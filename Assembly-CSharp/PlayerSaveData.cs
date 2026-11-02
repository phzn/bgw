using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x0200006C RID: 108
[Serializable]
public class PlayerSaveData
{
	// Token: 0x06000519 RID: 1305 RVA: 0x0001AB24 File Offset: 0x00018D24
	public void bix(ClothingSetData a)
	{
		int num = this.biz();
		a.bjd(num);
		this.clothingSetDatas.Insert(0, a);
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x0001AB4C File Offset: 0x00018D4C
	public void biy(int a)
	{
		for (int i = 0; i < this.clothingSetDatas.Count; i++)
		{
			if (this.clothingSetDatas[i].bje() == a)
			{
				this.clothingSetDatas.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x0001AB90 File Offset: 0x00018D90
	private int biz()
	{
		int num3;
		do
		{
			long num = DateTimeOffset.Now.ToUnixTimeSeconds();
			int num2 = global::UnityEngine.Random.Range(1000, 9999);
			num3 = (int)(num % 1000000L * 10000L + (long)num2);
			if (num3 <= 0)
			{
				num3 = global::UnityEngine.Random.Range(10000000, 99999999);
			}
		}
		while (this.bja(num3));
		return num3;
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x0001ABEC File Offset: 0x00018DEC
	private bool bja(int a)
	{
		for (int i = 0; i < this.clothingSetDatas.Count; i++)
		{
			if (this.clothingSetDatas[i].bje() == a)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x0001AC28 File Offset: 0x00018E28
	public int bjb(CLOTHE_TYPE a)
	{
		switch (a)
		{
		case CLOTHE_TYPE.Dick:
			return this.lastVerifiedDickUse;
		case CLOTHE_TYPE.Hair:
			return this.lastVerifiedHairUse;
		case (CLOTHE_TYPE)2:
		case (CLOTHE_TYPE)6:
		case (CLOTHE_TYPE)7:
			break;
		case CLOTHE_TYPE.Top:
			return this.lastVerifiedTopUse;
		case CLOTHE_TYPE.Bottom:
			return this.lastVerifiedBottomUse;
		case CLOTHE_TYPE.Underwear:
			return this.lastVerifiedUnderwearUse;
		case CLOTHE_TYPE.Socks:
			return this.lastVerifiedSocksUse;
		case CLOTHE_TYPE.Shoes:
			return this.lastVerifiedShoesUse;
		default:
			switch (a)
			{
			case CLOTHE_TYPE.SkinTone:
				return this.lastVerifiedSkinToneUse;
			case CLOTHE_TYPE.IntimateParts:
				return this.lastVerifiedIntimatePartsUse;
			case CLOTHE_TYPE.PubicAndGenital:
				return this.lastVerifiedPubicAndGenitalUse;
			}
			break;
		}
		return 0;
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x0001ACC4 File Offset: 0x00018EC4
	public void bjc(CLOTHE_TYPE a, int b)
	{
		switch (a)
		{
		case CLOTHE_TYPE.Dick:
			this.lastVerifiedDickUse = b;
			return;
		case CLOTHE_TYPE.Hair:
			this.lastVerifiedHairUse = b;
			return;
		case (CLOTHE_TYPE)2:
		case (CLOTHE_TYPE)6:
		case (CLOTHE_TYPE)7:
			break;
		case CLOTHE_TYPE.Top:
			this.lastVerifiedTopUse = b;
			return;
		case CLOTHE_TYPE.Bottom:
			this.lastVerifiedBottomUse = b;
			return;
		case CLOTHE_TYPE.Underwear:
			this.lastVerifiedUnderwearUse = b;
			return;
		case CLOTHE_TYPE.Socks:
			this.lastVerifiedSocksUse = b;
			return;
		case CLOTHE_TYPE.Shoes:
			this.lastVerifiedShoesUse = b;
			return;
		default:
			switch (a)
			{
			case CLOTHE_TYPE.SkinTone:
				this.lastVerifiedSkinToneUse = b;
				return;
			case CLOTHE_TYPE.IntimateParts:
				this.lastVerifiedIntimatePartsUse = b;
				return;
			case CLOTHE_TYPE.PubicAndGenital:
				this.lastVerifiedPubicAndGenitalUse = b;
				break;
			default:
				return;
			}
			break;
		}
	}

	// Token: 0x040004E0 RID: 1248
	[Obsolete("v1.2.013 will remove; v1.2.012 mirrors from desired*Use for forward-compat")]
	public int DickUse;

	// Token: 0x040004E1 RID: 1249
	[Obsolete("v1.2.013 will remove; v1.2.012 mirrors from desired*Use for forward-compat")]
	public int HairUse;

	// Token: 0x040004E2 RID: 1250
	[Obsolete("v1.2.013 will remove; v1.2.012 mirrors from desired*Use for forward-compat")]
	public int TopUse;

	// Token: 0x040004E3 RID: 1251
	[Obsolete("v1.2.013 will remove; v1.2.012 mirrors from desired*Use for forward-compat")]
	public int BottomUse;

	// Token: 0x040004E4 RID: 1252
	[Obsolete("v1.2.013 will remove; v1.2.012 mirrors from desired*Use for forward-compat")]
	public int UnderwearUse;

	// Token: 0x040004E5 RID: 1253
	[Obsolete("v1.2.013 will remove; v1.2.012 mirrors from desired*Use for forward-compat")]
	public int SocksUse;

	// Token: 0x040004E6 RID: 1254
	[Obsolete("v1.2.013 will remove; v1.2.012 mirrors from desired*Use for forward-compat")]
	public int ShoesUse;

	// Token: 0x040004E7 RID: 1255
	[Obsolete("v1.2.013 will remove; v1.2.012 mirrors from desired*Use for forward-compat")]
	public int SkinToneUse;

	// Token: 0x040004E8 RID: 1256
	[Obsolete("v1.2.013 will remove; v1.2.012 mirrors from desired*Use for forward-compat")]
	public int IntimatePartsUse;

	// Token: 0x040004E9 RID: 1257
	[Obsolete("v1.2.013 will remove; v1.2.012 mirrors from desired*Use for forward-compat")]
	public int PubicAndGenitalUse;

	// Token: 0x040004EA RID: 1258
	public int desiredDickUse;

	// Token: 0x040004EB RID: 1259
	public int desiredHairUse;

	// Token: 0x040004EC RID: 1260
	public int desiredTopUse;

	// Token: 0x040004ED RID: 1261
	public int desiredBottomUse;

	// Token: 0x040004EE RID: 1262
	public int desiredUnderwearUse;

	// Token: 0x040004EF RID: 1263
	public int desiredSocksUse;

	// Token: 0x040004F0 RID: 1264
	public int desiredShoesUse;

	// Token: 0x040004F1 RID: 1265
	public int desiredSkinToneUse;

	// Token: 0x040004F2 RID: 1266
	public int desiredIntimatePartsUse;

	// Token: 0x040004F3 RID: 1267
	public int desiredPubicAndGenitalUse;

	// Token: 0x040004F4 RID: 1268
	public int lastVerifiedDickUse;

	// Token: 0x040004F5 RID: 1269
	public int lastVerifiedHairUse;

	// Token: 0x040004F6 RID: 1270
	public int lastVerifiedTopUse;

	// Token: 0x040004F7 RID: 1271
	public int lastVerifiedBottomUse;

	// Token: 0x040004F8 RID: 1272
	public int lastVerifiedUnderwearUse;

	// Token: 0x040004F9 RID: 1273
	public int lastVerifiedSocksUse;

	// Token: 0x040004FA RID: 1274
	public int lastVerifiedShoesUse;

	// Token: 0x040004FB RID: 1275
	public int lastVerifiedSkinToneUse;

	// Token: 0x040004FC RID: 1276
	public int lastVerifiedIntimatePartsUse;

	// Token: 0x040004FD RID: 1277
	public int lastVerifiedPubicAndGenitalUse;

	// Token: 0x040004FE RID: 1278
	public List<ClothingSetData> clothingSetDatas = new List<ClothingSetData>();

	// Token: 0x040004FF RID: 1279
	public List<string> dismissedDots = new List<string>();

	// Token: 0x04000500 RID: 1280
	public List<int> knownItemDefIds = new List<int>();

	// Token: 0x04000501 RID: 1281
	public List<int> newItemDefIds = new List<int>();

	// Token: 0x04000502 RID: 1282
	public List<int> favoriteItemDefIds = new List<int>();

	// Token: 0x04000503 RID: 1283
	public bool hasInitializedKnownItems;

	// Token: 0x04000504 RID: 1284
	public bool aiConnectionEnabled;

	// Token: 0x04000505 RID: 1285
	public bool firstTimeMcpToggleDone;

	// Token: 0x04000506 RID: 1286
	public int aiConnectionMode;

	// Token: 0x04000507 RID: 1287
	public int directApiProviderId;

	// Token: 0x04000508 RID: 1288
	public string directApiModel = a.tk();

	// Token: 0x04000509 RID: 1289
	public string directApiBaseUrl = a.tk();

	// Token: 0x0400050A RID: 1290
	public string directApiPromptTemplate = a.tk();

	// Token: 0x0400050B RID: 1291
	public bool directApiTemplateCustomized;

	// Token: 0x0400050C RID: 1292
	public int directApiChattinessTier = 1;

	// Token: 0x0400050D RID: 1293
	public bool directApiFirstTimeTipDone;

	// Token: 0x0400050E RID: 1294
	public float girlPosX;

	// Token: 0x0400050F RID: 1295
	public float girlPosY;

	// Token: 0x04000510 RID: 1296
	public float girlPosZ;

	// Token: 0x04000511 RID: 1297
	public float settingPanelAnchorX;

	// Token: 0x04000512 RID: 1298
	public float settingPanelAnchorY;

	// Token: 0x04000513 RID: 1299
	public float bgmPanelAnchorX;

	// Token: 0x04000514 RID: 1300
	public float bgmPanelAnchorY;

	// Token: 0x04000515 RID: 1301
	public bool hasSavedGirlPosition;

	// Token: 0x04000516 RID: 1302
	public bool hasSavedSettingPanelPosition;

	// Token: 0x04000517 RID: 1303
	public bool hasSavedBgmPanelPosition;

	// Token: 0x04000518 RID: 1304
	public int saveVersion = 2;

	// Token: 0x04000519 RID: 1305
	public string lastSeenAppVersion = a.tk();

	// Token: 0x0400051A RID: 1306
	public int dirtinessLevel;

	// Token: 0x0400051B RID: 1307
	public int creatorPageDeveloperState;

	// Token: 0x0400051C RID: 1308
	public int creatorPagePublisherState;

	// Token: 0x0400051D RID: 1309
	public bool creatorRewardCreditedDeveloper;

	// Token: 0x0400051E RID: 1310
	public bool creatorRewardCreditedPublisher;
}
