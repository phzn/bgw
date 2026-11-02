using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x0200010C RID: 268
public static class fi
{
	// Token: 0x17000107 RID: 263
	// (get) Token: 0x0600136E RID: 4974 RVA: 0x0005F6E8 File Offset: 0x0005D8E8
	// (set) Token: 0x0600136F RID: 4975 RVA: 0x0005F6FC File Offset: 0x0005D8FC
	public static string kth
	{
		get
		{
			return PlayerPrefs.GetString(a.dto(), string.Empty);
		}
		set
		{
			string text = value ?? string.Empty;
			if (text.Length > 40)
			{
				text = text.Substring(0, 40);
			}
			PlayerPrefs.SetString(a.dto(), text);
			PlayerPrefs.Save();
		}
	}

	// Token: 0x04000A2C RID: 2604
	private const string ipi = "Settings_MpCustomText";
}
