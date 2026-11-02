using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BongoWaifu.Mcp
{
	// Token: 0x0200014F RID: 335
	[NullableContext(1)]
	[Nullable(0)]
	public static class McpProtocolRouter
	{
		// Token: 0x060017AF RID: 6063 RVA: 0x00075DDC File Offset: 0x00073FDC
		public static JsonRpcRequest ParseJsonRpc(string json)
		{
			JObject jobject = JObject.Parse(json);
			return new JsonRpcRequest(((string)jobject["jsonrpc"]) ?? "2.0", jobject["id"], ((string)jobject["method"]) ?? "", jobject["params"]);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00075E40 File Offset: 0x00074040
		public static string BuildError([Nullable(2)] JToken id, int code, string message, [Nullable(2)] JToken data = null)
		{
			JObject jobject = new JObject();
			jobject["code"] = code;
			jobject["message"] = message;
			JObject jobject2 = jobject;
			if (data != null)
			{
				jobject2["data"] = data;
			}
			JObject jobject3 = new JObject();
			jobject3["jsonrpc"] = "2.0";
			jobject3["id"] = id;
			jobject3["error"] = jobject2;
			return jobject3.ToString(Formatting.None, Array.Empty<JsonConverter>());
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00075EC1 File Offset: 0x000740C1
		public static string BuildResult([Nullable(2)] JToken id, JToken result)
		{
			JObject jobject = new JObject();
			jobject["jsonrpc"] = "2.0";
			jobject["id"] = id;
			jobject["result"] = result;
			return jobject.ToString(Formatting.None, Array.Empty<JsonConverter>());
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x00075F00 File Offset: 0x00074100
		public static string BuildCallToolResult([Nullable(2)] JToken id, string payloadJson, bool isError)
		{
			JObject jobject = new JObject();
			string text = "content";
			JArray jarray = new JArray();
			JObject jobject2 = new JObject();
			jobject2["type"] = "text";
			jobject2["text"] = payloadJson;
			jarray.Add(jobject2);
			jobject[text] = jarray;
			jobject["isError"] = isError;
			JObject jobject3 = jobject;
			return McpProtocolRouter.BuildResult(id, jobject3);
		}
	}
}
