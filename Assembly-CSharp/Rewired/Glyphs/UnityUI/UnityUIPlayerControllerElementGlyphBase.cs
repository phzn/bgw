using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

namespace Rewired.Glyphs.UnityUI
{
	// Token: 0x020001D7 RID: 471
	public abstract class UnityUIPlayerControllerElementGlyphBase : UnityUIControllerElementGlyphBase
	{
		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x000879DA File Offset: 0x00085BDA
		// (set) Token: 0x06001E3B RID: 7739 RVA: 0x000879E2 File Offset: 0x00085BE2
		public virtual ControllerElementGlyphSelectorOptionsSOBase ltj
		{
			get
			{
				return this._options;
			}
			set
			{
				this._options = value;
				this.faf();
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001E3C RID: 7740
		// (set) Token: 0x06001E3D RID: 7741
		public abstract int ltg { get; set; }

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001E3E RID: 7742
		// (set) Token: 0x06001E3F RID: 7743
		public abstract int lth { get; set; }

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x000879F1 File Offset: 0x00085BF1
		// (set) Token: 0x06001E41 RID: 7745 RVA: 0x000879F9 File Offset: 0x00085BF9
		public virtual AxisRange ltk
		{
			get
			{
				return this._actionRange;
			}
			set
			{
				this._actionRange = value;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x00087A02 File Offset: 0x00085C02
		// (set) Token: 0x06001E43 RID: 7747 RVA: 0x00087A0A File Offset: 0x00085C0A
		public virtual Transform ltl
		{
			get
			{
				return this._group1;
			}
			set
			{
				this._group1 = value;
				this.faf();
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001E44 RID: 7748 RVA: 0x00087A19 File Offset: 0x00085C19
		// (set) Token: 0x06001E45 RID: 7749 RVA: 0x00087A21 File Offset: 0x00085C21
		public virtual Transform ltm
		{
			get
			{
				return this._group2;
			}
			set
			{
				this._group2 = value;
				this.faf();
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x00087A30 File Offset: 0x00085C30
		protected virtual bool ltn
		{
			get
			{
				int num = 0;
				ControllerType controllerType;
				while (this.fej(num, out controllerType))
				{
					if (controllerType == ControllerType.Mouse)
					{
						return true;
					}
					if (controllerType == ControllerType.Keyboard)
					{
						return false;
					}
					num++;
				}
				return false;
			}
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00087A5C File Offset: 0x00085C5C
		protected virtual bool fej(int a, out ControllerType b)
		{
			return this.feo().fay(a, out b);
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x00087A6C File Offset: 0x00085C6C
		protected override void Update()
		{
			base.Update();
			if (!ReInput.isReady)
			{
				return;
			}
			ActionElementMap actionElementMap;
			ActionElementMap actionElementMap2;
			if (!ie.fdb(this.ltg, this.lth, this.ltk, this.feo(), this.jvw, out actionElementMap, out actionElementMap2))
			{
				this.fao();
				return;
			}
			if (actionElementMap != null && actionElementMap2 != null)
			{
				this.fel(actionElementMap, actionElementMap2);
				return;
			}
			if (actionElementMap != null)
			{
				this.fek(actionElementMap);
				return;
			}
			if (actionElementMap2 != null)
			{
				this.fek(actionElementMap2);
			}
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x00087ADE File Offset: 0x00085CDE
		protected override void fag()
		{
			this.jvy.Clear();
			this.jvz.Clear();
			base.fag();
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00087AFC File Offset: 0x00085CFC
		protected virtual bool fek(ActionElementMap a)
		{
			if (a == null)
			{
				return false;
			}
			int num = this.fak(a, this.fen(0), this.jvy);
			this.fah();
			return num > 0;
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00087B20 File Offset: 0x00085D20
		protected virtual bool fel(ActionElementMap a, ActionElementMap b)
		{
			if (a == null && b == null)
			{
				return false;
			}
			int num = 0;
			if (a != null && b != null)
			{
				this.jvx.Clear();
				this.jvx.Add(a);
				this.jvx.Add(b);
				num = this.fem(this.jvx, this.fen(0), this.jvy);
			}
			if (num == 0)
			{
				num += this.fak(a, this.fen(0), this.jvy);
				num += this.fak(b, this.fen(1), this.jvz);
			}
			this.fah();
			return num > 0;
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00087BB8 File Offset: 0x00085DB8
		protected override void fah()
		{
			base.fah();
			Transform transform = this.fen(0);
			Transform transform2 = this.fen(1);
			if (transform == transform2)
			{
				this.fai(transform);
				return;
			}
			this.faj(transform, this.jvy);
			this.faj(transform2, this.jvz);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00087C08 File Offset: 0x00085E08
		protected virtual int fem(IList<ActionElementMap> a, Transform b, List<ControllerElementGlyphBase.ia> c)
		{
			if (a == null)
			{
				return 0;
			}
			object obj;
			if (this.fas(ControllerElementGlyphBase.AllowedTypes.Glyphs) && ActionElementMap.TryGetCombinedElementIdentifierGlyph(a, out obj))
			{
				if (!this.far(b, c, 1))
				{
					return 0;
				}
				c[0].ezv(obj);
				return 1;
			}
			else
			{
				string text;
				if (!this.fas(ControllerElementGlyphBase.AllowedTypes.Text) || !ActionElementMap.TryGetCombinedElementIdentifierName(a, out text))
				{
					return 0;
				}
				if (!this.far(b, c, 1))
				{
					return 0;
				}
				c[0].ezw(text);
				return 1;
			}
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x00087C7C File Offset: 0x00085E7C
		protected override void fao()
		{
			base.fao();
			if (this._group1 != null && this._group1 != base.transform)
			{
				this._group1.gameObject.SetActive(false);
			}
			if (this._group2 != null && this._group2 != base.transform)
			{
				this._group2.gameObject.SetActive(false);
			}
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x00087CF4 File Offset: 0x00085EF4
		protected virtual Transform fen(int a)
		{
			if (a > 1)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (a != 0)
			{
				if (a != 1)
				{
					throw new NotImplementedException();
				}
				if (this._group1 == null)
				{
					return base.transform;
				}
				if (this._group2 != null)
				{
					return this._group2;
				}
				if (this._group1 != null)
				{
					return this._group1;
				}
				return base.transform;
			}
			else
			{
				if (!(this._group1 != null))
				{
					return base.transform;
				}
				return this._group1;
			}
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00087D7C File Offset: 0x00085F7C
		protected virtual ControllerElementGlyphSelectorOptions feo()
		{
			if (this._options != null && this._options.lsl == null)
			{
				Debug.LogError(a.epm() + typeof(ControllerElementGlyphSelectorOptions).Name + a.epn());
				return ControllerElementGlyphSelectorOptions.lsk;
			}
			if (!(this._options != null))
			{
				return ControllerElementGlyphSelectorOptions.lsk;
			}
			return this._options.lsl;
		}

		// Token: 0x04000F6A RID: 3946
		[SerializeField]
		private ControllerElementGlyphSelectorOptionsSOBase _options;

		// Token: 0x04000F6B RID: 3947
		[SerializeField]
		private AxisRange _actionRange;

		// Token: 0x04000F6C RID: 3948
		[SerializeField]
		private Transform _group1;

		// Token: 0x04000F6D RID: 3949
		[SerializeField]
		private Transform _group2;

		// Token: 0x04000F6E RID: 3950
		[NonSerialized]
		private List<ActionElementMap> jvw = new List<ActionElementMap>();

		// Token: 0x04000F6F RID: 3951
		[NonSerialized]
		private List<ActionElementMap> jvx = new List<ActionElementMap>();

		// Token: 0x04000F70 RID: 3952
		[NonSerialized]
		private readonly List<ControllerElementGlyphBase.ia> jvy = new List<ControllerElementGlyphBase.ia>();

		// Token: 0x04000F71 RID: 3953
		[NonSerialized]
		private readonly List<ControllerElementGlyphBase.ia> jvz = new List<ControllerElementGlyphBase.ia>();
	}
}
