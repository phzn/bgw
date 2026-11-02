using System;
using System.Collections.Generic;
using System.IO;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Steamworks;
using UnityEngine;

// Token: 0x0200002A RID: 42
public static class bj
{
	// Token: 0x06000260 RID: 608 RVA: 0x0000C050 File Offset: 0x0000A250
	public static void duz(uint a)
	{
		if (a == 0U)
		{
			return;
		}
		bj.bi bi = bj.wq(a);
		bi.hiv = true;
		bi.hiw = false;
		bi.hix = null;
		if (!SteamManager.krd)
		{
			return;
		}
		bj.wr();
		AppId_t appId_t = new AppId_t(a);
		if (!SteamApps.BIsDlcInstalled(appId_t))
		{
			return;
		}
		bi.hiw = true;
		string text;
		uint num = SteamApps.GetAppInstallDir(appId_t, out text, 4294967247U);
		if (num == 0U || string.IsNullOrEmpty(text))
		{
			return;
		}
		if (num >= 4294967289U)
		{
			Debug.LogWarning(string.Format(a.mg(), a, num));
			num = SteamApps.GetAppInstallDir(appId_t, out text, 37U);
			if (num == 0U || string.IsNullOrEmpty(text))
			{
				return;
			}
			if (num >= 4294967236U)
			{
				Debug.LogError(string.Format(a.mh(), a, num) + a.mi());
				return;
			}
		}
		bi.hix = text;
	}

	// Token: 0x14000005 RID: 5
	// (add) Token: 0x0600026E RID: 622 RVA: 0x0000C574 File Offset: 0x0000A774
	// (remove) Token: 0x06000261 RID: 609 RVA: 0x0000C124 File Offset: 0x0000A324
	public static event Action<uint> hja;

	// Token: 0x06000262 RID: 610 RVA: 0x0000C157 File Offset: 0x0000A357
	private static void cxj()
	{
		if (bj.hiz != null)
		{
			return;
		}
		if (!SteamManager.krd)
		{
			return;
		}
		bj.hiz = Callback<DlcInstalled_t>.Create(new Callback<DlcInstalled_t>.DispatchDelegate(bj.ws));
	}

	// Token: 0x06000263 RID: 611 RVA: 0x0000C180 File Offset: 0x0000A380
	private static bj.bi kpc(uint a)
	{
		bj.bi bi;
		if (bj.hiy.TryGetValue(a, out bi))
		{
			return bi;
		}
		bi = new bj.bi();
		bj.hiy[a] = bi;
		return bi;
	}

	// Token: 0x06000264 RID: 612 RVA: 0x0000C1B4 File Offset: 0x0000A3B4
	public static void wo()
	{
		bj.wr();
		foreach (DlcInfo dlcInfo in bk.kms)
		{
			bj.wp(dlcInfo.AppId);
		}
	}

	// Token: 0x06000265 RID: 613 RVA: 0x0000C157 File Offset: 0x0000A357
	private static void oek()
	{
		if (bj.hiz != null)
		{
			return;
		}
		if (!SteamManager.krd)
		{
			return;
		}
		bj.hiz = Callback<DlcInstalled_t>.Create(new Callback<DlcInstalled_t>.DispatchDelegate(bj.ws));
	}

	// Token: 0x06000266 RID: 614 RVA: 0x0000C20C File Offset: 0x0000A40C
	private static bj.bi wq(uint a)
	{
		bj.bi bi;
		if (bj.hiy.TryGetValue(a, out bi))
		{
			return bi;
		}
		bi = new bj.bi();
		bj.hiy[a] = bi;
		return bi;
	}

	// Token: 0x06000267 RID: 615 RVA: 0x0000C240 File Offset: 0x0000A440
	public static void wp(uint a)
	{
		if (a == 0U)
		{
			return;
		}
		bj.bi bi = bj.wq(a);
		bi.hiv = true;
		bi.hiw = false;
		bi.hix = null;
		if (!SteamManager.krd)
		{
			return;
		}
		bj.wr();
		AppId_t appId_t = new AppId_t(a);
		if (!SteamApps.BIsDlcInstalled(appId_t))
		{
			return;
		}
		bi.hiw = true;
		string text;
		uint num = SteamApps.GetAppInstallDir(appId_t, out text, 1024U);
		if (num == 0U || string.IsNullOrEmpty(text))
		{
			return;
		}
		if (num >= 1023U)
		{
			Debug.LogWarning(string.Format(a.mj(), a, num));
			num = SteamApps.GetAppInstallDir(appId_t, out text, 4096U);
			if (num == 0U || string.IsNullOrEmpty(text))
			{
				return;
			}
			if (num >= 4095U)
			{
				Debug.LogError(string.Format(a.mk(), a, num) + a.ml());
				return;
			}
		}
		bi.hix = text;
	}

