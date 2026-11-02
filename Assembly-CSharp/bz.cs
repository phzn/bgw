using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x02000041 RID: 65
public class bz : MonoBehaviour
{
	// Token: 0x060003FF RID: 1023 RVA: 0x00013E1B File Offset: 0x0001201B
	public void bdr()
	{
		if (this.sizes.Count == 0)
		{
			Debug.LogError(a.va());
			return;
		}
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x00013E38 File Offset: 0x00012038
	public bool nvu(int a)
	{
		if (a < 0 || a >= this.sizes.Count || this.sizes.Count == 0)
		{
			return false;
		}
		float num = this.sizes[a];
		for (int i = 0; i < this.sizes.Count; i++)
		{
			if (this.sizes[i] < num)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x00013E9C File Offset: 0x0001209C
	public int bdv(int a)
	{
		int num = a + 1;
		if (num < this.sizes.Count)
		{
			this.bds(num);
		}
		else
		{
			num = 0;
			this.bds(num);
		}
		return num;
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x00013ED0 File Offset: 0x000120D0
	public int lee(int a)
	{
		int num = a + 1;
		if (num < this.sizes.Count)
		{
			this.bds(num);
		}
		else
		{
			num = 0;
			this.bds(num);
		}
		return num;
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x00013F02 File Offset: 0x00012102
	public void hau()
	{
		if (this.sizes.Count == 0)
		{
			Debug.LogError(a.vb());
			return;
		}
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x00013F1C File Offset: 0x0001211C
	public float lok(int a)
	{
		if (a < 0 || a >= this.sizes.Count)
		{
			Debug.LogError(a.vc());
			return this.sizes[1];
		}
		return this.sizes[a];
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x00013F54 File Offset: 0x00012154
	public bool kin(int a)
	{
		if (a < 0 || a >= this.sizes.Count || this.sizes.Count == 0)
		{
			return false;
		}
		float num = this.sizes[a];
		for (int i = 0; i < this.sizes.Count; i++)
		{
			if (this.sizes[i] > num)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x00013FB7 File Offset: 0x000121B7
	public float dwf(int a)
	{
		if (a < 0 || a >= this.sizes.Count)
		{
			Debug.LogError(a.vd());
			return this.sizes[1];
		}
		return this.sizes[a];
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x0001404C File Offset: 0x0001224C
	public int fhj(int a)
	{
		int num = a + 1;
		if (num < this.sizes.Count)
		{
			this.bds(num);
		}
		else
		{
			num = 0;
			this.bds(num);
		}
		return num;
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x00014080 File Offset: 0x00012280
	public bool mgv(int a)
	{
		if (a < 0 || a >= this.sizes.Count || this.sizes.Count == 0)
		{
			return false;
		}
		float num = this.sizes[a];
		for (int i = 0; i < this.sizes.Count; i++)
		{
			if (this.sizes[i] > num)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x000140E4 File Offset: 0x000122E4
	public bool bdu(int a)
	{
		if (a < 0 || a >= this.sizes.Count || this.sizes.Count == 0)
		{
			return false;
		}
		float num = this.sizes[a];
		for (int i = 0; i < this.sizes.Count; i++)
		{
			if (this.sizes[i] > num)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00014148 File Offset: 0x00012348
	public bool gxq(int a)
	{
		if (a < 0 || a >= this.sizes.Count || this.sizes.Count == 0)
		{
			return false;
		}
		float num = this.sizes[a];
		for (int i = 0; i < this.sizes.Count; i++)
		{
			if (this.sizes[i] < num)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x000141AC File Offset: 0x000123AC
	public bool edb(int a)
	{
		if (a < 0 || a >= this.sizes.Count || this.sizes.Count == 0)
		{
			return false;
		}
		float num = this.sizes[a];
		for (int i = 0; i < this.sizes.Count; i++)
		{
			if (this.sizes[i] < num)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x0001420F File Offset: 0x0001240F
	public float lrz(int a)
	{
		if (a < 0 || a >= this.sizes.Count)
		{
			Debug.LogError(a.ve());
			return this.sizes[1];
		}
		return this.sizes[a];
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x00014246 File Offset: 0x00012446
	public float bdq(int a)
	{
		if (a < 0 || a >= this.sizes.Count)
		{
			Debug.LogError(a.vf());
			return this.sizes[1];
		}
		return this.sizes[a];
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x00014280 File Offset: 0x00012480
	public bool klh(int a)
	{
		if (a < 0 || a >= this.sizes.Count || this.sizes.Count == 0)
		{
			return false;
		}
		float num = this.sizes[a];
		for (int i = 0; i < this.sizes.Count; i++)
		{
			if (this.sizes[i] > num)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x000142E4 File Offset: 0x000124E4
	public bool ncy(int a)
	{
		if (a < 0 || a >= this.sizes.Count || this.sizes.Count == 0)
		{
			return false;
		}
		float num = this.sizes[a];
		for (int i = 0; i < this.sizes.Count; i++)
		{
			if (this.sizes[i] > num)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x00014348 File Offset: 0x00012548
	public void bds(int a)
	{
		if (a == this.hom)
		{
			return;
		}
		float num;
		if (a < 0 || a >= this.sizes.Count)
		{
			Debug.LogError(a.vf());
			num = this.sizes[1];
		}
		else
		{
			num = this.sizes[a];
		}
		if (this.gameObjects == null || this.gameObjects.Length == 0)
		{
			Debug.LogWarning(a.vg());
			return;
		}
		this.hom = a;
		for (int i = 0; i < this.gameObjects.Length; i++)
		{
			if (this.gameObjects[i] != null)
			{
				this.gameObjects[i].transform.localScale = new Vector3(num, num, num);
			}
			else
			{
				Debug.LogWarning(string.Format(a.vh(), i));
			}
		}
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x00014410 File Offset: 0x00012610
	public bool bdt(int a)
	{
		if (a < 0 || a >= this.sizes.Count || this.sizes.Count == 0)
		{
			return false;
		}
		float num = this.sizes[a];
		for (int i = 0; i < this.sizes.Count; i++)
		{
			if (this.sizes[i] < num)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x040001E4 RID: 484
	public GameObject[] gameObjects;

	// Token: 0x040001E5 RID: 485
	public List<float> sizes = new List<float> { 1f, 1.2f, 1.5f, 1.8f, 2.1f };

	// Token: 0x040001E6 RID: 486
	private int hom = -1;
}
