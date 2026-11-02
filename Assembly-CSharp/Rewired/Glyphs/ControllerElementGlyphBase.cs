using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

namespace Rewired.Glyphs
{
	// Token: 0x020001BD RID: 445
	public abstract class ControllerElementGlyphBase : MonoBehaviour
	{
		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001D7D RID: 7549 RVA: 0x00085772 File Offset: 0x00083972
		// (set) Token: 0x06001D7E RID: 7550 RVA: 0x0008577A File Offset: 0x0008397A
		public virtual GameObject lsf
		{
			get
			{
				return this._glyphOrTextPrefab;
			}
			set
			{
				this._glyphOrTextPrefab = value;
				this.faf();
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x00085789 File Offset: 0x00083989
		// (set) Token: 0x06001D80 RID: 7552 RVA: 0x00085791 File Offset: 0x00083991
		public virtual ControllerElementGlyphBase.AllowedTypes lsg
		{
			get
			{
				return this._allowedTypes;
			}
			set
			{
				this._allowedTypes = value;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x0008579A File Offset: 0x0008399A
		protected List<ControllerElementGlyphBase.ia> lsh
		{
			get
			{
				return this.jvc;
			}
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x00005090 File Offset: 0x00003290
		protected virtual void Awake()
		{
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x00005090 File Offset: 0x00003290
		protected virtual void Start()
		{
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x00005090 File Offset: 0x00003290
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x00005090 File Offset: 0x00003290
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x00005090 File Offset: 0x00003290
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x000857A2 File Offset: 0x000839A2
		protected virtual void Update()
		{
			if (!ReInput.isReady)
			{
				return;
			}
			if (this.jve != this.fap())
			{
				this.jve = this.fap();
				this.faf();
			}
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x000857D1 File Offset: 0x000839D1
		public virtual void faf()
		{
			this.fag();
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x000857DC File Offset: 0x000839DC
		protected virtual void fag()
		{
			for (int i = 0; i < this.jvc.Count; i++)
			{
				if (this.jvc[i] != null)
				{
					this.jvc[i].ezz();
				}
			}
			this.jvc.Clear();
			this.fao();
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x00085830 File Offset: 0x00083A30
		protected virtual void fah()
		{
			for (int i = 0; i < this.jvc.Count; i++)
			{
				if (this.jvc[i] != null)
				{
					this.jvc[i].ezy();
				}
			}
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x00085872 File Offset: 0x00083A72
		protected virtual void fai(Transform a)
		{
			this.faj(a, this.jvc);
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x00085884 File Offset: 0x00083A84
		protected virtual void faj(Transform a, List<ControllerElementGlyphBase.ia> b)
		{
			if (a == base.transform)
			{
				return;
			}
			bool flag = false;
			for (int i = 0; i < b.Count; i++)
			{
				if (b[i].lsd)
				{
					flag = true;
				}
			}
			if (a.gameObject.activeSelf != flag)
			{
				a.gameObject.SetActive(flag);
			}
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x000858E0 File Offset: 0x00083AE0
		protected virtual int fak(ActionElementMap a, Transform b, List<ControllerElementGlyphBase.ia> c)
		{
			this.jvd.Clear();
			int num = 0;
			if (this.fas(ControllerElementGlyphBase.AllowedTypes.Glyphs) && ControllerElementGlyphBase.fat(a, this.jvd) > 0)
			{
				if (!this.far(b, c, this.jvd.Count))
				{
					return 0;
				}
				for (int i = 0; i < this.jvd.Count; i++)
				{
					c[i].ezv(this.jvd[i]);
				}
				num += this.jvd.Count;
			}
			else if (this.fas(ControllerElementGlyphBase.AllowedTypes.Text) && a != null)
			{
				if (!this.far(b, c, 1))
				{
					return 0;
				}
				c[0].ezw(a.elementIdentifierName);
				num++;
			}
			return num;
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x00085997 File Offset: 0x00083B97
		protected virtual int fal(ActionElementMap a)
		{
			return this.fak(a, base.transform, this.jvc);
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x000859AC File Offset: 0x00083BAC
		protected virtual int fam(ControllerElementIdentifier a, AxisRange b, Transform c, List<ControllerElementGlyphBase.ia> d)
		{
			if (a == null)
			{
				return 0;
			}
			int num = 0;
			object glyph;
			if (this.fas(ControllerElementGlyphBase.AllowedTypes.Glyphs) && (glyph = a.GetGlyph(b)) != null)
			{
				if (!this.far(c, d, 1))
				{
					return 0;
				}
				d[0].ezv(glyph);
				num++;
			}
			else if (this.fas(ControllerElementGlyphBase.AllowedTypes.Text))
			{
				if (!this.far(c, d, 1))
				{
					return 0;
				}
				d[0].ezw(a.GetDisplayName(b));
				num++;
			}
			return num;
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00085A26 File Offset: 0x00083C26
		protected virtual int fan(ControllerElementIdentifier a, AxisRange b)
		{
			return this.fam(a, b, base.transform, this.jvc);
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00085A3C File Offset: 0x00083C3C
		protected virtual void fao()
		{
			for (int i = 0; i < this.jvc.Count; i++)
			{
				if (this.jvc[i] != null)
				{
					this.jvc[i].ezx();
				}
			}
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x00085A7E File Offset: 0x00083C7E
		protected virtual GameObject fap()
		{
			if (!(this._glyphOrTextPrefab != null))
			{
				return this.faq();
			}
			return this._glyphOrTextPrefab;
		}

		// Token: 0x06001D93 RID: 7571
		protected abstract GameObject faq();

		// Token: 0x06001D94 RID: 7572 RVA: 0x00085A9C File Offset: 0x00083C9C
		protected virtual bool far(Transform a, List<ControllerElementGlyphBase.ia> b, int c)
		{
			if (c <= 0)
			{
				return false;
			}
			GameObject gameObject = this.fap();
			if (gameObject == null)
			{
				Debug.LogError(a.eox());
				return false;
			}
			if (b == null)
			{
				return false;
			}
			for (int i = b.Count; i < c; i++)
			{
				GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject);
				gameObject2.name = a.eoy();
				gameObject2.hideFlags = HideFlags.DontSave;
				gameObject2.transform.SetParent(a, false);
				ib component = gameObject2.GetComponent<ib>();
				if (component == null)
				{
					string text = a.eoz();
					Type typeFromHandle = typeof(ib);
					Debug.LogError(text + ((typeFromHandle != null) ? typeFromHandle.ToString() : null) + a.epa());
					global::UnityEngine.Object.Destroy(gameObject2);
				}
				else
				{
					ControllerElementGlyphBase.ia ia = new ControllerElementGlyphBase.ia(component);
					b.Add(ia);
					if (b != this.jvc)
					{
						this.jvc.Add(ia);
					}
				}
			}
			return true;
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x00085B77 File Offset: 0x00083D77
		protected virtual bool fas(ControllerElementGlyphBase.AllowedTypes a)
		{
			return this._allowedTypes == ControllerElementGlyphBase.AllowedTypes.All || a == this._allowedTypes;
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00085B8C File Offset: 0x00083D8C
		protected static int fat(ActionElementMap a, List<object> b)
		{
			if (a == null)
			{
				return 0;
			}
			int num = 1;
			if (a.hasModifiers)
			{
				if (a.modifierKey1 != ModifierKey.None)
				{
					num++;
				}
				if (a.modifierKey2 != ModifierKey.None)
				{
					num++;
				}
				if (a.modifierKey3 != ModifierKey.None)
				{
					num++;
				}
			}
			if (a.elementIdentifierGlyphCount != num)
			{
				return 0;
			}
			a.GetElementIdentifierGlyphs(b);
			return num;
		}

		// Token: 0x04000F37 RID: 3895
		[SerializeField]
		private GameObject _glyphOrTextPrefab;

		// Token: 0x04000F38 RID: 3896
		[SerializeField]
		private ControllerElementGlyphBase.AllowedTypes _allowedTypes;

		// Token: 0x04000F39 RID: 3897
		[NonSerialized]
		private readonly List<ControllerElementGlyphBase.ia> jvc = new List<ControllerElementGlyphBase.ia>();

		// Token: 0x04000F3A RID: 3898
		[NonSerialized]
		private List<object> jvd = new List<object>();

		// Token: 0x04000F3B RID: 3899
		[NonSerialized]
		private GameObject jve;

		// Token: 0x020001BE RID: 446
		protected class ia
		{
			// Token: 0x17000413 RID: 1043
			// (get) Token: 0x06001D98 RID: 7576 RVA: 0x00085BFE File Offset: 0x00083DFE
			// (set) Token: 0x06001D99 RID: 7577 RVA: 0x00085C06 File Offset: 0x00083E06
			public virtual bool lsd
			{
				get
				{
					return this.jvb;
				}
				protected set
				{
					this.jvb = value;
				}
			}

			// Token: 0x17000414 RID: 1044
			// (get) Token: 0x06001D9A RID: 7578 RVA: 0x00085C0F File Offset: 0x00083E0F
			// (set) Token: 0x06001D9B RID: 7579 RVA: 0x00085C17 File Offset: 0x00083E17
			public ib lse
			{
				get
				{
					return this.juz;
				}
				set
				{
					this.juz = value;
				}
			}

			// Token: 0x06001D9C RID: 7580 RVA: 0x00085C20 File Offset: 0x00083E20
			public ia(ib a)
			{
				this.juz = a;
			}

			// Token: 0x06001D9D RID: 7581 RVA: 0x00085C2F File Offset: 0x00083E2F
			public virtual void ezv(object a)
			{
				if (this.juz == null)
				{
					return;
				}
				this.juz.fbm(a);
				this.jva = Time.frameCount;
				this.jvb = true;
			}

			// Token: 0x06001D9E RID: 7582 RVA: 0x00085C5E File Offset: 0x00083E5E
			public virtual void ezw(string a)
			{
				if (this.juz == null)
				{
					return;
				}
				this.juz.fbl(a);
				this.jva = Time.frameCount;
				this.jvb = true;
			}

			// Token: 0x06001D9F RID: 7583 RVA: 0x00085C8D File Offset: 0x00083E8D
			public virtual void ezx()
			{
				if (this.juz == null)
				{
					return;
				}
				if (!this.jvb)
				{
					return;
				}
				this.juz.fbn();
				this.jvb = false;
			}

			// Token: 0x06001DA0 RID: 7584 RVA: 0x00085CB9 File Offset: 0x00083EB9
			public virtual void ezy()
			{
				if (this.jva == Time.frameCount)
				{
					return;
				}
				this.ezx();
			}

			// Token: 0x06001DA1 RID: 7585 RVA: 0x00085CCF File Offset: 0x00083ECF
			public virtual void ezz()
			{
				if (this.juz == null)
				{
					return;
				}
				global::UnityEngine.Object.Destroy(this.juz.gameObject);
				this.juz = null;
				this.jvb = false;
			}

			// Token: 0x04000F3C RID: 3900
			private ib juz;

			// Token: 0x04000F3D RID: 3901
			private int jva;

			// Token: 0x04000F3E RID: 3902
			private bool jvb;
		}

		// Token: 0x020001BF RID: 447
		public enum AllowedTypes
		{
			// Token: 0x04000F40 RID: 3904
			All,
			// Token: 0x04000F41 RID: 3905
			Glyphs,
			// Token: 0x04000F42 RID: 3906
			Text
		}
	}
}