	// Token: 0x06000269 RID: 617 RVA: 0x0000C32C File Offset: 0x0000A52C
	public static bool iiw(uint a, out string b)
	{
		b = null;
		if (a == 0U)
		{
			return false;
		}
		if (!bj.wm(a))
		{
			return false;
		}
		bj.bi bi = bj.wq(a);
		if (!bi.hiv)
		{
			bj.wp(a);
		}
		if (string.IsNullOrEmpty(bi.hix))
		{
			return false;
		}
		if (!Directory.Exists(bi.hix))
		{
			return false;
		}
		b = bi.hix;
		return true;
	}

	// Token: 0x0600026A RID: 618 RVA: 0x0000C388 File Offset: 0x0000A588
	public static void dzg(uint a)
	{
		if (a == 0U)
		{
			return;
		}
		bj.bi bi = bj.wq(a);
		bi.hiv = true;
		bi.hiw = false;
		bi.hix = null;
		if (!SteamManager.krd)
		{
			return;
		}
		bj.wr();
		AppId_t appId_t = new AppId_t(a);
		if (!SteamApps.BIsDlcInstalled(appId_t))
		{
			return;
		}
		bi.hiw = true;
		string text;
		uint num = SteamApps.GetAppInstallDir(appId_t, out text, 77U);
		if (num == 0U || string.IsNullOrEmpty(text))
		{
			return;
		}
		if (num >= 49U)
		{
			Debug.LogWarning(string.Format(a.mm(), a, num));
			num = SteamApps.GetAppInstallDir(appId_t, out text, 19U);
			if (num == 0U || string.IsNullOrEmpty(text))
			{
				return;
			}
			if (num >= 22U)
			{
				Debug.LogError(string.Format(a.mn(), a, num) + a.mo());
				return;
			}
		}
		bi.hix = text;
	}

	// Token: 0x0600026B RID: 619 RVA: 0x0000C45C File Offset: 0x0000A65C
	public static void mkn()
	{
		bj.wr();
		foreach (DlcInfo dlcInfo in bk.kms)
		{
			bj.wp(dlcInfo.AppId);
		}
	}

	// Token: 0x0600026C RID: 620 RVA: 0x0000C4B4 File Offset: 0x0000A6B4
	private static void ws(DlcInstalled_t a)
	{
		uint appId = a.m_nAppID.m_AppId;
		DlcInfo dlcInfo;
		if (!bk.wu(appId, out dlcInfo))
		{
			return;
		}
		Debug.Log(string.Format(a.mp(), appId));
		bj.wp(appId);
		bq.bao();
		Action<uint> action = bj.hja;
		if (action == null)
		{
			return;
		}
		foreach (Delegate @delegate in action.GetInvocationList())
		{
			try
			{
				((Action<uint>)@delegate)(appId);
			}
			catch (Exception ex)
			{
				Debug.LogException(ex);
			}
		}
	}

	// Token: 0x0600026D RID: 621 RVA: 0x0000C548 File Offset: 0x0000A748
	public static bool wm(uint a)
	{
		if (a == 0U)
		{
			return false;
		}
		if (!SteamManager.krd)
		{
			return false;
		}
		bj.bi bi = bj.wq(a);
		if (!bi.hiv)
		{
			bj.wp(a);
		}
		return bi.hiw;
	}

	// Token: 0x0600026F RID: 623 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
	public static bool wn(uint a, out string b)
	{
		b = null;
		if (a == 0U)
		{
			return false;
		}
		if (!bj.wm(a))
		{
			return false;
		}
		bj.bi bi = bj.wq(a);
		if (!bi.hiv)
		{
			bj.wp(a);
		}
		if (string.IsNullOrEmpty(bi.hix))
		{
			return false;
		}
		if (!Directory.Exists(bi.hix))
		{
			return false;
		}
		b = bi.hix;
		return true;
	}

