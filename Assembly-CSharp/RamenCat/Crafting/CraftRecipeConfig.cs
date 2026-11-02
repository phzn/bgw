using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

namespace RamenCat.Crafting
{
	// Token: 0x020000F0 RID: 240
	[CreateAssetMenu(fileName = "CraftRecipeConfig", menuName = "BongoWaifu/Craft Recipe Config")]
	public class CraftRecipeConfig : ScriptableObject
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x00059640 File Offset: 0x00057840
		public int ksq
		{
			get
			{
				return this.slotCount;
			}
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x00059648 File Offset: 0x00057848
		public bool cqz(ItemData a)
		{
			if (a == null)
			{
				return false;
			}
			if (a.quantity == 0U)
			{
				return false;
			}
			if (!string.IsNullOrEmpty(a.rarity) && this.excludedInputRarities != null)
			{
				for (int i = 0; i < this.excludedInputRarities.Length; i++)
				{
					if (string.Equals(a.rarity, this.excludedInputRarities[i], StringComparison.OrdinalIgnoreCase))
					{
						return false;
					}
				}
			}
			if (!string.IsNullOrEmpty(a.category) && this.excludedCategories != null)
			{
				for (int j = 0; j < this.excludedCategories.Length; j++)
				{
					if (string.Equals(a.category, this.excludedCategories[j], StringComparison.OrdinalIgnoreCase))
					{
						return false;
					}
				}
			}
			if (this.tiers != null)
			{
				for (int k = 0; k < this.tiers.Length; k++)
				{
					if (this.tiers[k] != null && a.defID == this.tiers[k].generatorDefId)
					{
						return false;
					}
				}
			}
			if (this.excludeAchievementOnly && bq.hle != null)
			{
				SpineSkinData spineSkinData = bq.hle.bjx(a.defID);
				if (spineSkinData != null && spineSkinData.isNeedUnlock)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00059754 File Offset: 0x00057954
		public CraftTierEntry cra(string a)
		{
			if (string.IsNullOrEmpty(a) || this.tiers == null)
			{
				return null;
			}
			for (int i = 0; i < this.tiers.Length; i++)
			{
				if (this.tiers[i] != null && string.Equals(this.tiers[i].consumeRarity, a, StringComparison.OrdinalIgnoreCase))
				{
					return this.tiers[i];
				}
			}
			return null;
		}

		// Token: 0x04000961 RID: 2401
		public CraftTierEntry[] tiers = new CraftTierEntry[]
		{
			new CraftTierEntry
			{
				consumeRarity = a.bfb(),
				outputRarity = a.bfc(),
				generatorDefId = 30001
			},
			new CraftTierEntry
			{
				consumeRarity = a.bfc(),
				outputRarity = a.bfd(),
				generatorDefId = 30002
			},
			new CraftTierEntry
			{
				consumeRarity = a.bfd(),
				outputRarity = a.bfe(),
				generatorDefId = 30003
			},
			new CraftTierEntry
			{
				consumeRarity = a.bfe(),
				outputRarity = a.bff(),
				generatorDefId = 30004
			},
			new CraftTierEntry
			{
				consumeRarity = a.bff(),
				outputRarity = a.bfg(),
				generatorDefId = 30005
			}
		};

		// Token: 0x04000962 RID: 2402
		[SerializeField]
		private int slotCount = 10;

		// Token: 0x04000963 RID: 2403
		public string[] excludedCategories = new string[] { a.beq() };

		// Token: 0x04000964 RID: 2404
		public string[] excludedInputRarities = new string[] { a.bfg() };

		// Token: 0x04000965 RID: 2405
		public bool excludeAchievementOnly = true;

		// Token: 0x04000966 RID: 2406
		public float craftTimeoutSeconds = 5f;
	}
}
