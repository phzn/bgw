using System;
using Rewired.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020001F6 RID: 502
	[RequireComponent(typeof(CanvasScalerExt))]
	public class CanvasScalerFitter : MonoBehaviour
	{
		// Token: 0x06001FA3 RID: 8099 RVA: 0x0008C886 File Offset: 0x0008AA86
		private void OnEnable()
		{
			this.jzc = base.GetComponent<CanvasScalerExt>();
			this.Update();
			this.jzc.flf();
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x0008C8A5 File Offset: 0x0008AAA5
		private void Update()
		{
			if (Screen.width != this.jzd || Screen.height != this.jze)
			{
				this.jzd = Screen.width;
				this.jze = Screen.height;
				this.flg();
			}
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x0008C8E0 File Offset: 0x0008AAE0
		private void flg()
		{
			if (this.jzc.uiScaleMode != CanvasScaler.ScaleMode.ScaleWithScreenSize)
			{
				return;
			}
			if (this.breakPoints == null)
			{
				return;
			}
			float num = (float)Screen.width / (float)Screen.height;
			float num2 = float.PositiveInfinity;
			int num3 = 0;
			for (int i = 0; i < this.breakPoints.Length; i++)
			{
				float num4 = Mathf.Abs(num - this.breakPoints[i].screenAspectRatio);
				if ((num4 <= this.breakPoints[i].screenAspectRatio || MathTools.IsNear(this.breakPoints[i].screenAspectRatio, 0.01f)) && num4 < num2)
				{
					num2 = num4;
					num3 = i;
				}
			}
			this.jzc.referenceResolution = this.breakPoints[num3].referenceResolution;
		}

		// Token: 0x04000FF4 RID: 4084
		[SerializeField]
		private CanvasScalerFitter.BreakPoint[] breakPoints;

		// Token: 0x04000FF5 RID: 4085
		private CanvasScalerExt jzc;

		// Token: 0x04000FF6 RID: 4086
		private int jzd;

		// Token: 0x04000FF7 RID: 4087
		private int jze;

		// Token: 0x04000FF8 RID: 4088
		private Action jzf;

		// Token: 0x020001F7 RID: 503
		[Serializable]
		private class BreakPoint
		{
			// Token: 0x04000FF9 RID: 4089
			[SerializeField]
			public string name;

			// Token: 0x04000FFA RID: 4090
			[SerializeField]
			public float screenAspectRatio;

			// Token: 0x04000FFB RID: 4091
			[SerializeField]
			public Vector2 referenceResolution;
		}
	}
}
