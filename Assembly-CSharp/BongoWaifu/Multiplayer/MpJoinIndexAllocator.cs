using System;
using System.Collections.Generic;
using UnityEngine;

namespace BongoWaifu.Multiplayer
{
	// Token: 0x02000112 RID: 274
	public static class MpJoinIndexAllocator
	{
		// Token: 0x0600139E RID: 5022 RVA: 0x00060753 File Offset: 0x0005E953
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Reset()
		{
			MpJoinIndexAllocator.iql.Clear();
			MpJoinIndexAllocator.iqm.Clear();
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0006076C File Offset: 0x0005E96C
		public static int czv(NetworkPlayer a)
		{
			if (a == null)
			{
				return 0;
			}
			int num;
			if (MpJoinIndexAllocator.iql.TryGetValue(a, out num))
			{
				return num;
			}
			int num2 = 16;
			int num3 = 0;
			while (num3 < num2 && MpJoinIndexAllocator.iqm.Contains(num3))
			{
				num3++;
			}
			if (num3 >= num2)
			{
				num3 %= ((num2 > 0) ? num2 : fn.ktn);
			}
			MpJoinIndexAllocator.iql[a] = num3;
			MpJoinIndexAllocator.iqm.Add(num3);
			return num3;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x000607E0 File Offset: 0x0005E9E0
		public static void czw(NetworkPlayer a)
		{
			if (a == null)
			{
				return;
			}
			int num;
			if (!MpJoinIndexAllocator.iql.TryGetValue(a, out num))
			{
				return;
			}
			MpJoinIndexAllocator.iql.Remove(a);
			MpJoinIndexAllocator.iqm.Remove(num);
		}

		// Token: 0x04000A4F RID: 2639
		private static readonly Dictionary<NetworkPlayer, int> iql = new Dictionary<NetworkPlayer, int>();

		// Token: 0x04000A50 RID: 2640
		private static readonly HashSet<int> iqm = new HashSet<int>();
	}
}
