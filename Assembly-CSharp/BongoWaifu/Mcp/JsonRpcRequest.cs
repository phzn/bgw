using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json.Linq;

namespace BongoWaifu.Mcp
{
	// Token: 0x0200014E RID: 334
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class JsonRpcRequest : IEquatable<JsonRpcRequest>
	{
		// Token: 0x0600179A RID: 6042 RVA: 0x00075ADA File Offset: 0x00073CDA
		public JsonRpcRequest(string JsonRpc, [Nullable(2)] JToken Id, string Method, [Nullable(2)] JToken Params)
		{
			this.JsonRpc = JsonRpc;
			this.Id = Id;
			this.Method = Method;
			this.Params = Params;
			base..ctor();
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x00075AFF File Offset: 0x00073CFF
		[CompilerGenerated]
		private Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(JsonRpcRequest);
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x00075B0B File Offset: 0x00073D0B
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x00075B13 File Offset: 0x00073D13
		public string JsonRpc { get; set; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x00075B1C File Offset: 0x00073D1C
		// (set) Token: 0x0600179F RID: 6047 RVA: 0x00075B24 File Offset: 0x00073D24
		[Nullable(2)]
		public JToken Id
		{
			[NullableContext(2)]
			get;
			[NullableContext(2)]
			set;
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x00075B2D File Offset: 0x00073D2D
		// (set) Token: 0x060017A1 RID: 6049 RVA: 0x00075B35 File Offset: 0x00073D35
		public string Method { get; set; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x00075B3E File Offset: 0x00073D3E
		// (set) Token: 0x060017A3 RID: 6051 RVA: 0x00075B46 File Offset: 0x00073D46
		[Nullable(2)]
		public JToken Params
		{
			[NullableContext(2)]
			get;
			[NullableContext(2)]
			set;
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060017A4 RID: 6052 RVA: 0x00075B4F File Offset: 0x00073D4F
		public bool IsNotification
		{
			get
			{
				return this.Id == null;
			}
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00075B5C File Offset: 0x00073D5C
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("JsonRpcRequest");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x00075BA8 File Offset: 0x00073DA8
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("JsonRpc = ");
			builder.Append(this.JsonRpc);
			builder.Append(", Id = ");
			builder.Append(this.Id);
			builder.Append(", Method = ");
			builder.Append(this.Method);
			builder.Append(", Params = ");
			builder.Append(this.Params);
			builder.Append(", IsNotification = ");
			builder.Append(this.IsNotification.ToString());
			return true;
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x00075C46 File Offset: 0x00073E46
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(JsonRpcRequest left, JsonRpcRequest right)
		{
			return !(left == right);
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x00075C52 File Offset: 0x00073E52
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(JsonRpcRequest left, JsonRpcRequest right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00075C68 File Offset: 0x00073E68
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<JsonRpc>k__BackingField)) * -1521134295 + EqualityComparer<JToken>.Default.GetHashCode(this.<Id>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<Method>k__BackingField)) * -1521134295 + EqualityComparer<JToken>.Default.GetHashCode(this.<Params>k__BackingField);
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00075CE1 File Offset: 0x00073EE1
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as JsonRpcRequest);
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x00075CF0 File Offset: 0x00073EF0
		[NullableContext(2)]
		[CompilerGenerated]
		public bool Equals(JsonRpcRequest other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(this.<JsonRpc>k__BackingField, other.<JsonRpc>k__BackingField) && EqualityComparer<JToken>.Default.Equals(this.<Id>k__BackingField, other.<Id>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<Method>k__BackingField, other.<Method>k__BackingField) && EqualityComparer<JToken>.Default.Equals(this.<Params>k__BackingField, other.<Params>k__BackingField));
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x00075D81 File Offset: 0x00073F81
		[CompilerGenerated]
		private JsonRpcRequest(JsonRpcRequest original)
		{
			this.JsonRpc = original.<JsonRpc>k__BackingField;
			this.Id = original.<Id>k__BackingField;
			this.Method = original.<Method>k__BackingField;
			this.Params = original.<Params>k__BackingField;
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x00075DB9 File Offset: 0x00073FB9
		[CompilerGenerated]
		public void Deconstruct(out string JsonRpc, [Nullable(2)] out JToken Id, out string Method, [Nullable(2)] out JToken Params)
		{
			JsonRpc = this.JsonRpc;
			Id = this.Id;
			Method = this.Method;
			Params = this.Params;
		}
	}
}
