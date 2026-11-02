using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using BongoWaifu.Crafting;
using RamenCat;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.UI;

// Token: 0x020000A9 RID: 169
[DefaultExecutionOrder(50)]
public class SettingPanel : MonoBehaviour
{
	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00036207 File Offset: 0x00034407
	public static SettingPanel kqq
	{
		get
		{
			return SettingPanel.hyz;
		}
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0003620E File Offset: 0x0003440E
	public bool kqr
	{
		get
		{
			return this.draggableWindow != null && this.draggableWindow.ich;
		}
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x060008E5 RID: 2277 RVA: 0x0003622B File Offset: 0x0003442B
	public static bool kqs
	{
		get
		{
			return SteamManager.krd && bq.hmg;
		}
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x0003623B File Offset: 0x0003443B
	private void Awake()
	{
		SettingPanel.hyz = this;
		this.hyy = base.transform as RectTransform;
	}

	// Token: 0x060008E7 RID: 2279 RVA: 0x00036254 File Offset: 0x00034454
	private void Start()
	{
		Vector2 vector;
		if (this.hyy != null && ch.bhh(out vector))
		{
			this.hyy.anchoredPosition = this.cax(vector);
		}
		if (this.draggableWindow != null)
		{
			if (this.draggableWindow.onPositionChanged == null)
			{
				this.draggableWindow.onPositionChanged = new UnityEvent<Vector2>();
			}
			this.draggableWindow.onPositionChanged.AddListener(new UnityAction<Vector2>(this.cav));
		}
		this.btnClose.onClick.AddListener(new UnityAction(this.Close));
		this.toggle_Dick.onValueChanged.AddListener(new UnityAction<bool>(this.cbd));
		this.toggle_Hair.onValueChanged.AddListener(new UnityAction<bool>(this.cbe));
		this.toggle_Top.onValueChanged.AddListener(new UnityAction<bool>(this.cbf));
		this.toggle_Bottom.onValueChanged.AddListener(new UnityAction<bool>(this.cbg));
		this.toggle_Underwear.onValueChanged.AddListener(new UnityAction<bool>(this.cbh));
		this.toggle_Socks.onValueChanged.AddListener(new UnityAction<bool>(this.cbi));
		this.toggle_Shoes.onValueChanged.AddListener(new UnityAction<bool>(this.cbj));
		this.toggle_Clothe.onValueChanged.AddListener(new UnityAction<bool>(this.cbk));
		this.toggle_ClothingSet.onValueChanged.AddListener(new UnityAction<bool>(this.cbl));
		if (this.toggle_Craft != null)
		{
			this.toggle_Craft.onValueChanged.AddListener(new UnityAction<bool>(this.cbm));
		}
		this.toggle_Setting.onValueChanged.AddListener(new UnityAction<bool>(this.cbn));
		this.toggle_Info.onValueChanged.AddListener(new UnityAction<bool>(this.cbo));
		if (this.toggle_Multiplayer != null)
		{
			this.toggle_Multiplayer.onValueChanged.AddListener(new UnityAction<bool>(this.cbp));
		}
		if (this.toggle_Gallery != null)
		{
			this.toggle_Gallery.onValueChanged.AddListener(new UnityAction<bool>(this.cbq));
		}
		if (this.infoPanel == null && this.obj_Info != null)
		{
			this.infoPanel = this.obj_Info.GetComponent<InfoPanel>();
		}
		if (this.infoPanel != null)
		{
			this.infoPanel.bsz();
		}
		this.Open();
		this.Close();
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x000364F1 File Offset: 0x000346F1
	public void cal()
	{
		this.settingController.bvb();
	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x000364FE File Offset: 0x000346FE
	public void cam(RectTransform a)
	{
		if (a == null)
		{
			Debug.LogWarning(a.coh());
			this.Open();
			return;
		}
		this.can(a.position);
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x0003652C File Offset: 0x0003472C
	public void can(Vector2 a)
	{
		if (this.hyy == null)
		{
			this.hyy = base.transform as RectTransform;
		}
		if (this.hyy != null)
		{
			Vector3 position = this.hyy.position;
			position.x = a.x;
			position.y = a.y;
			this.hyy.position = position;
		}
		this.hzb = true;
		this.Open();
	}

	// Token: 0x060008EB RID: 2283 RVA: 0x000365A8 File Offset: 0x000347A8
	public void Open()
	{
		base.gameObject.SetActive(true);
		if (this.obj_Gallery != null)
		{
			this.obj_Gallery.SetActive(false);
		}
		if (this.obj_Multiplayer != null)
		{
			this.obj_Multiplayer.SetActive(false);
		}
		bool flag = this.cao();
		if (SettingPanel.kqs)
		{
			this.toggle_Clothe.isOn = true;
			this.toggle_Clothe.onValueChanged.Invoke(true);
			this.toggle_Dick.isOn = true;
			this.toggle_Dick.onValueChanged.Invoke(true);
		}
		else if (!flag)
		{
			this.toggle_Setting.isOn = true;
			this.toggle_Setting.onValueChanged.Invoke(true);
		}
		if (this.dotTab != null)
		{
			this.dotTab.ux();
		}
		this.cap();
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x00036680 File Offset: 0x00034880
	public bool cao()
	{
		bool flag = SettingPanel.kqs;
		bool flag2 = false;
		if (this.toggle_Clothe != null)
		{
			if (!flag && this.toggle_Clothe.isOn)
			{
				this.toggle_Clothe.isOn = false;
			}
			this.toggle_Clothe.gameObject.SetActive(flag);
		}
		if (this.toggle_ClothingSet != null)
		{
			if (!flag && this.toggle_ClothingSet.isOn)
			{
				this.toggle_ClothingSet.isOn = false;
			}
			this.toggle_ClothingSet.gameObject.SetActive(flag);
		}
		if (this.toggle_Craft != null)
		{
			if (!flag && this.toggle_Craft.isOn)
			{
				this.toggle_Craft.isOn = false;
			}
			this.toggle_Craft.gameObject.SetActive(flag);
		}
		if (this.toggle_Gallery != null)
		{
			if (!flag && this.toggle_Gallery.isOn)
			{
				this.toggle_Gallery.isOn = false;
			}
			this.toggle_Gallery.gameObject.SetActive(flag);
		}
		if (this.toggle_Multiplayer != null)
		{
			if (!flag && this.toggle_Multiplayer.isOn)
			{
				this.toggle_Multiplayer.isOn = false;
			}
			this.toggle_Multiplayer.gameObject.SetActive(flag);
		}
		if (!flag && ((this.obj_Clothe != null && this.obj_Clothe.activeSelf) || (this.obj_ClothingSet != null && this.obj_ClothingSet.activeSelf) || (this.obj_Craft != null && this.obj_Craft.activeSelf) || (this.obj_Gallery != null && this.obj_Gallery.activeSelf) || (this.obj_Multiplayer != null && this.obj_Multiplayer.activeSelf)) && this.toggle_Setting != null)
		{
			this.toggle_Setting.isOn = true;
			this.toggle_Setting.onValueChanged.Invoke(true);
			flag2 = true;
		}
		if (this.settingController != null)
		{
			this.settingController.bvc();
		}
		this.hza = flag;
		return flag2;
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x0003689A File Offset: 0x00034A9A
	private void Update()
	{
		if (this.hza != SettingPanel.kqs)
		{
			this.cao();
		}
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x000368B0 File Offset: 0x00034AB0
	public void Close()
	{
		base.gameObject.SetActive(false);
		SettingPanel.car();
	}

	// Token: 0x060008EF RID: 2287 RVA: 0x000368C4 File Offset: 0x00034AC4
	public void cap()
	{
		if (bq.hlf == null)
		{
			return;
		}
		List<int> newItemDefIds = bq.hlf.playerSaveData.newItemDefIds;
		bool flag = false;
		flag |= this.caq(this.dotToggleDick, CLOTHE_TYPE.Dick, newItemDefIds);
		flag |= this.caq(this.dotToggleHair, CLOTHE_TYPE.Hair, newItemDefIds);
		flag |= this.caq(this.dotToggleTop, CLOTHE_TYPE.Top, newItemDefIds);
		flag |= this.caq(this.dotToggleBottom, CLOTHE_TYPE.Bottom, newItemDefIds);
		flag |= this.caq(this.dotToggleUnderwear, CLOTHE_TYPE.Underwear, newItemDefIds);
		flag |= this.caq(this.dotToggleSocks, CLOTHE_TYPE.Socks, newItemDefIds);
		flag |= this.caq(this.dotToggleShoes, CLOTHE_TYPE.Shoes, newItemDefIds);
		if (this.dotToggleClothe != null)
		{
			this.dotToggleClothe.SetActive(flag);
		}
		SettingPanel.car();
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x00036988 File Offset: 0x00034B88
	private bool caq(GameObject a, CLOTHE_TYPE b, List<int> c)
	{
		if (a == null)
		{
			return false;
		}
		if (c != null && c.Count > 0)
		{
			List<SpineSkinData> list = bq.hle.bkl(b);
			if (list != null)
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (c.Contains(list[i].kox))
					{
						a.SetActive(true);
						return true;
					}
				}
			}
		}
		a.SetActive(false);
		return false;
	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x000369F1 File Offset: 0x00034BF1
	private static void car()
	{
		if (cx.kpw != null)
		{
			cx.kpw.brh();
		}
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x00036A0C File Offset: 0x00034C0C
	public void cas()
	{
		if (this.toggle_Clothe.isOn && this.obj_Clothe.activeInHierarchy)
		{
			ClotheItemController.kpt.bpi(this.nowSelect);
			if (bq.knd)
			{
				Debug.Log(a.coi());
			}
		}
		SettingPanel.car();
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x00036A5C File Offset: 0x00034C5C
	private void OnEnable()
	{
		this.cat();
		if (SteamInventoryManager.iid != null)
		{
			SteamInventoryManager.iid.iie += this.cba;
		}
		if (du.iah != null)
		{
			du.iae += this.cbc;
		}
		fa.iml += this.cau;
		this.cau();
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x00036AC8 File Offset: 0x00034CC8
	private void cat()
	{
		if (this.hyy == null)
		{
			return;
		}
		Vector2 anchoredPosition = this.hyy.anchoredPosition;
		Vector2 vector = this.cax(anchoredPosition);
		bool flag = (vector - anchoredPosition).sqrMagnitude > 0.01f;
		if (flag)
		{
			this.hyy.anchoredPosition = vector;
		}
		if (this.hzb)
		{
			this.hzb = false;
			if (flag)
			{
				Debug.Log(string.Format(a.coj(), anchoredPosition, vector));
			}
			return;
		}
		if (!flag)
		{
			return;
		}
		ch.bhg(vector);
		Debug.Log(string.Format(a.cok(), anchoredPosition, vector));
	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x00036B74 File Offset: 0x00034D74
	private void OnDisable()
	{
		if (SteamInventoryManager.iid != null)
		{
			SteamInventoryManager.iid.iie -= this.cba;
		}
		du.iae -= this.cbc;
		fa.iml -= this.cau;
		this.hzc = false;
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x00036BD0 File Offset: 0x00034DD0
	private void cau()
	{
		if (this.dotToggleSetting == null)
		{
			return;
		}
		fa fa = fa.imk;
		bool flag = fa != null && fa.imm == fa.CheckStatus.UpdateAvailable;
		this.dotToggleSetting.un(flag);
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x00036C14 File Offset: 0x00034E14
	private void OnDestroy()
	{
		if (this.draggableWindow != null && this.draggableWindow.onPositionChanged != null)
		{
			this.draggableWindow.onPositionChanged.RemoveListener(new UnityAction<Vector2>(this.cav));
		}
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x00036C4D File Offset: 0x00034E4D
	private void cav(Vector2 a)
	{
		ch.bhg(a);
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x00036C55 File Offset: 0x00034E55
	public void caw()
	{
		if (this.draggableWindow != null)
		{
			this.draggableWindow.cgk();
		}
	}

	// Token: 0x060008FA RID: 2298 RVA: 0x00036C70 File Offset: 0x00034E70
	private Vector2 cax(Vector2 a)
	{
		if (this.hyy == null)
		{
			return a;
		}
		RectTransform rectTransform = this.hyy.parent as RectTransform;
		if (rectTransform == null)
		{
			return a;
		}
		Rect rect = rectTransform.rect;
		float num = rect.width * 0.5f;
		float num2 = rect.height * 0.5f;
		Rect rect2 = this.hyy.rect;
		float num3 = this.cay();
		float num4 = rect2.xMin * num3;
		float num5 = rect2.xMax * num3;
		float num6 = rect2.yMin * num3;
		float num7 = rect2.yMax * num3;
		float num8 = -num + 40f - num4;
		float num9 = num - 40f - num5;
		float num10 = -num2 + 40f - num6;
		float num11 = num2 - 40f - num7;
		if (num8 > num9)
		{
			num9 = (num8 = (num8 + num9) * 0.5f);
		}
		if (num10 > num11)
		{
			num11 = (num10 = (num10 + num11) * 0.5f);
		}
		a.x = Mathf.Clamp(a.x, num8, num9);
		a.y = Mathf.Clamp(a.y, num10, num11);
		return a;
	}

	// Token: 0x060008FB RID: 2299 RVA: 0x00036D9C File Offset: 0x00034F9C
	private float cay()
	{
		float num = 1f;
		int childCount = base.transform.childCount;
		for (int i = 0; i < childCount; i++)
		{
			Vector3 localScale = base.transform.GetChild(i).localScale;
			float num2 = Mathf.Max(localScale.x, localScale.y);
			if (num2 > num)
			{
				num = num2;
			}
		}
		return num;
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x00036DF5 File Offset: 0x00034FF5
	public void caz()
	{
		this.cat();
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x00036E00 File Offset: 0x00035000
	private void cba(IReadOnlyList<ItemData> a)
	{
		if (SteamInventoryManager.iid != null && SteamInventoryManager.iid.ksp)
		{
			return;
		}
		if (du.iah != null && !du.iah.iai)
		{
			Debug.LogWarning(a.col());
			this.hzc = true;
			return;
		}
		this.hze.Clear();
		for (int i = 0; i < a.Count; i++)
		{
			ItemData itemData = a[i];
			if (itemData.quantity > 0U)
			{
				this.hze.Add(new ValueTuple<int, uint>(itemData.defID, itemData.quantity));
			}
		}
		if (this.hzf && this.hze.SetEquals(this.hzd))
		{
			return;
		}
		this.cas();
		SettingPanel.car();
		if (GalleryItemController.kpy != null)
		{
			GalleryItemController.kpy.bsa();
		}
		this.hzd.Clear();
		foreach (ValueTuple<int, uint> valueTuple in this.hze)
		{
			this.hzd.Add(valueTuple);
		}
		this.hzf = true;
	}

	// Token: 0x060008FE RID: 2302 RVA: 0x00036F38 File Offset: 0x00035138
	public void cbb(int a, int b)
	{
		PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		playerSaveData.DickUse = 0;
		playerSaveData.HairUse = 0;
		playerSaveData.TopUse = 0;
		playerSaveData.BottomUse = 0;
		playerSaveData.UnderwearUse = 0;
		playerSaveData.SocksUse = 0;
		playerSaveData.ShoesUse = 0;
		playerSaveData.SkinToneUse = 0;
		playerSaveData.IntimatePartsUse = 0;
		playerSaveData.PubicAndGenitalUse = 0;
		playerSaveData.desiredDickUse = 0;
		playerSaveData.desiredHairUse = 0;
		playerSaveData.desiredTopUse = 0;
		playerSaveData.desiredBottomUse = 0;
		playerSaveData.desiredUnderwearUse = 0;
		playerSaveData.desiredSocksUse = 0;
		playerSaveData.desiredShoesUse = 0;
		playerSaveData.desiredSkinToneUse = 0;
		playerSaveData.desiredIntimatePartsUse = 0;
		playerSaveData.desiredPubicAndGenitalUse = 0;
		playerSaveData.lastVerifiedDickUse = 0;
		playerSaveData.lastVerifiedHairUse = 0;
		playerSaveData.lastVerifiedTopUse = 0;
		playerSaveData.lastVerifiedBottomUse = 0;
		playerSaveData.lastVerifiedUnderwearUse = 0;
		playerSaveData.lastVerifiedSocksUse = 0;
		playerSaveData.lastVerifiedShoesUse = 0;
		playerSaveData.lastVerifiedSkinToneUse = 0;
		playerSaveData.lastVerifiedIntimatePartsUse = 0;
		playerSaveData.lastVerifiedPubicAndGenitalUse = 0;
		bq.bao();
		playerSaveData.knownItemDefIds.Clear();
		playerSaveData.newItemDefIds.Clear();
		playerSaveData.dismissedDots.Clear();
		playerSaveData.hasInitializedKnownItems = false;
		if (bq.hle != null)
		{
			bq.hle.bkt();
		}
		ci.Save(null);
		this.cas();
		if (this.clothingSetItemController != null)
		{
			this.clothingSetItemController.bqi();
		}
		Debug.Log(string.Format(a.com(), a, b));
		if (ModalDialogManager.kri)
		{
			StringTable table = LocalizationSettings.StringDatabase.GetTable(a.rh(), null);
			string text;
			if (table == null)
			{
				text = null;
			}
			else
			{
				StringTableEntry entry = table.GetEntry(a.con());
				text = ((entry != null) ? entry.GetLocalizedString() : null);
			}
			string text2 = text ?? a.coo();
			string text3;
			if (table == null)
			{
				text3 = null;
			}
			else
			{
				StringTableEntry entry2 = table.GetEntry(a.cop());
				text3 = ((entry2 != null) ? entry2.GetLocalizedString() : null);
			}
			string text4 = text3 ?? a.coq();
			string text5;
			if (table == null)
			{
				text5 = null;
			}
			else
			{
				StringTableEntry entry3 = table.GetEntry(a.cor());
				text5 = ((entry3 != null) ? entry3.GetLocalizedString() : null);
			}
			string text6 = text5 ?? a.cos();
			string text7;
			if (table == null)
			{
				text7 = null;
			}
			else
			{
				StringTableEntry entry4 = table.GetEntry(a.cot());
				text7 = ((entry4 != null) ? entry4.GetLocalizedString() : null);
			}
			string text8 = text7 ?? a.tk();
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.Format(text4, a));
			if (b > 0)
			{
				stringBuilder.Append(a.bfx());
				stringBuilder.Append(string.Format(text6, b));
			}
			if (playerSaveData.clothingSetDatas != null && playerSaveData.clothingSetDatas.Count > 0 && !string.IsNullOrEmpty(text8))
			{
				stringBuilder.Append(a.bhd());
				stringBuilder.Append(text8);
			}
			ModalDialogManager.icb.ShowMessage(text2, stringBuilder.ToString(), null);
		}
	}

	// Token: 0x060008FF RID: 2303 RVA: 0x000371F3 File Offset: 0x000353F3
	private void cbc()
	{
		if (this.hzc)
		{
			this.hzc = false;
			Debug.Log(a.cou());
			this.cas();
			SettingPanel.car();
		}
	}

	// Token: 0x06000900 RID: 2304 RVA: 0x00037219 File Offset: 0x00035419
	private void OnApplicationFocus(bool hasFocus)
	{
		if (!this.isNeedClose)
		{
			return;
		}
		if (!hasFocus && base.gameObject.activeSelf)
		{
			this.Close();
		}
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x0003725F File Offset: 0x0003545F
	[CompilerGenerated]
	private void cbd(bool a)
	{
		if (a)
		{
			bq.hlk = false;
			this.nowSelect = CLOTHE_TYPE.Dick;
			ClotheItemController.kpt.bpi(CLOTHE_TYPE.Dick);
		}
	}

	// Token: 0x06000903 RID: 2307 RVA: 0x0003727C File Offset: 0x0003547C
	[CompilerGenerated]
	private void cbe(bool a)
	{
		if (a)
		{
			bq.hlk = false;
			this.nowSelect = CLOTHE_TYPE.Hair;
			ClotheItemController.kpt.bpi(CLOTHE_TYPE.Hair);
		}
	}

	// Token: 0x06000904 RID: 2308 RVA: 0x00037299 File Offset: 0x00035499
	[CompilerGenerated]
	private void cbf(bool a)
	{
		if (a)
		{
			bq.hlk = false;
			this.nowSelect = CLOTHE_TYPE.Top;
			ClotheItemController.kpt.bpi(CLOTHE_TYPE.Top);
		}
	}

	// Token: 0x06000905 RID: 2309 RVA: 0x000372B6 File Offset: 0x000354B6
	[CompilerGenerated]
	private void cbg(bool a)
	{
		if (a)
		{
			bq.hlk = false;
			this.nowSelect = CLOTHE_TYPE.Bottom;
			ClotheItemController.kpt.bpi(CLOTHE_TYPE.Bottom);
		}
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x000372D3 File Offset: 0x000354D3
	[CompilerGenerated]
	private void cbh(bool a)
	{
		if (a)
		{
			bq.hlk = false;
			this.nowSelect = CLOTHE_TYPE.Underwear;
			ClotheItemController.kpt.bpi(CLOTHE_TYPE.Underwear);
		}
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x000372F0 File Offset: 0x000354F0
	[CompilerGenerated]
	private void cbi(bool a)
	{
		if (a)
		{
			bq.hlk = false;
			this.nowSelect = CLOTHE_TYPE.Socks;
			ClotheItemController.kpt.bpi(CLOTHE_TYPE.Socks);
		}
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x0003730D File Offset: 0x0003550D
	[CompilerGenerated]
	private void cbj(bool a)
	{
		if (a)
		{
			bq.hlk = false;
			this.nowSelect = CLOTHE_TYPE.Shoes;
			ClotheItemController.kpt.bpi(CLOTHE_TYPE.Shoes);
		}
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x0003732C File Offset: 0x0003552C
	[CompilerGenerated]
	private void cbk(bool a)
	{
		if (a)
		{
			bq.hlk = false;
			this.obj_Clothe.SetActive(true);
			this.obj_ClothingSet.SetActive(false);
			if (this.obj_Craft != null)
			{
				this.obj_Craft.SetActive(false);
			}
			this.obj_Setting.SetActive(false);
			this.obj_Info.SetActive(false);
			if (this.obj_Gallery != null)
			{
				this.obj_Gallery.SetActive(false);
			}
		}
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x000373A8 File Offset: 0x000355A8
	[CompilerGenerated]
	private void cbl(bool a)
	{
		if (a)
		{
			bq.hlk = false;
			this.obj_Clothe.SetActive(false);
			this.obj_ClothingSet.SetActive(true);
			this.clothingSetItemController.bqi();
			if (this.obj_Craft != null)
			{
				this.obj_Craft.SetActive(false);
			}
			this.obj_Setting.SetActive(false);
			this.obj_Info.SetActive(false);
			if (this.obj_Gallery != null)
			{
				this.obj_Gallery.SetActive(false);
			}
		}
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x00037430 File Offset: 0x00035630
	[CompilerGenerated]
	private void cbm(bool a)
	{
		if (a)
		{
			bq.hlk = false;
			this.obj_Clothe.SetActive(false);
			this.obj_ClothingSet.SetActive(false);
			if (this.obj_Craft != null)
			{
				this.obj_Craft.SetActive(true);
				CraftPanel component = this.obj_Craft.GetComponent<CraftPanel>();
				if (component != null)
				{
					component.cxc();
				}
			}
			this.obj_Setting.SetActive(false);
			this.obj_Info.SetActive(false);
			if (this.obj_Gallery != null)
			{
				this.obj_Gallery.SetActive(false);
			}
		}
	}

	// Token: 0x0600090C RID: 2316 RVA: 0x000374C8 File Offset: 0x000356C8
	[CompilerGenerated]
	private void cbn(bool a)
	{
		if (a)
		{
			bq.hlk = false;
			this.obj_Clothe.SetActive(false);
			this.obj_ClothingSet.SetActive(false);
			if (this.obj_Craft != null)
			{
				this.obj_Craft.SetActive(false);
			}
			this.obj_Setting.SetActive(true);
			this.obj_Info.SetActive(false);
			if (this.obj_Gallery != null)
			{
				this.obj_Gallery.SetActive(false);
			}
		}
	}

	// Token: 0x0600090D RID: 2317 RVA: 0x00037544 File Offset: 0x00035744
	[CompilerGenerated]
	private void cbo(bool a)
	{
		if (a)
		{
			bq.hlk = false;
			this.obj_Clothe.SetActive(false);
			this.obj_ClothingSet.SetActive(false);
			if (this.obj_Craft != null)
			{
				this.obj_Craft.SetActive(false);
			}
			this.obj_Setting.SetActive(false);
			this.obj_Info.SetActive(true);
			if (this.obj_Gallery != null)
			{
				this.obj_Gallery.SetActive(false);
			}
		}
	}

	// Token: 0x0600090E RID: 2318 RVA: 0x000375C0 File Offset: 0x000357C0
	[CompilerGenerated]
	private void cbp(bool a)
	{
		if (a)
		{
			bq.hlk = false;
			this.obj_Clothe.SetActive(false);
			this.obj_ClothingSet.SetActive(false);
			if (this.obj_Craft != null)
			{
				this.obj_Craft.SetActive(false);
			}
			this.obj_Setting.SetActive(false);
			this.obj_Info.SetActive(false);
			if (this.obj_Gallery != null)
			{
				this.obj_Gallery.SetActive(false);
			}
			if (this.obj_Multiplayer != null)
			{
				this.obj_Multiplayer.SetActive(true);
				return;
			}
		}
		else if (this.obj_Multiplayer != null)
		{
			this.obj_Multiplayer.SetActive(false);
		}
	}

	// Token: 0x0600090F RID: 2319 RVA: 0x00037674 File Offset: 0x00035874
	[CompilerGenerated]
	private void cbq(bool a)
	{
		if (a)
		{
			bq.hlk = false;
			this.obj_Clothe.SetActive(false);
			this.obj_ClothingSet.SetActive(false);
			if (this.obj_Craft != null)
			{
				this.obj_Craft.SetActive(false);
			}
			this.obj_Setting.SetActive(false);
			this.obj_Info.SetActive(false);
			if (this.obj_Gallery != null)
			{
				this.obj_Gallery.SetActive(true);
			}
			if (this.galleryPanel != null)
			{
				this.galleryPanel.bsj();
			}
		}
	}

	// Token: 0x04000762 RID: 1890
	public CLOTHE_TYPE nowSelect;

	// Token: 0x04000763 RID: 1891
	public bool isNeedClose = true;

	// Token: 0x04000764 RID: 1892
	public Button btnClose;

	// Token: 0x04000765 RID: 1893
	[SerializeField]
	private DraggableWindow draggableWindow;

	// Token: 0x04000766 RID: 1894
	private const float hyx = 40f;

	// Token: 0x04000767 RID: 1895
	private RectTransform hyy;

	// Token: 0x04000768 RID: 1896
	public Toggle toggle_Clothe;

	// Token: 0x04000769 RID: 1897
	public Toggle toggle_ClothingSet;

	// Token: 0x0400076A RID: 1898
	public Toggle toggle_Craft;

	// Token: 0x0400076B RID: 1899
	public Toggle toggle_Gallery;

	// Token: 0x0400076C RID: 1900
	public Toggle toggle_Setting;

	// Token: 0x0400076D RID: 1901
	public Toggle toggle_Info;

	// Token: 0x0400076E RID: 1902
	public Toggle toggle_Multiplayer;

	// Token: 0x0400076F RID: 1903
	public GameObject obj_Clothe;

	// Token: 0x04000770 RID: 1904
	public GameObject obj_ClothingSet;

	// Token: 0x04000771 RID: 1905
	public GameObject obj_Craft;

	// Token: 0x04000772 RID: 1906
	public GameObject obj_Gallery;

	// Token: 0x04000773 RID: 1907
	public GameObject obj_Setting;

	// Token: 0x04000774 RID: 1908
	public GameObject obj_Info;

	// Token: 0x04000775 RID: 1909
	public GameObject obj_Multiplayer;

	// Token: 0x04000776 RID: 1910
	public GalleryPanel galleryPanel;

	// Token: 0x04000777 RID: 1911
	public dn settingController;

	// Token: 0x04000778 RID: 1912
	public ClothingSetItemController clothingSetItemController;

	// Token: 0x04000779 RID: 1913
	public InfoPanel infoPanel;

	// Token: 0x0400077A RID: 1914
	public Toggle toggle_Dick;

	// Token: 0x0400077B RID: 1915
	public Toggle toggle_Hair;

	// Token: 0x0400077C RID: 1916
	public Toggle toggle_Top;

	// Token: 0x0400077D RID: 1917
	public Toggle toggle_Bottom;

	// Token: 0x0400077E RID: 1918
	public Toggle toggle_Underwear;

	// Token: 0x0400077F RID: 1919
	public Toggle toggle_Socks;

	// Token: 0x04000780 RID: 1920
	public Toggle toggle_Shoes;

	// Token: 0x04000781 RID: 1921
	public t dotTab;

	// Token: 0x04000782 RID: 1922
	public t dotToggleSetting;

	// Token: 0x04000783 RID: 1923
	public GameObject dotToggleClothe;

	// Token: 0x04000784 RID: 1924
	public GameObject dotToggleDick;

	// Token: 0x04000785 RID: 1925
	public GameObject dotToggleHair;

	// Token: 0x04000786 RID: 1926
	public GameObject dotToggleTop;

	// Token: 0x04000787 RID: 1927
	public GameObject dotToggleBottom;

	// Token: 0x04000788 RID: 1928
	public GameObject dotToggleUnderwear;

	// Token: 0x04000789 RID: 1929
	public GameObject dotToggleSocks;

	// Token: 0x0400078A RID: 1930
	public GameObject dotToggleShoes;

	// Token: 0x0400078B RID: 1931
	private static SettingPanel hyz;

	// Token: 0x0400078C RID: 1932
	private bool hza;

	// Token: 0x0400078D RID: 1933
	private bool hzb;

	// Token: 0x0400078E RID: 1934
	private bool hzc;

	// Token: 0x0400078F RID: 1935
	[TupleElementNames(new string[] { "defID", "quantity" })]
	private readonly HashSet<ValueTuple<int, uint>> hzd = new HashSet<ValueTuple<int, uint>>();

	// Token: 0x04000790 RID: 1936
	[TupleElementNames(new string[] { "defID", "quantity" })]
	private readonly HashSet<ValueTuple<int, uint>> hze = new HashSet<ValueTuple<int, uint>>();

	// Token: 0x04000791 RID: 1937
	private bool hzf;
}
