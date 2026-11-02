using System;
using UnityEngine;

namespace Rewired.Glyphs
{
	// Token: 0x020001C1 RID: 449
	[Serializable]
	public class ControllerElementGlyphSelectorOptionsSO : ControllerElementGlyphSelectorOptionsSOBase
	{
		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x00085D85 File Offset: 0x00083F85
		public override ControllerElementGlyphSelectorOptions lsl
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x04000F46 RID: 3910
		[SerializeField]
		private ControllerElementGlyphSelectorOptions _options;
	}
}
