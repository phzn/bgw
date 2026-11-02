using System;
using System.Globalization;
using UnityEngine;

namespace BongoWaifu.Mcp.Text
{
	// Token: 0x0200015C RID: 348
	public static class DurationCalculator
	{
		// Token: 0x060017E8 RID: 6120 RVA: 0x000777D4 File Offset: 0x000759D4
		public static float Compute(string text, float? overrideSeconds = null)
		{
			if (overrideSeconds != null)
			{
				return Mathf.Clamp(overrideSeconds.Value, 2f, 30f);
			}
			if (string.IsNullOrEmpty(text))
			{
				return 2f;
			}
			int num = 0;
			int num2 = 0;
			TextElementEnumerator textElementEnumerator = StringInfo.GetTextElementEnumerator(text);
			while (textElementEnumerator.MoveNext())
			{
				object obj = textElementEnumerator.Current;
				int num3 = char.ConvertToUtf32((string)obj, 0);
				if (!DurationCalculator.IsZeroWidth(num3))
				{
					if (DurationCalculator.IsCjk(num3))
					{
						num++;
					}
					else
					{
						num2++;
					}
				}
			}
			return Mathf.Clamp(2f + (float)num * 0.15f + (float)num2 * 0.05f, 2f, 30f);
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x00077878 File Offset: 0x00075A78
		private static bool IsCjk(int cp)
		{
			return (cp >= 4352 && cp <= 4447) || (cp >= 11904 && cp <= 12350) || (cp >= 12353 && cp <= 13311) || (cp >= 13312 && cp <= 19903) || (cp >= 19968 && cp <= 40959) || (cp >= 40960 && cp <= 42191) || (cp >= 44032 && cp <= 55203) || (cp >= 63744 && cp <= 64255) || (cp >= 65072 && cp <= 65103) || (cp >= 65280 && cp <= 65376) || (cp >= 127744 && cp <= 129791) || (cp >= 131072 && cp <= 196607);
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x000777B0 File Offset: 0x000759B0
		private static bool IsZeroWidth(int cp)
		{
			return cp == 8203 || cp == 8204 || cp == 8205 || cp == 65279;
		}

		// Token: 0x04000C2F RID: 3119
		public const float MinSeconds = 2f;

		// Token: 0x04000C30 RID: 3120
		public const float MaxSeconds = 30f;

		// Token: 0x04000C31 RID: 3121
		private const float BaseSeconds = 2f;

		// Token: 0x04000C32 RID: 3122
		private const float PerCjkSeconds = 0.15f;

		// Token: 0x04000C33 RID: 3123
		private const float PerOtherSeconds = 0.05f;
	}
}
