using System;
using System.Collections.Generic;

// Token: 0x02000113 RID: 275
public sealed class fm
{
	// Token: 0x060013A2 RID: 5026 RVA: 0x00060835 File Offset: 0x0005EA35
	public fm(float a)
	{
		this.iqn = a;
	}

	// Token: 0x060013A3 RID: 5027 RVA: 0x00060868 File Offset: 0x0005EA68
	public List<ulong> fxj(HashSet<ulong> a, IReadOnlyList<ulong> b, float c)
	{
		List<ulong> list = new List<ulong>();
		this.iqq.Clear();
		for (int i = 0; i < b.Count; i++)
		{
			ulong num = b[i];
			this.iqq.Add(num);
			float num2;
			if (a.Contains(num))
			{
				this.iqo.Remove(num);
			}
			else if (!this.iqo.TryGetValue(num, out num2))
			{
				this.iqo[num] = c;
			}
			else if (c - num2 >= this.iqn)
			{
				list.Add(num);
				this.iqo.Remove(num);
			}
		}
		this.iqp.Clear();
		foreach (KeyValuePair<ulong, float> keyValuePair in this.iqo)
		{
			if (!this.iqq.Contains(keyValuePair.Key))
			{
				this.iqp.Add(keyValuePair.Key);
			}
		}
		for (int j = 0; j < this.iqp.Count; j++)
		{
			this.iqo.Remove(this.iqp[j]);
		}
		return list;
	}

	// Token: 0x060013A4 RID: 5028 RVA: 0x000609A8 File Offset: 0x0005EBA8
	public List<ulong> czx(HashSet<ulong> a, IReadOnlyList<ulong> b, float c)
	{
		List<ulong> list = new List<ulong>();
		this.iqq.Clear();
		for (int i = 0; i < b.Count; i++)
		{
			ulong num = b[i];
			this.iqq.Add(num);
			float num2;
			if (a.Contains(num))
			{
				this.iqo.Remove(num);
			}
			else if (!this.iqo.TryGetValue(num, out num2))
			{
				this.iqo[num] = c;
			}
			else if (c - num2 >= this.iqn)
			{
				list.Add(num);
				this.iqo.Remove(num);
			}
		}
		this.iqp.Clear();
		foreach (KeyValuePair<ulong, float> keyValuePair in this.iqo)
		{
			if (!this.iqq.Contains(keyValuePair.Key))
			{
				this.iqp.Add(keyValuePair.Key);
			}
		}
		for (int j = 0; j < this.iqp.Count; j++)
		{
			this.iqo.Remove(this.iqp[j]);
		}
		return list;
	}

	// Token: 0x060013A5 RID: 5029 RVA: 0x00060AE8 File Offset: 0x0005ECE8
	public void czy()
	{
		this.iqo.Clear();
	}

	// Token: 0x060013A6 RID: 5030 RVA: 0x00060AF8 File Offset: 0x0005ECF8
	public List<ulong> ooe(HashSet<ulong> a, IReadOnlyList<ulong> b, float c)
	{
		List<ulong> list = new List<ulong>();
		this.iqq.Clear();
		for (int i = 0; i < b.Count; i++)
		{
			ulong num = b[i];
			this.iqq.Add(num);
			float num2;
			if (a.Contains(num))
			{
				this.iqo.Remove(num);
			}
			else if (!this.iqo.TryGetValue(num, out num2))
			{
				this.iqo[num] = c;
			}
			else if (c - num2 >= this.iqn)
			{
				list.Add(num);
				this.iqo.Remove(num);
			}
		}
		this.iqp.Clear();
		foreach (KeyValuePair<ulong, float> keyValuePair in this.iqo)
		{
			if (!this.iqq.Contains(keyValuePair.Key))
			{
				this.iqp.Add(keyValuePair.Key);
			}
		}
		for (int j = 0; j < this.iqp.Count; j++)
		{
			this.iqo.Remove(this.iqp[j]);
		}
		return list;
	}

	// Token: 0x060013A7 RID: 5031 RVA: 0x00060AE8 File Offset: 0x0005ECE8
	public void ote()
	{
		this.iqo.Clear();
	}

	// Token: 0x04000A51 RID: 2641
	private readonly float iqn;

	// Token: 0x04000A52 RID: 2642
	private readonly Dictionary<ulong, float> iqo = new Dictionary<ulong, float>();

	// Token: 0x04000A53 RID: 2643
	private readonly List<ulong> iqp = new List<ulong>();

	// Token: 0x04000A54 RID: 2644
	private readonly HashSet<ulong> iqq = new HashSet<ulong>();
}
