using System;
using System.Runtime.InteropServices;
using BongoWaifu.Multiplayer;
using UnityEngine;

namespace FishNet.Serializing.Generated
{
	// Token: 0x02000278 RID: 632
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
	public static class GeneratedWriters___Internal
	{
		// Token: 0x060026CF RID: 9935 RVA: 0x000A3920 File Offset: 0x000A1B20
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeOnce()
		{
			GenericWriter<ClothingSet>.SetWrite(new Action<Writer, ClothingSet>(GeneratedWriters___Internal.gxs));
			GenericWriter<InteractionType>.SetWrite(new Action<Writer, InteractionType>(GeneratedWriters___Internal.gxt));
			GenericWriter<NetworkPlayer>.SetWrite(new Action<Writer, NetworkPlayer>(GeneratedWriters___Internal.gxu));
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x000A3958 File Offset: 0x000A1B58
		public static void gxs(this Writer a, ClothingSet b)
		{
			a.WriteInt32(b.dick);
			a.WriteInt32(b.hair);
			a.WriteInt32(b.top);
			a.WriteInt32(b.bottom);
			a.WriteInt32(b.underwear);
			a.WriteInt32(b.socks);
			a.WriteInt32(b.shoes);
			a.WriteInt32(b.skinTone);
			a.WriteInt32(b.intimate);
			a.WriteInt32(b.pubic);
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x000A39E0 File Offset: 0x000A1BE0
		public static void gxt(this Writer a, InteractionType b)
		{
			a.WriteUInt8Unpacked((byte)b);
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x000A39F4 File Offset: 0x000A1BF4
		public static void gxu(this Writer a, NetworkPlayer b)
		{
			a.WriteNetworkBehaviour(b);
		}
	}
}
