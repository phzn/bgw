using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using BongoWaifu.Mcp.Prompts;
using BongoWaifu.Mcp.SpeechBubble;
using BongoWaifu.Mcp.Threading;
using BongoWaifu.Mcp.Tools;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace BongoWaifu.Mcp
{
	// Token: 0x02000147 RID: 327
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class McpDialogueServer : MonoBehaviour
	{
		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x0007486E File Offset: 0x00072A6E
		// (set) Token: 0x06001775 RID: 6005 RVA: 0x00074875 File Offset: 0x00072A75
		[Nullable(2)]
		public static McpDialogueServer Instance
		{
			[NullableContext(2)]
			get;
			[NullableContext(2)]
			private set;
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06001776 RID: 6006 RVA: 0x0007487D File Offset: 0x00072A7D
		// (set) Token: 0x06001777 RID: 6007 RVA: 0x00074885 File Offset: 0x00072A85
		public McpDialogueServer.State CurrentState { get; private set; }

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x0007488E File Offset: 0x00072A8E
		// (set) Token: 0x06001779 RID: 6009 RVA: 0x00074896 File Offset: 0x00072A96
		public int ActivePort { get; private set; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x0007489F File Offset: 0x00072A9F
		// (set) Token: 0x0600177B RID: 6011 RVA: 0x000748A7 File Offset: 0x00072AA7
		[Nullable(2)]
		public string LastError
		{
			[NullableContext(2)]
			get;
			[NullableContext(2)]
			private set;
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x000748B0 File Offset: 0x00072AB0
		// (set) Token: 0x0600177D RID: 6013 RVA: 0x000748B8 File Offset: 0x00072AB8
		public int ConnectedAiCount { get; private set; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x000748C1 File Offset: 0x00072AC1
		public int QueueLength
		{
			get
			{
				DialogueQueue queue = this._queue;
				if (queue == null)
				{
					return 0;
				}
				return queue.Count;
			}
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x000748D4 File Offset: 0x00072AD4
		private void Awake()
		{
			if (McpDialogueServer.Instance != null && McpDialogueServer.Instance != this)
			{
				global::UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			McpDialogueServer.Instance = this;
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00074902 File Offset: 0x00072B02
		private void OnDestroy()
		{
			if (McpDialogueServer.Instance == this)
			{
				McpDialogueServer.Instance = null;
			}
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00074918 File Offset: 0x00072B18
		public void StartServer()
		{
			if (this.CurrentState == McpDialogueServer.State.Running || this.CurrentState == McpDialogueServer.State.Starting)
			{
				return;
			}
			this.CurrentState = McpDialogueServer.State.Starting;
			this.LastError = null;
			this._shutdownCts = new CancellationTokenSource();
			foreach (int num in this.portCandidates)
			{
				try
				{
					this._listener = new HttpListener();
					this._listener.Prefixes.Add(string.Format("http://127.0.0.1:{0}/", num));
					this._listener.Start();
					this.ActivePort = num;
					break;
				}
				catch (HttpListenerException)
				{
					this._listener = null;
				}
				catch (Exception ex)
				{
					this.LastError = ex.Message;
					this.CurrentState = McpDialogueServer.State.OtherError;
					this._listener = null;
					return;
				}
			}
			if (this._listener == null)
			{
				this.CurrentState = McpDialogueServer.State.PortFail;
				return;
			}
			this._queue = new DialogueQueue();
			if (this.bubbleController != null)
			{
				this.bubbleController.Queue = this._queue;
			}
			this._sayTool = new SayTool(this._queue);
			this._askTool = new AskAndWaitTool(this._queue);
			this._getStateTool = new GetGameStateTool();
			this.CurrentState = McpDialogueServer.State.Running;
			Task.Run(() => this.AcceptLoop(this._shutdownCts.Token));
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x00074A70 File Offset: 0x00072C70
		public void StopServer()
		{
			if (this.CurrentState == McpDialogueServer.State.Stopped)
			{
				return;
			}
			CancellationTokenSource shutdownCts = this._shutdownCts;
			if (shutdownCts != null)
			{
				shutdownCts.Cancel();
			}
			try
			{
				HttpListener listener = this._listener;
				if (listener != null)
				{
					listener.Stop();
				}
			}
			catch
			{
			}
			if (this.bubbleController != null)
			{
				UnityMainThreadDispatcher.Instance.Enqueue(delegate
				{
					this.bubbleController.ForceHideAndDismissCurrent();
				});
			}
			foreach (KeyValuePair<string, McpSession> keyValuePair in this._sessions)
			{
				foreach (TaskCompletionSource<AskResult> taskCompletionSource in keyValuePair.Value.PendingAsks.Values)
				{
					taskCompletionSource.TrySetResult(new AskResult("dismissed", null, null));
				}
			}
			try
			{
				Task.WhenAll(this._activeSseWrites.Values).Wait(TimeSpan.FromSeconds(2.0));
			}
			catch
			{
			}
			DialogueQueue queue = this._queue;
			if (queue != null)
			{
				queue.Clear();
			}
			this._sessions.Clear();
			this._activeSseWrites.Clear();
			if (this.bubbleController != null)
			{
				this.bubbleController.Queue = null;
			}
			try
			{
				HttpListener listener2 = this._listener;
				if (listener2 != null)
				{
					listener2.Close();
				}
			}
			catch
			{
			}
			this._listener = null;
			this.CurrentState = McpDialogueServer.State.Stopped;
			this.ActivePort = 0;
			this.ConnectedAiCount = 0;
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00074C28 File Offset: 0x00072E28
		private void OnApplicationQuit()
		{
			this.StopServer();
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00074C30 File Offset: 0x00072E30
		private async Task AcceptLoop(CancellationToken ct)
		{
			McpDialogueServer.<>c__DisplayClass38_0 CS$<>8__locals1 = new McpDialogueServer.<>c__DisplayClass38_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.ct = ct;
			while (!CS$<>8__locals1.ct.IsCancellationRequested && this._listener != null && this._listener.IsListening)
			{
				McpDialogueServer.<>c__DisplayClass38_1 CS$<>8__locals2 = new McpDialogueServer.<>c__DisplayClass38_1();
				CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
				try
				{
					HttpListenerContext httpListenerContext = await this._listener.GetContextAsync();
					CS$<>8__locals2.ctx = httpListenerContext;
				}
				catch
				{
					break;
				}
				Task.Run(() => CS$<>8__locals2.CS$<>8__locals1.<>4__this.HandleRequest(CS$<>8__locals2.ctx, CS$<>8__locals2.CS$<>8__locals1.ct));
				CS$<>8__locals2 = null;
			}
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00074C7C File Offset: 0x00072E7C
		private async Task HandleRequest(HttpListenerContext ctx, CancellationToken ct)
		{
			try
			{
				IPEndPoint remoteEndPoint = ctx.Request.RemoteEndPoint;
				if (remoteEndPoint == null || !IPAddress.IsLoopback(remoteEndPoint.Address))
				{
					McpDialogueServer.WriteStatus(ctx.Response, 403, a.ekw());
				}
				else if (!OriginValidator.IsAllowed(ctx.Request.Headers[a.ekx()]))
				{
					McpDialogueServer.WriteStatus(ctx.Response, 403, a.eky());
				}
				else
				{
					if (!(ctx.Request.HttpMethod != a.ekz()))
					{
						Uri url = ctx.Request.Url;
						if (!(((url != null) ? url.AbsolutePath : null) != a.ela()))
						{
							string @string;
							using (MemoryStream ms = new MemoryStream())
							{
								await ctx.Request.InputStream.CopyToAsync(ms);
								@string = Encoding.UTF8.GetString(ms.ToArray());
							}
							MemoryStream ms = null;
							JsonRpcRequest jsonRpcRequest;
							try
							{
								jsonRpcRequest = McpProtocolRouter.ParseJsonRpc(@string);
							}
							catch
							{
								string text = McpProtocolRouter.BuildError(null, -32700, a.elc(), null);
								McpDialogueServer.WriteStatus(ctx.Response, 400, text);
								return;
							}
							if (jsonRpcRequest.IsNotification)
							{
								ctx.Response.StatusCode = 202;
								ctx.Response.Close();
								return;
							}
							string method = jsonRpcRequest.Method;
							if (!(method == a.eld()))
							{
								if (!(method == a.ele()))
								{
									if (!(method == a.elf()))
									{
										if (!(method == a.elg()))
										{
											if (!(method == a.elh()))
											{
												McpSession mcpSession;
												if (!(method == a.eli()))
												{
													McpDialogueServer.WriteStatus(ctx.Response, 200, McpProtocolRouter.BuildError(jsonRpcRequest.Id, -32601, a.elk() + jsonRpcRequest.Method, null));
												}
												else if (!this.TryGetSession(ctx, out mcpSession))
												{
													McpDialogueServer.WriteStatus(ctx.Response, 400, a.elj());
												}
												else
												{
													McpDialogueServer.WriteStatus(ctx.Response, 200, McpProtocolRouter.BuildResult(jsonRpcRequest.Id, new JObject()));
												}
											}
											else
											{
												this.HandlePromptsGet(ctx, jsonRpcRequest);
											}
										}
										else
										{
											this.HandlePromptsList(ctx, jsonRpcRequest);
										}
									}
									else
									{
										await this.HandleToolsCall(ctx, jsonRpcRequest, ct);
									}
								}
								else
								{
									this.HandleToolsList(ctx, jsonRpcRequest);
								}
							}
							else
							{
								this.HandleInitialize(ctx, jsonRpcRequest);
							}
							return;
						}
					}
					McpDialogueServer.WriteStatus(ctx.Response, 404, a.elb());
				}
			}
			catch (Exception ex)
			{
				Debug.LogException(ex);
				try
				{
					McpDialogueServer.WriteStatus(ctx.Response, 500, a.ell());
				}
				catch
				{
				}
			}
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00074CD0 File Offset: 0x00072ED0
		private void HandleInitialize(HttpListenerContext ctx, JsonRpcRequest req)
		{
			string text = Guid.NewGuid().ToString();
			this._sessions[text] = new McpSession(text);
			this.ConnectedAiCount = this._sessions.Count;
			JObject jobject = new JObject();
			jobject["protocolVersion"] = "2025-03-26";
			string text2 = "serverInfo";
			JObject jobject2 = new JObject();
			jobject2["name"] = "BongoWaifu MCP";
			jobject2["version"] = "1.0.0";
			jobject[text2] = jobject2;
			string text3 = "capabilities";
			JObject jobject3 = new JObject();
			string text4 = "tools";
			JObject jobject4 = new JObject();
			jobject4["listChanged"] = false;
			jobject3[text4] = jobject4;
			string text5 = "prompts";
			JObject jobject5 = new JObject();
			jobject5["listChanged"] = false;
			jobject3[text5] = jobject5;
			jobject[text3] = jobject3;
			jobject["instructions"] = McpDialogueServer.BuildServerInstructions();
			JObject jobject6 = jobject;
			ctx.Response.Headers["Mcp-Session-Id"] = text;
			McpDialogueServer.WriteStatus(ctx.Response, 200, McpProtocolRouter.BuildResult(req.Id, jobject6));
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00074E04 File Offset: 0x00073004
		private void HandleToolsList(HttpListenerContext ctx, JsonRpcRequest req)
		{
			McpSession mcpSession;
			if (!this.TryGetSession(ctx, out mcpSession))
			{
				McpDialogueServer.WriteStatus(ctx.Response, 400, "{\"error\":\"missing_session\"}");
				return;
			}
			JArray jarray = new JArray(new object[]
			{
				JToken.Parse(this._sayTool.Schema),
				JToken.Parse(this._askTool.Schema),
				JToken.Parse(this._getStateTool.Schema)
			});
			JObject jobject = new JObject();
			jobject["tools"] = jarray;
			JObject jobject2 = jobject;
			McpDialogueServer.WriteStatus(ctx.Response, 200, McpProtocolRouter.BuildResult(req.Id, jobject2));
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00074EA8 File Offset: 0x000730A8
		private void HandlePromptsList(HttpListenerContext ctx, JsonRpcRequest req)
		{
			McpSession mcpSession;
			if (!this.TryGetSession(ctx, out mcpSession))
			{
				McpDialogueServer.WriteStatus(ctx.Response, 400, "{\"error\":\"missing_session\"}");
				return;
			}
			JObject jobject = McpPromptRegistry.BuildListResult();
			McpDialogueServer.WriteStatus(ctx.Response, 200, McpProtocolRouter.BuildResult(req.Id, jobject));
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x00074EF8 File Offset: 0x000730F8
		private void HandlePromptsGet(HttpListenerContext ctx, JsonRpcRequest req)
		{
			McpSession mcpSession;
			if (!this.TryGetSession(ctx, out mcpSession))
			{
				McpDialogueServer.WriteStatus(ctx.Response, 400, "{\"error\":\"missing_session\"}");
				return;
			}
			JToken @params = req.Params;
			string text = (string)((@params != null) ? @params["name"] : null);
			if (string.IsNullOrEmpty(text))
			{
				McpDialogueServer.WriteStatus(ctx.Response, 200, McpProtocolRouter.BuildError(req.Id, -32602, "Missing prompt name", null));
				return;
			}
			JObject jobject = McpPromptRegistry.BuildGetResult(text);
			if (jobject == null)
			{
				McpDialogueServer.WriteStatus(ctx.Response, 200, McpProtocolRouter.BuildError(req.Id, -32602, "Unknown prompt: " + text, null));
				return;
			}
			McpDialogueServer.WriteStatus(ctx.Response, 200, McpProtocolRouter.BuildResult(req.Id, jobject));
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00074FC8 File Offset: 0x000731C8
		private async Task HandleToolsCall(HttpListenerContext ctx, JsonRpcRequest req, CancellationToken ct)
		{
			McpSession mcpSession;
			if (!this.TryGetSession(ctx, out mcpSession))
			{
				McpDialogueServer.WriteStatus(ctx.Response, 400, a.elj());
			}
			else
			{
				mcpSession.Touch();
				JToken @params = req.Params;
				string text = (string)((@params != null) ? @params[a.bdh()] : null);
				JToken params2 = req.Params;
				JToken jtoken = ((params2 != null) ? params2[a.elm()] : null);
				if (!(text == a.eln()))
				{
					if (!(text == a.elo()))
					{
						if (!(text == a.elp()))
						{
							McpDialogueServer.WriteStatus(ctx.Response, 200, McpProtocolRouter.BuildError(req.Id, -32601, a.elq() + text, null));
							goto IL_02A6;
						}
					}
					else
					{
						AskAndWaitTool.PrepareResult prepareResult = this._askTool.Prepare(mcpSession.SessionId, jtoken);
						if (prepareResult.IsBusyOrError)
						{
							McpDialogueServer.WriteStatus(ctx.Response, 200, McpProtocolRouter.BuildCallToolResult(req.Id, prepareResult.ErrorPayloadJson, true));
							goto IL_02A6;
						}
						Task task = this._askTool.StreamSseAsync(ctx.Response, req.Id, prepareResult.Message, mcpSession, this._shutdownCts.Token);
						Guid sseId = Guid.NewGuid();
						this._activeSseWrites.TryAdd(sseId, task);
						try
						{
							await task;
							goto IL_02A6;
						}
						finally
						{
							Task task2;
							this._activeSseWrites.TryRemove(sseId, out task2);
						}
					}
					ValueTuple<bool, string> valueTuple = this._getStateTool.Handle(jtoken);
					bool item = valueTuple.Item1;
					string item2 = valueTuple.Item2;
					McpDialogueServer.WriteStatus(ctx.Response, 200, McpProtocolRouter.BuildCallToolResult(req.Id, item2, item));
				}
				else
				{
					ValueTuple<bool, string> valueTuple2 = this._sayTool.Handle(mcpSession.SessionId, jtoken);
					bool item3 = valueTuple2.Item1;
					string item4 = valueTuple2.Item2;
					McpDialogueServer.WriteStatus(ctx.Response, 200, McpProtocolRouter.BuildCallToolResult(req.Id, item4, item3));
				}
				IL_02A6:;
			}
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x0007501C File Offset: 0x0007321C
		private bool TryGetSession(HttpListenerContext ctx, [Nullable(2)] out McpSession session)
		{
			session = null;
			string text = ctx.Request.Headers["Mcp-Session-Id"];
			return !string.IsNullOrEmpty(text) && this._sessions.TryGetValue(text, out session);
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00075059 File Offset: 0x00073259
		private static string BuildServerInstructions()
		{
			return CompanionPersona.BuildMcpInstructions();
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00075060 File Offset: 0x00073260
		private static void WriteStatus(HttpListenerResponse response, int status, string body)
		{
			try
			{
				response.StatusCode = status;
				response.ContentType = "application/json";
				byte[] bytes = Encoding.UTF8.GetBytes(body);
				response.ContentLength64 = (long)bytes.Length;
				response.OutputStream.Write(bytes, 0, bytes.Length);
				response.Close();
			}
			catch
			{
			}
		}

		// Token: 0x04000BD7 RID: 3031
		[SerializeField]
		private SpeechBubbleController bubbleController;

		// Token: 0x04000BD8 RID: 3032
		[SerializeField]
		private int[] portCandidates = new int[]
		{
			7337, 7338, 7339, 7340, 7341, 7342, 7343, 7344, 7345, 7346,
			7347, 7348, 7349, 7350, 7351, 7352, 7353, 7354, 7355, 7356
		};

		// Token: 0x04000BDD RID: 3037
		[Nullable(2)]
		private HttpListener _listener;

		// Token: 0x04000BDE RID: 3038
		[Nullable(2)]
		private DialogueQueue _queue;

		// Token: 0x04000BDF RID: 3039
		private readonly ConcurrentDictionary<string, McpSession> _sessions = new ConcurrentDictionary<string, McpSession>();

		// Token: 0x04000BE0 RID: 3040
		private readonly ConcurrentDictionary<Guid, Task> _activeSseWrites = new ConcurrentDictionary<Guid, Task>();

		// Token: 0x04000BE1 RID: 3041
		[Nullable(2)]
		private CancellationTokenSource _shutdownCts;

		// Token: 0x04000BE2 RID: 3042
		[Nullable(2)]
		private SayTool _sayTool;

		// Token: 0x04000BE3 RID: 3043
		[Nullable(2)]
		private AskAndWaitTool _askTool;

		// Token: 0x04000BE4 RID: 3044
		[Nullable(2)]
		private GetGameStateTool _getStateTool;

		// Token: 0x02000148 RID: 328
		[NullableContext(0)]
		public enum State
		{
			// Token: 0x04000BE6 RID: 3046
			Stopped,
			// Token: 0x04000BE7 RID: 3047
			Starting,
			// Token: 0x04000BE8 RID: 3048
			Running,
			// Token: 0x04000BE9 RID: 3049
			PortFail,
			// Token: 0x04000BEA RID: 3050
			OtherError
		}
	}
}
