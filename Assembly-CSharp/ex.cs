using System;
using GlobalKeyboardHook;

// Token: 0x020000F8 RID: 248
public static class ex
{
	// Token: 0x1400002C RID: 44
	// (add) Token: 0x06001277 RID: 4727 RVA: 0x0005ACCC File Offset: 0x00058ECC
	// (remove) Token: 0x0600127F RID: 4735 RVA: 0x0005AD9C File Offset: 0x00058F9C
	public static event ex.MouseEventHandler ild;

	// Token: 0x06001278 RID: 4728 RVA: 0x0005AA23 File Offset: 0x00058C23
	public static void lcw()
	{
		GlobalInputPoller.csg();
	}

	// Token: 0x06001279 RID: 4729 RVA: 0x0005AA23 File Offset: 0x00058C23
	public static void ctl()
	{
		GlobalInputPoller.csg();
	}

	// Token: 0x1400002B RID: 43
	// (add) Token: 0x0600127C RID: 4732 RVA: 0x0005AD68 File Offset: 0x00058F68
	// (remove) Token: 0x0600127A RID: 4730 RVA: 0x0005AD00 File Offset: 0x00058F00
	public static event ex.MouseEventHandler ilc;

	// Token: 0x0600127B RID: 4731 RVA: 0x0005AD33 File Offset: 0x00058F33
	public static void ctm()
	{
		while (GlobalInputPoller.csi())
		{
			ex.MouseEventHandler mouseEventHandler = ex.ilc;
			if (mouseEventHandler != null)
			{
				mouseEventHandler();
			}
		}
		while (GlobalInputPoller.csj())
		{
			ex.MouseEventHandler mouseEventHandler2 = ex.ild;
			if (mouseEventHandler2 != null)
			{
				mouseEventHandler2();
			}
		}
	}

	// Token: 0x0600127D RID: 4733 RVA: 0x0005AA1C File Offset: 0x00058C1C
	public static void ctk()
	{
		GlobalInputPoller.csf();
	}

	// Token: 0x0600127E RID: 4734 RVA: 0x0005AA23 File Offset: 0x00058C23
	public static void lmo()
	{
		GlobalInputPoller.csg();
	}

	// Token: 0x020000F9 RID: 249
	// (Invoke) Token: 0x06001281 RID: 4737
	public delegate void MouseEventHandler();
}
