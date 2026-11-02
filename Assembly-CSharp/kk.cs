using System;
using TMPro;
using UnityEngine;

// Token: 0x0200023C RID: 572
public class kk : MonoBehaviour
{
	// Token: 0x060024DF RID: 9439 RVA: 0x0009B0AA File Offset: 0x000992AA
	private void hag()
	{
		this.kgf = kk.gql();
	}

	// Token: 0x060024E0 RID: 9440 RVA: 0x0009B0B7 File Offset: 0x000992B7
	private static int gql()
	{
		if (kk.kgh == 2147483647)
		{
			kk.kgh = 0;
		}
		int num = kk.kgh;
		kk.kgh++;
		return num;
	}

	// Token: 0x060024E1 RID: 9441 RVA: 0x0009B0AA File Offset: 0x000992AA
	private void Awake()
	{
		this.kgf = kk.gql();
	}

	// Token: 0x170005F3 RID: 1523
	// (get) Token: 0x060024E7 RID: 9447 RVA: 0x0009B10D File Offset: 0x0009930D
	// (set) Token: 0x060024E2 RID: 9442 RVA: 0x0009B0DC File Offset: 0x000992DC
	public bool mft
	{
		get
		{
			return this.kgg;
		}
		set
		{
			if (this.title == null)
			{
				return;
			}
			this.title.gameObject.SetActive(value);
			this.kgg = value;
		}
	}

	// Token: 0x060024E3 RID: 9443 RVA: 0x0009B0AA File Offset: 0x000992AA
	private void ecy()
	{
		this.kgf = kk.gql();
	}

	// Token: 0x060024E4 RID: 9444 RVA: 0x00005090 File Offset: 0x00003290
	public virtual void gqk(Action a)
	{
	}

	// Token: 0x170005F2 RID: 1522
	// (get) Token: 0x060024E6 RID: 9446 RVA: 0x0009B105 File Offset: 0x00099305
	public int mfs
	{
		get
		{
			return this.kgf;
		}
	}

	// Token: 0x060024E8 RID: 9448 RVA: 0x0009B0AA File Offset: 0x000992AA
	private void cdq()
	{
		this.kgf = kk.gql();
	}

	// Token: 0x040011F4 RID: 4596
	public TMP_Text title;

	// Token: 0x040011F5 RID: 4597
	private int kgf;

	// Token: 0x040011F6 RID: 4598
	private bool kgg;

	// Token: 0x040011F7 RID: 4599
	private static int kgh;
}
