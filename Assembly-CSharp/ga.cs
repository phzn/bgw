using System;
using System.Collections;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using BongoWaifu.Multiplayer;
using Steamworks;
using UnityEngine;

// Token: 0x02000123 RID: 291
public sealed class ga : MonoBehaviour
{
	// Token: 0x060014EE RID: 5358 RVA: 0x00067746 File Offset: 0x00065946
	private static void jwu()
	{
		PlayerPrefs.SetInt(a.edl(), 1);
		ga.dgi();
		fq.dbg(a.edm());
	}

	// Token: 0x060014EF RID: 5359 RVA: 0x00067762 File Offset: 0x00065962
	private static void dgl()
	{
		PlayerPrefs.DeleteKey(a.edn());
		PlayerPrefs.Save();
	}

	// Token: 0x060014F0 RID: 5360 RVA: 0x00067774 File Offset: 0x00065974
	private void bkr()
	{
		this.iua = fv.kts;
		if (this.iua != null)
		{
			this.iua.isn += this.dgc;
			this.iua.ism += this.dgd;
			this.iua.isp += this.dge;
			this.iub = true;
		}
		else
		{
			Debug.LogWarning(a.edo());
		}
		this.iud = base.StartCoroutine(this.dfw());
	}

	// Token: 0x060014F1 RID: 5361 RVA: 0x00067804 File Offset: 0x00065A04
	public void nad()
	{
		this.dga();
		ga.dgi();
		ga.dgl();
	}

	// Token: 0x060014F2 RID: 5362 RVA: 0x00067816 File Offset: 0x00065A16
	private static void dgk()
	{
		PlayerPrefs.SetInt(a.edn(), 1);
		ga.dgi();
		fq.dbg(a.edp());
	}

	// Token: 0x060014F3 RID: 5363 RVA: 0x00067834 File Offset: 0x00065A34
	public bool jot()
	{
		if (MultiplayerSession.ivj)
		{
			fq.dbg(a.edq());
			ga.dgi();
			return false;
		}
		if (this.iuc || !ga.kue || !ga.kug)
		{
			return false;
		}
		if (this.iua == null || !this.iua.ktv)
		{
			return false;
		}
		if (this.iue)
		{
			return true;
		}
		if (this.iuf)
		{
			this.iug = true;
			return true;
		}
		this.iue = true;
		if (this.iud != null)
		{
			base.StopCoroutine(this.iud);
		}
		this.iud = base.StartCoroutine(this.dfy());
		return true;
	}

	// Token: 0x060014F4 RID: 5364 RVA: 0x000678D8 File Offset: 0x00065AD8
	private void dga()
	{
		if (this.iud != null)
		{
			base.StopCoroutine(this.iud);
			this.iud = null;
		}
		object obj = this.iue || this.iuf;
		this.iue = false;
		this.iuf = false;
		this.iug = false;
		this.iuh = false;
		object obj2 = obj;
		if (obj2 != null && this.iua != null && this.iua.ktv && !MultiplayerSession.iuw)
		{
			this.iua.ddm();
		}
		if (obj2 != null)
		{
			this.dgb();
		}
	}

