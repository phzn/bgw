using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using BongoWaifu.Mcp.SpeechBubble;
using BongoWaifu.Multiplayer;
using UnityEngine;

// Token: 0x0200002F RID: 47
public class bl : MonoBehaviour
{
	// Token: 0x06000283 RID: 643 RVA: 0x0000C9C8 File Offset: 0x0000ABC8
	private bool heh(int a)
	{
		CatCharacterDefinition catCharacterDefinition = this.xp(a);
		return catCharacterDefinition != null && catCharacterDefinition.unlockType == CatUnlockType.Workshop;
	}

	// Token: 0x06000284 RID: 644 RVA: 0x0000C9F1 File Offset: 0x0000ABF1
	private void xy(bool a)
	{
		if (this.catObject != null)
		{
			this.catObject.SetActive(a);
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x06000285 RID: 645 RVA: 0x0000CA0D File Offset: 0x0000AC0D
	public static bl kmv
	{
		get
		{
			return bl.hjg;
		}
	}

	// Token: 0x06000286 RID: 646 RVA: 0x0000CA14 File Offset: 0x0000AC14
	public int xr()
	{
		this.xu();
		int num = (bq.hly + 1) % this.kmu;
		this.xh(num);
		return num;
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x060002A4 RID: 676 RVA: 0x0000D02A File Offset: 0x0000B22A
	// (set) Token: 0x06000287 RID: 647 RVA: 0x0000CA3E File Offset: 0x0000AC3E
	public int hjk { get; private set; } = -1;

	// Token: 0x06000288 RID: 648 RVA: 0x0000CA47 File Offset: 0x0000AC47
	public void otw()
	{
		this.hjm = false;
	}

	// Token: 0x14000007 RID: 7
	// (add) Token: 0x06000295 RID: 661 RVA: 0x0000CCF4 File Offset: 0x0000AEF4
	// (remove) Token: 0x06000289 RID: 649 RVA: 0x0000CA50 File Offset: 0x0000AC50
	public static event Action hji;

	// Token: 0x0600028A RID: 650 RVA: 0x0000CA84 File Offset: 0x0000AC84
	private void xl()
	{
		this.xx(false);
		this.xy(false);
		if (this.waifuClickArea != null)
		{
			this.waifuClickArea.SetActive(false);
		}
		if (this.catClickArea != null)
		{
			this.catClickArea.SetActive(false);
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000D0D0 File Offset: 0x0000B2D0
	// (set) Token: 0x0600028B RID: 651 RVA: 0x0000CAD3 File Offset: 0x0000ACD3
	public ActiveCharacterInfo hjj { get; private set; }

	// Token: 0x0600028C RID: 652 RVA: 0x0000CADC File Offset: 0x0000ACDC
	public void cac()
	{
		if (this.hjm)
		{
			this.xh(this.hjn);
			this.hjm = false;
			return;
		}
		int num = this.xv();
		if (num <= 0)
		{
			return;
		}
		if (bq.hly == num)
		{
			return;
		}
		this.hjn = bq.hly;
		this.xh(num);
		this.hjm = true;
	}

	// Token: 0x0600028D RID: 653 RVA: 0x0000CB33 File Offset: 0x0000AD33
	private void zt(CatCharacterDefinition a)
	{
		this.xx(false);
		this.xy(true);
		this.xz(false);
		if (r.kmi != null)
		{
			r.kmi.tv(a);
		}
	}

	// Token: 0x0600028E RID: 654 RVA: 0x0000CB62 File Offset: 0x0000AD62
	private void xi()
	{
		this.xx(true);
		this.xy(false);
		this.xz(true);
		if (GirlController.kok != null)
		{
			GirlController.kok.bfc();
		}
	}

	// Token: 0x0600028F RID: 655 RVA: 0x0000CB90 File Offset: 0x0000AD90
	public void xm(bool a)
	{
		if (bq.hlz == a)
		{
			return;
		}
		bq.hlz = a;
		PlayerPrefs.SetInt(a.mw(), a ? 1 : 0);
		PlayerPrefs.Save();
		Action action = bl.hji;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000290 RID: 656 RVA: 0x0000CBC8 File Offset: 0x0000ADC8
	private void mlk()
	{
		if (eb.krm != null)
		{
			eb.krm.chs();
		}
		int num = PlayerPrefs.GetInt(a.mx(), 0);
		if (ec.cia(num))
		{
			Debug.LogWarning(string.Format(a.my(), num));
			num = 0;
		}
		this.xh(num);
	}

	// Token: 0x06000291 RID: 657 RVA: 0x0000C9F1 File Offset: 0x0000ABF1
	private void gsx(bool a)
	{
		if (this.catObject != null)
		{
			this.catObject.SetActive(a);
		}
	}

	// Token: 0x06000292 RID: 658 RVA: 0x0000CC20 File Offset: 0x0000AE20
	public void fui()
	{
		int hly = bq.hly;
		if (hly >= this.kmu)
		{
			Debug.Log(string.Format(a.mz(), hly, this.kmu));
			this.xh(0);
			return;
		}
		if (hly > 0)
		{
			this.xh(hly);
		}
	}

	// Token: 0x14000006 RID: 6
	// (add) Token: 0x06000293 RID: 659 RVA: 0x0000CC70 File Offset: 0x0000AE70
	// (remove) Token: 0x060002B3 RID: 691 RVA: 0x0000D4D8 File Offset: 0x0000B6D8
	public event Action<ActiveCharacterInfo> hjh;

	// Token: 0x06000294 RID: 660 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
	private void jwu()
	{
		if (bl.hjg != null && bl.hjg != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		bl.hjg = this;
		bq.hlz = PlayerPrefs.GetInt(a.na(), 0) != 0;
	}

	// Token: 0x06000296 RID: 662 RVA: 0x0000CD28 File Offset: 0x0000AF28
	public void xw()
	{
		int hly = bq.hly;
		if (hly >= this.kmu)
		{
			Debug.Log(string.Format(a.nb(), hly, this.kmu));
			this.xh(0);
			return;
		}
		if (hly > 0)
		{
			this.xh(hly);
		}
	}

	// Token: 0x06000297 RID: 663 RVA: 0x0000CD78 File Offset: 0x0000AF78
	private void ntw()
	{
		if (bl.hjg != null && bl.hjg != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		bl.hjg = this;
		bq.hlz = PlayerPrefs.GetInt(a.nc(), 0) != 0;
	}

	// Token: 0x06000298 RID: 664 RVA: 0x0000CDC4 File Offset: 0x0000AFC4
	public void ksb()
	{
		if (this.hjm)
		{
			this.xh(this.hjn);
			this.hjm = false;
			return;
		}
		int num = this.xv();
		if (num <= 0)
		{
			return;
		}
		if (bq.hly == num)
		{
			return;
		}
		this.hjn = bq.hly;
		this.xh(num);
		this.hjm = true;
	}

	// Token: 0x06000299 RID: 665 RVA: 0x0000CE1C File Offset: 0x0000B01C
	private bool ifh(int a)
	{
		CatCharacterDefinition catCharacterDefinition = this.xp(a);
		return catCharacterDefinition != null && catCharacterDefinition.unlockType == CatUnlockType.Workshop;
	}

	// Token: 0x0600029A RID: 666 RVA: 0x0000CE48 File Offset: 0x0000B048
	public void hwf()
	{
		int hly = bq.hly;
		if (hly >= this.kmu)
		{
			Debug.Log(string.Format(a.nd(), hly, this.kmu));
			this.xh(0);
			return;
		}
		if (hly > 0)
		{
			this.xh(hly);
		}
	}

	// Token: 0x0600029B RID: 667 RVA: 0x0000CE98 File Offset: 0x0000B098
	public void gid()
	{
		int hly = bq.hly;
		if (bq.hlz)
		{
			this.xl();
		}
		else if (hly == 0)
		{
			this.xi();
		}
		else
		{
			CatCharacterDefinition catCharacterDefinition = this.xp(hly);
			if (catCharacterDefinition == null)
			{
				this.xh(hly);
				return;
			}
			this.xj(catCharacterDefinition);
		}
		Action action = bl.hji;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x0600029C RID: 668 RVA: 0x0000CEF4 File Offset: 0x0000B0F4
	private IReadOnlyList<CatCharacterDefinition> kmt
	{
		get
		{
			if (!(eb.krm != null))
			{
				return bl.hjf;
			}
			return eb.krm.krl;
		}
	}

	// Token: 0x0600029D RID: 669 RVA: 0x0000CA47 File Offset: 0x0000AC47
	public void xu()
	{
		this.hjm = false;
	}

	// Token: 0x0600029F RID: 671 RVA: 0x0000CF2C File Offset: 0x0000B12C
	private void Start()
	{
		if (eb.krm != null)
		{
			eb.krm.chs();
		}
		int num = PlayerPrefs.GetInt(a.ne(), 0);
		if (ec.cia(num))
		{
			Debug.LogWarning(string.Format(a.nf(), num));
			num = 0;
		}
		this.xh(num);
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x0000CF84 File Offset: 0x0000B184
	private bool dwg(int a)
	{
		CatCharacterDefinition catCharacterDefinition = this.xp(a);
		return catCharacterDefinition != null && catCharacterDefinition.unlockType == CatUnlockType.Workshop;
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x0000CFAD File Offset: 0x0000B1AD
	private void xx(bool a)
	{
		if (this.waifuObject != null)
		{
			this.waifuObject.SetActive(a);
		}
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x0000CFCC File Offset: 0x0000B1CC
	public void mba()
	{
		int hly = bq.hly;
		if (hly >= this.kmu)
		{
			Debug.Log(string.Format(a.ng(), hly, this.kmu));
			this.xh(0);
			return;
		}
		if (hly > 0)
		{
			this.xh(hly);
		}
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x0000D034 File Offset: 0x0000B234
	public void nsj()
	{
		int hly = bq.hly;
		if (hly >= this.kmu)
		{
			Debug.Log(string.Format(a.nh(), hly, this.kmu));
			this.xh(0);
			return;
		}
		if (hly > 0)
		{
			this.xh(hly);
		}
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x0000D084 File Offset: 0x0000B284
	private void ekw()
	{
		if (bl.hjg != null && bl.hjg != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		bl.hjg = this;
		bq.hlz = PlayerPrefs.GetInt(a.ni(), 0) != 0;
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000D0D8 File Offset: 0x0000B2D8
	public bool kmw
	{
		get
		{
			return this.hjm;
		}
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
	public CatCharacterDefinition xp(int a)
	{
		if (a <= 0 || a >= this.kmu)
		{
			return null;
		}
		return this.kmt[a - 1];
	}

	// Token: 0x060002AA RID: 682 RVA: 0x0000CB33 File Offset: 0x0000AD33
	private void mth(CatCharacterDefinition a)
	{
		this.xx(false);
		this.xy(true);
		this.xz(false);
		if (r.kmi != null)
		{
			r.kmi.tv(a);
		}
	}

	// Token: 0x060002AB RID: 683 RVA: 0x0000CB33 File Offset: 0x0000AD33
	private void xj(CatCharacterDefinition a)
	{
		this.xx(false);
		this.xy(true);
		this.xz(false);
		if (r.kmi != null)
		{
			r.kmi.tv(a);
		}
	}

	// Token: 0x060002AC RID: 684 RVA: 0x0000D0FF File Offset: 0x0000B2FF
	private void xz(bool a)
	{
		if (this.waifuClickArea != null)
		{
			this.waifuClickArea.SetActive(a);
		}
		if (this.catClickArea != null)
		{
			this.catClickArea.SetActive(!a);
		}
	}

	// Token: 0x060002AD RID: 685 RVA: 0x0000D138 File Offset: 0x0000B338
	public void xh(int a)
	{
		if (a < 0 || a >= this.kmu)
		{
			a = 0;
		}
		this.hjk = -1;
		if (MultiplayerSession.iuw && this.xq(a))
		{
			this.hjk = a;
			a = 0;
		}
		bq.bao();
		bq.hly = a;
		if (a == 0)
		{
			if (bq.hlz)
			{
				this.xl();
			}
			else
			{
				this.xi();
			}
			this.xn(0, null);
		}
		else
		{
			int num = a - 1;
			CatCharacterDefinition catCharacterDefinition = this.kmt[num];
			if (catCharacterDefinition == null || (catCharacterDefinition.displayMode == CatDisplayMode.Spine && catCharacterDefinition.skeletonDataAsset == null) || (catCharacterDefinition.displayMode == CatDisplayMode.Image && catCharacterDefinition.idleSprite == null))
			{
				Debug.LogWarning(string.Format(a.nj(), num, catCharacterDefinition, (catCharacterDefinition != null) ? new CatDisplayMode?(catCharacterDefinition.displayMode) : null));
				a = 1;
				bq.hly = a;
				catCharacterDefinition = ((this.kmt.Count > 0) ? this.kmt[0] : null);
				if (catCharacterDefinition == null)
				{
					this.xh(0);
					return;
				}
			}
			if (bq.hlz)
			{
				this.xl();
			}
			else
			{
				this.xj(catCharacterDefinition);
			}
			this.xn(a, catCharacterDefinition);
		}
		Action action = bl.hji;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x060002AE RID: 686 RVA: 0x0000D294 File Offset: 0x0000B494
	public void xt()
	{
		if (this.hjm)
		{
			this.xh(this.hjn);
			this.hjm = false;
			return;
		}
		int num = this.xv();
		if (num <= 0)
		{
			return;
		}
		if (bq.hly == num)
		{
			return;
		}
		this.hjn = bq.hly;
		this.xh(num);
		this.hjm = true;
	}

	// Token: 0x060002AF RID: 687 RVA: 0x0000D2EC File Offset: 0x0000B4EC
	public void nfr()
	{
		if (this.hjm)
		{
			this.xh(this.hjn);
			this.hjm = false;
			return;
		}
		int num = this.xv();
		if (num <= 0)
		{
			return;
		}
		if (bq.hly == num)
		{
			return;
		}
		this.hjn = bq.hly;
		this.xh(num);
		this.hjm = true;
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x0000D344 File Offset: 0x0000B544
	private void bgs(int a, CatCharacterDefinition b)
	{
		ActiveCharacterInfo activeCharacterInfo = this.xo(a, b);
		this.hjj = activeCharacterInfo;
		if (activeCharacterInfo != null)
		{
			Action<ActiveCharacterInfo> action = this.hjh;
			if (action == null)
			{
				return;
			}
			action(activeCharacterInfo);
		}
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x0000CB33 File Offset: 0x0000AD33
	private void ghd(CatCharacterDefinition a)
	{
		this.xx(false);
		this.xy(true);
		this.xz(false);
		if (r.kmi != null)
		{
			r.kmi.tv(a);
		}
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x0000D37C File Offset: 0x0000B57C
	public void hzu(int a)
	{
		if (a < 0 || a >= this.kmu)
		{
			a = 0;
		}
		this.hjk = -1;
		if (MultiplayerSession.iuw && this.xq(a))
		{
			this.hjk = a;
			a = 0;
		}
		bq.bao();
		bq.hly = a;
		if (a == 0)
		{
			if (bq.hlz)
			{
				this.xl();
			}
			else
			{
				this.xi();
			}
			this.xn(0, null);
		}
		else
		{
			int num = a - 1;
			CatCharacterDefinition catCharacterDefinition = this.kmt[num];
			if (catCharacterDefinition == null || (catCharacterDefinition.displayMode == CatDisplayMode.Spine && catCharacterDefinition.skeletonDataAsset == null) || (catCharacterDefinition.displayMode == CatDisplayMode.Image && catCharacterDefinition.idleSprite == null))
			{
				Debug.LogWarning(string.Format(a.nk(), num, catCharacterDefinition, (catCharacterDefinition != null) ? new CatDisplayMode?(catCharacterDefinition.displayMode) : null));
				a = 1;
				bq.hly = a;
				catCharacterDefinition = ((this.kmt.Count > 0) ? this.kmt[0] : null);
				if (catCharacterDefinition == null)
				{
					this.xh(0);
					return;
				}
			}
			if (bq.hlz)
			{
				this.xl();
			}
			else
			{
				this.xj(catCharacterDefinition);
			}
			this.xn(a, catCharacterDefinition);
		}
		Action action = bl.hji;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x0000D510 File Offset: 0x0000B710
	private void czt(int a, CatCharacterDefinition b)
	{
		ActiveCharacterInfo activeCharacterInfo = this.xo(a, b);
		this.hjj = activeCharacterInfo;
		if (activeCharacterInfo != null)
		{
			Action<ActiveCharacterInfo> action = this.hjh;
			if (action == null)
			{
				return;
			}
			action(activeCharacterInfo);
		}
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x0000CFAD File Offset: 0x0000B1AD
	private void mmu(bool a)
	{
		if (this.waifuObject != null)
		{
			this.waifuObject.SetActive(a);
		}
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
	public CatCharacterDefinition qb(int a)
	{
		if (a <= 0 || a >= this.kmu)
		{
			return null;
		}
		return this.kmt[a - 1];
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x0000CA47 File Offset: 0x0000AC47
	public void hgt()
	{
		this.hjm = false;
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000D547 File Offset: 0x0000B747
	public int kmu
	{
		get
		{
			return 1 + this.kmt.Count;
		}
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x0000C9F1 File Offset: 0x0000ABF1
	private void jds(bool a)
	{
		if (this.catObject != null)
		{
			this.catObject.SetActive(a);
		}
	}

	// Token: 0x060002BA RID: 698 RVA: 0x0000D558 File Offset: 0x0000B758
	private void Awake()
	{
		if (bl.hjg != null && bl.hjg != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		bl.hjg = this;
		bq.hlz = PlayerPrefs.GetInt(a.mw(), 0) != 0;
	}

	// Token: 0x060002BB RID: 699 RVA: 0x0000CA47 File Offset: 0x0000AC47
	public void jag()
	{
		this.hjm = false;
	}

	// Token: 0x060002BC RID: 700 RVA: 0x0000D5A4 File Offset: 0x0000B7A4
	private void dte()
	{
		this.xx(false);
		this.xy(false);
		if (this.waifuClickArea != null)
		{
			this.waifuClickArea.SetActive(false);
		}
		if (this.catClickArea != null)
		{
			this.catClickArea.SetActive(false);
		}
	}

	// Token: 0x060002BD RID: 701 RVA: 0x0000D5F4 File Offset: 0x0000B7F4
	private void mup(int a, CatCharacterDefinition b)
	{
		ActiveCharacterInfo activeCharacterInfo = this.xo(a, b);
		this.hjj = activeCharacterInfo;
		if (activeCharacterInfo != null)
		{
			Action<ActiveCharacterInfo> action = this.hjh;
			if (action == null)
			{
				return;
			}
			action(activeCharacterInfo);
		}
	}

	// Token: 0x060002BE RID: 702 RVA: 0x0000D62C File Offset: 0x0000B82C
	private bool xq(int a)
	{
		CatCharacterDefinition catCharacterDefinition = this.xp(a);
		return catCharacterDefinition != null && catCharacterDefinition.unlockType == CatUnlockType.Workshop;
	}

	// Token: 0x060002BF RID: 703 RVA: 0x0000CA47 File Offset: 0x0000AC47
	public void egj()
	{
		this.hjm = false;
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x0000CFAD File Offset: 0x0000B1AD
	private void nz(bool a)
	{
		if (this.waifuObject != null)
		{
			this.waifuObject.SetActive(a);
		}
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x0000D658 File Offset: 0x0000B858
	public void xk()
	{
		int hly = bq.hly;
		if (bq.hlz)
		{
			this.xl();
		}
		else if (hly == 0)
		{
			this.xi();
		}
		else
		{
			CatCharacterDefinition catCharacterDefinition = this.xp(hly);
			if (catCharacterDefinition == null)
			{
				this.xh(hly);
				return;
			}
			this.xj(catCharacterDefinition);
		}
		Action action = bl.hji;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x0000D6B4 File Offset: 0x0000B8B4
	private void gyc()
	{
		this.xx(false);
		this.xy(false);
		if (this.waifuClickArea != null)
		{
			this.waifuClickArea.SetActive(false);
		}
		if (this.catClickArea != null)
		{
			this.catClickArea.SetActive(false);
		}
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x0000D704 File Offset: 0x0000B904
	private int xv()
	{
		IReadOnlyList<CatCharacterDefinition> readOnlyList = this.kmt;
		if (readOnlyList == null || readOnlyList.Count == 0)
		{
			return -1;
		}
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			if (readOnlyList[i] != null && readOnlyList[i].characterId == a.nl())
			{
				return i + 1;
			}
		}
		for (int j = 0; j < readOnlyList.Count; j++)
		{
			if (readOnlyList[j] != null && readOnlyList[j].unlockType == CatUnlockType.Free)
			{
				return j + 1;
			}
		}
		for (int k = 0; k < readOnlyList.Count; k++)
		{
			if (readOnlyList[k] != null && readOnlyList[k].unlockType == CatUnlockType.Workshop)
			{
				return k + 1;
			}
		}
		return -1;
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x0000C9F1 File Offset: 0x0000ABF1
	private void fdt(bool a)
	{
		if (this.catObject != null)
		{
			this.catObject.SetActive(a);
		}
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x0000D7C8 File Offset: 0x0000B9C8
	private ActiveCharacterInfo xo(int a, CatCharacterDefinition b)
	{
		if (a == 0)
		{
			if (this.waifuObject == null)
			{
				return null;
			}
			return new ActiveCharacterInfo(a.nm(), a.nn(), CharacterType.Waifu, this.waifuObject.transform);
		}
		else
		{
			if (this.catObject == null || b == null)
			{
				return null;
			}
			string text = ((!string.IsNullOrEmpty(b.characterId)) ? b.characterId : b.name);
			string text2 = ((!string.IsNullOrEmpty(b.displayName)) ? b.displayName : text);
			return new ActiveCharacterInfo(text, text2, CharacterType.Cat, this.catObject.transform);
		}
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x0000CFAD File Offset: 0x0000B1AD
	private void lgj(bool a)
	{
		if (this.waifuObject != null)
		{
			this.waifuObject.SetActive(a);
		}
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x0000D864 File Offset: 0x0000BA64
	private void xn(int a, CatCharacterDefinition b)
	{
		ActiveCharacterInfo activeCharacterInfo = this.xo(a, b);
		this.hjj = activeCharacterInfo;
		if (activeCharacterInfo != null)
		{
			Action<ActiveCharacterInfo> action = this.hjh;
			if (action == null)
			{
				return;
			}
			action(activeCharacterInfo);
		}
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x0000D89C File Offset: 0x0000BA9C
	public void msq()
	{
		if (this.hjm)
		{
			this.xh(this.hjn);
			this.hjm = false;
			return;
		}
		int num = this.xv();
		if (num <= 0)
		{
			return;
		}
		if (bq.hly == num)
		{
			return;
		}
		this.hjn = bq.hly;
		this.xh(num);
		this.hjm = true;
	}

	// Token: 0x0400013C RID: 316
	public GameObject waifuObject;

	// Token: 0x0400013D RID: 317
	public GameObject catObject;

	// Token: 0x0400013E RID: 318
	public GameObject waifuClickArea;

	// Token: 0x0400013F RID: 319
	public GameObject catClickArea;

	// Token: 0x04000140 RID: 320
	private static readonly List<CatCharacterDefinition> hjf = new List<CatCharacterDefinition>();

	// Token: 0x04000141 RID: 321
	private static bl hjg;

	// Token: 0x04000146 RID: 326
	private const string hjl = "draft_cat";

	// Token: 0x04000147 RID: 327
	private bool hjm;

	// Token: 0x04000148 RID: 328
	private int hjn;
}
