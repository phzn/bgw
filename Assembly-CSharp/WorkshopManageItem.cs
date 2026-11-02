using System;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020000D8 RID: 216
public sealed class WorkshopManageItem : MonoBehaviour
{
	// Token: 0x06000B4E RID: 2894 RVA: 0x00043380 File Offset: 0x00041580
	public void clb(SteamUGCDetails_t a, WorkshopManageTab b)
	{
		this.ifn = a;
		this.ifo = b;
		this.txtTitle.text = a.m_rgchTitle;
		this.btnLoad.onClick.AddListener(new UnityAction(this.clc));
		this.btnDelete.onClick.AddListener(new UnityAction(this.cld));
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x000433E5 File Offset: 0x000415E5
	private void clc()
	{
		this.ifo.clm(this.ifn);
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x000433F8 File Offset: 0x000415F8
	private void cld()
	{
		this.ifo.clp(this.ifn);
	}

	// Token: 0x040008BA RID: 2234
	[SerializeField]
	private TMP_Text txtTitle;

	// Token: 0x040008BB RID: 2235
	[SerializeField]
	private Button btnLoad;

	// Token: 0x040008BC RID: 2236
	[SerializeField]
	private Button btnDelete;

	// Token: 0x040008BD RID: 2237
	private SteamUGCDetails_t ifn;

	// Token: 0x040008BE RID: 2238
	private WorkshopManageTab ifo;
}
