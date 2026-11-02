using System;
using UnityEngine;

namespace Rewired.Glyphs
{
	// Token: 0x020001C0 RID: 448
	[Serializable]
	public class ControllerElementGlyphSelectorOptions
	{
		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x00085CFE File Offset: 0x00083EFE
		// (set) Token: 0x06001DA3 RID: 7587 RVA: 0x00085D06 File Offset: 0x00083F06
		public bool lsi
		{
			get
			{
				return this._useLastActiveController;
			}
			set
			{
				this._useLastActiveController = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x00085D0F File Offset: 0x00083F0F
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x00085D17 File Offset: 0x00083F17
		public ControllerType[] lsj
		{
			get
			{
				return this._controllerTypeOrder;
			}
			set
			{
				this._controllerTypeOrder = value;
			}
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00085D20 File Offset: 0x00083F20
		public virtual bool fay(int a, out ControllerType b)
		{
			if (a >= this._controllerTypeOrder.Length)
			{
				b = ControllerType.Keyboard;
				return false;
			}
			b = this._controllerTypeOrder[a];
			return true;
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x00085D3D File Offset: 0x00083F3D
		// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x00085D57 File Offset: 0x00083F57
		public static ControllerElementGlyphSelectorOptions lsk
		{
			get
			{
				if (ControllerElementGlyphSelectorOptions.jvf == null)
				{
					return ControllerElementGlyphSelectorOptions.jvf = new ControllerElementGlyphSelectorOptions();
				}
				return ControllerElementGlyphSelectorOptions.jvf;
			}
			set
			{
				ControllerElementGlyphSelectorOptions.jvf = value;
			}
		}

		// Token: 0x04000F43 RID: 3907
		[SerializeField]
		private bool _useLastActiveController = true;

		// Token: 0x04000F44 RID: 3908
		[SerializeField]
		private ControllerType[] _controllerTypeOrder = new ControllerType[]
		{
			ControllerType.Joystick,
			ControllerType.Custom,
			ControllerType.Mouse,
			ControllerType.Keyboard
		};

		// Token: 0x04000F45 RID: 3909
		private static ControllerElementGlyphSelectorOptions jvf;
	}
}
