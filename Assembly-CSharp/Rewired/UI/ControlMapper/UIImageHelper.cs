using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000241 RID: 577
	[RequireComponent(typeof(Image))]
	public class UIImageHelper : MonoBehaviour
	{
		// Token: 0x060024FB RID: 9467 RVA: 0x0009B3D4 File Offset: 0x000995D4
		public void SetEnabledState(bool newState)
		{
			this.kgn = newState;
			UIImageHelper.State state = (newState ? this.enabledState : this.disabledState);
			if (state == null)
			{
				return;
			}
			Image component = base.gameObject.GetComponent<Image>();
			if (component == null)
			{
				Debug.LogError(a.eyn());
				return;
			}
			state.gqy(component);
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x0009B425 File Offset: 0x00099625
		public void gqz(Color a)
		{
			this.enabledState.color = a;
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x0009B433 File Offset: 0x00099633
		public void gra(Color a)
		{
			this.disabledState.color = a;
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x0009B444 File Offset: 0x00099644
		public void grb()
		{
			UIImageHelper.State state = (this.kgn ? this.enabledState : this.disabledState);
			Image component = base.gameObject.GetComponent<Image>();
			if (component == null)
			{
				return;
			}
			state.gqy(component);
		}

		// Token: 0x04001203 RID: 4611
		[SerializeField]
		private UIImageHelper.State enabledState;

		// Token: 0x04001204 RID: 4612
		[SerializeField]
		private UIImageHelper.State disabledState;

		// Token: 0x04001205 RID: 4613
		private bool kgn;

		// Token: 0x02000242 RID: 578
		[Serializable]
		private class State
		{
			// Token: 0x06002500 RID: 9472 RVA: 0x0009B485 File Offset: 0x00099685
			public void gqy(Image a)
			{
				if (a == null)
				{
					return;
				}
				a.color = this.color;
			}

			// Token: 0x04001206 RID: 4614
			[SerializeField]
			public Color color;
		}
	}
}
