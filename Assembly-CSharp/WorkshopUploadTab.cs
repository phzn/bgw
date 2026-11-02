using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Kirurobo;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020000DF RID: 223
public sealed class WorkshopUploadTab : MonoBehaviour
{
	// Token: 0x06000B86 RID: 2950 RVA: 0x00043E8C File Offset: 0x0004208C
	private void Start()
	{
		this.inputTitle.characterLimit = 128;
		this.inputDescription.characterLimit = 8000;
		this.btnBrowsePreview.onClick.AddListener(new UnityAction(this.cmr));
		this.btnUpload.onClick.AddListener(new UnityAction(this.cmt));
		this.btnAcceptLegal.onClick.AddListener(new UnityAction(this.cmz));
		this.objSpinner.SetActive(false);
		if (this.objBtnTextUpload != null)
		{
			this.objBtnTextUpload.SetActive(true);
		}
		if (this.objBtnTextUpdate != null)
		{
			this.objBtnTextUpdate.SetActive(false);
		}
		if (this.objItemId != null)
		{
			this.objItemId.SetActive(false);
		}
		this.objLegalNotice.SetActive(false);
		this.cmm(false);
	}

	// Token: 0x06000B87 RID: 2951 RVA: 0x00043F7C File Offset: 0x0004217C
	private void OnEnable()
	{
		if (eg.krr != null)
		{
			eg.krr.iek += this.cmw;
			eg.krr.iel += this.cmx;
			eg.krr.ien += this.cmy;
		}
		this.cna();
	}

	// Token: 0x06000B88 RID: 2952 RVA: 0x00043FE0 File Offset: 0x000421E0
	private void OnDisable()
	{
		if (eg.krr != null)
		{
			eg.krr.iek -= this.cmw;
			eg.krr.iel -= this.cmx;
			eg.krr.ien -= this.cmy;
		}
	}

	// Token: 0x06000B89 RID: 2953 RVA: 0x0004403C File Offset: 0x0004223C
	public void cml(string a)
	{
		this.inputTitle.text = a ?? a.tk();
	}

	// Token: 0x06000B8A RID: 2954 RVA: 0x00044054 File Offset: 0x00042254
	public void cmm(bool a)
	{
		if (this.objPreview != null)
		{
			this.objPreview.SetActive(a);
		}
		if (this.objTitle != null)
		{
			this.objTitle.SetActive(a);
		}
		if (this.objDescription != null)
		{
			this.objDescription.SetActive(a);
		}
		if (this.objUploadBtn != null)
		{
			this.objUploadBtn.SetActive(a);
		}
		if (!a)
		{
			if (this.objItemId != null)
			{
				this.objItemId.SetActive(false);
			}
			if (this.objChangeNote != null)
			{
				this.objChangeNote.SetActive(false);
			}
			return;
		}
		this.cmn(a.dlv());
	}

	// Token: 0x06000B8B RID: 2955 RVA: 0x0004410C File Offset: 0x0004230C
	private void cmn(string a)
	{
		if (this.txtStatus == null)
		{
			return;
		}
		long num = eg.cij((this.createTab != null) ? this.createTab.kru : null);
		if (num < 0L)
		{
			return;
		}
		long num2 = eg.krq;
		double num3 = (double)num / 1048576.0;
		double num4 = (double)num2 / 1048576.0;
		double num5 = (double)num / (double)num2;
		int num6 = Mathf.Clamp((int)Math.Round(num5 * 100.0), 0, 999);
		int num7 = Mathf.Clamp((int)Math.Round(num5 * 14.0), 0, 14);
		string text = a.crz() + new string('=', num7) + new string('-', 14 - num7) + a.chz();
		this.txtStatus.text = string.Format(a.dlw(), new object[] { a, num3, num4, text, num6 });
		if (num5 > 1.0)
		{
			this.txtStatus.color = Color.red;
			return;
		}
		if (num5 > 0.8)
		{
			this.txtStatus.color = Color.yellow;
			return;
		}
		this.txtStatus.color = Color.white;
	}

	// Token: 0x06000B8C RID: 2956 RVA: 0x00044264 File Offset: 0x00042464
	public void cmo(string a)
	{
		if (string.IsNullOrEmpty(a))
		{
			return;
		}
		this.igk = a.Replace('\\', '/');
		this.cms(this.igk);
	}

