using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BongoWaifu.Crafting
{
	// Token: 0x02000106 RID: 262
	public class CraftBasketSlot : MonoBehaviour
	{
		// Token: 0x06001328 RID: 4904 RVA: 0x0005D2F0 File Offset: 0x0005B4F0
		public void cwj(int a, Action<int> b)
		{
			this.ini = a;
			this.ink = b;
			if (this._button != null)
			{
				this._button.onClick.RemoveAllListeners();
				this._button.onClick.AddListener(new UnityAction(this.cwm));
			}
			this.cwk();
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0005D34C File Offset: 0x0005B54C
		public void cwk()
		{
			this.inj = null;
			if (this._imageIcon != null)
			{
				this._imageIcon.sprite = null;
				this._imageIcon.enabled = false;
			}
			if (this._imageBackgroundLine != null)
			{
				SpineSkinSetting hle = bq.hle;
				this._imageBackgroundLine.color = ((hle != null) ? hle.defaultBackgroundColor : Color.gray);
			}
			if (this._placeholder != null)
			{
				this._placeholder.SetActive(true);
			}
			if (this._button != null)
			{
				this._button.interactable = false;
			}
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0005D3F0 File Offset: 0x0005B5F0
		public void cwl(ItemData a)
		{
			if (a == null)
			{
				this.cwk();
				return;
			}
			this.inj = a;
			if (this._imageIcon != null)
			{
				Sprite sprite = a.bio();
				this._imageIcon.sprite = sprite;
				this._imageIcon.enabled = sprite != null;
			}
			if (this._imageBackgroundLine != null)
			{
				this._imageBackgroundLine.color = a.biq();
			}
			if (this._placeholder != null)
			{
				this._placeholder.SetActive(false);
			}
			if (this._button != null)
			{
				this._button.interactable = true;
			}
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x0005D494 File Offset: 0x0005B694
		private void cwm()
		{
			if (this.inj == null)
			{
				return;
			}
			Action<int> action = this.ink;
			if (action == null)
			{
				return;
			}
			action(this.ini);
		}

		// Token: 0x040009DD RID: 2525
		[SerializeField]
		private Button _button;

		// Token: 0x040009DE RID: 2526
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x040009DF RID: 2527
		[SerializeField]
		private Image _imageBackgroundLine;

		// Token: 0x040009E0 RID: 2528
		[SerializeField]
		private GameObject _placeholder;

		// Token: 0x040009E1 RID: 2529
		private int ini;

		// Token: 0x040009E2 RID: 2530
		private ItemData inj;

		// Token: 0x040009E3 RID: 2531
		private Action<int> ink;
	}
}
