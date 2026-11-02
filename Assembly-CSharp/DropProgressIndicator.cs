using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using RamenCat;
using Steamworks;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

// Token: 0x02000034 RID: 52
public class DropProgressIndicator : MonoBehaviour
{
	// Token: 0x17000044 RID: 68
	// (get) Token: 0x060002FC RID: 764 RVA: 0x0000E817 File Offset: 0x0000CA17
	// (set) Token: 0x060002FD RID: 765 RVA: 0x0000E81E File Offset: 0x0000CA1E
	public static DropProgressIndicator hkp { get; private set; }

	// Token: 0x060002FE RID: 766 RVA: 0x0000E826 File Offset: 0x0000CA26
	private void Awake()
	{
		DropProgressIndicator.hkp = this;
	}

	// Token: 0x060002FF RID: 767 RVA: 0x0000E82E File Offset: 0x0000CA2E
	private void OnDestroy()
	{
		if (DropProgressIndicator.hkp == this)
		{
			DropProgressIndicator.hkp = null;
		}
	}

	// Token: 0x06000300 RID: 768 RVA: 0x0000E844 File Offset: 0x0000CA44
	private void OnEnable()
	{
		du.iae -= this.yx;
		du.iae += this.yx;
		du.iad -= this.za;
		du.iad += this.za;
		SteamInventoryManager.iij -= this.yy;
		SteamInventoryManager.iij += this.yy;
		this.hkq = false;
		this.hkr = false;
		this.hks = 0;
		this.hkt = 0;
		this.hku = -1;
		this.hkv = 0f;
		this.hkw = float.NaN;
		this.hkx = null;
		this.ze();
		du du = du.iah;
		if (du != null && du.iai)
		{
			this.yx();
		}
	}

	// Token: 0x06000301 RID: 769 RVA: 0x0000E91A File Offset: 0x0000CB1A
	private void OnDisable()
	{
		du.iae -= this.yx;
		du.iad -= this.za;
		SteamInventoryManager.iij -= this.yy;
	}

	// Token: 0x06000302 RID: 770 RVA: 0x0000E950 File Offset: 0x0000CB50
	private void OnApplicationQuit()
	{
		du du = du.iah;
		if (du == null)
		{
			return;
		}
		if (!this.hkq || !this.hkr)
		{
			return;
		}
		if (!du.iai || !SteamManager.krd)
		{
			return;
		}
		du.ceb();
	}

	// Token: 0x06000303 RID: 771 RVA: 0x0000E994 File Offset: 0x0000CB94
	private void yx()
	{
		this.hkq = true;
		this.hkv = 0f;
		this.yz(true);
		this.zd();
	}

	// Token: 0x06000304 RID: 772 RVA: 0x0000E9B8 File Offset: 0x0000CBB8
	private void yy()
	{
		if (!this.hkq || !this.hkr)
		{
			return;
		}
		du du = du.iah;
		if (du == null || !du.iai)
		{
			return;
		}
		if (bq.knd)
		{
			Debug.Log(a.qs());
		}
		this.yz(false);
		this.zd();
	}

	// Token: 0x06000305 RID: 773 RVA: 0x0000EA0C File Offset: 0x0000CC0C
	private void yz(bool a = true)
	{
		this.hkt = 0;
		du du = du.iah;
		int num;
		if (du != null && du.ceg(du.STEAM_STAT_ID.STAT_PLAYTIME_SINCE_DROP, out num))
		{
			num = Mathf.Max(0, num);
			int num2 = Mathf.Max(0, PlayerPrefs.GetInt(a.qt(), 0));
			bool flag = PlayerPrefs.GetInt(a.qu(), 0) == 1;
			bool flag2 = num2 > num && (flag || num == 0);
			this.hks = (flag2 ? num2 : num);
			this.hkr = true;
			this.hku = this.hks;
			if (flag2)
			{
				Debug.LogWarning(string.Format(a.qv(), num, num2, flag));
				du.cec(du.STEAM_STAT_ID.STAT_PLAYTIME_SINCE_DROP, num2, du.STEAM_STAT_OP.Set);
				du.ceb();
			}
			else if (bq.knd)
			{
				Debug.Log(string.Format(a.qw(), new object[] { this.hks, num, num2, flag }));
			}
			DropProgressIndicator.zh(this.hks, flag || flag2);
			if (a && this.hks >= 1800 && DropProgressIndicator.zk())
			{
				if (bq.knd)
				{
					Debug.Log(string.Format(a.qx(), this.hks));
				}
				SteamInventoryManager steamInventoryManager = SteamInventoryManager.iid;
				if (steamInventoryManager == null)
				{
					return;
				}
				steamInventoryManager.cpl();
				return;
			}
		}
		else
		{
			this.hks = 0;
			this.hkr = false;
			this.hku = -1;
		}
	}

