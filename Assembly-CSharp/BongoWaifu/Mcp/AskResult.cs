using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BongoWaifu.Mcp
{
	// Token: 0x02000139 RID: 313
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class AskResult : IEquatable<AskResult>
	{
		// Token: 0x060016C4 RID: 5828 RVA: 0x00072904 File Offset: 0x00070B04
		public AskResult(string Outcome, [Nullable(2)] string Button, int? ButtonIndex)
		{
			this.Outcome = Outcome;
			this.Button = Button;
			this.ButtonIndex = ButtonIndex;
			base..ctor();
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060016C5 RID: 5829 RVA: 0x00072921 File Offset: 0x00070B21
		[CompilerGenerated]
		private Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AskResult);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x0007292D File Offset: 0x00070B2D
		// (set) Token: 0x060016C7 RID: 5831 RVA: 0x00072935 File Offset: 0x00070B35
		public string Outcome { get; set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x0007293E File Offset: 0x00070B3E
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x00072946 File Offset: 0x00070B46
		[Nullable(2)]
		public string Button
		{
			[NullableContext(2)]
			get;
			[NullableContext(2)]
			set;
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x0007294F File Offset: 0x00070B4F
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x00072957 File Offset: 0x00070B57
		public int? ButtonIndex { get; set; }

		// Token: 0x060016CC RID: 5836 RVA: 0x00072960 File Offset: 0x00070B60
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AskResult");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x000729AC File Offset: 0x00070BAC
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Outcome = ");
			builder.Append(this.Outcome);
			builder.Append(", Button = ");
			builder.Append(this.Button);
			builder.Append(", ButtonIndex = ");
			builder.Append(this.ButtonIndex.ToString());
			return true;
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x00072A18 File Offset: 0x00070C18
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(AskResult left, AskResult right)
		{
			return !(left == right);
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x00072A24 File Offset: 0x00070C24
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(AskResult left, AskResult right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00072A38 File Offset: 0x00070C38
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<Outcome>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<Button>k__BackingField)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(this.<ButtonIndex>k__BackingField);
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00072A9A File Offset: 0x00070C9A
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as AskResult);
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00072AA8 File Offset: 0x00070CA8
		[NullableContext(2)]
		[CompilerGenerated]
		public bool Equals(AskResult other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(this.<Outcome>k__BackingField, other.<Outcome>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<Button>k__BackingField, other.<Button>k__BackingField) && EqualityComparer<int?>.Default.Equals(this.<ButtonIndex>k__BackingField, other.<ButtonIndex>k__BackingField));
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00072B21 File Offset: 0x00070D21
		[CompilerGenerated]
		private AskResult(AskResult original)
		{
			this.Outcome = original.<Outcome>k__BackingField;
			this.Button = original.<Button>k__BackingField;
			this.ButtonIndex = original.<ButtonIndex>k__BackingField;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00072B4D File Offset: 0x00070D4D
		[CompilerGenerated]
		public void Deconstruct(out string Outcome, [Nullable(2)] out string Button, out int? ButtonIndex)
		{
			Outcome = this.Outcome;
			Button = this.Button;
			ButtonIndex = this.ButtonIndex;
		}
	}
}
