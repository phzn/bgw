using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

namespace Rewired.Glyphs.UnityUI
{
	// Token: 0x020001D6 RID: 470
	public class UnityUIPlayerControllerElementGlyph : UnityUIPlayerControllerElementGlyphBase
	{
		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x00087900 File Offset: 0x00085B00
		// (set) Token: 0x06001E33 RID: 7731 RVA: 0x00087908 File Offset: 0x00085B08
		public override int ltg
		{
			get
			{
				return this._playerId;
			}
			set
			{
				this._playerId = value;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x00087911 File Offset: 0x00085B11
		// (set) Token: 0x06001E35 RID: 7733 RVA: 0x00087928 File Offset: 0x00085B28
		public override int lth
		{
			get
			{
				if (!this.jvv)
				{
					this.fdz();
				}
				return this.jvu;
			}
			set
			{
				if (!ReInput.isReady)
				{
					return;
				}
				InputAction action = ReInput.mapping.GetAction(value);
				if (action == null)
				{
					Debug.LogError(a.epl() + value.ToString());
					return;
				}
				this._actionName = action.name;
				this.fdz();
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x00087975 File Offset: 0x00085B75
		// (set) Token: 0x06001E37 RID: 7735 RVA: 0x0008797D File Offset: 0x00085B7D
		public string lti
		{
			get
			{
				return this._actionName;
			}
			set
			{
				this._actionName = value;
				this.fdz();
			}
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x0008798C File Offset: 0x00085B8C
		private void fdz()
		{
			if (!ReInput.isReady)
			{
				return;
			}
			InputAction action = ReInput.mapping.GetAction(this._actionName);
			this.jvu = ((action != null) ? action.id : (-1));
			this.jvv = true;
		}

		// Token: 0x04000F66 RID: 3942
		[SerializeField]
		private int _playerId;

		// Token: 0x04000F67 RID: 3943
		[SerializeField]
		private string _actionName;

		// Token: 0x04000F68 RID: 3944
		[NonSerialized]
		private int jvu = -1;

		// Token: 0x04000F69 RID: 3945
		[NonSerialized]
		private bool jvv;
	}
}
