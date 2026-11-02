using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	// Token: 0x020001B0 RID: 432
	public class RewiredEventSystem : EventSystem
	{
		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x00081FE8 File Offset: 0x000801E8
		// (set) Token: 0x06001C90 RID: 7312 RVA: 0x00081FF0 File Offset: 0x000801F0
		public bool lqf
		{
			get
			{
				return this._alwaysUpdate;
			}
			set
			{
				this._alwaysUpdate = value;
			}
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x00081FFC File Offset: 0x000801FC
		protected override void Update()
		{
			if (this.lqf)
			{
				EventSystem current = EventSystem.current;
				if (current != this)
				{
					EventSystem.current = this;
				}
				try
				{
					base.Update();
					return;
				}
				finally
				{
					if (current != this)
					{
						EventSystem.current = current;
					}
				}
			}
			base.Update();
		}

		// Token: 0x04000EEF RID: 3823
		[SerializeField]
		private bool _alwaysUpdate;
	}
}
