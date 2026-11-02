using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine.Networking;

namespace BongoWaifu.AiApi
{
	// Token: 0x02000174 RID: 372
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class AnthropicAdapter : IAiChatAdapter
	{
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x0003AA83 File Offset: 0x00038C83
		public AiProviderId Id
		{
			get
			{
				return AiProviderId.Anthropic;
			}
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00079C84 File Offset: 0x00077E84
		public UnityWebRequest BuildChatRequest(AiProviderConfig cfg, string baseUrl, string apiKey, AiChatRequest req)
		{
			string text = AiHttp.TrimEndSlash(baseUrl) + cfg.ChatPath;
			JObject jobject = new JObject();
			jobject["model"] = req.Model;
			jobject["max_tokens"] = req.MaxTokens;
			string text2 = "messages";
			JArray jarray = new JArray();
			JObject jobject2 = new JObject();
			jobject2["role"] = "user";
			jobject2["content"] = req.UserMessage;
			jarray.Add(jobject2);
			jobject[text2] = jarray;
			JObject jobject3 = jobject;
			if (!string.IsNullOrEmpty(req.SystemPrompt))
			{
				jobject3["system"] = req.SystemPrompt;
			}
			if (req.Temperature >= 0f)
			{
				jobject3["temperature"] = req.Temperature;
			}
			UnityWebRequest unityWebRequest = AiHttp.PostJson(text, jobject3.ToString(Formatting.None, Array.Empty<JsonConverter>()));
			unityWebRequest.SetRequestHeader("x-api-key", apiKey);
			AiHttp.ApplyExtraHeaders(unityWebRequest, cfg);
			return unityWebRequest;
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x00079D8C File Offset: 0x00077F8C
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
				JArray jarray = JObject.Parse(body)["content"] as JArray;
				string text = null;
				if (jarray != null)
				{
					foreach (JToken jtoken in jarray)
					{
						if ((string)jtoken["type"] == "text")
						{
							text = (string)jtoken["text"];
							break;
						}
					}
				}
				if (string.IsNullOrWhiteSpace(text))
				{
					aiChatResult = AiChatResult.Fail(AiErrorKind.BadResponse, AiHttp.Trunc(body, 4000));
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

		// Token: 0x06001876 RID: 6262 RVA: 0x00079E88 File Offset: 0x00078088
		public UnityWebRequest BuildModelsRequest(AiProviderConfig cfg, string baseUrl, string apiKey)
		{
			UnityWebRequest json = AiHttp.GetJson(AiHttp.TrimEndSlash(baseUrl) + cfg.ModelsPath);
			json.SetRequestHeader("x-api-key", apiKey);
			AiHttp.ApplyExtraHeaders(json, cfg);
			return json;
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00079EB4 File Offset: 0x000780B4
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
