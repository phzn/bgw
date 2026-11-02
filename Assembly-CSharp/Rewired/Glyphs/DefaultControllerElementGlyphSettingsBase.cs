using System;
using UnityEngine;

namespace Rewired.Glyphs
{
	// Token: 0x020001C3 RID: 451
	public abstract class DefaultControllerElementGlyphSettingsBase : MonoBehaviour
	{
		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001DAE RID: 7598 RVA: 0x00085D9D File Offset: 0x00083F9D
		// (set) Token: 0x06001DAF RID: 7599 RVA: 0x00085DA5 File Offset: 0x00083FA5
		public ControllerElementGlyphSelectorOptions lsm
		{
			get
			{
				return this._options;
			}
			set
			{
				this._options = value;
				this.fbg();
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x00085DB4 File Offset: 0x00083FB4
		// (set) Token: 0x06001DB1 RID: 7601 RVA: 0x00085DBC File Offset: 0x00083FBC
		public GameObject lsn
		{
			get
			{
				return this._glyphOrTextPrefab;
			}
			set
			{
				this._glyphOrTextPrefab = value;
				this.fbg();
			}
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00085DCB File Offset: 0x00083FCB
		protected virtual void OnEnable()
		{
			this.fbg();
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00005090 File Offset: 0x00003290
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00085DD3 File Offset: 0x00083FD3
		protected virtual void fbg()
		{
			this.fbh();
			this.fbi();
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00085DE1 File Offset: 0x00083FE1
		protected virtual void fbh()
		{
			ControllerElementGlyphSelectorOptions.lsk = this.lsm;
		}

		// Token: 0x06001DB6 RID: 7606
		protected abstract void fbi();

		// Token: 0x04000F47 RID: 3911
		[SerializeField]
		private ControllerElementGlyphSelectorOptions _options;

		// Token: 0x04000F48 RID: 3912
		[SerializeField]
		private GameObject _glyphOrTextPrefab;
	}
}
