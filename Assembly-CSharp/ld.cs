using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000259 RID: 601
[ExecuteInEditMode]
public class ld : MonoBehaviour
{
	// Token: 0x060025C4 RID: 9668 RVA: 0x0009DB07 File Offset: 0x0009BD07
	public void guf(float a)
	{
		this.Handle.color = ((a == 0f) ? this.DisabledColor : this.EnabledColor);
	}

	// Token: 0x060025C5 RID: 9669 RVA: 0x0009DB2A File Offset: 0x0009BD2A
	private void OnDestroy()
	{
		this.khw.onValueChanged.RemoveListener(new UnityAction<float>(this.guf));
	}

	// Token: 0x060025C6 RID: 9670 RVA: 0x0009DB48 File Offset: 0x0009BD48
	private void hcz()
	{
		this.khw = base.GetComponent<Slider>();
	}

	// Token: 0x060025C7 RID: 9671 RVA: 0x0009DB48 File Offset: 0x0009BD48
	private void ojd()
	{
		this.khw = base.GetComponent<Slider>();
	}

	// Token: 0x060025C8 RID: 9672 RVA: 0x0009DB48 File Offset: 0x0009BD48
	private void Awake()
	{
		this.khw = base.GetComponent<Slider>();
	}

	// Token: 0x060025C9 RID: 9673 RVA: 0x0009DB2A File Offset: 0x0009BD2A
	private void kql()
	{
		this.khw.onValueChanged.RemoveListener(new UnityAction<float>(this.guf));
	}

	// Token: 0x060025CA RID: 9674 RVA: 0x0009DB56 File Offset: 0x0009BD56
	private void evl()
	{
		this.guf(this.khw.value);
		this.khw.onValueChanged.AddListener(new UnityAction<float>(this.guf));
	}

	// Token: 0x060025CB RID: 9675 RVA: 0x0009DB56 File Offset: 0x0009BD56
	private void dil()
	{
		this.guf(this.khw.value);
		this.khw.onValueChanged.AddListener(new UnityAction<float>(this.guf));
	}

	// Token: 0x060025CC RID: 9676 RVA: 0x0009DB56 File Offset: 0x0009BD56
	private void lji()
	{
		this.guf(this.khw.value);
		this.khw.onValueChanged.AddListener(new UnityAction<float>(this.guf));
	}

	// Token: 0x060025CD RID: 9677 RVA: 0x0009DB56 File Offset: 0x0009BD56
	private void Start()
	{
		this.guf(this.khw.value);
		this.khw.onValueChanged.AddListener(new UnityAction<float>(this.guf));
	}

	// Token: 0x060025CF RID: 9679 RVA: 0x0009DB56 File Offset: 0x0009BD56
	private void hvg()
	{
		this.guf(this.khw.value);
		this.khw.onValueChanged.AddListener(new UnityAction<float>(this.guf));
	}

	// Token: 0x060025D0 RID: 9680 RVA: 0x0009DB2A File Offset: 0x0009BD2A
	private void kra()
	{
		this.khw.onValueChanged.RemoveListener(new UnityAction<float>(this.guf));
	}

	// Token: 0x060025D1 RID: 9681 RVA: 0x0009DB2A File Offset: 0x0009BD2A
	private void otz()
	{
		this.khw.onValueChanged.RemoveListener(new UnityAction<float>(this.guf));
	}

	// Token: 0x060025D2 RID: 9682 RVA: 0x0009DB2A File Offset: 0x0009BD2A
	private void fjd()
	{
		this.khw.onValueChanged.RemoveListener(new UnityAction<float>(this.guf));
	}

	// Token: 0x0400125E RID: 4702
	public Color EnabledColor;

	// Token: 0x0400125F RID: 4703
	public Color DisabledColor;

	// Token: 0x04001260 RID: 4704
	public Image Handle;

	// Token: 0x04001261 RID: 4705
	private Slider khw;
}
