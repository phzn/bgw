using System;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Glyphs.UnityUI
{
	// Token: 0x020001D4 RID: 468
	public class UnityUIGlyphOrText : GlyphOrTextBase<Image, Sprite, Text>
	{
		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x00087800 File Offset: 0x00085A00
		// (set) Token: 0x06001E29 RID: 7721 RVA: 0x00087821 File Offset: 0x00085A21
		protected override string lso
		{
			get
			{
				if (!(base.lsp != null))
				{
					return string.Empty;
				}
				return base.lsp.text;
			}
			set
			{
				if (base.lsp == null)
				{
					return;
				}
				base.lsp.text = value;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x0008783E File Offset: 0x00085A3E
		// (set) Token: 0x06001E2B RID: 7723 RVA: 0x0008785B File Offset: 0x00085A5B
		protected override Sprite lsr
		{
			get
			{
				if (!(base.lsq != null))
				{
					return null;
				}
				return base.lsq.sprite;
			}
			set
			{
				if (base.lsq == null)
				{
					return;
				}
				base.lsq.sprite = value;
			}
		}
	}
}
