using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020000C0 RID: 192
public sealed class TypingConfirmDialog : ModalDialogBase
{
	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0000FC31 File Offset: 0x0000DE31
	protected override bool krg
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x0003AF94 File Offset: 0x00039194
	protected override void Awake()
	{
		base.Awake();
		if (this.btnConfirm != null)
		{
			this.btnConfirm.onClick.AddListener(new UnityAction(this.cgg));
		}
		if (this.btnCancel != null)
		{
			this.btnCancel.onClick.AddListener(new UnityAction(this.cgh));
		}
		if (this.inputConfirm != null)
		{
			this.inputConfirm.onValueChanged.AddListener(new UnityAction<string>(this.cgf));
		}
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x0003B028 File Offset: 0x00039228
	public void cge(string a, string b, string c, string d, Action e, Action f = null)
	{
		base.cfu(a, b);
		this.ice = c ?? string.Empty;
		this.icc = e;
		this.icd = f;
		if (this.txtHint != null)
		{
			this.txtHint.text = d;
		}
		if (this.inputConfirm != null)
		{
			this.inputConfirm.text = string.Empty;
		}
		if (this.btnConfirm != null)
		{
			this.btnConfirm.interactable = false;
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x0003B0BC File Offset: 0x000392BC
	public override void cfo()
	{
		this.icc = null;
		this.icd = null;
		this.ice = null;
		base.cfo();
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x0003B0DC File Offset: 0x000392DC
	private void cgf(string a)
	{
		if (this.btnConfirm == null)
		{
			return;
		}
		bool flag = !string.IsNullOrEmpty(a) && a.Trim().Equals(this.ice, StringComparison.OrdinalIgnoreCase);
		this.btnConfirm.interactable = flag;
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x0003B122 File Offset: 0x00039322
	private void cgg()
	{
		Action action = this.icc;
		this.icc = null;
		this.icd = null;
		this.cfo();
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x0003B148 File Offset: 0x00039348
	private void cgh()
	{
		Action action = this.icd;
		this.icc = null;
		this.icd = null;
		this.cfo();
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x0400081B RID: 2075
	[SerializeField]
	private TMP_Text txtHint;

	// Token: 0x0400081C RID: 2076
	[SerializeField]
	private TMP_InputField inputConfirm;

	// Token: 0x0400081D RID: 2077
	[SerializeField]
	private Button btnConfirm;

	// Token: 0x0400081E RID: 2078
	[SerializeField]
	private Button btnCancel;

	// Token: 0x0400081F RID: 2079
	private Action icc;

	// Token: 0x04000820 RID: 2080
	private Action icd;

	// Token: 0x04000821 RID: 2081
	private string ice;
}
