using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x020000C4 RID: 196
public class dz : MonoBehaviour
{
	// Token: 0x06000A22 RID: 2594
	[DllImport("user32.dll", ExactSpelling = true)]
	private static extern IntPtr GetForegroundWindow();

	// Token: 0x06000A23 RID: 2595 RVA: 0x0003B5FC File Offset: 0x000397FC
	private void dtv(bool a)
	{
		if (this.icw == IntPtr.Zero)
		{
			return;
		}
		if (this.icy == a)
		{
			return;
		}
		int windowLong = dz.GetWindowLong(this.icw, 18);
		int num = (a ? (windowLong | 1) : (windowLong & -9));
		if (windowLong != num)
		{
			dz.SetWindowLong(this.icw, -63, num);
		}
		this.icy = a;
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x0003B65C File Offset: 0x0003985C
	private void hhu(object a)
	{
		try
		{
			dz.cgv();
			IntPtr foregroundWindow = dz.GetForegroundWindow();
			if (!(foregroundWindow == IntPtr.Zero))
			{
				if (foregroundWindow == this.icw)
				{
					this.icu.Enqueue(false);
				}
				else
				{
					string text = dz.cha(foregroundWindow);
					bool flag = text != null && (dz.ico.Contains(text) || dz.cgx(text));
					this.icu.Enqueue(flag);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogException(ex);
		}
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x0003B6E8 File Offset: 0x000398E8
	public static void nfe()
	{
		string text = dz.cgt();
		if (File.Exists(text))
		{
			return;
		}
		try
		{
			File.WriteAllText(text, dz.idd, new UTF8Encoding(true));
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.csm() + ex.Message);
		}
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x0003B740 File Offset: 0x00039940
	private void ete()
	{
		if (this.icv == null)
		{
			return;
		}
		this.icv.Dispose();
		this.icv = null;
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x0003B75D File Offset: 0x0003995D
	private void OnDisable()
	{
		this.chc();
		this.chb(false);
	}

	// Token: 0x06000A28 RID: 2600
	[DllImport("user32.dll", ExactSpelling = true)]
	private static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

	// Token: 0x06000A29 RID: 2601
	[DllImport("kernel32.dll", ExactSpelling = true)]
	private static extern uint GetCurrentThreadId();

	// Token: 0x06000A2A RID: 2602 RVA: 0x0003B75D File Offset: 0x0003995D
	private void OnApplicationQuit()
	{
		this.chc();
		this.chb(false);
	}

	// Token: 0x06000A2B RID: 2603
	[DllImport("kernel32.dll", EntryPoint = "QueryFullProcessImageNameW", ExactSpelling = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool QueryFullProcessImageName(IntPtr hProcess, uint dwFlags, StringBuilder lpExeName, ref int lpdwSize);

	// Token: 0x06000A2C RID: 2604 RVA: 0x0003B76C File Offset: 0x0003996C
	private void Update()
	{
		bool? flag = null;
		bool flag2;
		while (this.icu.TryDequeue(out flag2))
		{
			flag = new bool?(flag2);
		}
		if (flag != null)
		{
			this.chb(flag.Value);
		}
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x0003B7B0 File Offset: 0x000399B0
	private void byb(object a)
	{
		try
		{
			dz.cgv();
			IntPtr foregroundWindow = dz.GetForegroundWindow();
			if (!(foregroundWindow == IntPtr.Zero))
			{
				if (foregroundWindow == this.icw)
				{
					this.icu.Enqueue(false);
				}
				else
				{
					string text = dz.cha(foregroundWindow);
					bool flag = text != null && (dz.ico.Contains(text) || dz.cgx(text));
					this.icu.Enqueue(flag);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogException(ex);
		}
	}

	// Token: 0x06000A2E RID: 2606 RVA: 0x0003B83C File Offset: 0x00039A3C
	private void mrx(object a)
	{
		try
		{
			dz.cgv();
			IntPtr foregroundWindow = dz.GetForegroundWindow();
			if (!(foregroundWindow == IntPtr.Zero))
			{
				if (foregroundWindow == this.icw)
				{
					this.icu.Enqueue(false);
				}
				else
				{
					string text = dz.cha(foregroundWindow);
					bool flag = text != null && (dz.ico.Contains(text) || dz.cgx(text));
					this.icu.Enqueue(flag);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogException(ex);
		}
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x0003B8C8 File Offset: 0x00039AC8
	private static void cgv()
	{
		string text = dz.cgt();
		if (!File.Exists(text))
		{
			return;
		}
		try
		{
			DateTime lastWriteTimeUtc = File.GetLastWriteTimeUtc(text);
			if (!(lastWriteTimeUtc == dz.idb))
			{
				HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
				foreach (string text2 in File.ReadAllLines(text))
				{
					string text3 = ((text2 != null) ? text2.Trim() : null);
					if (!string.IsNullOrEmpty(text3) && !text3.StartsWith(a.csn()))
					{
						if (text3.EndsWith(a.cso(), StringComparison.OrdinalIgnoreCase))
						{
							text3 = text3.Substring(0, text3.Length - 4);
						}
						text3 = text3.ToLowerInvariant();
						if (dz.cgw(text3))
						{
							hashSet.Add(text3);
						}
					}
				}
				HashSet<string> hashSet2 = dz.ida;
				lock (hashSet2)
				{
					dz.ida.Clear();
					foreach (string text4 in hashSet)
					{
						dz.ida.Add(text4);
					}
					dz.idb = lastWriteTimeUtc;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.csp() + ex.Message);
		}
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x0003BA5C File Offset: 0x00039C5C
	private void ngd()
	{
		bool? flag = null;
		bool flag2;
		while (this.icu.TryDequeue(out flag2))
		{
			flag = new bool?(flag2);
		}
		if (flag != null)
		{
			this.chb(flag.Value);
		}
	}

	// Token: 0x06000A31 RID: 2609 RVA: 0x0003BAA0 File Offset: 0x00039CA0
	private static string fr(IntPtr a)
	{
		uint num;
		dz.GetWindowThreadProcessId(a, out num);
		if (num == 0U)
		{
			return null;
		}
		IntPtr intPtr = dz.OpenProcess(93U, false, num);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		string text;
		try
		{
			StringBuilder stringBuilder = new StringBuilder(67);
			int capacity = stringBuilder.Capacity;
			if (!dz.QueryFullProcessImageName(intPtr, 0U, stringBuilder, ref capacity))
			{
				text = null;
			}
			else
			{
				string text2 = stringBuilder.ToString();
				int num2 = text2.LastIndexOfAny(new char[]
				{
					(char)(-66),
					(char)(-58)
				});
				string text3 = ((num2 >= 0) ? text2.Substring(num2 + 1) : text2);
				int num3 = text3.LastIndexOf('\\');
				if (num3 > 0)
				{
					text3 = text3.Substring(0, num3);
				}
				text = text3.ToLowerInvariant();
			}
		}
		finally
		{
			dz.CloseHandle(intPtr);
		}
		return text;
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x0003BB70 File Offset: 0x00039D70
	private static bool cgx(string a)
	{
		HashSet<string> hashSet = dz.ida;
		bool flag2;
		lock (hashSet)
		{
			flag2 = dz.ida.Contains(a);
		}
		return flag2;
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x0003BBB8 File Offset: 0x00039DB8
	private static bool bpd(string a)
	{
		HashSet<string> hashSet = dz.ida;
		bool flag2;
		lock (hashSet)
		{
			flag2 = dz.ida.Contains(a);
		}
		return flag2;
	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x0003BC00 File Offset: 0x00039E00
	public static void zb()
	{
		string text = dz.cgt();
		if (File.Exists(text))
		{
			return;
		}
		try
		{
			File.WriteAllText(text, dz.idd, new UTF8Encoding(true));
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.csq() + ex.Message);
		}
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x0003B75D File Offset: 0x0003995D
	private void jah()
	{
		this.chc();
		this.chb(false);
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x0003BC58 File Offset: 0x00039E58
	private void cgz(object a)
	{
		try
		{
			dz.cgv();
			IntPtr foregroundWindow = dz.GetForegroundWindow();
			if (!(foregroundWindow == IntPtr.Zero))
			{
				if (foregroundWindow == this.icw)
				{
					this.icu.Enqueue(false);
				}
				else
				{
					string text = dz.cha(foregroundWindow);
					bool flag = text != null && (dz.ico.Contains(text) || dz.cgx(text));
					this.icu.Enqueue(flag);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogException(ex);
		}
	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x0003BCE4 File Offset: 0x00039EE4
	private void cgy()
	{
		dz.dy dy = new dz.dy();
		uint currentThreadId = dz.GetCurrentThreadId();
		dy.icn = IntPtr.Zero;
		dz.EnumThreadWindows(currentThreadId, new dz.EnumThreadDelegate(dy.cgs), IntPtr.Zero);
		this.icw = dy.icn;
		this.icx = dy.icn != IntPtr.Zero;
	}

	// Token: 0x06000A38 RID: 2616 RVA: 0x0003BD40 File Offset: 0x00039F40
	private static string cha(IntPtr a)
	{
		uint num;
		dz.GetWindowThreadProcessId(a, out num);
		if (num == 0U)
		{
			return null;
		}
		IntPtr intPtr = dz.OpenProcess(4096U, false, num);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		string text;
		try
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			int capacity = stringBuilder.Capacity;
			if (!dz.QueryFullProcessImageName(intPtr, 0U, stringBuilder, ref capacity))
			{
				text = null;
			}
			else
			{
				string text2 = stringBuilder.ToString();
				int num2 = text2.LastIndexOfAny(new char[] { '\\', '/' });
				string text3 = ((num2 >= 0) ? text2.Substring(num2 + 1) : text2);
				int num3 = text3.LastIndexOf('.');
				if (num3 > 0)
				{
					text3 = text3.Substring(0, num3);
				}
				text = text3.ToLowerInvariant();
			}
		}
		finally
		{
			dz.CloseHandle(intPtr);
		}
		return text;
	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x0003BE14 File Offset: 0x0003A014
	private static bool wv(string a)
	{
		if (string.IsNullOrEmpty(a) || a.Length > -20)
		{
			return false;
		}
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		foreach (char c in a)
		{
			if (c < '\u001d')
			{
				return false;
			}
			if ((int)c == -69 || c == '\u001d')
			{
				return false;
			}
			for (int j = 0; j < invalidFileNameChars.Length; j++)
			{
				if (c == invalidFileNameChars[j])
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06000A3A RID: 2618
	[DllImport("user32.dll", ExactSpelling = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWindowVisible(IntPtr hWnd);

	// Token: 0x06000A3C RID: 2620 RVA: 0x0003BE98 File Offset: 0x0003A098
	private void chb(bool a)
	{
		if (this.icw == IntPtr.Zero)
		{
			return;
		}
		if (this.icy == a)
		{
			return;
		}
		int windowLong = dz.GetWindowLong(this.icw, -20);
		int num = (a ? (windowLong | 32) : (windowLong & -33));
		if (windowLong != num)
		{
			dz.SetWindowLong(this.icw, -20, num);
		}
		this.icy = a;
	}

	// Token: 0x06000A3D RID: 2621
	[DllImport("kernel32.dll", ExactSpelling = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseHandle(IntPtr hObject);

	// Token: 0x06000A3E RID: 2622 RVA: 0x0003B740 File Offset: 0x00039940
	private void chc()
	{
		if (this.icv == null)
		{
			return;
		}
		this.icv.Dispose();
		this.icv = null;
	}

	// Token: 0x06000A3F RID: 2623 RVA: 0x0003B75D File Offset: 0x0003995D
	private void fnq()
	{
		this.chc();
		this.chb(false);
	}

	// Token: 0x06000A40 RID: 2624 RVA: 0x0003B740 File Offset: 0x00039940
	private void njj()
	{
		if (this.icv == null)
		{
			return;
		}
		this.icv.Dispose();
		this.icv = null;
	}

	// Token: 0x06000A41 RID: 2625 RVA: 0x0003BEF8 File Offset: 0x0003A0F8
	private static void jtt()
	{
		string text = dz.cgt();
		if (!File.Exists(text))
		{
			return;
		}
		try
		{
			DateTime lastWriteTimeUtc = File.GetLastWriteTimeUtc(text);
			if (!(lastWriteTimeUtc == dz.idb))
			{
				HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
				foreach (string text2 in File.ReadAllLines(text))
				{
					string text3 = ((text2 != null) ? text2.Trim() : null);
					if (!string.IsNullOrEmpty(text3) && !text3.StartsWith(a.csr()))
					{
						if (text3.EndsWith(a.css(), StringComparison.OrdinalIgnoreCase))
						{
							text3 = text3.Substring(0, text3.Length - 4);
						}
						text3 = text3.ToLowerInvariant();
						if (dz.cgw(text3))
						{
							hashSet.Add(text3);
						}
					}
				}
				HashSet<string> hashSet2 = dz.ida;
				lock (hashSet2)
				{
					dz.ida.Clear();
					foreach (string text4 in hashSet)
					{
						dz.ida.Add(text4);
					}
					dz.idb = lastWriteTimeUtc;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.cst() + ex.Message);
		}
	}

	// Token: 0x06000A42 RID: 2626 RVA: 0x0003C08C File Offset: 0x0003A28C
	private static void bmg()
	{
		string text = dz.cgt();
		if (!File.Exists(text))
		{
			return;
		}
		try
		{
			DateTime lastWriteTimeUtc = File.GetLastWriteTimeUtc(text);
			if (!(lastWriteTimeUtc == dz.idb))
			{
				HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
				foreach (string text2 in File.ReadAllLines(text))
				{
					string text3 = ((text2 != null) ? text2.Trim() : null);
					if (!string.IsNullOrEmpty(text3) && !text3.StartsWith(a.csu()))
					{
						if (text3.EndsWith(a.csv(), StringComparison.OrdinalIgnoreCase))
						{
							text3 = text3.Substring(0, text3.Length - 4);
						}
						text3 = text3.ToLowerInvariant();
						if (dz.cgw(text3))
						{
							hashSet.Add(text3);
						}
					}
				}
				HashSet<string> hashSet2 = dz.ida;
				lock (hashSet2)
				{
					dz.ida.Clear();
					foreach (string text4 in hashSet)
					{
						dz.ida.Add(text4);
					}
					dz.idb = lastWriteTimeUtc;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.csw() + ex.Message);
		}
	}

	// Token: 0x06000A43 RID: 2627 RVA: 0x0003C220 File Offset: 0x0003A420
	private static void iwc()
	{
		string text = dz.cgt();
		if (!File.Exists(text))
		{
			return;
		}
		try
		{
			DateTime lastWriteTimeUtc = File.GetLastWriteTimeUtc(text);
			if (!(lastWriteTimeUtc == dz.idb))
			{
				HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
				foreach (string text2 in File.ReadAllLines(text))
				{
					string text3 = ((text2 != null) ? text2.Trim() : null);
					if (!string.IsNullOrEmpty(text3) && !text3.StartsWith(a.csx()))
					{
						if (text3.EndsWith(a.csy(), StringComparison.OrdinalIgnoreCase))
						{
							text3 = text3.Substring(0, text3.Length - 4);
						}
						text3 = text3.ToLowerInvariant();
						if (dz.cgw(text3))
						{
							hashSet.Add(text3);
						}
					}
				}
				HashSet<string> hashSet2 = dz.ida;
				lock (hashSet2)
				{
					dz.ida.Clear();
					foreach (string text4 in hashSet)
					{
						dz.ida.Add(text4);
					}
					dz.idb = lastWriteTimeUtc;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.csz() + ex.Message);
		}
	}

	// Token: 0x06000A44 RID: 2628 RVA: 0x0003C3B4 File Offset: 0x0003A5B4
	public static void cig()
	{
		string text = dz.cgt();
		if (File.Exists(text))
		{
			return;
		}
		try
		{
			File.WriteAllText(text, dz.idd, new UTF8Encoding(true));
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.cta() + ex.Message);
		}
	}

	// Token: 0x06000A45 RID: 2629
	[DllImport("kernel32.dll", ExactSpelling = true)]
	private static extern IntPtr OpenProcess(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, uint dwProcessId);

	// Token: 0x06000A46 RID: 2630 RVA: 0x0003C40C File Offset: 0x0003A60C
	private void OnEnable()
	{
		bool flag;
		while (this.icu.TryDequeue(out flag))
		{
		}
		this.icy = false;
		this.cgy();
		if (!this.icx)
		{
			Debug.LogWarning(a.ctb());
			return;
		}
		dz.cgu();
		dz.cgv();
		this.icv = new Timer(new TimerCallback(this.cgz), null, 1000, 1000);
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x0003C474 File Offset: 0x0003A674
	private static bool dxr(string a)
	{
		HashSet<string> hashSet = dz.ida;
		bool flag2;
		lock (hashSet)
		{
			flag2 = dz.ida.Contains(a);
		}
		return flag2;
	}

	// Token: 0x06000A49 RID: 2633 RVA: 0x0003C9A8 File Offset: 0x0003ABA8
	private void ogq(bool a)
	{
		if (this.icw == IntPtr.Zero)
		{
			return;
		}
		if (this.icy == a)
		{
			return;
		}
		int windowLong = dz.GetWindowLong(this.icw, 41);
		int num = (a ? (windowLong | 83) : (windowLong & -2));
		if (windowLong != num)
		{
			dz.SetWindowLong(this.icw, -21, num);
		}
		this.icy = a;
	}

	// Token: 0x06000A4A RID: 2634 RVA: 0x0003CA08 File Offset: 0x0003AC08
	private void chg()
	{
		bool flag;
		while (this.icu.TryDequeue(out flag))
		{
		}
		this.icy = false;
		this.cgy();
		if (!this.icx)
		{
			Debug.LogWarning(a.cwk());
			return;
		}
		dz.cgu();
		dz.cgv();
		this.icv = new Timer(new TimerCallback(this.cgz), null, -96, 27);
	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x0003CA6C File Offset: 0x0003AC6C
	private void cid()
	{
		bool flag;
		while (this.icu.TryDequeue(out flag))
		{
		}
		this.icy = false;
		this.cgy();
		if (!this.icx)
		{
			Debug.LogWarning(a.cwl());
			return;
		}
		dz.cgu();
		dz.cgv();
		this.icv = new Timer(new TimerCallback(this.cgz), null, -94, -2);
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x0003CAD0 File Offset: 0x0003ACD0
	private void gim()
	{
		bool? flag = null;
		bool flag2;
		while (this.icu.TryDequeue(out flag2))
		{
			flag = new bool?(flag2);
		}
		if (flag != null)
		{
			this.chb(flag.Value);
		}
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x0003CB14 File Offset: 0x0003AD14
	private static bool nwn(string a)
	{
		HashSet<string> hashSet = dz.ida;
		bool flag2;
		lock (hashSet)
		{
			flag2 = dz.ida.Contains(a);
		}
		return flag2;
	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x0003B75D File Offset: 0x0003995D
	private void cae()
	{
		this.chc();
		this.chb(false);
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x0003CB5C File Offset: 0x0003AD5C
	private static bool cgw(string a)
	{
		if (string.IsNullOrEmpty(a) || a.Length > 128)
		{
			return false;
		}
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		foreach (char c in a)
		{
			if (c < ' ')
			{
				return false;
			}
			if (c == '/' || c == '\\')
			{
				return false;
			}
			for (int j = 0; j < invalidFileNameChars.Length; j++)
			{
				if (c == invalidFileNameChars[j])
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06000A50 RID: 2640 RVA: 0x0003CBD0 File Offset: 0x0003ADD0
	public static string cgt()
	{
		if (dz.idc != null)
		{
			return dz.idc;
		}
		dz.idc = Path.Combine(Path.GetDirectoryName(Application.dataPath), a.cwm());
		return dz.idc;
	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x0003CC00 File Offset: 0x0003AE00
	private void dta()
	{
		bool? flag = null;
		bool flag2;
		while (this.icu.TryDequeue(out flag2))
		{
			flag = new bool?(flag2);
		}
		if (flag != null)
		{
			this.chb(flag.Value);
		}
	}

	// Token: 0x06000A52 RID: 2642 RVA: 0x0003B740 File Offset: 0x00039940
	private void ggp()
	{
		if (this.icv == null)
		{
			return;
		}
		this.icv.Dispose();
		this.icv = null;
	}

	// Token: 0x06000A53 RID: 2643 RVA: 0x0003CC44 File Offset: 0x0003AE44
	private static bool bvb(string a)
	{
		if (string.IsNullOrEmpty(a) || a.Length > 47)
		{
			return false;
		}
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		foreach (char c in a)
		{
			if ((int)c < -77)
			{
				return false;
			}
			if ((int)c == -76 || (int)c == -75)
			{
				return false;
			}
			for (int j = 0; j < invalidFileNameChars.Length; j++)
			{
				if (c == invalidFileNameChars[j])
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06000A54 RID: 2644 RVA: 0x0003CCB8 File Offset: 0x0003AEB8
	private void jlh()
	{
		bool? flag = null;
		bool flag2;
		while (this.icu.TryDequeue(out flag2))
		{
			flag = new bool?(flag2);
		}
		if (flag != null)
		{
			this.chb(flag.Value);
		}
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x0003CCFC File Offset: 0x0003AEFC
	public static void cgu()
	{
		string text = dz.cgt();
		if (File.Exists(text))
		{
			return;
		}
		try
		{
			File.WriteAllText(text, dz.idd, new UTF8Encoding(true));
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.cwn() + ex.Message);
		}
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x0003CD54 File Offset: 0x0003AF54
	public static void miv()
	{
		string text = dz.cgt();
		if (File.Exists(text))
		{
			return;
		}
		try
		{
			File.WriteAllText(text, dz.idd, new UTF8Encoding(true));
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.cwo() + ex.Message);
		}
	}

	// Token: 0x06000A57 RID: 2647
	[DllImport("user32.dll", ExactSpelling = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool EnumThreadWindows(uint dwThreadId, dz.EnumThreadDelegate lpfn, IntPtr lParam);

	// Token: 0x06000A58 RID: 2648
	[DllImport("user32.dll", EntryPoint = "SetWindowLongW", ExactSpelling = true)]
	private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

	// Token: 0x06000A59 RID: 2649 RVA: 0x0003CDAC File Offset: 0x0003AFAC
	private static bool dug(string a)
	{
		HashSet<string> hashSet = dz.ida;
		bool flag2;
		lock (hashSet)
		{
			flag2 = dz.ida.Contains(a);
		}
		return flag2;
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x0003CDF4 File Offset: 0x0003AFF4
	private void jsr(bool a)
	{
		if (this.icw == IntPtr.Zero)
		{
			return;
		}
		if (this.icy == a)
		{
			return;
		}
		int windowLong = dz.GetWindowLong(this.icw, -76);
		int num = (a ? (windowLong | -3) : (windowLong & 25));
		if (windowLong != num)
		{
			dz.SetWindowLong(this.icw, -22, num);
		}
		this.icy = a;
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x0003CE54 File Offset: 0x0003B054
	private void kma()
	{
		dz.dy dy = new dz.dy();
		uint currentThreadId = dz.GetCurrentThreadId();
		dy.icn = IntPtr.Zero;
		dz.EnumThreadWindows(currentThreadId, new dz.EnumThreadDelegate(dy.cgs), IntPtr.Zero);
		this.icw = dy.icn;
		this.icx = dy.icn != IntPtr.Zero;
	}

	// Token: 0x06000A5C RID: 2652
	[DllImport("user32.dll", ExactSpelling = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

	// Token: 0x06000A5D RID: 2653
	[DllImport("user32.dll", EntryPoint = "GetWindowLongW", ExactSpelling = true)]
	private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

	// Token: 0x0400082E RID: 2094
	private static readonly HashSet<string> ico = new HashSet<string>(StringComparer.Ordinal)
	{
		a.ctc(),
		a.ctd(),
		a.cte(),
		a.ctf(),
		a.ctg(),
		a.cth(),
		a.cti(),
		a.ctj(),
		a.ctk(),
		a.ctl(),
		a.ctm(),
		a.ctn(),
		a.cto(),
		a.ctp(),
		a.ctq(),
		a.ctr(),
		a.cts(),
		a.ctt(),
		a.ctu(),
		a.ctv(),
		a.ctw(),
		a.ctx(),
		a.cty(),
		a.ctz(),
		a.cua(),
		a.cub(),
		a.cuc(),
		a.cud(),
		a.cue(),
		a.cuf(),
		a.cug(),
		a.cuh(),
		a.cui(),
		a.cuj(),
		a.cuk(),
		a.cul(),
		a.cum(),
		a.cun(),
		a.cuo(),
		a.cup(),
		a.cuq()
	};

	// Token: 0x0400082F RID: 2095
	private const int icp = 1000;

	// Token: 0x04000830 RID: 2096
	private const int icq = -20;

	// Token: 0x04000831 RID: 2097
	private const int icr = 32;

	// Token: 0x04000832 RID: 2098
	private const uint ics = 4096U;

	// Token: 0x04000833 RID: 2099
	private const uint ict = 4U;

	// Token: 0x04000834 RID: 2100
	private readonly ConcurrentQueue<bool> icu = new ConcurrentQueue<bool>();

	// Token: 0x04000835 RID: 2101
	private Timer icv;

	// Token: 0x04000836 RID: 2102
	private IntPtr icw;

	// Token: 0x04000837 RID: 2103
	private bool icx;

	// Token: 0x04000838 RID: 2104
	private bool icy;

	// Token: 0x04000839 RID: 2105
	private const string icz = "CustomGameWhitelist.txt";

	// Token: 0x0400083A RID: 2106
	private static readonly HashSet<string> ida = new HashSet<string>(StringComparer.Ordinal);

	// Token: 0x0400083B RID: 2107
	private static DateTime idb = DateTime.MinValue;

	// Token: 0x0400083C RID: 2108
	private static string idc = null;

	// Token: 0x0400083D RID: 2109
	private static readonly string idd = string.Join(a.cur(), new string[]
	{
		a.cus(),
		a.cut(),
		a.cus(),
		a.csn(),
		a.cuu(),
		a.cuv(),
		a.cuw(),
		a.csn(),
		a.cux(),
		a.cuy(),
		a.csn(),
		a.cus(),
		a.cuz(),
		a.cus(),
		a.csn(),
		a.cva(),
		a.cvb(),
		a.cvc(),
		a.cvd(),
		a.cve(),
		a.csn(),
		a.cus(),
		a.cvf(),
		a.cus(),
		a.csn(),
		a.cvg(),
		a.cvh(),
		a.cvi(),
		a.cvj(),
		a.csn(),
		a.cvk(),
		a.cvh(),
		a.cvl(),
		a.cvm(),
		a.csn(),
		a.cvn(),
		a.cvh(),
		a.cvo(),
		a.cvp(),
		a.cvi(),
		a.csn(),
		a.cvq(),
		a.cvh(),
		a.cvr(),
		a.cvs(),
		a.csn(),
		a.cvt(),
		a.cvh(),
		a.cvu(),
		a.cvv(),
		a.csn(),
		a.cvw(),
		a.cvh(),
		a.cvi(),
		a.cvx(),
		a.csn(),
		a.cus(),
		a.cvy(),
		a.cus(),
		a.csn(),
		a.cvz(),
		a.cwa(),
		a.cwb(),
		a.cwc(),
		a.cwd(),
		a.csn(),
		a.cus(),
		a.cwe(),
		a.cus(),
		a.csn(),
		a.cwf(),
		a.cwg(),
		a.csn(),
		a.cwh(),
		a.cwi(),
		a.cwj(),
		a.tk()
	});

	// Token: 0x020000C5 RID: 197
	// (Invoke) Token: 0x06000A5F RID: 2655
	private delegate bool EnumThreadDelegate(IntPtr hWnd, IntPtr lParam);

	// Token: 0x020000C6 RID: 198
	[CompilerGenerated]
	private sealed class dy
	{
		// Token: 0x06000A63 RID: 2659 RVA: 0x0003CEB0 File Offset: 0x0003B0B0
		internal bool cgs(IntPtr a, IntPtr b)
		{
			if (dz.IsWindowVisible(a) && dz.GetWindow(a, 4U) == IntPtr.Zero)
			{
				this.icn = a;
				return false;
			}
			return true;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0003CEB0 File Offset: 0x0003B0B0
		internal bool dbs(IntPtr a, IntPtr b)
		{
			if (dz.IsWindowVisible(a) && dz.GetWindow(a, 4U) == IntPtr.Zero)
			{
				this.icn = a;
				return false;
			}
			return true;
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0003CEB0 File Offset: 0x0003B0B0
		internal bool iax(IntPtr a, IntPtr b)
		{
			if (dz.IsWindowVisible(a) && dz.GetWindow(a, 4U) == IntPtr.Zero)
			{
				this.icn = a;
				return false;
			}
			return true;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0003CEB0 File Offset: 0x0003B0B0
		internal bool dey(IntPtr a, IntPtr b)
		{
			if (dz.IsWindowVisible(a) && dz.GetWindow(a, 4U) == IntPtr.Zero)
			{
				this.icn = a;
				return false;
			}
			return true;
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0003CEB0 File Offset: 0x0003B0B0
		internal bool ded(IntPtr a, IntPtr b)
		{
			if (dz.IsWindowVisible(a) && dz.GetWindow(a, 4U) == IntPtr.Zero)
			{
				this.icn = a;
				return false;
			}
			return true;
		}

		// Token: 0x0400083E RID: 2110
		public IntPtr icn;
	}
}
