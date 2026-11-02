using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using RamenCat;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

// Token: 0x0200008D RID: 141
public class ClotheItemController : MonoBehaviour
{
	// Token: 0x1700008E RID: 142
	// (get) Token: 0x0600061A RID: 1562 RVA: 0x0002194D File Offset: 0x0001FB4D
	public static ClotheItemController kpt
	{
		get
		{
			return ClotheItemController.hux;
		}
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x00021954 File Offset: 0x0001FB54
	public void Awake()
	{
		ClotheItemController.hux = this;
		this.clotheItem.transform.SetParent(this.transPool);
		this.clotheItem.gameObject.SetActive(false);
		ClotheItemController.cv cv = new ClotheItemController.cv
		{
			huf = this.titleTemplate,
			hug = ((this.titleTemplate != null) ? this.titleTemplate.GetComponentInChildren<TMP_Text>(true) : null),
			huh = this.groupTemplate
		};
		if (this.titleTemplate != null)
		{
			this.titleTemplate.SetActive(false);
		}
		if (this.groupTemplate != null)
		{
			this.groupTemplate.gameObject.SetActive(false);
		}
		this.hul.Enqueue(cv);
		if (this.btnRefreshInventory != null)
		{
			this.btnRefreshInventory.onClick.AddListener(new UnityAction(this.bph));
		}
	}

	// Token: 0x0600061C RID: 1564 RVA: 0x00021A40 File Offset: 0x0001FC40
	private void OnEnable()
	{
		bj.hja += this.bpo;
		bp.hky += this.bpq;
		fd.cvi(new Action<fd.Page>(this.bpp));
		if (this.hur && !this.hup)
		{
			this.bpi(this.huq);
		}
	}

	// Token: 0x0600061D RID: 1565 RVA: 0x00021A9C File Offset: 0x0001FC9C
	private void OnDestroy()
	{
		bj.hja -= this.bpo;
		bp.hky -= this.bpq;
		fd.cvk(new Action<fd.Page>(this.bpp));
		if (ClotheItemController.hux == this)
		{
			ClotheItemController.hux = null;
		}
	}

	// Token: 0x0600061E RID: 1566 RVA: 0x00021AF0 File Offset: 0x0001FCF0
	private void OnDisable()
	{
		bj.hja -= this.bpo;
		bp.hky -= this.bpq;
		fd.cvk(new Action<fd.Page>(this.bpp));
		if (!this.hup)
		{
			return;
		}
		this.bpv(true);
		this.hup = false;
		if (SettingPanel.kqq != null)
		{
			SettingPanel.kqq.cap();
		}
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x00021B60 File Offset: 0x0001FD60
	private void bph()
	{
		if (SteamInventoryManager.iid == null)
		{
			Debug.LogWarning(a.bhj());
			return;
		}
		if (Time.unscaledTime - this.hus < 1f)
		{
			if (bq.knd)
			{
				Debug.Log(a.bhk());
			}
			return;
		}
		this.hus = Time.unscaledTime;
		SteamInventoryManager.iid.cpl();
		Debug.Log(a.bhl());
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x00021BCC File Offset: 0x0001FDCC
	public void bpi(CLOTHE_TYPE a)
	{
		if (!SettingPanel.kqs)
		{
			this.bpu();
			this.bps();
			return;
		}
		if (this.hup && this.huq != a)
		{
			this.bpv(true);
		}
		this.bpu();
		this.bps();
		this.hum.Clear();
		List<CLOTHE_TYPE> list = this.bpj(a);
		bool flag = list.Count > 1;
		for (int i = 0; i < list.Count; i++)
		{
			CLOTHE_TYPE clothe_TYPE = list[i];
			ClotheItemController.cv cv = this.bpr();
			if (cv.huf != null)
			{
				cv.huf.SetActive(flag);
			}
			if (flag && cv.hug != null)
			{
				cv.hug.text = this.bpn(clothe_TYPE);
			}
			this.bpk(cv.huh, clothe_TYPE);
		}
		this.bpt();
		if (ClotheItem.hub)
		{
			ClotheItem.hub = false;
			ci.Save(null);
		}
		this.hup = true;
		this.huq = a;
		this.hur = true;
		if (SettingPanel.kqq != null)
		{
			SettingPanel.kqq.cap();
		}
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x00021CE4 File Offset: 0x0001FEE4
	private List<CLOTHE_TYPE> bpj(CLOTHE_TYPE a)
	{
		if (a != CLOTHE_TYPE.Dick)
		{
			return new List<CLOTHE_TYPE> { a };
		}
		if (!bj.wm(4716380U))
		{
			return new List<CLOTHE_TYPE> { CLOTHE_TYPE.Dick };
		}
		List<CLOTHE_TYPE> list = new List<CLOTHE_TYPE>(ClotheItemController.huw.Length);
		for (int i = 0; i < ClotheItemController.huw.Length; i++)
		{
			CLOTHE_TYPE clothe_TYPE = ClotheItemController.huw[i];
			List<SpineSkinData> list2 = ((bq.hle != null) ? bq.hle.bkl(clothe_TYPE) : null);
			if (list2 != null && list2.Count != 0)
			{
				list.Add(clothe_TYPE);
			}
		}
		if (list.Count == 0)
		{
			list.Add(CLOTHE_TYPE.Dick);
		}
		return list;
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x00021D80 File Offset: 0x0001FF80
	private void bpk(Transform a, CLOTHE_TYPE b)
	{
		if (bq.hle == null)
		{
			return;
		}
		List<SpineSkinData> list = bq.hle.bkl(b);
		if (list == null)
		{
			return;
		}
		if (!ClotheItemController.bpm(b) && list.Count > 0)
		{
			SpineSkinData spineSkinData = bq.hle.bjx(0);
			SpineSkinData spineSkinData2 = new SpineSkinData(list[0]);
			spineSkinData2.name = CLOTHE_NAME.Null;
			spineSkinData2.skinName = SKIN_NAME.Null;
			spineSkinData2.dlcType = DLC_TYPE.None;
			spineSkinData2.texture = bq.hle.nakedTexture;
			spineSkinData2.isNeedUnlock = false;
			spineSkinData2.creatorPageUnlock = CREATOR_PAGE_UNLOCK.None;
			ClotheItem clotheItem = this.bpx(a);
			clotheItem.boy(spineSkinData.icon);
			clotheItem.boo(spineSkinData2);
			clotheItem.bpf();
		}
		this.hun.Clear();
		this.huo.Clear();
		for (int i = 0; i < list.Count; i++)
		{
			SpineSkinData spineSkinData3 = list[i];
			if (spineSkinData3.bjq())
			{
				if (bp.zp(spineSkinData3.kox))
				{
					this.hun.Add(spineSkinData3);
				}
				else
				{
					this.huo.Add(spineSkinData3);
				}
			}
			this.hum.Add(spineSkinData3);
		}
		for (int j = 0; j < this.hun.Count; j++)
		{
			this.bpl(a, this.hun[j]);
		}
		for (int k = 0; k < this.huo.Count; k++)
		{
			this.bpl(a, this.huo[k]);
		}
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x00021EF3 File Offset: 0x000200F3
	private void bpl(Transform a, SpineSkinData b)
	{
		ClotheItem clotheItem = this.bpx(a);
		clotheItem.boy(b.icon);
		clotheItem.boo(b);
		clotheItem.bpf();
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x00021F14 File Offset: 0x00020114
	private static bool bpm(CLOTHE_TYPE a)
	{
		return a == CLOTHE_TYPE.Dick || a == CLOTHE_TYPE.SkinTone || a == CLOTHE_TYPE.IntimateParts;
	}

	// Token: 0x06000625 RID: 1573 RVA: 0x00021F28 File Offset: 0x00020128
	private string bpn(CLOTHE_TYPE a)
	{
		string text;
		if (!ClotheItemController.huv.TryGetValue(a, out text))
		{
			return a.ToString();
		}
		string text2;
		try
		{
			string localizedString = LocalizationSettings.StringDatabase.GetLocalizedString(a.rh(), text, null, FallbackBehavior.UseProjectSettings, Array.Empty<object>());
			text2 = (string.IsNullOrEmpty(localizedString) ? a.ToString() : localizedString);
		}
		catch
		{
			text2 = a.ToString();
		}
		return text2;
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x00021FB4 File Offset: 0x000201B4
	private void bpo(uint a)
	{
		if (a != 4716380U)
		{
			return;
		}
		if (!this.hup || this.huq != CLOTHE_TYPE.Dick)
		{
			return;
		}
		this.bpi(CLOTHE_TYPE.Dick);
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x00021FD7 File Offset: 0x000201D7
	private void bpp(fd.Page a)
	{
		if (!this.hup || this.huq != CLOTHE_TYPE.Dick)
		{
			return;
		}
		this.bpi(CLOTHE_TYPE.Dick);
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x00021FF1 File Offset: 0x000201F1
	private void bpq()
	{
		if (this.hup)
		{
			this.bpi(this.huq);
		}
	}

	// Token: 0x06000629 RID: 1577 RVA: 0x00022008 File Offset: 0x00020208
	private ClotheItemController.cv bpr()
	{
		ClotheItemController.cv cv;
		if (this.hul.Count > 0)
		{
			cv = this.hul.Dequeue();
		}
		else
		{
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.titleTemplate, this.transContent);
			Transform transform = global::UnityEngine.Object.Instantiate<GameObject>(this.groupTemplate.gameObject, this.transContent).transform;
			for (int i = transform.childCount - 1; i >= 0; i--)
			{
				Transform child = transform.GetChild(i);
				if (child.GetComponent<ClotheItem>() != null)
				{
					global::UnityEngine.Object.Destroy(child.gameObject);
				}
			}
			cv = new ClotheItemController.cv
			{
				huf = gameObject,
				hug = ((gameObject != null) ? gameObject.GetComponentInChildren<TMP_Text>(true) : null),
				huh = transform
			};
		}
		if (cv.huf != null)
		{
			cv.huf.transform.SetParent(this.transContent);
			cv.huf.SetActive(false);
		}
		if (cv.huh != null)
		{
			cv.huh.SetParent(this.transContent);
			cv.huh.gameObject.SetActive(true);
		}
		this.huk.Add(cv);
		return cv;
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x00022134 File Offset: 0x00020334
	private void bps()
	{
		for (int i = 0; i < this.huk.Count; i++)
		{
			ClotheItemController.cv cv = this.huk[i];
			if (cv.huf != null)
			{
				cv.huf.SetActive(false);
			}
			if (cv.huh != null)
			{
				cv.huh.gameObject.SetActive(false);
			}
			this.hul.Enqueue(cv);
		}
		this.huk.Clear();
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x000221B4 File Offset: 0x000203B4
	private void bpt()
	{
		for (int i = 0; i < this.huk.Count; i++)
		{
			ClotheItemController.cv cv = this.huk[i];
			if (cv.huf != null)
			{
				cv.huf.transform.SetSiblingIndex(i * 2);
			}
			if (cv.huh != null)
			{
				cv.huh.SetSiblingIndex(i * 2 + 1);
			}
		}
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x00022224 File Offset: 0x00020424
	private void bpu()
	{
		for (int i = this.hui.Count - 1; i >= 0; i--)
		{
			this.bpy(this.hui[i]);
		}
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x0002225C File Offset: 0x0002045C
	private void bpv(bool a)
	{
		PlayerData hlf = bq.hlf;
		PlayerSaveData playerSaveData = ((hlf != null) ? hlf.playerSaveData : null);
		if (((playerSaveData != null) ? playerSaveData.newItemDefIds : null) == null || this.hum == null)
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < this.hum.Count; i++)
		{
			SpineSkinData spineSkinData = this.hum[i];
			if (spineSkinData != null && spineSkinData.kox != 0 && spineSkinData.bjq() && playerSaveData.newItemDefIds.Remove(spineSkinData.kox))
			{
				flag = true;
			}
		}
		if (!flag)
		{
			return;
		}
		if (a)
		{
			ci.Save(null);
			if (cx.kpw != null)
			{
				cx.kpw.brh();
			}
		}
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x00022304 File Offset: 0x00020504
	public void bpw()
	{
		for (int i = 0; i < this.hui.Count; i++)
		{
			this.hui[i].bpf();
		}
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x00022338 File Offset: 0x00020538
	public ClotheItem bpx(Transform a)
	{
		ClotheItem clotheItem = ((this.huj.Count > 0) ? this.huj.Dequeue() : global::UnityEngine.Object.Instantiate<ClotheItem>(this.clotheItem, this.transPool));
		clotheItem.bon();
		clotheItem.transform.SetParent(a);
		this.hui.Add(clotheItem);
		return clotheItem;
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x00022391 File Offset: 0x00020591
	public void bpy(ClotheItem a)
	{
		this.hui.Remove(a);
		a.transform.SetParent(this.transPool);
		a.Close();
		this.huj.Enqueue(a);
	}

	// Token: 0x04000624 RID: 1572
	[SerializeField]
	private ClotheItem clotheItem;

	// Token: 0x04000625 RID: 1573
	[SerializeField]
	private Transform transContent;

	// Token: 0x04000626 RID: 1574
	[SerializeField]
	private GameObject titleTemplate;

	// Token: 0x04000627 RID: 1575
	[SerializeField]
	private Transform groupTemplate;

	// Token: 0x04000628 RID: 1576
	[SerializeField]
	private Transform transPool;

	// Token: 0x04000629 RID: 1577
	[SerializeField]
	private Button btnRefreshInventory;

	// Token: 0x0400062A RID: 1578
	private readonly List<ClotheItem> hui = new List<ClotheItem>();

	// Token: 0x0400062B RID: 1579
	private readonly Queue<ClotheItem> huj = new Queue<ClotheItem>();

	// Token: 0x0400062C RID: 1580
	private readonly List<ClotheItemController.cv> huk = new List<ClotheItemController.cv>();

	// Token: 0x0400062D RID: 1581
	private readonly Queue<ClotheItemController.cv> hul = new Queue<ClotheItemController.cv>();

	// Token: 0x0400062E RID: 1582
	private readonly List<SpineSkinData> hum = new List<SpineSkinData>();

	// Token: 0x0400062F RID: 1583
	private readonly List<SpineSkinData> hun = new List<SpineSkinData>();

	// Token: 0x04000630 RID: 1584
	private readonly List<SpineSkinData> huo = new List<SpineSkinData>();

	// Token: 0x04000631 RID: 1585
	private bool hup;

	// Token: 0x04000632 RID: 1586
	private CLOTHE_TYPE huq;

	// Token: 0x04000633 RID: 1587
	private bool hur;

	// Token: 0x04000634 RID: 1588
	private float hus;

	// Token: 0x04000635 RID: 1589
	private const float hut = 1f;

	// Token: 0x04000636 RID: 1590
	private const string huu = "UI";

	// Token: 0x04000637 RID: 1591
	private static readonly Dictionary<CLOTHE_TYPE, string> huv = new Dictionary<CLOTHE_TYPE, string>
	{
		{
			CLOTHE_TYPE.Dick,
			a.bhm()
		},
		{
			CLOTHE_TYPE.SkinTone,
			a.bhn()
		},
		{
			CLOTHE_TYPE.IntimateParts,
			a.bho()
		},
		{
			CLOTHE_TYPE.PubicAndGenital,
			a.bhp()
		}
	};

	// Token: 0x04000638 RID: 1592
	private static readonly CLOTHE_TYPE[] huw = new CLOTHE_TYPE[]
	{
		CLOTHE_TYPE.Dick,
		CLOTHE_TYPE.SkinTone,
		CLOTHE_TYPE.IntimateParts,
		CLOTHE_TYPE.PubicAndGenital
	};

	// Token: 0x04000639 RID: 1593
	private static ClotheItemController hux;

	// Token: 0x0200008E RID: 142
	private sealed class cv
	{
		// Token: 0x0400063A RID: 1594
		public GameObject huf;

		// Token: 0x0400063B RID: 1595
		public TMP_Text hug;

		// Token: 0x0400063C RID: 1596
		public Transform huh;
	}
}
