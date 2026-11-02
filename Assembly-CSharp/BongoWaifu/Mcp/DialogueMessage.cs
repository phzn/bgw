using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BongoWaifu.Mcp
{
	// Token: 0x0200013C RID: 316
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class DialogueMessage : IEquatable<DialogueMessage>
	{
		// Token: 0x060016D8 RID: 5848 RVA: 0x00072B84 File Offset: 0x00070D84
		public DialogueMessage(string MessageId, MessageKind Kind, string SessionId, string Text, float DisplaySeconds, [Nullable(new byte[] { 2, 1 })] IReadOnlyList<string> Buttons, [Nullable(new byte[] { 2, 1 })] TaskCompletionSource<AskResult> AskCompletion, DateTime EnqueuedAtUtc)
		{
			this.MessageId = MessageId;
			this.Kind = Kind;
			this.SessionId = SessionId;
			this.Text = Text;
			this.DisplaySeconds = DisplaySeconds;
			this.Buttons = Buttons;
			this.AskCompletion = AskCompletion;
			this.EnqueuedAtUtc = EnqueuedAtUtc;
			base..ctor();
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x00072BD4 File Offset: 0x00070DD4
		[CompilerGenerated]
		private Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DialogueMessage);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x00072BE0 File Offset: 0x00070DE0
		// (set) Token: 0x060016DB RID: 5851 RVA: 0x00072BE8 File Offset: 0x00070DE8
		public string MessageId { get; set; }

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x00072BF1 File Offset: 0x00070DF1
		// (set) Token: 0x060016DD RID: 5853 RVA: 0x00072BF9 File Offset: 0x00070DF9
		public MessageKind Kind { get; set; }

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x00072C02 File Offset: 0x00070E02
		// (set) Token: 0x060016DF RID: 5855 RVA: 0x00072C0A File Offset: 0x00070E0A
		public string SessionId { get; set; }

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x00072C13 File Offset: 0x00070E13
		// (set) Token: 0x060016E1 RID: 5857 RVA: 0x00072C1B File Offset: 0x00070E1B
		public string Text { get; set; }

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x00072C24 File Offset: 0x00070E24
		// (set) Token: 0x060016E3 RID: 5859 RVA: 0x00072C2C File Offset: 0x00070E2C
		public float DisplaySeconds { get; set; }

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x00072C35 File Offset: 0x00070E35
		// (set) Token: 0x060016E5 RID: 5861 RVA: 0x00072C3D File Offset: 0x00070E3D
		[Nullable(new byte[] { 2, 1 })]
		public IReadOnlyList<string> Buttons
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get;
			[param: Nullable(new byte[] { 2, 1 })]
			set;
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x00072C46 File Offset: 0x00070E46
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x00072C4E File Offset: 0x00070E4E
		[Nullable(new byte[] { 2, 1 })]
		public TaskCompletionSource<AskResult> AskCompletion
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get;
			[param: Nullable(new byte[] { 2, 1 })]
			set;
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x00072C57 File Offset: 0x00070E57
		// (set) Token: 0x060016E9 RID: 5865 RVA: 0x00072C5F File Offset: 0x00070E5F
		public DateTime EnqueuedAtUtc { get; set; }

		// Token: 0x060016EA RID: 5866 RVA: 0x00072C68 File Offset: 0x00070E68
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DialogueMessage");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00072CB4 File Offset: 0x00070EB4
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("MessageId = ");
			builder.Append(this.MessageId);
			builder.Append(", Kind = ");
			builder.Append(this.Kind.ToString());
			builder.Append(", SessionId = ");
			builder.Append(this.SessionId);
			builder.Append(", Text = ");
			builder.Append(this.Text);
			builder.Append(", DisplaySeconds = ");
			builder.Append(this.DisplaySeconds.ToString());
			builder.Append(", Buttons = ");
			builder.Append(this.Buttons);
			builder.Append(", AskCompletion = ");
			builder.Append(this.AskCompletion);
			builder.Append(", EnqueuedAtUtc = ");
			builder.Append(this.EnqueuedAtUtc.ToString());
			return true;
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00072DB9 File Offset: 0x00070FB9
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(DialogueMessage left, DialogueMessage right)
		{
			return !(left == right);
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00072DC5 File Offset: 0x00070FC5
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(DialogueMessage left, DialogueMessage right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00072DDC File Offset: 0x00070FDC
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<MessageId>k__BackingField)) * -1521134295 + EqualityComparer<MessageKind>.Default.GetHashCode(this.<Kind>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<SessionId>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<Text>k__BackingField)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(this.<DisplaySeconds>k__BackingField)) * -1521134295 + EqualityComparer<IReadOnlyList<string>>.Default.GetHashCode(this.<Buttons>k__BackingField)) * -1521134295 + EqualityComparer<TaskCompletionSource<AskResult>>.Default.GetHashCode(this.<AskCompletion>k__BackingField)) * -1521134295 + EqualityComparer<DateTime>.Default.GetHashCode(this.<EnqueuedAtUtc>k__BackingField);
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00072EB1 File Offset: 0x000710B1
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as DialogueMessage);
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00072EC0 File Offset: 0x000710C0
		[NullableContext(2)]
		[CompilerGenerated]
		public bool Equals(DialogueMessage other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(this.<MessageId>k__BackingField, other.<MessageId>k__BackingField) && EqualityComparer<MessageKind>.Default.Equals(this.<Kind>k__BackingField, other.<Kind>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<SessionId>k__BackingField, other.<SessionId>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<Text>k__BackingField, other.<Text>k__BackingField) && EqualityComparer<float>.Default.Equals(this.<DisplaySeconds>k__BackingField, other.<DisplaySeconds>k__BackingField) && EqualityComparer<IReadOnlyList<string>>.Default.Equals(this.<Buttons>k__BackingField, other.<Buttons>k__BackingField) && EqualityComparer<TaskCompletionSource<AskResult>>.Default.Equals(this.<AskCompletion>k__BackingField, other.<AskCompletion>k__BackingField) && EqualityComparer<DateTime>.Default.Equals(this.<EnqueuedAtUtc>k__BackingField, other.<EnqueuedAtUtc>k__BackingField));
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00072FC0 File Offset: 0x000711C0
		[CompilerGenerated]
		private DialogueMessage(DialogueMessage original)
		{
			this.MessageId = original.<MessageId>k__BackingField;
			this.Kind = original.<Kind>k__BackingField;
			this.SessionId = original.<SessionId>k__BackingField;
			this.Text = original.<Text>k__BackingField;
			this.DisplaySeconds = original.<DisplaySeconds>k__BackingField;
			this.Buttons = original.<Buttons>k__BackingField;
			this.AskCompletion = original.<AskCompletion>k__BackingField;
			this.EnqueuedAtUtc = original.<EnqueuedAtUtc>k__BackingField;
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00073034 File Offset: 0x00071234
		[CompilerGenerated]
		public void Deconstruct(out string MessageId, out MessageKind Kind, out string SessionId, out string Text, out float DisplaySeconds, [Nullable(new byte[] { 2, 1 })] out IReadOnlyList<string> Buttons, [Nullable(new byte[] { 2, 1 })] out TaskCompletionSource<AskResult> AskCompletion, out DateTime EnqueuedAtUtc)
		{
			MessageId = this.MessageId;
			Kind = this.Kind;
			SessionId = this.SessionId;
			Text = this.Text;
			DisplaySeconds = this.DisplaySeconds;
			Buttons = this.Buttons;
			AskCompletion = this.AskCompletion;
			EnqueuedAtUtc = this.EnqueuedAtUtc;
		}
	}
}
