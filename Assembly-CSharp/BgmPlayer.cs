using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using FMOD;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

// Token: 0x02000014 RID: 20
public sealed class BgmPlayer : MonoBehaviour
{
	// Token: 0x17000020 RID: 32
	// (get) Token: 0x060000CC RID: 204 RVA: 0x00005648 File Offset: 0x00003848
	public static BgmPlayer kmc
	{
		get
		{
			return BgmPlayer.hft;
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x060000CD RID: 205 RVA: 0x0000564F File Offset: 0x0000384F
	// (set) Token: 0x060000CE RID: 206 RVA: 0x00005657 File Offset: 0x00003857
	public BgmAlbumConfig hfu { get; private set; }

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x060000CF RID: 207 RVA: 0x00005660 File Offset: 0x00003860
	// (set) Token: 0x060000D0 RID: 208 RVA: 0x00005668 File Offset: 0x00003868
	public int hfv { get; private set; } = -1;

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x060000D1 RID: 209 RVA: 0x00005671 File Offset: 0x00003871
	// (set) Token: 0x060000D2 RID: 210 RVA: 0x00005679 File Offset: 0x00003879
	public BgmPlayMode hfw { get; private set; }

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x060000D3 RID: 211 RVA: 0x00005682 File Offset: 0x00003882
	public bool kmd
	{
		get
		{
			return this.hfy.isValid();
		}
	}

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x060000D4 RID: 212 RVA: 0x00005690 File Offset: 0x00003890
	// (remove) Token: 0x060000D5 RID: 213 RVA: 0x000056C8 File Offset: 0x000038C8
	public event Action hfx;

	// Token: 0x060000D6 RID: 214 RVA: 0x00005700 File Offset: 0x00003900
	public static BgmPlayer si()
	{
		if (BgmPlayer.hft != null)
		{
			return BgmPlayer.hft;
		}
		GameObject gameObject = new GameObject(a.cs());
		global::UnityEngine.Object.DontDestroyOnLoad(gameObject);
		BgmPlayer.hft = gameObject.AddComponent<BgmPlayer>();
		BgmPlayer.hft.hfu = Resources.Load<BgmAlbumConfig>(a.ct());
		return BgmPlayer.hft;
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00005754 File Offset: 0x00003954
	public void sj()
	{
		if (this.hfu == null || this.hfu.kow == 0)
		{
			global::UnityEngine.Debug.LogError(a.cu());
			AudioManager audioManager = AudioManager.klw;
			if (audioManager == null)
			{
				return;
			}
			j bgm_Main = audioManager.BGM_Main;
			if (bgm_Main == null)
			{
				return;
			}
			bgm_Main.rt(0f);
			return;
		}
		else
		{
			this.hfw = (BgmPlayMode)Mathf.Clamp(PlayerPrefs.GetInt(a.cv(), 0), 0, 2);
			this.hgc = PlayerPrefs.GetInt(a.cw(), this.hfu.defaultIndex);
			int num = this.hgc;
			bool flag = true;
			if (this.hfu.bil(num) == null || l.sx(this.hfu, this.hfu.bil(num)))
			{
				num = l.sy(this.hfu);
				flag = false;
			}
			if (num < 0)
			{
				global::UnityEngine.Debug.LogWarning(a.cx());
				return;
			}
			this.sl(num, flag);
			this.so();
			return;
		}
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00005834 File Offset: 0x00003A34
	public void sk(int a)
	{
		if (!this.sl(a, true))
		{
			return;
		}
		this.st();
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00005848 File Offset: 0x00003A48
	public bool sl(int a, bool b)
	{
		if (!l.kmf)
		{
			if (b && this.hfu != null && this.hfu.bil(a) != null)
			{
				this.hgc = a;
				PlayerPrefs.SetInt(a.cw(), a);
				PlayerPrefs.Save();
			}
			global::UnityEngine.Debug.LogWarning(a.cy());
			return false;
		}
		BgmTrack bgmTrack = ((this.hfu != null) ? this.hfu.bil(a) : null);
		if (bgmTrack == null)
		{
			global::UnityEngine.Debug.LogWarning(string.Format(a.cz(), a));
			return false;
		}
		if (l.sx(this.hfu, bgmTrack))
		{
			global::UnityEngine.Debug.LogWarning(a.da() + bgmTrack.id + a.db());
			return false;
		}
		if (bgmTrack.track.Guid.IsNull)
		{
			global::UnityEngine.Debug.LogError(a.da() + bgmTrack.id + a.dc());
			return false;
		}
		this.su();
		try
		{
			this.hfy = RuntimeManager.CreateInstance(bgmTrack.track.Guid);
			if (!this.hfy.isValid())
			{
				global::UnityEngine.Debug.LogError(a.da() + bgmTrack.id + a.dd());
				this.su();
				return false;
			}
			EventDescription eventDescription;
			RESULT result = this.hfy.getDescription(out eventDescription);
			if (result != RESULT.OK)
			{
				global::UnityEngine.Debug.LogError(string.Format(a.de(), bgmTrack.id, result));
				this.su();
				return false;
			}
			int num;
			result = eventDescription.getLength(out num);
			if (result != RESULT.OK)
			{
				global::UnityEngine.Debug.LogError(string.Format(a.df(), bgmTrack.id, result));
				this.su();
				return false;
			}
			this.hfz = Mathf.Max(1f, (float)num / 1000f);
			result = this.hfy.start();
			if (result != RESULT.OK)
			{
				global::UnityEngine.Debug.LogError(string.Format(a.dg(), bgmTrack.id, result));
				this.su();
				return false;
			}
		}
		catch (Exception ex)
		{
			global::UnityEngine.Debug.LogError(string.Format(a.dh(), bgmTrack.id, ex));
			this.su();
			return false;
		}
		this.hga = 0f;
		this.hgf = 0f;
		this.hfv = a;
		if (b)
		{
			this.hgc = a;
			PlayerPrefs.SetInt(a.cw(), a);
			PlayerPrefs.Save();
		}
		Action action = this.hfx;
		if (action != null)
		{
			action();
		}
		return true;
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00005ACC File Offset: 0x00003CCC
	public void sm()
	{
		this.st();
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00005AD4 File Offset: 0x00003CD4
	public void sn()
	{
		if (this.hfu == null || this.hgb.Count == 0)
		{
			return;
		}
		int count = this.hgb.Count;
		for (int i = 0; i < count; i++)
		{
			int num = this.hgb.Dequeue();
			if (!l.sx(this.hfu, this.hfu.bil(num)))
			{
				this.hgb.Enqueue(num);
			}
		}
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00005B46 File Offset: 0x00003D46
	private void so()
	{
		if (this.hgd)
		{
			return;
		}
		this.hgd = true;
		SteamManager.ibn += this.sp;
		if (SteamManager.krd)
		{
			this.sp();
		}
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00005B78 File Offset: 0x00003D78
	private void sp()
	{
		if (this.hfu == null)
		{
			return;
		}
		this.st();
		BgmTrack bgmTrack = this.hfu.bil(this.hgc);
		if (bgmTrack == null)
		{
			return;
		}
		if (l.sx(this.hfu, bgmTrack))
		{
			return;
		}
		if (this.hgc == this.hfv)
		{
			return;
		}
		if (this.sl(this.hgc, false))
		{
			this.st();
		}
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00005BE3 File Offset: 0x00003DE3
	private void OnDestroy()
	{
		if (!this.hgd)
		{
			return;
		}
		this.hgd = false;
		SteamManager.ibn -= this.sp;
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00005C06 File Offset: 0x00003E06
	public void sq(BgmPlayMode a)
	{
		if (this.hfw == a)
		{
			return;
		}
		this.hfw = a;
		PlayerPrefs.SetInt(a.cv(), (int)a);
		PlayerPrefs.Save();
		if (a == BgmPlayMode.Shuffle)
		{
			this.st();
		}
		Action action = this.hfx;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x00005C44 File Offset: 0x00003E44
	public void sr()
	{
		if (!l.kmf)
		{
			return;
		}
		bool flag = l.kme;
		switch (this.hfw)
		{
		case BgmPlayMode.Single:
			this.sl(this.hfv, flag);
			return;
		case BgmPlayMode.Sequential:
			this.sl(this.ss(this.hfv), flag);
			return;
		case BgmPlayMode.Shuffle:
			if (this.hgb.Count == 0)
			{
				this.st();
			}
			if (this.hgb.Count > 0)
			{
				this.sl(this.hgb.Dequeue(), flag);
			}
			return;
		default:
			return;
		}
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00005CD4 File Offset: 0x00003ED4
	private void Update()
	{
		if (!this.hfy.isValid())
		{
			return;
		}
		this.hgf += Time.unscaledDeltaTime;
		if (this.hgf >= 0.5f)
		{
			this.hgf = 0f;
			PLAYBACK_STATE playback_STATE;
			this.hfy.getPlaybackState(out playback_STATE);
			if (playback_STATE == PLAYBACK_STATE.STOPPED)
			{
				this.sr();
				return;
			}
		}
		if (this.hfw == BgmPlayMode.Single)
		{
			return;
		}
		this.hga += Time.unscaledDeltaTime;
		if (this.hga >= this.hfz)
		{
			this.sr();
		}
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x00005D64 File Offset: 0x00003F64
	private int ss(int a)
	{
		int num = this.hfu.kow;
		for (int i = 1; i <= num; i++)
		{
			int num2 = (a + i) % num;
			if (!l.sx(this.hfu, this.hfu.bil(num2)))
			{
				return num2;
			}
		}
		return a;
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00005DAC File Offset: 0x00003FAC
	private void st()
	{
		this.hgb.Clear();
		if (this.hfu == null)
		{
			return;
		}
		List<int> list = new List<int>();
		for (int i = 0; i < this.hfu.kow; i++)
		{
			if (i != this.hfv && !l.sx(this.hfu, this.hfu.bil(i)))
			{
				list.Add(i);
			}
		}
		for (int j = list.Count - 1; j > 0; j--)
		{
			int num = global::UnityEngine.Random.Range(0, j + 1);
			List<int> list2 = list;
			int num2 = j;
			List<int> list3 = list;
			int num3 = num;
			int num4 = list[num];
			int num5 = list[j];
			list2[num2] = num4;
			list3[num3] = num5;
		}
		foreach (int num6 in list)
		{
			this.hgb.Enqueue(num6);
		}
		if (list.Count == 0 && this.hfv >= 0)
		{
			this.hgb.Enqueue(this.hfv);
		}
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00005EDC File Offset: 0x000040DC
	private void su()
	{
		if (!this.hfy.isValid())
		{
			return;
		}
		this.hfy.stop(global::FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
		this.hfy.release();
		this.hfy.clearHandle();
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00005F10 File Offset: 0x00004110
	private void OnApplicationQuit()
	{
		this.su();
	}

	// Token: 0x040000BB RID: 187
	public const string PrefKeyTrackIndex = "Settings_BgmTrackIndex";

	// Token: 0x040000BC RID: 188
	public const string PrefKeyPlayMode = "Settings_BgmPlayMode";

	// Token: 0x040000BD RID: 189
	private static BgmPlayer hft;

	// Token: 0x040000C2 RID: 194
	private EventInstance hfy;

	// Token: 0x040000C3 RID: 195
	private float hfz;

	// Token: 0x040000C4 RID: 196
	private float hga;

	// Token: 0x040000C5 RID: 197
	private readonly Queue<int> hgb = new Queue<int>();

	// Token: 0x040000C6 RID: 198
	private int hgc = -1;

	// Token: 0x040000C7 RID: 199
	private bool hgd;

	// Token: 0x040000C8 RID: 200
	private const float hge = 0.5f;

	// Token: 0x040000C9 RID: 201
	private float hgf;
}
