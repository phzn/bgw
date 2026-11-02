using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020000BB RID: 187
public sealed class ConfirmDialog : ModalDialogBase
{
	// Token: 0x170000BC RID: 188
	// (get) Token: 0x060009DA RID: 2522 RVA: 0x0003AA83 File Offset: 0x00038C83
	protected override bool krg
	{
		get
		{
			return true;
		}
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x0003AA88 File Offset: 0x00038C88
	protected override void Awake()
	{
		base.Awake();
		if (this.btnConfirm != null)
		{
			this.btnConfirm.onClick.AddListener(new UnityAction(this.cfq));
		}
		if (this.btnCancel != null)
		{
			this.btnCancel.onClick.AddListener(new UnityAction(this.cfr));
		}
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x0003AAEF File Offset: 0x00038CEF
	public void cfn(string a, string b, Action c, Action d = null)
	{
		base.cfu(a, b);
		this.ibs = c;
		this.ibt = d;
		base.gameObject.SetActive(true);
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x0003AB14 File Offset: 0x00038D14
	public override void cfo()
	{
		this.ibs = null;
		this.ibt = null;
		base.cfo();
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x0003AB2A File Offset: 0x00038D2A
	protected override void cfp()
	{
		this.cfr();
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x0003AB32 File Offset: 0x00038D32
	private void cfq()
	{
		Action action = this.ibs;
		this.ibs = null;
		this.ibt = null;
		this.cfo();
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x0003AB58 File Offset: 0x00038D58
	private void cfr()
	{
		Action action = this.ibt;
		this.ibs = null;
		this.ibt = null;
		this.cfo();
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x04000807 RID: 2055
	[SerializeField]
	private Button btnConfirm;

	// Token: 0x04000808 RID: 2056
	[SerializeField]
	private Button btnCancel;

	// Token: 0x04000809 RID: 2057
	private Action ibs;

	// Token: 0x0400080A RID: 2058
	private Action ibt;
}
