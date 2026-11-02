using System;
using GlobalKeyboardHook;

// Token: 0x020000F5 RID: 245
public static class ev
{
	// Token: 0x06001258 RID: 4696 RVA: 0x0005AA1C File Offset: 0x00058C1C
	public static void nqf()
	{
		GlobalInputPoller.csf();
	}

	// Token: 0x06001259 RID: 4697 RVA: 0x0005AA23 File Offset: 0x00058C23
	public static void isl()
	{
		GlobalInputPoller.csg();
	}

	// Token: 0x14000026 RID: 38
	// (add) Token: 0x0600125E RID: 4702 RVA: 0x0005AAB8 File Offset: 0x00058CB8
	// (remove) Token: 0x0600125A RID: 4698 RVA: 0x0005AA2C File Offset: 0x00058C2C
	public static event ev.KeyPressedHandler ikw;

	// Token: 0x0600125B RID: 4699 RVA: 0x0005AA60 File Offset: 0x00058C60
	public static void cuz()
	{
		int num;
		while (GlobalInputPoller.csh(out num))
		{
			ev.KeyPressedHandler keyPressedHandler = ev.ikw;
			if (keyPressedHandler != null)
			{
				keyPressedHandler(num);
			}
		}
	}

	// Token: 0x0600125C RID: 4700 RVA: 0x0005AA8C File Offset: 0x00058C8C
	public static void csu()
	{
		int num;
		while (GlobalInputPoller.csh(out num))
		{
			ev.KeyPressedHandler keyPressedHandler = ev.ikw;
			if (keyPressedHandler != null)
			{
				keyPressedHandler(num);
			}
		}
	}

	// Token: 0x0600125D RID: 4701 RVA: 0x0005AA23 File Offset: 0x00058C23
	public static void nhu()
	{
		GlobalInputPoller.csg();
	}

	// Token: 0x0600125F RID: 4703 RVA: 0x0005AA1C File Offset: 0x00058C1C
	public static void css()
	{
		GlobalInputPoller.csf();
	}

	// Token: 0x06001260 RID: 4704 RVA: 0x0005AA23 File Offset: 0x00058C23
	public static void eyo()
	{
		GlobalInputPoller.csg();
	}

	// Token: 0x06001261 RID: 4705 RVA: 0x0005AA23 File Offset: 0x00058C23
	public static void igy()
	{
		GlobalInputPoller.csg();
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x06001262 RID: 4706 RVA: 0x0000FC31 File Offset: 0x0000DE31
	public static bool ksr
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06001263 RID: 4707 RVA: 0x0005AA1C File Offset: 0x00058C1C
	public static void gdx()
	{
		GlobalInputPoller.csf();
	}

	// Token: 0x06001264 RID: 4708 RVA: 0x0005AA23 File Offset: 0x00058C23
	public static void cst()
	{
		GlobalInputPoller.csg();
	}

	// Token: 0x020000F6 RID: 246
	// (Invoke) Token: 0x06001266 RID: 4710
	public delegate void KeyPressedHandler(int keyCode);
}
