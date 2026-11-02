using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x02000054 RID: 84
public static class LogManager
{
	// Token: 0x0600048E RID: 1166 RVA: 0x000168E4 File Offset: 0x00014AE4
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void Init()
	{
		try
		{
			Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
			Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
			Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.ScriptOnly);
			Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.ScriptOnly);
			Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.ScriptOnly);
			if (Interlocked.CompareExchange(ref LogManager.hqv, 1, 0) == 0)
			{
				LogManager.hqt = Stopwatch.GetTimestamp();
				Application.logMessageReceivedThreaded += LogManager.bgt;
				Application.quitting += LogManager.bgs;
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x00016964 File Offset: 0x00014B64
	private static void bgs()
	{
		try
		{
			Application.logMessageReceivedThreaded -= LogManager.bgt;
			Application.quitting -= LogManager.bgs;
			Interlocked.Exchange(ref LogManager.hqv, 0);
		}
		catch
		{
		}
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x000169B4 File Offset: 0x00014BB4
	private static void bgt(string a, string b, LogType c)
	{
		try
		{
			if (Interlocked.CompareExchange(ref LogManager.hqw, 0, 0) != 1)
			{
				if (a == null || !a.StartsWith(a.wf(), StringComparison.Ordinal))
				{
					if ((Stopwatch.GetTimestamp() - LogManager.hqt) / Stopwatch.Frequency >= 300L)
					{
						object obj = LogManager.hqu;
						lock (obj)
						{
							if ((Stopwatch.GetTimestamp() - LogManager.hqt) / Stopwatch.Frequency >= 300L)
							{
								Interlocked.Exchange(ref LogManager.hqw, 1);
								try
								{
									LogManager.bgu();
								}
								finally
								{
									Interlocked.Exchange(ref LogManager.hqw, 0);
								}
								LogManager.hqt = Stopwatch.GetTimestamp();
								LogManager.hqs.Clear();
							}
						}
					}
					if (LogManager.hqs.Count >= 200)
					{
						object obj = LogManager.hqu;
						lock (obj)
						{
							if (LogManager.hqs.Count >= 200)
							{
								LogManager.hqs.Clear();
							}
						}
					}
					string text = ((a == null) ? a.tk() : ((a.Length > 80) ? a.Substring(0, 80) : a));
					LogManager.hqs.AddOrUpdate(text, 1, new Func<string, int, int>(LogManager.<>c.<>9.bgr));
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x00016B6C File Offset: 0x00014D6C
	private static void bgu()
	{
		try
		{
			foreach (KeyValuePair<string, int> keyValuePair in LogManager.hqs)
			{
				if (keyValuePair.Value > 200)
				{
					Debug.LogError(string.Format(a.wg(), a.wf(), keyValuePair.Key, keyValuePair.Value));
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x04000268 RID: 616
	private const int hqo = 200;

	// Token: 0x04000269 RID: 617
	private const int hqp = 200;

	// Token: 0x0400026A RID: 618
	private const long hqq = 300L;

	// Token: 0x0400026B RID: 619
	private const string hqr = "[LogManager]";

	// Token: 0x0400026C RID: 620
	private static readonly ConcurrentDictionary<string, int> hqs = new ConcurrentDictionary<string, int>();

	// Token: 0x0400026D RID: 621
	private static long hqt;

	// Token: 0x0400026E RID: 622
	private static readonly object hqu = new object();

	// Token: 0x0400026F RID: 623
	private static int hqv;

	// Token: 0x04000270 RID: 624
	private static int hqw;
}
