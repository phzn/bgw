using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BongoWaifu.AiApi
{
	// Token: 0x0200017B RID: 379
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class AiModelList : IEquatable<AiModelList>
	{
		// Token: 0x060018D9 RID: 6361 RVA: 0x0007B74C File Offset: 0x0007994C
		public AiModelList(bool Ok, IReadOnlyList<string> Models, AiErrorKind Error, [Nullable(2)] string RawDetail = null)
		{
			this.Ok = Ok;
			this.Models = Models;
			this.Error = Error;
			this.RawDetail = RawDetail;
			base..ctor();
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x0007B771 File Offset: 0x00079971
		[CompilerGenerated]
		private Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AiModelList);
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x0007B77D File Offset: 0x0007997D
		// (set) Token: 0x060018DC RID: 6364 RVA: 0x0007B785 File Offset: 0x00079985
		public bool Ok { get; set; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060018DD RID: 6365 RVA: 0x0007B78E File Offset: 0x0007998E
		// (set) Token: 0x060018DE RID: 6366 RVA: 0x0007B796 File Offset: 0x00079996
		public IReadOnlyList<string> Models { get; set; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060018DF RID: 6367 RVA: 0x0007B79F File Offset: 0x0007999F
		// (set) Token: 0x060018E0 RID: 6368 RVA: 0x0007B7A7 File Offset: 0x000799A7
		public AiErrorKind Error { get; set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060018E1 RID: 6369 RVA: 0x0007B7B0 File Offset: 0x000799B0
		// (set) Token: 0x060018E2 RID: 6370 RVA: 0x0007B7B8 File Offset: 0x000799B8
		[Nullable(2)]
		public string RawDetail
		{
			[NullableContext(2)]
			get;
			[NullableContext(2)]
			set;
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0007B7C1 File Offset: 0x000799C1
		public static AiModelList Success(IReadOnlyList<string> models)
		{
			return new AiModelList(true, models, AiErrorKind.None, null);
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x0007B7CC File Offset: 0x000799CC
		public static AiModelList Fail(AiErrorKind kind, [Nullable(2)] string detail = null)
		{
			return new AiModelList(false, Array.Empty<string>(), kind, detail);
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x0007B7DC File Offset: 0x000799DC
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AiModelList");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x0007B828 File Offset: 0x00079A28
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Ok = ");
			builder.Append(this.Ok.ToString());
			builder.Append(", Models = ");
			builder.Append(this.Models);
			builder.Append(", Error = ");
			builder.Append(this.Error.ToString());
			builder.Append(", RawDetail = ");
			builder.Append(this.RawDetail);
			return true;
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0007B8BB File Offset: 0x00079ABB
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(AiModelList left, AiModelList right)
		{
			return !(left == right);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0007B8C7 File Offset: 0x00079AC7
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(AiModelList left, AiModelList right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x0007B8DC File Offset: 0x00079ADC
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<Ok>k__BackingField)) * -1521134295 + EqualityComparer<IReadOnlyList<string>>.Default.GetHashCode(this.<Models>k__BackingField)) * -1521134295 + EqualityComparer<AiErrorKind>.Default.GetHashCode(this.<Error>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<RawDetail>k__BackingField);
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x0007B955 File Offset: 0x00079B55
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as AiModelList);
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x0007B964 File Offset: 0x00079B64
		[NullableContext(2)]
		[CompilerGenerated]
		public bool Equals(AiModelList other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<bool>.Default.Equals(this.<Ok>k__BackingField, other.<Ok>k__BackingField) && EqualityComparer<IReadOnlyList<string>>.Default.Equals(this.<Models>k__BackingField, other.<Models>k__BackingField) && EqualityComparer<AiErrorKind>.Default.Equals(this.<Error>k__BackingField, other.<Error>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<RawDetail>k__BackingField, other.<RawDetail>k__BackingField));
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0007B9F5 File Offset: 0x00079BF5
		[CompilerGenerated]
		private AiModelList(AiModelList original)
		{
			this.Ok = original.<Ok>k__BackingField;
			this.Models = original.<Models>k__BackingField;
			this.Error = original.<Error>k__BackingField;
			this.RawDetail = original.<RawDetail>k__BackingField;
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x0007BA2D File Offset: 0x00079C2D
		[CompilerGenerated]
		public void Deconstruct(out bool Ok, out IReadOnlyList<string> Models, out AiErrorKind Error, [Nullable(2)] out string RawDetail)
		{
			Ok = this.Ok;
			Models = this.Models;
			Error = this.Error;
			RawDetail = this.RawDetail;
		}
	}
}
