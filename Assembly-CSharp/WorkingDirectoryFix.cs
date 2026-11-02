using System;
using System.IO;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x020000AE RID: 174
public static class WorkingDirectoryFix
{
	// Token: 0x06000947 RID: 2375 RVA: 0x0003873C File Offset: 0x0003693C
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
	private static void EnsureWorkingDirectory()
	{
		try
		{
			string text = d.mf();
			if (!string.IsNullOrEmpty(text))
			{
				string directoryName = Path.GetDirectoryName(text);
				if (!string.IsNullOrEmpty(directoryName))
				{
					string text2 = Path.GetFullPath(Directory.GetCurrentDirectory()).TrimEnd(new char[]
					{
						Path.DirectorySeparatorChar,
						Path.AltDirectorySeparatorChar
					});
					string text3 = Path.GetFullPath(directoryName).TrimEnd(new char[]
					{
						Path.DirectorySeparatorChar,
						Path.AltDirectorySeparatorChar
					});
					if (!string.Equals(text2, text3, StringComparison.OrdinalIgnoreCase))
					{
						Directory.SetCurrentDirectory(directoryName);
						Debug.Log(a.coy() + directoryName);
					}
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.coz() + ex.Message);
		}
	}
}
