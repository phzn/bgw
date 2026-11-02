using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200008F RID: 143
public class cw : MonoBehaviour
{
	// Token: 0x1700008F RID: 143
	// (get) Token: 0x06000634 RID: 1588 RVA: 0x00022484 File Offset: 0x00020684
	public int kpu
	{
		get
		{
			return this.huy.bje();
		}
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x00022494 File Offset: 0x00020694
	private void mni(ClothingSetShowItem a, int b)
	{
		SpineSkinData spineSkinData = bq.hle.bjx(b);
		a.bqv((spineSkinData != null) ? spineSkinData.icon : null);
		a.bqw(b != 0 && spineSkinData != null && !spineSkinData.bjq());
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x000224D8 File Offset: 0x000206D8
	public void bqc()
	{
		bq.hlk = false;
		SpineSkinData spineSkinData = bq.hle.bjy(this.huy.desiredHairUse, CLOTHE_TYPE.Hair);
		if (spineSkinData != null)
		{
			spineSkinData.bjp(true);
		}
		SpineSkinData spineSkinData2 = bq.hle.bjy(this.huy.desiredTopUse, CLOTHE_TYPE.Top);
		if (spineSkinData2 != null)
		{
			spineSkinData2.bjp(true);
		}
		SpineSkinData spineSkinData3 = bq.hle.bjy(this.huy.desiredBottomUse, CLOTHE_TYPE.Bottom);
		if (spineSkinData3 != null)
		{
			spineSkinData3.bjp(true);
		}
		SpineSkinData spineSkinData4 = bq.hle.bjy(this.huy.desiredUnderwearUse, CLOTHE_TYPE.Underwear);
		if (spineSkinData4 != null)
		{
			spineSkinData4.bjp(true);
		}
		SpineSkinData spineSkinData5 = bq.hle.bjy(this.huy.desiredSocksUse, CLOTHE_TYPE.Socks);
		if (spineSkinData5 != null)
		{
			spineSkinData5.bjp(true);
		}
		SpineSkinData spineSkinData6 = bq.hle.bjy(this.huy.desiredShoesUse, CLOTHE_TYPE.Shoes);
		if (spineSkinData6 != null)
		{
			spineSkinData6.bjp(true);
		}
		ci.Save(null);
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x000225C0 File Offset: 0x000207C0
	public void bqa()
	{
		base.gameObject.SetActive(true);
		this._btnUse.onClick.RemoveAllListeners();
		this._btnUse.onClick.AddListener(new UnityAction(this.bqf));
		this._btnDelete.onClick.RemoveAllListeners();
		this._btnDelete.onClick.AddListener(new UnityAction(this.bqg));
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x00022634 File Offset: 0x00020834
	public void bqd()
	{
		this.bqe(this._item_Hair, this.huy.desiredHairUse);
		this.bqe(this._item_Top, this.huy.desiredTopUse);
		this.bqe(this._item_Bottom, this.huy.desiredBottomUse);
		this.bqe(this._item_Underwear, this.huy.desiredUnderwearUse);
		this.bqe(this._item_Socks, this.huy.desiredSocksUse);
		this.bqe(this._item_Shoes, this.huy.desiredShoesUse);
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x000226CC File Offset: 0x000208CC
	public void lsh()
	{
		base.gameObject.SetActive(true);
		this._btnUse.onClick.RemoveAllListeners();
		this._btnUse.onClick.AddListener(new UnityAction(this.bqf));
		this._btnDelete.onClick.RemoveAllListeners();
		this._btnDelete.onClick.AddListener(new UnityAction(this.bqg));
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x0001F517 File Offset: 0x0001D717
	public void Close()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x0001F517 File Offset: 0x0001D717
	public void lym()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x0002273D File Offset: 0x0002093D
	[CompilerGenerated]
	private void bqf()
	{
		this.bqc();
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x00022748 File Offset: 0x00020948
	public void lty()
	{
		base.gameObject.SetActive(true);
		this._btnUse.onClick.RemoveAllListeners();
		this._btnUse.onClick.AddListener(new UnityAction(this.bqf));
		this._btnDelete.onClick.RemoveAllListeners();
		this._btnDelete.onClick.AddListener(new UnityAction(this.bqg));
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x000227BC File Offset: 0x000209BC
	private void dus(ClothingSetShowItem a, int b)
	{
		SpineSkinData spineSkinData = bq.hle.bjx(b);
		a.bqv((spineSkinData != null) ? spineSkinData.icon : null);
		a.bqw(b != 0 && spineSkinData != null && !spineSkinData.bjq());
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x00022800 File Offset: 0x00020A00
	private void fid(ClothingSetShowItem a, int b)
	{
		SpineSkinData spineSkinData = bq.hle.bjx(b);
		a.bqv((spineSkinData != null) ? spineSkinData.icon : null);
		a.bqw(b != 0 && spineSkinData != null && !spineSkinData.bjq());
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x00022844 File Offset: 0x00020A44
	public void nne()
	{
		this.bqe(this._item_Hair, this.huy.desiredHairUse);
		this.bqe(this._item_Top, this.huy.desiredTopUse);
		this.bqe(this._item_Bottom, this.huy.desiredBottomUse);
		this.bqe(this._item_Underwear, this.huy.desiredUnderwearUse);
		this.bqe(this._item_Socks, this.huy.desiredSocksUse);
		this.bqe(this._item_Shoes, this.huy.desiredShoesUse);
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x000228DC File Offset: 0x00020ADC
	private void bqe(ClothingSetShowItem a, int b)
	{
		SpineSkinData spineSkinData = bq.hle.bjx(b);
		a.bqv((spineSkinData != null) ? spineSkinData.icon : null);
		a.bqw(b != 0 && spineSkinData != null && !spineSkinData.bjq());
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x00022920 File Offset: 0x00020B20
	private void dea(ClothingSetShowItem a, int b)
	{
		SpineSkinData spineSkinData = bq.hle.bjx(b);
		a.bqv((spineSkinData != null) ? spineSkinData.icon : null);
		a.bqw(b != 0 && spineSkinData != null && !spineSkinData.bjq());
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x00022963 File Offset: 0x00020B63
	[CompilerGenerated]
	private void bqg()
	{
		ClothingSetItemController.kpv.bqp(this);
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00022970 File Offset: 0x00020B70
	public void bqb(ClothingSetData a)
	{
		this.huy = a;
		this.bqd();
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x00022980 File Offset: 0x00020B80
	public void mmx()
	{
		this.bqe(this._item_Hair, this.huy.desiredHairUse);
		this.bqe(this._item_Top, this.huy.desiredTopUse);
		this.bqe(this._item_Bottom, this.huy.desiredBottomUse);
		this.bqe(this._item_Underwear, this.huy.desiredUnderwearUse);
		this.bqe(this._item_Socks, this.huy.desiredSocksUse);
		this.bqe(this._item_Shoes, this.huy.desiredShoesUse);
	}

	// Token: 0x0400063D RID: 1597
	private ClothingSetData huy;

	// Token: 0x0400063E RID: 1598
	public ClothingSetShowItem _item_Hair;

	// Token: 0x0400063F RID: 1599
	public ClothingSetShowItem _item_Top;

	// Token: 0x04000640 RID: 1600
	public ClothingSetShowItem _item_Bottom;

	// Token: 0x04000641 RID: 1601
	public ClothingSetShowItem _item_Underwear;

	// Token: 0x04000642 RID: 1602
	public ClothingSetShowItem _item_Socks;

	// Token: 0x04000643 RID: 1603
	public ClothingSetShowItem _item_Shoes;

	// Token: 0x04000644 RID: 1604
	public Button _btnUse;

	// Token: 0x04000645 RID: 1605
	public Button _btnDelete;
}
