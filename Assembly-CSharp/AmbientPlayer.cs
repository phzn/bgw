using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using FMOD;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

// Token: 0x02000007 RID: 7
public sealed class AmbientPlayer : MonoBehaviour
{
	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600001D RID: 29 RVA: 0x0000286A File Offset: 0x00000A6A
	public static AmbientPlayer kll
	{
		get
		{
			return AmbientPlayer.hbe;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600001E RID: 30 RVA: 0x00002871 File Offset: 0x00000A71
	// (set) Token: 0x0600001F RID: 31 RVA: 0x00002879 File Offset: 0x00000A79
	public AmbientConfig hbf { get; private set; }

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000020 RID: 32 RVA: 0x00002882 File Offset: 0x00000A82
	// (set) Token: 0x06000021 RID: 33 RVA: 0x0000288A File Offset: 0x00000A8A
	public bool hbg { get; private set; }

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000022 RID: 34 RVA: 0x00002893 File Offset: 0x00000A93
	// (set) Token: 0x06000023 RID: 35 RVA: 0x0000289B File Offset: 0x00000A9B
	public AmbientTheme hbh { get; private set; }

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000024 RID: 36 RVA: 0x000028A4 File Offset: 0x00000AA4
	// (set) Token: 0x06000025 RID: 37 RVA: 0x000028AC File Offset: 0x00000AAC
	public bool hbi { get; private set; }

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000026 RID: 38 RVA: 0x000028B5 File Offset: 0x00000AB5
	// (set) Token: 0x06000027 RID: 39 RVA: 0x000028BD File Offset: 0x00000ABD
	public bool hbj { get; private set; }

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000028 RID: 40 RVA: 0x000028C6 File Offset: 0x00000AC6
	// (set) Token: 0x06000029 RID: 41 RVA: 0x000028CE File Offset: 0x00000ACE
	public AmbientWeather hbk { get; private set; }

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600002A RID: 42 RVA: 0x000028D7 File Offset: 0x00000AD7
	// (set) Token: 0x0600002B RID: 43 RVA: 0x000028DF File Offset: 0x00000ADF
	public bool hbl { get; private set; } = true;

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600002C RID: 44 RVA: 0x000028E8 File Offset: 0x00000AE8
	// (set) Token: 0x0600002D RID: 45 RVA: 0x000028F0 File Offset: 0x00000AF0
	public bool hbm { get; private set; } = true;

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x0600002E RID: 46 RVA: 0x000028F9 File Offset: 0x00000AF9
	// (set) Token: 0x0600002F RID: 47 RVA: 0x00002901 File Offset: 0x00000B01
	public AmbientWeather hbn { get; private set; }

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000030 RID: 48 RVA: 0x0000290A File Offset: 0x00000B0A
	// (set) Token: 0x06000031 RID: 49 RVA: 0x00002912 File Offset: 0x00000B12
	public AmbientCityTime hbo { get; private set; }

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000032 RID: 50 RVA: 0x0000291B File Offset: 0x00000B1B
	// (set) Token: 0x06000033 RID: 51 RVA: 0x00002923 File Offset: 0x00000B23
	public AmbientBusyMode hbp { get; private set; } = AmbientBusyMode.Auto;

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000034 RID: 52 RVA: 0x0000292C File Offset: 0x00000B2C
	// (set) Token: 0x06000035 RID: 53 RVA: 0x00002934 File Offset: 0x00000B34
	public bool hbq { get; private set; } = true;

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000036 RID: 54 RVA: 0x0000293D File Offset: 0x00000B3D
	// (set) Token: 0x06000037 RID: 55 RVA: 0x00002945 File Offset: 0x00000B45
	public bool hbr { get; private set; } = true;

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000038 RID: 56 RVA: 0x0000294E File Offset: 0x00000B4E
	public AmbientWeather klm
	{
		get
		{
			if (this.hbh != AmbientTheme.City)
			{
				return this.hbk;
			}
			return this.hbn;
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000039 RID: 57 RVA: 0x00002966 File Offset: 0x00000B66
	private bool kln
	{
		get
		{
			if (this.hbh != AmbientTheme.City)
			{
				return this.hbt.isValid();
			}
			return this.hbw.isValid();
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x0600003A RID: 58 RVA: 0x00002988 File Offset: 0x00000B88
	public bool klo
	{
		get
		{
			return this.kln;
		}
	}

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x0600003B RID: 59 RVA: 0x00002990 File Offset: 0x00000B90
	// (remove) Token: 0x0600003C RID: 60 RVA: 0x000029C8 File Offset: 0x00000BC8
	public event Action hbs;

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x0600003D RID: 61 RVA: 0x00002A00 File Offset: 0x00000C00
	public string klp
	{
		get
		{
			if (this.klm == AmbientWeather.Auto)
			{
				return this.hby.ToString();
			}
			return a.t() + this.klm.ToString();
		}
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002A48 File Offset: 0x00000C48
	public static AmbientPlayer nq()
	{
		if (AmbientPlayer.hbe != null)
		{
			return AmbientPlayer.hbe;
		}
		GameObject gameObject = new GameObject(a.u());
		global::UnityEngine.Object.DontDestroyOnLoad(gameObject);
		AmbientPlayer.hbe = gameObject.AddComponent<AmbientPlayer>();
		AmbientPlayer.hbe.hbf = Resources.Load<AmbientConfig>(a.v());
		return AmbientPlayer.hbe;
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002A9C File Offset: 0x00000C9C
	public void nr()
	{
		this.hbg = PlayerPrefs.GetInt(a.w(), 0) != 0;
		this.hbh = (AmbientTheme)Mathf.Clamp(PlayerPrefs.GetInt(a.x(), 0), 0, 1);
		AmbientPlayer.ns();
		this.hbi = PlayerPrefs.GetInt(a.y(), 0) != 0;
		this.hbj = PlayerPrefs.GetInt(a.z(), 0) != 0;
		this.hbk = (AmbientWeather)Mathf.Clamp(PlayerPrefs.GetInt(a.ba(), 0), 0, 4);
		this.hbl = PlayerPrefs.GetInt(a.bb(), 1) != 0;
		this.hbm = PlayerPrefs.GetInt(a.bc(), 1) != 0;
		this.hbn = (AmbientWeather)Mathf.Clamp(PlayerPrefs.GetInt(a.bd(), 0), 0, 4);
		this.hbo = (AmbientCityTime)Mathf.Clamp(PlayerPrefs.GetInt(a.be(), 0), 0, 4);
		this.hbp = (AmbientBusyMode)Mathf.Clamp(PlayerPrefs.GetInt(a.bf(), 2), 0, 2);
		this.hbq = PlayerPrefs.GetInt(a.bg(), 1) != 0;
		this.hbr = PlayerPrefs.GetInt(a.bh(), 1) != 0;
		AudioManager audioManager = AudioManager.klw;
		if (audioManager != null)
		{
			audioManager.qn(PlayerPrefs.GetFloat(a.bi(), 0.5f), true);
		}
		if (this.hbf == null || this.hbf.kov == 0)
		{
			global::UnityEngine.Debug.LogError(a.bj());
			return;
		}
		this.ou();
		this.ph();
		this.ol();
		this.hcp = this.hco;
		this.hcr = this.hcq;
		this.hda = this.hcz;
		this.hdc = this.hdb;
		this.hde = this.hdd;
		this.of(true);
		Action action = this.hbs;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00002C60 File Offset: 0x00000E60
	private static void ns()
	{
		if (PlayerPrefs.HasKey(a.y()) || PlayerPrefs.HasKey(a.z()))
		{
			return;
		}
		if (!PlayerPrefs.HasKey(a.bk()))
		{
			return;
		}
		int num = Mathf.Clamp(PlayerPrefs.GetInt(a.bk(), 0), 0, 2);
		PlayerPrefs.SetInt(a.y(), (num == 1) ? 1 : 0);
		PlayerPrefs.SetInt(a.z(), (num == 2) ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002CD0 File Offset: 0x00000ED0
	public void nt(bool a)
	{
		if (this.hbg == a)
		{
			return;
		}
		this.hbg = a;
		PlayerPrefs.SetInt(a.w(), a ? 1 : 0);
		PlayerPrefs.Save();
		if (a)
		{
			this.of(false);
		}
		else
		{
			this.ok();
		}
		Action action = this.hbs;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002D28 File Offset: 0x00000F28
	public void nu(AmbientTheme a)
	{
		if (this.hbh == a)
		{
			return;
		}
		this.hbh = a;
		PlayerPrefs.SetInt(a.x(), (int)a);
		PlayerPrefs.Save();
		if (this.klm == AmbientWeather.Auto)
		{
			this.ou();
		}
		if (this.hbf != null)
		{
			this.ol();
			this.hcl = this.hck;
			this.hcn = this.hcm;
			this.hde = this.hdd;
		}
		this.of(false);
		Action action = this.hbs;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002DB3 File Offset: 0x00000FB3
	public void nv(bool a)
	{
		if (this.hbi == a)
		{
			return;
		}
		this.hbi = a;
		PlayerPrefs.SetInt(a.y(), a ? 1 : 0);
		PlayerPrefs.Save();
		this.of(false);
		Action action = this.hbs;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002DF3 File Offset: 0x00000FF3
	public void nw(bool a)
	{
		if (this.hbj == a)
		{
			return;
		}
		this.hbj = a;
		PlayerPrefs.SetInt(a.z(), a ? 1 : 0);
		PlayerPrefs.Save();
		this.of(false);
		Action action = this.hbs;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002E34 File Offset: 0x00001034
	public void nx(AmbientWeather a)
	{
		if (this.hbk == a)
		{
			return;
		}
		this.hbk = a;
		PlayerPrefs.SetInt(a.ba(), (int)a);
		PlayerPrefs.Save();
		if (this.hbh == AmbientTheme.Forest && a == AmbientWeather.Auto)
		{
			this.ou();
		}
		Action action = this.hbs;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002E83 File Offset: 0x00001083
	public void ny(bool a)
	{
		if (this.hbl == a)
		{
			return;
		}
		this.hbl = a;
		PlayerPrefs.SetInt(a.bb(), a ? 1 : 0);
		PlayerPrefs.Save();
		Action action = this.hbs;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002EBC File Offset: 0x000010BC
	public void nz(bool a)
	{
		if (this.hbm == a)
		{
			return;
		}
		this.hbm = a;
		PlayerPrefs.SetInt(a.bc(), a ? 1 : 0);
		PlayerPrefs.Save();
		Action action = this.hbs;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002EF8 File Offset: 0x000010F8
	public void oa(AmbientWeather a)
	{
		if (this.hbn == a)
		{
			return;
		}
		this.hbn = a;
		PlayerPrefs.SetInt(a.bd(), (int)a);
		PlayerPrefs.Save();
		if (this.hbh == AmbientTheme.City && a == AmbientWeather.Auto)
		{
			this.ou();
		}
		Action action = this.hbs;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002F48 File Offset: 0x00001148
	public void ob(AmbientCityTime a)
	{
		if (this.hbo == a)
		{
			return;
		}
		this.hbo = a;
		PlayerPrefs.SetInt(a.be(), (int)a);
		PlayerPrefs.Save();
		Action action = this.hbs;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002F7B File Offset: 0x0000117B
	public void oc(AmbientBusyMode a)
	{
		if (this.hbp == a)
		{
			return;
		}
		this.hbp = a;
		PlayerPrefs.SetInt(a.bf(), (int)a);
		PlayerPrefs.Save();
		Action action = this.hbs;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002FAE File Offset: 0x000011AE
	public void od(bool a)
	{
		if (this.hbq == a)
		{
			return;
		}
		this.hbq = a;
		PlayerPrefs.SetInt(a.bg(), a ? 1 : 0);
		PlayerPrefs.Save();
		Action action = this.hbs;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002FE7 File Offset: 0x000011E7
	public void oe(bool a)
	{
		if (this.hbr == a)
		{
			return;
		}
		this.hbr = a;
		PlayerPrefs.SetInt(a.bh(), a ? 1 : 0);
		PlayerPrefs.Save();
		Action action = this.hbs;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00003020 File Offset: 0x00001220
	private void of(bool a = false)
	{
		if (!this.hbg)
		{
			return;
		}
		if (!l.kmf)
		{
			global::UnityEngine.Debug.LogWarning(a.bl());
			return;
		}
		if (a)
		{
			this.hbx = 0f;
		}
		if (this.hbh == AmbientTheme.City)
		{
			this.oj(ref this.hbt);
			this.oj(ref this.hbu);
			this.oj(ref this.hbv);
			if (!this.hbw.isValid())
			{
				this.og(ref this.hbw, AmbientScene.City);
			}
			if (!this.hbw.isValid())
			{
				this.hbx = -1f;
			}
			return;
		}
		this.oj(ref this.hbw);
		if (!this.hbt.isValid())
		{
			this.og(ref this.hbt, AmbientScene.Forest);
		}
		if (!this.hbt.isValid())
		{
			this.hbx = -1f;
		}
		if (this.hbi)
		{
			if (!this.hbu.isValid())
			{
				this.og(ref this.hbu, AmbientScene.Stream);
			}
		}
		else
		{
			this.oj(ref this.hbu);
		}
		if (this.hbj)
		{
			if (!this.hbv.isValid())
			{
				if (!this.hcb)
				{
					this.hcb = true;
					this.hcc = DateTime.UtcNow;
					this.hcd = null;
				}
				this.og(ref this.hbv, AmbientScene.Campfire);
			}
		}
		else
		{
			this.oj(ref this.hbv);
		}
		this.oh();
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00003180 File Offset: 0x00001380
	private void og(ref EventInstance a, AmbientScene b)
	{
		AmbientSceneEntry ambientSceneEntry = ((this.hbf != null) ? this.hbf.bij(b) : null);
		if (ambientSceneEntry == null)
		{
			global::UnityEngine.Debug.LogError(string.Format(a.bm(), b));
			return;
		}
		if (ambientSceneEntry.eventRef.Guid.IsNull)
		{
			global::UnityEngine.Debug.LogError(string.Format(a.bn(), b));
			return;
		}
		if (!this.oi())
		{
			return;
		}
		try
		{
			a = RuntimeManager.CreateInstance(ambientSceneEntry.eventRef.Guid);
			if (!a.isValid())
			{
				global::UnityEngine.Debug.LogError(string.Format(a.bo(), b));
				this.oj(ref a);
			}
			else
			{
				this.ol();
				this.oq(true);
				if (this.hbx >= 0f)
				{
					a.setVolume(Mathf.Clamp01(this.hbx / 5f));
				}
				RESULT result = a.start();
				if (result != RESULT.OK)
				{
					global::UnityEngine.Debug.LogError(string.Format(a.bp(), b, result));
					this.oj(ref a);
				}
			}
		}
		catch (EventNotFoundException ex)
		{
			global::UnityEngine.Debug.LogError(string.Format(a.bq(), b, ex));
			this.oj(ref a);
		}
	}

	// Token: 0x0600004F RID: 79 RVA: 0x000032C8 File Offset: 0x000014C8
	private void oh()
	{
		if (!this.hbu.isValid())
		{
			return;
		}
		float num = ((this.hbx >= 0f) ? Mathf.Clamp01(this.hbx / 5f) : 1f);
		this.hbu.setVolume(num * (this.hbj ? 0.251f : 1f));
	}

	// Token: 0x06000050 RID: 80 RVA: 0x0000332C File Offset: 0x0000152C
	private bool oi()
	{
		bool flag;
		try
		{
			if (!RuntimeManager.HasBankLoaded(a.br()))
			{
				RuntimeManager.LoadBank(a.br(), false);
			}
			flag = true;
		}
		catch (BankLoadException ex)
		{
			global::UnityEngine.Debug.LogError(string.Format(a.bs(), a.br(), ex));
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00003380 File Offset: 0x00001580
	private void oj(ref EventInstance a)
	{
		if (!a.isValid())
		{
			return;
		}
		a.stop(global::FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
		a.release();
		a.clearHandle();
	}

	// Token: 0x06000052 RID: 82 RVA: 0x000033A0 File Offset: 0x000015A0
	private void ok()
	{
		this.hbx = -1f;
		this.oj(ref this.hbt);
		this.oj(ref this.hbu);
		this.oj(ref this.hbv);
		this.oj(ref this.hbw);
	}

	// Token: 0x06000053 RID: 83 RVA: 0x000033DD File Offset: 0x000015DD
	private void OnApplicationQuit()
	{
		this.ok();
	}

	// Token: 0x06000054 RID: 84 RVA: 0x000033E8 File Offset: 0x000015E8
	private void Update()
	{
		if (this.hbf == null)
		{
			return;
		}
		float num = Mathf.Min(Time.unscaledDeltaTime, 0.1f);
		if (this.hbx >= 0f && this.kln)
		{
			this.hbx += num;
			float num2 = Mathf.Clamp01(this.hbx / 5f);
			if (this.hbt.isValid())
			{
				this.hbt.setVolume(num2);
			}
			if (this.hbw.isValid())
			{
				this.hbw.setVolume(num2);
			}
			if (this.hbv.isValid())
			{
				this.hbv.setVolume(num2);
			}
			if (this.hbu.isValid())
			{
				this.hbu.setVolume(num2 * (this.hbj ? 0.251f : 1f));
			}
			if (num2 >= 1f)
			{
				this.hbx = -1f;
			}
		}
		this.ov();
		this.pg(num);
		this.pf(num);
		this.pe();
		this.ol();
		this.oo(num);
		this.oq(false);
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00003510 File Offset: 0x00001710
	private void ol()
	{
		AmbientWeather ambientWeather = this.klm;
		if (ambientWeather == AmbientWeather.Auto)
		{
			this.hck = AmbientPlayer.pc(this.hby);
			this.hcm = ((this.hby == AmbientPlayer.WeatherStage.StormWarn) ? 1f : 0f);
			float num = 0f;
			if (Mathf.Approximately(this.hck, 3f))
			{
				num = this.hbf.heavyRainWindFloor;
			}
			if (this.hby == AmbientPlayer.WeatherStage.StormWarn)
			{
				num = Mathf.Max(num, this.hbf.stormWarnWindFloor);
			}
			this.hcx = Mathf.Clamp01(Mathf.Max(this.hcj, num));
			this.hco = ((this.hbl && (this.hck < 2f || !AmbientPlayer.pa(this.hby))) ? 1f : 0f);
		}
		else
		{
			this.hck = AmbientPlayer.pd(ambientWeather);
			this.hcm = 0f;
			float num2 = (Mathf.Approximately(this.hck, 3f) ? this.hbf.heavyRainWindFloor : 0f);
			this.hcx = Mathf.Clamp01(Mathf.Max(this.hcj, num2));
			bool flag = ambientWeather == AmbientWeather.RainNormal || ambientWeather == AmbientWeather.RainHeavy;
			this.hco = ((this.hbl && !flag) ? 1f : 0f);
		}
		this.hcq = (this.hbm ? 1f : 0f);
		this.hcv = (this.hce ? 1f : 0f);
		this.hcs = this.om();
		this.hcz = (this.hbq ? 1f : 0f);
		this.hdb = (this.hbr ? 1f : 0f);
		this.hdd = ((this.hbp == AmbientBusyMode.Off) ? 0f : ((this.hbp == AmbientBusyMode.Always) ? 1f : (this.on(this.hcs) ? 1f : 0f)));
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00003714 File Offset: 0x00001914
	private float om()
	{
		if (this.hbh != AmbientTheme.City)
		{
			return AmbientPlayer.pi();
		}
		switch (this.hbo)
		{
		case AmbientCityTime.Dawn:
			return this.hbf.cityDawnHour;
		case AmbientCityTime.Morning:
			return this.hbf.cityMorningHour;
		case AmbientCityTime.Afternoon:
			return this.hbf.cityAfternoonHour;
		case AmbientCityTime.Night:
			return this.hbf.cityNightHour;
		default:
			return AmbientPlayer.pi();
		}
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00003788 File Offset: 0x00001988
	private bool on(float a)
	{
		return (a >= this.hbf.cityBusyPeakA.x && a <= this.hbf.cityBusyPeakA.y) || (a >= this.hbf.cityBusyPeakB.x && a <= this.hbf.cityBusyPeakB.y);
	}

	// Token: 0x06000058 RID: 88 RVA: 0x000037E8 File Offset: 0x000019E8
	private void oo(float a)
	{
		this.hcl = AmbientPlayer.op(this.hcl, this.hck, a, this.hbf.weatherRampSeconds, 3f);
		this.hcn = AmbientPlayer.op(this.hcn, this.hcm, a, this.hbf.stormRampSeconds, 1f);
		this.hcp = AmbientPlayer.op(this.hcp, this.hco, a, this.hbf.birdsRampSeconds, 1f);
		this.hcr = AmbientPlayer.op(this.hcr, this.hcq, a, this.hbf.birdsRampSeconds, 1f);
		this.hcy = AmbientPlayer.op(this.hcy, this.hcx, a, this.hbf.windRampSeconds, 1f);
		this.hcw = AmbientPlayer.op(this.hcw, this.hcv, a, this.hbf.streamDriftSeconds, 1f);
		this.hcu = AmbientPlayer.op(this.hcu, this.hct, a, this.hbf.campfireReigniteSeconds, 7f);
		this.hda = AmbientPlayer.op(this.hda, this.hcz, a, this.hbf.birdsRampSeconds, 1f);
		this.hdc = AmbientPlayer.op(this.hdc, this.hdb, a, this.hbf.birdsRampSeconds, 1f);
		this.hde = AmbientPlayer.op(this.hde, this.hdd, a, this.hbf.cityBusyRampSeconds, 1f);
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00003985 File Offset: 0x00001B85
	private static float op(float a, float b, float c, float d, float e)
	{
		if (Mathf.Approximately(a, b))
		{
			return b;
		}
		return Mathf.MoveTowards(a, b, c * (e / Mathf.Max(0.01f, d)));
	}

	// Token: 0x0600005A RID: 90 RVA: 0x000039AC File Offset: 0x00001BAC
	private void oq(bool a)
	{
		this.ot(a.bt(), this.hcl, ref this.hdf, a);
		this.ot(a.bu(), this.hcn, ref this.hdg, a);
		this.ot(a.bv(), this.hcp, ref this.hdh, a);
		this.ot(a.bw(), this.hcr, ref this.hdi, a);
		this.ot(a.bx(), this.hcs, ref this.hdj, a);
		this.ot(a.by(), this.hcu, ref this.hdk, a);
		this.ot(a.bz(), this.hcw, ref this.hdl, a);
		this.ot(a.ca(), this.hcy, ref this.hdm, a);
		this.or(a);
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00003A80 File Offset: 0x00001C80
	private void or(bool a)
	{
		if (!this.hbw.isValid())
		{
			return;
		}
		this.os(a.cb(), this.hda, ref this.hdn, a);
		this.os(a.cc(), this.hdc, ref this.hdo, a);
		this.os(a.cd(), this.hde, ref this.hdp, a);
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00003AE3 File Offset: 0x00001CE3
	private void os(string a, float b, ref float c, bool d)
	{
		if (!d && Mathf.Approximately(c, b))
		{
			return;
		}
		c = b;
		this.hbw.setParameterByName(a, b, false);
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00003B08 File Offset: 0x00001D08
	private void ot(string a, float b, ref float c, bool d)
	{
		if (!d && Mathf.Approximately(c, b))
		{
			return;
		}
		c = b;
		if (this.hbt.isValid())
		{
			this.hbt.setParameterByName(a, b, false);
		}
		if (this.hbu.isValid())
		{
			this.hbu.setParameterByName(a, b, false);
		}
		if (this.hbv.isValid())
		{
			this.hbv.setParameterByName(a, b, false);
		}
		if (this.hbw.isValid())
		{
			this.hbw.setParameterByName(a, b, false);
		}
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00003B97 File Offset: 0x00001D97
	private void ou()
	{
		if (this.hbf == null)
		{
			return;
		}
		this.hby = AmbientPlayer.WeatherStage.Clear;
		this.hbz = this.oy();
		this.ox(AmbientPlayer.WeatherStage.Clear, false);
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00003BC3 File Offset: 0x00001DC3
	private void ov()
	{
		if (this.klm != AmbientWeather.Auto)
		{
			return;
		}
		if (DateTime.UtcNow < this.hca)
		{
			return;
		}
		this.ow();
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00003BE8 File Offset: 0x00001DE8
	private void ow()
	{
		switch (this.hby)
		{
		case AmbientPlayer.WeatherStage.Clear:
			this.ox(AmbientPlayer.WeatherStage.StormWarn, false);
			return;
		case AmbientPlayer.WeatherStage.StormWarn:
			this.ox(AmbientPlayer.WeatherStage.RainWeakUp, false);
			return;
		case AmbientPlayer.WeatherStage.RainWeakUp:
			this.ox((this.hbz >= 2) ? AmbientPlayer.WeatherStage.RainNormalUp : AmbientPlayer.WeatherStage.Clear, this.hbz < 2);
			return;
		case AmbientPlayer.WeatherStage.RainNormalUp:
			this.ox((this.hbz >= 3) ? AmbientPlayer.WeatherStage.RainHeavy : AmbientPlayer.WeatherStage.RainWeakDown, false);
			return;
		case AmbientPlayer.WeatherStage.RainHeavy:
			this.ox(AmbientPlayer.WeatherStage.RainNormalDown, false);
			return;
		case AmbientPlayer.WeatherStage.RainNormalDown:
			this.ox(AmbientPlayer.WeatherStage.RainWeakDown, false);
			return;
		case AmbientPlayer.WeatherStage.RainWeakDown:
			this.ox(AmbientPlayer.WeatherStage.Clear, true);
			return;
		default:
			return;
		}
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00003C80 File Offset: 0x00001E80
	private void ox(AmbientPlayer.WeatherStage a, bool b = false)
	{
		if (b)
		{
			this.hbz = this.oy();
		}
		this.hby = a;
		this.hca = DateTime.UtcNow.AddSeconds((double)this.oz(a));
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00003CC0 File Offset: 0x00001EC0
	private int oy()
	{
		float num = Mathf.Max(0f, this.hbf.peakWeightWeak);
		float num2 = Mathf.Max(0f, this.hbf.peakWeightNormal);
		float num3 = Mathf.Max(0f, this.hbf.peakWeightHeavy);
		float num4 = num + num2 + num3;
		if (num4 <= 0f)
		{
			return 2;
		}
		float num5 = global::UnityEngine.Random.value * num4;
		if (num5 < num)
		{
			return 1;
		}
		if (num5 < num + num2)
		{
			return 2;
		}
		return 3;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00003D3C File Offset: 0x00001F3C
	private float oz(AmbientPlayer.WeatherStage a)
	{
		if (a == AmbientPlayer.WeatherStage.Clear)
		{
			return global::UnityEngine.Random.Range(this.hbf.clearMinutes.x, this.hbf.clearMinutes.y) * 60f;
		}
		if (a == AmbientPlayer.WeatherStage.StormWarn)
		{
			return this.hbf.stormWarnSeconds;
		}
		if (this.pb(a) && global::UnityEngine.Random.value < this.hbf.quickRiseChance)
		{
			return global::UnityEngine.Random.Range(this.hbf.quickStageSeconds.x, this.hbf.quickStageSeconds.y);
		}
		return global::UnityEngine.Random.Range(this.hbf.rainStageMinutes.x, this.hbf.rainStageMinutes.y) * 60f;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00003DF6 File Offset: 0x00001FF6
	private static bool pa(AmbientPlayer.WeatherStage a)
	{
		return a == AmbientPlayer.WeatherStage.RainWeakUp || a == AmbientPlayer.WeatherStage.RainNormalUp || a == AmbientPlayer.WeatherStage.RainHeavy;
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00003E06 File Offset: 0x00002006
	private bool pb(AmbientPlayer.WeatherStage a)
	{
		if (a == AmbientPlayer.WeatherStage.RainWeakUp)
		{
			return this.hbz > 1;
		}
		return a == AmbientPlayer.WeatherStage.RainNormalUp && this.hbz > 2;
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00003E25 File Offset: 0x00002025
	private static float pc(AmbientPlayer.WeatherStage a)
	{
		switch (a)
		{
		case AmbientPlayer.WeatherStage.RainWeakUp:
		case AmbientPlayer.WeatherStage.RainWeakDown:
			return 1f;
		case AmbientPlayer.WeatherStage.RainNormalUp:
		case AmbientPlayer.WeatherStage.RainNormalDown:
			return 2f;
		case AmbientPlayer.WeatherStage.RainHeavy:
			return 3f;
		default:
			return 0f;
		}
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00003E5C File Offset: 0x0000205C
	private static float pd(AmbientWeather a)
	{
		switch (a)
		{
		case AmbientWeather.RainWeak:
			return 1f;
		case AmbientWeather.RainNormal:
			return 2f;
		case AmbientWeather.RainHeavy:
			return 3f;
		default:
			return 0f;
		}
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00003E8C File Offset: 0x0000208C
	private void pe()
	{
		if (!this.hcb)
		{
			this.hct = 0f;
			return;
		}
		double totalHours = (DateTime.UtcNow - this.hcc).TotalHours;
		this.hct = Mathf.Clamp((float)totalHours, 0f, 7f);
		if (this.hct < 7f)
		{
			this.hcd = null;
			return;
		}
		if (this.hcd == null)
		{
			this.hcd = new DateTime?(DateTime.UtcNow);
			return;
		}
		if ((DateTime.UtcNow - this.hcd.Value).TotalMinutes < (double)this.hbf.campfireEndHoldMinutes)
		{
			return;
		}
		this.hcc = DateTime.UtcNow;
		this.hcd = null;
		this.hct = 0f;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00003F64 File Offset: 0x00002164
	private void pf(float a)
	{
		this.hcf += a;
		if (this.hcf < this.hcg)
		{
			return;
		}
		this.hcf = 0f;
		this.hcg = global::UnityEngine.Random.Range(this.hbf.streamDriftMinutes.x, this.hbf.streamDriftMinutes.y) * 60f;
		this.hce = !this.hce;
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00003FDC File Offset: 0x000021DC
	private void pg(float a)
	{
		this.hch += a;
		if (this.hch < this.hci)
		{
			return;
		}
		this.hch = 0f;
		this.hci = global::UnityEngine.Random.Range(this.hbf.windGustSeconds.x, this.hbf.windGustSeconds.y);
		this.hcj = global::UnityEngine.Random.value;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00004048 File Offset: 0x00002248
	private void ph()
	{
		if (this.hbf == null)
		{
			return;
		}
		this.hce = true;
		this.hcf = 0f;
		this.hcg = global::UnityEngine.Random.Range(this.hbf.streamDriftMinutes.x, this.hbf.streamDriftMinutes.y) * 60f;
		this.hch = 0f;
		this.hci = global::UnityEngine.Random.Range(this.hbf.windGustSeconds.x, this.hbf.windGustSeconds.y);
		this.hcj = global::UnityEngine.Random.value;
	}

	// Token: 0x0600006C RID: 108 RVA: 0x000040E8 File Offset: 0x000022E8
	private static float pi()
	{
		DateTime now = DateTime.Now;
		return (float)now.Hour + (float)now.Minute / 60f + (float)now.Second / 3600f;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00004121 File Offset: 0x00002321
	public void pj()
	{
		if (this.klm != AmbientWeather.Auto)
		{
			global::UnityEngine.Debug.LogWarning(a.ce());
			return;
		}
		this.ow();
	}

	// Token: 0x0600006E RID: 110 RVA: 0x0000413C File Offset: 0x0000233C
	public void pk()
	{
		this.hcb = true;
		this.hcc = DateTime.UtcNow;
		this.hcd = null;
	}

	// Token: 0x0600006F RID: 111 RVA: 0x0000415C File Offset: 0x0000235C
	public void pl()
	{
		this.hce = !this.hce;
		this.hcf = 0f;
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00004178 File Offset: 0x00002378
	public string pm()
	{
		return string.Concat(new string[]
		{
			string.Format(a.cf(), new object[] { this.hcl, this.hck, this.hcn, this.hcm }),
			string.Format(a.cg(), new object[] { this.hcp, this.hco, this.hcr, this.hcq }),
			string.Format(a.ch(), this.hcs),
			string.Format(a.ci(), new object[] { this.hcu, this.hct, this.hcw, this.hcv }),
			string.Format(a.cj(), new object[] { this.hcy, this.hcx, this.hbz, this.hcj }),
			string.Format(a.ck(), new object[] { this.hda, this.hcz, this.hdc, this.hdb }),
			string.Format(a.cl(), this.hde, this.hdd, this.hbw.isValid())
		});
	}

	// Token: 0x0400000E RID: 14
	public const string PrefKeyEnabled = "Settings_AmbientEnabled";

	// Token: 0x0400000F RID: 15
	public const string PrefKeyTheme = "Settings_AmbientTheme";

	// Token: 0x04000010 RID: 16
	public const string PrefKeyScene = "Settings_AmbientScene";

	// Token: 0x04000011 RID: 17
	public const string PrefKeyStream = "Settings_AmbientStream";

	// Token: 0x04000012 RID: 18
	public const string PrefKeyCampfire = "Settings_AmbientCampfire";

	// Token: 0x04000013 RID: 19
	public const string PrefKeyWeather = "Settings_AmbientWeather";

	// Token: 0x04000014 RID: 20
	public const string PrefKeyBirds = "Settings_AmbientBirds";

	// Token: 0x04000015 RID: 21
	public const string PrefKeyInsects = "Settings_AmbientInsects";

	// Token: 0x04000016 RID: 22
	public const string PrefKeyVolume = "Settings_AmbientVolume";

	// Token: 0x04000017 RID: 23
	public const string PrefKeyCityWeather = "Settings_AmbientCityWeather";

	// Token: 0x04000018 RID: 24
	public const string PrefKeyCityTime = "Settings_AmbientCityTime";

	// Token: 0x04000019 RID: 25
	public const string PrefKeyCityBusy = "Settings_AmbientCityBusy";

	// Token: 0x0400001A RID: 26
	public const string PrefKeyCityPark = "Settings_AmbientCityPark";

	// Token: 0x0400001B RID: 27
	public const string PrefKeyCityCars = "Settings_AmbientCityCars";

	// Token: 0x0400001C RID: 28
	private const string haq = "Rain";

	// Token: 0x0400001D RID: 29
	private const string har = "Storm";

	// Token: 0x0400001E RID: 30
	private const string has = "Birds";

	// Token: 0x0400001F RID: 31
	private const string hat = "Insects";

	// Token: 0x04000020 RID: 32
	private const string hau = "Hour";

	// Token: 0x04000021 RID: 33
	private const string hav = "FireAge";

	// Token: 0x04000022 RID: 34
	private const string haw = "StreamNear";

	// Token: 0x04000023 RID: 35
	private const string hax = "Wind";

	// Token: 0x04000024 RID: 36
	private const string hay = "Park";

	// Token: 0x04000025 RID: 37
	private const string haz = "Cars";

	// Token: 0x04000026 RID: 38
	private const string hba = "Busy";

	// Token: 0x04000027 RID: 39
	private const float hbb = 3f;

	// Token: 0x04000028 RID: 40
	private const float hbc = 1f;

	// Token: 0x04000029 RID: 41
	private const float hbd = 7f;

	// Token: 0x0400002A RID: 42
	public const float StartupFadeSeconds = 5f;

	// Token: 0x0400002B RID: 43
	public const float StreamDuckVolume = 0.251f;

	// Token: 0x0400002C RID: 44
	private static AmbientPlayer hbe;

	// Token: 0x0400003B RID: 59
	private EventInstance hbt;

	// Token: 0x0400003C RID: 60
	private EventInstance hbu;

	// Token: 0x0400003D RID: 61
	private EventInstance hbv;

	// Token: 0x0400003E RID: 62
	private EventInstance hbw;

	// Token: 0x0400003F RID: 63
	private float hbx = -1f;

	// Token: 0x04000040 RID: 64
	private AmbientPlayer.WeatherStage hby;

	// Token: 0x04000041 RID: 65
	private int hbz = 1;

	// Token: 0x04000042 RID: 66
	private DateTime hca;

	// Token: 0x04000043 RID: 67
	private bool hcb;

	// Token: 0x04000044 RID: 68
	private DateTime hcc;

	// Token: 0x04000045 RID: 69
	private DateTime? hcd;

	// Token: 0x04000046 RID: 70
	private bool hce = true;

	// Token: 0x04000047 RID: 71
	private float hcf;

	// Token: 0x04000048 RID: 72
	private float hcg;

	// Token: 0x04000049 RID: 73
	private float hch;

	// Token: 0x0400004A RID: 74
	private float hci;

	// Token: 0x0400004B RID: 75
	private float hcj;

	// Token: 0x0400004C RID: 76
	private float hck;

	// Token: 0x0400004D RID: 77
	private float hcl;

	// Token: 0x0400004E RID: 78
	private float hcm;

	// Token: 0x0400004F RID: 79
	private float hcn;

	// Token: 0x04000050 RID: 80
	private float hco = 1f;

	// Token: 0x04000051 RID: 81
	private float hcp = 1f;

	// Token: 0x04000052 RID: 82
	private float hcq = 1f;

	// Token: 0x04000053 RID: 83
	private float hcr = 1f;

	// Token: 0x04000054 RID: 84
	private float hcs;

	// Token: 0x04000055 RID: 85
	private float hct;

	// Token: 0x04000056 RID: 86
	private float hcu;

	// Token: 0x04000057 RID: 87
	private float hcv = 1f;

	// Token: 0x04000058 RID: 88
	private float hcw = 1f;

	// Token: 0x04000059 RID: 89
	private float hcx;

	// Token: 0x0400005A RID: 90
	private float hcy;

	// Token: 0x0400005B RID: 91
	private float hcz = 1f;

	// Token: 0x0400005C RID: 92
	private float hda = 1f;

	// Token: 0x0400005D RID: 93
	private float hdb = 1f;

	// Token: 0x0400005E RID: 94
	private float hdc = 1f;

	// Token: 0x0400005F RID: 95
	private float hdd;

	// Token: 0x04000060 RID: 96
	private float hde;

	// Token: 0x04000061 RID: 97
	private float hdf;

	// Token: 0x04000062 RID: 98
	private float hdg;

	// Token: 0x04000063 RID: 99
	private float hdh;

	// Token: 0x04000064 RID: 100
	private float hdi;

	// Token: 0x04000065 RID: 101
	private float hdj;

	// Token: 0x04000066 RID: 102
	private float hdk;

	// Token: 0x04000067 RID: 103
	private float hdl;

	// Token: 0x04000068 RID: 104
	private float hdm;

	// Token: 0x04000069 RID: 105
	private float hdn;

	// Token: 0x0400006A RID: 106
	private float hdo;

	// Token: 0x0400006B RID: 107
	private float hdp;

	// Token: 0x02000008 RID: 8
	private enum WeatherStage
	{
		// Token: 0x0400006D RID: 109
		Clear,
		// Token: 0x0400006E RID: 110
		StormWarn,
		// Token: 0x0400006F RID: 111
		RainWeakUp,
		// Token: 0x04000070 RID: 112
		RainNormalUp,
		// Token: 0x04000071 RID: 113
		RainHeavy,
		// Token: 0x04000072 RID: 114
		RainNormalDown,
		// Token: 0x04000073 RID: 115
		RainWeakDown
	}
}
