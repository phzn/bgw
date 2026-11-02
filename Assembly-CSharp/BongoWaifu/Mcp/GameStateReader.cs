using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BongoWaifu.Mcp.SpeechBubble;
using RamenCat;
using Spine;

namespace BongoWaifu.Mcp
{
	// Token: 0x02000146 RID: 326
	[NullableContext(1)]
	[Nullable(0)]
	public static class GameStateReader
	{
		// Token: 0x0600176C RID: 5996 RVA: 0x00074444 File Offset: 0x00072644
		public static CharacterInfoDto ReadCharacter()
		{
			ActiveCharacterInfo activeCharacterInfo = ((bl.kmv != null) ? bl.kmv.hjj : null);
			if (activeCharacterInfo == null)
			{
				return new CharacterInfoDto("unknown", "Unknown", "waifu", null, new List<string>());
			}
			string text = null;
			List<string> list = new List<string>();
			if (activeCharacterInfo.Type == CharacterType.Waifu)
			{
				text = GameStateReader.ReadWaifuSkinName();
				GameStateReader.CollectWornClothes(list);
			}
			return new CharacterInfoDto(activeCharacterInfo.CharacterId, activeCharacterInfo.DisplayName, (activeCharacterInfo.Type == CharacterType.Waifu) ? "waifu" : "cat", text, list);
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x000744D4 File Offset: 0x000726D4
		[return: Nullable(new byte[] { 2, 1 })]
		public static List<AchievementDto> ReadAchievements(bool includeLocked)
		{
			du du = du.iah;
			if (du == null || !du.iai)
			{
				return null;
			}
			List<AchievementDto> list = new List<AchievementDto>();
			foreach (object obj in Enum.GetValues(typeof(du.ACHIEVEMENT)))
			{
				du.ACHIEVEMENT achievement = (du.ACHIEVEMENT)obj;
				bool flag = du.cej(achievement);
				if (includeLocked || flag)
				{
					string text = achievement.ToString();
					string text2 = null;
					uint num;
					if (flag && du.cek(achievement, out num) && num > 0U)
					{
						text2 = DateTimeOffset.FromUnixTimeSeconds((long)((ulong)num)).UtcDateTime.ToString("o");
					}
					list.Add(new AchievementDto(text, text, string.Empty, flag, text2));
				}
			}
			return list;
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x000745C4 File Offset: 0x000727C4
		[return: Nullable(new byte[] { 2, 1 })]
		public static List<InventoryItemDto> ReadInventory()
		{
			if (!bq.hmf)
			{
				return null;
			}
			List<InventoryItemDto> list = new List<InventoryItemDto>();
			SteamInventoryManager steamInventoryManager = SteamInventoryManager.iid;
			if (steamInventoryManager == null)
			{
				return list;
			}
			foreach (ItemData itemData in steamInventoryManager.cpm())
			{
				if (itemData != null)
				{
					list.Add(new InventoryItemDto(itemData.itemId.ToString(), itemData.defID.ToString(), itemData.name ?? string.Empty, (int)itemData.quantity));
				}
			}
			return list;
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00074664 File Offset: 0x00072864
		[NullableContext(2)]
		public static GaugeInfoDto ReadGauges()
		{
			GirlController girlController = GirlController.kok;
			if (girlController == null)
			{
				return null;
			}
			float num = girlController.kog;
			int num2 = ((num > 75f) ? 3 : ((num > 50f) ? 2 : ((num > 25f) ? 1 : 0)));
			return new GaugeInfoDto(num, num2, 0.2f, 0.5555556f);
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x000746C0 File Offset: 0x000728C0
		[NullableContext(2)]
		public static StatsInfoDto ReadStats()
		{
			du du = du.iah;
			if (du == null || !du.iai)
			{
				return null;
			}
			int num2;
			int? num = (du.ceg(du.STEAM_STAT_ID.STAT_CLICK, out num2) ? new int?(num2) : null);
			int num4;
			int? num3 = (du.ceg(du.STEAM_STAT_ID.STAT_ORGASM, out num4) ? new int?(num4) : null);
			int num6;
			int? num5 = (du.ceg(du.STEAM_STAT_ID.STAT_CRAFT_TOTAL_COUNT, out num6) ? new int?(num6) : null);
			return new StatsInfoDto(num, num3, num5);
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0007474C File Offset: 0x0007294C
		[NullableContext(2)]
		private static string ReadWaifuSkinName()
		{
			GirlController girlController = GirlController.kok;
			if (girlController == null || girlController.skeletonAnimation == null)
			{
				return null;
			}
			Skeleton skeleton = girlController.skeletonAnimation.Skeleton;
			Skin skin = ((skeleton != null) ? skeleton.Skin : null);
			if (skin == null)
			{
				return null;
			}
			return skin.Name;
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x0007479C File Offset: 0x0007299C
		private static void CollectWornClothes(List<string> target)
		{
			PlayerData hlf = bq.hlf;
			if (hlf == null || hlf.playerSaveData == null)
			{
				return;
			}
			GameStateReader.AddClotheName(target, bq.kni);
			GameStateReader.AddClotheName(target, bq.knj);
			GameStateReader.AddClotheName(target, bq.knk);
			GameStateReader.AddClotheName(target, bq.knh);
			GameStateReader.AddClotheName(target, bq.knl);
			GameStateReader.AddClotheName(target, bq.knm);
			GameStateReader.AddClotheName(target, bq.kng);
			GameStateReader.AddClotheName(target, bq.knn);
			GameStateReader.AddClotheName(target, bq.kno);
			GameStateReader.AddClotheName(target, bq.knp);
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00074830 File Offset: 0x00072A30
		private static void AddClotheName(List<string> target, int id)
		{
			if (id <= 0)
			{
				return;
			}
			if (Enum.IsDefined(typeof(CLOTHE_NAME), id))
			{
				CLOTHE_NAME clothe_NAME = (CLOTHE_NAME)id;
				target.Add(clothe_NAME.ToString());
			}
		}
	}
}
