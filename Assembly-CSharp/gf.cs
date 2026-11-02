using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Spine.Unity;
using UnityEngine;

// Token: 0x02000133 RID: 307
public sealed class gf
{
	// Token: 0x0600167C RID: 5756 RVA: 0x0006F644 File Offset: 0x0006D844
	private Material dpr(Material a)
	{
		if (a == null)
		{
			return null;
		}
		Material material;
		if (this.iyl.TryGetValue(a, out material))
		{
			return material;
		}
		Material material2 = new Material(a)
		{
			name = a.name + a.ehx()
		};
		if (material2.HasProperty(gf.iym))
		{
			material2.SetInt(gf.iym, 0);
		}
		this.iyl[a] = material2;
		this.iyj.CustomMaterialOverride[a] = material2;
		return material2;
	}

	// Token: 0x0600167D RID: 5757 RVA: 0x0006F6C4 File Offset: 0x0006D8C4
	private Material zk(Material a)
	{
		if (a == null)
		{
			return null;
		}
		Material material;
		if (this.iyl.TryGetValue(a, out material))
		{
			return material;
		}
		Material material2 = new Material(a)
		{
			name = a.name + a.eia()
		};
		if (material2.HasProperty(gf.iym))
		{
			material2.SetInt(gf.iym, 0);
		}
		this.iyl[a] = material2;
		this.iyj.CustomMaterialOverride[a] = material2;
		return material2;
	}

	// Token: 0x0600167E RID: 5758 RVA: 0x0006F744 File Offset: 0x0006D944
	private Material cwj(Material a)
	{
		if (a == null)
		{
			return null;
		}
		Material material;
		if (this.iyl.TryGetValue(a, out material))
		{
			return material;
		}
		Material material2 = new Material(a)
		{
			name = a.name + a.eib()
		};
		if (material2.HasProperty(gf.iym))
		{
			material2.SetInt(gf.iym, 0);
		}
		this.iyl[a] = material2;
		this.iyj.CustomMaterialOverride[a] = material2;
		return material2;
	}

	// Token: 0x0600167F RID: 5759 RVA: 0x0006F7C4 File Offset: 0x0006D9C4
	public void els()
	{
		foreach (KeyValuePair<Material, Material> keyValuePair in this.iyl)
		{
			if (keyValuePair.Value != null && keyValuePair.Value.HasProperty(gf.iym))
			{
				keyValuePair.Value.SetInt(gf.iym, 0);
			}
		}
	}

	// Token: 0x06001680 RID: 5760 RVA: 0x0006F844 File Offset: 0x0006DA44
	private void dpo()
	{
		if (this.iyj == null || this.iyk == null || this.iyk.SpineMaterialDatas == null)
		{
			return;
		}
		foreach (SpineMaterialData spineMaterialData in this.iyk.SpineMaterialDatas)
		{
			if (spineMaterialData != null && !(spineMaterialData.material == null))
			{
				this.dpr(spineMaterialData.material);
			}
		}
		fq.dbg(string.Format(a.eic(), this.iyl.Count));
	}

	// Token: 0x06001681 RID: 5761 RVA: 0x0006F8FC File Offset: 0x0006DAFC
	public void hhz()
	{
		foreach (KeyValuePair<Material, Material> keyValuePair in this.iyl)
		{
			if (keyValuePair.Value != null && keyValuePair.Value.HasProperty(gf.iym))
			{
				keyValuePair.Value.SetInt(gf.iym, 0);
			}
		}
	}

	// Token: 0x06001682 RID: 5762 RVA: 0x0006F97C File Offset: 0x0006DB7C
	public void dps()
	{
		fq.dbg(string.Format(a.eid(), this.iyl.Count));
		foreach (KeyValuePair<Material, Material> keyValuePair in this.iyl)
		{
			if (this.iyj != null)
			{
				this.iyj.CustomMaterialOverride.Remove(keyValuePair.Key);
			}
			if (keyValuePair.Value != null)
			{
				global::UnityEngine.Object.Destroy(keyValuePair.Value);
			}
		}
		this.iyl.Clear();
	}

	// Token: 0x06001683 RID: 5763 RVA: 0x0006FA34 File Offset: 0x0006DC34
	private void blq()
	{
		if (this.iyj == null || this.iyk == null || this.iyk.SpineMaterialDatas == null)
		{
			return;
		}
		foreach (SpineMaterialData spineMaterialData in this.iyk.SpineMaterialDatas)
		{
			if (spineMaterialData != null && !(spineMaterialData.material == null))
			{
				this.dpr(spineMaterialData.material);
			}
		}
		fq.dbg(string.Format(a.eie(), this.iyl.Count));
	}

