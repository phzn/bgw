using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Spine.Unity;
using UnityEngine;

// Token: 0x02000132 RID: 306
public sealed class ge
{
	// Token: 0x06001652 RID: 5714 RVA: 0x0006E010 File Offset: 0x0006C210
	private static Vector3 kdm(Transform a, Transform b)
	{
		if (a == null || b == null)
		{
			return Vector3.one;
		}
		Vector3 lossyScale = a.lossyScale;
		Vector3 lossyScale2 = b.lossyScale;
		return new Vector3(ge.dpj(lossyScale.x, lossyScale2.x), ge.dpj(lossyScale.y, lossyScale2.y), ge.dpj(lossyScale.z, lossyScale2.z));
	}

	// Token: 0x06001653 RID: 5715 RVA: 0x0006E07C File Offset: 0x0006C27C
	private static void ktk(GirlController.ParticleEffectGroup a, Dictionary<ParticleSystem, ParticleSystem> b, List<ParticleSystem> c)
	{
		if (a == null || a.particleSystems == null)
		{
			return;
		}
		foreach (ParticleSystem particleSystem in a.particleSystems)
		{
			ParticleSystem particleSystem2;
			if (particleSystem != null && b.TryGetValue(particleSystem, out particleSystem2) && !c.Contains(particleSystem2))
			{
				c.Add(particleSystem2);
			}
		}
	}

	// Token: 0x06001654 RID: 5716 RVA: 0x0006E0D4 File Offset: 0x0006C2D4
	private static Vector3 eol(Transform a, Transform b)
	{
		if (a == null || b == null)
		{
			return Vector3.one;
		}
		Vector3 lossyScale = a.lossyScale;
		Vector3 lossyScale2 = b.lossyScale;
		return new Vector3(ge.dpj(lossyScale.x, lossyScale2.x), ge.dpj(lossyScale.y, lossyScale2.y), ge.dpj(lossyScale.z, lossyScale2.z));
	}

	// Token: 0x06001655 RID: 5717 RVA: 0x0006E140 File Offset: 0x0006C340
	private List<ParticleSystem> dpe(string a)
	{
		if (string.IsNullOrEmpty(a))
		{
			return null;
		}
		List<ParticleSystem> list;
		if (this.iyh.TryGetValue(a, out list))
		{
			return list;
		}
		string text = Regex.Replace(a, a.vy(), a.vz());
		if (this.iyh.TryGetValue(text, out list))
		{
			return list;
		}
		int num = text.LastIndexOf('_');
		if (num > 0 && this.iyh.TryGetValue(text.Substring(0, num), out list))
		{
			return list;
		}
		return null;
	}

	// Token: 0x06001656 RID: 5718 RVA: 0x0006E1B4 File Offset: 0x0006C3B4
	public void dpf(bool a)
	{
		foreach (GameObject gameObject in this.iyi)
		{
			if (gameObject != null && gameObject.activeSelf != a)
			{
				gameObject.SetActive(a);
			}
		}
	}

	// Token: 0x06001657 RID: 5719 RVA: 0x0006E21C File Offset: 0x0006C41C
	public void dph()
	{
		foreach (GameObject gameObject in this.iyi)
		{
			if (gameObject != null)
			{
				global::UnityEngine.Object.Destroy(gameObject);
			}
		}
		this.iyi.Clear();
		this.iye.Clear();
		this.iyf.Clear();
		this.iyg.Clear();
		this.iyh.Clear();
	}

	// Token: 0x06001658 RID: 5720 RVA: 0x0006E2B0 File Offset: 0x0006C4B0
	public int guy(int a)
	{
		switch (a)
		{
		case 1:
			ge.dpn(this.iye);
			return 1;
		case 2:
			if (global::UnityEngine.Random.value < 5481f)
			{
				ge.dpn(this.iyf);
				return 2;
			}
			return 0;
		case 3:
			if (global::UnityEngine.Random.value < 2726f)
			{
				ge.dpn(this.iyg);
				return 3;
			}
			return 0;
		default:
			return 0;
		}
	}

