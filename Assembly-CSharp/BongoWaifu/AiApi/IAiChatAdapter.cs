using System;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace BongoWaifu.AiApi
{
	// Token: 0x0200017C RID: 380
	[NullableContext(1)]
	public interface IAiChatAdapter
	{
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060018EF RID: 6383
		AiProviderId Id { get; }

		// Token: 0x060018F0 RID: 6384
		UnityWebRequest BuildChatRequest(AiProviderConfig cfg, string baseUrl, string apiKey, AiChatRequest req);

		// Token: 0x060018F1 RID: 6385
		AiChatResult ParseChatResponse(long httpStatus, string body, UnityWebRequest.Result result);

		// Token: 0x060018F2 RID: 6386
		UnityWebRequest BuildModelsRequest(AiProviderConfig cfg, string baseUrl, string apiKey);

		// Token: 0x060018F3 RID: 6387
		AiModelList ParseModelsResponse(long httpStatus, string body, UnityWebRequest.Result result);
	}
}
