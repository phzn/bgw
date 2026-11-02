using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x0200006F RID: 111
[CreateAssetMenu(fileName = "PlayData", menuName = "Scriptable Objects/PlayData")]
public class PlayerData : ScriptableObject
{
	// Token: 0x06000524 RID: 1316 RVA: 0x0001ADFC File Offset: 0x00018FFC
	public AchievementData bjf(du.ACHIEVEMENT a)
	{
		for (int i = 0; i < this.achievementDatas.Count; i++)
		{
			if (this.achievementDatas[i].achievement == a)
			{
				return this.achievementDatas[i];
			}
		}
		return null;
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x0001AE44 File Offset: 0x00019044
	public PlayerSaveData Save()
	{
		return new PlayerSaveData
		{
			DickUse = this.playerSaveData.desiredDickUse,
			HairUse = this.playerSaveData.desiredHairUse,
			TopUse = this.playerSaveData.desiredTopUse,
			BottomUse = this.playerSaveData.desiredBottomUse,
			UnderwearUse = this.playerSaveData.desiredUnderwearUse,
			SocksUse = this.playerSaveData.desiredSocksUse,
			ShoesUse = this.playerSaveData.desiredShoesUse,
			SkinToneUse = this.playerSaveData.desiredSkinToneUse,
			IntimatePartsUse = this.playerSaveData.desiredIntimatePartsUse,
			PubicAndGenitalUse = this.playerSaveData.desiredPubicAndGenitalUse,
			desiredDickUse = this.playerSaveData.desiredDickUse,
			desiredHairUse = this.playerSaveData.desiredHairUse,
			desiredTopUse = this.playerSaveData.desiredTopUse,
			desiredBottomUse = this.playerSaveData.desiredBottomUse,
			desiredUnderwearUse = this.playerSaveData.desiredUnderwearUse,
			desiredSocksUse = this.playerSaveData.desiredSocksUse,
			desiredShoesUse = this.playerSaveData.desiredShoesUse,
			desiredSkinToneUse = this.playerSaveData.desiredSkinToneUse,
			desiredIntimatePartsUse = this.playerSaveData.desiredIntimatePartsUse,
			desiredPubicAndGenitalUse = this.playerSaveData.desiredPubicAndGenitalUse,
			lastVerifiedDickUse = this.playerSaveData.lastVerifiedDickUse,
			lastVerifiedHairUse = this.playerSaveData.lastVerifiedHairUse,
			lastVerifiedTopUse = this.playerSaveData.lastVerifiedTopUse,
			lastVerifiedBottomUse = this.playerSaveData.lastVerifiedBottomUse,
			lastVerifiedUnderwearUse = this.playerSaveData.lastVerifiedUnderwearUse,
			lastVerifiedSocksUse = this.playerSaveData.lastVerifiedSocksUse,
			lastVerifiedShoesUse = this.playerSaveData.lastVerifiedShoesUse,
			lastVerifiedSkinToneUse = this.playerSaveData.lastVerifiedSkinToneUse,
			lastVerifiedIntimatePartsUse = this.playerSaveData.lastVerifiedIntimatePartsUse,
			lastVerifiedPubicAndGenitalUse = this.playerSaveData.lastVerifiedPubicAndGenitalUse,
			clothingSetDatas = this.playerSaveData.clothingSetDatas,
			dismissedDots = this.playerSaveData.dismissedDots,
			knownItemDefIds = this.playerSaveData.knownItemDefIds,
			newItemDefIds = this.playerSaveData.newItemDefIds,
			favoriteItemDefIds = this.playerSaveData.favoriteItemDefIds,
			hasInitializedKnownItems = this.playerSaveData.hasInitializedKnownItems,
			aiConnectionEnabled = this.playerSaveData.aiConnectionEnabled,
			firstTimeMcpToggleDone = this.playerSaveData.firstTimeMcpToggleDone,
			aiConnectionMode = this.playerSaveData.aiConnectionMode,
			directApiProviderId = this.playerSaveData.directApiProviderId,
			directApiModel = this.playerSaveData.directApiModel,
			directApiBaseUrl = this.playerSaveData.directApiBaseUrl,
			directApiPromptTemplate = this.playerSaveData.directApiPromptTemplate,
			directApiTemplateCustomized = this.playerSaveData.directApiTemplateCustomized,
			directApiChattinessTier = this.playerSaveData.directApiChattinessTier,
			directApiFirstTimeTipDone = this.playerSaveData.directApiFirstTimeTipDone,
			girlPosX = this.playerSaveData.girlPosX,
			girlPosY = this.playerSaveData.girlPosY,
			girlPosZ = this.playerSaveData.girlPosZ,
			settingPanelAnchorX = this.playerSaveData.settingPanelAnchorX,
			settingPanelAnchorY = this.playerSaveData.settingPanelAnchorY,
			bgmPanelAnchorX = this.playerSaveData.bgmPanelAnchorX,
			bgmPanelAnchorY = this.playerSaveData.bgmPanelAnchorY,
			hasSavedGirlPosition = this.playerSaveData.hasSavedGirlPosition,
			hasSavedSettingPanelPosition = this.playerSaveData.hasSavedSettingPanelPosition,
			hasSavedBgmPanelPosition = this.playerSaveData.hasSavedBgmPanelPosition,
			saveVersion = this.playerSaveData.saveVersion,
			lastSeenAppVersion = this.playerSaveData.lastSeenAppVersion,
			dirtinessLevel = this.playerSaveData.dirtinessLevel,
			creatorPageDeveloperState = this.playerSaveData.creatorPageDeveloperState,
			creatorPagePublisherState = this.playerSaveData.creatorPagePublisherState,
			creatorRewardCreditedDeveloper = this.playerSaveData.creatorRewardCreditedDeveloper,
			creatorRewardCreditedPublisher = this.playerSaveData.creatorRewardCreditedPublisher
		};
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x0001B288 File Offset: 0x00019488
	public void bjg(PlayerSaveData a)
	{
		if (a == null)
		{
			a = new PlayerSaveData();
		}
		this.playerSaveData.DickUse = a.DickUse;
		this.playerSaveData.HairUse = a.HairUse;
		this.playerSaveData.TopUse = a.TopUse;
		this.playerSaveData.BottomUse = a.BottomUse;
		this.playerSaveData.UnderwearUse = a.UnderwearUse;
		this.playerSaveData.SocksUse = a.SocksUse;
		this.playerSaveData.ShoesUse = a.ShoesUse;
		this.playerSaveData.SkinToneUse = a.SkinToneUse;
		this.playerSaveData.IntimatePartsUse = a.IntimatePartsUse;
		this.playerSaveData.PubicAndGenitalUse = a.PubicAndGenitalUse;
		if (a.clothingSetDatas != null)
		{
			this.playerSaveData.clothingSetDatas = a.clothingSetDatas;
		}
		else
		{
			this.playerSaveData.clothingSetDatas = new List<ClothingSetData>();
		}
		if (a.dismissedDots != null)
		{
			this.playerSaveData.dismissedDots = a.dismissedDots;
		}
		else
		{
			this.playerSaveData.dismissedDots = new List<string>();
		}
		if (a.knownItemDefIds != null)
		{
			this.playerSaveData.knownItemDefIds = a.knownItemDefIds;
		}
		else
		{
			this.playerSaveData.knownItemDefIds = new List<int>();
		}
		if (a.newItemDefIds != null)
		{
			this.playerSaveData.newItemDefIds = a.newItemDefIds;
		}
		else
		{
			this.playerSaveData.newItemDefIds = new List<int>();
		}
		if (a.favoriteItemDefIds != null)
		{
			this.playerSaveData.favoriteItemDefIds = a.favoriteItemDefIds;
		}
		else
		{
			this.playerSaveData.favoriteItemDefIds = new List<int>();
		}
		int num = 50;
		if (this.playerSaveData.newItemDefIds.Count > num)
		{
			int num2 = this.playerSaveData.newItemDefIds.Count - num;
			this.playerSaveData.newItemDefIds.RemoveRange(0, num2);
		}
		this.playerSaveData.hasInitializedKnownItems = a.hasInitializedKnownItems;
		this.playerSaveData.aiConnectionEnabled = a.aiConnectionEnabled;
		this.playerSaveData.firstTimeMcpToggleDone = a.firstTimeMcpToggleDone;
		this.playerSaveData.aiConnectionMode = a.aiConnectionMode;
		this.playerSaveData.directApiProviderId = a.directApiProviderId;
		this.playerSaveData.directApiModel = a.directApiModel ?? a.tk();
		this.playerSaveData.directApiBaseUrl = a.directApiBaseUrl ?? a.tk();
		this.playerSaveData.directApiPromptTemplate = a.directApiPromptTemplate ?? a.tk();
		this.playerSaveData.directApiTemplateCustomized = a.directApiTemplateCustomized;
		this.playerSaveData.directApiChattinessTier = a.directApiChattinessTier;
		this.playerSaveData.directApiFirstTimeTipDone = a.directApiFirstTimeTipDone;
		if (this.playerSaveData.aiConnectionMode == 0 && a.aiConnectionEnabled)
		{
			this.playerSaveData.aiConnectionMode = 1;
		}
		this.playerSaveData.girlPosX = a.girlPosX;
		this.playerSaveData.girlPosY = a.girlPosY;
		this.playerSaveData.girlPosZ = a.girlPosZ;
		this.playerSaveData.settingPanelAnchorX = a.settingPanelAnchorX;
		this.playerSaveData.settingPanelAnchorY = a.settingPanelAnchorY;
		this.playerSaveData.bgmPanelAnchorX = a.bgmPanelAnchorX;
		this.playerSaveData.bgmPanelAnchorY = a.bgmPanelAnchorY;
		this.playerSaveData.hasSavedGirlPosition = a.hasSavedGirlPosition;
		this.playerSaveData.hasSavedSettingPanelPosition = a.hasSavedSettingPanelPosition;
		this.playerSaveData.hasSavedBgmPanelPosition = a.hasSavedBgmPanelPosition;
		this.playerSaveData.saveVersion = a.saveVersion;
		this.playerSaveData.lastSeenAppVersion = a.lastSeenAppVersion ?? a.tk();
		this.playerSaveData.dirtinessLevel = a.dirtinessLevel;
		this.playerSaveData.creatorPageDeveloperState = a.creatorPageDeveloperState;
		this.playerSaveData.creatorPagePublisherState = a.creatorPagePublisherState;
		this.playerSaveData.creatorRewardCreditedDeveloper = a.creatorRewardCreditedDeveloper;
		this.playerSaveData.creatorRewardCreditedPublisher = a.creatorRewardCreditedPublisher;
		this.playerSaveData.desiredDickUse = a.desiredDickUse;
		this.playerSaveData.desiredHairUse = a.desiredHairUse;
		this.playerSaveData.desiredTopUse = a.desiredTopUse;
		this.playerSaveData.desiredBottomUse = a.desiredBottomUse;
		this.playerSaveData.desiredUnderwearUse = a.desiredUnderwearUse;
		this.playerSaveData.desiredSocksUse = a.desiredSocksUse;
		this.playerSaveData.desiredShoesUse = a.desiredShoesUse;
		this.playerSaveData.desiredSkinToneUse = a.desiredSkinToneUse;
		this.playerSaveData.desiredIntimatePartsUse = a.desiredIntimatePartsUse;
		this.playerSaveData.desiredPubicAndGenitalUse = a.desiredPubicAndGenitalUse;
		this.playerSaveData.lastVerifiedDickUse = a.lastVerifiedDickUse;
		this.playerSaveData.lastVerifiedHairUse = a.lastVerifiedHairUse;
		this.playerSaveData.lastVerifiedTopUse = a.lastVerifiedTopUse;
		this.playerSaveData.lastVerifiedBottomUse = a.lastVerifiedBottomUse;
		this.playerSaveData.lastVerifiedUnderwearUse = a.lastVerifiedUnderwearUse;
		this.playerSaveData.lastVerifiedSocksUse = a.lastVerifiedSocksUse;
		this.playerSaveData.lastVerifiedShoesUse = a.lastVerifiedShoesUse;
		this.playerSaveData.lastVerifiedSkinToneUse = a.lastVerifiedSkinToneUse;
		this.playerSaveData.lastVerifiedIntimatePartsUse = a.lastVerifiedIntimatePartsUse;
		this.playerSaveData.lastVerifiedPubicAndGenitalUse = a.lastVerifiedPubicAndGenitalUse;
		if (this.playerSaveData.saveVersion < 2)
		{
			this.playerSaveData.desiredDickUse = a.DickUse;
			this.playerSaveData.desiredHairUse = a.HairUse;
			this.playerSaveData.desiredTopUse = a.TopUse;
			this.playerSaveData.desiredBottomUse = a.BottomUse;
			this.playerSaveData.desiredUnderwearUse = a.UnderwearUse;
			this.playerSaveData.desiredSocksUse = a.SocksUse;
			this.playerSaveData.desiredShoesUse = a.ShoesUse;
			this.playerSaveData.desiredSkinToneUse = a.SkinToneUse;
			this.playerSaveData.desiredIntimatePartsUse = a.IntimatePartsUse;
			this.playerSaveData.desiredPubicAndGenitalUse = a.PubicAndGenitalUse;
			foreach (ClothingSetData clothingSetData in this.playerSaveData.clothingSetDatas)
			{
				if (clothingSetData != null)
				{
					clothingSetData.desiredDickUse = clothingSetData.DickUse;
					clothingSetData.desiredHairUse = clothingSetData.HairUse;
					clothingSetData.desiredTopUse = clothingSetData.TopUse;
					clothingSetData.desiredBottomUse = clothingSetData.BottomUse;
					clothingSetData.desiredUnderwearUse = clothingSetData.UnderwearUse;
					clothingSetData.desiredSocksUse = clothingSetData.SocksUse;
					clothingSetData.desiredShoesUse = clothingSetData.ShoesUse;
					clothingSetData.desiredSkinToneUse = clothingSetData.SkinToneUse;
					clothingSetData.desiredIntimatePartsUse = clothingSetData.IntimatePartsUse;
					clothingSetData.desiredPubicAndGenitalUse = clothingSetData.PubicAndGenitalUse;
				}
			}
			this.playerSaveData.saveVersion = 2;
			return;
		}
		if (this.playerSaveData.saveVersion == 2)
		{
			PlayerData.bjh(ref this.playerSaveData.desiredDickUse, ref this.playerSaveData.lastVerifiedDickUse, a.DickUse);
			PlayerData.bjh(ref this.playerSaveData.desiredHairUse, ref this.playerSaveData.lastVerifiedHairUse, a.HairUse);
			PlayerData.bjh(ref this.playerSaveData.desiredTopUse, ref this.playerSaveData.lastVerifiedTopUse, a.TopUse);
			PlayerData.bjh(ref this.playerSaveData.desiredBottomUse, ref this.playerSaveData.lastVerifiedBottomUse, a.BottomUse);
			PlayerData.bjh(ref this.playerSaveData.desiredUnderwearUse, ref this.playerSaveData.lastVerifiedUnderwearUse, a.UnderwearUse);
			PlayerData.bjh(ref this.playerSaveData.desiredSocksUse, ref this.playerSaveData.lastVerifiedSocksUse, a.SocksUse);
			PlayerData.bjh(ref this.playerSaveData.desiredShoesUse, ref this.playerSaveData.lastVerifiedShoesUse, a.ShoesUse);
			PlayerData.bjh(ref this.playerSaveData.desiredSkinToneUse, ref this.playerSaveData.lastVerifiedSkinToneUse, a.SkinToneUse);
			PlayerData.bjh(ref this.playerSaveData.desiredIntimatePartsUse, ref this.playerSaveData.lastVerifiedIntimatePartsUse, a.IntimatePartsUse);
			PlayerData.bjh(ref this.playerSaveData.desiredPubicAndGenitalUse, ref this.playerSaveData.lastVerifiedPubicAndGenitalUse, a.PubicAndGenitalUse);
			foreach (ClothingSetData clothingSetData2 in this.playerSaveData.clothingSetDatas)
			{
				if (clothingSetData2 != null)
				{
					PlayerData.bjh(ref clothingSetData2.desiredDickUse, ref clothingSetData2.lastVerifiedDickUse, clothingSetData2.DickUse);
					PlayerData.bjh(ref clothingSetData2.desiredHairUse, ref clothingSetData2.lastVerifiedHairUse, clothingSetData2.HairUse);
					PlayerData.bjh(ref clothingSetData2.desiredTopUse, ref clothingSetData2.lastVerifiedTopUse, clothingSetData2.TopUse);
					PlayerData.bjh(ref clothingSetData2.desiredBottomUse, ref clothingSetData2.lastVerifiedBottomUse, clothingSetData2.BottomUse);
					PlayerData.bjh(ref clothingSetData2.desiredUnderwearUse, ref clothingSetData2.lastVerifiedUnderwearUse, clothingSetData2.UnderwearUse);
					PlayerData.bjh(ref clothingSetData2.desiredSocksUse, ref clothingSetData2.lastVerifiedSocksUse, clothingSetData2.SocksUse);
					PlayerData.bjh(ref clothingSetData2.desiredShoesUse, ref clothingSetData2.lastVerifiedShoesUse, clothingSetData2.ShoesUse);
					PlayerData.bjh(ref clothingSetData2.desiredSkinToneUse, ref clothingSetData2.lastVerifiedSkinToneUse, clothingSetData2.SkinToneUse);
					PlayerData.bjh(ref clothingSetData2.desiredIntimatePartsUse, ref clothingSetData2.lastVerifiedIntimatePartsUse, clothingSetData2.IntimatePartsUse);
					PlayerData.bjh(ref clothingSetData2.desiredPubicAndGenitalUse, ref clothingSetData2.lastVerifiedPubicAndGenitalUse, clothingSetData2.PubicAndGenitalUse);
				}
			}
		}
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x0001BC24 File Offset: 0x00019E24
	private static void bjh(ref int a, ref int b, int c)
	{
		if (a == 0 && b == 0 && c != 0)
		{
			Debug.LogWarning(a.bej());
			a = c;
		}
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x00005090 File Offset: 0x00003290
	public void bji()
	{
	}

	// Token: 0x04000542 RID: 1346
	public PlayerSaveData playerSaveData = new PlayerSaveData();

	// Token: 0x04000543 RID: 1347
	public ItemData[] itemDatas;

	// Token: 0x04000544 RID: 1348
	public List<AchievementData> achievementDatas = new List<AchievementData>();
}
