using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using BongoWaifu.Multiplayer;
using FishNet;
using FishNet.Connection;
using FishNet.Managing.Client;
using FishNet.Managing.Server;
using FishNet.Object;
using FishNet.Transporting;
using Steamworks;
using UnityEngine;

// Token: 0x02000116 RID: 278
public sealed class fp : MonoBehaviour
{
	// Token: 0x060013E6 RID: 5094 RVA: 0x00061C54 File Offset: 0x0005FE54
	private void cws(ClientConnectionStateArgs a)
	{
		fq.dbg(string.Format(a.dul(), a.ConnectionState));
		this.irg = a.ConnectionState;
		if (a.ConnectionState == LocalConnectionState.Started)
		{
			MultiplayerSession.dih(true);
			return;
		}
		if (a.ConnectionState == LocalConnectionState.Stopped)
		{
			MultiplayerSession.dih(false);
			if (this.ire)
			{
				return;
			}
			ga ga = ga.kub;
			if (ga != null && ga.kuc)
			{
				ga.dft();
				return;
			}
			if (ga != null && ga.dfs())
			{
				return;
			}
			if (this.irc != null && this.irc.ktv)
			{
				this.irc.ddm();
			}
		}
	}

	// Token: 0x060013E7 RID: 5095 RVA: 0x00061D05 File Offset: 0x0005FF05
	private void Awake()
	{
		if (fp.irb != null && fp.irb != this)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		fp.irb = this;
	}

	// Token: 0x060013E8 RID: 5096 RVA: 0x00061D2E File Offset: 0x0005FF2E
	private void er()
	{
		this.dbc();
	}

	// Token: 0x060013E9 RID: 5097 RVA: 0x00061D38 File Offset: 0x0005FF38
	private void OnDestroy()
	{
		if (this.irc != null)
		{
			this.irc.ism -= this.dax;
			this.irc.isn -= this.day;
			this.irc.iso -= this.dbb;
			this.irc.iss -= this.daz;
			this.irc.isq -= this.dba;
		}
		if (this.irf && InstanceFinder.ClientManager != null)
		{
			InstanceFinder.ClientManager.OnClientConnectionState -= this.dbe;
		}
	}