	// Token: 0x06000270 RID: 624 RVA: 0x0000C157 File Offset: 0x0000A357
	private static void wr()
	{
		if (bj.hiz != null)
		{
			return;
		}
		if (!SteamManager.krd)
		{
			return;
		}
		bj.hiz = Callback<DlcInstalled_t>.Create(new Callback<DlcInstalled_t>.DispatchDelegate(bj.ws));
	}

	// Token: 0x06000271 RID: 625 RVA: 0x0000C604 File Offset: 0x0000A804
	public static void egd()
	{
		bj.wr();
		foreach (DlcInfo dlcInfo in bk.kms)
		{
			bj.wp(dlcInfo.AppId);
		}
	}

	// Token: 0x06000272 RID: 626 RVA: 0x0000C65C File Offset: 0x0000A85C
	public static bool hqi(uint a, out string b)
	{
		b = null;
		if (a == 0U)
		{
			return false;
		}
		if (!bj.wm(a))
		{
			return false;
		}
		bj.bi bi = bj.wq(a);
		if (!bi.hiv)
		{
			bj.wp(a);
		}
		if (string.IsNullOrEmpty(bi.hix))
		{
			return false;
		}
		if (!Directory.Exists(bi.hix))
		{
			return false;
		}
		b = bi.hix;
		return true;
	}

	// Token: 0x06000273 RID: 627 RVA: 0x0000C6B8 File Offset: 0x0000A8B8
	public static bool jou(uint a, out string b)
	{
		b = null;
		if (a == 0U)
		{
			return false;
		}
		if (!bj.wm(a))
		{
			return false;
		}
		bj.bi bi = bj.wq(a);
		if (!bi.hiv)
		{
			bj.wp(a);
		}
		if (string.IsNullOrEmpty(bi.hix))
		{
			return false;
		}
		if (!Directory.Exists(bi.hix))
		{
			return false;
		}
		b = bi.hix;
		return true;
	}

	// Token: 0x06000274 RID: 628 RVA: 0x0000C714 File Offset: 0x0000A914
	private static bj.bi fmd(uint a)
	{
		bj.bi bi;
		if (bj.hiy.TryGetValue(a, out bi))
		{
			return bi;
		}
		bi = new bj.bi();
		bj.hiy[a] = bi;
		return bi;
	}

	// Token: 0x06000275 RID: 629 RVA: 0x0000C748 File Offset: 0x0000A948
	public static void mvt(uint a)
	{
		if (a == 0U)
		{
			return;
		}
		bj.bi bi = bj.wq(a);
		bi.hiv = true;
		bi.hiw = false;
		bi.hix = null;
		if (!SteamManager.krd)
		{
			return;
		}
		bj.wr();
		AppId_t appId_t = new AppId_t(a);
		if (!SteamApps.BIsDlcInstalled(appId_t))
		{
			return;
		}
		bi.hiw = true;
		string text;
		uint num = SteamApps.GetAppInstallDir(appId_t, out text, 4294967232U);
		if (num == 0U || string.IsNullOrEmpty(text))
		{
			return;
		}
		if (num >= 4294967208U)
		{
			Debug.LogWarning(string.Format(a.mq(), a, num));
			num = SteamApps.GetAppInstallDir(appId_t, out text, 4294967243U);
			if (num == 0U || string.IsNullOrEmpty(text))
			{
				return;
			}
			if (num >= 25U)
			{
				Debug.LogError(string.Format(a.mr(), a, num) + a.ms());
				return;
			}
		}
		bi.hix = text;
	}

	// Token: 0x06000276 RID: 630 RVA: 0x0000C157 File Offset: 0x0000A357
	private static void mzl()
	{
		if (bj.hiz != null)
		{
			return;
		}
		if (!SteamManager.krd)
		{
			return;
		}
		bj.hiz = Callback<DlcInstalled_t>.Create(new Callback<DlcInstalled_t>.DispatchDelegate(bj.ws));
	}

	// Token: 0x0400012B RID: 299
	private static readonly Dictionary<uint, bj.bi> hiy = new Dictionary<uint, bj.bi>();

	// Token: 0x0400012C RID: 300
	private static Callback<DlcInstalled_t> hiz;

	// Token: 0x0200002B RID: 43
	private sealed class bi
	{
		// Token: 0x0400012E RID: 302
		public bool hiv;

		// Token: 0x0400012F RID: 303
		public bool hiw;

		// Token: 0x04000130 RID: 304
		public string hix;
	}
}
