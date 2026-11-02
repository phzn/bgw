using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000105 RID: 261
public class fe
{
	// Token: 0x14000030 RID: 48
	// (add) Token: 0x06001302 RID: 4866 RVA: 0x0005C7BC File Offset: 0x0005A9BC
	// (remove) Token: 0x06001321 RID: 4897 RVA: 0x0005D0E0 File Offset: 0x0005B2E0
	public event Action inh;

	// Token: 0x06001303 RID: 4867 RVA: 0x0005C7F4 File Offset: 0x0005A9F4
	public bool Remove(ulong instanceId)
	{
		int num = this.ine.IndexOf(instanceId);
		if (num < 0)
		{
			return false;
		}
		this.ine.RemoveAt(num);
		if (this.ine.Count == 0)
		{
			this.ing = null;
		}
		Action action = this.inh;
		if (action != null)
		{
			action();
		}
		return true;
	}

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x06001304 RID: 4868 RVA: 0x0005C846 File Offset: 0x0005AA46
	public string ktd
	{
		get
		{
			return this.ing;
		}
	}

	// Token: 0x06001305 RID: 4869 RVA: 0x0005C84E File Offset: 0x0005AA4E
	public bool jfn(ulong a)
	{
		return this.ine.Contains(a);
	}

	// Token: 0x06001306 RID: 4870 RVA: 0x0005C85C File Offset: 0x0005AA5C
	public int dky(ulong a)
	{
		int num = 0;
		for (int i = 0; i < this.ine.Count; i++)
		{
			if (this.ine[i] == a)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x06001307 RID: 4871 RVA: 0x0005C895 File Offset: 0x0005AA95
	public bool ktb
	{
		get
		{
			return this.ine.Count >= this.inf;
		}
	}

	// Token: 0x06001308 RID: 4872 RVA: 0x0005C8AD File Offset: 0x0005AAAD
	public ulong frv(int a)
	{
		if (a < 0 || a >= this.ine.Count)
		{
			return 0UL;
		}
		return this.ine[a];
	}

	// Token: 0x06001309 RID: 4873 RVA: 0x0005C8AD File Offset: 0x0005AAAD
	public ulong cwf(int a)
	{
		if (a < 0 || a >= this.ine.Count)
		{
			return 0UL;
		}
		return this.ine[a];
	}

	// Token: 0x0600130A RID: 4874 RVA: 0x0005C8D0 File Offset: 0x0005AAD0
	public int cwd(ulong a)
	{
		int num = 0;
		for (int i = 0; i < this.ine.Count; i++)
		{
			if (this.ine[i] == a)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x0600130B RID: 4875 RVA: 0x0005C84E File Offset: 0x0005AA4E
	public bool cwc(ulong a)
	{
		return this.ine.Contains(a);
	}

	// Token: 0x0600130C RID: 4876 RVA: 0x0005C90C File Offset: 0x0005AB0C
	public bool cwe(int a)
	{
		if (a < 0 || a >= this.ine.Count)
		{
			return false;
		}
		this.ine.RemoveAt(a);
		if (this.ine.Count == 0)
		{
			this.ing = null;
		}
		Action action = this.inh;
		if (action != null)
		{
			action();
		}
		return true;
	}

	// Token: 0x0600130D RID: 4877 RVA: 0x0005C960 File Offset: 0x0005AB60
	public bool fzw(int a)
	{
		if (a < 0 || a >= this.ine.Count)
		{
			return false;
		}
		this.ine.RemoveAt(a);
		if (this.ine.Count == 0)
		{
			this.ing = null;
		}
		Action action = this.inh;
		if (action != null)
		{
			action();
		}
		return true;
	}

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x0600130E RID: 4878 RVA: 0x0005C9B3 File Offset: 0x0005ABB3
	public IReadOnlyList<ulong> ksy
	{
		get
		{
			return this.ine;
		}
	}

	// Token: 0x0600130F RID: 4879 RVA: 0x0005C9BC File Offset: 0x0005ABBC
	public ValueTuple<ulong, uint>[] oos()
	{
		Dictionary<ulong, uint> dictionary = new Dictionary<ulong, uint>();
		for (int i = 0; i < this.ine.Count; i++)
		{
			ulong num = this.ine[i];
			uint num2;
			dictionary.TryGetValue(num, out num2);
			dictionary[num] = num2 + 1U;
		}
		ValueTuple<ulong, uint>[] array = new ValueTuple<ulong, uint>[dictionary.Count];
		int num3 = 0;
		foreach (KeyValuePair<ulong, uint> keyValuePair in dictionary)
		{
			array[num3++] = new ValueTuple<ulong, uint>(keyValuePair.Key, keyValuePair.Value);
		}
		return array;
	}

	// Token: 0x06001310 RID: 4880 RVA: 0x0005CA74 File Offset: 0x0005AC74
	public bool gvc(ulong instanceId)
	{
		int num = this.ine.IndexOf(instanceId);
		if (num < 0)
		{
			return false;
		}
		this.ine.RemoveAt(num);
		if (this.ine.Count == 0)
		{
			this.ing = null;
		}
		Action action = this.inh;
		if (action != null)
		{
			action();
		}
		return true;
	}

	// Token: 0x06001311 RID: 4881 RVA: 0x0005CAC8 File Offset: 0x0005ACC8
	public int bkm(ulong a)
	{
		int num = 0;
		for (int i = 0; i < this.ine.Count; i++)
		{
			if (this.ine[i] == a)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06001312 RID: 4882 RVA: 0x0005CB04 File Offset: 0x0005AD04
	public int cwh(IReadOnlyList<ItemData> a)
	{
		if (a == null)
		{
			int count = this.ine.Count;
			this.cwg();
			return count;
		}
		Dictionary<ulong, uint> dictionary = new Dictionary<ulong, uint>(a.Count);
		for (int i = 0; i < a.Count; i++)
		{
			ItemData itemData = a[i];
			if (itemData != null && itemData.quantity > 0U)
			{
				dictionary[itemData.itemId] = itemData.quantity;
			}
		}
		int num = 0;
		for (int j = this.ine.Count - 1; j >= 0; j--)
		{
			if (!dictionary.ContainsKey(this.ine[j]))
			{
				this.ine.RemoveAt(j);
				num++;
			}
		}
		Dictionary<ulong, int> dictionary2 = new Dictionary<ulong, int>();
		for (int k = this.ine.Count - 1; k >= 0; k--)
		{
			ulong num2 = this.ine[k];
			int num3;
			dictionary2.TryGetValue(num2, out num3);
			num3++;
			if (num3 > (int)dictionary[num2])
			{
				this.ine.RemoveAt(k);
				num++;
			}
			else
			{
				dictionary2[num2] = num3;
			}
		}
		if (this.ine.Count == 0)
		{
			this.ing = null;
		}
		if (num > 0)
		{
			Action action = this.inh;
			if (action != null)
			{
				action();
			}
		}
		return num;
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x0005CC48 File Offset: 0x0005AE48
	public bool Add(ulong instanceId, string rarity)
	{
		if (this.ktb)
		{
			return false;
		}
		if (this.ing == null)
		{
			this.ing = rarity ?? string.Empty;
		}
		else if (!string.Equals(this.ing, rarity ?? string.Empty, StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}
		this.ine.Add(instanceId);
		Action action = this.inh;
		if (action != null)
		{
			action();
		}
		return true;
	}

	// Token: 0x06001314 RID: 4884 RVA: 0x0005C84E File Offset: 0x0005AA4E
	public bool dkn(ulong a)
	{
		return this.ine.Contains(a);
	}

	// Token: 0x06001315 RID: 4885 RVA: 0x0005CCB4 File Offset: 0x0005AEB4
	public bool ocb(ulong instanceId, string rarity)
	{
		if (this.ktb)
		{
			return false;
		}
		if (this.ing == null)
		{
			this.ing = rarity ?? string.Empty;
		}
		else if (!string.Equals(this.ing, rarity ?? string.Empty, StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}
		this.ine.Add(instanceId);
		Action action = this.inh;
		if (action != null)
		{
			action();
		}
		return true;
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x0005CD20 File Offset: 0x0005AF20
	public bool nrc(ulong instanceId, string rarity)
	{
		if (this.ktb)
		{
			return false;
		}
		if (this.ing == null)
		{
			this.ing = rarity ?? string.Empty;
		}
		else if (!string.Equals(this.ing, rarity ?? string.Empty, StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}
		this.ine.Add(instanceId);
		Action action = this.inh;
		if (action != null)
		{
			action();
		}
		return true;
	}

	// Token: 0x06001317 RID: 4887 RVA: 0x0005CD8C File Offset: 0x0005AF8C
	public int ocp(ulong a)
	{
		int num = 0;
		for (int i = 0; i < this.ine.Count; i++)
		{
			if (this.ine[i] == a)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06001318 RID: 4888 RVA: 0x0005CDC8 File Offset: 0x0005AFC8
	[return: TupleElementNames(new string[] { "instanceId", "qty" })]
	public ValueTuple<ulong, uint>[] cwi()
	{
		Dictionary<ulong, uint> dictionary = new Dictionary<ulong, uint>();
		for (int i = 0; i < this.ine.Count; i++)
		{
			ulong num = this.ine[i];
			uint num2;
			dictionary.TryGetValue(num, out num2);
			dictionary[num] = num2 + 1U;
		}
		ValueTuple<ulong, uint>[] array = new ValueTuple<ulong, uint>[dictionary.Count];
		int num3 = 0;
		foreach (KeyValuePair<ulong, uint> keyValuePair in dictionary)
		{
			array[num3++] = new ValueTuple<ulong, uint>(keyValuePair.Key, keyValuePair.Value);
		}
		return array;
	}

	// Token: 0x06001319 RID: 4889 RVA: 0x0005CE80 File Offset: 0x0005B080
	public void cwg()
	{
		if (this.ine.Count == 0 && this.ing == null)
		{
			return;
		}
		this.ine.Clear();
		this.ing = null;
		Action action = this.inh;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x0005CEBC File Offset: 0x0005B0BC
	public bool flw(ulong instanceId)
	{
		int num = this.ine.IndexOf(instanceId);
		if (num < 0)
		{
			return false;
		}
		this.ine.RemoveAt(num);
		if (this.ine.Count == 0)
		{
			this.ing = null;
		}
		Action action = this.inh;
		if (action != null)
		{
			action();
		}
		return true;
	}

	// Token: 0x0600131B RID: 4891 RVA: 0x0005CF0E File Offset: 0x0005B10E
	public fe(int a)
	{
		this.inf = Mathf.Max(1, a);
		this.ine = new List<ulong>(this.inf);
	}

	// Token: 0x0600131C RID: 4892 RVA: 0x0005CF34 File Offset: 0x0005B134
	public bool fup(int a)
	{
		if (a < 0 || a >= this.ine.Count)
		{
			return false;
		}
		this.ine.RemoveAt(a);
		if (this.ine.Count == 0)
		{
			this.ing = null;
		}
		Action action = this.inh;
		if (action != null)
		{
			action();
		}
		return true;
	}

	// Token: 0x0600131D RID: 4893 RVA: 0x0005CF88 File Offset: 0x0005B188
	public int hdi(ulong a)
	{
		int num = 0;
		for (int i = 0; i < this.ine.Count; i++)
		{
			if (this.ine[i] == a)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x0600131E RID: 4894 RVA: 0x0005CFC4 File Offset: 0x0005B1C4
	public bool en(int a)
	{
		if (a < 0 || a >= this.ine.Count)
		{
			return false;
		}
		this.ine.RemoveAt(a);
		if (this.ine.Count == 0)
		{
			this.ing = null;
		}
		Action action = this.inh;
		if (action != null)
		{
			action();
		}
		return true;
	}

	// Token: 0x0600131F RID: 4895 RVA: 0x0005D018 File Offset: 0x0005B218
	public ValueTuple<ulong, uint>[] ihr()
	{
		Dictionary<ulong, uint> dictionary = new Dictionary<ulong, uint>();
		for (int i = 0; i < this.ine.Count; i++)
		{
			ulong num = this.ine[i];
			uint num2;
			dictionary.TryGetValue(num, out num2);
			dictionary[num] = num2 + 1U;
		}
		ValueTuple<ulong, uint>[] array = new ValueTuple<ulong, uint>[dictionary.Count];
		int num3 = 0;
		foreach (KeyValuePair<ulong, uint> keyValuePair in dictionary)
		{
			array[num3++] = new ValueTuple<ulong, uint>(keyValuePair.Key, keyValuePair.Value);
		}
		return array;
	}

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x06001320 RID: 4896 RVA: 0x0005D0D0 File Offset: 0x0005B2D0
	public bool ktc
	{
		get
		{
			return this.ine.Count == 0;
		}
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x06001322 RID: 4898 RVA: 0x0005D115 File Offset: 0x0005B315
	public int ksz
	{
		get
		{
			return this.inf;
		}
	}

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x06001323 RID: 4899 RVA: 0x0005D11D File Offset: 0x0005B31D
	public int kta
	{
		get
		{
			return this.ine.Count;
		}
	}

	// Token: 0x06001324 RID: 4900 RVA: 0x0005D12C File Offset: 0x0005B32C
	public bool ghg(int a)
	{
		if (a < 0 || a >= this.ine.Count)
		{
			return false;
		}
		this.ine.RemoveAt(a);
		if (this.ine.Count == 0)
		{
			this.ing = null;
		}
		Action action = this.inh;
		if (action != null)
		{
			action();
		}
		return true;
	}

	// Token: 0x06001325 RID: 4901 RVA: 0x0005D180 File Offset: 0x0005B380
	public ValueTuple<ulong, uint>[] cnu()
	{
		Dictionary<ulong, uint> dictionary = new Dictionary<ulong, uint>();
		for (int i = 0; i < this.ine.Count; i++)
		{
			ulong num = this.ine[i];
			uint num2;
			dictionary.TryGetValue(num, out num2);
			dictionary[num] = num2 + 1U;
		}
		ValueTuple<ulong, uint>[] array = new ValueTuple<ulong, uint>[dictionary.Count];
		int num3 = 0;
		foreach (KeyValuePair<ulong, uint> keyValuePair in dictionary)
		{
			array[num3++] = new ValueTuple<ulong, uint>(keyValuePair.Key, keyValuePair.Value);
		}
		return array;
	}

	// Token: 0x06001326 RID: 4902 RVA: 0x0005D238 File Offset: 0x0005B438
	public ValueTuple<ulong, uint>[] fuw()
	{
		Dictionary<ulong, uint> dictionary = new Dictionary<ulong, uint>();
		for (int i = 0; i < this.ine.Count; i++)
		{
			ulong num = this.ine[i];
			uint num2;
			dictionary.TryGetValue(num, out num2);
			dictionary[num] = num2 + 1U;
		}
		ValueTuple<ulong, uint>[] array = new ValueTuple<ulong, uint>[dictionary.Count];
		int num3 = 0;
		foreach (KeyValuePair<ulong, uint> keyValuePair in dictionary)
		{
			array[num3++] = new ValueTuple<ulong, uint>(keyValuePair.Key, keyValuePair.Value);
		}
		return array;
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x0005C8AD File Offset: 0x0005AAAD
	public ulong odf(int a)
	{
		if (a < 0 || a >= this.ine.Count)
		{
			return 0UL;
		}
		return this.ine[a];
	}

	// Token: 0x040009D9 RID: 2521
	private readonly List<ulong> ine;

	// Token: 0x040009DA RID: 2522
	private readonly int inf;

	// Token: 0x040009DB RID: 2523
	private string ing;
}
