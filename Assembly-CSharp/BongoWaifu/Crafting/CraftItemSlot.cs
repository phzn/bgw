using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BongoWaifu.Crafting
{
	// Token: 0x02000107 RID: 263
	public class CraftItemSlot : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x0005D4B5 File Offset: 0x0005B6B5
		public ItemData kte
		{
			get
			{
				return this.inl;
			}
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x0005D4BD File Offset: 0x0005B6BD
		private void Awake()
		{
			if (this._button != null)
			{
				this._button.onClick.AddListener(new UnityAction(this.cwr));
			}
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x0005D4E9 File Offset: 0x0005B6E9
		private void OnDestroy()
		{
			if (this._button != null)
			{
				this._button.onClick.RemoveListener(new UnityAction(this.cwr));
			}
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x0005D515 File Offset: 0x0005B715
		public void cwo(ItemData a, Func<ItemData, int> b, Func<ItemData, bool> c, Action<ItemData, bool> d, Func<ItemData, bool> e)
		{
			this.inl = a;
			this.inm = b;
			this.inn = c;
			this.ino = d;
			this.inp = e;
			this.cwq();
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x0005D544 File Offset: 0x0005B744
		private int cwp()
		{
			int num = (int)this.inl.quantity;
			if (num > 0 && this.inp != null && this.inp(this.inl))
			{
				num--;
			}
			return num;
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x0005D584 File Offset: 0x0005B784
		public void cwq()
		{
			if (this.inl == null)
			{
				return;
			}
			if (this._imageIcon != null)
			{
				Sprite sprite = this.inl.bio();
				this._imageIcon.sprite = sprite;
				this._imageIcon.enabled = sprite != null;
			}
			if (this._imageBackgroundLine != null)
			{
				this._imageBackgroundLine.color = this.inl.biq();
			}
			bool flag = this.inp != null && this.inp(this.inl);
			int num = ((this.inm != null) ? this.inm(this.inl) : 0);
			int quantity = (int)this.inl.quantity;
			int num2 = this.cwp() - num;
			if (num2 < 0)
			{
				num2 = 0;
			}
			int num3 = quantity - num;
			if (num3 < 0)
			{
				num3 = 0;
			}
			if (this._textNumber != null && this._rectNumberBG != null)
			{
				if (this.inl.quantity > 1U)
				{
					this._rectNumberBG.gameObject.SetActive(true);
					this._textNumber.text = ((flag || num3 < quantity) ? string.Format(a.drz(), num3, quantity) : quantity.ToString());
					this._textNumber.ForceMeshUpdate(false, false);
					LayoutRebuilder.ForceRebuildLayoutImmediate(this._textNumber.rectTransform);
					float width = this._textNumber.rectTransform.rect.width;
					this._rectNumberBG.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width + 10f);
				}
				else
				{
					this._rectNumberBG.gameObject.SetActive(false);
				}
			}
			bool flag2 = num > 0;
			bool flag3 = num2 <= 0;
			bool flag4 = this.inn == null || this.inn(this.inl);
			bool flag5 = !flag4 && !flag2;
			if (this._objSelected != null)
			{
				this._objSelected.SetActive(flag2);
			}
			if (this._objFavorite != null)
			{
				this._objFavorite.SetActive(flag);
			}
			if (this._canvasGroup != null)
			{
				this._canvasGroup.alpha = ((flag3 || flag5) ? 0.4f : 1f);
			}
			if (this._button != null)
			{
				this._button.interactable = flag2 || (!flag3 && flag4);
			}
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x0005D7F8 File Offset: 0x0005B9F8
		private void cwr()
		{
			if (this.inl == null)
			{
				return;
			}
			int num = ((this.inm != null) ? this.inm(this.inl) : 0);
			if (this.cwp() - num <= 0)
			{
				if (num > 0)
				{
					Action<ItemData, bool> action = this.ino;
					if (action == null)
					{
						return;
					}
					action(this.inl, false);
				}
				return;
			}
			Action<ItemData, bool> action2 = this.ino;
			if (action2 == null)
			{
				return;
			}
			action2(this.inl, true);
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x0005D869 File Offset: 0x0005BA69
		public void OnPointerClick(PointerEventData eventData)
		{
			if (eventData.button != PointerEventData.InputButton.Right)
			{
				return;
			}
			if (this.inl == null || !bp.zo(this.inl.defID))
			{
				return;
			}
			bp.zq(this.inl.defID);
		}

		// Token: 0x040009E4 RID: 2532
		[SerializeField]
		private Button _button;

		// Token: 0x040009E5 RID: 2533
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x040009E6 RID: 2534
		[SerializeField]
		private Image _imageBackgroundLine;

		// Token: 0x040009E7 RID: 2535
		[SerializeField]
		private RectTransform _rectNumberBG;

		// Token: 0x040009E8 RID: 2536
		[SerializeField]
		private TextMeshProUGUI _textNumber;

		// Token: 0x040009E9 RID: 2537
		[SerializeField]
		private GameObject _objSelected;

		// Token: 0x040009EA RID: 2538
		[SerializeField]
		private GameObject _objFavorite;

		// Token: 0x040009EB RID: 2539
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040009EC RID: 2540
		private ItemData inl;

		// Token: 0x040009ED RID: 2541
		private Func<ItemData, int> inm;

		// Token: 0x040009EE RID: 2542
		private Func<ItemData, bool> inn;

		// Token: 0x040009EF RID: 2543
		private Action<ItemData, bool> ino;

		// Token: 0x040009F0 RID: 2544
		private Func<ItemData, bool> inp;
	}
}
