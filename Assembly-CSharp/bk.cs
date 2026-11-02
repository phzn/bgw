using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};

// Token: 0x0200002E RID: 46
public static class bk
{
	// Token: 0x17000037 RID: 55
	// (get) Token: 0x0600027D RID: 637 RVA: 0x0000C867 File Offset: 0x0000AA67
	public static IReadOnlyList<DlcInfo> kms
	{
		get
		{
			return bk.hje;
		}
	}

	// Token: 0x0600027F RID: 639 RVA: 0x0000C8A8 File Offset: 0x0000AAA8
	public static bool wv(string a, out DlcInfo b)
	{
		foreach (DlcInfo dlcInfo in bk.hje)
		{
			if (string.Equals(dlcInfo.BundleName, a, StringComparison.OrdinalIgnoreCase))
			{
				b = dlcInfo;
				return true;
			}
		}
		b = default(DlcInfo);
		return false;
	}

	// Token: 0x06000280 RID: 640 RVA: 0x0000C8F4 File Offset: 0x0000AAF4
	public static bool heb(string a, out DlcInfo b)
	{
		foreach (DlcInfo dlcInfo in bk.hje)
		{
			if (string.Equals(dlcInfo.BundleName, a, StringComparison.OrdinalIgnoreCase))
			{
				b = dlcInfo;
				return true;
			}
		}
		b = default(DlcInfo);
		return false;
	}

	// Token: 0x06000281 RID: 641 RVA: 0x0000C940 File Offset: 0x0000AB40
	public static bool bvu(uint a, out DlcInfo b)
	{
		foreach (DlcInfo dlcInfo in bk.hje)
		{
			if (dlcInfo.AppId == a)
			{
				b = dlcInfo;
				return true;
			}
		}
		b = default(DlcInfo);
		return false;
	}

	// Token: 0x06000282 RID: 642 RVA: 0x0000C984 File Offset: 0x0000AB84
	public static bool wu(uint a, out DlcInfo b)
	{
		foreach (DlcInfo dlcInfo in bk.hje)
		{
			if (dlcInfo.AppId == a)
			{
				b = dlcInfo;
				return true;
			}
		}
		b = default(DlcInfo);
		return false;
	}

	// Token: 0x04000138 RID: 312
	public const uint hjb = 4716380U;

	// Token: 0x04000139 RID: 313
	public const string hjc = "Content";

	// Token: 0x0400013A RID: 314
	public static readonly DlcInfo hjd = new DlcInfo(4716380U, a.mt(), a.mu(), a.mv());

	// Token: 0x0400013B RID: 315
	private static readonly DlcInfo[] hje = new DlcInfo[] { bk.hjd };
}
