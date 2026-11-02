using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using BongoWaifu.AiApi;
using BongoWaifu.Mcp;
using BongoWaifu.Multiplayer;
using FishySteamworks;
using GlobalKeyboardHook;
using Kirurobo;
using RamenCat;
using Rewired;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000039 RID: 57
public class bx : MonoBehaviour
{
	// Token: 0x0600035F RID: 863 RVA: 0x00010244 File Offset: 0x0000E444
	private void bcp(int a)
	{
		if (!bq.hlw)
		{
			return;
		}
		bl bl = bl.kmv;
		if (bl == null)
		{
			return;
		}
		bl.xt();
	}

	// Token: 0x06000360 RID: 864 RVA: 0x0001025D File Offset: 0x0000E45D
	private IEnumerator bch(YieldInstruction a, Action b)
	{
		yield return a;
		if (b != null)
		{
			b();
		}
		yield break;
	}

	// Token: 0x06000361 RID: 865 RVA: 0x00010273 File Offset: 0x0000E473
	private void dye(int a)
	{
		this.text_Number.text = a.ToString();
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06000362 RID: 866 RVA: 0x00010287 File Offset: 0x0000E487
	public int koc
	{
		get
		{
			return bq.knf;
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x06000363 RID: 867 RVA: 0x0001028E File Offset: 0x0000E48E
	public bool kod
	{
		get
		{
			return bq.knc || (SteamManager.krd && bq.hmf);
		}
	}

	// Token: 0x06000364 RID: 868 RVA: 0x000102A8 File Offset: 0x0000E4A8
	private bool nrs(CLOTHE_TYPE a)
	{
		global::PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		switch (a)
		{
		case CLOTHE_TYPE.Dick:
			return playerSaveData.desiredDickUse == 0;
		case CLOTHE_TYPE.Hair:
			return playerSaveData.desiredHairUse == 0;
		case (CLOTHE_TYPE)2:
		case (CLOTHE_TYPE)6:
		case (CLOTHE_TYPE)7:
			break;
		case CLOTHE_TYPE.Top:
			return playerSaveData.desiredTopUse == 0;
		case CLOTHE_TYPE.Bottom:
			return playerSaveData.desiredBottomUse == 0;
		case CLOTHE_TYPE.Underwear:
			return playerSaveData.desiredUnderwearUse == 0;
		case CLOTHE_TYPE.Socks:
			return playerSaveData.desiredSocksUse == 0;
		case CLOTHE_TYPE.Shoes:
			return playerSaveData.desiredShoesUse == 0;
		default:
			switch (a)
			{
			case (CLOTHE_TYPE)27:
				return playerSaveData.desiredSkinToneUse == 0;
			case (CLOTHE_TYPE)28:
				return playerSaveData.desiredIntimatePartsUse == 0;
			case (CLOTHE_TYPE)29:
				return playerSaveData.desiredPubicAndGenitalUse == 0;
			}
			break;
		}
		return true;
	}

	// Token: 0x06000365 RID: 869 RVA: 0x0001036C File Offset: 0x0000E56C
	private void ndv(int a)
	{
		if (!bq.hlw)
		{
			return;
		}
		cx cx = cx.kpw;
		if (cx == null)
		{
			return;
		}
		cx.brj();
	}

	// Token: 0x06000366 RID: 870 RVA: 0x00010398 File Offset: 0x0000E598
	private void nsj(int a)
	{
		if (!bq.hlw)
		{
			return;
		}
		if (UniWindowController.current != null)
		{
			bx.bcc(UniWindowController.current.monitorToFit);
		}
		CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
		if (characterDragTarget != null)
		{
			characterDragTarget.bgy();
		}
		if (this.settingPanel != null)
		{
			this.settingPanel.caw();
		}
		BgmPanelController bgmPanelController = ((cx.kpw != null) ? cx.kpw.bgmPanel : null);
		if (bgmPanelController != null)
		{
			bgmPanelController.bmt();
		}
		IReadOnlyList<gb> readOnlyList = MultiplayerSession.kuk;
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			RemoteAvatarPlacement iuu = readOnlyList[i].iuu;
			if (iuu != null)
			{
				iuu.dnm();
			}
		}
	}

	// Token: 0x06000367 RID: 871 RVA: 0x0001044C File Offset: 0x0000E64C
	private void bdc(HashSet<int> a)
	{
		global::PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		if (!playerSaveData.hasInitializedKnownItems)
		{
			return;
		}
		bool flag = false;
		for (int i = playerSaveData.knownItemDefIds.Count - 1; i >= 0; i--)
		{
			int num = playerSaveData.knownItemDefIds[i];
			SpineSkinData spineSkinData = this.spineSkinSetting.bjx(num);
			if (spineSkinData != null && !bx.bbs(spineSkinData, a))
			{
				playerSaveData.knownItemDefIds.RemoveAt(i);
				playerSaveData.newItemDefIds.Remove(num);
				flag = true;
			}
		}
		for (int j = playerSaveData.newItemDefIds.Count - 1; j >= 0; j--)
		{
			int num2 = playerSaveData.newItemDefIds[j];
			SpineSkinData spineSkinData2 = this.spineSkinSetting.bjx(num2);
			bool flag2 = spineSkinData2 != null && bx.bbs(spineSkinData2, a);
			if (!flag2)
			{
				Debug.LogWarning(string.Format(a.sj(), num2, (spineSkinData2 != null) ? a.sl() : a.sk(), flag2));
				playerSaveData.newItemDefIds.RemoveAt(j);
				flag = true;
			}
		}
		if (flag)
		{
			ci.Save(null);
		}
	}

	// Token: 0x06000368 RID: 872 RVA: 0x00010564 File Offset: 0x0000E764
	private void jda(Dictionary<int, uint> a)
	{
		this.hoa.Clear();
		foreach (KeyValuePair<int, uint> keyValuePair in a)
		{
			this.hoa[keyValuePair.Key] = keyValuePair.Value;
		}
	}

	// Token: 0x06000369 RID: 873 RVA: 0x000105D0 File Offset: 0x0000E7D0
	private void oqo()
	{
		bx.hod = this;
		this.hof = Camera.main;
		bq.hlf = this.playerData;
		bq.hle = this.spineSkinSetting;
		bq.hlg = this.voiceConfig;
		dn.bxu(dn.bxt());
		q.tr();
		q.ts();
	}

	// Token: 0x0600036A RID: 874 RVA: 0x00010623 File Offset: 0x0000E823
	private void bcg(int a)
	{
		SteamInventoryManager.iid.cpp(a);
	}

	// Token: 0x0600036B RID: 875 RVA: 0x00010630 File Offset: 0x0000E830
	private static bool bcb(UniWindowController a)
	{
		if (a == null)
		{
			return false;
		}
		if (bx.hog == null)
		{
			bx.hog = typeof(UniWindowController).GetField(a.sm(), BindingFlags.Instance | BindingFlags.NonPublic);
			if (bx.hog == null)
			{
				Debug.LogWarning(a.sn());
				return false;
			}
		}
		object value = bx.hog.GetValue(a);
		if (value == null)
		{
			return false;
		}
		if (bx.hoh == null)
		{
			bx.hoh = value.GetType().GetProperty(a.so(), BindingFlags.Instance | BindingFlags.Public);
			if (bx.hoh == null)
			{
				Debug.LogWarning(a.sp());
				return false;
			}
		}
		bool flag;
		try
		{
			flag = (bool)bx.hoh.GetValue(value);
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.sq() + ex.Message);
			flag = false;
		}
		return flag;
	}

	// Token: 0x0600036C RID: 876 RVA: 0x00010718 File Offset: 0x0000E918
	private void isn()
	{
		if (this.hnh.GetButtonDown(a.sr()) || Input.anyKeyDown)
		{
			this.bci();
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x0600036D RID: 877 RVA: 0x0001073C File Offset: 0x0000E93C
	// (set) Token: 0x0600037F RID: 895 RVA: 0x000110D0 File Offset: 0x0000F2D0
	public Vector3 koe
	{
		get
		{
			if (this.hoe == Vector3.zero)
			{
				if (this.hof == null)
				{
					this.hof = Camera.main;
				}
				this.hoe = this.hof.transform.position;
			}
			return this.hoe;
		}
		set
		{
			this.hoe = value;
		}
	}

	// Token: 0x0600036E RID: 878 RVA: 0x00010790 File Offset: 0x0000E990
	private void bce()
	{
		if (this.hnh.GetButtonDown(a.ss()) || Input.anyKeyDown)
		{
			this.bci();
		}
	}

	// Token: 0x0600036F RID: 879 RVA: 0x000107B4 File Offset: 0x0000E9B4
	private void ipv(IReadOnlyList<ItemData> a)
	{
		if (a == null || a.Count == 0)
		{
			return;
		}
		List<ItemData> list = new List<ItemData>(bq.hlj);
		list.AddRange(a);
		bq.baq(list);
		foreach (ItemData itemData in a)
		{
			SpineSkinData spineSkinData = bq.hle.bjx(itemData.defID);
			if (spineSkinData != null)
			{
				if (!bx.hno.Contains(itemData.defID))
				{
					if (bq.knd)
					{
						Debug.Log(string.Format(a.st(), itemData.defID));
					}
				}
				else if (this.bcu(spineSkinData.type))
				{
					spineSkinData.bjp(true);
				}
				else
				{
					Debug.Log(string.Format(a.su(), itemData.defID, spineSkinData.type));
				}
			}
		}
		bq.hle.bkt();
		ci.Save(null);
		base.StartCoroutine(this.bcv());
	}

	// Token: 0x06000370 RID: 880 RVA: 0x000108C4 File Offset: 0x0000EAC4
	private void olc()
	{
		bx.hod = this;
		this.hof = Camera.main;
		bq.hlf = this.playerData;
		bq.hle = this.spineSkinSetting;
		bq.hlg = this.voiceConfig;
		dn.bxu(dn.bxt());
		q.tr();
		q.ts();
	}

	// Token: 0x06000371 RID: 881 RVA: 0x00010918 File Offset: 0x0000EB18
	private void bcm(int a)
	{
		if (!bq.hlw)
		{
			return;
		}
		if (UniWindowController.current != null)
		{
			bx.bcc(UniWindowController.current.monitorToFit);
		}
		CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
		if (characterDragTarget != null)
		{
			characterDragTarget.bgy();
		}
		if (this.settingPanel != null)
		{
			this.settingPanel.caw();
		}
		BgmPanelController bgmPanelController = ((cx.kpw != null) ? cx.kpw.bgmPanel : null);
		if (bgmPanelController != null)
		{
			bgmPanelController.bmt();
		}
		IReadOnlyList<gb> readOnlyList = MultiplayerSession.kuk;
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			RemoteAvatarPlacement iuu = readOnlyList[i].iuu;
			if (iuu != null)
			{
				iuu.dnm();
			}
		}
	}

	// Token: 0x06000372 RID: 882 RVA: 0x000109CC File Offset: 0x0000EBCC
	public static void bcc(int a)
	{
		UniWindowController current = UniWindowController.current;
		if (current == null)
		{
			return;
		}
		Rect monitorRect = UniWindowController.GetMonitorRect(a);
		if (monitorRect.width <= 0f || monitorRect.height <= 0f)
		{
			return;
		}
		current.windowPosition = monitorRect.position;
		current.windowSize = monitorRect.size;
	}

	// Token: 0x06000373 RID: 883 RVA: 0x00010A28 File Offset: 0x0000EC28
	public void bci()
	{
		if (!this.isCanClick)
		{
			return;
		}
		if (!bq.hmg)
		{
			return;
		}
		if (this.settingPanel != null && this.settingPanel.gameObject.activeSelf)
		{
			if (!bq.hlk)
			{
				bq.hlk = true;
			}
			return;
		}
		BgmPanelController bgmPanelController = ((cx.kpw != null) ? cx.kpw.bgmPanel : null);
		if (bgmPanelController != null && bgmPanelController.gameObject.activeSelf)
		{
			if (!bq.hlk)
			{
				bq.hlk = true;
			}
			return;
		}
		if (Input.GetMouseButtonDown(0) && EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			return;
		}
		if (!bq.hlk)
		{
			bq.hlk = true;
			return;
		}
		if (Time.unscaledTime - this.hnl < 0.05f)
		{
			return;
		}
		this.hnl = Time.unscaledTime;
		if (MultiplayerSession.iuw && Input.GetMouseButtonDown(0) && fu.dck())
		{
			return;
		}
		if (du.iah != null)
		{
			du.iah.cec(du.STEAM_STAT_ID.STAT_CLICK, 1, du.STEAM_STAT_OP.Add);
		}
		if (!bq.hlz)
		{
			if (bq.hly == 0)
			{
				if (this.girlController.bfd() && MultiplayerSession.iuw)
				{
					MultiplayerSession.dhz();
				}
			}
			else if (r.kmi != null)
			{
				r.kmi.ue();
				if (MultiplayerSession.iuw)
				{
					MultiplayerSession.dia();
				}
			}
		}
		Action action = bx.hoi;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000374 RID: 884 RVA: 0x00010B90 File Offset: 0x0000ED90
	private void jed(IReadOnlyList<ItemData> a)
	{
		if (a == null || a.Count == 0)
		{
			return;
		}
		if (!bq.hmg)
		{
			this.hnn.AddRange(a);
			if (bq.knd)
			{
				Debug.Log(string.Format(a.sv(), a.Count));
			}
			return;
		}
		this.bct(a);
	}

	// Token: 0x06000375 RID: 885 RVA: 0x00010BE5 File Offset: 0x0000EDE5
	private void op()
	{
		if (this.hnh.GetButtonDown(a.sw()) || Input.anyKeyDown)
		{
			this.bci();
		}
	}

	// Token: 0x06000376 RID: 886 RVA: 0x00010C06 File Offset: 0x0000EE06
	private void OnApplicationFocus(bool hasFocus)
	{
		if (hasFocus)
		{
			this.bcr();
		}
	}

	// Token: 0x06000378 RID: 888 RVA: 0x00010CA8 File Offset: 0x0000EEA8
	private void bcn(int a)
	{
		if (!bq.hlw)
		{
			return;
		}
		cx cx = cx.kpw;
		if (cx == null)
		{
			return;
		}
		cx.brj();
	}

	// Token: 0x06000379 RID: 889 RVA: 0x00010CD4 File Offset: 0x0000EED4
	private void hrm(int a)
	{
		if (!bq.hlw)
		{
			return;
		}
		if (UniWindowController.current != null)
		{
			bx.bcc(UniWindowController.current.monitorToFit);
		}
		CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
		if (characterDragTarget != null)
		{
			characterDragTarget.bgy();
		}
		if (this.settingPanel != null)
		{
			this.settingPanel.caw();
		}
		BgmPanelController bgmPanelController = ((cx.kpw != null) ? cx.kpw.bgmPanel : null);
		if (bgmPanelController != null)
		{
			bgmPanelController.bmt();
		}
		IReadOnlyList<gb> readOnlyList = MultiplayerSession.kuk;
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			RemoteAvatarPlacement iuu = readOnlyList[i].iuu;
			if (iuu != null)
			{
				iuu.dnm();
			}
		}
	}

	// Token: 0x0600037A RID: 890 RVA: 0x00010D88 File Offset: 0x0000EF88
	private void Start()
	{
		this.hnh = ReInput.players.GetPlayer(0);
		if (SteamInventoryManager.iid != null)
		{
			SteamInventoryManager.iid.cpl();
			this.bcr();
			SteamInventoryManager.iid.iie += this.bcy;
			SteamInventoryManager.iid.iii += this.bcs;
		}
		else
		{
			Debug.LogError(a.sx());
		}
		this.spineSkinSetting.bkr();
		ci.bhp(new Action(this.bde));
		bq.zr();
		bq.zs();
		bq.zu();
		bq.baa();
		this.giftManager.bdl();
		BgmPlayer.si();
		AmbientPlayer.nq();
		base.StartCoroutine(this.bbz());
		this.hnt = new Action<du.StatUpdatedEventArgs>(this.bdf);
		du.cem(du.STEAM_STAT_ID.STAT_CLICK, this.hnt);
		this.hnu = new Action(this.bdg);
		du.iae += this.hnu;
		if (du.iah != null && du.iah.iai)
		{
			bq.bac();
			this.text_Number.text = this.koc.ToString();
		}
		SteamManager.ibn -= this.bcq;
		SteamManager.ibn += this.bcq;
		if (SteamManager.krd)
		{
			this.bcq();
		}
		eu.cry(true);
		eu.ijw += this.bcl;
		eu.ijz += this.bcm;
		eu.ika += this.bcn;
		eu.ikb += this.bco;
		eu.ikc += this.bcp;
		if (PlayerPrefs.GetInt(a.sy(), 1) == 0)
		{
			bq.hlw = false;
			WinGlobalHotkey.ctq();
		}
		fa.cus();
		fd.cvl();
		fb.cuy();
	}

	// Token: 0x0600037B RID: 891 RVA: 0x00010F72 File Offset: 0x0000F172
	private void bcl(int a)
	{
		this.bci();
	}

	// Token: 0x0600037C RID: 892 RVA: 0x00010F7C File Offset: 0x0000F17C
	private static bool bbs(SpineSkinData a, HashSet<int> b)
	{
		if (a == null)
		{
			return false;
		}
		if (bq.knc)
		{
			return true;
		}
		if (a.type == CLOTHE_TYPE.Dick)
		{
			return a.bjk();
		}
		if ((a.type == CLOTHE_TYPE.SkinTone && a.kox == 200) || (a.type == CLOTHE_TYPE.IntimateParts && a.kox == 400))
		{
			return true;
		}
		if (a.koy)
		{
			return bj.wm(a.bjn());
		}
		return b.Contains(a.kox);
	}

	// Token: 0x0600037D RID: 893 RVA: 0x00010FF8 File Offset: 0x0000F1F8
	private void drn()
	{
		eu.ijw -= this.bcl;
		eu.ijz -= this.bcm;
		eu.ika -= this.bcn;
		eu.ikb -= this.bco;
		eu.ikc -= this.bcp;
		eu.crz();
		if (SteamInventoryManager.iid != null)
		{
			SteamInventoryManager.iid.iie -= this.bcy;
			SteamInventoryManager.iid.iii -= this.bcs;
		}
		if (this.hnt != null)
		{
			du.cen(du.STEAM_STAT_ID.STAT_CLICK, this.hnt);
		}
		if (this.hnu != null)
		{
			du.iae -= this.hnu;
		}
		SteamManager.ibn -= this.bcq;
	}

	// Token: 0x0600037E RID: 894 RVA: 0x00010273 File Offset: 0x0000E473
	private void bdd(int a)
	{
		this.text_Number.text = a.ToString();
	}

	// Token: 0x06000380 RID: 896 RVA: 0x000110DC File Offset: 0x0000F2DC
	private void bcs(IReadOnlyList<ItemData> a)
	{
		if (a == null || a.Count == 0)
		{
			return;
		}
		if (!bq.hmg)
		{
			this.hnn.AddRange(a);
			if (bq.knd)
			{
				Debug.Log(string.Format(a.sz(), a.Count));
			}
			return;
		}
		this.bct(a);
	}

	// Token: 0x06000381 RID: 897 RVA: 0x00011134 File Offset: 0x0000F334
	private void bcr()
	{
		if (!SteamManager.krd)
		{
			return;
		}
		if (SteamInventoryManager.iid == null)
		{
			return;
		}
		if (Time.realtimeSinceStartup - this.hnr < 60f)
		{
			return;
		}
		this.hnr = Time.realtimeSinceStartup;
		SteamInventoryManager.iid.cpq();
	}

	// Token: 0x06000382 RID: 898 RVA: 0x00011180 File Offset: 0x0000F380
	private void ekg(IReadOnlyList<ItemData> a)
	{
		if (a == null || a.Count == 0)
		{
			return;
		}
		if (!bq.hmg)
		{
			this.hnn.AddRange(a);
			if (bq.knd)
			{
				Debug.Log(string.Format(a.ta(), a.Count));
			}
			return;
		}
		this.bct(a);
	}

	// Token: 0x06000383 RID: 899 RVA: 0x000111D5 File Offset: 0x0000F3D5
	private void nwf()
	{
		if (!SteamManager.krd && !bq.knc)
		{
			return;
		}
		if (this.settingPanel.gameObject.activeSelf)
		{
			this.bce();
		}
	}

	// Token: 0x06000384 RID: 900 RVA: 0x00011200 File Offset: 0x0000F400
	private void dmo()
	{
		if (bq.hmh)
		{
			return;
		}
		global::PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		string version = Application.version;
		string text = playerSaveData.lastSeenAppVersion ?? a.tb();
		if (text == version)
		{
			return;
		}
		if (!playerSaveData.hasInitializedKnownItems)
		{
			playerSaveData.lastSeenAppVersion = version;
			ci.Save(null);
			return;
		}
		List<int> newItemDefIds = playerSaveData.newItemDefIds;
		int num = ((newItemDefIds != null) ? newItemDefIds.Count : 0);
		List<int> newItemDefIds2 = playerSaveData.newItemDefIds;
		if (newItemDefIds2 != null)
		{
			newItemDefIds2.Clear();
		}
		playerSaveData.lastSeenAppVersion = version;
		ci.Save(null);
		if (bq.knd)
		{
			Debug.Log(string.Format(a.tc(), text, version, num));
		}
		if (cx.kpw != null)
		{
			cx.kpw.brh();
		}
	}

	// Token: 0x06000385 RID: 901 RVA: 0x000112BC File Offset: 0x0000F4BC
	[CompilerGenerated]
	private void bdg()
	{
		bq.bac();
		this.text_Number.text = this.koc.ToString();
	}

	// Token: 0x06000386 RID: 902 RVA: 0x000112E8 File Offset: 0x0000F4E8
	private void bcx()
	{
		global::PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		if (playerSaveData.hasInitializedKnownItems)
		{
			return;
		}
		foreach (CLOTHE_TYPE clothe_TYPE in new CLOTHE_TYPE[]
		{
			CLOTHE_TYPE.Dick,
			CLOTHE_TYPE.Hair,
			CLOTHE_TYPE.Top,
			CLOTHE_TYPE.Bottom,
			CLOTHE_TYPE.Underwear,
			CLOTHE_TYPE.Socks,
			CLOTHE_TYPE.Shoes,
			CLOTHE_TYPE.SkinTone,
			CLOTHE_TYPE.IntimateParts,
			CLOTHE_TYPE.PubicAndGenital
		})
		{
			List<SpineSkinData> list = this.spineSkinSetting.bkl(clothe_TYPE);
			if (list != null)
			{
				foreach (SpineSkinData spineSkinData in list)
				{
					if (spineSkinData.kox != 0 && spineSkinData.bjq() && spineSkinData.bjk() && !playerSaveData.knownItemDefIds.Contains(spineSkinData.kox))
					{
						playerSaveData.knownItemDefIds.Add(spineSkinData.kox);
					}
				}
			}
		}
		playerSaveData.hasInitializedKnownItems = true;
		ci.Save(null);
		Debug.Log(string.Format(a.td(), playerSaveData.knownItemDefIds.Count));
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00010244 File Offset: 0x0000E444
	private void kjt(int a)
	{
		if (!bq.hlw)
		{
			return;
		}
		bl bl = bl.kmv;
		if (bl == null)
		{
			return;
		}
		bl.xt();
	}

	// Token: 0x06000388 RID: 904 RVA: 0x000113F4 File Offset: 0x0000F5F4
	private void bcz(HashSet<int> a)
	{
		global::PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		if (!playerSaveData.hasInitializedKnownItems)
		{
			return;
		}
		CLOTHE_TYPE[] array = new CLOTHE_TYPE[]
		{
			CLOTHE_TYPE.Dick,
			CLOTHE_TYPE.Hair,
			CLOTHE_TYPE.Top,
			CLOTHE_TYPE.Bottom,
			CLOTHE_TYPE.Underwear,
			CLOTHE_TYPE.Socks,
			CLOTHE_TYPE.Shoes,
			CLOTHE_TYPE.SkinTone,
			CLOTHE_TYPE.IntimateParts,
			CLOTHE_TYPE.PubicAndGenital
		};
		bool flag = bq.hma > DropNotificationMode.Off;
		bool flag2 = false;
		foreach (CLOTHE_TYPE clothe_TYPE in array)
		{
			List<SpineSkinData> list = this.spineSkinSetting.bkl(clothe_TYPE);
			if (list != null)
			{
				foreach (SpineSkinData spineSkinData in list)
				{
					if (spineSkinData.kox != 0 && bx.bbs(spineSkinData, a) && !playerSaveData.knownItemDefIds.Contains(spineSkinData.kox))
					{
						playerSaveData.knownItemDefIds.Add(spineSkinData.kox);
						if (flag && !playerSaveData.newItemDefIds.Contains(spineSkinData.kox))
						{
							playerSaveData.newItemDefIds.Add(spineSkinData.kox);
							if (playerSaveData.newItemDefIds.Count > 50)
							{
								int num = playerSaveData.newItemDefIds[0];
								playerSaveData.newItemDefIds.RemoveAt(0);
								Debug.LogWarning(string.Format(a.te(), 50, num));
							}
							if (bq.knd)
							{
								Debug.Log(string.Format(a.tf(), spineSkinData.kox, clothe_TYPE));
							}
						}
						flag2 = true;
					}
				}
			}
		}
		if (flag2)
		{
			ci.Save(null);
			if (cx.kpw != null)
			{
				cx.kpw.brh();
			}
		}
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00010F72 File Offset: 0x0000F172
	private void gnw(int a)
	{
		this.bci();
	}

	// Token: 0x0600038A RID: 906 RVA: 0x000115AC File Offset: 0x0000F7AC
	private void jlb(HashSet<int> a)
	{
		global::PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		if (!playerSaveData.hasInitializedKnownItems)
		{
			return;
		}
		CLOTHE_TYPE[] array = new CLOTHE_TYPE[-61];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.67877719C2B703153E6D07E3386D425643658FF7EDCBDD659D297D772FB8AD31).FieldHandle);
		bool flag = bq.hma > DropNotificationMode.Off;
		bool flag2 = false;
		foreach (CLOTHE_TYPE clothe_TYPE in array)
		{
			List<SpineSkinData> list = this.spineSkinSetting.bkl(clothe_TYPE);
			if (list != null)
			{
				foreach (SpineSkinData spineSkinData in list)
				{
					if (spineSkinData.kox != 0 && bx.bbs(spineSkinData, a) && !playerSaveData.knownItemDefIds.Contains(spineSkinData.kox))
					{
						playerSaveData.knownItemDefIds.Add(spineSkinData.kox);
						if (flag && !playerSaveData.newItemDefIds.Contains(spineSkinData.kox))
						{
							playerSaveData.newItemDefIds.Add(spineSkinData.kox);
							if (playerSaveData.newItemDefIds.Count > -84)
							{
								int num = playerSaveData.newItemDefIds[0];
								playerSaveData.newItemDefIds.RemoveAt(0);
								Debug.LogWarning(string.Format(a.tg(), -54, num));
							}
							if (bq.knd)
							{
								Debug.Log(string.Format(a.th(), spineSkinData.kox, clothe_TYPE));
							}
						}
						flag2 = true;
					}
				}
			}
		}
		if (flag2)
		{
			ci.Save(null);
			if (cx.kpw != null)
			{
				cx.kpw.brh();
			}
		}
	}

	// Token: 0x0600038B RID: 907 RVA: 0x00011764 File Offset: 0x0000F964
	private void lfn(int a)
	{
		if (!bq.hlw)
		{
			return;
		}
		if (UniWindowController.current != null)
		{
			bx.bcc(UniWindowController.current.monitorToFit);
		}
		CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
		if (characterDragTarget != null)
		{
			characterDragTarget.bgy();
		}
		if (this.settingPanel != null)
		{
			this.settingPanel.caw();
		}
		BgmPanelController bgmPanelController = ((cx.kpw != null) ? cx.kpw.bgmPanel : null);
		if (bgmPanelController != null)
		{
			bgmPanelController.bmt();
		}
		IReadOnlyList<gb> readOnlyList = MultiplayerSession.kuk;
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			RemoteAvatarPlacement iuu = readOnlyList[i].iuu;
			if (iuu != null)
			{
				iuu.dnm();
			}
		}
	}

	// Token: 0x0600038C RID: 908 RVA: 0x00011818 File Offset: 0x0000FA18
	private void Awake()
	{
		bx.hod = this;
		this.hof = Camera.main;
		bq.hlf = this.playerData;
		bq.hle = this.spineSkinSetting;
		bq.hlg = this.voiceConfig;
		dn.bxu(dn.bxt());
		q.tr();
		q.ts();
	}

	// Token: 0x0600038D RID: 909 RVA: 0x0001186C File Offset: 0x0000FA6C
	private void ihu()
	{
		this.hnh = ReInput.players.GetPlayer(0);
		if (SteamInventoryManager.iid != null)
		{
			SteamInventoryManager.iid.cpl();
			this.bcr();
			SteamInventoryManager.iid.iie += this.bcy;
			SteamInventoryManager.iid.iii += this.bcs;
		}
		else
		{
			Debug.LogError(a.ti());
		}
		this.spineSkinSetting.bkr();
		ci.bhp(new Action(this.bde));
		bq.zr();
		bq.zs();
		bq.zu();
		bq.baa();
		this.giftManager.bdl();
		BgmPlayer.si();
		AmbientPlayer.nq();
		base.StartCoroutine(this.bbz());
		this.hnt = new Action<du.StatUpdatedEventArgs>(this.bdf);
		du.cem(du.STEAM_STAT_ID.STAT_CLICK, this.hnt);
		this.hnu = new Action(this.bdg);
		du.iae += this.hnu;
		if (du.iah != null && du.iah.iai)
		{
			bq.bac();
			this.text_Number.text = this.koc.ToString();
		}
		SteamManager.ibn -= this.bcq;
		SteamManager.ibn += this.bcq;
		if (SteamManager.krd)
		{
			this.bcq();
		}
		eu.cry(true);
		eu.ijw += this.bcl;
		eu.ijz += this.bcm;
		eu.ika += this.bcn;
		eu.ikb += this.bco;
		eu.ikc += this.bcp;
		if (PlayerPrefs.GetInt(a.tj(), 1) == 0)
		{
			bq.hlw = false;
			WinGlobalHotkey.ctq();
		}
		fa.cus();
		fd.cvl();
		fb.cuy();
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00011AA8 File Offset: 0x0000FCA8
	public static void ceh(int a)
	{
		UniWindowController current = UniWindowController.current;
		if (current == null)
		{
			return;
		}
		Rect monitorRect = UniWindowController.GetMonitorRect(a);
		if (monitorRect.width <= -359f || monitorRect.height <= 6751f)
		{
			return;
		}
		current.windowPosition = monitorRect.position;
		current.windowSize = monitorRect.size;
	}

	// Token: 0x06000390 RID: 912 RVA: 0x00011B03 File Offset: 0x0000FD03
	private void bcq()
	{
		this.bcr();
	}

	// Token: 0x06000391 RID: 913 RVA: 0x00011B0C File Offset: 0x0000FD0C
	private void bcw()
	{
		if (bq.hmh)
		{
			return;
		}
		global::PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		string version = Application.version;
		string text = playerSaveData.lastSeenAppVersion ?? a.tk();
		if (text == version)
		{
			return;
		}
		if (!playerSaveData.hasInitializedKnownItems)
		{
			playerSaveData.lastSeenAppVersion = version;
			ci.Save(null);
			return;
		}
		List<int> newItemDefIds = playerSaveData.newItemDefIds;
		int num = ((newItemDefIds != null) ? newItemDefIds.Count : 0);
		List<int> newItemDefIds2 = playerSaveData.newItemDefIds;
		if (newItemDefIds2 != null)
		{
			newItemDefIds2.Clear();
		}
		playerSaveData.lastSeenAppVersion = version;
		ci.Save(null);
		if (bq.knd)
		{
			Debug.Log(string.Format(a.tl(), text, version, num));
		}
		if (cx.kpw != null)
		{
			cx.kpw.brh();
		}
	}

	// Token: 0x06000392 RID: 914 RVA: 0x00010C06 File Offset: 0x0000EE06
	private void kvj(bool hasFocus)
	{
		if (hasFocus)
		{
			this.bcr();
		}
	}

	// Token: 0x06000393 RID: 915 RVA: 0x00011BC8 File Offset: 0x0000FDC8
	private void Update()
	{
		eu.csa();
		if (!SteamManager.krd && !bq.knc)
		{
			if (!this.hnj)
			{
				Debug.LogError(a.tm());
				this.hnj = true;
			}
			return;
		}
		this.hni += Time.deltaTime;
		if (this.hni >= this.needRetryTime)
		{
			this.hni = 0f;
			this.bcg(20000);
			base.StartCoroutine(this.bch(bx.hnw, new Action(this.bdh)));
		}
		this.hns += Time.unscaledDeltaTime;
		if (this.hns >= 600f)
		{
			this.hns = 0f;
			this.bcr();
		}
		if (this.hnk)
		{
			this.girlController.sizeController.bds(bq.hlo);
		}
		if (!this.settingPanel.gameObject.activeSelf)
		{
			this.bcf();
		}
	}

	// Token: 0x06000394 RID: 916 RVA: 0x00011CBC File Offset: 0x0000FEBC
	private void nsh()
	{
		bx.hod = this;
		this.hof = Camera.main;
		bq.hlf = this.playerData;
		bq.hle = this.spineSkinSetting;
		bq.hlg = this.voiceConfig;
		dn.bxu(dn.bxt());
		q.tr();
		q.ts();
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00011D10 File Offset: 0x0000FF10
	private static bool eib(SpineSkinData a, HashSet<int> b)
	{
		if (a == null)
		{
			return false;
		}
		if (bq.knc)
		{
			return true;
		}
		if (a.type == CLOTHE_TYPE.Dick)
		{
			return a.bjk();
		}
		if ((a.type == (CLOTHE_TYPE)(-98) && a.kox == 16) || (a.type == (CLOTHE_TYPE)2 && a.kox == 16))
		{
			return true;
		}
		if (a.koy)
		{
			return bj.wm(a.bjn());
		}
		return b.Contains(a.kox);
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00011D84 File Offset: 0x0000FF84
	private void dfo(Dictionary<int, uint> a)
	{
		this.hoa.Clear();
		foreach (KeyValuePair<int, uint> keyValuePair in a)
		{
			this.hoa[keyValuePair.Key] = keyValuePair.Value;
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x0600039D RID: 925 RVA: 0x00012191 File Offset: 0x00010391
	// (set) Token: 0x06000397 RID: 919 RVA: 0x00011DF0 File Offset: 0x0000FFF0
	public static bx hod { get; private set; }

	// Token: 0x06000398 RID: 920 RVA: 0x00011DF8 File Offset: 0x0000FFF8
	[CompilerGenerated]
	private void bdf(du.StatUpdatedEventArgs a)
	{
		bq.bac();
		this.bdd(a.newValue);
	}

	// Token: 0x06000399 RID: 921 RVA: 0x00011E0C File Offset: 0x0001000C
	private void OnApplicationQuit()
	{
		bool flag = SteamManager.ibh;
		if (!flag && SteamManager.kre)
		{
			try
			{
				flag = !SteamAPI.IsSteamRunning();
			}
			catch (Exception)
			{
				flag = true;
			}
		}
		if (flag)
		{
			Debug.LogWarning(a.tn());
			global::FishySteamworks.FishySteamworks.SteamApiUnavailable = true;
			SteamManager.cev();
		}
		if (!flag && du.iah != null)
		{
			try
			{
				du.iah.cdt();
			}
			catch (Exception ex)
			{
				Debug.LogError(string.Format(a.to(), ex));
			}
		}
		if (bq.hmh)
		{
			Debug.LogWarning(a.tp());
		}
		else
		{
			try
			{
				ci.Save(null);
			}
			catch (Exception ex2)
			{
				Debug.LogError(string.Format(a.tq(), ex2));
			}
		}
		eu.crz();
		try
		{
			bh.wh(true);
		}
		catch (Exception ex3)
		{
			Debug.LogError(string.Format(a.tr(), ex3));
		}
		try
		{
			fp fp = fp.kto;
			if (fp != null)
			{
				fp.daw();
			}
		}
		catch (Exception ex4)
		{
			Debug.LogError(string.Format(a.ts(), ex4));
		}
		if (SteamManager.kre)
		{
			SteamAPI.Shutdown();
			SteamManager.cev();
		}
	}

	// Token: 0x0600039A RID: 922 RVA: 0x00011F48 File Offset: 0x00010148
	private void bda(Dictionary<int, uint> a)
	{
		global::PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		if (!playerSaveData.hasInitializedKnownItems)
		{
			return;
		}
		if (bq.hma != DropNotificationMode.All)
		{
			this.bdb(a);
			this.hoc = true;
			return;
		}
		if (!this.hoc)
		{
			this.bdb(a);
			this.hoc = true;
			return;
		}
		bool flag = false;
		foreach (KeyValuePair<int, uint> keyValuePair in a)
		{
			int key = keyValuePair.Key;
			uint value = keyValuePair.Value;
			uint num;
			this.hoa.TryGetValue(key, out num);
			if (value > num && this.spineSkinSetting.bjx(key) != null && !playerSaveData.newItemDefIds.Contains(key))
			{
				playerSaveData.newItemDefIds.Add(key);
				if (playerSaveData.newItemDefIds.Count > 50)
				{
					int num2 = playerSaveData.newItemDefIds[0];
					playerSaveData.newItemDefIds.RemoveAt(0);
					Debug.LogWarning(string.Format(a.tt(), 50, num2));
				}
				flag = true;
				if (bq.knd)
				{
					Debug.Log(string.Format(a.tu(), key, num, value));
				}
			}
		}
		this.bdb(a);
		if (flag)
		{
			ci.Save(null);
			if (cx.kpw != null)
			{
				cx.kpw.brh();
			}
		}
	}

	// Token: 0x0600039B RID: 923 RVA: 0x000120D0 File Offset: 0x000102D0
	private void bnu(int a)
	{
		if (!bq.hlw)
		{
			return;
		}
		if (UniWindowController.current != null)
		{
			bx.bcc(UniWindowController.current.monitorToFit);
		}
		CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
		if (characterDragTarget != null)
		{
			characterDragTarget.bgy();
		}
		if (this.settingPanel != null)
		{
			this.settingPanel.caw();
		}
		BgmPanelController bgmPanelController = ((cx.kpw != null) ? cx.kpw.bgmPanel : null);
		if (bgmPanelController != null)
		{
			bgmPanelController.bmt();
		}
		IReadOnlyList<gb> readOnlyList = MultiplayerSession.kuk;
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			RemoteAvatarPlacement iuu = readOnlyList[i].iuu;
			if (iuu != null)
			{
				iuu.dnm();
			}
		}
	}

	// Token: 0x0600039C RID: 924 RVA: 0x00012182 File Offset: 0x00010382
	[CompilerGenerated]
	private void bde()
	{
		base.StartCoroutine(this.bby());
	}

	// Token: 0x0600039E RID: 926 RVA: 0x00012198 File Offset: 0x00010398
	public static void oqd(int a)
	{
		UniWindowController current = UniWindowController.current;
		if (current == null)
		{
			return;
		}
		Rect monitorRect = UniWindowController.GetMonitorRect(a);
		if (monitorRect.width <= 5423f || monitorRect.height <= -2540f)
		{
			return;
		}
		current.windowPosition = monitorRect.position;
		current.windowSize = monitorRect.size;
	}

	// Token: 0x0600039F RID: 927 RVA: 0x000121F4 File Offset: 0x000103F4
	private void bct(IReadOnlyList<ItemData> a)
	{
		if (a == null || a.Count == 0)
		{
			return;
		}
		List<ItemData> list = new List<ItemData>(bq.hlj);
		list.AddRange(a);
		bq.baq(list);
		foreach (ItemData itemData in a)
		{
			SpineSkinData spineSkinData = bq.hle.bjx(itemData.defID);
			if (spineSkinData != null)
			{
				if (!bx.hno.Contains(itemData.defID))
				{
					if (bq.knd)
					{
						Debug.Log(string.Format(a.tv(), itemData.defID));
					}
				}
				else if (this.bcu(spineSkinData.type))
				{
					spineSkinData.bjp(true);
				}
				else
				{
					Debug.Log(string.Format(a.tw(), itemData.defID, spineSkinData.type));
				}
			}
		}
		bq.hle.bkt();
		ci.Save(null);
		base.StartCoroutine(this.bcv());
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00012304 File Offset: 0x00010504
	private void kam()
	{
		bool flag = SteamManager.ibh;
		if (!flag && SteamManager.kre)
		{
			try
			{
				flag = !SteamAPI.IsSteamRunning();
			}
			catch (Exception)
			{
				flag = true;
			}
		}
		if (flag)
		{
			Debug.LogWarning(a.tx());
			global::FishySteamworks.FishySteamworks.SteamApiUnavailable = true;
			SteamManager.cev();
		}
		if (!flag && du.iah != null)
		{
			try
			{
				du.iah.cdt();
			}
			catch (Exception ex)
			{
				Debug.LogError(string.Format(a.ty(), ex));
			}
		}
		if (bq.hmh)
		{
			Debug.LogWarning(a.tz());
		}
		else
		{
			try
			{
				ci.Save(null);
			}
			catch (Exception ex2)
			{
				Debug.LogError(string.Format(a.ua(), ex2));
			}
		}
		eu.crz();
		try
		{
			bh.wh(true);
		}
		catch (Exception ex3)
		{
			Debug.LogError(string.Format(a.ub(), ex3));
		}
		try
		{
			fp fp = fp.kto;
			if (fp != null)
			{
				fp.daw();
			}
		}
		catch (Exception ex4)
		{
			Debug.LogError(string.Format(a.uc(), ex4));
		}
		if (SteamManager.kre)
		{
			SteamAPI.Shutdown();
			SteamManager.cev();
		}
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00012440 File Offset: 0x00010640
	private bool bcu(CLOTHE_TYPE a)
	{
		global::PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		switch (a)
		{
		case CLOTHE_TYPE.Dick:
			return playerSaveData.desiredDickUse == 0;
		case CLOTHE_TYPE.Hair:
			return playerSaveData.desiredHairUse == 0;
		case (CLOTHE_TYPE)2:
		case (CLOTHE_TYPE)6:
		case (CLOTHE_TYPE)7:
			break;
		case CLOTHE_TYPE.Top:
			return playerSaveData.desiredTopUse == 0;
		case CLOTHE_TYPE.Bottom:
			return playerSaveData.desiredBottomUse == 0;
		case CLOTHE_TYPE.Underwear:
			return playerSaveData.desiredUnderwearUse == 0;
		case CLOTHE_TYPE.Socks:
			return playerSaveData.desiredSocksUse == 0;
		case CLOTHE_TYPE.Shoes:
			return playerSaveData.desiredShoesUse == 0;
		default:
			switch (a)
			{
			case CLOTHE_TYPE.SkinTone:
				return playerSaveData.desiredSkinToneUse == 0;
			case CLOTHE_TYPE.IntimateParts:
				return playerSaveData.desiredIntimatePartsUse == 0;
			case CLOTHE_TYPE.PubicAndGenital:
				return playerSaveData.desiredPubicAndGenitalUse == 0;
			}
			break;
		}
		return true;
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00012504 File Offset: 0x00010704
	private void ewa()
	{
		eu.csa();
		if (!SteamManager.krd && !bq.knc)
		{
			if (!this.hnj)
			{
				Debug.LogError(a.ud());
				this.hnj = true;
			}
			return;
		}
		this.hni += Time.deltaTime;
		if (this.hni >= this.needRetryTime)
		{
			this.hni = -8789f;
			this.bcg(84);
			base.StartCoroutine(this.bch(bx.hnw, new Action(this.bdh)));
		}
		this.hns += Time.unscaledDeltaTime;
		if (this.hns >= -7035f)
		{
			this.hns = -9833f;
			this.bcr();
		}
		if (this.hnk)
		{
			this.girlController.sizeController.bds(bq.hlo);
		}
		if (!this.settingPanel.gameObject.activeSelf)
		{
			this.bcf();
		}
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x000125F4 File Offset: 0x000107F4
	public static void dnc(int a)
	{
		UniWindowController current = UniWindowController.current;
		if (current == null)
		{
			return;
		}
		Rect monitorRect = UniWindowController.GetMonitorRect(a);
		if (monitorRect.width <= -5006f || monitorRect.height <= -3410f)
		{
			return;
		}
		current.windowPosition = monitorRect.position;
		current.windowSize = monitorRect.size;
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00012650 File Offset: 0x00010850
	private void fkx()
	{
		bx.hod = this;
		this.hof = Camera.main;
		bq.hlf = this.playerData;
		bq.hle = this.spineSkinSetting;
		bq.hlg = this.voiceConfig;
		dn.bxu(dn.bxt());
		q.tr();
		q.ts();
	}

	// Token: 0x14000009 RID: 9
	// (add) Token: 0x060003A5 RID: 933 RVA: 0x000126A4 File Offset: 0x000108A4
	// (remove) Token: 0x060003B9 RID: 953 RVA: 0x00012CAC File Offset: 0x00010EAC
	public static event Action hoi;

	// Token: 0x060003A6 RID: 934 RVA: 0x000126D7 File Offset: 0x000108D7
	private IEnumerator bby()
	{
		try
		{
			if (this.settingController != null)
			{
				this.settingController.bxm();
			}
		}
		catch (Exception ex)
		{
			string text = a.rx();
			Exception ex2 = ex;
			Debug.LogWarning(text + ((ex2 != null) ? ex2.ToString() : null));
		}
		if (!SteamManager.krd && !bq.knc)
		{
			if (this.steamWarningObject != null)
			{
				this.steamWarningObject.SetActive(true);
			}
			Debug.LogError(a.ry());
			while (!SteamManager.krd)
			{
				yield return null;
			}
			if (this.steamWarningObject != null)
			{
				this.steamWarningObject.SetActive(false);
			}
			Debug.Log(a.rz());
		}
		BgmPlayer.si().sj();
		AmbientPlayer.nq().nr();
		while (!this.kod)
		{
			yield return null;
		}
		bj.wo();
		bh.wd();
		if (bq.hle != null)
		{
			bg.vx(bq.hle);
			int num = bg.vy(bq.hle);
			if (num > 0)
			{
				Debug.Log(string.Format(a.sa(), num));
			}
		}
		bq.bas();
		this.bcw();
		this.bcx();
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		while (!(GirlController.kok != null) || !GirlController.kok.kom)
		{
			if (Time.realtimeSinceStartup - realtimeSinceStartup > 5f)
			{
				Debug.LogWarning(a.sb());
				break;
			}
			yield return null;
		}
		bq.hle.bkt();
		GirlController girlController = GirlController.kok;
		if (girlController != null)
		{
			girlController.bft();
		}
		try
		{
			this.settingPanel.cal();
		}
		catch (Exception ex3)
		{
			string text2 = a.sc();
			Exception ex4 = ex3;
			Debug.LogError(text2 + ((ex4 != null) ? ex4.ToString() : null));
		}
		bq.hmg = true;
		if (this.hnn.Count > 0)
		{
			List<ItemData> list = new List<ItemData>(this.hnn);
			this.hnn.Clear();
			this.bct(list);
		}
		if (bq.hlf != null && bq.hlf.playerSaveData != null)
		{
			int aiConnectionMode = bq.hlf.playerSaveData.aiConnectionMode;
			if (aiConnectionMode == 1)
			{
				if (McpDialogueServer.Instance != null)
				{
					McpDialogueServer.Instance.StartServer();
				}
			}
			else if (aiConnectionMode == 2)
			{
				DirectApiScheduler directApiScheduler = DirectApiScheduler.EnsureInstance();
				directApiScheduler.Enable();
				directApiScheduler.ScheduleLaunchGreeting();
			}
		}
		if (cx.kpw != null)
		{
			cx.kpw.brh();
		}
		this.girlController.sizeController.bds(bq.hlo);
		this.hnk = true;
		this.sizeUIController.bds(bq.hlp);
		if (this.sizeToolbarController != null)
		{
			this.sizeToolbarController.bds(bq.hlq);
		}
		UniWindowController.current.isTopmost = bq.hls;
		UniWindowController.current.forceTopmost = bq.hls;
		this.settingController.byi(bq.hlt);
		Canvas.ForceUpdateCanvases();
		base.StartCoroutine(this.bcd(PlayerPrefs.GetFloat(a.sd(), 0.5f), PlayerPrefs.GetFloat(a.se(), 0.5f), PlayerPrefs.GetFloat(a.sf(), 0.5f), PlayerPrefs.GetFloat(a.sg(), 0.5f)));
		yield break;
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x00011B03 File Offset: 0x0000FD03
	private void sa()
	{
		this.bcr();
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x000126E8 File Offset: 0x000108E8
	private void fty()
	{
		eu.ijw -= this.bcl;
		eu.ijz -= this.bcm;
		eu.ika -= this.bcn;
		eu.ikb -= this.bco;
		eu.ikc -= this.bcp;
		eu.crz();
		if (SteamInventoryManager.iid != null)
		{
			SteamInventoryManager.iid.iie -= this.bcy;
			SteamInventoryManager.iid.iii -= this.bcs;
		}
		if (this.hnt != null)
		{
			du.cen(du.STEAM_STAT_ID.STAT_CLICK, this.hnt);
		}
		if (this.hnu != null)
		{
			du.iae -= this.hnu;
		}
		SteamManager.ibn -= this.bcq;
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x000127C0 File Offset: 0x000109C0
	private void nhm()
	{
		if (this.hnh.GetButtonDown(a.ue()) || Input.anyKeyDown)
		{
			this.bci();
		}
	}

	// Token: 0x060003AA RID: 938 RVA: 0x000127E1 File Offset: 0x000109E1
	private IEnumerator bcv()
	{
		yield return null;
		bq.hle.bkt();
		yield break;
	}

	// Token: 0x060003AB RID: 939 RVA: 0x000127EC File Offset: 0x000109EC
	private void lv()
	{
		if (!SteamManager.krd)
		{
			return;
		}
		if (SteamInventoryManager.iid == null)
		{
			return;
		}
		if (Time.realtimeSinceStartup - this.hnr < 6200f)
		{
			return;
		}
		this.hnr = Time.realtimeSinceStartup;
		SteamInventoryManager.iid.cpq();
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00012838 File Offset: 0x00010A38
	private static bool fuj(SpineSkinData a, HashSet<int> b)
	{
		if (a == null)
		{
			return false;
		}
		if (bq.knc)
		{
			return true;
		}
		if (a.type == CLOTHE_TYPE.Dick)
		{
			return a.bjk();
		}
		if ((a.type == (CLOTHE_TYPE)13 && a.kox == 13) || (a.type == (CLOTHE_TYPE)95 && a.kox == 0))
		{
			return true;
		}
		if (a.koy)
		{
			return bj.wm(a.bjn());
		}
		return b.Contains(a.kox);
	}

	// Token: 0x060003AD RID: 941 RVA: 0x000128AB File Offset: 0x00010AAB
	private void bco(int a)
	{
		if (!bq.hlw)
		{
			return;
		}
		SettingPanel settingPanel = SettingPanel.kqq;
		if (settingPanel == null)
		{
			return;
		}
		dn dn = settingPanel.settingController;
		if (dn == null)
		{
			return;
		}
		dn.bve(a);
	}

	// Token: 0x060003AE RID: 942 RVA: 0x000128D0 File Offset: 0x00010AD0
	private void jla(int a)
	{
		if (!bq.hlw)
		{
			return;
		}
		cx cx = cx.kpw;
		if (cx == null)
		{
			return;
		}
		cx.brj();
	}

	// Token: 0x060003AF RID: 943 RVA: 0x000128AB File Offset: 0x00010AAB
	private void coo(int a)
	{
		if (!bq.hlw)
		{
			return;
		}
		SettingPanel settingPanel = SettingPanel.kqq;
		if (settingPanel == null)
		{
			return;
		}
		dn dn = settingPanel.settingController;
		if (dn == null)
		{
			return;
		}
		dn.bve(a);
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x000128FC File Offset: 0x00010AFC
	private void OnDisable()
	{
		eu.ijw -= this.bcl;
		eu.ijz -= this.bcm;
		eu.ika -= this.bcn;
		eu.ikb -= this.bco;
		eu.ikc -= this.bcp;
		eu.crz();
		if (SteamInventoryManager.iid != null)
		{
			SteamInventoryManager.iid.iie -= this.bcy;
			SteamInventoryManager.iid.iii -= this.bcs;
		}
		if (this.hnt != null)
		{
			du.cen(du.STEAM_STAT_ID.STAT_CLICK, this.hnt);
		}
		if (this.hnu != null)
		{
			du.iae -= this.hnu;
		}
		SteamManager.ibn -= this.bcq;
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x00010244 File Offset: 0x0000E444
	private void inv(int a)
	{
		if (!bq.hlw)
		{
			return;
		}
		bl bl = bl.kmv;
		if (bl == null)
		{
			return;
		}
		bl.xt();
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x000129D4 File Offset: 0x00010BD4
	private void ebr(HashSet<int> a)
	{
		global::PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		if (!playerSaveData.hasInitializedKnownItems)
		{
			return;
		}
		CLOTHE_TYPE[] array = new CLOTHE_TYPE[-24];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.67877719C2B703153E6D07E3386D425643658FF7EDCBDD659D297D772FB8AD31).FieldHandle);
		bool flag = bq.hma > DropNotificationMode.Off;
		bool flag2 = false;
		foreach (CLOTHE_TYPE clothe_TYPE in array)
		{
			List<SpineSkinData> list = this.spineSkinSetting.bkl(clothe_TYPE);
			if (list != null)
			{
				foreach (SpineSkinData spineSkinData in list)
				{
					if (spineSkinData.kox != 0 && bx.bbs(spineSkinData, a) && !playerSaveData.knownItemDefIds.Contains(spineSkinData.kox))
					{
						playerSaveData.knownItemDefIds.Add(spineSkinData.kox);
						if (flag && !playerSaveData.newItemDefIds.Contains(spineSkinData.kox))
						{
							playerSaveData.newItemDefIds.Add(spineSkinData.kox);
							if (playerSaveData.newItemDefIds.Count > -7)
							{
								int num = playerSaveData.newItemDefIds[0];
								playerSaveData.newItemDefIds.RemoveAt(0);
								Debug.LogWarning(string.Format(a.uf(), 32, num));
							}
							if (bq.knd)
							{
								Debug.Log(string.Format(a.ug(), spineSkinData.kox, clothe_TYPE));
							}
						}
						flag2 = true;
					}
				}
			}
		}
		if (flag2)
		{
			ci.Save(null);
			if (cx.kpw != null)
			{
				cx.kpw.brh();
			}
		}
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00012B8C File Offset: 0x00010D8C
	private void bdb(Dictionary<int, uint> a)
	{
		this.hoa.Clear();
		foreach (KeyValuePair<int, uint> keyValuePair in a)
		{
			this.hoa[keyValuePair.Key] = keyValuePair.Value;
		}
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x00012BF8 File Offset: 0x00010DF8
	private void krf()
	{
		if (!SteamManager.krd)
		{
			return;
		}
		if (SteamInventoryManager.iid == null)
		{
			return;
		}
		if (Time.realtimeSinceStartup - this.hnr < 6957f)
		{
			return;
		}
		this.hnr = Time.realtimeSinceStartup;
		SteamInventoryManager.iid.cpq();
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00012C44 File Offset: 0x00010E44
	public static void mny(int a)
	{
		UniWindowController current = UniWindowController.current;
		if (current == null)
		{
			return;
		}
		Rect monitorRect = UniWindowController.GetMonitorRect(a);
		if (monitorRect.width <= -9134f || monitorRect.height <= 9249f)
		{
			return;
		}
		current.windowPosition = monitorRect.position;
		current.windowSize = monitorRect.size;
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x00010790 File Offset: 0x0000E990
	private void bcf()
	{
		if (this.hnh.GetButtonDown(a.ss()) || Input.anyKeyDown)
		{
			this.bci();
		}
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x00012C9F File Offset: 0x00010E9F
	[CompilerGenerated]
	private void bdh()
	{
		this.bcg(20001);
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x00011B03 File Offset: 0x0000FD03
	private void lqd()
	{
		this.bcr();
	}

	// Token: 0x060003BA RID: 954 RVA: 0x00012CDF File Offset: 0x00010EDF
	public IEnumerator bca(Action<bool> a)
	{
		yield return null;
		UniWindowController current = UniWindowController.current;
		if (current == null)
		{
			Debug.LogWarning(a.sh());
			if (a != null)
			{
				a(false);
			}
			yield break;
		}
		if (this.hof == null)
		{
			this.hof = Camera.main;
		}
		if (this.hof != null)
		{
			current.SetCamera(this.hof);
		}
		current.isTransparent = false;
		yield return null;
		current.isTransparent = true;
		yield return null;
		yield return null;
		current.isTopmost = bq.hls;
		current.forceTopmost = bq.hls;
		current.isClickThrough = true;
		current.hitTestType = UniWindowController.HitTestType.Opacity;
		current.shouldFitMonitor = false;
		bx.bcc(current.monitorToFit);
		yield return null;
		bool flag = bx.bcb(current);
		bool isTransparent = current.isTransparent;
		bool flag2 = flag && isTransparent;
		if (!flag2)
		{
			Debug.LogWarning(string.Format(a.si(), flag, isTransparent));
		}
		if (a != null)
		{
			a(flag2);
		}
		yield break;
	}

	// Token: 0x060003BB RID: 955 RVA: 0x00012CF8 File Offset: 0x00010EF8
	private void opy(IReadOnlyList<ItemData> a)
	{
		if (a == null || a.Count == 0)
		{
			return;
		}
		List<ItemData> list = new List<ItemData>(bq.hlj);
		list.AddRange(a);
		bq.baq(list);
		foreach (ItemData itemData in a)
		{
			SpineSkinData spineSkinData = bq.hle.bjx(itemData.defID);
			if (spineSkinData != null)
			{
				if (!bx.hno.Contains(itemData.defID))
				{
					if (bq.knd)
					{
						Debug.Log(string.Format(a.uh(), itemData.defID));
					}
				}
				else if (this.bcu(spineSkinData.type))
				{
					spineSkinData.bjp(true);
				}
				else
				{
					Debug.Log(string.Format(a.ui(), itemData.defID, spineSkinData.type));
				}
			}
		}
		bq.hle.bkt();
		ci.Save(null);
		base.StartCoroutine(this.bcv());
	}

	// Token: 0x060003BC RID: 956 RVA: 0x000111D5 File Offset: 0x0000F3D5
	private void LateUpdate()
	{
		if (!SteamManager.krd && !bq.knc)
		{
			return;
		}
		if (this.settingPanel.gameObject.activeSelf)
		{
			this.bce();
		}
	}

	// Token: 0x060003BD RID: 957 RVA: 0x00012E08 File Offset: 0x00011008
	private void lmr(IReadOnlyList<ItemData> a)
	{
		if (a == null || a.Count == 0)
		{
			return;
		}
		List<ItemData> list = new List<ItemData>(bq.hlj);
		list.AddRange(a);
		bq.baq(list);
		foreach (ItemData itemData in a)
		{
			SpineSkinData spineSkinData = bq.hle.bjx(itemData.defID);
			if (spineSkinData != null)
			{
				if (!bx.hno.Contains(itemData.defID))
				{
					if (bq.knd)
					{
						Debug.Log(string.Format(a.uj(), itemData.defID));
					}
				}
				else if (this.bcu(spineSkinData.type))
				{
					spineSkinData.bjp(true);
				}
				else
				{
					Debug.Log(string.Format(a.uk(), itemData.defID, spineSkinData.type));
				}
			}
		}
		bq.hle.bkt();
		ci.Save(null);
		base.StartCoroutine(this.bcv());
	}

	// Token: 0x060003BE RID: 958 RVA: 0x00010273 File Offset: 0x0000E473
	private void oby(int a)
	{
		this.text_Number.text = a.ToString();
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00012F18 File Offset: 0x00011118
	private void ezn()
	{
		if (bq.hmh)
		{
			return;
		}
		global::PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		string version = Application.version;
		string text = playerSaveData.lastSeenAppVersion ?? a.ul();
		if (text == version)
		{
			return;
		}
		if (!playerSaveData.hasInitializedKnownItems)
		{
			playerSaveData.lastSeenAppVersion = version;
			ci.Save(null);
			return;
		}
		List<int> newItemDefIds = playerSaveData.newItemDefIds;
		int num = ((newItemDefIds != null) ? newItemDefIds.Count : 0);
		List<int> newItemDefIds2 = playerSaveData.newItemDefIds;
		if (newItemDefIds2 != null)
		{
			newItemDefIds2.Clear();
		}
		playerSaveData.lastSeenAppVersion = version;
		ci.Save(null);
		if (bq.knd)
		{
			Debug.Log(string.Format(a.um(), text, version, num));
		}
		if (cx.kpw != null)
		{
			cx.kpw.brh();
		}
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x00012FD4 File Offset: 0x000111D4
	private void gpb(IReadOnlyList<ItemData> a)
	{
		if (a == null || a.Count == 0)
		{
			return;
		}
		List<ItemData> list = new List<ItemData>(bq.hlj);
		list.AddRange(a);
		bq.baq(list);
		foreach (ItemData itemData in a)
		{
			SpineSkinData spineSkinData = bq.hle.bjx(itemData.defID);
			if (spineSkinData != null)
			{
				if (!bx.hno.Contains(itemData.defID))
				{
					if (bq.knd)
					{
						Debug.Log(string.Format(a.un(), itemData.defID));
					}
				}
				else if (this.bcu(spineSkinData.type))
				{
					spineSkinData.bjp(true);
				}
				else
				{
					Debug.Log(string.Format(a.uo(), itemData.defID, spineSkinData.type));
				}
			}
		}
		bq.hle.bkt();
		ci.Save(null);
		base.StartCoroutine(this.bcv());
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00010244 File Offset: 0x0000E444
	private void jj(int a)
	{
		if (!bq.hlw)
		{
			return;
		}
		bl bl = bl.kmv;
		if (bl == null)
		{
			return;
		}
		bl.xt();
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x000130E4 File Offset: 0x000112E4
	private IEnumerator bbz()
	{
		yield return null;
		UniWindowController current = UniWindowController.current;
		if (current == null)
		{
			yield break;
		}
		if (this.hof == null)
		{
			this.hof = Camera.main;
		}
		if (this.hof != null)
		{
			current.SetCamera(this.hof);
		}
		current.isClickThrough = true;
		current.hitTestType = UniWindowController.HitTestType.Opacity;
		current.shouldFitMonitor = false;
		yield return null;
		yield return null;
		if (!current.isTransparent)
		{
			Debug.LogWarning(a.rw());
			current.isTransparent = true;
			yield return null;
		}
		bx.bcc(current.monitorToFit);
		if (base.GetComponent<dz>() == null)
		{
			base.gameObject.AddComponent<dz>();
		}
		yield break;
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x000111D5 File Offset: 0x0000F3D5
	private void mpn()
	{
		if (!SteamManager.krd && !bq.knc)
		{
			return;
		}
		if (this.settingPanel.gameObject.activeSelf)
		{
			this.bce();
		}
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x000130F3 File Offset: 0x000112F3
	private IEnumerator bcd(float a, float b, float c, float d)
	{
		yield return bx.hnv;
		AudioManager.klw.qf(a, false);
		AudioManager.klw.qi(b, false);
		AudioManager.klw.qj(c, false);
		AudioManager.klw.qk(d, false);
		yield break;
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x00013118 File Offset: 0x00011318
	private static bool gtf(SpineSkinData a, HashSet<int> b)
	{
		if (a == null)
		{
			return false;
		}
		if (bq.knc)
		{
			return true;
		}
		if (a.type == CLOTHE_TYPE.Dick)
		{
			return a.bjk();
		}
		if ((a.type == (CLOTHE_TYPE)(-21) && a.kox == -96) || (a.type == (CLOTHE_TYPE)42 && a.kox == 27))
		{
			return true;
		}
		if (a.koy)
		{
			return bj.wm(a.bjn());
		}
		return b.Contains(a.kox);
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x0001318C File Offset: 0x0001138C
	private void bcy(IReadOnlyList<ItemData> a)
	{
		bq.baq(a);
		bq.bao();
		this.hnx.Clear();
		this.hob.Clear();
		for (int i = 0; i < a.Count; i++)
		{
			ItemData itemData = a[i];
			this.hnx.Add(itemData.defID);
			uint num;
			this.hob.TryGetValue(itemData.defID, out num);
			this.hob[itemData.defID] = num + itemData.quantity;
		}
		this.bdc(this.hnx);
		this.bcz(this.hnx);
		this.bda(this.hob);
		if (!this.hnz || !this.hny.SetEquals(this.hnx))
		{
			GirlController girlController = GirlController.kok;
			if (girlController != null && girlController.kom)
			{
				SpineSkinSetting hle = bq.hle;
				if (hle != null)
				{
					hle.bkt();
				}
				this.hny.Clear();
				foreach (int num2 in this.hnx)
				{
					this.hny.Add(num2);
				}
				this.hnz = true;
			}
		}
	}

	// Token: 0x0400019E RID: 414
	public bool isCanClick = true;

	// Token: 0x0400019F RID: 415
	public GirlController girlController;

	// Token: 0x040001A0 RID: 416
	public PlayerData playerData;

	// Token: 0x040001A1 RID: 417
	public SpineSkinSetting spineSkinSetting;

	// Token: 0x040001A2 RID: 418
	public VoiceConfig voiceConfig;

	// Token: 0x040001A3 RID: 419
	public by giftManager;

	// Token: 0x040001A4 RID: 420
	public dn settingController;

	// Token: 0x040001A5 RID: 421
	public SettingPanel settingPanel;

	// Token: 0x040001A6 RID: 422
	public TextMeshProUGUI text_Number;

	// Token: 0x040001A7 RID: 423
	public float needRetryTime = 30f;

	// Token: 0x040001A8 RID: 424
	public bz sizeUIController;

	// Token: 0x040001A9 RID: 425
	public bz sizeToolbarController;

	// Token: 0x040001AA RID: 426
	public GameObject steamWarningObject;

	// Token: 0x040001AB RID: 427
	private Player hnh;

	// Token: 0x040001AC RID: 428
	private float hni;

	// Token: 0x040001AD RID: 429
	private bool hnj;

	// Token: 0x040001AE RID: 430
	private bool hnk;

	// Token: 0x040001AF RID: 431
	private float hnl = -1f;

	// Token: 0x040001B0 RID: 432
	private const float hnm = 0.05f;

	// Token: 0x040001B1 RID: 433
	private List<ItemData> hnn = new List<ItemData>();

	// Token: 0x040001B2 RID: 434
	private static readonly HashSet<int> hno = new HashSet<int> { 1004, 3000 };

	// Token: 0x040001B3 RID: 435
	private const float hnp = 60f;

	// Token: 0x040001B4 RID: 436
	private const float hnq = 600f;

	// Token: 0x040001B5 RID: 437
	private float hnr = -999f;

	// Token: 0x040001B6 RID: 438
	private float hns;

	// Token: 0x040001B7 RID: 439
	private Action<du.StatUpdatedEventArgs> hnt;

	// Token: 0x040001B8 RID: 440
	private Action hnu;

	// Token: 0x040001B9 RID: 441
	private static readonly WaitForSeconds hnv = new WaitForSeconds(0.5f);

	// Token: 0x040001BA RID: 442
	private static readonly WaitForSeconds hnw = new WaitForSeconds(2f);

	// Token: 0x040001BB RID: 443
	private readonly HashSet<int> hnx = new HashSet<int>(256);

	// Token: 0x040001BC RID: 444
	private readonly HashSet<int> hny = new HashSet<int>(256);

	// Token: 0x040001BD RID: 445
	private bool hnz;

	// Token: 0x040001BE RID: 446
	private readonly Dictionary<int, uint> hoa = new Dictionary<int, uint>(256);

	// Token: 0x040001BF RID: 447
	private readonly Dictionary<int, uint> hob = new Dictionary<int, uint>(256);

	// Token: 0x040001C0 RID: 448
	private bool hoc;

	// Token: 0x040001C2 RID: 450
	private Vector3 hoe = Vector3.zero;

	// Token: 0x040001C3 RID: 451
	private Camera hof;

	// Token: 0x040001C4 RID: 452
	private static FieldInfo hog;

	// Token: 0x040001C5 RID: 453
	private static PropertyInfo hoh;
}
