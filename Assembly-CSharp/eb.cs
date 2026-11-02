using System;
using System.Collections.Generic;
using System.IO;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x020000CD RID: 205
public class eb : MonoBehaviour
{
	// Token: 0x06000A88 RID: 2696 RVA: 0x0003DD14 File Offset: 0x0003BF14
	private void cwt(string a)
	{
		string fullPath = Path.GetFullPath(a);
		if (this.ido.Contains(fullPath))
		{
			return;
		}
		if (!File.Exists(Path.Combine(a, a.cyn())))
		{
			return;
		}
		string text;
		CatCharacterDefinition catCharacterDefinition = ea.chh(a, out text);
		if (catCharacterDefinition != null)
		{
			this.idm.Add(catCharacterDefinition);
			this.ido.Add(fullPath);
			return;
		}
		Debug.LogWarning(a.cyo() + a + a.cyp() + text);
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0003DD8C File Offset: 0x0003BF8C
	public IReadOnlyList<CatCharacterDefinition> krl
	{
		get
		{
			return this.idn;
		}
	}

	// Token: 0x06000A8A RID: 2698 RVA: 0x0003DD94 File Offset: 0x0003BF94
	private void jzz()
	{
		string text = eb.krn;
		if (!Directory.Exists(text))
		{
			Debug.Log(a.cyq() + text);
			Directory.CreateDirectory(text);
			return;
		}
		foreach (string text2 in Directory.GetDirectories(text))
		{
			this.chx(text2);
		}
	}

	// Token: 0x06000A8B RID: 2699 RVA: 0x0003DDE7 File Offset: 0x0003BFE7
	private void nmw()
	{
		if (eg.krr != null)
		{
			eg.krr.iem += this.chy;
		}
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0003DE0C File Offset: 0x0003C00C
	private static string krn
	{
		get
		{
			return Path.Combine(Application.persistentDataPath, a.cyr());
		}
	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x0003DE20 File Offset: 0x0003C020
	private void myz()
	{
		string text = eb.krn;
		if (!Directory.Exists(text))
		{
			Debug.Log(a.cys() + text);
			Directory.CreateDirectory(text);
			return;
		}
		foreach (string text2 in Directory.GetDirectories(text))
		{
			this.chx(text2);
		}
	}

	// Token: 0x06000A8E RID: 2702 RVA: 0x0003DE74 File Offset: 0x0003C074
	public void chs()
	{
		if (eg.krr != null)
		{
			eg.krr.iem -= this.chy;
			eg.krr.iem += this.chy;
		}
		this.cht();
	}

	// Token: 0x06000A8F RID: 2703 RVA: 0x0003DEC0 File Offset: 0x0003C0C0
	private void OnDisable()
	{
		if (eg.krr != null)
		{
			eg.krr.iem -= this.chy;
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0003E62A File Offset: 0x0003C82A
	// (set) Token: 0x06000A90 RID: 2704 RVA: 0x0003DEE5 File Offset: 0x0003C0E5
	public int idp { get; private set; }

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0003DEEE File Offset: 0x0003C0EE
	public static eb krm
	{
		get
		{
			return eb.idq;
		}
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x0003DEC0 File Offset: 0x0003C0C0
	private void huj()
	{
		if (eg.krr != null)
		{
			eg.krr.iem -= this.chy;
		}
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x0003DEF5 File Offset: 0x0003C0F5
	private void Awake()
	{
		if (eb.idq != null && eb.idq != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		eb.idq = this;
	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x0003DEF5 File Offset: 0x0003C0F5
	private void ekz()
	{
		if (eb.idq != null && eb.idq != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		eb.idq = this;
	}

	// Token: 0x06000A95 RID: 2709 RVA: 0x0003DF24 File Offset: 0x0003C124
	private void chz()
	{
		this.idn.Clear();
		foreach (CatCharacterDefinition catCharacterDefinition in this.builtInCharacters)
		{
			if (catCharacterDefinition != null)
			{
				this.idn.Add(catCharacterDefinition);
			}
		}
		this.idp = this.idn.Count;
		foreach (CatCharacterDefinition catCharacterDefinition2 in this.idm)
		{
			if (catCharacterDefinition2 != null)
			{
				this.idn.Add(catCharacterDefinition2);
			}
		}
	}

	// Token: 0x06000A96 RID: 2710 RVA: 0x0003DFF4 File Offset: 0x0003C1F4
	private void fnx()
	{
		string text = eb.krn;
		if (!Directory.Exists(text))
		{
			Debug.Log(a.cyt() + text);
			Directory.CreateDirectory(text);
			return;
		}
		foreach (string text2 in Directory.GetDirectories(text))
		{
			this.chx(text2);
		}
	}

	// Token: 0x06000A97 RID: 2711 RVA: 0x0003E047 File Offset: 0x0003C247
	private void chy()
	{
		Debug.Log(a.cyu());
		this.cht();
		if (bl.kmv != null)
		{
			bl.kmv.xw();
		}
	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x0003DDE7 File Offset: 0x0003BFE7
	private void OnEnable()
	{
		if (eg.krr != null)
		{
			eg.krr.iem += this.chy;
		}
	}

	// Token: 0x06000A99 RID: 2713 RVA: 0x0003DEF5 File Offset: 0x0003C0F5
	private void jkl()
	{
		if (eb.idq != null && eb.idq != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		eb.idq = this;
	}

	// Token: 0x06000A9A RID: 2714 RVA: 0x0003E070 File Offset: 0x0003C270
	private void chw()
	{
		this.idl = 0;
		if (eg.krr == null)
		{
			return;
		}
		if (!SteamManager.krd)
		{
			return;
		}
		List<string> list = eg.krr.ciz();
		this.idl = list.Count;
		foreach (string text in list)
		{
			this.chx(text);
		}
	}

	// Token: 0x06000A9C RID: 2716 RVA: 0x0003DDE7 File Offset: 0x0003BFE7
	private void mpr()
	{
		if (eg.krr != null)
		{
			eg.krr.iem += this.chy;
		}
	}

	// Token: 0x06000A9D RID: 2717 RVA: 0x0003E128 File Offset: 0x0003C328
	private void chx(string a)
	{
		string fullPath = Path.GetFullPath(a);
		if (this.ido.Contains(fullPath))
		{
			return;
		}
		if (!File.Exists(Path.Combine(a, a.cxy())))
		{
			return;
		}
		string text;
		CatCharacterDefinition catCharacterDefinition = ea.chh(a, out text);
		if (catCharacterDefinition != null)
		{
			this.idm.Add(catCharacterDefinition);
			this.ido.Add(fullPath);
			return;
		}
		Debug.LogWarning(a.cyv() + a + a.cyw() + text);
	}

	// Token: 0x06000A9E RID: 2718 RVA: 0x0003E1A0 File Offset: 0x0003C3A0
	private void mxk(string a)
	{
		string fullPath = Path.GetFullPath(a);
		if (this.ido.Contains(fullPath))
		{
			return;
		}
		if (!File.Exists(Path.Combine(a, a.cyx())))
		{
			return;
		}
		string text;
		CatCharacterDefinition catCharacterDefinition = ea.chh(a, out text);
		if (catCharacterDefinition != null)
		{
			this.idm.Add(catCharacterDefinition);
			this.ido.Add(fullPath);
			return;
		}
		Debug.LogWarning(a.cyy() + a + a.cyz() + text);
	}

	// Token: 0x06000A9F RID: 2719 RVA: 0x0003E218 File Offset: 0x0003C418
	private void ewp(string a)
	{
		string fullPath = Path.GetFullPath(a);
		if (this.ido.Contains(fullPath))
		{
			return;
		}
		if (!File.Exists(Path.Combine(a, a.cza())))
		{
			return;
		}
		string text;
		CatCharacterDefinition catCharacterDefinition = ea.chh(a, out text);
		if (catCharacterDefinition != null)
		{
			this.idm.Add(catCharacterDefinition);
			this.ido.Add(fullPath);
			return;
		}
		Debug.LogWarning(a.czb() + a + a.czc() + text);
	}

	// Token: 0x06000AA0 RID: 2720 RVA: 0x0003E290 File Offset: 0x0003C490
	public void onw()
	{
		if (eg.krr != null)
		{
			eg.krr.iem -= this.chy;
			eg.krr.iem += this.chy;
		}
		this.cht();
	}

	// Token: 0x06000AA1 RID: 2721 RVA: 0x0003E2DC File Offset: 0x0003C4DC
	private void chv()
	{
		string text = eb.krn;
		if (!Directory.Exists(text))
		{
			Debug.Log(a.czd() + text);
			Directory.CreateDirectory(text);
			return;
		}
		foreach (string text2 in Directory.GetDirectories(text))
		{
			this.chx(text2);
		}
	}

	// Token: 0x06000AA2 RID: 2722 RVA: 0x0003DEC0 File Offset: 0x0003C0C0
	private void mau()
	{
		if (eg.krr != null)
		{
			eg.krr.iem -= this.chy;
		}
	}

	// Token: 0x06000AA3 RID: 2723 RVA: 0x0003E330 File Offset: 0x0003C530
	public void ccj()
	{
		if (eg.krr != null)
		{
			eg.krr.iem -= this.chy;
			eg.krr.iem += this.chy;
		}
		this.cht();
	}

	// Token: 0x06000AA4 RID: 2724 RVA: 0x0003E37C File Offset: 0x0003C57C
	private void chu()
	{
		foreach (CatCharacterDefinition catCharacterDefinition in this.idm)
		{
			if (catCharacterDefinition != null)
			{
				global::UnityEngine.Object.Destroy(catCharacterDefinition);
			}
		}
		this.idm.Clear();
		this.ido.Clear();
		this.chv();
		this.chw();
		this.idk = this.idm.Count;
		Debug.Log(string.Format(a.cze(), this.idk) + string.Format(a.czf(), this.idl));
	}

	// Token: 0x06000AA5 RID: 2725 RVA: 0x0003E440 File Offset: 0x0003C640
	private void gwy()
	{
		foreach (CatCharacterDefinition catCharacterDefinition in this.idm)
		{
			if (catCharacterDefinition != null)
			{
				global::UnityEngine.Object.Destroy(catCharacterDefinition);
			}
		}
		this.idm.Clear();
		this.ido.Clear();
		this.chv();
		this.chw();
		this.idk = this.idm.Count;
		Debug.Log(string.Format(a.czg(), this.idk) + string.Format(a.czh(), this.idl));
	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x0003DDE7 File Offset: 0x0003BFE7
	private void ewu()
	{
		if (eg.krr != null)
		{
			eg.krr.iem += this.chy;
		}
	}

	// Token: 0x06000AA7 RID: 2727 RVA: 0x0003E504 File Offset: 0x0003C704
	public void khh()
	{
		if (eg.krr != null)
		{
			eg.krr.iem -= this.chy;
			eg.krr.iem += this.chy;
		}
		this.cht();
	}

	// Token: 0x06000AA8 RID: 2728 RVA: 0x0003DEF5 File Offset: 0x0003C0F5
	private void dem()
	{
		if (eb.idq != null && eb.idq != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		eb.idq = this;
	}

	// Token: 0x06000AA9 RID: 2729 RVA: 0x0003E550 File Offset: 0x0003C750
	private void dzr()
	{
		string text = eb.krn;
		if (!Directory.Exists(text))
		{
			Debug.Log(a.czi() + text);
			Directory.CreateDirectory(text);
			return;
		}
		foreach (string text2 in Directory.GetDirectories(text))
		{
			this.chx(text2);
		}
	}

	// Token: 0x06000AAA RID: 2730 RVA: 0x0003E5A4 File Offset: 0x0003C7A4
	private void jet(string a)
	{
		string fullPath = Path.GetFullPath(a);
		if (this.ido.Contains(fullPath))
		{
			return;
		}
		if (!File.Exists(Path.Combine(a, a.czj())))
		{
			return;
		}
		string text;
		CatCharacterDefinition catCharacterDefinition = ea.chh(a, out text);
		if (catCharacterDefinition != null)
		{
			this.idm.Add(catCharacterDefinition);
			this.ido.Add(fullPath);
			return;
		}
		Debug.LogWarning(a.czk() + a + a.czl() + text);
	}

	// Token: 0x06000AAB RID: 2731 RVA: 0x0003E61C File Offset: 0x0003C81C
	public void cht()
	{
		this.chu();
		this.chz();
	}

	// Token: 0x06000AAC RID: 2732 RVA: 0x0003DEF5 File Offset: 0x0003C0F5
	private void cni()
	{
		if (eb.idq != null && eb.idq != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		eb.idq = this;
	}

	// Token: 0x0400085A RID: 2138
	public List<CatCharacterDefinition> builtInCharacters = new List<CatCharacterDefinition>();

	// Token: 0x0400085B RID: 2139
	private int idk;

	// Token: 0x0400085C RID: 2140
	private int idl;

	// Token: 0x0400085D RID: 2141
	private readonly List<CatCharacterDefinition> idm = new List<CatCharacterDefinition>();

	// Token: 0x0400085E RID: 2142
	private readonly List<CatCharacterDefinition> idn = new List<CatCharacterDefinition>();

	// Token: 0x0400085F RID: 2143
	private readonly HashSet<string> ido = new HashSet<string>();

	// Token: 0x04000861 RID: 2145
	private static eb idq;
}