	// Token: 0x06000B8D RID: 2957 RVA: 0x0004428C File Offset: 0x0004248C
	public void cmp(ulong a, string b = null, string c = null)
	{
		this.igl = true;
		this.igm = a;
		if (this.objItemId != null)
		{
			this.objItemId.SetActive(true);
		}
		if (this.txtItemId != null)
		{
			this.txtItemId.text = a.ToString();
		}
		if (this.objChangeNote != null)
		{
			this.objChangeNote.SetActive(true);
		}
		if (string.IsNullOrEmpty(this.inputChangeNote.text))
		{
			this.inputChangeNote.text = a.dlx();
		}
		if (this.objBtnTextUpload != null)
		{
			this.objBtnTextUpload.SetActive(false);
		}
		if (this.objBtnTextUpdate != null)
		{
			this.objBtnTextUpdate.SetActive(true);
		}
		if (b != null)
		{
			this.inputTitle.text = b;
		}
		if (c != null)
		{
			this.inputDescription.text = c;
		}
	}

	// Token: 0x06000B8E RID: 2958 RVA: 0x00044370 File Offset: 0x00042570
	public void cmq()
	{
		this.igl = false;
		this.igm = 0UL;
		if (this.objItemId != null)
		{
			this.objItemId.SetActive(false);
		}
		if (this.objChangeNote != null)
		{
			this.objChangeNote.SetActive(false);
		}
		this.inputChangeNote.text = a.tk();
		if (this.objBtnTextUpload != null)
		{
			this.objBtnTextUpload.SetActive(true);
		}
		if (this.objBtnTextUpdate != null)
		{
			this.objBtnTextUpdate.SetActive(false);
		}
	}

	// Token: 0x06000B8F RID: 2959 RVA: 0x00044404 File Offset: 0x00042604
	private void cmr()
	{
		FilePanel.OpenFilePanel(new FilePanel.Settings
		{
			title = a.dly(),
			filters = new FilePanel.Filter[]
			{
				new FilePanel.Filter(a.dlz(), new string[]
				{
					a.dma(),
					a.dmb()
				})
			}
		}, new Action<string[]>(this.cnb));
	}

