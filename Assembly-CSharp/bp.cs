using System;
using System.Collections.Generic;

// Token: 0x02000035 RID: 53
public static class bp
{
	// Token: 0x06000313 RID: 787 RVA: 0x0000EFD4 File Offset: 0x0000D1D4
	public static bool ckx(int a)
	{
		if (a == 0)
		{
			return false;
		}
		SpineSkinSetting hle = bq.hle;
		if (hle == null)
		{
			return false;
		}
		SpineSkinData spineSkinData = hle.bjx(a);
		return spineSkinData != null && !bp.zn(spineSkinData.type);
	}

	// Token: 0x06000314 RID: 788 RVA: 0x0000F014 File Offset: 0x0000D214
	public static void bpj(int a)
	{
		if (!bp.zo(a))
		{
			return;
		}
		PlayerData hlf = bq.hlf;
		List<int> list;
		if (hlf == null)
		{
			list = null;
		}
		else
		{
			PlayerSaveData playerSaveData = hlf.playerSaveData;
			list = ((playerSaveData != null) ? playerSaveData.favoriteItemDefIds : null);
		}
		List<int> list2 = list;
		if (list2 == null)
		{
			return;
		}
		if (!list2.Remove(a))
		{
			list2.Add(a);
		}
		ci.Save(null);
		Action action = bp.hky;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000315 RID: 789 RVA: 0x0000F074 File Offset: 0x0000D274
	public static bool bgd(int a)
	{
		if (a == 0)
		{
			return false;
		}
		SpineSkinSetting hle = bq.hle;
		if (hle == null)
		{
			return false;
		}
		SpineSkinData spineSkinData = hle.bjx(a);
		return spineSkinData != null && !bp.zn(spineSkinData.type);
	}

	// Token: 0x06000316 RID: 790 RVA: 0x0000F0B2 File Offset: 0x0000D2B2
	private static bool zn(CLOTHE_TYPE a)
	{
		return a == CLOTHE_TYPE.Dick || a == CLOTHE_TYPE.SkinTone || a == CLOTHE_TYPE.IntimateParts || a == CLOTHE_TYPE.PubicAndGenital;
	}

	// Token: 0x06000317 RID: 791 RVA: 0x0000F0C8 File Offset: 0x0000D2C8
	public static bool zp(int a)
	{
		PlayerData hlf = bq.hlf;
		List<int> list;
		if (hlf == null)
		{
			list = null;
		}
		else
		{
			PlayerSaveData playerSaveData = hlf.playerSaveData;
			list = ((playerSaveData != null) ? playerSaveData.favoriteItemDefIds : null);
		}
		List<int> list2 = list;
		return list2 != null && list2.Contains(a);
	}

	// Token: 0x06000318 RID: 792 RVA: 0x0000F0FF File Offset: 0x0000D2FF
	private static bool kcj(CLOTHE_TYPE a)
	{
		return a == CLOTHE_TYPE.Dick || a == (CLOTHE_TYPE)46 || a == (CLOTHE_TYPE)(-93) || a == (CLOTHE_TYPE)7;
	}

	// Token: 0x06000319 RID: 793 RVA: 0x0000F114 File Offset: 0x0000D314
	public static void odg(int a)
	{
		if (!bp.zo(a))
		{
			return;
		}
		PlayerData hlf = bq.hlf;
		List<int> list;
		if (hlf == null)
		{
			list = null;
		}
		else
		{
			PlayerSaveData playerSaveData = hlf.playerSaveData;
			list = ((playerSaveData != null) ? playerSaveData.favoriteItemDefIds : null);
		}
		List<int> list2 = list;
		if (list2 == null)
		{
			return;
		}
		if (!list2.Remove(a))
		{
			list2.Add(a);
		}
		ci.Save(null);
		Action action = bp.hky;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x0600031A RID: 794 RVA: 0x0000F174 File Offset: 0x0000D374
	public static bool elq(int a)
	{
		if (a == 0)
		{
			return false;
		}
		SpineSkinSetting hle = bq.hle;
		if (hle == null)
		{
			return false;
		}
		SpineSkinData spineSkinData = hle.bjx(a);
		return spineSkinData != null && !bp.zn(spineSkinData.type);
	}

	// Token: 0x0600031B RID: 795 RVA: 0x0000F1B4 File Offset: 0x0000D3B4
	public static void ejy(int a)
	{
		if (!bp.zo(a))
		{
			return;
		}
		PlayerData hlf = bq.hlf;
		List<int> list;
		if (hlf == null)
		{
			list = null;
		}
		else
		{
			PlayerSaveData playerSaveData = hlf.playerSaveData;
			list = ((playerSaveData != null) ? playerSaveData.favoriteItemDefIds : null);
		}
		List<int> list2 = list;
		if (list2 == null)
		{
			return;
		}
		if (!list2.Remove(a))
		{
			list2.Add(a);
		}
		ci.Save(null);
		Action action = bp.hky;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x0600031C RID: 796 RVA: 0x0000F214 File Offset: 0x0000D414
	public static bool frh(int a)
	{
		PlayerData hlf = bq.hlf;
		List<int> list;
		if (hlf == null)
		{
			list = null;
		}
		else
		{
			PlayerSaveData playerSaveData = hlf.playerSaveData;
			list = ((playerSaveData != null) ? playerSaveData.favoriteItemDefIds : null);
		}
		List<int> list2 = list;
		return list2 != null && list2.Contains(a);
	}

	// Token: 0x0600031D RID: 797 RVA: 0x0000F24C File Offset: 0x0000D44C
	public static void zq(int a)
	{
		if (!bp.zo(a))
		{
			return;
		}
		PlayerData hlf = bq.hlf;
		List<int> list;
		if (hlf == null)
		{
			list = null;
		}
		else
		{
			PlayerSaveData playerSaveData = hlf.playerSaveData;
			list = ((playerSaveData != null) ? playerSaveData.favoriteItemDefIds : null);
		}
		List<int> list2 = list;
		if (list2 == null)
		{
			return;
		}
		if (!list2.Remove(a))
		{
			list2.Add(a);
		}
		ci.Save(null);
		Action action = bp.hky;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x14000008 RID: 8
	// (add) Token: 0x0600031E RID: 798 RVA: 0x0000F2AC File Offset: 0x0000D4AC
	// (remove) Token: 0x06000323 RID: 803 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
	public static event Action hky;

	// Token: 0x0600031F RID: 799 RVA: 0x0000F2E0 File Offset: 0x0000D4E0
	public static bool keb(int a)
	{
		PlayerData hlf = bq.hlf;
		List<int> list;
		if (hlf == null)
		{
			list = null;
		}
		else
		{
			PlayerSaveData playerSaveData = hlf.playerSaveData;
			list = ((playerSaveData != null) ? playerSaveData.favoriteItemDefIds : null);
		}
		List<int> list2 = list;
		return list2 != null && list2.Contains(a);
	}

	// Token: 0x06000320 RID: 800 RVA: 0x0000F318 File Offset: 0x0000D518
	public static bool lgd(int a)
	{
		PlayerData hlf = bq.hlf;
		List<int> list;
		if (hlf == null)
		{
			list = null;
		}
		else
		{
			PlayerSaveData playerSaveData = hlf.playerSaveData;
			list = ((playerSaveData != null) ? playerSaveData.favoriteItemDefIds : null);
		}
		List<int> list2 = list;
		return list2 != null && list2.Contains(a);
	}

	// Token: 0x06000321 RID: 801 RVA: 0x0000F350 File Offset: 0x0000D550
	public static void mla(int a)
	{
		if (!bp.zo(a))
		{
			return;
		}
		PlayerData hlf = bq.hlf;
		List<int> list;
		if (hlf == null)
		{
			list = null;
		}
		else
		{
			PlayerSaveData playerSaveData = hlf.playerSaveData;
			list = ((playerSaveData != null) ? playerSaveData.favoriteItemDefIds : null);
		}
		List<int> list2 = list;
		if (list2 == null)
		{
			return;
		}
		if (!list2.Remove(a))
		{
			list2.Add(a);
		}
		ci.Save(null);
		Action action = bp.hky;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000322 RID: 802 RVA: 0x0000F3B0 File Offset: 0x0000D5B0
	public static bool zo(int a)
	{
		if (a == 0)
		{
			return false;
		}
		SpineSkinSetting hle = bq.hle;
		if (hle == null)
		{
			return false;
		}
		SpineSkinData spineSkinData = hle.bjx(a);
		return spineSkinData != null && !bp.zn(spineSkinData.type);
	}
}
