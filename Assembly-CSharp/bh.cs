using System;
using System.Collections.Generic;
using System.IO;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x02000029 RID: 41
public static class bh
{
	// Token: 0x0600024D RID: 589 RVA: 0x0000BA35 File Offset: 0x00009C35
	public static void wd()
	{
		if (bh.hiu)
		{
			return;
		}
		bh.hiu = true;
		bj.hja += bh.wj;
	}

	// Token: 0x0600024E RID: 590 RVA: 0x0000BA58 File Offset: 0x00009C58
	public static bool wf<b>(string a, string b, out b c, out string d) where b : global::UnityEngine.Object
	{
		c = default(b);
		d = null;
		if (string.IsNullOrEmpty(a))
		{
			d = a.kz();
			return false;
		}
		if (string.IsNullOrEmpty(b))
		{
			d = a.la();
			return false;
		}
		AssetBundle assetBundle;
		if (!bh.wg(a, out assetBundle, out d))
		{
			return false;
		}
		b b2 = assetBundle.LoadAsset<b>(b);
		if (b2 == null)
		{
			d = string.Concat(new string[]
			{
				a.lb(),
				b,
				a.lc(),
				typeof(b).Name,
				a.ld(),
				a,
				a.le()
			});
			return false;
		}
		c = b2;
		return true;
	}

	// Token: 0x06000250 RID: 592 RVA: 0x0000BB18 File Offset: 0x00009D18
	public static void wh(bool a)
	{
		foreach (KeyValuePair<string, AssetBundle> keyValuePair in bh.hit)
		{
			if (keyValuePair.Value != null)
			{
				keyValuePair.Value.Unload(a);
			}
		}
		bh.hit.Clear();
	}

	// Token: 0x06000251 RID: 593 RVA: 0x0000BA35 File Offset: 0x00009C35
	public static void cgs()
	{
		if (bh.hiu)
		{
			return;
		}
		bh.hiu = true;
		bj.hja += bh.wj;
	}

	// Token: 0x06000252 RID: 594 RVA: 0x0000BB8C File Offset: 0x00009D8C
	private static void wj(uint a)
	{
		DlcInfo dlcInfo;
		if (!bk.wu(a, out dlcInfo))
		{
			return;
		}
		Debug.Log(string.Format(a.lf(), a, dlcInfo.BundleName));
		bh.wi(dlcInfo.BundleName);
	}

	// Token: 0x06000253 RID: 595 RVA: 0x0000BBCC File Offset: 0x00009DCC
	public static void isj(string a)
	{
		AssetBundle assetBundle;
		if (bh.hit.TryGetValue(a, out assetBundle))
		{
			if (assetBundle != null)
			{
				assetBundle.Unload(false);
			}
			bh.hit.Remove(a);
		}
	}

	// Token: 0x06000254 RID: 596 RVA: 0x0000BA35 File Offset: 0x00009C35
	public static void djq()
	{
		if (bh.hiu)
		{
			return;
		}
		bh.hiu = true;
		bj.hja += bh.wj;
	}

	// Token: 0x06000255 RID: 597 RVA: 0x0000BC04 File Offset: 0x00009E04
	public static void iy(string a)
	{
		AssetBundle assetBundle;
		if (bh.hit.TryGetValue(a, out assetBundle))
		{
			if (assetBundle != null)
			{
				assetBundle.Unload(false);
			}
			bh.hit.Remove(a);
		}
	}

	// Token: 0x06000256 RID: 598 RVA: 0x0000BC3C File Offset: 0x00009E3C
	public static bool wg(string a, out AssetBundle b, out string c)
	{
		b = null;
		c = null;
		if (bh.hit.TryGetValue(a, out b) && b != null)
		{
			return true;
		}
		DlcInfo dlcInfo;
		if (!bk.wv(a, out dlcInfo))
		{
			c = a.lg() + a + a.lh();
			return false;
		}
		string text;
		if (!bj.wn(dlcInfo.AppId, out text))
		{
			c = string.Format(a.li(), dlcInfo.AppId);
			return false;
		}
		string text2 = Path.Combine(text, a.lj(), a);
		if (!File.Exists(text2))
		{
			c = a.lk() + text2 + a.le();
			return false;
		}
		AssetBundle assetBundle = AssetBundle.LoadFromFile(text2);
		if (assetBundle == null)
		{
			c = a.ll() + text2 + a.lm();
			return false;
		}
		bh.hit[a] = assetBundle;
		b = assetBundle;
		return true;
	}

