using System;
using UnityEngine;

// Token: 0x020000C3 RID: 195
[DefaultExecutionOrder(-100)]
[DisallowMultipleComponent]
[RequireComponent(typeof(Camera))]
public sealed class FixedResolutionViewport : MonoBehaviour
{
	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0003B44E File Offset: 0x0003964E
	// (set) Token: 0x06000A1A RID: 2586 RVA: 0x0003B456 File Offset: 0x00039656
	public float icj { get; private set; }

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0003B45F File Offset: 0x0003965F
	public int krj
	{
		get
		{
			return this.referenceScreenHeight;
		}
	}

	// Token: 0x06000A1C RID: 2588 RVA: 0x0003B468 File Offset: 0x00039668
	private void Awake()
	{
		this.icm = base.GetComponent<Camera>();
		if (this.icm == null)
		{
			return;
		}
		this.icj = this.icm.fieldOfView;
		this.ick = Mathf.Tan(this.icj * 0.5f * 0.017453292f);
		this.cgq();
	}

	// Token: 0x06000A1D RID: 2589 RVA: 0x0003B4C4 File Offset: 0x000396C4
	private void OnEnable()
	{
		this.cgq();
	}

	// Token: 0x06000A1E RID: 2590 RVA: 0x0003B4CC File Offset: 0x000396CC
	private void LateUpdate()
	{
		if (Screen.height != this.icl)
		{
			this.cgq();
		}
	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x0003B4E4 File Offset: 0x000396E4
	private void cgq()
	{
		if (this.icm == null)
		{
			this.icm = base.GetComponent<Camera>();
		}
		if (this.icm == null || this.referenceScreenHeight <= 0)
		{
			return;
		}
		this.icl = Screen.height;
		float num = (float)this.icl / (float)this.referenceScreenHeight * this.ick;
		float num2 = 2f * Mathf.Atan(num);
		this.icm.fieldOfView = Mathf.Clamp(num2 * 57.29578f, 1f, 179f);
	}

	// Token: 0x06000A20 RID: 2592 RVA: 0x0003B574 File Offset: 0x00039774
	private void cgr()
	{
		if (this.icm == null)
		{
			this.icm = base.GetComponent<Camera>();
		}
		if (this.icm == null)
		{
			return;
		}
		this.icj = this.icm.fieldOfView;
		this.ick = Mathf.Tan(this.icj * 0.5f * 0.017453292f);
		this.icl = -1;
	}

	// Token: 0x04000829 RID: 2089
	[SerializeField]
	private int referenceScreenHeight = 1024;

	// Token: 0x0400082B RID: 2091
	private float ick;

	// Token: 0x0400082C RID: 2092
	private int icl = -1;

	// Token: 0x0400082D RID: 2093
	private Camera icm;
}
