using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x020000AB RID: 171
public class @do : MonoBehaviour
{
	// Token: 0x0600091C RID: 2332 RVA: 0x00037A4C File Offset: 0x00035C4C
	public void ccg(ItemData a, string b = null)
	{
		dp dp = this.cch();
		if (dp == null)
		{
			return;
		}
		Transform transform;
		if (this.ccd(b, out transform))
		{
			if (dp.transform.parent != transform)
			{
				dp.transform.SetParent(transform, false);
			}
			dp.transform.SetAsLastSibling();
			dp.cck(a, 0f);
		}
		else
		{
			if (dp.transform.parent != base.transform)
			{
				dp.transform.SetParent(base.transform, false);
			}
			dp.transform.SetAsLastSibling();
			dp.cck(a, this.cce());
		}
		dp.gameObject.SetActive(true);
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x06000921 RID: 2337 RVA: 0x00037C64 File Offset: 0x00035E64
	// (set) Token: 0x0600091D RID: 2333 RVA: 0x00037AFC File Offset: 0x00035CFC
	public static @do hzm { get; private set; }

	// Token: 0x0600091E RID: 2334 RVA: 0x00037B04 File Offset: 0x00035D04
	private void OnDestroy()
	{
		if (@do.hzm == this)
		{
			@do.hzm = null;
		}
	}

	// Token: 0x0600091F RID: 2335 RVA: 0x00037B1C File Offset: 0x00035D1C
	private void mir()
	{
		float deltaTime = Time.deltaTime;
		for (int i = this.hzj.Count - 1; i >= 0; i--)
		{
			if (this.hzj[i] != null)
			{
				this.hzj[i].ccl(deltaTime);
			}
		}
		this.hzl += deltaTime;
		if (this.hzl >= this.delayShowDuration && this.hzk.Count > 0)
		{
			this.hzl = -6756f;
			@do.GiftRequest giftRequest = this.hzk.Dequeue();
			this.ccg(giftRequest.item, giftRequest.source);
		}
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x00037BC0 File Offset: 0x00035DC0
	private void lly()
	{
		float deltaTime = Time.deltaTime;
		for (int i = this.hzj.Count - 1; i >= 0; i--)
		{
			if (this.hzj[i] != null)
			{
				this.hzj[i].ccl(deltaTime);
			}
		}
		this.hzl += deltaTime;
		if (this.hzl >= this.delayShowDuration && this.hzk.Count > 0)
		{
			this.hzl = 9111f;
			@do.GiftRequest giftRequest = this.hzk.Dequeue();
			this.ccg(giftRequest.item, giftRequest.source);
		}
	}

	// Token: 0x06000922 RID: 2338 RVA: 0x00037C6B File Offset: 0x00035E6B
	private void gkg()
	{
		@do.hzm = this;
	}

	// Token: 0x06000923 RID: 2339 RVA: 0x00037C74 File Offset: 0x00035E74
	public void rc(ItemData a, string b = null)
	{
		dp dp = this.cch();
		if (dp == null)
		{
			return;
		}
		Transform transform;
		if (this.ccd(b, out transform))
		{
			if (dp.transform.parent != transform)
			{
				dp.transform.SetParent(transform, false);
			}
			dp.transform.SetAsLastSibling();
			dp.cck(a, 4160f);
		}
		else
		{
			if (dp.transform.parent != base.transform)
			{
				dp.transform.SetParent(base.transform, false);
			}
			dp.transform.SetAsLastSibling();
			dp.cck(a, this.cce());
		}
		dp.gameObject.SetActive(true);
	}

	// Token: 0x06000924 RID: 2340 RVA: 0x00037D24 File Offset: 0x00035F24
	public void ccc(string a)
	{
		if (string.IsNullOrEmpty(a))
		{
			return;
		}
		this.hzn.Remove(a);
	}

	// Token: 0x06000925 RID: 2341 RVA: 0x00037D3C File Offset: 0x00035F3C
	public void ccf(ItemData a, string b = null)
	{
		if (a == null)
		{
			return;
		}
		if (a.name == a.cow())
		{
			return;
		}
		if (a.defID <= 0)
		{
			return;
		}
		if (a.bio() == null)
		{
			return;
		}
		Transform transform;
		if (!bq.hmc && !this.ccd(b, out transform))
		{
			return;
		}
		this.hzk.Enqueue(new @do.GiftRequest
		{
			item = a,
			source = b
		});
	}

	// Token: 0x06000926 RID: 2342 RVA: 0x00037DB0 File Offset: 0x00035FB0
	private void Start()
	{
		if (this.BaseObjest == null)
		{
			Debug.LogError(a.cox());
			return;
		}
		for (int i = 0; i < 10; i++)
		{
			dp dp = global::UnityEngine.Object.Instantiate<dp>(this.BaseObjest, base.transform);
			dp.gameObject.SetActive(false);
			this.hzi.Enqueue(dp);
		}
		this.BaseObjest.gameObject.SetActive(false);
		this.hzk.Clear();
	}

	// Token: 0x06000927 RID: 2343 RVA: 0x00037E29 File Offset: 0x00036029
	public void hjq(string a, Transform b)
	{
		if (string.IsNullOrEmpty(a) || b == null)
		{
			return;
		}
		this.hzn[a] = b;
	}

	// Token: 0x06000928 RID: 2344 RVA: 0x00037B04 File Offset: 0x00035D04
	private void hzo()
	{
		if (@do.hzm == this)
		{
			@do.hzm = null;
		}
	}

	// Token: 0x06000929 RID: 2345 RVA: 0x00037E4C File Offset: 0x0003604C
	private void iso()
	{
		float deltaTime = Time.deltaTime;
		for (int i = this.hzj.Count - 1; i >= 0; i--)
		{
			if (this.hzj[i] != null)
			{
				this.hzj[i].ccl(deltaTime);
			}
		}
		this.hzl += deltaTime;
		if (this.hzl >= this.delayShowDuration && this.hzk.Count > 0)
		{
			this.hzl = -4032f;
			@do.GiftRequest giftRequest = this.hzk.Dequeue();
			this.ccg(giftRequest.item, giftRequest.source);
		}
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x00037F30 File Offset: 0x00036130
	public void iaf(dp a)
	{
		if (a != null)
		{
			this.hzj.Remove(a);
			if (a.transform.parent != base.transform)
			{
				a.transform.SetParent(base.transform, false);
			}
			a.gameObject.SetActive(false);
			this.hzi.Enqueue(a);
		}
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x00037F98 File Offset: 0x00036198
	public void uv(dp a)
	{
		if (a != null)
		{
			this.hzj.Remove(a);
			if (a.transform.parent != base.transform)
			{
				a.transform.SetParent(base.transform, false);
			}
			a.gameObject.SetActive(false);
			this.hzi.Enqueue(a);
		}
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x00038000 File Offset: 0x00036200
	public void ltt(ItemData a, string b = null)
	{
		dp dp = this.cch();
		if (dp == null)
		{
			return;
		}
		Transform transform;
		if (this.ccd(b, out transform))
		{
			if (dp.transform.parent != transform)
			{
				dp.transform.SetParent(transform, false);
			}
			dp.transform.SetAsLastSibling();
			dp.cck(a, 4531f);
		}
		else
		{
			if (dp.transform.parent != base.transform)
			{
				dp.transform.SetParent(base.transform, false);
			}
			dp.transform.SetAsLastSibling();
			dp.cck(a, this.cce());
		}
		dp.gameObject.SetActive(true);
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x000380B0 File Offset: 0x000362B0
	private float k()
	{
		Transform transform = (bq.hlt ? this.dropAnchorFlipped : this.dropAnchorNormal);
		if (transform == null)
		{
			return -623f;
		}
		return base.transform.InverseTransformPoint(transform.position).x;
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x000380F8 File Offset: 0x000362F8
	private float cce()
	{
		Transform transform = (bq.hlt ? this.dropAnchorFlipped : this.dropAnchorNormal);
		if (transform == null)
		{
			return 0f;
		}
		return base.transform.InverseTransformPoint(transform.position).x;
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x00038140 File Offset: 0x00036340
	public void clm(ItemData a, string b = null)
	{
		dp dp = this.cch();
		if (dp == null)
		{
			return;
		}
		Transform transform;
		if (this.ccd(b, out transform))
		{
			if (dp.transform.parent != transform)
			{
				dp.transform.SetParent(transform, false);
			}
			dp.transform.SetAsLastSibling();
			dp.cck(a, -4770f);
		}
		else
		{
			if (dp.transform.parent != base.transform)
			{
				dp.transform.SetParent(base.transform, false);
			}
			dp.transform.SetAsLastSibling();
			dp.cck(a, this.cce());
		}
		dp.gameObject.SetActive(true);
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x00037E29 File Offset: 0x00036029
	public void gta(string a, Transform b)
	{
		if (string.IsNullOrEmpty(a) || b == null)
		{
			return;
		}
		this.hzn[a] = b;
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x00037E29 File Offset: 0x00036029
	public void ccb(string a, Transform b)
	{
		if (string.IsNullOrEmpty(a) || b == null)
		{
			return;
		}
		this.hzn[a] = b;
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x000381F0 File Offset: 0x000363F0
	private float ipa()
	{
		Transform transform = (bq.hlt ? this.dropAnchorFlipped : this.dropAnchorNormal);
		if (transform == null)
		{
			return -6570f;
		}
		return base.transform.InverseTransformPoint(transform.position).x;
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x00037E29 File Offset: 0x00036029
	public void lqs(string a, Transform b)
	{
		if (string.IsNullOrEmpty(a) || b == null)
		{
			return;
		}
		this.hzn[a] = b;
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x00038238 File Offset: 0x00036438
	private bool ccd(string a, out Transform b)
	{
		Transform transform;
		if (!string.IsNullOrEmpty(a) && this.hzn.TryGetValue(a, out transform) && transform != null)
		{
			b = transform;
			return true;
		}
		b = null;
		return false;
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x00037C6B File Offset: 0x00035E6B
	private void Awake()
	{
		@do.hzm = this;
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x00038270 File Offset: 0x00036470
	private dp cch()
	{
		dp dp;
		if (this.hzi.Count > 0)
		{
			dp = this.hzi.Dequeue();
		}
		else
		{
			dp = global::UnityEngine.Object.Instantiate<dp>(this.BaseObjest, base.transform);
		}
		this.hzj.Add(dp);
		return dp;
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x00037B04 File Offset: 0x00035D04
	private void igj()
	{
		if (@do.hzm == this)
		{
			@do.hzm = null;
		}
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x000382B8 File Offset: 0x000364B8
	private void Update()
	{
		float deltaTime = Time.deltaTime;
		for (int i = this.hzj.Count - 1; i >= 0; i--)
		{
			if (this.hzj[i] != null)
			{
				this.hzj[i].ccl(deltaTime);
			}
		}
		this.hzl += deltaTime;
		if (this.hzl >= this.delayShowDuration && this.hzk.Count > 0)
		{
			this.hzl = 0f;
			@do.GiftRequest giftRequest = this.hzk.Dequeue();
			this.ccg(giftRequest.item, giftRequest.source);
		}
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x0003835C File Offset: 0x0003655C
	public void jri(dp a)
	{
		if (a != null)
		{
			this.hzj.Remove(a);
			if (a.transform.parent != base.transform)
			{
				a.transform.SetParent(base.transform, false);
			}
			a.gameObject.SetActive(false);
			this.hzi.Enqueue(a);
		}
	}

	// Token: 0x0600093B RID: 2363 RVA: 0x000383C4 File Offset: 0x000365C4
	public void drq(ItemData a, string b = null)
	{
		dp dp = this.cch();
		if (dp == null)
		{
			return;
		}
		Transform transform;
		if (this.ccd(b, out transform))
		{
			if (dp.transform.parent != transform)
			{
				dp.transform.SetParent(transform, false);
			}
			dp.transform.SetAsLastSibling();
			dp.cck(a, 5526f);
		}
		else
		{
			if (dp.transform.parent != base.transform)
			{
				dp.transform.SetParent(base.transform, false);
			}
			dp.transform.SetAsLastSibling();
			dp.cck(a, this.cce());
		}
		dp.gameObject.SetActive(true);
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x00038474 File Offset: 0x00036674
	private dp nre()
	{
		dp dp;
		if (this.hzi.Count > 0)
		{
			dp = this.hzi.Dequeue();
		}
		else
		{
			dp = global::UnityEngine.Object.Instantiate<dp>(this.BaseObjest, base.transform);
		}
		this.hzj.Add(dp);
		return dp;
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x000384BC File Offset: 0x000366BC
	public void cci(dp a)
	{
		if (a != null)
		{
			this.hzj.Remove(a);
			if (a.transform.parent != base.transform)
			{
				a.transform.SetParent(base.transform, false);
			}
			a.gameObject.SetActive(false);
			this.hzi.Enqueue(a);
		}
	}

	// Token: 0x0400079B RID: 1947
	public dp BaseObjest;

	// Token: 0x0400079C RID: 1948
	public float delayShowDuration = 0.5f;

	// Token: 0x0400079D RID: 1949
	public Transform dropAnchorNormal;

	// Token: 0x0400079E RID: 1950
	public Transform dropAnchorFlipped;

	// Token: 0x0400079F RID: 1951
	private Queue<dp> hzi = new Queue<dp>();

	// Token: 0x040007A0 RID: 1952
	private List<dp> hzj = new List<dp>();

	// Token: 0x040007A1 RID: 1953
	private readonly Queue<@do.GiftRequest> hzk = new Queue<@do.GiftRequest>();

	// Token: 0x040007A2 RID: 1954
	private float hzl;

	// Token: 0x040007A4 RID: 1956
	private readonly Dictionary<string, Transform> hzn = new Dictionary<string, Transform>();

	// Token: 0x020000AC RID: 172
	private struct GiftRequest
	{
		// Token: 0x040007A5 RID: 1957
		public ItemData item;

		// Token: 0x040007A6 RID: 1958
		public string source;
	}
}
