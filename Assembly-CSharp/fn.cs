using System;
using UnityEngine;

// Token: 0x02000114 RID: 276
public static class fn
{
	// Token: 0x1700010E RID: 270
	// (get) Token: 0x060013A8 RID: 5032 RVA: 0x00060C38 File Offset: 0x0005EE38
	public static int ktn
	{
		get
		{
			return fn.iqr.Length;
		}
	}

	// Token: 0x060013A9 RID: 5033 RVA: 0x00060C44 File Offset: 0x0005EE44
	public static Color daa(int a)
	{
		int num = fn.iqr.Length;
		int num2 = (a % num + num) % num;
		return fn.iqr[num2];
	}

	// Token: 0x04000A55 RID: 2645
	private static readonly Color[] iqr = new Color[]
	{
		new Color(0.902f, 0.294f, 0.235f),
		new Color(0.945f, 0.51f, 0.176f),
		new Color(0.949f, 0.769f, 0.216f),
		new Color(0.639f, 0.796f, 0.216f),
		new Color(0.302f, 0.714f, 0.4f),
		new Color(0.18f, 0.706f, 0.612f),
		new Color(0.204f, 0.706f, 0.808f),
		new Color(0.278f, 0.569f, 0.902f),
		new Color(0.243f, 0.412f, 0.816f),
		new Color(0.416f, 0.376f, 0.816f),
		new Color(0.612f, 0.353f, 0.788f),
		new Color(0.827f, 0.373f, 0.706f),
		new Color(0.933f, 0.416f, 0.541f),
		new Color(0.804f, 0.522f, 0.404f),
		new Color(0.545f, 0.616f, 0.671f),
		new Color(0.463f, 0.463f, 0.463f)
	};
}
