using System;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine.Networking;

namespace BongoWaifu.AiApi
{
	// Token: 0x0200017D RID: 381
	[NullableContext(1)]
	[Nullable(0)]
	internal static class AiHttp
	{
		// Token: 0x060018F4 RID: 6388 RVA: 0x0007BA50 File Offset: 0x00079C50
		public static UnityWebRequest PostJson(string url, string json)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(url, "POST");
			byte[] bytes = Encoding.UTF8.GetBytes(json ?? "");
			unityWebRequest.uploadHandler = new UploadHandlerRaw(bytes);
			unityWebRequest.downloadHandler = new DownloadHandlerBuffer();
			unityWebRequest.SetRequestHeader("Content-Type", "application/json");
			return unityWebRequest;
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x0007BAA4 File Offset: 0x00079CA4
		public static UnityWebRequest GetJson(string url)
		{
			return UnityWebRequest.Get(url);
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x0007BAAC File Offset: 0x00079CAC
		public static void ApplyExtraHeaders(UnityWebRequest req, AiProviderConfig cfg)
		{
			if (cfg.ExtraHeaders == null)
			{
				return;
			}
			foreach (ValueTuple<string, string> valueTuple in cfg.ExtraHeaders)
			{
				string item = valueTuple.Item1;
				string item2 = valueTuple.Item2;
				req.SetRequestHeader(item, item2);
			}
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x0007BB10 File Offset: 0x00079D10
		public static AiErrorKind Classify(long status, UnityWebRequest.Result result)
		{
			if (result == UnityWebRequest.Result.ConnectionError)
			{
				return AiErrorKind.Network;
			}
			if (result == UnityWebRequest.Result.DataProcessingError)
			{
				return AiErrorKind.BadResponse;
			}
			if (status == 401L || status == 403L)
			{
				return AiErrorKind.InvalidKey;
			}
			if (status == 429L)
			{
				return AiErrorKind.RateLimited;
			}
			if (status >= 500L)
			{
				return AiErrorKind.Network;
			}
			if (status >= 400L)
			{
				return AiErrorKind.BadResponse;
			}
			return AiErrorKind.None;
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x0007BB5F File Offset: 0x00079D5F
		public static string Trunc([Nullable(2)] string s, int max = 4000)
		{
			if (string.IsNullOrEmpty(s))
			{
				return "";
			}
			if (s.Length <= max)
			{
				return s;
			}
			return s.Substring(0, max);
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x0007BB82 File Offset: 0x00079D82
		public static string TrimEndSlash(string url)
		{
			if (!string.IsNullOrEmpty(url))
			{
				return url.TrimEnd('/');
			}
			return "";
		}

		// Token: 0x04000CD7 RID: 3287
		public const int MaxDetailChars = 4000;
	}
}
