using System;
using Rewired.UI.ControlMapper;
using TMPro;
using UnityEngine;

// Token: 0x02000227 RID: 551
public class kg : MonoBehaviour
{
	// Token: 0x060023DD RID: 9181 RVA: 0x0009982F File Offset: 0x00097A2F
	public void jyh(int a, string b, Action<int, ButtonInfo> c)
	{
		this.kgb = a;
		this.label.text = b;
		this.kgc = c;
		this.kga = base.transform.GetComponentsInChildren<ButtonInfo>(true);
	}

	// Token: 0x060023DE RID: 9182 RVA: 0x0009985D File Offset: 0x00097A5D
	public void krh(ButtonInfo buttonInfo)
	{
		if (this.kgc == null)
		{
			return;
		}
		this.kgc(this.kgb, buttonInfo);
	}

	// Token: 0x060023DF RID: 9183 RVA: 0x0009982F File Offset: 0x00097A2F
	public void gkh(int a, string b, Action<int, ButtonInfo> c)
	{
		this.kgb = a;
		this.label.text = b;
		this.kgc = c;
		this.kga = base.transform.GetComponentsInChildren<ButtonInfo>(true);
	}

	// Token: 0x17000567 RID: 1383
	// (get) Token: 0x060023E1 RID: 9185 RVA: 0x00099883 File Offset: 0x00097A83
	// (set) Token: 0x060023E0 RID: 9184 RVA: 0x0009987A File Offset: 0x00097A7A
	public ButtonInfo[] kga { get; private set; }

	// Token: 0x060023E2 RID: 9186 RVA: 0x0009982F File Offset: 0x00097A2F
	public void eyy(int a, string b, Action<int, ButtonInfo> c)
	{
		this.kgb = a;
		this.label.text = b;
		this.kgc = c;
		this.kga = base.transform.GetComponentsInChildren<ButtonInfo>(true);
	}

	// Token: 0x060023E4 RID: 9188 RVA: 0x0009985D File Offset: 0x00097A5D
	public void OnButtonActivated(ButtonInfo buttonInfo)
	{
		if (this.kgc == null)
		{
			return;
		}
		this.kgc(this.kgb, buttonInfo);
	}

	// Token: 0x060023E5 RID: 9189 RVA: 0x0009985D File Offset: 0x00097A5D
	public void lny(ButtonInfo buttonInfo)
	{
		if (this.kgc == null)
		{
			return;
		}
		this.kgc(this.kgb, buttonInfo);
	}

	// Token: 0x0400115E RID: 4446
	public TMP_Text label;

	// Token: 0x04001160 RID: 4448
	private int kgb;

	// Token: 0x04001161 RID: 4449
	private Action<int, ButtonInfo> kgc;
}