	// Token: 0x06000257 RID: 599 RVA: 0x0000BD10 File Offset: 0x00009F10
	public static bool we<a>(string a, string b, out a c, out string d) where a : global::UnityEngine.Object
	{
		c = default(a);
		d = null;
		if (string.IsNullOrEmpty(a))
		{
			d = a.kz();
			return false;
		}
		if (string.IsNullOrEmpty(b))
		{
			d = a.ln();
			return false;
		}
		AssetBundle assetBundle;
		if (!bh.wg(a, out assetBundle, out d))
		{
			return false;
		}
		a a2 = assetBundle.LoadAsset<a>(b);
		if (a2 == null)
		{
			d = string.Concat(new string[]
			{
				a.lo(),
				b,
				a.lc(),
				typeof(a).Name,
				a.ld(),
				a,
				a.le()
			});
			return false;
		}
		c = a2;
		return true;
	}

	// Token: 0x06000258 RID: 600 RVA: 0x0000BA35 File Offset: 0x00009C35
	public static void ngx()
	{
		if (bh.hiu)
		{
			return;
		}
		bh.hiu = true;
		bj.hja += bh.wj;
	}

	// Token: 0x06000259 RID: 601 RVA: 0x0000BDC0 File Offset: 0x00009FC0
	public static bool njp(string a, out AssetBundle b, out string c)
	{
		b = null;
		c = null;
		if (bh.hit.TryGetValue(a, out b) && b != null)
		{
			return true;
		}
		DlcInfo dlcInfo;
		if (!bk.wv(a, out dlcInfo))
		{
			c = a.lp() + a + a.lq();
			return false;
		}
		string text;
		if (!bj.wn(dlcInfo.AppId, out text))
		{
			c = string.Format(a.lr(), dlcInfo.AppId);
			return false;
		}
		string text2 = Path.Combine(text, a.ls(), a);
		if (!File.Exists(text2))
		{
			c = a.lt() + text2 + a.lu();
			return false;
		}
		AssetBundle assetBundle = AssetBundle.LoadFromFile(text2);
		if (assetBundle == null)
		{
			c = a.lv() + text2 + a.lw();
			return false;
		}
		bh.hit[a] = assetBundle;
		b = assetBundle;
		return true;
	}

	// Token: 0x0600025A RID: 602 RVA: 0x0000BE94 File Offset: 0x0000A094
	public static bool cks(string a, out AssetBundle b, out string c)
	{
		b = null;
		c = null;
		if (bh.hit.TryGetValue(a, out b) && b != null)
		{
			return true;
		}
		DlcInfo dlcInfo;
		if (!bk.wv(a, out dlcInfo))
		{
			c = a.lx() + a + a.ly();
			return false;
		}
		string text;
		if (!bj.wn(dlcInfo.AppId, out text))
		{
			c = string.Format(a.lz(), dlcInfo.AppId);
			return false;
		}
		string text2 = Path.Combine(text, a.ma(), a);
		if (!File.Exists(text2))
		{
			c = a.mb() + text2 + a.mc();
			return false;
		}
		AssetBundle assetBundle = AssetBundle.LoadFromFile(text2);
		if (assetBundle == null)
		{
			c = a.md() + text2 + a.me();
			return false;
		}
		bh.hit[a] = assetBundle;
		b = assetBundle;
		return true;
	}

	// Token: 0x0600025B RID: 603 RVA: 0x0000BF68 File Offset: 0x0000A168
	private static void kqy(uint a)
	{
		DlcInfo dlcInfo;
		if (!bk.wu(a, out dlcInfo))
		{
			return;
		}
		Debug.Log(string.Format(a.mf(), a, dlcInfo.BundleName));
		bh.wi(dlcInfo.BundleName);
	}

	// Token: 0x0600025C RID: 604 RVA: 0x0000BA35 File Offset: 0x00009C35
	public static void nop()
	{
		if (bh.hiu)
		{
			return;
		}
		bh.hiu = true;
		bj.hja += bh.wj;
	}

	// Token: 0x0600025D RID: 605 RVA: 0x0000BFA8 File Offset: 0x0000A1A8
	public static void wi(string a)
	{
		AssetBundle assetBundle;
		if (bh.hit.TryGetValue(a, out assetBundle))
		{
			if (assetBundle != null)
			{
				assetBundle.Unload(false);
			}
			bh.hit.Remove(a);
		}
	}

	// Token: 0x0600025E RID: 606 RVA: 0x0000BFE0 File Offset: 0x0000A1E0
	public static void oof(string a)
	{
		AssetBundle assetBundle;
		if (bh.hit.TryGetValue(a, out assetBundle))
		{
			if (assetBundle != null)
			{
				assetBundle.Unload(false);
			}
			bh.hit.Remove(a);
		}
	}

	// Token: 0x0600025F RID: 607 RVA: 0x0000C018 File Offset: 0x0000A218
	public static void ddf(string a)
	{
		AssetBundle assetBundle;
		if (bh.hit.TryGetValue(a, out assetBundle))
		{
			if (assetBundle != null)
			{
				assetBundle.Unload(false);
			}
			bh.hit.Remove(a);
		}
	}

	// Token: 0x04000129 RID: 297
	private static readonly Dictionary<string, AssetBundle> hit = new Dictionary<string, AssetBundle>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x0400012A RID: 298
	private static bool hiu;
}
