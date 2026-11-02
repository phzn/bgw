using System;
using UnityEngine;
using UnityEngine.UI;

namespace Ricimi
{
	// Token: 0x0200024B RID: 587
	public class CircularProgressBar : MonoBehaviour
	{
		// Token: 0x06002559 RID: 9561 RVA: 0x0009C59A File Offset: 0x0009A79A
		private void Update()
		{
			this.gtl(this.Percentage);
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x0009C5A8 File Offset: 0x0009A7A8
		private void gtl(float a)
		{
			float num = a / 100f;
			this.progressImage.fillAmount = num;
			float num2 = num * 360f;
			this.progressEndContainer.localEulerAngles = new Vector3(0f, 0f, -num2);
			this.progressEndImage.localEulerAngles = new Vector3(0f, 0f, num2);
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x0009C608 File Offset: 0x0009A808
		public float gtm()
		{
			return this.progressImage.fillAmount;
		}

		// Token: 0x04001224 RID: 4644
		[Range(0f, 100f)]
		public float Percentage;

		// Token: 0x04001225 RID: 4645
		[SerializeField]
		private Image progressImage;

		// Token: 0x04001226 RID: 4646
		[SerializeField]
		private RectTransform progressEndContainer;

		// Token: 0x04001227 RID: 4647
		[SerializeField]
		private RectTransform progressEndImage;
	}
}
