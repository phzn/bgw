using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BongoWaifu.Multiplayer
{
	// Token: 0x02000118 RID: 280
	public sealed class MultiplayerFriendListWindow : MonoBehaviour
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x00063BC3 File Offset: 0x00061DC3
		public bool ktp
		{
			get
			{
				return this.windowRoot != null && this.listContainer != null && this.rowTemplate != null;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x00063BEF File Offset: 0x00061DEF
		public bool ktq
		{
			get
			{
				return this.windowRoot != null && this.windowRoot.activeSelf && this.irx == MultiplayerFriendListWindow.Mode.Invite;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x00063C17 File Offset: 0x00061E17
		public bool ktr
		{
			get
			{
				return this.windowRoot != null && this.windowRoot.activeSelf && this.irx == MultiplayerFriendListWindow.Mode.Join;
			}
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00063C3F File Offset: 0x00061E3F
		private void Awake()
		{
			this.dbp();
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00063C48 File Offset: 0x00061E48
		private void dbp()
		{
			if (this.iry)
			{
				return;
			}
			this.iry = true;
			if (this.btnClose != null)
			{
				this.btnClose.onClick.AddListener(new UnityAction(this.Close));
			}
			if (this.rowTemplate != null)
			{
				this.rowTemplate.gameObject.SetActive(false);
			}
			MultiplayerSession.iva += this.dbs;
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00063CBF File Offset: 0x00061EBF
		private void OnDestroy()
		{
			if (this.iry)
			{
				MultiplayerSession.iva -= this.dbs;
			}
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00063CDC File Offset: 0x00061EDC
		public void dbq()
		{
			fv fv = fv.kts;
			if (fv == null || !fv.ktv)
			{
				return;
			}
			this.irx = MultiplayerFriendListWindow.Mode.Invite;
			this.Open();
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00063D0E File Offset: 0x00061F0E
		public void dbr()
		{
			this.irx = MultiplayerFriendListWindow.Mode.Join;
			this.Open();
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x00063D1D File Offset: 0x00061F1D
		public void Close()
		{
			this.dby();
			if (this.windowRoot != null)
			{
				this.windowRoot.SetActive(false);
			}
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00063D3F File Offset: 0x00061F3F
		private void dbs()
		{
			if (this.windowRoot != null && this.windowRoot.activeSelf)
			{
				this.Close();
			}
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x00063D64 File Offset: 0x00061F64
		private void Open()
		{
			this.dbp();
			if (!this.ktp)
			{
				fq.dbg(a.dxn());
				return;
			}
			this.windowRoot.SetActive(true);
			if (this.titleText != null)
			{
				this.titleText.text = ((this.irx == MultiplayerFriendListWindow.Mode.Invite) ? MultiplayerLoc.Get(a.dxq(), a.dxr()) : MultiplayerLoc.Get(a.dxo(), a.dxp()));
			}
			this.dbt();
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00063DE0 File Offset: 0x00061FE0
		private void dbt()
		{
			this.dby();
			if (SteamManager.krd)
			{
				if (this.irx == MultiplayerFriendListWindow.Mode.Invite)
				{
					this.dbu();
				}
				else
				{
					this.dbv();
				}
			}
			bool flag = this.irw.Count == 0;
			if (this.emptyText != null)
			{
				this.emptyText.gameObject.SetActive(flag);
				if (flag)
				{
					this.emptyText.text = ((this.irx == MultiplayerFriendListWindow.Mode.Invite) ? MultiplayerLoc.Get(a.dxu(), a.dxv()) : MultiplayerLoc.Get(a.dxs(), a.dxt()));
				}
			}
			fq.dbg(string.Format(a.dxw(), this.irx, this.irw.Count));
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00063EA0 File Offset: 0x000620A0
		private void dbu()
		{
			MultiplayerFriendListWindow.fr fr = new MultiplayerFriendListWindow.fr();
			fv fv = fv.kts;
			if (fv == null || !fv.ktv)
			{
				return;
			}
			fr.irp = fv.ktu;
			fr.irq = MultiplayerLoc.Get(a.dxx(), a.dxy());
			int friendCount = SteamFriends.GetFriendCount(EFriendFlags.k_EFriendFlagImmediate);
			for (int i = 0; i < friendCount; i++)
			{
				MultiplayerFriendListWindow.fs fs = new MultiplayerFriendListWindow.fs();
				fs.irt = fr;
				CSteamID friendByIndex = SteamFriends.GetFriendByIndex(i, EFriendFlags.k_EFriendFlagImmediate);
				if (SteamFriends.GetFriendPersonaState(friendByIndex) != EPersonaState.k_EPersonaStateOffline)
				{
					MultiplayerFriendRow multiplayerFriendRow = this.dbx();
					fs.irr = friendByIndex;
					fs.irs = multiplayerFriendRow;
					multiplayerFriendRow.dcc(MultiplayerFriendListWindow.dbw(friendByIndex), new Action(fs.dbk), true, true);
				}
			}
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x00063F58 File Offset: 0x00062158
		private void dbv()
		{
			AppId_t appID = SteamUtils.GetAppID();
			int friendCount = SteamFriends.GetFriendCount(EFriendFlags.k_EFriendFlagImmediate);
			for (int i = 0; i < friendCount; i++)
			{
				MultiplayerFriendListWindow.ft ft = new MultiplayerFriendListWindow.ft();
				ft.irv = this;
				CSteamID friendByIndex = SteamFriends.GetFriendByIndex(i, EFriendFlags.k_EFriendFlagImmediate);
				FriendGameInfo_t friendGameInfo_t;
				if (SteamFriends.GetFriendGamePlayed(friendByIndex, out friendGameInfo_t) && !(friendGameInfo_t.m_gameID.AppID() != appID) && friendGameInfo_t.m_steamIDLobby.IsValid())
				{
					MultiplayerFriendRow multiplayerFriendRow = this.dbx();
					ft.iru = friendGameInfo_t.m_steamIDLobby;
					multiplayerFriendRow.dcc(MultiplayerFriendListWindow.dbw(friendByIndex), new Action(ft.dbl), true, true);
				}
			}
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00063FF0 File Offset: 0x000621F0
		public static string dbw(CSteamID a)
		{
			string friendPersonaName = SteamFriends.GetFriendPersonaName(a);
			if (!string.IsNullOrEmpty(friendPersonaName) && friendPersonaName != a.dxz())
			{
				return friendPersonaName;
			}
			SteamFriends.RequestUserInformation(a, true);
			return MultiplayerLoc.Get(a.dya(), a.dyb());
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x00064034 File Offset: 0x00062234
		private MultiplayerFriendRow dbx()
		{
			MultiplayerFriendRow multiplayerFriendRow = global::UnityEngine.Object.Instantiate<MultiplayerFriendRow>(this.rowTemplate, this.listContainer);
			multiplayerFriendRow.gameObject.SetActive(true);
			this.irw.Add(multiplayerFriendRow);
			return multiplayerFriendRow;
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0006406C File Offset: 0x0006226C
		private void dby()
		{
			foreach (MultiplayerFriendRow multiplayerFriendRow in this.irw)
			{
				if (multiplayerFriendRow != null)
				{
					global::UnityEngine.Object.Destroy(multiplayerFriendRow.gameObject);
				}
			}
			this.irw.Clear();
		}

		// Token: 0x04000A6D RID: 2669
		[SerializeField]
		private GameObject windowRoot;

		// Token: 0x04000A6E RID: 2670
		[SerializeField]
		private TMP_Text titleText;

		// Token: 0x04000A6F RID: 2671
		[SerializeField]
		private TMP_Text emptyText;

		// Token: 0x04000A70 RID: 2672
		[SerializeField]
		private Button btnClose;

		// Token: 0x04000A71 RID: 2673
		[SerializeField]
		private Transform listContainer;

		// Token: 0x04000A72 RID: 2674
		[SerializeField]
		private MultiplayerFriendRow rowTemplate;

		// Token: 0x04000A73 RID: 2675
		private readonly List<MultiplayerFriendRow> irw = new List<MultiplayerFriendRow>();

		// Token: 0x04000A74 RID: 2676
		private MultiplayerFriendListWindow.Mode irx;

		// Token: 0x04000A75 RID: 2677
		private bool iry;

		// Token: 0x02000119 RID: 281
		private enum Mode
		{
			// Token: 0x04000A77 RID: 2679
			Invite,
			// Token: 0x04000A78 RID: 2680
			Join
		}

		// Token: 0x0200011A RID: 282
		[CompilerGenerated]
		private sealed class fr
		{
			// Token: 0x04000A79 RID: 2681
			public CSteamID irp;

			// Token: 0x04000A7A RID: 2682
			public string irq;
		}

		// Token: 0x0200011B RID: 283
		[CompilerGenerated]
		private sealed class fs
		{
			// Token: 0x06001447 RID: 5191 RVA: 0x000640EB File Offset: 0x000622EB
			internal void dka()
			{
				if (SteamMatchmaking.InviteUserToLobby(this.irt.irp, this.irr))
				{
					this.irs.dcd(this.irt.irq, false);
				}
			}

			// Token: 0x06001448 RID: 5192 RVA: 0x000640EB File Offset: 0x000622EB
			internal void dbk()
			{
				if (SteamMatchmaking.InviteUserToLobby(this.irt.irp, this.irr))
				{
					this.irs.dcd(this.irt.irq, false);
				}
			}

			// Token: 0x06001449 RID: 5193 RVA: 0x000640EB File Offset: 0x000622EB
			internal void buv()
			{
				if (SteamMatchmaking.InviteUserToLobby(this.irt.irp, this.irr))
				{
					this.irs.dcd(this.irt.irq, false);
				}
			}

			// Token: 0x0600144A RID: 5194 RVA: 0x000640EB File Offset: 0x000622EB
			internal void omz()
			{
				if (SteamMatchmaking.InviteUserToLobby(this.irt.irp, this.irr))
				{
					this.irs.dcd(this.irt.irq, false);
				}
			}

			// Token: 0x04000A7B RID: 2683
			public CSteamID irr;

			// Token: 0x04000A7C RID: 2684
			public MultiplayerFriendRow irs;

			// Token: 0x04000A7D RID: 2685
			public MultiplayerFriendListWindow.fr irt;
		}

		// Token: 0x0200011C RID: 284
		[CompilerGenerated]
		private sealed class ft
		{
			// Token: 0x0600144C RID: 5196 RVA: 0x0006411C File Offset: 0x0006231C
			internal void few()
			{
				if (fp.kto != null)
				{
					fp.kto.dar(this.iru);
				}
				this.irv.Close();
			}

			// Token: 0x0600144D RID: 5197 RVA: 0x0006411C File Offset: 0x0006231C
			internal void njp()
			{
				if (fp.kto != null)
				{
					fp.kto.dar(this.iru);
				}
				this.irv.Close();
			}

			// Token: 0x0600144E RID: 5198 RVA: 0x0006411C File Offset: 0x0006231C
			internal void dbl()
			{
				if (fp.kto != null)
				{
					fp.kto.dar(this.iru);
				}
				this.irv.Close();
			}

			// Token: 0x0600144F RID: 5199 RVA: 0x0006411C File Offset: 0x0006231C
			internal void mpl()
			{
				if (fp.kto != null)
				{
					fp.kto.dar(this.iru);
				}
				this.irv.Close();
			}

			// Token: 0x04000A7E RID: 2686
			public CSteamID iru;

			// Token: 0x04000A7F RID: 2687
			public MultiplayerFriendListWindow irv;
		}
	}
}
