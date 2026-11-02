using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020000D6 RID: 214
public sealed class WorkshopEditorManager : MonoBehaviour
{
	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x06000B42 RID: 2882 RVA: 0x0004320E File Offset: 0x0004140E
	public static WorkshopEditorManager krw
	{
		get
		{
			return WorkshopEditorManager.ifm;
		}
	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x00043215 File Offset: 0x00041415
	private void Awake()
	{
		WorkshopEditorManager.ifm = this;
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x00043220 File Offset: 0x00041420
	private void Start()
	{
		this.toggleCreate.onValueChanged.AddListener(new UnityAction<bool>(this.cky));
		this.toggleUpload.onValueChanged.AddListener(new UnityAction<bool>(this.ckz));
		this.toggleManage.onValueChanged.AddListener(new UnityAction<bool>(this.cla));
		this.toggleCreate.isOn = true;
		this.toggleUpload.isOn = false;
		this.toggleManage.isOn = false;
		this.contentCreate.SetActive(true);
		this.contentUpload.SetActive(false);
		this.contentManage.SetActive(false);
		this.btnExit.onClick.AddListener(new UnityAction(WorkshopEditorManager.<>c.<>9.cku));
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x000432F8 File Offset: 0x000414F8
	public void ckw()
	{
		this.toggleCreate.isOn = true;
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x00043308 File Offset: 0x00041508
	public void ckx(ulong a = 0UL)
	{
		this.toggleUpload.isOn = true;
		if (a != 0UL)
		{
			WorkshopUploadTab component = this.contentUpload.GetComponent<WorkshopUploadTab>();
			if (component != null)
			{
				component.cmp(a, null, null);
			}
		}
	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x00043342 File Offset: 0x00041542
	[CompilerGenerated]
	private void cky(bool a)
	{
		this.contentCreate.SetActive(a);
	}

	// Token: 0x06000B49 RID: 2889 RVA: 0x00043350 File Offset: 0x00041550
	[CompilerGenerated]
	private void ckz(bool a)
	{
		this.contentUpload.SetActive(a);
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x0004335E File Offset: 0x0004155E
	[CompilerGenerated]
	private void cla(bool a)
	{
		this.contentManage.SetActive(a);
	}

	// Token: 0x040008B0 RID: 2224
	private static WorkshopEditorManager ifm;

	// Token: 0x040008B1 RID: 2225
	[SerializeField]
	private Toggle toggleCreate;

	// Token: 0x040008B2 RID: 2226
	[SerializeField]
	private Toggle toggleUpload;

	// Token: 0x040008B3 RID: 2227
	[SerializeField]
	private Toggle toggleManage;

	// Token: 0x040008B4 RID: 2228
	[SerializeField]
	private GameObject contentCreate;

	// Token: 0x040008B5 RID: 2229
	[SerializeField]
	private GameObject contentUpload;

	// Token: 0x040008B6 RID: 2230
	[SerializeField]
	private GameObject contentManage;

	// Token: 0x040008B7 RID: 2231
	[SerializeField]
	private Button btnExit;
}
