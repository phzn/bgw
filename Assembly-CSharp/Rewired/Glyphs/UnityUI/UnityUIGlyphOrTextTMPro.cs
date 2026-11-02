using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Glyphs.UnityUI
{
	// Token: 0x020001D5 RID: 469
	public class UnityUIGlyphOrTextTMPro : GlyphOrTextBase<Image, Sprite, TMP_Text>
	{
		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x00087880 File Offset: 0x00085A80
		// (set) Token: 0x06001E2E RID: 7726 RVA: 0x000878A1 File Offset: 0x00085AA1
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

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x000878BE File Offset: 0x00085ABE
		// (set) Token: 0x06001E30 RID: 7728 RVA: 0x000878DB File Offset: 0x00085ADB
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