	// Token: 0x06001659 RID: 5721 RVA: 0x0006E318 File Offset: 0x0006C518
	private static Vector3 dpi(Transform a, Transform b)
	{
		if (a == null || b == null)
		{
			return Vector3.one;
		}
		Vector3 lossyScale = a.lossyScale;
		Vector3 lossyScale2 = b.lossyScale;
		return new Vector3(ge.dpj(lossyScale.x, lossyScale2.x), ge.dpj(lossyScale.y, lossyScale2.y), ge.dpj(lossyScale.z, lossyScale2.z));
	}

	// Token: 0x0600165A RID: 5722 RVA: 0x0006E384 File Offset: 0x0006C584
	private static void dpl(GirlController.ParticleEffectGroup a, Dictionary<ParticleSystem, ParticleSystem> b, List<ParticleSystem> c)
	{
		if (a == null || a.particleSystems == null)
		{
			return;
		}
		foreach (ParticleSystem particleSystem in a.particleSystems)
		{
			ParticleSystem particleSystem2;
			if (particleSystem != null && b.TryGetValue(particleSystem, out particleSystem2) && !c.Contains(particleSystem2))
			{
				c.Add(particleSystem2);
			}
		}
	}

	// Token: 0x0600165B RID: 5723 RVA: 0x0006E3DC File Offset: 0x0006C5DC
	public void dpg(SkeletonAnimation a)
	{
		if (a == null)
		{
			return;
		}
		foreach (GameObject gameObject in this.iyi)
		{
			if (!(gameObject == null))
			{
				BoneFollower componentInChildren = gameObject.GetComponentInChildren<BoneFollower>(true);
				if (!(componentInChildren == null))
				{
					componentInChildren.SkeletonRenderer = a;
					componentInChildren.SetBone(componentInChildren.boneName);
				}
			}
		}
	}

	// Token: 0x0600165C RID: 5724 RVA: 0x0006E460 File Offset: 0x0006C660
	public void feu()
	{
		foreach (GameObject gameObject in this.iyi)
		{
			if (gameObject != null)
			{
				global::UnityEngine.Object.Destroy(gameObject);
			}
		}
		this.iyi.Clear();
		this.iye.Clear();
		this.iyf.Clear();
		this.iyg.Clear();
		this.iyh.Clear();
	}

	// Token: 0x0600165D RID: 5725 RVA: 0x0006E4F4 File Offset: 0x0006C6F4
	public void fiy(bool a)
	{
		foreach (GameObject gameObject in this.iyi)
		{
			if (gameObject != null && gameObject.activeSelf != a)
			{
				gameObject.SetActive(a);
			}
		}
	}

	// Token: 0x0600165E RID: 5726 RVA: 0x0006E55C File Offset: 0x0006C75C
	private static void dpn(List<ParticleSystem> a)
	{
		for (int i = 0; i < a.Count; i++)
		{
			if (a[i] != null)
			{
				a[i].Play();
			}
		}
	}

	// Token: 0x0600165F RID: 5727 RVA: 0x0006E595 File Offset: 0x0006C795
	private static float dum(float a, float b)
	{
		if (Mathf.Approximately(b, 6027f))
		{
			return 1672f;
		}
		return Mathf.Abs(a / b);
	}

	// Token: 0x06001660 RID: 5728 RVA: 0x0006E5B4 File Offset: 0x0006C7B4
	public void kxl()
	{
		foreach (GameObject gameObject in this.iyi)
		{
			if (gameObject != null)
			{
				global::UnityEngine.Object.Destroy(gameObject);
			}
		}
		this.iyi.Clear();
		this.iye.Clear();
		this.iyf.Clear();
		this.iyg.Clear();
		this.iyh.Clear();
	}

