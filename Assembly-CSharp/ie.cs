using System;
using System.Collections.Generic;
using Rewired;
using Rewired.Glyphs;

// Token: 0x020001CD RID: 461
public static class ie
{
	// Token: 0x06001DF8 RID: 7672 RVA: 0x00086740 File Offset: 0x00084940
	public static bool fdf(List<ActionElementMap> a, out ActionElementMap b, out ActionElementMap c)
	{
		b = null;
		c = null;
		int count = a.Count;
		int i = 0;
		while (i < count)
		{
			ActionElementMap actionElementMap = a[i];
			if (actionElementMap.elementType == ControllerElementType.Axis)
			{
				if (actionElementMap.axisType != AxisType.Normal)
				{
					if (actionElementMap.axisType != AxisType.None)
					{
						goto IL_003D;
					}
				}
			}
			else if (actionElementMap.elementType == ControllerElementType.Button)
			{
				goto IL_003D;
			}
			IL_0055:
			i++;
			continue;
			IL_003D:
			if (actionElementMap.axisContribution == Pole.Positive)
			{
				if (c == null)
				{
					c = actionElementMap;
					goto IL_0055;
				}
				goto IL_0055;
			}
			else
			{
				if (b == null)
				{
					b = actionElementMap;
					goto IL_0055;
				}
				goto IL_0055;
			}
		}
		return b != null || c != null;
	}

	// Token: 0x06001DF9 RID: 7673 RVA: 0x000867B8 File Offset: 0x000849B8
	public static ActionElementMap eao(List<ActionElementMap> a)
	{
		int count = a.Count;
		for (int i = 0; i < count; i++)
		{
			ActionElementMap actionElementMap = a[i];
			if (actionElementMap.elementType == ControllerElementType.Axis && actionElementMap.axisType == AxisType.Normal)
			{
				return actionElementMap;
			}
		}
		return null;
	}

