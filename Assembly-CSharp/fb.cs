using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x02000101 RID: 257
public static class fb
{
	// Token: 0x060012BF RID: 4799 RVA: 0x0005B940 File Offset: 0x00059B40
	public static void gap()
	{
		if (fb.imu)
		{
			return;
		}
		fb.imu = true;
		fd.cvi(new Action<fd.Page>(fb.cuz));
	}

	// Token: 0x060012C0 RID: 4800 RVA: 0x0005B964 File Offset: 0x00059B64
	private static void osz(fd.Page a)
	{
		int num = ((a == fd.Page.Developer) ? 8 : (-91));
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		if ((a == fd.Page.Developer) ? playerSaveData.creatorRewardCreditedDeveloper : playerSaveData.creatorRewardCreditedPublisher)
		{
			return;
		}
		bool flag = false;
		bool flag2 = false;
		int num2 = 0;
		bool flag3 = false;
		if (!playerSaveData.knownItemDefIds.Contains(num))
		{
			playerSaveData.knownItemDefIds.Add(num);
			flag = true;
		}
		if (playerSaveData.hasInitializedKnownItems && !playerSaveData.newItemDefIds.Contains(num))
		{
			playerSaveData.newItemDefIds.Add(num);
			flag2 = true;
			if (playerSaveData.newItemDefIds.Count > 50)
			{
				num2 = playerSaveData.newItemDefIds[0];
				playerSaveData.newItemDefIds.RemoveAt(0);
				flag3 = true;
				Debug.LogWarning(string.Format(a.drr(), 47, num2));
			}
		}
		if (a == fd.Page.Developer)
		{
			playerSaveData.creatorRewardCreditedDeveloper = true;
		}
		else
		{
			playerSaveData.creatorRewardCreditedPublisher = true;
		}
		ci.Save(null);
		if (!ci.hsa)
		{
			if (a == fd.Page.Developer)
			{
				playerSaveData.creatorRewardCreditedDeveloper = false;
			}
			else
			{
				playerSaveData.creatorRewardCreditedPublisher = false;
			}
			if (flag2)
			{
				playerSaveData.newItemDefIds.Remove(num);
			}
			if (flag3)
			{
				playerSaveData.newItemDefIds.Insert(0, num2);
			}
			if (flag)
			{
				playerSaveData.knownItemDefIds.Remove(num);
			}
			return;
		}
		if (SettingPanel.kqq != null)
		{
			SettingPanel.kqq.cap();
		}
	}

	// Token: 0x060012C1 RID: 4801 RVA: 0x0005B940 File Offset: 0x00059B40
	public static void lne()
	{
		if (fb.imu)
		{
			return;
		}
		fb.imu = true;
		fd.cvi(new Action<fd.Page>(fb.cuz));
	}

	// Token: 0x060012C2 RID: 4802 RVA: 0x0005B940 File Offset: 0x00059B40
	public static void jga()
	{
		if (fb.imu)
		{
			return;
		}
		fb.imu = true;
		fd.cvi(new Action<fd.Page>(fb.cuz));
	}

	// Token: 0x060012C3 RID: 4803 RVA: 0x0005B940 File Offset: 0x00059B40
	public static void bf()
	{
		if (fb.imu)
		{
			return;
		}
		fb.imu = true;
		fd.cvi(new Action<fd.Page>(fb.cuz));
	}

