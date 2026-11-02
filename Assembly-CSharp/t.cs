using System;
using System.Collections;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x0200001C RID: 28
public class t : MonoBehaviour
{
	// Token: 0x0600016B RID: 363 RVA: 0x00008A2C File Offset: 0x00006C2C
	private void kkt()
	{
		if (this.dotObject == null)
		{
			return;
		}
		if (this.kmm)
		{
			this.ux();
			return;
		}
		this.dotObject.SetActive(!this.hhr);
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00008A60 File Offset: 0x00006C60
	private void mci()
	{
		if (this.stateDriven)
		{
			return;
		}
		if (string.IsNullOrEmpty(this.dotId))
		{
			Debug.LogError(a.je() + base.name + a.jf());
			return;
		}
		List<string> list = bq.hlf.playerSaveData.dismissedDots;
		if (list == null)
		{
			list = new List<string>();
			bq.hlf.playerSaveData.dismissedDots = list;
		}
		if (this.hhr && !list.Contains(this.dotId))
		{
			list.Add(this.dotId);
		}
		else if (!this.hhr && list.Contains(this.dotId))
		{
			list.Remove(this.dotId);
		}
		ci.Save(null);
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00008B14 File Offset: 0x00006D14
	public void ccv(t a)
	{
		if (a == null)
		{
			return;
		}
		if (this.hhq.Remove(a))
		{
			this.ux();
		}
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00008B34 File Offset: 0x00006D34
	public void ux()
	{
		if (!this.kmm)
		{
			return;
		}
		if (this.dotObject == null)
		{
			return;
		}
		this.dotObject.SetActive(this.uv());
	}

	// Token: 0x0600016F RID: 367 RVA: 0x00008B5F File Offset: 0x00006D5F
	private void cdu()
	{
		if (this.hhs != null)
		{
			base.StopCoroutine(this.hhs);
			this.hhs = null;
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000170 RID: 368 RVA: 0x00008B7C File Offset: 0x00006D7C
	public bool kml
	{
		get
		{
			return this.hhr;
		}
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00008B84 File Offset: 0x00006D84
	private void up()
	{
		if (this.stateDriven)
		{
			return;
		}
		this.uz();
		this.uy();
		if (this.parentDot != null)
		{
			this.parentDot.ux();
		}
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00008BB4 File Offset: 0x00006DB4
	public void ur()
	{
		if (this.stateDriven)
		{
			return;
		}
		this.hhr = false;
		this.va();
		this.uy();
		if (this.parentDot != null)
		{
			this.parentDot.ux();
		}
	}

	// Token: 0x06000173 RID: 371 RVA: 0x00008BEB File Offset: 0x00006DEB
	public void gcs()
	{
		if (this.stateDriven)
		{
			return;
		}
		if (this.hhr)
		{
			return;
		}
		this.hhr = true;
		this.va();
		this.uy();
		if (this.parentDot != null)
		{
			this.parentDot.ux();
		}
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00008C2B File Offset: 0x00006E2B
	public void dhj(t a)
	{
		if (a == null)
		{
			return;
		}
		if (this.hhq.Contains(a))
		{
			return;
		}
		this.hhq.Add(a);
		this.ux();
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00008C58 File Offset: 0x00006E58
	private void fcv()
	{
		if (this.parentDot != null)
		{
			this.parentDot.uu(this);
		}
	}

	// Token: 0x06000176 RID: 374 RVA: 0x00008C74 File Offset: 0x00006E74
	private static bool cjl(t a, List<string> b)
	{
		return !(a == null) && (b == null || !b.Contains(a.dotId));
	}

	// Token: 0x06000177 RID: 375 RVA: 0x00008B14 File Offset: 0x00006D14
	public void uu(t a)
	{
		if (a == null)
		{
			return;
		}
		if (this.hhq.Remove(a))
		{
			this.ux();
		}
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00008B5F File Offset: 0x00006D5F
	private void blz()
	{
		if (this.hhs != null)
		{
			base.StopCoroutine(this.hhs);
			this.hhs = null;
		}
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00008B34 File Offset: 0x00006D34
	public void glx()
	{
		if (!this.kmm)
		{
			return;
		}
		if (this.dotObject == null)
		{
			return;
		}
		this.dotObject.SetActive(this.uv());
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00008C95 File Offset: 0x00006E95
	private void bx()
	{
		if (this.stateDriven)
		{
			return;
		}
		if (bq.hlf == null)
		{
			this.hhs = base.StartCoroutine(this.uo());
			return;
		}
		this.up();
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00008A2C File Offset: 0x00006C2C
	private void uy()
	{
		if (this.dotObject == null)
		{
			return;
		}
		if (this.kmm)
		{
			this.ux();
			return;
		}
		this.dotObject.SetActive(!this.hhr);
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00008C2B File Offset: 0x00006E2B
	public void lus(t a)
	{
		if (a == null)
		{
			return;
		}
		if (this.hhq.Contains(a))
		{
			return;
		}
		this.hhq.Add(a);
		this.ux();
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00008CC8 File Offset: 0x00006EC8
	private void va()
	{
		if (this.stateDriven)
		{
			return;
		}
		if (string.IsNullOrEmpty(this.dotId))
		{
			Debug.LogError(a.jg() + base.name + a.jh());
			return;
		}
		List<string> list = bq.hlf.playerSaveData.dismissedDots;
		if (list == null)
		{
			list = new List<string>();
			bq.hlf.playerSaveData.dismissedDots = list;
		}
		if (this.hhr && !list.Contains(this.dotId))
		{
			list.Add(this.dotId);
		}
		else if (!this.hhr && list.Contains(this.dotId))
		{
			list.Remove(this.dotId);
		}
		ci.Save(null);
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00008D7C File Offset: 0x00006F7C
	public bool dmw()
	{
		if (bq.hlf == null)
		{
			return false;
		}
		List<string> dismissedDots = bq.hlf.playerSaveData.dismissedDots;
		if (this.childDots != null)
		{
			for (int i = 0; i < this.childDots.Count; i++)
			{
				if (t.uw(this.childDots[i], dismissedDots))
				{
					return true;
				}
			}
		}
		for (int j = 0; j < this.hhq.Count; j++)
		{
			if (t.uw(this.hhq[j], dismissedDots))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00008E0C File Offset: 0x0000700C
	private void fat()
	{
		List<string> dismissedDots = bq.hlf.playerSaveData.dismissedDots;
		this.hhr = dismissedDots != null && dismissedDots.Contains(this.dotId);
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00008B5F File Offset: 0x00006D5F
	private void OnDisable()
	{
		if (this.hhs != null)
		{
			base.StopCoroutine(this.hhs);
			this.hhs = null;
		}
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00008E44 File Offset: 0x00007044
	private void uz()
	{
		List<string> dismissedDots = bq.hlf.playerSaveData.dismissedDots;
		this.hhr = dismissedDots != null && dismissedDots.Contains(this.dotId);
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00008E79 File Offset: 0x00007079
	public void nkp()
	{
		if (this.stateDriven)
		{
			return;
		}
		if (bq.hlf == null)
		{
			return;
		}
		this.up();
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00008C58 File Offset: 0x00006E58
	private void ncc()
	{
		if (this.parentDot != null)
		{
			this.parentDot.uu(this);
		}
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00008BEB File Offset: 0x00006DEB
	public void mup()
	{
		if (this.stateDriven)
		{
			return;
		}
		if (this.hhr)
		{
			return;
		}
		this.hhr = true;
		this.va();
		this.uy();
		if (this.parentDot != null)
		{
			this.parentDot.ux();
		}
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00008B5F File Offset: 0x00006D5F
	private void lg()
	{
		if (this.hhs != null)
		{
			base.StopCoroutine(this.hhs);
			this.hhs = null;
		}
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00008EB6 File Offset: 0x000070B6
	public void un(bool a)
	{
		if (this.dotObject == null)
		{
			return;
		}
		this.dotObject.SetActive(a);
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00008ED3 File Offset: 0x000070D3
	private IEnumerator uo()
	{
		while (bq.hlf == null)
		{
			yield return null;
		}
		this.hhs = null;
		this.up();
		yield break;
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00008EE4 File Offset: 0x000070E4
	public bool njf()
	{
		if (bq.hlf == null)
		{
			return false;
		}
		List<string> dismissedDots = bq.hlf.playerSaveData.dismissedDots;
		if (this.childDots != null)
		{
			for (int i = 0; i < this.childDots.Count; i++)
			{
				if (t.uw(this.childDots[i], dismissedDots))
				{
					return true;
				}
			}
		}
		for (int j = 0; j < this.hhq.Count; j++)
		{
			if (t.uw(this.hhq[j], dismissedDots))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00008B84 File Offset: 0x00006D84
	private void kwm()
	{
		if (this.stateDriven)
		{
			return;
		}
		this.uz();
		this.uy();
		if (this.parentDot != null)
		{
			this.parentDot.ux();
		}
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00008EB6 File Offset: 0x000070B6
	public void pt(bool a)
	{
		if (this.dotObject == null)
		{
			return;
		}
		this.dotObject.SetActive(a);
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00008E79 File Offset: 0x00007079
	public void us()
	{
		if (this.stateDriven)
		{
			return;
		}
		if (bq.hlf == null)
		{
			return;
		}
		this.up();
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00008BEB File Offset: 0x00006DEB
	public void uq()
	{
		if (this.stateDriven)
		{
			return;
		}
		if (this.hhr)
		{
			return;
		}
		this.hhr = true;
		this.va();
		this.uy();
		if (this.parentDot != null)
		{
			this.parentDot.ux();
		}
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00008C2B File Offset: 0x00006E2B
	public void kmq(t a)
	{
		if (a == null)
		{
			return;
		}
		if (this.hhq.Contains(a))
		{
			return;
		}
		this.hhq.Add(a);
		this.ux();
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00008EB6 File Offset: 0x000070B6
	public void cyz(bool a)
	{
		if (this.dotObject == null)
		{
			return;
		}
		this.dotObject.SetActive(a);
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00008B14 File Offset: 0x00006D14
	public void ghf(t a)
	{
		if (a == null)
		{
			return;
		}
		if (this.hhq.Remove(a))
		{
			this.ux();
		}
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00008C74 File Offset: 0x00006E74
	private static bool fwh(t a, List<string> b)
	{
		return !(a == null) && (b == null || !b.Contains(a.dotId));
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00008C58 File Offset: 0x00006E58
	private void OnDestroy()
	{
		if (this.parentDot != null)
		{
			this.parentDot.uu(this);
		}
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00008C2B File Offset: 0x00006E2B
	public void llc(t a)
	{
		if (a == null)
		{
			return;
		}
		if (this.hhq.Contains(a))
		{
			return;
		}
		this.hhq.Add(a);
		this.ux();
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00008F74 File Offset: 0x00007174
	private void fhi()
	{
		if (this.stateDriven)
		{
			return;
		}
		if (string.IsNullOrEmpty(this.dotId))
		{
			Debug.LogError(a.ji() + base.name + a.jj());
			return;
		}
		List<string> list = bq.hlf.playerSaveData.dismissedDots;
		if (list == null)
		{
			list = new List<string>();
			bq.hlf.playerSaveData.dismissedDots = list;
		}
		if (this.hhr && !list.Contains(this.dotId))
		{
			list.Add(this.dotId);
		}
		else if (!this.hhr && list.Contains(this.dotId))
		{
			list.Remove(this.dotId);
		}
		ci.Save(null);
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00008A2C File Offset: 0x00006C2C
	private void xa()
	{
		if (this.dotObject == null)
		{
			return;
		}
		if (this.kmm)
		{
			this.ux();
			return;
		}
		this.dotObject.SetActive(!this.hhr);
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00008C58 File Offset: 0x00006E58
	private void fwq()
	{
		if (this.parentDot != null)
		{
			this.parentDot.uu(this);
		}
	}

	// Token: 0x06000197 RID: 407 RVA: 0x00008B84 File Offset: 0x00006D84
	private void nhl()
	{
		if (this.stateDriven)
		{
			return;
		}
		this.uz();
		this.uy();
		if (this.parentDot != null)
		{
			this.parentDot.ux();
		}
	}

	// Token: 0x06000198 RID: 408 RVA: 0x00008C95 File Offset: 0x00006E95
	private void OnEnable()
	{
		if (this.stateDriven)
		{
			return;
		}
		if (bq.hlf == null)
		{
			this.hhs = base.StartCoroutine(this.uo());
			return;
		}
		this.up();
	}

	// Token: 0x06000199 RID: 409 RVA: 0x00008B84 File Offset: 0x00006D84
	private void lmg()
	{
		if (this.stateDriven)
		{
			return;
		}
		this.uz();
		this.uy();
		if (this.parentDot != null)
		{
			this.parentDot.ux();
		}
	}

	// Token: 0x0600019A RID: 410 RVA: 0x00008C2B File Offset: 0x00006E2B
	public void ut(t a)
	{
		if (a == null)
		{
			return;
		}
		if (this.hhq.Contains(a))
		{
			return;
		}
		this.hhq.Add(a);
		this.ux();
	}

	// Token: 0x0600019B RID: 411 RVA: 0x00008C74 File Offset: 0x00006E74
	private static bool cbb(t a, List<string> b)
	{
		return !(a == null) && (b == null || !b.Contains(a.dotId));
	}

	// Token: 0x0600019C RID: 412 RVA: 0x00008B34 File Offset: 0x00006D34
	public void ksc()
	{
		if (!this.kmm)
		{
			return;
		}
		if (this.dotObject == null)
		{
			return;
		}
		this.dotObject.SetActive(this.uv());
	}

	// Token: 0x0600019D RID: 413 RVA: 0x00009028 File Offset: 0x00007228
	private void bis()
	{
		List<string> dismissedDots = bq.hlf.playerSaveData.dismissedDots;
		this.hhr = dismissedDots != null && dismissedDots.Contains(this.dotId);
	}

	// Token: 0x0600019E RID: 414 RVA: 0x00008B34 File Offset: 0x00006D34
	public void pd()
	{
		if (!this.kmm)
		{
			return;
		}
		if (this.dotObject == null)
		{
			return;
		}
		this.dotObject.SetActive(this.uv());
	}

	// Token: 0x0600019F RID: 415 RVA: 0x00009060 File Offset: 0x00007260
	public bool ftn()
	{
		if (bq.hlf == null)
		{
			return false;
		}
		List<string> dismissedDots = bq.hlf.playerSaveData.dismissedDots;
		if (this.childDots != null)
		{
			for (int i = 0; i < this.childDots.Count; i++)
			{
				if (t.uw(this.childDots[i], dismissedDots))
				{
					return true;
				}
			}
		}
		for (int j = 0; j < this.hhq.Count; j++)
		{
			if (t.uw(this.hhq[j], dismissedDots))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00008C58 File Offset: 0x00006E58
	private void dnm()
	{
		if (this.parentDot != null)
		{
			this.parentDot.uu(this);
		}
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x00008C74 File Offset: 0x00006E74
	private static bool uw(t a, List<string> b)
	{
		return !(a == null) && (b == null || !b.Contains(a.dotId));
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x060001A2 RID: 418 RVA: 0x000090ED File Offset: 0x000072ED
	private bool kmm
	{
		get
		{
			return (this.childDots != null && this.childDots.Count > 0) || this.hhq.Count > 0;
		}
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x00008EB6 File Offset: 0x000070B6
	public void lnl(bool a)
	{
		if (this.dotObject == null)
		{
			return;
		}
		this.dotObject.SetActive(a);
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x00009118 File Offset: 0x00007318
	public bool uv()
	{
		if (bq.hlf == null)
		{
			return false;
		}
		List<string> dismissedDots = bq.hlf.playerSaveData.dismissedDots;
		if (this.childDots != null)
		{
			for (int i = 0; i < this.childDots.Count; i++)
			{
				if (t.uw(this.childDots[i], dismissedDots))
				{
					return true;
				}
			}
		}
		for (int j = 0; j < this.hhq.Count; j++)
		{
			if (t.uw(this.hhq[j], dismissedDots))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x000091A8 File Offset: 0x000073A8
	private void ljb()
	{
		if (this.stateDriven)
		{
			return;
		}
		if (string.IsNullOrEmpty(this.dotId))
		{
			Debug.LogError(a.jk() + base.name + a.jl());
			return;
		}
		List<string> list = bq.hlf.playerSaveData.dismissedDots;
		if (list == null)
		{
			list = new List<string>();
			bq.hlf.playerSaveData.dismissedDots = list;
		}
		if (this.hhr && !list.Contains(this.dotId))
		{
			list.Add(this.dotId);
		}
		else if (!this.hhr && list.Contains(this.dotId))
		{
			list.Remove(this.dotId);
		}
		ci.Save(null);
	}

	// Token: 0x040000F0 RID: 240
	public string dotId;

	// Token: 0x040000F1 RID: 241
	public GameObject dotObject;

	// Token: 0x040000F2 RID: 242
	public t parentDot;

	// Token: 0x040000F3 RID: 243
	public List<t> childDots = new List<t>();

	// Token: 0x040000F4 RID: 244
	public bool stateDriven;

	// Token: 0x040000F5 RID: 245
	[NonSerialized]
	private readonly List<t> hhq = new List<t>();

	// Token: 0x040000F6 RID: 246
	private bool hhr;

	// Token: 0x040000F7 RID: 247
	private Coroutine hhs;
}
