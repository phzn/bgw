using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine.Networking;

namespace BongoWaifu.AiApi
{
	// Token: 0x02000177 RID: 375
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class GeminiAdapter : IAiChatAdapter
	{
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x0007AB8F File Offset: 0x00078D8F
		public AiProviderId Id
		{
			get
			{
				return AiProviderId.Gemini;
			}
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0007AB94 File Offset: 0x00078D94
		public UnityWebRequest BuildChatRequest(AiProviderConfig cfg, string baseUrl, string apiKey, AiChatRequest req)
		{
			string text = req.Model;
			if (!text.StartsWith("models/"))
			{
				text = "models/" + text;
			}
			string text2 = string.Concat(new string[]
			{
				AiHttp.TrimEndSlash(baseUrl),
				cfg.ChatPath,
				"/",
				text,
				":generateContent"
			});
			JObject jobject = new JObject();
			string text3 = "systemInstruction";
			JObject jobject2 = new JObject();
			string text4 = "parts";
			JArray jarray = new JArray();
			JObject jobject3 = new JObject();
			jobject3["text"] = req.SystemPrompt;
			jarray.Add(jobject3);
			jobject2[text4] = jarray;
			jobject[text3] = jobject2;
			string text5 = "contents";
			JArray jarray2 = new JArray();
			JObject jobject4 = new JObject();
			jobject4["role"] = "user";
			string text6 = "parts";
			JArray jarray3 = new JArray();
			JObject jobject5 = new JObject();
			jobject5["text"] = req.UserMessage;
			jarray3.Add(jobject5);
			jobject4[text6] = jarray3;
			jarray2.Add(jobject4);
			jobject[text5] = jarray2;
			string text7 = "generationConfig";
			JObject jobject6 = new JObject();
			jobject6["maxOutputTokens"] = req.MaxTokens;
			jobject[text7] = jobject6;
			JObject jobject7 = jobject;
			if (req.Temperature >= 0f)
			{
				((JObject)jobject7["generationConfig"])["temperature"] = req.Temperature;
			}
			UnityWebRequest unityWebRequest = AiHttp.PostJson(text2, jobject7.ToString(Formatting.None, Array.Empty<JsonConverter>()));
			unityWebRequest.SetRequestHeader("x-goog-api-key", apiKey);
			AiHttp.ApplyExtraHeaders(unityWebRequest, cfg);
			return unityWebRequest;
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x0007AD1C File Offset: 0x00078F1C
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
				JObject jobject = JObject.Parse(body);
				string text = null;
				JToken jtoken = jobject["candidates"];
				object obj;
				if (jtoken == null)
				{
					obj = null;
				}
				else
				{
					JToken jtoken2 = jtoken[0];
					if (jtoken2 == null)
					{
						obj = null;
					}
					else
					{
						JToken jtoken3 = jtoken2["content"];
						obj = ((jtoken3 != null) ? jtoken3["parts"] : null);
					}
				}
				JArray jarray = obj as JArray;
				if (jarray != null)
				{
					foreach (JToken jtoken4 in jarray)
					{
						if (jtoken4 != null)
						{
							JToken jtoken5 = jtoken4["thought"];
							bool? flag = ((jtoken5 != null) ? jtoken5.Value<bool?>() : null);
							bool flag2 = true;
							if ((flag.GetValueOrDefault() == flag2) & (flag != null))
							{
								continue;
							}
						}
						string text2 = (string)((jtoken4 != null) ? jtoken4["text"] : null);
						if (!string.IsNullOrEmpty(text2))
						{
							text = text2;
							break;
						}
					}
				}
				if (string.IsNullOrWhiteSpace(text))
				{
					JToken jtoken6 = jobject["promptFeedback"];
					string text3 = (string)((jtoken6 != null) ? jtoken6["blockReason"] : null);
					JToken jtoken7 = jobject["candidates"];
					JToken jtoken8;
					if (jtoken7 == null)
					{
						jtoken8 = null;
					}
					else
					{
						JToken jtoken9 = jtoken7[0];
						jtoken8 = ((jtoken9 != null) ? jtoken9["finishReason"] : null);
					}
					string text4 = (string)jtoken8;
					string text5;
					if ((text5 = text3) == null)
					{
						text5 = text4 ?? AiHttp.Trunc(body, 4000);
					}
					string text6 = text5;
					aiChatResult = AiChatResult.Fail(AiErrorKind.BadResponse, text6);
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

		// Token: 0x060018AA RID: 6314 RVA: 0x0007AF0C File Offset: 0x0007910C
		public UnityWebRequest BuildModelsRequest(AiProviderConfig cfg, string baseUrl, string apiKey)
		{
			UnityWebRequest json = AiHttp.GetJson(AiHttp.TrimEndSlash(baseUrl) + cfg.ModelsPath);
			json.SetRequestHeader("x-goog-api-key", apiKey);
			AiHttp.ApplyExtraHeaders(json, cfg);
			return json;
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x0007AF38 File Offset: 0x00079138
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
				JArray jarray = JObject.Parse(body)["models"] as JArray;
				List<string> list = new List<string>();
				if (jarray != null)
				{
					foreach (JToken jtoken in jarray)
					{
						JArray jarray2 = jtoken["supportedGenerationMethods"] as JArray;
						bool flag = jarray2 == null;
						if (jarray2 != null)
						{
							using (IEnumerator<JToken> enumerator2 = jarray2.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									if ((string)enumerator2.Current == "generateContent")
									{
										flag = true;
										break;
									}
								}
							}
						}
						if (flag)
						{
							string text = (string)jtoken["name"];
							if (!string.IsNullOrEmpty(text))
							{
								if (text.StartsWith("models/"))
								{
									text = text.Substring("models/".Length);
								}
								if (AiModelFilter.IsLikelyChatModel(text))
								{
									list.Add(text);
								}
							}
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