	// Token: 0x06001684 RID: 5764 RVA: 0x0006FAEC File Offset: 0x0006DCEC
	private Material khn(Material a)
	{
		if (a == null)
		{
			return null;
		}
		Material material;
		if (this.iyl.TryGetValue(a, out material))
		{
			return material;
		}
		Material material2 = new Material(a)
		{
			name = a.name + a.eif()
		};
		if (material2.HasProperty(gf.iym))
		{
			material2.SetInt(gf.iym, 0);
		}
		this.iyl[a] = material2;
		this.iyj.CustomMaterialOverride[a] = material2;
		return material2;
	}

	// Token: 0x06001685 RID: 5765 RVA: 0x0006FB6C File Offset: 0x0006DD6C
	public void hsa()
	{
		fq.dbg(string.Format(a.eig(), this.iyl.Count));
		foreach (KeyValuePair<Material, Material> keyValuePair in this.iyl)
		{
			if (this.iyj != null)
			{
				this.iyj.CustomMaterialOverride.Remove(keyValuePair.Key);
			}
			if (keyValuePair.Value != null)
			{
				global::UnityEngine.Object.Destroy(keyValuePair.Value);
			}
		}
		this.iyl.Clear();
	}

	// Token: 0x06001686 RID: 5766 RVA: 0x0006FC24 File Offset: 0x0006DE24
	public void dpq()
	{
		foreach (KeyValuePair<Material, Material> keyValuePair in this.iyl)
		{
			if (keyValuePair.Value != null && keyValuePair.Value.HasProperty(gf.iym))
			{
				keyValuePair.Value.SetInt(gf.iym, 0);
			}
		}
	}

	// Token: 0x06001687 RID: 5767 RVA: 0x0006FCA4 File Offset: 0x0006DEA4
	public gf(SkeletonAnimation a, SpineSkinSetting b)
	{
		this.iyj = a;
		this.iyk = b;
		this.dpo();
	}

	// Token: 0x06001688 RID: 5768 RVA: 0x0006FCCC File Offset: 0x0006DECC
	private Material due(Material a)
	{
		if (a == null)
		{
			return null;
		}
		Material material;
		if (this.iyl.TryGetValue(a, out material))
		{
			return material;
		}
		Material material2 = new Material(a)
		{
			name = a.name + a.eih()
		};
		if (material2.HasProperty(gf.iym))
		{
			material2.SetInt(gf.iym, 0);
		}
		this.iyl[a] = material2;
		this.iyj.CustomMaterialOverride[a] = material2;
		return material2;
	}

	// Token: 0x06001689 RID: 5769 RVA: 0x0006FD4C File Offset: 0x0006DF4C
	public void fsj()
	{
		fq.dbg(string.Format(a.eii(), this.iyl.Count));
		foreach (KeyValuePair<Material, Material> keyValuePair in this.iyl)
		{
			if (this.iyj != null)
			{
				this.iyj.CustomMaterialOverride.Remove(keyValuePair.Key);
			}
			if (keyValuePair.Value != null)
			{
				global::UnityEngine.Object.Destroy(keyValuePair.Value);
			}
		}
		this.iyl.Clear();
	}

	// Token: 0x0600168A RID: 5770 RVA: 0x0006FE04 File Offset: 0x0006E004
	public void fxj()
	{
		foreach (KeyValuePair<Material, Material> keyValuePair in this.iyl)
		{
			if (keyValuePair.Value != null && keyValuePair.Value.HasProperty(gf.iym))
			{
				keyValuePair.Value.SetInt(gf.iym, 0);
			}
		}
	}

	// Token: 0x0600168B RID: 5771 RVA: 0x0006FE84 File Offset: 0x0006E084
	public void dpp(SKIN_NAME a, Texture2D b)
	{
		if (this.iyj == null || this.iyk == null || b == null)
		{
			return;
		}
		SpineMaterialData spineMaterialData = this.iyk.bkv(a);
		if (spineMaterialData == null || spineMaterialData.material == null)
		{
			fq.dbg(string.Format(a.eij(), a));
			return;
		}
		Material material = this.dpr(spineMaterialData.material);
		if (material == null)
		{
			return;
		}
		material.SetInt(gf.iym, 1);
		material.SetTexture(gf.iyn, b);
		fq.dbg(string.Format(a.eik(), a, b.name));
	}

	// Token: 0x04000B66 RID: 2918
	private readonly SkeletonAnimation iyj;

	// Token: 0x04000B67 RID: 2919
	private readonly SpineSkinSetting iyk;

	// Token: 0x04000B68 RID: 2920
	private readonly Dictionary<Material, Material> iyl = new Dictionary<Material, Material>();

	// Token: 0x04000B69 RID: 2921
	private static readonly int iym = Shader.PropertyToID(a.bem());

	// Token: 0x04000B6A RID: 2922
	private static readonly int iyn = Shader.PropertyToID(a.ben());
}
