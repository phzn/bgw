using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Spine;
using Spine.Unity;
using UnityEngine;

namespace BongoWaifu.Multiplayer
{
	// Token: 0x02000131 RID: 305
	public sealed class RemoteCatView : MonoBehaviour
	{
		// Token: 0x06001649 RID: 5705 RVA: 0x0006D988 File Offset: 0x0006BB88
		private void dou()
		{
			if (this.ixn)
			{
				return;
			}
			this.ixn = true;
			if (this.skeletonAnimation == null)
			{
				this.skeletonAnimation = base.GetComponentInChildren<SkeletonAnimation>(true);
			}
			if (this.imageRenderer == null)
			{
				this.imageRenderer = base.GetComponentInChildren<SpriteRenderer>(true);
			}
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x0006D9DC File Offset: 0x0006BBDC
		public void dov(CatCharacterDefinition a)
		{
			this.dou();
			if (a == null)
			{
				fq.dbg(a.ehe());
				return;
			}
			this.ixp = a.displayMode;
			this.ixr = ((a.displayMode == CatDisplayMode.Spine) ? a.skeletonDataAsset : null);
			this.ixs = a.clickLeftAnim;
			this.ixt = a.clickRightAnim;
			this.ixu = a.handMixOutTime;
			this.ixv = a.idleSprite;
			this.ixw = a.clickLeftSprite;
			this.ixx = a.clickRightSprite;
			this.ixy = a.clickDisplayDuration;
			if (a.displayMode == CatDisplayMode.Spine && this.skeletonAnimation != null && this.skeletonAnimation.skeletonDataAsset == a.skeletonDataAsset)
			{
				return;
			}
			fq.dbg(string.Format(a.ehf(), new object[]
			{
				a.characterId,
				a.displayMode,
				fq.dbh(a.skeletonDataAsset),
				fq.dbh(a.idleSprite),
				fq.dbh(this.skeletonAnimation),
				fq.dbh(this.imageRenderer)
			}));
			if (a.displayMode == CatDisplayMode.Spine && a.skeletonDataAsset != null && this.skeletonAnimation != null)
			{
				if (this.imageRenderer != null)
				{
					this.imageRenderer.enabled = false;
				}
				this.skeletonAnimation.gameObject.SetActive(true);
				if (this.skeletonAnimation.skeletonDataAsset != a.skeletonDataAsset)
				{
					this.skeletonAnimation.ClearState();
					this.skeletonAnimation.skeletonDataAsset = a.skeletonDataAsset;
					this.skeletonAnimation.Initialize(true, false);
				}
				this.dow();
				return;
			}
			if (a.displayMode == CatDisplayMode.Image && a.idleSprite != null && this.imageRenderer != null)
			{
				if (this.skeletonAnimation != null)
				{
					this.skeletonAnimation.gameObject.SetActive(false);
				}
				this.imageRenderer.enabled = true;
				this.imageRenderer.sprite = a.idleSprite;
			}
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0006DC0C File Offset: 0x0006BE0C
		private void dow()
		{
			if (this.skeletonAnimation == null || this.skeletonAnimation.Skeleton == null)
			{
				return;
			}
			SkeletonData data = this.skeletonAnimation.Skeleton.Data;
			foreach (string text in new string[]
			{
				a.ehg(),
				a.iv(),
				a.ehh(),
				a.ehi(),
				a.ehj()
			})
			{
				if (data.FindAnimation(text) != null)
				{
					this.ixq = text;
					this.skeletonAnimation.AnimationState.SetAnimation(0, text, true);
					return;
				}
			}
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x0006DCAC File Offset: 0x0006BEAC
		private void Update()
		{
			if (this.ixp == CatDisplayMode.Spine)
			{
				this.dox();
				return;
			}
			if (!this.iyb)
			{
				return;
			}
			this.iya -= Time.deltaTime;
			if (this.iya <= 0f)
			{
				this.iyb = false;
				if (this.imageRenderer != null && this.ixv != null)
				{
					this.imageRenderer.sprite = this.ixv;
				}
			}
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x0006DD24 File Offset: 0x0006BF24
		private void dox()
		{
			if (this.skeletonAnimation == null || string.IsNullOrEmpty(this.ixq))
			{
				return;
			}
			if (this.skeletonAnimation.skeletonDataAsset != this.ixr)
			{
				return;
			}
			global::Spine.AnimationState animationState = this.skeletonAnimation.AnimationState;
			if (animationState == null)
			{
				return;
			}
			TrackEntry current = animationState.GetCurrent(0);
			if (current != null && current.Animation != null && !(current.Animation.Name != this.ixq) && current.Loop)
			{
				float duration = current.Animation.Duration;
				if (duration > 0f && current.TrackTime > 3600f)
				{
					current.TrackTime %= duration;
				}
				return;
			}
			if (this.skeletonAnimation.Skeleton == null || this.skeletonAnimation.Skeleton.Data == null || this.skeletonAnimation.Skeleton.Data.FindAnimation(this.ixq) == null)
			{
				return;
			}
			animationState.SetAnimation(0, this.ixq, true);
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x0006DE25 File Offset: 0x0006C025
		public void doy()
		{
			this.dou();
			if (Time.unscaledTime - this.iyc < 0.05f)
			{
				return;
			}
			this.iyc = Time.unscaledTime;
			if (this.ixp == CatDisplayMode.Spine)
			{
				this.doz();
				return;
			}
			this.dpa();
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0006DE64 File Offset: 0x0006C064
		private void doz()
		{
			if (this.skeletonAnimation == null || this.skeletonAnimation.AnimationState == null || this.skeletonAnimation.Skeleton == null)
			{
				return;
			}
			if (this.skeletonAnimation.skeletonDataAsset != this.ixr)
			{
				return;
			}
			string text = (this.ixz ? this.ixs : this.ixt);
			this.ixz = !this.ixz;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			if (this.skeletonAnimation.Skeleton.Data.FindAnimation(text) == null)
			{
				return;
			}
			this.skeletonAnimation.AnimationState.ClearTrack(1);
			TrackEntry trackEntry = this.skeletonAnimation.AnimationState.SetAnimation(1, text, false);
			trackEntry.MixBlend = MixBlend.First;
			trackEntry.MixDuration = 0f;
			this.skeletonAnimation.AnimationState.AddEmptyAnimation(1, this.ixu, 0f);
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x0006DF50 File Offset: 0x0006C150
		private void dpa()
		{
			if (this.imageRenderer == null)
			{
				return;
			}
			Sprite sprite = (this.ixz ? this.ixw : this.ixx);
			this.ixz = !this.ixz;
			if (sprite == null)
			{
				return;
			}
			this.imageRenderer.sprite = sprite;
			this.iya = this.ixy;
			this.iyb = true;
		}

		// Token: 0x04000B4E RID: 2894
		[SerializeField]
		public SkeletonAnimation skeletonAnimation;

		// Token: 0x04000B4F RID: 2895
		[SerializeField]
		public SpriteRenderer imageRenderer;

		// Token: 0x04000B50 RID: 2896
		private bool ixn;

		// Token: 0x04000B51 RID: 2897
		private const int ixo = 1;

		// Token: 0x04000B52 RID: 2898
		private CatDisplayMode ixp;

		// Token: 0x04000B53 RID: 2899
		private string ixq;

		// Token: 0x04000B54 RID: 2900
		private SkeletonDataAsset ixr;

		// Token: 0x04000B55 RID: 2901
		private string ixs = a.iw();

		// Token: 0x04000B56 RID: 2902
		private string ixt = a.ix();

		// Token: 0x04000B57 RID: 2903
		private float ixu = 0.3f;

		// Token: 0x04000B58 RID: 2904
		private Sprite ixv;

		// Token: 0x04000B59 RID: 2905
		private Sprite ixw;

		// Token: 0x04000B5A RID: 2906
		private Sprite ixx;

		// Token: 0x04000B5B RID: 2907
		private float ixy = 0.5f;

		// Token: 0x04000B5C RID: 2908
		private bool ixz = true;

		// Token: 0x04000B5D RID: 2909
		private float iya;

		// Token: 0x04000B5E RID: 2910
		private bool iyb;

		// Token: 0x04000B5F RID: 2911
		private float iyc = float.NegativeInfinity;

		// Token: 0x04000B60 RID: 2912
		private const float iyd = 0.05f;
	}
}
