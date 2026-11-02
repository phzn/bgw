using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x02000075 RID: 117
[Serializable]
public class SpineSkinData
{
	// Token: 0x17000078 RID: 120
	// (get) Token: 0x0600052C RID: 1324 RVA: 0x0001BC6F File Offset: 0x00019E6F
	public int kox
	{
		get
		{
			return (int)this.name;
		}
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x0001BC78 File Offset: 0x00019E78
	public bool bjk()
	{
		CREATOR_PAGE_UNLOCK creator_PAGE_UNLOCK = this.creatorPageUnlock;
		if (creator_PAGE_UNLOCK != CREATOR_PAGE_UNLOCK.Developer)
		{
			return creator_PAGE_UNLOCK != CREATOR_PAGE_UNLOCK.Publisher || fd.cvn(fd.Page.Publisher);
		}
		return fd.cvn(fd.Page.Developer);
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x0600052E RID: 1326 RVA: 0x0001BCA5 File Offset: 0x00019EA5
	public bool koy
	{
		get
		{
			return this.dlcType > DLC_TYPE.None;
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x0600052F RID: 1327 RVA: 0x0001BCB0 File Offset: 0x00019EB0
	public bool koz
	{
		get
		{
			return this.bjk() && (!this.isNeedUnlock || (du.iah != null && du.iah.cej(this.achievement)));
		}
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x0001BCE8 File Offset: 0x00019EE8
	public SpineSkinData(SpineSkinData spineSkinData)
	{
		this.type = spineSkinData.type;
		this.name = spineSkinData.name;
		this.skinName = spineSkinData.skinName;
		this.texture = spineSkinData.texture;
		this.icon = spineSkinData.icon;
		this.dlcType = spineSkinData.dlcType;
		this.creatorPageUnlock = spineSkinData.creatorPageUnlock;
		this.overrideDickBottomPos = spineSkinData.overrideDickBottomPos;
		this.dickBottomOverrideLocalPos = spineSkinData.dickBottomOverrideLocalPos;
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x0001BD72 File Offset: 0x00019F72
	public SpineSkinData()
	{
		this.type = CLOTHE_TYPE.Dick;
		this.name = CLOTHE_NAME.Null;
		this.skinName = SKIN_NAME.Null;
		this.texture = null;
		this.icon = null;
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x0001BDA8 File Offset: 0x00019FA8
	public uint bjn()
	{
		uint num;
		if (this.dlcType == DLC_TYPE.AdultContent)
		{
			num = 4716380U;
		}
		else
		{
			num = 0U;
		}
		return num;
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x0001BDCC File Offset: 0x00019FCC
	public void bjo()
	{
		int num = this.kox;
		CLOTHE_TYPE clothe_TYPE = this.type;
		switch (clothe_TYPE)
		{
		case CLOTHE_TYPE.Dick:
			bq.hlf.playerSaveData.desiredDickUse = num;
			break;
		case CLOTHE_TYPE.Hair:
			bq.hlf.playerSaveData.desiredHairUse = num;
			break;
		case (CLOTHE_TYPE)2:
		case (CLOTHE_TYPE)6:
		case (CLOTHE_TYPE)7:
			break;
		case CLOTHE_TYPE.Top:
			bq.hlf.playerSaveData.desiredTopUse = num;
			break;
		case CLOTHE_TYPE.Bottom:
			bq.hlf.playerSaveData.desiredBottomUse = num;
			break;
		case CLOTHE_TYPE.Underwear:
			bq.hlf.playerSaveData.desiredUnderwearUse = num;
			break;
		case CLOTHE_TYPE.Socks:
			bq.hlf.playerSaveData.desiredSocksUse = num;
			break;
		case CLOTHE_TYPE.Shoes:
			bq.hlf.playerSaveData.desiredShoesUse = num;
			break;
		default:
			switch (clothe_TYPE)
			{
			case CLOTHE_TYPE.SkinTone:
				bq.hlf.playerSaveData.desiredSkinToneUse = num;
				break;
			case CLOTHE_TYPE.IntimateParts:
				bq.hlf.playerSaveData.desiredIntimatePartsUse = num;
				break;
			case CLOTHE_TYPE.PubicAndGenital:
				bq.hlf.playerSaveData.desiredPubicAndGenitalUse = num;
				break;
			}
			break;
		}
		if (this.skinName != SKIN_NAME.Null)
		{
			bq.hle.bks(this.skinName, this.texture);
		}
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x0001BF08 File Offset: 0x0001A108
	public void bjp(bool a = false)
	{
		int num = this.kox;
		PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		CLOTHE_TYPE clothe_TYPE = this.type;
		switch (clothe_TYPE)
		{
		case CLOTHE_TYPE.Dick:
			playerSaveData.desiredDickUse = num;
			break;
		case CLOTHE_TYPE.Hair:
			if (a || playerSaveData.desiredHairUse != num)
			{
				playerSaveData.desiredHairUse = num;
			}
			else
			{
				playerSaveData.desiredHairUse = 0;
			}
			break;
		case (CLOTHE_TYPE)2:
		case (CLOTHE_TYPE)6:
		case (CLOTHE_TYPE)7:
			break;
		case CLOTHE_TYPE.Top:
			if (a || playerSaveData.desiredTopUse != num)
			{
				playerSaveData.desiredTopUse = num;
			}
			else
			{
				playerSaveData.desiredTopUse = 0;
			}
			break;
		case CLOTHE_TYPE.Bottom:
			if (a || playerSaveData.desiredBottomUse != num)
			{
				playerSaveData.desiredBottomUse = num;
			}
			else
			{
				playerSaveData.desiredBottomUse = 0;
			}
			break;
		case CLOTHE_TYPE.Underwear:
			if (a || playerSaveData.desiredUnderwearUse != num)
			{
				playerSaveData.desiredUnderwearUse = num;
			}
			else
			{
				playerSaveData.desiredUnderwearUse = 0;
			}
			break;
		case CLOTHE_TYPE.Socks:
			if (a || playerSaveData.desiredSocksUse != num)
			{
				playerSaveData.desiredSocksUse = num;
			}
			else
			{
				playerSaveData.desiredSocksUse = 0;
			}
			break;
		case CLOTHE_TYPE.Shoes:
			if (a || playerSaveData.desiredShoesUse != num)
			{
				playerSaveData.desiredShoesUse = num;
			}
			else
			{
				playerSaveData.desiredShoesUse = 0;
			}
			break;
		default:
			switch (clothe_TYPE)
			{
			case CLOTHE_TYPE.SkinTone:
				playerSaveData.desiredSkinToneUse = num;
				break;
			case CLOTHE_TYPE.IntimateParts:
				playerSaveData.desiredIntimatePartsUse = num;
				break;
			case CLOTHE_TYPE.PubicAndGenital:
				if (a || playerSaveData.desiredPubicAndGenitalUse != num)
				{
					playerSaveData.desiredPubicAndGenitalUse = num;
				}
				else
				{
					playerSaveData.desiredPubicAndGenitalUse = 0;
				}
				break;
			}
			break;
		}
		bq.bap(this.type);
		if (this.skinName != SKIN_NAME.Null && this.texture != null)
		{
			bq.hle.bks(this.skinName, this.texture);
			return;
		}
		bq.hle.bkt();
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x0001C0BE File Offset: 0x0001A2BE
	public bool bjq()
	{
		return this.bjr(this.kox);
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x0001C0CC File Offset: 0x0001A2CC
	public bool bjr(int a)
	{
		if (bq.knc)
		{
			return true;
		}
		if (this.type == CLOTHE_TYPE.Dick)
		{
			return true;
		}
		if ((this.type == CLOTHE_TYPE.SkinTone && a == 200) || (this.type == CLOTHE_TYPE.IntimateParts && a == 400))
		{
			return true;
		}
		if (this.koy)
		{
			return bj.wm(this.bjn());
		}
		foreach (ItemData itemData in bq.hlf.itemDatas)
		{
			if (itemData != null && itemData.defID == a && itemData.quantity > 0U)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x0001C15C File Offset: 0x0001A35C
	public bool bjs()
	{
		if (bq.hle == null || bq.hle.bjy(this.kox, this.type) == null)
		{
			return false;
		}
		PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		CLOTHE_TYPE clothe_TYPE = this.type;
		switch (clothe_TYPE)
		{
		case CLOTHE_TYPE.Dick:
			return playerSaveData.desiredDickUse == this.kox;
		case CLOTHE_TYPE.Hair:
			return playerSaveData.desiredHairUse == this.kox;
		case (CLOTHE_TYPE)2:
		case (CLOTHE_TYPE)6:
		case (CLOTHE_TYPE)7:
			break;
		case CLOTHE_TYPE.Top:
			return playerSaveData.desiredTopUse == this.kox;
		case CLOTHE_TYPE.Bottom:
			return playerSaveData.desiredBottomUse == this.kox;
		case CLOTHE_TYPE.Underwear:
			return playerSaveData.desiredUnderwearUse == this.kox;
		case CLOTHE_TYPE.Socks:
			return playerSaveData.desiredSocksUse == this.kox;
		case CLOTHE_TYPE.Shoes:
			return playerSaveData.desiredShoesUse == this.kox;
		default:
			switch (clothe_TYPE)
			{
			case CLOTHE_TYPE.SkinTone:
				return playerSaveData.desiredSkinToneUse == this.kox;
			case CLOTHE_TYPE.IntimateParts:
				return playerSaveData.desiredIntimatePartsUse == this.kox;
			case CLOTHE_TYPE.PubicAndGenital:
				return playerSaveData.desiredPubicAndGenitalUse == this.kox;
			}
			break;
		}
		Debug.LogError(a.bek() + this.type.ToString());
		return false;
	}

	// Token: 0x04000582 RID: 1410
	public CLOTHE_TYPE type;

	// Token: 0x04000583 RID: 1411
	public CLOTHE_NAME name;

	// Token: 0x04000584 RID: 1412
	public SKIN_NAME skinName;

	// Token: 0x04000585 RID: 1413
	public Texture2D texture;

	// Token: 0x04000586 RID: 1414
	public Sprite icon;

	// Token: 0x04000587 RID: 1415
	public bool isNeedUnlock;

	// Token: 0x04000588 RID: 1416
	public du.ACHIEVEMENT achievement;

	// Token: 0x04000589 RID: 1417
	public CREATOR_PAGE_UNLOCK creatorPageUnlock;

	// Token: 0x0400058A RID: 1418
	public DLC_TYPE dlcType;

	// Token: 0x0400058B RID: 1419
	public bool overrideDickBottomPos;

	// Token: 0x0400058C RID: 1420
	public Vector3 dickBottomOverrideLocalPos = Vector3.zero;
}
