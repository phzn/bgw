using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BongoWaifu.AiApi
{
	// Token: 0x0200016E RID: 366
	[NullableContext(1)]
	[Nullable(0)]
	public static class AiProviderCatalog
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x000791C7 File Offset: 0x000773C7
		public static IReadOnlyList<AiProviderConfig> All
		{
			get
			{
				return AiProviderCatalog._all;
			}
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x000791D0 File Offset: 0x000773D0
		public static AiProviderConfig For(AiProviderId id)
		{
			for (int i = 0; i < AiProviderCatalog._all.Length; i++)
			{
				if (AiProviderCatalog._all[i].Id == id)
				{
					return AiProviderCatalog._all[i];
				}
			}
			return AiProviderCatalog._all[0];
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x0007920D File Offset: 0x0007740D
		public static AiProviderConfig For(int id)
		{
			return AiProviderCatalog.For((AiProviderId)id);
		}

		// Token: 0x04000C79 RID: 3193
		[Nullable(new byte[] { 1, 0, 1, 1 })]
		private static readonly IReadOnlyList<ValueTuple<string, string>> OpenRouterHeaders = new ValueTuple<string, string>[]
		{
			new ValueTuple<string, string>("HTTP-Referer", "https://store.steampowered.com/app/3861430"),
			new ValueTuple<string, string>("X-Title", "BongoWaifu")
		};

		// Token: 0x04000C7A RID: 3194
		[Nullable(new byte[] { 1, 0, 1, 1 })]
		private static readonly IReadOnlyList<ValueTuple<string, string>> AnthropicHeaders = new ValueTuple<string, string>[]
		{
			new ValueTuple<string, string>("anthropic-version", "2023-06-01")
		};

		// Token: 0x04000C7B RID: 3195
		private static readonly AiProviderConfig[] _all = new AiProviderConfig[]
		{
			new AiProviderConfig(AiProviderId.OpenAI, "OpenAI", "https://api.openai.com/v1", "/chat/completions", "/models", AiAuthStyle.BearerHeader, "Authorization", null, false),
			new AiProviderConfig(AiProviderId.Anthropic, "Anthropic", "https://api.anthropic.com", "/v1/messages", "/v1/models", AiAuthStyle.XApiKeyHeader, "x-api-key", AiProviderCatalog.AnthropicHeaders, false),
			new AiProviderConfig(AiProviderId.Gemini, "Gemini", "https://generativelanguage.googleapis.com", "/v1beta", "/v1beta/models", AiAuthStyle.UrlQueryParam, null, null, false),
			new AiProviderConfig(AiProviderId.OpenRouter, "OpenRouter", "https://openrouter.ai/api/v1", "/chat/completions", "/models", AiAuthStyle.BearerHeader, "Authorization", AiProviderCatalog.OpenRouterHeaders, false),
			new AiProviderConfig(AiProviderId.OpenAiCompatible, "OpenAI-compatible", "", "/chat/completions", "/models", AiAuthStyle.BearerHeader, "Authorization", null, true)
		};
	}
}
