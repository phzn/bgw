using System;
using System.Runtime.CompilerServices;
using BongoWaifu.Mcp.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BongoWaifu.Mcp.Tools
{
	// Token: 0x02000159 RID: 345
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SayTool
	{
		// Token: 0x060017DD RID: 6109 RVA: 0x00077478 File Offset: 0x00075678
		public SayTool(DialogueQueue queue)
		{
			this._queue = queue;
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x00077487 File Offset: 0x00075687
		public string Schema
		{
			get
			{
				return "{\n          \"name\": \"say\",\n          \"description\": \"Display a non-blocking speech bubble on the desktop companion. Returns immediately after queueing.\",\n          \"inputSchema\": {\n            \"type\": \"object\",\n            \"properties\": {\n              \"text\": { \"type\": \"string\", \"maxLength\": 1000 },\n              \"duration_seconds\": { \"type\": \"number\", \"minimum\": 2, \"maximum\": 30 }\n            },\n            \"required\": [\"text\"]\n          }\n        }";
			}
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x00077490 File Offset: 0x00075690
		[return: TupleElementNames(new string[] { "isError", "payload" })]
		[return: Nullable(new byte[] { 0, 1 })]
		public ValueTuple<bool, string> Handle(string sessionId, [Nullable(2)] JToken args)
		{
			string text = ((string)((args != null) ? args["text"] : null)) ?? string.Empty;
			if (DisplayWidth.Measure(text) > 400)
			{
				return new ValueTuple<bool, string>(true, "{\"error\":\"text_too_long\",\"detail\":\"display width > 400\"}");
			}
			float? num;
			if (args == null)
			{
				num = null;
			}
			else
			{
				JToken jtoken = args["duration_seconds"];
				num = ((jtoken != null) ? jtoken.Value<float?>() : null);
			}
			float? num2 = num;
			if (num2 != null && (num2.Value < 2f || num2.Value > 30f))
			{
				return new ValueTuple<bool, string>(true, "{\"error\":\"invalid_duration\"}");
			}
			float num3 = DurationCalculator.Compute(text, num2);
			DialogueMessage dialogueMessage = new DialogueMessage(Guid.NewGuid().ToString(), MessageKind.Say, sessionId, text, num3, null, null, DateTime.UtcNow);
			this._queue.Enqueue(dialogueMessage);
			JObject jobject = new JObject();
			jobject["queued"] = true;
			jobject["message_id"] = dialogueMessage.MessageId;
			jobject["queue_position"] = this._queue.Count;
			JObject jobject2 = jobject;
			return new ValueTuple<bool, string>(false, jobject2.ToString(Formatting.None, Array.Empty<JsonConverter>()));
		}

		// Token: 0x04000C2B RID: 3115
		private readonly DialogueQueue _queue;
	}
}