	// Token: 0x06000306 RID: 774 RVA: 0x0000EB84 File Offset: 0x0000CD84
	private void za()
	{
		if (PlayerPrefs.GetInt(a.qu(), 0) == 0)
		{
			return;
		}
		du du = du.iah;
		if (du != null && du.iak < du.iaj)
		{
			return;
		}
		PlayerPrefs.SetInt(a.qu(), 0);
		PlayerPrefs.Save();
	}

	// Token: 0x06000307 RID: 775 RVA: 0x0000EBD0 File Offset: 0x0000CDD0
	public void zb()
	{
		du du = du.iah;
		if (du == null || !this.hkq || !this.hkr || !du.iai)
		{
			return;
		}
		if (bq.knd)
		{
			Debug.Log(string.Format(a.qy(), this.hks + this.hkt));
		}
		du.cec(du.STEAM_STAT_ID.STAT_PLAYTIME_SINCE_DROP, 0, du.STEAM_STAT_OP.Set);
		du.ceb();
		this.hks = 0;
		this.hkt = 0;
		this.hku = 0;
		DropProgressIndicator.zh(0, true);
		this.hkw = float.NaN;
		this.hkx = null;
		this.zd();
	}

	// Token: 0x06000308 RID: 776 RVA: 0x0000EC70 File Offset: 0x0000CE70
	private void Update()
	{
		du du = du.iah;
		if (du == null)
		{
			this.hkq = false;
			this.ze();
			return;
		}
		if (!du.iai)
		{
			this.hkq = false;
			this.hkr = false;
			this.hkv = 0f;
			this.ze();
			return;
		}
		if (!this.hkq)
		{
			return;
		}
		this.hkv += Time.unscaledDeltaTime;
		while (this.hkv >= 1f)
		{
			this.hkv -= 1f;
			this.zc(du);
		}
	}

	// Token: 0x06000309 RID: 777 RVA: 0x0000ED08 File Offset: 0x0000CF08
	private void zc(du a)
	{
		if (this.hkr)
		{
			this.hkt++;
			int num = this.hks + this.hkt;
			if (num != this.hku)
			{
				a.cec(du.STEAM_STAT_ID.STAT_PLAYTIME_SINCE_DROP, num, du.STEAM_STAT_OP.Set);
				this.hku = num;
				DropProgressIndicator.zh(num, true);
			}
		}
		this.zd();
	}

	// Token: 0x0600030A RID: 778 RVA: 0x0000ED60 File Offset: 0x0000CF60
	private void zd()
	{
		du du = du.iah;
		if (du == null || !this.hkq || !du.iai || !this.hkr)
		{
			this.ze();
			return;
		}
		int num = this.hks + this.hkt;
		if (num < 0)
		{
			num = 0;
		}
		if (num >= 1800)
		{
			this.zf(1f);
			string text = (DropProgressIndicator.zk() ? DropProgressIndicator.zj(a.rb(), a.rc()) : DropProgressIndicator.zj(a.qz(), a.ra()));
			this.zg(text);
			return;
		}
		this.zf((float)num / 1800f);
		int num2 = 1800 - num;
		this.zg(DropProgressIndicator.zi(num2));
	}

	// Token: 0x0600030B RID: 779 RVA: 0x0000EE19 File Offset: 0x0000D019
	private void ze()
	{
		this.zf(0f);
		this.zg(DropProgressIndicator.zj(a.rd(), a.re()));
	}

