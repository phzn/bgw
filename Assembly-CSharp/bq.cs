using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using FMODUnity;
using UnityEngine;

// Token: 0x02000038 RID: 56
public static class bq
{
	// Token: 0x06000324 RID: 804 RVA: 0x0000F424 File Offset: 0x0000D624
	public static int epm(int a)
	{
		if (bq.hlj == null)
		{
			return 0;
		}
		int num = 0;
		for (int i = 0; i < bq.hlj.Length; i++)
		{
			ItemData itemData = bq.hlj[i];
			if (itemData != null && itemData.defID == a)
			{
				num += (int)itemData.quantity;
			}
		}
		return num;
	}

	// Token: 0x06000325 RID: 805 RVA: 0x0000F46C File Offset: 0x0000D66C
	public static void zs()
	{
		bq.hmc = PlayerPrefs.GetInt(a.ri(), 1) == 1;
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x06000326 RID: 806 RVA: 0x0000F481 File Offset: 0x0000D681
	public static int kni
	{
		get
		{
			return bq.ban(CLOTHE_TYPE.Top, bq.hlf.playerSaveData.desiredTopUse);
		}
	}

	// Token: 0x06000327 RID: 807 RVA: 0x0000F498 File Offset: 0x0000D698
	public static EventReference maw(Func<VoiceProfile, EventReference> a, EventReference b)
	{
		VoiceProfile voiceProfile = bq.kne;
		if (voiceProfile != null)
		{
			EventReference eventReference = a(voiceProfile);
			if (!eventReference.IsNull)
			{
				return eventReference;
			}
		}
		return b;
	}

	// Token: 0x06000328 RID: 808 RVA: 0x0000F4C2 File Offset: 0x0000D6C2
	public static void bac()
	{
		if (du.iah != null)
		{
			du.iah.cef(du.STEAM_STAT_ID.STAT_CLICK, out bq.hln);
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x06000329 RID: 809 RVA: 0x0000F4E1 File Offset: 0x0000D6E1
	public static int knm
	{
		get
		{
			return bq.ban(CLOTHE_TYPE.Shoes, bq.hlf.playerSaveData.desiredShoesUse);
		}
	}

	// Token: 0x0600032A RID: 810 RVA: 0x0000F4F9 File Offset: 0x0000D6F9
	public static void zt()
	{
		bq.hmd = PlayerPrefs.GetInt(a.rj(), 0) == 1;
	}

	// Token: 0x0600032B RID: 811 RVA: 0x0000F510 File Offset: 0x0000D710
	public static void gdg()
	{
		SpineSkinData spineSkinData = bq.hle.bjy(bq.hlf.playerSaveData.desiredDickUse, CLOTHE_TYPE.Dick);
		if (spineSkinData != null)
		{
			spineSkinData.bjo();
		}
		SpineSkinData spineSkinData2 = bq.hle.bjy(bq.hlf.playerSaveData.desiredHairUse, CLOTHE_TYPE.Hair);
		if (spineSkinData2 != null)
		{
			spineSkinData2.bjo();
		}
		SpineSkinData spineSkinData3 = bq.hle.bjy(bq.hlf.playerSaveData.desiredTopUse, CLOTHE_TYPE.Top);
		if (spineSkinData3 != null)
		{
			spineSkinData3.bjo();
		}
		SpineSkinData spineSkinData4 = bq.hle.bjy(bq.hlf.playerSaveData.desiredBottomUse, CLOTHE_TYPE.Bottom);
		if (spineSkinData4 != null)
		{
			spineSkinData4.bjo();
		}
		SpineSkinData spineSkinData5 = bq.hle.bjy(bq.hlf.playerSaveData.desiredUnderwearUse, CLOTHE_TYPE.Underwear);
		if (spineSkinData5 != null)
		{
			spineSkinData5.bjo();
		}
		SpineSkinData spineSkinData6 = bq.hle.bjy(bq.hlf.playerSaveData.desiredSocksUse, CLOTHE_TYPE.Socks);
		if (spineSkinData6 != null)
		{
			spineSkinData6.bjo();
		}
		SpineSkinData spineSkinData7 = bq.hle.bjy(bq.hlf.playerSaveData.desiredShoesUse, (CLOTHE_TYPE)22);
		if (spineSkinData7 != null)
		{
			spineSkinData7.bjo();
		}
		bq.hle.bkp();
		bq.bao();
	}

	// Token: 0x0600032C RID: 812 RVA: 0x0000F4C2 File Offset: 0x0000D6C2
	public static void fnt()
	{
		if (du.iah != null)
		{
			du.iah.cef(du.STEAM_STAT_ID.STAT_CLICK, out bq.hln);
		}
	}

	// Token: 0x0600032D RID: 813 RVA: 0x0000F630 File Offset: 0x0000D830
	public static void bap(CLOTHE_TYPE a)
	{
		bq.hme.Remove(a);
	}

	// Token: 0x0600032E RID: 814 RVA: 0x0000F640 File Offset: 0x0000D840
	public static void baq(IReadOnlyList<ItemData> a)
	{
		int count = a.Count;
		ItemData[] array = bq.hlf.itemDatas;
		if (array == null || array.Length != count)
		{
			ItemData[] array2 = new ItemData[count];
			int num = ((array != null) ? ((array.Length < count) ? array.Length : count) : 0);
			for (int i = 0; i < num; i++)
			{
				array2[i] = array[i];
			}
			array = array2;
		}
		for (int j = 0; j < count; j++)
		{
			if (array[j] == null)
			{
				array[j] = new ItemData();
			}
			a[j].biw(array[j]);
		}
		bq.hlj = array;
		bq.hlf.itemDatas = array;
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x0600032F RID: 815 RVA: 0x0000F6DD File Offset: 0x0000D8DD
	public static int knl
	{
		get
		{
			return bq.ban(CLOTHE_TYPE.Socks, bq.hlf.playerSaveData.desiredSocksUse);
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x06000330 RID: 816 RVA: 0x0000F6F4 File Offset: 0x0000D8F4
	public static int knh
	{
		get
		{
			return bq.ban(CLOTHE_TYPE.Hair, bq.hlf.playerSaveData.desiredHairUse);
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x06000331 RID: 817 RVA: 0x0000F70B File Offset: 0x0000D90B
	public static int knj
	{
		get
		{
			return bq.ban(CLOTHE_TYPE.Bottom, bq.hlf.playerSaveData.desiredBottomUse);
		}
	}

	// Token: 0x06000332 RID: 818 RVA: 0x0000F724 File Offset: 0x0000D924
	public static int bar(int a)
	{
		if (bq.hlj == null)
		{
			return 0;
		}
		int num = 0;
		for (int i = 0; i < bq.hlj.Length; i++)
		{
			ItemData itemData = bq.hlj[i];
			if (itemData != null && itemData.defID == a)
			{
				num += (int)itemData.quantity;
			}
		}
		return num;
	}

	// Token: 0x06000333 RID: 819 RVA: 0x0000F76C File Offset: 0x0000D96C
	public static void bas()
	{
		SpineSkinData spineSkinData = bq.hle.bjy(bq.hlf.playerSaveData.desiredDickUse, CLOTHE_TYPE.Dick);
		if (spineSkinData != null)
		{
			spineSkinData.bjo();
		}
		SpineSkinData spineSkinData2 = bq.hle.bjy(bq.hlf.playerSaveData.desiredHairUse, CLOTHE_TYPE.Hair);
		if (spineSkinData2 != null)
		{
			spineSkinData2.bjo();
		}
		SpineSkinData spineSkinData3 = bq.hle.bjy(bq.hlf.playerSaveData.desiredTopUse, CLOTHE_TYPE.Top);
		if (spineSkinData3 != null)
		{
			spineSkinData3.bjo();
		}
		SpineSkinData spineSkinData4 = bq.hle.bjy(bq.hlf.playerSaveData.desiredBottomUse, CLOTHE_TYPE.Bottom);
		if (spineSkinData4 != null)
		{
			spineSkinData4.bjo();
		}
		SpineSkinData spineSkinData5 = bq.hle.bjy(bq.hlf.playerSaveData.desiredUnderwearUse, CLOTHE_TYPE.Underwear);
		if (spineSkinData5 != null)
		{
			spineSkinData5.bjo();
		}
		SpineSkinData spineSkinData6 = bq.hle.bjy(bq.hlf.playerSaveData.desiredSocksUse, CLOTHE_TYPE.Socks);
		if (spineSkinData6 != null)
		{
			spineSkinData6.bjo();
		}
		SpineSkinData spineSkinData7 = bq.hle.bjy(bq.hlf.playerSaveData.desiredShoesUse, CLOTHE_TYPE.Shoes);
		if (spineSkinData7 != null)
		{
			spineSkinData7.bjo();
		}
		bq.hle.bkp();
		bq.bao();
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x06000334 RID: 820 RVA: 0x0000F88C File Offset: 0x0000DA8C
	public static VoiceProfile kne
	{
		get
		{
			if (!(bq.hlg != null))
			{
				return null;
			}
			return bq.hlg.bld(bq.hlh);
		}
	}

	// Token: 0x06000335 RID: 821 RVA: 0x0000F8AC File Offset: 0x0000DAAC
	public static void nxv()
	{
		int num = PlayerPrefs.GetInt(a.rk(), 2);
		if (!Enum.IsDefined(typeof(DirtinessMode), num))
		{
			num = 2;
		}
		bq.hmb = (DirtinessMode)num;
	}

	// Token: 0x06000336 RID: 822 RVA: 0x0000F8E4 File Offset: 0x0000DAE4
	public static EventReference msd(Func<VoiceProfile, EventReference> a, EventReference b)
	{
		VoiceProfile voiceProfile = bq.kne;
		if (voiceProfile != null)
		{
			EventReference eventReference = a(voiceProfile);
			if (!eventReference.IsNull)
			{
				return eventReference;
			}
		}
		return b;
	}

	// Token: 0x06000337 RID: 823 RVA: 0x0000F4C2 File Offset: 0x0000D6C2
	public static void inp()
	{
		if (du.iah != null)
		{
			du.iah.cef(du.STEAM_STAT_ID.STAT_CLICK, out bq.hln);
		}
	}

	// Token: 0x06000338 RID: 824 RVA: 0x0000F910 File Offset: 0x0000DB10
	public static int lft(int a)
	{
		if (bq.hlj == null)
		{
			return 0;
		}
		int num = 0;
		for (int i = 0; i < bq.hlj.Length; i++)
		{
			ItemData itemData = bq.hlj[i];
			if (itemData != null && itemData.defID == a)
			{
				num += (int)itemData.quantity;
			}
		}
		return num;
	}

	// Token: 0x06000339 RID: 825 RVA: 0x0000F958 File Offset: 0x0000DB58
	public static void mjj()
	{
		bq.hmd = PlayerPrefs.GetInt(a.rl(), 0) == 1;
	}

	// Token: 0x0600033A RID: 826 RVA: 0x0000F970 File Offset: 0x0000DB70
	public static EventReference nfg(int a, Func<VoiceProfile, EventReference> b, EventReference c)
	{
		if (bq.hlg != null)
		{
			VoiceProfile voiceProfile = bq.hlg.ble(a);
			if (voiceProfile != null)
			{
				EventReference eventReference = b(voiceProfile);
				if (!eventReference.IsNull)
				{
					return eventReference;
				}
			}
		}
		return c;
	}

	// Token: 0x0600033B RID: 827 RVA: 0x0000F630 File Offset: 0x0000D830
	public static void obl(CLOTHE_TYPE a)
	{
		bq.hme.Remove(a);
	}

	// Token: 0x0600033C RID: 828 RVA: 0x0000F9B0 File Offset: 0x0000DBB0
	public static void baa()
	{
		int num = ((bq.hlg != null) ? bq.hlg.kpk : 0);
		int num2 = ((bq.hlg != null) ? bq.hlg.defaultIndex : 0);
		int @int = PlayerPrefs.GetInt(a.rm(), num2);
		bq.hlh = ((num > 0) ? Mathf.Clamp(@int, 0, num - 1) : 0);
	}

	// Token: 0x0600033D RID: 829 RVA: 0x0000FA18 File Offset: 0x0000DC18
	public static EventReference itr(Func<VoiceProfile, EventReference> a, EventReference b)
	{
		VoiceProfile voiceProfile = bq.kne;
		if (voiceProfile != null)
		{
			EventReference eventReference = a(voiceProfile);
			if (!eventReference.IsNull)
			{
				return eventReference;
			}
		}
		return b;
	}

	// Token: 0x0600033E RID: 830 RVA: 0x0000FA44 File Offset: 0x0000DC44
	public static void ogm(IReadOnlyList<ItemData> a)
	{
		int count = a.Count;
		ItemData[] array = bq.hlf.itemDatas;
		if (array == null || array.Length != count)
		{
			ItemData[] array2 = new ItemData[count];
			int num = ((array != null) ? ((array.Length < count) ? array.Length : count) : 0);
			for (int i = 0; i < num; i++)
			{
				array2[i] = array[i];
			}
			array = array2;
		}
		for (int j = 0; j < count; j++)
		{
			if (array[j] == null)
			{
				array[j] = new ItemData();
			}
			a[j].biw(array[j]);
		}
		bq.hlj = array;
		bq.hlf.itemDatas = array;
	}

	// Token: 0x0600033F RID: 831 RVA: 0x0000FAE1 File Offset: 0x0000DCE1
	public static void tn()
	{
		bq.hmd = PlayerPrefs.GetInt(a.rn(), 0) == 1;
	}

	// Token: 0x06000340 RID: 832 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
	public static void cdm()
	{
		int num = ((bq.hlg != null) ? bq.hlg.kpk : 0);
		int num2 = ((bq.hlg != null) ? bq.hlg.defaultIndex : 0);
		int @int = PlayerPrefs.GetInt(a.ro(), num2);
		bq.hlh = ((num > 0) ? Mathf.Clamp(@int, 0, num - 1) : 0);
	}

	// Token: 0x06000342 RID: 834 RVA: 0x0000FBF4 File Offset: 0x0000DDF4
	public static EventReference zz(int a, Func<VoiceProfile, EventReference> b, EventReference c)
	{
		if (bq.hlg != null)
		{
			VoiceProfile voiceProfile = bq.hlg.ble(a);
			if (voiceProfile != null)
			{
				EventReference eventReference = b(voiceProfile);
				if (!eventReference.IsNull)
				{
					return eventReference;
				}
			}
		}
		return c;
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x06000343 RID: 835 RVA: 0x0000FC31 File Offset: 0x0000DE31
	public static bool knc
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06000344 RID: 836 RVA: 0x0000FC34 File Offset: 0x0000DE34
	public static void zu()
	{
		int num = PlayerPrefs.GetInt(a.rp(), 2);
		if (!Enum.IsDefined(typeof(DirtinessMode), num))
		{
			num = 2;
		}
		bq.hmb = (DirtinessMode)num;
	}

	// Token: 0x06000345 RID: 837 RVA: 0x0000FC6C File Offset: 0x0000DE6C
	public static void klm()
	{
		int num = PlayerPrefs.GetInt(a.rq(), 2);
		if (!Enum.IsDefined(typeof(DirtinessMode), num))
		{
			num = 2;
		}
		bq.hmb = (DirtinessMode)num;
	}

	// Token: 0x06000346 RID: 838 RVA: 0x0000FCA4 File Offset: 0x0000DEA4
	public static void rx()
	{
		bq.hmd = PlayerPrefs.GetInt(a.rr(), 0) == 1;
	}

	// Token: 0x06000347 RID: 839 RVA: 0x0000FCBC File Offset: 0x0000DEBC
	public static void gve()
	{
		int num = PlayerPrefs.GetInt(a.rs(), 2);
		if (!Enum.IsDefined(typeof(DirtinessMode), num))
		{
			num = 2;
		}
		bq.hmb = (DirtinessMode)num;
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06000348 RID: 840 RVA: 0x0000FCF4 File Offset: 0x0000DEF4
	public static int knp
	{
		get
		{
			return bq.ban(CLOTHE_TYPE.PubicAndGenital, bq.hlf.playerSaveData.desiredPubicAndGenitalUse);
		}
	}

	// Token: 0x06000349 RID: 841 RVA: 0x0000FD0C File Offset: 0x0000DF0C
	public static EventReference chj(Func<VoiceProfile, EventReference> a, EventReference b)
	{
		VoiceProfile voiceProfile = bq.kne;
		if (voiceProfile != null)
		{
			EventReference eventReference = a(voiceProfile);
			if (!eventReference.IsNull)
			{
				return eventReference;
			}
		}
		return b;
	}

	// Token: 0x0600034A RID: 842 RVA: 0x0000FD38 File Offset: 0x0000DF38
	private static int ban(CLOTHE_TYPE a, int b)
	{
		int num;
		if (bq.hme.TryGetValue(a, out num))
		{
			return num;
		}
		int num2 = ((bq.hle != null) ? bq.hle.bkn(b, a) : 0);
		bq.hme[a] = num2;
		return num2;
	}

	// Token: 0x0600034B RID: 843 RVA: 0x0000FD80 File Offset: 0x0000DF80
	private static int hbs(CLOTHE_TYPE a, int b)
	{
		int num;
		if (bq.hme.TryGetValue(a, out num))
		{
			return num;
		}
		int num2 = ((bq.hle != null) ? bq.hle.bkn(b, a) : 0);
		bq.hme[a] = num2;
		return num2;
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x0600034C RID: 844 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
	public static int knn
	{
		get
		{
			return bq.ban(CLOTHE_TYPE.SkinTone, bq.hlf.playerSaveData.desiredSkinToneUse);
		}
	}

	// Token: 0x0600034D RID: 845 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
	public static EventReference kmx(int a, Func<VoiceProfile, EventReference> b, EventReference c)
	{
		if (bq.hlg != null)
		{
			VoiceProfile voiceProfile = bq.hlg.ble(a);
			if (voiceProfile != null)
			{
				EventReference eventReference = b(voiceProfile);
				if (!eventReference.IsNull)
				{
					return eventReference;
				}
			}
		}
		return c;
	}

	// Token: 0x0600034E RID: 846 RVA: 0x0000FE20 File Offset: 0x0000E020
	public static EventReference oie(int a, Func<VoiceProfile, EventReference> b, EventReference c)
	{
		if (bq.hlg != null)
		{
			VoiceProfile voiceProfile = bq.hlg.ble(a);
			if (voiceProfile != null)
			{
				EventReference eventReference = b(voiceProfile);
				if (!eventReference.IsNull)
				{
					return eventReference;
				}
			}
		}
		return c;
	}

	// Token: 0x0600034F RID: 847 RVA: 0x0000FE60 File Offset: 0x0000E060
	public static void frb()
	{
		int num = ((bq.hlg != null) ? bq.hlg.kpk : 0);
		int num2 = ((bq.hlg != null) ? bq.hlg.defaultIndex : 0);
		int @int = PlayerPrefs.GetInt(a.rt(), num2);
		bq.hlh = ((num > 0) ? Mathf.Clamp(@int, 0, num - 1) : 0);
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x06000350 RID: 848 RVA: 0x0000FEC5 File Offset: 0x0000E0C5
	public static int knf
	{
		get
		{
			return bq.hln;
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06000351 RID: 849 RVA: 0x0000FECC File Offset: 0x0000E0CC
	public static int kno
	{
		get
		{
			return bq.ban(CLOTHE_TYPE.IntimateParts, bq.hlf.playerSaveData.desiredIntimatePartsUse);
		}
	}

	// Token: 0x06000352 RID: 850 RVA: 0x0000FEE4 File Offset: 0x0000E0E4
	public static void bna()
	{
		SpineSkinData spineSkinData = bq.hle.bjy(bq.hlf.playerSaveData.desiredDickUse, CLOTHE_TYPE.Dick);
		if (spineSkinData != null)
		{
			spineSkinData.bjo();
		}
		SpineSkinData spineSkinData2 = bq.hle.bjy(bq.hlf.playerSaveData.desiredHairUse, CLOTHE_TYPE.Hair);
		if (spineSkinData2 != null)
		{
			spineSkinData2.bjo();
		}
		SpineSkinData spineSkinData3 = bq.hle.bjy(bq.hlf.playerSaveData.desiredTopUse, CLOTHE_TYPE.Top);
		if (spineSkinData3 != null)
		{
			spineSkinData3.bjo();
		}
		SpineSkinData spineSkinData4 = bq.hle.bjy(bq.hlf.playerSaveData.desiredBottomUse, CLOTHE_TYPE.Bottom);
		if (spineSkinData4 != null)
		{
			spineSkinData4.bjo();
		}
		SpineSkinData spineSkinData5 = bq.hle.bjy(bq.hlf.playerSaveData.desiredUnderwearUse, CLOTHE_TYPE.Underwear);
		if (spineSkinData5 != null)
		{
			spineSkinData5.bjo();
		}
		SpineSkinData spineSkinData6 = bq.hle.bjy(bq.hlf.playerSaveData.desiredSocksUse, CLOTHE_TYPE.Socks);
		if (spineSkinData6 != null)
		{
			spineSkinData6.bjo();
		}
		SpineSkinData spineSkinData7 = bq.hle.bjy(bq.hlf.playerSaveData.desiredShoesUse, (CLOTHE_TYPE)60);
		if (spineSkinData7 != null)
		{
			spineSkinData7.bjo();
		}
		bq.hle.bkp();
		bq.bao();
	}

	// Token: 0x06000353 RID: 851 RVA: 0x00010004 File Offset: 0x0000E204
	public static void cwa()
	{
		SpineSkinData spineSkinData = bq.hle.bjy(bq.hlf.playerSaveData.desiredDickUse, CLOTHE_TYPE.Dick);
		if (spineSkinData != null)
		{
			spineSkinData.bjo();
		}
		SpineSkinData spineSkinData2 = bq.hle.bjy(bq.hlf.playerSaveData.desiredHairUse, CLOTHE_TYPE.Hair);
		if (spineSkinData2 != null)
		{
			spineSkinData2.bjo();
		}
		SpineSkinData spineSkinData3 = bq.hle.bjy(bq.hlf.playerSaveData.desiredTopUse, CLOTHE_TYPE.Top);
		if (spineSkinData3 != null)
		{
			spineSkinData3.bjo();
		}
		SpineSkinData spineSkinData4 = bq.hle.bjy(bq.hlf.playerSaveData.desiredBottomUse, CLOTHE_TYPE.Bottom);
		if (spineSkinData4 != null)
		{
			spineSkinData4.bjo();
		}
		SpineSkinData spineSkinData5 = bq.hle.bjy(bq.hlf.playerSaveData.desiredUnderwearUse, CLOTHE_TYPE.Underwear);
		if (spineSkinData5 != null)
		{
			spineSkinData5.bjo();
		}
		SpineSkinData spineSkinData6 = bq.hle.bjy(bq.hlf.playerSaveData.desiredSocksUse, CLOTHE_TYPE.Socks);
		if (spineSkinData6 != null)
		{
			spineSkinData6.bjo();
		}
		SpineSkinData spineSkinData7 = bq.hle.bjy(bq.hlf.playerSaveData.desiredShoesUse, (CLOTHE_TYPE)(-87));
		if (spineSkinData7 != null)
		{
			spineSkinData7.bjo();
		}
		bq.hle.bkp();
		bq.bao();
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x06000354 RID: 852 RVA: 0x00010124 File Offset: 0x0000E324
	public static int kng
	{
		get
		{
			return bq.ban(CLOTHE_TYPE.Dick, bq.hlf.playerSaveData.desiredDickUse);
		}
	}

	// Token: 0x06000355 RID: 853 RVA: 0x0001013C File Offset: 0x0000E33C
	public static EventReference zy(Func<VoiceProfile, EventReference> a, EventReference b)
	{
		VoiceProfile voiceProfile = bq.kne;
		if (voiceProfile != null)
		{
			EventReference eventReference = a(voiceProfile);
			if (!eventReference.IsNull)
			{
				return eventReference;
			}
		}
		return b;
	}

	// Token: 0x06000356 RID: 854 RVA: 0x0000F630 File Offset: 0x0000D830
	public static void hpt(CLOTHE_TYPE a)
	{
		bq.hme.Remove(a);
	}

	// Token: 0x06000357 RID: 855 RVA: 0x0000F630 File Offset: 0x0000D830
	public static void dxu(CLOTHE_TYPE a)
	{
		bq.hme.Remove(a);
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x06000358 RID: 856 RVA: 0x00010166 File Offset: 0x0000E366
	public static int knk
	{
		get
		{
			return bq.ban(CLOTHE_TYPE.Underwear, bq.hlf.playerSaveData.desiredUnderwearUse);
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06000359 RID: 857 RVA: 0x0000FC31 File Offset: 0x0000DE31
	public static bool knd
	{
		get
		{
			return false;
		}
	}

	// Token: 0x0600035A RID: 858 RVA: 0x00010180 File Offset: 0x0000E380
	public static void zr()
	{
		int num = PlayerPrefs.GetInt(a.ru(), 2);
		if (!Enum.IsDefined(typeof(DropNotificationMode), num))
		{
			num = 2;
		}
		bq.hma = (DropNotificationMode)num;
	}

	// Token: 0x0600035B RID: 859 RVA: 0x000101B8 File Offset: 0x0000E3B8
	public static void bao()
	{
		bq.hme.Clear();
	}

	// Token: 0x0600035C RID: 860 RVA: 0x000101C4 File Offset: 0x0000E3C4
	public static void cuy()
	{
		int num = PlayerPrefs.GetInt(a.rv(), 2);
		if (!Enum.IsDefined(typeof(DropNotificationMode), num))
		{
			num = 2;
		}
		bq.hma = (DropNotificationMode)num;
	}

	// Token: 0x0600035D RID: 861 RVA: 0x000101FC File Offset: 0x0000E3FC
	private static int mlz(CLOTHE_TYPE a, int b)
	{
		int num;
		if (bq.hme.TryGetValue(a, out num))
		{
			return num;
		}
		int num2 = ((bq.hle != null) ? bq.hle.bkn(b, a) : 0);
		bq.hme[a] = num2;
		return num2;
	}

	// Token: 0x0600035E RID: 862 RVA: 0x0000F4C2 File Offset: 0x0000D6C2
	public static void lqa()
	{
		if (du.iah != null)
		{
			du.iah.cef(du.STEAM_STAT_ID.STAT_CLICK, out bq.hln);
		}
	}

	// Token: 0x0400017B RID: 379
	public const string hkz = "Settings_DropNotification";

	// Token: 0x0400017C RID: 380
	public const string hla = "Settings_DropAnimation";

	// Token: 0x0400017D RID: 381
	public const string hlb = "Settings_DisableMassagerIdle";

	// Token: 0x0400017E RID: 382
	public const string hlc = "Settings_DirtinessMode";

	// Token: 0x0400017F RID: 383
	public const int hld = 50;

	// Token: 0x04000180 RID: 384
	public static SpineSkinSetting hle;

	// Token: 0x04000181 RID: 385
	public static PlayerData hlf;

	// Token: 0x04000182 RID: 386
	public static VoiceConfig hlg;

	// Token: 0x04000183 RID: 387
	public static int hlh;

	// Token: 0x04000184 RID: 388
	public const string hli = "Settings_VoiceProfile";

	// Token: 0x04000185 RID: 389
	public static ItemData[] hlj = new ItemData[0];

	// Token: 0x04000186 RID: 390
	public static bool hlk = true;

	// Token: 0x04000187 RID: 391
	public static bool hll = false;

	// Token: 0x04000188 RID: 392
	public static bool hlm = true;

	// Token: 0x04000189 RID: 393
	private static int hln = 0;

	// Token: 0x0400018A RID: 394
	public static int hlo;

	// Token: 0x0400018B RID: 395
	public static int hlp;

	// Token: 0x0400018C RID: 396
	public static int hlq;

	// Token: 0x0400018D RID: 397
	public static int hlr;

	// Token: 0x0400018E RID: 398
	public static bool hls = true;

	// Token: 0x0400018F RID: 399
	public static bool hlt = false;

	// Token: 0x04000190 RID: 400
	public static bool hlu = false;

	// Token: 0x04000191 RID: 401
	public static bool hlv = false;

	// Token: 0x04000192 RID: 402
	public static bool hlw = true;

	// Token: 0x04000193 RID: 403
	public static bool hlx = true;

	// Token: 0x04000194 RID: 404
	public static int hly = 0;

	// Token: 0x04000195 RID: 405
	public static bool hlz = false;

	// Token: 0x04000196 RID: 406
	public static DropNotificationMode hma = DropNotificationMode.All;

	// Token: 0x04000197 RID: 407
	public static DirtinessMode hmb = DirtinessMode.Manual;

	// Token: 0x04000198 RID: 408
	public static bool hmc = true;

	// Token: 0x04000199 RID: 409
	public static bool hmd = false;

	// Token: 0x0400019A RID: 410
	private static readonly Dictionary<CLOTHE_TYPE, int> hme = new Dictionary<CLOTHE_TYPE, int>();

	// Token: 0x0400019B RID: 411
	public static bool hmf = false;

	// Token: 0x0400019C RID: 412
	public static bool hmg = false;

	// Token: 0x0400019D RID: 413
	public static bool hmh = false;
}
