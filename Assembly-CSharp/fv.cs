using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using BongoWaifu.Multiplayer;
using Steamworks;
using UnityEngine;

// Token: 0x0200011F RID: 287
public sealed class fv : MonoBehaviour
{
	// Token: 0x0600146F RID: 5231 RVA: 0x00065242 File Offset: 0x00063442
	private void ddv(CSteamID a)
	{
		SteamFriends.SetRichPresence(a.dzh(), a.dzi() + a.m_SteamID.ToString());
	}

	// Token: 0x06001470 RID: 5232 RVA: 0x00065268 File Offset: 0x00063468
	private void kd()
	{
		CallResult<LobbyCreated_t> callResult = this.ita;
		if (callResult != null)
		{
			callResult.Dispose();
		}
		this.ita = null;
		Callback<LobbyEnter_t> callback = this.itb;
		if (callback != null)
		{
			callback.Unregister();
		}
		Callback<LobbyDataUpdate_t> callback2 = this.itc;
		if (callback2 != null)
		{
			callback2.Unregister();
		}
		Callback<LobbyChatUpdate_t> callback3 = this.itd;
		if (callback3 != null)
		{
			callback3.Unregister();
		}
		Callback<GameLobbyJoinRequested_t> callback4 = this.ite;
		if (callback4 != null)
		{
			callback4.Unregister();
		}
		this.itb = null;
		this.itc = null;
		this.itd = null;
		this.ite = null;
		this.ist = false;
	}

	// Token: 0x14000036 RID: 54
	// (add) Token: 0x06001471 RID: 5233 RVA: 0x000652F4 File Offset: 0x000634F4
	// (remove) Token: 0x060014B9 RID: 5305 RVA: 0x00066728 File Offset: 0x00064928
	public event Action<string> isr;

