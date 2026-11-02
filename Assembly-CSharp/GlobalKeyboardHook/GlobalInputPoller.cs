using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace GlobalKeyboardHook
{
	// Token: 0x020000F4 RID: 244
	internal static class GlobalInputPoller
	{
		// Token: 0x0600124A RID: 4682 RVA: 0x0005A668 File Offset: 0x00058868
		public static void csf()
		{
			object obj = GlobalInputPoller.ikn;
			lock (obj)
			{
				GlobalInputPoller.iku++;
				if (GlobalInputPoller.iku == 1)
				{
					GlobalInputPoller.csm();
					GlobalInputPoller.ikt = new Timer(new TimerCallback(GlobalInputPoller.csk), null, 0, 16);
				}
			}
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x0005A6D4 File Offset: 0x000588D4
		public static void csg()
		{
			object obj = GlobalInputPoller.ikn;
			lock (obj)
			{
				if (GlobalInputPoller.iku != 0)
				{
					GlobalInputPoller.iku--;
					if (GlobalInputPoller.iku == 0)
					{
						GlobalInputPoller.csn();
						GlobalInputPoller.csm();
					}
				}
			}
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x0005A734 File Offset: 0x00058934
		public static bool csh(out int a)
		{
			return GlobalInputPoller.iko.TryDequeue(out a);
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x0005A744 File Offset: 0x00058944
		public static bool csi()
		{
			bool flag;
			return GlobalInputPoller.ikp.TryDequeue(out flag);
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x0005A760 File Offset: 0x00058960
		public static bool csj()
		{
			bool flag;
			return GlobalInputPoller.ikq.TryDequeue(out flag);
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0005A77C File Offset: 0x0005897C
		private static void csk(object a)
		{
			if (Interlocked.CompareExchange(ref GlobalInputPoller.ikv, 1, 0) != 0)
			{
				return;
			}
			try
			{
				object obj = GlobalInputPoller.ikn;
				lock (obj)
				{
					int[] array = GlobalInputPoller.ikr;
					bool[] array2 = GlobalInputPoller.iks;
					for (int i = 0; i < array.Length; i++)
					{
						int num = array[i];
						bool flag2 = ((int)GlobalInputPoller.GetAsyncKeyState(num) & 32768) != 0;
						if (!array2[i] && flag2)
						{
							array2[i] = true;
							GlobalInputPoller.csl(num);
						}
						else if (array2[i] && !flag2)
						{
							array2[i] = false;
						}
					}
				}
			}
			catch (Exception ex)
			{
				Debug.LogException(ex);
			}
			finally
			{
				Interlocked.Exchange(ref GlobalInputPoller.ikv, 0);
			}
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0005A854 File Offset: 0x00058A54
		private static void csl(int a)
		{
			if (a == 1)
			{
				GlobalInputPoller.ikp.Enqueue(true);
				return;
			}
			if (a == 2)
			{
				GlobalInputPoller.ikq.Enqueue(true);
				return;
			}
			if (a != 4 && a != 5 && a != 6)
			{
				GlobalInputPoller.iko.Enqueue(a);
			}
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x0005A890 File Offset: 0x00058A90
		private static void csm()
		{
			for (int i = 0; i < GlobalInputPoller.iks.Length; i++)
			{
				GlobalInputPoller.iks[i] = false;
			}
			int num;
			while (GlobalInputPoller.iko.TryDequeue(out num))
			{
			}
			bool flag;
			while (GlobalInputPoller.ikp.TryDequeue(out flag))
			{
			}
			while (GlobalInputPoller.ikq.TryDequeue(out flag))
			{
			}
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0005A8E1 File Offset: 0x00058AE1
		private static void csn()
		{
			if (GlobalInputPoller.ikt == null)
			{
				return;
			}
			GlobalInputPoller.ikt.Dispose();
			GlobalInputPoller.ikt = null;
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x0005A8FB File Offset: 0x00058AFB
		private static void cso()
		{
			GlobalInputPoller.csn();
			GlobalInputPoller.iku = 0;
			Interlocked.Exchange(ref GlobalInputPoller.ikv, 0);
			GlobalInputPoller.csm();
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x0005A91C File Offset: 0x00058B1C
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void OnSubsystemRegistration()
		{
			object obj = GlobalInputPoller.ikn;
			lock (obj)
			{
				GlobalInputPoller.cso();
			}
			Application.quitting -= GlobalInputPoller.csp;
			Application.quitting += GlobalInputPoller.csp;
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x0005A97C File Offset: 0x00058B7C
		private static void csp()
		{
			object obj = GlobalInputPoller.ikn;
			lock (obj)
			{
				GlobalInputPoller.cso();
			}
		}

		// Token: 0x06001256 RID: 4694
		[DllImport("user32.dll", ExactSpelling = true)]
		[return: MarshalAs(UnmanagedType.I2)]
		private static extern short GetAsyncKeyState(int vKey);

		// Token: 0x0400097A RID: 2426
		private const int ikh = 1;

		// Token: 0x0400097B RID: 2427
		private const int iki = 2;

		// Token: 0x0400097C RID: 2428
		private const int ikj = 4;

		// Token: 0x0400097D RID: 2429
		private const int ikk = 5;

		// Token: 0x0400097E RID: 2430
		private const int ikl = 6;

		// Token: 0x0400097F RID: 2431
		private const int ikm = 16;

		// Token: 0x04000980 RID: 2432
		private static readonly object ikn = new object();

		// Token: 0x04000981 RID: 2433
		private static readonly ConcurrentQueue<int> iko = new ConcurrentQueue<int>();

		// Token: 0x04000982 RID: 2434
		private static readonly ConcurrentQueue<bool> ikp = new ConcurrentQueue<bool>();

		// Token: 0x04000983 RID: 2435
		private static readonly ConcurrentQueue<bool> ikq = new ConcurrentQueue<bool>();

		// Token: 0x04000984 RID: 2436
		private static readonly int[] ikr = new int[]
		{
			1, 2, 3, 4, 5, 6, 8, 9, 12, 13,
			19, 20, 21, 23, 24, 25, 27, 28, 29, 30,
			31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
			41, 43, 44, 45, 46, 47, 48, 49, 50, 51,
			52, 53, 54, 55, 56, 57, 65, 66, 67, 68,
			69, 70, 71, 72, 73, 74, 75, 76, 77, 78,
			79, 80, 81, 82, 83, 84, 85, 86, 87, 88,
			89, 90, 91, 92, 93, 95, 96, 97, 98, 99,
			100, 101, 102, 103, 104, 105, 106, 107, 108, 109,
			110, 111, 112, 113, 114, 115, 116, 117, 118, 119,
			120, 121, 122, 123, 124, 125, 126, 127, 128, 129,
			130, 131, 132, 133, 134, 135, 136, 137, 138, 139,
			140, 141, 142, 143, 144, 145, 146, 147, 148, 149,
			150, 160, 161, 162, 163, 164, 165, 166, 167, 168,
			169, 170, 171, 172, 173, 174, 175, 176, 177, 178,
			179, 180, 181, 182, 183, 186, 187, 188, 189, 190,
			191, 192, 195, 196, 197, 198, 199, 200, 201, 202,
			203, 204, 205, 206, 207, 208, 209, 210, 211, 212,
			213, 214, 215, 216, 217, 218, 219, 220, 221, 222,
			223, 225, 226, 227, 228, 229, 230, 231, 233, 234,
			235, 236, 237, 238, 239, 240, 241, 242, 243, 244,
			245, 246, 247, 248, 249, 250, 251, 252, 253, 254
		};

		// Token: 0x04000985 RID: 2437
		private static readonly bool[] iks = new bool[GlobalInputPoller.ikr.Length];

		// Token: 0x04000986 RID: 2438
		private static Timer ikt;

		// Token: 0x04000987 RID: 2439
		private static int iku;

		// Token: 0x04000988 RID: 2440
		private static int ikv;
	}
}
