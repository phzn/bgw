using System;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

// Token: 0x0200007A RID: 122
[DefaultExecutionOrder(100)]
public sealed class AmbientPageController : MonoBehaviour
{
	// Token: 0x06000563 RID: 1379 RVA: 0x0001DF38 File Offset: 0x0001C138
	private void Awake()
	{
		if (this.sceneImages != null && this.sceneImages.Length >= 2)
		{
			if (this.sceneImages[0] != null)
			{
				this.hst = this.sceneImages[0].color;
			}
			if (this.sceneImages[1] != null)
			{
				this.hsu = this.sceneImages[1].color;
			}
			if (AmbientPageController.blk(this.hst, this.hsu))
			{
				this.hst = new Color32(240, 160, 80, byte.MaxValue);
			}
		}
		if (this.toggleBirds != null)
		{
			this.toggleBirds.onValueChanged.AddListener(new UnityAction<bool>(this.blw));
		}
		if (this.toggleInsects != null)
		{
			this.toggleInsects.onValueChanged.AddListener(new UnityAction<bool>(this.blx));
		}
		if (this.toggleThemeForest != null)
		{
			this.toggleThemeForest.onValueChanged.AddListener(new UnityAction<bool>(this.blq));
		}
		if (this.toggleThemeCity != null)
		{
			this.toggleThemeCity.onValueChanged.AddListener(new UnityAction<bool>(this.blr));
		}
		if (this.toggleThemeNone != null)
		{
			this.toggleThemeNone.onValueChanged.AddListener(new UnityAction<bool>(this.bls));
		}
		AmbientPageController.blj(this.cityTimeToggles, new UnityAction<int, bool>(this.blt));
		AmbientPageController.blj(this.cityWeatherToggles, new UnityAction<int, bool>(this.blu));
		AmbientPageController.blj(this.busyToggles, new UnityAction<int, bool>(this.blv));
		if (this.weatherToggles != null)
		{
			AmbientPageController.blj(this.weatherToggles, new UnityAction<int, bool>(this.blp));
			this.hsv = new TMP_Text[this.weatherToggles.Length][];
			this.hsw = new float[this.weatherToggles.Length][];
			for (int i = 0; i < this.weatherToggles.Length; i++)
			{
				if (!(this.weatherToggles[i] == null))
				{
					TMP_Text[] componentsInChildren = this.weatherToggles[i].GetComponentsInChildren<TMP_Text>(true);
					this.hsv[i] = componentsInChildren;
					this.hsw[i] = new float[componentsInChildren.Length];
					for (int j = 0; j < componentsInChildren.Length; j++)
					{
						this.hsw[i][j] = ((componentsInChildren[j] != null) ? componentsInChildren[j].color.a : 1f);
					}
				}
			}
		}
		if (this.sceneButtons != null)
		{
			for (int k = 0; k < this.sceneButtons.Length; k++)
			{
				AmbientPageController.cj cj = new AmbientPageController.cj();
				cj.hsf = this;
				cj.hse = k;
				if (this.sceneButtons[k] != null)
				{
					this.sceneButtons[k].onClick.AddListener(new UnityAction(cj.blg));
				}
			}
		}
		if (this.cityLayerButtons != null)
		{
			for (int l = 0; l < this.cityLayerButtons.Length; l++)
			{
				AmbientPageController.ck ck = new AmbientPageController.ck();
				ck.hsh = this;
				ck.hsg = l;
				if (this.cityLayerButtons[l] != null)
				{
					this.cityLayerButtons[l].onClick.AddListener(new UnityAction(ck.blh));
				}
			}
		}
		if (this.sliderVolume != null)
		{
			this.sliderVolume.onValueChanged.AddListener(new UnityAction<float>(AmbientPageController.<>c.<>9.blf));
			AmbientPageController.bll(this.sliderVolume.gameObject, new UnityAction<BaseEventData>(this.bmh));
		}
		if (this.muteButton != null)
		{
			this.muteButton.hzh += this.blo;
		}
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x0001E308 File Offset: 0x0001C508
	private static void blj(Toggle[] a, UnityAction<int, bool> b)
	{
		AmbientPageController.cl cl = new AmbientPageController.cl();
		cl.hsi = b;
		if (a == null)
		{
			return;
		}
		for (int i = 0; i < a.Length; i++)
		{
			AmbientPageController.cm cm = new AmbientPageController.cm();
			cm.hsk = cl;
			if (!(a[i] == null))
			{
				cm.hsj = i;
				a[i].onValueChanged.AddListener(new UnityAction<bool>(cm.bli));
			}
		}
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x0001E36C File Offset: 0x0001C56C
	private static bool blk(Color a, Color b)
	{
		return Mathf.Approximately(a.r, b.r) && Mathf.Approximately(a.g, b.g) && Mathf.Approximately(a.b, b.b) && Mathf.Approximately(a.a, b.a);
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x0001E3C8 File Offset: 0x0001C5C8
	private static void bll(GameObject a, UnityAction<BaseEventData> b)
	{
		EventTrigger eventTrigger = a.GetComponent<EventTrigger>();
		if (eventTrigger == null)
		{
			eventTrigger = a.AddComponent<EventTrigger>();
		}
		EventTrigger.Entry entry = new EventTrigger.Entry
		{
			eventID = EventTriggerType.PointerUp
		};
		entry.callback.AddListener(b);
		eventTrigger.triggers.Add(entry);
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x0001E411 File Offset: 0x0001C611
	private void Start()
	{
		this.bma();
		this.hsx = true;
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x0001E420 File Offset: 0x0001C620
	private void OnEnable()
	{
		if (AmbientPlayer.kll != null)
		{
			AmbientPlayer.kll.hbs += this.bma;
		}
		AudioManager.hfa += this.bln;
		LocalizationSettings.SelectedLocaleChanged += this.blm;
		if (this.sliderVolume != null)
		{
			float @float = PlayerPrefs.GetFloat(a.bi(), 0.5f);
			if (!Mathf.Approximately(this.sliderVolume.value, @float))
			{
				this.sliderVolume.value = @float;
			}
		}
		this.bma();
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x0001E4B8 File Offset: 0x0001C6B8
	private void OnDisable()
	{
		if (AmbientPlayer.kll != null)
		{
			AmbientPlayer.kll.hbs -= this.bma;
		}
		AudioManager.hfa -= this.bln;
		LocalizationSettings.SelectedLocaleChanged -= this.blm;
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x0001E50A File Offset: 0x0001C70A
	private void blm(Locale a)
	{
		this.bma();
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x0001E512 File Offset: 0x0001C712
	private void bln(float a)
	{
		if (this.sliderVolume != null && !Mathf.Approximately(this.sliderVolume.value, a))
		{
			this.sliderVolume.value = a;
		}
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x0001E541 File Offset: 0x0001C741
	private void blo()
	{
		if (this.sliderVolume == null)
		{
			return;
		}
		PlayerPrefs.SetFloat(a.bi(), this.sliderVolume.value);
		PlayerPrefs.Save();
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x0001E56C File Offset: 0x0001C76C
	private void blp(int a, bool b)
	{
		if (!this.hsx || this.hsy || !b)
		{
			return;
		}
		AmbientPlayer ambientPlayer = AmbientPlayer.kll;
		if (ambientPlayer == null)
		{
			return;
		}
		ambientPlayer.nx((AmbientWeather)a);
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x0001E594 File Offset: 0x0001C794
	private void blq(bool a)
	{
		if (!this.hsx || this.hsy || !a)
		{
			return;
		}
		AmbientPlayer ambientPlayer = AmbientPlayer.kll;
		if (ambientPlayer == null)
		{
			return;
		}
		ambientPlayer.nu(AmbientTheme.Forest);
		ambientPlayer.nt(true);
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x0001E5D4 File Offset: 0x0001C7D4
	private void blr(bool a)
	{
		if (!this.hsx || this.hsy || !a)
		{
			return;
		}
		AmbientPlayer ambientPlayer = AmbientPlayer.kll;
		if (ambientPlayer == null)
		{
			return;
		}
		ambientPlayer.nu(AmbientTheme.City);
		ambientPlayer.nt(true);
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x0001E613 File Offset: 0x0001C813
	private void bls(bool a)
	{
		if (!this.hsx || this.hsy || !a)
		{
			return;
		}
		AmbientPlayer ambientPlayer = AmbientPlayer.kll;
		if (ambientPlayer == null)
		{
			return;
		}
		ambientPlayer.nt(false);
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x0001E639 File Offset: 0x0001C839
	private void blt(int a, bool b)
	{
		if (!this.hsx || this.hsy || !b)
		{
			return;
		}
		AmbientPlayer ambientPlayer = AmbientPlayer.kll;
		if (ambientPlayer == null)
		{
			return;
		}
		ambientPlayer.ob((AmbientCityTime)a);
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x0001E65F File Offset: 0x0001C85F
	private void blu(int a, bool b)
	{
		if (!this.hsx || this.hsy || !b)
		{
			return;
		}
		AmbientPlayer ambientPlayer = AmbientPlayer.kll;
		if (ambientPlayer == null)
		{
			return;
		}
		ambientPlayer.oa((AmbientWeather)a);
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x0001E685 File Offset: 0x0001C885
	private void blv(int a, bool b)
	{
		if (!this.hsx || this.hsy || !b)
		{
			return;
		}
		AmbientPlayer ambientPlayer = AmbientPlayer.kll;
		if (ambientPlayer == null)
		{
			return;
		}
		ambientPlayer.oc((AmbientBusyMode)a);
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x0001E6AC File Offset: 0x0001C8AC
	private void blw(bool a)
	{
		AmbientPlayer ambientPlayer = AmbientPlayer.kll;
		if (ambientPlayer == null)
		{
			return;
		}
		ambientPlayer.ny(a);
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x0001E6D0 File Offset: 0x0001C8D0
	private void blx(bool a)
	{
		AmbientPlayer ambientPlayer = AmbientPlayer.kll;
		if (ambientPlayer == null)
		{
			return;
		}
		ambientPlayer.nz(a);
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x0001E6F4 File Offset: 0x0001C8F4
	private void bly(int a)
	{
		AmbientPlayer ambientPlayer = AmbientPlayer.kll;
		if (ambientPlayer == null)
		{
			return;
		}
		if (a == 1)
		{
			ambientPlayer.nv(!ambientPlayer.hbi);
			return;
		}
		if (a == 2)
		{
			ambientPlayer.nw(!ambientPlayer.hbj);
		}
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x0001E738 File Offset: 0x0001C938
	private void blz(int a)
	{
		AmbientPlayer ambientPlayer = AmbientPlayer.kll;
		if (ambientPlayer == null)
		{
			return;
		}
		if (a == 0)
		{
			ambientPlayer.od(!ambientPlayer.hbq);
			return;
		}
		if (a == 1)
		{
			ambientPlayer.oe(!ambientPlayer.hbr);
		}
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x0001E77C File Offset: 0x0001C97C
	private void bma()
	{
		AmbientPlayer ambientPlayer = AmbientPlayer.kll;
		bool flag = ambientPlayer != null;
		if (this.titleLabel != null)
		{
			this.titleLabel.text = BgmLoc.Get(a.bfi(), a.bfj());
		}
		bool flag2 = flag && ambientPlayer.hbg;
		this.hsy = true;
		try
		{
			if (this.contentRoot != null && this.contentRoot.activeSelf != flag2)
			{
				this.contentRoot.SetActive(flag2);
			}
			if (this.themeContents != null)
			{
				for (int i = 0; i < this.themeContents.Length; i++)
				{
					if (!(this.themeContents[i] == null))
					{
						bool flag3 = flag2 && i == (int)ambientPlayer.hbh;
						if (this.themeContents[i].activeSelf != flag3)
						{
							this.themeContents[i].SetActive(flag3);
						}
					}
				}
			}
			Selectable[] componentsInChildren = base.GetComponentsInChildren<Selectable>(true);
			for (int j = 0; j < componentsInChildren.Length; j++)
			{
				componentsInChildren[j].interactable = flag;
			}
			this.bmd(this.toggleBirds, this.birdsLabel, flag && ambientPlayer.hbl, a.bfk(), a.bfl());
			this.bmd(this.toggleInsects, this.insectsLabel, flag && ambientPlayer.hbm, a.bfm(), a.bfn());
			bool flag4 = flag;
			if (AmbientPageController.bmb(this.weatherToggles, (int)(flag ? ambientPlayer.hbk : ((AmbientWeather)(-1))), flag4))
			{
				for (int k = 0; k < this.weatherToggles.Length; k++)
				{
					this.bmc(k, flag4);
				}
			}
			AmbientPageController.bmb(this.cityTimeToggles, (int)(flag ? ambientPlayer.hbo : ((AmbientCityTime)(-1))), flag);
			AmbientPageController.bmb(this.cityWeatherToggles, (int)(flag ? ambientPlayer.hbn : ((AmbientWeather)(-1))), flag);
			AmbientPageController.bmb(this.busyToggles, (int)(flag ? ambientPlayer.hbp : ((AmbientBusyMode)(-1))), flag);
			Toggle toggle = ((!flag2) ? this.toggleThemeNone : ((ambientPlayer.hbh == AmbientTheme.City) ? this.toggleThemeCity : this.toggleThemeForest));
			if (toggle != null && !toggle.isOn)
			{
				toggle.isOn = true;
			}
		}
		finally
		{
			this.hsy = false;
		}
		bool[] array = new bool[]
		{
			default(bool),
			flag && ambientPlayer.hbi,
			flag && ambientPlayer.hbj
		};
		this.bme(this.sceneButtons, this.sceneImages, this.sceneLabels, this.sceneDimOverlays, array, flag, AmbientPageController.bmf(ambientPlayer), AmbientPageController.bmg(ambientPlayer));
		int num = 0;
		if (this.sceneButtons != null && num < this.sceneButtons.Length && this.sceneButtons[num] != null)
		{
			this.sceneButtons[num].interactable = false;
		}
		bool[] array2 = new bool[]
		{
			flag && ambientPlayer.hbq,
			flag && ambientPlayer.hbr
		};
		this.bme(this.cityLayerButtons, this.cityLayerImages, this.cityLayerLabels, this.cityLayerDimOverlays, array2, flag, new string[]
		{
			a.bfo(),
			a.bfp()
		}, new string[]
		{
			a.bfq(),
			a.bfr()
		});
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x0001EAC4 File Offset: 0x0001CCC4
	private static bool bmb(Toggle[] a, int b, bool c)
	{
		if (a == null || a.Length == 0 || a[0] == null)
		{
			return false;
		}
		if (!a[0].gameObject.activeInHierarchy)
		{
			return false;
		}
		ToggleGroup toggleGroup = null;
		int num = 0;
		while (num < a.Length && toggleGroup == null)
		{
			if (a[num] != null)
			{
				toggleGroup = a[num].group;
			}
			num++;
		}
		for (int i = 0; i < a.Length; i++)
		{
			Toggle toggle = a[i];
			if (!(toggle == null))
			{
				toggle.interactable = c;
				if (c && i == b && !toggle.isOn)
				{
					toggle.isOn = true;
				}
			}
		}
		if (c && toggleGroup != null)
		{
			toggleGroup.allowSwitchOff = false;
		}
		return true;
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x0001EB70 File Offset: 0x0001CD70
	private void bmc(int a, bool b)
	{
		if (this.hsv == null || a < 0 || a >= this.hsv.Length)
		{
			return;
		}
		TMP_Text[] array = this.hsv[a];
		float[] array2 = this.hsw[a];
		if (array == null || array2 == null)
		{
			return;
		}
		for (int i = 0; i < array.Length; i++)
		{
			if (!(array[i] == null))
			{
				Color color = array[i].color;
				color.a = array2[i] * (b ? 1f : 0.45f);
				array[i].color = color;
			}
		}
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x0001EBF3 File Offset: 0x0001CDF3
	private void bmd(Toggle a, TMP_Text b, bool c, string d, string e)
	{
		if (a != null)
		{
			a.SetIsOnWithoutNotify(c);
		}
		if (b != null)
		{
			b.text = BgmLoc.Get(d, e);
		}
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x0001EC20 File Offset: 0x0001CE20
	private void bme(Button[] a, Image[] b, TMP_Text[] c, GameObject[] d, bool[] e, bool f, string[] g, string[] h)
	{
		if (a == null)
		{
			return;
		}
		for (int i = 0; i < a.Length; i++)
		{
			if (a[i] != null)
			{
				a[i].interactable = f;
			}
			bool flag = e != null && i < e.Length && e[i];
			bool flag2 = b != null && i < b.Length && b[i] != null && b[i].sprite != null;
			if (b != null && i < b.Length && b[i] != null)
			{
				Color color = (flag2 ? Color.white : (flag ? this.hst : this.hsu));
				if (!f)
				{
					color.a *= 0.45f;
				}
				b[i].color = color;
			}
			if (d != null && i < d.Length && d[i] != null)
			{
				bool flag3 = flag2 && !flag;
				if (d[i].activeSelf != flag3)
				{
					d[i].SetActive(flag3);
				}
			}
			if (c != null && i < c.Length && c[i] != null)
			{
				if (g != null && i < g.Length && !string.IsNullOrEmpty(g[i]))
				{
					string text = ((h != null && i < h.Length) ? h[i] : g[i]);
					c[i].text = BgmLoc.Get(g[i], text);
				}
				Color color2 = c[i].color;
				color2.a = (f ? 1f : 0.45f);
				c[i].color = color2;
			}
		}
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x0001EDA4 File Offset: 0x0001CFA4
	private static string[] bmf(AmbientPlayer a)
	{
		AmbientConfig ambientConfig = ((a != null) ? a.hbf : null);
		if (ambientConfig == null)
		{
			return null;
		}
		string[] array = new string[3];
		for (int i = 0; i < array.Length; i++)
		{
			AmbientSceneEntry ambientSceneEntry = ambientConfig.bij((AmbientScene)i);
			array[i] = ((ambientSceneEntry != null) ? ambientSceneEntry.nameKey : null);
		}
		return array;
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x0001EDFC File Offset: 0x0001CFFC
	private static string[] bmg(AmbientPlayer a)
	{
		AmbientConfig ambientConfig = ((a != null) ? a.hbf : null);
		if (ambientConfig == null)
		{
			return null;
		}
		string[] array = new string[3];
		for (int i = 0; i < array.Length; i++)
		{
			AmbientSceneEntry ambientSceneEntry = ambientConfig.bij((AmbientScene)i);
			array[i] = ((ambientSceneEntry != null) ? ambientSceneEntry.fallbackName : null);
		}
		return array;
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x0001EEAC File Offset: 0x0001D0AC
	[CompilerGenerated]
	private void bmh(BaseEventData a)
	{
		this.blo();
	}

	// Token: 0x040005AB RID: 1451
	private const string hsl = "UI_Setting_Ambient_Title";

	// Token: 0x040005AC RID: 1452
	private const string hsm = "UI_Setting_Ambient_Birds";

	// Token: 0x040005AD RID: 1453
	private const string hsn = "UI_Setting_Ambient_Insects";

	// Token: 0x040005AE RID: 1454
	private const string hso = "UI_Setting_Ambient_Park";

	// Token: 0x040005AF RID: 1455
	private const string hsp = "UI_Setting_Ambient_Cars";

	// Token: 0x040005B0 RID: 1456
	private const float hsq = 0.45f;

	// Token: 0x040005B1 RID: 1457
	private const int hsr = 0;

	// Token: 0x040005B2 RID: 1458
	private const int hss = 1;

	// Token: 0x040005B3 RID: 1459
	[SerializeField]
	private TMP_Text titleLabel;

	// Token: 0x040005B4 RID: 1460
	[SerializeField]
	private Slider sliderVolume;

	// Token: 0x040005B5 RID: 1461
	[SerializeField]
	private VolumeMuteButton muteButton;

	// Token: 0x040005B6 RID: 1462
	[SerializeField]
	private Toggle[] weatherToggles;

	// Token: 0x040005B7 RID: 1463
	[SerializeField]
	private Toggle toggleThemeForest;

	// Token: 0x040005B8 RID: 1464
	[SerializeField]
	private Toggle toggleThemeCity;

	// Token: 0x040005B9 RID: 1465
	[SerializeField]
	private Toggle toggleThemeNone;

	// Token: 0x040005BA RID: 1466
	[SerializeField]
	private GameObject contentRoot;

	// Token: 0x040005BB RID: 1467
	[SerializeField]
	private GameObject[] themeContents;

	// Token: 0x040005BC RID: 1468
	[SerializeField]
	private Button[] sceneButtons;

	// Token: 0x040005BD RID: 1469
	[SerializeField]
	private Image[] sceneImages;

	// Token: 0x040005BE RID: 1470
	[SerializeField]
	private TMP_Text[] sceneLabels;

	// Token: 0x040005BF RID: 1471
	[SerializeField]
	private GameObject[] sceneDimOverlays;

	// Token: 0x040005C0 RID: 1472
	[SerializeField]
	private Toggle toggleBirds;

	// Token: 0x040005C1 RID: 1473
	[SerializeField]
	private TMP_Text birdsLabel;

	// Token: 0x040005C2 RID: 1474
	[SerializeField]
	private Toggle toggleInsects;

	// Token: 0x040005C3 RID: 1475
	[SerializeField]
	private TMP_Text insectsLabel;

	// Token: 0x040005C4 RID: 1476
	[SerializeField]
	private Toggle[] cityTimeToggles;

	// Token: 0x040005C5 RID: 1477
	[SerializeField]
	private Toggle[] cityWeatherToggles;

	// Token: 0x040005C6 RID: 1478
	[SerializeField]
	private Toggle[] busyToggles;

	// Token: 0x040005C7 RID: 1479
	[SerializeField]
	private Button[] cityLayerButtons;

	// Token: 0x040005C8 RID: 1480
	[SerializeField]
	private Image[] cityLayerImages;

	// Token: 0x040005C9 RID: 1481
	[SerializeField]
	private TMP_Text[] cityLayerLabels;

	// Token: 0x040005CA RID: 1482
	[SerializeField]
	private GameObject[] cityLayerDimOverlays;

	// Token: 0x040005CB RID: 1483
	private Color hst = new Color32(240, 160, 80, byte.MaxValue);

	// Token: 0x040005CC RID: 1484
	private Color hsu = new Color32(246, 207, 168, byte.MaxValue);

	// Token: 0x040005CD RID: 1485
	private TMP_Text[][] hsv;

	// Token: 0x040005CE RID: 1486
	private float[][] hsw;

	// Token: 0x040005CF RID: 1487
	private bool hsx;

	// Token: 0x040005D0 RID: 1488
	private bool hsy;

	// Token: 0x0200007C RID: 124
	[CompilerGenerated]
	private sealed class cj
	{
		// Token: 0x06000585 RID: 1413 RVA: 0x0001EED3 File Offset: 0x0001D0D3
		internal void jjj()
		{
			this.hsf.bly(this.hse);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0001EED3 File Offset: 0x0001D0D3
		internal void kdv()
		{
			this.hsf.bly(this.hse);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0001EED3 File Offset: 0x0001D0D3
		internal void cwg()
		{
			this.hsf.bly(this.hse);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0001EED3 File Offset: 0x0001D0D3
		internal void blg()
		{
			this.hsf.bly(this.hse);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0001EED3 File Offset: 0x0001D0D3
		internal void gvt()
		{
			this.hsf.bly(this.hse);
		}

		// Token: 0x040005D3 RID: 1491
		public int hse;

		// Token: 0x040005D4 RID: 1492
		public AmbientPageController hsf;
	}

	// Token: 0x0200007D RID: 125
	[CompilerGenerated]
	private sealed class ck
	{
		// Token: 0x0600058A RID: 1418 RVA: 0x0001EEE6 File Offset: 0x0001D0E6
		internal void blh()
		{
			this.hsh.blz(this.hsg);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0001EEE6 File Offset: 0x0001D0E6
		internal void lbp()
		{
			this.hsh.blz(this.hsg);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0001EEE6 File Offset: 0x0001D0E6
		internal void caw()
		{
			this.hsh.blz(this.hsg);
		}

		// Token: 0x040005D5 RID: 1493
		public int hsg;

		// Token: 0x040005D6 RID: 1494
		public AmbientPageController hsh;
	}

	// Token: 0x0200007E RID: 126
	[CompilerGenerated]
	private sealed class cl
	{
		// Token: 0x040005D7 RID: 1495
		public UnityAction<int, bool> hsi;
	}

	// Token: 0x0200007F RID: 127
	[CompilerGenerated]
	private sealed class cm
	{
		// Token: 0x0600058F RID: 1423 RVA: 0x0001EEF9 File Offset: 0x0001D0F9
		internal void dny(bool a)
		{
			this.hsk.hsi(this.hsj, a);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0001EEF9 File Offset: 0x0001D0F9
		internal void bli(bool a)
		{
			this.hsk.hsi(this.hsj, a);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0001EEF9 File Offset: 0x0001D0F9
		internal void glf(bool a)
		{
			this.hsk.hsi(this.hsj, a);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0001EEF9 File Offset: 0x0001D0F9
		internal void cmg(bool a)
		{
			this.hsk.hsi(this.hsj, a);
		}

		// Token: 0x040005D8 RID: 1496
		public int hsj;

		// Token: 0x040005D9 RID: 1497
		public AmbientPageController.cl hsk;
	}
}
