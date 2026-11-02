using System;
using UnityEngine;

// Token: 0x02000269 RID: 617
public class lr
{
	// Token: 0x060026A5 RID: 9893 RVA: 0x000A2DA4 File Offset: 0x000A0FA4
	public static bool kyj(int a)
	{
		return Input.GetMouseButton(a);
	}

	// Token: 0x060026A6 RID: 9894 RVA: 0x000A2DAC File Offset: 0x000A0FAC
	public static bool gxk(int a)
	{
		return Input.GetMouseButtonUp(a);
	}

	// Token: 0x060026A7 RID: 9895 RVA: 0x000A2DB4 File Offset: 0x000A0FB4
	private static Vector3 ock()
	{
		return Input.mousePosition;
	}

	// Token: 0x060026A8 RID: 9896 RVA: 0x000A2DA4 File Offset: 0x000A0FA4
	public static bool gxi(int a)
	{
		return Input.GetMouseButton(a);
	}

	// Token: 0x060026A9 RID: 9897 RVA: 0x000A2DBB File Offset: 0x000A0FBB
	public static bool gxj(int a)
	{
		return Input.GetMouseButtonDown(a);
	}

	// Token: 0x060026AA RID: 9898 RVA: 0x000A2DAC File Offset: 0x000A0FAC
	public static bool fmt(int a)
	{
		return Input.GetMouseButtonUp(a);
	}

	// Token: 0x17000612 RID: 1554
	// (get) Token: 0x060026AB RID: 9899 RVA: 0x000A2DC3 File Offset: 0x000A0FC3
	public static Vector3 mgy
	{
		get
		{
			return lr.gxh();
		}
	}

	// Token: 0x060026AC RID: 9900 RVA: 0x000A2DB4 File Offset: 0x000A0FB4
	private static Vector3 gxh()
	{
		return Input.mousePosition;
	}

	// Token: 0x060026AD RID: 9901 RVA: 0x000A2DBB File Offset: 0x000A0FBB
	public static bool dki(int a)
	{
		return Input.GetMouseButtonDown(a);
	}

	// Token: 0x060026AF RID: 9903 RVA: 0x000A2DA4 File Offset: 0x000A0FA4
	public static bool khp(int a)
	{
		return Input.GetMouseButton(a);
	}

	// Token: 0x060026B0 RID: 9904 RVA: 0x000A2DCA File Offset: 0x000A0FCA
	public static bool gxg(string a)
	{
		return Input.GetKeyUp(a);
	}
}
