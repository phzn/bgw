using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

namespace Rewired.Glyphs
{
	// Token: 0x020001CE RID: 462
	[Serializable]
	public class SpriteGlyphSet : GlyphSet
	{
		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x0008752F File Offset: 0x0008572F
		// (set) Token: 0x06001E15 RID: 7701 RVA: 0x00087537 File Offset: 0x00085737
		public List<SpriteGlyphSet.Entry> ltd
		{
			get
			{
				return this._glyphs;
			}
			set
			{
				this._glyphs = value;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001E16 RID: 7702 RVA: 0x00087540 File Offset: 0x00085740
		public override int lsy
		{
			get
			{
				if (this._glyphs == null)
				{
					return 0;
				}
				return this._glyphs.Count;
			}
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00087557 File Offset: 0x00085757
		public override GlyphSet.EntryBase fcm(int a)
		{
			if (this._glyphs == null)
			{
				return null;
			}
			if (a >= this._glyphs.Count)
			{
				throw new ArgumentOutOfRangeException(a.epi());
			}
			return this._glyphs[a];
		}

		// Token: 0x04000F63 RID: 3939
		[SerializeField]
		private List<SpriteGlyphSet.Entry> _glyphs;

		// Token: 0x020001CF RID: 463
		[Serializable]
		public class Entry : GlyphSet.EntryBase<Sprite>
		{
		}
	}
}
