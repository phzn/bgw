using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using TMPro;
using UnityEngine;

// Token: 0x02000093 RID: 147
[RequireComponent(typeof(TMP_Dropdown))]
public class cy : MonoBehaviour
{
	// Token: 0x0600068E RID: 1678 RVA: 0x00024AB4 File Offset: 0x00022CB4
	private void Awake()
	{
		this.hvs = base.GetComponent<TMP_Dropdown>();
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x00024AC4 File Offset: 0x00022CC4
	private void lto(Transform a)
	{
		Transform transform = cy.brq(a);
		if (transform == null)
		{
			return;
		}
		for (int i = 0; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			if (child.name.Contains(a.bid()))
			{
				int num = cy.brp(child.name);
				if (num >= 0)
				{
					cs cs = child.GetComponent<cs>();
					if (cs == null)
					{
						cs = child.GetComponentInChildren<cs>(true);
					}
					if (!(cs == null))
					{
						bool flag = this.hvt.ContainsKey(num);
						uint num2 = (flag ? this.hvt[num] : 0U);
						cs.bnz(flag, num2, a.bie());
					}
				}
			}
		}
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x00024B7C File Offset: 0x00022D7C
	private void kqg(Transform a)
	{
		Transform transform = cy.brq(a);
		if (transform == null)
		{
			return;
		}
		for (int i = 0; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			if (child.name.Contains(a.bif()))
			{
				int num = cy.brp(child.name);
				if (num >= 0)
				{
					cs cs = child.GetComponent<cs>();
					if (cs == null)
					{
						cs = child.GetComponentInChildren<cs>(true);
					}
					if (!(cs == null))
					{
						bool flag = this.hvt.ContainsKey(num);
						uint num2 = (flag ? this.hvt[num] : 0U);
						cs.bnz(flag, num2, a.big());
					}
				}
			}
		}
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x00024C34 File Offset: 0x00022E34
	private void LateUpdate()
	{
		Transform transform = this.hvs.transform.Find(a.bih());
		bool flag = transform != null && transform.gameObject.activeInHierarchy;
		if (flag && !this.hvu)
		{
			this.bro(transform);
		}
		this.hvu = flag;
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x00024C88 File Offset: 0x00022E88
	private static int brp(string a)
	{
		int num = a.IndexOf(' ');
		int num2 = a.IndexOf(':');
		if (num < 0 || num2 <= num)
		{
			return -1;
		}
		int num3;
		if (!int.TryParse(a.Substring(num + 1, num2 - num - 1), out num3))
		{
			return -1;
		}
		return num3;
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x00024AB4 File Offset: 0x00022CB4
	private void bbv()
	{
		this.hvs = base.GetComponent<TMP_Dropdown>();
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x00024AB4 File Offset: 0x00022CB4
	private void kfu()
	{
		this.hvs = base.GetComponent<TMP_Dropdown>();
	}

	// Token: 0x06000696 RID: 1686 RVA: 0x00024CE0 File Offset: 0x00022EE0
	private void cze()
	{
		Transform transform = this.hvs.transform.Find(a.bii());
		bool flag = transform != null && transform.gameObject.activeInHierarchy;
		if (flag && !this.hvu)
		{
			this.bro(transform);
		}
		this.hvu = flag;
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x00024D34 File Offset: 0x00022F34
	public void da()
	{
		this.hvt.Clear();
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x00024D44 File Offset: 0x00022F44
	private void bro(Transform a)
	{
		Transform transform = cy.brq(a);
		if (transform == null)
		{
			return;
		}
		for (int i = 0; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			if (child.name.Contains(a.bij()))
			{
				int num = cy.brp(child.name);
				if (num >= 0)
				{
					cs cs = child.GetComponent<cs>();
					if (cs == null)
					{
						cs = child.GetComponentInChildren<cs>(true);
					}
					if (!(cs == null))
					{
						bool flag = this.hvt.ContainsKey(num);
						uint num2 = (flag ? this.hvt[num] : 0U);
						cs.bnz(flag, num2, a.tk());
					}
				}
			}
		}
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x00024DFB File Offset: 0x00022FFB
	public void ets(int a, uint b)
	{
		this.hvt[a] = b;
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x00024D34 File Offset: 0x00022F34
	public void brn()
	{
		this.hvt.Clear();
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x00024E0C File Offset: 0x0002300C
	private static int dlp(string a)
	{
		int num = a.IndexOf((char)(-62));
		int num2 = a.IndexOf('\n');
		if (num < 0 || num2 <= num)
		{
			return -1;
		}
		int num3;
		if (!int.TryParse(a.Substring(num + 1, num2 - num - 1), out num3))
		{
			return -1;
		}
		return num3;
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x00024E50 File Offset: 0x00023050
	private static int fks(string a)
	{
		int num = a.IndexOf('N');
		int num2 = a.IndexOf((char)(-38));
		if (num < 0 || num2 <= num)
		{
			return -1;
		}
		int num3;
		if (!int.TryParse(a.Substring(num + 1, num2 - num - 1), out num3))
		{
			return -1;
		}
		return num3;
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x00024E94 File Offset: 0x00023094
	private void dlj(Transform a)
	{
		Transform transform = cy.brq(a);
		if (transform == null)
		{
			return;
		}
		for (int i = 0; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			if (child.name.Contains(a.bik()))
			{
				int num = cy.brp(child.name);
				if (num >= 0)
				{
					cs cs = child.GetComponent<cs>();
					if (cs == null)
					{
						cs = child.GetComponentInChildren<cs>(true);
					}
					if (!(cs == null))
					{
						bool flag = this.hvt.ContainsKey(num);
						uint num2 = (flag ? this.hvt[num] : 0U);
						cs.bnz(flag, num2, a.bil());
					}
				}
			}
		}
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x00024F4C File Offset: 0x0002314C
	private void ikp()
	{
		Transform transform = this.hvs.transform.Find(a.bim());
		bool flag = transform != null && transform.gameObject.activeInHierarchy;
		if (flag && !this.hvu)
		{
			this.bro(transform);
		}
		this.hvu = flag;
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x00024AB4 File Offset: 0x00022CB4
	private void dxh()
	{
		this.hvs = base.GetComponent<TMP_Dropdown>();
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x00024D34 File Offset: 0x00022F34
	public void liy()
	{
		this.hvt.Clear();
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x00024AB4 File Offset: 0x00022CB4
	private void ecx()
	{
		this.hvs = base.GetComponent<TMP_Dropdown>();
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x00024FA0 File Offset: 0x000231A0
	private static Transform brq(Transform a)
	{
		Transform transform = a.Find(a.bin());
		if (transform != null)
		{
			Transform transform2 = transform.Find(a.lj());
			if (transform2 != null)
			{
				return transform2;
			}
		}
		return a.Find(a.lj());
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x00024FE4 File Offset: 0x000231E4
	private void fas()
	{
		Transform transform = this.hvs.transform.Find(a.bio());
		bool flag = transform != null && transform.gameObject.activeInHierarchy;
		if (flag && !this.hvu)
		{
			this.bro(transform);
		}
		this.hvu = flag;
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x00024DFB File Offset: 0x00022FFB
	public void brm(int a, uint b)
	{
		this.hvt[a] = b;
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00024DFB File Offset: 0x00022FFB
	public void oei(int a, uint b)
	{
		this.hvt[a] = b;
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x00025038 File Offset: 0x00023238
	private void evx()
	{
		Transform transform = this.hvs.transform.Find(a.bip());
		bool flag = transform != null && transform.gameObject.activeInHierarchy;
		if (flag && !this.hvu)
		{
			this.bro(transform);
		}
		this.hvu = flag;
	}

	// Token: 0x04000670 RID: 1648
	private TMP_Dropdown hvs;

	// Token: 0x04000671 RID: 1649
	private readonly Dictionary<int, uint> hvt = new Dictionary<int, uint>();

	// Token: 0x04000672 RID: 1650
	private bool hvu;
}
