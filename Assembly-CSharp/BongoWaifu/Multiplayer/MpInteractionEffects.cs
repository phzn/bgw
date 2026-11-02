using System;
using System.Collections;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

namespace BongoWaifu.Multiplayer
{
	// Token: 0x0200010F RID: 271
	public sealed class MpInteractionEffects : MonoBehaviour
	{
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x0005F9D9 File Offset: 0x0005DBD9
		// (set) Token: 0x0600137D RID: 4989 RVA: 0x0005F9E0 File Offset: 0x0005DBE0
		public static MpInteractionEffects iqi { get; private set; }

		// Token: 0x0600137E RID: 4990 RVA: 0x0005F9E8 File Offset: 0x0005DBE8
		public static void czb()
		{
			if (MpInteractionEffects.iqi != null)
			{
				return;
			}
			MpInteractionEffects mpInteractionEffects = global::UnityEngine.Object.FindFirstObjectByType<MpInteractionEffects>(FindObjectsInactive.Exclude);
			if (mpInteractionEffects != null)
			{
				MpInteractionEffects.iqi = mpInteractionEffects;
				return;
			}
			MpInteractionEffects.iqi = new GameObject(a.dtp()).AddComponent<MpInteractionEffects>();
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x0005FA2E File Offset: 0x0005DC2E
		private void Awake()
		{
			if (MpInteractionEffects.iqi != null && MpInteractionEffects.iqi != this)
			{
				global::UnityEngine.Object.Destroy(this);
				return;
			}
			MpInteractionEffects.iqi = this;
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0005FA58 File Offset: 0x0005DC58
		private void OnDestroy()
		{
			if (MpInteractionEffects.iqi == this)
			{
				MpInteractionEffects.iqi = null;
			}
			for (int i = 0; i < this.iqj.Count; i++)
			{
				if (this.iqj[i].ipv != null)
				{
					global::UnityEngine.Object.Destroy(this.iqj[i].ipv);
				}
			}
			this.iqj.Clear();
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0005FAC8 File Offset: 0x0005DCC8
		private void OnEnable()
		{
			if (MpInteractionEffects.iqi != this)
			{
				return;
			}
			MultiplayerSession.ivg += this.czc;
			MultiplayerSession.ivf += this.czd;
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x0005FAFA File Offset: 0x0005DCFA
		private void OnDisable()
		{
			MultiplayerSession.ivg -= this.czc;
			MultiplayerSession.ivf -= this.czd;
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x0005FB20 File Offset: 0x0005DD20
		private void czc(gb a, InteractionType b, NetworkPlayer c, Vector2 d)
		{
			if (b != InteractionType.Thrust || c == null || a == null)
			{
				return;
			}
			if (a.iur == null)
			{
				return;
			}
			Bounds bounds;
			if (a.iuu == null || !a.iuu.dnv(out bounds))
			{
				bounds = a.iur.bounds;
			}
			this.czf(a.iur, bounds, d, c, a.iun == CharacterKind.Waifu);
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x0005FB90 File Offset: 0x0005DD90
		private void czd(InteractionType a, NetworkPlayer b, Vector2 c)
		{
			if (a != InteractionType.Thrust || b == null)
			{
				return;
			}
			if (bq.hlz)
			{
				return;
			}
			Renderer renderer = MpInteractionEffects.czg();
			if (renderer == null)
			{
				return;
			}
			Bounds bounds = MpInteractionEffects.cze(renderer);
			this.czf(renderer, bounds, c, b, bq.hly == 0);
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0005FBDC File Offset: 0x0005DDDC
		private static Bounds cze(Renderer a)
		{
			Bounds bounds = a.bounds;
			SkeletonAnimation skeletonAnimation = ((bq.hly == 0 && GirlController.kok != null) ? GirlController.kok.skeletonAnimation : null);
			Bounds bounds2;
			if (skeletonAnimation != null && gh.drc(skeletonAnimation, out bounds2))
			{
				bounds = bounds2;
			}
			else if (bq.hly != 0 && r.kmi != null)
			{
				SkeletonAnimation skeletonAnimation2 = r.kmi.skeletonAnimation;
				Bounds bounds3;
				if (skeletonAnimation2 != null && skeletonAnimation2.GetComponent<Renderer>() == a && gh.drc(skeletonAnimation2, out bounds3))
				{
					bounds = bounds3;
				}
			}
			return bounds;
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0005FC70 File Offset: 0x0005DE70
		private void czf(Renderer a, Bounds b, Vector2 c, NetworkPlayer d, bool e)
		{
			if (a == null || !a.enabled || !a.gameObject.activeInHierarchy)
			{
				return;
			}
			Bounds bounds = b;
			if (bounds.size.x < 0.001f || bounds.size.y < 0.001f)
			{
				return;
			}
			Color color = fn.daa(d.kva);
			Vector3 vector = new Vector3(bounds.min.x + Mathf.Clamp01(c.x) * bounds.size.x, bounds.min.y + Mathf.Clamp01(c.y) * bounds.size.y, bounds.center.z);
			Vector3 vector2 = new Vector3(bounds.center.x, bounds.max.y, bounds.center.z);
			this.czi(vector, color);
			if (e)
			{
				this.czo(vector2, color, MpInteractionEffects.czp(d));
			}
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x0005FD78 File Offset: 0x0005DF78
		private static Renderer czg()
		{
			if (bq.hly != 0)
			{
				r r = r.kmi;
				if (r == null)
				{
					return null;
				}
				SkeletonAnimation skeletonAnimation = r.skeletonAnimation;
				Renderer renderer = ((skeletonAnimation != null) ? skeletonAnimation.GetComponent<Renderer>() : null);
				if (renderer != null && renderer.enabled && renderer.gameObject.activeInHierarchy)
				{
					return renderer;
				}
				SpriteRenderer imageSpriteRenderer = r.imageSpriteRenderer;
				if (imageSpriteRenderer != null && imageSpriteRenderer.enabled && imageSpriteRenderer.gameObject.activeInHierarchy)
				{
					return imageSpriteRenderer;
				}
				return null;
			}
			else
			{
				GirlController girlController = GirlController.kok;
				SkeletonAnimation skeletonAnimation2 = ((girlController != null) ? girlController.skeletonAnimation : null);
				if (!(skeletonAnimation2 != null))
				{
					return null;
				}
				return skeletonAnimation2.GetComponent<Renderer>();
			}
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0005FE38 File Offset: 0x0005E038
		public void czh(GameObject a, Color b, string c)
		{
			Renderer renderer = MpInteractionEffects.czg();
			Vector3 vector;
			Vector3 vector2;
			if (renderer != null && renderer.bounds.size.x > 0.001f && renderer.bounds.size.y > 0.001f)
			{
				Bounds bounds = MpInteractionEffects.cze(renderer);
				vector = new Vector3(bounds.min.x + 0.5f * bounds.size.x, bounds.min.y + 0.4f * bounds.size.y, bounds.center.z);
				vector2 = new Vector3(bounds.center.x, bounds.max.y, bounds.center.z);
			}
			else
			{
				Camera main = Camera.main;
				vector = (vector2 = ((main != null) ? main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 10f)) : Vector3.zero));
			}
			GameObject gameObject = ((a != null) ? a : this.clickEffectPrefab);
			this.czj(gameObject, vector, b);
			this.czo(vector2, b, c);
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x0005FF74 File Offset: 0x0005E174
		private void czi(Vector3 a, Color b)
		{
			this.czj(this.clickEffectPrefab, a, b);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x0005FF84 File Offset: 0x0005E184
		private void czj(GameObject a, Vector3 b, Color c)
		{
			if (a == null)
			{
				return;
			}
			MpInteractionEffects.fk fk = this.czk(a);
			if (fk == null)
			{
				return;
			}
			fk.ipw.position = b;
			fk.ipw.localScale = fk.ipy * MpInteractionEffects.czn();
			for (int i = 0; i < fk.ipx.Length; i++)
			{
				if (!(fk.ipx[i] == null))
				{
					fk.ipx[i].main.startColor = c;
				}
			}
			fk.ipv.SetActive(true);
			for (int j = 0; j < fk.ipx.Length; j++)
			{
				if (!(fk.ipx[j] == null))
				{
					fk.ipx[j].Clear(false);
					fk.ipx[j].Play(false);
				}
			}
			fk.ipz = Time.time + this.effectLifetime;
			MpInteractionEffects.fk fk2 = fk;
			int num = fk2.iqa + 1;
			fk2.iqa = num;
			int num2 = num;
			base.StartCoroutine(this.czm(fk, num2));
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00060094 File Offset: 0x0005E294
		private MpInteractionEffects.fk czk(GameObject a)
		{
			for (int i = 0; i < this.iqj.Count; i++)
			{
				MpInteractionEffects.fk fk = this.iqj[i];
				if (fk.ipu == a && fk.ipv != null && Time.time >= fk.ipz)
				{
					return fk;
				}
			}
			return this.czl(a);
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x000600F8 File Offset: 0x0005E2F8
		private MpInteractionEffects.fk czl(GameObject a)
		{
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(a, Vector3.zero, Quaternion.identity);
			MpInteractionEffects.fk fk = new MpInteractionEffects.fk
			{
				ipu = a,
				ipv = gameObject,
				ipw = gameObject.transform,
				ipx = gameObject.GetComponentsInChildren<ParticleSystem>(true),
				ipy = gameObject.transform.localScale
			};
			for (int i = 0; i < fk.ipx.Length; i++)
			{
				fk.ipx[i].main.scalingMode = ParticleSystemScalingMode.Hierarchy;
			}
			this.iqj.Add(fk);
			return fk;
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x0006018A File Offset: 0x0005E38A
		private IEnumerator czm(MpInteractionEffects.fk a, int b)
		{
			if (this.iqk == null)
			{
				this.iqk = new WaitForSeconds(this.effectLifetime);
			}
			yield return this.iqk;
			if (a.iqa != b || a.ipv == null)
			{
				yield break;
			}
			for (int i = 0; i < a.ipx.Length; i++)
			{
				if (a.ipx[i] != null)
				{
					a.ipx[i].Stop(false, ParticleSystemStopBehavior.StopEmittingAndClear);
				}
			}
			a.ipv.SetActive(false);
			yield break;
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x000601A8 File Offset: 0x0005E3A8
		private static float czn()
		{
			GirlController girlController = GirlController.kok;
			if (girlController == null || girlController.sizeController == null)
			{
				return 1f;
			}
			bz sizeController = girlController.sizeController;
			int num = ((sizeController.sizes != null) ? sizeController.sizes.Count : 0);
			if (num == 0)
			{
				return 1f;
			}
			int num2 = Mathf.Clamp(bq.hlo, 0, num - 1);
			float num3 = sizeController.bdq(0);
			if (num3 <= 0.0001f)
			{
				return 1f;
			}
			return sizeController.bdq(num2) / num3;
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00060230 File Offset: 0x0005E430
		private void czo(Vector3 a, Color b, string c)
		{
			if (string.IsNullOrEmpty(c))
			{
				return;
			}
			Camera main = Camera.main;
			if (main == null)
			{
				return;
			}
			Vector3 vector = main.WorldToScreenPoint(a);
			if (vector.z <= 0f)
			{
				return;
			}
			MpFloatingText mpFloatingText = this.czr();
			if (mpFloatingText == null)
			{
				return;
			}
			float num = MpInteractionEffects.czn();
			int num2 = Mathf.Max(1, Mathf.RoundToInt((float)this.textFontSize * num));
			mpFloatingText.cyt(new Vector2(vector.x, vector.y), b, c, this.textRiseDistance * num, this.textDuration, num2);
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x000602C4 File Offset: 0x0005E4C4
		private static string czp(NetworkPlayer a)
		{
			string text = a.kuq;
			string text2 = a.kvb;
			if (!string.IsNullOrEmpty(text2))
			{
				try
				{
					return string.Format(text2, text);
				}
				catch
				{
					return text2;
				}
			}
			return MpInteractionEffects.czq(text);
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x00060310 File Offset: 0x0005E510
		public static string czq(string a)
		{
			return string.Format(MultiplayerLoc.Get(a.dtq(), a.dtr()), a);
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00060328 File Offset: 0x0005E528
		private MpFloatingText czr()
		{
			for (int i = 0; i < this.iqh.Count; i++)
			{
				if (this.iqh[i] != null && this.iqh[i].ktk)
				{
					return this.iqh[i];
				}
			}
			return this.czs();
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00060388 File Offset: 0x0005E588
		private MpFloatingText czs()
		{
			this.czt();
			if (this.iqg == null)
			{
				return null;
			}
			GameObject gameObject = new GameObject(a.dts(), new Type[]
			{
				typeof(RectTransform),
				typeof(CanvasGroup)
			});
			RectTransform rectTransform = (RectTransform)gameObject.transform;
			rectTransform.SetParent(this.iqg.transform, false);
			RectTransform rectTransform2 = rectTransform;
			RectTransform rectTransform3 = rectTransform;
			Vector2 vector = new Vector2(0.5f, 0.5f);
			rectTransform3.anchorMax = vector;
			rectTransform2.anchorMin = vector;
			rectTransform.pivot = new Vector2(0.5f, 0.5f);
			rectTransform.sizeDelta = new Vector2(600f, 80f);
			GameObject gameObject2 = new GameObject(a.dtt(), new Type[]
			{
				typeof(RectTransform),
				typeof(Text),
				typeof(Outline)
			});
			RectTransform rectTransform4 = (RectTransform)gameObject2.transform;
			rectTransform4.SetParent(rectTransform, false);
			rectTransform4.anchorMin = Vector2.zero;
			rectTransform4.anchorMax = Vector2.one;
			rectTransform4.offsetMin = Vector2.zero;
			rectTransform4.offsetMax = Vector2.zero;
			Text component = gameObject2.GetComponent<Text>();
			component.font = MpInteractionEffects.czu();
			component.fontSize = this.textFontSize;
			component.alignment = TextAnchor.MiddleCenter;
			component.horizontalOverflow = HorizontalWrapMode.Overflow;
			component.verticalOverflow = VerticalWrapMode.Overflow;
			component.raycastTarget = false;
			Outline component2 = gameObject2.GetComponent<Outline>();
			component2.effectColor = new Color(0f, 0f, 0f, 0.85f);
			component2.effectDistance = new Vector2(1.5f, -1.5f);
			CanvasGroup component3 = gameObject.GetComponent<CanvasGroup>();
			component3.interactable = false;
			component3.blocksRaycasts = false;
			MpFloatingText mpFloatingText = gameObject.AddComponent<MpFloatingText>();
			mpFloatingText.cyr(rectTransform, component, component3);
			this.iqh.Add(mpFloatingText);
			return mpFloatingText;
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x0006055C File Offset: 0x0005E75C
		private void czt()
		{
			if (this.iqg != null)
			{
				return;
			}
			GameObject gameObject = new GameObject(a.dtu(), new Type[] { typeof(Canvas) });
			gameObject.transform.SetParent(base.transform, false);
			this.iqg = gameObject.GetComponent<Canvas>();
			this.iqg.renderMode = RenderMode.ScreenSpaceOverlay;
			this.iqg.sortingOrder = this.canvasSortingOrder;
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x000605D4 File Offset: 0x0005E7D4
		private static Font czu()
		{
			Font builtinResource = Resources.GetBuiltinResource<Font>(a.dtv());
			if (builtinResource != null)
			{
				return builtinResource;
			}
			return Font.CreateDynamicFontFromOSFont(a.dtw(), 24);
		}

		// Token: 0x04000A38 RID: 2616
		[SerializeField]
		private GameObject clickEffectPrefab;

		// Token: 0x04000A39 RID: 2617
		[SerializeField]
		private float effectLifetime = 2f;

		// Token: 0x04000A3A RID: 2618
		[SerializeField]
		private float textRiseDistance = 70f;

		// Token: 0x04000A3B RID: 2619
		[SerializeField]
		private float textDuration = 1.4f;

		// Token: 0x04000A3C RID: 2620
		[SerializeField]
		private int textFontSize = 28;

		// Token: 0x04000A3D RID: 2621
		[SerializeField]
		private int canvasSortingOrder = 460;

		// Token: 0x04000A3E RID: 2622
		private Canvas iqg;

		// Token: 0x04000A3F RID: 2623
		private readonly List<MpFloatingText> iqh = new List<MpFloatingText>();

		// Token: 0x04000A41 RID: 2625
		private readonly List<MpInteractionEffects.fk> iqj = new List<MpInteractionEffects.fk>();

		// Token: 0x04000A42 RID: 2626
		private WaitForSeconds iqk;

		// Token: 0x02000110 RID: 272
		private sealed class fk
		{
			// Token: 0x04000A43 RID: 2627
			public GameObject ipu;

			// Token: 0x04000A44 RID: 2628
			public GameObject ipv;

			// Token: 0x04000A45 RID: 2629
			public Transform ipw;

			// Token: 0x04000A46 RID: 2630
			public ParticleSystem[] ipx;

			// Token: 0x04000A47 RID: 2631
			public Vector3 ipy;

			// Token: 0x04000A48 RID: 2632
			public float ipz;

			// Token: 0x04000A49 RID: 2633
			public int iqa;
		}
	}
}
