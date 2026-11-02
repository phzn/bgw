using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Token: 0x0200025C RID: 604
public class lg : MonoBehaviour
{
	// Token: 0x060025E3 RID: 9699 RVA: 0x0009DDC2 File Offset: 0x0009BFC2
	private void Start()
	{
		this.guj();
	}

	// Token: 0x060025E4 RID: 9700 RVA: 0x0009DDCA File Offset: 0x0009BFCA
	private void dzy()
	{
		this.OptionText.text = this.Options[this.khz];
	}

	// Token: 0x060025E5 RID: 9701 RVA: 0x0009DDE8 File Offset: 0x0009BFE8
	public void OnNextButtonClicked()
	{
		this.khz = (this.khz + 1) % this.Options.Count;
		this.guj();
	}

	// Token: 0x060025E7 RID: 9703 RVA: 0x0009DDE8 File Offset: 0x0009BFE8
	public void eiw()
	{
		this.khz = (this.khz + 1) % this.Options.Count;
		this.guj();
	}

	// Token: 0x060025E8 RID: 9704 RVA: 0x0009DE0A File Offset: 0x0009C00A
	public void OnPrevButtonClicked()
	{
		this.khz--;
		if (this.khz < 0)
		{
			this.khz = this.Options.Count - 1;
		}
		this.guj();
	}

	// Token: 0x060025E9 RID: 9705 RVA: 0x0009DDCA File Offset: 0x0009BFCA
	private void guj()
	{
		this.OptionText.text = this.Options[this.khz];
	}

	// Token: 0x060025EA RID: 9706 RVA: 0x0009DDCA File Offset: 0x0009BFCA
	private void kfu()
	{
		this.OptionText.text = this.Options[this.khz];
	}

	// Token: 0x060025EB RID: 9707 RVA: 0x0009DDE8 File Offset: 0x0009BFE8
	public void nxl()
	{
		this.khz = (this.khz + 1) % this.Options.Count;
		this.guj();
	}

	// Token: 0x060025EC RID: 9708 RVA: 0x0009DDCA File Offset: 0x0009BFCA
	private void jss()
	{
		this.OptionText.text = this.Options[this.khz];
	}

	// Token: 0x060025ED RID: 9709 RVA: 0x0009DDCA File Offset: 0x0009BFCA
	private void obk()
	{
		this.OptionText.text = this.Options[this.khz];
	}

	// Token: 0x04001267 RID: 4711
	public List<string> Options;

	// Token: 0x04001268 RID: 4712
	public TextMeshProUGUI OptionText;

	// Token: 0x04001269 RID: 4713
	private int khz;
}