	// Token: 0x060014F5 RID: 5365 RVA: 0x00067965 File Offset: 0x00065B65
	private void dvn()
	{
		this.iuc = true;
		this.dga();
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x060014F7 RID: 5367 RVA: 0x00067992 File Offset: 0x00065B92
	// (set) Token: 0x060014F6 RID: 5366 RVA: 0x00067974 File Offset: 0x00065B74
	public static bool kuf
	{
		get
		{
			if (ga.iuk == null)
			{
				ga.iuk = new bool?(PlayerPrefs.GetInt(a.edr(), 0) == 1);
			}
			return ga.iuk.Value;
		}
		set
		{
			ga.iuk = new bool?(value);
			PlayerPrefs.SetInt(a.edr(), value ? 1 : 0);
		}
	}

	// Token: 0x060014F8 RID: 5368 RVA: 0x000679C2 File Offset: 0x00065BC2
	private void dgb()
	{
		Action action = this.iui;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x060014F9 RID: 5369 RVA: 0x000679D4 File Offset: 0x00065BD4
	private static void jxg(ulong lobby, ulong host)
	{
		PlayerPrefs.SetString(a.eds(), lobby.ToString());
		PlayerPrefs.SetString(a.edt(), host.ToString());
		ga.dgl();
		PlayerPrefs.Save();
		fq.dbg(string.Format(a.edu(), lobby, host));
	}

	// Token: 0x060014FA RID: 5370 RVA: 0x00067A28 File Offset: 0x00065C28
	private void met()
	{
		if (this.iud != null)
		{
			base.StopCoroutine(this.iud);
			this.iud = null;
		}
		object obj = this.iue || this.iuf;
		this.iue = false;
		this.iuf = false;
		this.iug = false;
		this.iuh = false;
		object obj2 = obj;
		if (obj2 != null && this.iua != null && this.iua.ktv && !MultiplayerSession.iuw)
		{
			this.iua.ddm();
		}
		if (obj2 != null)
		{
			this.dgb();
		}
	}

	// Token: 0x060014FB RID: 5371 RVA: 0x00067965 File Offset: 0x00065B65
	private void omq()
	{
		this.iuc = true;
		this.dga();
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x060014FC RID: 5372 RVA: 0x00067AB8 File Offset: 0x00065CB8
	private static ulong kuh
	{
		get
		{
			ulong num;
			if (!ulong.TryParse(PlayerPrefs.GetString(a.edv(), string.Empty), out num))
			{
				return 0UL;
			}
			return num;
		}
	}

	// Token: 0x060014FD RID: 5373 RVA: 0x00067AE1 File Offset: 0x00065CE1
	public void dfu()
	{
		MultiplayerSession.dhv();
		this.dga();
	}

	// Token: 0x060014FE RID: 5374 RVA: 0x00067AF0 File Offset: 0x00065CF0
	private void dfx()
	{
		if (!this.dgn())
		{
			return;
		}
		fp fp = fp.kto;
		if (fp == null)
		{
			return;
		}
		fq.dbg(a.edw());
		fp.daq();
	}

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x0600151E RID: 5406 RVA: 0x00068111 File Offset: 0x00066311
	// (set) Token: 0x060014FF RID: 5375 RVA: 0x00067B26 File Offset: 0x00065D26
	public static bool kue
	{
		get
		{
			if (ga.iuj == null)
			{
				ga.iuj = new bool?(PlayerPrefs.GetInt(a.edx(), 1) == 1);
			}
			return ga.iuj.Value;
		}
		set
		{
			ga.iuj = new bool?(value);
			PlayerPrefs.SetInt(a.edx(), value ? 1 : 0);
			if (!value)
			{
				ga ga = ga.itz;
				if (ga == null)
				{
					return;
				}
				ga.dga();
			}
		}
	}

	// Token: 0x06001500 RID: 5376 RVA: 0x00067B56 File Offset: 0x00065D56
	public void dft()
	{
		this.iuh = true;
	}

	// Token: 0x06001501 RID: 5377 RVA: 0x00067B5F File Offset: 0x00065D5F
	private IEnumerator dfy()
	{
		fp fp = fp.kto;
		this.dgb();
		int num = 0;
		while (num < ga.ity.Length && !this.iuc)
		{
			yield return new WaitForSecondsRealtime(ga.ity[num]);
			if (this.iuc || !ga.kue || MultiplayerSession.ivj || !ga.kug || this.iua == null || !this.iua.ktv)
			{
				break;
			}
			if (this.iua.ddo().m_SteamID != ga.kui)
			{
				fq.dbg(a.edh());
				break;
			}
			this.iuh = false;
			fp fp2 = fp;
			if (fp2 != null)
			{
				fp2.dat(default(CSteamID));
			}
			float num2 = 0f;
			while (num2 < 13f && !MultiplayerSession.iuw && !this.iuh && !this.iuc)
			{
				num2 += Time.unscaledDeltaTime;
				yield return null;
			}
			if (MultiplayerSession.iuw)
			{
				fq.dbg(string.Format(a.edi(), num + 1));
				this.iue = false;
				this.iud = null;
				this.dgb();
				yield break;
			}
			fq.dbg(string.Format(a.edj(), num + 1, this.iuh));
			int num3 = num;
			num = num3 + 1;
		}
		this.iue = false;
		this.iud = null;
		fq.dbg(a.edk());
		this.dfz();
		this.dgb();
		yield break;
	}

	// Token: 0x06001502 RID: 5378 RVA: 0x00067B6E File Offset: 0x00065D6E
	private void kcl()
	{
		if (ga.itz != null && ga.itz != this)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		ga.itz = this;
	}

	// Token: 0x06001503 RID: 5379 RVA: 0x00067B98 File Offset: 0x00065D98
	private void jrl()
	{
		if (!this.dgn())
		{
			return;
		}
		fp fp = fp.kto;
		if (fp == null)
		{
			return;
		}
		fq.dbg(a.edy());
		fp.daq();
	}

	// Token: 0x06001504 RID: 5380 RVA: 0x00067BD0 File Offset: 0x00065DD0
	private void Start()
	{
		this.iua = fv.kts;
		if (this.iua != null)
		{
			this.iua.isn += this.dgc;
			this.iua.ism += this.dgd;
			this.iua.isp += this.dge;
			this.iub = true;
		}
		else
		{
			Debug.LogWarning(a.edz());
		}
		this.iud = base.StartCoroutine(this.dfw());
	}

	// Token: 0x06001505 RID: 5381 RVA: 0x00067C60 File Offset: 0x00065E60
	private void lbj(CSteamID a)
	{
		if (this.iuf)
		{
			fq.dbg(string.Format(a.eea(), a.m_SteamID));
			this.iug = true;
		}
	}

	// Token: 0x06001506 RID: 5382 RVA: 0x00067C8B File Offset: 0x00065E8B
	private void dgd(CSteamID a)
	{
		ga.dgk();
	}

	// Token: 0x14000038 RID: 56
	// (add) Token: 0x06001507 RID: 5383 RVA: 0x00067C94 File Offset: 0x00065E94
	// (remove) Token: 0x06001518 RID: 5400 RVA: 0x00067F94 File Offset: 0x00066194
	public event Action iui;

	// Token: 0x06001508 RID: 5384 RVA: 0x00067CCC File Offset: 0x00065ECC
	private void dvm()
	{
		if (!this.dgn())
		{
			return;
		}
		fp fp = fp.kto;
		if (fp == null)
		{
			return;
		}
		fq.dbg(a.eeb());
		fp.daq();
	}

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x06001509 RID: 5385 RVA: 0x00067D02 File Offset: 0x00065F02
	public bool kuc
	{
		get
		{
			return this.iue;
		}
	}

	// Token: 0x0600150A RID: 5386 RVA: 0x00067D0A File Offset: 0x00065F0A
	private IEnumerator dfw()
	{
		while (!SteamManager.krd && !this.iuc)
		{
			yield return null;
		}
		if (this.iuc)
		{
			yield break;
		}
		yield return new WaitForSecondsRealtime(2f);
		if (this.iuc)
		{
			this.iud = null;
			yield break;
		}
		if (!this.dgm())
		{
			this.iud = null;
			this.dfx();
			yield break;
		}
		fp fp = fp.kto;
		if (fp == null)
		{
			this.iud = null;
			yield break;
		}
		this.iuf = true;
		this.iug = false;
		this.dgb();
		fq.dbg(string.Format(a.ede(), ga.kuh, ga.kui));
		fp.das(new CSteamID(ga.kuh));
		float num = 0f;
		while (num < 13f && !MultiplayerSession.iuw && !this.iug && !this.iuc)
		{
			num += Time.unscaledDeltaTime;
			yield return null;
		}
		bool flag = MultiplayerSession.iuw;
		this.iuf = false;
		this.iud = null;
		if (flag)
		{
			fq.dbg(a.edf());
		}
		else
		{
			fq.dbg(string.Format(a.edg(), this.iug));
			this.dfz();
		}
		this.dgb();
		yield break;
	}

	// Token: 0x0600150B RID: 5387 RVA: 0x00067D1C File Offset: 0x00065F1C
	private static void Save(ulong lobby, ulong host)
	{
		PlayerPrefs.SetString(a.edv(), lobby.ToString());
		PlayerPrefs.SetString(a.eec(), host.ToString());
		ga.dgl();
		PlayerPrefs.Save();
		fq.dbg(string.Format(a.eed(), lobby, host));
	}

	// Token: 0x0600150C RID: 5388 RVA: 0x000679C2 File Offset: 0x00065BC2
	private void ksq()
	{
		Action action = this.iui;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x17000121 RID: 289
	// (get) Token: 0x0600150D RID: 5389 RVA: 0x00067D70 File Offset: 0x00065F70
	private static bool kuj
	{
		get
		{
			return PlayerPrefs.GetInt(a.edn(), 0) == 1;
		}
	}

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x0600150E RID: 5390 RVA: 0x00067D80 File Offset: 0x00065F80
	private static ulong kui
	{
		get
		{
			ulong num;
			if (!ulong.TryParse(PlayerPrefs.GetString(a.eec(), string.Empty), out num))
			{
				return 0UL;
			}
			return num;
		}
	}

	// Token: 0x0600150F RID: 5391 RVA: 0x00067DA9 File Offset: 0x00065FA9
	private void dfz()
	{
		ga.dgi();
		if (this.iua != null && this.iua.ktv)
		{
			this.iua.ddm();
		}
	}

	// Token: 0x06001510 RID: 5392 RVA: 0x00067DD8 File Offset: 0x00065FD8
	private bool dgm()
	{
		return ga.kue && ga.kug && !MultiplayerSession.ivj && !MultiplayerSession.iuw && (this.iua == null || !this.iua.ktv) && !this.iue && !this.iuf;
	}

	// Token: 0x06001511 RID: 5393 RVA: 0x00067E30 File Offset: 0x00066030
	private bool dgn()
	{
		return ga.kuf && ga.kuj && !MultiplayerSession.ivj && !MultiplayerSession.iuw && (this.iua == null || !this.iua.ktv) && !this.iue && !this.iuf;
	}

	// Token: 0x06001512 RID: 5394 RVA: 0x00067E88 File Offset: 0x00066088
	private void he()
	{
		this.iua = fv.kts;
		if (this.iua != null)
		{
			this.iua.isn += this.dgc;
			this.iua.ism += this.dgd;
			this.iua.isp += this.dge;
			this.iub = true;
		}
		else
		{
			Debug.LogWarning(a.eee());
		}
		this.iud = base.StartCoroutine(this.dfw());
	}

	// Token: 0x06001513 RID: 5395 RVA: 0x00067804 File Offset: 0x00065A04
	public void ext()
	{
		this.dga();
		ga.dgi();
		ga.dgl();
	}

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x06001514 RID: 5396 RVA: 0x00067F18 File Offset: 0x00066118
	public static ga kub
	{
		get
		{
			return ga.itz;
		}
	}

	// Token: 0x06001515 RID: 5397 RVA: 0x00067804 File Offset: 0x00065A04
	public void dfv()
	{
		this.dga();
		ga.dgi();
		ga.dgl();
	}

	// Token: 0x06001516 RID: 5398 RVA: 0x00067F1F File Offset: 0x0006611F
	private static void dgi()
	{
		PlayerPrefs.DeleteKey(a.edv());
		PlayerPrefs.DeleteKey(a.eec());
		PlayerPrefs.Save();
	}

	// Token: 0x06001517 RID: 5399 RVA: 0x00067F3C File Offset: 0x0006613C
	private bool mpi()
	{
		return ga.kuf && ga.kuj && !MultiplayerSession.ivj && !MultiplayerSession.iuw && (this.iua == null || !this.iua.ktv) && !this.iue && !this.iuf;
	}

	// Token: 0x06001519 RID: 5401 RVA: 0x00067FC9 File Offset: 0x000661C9
	private void dge(CSteamID a)
	{
		if (this.iuf)
		{
			fq.dbg(string.Format(a.eef(), a.m_SteamID));
			this.iug = true;
		}
	}

	// Token: 0x0600151A RID: 5402 RVA: 0x00067FF4 File Offset: 0x000661F4
	private void kk()
	{
		this.iua = fv.kts;
		if (this.iua != null)
		{
			this.iua.isn += this.dgc;
			this.iua.ism += this.dgd;
			this.iua.isp += this.dge;
			this.iub = true;
		}
		else
		{
			Debug.LogWarning(a.eeg());
		}
		this.iud = base.StartCoroutine(this.dfw());
	}

	// Token: 0x0600151B RID: 5403 RVA: 0x00068084 File Offset: 0x00066284
	private void OnDestroy()
	{
		if (this.iub && this.iua != null)
		{
			this.iua.isn -= this.dgc;
			this.iua.ism -= this.dgd;
			this.iua.isp -= this.dge;
		}
		if (ga.itz == this)
		{
			ga.itz = null;
		}
	}

	// Token: 0x0600151C RID: 5404 RVA: 0x00067B6E File Offset: 0x00065D6E
	private void bdv()
	{
		if (ga.itz != null && ga.itz != this)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		ga.itz = this;
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x0600151D RID: 5405 RVA: 0x000680FF File Offset: 0x000662FF
	public bool kud
	{
		get
		{
			return this.iue || this.iuf;
		}
	}

	// Token: 0x0600151F RID: 5407 RVA: 0x00068144 File Offset: 0x00066344
	public bool cve()
	{
		if (MultiplayerSession.ivj)
		{
			fq.dbg(a.eeh());
			ga.dgi();
			return false;
		}
		if (this.iuc || !ga.kue || !ga.kug)
		{
			return false;
		}
		if (this.iua == null || !this.iua.ktv)
		{
			return false;
		}
		if (this.iue)
		{
			return true;
		}
		if (this.iuf)
		{
			this.iug = true;
			return true;
		}
		this.iue = true;
		if (this.iud != null)
		{
			base.StopCoroutine(this.iud);
		}
		this.iud = base.StartCoroutine(this.dfy());
		return true;
	}

	// Token: 0x06001520 RID: 5408 RVA: 0x00067B56 File Offset: 0x00065D56
	public void gsd()
	{
		this.iuh = true;
	}

	// Token: 0x06001522 RID: 5410 RVA: 0x00067B6E File Offset: 0x00065D6E
	private void ork()
	{
		if (ga.itz != null && ga.itz != this)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		ga.itz = this;
	}

	// Token: 0x06001523 RID: 5411 RVA: 0x00067804 File Offset: 0x00065A04
	public void odo()
	{
		this.dga();
		ga.dgi();
		ga.dgl();
	}

	// Token: 0x06001524 RID: 5412 RVA: 0x000681E8 File Offset: 0x000663E8
	private void dgc(CSteamID a, CSteamID b)
	{
		MultiplayerSession.dhv();
		if (this.iua != null && this.iua.ktw)
		{
			ga.dgi();
			return;
		}
		ulong num = (SteamManager.krd ? SteamUser.GetSteamID().m_SteamID : 0UL);
		if (!this.iuf)
		{
			if (b.IsValid() && b.m_SteamID != 0UL && b.m_SteamID != num)
			{
				ga.Save(a.m_SteamID, b.m_SteamID);
			}
			return;
		}
		ulong num2 = ga.kui;
		ulong num3 = ((this.iua != null) ? this.iua.ddo().m_SteamID : 0UL);
		if (num3 != num2)
		{
			fq.dbg(string.Format(a.eei(), num3, num2));
			this.iug = true;
			return;
		}
		if (!b.IsValid() && num2 != 0UL)
		{
			fp fp = fp.kto;
			if (fp == null)
			{
				return;
			}
			fp.dat(new CSteamID(num2));
		}
	}

	// Token: 0x06001525 RID: 5413 RVA: 0x00067AE1 File Offset: 0x00065CE1
	public void bpt()
	{
		MultiplayerSession.dhv();
		this.dga();
	}

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x06001526 RID: 5414 RVA: 0x000682D9 File Offset: 0x000664D9
	private static bool kug
	{
		get
		{
			return ga.kuh != 0UL && ga.kui > 0UL;
		}
	}

	// Token: 0x06001527 RID: 5415 RVA: 0x000682F0 File Offset: 0x000664F0
	public bool dfs()
	{
		if (MultiplayerSession.ivj)
		{
			fq.dbg(a.eej());
			ga.dgi();
			return false;
		}
		if (this.iuc || !ga.kue || !ga.kug)
		{
			return false;
		}
		if (this.iua == null || !this.iua.ktv)
		{
			return false;
		}
		if (this.iue)
		{
			return true;
		}
		if (this.iuf)
		{
			this.iug = true;
			return true;
		}
		this.iue = true;
		if (this.iud != null)
		{
			base.StopCoroutine(this.iud);
		}
		this.iud = base.StartCoroutine(this.dfy());
		return true;
	}

	// Token: 0x06001529 RID: 5417 RVA: 0x000679C2 File Offset: 0x00065BC2
	private void eag()
	{
		Action action = this.iui;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x0600152A RID: 5418 RVA: 0x000683AC File Offset: 0x000665AC
	private bool mzo()
	{
		return ga.kuf && ga.kuj && !MultiplayerSession.ivj && !MultiplayerSession.iuw && (this.iua == null || !this.iua.ktv) && !this.iue && !this.iuf;
	}

	// Token: 0x0600152B RID: 5419 RVA: 0x00068404 File Offset: 0x00066604
	private bool irg()
	{
		return ga.kuf && ga.kuj && !MultiplayerSession.ivj && !MultiplayerSession.iuw && (this.iua == null || !this.iua.ktv) && !this.iue && !this.iuf;
	}

	// Token: 0x0600152C RID: 5420 RVA: 0x00067DA9 File Offset: 0x00065FA9
	private void mcy()
	{
		ga.dgi();
		if (this.iua != null && this.iua.ktv)
		{
			this.iua.ddm();
		}
	}

	// Token: 0x0600152D RID: 5421 RVA: 0x00067B6E File Offset: 0x00065D6E
	private void fga()
	{
		if (ga.itz != null && ga.itz != this)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		ga.itz = this;
	}

	// Token: 0x0600152E RID: 5422 RVA: 0x0006845B File Offset: 0x0006665B
	private void lva(CSteamID a)
	{
		if (this.iuf)
		{
			fq.dbg(string.Format(a.eek(), a.m_SteamID));
			this.iug = true;
		}
	}

	// Token: 0x0600152F RID: 5423 RVA: 0x00067965 File Offset: 0x00065B65
	private void OnApplicationQuit()
	{
		this.iuc = true;
		this.dga();
	}

	// Token: 0x06001530 RID: 5424 RVA: 0x00067B6E File Offset: 0x00065D6E
	private void Awake()
	{
		if (ga.itz != null && ga.itz != this)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		ga.itz = this;
	}

	// Token: 0x06001531 RID: 5425 RVA: 0x00068488 File Offset: 0x00066688
	private bool lfx()
	{
		return ga.kuf && ga.kuj && !MultiplayerSession.ivj && !MultiplayerSession.iuw && (this.iua == null || !this.iua.ktv) && !this.iue && !this.iuf;
	}

	// Token: 0x06001532 RID: 5426 RVA: 0x00067B56 File Offset: 0x00065D56
	public void mmy()
	{
		this.iuh = true;
	}

	// Token: 0x06001533 RID: 5427 RVA: 0x000684E0 File Offset: 0x000666E0
	private void kwr()
	{
		if (!this.dgn())
		{
			return;
		}
		fp fp = fp.kto;
		if (fp == null)
		{
			return;
		}
		fq.dbg(a.eel());
		fp.daq();
	}

	// Token: 0x06001534 RID: 5428 RVA: 0x00068518 File Offset: 0x00066718
	private void iig()
	{
		this.iua = fv.kts;
		if (this.iua != null)
		{
			this.iua.isn += this.dgc;
			this.iua.ism += this.dgd;
			this.iua.isp += this.dge;
			this.iub = true;
		}
		else
		{
			Debug.LogWarning(a.eem());
		}
		this.iud = base.StartCoroutine(this.dfw());
	}

	// Token: 0x04000ABC RID: 2748
	public const string PrefKeyAutoRejoin = "Settings_MpAutoRejoin";

	// Token: 0x04000ABD RID: 2749
	private const string itt = "mp_last_lobby";

	// Token: 0x04000ABE RID: 2750
	private const string itu = "mp_last_host";

	// Token: 0x04000ABF RID: 2751
	public const string PrefKeyAutoHost = "Settings_MpAutoHost";

	// Token: 0x04000AC0 RID: 2752
	private const string itv = "mp_was_host";

	// Token: 0x04000AC1 RID: 2753
	private const float itw = 2f;

	// Token: 0x04000AC2 RID: 2754
	private const float itx = 13f;

	// Token: 0x04000AC3 RID: 2755
	private static readonly float[] ity = new float[] { 2f, 4f, 8f };

	// Token: 0x04000AC4 RID: 2756
	private static ga itz;

	// Token: 0x04000AC5 RID: 2757
	private fv iua;

	// Token: 0x04000AC6 RID: 2758
	private bool iub;

	// Token: 0x04000AC7 RID: 2759
	private bool iuc;

	// Token: 0x04000AC8 RID: 2760
	private Coroutine iud;

	// Token: 0x04000AC9 RID: 2761
	private bool iue;

	// Token: 0x04000ACA RID: 2762
	private bool iuf;

	// Token: 0x04000ACB RID: 2763
	private bool iug;

	// Token: 0x04000ACC RID: 2764
	private bool iuh;

	// Token: 0x04000ACE RID: 2766
	private static bool? iuj;

	// Token: 0x04000ACF RID: 2767
	private static bool? iuk;
}
