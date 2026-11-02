using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Managing.Transporting;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using Steamworks;
using UnityEngine;

namespace BongoWaifu.Multiplayer
{
	// Token: 0x0200012B RID: 299
	public sealed class NetworkPlayer : NetworkBehaviour
	{
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x000695C1 File Offset: 0x000677C1
		public ulong kup
		{
			get
			{
				return this._steamId.Value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x000695CE File Offset: 0x000677CE
		public string kuq
		{
			get
			{
				if (!string.IsNullOrEmpty(this._steamName.Value))
				{
					return this._steamName.Value;
				}
				return a.eex();
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x000695F3 File Offset: 0x000677F3
		public CharacterKind kur
		{
			get
			{
				return (CharacterKind)this._characterKind.Value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x00069600 File Offset: 0x00067800
		public string kus
		{
			get
			{
				return this._catId.Value ?? string.Empty;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x00069616 File Offset: 0x00067816
		public ClothingSet kut
		{
			get
			{
				return this._clothing.Value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x00069623 File Offset: 0x00067823
		public int kuu
		{
			get
			{
				return this._voiceProfile.Value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x00069630 File Offset: 0x00067830
		public int kuv
		{
			get
			{
				return this._animState.Value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x0006963D File Offset: 0x0006783D
		public int kuw
		{
			get
			{
				return this._hotLevel.Value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x0006964A File Offset: 0x0006784A
		public bool kux
		{
			get
			{
				return this._isPerforming.Value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x00069657 File Offset: 0x00067857
		public int kuy
		{
			get
			{
				return this._dirtiness.Value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x00069664 File Offset: 0x00067864
		public int kuz
		{
			get
			{
				return this._love.Value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x00069671 File Offset: 0x00067871
		public int kva
		{
			get
			{
				return this._joinIndex.Value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x0006967E File Offset: 0x0006787E
		public string kvb
		{
			get
			{
				return this._mpCustomText.Value ?? string.Empty;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x00069694 File Offset: 0x00067894
		public bool kvc
		{
			get
			{
				return this._pokeOthersDisabled.Value;
			}
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x000696A4 File Offset: 0x000678A4
		public override void OnStartClient()
		{
			base.OnStartClient();
			this._steamId.OnChange += this.dkf;
			this._steamName.OnChange += this.dkg;
			this._characterKind.OnChange += this.dkh;
			this._catId.OnChange += this.dki;
			this._clothing.OnChange += this.dkj;
			this._voiceProfile.OnChange += this.dkk;
			this._animState.OnChange += this.dkl;
			this._hotLevel.OnChange += this.dkm;
			this._dirtiness.OnChange += this.dkn;
			this._pokeOthersDisabled.OnChange += this.dko;
			fq.dbg(string.Format(a.eey(), new object[]
			{
				base.IsOwner,
				base.OwnerId,
				base.ObjectId,
				base.IsOwner ? a.efa() : a.eez()
			}));
			if (base.IsOwner)
			{
				MultiplayerSession.SetLocalPlayer(this);
				ulong num = NetworkPlayer.djf();
				string text = NetworkPlayer.djg();
				fq.dbg(string.Format(a.efb(), num, text, base.ObjectId));
				this.djj(num, text);
				if (num == 0UL)
				{
					SteamManager.ibn -= this.djh;
					SteamManager.ibn += this.djh;
					this.ivk = true;
					if (SteamManager.krd)
					{
						this.djh();
						return;
					}
				}
			}
			else
			{
				MultiplayerSession.RegisterRemote(this);
			}
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00069878 File Offset: 0x00067A78
		public override void OnStopClient()
		{
			base.OnStopClient();
			this._steamId.OnChange -= this.dkf;
			this._steamName.OnChange -= this.dkg;
			this._characterKind.OnChange -= this.dkh;
			this._catId.OnChange -= this.dki;
			this._clothing.OnChange -= this.dkj;
			this._voiceProfile.OnChange -= this.dkk;
			this._animState.OnChange -= this.dkl;
			this._hotLevel.OnChange -= this.dkm;
			this._dirtiness.OnChange -= this.dkn;
			this._pokeOthersDisabled.OnChange -= this.dko;
			this.dji();
			if (base.IsOwner)
			{
				MultiplayerSession.dii(this);
				return;
			}
			MultiplayerSession.dij(this);
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x0006998C File Offset: 0x00067B8C
		public override void OnStartServer()
		{
			base.OnStartServer();
			this._joinIndex.Value = MpJoinIndexAllocator.czv(this);
			fq.dbg(string.Format(a.efc(), base.ObjectId, this._joinIndex.Value));
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x000699DA File Offset: 0x00067BDA
		public override void OnStopServer()
		{
			base.OnStopServer();
			MpJoinIndexAllocator.czw(this);
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x000699E8 File Offset: 0x00067BE8
		private static ulong djf()
		{
			if (!SteamManager.krd)
			{
				return 0UL;
			}
			return SteamUser.GetSteamID().m_SteamID;
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x000699FE File Offset: 0x00067BFE
		internal static string djg()
		{
			if (!SteamManager.krd)
			{
				return a.eex();
			}
			return SteamFriends.GetPersonaName();
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00069A14 File Offset: 0x00067C14
		private void djh()
		{
			if (!this.ivk)
			{
				return;
			}
			if (!base.IsOwner || !base.IsSpawned)
			{
				this.dji();
				return;
			}
			ulong num = NetworkPlayer.djf();
			if (num == 0UL)
			{
				return;
			}
			string text = NetworkPlayer.djg();
			fq.dbg(string.Format(a.efd(), num, text, base.ObjectId));
			this.djj(num, text);
			this.dji();
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00069A80 File Offset: 0x00067C80
		private void dji()
		{
			if (!this.ivk)
			{
				return;
			}
			SteamManager.ibn -= this.djh;
			this.ivk = false;
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x00069AA4 File Offset: 0x00067CA4
		[ServerRpc]
		private void djj(ulong a, string b)
		{
			this.dkq(a, b);
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00069ABC File Offset: 0x00067CBC
		internal static ulong djk(NetworkConnection a)
		{
			if (a == null)
			{
				return 0UL;
			}
			if (a.IsLocalClient)
			{
				if (!SteamManager.krd)
				{
					return 0UL;
				}
				return SteamUser.GetSteamID().m_SteamID;
			}
			else
			{
				TransportManager transportManager = InstanceFinder.TransportManager;
				Transport transport = ((transportManager != null) ? transportManager.Transport : null);
				if (transport == null)
				{
					return 0UL;
				}
				ulong num;
				if (!ulong.TryParse(transport.GetConnectionAddress(a.ClientId), out num))
				{
					return 0UL;
				}
				return num;
			}
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00069B30 File Offset: 0x00067D30
		[ServerRpc]
		public void djl(int a, string b)
		{
			this.dkt(a, b);
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00069B48 File Offset: 0x00067D48
		[ServerRpc]
		public void djm(ClothingSet a)
		{
			this.dkw(a);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00069B5C File Offset: 0x00067D5C
		[ServerRpc]
		public void djn(int a)
		{
			this.dkz(a);
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00069B70 File Offset: 0x00067D70
		[ServerRpc]
		public void djo(int a, int b, bool c)
		{
			this.dlc(a, b, c);
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00069B88 File Offset: 0x00067D88
		[ServerRpc]
		public void djp(int a)
		{
			this.dlf(a);
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00069B9C File Offset: 0x00067D9C
		[ServerRpc]
		public void djq(int a)
		{
			this.dli(a);
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00069BB0 File Offset: 0x00067DB0
		[ServerRpc]
		public void djr(string a)
		{
			this.dll(a);
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00069BC4 File Offset: 0x00067DC4
		[ServerRpc]
		public void djs(bool a)
		{
			this.dlo(a);
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00069BD8 File Offset: 0x00067DD8
		public void djt()
		{
			if (!base.IsServerInitialized || base.Owner == null)
			{
				fq.dbg(a.efe());
				return;
			}
			if (base.Owner.IsLocalClient)
			{
				fq.dbg(a.eff());
				return;
			}
			fq.dbg(string.Format(a.efg(), this.kup, this.kuq));
			this.dju(base.Owner);
			base.Owner.Disconnect(false);
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00069C58 File Offset: 0x00067E58
		[TargetRpc]
		private void dju(NetworkConnection a)
		{
			this.dlr(a);
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00069C6C File Offset: 0x00067E6C
		public bool djv()
		{
			if (!base.IsServerInitialized || base.Owner == null)
			{
				fq.dbg(a.efh());
				return false;
			}
			if (base.Owner.IsLocalClient)
			{
				fq.dbg(a.efi());
				return false;
			}
			fq.dbg(string.Format(a.efj(), this.kup, this.kuq));
			this.djw(base.Owner);
			base.Owner.Disconnect(false);
			return true;
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00069CF0 File Offset: 0x00067EF0
		[TargetRpc]
		private void djw(NetworkConnection a)
		{
			this.dlu(a);
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00069D04 File Offset: 0x00067F04
		[ServerRpc(RequireOwnership = false)]
		public void djx(InteractionType a, Vector2 b, NetworkConnection c = null)
		{
			this.dlx(a, b, c);
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00069D1C File Offset: 0x00067F1C
		private static NetworkPlayer djy(NetworkConnection a)
		{
			if (a == null)
			{
				return null;
			}
			NetworkObject firstObject = a.FirstObject;
			if (!(firstObject != null))
			{
				return null;
			}
			return firstObject.GetComponent<NetworkPlayer>();
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00069D4C File Offset: 0x00067F4C
		private bool djz(NetworkConnection a)
		{
			float unscaledTime = Time.unscaledTime;
			if (unscaledTime - this.ivn < 0.08f)
			{
				return false;
			}
			int num = ((a != null) ? a.ClientId : (-1));
			float num2;
			if (this.ivo.TryGetValue(num, out num2) && unscaledTime - num2 < 0.15f)
			{
				return false;
			}
			this.ivn = unscaledTime;
			this.ivo[num] = unscaledTime;
			return true;
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00069DB4 File Offset: 0x00067FB4
		[ObserversRpc]
		private void dka(InteractionType a, NetworkPlayer b, Vector2 c)
		{
			this.dma(a, b, c);
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00069DCC File Offset: 0x00067FCC
		[ServerRpc]
		public void dkb(NetworkConnection a = null)
		{
			this.dmd(a);
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00069DE0 File Offset: 0x00067FE0
		[ObserversRpc]
		private void dkc()
		{
			this.dmg();
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00069DF4 File Offset: 0x00067FF4
		[ServerRpc]
		public void dkd(NetworkConnection a = null)
		{
			this.dmj(a);
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00069E08 File Offset: 0x00068008
		[ObserversRpc]
		private void dke()
		{
			this.dmm();
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x00069E1B File Offset: 0x0006801B
		private void dkf(ulong a, ulong b, bool c)
		{
			this.dkp();
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00069E1B File Offset: 0x0006801B
		private void dkg(string a, string b, bool c)
		{
			this.dkp();
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00069E24 File Offset: 0x00068024
		private void dkh(int a, int b, bool c)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.efk(), new object[] { a, b, base.IsOwner, c }));
			}
			this.dkp();
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00069E1B File Offset: 0x0006801B
		private void dki(string a, string b, bool c)
		{
			this.dkp();
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x00069E7C File Offset: 0x0006807C
		private void dkj(ClothingSet a, ClothingSet b, bool c)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.efl(), base.IsOwner, c, fq.dbi(b)));
			}
			this.dkp();
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x00069EB4 File Offset: 0x000680B4
		private void dkk(int a, int b, bool c)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.efm(), new object[] { a, b, base.IsOwner, c }));
			}
			this.dkp();
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x00069F0C File Offset: 0x0006810C
		private void dkl(int a, int b, bool c)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.efn(), new object[] { a, b, base.IsOwner, c }));
			}
			this.dkp();
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x00069E1B File Offset: 0x0006801B
		private void dkm(int a, int b, bool c)
		{
			this.dkp();
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x00069F64 File Offset: 0x00068164
		private void dkn(int a, int b, bool c)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.efo(), new object[] { a, b, base.IsOwner, c }));
			}
			this.dkp();
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x00069FBC File Offset: 0x000681BC
		private void dko(bool a, bool b, bool c)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.efp(), new object[] { a, b, base.IsOwner, c }));
			}
			MultiplayerSession.dhr();
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x0006A013 File Offset: 0x00068213
		private void dkp()
		{
			if (base.IsOwner)
			{
				return;
			}
			MultiplayerSession.dik(this);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x0006A168 File Offset: 0x00068368
		public override void NetworkInitialize___Early()
		{
			if (this.ivp)
			{
				return;
			}
			this.ivp = true;
			base.NetworkInitialize___Early();
			this._pokeOthersDisabled.InitializeEarly(this, 13U, false);
			this._mpCustomText.InitializeEarly(this, 12U, false);
			this._joinIndex.InitializeEarly(this, 11U, false);
			this._love.InitializeEarly(this, 10U, false);
			this._dirtiness.InitializeEarly(this, 9U, false);
			this._isPerforming.InitializeEarly(this, 8U, false);
			this._hotLevel.InitializeEarly(this, 7U, false);
			this._animState.InitializeEarly(this, 6U, false);
			this._voiceProfile.InitializeEarly(this, 5U, false);
			this._clothing.InitializeEarly(this, 4U, false);
			this._catId.InitializeEarly(this, 3U, false);
			this._characterKind.InitializeEarly(this, 2U, false);
			this._steamName.InitializeEarly(this, 1U, false);
			this._steamId.InitializeEarly(this, 0U, false);
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.dks));
			base.RegisterServerRpc(1U, new ServerRpcDelegate(this.dkv));
			base.RegisterServerRpc(2U, new ServerRpcDelegate(this.dky));
			base.RegisterServerRpc(3U, new ServerRpcDelegate(this.dlb));
			base.RegisterServerRpc(4U, new ServerRpcDelegate(this.dle));
			base.RegisterServerRpc(5U, new ServerRpcDelegate(this.dlh));
			base.RegisterServerRpc(6U, new ServerRpcDelegate(this.dlk));
			base.RegisterServerRpc(7U, new ServerRpcDelegate(this.dln));
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.dlq));
			base.RegisterTargetRpc(9U, new ClientRpcDelegate(this.dlt));
			base.RegisterTargetRpc(10U, new ClientRpcDelegate(this.dlw));
			base.RegisterServerRpc(11U, new ServerRpcDelegate(this.dlz));
			base.RegisterObserversRpc(12U, new ClientRpcDelegate(this.dmc));
			base.RegisterServerRpc(13U, new ServerRpcDelegate(this.dmf));
			base.RegisterObserversRpc(14U, new ClientRpcDelegate(this.dmi));
			base.RegisterServerRpc(15U, new ServerRpcDelegate(this.dml));
			base.RegisterObserversRpc(16U, new ClientRpcDelegate(this.dmo));
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x0006A3A0 File Offset: 0x000685A0
		public override void NetworkInitialize___Late()
		{
			if (this.ivq)
			{
				return;
			}
			this.ivq = true;
			base.NetworkInitialize___Late();
			this._pokeOthersDisabled.InitializeLate();
			this._mpCustomText.InitializeLate();
			this._joinIndex.InitializeLate();
			this._love.InitializeLate();
			this._dirtiness.InitializeLate();
			this._isPerforming.InitializeLate();
			this._hotLevel.InitializeLate();
			this._animState.InitializeLate();
			this._voiceProfile.InitializeLate();
			this._clothing.InitializeLate();
			this._catId.InitializeLate();
			this._characterKind.InitializeLate();
			this._steamName.InitializeLate();
			this._steamId.InitializeLate();
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x0006A45E File Offset: 0x0006865E
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize___Late();
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x0006A46C File Offset: 0x0006866C
		private void dkq(ulong a, string b)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				networkManager.LogWarning(a.efq());
				return;
			}
			if (!base.IsOwner)
			{
				NetworkManager networkManager2 = base.NetworkManager;
				networkManager2.LogWarning(a.efr());
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter pooledWriter = WriterPool.Retrieve();
			pooledWriter.WriteUInt64(a);
			pooledWriter.WriteString(b);
			base.SendServerRpc(0U, pooledWriter, channel, DataOrderType.Default);
			pooledWriter.Store();
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x0006A4D8 File Offset: 0x000686D8
		private void dkr(ulong a, string b)
		{
			ulong num = NetworkPlayer.djk(base.Owner);
			if (num != 0UL && num != a)
			{
				if (fq.iro)
				{
					fq.dbg(string.Format(a.efs(), a, num));
				}
				a = num;
			}
			this._steamId.Value = a;
			this._steamName.Value = b;
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x0006A538 File Offset: 0x00068738
		private void dks(PooledReader a, Channel b, NetworkConnection c)
		{
			ulong num = a.ReadUInt64();
			string text = a.ReadStringAllocated();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (!base.OwnerMatches(c))
			{
				return;
			}
			this.dkr(num, text);
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x0006A574 File Offset: 0x00068774
		private void dkt(int a, string b)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				networkManager.LogWarning(a.efq());
				return;
			}
			if (!base.IsOwner)
			{
				NetworkManager networkManager2 = base.NetworkManager;
				networkManager2.LogWarning(a.efr());
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter pooledWriter = WriterPool.Retrieve();
			pooledWriter.WriteInt32(a);
			pooledWriter.WriteString(b);
			base.SendServerRpc(1U, pooledWriter, channel, DataOrderType.Default);
			pooledWriter.Store();
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x0006A5E0 File Offset: 0x000687E0
		public void dku(int a, string b)
		{
			fq.dbg(string.Format(a.eft(), a, b));
			this._characterKind.Value = a;
			this._catId.Value = b ?? string.Empty;
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x0006A61C File Offset: 0x0006881C
		private void dkv(PooledReader a, Channel b, NetworkConnection c)
		{
			int num = a.ReadInt32();
			string text = a.ReadStringAllocated();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (!base.OwnerMatches(c))
			{
				return;
			}
			this.dku(num, text);
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x0006A658 File Offset: 0x00068858
		private void dkw(ClothingSet a)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				networkManager.LogWarning(a.efq());
				return;
			}
			if (!base.IsOwner)
			{
				NetworkManager networkManager2 = base.NetworkManager;
				networkManager2.LogWarning(a.efr());
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter pooledWriter = WriterPool.Retrieve();
			pooledWriter.gxs(a);
			base.SendServerRpc(2U, pooledWriter, channel, DataOrderType.Default);
			pooledWriter.Store();
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x0006A6BD File Offset: 0x000688BD
		public void dkx(ClothingSet a)
		{
			if (fq.iro)
			{
				fq.dbg(a.efu() + fq.dbi(a) + a.chz());
			}
			this._clothing.Value = a;
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x0006A6EC File Offset: 0x000688EC
		private void dky(PooledReader a, Channel b, NetworkConnection c)
		{
			ClothingSet clothingSet = global::FishNet.Serializing.Generated.GeneratedReaders___Internal.gxv(a);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (!base.OwnerMatches(c))
			{
				return;
			}
			this.dkx(clothingSet);
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x0006A720 File Offset: 0x00068920
		private void dkz(int a)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				networkManager.LogWarning(a.efq());
				return;
			}
			if (!base.IsOwner)
			{
				NetworkManager networkManager2 = base.NetworkManager;
				networkManager2.LogWarning(a.efr());
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter pooledWriter = WriterPool.Retrieve();
			pooledWriter.WriteInt32(a);
			base.SendServerRpc(3U, pooledWriter, channel, DataOrderType.Default);
			pooledWriter.Store();
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x0006A785 File Offset: 0x00068985
		public void dla(int a)
		{
			this._voiceProfile.Value = ((a < 0) ? 0 : a);
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x0006A79C File Offset: 0x0006899C
		private void dlb(PooledReader a, Channel b, NetworkConnection c)
		{
			int num = a.ReadInt32();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (!base.OwnerMatches(c))
			{
				return;
			}
			this.dla(num);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x0006A7D0 File Offset: 0x000689D0
		private void dlc(int a, int b, bool c)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				networkManager.LogWarning(a.efq());
				return;
			}
			if (!base.IsOwner)
			{
				NetworkManager networkManager2 = base.NetworkManager;
				networkManager2.LogWarning(a.efr());
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter pooledWriter = WriterPool.Retrieve();
			pooledWriter.WriteInt32(a);
			pooledWriter.WriteInt32(b);
			pooledWriter.WriteBoolean(c);
			base.SendServerRpc(4U, pooledWriter, channel, DataOrderType.Default);
			pooledWriter.Store();
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x0006A844 File Offset: 0x00068A44
		public void dld(int a, int b, bool c)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.efv(), a, b, c));
			}
			this._animState.Value = a;
			this._hotLevel.Value = b;
			this._isPerforming.Value = c;
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x0006A8A0 File Offset: 0x00068AA0
		private void dle(PooledReader a, Channel b, NetworkConnection c)
		{
			int num = a.ReadInt32();
			int num2 = a.ReadInt32();
			bool flag = a.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (!base.OwnerMatches(c))
			{
				return;
			}
			this.dld(num, num2, flag);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x0006A8E4 File Offset: 0x00068AE4
		private void dlf(int a)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				networkManager.LogWarning(a.efq());
				return;
			}
			if (!base.IsOwner)
			{
				NetworkManager networkManager2 = base.NetworkManager;
				networkManager2.LogWarning(a.efr());
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter pooledWriter = WriterPool.Retrieve();
			pooledWriter.WriteInt32(a);
			base.SendServerRpc(5U, pooledWriter, channel, DataOrderType.Default);
			pooledWriter.Store();
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x0006A949 File Offset: 0x00068B49
		public void dlg(int a)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.efw(), a));
			}
			this._dirtiness.Value = a;
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x0006A974 File Offset: 0x00068B74
		private void dlh(PooledReader a, Channel b, NetworkConnection c)
		{
			int num = a.ReadInt32();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (!base.OwnerMatches(c))
			{
				return;
			}
			this.dlg(num);
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0006A9A8 File Offset: 0x00068BA8
		private void dli(int a)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				networkManager.LogWarning(a.efq());
				return;
			}
			if (!base.IsOwner)
			{
				NetworkManager networkManager2 = base.NetworkManager;
				networkManager2.LogWarning(a.efr());
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter pooledWriter = WriterPool.Retrieve();
			pooledWriter.WriteInt32(a);
			base.SendServerRpc(6U, pooledWriter, channel, DataOrderType.Default);
			pooledWriter.Store();
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0006AA0D File Offset: 0x00068C0D
		public void dlj(int a)
		{
			this._love.Value = Mathf.Clamp(a, 0, 100);
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x0006AA24 File Offset: 0x00068C24
		private void dlk(PooledReader a, Channel b, NetworkConnection c)
		{
			int num = a.ReadInt32();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (!base.OwnerMatches(c))
			{
				return;
			}
			this.dlj(num);
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x0006AA58 File Offset: 0x00068C58
		private void dll(string a)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				networkManager.LogWarning(a.efq());
				return;
			}
			if (!base.IsOwner)
			{
				NetworkManager networkManager2 = base.NetworkManager;
				networkManager2.LogWarning(a.efr());
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter pooledWriter = WriterPool.Retrieve();
			pooledWriter.WriteString(a);
			base.SendServerRpc(7U, pooledWriter, channel, DataOrderType.Default);
			pooledWriter.Store();
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x0006AAC0 File Offset: 0x00068CC0
		public void dlm(string a)
		{
			string text = a ?? string.Empty;
			if (text.Length > 40)
			{
				text = text.Substring(0, 40);
			}
			this._mpCustomText.Value = text;
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x0006AAF8 File Offset: 0x00068CF8
		private void dln(PooledReader a, Channel b, NetworkConnection c)
		{
			string text = a.ReadStringAllocated();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (!base.OwnerMatches(c))
			{
				return;
			}
			this.dlm(text);
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x0006AB2C File Offset: 0x00068D2C
		private void dlo(bool a)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				networkManager.LogWarning(a.efq());
				return;
			}
			if (!base.IsOwner)
			{
				NetworkManager networkManager2 = base.NetworkManager;
				networkManager2.LogWarning(a.efr());
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter pooledWriter = WriterPool.Retrieve();
			pooledWriter.WriteBoolean(a);
			base.SendServerRpc(8U, pooledWriter, channel, DataOrderType.Default);
			pooledWriter.Store();
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x0006AB94 File Offset: 0x00068D94
		public void dlp(bool a)
		{
			if (base.Owner == null || !base.Owner.IsLocalClient)
			{
				fq.dbg(a.efx());
				return;
			}
			fq.dbg(string.Format(a.efy(), a));
			this._pokeOthersDisabled.Value = !a;
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x0006ABEC File Offset: 0x00068DEC
		private void dlq(PooledReader a, Channel b, NetworkConnection c)
		{
			bool flag = a.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (!base.OwnerMatches(c))
			{
				return;
			}
			this.dlp(flag);
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x0006AC20 File Offset: 0x00068E20
		private void dlr(NetworkConnection a)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				networkManager.LogWarning(a.efz());
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter pooledWriter = WriterPool.Retrieve();
			base.SendTargetRpc(9U, pooledWriter, channel, DataOrderType.Default, a, false, true);
			pooledWriter.Store();
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x0006AC66 File Offset: 0x00068E66
		private void dls(NetworkConnection a)
		{
			fq.dbg(a.ega());
			MultiplayerSession.dhu();
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x0006AC78 File Offset: 0x00068E78
		private void dlt(PooledReader a, Channel b)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.dls(base.LocalConnection);
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x0006AC9C File Offset: 0x00068E9C
		private void dlu(NetworkConnection a)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				networkManager.LogWarning(a.efz());
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter pooledWriter = WriterPool.Retrieve();
			base.SendTargetRpc(10U, pooledWriter, channel, DataOrderType.Default, a, false, true);
			pooledWriter.Store();
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x0006ACE4 File Offset: 0x00068EE4
		private void dlv(NetworkConnection a)
		{
			fq.dbg(a.egb());
			fv fv = fv.kts;
			if (fv != null && fv.ktv)
			{
				fv.ddm();
			}
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x0006AD18 File Offset: 0x00068F18
		private void dlw(PooledReader a, Channel b)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.dlv(base.LocalConnection);
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x0006AD3C File Offset: 0x00068F3C
		private void dlx(InteractionType a, Vector2 b, NetworkConnection c = null)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				networkManager.LogWarning(a.efq());
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter pooledWriter = WriterPool.Retrieve();
			pooledWriter.gxt(a);
			pooledWriter.WriteVector2(b);
			base.SendServerRpc(11U, pooledWriter, channel, DataOrderType.Default);
			pooledWriter.Store();
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x0006AD90 File Offset: 0x00068F90
		public void dly(InteractionType a, Vector2 b, NetworkConnection c)
		{
			if (!MultiplayerSession.kum)
			{
				fq.dbg(a.egc());
				return;
			}
			CharacterKind value = (CharacterKind)this._characterKind.Value;
			if (value != CharacterKind.Waifu && value != CharacterKind.Cat)
			{
				fq.dbg(string.Format(a.egd(), value));
				return;
			}
			if (value == CharacterKind.Waifu && this._isPerforming.Value)
			{
				fq.dbg(a.ege());
				return;
			}
			if (!this.djz(c))
			{
				return;
			}
			NetworkPlayer networkPlayer = NetworkPlayer.djy(c);
			fq.dbg(string.Format(a.egf(), new object[]
			{
				a,
				(c != null) ? c.ClientId : (-1),
				fq.dbh(networkPlayer),
				b
			}));
			this.dka(a, networkPlayer, b);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x0006AE58 File Offset: 0x00069058
		private void dlz(PooledReader a, Channel b, NetworkConnection c)
		{
			InteractionType interactionType = global::FishNet.Serializing.Generated.GeneratedReaders___Internal.gxw(a);
			Vector2 vector = a.ReadVector2();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.dly(interactionType, vector, c);
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x0006AE88 File Offset: 0x00069088
		private void dma(InteractionType a, NetworkPlayer b, Vector2 c)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				networkManager.LogWarning(a.efz());
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter pooledWriter = WriterPool.Retrieve();
			pooledWriter.gxt(a);
			pooledWriter.gxu(b);
			pooledWriter.WriteVector2(c);
			base.SendObserversRpc(12U, pooledWriter, channel, DataOrderType.Default, false, false, false);
			pooledWriter.Store();
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x0006AEE4 File Offset: 0x000690E4
		private void dmb(InteractionType a, NetworkPlayer b, Vector2 c)
		{
			fq.dbg(string.Format(a.egg(), new object[]
			{
				a,
				fq.dbh(b),
				c,
				base.IsOwner
			}));
			if (base.IsOwner)
			{
				MultiplayerSession.dil(a, b, c);
				return;
			}
			MultiplayerSession.dim(this, a, b, c);
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x0006AF4C File Offset: 0x0006914C
		private void dmc(PooledReader a, Channel b)
		{
			InteractionType interactionType = global::FishNet.Serializing.Generated.GeneratedReaders___Internal.gxw(a);
			NetworkPlayer networkPlayer = global::FishNet.Serializing.Generated.GeneratedReaders___Internal.gxx(a);
			Vector2 vector = a.ReadVector2();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.dmb(interactionType, networkPlayer, vector);
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x0006AF84 File Offset: 0x00069184
		private void dmd(NetworkConnection a = null)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				networkManager.LogWarning(a.efq());
				return;
			}
			if (!base.IsOwner)
			{
				NetworkManager networkManager2 = base.NetworkManager;
				networkManager2.LogWarning(a.efr());
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter pooledWriter = WriterPool.Retrieve();
			base.SendServerRpc(13U, pooledWriter, channel, DataOrderType.Default);
			pooledWriter.Store();
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x0006AFE3 File Offset: 0x000691E3
		public void dme(NetworkConnection a)
		{
			if (this._characterKind.Value != 0)
			{
				return;
			}
			if (this._isPerforming.Value)
			{
				return;
			}
			if (!this.djz(a))
			{
				return;
			}
			this.dkc();
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x0006B014 File Offset: 0x00069214
		private void dmf(PooledReader a, Channel b, NetworkConnection c)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (!base.OwnerMatches(c))
			{
				return;
			}
			this.dme(c);
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x0006B040 File Offset: 0x00069240
		private void dmg()
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				networkManager.LogWarning(a.efz());
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter pooledWriter = WriterPool.Retrieve();
			base.SendObserversRpc(14U, pooledWriter, channel, DataOrderType.Default, false, false, false);
			pooledWriter.Store();
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x0006B086 File Offset: 0x00069286
		private void dmh()
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.egh(), base.IsOwner));
			}
			if (base.IsOwner)
			{
				return;
			}
			MultiplayerSession.dim(this, InteractionType.Thrust, null, Vector2.zero);
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x0006B0C0 File Offset: 0x000692C0
		private void dmi(PooledReader a, Channel b)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.dmh();
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x0006B0E0 File Offset: 0x000692E0
		private void dmj(NetworkConnection a = null)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				networkManager.LogWarning(a.efq());
				return;
			}
			if (!base.IsOwner)
			{
				NetworkManager networkManager2 = base.NetworkManager;
				networkManager2.LogWarning(a.efr());
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter pooledWriter = WriterPool.Retrieve();
			base.SendServerRpc(15U, pooledWriter, channel, DataOrderType.Default);
			pooledWriter.Store();
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x0006B13F File Offset: 0x0006933F
		public void dmk(NetworkConnection a)
		{
			if (this._characterKind.Value != 1)
			{
				return;
			}
			if (!this.djz(a))
			{
				return;
			}
			this.dke();
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x0006B160 File Offset: 0x00069360
		private void dml(PooledReader a, Channel b, NetworkConnection c)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (!base.OwnerMatches(c))
			{
				return;
			}
			this.dmk(c);
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x0006B18C File Offset: 0x0006938C
		private void dmm()
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				networkManager.LogWarning(a.efz());
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter pooledWriter = WriterPool.Retrieve();
			base.SendObserversRpc(16U, pooledWriter, channel, DataOrderType.Default, false, false, false);
			pooledWriter.Store();
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x0006B1D2 File Offset: 0x000693D2
		private void dmn()
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.egi(), base.IsOwner));
			}
			if (base.IsOwner)
			{
				return;
			}
			MultiplayerSession.din(this);
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x0006B204 File Offset: 0x00069404
		private void dmo(PooledReader a, Channel b)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.dmn();
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x0006A45E File Offset: 0x0006865E
		public void Awake()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize___Late();
		}

		// Token: 0x04000B03 RID: 2819
		public readonly SyncVar<ulong> _steamId = new SyncVar<ulong>(default(SyncTypeSettings));

		// Token: 0x04000B04 RID: 2820
		public readonly SyncVar<string> _steamName = new SyncVar<string>(default(SyncTypeSettings));

		// Token: 0x04000B05 RID: 2821
		public readonly SyncVar<int> _characterKind = new SyncVar<int>(default(SyncTypeSettings));

		// Token: 0x04000B06 RID: 2822
		public readonly SyncVar<string> _catId = new SyncVar<string>(default(SyncTypeSettings));

		// Token: 0x04000B07 RID: 2823
		public readonly SyncVar<ClothingSet> _clothing = new SyncVar<ClothingSet>(default(SyncTypeSettings));

		// Token: 0x04000B08 RID: 2824
		public readonly SyncVar<int> _voiceProfile = new SyncVar<int>(default(SyncTypeSettings));

		// Token: 0x04000B09 RID: 2825
		public readonly SyncVar<int> _animState = new SyncVar<int>(default(SyncTypeSettings));

		// Token: 0x04000B0A RID: 2826
		public readonly SyncVar<int> _hotLevel = new SyncVar<int>(default(SyncTypeSettings));

		// Token: 0x04000B0B RID: 2827
		public readonly SyncVar<bool> _isPerforming = new SyncVar<bool>(default(SyncTypeSettings));

		// Token: 0x04000B0C RID: 2828
		public readonly SyncVar<int> _dirtiness = new SyncVar<int>(default(SyncTypeSettings));

		// Token: 0x04000B0D RID: 2829
		public readonly SyncVar<int> _love = new SyncVar<int>(default(SyncTypeSettings));

		// Token: 0x04000B0E RID: 2830
		public readonly SyncVar<int> _joinIndex = new SyncVar<int>(default(SyncTypeSettings));

		// Token: 0x04000B0F RID: 2831
		public const int MpCustomTextMaxLength = 40;

		// Token: 0x04000B10 RID: 2832
		public readonly SyncVar<string> _mpCustomText = new SyncVar<string>(default(SyncTypeSettings));

		// Token: 0x04000B11 RID: 2833
		public readonly SyncVar<bool> _pokeOthersDisabled = new SyncVar<bool>(default(SyncTypeSettings));

		// Token: 0x04000B12 RID: 2834
		private bool ivk;

		// Token: 0x04000B13 RID: 2835
		private const float ivl = 0.08f;

		// Token: 0x04000B14 RID: 2836
		private const float ivm = 0.15f;

		// Token: 0x04000B15 RID: 2837
		private float ivn = -999f;

		// Token: 0x04000B16 RID: 2838
		private readonly Dictionary<int, float> ivo = new Dictionary<int, float>();

		// Token: 0x04000B17 RID: 2839
		private bool ivp;

		// Token: 0x04000B18 RID: 2840
		private bool ivq;
	}
}
