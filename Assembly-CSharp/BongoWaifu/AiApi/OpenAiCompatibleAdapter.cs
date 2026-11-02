using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine.Networking;

namespace BongoWaifu.AiApi
{
	// Token: 0x0200017E RID: 382
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class OpenAiCompatibleAdapter : IAiChatAdapter
	{
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x0007BB9A File Offset: 0x00079D9A
		public AiProviderId Id { get; }

		// Token: 0x060018FB RID: 6395 RVA: 0x0007BBA2 File Offset: 0x00079DA2
		public OpenAiCompatibleAdapter(AiProviderId id)
		{
			this.Id = id;
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x0007BBB4 File Offset: 0x00079DB4
		public UnityWebRequest BuildChatRequest(AiProviderConfig cfg, string baseUrl, string apiKey, AiChatRequest req)
		{
			string text = AiHttp.TrimEndSlash(baseUrl) + cfg.ChatPath;
			JObject jobject = new JObject();
			jobject["model"] = req.Model;
			string text2 = "messages";
			JArray jarray = new JArray();
			JObject jobject2 = new JObject();
			jobject2["role"] = "system";
			jobject2["content"] = req.SystemPrompt;
			jarray.Add(jobject2);
			JObject jobject3 = new JObject();
			jobject3["role"] = "user";
			jobject3["content"] = req.UserMessage;
			jarray.Add(jobject3);
			jobject[text2] = jarray;
			JObject jobject4 = jobject;
			jobject4[(this.Id == AiProviderId.OpenAI) ? "max_completion_tokens" : "max_tokens"] = req.MaxTokens;
			if (req.Temperature >= 0f)
			{
				jobject4["temperature"] = req.Temperature;
			}
			UnityWebRequest unityWebRequest = AiHttp.PostJson(text, jobject4.ToString(Formatting.None, Array.Empty<JsonConverter>()));
			unityWebRequest.SetRequestHeader("Authorization", "Bearer " + apiKey);
			AiHttp.ApplyExtraHeaders(unityWebRequest, cfg);
			return unityWebRequest;
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x0007BCE8 File Offset: 0x00079EE8
		public AiChatResult ParseChatResponse(long httpStatus, string body, UnityWebRequest.Result result)
		{
			AiErrorKind aiErrorKind = AiHttp.Classify(httpStatus, result);
			if (aiErrorKind != AiErrorKind.None)
			{
				return AiChatResult.Fail(aiErrorKind, AiHttp.Trunc(body, 4000));
			}
			AiChatResult aiChatResult;
			try
			{
				JToken jtoken = JObject.Parse(body)["choices"];
				JToken jtoken2 = ((jtoken != null) ? jtoken[0] : null);
				JToken jtoken3;
				if (jtoken2 == null)
				{
					jtoken3 = null;
				}
				else
				{
					JToken jtoken4 = jtoken2["message"];
					jtoken3 = ((jtoken4 != null) ? jtoken4["content"] : null);
				}
				string text = (string)jtoken3;
				if (string.IsNullOrWhiteSpace(text))
				{
					string text2 = (((string)((jtoken2 != null) ? jtoken2["finish_reason"] : null) == "length") ? "output truncated — token budget exhausted (raise max tokens; reasoning model?)" : AiHttp.Trunc(body, 4000));
					aiChatResult = AiChatResult.Fail(AiErrorKind.BadResponse, text2);
				}
				else
				{
					aiChatResult = AiChatResult.Success(text.Trim());
				}
			}
			catch
			{
				aiChatResult = AiChatResult.Fail(AiErrorKind.BadResponse, AiHttp.Trunc(body, 4000));
			}
			return aiChatResult;
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x0007BDE0 File Offset: 0x00079FE0
		public UnityWebRequest BuildModelsRequest(AiProviderConfig cfg, string baseUrl, string apiKey)
		{
			UnityWebRequest json = AiHttp.GetJson(AiHttp.TrimEndSlash(baseUrl) + cfg.ModelsPath);
			json.SetRequestHeader("Authorization", "Bearer " + apiKey);
			AiHttp.ApplyExtraHeaders(json, cfg);
			return json;
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x0007BE18 File Offset: 0x0007A018
		public AiModelList ParseModelsResponse(long httpStatus, string body, UnityWebRequest.Result result)
		{
			AiErrorKind aiErrorKind = AiHttp.Classify(httpStatus, result);
			if (aiErrorKind != AiErrorKind.None)
			{
				return AiModelList.Fail(aiErrorKind, AiHttp.Trunc(body, 4000));
			}
			AiModelList aiModelList;
			try
			{
				JArray jarray = JObject.Parse(body)["data"] as JArray;
				List<string> list = new List<string>();
				if (jarray != null)
				{
					foreach (JToken jtoken in jarray)
					{
						string text = (string)jtoken["id"];
						if (!string.IsNullOrEmpty(text) && AiModelFilter.IsLikelyChatModel(text))
						{
							list.Add(text);
						}
					}
				}
				list.Sort(StringComparer.OrdinalIgnoreCase);
				aiModelList = AiModelList.Success(list);
			}
			catch
			{
				aiModelList = AiModelList.Fail(AiErrorKind.BadResponse, AiHttp.Trunc(body, 4000));
			}
			return aiModelList;
		}
	}
}
