using System;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x020000BE RID: 190
public sealed class ModalDialogManager : MonoBehaviour
{
	// Token: 0x170000BF RID: 191
	// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0003ACBD File Offset: 0x00038EBD
	// (set) Token: 0x060009F1 RID: 2545 RVA: 0x0003ACC4 File Offset: 0x00038EC4
	public static ModalDialogManager icb { get; private set; }

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0003ACCC File Offset: 0x00038ECC
	public bool krh
	{
		get
		{
			return this.ica != null && this.ica.gameObject.activeInHierarchy;
		}
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x0003ACF0 File Offset: 0x00038EF0
	private void Awake()
	{
		if (ModalDialogManager.icb != null && ModalDialogManager.icb != this)
		{
			Debug.LogWarning(a.csb());
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		ModalDialogManager.icb = this;
		if (this.dialogRoot == null)
		{
			this.dialogRoot = base.transform;
		}
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x0003AD4D File Offset: 0x00038F4D
	private void OnDestroy()
	{
		if (ModalDialogManager.icb == this)
		{
			ModalDialogManager.icb = null;
		}
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x0003AD64 File Offset: 0x00038F64
	public void ShowMessage(string title, string message, Action onOk = null)
	{
		if (!this.cgb(a.csc()))
		{
			return;
		}
		MessageDialog messageDialog = this.cgc<MessageDialog>(ref this.ibx, this.messagePrefab, a.csd());
		if (messageDialog == null)
		{
			return;
		}
		this.ica = messageDialog;
		messageDialog.cfs(title, message, this.cgd(onOk));
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x0003ADB8 File Offset: 0x00038FB8
	public void ShowConfirm(string title, string message, Action onConfirm, Action onCancel = null)
	{
		if (!this.cgb(a.cse()))
		{
			return;
		}
		ConfirmDialog confirmDialog = this.cgc<ConfirmDialog>(ref this.iby, this.confirmPrefab, a.csf());
		if (confirmDialog == null)
		{
			return;
		}
		this.ica = confirmDialog;
		confirmDialog.cfn(title, message, this.cgd(onConfirm), this.cgd(onCancel));
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x0003AE14 File Offset: 0x00039014
	public void ShowTypingConfirm(string title, string message, string requiredKeyword, string hint, Action onConfirm, Action onCancel = null)
	{
		if (!this.cgb(a.csg()))
		{
			return;
		}
		TypingConfirmDialog typingConfirmDialog = this.cgc<TypingConfirmDialog>(ref this.ibz, this.typingConfirmPrefab, a.csh());
		if (typingConfirmDialog == null)
		{
			return;
		}
		this.ica = typingConfirmDialog;
		typingConfirmDialog.cge(title, message, requiredKeyword, hint, this.cgd(onConfirm), this.cgd(onCancel));
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x0003AE73 File Offset: 0x00039073
	public void cfz()
	{
		if (this.ica != null)
		{
			this.ica.cfo();
			this.ica = null;
		}
	}

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x060009F9 RID: 2553 RVA: 0x0003AE95 File Offset: 0x00039095
	public static bool kri
	{
		get
		{
			if (ModalDialogManager.icb == null)
			{
				Debug.LogError(a.csi());
				return false;
			}
			return true;
		}
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x0003AEB1 File Offset: 0x000390B1
	private bool cgb(string a)
	{
		if (this.krh)
		{
			Debug.LogWarning(a.csj() + a + a.csk());
			return false;
		}
		this.ica = null;
		return true;
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x0003AEDC File Offset: 0x000390DC
	private a cgc<a>(ref a a, a b, string c) where a : ModalDialogBase
	{
		if (a != null)
		{
			return a;
		}
		if (b == null)
		{
			Debug.LogError(a.csj() + c + a.csl());
			return default(a);
		}
		a = global::UnityEngine.Object.Instantiate<a>(b, this.dialogRoot);
		a.name = c;
		return a;
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x0003AF55 File Offset: 0x00039155
	private Action cgd(Action a)
	{
		ModalDialogManager.dw dw = new ModalDialogManager.dw();
		dw.ibv = this;
		dw.ibw = a;
		return new Action(dw.cfv);
	}

	// Token: 0x04000810 RID: 2064
	[SerializeField]
	private MessageDialog messagePrefab;

	// Token: 0x04000811 RID: 2065
	[SerializeField]
	private ConfirmDialog confirmPrefab;

	// Token: 0x04000812 RID: 2066
	[SerializeField]
	private TypingConfirmDialog typingConfirmPrefab;

	// Token: 0x04000813 RID: 2067
	[SerializeField]
	private Transform dialogRoot;

	// Token: 0x04000814 RID: 2068
	private MessageDialog ibx;

	// Token: 0x04000815 RID: 2069
	private ConfirmDialog iby;

	// Token: 0x04000816 RID: 2070
	private TypingConfirmDialog ibz;

	// Token: 0x04000817 RID: 2071
	private ModalDialogBase ica;

	// Token: 0x020000BF RID: 191
	[CompilerGenerated]
	private sealed class dw
	{
		// Token: 0x060009FF RID: 2559 RVA: 0x0003AF75 File Offset: 0x00039175
		internal void obg()
		{
			this.ibv.ica = null;
			Action action = this.ibw;
			if (action == null)
			{
				return;
			}
			action();
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0003AF75 File Offset: 0x00039175
		internal void nhb()
		{
			this.ibv.ica = null;
			Action action = this.ibw;
			if (action == null)
			{
				return;
			}
			action();
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0003AF75 File Offset: 0x00039175
		internal void cfv()
		{
			this.ibv.ica = null;
			Action action = this.ibw;
			if (action == null)
			{
				return;
			}
			action();
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0003AF75 File Offset: 0x00039175
		internal void lrs()
		{
			this.ibv.ica = null;
			Action action = this.ibw;
			if (action == null)
			{
				return;
			}
			action();
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0003AF75 File Offset: 0x00039175
		internal void nrr()
		{
			this.ibv.ica = null;
			Action action = this.ibw;
			if (action == null)
			{
				return;
			}
			action();
		}

		// Token: 0x04000819 RID: 2073
		public ModalDialogManager ibv;

		// Token: 0x0400081A RID: 2074
		public Action ibw;
	}
}
