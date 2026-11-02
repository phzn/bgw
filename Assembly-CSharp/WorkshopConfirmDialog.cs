using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020000D4 RID: 212
public sealed class WorkshopConfirmDialog : MonoBehaviour
{
	// Token: 0x06000B23 RID: 2851 RVA: 0x00042438 File Offset: 0x00040638
	private void Awake()
	{
		this.btnConfirm.onClick.AddListener(new UnityAction(this.cju));
		this.btnCancel.onClick.AddListener(new UnityAction(this.cjv));
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B24 RID: 2852 RVA: 0x00042489 File Offset: 0x00040689
	public void cjt(string a, string b, Action c)
	{
		this.txtTitle.text = a;
		this.txtMessage.text = b;
		this.ifd = c;
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x000424B6 File Offset: 0x000406B6
	[CompilerGenerated]
	private void cju()
	{
		Action action = this.ifd;
		if (action != null)
		{
			action();
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x0001F517 File Offset: 0x0001D717
	[CompilerGenerated]
	private void cjv()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x04000888 RID: 2184
	[SerializeField]
	private TMP_Text txtTitle;

	// Token: 0x04000889 RID: 2185
	[SerializeField]
	private TMP_Text txtMessage;

	// Token: 0x0400088A RID: 2186
	[SerializeField]
	private Button btnConfirm;

	// Token: 0x0400088B RID: 2187
	[SerializeField]
	private Button btnCancel;

	// Token: 0x0400088C RID: 2188
	private Action ifd;
}
