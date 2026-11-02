using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace BongoWaifu.Multiplayer
{
	// Token: 0x02000121 RID: 289
	public sealed class MultiplayerPanelController : MonoBehaviour
	{
		// Token: 0x060014C5 RID: 5317 RVA: 0x000668BC File Offset: 0x00064ABC
		private void Awake()
		{
			if (this.btnCreate != null)
			{
				this.btnCreate.onClick.AddListener(new UnityAction(this.deb));
			}
			if (this.btnLeave != null)
			{
				this.btnLeave.onClick.AddListener(new UnityAction(this.dec));
			}
			if (this.btnInvite != null)
			{
				this.btnInvite.onClick.AddListener(new UnityAction(this.ded));
			}
			if (this.btnJoin != null)
			{
				this.btnJoin.onClick.AddListener(new UnityAction(this.dee));
			}
			if (this.btnMuteAll != null)
			{
				this.btnMuteAll.onClick.AddListener(new UnityAction(this.dep));
			}
			if (this.btnPokeToggle != null)
			{
				this.btnPokeToggle.onValueChanged.AddListener(new UnityAction<bool>(this.der));
			}
			if (this.autoRejoinToggle != null)
			{
				this.autoRejoinToggle.onValueChanged.AddListener(new UnityAction<bool>(this.det));
			}
			if (this.autoHostToggle != null)
			{
				this.autoHostToggle.onValueChanged.AddListener(new UnityAction<bool>(this.deu));
			}
			if (this.inputCustomText != null)
			{
				this.inputCustomText.characterLimit = 40;
				this.inputCustomText.onEndEdit.AddListener(new UnityAction<string>(this.dev));
			}
			if (this.btnResetCustomText != null)
			{
				this.btnResetCustomText.onClick.AddListener(new UnityAction(this.dew));
			}
			if (this.memberRowTemplate != null)
			{
				this.memberRowTemplate.gameObject.SetActive(false);
			}
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00066A9C File Offset: 0x00064C9C
		private void OnEnable()
		{
			this.deh();
			MultiplayerSession.iva += this.dek;
			MultiplayerSession.ivc += this.def;
			MultiplayerSession.ivd += this.def;
			MultiplayerSession.ivi += this.dek;
			fv fv = fv.kts;
			if (fv != null)
			{
				fv.isq += this.dek;
				fv.isr += this.deg;
			}
			ga ga = ga.kub;
			if (ga != null)
			{
				ga.iui += this.dek;
			}
			this.dek();
			LocalizationSettings.InitializationOperation.Completed += this.dea;
			LocalizationSettings.SelectedLocaleChanged += this.ddz;
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00066B77 File Offset: 0x00064D77
		private void ddz(Locale a)
		{
			if (this == null || !base.isActiveAndEnabled)
			{
				return;
			}
			this.deh();
			this.dek();
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00066B77 File Offset: 0x00064D77
		private void dea(AsyncOperationHandle<LocalizationSettings> a)
		{
			if (this == null || !base.isActiveAndEnabled)
			{
				return;
			}
			this.deh();
			this.dek();
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00066B98 File Offset: 0x00064D98
		private void OnDisable()
		{
			if (this.friendListWindow != null)
			{
				this.friendListWindow.Close();
			}
			LocalizationSettings.InitializationOperation.Completed -= this.dea;
			LocalizationSettings.SelectedLocaleChanged -= this.ddz;
			MultiplayerSession.iva -= this.dek;
			MultiplayerSession.ivc -= this.def;
			MultiplayerSession.ivd -= this.def;
			MultiplayerSession.ivi -= this.dek;
			fv fv = fv.kts;
			if (fv != null)
			{
				fv.isq -= this.dek;
				fv.isr -= this.deg;
			}
			ga ga = ga.kub;
			if (ga != null)
			{
				ga.iui -= this.dek;
			}
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00066C80 File Offset: 0x00064E80
		private void deb()
		{
			if (fp.kto != null)
			{
				fp.kto.daq();
			}
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x00066C99 File Offset: 0x00064E99
		private void dec()
		{
			if (fp.kto != null)
			{
				fp.kto.dau();
			}
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00066CB4 File Offset: 0x00064EB4
		private void ded()
		{
			fv fv = fv.kts;
			if (fv == null || !fv.ktv)
			{
				return;
			}
			if (!(this.friendListWindow != null) || !this.friendListWindow.ktp)
			{
				SteamFriends.ActivateGameOverlayInviteDialog(fv.ktu);
				return;
			}
			if (this.friendListWindow.ktq)
			{
				this.friendListWindow.Close();
				return;
			}
			this.friendListWindow.dbq();
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x00066D24 File Offset: 0x00064F24
		private void dee()
		{
			if (!(this.friendListWindow != null) || !this.friendListWindow.ktp)
			{
				fq.dbg(a.ebu());
				return;
			}
			if (this.friendListWindow.ktr)
			{
				this.friendListWindow.Close();
				return;
			}
			this.friendListWindow.dbr();
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x00066D7B File Offset: 0x00064F7B
		private void def(gb a)
		{
			this.dek();
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00066D83 File Offset: 0x00064F83
		private void deg(string a)
		{
			if (this.statusText != null)
			{
				this.statusText.text = a;
			}
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00066DA0 File Offset: 0x00064FA0
		private void deh()
		{
			MultiplayerPanelController.dej(this.btnCreate, a.ebv(), a.ebw(), a.ebx(), a.eby());
			MultiplayerPanelController.dej(this.btnLeave, a.ebz(), a.eca(), a.ecb(), a.ecc());
			MultiplayerPanelController.dej(this.btnInvite, a.ecd(), a.dxr(), a.ece(), a.ecf());
			MultiplayerPanelController.dej(this.btnJoin, a.ecg(), a.ech(), a.eci(), a.ecj());
			this.dei();
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00066E30 File Offset: 0x00065030
		private void dei()
		{
			if (this.inputCustomText != null)
			{
				TMP_Text tmp_Text = this.inputCustomText.placeholder as TMP_Text;
				if (tmp_Text != null)
				{
					tmp_Text.text = MpInteractionEffects.czq(NetworkPlayer.djg());
				}
			}
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00066E70 File Offset: 0x00065070
		private static void dej(Button a, string b, string c, string d, string e)
		{
			if (a == null)
			{
				return;
			}
			Transform transform = a.transform.Find(a.eck());
			TMP_Text tmp_Text;
			if (transform != null && transform.TryGetComponent<TMP_Text>(out tmp_Text))
			{
				tmp_Text.text = MultiplayerLoc.Get(b, c);
			}
			Transform transform2 = a.transform.Find(a.ecl());
			bb bb;
			if (transform2 != null && transform2.TryGetComponent<bb>(out bb) && bb.tipContect != null)
			{
				bb.vh(MultiplayerLoc.Get(d, e));
			}
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00066EF8 File Offset: 0x000650F8
		private void dek()
		{
			this.iti = true;
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00066F01 File Offset: 0x00065101
		private void Update()
		{
			if (!this.iti)
			{
				return;
			}
			this.iti = false;
			this.del();
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00066F1C File Offset: 0x0006511C
		private void del()
		{
			bool flag = MultiplayerSession.iuw;
			fv fv = fv.kts;
			bool flag2 = !flag && fv != null && fv.ktv;
			if (this.btnCreate != null)
			{
				this.btnCreate.gameObject.SetActive(!flag && !flag2);
			}
			if (this.btnJoin != null)
			{
				this.btnJoin.gameObject.SetActive(!flag && !flag2);
			}
			if (this.btnLeave != null)
			{
				this.btnLeave.gameObject.SetActive(flag || flag2);
			}
			if (this.btnInvite != null)
			{
				this.btnInvite.gameObject.SetActive(flag);
			}
			bool flag3 = ga.kub != null && ga.kub.kud;
			if (this.statusText != null)
			{
				this.statusText.text = (flag3 ? MultiplayerLoc.Get(a.ecq(), a.ecr()) : (flag ? MultiplayerPanelController.dez() : (flag2 ? MultiplayerLoc.Get(a.eco(), a.ecp()) : MultiplayerLoc.Get(a.ecm(), a.ecn()))));
			}
			if (this.autoRejoinToggle != null)
			{
				this.autoRejoinToggle.gameObject.SetActive(flag && !MultiplayerSession.kuo);
				this.autoRejoinToggle.SetIsOnWithoutNotify(ga.kue);
			}
			if (this.autoHostToggle != null)
			{
				this.autoHostToggle.gameObject.SetActive(flag && MultiplayerSession.kuo);
				this.autoHostToggle.SetIsOnWithoutNotify(ga.kuf);
			}
			if (this.btnMuteAll != null)
			{
				this.btnMuteAll.gameObject.SetActive(flag);
			}
			this.deq();
			if (this.btnPokeToggle != null)
			{
				this.btnPokeToggle.gameObject.SetActive(flag && MultiplayerSession.kuo);
			}
			this.des();
			if (this.inputCustomText != null && !this.inputCustomText.isFocused)
			{
				this.inputCustomText.SetTextWithoutNotify(fi.kth);
			}
			this.dem(flag);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0006714C File Offset: 0x0006534C
		private void dem(bool a)
		{
			if (!(this.memberListContainer != null) || !(this.memberRowTemplate != null))
			{
				if (this.memberListText != null)
				{
					this.memberListText.text = (a ? MultiplayerPanelController.dfa() : string.Empty);
				}
				return;
			}
			if (this.memberListText != null)
			{
				this.memberListText.text = string.Empty;
			}
			this.dex();
			if (a)
			{
				this.den();
			}
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x000671D0 File Offset: 0x000653D0
		private void den()
		{
			fv fv = fv.kts;
			if (fv == null)
			{
				return;
			}
			bool flag = fv.ktw;
			CSteamID csteamID = (SteamManager.krd ? SteamUser.GetSteamID() : CSteamID.Nil);
			string text = MultiplayerLoc.Get(a.ecs(), a.ect());
			List<CSteamID> list = fv.ddp();
			for (int i = 0; i < list.Count; i++)
			{
				MultiplayerPanelController.fw fw = new MultiplayerPanelController.fw();
				fw.itg = this;
				CSteamID csteamID2 = list[i];
				bool flag2 = SteamManager.krd && csteamID2 == csteamID;
				string text2 = MultiplayerFriendListWindow.dbw(csteamID2);
				if (flag2)
				{
					text2 = string.Format(text, text2);
				}
				MultiplayerFriendRow multiplayerFriendRow = global::UnityEngine.Object.Instantiate<MultiplayerFriendRow>(this.memberRowTemplate, this.memberListContainer);
				multiplayerFriendRow.gameObject.SetActive(true);
				this.ith.Add(multiplayerFriendRow);
				fw.itf = csteamID2;
				multiplayerFriendRow.dcc(text2, new Action(fw.ddx), flag && !flag2, true);
				multiplayerFriendRow.dce(fw.itf.m_SteamID, gc.dmu(fw.itf.m_SteamID), new Action(fw.ddy), !flag2);
				gb gb;
				Color color = (flag2 ? MultiplayerSession.kul : (MultiplayerSession.dip(fw.itf.m_SteamID, out gb) ? gb.iuv : Color.white));
				multiplayerFriendRow.dcg(color);
			}
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00067348 File Offset: 0x00065548
		private void deo(ulong a)
		{
			bool flag = !gc.dmu(a);
			gc.dmv(a, flag);
			for (int i = 0; i < this.ith.Count; i++)
			{
				if (this.ith[i] != null && this.ith[i].irz == a)
				{
					this.ith[i].dcf(flag);
				}
			}
			fq.dbg(string.Format(a.ecu(), a, flag));
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x000673D1 File Offset: 0x000655D1
		private void dep()
		{
			gc.kvd = !gc.kvd;
			this.deq();
			fq.dbg(string.Format(a.ecv(), gc.kvd));
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x00067400 File Offset: 0x00065600
		private void deq()
		{
			bool flag = gc.kvd;
			if (this.muteAllIconOn != null)
			{
				this.muteAllIconOn.SetActive(flag);
			}
			if (this.muteAllIconOff != null)
			{
				this.muteAllIconOff.SetActive(!flag);
			}
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0006744A File Offset: 0x0006564A
		private void der(bool a)
		{
			MultiplayerSession.dhq(a);
			fq.dbg(string.Format(a.ecw(), a));
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00067467 File Offset: 0x00065667
		private void des()
		{
			if (this.btnPokeToggle != null)
			{
				this.btnPokeToggle.SetIsOnWithoutNotify(MultiplayerSession.kum);
			}
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x00067487 File Offset: 0x00065687
		private void det(bool a)
		{
			ga.kue = a;
			fq.dbg(string.Format(a.ecx(), a));
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x000674A4 File Offset: 0x000656A4
		private void deu(bool a)
		{
			ga.kuf = a;
			fq.dbg(string.Format(a.ecy(), a));
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x000674C1 File Offset: 0x000656C1
		private void dev(string a)
		{
			fi.kth = a;
			MultiplayerSession.did(fi.kth);
			fq.dbg(string.Format(a.ecz(), fi.kth.Length));
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x000674F4 File Offset: 0x000656F4
		public void dew()
		{
			fi.kth = string.Empty;
			MultiplayerSession.did(string.Empty);
			if (this.inputCustomText != null)
			{
				this.inputCustomText.SetTextWithoutNotify(string.Empty);
			}
			this.dei();
			fq.dbg(a.eda());
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00067544 File Offset: 0x00065744
		private void dex()
		{
			foreach (MultiplayerFriendRow multiplayerFriendRow in this.ith)
			{
				if (multiplayerFriendRow != null)
				{
					global::UnityEngine.Object.Destroy(multiplayerFriendRow.gameObject);
				}
			}
			this.ith.Clear();
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x000675B0 File Offset: 0x000657B0
		private static void dey(CSteamID a)
		{
			IReadOnlyList<gb> readOnlyList = MultiplayerSession.kuk;
			for (int i = 0; i < readOnlyList.Count; i++)
			{
				if (readOnlyList[i].iul == a.m_SteamID)
				{
					MultiplayerSession.dig(readOnlyList[i]);
					return;
				}
			}
			fq.dbg(string.Format(a.edb(), a.m_SteamID));
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x00067610 File Offset: 0x00065810
		private static string dez()
		{
			fv fv = fv.kts;
			int num = ((fv != null) ? fv.ddp().Count : 0);
			return string.Format(MultiplayerLoc.Get(a.edc(), a.edd()), num, 16);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0006765C File Offset: 0x0006585C
		private static string dfa()
		{
			StringBuilder stringBuilder = new StringBuilder();
			fv fv = fv.kts;
			if (fv == null)
			{
				return string.Empty;
			}
			string text = MultiplayerLoc.Get(a.ecs(), a.ect());
			List<CSteamID> list = fv.ddp();
			for (int i = 0; i < list.Count; i++)
			{
				CSteamID csteamID = list[i];
				string text2 = (SteamManager.krd ? SteamFriends.GetFriendPersonaName(csteamID) : csteamID.ToString());
				bool flag = SteamManager.krd && csteamID == SteamUser.GetSteamID();
				stringBuilder.AppendLine(flag ? string.Format(text, text2) : text2);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000AA7 RID: 2727
		[SerializeField]
		private Button btnCreate;

		// Token: 0x04000AA8 RID: 2728
		[SerializeField]
		private Button btnLeave;

		// Token: 0x04000AA9 RID: 2729
		[SerializeField]
		private Button btnInvite;

		// Token: 0x04000AAA RID: 2730
		[SerializeField]
		private Button btnJoin;

		// Token: 0x04000AAB RID: 2731
		[SerializeField]
		private MultiplayerFriendListWindow friendListWindow;

		// Token: 0x04000AAC RID: 2732
		[SerializeField]
		private TMP_Text statusText;

		// Token: 0x04000AAD RID: 2733
		[SerializeField]
		private TMP_Text memberListText;

		// Token: 0x04000AAE RID: 2734
		[SerializeField]
		private Transform memberListContainer;

		// Token: 0x04000AAF RID: 2735
		[SerializeField]
		private MultiplayerFriendRow memberRowTemplate;

		// Token: 0x04000AB0 RID: 2736
		[SerializeField]
		private Button btnMuteAll;

		// Token: 0x04000AB1 RID: 2737
		[SerializeField]
		private GameObject muteAllIconOn;

		// Token: 0x04000AB2 RID: 2738
		[SerializeField]
		private GameObject muteAllIconOff;

		// Token: 0x04000AB3 RID: 2739
		[SerializeField]
		private Toggle btnPokeToggle;

		// Token: 0x04000AB4 RID: 2740
		[SerializeField]
		private Toggle autoRejoinToggle;

		// Token: 0x04000AB5 RID: 2741
		[SerializeField]
		private Toggle autoHostToggle;

		// Token: 0x04000AB6 RID: 2742
		[SerializeField]
		private TMP_InputField inputCustomText;

		// Token: 0x04000AB7 RID: 2743
		[SerializeField]
		private Button btnResetCustomText;

		// Token: 0x04000AB8 RID: 2744
		private readonly List<MultiplayerFriendRow> ith = new List<MultiplayerFriendRow>();

		// Token: 0x04000AB9 RID: 2745
		private bool iti;

		// Token: 0x02000122 RID: 290
		[CompilerGenerated]
		private sealed class fw
		{
			// Token: 0x060014E6 RID: 5350 RVA: 0x00067721 File Offset: 0x00065921
			internal void omk()
			{
				this.itg.deo(this.itf.m_SteamID);
			}

			// Token: 0x060014E8 RID: 5352 RVA: 0x00067739 File Offset: 0x00065939
			internal void kst()
			{
				MultiplayerPanelController.dey(this.itf);
			}

			// Token: 0x060014E9 RID: 5353 RVA: 0x00067739 File Offset: 0x00065939
			internal void hvl()
			{
				MultiplayerPanelController.dey(this.itf);
			}

			// Token: 0x060014EA RID: 5354 RVA: 0x00067721 File Offset: 0x00065921
			internal void ddy()
			{
				this.itg.deo(this.itf.m_SteamID);
			}

			// Token: 0x060014EB RID: 5355 RVA: 0x00067739 File Offset: 0x00065939
			internal void idl()
			{
				MultiplayerPanelController.dey(this.itf);
			}

			// Token: 0x060014EC RID: 5356 RVA: 0x00067739 File Offset: 0x00065939
			internal void dfh()
			{
				MultiplayerPanelController.dey(this.itf);
			}

			// Token: 0x060014ED RID: 5357 RVA: 0x00067739 File Offset: 0x00065939
			internal void ddx()
			{
				MultiplayerPanelController.dey(this.itf);
			}

			// Token: 0x04000ABA RID: 2746
			public CSteamID itf;

			// Token: 0x04000ABB RID: 2747
			public MultiplayerPanelController itg;
		}
	}
}
