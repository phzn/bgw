using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using TMPro;
using UnityEngine;

// Token: 0x02000257 RID: 599
public class lc : MonoBehaviour
{
	// Token: 0x060025B1 RID: 9649 RVA: 0x0009D950 File Offset: 0x0009BB50
	private void Awake()
	{
		this.khu = base.GetComponent<TextMeshProUGUI>();
	}

	// Token: 0x060025B2 RID: 9650 RVA: 0x0009D95E File Offset: 0x0009BB5E
	private void OnEnable()
	{
		lb slider = this.Slider;
		slider.OnOptionSelected = (Action<int, int>)Delegate.Combine(slider.OnOptionSelected, new Action<int, int>(this.guc));
	}

	// Token: 0x060025B3 RID: 9651 RVA: 0x0009D950 File Offset: 0x0009BB50
	private void bfn()
	{
		this.khu = base.GetComponent<TextMeshProUGUI>();
	}

	// Token: 0x060025B5 RID: 9653 RVA: 0x0009D950 File Offset: 0x0009BB50
	private void nbr()
	{
		this.khu = base.GetComponent<TextMeshProUGUI>();
	}

	// Token: 0x060025B6 RID: 9654 RVA: 0x0009D95E File Offset: 0x0009BB5E
	private void ffn()
	{
		lb slider = this.Slider;
		slider.OnOptionSelected = (Action<int, int>)Delegate.Combine(slider.OnOptionSelected, new Action<int, int>(this.guc));
	}

	// Token: 0x060025B7 RID: 9655 RVA: 0x0009D987 File Offset: 0x0009BB87
	private void dyi()
	{
		lb slider = this.Slider;
		slider.OnOptionSelected = (Action<int, int>)Delegate.Remove(slider.OnOptionSelected, new Action<int, int>(this.guc));
	}

	// Token: 0x060025B8 RID: 9656 RVA: 0x0009D950 File Offset: 0x0009BB50
	private void gld()
	{
		this.khu = base.GetComponent<TextMeshProUGUI>();
	}

	// Token: 0x060025B9 RID: 9657 RVA: 0x0009D9B0 File Offset: 0x0009BBB0
	private void guc(int a, int b)
	{
		this.khu.text = string.Format(a.ezo(), this.TitleText, a + 1, b);
	}

	// Token: 0x060025BA RID: 9658 RVA: 0x0009D9DB File Offset: 0x0009BBDB
	private void nyd(int a, int b)
	{
		this.khu.text = string.Format(a.ezp(), this.TitleText, a + 1, b);
	}

	// Token: 0x060025BB RID: 9659 RVA: 0x0009DA06 File Offset: 0x0009BC06
	private void bdk(int a, int b)
	{
		this.khu.text = string.Format(a.ezq(), this.TitleText, a + 1, b);
	}

	// Token: 0x060025BC RID: 9660 RVA: 0x0009D950 File Offset: 0x0009BB50
	private void ea()
	{
		this.khu = base.GetComponent<TextMeshProUGUI>();
	}

	// Token: 0x060025BD RID: 9661 RVA: 0x0009D987 File Offset: 0x0009BB87
	private void OnDisable()
	{
		lb slider = this.Slider;
		slider.OnOptionSelected = (Action<int, int>)Delegate.Remove(slider.OnOptionSelected, new Action<int, int>(this.guc));
	}

	// Token: 0x04001257 RID: 4695
	public lb Slider;

	// Token: 0x04001258 RID: 4696
	public string TitleText;

	// Token: 0x04001259 RID: 4697
	private TextMeshProUGUI khu;
}
