using System;
using System.Collections;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Steamworks;
using UnityEngine;

// Token: 0x020000FC RID: 252
public sealed class fa : MonoBehaviour
{
	// Token: 0x06001290 RID: 4752 RVA: 0x0005B0AB File Offset: 0x000592AB
	private void ebu()
	{
		if (fa.imk != null && fa.imk != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		fa.imk = this;
	}

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06001291 RID: 4753 RVA: 0x0005B0D9 File Offset: 0x000592D9
	// (set) Token: 0x06001297 RID: 4759 RVA: 0x0005B13F File Offset: 0x0005933F
	public fa.CheckStatus imm { get; private set; }

	// Token: 0x06001292 RID: 4754 RVA: 0x0005B0E1 File Offset: 0x000592E1
	private void Start()
	{
		base.StartCoroutine(this.cut());
	}

	// Token: 0x1400002E RID: 46
	// (add) Token: 0x060012A7 RID: 4775 RVA: 0x0005B654 File Offset: 0x00059854
	// (remove) Token: 0x06001293 RID: 4755 RVA: 0x0005B0F0 File Offset: 0x000592F0
	public static event Action iml;

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x060012A6 RID: 4774 RVA: 0x0005B64B File Offset: 0x0005984B
	// (set) Token: 0x06001294 RID: 4756 RVA: 0x0005B123 File Offset: 0x00059323
	public int imn { get; private set; }

	// Token: 0x06001295 RID: 4757 RVA: 0x0005B0AB File Offset: 0x000592AB
	private void Awake()
	{
		if (fa.imk != null && fa.imk != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		fa.imk = this;
	}

	// Token: 0x06001298 RID: 4760 RVA: 0x0005B148 File Offset: 0x00059348
	public void cuw()
	{
		if (this.imt)
		{
			return;
		}
		this.imt = true;
		base.StartCoroutine(this.cux());
	}

	// Token: 0x06001299 RID: 4761 RVA: 0x0005B168 File Offset: 0x00059368
	public void cuu()
	{
		try
		{
			this.imm = fa.CheckStatus.Checking;
			Action action = fa.iml;
			if (action != null)
			{
				action();
			}
			if (!SteamManager.krd || SteamManager.ibh)
			{
				this.cuv(SteamManager.ibh ? a.dqw() : a.dqv());
			}
			else
			{
				this.imn = SteamApps.GetAppBuildId();
				if (this.imn <= 0)
				{
					this.cuv(a.dqx());
				}
				else
				{
					string text = a.tk();
					string text2;
					if (SteamApps.GetCurrentBetaName(out text2, 256) && !string.IsNullOrEmpty(text2))
					{
						text = text2;
					}
					int num;
					int num2;
					int numBetas = SteamApps.GetNumBetas(out num, out num2);
					Debug.Log(string.Format(a.dqy(), text, numBetas) + string.Format(a.dqz(), num, num2, this.imn));
					if (numBetas <= 0)
					{
						this.cuv(string.Format(a.dra(), numBetas));
					}
					else
					{
						fa.BranchInfo? branchInfo = null;
						fa.BranchInfo? branchInfo2 = null;
						fa.BranchInfo? branchInfo3 = null;
						for (int i = 0; i < numBetas; i++)
						{
							uint num3;
							uint num4;
							string text3;
							string text4;
							if (!SteamApps.GetBetaInfo(i, out num3, out num4, out text3, 256, out text4, 256))
							{
								Debug.LogWarning(string.Format(a.drb(), i));
							}
							else
							{
								Debug.Log(string.Format(a.drc(), new object[] { i, text3, num3, num4 }));
								fa.BranchInfo branchInfo4 = new fa.BranchInfo(i, num3, num4, text3);
								if ((num3 & 8U) != 0U && branchInfo == null)
								{
									branchInfo = new fa.BranchInfo?(branchInfo4);
								}
								if (!string.IsNullOrEmpty(text) && string.Equals(text3, text, StringComparison.OrdinalIgnoreCase) && branchInfo2 == null)
								{
									branchInfo2 = new fa.BranchInfo?(branchInfo4);
								}
								if ((num3 & 1U) != 0U && branchInfo3 == null)
								{
									branchInfo3 = new fa.BranchInfo?(branchInfo4);
								}
							}
						}
						fa.BranchInfo? branchInfo5 = branchInfo;
						fa.BranchInfo? branchInfo7;
						if (branchInfo5 == null)
						{
							fa.BranchInfo? branchInfo6 = branchInfo2;
							branchInfo7 = ((branchInfo6 != null) ? branchInfo6 : branchInfo3);
						}
						else
						{
							branchInfo7 = branchInfo5;
						}
						fa.BranchInfo? branchInfo8 = branchInfo7;
						if (branchInfo8 == null)
						{
							this.cuv(string.Format(a.drd(), text, numBetas) + string.Format(a.dre(), branchInfo != null, branchInfo3 != null));
						}
						else
						{
							this.imo = branchInfo8.Value.BuildId;
							this.imp = (string.IsNullOrEmpty(branchInfo8.Value.Name) ? a.dqu() : branchInfo8.Value.Name);
							this.ims = 0;
							this.imr = new DateTime?(DateTime.UtcNow);
							this.imq = null;
							this.imm = ((this.imn == (int)this.imo) ? fa.CheckStatus.UpToDate : fa.CheckStatus.UpdateAvailable);
							Debug.Log(a.drf() + this.imp + a.drg() + string.Format(a.drh(), this.imn, this.imo, this.imm));
							Action action2 = fa.iml;
							if (action2 != null)
							{
								action2();
							}
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(string.Format(a.dri(), ex));
			this.cuv(ex.Message);
		}
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x060012AF RID: 4783 RVA: 0x0005B74E File Offset: 0x0005994E
	// (set) Token: 0x0600129A RID: 4762 RVA: 0x0005B4DC File Offset: 0x000596DC
	public uint imo { get; private set; }

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x0600129E RID: 4766 RVA: 0x0005B51D File Offset: 0x0005971D
	// (set) Token: 0x0600129B RID: 4763 RVA: 0x0005B4E5 File Offset: 0x000596E5
	public string imp { get; private set; } = a.dqu();

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x060012B0 RID: 4784 RVA: 0x0005B756 File Offset: 0x00059956
	// (set) Token: 0x0600129C RID: 4764 RVA: 0x0005B4EE File Offset: 0x000596EE
	public DateTime? imr { get; private set; }

	// Token: 0x0600129D RID: 4765 RVA: 0x0005B4F7 File Offset: 0x000596F7
	public static void cus()
	{
		if (fa.imk != null)
		{
			return;
		}
		GameObject gameObject = new GameObject(a.drj());
		global::UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.AddComponent<fa>();
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x0600129F RID: 4767 RVA: 0x0005B525 File Offset: 0x00059725
	// (set) Token: 0x060012A1 RID: 4769 RVA: 0x0005B553 File Offset: 0x00059753
	public string imq { get; private set; }

	// Token: 0x060012A0 RID: 4768 RVA: 0x0005B52D File Offset: 0x0005972D
	public static void bhx()
	{
		if (fa.imk != null)
		{
			return;
		}
		GameObject gameObject = new GameObject(a.drk());
		global::UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.AddComponent<fa>();
	}

	// Token: 0x060012A3 RID: 4771 RVA: 0x0005B574 File Offset: 0x00059774
	private IEnumerator cut()
	{
		yield return new WaitForSecondsRealtime(5f);
		for (;;)
		{
			this.cuu();
			float num = ((this.imm == fa.CheckStatus.ApiUnavailable && this.ims > 0) ? fa.ime[Math.Min(this.ims - 1, fa.ime.Length - 1)] : 1800f);
			yield return new WaitForSecondsRealtime(num);
		}
		yield break;
	}

	// Token: 0x060012A4 RID: 4772 RVA: 0x0005B584 File Offset: 0x00059784
	private void gjc(string a)
	{
		this.ims++;
		this.imm = fa.CheckStatus.ApiUnavailable;
		this.imr = new DateTime?(DateTime.UtcNow);
		this.imq = a;
		Debug.LogWarning(string.Format(a.drl(), a, this.ims));
		Action action = fa.iml;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x060012A5 RID: 4773 RVA: 0x0005B5E8 File Offset: 0x000597E8
	private void cuv(string a)
	{
		this.ims++;
		this.imm = fa.CheckStatus.ApiUnavailable;
		this.imr = new DateTime?(DateTime.UtcNow);
		this.imq = a;
		Debug.LogWarning(string.Format(a.drm(), a, this.ims));
		Action action = fa.iml;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x060012A8 RID: 4776 RVA: 0x0005B688 File Offset: 0x00059888
	private void ecg(string a)
	{
		this.ims++;
		this.imm = fa.CheckStatus.ApiUnavailable;
		this.imr = new DateTime?(DateTime.UtcNow);
		this.imq = a;
		Debug.LogWarning(string.Format(a.drn(), a, this.ims));
		Action action = fa.iml;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x060012AD RID: 4781 RVA: 0x0005B747 File Offset: 0x00059947
	// (set) Token: 0x060012A9 RID: 4777 RVA: 0x0005B6EB File Offset: 0x000598EB
	public static fa imk { get; private set; }

	// Token: 0x060012AA RID: 4778 RVA: 0x0005B6F3 File Offset: 0x000598F3
	private IEnumerator cux()
	{
		Debug.Log(string.Format(a.dqs(), 3861430U));
		Application.OpenURL(string.Format(a.dqt(), 3861430U));
		yield return new WaitForSecondsRealtime(0.5f);
		Application.Quit();
		yield break;
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x0005B6FB File Offset: 0x000598FB
	public static void hds()
	{
		if (fa.imk != null)
		{
			return;
		}
		GameObject gameObject = new GameObject(a.dro());
		global::UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.AddComponent<fa>();
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x0005B721 File Offset: 0x00059921
	public static void opq()
	{
		if (fa.imk != null)
		{
			return;
		}
		GameObject gameObject = new GameObject(a.drp());
		global::UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.AddComponent<fa>();
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x0005B0E1 File Offset: 0x000592E1
	private void eob()
	{
		base.StartCoroutine(this.cut());
	}

	// Token: 0x060012B1 RID: 4785 RVA: 0x0005B760 File Offset: 0x00059960
	private void hyr(string a)
	{
		this.ims++;
		this.imm = fa.CheckStatus.ApiUnavailable;
		this.imr = new DateTime?(DateTime.UtcNow);
		this.imq = a;
		Debug.LogWarning(string.Format(a.drq(), a, this.ims));
		Action action = fa.iml;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x040009A8 RID: 2472
	private const float ilz = 5f;

	// Token: 0x040009A9 RID: 2473
	private const float ima = 1800f;

	// Token: 0x040009AA RID: 2474
	private const float imb = 0.5f;

	// Token: 0x040009AB RID: 2475
	private const uint imc = 3861430U;

	// Token: 0x040009AC RID: 2476
	private const int imd = 256;

	// Token: 0x040009AD RID: 2477
	private static readonly float[] ime = new float[] { 300f, 900f, 3600f };

	// Token: 0x040009AE RID: 2478
	private const uint imf = 1U;

	// Token: 0x040009AF RID: 2479
	private const uint img = 2U;

	// Token: 0x040009B0 RID: 2480
	private const uint imh = 4U;

	// Token: 0x040009B1 RID: 2481
	private const uint imi = 8U;

	// Token: 0x040009B2 RID: 2482
	private const uint imj = 16U;

	// Token: 0x040009BB RID: 2491
	private int ims;

	// Token: 0x040009BC RID: 2492
	private bool imt;

	// Token: 0x020000FD RID: 253
	public enum CheckStatus
	{
		// Token: 0x040009BE RID: 2494
		Unknown,
		// Token: 0x040009BF RID: 2495
		Checking,
		// Token: 0x040009C0 RID: 2496
		UpToDate,
		// Token: 0x040009C1 RID: 2497
		UpdateAvailable,
		// Token: 0x040009C2 RID: 2498
		ApiUnavailable
	}

	// Token: 0x020000FE RID: 254
	private readonly struct BranchInfo
	{
		// Token: 0x060012B2 RID: 4786 RVA: 0x0005B7C3 File Offset: 0x000599C3
		public BranchInfo(int idx, uint flags, uint buildId, string name)
		{
			this.Index = idx;
			this.Flags = flags;
			this.BuildId = buildId;
			this.Name = name;
		}

		// Token: 0x040009C3 RID: 2499
		public readonly int Index;

		// Token: 0x040009C4 RID: 2500
		public readonly uint Flags;

		// Token: 0x040009C5 RID: 2501
		public readonly uint BuildId;

		// Token: 0x040009C6 RID: 2502
		public readonly string Name;
	}
}
