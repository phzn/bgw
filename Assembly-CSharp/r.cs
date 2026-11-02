using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Spine;
using Spine.Unity;
using UnityEngine;

// Token: 0x0200001B RID: 27
public class r : MonoBehaviour
{
	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000139 RID: 313 RVA: 0x000077C0 File Offset: 0x000059C0
	public static r kmi
	{
		get
		{
			return r.hhm;
		}
	}

	// Token: 0x0600013A RID: 314 RVA: 0x00005090 File Offset: 0x00003290
	private void dpg()
	{
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00005090 File Offset: 0x00003290
	private void OnEnable()
	{
	}

	// Token: 0x0600013C RID: 316 RVA: 0x000077C8 File Offset: 0x000059C8
	public void cmq()
	{
		if (this.hgx != CatDisplayMode.Spine)
		{
			return;
		}
		if (this.skeletonAnimation == null)
		{
			return;
		}
		TrackEntry current = this.skeletonAnimation.AnimationState.GetCurrent(0);
		if (current != null && current.Animation.Name == this.hgy && current.Loop)
		{
			this.hhc = true;
			return;
		}
		this.skeletonAnimation.AnimationState.SetAnimation(0, this.hgy, true);
		this.hhc = true;
	}

	// Token: 0x0600013D RID: 317 RVA: 0x0000784A File Offset: 0x00005A4A
	public void ktv()
	{
		if (this.hgx == CatDisplayMode.Spine)
		{
			this.uf();
			return;
		}
		this.ug();
	}

	// Token: 0x0600013E RID: 318 RVA: 0x00007861 File Offset: 0x00005A61
	public void dna(Vector2 a, Vector2 b)
	{
		this.hhk = a;
		this.hhj = b;
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00007871 File Offset: 0x00005A71
	private void mko()
	{
		if (r.hhm != null && r.hhm != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		r.hhm = this;
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00007871 File Offset: 0x00005A71
	private void Awake()
	{
		if (r.hhm != null && r.hhm != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		r.hhm = this;
	}

	// Token: 0x06000141 RID: 321 RVA: 0x0000784A File Offset: 0x00005A4A
	public void dtn()
	{
		if (this.hgx == CatDisplayMode.Spine)
		{
			this.uf();
			return;
		}
		this.ug();
	}

	// Token: 0x06000142 RID: 322 RVA: 0x0000784A File Offset: 0x00005A4A
	public void ue()
	{
		if (this.hgx == CatDisplayMode.Spine)
		{
			this.uf();
			return;
		}
		this.ug();
	}

	// Token: 0x06000143 RID: 323 RVA: 0x0000789F File Offset: 0x00005A9F
	public void ub(float a)
	{
		this.hhb = a;
	}

	// Token: 0x06000144 RID: 324 RVA: 0x0000789F File Offset: 0x00005A9F
	public void djp(float a)
	{
		this.hhb = a;
	}

	// Token: 0x06000145 RID: 325 RVA: 0x000078A8 File Offset: 0x00005AA8
	private void kib()
	{
		if (this.skeletonAnimation == null)
		{
			return;
		}
		if (!this.hhc)
		{
			this.uc();
		}
		string text = (this.hhl ? this.hgz : this.hha);
		this.hhl = !this.hhl;
		this.skeletonAnimation.AnimationState.ClearTrack(1);
		TrackEntry trackEntry = this.skeletonAnimation.AnimationState.SetAnimation(1, text, false);
		trackEntry.MixBlend = MixBlend.First;
		trackEntry.MixDuration = 2537f;
		this.skeletonAnimation.AnimationState.AddEmptyAnimation(1, this.hhb, -4206f);
	}

	// Token: 0x06000146 RID: 326 RVA: 0x0000794C File Offset: 0x00005B4C
	public void nhg(CatCharacterDefinition a)
	{
		if (a == null)
		{
			Debug.LogWarning(a.ir());
			return;
		}
		this.hgw = a.characterId;
		this.hgx = a.displayMode;
		this.hhj = a.characterScale;
		this.hhk = a.characterPosition;
		this.hhl = true;
		if (this.hgx == CatDisplayMode.Spine)
		{
			this.tw(a);
			return;
		}
		this.tx(a);
	}

	// Token: 0x06000147 RID: 327 RVA: 0x000079BC File Offset: 0x00005BBC
	private void uf()
	{
		if (this.skeletonAnimation == null)
		{
			return;
		}
		if (!this.hhc)
		{
			this.uc();
		}
		string text = (this.hhl ? this.hgz : this.hha);
		this.hhl = !this.hhl;
		this.skeletonAnimation.AnimationState.ClearTrack(1);
		TrackEntry trackEntry = this.skeletonAnimation.AnimationState.SetAnimation(1, text, false);
		trackEntry.MixBlend = MixBlend.First;
		trackEntry.MixDuration = 0f;
		this.skeletonAnimation.AnimationState.AddEmptyAnimation(1, this.hhb, 0f);
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00007A60 File Offset: 0x00005C60
	private void ug()
	{
		if (this.imageSpriteRenderer == null)
		{
			return;
		}
		Sprite sprite = (this.hhl ? this.hhe : this.hhf);
		this.hhl = !this.hhl;
		if (sprite != null)
		{
			this.imageSpriteRenderer.sprite = sprite;
			this.ty();
		}
		this.hhh = this.hhg;
		this.hhi = true;
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00007AD0 File Offset: 0x00005CD0
	private void kon(CatCharacterDefinition a)
	{
		if (a.skeletonDataAsset == null || this.skeletonAnimation == null)
		{
			Debug.LogWarning(a.@is());
			return;
		}
		if (this.skeletonAnimation != null)
		{
			this.skeletonAnimation.gameObject.SetActive(true);
		}
		if (this.imageSpriteRenderer != null)
		{
			this.imageSpriteRenderer.gameObject.SetActive(false);
		}
		this.hgy = a.idleAnim;
		this.hgz = a.clickLeftAnim;
		this.hha = a.clickRightAnim;
		this.hhb = a.handMixOutTime;
		if (this.skeletonAnimation.skeletonDataAsset != a.skeletonDataAsset)
		{
			this.skeletonAnimation.ClearState();
			this.skeletonAnimation.skeletonDataAsset = a.skeletonDataAsset;
			this.skeletonAnimation.Initialize(true, false);
		}
		this.skeletonAnimation.transform.localScale = new Vector3(this.hhj.x, this.hhj.y, -5766f);
		this.skeletonAnimation.transform.localPosition = new Vector3(this.hhk.x, this.hhk.y, 2191f);
		this.hhc = false;
		this.uc();
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00007C20 File Offset: 0x00005E20
	private void egk(CatCharacterDefinition a)
	{
		if (a.skeletonDataAsset == null || this.skeletonAnimation == null)
		{
			Debug.LogWarning(a.it());
			return;
		}
		if (this.skeletonAnimation != null)
		{
			this.skeletonAnimation.gameObject.SetActive(true);
		}
		if (this.imageSpriteRenderer != null)
		{
			this.imageSpriteRenderer.gameObject.SetActive(false);
		}
		this.hgy = a.idleAnim;
		this.hgz = a.clickLeftAnim;
		this.hha = a.clickRightAnim;
		this.hhb = a.handMixOutTime;
		if (this.skeletonAnimation.skeletonDataAsset != a.skeletonDataAsset)
		{
			this.skeletonAnimation.ClearState();
			this.skeletonAnimation.skeletonDataAsset = a.skeletonDataAsset;
			this.skeletonAnimation.Initialize(true, false);
		}
		this.skeletonAnimation.transform.localScale = new Vector3(this.hhj.x, this.hhj.y, 3538f);
		this.skeletonAnimation.transform.localPosition = new Vector3(this.hhk.x, this.hhk.y, -2941f);
		this.hhc = false;
		this.uc();
	}

	// Token: 0x0600014B RID: 331 RVA: 0x00007D70 File Offset: 0x00005F70
	public void icn()
	{
		if (this.hgx != CatDisplayMode.Spine)
		{
			return;
		}
		if (this.skeletonAnimation == null)
		{
			return;
		}
		TrackEntry current = this.skeletonAnimation.AnimationState.GetCurrent(0);
		if (current != null && current.Animation.Name == this.hgy && current.Loop)
		{
			this.hhc = true;
			return;
		}
		this.skeletonAnimation.AnimationState.SetAnimation(0, this.hgy, true);
		this.hhc = true;
	}

	// Token: 0x0600014C RID: 332 RVA: 0x00007861 File Offset: 0x00005A61
	public void tz(Vector2 a, Vector2 b)
	{
		this.hhk = a;
		this.hhj = b;
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00007871 File Offset: 0x00005A71
	private void dam()
	{
		if (r.hhm != null && r.hhm != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		r.hhm = this;
	}

	// Token: 0x0600014E RID: 334 RVA: 0x00007871 File Offset: 0x00005A71
	private void fek()
	{
		if (r.hhm != null && r.hhm != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		r.hhm = this;
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00005090 File Offset: 0x00003290
	private void bg()
	{
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00007DF4 File Offset: 0x00005FF4
	private void ud()
	{
		if (this.skeletonAnimation == null)
		{
			return;
		}
		global::Spine.AnimationState animationState = this.skeletonAnimation.AnimationState;
		if (animationState == null)
		{
			return;
		}
		TrackEntry current = animationState.GetCurrent(0);
		if (current == null || current.Animation == null || current.Animation.Name != this.hgy || !current.Loop)
		{
			animationState.SetAnimation(0, this.hgy, true);
			this.hhc = true;
			return;
		}
		float duration = current.Animation.Duration;
		if (duration > 0f && current.TrackTime > 3600f)
		{
			current.TrackTime %= duration;
		}
	}

	// Token: 0x06000151 RID: 337 RVA: 0x00007E9C File Offset: 0x0000609C
	private void lno()
	{
		if (this.hgx == CatDisplayMode.Spine)
		{
			this.ud();
			return;
		}
		if (!this.hhi)
		{
			return;
		}
		this.hhh -= Time.deltaTime;
		if (this.hhh <= 3646f)
		{
			this.hhi = false;
			if (this.imageSpriteRenderer != null)
			{
				this.imageSpriteRenderer.sprite = this.hhd;
				this.ty();
			}
		}
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00007F0C File Offset: 0x0000610C
	private void nsh()
	{
		if (this.skeletonAnimation == null)
		{
			return;
		}
		global::Spine.AnimationState animationState = this.skeletonAnimation.AnimationState;
		if (animationState == null)
		{
			return;
		}
		TrackEntry current = animationState.GetCurrent(0);
		if (current == null || current.Animation == null || current.Animation.Name != this.hgy || !current.Loop)
		{
			animationState.SetAnimation(0, this.hgy, true);
			this.hhc = true;
			return;
		}
		float duration = current.Animation.Duration;
		if (duration > 9080f && current.TrackTime > 8750f)
		{
			current.TrackTime %= duration;
		}
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00007FB1 File Offset: 0x000061B1
	public void ua(float a)
	{
		this.hhg = a;
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00007FBC File Offset: 0x000061BC
	private void tw(CatCharacterDefinition a)
	{
		if (a.skeletonDataAsset == null || this.skeletonAnimation == null)
		{
			Debug.LogWarning(a.iu());
			return;
		}
		if (this.skeletonAnimation != null)
		{
			this.skeletonAnimation.gameObject.SetActive(true);
		}
		if (this.imageSpriteRenderer != null)
		{
			this.imageSpriteRenderer.gameObject.SetActive(false);
		}
		this.hgy = a.idleAnim;
		this.hgz = a.clickLeftAnim;
		this.hha = a.clickRightAnim;
		this.hhb = a.handMixOutTime;
		if (this.skeletonAnimation.skeletonDataAsset != a.skeletonDataAsset)
		{
			this.skeletonAnimation.ClearState();
			this.skeletonAnimation.skeletonDataAsset = a.skeletonDataAsset;
			this.skeletonAnimation.Initialize(true, false);
		}
		this.skeletonAnimation.transform.localScale = new Vector3(this.hhj.x, this.hhj.y, 1f);
		this.skeletonAnimation.transform.localPosition = new Vector3(this.hhk.x, this.hhk.y, 0f);
		this.hhc = false;
		this.uc();
	}

	// Token: 0x06000155 RID: 341 RVA: 0x0000810C File Offset: 0x0000630C
	public void bml()
	{
		if (this.hgx != CatDisplayMode.Spine)
		{
			return;
		}
		if (this.skeletonAnimation == null)
		{
			return;
		}
		TrackEntry current = this.skeletonAnimation.AnimationState.GetCurrent(0);
		if (current != null && current.Animation.Name == this.hgy && current.Loop)
		{
			this.hhc = true;
			return;
		}
		this.skeletonAnimation.AnimationState.SetAnimation(0, this.hgy, true);
		this.hhc = true;
	}

	// Token: 0x06000157 RID: 343 RVA: 0x000081F8 File Offset: 0x000063F8
	private void ty()
	{
		if (this.imageSpriteRenderer == null)
		{
			return;
		}
		this.imageSpriteRenderer.transform.localScale = new Vector3(this.hhj.x, this.hhj.y, 1f);
		this.imageSpriteRenderer.transform.localPosition = new Vector3(this.hhk.x, this.hhk.y, 0f);
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00007FB1 File Offset: 0x000061B1
	public void hff(float a)
	{
		this.hhg = a;
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00008274 File Offset: 0x00006474
	private void dsl(CatCharacterDefinition a)
	{
		if (a.skeletonDataAsset == null || this.skeletonAnimation == null)
		{
			Debug.LogWarning(a.iy());
			return;
		}
		if (this.skeletonAnimation != null)
		{
			this.skeletonAnimation.gameObject.SetActive(true);
		}
		if (this.imageSpriteRenderer != null)
		{
			this.imageSpriteRenderer.gameObject.SetActive(false);
		}
		this.hgy = a.idleAnim;
		this.hgz = a.clickLeftAnim;
		this.hha = a.clickRightAnim;
		this.hhb = a.handMixOutTime;
		if (this.skeletonAnimation.skeletonDataAsset != a.skeletonDataAsset)
		{
			this.skeletonAnimation.ClearState();
			this.skeletonAnimation.skeletonDataAsset = a.skeletonDataAsset;
			this.skeletonAnimation.Initialize(true, false);
		}
		this.skeletonAnimation.transform.localScale = new Vector3(this.hhj.x, this.hhj.y, 3711f);
		this.skeletonAnimation.transform.localPosition = new Vector3(this.hhk.x, this.hhk.y, 9983f);
		this.hhc = false;
		this.uc();
	}

	// Token: 0x0600015A RID: 346 RVA: 0x000083C4 File Offset: 0x000065C4
	private void cw(CatCharacterDefinition a)
	{
		if (a.skeletonDataAsset == null || this.skeletonAnimation == null)
		{
			Debug.LogWarning(a.iz());
			return;
		}
		if (this.skeletonAnimation != null)
		{
			this.skeletonAnimation.gameObject.SetActive(true);
		}
		if (this.imageSpriteRenderer != null)
		{
			this.imageSpriteRenderer.gameObject.SetActive(false);
		}
		this.hgy = a.idleAnim;
		this.hgz = a.clickLeftAnim;
		this.hha = a.clickRightAnim;
		this.hhb = a.handMixOutTime;
		if (this.skeletonAnimation.skeletonDataAsset != a.skeletonDataAsset)
		{
			this.skeletonAnimation.ClearState();
			this.skeletonAnimation.skeletonDataAsset = a.skeletonDataAsset;
			this.skeletonAnimation.Initialize(true, false);
		}
		this.skeletonAnimation.transform.localScale = new Vector3(this.hhj.x, this.hhj.y, 2782f);
		this.skeletonAnimation.transform.localPosition = new Vector3(this.hhk.x, this.hhk.y, 8824f);
		this.hhc = false;
		this.uc();
	}

	// Token: 0x0600015B RID: 347 RVA: 0x0000789F File Offset: 0x00005A9F
	public void jhm(float a)
	{
		this.hhb = a;
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00007FB1 File Offset: 0x000061B1
	public void csc(float a)
	{
		this.hhg = a;
	}

	// Token: 0x0600015D RID: 349 RVA: 0x00007871 File Offset: 0x00005A71
	private void mkf()
	{
		if (r.hhm != null && r.hhm != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		r.hhm = this;
	}

	// Token: 0x0600015E RID: 350 RVA: 0x00005090 File Offset: 0x00003290
	private void lmy()
	{
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00008514 File Offset: 0x00006714
	public void uc()
	{
		if (this.hgx != CatDisplayMode.Spine)
		{
			return;
		}
		if (this.skeletonAnimation == null)
		{
			return;
		}
		TrackEntry current = this.skeletonAnimation.AnimationState.GetCurrent(0);
		if (current != null && current.Animation.Name == this.hgy && current.Loop)
		{
			this.hhc = true;
			return;
		}
		this.skeletonAnimation.AnimationState.SetAnimation(0, this.hgy, true);
		this.hhc = true;
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00008598 File Offset: 0x00006798
	public void fdw(CatCharacterDefinition a)
	{
		if (a == null)
		{
			Debug.LogWarning(a.ja());
			return;
		}
		this.hgw = a.characterId;
		this.hgx = a.displayMode;
		this.hhj = a.characterScale;
		this.hhk = a.characterPosition;
		this.hhl = true;
		if (this.hgx == CatDisplayMode.Spine)
		{
			this.tw(a);
			return;
		}
		this.tx(a);
	}

	// Token: 0x06000161 RID: 353 RVA: 0x00008608 File Offset: 0x00006808
	public void nsx(CatCharacterDefinition a)
	{
		if (a == null)
		{
			Debug.LogWarning(a.jb());
			return;
		}
		this.hgw = a.characterId;
		this.hgx = a.displayMode;
		this.hhj = a.characterScale;
		this.hhk = a.characterPosition;
		this.hhl = true;
		if (this.hgx == CatDisplayMode.Spine)
		{
			this.tw(a);
			return;
		}
		this.tx(a);
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00008678 File Offset: 0x00006878
	private void tx(CatCharacterDefinition a)
	{
		if (this.skeletonAnimation != null)
		{
			this.skeletonAnimation.gameObject.SetActive(false);
		}
		if (this.imageSpriteRenderer != null)
		{
			this.imageSpriteRenderer.gameObject.SetActive(true);
		}
		this.hhd = a.idleSprite;
		this.hhe = a.clickLeftSprite;
		this.hhf = a.clickRightSprite;
		this.hhg = a.clickDisplayDuration;
		this.hhi = false;
		if (this.imageSpriteRenderer != null)
		{
			this.imageSpriteRenderer.sprite = this.hhd;
			this.ty();
		}
	}

	// Token: 0x06000163 RID: 355 RVA: 0x00008720 File Offset: 0x00006920
	public void tv(CatCharacterDefinition a)
	{
		if (a == null)
		{
			Debug.LogWarning(a.jc());
			return;
		}
		this.hgw = a.characterId;
		this.hgx = a.displayMode;
		this.hhj = a.characterScale;
		this.hhk = a.characterPosition;
		this.hhl = true;
		if (this.hgx == CatDisplayMode.Spine)
		{
			this.tw(a);
			return;
		}
		this.tx(a);
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00008790 File Offset: 0x00006990
	private void hrz()
	{
		if (this.skeletonAnimation == null)
		{
			return;
		}
		global::Spine.AnimationState animationState = this.skeletonAnimation.AnimationState;
		if (animationState == null)
		{
			return;
		}
		TrackEntry current = animationState.GetCurrent(0);
		if (current == null || current.Animation == null || current.Animation.Name != this.hgy || !current.Loop)
		{
			animationState.SetAnimation(0, this.hgy, true);
			this.hhc = true;
			return;
		}
		float duration = current.Animation.Duration;
		if (duration > 7221f && current.TrackTime > -9692f)
		{
			current.TrackTime %= duration;
		}
	}

	// Token: 0x06000165 RID: 357 RVA: 0x0000784A File Offset: 0x00005A4A
	public void ixo()
	{
		if (this.hgx == CatDisplayMode.Spine)
		{
			this.uf();
			return;
		}
		this.ug();
	}

	// Token: 0x06000166 RID: 358 RVA: 0x00008838 File Offset: 0x00006A38
	public void klk(CatCharacterDefinition a)
	{
		if (a == null)
		{
			Debug.LogWarning(a.jd());
			return;
		}
		this.hgw = a.characterId;
		this.hgx = a.displayMode;
		this.hhj = a.characterScale;
		this.hhk = a.characterPosition;
		this.hhl = true;
		if (this.hgx == CatDisplayMode.Spine)
		{
			this.tw(a);
			return;
		}
		this.tx(a);
	}

	// Token: 0x06000167 RID: 359 RVA: 0x000088A8 File Offset: 0x00006AA8
	private void Update()
	{
		if (this.hgx == CatDisplayMode.Spine)
		{
			this.ud();
			return;
		}
		if (!this.hhi)
		{
			return;
		}
		this.hhh -= Time.deltaTime;
		if (this.hhh <= 0f)
		{
			this.hhi = false;
			if (this.imageSpriteRenderer != null)
			{
				this.imageSpriteRenderer.sprite = this.hhd;
				this.ty();
			}
		}
	}

	// Token: 0x06000168 RID: 360 RVA: 0x0000784A File Offset: 0x00005A4A
	public void gge()
	{
		if (this.hgx == CatDisplayMode.Spine)
		{
			this.uf();
			return;
		}
		this.ug();
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00008918 File Offset: 0x00006B18
	private void la()
	{
		if (this.skeletonAnimation == null)
		{
			return;
		}
		if (!this.hhc)
		{
			this.uc();
		}
		string text = (this.hhl ? this.hgz : this.hha);
		this.hhl = !this.hhl;
		this.skeletonAnimation.AnimationState.ClearTrack(1);
		TrackEntry trackEntry = this.skeletonAnimation.AnimationState.SetAnimation(1, text, false);
		trackEntry.MixBlend = MixBlend.First;
		trackEntry.MixDuration = -7955f;
		this.skeletonAnimation.AnimationState.AddEmptyAnimation(1, this.hhb, 4026f);
	}

	// Token: 0x0600016A RID: 362 RVA: 0x000089BC File Offset: 0x00006BBC
	private void jis()
	{
		if (this.hgx == CatDisplayMode.Spine)
		{
			this.ud();
			return;
		}
		if (!this.hhi)
		{
			return;
		}
		this.hhh -= Time.deltaTime;
		if (this.hhh <= 8238f)
		{
			this.hhi = false;
			if (this.imageSpriteRenderer != null)
			{
				this.imageSpriteRenderer.sprite = this.hhd;
				this.ty();
			}
		}
	}

	// Token: 0x040000DB RID: 219
	private const int hgu = 0;

	// Token: 0x040000DC RID: 220
	private const int hgv = 1;

	// Token: 0x040000DD RID: 221
	public SkeletonAnimation skeletonAnimation;

	// Token: 0x040000DE RID: 222
	public SpriteRenderer imageSpriteRenderer;

	// Token: 0x040000DF RID: 223
	private string hgw;

	// Token: 0x040000E0 RID: 224
	private CatDisplayMode hgx;

	// Token: 0x040000E1 RID: 225
	private string hgy = a.iv();

	// Token: 0x040000E2 RID: 226
	private string hgz = a.iw();

	// Token: 0x040000E3 RID: 227
	private string hha = a.ix();

	// Token: 0x040000E4 RID: 228
	private float hhb = 0.3f;

	// Token: 0x040000E5 RID: 229
	private bool hhc;

	// Token: 0x040000E6 RID: 230
	private Sprite hhd;

	// Token: 0x040000E7 RID: 231
	private Sprite hhe;

	// Token: 0x040000E8 RID: 232
	private Sprite hhf;

	// Token: 0x040000E9 RID: 233
	private float hhg = 0.5f;

	// Token: 0x040000EA RID: 234
	private float hhh;

	// Token: 0x040000EB RID: 235
	private bool hhi;

	// Token: 0x040000EC RID: 236
	private Vector2 hhj = Vector2.one;

	// Token: 0x040000ED RID: 237
	private Vector2 hhk = Vector2.zero;

	// Token: 0x040000EE RID: 238
	private bool hhl = true;

	// Token: 0x040000EF RID: 239
	private static r hhm;
}
