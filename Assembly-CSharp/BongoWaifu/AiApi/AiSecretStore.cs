using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace BongoWaifu.AiApi
{
	// Token: 0x02000173 RID: 371
	[NullableContext(1)]
	[Nullable(0)]
	public static class AiSecretStore
	{
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x000798FC File Offset: 0x00077AFC
		private static string FilePath
		{
			get
			{
				string text;
				if ((text = AiSecretStore._cachedPath) == null)
				{
					text = (AiSecretStore._cachedPath = Path.Combine(Application.persistentDataPath, "ai_credential.dat"));
				}
				return text;
			}
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0007991C File Offset: 0x00077B1C
		private static string Field(int providerId)
		{
			return providerId.ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0007992C File Offset: 0x00077B2C
		[NullableContext(2)]
		private static JObject ReadRoot()
		{
			JObject jobject;
			try
			{
				string filePath = AiSecretStore.FilePath;
				if (!File.Exists(filePath))
				{
					jobject = null;
				}
				else
				{
					string text = File.ReadAllText(filePath);
					if (string.IsNullOrEmpty(text))
					{
						jobject = null;
					}
					else
					{
						string text2 = ci.bhy(ci.kou, text);
						if (string.IsNullOrEmpty(text2))
						{
							jobject = null;
						}
						else
						{
							jobject = JObject.Parse(text2);
						}
					}
				}
			}
			catch
			{
				jobject = null;
			}
			return jobject;
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x00079998 File Offset: 0x00077B98
		[return: Nullable(2)]
		private static JObject KeysOrNull(JObject root)
		{
			return root["keys"] as JObject;
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x000799AC File Offset: 0x00077BAC
		private static bool WriteRoot(JObject root)
		{
			bool flag;
			try
			{
				string text = root.ToString(Formatting.None, Array.Empty<JsonConverter>());
				string text2 = ci.bhx(ci.kou, text);
				File.WriteAllText(AiSecretStore.FilePath, text2);
				flag = true;
			}
			catch (Exception ex)
			{
				Debug.LogWarning("[AiSecretStore] WriteRoot 失敗：" + ex.GetType().Name);
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00079A14 File Offset: 0x00077C14
		public static bool HasKey(int providerId)
		{
			JObject jobject = AiSecretStore.ReadRoot();
			if (jobject == null)
			{
				return false;
			}
			JObject jobject2 = AiSecretStore.KeysOrNull(jobject);
			return !string.IsNullOrEmpty((string)((jobject2 != null) ? jobject2[AiSecretStore.Field(providerId)] : null));
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00079A54 File Offset: 0x00077C54
		[NullableContext(2)]
		public static bool StoreKey(int providerId, string plainKey)
		{
			JObject jobject = AiSecretStore.ReadRoot() ?? new JObject();
			jobject.Remove("k");
			JObject jobject2 = jobject["keys"] as JObject;
			if (jobject2 == null)
			{
				jobject2 = new JObject();
				jobject["keys"] = jobject2;
			}
			if (string.IsNullOrEmpty(plainKey))
			{
				jobject2.Remove(AiSecretStore.Field(providerId));
			}
			else
			{
				jobject2[AiSecretStore.Field(providerId)] = plainKey;
			}
			if (!jobject2.HasValues)
			{
				AiSecretStore.ClearAll();
				return true;
			}
			return AiSecretStore.WriteRoot(jobject);
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00079AE0 File Offset: 0x00077CE0
		public static void ClearKey(int providerId)
		{
			AiSecretStore.StoreKey(providerId, null);
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x00079AEC File Offset: 0x00077CEC
		public static void ClearAll()
		{
			try
			{
				string filePath = AiSecretStore.FilePath;
				if (File.Exists(filePath))
				{
					File.Delete(filePath);
				}
			}
			catch (Exception ex)
			{
				Debug.LogWarning("[AiSecretStore] ClearAll 失敗：" + ex.GetType().Name);
			}
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00079B3C File Offset: 0x00077D3C
		[NullableContext(2)]
		public static string GetKeyForRequest(int providerId)
		{
			JObject jobject = AiSecretStore.ReadRoot();
			if (jobject == null)
			{
				return null;
			}
			JObject jobject2 = AiSecretStore.KeysOrNull(jobject);
			string text = (string)((jobject2 != null) ? jobject2[AiSecretStore.Field(providerId)] : null);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return null;
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x00079B80 File Offset: 0x00077D80
		[NullableContext(2)]
		public static string GetMaskedHint(int providerId)
		{
			string text;
			try
			{
				string keyForRequest = AiSecretStore.GetKeyForRequest(providerId);
				if (string.IsNullOrEmpty(keyForRequest))
				{
					text = null;
				}
				else
				{
					text = ((keyForRequest.Length <= 10) ? "••••••" : (keyForRequest.Substring(0, 6) + "••••••" + keyForRequest.Substring(keyForRequest.Length - 4)));
				}
			}
			catch
			{
				text = null;
			}
			return text;
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00079BEC File Offset: 0x00077DEC
		public static bool MigrateLegacyKey(int providerId)
		{
			JObject jobject = AiSecretStore.ReadRoot();
			if (jobject == null)
			{
				return false;
			}
			string text = (string)jobject["k"];
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			JObject jobject2 = jobject["keys"] as JObject;
			if (jobject2 == null)
			{
				jobject2 = new JObject();
				jobject["keys"] = jobject2;
			}
			if (string.IsNullOrEmpty((string)jobject2[AiSecretStore.Field(providerId)]))
			{
				jobject2[AiSecretStore.Field(providerId)] = text;
			}
			jobject.Remove("k");
			return AiSecretStore.WriteRoot(jobject);
		}

		// Token: 0x04000C98 RID: 3224
		private const string FileName = "ai_credential.dat";

		// Token: 0x04000C99 RID: 3225
		private const string KeysField = "keys";

		// Token: 0x04000C9A RID: 3226
		private const string LegacyField = "k";

		// Token: 0x04000C9B RID: 3227
		[Nullable(2)]
		private static string _cachedPath;
	}
}
