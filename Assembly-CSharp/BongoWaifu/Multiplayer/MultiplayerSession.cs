using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

namespace BongoWaifu.Multiplayer
{
	// Token: 0x02000127 RID: 295
	public static class MultiplayerSession
	{
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x000689B3 File Offset: 0x00066BB3
		// (set) Token: 0x06001543 RID: 5443 RVA: 0x000689BA File Offset: 0x00066BBA
		public static bool iuw { get; private set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x000689C2 File Offset: 0x00066BC2
		// (set) Token: 0x06001545 RID: 5445 RVA: 0x000689C9 File Offset: 0x00066BC9
		public static NetworkPlayer iux { get; private set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x000689D1 File Offset: 0x00066BD1
		public static IReadOnlyList<gb> kuk
		{
			get
			{
				return MultiplayerSession.iuy;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x000689D8 File Offset: 0x00066BD8
		public static Color kul
		{
			get
			{
				if (!(MultiplayerSession.iux != null))
				{
					return Color.white;
				}
				return fn.daa(MultiplayerSession.iux.kva);
			}
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06001548 RID: 5448 RVA: 0x000689FC File Offset: 0x00066BFC
		// (remove) Token: 0x06001549 RID: 5449 RVA: 0x00068A30 File Offset: 0x00066C30
		public static event Action iva;

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x0600154A RID: 5450 RVA: 0x00068A64 File Offset: 0x00066C64
		// (remove) Token: 0x0600154B RID: 5451 RVA: 0x00068A98 File Offset: 0x00066C98
		public static event Action ivb;

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x0600154C RID: 5452 RVA: 0x00068ACC File Offset: 0x00066CCC
		// (remove) Token: 0x0600154D RID: 5453 RVA: 0x00068B00 File Offset: 0x00066D00
		public static event Action<gb> ivc;

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x0600154E RID: 5454 RVA: 0x00068B34 File Offset: 0x00066D34
		// (remove) Token: 0x0600154F RID: 5455 RVA: 0x00068B68 File Offset: 0x00066D68
		public static event Action<gb> ivd;

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x06001550 RID: 5456 RVA: 0x00068B9C File Offset: 0x00066D9C
		// (remove) Token: 0x06001551 RID: 5457 RVA: 0x00068BD0 File Offset: 0x00066DD0
		public static event Action<gb> ive;

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x06001552 RID: 5458 RVA: 0x00068C04 File Offset: 0x00066E04
		// (remove) Token: 0x06001553 RID: 5459 RVA: 0x00068C38 File Offset: 0x00066E38
		public static event Action<InteractionType, NetworkPlayer, Vector2> ivf;

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x06001554 RID: 5460 RVA: 0x00068C6C File Offset: 0x00066E6C
		// (remove) Token: 0x06001555 RID: 5461 RVA: 0x00068CA0 File Offset: 0x00066EA0
		public static event Action<gb, InteractionType, NetworkPlayer, Vector2> ivg;

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06001556 RID: 5462 RVA: 0x00068CD4 File Offset: 0x00066ED4
		// (remove) Token: 0x06001557 RID: 5463 RVA: 0x00068D08 File Offset: 0x00066F08
		public static event Action<gb> ivh;

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06001558 RID: 5464 RVA: 0x00068D3C File Offset: 0x00066F3C
		// (remove) Token: 0x06001559 RID: 5465 RVA: 0x00068D70 File Offset: 0x00066F70
		public static event Action ivi;

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x00068DA4 File Offset: 0x00066FA4
		public static bool kum
		{
			get
			{
				NetworkPlayer networkPlayer = MultiplayerSession.dho();
				return networkPlayer == null || !networkPlayer.kvc;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600155B RID: 5467 RVA: 0x00068DCC File Offset: 0x00066FCC
		public static bool kun
		{
			get
			{
				fv fv = fv.kts;
				if (fv == null || fv.ddn().m_SteamID == 0UL)
				{
					return false;
				}
				NetworkPlayer networkPlayer = MultiplayerSession.dho();
				return networkPlayer != null && !networkPlayer.kvc;
			}
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00068E14 File Offset: 0x00067014
		private static NetworkPlayer dho()
		{
			fv fv = fv.kts;
			if (fv == null)
			{
				return MultiplayerSession.iux;
			}
			ulong steamID = fv.ddn().m_SteamID;
			if (steamID == 0UL)
			{
				return MultiplayerSession.iux;
			}
			if (MultiplayerSession.iux != null && MultiplayerSession.iux.kup == steamID)
			{
				return MultiplayerSession.iux;
			}
			for (int i = 0; i < MultiplayerSession.iuy.Count; i++)
			{
				if (MultiplayerSession.iuy[i].iup != null && MultiplayerSession.iuy[i].iup.kup == steamID)
				{
					return MultiplayerSession.iuy[i].iup;
				}
			}
			return null;
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600155D RID: 5469 RVA: 0x00068EC4 File Offset: 0x000670C4
		public static bool kuo
		{
			get
			{
				fv fv = fv.kts;
				return fv != null && fv.ktw;
			}
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00068EE8 File Offset: 0x000670E8
		public static void dhq(bool a)
		{
			fq.dbg(string.Format(a.een(), fq.dbh(MultiplayerSession.iux), a));
			NetworkPlayer networkPlayer = MultiplayerSession.iux;
			if (networkPlayer == null)
			{
				return;
			}
			networkPlayer.djs(a);
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00068F19 File Offset: 0x00067119
		internal static void dhr()
		{
			Action action = MultiplayerSession.ivi;
			if (action == null)
			{
				return;
			}
			action();
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x00068F2A File Offset: 0x0006712A
		// (set) Token: 0x06001561 RID: 5473 RVA: 0x00068F31 File Offset: 0x00067131
		public static bool ivj { get; private set; }

		// Token: 0x06001562 RID: 5474 RVA: 0x00068F39 File Offset: 0x00067139
		internal static void dhu()
		{
			MultiplayerSession.ivj = true;
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00068F41 File Offset: 0x00067141
		public static void dhv()
		{
			MultiplayerSession.ivj = false;
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00068F4C File Offset: 0x0006714C
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
			MultiplayerSession.iuw = false;
			MultiplayerSession.iux = null;
			MultiplayerSession.iuy.Clear();
			MultiplayerSession.iuz.Clear();
			MultiplayerSession.iva = null;
			MultiplayerSession.ivb = null;
			MultiplayerSession.ivc = null;
			MultiplayerSession.ivd = null;
			MultiplayerSession.ive = null;
			MultiplayerSession.ivf = null;
			MultiplayerSession.ivg = null;
			MultiplayerSession.ivh = null;
			MultiplayerSession.ivi = null;
			MultiplayerSession.ivj = false;
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x00068FB8 File Offset: 0x000671B8
		public static void dhw(ClothingSet a)
		{
			fq.dbg(string.Concat(new string[]
			{
				a.eeo(),
				fq.dbh(MultiplayerSession.iux),
				a.eep(),
				fq.dbi(a),
				a.eeq(),
				fq.dbj(),
				a.chz()
			}));
			NetworkPlayer networkPlayer = MultiplayerSession.iux;
			if (networkPlayer == null)
			{
				return;
			}
			networkPlayer.djm(a);
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00069023 File Offset: 0x00067223
		public static void dhx(CharacterKind a, string b)
		{
			fq.dbg(string.Format(a.eer(), fq.dbh(MultiplayerSession.iux), a, b));
			NetworkPlayer networkPlayer = MultiplayerSession.iux;
			if (networkPlayer == null)
			{
				return;
			}
			networkPlayer.djl((int)a, b ?? string.Empty);
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x0006905F File Offset: 0x0006725F
		public static void dhy(int a, int b, bool c)
		{
			NetworkPlayer networkPlayer = MultiplayerSession.iux;
			if (networkPlayer == null)
			{
				return;
			}
			networkPlayer.djo(a, b, c);
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00069073 File Offset: 0x00067273
		public static void dhz()
		{
			NetworkPlayer networkPlayer = MultiplayerSession.iux;
			if (networkPlayer == null)
			{
				return;
			}
			networkPlayer.dkb(null);
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00069085 File Offset: 0x00067285
		public static void dia()
		{
			NetworkPlayer networkPlayer = MultiplayerSession.iux;
			if (networkPlayer == null)
			{
				return;
			}
			networkPlayer.dkd(null);
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00069097 File Offset: 0x00067297
		public static void dib(int a)
		{
			NetworkPlayer networkPlayer = MultiplayerSession.iux;
			if (networkPlayer == null)
			{
				return;
			}
			networkPlayer.djp(a);
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x000690A9 File Offset: 0x000672A9
		public static void dic(int a)
		{
			NetworkPlayer networkPlayer = MultiplayerSession.iux;
			if (networkPlayer == null)
			{
				return;
			}
			networkPlayer.djq(a);
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x000690BB File Offset: 0x000672BB
		public static void did(string a)
		{
			NetworkPlayer networkPlayer = MultiplayerSession.iux;
			if (networkPlayer == null)
			{
				return;
			}
			networkPlayer.djr(a);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x000690CD File Offset: 0x000672CD
		public static void die(int a)
		{
			NetworkPlayer networkPlayer = MultiplayerSession.iux;
			if (networkPlayer == null)
			{
				return;
			}
			networkPlayer.djn(a);
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x000690DF File Offset: 0x000672DF
		public static void dif(gb a, InteractionType b, Vector2 c)
		{
			if (a != null)
			{
				NetworkPlayer iup = a.iup;
				if (iup == null)
				{
					return;
				}
				iup.djx(b, c, null);
			}
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x000690F7 File Offset: 0x000672F7
		public static void dig(gb a)
		{
			if (a != null)
			{
				NetworkPlayer iup = a.iup;
				if (iup == null)
				{
					return;
				}
				iup.djt();
			}
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x0006910C File Offset: 0x0006730C
		internal static void dih(bool a)
		{
			if (MultiplayerSession.iuw == a)
			{
				return;
			}
			MultiplayerSession.iuw = a;
			fq.dbg(string.Format(a.ees(), a, MultiplayerSession.iuy.Count));
			if (!a)
			{
				if (MultiplayerSession.iuy.Count > 0)
				{
					gb[] array = MultiplayerSession.iuy.ToArray();
					MultiplayerSession.iuy.Clear();
					MultiplayerSession.iuz.Clear();
					for (int i = 0; i < array.Length; i++)
					{
						fq.dbg(a.eet() + array[i].ium);
						Action<gb> action = MultiplayerSession.ivd;
						if (action != null)
						{
							action(array[i]);
						}
					}
				}
				MultiplayerSession.iuz.Clear();
				MultiplayerSession.iux = null;
			}
			Action action2 = MultiplayerSession.iva;
			if (action2 == null)
			{
				return;
			}
			action2();
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x000691D5 File Offset: 0x000673D5
		internal static void SetLocalPlayer(NetworkPlayer player)
		{
			if (MultiplayerSession.iux == player)
			{
				return;
			}
			MultiplayerSession.iux = player;
			if (player != null)
			{
				Action action = MultiplayerSession.ivb;
				if (action == null)
				{
					return;
				}
				action();
			}
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00069203 File Offset: 0x00067403
		internal static void dii(NetworkPlayer a)
		{
			if (MultiplayerSession.iux == a)
			{
				MultiplayerSession.iux = null;
			}
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00069218 File Offset: 0x00067418
		internal static gb RegisterRemote(NetworkPlayer player)
		{
			if (player == null)
			{
				return null;
			}
			gb gb;
			if (MultiplayerSession.iuz.TryGetValue(player, out gb))
			{
				return gb;
			}
			gb gb2 = new gb
			{
				iul = player.kup,
				ium = player.kuq,
				iun = player.kur,
				iuo = player.kus,
				iup = player,
				iuv = fn.daa(player.kva)
			};
			MultiplayerSession.iuy.Add(gb2);
			MultiplayerSession.iuz[player] = gb2;
			fq.dbg(string.Format(a.eeu(), new object[]
			{
				gb2.iul,
				gb2.ium,
				gb2.iun,
				MultiplayerSession.iuy.Count
			}));
			Action<gb> action = MultiplayerSession.ivc;
			if (action != null)
			{
				action(gb2);
			}
			return gb2;
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00069304 File Offset: 0x00067504
		internal static void dij(NetworkPlayer a)
		{
			if (a == null)
			{
				return;
			}
			gb gb;
			if (!MultiplayerSession.iuz.TryGetValue(a, out gb))
			{
				return;
			}
			MultiplayerSession.iuz.Remove(a);
			MultiplayerSession.iuy.Remove(gb);
			if (fq.iro)
			{
				fq.dbg(string.Format(a.eev(), gb.ium, MultiplayerSession.iuy.Count));
			}
			Action<gb> action = MultiplayerSession.ivd;
			if (action == null)
			{
				return;
			}
			action(gb);
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00069380 File Offset: 0x00067580
		internal static void dik(NetworkPlayer a)
		{
			if (a == null)
			{
				return;
			}
			gb gb;
			if (!MultiplayerSession.iuz.TryGetValue(a, out gb))
			{
				return;
			}
			gb.iul = a.kup;
			gb.ium = a.kuq;
			gb.iun = a.kur;
			gb.iuo = a.kus;
			gb.iuv = fn.daa(a.kva);
			if (fq.iro)
			{
				fq.dbg(string.Format(a.eew(), gb.ium, gb.iun, gb.iuo));
			}
			Action<gb> action = MultiplayerSession.ive;
			if (action == null)
			{
				return;
			}
			action(gb);
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00069425 File Offset: 0x00067625
		internal static void dil(InteractionType a, NetworkPlayer b, Vector2 c)
		{
			Action<InteractionType, NetworkPlayer, Vector2> action = MultiplayerSession.ivf;
			if (action == null)
			{
				return;
			}
			action(a, b, c);
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x0006943C File Offset: 0x0006763C
		internal static void dim(NetworkPlayer a, InteractionType b, NetworkPlayer c, Vector2 d)
		{
			if (a == null)
			{
				return;
			}
			gb gb;
			if (!MultiplayerSession.iuz.TryGetValue(a, out gb))
			{
				return;
			}
			Action<gb, InteractionType, NetworkPlayer, Vector2> action = MultiplayerSession.ivg;
			if (action == null)
			{
				return;
			}
			action(gb, b, c, d);
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00069478 File Offset: 0x00067678
		internal static void din(NetworkPlayer a)
		{
			if (a == null)
			{
				return;
			}
			gb gb;
			if (!MultiplayerSession.iuz.TryGetValue(a, out gb))
			{
				return;
			}
			Action<gb> action = MultiplayerSession.ivh;
			if (action == null)
			{
				return;
			}
			action(gb);
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x000694AF File Offset: 0x000676AF
		internal static bool dio(NetworkPlayer a, out gb b)
		{
			return MultiplayerSession.iuz.TryGetValue(a, out b);
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x000694C0 File Offset: 0x000676C0
		public static bool dip(ulong a, out gb b)
		{
			for (int i = 0; i < MultiplayerSession.iuy.Count; i++)
			{
				if (MultiplayerSession.iuy[i].iul == a)
				{
					b = MultiplayerSession.iuy[i];
					return true;
				}
			}
			b = null;
			return false;
		}

		// Token: 0x04000AE7 RID: 2791
		private static readonly List<gb> iuy = new List<gb>();

		// Token: 0x04000AE8 RID: 2792
		private static readonly Dictionary<NetworkPlayer, gb> iuz = new Dictionary<NetworkPlayer, gb>();
	}
}
