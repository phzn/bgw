using System;
using Steamworks;

// Token: 0x02000015 RID: 21
public static class l
{
	// Token: 0x17000025 RID: 37
	// (get) Token: 0x060000E7 RID: 231 RVA: 0x00005F39 File Offset: 0x00004139
	public static bool kme
	{
		get
		{
			return SteamManager.krd && !SteamManager.ibh;
		}
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x00005F4C File Offset: 0x0000414C
	public static int hun(BgmAlbumConfig a)
	{
		if (a == null)
		{
			return -1;
		}
		for (int i = 0; i < a.kow; i++)
		{
			if (!l.sx(a, a.bil(i)))
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00005F88 File Offset: 0x00004188
	public static bool sx(BgmAlbumConfig a, BgmTrack b)
	{
		if (b == null || !b.requiresDlc)
		{
			return false;
		}
		if (a == null || a.dlcAppId == 0U)
		{
			return true;
		}
		if (!l.kme)
		{
			return !bq.knc;
		}
		return !SteamApps.BIsDlcInstalled(new AppId_t(a.dlcAppId));
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00005FD8 File Offset: 0x000041D8
	public static int frd(BgmAlbumConfig a)
	{
		if (a == null)
		{
			return -1;
		}
		for (int i = 0; i < a.kow; i++)
		{
			if (!l.sx(a, a.bil(i)))
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00006014 File Offset: 0x00004214
	public static int jtb(BgmAlbumConfig a)
	{
		if (a == null)
		{
			return -1;
		}
		for (int i = 0; i < a.kow; i++)
		{
			if (!l.sx(a, a.bil(i)))
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00006050 File Offset: 0x00004250
	public static int oqq(BgmAlbumConfig a)
	{
		if (a == null)
		{
			return -1;
		}
		for (int i = 0; i < a.kow; i++)
		{
			if (!l.sx(a, a.bil(i)))
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x060000ED RID: 237 RVA: 0x0000608C File Offset: 0x0000428C
	public static int sy(BgmAlbumConfig a)
	{
		if (a == null)
		{
			return -1;
		}
		for (int i = 0; i < a.kow; i++)
		{
			if (!l.sx(a, a.bil(i)))
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x060000EE RID: 238 RVA: 0x000060C7 File Offset: 0x000042C7
	public static bool kmf
	{
		get
		{
			return l.kme || bq.knc;
		}
	}
}
