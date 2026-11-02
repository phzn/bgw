using System;
using System.Runtime.CompilerServices;

namespace BongoWaifu.Mcp
{
	// Token: 0x02000151 RID: 337
	public static class OriginValidator
	{
		// Token: 0x060017B9 RID: 6073 RVA: 0x00075FC0 File Offset: 0x000741C0
		[NullableContext(2)]
		public static bool IsAllowed(string origin)
		{
			if (string.IsNullOrEmpty(origin))
			{
				return true;
			}
			if (origin == "null")
			{
				return false;
			}
			Uri uri;
			if (!Uri.TryCreate(origin, UriKind.Absolute, out uri))
			{
				return false;
			}
			if (uri.Scheme != "http")
			{
				return false;
			}
			string text = uri.Host.Trim(new char[] { '[', ']' });
			return text == "127.0.0.1" || text == "localhost" || text == "::1";
		}
	}
}
