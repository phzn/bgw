using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BongoWaifu.Mcp
{
	// Token: 0x02000145 RID: 325
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class StatsInfoDto : IEquatable<StatsInfoDto>
	{
		// Token: 0x0600175A RID: 5978 RVA: 0x000741B8 File Offset: 0x000723B8
		public StatsInfoDto(int? ClickCount, int? OrgasmCount, int? CraftCount)
		{
			this.ClickCount = ClickCount;
			this.OrgasmCount = OrgasmCount;
			this.CraftCount = CraftCount;
			base..ctor();
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600175B RID: 5979 RVA: 0x000741D5 File Offset: 0x000723D5
		[CompilerGenerated]
		private Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(StatsInfoDto);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x000741E1 File Offset: 0x000723E1
		// (set) Token: 0x0600175D RID: 5981 RVA: 0x000741E9 File Offset: 0x000723E9
		public int? ClickCount { get; set; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x000741F2 File Offset: 0x000723F2
		// (set) Token: 0x0600175F RID: 5983 RVA: 0x000741FA File Offset: 0x000723FA
		public int? OrgasmCount { get; set; }

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x00074203 File Offset: 0x00072403
		// (set) Token: 0x06001761 RID: 5985 RVA: 0x0007420B File Offset: 0x0007240B
		public int? CraftCount { get; set; }

		// Token: 0x06001762 RID: 5986 RVA: 0x00074214 File Offset: 0x00072414
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("StatsInfoDto");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00074260 File Offset: 0x00072460
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("ClickCount = ");
			builder.Append(this.ClickCount.ToString());
			builder.Append(", OrgasmCount = ");
			builder.Append(this.OrgasmCount.ToString());
			builder.Append(", CraftCount = ");
			builder.Append(this.CraftCount.ToString());
			return true;
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x000742E8 File Offset: 0x000724E8
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(StatsInfoDto left, StatsInfoDto right)
		{
			return !(left == right);
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x000742F4 File Offset: 0x000724F4
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(StatsInfoDto left, StatsInfoDto right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x00074308 File Offset: 0x00072508
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(this.<ClickCount>k__BackingField)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(this.<OrgasmCount>k__BackingField)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(this.<CraftCount>k__BackingField);
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x0007436A File Offset: 0x0007256A
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as StatsInfoDto);
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x00074378 File Offset: 0x00072578
		[NullableContext(2)]
		[CompilerGenerated]
		public bool Equals(StatsInfoDto other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<int?>.Default.Equals(this.<ClickCount>k__BackingField, other.<ClickCount>k__BackingField) && EqualityComparer<int?>.Default.Equals(this.<OrgasmCount>k__BackingField, other.<OrgasmCount>k__BackingField) && EqualityComparer<int?>.Default.Equals(this.<CraftCount>k__BackingField, other.<CraftCount>k__BackingField));
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x000743F1 File Offset: 0x000725F1
		[CompilerGenerated]
		private StatsInfoDto(StatsInfoDto original)
		{
			this.ClickCount = original.<ClickCount>k__BackingField;
			this.OrgasmCount = original.<OrgasmCount>k__BackingField;
			this.CraftCount = original.<CraftCount>k__BackingField;
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x0007441D File Offset: 0x0007261D
		[CompilerGenerated]
		public void Deconstruct(out int? ClickCount, out int? OrgasmCount, out int? CraftCount)
		{
			ClickCount = this.ClickCount;
			OrgasmCount = this.OrgasmCount;
			CraftCount = this.CraftCount;
		}
	}
}
