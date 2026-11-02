using System;
using System.Runtime.CompilerServices;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

// Token: 0x02000013 RID: 19
public static class BgmLoc
{
	// Token: 0x060000CB RID: 203 RVA: 0x000055D4 File Offset: 0x000037D4
	[NullableContext(1)]
	public static string Get(string key, string fallback)
	{
		string text;
		try
		{
			if (!LocalizationSettings.InitializationOperation.IsDone)
			{
				text = fallback;
			}
			else
			{
				StringTable table = LocalizationSettings.StringDatabase.GetTable("UI", null);
				StringTableEntry stringTableEntry = ((table != null) ? table.GetEntry(key) : null);
				string text2 = ((stringTableEntry != null) ? stringTableEntry.GetLocalizedString() : null);
				text = (string.IsNullOrEmpty(text2) ? fallback : text2);
			}
		}
		catch
		{
			text = fallback;
		}
		return text;
	}
}
