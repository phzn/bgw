using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BongoWaifu.Mcp
{
	// Token: 0x02000143 RID: 323
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class InventoryItemDto : IEquatable<InventoryItemDto>
	{
		// Token: 0x06001732 RID: 5938 RVA: 0x00073BD3 File Offset: 0x00071DD3
		public InventoryItemDto(string ItemId, string DefinitionId, string Name, int Quantity)
		{
			this.ItemId = ItemId;
			this.DefinitionId = DefinitionId;
			this.Name = Name;
			this.Quantity = Quantity;
			base..ctor();
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x00073BF8 File Offset: 0x00071DF8
		[CompilerGenerated]
		private Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(InventoryItemDto);
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x00073C04 File Offset: 0x00071E04
		// (set) Token: 0x06001735 RID: 5941 RVA: 0x00073C0C File Offset: 0x00071E0C
		public string ItemId { get; set; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x00073C15 File Offset: 0x00071E15
		// (set) Token: 0x06001737 RID: 5943 RVA: 0x00073C1D File Offset: 0x00071E1D
		public string DefinitionId { get; set; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x00073C26 File Offset: 0x00071E26
		// (set) Token: 0x06001739 RID: 5945 RVA: 0x00073C2E File Offset: 0x00071E2E
		public string Name { get; set; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x00073C37 File Offset: 0x00071E37
		// (set) Token: 0x0600173B RID: 5947 RVA: 0x00073C3F File Offset: 0x00071E3F
		public int Quantity { get; set; }

		// Token: 0x0600173C RID: 5948 RVA: 0x00073C48 File Offset: 0x00071E48
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("InventoryItemDto");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00073C94 File Offset: 0x00071E94
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("ItemId = ");
			builder.Append(this.ItemId);
			builder.Append(", DefinitionId = ");
			builder.Append(this.DefinitionId);
			builder.Append(", Name = ");
			builder.Append(this.Name);
			builder.Append(", Quantity = ");
			builder.Append(this.Quantity.ToString());
			return true;
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x00073D19 File Offset: 0x00071F19
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(InventoryItemDto left, InventoryItemDto right)
		{
			return !(left == right);
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00073D25 File Offset: 0x00071F25
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(InventoryItemDto left, InventoryItemDto right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00073D3C File Offset: 0x00071F3C
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<ItemId>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<DefinitionId>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<Name>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<Quantity>k__BackingField);
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x00073DB5 File Offset: 0x00071FB5
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as InventoryItemDto);
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x00073DC4 File Offset: 0x00071FC4
		[NullableContext(2)]
		[CompilerGenerated]
		public bool Equals(InventoryItemDto other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(this.<ItemId>k__BackingField, other.<ItemId>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<DefinitionId>k__BackingField, other.<DefinitionId>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<Name>k__BackingField, other.<Name>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<Quantity>k__BackingField, other.<Quantity>k__BackingField));
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00073E55 File Offset: 0x00072055
		[CompilerGenerated]
		private InventoryItemDto(InventoryItemDto original)
		{
			this.ItemId = original.<ItemId>k__BackingField;
			this.DefinitionId = original.<DefinitionId>k__BackingField;
			this.Name = original.<Name>k__BackingField;
			this.Quantity = original.<Quantity>k__BackingField;
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00073E8D File Offset: 0x0007208D
		[CompilerGenerated]
		public void Deconstruct(out string ItemId, out string DefinitionId, out string Name, out int Quantity)
		{
			ItemId = this.ItemId;
			DefinitionId = this.DefinitionId;
			Name = this.Name;
			Quantity = this.Quantity;
		}
	}
}
