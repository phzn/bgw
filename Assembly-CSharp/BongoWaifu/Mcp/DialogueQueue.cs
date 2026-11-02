using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BongoWaifu.Mcp
{
	// Token: 0x0200013E RID: 318
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class DialogueQueue
	{
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x0007308C File Offset: 0x0007128C
		public int Count
		{
			get
			{
				object gate = this._gate;
				int count;
				lock (gate)
				{
					count = this._items.Count;
				}
				return count;
			}
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x000730D4 File Offset: 0x000712D4
		public EnqueueOutcome Enqueue(DialogueMessage msg)
		{
			object gate = this._gate;
			EnqueueOutcome enqueueOutcome;
			lock (gate)
			{
				if (msg.Kind == MessageKind.Ask)
				{
					DialogueMessage currentlyShowing = this._currentlyShowing;
					bool flag2;
					if (currentlyShowing == null || currentlyShowing.Kind != MessageKind.Ask)
					{
						flag2 = this._items.Any<DialogueMessage>((DialogueMessage m) => m.Kind == MessageKind.Ask);
					}
					else
					{
						flag2 = true;
					}
					if (flag2)
					{
						enqueueOutcome = EnqueueOutcome.Busy;
					}
					else
					{
						this._items.AddLast(msg);
						enqueueOutcome = EnqueueOutcome.Accepted;
					}
				}
				else
				{
					if (this._items.Count<DialogueMessage>((DialogueMessage m) => m.Kind == MessageKind.Say && m.SessionId == msg.SessionId) >= 10)
					{
						DialogueMessage dialogueMessage = this._items.First<DialogueMessage>((DialogueMessage m) => m.Kind == MessageKind.Say && m.SessionId == msg.SessionId);
						this._items.Remove(dialogueMessage);
					}
					if (this._items.Count<DialogueMessage>((DialogueMessage m) => m.Kind == MessageKind.Say) >= 50)
					{
						DialogueMessage dialogueMessage2 = this._items.First<DialogueMessage>((DialogueMessage m) => m.Kind == MessageKind.Say);
						this._items.Remove(dialogueMessage2);
					}
					this._items.AddLast(msg);
					enqueueOutcome = EnqueueOutcome.Accepted;
				}
			}
			return enqueueOutcome;
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x0007325C File Offset: 0x0007145C
		[NullableContext(2)]
		public DialogueMessage PeekFront()
		{
			object gate = this._gate;
			DialogueMessage dialogueMessage;
			lock (gate)
			{
				LinkedListNode<DialogueMessage> first = this._items.First;
				dialogueMessage = ((first != null) ? first.Value : null);
			}
			return dialogueMessage;
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x000732B0 File Offset: 0x000714B0
		[NullableContext(2)]
		public DialogueMessage Dequeue()
		{
			object gate = this._gate;
			DialogueMessage dialogueMessage;
			lock (gate)
			{
				if (this._items.First == null)
				{
					dialogueMessage = null;
				}
				else
				{
					DialogueMessage value = this._items.First.Value;
					this._items.RemoveFirst();
					dialogueMessage = value;
				}
			}
			return dialogueMessage;
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00073318 File Offset: 0x00071518
		public void RemovePendingAsksForSession(string sessionId)
		{
			object gate = this._gate;
			lock (gate)
			{
				LinkedListNode<DialogueMessage> next;
				for (LinkedListNode<DialogueMessage> linkedListNode = this._items.First; linkedListNode != null; linkedListNode = next)
				{
					next = linkedListNode.Next;
					if (linkedListNode.Value.Kind == MessageKind.Ask && linkedListNode.Value.SessionId == sessionId)
					{
						this._items.Remove(linkedListNode);
					}
				}
			}
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00073398 File Offset: 0x00071598
		public void Clear()
		{
			object gate = this._gate;
			lock (gate)
			{
				this._items.Clear();
				this._currentlyShowing = null;
			}
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x000733E4 File Offset: 0x000715E4
		public void MarkCurrentlyShowing(DialogueMessage msg)
		{
			object gate = this._gate;
			lock (gate)
			{
				this._currentlyShowing = msg;
			}
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00073428 File Offset: 0x00071628
		public void ClearCurrentlyShowing()
		{
			object gate = this._gate;
			lock (gate)
			{
				this._currentlyShowing = null;
			}
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x0007346C File Offset: 0x0007166C
		public List<DialogueMessage> Snapshot()
		{
			object gate = this._gate;
			List<DialogueMessage> list;
			lock (gate)
			{
				list = this._items.ToList<DialogueMessage>();
			}
			return list;
		}

		// Token: 0x04000BB7 RID: 2999
		public const int PerSessionSayCap = 10;

		// Token: 0x04000BB8 RID: 3000
		public const int GlobalSayCap = 50;

		// Token: 0x04000BB9 RID: 3001
		private readonly LinkedList<DialogueMessage> _items = new LinkedList<DialogueMessage>();

		// Token: 0x04000BBA RID: 3002
		private readonly object _gate = new object();

		// Token: 0x04000BBB RID: 3003
		[Nullable(2)]
		private DialogueMessage _currentlyShowing;
	}
}
