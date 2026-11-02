using System;
using UnityEngine;

// Token: 0x02000267 RID: 615
public class lq : MonoBehaviour
{
	// Token: 0x0600269D RID: 9885 RVA: 0x000A2CA8 File Offset: 0x000A0EA8
	private void ftu()
	{
		Quaternion quaternion = Quaternion.Euler(2952f, Time.time * this.angularVelocity, -7217f);
		base.transform.localRotation = this.kjs * quaternion;
	}

	// Token: 0x0600269E RID: 9886 RVA: 0x000A2CE8 File Offset: 0x000A0EE8
	private void Update()
	{
		Quaternion quaternion = Quaternion.Euler(0f, Time.time * this.angularVelocity, 0f);
		base.transform.localRotation = this.kjs * quaternion;
	}

	// Token: 0x0600269F RID: 9887 RVA: 0x000A2D28 File Offset: 0x000A0F28
	private void wd()
	{
		this.kjs = base.transform.localRotation;
	}

	// Token: 0x060026A0 RID: 9888 RVA: 0x000A2D28 File Offset: 0x000A0F28
	private void Start()
	{
		this.kjs = base.transform.localRotation;
	}

	// Token: 0x060026A2 RID: 9890 RVA: 0x000A2D5C File Offset: 0x000A0F5C
	private void nzj()
	{
		Quaternion quaternion = Quaternion.Euler(-3124f, Time.time * this.angularVelocity, 593f);
		base.transform.localRotation = this.kjs * quaternion;
	}

	// Token: 0x060026A3 RID: 9891 RVA: 0x000A2D28 File Offset: 0x000A0F28
	private void bok()
	{
		this.kjs = base.transform.localRotation;
	}

	// Token: 0x040012BA RID: 4794
	public float angularVelocity = 90f;

	// Token: 0x040012BB RID: 4795
	private Vector3 kjr = Vector3.up;

	// Token: 0x040012BC RID: 4796
	private Quaternion kjs;
}
