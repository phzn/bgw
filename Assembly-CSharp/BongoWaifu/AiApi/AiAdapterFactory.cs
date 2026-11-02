using System;
using System.Runtime.CompilerServices;

namespace BongoWaifu.AiApi
{
	// Token: 0x0200016F RID: 367
	public static class AiAdapterFactory
	{
		// Token: 0x0600184F RID: 6223 RVA: 0x00079345 File Offset: 0x00077545
		[NullableContext(1)]
		public static IAiChatAdapter Create(AiProviderId id)
		{
			if (id == AiProviderId.Anthropic)
			{
				return new AnthropicAdapter();
			}
			if (id != AiProviderId.Gemini)
			{
				return new OpenAiCompatibleAdapter(id);
			}
			return new GeminiAdapter();
		}
	}
}
