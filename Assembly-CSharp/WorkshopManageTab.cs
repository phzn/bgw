using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020000D9 RID: 217
public sealed class WorkshopManageTab : MonoBehaviour
{
	// Token: 0x06000B52 RID: 2898 RVA: 0x0004340B File Offset: 0x0004160B
	private void Start()
	{
		this.btnRefresh.onClick.AddListener(new UnityAction(this.clk));
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x00043429 File Offset: 0x00041629
	private void OnEnable()
	{
		if (eg.krr != null)
		{
			eg.krr.ifc += this.cll;
		}
		this.clk();
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x00043454 File Offset: 0x00041654
	private void OnDisable()
	{
		if (eg.krr != null)
		{
			eg.krr.ifc -= this.cll;
		}
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x0004347C File Offset: 0x0004167C
	private void clk()
	{
		if (!SteamManager.krd)
		{
			this.txtStatus.text = a.dlh();
			return;
		}
		if (eg.krr == null)
		{
			return;
		}
		this.txtStatus.text = a.re();
		this.clq();
		eg.krr.cjk();
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x000434D0 File Offset: 0x000416D0
	private void cll(List<SteamUGCDetails_t> a)
	{
		this.clq();
		if (a.Count == 0)
		{
			this.txtStatus.text = a.dli();
			return;
		}
		this.txtStatus.text = string.Format(a.dlg(), a.Count);
		foreach (SteamUGCDetails_t steamUGCDetails_t in a)
		{
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.itemPrefab, this.itemListContainer);
			gameObject.SetActive(true);
			WorkshopManageItem component = gameObject.GetComponent<WorkshopManageItem>();
			if (component == null)
			{
				Debug.LogError(a.dlj());
				global::UnityEngine.Object.Destroy(gameObject);
			}
			else
			{
				component.clb(steamUGCDetails_t, this);
				this.ifz.Add(gameObject);
			}
		}
	}

	// Token: 0x06000B57 RID: 2903 RVA: 0x000435A8 File Offset: 0x000417A8
	public void clm(SteamUGCDetails_t a)
	{
		if (this.iga)
		{
			return;
		}
		this.iga = true;
		if ((SteamUGC.GetItemState(a.m_nPublishedFileId) & 4U) > 0U)
		{
			this.clo(a);
			return;
		}
		base.StartCoroutine(this.cln(a));
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x000435E2 File Offset: 0x000417E2
	private IEnumerator cln(SteamUGCDetails_t a)
	{
		ulong publishedFileId = a.m_nPublishedFileId.m_PublishedFileId;
		this.txtStatus.text = a.dld();
		SteamUGC.SubscribeItem(a.m_nPublishedFileId);
		SteamUGC.DownloadItem(a.m_nPublishedFileId, true);
		float num = 30f;
		float num2 = 0f;
		bool flag = false;
		while (num2 < num)
		{
			yield return new WaitForSeconds(0.5f);
			num2 += 0.5f;
			flag = (SteamUGC.GetItemState(a.m_nPublishedFileId) & 4U) > 0U;
			if (flag)
			{
				break;
			}
		}
		if (!flag)
		{
			this.iga = false;
			this.txtStatus.text = a.dle();
			Debug.LogWarning(string.Format(a.dlf(), publishedFileId));
			yield break;
		}
		this.txtStatus.text = string.Format(a.dlg(), this.ifz.Count);
		this.clo(a);
		yield break;
	}

	// Token: 0x06000B59 RID: 2905 RVA: 0x000435F8 File Offset: 0x000417F8
	private void clo(SteamUGCDetails_t a)
	{
		bool flag = false;
		string text = null;
		ulong num;
		uint num2;
		if (SteamUGC.GetItemInstallInfo(a.m_nPublishedFileId, out num, out text, 1024U, out num2) && !string.IsNullOrEmpty(text) && Directory.Exists(text) && this.createTab != null)
		{
			this.createTab.cjy(text);
			flag = true;
		}
		if (flag && this.uploadTab != null)
		{
			this.uploadTab.cmp(a.m_nPublishedFileId.m_PublishedFileId, a.m_rgchTitle, a.m_rgchDescription);
			string text2 = Path.Combine(text, a.cxn());
			if (File.Exists(text2))
			{
				this.uploadTab.cmo(text2);
			}
		}
		if (!flag)
		{
			this.txtStatus.text = a.dlk();
		}
		this.iga = false;
		if (WorkshopEditorManager.krw != null)
		{
			WorkshopEditorManager.krw.ckw();
		}
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x000436D8 File Offset: 0x000418D8
	public void clp(SteamUGCDetails_t a)
	{
		WorkshopManageTab.eh eh = new WorkshopManageTab.eh();
		eh.ifp = a;
		eh.ifq = this;
		this.confirmDialog.cjt(a.dll(), a.dlm() + eh.ifp.m_rgchTitle + a.dln(), new Action(eh.cle));
	}

	// Token: 0x06000B5B RID: 2907 RVA: 0x00043730 File Offset: 0x00041930
	private void clq()
	{
		foreach (GameObject gameObject in this.ifz)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.ifz.Clear();
	}

	// Token: 0x040008BF RID: 2239
	[SerializeField]
	private Transform itemListContainer;

	// Token: 0x040008C0 RID: 2240
	[SerializeField]
	private GameObject itemPrefab;

	// Token: 0x040008C1 RID: 2241
	[SerializeField]
	private TMP_Text txtStatus;

	// Token: 0x040008C2 RID: 2242
	[SerializeField]
	private Button btnRefresh;

	// Token: 0x040008C3 RID: 2243
	[SerializeField]
	private WorkshopConfirmDialog confirmDialog;

	// Token: 0x040008C4 RID: 2244
	[SerializeField]
	private WorkshopCreateTab createTab;

	// Token: 0x040008C5 RID: 2245
	[SerializeField]
	private WorkshopUploadTab uploadTab;

	// Token: 0x040008C6 RID: 2246
	private readonly List<GameObject> ifz = new List<GameObject>();

	// Token: 0x040008C7 RID: 2247
	private bool iga;

	// Token: 0x020000DA RID: 218
	[CompilerGenerated]
	private sealed class eh
	{
		// Token: 0x06000B5D RID: 2909 RVA: 0x0004379F File Offset: 0x0004199F
		internal void oae(bool a)
		{
			if (a)
			{
				this.ifq.clk();
			}
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x000437B0 File Offset: 0x000419B0
		internal void cle()
		{
			eg eg = eg.krr;
			PublishedFileId_t nPublishedFileId = this.ifp.m_nPublishedFileId;
			Action<bool> action;
			if ((action = this.ifr) == null)
			{
				action = (this.ifr = new Action<bool>(this.clf));
			}
			eg.cjm(nPublishedFileId, action);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0004379F File Offset: 0x0004199F
		internal void clf(bool a)
		{
			if (a)
			{
				this.ifq.clk();
			}
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0004379F File Offset: 0x0004199F
		internal void lik(bool a)
		{
			if (a)
			{
				this.ifq.clk();
			}
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0004379F File Offset: 0x0004199F
		internal void bdj(bool a)
		{
			if (a)
			{
				this.ifq.clk();
			}
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0004379F File Offset: 0x0004199F
		internal void drv(bool a)
		{
			if (a)
			{
				this.ifq.clk();
			}
		}

		// Token: 0x040008C8 RID: 2248
		public SteamUGCDetails_t ifp;

		// Token: 0x040008C9 RID: 2249
		public WorkshopManageTab ifq;

		// Token: 0x040008CA RID: 2250
		public Action<bool> ifr;
	}
}
