using System;
using System.Runtime.CompilerServices;

namespace BongoWaifu.AiApi
{
	// Token: 0x02000167 RID: 359
	public static class AiModelFilter
	{
		// Token: 0x06001825 RID: 6181 RVA: 0x00078824 File Offset: 0x00076A24
		[NullableContext(2)]
		public static bool IsLikelyChatModel(string id)
		{
			if (string.IsNullOrEmpty(id))
			{
				return false;
			}
			string text = id.ToLowerInvariant();
			foreach (string text2 in AiModelFilter.NonChatMarkers)
			{
				if (text.Contains(text2))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04000C57 RID: 3159
		[Nullable(1)]
		private static readonly string[] NonChatMarkers = new string[]
		{
			"embedding", "whisper", "transcribe", "tts", "audio", "speech", "realtime", "dall-e", "dalle", "image",
			"moderation", "davinci", "babbage"
		};
	}
}
