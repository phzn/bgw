using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using RamenCat;
using UnityEngine;

// Token: 0x02000040 RID: 64
public class by : MonoBehaviour
{
	// Token: 0x060003EB RID: 1003 RVA: 0x00013B80 File Offset: 0x00011D80
	private void bdo(ItemData a, string b)
	{
		Debug.Log(string.Concat(new string[]
		{
			a.up(),
			a.name,
			a.uq(),
			b,
			a.ur()
		}));
		this.showGiftManager.ccf(a, b);
		if (by.bdp(b))
		{
			if (DropProgressIndicator.hkp != null)
			{
				DropProgressIndicator.hkp.zb();
			}
			Action<string> action = by.hol;
			if (action == null)
			{
				return;
			}
			action(a.bir());
		}
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x00013C03 File Offset: 0x00011E03
	private static bool bdp(string a)
	{
		return !string.IsNullOrEmpty(a) && a.StartsWith(a.us(), StringComparison.Ordinal);
	}

	// Token: 0x1400000A RID: 10
	// (add) Token: 0x060003EF RID: 1007 RVA: 0x00013C50 File Offset: 0x00011E50
	// (remove) Token: 0x060003ED RID: 1005 RVA: 0x00013C1C File Offset: 0x00011E1C
	public static event Action<string> hol;

	// Token: 0x060003F0 RID: 1008 RVA: 0x00013C84 File Offset: 0x00011E84
	private void kky(ItemData a, string b)
	{
		Debug.Log(string.Concat(new string[]
		{
			a.ut(),
			a.name,
			a.uu(),
			b,
			a.uv()
		}));
		this.showGiftManager.ccf(a, b);
		if (by.bdp(b))
		{
			if (DropProgressIndicator.hkp != null)
			{
				DropProgressIndicator.hkp.zb();
			}
			Action<string> action = by.hol;
			if (action == null)
			{
				return;
			}
			action(a.bir());
		}
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x00013D07 File Offset: 0x00011F07
	private void mys()
	{
		this.bdl();
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x00013D07 File Offset: 0x00011F07
	private void ogv()
	{
		this.bdl();
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x00013D0F File Offset: 0x00011F0F
	private static bool kye(string a)
	{
		return !string.IsNullOrEmpty(a) && a.StartsWith(a.uw(), StringComparison.Ordinal);
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x00013D27 File Offset: 0x00011F27
	public void OnDestroy()
	{
		SteamManager.ibn -= this.bdk;
		if (SteamInventoryManager.iid != null)
		{
			SteamInventoryManager.iid.iig -= this.bdo;
		}
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00013D5D File Offset: 0x00011F5D
	// (set) Token: 0x060003FE RID: 1022 RVA: 0x00013E13 File Offset: 0x00012013
	public static by hok { get; private set; }

	// Token: 0x060003F6 RID: 1014 RVA: 0x00013D64 File Offset: 0x00011F64
	private void kwq()
	{
		by.hok = this;
		SteamManager.ibn -= this.bdk;
		SteamManager.ibn += this.bdk;
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x00013D64 File Offset: 0x00011F64
	private void ej()
	{
		by.hok = this;
		SteamManager.ibn -= this.bdk;
		SteamManager.ibn += this.bdk;
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x00013D07 File Offset: 0x00011F07
	private void col()
	{
		this.bdl();
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x00013D90 File Offset: 0x00011F90
	public void bdl()
	{
		if (!SteamManager.krd)
		{
			Debug.LogError(a.ux());
			return;
		}
		if (this.hoj)
		{
			return;
		}
		if (SteamInventoryManager.iid == null)
		{
			return;
		}
		SteamInventoryManager.iid.iig += this.bdo;
		this.hoj = true;
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x00013D64 File Offset: 0x00011F64
	private void Awake()
	{
		by.hok = this;
		SteamManager.ibn -= this.bdk;
		SteamManager.ibn += this.bdk;
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x00013DE3 File Offset: 0x00011FE3
	private static bool ctq(string a)
	{
		return !string.IsNullOrEmpty(a) && a.StartsWith(a.uy(), StringComparison.Ordinal);
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x00013DFB File Offset: 0x00011FFB
	private static bool cov(string a)
	{
		return !string.IsNullOrEmpty(a) && a.StartsWith(a.uz(), StringComparison.Ordinal);
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x00013D07 File Offset: 0x00011F07
	private void bdk()
	{
		this.bdl();
	}

	// Token: 0x040001E0 RID: 480
	public @do showGiftManager;

	// Token: 0x040001E1 RID: 481
	private bool hoj;
}
