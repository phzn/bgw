using System;
using UnityEngine;

// Token: 0x020000F7 RID: 247
public class ew : MonoBehaviour
{
	// Token: 0x06001269 RID: 4713 RVA: 0x0005AAEB File Offset: 0x00058CEB
	private void fhk()
	{
		if (ew.ikx != null && ew.ikx != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		ew.ikx = this;
	}

	// Token: 0x14000027 RID: 39
	// (add) Token: 0x0600126A RID: 4714 RVA: 0x0005AB1C File Offset: 0x00058D1C
	// (remove) Token: 0x0600126C RID: 4716 RVA: 0x0005AB84 File Offset: 0x00058D84
	public static event Action iky;

	// Token: 0x1400002A RID: 42
	// (add) Token: 0x06001271 RID: 4721 RVA: 0x0005AC54 File Offset: 0x00058E54
	// (remove) Token: 0x0600126B RID: 4715 RVA: 0x0005AB50 File Offset: 0x00058D50
	public static event Action<ushort> ilb;

	// Token: 0x14000028 RID: 40
	// (add) Token: 0x06001274 RID: 4724 RVA: 0x0005AC90 File Offset: 0x00058E90
	// (remove) Token: 0x0600126D RID: 4717 RVA: 0x0005ABB8 File Offset: 0x00058DB8
	public static event Action ikz;

	// Token: 0x0600126E RID: 4718 RVA: 0x0005AAEB File Offset: 0x00058CEB
	private void bpp()
	{
		if (ew.ikx != null && ew.ikx != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		ew.ikx = this;
	}

	// Token: 0x14000029 RID: 41
	// (add) Token: 0x06001270 RID: 4720 RVA: 0x0005AC20 File Offset: 0x00058E20
	// (remove) Token: 0x0600126F RID: 4719 RVA: 0x0005ABEC File Offset: 0x00058DEC
	public static event Action ila;

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x06001275 RID: 4725 RVA: 0x0005ACC3 File Offset: 0x00058EC3
	// (set) Token: 0x06001273 RID: 4723 RVA: 0x0005AC87 File Offset: 0x00058E87
	public static ew ikx { get; private set; }

	// Token: 0x06001276 RID: 4726 RVA: 0x0005AAEB File Offset: 0x00058CEB
	private void Awake()
	{
		if (ew.ikx != null && ew.ikx != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		ew.ikx = this;
	}
}
