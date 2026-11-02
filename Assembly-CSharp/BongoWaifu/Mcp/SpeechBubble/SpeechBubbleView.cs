using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BongoWaifu.Mcp.SpeechBubble
{
	// Token: 0x02000161 RID: 353
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SpeechBubbleView : MonoBehaviour
	{
		// Token: 0x14000042 RID: 66
		// (add) Token: 0x0600180F RID: 6159 RVA: 0x000781B4 File Offset: 0x000763B4
		// (remove) Token: 0x06001810 RID: 6160 RVA: 0x000781EC File Offset: 0x000763EC
		[Nullable(2)]
		[method: NullableContext(2)]
		[field: Nullable(2)]
		public event Action<int> OnButtonClicked;

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06001811 RID: 6161 RVA: 0x00078224 File Offset: 0x00076424
		// (remove) Token: 0x06001812 RID: 6162 RVA: 0x0007825C File Offset: 0x0007645C
		[Nullable(2)]
		[method: NullableContext(2)]
		[field: Nullable(2)]
		public event Action OnCloseClicked;

		// Token: 0x06001813 RID: 6163 RVA: 0x00078294 File Offset: 0x00076494
		private void Awake()
		{
			for (int i = 0; i < this.buttons.Length; i++)
			{
				int idx = i;
				if (this.buttons[i] != null)
				{
					this.buttons[i].onClick.AddListener(delegate
					{
						Action<int> onButtonClicked = this.OnButtonClicked;
						if (onButtonClicked == null)
						{
							return;
						}
						onButtonClicked(idx);
					});
				}
			}
			if (this.closeButton != null)
			{
				this.closeButton.onClick.AddListener(delegate
				{
					Action onCloseClicked = this.OnCloseClicked;
					if (onCloseClicked == null)
					{
						return;
					}
					onCloseClicked();
				});
			}
			this.Hide();
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x00078326 File Offset: 0x00076526
		public void ShowSay(string text)
		{
			this.messageText.text = text;
			this.buttonRow.SetActive(false);
			base.gameObject.SetActive(true);
			this.canvasGroup.alpha = 1f;
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x0007835C File Offset: 0x0007655C
		public void ShowAsk(string text, IReadOnlyList<string> btns)
		{
			this.messageText.text = text;
			this.buttonRow.SetActive(true);
			for (int i = 0; i < this.buttons.Length; i++)
			{
				bool flag = i < btns.Count;
				if (this.buttons[i] != null)
				{
					this.buttons[i].gameObject.SetActive(flag);
				}
				if (flag && this.buttonLabels[i] != null)
				{
					this.buttonLabels[i].text = btns[i];
				}
			}
			base.gameObject.SetActive(true);
			this.canvasGroup.alpha = 1f;
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x00078404 File Offset: 0x00076604
		public void SetCountdown(float normalized)
		{
			this.countdownFill.fillAmount = Mathf.Clamp01(normalized);
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x00078417 File Offset: 0x00076617
		public void Hide()
		{
			base.gameObject.SetActive(false);
			this.canvasGroup.alpha = 0f;
		}

		// Token: 0x04000C46 RID: 3142
		[SerializeField]
		private CanvasGroup canvasGroup;

		// Token: 0x04000C47 RID: 3143
		[SerializeField]
		private Text messageText;

		// Token: 0x04000C48 RID: 3144
		[SerializeField]
		private GameObject buttonRow;

		// Token: 0x04000C49 RID: 3145
		[SerializeField]
		private Button[] buttons = Array.Empty<Button>();

		// Token: 0x04000C4A RID: 3146
		[SerializeField]
		private TMP_Text[] buttonLabels = Array.Empty<TMP_Text>();

		// Token: 0x04000C4B RID: 3147
		[SerializeField]
		private Button closeButton;

		// Token: 0x04000C4C RID: 3148
		[SerializeField]
		private Image countdownFill;
	}
}
