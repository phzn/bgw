using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BongoWaifu.Mcp
{
	// Token: 0x02000144 RID: 324
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class GaugeInfoDto : IEquatable<GaugeInfoDto>
	{
		// Token: 0x06001746 RID: 5958 RVA: 0x00073EB0 File Offset: 0x000720B0
		public GaugeInfoDto(float Hot, int HotLevel, float HotPerClick, float HotDecayPerSec)
		{
			this.Hot = Hot;
			this.HotLevel = HotLevel;
			this.HotPerClick = HotPerClick;
			this.HotDecayPerSec = HotDecayPerSec;
			base..ctor();
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06001747 RID: 5959 RVA: 0x00073ED5 File Offset: 0x000720D5
		[CompilerGenerated]
		private Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GaugeInfoDto);
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x00073EE1 File Offset: 0x000720E1
		// (set) Token: 0x06001749 RID: 5961 RVA: 0x00073EE9 File Offset: 0x000720E9
		public float Hot { get; set; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x00073EF2 File Offset: 0x000720F2
		// (set) Token: 0x0600174B RID: 5963 RVA: 0x00073EFA File Offset: 0x000720FA
		public int HotLevel { get; set; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x00073F03 File Offset: 0x00072103
		// (set) Token: 0x0600174D RID: 5965 RVA: 0x00073F0B File Offset: 0x0007210B
		public float HotPerClick { get; set; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x00073F14 File Offset: 0x00072114
		// (set) Token: 0x0600174F RID: 5967 RVA: 0x00073F1C File Offset: 0x0007211C
		public float HotDecayPerSec { get; set; }

		// Token: 0x06001750 RID: 5968 RVA: 0x00073F28 File Offset: 0x00072128
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GaugeInfoDto");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00073F74 File Offset: 0x00072174
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Hot = ");
			builder.Append(this.Hot.ToString());
			builder.Append(", HotLevel = ");
			builder.Append(this.HotLevel.ToString());
			builder.Append(", HotPerClick = ");
			builder.Append(this.HotPerClick.ToString());
			builder.Append(", HotDecayPerSec = ");
			builder.Append(this.HotDecayPerSec.ToString());
			return true;
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x00074023 File Offset: 0x00072223
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(GaugeInfoDto left, GaugeInfoDto right)
		{
			return !(left == right);
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0007402F File Offset: 0x0007222F
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(GaugeInfoDto left, GaugeInfoDto right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x00074044 File Offset: 0x00072244
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(this.<Hot>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<HotLevel>k__BackingField)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(this.<HotPerClick>k__BackingField)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(this.<HotDecayPerSec>k__BackingField);
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x000740BD File Offset: 0x000722BD
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as GaugeInfoDto);
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x000740CC File Offset: 0x000722CC
		[NullableContext(2)]
		[CompilerGenerated]
		public bool Equals(GaugeInfoDto other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<float>.Default.Equals(this.<Hot>k__BackingField, other.<Hot>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<HotLevel>k__BackingField, other.<HotLevel>k__BackingField) && EqualityComparer<float>.Default.Equals(this.<HotPerClick>k__BackingField, other.<HotPerClick>k__BackingField) && EqualityComparer<float>.Default.Equals(this.<HotDecayPerSec>k__BackingField, other.<HotDecayPerSec>k__BackingField));
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x0007415D File Offset: 0x0007235D
		[CompilerGenerated]
		private GaugeInfoDto(GaugeInfoDto original)
		{
			this.Hot = original.<Hot>k__BackingField;
			this.HotLevel = original.<HotLevel>k__BackingField;
			this.HotPerClick = original.<HotPerClick>k__BackingField;
			this.HotDecayPerSec = original.<HotDecayPerSec>k__BackingField;
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x00074195 File Offset: 0x00072395
		[CompilerGenerated]
		public void Deconstruct(out float Hot, out int HotLevel, out float HotPerClick, out float HotDecayPerSec)
		{
			Hot = this.Hot;
			HotLevel = this.HotLevel;
			HotPerClick = this.HotPerClick;
			HotDecayPerSec = this.HotDecayPerSec;
		}
	}
}
