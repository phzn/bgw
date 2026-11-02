using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using AOT;
using FMOD;
using FMOD.Studio;
using FMODUnity;
using Spine;
using Spine.Unity;
using UnityEngine;

namespace BongoWaifu.Multiplayer
{
	// Token: 0x02000136 RID: 310
	public sealed class RemoteWaifuView : MonoBehaviour
	{
		// Token: 0x0600169F RID: 5791 RVA: 0x000710B9 File Offset: 0x0006F2B9
		private void Awake()
		{
			this.dqj();
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x000710C1 File Offset: 0x0006F2C1
		private void OnDestroy()
		{
			this.dra();
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x000710C9 File Offset: 0x0006F2C9
		public void dqg(ulong a)
		{
			this.izy = a;
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x000710D2 File Offset: 0x0006F2D2
		public void dqh(int a)
		{
			this.izz = a;
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x000710DC File Offset: 0x0006F2DC
		private void Update()
		{
			string text;
			while (this.izq.TryDequeue(out text))
			{
				fq.dbg(a.ekg() + text);
				ge ge = this.izs;
				if (ge != null)
				{
					ge.dpd(text);
				}
			}
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x0007111C File Offset: 0x0006F31C
		[MonoPInvokeCallback(typeof(EVENT_CALLBACK))]
		private static RESULT dqi(EVENT_CALLBACK_TYPE a, IntPtr b, IntPtr c)
		{
			try
			{
				if (a == EVENT_CALLBACK_TYPE.SOUND_PLAYED)
				{
					RemoteWaifuView remoteWaifuView;
					string text;
					if (RemoteWaifuView.izo.TryGetValue(b, out remoteWaifuView) && new Sound
					{
						handle = c
					}.getName(out text, 256) == RESULT.OK && !string.IsNullOrEmpty(text))
					{
						remoteWaifuView.izq.Enqueue(Path.GetFileNameWithoutExtension(text));
					}
				}
				else if (a == EVENT_CALLBACK_TYPE.DESTROYED)
				{
					RemoteWaifuView remoteWaifuView2;
					RemoteWaifuView.izo.TryRemove(b, out remoteWaifuView2);
				}
			}
			catch (Exception)
			{
			}
			return RESULT.OK;
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x000711A8 File Offset: 0x0006F3A8
		private void dqj()
		{
			if (this.izx)
			{
				return;
			}
			if (this.skeletonAnimation == null)
			{
				this.skeletonAnimation = base.GetComponentInChildren<SkeletonAnimation>();
			}
			if (this.skeletonAnimation != null && bq.hle != null)
			{
				this.skeletonAnimation.Initialize(false, false);
				if (this.skeletonAnimation.Skeleton == null || this.skeletonAnimation.AnimationState == null)
				{
					fq.dbg(a.ekh());
					return;
				}
				this.izu = this.skeletonAnimation.skeletonDataAsset;
				gf gf = this.izr;
				if (gf != null)
				{
					gf.dps();
				}
				this.izr = new gf(this.skeletonAnimation, bq.hle);
				this.izs = ge.dpb(base.transform, this.skeletonAnimation);
				if (!this.izw)
				{
					this.izs.dpf(false);
				}
				this.skeletonAnimation.OnAnimationRebuild += this.dqk;
				this.dqm();
				this.izx = true;
			}
			fq.dbg(string.Format(a.eki(), fq.dbh(this.skeletonAnimation), fq.dbh(bq.hle), this.izx));
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x000712E1 File Offset: 0x0006F4E1
		private void dqk(ISkeletonAnimation a)
		{
			this.jak = -1;
			this.jae = int.MinValue;
			this.jag = -1;
			this.jac = false;
			this.jal = null;
			this.dqm();
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00071310 File Offset: 0x0006F510
		public void dql(bool a)
		{
			if (this.izw == a)
			{
				return;
			}
			this.izw = a;
			this.dqj();
			if (!this.izx)
			{
				return;
			}
			fq.dbg(string.Format(a.ekj(), a));
			if (!a)
			{
				ge ge = this.izs;
				if (ge == null)
				{
					return;
				}
				ge.dpf(false);
				return;
			}
			else
			{
				if (this.izu != null && this.skeletonAnimation.skeletonDataAsset != this.izu)
				{
					this.skeletonAnimation.ClearState();
					this.skeletonAnimation.skeletonDataAsset = this.izu;
					this.skeletonAnimation.Initialize(true, false);
				}
				ge ge2 = this.izs;
				if (ge2 != null)
				{
					ge2.dpf(true);
				}
				ge ge3 = this.izs;
				if (ge3 == null)
				{
					return;
				}
				ge3.dpg(this.skeletonAnimation);
				return;
			}
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x000713E0 File Offset: 0x0006F5E0
		private void dqm()
		{
			global::Spine.AnimationState animationState = ((this.skeletonAnimation != null) ? this.skeletonAnimation.AnimationState : null);
			if (this.izt == animationState)
			{
				return;
			}
			if (this.izt != null)
			{
				this.izt.Event -= this.dqo;
			}
			this.izt = animationState;
			if (this.izt != null)
			{
				this.izt.Event += this.dqo;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060016A9 RID: 5801 RVA: 0x00071459 File Offset: 0x0006F659
		private bool kvk
		{
			get
			{
				return gc.dmu(this.izy);
			}
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00071468 File Offset: 0x0006F668
		private void dqo(TrackEntry a, Event b)
		{
			if (!this.izw)
			{
				return;
			}
			if (b.Data == null)
			{
				return;
			}
			if (b.Data.Name == a.wb())
			{
				int num = ((this.izs != null) ? this.izs.dpc(this.izv) : 0);
				GirlController girlController = GirlController.kok;
				if (girlController != null && !this.kvk)
				{
					if (num == 2)
					{
						gc.dmx(girlController.soundSquirtSmall, base.transform.position);
						return;
					}
					if (num == 3)
					{
						gc.dmx(girlController.soundSquirtBig, base.transform.position);
						return;
					}
				}
			}
			else if (b.Data.Name == a.wa())
			{
				GirlController girlController2 = GirlController.kok;
				if (girlController2 == null)
				{
					return;
				}
				if (this.kvk)
				{
					return;
				}
				gc.dmx(girlController2.soundThrust, base.transform.position);
				if (Time.unscaledTime >= this.jaa && global::UnityEngine.Random.value < 0.3f)
				{
					gc.dmy(bq.zz(this.izz, new Func<VoiceProfile, EventReference>(RemoteWaifuView.<>c.<>9.dqe), girlController2.soundLoopWaifu), base.transform.position, RemoteWaifuView.izp, EVENT_CALLBACK_TYPE.DESTROYED | EVENT_CALLBACK_TYPE.SOUND_PLAYED, new Action<EventInstance>(this.drb));
					this.jaa = Time.unscaledTime + 0.5f;
				}
			}
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x000715E0 File Offset: 0x0006F7E0
		public void dqp(ClothingSet a)
		{
			this.dqj();
			if (this.skeletonAnimation == null)
			{
				return;
			}
			if (this.jac && a.diq(this.jab))
			{
				return;
			}
			if (gg.dqb(this.skeletonAnimation, this.izr, a))
			{
				this.jab = a;
				this.jac = true;
			}
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x0007163C File Offset: 0x0006F83C
		public void dqq(int a)
		{
			this.dqj();
			if (this.skeletonAnimation == null)
			{
				if (fq.iro)
				{
					fq.dbg(string.Format(a.ekk(), a));
				}
				return;
			}
			if (a == 5)
			{
				if (this.jad != 5)
				{
					this.jaf = true;
				}
			}
			else
			{
				this.jaf = false;
			}
			this.jad = a;
			bool flag = this.jaf && a == 5;
			if (a == this.jae && !flag)
			{
				return;
			}
			if (this.jal != null && !this.jal.IsComplete)
			{
				return;
			}
			string text;
			bool flag2;
			if (!this.dqt(a, out text, out flag2))
			{
				if (fq.iro)
				{
					fq.dbg(string.Format(a.ekl(), a));
				}
				return;
			}
			if (fq.iro)
			{
				fq.dbg(string.Format(a.ekm(), a, text, flag2));
			}
			this.skeletonAnimation.AnimationState.SetAnimation(0, text, flag2);
			this.jae = a;
			if (this.jaf && a == 5)
			{
				this.jaf = false;
				this.dqr();
			}
			string text2;
			bool flag3;
			if (!flag2 && this.dqt(RemoteWaifuView.dqs(a), out text2, out flag3))
			{
				this.skeletonAnimation.AnimationState.AddAnimation(0, text2, flag3, 0f);
			}
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00071784 File Offset: 0x0006F984
		private void dqr()
		{
			if (this.kvk)
			{
				return;
			}
			GirlController girlController = GirlController.kok;
			if (girlController == null)
			{
				return;
			}
			EventReference eventReference = bq.zz(this.izz, new Func<VoiceProfile, EventReference>(RemoteWaifuView.<>c.<>9.dqf), girlController.soundEnd_VC);
			if (eventReference.IsNull || girlController.soundEnd_SFX.IsNull)
			{
				return;
			}
			if (fq.iro)
			{
				fq.dbg(string.Format(a.ekn(), this.izz));
			}
			gc.dmx(eventReference, base.transform.position);
			gc.dmx(girlController.soundEnd_SFX, base.transform.position);
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x0007183C File Offset: 0x0006FA3C
		private static int dqs(int a)
		{
			if (a == 3)
			{
				return 1;
			}
			if (a != 5)
			{
				return a;
			}
			return 2;
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00071850 File Offset: 0x0006FA50
		private bool dqt(int a, out string b, out bool c)
		{
			b = RemoteWaifuView.dqy(a);
			if (this.skeletonAnimation.Skeleton != null && this.skeletonAnimation.Skeleton.Data.FindAnimation(b) == null)
			{
				b = RemoteWaifuView.dqz(a);
				if (this.skeletonAnimation.Skeleton.Data.FindAnimation(b) == null)
				{
					c = false;
					return false;
				}
			}
			c = a != 5;
			return true;
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x000718BC File Offset: 0x0006FABC
		public void dqu(int a)
		{
			this.dqj();
			if (this.skeletonAnimation == null)
			{
				return;
			}
			a = Mathf.Clamp(a, 0, 3);
			this.izv = a;
			if (a == this.jag)
			{
				return;
			}
			this.skeletonAnimation.AnimationState.SetAnimation(5, a.eko() + a.ToString(), true);
			this.jag = a;
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00071928 File Offset: 0x0006FB28
		public void dqv(int a)
		{
			this.dqj();
			if (this.skeletonAnimation == null || this.skeletonAnimation.Skeleton == null)
			{
				return;
			}
			a = Mathf.Clamp(a, 0, 10);
			if (a == this.jak)
			{
				return;
			}
			bool flag = this.jak < 0;
			string text = string.Format(a.vv(), a);
			if (this.skeletonAnimation.Skeleton.Data.FindAnimation(text) == null)
			{
				this.jak = a;
				fq.dbg(string.Format(a.ekp(), a, text));
				return;
			}
			fq.dbg(string.Format(a.ekq(), a, flag));
			this.skeletonAnimation.AnimationState.SetAnimation(6, text, true).MixDuration = (flag ? 0f : 1f);
			this.jak = a;
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00071A08 File Offset: 0x0006FC08
		public void dqw()
		{
			this.dqj();
			if (this.skeletonAnimation == null || this.skeletonAnimation.AnimationState == null)
			{
				return;
			}
			if (Time.unscaledTime - this.jan < 0.05f)
			{
				return;
			}
			this.jan = Time.unscaledTime;
			this.jal = this.skeletonAnimation.AnimationState.SetAnimation(0, a.ekr(), false);
			this.jal.Dispose += this.dqx;
			string text;
			bool flag;
			if (this.dqt(RemoteWaifuView.dqs(this.jad), out text, out flag))
			{
				this.skeletonAnimation.AnimationState.AddAnimation(0, text, flag, 0f);
			}
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00071ABA File Offset: 0x0006FCBA
		private void dqx(TrackEntry a)
		{
			if (this.jal != a)
			{
				return;
			}
			this.jal = null;
			if (this.jad != this.jae || this.jaf)
			{
				this.dqq(this.jad);
			}
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00071AF0 File Offset: 0x0006FCF0
		private static string dqy(int a)
		{
			switch (a)
			{
			case 1:
				return a.vm();
			case 2:
				return a.vn();
			case 3:
				return a.vm();
			case 4:
				return a.vm();
			case 5:
				return a.vq();
			default:
				return a.vl();
			}
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00071B40 File Offset: 0x0006FD40
		private static string dqz(int a)
		{
			switch (a)
			{
			case 1:
				return a.vm();
			case 2:
				return a.vo();
			case 3:
				return a.vm();
			case 4:
				return a.vm();
			case 5:
				return a.vq();
			default:
				return a.iv();
			}
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00071B90 File Offset: 0x0006FD90
		public void dra()
		{
			if (this.skeletonAnimation != null)
			{
				this.skeletonAnimation.OnAnimationRebuild -= this.dqk;
			}
			if (this.izt != null)
			{
				this.izt.Event -= this.dqo;
				this.izt = null;
			}
			ge ge = this.izs;
			if (ge != null)
			{
				ge.dph();
			}
			this.izs = null;
			gf gf = this.izr;
			if (gf != null)
			{
				gf.dps();
			}
			this.izr = null;
			foreach (KeyValuePair<IntPtr, RemoteWaifuView> keyValuePair in RemoteWaifuView.izo)
			{
				if (keyValuePair.Value == this)
				{
					RemoteWaifuView remoteWaifuView;
					RemoteWaifuView.izo.TryRemove(keyValuePair.Key, out remoteWaifuView);
				}
			}
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00071CDD File Offset: 0x0006FEDD
		[CompilerGenerated]
		private void drb(EventInstance a)
		{
			RemoteWaifuView.izo[a.handle] = this;
		}

		// Token: 0x04000B81 RID: 2945
		[SerializeField]
		public SkeletonAnimation skeletonAnimation;

		// Token: 0x04000B82 RID: 2946
		private const int izk = 0;

		// Token: 0x04000B83 RID: 2947
		private const int izl = 5;

		// Token: 0x04000B84 RID: 2948
		private const string izm = "Effect_Push";

		// Token: 0x04000B85 RID: 2949
		private const string izn = "Sound_Push";

		// Token: 0x04000B86 RID: 2950
		private static readonly ConcurrentDictionary<IntPtr, RemoteWaifuView> izo = new ConcurrentDictionary<IntPtr, RemoteWaifuView>();

		// Token: 0x04000B87 RID: 2951
		private static readonly EVENT_CALLBACK izp = new EVENT_CALLBACK(RemoteWaifuView.dqi);

		// Token: 0x04000B88 RID: 2952
		private readonly ConcurrentQueue<string> izq = new ConcurrentQueue<string>();

		// Token: 0x04000B89 RID: 2953
		private gf izr;

		// Token: 0x04000B8A RID: 2954
		private ge izs;

		// Token: 0x04000B8B RID: 2955
		private global::Spine.AnimationState izt;

		// Token: 0x04000B8C RID: 2956
		private SkeletonDataAsset izu;

		// Token: 0x04000B8D RID: 2957
		private int izv;

		// Token: 0x04000B8E RID: 2958
		private bool izw = true;

		// Token: 0x04000B8F RID: 2959
		private bool izx;

		// Token: 0x04000B90 RID: 2960
		private ulong izy;

		// Token: 0x04000B91 RID: 2961
		private int izz;

		// Token: 0x04000B92 RID: 2962
		private float jaa;

		// Token: 0x04000B93 RID: 2963
		private ClothingSet jab;

		// Token: 0x04000B94 RID: 2964
		private bool jac;

		// Token: 0x04000B95 RID: 2965
		private int jad = -1;

		// Token: 0x04000B96 RID: 2966
		private int jae = int.MinValue;

		// Token: 0x04000B97 RID: 2967
		private bool jaf;

		// Token: 0x04000B98 RID: 2968
		private int jag = -1;

		// Token: 0x04000B99 RID: 2969
		private const int jah = 6;

		// Token: 0x04000B9A RID: 2970
		private const float jai = 1f;

		// Token: 0x04000B9B RID: 2971
		private const int jaj = 10;

		// Token: 0x04000B9C RID: 2972
		private int jak = -1;

		// Token: 0x04000B9D RID: 2973
		private TrackEntry jal;

		// Token: 0x04000B9E RID: 2974
		private const float jam = 0.05f;

		// Token: 0x04000B9F RID: 2975
		private float jan = float.NegativeInfinity;
	}
}
