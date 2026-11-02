using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using FMODUnity;
using Spine.Unity;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

// Token: 0x02000080 RID: 128
public sealed class BgmPanelController : MonoBehaviour
{
	// Token: 0x06000594 RID: 1428 RVA: 0x0001EF14 File Offset: 0x0001D114
	private void Awake()
	{
		this.htj = ((this.toggleBgm != null) ? this.toggleBgm.GetComponentInParent<ToggleTabVisuals>() : null);
		if (this.toggleBgm != null && this.pageBgm != null)
		{
			this.toggleBgm.onValueChanged.AddListener(new UnityAction<bool>(this.bni));
		}
		if (this.toggleWhiteNoise != null && this.pageWhiteNoise != null)
		{
			this.toggleWhiteNoise.onValueChanged.AddListener(new UnityAction<bool>(this.bnj));
		}
		if (this.sliderVolume != null)
		{
			this.sliderVolume.onValueChanged.AddListener(new UnityAction<float>(BgmPanelController.<>c.<>9.bmi));
			BgmPanelController.bmn(this.sliderVolume.gameObject, new UnityAction<BaseEventData>(this.bnk));
		}
		if (this.muteButton != null)
		{
			this.muteButton.hzh += this.bmr;
		}
		if (this.modeButton != null)
		{
			this.modeButton.onClick.AddListener(new UnityAction(this.bnh));
		}
		if (this.closeButton != null)
		{
			this.closeButton.onClick.AddListener(new UnityAction(this.Close));
		}
		if (this.draggableWindow != null)
		{
			if (this.draggableWindow.onPositionChanged == null)
			{
				this.draggableWindow.onPositionChanged = new UnityEvent<Vector2>();
			}
			this.draggableWindow.onPositionChanged.AddListener(new UnityAction<Vector2>(ch.bhi));
		}
		if (this.tipObject == null)
		{
			this.tipObject = global::UnityEngine.Object.FindObjectOfType<bb>();
		}
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x0001F0E8 File Offset: 0x0001D2E8
	private static void bmn(GameObject a, UnityAction<BaseEventData> b)
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

	// Token: 0x06000596 RID: 1430 RVA: 0x0001F134 File Offset: 0x0001D334
	private void OnEnable()
	{
		if (BgmPlayer.kmc != null)
		{
			BgmPlayer.kmc.hfx += this.bnf;
		}
		AudioManager.het += this.bmq;
		LocalizationSettings.SelectedLocaleChanged += this.bmo;
		eu.ijx += this.bmz;
		eu.ijy += this.bmz;
		if (this.sliderVolume != null)
		{
			float @float = PlayerPrefs.GetFloat(a.se(), 0.5f);
			if (!Mathf.Approximately(this.sliderVolume.value, @float))
			{
				this.sliderVolume.value = @float;
			}
		}
		Vector2 vector;
		if (ch.bhj(out vector))
		{
			((RectTransform)base.transform).anchoredPosition = this.bmp(vector);
		}
		bool flag = AmbientPlayer.kll != null && AmbientPlayer.kll.hbg;
		if (this.toggleBgm != null)
		{
			this.toggleBgm.SetIsOnWithoutNotify(!flag);
		}
		if (this.toggleWhiteNoise != null)
		{
			this.toggleWhiteNoise.SetIsOnWithoutNotify(flag);
		}
		if (this.pageBgm != null)
		{
			this.pageBgm.SetActive(!flag);
		}
		if (this.pageWhiteNoise != null)
		{
			this.pageWhiteNoise.SetActive(flag);
		}
		if (this.htj != null)
		{
			this.htj.bns();
		}
		this.bnb();
		if (BgmPlayer.kmc != null)
		{
			BgmPlayer.kmc.sn();
		}
		this.bnd();
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x0001F2CC File Offset: 0x0001D4CC
	private void OnDisable()
	{
		if (BgmPlayer.kmc != null)
		{
			BgmPlayer.kmc.hfx -= this.bnf;
		}
		AudioManager.het -= this.bmq;
		LocalizationSettings.SelectedLocaleChanged -= this.bmo;
		eu.ijx -= this.bmz;
		eu.ijy -= this.bmz;
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x0001F340 File Offset: 0x0001D540
	private void bmo(Locale a)
	{
		this.bnd();
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x0001F348 File Offset: 0x0001D548
	private Vector2 bmp(Vector2 a)
	{
		RectTransform rectTransform = base.transform as RectTransform;
		RectTransform rectTransform2 = ((rectTransform != null) ? (rectTransform.parent as RectTransform) : null);
		if (rectTransform == null || rectTransform2 == null)
		{
			return a;
		}
		Rect rect = rectTransform2.rect;
		float num = rect.width * 0.5f;
		float num2 = rect.height * 0.5f;
		Rect rect2 = rectTransform.rect;
		float num3 = -num + 40f - rect2.xMin;
		float num4 = num - 40f - rect2.xMax;
		float num5 = -num2 + 40f - rect2.yMin;
		float num6 = num2 - 40f - rect2.yMax;
		if (num3 > num4)
		{
			num4 = (num3 = (num3 + num4) * 0.5f);
		}
		if (num5 > num6)
		{
			num6 = (num5 = (num5 + num6) * 0.5f);
		}
		a.x = Mathf.Clamp(a.x, num3, num4);
		a.y = Mathf.Clamp(a.y, num5, num6);
		return a;
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x0001F455 File Offset: 0x0001D655
	private void bmq(float a)
	{
		if (this.sliderVolume != null && !Mathf.Approximately(this.sliderVolume.value, a))
		{
			this.sliderVolume.value = a;
		}
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x0001F484 File Offset: 0x0001D684
	private void bmr()
	{
		if (this.sliderVolume == null)
		{
			return;
		}
		PlayerPrefs.SetFloat(a.se(), this.sliderVolume.value);
		PlayerPrefs.Save();
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x0001F4AF File Offset: 0x0001D6AF
	private void OnApplicationFocus(bool focus)
	{
		if (focus && base.isActiveAndEnabled)
		{
			this.bnc();
		}
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x0001F4C4 File Offset: 0x0001D6C4
	public void Open()
	{
		base.gameObject.SetActive(true);
		if (!this.openSound.IsNull && AudioManager.klw != null)
		{
			AudioManager.klw.qw(this.openSound, float3.zero, 1f);
		}
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x0001F517 File Offset: 0x0001D717
	public void Close()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x0600059F RID: 1439 RVA: 0x0001F525 File Offset: 0x0001D725
	public bool kpn
	{
		get
		{
			return this.draggableWindow != null && this.draggableWindow.ich;
		}
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x0001F544 File Offset: 0x0001D744
	public void bmt()
	{
		cx cx = cx.kpw;
		if (cx == null)
		{
			this.bmv();
			return;
		}
		if (this.hti != null)
		{
			cx.StopCoroutine(this.hti);
		}
		this.hti = cx.StartCoroutine(this.bmu());
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x0001F58D File Offset: 0x0001D78D
	private IEnumerator bmu()
	{
		yield return null;
		yield return null;
		this.hti = null;
		if (this == null)
		{
			yield break;
		}
		this.bmv();
		yield break;
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x0001F59C File Offset: 0x0001D79C
	private void bmv()
	{
		RectTransform rectTransform = base.transform as RectTransform;
		RectTransform rectTransform2 = ((rectTransform != null) ? (rectTransform.parent as RectTransform) : null);
		if (rectTransform == null || rectTransform2 == null)
		{
			return;
		}
		Rect rect = rectTransform.rect;
		Vector2 vector;
		Vector2 vector2;
		if (BgmPanelController.bmw(rectTransform2, out vector))
		{
			vector2 = new Vector2(vector.x - rect.center.x, vector.y + 16f - rect.yMin);
		}
		else
		{
			vector2 = new Vector2(rectTransform2.rect.center.x - rect.center.x, rectTransform2.rect.yMax);
		}
		Vector2 vector3 = (rectTransform.anchorMin + rectTransform.anchorMax) * 0.5f;
		Vector2 vector4 = new Vector2((vector3.x - rectTransform2.pivot.x) * rectTransform2.rect.width, (vector3.y - rectTransform2.pivot.y) * rectTransform2.rect.height);
		Vector2 vector5 = this.bmp(vector2 - vector4);
		rectTransform.anchoredPosition = vector5;
		ch.bhi(vector5);
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x0001F6E4 File Offset: 0x0001D8E4
	private static bool bmw(RectTransform a, out Vector2 b)
	{
		b = default(Vector2);
		if (bq.hlz)
		{
			return false;
		}
		Bounds bounds;
		Transform transform;
		if (!BgmPanelController.bmx(out bounds, out transform))
		{
			return false;
		}
		float num = bounds.center.x;
		Transform transform2 = BgmPanelController.bmy(transform);
		if (transform2 != null)
		{
			num = 2f * transform2.position.x - num;
		}
		Canvas componentInParent = a.GetComponentInParent<Canvas>();
		Canvas canvas = ((componentInParent != null) ? componentInParent.rootCanvas : null);
		Camera camera = ((canvas != null && canvas.renderMode != RenderMode.ScreenSpaceOverlay) ? canvas.worldCamera : null);
		Camera camera2 = ((camera != null) ? camera : Camera.main);
		if (camera2 == null)
		{
			return false;
		}
		Vector3 vector = new Vector3(num, bounds.max.y, bounds.center.z);
		Vector2 vector2 = camera2.WorldToScreenPoint(vector);
		return RectTransformUtility.ScreenPointToLocalPointInRectangle(a, vector2, camera, out b);
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x0001F7D8 File Offset: 0x0001D9D8
	private static bool bmx(out Bounds a, out Transform b)
	{
		a = default(Bounds);
		b = null;
		if (bq.hly == 0)
		{
			SkeletonAnimation skeletonAnimation = ((GirlController.kok != null) ? GirlController.kok.skeletonAnimation : null);
			if (skeletonAnimation == null || !skeletonAnimation.gameObject.activeInHierarchy)
			{
				return false;
			}
			if (!gh.drc(skeletonAnimation, out a))
			{
				return false;
			}
			b = skeletonAnimation.transform;
			return true;
		}
		else
		{
			r r = r.kmi;
			if (r == null)
			{
				return false;
			}
			SkeletonAnimation skeletonAnimation2 = r.skeletonAnimation;
			if (skeletonAnimation2 != null && skeletonAnimation2.gameObject.activeInHierarchy && gh.drc(skeletonAnimation2, out a))
			{
				b = skeletonAnimation2.transform;
				return true;
			}
			SpriteRenderer imageSpriteRenderer = r.imageSpriteRenderer;
			if (imageSpriteRenderer != null && imageSpriteRenderer.gameObject.activeInHierarchy && imageSpriteRenderer.sprite != null)
			{
				a = imageSpriteRenderer.bounds;
				b = imageSpriteRenderer.transform;
				return a.size.x > 0.001f && a.size.y > 0.001f;
			}
			return false;
		}
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x0001F8E8 File Offset: 0x0001DAE8
	private static Transform bmy(Transform a)
	{
		Transform transform = null;
		Transform transform2 = ((a != null) ? a.parent : null);
		while (transform2 != null)
		{
			if (transform2.localScale.x < 0f)
			{
				transform = transform2;
			}
			transform2 = transform2.parent;
		}
		return transform;
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x0001F931 File Offset: 0x0001DB31
	private void Update()
	{
		if (!Input.GetMouseButtonDown(0) && !Input.GetMouseButtonDown(1))
		{
			return;
		}
		this.bna();
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x0001F94A File Offset: 0x0001DB4A
	private void bmz()
	{
		if (this.hth == Time.frameCount)
		{
			return;
		}
		this.bna();
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x0001F960 File Offset: 0x0001DB60
	private void bna()
	{
		if (this.draggableWindow != null && this.draggableWindow.ich)
		{
			return;
		}
		this.hth = Time.frameCount;
		Vector2 vector = Input.mousePosition;
		if (vector.x < 0f || vector.x > (float)Screen.width || vector.y < 0f || vector.y > (float)Screen.height)
		{
			this.Close();
			return;
		}
		if (dx.cgm(base.transform as RectTransform, vector))
		{
			return;
		}
		SettingPanel settingPanel = SettingPanel.kqq;
		if (settingPanel != null && settingPanel.gameObject.activeSelf)
		{
			if (settingPanel.kqr)
			{
				return;
			}
			if (dx.cgl(settingPanel.transform, vector))
			{
				return;
			}
		}
		if (this.htg == null)
		{
			cx cx = global::UnityEngine.Object.FindObjectOfType<cx>();
			if (cx != null && cx.btnBgm != null)
			{
				this.htg = cx.btnBgm.transform as RectTransform;
			}
		}
		if (dx.cgm(this.htg, vector))
		{
			return;
		}
		this.Close();
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x0001FA7C File Offset: 0x0001DC7C
	private void bnb()
	{
		BgmPlayer bgmPlayer = BgmPlayer.kmc;
		BgmAlbumConfig bgmAlbumConfig = ((bgmPlayer != null) ? bgmPlayer.hfu : null);
		if (bgmAlbumConfig == null)
		{
			return;
		}
		if (l.sx(bgmAlbumConfig, bgmAlbumConfig.bil(bgmPlayer.hfv)))
		{
			int num = l.sy(bgmAlbumConfig);
			if (num >= 0)
			{
				bgmPlayer.sl(num, l.kme);
			}
		}
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x0001FAD8 File Offset: 0x0001DCD8
	public void bnc()
	{
		this.bnb();
		BgmPlayer bgmPlayer = BgmPlayer.kmc;
		if (bgmPlayer != null && bgmPlayer.hfu != null)
		{
			bgmPlayer.sm();
		}
		this.bnd();
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x0001FB14 File Offset: 0x0001DD14
	private void bnd()
	{
		foreach (BgmTrackRow bgmTrackRow in this.htf)
		{
			if (bgmTrackRow != null)
			{
				global::UnityEngine.Object.Destroy(bgmTrackRow.gameObject);
			}
		}
		this.htf.Clear();
		BgmPlayer bgmPlayer = BgmPlayer.kmc;
		BgmAlbumConfig bgmAlbumConfig = ((bgmPlayer != null) ? bgmPlayer.hfu : null);
		if (bgmAlbumConfig == null || bgmAlbumConfig.kow == 0)
		{
			Debug.LogWarning(a.bfs());
			this.bnf();
			return;
		}
		if (this.rowTemplate == null || this.rowContainer == null)
		{
			Debug.LogWarning(a.bft());
			return;
		}
		string text = string.Format(a.bfu(), bgmAlbumConfig.dlcAppId);
		string text2 = BgmLoc.Get(a.bfv(), a.bfw()) + a.bfx() + BgmLoc.Get(a.bfy(), a.bfz());
		for (int i = 0; i < bgmAlbumConfig.kow; i++)
		{
			BgmTrack bgmTrack = bgmAlbumConfig.bil(i);
			if (bgmTrack != null)
			{
				BgmTrackRow bgmTrackRow2 = global::UnityEngine.Object.Instantiate<BgmTrackRow>(this.rowTemplate, this.rowContainer);
				bgmTrackRow2.gameObject.SetActive(true);
				bgmTrackRow2.bnq(i, bgmTrack, l.sx(bgmAlbumConfig, bgmTrack), i == bgmPlayer.hfv, new Action<int>(this.bne), text, this.tipObject, text2);
				this.htf.Add(bgmTrackRow2);
			}
		}
		this.bnf();
	}

	// Token: 0x060005AC RID: 1452 RVA: 0x0001FCAC File Offset: 0x0001DEAC
	private void bne(int a)
	{
		if (BgmPlayer.kmc == null)
		{
			return;
		}
		BgmPlayer.kmc.sk(a);
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x0001FCC8 File Offset: 0x0001DEC8
	private void bnf()
	{
		BgmPlayer bgmPlayer = BgmPlayer.kmc;
		if (this.modeLabel != null)
		{
			this.modeLabel.text = BgmPanelController.bng((bgmPlayer != null) ? bgmPlayer.hfw : BgmPlayMode.Single);
		}
		BgmAlbumConfig bgmAlbumConfig = ((bgmPlayer != null) ? bgmPlayer.hfu : null);
		if (bgmAlbumConfig == null)
		{
			return;
		}
		int num = 0;
		while (num < this.htf.Count && num < bgmAlbumConfig.kow)
		{
			BgmTrack bgmTrack = bgmAlbumConfig.bil(num);
			if (!(this.htf[num] == null) && bgmTrack != null)
			{
				this.htf[num].bnq(num, bgmTrack, l.sx(bgmAlbumConfig, bgmTrack), num == bgmPlayer.hfv, new Action<int>(this.bne), string.Format(a.bfu(), bgmAlbumConfig.dlcAppId), this.tipObject, BgmLoc.Get(a.bfv(), a.bfw()) + a.bfx() + BgmLoc.Get(a.bfy(), a.bfz()));
			}
			num++;
		}
	}

	// Token: 0x060005AE RID: 1454 RVA: 0x0001FDDE File Offset: 0x0001DFDE
	private static string bng(BgmPlayMode a)
	{
		if (a == BgmPlayMode.Sequential)
		{
			return BgmLoc.Get(a.bga(), a.bgb());
		}
		if (a != BgmPlayMode.Shuffle)
		{
			return BgmLoc.Get(a.bge(), a.bgf());
		}
		return BgmLoc.Get(a.bgc(), a.bgd());
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x0001FE1C File Offset: 0x0001E01C
	private void bnh()
	{
		BgmPlayer bgmPlayer = BgmPlayer.kmc;
		if (bgmPlayer == null)
		{
			return;
		}
		bgmPlayer.sq((bgmPlayer.hfw + 1) % (BgmPlayMode)3);
		this.bnf();
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x0001FE69 File Offset: 0x0001E069
	[CompilerGenerated]
	private void bni(bool a)
	{
		this.pageBgm.SetActive(a);
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x0001FE77 File Offset: 0x0001E077
	[CompilerGenerated]
	private void bnj(bool a)
	{
		this.pageWhiteNoise.SetActive(a);
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x0001FE85 File Offset: 0x0001E085
	[CompilerGenerated]
	private void bnk(BaseEventData a)
	{
		this.bmr();
	}

	// Token: 0x040005DA RID: 1498
	private const string htc = "steam://openurl/https://store.steampowered.com/app/{0}?utm_source=bongowaifu&utm_medium=ingame&utm_campaign=bgm_album";

	// Token: 0x040005DB RID: 1499
	private const float htd = 40f;

	// Token: 0x040005DC RID: 1500
	private const float hte = 16f;

	// Token: 0x040005DD RID: 1501
	[SerializeField]
	private DraggableWindow draggableWindow;

	// Token: 0x040005DE RID: 1502
	[SerializeField]
	private Toggle toggleBgm;

	// Token: 0x040005DF RID: 1503
	[SerializeField]
	private Toggle toggleWhiteNoise;

	// Token: 0x040005E0 RID: 1504
	[SerializeField]
	private Button closeButton;

	// Token: 0x040005E1 RID: 1505
	[SerializeField]
	private EventReference openSound;

	// Token: 0x040005E2 RID: 1506
	[SerializeField]
	private GameObject pageBgm;

	// Token: 0x040005E3 RID: 1507
	[SerializeField]
	private GameObject pageWhiteNoise;

	// Token: 0x040005E4 RID: 1508
	[SerializeField]
	private Slider sliderVolume;

	// Token: 0x040005E5 RID: 1509
	[SerializeField]
	private VolumeMuteButton muteButton;

	// Token: 0x040005E6 RID: 1510
	[SerializeField]
	private BgmTrackRow rowTemplate;

	// Token: 0x040005E7 RID: 1511
	[SerializeField]
	private Transform rowContainer;

	// Token: 0x040005E8 RID: 1512
	[SerializeField]
	private Button modeButton;

	// Token: 0x040005E9 RID: 1513
	[SerializeField]
	private TMP_Text modeLabel;

	// Token: 0x040005EA RID: 1514
	[SerializeField]
	private bb tipObject;

	// Token: 0x040005EB RID: 1515
	private readonly List<BgmTrackRow> htf = new List<BgmTrackRow>();

	// Token: 0x040005EC RID: 1516
	private RectTransform htg;

	// Token: 0x040005ED RID: 1517
	private int hth = -1;

	// Token: 0x040005EE RID: 1518
	private Coroutine hti;

	// Token: 0x040005EF RID: 1519
	private ToggleTabVisuals htj;
}
