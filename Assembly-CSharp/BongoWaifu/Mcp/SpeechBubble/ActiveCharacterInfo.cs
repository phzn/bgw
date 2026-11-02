using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace BongoWaifu.Mcp.SpeechBubble
{
	// Token: 0x0200015E RID: 350
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class ActiveCharacterInfo : IEquatable<ActiveCharacterInfo>
	{
		// Token: 0x060017EB RID: 6123 RVA: 0x00077958 File Offset: 0x00075B58
		public ActiveCharacterInfo(string CharacterId, string DisplayName, CharacterType Type, Transform Root)
		{
			this.CharacterId = CharacterId;
			this.DisplayName = DisplayName;
			this.Type = Type;
			this.Root = Root;
			base..ctor();
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x0007797D File Offset: 0x00075B7D
		[CompilerGenerated]
		private Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ActiveCharacterInfo);
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060017ED RID: 6125 RVA: 0x00077989 File Offset: 0x00075B89
		// (set) Token: 0x060017EE RID: 6126 RVA: 0x00077991 File Offset: 0x00075B91
		public string CharacterId { get; set; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x0007799A File Offset: 0x00075B9A
		// (set) Token: 0x060017F0 RID: 6128 RVA: 0x000779A2 File Offset: 0x00075BA2
		public string DisplayName { get; set; }

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x000779AB File Offset: 0x00075BAB
		// (set) Token: 0x060017F2 RID: 6130 RVA: 0x000779B3 File Offset: 0x00075BB3
		public CharacterType Type { get; set; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060017F3 RID: 6131 RVA: 0x000779BC File Offset: 0x00075BBC
		// (set) Token: 0x060017F4 RID: 6132 RVA: 0x000779C4 File Offset: 0x00075BC4
		public Transform Root { get; set; }

		// Token: 0x060017F5 RID: 6133 RVA: 0x000779D0 File Offset: 0x00075BD0
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ActiveCharacterInfo");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00077A1C File Offset: 0x00075C1C
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("CharacterId = ");
			builder.Append(this.CharacterId);
			builder.Append(", DisplayName = ");
			builder.Append(this.DisplayName);
			builder.Append(", Type = ");
			builder.Append(this.Type.ToString());
			builder.Append(", Root = ");
			builder.Append(this.Root);
			return true;
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00077AA1 File Offset: 0x00075CA1
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(ActiveCharacterInfo left, ActiveCharacterInfo right)
		{
			return !(left == right);
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00077AAD File Offset: 0x00075CAD
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(ActiveCharacterInfo left, ActiveCharacterInfo right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00077AC4 File Offset: 0x00075CC4
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<global::System.Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<CharacterId>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<DisplayName>k__BackingField)) * -1521134295 + EqualityComparer<CharacterType>.Default.GetHashCode(this.<Type>k__BackingField)) * -1521134295 + EqualityComparer<Transform>.Default.GetHashCode(this.<Root>k__BackingField);
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00077B3D File Offset: 0x00075D3D
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as ActiveCharacterInfo);
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x00077B4C File Offset: 0x00075D4C
		[NullableContext(2)]
		[CompilerGenerated]
		public bool Equals(ActiveCharacterInfo other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(this.<CharacterId>k__BackingField, other.<CharacterId>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<DisplayName>k__BackingField, other.<DisplayName>k__BackingField) && EqualityComparer<CharacterType>.Default.Equals(this.<Type>k__BackingField, other.<Type>k__BackingField) && EqualityComparer<Transform>.Default.Equals(this.<Root>k__BackingField, other.<Root>k__BackingField));
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00077BDD File Offset: 0x00075DDD
		[CompilerGenerated]
		private ActiveCharacterInfo(ActiveCharacterInfo original)
		{
			this.CharacterId = original.<CharacterId>k__BackingField;
			this.DisplayName = original.<DisplayName>k__BackingField;
			this.Type = original.<Type>k__BackingField;
			this.Root = original.<Root>k__BackingField;
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x00077C15 File Offset: 0x00075E15
		[CompilerGenerated]
		public void Deconstruct(out string CharacterId, out string DisplayName, out CharacterType Type, out Transform Root)
		{
			CharacterId = this.CharacterId;
			DisplayName = this.DisplayName;
			Type = this.Type;
			Root = this.Root;
		}
	}
}
