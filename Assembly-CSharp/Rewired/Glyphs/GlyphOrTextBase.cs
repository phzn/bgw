using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

namespace Rewired.Glyphs
{
	// Token: 0x020001C6 RID: 454
	public abstract class GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent> : ib where TGlyphComponent : Behaviour where TGlyphGraphic : class where TTextComponent : Behaviour
	{
		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x00085DF7 File Offset: 0x00083FF7
		// (set) Token: 0x06001DC0 RID: 7616 RVA: 0x00085DFF File Offset: 0x00083FFF
		public TTextComponent lsp
		{
			get
			{
				return this._textComponent;
			}
			set
			{
				this._textComponent = value;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x00085E08 File Offset: 0x00084008
		// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x00085E10 File Offset: 0x00084010
		public TGlyphComponent lsq
		{
			get
			{
				return this._glyphComponent;
			}
			set
			{
				this._glyphComponent = value;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001DC3 RID: 7619
		// (set) Token: 0x06001DC4 RID: 7620
		protected abstract TGlyphGraphic lsr { get; set; }

		// Token: 0x06001DC5 RID: 7621 RVA: 0x00085E1C File Offset: 0x0008401C
		public override void fbl(string a)
		{
			if (this._textComponent == null)
			{
				return;
			}
			if (!string.Equals(this.lso, a, StringComparison.Ordinal))
			{
				this.lso = a;
			}
			if (!this._textComponent.gameObject.activeSelf)
			{
				this._textComponent.gameObject.SetActive(true);
				if (!base.gameObject.activeSelf)
				{
					base.gameObject.SetActive(true);
				}
			}
			this.fbo(ib.TypeFlags.Glyph);
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00085EA0 File Offset: 0x000840A0
		public override void fbm(object a)
		{
			if (a != null && !(a is TGlyphGraphic))
			{
				Debug.LogError(a.epb() + typeof(TGlyphGraphic).Name + a.epc());
				return;
			}
			this.fbm((TGlyphGraphic)((object)a));
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00085EE0 File Offset: 0x000840E0
		public virtual void fbm(TGlyphGraphic a)
		{
			if (this._glyphComponent == null)
			{
				return;
			}
			if (this.lsr != a)
			{
				this.lsr = a;
			}
			if (!this._glyphComponent.gameObject.activeSelf)
			{
				this._glyphComponent.gameObject.SetActive(true);
				if (!base.gameObject.activeSelf)
				{
					base.gameObject.SetActive(true);
				}
			}
			this.fbo(ib.TypeFlags.Text);
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00085F68 File Offset: 0x00084168
		protected override void fbo(ib.TypeFlags a)
		{
			if (this._textComponent != null && (a & ib.TypeFlags.Text) != ib.TypeFlags.None && this._textComponent.gameObject.activeSelf)
			{
				this._textComponent.gameObject.SetActive(false);
			}
			if (this._glyphComponent != null && (a & ib.TypeFlags.Glyph) != ib.TypeFlags.None && this._glyphComponent.gameObject.activeSelf)
			{
				this._glyphComponent.gameObject.SetActive(false);
			}
			if ((this._glyphComponent == null || !this._glyphComponent.gameObject.activeSelf) && (this._textComponent == null || !this._textComponent.gameObject.activeSelf))
			{
				base.gameObject.SetActive(false);
			}
		}

		// Token: 0x04000F4E RID: 3918
		[SerializeField]
		private TTextComponent _textComponent;

		// Token: 0x04000F4F RID: 3919
		[SerializeField]
		private TGlyphComponent _glyphComponent;
	}
}
