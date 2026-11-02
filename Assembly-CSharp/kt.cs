using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200024D RID: 589
public class kt : MonoBehaviour
{
	// Token: 0x06002560 RID: 9568 RVA: 0x0009C656 File Offset: 0x0009A856
	public void jdo()
	{
		if (this.khj)
		{
			this.khj = false;
			this.khk.color = this.disabledColor;
			return;
		}
		this.khj = true;
		this.khk.color = this.enabledColor;
	}

	// Token: 0x06002561 RID: 9569 RVA: 0x0009C656 File Offset: 0x0009A856
	public void SwapColor()
	{
		if (this.khj)
		{
			this.khj = false;
			this.khk.color = this.disabledColor;
			return;
		}
		this.khj = true;
		this.khk.color = this.enabledColor;
	}

	// Token: 0x06002563 RID: 9571 RVA: 0x0009C6A0 File Offset: 0x0009A8A0
	private void Awake()
	{
		this.khk = base.GetComponent<Image>();
	}

	// Token: 0x06002564 RID: 9572 RVA: 0x0009C656 File Offset: 0x0009A856
	public void iaa()
	{
		if (this.khj)
		{
			this.khj = false;
			this.khk.color = this.disabledColor;
			return;
		}
		this.khj = true;
		this.khk.color = this.enabledColor;
	}

	// Token: 0x06002565 RID: 9573 RVA: 0x0009C656 File Offset: 0x0009A856
	public void hyt()
	{
		if (this.khj)
		{
			this.khj = false;
			this.khk.color = this.disabledColor;
			return;
		}
		this.khj = true;
		this.khk.color = this.enabledColor;
	}

	// Token: 0x06002566 RID: 9574 RVA: 0x0009C656 File Offset: 0x0009A856
	public void oca()
	{
		if (this.khj)
		{
			this.khj = false;
			this.khk.color = this.disabledColor;
			return;
		}
		this.khj = true;
		this.khk.color = this.enabledColor;
	}

	// Token: 0x06002567 RID: 9575 RVA: 0x0009C6A0 File Offset: 0x0009A8A0
	private void kao()
	{
		this.khk = base.GetComponent<Image>();
	}

	// Token: 0x06002568 RID: 9576 RVA: 0x0009C6A0 File Offset: 0x0009A8A0
	private void edg()
	{
		this.khk = base.GetComponent<Image>();
	}

	// Token: 0x0400122A RID: 4650
	public Color enabledColor;

	// Token: 0x0400122B RID: 4651
	public Color disabledColor;

	// Token: 0x0400122C RID: 4652
	private bool khj = true;

	// Token: 0x0400122D RID: 4653
	private Image khk;
}
