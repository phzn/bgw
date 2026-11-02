using System;
using TMPro;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000240 RID: 576
	public class UIGroup : MonoBehaviour
	{
		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060024F6 RID: 9462 RVA: 0x0009B36C File Offset: 0x0009956C
		// (set) Token: 0x060024F7 RID: 9463 RVA: 0x0009B38D File Offset: 0x0009958D
		public string mfv
		{
			get
			{
				if (!(this._label != null))
				{
					return string.Empty;
				}
				return this._label.text;
			}
			set
			{
				if (this._label == null)
				{
					return;
				}
				this._label.text = value;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060024F8 RID: 9464 RVA: 0x0009B3AA File Offset: 0x000995AA
		public Transform mfw
		{
			get
			{
				return this._content;
			}
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x0009B3B2 File Offset: 0x000995B2
		public void gqx(bool a)
		{
			if (this._label == null)
			{
				return;
			}
			this._label.gameObject.SetActive(a);
		}

		// Token: 0x04001201 RID: 4609
		[SerializeField]
		private TMP_Text _label;

		// Token: 0x04001202 RID: 4610
		[SerializeField]
		private Transform _content;
	}
}
