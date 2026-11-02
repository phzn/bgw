using System;
using System.Runtime.CompilerServices;
using System.Text;
using BongoWaifu.Mcp;
using BongoWaifu.Mcp.SpeechBubble;
using BongoWaifu.Mcp.Text;
using UnityEngine;

namespace BongoWaifu.AiApi
{
	// Token: 0x02000175 RID: 373
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class DirectApiScheduler : MonoBehaviour
	{
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x00079F98 File Offset: 0x00078198
		public static DirectApiScheduler Instance
		{
			get
			{
				return DirectApiScheduler._instance;
			}
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x00079F9F File Offset: 0x0007819F
		[NullableContext(1)]
		public static DirectApiScheduler EnsureInstance()
		{
			if (DirectApiScheduler._instance == null)
			{
				GameObject gameObject = new GameObject("[DirectApiScheduler]");
				global::UnityEngine.Object.DontDestroyOnLoad(gameObject);
				gameObject.hideFlags = HideFlags.HideAndDontSave;
				DirectApiScheduler._instance = gameObject.AddComponent<DirectApiScheduler>();
			}
			return DirectApiScheduler._instance;
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00079FD5 File Offset: 0x000781D5
		private void Awake()
		{
			if (DirectApiScheduler._instance != null && DirectApiScheduler._instance != this)
			{
				global::UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			DirectApiScheduler._instance = this;
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x0007A003 File Offset: 0x00078203
		private void OnDestroy()
		{
			if (this._enabled)
			{
				this.Disable();
			}
			if (DirectApiScheduler._instance == this)
			{
				DirectApiScheduler._instance = null;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x0007A026 File Offset: 0x00078226
		public bool IsEnabled
		{
			get
			{
				return this._enabled;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x0007A02E File Offset: 0x0007822E
		// (set) Token: 0x0600187F RID: 6271 RVA: 0x0007A036 File Offset: 0x00078236
		public bool HasRunResult { get; private set; }

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x0007A03F File Offset: 0x0007823F
		// (set) Token: 0x06001881 RID: 6273 RVA: 0x0007A047 File Offset: 0x00078247
		public bool LastOk { get; private set; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x0007A050 File Offset: 0x00078250
		// (set) Token: 0x06001883 RID: 6275 RVA: 0x0007A058 File Offset: 0x00078258
		public AiErrorKind LastError { get; private set; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x0007A061 File Offset: 0x00078261
		// (set) Token: 0x06001885 RID: 6277 RVA: 0x0007A069 File Offset: 0x00078269
		public string LastDetail { get; private set; }

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x06001886 RID: 6278 RVA: 0x0007A074 File Offset: 0x00078274
		// (remove) Token: 0x06001887 RID: 6279 RVA: 0x0007A0A8 File Offset: 0x000782A8
		public static event Action OnRuntimeStatusChanged;

		// Token: 0x06001888 RID: 6280 RVA: 0x0007A0DC File Offset: 0x000782DC
		public void Enable()
		{
			if (this._enabled)
			{
				return;
			}
			this._bubble = global::UnityEngine.Object.FindObjectOfType<SpeechBubbleController>(true);
			this._queue = new DialogueQueue();
			if (this._bubble != null)
			{
				this._bubble.Queue = this._queue;
			}
			this._backoffUntil = 0f;
			this._lastCallAt = -9999f;
			this._hotArmedLevel = ((GirlController.kok != null) ? DirectApiScheduler.HotLevelOf(GirlController.kok.kog) : 0);
			this._enabled = true;
			this.ScheduleNextIdle();
			ClotheItem.hue += this.OnOutfitChangedEvent;
			by.hol += this.OnItemDropEvent;
			bx.hoi += this.OnPlayerInteractedEvent;
			du.iaf += this.OnAchievementEvent;
			du.cem(du.STEAM_STAT_ID.STAT_ORGASM, new Action<du.StatUpdatedEventArgs>(this.OnOrgasmStat));
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x0007A1C8 File Offset: 0x000783C8
		public void Disable()
		{
			if (!this._enabled)
			{
				return;
			}
			this._enabled = false;
			ClotheItem.hue -= this.OnOutfitChangedEvent;
			by.hol -= this.OnItemDropEvent;
			bx.hoi -= this.OnPlayerInteractedEvent;
			du.iaf -= this.OnAchievementEvent;
			du.cen(du.STEAM_STAT_ID.STAT_ORGASM, new Action<du.StatUpdatedEventArgs>(this.OnOrgasmStat));
			AiRequestRunner.Instance.CancelInFlight();
			if (this._bubble != null)
			{
				this._bubble.Queue = null;
				this._bubble.ForceHideAndDismissCurrent();
			}
			this._queue = null;
			this._pendingGreet = false;
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x0007A278 File Offset: 0x00078478
		private void Update()
		{
			if (!this._enabled)
			{
				return;
			}
			float unscaledTime = Time.unscaledTime;
			if (this._pendingGreet && unscaledTime >= this._greetAt)
			{
				this._pendingGreet = false;
				this.TriggerLine(AiTriggerKind.Launch, null, true);
			}
			if (unscaledTime >= this._nextIdleAt)
			{
				if (unscaledTime - this._lastInteractAt >= 20f)
				{
					this.TriggerLine(AiTriggerKind.IdleChatter, null, false);
				}
				this.ScheduleNextIdle();
			}
			this.PollHot();
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x0007A2E4 File Offset: 0x000784E4
		public void TalkNow()
		{
			DirectApiScheduler.TriggerBlockReason triggerBlockReason = this.TriggerLine(AiTriggerKind.Manual, null, true);
			if (triggerBlockReason != DirectApiScheduler.TriggerBlockReason.None)
			{
				this.ShowModalMessage(AiLoc.Get("UI_Setting_AI_ConnectionMode_Title", "AI Connection"), this.DescribeBlock(triggerBlockReason));
			}
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0007A31A File Offset: 0x0007851A
		public void ScheduleLaunchGreeting()
		{
			this._pendingGreet = true;
			this._greetAt = Time.unscaledTime + 4f;
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x0007A334 File Offset: 0x00078534
		public void NotifyInteraction()
		{
			this._lastInteractAt = Time.unscaledTime;
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x0007A341 File Offset: 0x00078541
		private void OnOutfitChangedEvent()
		{
			this.TriggerLine(AiTriggerKind.OutfitChange, null, false);
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0007A34D File Offset: 0x0007854D
		[NullableContext(1)]
		private void OnItemDropEvent(string itemName)
		{
			this.TriggerLine(AiTriggerKind.ItemDrop, itemName, false);
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0007A359 File Offset: 0x00078559
		private void OnPlayerInteractedEvent()
		{
			this.NotifyInteraction();
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0007A361 File Offset: 0x00078561
		private void OnAchievementEvent(du.ACHIEVEMENT a)
		{
			this.TriggerLine(AiTriggerKind.Achievement, a.ToString(), false);
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x0007A379 File Offset: 0x00078579
		[NullableContext(1)]
		private void OnOrgasmStat(du.StatUpdatedEventArgs e)
		{
			if (e != null && e.newValue > e.oldValue)
			{
				this.TriggerLine(AiTriggerKind.OrgasmMilestone, null, false);
			}
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x0007A398 File Offset: 0x00078598
		private void PollHot()
		{
			GirlController girlController = GirlController.kok;
			if (girlController == null)
			{
				return;
			}
			float num = girlController.kog;
			int num2 = DirectApiScheduler.HotLevelOf(num);
			if (num2 > this._hotArmedLevel)
			{
				if (this.TriggerLine(AiTriggerKind.HotMilestone, "level " + num2.ToString(), false) == DirectApiScheduler.TriggerBlockReason.None)
				{
					this._hotArmedLevel = num2;
					return;
				}
			}
			else if (num2 < this._hotArmedLevel && num < DirectApiScheduler.HotEntryThreshold(this._hotArmedLevel) - 5f)
			{
				this._hotArmedLevel = num2;
			}
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x0007A413 File Offset: 0x00078613
		private static int HotLevelOf(float hot)
		{
			if (hot >= 75f)
			{
				return 3;
			}
			if (hot >= 50f)
			{
				return 2;
			}
			if (hot < 25f)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x0007A434 File Offset: 0x00078634
		private static float HotEntryThreshold(int level)
		{
			if (level >= 3)
			{
				return 75f;
			}
			if (level == 2)
			{
				return 50f;
			}
			if (level != 1)
			{
				return 0f;
			}
			return 25f;
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x0007A45C File Offset: 0x0007865C
		private void ScheduleNextIdle()
		{
			int num = ((bq.hlf != null && bq.hlf.playerSaveData != null) ? bq.hlf.playerSaveData.directApiChattinessTier : 1);
			float num2;
			float num3;
			if (num != 0)
			{
				if (num != 2)
				{
					num2 = 5f;
					num3 = 8f;
				}
				else
				{
					num2 = 2f;
					num3 = 4f;
				}
			}
			else
			{
				num2 = 10f;
				num3 = 15f;
			}
			float num4 = global::UnityEngine.Random.Range(num2, num3) * 60f;
			this._nextIdleAt = Time.unscaledTime + num4;
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x0007A4E4 File Offset: 0x000786E4
		[NullableContext(1)]
		private static string ReasonLocKey(DirectApiScheduler.TriggerBlockReason reason)
		{
			switch (reason)
			{
			case DirectApiScheduler.TriggerBlockReason.QuotaHour:
				return "aiconn_sys_quota";
			case DirectApiScheduler.TriggerBlockReason.QuotaDay:
				return "aiconn_sys_quota";
			case DirectApiScheduler.TriggerBlockReason.NoModel:
				return "aiconn_sys_no_model";
			case DirectApiScheduler.TriggerBlockReason.NoKey:
				return "aiconn_status_no_key";
			}
			return "aiconn_sys_busy";
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x0007A538 File Offset: 0x00078738
		[NullableContext(1)]
		private string DescribeBlock(DirectApiScheduler.TriggerBlockReason reason)
		{
			string text;
			switch (reason)
			{
			case DirectApiScheduler.TriggerBlockReason.QuotaHour:
				text = "Reached the chat limit for now.";
				goto IL_0044;
			case DirectApiScheduler.TriggerBlockReason.QuotaDay:
				text = "Reached the chat limit for now.";
				goto IL_0044;
			case DirectApiScheduler.TriggerBlockReason.NoModel:
				text = "Pick a model first.";
				goto IL_0044;
			case DirectApiScheduler.TriggerBlockReason.NoKey:
				text = "No API key — enter one above.";
				goto IL_0044;
			}
			text = "Still thinking… try again in a moment.";
			IL_0044:
			string text2 = text;
			return AiLoc.Get(DirectApiScheduler.ReasonLocKey(reason), text2);
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x0007A598 File Offset: 0x00078798
		private DirectApiScheduler.TriggerBlockReason TriggerLine(AiTriggerKind kind, string detail, bool bypassGap)
		{
			if (!this._enabled || this._queue == null)
			{
				return DirectApiScheduler.TriggerBlockReason.NotEnabled;
			}
			float unscaledTime = Time.unscaledTime;
			AiRequestRunner instance = AiRequestRunner.Instance;
			if (instance.IsChatBusy)
			{
				return DirectApiScheduler.TriggerBlockReason.Busy;
			}
			if (kind != AiTriggerKind.Manual && unscaledTime < this._backoffUntil)
			{
				return DirectApiScheduler.TriggerBlockReason.Backoff;
			}
			if (!bypassGap && unscaledTime - this._lastCallAt < 30f)
			{
				return DirectApiScheduler.TriggerBlockReason.MinGap;
			}
			PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
			if (playerSaveData == null)
			{
				return DirectApiScheduler.TriggerBlockReason.NoSave;
			}
			AiProviderId directApiProviderId = (AiProviderId)playerSaveData.directApiProviderId;
			AiProviderConfig aiProviderConfig = AiProviderCatalog.For(directApiProviderId);
			string directApiModel = playerSaveData.directApiModel;
			if (string.IsNullOrEmpty(directApiModel))
			{
				Debug.Log("[DirectApiScheduler] 未選模型，略過。");
				return DirectApiScheduler.TriggerBlockReason.NoModel;
			}
			string text = ((aiProviderConfig.AllowsCustomBaseUrl && !string.IsNullOrEmpty(playerSaveData.directApiBaseUrl)) ? playerSaveData.directApiBaseUrl : aiProviderConfig.DefaultBaseUrl);
			string keyForRequestSafely = this.GetKeyForRequestSafely((int)directApiProviderId);
			if (string.IsNullOrEmpty(keyForRequestSafely))
			{
				this.LogNoKeySkipped();
				return DirectApiScheduler.TriggerBlockReason.NoKey;
			}
			ValueTuple<string, string> valueTuple = AiPromptComposer.Build(DirectApiScheduler.ResolveTemplate(playerSaveData), kind, detail);
			string item = valueTuple.Item1;
			string item2 = valueTuple.Item2;
			IAiChatAdapter aiChatAdapter = AiAdapterFactory.Create(directApiProviderId);
			AiChatRequest aiChatRequest = new AiChatRequest(directApiModel, item, item2, 2048, -1f);
			this._inflightKind = kind;
			this._lastCallAt = unscaledTime;
			instance.SendChat(aiChatAdapter, aiProviderConfig, text, keyForRequestSafely, aiChatRequest, 20, new Action<AiChatResult>(this.OnChatDone));
			return DirectApiScheduler.TriggerBlockReason.None;
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x0007A6E8 File Offset: 0x000788E8
		private string GetKeyForRequestSafely(int providerId)
		{
			string text;
			try
			{
				text = AiSecretStore.GetKeyForRequest(providerId);
			}
			catch (Exception ex)
			{
				if (Time.unscaledTime - this._lastKeyReadErrorLogAt >= 60f)
				{
					this._lastKeyReadErrorLogAt = Time.unscaledTime;
					string text2 = "[DirectApiScheduler] AiSecretStore.GetKeyForRequest failed; treating API key as unavailable.\n";
					Exception ex2 = ex;
					Debug.LogError(text2 + ((ex2 != null) ? ex2.ToString() : null));
				}
				text = null;
			}
			return text;
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x0007A750 File Offset: 0x00078950
		private void LogNoKeySkipped()
		{
			if (Time.unscaledTime - this._lastNoKeyLogAt < 60f)
			{
				return;
			}
			this._lastNoKeyLogAt = Time.unscaledTime;
			Debug.Log("[DirectApiScheduler] 無金鑰，略過。");
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x0007A77C File Offset: 0x0007897C
		[NullableContext(1)]
		private void OnChatDone(AiChatResult res)
		{
			if (!this._enabled || this._queue == null)
			{
				return;
			}
			if (res.Ok && !string.IsNullOrWhiteSpace(res.Text))
			{
				this.SetRuntimeStatus(true, AiErrorKind.None, null);
				this._lastBgErrorWindow = AiErrorKind.None;
				string text = DirectApiScheduler.PostProcess(res.Text);
				if (text.Length == 0)
				{
					return;
				}
				float num = DurationCalculator.Compute(text, null);
				DialogueMessage dialogueMessage = new DialogueMessage(Guid.NewGuid().ToString(), MessageKind.Say, "directapi", text, num, null, null, DateTime.UtcNow);
				this._queue.Enqueue(dialogueMessage);
				return;
			}
			else
			{
				this.SetRuntimeStatus(false, res.Error, res.RawDetail);
				if (this._inflightKind != AiTriggerKind.Manual)
				{
					this._backoffUntil = Time.unscaledTime + 60f;
				}
				Debug.Log(string.Format("[DirectApiScheduler] 請求失敗：{0}", res.Error) + (string.IsNullOrEmpty(res.RawDetail) ? "" : (" 詳情：" + res.RawDetail)));
				if (this._inflightKind == AiTriggerKind.Manual)
				{
					this.ShowApiError(res.Error, res.RawDetail);
					return;
				}
				if (res.Error != this._lastBgErrorWindow)
				{
					this._lastBgErrorWindow = res.Error;
					this.ShowApiError(res.Error, res.RawDetail);
				}
				return;
			}
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x0007A8D4 File Offset: 0x00078AD4
		[NullableContext(1)]
		public void ShowModalMessage(string title, string body)
		{
			if (string.IsNullOrEmpty(title) && string.IsNullOrEmpty(body))
			{
				return;
			}
			string text = (string.IsNullOrEmpty(title) ? AiLoc.Get("UI_Setting_AI_ConnectionMode_Title", "AI Connection") : title);
			string text2 = (string.IsNullOrEmpty(body) ? text : body);
			if (ModalDialogManager.kri && !ModalDialogManager.icb.krh)
			{
				ModalDialogManager.icb.ShowMessage(text, text2, null);
			}
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x0007A93A File Offset: 0x00078B3A
		public void ShowApiError(AiErrorKind err, string rawDetail)
		{
			this.ShowModalMessage(AiLoc.DescribeError(err), string.IsNullOrEmpty(rawDetail) ? AiLoc.DescribeError(err) : rawDetail);
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0007A959 File Offset: 0x00078B59
		private void SetRuntimeStatus(bool ok, AiErrorKind err, string detail)
		{
			this.HasRunResult = true;
			this.LastOk = ok;
			this.LastError = err;
			this.LastDetail = detail;
			DirectApiScheduler.RaiseRuntimeStatusChanged();
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0007A97C File Offset: 0x00078B7C
		public void ResetRuntimeStatus()
		{
			this.HasRunResult = false;
			this.LastOk = false;
			this.LastError = AiErrorKind.None;
			this.LastDetail = null;
			DirectApiScheduler.RaiseRuntimeStatusChanged();
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0007A9A0 File Offset: 0x00078BA0
		private static void RaiseRuntimeStatusChanged()
		{
			Action onRuntimeStatusChanged = DirectApiScheduler.OnRuntimeStatusChanged;
			if (onRuntimeStatusChanged == null)
			{
				return;
			}
			try
			{
				onRuntimeStatusChanged();
			}
			catch (Exception ex)
			{
				Debug.LogWarning("[DirectApiScheduler] OnRuntimeStatusChanged 訂閱者拋例外：" + ex.GetType().Name);
			}
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0007A9F0 File Offset: 0x00078BF0
		[NullableContext(1)]
		private static string ResolveTemplate(PlayerSaveData save)
		{
			if (save.directApiTemplateCustomized && !string.IsNullOrWhiteSpace(save.directApiPromptTemplate))
			{
				return save.directApiPromptTemplate;
			}
			return AiPromptComposer.GetLocalizedDefaultTemplate();
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0007AA14 File Offset: 0x00078C14
		[NullableContext(1)]
		private static string PostProcess(string raw)
		{
			string text = raw.Trim();
			int num = text.IndexOf('\n');
			if (num >= 0)
			{
				text = text.Substring(0, num).Trim();
			}
			text = DirectApiScheduler.StripWrappingQuotes(text);
			return DirectApiScheduler.ClampDisplayWidth(text, 400);
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0007AA58 File Offset: 0x00078C58
		[NullableContext(1)]
		private static string StripWrappingQuotes(string s)
		{
			if (s.Length >= 2)
			{
				char c = s[0];
				char c2 = s[s.Length - 1];
				if ((c == '"' && c2 == '"') || (c == '\'' && c2 == '\'') || (c == '“' && c2 == '”') || (c == '「' && c2 == '」') || (c == '『' && c2 == '』'))
				{
					return s.Substring(1, s.Length - 2).Trim();
				}
			}
			return s;
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0007AAE8 File Offset: 0x00078CE8
		[NullableContext(1)]
		private static string ClampDisplayWidth(string s, int max)
		{
			if (DisplayWidth.Measure(s) <= max)
			{
				return s;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			foreach (char c in s)
			{
				int num2 = DisplayWidth.Measure(c.ToString());
				if (num + num2 > max - 1)
				{
					break;
				}
				stringBuilder.Append(c);
				num += num2;
			}
			stringBuilder.Append('…');
			return stringBuilder.ToString();
		}

		// Token: 0x04000C9C RID: 3228
		private static DirectApiScheduler _instance;

		// Token: 0x04000C9D RID: 3229
		private const float GlobalMinGapSec = 30f;

		// Token: 0x04000C9E RID: 3230
		private const int RequestTimeoutSec = 20;

		// Token: 0x04000C9F RID: 3231
		private const float BackoffSec = 60f;

		// Token: 0x04000CA0 RID: 3232
		private const int MaxTokens = 2048;

		// Token: 0x04000CA1 RID: 3233
		private const float Temperature = -1f;

		// Token: 0x04000CA2 RID: 3234
		private const float IdleSuppressAfterInteractSec = 20f;

		// Token: 0x04000CA3 RID: 3235
		private const float HotHysteresisMargin = 5f;

		// Token: 0x04000CA4 RID: 3236
		private const float LaunchGreetDelaySec = 4f;

		// Token: 0x04000CA5 RID: 3237
		private bool _enabled;

		// Token: 0x04000CA6 RID: 3238
		private SpeechBubbleController _bubble;

		// Token: 0x04000CA7 RID: 3239
		private DialogueQueue _queue;

		// Token: 0x04000CA8 RID: 3240
		private float _nextIdleAt;

		// Token: 0x04000CA9 RID: 3241
		private float _lastCallAt = -9999f;

		// Token: 0x04000CAA RID: 3242
		private float _lastInteractAt = -9999f;

		// Token: 0x04000CAB RID: 3243
		private float _backoffUntil;

		// Token: 0x04000CAC RID: 3244
		private float _lastKeyReadErrorLogAt = -9999f;

		// Token: 0x04000CAD RID: 3245
		private float _lastNoKeyLogAt = -9999f;

		// Token: 0x04000CAE RID: 3246
		private AiTriggerKind _inflightKind;

		// Token: 0x04000CAF RID: 3247
		private int _hotArmedLevel;

		// Token: 0x04000CB0 RID: 3248
		private bool _pendingGreet;

		// Token: 0x04000CB1 RID: 3249
		private float _greetAt;

		// Token: 0x04000CB7 RID: 3255
		private AiErrorKind _lastBgErrorWindow;

		// Token: 0x02000176 RID: 374
		[NullableContext(0)]
		private enum TriggerBlockReason
		{
			// Token: 0x04000CB9 RID: 3257
			None,
			// Token: 0x04000CBA RID: 3258
			NotEnabled,
			// Token: 0x04000CBB RID: 3259
			Busy,
			// Token: 0x04000CBC RID: 3260
			Backoff,
			// Token: 0x04000CBD RID: 3261
			MinGap,
			// Token: 0x04000CBE RID: 3262
			QuotaHour,
			// Token: 0x04000CBF RID: 3263
			QuotaDay,
			// Token: 0x04000CC0 RID: 3264
			NoSave,
			// Token: 0x04000CC1 RID: 3265
			NoModel,
			// Token: 0x04000CC2 RID: 3266
			NoKey
		}
	}
}
