using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200023D RID: 573
	public class UIControlSet : MonoBehaviour
	{
		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060024E9 RID: 9449 RVA: 0x0009B118 File Offset: 0x00099318
		private Dictionary<int, kk> mfu
		{
			get
			{
				Dictionary<int, kk> dictionary;
				if ((dictionary = this.kgl) == null)
				{
					dictionary = (this.kgl = new Dictionary<int, kk>());
				}
				return dictionary;
			}
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x0009B13D File Offset: 0x0009933D
		public void gqp(string a)
		{
			if (this.title == null)
			{
				return;
			}
			this.title.text = a;
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x0009B15C File Offset: 0x0009935C
		public a gqq<a>(int a) where a : kk
		{
			kk kk;
			this.mfu.TryGetValue(a, out kk);
			return kk as a;
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x0009B184 File Offset: 0x00099384
		public kp gqr(GameObject a, Sprite b, float c, float d, Action<int, float> e, Action<int> f)
		{
			UIControlSet.kl kl = new UIControlSet.kl();
			kl.kgi = e;
			kl.kgk = f;
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(a);
			kl.kgj = gameObject.GetComponent<kp>();
			if (kl.kgj == null)
			{
				global::UnityEngine.Object.Destroy(gameObject);
				Debug.LogError(a.eym());
				return null;
			}
			gameObject.transform.SetParent(base.transform, false);
			if (kl.kgj.iconImage != null)
			{
				kl.kgj.iconImage.sprite = b;
			}
			if (kl.kgj.slider != null)
			{
				kl.kgj.slider.minValue = c;
				kl.kgj.slider.maxValue = d;
				if (kl.kgi != null)
				{
					kl.kgj.slider.onValueChanged.AddListener(new UnityAction<float>(kl.gqm));
				}
				if (kl.kgk != null)
				{
					kl.kgj.gqk(new Action(kl.gqn));
				}
			}
			this.mfu.Add(kl.kgj.mfs, kl.kgj);
			return kl.kgj;
		}

		// Token: 0x040011F8 RID: 4600
		[SerializeField]
		private TMP_Text title;

		// Token: 0x040011F9 RID: 4601
		private Dictionary<int, kk> kgl;

		// Token: 0x0200023E RID: 574
		[CompilerGenerated]
		private sealed class kl
		{
			// Token: 0x060024EF RID: 9455 RVA: 0x0009B2B0 File Offset: 0x000994B0
			internal void bmd(float a)
			{
				this.kgi(this.kgj.mfs, a);
			}

			// Token: 0x060024F0 RID: 9456 RVA: 0x0009B2C9 File Offset: 0x000994C9
			internal void gqn()
			{
				this.kgk(this.kgj.mfs);
			}

			// Token: 0x060024F1 RID: 9457 RVA: 0x0009B2B0 File Offset: 0x000994B0
			internal void gqm(float a)
			{
				this.kgi(this.kgj.mfs, a);
			}

			// Token: 0x040011FA RID: 4602
			public Action<int, float> kgi;

			// Token: 0x040011FB RID: 4603
			public kp kgj;

			// Token: 0x040011FC RID: 4604
			public Action<int> kgk;
		}
	}
}
