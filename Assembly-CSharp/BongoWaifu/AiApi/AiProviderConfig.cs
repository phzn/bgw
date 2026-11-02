using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BongoWaifu.AiApi
{
	// Token: 0x0200016D RID: 365
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class AiProviderConfig : IEquatable<AiProviderConfig>
	{
		// Token: 0x0600182D RID: 6189 RVA: 0x00078C48 File Offset: 0x00076E48
		public AiProviderConfig(AiProviderId Id, string DisplayName, string DefaultBaseUrl, string ChatPath, string ModelsPath, AiAuthStyle AuthStyle, [Nullable(2)] string AuthHeaderName, [TupleElementNames(new string[] { "Name", "Value" })] [Nullable(new byte[] { 2, 0, 1, 1 })] IReadOnlyList<ValueTuple<string, string>> ExtraHeaders, bool AllowsCustomBaseUrl)
		{
			this.Id = Id;
			this.DisplayName = DisplayName;
			this.DefaultBaseUrl = DefaultBaseUrl;
			this.ChatPath = ChatPath;
			this.ModelsPath = ModelsPath;
			this.AuthStyle = AuthStyle;
			this.AuthHeaderName = AuthHeaderName;
			this.ExtraHeaders = ExtraHeaders;
			this.AllowsCustomBaseUrl = AllowsCustomBaseUrl;
			base..ctor();
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600182E RID: 6190 RVA: 0x00078CA0 File Offset: 0x00076EA0
		[CompilerGenerated]
		private Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AiProviderConfig);
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x00078CAC File Offset: 0x00076EAC
		// (set) Token: 0x06001830 RID: 6192 RVA: 0x00078CB4 File Offset: 0x00076EB4
		public AiProviderId Id { get; set; }

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x00078CBD File Offset: 0x00076EBD
		// (set) Token: 0x06001832 RID: 6194 RVA: 0x00078CC5 File Offset: 0x00076EC5
		public string DisplayName { get; set; }

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x00078CCE File Offset: 0x00076ECE
		// (set) Token: 0x06001834 RID: 6196 RVA: 0x00078CD6 File Offset: 0x00076ED6
		public string DefaultBaseUrl { get; set; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x00078CDF File Offset: 0x00076EDF
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x00078CE7 File Offset: 0x00076EE7
		public string ChatPath { get; set; }

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x00078CF0 File Offset: 0x00076EF0
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x00078CF8 File Offset: 0x00076EF8
		public string ModelsPath { get; set; }

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x00078D01 File Offset: 0x00076F01
		// (set) Token: 0x0600183A RID: 6202 RVA: 0x00078D09 File Offset: 0x00076F09
		public AiAuthStyle AuthStyle { get; set; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x00078D12 File Offset: 0x00076F12
		// (set) Token: 0x0600183C RID: 6204 RVA: 0x00078D1A File Offset: 0x00076F1A
		[Nullable(2)]
		public string AuthHeaderName
		{
			[NullableContext(2)]
			get;
			[NullableContext(2)]
			set;
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x00078D23 File Offset: 0x00076F23
		// (set) Token: 0x0600183E RID: 6206 RVA: 0x00078D2B File Offset: 0x00076F2B
		[TupleElementNames(new string[] { "Name", "Value" })]
		[Nullable(new byte[] { 2, 0, 1, 1 })]
		public IReadOnlyList<ValueTuple<string, string>> ExtraHeaders
		{
			[return: TupleElementNames(new string[] { "Name", "Value" })]
			[return: Nullable(new byte[] { 2, 0, 1, 1 })]
			get;
			[param: TupleElementNames(new string[] { "Name", "Value" })]
			[param: Nullable(new byte[] { 2, 0, 1, 1 })]
			set;
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600183F RID: 6207 RVA: 0x00078D34 File Offset: 0x00076F34
		// (set) Token: 0x06001840 RID: 6208 RVA: 0x00078D3C File Offset: 0x00076F3C
		public bool AllowsCustomBaseUrl { get; set; }

		// Token: 0x06001841 RID: 6209 RVA: 0x00078D48 File Offset: 0x00076F48
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AiProviderConfig");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00078D94 File Offset: 0x00076F94
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Id = ");
			builder.Append(this.Id.ToString());
			builder.Append(", DisplayName = ");
			builder.Append(this.DisplayName);
			builder.Append(", DefaultBaseUrl = ");
			builder.Append(this.DefaultBaseUrl);
			builder.Append(", ChatPath = ");
			builder.Append(this.ChatPath);
			builder.Append(", ModelsPath = ");
			builder.Append(this.ModelsPath);
			builder.Append(", AuthStyle = ");
			builder.Append(this.AuthStyle.ToString());
			builder.Append(", AuthHeaderName = ");
			builder.Append(this.AuthHeaderName);
			builder.Append(", ExtraHeaders = ");
			builder.Append(this.ExtraHeaders);
			builder.Append(", AllowsCustomBaseUrl = ");
			builder.Append(this.AllowsCustomBaseUrl.ToString());
			return true;
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00078EB2 File Offset: 0x000770B2
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(AiProviderConfig left, AiProviderConfig right)
		{
			return !(left == right);
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00078EBE File Offset: 0x000770BE
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(AiProviderConfig left, AiProviderConfig right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00078ED4 File Offset: 0x000770D4
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<AiProviderId>.Default.GetHashCode(this.<Id>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<DisplayName>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<DefaultBaseUrl>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<ChatPath>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<ModelsPath>k__BackingField)) * -1521134295 + EqualityComparer<AiAuthStyle>.Default.GetHashCode(this.<AuthStyle>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<AuthHeaderName>k__BackingField)) * -1521134295 + EqualityComparer<IReadOnlyList<ValueTuple<string, string>>>.Default.GetHashCode(this.<ExtraHeaders>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<AllowsCustomBaseUrl>k__BackingField);
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00078FC0 File Offset: 0x000771C0
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as AiProviderConfig);
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00078FD0 File Offset: 0x000771D0
		[NullableContext(2)]
		[CompilerGenerated]
		public bool Equals(AiProviderConfig other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<AiProviderId>.Default.Equals(this.<Id>k__BackingField, other.<Id>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<DisplayName>k__BackingField, other.<DisplayName>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<DefaultBaseUrl>k__BackingField, other.<DefaultBaseUrl>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<ChatPath>k__BackingField, other.<ChatPath>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<ModelsPath>k__BackingField, other.<ModelsPath>k__BackingField) && EqualityComparer<AiAuthStyle>.Default.Equals(this.<AuthStyle>k__BackingField, other.<AuthStyle>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<AuthHeaderName>k__BackingField, other.<AuthHeaderName>k__BackingField) && EqualityComparer<IReadOnlyList<ValueTuple<string, string>>>.Default.Equals(this.<ExtraHeaders>k__BackingField, other.<ExtraHeaders>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<AllowsCustomBaseUrl>k__BackingField, other.<AllowsCustomBaseUrl>k__BackingField));
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x000790EC File Offset: 0x000772EC
		[CompilerGenerated]
		private AiProviderConfig(AiProviderConfig original)
		{
			this.Id = original.<Id>k__BackingField;
			this.DisplayName = original.<DisplayName>k__BackingField;
			this.DefaultBaseUrl = original.<DefaultBaseUrl>k__BackingField;
			this.ChatPath = original.<ChatPath>k__BackingField;
			this.ModelsPath = original.<ModelsPath>k__BackingField;
			this.AuthStyle = original.<AuthStyle>k__BackingField;
			this.AuthHeaderName = original.<AuthHeaderName>k__BackingField;
			this.ExtraHeaders = original.<ExtraHeaders>k__BackingField;
			this.AllowsCustomBaseUrl = original.<AllowsCustomBaseUrl>k__BackingField;
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x0007916C File Offset: 0x0007736C
		[CompilerGenerated]
		public void Deconstruct(out AiProviderId Id, out string DisplayName, out string DefaultBaseUrl, out string ChatPath, out string ModelsPath, out AiAuthStyle AuthStyle, [Nullable(2)] out string AuthHeaderName, [TupleElementNames(new string[] { "Name", "Value" })] [Nullable(new byte[] { 2, 0, 1, 1 })] out IReadOnlyList<ValueTuple<string, string>> ExtraHeaders, out bool AllowsCustomBaseUrl)
		{
			Id = this.Id;
			DisplayName = this.DisplayName;
			DefaultBaseUrl = this.DefaultBaseUrl;
			ChatPath = this.ChatPath;
			ModelsPath = this.ModelsPath;
			AuthStyle = this.AuthStyle;
			AuthHeaderName = this.AuthHeaderName;
			ExtraHeaders = this.ExtraHeaders;
			AllowsCustomBaseUrl = this.AllowsCustomBaseUrl;
		}
	}
}