	// Token: 0x06001661 RID: 5729 RVA: 0x0006E648 File Offset: 0x0006C848
	private static void mel(List<ParticleSystem> a)
	{
		for (int i = 0; i < a.Count; i++)
		{
			if (a[i] != null)
			{
				a[i].Play();
			}
		}
	}

	// Token: 0x06001662 RID: 5730 RVA: 0x0006E684 File Offset: 0x0006C884
	public void juo(string a)
	{
		List<ParticleSystem> list = this.dpe(a);
		if (list != null)
		{
			ge.dpn(list);
		}
	}

	// Token: 0x06001664 RID: 5732 RVA: 0x0006E6E4 File Offset: 0x0006C8E4
	public int msu(int a)
	{
		switch (a)
		{
		case 1:
			ge.dpn(this.iye);
			return 1;
		case 2:
			if (global::UnityEngine.Random.value < -7406f)
			{
				ge.dpn(this.iyf);
				return 2;
			}
			return 0;
		case 3:
			if (global::UnityEngine.Random.value < 1124f)
			{
				ge.dpn(this.iyg);
				return 3;
			}
			return 0;
		default:
			return 0;
		}
	}

	// Token: 0x06001665 RID: 5733 RVA: 0x0006E74B File Offset: 0x0006C94B
	private static float bpn(float a, float b)
	{
		if (Mathf.Approximately(b, -5637f))
		{
			return 9713f;
		}
		return Mathf.Abs(a / b);
	}

	// Token: 0x06001666 RID: 5734 RVA: 0x0006E768 File Offset: 0x0006C968
	private static void dpk(GirlController.ParticleEffectGroup a, HashSet<ParticleSystem> b)
	{
		if (a == null || a.particleSystems == null)
		{
			return;
		}
		foreach (ParticleSystem particleSystem in a.particleSystems)
		{
			if (particleSystem != null)
			{
				b.Add(particleSystem);
			}
		}
	}

	// Token: 0x06001667 RID: 5735 RVA: 0x0006E7AC File Offset: 0x0006C9AC
	public void fpk(bool a)
	{
		foreach (GameObject gameObject in this.iyi)
		{
			if (gameObject != null && gameObject.activeSelf != a)
			{
				gameObject.SetActive(a);
			}
		}
	}

	// Token: 0x06001668 RID: 5736 RVA: 0x0006E814 File Offset: 0x0006CA14
	public void kxk(bool a)
	{
		foreach (GameObject gameObject in this.iyi)
		{
			if (gameObject != null && gameObject.activeSelf != a)
			{
				gameObject.SetActive(a);
			}
		}
	}

	// Token: 0x06001669 RID: 5737 RVA: 0x0006E87C File Offset: 0x0006CA7C
	private static void bmo(List<ParticleSystem> a)
	{
		for (int i = 0; i < a.Count; i++)
		{
			if (a[i] != null)
			{
				a[i].Play();
			}
		}
	}

