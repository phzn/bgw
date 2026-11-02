using System;
using System.Collections.Generic;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Localization
{
	// Token: 0x020001BA RID: 442
	public class LocalizedStringProvider : LocalizedStringProviderBase
	{
		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x000854A9 File Offset: 0x000836A9
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x000854B1 File Offset: 0x000836B1
		protected virtual Dictionary<string, string> lrw
		{
			get
			{
				return this.juu;
			}
			set
			{
				this.juu = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x000854BA File Offset: 0x000836BA
		// (set) Token: 0x06001D63 RID: 7523 RVA: 0x000854C2 File Offset: 0x000836C2
		public virtual TextAsset lrx
		{
			get
			{
				return this._localizedStringsFile;
			}
			set
			{
				this._localizedStringsFile = value;
				this.ezj();
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x000854D1 File Offset: 0x000836D1
		protected override bool lry
		{
			get
			{
				return this.juv;
			}
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x000854D9 File Offset: 0x000836D9
		protected override bool eze()
		{
			this.juv = this.ezf();
			return this.juv;
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x000854F0 File Offset: 0x000836F0
		protected virtual bool ezf()
		{
			this.juu.Clear();
			if (this._localizedStringsFile != null)
			{
				try
				{
					this.juu = JsonParser.FromJson<Dictionary<string, string>>(this._localizedStringsFile.text);
				}
				catch (Exception ex)
				{
					Debug.LogError(ex);
				}
			}
			return this.juu.Count > 0;
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x00085554 File Offset: 0x00083754
		protected override bool TryGetLocalizedString(string key, out string result)
		{
			if (!this.juv)
			{
				result = null;
				return false;
			}
			return this.juu.TryGetValue(key, out result);
		}

		// Token: 0x04000F30 RID: 3888
		[SerializeField]
		private TextAsset _localizedStringsFile;

		// Token: 0x04000F31 RID: 3889
		[NonSerialized]
		private Dictionary<string, string> juu = new Dictionary<string, string>();

		// Token: 0x04000F32 RID: 3890
		[NonSerialized]
		private bool juv;
	}
}
