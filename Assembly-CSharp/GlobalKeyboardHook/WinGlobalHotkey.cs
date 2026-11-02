using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Threading;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

namespace GlobalKeyboardHook
{
	// Token: 0x020000FA RID: 250
	public static class WinGlobalHotkey
	{
		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06001284 RID: 4740 RVA: 0x0005ADD0 File Offset: 0x00058FD0
		// (remove) Token: 0x06001285 RID: 4741 RVA: 0x0005AE04 File Offset: 0x00059004
		public static event Action<int> ile;

		// Token: 0x06001286 RID: 4742 RVA: 0x0005AE38 File Offset: 0x00059038
		public static void ctp()
		{
			if (WinGlobalHotkey.ilr != null)
			{
				return;
			}
			WinGlobalHotkey.ilt.Reset();
			WinGlobalHotkey.ilr = new Thread(new ThreadStart(WinGlobalHotkey.cts))
			{
				IsBackground = true,
				Name = a.dqm()
			};
			WinGlobalHotkey.ilr.Start();
			if (!WinGlobalHotkey.ilt.Wait(2000))
			{
				Debug.LogWarning(a.dqn());
			}
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x0005AEA4 File Offset: 0x000590A4
		public static void ctq()
		{
			if (WinGlobalHotkey.ilr == null)
			{
				return;
			}
			if (WinGlobalHotkey.ils != 0U)
			{
				WinGlobalHotkey.PostThreadMessage(WinGlobalHotkey.ils, 18U, IntPtr.Zero, IntPtr.Zero);
			}
			WinGlobalHotkey.ilr.Join(2000);
			WinGlobalHotkey.ilr = null;
			WinGlobalHotkey.ils = 0U;
			int num;
			while (WinGlobalHotkey.ilq.TryDequeue(out num))
			{
			}
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x0005AF04 File Offset: 0x00059104
		public static void ctr()
		{
			int num;
			while (WinGlobalHotkey.ilq.TryDequeue(out num))
			{
				Action<int> action = WinGlobalHotkey.ile;
				if (action != null)
				{
					action(num);
				}
			}
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x0005AF34 File Offset: 0x00059134
		private static void cts()
		{
			WinGlobalHotkey.ils = WinGlobalHotkey.GetCurrentThreadId();
			bool flag = WinGlobalHotkey.RegisterHotKey(IntPtr.Zero, 1, 2U, 112U);
			bool flag2 = WinGlobalHotkey.RegisterHotKey(IntPtr.Zero, 2, 2U, 113U);
			bool flag3 = WinGlobalHotkey.RegisterHotKey(IntPtr.Zero, 3, 2U, 114U);
			bool flag4 = WinGlobalHotkey.RegisterHotKey(IntPtr.Zero, 4, 2U, 120U);
			if (!flag)
			{
				Debug.LogWarning(a.dqo());
			}
			if (!flag2)
			{
				Debug.LogWarning(a.dqp());
			}
			if (!flag3)
			{
				Debug.LogWarning(a.dqq());
			}
			if (!flag4)
			{
				Debug.LogWarning(a.dqr());
			}
			WinGlobalHotkey.ilt.Set();
			try
			{
				WinGlobalHotkey.MSG msg;
				while (WinGlobalHotkey.GetMessage(out msg, IntPtr.Zero, 0U, 0U) > 0 && msg.message != 18U)
				{
					if (msg.message == 786U)
					{
						int num = msg.wParam.ToInt32();
						if (num == 1)
						{
							WinGlobalHotkey.ilq.Enqueue(112);
						}
						else if (num == 2)
						{
							WinGlobalHotkey.ilq.Enqueue(113);
						}
						else if (num == 3)
						{
							WinGlobalHotkey.ilq.Enqueue(114);
						}
						else if (num == 4)
						{
							WinGlobalHotkey.ilq.Enqueue(120);
						}
					}
				}
			}
			finally
			{
				WinGlobalHotkey.UnregisterHotKey(IntPtr.Zero, 1);
				WinGlobalHotkey.UnregisterHotKey(IntPtr.Zero, 2);
				WinGlobalHotkey.UnregisterHotKey(IntPtr.Zero, 3);
				WinGlobalHotkey.UnregisterHotKey(IntPtr.Zero, 4);
			}
		}

		// Token: 0x0600128A RID: 4746
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

		// Token: 0x0600128B RID: 4747
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		// Token: 0x0600128C RID: 4748
		[DllImport("user32.dll")]
		private static extern int GetMessage(out WinGlobalHotkey.MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

		// Token: 0x0600128D RID: 4749
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool PostThreadMessage(uint idThread, uint Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x0600128E RID: 4750
		[DllImport("kernel32.dll")]
		private static extern uint GetCurrentThreadId();

		// Token: 0x04000992 RID: 2450
		private const uint ilf = 2U;

		// Token: 0x04000993 RID: 2451
		private const int ilg = 112;

		// Token: 0x04000994 RID: 2452
		private const int ilh = 113;

		// Token: 0x04000995 RID: 2453
		private const int ili = 114;

		// Token: 0x04000996 RID: 2454
		private const int ilj = 120;

		// Token: 0x04000997 RID: 2455
		private const int ilk = 1;

		// Token: 0x04000998 RID: 2456
		private const int ill = 2;

		// Token: 0x04000999 RID: 2457
		private const int ilm = 3;

		// Token: 0x0400099A RID: 2458
		private const int iln = 4;

		// Token: 0x0400099B RID: 2459
		private const uint ilo = 786U;

		// Token: 0x0400099C RID: 2460
		private const uint ilp = 18U;

		// Token: 0x0400099D RID: 2461
		private static readonly ConcurrentQueue<int> ilq = new ConcurrentQueue<int>();

		// Token: 0x0400099E RID: 2462
		private static Thread ilr;

		// Token: 0x0400099F RID: 2463
		private static uint ils;

		// Token: 0x040009A0 RID: 2464
		private static readonly ManualResetEventSlim ilt = new ManualResetEventSlim(false);

		// Token: 0x020000FB RID: 251
		private struct MSG
		{
			// Token: 0x040009A1 RID: 2465
			public IntPtr hwnd;

			// Token: 0x040009A2 RID: 2466
			public uint message;

			// Token: 0x040009A3 RID: 2467
			public IntPtr wParam;

			// Token: 0x040009A4 RID: 2468
			public IntPtr lParam;

			// Token: 0x040009A5 RID: 2469
			public uint time;

			// Token: 0x040009A6 RID: 2470
			public int pt_x;

			// Token: 0x040009A7 RID: 2471
			public int pt_y;
		}
	}
}
