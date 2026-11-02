using System;
using UnityEngine;

// Token: 0x02000057 RID: 87
public static class ch
{
	// Token: 0x060004A2 RID: 1186 RVA: 0x00016EB4 File Offset: 0x000150B4
	public static void bhd(Vector3 a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		playerSaveData.girlPosX = a.x;
		playerSaveData.girlPosY = a.y;
		playerSaveData.girlPosZ = a.z;
		playerSaveData.hasSavedGirlPosition = true;
		ci.Save(null);
	}

	// Token: 0x060004A3 RID: 1187 RVA: 0x00016F14 File Offset: 0x00015114
	public static bool bhe(out Vector3 a)
	{
		a = Vector3.zero;
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || !playerSaveData.hasSavedGirlPosition)
		{
			return false;
		}
		a = new Vector3(playerSaveData.girlPosX, playerSaveData.girlPosY, playerSaveData.girlPosZ);
		return true;
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x00016F74 File Offset: 0x00015174
	public static void mtd()
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		playerSaveData.hasSavedGirlPosition = false;
		ci.Save(null);
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x00016FB0 File Offset: 0x000151B0
	public static void bt(Vector3 a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		playerSaveData.girlPosX = a.x;
		playerSaveData.girlPosY = a.y;
		playerSaveData.girlPosZ = a.z;
		playerSaveData.hasSavedGirlPosition = true;
		ci.Save(null);
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00017010 File Offset: 0x00015210
	public static bool bhh(out Vector2 a)
	{
		a = Vector2.zero;
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || !playerSaveData.hasSavedSettingPanelPosition)
		{
			return false;
		}
		a = new Vector2(playerSaveData.settingPanelAnchorX, playerSaveData.settingPanelAnchorY);
		return true;
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x00017068 File Offset: 0x00015268
	public static void cig()
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		playerSaveData.hasSavedGirlPosition = false;
		ci.Save(null);
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x000170A4 File Offset: 0x000152A4
	public static void bhg(Vector2 a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		playerSaveData.settingPanelAnchorX = a.x;
		playerSaveData.settingPanelAnchorY = a.y;
		playerSaveData.hasSavedSettingPanelPosition = true;
		ci.Save(null);
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x000170F8 File Offset: 0x000152F8
	public static bool bhj(out Vector2 a)
	{
		a = Vector2.zero;
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || !playerSaveData.hasSavedBgmPanelPosition)
		{
			return false;
		}
		a = new Vector2(playerSaveData.bgmPanelAnchorX, playerSaveData.bgmPanelAnchorY);
		return true;
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x00017150 File Offset: 0x00015350
	public static bool dum(out Vector2 a)
	{
		a = Vector2.zero;
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || !playerSaveData.hasSavedSettingPanelPosition)
		{
			return false;
		}
		a = new Vector2(playerSaveData.settingPanelAnchorX, playerSaveData.settingPanelAnchorY);
		return true;
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x000171A8 File Offset: 0x000153A8
	public static void mzr()
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		playerSaveData.hasSavedGirlPosition = false;
		ci.Save(null);
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x000171E4 File Offset: 0x000153E4
	public static void gyj(Vector2 a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		playerSaveData.settingPanelAnchorX = a.x;
		playerSaveData.settingPanelAnchorY = a.y;
		playerSaveData.hasSavedSettingPanelPosition = true;
		ci.Save(null);
	}

	// Token: 0x060004AD RID: 1197 RVA: 0x00017238 File Offset: 0x00015438
	public static void mul(Vector2 a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		playerSaveData.settingPanelAnchorX = a.x;
		playerSaveData.settingPanelAnchorY = a.y;
		playerSaveData.hasSavedSettingPanelPosition = true;
		ci.Save(null);
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x0001728C File Offset: 0x0001548C
	public static bool goq(out Vector2 a)
	{
		a = Vector2.zero;
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || !playerSaveData.hasSavedBgmPanelPosition)
		{
			return false;
		}
		a = new Vector2(playerSaveData.bgmPanelAnchorX, playerSaveData.bgmPanelAnchorY);
		return true;
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x000172E4 File Offset: 0x000154E4
	public static bool yq(out Vector3 a)
	{
		a = Vector3.zero;
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || !playerSaveData.hasSavedGirlPosition)
		{
			return false;
		}
		a = new Vector3(playerSaveData.girlPosX, playerSaveData.girlPosY, playerSaveData.girlPosZ);
		return true;
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x00017344 File Offset: 0x00015544
	public static bool nve(out Vector3 a)
	{
		a = Vector3.zero;
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || !playerSaveData.hasSavedGirlPosition)
		{
			return false;
		}
		a = new Vector3(playerSaveData.girlPosX, playerSaveData.girlPosY, playerSaveData.girlPosZ);
		return true;
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x000173A4 File Offset: 0x000155A4
	public static void bhi(Vector2 a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		playerSaveData.bgmPanelAnchorX = a.x;
		playerSaveData.bgmPanelAnchorY = a.y;
		playerSaveData.hasSavedBgmPanelPosition = true;
		ci.Save(null);
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x000173F8 File Offset: 0x000155F8
	public static bool eht(out Vector3 a)
	{
		a = Vector3.zero;
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || !playerSaveData.hasSavedGirlPosition)
		{
			return false;
		}
		a = new Vector3(playerSaveData.girlPosX, playerSaveData.girlPosY, playerSaveData.girlPosZ);
		return true;
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x00017458 File Offset: 0x00015658
	public static void bhf()
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		playerSaveData.hasSavedGirlPosition = false;
		ci.Save(null);
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x00017494 File Offset: 0x00015694
	public static void mmx(Vector2 a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		playerSaveData.settingPanelAnchorX = a.x;
		playerSaveData.settingPanelAnchorY = a.y;
		playerSaveData.hasSavedSettingPanelPosition = true;
		ci.Save(null);
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x000174E8 File Offset: 0x000156E8
	public static void bbv(Vector2 a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		playerSaveData.settingPanelAnchorX = a.x;
		playerSaveData.settingPanelAnchorY = a.y;
		playerSaveData.hasSavedSettingPanelPosition = true;
		ci.Save(null);
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x0001753C File Offset: 0x0001573C
	public static bool col(out Vector3 a)
	{
		a = Vector3.zero;
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || !playerSaveData.hasSavedGirlPosition)
		{
			return false;
		}
		a = new Vector3(playerSaveData.girlPosX, playerSaveData.girlPosY, playerSaveData.girlPosZ);
		return true;
	}

	// Token: 0x060004B7 RID: 1207 RVA: 0x0001759C File Offset: 0x0001579C
	public static void giy(Vector2 a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		playerSaveData.bgmPanelAnchorX = a.x;
		playerSaveData.bgmPanelAnchorY = a.y;
		playerSaveData.hasSavedBgmPanelPosition = true;
		ci.Save(null);
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x000175F0 File Offset: 0x000157F0
	public static void jqz(Vector2 a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		playerSaveData.bgmPanelAnchorX = a.x;
		playerSaveData.bgmPanelAnchorY = a.y;
		playerSaveData.hasSavedBgmPanelPosition = true;
		ci.Save(null);
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x00017644 File Offset: 0x00015844
	public static void bit(Vector3 a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		playerSaveData.girlPosX = a.x;
		playerSaveData.girlPosY = a.y;
		playerSaveData.girlPosZ = a.z;
		playerSaveData.hasSavedGirlPosition = true;
		ci.Save(null);
	}
}
