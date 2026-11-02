using System;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

namespace BongoWaifu.Multiplayer
{
	// Token: 0x02000120 RID: 288
	public static class MultiplayerLoc
	{
		// Token: 0x060014C4 RID: 5316 RVA: 0x00066848 File Offset: 0x00064A48
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
}
