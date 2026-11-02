using System;
using Steamworks;

// Token: 0x020000CE RID: 206
public static class ec
{
	// Token: 0x06000AAE RID: 2734 RVA: 0x0003E634 File Offset: 0x0003C834
	public static bool kcj(int a)
	{
		bl bl = bl.kmv;
		if (bl == null)
		{
			return false;
		}
		CatCharacterDefinition catCharacterDefinition = bl.xp(a);
		if (catCharacterDefinition == null)
		{
			return false;
		}
		if (catCharacterDefinition.unlockType != CatUnlockType.DLC)
		{
			return false;
		}
		if (!SteamManager.krd)
		{
			return !bq.knc;
		}
		return !SteamApps.BIsDlcInstalled(new AppId_t(catCharacterDefinition.dlcAppId));
	}

	// Token: 0x06000AAF RID: 2735 RVA: 0x0003E694 File Offset: 0x0003C894
	public static bool cia(int a)
	{
		bl bl = bl.kmv;
		if (bl == null)
		{
			return false;
		}
		CatCharacterDefinition catCharacterDefinition = bl.xp(a);
		if (catCharacterDefinition == null)
		{
			return false;
		}
		if (catCharacterDefinition.unlockType != CatUnlockType.DLC)
		{
			return false;
		}
		if (!SteamManager.krd)
		{
			return !bq.knc;
		}
		return !SteamApps.BIsDlcInstalled(new AppId_t(catCharacterDefinition.dlcAppId));
	}
}
