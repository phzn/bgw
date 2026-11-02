using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BongoWaifu.Mcp
{
	// Token: 0x02000141 RID: 321
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class CharacterInfoDto : IEquatable<CharacterInfoDto>
	{
		// Token: 0x06001706 RID: 5894 RVA: 0x00073516 File Offset: 0x00071716
		public CharacterInfoDto(string CharacterId, string CharacterName, string CharacterType, [Nullable(2)] string CurrentSkin, List<string> CurrentClothes)
		{
			this.CharacterId = CharacterId;
			this.CharacterName = CharacterName;
			this.CharacterType = CharacterType;
			this.CurrentSkin = CurrentSkin;
			this.CurrentClothes = CurrentClothes;
			base..ctor();
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x00073543 File Offset: 0x00071743
		[CompilerGenerated]
		private Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(CharacterInfoDto);
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x0007354F File Offset: 0x0007174F
		// (set) Token: 0x06001709 RID: 5897 RVA: 0x00073557 File Offset: 0x00071757
		public string CharacterId { get; set; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x00073560 File Offset: 0x00071760
		// (set) Token: 0x0600170B RID: 5899 RVA: 0x00073568 File Offset: 0x00071768
		public string CharacterName { get; set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x00073571 File Offset: 0x00071771
		// (set) Token: 0x0600170D RID: 5901 RVA: 0x00073579 File Offset: 0x00071779
		public string CharacterType { get; set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x00073582 File Offset: 0x00071782
		// (set) Token: 0x0600170F RID: 5903 RVA: 0x0007358A File Offset: 0x0007178A
		[Nullable(2)]
		public string CurrentSkin
		{
			[NullableContext(2)]
			get;
			[NullableContext(2)]
			set;
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x00073593 File Offset: 0x00071793
		// (set) Token: 0x06001711 RID: 5905 RVA: 0x0007359B File Offset: 0x0007179B
		public List<string> CurrentClothes { get; set; }

		// Token: 0x06001712 RID: 5906 RVA: 0x000735A4 File Offset: 0x000717A4
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CharacterInfoDto");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x000735F0 File Offset: 0x000717F0
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("CharacterId = ");
			builder.Append(this.CharacterId);
			builder.Append(", CharacterName = ");
			builder.Append(this.CharacterName);
			builder.Append(", CharacterType = ");
			builder.Append(this.CharacterType);
			builder.Append(", CurrentSkin = ");
			builder.Append(this.CurrentSkin);
			builder.Append(", CurrentClothes = ");
			builder.Append(this.CurrentClothes);
			return true;
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x00073680 File Offset: 0x00071880
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(CharacterInfoDto left, CharacterInfoDto right)
		{
			return !(left == right);
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x0007368C File Offset: 0x0007188C
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(CharacterInfoDto left, CharacterInfoDto right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x000736A0 File Offset: 0x000718A0
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<CharacterId>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<CharacterName>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<CharacterType>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<CurrentSkin>k__BackingField)) * -1521134295 + EqualityComparer<List<string>>.Default.GetHashCode(this.<CurrentClothes>k__BackingField);
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x00073730 File Offset: 0x00071930
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as CharacterInfoDto);
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x00073740 File Offset: 0x00071940
		[NullableContext(2)]
		[CompilerGenerated]
		public bool Equals(CharacterInfoDto other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(this.<CharacterId>k__BackingField, other.<CharacterId>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<CharacterName>k__BackingField, other.<CharacterName>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<CharacterType>k__BackingField, other.<CharacterType>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<CurrentSkin>k__BackingField, other.<CurrentSkin>k__BackingField) && EqualityComparer<List<string>>.Default.Equals(this.<CurrentClothes>k__BackingField, other.<CurrentClothes>k__BackingField));
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x000737F0 File Offset: 0x000719F0
		[CompilerGenerated]
		private CharacterInfoDto(CharacterInfoDto original)
		{
			this.CharacterId = original.<CharacterId>k__BackingField;
			this.CharacterName = original.<CharacterName>k__BackingField;
			this.CharacterType = original.<CharacterType>k__BackingField;
			this.CurrentSkin = original.<CurrentSkin>k__BackingField;
			this.CurrentClothes = original.<CurrentClothes>k__BackingField;
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x0007383F File Offset: 0x00071A3F
		[CompilerGenerated]
		public void Deconstruct(out string CharacterId, out string CharacterName, out string CharacterType, [Nullable(2)] out string CurrentSkin, out List<string> CurrentClothes)
		{
			CharacterId = this.CharacterId;
			CharacterName = this.CharacterName;
			CharacterType = this.CharacterType;
			CurrentSkin = this.CurrentSkin;
			CurrentClothes = this.CurrentClothes;
		}
	}
}
