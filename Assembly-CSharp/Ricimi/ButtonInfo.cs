using System;
using UnityEngine.UI;

namespace Ricimi
{
	// Token: 0x0200024A RID: 586
	[Serializable]
	public class ButtonInfo
	{
		// Token: 0x04001220 RID: 4640
		public string Label;

		// Token: 0x04001221 RID: 4641
		public bool ClosePopupWhenClicked;

		// Token: 0x04001222 RID: 4642
		public bool IgnoreButtonClickedEvent;

		// Token: 0x04001223 RID: 4643
		public Button.ButtonClickedEvent OnClickedEvent;
	}
}