	// Token: 0x06001472 RID: 5234 RVA: 0x0006532C File Offset: 0x0006352C
	public void gvo()
	{
		this.isz = false;
		this.isy = 0UL;
		if (!this.ktv)
		{
			return;
		}
		CSteamID csteamID = this.ktu;
		if (SteamManager.krd && !SteamManager.ibh)
		{
			this.ddw();
			SteamMatchmaking.LeaveLobby(csteamID);
		}
		this.isu = 0UL;
		this.isv = false;
		Action action = this.iso;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06001473 RID: 5235 RVA: 0x00065394 File Offset: 0x00063594
	private void cxt()
	{
		if (this.ist)
		{
			return;
		}
		if (!SteamManager.krd)
		{
			return;
		}
		this.ist = true;
		this.ita = CallResult<LobbyCreated_t>.Create(new CallResult<LobbyCreated_t>.APIDispatchDelegate(this.ddq));
		this.itb = Callback<LobbyEnter_t>.Create(new Callback<LobbyEnter_t>.DispatchDelegate(this.ddr));
		this.itc = Callback<LobbyDataUpdate_t>.Create(new Callback<LobbyDataUpdate_t>.DispatchDelegate(this.dds));
		this.itd = Callback<LobbyChatUpdate_t>.Create(new Callback<LobbyChatUpdate_t>.DispatchDelegate(this.ddt));
		this.ite = Callback<GameLobbyJoinRequested_t>.Create(new Callback<GameLobbyJoinRequested_t>.DispatchDelegate(this.ddu));
	}

	// Token: 0x06001474 RID: 5236 RVA: 0x0006542C File Offset: 0x0006362C
	public List<CSteamID> ddp()
	{
		List<CSteamID> list = new List<CSteamID>();
		if (!this.ktv)
		{
			return list;
		}
		int numLobbyMembers = SteamMatchmaking.GetNumLobbyMembers(this.ktu);
		for (int i = 0; i < numLobbyMembers; i++)
		{
			list.Add(SteamMatchmaking.GetLobbyMemberByIndex(this.ktu, i));
		}
		return list;
	}

	// Token: 0x06001475 RID: 5237 RVA: 0x00065474 File Offset: 0x00063674
	private void cqu()
	{
		this.isw = 7593.0;
	}

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x06001476 RID: 5238 RVA: 0x00065485 File Offset: 0x00063685
	private bool ktt
	{
		get
		{
			return Time.realtimeSinceStartupAsDouble < this.isw;
		}
	}

	// Token: 0x06001477 RID: 5239 RVA: 0x00065494 File Offset: 0x00063694
	private void vl()
	{
		SteamManager.ibn += this.ddh;
		if (SteamManager.krd)
		{
			this.ddi();
		}
	}

	// Token: 0x06001478 RID: 5240 RVA: 0x000654B4 File Offset: 0x000636B4
	private void efm()
	{
		SteamFriends.SetRichPresence(a.dzj(), string.Empty);
	}

	// Token: 0x14000035 RID: 53
	// (add) Token: 0x06001479 RID: 5241 RVA: 0x000654C8 File Offset: 0x000636C8
	// (remove) Token: 0x0600148B RID: 5259 RVA: 0x00065A58 File Offset: 0x00063C58
	public event Action isq;

	// Token: 0x14000034 RID: 52
	// (add) Token: 0x060014AD RID: 5293 RVA: 0x000663A8 File Offset: 0x000645A8
	// (remove) Token: 0x0600147A RID: 5242 RVA: 0x00065500 File Offset: 0x00063700
	public event Action<CSteamID> isp;

	// Token: 0x0600147B RID: 5243 RVA: 0x00065538 File Offset: 0x00063738
	private void kin(LobbyCreated_t a, bool b)
	{
		if (b || a.m_eResult != EResult.k_EResultOK)
		{
			this.ddd();
			this.isz = false;
			Action<string> action = this.isr;
			if (action == null)
			{
				return;
			}
			action(string.Format(MultiplayerLoc.Get(a.dzk(), a.dzl()), b ? a.dzm() : a.m_eResult.ToString()));
			return;
		}
		else
		{
			CSteamID csteamID = new CSteamID(a.m_ulSteamIDLobby);
			if (this.ktv && this.ktu != csteamID)
			{
				fq.dbg(string.Format(a.dzn(), this.isu, csteamID.m_SteamID));
				SteamMatchmaking.LeaveLobby(csteamID);
				this.ddd();
				return;
			}
			if (!this.isz)
			{
				fq.dbg(string.Format(a.dzo(), csteamID.m_SteamID));
				SteamMatchmaking.LeaveLobby(csteamID);
				return;
			}
			this.isz = false;
			this.isy = csteamID.m_SteamID;
			CSteamID steamID = SteamUser.GetSteamID();
			SteamMatchmaking.SetLobbyData(csteamID, a.dzp(), steamID.m_SteamID.ToString());
			SteamMatchmaking.SetLobbyData(csteamID, a.dzq(), Application.version);
			this.ddv(csteamID);
			this.isv = true;
			Action<CSteamID> action2 = this.ism;
			if (action2 == null)
			{
				return;
			}
			action2(csteamID);
			return;
		}
	}

	// Token: 0x14000037 RID: 55
	// (add) Token: 0x0600147C RID: 5244 RVA: 0x00065680 File Offset: 0x00063880
	// (remove) Token: 0x06001487 RID: 5255 RVA: 0x00065A10 File Offset: 0x00063C10
	public event Action<CSteamID> iss;

	// Token: 0x0600147D RID: 5245 RVA: 0x000656B8 File Offset: 0x000638B8
	public void jjg()
	{
		this.isz = false;
		this.isy = 0UL;
		if (!this.ktv)
		{
			return;
		}
		CSteamID csteamID = this.ktu;
		if (SteamManager.krd && !SteamManager.ibh)
		{
			this.ddw();
			SteamMatchmaking.LeaveLobby(csteamID);
		}
		this.isu = 0UL;
		this.isv = false;
		Action action = this.iso;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x0600147E RID: 5246 RVA: 0x0006571D File Offset: 0x0006391D
	public static fv kts
	{
		get
		{
			return fv.isl;
		}
	}

	// Token: 0x0600147F RID: 5247 RVA: 0x00065724 File Offset: 0x00063924
	private void ck()
	{
		CallResult<LobbyCreated_t> callResult = this.ita;
		if (callResult != null)
		{
			callResult.Dispose();
		}
		this.ita = null;
		Callback<LobbyEnter_t> callback = this.itb;
		if (callback != null)
		{
			callback.Unregister();
		}
		Callback<LobbyDataUpdate_t> callback2 = this.itc;
		if (callback2 != null)
		{
			callback2.Unregister();
		}
		Callback<LobbyChatUpdate_t> callback3 = this.itd;
		if (callback3 != null)
		{
			callback3.Unregister();
		}
		Callback<GameLobbyJoinRequested_t> callback4 = this.ite;
		if (callback4 != null)
		{
			callback4.Unregister();
		}
		this.itb = null;
		this.itc = null;
		this.itd = null;
		this.ite = null;
		this.ist = false;
	}

	// Token: 0x06001480 RID: 5248 RVA: 0x000657B0 File Offset: 0x000639B0
	private void ddd()
	{
		this.isw = 0.0;
	}

	// Token: 0x17000116 RID: 278
	// (get) Token: 0x06001481 RID: 5249 RVA: 0x000657C1 File Offset: 0x000639C1
	public CSteamID ktu
	{
		get
		{
			return new CSteamID(this.isu);
		}
	}

	// Token: 0x14000032 RID: 50
	// (add) Token: 0x060014AF RID: 5295 RVA: 0x000663F4 File Offset: 0x000645F4
	// (remove) Token: 0x06001482 RID: 5250 RVA: 0x000657D0 File Offset: 0x000639D0
	public event Action<CSteamID, CSteamID> isn;

	// Token: 0x06001483 RID: 5251 RVA: 0x00065805 File Offset: 0x00063A05
	private void ddh()
	{
		this.ddi();
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x00065810 File Offset: 0x00063A10
	private void fvv()
	{
		CallResult<LobbyCreated_t> callResult = this.ita;
		if (callResult != null)
		{
			callResult.Dispose();
		}
		this.ita = null;
		Callback<LobbyEnter_t> callback = this.itb;
		if (callback != null)
		{
			callback.Unregister();
		}
		Callback<LobbyDataUpdate_t> callback2 = this.itc;
		if (callback2 != null)
		{
			callback2.Unregister();
		}
		Callback<LobbyChatUpdate_t> callback3 = this.itd;
		if (callback3 != null)
		{
			callback3.Unregister();
		}
		Callback<GameLobbyJoinRequested_t> callback4 = this.ite;
		if (callback4 != null)
		{
			callback4.Unregister();
		}
		this.itb = null;
		this.itc = null;
		this.itd = null;
		this.ite = null;
		this.ist = false;
	}

	// Token: 0x06001485 RID: 5253 RVA: 0x0006589C File Offset: 0x00063A9C
	private void glk(LobbyChatUpdate_t a)
	{
		if (!this.ktv)
		{
			return;
		}
		if (a.m_ulSteamIDLobby != this.isu)
		{
			return;
		}
		Action action = this.isq;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06001486 RID: 5254 RVA: 0x000658C8 File Offset: 0x00063AC8
	private void mqx(LobbyCreated_t a, bool b)
	{
		if (b || a.m_eResult != EResult.k_EResultOK)
		{
			this.ddd();
			this.isz = false;
			Action<string> action = this.isr;
			if (action == null)
			{
				return;
			}
			action(string.Format(MultiplayerLoc.Get(a.dzr(), a.dzs()), b ? a.dzt() : a.m_eResult.ToString()));
			return;
		}
		else
		{
			CSteamID csteamID = new CSteamID(a.m_ulSteamIDLobby);
			if (this.ktv && this.ktu != csteamID)
			{
				fq.dbg(string.Format(a.dzu(), this.isu, csteamID.m_SteamID));
				SteamMatchmaking.LeaveLobby(csteamID);
				this.ddd();
				return;
			}
			if (!this.isz)
			{
				fq.dbg(string.Format(a.dzv(), csteamID.m_SteamID));
				SteamMatchmaking.LeaveLobby(csteamID);
				return;
			}
			this.isz = false;
			this.isy = csteamID.m_SteamID;
			CSteamID steamID = SteamUser.GetSteamID();
			SteamMatchmaking.SetLobbyData(csteamID, a.dzw(), steamID.m_SteamID.ToString());
			SteamMatchmaking.SetLobbyData(csteamID, a.dzx(), Application.version);
			this.ddv(csteamID);
			this.isv = true;
			Action<CSteamID> action2 = this.ism;
			if (action2 == null)
			{
				return;
			}
			action2(csteamID);
			return;
		}
	}

	// Token: 0x06001489 RID: 5257 RVA: 0x00065A45 File Offset: 0x00063C45
	private void bee()
	{
		this.isw = -4826.0;
	}

	// Token: 0x0600148A RID: 5258 RVA: 0x00065805 File Offset: 0x00063A05
	private void jnv()
	{
		this.ddi();
	}

	// Token: 0x0600148C RID: 5260 RVA: 0x00065A8D File Offset: 0x00063C8D
	public CSteamID cxp()
	{
		if (!this.ktv)
		{
			return CSteamID.Nil;
		}
		return SteamMatchmaking.GetLobbyOwner(this.ktu);
	}

	// Token: 0x0600148D RID: 5261 RVA: 0x00065AA8 File Offset: 0x00063CA8
	public CSteamID ddn()
	{
		if (!this.ktv)
		{
			return CSteamID.Nil;
		}
		ulong num;
		if (ulong.TryParse(SteamMatchmaking.GetLobbyData(this.ktu, a.dzy()), out num))
		{
			return new CSteamID(num);
		}
		return CSteamID.Nil;
	}

	// Token: 0x0600148E RID: 5262 RVA: 0x00065A8D File Offset: 0x00063C8D
	public CSteamID ddo()
	{
		if (!this.ktv)
		{
			return CSteamID.Nil;
		}
		return SteamMatchmaking.GetLobbyOwner(this.ktu);
	}

	// Token: 0x0600148F RID: 5263 RVA: 0x00065AE8 File Offset: 0x00063CE8
	private void kic(LobbyDataUpdate_t a)
	{
		if (!this.ktv)
		{
			return;
		}
		if (a.m_ulSteamIDLobby != this.isu)
		{
			return;
		}
		Action action = this.isq;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06001490 RID: 5264 RVA: 0x00065B14 File Offset: 0x00063D14
	private void ddq(LobbyCreated_t a, bool b)
	{
		if (b || a.m_eResult != EResult.k_EResultOK)
		{
			this.ddd();
			this.isz = false;
			Action<string> action = this.isr;
			if (action == null)
			{
				return;
			}
			action(string.Format(MultiplayerLoc.Get(a.dzz(), a.eaa()), b ? a.eab() : a.m_eResult.ToString()));
			return;
		}
		else
		{
			CSteamID csteamID = new CSteamID(a.m_ulSteamIDLobby);
			if (this.ktv && this.ktu != csteamID)
			{
				fq.dbg(string.Format(a.eac(), this.isu, csteamID.m_SteamID));
				SteamMatchmaking.LeaveLobby(csteamID);
				this.ddd();
				return;
			}
			if (!this.isz)
			{
				fq.dbg(string.Format(a.ead(), csteamID.m_SteamID));
				SteamMatchmaking.LeaveLobby(csteamID);
				return;
			}
			this.isz = false;
			this.isy = csteamID.m_SteamID;
			CSteamID steamID = SteamUser.GetSteamID();
			SteamMatchmaking.SetLobbyData(csteamID, a.dzy(), steamID.m_SteamID.ToString());
			SteamMatchmaking.SetLobbyData(csteamID, a.eae(), Application.version);
			this.ddv(csteamID);
			this.isv = true;
			Action<CSteamID> action2 = this.ism;
			if (action2 == null)
			{
				return;
			}
			action2(csteamID);
			return;
		}
	}

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x06001491 RID: 5265 RVA: 0x00065C5C File Offset: 0x00063E5C
	public bool ktv
	{
		get
		{
			return this.isu != 0UL && this.ktu.IsValid();
		}
	}

	// Token: 0x06001492 RID: 5266 RVA: 0x00065C81 File Offset: 0x00063E81
	private void iwe()
	{
		this.isw = Time.realtimeSinceStartupAsDouble + 6491.0;
	}

	// Token: 0x06001493 RID: 5267 RVA: 0x00065C98 File Offset: 0x00063E98
	public void ddk()
	{
		if (!SteamManager.krd)
		{
			Action<string> action = this.isr;
			if (action == null)
			{
				return;
			}
			action(MultiplayerLoc.Get(a.eaf(), a.eag()));
			return;
		}
		else if (this.ktv)
		{
			Action<string> action2 = this.isr;
			if (action2 == null)
			{
				return;
			}
			action2(MultiplayerLoc.Get(a.eah(), a.eai()));
			return;
		}
		else
		{
			if (this.ktt)
			{
				fq.dbg(a.eaj());
				return;
			}
			SteamAPICall_t steamAPICall_t = SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypeFriendsOnly, 16);
			this.ita.Set(steamAPICall_t, null);
			this.isz = true;
			this.isy = 0UL;
			this.ddc();
			return;
		}
	}

	// Token: 0x06001494 RID: 5268 RVA: 0x00065D34 File Offset: 0x00063F34
	public CSteamID nrf()
	{
		if (!this.ktv)
		{
			return CSteamID.Nil;
		}
		ulong num;
		if (ulong.TryParse(SteamMatchmaking.GetLobbyData(this.ktu, a.eak()), out num))
		{
			return new CSteamID(num);
		}
		return CSteamID.Nil;
	}

	// Token: 0x06001495 RID: 5269 RVA: 0x00065805 File Offset: 0x00063A05
	private void jor()
	{
		this.ddi();
	}

	// Token: 0x06001496 RID: 5270 RVA: 0x00065D74 File Offset: 0x00063F74
	private void ddr(LobbyEnter_t a)
	{
		this.ddd();
		CSteamID csteamID = new CSteamID(a.m_ulSteamIDLobby);
		if (this.ktv && this.ktu != csteamID)
		{
			fq.dbg(string.Format(a.eal(), this.isu, csteamID.m_SteamID));
			if (a.m_EChatRoomEnterResponse == 1U)
			{
				SteamMatchmaking.LeaveLobby(csteamID);
			}
			return;
		}
		if (!this.ktv && csteamID.m_SteamID != this.isy)
		{
			fq.dbg(string.Format(a.eam(), this.isy, csteamID.m_SteamID));
			if (a.m_EChatRoomEnterResponse == 1U)
			{
				SteamMatchmaking.LeaveLobby(csteamID);
			}
			return;
		}
		this.isy = 0UL;
		if (a.m_EChatRoomEnterResponse != 1U)
		{
			Action<string> action = this.isr;
			if (action != null)
			{
				action(string.Format(MultiplayerLoc.Get(a.ean(), a.eao()), a.eap() + a.m_EChatRoomEnterResponse.ToString()));
			}
			Action<CSteamID> action2 = this.isp;
			if (action2 == null)
			{
				return;
			}
			action2(csteamID);
			return;
		}
		else
		{
			this.isu = csteamID.m_SteamID;
			CSteamID csteamID2 = this.ddn();
			this.isv = csteamID2 == SteamUser.GetSteamID();
			if (!this.isv)
			{
				string lobbyData = SteamMatchmaking.GetLobbyData(csteamID, a.eae());
				if (!string.IsNullOrEmpty(lobbyData) && lobbyData != Application.version)
				{
					SteamMatchmaking.LeaveLobby(csteamID);
					this.isu = 0UL;
					this.isv = false;
					Action<string> action3 = this.isr;
					if (action3 != null)
					{
						action3(string.Format(MultiplayerLoc.Get(a.ean(), a.eao()), a.eaq() + lobbyData + a.ear() + Application.version));
					}
					Action<CSteamID> action4 = this.isp;
					if (action4 == null)
					{
						return;
					}
					action4(csteamID);
					return;
				}
			}
			if (!this.isv)
			{
				this.ddv(csteamID);
			}
			Action<CSteamID, CSteamID> action5 = this.isn;
			if (action5 != null)
			{
				action5(csteamID, csteamID2);
			}
			Action action6 = this.isq;
			if (action6 == null)
			{
				return;
			}
			action6();
			return;
		}
	}

	// Token: 0x06001497 RID: 5271 RVA: 0x00065F6C File Offset: 0x0006416C
	public void hpw()
	{
		if (!SteamManager.krd)
		{
			Action<string> action = this.isr;
			if (action == null)
			{
				return;
			}
			action(MultiplayerLoc.Get(a.eas(), a.eat()));
			return;
		}
		else if (this.ktv)
		{
			Action<string> action2 = this.isr;
			if (action2 == null)
			{
				return;
			}
			action2(MultiplayerLoc.Get(a.eau(), a.eav()));
			return;
		}
		else
		{
			if (this.ktt)
			{
				fq.dbg(a.eaw());
				return;
			}
			SteamAPICall_t steamAPICall_t = SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypeFriendsOnly, 67);
			this.ita.Set(steamAPICall_t, null);
			this.isz = true;
			this.isy = 0UL;
			this.ddc();
			return;
		}
	}

	// Token: 0x06001498 RID: 5272 RVA: 0x00065805 File Offset: 0x00063A05
	private void bfv()
	{
		this.ddi();
	}

	// Token: 0x06001499 RID: 5273 RVA: 0x00066008 File Offset: 0x00064208
	private void ddi()
	{
		if (this.ist)
		{
			return;
		}
		if (!SteamManager.krd)
		{
			return;
		}
		this.ist = true;
		this.ita = CallResult<LobbyCreated_t>.Create(new CallResult<LobbyCreated_t>.APIDispatchDelegate(this.ddq));
		this.itb = Callback<LobbyEnter_t>.Create(new Callback<LobbyEnter_t>.DispatchDelegate(this.ddr));
		this.itc = Callback<LobbyDataUpdate_t>.Create(new Callback<LobbyDataUpdate_t>.DispatchDelegate(this.dds));
		this.itd = Callback<LobbyChatUpdate_t>.Create(new Callback<LobbyChatUpdate_t>.DispatchDelegate(this.ddt));
		this.ite = Callback<GameLobbyJoinRequested_t>.Create(new Callback<GameLobbyJoinRequested_t>.DispatchDelegate(this.ddu));
	}

	// Token: 0x14000031 RID: 49
	// (add) Token: 0x060014AA RID: 5290 RVA: 0x00066368 File Offset: 0x00064568
	// (remove) Token: 0x0600149A RID: 5274 RVA: 0x000660A0 File Offset: 0x000642A0
	public event Action<CSteamID> ism;

	// Token: 0x0600149B RID: 5275 RVA: 0x000660D5 File Offset: 0x000642D5
	private void fi()
	{
		this.isw = 4854.0;
	}

	// Token: 0x0600149C RID: 5276 RVA: 0x000660E6 File Offset: 0x000642E6
	private void nzu()
	{
		this.isw = Time.realtimeSinceStartupAsDouble + -6461.0;
	}

	// Token: 0x0600149D RID: 5277 RVA: 0x000660FD File Offset: 0x000642FD
	private void oie(CSteamID a)
	{
		SteamFriends.SetRichPresence(a.eax(), a.eay() + a.m_SteamID.ToString());
	}

	// Token: 0x0600149E RID: 5278 RVA: 0x00066120 File Offset: 0x00064320
	private void onb()
	{
		this.isw = 2474.0;
	}

	// Token: 0x0600149F RID: 5279 RVA: 0x00066131 File Offset: 0x00064331
	private void fmo()
	{
		if (fv.isl != null && fv.isl != this)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		fv.isl = this;
	}

	// Token: 0x060014A0 RID: 5280 RVA: 0x00065A8D File Offset: 0x00063C8D
	public CSteamID ckd()
	{
		if (!this.ktv)
		{
			return CSteamID.Nil;
		}
		return SteamMatchmaking.GetLobbyOwner(this.ktu);
	}

	// Token: 0x060014A1 RID: 5281 RVA: 0x0006615C File Offset: 0x0006435C
	private void crb(LobbyCreated_t a, bool b)
	{
		if (b || a.m_eResult != EResult.k_EResultOK)
		{
			this.ddd();
			this.isz = false;
			Action<string> action = this.isr;
			if (action == null)
			{
				return;
			}
			action(string.Format(MultiplayerLoc.Get(a.eaz(), a.eba()), b ? a.ebb() : a.m_eResult.ToString()));
			return;
		}
		else
		{
			CSteamID csteamID = new CSteamID(a.m_ulSteamIDLobby);
			if (this.ktv && this.ktu != csteamID)
			{
				fq.dbg(string.Format(a.ebc(), this.isu, csteamID.m_SteamID));
				SteamMatchmaking.LeaveLobby(csteamID);
				this.ddd();
				return;
			}
			if (!this.isz)
			{
				fq.dbg(string.Format(a.ebd(), csteamID.m_SteamID));
				SteamMatchmaking.LeaveLobby(csteamID);
				return;
			}
			this.isz = false;
			this.isy = csteamID.m_SteamID;
			CSteamID steamID = SteamUser.GetSteamID();
			SteamMatchmaking.SetLobbyData(csteamID, a.ebe(), steamID.m_SteamID.ToString());
			SteamMatchmaking.SetLobbyData(csteamID, a.ebf(), Application.version);
			this.ddv(csteamID);
			this.isv = true;
			Action<CSteamID> action2 = this.ism;
			if (action2 == null)
			{
				return;
			}
			action2(csteamID);
			return;
		}
	}

	// Token: 0x060014A2 RID: 5282 RVA: 0x000662A2 File Offset: 0x000644A2
	private void ddw()
	{
		SteamFriends.SetRichPresence(a.dzh(), string.Empty);
	}

	// Token: 0x060014A3 RID: 5283 RVA: 0x000662B4 File Offset: 0x000644B4
	private void few()
	{
		SteamManager.ibn -= this.ddh;
		this.ddj();
		if (this.ktv)
		{
			this.ddm();
		}
	}

	// Token: 0x060014A4 RID: 5284 RVA: 0x000662DB File Offset: 0x000644DB
	private void may()
	{
		SteamFriends.SetRichPresence(a.ebg(), string.Empty);
	}

	// Token: 0x060014A5 RID: 5285 RVA: 0x00065A8D File Offset: 0x00063C8D
	public CSteamID fnb()
	{
		if (!this.ktv)
		{
			return CSteamID.Nil;
		}
		return SteamMatchmaking.GetLobbyOwner(this.ktu);
	}

	// Token: 0x060014A6 RID: 5286 RVA: 0x000662F0 File Offset: 0x000644F0
	public void ddm()
	{
		this.isz = false;
		this.isy = 0UL;
		if (!this.ktv)
		{
			return;
		}
		CSteamID csteamID = this.ktu;
		if (SteamManager.krd && !SteamManager.ibh)
		{
			this.ddw();
			SteamMatchmaking.LeaveLobby(csteamID);
		}
		this.isu = 0UL;
		this.isv = false;
		Action action = this.iso;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x060014A8 RID: 5288 RVA: 0x000662B4 File Offset: 0x000644B4
	private void OnDisable()
	{
		SteamManager.ibn -= this.ddh;
		this.ddj();
		if (this.ktv)
		{
			this.ddm();
		}
	}

	// Token: 0x060014A9 RID: 5289 RVA: 0x000662B4 File Offset: 0x000644B4
	private void gbm()
	{
		SteamManager.ibn -= this.ddh;
		this.ddj();
		if (this.ktv)
		{
			this.ddm();
		}
	}

	// Token: 0x060014AB RID: 5291 RVA: 0x00065AE8 File Offset: 0x00063CE8
	private void blo(LobbyDataUpdate_t a)
	{
		if (!this.ktv)
		{
			return;
		}
		if (a.m_ulSteamIDLobby != this.isu)
		{
			return;
		}
		Action action = this.isq;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x17000118 RID: 280
	// (get) Token: 0x060014AC RID: 5292 RVA: 0x0006639D File Offset: 0x0006459D
	public bool ktw
	{
		get
		{
			return this.isv;
		}
	}

	// Token: 0x060014AE RID: 5294 RVA: 0x000663DD File Offset: 0x000645DD
	private void ddc()
	{
		this.isw = Time.realtimeSinceStartupAsDouble + 3.0;
	}

	// Token: 0x060014B0 RID: 5296 RVA: 0x0006642C File Offset: 0x0006462C
	public List<CSteamID> lxm()
	{
		List<CSteamID> list = new List<CSteamID>();
		if (!this.ktv)
		{
			return list;
		}
		int numLobbyMembers = SteamMatchmaking.GetNumLobbyMembers(this.ktu);
		for (int i = 0; i < numLobbyMembers; i++)
		{
			list.Add(SteamMatchmaking.GetLobbyMemberByIndex(this.ktu, i));
		}
		return list;
	}

	// Token: 0x060014B1 RID: 5297 RVA: 0x00066474 File Offset: 0x00064674
	public void ddl(CSteamID a)
	{
		if (!SteamManager.krd)
		{
			Action<string> action = this.isr;
			if (action == null)
			{
				return;
			}
			action(MultiplayerLoc.Get(a.ebh(), a.ebi()));
			return;
		}
		else if (!a.IsValid())
		{
			Action<string> action2 = this.isr;
			if (action2 == null)
			{
				return;
			}
			action2(MultiplayerLoc.Get(a.ebj(), a.ebk()));
			return;
		}
		else
		{
			if (this.ktv && this.ktu == a)
			{
				return;
			}
			if (this.ktt)
			{
				fq.dbg(string.Format(a.ebl(), a.m_SteamID));
				return;
			}
			if (this.ktv)
			{
				this.ddm();
			}
			SteamMatchmaking.JoinLobby(a);
			this.isz = false;
			this.isy = a.m_SteamID;
			this.ddc();
			return;
		}
	}

	// Token: 0x060014B2 RID: 5298 RVA: 0x0006653C File Offset: 0x0006473C
	private void ddj()
	{
		CallResult<LobbyCreated_t> callResult = this.ita;
		if (callResult != null)
		{
			callResult.Dispose();
		}
		this.ita = null;
		Callback<LobbyEnter_t> callback = this.itb;
		if (callback != null)
		{
			callback.Unregister();
		}
		Callback<LobbyDataUpdate_t> callback2 = this.itc;
		if (callback2 != null)
		{
			callback2.Unregister();
		}
		Callback<LobbyChatUpdate_t> callback3 = this.itd;
		if (callback3 != null)
		{
			callback3.Unregister();
		}
		Callback<GameLobbyJoinRequested_t> callback4 = this.ite;
		if (callback4 != null)
		{
			callback4.Unregister();
		}
		this.itb = null;
		this.itc = null;
		this.itd = null;
		this.ite = null;
		this.ist = false;
	}

	// Token: 0x060014B3 RID: 5299 RVA: 0x00065AE8 File Offset: 0x00063CE8
	private void dds(LobbyDataUpdate_t a)
	{
		if (!this.ktv)
		{
			return;
		}
		if (a.m_ulSteamIDLobby != this.isu)
		{
			return;
		}
		Action action = this.isq;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x060014B4 RID: 5300 RVA: 0x000665C8 File Offset: 0x000647C8
	private void ddu(GameLobbyJoinRequested_t a)
	{
		Action<CSteamID> action = this.iss;
		if (action == null)
		{
			return;
		}
		action(a.m_steamIDLobby);
	}

	// Token: 0x060014B5 RID: 5301 RVA: 0x00065494 File Offset: 0x00063694
	private void OnEnable()
	{
		SteamManager.ibn += this.ddh;
		if (SteamManager.krd)
		{
			this.ddi();
		}
	}

	// Token: 0x060014B6 RID: 5302 RVA: 0x00065805 File Offset: 0x00063A05
	private void nmh()
	{
		this.ddi();
	}

	// Token: 0x060014B7 RID: 5303 RVA: 0x000665E0 File Offset: 0x000647E0
	private void sa(LobbyCreated_t a, bool b)
	{
		if (b || a.m_eResult != EResult.k_EResultOK)
		{
			this.ddd();
			this.isz = false;
			Action<string> action = this.isr;
			if (action == null)
			{
				return;
			}
			action(string.Format(MultiplayerLoc.Get(a.ebm(), a.ebn()), b ? a.ebo() : a.m_eResult.ToString()));
			return;
		}
		else
		{
			CSteamID csteamID = new CSteamID(a.m_ulSteamIDLobby);
			if (this.ktv && this.ktu != csteamID)
			{
				fq.dbg(string.Format(a.ebp(), this.isu, csteamID.m_SteamID));
				SteamMatchmaking.LeaveLobby(csteamID);
				this.ddd();
				return;
			}
			if (!this.isz)
			{
				fq.dbg(string.Format(a.ebq(), csteamID.m_SteamID));
				SteamMatchmaking.LeaveLobby(csteamID);
				return;
			}
			this.isz = false;
			this.isy = csteamID.m_SteamID;
			CSteamID steamID = SteamUser.GetSteamID();
			SteamMatchmaking.SetLobbyData(csteamID, a.ebr(), steamID.m_SteamID.ToString());
			SteamMatchmaking.SetLobbyData(csteamID, a.ebs(), Application.version);
			this.ddv(csteamID);
			this.isv = true;
			Action<CSteamID> action2 = this.ism;
			if (action2 == null)
			{
				return;
			}
			action2(csteamID);
			return;
		}
	}

	// Token: 0x060014B8 RID: 5304 RVA: 0x0006589C File Offset: 0x00063A9C
	private void ddt(LobbyChatUpdate_t a)
	{
		if (!this.ktv)
		{
			return;
		}
		if (a.m_ulSteamIDLobby != this.isu)
		{
			return;
		}
		Action action = this.isq;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x060014BA RID: 5306 RVA: 0x00065AE8 File Offset: 0x00063CE8
	private void fop(LobbyDataUpdate_t a)
	{
		if (!this.ktv)
		{
			return;
		}
		if (a.m_ulSteamIDLobby != this.isu)
		{
			return;
		}
		Action action = this.isq;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x060014BB RID: 5307 RVA: 0x00066131 File Offset: 0x00064331
	private void lcm()
	{
		if (fv.isl != null && fv.isl != this)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		fv.isl = this;
	}

	// Token: 0x060014BC RID: 5308 RVA: 0x0006675D File Offset: 0x0006495D
	private void njf()
	{
		SteamFriends.SetRichPresence(a.ebt(), string.Empty);
	}

	// Token: 0x060014BD RID: 5309 RVA: 0x00065AE8 File Offset: 0x00063CE8
	private void jog(LobbyDataUpdate_t a)
	{
		if (!this.ktv)
		{
			return;
		}
		if (a.m_ulSteamIDLobby != this.isu)
		{
			return;
		}
		Action action = this.isq;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x14000033 RID: 51
	// (add) Token: 0x060014BE RID: 5310 RVA: 0x00066770 File Offset: 0x00064970
	// (remove) Token: 0x060014C3 RID: 5315 RVA: 0x00066810 File Offset: 0x00064A10
	public event Action iso;

	// Token: 0x060014BF RID: 5311 RVA: 0x0006589C File Offset: 0x00063A9C
	private void kay(LobbyChatUpdate_t a)
	{
		if (!this.ktv)
		{
			return;
		}
		if (a.m_ulSteamIDLobby != this.isu)
		{
			return;
		}
		Action action = this.isq;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x060014C0 RID: 5312 RVA: 0x00065A8D File Offset: 0x00063C8D
	public CSteamID dvv()
	{
		if (!this.ktv)
		{
			return CSteamID.Nil;
		}
		return SteamMatchmaking.GetLobbyOwner(this.ktu);
	}

	// Token: 0x060014C1 RID: 5313 RVA: 0x00066131 File Offset: 0x00064331
	private void Awake()
	{
		if (fv.isl != null && fv.isl != this)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		fv.isl = this;
	}

	// Token: 0x060014C2 RID: 5314 RVA: 0x000667A8 File Offset: 0x000649A8
	public void mbn()
	{
		this.isz = false;
		this.isy = 0UL;
		if (!this.ktv)
		{
			return;
		}
		CSteamID csteamID = this.ktu;
		if (SteamManager.krd && !SteamManager.ibh)
		{
			this.ddw();
			SteamMatchmaking.LeaveLobby(csteamID);
		}
		this.isu = 0UL;
		this.isv = false;
		Action action = this.iso;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x04000A8F RID: 2703
	private static readonly AppId_t isi = new AppId_t(3861430U);

	// Token: 0x04000A90 RID: 2704
	public const int MaxMembers = 16;

	// Token: 0x04000A91 RID: 2705
	private const string isj = "host_steamid";

	// Token: 0x04000A92 RID: 2706
	private const string isk = "app_build";

	// Token: 0x04000A93 RID: 2707
	private static fv isl;

	// Token: 0x04000A9B RID: 2715
	private bool ist;

	// Token: 0x04000A9C RID: 2716
	private ulong isu;

	// Token: 0x04000A9D RID: 2717
	private bool isv;

	// Token: 0x04000A9E RID: 2718
	private double isw;

	// Token: 0x04000A9F RID: 2719
	private const double isx = 3.0;

	// Token: 0x04000AA0 RID: 2720
	private ulong isy;

	// Token: 0x04000AA1 RID: 2721
	private bool isz;

	// Token: 0x04000AA2 RID: 2722
	private CallResult<LobbyCreated_t> ita;

	// Token: 0x04000AA3 RID: 2723
	private Callback<LobbyEnter_t> itb;

	// Token: 0x04000AA4 RID: 2724
	private Callback<LobbyDataUpdate_t> itc;

	// Token: 0x04000AA5 RID: 2725
	private Callback<LobbyChatUpdate_t> itd;

	// Token: 0x04000AA6 RID: 2726
	private Callback<GameLobbyJoinRequested_t> ite;
}
