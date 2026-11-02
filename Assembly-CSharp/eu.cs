using System;
using GlobalKeyboardHook;

// Token: 0x020000F3 RID: 243
public static class eu
{
	// Token: 0x14000021 RID: 33
	// (add) Token: 0x06001243 RID: 4675 RVA: 0x0005A4D4 File Offset: 0x000586D4
	// (remove) Token: 0x06001226 RID: 4646 RVA: 0x00059FB4 File Offset: 0x000581B4
	public static event Action ijy;

	// Token: 0x14000020 RID: 32
	// (add) Token: 0x06001240 RID: 4672 RVA: 0x0005A3D8 File Offset: 0x000585D8
	// (remove) Token: 0x06001227 RID: 4647 RVA: 0x00059FE8 File Offset: 0x000581E8
	public static event Action ijx;

	// Token: 0x14000022 RID: 34
	// (add) Token: 0x0600122B RID: 4651 RVA: 0x0005A074 File Offset: 0x00058274
	// (remove) Token: 0x06001228 RID: 4648 RVA: 0x0005A01C File Offset: 0x0005821C
	public static event Action<int> ijz;

	// Token: 0x06001229 RID: 4649 RVA: 0x0005A04F File Offset: 0x0005824F
	private static void ktq()
	{
		Action action = eu.ijy;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x0600122A RID: 4650 RVA: 0x0005A060 File Offset: 0x00058260
	public static void csa()
	{
		ev.csu();
		ex.ctm();
		WinGlobalHotkey.ctr();
	}

	// Token: 0x0600122C RID: 4652 RVA: 0x0005A0A8 File Offset: 0x000582A8
	private static void hng(int a)
	{
		if (a == -65)
		{
			Action<int> action = eu.ijz;
			if (action == null)
			{
				return;
			}
			action(a);
			return;
		}
		else if (a == 98)
		{
			Action<int> action2 = eu.ika;
			if (action2 == null)
			{
				return;
			}
			action2(a);
			return;
		}
		else
		{
			if (a != 4)
			{
				if (a == 35)
				{
					Action<int> action3 = eu.ikc;
					if (action3 == null)
					{
						return;
					}
					action3(a);
				}
				return;
			}
			Action<int> action4 = eu.ikb;
			if (action4 == null)
			{
				return;
			}
			action4(a);
			return;
		}
	}

	// Token: 0x0600122D RID: 4653 RVA: 0x0005A10C File Offset: 0x0005830C
	public static void crz()
	{
		ev.ikw -= eu.csb;
		ev.cst();
		ex.ilc -= eu.csd;
		ex.ild -= eu.cse;
		ex.ctl();
		WinGlobalHotkey.ile -= eu.csc;
		WinGlobalHotkey.ctq();
	}

	// Token: 0x0600122E RID: 4654 RVA: 0x0005A16C File Offset: 0x0005836C
	private static void kcq()
	{
		Action<int> action = eu.ijw;
		if (action != null)
		{
			action(0);
		}
		Action action2 = eu.ijx;
		if (action2 == null)
		{
			return;
		}
		action2();
	}

	// Token: 0x14000023 RID: 35
	// (add) Token: 0x06001236 RID: 4662 RVA: 0x0005A2A4 File Offset: 0x000584A4
	// (remove) Token: 0x0600122F RID: 4655 RVA: 0x0005A190 File Offset: 0x00058390
	public static event Action<int> ika;

	// Token: 0x14000024 RID: 36
	// (add) Token: 0x06001230 RID: 4656 RVA: 0x0005A1C4 File Offset: 0x000583C4
	// (remove) Token: 0x06001245 RID: 4677 RVA: 0x0005A508 File Offset: 0x00058708
	public static event Action<int> ikb;

	// Token: 0x14000025 RID: 37
	// (add) Token: 0x06001231 RID: 4657 RVA: 0x0005A1F8 File Offset: 0x000583F8
	// (remove) Token: 0x0600123F RID: 4671 RVA: 0x0005A3A4 File Offset: 0x000585A4
	public static event Action<int> ikc;

	// Token: 0x06001232 RID: 4658 RVA: 0x0005A22B File Offset: 0x0005842B
	private static void csb(int a)
	{
		Action<int> action = eu.ijw;
		if (action == null)
		{
			return;
		}
		action(a);
	}

	// Token: 0x06001233 RID: 4659 RVA: 0x0005A240 File Offset: 0x00058440
	private static void kai(int a)
	{
		if (a == -17)
		{
			Action<int> action = eu.ijz;
			if (action == null)
			{
				return;
			}
			action(a);
			return;
		}
		else if (a == -65)
		{
			Action<int> action2 = eu.ika;
			if (action2 == null)
			{
				return;
			}
			action2(a);
			return;
		}
		else
		{
			if (a != -73)
			{
				if (a == 93)
				{
					Action<int> action3 = eu.ikc;
					if (action3 == null)
					{
						return;
					}
					action3(a);
				}
				return;
			}
			Action<int> action4 = eu.ikb;
			if (action4 == null)
			{
				return;
			}
			action4(a);
			return;
		}
	}

	// Token: 0x06001234 RID: 4660 RVA: 0x0005A16C File Offset: 0x0005836C
	private static void opv()
	{
		Action<int> action = eu.ijw;
		if (action != null)
		{
			action(0);
		}
		Action action2 = eu.ijx;
		if (action2 == null)
		{
			return;
		}
		action2();
	}

	// Token: 0x06001235 RID: 4661 RVA: 0x0005A22B File Offset: 0x0005842B
	private static void mhv(int a)
	{
		Action<int> action = eu.ijw;
		if (action == null)
		{
			return;
		}
		action(a);
	}

	// Token: 0x1400001F RID: 31
	// (add) Token: 0x0600123A RID: 4666 RVA: 0x0005A370 File Offset: 0x00058570
	// (remove) Token: 0x06001237 RID: 4663 RVA: 0x0005A2D8 File Offset: 0x000584D8
	public static event Action<int> ijw;

	// Token: 0x06001238 RID: 4664 RVA: 0x0005A04F File Offset: 0x0005824F
	private static void gtm()
	{
		Action action = eu.ijy;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06001239 RID: 4665 RVA: 0x0005A30C File Offset: 0x0005850C
	public static void cry(bool a = true)
	{
		ev.ikw += eu.csb;
		ev.css();
		ex.ilc += eu.csd;
		ex.ild += eu.cse;
		ex.ctk();
		if (a)
		{
			WinGlobalHotkey.ile += eu.csc;
			WinGlobalHotkey.ctp();
		}
	}

	// Token: 0x0600123B RID: 4667 RVA: 0x0005A16C File Offset: 0x0005836C
	private static void csd()
	{
		Action<int> action = eu.ijw;
		if (action != null)
		{
			action(0);
		}
		Action action2 = eu.ijx;
		if (action2 == null)
		{
			return;
		}
		action2();
	}

	// Token: 0x0600123C RID: 4668 RVA: 0x0005A04F File Offset: 0x0005824F
	private static void cse()
	{
		Action action = eu.ijy;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x0600123D RID: 4669 RVA: 0x0005A060 File Offset: 0x00058260
	public static void idc()
	{
		ev.csu();
		ex.ctm();
		WinGlobalHotkey.ctr();
	}

	// Token: 0x0600123E RID: 4670 RVA: 0x0005A22B File Offset: 0x0005842B
	private static void hdd(int a)
	{
		Action<int> action = eu.ijw;
		if (action == null)
		{
			return;
		}
		action(a);
	}

	// Token: 0x06001241 RID: 4673 RVA: 0x0005A40C File Offset: 0x0005860C
	private static void wo(int a)
	{
		if (a == -32)
		{
			Action<int> action = eu.ijz;
			if (action == null)
			{
				return;
			}
			action(a);
			return;
		}
		else if (a == 5)
		{
			Action<int> action2 = eu.ika;
			if (action2 == null)
			{
				return;
			}
			action2(a);
			return;
		}
		else
		{
			if (a != 44)
			{
				if (a == 34)
				{
					Action<int> action3 = eu.ikc;
					if (action3 == null)
					{
						return;
					}
					action3(a);
				}
				return;
			}
			Action<int> action4 = eu.ikb;
			if (action4 == null)
			{
				return;
			}
			action4(a);
			return;
		}
	}

	// Token: 0x06001242 RID: 4674 RVA: 0x0005A470 File Offset: 0x00058670
	private static void st(int a)
	{
		if (a == 96)
		{
			Action<int> action = eu.ijz;
			if (action == null)
			{
				return;
			}
			action(a);
			return;
		}
		else if (a == -11)
		{
			Action<int> action2 = eu.ika;
			if (action2 == null)
			{
				return;
			}
			action2(a);
			return;
		}
		else
		{
			if (a != -33)
			{
				if (a == 47)
				{
					Action<int> action3 = eu.ikc;
					if (action3 == null)
					{
						return;
					}
					action3(a);
				}
				return;
			}
			Action<int> action4 = eu.ikb;
			if (action4 == null)
			{
				return;
			}
			action4(a);
			return;
		}
	}

	// Token: 0x06001244 RID: 4676 RVA: 0x0005A16C File Offset: 0x0005836C
	private static void dyf()
	{
		Action<int> action = eu.ijw;
		if (action != null)
		{
			action(0);
		}
		Action action2 = eu.ijx;
		if (action2 == null)
		{
			return;
		}
		action2();
	}

	// Token: 0x06001246 RID: 4678 RVA: 0x0005A53C File Offset: 0x0005873C
	public static void gbh(bool a = true)
	{
		ev.ikw += eu.csb;
		ev.css();
		ex.ilc += eu.csd;
		ex.ild += eu.cse;
		ex.ctk();
		if (a)
		{
			WinGlobalHotkey.ile += eu.csc;
			WinGlobalHotkey.ctp();
		}
	}

	// Token: 0x06001247 RID: 4679 RVA: 0x0005A5A0 File Offset: 0x000587A0
	public static void mtn(bool a = true)
	{
		ev.ikw += eu.csb;
		ev.css();
		ex.ilc += eu.csd;
		ex.ild += eu.cse;
		ex.ctk();
		if (a)
		{
			WinGlobalHotkey.ile += eu.csc;
			WinGlobalHotkey.ctp();
		}
	}

	// Token: 0x06001248 RID: 4680 RVA: 0x0005A604 File Offset: 0x00058804
	private static void csc(int a)
	{
		if (a == 112)
		{
			Action<int> action = eu.ijz;
			if (action == null)
			{
				return;
			}
			action(a);
			return;
		}
		else if (a == 113)
		{
			Action<int> action2 = eu.ika;
			if (action2 == null)
			{
				return;
			}
			action2(a);
			return;
		}
		else
		{
			if (a != 114)
			{
				if (a == 120)
				{
					Action<int> action3 = eu.ikc;
					if (action3 == null)
					{
						return;
					}
					action3(a);
				}
				return;
			}
			Action<int> action4 = eu.ikb;
			if (action4 == null)
			{
				return;
			}
			action4(a);
			return;
		}
	}

	// Token: 0x06001249 RID: 4681 RVA: 0x0005A16C File Offset: 0x0005836C
	private static void eos()
	{
		Action<int> action = eu.ijw;
		if (action != null)
		{
			action(0);
		}
		Action action2 = eu.ijx;
		if (action2 == null)
		{
			return;
		}
		action2();
	}

	// Token: 0x04000976 RID: 2422
	private const int ikd = 112;

	// Token: 0x04000977 RID: 2423
	private const int ike = 113;

	// Token: 0x04000978 RID: 2424
	private const int ikf = 114;

	// Token: 0x04000979 RID: 2425
	private const int ikg = 120;
}
