using System;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Kirurobo;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000265 RID: 613
public class lo : MonoBehaviour
{
	// Token: 0x06002658 RID: 9816 RVA: 0x000A0D26 File Offset: 0x0009EF26
	private void esx(int a)
	{
		if (!this.kjk)
		{
			return;
		}
		if (a < 1)
		{
			this.kjk.shouldFitMonitor = false;
			return;
		}
		this.kjk.monitorToFit = a - 1;
		this.kjk.shouldFitMonitor = true;
	}

	// Token: 0x06002659 RID: 9817 RVA: 0x000A0D61 File Offset: 0x0009EF61
	private void ksp(string a)
	{
		Debug.Log(a);
	}

	// Token: 0x0600265A RID: 9818 RVA: 0x000A0D61 File Offset: 0x0009EF61
	private void eay(string a)
	{
		Debug.Log(a);
	}

	// Token: 0x0600265B RID: 9819 RVA: 0x000A0D6C File Offset: 0x0009EF6C
	private void Update()
	{
		if (lr.gxj(1))
		{
			this.kjo = lr.mgy;
			this.kjp = 0f;
		}
		if (lr.gxi(1))
		{
			this.kjm += (lr.mgy - this.kjo).sqrMagnitude;
		}
		if (lr.gxk(1))
		{
			if (this.kjm < this.kjn)
			{
				this.gwn(this.kjo);
			}
			this.kjm = 0f;
			this.kjp = 0f;
		}
		if (Input.touchSupported && Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			if (touch.phase == TouchPhase.Began)
			{
				this.kjo = Input.mousePosition;
				this.kjp = 0f;
			}
			if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
			{
				this.kjm += touch.deltaPosition.sqrMagnitude;
				this.kjp += touch.deltaTime;
			}
			if (touch.phase == TouchPhase.Ended)
			{
				if (this.kjm < this.kjn && this.kjp >= this.kjq)
				{
					this.gwn(this.kjo);
				}
				this.kjm = 0f;
				this.kjp = 0f;
			}
		}
		if (lr.gxg(a.fdi()) && this.menuPanel)
		{
			if (this.menuPanel.gameObject.activeSelf)
			{
				this.gwo();
			}
			else
			{
				Vector2 vector = new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2));
				this.gwn(vector);
			}
		}
		if (lr.gxg(a.faq()))
		{
			this.gwl();
		}
	}

	// Token: 0x0600265C RID: 9820 RVA: 0x000A0F30 File Offset: 0x0009F130
	private void kby()
	{
		if (this.menuPanel)
		{
			this.menuPanel.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600265D RID: 9821 RVA: 0x00043378 File Offset: 0x00041578
	private void gwl()
	{
		Application.Quit();
	}

	// Token: 0x0600265E RID: 9822 RVA: 0x000A0F50 File Offset: 0x0009F150
	private void gwn(Vector2 a)
	{
		if (this.menuPanel)
		{
			Vector2 vector = a * (this.kjl.sizeDelta.x / (float)Screen.width);
			float width = this.menuPanel.rect.width;
			float height = this.menuPanel.rect.height;
			vector.y = Mathf.Max(Mathf.Min(vector.y, (float)Screen.height - height / 2f), height / 2f);
			vector.x = Mathf.Max(Mathf.Min(vector.x, (float)Screen.width - width / 2f), width / 2f);
			this.menuPanel.pivot = Vector2.one * 0.5f;
			this.menuPanel.anchorMin = Vector2.zero;
			this.menuPanel.anchorMax = Vector2.zero;
			this.menuPanel.anchoredPosition = vector;
			this.menuPanel.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600265F RID: 9823 RVA: 0x000A1062 File Offset: 0x0009F262
	[CompilerGenerated]
	private void gwt(bool a)
	{
		this.kjk.isTransparent = a;
	}

	// Token: 0x06002660 RID: 9824 RVA: 0x000A0F30 File Offset: 0x0009F130
	private void fnb()
	{
		if (this.menuPanel)
		{
			this.menuPanel.gameObject.SetActive(false);
		}
	}

	// Token: 0x06002661 RID: 9825 RVA: 0x000A0D61 File Offset: 0x0009EF61
	public void dyz(string a)
	{
		Debug.Log(a);
	}

	// Token: 0x06002662 RID: 9826 RVA: 0x000A1070 File Offset: 0x0009F270
	[CompilerGenerated]
	private void gwy()
	{
		this.gwq();
		this.gwp();
	}

	// Token: 0x06002663 RID: 9827 RVA: 0x00043378 File Offset: 0x00041578
	private void gez()
	{
		Application.Quit();
	}

	// Token: 0x06002664 RID: 9828 RVA: 0x000A107E File Offset: 0x0009F27E
	[CompilerGenerated]
	private void gwu(bool a)
	{
		this.kjk.isTopmost = a;
	}

	// Token: 0x06002665 RID: 9829 RVA: 0x000A108C File Offset: 0x0009F28C
	private void dpr()
	{
		if (!this.fitWindowDropdown)
		{
			return;
		}
		this.fitWindowDropdown.options.RemoveRange(1, this.fitWindowDropdown.options.Count - 1);
		if (!this.kjk)
		{
			this.fitWindowDropdown.value = 0;
			return;
		}
		int monitorCount = UniWindowController.GetMonitorCount();
		for (int i = 0; i < monitorCount; i++)
		{
			this.fitWindowDropdown.options.Add(new Dropdown.OptionData(a.fdj() + i.ToString()));
		}
		if (this.kjk.monitorToFit >= monitorCount)
		{
			this.kjk.monitorToFit = monitorCount - 1;
		}
	}

	// Token: 0x06002666 RID: 9830 RVA: 0x000A1138 File Offset: 0x0009F338
	[CompilerGenerated]
	private void gww(int a)
	{
		this.gwm(a);
	}

	// Token: 0x06002667 RID: 9831 RVA: 0x000A1144 File Offset: 0x0009F344
	private void Start()
	{
		this.kjk = global::UnityEngine.Object.FindAnyObjectByType<UniWindowController>();
		if (this.menuPanel)
		{
			this.kjl = this.menuPanel.GetComponentInParent<Canvas>().GetComponent<RectTransform>();
		}
		this.gwq();
		this.gwp();
		this.gwo();
		if (this.kjk)
		{
			Toggle toggle = this.transparentToggle;
			if (toggle != null)
			{
				toggle.onValueChanged.AddListener(new UnityAction<bool>(this.gwt));
			}
			Toggle toggle2 = this.topmostToggle;
			if (toggle2 != null)
			{
				toggle2.onValueChanged.AddListener(new UnityAction<bool>(this.gwu));
			}
			Toggle toggle3 = this.bottommostToggle;
			if (toggle3 != null)
			{
				toggle3.onValueChanged.AddListener(new UnityAction<bool>(this.gwv));
			}
			Dropdown dropdown = this.fitWindowDropdown;
			if (dropdown != null)
			{
				dropdown.onValueChanged.AddListener(new UnityAction<int>(this.gww));
			}
			Button button = this.quitButton;
			if (button != null)
			{
				button.onClick.AddListener(new UnityAction(this.gwl));
			}
			Button button2 = this.menuCloseButton;
			if (button2 != null)
			{
				button2.onClick.AddListener(new UnityAction(this.gwo));
			}
			this.kjk.OnStateChanged += this.gwx;
			this.kjk.OnMonitorChanged += this.gwy;
		}
	}

	// Token: 0x06002669 RID: 9833 RVA: 0x000A12BC File Offset: 0x0009F4BC
	private void los(Vector2 a)
	{
		if (this.menuPanel)
		{
			Vector2 vector = a * (this.kjl.sizeDelta.x / (float)Screen.width);
			float width = this.menuPanel.rect.width;
			float height = this.menuPanel.rect.height;
			vector.y = Mathf.Max(Mathf.Min(vector.y, (float)Screen.height - height / 4924f), height / 5271f);
			vector.x = Mathf.Max(Mathf.Min(vector.x, (float)Screen.width - width / 3291f), width / 5052f);
			this.menuPanel.pivot = Vector2.one * 4967f;
			this.menuPanel.anchorMin = Vector2.zero;
			this.menuPanel.anchorMax = Vector2.zero;
			this.menuPanel.anchoredPosition = vector;
			this.menuPanel.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600266A RID: 9834 RVA: 0x000A13D0 File Offset: 0x0009F5D0
	private void ghn()
	{
		if (!this.fitWindowDropdown)
		{
			return;
		}
		this.fitWindowDropdown.options.RemoveRange(1, this.fitWindowDropdown.options.Count - 1);
		if (!this.kjk)
		{
			this.fitWindowDropdown.value = 0;
			return;
		}
		int monitorCount = UniWindowController.GetMonitorCount();
		for (int i = 0; i < monitorCount; i++)
		{
			this.fitWindowDropdown.options.Add(new Dropdown.OptionData(a.fdk() + i.ToString()));
		}
		if (this.kjk.monitorToFit >= monitorCount)
		{
			this.kjk.monitorToFit = monitorCount - 1;
		}
	}

	// Token: 0x0600266B RID: 9835 RVA: 0x000A0D61 File Offset: 0x0009EF61
	private void chs(string a)
	{
		Debug.Log(a);
	}

	// Token: 0x0600266C RID: 9836 RVA: 0x000A0D61 File Offset: 0x0009EF61
	private void gwr(string a)
	{
		Debug.Log(a);
	}

	// Token: 0x0600266D RID: 9837 RVA: 0x000A147C File Offset: 0x0009F67C
	private void ego()
	{
		if (this.kjk)
		{
			if (this.transparentToggle)
			{
				this.transparentToggle.isOn = this.kjk.isTransparent;
			}
			if (this.topmostToggle)
			{
				this.topmostToggle.isOn = this.kjk.isTopmost;
			}
			if (this.bottommostToggle)
			{
				this.bottommostToggle.isOn = this.kjk.isBottommost;
			}
			if (this.fitWindowDropdown)
			{
				if (this.kjk.shouldFitMonitor)
				{
					this.fitWindowDropdown.value = this.kjk.monitorToFit + 1;
				}
				else
				{
					this.fitWindowDropdown.value = 0;
				}
				this.fitWindowDropdown.RefreshShownValue();
			}
		}
	}

	// Token: 0x0600266E RID: 9838 RVA: 0x000A1550 File Offset: 0x0009F750
	private void gyx(Vector2 a)
	{
		if (this.menuPanel)
		{
			Vector2 vector = a * (this.kjl.sizeDelta.x / (float)Screen.width);
			float width = this.menuPanel.rect.width;
			float height = this.menuPanel.rect.height;
			vector.y = Mathf.Max(Mathf.Min(vector.y, (float)Screen.height - height / 718f), height / 7730f);
			vector.x = Mathf.Max(Mathf.Min(vector.x, (float)Screen.width - width / -6008f), width / 2245f);
			this.menuPanel.pivot = Vector2.one * -3362f;
			this.menuPanel.anchorMin = Vector2.zero;
			this.menuPanel.anchorMax = Vector2.zero;
			this.menuPanel.anchoredPosition = vector;
			this.menuPanel.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600266F RID: 9839 RVA: 0x000A0D61 File Offset: 0x0009EF61
	public void gws(string a)
	{
		Debug.Log(a);
	}

	// Token: 0x06002670 RID: 9840 RVA: 0x000A1664 File Offset: 0x0009F864
	private void jd()
	{
		if (this.kjk)
		{
			if (this.transparentToggle)
			{
				this.transparentToggle.isOn = this.kjk.isTransparent;
			}
			if (this.topmostToggle)
			{
				this.topmostToggle.isOn = this.kjk.isTopmost;
			}
			if (this.bottommostToggle)
			{
				this.bottommostToggle.isOn = this.kjk.isBottommost;
			}
			if (this.fitWindowDropdown)
			{
				if (this.kjk.shouldFitMonitor)
				{
					this.fitWindowDropdown.value = this.kjk.monitorToFit + 1;
				}
				else
				{
					this.fitWindowDropdown.value = 0;
				}
				this.fitWindowDropdown.RefreshShownValue();
			}
		}
	}

	// Token: 0x06002671 RID: 9841 RVA: 0x000A0F30 File Offset: 0x0009F130
	private void oql()
	{
		if (this.menuPanel)
		{
			this.menuPanel.gameObject.SetActive(false);
		}
	}

	// Token: 0x06002672 RID: 9842 RVA: 0x000A0D61 File Offset: 0x0009EF61
	public void lix(string a)
	{
		Debug.Log(a);
	}

	// Token: 0x06002673 RID: 9843 RVA: 0x000A1738 File Offset: 0x0009F938
	private void gwq()
	{
		if (!this.fitWindowDropdown)
		{
			return;
		}
		this.fitWindowDropdown.options.RemoveRange(1, this.fitWindowDropdown.options.Count - 1);
		if (!this.kjk)
		{
			this.fitWindowDropdown.value = 0;
			return;
		}
		int monitorCount = UniWindowController.GetMonitorCount();
		for (int i = 0; i < monitorCount; i++)
		{
			this.fitWindowDropdown.options.Add(new Dropdown.OptionData(a.fdc() + i.ToString()));
		}
		if (this.kjk.monitorToFit >= monitorCount)
		{
			this.kjk.monitorToFit = monitorCount - 1;
		}
	}

	// Token: 0x06002674 RID: 9844 RVA: 0x000A0F30 File Offset: 0x0009F130
	private void gwo()
	{
		if (this.menuPanel)
		{
			this.menuPanel.gameObject.SetActive(false);
		}
	}

	// Token: 0x06002675 RID: 9845 RVA: 0x000A0D26 File Offset: 0x0009EF26
	private void epo(int a)
	{
		if (!this.kjk)
		{
			return;
		}
		if (a < 1)
		{
			this.kjk.shouldFitMonitor = false;
			return;
		}
		this.kjk.monitorToFit = a - 1;
		this.kjk.shouldFitMonitor = true;
	}

	// Token: 0x06002676 RID: 9846 RVA: 0x000A17E4 File Offset: 0x0009F9E4
	private void eka()
	{
		if (lr.gxj(1))
		{
			this.kjo = lr.mgy;
			this.kjp = -4304f;
		}
		if (lr.gxi(1))
		{
			this.kjm += (lr.mgy - this.kjo).sqrMagnitude;
		}
		if (lr.gxk(1))
		{
			if (this.kjm < this.kjn)
			{
				this.gwn(this.kjo);
			}
			this.kjm = -8903f;
			this.kjp = 7666f;
		}
		if (Input.touchSupported && Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			if (touch.phase == TouchPhase.Began)
			{
				this.kjo = Input.mousePosition;
				this.kjp = 3797f;
			}
			if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
			{
				this.kjm += touch.deltaPosition.sqrMagnitude;
				this.kjp += touch.deltaTime;
			}
			if (touch.phase == TouchPhase.Ended)
			{
				if (this.kjm < this.kjn && this.kjp >= this.kjq)
				{
					this.gwn(this.kjo);
				}
				this.kjm = 6873f;
				this.kjp = -9943f;
			}
		}
		if (lr.gxg(a.fdl()) && this.menuPanel)
		{
			if (this.menuPanel.gameObject.activeSelf)
			{
				this.gwo();
			}
			else
			{
				Vector2 vector = new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2));
				this.gwn(vector);
			}
		}
		if (lr.gxg(a.fdm()))
		{
			this.gwl();
		}
	}

	// Token: 0x06002677 RID: 9847 RVA: 0x00043378 File Offset: 0x00041578
	private void ohe()
	{
		Application.Quit();
	}

	// Token: 0x06002678 RID: 9848 RVA: 0x000A0D61 File Offset: 0x0009EF61
	public void bdz(string a)
	{
		Debug.Log(a);
	}

	// Token: 0x06002679 RID: 9849 RVA: 0x000A0D61 File Offset: 0x0009EF61
	public void onz(string a)
	{
		Debug.Log(a);
	}

	// Token: 0x0600267A RID: 9850 RVA: 0x000A19A8 File Offset: 0x0009FBA8
	private void ehe()
	{
		this.kjk = global::UnityEngine.Object.FindAnyObjectByType<UniWindowController>();
		if (this.menuPanel)
		{
			this.kjl = this.menuPanel.GetComponentInParent<Canvas>().GetComponent<RectTransform>();
		}
		this.gwq();
		this.gwp();
		this.gwo();
		if (this.kjk)
		{
			Toggle toggle = this.transparentToggle;
			if (toggle != null)
			{
				toggle.onValueChanged.AddListener(new UnityAction<bool>(this.gwt));
			}
			Toggle toggle2 = this.topmostToggle;
			if (toggle2 != null)
			{
				toggle2.onValueChanged.AddListener(new UnityAction<bool>(this.gwu));
			}
			Toggle toggle3 = this.bottommostToggle;
			if (toggle3 != null)
			{
				toggle3.onValueChanged.AddListener(new UnityAction<bool>(this.gwv));
			}
			Dropdown dropdown = this.fitWindowDropdown;
			if (dropdown != null)
			{
				dropdown.onValueChanged.AddListener(new UnityAction<int>(this.gww));
			}
			Button button = this.quitButton;
			if (button != null)
			{
				button.onClick.AddListener(new UnityAction(this.gwl));
			}
			Button button2 = this.menuCloseButton;
			if (button2 != null)
			{
				button2.onClick.AddListener(new UnityAction(this.gwo));
			}
			this.kjk.OnStateChanged += this.gwx;
			this.kjk.OnMonitorChanged += this.gwy;
		}
	}

	// Token: 0x0600267B RID: 9851 RVA: 0x000A1B00 File Offset: 0x0009FD00
	private void kuc()
	{
		if (this.kjk)
		{
			if (this.transparentToggle)
			{
				this.transparentToggle.isOn = this.kjk.isTransparent;
			}
			if (this.topmostToggle)
			{
				this.topmostToggle.isOn = this.kjk.isTopmost;
			}
			if (this.bottommostToggle)
			{
				this.bottommostToggle.isOn = this.kjk.isBottommost;
			}
			if (this.fitWindowDropdown)
			{
				if (this.kjk.shouldFitMonitor)
				{
					this.fitWindowDropdown.value = this.kjk.monitorToFit + 1;
				}
				else
				{
					this.fitWindowDropdown.value = 0;
				}
				this.fitWindowDropdown.RefreshShownValue();
			}
		}
	}

	// Token: 0x0600267C RID: 9852 RVA: 0x000A1BD4 File Offset: 0x0009FDD4
	private void bxo()
	{
		if (!this.fitWindowDropdown)
		{
			return;
		}
		this.fitWindowDropdown.options.RemoveRange(1, this.fitWindowDropdown.options.Count - 1);
		if (!this.kjk)
		{
			this.fitWindowDropdown.value = 0;
			return;
		}
		int monitorCount = UniWindowController.GetMonitorCount();
		for (int i = 0; i < monitorCount; i++)
		{
			this.fitWindowDropdown.options.Add(new Dropdown.OptionData(a.fdn() + i.ToString()));
		}
		if (this.kjk.monitorToFit >= monitorCount)
		{
			this.kjk.monitorToFit = monitorCount - 1;
		}
	}

	// Token: 0x0600267D RID: 9853 RVA: 0x000A1C80 File Offset: 0x0009FE80
	private void ivi()
	{
		if (this.kjk)
		{
			if (this.transparentToggle)
			{
				this.transparentToggle.isOn = this.kjk.isTransparent;
			}
			if (this.topmostToggle)
			{
				this.topmostToggle.isOn = this.kjk.isTopmost;
			}
			if (this.bottommostToggle)
			{
				this.bottommostToggle.isOn = this.kjk.isBottommost;
			}
			if (this.fitWindowDropdown)
			{
				if (this.kjk.shouldFitMonitor)
				{
					this.fitWindowDropdown.value = this.kjk.monitorToFit + 1;
				}
				else
				{
					this.fitWindowDropdown.value = 0;
				}
				this.fitWindowDropdown.RefreshShownValue();
			}
		}
	}

	// Token: 0x0600267E RID: 9854 RVA: 0x000A0D26 File Offset: 0x0009EF26
	private void gwm(int a)
	{
		if (!this.kjk)
		{
			return;
		}
		if (a < 1)
		{
			this.kjk.shouldFitMonitor = false;
			return;
		}
		this.kjk.monitorToFit = a - 1;
		this.kjk.shouldFitMonitor = true;
	}

	// Token: 0x0600267F RID: 9855 RVA: 0x000A1D54 File Offset: 0x0009FF54
	private void jzr()
	{
		if (!this.fitWindowDropdown)
		{
			return;
		}
		this.fitWindowDropdown.options.RemoveRange(1, this.fitWindowDropdown.options.Count - 1);
		if (!this.kjk)
		{
			this.fitWindowDropdown.value = 0;
			return;
		}
		int monitorCount = UniWindowController.GetMonitorCount();
		for (int i = 0; i < monitorCount; i++)
		{
			this.fitWindowDropdown.options.Add(new Dropdown.OptionData(a.fdo() + i.ToString()));
		}
		if (this.kjk.monitorToFit >= monitorCount)
		{
			this.kjk.monitorToFit = monitorCount - 1;
		}
	}

	// Token: 0x06002680 RID: 9856 RVA: 0x000A1E00 File Offset: 0x000A0000
	private void gwp()
	{
		if (this.kjk)
		{
			if (this.transparentToggle)
			{
				this.transparentToggle.isOn = this.kjk.isTransparent;
			}
			if (this.topmostToggle)
			{
				this.topmostToggle.isOn = this.kjk.isTopmost;
			}
			if (this.bottommostToggle)
			{
				this.bottommostToggle.isOn = this.kjk.isBottommost;
			}
			if (this.fitWindowDropdown)
			{
				if (this.kjk.shouldFitMonitor)
				{
					this.fitWindowDropdown.value = this.kjk.monitorToFit + 1;
				}
				else
				{
					this.fitWindowDropdown.value = 0;
				}
				this.fitWindowDropdown.RefreshShownValue();
			}
		}
	}

	// Token: 0x06002681 RID: 9857 RVA: 0x000A1ED1 File Offset: 0x000A00D1
	[CompilerGenerated]
	private void gwx(UniWindowController.WindowStateEventType a)
	{
		this.gwp();
	}

	// Token: 0x06002682 RID: 9858 RVA: 0x00043378 File Offset: 0x00041578
	private void clk()
	{
		Application.Quit();
	}

	// Token: 0x06002683 RID: 9859 RVA: 0x000A1EDC File Offset: 0x000A00DC
	private void bg(Vector2 a)
	{
		if (this.menuPanel)
		{
			Vector2 vector = a * (this.kjl.sizeDelta.x / (float)Screen.width);
			float width = this.menuPanel.rect.width;
			float height = this.menuPanel.rect.height;
			vector.y = Mathf.Max(Mathf.Min(vector.y, (float)Screen.height - height / 9991f), height / 4008f);
			vector.x = Mathf.Max(Mathf.Min(vector.x, (float)Screen.width - width / 8090f), width / -3073f);
			this.menuPanel.pivot = Vector2.one * -9301f;
			this.menuPanel.anchorMin = Vector2.zero;
			this.menuPanel.anchorMax = Vector2.zero;
			this.menuPanel.anchoredPosition = vector;
			this.menuPanel.gameObject.SetActive(true);
		}
	}

	// Token: 0x06002684 RID: 9860 RVA: 0x000A1FF0 File Offset: 0x000A01F0
	private void dcc()
	{
		if (lr.gxj(1))
		{
			this.kjo = lr.mgy;
			this.kjp = 8137f;
		}
		if (lr.gxi(1))
		{
			this.kjm += (lr.mgy - this.kjo).sqrMagnitude;
		}
		if (lr.gxk(1))
		{
			if (this.kjm < this.kjn)
			{
				this.gwn(this.kjo);
			}
			this.kjm = -915f;
			this.kjp = -9813f;
		}
		if (Input.touchSupported && Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			if (touch.phase == TouchPhase.Began)
			{
				this.kjo = Input.mousePosition;
				this.kjp = 2336f;
			}
			if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
			{
				this.kjm += touch.deltaPosition.sqrMagnitude;
				this.kjp += touch.deltaTime;
			}
			if (touch.phase == TouchPhase.Ended)
			{
				if (this.kjm < this.kjn && this.kjp >= this.kjq)
				{
					this.gwn(this.kjo);
				}
				this.kjm = -4158f;
				this.kjp = 1649f;
			}
		}
		if (lr.gxg(a.fdp()) && this.menuPanel)
		{
			if (this.menuPanel.gameObject.activeSelf)
			{
				this.gwo();
			}
			else
			{
				Vector2 vector = new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2));
				this.gwn(vector);
			}
		}
		if (lr.gxg(a.fdq()))
		{
			this.gwl();
		}
	}

	// Token: 0x06002685 RID: 9861 RVA: 0x000A0D26 File Offset: 0x0009EF26
	private void lwe(int a)
	{
		if (!this.kjk)
		{
			return;
		}
		if (a < 1)
		{
			this.kjk.shouldFitMonitor = false;
			return;
		}
		this.kjk.monitorToFit = a - 1;
		this.kjk.shouldFitMonitor = true;
	}

	// Token: 0x06002686 RID: 9862 RVA: 0x000A21B4 File Offset: 0x000A03B4
	[CompilerGenerated]
	private void gwv(bool a)
	{
		this.kjk.isBottommost = a;
	}

	// Token: 0x040012A8 RID: 4776
	private UniWindowController kjk;

	// Token: 0x040012A9 RID: 4777
	private RectTransform kjl;

	// Token: 0x040012AA RID: 4778
	private float kjm;

	// Token: 0x040012AB RID: 4779
	private float kjn = 36f;

	// Token: 0x040012AC RID: 4780
	private Vector3 kjo;

	// Token: 0x040012AD RID: 4781
	private float kjp;

	// Token: 0x040012AE RID: 4782
	private float kjq = 0.5f;

	// Token: 0x040012AF RID: 4783
	public Toggle transparentToggle;

	// Token: 0x040012B0 RID: 4784
	public Toggle topmostToggle;

	// Token: 0x040012B1 RID: 4785
	public Toggle bottommostToggle;

	// Token: 0x040012B2 RID: 4786
	public Dropdown fitWindowDropdown;

	// Token: 0x040012B3 RID: 4787
	public Button quitButton;

	// Token: 0x040012B4 RID: 4788
	public Button menuCloseButton;

	// Token: 0x040012B5 RID: 4789
	public RectTransform menuPanel;
}
