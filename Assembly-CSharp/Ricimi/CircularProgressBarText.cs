using System;
using TMPro;
using UnityEngine;

namespace Ricimi
{
	// Token: 0x0200024C RID: 588
	public class CircularProgressBarText : MonoBehaviour
	{
		// Token: 0x0600255D RID: 9565 RVA: 0x0009C615 File Offset: 0x0009A815
		private void Awake()
		{
			this.khi = base.GetComponent<TextMeshProUGUI>();
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x0009C624 File Offset: 0x0009A824
		private void Update()
		{
			this.khi.text = ((int)(this.progressBar.gtm() * 100f)).ToString();
		}

		// Token: 0x04001228 RID: 4648
		[SerializeField]
		private CircularProgressBar progressBar;

		// Token: 0x04001229 RID: 4649
		private TextMeshProUGUI khi;
	}
}
