using System;
using System.Collections.Generic;
using System.Text;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Rewired.Interfaces;
using Rewired.Utils;
using UnityEngine;

namespace Rewired.Glyphs
{
	// Token: 0x020001C7 RID: 455
	public class GlyphProvider : MonoBehaviour, IGlyphProvider
	{
		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x00086067 File Offset: 0x00084267
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x0008606F File Offset: 0x0008426F
		public bool lss
		{
			get
			{
				return this._prefetch;
			}
			set
			{
				this._prefetch = value;
				if (base.isActiveAndEnabled && ReInput.isReady && ReInput.glyphs.glyphProvider == this)
				{
					ReInput.glyphs.prefetch = value;
				}
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x0008609F File Offset: 0x0008429F
		// (set) Token: 0x06001DCD RID: 7629 RVA: 0x000860A7 File Offset: 0x000842A7
		public List<GlyphSetCollection> lst
		{
			get
			{
				return this._glyphSetCollections;
			}
			set
			{
				this._glyphSetCollections = value;
				this.fcc();
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x000860B6 File Offset: 0x000842B6
		protected Dictionary<string, object> lsu
		{
			get
			{
				return this.jvg;
			}
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x000860BE File Offset: 0x000842BE
		protected virtual void OnEnable()
		{
			if (!this.jvh)
			{
				this.fcb();
			}
			this.fca();
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x000860D5 File Offset: 0x000842D5
		protected virtual void OnDisable()
		{
			if (ReInput.isReady && ReInput.glyphs.glyphProvider == this)
			{
				ReInput.glyphs.glyphProvider = null;
			}
			ReInput.InitializedEvent -= this.fca;
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00005090 File Offset: 0x00003290
		protected virtual void Update()
		{
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x00086108 File Offset: 0x00084308
		protected virtual void fca()
		{
			ReInput.InitializedEvent -= this.fca;
			ReInput.InitializedEvent += this.fca;
			if (!ReInput.isReady)
			{
				return;
			}
			if (!UnityTools.IsNullOrDestroyed<IGlyphProvider>(ReInput.glyphs.glyphProvider))
			{
				Debug.LogWarning(a.epd());
				return;
			}
			ReInput.glyphs.glyphProvider = this;
			ReInput.glyphs.prefetch = this._prefetch;
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x00086178 File Offset: 0x00084378
		protected virtual bool fcb()
		{
			this.jvh = false;
			if (this._glyphSetCollections == null)
			{
				return false;
			}
			this.jvg.Clear();
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < this._glyphSetCollections.Count; i++)
			{
				GlyphSetCollection glyphSetCollection = this._glyphSetCollections[i];
				if (!(glyphSetCollection == null))
				{
					foreach (GlyphSet glyphSet in glyphSetCollection.fcy())
					{
						if (!(glyphSet == null) && glyphSet.lsx != null)
						{
							int num = glyphSet.lsx.Length;
							for (int j = 0; j < num; j++)
							{
								if (!string.IsNullOrEmpty(glyphSet.lsx[j]))
								{
									int num2 = glyphSet.lsy;
									for (int k = 0; k < num2; k++)
									{
										GlyphSet.EntryBase entryBase = glyphSet.fcm(k);
										if (entryBase != null && !string.IsNullOrEmpty(entryBase.lsv) && entryBase.fcg() != null)
										{
											stringBuilder.Append(glyphSet.lsx[j]);
											stringBuilder.Append('/');
											stringBuilder.Append(entryBase.lsv);
											string text = stringBuilder.ToString();
											stringBuilder.Length = 0;
											if (this.jvg.ContainsKey(text))
											{
												Debug.LogError(a.epe() + text);
											}
											else
											{
												this.jvg.Add(text, entryBase.fcg());
											}
										}
									}
								}
							}
						}
					}
				}
			}
			this.jvh = true;
			return true;
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x00086338 File Offset: 0x00084538
		public void fcc()
		{
			this.fcb();
			if (base.isActiveAndEnabled && ReInput.isReady && ReInput.glyphs.glyphProvider == this)
			{
				ReInput.glyphs.Reload();
			}
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x00086367 File Offset: 0x00084567
		bool IGlyphProvider.fcd(string a, out object b)
		{
			if (!this.jvh)
			{
				b = null;
				return false;
			}
			return this.jvg.TryGetValue(a, out b);
		}

		// Token: 0x04000F50 RID: 3920
		[SerializeField]
		private bool _prefetch;

		// Token: 0x04000F51 RID: 3921
		[SerializeField]
		private List<GlyphSetCollection> _glyphSetCollections;

		// Token: 0x04000F52 RID: 3922
		[NonSerialized]
		private readonly Dictionary<string, object> jvg = new Dictionary<string, object>();

		// Token: 0x04000F53 RID: 3923
		[NonSerialized]
		private bool jvh;
	}
}
