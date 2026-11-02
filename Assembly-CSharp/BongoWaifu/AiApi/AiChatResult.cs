using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BongoWaifu.AiApi
{
	// Token: 0x0200017A RID: 378
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class AiChatResult : IEquatable<AiChatResult>
	{
		// Token: 0x060018C3 RID: 6339 RVA: 0x0007B44B File Offset: 0x0007964B
		public AiChatResult(bool Ok, string Text, AiErrorKind Error, string RawDetail)
		{
			this.Ok = Ok;
			this.Text = Text;
			this.Error = Error;
			this.RawDetail = RawDetail;
			base..ctor();
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060018C4 RID: 6340 RVA: 0x0007B470 File Offset: 0x00079670
		[Nullable(1)]
		[CompilerGenerated]
		private Type EqualityContract
		{
			[NullableContext(1)]
			[CompilerGenerated]
			get
			{
				return typeof(AiChatResult);
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x0007B47C File Offset: 0x0007967C
		// (set) Token: 0x060018C6 RID: 6342 RVA: 0x0007B484 File Offset: 0x00079684
		public bool Ok { get; set; }

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x0007B48D File Offset: 0x0007968D
		// (set) Token: 0x060018C8 RID: 6344 RVA: 0x0007B495 File Offset: 0x00079695
		public string Text { get; set; }

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x0007B49E File Offset: 0x0007969E
		// (set) Token: 0x060018CA RID: 6346 RVA: 0x0007B4A6 File Offset: 0x000796A6
		public AiErrorKind Error { get; set; }

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x0007B4AF File Offset: 0x000796AF
		// (set) Token: 0x060018CC RID: 6348 RVA: 0x0007B4B7 File Offset: 0x000796B7
		public string RawDetail { get; set; }

		// Token: 0x060018CD RID: 6349 RVA: 0x0007B4C0 File Offset: 0x000796C0
		[NullableContext(1)]
		public static AiChatResult Success(string text)
		{
			return new AiChatResult(true, text, AiErrorKind.None, null);
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x0007B4CB File Offset: 0x000796CB
		[NullableContext(1)]
		public static AiChatResult Fail(AiErrorKind kind, [Nullable(2)] string detail = null)
		{
			return new AiChatResult(false, null, kind, detail);
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0007B4D8 File Offset: 0x000796D8
		[NullableContext(1)]
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AiChatResult");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x0007B524 File Offset: 0x00079724
		[NullableContext(1)]
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Ok = ");
			builder.Append(this.Ok.ToString());
			builder.Append(", Text = ");
			builder.Append(this.Text);
			builder.Append(", Error = ");
			builder.Append(this.Error.ToString());
			builder.Append(", RawDetail = ");
			builder.Append(this.RawDetail);
			return true;
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x0007B5B7 File Offset: 0x000797B7
		[CompilerGenerated]
		public static bool operator !=(AiChatResult left, AiChatResult right)
		{
			return !(left == right);
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0007B5C3 File Offset: 0x000797C3
		[CompilerGenerated]
		public static bool operator ==(AiChatResult left, AiChatResult right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0007B5D8 File Offset: 0x000797D8
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<Ok>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<Text>k__BackingField)) * -1521134295 + EqualityComparer<AiErrorKind>.Default.GetHashCode(this.<Error>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<RawDetail>k__BackingField);
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0007B651 File Offset: 0x00079851
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as AiChatResult);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0007B660 File Offset: 0x00079860
		[CompilerGenerated]
		public bool Equals(AiChatResult other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<bool>.Default.Equals(this.<Ok>k__BackingField, other.<Ok>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<Text>k__BackingField, other.<Text>k__BackingField) && EqualityComparer<AiErrorKind>.Default.Equals(this.<Error>k__BackingField, other.<Error>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<RawDetail>k__BackingField, other.<RawDetail>k__BackingField));
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0007B6F1 File Offset: 0x000798F1
		[CompilerGenerated]
		private AiChatResult([Nullable(1)] AiChatResult original)
		{
			this.Ok = original.<Ok>k__BackingField;
			this.Text = original.<Text>k__BackingField;
			this.Error = original.<Error>k__BackingField;
			this.RawDetail = original.<RawDetail>k__BackingField;
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x0007B729 File Offset: 0x00079929
		[CompilerGenerated]
		public void Deconstruct(out bool Ok, out string Text, out AiErrorKind Error, out string RawDetail)
		{
			Ok = this.Ok;
			Text = this.Text;
			Error = this.Error;
			RawDetail = this.RawDetail;
		}
	}
}
