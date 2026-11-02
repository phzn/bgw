using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BongoWaifu.Mcp
{
	// Token: 0x02000142 RID: 322
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class AchievementDto : IEquatable<AchievementDto>
	{
		// Token: 0x0600171C RID: 5916 RVA: 0x0007386B File Offset: 0x00071A6B
		public AchievementDto(string ApiName, string DisplayName, string Description, bool Unlocked, [Nullable(2)] string UnlockTimeUtc)
		{
			this.ApiName = ApiName;
			this.DisplayName = DisplayName;
			this.Description = Description;
			this.Unlocked = Unlocked;
			this.UnlockTimeUtc = UnlockTimeUtc;
			base..ctor();
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600171D RID: 5917 RVA: 0x00073898 File Offset: 0x00071A98
		[CompilerGenerated]
		private Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AchievementDto);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x000738A4 File Offset: 0x00071AA4
		// (set) Token: 0x0600171F RID: 5919 RVA: 0x000738AC File Offset: 0x00071AAC
		public string ApiName { get; set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x000738B5 File Offset: 0x00071AB5
		// (set) Token: 0x06001721 RID: 5921 RVA: 0x000738BD File Offset: 0x00071ABD
		public string DisplayName { get; set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x000738C6 File Offset: 0x00071AC6
		// (set) Token: 0x06001723 RID: 5923 RVA: 0x000738CE File Offset: 0x00071ACE
		public string Description { get; set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x000738D7 File Offset: 0x00071AD7
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x000738DF File Offset: 0x00071ADF
		public bool Unlocked { get; set; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x000738E8 File Offset: 0x00071AE8
		// (set) Token: 0x06001727 RID: 5927 RVA: 0x000738F0 File Offset: 0x00071AF0
		[Nullable(2)]
		public string UnlockTimeUtc
		{
			[NullableContext(2)]
			get;
			[NullableContext(2)]
			set;
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x000738FC File Offset: 0x00071AFC
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AchievementDto");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x00073948 File Offset: 0x00071B48
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("ApiName = ");
			builder.Append(this.ApiName);
			builder.Append(", DisplayName = ");
			builder.Append(this.DisplayName);
			builder.Append(", Description = ");
			builder.Append(this.Description);
			builder.Append(", Unlocked = ");
			builder.Append(this.Unlocked.ToString());
			builder.Append(", UnlockTimeUtc = ");
			builder.Append(this.UnlockTimeUtc);
			return true;
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x000739E6 File Offset: 0x00071BE6
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(AchievementDto left, AchievementDto right)
		{
			return !(left == right);
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x000739F2 File Offset: 0x00071BF2
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(AchievementDto left, AchievementDto right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00073A08 File Offset: 0x00071C08
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<ApiName>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<DisplayName>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<Description>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<Unlocked>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<UnlockTimeUtc>k__BackingField);
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x00073A98 File Offset: 0x00071C98
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as AchievementDto);
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00073AA8 File Offset: 0x00071CA8
		[NullableContext(2)]
		[CompilerGenerated]
		public bool Equals(AchievementDto other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(this.<ApiName>k__BackingField, other.<ApiName>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<DisplayName>k__BackingField, other.<DisplayName>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<Description>k__BackingField, other.<Description>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<Unlocked>k__BackingField, other.<Unlocked>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<UnlockTimeUtc>k__BackingField, other.<UnlockTimeUtc>k__BackingField));
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00073B58 File Offset: 0x00071D58
		[CompilerGenerated]
		private AchievementDto(AchievementDto original)
		{
			this.ApiName = original.<ApiName>k__BackingField;
			this.DisplayName = original.<DisplayName>k__BackingField;
			this.Description = original.<Description>k__BackingField;
			this.Unlocked = original.<Unlocked>k__BackingField;
			this.UnlockTimeUtc = original.<UnlockTimeUtc>k__BackingField;
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00073BA7 File Offset: 0x00071DA7
		[CompilerGenerated]
		public void Deconstruct(out string ApiName, out string DisplayName, out string Description, out bool Unlocked, [Nullable(2)] out string UnlockTimeUtc)
		{
			ApiName = this.ApiName;
			DisplayName = this.DisplayName;
			Description = this.Description;
			Unlocked = this.Unlocked;
			UnlockTimeUtc = this.UnlockTimeUtc;
		}
	}
}
