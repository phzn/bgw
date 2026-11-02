using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x02000028 RID: 40
public static class bg
{
	// Token: 0x0600023D RID: 573 RVA: 0x0000B340 File Offset: 0x00009540
	public static string wb(CLOTHE_TYPE a, CLOTHE_NAME b)
	{
		string text = a.ToString();
		int num = (int)b;
		string text2 = num.ToString(a.jn());
		return string.Concat(new string[]
		{
			a.jo(),
			text,
			a.jp(),
			text2,
			a.jq()
		});
	}

	// Token: 0x0600023E RID: 574 RVA: 0x0000B398 File Offset: 0x00009598
	public static string wa(CLOTHE_TYPE a, CLOTHE_NAME b)
	{
		string text = a.ToString();
		int num = (int)b;
		string text2 = num.ToString(a.jn());
		return string.Concat(new string[]
		{
			a.jo(),
			text,
			a.jr(),
			text2,
			a.jq()
		});
	}

	// Token: 0x0600023F RID: 575 RVA: 0x0000B3F0 File Offset: 0x000095F0
	public static bool r(SpineSkinData a, out string b)
	{
		b = null;
		if (a == null)
		{
			b = a.js();
			return false;
		}
		if (!a.koy)
		{
			b = a.jt();
			return false;
		}
		string text = bg.wa(a.type, a.name);
		string text2 = bg.wb(a.type, a.name);
		Texture2D texture2D;
		string text3;
		if (!bh.wf<Texture2D>(bk.hjd.BundleName, text, out texture2D, out text3))
		{
			b = a.ju() + text + a.jv() + text3;
			return false;
		}
		Sprite sprite;
		string text4;
		if (!bh.wf<Sprite>(bk.hjd.BundleName, text2, out sprite, out text4))
		{
			b = a.jw() + text2 + a.jx() + text4;
			return false;
		}
		a.texture = texture2D;
		a.icon = sprite;
		return true;
	}