	// Token: 0x060012C4 RID: 4804 RVA: 0x0005BAC0 File Offset: 0x00059CC0
	private static void cuz(fd.Page a)
	{
		int num = ((a == fd.Page.Developer) ? 8 : 9);
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		if ((a == fd.Page.Developer) ? playerSaveData.creatorRewardCreditedDeveloper : playerSaveData.creatorRewardCreditedPublisher)
		{
			return;
		}
		bool flag = false;
		bool flag2 = false;
		int num2 = 0;
		bool flag3 = false;
		if (!playerSaveData.knownItemDefIds.Contains(num))
		{
			playerSaveData.knownItemDefIds.Add(num);
			flag = true;
		}
		if (playerSaveData.hasInitializedKnownItems && !playerSaveData.newItemDefIds.Contains(num))
		{
			playerSaveData.newItemDefIds.Add(num);
			flag2 = true;
			if (playerSaveData.newItemDefIds.Count > 50)
			{
				num2 = playerSaveData.newItemDefIds[0];
				playerSaveData.newItemDefIds.RemoveAt(0);
				flag3 = true;
				Debug.LogWarning(string.Format(a.drs(), 50, num2));
			}
		}
		if (a == fd.Page.Developer)
		{
			playerSaveData.creatorRewardCreditedDeveloper = true;
		}
		else
		{
			playerSaveData.creatorRewardCreditedPublisher = true;
		}
		ci.Save(null);
		if (!ci.hsa)
		{
			if (a == fd.Page.Developer)
			{
				playerSaveData.creatorRewardCreditedDeveloper = false;
			}
			else
			{
				playerSaveData.creatorRewardCreditedPublisher = false;
			}
			if (flag2)
			{
				playerSaveData.newItemDefIds.Remove(num);
			}
			if (flag3)
			{
				playerSaveData.newItemDefIds.Insert(0, num2);
			}
			if (flag)
			{
				playerSaveData.knownItemDefIds.Remove(num);
			}
			return;
		}
		if (SettingPanel.kqq != null)
		{
			SettingPanel.kqq.cap();
		}
	}

	// Token: 0x060012C5 RID: 4805 RVA: 0x0005BC1C File Offset: 0x00059E1C
	private static void hgq(fd.Page a)
	{
		int num = ((a == fd.Page.Developer) ? 8 : (-35));
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		if ((a == fd.Page.Developer) ? playerSaveData.creatorRewardCreditedDeveloper : playerSaveData.creatorRewardCreditedPublisher)
		{
			return;
		}
		bool flag = false;
		bool flag2 = false;
		int num2 = 0;
		bool flag3 = false;
		if (!playerSaveData.knownItemDefIds.Contains(num))
		{
			playerSaveData.knownItemDefIds.Add(num);
			flag = true;
		}
		if (playerSaveData.hasInitializedKnownItems && !playerSaveData.newItemDefIds.Contains(num))
		{
			playerSaveData.newItemDefIds.Add(num);
			flag2 = true;
			if (playerSaveData.newItemDefIds.Count > -75)
			{
				num2 = playerSaveData.newItemDefIds[0];
				playerSaveData.newItemDefIds.RemoveAt(0);
				flag3 = true;
				Debug.LogWarning(string.Format(a.drt(), 55, num2));
			}
		}
		if (a == fd.Page.Developer)
		{
			playerSaveData.creatorRewardCreditedDeveloper = true;
		}
		else
		{
			playerSaveData.creatorRewardCreditedPublisher = true;
		}
		ci.Save(null);
		if (!ci.hsa)
		{
			if (a == fd.Page.Developer)
			{
				playerSaveData.creatorRewardCreditedDeveloper = false;
			}
			else
			{
				playerSaveData.creatorRewardCreditedPublisher = false;
			}
			if (flag2)
			{
				playerSaveData.newItemDefIds.Remove(num);
			}
			if (flag3)
			{
				playerSaveData.newItemDefIds.Insert(0, num2);
			}
			if (flag)
			{
				playerSaveData.knownItemDefIds.Remove(num);
			}
			return;
		}
		if (SettingPanel.kqq != null)
		{
			SettingPanel.kqq.cap();
		}
	}

