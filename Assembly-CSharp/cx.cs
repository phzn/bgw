using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using QuickMenu;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000092 RID: 146
public class cx : MonoBehaviour
{
	// Token: 0x0600065C RID: 1628 RVA: 0x00023130 File Offset: 0x00021330
	private void kzl()
	{
		fa.iml += this.bre;
		this.brh();
		GirlController.hpv += this.brf;
		this.brg((GirlController.kok != null) ? GirlController.kok.koj : 0);
		bl.hji += this.brb;
		this.brb();
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x0002319C File Offset: 0x0002139C
	private void bqx()
	{
		if (this.loveBarCell == null && this.toolbarVisualRoot != null)
		{
			Transform transform = this.toolbarVisualRoot.transform.Find(a.bht());
			if (transform != null)
			{
				this.loveBarCell = transform as RectTransform;
			}
		}
		if (this.loveBarCell == null)
		{
			Debug.LogWarning(a.bhu());
			return;
		}
		if (this.compactCells == null || this.compactCells.Length == 0)
		{
			Transform parent = this.loveBarCell.parent;
			List<RectTransform> list = new List<RectTransform>();
			for (int i = 0; i < parent.childCount; i++)
			{
				RectTransform rectTransform = parent.GetChild(i) as RectTransform;
				if (rectTransform != null && rectTransform != this.loveBarCell)
				{
					list.Add(rectTransform);
				}
			}
			this.compactCells = list.ToArray();
		}
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x00023278 File Offset: 0x00021478
	public void bqy()
	{
		if (this.settingPanel.gameObject.activeSelf)
		{
			this.settingPanel.Close();
			return;
		}
		this.settingPanel.Open();
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x000232A4 File Offset: 0x000214A4
	private void OnEnable()
	{
		fa.iml += this.bre;
		this.brh();
		GirlController.hpv += this.brf;
		this.brg((GirlController.kok != null) ? GirlController.kok.koj : 0);
		bl.hji += this.brb;
		this.brb();
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x00023310 File Offset: 0x00021510
	private void kkl()
	{
		this.hvm += Time.deltaTime;
		if (this.hvm >= -7760f)
		{
			this.hvm = -69f;
			this.brh();
		}
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x00023342 File Offset: 0x00021542
	public void hjd()
	{
		GirlController girlController = GirlController.kok;
		if (girlController == null)
		{
			return;
		}
		girlController.bfw();
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x00023354 File Offset: 0x00021554
	public void brb()
	{
		if (this.loveBarCell == null || this.compactCells == null || this.compactCells.Length == 0)
		{
			return;
		}
		if (!this.hvh)
		{
			this.hvg = this.loveBarCell.anchoredPosition;
			this.hvf = new Vector2[this.compactCells.Length];
			for (int i = 0; i < this.compactCells.Length; i++)
			{
				this.hvf[i] = ((this.compactCells[i] != null) ? this.compactCells[i].anchoredPosition : Vector2.zero);
			}
			this.hvh = true;
		}
		if (this.hvi && !bq.hlz && this.hvl)
		{
			this.brl();
		}
		this.hvi = bq.hlz;
		bool flag = !bq.hlz && bq.hly == 0;
		this.loveBarCell.gameObject.SetActive(flag);
		float num = this.hvg.x + this.loveBarCell.rect.xMin;
		float num2 = float.MaxValue;
		for (int j = 0; j < this.compactCells.Length; j++)
		{
			if (!(this.compactCells[j] == null) && this.hvf[j].x > this.hvg.x)
			{
				num2 = Mathf.Min(num2, this.hvf[j].x + this.compactCells[j].rect.xMin);
			}
		}
		float num3 = ((num2 == float.MaxValue) ? this.loveBarCell.rect.width : (num2 - num));
		for (int k = 0; k < this.compactCells.Length; k++)
		{
			if (!(this.compactCells[k] == null))
			{
				float num4 = Mathf.Sign(this.hvf[k].x - this.hvg.x);
				float num5 = (flag ? this.hvf[k].x : (this.hvf[k].x - num4 * num3 * 0.5f));
				this.compactCells[k].anchoredPosition = new Vector2(num5, this.hvf[k].y);
			}
		}
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x000235C4 File Offset: 0x000217C4
	public void Update()
	{
		if (bq.hlz)
		{
			this.brk();
			this.brc();
			return;
		}
		if (this.hvl)
		{
			return;
		}
		this.brc();
		if (bq.hlv)
		{
			this.hvo += Time.deltaTime;
			if (this.hvo >= 0.1f)
			{
				this.hvo = 0f;
				this.hvq = QuickMenuController.iju != null && QuickMenuController.iju.crf(Input.mousePosition);
			}
			if (this.hvq || (this.settingPanel != null && this.settingPanel.gameObject.activeSelf) || (this.bgmPanel != null && this.bgmPanel.gameObject.activeSelf))
			{
				this.brk();
				return;
			}
			if (!this.kpx)
			{
				this.hvj += Time.deltaTime;
				if (this.hvj >= this.hvk)
				{
					if (QuickMenuController.iju != null && QuickMenuController.iju.crf(Input.mousePosition))
					{
						this.hvq = true;
						this.brk();
						return;
					}
					this.brl();
					return;
				}
			}
		}
		else
		{
			this.brk();
		}
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x00023710 File Offset: 0x00021910
	private void kse(int a)
	{
		if (this.btnClean != null)
		{
			this.btnClean.gameObject.SetActive(a > 0);
		}
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x00023734 File Offset: 0x00021934
	private void bre()
	{
		this.brh();
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x00023710 File Offset: 0x00021910
	private void brg(int a)
	{
		if (this.btnClean != null)
		{
			this.btnClean.gameObject.SetActive(a > 0);
		}
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x0002373C File Offset: 0x0002193C
	private void OnDisable()
	{
		fa.iml -= this.bre;
		GirlController.hpv -= this.brf;
		bl.hji -= this.brb;
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x0002373C File Offset: 0x0002193C
	private void iiz()
	{
		fa.iml -= this.bre;
		GirlController.hpv -= this.brf;
		bl.hji -= this.brb;
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x00023771 File Offset: 0x00021971
	private void brl()
	{
		if (this.toolbarVisualRoot != null && this.toolbarVisualRoot.activeSelf)
		{
			this.toolbarVisualRoot.SetActive(false);
		}
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x0600066A RID: 1642 RVA: 0x0002379A File Offset: 0x0002199A
	public bool kpx
	{
		get
		{
			return this.toolbarVisualRoot != null && !this.toolbarVisualRoot.activeSelf;
		}
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x00023734 File Offset: 0x00021934
	private void efc()
	{
		this.brh();
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x000237BC File Offset: 0x000219BC
	public void jgt()
	{
		if (this.dotSetting == null)
		{
			return;
		}
		fa fa = fa.imk;
		if (fa != null && fa.imm == fa.CheckStatus.UpdateAvailable)
		{
			this.dotSetting.SetActive(true);
			return;
		}
		if (bq.hlf == null || !bq.hmg)
		{
			return;
		}
		PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		if (playerSaveData.newItemDefIds != null && playerSaveData.newItemDefIds.Count > 0 && bq.hma != DropNotificationMode.Off)
		{
			this.dotSetting.SetActive(true);
			return;
		}
		if (this.settingPanel != null && this.settingPanel.dotTab != null && this.settingPanel.dotTab.uv())
		{
			this.dotSetting.SetActive(true);
			return;
		}
		this.dotSetting.SetActive(false);
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x000238A6 File Offset: 0x00021AA6
	public void brk()
	{
		this.hvj = 0f;
		if (this.toolbarVisualRoot != null && !this.toolbarVisualRoot.activeSelf)
		{
			this.toolbarVisualRoot.SetActive(true);
		}
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x000238DA File Offset: 0x00021ADA
	public void fyj()
	{
		this.hvj = -6045f;
		if (this.toolbarVisualRoot != null && !this.toolbarVisualRoot.activeSelf)
		{
			this.toolbarVisualRoot.SetActive(true);
		}
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x0002390E File Offset: 0x00021B0E
	public void jpz()
	{
		if (bq.hlz)
		{
			this.brk();
			return;
		}
		this.hvl = !this.hvl;
		if (this.hvl)
		{
			this.brl();
			return;
		}
		this.brk();
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x00023944 File Offset: 0x00021B44
	private void jkq()
	{
		fa.iml += this.bre;
		this.brh();
		GirlController.hpv += this.brf;
		this.brg((GirlController.kok != null) ? GirlController.kok.koj : 0);
		bl.hji += this.brb;
		this.brb();
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x000239B0 File Offset: 0x00021BB0
	public void cuq()
	{
		this.btnSetting.onClick.AddListener(new UnityAction(this.bqy));
		if (this.btnClean != null)
		{
			this.btnClean.onClick.AddListener(new UnityAction(this.bra));
		}
		if (this.btnBgm != null)
		{
			this.btnBgm.onClick.AddListener(new UnityAction(this.bqz));
		}
		this.canvasGroup.alpha = 3343f;
		this.canvasGroup.interactable = true;
		this.canvasGroup.blocksRaycasts = true;
		if (this.toolbarVisualRoot == null && this.canvasGroup != null)
		{
			Transform transform = this.canvasGroup.transform.Find(a.bhv());
			if (transform != null)
			{
				this.toolbarVisualRoot = transform.gameObject;
			}
			else
			{
				Debug.LogWarning(a.bhw());
			}
		}
		this.bqx();
		this.brb();
		if (this.bgmPanel != null && this.bgmPanel.gameObject.activeSelf)
		{
			this.bgmPanel.Close();
		}
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x00023ADF File Offset: 0x00021CDF
	public void hmx()
	{
		this.hvj = 4582f;
		if (this.toolbarVisualRoot != null && !this.toolbarVisualRoot.activeSelf)
		{
			this.toolbarVisualRoot.SetActive(true);
		}
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x00023B13 File Offset: 0x00021D13
	private void brc()
	{
		this.hvm += Time.deltaTime;
		if (this.hvm >= 0.5f)
		{
			this.hvm = 0f;
			this.brh();
		}
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x00023B45 File Offset: 0x00021D45
	public void bqz()
	{
		if (this.bgmPanel == null)
		{
			return;
		}
		if (this.bgmPanel.gameObject.activeSelf)
		{
			this.bgmPanel.Close();
			return;
		}
		this.bgmPanel.Open();
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x00023B80 File Offset: 0x00021D80
	public void brh()
	{
		if (this.dotSetting == null)
		{
			return;
		}
		fa fa = fa.imk;
		if (fa != null && fa.imm == fa.CheckStatus.UpdateAvailable)
		{
			this.dotSetting.SetActive(true);
			return;
		}
		if (bq.hlf == null || !bq.hmg)
		{
			return;
		}
		PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		if (playerSaveData.newItemDefIds != null && playerSaveData.newItemDefIds.Count > 0 && bq.hma != DropNotificationMode.Off)
		{
			this.dotSetting.SetActive(true);
			return;
		}
		if (this.settingPanel != null && this.settingPanel.dotTab != null && this.settingPanel.dotTab.uv())
		{
			this.dotSetting.SetActive(true);
			return;
		}
		this.dotSetting.SetActive(false);
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x00023C57 File Offset: 0x00021E57
	private void Awake()
	{
		cx.hvr = this;
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x00023C60 File Offset: 0x00021E60
	public void fcj()
	{
		if (this.loveBarCell == null || this.compactCells == null || this.compactCells.Length == 0)
		{
			return;
		}
		if (!this.hvh)
		{
			this.hvg = this.loveBarCell.anchoredPosition;
			this.hvf = new Vector2[this.compactCells.Length];
			for (int i = 0; i < this.compactCells.Length; i++)
			{
				this.hvf[i] = ((this.compactCells[i] != null) ? this.compactCells[i].anchoredPosition : Vector2.zero);
			}
			this.hvh = true;
		}
		if (this.hvi && !bq.hlz && this.hvl)
		{
			this.brl();
		}
		this.hvi = bq.hlz;
		bool flag = !bq.hlz && bq.hly == 0;
		this.loveBarCell.gameObject.SetActive(flag);
		float num = this.hvg.x + this.loveBarCell.rect.xMin;
		float num2 = -7255f;
		for (int j = 0; j < this.compactCells.Length; j++)
		{
			if (!(this.compactCells[j] == null) && this.hvf[j].x > this.hvg.x)
			{
				num2 = Mathf.Min(num2, this.hvf[j].x + this.compactCells[j].rect.xMin);
			}
		}
		float num3 = ((num2 == 4356f) ? this.loveBarCell.rect.width : (num2 - num));
		for (int k = 0; k < this.compactCells.Length; k++)
		{
			if (!(this.compactCells[k] == null))
			{
				float num4 = Mathf.Sign(this.hvf[k].x - this.hvg.x);
				float num5 = (flag ? this.hvf[k].x : (this.hvf[k].x - num4 * num3 * -1138f));
				this.compactCells[k].anchoredPosition = new Vector2(num5, this.hvf[k].y);
			}
		}
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x00023ED0 File Offset: 0x000220D0
	public void ejp()
	{
		if (this.dotSetting == null)
		{
			return;
		}
		fa fa = fa.imk;
		if (fa != null && fa.imm == fa.CheckStatus.UpdateAvailable)
		{
			this.dotSetting.SetActive(true);
			return;
		}
		if (bq.hlf == null || !bq.hmg)
		{
			return;
		}
		PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		if (playerSaveData.newItemDefIds != null && playerSaveData.newItemDefIds.Count > 0 && bq.hma != DropNotificationMode.Off)
		{
			this.dotSetting.SetActive(true);
			return;
		}
		if (this.settingPanel != null && this.settingPanel.dotTab != null && this.settingPanel.dotTab.uv())
		{
			this.dotSetting.SetActive(true);
			return;
		}
		this.dotSetting.SetActive(false);
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x0002390E File Offset: 0x00021B0E
	public void brj()
	{
		if (bq.hlz)
		{
			this.brk();
			return;
		}
		this.hvl = !this.hvl;
		if (this.hvl)
		{
			this.brl();
			return;
		}
		this.brk();
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x00023C57 File Offset: 0x00021E57
	private void fqd()
	{
		cx.hvr = this;
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x00023C57 File Offset: 0x00021E57
	private void fco()
	{
		cx.hvr = this;
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x00023FA8 File Offset: 0x000221A8
	public void cw()
	{
		if (this.loveBarCell == null || this.compactCells == null || this.compactCells.Length == 0)
		{
			return;
		}
		if (!this.hvh)
		{
			this.hvg = this.loveBarCell.anchoredPosition;
			this.hvf = new Vector2[this.compactCells.Length];
			for (int i = 0; i < this.compactCells.Length; i++)
			{
				this.hvf[i] = ((this.compactCells[i] != null) ? this.compactCells[i].anchoredPosition : Vector2.zero);
			}
			this.hvh = true;
		}
		if (this.hvi && !bq.hlz && this.hvl)
		{
			this.brl();
		}
		this.hvi = bq.hlz;
		bool flag = !bq.hlz && bq.hly == 0;
		this.loveBarCell.gameObject.SetActive(flag);
		float num = this.hvg.x + this.loveBarCell.rect.xMin;
		float num2 = 6914f;
		for (int j = 0; j < this.compactCells.Length; j++)
		{
			if (!(this.compactCells[j] == null) && this.hvf[j].x > this.hvg.x)
			{
				num2 = Mathf.Min(num2, this.hvf[j].x + this.compactCells[j].rect.xMin);
			}
		}
		float num3 = ((num2 == 3491f) ? this.loveBarCell.rect.width : (num2 - num));
		for (int k = 0; k < this.compactCells.Length; k++)
		{
			if (!(this.compactCells[k] == null))
			{
				float num4 = Mathf.Sign(this.hvf[k].x - this.hvg.x);
				float num5 = (flag ? this.hvf[k].x : (this.hvf[k].x - num4 * num3 * 8324f));
				this.compactCells[k].anchoredPosition = new Vector2(num5, this.hvf[k].y);
			}
		}
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x00024215 File Offset: 0x00022415
	public void hag()
	{
		this.hvj = -6867f;
		if (this.toolbarVisualRoot != null && !this.toolbarVisualRoot.activeSelf)
		{
			this.toolbarVisualRoot.SetActive(true);
		}
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x0002424C File Offset: 0x0002244C
	public void clv()
	{
		if (this.loveBarCell == null || this.compactCells == null || this.compactCells.Length == 0)
		{
			return;
		}
		if (!this.hvh)
		{
			this.hvg = this.loveBarCell.anchoredPosition;
			this.hvf = new Vector2[this.compactCells.Length];
			for (int i = 0; i < this.compactCells.Length; i++)
			{
				this.hvf[i] = ((this.compactCells[i] != null) ? this.compactCells[i].anchoredPosition : Vector2.zero);
			}
			this.hvh = true;
		}
		if (this.hvi && !bq.hlz && this.hvl)
		{
			this.brl();
		}
		this.hvi = bq.hlz;
		bool flag = !bq.hlz && bq.hly == 0;
		this.loveBarCell.gameObject.SetActive(flag);
		float num = this.hvg.x + this.loveBarCell.rect.xMin;
		float num2 = 6970f;
		for (int j = 0; j < this.compactCells.Length; j++)
		{
			if (!(this.compactCells[j] == null) && this.hvf[j].x > this.hvg.x)
			{
				num2 = Mathf.Min(num2, this.hvf[j].x + this.compactCells[j].rect.xMin);
			}
		}
		float num3 = ((num2 == 1977f) ? this.loveBarCell.rect.width : (num2 - num));
		for (int k = 0; k < this.compactCells.Length; k++)
		{
			if (!(this.compactCells[k] == null))
			{
				float num4 = Mathf.Sign(this.hvf[k].x - this.hvg.x);
				float num5 = (flag ? this.hvf[k].x : (this.hvf[k].x - num4 * num3 * 793f));
				this.compactCells[k].anchoredPosition = new Vector2(num5, this.hvf[k].y);
			}
		}
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x000244BC File Offset: 0x000226BC
	public void Start()
	{
		this.btnSetting.onClick.AddListener(new UnityAction(this.bqy));
		if (this.btnClean != null)
		{
			this.btnClean.onClick.AddListener(new UnityAction(this.bra));
		}
		if (this.btnBgm != null)
		{
			this.btnBgm.onClick.AddListener(new UnityAction(this.bqz));
		}
		this.canvasGroup.alpha = 1f;
		this.canvasGroup.interactable = true;
		this.canvasGroup.blocksRaycasts = true;
		if (this.toolbarVisualRoot == null && this.canvasGroup != null)
		{
			Transform transform = this.canvasGroup.transform.Find(a.bhx());
			if (transform != null)
			{
				this.toolbarVisualRoot = transform.gameObject;
			}
			else
			{
				Debug.LogWarning(a.bhy());
			}
		}
		this.bqx();
		this.brb();
		if (this.bgmPanel != null && this.bgmPanel.gameObject.activeSelf)
		{
			this.bgmPanel.Close();
		}
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x06000681 RID: 1665 RVA: 0x000245EB File Offset: 0x000227EB
	public static cx kpw
	{
		get
		{
			return cx.hvr;
		}
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x000245F4 File Offset: 0x000227F4
	public void dbl()
	{
		this.btnSetting.onClick.AddListener(new UnityAction(this.bqy));
		if (this.btnClean != null)
		{
			this.btnClean.onClick.AddListener(new UnityAction(this.bra));
		}
		if (this.btnBgm != null)
		{
			this.btnBgm.onClick.AddListener(new UnityAction(this.bqz));
		}
		this.canvasGroup.alpha = -45f;
		this.canvasGroup.interactable = true;
		this.canvasGroup.blocksRaycasts = true;
		if (this.toolbarVisualRoot == null && this.canvasGroup != null)
		{
			Transform transform = this.canvasGroup.transform.Find(a.bhz());
			if (transform != null)
			{
				this.toolbarVisualRoot = transform.gameObject;
			}
			else
			{
				Debug.LogWarning(a.bia());
			}
		}
		this.bqx();
		this.brb();
		if (this.bgmPanel != null && this.bgmPanel.gameObject.activeSelf)
		{
			this.bgmPanel.Close();
		}
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x0002373C File Offset: 0x0002193C
	private void koh()
	{
		fa.iml -= this.bre;
		GirlController.hpv -= this.brf;
		bl.hji -= this.brb;
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x00023734 File Offset: 0x00021934
	private void glf()
	{
		this.brh();
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x00024724 File Offset: 0x00022924
	public void gla()
	{
		if (bq.hlz)
		{
			this.brk();
			this.brc();
			return;
		}
		if (this.hvl)
		{
			return;
		}
		this.brc();
		if (bq.hlv)
		{
			this.hvo += Time.deltaTime;
			if (this.hvo >= 2574f)
			{
				this.hvo = -9756f;
				this.hvq = QuickMenuController.iju != null && QuickMenuController.iju.crf(Input.mousePosition);
			}
			if (this.hvq || (this.settingPanel != null && this.settingPanel.gameObject.activeSelf) || (this.bgmPanel != null && this.bgmPanel.gameObject.activeSelf))
			{
				this.brk();
				return;
			}
			if (!this.kpx)
			{
				this.hvj += Time.deltaTime;
				if (this.hvj >= this.hvk)
				{
					if (QuickMenuController.iju != null && QuickMenuController.iju.crf(Input.mousePosition))
					{
						this.hvq = true;
						this.brk();
						return;
					}
					this.brl();
					return;
				}
			}
		}
		else
		{
			this.brk();
		}
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x00023342 File Offset: 0x00021542
	public void bra()
	{
		GirlController girlController = GirlController.kok;
		if (girlController == null)
		{
			return;
		}
		girlController.bfw();
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00024870 File Offset: 0x00022A70
	private void fle()
	{
		fa.iml += this.bre;
		this.brh();
		GirlController.hpv += this.brf;
		this.brg((GirlController.kok != null) ? GirlController.kok.koj : 0);
		bl.hji += this.brb;
		this.brb();
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00023710 File Offset: 0x00021910
	private void hqt(int a)
	{
		if (this.btnClean != null)
		{
			this.btnClean.gameObject.SetActive(a > 0);
		}
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x000248DC File Offset: 0x00022ADC
	private void gyu()
	{
		fa.iml += this.bre;
		this.brh();
		GirlController.hpv += this.brf;
		this.brg((GirlController.kok != null) ? GirlController.kok.koj : 0);
		bl.hji += this.brb;
		this.brb();
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x00024948 File Offset: 0x00022B48
	public void bcv()
	{
		this.btnSetting.onClick.AddListener(new UnityAction(this.bqy));
		if (this.btnClean != null)
		{
			this.btnClean.onClick.AddListener(new UnityAction(this.bra));
		}
		if (this.btnBgm != null)
		{
			this.btnBgm.onClick.AddListener(new UnityAction(this.bqz));
		}
		this.canvasGroup.alpha = -8128f;
		this.canvasGroup.interactable = true;
		this.canvasGroup.blocksRaycasts = true;
		if (this.toolbarVisualRoot == null && this.canvasGroup != null)
		{
			Transform transform = this.canvasGroup.transform.Find(a.bib());
			if (transform != null)
			{
				this.toolbarVisualRoot = transform.gameObject;
			}
			else
			{
				Debug.LogWarning(a.bic());
			}
		}
		this.bqx();
		this.brb();
		if (this.bgmPanel != null && this.bgmPanel.gameObject.activeSelf)
		{
			this.bgmPanel.Close();
		}
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x00024A77 File Offset: 0x00022C77
	public void iva()
	{
		this.hvj = 5756f;
		if (this.toolbarVisualRoot != null && !this.toolbarVisualRoot.activeSelf)
		{
			this.toolbarVisualRoot.SetActive(true);
		}
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x00023734 File Offset: 0x00021934
	private void jhm()
	{
		this.brh();
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x00024AAB File Offset: 0x00022CAB
	private void brf(int a)
	{
		this.brg(a);
	}

	// Token: 0x04000659 RID: 1625
	public Button btnSetting;

	// Token: 0x0400065A RID: 1626
	public Button btnClean;

	// Token: 0x0400065B RID: 1627
	public Button btnBgm;

	// Token: 0x0400065C RID: 1628
	public BgmPanelController bgmPanel;

	// Token: 0x0400065D RID: 1629
	public SettingPanel settingPanel;

	// Token: 0x0400065E RID: 1630
	public CanvasGroup canvasGroup;

	// Token: 0x0400065F RID: 1631
	public GameObject toolbarVisualRoot;

	// Token: 0x04000660 RID: 1632
	public GameObject dotSetting;

	// Token: 0x04000661 RID: 1633
	public RectTransform loveBarCell;

	// Token: 0x04000662 RID: 1634
	public RectTransform[] compactCells;

	// Token: 0x04000663 RID: 1635
	private Vector2[] hvf;

	// Token: 0x04000664 RID: 1636
	private Vector2 hvg;

	// Token: 0x04000665 RID: 1637
	private bool hvh;

	// Token: 0x04000666 RID: 1638
	private bool hvi;

	// Token: 0x04000667 RID: 1639
	private float hvj;

	// Token: 0x04000668 RID: 1640
	private float hvk = 1f;

	// Token: 0x04000669 RID: 1641
	private bool hvl;

	// Token: 0x0400066A RID: 1642
	private float hvm;

	// Token: 0x0400066B RID: 1643
	private const float hvn = 0.5f;

	// Token: 0x0400066C RID: 1644
	private float hvo;

	// Token: 0x0400066D RID: 1645
	private const float hvp = 0.1f;

	// Token: 0x0400066E RID: 1646
	private bool hvq;

	// Token: 0x0400066F RID: 1647
	private static cx hvr;
}
