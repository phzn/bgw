using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Discord.Sdk;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

// Token: 0x02000030 RID: 48
public class bo : MonoBehaviour
{
	// Token: 0x060002C9 RID: 713 RVA: 0x0000D8F4 File Offset: 0x0000BAF4
	private void dxk(Locale a)
	{
		Debug.Log(a.nu() + a.Identifier.Code);
		this.ys();
	}

	// Token: 0x060002CA RID: 714 RVA: 0x0000D924 File Offset: 0x0000BB24
	public void mfo(string a)
	{
		this.hjz = (string.IsNullOrWhiteSpace(a) ? null : a);
		this.ys();
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x060002CB RID: 715 RVA: 0x0000D93E File Offset: 0x0000BB3E
	public bool knb
	{
		get
		{
			return this.hkb;
		}
	}

	// Token: 0x060002CC RID: 716 RVA: 0x0000D948 File Offset: 0x0000BB48
	private void ffp()
	{
		LocalizationSettings.SelectedLocaleChanged -= this.yp;
		if (this.hjy || this.hjw == null)
		{
			return;
		}
		try
		{
			if (this.hjx)
			{
				this.hjw.ClearRichPresence();
			}
		}
		catch
		{
		}
		this.hjw.Dispose();
		this.hjw = null;
	}

	// Token: 0x060002CD RID: 717 RVA: 0x0000D9B4 File Offset: 0x0000BBB4
	private string krw()
	{
		Locale selectedLocale = LocalizationSettings.SelectedLocale;
		if (selectedLocale == null)
		{
			return a.nv();
		}
		string code = selectedLocale.Identifier.Code;
		string text;
		if (!(code == a.nw()))
		{
			if (!(code == a.nx()))
			{
				if (!(code == a.ny()))
				{
					if (!(code == a.nz()))
					{
						text = a.oe();
					}
					else
					{
						text = a.od();
					}
				}
				else
				{
					text = a.oc();
				}
			}
			else
			{
				text = a.ob();
			}
		}
		else
		{
			text = a.oa();
		}
		return text;
	}

	// Token: 0x060002CE RID: 718 RVA: 0x0000DA44 File Offset: 0x0000BC44
	private void ym()
	{
		Debug.Log(a.of());
		this.hjw = new Client();
		this.hjw.AddLogCallback(new Client.LogCallback(bo.<>c.<>9.ya), LoggingSeverity.Info);
		this.hjw.SetApplicationId(1490748096097816657UL);
		Debug.Log(string.Format(a.og(), 1490748096097816657UL));
		bool flag = this.hjw.RegisterLaunchSteamApplication(1490748096097816657UL, 3861430U);
		Debug.Log(a.oh() + (flag ? a.oj() : a.oi()));
		this.hka = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x0000DB1C File Offset: 0x0000BD1C
	private IEnumerator yo()
	{
		yield return LocalizationSettings.InitializationOperation;
		string text = a.nt();
		Locale selectedLocale = LocalizationSettings.SelectedLocale;
		Debug.Log(text + ((selectedLocale != null) ? selectedLocale.Identifier.Code : null));
		this.ys();
		LocalizationSettings.SelectedLocaleChanged += this.yp;
		yield break;
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x0000DB2B File Offset: 0x0000BD2B
	private void Start()
	{
		if (this.hkb)
		{
			this.ym();
			this.hkc = base.StartCoroutine(this.yo());
			return;
		}
		Debug.Log(a.ok());
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x0000DB58 File Offset: 0x0000BD58
	public void yq(bool a)
	{
		this.hkb = a;
		PlayerPrefs.SetInt(a.ol(), a ? 1 : 0);
		PlayerPrefs.Save();
		if (this.hjy)
		{
			return;
		}
		if (this.hkc != null)
		{
			base.StopCoroutine(this.hkc);
			this.hkc = null;
		}
		if (this.hkd && this.hjw != null)
		{
			try
			{
				this.hjw.Dispose();
			}
			catch (Exception ex)
			{
				Debug.LogWarning(a.om() + ex.Message);
			}
			this.hjw = null;
		}
		this.hkd = false;
		if (a)
		{
			if (this.hjw == null)
			{
				this.ym();
				this.hkc = base.StartCoroutine(this.yo());
				return;
			}
			this.ys();
			return;
		}
		else
		{
			if (this.hjw == null)
			{
				Debug.Log(a.on());
				return;
			}
			this.hkc = base.StartCoroutine(this.yr());
			return;
		}
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x0000DC4C File Offset: 0x0000BE4C
	private void kuu()
	{
		if (this.hkb)
		{
			this.ym();
			this.hkc = base.StartCoroutine(this.yo());
			return;
		}
		Debug.Log(a.oo());
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x0000DC7C File Offset: 0x0000BE7C
	private string yt()
	{
		Locale selectedLocale = LocalizationSettings.SelectedLocale;
		if (selectedLocale == null)
		{
			return a.dj();
		}
		string code = selectedLocale.Identifier.Code;
		string text;
		if (!(code == a.op()))
		{
			if (!(code == a.oq()))
			{
				if (!(code == a.or()))
				{
					if (!(code == a.os()))
					{
						text = a.ow();
					}
					else
					{
						text = a.ov();
					}
				}
				else
				{
					text = a.ou();
				}
			}
			else
			{
				text = a.ot();
			}
		}
		else
		{
			text = a.ot();
		}
		return text;
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x0000DD0C File Offset: 0x0000BF0C
	private void blz()
	{
		LocalizationSettings.SelectedLocaleChanged -= this.yp;
		if (this.hjy || this.hjw == null)
		{
			return;
		}
		try
		{
			if (this.hjx)
			{
				this.hjw.ClearRichPresence();
			}
		}
		catch
		{
		}
		this.hjw.Dispose();
		this.hjw = null;
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x0000D924 File Offset: 0x0000BB24
	public void yn(string a)
	{
		this.hjz = (string.IsNullOrWhiteSpace(a) ? null : a);
		this.ys();
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x0000DD78 File Offset: 0x0000BF78
	private void kng()
	{
		this.hjy = true;
		if (this.hjw == null)
		{
			return;
		}
		try
		{
			if (this.hjx)
			{
				this.hjw.ClearRichPresence();
			}
			this.hjw.Disconnect();
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.ox() + ex.Message);
		}
		Thread.Sleep(5);
		try
		{
			this.hjw.Dispose();
		}
		catch (Exception ex2)
		{
			Debug.LogWarning(a.oy() + ex2.Message);
		}
		this.hjw = null;
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x0000DE1C File Offset: 0x0000C01C
	[CompilerGenerated]
	private void yu(ClientResult a)
	{
		if (a.Successful())
		{
			this.hjx = true;
			Debug.Log(a.oz());
			return;
		}
		Debug.LogWarning(string.Format(a.pa(), a));
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x0000DE48 File Offset: 0x0000C048
	private string cqc()
	{
		Locale selectedLocale = LocalizationSettings.SelectedLocale;
		if (selectedLocale == null)
		{
			return a.pb();
		}
		string code = selectedLocale.Identifier.Code;
		string text;
		if (!(code == a.pc()))
		{
			if (!(code == a.pd()))
			{
				if (!(code == a.pe()))
				{
					if (!(code == a.pf()))
					{
						text = a.pk();
					}
					else
					{
						text = a.pj();
					}
				}
				else
				{
					text = a.pi();
				}
			}
			else
			{
				text = a.ph();
			}
		}
		else
		{
			text = a.pg();
		}
		return text;
	}

	// Token: 0x060002DA RID: 730 RVA: 0x0000DED8 File Offset: 0x0000C0D8
	private void dxq()
	{
		if (bo.hke != null && bo.hke != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		bo.hke = this;
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		this.hkb = PlayerPrefs.GetInt(a.pl(), 1) == 1;
	}

	// Token: 0x060002DB RID: 731 RVA: 0x0000DF30 File Offset: 0x0000C130
	private void OnDestroy()
	{
		LocalizationSettings.SelectedLocaleChanged -= this.yp;
		if (this.hjy || this.hjw == null)
		{
			return;
		}
		try
		{
			if (this.hjx)
			{
				this.hjw.ClearRichPresence();
			}
		}
		catch
		{
		}
		this.hjw.Dispose();
		this.hjw = null;
	}

	// Token: 0x060002DC RID: 732 RVA: 0x0000DF9C File Offset: 0x0000C19C
	private void yp(Locale a)
	{
		Debug.Log(a.pm() + a.Identifier.Code);
		this.ys();
	}

	// Token: 0x060002DD RID: 733 RVA: 0x0000DFCC File Offset: 0x0000C1CC
	private void fka()
	{
		this.hjy = true;
		if (this.hjw == null)
		{
			return;
		}
		try
		{
			if (this.hjx)
			{
				this.hjw.ClearRichPresence();
			}
			this.hjw.Disconnect();
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.pn() + ex.Message);
		}
		Thread.Sleep(-35);
		try
		{
			this.hjw.Dispose();
		}
		catch (Exception ex2)
		{
			Debug.LogWarning(a.po() + ex2.Message);
		}
		this.hjw = null;
	}

	// Token: 0x060002DE RID: 734 RVA: 0x0000E074 File Offset: 0x0000C274
	private void gfi()
	{
		Debug.Log(a.pp());
		this.hjw = new Client();
		this.hjw.AddLogCallback(new Client.LogCallback(bo.<>c.<>9.ya), LoggingSeverity.Info);
		this.hjw.SetApplicationId(18446744073709545607UL);
		Debug.Log(string.Format(a.pq(), 8027UL));
		bool flag = this.hjw.RegisterLaunchSteamApplication(18446744073709547217UL, 14U);
		Debug.Log(a.pr() + (flag ? a.pt() : a.ps()));
		this.hka = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000E1CC File Offset: 0x0000C3CC
	// (set) Token: 0x060002DF RID: 735 RVA: 0x0000E13A File Offset: 0x0000C33A
	public static bo hke { get; private set; }

	// Token: 0x060002E0 RID: 736 RVA: 0x0000E144 File Offset: 0x0000C344
	private void Awake()
	{
		if (bo.hke != null && bo.hke != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		bo.hke = this;
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		this.hkb = PlayerPrefs.GetInt(a.ol(), 1) == 1;
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x0000E19C File Offset: 0x0000C39C
	private void oib(Locale a)
	{
		Debug.Log(a.pu() + a.Identifier.Code);
		this.ys();
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x0000E1D4 File Offset: 0x0000C3D4
	private string hoz()
	{
		Locale selectedLocale = LocalizationSettings.SelectedLocale;
		if (selectedLocale == null)
		{
			return a.pv();
		}
		string code = selectedLocale.Identifier.Code;
		string text;
		if (!(code == a.pw()))
		{
			if (!(code == a.px()))
			{
				if (!(code == a.py()))
				{
					if (!(code == a.pz()))
					{
						text = a.qe();
					}
					else
					{
						text = a.qd();
					}
				}
				else
				{
					text = a.qc();
				}
			}
			else
			{
				text = a.qb();
			}
		}
		else
		{
			text = a.qa();
		}
		return text;
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x0000E264 File Offset: 0x0000C464
	private void nqu(Locale a)
	{
		Debug.Log(a.qf() + a.Identifier.Code);
		this.ys();
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x0000E294 File Offset: 0x0000C494
	private void byh()
	{
		if (bo.hke != null && bo.hke != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		bo.hke = this;
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		this.hkb = PlayerPrefs.GetInt(a.qg(), 1) == 1;
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x0000E2EC File Offset: 0x0000C4EC
	public void ys()
	{
		if (this.hjw == null)
		{
			return;
		}
		if (!this.hkb)
		{
			if (this.hjx)
			{
				try
				{
					this.hjw.ClearRichPresence();
				}
				catch (Exception ex)
				{
					Debug.LogWarning(a.qh() + ex.Message);
				}
				this.hjx = false;
			}
			return;
		}
		string text = this.yt();
		Debug.Log(a.qi() + text);
		Activity activity = new Activity();
		activity.SetType(ActivityTypes.Playing);
		activity.SetName(text);
		if (!string.IsNullOrEmpty(this.hjz))
		{
			activity.SetDetails(this.hjz);
		}
		ActivityAssets activityAssets = new ActivityAssets();
		activityAssets.SetLargeImage(a.qj());
		activityAssets.SetLargeText(a.dj());
		activity.SetAssets(activityAssets);
		ActivityTimestamps activityTimestamps = new ActivityTimestamps();
		activityTimestamps.SetStart((ulong)this.hka);
		activity.SetTimestamps(activityTimestamps);
		ActivityButton activityButton = new ActivityButton();
		activityButton.SetLabel(a.qk());
		activityButton.SetUrl(a.ql());
		activity.AddButton(activityButton);
		ActivityButton activityButton2 = new ActivityButton();
		activityButton2.SetLabel(a.qm());
		activityButton2.SetUrl(a.qn());
		activity.AddButton(activityButton2);
		this.hjw.UpdateRichPresence(activity, new Client.UpdateRichPresenceCallback(this.yu));
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x0000E438 File Offset: 0x0000C638
	private IEnumerator yr()
	{
		this.hkd = true;
		LocalizationSettings.SelectedLocaleChanged -= this.yp;
		try
		{
			if (this.hjx)
			{
				this.hjw.ClearRichPresence();
			}
			this.hjw.Disconnect();
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.nq() + ex.Message);
		}
		this.hjx = false;
		yield return new WaitForSecondsRealtime(0.5f);
		if (this.hjy)
		{
			this.hkc = null;
			yield break;
		}
		if (this.hjw != null)
		{
			try
			{
				this.hjw.Dispose();
			}
			catch (Exception ex2)
			{
				Debug.LogWarning(a.nr() + ex2.Message);
			}
			this.hjw = null;
		}
		this.hkd = false;
		Debug.Log(a.ns());
		this.hkc = null;
		yield break;
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x0000D924 File Offset: 0x0000BB24
	public void lsk(string a)
	{
		this.hjz = (string.IsNullOrWhiteSpace(a) ? null : a);
		this.ys();
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x0000E448 File Offset: 0x0000C648
	private void bfg()
	{
		if (bo.hke != null && bo.hke != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		bo.hke = this;
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		this.hkb = PlayerPrefs.GetInt(a.qo(), 1) == 1;
	}

	// Token: 0x060002EA RID: 746 RVA: 0x0000E4A0 File Offset: 0x0000C6A0
	private void gll(Locale a)
	{
		Debug.Log(a.qp() + a.Identifier.Code);
		this.ys();
	}

	// Token: 0x060002EB RID: 747 RVA: 0x0000E4D0 File Offset: 0x0000C6D0
	private void OnApplicationQuit()
	{
		this.hjy = true;
		if (this.hjw == null)
		{
			return;
		}
		try
		{
			if (this.hjx)
			{
				this.hjw.ClearRichPresence();
			}
			this.hjw.Disconnect();
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.qq() + ex.Message);
		}
		Thread.Sleep(500);
		try
		{
			this.hjw.Dispose();
		}
		catch (Exception ex2)
		{
			Debug.LogWarning(a.qr() + ex2.Message);
		}
		this.hjw = null;
	}

	// Token: 0x060002EC RID: 748 RVA: 0x0000E578 File Offset: 0x0000C778
	private void ipb()
	{
		LocalizationSettings.SelectedLocaleChanged -= this.yp;
		if (this.hjy || this.hjw == null)
		{
			return;
		}
		try
		{
			if (this.hjx)
			{
				this.hjw.ClearRichPresence();
			}
		}
		catch
		{
		}
		this.hjw.Dispose();
		this.hjw = null;
	}

	// Token: 0x04000149 RID: 329
	private const ulong hju = 1490748096097816657UL;

	// Token: 0x0400014A RID: 330
	private const uint hjv = 3861430U;

	// Token: 0x0400014B RID: 331
	public const string PREF_KEY_RICH_PRESENCE = "Settings_DiscordRichPresence";

	// Token: 0x0400014C RID: 332
	private Client hjw;

	// Token: 0x0400014D RID: 333
	private bool hjx;

	// Token: 0x0400014E RID: 334
	private bool hjy;

	// Token: 0x0400014F RID: 335
	private string hjz;

	// Token: 0x04000150 RID: 336
	private long hka;

	// Token: 0x04000151 RID: 337
	private bool hkb = true;

	// Token: 0x04000152 RID: 338
	private Coroutine hkc;

	// Token: 0x04000153 RID: 339
	private bool hkd;
}
