using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020000BC RID: 188
public sealed class MessageDialog : ModalDialogBase
{
	// Token: 0x170000BD RID: 189
	// (get) Token: 0x060009E2 RID: 2530 RVA: 0x0003AA83 File Offset: 0x00038C83
	protected override bool krg
	{
		get
		{
			return true;
		}
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x0003AB86 File Offset: 0x00038D86
	protected override void Awake()
	{
		base.Awake();
		if (this.btnOk != null)
		{
			this.btnOk.onClick.AddListener(new UnityAction(this.cft));
		}
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x0003ABB8 File Offset: 0x00038DB8
	public void cfs(string a, string b, Action c = null)
	{
		base.cfu(a, b);
		this.ibu = c;
		base.gameObject.SetActive(true);
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x0003ABD5 File Offset: 0x00038DD5
	public override void cfo()
	{
		this.ibu = null;
		base.cfo();
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x0003ABE4 File Offset: 0x00038DE4
	protected override void cfp()
	{
		this.cft();
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x0003ABEC File Offset: 0x00038DEC
	private void cft()
	{
		Action action = this.ibu;
		this.ibu = null;
		this.cfo();
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x0400080B RID: 2059
	[SerializeField]
	private Button btnOk;

	// Token: 0x0400080C RID: 2060
	private Action ibu;
}
