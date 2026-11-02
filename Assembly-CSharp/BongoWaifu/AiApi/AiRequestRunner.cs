using System;
using System.Collections;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;
using UnityEngine.Networking;

namespace BongoWaifu.AiApi
{
	// Token: 0x02000170 RID: 368
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class AiRequestRunner : MonoBehaviour
	{
		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x00079363 File Offset: 0x00077563
		public static AiRequestRunner Instance
		{
			get
			{
				if (AiRequestRunner._instance == null)
				{
					GameObject gameObject = new GameObject("[AiRequestRunner]");
					global::UnityEngine.Object.DontDestroyOnLoad(gameObject);
					gameObject.hideFlags = HideFlags.HideAndDontSave;
					AiRequestRunner._instance = gameObject.AddComponent<AiRequestRunner>();
				}
				return AiRequestRunner._instance;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x00079399 File Offset: 0x00077599
		public bool IsChatBusy
		{
			get
			{
				return this._chatCo != null;
			}
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x000793A4 File Offset: 0x000775A4
		public void SendChat(IAiChatAdapter adapter, AiProviderConfig cfg, string baseUrl, string apiKey, AiChatRequest req, int timeoutSec, Action<AiChatResult> onDone)
		{
			if (this._chatCo != null)
			{
				if (onDone != null)
				{
					onDone(AiChatResult.Fail(AiErrorKind.RateLimited, "busy"));
				}
				return;
			}
			int num = this._chatGeneration + 1;
			this._chatGeneration = num;
			int num2 = num;
			this._chatCo = base.StartCoroutine(this.ChatCo(num2, adapter, cfg, baseUrl, apiKey, req, timeoutSec, onDone));
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00079400 File Offset: 0x00077600
		private IEnumerator ChatCo(int gen, IAiChatAdapter adapter, AiProviderConfig cfg, string baseUrl, string apiKey, AiChatRequest req, int timeoutSec, Action<AiChatResult> onDone)
		{
			UnityWebRequest web;
			try
			{
				web = adapter.BuildChatRequest(cfg, baseUrl, apiKey, req);
			}
			catch
			{
				this._chatCo = null;
				if (onDone != null)
				{
					onDone(AiChatResult.Fail(AiErrorKind.BadResponse, a.emb()));
				}
				yield break;
			}
			this._chatReq = web;
			web.timeout = timeoutSec;
			yield return web.SendWebRequest();
			bool flag = gen != this._chatGeneration;
			AiChatResult aiChatResult = AiRequestRunner.BuildChatResult(adapter, web);
			if (this._chatReq == web)
			{
				this._chatReq = null;
			}
			this._chatCo = null;
			web.Dispose();
			if (!flag)
			{
				if (onDone != null)
				{
					onDone(aiChatResult);
				}
			}
			yield break;
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00079458 File Offset: 0x00077658
		private static AiChatResult BuildChatResult(IAiChatAdapter adapter, UnityWebRequest web)
		{
			if (web.result == UnityWebRequest.Result.ConnectionError && AiRequestRunner.IsTimeout(web))
			{
				return AiChatResult.Fail(AiErrorKind.Timeout, web.error);
			}
			string text = ((web.downloadHandler != null) ? web.downloadHandler.text : "");
			return adapter.ParseChatResponse(web.responseCode, text, web.result);
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x000794B4 File Offset: 0x000776B4
		public void CancelInFlight()
		{
			this._chatGeneration++;
			if (this._chatCo != null)
			{
				base.StopCoroutine(this._chatCo);
				this._chatCo = null;
			}
			if (this._chatReq != null)
			{
				try
				{
					this._chatReq.Abort();
				}
				catch
				{
				}
				this._chatReq.Dispose();
				this._chatReq = null;
			}
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00079524 File Offset: 0x00077724
		public void FetchModels(IAiChatAdapter adapter, AiProviderConfig cfg, string baseUrl, string apiKey, int timeoutSec, Action<AiModelList> onDone)
		{
			if (this._modelsCo != null)
			{
				if (onDone != null)
				{
					onDone(AiModelList.Fail(AiErrorKind.RateLimited, null));
				}
				return;
			}
			this._modelsCo = base.StartCoroutine(this.ModelsCo(adapter, cfg, baseUrl, apiKey, timeoutSec, onDone));
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00079567 File Offset: 0x00077767
		private IEnumerator ModelsCo(IAiChatAdapter adapter, AiProviderConfig cfg, string baseUrl, string apiKey, int timeoutSec, Action<AiModelList> onDone)
		{
			UnityWebRequest web;
			try
			{
				web = adapter.BuildModelsRequest(cfg, baseUrl, apiKey);
			}
			catch
			{
				this._modelsCo = null;
				if (onDone != null)
				{
					onDone(AiModelList.Fail(AiErrorKind.BadResponse, null));
				}
				yield break;
			}
			this._modelsReq = web;
			web.timeout = timeoutSec;
			yield return web.SendWebRequest();
			string text = ((web.downloadHandler != null) ? web.downloadHandler.text : a.tk());
			AiModelList aiModelList = adapter.ParseModelsResponse(web.responseCode, text, web.result);
			if (this._modelsReq == web)
			{
				this._modelsReq = null;
			}
			this._modelsCo = null;
			web.Dispose();
			if (onDone != null)
			{
				onDone(aiModelList);
			}
			yield break;
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x000795A3 File Offset: 0x000777A3
		private static bool IsTimeout(UnityWebRequest web)
		{
			return !string.IsNullOrEmpty(web.error) && web.error.IndexOf("time", StringComparison.OrdinalIgnoreCase) >= 0;
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x000795CC File Offset: 0x000777CC
		private void OnDestroy()
		{
			this.CancelInFlight();
			if (this._modelsCo != null)
			{
				base.StopCoroutine(this._modelsCo);
				this._modelsCo = null;
			}
			if (this._modelsReq != null)
			{
				try
				{
					this._modelsReq.Abort();
				}
				catch
				{
				}
				this._modelsReq.Dispose();
				this._modelsReq = null;
			}
			if (AiRequestRunner._instance == this)
			{
				AiRequestRunner._instance = null;
			}
		}

		// Token: 0x04000C7C RID: 3196
		[Nullable(2)]
		private static AiRequestRunner _instance;

		// Token: 0x04000C7D RID: 3197
		private int _chatGeneration;

		// Token: 0x04000C7E RID: 3198
		[Nullable(2)]
		private Coroutine _chatCo;

		// Token: 0x04000C7F RID: 3199
		[Nullable(2)]
		private UnityWebRequest _chatReq;

		// Token: 0x04000C80 RID: 3200
		[Nullable(2)]
		private Coroutine _modelsCo;

		// Token: 0x04000C81 RID: 3201
		[Nullable(2)]
		private UnityWebRequest _modelsReq;
	}
}