	// Token: 0x06000B90 RID: 2960 RVA: 0x00044468 File Offset: 0x00042668
	private void cms(string a)
	{
		if (!File.Exists(a))
		{
			return;
		}
		try
		{
			if (this.imgPreview.texture != null)
			{
				global::UnityEngine.Object.Destroy(this.imgPreview.texture);
			}
			byte[] array = File.ReadAllBytes(a);
			Texture2D texture2D = new Texture2D(2, 2);
			texture2D.LoadImage(array);
			this.imgPreview.texture = texture2D;
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.dmc() + ex.Message);
		}
	}

	// Token: 0x06000B91 RID: 2961 RVA: 0x000444F0 File Offset: 0x000426F0
	private void cmt()
	{
		if (!SteamManager.krd)
		{
			this.txtStatus.text = a.dmd();
			this.txtStatus.color = Color.red;
			return;
		}
		if (this.createTab != null)
		{
			this.createTab.ckb();
		}
		WorkshopCreateTab workshopCreateTab = this.createTab;
		if (string.IsNullOrEmpty((workshopCreateTab != null) ? workshopCreateTab.kru : null))
		{
			this.txtStatus.text = a.dme();
			this.txtStatus.color = Color.yellow;
			return;
		}
		string text = this.inputTitle.text;
		string text2 = this.inputDescription.text;
		string text3 = this.createTab.kru;
		if (string.IsNullOrEmpty(text))
		{
			this.txtStatus.text = a.dmf();
			this.txtStatus.color = Color.yellow;
			return;
		}
		this.btnUpload.interactable = false;
		this.objSpinner.SetActive(true);
		this.cmn(a.dmg());
		if (this.txtStatus.text == a.tk() || this.txtStatus.text == null)
		{
			this.txtStatus.text = a.dmh();
			this.txtStatus.color = Color.white;
		}
		if (eg.krr == null)
		{
			this.txtStatus.text = a.dmi();
			this.txtStatus.color = Color.red;
			this.btnUpload.interactable = true;
			this.objSpinner.SetActive(false);
			return;
		}
		this.ign = base.StartCoroutine(this.cmu());
		if (this.igl && this.igm != 0UL)
		{
			eg.krr.cix(new PublishedFileId_t(this.igm), text3, text, text2, this.igk, this.inputChangeNote.text);
			return;
		}
		eg.krr.ciw(text3, text, text2, this.igk, a.dmj());
	}

	// Token: 0x06000B92 RID: 2962 RVA: 0x000446D7 File Offset: 0x000428D7
	private IEnumerator cmu()
	{
		yield return new WaitForSeconds(60f);
		this.ign = null;
		this.btnUpload.interactable = true;
		this.objSpinner.SetActive(false);
		this.txtStatus.text = a.dlu();
		this.txtStatus.color = Color.red;
		yield break;
	}

	// Token: 0x06000B93 RID: 2963 RVA: 0x000446E6 File Offset: 0x000428E6
	private void cmv()
	{
		if (this.ign != null)
		{
			base.StopCoroutine(this.ign);
			this.ign = null;
		}
	}

	// Token: 0x06000B94 RID: 2964 RVA: 0x00044704 File Offset: 0x00042904
	private void cmw(PublishedFileId_t a)
	{
		this.cmv();
		this.btnUpload.interactable = true;
		this.objSpinner.SetActive(false);
		this.txtStatus.text = string.Format(a.dmk(), a.m_PublishedFileId);
		this.txtStatus.color = Color.green;
		this.cmp(a.m_PublishedFileId, null, null);
	}

	// Token: 0x06000B95 RID: 2965 RVA: 0x00044770 File Offset: 0x00042970
	private void cmx(string a, EResult b)
	{
		this.cmv();
		this.btnUpload.interactable = true;
		this.objSpinner.SetActive(false);
		this.txtStatus.text = string.Format(a.dml(), a, b);
		this.txtStatus.color = Color.red;
	}

	// Token: 0x06000B96 RID: 2966 RVA: 0x000447C7 File Offset: 0x000429C7
	private void cmy()
	{
		this.objLegalNotice.SetActive(true);
	}

	// Token: 0x06000B97 RID: 2967 RVA: 0x000447D5 File Offset: 0x000429D5
	private void cmz()
	{
		SteamFriends.ActivateGameOverlayToWebPage(a.dmm(), EActivateGameOverlayToWebPageMode.k_EActivateGameOverlayToWebPageMode_Default);
	}

	// Token: 0x06000B98 RID: 2968 RVA: 0x000447E4 File Offset: 0x000429E4
	private void cna()
	{
		if (!SteamManager.krd)
		{
			this.txtStatus.text = a.dlh();
			this.txtStatus.color = Color.yellow;
			return;
		}
		this.txtStatus.text = a.dmn();
		this.txtStatus.color = Color.green;
	}

	// Token: 0x06000B9A RID: 2970 RVA: 0x00044839 File Offset: 0x00042A39
	[CompilerGenerated]
	private void cnb(string[] a)
	{
		if (a == null || a.Length == 0)
		{
			return;
		}
		this.igk = a[0].Replace('\\', '/');
		this.cms(this.igk);
	}

	// Token: 0x040008E0 RID: 2272
	[SerializeField]
	private RawImage imgPreview;

	// Token: 0x040008E1 RID: 2273
	[SerializeField]
	private Button btnBrowsePreview;

	// Token: 0x040008E2 RID: 2274
	[SerializeField]
	private TMP_InputField inputTitle;

	// Token: 0x040008E3 RID: 2275
	[SerializeField]
	private TMP_InputField inputDescription;

	// Token: 0x040008E4 RID: 2276
	[SerializeField]
	private TMP_InputField inputChangeNote;

	// Token: 0x040008E5 RID: 2277
	[SerializeField]
	private Button btnUpload;

	// Token: 0x040008E6 RID: 2278
	[SerializeField]
	private GameObject objBtnTextUpload;

	// Token: 0x040008E7 RID: 2279
	[SerializeField]
	private GameObject objBtnTextUpdate;

	// Token: 0x040008E8 RID: 2280
	[SerializeField]
	private TMP_Text txtStatus;

	// Token: 0x040008E9 RID: 2281
	[SerializeField]
	private GameObject objSpinner;

	// Token: 0x040008EA RID: 2282
	[SerializeField]
	private GameObject objPreview;

	// Token: 0x040008EB RID: 2283
	[SerializeField]
	private GameObject objTitle;

	// Token: 0x040008EC RID: 2284
	[SerializeField]
	private GameObject objDescription;

	// Token: 0x040008ED RID: 2285
	[SerializeField]
	private GameObject objChangeNote;

	// Token: 0x040008EE RID: 2286
	[SerializeField]
	private GameObject objUploadBtn;

	// Token: 0x040008EF RID: 2287
	[SerializeField]
	private GameObject objItemId;

	// Token: 0x040008F0 RID: 2288
	[SerializeField]
	private TMP_Text txtItemId;

	// Token: 0x040008F1 RID: 2289
	[SerializeField]
	private WorkshopCreateTab createTab;

	// Token: 0x040008F2 RID: 2290
	[SerializeField]
	private GameObject objLegalNotice;

	// Token: 0x040008F3 RID: 2291
	[SerializeField]
	private Button btnAcceptLegal;

	// Token: 0x040008F4 RID: 2292
	private string igk;

	// Token: 0x040008F5 RID: 2293
	private bool igl;

	// Token: 0x040008F6 RID: 2294
	private ulong igm;

	// Token: 0x040008F7 RID: 2295
	private Coroutine ign;
}
