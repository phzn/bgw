using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BongoWaifu.AiApi
{
	// Token: 0x02000179 RID: 377
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class AiChatRequest : IEquatable<AiChatRequest>
	{
		// Token: 0x060018AD RID: 6317 RVA: 0x0007B0D8 File Offset: 0x000792D8
		public AiChatRequest(string Model, string SystemPrompt, string UserMessage, int MaxTokens, float Temperature)
		{
			this.Model = Model;
			this.SystemPrompt = SystemPrompt;
			this.UserMessage = UserMessage;
			this.MaxTokens = MaxTokens;
			this.Temperature = Temperature;
			base..ctor();
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x0007B105 File Offset: 0x00079305
		[CompilerGenerated]
		private Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AiChatRequest);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060018AF RID: 6319 RVA: 0x0007B111 File Offset: 0x00079311
		// (set) Token: 0x060018B0 RID: 6320 RVA: 0x0007B119 File Offset: 0x00079319
		public string Model { get; set; }

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060018B1 RID: 6321 RVA: 0x0007B122 File Offset: 0x00079322
		// (set) Token: 0x060018B2 RID: 6322 RVA: 0x0007B12A File Offset: 0x0007932A
		public string SystemPrompt { get; set; }

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060018B3 RID: 6323 RVA: 0x0007B133 File Offset: 0x00079333
		// (set) Token: 0x060018B4 RID: 6324 RVA: 0x0007B13B File Offset: 0x0007933B
		public string UserMessage { get; set; }

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060018B5 RID: 6325 RVA: 0x0007B144 File Offset: 0x00079344
		// (set) Token: 0x060018B6 RID: 6326 RVA: 0x0007B14C File Offset: 0x0007934C
		public int MaxTokens { get; set; }

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060018B7 RID: 6327 RVA: 0x0007B155 File Offset: 0x00079355
		// (set) Token: 0x060018B8 RID: 6328 RVA: 0x0007B15D File Offset: 0x0007935D
		public float Temperature { get; set; }

		// Token: 0x060018B9 RID: 6329 RVA: 0x0007B168 File Offset: 0x00079368
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AiChatRequest");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x0007B1B4 File Offset: 0x000793B4
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Model = ");
			builder.Append(this.Model);
			builder.Append(", SystemPrompt = ");
			builder.Append(this.SystemPrompt);
			builder.Append(", UserMessage = ");
			builder.Append(this.UserMessage);
			builder.Append(", MaxTokens = ");
			builder.Append(this.MaxTokens.ToString());
			builder.Append(", Temperature = ");
			builder.Append(this.Temperature.ToString());
			return true;
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x0007B260 File Offset: 0x00079460
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(AiChatRequest left, AiChatRequest right)
		{
			return !(left == right);
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x0007B26C File Offset: 0x0007946C
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(AiChatRequest left, AiChatRequest right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x0007B280 File Offset: 0x00079480
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<Model>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<SystemPrompt>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<UserMessage>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<MaxTokens>k__BackingField)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(this.<Temperature>k__BackingField);
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x0007B310 File Offset: 0x00079510
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as AiChatRequest);
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x0007B320 File Offset: 0x00079520
		[NullableContext(2)]
		[CompilerGenerated]
		public bool Equals(AiChatRequest other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(this.<Model>k__BackingField, other.<Model>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<SystemPrompt>k__BackingField, other.<SystemPrompt>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<UserMessage>k__BackingField, other.<UserMessage>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<MaxTokens>k__BackingField, other.<MaxTokens>k__BackingField) && EqualityComparer<float>.Default.Equals(this.<Temperature>k__BackingField, other.<Temperature>k__BackingField));
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x0007B3D0 File Offset: 0x000795D0
		[CompilerGenerated]
		private AiChatRequest(AiChatRequest original)
		{
			this.Model = original.<Model>k__BackingField;
			this.SystemPrompt = original.<SystemPrompt>k__BackingField;
			this.UserMessage = original.<UserMessage>k__BackingField;
			this.MaxTokens = original.<MaxTokens>k__BackingField;
			this.Temperature = original.<Temperature>k__BackingField;
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0007B41F File Offset: 0x0007961F
		[CompilerGenerated]
		public void Deconstruct(out string Model, out string SystemPrompt, out string UserMessage, out int MaxTokens, out float Temperature)
		{
			Model = this.Model;
			SystemPrompt = this.SystemPrompt;
			UserMessage = this.UserMessage;
			MaxTokens = this.MaxTokens;
			Temperature = this.Temperature;
		}
	}
}