	// Token: 0x06001DFA RID: 7674 RVA: 0x000867F4 File Offset: 0x000849F4
	public static bool qi(InputAction a, AxisRange b, List<ActionElementMap> c, out ActionElementMap d, out ActionElementMap e)
	{
		d = null;
		e = null;
		bool flag = a.type == InputActionType.Axis;
		int count = c.Count;
		for (int i = 0; i < count; i++)
		{
			if (flag)
			{
				if (b == AxisRange.Full)
				{
					ActionElementMap actionElementMap = ie.fdd(c);
					if (actionElementMap != null)
					{
						d = actionElementMap;
						return true;
					}
					ActionElementMap actionElementMap2;
					if (ie.fdf(c, out actionElementMap, out actionElementMap2))
					{
						d = actionElementMap;
						e = actionElementMap2;
						return true;
					}
				}
				else
				{
					ActionElementMap actionElementMap = ie.fde(c, b);
					if (actionElementMap != null)
					{
						d = actionElementMap;
						return true;
					}
				}
			}
			else
			{
				ActionElementMap actionElementMap = ie.fde(c, b);
				if (actionElementMap != null)
				{
					d = actionElementMap;
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001DFB RID: 7675 RVA: 0x00086874 File Offset: 0x00084A74
	private static int fdh(Player a, ControllerType b, int c, int d, bool e, List<ActionElementMap> f)
	{
		int count = f.Count;
		a.controllers.maps.GetElementMapsWithAction(b, c, d, e, f);
		ie.fdk(a, f, count);
		return f.Count - count;
	}

	// Token: 0x06001DFC RID: 7676 RVA: 0x000868B4 File Offset: 0x00084AB4
	public static bool eap(int a, int b, AxisRange c, ControllerElementGlyphSelectorOptions d, List<ActionElementMap> e, out ActionElementMap f, out ActionElementMap g)
	{
		f = null;
		g = null;
		if (!ReInput.isReady)
		{
			return false;
		}
		if (d == null)
		{
			return false;
		}
		if (e == null)
		{
			return false;
		}
		InputAction action = ReInput.mapping.GetAction(b);
		if (action == null)
		{
			return false;
		}
		Player player = ReInput.players.GetPlayer(a);
		if (player == null)
		{
			return false;
		}
		Controller controller = player.controllers.GetLastActiveController();
		e.Clear();
		if (d.lsi && controller != null)
		{
			Controller controller2 = null;
			if (controller.type == ControllerType.Keyboard || controller.type == ControllerType.Mouse)
			{
				if (ie.fdg(d))
				{
					if (ReInput.controllers.Mouse.enabled && player.controllers.hasMouse)
					{
						controller = ReInput.controllers.Mouse;
						controller2 = ReInput.controllers.Keyboard;
					}
				}
				else if (ReInput.controllers.Keyboard.enabled && player.controllers.hasKeyboard)
				{
					controller = ReInput.controllers.Keyboard;
					controller2 = ReInput.controllers.Mouse;
				}
			}
			if (ie.fdh(player, controller.type, controller.id, b, true, e) > 0 && ie.fdc(action, c, e, out f, out g))
			{
				return true;
			}
			if (controller2 != null && ie.fdh(player, controller2.type, controller2.id, b, true, e) > 0 && ie.fdc(action, c, e, out f, out g))
			{
				return true;
			}
			if (ie.fdi(player, controller.type, b, true, e) > 0 && ie.fdc(action, c, e, out f, out g))
			{
				return true;
			}
		}
		int num = 0;
		ControllerType controllerType;
		while (d.fay(num, out controllerType))
		{
			if (ie.fdi(player, controllerType, b, true, e) > 0 && ie.fdc(action, c, e, out f, out g))
			{
				return true;
			}
			num++;
		}
		return ie.fdj(player, b, true, e) > 0 && ie.fdc(action, c, e, out f, out g);
	}

	// Token: 0x06001DFD RID: 7677 RVA: 0x00086A7C File Offset: 0x00084C7C
	private static int kju(Player a, ControllerType b, int c, bool d, List<ActionElementMap> e)
	{
		int count = e.Count;
		a.controllers.maps.GetElementMapsWithAction(b, c, d, e);
		ie.fdk(a, e, count);
		return e.Count - count;
	}

	// Token: 0x06001DFE RID: 7678 RVA: 0x00086ABC File Offset: 0x00084CBC
	private static int kag(Player a, int b, bool c, List<ActionElementMap> d)
	{
		int count = d.Count;
		a.controllers.maps.GetElementMapsWithAction(b, c, d);
		ie.fdk(a, d, count);
		return d.Count - count;
	}

	// Token: 0x06001DFF RID: 7679 RVA: 0x00086AF8 File Offset: 0x00084CF8
	public static bool dho(List<ActionElementMap> a, out ActionElementMap b, out ActionElementMap c)
	{
		b = null;
		c = null;
		int count = a.Count;
		int i = 0;
		while (i < count)
		{
			ActionElementMap actionElementMap = a[i];
			if (actionElementMap.elementType == ControllerElementType.Axis)
			{
				if (actionElementMap.axisType != AxisType.Normal)
				{
					if (actionElementMap.axisType != AxisType.None)
					{
						goto IL_003D;
					}
				}
			}
			else if (actionElementMap.elementType == ControllerElementType.Button)
			{
				goto IL_003D;
			}
			IL_0055:
			i++;
			continue;
			IL_003D:
			if (actionElementMap.axisContribution == Pole.Positive)
			{
				if (c == null)
				{
					c = actionElementMap;
					goto IL_0055;
				}
				goto IL_0055;
			}
			else
			{
				if (b == null)
				{
					b = actionElementMap;
					goto IL_0055;
				}
				goto IL_0055;
			}
		}
		return b != null || c != null;
	}

	// Token: 0x06001E00 RID: 7680 RVA: 0x00086B70 File Offset: 0x00084D70
	private static int hky(Player a, List<ActionElementMap> b, int c)
	{
		int count = b.Count;
		for (int i = count - 1; i >= c; i--)
		{
			if (!a.controllers.ContainsController(b[i].controllerMap.controller) || !b[i].controllerMap.controller.enabled)
			{
				b.RemoveAt(i);
			}
		}
		return count - b.Count;
	}

	// Token: 0x06001E01 RID: 7681 RVA: 0x00086BD8 File Offset: 0x00084DD8
	private static int cfz(Player a, List<ActionElementMap> b, int c)
	{
		int count = b.Count;
		for (int i = count - 1; i >= c; i--)
		{
			if (!a.controllers.ContainsController(b[i].controllerMap.controller) || !b[i].controllerMap.controller.enabled)
			{
				b.RemoveAt(i);
			}
		}
		return count - b.Count;
	}

	// Token: 0x06001E02 RID: 7682 RVA: 0x00086C40 File Offset: 0x00084E40
	public static ActionElementMap mcy(List<ActionElementMap> a)
	{
		int count = a.Count;
		for (int i = 0; i < count; i++)
		{
			ActionElementMap actionElementMap = a[i];
			if (actionElementMap.elementType == ControllerElementType.Axis && actionElementMap.axisType == AxisType.Normal)
			{
				return actionElementMap;
			}
		}
		return null;
	}

	// Token: 0x06001E03 RID: 7683 RVA: 0x00086C7C File Offset: 0x00084E7C
	public static bool fto(int a, int b, AxisRange c, ControllerElementGlyphSelectorOptions d, List<ActionElementMap> e, out ActionElementMap f, out ActionElementMap g)
	{
		f = null;
		g = null;
		if (!ReInput.isReady)
		{
			return false;
		}
		if (d == null)
		{
			return false;
		}
		if (e == null)
		{
			return false;
		}
		InputAction action = ReInput.mapping.GetAction(b);
		if (action == null)
		{
			return false;
		}
		Player player = ReInput.players.GetPlayer(a);
		if (player == null)
		{
			return false;
		}
		Controller controller = player.controllers.GetLastActiveController();
		e.Clear();
		if (d.lsi && controller != null)
		{
			Controller controller2 = null;
			if (controller.type == ControllerType.Keyboard || controller.type == ControllerType.Mouse)
			{
				if (ie.fdg(d))
				{
					if (ReInput.controllers.Mouse.enabled && player.controllers.hasMouse)
					{
						controller = ReInput.controllers.Mouse;
						controller2 = ReInput.controllers.Keyboard;
					}
				}
				else if (ReInput.controllers.Keyboard.enabled && player.controllers.hasKeyboard)
				{
					controller = ReInput.controllers.Keyboard;
					controller2 = ReInput.controllers.Mouse;
				}
			}
			if (ie.fdh(player, controller.type, controller.id, b, true, e) > 0 && ie.fdc(action, c, e, out f, out g))
			{
				return true;
			}
			if (controller2 != null && ie.fdh(player, controller2.type, controller2.id, b, true, e) > 0 && ie.fdc(action, c, e, out f, out g))
			{
				return true;
			}
			if (ie.fdi(player, controller.type, b, true, e) > 0 && ie.fdc(action, c, e, out f, out g))
			{
				return true;
			}
		}
		int num = 0;
		ControllerType controllerType;
		while (d.fay(num, out controllerType))
		{
			if (ie.fdi(player, controllerType, b, true, e) > 0 && ie.fdc(action, c, e, out f, out g))
			{
				return true;
			}
			num++;
		}
		return ie.fdj(player, b, true, e) > 0 && ie.fdc(action, c, e, out f, out g);
	}

	// Token: 0x06001E04 RID: 7684 RVA: 0x00086E44 File Offset: 0x00085044
	private static int mjk(Player a, ControllerType b, int c, int d, bool e, List<ActionElementMap> f)
	{
		int count = f.Count;
		a.controllers.maps.GetElementMapsWithAction(b, c, d, e, f);
		ie.fdk(a, f, count);
		return f.Count - count;
	}

	// Token: 0x06001E05 RID: 7685 RVA: 0x00086E84 File Offset: 0x00085084
	public static bool fdg(ControllerElementGlyphSelectorOptions a)
	{
		if (a == null)
		{
			return false;
		}
		int num = 0;
		ControllerType controllerType;
		while (a.fay(num, out controllerType))
		{
			if (controllerType == ControllerType.Mouse)
			{
				return true;
			}
			if (controllerType == ControllerType.Keyboard)
			{
				return false;
			}
			num++;
		}
		return false;
	}

	// Token: 0x06001E06 RID: 7686 RVA: 0x00086EB8 File Offset: 0x000850B8
	public static bool fgu(List<ActionElementMap> a, out ActionElementMap b, out ActionElementMap c)
	{
		b = null;
		c = null;
		int count = a.Count;
		int i = 0;
		while (i < count)
		{
			ActionElementMap actionElementMap = a[i];
			if (actionElementMap.elementType == ControllerElementType.Axis)
			{
				if (actionElementMap.axisType != AxisType.Normal)
				{
					if (actionElementMap.axisType != AxisType.None)
					{
						goto IL_003D;
					}
				}
			}
			else if (actionElementMap.elementType == ControllerElementType.Button)
			{
				goto IL_003D;
			}
			IL_0055:
			i++;
			continue;
			IL_003D:
			if (actionElementMap.axisContribution == Pole.Positive)
			{
				if (c == null)
				{
					c = actionElementMap;
					goto IL_0055;
				}
				goto IL_0055;
			}
			else
			{
				if (b == null)
				{
					b = actionElementMap;
					goto IL_0055;
				}
				goto IL_0055;
			}
		}
		return b != null || c != null;
	}

	// Token: 0x06001E07 RID: 7687 RVA: 0x00086F30 File Offset: 0x00085130
	private static int fdj(Player a, int b, bool c, List<ActionElementMap> d)
	{
		int count = d.Count;
		a.controllers.maps.GetElementMapsWithAction(b, c, d);
		ie.fdk(a, d, count);
		return d.Count - count;
	}

	// Token: 0x06001E08 RID: 7688 RVA: 0x00086F6C File Offset: 0x0008516C
	public static ActionElementMap gfg(List<ActionElementMap> a)
	{
		int count = a.Count;
		for (int i = 0; i < count; i++)
		{
			ActionElementMap actionElementMap = a[i];
			if (actionElementMap.elementType == ControllerElementType.Axis && actionElementMap.axisType == AxisType.Normal)
			{
				return actionElementMap;
			}
		}
		return null;
	}

	// Token: 0x06001E09 RID: 7689 RVA: 0x00086FA8 File Offset: 0x000851A8
	public static bool mwk(List<ActionElementMap> a, out ActionElementMap b, out ActionElementMap c)
	{
		b = null;
		c = null;
		int count = a.Count;
		int i = 0;
		while (i < count)
		{
			ActionElementMap actionElementMap = a[i];
			if (actionElementMap.elementType == ControllerElementType.Axis)
			{
				if (actionElementMap.axisType != AxisType.Normal)
				{
					if (actionElementMap.axisType != AxisType.None)
					{
						goto IL_003D;
					}
				}
			}
			else if (actionElementMap.elementType == ControllerElementType.Button)
			{
				goto IL_003D;
			}
			IL_0055:
			i++;
			continue;
			IL_003D:
			if (actionElementMap.axisContribution == Pole.Positive)
			{
				if (c == null)
				{
					c = actionElementMap;
					goto IL_0055;
				}
				goto IL_0055;
			}
			else
			{
				if (b == null)
				{
					b = actionElementMap;
					goto IL_0055;
				}
				goto IL_0055;
			}
		}
		return b != null || c != null;
	}

	// Token: 0x06001E0A RID: 7690 RVA: 0x00087020 File Offset: 0x00085220
	public static bool fdc(InputAction a, AxisRange b, List<ActionElementMap> c, out ActionElementMap d, out ActionElementMap e)
	{
		d = null;
		e = null;
		bool flag = a.type == InputActionType.Axis;
		int count = c.Count;
		for (int i = 0; i < count; i++)
		{
			if (flag)
			{
				if (b == AxisRange.Full)
				{
					ActionElementMap actionElementMap = ie.fdd(c);
					if (actionElementMap != null)
					{
						d = actionElementMap;
						return true;
					}
					ActionElementMap actionElementMap2;
					if (ie.fdf(c, out actionElementMap, out actionElementMap2))
					{
						d = actionElementMap;
						e = actionElementMap2;
						return true;
					}
				}
				else
				{
					ActionElementMap actionElementMap = ie.fde(c, b);
					if (actionElementMap != null)
					{
						d = actionElementMap;
						return true;
					}
				}
			}
			else
			{
				ActionElementMap actionElementMap = ie.fde(c, b);
				if (actionElementMap != null)
				{
					d = actionElementMap;
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001E0B RID: 7691 RVA: 0x000870A0 File Offset: 0x000852A0
	public static bool fdb(int a, int b, AxisRange c, ControllerElementGlyphSelectorOptions d, List<ActionElementMap> e, out ActionElementMap f, out ActionElementMap g)
	{
		f = null;
		g = null;
		if (!ReInput.isReady)
		{
			return false;
		}
		if (d == null)
		{
			return false;
		}
		if (e == null)
		{
			return false;
		}
		InputAction action = ReInput.mapping.GetAction(b);
		if (action == null)
		{
			return false;
		}
		Player player = ReInput.players.GetPlayer(a);
		if (player == null)
		{
			return false;
		}
		Controller controller = player.controllers.GetLastActiveController();
		e.Clear();
		if (d.lsi && controller != null)
		{
			Controller controller2 = null;
			if (controller.type == ControllerType.Keyboard || controller.type == ControllerType.Mouse)
			{
				if (ie.fdg(d))
				{
					if (ReInput.controllers.Mouse.enabled && player.controllers.hasMouse)
					{
						controller = ReInput.controllers.Mouse;
						controller2 = ReInput.controllers.Keyboard;
					}
				}
				else if (ReInput.controllers.Keyboard.enabled && player.controllers.hasKeyboard)
				{
					controller = ReInput.controllers.Keyboard;
					controller2 = ReInput.controllers.Mouse;
				}
			}
			if (ie.fdh(player, controller.type, controller.id, b, true, e) > 0 && ie.fdc(action, c, e, out f, out g))
			{
				return true;
			}
			if (controller2 != null && ie.fdh(player, controller2.type, controller2.id, b, true, e) > 0 && ie.fdc(action, c, e, out f, out g))
			{
				return true;
			}
			if (ie.fdi(player, controller.type, b, true, e) > 0 && ie.fdc(action, c, e, out f, out g))
			{
				return true;
			}
		}
		int num = 0;
		ControllerType controllerType;
		while (d.fay(num, out controllerType))
		{
			if (ie.fdi(player, controllerType, b, true, e) > 0 && ie.fdc(action, c, e, out f, out g))
			{
				return true;
			}
			num++;
		}
		return ie.fdj(player, b, true, e) > 0 && ie.fdc(action, c, e, out f, out g);
	}

	// Token: 0x06001E0C RID: 7692 RVA: 0x00087268 File Offset: 0x00085468
	public static ActionElementMap fde(List<ActionElementMap> a, AxisRange b)
	{
		if (a.Count == 0)
		{
			return null;
		}
		int count = a.Count;
		for (int i = 0; i < count; i++)
		{
			ActionElementMap actionElementMap = a[i];
			switch (b)
			{
			case AxisRange.Full:
				if (actionElementMap.axisRange == AxisRange.Full)
				{
					return actionElementMap;
				}
				break;
			case AxisRange.Positive:
				if ((actionElementMap.axisType == AxisType.Split || actionElementMap.axisType == AxisType.None) && actionElementMap.axisContribution == Pole.Positive)
				{
					return actionElementMap;
				}
				break;
			case AxisRange.Negative:
				if ((actionElementMap.axisType == AxisType.Split || actionElementMap.axisType == AxisType.None) && actionElementMap.axisContribution == Pole.Negative)
				{
					return actionElementMap;
				}
				break;
			}
		}
		if (b == AxisRange.Full)
		{
			for (int j = 0; j < count; j++)
			{
				ActionElementMap actionElementMap = a[j];
				if ((actionElementMap.axisType == AxisType.Split || actionElementMap.axisType == AxisType.None) && actionElementMap.axisContribution == Pole.Positive)
				{
					return actionElementMap;
				}
			}
		}
		return null;
	}

	// Token: 0x06001E0D RID: 7693 RVA: 0x00087324 File Offset: 0x00085524
	private static int gch(Player a, ControllerType b, int c, bool d, List<ActionElementMap> e)
	{
		int count = e.Count;
		a.controllers.maps.GetElementMapsWithAction(b, c, d, e);
		ie.fdk(a, e, count);
		return e.Count - count;
	}

	// Token: 0x06001E0E RID: 7694 RVA: 0x00087364 File Offset: 0x00085564
	private static int fdi(Player a, ControllerType b, int c, bool d, List<ActionElementMap> e)
	{
		int count = e.Count;
		a.controllers.maps.GetElementMapsWithAction(b, c, d, e);
		ie.fdk(a, e, count);
		return e.Count - count;
	}

	// Token: 0x06001E0F RID: 7695 RVA: 0x000873A4 File Offset: 0x000855A4
	private static int dkf(Player a, ControllerType b, int c, bool d, List<ActionElementMap> e)
	{
		int count = e.Count;
		a.controllers.maps.GetElementMapsWithAction(b, c, d, e);
		ie.fdk(a, e, count);
		return e.Count - count;
	}

	// Token: 0x06001E10 RID: 7696 RVA: 0x000873E4 File Offset: 0x000855E4
	private static int jxz(Player a, ControllerType b, int c, int d, bool e, List<ActionElementMap> f)
	{
		int count = f.Count;
		a.controllers.maps.GetElementMapsWithAction(b, c, d, e, f);
		ie.fdk(a, f, count);
		return f.Count - count;
	}

	// Token: 0x06001E11 RID: 7697 RVA: 0x00087424 File Offset: 0x00085624
	public static ActionElementMap fdd(List<ActionElementMap> a)
	{
		int count = a.Count;
		for (int i = 0; i < count; i++)
		{
			ActionElementMap actionElementMap = a[i];
			if (actionElementMap.elementType == ControllerElementType.Axis && actionElementMap.axisType == AxisType.Normal)
			{
				return actionElementMap;
			}
		}
		return null;
	}

	// Token: 0x06001E12 RID: 7698 RVA: 0x00087460 File Offset: 0x00085660
	private static int fdk(Player a, List<ActionElementMap> b, int c)
	{
		int count = b.Count;
		for (int i = count - 1; i >= c; i--)
		{
			if (!a.controllers.ContainsController(b[i].controllerMap.controller) || !b[i].controllerMap.controller.enabled)
			{
				b.RemoveAt(i);
			}
		}
		return count - b.Count;
	}

	// Token: 0x06001E13 RID: 7699 RVA: 0x000874C8 File Offset: 0x000856C8
	private static int fij(Player a, List<ActionElementMap> b, int c)
	{
		int count = b.Count;
		for (int i = count - 1; i >= c; i--)
		{
			if (!a.controllers.ContainsController(b[i].controllerMap.controller) || !b[i].controllerMap.controller.enabled)
			{
				b.RemoveAt(i);
			}
		}
		return count - b.Count;
	}
}