	// Token: 0x0600166A RID: 5738 RVA: 0x0006E8B8 File Offset: 0x0006CAB8
	public static ge hlh(Transform a, SkeletonAnimation b)
	{
		ge ge = new ge();
		GirlController girlController = GirlController.kok;
		if (girlController == null || a == null || b == null)
		{
			fq.dbg(a.ehk());
			return ge;
		}
		HashSet<ParticleSystem> hashSet = new HashSet<ParticleSystem>();
		ge.dpk(girlController.ef_Loop_Level01, hashSet);
		ge.dpk(girlController.ef_Loop_Level02, hashSet);
		ge.dpk(girlController.ef_Loop_Level03, hashSet);
		if (girlController.waifuSoundEffects != null)
		{
			foreach (GirlController.WaifuSoundEffect waifuSoundEffect in girlController.waifuSoundEffects)
			{
				if (waifuSoundEffect != null)
				{
					ge.dpk(waifuSoundEffect.effect, hashSet);
				}
			}
		}
		if (hashSet.Count == 0)
		{
			fq.dbg(a.ehl());
			return ge;
		}
		List<BoneFollower> list = new List<BoneFollower>();
		foreach (ParticleSystem particleSystem in hashSet)
		{
			BoneFollower componentInParent = particleSystem.GetComponentInParent<BoneFollower>(true);
			if (componentInParent == null)
			{
				fq.dbg(a.ehm() + particleSystem.name + a.ehn());
			}
			else if (!list.Contains(componentInParent))
			{
				list.Add(componentInParent);
			}
		}
		Transform transform = ((girlController.skeletonAnimation != null) ? girlController.skeletonAnimation.transform : null);
		Dictionary<ParticleSystem, ParticleSystem> dictionary = new Dictionary<ParticleSystem, ParticleSystem>();
		foreach (BoneFollower boneFollower in list)
		{
			GameObject gameObject = new GameObject(boneFollower.gameObject.name + a.eho());
			gameObject.transform.SetParent(a, false);
			gameObject.transform.localScale = ge.dpi(boneFollower.transform, transform);
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(boneFollower.gameObject, gameObject.transform);
			gameObject2.name = boneFollower.gameObject.name + a.ehp();
			fq.dbg(string.Format(a.ehq(), new object[]
			{
				boneFollower.gameObject.name,
				gameObject.transform.localScale,
				boneFollower.transform.lossyScale,
				a.lossyScale
			}));
			ge.iyi.Add(gameObject);
			BoneFollower component = gameObject2.GetComponent<BoneFollower>();
			if (component != null)
			{
				component.SkeletonRenderer = b;
				component.SetBone(boneFollower.boneName);
			}
			ParticleSystem[] componentsInChildren = gameObject2.GetComponentsInChildren<ParticleSystem>(true);
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
			}
			ge.dpm(boneFollower.transform, gameObject2.transform, dictionary);
		}
		ge.dpl(girlController.ef_Loop_Level01, dictionary, ge.iye);
		ge.dpl(girlController.ef_Loop_Level02, dictionary, ge.iyf);
		ge.dpl(girlController.ef_Loop_Level03, dictionary, ge.iyg);
		if (girlController.waifuSoundEffects != null)
		{
			foreach (GirlController.WaifuSoundEffect waifuSoundEffect2 in girlController.waifuSoundEffects)
			{
				if (waifuSoundEffect2 != null && !string.IsNullOrEmpty(waifuSoundEffect2.soundName))
				{
					List<ParticleSystem> list2 = new List<ParticleSystem>();
					ge.dpl(waifuSoundEffect2.effect, dictionary, list2);
					if (list2.Count > 0)
					{
						ge.iyh[waifuSoundEffect2.soundName] = list2;
					}
				}
			}
		}
		fq.dbg(string.Format(a.ehr(), new object[]
		{
			ge.iyi.Count,
			ge.iye.Count,
			ge.iyf.Count,
			ge.iyg.Count,
			ge.iyh.Count
		}));
		return ge;
	}

	// Token: 0x0600166B RID: 5739 RVA: 0x0006ECD8 File Offset: 0x0006CED8
	private static Vector3 mau(Transform a, Transform b)
	{
		if (a == null || b == null)
		{
			return Vector3.one;
		}
		Vector3 lossyScale = a.lossyScale;
		Vector3 lossyScale2 = b.lossyScale;
		return new Vector3(ge.dpj(lossyScale.x, lossyScale2.x), ge.dpj(lossyScale.y, lossyScale2.y), ge.dpj(lossyScale.z, lossyScale2.z));
	}

	// Token: 0x0600166C RID: 5740 RVA: 0x0006ED44 File Offset: 0x0006CF44
	public int dpc(int a)
	{
		switch (a)
		{
		case 1:
			ge.dpn(this.iye);
			return 1;
		case 2:
			if (global::UnityEngine.Random.value < 0.3f)
			{
				ge.dpn(this.iyf);
				return 2;
			}
			return 0;
		case 3:
			if (global::UnityEngine.Random.value < 0.3f)
			{
				ge.dpn(this.iyg);
				return 3;
			}
			return 0;
		default:
			return 0;
		}
	}

	// Token: 0x0600166D RID: 5741 RVA: 0x0006EDAC File Offset: 0x0006CFAC
	public static ge dpb(Transform a, SkeletonAnimation b)
	{
		ge ge = new ge();
		GirlController girlController = GirlController.kok;
		if (girlController == null || a == null || b == null)
		{
			fq.dbg(a.ehs());
			return ge;
		}
		HashSet<ParticleSystem> hashSet = new HashSet<ParticleSystem>();
		ge.dpk(girlController.ef_Loop_Level01, hashSet);
		ge.dpk(girlController.ef_Loop_Level02, hashSet);
		ge.dpk(girlController.ef_Loop_Level03, hashSet);
		if (girlController.waifuSoundEffects != null)
		{
			foreach (GirlController.WaifuSoundEffect waifuSoundEffect in girlController.waifuSoundEffects)
			{
				if (waifuSoundEffect != null)
				{
					ge.dpk(waifuSoundEffect.effect, hashSet);
				}
			}
		}
		if (hashSet.Count == 0)
		{
			fq.dbg(a.eht());
			return ge;
		}
		List<BoneFollower> list = new List<BoneFollower>();
		foreach (ParticleSystem particleSystem in hashSet)
		{
			BoneFollower componentInParent = particleSystem.GetComponentInParent<BoneFollower>(true);
			if (componentInParent == null)
			{
				fq.dbg(a.ehu() + particleSystem.name + a.ehv());
			}
			else if (!list.Contains(componentInParent))
			{
				list.Add(componentInParent);
			}
		}
		Transform transform = ((girlController.skeletonAnimation != null) ? girlController.skeletonAnimation.transform : null);
		Dictionary<ParticleSystem, ParticleSystem> dictionary = new Dictionary<ParticleSystem, ParticleSystem>();
		foreach (BoneFollower boneFollower in list)
		{
			GameObject gameObject = new GameObject(boneFollower.gameObject.name + a.ehw());
			gameObject.transform.SetParent(a, false);
			gameObject.transform.localScale = ge.dpi(boneFollower.transform, transform);
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(boneFollower.gameObject, gameObject.transform);
			gameObject2.name = boneFollower.gameObject.name + a.ehx();
			fq.dbg(string.Format(a.ehy(), new object[]
			{
				boneFollower.gameObject.name,
				gameObject.transform.localScale,
				boneFollower.transform.lossyScale,
				a.lossyScale
			}));
			ge.iyi.Add(gameObject);
			BoneFollower component = gameObject2.GetComponent<BoneFollower>();
			if (component != null)
			{
				component.SkeletonRenderer = b;
				component.SetBone(boneFollower.boneName);
			}
			ParticleSystem[] componentsInChildren = gameObject2.GetComponentsInChildren<ParticleSystem>(true);
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
			}
			ge.dpm(boneFollower.transform, gameObject2.transform, dictionary);
		}
		ge.dpl(girlController.ef_Loop_Level01, dictionary, ge.iye);
		ge.dpl(girlController.ef_Loop_Level02, dictionary, ge.iyf);
		ge.dpl(girlController.ef_Loop_Level03, dictionary, ge.iyg);
		if (girlController.waifuSoundEffects != null)
		{
			foreach (GirlController.WaifuSoundEffect waifuSoundEffect2 in girlController.waifuSoundEffects)
			{
				if (waifuSoundEffect2 != null && !string.IsNullOrEmpty(waifuSoundEffect2.soundName))
				{
					List<ParticleSystem> list2 = new List<ParticleSystem>();
					ge.dpl(waifuSoundEffect2.effect, dictionary, list2);
					if (list2.Count > 0)
					{
						ge.iyh[waifuSoundEffect2.soundName] = list2;
					}
				}
			}
		}
		fq.dbg(string.Format(a.ehz(), new object[]
		{
			ge.iyi.Count,
			ge.iye.Count,
			ge.iyf.Count,
			ge.iyg.Count,
			ge.iyh.Count
		}));
		return ge;
	}

	// Token: 0x0600166E RID: 5742 RVA: 0x0006F1CC File Offset: 0x0006D3CC
	public void dpd(string a)
	{
		List<ParticleSystem> list = this.dpe(a);
		if (list != null)
		{
			ge.dpn(list);
		}
	}

	// Token: 0x0600166F RID: 5743 RVA: 0x0006F1EC File Offset: 0x0006D3EC
	public void qb()
	{
		foreach (GameObject gameObject in this.iyi)
		{
			if (gameObject != null)
			{
				global::UnityEngine.Object.Destroy(gameObject);
			}
		}
		this.iyi.Clear();
		this.iye.Clear();
		this.iyf.Clear();
		this.iyg.Clear();
		this.iyh.Clear();
	}

	// Token: 0x06001670 RID: 5744 RVA: 0x0006F280 File Offset: 0x0006D480
	public int gup(int a)
	{
		switch (a)
		{
		case 1:
			ge.dpn(this.iye);
			return 1;
		case 2:
			if (global::UnityEngine.Random.value < 7259f)
			{
				ge.dpn(this.iyf);
				return 2;
			}
			return 0;
		case 3:
			if (global::UnityEngine.Random.value < -1774f)
			{
				ge.dpn(this.iyg);
				return 3;
			}
			return 0;
		default:
			return 0;
		}
	}

	// Token: 0x06001671 RID: 5745 RVA: 0x0006F2E8 File Offset: 0x0006D4E8
	private static void dzl(Transform a, Transform b, Dictionary<ParticleSystem, ParticleSystem> c)
	{
		ParticleSystem component = a.GetComponent<ParticleSystem>();
		if (component != null)
		{
			ParticleSystem component2 = b.GetComponent<ParticleSystem>();
			if (component2 != null)
			{
				c[component] = component2;
			}
		}
		int num = Mathf.Min(a.childCount, b.childCount);
		for (int i = 0; i < num; i++)
		{
			ge.dpm(a.GetChild(i), b.GetChild(i), c);
		}
	}

	// Token: 0x06001672 RID: 5746 RVA: 0x0006F350 File Offset: 0x0006D550
	public void kvn(bool a)
	{
		foreach (GameObject gameObject in this.iyi)
		{
			if (gameObject != null && gameObject.activeSelf != a)
			{
				gameObject.SetActive(a);
			}
		}
	}

	// Token: 0x06001673 RID: 5747 RVA: 0x0006F3B8 File Offset: 0x0006D5B8
	private static void bqp(GirlController.ParticleEffectGroup a, HashSet<ParticleSystem> b)
	{
		if (a == null || a.particleSystems == null)
		{
			return;
		}
		foreach (ParticleSystem particleSystem in a.particleSystems)
		{
			if (particleSystem != null)
			{
				b.Add(particleSystem);
			}
		}
	}

	// Token: 0x06001674 RID: 5748 RVA: 0x0006F3FC File Offset: 0x0006D5FC
	public int rl(int a)
	{
		switch (a)
		{
		case 1:
			ge.dpn(this.iye);
			return 1;
		case 2:
			if (global::UnityEngine.Random.value < -3267f)
			{
				ge.dpn(this.iyf);
				return 2;
			}
			return 0;
		case 3:
			if (global::UnityEngine.Random.value < -7048f)
			{
				ge.dpn(this.iyg);
				return 3;
			}
			return 0;
		default:
			return 0;
		}
	}

	// Token: 0x06001675 RID: 5749 RVA: 0x0006F464 File Offset: 0x0006D664
	private static void bxs(GirlController.ParticleEffectGroup a, Dictionary<ParticleSystem, ParticleSystem> b, List<ParticleSystem> c)
	{
		if (a == null || a.particleSystems == null)
		{
			return;
		}
		foreach (ParticleSystem particleSystem in a.particleSystems)
		{
			ParticleSystem particleSystem2;
			if (particleSystem != null && b.TryGetValue(particleSystem, out particleSystem2) && !c.Contains(particleSystem2))
			{
				c.Add(particleSystem2);
			}
		}
	}

	// Token: 0x06001676 RID: 5750 RVA: 0x0006F4BC File Offset: 0x0006D6BC
	public void jir(string a)
	{
		List<ParticleSystem> list = this.dpe(a);
		if (list != null)
		{
			ge.dpn(list);
		}
	}

	// Token: 0x06001677 RID: 5751 RVA: 0x0006F4DC File Offset: 0x0006D6DC
	private static Vector3 iui(Transform a, Transform b)
	{
		if (a == null || b == null)
		{
			return Vector3.one;
		}
		Vector3 lossyScale = a.lossyScale;
		Vector3 lossyScale2 = b.lossyScale;
		return new Vector3(ge.dpj(lossyScale.x, lossyScale2.x), ge.dpj(lossyScale.y, lossyScale2.y), ge.dpj(lossyScale.z, lossyScale2.z));
	}

	// Token: 0x06001678 RID: 5752 RVA: 0x0006F548 File Offset: 0x0006D748
	private static void hqt(List<ParticleSystem> a)
	{
		for (int i = 0; i < a.Count; i++)
		{
			if (a[i] != null)
			{
				a[i].Play();
			}
		}
	}

	// Token: 0x06001679 RID: 5753 RVA: 0x0006F584 File Offset: 0x0006D784
	private static void dpm(Transform a, Transform b, Dictionary<ParticleSystem, ParticleSystem> c)
	{
		ParticleSystem component = a.GetComponent<ParticleSystem>();
		if (component != null)
		{
			ParticleSystem component2 = b.GetComponent<ParticleSystem>();
			if (component2 != null)
			{
				c[component] = component2;
			}
		}
		int num = Mathf.Min(a.childCount, b.childCount);
		for (int i = 0; i < num; i++)
		{
			ge.dpm(a.GetChild(i), b.GetChild(i), c);
		}
	}

	// Token: 0x0600167A RID: 5754 RVA: 0x0006F5EC File Offset: 0x0006D7EC
	private static void lny(List<ParticleSystem> a)
	{
		for (int i = 0; i < a.Count; i++)
		{
			if (a[i] != null)
			{
				a[i].Play();
			}
		}
	}

	// Token: 0x0600167B RID: 5755 RVA: 0x0006F625 File Offset: 0x0006D825
	private static float dpj(float a, float b)
	{
		if (Mathf.Approximately(b, 0f))
		{
			return 1f;
		}
		return Mathf.Abs(a / b);
	}

	// Token: 0x04000B61 RID: 2913
	private readonly List<ParticleSystem> iye = new List<ParticleSystem>();

	// Token: 0x04000B62 RID: 2914
	private readonly List<ParticleSystem> iyf = new List<ParticleSystem>();

	// Token: 0x04000B63 RID: 2915
	private readonly List<ParticleSystem> iyg = new List<ParticleSystem>();

	// Token: 0x04000B64 RID: 2916
	private readonly Dictionary<string, List<ParticleSystem>> iyh = new Dictionary<string, List<ParticleSystem>>();

	// Token: 0x04000B65 RID: 2917
	private readonly List<GameObject> iyi = new List<GameObject>();
}