	// Token: 0x06000240 RID: 576 RVA: 0x0000B4A8 File Offset: 0x000096A8
	private static void lej(uint a)
	{
		if (bg.his == null || bg.his.SpineSkinDatas == null)
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < bg.his.SpineSkinDatas.Count; i++)
		{
			SpineSkinData spineSkinData = bg.his.SpineSkinDatas[i];
			string text;
			if (spineSkinData != null && spineSkinData.koy && spineSkinData.bjn() == a && bg.vz(spineSkinData, out text))
			{
				num++;
			}
		}
		if (num == 0)
		{
			return;
		}
		Debug.Log(string.Format(a.jy(), a, num));
		bg.his.bkm();
		bg.his.bkp();
	}

	// Token: 0x06000241 RID: 577 RVA: 0x0000B554 File Offset: 0x00009754
	public static string kab(CLOTHE_TYPE a, CLOTHE_NAME b)
	{
		string text = a.ToString();
		int num = (int)b;
		string text2 = num.ToString(a.jz());
		return string.Concat(new string[]
		{
			a.ka(),
			text,
			a.kb(),
			text2,
			a.kc()
		});
	}

	// Token: 0x06000242 RID: 578 RVA: 0x0000B5AC File Offset: 0x000097AC
	public static int fab(SpineSkinSetting a)
	{
		if (a == null || a.SpineSkinDatas == null)
		{
			return 0;
		}
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < a.SpineSkinDatas.Count; i++)
		{
			SpineSkinData spineSkinData = a.SpineSkinDatas[i];
			if (spineSkinData != null && spineSkinData.koy)
			{
				num2++;
				string text;
				if (bg.vz(spineSkinData, out text))
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x06000243 RID: 579 RVA: 0x0000B614 File Offset: 0x00009814
	public static bool vz(SpineSkinData a, out string b)
	{
		b = null;
		if (a == null)
		{
			b = a.kd();
			return false;
		}
		if (!a.koy)
		{
			b = a.ke();
			return false;
		}
		string text = bg.wa(a.type, a.name);
		string text2 = bg.wb(a.type, a.name);
		Texture2D texture2D;
		string text3;
		if (!bh.wf<Texture2D>(bk.hjd.BundleName, text, out texture2D, out text3))
		{
			b = a.kf() + text + a.kg() + text3;
			return false;
		}
		Sprite sprite;
		string text4;
		if (!bh.wf<Sprite>(bk.hjd.BundleName, text2, out sprite, out text4))
		{
			b = a.kh() + text2 + a.kg() + text4;
			return false;
		}
		a.texture = texture2D;
		a.icon = sprite;
		return true;
	}

	// Token: 0x06000244 RID: 580 RVA: 0x0000B6CC File Offset: 0x000098CC
	public static void erd(SpineSkinSetting a)
	{
		if (bg.hir)
		{
			return;
		}
		bg.hir = true;
		bg.his = a;
		bj.hja += bg.wc;
	}

	// Token: 0x06000245 RID: 581 RVA: 0x0000B6F4 File Offset: 0x000098F4
	public static int vy(SpineSkinSetting a)
	{
		if (a == null || a.SpineSkinDatas == null)
		{
			return 0;
		}
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < a.SpineSkinDatas.Count; i++)
		{
			SpineSkinData spineSkinData = a.SpineSkinDatas[i];
			if (spineSkinData != null && spineSkinData.koy)
			{
				num2++;
				string text;
				if (bg.vz(spineSkinData, out text))
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x06000246 RID: 582 RVA: 0x0000B6CC File Offset: 0x000098CC
	public static void vx(SpineSkinSetting a)
	{
		if (bg.hir)
		{
			return;
		}
		bg.hir = true;
		bg.his = a;
		bj.hja += bg.wc;
	}

	// Token: 0x06000247 RID: 583 RVA: 0x0000B75C File Offset: 0x0000995C
	private static void wc(uint a)
	{
		if (bg.his == null || bg.his.SpineSkinDatas == null)
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < bg.his.SpineSkinDatas.Count; i++)
		{
			SpineSkinData spineSkinData = bg.his.SpineSkinDatas[i];
			string text;
			if (spineSkinData != null && spineSkinData.koy && spineSkinData.bjn() == a && bg.vz(spineSkinData, out text))
			{
				num++;
			}
		}
		if (num == 0)
		{
			return;
		}
		Debug.Log(string.Format(a.ki(), a, num));
		bg.his.bkm();
		bg.his.bkp();
	}

	// Token: 0x06000248 RID: 584 RVA: 0x0000B808 File Offset: 0x00009A08
	public static bool ixe(SpineSkinData a, out string b)
	{
		b = null;
		if (a == null)
		{
			b = a.kj();
			return false;
		}
		if (!a.koy)
		{
			b = a.kk();
			return false;
		}
		string text = bg.wa(a.type, a.name);
		string text2 = bg.wb(a.type, a.name);
		Texture2D texture2D;
		string text3;
		if (!bh.wf<Texture2D>(bk.hjd.BundleName, text, out texture2D, out text3))
		{
			b = a.kl() + text + a.km() + text3;
			return false;
		}
		Sprite sprite;
		string text4;
		if (!bh.wf<Sprite>(bk.hjd.BundleName, text2, out sprite, out text4))
		{
			b = a.kn() + text2 + a.ko() + text4;
			return false;
		}
		a.texture = texture2D;
		a.icon = sprite;
		return true;
	}

	// Token: 0x06000249 RID: 585 RVA: 0x0000B8C0 File Offset: 0x00009AC0
	public static bool nno(SpineSkinData a, out string b)
	{
		b = null;
		if (a == null)
		{
			b = a.kp();
			return false;
		}
		if (!a.koy)
		{
			b = a.kq();
			return false;
		}
		string text = bg.wa(a.type, a.name);
		string text2 = bg.wb(a.type, a.name);
		Texture2D texture2D;
		string text3;
		if (!bh.wf<Texture2D>(bk.hjd.BundleName, text, out texture2D, out text3))
		{
			b = a.kr() + text + a.ks() + text3;
			return false;
		}
		Sprite sprite;
		string text4;
		if (!bh.wf<Sprite>(bk.hjd.BundleName, text2, out sprite, out text4))
		{
			b = a.kt() + text2 + a.ku() + text4;
			return false;
		}
		a.texture = texture2D;
		a.icon = sprite;
		return true;
	}

	// Token: 0x0600024A RID: 586 RVA: 0x0000B6CC File Offset: 0x000098CC
	public static void bpd(SpineSkinSetting a)
	{
		if (bg.hir)
		{
			return;
		}
		bg.hir = true;
		bg.his = a;
		bj.hja += bg.wc;
	}

	// Token: 0x0600024B RID: 587 RVA: 0x0000B978 File Offset: 0x00009B78
	public static int ild(SpineSkinSetting a)
	{
		if (a == null || a.SpineSkinDatas == null)
		{
			return 0;
		}
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < a.SpineSkinDatas.Count; i++)
		{
			SpineSkinData spineSkinData = a.SpineSkinDatas[i];
			if (spineSkinData != null && spineSkinData.koy)
			{
				num2++;
				string text;
				if (bg.vz(spineSkinData, out text))
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x0600024C RID: 588 RVA: 0x0000B9E0 File Offset: 0x00009BE0
	public static string ilj(CLOTHE_TYPE a, CLOTHE_NAME b)
	{
		string text = a.ToString();
		int num = (int)b;
		string text2 = num.ToString(a.kv());
		return string.Concat(new string[]
		{
			a.kw(),
			text,
			a.kx(),
			text2,
			a.ky()
		});
	}

	// Token: 0x04000126 RID: 294
	private const string hiq = "Assets/SourceFiles/Bundle/AdultContent";

	// Token: 0x04000127 RID: 295
	private static bool hir;

	// Token: 0x04000128 RID: 296
	private static SpineSkinSetting his;
}
