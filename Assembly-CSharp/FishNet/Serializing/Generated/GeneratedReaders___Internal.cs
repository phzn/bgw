using System;
using System.Runtime.InteropServices;
using BongoWaifu.Multiplayer;
using UnityEngine;

namespace FishNet.Serializing.Generated
{
	// Token: 0x02000279 RID: 633
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
	public static class GeneratedReaders___Internal
	{
		// Token: 0x060026D3 RID: 9939 RVA: 0x000A3A08 File Offset: 0x000A1C08
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeOnce()
		{
			GenericReader<ClothingSet>.SetRead(new Func<Reader, ClothingSet>(GeneratedReaders___Internal.gxv));
			GenericReader<InteractionType>.SetRead(new Func<Reader, InteractionType>(GeneratedReaders___Internal.gxw));
			GenericReader<NetworkPlayer>.SetRead(new Func<Reader, NetworkPlayer>(GeneratedReaders___Internal.gxx));
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x000A3A40 File Offset: 0x000A1C40
		public static ClothingSet gxv(Reader a)
		{
			return new ClothingSet
			{
				dick = a.ReadInt32(),
				hair = a.ReadInt32(),
				top = a.ReadInt32(),
				bottom = a.ReadInt32(),
				underwear = a.ReadInt32(),
				socks = a.ReadInt32(),
				shoes = a.ReadInt32(),
				skinTone = a.ReadInt32(),
				intimate = a.ReadInt32(),
				pubic = a.ReadInt32()
			};
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x000A3AD8 File Offset: 0x000A1CD8
		public static InteractionType gxw(Reader a)
		{
			return (InteractionType)a.ReadUInt8Unpacked();
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x000A3AEC File Offset: 0x000A1CEC
		public static NetworkPlayer gxx(Reader a)
		{
			return (NetworkPlayer)a.ReadNetworkBehaviour();
		}
	}
}