	// Token: 0x0600030C RID: 780 RVA: 0x0000EE3C File Offset: 0x0000D03C
	private void zf(float a)
	{
		if (this._slider == null)
		{
			return;
		}
		if (!float.IsNaN(this.hkw) && Mathf.Abs(this.hkw - a) <= 0.001f)
		{
			return;
		}
		this._slider.value = a;
		this.hkw = a;
	}

	// Token: 0x0600030D RID: 781 RVA: 0x0000EE8D File Offset: 0x0000D08D
	private void zg(string a)
	{
		if (this.tipObject == null)
		{
			return;
		}
		if (this.hkx == a)
		{
			return;
		}
		this.tipObject.vh(a);
		this.hkx = a;
	}

	// Token: 0x0600030E RID: 782 RVA: 0x0000EEC0 File Offset: 0x0000D0C0
	private static void zh(int a, bool b)
	{
		PlayerPrefs.SetInt(a.qt(), Mathf.Max(0, a));
		PlayerPrefs.SetInt(a.qu(), b ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x0600030F RID: 783 RVA: 0x0000EEEC File Offset: 0x0000D0EC
	private static string zi(int a)
	{
		if (a < 0)
		{
			a = 0;
		}
		int num = a / 60;
		int num2 = a % 60;
		return string.Format(DropProgressIndicator.zj(a.rf(), a.rg()), num, num2);
	}

	// Token: 0x06000310 RID: 784 RVA: 0x0000EF2C File Offset: 0x0000D12C
	private static string zj(string a, string b)
	{
		string text;
		try
		{
			string localizedString = LocalizationSettings.StringDatabase.GetLocalizedString(a.rh(), a, null, FallbackBehavior.UseProjectSettings, Array.Empty<object>());
			text = (string.IsNullOrEmpty(localizedString) ? b : localizedString);
		}
		catch
		{
			text = b;
		}
		return text;
	}

	// Token: 0x06000311 RID: 785 RVA: 0x0000EF80 File Offset: 0x0000D180
	private static bool zk()
	{
		if (!SteamManager.krd)
		{
			return false;
		}
		bool flag;
		try
		{
			flag = SteamUser.BLoggedOn();
		}
		catch
		{
			flag = false;
		}
		return flag;
	}

	// Token: 0x0400015D RID: 349
	private const int hkf = 1800;

	// Token: 0x0400015E RID: 350
	private const float hkg = 1f;

	// Token: 0x0400015F RID: 351
	private const float hkh = 0.001f;

	// Token: 0x04000160 RID: 352
	private const string hki = "UI";

	// Token: 0x04000161 RID: 353
	private const string hkj = "drop_progress_remaining";

	// Token: 0x04000162 RID: 354
	private const string hkk = "drop_progress_imminent";

	// Token: 0x04000163 RID: 355
	private const string hkl = "drop_progress_loading";

	// Token: 0x04000164 RID: 356
	private const string hkm = "drop_progress_offline";

	// Token: 0x04000165 RID: 357
	private const string hkn = "DropProgress_STAT_PLAYTIME_SINCE_DROP_Value";

	// Token: 0x04000166 RID: 358
	private const string hko = "DropProgress_STAT_PLAYTIME_SINCE_DROP_Pending";

	// Token: 0x04000167 RID: 359
	[SerializeField]
	private Slider _slider;

	// Token: 0x04000168 RID: 360
	[SerializeField]
	private bb tipObject;

	// Token: 0x0400016A RID: 362
	private bool hkq;

	// Token: 0x0400016B RID: 363
	private bool hkr;

	// Token: 0x0400016C RID: 364
	private int hks;

	// Token: 0x0400016D RID: 365
	private int hkt;

	// Token: 0x0400016E RID: 366
	private int hku = -1;

	// Token: 0x0400016F RID: 367
	private float hkv;

	// Token: 0x04000170 RID: 368
	private float hkw = float.NaN;

	// Token: 0x04000171 RID: 369
	private string hkx;
}
