using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BongoWaifu.Mcp
{
	// Token: 0x02000150 RID: 336
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class McpSession
	{
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x00075F6C File Offset: 0x0007416C
		public string SessionId { get; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x00075F74 File Offset: 0x00074174
		// (set) Token: 0x060017B5 RID: 6069 RVA: 0x00075F7C File Offset: 0x0007417C
		public DateTime LastSeenUtc { get; set; }

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x00075F85 File Offset: 0x00074185
		public ConcurrentDictionary<string, TaskCompletionSource<AskResult>> PendingAsks { get; } = new ConcurrentDictionary<string, TaskCompletionSource<AskResult>>();

		// Token: 0x060017B7 RID: 6071 RVA: 0x00075F8D File Offset: 0x0007418D
		public McpSession(string sessionId)
		{
			this.SessionId = sessionId;
			this.LastSeenUtc = DateTime.UtcNow;
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00075FB2 File Offset: 0x000741B2
		public void Touch()
		{
			this.LastSeenUtc = DateTime.UtcNow;
		}
	}
}
