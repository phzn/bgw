using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

namespace Rewired.Glyphs
{
	// Token: 0x020001CB RID: 459
	[Serializable]
	public class GlyphSetCollection : ScriptableObject
	{
		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x000863DE File Offset: 0x000845DE
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x000863E6 File Offset: 0x000845E6
		public List<GlyphSet> ltb
		{
			get
			{
				return this._sets;
			}
			set
			{
				this._sets = value;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x000863EF File Offset: 0x000845EF
		// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x000863F7 File Offset: 0x000845F7
		public List<GlyphSetCollection> ltc
		{
			get
			{
				return this._collections;
			}
			set
			{
				if (value != null && value.Contains(this))
				{
					GlyphSetCollection.fda();
					Debug.LogWarning(a.epg());
					return;
				}
				this._collections = value;
			}
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x0008641C File Offset: 0x0008461C
		public virtual IEnumerable<GlyphSet> fcy()
		{
			return this.fcz(new List<GlyphSetCollection> { this });
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00086430 File Offset: 0x00084630
		protected virtual IEnumerable<GlyphSet> fcz(List<GlyphSetCollection> a)
		{
			if (a == null)
			{
				throw new ArgumentNullException(a.epf());
			}
			if (this._sets != null)
			{
				int count = this._sets.Count;
				int num;
				for (int i = 0; i < count; i = num + 1)
				{
					if (!(this._sets[i] == null))
					{
						yield return this.ltb[i];
					}
					num = i;
				}
			}
			if (this._collections != null)
			{
				int count2 = this._collections.Count;
				int num;
				for (int i = 0; i < count2; i = num + 1)
				{
					if (!(this._collections[i] == null))
					{
						if (a.Contains(this._collections[i]))
						{
							GlyphSetCollection.fda();
						}
						else
						{
							a.Add(this._collections[i]);
							foreach (GlyphSet glyphSet in this._collections[i].fcz(a))
							{
								yield return glyphSet;
							}
							IEnumerator<GlyphSet> enumerator = null;
						}
					}
					num = i;
				}
			}
			yield break;
			yield break;
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00086447 File Offset: 0x00084647
		private static void fda()
		{
			Debug.LogError(a.eph());
		}

		// Token: 0x04000F57 RID: 3927
		[SerializeField]
		private List<GlyphSet> _sets;

		// Token: 0x04000F58 RID: 3928
		[SerializeField]
		private List<GlyphSetCollection> _collections;
	}
}
