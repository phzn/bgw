using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BongoWaifu.Mcp.Threading
{
	// Token: 0x0200015A RID: 346
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class UnityMainThreadDispatcher : MonoBehaviour
	{
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x000775CD File Offset: 0x000757CD
		public static UnityMainThreadDispatcher Instance
		{
			get
			{
				if (UnityMainThreadDispatcher._instance == null)
				{
					GameObject gameObject = new GameObject("[UnityMainThreadDispatcher]");
					global::UnityEngine.Object.DontDestroyOnLoad(gameObject);
					UnityMainThreadDispatcher._instance = gameObject.AddComponent<UnityMainThreadDispatcher>();
				}
				return UnityMainThreadDispatcher._instance;
			}
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x000775FB File Offset: 0x000757FB
		public void Enqueue(Action action)
		{
			this._queue.Enqueue(action);
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x0007760C File Offset: 0x0007580C
		private void Update()
		{
			int num = 0;
			Action action;
			while (num < 8 && this._queue.TryDequeue(out action))
			{
				try
				{
					action();
				}
				catch (Exception ex)
				{
					Debug.LogException(ex);
				}
				num++;
			}
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00077654 File Offset: 0x00075854
		private void OnDestroy()
		{
			if (UnityMainThreadDispatcher._instance == this)
			{
				UnityMainThreadDispatcher._instance = null;
			}
		}

		// Token: 0x04000C2C RID: 3116
		private const int MaxActionsPerFrame = 8;

		// Token: 0x04000C2D RID: 3117
		[Nullable(2)]
		private static UnityMainThreadDispatcher _instance;

		// Token: 0x04000C2E RID: 3118
		private readonly ConcurrentQueue<Action> _queue = new ConcurrentQueue<Action>();
	}
}
