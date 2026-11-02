using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Steamworks;
using UnityEngine;

// Token: 0x020000D0 RID: 208
public sealed class eg : MonoBehaviour
{
	// Token: 0x06000ABE RID: 2750 RVA: 0x0003F944 File Offset: 0x0003DB44
	public void ciw(string a, string b, string c, string d, string e = "Initial upload")
	{
		if (!this.cjr())
		{
			return;
		}
		if (this.ieo)
		{
			Debug.LogWarning(a.dct());
			return;
		}
		if (!this.cjs(a))
		{
			return;
		}
		this.ieo = true;
		this.iep = a.dcu();
		this.ifb = new eg.ee
		{
			idw = a,
			idy = b,
			idz = c,
			iea = d,
			ieb = e
		};
		SteamAPICall_t steamAPICall_t = SteamUGC.CreateItem(eg.ieg, EWorkshopFileType.k_EWorkshopFileTypeFirst);
		this.ies.Set(steamAPICall_t, null);
	}

	// Token: 0x06000ABF RID: 2751 RVA: 0x0003F9D4 File Offset: 0x0003DBD4
	public static long cij(string a)
	{
		if (string.IsNullOrEmpty(a) || !Directory.Exists(a))
		{
			return -1L;
		}
		long num2;
		try
		{
			long num = 0L;
			foreach (string text in Directory.EnumerateFiles(a, a.dcv(), SearchOption.AllDirectories))
			{
				num += new FileInfo(text).Length;
			}
			num2 = num;
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.dcw() + ex.Message);
			num2 = -1L;
		}
		return num2;
	}

	// Token: 0x06000AC0 RID: 2752 RVA: 0x0003FA74 File Offset: 0x0003DC74
	private void fpf(PublishedFileId_t a, string b, string c, string d, string e, string f)
	{
		this.iep = a.dcx();
		bool flag = true;
		if (string.IsNullOrEmpty(b) || !Directory.Exists(b))
		{
			Debug.LogError(string.Format(a.dcy(), b, Directory.Exists(b ?? a.dcz())));
			flag = false;
		}
		if (!string.IsNullOrEmpty(e) && !File.Exists(e))
		{
			Debug.LogError(string.Format(a.dda(), e, File.Exists(e)));
			flag = false;
		}
		if (string.IsNullOrEmpty(c))
		{
			Debug.LogError(a.ddb());
			flag = false;
		}
		if (!flag)
		{
			this.cjp(a.ddc(), EResult.k_EResultInvalidParam);
			return;
		}
		b = b.Replace(']', (char)(-86));
		if (!string.IsNullOrEmpty(e))
		{
			e = e.Replace('<', (char)(-88));
		}
		UGCUpdateHandle_t ugcupdateHandle_t = SteamUGC.StartItemUpdate(eg.ieg, a);
		if (ugcupdateHandle_t.m_UGCUpdateHandle == 18446744073709551615UL)
		{
			Debug.LogError(a.ddd());
			this.cjp(a.dde(), EResult.k_EResultInvalidParam);
			return;
		}
		bool flag2 = true;
		flag2 &= eg.cjq(a.ddf(), SteamUGC.SetItemTitle(ugcupdateHandle_t, c));
		flag2 &= eg.cjq(a.ddg(), SteamUGC.SetItemDescription(ugcupdateHandle_t, d));
		flag2 &= eg.cjq(a.ddh(), SteamUGC.SetItemContent(ugcupdateHandle_t, b));
		flag2 &= eg.cjq(a.ddi(), SteamUGC.SetItemVisibility(ugcupdateHandle_t, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic));
		if (!string.IsNullOrEmpty(e))
		{
			flag2 &= eg.cjq(a.ddj(), SteamUGC.SetItemPreview(ugcupdateHandle_t, e));
		}
		string text = a.ddk();
		string text2 = Path.Combine(b, a.ddl());
		if (File.Exists(text2))
		{
			try
			{
				CharacterPackageData characterPackageData = JsonUtility.FromJson<CharacterPackageData>(File.ReadAllText(text2));
				if (characterPackageData != null && !string.IsNullOrEmpty(characterPackageData.type))
				{
					text = ((characterPackageData.type == a.ddm()) ? a.ddo() : a.ddn());
				}
			}
			catch (Exception ex)
			{
				Debug.LogWarning(a.ddp() + ex.Message);
			}
		}
		flag2 &= eg.cjq(a.ddq(), SteamUGC.SetItemTags(ugcupdateHandle_t, new List<string> { text }, false));
		if (!flag2)
		{
			Debug.LogWarning(a.ddr());
		}
		SteamAPICall_t steamAPICall_t = SteamUGC.SubmitItemUpdate(ugcupdateHandle_t, f);
		this.iet.Set(steamAPICall_t, null);
	}

	// Token: 0x06000AC1 RID: 2753 RVA: 0x0003FCAC File Offset: 0x0003DEAC
	private void cjo(PublishedFileId_t a, string b, string c, string d, string e, string f)
	{
		this.iep = a.dds();
		bool flag = true;
		if (string.IsNullOrEmpty(b) || !Directory.Exists(b))
		{
			Debug.LogError(string.Format(a.ddt(), b, Directory.Exists(b ?? a.tk())));
			flag = false;
		}
		if (!string.IsNullOrEmpty(e) && !File.Exists(e))
		{
			Debug.LogError(string.Format(a.ddu(), e, File.Exists(e)));
			flag = false;
		}
		if (string.IsNullOrEmpty(c))
		{
			Debug.LogError(a.ddv());
			flag = false;
		}
		if (!flag)
		{
			this.cjp(a.ddw(), EResult.k_EResultInvalidParam);
			return;
		}
		b = b.Replace('\\', '/');
		if (!string.IsNullOrEmpty(e))
		{
			e = e.Replace('\\', '/');
		}
		UGCUpdateHandle_t ugcupdateHandle_t = SteamUGC.StartItemUpdate(eg.ieg, a);
		if (ugcupdateHandle_t.m_UGCUpdateHandle == 18446744073709551615UL)
		{
			Debug.LogError(a.ddx());
			this.cjp(a.ddy(), EResult.k_EResultInvalidParam);
			return;
		}
		bool flag2 = true;
		flag2 &= eg.cjq(a.ddz(), SteamUGC.SetItemTitle(ugcupdateHandle_t, c));
		flag2 &= eg.cjq(a.dea(), SteamUGC.SetItemDescription(ugcupdateHandle_t, d));
		flag2 &= eg.cjq(a.deb(), SteamUGC.SetItemContent(ugcupdateHandle_t, b));
		flag2 &= eg.cjq(a.dec(), SteamUGC.SetItemVisibility(ugcupdateHandle_t, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic));
		if (!string.IsNullOrEmpty(e))
		{
			flag2 &= eg.cjq(a.ded(), SteamUGC.SetItemPreview(ugcupdateHandle_t, e));
		}
		string text = a.dee();
		string text2 = Path.Combine(b, a.cxy());
		if (File.Exists(text2))
		{
			try
			{
				CharacterPackageData characterPackageData = JsonUtility.FromJson<CharacterPackageData>(File.ReadAllText(text2));
				if (characterPackageData != null && !string.IsNullOrEmpty(characterPackageData.type))
				{
					text = ((characterPackageData.type == a.cxe()) ? a.def() : a.dee());
				}
			}
			catch (Exception ex)
			{
				Debug.LogWarning(a.deg() + ex.Message);
			}
		}
		flag2 &= eg.cjq(a.deh(), SteamUGC.SetItemTags(ugcupdateHandle_t, new List<string> { text }, false));
		if (!flag2)
		{
			Debug.LogWarning(a.dei());
		}
		SteamAPICall_t steamAPICall_t = SteamUGC.SubmitItemUpdate(ugcupdateHandle_t, f);
		this.iet.Set(steamAPICall_t, null);
	}

	// Token: 0x06000AC2 RID: 2754 RVA: 0x0003FEE4 File Offset: 0x0003E0E4
	private static bool oii(string a, bool b)
	{
		if (!b)
		{
			Debug.LogError(a.dej() + a + a.dek());
		}
		return b;
	}

	// Token: 0x06000AC3 RID: 2755 RVA: 0x0003FEFF File Offset: 0x0003E0FF
	public void cix(PublishedFileId_t a, string b, string c, string d, string e, string f = "Update")
	{
		if (!this.cjr())
		{
			return;
		}
		if (this.ieo)
		{
			Debug.LogWarning(a.dct());
			return;
		}
		if (!this.cjs(b))
		{
			return;
		}
		this.ieo = true;
		this.cjo(a, b, c, d, e, f);
	}

	// Token: 0x06000AC4 RID: 2756 RVA: 0x0003FF40 File Offset: 0x0003E140
	private void cjg(RemoteStoragePublishedFileSubscribed_t a)
	{
		if (a.m_nAppID != eg.ieg)
		{
			return;
		}
		Debug.Log(string.Format(a.del(), a.m_nPublishedFileId.m_PublishedFileId));
		SteamUGC.DownloadItem(a.m_nPublishedFileId, true);
	}

	// Token: 0x06000AC5 RID: 2757 RVA: 0x0003FF8C File Offset: 0x0003E18C
	private void idi(ItemInstalled_t a)
	{
		if (a.m_unAppID != eg.ieg)
		{
			return;
		}
		Debug.Log(string.Format(a.dem(), a.m_nPublishedFileId.m_PublishedFileId));
		Action action = this.iem;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x14000017 RID: 23
	// (add) Token: 0x06000B19 RID: 2841 RVA: 0x0004231C File Offset: 0x0004051C
	// (remove) Token: 0x06000AC6 RID: 2758 RVA: 0x0003FFDC File Offset: 0x0003E1DC
	public event Action ien;

	// Token: 0x14000016 RID: 22
	// (add) Token: 0x06000AC7 RID: 2759 RVA: 0x00040014 File Offset: 0x0003E214
	// (remove) Token: 0x06000B11 RID: 2833 RVA: 0x00042014 File Offset: 0x00040214
	public event Action iem;

	// Token: 0x06000AC8 RID: 2760 RVA: 0x0004004C File Offset: 0x0003E24C
	private void hbr(DownloadItemResult_t a)
	{
		if (a.m_unAppID != eg.ieg)
		{
			return;
		}
		if (a.m_eResult != EResult.k_EResultOK)
		{
			Debug.LogWarning(string.Format(a.den(), a.m_nPublishedFileId.m_PublishedFileId, a.m_eResult));
			return;
		}
		Debug.Log(string.Format(a.deo(), a.m_nPublishedFileId.m_PublishedFileId));
		Action action = this.iem;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000AC9 RID: 2761 RVA: 0x000400D0 File Offset: 0x0003E2D0
	private void bvy(RemoteStoragePublishedFileUnsubscribed_t a)
	{
		if (a.m_nAppID != eg.ieg)
		{
			return;
		}
		Debug.Log(string.Format(a.dep(), a.m_nPublishedFileId.m_PublishedFileId));
		Action action = this.iem;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x00040120 File Offset: 0x0003E320
	private void cjp(string a, EResult b)
	{
		this.ieo = false;
		this.iep = a.tk();
		this.ifb = null;
		Debug.LogError(string.Format(a.deq(), a, b));
		Action<string, EResult> action = this.iel;
		if (action == null)
		{
			return;
		}
		action(a, b);
	}

	// Token: 0x06000ACB RID: 2763 RVA: 0x0004016E File Offset: 0x0003E36E
	private bool mtl()
	{
		if (!SteamManager.krd)
		{
			Debug.LogError(a.der());
			return false;
		}
		return true;
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x00040184 File Offset: 0x0003E384
	public float kfd()
	{
		if (!this.ieo)
		{
			return -5771f;
		}
		return 2254f;
	}

	// Token: 0x06000ACD RID: 2765 RVA: 0x00040199 File Offset: 0x0003E399
	private bool oji()
	{
		if (!SteamManager.krd)
		{
			Debug.LogError(a.des());
			return false;
		}
		return true;
	}

	// Token: 0x06000ACE RID: 2766 RVA: 0x000401B0 File Offset: 0x0003E3B0
	public void mld(string a, string b, string c, string d, string e = "Initial upload")
	{
		if (!this.cjr())
		{
			return;
		}
		if (this.ieo)
		{
			Debug.LogWarning(a.det());
			return;
		}
		if (!this.cjs(a))
		{
			return;
		}
		this.ieo = true;
		this.iep = a.deu();
		this.ifb = new eg.ee
		{
			idw = a,
			idy = b,
			idz = c,
			iea = d,
			ieb = e
		};
		SteamAPICall_t steamAPICall_t = SteamUGC.CreateItem(eg.ieg, EWorkshopFileType.k_EWorkshopFileTypeFirst);
		this.ies.Set(steamAPICall_t, null);
	}

	// Token: 0x06000ACF RID: 2767 RVA: 0x00040240 File Offset: 0x0003E440
	public void npo(string a, string b, string c, string d, string e = "Initial upload")
	{
		if (!this.cjr())
		{
			return;
		}
		if (this.ieo)
		{
			Debug.LogWarning(a.dev());
			return;
		}
		if (!this.cjs(a))
		{
			return;
		}
		this.ieo = true;
		this.iep = a.dew();
		this.ifb = new eg.ee
		{
			idw = a,
			idy = b,
			idz = c,
			iea = d,
			ieb = e
		};
		SteamAPICall_t steamAPICall_t = SteamUGC.CreateItem(eg.ieg, EWorkshopFileType.k_EWorkshopFileTypeFirst);
		this.ies.Set(steamAPICall_t, null);
	}

	// Token: 0x06000AD0 RID: 2768 RVA: 0x000402D0 File Offset: 0x0003E4D0
	private void lha(ItemInstalled_t a)
	{
		if (a.m_unAppID != eg.ieg)
		{
			return;
		}
		Debug.Log(string.Format(a.dex(), a.m_nPublishedFileId.m_PublishedFileId));
		Action action = this.iem;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000AD1 RID: 2769 RVA: 0x0004031F File Offset: 0x0003E51F
	private static bool cjq(string a, bool b)
	{
		if (!b)
		{
			Debug.LogError(a.dey() + a + a.dez());
		}
		return b;
	}

	// Token: 0x06000AD2 RID: 2770 RVA: 0x0004033C File Offset: 0x0003E53C
	public List<string> ciz()
	{
		List<string> list = new List<string>();
		if (!this.cjr())
		{
			return list;
		}
		uint numSubscribedItems = SteamUGC.GetNumSubscribedItems();
		this.ier = (int)numSubscribedItems;
		if (numSubscribedItems == 0U)
		{
			return list;
		}
		PublishedFileId_t[] array = new PublishedFileId_t[numSubscribedItems];
		SteamUGC.GetSubscribedItems(array, numSubscribedItems);
		foreach (PublishedFileId_t publishedFileId_t in array)
		{
			uint itemState = SteamUGC.GetItemState(publishedFileId_t);
			bool flag = (itemState & 4U) > 0U;
			bool flag2 = (itemState & 8U) > 0U;
			if (flag && !flag2)
			{
				ulong num;
				string text;
				uint num2;
				if (SteamUGC.GetItemInstallInfo(publishedFileId_t, out num, out text, 1024U, out num2) && !string.IsNullOrEmpty(text))
				{
					list.Add(text);
				}
			}
			else if (flag2 || !flag)
			{
				SteamUGC.DownloadItem(publishedFileId_t, true);
				Debug.Log(string.Format(a.dfa(), publishedFileId_t.m_PublishedFileId));
			}
		}
		Debug.Log(string.Format(a.dfb(), list.Count, numSubscribedItems - (uint)list.Count));
		return list;
	}

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x00040430 File Offset: 0x0003E630
	public int krt
	{
		get
		{
			if (!SteamManager.krd)
			{
				return 0;
			}
			return (int)SteamUGC.GetNumSubscribedItems();
		}
	}

	// Token: 0x06000AD4 RID: 2772 RVA: 0x00040440 File Offset: 0x0003E640
	private void hvx(ItemInstalled_t a)
	{
		if (a.m_unAppID != eg.ieg)
		{
			return;
		}
		Debug.Log(string.Format(a.dfc(), a.m_nPublishedFileId.m_PublishedFileId));
		Action action = this.iem;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000AD5 RID: 2773 RVA: 0x00040490 File Offset: 0x0003E690
	private bool cjs(string a)
	{
		long num = eg.cij(a);
		if (num < 0L)
		{
			return true;
		}
		if (num <= 209715200L)
		{
			return true;
		}
		double num2 = (double)num / 1048576.0;
		double num3 = 200.0;
		string text = string.Format(a.dfd(), num2, num3);
		Debug.LogError(string.Concat(new string[]
		{
			a.dey(),
			text,
			a.dfe(),
			a,
			a.dff()
		}));
		Action<string, EResult> action = this.iel;
		if (action != null)
		{
			action(text, EResult.k_EResultLimitExceeded);
		}
		return false;
	}

	// Token: 0x06000AD6 RID: 2774 RVA: 0x0004052C File Offset: 0x0003E72C
	private void cjd(SubmitItemUpdateResult_t a, bool b)
	{
		this.ieo = false;
		this.iep = a.tk();
		if (b)
		{
			this.cjp(a.dfg(), EResult.k_EResultIOFailure);
			return;
		}
		if (a.m_eResult != EResult.k_EResultOK)
		{
			this.cjp(a.dfg(), a.m_eResult);
			return;
		}
		Debug.Log(a.dfh() + (a.m_bUserNeedsToAcceptWorkshopLegalAgreement ? a.dfi() : a.tk()));
		if (a.m_bUserNeedsToAcceptWorkshopLegalAgreement)
		{
			Action action = this.ien;
			if (action != null)
			{
				action();
			}
		}
		Action<PublishedFileId_t> action2 = this.iek;
		if (action2 == null)
		{
			return;
		}
		action2(a.m_nPublishedFileId);
	}

	// Token: 0x06000AD7 RID: 2775 RVA: 0x000405CC File Offset: 0x0003E7CC
	private void cje(DownloadItemResult_t a)
	{
		if (a.m_unAppID != eg.ieg)
		{
			return;
		}
		if (a.m_eResult != EResult.k_EResultOK)
		{
			Debug.LogWarning(string.Format(a.dfj(), a.m_nPublishedFileId.m_PublishedFileId, a.m_eResult));
			return;
		}
		Debug.Log(string.Format(a.dfk(), a.m_nPublishedFileId.m_PublishedFileId));
		Action action = this.iem;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x00040650 File Offset: 0x0003E850
	private void cjf(ItemInstalled_t a)
	{
		if (a.m_unAppID != eg.ieg)
		{
			return;
		}
		Debug.Log(string.Format(a.dfl(), a.m_nPublishedFileId.m_PublishedFileId));
		Action action = this.iem;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x14000013 RID: 19
	// (add) Token: 0x06000B10 RID: 2832 RVA: 0x00041FDC File Offset: 0x000401DC
	// (remove) Token: 0x06000AD9 RID: 2777 RVA: 0x000406A0 File Offset: 0x0003E8A0
	public event Action<PublishedFileId_t> iej;

	// Token: 0x06000ADA RID: 2778 RVA: 0x000406D8 File Offset: 0x0003E8D8
	private void wl(SubmitItemUpdateResult_t a, bool b)
	{
		this.ieo = false;
		this.iep = a.dfm();
		if (b)
		{
			this.cjp(a.dfn(), (EResult)(-74));
			return;
		}
		if (a.m_eResult != EResult.k_EResultOK)
		{
			this.cjp(a.dfo(), a.m_eResult);
			return;
		}
		Debug.Log(a.dfp() + (a.m_bUserNeedsToAcceptWorkshopLegalAgreement ? a.dfr() : a.dfq()));
		if (a.m_bUserNeedsToAcceptWorkshopLegalAgreement)
		{
			Action action = this.ien;
			if (action != null)
			{
				action();
			}
		}
		Action<PublishedFileId_t> action2 = this.iek;
		if (action2 == null)
		{
			return;
		}
		action2(a.m_nPublishedFileId);
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x00040775 File Offset: 0x0003E975
	private void fpd()
	{
		if (eg.iei != null && eg.iei != this)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		eg.iei = this;
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x000407A0 File Offset: 0x0003E9A0
	private void mxv(SubmitItemUpdateResult_t a, bool b)
	{
		this.ieo = false;
		this.iep = a.dfs();
		if (b)
		{
			this.cjp(a.dft(), (EResult)(-63));
			return;
		}
		if (a.m_eResult != EResult.k_EResultOK)
		{
			this.cjp(a.dfu(), a.m_eResult);
			return;
		}
		Debug.Log(a.dfv() + (a.m_bUserNeedsToAcceptWorkshopLegalAgreement ? a.dfx() : a.dfw()));
		if (a.m_bUserNeedsToAcceptWorkshopLegalAgreement)
		{
			Action action = this.ien;
			if (action != null)
			{
				action();
			}
		}
		Action<PublishedFileId_t> action2 = this.iek;
		if (action2 == null)
		{
			return;
		}
		action2(a.m_nPublishedFileId);
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x00040840 File Offset: 0x0003EA40
	public void cjk()
	{
		if (!this.cjr())
		{
			return;
		}
		UGCQueryHandle_t ugcqueryHandle_t = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Published, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, eg.ieg, eg.ieg, 1U);
		if (this.ieu == null)
		{
			this.ieu = CallResult<SteamUGCQueryCompleted_t>.Create(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(this.cjl));
		}
		SteamAPICall_t steamAPICall_t = SteamUGC.SendQueryUGCRequest(ugcqueryHandle_t);
		this.ieu.Set(steamAPICall_t, null);
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x000408A8 File Offset: 0x0003EAA8
	private bool lkf(string a)
	{
		long num = eg.cij(a);
		if (num < 0L)
		{
			return true;
		}
		if (num <= -46L)
		{
			return true;
		}
		double num2 = (double)num / -2394.0;
		double num3 = -5361.0;
		string text = string.Format(a.dfy(), num2, num3);
		Debug.LogError(string.Concat(new string[]
		{
			a.dfz(),
			text,
			a.dga(),
			a,
			a.dgb()
		}));
		Action<string, EResult> action = this.iel;
		if (action != null)
		{
			action(text, EResult.k_EResultExpired);
		}
		return false;
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0004093E File Offset: 0x0003EB3E
	public static eg krr
	{
		get
		{
			return eg.iei;
		}
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x00040945 File Offset: 0x0003EB45
	private bool dkb()
	{
		if (!SteamManager.krd)
		{
			Debug.LogError(a.dgc());
			return false;
		}
		return true;
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x0004095B File Offset: 0x0003EB5B
	private bool cjr()
	{
		if (!SteamManager.krd)
		{
			Debug.LogError(a.dgd());
			return false;
		}
		return true;
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x00040971 File Offset: 0x0003EB71
	private bool ots()
	{
		if (!SteamManager.krd)
		{
			Debug.LogError(a.dge());
			return false;
		}
		return true;
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x00040988 File Offset: 0x0003EB88
	public List<string> dbb()
	{
		List<string> list = new List<string>();
		if (!this.cjr())
		{
			return list;
		}
		uint numSubscribedItems = SteamUGC.GetNumSubscribedItems();
		this.ier = (int)numSubscribedItems;
		if (numSubscribedItems == 0U)
		{
			return list;
		}
		PublishedFileId_t[] array = new PublishedFileId_t[numSubscribedItems];
		SteamUGC.GetSubscribedItems(array, numSubscribedItems);
		foreach (PublishedFileId_t publishedFileId_t in array)
		{
			uint itemState = SteamUGC.GetItemState(publishedFileId_t);
			bool flag = (itemState & 4U) > 0U;
			bool flag2 = (itemState & 8U) > 0U;
			if (flag && !flag2)
			{
				ulong num;
				string text;
				uint num2;
				if (SteamUGC.GetItemInstallInfo(publishedFileId_t, out num, out text, 4294967222U, out num2) && !string.IsNullOrEmpty(text))
				{
					list.Add(text);
				}
			}
			else if (flag2 || !flag)
			{
				SteamUGC.DownloadItem(publishedFileId_t, true);
				Debug.Log(string.Format(a.dgf(), publishedFileId_t.m_PublishedFileId));
			}
		}
		Debug.Log(string.Format(a.dgg(), list.Count, numSubscribedItems - (uint)list.Count));
		return list;
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x00040A79 File Offset: 0x0003EC79
	private static bool bmj(string a, bool b)
	{
		if (!b)
		{
			Debug.LogError(a.dgh() + a + a.dgi());
		}
		return b;
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x00040A94 File Offset: 0x0003EC94
	private void lhz(DeleteItemResult_t a, bool b)
	{
		bool flag = !b && a.m_eResult == EResult.k_EResultOK;
		if (!flag)
		{
			Debug.LogError(string.Format(a.dgj(), a.m_eResult));
		}
		else
		{
			Debug.Log(a.dgk());
		}
		Action<bool> action = this.iew;
		if (action != null)
		{
			action(flag);
		}
		this.iew = null;
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x00040AF3 File Offset: 0x0003ECF3
	public float gul()
	{
		if (!this.ieo)
		{
			return 6520f;
		}
		return 8137f;
	}

	// Token: 0x14000018 RID: 24
	// (add) Token: 0x06000AE7 RID: 2791 RVA: 0x00040B08 File Offset: 0x0003ED08
	// (remove) Token: 0x06000AF4 RID: 2804 RVA: 0x0004109C File Offset: 0x0003F29C
	public event Action<List<SteamUGCDetails_t>> ifc;

	// Token: 0x06000AE8 RID: 2792 RVA: 0x00040B40 File Offset: 0x0003ED40
	public void fsl(PublishedFileId_t a, Action<bool> b = null)
	{
		if (!this.cjr())
		{
			if (b != null)
			{
				b(false);
			}
			return;
		}
		this.iew = b;
		if (this.iev == null)
		{
			this.iev = CallResult<DeleteItemResult_t>.Create(new CallResult<DeleteItemResult_t>.APIDispatchDelegate(this.cjn));
		}
		SteamAPICall_t steamAPICall_t = SteamUGC.DeleteItem(a);
		this.iev.Set(steamAPICall_t, null);
	}

	// Token: 0x06000AE9 RID: 2793 RVA: 0x00040B9C File Offset: 0x0003ED9C
	private void lvu(DeleteItemResult_t a, bool b)
	{
		bool flag = !b && a.m_eResult == EResult.k_EResultOK;
		if (!flag)
		{
			Debug.LogError(string.Format(a.dgl(), a.m_eResult));
		}
		else
		{
			Debug.Log(a.dgm());
		}
		Action<bool> action = this.iew;
		if (action != null)
		{
			action(flag);
		}
		this.iew = null;
	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x00040BFC File Offset: 0x0003EDFC
	private void cya()
	{
		if (!SteamManager.krd)
		{
			Debug.LogWarning(a.dgn());
			return;
		}
		this.ies = CallResult<CreateItemResult_t>.Create(new CallResult<CreateItemResult_t>.APIDispatchDelegate(this.cjb));
		this.iet = CallResult<SubmitItemUpdateResult_t>.Create(new CallResult<SubmitItemUpdateResult_t>.APIDispatchDelegate(this.cjd));
		this.iex = Callback<DownloadItemResult_t>.Create(new Callback<DownloadItemResult_t>.DispatchDelegate(this.cje));
		this.iey = Callback<ItemInstalled_t>.Create(new Callback<ItemInstalled_t>.DispatchDelegate(this.cjf));
		this.iez = Callback<RemoteStoragePublishedFileSubscribed_t>.Create(new Callback<RemoteStoragePublishedFileSubscribed_t>.DispatchDelegate(this.cjg));
		this.ifa = Callback<RemoteStoragePublishedFileUnsubscribed_t>.Create(new Callback<RemoteStoragePublishedFileUnsubscribed_t>.DispatchDelegate(this.cjh));
	}

	// Token: 0x06000AEB RID: 2795 RVA: 0x00040CA8 File Offset: 0x0003EEA8
	private void cjb(CreateItemResult_t a, bool b)
	{
		if (b)
		{
			this.cjp(a.dgo(), EResult.k_EResultIOFailure);
			return;
		}
		if (a.m_eResult != EResult.k_EResultOK)
		{
			this.cjp(a.dgo(), a.m_eResult);
			return;
		}
		PublishedFileId_t nPublishedFileId = a.m_nPublishedFileId;
		this.ieq = nPublishedFileId.m_PublishedFileId;
		Debug.Log(string.Format(a.dgp(), nPublishedFileId.m_PublishedFileId) + (a.m_bUserNeedsToAcceptWorkshopLegalAgreement ? a.dfi() : a.tk()));
		if (a.m_bUserNeedsToAcceptWorkshopLegalAgreement)
		{
			Action action = this.ien;
			if (action != null)
			{
				action();
			}
		}
		Action<PublishedFileId_t> action2 = this.iej;
		if (action2 != null)
		{
			action2(nPublishedFileId);
		}
		if (this.ifb != null)
		{
			base.StartCoroutine(this.cjc(nPublishedFileId));
			return;
		}
		this.ieo = false;
		this.iep = a.tk();
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x00040D90 File Offset: 0x0003EF90
	private void hrb()
	{
		CallResult<CreateItemResult_t> callResult = this.ies;
		if (callResult != null)
		{
			callResult.Dispose();
		}
		CallResult<SubmitItemUpdateResult_t> callResult2 = this.iet;
		if (callResult2 != null)
		{
			callResult2.Dispose();
		}
		this.ies = null;
		this.iet = null;
		CallResult<SteamUGCQueryCompleted_t> callResult3 = this.ieu;
		if (callResult3 != null)
		{
			callResult3.Dispose();
		}
		this.ieu = null;
		CallResult<DeleteItemResult_t> callResult4 = this.iev;
		if (callResult4 != null)
		{
			callResult4.Dispose();
		}
		this.iev = null;
		Callback<DownloadItemResult_t> callback = this.iex;
		if (callback != null)
		{
			callback.Unregister();
		}
		Callback<ItemInstalled_t> callback2 = this.iey;
		if (callback2 != null)
		{
			callback2.Unregister();
		}
		Callback<RemoteStoragePublishedFileSubscribed_t> callback3 = this.iez;
		if (callback3 != null)
		{
			callback3.Unregister();
		}
		Callback<RemoteStoragePublishedFileUnsubscribed_t> callback4 = this.ifa;
		if (callback4 != null)
		{
			callback4.Unregister();
		}
		this.iex = null;
		this.iey = null;
		this.iez = null;
		this.ifa = null;
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x00040E60 File Offset: 0x0003F060
	public void odi(string a, string b, string c, string d, string e = "Initial upload")
	{
		if (!this.cjr())
		{
			return;
		}
		if (this.ieo)
		{
			Debug.LogWarning(a.dgq());
			return;
		}
		if (!this.cjs(a))
		{
			return;
		}
		this.ieo = true;
		this.iep = a.dgr();
		this.ifb = new eg.ee
		{
			idw = a,
			idy = b,
			idz = c,
			iea = d,
			ieb = e
		};
		SteamAPICall_t steamAPICall_t = SteamUGC.CreateItem(eg.ieg, EWorkshopFileType.k_EWorkshopFileTypeFirst);
		this.ies.Set(steamAPICall_t, null);
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x00040EF0 File Offset: 0x0003F0F0
	private void cjn(DeleteItemResult_t a, bool b)
	{
		bool flag = !b && a.m_eResult == EResult.k_EResultOK;
		if (!flag)
		{
			Debug.LogError(string.Format(a.dgs(), a.m_eResult));
		}
		else
		{
			Debug.Log(a.dgt());
		}
		Action<bool> action = this.iew;
		if (action != null)
		{
			action(flag);
		}
		this.iew = null;
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x00040F4F File Offset: 0x0003F14F
	public bool krs
	{
		get
		{
			return this.ieo;
		}
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x00040F58 File Offset: 0x0003F158
	private void lgk(DeleteItemResult_t a, bool b)
	{
		bool flag = !b && a.m_eResult == EResult.k_EResultOK;
		if (!flag)
		{
			Debug.LogError(string.Format(a.dgu(), a.m_eResult));
		}
		else
		{
			Debug.Log(a.dgv());
		}
		Action<bool> action = this.iew;
		if (action != null)
		{
			action(flag);
		}
		this.iew = null;
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x00040FB7 File Offset: 0x0003F1B7
	public float kdy()
	{
		if (!this.ieo)
		{
			return -5090f;
		}
		return 1313f;
	}

	// Token: 0x06000AF3 RID: 2803 RVA: 0x00040FCC File Offset: 0x0003F1CC
	private void lfo()
	{
		CallResult<CreateItemResult_t> callResult = this.ies;
		if (callResult != null)
		{
			callResult.Dispose();
		}
		CallResult<SubmitItemUpdateResult_t> callResult2 = this.iet;
		if (callResult2 != null)
		{
			callResult2.Dispose();
		}
		this.ies = null;
		this.iet = null;
		CallResult<SteamUGCQueryCompleted_t> callResult3 = this.ieu;
		if (callResult3 != null)
		{
			callResult3.Dispose();
		}
		this.ieu = null;
		CallResult<DeleteItemResult_t> callResult4 = this.iev;
		if (callResult4 != null)
		{
			callResult4.Dispose();
		}
		this.iev = null;
		Callback<DownloadItemResult_t> callback = this.iex;
		if (callback != null)
		{
			callback.Unregister();
		}
		Callback<ItemInstalled_t> callback2 = this.iey;
		if (callback2 != null)
		{
			callback2.Unregister();
		}
		Callback<RemoteStoragePublishedFileSubscribed_t> callback3 = this.iez;
		if (callback3 != null)
		{
			callback3.Unregister();
		}
		Callback<RemoteStoragePublishedFileUnsubscribed_t> callback4 = this.ifa;
		if (callback4 != null)
		{
			callback4.Unregister();
		}
		this.iex = null;
		this.iey = null;
		this.iez = null;
		this.ifa = null;
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x000410D4 File Offset: 0x0003F2D4
	private void pg(string a, EResult b)
	{
		this.ieo = false;
		this.iep = a.dgw();
		this.ifb = null;
		Debug.LogError(string.Format(a.dgx(), a, b));
		Action<string, EResult> action = this.iel;
		if (action == null)
		{
			return;
		}
		action(a, b);
	}

	// Token: 0x14000015 RID: 21
	// (add) Token: 0x06000AF6 RID: 2806 RVA: 0x00041124 File Offset: 0x0003F324
	// (remove) Token: 0x06000B07 RID: 2823 RVA: 0x000419D8 File Offset: 0x0003FBD8
	public event Action<string, EResult> iel;

	// Token: 0x06000AF7 RID: 2807 RVA: 0x0004115C File Offset: 0x0003F35C
	private void faf(SubmitItemUpdateResult_t a, bool b)
	{
		this.ieo = false;
		this.iep = a.dgy();
		if (b)
		{
			this.cjp(a.dgz(), EResult.k_EResultRemoteDisconnect);
			return;
		}
		if (a.m_eResult != EResult.k_EResultOK)
		{
			this.cjp(a.dha(), a.m_eResult);
			return;
		}
		Debug.Log(a.dhb() + (a.m_bUserNeedsToAcceptWorkshopLegalAgreement ? a.dhd() : a.dhc()));
		if (a.m_bUserNeedsToAcceptWorkshopLegalAgreement)
		{
			Action action = this.ien;
			if (action != null)
			{
				action();
			}
		}
		Action<PublishedFileId_t> action2 = this.iek;
		if (action2 == null)
		{
			return;
		}
		action2(a.m_nPublishedFileId);
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x000411F9 File Offset: 0x0003F3F9
	public static long krq
	{
		get
		{
			return 209715200L;
		}
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x00041204 File Offset: 0x0003F404
	private void cjh(RemoteStoragePublishedFileUnsubscribed_t a)
	{
		if (a.m_nAppID != eg.ieg)
		{
			return;
		}
		Debug.Log(string.Format(a.dhe(), a.m_nPublishedFileId.m_PublishedFileId));
		Action action = this.iem;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000AFA RID: 2810 RVA: 0x00041254 File Offset: 0x0003F454
	private void drz()
	{
		if (!SteamManager.krd)
		{
			Debug.LogWarning(a.dhf());
			return;
		}
		this.ies = CallResult<CreateItemResult_t>.Create(new CallResult<CreateItemResult_t>.APIDispatchDelegate(this.cjb));
		this.iet = CallResult<SubmitItemUpdateResult_t>.Create(new CallResult<SubmitItemUpdateResult_t>.APIDispatchDelegate(this.cjd));
		this.iex = Callback<DownloadItemResult_t>.Create(new Callback<DownloadItemResult_t>.DispatchDelegate(this.cje));
		this.iey = Callback<ItemInstalled_t>.Create(new Callback<ItemInstalled_t>.DispatchDelegate(this.cjf));
		this.iez = Callback<RemoteStoragePublishedFileSubscribed_t>.Create(new Callback<RemoteStoragePublishedFileSubscribed_t>.DispatchDelegate(this.cjg));
		this.ifa = Callback<RemoteStoragePublishedFileUnsubscribed_t>.Create(new Callback<RemoteStoragePublishedFileUnsubscribed_t>.DispatchDelegate(this.cjh));
	}

	// Token: 0x14000014 RID: 20
	// (add) Token: 0x06000AFB RID: 2811 RVA: 0x00041300 File Offset: 0x0003F500
	// (remove) Token: 0x06000B16 RID: 2838 RVA: 0x00042168 File Offset: 0x00040368
	public event Action<PublishedFileId_t> iek;

	// Token: 0x06000AFC RID: 2812 RVA: 0x00041338 File Offset: 0x0003F538
	private void nhb(RemoteStoragePublishedFileSubscribed_t a)
	{
		if (a.m_nAppID != eg.ieg)
		{
			return;
		}
		Debug.Log(string.Format(a.dhg(), a.m_nPublishedFileId.m_PublishedFileId));
		SteamUGC.DownloadItem(a.m_nPublishedFileId, true);
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x00041384 File Offset: 0x0003F584
	private void nkm(SubmitItemUpdateResult_t a, bool b)
	{
		this.ieo = false;
		this.iep = a.dhh();
		if (b)
		{
			this.cjp(a.dhi(), EResult.k_EResultAccountLoginDeniedThrottle);
			return;
		}
		if (a.m_eResult != EResult.k_EResultOK)
		{
			this.cjp(a.dhj(), a.m_eResult);
			return;
		}
		Debug.Log(a.dhk() + (a.m_bUserNeedsToAcceptWorkshopLegalAgreement ? a.dhm() : a.dhl()));
		if (a.m_bUserNeedsToAcceptWorkshopLegalAgreement)
		{
			Action action = this.ien;
			if (action != null)
			{
				action();
			}
		}
		Action<PublishedFileId_t> action2 = this.iek;
		if (action2 == null)
		{
			return;
		}
		action2(a.m_nPublishedFileId);
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x00041424 File Offset: 0x0003F624
	private void lln(CreateItemResult_t a, bool b)
	{
		if (b)
		{
			this.cjp(a.dhn(), (EResult)(-18));
			return;
		}
		if (a.m_eResult != EResult.k_EResultOK)
		{
			this.cjp(a.dho(), a.m_eResult);
			return;
		}
		PublishedFileId_t nPublishedFileId = a.m_nPublishedFileId;
		this.ieq = nPublishedFileId.m_PublishedFileId;
		Debug.Log(string.Format(a.dhp(), nPublishedFileId.m_PublishedFileId) + (a.m_bUserNeedsToAcceptWorkshopLegalAgreement ? a.dhr() : a.dhq()));
		if (a.m_bUserNeedsToAcceptWorkshopLegalAgreement)
		{
			Action action = this.ien;
			if (action != null)
			{
				action();
			}
		}
		Action<PublishedFileId_t> action2 = this.iej;
		if (action2 != null)
		{
			action2(nPublishedFileId);
		}
		if (this.ifb != null)
		{
			base.StartCoroutine(this.cjc(nPublishedFileId));
			return;
		}
		this.ieo = false;
		this.iep = a.dhs();
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x000414F8 File Offset: 0x0003F6F8
	private void hox(SteamUGCQueryCompleted_t a, bool b)
	{
		List<SteamUGCDetails_t> list = new List<SteamUGCDetails_t>();
		if (!b && a.m_eResult == EResult.k_EResultOK)
		{
			for (uint num = 0U; num < a.m_unNumResultsReturned; num += 1U)
			{
				SteamUGCDetails_t steamUGCDetails_t;
				if (SteamUGC.GetQueryUGCResult(a.m_handle, num, out steamUGCDetails_t))
				{
					list.Add(steamUGCDetails_t);
				}
			}
		}
		else
		{
			Debug.LogWarning(string.Format(a.dht(), a.m_eResult));
		}
		SteamUGC.ReleaseQueryUGCRequest(a.m_handle);
		Action<List<SteamUGCDetails_t>> action = this.ifc;
		if (action == null)
		{
			return;
		}
		action(list);
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x00041578 File Offset: 0x0003F778
	private void eis(RemoteStoragePublishedFileSubscribed_t a)
	{
		if (a.m_nAppID != eg.ieg)
		{
			return;
		}
		Debug.Log(string.Format(a.dhu(), a.m_nPublishedFileId.m_PublishedFileId));
		SteamUGC.DownloadItem(a.m_nPublishedFileId, true);
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x000415C4 File Offset: 0x0003F7C4
	private void iym(SteamUGCQueryCompleted_t a, bool b)
	{
		List<SteamUGCDetails_t> list = new List<SteamUGCDetails_t>();
		if (!b && a.m_eResult == EResult.k_EResultOK)
		{
			for (uint num = 0U; num < a.m_unNumResultsReturned; num += 1U)
			{
				SteamUGCDetails_t steamUGCDetails_t;
				if (SteamUGC.GetQueryUGCResult(a.m_handle, num, out steamUGCDetails_t))
				{
					list.Add(steamUGCDetails_t);
				}
			}
		}
		else
		{
			Debug.LogWarning(string.Format(a.dhv(), a.m_eResult));
		}
		SteamUGC.ReleaseQueryUGCRequest(a.m_handle);
		Action<List<SteamUGCDetails_t>> action = this.ifc;
		if (action == null)
		{
			return;
		}
		action(list);
	}

	// Token: 0x06000B02 RID: 2818 RVA: 0x00041644 File Offset: 0x0003F844
	public void cjm(PublishedFileId_t a, Action<bool> b = null)
	{
		if (!this.cjr())
		{
			if (b != null)
			{
				b(false);
			}
			return;
		}
		this.iew = b;
		if (this.iev == null)
		{
			this.iev = CallResult<DeleteItemResult_t>.Create(new CallResult<DeleteItemResult_t>.APIDispatchDelegate(this.cjn));
		}
		SteamAPICall_t steamAPICall_t = SteamUGC.DeleteItem(a);
		this.iev.Set(steamAPICall_t, null);
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x000416A0 File Offset: 0x0003F8A0
	private void eub()
	{
		CallResult<CreateItemResult_t> callResult = this.ies;
		if (callResult != null)
		{
			callResult.Dispose();
		}
		CallResult<SubmitItemUpdateResult_t> callResult2 = this.iet;
		if (callResult2 != null)
		{
			callResult2.Dispose();
		}
		this.ies = null;
		this.iet = null;
		CallResult<SteamUGCQueryCompleted_t> callResult3 = this.ieu;
		if (callResult3 != null)
		{
			callResult3.Dispose();
		}
		this.ieu = null;
		CallResult<DeleteItemResult_t> callResult4 = this.iev;
		if (callResult4 != null)
		{
			callResult4.Dispose();
		}
		this.iev = null;
		Callback<DownloadItemResult_t> callback = this.iex;
		if (callback != null)
		{
			callback.Unregister();
		}
		Callback<ItemInstalled_t> callback2 = this.iey;
		if (callback2 != null)
		{
			callback2.Unregister();
		}
		Callback<RemoteStoragePublishedFileSubscribed_t> callback3 = this.iez;
		if (callback3 != null)
		{
			callback3.Unregister();
		}
		Callback<RemoteStoragePublishedFileUnsubscribed_t> callback4 = this.ifa;
		if (callback4 != null)
		{
			callback4.Unregister();
		}
		this.iex = null;
		this.iey = null;
		this.iez = null;
		this.ifa = null;
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x0004176D File Offset: 0x0003F96D
	public float bui()
	{
		if (!this.ieo)
		{
			return 1051f;
		}
		return -3523f;
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x00041782 File Offset: 0x0003F982
	private static bool bro(string a, bool b)
	{
		if (!b)
		{
			Debug.LogError(a.dhw() + a + a.dhx());
		}
		return b;
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x000417A0 File Offset: 0x0003F9A0
	private void jgf(PublishedFileId_t a, string b, string c, string d, string e, string f)
	{
		this.iep = a.dhy();
		bool flag = true;
		if (string.IsNullOrEmpty(b) || !Directory.Exists(b))
		{
			Debug.LogError(string.Format(a.dhz(), b, Directory.Exists(b ?? a.dia())));
			flag = false;
		}
		if (!string.IsNullOrEmpty(e) && !File.Exists(e))
		{
			Debug.LogError(string.Format(a.dib(), e, File.Exists(e)));
			flag = false;
		}
		if (string.IsNullOrEmpty(c))
		{
			Debug.LogError(a.dic());
			flag = false;
		}
		if (!flag)
		{
			this.cjp(a.did(), EResult.k_EResultInvalidParam);
			return;
		}
		b = b.Replace('\n', ']');
		if (!string.IsNullOrEmpty(e))
		{
			e = e.Replace((char)(-46), (char)(-42));
		}
		UGCUpdateHandle_t ugcupdateHandle_t = SteamUGC.StartItemUpdate(eg.ieg, a);
		if (ugcupdateHandle_t.m_UGCUpdateHandle == 18446744073709551615UL)
		{
			Debug.LogError(a.die());
			this.cjp(a.dif(), EResult.k_EResultInvalidParam);
			return;
		}
		bool flag2 = true;
		flag2 &= eg.cjq(a.dig(), SteamUGC.SetItemTitle(ugcupdateHandle_t, c));
		flag2 &= eg.cjq(a.dih(), SteamUGC.SetItemDescription(ugcupdateHandle_t, d));
		flag2 &= eg.cjq(a.dii(), SteamUGC.SetItemContent(ugcupdateHandle_t, b));
		flag2 &= eg.cjq(a.dij(), SteamUGC.SetItemVisibility(ugcupdateHandle_t, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic));
		if (!string.IsNullOrEmpty(e))
		{
			flag2 &= eg.cjq(a.dik(), SteamUGC.SetItemPreview(ugcupdateHandle_t, e));
		}
		string text = a.dil();
		string text2 = Path.Combine(b, a.dim());
		if (File.Exists(text2))
		{
			try
			{
				CharacterPackageData characterPackageData = JsonUtility.FromJson<CharacterPackageData>(File.ReadAllText(text2));
				if (characterPackageData != null && !string.IsNullOrEmpty(characterPackageData.type))
				{
					text = ((characterPackageData.type == a.din()) ? a.dip() : a.dio());
				}
			}
			catch (Exception ex)
			{
				Debug.LogWarning(a.diq() + ex.Message);
			}
		}
		flag2 &= eg.cjq(a.dir(), SteamUGC.SetItemTags(ugcupdateHandle_t, new List<string> { text }, false));
		if (!flag2)
		{
			Debug.LogWarning(a.dis());
		}
		SteamAPICall_t steamAPICall_t = SteamUGC.SubmitItemUpdate(ugcupdateHandle_t, f);
		this.iet.Set(steamAPICall_t, null);
	}

	// Token: 0x06000B08 RID: 2824 RVA: 0x00041A10 File Offset: 0x0003FC10
	private void ghu(DeleteItemResult_t a, bool b)
	{
		bool flag = !b && a.m_eResult == EResult.k_EResultOK;
		if (!flag)
		{
			Debug.LogError(string.Format(a.dit(), a.m_eResult));
		}
		else
		{
			Debug.Log(a.diu());
		}
		Action<bool> action = this.iew;
		if (action != null)
		{
			action(flag);
		}
		this.iew = null;
	}

	// Token: 0x06000B09 RID: 2825 RVA: 0x00041A6F File Offset: 0x0003FC6F
	private IEnumerator cjc(PublishedFileId_t a)
	{
		this.iep = a.dcs();
		yield return new WaitForSeconds(2f);
		if (this.ifb == null)
		{
			yield break;
		}
		eg.ee ee = this.ifb;
		this.ifb = null;
		this.cjo(a, ee.idw, ee.idy, ee.idz, ee.iea, ee.ieb);
		yield break;
	}

	// Token: 0x06000B0A RID: 2826 RVA: 0x00040775 File Offset: 0x0003E975
	private void Awake()
	{
		if (eg.iei != null && eg.iei != this)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		eg.iei = this;
	}

	// Token: 0x06000B0B RID: 2827 RVA: 0x00041A88 File Offset: 0x0003FC88
	private void fbt(PublishedFileId_t a, string b, string c, string d, string e, string f)
	{
		this.iep = a.div();
		bool flag = true;
		if (string.IsNullOrEmpty(b) || !Directory.Exists(b))
		{
			Debug.LogError(string.Format(a.diw(), b, Directory.Exists(b ?? a.dix())));
			flag = false;
		}
		if (!string.IsNullOrEmpty(e) && !File.Exists(e))
		{
			Debug.LogError(string.Format(a.diy(), e, File.Exists(e)));
			flag = false;
		}
		if (string.IsNullOrEmpty(c))
		{
			Debug.LogError(a.diz());
			flag = false;
		}
		if (!flag)
		{
			this.cjp(a.dja(), EResult.k_EResultInvalidParam);
			return;
		}
		b = b.Replace((char)(-36), '!');
		if (!string.IsNullOrEmpty(e))
		{
			e = e.Replace((char)(-39), (char)(-71));
		}
		UGCUpdateHandle_t ugcupdateHandle_t = SteamUGC.StartItemUpdate(eg.ieg, a);
		if (ugcupdateHandle_t.m_UGCUpdateHandle == 18446744073709551615UL)
		{
			Debug.LogError(a.djb());
			this.cjp(a.djc(), EResult.k_EResultInvalidParam);
			return;
		}
		bool flag2 = true;
		flag2 &= eg.cjq(a.djd(), SteamUGC.SetItemTitle(ugcupdateHandle_t, c));
		flag2 &= eg.cjq(a.dje(), SteamUGC.SetItemDescription(ugcupdateHandle_t, d));
		flag2 &= eg.cjq(a.djf(), SteamUGC.SetItemContent(ugcupdateHandle_t, b));
		flag2 &= eg.cjq(a.djg(), SteamUGC.SetItemVisibility(ugcupdateHandle_t, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic));
		if (!string.IsNullOrEmpty(e))
		{
			flag2 &= eg.cjq(a.djh(), SteamUGC.SetItemPreview(ugcupdateHandle_t, e));
		}
		string text = a.dji();
		string text2 = Path.Combine(b, a.djj());
		if (File.Exists(text2))
		{
			try
			{
				CharacterPackageData characterPackageData = JsonUtility.FromJson<CharacterPackageData>(File.ReadAllText(text2));
				if (characterPackageData != null && !string.IsNullOrEmpty(characterPackageData.type))
				{
					text = ((characterPackageData.type == a.djk()) ? a.djm() : a.djl());
				}
			}
			catch (Exception ex)
			{
				Debug.LogWarning(a.djn() + ex.Message);
			}
		}
		flag2 &= eg.cjq(a.djo(), SteamUGC.SetItemTags(ugcupdateHandle_t, new List<string> { text }, false));
		if (!flag2)
		{
			Debug.LogWarning(a.djp());
		}
		SteamAPICall_t steamAPICall_t = SteamUGC.SubmitItemUpdate(ugcupdateHandle_t, f);
		this.iet.Set(steamAPICall_t, null);
	}

	// Token: 0x06000B0C RID: 2828 RVA: 0x00041CC0 File Offset: 0x0003FEC0
	private void dox(string a, EResult b)
	{
		this.ieo = false;
		this.iep = a.djq();
		this.ifb = null;
		Debug.LogError(string.Format(a.djr(), a, b));
		Action<string, EResult> action = this.iel;
		if (action == null)
		{
			return;
		}
		action(a, b);
	}

	// Token: 0x06000B0D RID: 2829 RVA: 0x00041D10 File Offset: 0x0003FF10
	private void bcs(PublishedFileId_t a, string b, string c, string d, string e, string f)
	{
		this.iep = a.djs();
		bool flag = true;
		if (string.IsNullOrEmpty(b) || !Directory.Exists(b))
		{
			Debug.LogError(string.Format(a.djt(), b, Directory.Exists(b ?? a.dju())));
			flag = false;
		}
		if (!string.IsNullOrEmpty(e) && !File.Exists(e))
		{
			Debug.LogError(string.Format(a.djv(), e, File.Exists(e)));
			flag = false;
		}
		if (string.IsNullOrEmpty(c))
		{
			Debug.LogError(a.djw());
			flag = false;
		}
		if (!flag)
		{
			this.cjp(a.djx(), EResult.k_EResultInvalidParam);
			return;
		}
		b = b.Replace((char)(-89), '\t');
		if (!string.IsNullOrEmpty(e))
		{
			e = e.Replace('\t', (char)(-36));
		}
		UGCUpdateHandle_t ugcupdateHandle_t = SteamUGC.StartItemUpdate(eg.ieg, a);
		if (ugcupdateHandle_t.m_UGCUpdateHandle == 18446744073709551615UL)
		{
			Debug.LogError(a.djy());
			this.cjp(a.djz(), EResult.k_EResultInvalidParam);
			return;
		}
		bool flag2 = true;
		flag2 &= eg.cjq(a.dka(), SteamUGC.SetItemTitle(ugcupdateHandle_t, c));
		flag2 &= eg.cjq(a.dkb(), SteamUGC.SetItemDescription(ugcupdateHandle_t, d));
		flag2 &= eg.cjq(a.dkc(), SteamUGC.SetItemContent(ugcupdateHandle_t, b));
		flag2 &= eg.cjq(a.dkd(), SteamUGC.SetItemVisibility(ugcupdateHandle_t, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic));
		if (!string.IsNullOrEmpty(e))
		{
			flag2 &= eg.cjq(a.dke(), SteamUGC.SetItemPreview(ugcupdateHandle_t, e));
		}
		string text = a.dkf();
		string text2 = Path.Combine(b, a.dkg());
		if (File.Exists(text2))
		{
			try
			{
				CharacterPackageData characterPackageData = JsonUtility.FromJson<CharacterPackageData>(File.ReadAllText(text2));
				if (characterPackageData != null && !string.IsNullOrEmpty(characterPackageData.type))
				{
					text = ((characterPackageData.type == a.dkh()) ? a.dkj() : a.dki());
				}
			}
			catch (Exception ex)
			{
				Debug.LogWarning(a.dkk() + ex.Message);
			}
		}
		flag2 &= eg.cjq(a.dkl(), SteamUGC.SetItemTags(ugcupdateHandle_t, new List<string> { text }, false));
		if (!flag2)
		{
			Debug.LogWarning(a.dkm());
		}
		SteamAPICall_t steamAPICall_t = SteamUGC.SubmitItemUpdate(ugcupdateHandle_t, f);
		this.iet.Set(steamAPICall_t, null);
	}

	// Token: 0x06000B0F RID: 2831 RVA: 0x00041F5C File Offset: 0x0004015C
	private void cjl(SteamUGCQueryCompleted_t a, bool b)
	{
		List<SteamUGCDetails_t> list = new List<SteamUGCDetails_t>();
		if (!b && a.m_eResult == EResult.k_EResultOK)
		{
			for (uint num = 0U; num < a.m_unNumResultsReturned; num += 1U)
			{
				SteamUGCDetails_t steamUGCDetails_t;
				if (SteamUGC.GetQueryUGCResult(a.m_handle, num, out steamUGCDetails_t))
				{
					list.Add(steamUGCDetails_t);
				}
			}
		}
		else
		{
			Debug.LogWarning(string.Format(a.dkn(), a.m_eResult));
		}
		SteamUGC.ReleaseQueryUGCRequest(a.m_handle);
		Action<List<SteamUGCDetails_t>> action = this.ifc;
		if (action == null)
		{
			return;
		}
		action(list);
	}

	// Token: 0x06000B12 RID: 2834 RVA: 0x0004204C File Offset: 0x0004024C
	private void ivd(SteamUGCQueryCompleted_t a, bool b)
	{
		List<SteamUGCDetails_t> list = new List<SteamUGCDetails_t>();
		if (!b && a.m_eResult == EResult.k_EResultOK)
		{
			for (uint num = 0U; num < a.m_unNumResultsReturned; num += 1U)
			{
				SteamUGCDetails_t steamUGCDetails_t;
				if (SteamUGC.GetQueryUGCResult(a.m_handle, num, out steamUGCDetails_t))
				{
					list.Add(steamUGCDetails_t);
				}
			}
		}
		else
		{
			Debug.LogWarning(string.Format(a.dko(), a.m_eResult));
		}
		SteamUGC.ReleaseQueryUGCRequest(a.m_handle);
		Action<List<SteamUGCDetails_t>> action = this.ifc;
		if (action == null)
		{
			return;
		}
		action(list);
	}

	// Token: 0x06000B13 RID: 2835 RVA: 0x000420CC File Offset: 0x000402CC
	private static bool eox(string a, bool b)
	{
		if (!b)
		{
			Debug.LogError(a.dkp() + a + a.dkq());
		}
		return b;
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x000420E8 File Offset: 0x000402E8
	public void hlh()
	{
		if (!this.cjr())
		{
			return;
		}
		UGCQueryHandle_t ugcqueryHandle_t = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Published, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, eg.ieg, eg.ieg, 1U);
		if (this.ieu == null)
		{
			this.ieu = CallResult<SteamUGCQueryCompleted_t>.Create(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(this.cjl));
		}
		SteamAPICall_t steamAPICall_t = SteamUGC.SendQueryUGCRequest(ugcqueryHandle_t);
		this.ieu.Set(steamAPICall_t, null);
	}

	// Token: 0x06000B15 RID: 2837 RVA: 0x00042150 File Offset: 0x00040350
	public float ciy()
	{
		if (!this.ieo)
		{
			return 0f;
		}
		return -1f;
	}

	// Token: 0x06000B17 RID: 2839 RVA: 0x000421A0 File Offset: 0x000403A0
	private void OnDisable()
	{
		CallResult<CreateItemResult_t> callResult = this.ies;
		if (callResult != null)
		{
			callResult.Dispose();
		}
		CallResult<SubmitItemUpdateResult_t> callResult2 = this.iet;
		if (callResult2 != null)
		{
			callResult2.Dispose();
		}
		this.ies = null;
		this.iet = null;
		CallResult<SteamUGCQueryCompleted_t> callResult3 = this.ieu;
		if (callResult3 != null)
		{
			callResult3.Dispose();
		}
		this.ieu = null;
		CallResult<DeleteItemResult_t> callResult4 = this.iev;
		if (callResult4 != null)
		{
			callResult4.Dispose();
		}
		this.iev = null;
		Callback<DownloadItemResult_t> callback = this.iex;
		if (callback != null)
		{
			callback.Unregister();
		}
		Callback<ItemInstalled_t> callback2 = this.iey;
		if (callback2 != null)
		{
			callback2.Unregister();
		}
		Callback<RemoteStoragePublishedFileSubscribed_t> callback3 = this.iez;
		if (callback3 != null)
		{
			callback3.Unregister();
		}
		Callback<RemoteStoragePublishedFileUnsubscribed_t> callback4 = this.ifa;
		if (callback4 != null)
		{
			callback4.Unregister();
		}
		this.iex = null;
		this.iey = null;
		this.iez = null;
		this.ifa = null;
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x00042270 File Offset: 0x00040470
	private void OnEnable()
	{
		if (!SteamManager.krd)
		{
			Debug.LogWarning(a.dgd());
			return;
		}
		this.ies = CallResult<CreateItemResult_t>.Create(new CallResult<CreateItemResult_t>.APIDispatchDelegate(this.cjb));
		this.iet = CallResult<SubmitItemUpdateResult_t>.Create(new CallResult<SubmitItemUpdateResult_t>.APIDispatchDelegate(this.cjd));
		this.iex = Callback<DownloadItemResult_t>.Create(new Callback<DownloadItemResult_t>.DispatchDelegate(this.cje));
		this.iey = Callback<ItemInstalled_t>.Create(new Callback<ItemInstalled_t>.DispatchDelegate(this.cjf));
		this.iez = Callback<RemoteStoragePublishedFileSubscribed_t>.Create(new Callback<RemoteStoragePublishedFileSubscribed_t>.DispatchDelegate(this.cjg));
		this.ifa = Callback<RemoteStoragePublishedFileUnsubscribed_t>.Create(new Callback<RemoteStoragePublishedFileUnsubscribed_t>.DispatchDelegate(this.cjh));
	}

	// Token: 0x04000867 RID: 2151
	private static readonly AppId_t ieg = new AppId_t(3861430U);

	// Token: 0x04000868 RID: 2152
	private const long ieh = 209715200L;

	// Token: 0x04000869 RID: 2153
	private static eg iei;

	// Token: 0x0400086F RID: 2159
	private bool ieo;

	// Token: 0x04000870 RID: 2160
	private string iep = a.tk();

	// Token: 0x04000871 RID: 2161
	private ulong ieq;

	// Token: 0x04000872 RID: 2162
	private int ier;

	// Token: 0x04000873 RID: 2163
	private CallResult<CreateItemResult_t> ies;

	// Token: 0x04000874 RID: 2164
	private CallResult<SubmitItemUpdateResult_t> iet;

	// Token: 0x04000875 RID: 2165
	private CallResult<SteamUGCQueryCompleted_t> ieu;

	// Token: 0x04000876 RID: 2166
	private CallResult<DeleteItemResult_t> iev;

	// Token: 0x04000877 RID: 2167
	private Action<bool> iew;

	// Token: 0x04000878 RID: 2168
	private Callback<DownloadItemResult_t> iex;

	// Token: 0x04000879 RID: 2169
	private Callback<ItemInstalled_t> iey;

	// Token: 0x0400087A RID: 2170
	private Callback<RemoteStoragePublishedFileSubscribed_t> iez;

	// Token: 0x0400087B RID: 2171
	private Callback<RemoteStoragePublishedFileUnsubscribed_t> ifa;

	// Token: 0x0400087C RID: 2172
	private eg.ee ifb;

	// Token: 0x020000D1 RID: 209
	private sealed class ee
	{
		// Token: 0x0400087E RID: 2174
		public string idw;

		// Token: 0x0400087F RID: 2175
		public string idy;

		// Token: 0x04000880 RID: 2176
		public string idz;

		// Token: 0x04000881 RID: 2177
		public string iea;

		// Token: 0x04000882 RID: 2178
		public string ieb;
	}
}
