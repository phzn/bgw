using System;
using System.Globalization;

namespace BongoWaifu.Mcp.Text
{
	// Token: 0x0200015B RID: 347
	public static class DisplayWidth
	{
		// Token: 0x060017E5 RID: 6117 RVA: 0x0007767C File Offset: 0x0007587C
		public static int Measure(string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				return 0;
			}
			int num = 0;
			TextElementEnumerator textElementEnumerator = StringInfo.GetTextElementEnumerator(text);
			while (textElementEnumerator.MoveNext())
			{
				object obj = textElementEnumerator.Current;
				int num2 = char.ConvertToUtf32((string)obj, 0);
				if (!DisplayWidth.IsZeroWidth(num2))
				{
					num += (DisplayWidth.IsCjk(num2) ? 2 : 1);
				}
			}
			return num;
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x000776D0 File Offset: 0x000758D0
		private static bool IsCjk(int cp)
		{
			return (cp >= 4352 && cp <= 4447) || (cp >= 11904 && cp <= 12350) || (cp >= 12353 && cp <= 13311) || (cp >= 13312 && cp <= 19903) || (cp >= 19968 && cp <= 40959) || (cp >= 40960 && cp <= 42191) || (cp >= 44032 && cp <= 55203) || (cp >= 63744 && cp <= 64255) || (cp >= 65072 && cp <= 65103) || (cp >= 65280 && cp <= 65376) || (cp >= 127744 && cp <= 129791) || (cp >= 131072 && cp <= 196607);
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x000777B0 File Offset: 0x000759B0
		private static bool IsZeroWidth(int cp)
		{
			return cp == 8203 || cp == 8204 || cp == 8205 || cp == 65279;
		}
	}
}