	// Token: 0x060013EA RID: 5098 RVA: 0x00061DF4 File Offset: 0x0005FFF4
	private void dn()
	{
		this.irc = fv.kts;
		if (this.irc != null)
		{
			this.irc.ism += this.dax;
			this.irc.isn += this.day;
			this.irc.iso += this.dbb;
			this.irc.iss += this.daz;
			this.irc.isq += this.dba;
		}
		else
		{
			Debug.LogWarning(a.dum());
		}
		this.dap();
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x00061E9F File Offset: 0x0006009F
	public void daq()
	{
		ga ga = ga.kub;
		if (ga != null)
		{
			ga.dfu();
		}
		this.dap();
		if (this.irc == null)
		{
			Debug.LogWarning(a.dun());
			return;
		}
		this.irc.ddk();
	}

	// Token: 0x060013EC RID: 5100 RVA: 0x00061EDC File Offset: 0x000600DC
	private void dbd()
	{
		bool flag = this.ird;
		if (InstanceFinder.ClientManager != null)
		{
			InstanceFinder.ClientManager.StopConnection();
		}
		if (flag && InstanceFinder.ServerManager != null)
		{
			InstanceFinder.ServerManager.StopConnection(true);
		}
		this.ird = false;
	}

	// Token: 0x060013ED RID: 5101 RVA: 0x00061F29 File Offset: 0x00060129
	private void dbb()
	{
		if (this.ire)
		{
			return;
		}
		this.dbd();
	}

	// Token: 0x060013EE RID: 5102 RVA: 0x00061F3A File Offset: 0x0006013A
	public void dav()
	{
		fq.dbg(a.duo());
		this.daw();
	}

	// Token: 0x060013EF RID: 5103 RVA: 0x00061F4C File Offset: 0x0006014C
	private void ddw(CSteamID a, CSteamID b)
	{
		this.dap();
		if (this.irc != null && this.irc.ktw)
		{
			return;
		}
		if (!b.IsValid())
		{
			Debug.LogWarning(a.dup());
			return;
		}
		if (InstanceFinder.ClientManager != null)
		{
			fq.dbg(string.Format(a.duq(), b.m_SteamID));
			InstanceFinder.ClientManager.StartConnection(b.m_SteamID.ToString());
		}
	}

	// Token: 0x060013F0 RID: 5104 RVA: 0x00061FD0 File Offset: 0x000601D0
	public void fec()
	{
		if (this.ire)
		{
			return;
		}
		this.ire = true;
		try
		{
			this.dbd();
			if (this.irc != null)
			{
				this.irc.ddm();
			}
		}
		finally
		{
			this.ire = false;
		}
		ga ga = ga.kub;
		if (ga == null)
		{
			return;
		}
		ga.dfv();
	}

	// Token: 0x060013F1 RID: 5105 RVA: 0x00062038 File Offset: 0x00060238
	private void mfy()
	{
		if (!this.ird || this.ire || this.irc == null || !this.irc.ktv || !this.irc.ktw)
		{
			fm fm = this.irj;
			if (fm == null)
			{
				return;
			}
			fm.czy();
			return;
		}
		else if (!SteamManager.krd || SteamManager.ibh)
		{
			fm fm2 = this.irj;
			if (fm2 == null)
			{
				return;
			}
			fm2.czy();
			return;
		}
		else
		{
			if (Time.unscaledTime < this.irk)
			{
				return;
			}
			this.irk = Time.unscaledTime + -4322f;
			List<CSteamID> list = this.irc.ddp();
			this.irl.Clear();
			for (int i = 0; i < list.Count; i++)
			{
				this.irl.Add(list[i].m_SteamID);
			}
			if (!this.irl.Contains(SteamUser.GetSteamID().m_SteamID))
			{
				fm fm3 = this.irj;
				if (fm3 == null)
				{
					return;
				}
				fm3.czy();
				return;
			}
			else
			{
				ServerManager serverManager = InstanceFinder.ServerManager;
				if (!(serverManager == null))
				{
					this.irm.Clear();
					this.irn.Clear();
					foreach (KeyValuePair<int, NetworkConnection> keyValuePair in serverManager.Clients)
					{
						NetworkConnection value = keyValuePair.Value;
						if (!(value == null) && !value.IsLocalClient)
						{
							ulong num = NetworkPlayer.djk(value);
							if (num != 0UL)
							{
								this.irm.Add(num);
								this.irn[num] = value;
							}
						}
					}
					if (this.irj == null)
					{
						this.irj = new fm(-1407f);
					}
					List<ulong> list2 = this.irj.czx(this.irl, this.irm, Time.unscaledTime);
					for (int j = 0; j < list2.Count; j++)
					{
						NetworkConnection networkConnection;
						if (this.irn.TryGetValue(list2[j], out networkConnection))
						{
							fq.dbg(string.Format(a.dur(), 7084f, list2[j]));
							NetworkObject firstObject = networkConnection.FirstObject;
							NetworkPlayer networkPlayer = ((firstObject != null) ? firstObject.GetComponent<NetworkPlayer>() : null);
							if (networkPlayer == null || !networkPlayer.djv())
							{
								networkConnection.Disconnect(false);
							}
						}
					}
					return;
				}
				fm fm4 = this.irj;
				if (fm4 == null)
				{
					return;
				}
				fm4.czy();
				return;
			}
		}
	}

	// Token: 0x060013F2 RID: 5106 RVA: 0x000622B8 File Offset: 0x000604B8
	private void gdt(ClientConnectionStateArgs a)
	{
		fq.dbg(string.Format(a.dus(), a.ConnectionState));
		this.irg = a.ConnectionState;
		if (a.ConnectionState == LocalConnectionState.Started)
		{
			MultiplayerSession.dih(true);
			return;
		}
		if (a.ConnectionState == LocalConnectionState.Stopped)
		{
			MultiplayerSession.dih(false);
			if (this.ire)
			{
				return;
			}
			ga ga = ga.kub;
			if (ga != null && ga.kuc)
			{
				ga.dft();
				return;
			}
			if (ga != null && ga.dfs())
			{
				return;
			}
			if (this.irc != null && this.irc.ktv)
			{
				this.irc.ddm();
			}
		}
	}

	// Token: 0x060013F3 RID: 5107 RVA: 0x0006236C File Offset: 0x0006056C
	public void daw()
	{
		if (this.ire)
		{
			return;
		}
		this.ire = true;
		try
		{
			this.dbd();
			if (this.irc != null)
			{
				this.irc.ddm();
			}
		}
		finally
		{
			this.ire = false;
		}
	}

	// Token: 0x060013F4 RID: 5108 RVA: 0x000623C4 File Offset: 0x000605C4
	private void nyl(CSteamID a, CSteamID b)
	{
		this.dap();
		if (this.irc != null && this.irc.ktw)
		{
			return;
		}
		if (!b.IsValid())
		{
			Debug.LogWarning(a.dut());
			return;
		}
		if (InstanceFinder.ClientManager != null)
		{
			fq.dbg(string.Format(a.duu(), b.m_SteamID));
			InstanceFinder.ClientManager.StartConnection(b.m_SteamID.ToString());
		}
	}

	// Token: 0x060013F5 RID: 5109 RVA: 0x00062448 File Offset: 0x00060648
	private void Start()
	{
		this.irc = fv.kts;
		if (this.irc != null)
		{
			this.irc.ism += this.dax;
			this.irc.isn += this.day;
			this.irc.iso += this.dbb;
			this.irc.iss += this.daz;
			this.irc.isq += this.dba;
		}
		else
		{
			Debug.LogWarning(a.duv());
		}
		this.dap();
	}

	// Token: 0x060013F6 RID: 5110 RVA: 0x000624F4 File Offset: 0x000606F4
	private void dbe(ClientConnectionStateArgs a)
	{
		fq.dbg(string.Format(a.duw(), a.ConnectionState));
		this.irg = a.ConnectionState;
		if (a.ConnectionState == LocalConnectionState.Started)
		{
			MultiplayerSession.dih(true);
			return;
		}
		if (a.ConnectionState == LocalConnectionState.Stopped)
		{
			MultiplayerSession.dih(false);
			if (this.ire)
			{
				return;
			}
			ga ga = ga.kub;
			if (ga != null && ga.kuc)
			{
				ga.dft();
				return;
			}
			if (ga != null && ga.dfs())
			{
				return;
			}
			if (this.irc != null && this.irc.ktv)
			{
				this.irc.ddm();
			}
		}
	}

	// Token: 0x060013F7 RID: 5111 RVA: 0x000625A8 File Offset: 0x000607A8
	public void hgv()
	{
		if (this.ire)
		{
			return;
		}
		this.ire = true;
		try
		{
			this.dbd();
			if (this.irc != null)
			{
				this.irc.ddm();
			}
		}
		finally
		{
			this.ire = false;
		}
		ga ga = ga.kub;
		if (ga == null)
		{
			return;
		}
		ga.dfv();
	}

	// Token: 0x060013F8 RID: 5112 RVA: 0x00062610 File Offset: 0x00060810
	private void gfn()
	{
		if (this.irc != null)
		{
			this.irc.ism -= this.dax;
			this.irc.isn -= this.day;
			this.irc.iso -= this.dbb;
			this.irc.iss -= this.daz;
			this.irc.isq -= this.dba;
		}
		if (this.irf && InstanceFinder.ClientManager != null)
		{
			InstanceFinder.ClientManager.OnClientConnectionState -= this.dbe;
		}
	}

	// Token: 0x060013F9 RID: 5113 RVA: 0x000626C9 File Offset: 0x000608C9
	public void dar(CSteamID a)
	{
		ga ga = ga.kub;
		if (ga != null)
		{
			ga.dfu();
		}
		this.dap();
		if (this.irc == null)
		{
			return;
		}
		this.irc.ddl(a);
	}

	// Token: 0x060013FA RID: 5114 RVA: 0x000626FC File Offset: 0x000608FC
	private void cfi()
	{
		this.irc = fv.kts;
		if (this.irc != null)
		{
			this.irc.ism += this.dax;
			this.irc.isn += this.day;
			this.irc.iso += this.dbb;
			this.irc.iss += this.daz;
			this.irc.isq += this.dba;
		}
		else
		{
			Debug.LogWarning(a.dux());
		}
		this.dap();
	}

	// Token: 0x060013FB RID: 5115 RVA: 0x000627A7 File Offset: 0x000609A7
	public void das(CSteamID a)
	{
		this.dap();
		if (this.irc == null)
		{
			return;
		}
		this.irc.ddl(a);
	}

	// Token: 0x060013FC RID: 5116 RVA: 0x000627CC File Offset: 0x000609CC
	private void esq(CSteamID a, CSteamID b)
	{
		this.dap();
		if (this.irc != null && this.irc.ktw)
		{
			return;
		}
		if (!b.IsValid())
		{
			Debug.LogWarning(a.duy());
			return;
		}
		if (InstanceFinder.ClientManager != null)
		{
			fq.dbg(string.Format(a.duz(), b.m_SteamID));
			InstanceFinder.ClientManager.StartConnection(b.m_SteamID.ToString());
		}
	}

	// Token: 0x060013FD RID: 5117 RVA: 0x0006284D File Offset: 0x00060A4D
	private void nov(CSteamID a)
	{
		this.dar(a);
	}

	// Token: 0x060013FE RID: 5118 RVA: 0x000627A7 File Offset: 0x000609A7
	public void bed(CSteamID a)
	{
		this.dap();
		if (this.irc == null)
		{
			return;
		}
		this.irc.ddl(a);
	}

	// Token: 0x060013FF RID: 5119 RVA: 0x00062858 File Offset: 0x00060A58
	private void bw(ClientConnectionStateArgs a)
	{
		fq.dbg(string.Format(a.dva(), a.ConnectionState));
		this.irg = a.ConnectionState;
		if (a.ConnectionState == LocalConnectionState.Started)
		{
			MultiplayerSession.dih(true);
			return;
		}
		if (a.ConnectionState == LocalConnectionState.Stopped)
		{
			MultiplayerSession.dih(false);
			if (this.ire)
			{
				return;
			}
			ga ga = ga.kub;
			if (ga != null && ga.kuc)
			{
				ga.dft();
				return;
			}
			if (ga != null && ga.dfs())
			{
				return;
			}
			if (this.irc != null && this.irc.ktv)
			{
				this.irc.ddm();
			}
		}
	}

	// Token: 0x06001400 RID: 5120 RVA: 0x0006290C File Offset: 0x00060B0C
	public void dat(CSteamID a = default(CSteamID))
	{
		this.dap();
		if (this.irc == null || !this.irc.ktv)
		{
			return;
		}
		CSteamID csteamID = (a.IsValid() ? a : this.irc.ddn());
		if (!csteamID.IsValid())
		{
			fq.dbg(a.dvb());
			return;
		}
		if (InstanceFinder.ClientManager != null)
		{
			fq.dbg(string.Format(a.dvc(), csteamID.m_SteamID));
			InstanceFinder.ClientManager.StartConnection(csteamID.m_SteamID.ToString());
		}
	}

	// Token: 0x06001401 RID: 5121 RVA: 0x000629A5 File Offset: 0x00060BA5
	public void cva()
	{
		ga ga = ga.kub;
		if (ga != null)
		{
			ga.dfu();
		}
		this.dap();
		if (this.irc == null)
		{
			Debug.LogWarning(a.dvd());
			return;
		}
		this.irc.ddk();
	}

	// Token: 0x06001402 RID: 5122 RVA: 0x000629E4 File Offset: 0x00060BE4
	private void kra()
	{
		if (this.ire)
		{
			return;
		}
		if (this.irc == null || !this.irc.ktv || this.irc.ktw)
		{
			return;
		}
		if (this.irg != LocalConnectionState.Stopped)
		{
			return;
		}
		ga ga = ga.kub;
		if (ga != null && ga.kuc)
		{
			return;
		}
		CSteamID csteamID = this.irc.ddn();
		if (!csteamID.IsValid())
		{
			return;
		}
		if (InstanceFinder.ClientManager == null)
		{
			return;
		}
		fq.dbg(string.Format(a.dve(), csteamID.m_SteamID));
		InstanceFinder.ClientManager.StartConnection(csteamID.m_SteamID.ToString());
	}

	// Token: 0x06001403 RID: 5123 RVA: 0x00062A9C File Offset: 0x00060C9C
	private void ncs()
	{
		if (this.ire)
		{
			return;
		}
		if (this.irc == null || !this.irc.ktv || this.irc.ktw)
		{
			return;
		}
		if (this.irg != LocalConnectionState.Stopped)
		{
			return;
		}
		ga ga = ga.kub;
		if (ga != null && ga.kuc)
		{
			return;
		}
		CSteamID csteamID = this.irc.ddn();
		if (!csteamID.IsValid())
		{
			return;
		}
		if (InstanceFinder.ClientManager == null)
		{
			return;
		}
		fq.dbg(string.Format(a.dvf(), csteamID.m_SteamID));
		InstanceFinder.ClientManager.StartConnection(csteamID.m_SteamID.ToString());
	}

	// Token: 0x06001404 RID: 5124 RVA: 0x00062B54 File Offset: 0x00060D54
	public void nbz()
	{
		if (this.ire)
		{
			return;
		}
		this.ire = true;
		try
		{
			this.dbd();
			if (this.irc != null)
			{
				this.irc.ddm();
			}
		}
		finally
		{
			this.ire = false;
		}
	}

	// Token: 0x06001405 RID: 5125 RVA: 0x00061D05 File Offset: 0x0005FF05
	private void gsa()
	{
		if (fp.irb != null && fp.irb != this)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		fp.irb = this;
	}

	// Token: 0x06001406 RID: 5126 RVA: 0x00062BAC File Offset: 0x00060DAC
	public void dau()
	{
		if (this.ire)
		{
			return;
		}
		this.ire = true;
		try
		{
			this.dbd();
			if (this.irc != null)
			{
				this.irc.ddm();
			}
		}
		finally
		{
			this.ire = false;
		}
		ga ga = ga.kub;
		if (ga == null)
		{
			return;
		}
		ga.dfv();
	}

	// Token: 0x06001407 RID: 5127 RVA: 0x00062C14 File Offset: 0x00060E14
	private void dap()
	{
		if (this.irf)
		{
			return;
		}
		ClientManager clientManager = InstanceFinder.ClientManager;
		if (clientManager == null)
		{
			return;
		}
		clientManager.OnClientConnectionState += this.dbe;
		this.irf = true;
	}

	// Token: 0x06001408 RID: 5128 RVA: 0x00061D05 File Offset: 0x0005FF05
	private void omd()
	{
		if (fp.irb != null && fp.irb != this)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		fp.irb = this;
	}

	// Token: 0x06001409 RID: 5129 RVA: 0x00062C54 File Offset: 0x00060E54
	private void ljr()
	{
		if (this.ire)
		{
			return;
		}
		if (this.irc == null || !this.irc.ktv || this.irc.ktw)
		{
			return;
		}
		if (this.irg != LocalConnectionState.Stopped)
		{
			return;
		}
		ga ga = ga.kub;
		if (ga != null && ga.kuc)
		{
			return;
		}
		CSteamID csteamID = this.irc.ddn();
		if (!csteamID.IsValid())
		{
			return;
		}
		if (InstanceFinder.ClientManager == null)
		{
			return;
		}
		fq.dbg(string.Format(a.dvg(), csteamID.m_SteamID));
		InstanceFinder.ClientManager.StartConnection(csteamID.m_SteamID.ToString());
	}

	// Token: 0x0600140A RID: 5130 RVA: 0x00062D0C File Offset: 0x00060F0C
	private void eql(CSteamID a, CSteamID b)
	{
		this.dap();
		if (this.irc != null && this.irc.ktw)
		{
			return;
		}
		if (!b.IsValid())
		{
			Debug.LogWarning(a.dvh());
			return;
		}
		if (InstanceFinder.ClientManager != null)
		{
			fq.dbg(string.Format(a.dvi(), b.m_SteamID));
			InstanceFinder.ClientManager.StartConnection(b.m_SteamID.ToString());
		}
	}

	// Token: 0x0600140B RID: 5131 RVA: 0x00062D90 File Offset: 0x00060F90
	private void day(CSteamID a, CSteamID b)
	{
		this.dap();
		if (this.irc != null && this.irc.ktw)
		{
			return;
		}
		if (!b.IsValid())
		{
			Debug.LogWarning(a.dvj());
			return;
		}
		if (InstanceFinder.ClientManager != null)
		{
			fq.dbg(string.Format(a.dvk(), b.m_SteamID));
			InstanceFinder.ClientManager.StartConnection(b.m_SteamID.ToString());
		}
	}

	// Token: 0x0600140C RID: 5132 RVA: 0x00062E14 File Offset: 0x00061014
	private void dba()
	{
		if (this.ire)
		{
			return;
		}
		if (this.irc == null || !this.irc.ktv || this.irc.ktw)
		{
			return;
		}
		if (this.irg != LocalConnectionState.Stopped)
		{
			return;
		}
		ga ga = ga.kub;
		if (ga != null && ga.kuc)
		{
			return;
		}
		CSteamID csteamID = this.irc.ddn();
		if (!csteamID.IsValid())
		{
			return;
		}
		if (InstanceFinder.ClientManager == null)
		{
			return;
		}
		fq.dbg(string.Format(a.dvl(), csteamID.m_SteamID));
		InstanceFinder.ClientManager.StartConnection(csteamID.m_SteamID.ToString());
	}

	// Token: 0x0600140D RID: 5133 RVA: 0x0006284D File Offset: 0x00060A4D
	private void jov(CSteamID a)
	{
		this.dar(a);
	}

	// Token: 0x0600140E RID: 5134 RVA: 0x0006284D File Offset: 0x00060A4D
	private void daz(CSteamID a)
	{
		this.dar(a);
	}

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x0600140F RID: 5135 RVA: 0x00062ECA File Offset: 0x000610CA
	public static fp kto
	{
		get
		{
			return fp.irb;
		}
	}

	// Token: 0x06001410 RID: 5136 RVA: 0x000626C9 File Offset: 0x000608C9
	public void mti(CSteamID a)
	{
		ga ga = ga.kub;
		if (ga != null)
		{
			ga.dfu();
		}
		this.dap();
		if (this.irc == null)
		{
			return;
		}
		this.irc.ddl(a);
	}

	// Token: 0x06001412 RID: 5138 RVA: 0x0006284D File Offset: 0x00060A4D
	private void nih(CSteamID a)
	{
		this.dar(a);
	}

	// Token: 0x06001413 RID: 5139 RVA: 0x00062EFC File Offset: 0x000610FC
	public void dyk()
	{
		if (this.ire)
		{
			return;
		}
		this.ire = true;
		try
		{
			this.dbd();
			if (this.irc != null)
			{
				this.irc.ddm();
			}
		}
		finally
		{
			this.ire = false;
		}
		ga ga = ga.kub;
		if (ga == null)
		{
			return;
		}
		ga.dfv();
	}

	// Token: 0x06001414 RID: 5140 RVA: 0x0006284D File Offset: 0x00060A4D
	private void cdq(CSteamID a)
	{
		this.dar(a);
	}

	// Token: 0x06001415 RID: 5141 RVA: 0x00062F64 File Offset: 0x00061164
	private void nsg()
	{
		this.irc = fv.kts;
		if (this.irc != null)
		{
			this.irc.ism += this.dax;
			this.irc.isn += this.day;
			this.irc.iso += this.dbb;
			this.irc.iss += this.daz;
			this.irc.isq += this.dba;
		}
		else
		{
			Debug.LogWarning(a.dvm());
		}
		this.dap();
	}

	// Token: 0x06001416 RID: 5142 RVA: 0x00063010 File Offset: 0x00061210
	public void bft()
	{
		if (this.ire)
		{
			return;
		}
		this.ire = true;
		try
		{
			this.dbd();
			if (this.irc != null)
			{
				this.irc.ddm();
			}
		}
		finally
		{
			this.ire = false;
		}
		ga ga = ga.kub;
		if (ga == null)
		{
			return;
		}
		ga.dfv();
	}

	// Token: 0x06001417 RID: 5143 RVA: 0x00063078 File Offset: 0x00061278
	private void fgm()
	{
		if (this.irf)
		{
			return;
		}
		ClientManager clientManager = InstanceFinder.ClientManager;
		if (clientManager == null)
		{
			return;
		}
		clientManager.OnClientConnectionState += this.dbe;
		this.irf = true;
	}

	// Token: 0x06001418 RID: 5144 RVA: 0x000630B8 File Offset: 0x000612B8
	private void hcr()
	{
		this.irc = fv.kts;
		if (this.irc != null)
		{
			this.irc.ism += this.dax;
			this.irc.isn += this.day;
			this.irc.iso += this.dbb;
			this.irc.iss += this.daz;
			this.irc.isq += this.dba;
		}
		else
		{
			Debug.LogWarning(a.dvn());
		}
		this.dap();
	}

	// Token: 0x06001419 RID: 5145 RVA: 0x00061D2E File Offset: 0x0005FF2E
	private void hnk()
	{
		this.dbc();
	}

	// Token: 0x0600141A RID: 5146 RVA: 0x00063163 File Offset: 0x00061363
	public void cjj()
	{
		ga ga = ga.kub;
		if (ga != null)
		{
			ga.dfu();
		}
		this.dap();
		if (this.irc == null)
		{
			Debug.LogWarning(a.dvo());
			return;
		}
		this.irc.ddk();
	}

	// Token: 0x0600141B RID: 5147 RVA: 0x000631A0 File Offset: 0x000613A0
	private void dbc()
	{
		if (!this.ird || this.ire || this.irc == null || !this.irc.ktv || !this.irc.ktw)
		{
			fm fm = this.irj;
			if (fm == null)
			{
				return;
			}
			fm.czy();
			return;
		}
		else if (!SteamManager.krd || SteamManager.ibh)
		{
			fm fm2 = this.irj;
			if (fm2 == null)
			{
				return;
			}
			fm2.czy();
			return;
		}
		else
		{
			if (Time.unscaledTime < this.irk)
			{
				return;
			}
			this.irk = Time.unscaledTime + 5f;
			List<CSteamID> list = this.irc.ddp();
			this.irl.Clear();
			for (int i = 0; i < list.Count; i++)
			{
				this.irl.Add(list[i].m_SteamID);
			}
			if (!this.irl.Contains(SteamUser.GetSteamID().m_SteamID))
			{
				fm fm3 = this.irj;
				if (fm3 == null)
				{
					return;
				}
				fm3.czy();
				return;
			}
			else
			{
				ServerManager serverManager = InstanceFinder.ServerManager;
				if (!(serverManager == null))
				{
					this.irm.Clear();
					this.irn.Clear();
					foreach (KeyValuePair<int, NetworkConnection> keyValuePair in serverManager.Clients)
					{
						NetworkConnection value = keyValuePair.Value;
						if (!(value == null) && !value.IsLocalClient)
						{
							ulong num = NetworkPlayer.djk(value);
							if (num != 0UL)
							{
								this.irm.Add(num);
								this.irn[num] = value;
							}
						}
					}
					if (this.irj == null)
					{
						this.irj = new fm(20f);
					}
					List<ulong> list2 = this.irj.czx(this.irl, this.irm, Time.unscaledTime);
					for (int j = 0; j < list2.Count; j++)
					{
						NetworkConnection networkConnection;
						if (this.irn.TryGetValue(list2[j], out networkConnection))
						{
							fq.dbg(string.Format(a.dvp(), 20f, list2[j]));
							NetworkObject firstObject = networkConnection.FirstObject;
							NetworkPlayer networkPlayer = ((firstObject != null) ? firstObject.GetComponent<NetworkPlayer>() : null);
							if (networkPlayer == null || !networkPlayer.djv())
							{
								networkConnection.Disconnect(false);
							}
						}
					}
					return;
				}
				fm fm4 = this.irj;
				if (fm4 == null)
				{
					return;
				}
				fm4.czy();
				return;
			}
		}
	}

	// Token: 0x0600141C RID: 5148 RVA: 0x00063420 File Offset: 0x00061620
	public void isl(CSteamID a = default(CSteamID))
	{
		this.dap();
		if (this.irc == null || !this.irc.ktv)
		{
			return;
		}
		CSteamID csteamID = (a.IsValid() ? a : this.irc.ddn());
		if (!csteamID.IsValid())
		{
			fq.dbg(a.dvq());
			return;
		}
		if (InstanceFinder.ClientManager != null)
		{
			fq.dbg(string.Format(a.dvr(), csteamID.m_SteamID));
			InstanceFinder.ClientManager.StartConnection(csteamID.m_SteamID.ToString());
		}
	}

	// Token: 0x0600141D RID: 5149 RVA: 0x000634BC File Offset: 0x000616BC
	private void dax(CSteamID a)
	{
		this.dap();
		fq.dbg(string.Format(a.dvs(), a.m_SteamID));
		if (InstanceFinder.ServerManager != null)
		{
			InstanceFinder.ServerManager.StartConnection();
			this.ird = true;
		}
		if (InstanceFinder.ClientManager != null)
		{
			InstanceFinder.ClientManager.StartConnection();
		}
	}

	// Token: 0x0600141E RID: 5150 RVA: 0x00061D2E File Offset: 0x0005FF2E
	private void Update()
	{
		this.dbc();
	}

	// Token: 0x04000A5F RID: 2655
	private static fp irb;

	// Token: 0x04000A60 RID: 2656
	private fv irc;

	// Token: 0x04000A61 RID: 2657
	private bool ird;

	// Token: 0x04000A62 RID: 2658
	private bool ire;

	// Token: 0x04000A63 RID: 2659
	private bool irf;

	// Token: 0x04000A64 RID: 2660
	private LocalConnectionState irg;

	// Token: 0x04000A65 RID: 2661
	private const float irh = 5f;

	// Token: 0x04000A66 RID: 2662
	private const float iri = 20f;

	// Token: 0x04000A67 RID: 2663
	private fm irj;

	// Token: 0x04000A68 RID: 2664
	private float irk;

	// Token: 0x04000A69 RID: 2665
	private readonly HashSet<ulong> irl = new HashSet<ulong>();

	// Token: 0x04000A6A RID: 2666
	private readonly List<ulong> irm = new List<ulong>();

	// Token: 0x04000A6B RID: 2667
	private readonly Dictionary<ulong, NetworkConnection> irn = new Dictionary<ulong, NetworkConnection>();
}
