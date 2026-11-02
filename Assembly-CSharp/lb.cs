using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000256 RID: 598
public class lb : MonoBehaviour
{
	// Token: 0x060025A2 RID: 9634 RVA: 0x0009D75A File Offset: 0x0009B95A
	private void Start()
	{
		this.gub();
	}

	// Token: 0x060025A3 RID: 9635 RVA: 0x0009D762 File Offset: 0x0009B962
	public void oma()
	{
		this.khr = this.khs;
		this.khs--;
		if (this.khs < 0)
		{
			this.khs = this.Options.Count - 1;
		}
		this.gub();
	}

	// Token: 0x060025A4 RID: 9636 RVA: 0x0009D7A0 File Offset: 0x0009B9A0
	private void lpz()
	{
		if (this.kht != null)
		{
			global::UnityEngine.Object.Destroy(this.kht);
		}
		this.kht = global::UnityEngine.Object.Instantiate<GameObject>(this.Options[this.khs], (this.Root != null) ? this.Root : base.transform, false);
		Action<int, int> onOptionSelected = this.OnOptionSelected;
		if (onOptionSelected == null)
		{
			return;
		}
		onOptionSelected(this.khs, this.Options.Count);
	}

	// Token: 0x060025A5 RID: 9637 RVA: 0x0009D75A File Offset: 0x0009B95A
	private void jcz()
	{
		this.gub();
	}

	// Token: 0x060025A6 RID: 9638 RVA: 0x0009D820 File Offset: 0x0009BA20
	public void OnNextButtonClicked()
	{
		this.khr = this.khs;
		this.khs = (this.khs + 1) % this.Options.Count;
		this.gub();
	}

	// Token: 0x060025A7 RID: 9639 RVA: 0x0009D820 File Offset: 0x0009BA20
	public void oq()
	{
		this.khr = this.khs;
		this.khs = (this.khs + 1) % this.Options.Count;
		this.gub();
	}

	// Token: 0x060025A8 RID: 9640 RVA: 0x0009D75A File Offset: 0x0009B95A
	private void mlq()
	{
		this.gub();
	}

	// Token: 0x060025A9 RID: 9641 RVA: 0x0009D762 File Offset: 0x0009B962
	public void OnPrevButtonClicked()
	{
		this.khr = this.khs;
		this.khs--;
		if (this.khs < 0)
		{
			this.khs = this.Options.Count - 1;
		}
		this.gub();
	}

	// Token: 0x060025AA RID: 9642 RVA: 0x0009D75A File Offset: 0x0009B95A
	private void gyt()
	{
		this.gub();
	}

	// Token: 0x060025AB RID: 9643 RVA: 0x0009D820 File Offset: 0x0009BA20
	public void jpe()
	{
		this.khr = this.khs;
		this.khs = (this.khs + 1) % this.Options.Count;
		this.gub();
	}

	// Token: 0x060025AC RID: 9644 RVA: 0x0009D850 File Offset: 0x0009BA50
	private void bum()
	{
		if (this.kht != null)
		{
			global::UnityEngine.Object.Destroy(this.kht);
		}
		this.kht = global::UnityEngine.Object.Instantiate<GameObject>(this.Options[this.khs], (this.Root != null) ? this.Root : base.transform, false);
		Action<int, int> onOptionSelected = this.OnOptionSelected;
		if (onOptionSelected == null)
		{
			return;
		}
		onOptionSelected(this.khs, this.Options.Count);
	}

	// Token: 0x060025AD RID: 9645 RVA: 0x0009D8D0 File Offset: 0x0009BAD0
	private void gub()
	{
		if (this.kht != null)
		{
			global::UnityEngine.Object.Destroy(this.kht);
		}
		this.kht = global::UnityEngine.Object.Instantiate<GameObject>(this.Options[this.khs], (this.Root != null) ? this.Root : base.transform, false);
		Action<int, int> onOptionSelected = this.OnOptionSelected;
		if (onOptionSelected == null)
		{
			return;
		}
		onOptionSelected(this.khs, this.Options.Count);
	}

	// Token: 0x060025AF RID: 9647 RVA: 0x0009D820 File Offset: 0x0009BA20
	public void bhs()
	{
		this.khr = this.khs;
		this.khs = (this.khs + 1) % this.Options.Count;
		this.gub();
	}

	// Token: 0x060025B0 RID: 9648 RVA: 0x0009D762 File Offset: 0x0009B962
	public void jaa()
	{
		this.khr = this.khs;
		this.khs--;
		if (this.khs < 0)
		{
			this.khs = this.Options.Count - 1;
		}
		this.gub();
	}

	// Token: 0x04001251 RID: 4689
	public List<GameObject> Options;

	// Token: 0x04001252 RID: 4690
	public Transform Root;

	// Token: 0x04001253 RID: 4691
	public Action<int, int> OnOptionSelected;

	// Token: 0x04001254 RID: 4692
	private int khr;

	// Token: 0x04001255 RID: 4693
	private int khs;

	// Token: 0x04001256 RID: 4694
	private GameObject kht;
}
