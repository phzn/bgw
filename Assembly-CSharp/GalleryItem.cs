using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000094 RID: 148
public class GalleryItem : MonoBehaviour
{
	// Token: 0x17000093 RID: 147
	// (get) Token: 0x060006A7 RID: 1703 RVA: 0x0002508C File Offset: 0x0002328C
	// (set) Token: 0x060006A8 RID: 1704 RVA: 0x00025094 File Offset: 0x00023294
	public SpineSkinData hvw { get; private set; }

	// Token: 0x060006A9 RID: 1705 RVA: 0x0002509D File Offset: 0x0002329D
	public void brt()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x000250AC File Offset: 0x000232AC
	public void bru(SpineSkinData a, bool b)
	{
		this.hvw = a;
		if (this._imageIcon != null)
		{
			this._imageIcon.sprite = ((a != null) ? a.icon : null);
			this._imageIcon.color = (b ? Color.white : GalleryItem.hvv);
		}
		this.brv(b);
		this.brw();
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x0002510C File Offset: 0x0002330C
	private void brv(bool a)
	{
		if (this._imageBackground == null)
		{
			return;
		}
		SpineSkinSetting hle = bq.hle;
		if (hle == null)
		{
			return;
		}
		if (a && this.hvw != null)
		{
			string text = GalleryItem.brx(this.hvw.kox);
			this._imageBackground.color = ((!string.IsNullOrEmpty(text)) ? hle.bjv(text) : hle.defaultBackgroundColor);
			return;
		}
		this._imageBackground.color = Color.clear;
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00025188 File Offset: 0x00023388
	private void brw()
	{
		if (this._tipObject == null)
		{
			return;
		}
		string text = ((this.hvw != null) ? da.bsk(this.hvw) : null);
		if (string.IsNullOrEmpty(text))
		{
			this._tipObject.vj(false);
			return;
		}
		this._tipObject.vj(true);
		this._tipObject.vh(text);
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x000251E8 File Offset: 0x000233E8
	private static string brx(int a)
	{
		ItemData[] hlj = bq.hlj;
		if (hlj == null || hlj.Length == 0)
		{
			return null;
		}
		foreach (ItemData itemData in hlj)
		{
			if (itemData != null && itemData.defID == a)
			{
				return itemData.rarity;
			}
		}
		return null;
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x0002522C File Offset: 0x0002342C
	public void Close()
	{
		if (this._imageIcon != null)
		{
			this._imageIcon.sprite = null;
		}
		if (this._tipObject != null)
		{
			this._tipObject.vj(false);
		}
		this.hvw = null;
		base.gameObject.SetActive(false);
	}

	// Token: 0x04000673 RID: 1651
	[SerializeField]
	private Image _imageIcon;

	// Token: 0x04000674 RID: 1652
	[SerializeField]
	private Image _imageBackground;

	// Token: 0x04000675 RID: 1653
	[SerializeField]
	private bb _tipObject;

	// Token: 0x04000676 RID: 1654
	private static readonly Color hvv = new Color(0.1f, 0.1f, 0.1f, 0.5f);
}
