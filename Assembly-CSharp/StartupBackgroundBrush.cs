using System;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x020000C8 RID: 200
public static class StartupBackgroundBrush
{
	// Token: 0x06000A6D RID: 2669
	[DllImport("user32.dll")]
	private static extern IntPtr GetActiveWindow();

	// Token: 0x06000A6E RID: 2670
	[DllImport("user32.dll", EntryPoint = "SetClassLongPtrW", SetLastError = true)]
	private static extern IntPtr SetClassLongPtr64(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

	// Token: 0x06000A6F RID: 2671
	[DllImport("user32.dll", EntryPoint = "SetClassLongW", SetLastError = true)]
	private static extern IntPtr SetClassLong32(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

	// Token: 0x06000A70 RID: 2672
	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);

	// Token: 0x06000A71 RID: 2673
	[DllImport("gdi32.dll")]
	private static extern IntPtr CreateSolidBrush(uint crColor);

	// Token: 0x06000A72 RID: 2674 RVA: 0x0003D098 File Offset: 0x0003B298
	private static IntPtr che(IntPtr a, IntPtr b)
	{
		if (IntPtr.Size != 8)
		{
			return StartupBackgroundBrush.SetClassLong32(a, -10, b);
		}
		return StartupBackgroundBrush.SetClassLongPtr64(a, -10, b);
	}

	// Token: 0x06000A73 RID: 2675 RVA: 0x0003D0B8 File Offset: 0x0003B2B8
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void Apply()
	{
		IntPtr activeWindow = StartupBackgroundBrush.GetActiveWindow();
		if (activeWindow == IntPtr.Zero)
		{
			return;
		}
		IntPtr intPtr = StartupBackgroundBrush.CreateSolidBrush(0U);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		StartupBackgroundBrush.che(activeWindow, intPtr);
		StartupBackgroundBrush.InvalidateRect(activeWindow, IntPtr.Zero, true);
	}

	// Token: 0x04000844 RID: 2116
	private const int idh = -10;
}
