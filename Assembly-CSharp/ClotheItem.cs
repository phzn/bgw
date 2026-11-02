using System;
using System.Linq;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.UI;

// Token: 0x0200008B RID: 139
public class ClotheItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerClickHandler
{
	// Token: 0x1700008B RID: 139
	// (get) Token: 0x060005FD RID: 1533 RVA: 0x00020F23 File Offset: 0x0001F123
	public ClotheItemController kpq
	{
		get
		{
			return ClotheItemController.kpt;
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x060005FE RID: 1534 RVA: 0x00020F2A File Offset: 0x0001F12A
	public SettingPanel kpr
	{
		get
		{
			return SettingPanel.kqq;
		}
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x060005FF RID: 1535 RVA: 0x00020F31 File Offset: 0x0001F131
	public Button kps
	{
		get
		{
			return this._button;
		}
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00005090 File Offset: 0x00003290
	public void Start()
	{
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x00020F39 File Offset: 0x0001F139
	public void bon()
	{
		this._imageIcon.sprite = null;
		this.boz(false);
		this.kps.onClick.AddListener(new UnityAction(this.bpc));
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x00020F78 File Offset: 0x0001F178
	public void boo(SpineSkinData a)
	{
		this.spineSkinData = a;
		if (this._tipObject != null)
		{
			if (a.kox == 0)
			{
				this._tipObject.vj(false);
				this._button.interactable = true;
			}
			else if (!a.bjk())
			{
				this._imageIcon.sprite = bq.hle.spriteLock;
				this._tipObject.vj(true);
				this._tipObject.tipDelay = 0f;
				this._tipObject.vh(ClotheItem.bor(a.creatorPageUnlock));
				this._button.interactable = false;
			}
			else if (a.isNeedUnlock)
			{
				bool flag = du.iah != null && du.iah.iai && du.iah.cej(a.achievement);
				if (!flag && du.iah != null && !du.iah.iai)
				{
					Debug.LogWarning(string.Format(a.bgx(), a.name, a.achievement));
					return;
				}
				if (flag)
				{
					this.bos(a);
					this._button.interactable = true;
				}
				else
				{
					if (bq.knd)
					{
						Debug.Log(string.Format(a.bgy(), a.name, a.achievement, flag));
					}
					this._imageIcon.sprite = bq.hle.spriteLock;
					this._tipObject.vj(true);
					this._tipObject.tipDelay = 0f;
					AchievementData achievementData = bq.hlf.bjf(a.achievement);
					if (achievementData != null)
					{
						this._tipObject.vh(achievementData.description);
					}
					this._button.interactable = false;
				}
			}
			else
			{
				this.bos(a);
				this._button.interactable = true;
			}
		}
		this.bow();
		this.bpe();
		this.bop();
		this.bpd();
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x00021178 File Offset: 0x0001F378
	private void bop()
	{
		if (this._imageBackground_Line == null)
		{
			return;
		}
		SpineSkinSetting hle = bq.hle;
		if (hle == null)
		{
			return;
		}
		if (this.spineSkinData == null || this.spineSkinData.kox == 0)
		{
			this._imageBackground_Line.color = hle.defaultBackgroundColor;
			return;
		}
		string text = ClotheItem.boq(this.spineSkinData.kox);
		this._imageBackground_Line.color = ((!string.IsNullOrEmpty(text)) ? hle.bjv(text) : hle.defaultBackgroundColor);
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00021200 File Offset: 0x0001F400
	private static string boq(int a)
	{
		ItemData[] hlj = bq.hlj;
		if (hlj == null || hlj.Length == 0)
		{
			return null;
		}
		foreach (ItemData itemData in hlj)
		{
			if (itemData != null && itemData.defID == a)
			{
				return itemData.rarity;
			}
		}
		return null;
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x00021244 File Offset: 0x0001F444
	private static string bor(CREATOR_PAGE_UNLOCK a)
	{
		string text = ((a == CREATOR_PAGE_UNLOCK.Developer) ? a.bha() : a.bgz());
		try
		{
			StringTable table = LocalizationSettings.StringDatabase.GetTable(a.rh(), null);
			string text2;
			if (table == null)
			{
				text2 = null;
			}
			else
			{
				StringTableEntry entry = table.GetEntry(text);
				text2 = ((entry != null) ? entry.GetLocalizedString() : null);
			}
			string text3 = text2;
			if (!string.IsNullOrEmpty(text3))
			{
				return text3;
			}
		}
		catch
		{
		}
		if (a != CREATOR_PAGE_UNLOCK.Developer)
		{
			return a.bhb();
		}
		return a.bhc();
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x000212C4 File Offset: 0x0001F4C4
	private void bos(SpineSkinData a)
	{
		if (this._tipObject == null)
		{
			return;
		}
		string text;
		string text2;
		if (!ClotheItem.bot(a, out text, out text2))
		{
			this._tipObject.vj(false);
			return;
		}
		string text3;
		if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2))
		{
			text3 = text + a.bhd() + text2;
		}
		else
		{
			text3 = ((!string.IsNullOrEmpty(text)) ? text : text2);
		}
		this._tipObject.vj(true);
		this._tipObject.tipDelay = 0.6f;
		this._tipObject.vh(text3);
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x00021350 File Offset: 0x0001F550
	private static bool bot(SpineSkinData a, out string b, out string c)
	{
		ClotheItem.cu cu = new ClotheItem.cu();
		cu.hua = a;
		b = null;
		c = null;
		if (cu.hua == null || cu.hua.kox == 0)
		{
			return false;
		}
		ItemData[] hlj = bq.hlj;
		ItemData itemData = ((hlj != null) ? hlj.FirstOrDefault<ItemData>(new Func<ItemData, bool>(cu.boj)) : null);
		if (itemData != null)
		{
			b = ClotheItem.bou(itemData, true);
			c = ClotheItem.bou(itemData, false);
		}
		string text = cu.hua.name.ToString();
		if (string.IsNullOrEmpty(b))
		{
			b = ClotheItem.bov(a.bhe() + text + a.bhf());
		}
		if (string.IsNullOrEmpty(c))
		{
			c = ClotheItem.bov(a.bhe() + text + a.bhg());
		}
		return !string.IsNullOrEmpty(b) || !string.IsNullOrEmpty(c);
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x00021426 File Offset: 0x0001F626
	private static string bou(ItemData a, bool b)
	{
		if (!b)
		{
			return a.bis();
		}
		return a.bir();
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x00021438 File Offset: 0x0001F638
	private static string bov(string a)
	{
		string text2;
		try
		{
			StringTable table = LocalizationSettings.StringDatabase.GetTable(a.bhh(), null);
			StringTableEntry stringTableEntry = ((table != null) ? table.GetEntry(a) : null);
			string text = ((stringTableEntry != null) ? stringTableEntry.GetLocalizedString() : null);
			text2 = (string.IsNullOrEmpty(text) ? null : text);
		}
		catch
		{
			text2 = null;
		}
		return text2;
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x0002149C File Offset: 0x0001F69C
	public void bow()
	{
		if (this._textNumber == null || this._rectNumberBG == null || this.spineSkinData == null)
		{
			return;
		}
		int num = this.box(this.spineSkinData.kox);
		if (num <= 1)
		{
			this._rectNumberBG.gameObject.SetActive(false);
			return;
		}
		this._rectNumberBG.gameObject.SetActive(true);
		this._textNumber.text = num.ToString();
		this._textNumber.ForceMeshUpdate(false, false);
		LayoutRebuilder.ForceRebuildLayoutImmediate(this._textNumber.rectTransform);
		float width = this._textNumber.rectTransform.rect.width;
		this._rectNumberBG.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width + 10f);
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x00021562 File Offset: 0x0001F762
	private int box(int a)
	{
		return bq.bar(a);
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x0002156A File Offset: 0x0001F76A
	public void Close()
	{
		this.kps.onClick.RemoveListener(new UnityAction(this.bpc));
		this._imageIcon.sprite = null;
		this.boz(false);
		base.gameObject.SetActive(false);
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x000215A7 File Offset: 0x0001F7A7
	public void boy(Sprite a)
	{
		if (a == null)
		{
			return;
		}
		this._imageIcon.sprite = a;
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x000215BF File Offset: 0x0001F7BF
	public void boz(bool a)
	{
		this._objUse.SetActive(a);
	}

	// Token: 0x1400000C RID: 12
	// (add) Token: 0x0600060F RID: 1551 RVA: 0x000215D0 File Offset: 0x0001F7D0
	// (remove) Token: 0x06000610 RID: 1552 RVA: 0x00021604 File Offset: 0x0001F804
	public static event Action hue;

	// Token: 0x06000611 RID: 1553 RVA: 0x00021638 File Offset: 0x0001F838
	public void bpc()
	{
		bq.hlk = false;
		this.spineSkinData.bjp(false);
		this.boz(true);
		this.kpq.bpw();
		GirlController.kok.ChangeClothe();
		ci.Save(null);
		Action action = ClotheItem.hue;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x00021688 File Offset: 0x0001F888
	public void OnPointerEnter(PointerEventData eventData)
	{
		if (this.spineSkinData == null || this._objNewDot == null || !this._objNewDot.activeSelf)
		{
			return;
		}
		if (bq.hlf.playerSaveData.newItemDefIds.Remove(this.spineSkinData.kox))
		{
			this._objNewDot.SetActive(false);
			ci.Save(null);
			if (SettingPanel.kqq != null)
			{
				SettingPanel.kqq.cap();
			}
		}
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x00021704 File Offset: 0x0001F904
	public void OnPointerClick(PointerEventData eventData)
	{
		if (eventData.button != PointerEventData.InputButton.Right)
		{
			return;
		}
		if (this.spineSkinData == null)
		{
			return;
		}
		if (!bp.zo(this.spineSkinData.kox))
		{
			return;
		}
		if (!this.spineSkinData.bjq())
		{
			return;
		}
		bp.zq(this.spineSkinData.kox);
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x00021758 File Offset: 0x0001F958
	private void bpd()
	{
		if (this._objFavorite == null || this.spineSkinData == null)
		{
			return;
		}
		this._objFavorite.SetActive(this.spineSkinData.kox != 0 && bp.zp(this.spineSkinData.kox));
	}

	// Token: 0x06000615 RID: 1557 RVA: 0x000217A8 File Offset: 0x0001F9A8
	private void bpe()
	{
		if (this._objNewDot == null || this.spineSkinData == null || bq.hlf == null)
		{
			return;
		}
		PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		int num = this.spineSkinData.kox;
		if (this.spineSkinData.kox == 0)
		{
			this._objNewDot.SetActive(false);
			return;
		}
		if (this.spineSkinData.isNeedUnlock && (!(du.iah != null) || !du.iah.iai || !du.iah.cej(this.spineSkinData.achievement)))
		{
			this._objNewDot.SetActive(false);
			if (playerSaveData.newItemDefIds.Remove(num))
			{
				Debug.LogWarning(string.Format(a.bhi(), num, this.spineSkinData.achievement));
				ClotheItem.hub = true;
			}
			return;
		}
		if (!this.spineSkinData.bjk())
		{
			this._objNewDot.SetActive(false);
			if (playerSaveData.newItemDefIds.Remove(num))
			{
				ClotheItem.hub = true;
			}
			return;
		}
		if (!playerSaveData.knownItemDefIds.Contains(num))
		{
			playerSaveData.knownItemDefIds.Add(num);
			if (playerSaveData.hasInitializedKnownItems && !playerSaveData.newItemDefIds.Contains(num))
			{
				playerSaveData.newItemDefIds.Add(num);
			}
			ClotheItem.hub = true;
		}
		this._objNewDot.SetActive(playerSaveData.newItemDefIds.Contains(num));
	}

	// Token: 0x06000616 RID: 1558 RVA: 0x0002191A File Offset: 0x0001FB1A
	public void bpf()
	{
		this.boz(this.spineSkinData.bjs());
		this.bow();
	}

	// Token: 0x04000613 RID: 1555
	[SerializeField]
	private Button _button;

	// Token: 0x04000614 RID: 1556
	[SerializeField]
	private Image _imageIcon;

	// Token: 0x04000615 RID: 1557
	[SerializeField]
	private GameObject _objUse;

	// Token: 0x04000616 RID: 1558
	[SerializeField]
	private bb _tipObject;

	// Token: 0x04000617 RID: 1559
	[SerializeField]
	private RectTransform _rectNumberBG;

	// Token: 0x04000618 RID: 1560
	[SerializeField]
	private RectTransform _rectNumber;

	// Token: 0x04000619 RID: 1561
	[SerializeField]
	private TextMeshProUGUI _textNumber;

	// Token: 0x0400061A RID: 1562
	[SerializeField]
	private GameObject _objNewDot;

	// Token: 0x0400061B RID: 1563
	[SerializeField]
	private GameObject _objFavorite;

	// Token: 0x0400061C RID: 1564
	[SerializeField]
	private Image _imageBackground_Line;

	// Token: 0x0400061D RID: 1565
	internal static bool hub;

	// Token: 0x0400061E RID: 1566
	private const float huc = 0.6f;

	// Token: 0x0400061F RID: 1567
	private const string hud = "Item";

	// Token: 0x04000620 RID: 1568
	public SpineSkinData spineSkinData;

	// Token: 0x04000621 RID: 1569
	public Action OnClickAction;

	// Token: 0x0200008C RID: 140
	[CompilerGenerated]
	private sealed class cu
	{
		// Token: 0x06000619 RID: 1561 RVA: 0x00021933 File Offset: 0x0001FB33
		internal bool boj(ItemData a)
		{
			return a != null && a.defID == this.hua.kox;
		}

		// Token: 0x04000623 RID: 1571
		public SpineSkinData hua;
	}
}
