using System;
using System.Collections;
using System.Text;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using AOT;
using FishySteamworks;
using Steamworks;
using UnityEngine;

// Token: 0x020000B9 RID: 185
[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x060009BC RID: 2492 RVA: 0x0003A540 File Offset: 0x00038740
	protected static SteamManager krc
	{
		get
		{
			if (SteamManager.ibe == null)
			{
				return new GameObject(a.crj()).AddComponent<SteamManager>();
			}
			return SteamManager.ibe;
		}
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x060009BD RID: 2493 RVA: 0x0003A564 File Offset: 0x00038764
	public static bool krd
	{
		get
		{
			return SteamManager.krc.ibg;
		}
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x060009BE RID: 2494 RVA: 0x0003A570 File Offset: 0x00038770
	public static bool kre
	{
		get
		{
			return SteamManager.krc.ibf;
		}
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x0003A57C File Offset: 0x0003877C
	public static void cev()
	{
		if (SteamManager.ibe == null)
		{
			return;
		}
		SteamManager.ibe.ibg = false;
		SteamManager.ibe.ibf = false;
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x060009C0 RID: 2496 RVA: 0x0003A5A2 File Offset: 0x000387A2
	public static bool krf
	{
		get
		{
			return SteamManager.ibe != null && SteamManager.ibe.ibg;
		}
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x060009C1 RID: 2497 RVA: 0x0003A5BD File Offset: 0x000387BD
	// (set) Token: 0x060009C2 RID: 2498 RVA: 0x0003A5C4 File Offset: 0x000387C4
	public static bool ibh { get; private set; }

	// Token: 0x060009C3 RID: 2499 RVA: 0x0003A5CC File Offset: 0x000387CC
	private void cez()
	{
		if (this.ibi == null)
		{
			this.ibi = Callback<SteamShutdown_t>.Create(new Callback<SteamShutdown_t>.DispatchDelegate(this.cfa));
		}
		if (this.ibj == null)
		{
			this.ibj = Callback<IPCFailure_t>.Create(new Callback<IPCFailure_t>.DispatchDelegate(this.cfb));
		}
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x0003A60C File Offset: 0x0003880C
	private void cfa(SteamShutdown_t a)
	{
		SteamManager.cfc(a.crk());
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x0003A618 File Offset: 0x00038818
	private void cfb(IPCFailure_t a)
	{
		SteamManager.cfc(a.crl());
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x0003A624 File Offset: 0x00038824
	private static void cfc(string a)
	{
		if (SteamManager.ibh)
		{
			return;
		}
		SteamManager.ibh = true;
		global::FishySteamworks.FishySteamworks.SteamApiUnavailable = true;
		Debug.LogWarning(a.crm() + a + a.crn());
		try
		{
			fp fp = fp.kto;
			if (fp != null)
			{
				fp.dav();
			}
		}
		catch (Exception ex)
		{
			string text = a.cro();
			Exception ex2 = ex;
			Debug.LogError(text + ((ex2 != null) ? ex2.ToString() : null));
		}
	}

	// Token: 0x14000012 RID: 18
	// (add) Token: 0x060009C7 RID: 2503 RVA: 0x0003A69C File Offset: 0x0003889C
	// (remove) Token: 0x060009C8 RID: 2504 RVA: 0x0003A6D0 File Offset: 0x000388D0
	public static event Action ibn;

	// Token: 0x060009C9 RID: 2505 RVA: 0x0003A703 File Offset: 0x00038903
	[MonoPInvokeCallback(typeof(SteamAPIWarningMessageHook_t))]
	protected static void cff(int a, StringBuilder b)
	{
		Debug.LogWarning(b);
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x0003A70B File Offset: 0x0003890B
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void InitOnPlayMode()
	{
		SteamManager.ibd = false;
		SteamManager.ibe = null;
		SteamManager.ibn = null;
		SteamManager.ibh = false;
		global::FishySteamworks.FishySteamworks.SteamApiUnavailable = false;
	}

	// Token: 0x060009CB RID: 2507 RVA: 0x0003A72C File Offset: 0x0003892C
	protected virtual void Awake()
	{
		if (SteamManager.ibe != null)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		SteamManager.ibe = this;
		if (SteamManager.ibd)
		{
			throw new Exception(a.crp());
		}
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError(a.crq(), this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError(a.crr(), this);
		}
		try
		{
			if (Array.IndexOf<string>(Environment.GetCommandLineArgs(), a.crs()) < 0 && SteamAPI.RestartAppIfNecessary(AppId_t.Invalid))
			{
				Debug.Log(a.crt());
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			string text = a.cru();
			DllNotFoundException ex2 = ex;
			Debug.LogError(text + ((ex2 != null) ? ex2.ToString() : null), this);
			Application.Quit();
			return;
		}
		if (!this.cfh())
		{
			this.cfk();
		}
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x0003A814 File Offset: 0x00038A14
	private bool cfh()
	{
		if (this.ibg)
		{
			return true;
		}
		if (!this.ibf)
		{
			this.ibf = SteamAPI.Init();
			if (!this.ibf)
			{
				return false;
			}
			SteamManager.ibd = true;
			this.cfi();
			this.cez();
			Debug.Log(a.crv());
		}
		if (!SteamUser.BLoggedOn())
		{
			return false;
		}
		this.ibg = true;
		Debug.Log(a.crw());
		this.cfj();
		return true;
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x0003A885 File Offset: 0x00038A85
	private void cfi()
	{
		if (this.ibm == null)
		{
			this.ibm = new SteamAPIWarningMessageHook_t(SteamManager.cff);
			SteamClient.SetWarningMessageHook(this.ibm);
		}
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x0003A8AC File Offset: 0x00038AAC
	private void cfj()
	{
		if (this.ibo)
		{
			return;
		}
		this.ibo = true;
		Action action = SteamManager.ibn;
		if (action == null)
		{
			return;
		}
		foreach (Delegate @delegate in action.GetInvocationList())
		{
			try
			{
				((Action)@delegate)();
			}
			catch (Exception ex)
			{
				string text = a.crx();
				Exception ex2 = ex;
				Debug.LogError(text + ((ex2 != null) ? ex2.ToString() : null));
			}
		}
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x0003A92C File Offset: 0x00038B2C
	private void cfk()
	{
		if (this.ibp)
		{
			return;
		}
		this.ibp = true;
		base.StartCoroutine(this.cfl());
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x0003A94B File Offset: 0x00038B4B
	private IEnumerator cfl()
	{
		Debug.LogWarning(a.cri());
		while (!this.ibg)
		{
			float num = (this.ibf ? 1f : 2f);
			yield return new WaitForSecondsRealtime(num);
			this.cfh();
		}
		this.ibp = false;
		yield break;
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x0003A95A File Offset: 0x00038B5A
	protected virtual void OnEnable()
	{
		if (SteamManager.ibe == null)
		{
			SteamManager.ibe = this;
		}
		if (!this.ibf)
		{
			return;
		}
		this.cfi();
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x0003A980 File Offset: 0x00038B80
	protected virtual void Update()
	{
		if (!this.ibf)
		{
			return;
		}
		if (SteamManager.ibh)
		{
			return;
		}
		if (Time.unscaledTime >= this.ibl)
		{
			this.ibl = Time.unscaledTime + 5f;
			bool flag;
			try
			{
				flag = SteamAPI.IsSteamRunning();
			}
			catch (Exception)
			{
				flag = false;
			}
			if (!flag)
			{
				SteamManager.cfc(a.cry());
				return;
			}
		}
		SteamAPI.RunCallbacks();
	}

	// Token: 0x040007F5 RID: 2037
	protected static bool ibd;

	// Token: 0x040007F6 RID: 2038
	protected static SteamManager ibe;

	// Token: 0x040007F7 RID: 2039
	protected bool ibf;

	// Token: 0x040007F8 RID: 2040
	private bool ibg;

	// Token: 0x040007FA RID: 2042
	private Callback<SteamShutdown_t> ibi;

	// Token: 0x040007FB RID: 2043
	private Callback<IPCFailure_t> ibj;

	// Token: 0x040007FC RID: 2044
	private const float ibk = 5f;

	// Token: 0x040007FD RID: 2045
	private float ibl;

	// Token: 0x040007FE RID: 2046
	protected SteamAPIWarningMessageHook_t ibm;

	// Token: 0x04000800 RID: 2048
	private bool ibo;

	// Token: 0x04000801 RID: 2049
	private bool ibp;

	// Token: 0x04000802 RID: 2050
	private const float ibq = 2f;

	// Token: 0x04000803 RID: 2051
	private const float ibr = 1f;
}
