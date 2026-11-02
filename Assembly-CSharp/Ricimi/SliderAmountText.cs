using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Ricimi
{
	// Token: 0x02000258 RID: 600
	[RequireComponent(typeof(TextMeshProUGUI))]
	public class SliderAmountText : MonoBehaviour
	{
		// Token: 0x060025BE RID: 9662 RVA: 0x0009DA31 File Offset: 0x0009BC31
		private void Awake()
		{
			this.khv = base.GetComponent<TextMeshProUGUI>();
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x0009DA3F File Offset: 0x0009BC3F
		private void Start()
		{
			this.slider.onValueChanged.AddListener(new UnityAction<float>(this.gud));
			this.gue(this.slider.value);
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x0009DA6E File Offset: 0x0009BC6E
		private void OnDestroy()
		{
			this.slider.onValueChanged.RemoveListener(new UnityAction<float>(this.gud));
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x0009DA8C File Offset: 0x0009BC8C
		private void gud(float a)
		{
			this.gue(a);
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x0009DA98 File Offset: 0x0009BC98
		private void gue(float a)
		{
			if (this.WholeNumber)
			{
				this.khv.text = string.Format(a.ezr(), (int)a, this.Suffix);
				return;
			}
			this.khv.text = string.Format(a.ezr(), Math.Round((double)a, 2), this.Suffix);
		}

		// Token: 0x0400125A RID: 4698
		[SerializeField]
		private Slider slider;

		// Token: 0x0400125B RID: 4699
		public string Suffix;

		// Token: 0x0400125C RID: 4700
		public bool WholeNumber = true;

		// Token: 0x0400125D RID: 4701
		private TextMeshProUGUI khv;
	}
}
