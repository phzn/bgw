using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x0200001A RID: 26
public static class q
{
	// Token: 0x06000105 RID: 261 RVA: 0x000062A0 File Offset: 0x000044A0
	private static bool ti()
	{
		int num = q.RegDeleteKeyValueW(q.hgo, a.di(), a.dj());
		if (num == 2)
		{
			num = 0;
		}
		if (num != 0)
		{
			Debug.LogError(string.Format(a.dk(), num));
			return false;
		}
		return true;
	}

	// Token: 0x06000106 RID: 262 RVA: 0x000062E4 File Offset: 0x000044E4
	private static bool tl()
	{
		bool flag;
		try
		{
			if (q.tk())
			{
				flag = true;
			}
			else
			{
				string text = d.mf();
				if (string.IsNullOrEmpty(text))
				{
					Debug.LogWarning(a.dl());
					flag = false;
				}
				else
				{
					string text2 = a.dm() + text + a.dn();
					int num = q.tj(a.@do() + text2 + a.dp());
					if (num != 0)
					{
						Debug.LogWarning(string.Format(a.dq(), num));
						flag = false;
					}
					else
					{
						Debug.Log(a.dr());
						flag = true;
					}
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError(a.ds() + ex.Message);
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000107 RID: 263
	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int RegDeleteKeyValueW(IntPtr hKey, string lpSubKey, string lpValueName);

	// Token: 0x06000108 RID: 264 RVA: 0x0000639C File Offset: 0x0000459C
	public static bool ps()
	{
		bool flag;
		try
		{
			flag = q.te() || q.tk();
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.dt() + ex.Message);
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000109 RID: 265 RVA: 0x000063E8 File Offset: 0x000045E8
	public static void lns()
	{
		try
		{
			string fullPath = Path.GetFullPath(Path.Combine(Application.dataPath, a.du(), a.dv()));
			if (!File.Exists(fullPath))
			{
				if (!PlayerPrefs.HasKey(a.dw()))
				{
					Debug.Log(a.dx());
				}
				else
				{
					if (q.to())
					{
						q.tq(false);
						Debug.Log(a.dy());
					}
					PlayerPrefs.SetInt(a.dz(), 0);
				}
				PlayerPrefs.SetInt(a.ea(), 1);
				PlayerPrefs.Save();
				File.WriteAllText(fullPath, DateTime.UtcNow.ToString(a.eb()));
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.ec() + ex.Message);
		}
	}

	// Token: 0x0600010A RID: 266 RVA: 0x000064AC File Offset: 0x000046AC
	public static bool exd()
	{
		bool flag;
		try
		{
			flag = q.te() || q.tk();
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.ed() + ex.Message);
			flag = false;
		}
		return flag;
	}

	// Token: 0x0600010B RID: 267 RVA: 0x000064F8 File Offset: 0x000046F8
	public static bool gwm(bool a)
	{
		bool flag;
		try
		{
			if (!a)
			{
				if (q.te())
				{
					flag = false;
				}
				else
				{
					flag = !q.tk();
				}
			}
			else if (d.mc())
			{
				if (q.te())
				{
					flag = false;
				}
				else
				{
					flag = q.tk();
				}
			}
			else if (!q.tg())
			{
				flag = false;
			}
			else
			{
				flag = !q.tk();
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.ee() + ex.Message);
			flag = false;
		}
		return flag;
	}

	// Token: 0x0600010C RID: 268 RVA: 0x0000657C File Offset: 0x0000477C
	public static bool to()
	{
		bool flag;
		try
		{
			flag = q.te() || q.tk();
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.ef() + ex.Message);
			flag = false;
		}
		return flag;
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600010D RID: 269 RVA: 0x000065C8 File Offset: 0x000047C8
	private static string kmg
	{
		get
		{
			string text = d.mf();
			if (!string.IsNullOrEmpty(text))
			{
				return a.eg() + text + a.eh();
			}
			return null;
		}
	}

	// Token: 0x0600010E RID: 270 RVA: 0x000065F8 File Offset: 0x000047F8
	public static void zt()
	{
		try
		{
			string text = q.td();
			if (!string.IsNullOrEmpty(text))
			{
				if (text.IndexOf(a.ei(), StringComparison.OrdinalIgnoreCase) >= 0)
				{
					PlayerPrefs.SetInt(a.ej(), 1);
					PlayerPrefs.Save();
					if (q.tq(true))
					{
						Debug.Log(a.ek());
					}
					else if (q.tq(false))
					{
						PlayerPrefs.SetInt(a.el(), 0);
						PlayerPrefs.Save();
						Debug.LogWarning(a.em());
					}
					else
					{
						Debug.LogWarning(a.en());
					}
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.eo() + ex.Message);
		}
	}

	// Token: 0x0600010F RID: 271 RVA: 0x000066A8 File Offset: 0x000048A8
	public static bool tp(bool a)
	{
		bool flag;
		try
		{
			if (!a)
			{
				if (q.te())
				{
					flag = false;
				}
				else
				{
					flag = !q.tk();
				}
			}
			else if (d.mc())
			{
				if (q.te())
				{
					flag = false;
				}
				else
				{
					flag = q.tk();
				}
			}
			else if (!q.tg())
			{
				flag = false;
			}
			else
			{
				flag = !q.tk();
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.ep() + ex.Message);
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000110 RID: 272 RVA: 0x0000672C File Offset: 0x0000492C
	private static bool dsg()
	{
		string text = q.kmg;
		if (string.IsNullOrEmpty(text))
		{
			Debug.LogWarning(a.eq());
			return false;
		}
		uint num = (uint)((text.Length + 1) * 2);
		int num2 = q.RegSetKeyValueW(q.hgo, a.er(), a.es(), 1U, text, num);
		if (num2 != 0)
		{
			Debug.LogError(string.Format(a.et(), num2));
			return false;
		}
		return true;
	}

	// Token: 0x06000111 RID: 273 RVA: 0x00006794 File Offset: 0x00004994
	private static bool tm()
	{
		bool flag;
		try
		{
			if (!q.tk())
			{
				flag = true;
			}
			else
			{
				int num = q.tj(a.eu());
				if (num != 0)
				{
					Debug.LogWarning(string.Format(a.ev(), num));
					flag = false;
				}
				else
				{
					Debug.Log(a.ew());
					flag = true;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError(a.ex() + ex.Message);
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000112 RID: 274 RVA: 0x0000680C File Offset: 0x00004A0C
	private static bool mcq()
	{
		int num = q.RegDeleteKeyValueW(q.hgo, a.ey(), a.ez());
		if (num == 2)
		{
			num = 0;
		}
		if (num != 0)
		{
			Debug.LogError(string.Format(a.fa(), num));
			return false;
		}
		return true;
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00006850 File Offset: 0x00004A50
	public static bool bbl(bool a)
	{
		bool flag3;
		try
		{
			if (!a)
			{
				bool flag = q.ti();
				bool flag2 = q.tm();
				flag3 = flag && flag2;
			}
			else if (d.mc())
			{
				bool flag4 = q.tl();
				if (flag4)
				{
					q.ti();
				}
				flag3 = flag4;
			}
			else if (!q.tm())
			{
				Debug.LogWarning(a.fb());
				flag3 = false;
			}
			else
			{
				flag3 = q.th();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError(a.fc() + ex.Message);
			flag3 = false;
		}
		return flag3;
	}

	// Token: 0x06000114 RID: 276 RVA: 0x000068D0 File Offset: 0x00004AD0
	public static void tt()
	{
		if (Application.platform != RuntimePlatform.OSXPlayer && Application.platform != RuntimePlatform.OSXEditor)
		{
			return;
		}
		try
		{
			string environmentVariable = Environment.GetEnvironmentVariable(a.fd());
			if (!string.IsNullOrEmpty(environmentVariable))
			{
				string text = Path.Combine(environmentVariable, a.fe(), a.ff(), a.fg());
				if (File.Exists(text))
				{
					File.Delete(text);
					Debug.Log(a.fh());
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.fi() + ex.Message);
		}
	}

	// Token: 0x06000115 RID: 277
	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int RegSetKeyValueW(IntPtr hKey, string lpSubKey, string lpValueName, uint dwType, string lpData, uint cbData);

	// Token: 0x06000116 RID: 278 RVA: 0x0000695C File Offset: 0x00004B5C
	private static bool jjj()
	{
		int num = q.RegDeleteKeyValueW(q.hgo, a.fj(), a.fk());
		if (num == 2)
		{
			num = 0;
		}
		if (num != 0)
		{
			Debug.LogError(string.Format(a.fl(), num));
			return false;
		}
		return true;
	}

	// Token: 0x06000117 RID: 279 RVA: 0x000069A0 File Offset: 0x00004BA0
	public static bool jam(bool a)
	{
		bool flag;
		try
		{
			if (!a)
			{
				if (q.te())
				{
					flag = false;
				}
				else
				{
					flag = !q.tk();
				}
			}
			else if (d.mc())
			{
				if (q.te())
				{
					flag = false;
				}
				else
				{
					flag = q.tk();
				}
			}
			else if (!q.tg())
			{
				flag = false;
			}
			else
			{
				flag = !q.tk();
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.fm() + ex.Message);
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00006A24 File Offset: 0x00004C24
	private static bool ljb()
	{
		uint num = 0U;
		uint num3;
		int num2 = q.RegGetValueW(q.hgo, a.fn(), a.fo(), 2U, out num3, IntPtr.Zero, ref num);
		return num2 == 0 || num2 == -18;
	}

	// Token: 0x0600011A RID: 282 RVA: 0x00006A70 File Offset: 0x00004C70
	private static bool gls()
	{
		bool flag;
		try
		{
			flag = q.tj(a.fp()) == 0;
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.fq() + ex.Message);
			flag = false;
		}
		return flag;
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00006AB8 File Offset: 0x00004CB8
	private static string kon()
	{
		uint num = 0U;
		uint num3;
		int num2 = q.RegGetValueW(q.hgo, a.fr(), a.fs(), 2U, out num3, IntPtr.Zero, ref num);
		if (num2 == 2)
		{
			return null;
		}
		if (num2 != 0 && num2 != 16)
		{
			return null;
		}
		if (num == 0U)
		{
			return null;
		}
		IntPtr intPtr = Marshal.AllocHGlobal((int)num);
		string text;
		try
		{
			num2 = q.RegGetValueW(q.hgo, a.ft(), a.fu(), 2U, out num3, intPtr, ref num);
			text = ((num2 == 0) ? Marshal.PtrToStringUni(intPtr) : null);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return text;
	}

	// Token: 0x0600011C RID: 284 RVA: 0x00006B48 File Offset: 0x00004D48
	private static bool kql()
	{
		uint num = 0U;
		uint num3;
		int num2 = q.RegGetValueW(q.hgo, a.fv(), a.fw(), 2U, out num3, IntPtr.Zero, ref num);
		return num2 == 0 || num2 == -77;
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00006B80 File Offset: 0x00004D80
	private static bool dwj()
	{
		string text = q.kmg;
		if (string.IsNullOrEmpty(text))
		{
			Debug.LogWarning(a.fx());
			return false;
		}
		uint num = (uint)((text.Length + 1) * 2);
		int num2 = q.RegSetKeyValueW(q.hgo, a.fy(), a.fz(), 1U, text, num);
		if (num2 != 0)
		{
			Debug.LogError(string.Format(a.ga(), num2));
			return false;
		}
		return true;
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00006BE8 File Offset: 0x00004DE8
	private static bool bnu()
	{
		string text = q.kmg;
		if (string.IsNullOrEmpty(text))
		{
			return q.te();
		}
		string text2 = q.td();
		return text2 != null && string.Equals(text2, text, StringComparison.OrdinalIgnoreCase);
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00006C1C File Offset: 0x00004E1C
	private static bool mns()
	{
		int num = q.RegDeleteKeyValueW(q.hgo, a.gb(), a.gc());
		if (num == 2)
		{
			num = 0;
		}
		if (num != 0)
		{
			Debug.LogError(string.Format(a.gd(), num));
			return false;
		}
		return true;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00006C60 File Offset: 0x00004E60
	public static bool bso(bool a)
	{
		bool flag;
		try
		{
			if (!a)
			{
				if (q.te())
				{
					flag = false;
				}
				else
				{
					flag = !q.tk();
				}
			}
			else if (d.mc())
			{
				if (q.te())
				{
					flag = false;
				}
				else
				{
					flag = q.tk();
				}
			}
			else if (!q.tg())
			{
				flag = false;
			}
			else
			{
				flag = !q.tk();
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.ge() + ex.Message);
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00006CE4 File Offset: 0x00004EE4
	public static bool iur(bool a)
	{
		bool flag;
		try
		{
			if (!a)
			{
				if (q.te())
				{
					flag = false;
				}
				else
				{
					flag = !q.tk();
				}
			}
			else if (d.mc())
			{
				if (q.te())
				{
					flag = false;
				}
				else
				{
					flag = q.tk();
				}
			}
			else if (!q.tg())
			{
				flag = false;
			}
			else
			{
				flag = !q.tk();
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.gf() + ex.Message);
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00006D68 File Offset: 0x00004F68
	private static bool obc()
	{
		bool flag;
		try
		{
			if (!q.tk())
			{
				flag = true;
			}
			else
			{
				int num = q.tj(a.gg());
				if (num != 0)
				{
					Debug.LogWarning(string.Format(a.gh(), num));
					flag = false;
				}
				else
				{
					Debug.Log(a.gi());
					flag = true;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError(a.gj() + ex.Message);
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00006DE0 File Offset: 0x00004FE0
	public static bool tq(bool a)
	{
		bool flag3;
		try
		{
			if (!a)
			{
				bool flag = q.ti();
				bool flag2 = q.tm();
				flag3 = flag && flag2;
			}
			else if (d.mc())
			{
				bool flag4 = q.tl();
				if (flag4)
				{
					q.ti();
				}
				flag3 = flag4;
			}
			else if (!q.tm())
			{
				Debug.LogWarning(a.gk());
				flag3 = false;
			}
			else
			{
				flag3 = q.th();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError(a.gl() + ex.Message);
			flag3 = false;
		}
		return flag3;
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00006E60 File Offset: 0x00005060
	private static bool th()
	{
		string text = q.kmg;
		if (string.IsNullOrEmpty(text))
		{
			Debug.LogWarning(a.gm());
			return false;
		}
		uint num = (uint)((text.Length + 1) * 2);
		int num2 = q.RegSetKeyValueW(q.hgo, a.di(), a.dj(), 1U, text, num);
		if (num2 != 0)
		{
			Debug.LogError(string.Format(a.gn(), num2));
			return false;
		}
		return true;
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x06000125 RID: 293 RVA: 0x00006EC8 File Offset: 0x000050C8
	public static bool kmh
	{
		get
		{
			RuntimePlatform platform = Application.platform;
			return platform == RuntimePlatform.WindowsPlayer || platform == RuntimePlatform.WindowsEditor;
		}
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00006EE8 File Offset: 0x000050E8
	private static bool tk()
	{
		bool flag;
		try
		{
			flag = q.tj(a.go()) == 0;
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.gp() + ex.Message);
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00006F30 File Offset: 0x00005130
	private static bool geu()
	{
		bool flag;
		try
		{
			if (q.tk())
			{
				flag = true;
			}
			else
			{
				string text = d.mf();
				if (string.IsNullOrEmpty(text))
				{
					Debug.LogWarning(a.gq());
					flag = false;
				}
				else
				{
					string text2 = a.gr() + text + a.gs();
					int num = q.tj(a.gt() + text2 + a.gu());
					if (num != 0)
					{
						Debug.LogWarning(string.Format(a.gv(), num));
						flag = false;
					}
					else
					{
						Debug.Log(a.gw());
						flag = true;
					}
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError(a.gx() + ex.Message);
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00006FE8 File Offset: 0x000051E8
	public static bool gsp(bool a)
	{
		bool flag3;
		try
		{
			if (!a)
			{
				bool flag = q.ti();
				bool flag2 = q.tm();
				flag3 = flag && flag2;
			}
			else if (d.mc())
			{
				bool flag4 = q.tl();
				if (flag4)
				{
					q.ti();
				}
				flag3 = flag4;
			}
			else if (!q.tm())
			{
				Debug.LogWarning(a.gy());
				flag3 = false;
			}
			else
			{
				flag3 = q.th();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError(a.gz() + ex.Message);
			flag3 = false;
		}
		return flag3;
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00007068 File Offset: 0x00005268
	private static int tj(string a)
	{
		int num;
		using (Process process = Process.Start(new ProcessStartInfo
		{
			FileName = a.ha(),
			Arguments = a,
			UseShellExecute = false,
			CreateNoWindow = true,
			RedirectStandardOutput = true,
			RedirectStandardError = true
		}))
		{
			if (process == null)
			{
				num = -1;
			}
			else
			{
				Task<string> task = process.StandardOutput.ReadToEndAsync();
				Task<string> task2 = process.StandardError.ReadToEndAsync();
				process.WaitForExit();
				Task.WaitAll(new Task[] { task, task2 });
				num = process.ExitCode;
			}
		}
		return num;
	}

	// Token: 0x0600012A RID: 298
	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int RegGetValueW(IntPtr hKey, string lpSubKey, string lpValue, uint dwFlags, out uint pdwType, IntPtr pvData, ref uint pcbData);

	// Token: 0x0600012B RID: 299 RVA: 0x0000710C File Offset: 0x0000530C
	private static int gny(string a)
	{
		int num;
		using (Process process = Process.Start(new ProcessStartInfo
		{
			FileName = a.hb(),
			Arguments = a,
			UseShellExecute = false,
			CreateNoWindow = true,
			RedirectStandardOutput = true,
			RedirectStandardError = true
		}))
		{
			if (process == null)
			{
				num = -1;
			}
			else
			{
				Task<string> task = process.StandardOutput.ReadToEndAsync();
				Task<string> task2 = process.StandardError.ReadToEndAsync();
				process.WaitForExit();
				Task.WaitAll(new Task[] { task, task2 });
				num = process.ExitCode;
			}
		}
		return num;
	}

	// Token: 0x0600012C RID: 300 RVA: 0x000071B0 File Offset: 0x000053B0
	private static bool te()
	{
		uint num = 0U;
		uint num3;
		int num2 = q.RegGetValueW(q.hgo, a.di(), a.dj(), 2U, out num3, IntPtr.Zero, ref num);
		return num2 == 0 || num2 == 234;
	}

	// Token: 0x0600012D RID: 301 RVA: 0x000071EC File Offset: 0x000053EC
	public static void ts()
	{
		try
		{
			string text = q.td();
			if (!string.IsNullOrEmpty(text))
			{
				if (text.IndexOf(a.hc(), StringComparison.OrdinalIgnoreCase) >= 0)
				{
					PlayerPrefs.SetInt(a.hd(), 1);
					PlayerPrefs.Save();
					if (q.tq(true))
					{
						Debug.Log(a.he());
					}
					else if (q.tq(false))
					{
						PlayerPrefs.SetInt(a.hd(), 0);
						PlayerPrefs.Save();
						Debug.LogWarning(a.hf());
					}
					else
					{
						Debug.LogWarning(a.hg());
					}
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.hh() + ex.Message);
		}
	}

	// Token: 0x0600012E RID: 302 RVA: 0x0000729C File Offset: 0x0000549C
	public static void dsx()
	{
		if (Application.platform != RuntimePlatform.OSXPlayer && Application.platform != RuntimePlatform.OSXEditor)
		{
			return;
		}
		try
		{
			string environmentVariable = Environment.GetEnvironmentVariable(a.hi());
			if (!string.IsNullOrEmpty(environmentVariable))
			{
				string text = Path.Combine(environmentVariable, a.hj(), a.hk(), a.hl());
				if (File.Exists(text))
				{
					File.Delete(text);
					Debug.Log(a.hm());
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.hn() + ex.Message);
		}
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00007328 File Offset: 0x00005528
	private static bool tg()
	{
		string text = q.kmg;
		if (string.IsNullOrEmpty(text))
		{
			return q.te();
		}
		string text2 = q.td();
		return text2 != null && string.Equals(text2, text, StringComparison.OrdinalIgnoreCase);
	}

	// Token: 0x06000130 RID: 304 RVA: 0x0000735C File Offset: 0x0000555C
	private static bool fyd()
	{
		string text = q.kmg;
		if (string.IsNullOrEmpty(text))
		{
			Debug.LogWarning(a.ho());
			return false;
		}
		uint num = (uint)((text.Length + 1) * 2);
		int num2 = q.RegSetKeyValueW(q.hgo, a.hp(), a.hq(), 1U, text, num);
		if (num2 != 0)
		{
			Debug.LogError(string.Format(a.hr(), num2));
			return false;
		}
		return true;
	}

	// Token: 0x06000131 RID: 305 RVA: 0x000073C4 File Offset: 0x000055C4
	private static bool drq()
	{
		string text = q.kmg;
		if (string.IsNullOrEmpty(text))
		{
			Debug.LogWarning(a.hs());
			return false;
		}
		uint num = (uint)((text.Length + 1) * 2);
		int num2 = q.RegSetKeyValueW(q.hgo, a.ht(), a.hu(), 1U, text, num);
		if (num2 != 0)
		{
			Debug.LogError(string.Format(a.hv(), num2));
			return false;
		}
		return true;
	}

	// Token: 0x06000132 RID: 306 RVA: 0x0000742C File Offset: 0x0000562C
	public static void okm()
	{
		if (Application.platform != RuntimePlatform.OSXPlayer && Application.platform != RuntimePlatform.OSXEditor)
		{
			return;
		}
		try
		{
			string environmentVariable = Environment.GetEnvironmentVariable(a.hw());
			if (!string.IsNullOrEmpty(environmentVariable))
			{
				string text = Path.Combine(environmentVariable, a.hx(), a.hy(), a.hz());
				if (File.Exists(text))
				{
					File.Delete(text);
					Debug.Log(a.ia());
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.ib() + ex.Message);
		}
	}

	// Token: 0x06000133 RID: 307 RVA: 0x000074B8 File Offset: 0x000056B8
	public static bool ncm()
	{
		bool flag;
		try
		{
			flag = q.te() || q.tk();
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.ic() + ex.Message);
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000134 RID: 308 RVA: 0x00007504 File Offset: 0x00005704
	private static string td()
	{
		uint num = 0U;
		uint num3;
		int num2 = q.RegGetValueW(q.hgo, a.di(), a.dj(), 2U, out num3, IntPtr.Zero, ref num);
		if (num2 == 2)
		{
			return null;
		}
		if (num2 != 0 && num2 != 234)
		{
			return null;
		}
		if (num == 0U)
		{
			return null;
		}
		IntPtr intPtr = Marshal.AllocHGlobal((int)num);
		string text;
		try
		{
			num2 = q.RegGetValueW(q.hgo, a.di(), a.dj(), 2U, out num3, intPtr, ref num);
			text = ((num2 == 0) ? Marshal.PtrToStringUni(intPtr) : null);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return text;
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00007598 File Offset: 0x00005798
	private static int mi(string a)
	{
		int num;
		using (Process process = Process.Start(new ProcessStartInfo
		{
			FileName = a.id(),
			Arguments = a,
			UseShellExecute = false,
			CreateNoWindow = true,
			RedirectStandardOutput = true,
			RedirectStandardError = true
		}))
		{
			if (process == null)
			{
				num = -1;
			}
			else
			{
				Task<string> task = process.StandardOutput.ReadToEndAsync();
				Task<string> task2 = process.StandardError.ReadToEndAsync();
				process.WaitForExit();
				Task.WaitAll(new Task[] { task, task2 });
				num = process.ExitCode;
			}
		}
		return num;
	}

	// Token: 0x06000136 RID: 310 RVA: 0x0000763C File Offset: 0x0000583C
	public static void tr()
	{
		try
		{
			string fullPath = Path.GetFullPath(Path.Combine(Application.dataPath, a.ie(), a.@if()));
			if (!File.Exists(fullPath))
			{
				if (!PlayerPrefs.HasKey(a.ig()))
				{
					Debug.Log(a.ih());
				}
				else
				{
					if (q.to())
					{
						q.tq(false);
						Debug.Log(a.ii());
					}
					PlayerPrefs.SetInt(a.hd(), 0);
				}
				PlayerPrefs.SetInt(a.ig(), 1);
				PlayerPrefs.Save();
				File.WriteAllText(fullPath, DateTime.UtcNow.ToString(a.ij()));
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.ik() + ex.Message);
		}
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00007700 File Offset: 0x00005900
	private static bool dky()
	{
		string text = q.kmg;
		if (string.IsNullOrEmpty(text))
		{
			return q.te();
		}
		string text2 = q.td();
		return text2 != null && string.Equals(text2, text, StringComparison.OrdinalIgnoreCase);
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00007734 File Offset: 0x00005934
	public static void jbi()
	{
		if (Application.platform != RuntimePlatform.OSXPlayer && Application.platform != RuntimePlatform.OSXEditor)
		{
			return;
		}
		try
		{
			string environmentVariable = Environment.GetEnvironmentVariable(a.il());
			if (!string.IsNullOrEmpty(environmentVariable))
			{
				string text = Path.Combine(environmentVariable, a.im(), a.@in(), a.io());
				if (File.Exists(text))
				{
					File.Delete(text);
					Debug.Log(a.ip());
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.iq() + ex.Message);
		}
	}

	// Token: 0x040000CD RID: 205
	private const string hgg = "BongoWaifu";

	// Token: 0x040000CE RID: 206
	private const string hgh = "BongoWaifu";

	// Token: 0x040000CF RID: 207
	private const string hgi = "-autostart";

	// Token: 0x040000D0 RID: 208
	private const string hgj = "com.bongowaifu.autostart";

	// Token: 0x040000D1 RID: 209
	private const string hgk = ".bongowaifu_install_marker";

	// Token: 0x040000D2 RID: 210
	private const string hgl = "Settings_AutoStart";

	// Token: 0x040000D3 RID: 211
	private const string hgm = "Settings_AutoStartFreshCheckV2";

	// Token: 0x040000D4 RID: 212
	private const string hgn = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

	// Token: 0x040000D5 RID: 213
	private static readonly IntPtr hgo = new IntPtr(-2147483647);

	// Token: 0x040000D6 RID: 214
	private const uint hgp = 1U;

	// Token: 0x040000D7 RID: 215
	private const uint hgq = 2U;

	// Token: 0x040000D8 RID: 216
	private const int hgr = 0;

	// Token: 0x040000D9 RID: 217
	private const int hgs = 2;

	// Token: 0x040000DA RID: 218
	private const int hgt = 234;
}
