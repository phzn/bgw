using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200025A RID: 602
public class le : MonoBehaviour
{
	// Token: 0x060025D3 RID: 9683 RVA: 0x0009DB85 File Offset: 0x0009BD85
	public void mjt(int a, bool b)
	{
		this.TabOnGroup[a].SetActive(b);
		this.TabOffGroup[a].SetActive(!b);
	}

	// Token: 0x060025D4 RID: 9684 RVA: 0x0009DBB8 File Offset: 0x0009BDB8
	private void Start()
	{
		foreach (Toggle toggle in base.GetComponentsInChildren<Toggle>())
		{
			toggle.gameObject.AddComponent<lf>().TabMenu = this;
			this.khx.Add(toggle);
		}
		for (int j = 1; j < this.khx.Count; j++)
		{
			this.gug(j, false);
		}
		this.khx[0].isOn = true;
		this.gug(0, true);
	}

	// Token: 0x060025D5 RID: 9685 RVA: 0x0009DB85 File Offset: 0x0009BD85
	public void nnc(int a, bool b)
	{
		this.TabOnGroup[a].SetActive(b);
		this.TabOffGroup[a].SetActive(!b);
	}

	// Token: 0x060025D7 RID: 9687 RVA: 0x0009DC48 File Offset: 0x0009BE48
	private void lzt()
	{
		foreach (Toggle toggle in base.GetComponentsInChildren<Toggle>())
		{
			toggle.gameObject.AddComponent<lf>().TabMenu = this;
			this.khx.Add(toggle);
		}
		for (int j = 1; j < this.khx.Count; j++)
		{
			this.gug(j, false);
		}
		this.khx[0].isOn = true;
		this.gug(0, true);
	}

	// Token: 0x060025D8 RID: 9688 RVA: 0x0009DB85 File Offset: 0x0009BD85
	public void frq(int a, bool b)
	{
		this.TabOnGroup[a].SetActive(b);
		this.TabOffGroup[a].SetActive(!b);
	}

	// Token: 0x060025D9 RID: 9689 RVA: 0x0009DCC4 File Offset: 0x0009BEC4
	private void jan()
	{
		foreach (Toggle toggle in base.GetComponentsInChildren<Toggle>())
		{
			toggle.gameObject.AddComponent<lf>().TabMenu = this;
			this.khx.Add(toggle);
		}
		for (int j = 1; j < this.khx.Count; j++)
		{
			this.gug(j, false);
		}
		this.khx[0].isOn = true;
		this.gug(0, true);
	}

	// Token: 0x060025DA RID: 9690 RVA: 0x0009DD40 File Offset: 0x0009BF40
	public void guh(Toggle a, bool b)
	{
		int num = this.khx.IndexOf(a);
		if (num >= 0)
		{
			this.gug(num, b);
		}
	}

	// Token: 0x060025DB RID: 9691 RVA: 0x0009DB85 File Offset: 0x0009BD85
	public void gug(int a, bool b)
	{
		this.TabOnGroup[a].SetActive(b);
		this.TabOffGroup[a].SetActive(!b);
	}

	// Token: 0x04001262 RID: 4706
	public List<GameObject> TabOnGroup;

	// Token: 0x04001263 RID: 4707
	public List<GameObject> TabOffGroup;

	// Token: 0x04001264 RID: 4708
	private List<Toggle> khx = new List<Toggle>();
}
