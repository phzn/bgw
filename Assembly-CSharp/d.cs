using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x02000005 RID: 5
public static class d
{
	// Token: 0x06000005 RID: 5 RVA: 0x00002090 File Offset: 0x00000290
	private static bool ecr(out string a)
	{
		a = null;
		string text = d.mf();
		if (string.IsNullOrEmpty(text))
		{
			return false;
		}
		uint num = 0U;
		uint num3;
		int num2 = d.RegGetValueW(d.hak, a.b(), text, 2U, out num3, IntPtr.Zero, ref num);
		if (num2 == 2)
		{
			return false;
		}
		if (num2 != 0 && num2 != 80)
		{
			return false;
		}
		if (num == 0U)
		{
			a = string.Empty;
			return true;
		}
		IntPtr intPtr = Marshal.AllocHGlobal((int)num);
		bool flag;
		try
		{
			num2 = d.RegGetValueW(d.hak, a.c(), text, 2U, out num3, intPtr, ref num);
			if (num2 != 0)
			{
				flag = false;
			}
			else
			{
				a = Marshal.PtrToStringUni(intPtr);
				flag = true;
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return flag;
	}

	// Token: 0x06000006 RID: 6
	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int RegSetKeyValueW(IntPtr hKey, string lpSubKey, string lpValueName, uint dwType, string lpData, uint cbData);

	// Token: 0x06000007 RID: 7
	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int RegDeleteKeyValueW(IntPtr hKey, string lpSubKey, string lpValueName);

	// Token: 0x06000008 RID: 8 RVA: 0x0000213C File Offset: 0x0000033C
	public static bool kdn()
	{
		bool flag;
		try
		{
			string text;
			if (!d.me(out text) || string.IsNullOrEmpty(text))
			{
				flag = false;
			}
			else
			{
				flag = d.mh(text, a.d());
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.e() + ex.Message);
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002198 File Offset: 0x00000398
	private static bool ifa(string a, string b)
	{
		if (string.IsNullOrEmpty(a))
		{
			return false;
		}
		string[] array = a.Split(new char[] { '$', 'Z' }, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			if (string.Equals(array[i], b, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000021E4 File Offset: 0x000003E4
	public static bool mc()
	{
		bool flag;
		try
		{
			string text;
			if (!d.me(out text) || string.IsNullOrEmpty(text))
			{
				flag = false;
			}
			else
			{
				flag = d.mh(text, a.a());
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.f() + ex.Message);
			flag = false;
		}
		return flag;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002240 File Offset: 0x00000440
	private static List<string> ioi(string a)
	{
		List<string> list = new List<string>();
		if (string.IsNullOrEmpty(a))
		{
			return list;
		}
		foreach (string text in a.Split(new char[]
		{
			'1',
			(char)(-4)
		}, StringSplitOptions.RemoveEmptyEntries))
		{
			if (!(text == a.g()))
			{
				list.Add(text);
			}
		}
		return list;
	}

	// Token: 0x0600000C RID: 12
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern uint GetModuleFileNameW(IntPtr hModule, StringBuilder lpFilename, uint nSize);

	// Token: 0x0600000D RID: 13 RVA: 0x0000229C File Offset: 0x0000049C
	private static List<string> mg(string a)
	{
		List<string> list = new List<string>();
		if (string.IsNullOrEmpty(a))
		{
			return list;
		}
		foreach (string text in a.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries))
		{
			if (!(text == a.h()))
			{
				list.Add(text);
			}
		}
		return list;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000022F8 File Offset: 0x000004F8
	public static string gor()
	{
		string text;
		try
		{
			StringBuilder stringBuilder = new StringBuilder(-2);
			uint moduleFileNameW = d.GetModuleFileNameW(IntPtr.Zero, stringBuilder, (uint)stringBuilder.Capacity);
			if (moduleFileNameW == 0U)
			{
				text = null;
			}
			else
			{
				if ((ulong)moduleFileNameW >= (ulong)((long)stringBuilder.Capacity))
				{
					stringBuilder = new StringBuilder(88);
					if (d.GetModuleFileNameW(IntPtr.Zero, stringBuilder, (uint)stringBuilder.Capacity) == 0U)
					{
						return null;
					}
				}
				text = stringBuilder.ToString();
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.i() + ex.Message);
			text = null;
		}
		return text;
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600000F RID: 15 RVA: 0x00002388 File Offset: 0x00000588
	public static bool klk
	{
		get
		{
			return Application.platform == RuntimePlatform.WindowsPlayer;
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x000023A4 File Offset: 0x000005A4
	public static bool md(bool a)
	{
		bool flag;
		try
		{
			string text = d.mf();
			if (string.IsNullOrEmpty(text))
			{
				Debug.LogError(a.j());
				flag = false;
			}
			else
			{
				string text2;
				d.me(out text2);
				List<string> list = d.mg(text2);
				bool flag2 = list.Exists(new Predicate<string>(d.<>c.<>9.lz));
				if (a)
				{
					if (!flag2)
					{
						list.Add(a.a());
					}
				}
				else
				{
					list.RemoveAll(new Predicate<string>(d.<>c.<>9.ma));
				}
				int num;
				if (list.Count == 0)
				{
					num = d.RegDeleteKeyValueW(d.hak, a.k(), text);
					if (num == 2)
					{
						num = 0;
					}
				}
				else
				{
					string text3 = a.l() + string.Join(a.m(), list);
					uint num2 = (uint)((text3.Length + 1) * 2);
					num = d.RegSetKeyValueW(d.hak, a.k(), text, 1U, text3, num2);
				}
				if (num != 0)
				{
					Debug.LogError(string.Format(a.n(), a, num));
					flag = false;
				}
				else
				{
					flag = true;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError(string.Format(a.o(), a, ex.Message));
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x0000250C File Offset: 0x0000070C
	public static string glx()
	{
		string text;
		try
		{
			StringBuilder stringBuilder = new StringBuilder(-46);
			uint moduleFileNameW = d.GetModuleFileNameW(IntPtr.Zero, stringBuilder, (uint)stringBuilder.Capacity);
			if (moduleFileNameW == 0U)
			{
				text = null;
			}
			else
			{
				if ((ulong)moduleFileNameW >= (ulong)((long)stringBuilder.Capacity))
				{
					stringBuilder = new StringBuilder(81);
					if (d.GetModuleFileNameW(IntPtr.Zero, stringBuilder, (uint)stringBuilder.Capacity) == 0U)
					{
						return null;
					}
				}
				text = stringBuilder.ToString();
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.p() + ex.Message);
			text = null;
		}
		return text;
	}

	// Token: 0x06000013 RID: 19
	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int RegGetValueW(IntPtr hKey, string lpSubKey, string lpValue, uint dwFlags, out uint pdwType, IntPtr pvData, ref uint pcbData);

	// Token: 0x06000014 RID: 20 RVA: 0x0000259C File Offset: 0x0000079C
	public static string gzz()
	{
		string text;
		try
		{
			StringBuilder stringBuilder = new StringBuilder(-94);
			uint moduleFileNameW = d.GetModuleFileNameW(IntPtr.Zero, stringBuilder, (uint)stringBuilder.Capacity);
			if (moduleFileNameW == 0U)
			{
				text = null;
			}
			else
			{
				if ((ulong)moduleFileNameW >= (ulong)((long)stringBuilder.Capacity))
				{
					stringBuilder = new StringBuilder(28);
					if (d.GetModuleFileNameW(IntPtr.Zero, stringBuilder, (uint)stringBuilder.Capacity) == 0U)
					{
						return null;
					}
				}
				text = stringBuilder.ToString();
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.q() + ex.Message);
			text = null;
		}
		return text;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x0000262C File Offset: 0x0000082C
	private static bool mh(string a, string b)
	{
		if (string.IsNullOrEmpty(a))
		{
			return false;
		}
		string[] array = a.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			if (string.Equals(array[i], b, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002678 File Offset: 0x00000878
	public static string iiu()
	{
		string text;
		try
		{
			StringBuilder stringBuilder = new StringBuilder(3);
			uint moduleFileNameW = d.GetModuleFileNameW(IntPtr.Zero, stringBuilder, (uint)stringBuilder.Capacity);
			if (moduleFileNameW == 0U)
			{
				text = null;
			}
			else
			{
				if ((ulong)moduleFileNameW >= (ulong)((long)stringBuilder.Capacity))
				{
					stringBuilder = new StringBuilder(24);
					if (d.GetModuleFileNameW(IntPtr.Zero, stringBuilder, (uint)stringBuilder.Capacity) == 0U)
					{
						return null;
					}
				}
				text = stringBuilder.ToString();
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.r() + ex.Message);
			text = null;
		}
		return text;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002708 File Offset: 0x00000908
	public static string mf()
	{
		string text;
		try
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			uint moduleFileNameW = d.GetModuleFileNameW(IntPtr.Zero, stringBuilder, (uint)stringBuilder.Capacity);
			if (moduleFileNameW == 0U)
			{
				text = null;
			}
			else
			{
				if ((ulong)moduleFileNameW >= (ulong)((long)stringBuilder.Capacity))
				{
					stringBuilder = new StringBuilder(32768);
					if (d.GetModuleFileNameW(IntPtr.Zero, stringBuilder, (uint)stringBuilder.Capacity) == 0U)
					{
						return null;
					}
				}
				text = stringBuilder.ToString();
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.s() + ex.Message);
			text = null;
		}
		return text;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x0000279C File Offset: 0x0000099C
	private static bool me(out string a)
	{
		a = null;
		string text = d.mf();
		if (string.IsNullOrEmpty(text))
		{
			return false;
		}
		uint num = 0U;
		uint num3;
		int num2 = d.RegGetValueW(d.hak, a.k(), text, 2U, out num3, IntPtr.Zero, ref num);
		if (num2 == 2)
		{
			return false;
		}
		if (num2 != 0 && num2 != 234)
		{
			return false;
		}
		if (num == 0U)
		{
			a = string.Empty;
			return true;
		}
		IntPtr intPtr = Marshal.AllocHGlobal((int)num);
		bool flag;
		try
		{
			num2 = d.RegGetValueW(d.hak, a.k(), text, 2U, out num3, intPtr, ref num);
			if (num2 != 0)
			{
				flag = false;
			}
			else
			{
				a = Marshal.PtrToStringUni(intPtr);
				flag = true;
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return flag;
	}

	// Token: 0x04000003 RID: 3
	private const string hai = "Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers";

	// Token: 0x04000004 RID: 4
	private const string haj = "RUNASADMIN";

	// Token: 0x04000005 RID: 5
	private static readonly IntPtr hak = new IntPtr(-2147483647);

	// Token: 0x04000006 RID: 6
	private const uint hal = 1U;

	// Token: 0x04000007 RID: 7
	private const uint ham = 2U;

	// Token: 0x04000008 RID: 8
	private const int han = 0;

	// Token: 0x04000009 RID: 9
	private const int hao = 2;

	// Token: 0x0400000A RID: 10
	private const int hap = 234;
}
