using System;
using System.Runtime.CompilerServices;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

namespace BongoWaifu.AiApi
{
	// Token: 0x02000166 RID: 358
	[NullableContext(1)]
	[Nullable(0)]
	public static class AiLoc
	{
		// Token: 0x06001823 RID: 6179 RVA: 0x00078734 File Offset: 0x00076934
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

		// Token: 0x06001824 RID: 6180 RVA: 0x000787A8 File Offset: 0x000769A8
		public static string DescribeError(AiErrorKind err)
		{
			switch (err)
			{
			case AiErrorKind.InvalidKey:
				return AiLoc.Get("aiconn_err_invalid_key", "Invalid API key.");
			case AiErrorKind.RateLimited:
				return AiLoc.Get("aiconn_err_rate", "Rate limited — try later.");
			case AiErrorKind.Network:
				return AiLoc.Get("aiconn_err_network", "Network error.");
			case AiErrorKind.Timeout:
				return AiLoc.Get("aiconn_err_timeout", "Request timed out.");
			}
			return AiLoc.Get("aiconn_err_bad", "Unexpected response.");
		}
	}
}
