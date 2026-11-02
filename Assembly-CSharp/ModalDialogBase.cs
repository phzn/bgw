using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000BD RID: 189
public abstract class ModalDialogBase : MonoBehaviour
{
	// Token: 0x170000BE RID: 190
	// (get) Token: 0x060009E9 RID: 2537 RVA: 0x0000FC31 File Offset: 0x0000DE31
	protected virtual bool krg
	{
		get
		{
			return false;
		}
	}

	// Token: 0x060009EA RID: 2538 RVA: 0x0003AC0C File Offset: 0x00038E0C
	protected virtual void Awake()
	{
		base.gameObject.SetActive(false);
		if (this.modalBlocker != null && !this.modalBlocker.raycastTarget)
		{
			Debug.LogWarning(a.crz() + base.GetType().Name + a.csa());
		}
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x0003AC5F File Offset: 0x00038E5F
	protected virtual void Update()
	{
		if (!this.krg)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			return;
		}
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			this.cfp();
		}
	}

	// Token: 0x060009EC RID: 2540 RVA: 0x00005090 File Offset: 0x00003290
	protected virtual void cfp()
	{
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x0001F517 File Offset: 0x0001D717
	public virtual void cfo()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x0003AC87 File Offset: 0x00038E87
	protected void cfu(string a, string b)
	{
		if (this.txtTitle != null)
		{
			this.txtTitle.text = a;
		}
		if (this.txtMessage != null)
		{
			this.txtMessage.text = b;
		}
	}

	// Token: 0x0400080D RID: 2061
	[SerializeField]
	protected TMP_Text txtTitle;

	// Token: 0x0400080E RID: 2062
	[SerializeField]
	protected TMP_Text txtMessage;

	// Token: 0x0400080F RID: 2063
	[SerializeField]
	protected Image modalBlocker;
}
