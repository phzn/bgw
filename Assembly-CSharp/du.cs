using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Steamworks;
using UnityEngine;

// Token: 0x020000B0 RID: 176
public class du : MonoBehaviour
{
	// Token: 0x0600094D RID: 2381 RVA: 0x00038940 File Offset: 0x00036B40
	private void mm(UserStatsReceived_t a)
	{
		if (a.m_nGameID != (ulong)this.ial.AppID().m_AppId)
		{
			return;
		}
		if (a.m_eResult != EResult.k_EResultOK)
		{
			Debug.LogError(string.Format(a.cpl(), a.m_eResult, -8609f));
			this.cdw();
			return;
		}
		if (bq.knd)
		{
			Debug.Log(a.cpk());
		}
		this.iai = true;
		this.cdx();
		this.cea();
		Action action = du.iae;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x000389CE File Offset: 0x00036BCE
	private void mzt(Action a)
	{
		if (SteamManager.ibh)
		{
			return;
		}
		if (this.iai)
		{
			a();
			return;
		}
		if (bq.knd)
		{
			Debug.Log(a.cpm());
		}
		this.iao.Enqueue(a);
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x00038A04 File Offset: 0x00036C04
	private void cyx(du.STEAM_STAT_ID a, int b)
	{
		foreach (du.AchievementCondition achievementCondition in du.iaz)
		{
			if (achievementCondition.requiredStat == a && b >= achievementCondition.requiredValue)
			{
				this.cei(achievementCondition.achievementId);
			}
		}
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x00038A70 File Offset: 0x00036C70
	private void kyc()
	{
		if (!SteamManager.krd)
		{
			return;
		}
		if (this.iam != null)
		{
			return;
		}
		this.cdp();
		if (this.ial.AppID().m_AppId == 0U)
		{
			this.ial = new CGameID(SteamUtils.GetAppID());
		}
		if (bq.knd)
		{
			Debug.Log(a.cpn());
		}
		this.cds();
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x00038ACD File Offset: 0x00036CCD
	private void ecr()
	{
		while (this.iao.Count > 0)
		{
			this.iao.Dequeue()();
		}
	}

	// Token: 0x14000010 RID: 16
	// (add) Token: 0x060009A4 RID: 2468 RVA: 0x0003A0F0 File Offset: 0x000382F0
	// (remove) Token: 0x06000952 RID: 2386 RVA: 0x00038AF0 File Offset: 0x00036CF0
	public static event Action iae;

	// Token: 0x06000953 RID: 2387 RVA: 0x00038B23 File Offset: 0x00036D23
	public void ceb()
	{
		if (this.iai)
		{
			this.ced();
			this.iaq = 0f;
		}
	}

	// Token: 0x14000011 RID: 17
	// (add) Token: 0x06000998 RID: 2456 RVA: 0x00039D5C File Offset: 0x00037F5C
	// (remove) Token: 0x06000954 RID: 2388 RVA: 0x00038B40 File Offset: 0x00036D40
	public static event Action<du.ACHIEVEMENT> iaf;

	// Token: 0x06000955 RID: 2389 RVA: 0x00038B74 File Offset: 0x00036D74
	public bool cek(du.ACHIEVEMENT a, out uint b)
	{
		b = 0U;
		bool flag;
		return SteamManager.krd && this.iai && (SteamUserStats.GetAchievementAndUnlockTime(a.ToString(), out flag, out b) && flag);
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x00038BAC File Offset: 0x00036DAC
	public static void cem(du.STEAM_STAT_ID a, Action<du.StatUpdatedEventArgs> b)
	{
		Action<du.StatUpdatedEventArgs> action;
		if (du.iag.TryGetValue(a, out action))
		{
			du.iag[a] = (Action<du.StatUpdatedEventArgs>)Delegate.Combine(action, b);
			return;
		}
		du.iag[a] = b;
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000957 RID: 2391 RVA: 0x00038BEC File Offset: 0x00036DEC
	// (set) Token: 0x0600096C RID: 2412 RVA: 0x00039240 File Offset: 0x00037440
	public bool iai { get; private set; }

	// Token: 0x06000958 RID: 2392 RVA: 0x00038BF4 File Offset: 0x00036DF4
	private void lop()
	{
		if (SteamManager.ibh)
		{
			return;
		}
		if (this.iai && this.iap)
		{
			this.iaq += Time.deltaTime;
			if (this.iaq >= -4559f)
			{
				if (this.iat.Count > 0)
				{
					if (Time.realtimeSinceStartup - this.iav < 6680f)
					{
						return;
					}
					Debug.LogWarning(string.Format(a.cpo(), 5012f));
					this.iaw += this.iat.Count;
					this.iat.Clear();
				}
				this.iaq = -5504f;
				base.StartCoroutine(this.cdr());
			}
		}
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x00038CB4 File Offset: 0x00036EB4
	private void glv(UserStatsReceived_t a)
	{
		if (a.m_nGameID != (ulong)this.ial.AppID().m_AppId)
		{
			return;
		}
		if (a.m_eResult != EResult.k_EResultOK)
		{
			Debug.LogError(string.Format(a.cpq(), a.m_eResult, -2850f));
			this.cdw();
			return;
		}
		if (bq.knd)
		{
			Debug.Log(a.cpp());
		}
		this.iai = true;
		this.cdx();
		this.cea();
		Action action = du.iae;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x06000969 RID: 2409 RVA: 0x00039107 File Offset: 0x00037307
	// (set) Token: 0x0600095A RID: 2394 RVA: 0x00038D42 File Offset: 0x00036F42
	public int iaj { get; private set; }

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x0600095B RID: 2395 RVA: 0x00038D4B File Offset: 0x00036F4B
	// (set) Token: 0x0600096F RID: 2415 RVA: 0x0003939B File Offset: 0x0003759B
	public int iak { get; private set; }

	// Token: 0x0600095C RID: 2396 RVA: 0x00038D53 File Offset: 0x00036F53
	private void yu()
	{
		if (SteamManager.ibh)
		{
			return;
		}
		this.ias = this.iaj;
		this.iat.Enqueue(this.ias);
		this.iav = Time.realtimeSinceStartup;
		SteamUserStats.StoreStats();
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x00038D8B File Offset: 0x00036F8B
	private void Awake()
	{
		if (du.iah == null)
		{
			du.iah = this;
			global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			return;
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x00038DB7 File Offset: 0x00036FB7
	private void OnEnable()
	{
		SteamManager.ibn -= this.cdq;
		SteamManager.ibn += this.cdq;
		if (SteamManager.krd)
		{
			this.cdq();
		}
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x00038DE8 File Offset: 0x00036FE8
	public bool ibg(du.STEAM_STAT_ID a, out int b)
	{
		string text = a.ToString();
		bool stat = SteamUserStats.GetStat(text, out b);
		if (!stat)
		{
			if (bq.knd)
			{
				Debug.LogWarning(a.cpr() + text + a.cps());
			}
			b = 0;
		}
		return stat;
	}

	// Token: 0x06000960 RID: 2400 RVA: 0x00038E2C File Offset: 0x0003702C
	private void glw()
	{
		if (this.iay == null)
		{
			return;
		}
		base.StopCoroutine(this.iay);
		this.iay = null;
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x00038E4C File Offset: 0x0003704C
	private void gud(du.STEAM_STAT_ID a, int b)
	{
		foreach (du.AchievementCondition achievementCondition in du.iaz)
		{
			if (achievementCondition.requiredStat == a && b >= achievementCondition.requiredValue)
			{
				this.cei(achievementCondition.achievementId);
			}
		}
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x00038EB8 File Offset: 0x000370B8
	public void mxb()
	{
		if (!SteamManager.krd)
		{
			Debug.LogError(a.cpt());
			return;
		}
		AppId_t appID = SteamUtils.GetAppID();
		if (bq.knd)
		{
			Debug.Log(string.Format(a.cpu(), appID));
		}
		if (appID.m_AppId == 0U)
		{
			Debug.LogError(a.cpv());
			return;
		}
		this.iai = false;
		SteamUserStats.RequestUserStats(SteamUser.GetSteamID());
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x00038F20 File Offset: 0x00037120
	private void odo(UserStatsReceived_t a)
	{
		if (a.m_nGameID != (ulong)this.ial.AppID().m_AppId)
		{
			return;
		}
		if (a.m_eResult != EResult.k_EResultOK)
		{
			Debug.LogError(string.Format(a.cpx(), a.m_eResult, 2028f));
			this.cdw();
			return;
		}
		if (bq.knd)
		{
			Debug.Log(a.cpw());
		}
		this.iai = true;
		this.cdx();
		this.cea();
		Action action = du.iae;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x00038FB0 File Offset: 0x000371B0
	private void OnDisable()
	{
		SteamManager.ibn -= this.cdq;
		this.cdx();
		base.StopAllCoroutines();
		Callback<UserStatsReceived_t> callback = this.iam;
		if (callback != null)
		{
			callback.Unregister();
		}
		this.iam = null;
		Callback<UserStatsStored_t> callback2 = this.ian;
		if (callback2 != null)
		{
			callback2.Unregister();
		}
		this.ian = null;
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x0003900C File Offset: 0x0003720C
	private void kge()
	{
		if (!SteamManager.krd)
		{
			return;
		}
		if (this.iam != null)
		{
			return;
		}
		this.cdp();
		if (this.ial.AppID().m_AppId == 0U)
		{
			this.ial = new CGameID(SteamUtils.GetAppID());
		}
		if (bq.knd)
		{
			Debug.Log(a.cpy());
		}
		this.cds();
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x00039069 File Offset: 0x00037269
	private void OnDestroy()
	{
		du.iac = null;
		du.iad = null;
		du.iae = null;
		du.iaf = null;
		du.iag.Clear();
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x00039090 File Offset: 0x00037290
	public void ezl(du.STEAM_STAT_ID a, int b, du.STEAM_STAT_OP c)
	{
		du.dr dr = new du.dr();
		dr.hzs = this;
		dr.hzt = a;
		dr.hzu = b;
		dr.hzv = c;
		this.cdz(new Action(dr.ccq));
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x000390D1 File Offset: 0x000372D1
	private void cdz(Action a)
	{
		if (SteamManager.ibh)
		{
			return;
		}
		if (this.iai)
		{
			a();
			return;
		}
		if (bq.knd)
		{
			Debug.Log(a.cpz());
		}
		this.iao.Enqueue(a);
	}

	// Token: 0x0600096A RID: 2410 RVA: 0x00039110 File Offset: 0x00037310
	private void cee(du.STEAM_STAT_ID a, int b, du.STEAM_STAT_OP c)
	{
		if (SteamManager.ibh)
		{
			return;
		}
		string text = a.ToString();
		int num;
		if (!SteamUserStats.GetStat(text, out num))
		{
			if (bq.knd)
			{
				Debug.LogWarning(a.cqa() + text + a.cqb());
			}
			return;
		}
		int num2 = num;
		bool flag = false;
		switch (c)
		{
		case du.STEAM_STAT_OP.Add:
			num2 = num + b;
			flag = true;
			break;
		case du.STEAM_STAT_OP.Set:
			if (num != b)
			{
				num2 = b;
				flag = true;
			}
			break;
		case du.STEAM_STAT_OP.Max:
			if (b > num)
			{
				num2 = b;
				flag = true;
			}
			break;
		case du.STEAM_STAT_OP.Min:
			if (num == 0 || b < num)
			{
				num2 = b;
				flag = true;
			}
			break;
		}
		if (flag)
		{
			SteamUserStats.SetStat(text, num2);
			int num3 = this.iaj;
			this.iaj = num3 + 1;
			this.iap = true;
			if (bq.knd)
			{
				Debug.Log(string.Format(a.cqc(), new object[] { text, c, num, num2 }));
			}
			du.StatUpdatedEventArgs e = new du.StatUpdatedEventArgs(a, num, num2, c);
			Action<du.StatUpdatedEventArgs> action = du.iac;
			if (action != null)
			{
				action(e);
			}
			Action<du.StatUpdatedEventArgs> action2;
			if (du.iag.TryGetValue(a, out action2) && action2 != null)
			{
				action2(e);
			}
			this.ceh(a, num2);
		}
	}

	// Token: 0x0600096B RID: 2411 RVA: 0x00038ACD File Offset: 0x00036CCD
	private void kaj()
	{
		while (this.iao.Count > 0)
		{
			this.iao.Dequeue()();
		}
	}

	// Token: 0x0600096D RID: 2413 RVA: 0x0003924C File Offset: 0x0003744C
	private void gga(du.STEAM_STAT_ID a, int b, du.STEAM_STAT_OP c)
	{
		if (SteamManager.ibh)
		{
			return;
		}
		string text = a.ToString();
		int num;
		if (!SteamUserStats.GetStat(text, out num))
		{
			if (bq.knd)
			{
				Debug.LogWarning(a.cqd() + text + a.cqe());
			}
			return;
		}
		int num2 = num;
		bool flag = false;
		switch (c)
		{
		case du.STEAM_STAT_OP.Add:
			num2 = num + b;
			flag = true;
			break;
		case du.STEAM_STAT_OP.Set:
			if (num != b)
			{
				num2 = b;
				flag = true;
			}
			break;
		case du.STEAM_STAT_OP.Max:
			if (b > num)
			{
				num2 = b;
				flag = true;
			}
			break;
		case du.STEAM_STAT_OP.Min:
			if (num == 0 || b < num)
			{
				num2 = b;
				flag = true;
			}
			break;
		}
		if (flag)
		{
			SteamUserStats.SetStat(text, num2);
			int num3 = this.iaj;
			this.iaj = num3 + 1;
			this.iap = true;
			if (bq.knd)
			{
				Debug.Log(string.Format(a.cqf(), new object[] { text, c, num, num2 }));
			}
			du.StatUpdatedEventArgs e = new du.StatUpdatedEventArgs(a, num, num2, c);
			Action<du.StatUpdatedEventArgs> action = du.iac;
			if (action != null)
			{
				action(e);
			}
			Action<du.StatUpdatedEventArgs> action2;
			if (du.iag.TryGetValue(a, out action2) && action2 != null)
			{
				action2(e);
			}
			this.ceh(a, num2);
		}
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x0003937C File Offset: 0x0003757C
	public void lfn()
	{
		if (SteamManager.krd && this.iai && this.iap)
		{
			this.ceb();
		}
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x00038D53 File Offset: 0x00036F53
	private void ced()
	{
		if (SteamManager.ibh)
		{
			return;
		}
		this.ias = this.iaj;
		this.iat.Enqueue(this.ias);
		this.iav = Time.realtimeSinceStartup;
		SteamUserStats.StoreStats();
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x000393A4 File Offset: 0x000375A4
	private void ceh(du.STEAM_STAT_ID a, int b)
	{
		foreach (du.AchievementCondition achievementCondition in du.iaz)
		{
			if (achievementCondition.requiredStat == a && b >= achievementCondition.requiredValue)
			{
				this.cei(achievementCondition.achievementId);
			}
		}
	}

	// Token: 0x06000972 RID: 2418 RVA: 0x00039410 File Offset: 0x00037610
	private void mau()
	{
		if (!SteamManager.krd)
		{
			return;
		}
		if (this.iam != null)
		{
			return;
		}
		this.cdp();
		if (this.ial.AppID().m_AppId == 0U)
		{
			this.ial = new CGameID(SteamUtils.GetAppID());
		}
		if (bq.knd)
		{
			Debug.Log(a.cqg());
		}
		this.cds();
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x00039470 File Offset: 0x00037670
	public bool ceg(du.STEAM_STAT_ID a, out int b)
	{
		string text = a.ToString();
		bool stat = SteamUserStats.GetStat(text, out b);
		if (!stat)
		{
			if (bq.knd)
			{
				Debug.LogWarning(a.cqa() + text + a.cqb());
			}
			b = 0;
		}
		return stat;
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x00038E2C File Offset: 0x0003702C
	private void cdx()
	{
		if (this.iay == null)
		{
			return;
		}
		base.StopCoroutine(this.iay);
		this.iay = null;
	}

	// Token: 0x06000975 RID: 2421 RVA: 0x000394B4 File Offset: 0x000376B4
	public void fca()
	{
		if (!SteamManager.krd)
		{
			Debug.LogError(a.cqh());
			return;
		}
		AppId_t appID = SteamUtils.GetAppID();
		if (bq.knd)
		{
			Debug.Log(string.Format(a.cqi(), appID));
		}
		if (appID.m_AppId == 0U)
		{
			Debug.LogError(a.cqj());
			return;
		}
		this.iai = false;
		SteamUserStats.RequestUserStats(SteamUser.GetSteamID());
	}

	// Token: 0x06000976 RID: 2422 RVA: 0x0003951A File Offset: 0x0003771A
	private IEnumerator cdr()
	{
		yield return new WaitForEndOfFrame();
		if (!this.iai || !this.iap)
		{
			yield break;
		}
		if (this.iat.Count > 0)
		{
			yield break;
		}
		if (bq.knd)
		{
			Debug.Log(a.cpj());
		}
		this.ced();
		yield break;
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x0003952C File Offset: 0x0003772C
	public bool dgc(du.ACHIEVEMENT a)
	{
		if (!SteamManager.krd || !this.iai)
		{
			return false;
		}
		string text = a.ToString();
		bool flag;
		if (!SteamUserStats.GetAchievement(text, out flag))
		{
			if (bq.knd)
			{
				Debug.LogWarning(a.cqk() + text + a.cql());
			}
			return false;
		}
		return flag;
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x00039581 File Offset: 0x00037781
	private void ndo()
	{
		if (this.iam == null)
		{
			this.iam = Callback<UserStatsReceived_t>.Create(new Callback<UserStatsReceived_t>.DispatchDelegate(this.cdu));
		}
		if (this.ian == null)
		{
			this.ian = Callback<UserStatsStored_t>.Create(new Callback<UserStatsStored_t>.DispatchDelegate(this.cdv));
		}
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x000395C4 File Offset: 0x000377C4
	private void cdq()
	{
		if (!SteamManager.krd)
		{
			return;
		}
		if (this.iam != null)
		{
			return;
		}
		this.cdp();
		if (this.ial.AppID().m_AppId == 0U)
		{
			this.ial = new CGameID(SteamUtils.GetAppID());
		}
		if (bq.knd)
		{
			Debug.Log(a.cqm());
		}
		this.cds();
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x00039624 File Offset: 0x00037824
	public Dictionary<du.ACHIEVEMENT, bool> hyw()
	{
		Dictionary<du.ACHIEVEMENT, bool> dictionary = new Dictionary<du.ACHIEVEMENT, bool>();
		foreach (object obj in Enum.GetValues(typeof(du.ACHIEVEMENT)))
		{
			du.ACHIEVEMENT achievement = (du.ACHIEVEMENT)obj;
			dictionary[achievement] = this.cej(achievement);
		}
		return dictionary;
	}

	// Token: 0x0600097B RID: 2427 RVA: 0x00039694 File Offset: 0x00037894
	private void gxv(du.STEAM_STAT_ID a, int b)
	{
		foreach (du.AchievementCondition achievementCondition in du.iaz)
		{
			if (achievementCondition.requiredStat == a && b >= achievementCondition.requiredValue)
			{
				this.cei(achievementCondition.achievementId);
			}
		}
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x0600097D RID: 2429 RVA: 0x000397DF File Offset: 0x000379DF
	// (set) Token: 0x0600099B RID: 2459 RVA: 0x00039DF6 File Offset: 0x00037FF6
	public static du iah { get; private set; }

	// Token: 0x0600097E RID: 2430 RVA: 0x00039581 File Offset: 0x00037781
	private void drq()
	{
		if (this.iam == null)
		{
			this.iam = Callback<UserStatsReceived_t>.Create(new Callback<UserStatsReceived_t>.DispatchDelegate(this.cdu));
		}
		if (this.ian == null)
		{
			this.ian = Callback<UserStatsStored_t>.Create(new Callback<UserStatsStored_t>.DispatchDelegate(this.cdv));
		}
	}

	// Token: 0x0600097F RID: 2431 RVA: 0x000397E8 File Offset: 0x000379E8
	public void cef(du.STEAM_STAT_ID a, out int b)
	{
		string text = a.ToString();
		if (!SteamUserStats.GetStat(text, out b))
		{
			if (bq.knd)
			{
				Debug.LogWarning(a.cqa() + text + a.cqb());
			}
			b = 0;
		}
	}

	// Token: 0x06000980 RID: 2432 RVA: 0x00038D53 File Offset: 0x00036F53
	private void bkg()
	{
		if (SteamManager.ibh)
		{
			return;
		}
		this.ias = this.iaj;
		this.iat.Enqueue(this.ias);
		this.iav = Time.realtimeSinceStartup;
		SteamUserStats.StoreStats();
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x0003982C File Offset: 0x00037A2C
	public bool mmz(du.ACHIEVEMENT a)
	{
		if (!SteamManager.krd || !this.iai)
		{
			return false;
		}
		string text = a.ToString();
		if (this.cej(a))
		{
			return false;
		}
		bool flag = SteamUserStats.SetAchievement(text);
		if (flag)
		{
			this.iap = true;
			if (bq.knd)
			{
				Debug.Log(a.cqn() + text);
			}
			Action<du.ACHIEVEMENT> action = du.iaf;
			if (action != null)
			{
				action(a);
			}
			this.ceb();
			return flag;
		}
		Debug.LogWarning(a.cqo() + text);
		return flag;
	}

	// Token: 0x06000982 RID: 2434 RVA: 0x00039581 File Offset: 0x00037781
	private void hhx()
	{
		if (this.iam == null)
		{
			this.iam = Callback<UserStatsReceived_t>.Create(new Callback<UserStatsReceived_t>.DispatchDelegate(this.cdu));
		}
		if (this.ian == null)
		{
			this.ian = Callback<UserStatsStored_t>.Create(new Callback<UserStatsStored_t>.DispatchDelegate(this.cdv));
		}
	}

	// Token: 0x06000983 RID: 2435 RVA: 0x0003937C File Offset: 0x0003757C
	public void lnn()
	{
		if (SteamManager.krd && this.iai && this.iap)
		{
			this.ceb();
		}
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x000398B4 File Offset: 0x00037AB4
	public void cec(du.STEAM_STAT_ID a, int b, du.STEAM_STAT_OP c)
	{
		du.dr dr = new du.dr();
		dr.hzs = this;
		dr.hzt = a;
		dr.hzu = b;
		dr.hzv = c;
		this.cdz(new Action(dr.ccq));
	}

	// Token: 0x1400000F RID: 15
	// (add) Token: 0x06000985 RID: 2437 RVA: 0x000398F8 File Offset: 0x00037AF8
	// (remove) Token: 0x06000993 RID: 2451 RVA: 0x00039C84 File Offset: 0x00037E84
	public static event Action iad;

	// Token: 0x06000986 RID: 2438 RVA: 0x00038D53 File Offset: 0x00036F53
	private void dur()
	{
		if (SteamManager.ibh)
		{
			return;
		}
		this.ias = this.iaj;
		this.iat.Enqueue(this.ias);
		this.iav = Time.realtimeSinceStartup;
		SteamUserStats.StoreStats();
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x0003992C File Offset: 0x00037B2C
	public static void hnu(du.STEAM_STAT_ID a, Action<du.StatUpdatedEventArgs> b)
	{
		Action<du.StatUpdatedEventArgs> action;
		if (du.iag.TryGetValue(a, out action))
		{
			du.iag[a] = (Action<du.StatUpdatedEventArgs>)Delegate.Combine(action, b);
			return;
		}
		du.iag[a] = b;
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x00038E2C File Offset: 0x0003702C
	private void kle()
	{
		if (this.iay == null)
		{
			return;
		}
		base.StopCoroutine(this.iay);
		this.iay = null;
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x0003996C File Offset: 0x00037B6C
	private void cdw()
	{
		if (this.iay != null)
		{
			return;
		}
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		this.iay = base.StartCoroutine(this.cdy());
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x00039994 File Offset: 0x00037B94
	private void gbn()
	{
		if (!SteamManager.krd)
		{
			return;
		}
		if (this.iam != null)
		{
			return;
		}
		this.cdp();
		if (this.ial.AppID().m_AppId == 0U)
		{
			this.ial = new CGameID(SteamUtils.GetAppID());
		}
		if (bq.knd)
		{
			Debug.Log(a.cqp());
		}
		this.cds();
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x000399F1 File Offset: 0x00037BF1
	private IEnumerator cdy()
	{
		while (!this.iai)
		{
			yield return new WaitForSecondsRealtime(30f);
			if (this.iai)
			{
				break;
			}
			if (SteamManager.ibh)
			{
				this.iay = null;
				yield break;
			}
			if (SteamManager.krd && SteamUser.BLoggedOn())
			{
				if (bq.knd)
				{
					Debug.Log(a.cpi());
				}
				this.cds();
			}
		}
		this.iay = null;
		yield break;
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x00039A00 File Offset: 0x00037C00
	private void bdd()
	{
		SteamManager.ibn -= this.cdq;
		this.cdx();
		base.StopAllCoroutines();
		Callback<UserStatsReceived_t> callback = this.iam;
		if (callback != null)
		{
			callback.Unregister();
		}
		this.iam = null;
		Callback<UserStatsStored_t> callback2 = this.ian;
		if (callback2 != null)
		{
			callback2.Unregister();
		}
		this.ian = null;
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x00039A5C File Offset: 0x00037C5C
	public Dictionary<du.ACHIEVEMENT, bool> gwu()
	{
		Dictionary<du.ACHIEVEMENT, bool> dictionary = new Dictionary<du.ACHIEVEMENT, bool>();
		foreach (object obj in Enum.GetValues(typeof(du.ACHIEVEMENT)))
		{
			du.ACHIEVEMENT achievement = (du.ACHIEVEMENT)obj;
			dictionary[achievement] = this.cej(achievement);
		}
		return dictionary;
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x00039AEC File Offset: 0x00037CEC
	private void ivp()
	{
		SteamManager.ibn -= this.cdq;
		this.cdx();
		base.StopAllCoroutines();
		Callback<UserStatsReceived_t> callback = this.iam;
		if (callback != null)
		{
			callback.Unregister();
		}
		this.iam = null;
		Callback<UserStatsStored_t> callback2 = this.ian;
		if (callback2 != null)
		{
			callback2.Unregister();
		}
		this.ian = null;
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x00039B48 File Offset: 0x00037D48
	public bool cej(du.ACHIEVEMENT a)
	{
		if (!SteamManager.krd || !this.iai)
		{
			return false;
		}
		string text = a.ToString();
		bool flag;
		if (!SteamUserStats.GetAchievement(text, out flag))
		{
			if (bq.knd)
			{
				Debug.LogWarning(a.cqq() + text + a.cqr());
			}
			return false;
		}
		return flag;
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x00039BA0 File Offset: 0x00037DA0
	private void ef()
	{
		SteamManager.ibn -= this.cdq;
		this.cdx();
		base.StopAllCoroutines();
		Callback<UserStatsReceived_t> callback = this.iam;
		if (callback != null)
		{
			callback.Unregister();
		}
		this.iam = null;
		Callback<UserStatsStored_t> callback2 = this.ian;
		if (callback2 != null)
		{
			callback2.Unregister();
		}
		this.ian = null;
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x00039BFC File Offset: 0x00037DFC
	public bool cei(du.ACHIEVEMENT a)
	{
		if (!SteamManager.krd || !this.iai)
		{
			return false;
		}
		string text = a.ToString();
		if (this.cej(a))
		{
			return false;
		}
		bool flag = SteamUserStats.SetAchievement(text);
		if (flag)
		{
			this.iap = true;
			if (bq.knd)
			{
				Debug.Log(a.cqs() + text);
			}
			Action<du.ACHIEVEMENT> action = du.iaf;
			if (action != null)
			{
				action(a);
			}
			this.ceb();
			return flag;
		}
		Debug.LogWarning(a.cqt() + text);
		return flag;
	}

	// Token: 0x1400000E RID: 14
	// (add) Token: 0x060009A2 RID: 2466 RVA: 0x0003A050 File Offset: 0x00038250
	// (remove) Token: 0x06000994 RID: 2452 RVA: 0x00039CB8 File Offset: 0x00037EB8
	public static event Action<du.StatUpdatedEventArgs> iac;

	// Token: 0x06000995 RID: 2453 RVA: 0x00039581 File Offset: 0x00037781
	private void cdp()
	{
		if (this.iam == null)
		{
			this.iam = Callback<UserStatsReceived_t>.Create(new Callback<UserStatsReceived_t>.DispatchDelegate(this.cdu));
		}
		if (this.ian == null)
		{
			this.ian = Callback<UserStatsStored_t>.Create(new Callback<UserStatsStored_t>.DispatchDelegate(this.cdv));
		}
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x00038ACD File Offset: 0x00036CCD
	private void nik()
	{
		while (this.iao.Count > 0)
		{
			this.iao.Dequeue()();
		}
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x00039CEC File Offset: 0x00037EEC
	public Dictionary<du.ACHIEVEMENT, bool> cel()
	{
		Dictionary<du.ACHIEVEMENT, bool> dictionary = new Dictionary<du.ACHIEVEMENT, bool>();
		foreach (object obj in Enum.GetValues(typeof(du.ACHIEVEMENT)))
		{
			du.ACHIEVEMENT achievement = (du.ACHIEVEMENT)obj;
			dictionary[achievement] = this.cej(achievement);
		}
		return dictionary;
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x0003937C File Offset: 0x0003757C
	public void cdt()
	{
		if (SteamManager.krd && this.iai && this.iap)
		{
			this.ceb();
		}
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x00039D90 File Offset: 0x00037F90
	public void cds()
	{
		if (!SteamManager.krd)
		{
			Debug.LogError(a.cqu());
			return;
		}
		AppId_t appID = SteamUtils.GetAppID();
		if (bq.knd)
		{
			Debug.Log(string.Format(a.cqv(), appID));
		}
		if (appID.m_AppId == 0U)
		{
			Debug.LogError(a.cqw());
			return;
		}
		this.iai = false;
		SteamUserStats.RequestUserStats(SteamUser.GetSteamID());
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x00039E00 File Offset: 0x00038000
	private void Update()
	{
		if (SteamManager.ibh)
		{
			return;
		}
		if (this.iai && this.iap)
		{
			this.iaq += Time.deltaTime;
			if (this.iaq >= 5f)
			{
				if (this.iat.Count > 0)
				{
					if (Time.realtimeSinceStartup - this.iav < 60f)
					{
						return;
					}
					Debug.LogWarning(string.Format(a.cqx(), 60f));
					this.iaw += this.iat.Count;
					this.iat.Clear();
				}
				this.iaq = 0f;
				base.StartCoroutine(this.cdr());
			}
		}
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x00038ACD File Offset: 0x00036CCD
	private void cea()
	{
		while (this.iao.Count > 0)
		{
			this.iao.Dequeue()();
		}
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x00039EC0 File Offset: 0x000380C0
	private void bhh(du.STEAM_STAT_ID a, int b, du.STEAM_STAT_OP c)
	{
		if (SteamManager.ibh)
		{
			return;
		}
		string text = a.ToString();
		int num;
		if (!SteamUserStats.GetStat(text, out num))
		{
			if (bq.knd)
			{
				Debug.LogWarning(a.cqy() + text + a.cqz());
			}
			return;
		}
		int num2 = num;
		bool flag = false;
		switch (c)
		{
		case du.STEAM_STAT_OP.Add:
			num2 = num + b;
			flag = true;
			break;
		case du.STEAM_STAT_OP.Set:
			if (num != b)
			{
				num2 = b;
				flag = true;
			}
			break;
		case du.STEAM_STAT_OP.Max:
			if (b > num)
			{
				num2 = b;
				flag = true;
			}
			break;
		case du.STEAM_STAT_OP.Min:
			if (num == 0 || b < num)
			{
				num2 = b;
				flag = true;
			}
			break;
		}
		if (flag)
		{
			SteamUserStats.SetStat(text, num2);
			int num3 = this.iaj;
			this.iaj = num3 + 1;
			this.iap = true;
			if (bq.knd)
			{
				Debug.Log(string.Format(a.cra(), new object[] { text, c, num, num2 }));
			}
			du.StatUpdatedEventArgs e = new du.StatUpdatedEventArgs(a, num, num2, c);
			Action<du.StatUpdatedEventArgs> action = du.iac;
			if (action != null)
			{
				action(e);
			}
			Action<du.StatUpdatedEventArgs> action2;
			if (du.iag.TryGetValue(a, out action2) && action2 != null)
			{
				action2(e);
			}
			this.ceh(a, num2);
		}
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x00039FF0 File Offset: 0x000381F0
	public void izb(du.STEAM_STAT_ID a, out int b)
	{
		string text = a.ToString();
		if (!SteamUserStats.GetStat(text, out b))
		{
			if (bq.knd)
			{
				Debug.LogWarning(a.crb() + text + a.crc());
			}
			b = 0;
		}
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x0003A033 File Offset: 0x00038233
	public void kxr()
	{
		if (this.iai)
		{
			this.ced();
			this.iaq = -2684f;
		}
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x0003937C File Offset: 0x0003757C
	public void nqb()
	{
		if (SteamManager.krd && this.iai && this.iap)
		{
			this.ceb();
		}
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x0003A084 File Offset: 0x00038284
	private void vc(du.STEAM_STAT_ID a, int b)
	{
		foreach (du.AchievementCondition achievementCondition in du.iaz)
		{
			if (achievementCondition.requiredStat == a && b >= achievementCondition.requiredValue)
			{
				this.cei(achievementCondition.achievementId);
			}
		}
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x0003A124 File Offset: 0x00038324
	private void cdu(UserStatsReceived_t a)
	{
		if (a.m_nGameID != (ulong)this.ial.AppID().m_AppId)
		{
			return;
		}
		if (a.m_eResult != EResult.k_EResultOK)
		{
			Debug.LogError(string.Format(a.cre(), a.m_eResult, 30f));
			this.cdw();
			return;
		}
		if (bq.knd)
		{
			Debug.Log(a.crd());
		}
		this.iai = true;
		this.cdx();
		this.cea();
		Action action = du.iae;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x00039581 File Offset: 0x00037781
	private void kwj()
	{
		if (this.iam == null)
		{
			this.iam = Callback<UserStatsReceived_t>.Create(new Callback<UserStatsReceived_t>.DispatchDelegate(this.cdu));
		}
		if (this.ian == null)
		{
			this.ian = Callback<UserStatsStored_t>.Create(new Callback<UserStatsStored_t>.DispatchDelegate(this.cdv));
		}
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x0003A1B4 File Offset: 0x000383B4
	public bool qj(du.ACHIEVEMENT a, out uint b)
	{
		b = 0U;
		bool flag;
		return SteamManager.krd && this.iai && (SteamUserStats.GetAchievementAndUnlockTime(a.ToString(), out flag, out b) && flag);
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x0003A1EC File Offset: 0x000383EC
	public Dictionary<du.ACHIEVEMENT, bool> ccx()
	{
		Dictionary<du.ACHIEVEMENT, bool> dictionary = new Dictionary<du.ACHIEVEMENT, bool>();
		foreach (object obj in Enum.GetValues(typeof(du.ACHIEVEMENT)))
		{
			du.ACHIEVEMENT achievement = (du.ACHIEVEMENT)obj;
			dictionary[achievement] = this.cej(achievement);
		}
		return dictionary;
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x0003A25C File Offset: 0x0003845C
	public static void cen(du.STEAM_STAT_ID a, Action<du.StatUpdatedEventArgs> b)
	{
		Action<du.StatUpdatedEventArgs> action;
		if (du.iag.TryGetValue(a, out action))
		{
			Action<du.StatUpdatedEventArgs> action2 = (Action<du.StatUpdatedEventArgs>)Delegate.Remove(action, b);
			if (action2 == null)
			{
				du.iag.Remove(a);
				return;
			}
			du.iag[a] = action2;
		}
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x0003A2A4 File Offset: 0x000384A4
	private void cdv(UserStatsStored_t a)
	{
		if (a.m_nGameID != (ulong)this.ial.AppID().m_AppId)
		{
			return;
		}
		if (this.iaw > 0)
		{
			this.iaw--;
			if (bq.knd)
			{
				Debug.Log(a.crf());
			}
			return;
		}
		int num = ((this.iat.Count > 0) ? this.iat.Dequeue() : this.ias);
		if (a.m_eResult != EResult.k_EResultOK)
		{
			if (a.m_eResult == EResult.k_EResultInvalidParam)
			{
				if (bq.knd)
				{
					Debug.LogWarning(a.crh());
				}
				this.cds();
			}
			return;
		}
		if (bq.knd)
		{
			Debug.Log(a.crg());
		}
		this.iak = Math.Max(this.iak, num);
		if (this.iak >= this.iaj)
		{
			this.iap = false;
			this.iaq = 0f;
		}
		Action action = du.iad;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x0003996C File Offset: 0x00037B6C
	private void cqa()
	{
		if (this.iay != null)
		{
			return;
		}
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		this.iay = base.StartCoroutine(this.cdy());
	}

	// Token: 0x040007BA RID: 1978
	private static Dictionary<du.STEAM_STAT_ID, Action<du.StatUpdatedEventArgs>> iag = new Dictionary<du.STEAM_STAT_ID, Action<du.StatUpdatedEventArgs>>();

	// Token: 0x040007BF RID: 1983
	private CGameID ial;

	// Token: 0x040007C0 RID: 1984
	protected Callback<UserStatsReceived_t> iam;

	// Token: 0x040007C1 RID: 1985
	protected Callback<UserStatsStored_t> ian;

	// Token: 0x040007C2 RID: 1986
	private Queue<Action> iao = new Queue<Action>();

	// Token: 0x040007C3 RID: 1987
	private bool iap;

	// Token: 0x040007C4 RID: 1988
	private float iaq;

	// Token: 0x040007C5 RID: 1989
	private const float iar = 5f;

	// Token: 0x040007C6 RID: 1990
	private int ias;

	// Token: 0x040007C7 RID: 1991
	private readonly Queue<int> iat = new Queue<int>();

	// Token: 0x040007C8 RID: 1992
	private const float iau = 60f;

	// Token: 0x040007C9 RID: 1993
	private float iav;

	// Token: 0x040007CA RID: 1994
	private int iaw;

	// Token: 0x040007CB RID: 1995
	private const float iax = 30f;

	// Token: 0x040007CC RID: 1996
	private Coroutine iay;

	// Token: 0x040007CD RID: 1997
	private static readonly List<du.AchievementCondition> iaz = new List<du.AchievementCondition>
	{
		new du.AchievementCondition(du.ACHIEVEMENT.ACHIEVEMENT_1, du.STEAM_STAT_ID.STAT_CLICK, 100),
		new du.AchievementCondition(du.ACHIEVEMENT.ACHIEVEMENT_2, du.STEAM_STAT_ID.STAT_CLICK, 1000),
		new du.AchievementCondition(du.ACHIEVEMENT.ACHIEVEMENT_3, du.STEAM_STAT_ID.STAT_CLICK, 10000),
		new du.AchievementCondition(du.ACHIEVEMENT.ACHIEVEMENT_4, du.STEAM_STAT_ID.STAT_CLICK, 100000),
		new du.AchievementCondition(du.ACHIEVEMENT.ACHIEVEMENT_5, du.STEAM_STAT_ID.STAT_CLICK, 1000000),
		new du.AchievementCondition(du.ACHIEVEMENT.ACHIEVEMENT_6, du.STEAM_STAT_ID.STAT_CLICK, 10000000),
		new du.AchievementCondition(du.ACHIEVEMENT.ACH_ORGASM_T1, du.STEAM_STAT_ID.STAT_ORGASM, 5),
		new du.AchievementCondition(du.ACHIEVEMENT.ACH_ORGASM_T2, du.STEAM_STAT_ID.STAT_ORGASM, 50),
		new du.AchievementCondition(du.ACHIEVEMENT.ACH_ORGASM_T3, du.STEAM_STAT_ID.STAT_ORGASM, 200),
		new du.AchievementCondition(du.ACHIEVEMENT.ACH_ORGASM_T4, du.STEAM_STAT_ID.STAT_ORGASM, 500),
		new du.AchievementCondition(du.ACHIEVEMENT.ACH_ORGASM_T5, du.STEAM_STAT_ID.STAT_ORGASM, 1000)
	};

	// Token: 0x020000B1 RID: 177
	public enum STEAM_STAT_ID
	{
		// Token: 0x040007CF RID: 1999
		STAT_CLICK,
		// Token: 0x040007D0 RID: 2000
		STAT_PLAYTIME_SINCE_DROP,
		// Token: 0x040007D1 RID: 2001
		STAT_ORGASM,
		// Token: 0x040007D2 RID: 2002
		STAT_CRAFT_TOTAL_COUNT
	}

	// Token: 0x020000B2 RID: 178
	public enum STEAM_STAT_OP
	{
		// Token: 0x040007D4 RID: 2004
		Add,
		// Token: 0x040007D5 RID: 2005
		Set,
		// Token: 0x040007D6 RID: 2006
		Max,
		// Token: 0x040007D7 RID: 2007
		Min
	}

	// Token: 0x020000B3 RID: 179
	public enum ACHIEVEMENT
	{
		// Token: 0x040007D9 RID: 2009
		ACHIEVEMENT_1,
		// Token: 0x040007DA RID: 2010
		ACHIEVEMENT_2,
		// Token: 0x040007DB RID: 2011
		ACHIEVEMENT_3,
		// Token: 0x040007DC RID: 2012
		ACHIEVEMENT_4,
		// Token: 0x040007DD RID: 2013
		ACHIEVEMENT_5,
		// Token: 0x040007DE RID: 2014
		ACHIEVEMENT_6,
		// Token: 0x040007DF RID: 2015
		ACH_ORGASM_T1,
		// Token: 0x040007E0 RID: 2016
		ACH_ORGASM_T2,
		// Token: 0x040007E1 RID: 2017
		ACH_ORGASM_T3,
		// Token: 0x040007E2 RID: 2018
		ACH_ORGASM_T4,
		// Token: 0x040007E3 RID: 2019
		ACH_ORGASM_T5
	}

	// Token: 0x020000B4 RID: 180
	[Serializable]
	public class AchievementCondition
	{
		// Token: 0x060009AC RID: 2476 RVA: 0x0003A392 File Offset: 0x00038592
		public AchievementCondition(du.ACHIEVEMENT id, du.STEAM_STAT_ID stat, int value)
		{
			this.achievementId = id;
			this.requiredStat = stat;
			this.requiredValue = value;
		}

		// Token: 0x040007E4 RID: 2020
		public du.ACHIEVEMENT achievementId;

		// Token: 0x040007E5 RID: 2021
		public du.STEAM_STAT_ID requiredStat;

		// Token: 0x040007E6 RID: 2022
		public int requiredValue;
	}

	// Token: 0x020000B5 RID: 181
	[Serializable]
	public class StatUpdatedEventArgs
	{
		// Token: 0x060009AD RID: 2477 RVA: 0x0003A3AF File Offset: 0x000385AF
		public StatUpdatedEventArgs(du.STEAM_STAT_ID id, int oldVal, int newVal, du.STEAM_STAT_OP op)
		{
			this.statId = id;
			this.oldValue = oldVal;
			this.newValue = newVal;
			this.operationType = op;
		}

		// Token: 0x040007E7 RID: 2023
		public du.STEAM_STAT_ID statId;

		// Token: 0x040007E8 RID: 2024
		public int oldValue;

		// Token: 0x040007E9 RID: 2025
		public int newValue;

		// Token: 0x040007EA RID: 2026
		public du.STEAM_STAT_OP operationType;
	}

	// Token: 0x020000B6 RID: 182
	[CompilerGenerated]
	private sealed class dr
	{
		// Token: 0x060009AE RID: 2478 RVA: 0x0003A3D4 File Offset: 0x000385D4
		internal void ccq()
		{
			this.hzs.cee(this.hzt, this.hzu, this.hzv);
		}

		// Token: 0x040007EB RID: 2027
		public du hzs;

		// Token: 0x040007EC RID: 2028
		public du.STEAM_STAT_ID hzt;

		// Token: 0x040007ED RID: 2029
		public int hzu;

		// Token: 0x040007EE RID: 2030
		public du.STEAM_STAT_OP hzv;
	}
}