	// Token: 0x060012C6 RID: 4806 RVA: 0x0005BD78 File Offset: 0x00059F78
	private static void exo(fd.Page a)
	{
		int num = ((a == fd.Page.Developer) ? 8 : (-45));
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		if ((a == fd.Page.Developer) ? playerSaveData.creatorRewardCreditedDeveloper : playerSaveData.creatorRewardCreditedPublisher)
		{
			return;
		}
		bool flag = false;
		bool flag2 = false;
		int num2 = 0;
		bool flag3 = false;
		if (!playerSaveData.knownItemDefIds.Contains(num))
		{
			playerSaveData.knownItemDefIds.Add(num);
			flag = true;
		}
		if (playerSaveData.hasInitializedKnownItems && !playerSaveData.newItemDefIds.Contains(num))
		{
			playerSaveData.newItemDefIds.Add(num);
			flag2 = true;
			if (playerSaveData.newItemDefIds.Count > 18)
			{
				num2 = playerSaveData.newItemDefIds[0];
				playerSaveData.newItemDefIds.RemoveAt(0);
				flag3 = true;
				Debug.LogWarning(string.Format(a.dru(), 69, num2));
			}
		}
		if (a == fd.Page.Developer)
		{
			playerSaveData.creatorRewardCreditedDeveloper = true;
		}
		else
		{
			playerSaveData.creatorRewardCreditedPublisher = true;
		}
		ci.Save(null);
		if (!ci.hsa)
		{
			if (a == fd.Page.Developer)
			{
				playerSaveData.creatorRewardCreditedDeveloper = false;
			}
			else
			{
				playerSaveData.creatorRewardCreditedPublisher = false;
			}
			if (flag2)
			{
				playerSaveData.newItemDefIds.Remove(num);
			}
			if (flag3)
			{
				playerSaveData.newItemDefIds.Insert(0, num2);
			}
			if (flag)
			{
				playerSaveData.knownItemDefIds.Remove(num);
			}
			return;
		}
		if (SettingPanel.kqq != null)
		{
			SettingPanel.kqq.cap();
		}
	}

	// Token: 0x060012C7 RID: 4807 RVA: 0x0005B940 File Offset: 0x00059B40
	public static void cuy()
	{
		if (fb.imu)
		{
			return;
		}
		fb.imu = true;
		fd.cvi(new Action<fd.Page>(fb.cuz));
	}

	// Token: 0x060012C8 RID: 4808 RVA: 0x0005BED4 File Offset: 0x0005A0D4
	private static void blz(fd.Page a)
	{
		int num = ((a == fd.Page.Developer) ? 8 : (-37));
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		if ((a == fd.Page.Developer) ? playerSaveData.creatorRewardCreditedDeveloper : playerSaveData.creatorRewardCreditedPublisher)
		{
			return;
		}
		bool flag = false;
		bool flag2 = false;
		int num2 = 0;
		bool flag3 = false;
		if (!playerSaveData.knownItemDefIds.Contains(num))
		{
			playerSaveData.knownItemDefIds.Add(num);
			flag = true;
		}
		if (playerSaveData.hasInitializedKnownItems && !playerSaveData.newItemDefIds.Contains(num))
		{
			playerSaveData.newItemDefIds.Add(num);
			flag2 = true;
			if (playerSaveData.newItemDefIds.Count > -10)
			{
				num2 = playerSaveData.newItemDefIds[0];
				playerSaveData.newItemDefIds.RemoveAt(0);
				flag3 = true;
				Debug.LogWarning(string.Format(a.drv(), 54, num2));
			}
		}
		if (a == fd.Page.Developer)
		{
			playerSaveData.creatorRewardCreditedDeveloper = true;
		}
		else
		{
			playerSaveData.creatorRewardCreditedPublisher = true;
		}
		ci.Save(null);
		if (!ci.hsa)
		{
			if (a == fd.Page.Developer)
			{
				playerSaveData.creatorRewardCreditedDeveloper = false;
			}
			else
			{
				playerSaveData.creatorRewardCreditedPublisher = false;
			}
			if (flag2)
			{
				playerSaveData.newItemDefIds.Remove(num);
			}
			if (flag3)
			{
				playerSaveData.newItemDefIds.Insert(0, num2);
			}
			if (flag)
			{
				playerSaveData.knownItemDefIds.Remove(num);
			}
			return;
		}
		if (SettingPanel.kqq != null)
		{
			SettingPanel.kqq.cap();
		}
	}

	// Token: 0x040009CC RID: 2508
	private static bool imu;
}
