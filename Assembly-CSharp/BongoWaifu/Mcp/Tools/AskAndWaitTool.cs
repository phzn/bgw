using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using BongoWaifu.Mcp.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BongoWaifu.Mcp.Tools
{
	// Token: 0x02000152 RID: 338
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class AskAndWaitTool
	{
		// Token: 0x060017BA RID: 6074 RVA: 0x0007604A File Offset: 0x0007424A
		public AskAndWaitTool(DialogueQueue queue)
		{
			this._queue = queue;
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x00076059 File Offset: 0x00074259
		public string Schema
		{
			get
			{
				return "{\n          \"name\": \"ask_and_wait\",\n          \"description\": \"Display a speech bubble with 2-4 buttons; blocks until player clicks, times out, or dismisses.\",\n          \"inputSchema\": {\n            \"type\": \"object\",\n            \"properties\": {\n              \"text\": { \"type\": \"string\" },\n              \"buttons\": { \"type\": \"array\", \"items\": { \"type\": \"string\" }, \"minItems\": 2, \"maxItems\": 4 },\n              \"response_timeout_seconds\": { \"type\": \"number\", \"minimum\": 5, \"maximum\": 600 }\n            },\n            \"required\": [\"text\", \"buttons\"]\n          }\n        }";
			}
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00076060 File Offset: 0x00074260
		public AskAndWaitTool.PrepareResult Prepare(string sessionId, [Nullable(2)] JToken args)
		{
			string text = ((string)((args != null) ? args["text"] : null)) ?? string.Empty;
			if (DisplayWidth.Measure(text) > 400)
			{
				return new AskAndWaitTool.PrepareResult(true, "{\"error\":\"text_too_long\"}", null);
			}
			JArray jarray = ((args != null) ? args["buttons"] : null) as JArray;
			if (jarray == null || jarray.Count < 2 || jarray.Count > 4)
			{
				return new AskAndWaitTool.PrepareResult(true, "{\"error\":\"invalid_button_count\"}", null);
			}
			List<string> list = new List<string>(jarray.Count);
			foreach (JToken jtoken in jarray)
			{
				string text2 = ((string)jtoken) ?? string.Empty;
				if (DisplayWidth.Measure(text2) > 30)
				{
					return new AskAndWaitTool.PrepareResult(true, "{\"error\":\"button_too_long\"}", null);
				}
				list.Add(text2);
			}
			float? num;
			if (args == null)
			{
				num = null;
			}
			else
			{
				JToken jtoken2 = args["response_timeout_seconds"];
				num = ((jtoken2 != null) ? jtoken2.Value<float?>() : null);
			}
			float num2 = num ?? 120f;
			if (num2 < 5f || num2 > 600f)
			{
				return new AskAndWaitTool.PrepareResult(true, "{\"error\":\"invalid_timeout\"}", null);
			}
			TaskCompletionSource<AskResult> taskCompletionSource = new TaskCompletionSource<AskResult>(TaskCreationOptions.RunContinuationsAsynchronously);
			DialogueMessage dialogueMessage = new DialogueMessage(Guid.NewGuid().ToString(), MessageKind.Ask, sessionId, text, num2, list, taskCompletionSource, DateTime.UtcNow);
			if (this._queue.Enqueue(dialogueMessage) == EnqueueOutcome.Busy)
			{
				return new AskAndWaitTool.PrepareResult(true, "{\"error\":\"busy\"}", null);
			}
			return new AskAndWaitTool.PrepareResult(false, null, dialogueMessage);
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x0007621C File Offset: 0x0007441C
		public async Task StreamSseAsync(HttpListenerResponse response, [Nullable(2)] JToken requestId, DialogueMessage msg, McpSession session, CancellationToken serverShutdown)
		{
			AskAndWaitTool.<>c__DisplayClass6_0 CS$<>8__locals1 = new AskAndWaitTool.<>c__DisplayClass6_0();
			CS$<>8__locals1.response = response;
			CS$<>8__locals1.response.ContentType = a.els();
			CS$<>8__locals1.response.Headers[a.elt()] = a.elu();
			CS$<>8__locals1.response.Headers[a.elv()] = a.elw();
			CS$<>8__locals1.response.StatusCode = 200;
			if (msg.AskCompletion == null)
			{
				try
				{
					CS$<>8__locals1.response.Close();
				}
				catch
				{
				}
			}
			else
			{
				session.PendingAsks[msg.MessageId] = msg.AskCompletion;
				CS$<>8__locals1.writeLock = new SemaphoreSlim(1, 1);
				CS$<>8__locals1.heartbeatCts = CancellationTokenSource.CreateLinkedTokenSource(new CancellationToken[] { serverShutdown });
				try
				{
					Task heartbeat = Task.Run(delegate
					{
						AskAndWaitTool.<>c__DisplayClass6_0.<<StreamSseAsync>b__0>d <<StreamSseAsync>b__0>d;
						<<StreamSseAsync>b__0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
						<<StreamSseAsync>b__0>d.<>4__this = CS$<>8__locals1;
						<<StreamSseAsync>b__0>d.<>1__state = -1;
						<<StreamSseAsync>b__0>d.<>t__builder.Start<AskAndWaitTool.<>c__DisplayClass6_0.<<StreamSseAsync>b__0>d>(ref <<StreamSseAsync>b__0>d);
						return <<StreamSseAsync>b__0>d.<>t__builder.Task;
					}, CS$<>8__locals1.heartbeatCts.Token);
					AskResult result = null;
					object obj = null;
					try
					{
						try
						{
							AskResult askResult = await msg.AskCompletion.Task;
							result = askResult;
						}
						catch (Exception)
						{
						}
					}
					catch (object obj)
					{
					}
					CS$<>8__locals1.heartbeatCts.Cancel();
					try
					{
						await heartbeat;
					}
					catch
					{
					}
					object obj2 = obj;
					if (obj2 != null)
					{
						Exception ex = obj2 as Exception;
						if (ex == null)
						{
							throw obj2;
						}
						ExceptionDispatchInfo.Capture(ex).Throw();
					}
					obj = null;
					if (result != null)
					{
						JObject jobject = new JObject();
						jobject[a.elx()] = result.Outcome;
						jobject[a.ely()] = result.Button;
						jobject[a.elz()] = result.ButtonIndex;
						string text = McpProtocolRouter.BuildCallToolResult(requestId, jobject.ToString(Formatting.None, Array.Empty<JsonConverter>()), false);
						string text2 = a.ema() + text + a.bhd();
						try
						{
							await AskAndWaitTool.WriteRawAsync(CS$<>8__locals1.response, CS$<>8__locals1.writeLock, text2);
						}
						catch
						{
						}
					}
					TaskCompletionSource<AskResult> taskCompletionSource;
					session.PendingAsks.TryRemove(msg.MessageId, out taskCompletionSource);
					try
					{
						CS$<>8__locals1.response.Close();
					}
					catch
					{
					}
				}
				finally
				{
					if (CS$<>8__locals1.heartbeatCts != null)
					{
						((IDisposable)CS$<>8__locals1.heartbeatCts).Dispose();
					}
				}
			}
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00076284 File Offset: 0x00074484
		private static async Task WriteRawAsync(HttpListenerResponse response, SemaphoreSlim gate, string text)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			await gate.WaitAsync();
			try
			{
				await response.OutputStream.WriteAsync(bytes, 0, bytes.Length);
				await response.OutputStream.FlushAsync();
			}
			finally
			{
				gate.Release();
			}
		}

		// Token: 0x04000C0B RID: 3083
		private readonly DialogueQueue _queue;

		// Token: 0x02000153 RID: 339
		[NullableContext(2)]
		[Nullable(0)]
		public sealed class PrepareResult : IEquatable<AskAndWaitTool.PrepareResult>
		{
			// Token: 0x060017BF RID: 6079 RVA: 0x000762D7 File Offset: 0x000744D7
			public PrepareResult(bool IsBusyOrError, string ErrorPayloadJson, DialogueMessage Message)
			{
				this.IsBusyOrError = IsBusyOrError;
				this.ErrorPayloadJson = ErrorPayloadJson;
				this.Message = Message;
				base..ctor();
			}

			// Token: 0x1700017D RID: 381
			// (get) Token: 0x060017C0 RID: 6080 RVA: 0x000762F4 File Offset: 0x000744F4
			[Nullable(1)]
			[CompilerGenerated]
			private Type EqualityContract
			{
				[NullableContext(1)]
				[CompilerGenerated]
				get
				{
					return typeof(AskAndWaitTool.PrepareResult);
				}
			}

			// Token: 0x1700017E RID: 382
			// (get) Token: 0x060017C1 RID: 6081 RVA: 0x00076300 File Offset: 0x00074500
			// (set) Token: 0x060017C2 RID: 6082 RVA: 0x00076308 File Offset: 0x00074508
			public bool IsBusyOrError { get; set; }

			// Token: 0x1700017F RID: 383
			// (get) Token: 0x060017C3 RID: 6083 RVA: 0x00076311 File Offset: 0x00074511
			// (set) Token: 0x060017C4 RID: 6084 RVA: 0x00076319 File Offset: 0x00074519
			public string ErrorPayloadJson { get; set; }

			// Token: 0x17000180 RID: 384
			// (get) Token: 0x060017C5 RID: 6085 RVA: 0x00076322 File Offset: 0x00074522
			// (set) Token: 0x060017C6 RID: 6086 RVA: 0x0007632A File Offset: 0x0007452A
			public DialogueMessage Message { get; set; }

			// Token: 0x060017C7 RID: 6087 RVA: 0x00076334 File Offset: 0x00074534
			[NullableContext(1)]
			[CompilerGenerated]
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("PrepareResult");
				stringBuilder.Append(" { ");
				if (this.PrintMembers(stringBuilder))
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append('}');
				return stringBuilder.ToString();
			}

			// Token: 0x060017C8 RID: 6088 RVA: 0x00076380 File Offset: 0x00074580
			[NullableContext(1)]
			[CompilerGenerated]
			private bool PrintMembers(StringBuilder builder)
			{
				RuntimeHelpers.EnsureSufficientExecutionStack();
				builder.Append("IsBusyOrError = ");
				builder.Append(this.IsBusyOrError.ToString());
				builder.Append(", ErrorPayloadJson = ");
				builder.Append(this.ErrorPayloadJson);
				builder.Append(", Message = ");
				builder.Append(this.Message);
				return true;
			}

			// Token: 0x060017C9 RID: 6089 RVA: 0x000763EC File Offset: 0x000745EC
			[CompilerGenerated]
			public static bool operator !=(AskAndWaitTool.PrepareResult left, AskAndWaitTool.PrepareResult right)
			{
				return !(left == right);
			}

			// Token: 0x060017CA RID: 6090 RVA: 0x000763F8 File Offset: 0x000745F8
			[CompilerGenerated]
			public static bool operator ==(AskAndWaitTool.PrepareResult left, AskAndWaitTool.PrepareResult right)
			{
				return left == right || (left != null && left.Equals(right));
			}

			// Token: 0x060017CB RID: 6091 RVA: 0x0007640C File Offset: 0x0007460C
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return ((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<IsBusyOrError>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<ErrorPayloadJson>k__BackingField)) * -1521134295 + EqualityComparer<DialogueMessage>.Default.GetHashCode(this.<Message>k__BackingField);
			}

			// Token: 0x060017CC RID: 6092 RVA: 0x0007646E File Offset: 0x0007466E
			[CompilerGenerated]
			public override bool Equals(object obj)
			{
				return this.Equals(obj as AskAndWaitTool.PrepareResult);
			}

			// Token: 0x060017CD RID: 6093 RVA: 0x0007647C File Offset: 0x0007467C
			[CompilerGenerated]
			public bool Equals(AskAndWaitTool.PrepareResult other)
			{
				return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<bool>.Default.Equals(this.<IsBusyOrError>k__BackingField, other.<IsBusyOrError>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<ErrorPayloadJson>k__BackingField, other.<ErrorPayloadJson>k__BackingField) && EqualityComparer<DialogueMessage>.Default.Equals(this.<Message>k__BackingField, other.<Message>k__BackingField));
			}

			// Token: 0x060017CF RID: 6095 RVA: 0x000764F5 File Offset: 0x000746F5
			[CompilerGenerated]
			private PrepareResult([Nullable(1)] AskAndWaitTool.PrepareResult original)
			{
				this.IsBusyOrError = original.<IsBusyOrError>k__BackingField;
				this.ErrorPayloadJson = original.<ErrorPayloadJson>k__BackingField;
				this.Message = original.<Message>k__BackingField;
			}

			// Token: 0x060017D0 RID: 6096 RVA: 0x00076521 File Offset: 0x00074721
			[CompilerGenerated]
			public void Deconstruct(out bool IsBusyOrError, out string ErrorPayloadJson, out DialogueMessage Message)
			{
				IsBusyOrError = this.IsBusyOrError;
				ErrorPayloadJson = this.ErrorPayloadJson;
				Message = this.Message;
			}
		}
	}
}
