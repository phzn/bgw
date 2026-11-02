using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using FMODUnity;
using Rewired;
using UnityEngine;

namespace BongoWaifu.Mcp.SpeechBubble
{
	// Token: 0x0200015F RID: 351
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class SpeechBubbleController : MonoBehaviour
	{
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x00077C38 File Offset: 0x00075E38
		// (set) Token: 0x06001800 RID: 6144 RVA: 0x00077C40 File Offset: 0x00075E40
		public DialogueQueue Queue { get; set; }

		// Token: 0x06001801 RID: 6145 RVA: 0x00077C4C File Offset: 0x00075E4C
		private void Awake()
		{
			if (ReInput.isReady)
			{
				this._rewiredPlayer = ReInput.players.GetPlayer(this.rewiredPlayerId);
			}
			this.view.OnButtonClicked += this.OnButtonClicked;
			this.view.OnCloseClicked += this.OnCloseClicked;
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00077CA4 File Offset: 0x00075EA4
		private void OnDestroy()
		{
			if (this.view != null)
			{
				this.view.OnButtonClicked -= this.OnButtonClicked;
				this.view.OnCloseClicked -= this.OnCloseClicked;
			}
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00077CE4 File Offset: 0x00075EE4
		private void Update()
		{
			if (this._previewActive)
			{
				this._previewRemaining -= Time.unscaledDeltaTime;
				if (this._previewRemaining <= 0f)
				{
					this._previewActive = false;
					if (this._currentlyShowing != null)
					{
						if (this._currentlyShowing.Kind == MessageKind.Say)
						{
							this.view.ShowSay(this._currentlyShowing.Text);
							return;
						}
						if (this._currentlyShowing.Buttons != null)
						{
							this.view.ShowAsk(this._currentlyShowing.Text, this._currentlyShowing.Buttons);
							return;
						}
						this.view.ShowSay(this._currentlyShowing.Text);
						return;
					}
					else
					{
						this.view.Hide();
					}
				}
				return;
			}
			if (this.Queue == null)
			{
				return;
			}
			if (this._currentlyShowing != null && this._rewiredPlayer != null && this._rewiredPlayer.GetButtonDown("UICancel"))
			{
				this.DismissCurrent();
				return;
			}
			if (this._currentlyShowing != null)
			{
				this._elapsed += Time.unscaledDeltaTime;
				float num = Mathf.Max(0f, this._currentlyShowing.DisplaySeconds - this._elapsed);
				this.view.SetCountdown(num / Mathf.Max(0.01f, this._currentlyShowing.DisplaySeconds));
				if (this._elapsed >= this._currentlyShowing.DisplaySeconds)
				{
					if (this._currentlyShowing.Kind == MessageKind.Ask && this._currentlyShowing.AskCompletion != null)
					{
						this._currentlyShowing.AskCompletion.TrySetResult(new AskResult("timeout", null, null));
					}
					this.AdvanceQueue();
				}
				return;
			}
			DialogueMessage dialogueMessage = this.Queue.PeekFront();
			if (dialogueMessage == null)
			{
				this.view.Hide();
				return;
			}
			this._currentlyShowing = dialogueMessage;
			this._elapsed = 0f;
			this.Queue.MarkCurrentlyShowing(dialogueMessage);
			this.PlayTalkPopSound();
			if (dialogueMessage.Kind == MessageKind.Say)
			{
				this.view.ShowSay(dialogueMessage.Text);
				return;
			}
			if (dialogueMessage.Buttons != null)
			{
				this.view.ShowAsk(dialogueMessage.Text, dialogueMessage.Buttons);
				return;
			}
			this.view.ShowSay(dialogueMessage.Text);
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00077F30 File Offset: 0x00076130
		private void OnButtonClicked(int index)
		{
			DialogueMessage currentlyShowing = this._currentlyShowing;
			if (currentlyShowing == null || currentlyShowing.Kind != MessageKind.Ask)
			{
				return;
			}
			if (this._currentlyShowing.Buttons == null || index < 0 || index >= this._currentlyShowing.Buttons.Count)
			{
				return;
			}
			string text = this._currentlyShowing.Buttons[index];
			TaskCompletionSource<AskResult> askCompletion = this._currentlyShowing.AskCompletion;
			if (askCompletion != null)
			{
				askCompletion.TrySetResult(new AskResult("clicked", text, new int?(index)));
			}
			this.AdvanceQueue();
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00077FBD File Offset: 0x000761BD
		private void OnCloseClicked()
		{
			this.DismissCurrent();
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00077FC8 File Offset: 0x000761C8
		private void DismissCurrent()
		{
			if (this._currentlyShowing == null)
			{
				return;
			}
			if (this._currentlyShowing.Kind == MessageKind.Ask)
			{
				TaskCompletionSource<AskResult> askCompletion = this._currentlyShowing.AskCompletion;
				if (askCompletion != null)
				{
					askCompletion.TrySetResult(new AskResult("dismissed", null, null));
				}
			}
			this.AdvanceQueue();
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00078024 File Offset: 0x00076224
		private void AdvanceQueue()
		{
			DialogueQueue queue = this.Queue;
			if (queue != null)
			{
				queue.Dequeue();
			}
			DialogueQueue queue2 = this.Queue;
			if (queue2 != null)
			{
				queue2.ClearCurrentlyShowing();
			}
			this._currentlyShowing = null;
			this._elapsed = 0f;
			this.view.Hide();
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x00078071 File Offset: 0x00076271
		[NullableContext(1)]
		public void ShowSizePreview(string text, float seconds = 2.5f)
		{
			DialogueMessage currentlyShowing = this._currentlyShowing;
			if (currentlyShowing != null && currentlyShowing.Kind == MessageKind.Ask)
			{
				return;
			}
			this._previewActive = true;
			this._previewRemaining = seconds;
			this.view.ShowSay(text);
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x000780A8 File Offset: 0x000762A8
		public void ForceHideAndDismissCurrent()
		{
			if (this._currentlyShowing == null)
			{
				this.view.Hide();
				return;
			}
			if (this._currentlyShowing.Kind == MessageKind.Ask)
			{
				TaskCompletionSource<AskResult> askCompletion = this._currentlyShowing.AskCompletion;
				if (askCompletion != null)
				{
					askCompletion.TrySetResult(new AskResult("dismissed", null, null));
				}
			}
			this._currentlyShowing = null;
			this._elapsed = 0f;
			DialogueQueue queue = this.Queue;
			if (queue != null)
			{
				queue.ClearCurrentlyShowing();
			}
			this.view.Hide();
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x00078138 File Offset: 0x00076338
		private void PlayTalkPopSound()
		{
			EventReference eventReference = bq.zy((VoiceProfile p) => p.talkVoice, this.talkPopSound);
			if (eventReference.IsNull || AudioManager.klw == null)
			{
				return;
			}
			AudioManager.klw.qw(eventReference, Vector3.zero, 1f);
		}

		// Token: 0x04000C3B RID: 3131
		[Nullable(1)]
		[SerializeField]
		private SpeechBubbleView view;

		// Token: 0x04000C3C RID: 3132
		[SerializeField]
		private int rewiredPlayerId;

		// Token: 0x04000C3D RID: 3133
		[SerializeField]
		private EventReference talkPopSound;

		// Token: 0x04000C3F RID: 3135
		private DialogueMessage _currentlyShowing;

		// Token: 0x04000C40 RID: 3136
		private float _elapsed;

		// Token: 0x04000C41 RID: 3137
		private Player _rewiredPlayer;

		// Token: 0x04000C42 RID: 3138
		private bool _previewActive;

		// Token: 0x04000C43 RID: 3139
		private float _previewRemaining;
	}
}
