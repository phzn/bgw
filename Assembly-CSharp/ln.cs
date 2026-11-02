using System;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Kirurobo;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Token: 0x02000264 RID: 612
public class ln : MonoBehaviour
{
	// Token: 0x06002615 RID: 9749 RVA: 0x0009E5B8 File Offset: 0x0009C7B8
	private void hvi(Vector2 a)
	{
		if (this.menuPanel)
		{
			Vector2 vector = a * (this.kjc.sizeDelta.x / (float)Screen.width);
			float width = this.menuPanel.rect.width;
			float height = this.menuPanel.rect.height;
			vector.y = Mathf.Max(Mathf.Min(vector.y, (float)Screen.height - height / 5589f), height / -2953f);
			vector.x = Mathf.Max(Mathf.Min(vector.x, (float)Screen.width - width / 7046f), width / -3322f);
			this.menuPanel.pivot = Vector2.one * -379f;
			this.menuPanel.anchorMin = Vector2.zero;
			this.menuPanel.anchorMax = Vector2.zero;
			this.menuPanel.anchoredPosition = vector;
			this.menuPanel.gameObject.SetActive(true);
		}
	}

	// Token: 0x06002616 RID: 9750 RVA: 0x0009E6CC File Offset: 0x0009C8CC
	public void htw()
	{
		if (this.kja)
		{
			if (this.clickThroughToggle)
			{
				this.clickThroughToggle.SetIsOnWithoutNotify(this.kja.isClickThrough);
				if (this.kja.hitTestType == UniWindowController.HitTestType.None)
				{
					this.clickThroughToggle.interactable = true;
				}
				else
				{
					this.clickThroughToggle.interactable = false;
				}
			}
			if (this.kja.hitTestType == UniWindowController.HitTestType.Opacity && this.kja.isTransparent)
			{
				if (this.pickedColorImage)
				{
					this.pickedColorImage.color = this.kja.pickedColor;
				}
				if (this.pickedColorText)
				{
					this.pickedColorText.text = string.Format(a.fac(), this.kja.pickedColor.a);
					this.pickedColorText.color = Color.black;
					return;
				}
			}
			else
			{
				if (this.pickedColorImage)
				{
					this.pickedColorImage.color = Color.gray;
				}
				if (this.pickedColorText)
				{
					this.pickedColorText.text = a.fad();
					this.pickedColorText.color = Color.gray;
				}
			}
		}
	}

	// Token: 0x06002617 RID: 9751 RVA: 0x0009E80C File Offset: 0x0009CA0C
	private void gvi()
	{
		if (this.kja)
		{
			Vector2 windowPosition = this.kja.windowPosition;
			this.gvo(string.Concat(new string[]
			{
				a.fae(),
				windowPosition.ToString(),
				a.faf(),
				this.kja.windowSize.ToString(),
				a.fag(),
				(this.kja.cursorPosition - windowPosition).ToString(),
				a.fah(),
				lr.mgy.ToString()
			}));
			this.gvp();
		}
	}

	// Token: 0x06002618 RID: 9752 RVA: 0x0009E8D8 File Offset: 0x0009CAD8
	private void gvl()
	{
		if (this.kja)
		{
			if (this.transparentToggle)
			{
				this.transparentToggle.SetIsOnWithoutNotify(this.kja.isTransparent);
			}
			if (this.alphaSlider)
			{
				this.alphaSlider.SetValueWithoutNotify(this.kja.alphaValue);
			}
			if (this.topmostToggle)
			{
				this.topmostToggle.SetIsOnWithoutNotify(this.kja.isTopmost);
			}
			if (this.bottommostToggle)
			{
				this.bottommostToggle.SetIsOnWithoutNotify(this.kja.isBottommost);
			}
			if (this.zoomedToggle)
			{
				this.zoomedToggle.SetIsOnWithoutNotify(this.kja.isZoomed);
			}
			if (this.allowDropToggle)
			{
				this.allowDropToggle.SetIsOnWithoutNotify(this.kja.allowDropFiles);
			}
			if (this.dragMoveToggle)
			{
				this.dragMoveToggle.isOn = this.kjb && this.kjb.isActiveAndEnabled;
			}
			if (this.fitWindowDropdown)
			{
				if (this.kja.shouldFitMonitor)
				{
					this.fitWindowDropdown.value = this.kja.monitorToFit + 1;
					if (this.zoomedToggle)
					{
						this.zoomedToggle.interactable = false;
					}
				}
				else
				{
					this.fitWindowDropdown.value = 0;
					if (this.zoomedToggle)
					{
						this.zoomedToggle.interactable = true;
					}
				}
				this.fitWindowDropdown.RefreshShownValue();
			}
			if (this.transparentTypeDropdown)
			{
				this.transparentTypeDropdown.value = (int)this.kja.transparentType;
				this.transparentTypeDropdown.RefreshShownValue();
			}
			if (this.hitTestTypeDropdown)
			{
				this.hitTestTypeDropdown.value = (int)this.kja.hitTestType;
				this.hitTestTypeDropdown.RefreshShownValue();
			}
			this.gvm();
		}
		if (this.showBorderlineToggle && this.borderlinePanel)
		{
			this.borderlinePanel.gameObject.SetActive(this.showBorderlineToggle.isOn);
		}
	}

	// Token: 0x06002619 RID: 9753 RVA: 0x0009EB10 File Offset: 0x0009CD10
	private void gvj(Vector2 a)
	{
		if (this.menuPanel)
		{
			Vector2 vector = a * (this.kjc.sizeDelta.x / (float)Screen.width);
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

	// Token: 0x0600261A RID: 9754 RVA: 0x0009EC22 File Offset: 0x0009CE22
	[CompilerGenerated]
	private void gwd(int a)
	{
		this.kja.hitTestType = (UniWindowController.HitTestType)a;
	}

	// Token: 0x0600261B RID: 9755 RVA: 0x0009EC30 File Offset: 0x0009CE30
	private void hfx(string a)
	{
		this.kjg = Time.time;
		if (this.messageText)
		{
			this.messageText.text = a;
		}
		Debug.Log(a);
	}

	// Token: 0x0600261C RID: 9756 RVA: 0x0009EC5C File Offset: 0x0009CE5C
	private void hcm()
	{
		if (this.menuPanel)
		{
			this.menuPanel.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600261D RID: 9757 RVA: 0x0009EC5C File Offset: 0x0009CE5C
	private void gvk()
	{
		if (this.menuPanel)
		{
			this.menuPanel.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600261E RID: 9758 RVA: 0x0009EC7C File Offset: 0x0009CE7C
	[CompilerGenerated]
	private void gwk(string[] a)
	{
		this.gvf(string.Join(Environment.NewLine, a));
	}

	// Token: 0x0600261F RID: 9759 RVA: 0x0009EC90 File Offset: 0x0009CE90
	private void Update()
	{
		this.gvm();
		if (this.kjg + this.kjh < Time.time)
		{
			this.gvi();
		}
		if (lr.gxj(1))
		{
			this.kjf = lr.mgy;
			this.gvg();
		}
		if (lr.gxi(1))
		{
			this.kjd += (lr.mgy - this.kjf).sqrMagnitude;
		}
		if (lr.gxk(1))
		{
			if (this.kjd < this.kje)
			{
				this.gvj(this.kjf);
			}
			this.kjd = 0f;
			this.gvg();
		}
		if (Input.touchSupported && Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			if (touch.phase == TouchPhase.Began)
			{
				this.kjf = Input.mousePosition;
				this.gvg();
			}
			if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
			{
				this.kjd += touch.deltaPosition.sqrMagnitude;
				this.kji += touch.deltaTime;
			}
			if (touch.phase == TouchPhase.Ended)
			{
				if (this.kjd < this.kje && this.kji >= this.kjj)
				{
					this.gvj(this.kjf);
				}
				this.kjd = 0f;
				this.gvg();
			}
		}
		if (lr.gxg(a.ij()))
		{
			FilePanel.OpenFilePanel(new FilePanel.Settings
			{
				flags = FilePanel.Flag.AllowMultipleSelection,
				title = a.fai(),
				filters = new FilePanel.Filter[]
				{
					new FilePanel.Filter(a.faj(), new string[]
					{
						a.dma(),
						a.dmb(),
						a.fak()
					}),
					new FilePanel.Filter(a.fal(), new string[] { a.dcv() })
				},
				initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
				initialFile = a.fam()
			}, new Action<string[]>(this.gwj));
		}
		if (lr.gxg(a.fan()))
		{
			FilePanel.SaveFilePanel(new FilePanel.Settings
			{
				flags = FilePanel.Flag.AllowMultipleSelection,
				title = a.fao(),
				filters = new FilePanel.Filter[0],
				initialFile = a.fap(),
				initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
			}, new Action<string[]>(this.gwk));
		}
		if (lr.gxg(a.faq()))
		{
			Application.Quit();
		}
	}

	// Token: 0x06002620 RID: 9760 RVA: 0x0009EF18 File Offset: 0x0009D118
	[CompilerGenerated]
	private void gvs(bool a)
	{
		this.kja.isTopmost = a;
	}

	// Token: 0x06002621 RID: 9761 RVA: 0x0009EF26 File Offset: 0x0009D126
	public void gvo(string a)
	{
		if (this.messageText)
		{
			this.messageText.text = a;
			return;
		}
		Debug.Log(a);
	}

	// Token: 0x06002622 RID: 9762 RVA: 0x0009EF48 File Offset: 0x0009D148
	private void gpy()
	{
		if (!this.fitWindowDropdown)
		{
			return;
		}
		this.fitWindowDropdown.options.RemoveRange(1, this.fitWindowDropdown.options.Count - 1);
		if (!this.kja)
		{
			this.fitWindowDropdown.value = 0;
			return;
		}
		int monitorCount = UniWindowController.GetMonitorCount();
		for (int i = 0; i < monitorCount; i++)
		{
			this.fitWindowDropdown.options.Add(new Dropdown.OptionData(a.far() + i.ToString()));
		}
		if (this.kja.monitorToFit >= monitorCount)
		{
			this.kja.monitorToFit = monitorCount - 1;
		}
	}

	// Token: 0x06002623 RID: 9763 RVA: 0x0009EFF4 File Offset: 0x0009D1F4
	private void iab()
	{
		this.gvm();
		if (this.kjg + this.kjh < Time.time)
		{
			this.gvi();
		}
		if (lr.gxj(1))
		{
			this.kjf = lr.mgy;
			this.gvg();
		}
		if (lr.gxi(1))
		{
			this.kjd += (lr.mgy - this.kjf).sqrMagnitude;
		}
		if (lr.gxk(1))
		{
			if (this.kjd < this.kje)
			{
				this.gvj(this.kjf);
			}
			this.kjd = 8634f;
			this.gvg();
		}
		if (Input.touchSupported && Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			if (touch.phase == TouchPhase.Began)
			{
				this.kjf = Input.mousePosition;
				this.gvg();
			}
			if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
			{
				this.kjd += touch.deltaPosition.sqrMagnitude;
				this.kji += touch.deltaTime;
			}
			if (touch.phase == TouchPhase.Ended)
			{
				if (this.kjd < this.kje && this.kji >= this.kjj)
				{
					this.gvj(this.kjf);
				}
				this.kjd = 7923f;
				this.gvg();
			}
		}
		if (lr.gxg(a.fas()))
		{
			FilePanel.OpenFilePanel(new FilePanel.Settings
			{
				flags = FilePanel.Flag.AllowMultipleSelection,
				title = a.fat(),
				filters = new FilePanel.Filter[]
				{
					new FilePanel.Filter(a.fau(), new string[]
					{
						a.fav(),
						a.faw(),
						a.fax()
					}),
					new FilePanel.Filter(a.fay(), new string[] { a.faz() })
				},
				initialDirectory = Environment.GetFolderPath((Environment.SpecialFolder)3),
				initialFile = a.fba()
			}, new Action<string[]>(this.gwj));
		}
		if (lr.gxg(a.fbb()))
		{
			FilePanel.SaveFilePanel(new FilePanel.Settings
			{
				flags = FilePanel.Flag.AllowMultipleSelection,
				title = a.fbc(),
				filters = new FilePanel.Filter[0],
				initialFile = a.fbd(),
				initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
			}, new Action<string[]>(this.gwk));
		}
		if (lr.gxg(a.fbe()))
		{
			Application.Quit();
		}
	}

	// Token: 0x06002624 RID: 9764 RVA: 0x0009F27C File Offset: 0x0009D47C
	private void nlu(int a)
	{
		if (!this.kja)
		{
			return;
		}
		if (a < 1)
		{
			this.kja.shouldFitMonitor = false;
			if (this.zoomedToggle)
			{
				this.zoomedToggle.interactable = true;
				return;
			}
		}
		else
		{
			this.kja.monitorToFit = a - 1;
			this.kja.shouldFitMonitor = true;
			if (this.zoomedToggle)
			{
				this.zoomedToggle.interactable = false;
			}
		}
	}

	// Token: 0x06002625 RID: 9765 RVA: 0x0009F2F4 File Offset: 0x0009D4F4
	private void dvp(bool hasFocus)
	{
		if (hasFocus)
		{
			this.gvl();
			if (this.kja)
			{
				this.gvo(a.fbf());
				return;
			}
			this.gvo(a.fbg());
		}
	}

	// Token: 0x06002626 RID: 9766 RVA: 0x0009EC5C File Offset: 0x0009CE5C
	private void fz()
	{
		if (this.menuPanel)
		{
			this.menuPanel.gameObject.SetActive(false);
		}
	}

	// Token: 0x06002627 RID: 9767 RVA: 0x0009F323 File Offset: 0x0009D523
	[CompilerGenerated]
	private void gvt(bool a)
	{
		this.kja.isBottommost = a;
	}

	// Token: 0x06002628 RID: 9768 RVA: 0x0009EC30 File Offset: 0x0009CE30
	private void gvf(string a)
	{
		this.kjg = Time.time;
		if (this.messageText)
		{
			this.messageText.text = a;
		}
		Debug.Log(a);
	}

	// Token: 0x06002629 RID: 9769 RVA: 0x0009F331 File Offset: 0x0009D531
	[CompilerGenerated]
	private void gvx()
	{
		this.kja.windowSize += new Vector2(-100f, 0f);
	}

	// Token: 0x0600262A RID: 9770 RVA: 0x0009F358 File Offset: 0x0009D558
	[CompilerGenerated]
	private void gvw(int a)
	{
		this.gvh(a);
	}

	// Token: 0x0600262B RID: 9771 RVA: 0x0009F361 File Offset: 0x0009D561
	[CompilerGenerated]
	private void gvy()
	{
		this.kja.windowSize += new Vector2(100f, 0f);
	}

	// Token: 0x0600262C RID: 9772 RVA: 0x0009F388 File Offset: 0x0009D588
	private void glk(bool hasFocus)
	{
		if (hasFocus)
		{
			this.gvl();
			if (this.kja)
			{
				this.gvo(a.fbh());
				return;
			}
			this.gvo(a.fbi());
		}
	}

	// Token: 0x0600262D RID: 9773 RVA: 0x0009F3B8 File Offset: 0x0009D5B8
	private void Start()
	{
		this.kja = UniWindowController.current;
		this.kjb = global::UnityEngine.Object.FindAnyObjectByType<UniWindowMoveHandle>();
		if (this.menuPanel)
		{
			this.kjc = this.menuPanel.GetComponentInParent<Canvas>().GetComponent<RectTransform>();
		}
		this.gvn();
		this.gvl();
		if (this.kja)
		{
			Toggle toggle = this.transparentToggle;
			if (toggle != null)
			{
				toggle.onValueChanged.AddListener(new UnityAction<bool>(this.gvq));
			}
			Slider slider = this.alphaSlider;
			if (slider != null)
			{
				slider.onValueChanged.AddListener(new UnityAction<float>(this.gvr));
			}
			Toggle toggle2 = this.topmostToggle;
			if (toggle2 != null)
			{
				toggle2.onValueChanged.AddListener(new UnityAction<bool>(this.gvs));
			}
			Toggle toggle3 = this.bottommostToggle;
			if (toggle3 != null)
			{
				toggle3.onValueChanged.AddListener(new UnityAction<bool>(this.gvt));
			}
			Toggle toggle4 = this.zoomedToggle;
			if (toggle4 != null)
			{
				toggle4.onValueChanged.AddListener(new UnityAction<bool>(this.gvu));
			}
			Toggle toggle5 = this.allowDropToggle;
			if (toggle5 != null)
			{
				toggle5.onValueChanged.AddListener(new UnityAction<bool>(this.gvv));
			}
			Dropdown dropdown = this.fitWindowDropdown;
			if (dropdown != null)
			{
				dropdown.onValueChanged.AddListener(new UnityAction<int>(this.gvw));
			}
			Button button = this.widthDownButton;
			if (button != null)
			{
				button.onClick.AddListener(new UnityAction(this.gvx));
			}
			Button button2 = this.widthUpButton;
			if (button2 != null)
			{
				button2.onClick.AddListener(new UnityAction(this.gvy));
			}
			Button button3 = this.heightDownButton;
			if (button3 != null)
			{
				button3.onClick.AddListener(new UnityAction(this.gvz));
			}
			Button button4 = this.heightUpButton;
			if (button4 != null)
			{
				button4.onClick.AddListener(new UnityAction(this.gwa));
			}
			Toggle toggle6 = this.clickThroughToggle;
			if (toggle6 != null)
			{
				toggle6.onValueChanged.AddListener(new UnityAction<bool>(this.gwb));
			}
			Dropdown dropdown2 = this.transparentTypeDropdown;
			if (dropdown2 != null)
			{
				dropdown2.onValueChanged.AddListener(new UnityAction<int>(this.gwc));
			}
			Dropdown dropdown3 = this.hitTestTypeDropdown;
			if (dropdown3 != null)
			{
				dropdown3.onValueChanged.AddListener(new UnityAction<int>(this.gwd));
			}
			Button button5 = this.menuCloseButton;
			if (button5 != null)
			{
				button5.onClick.AddListener(new UnityAction(this.gvk));
			}
			if (this.kjb)
			{
				Toggle toggle7 = this.dragMoveToggle;
				if (toggle7 != null)
				{
					toggle7.onValueChanged.AddListener(new UnityAction<bool>(this.gwe));
				}
			}
			this.kja.OnStateChanged += this.gwf;
			this.kja.OnMonitorChanged += this.gwg;
			this.kja.OnDropFiles += this.gwh;
		}
		Toggle toggle8 = this.showBorderlineToggle;
		if (toggle8 == null)
		{
			return;
		}
		toggle8.onValueChanged.AddListener(new UnityAction<bool>(this.gwi));
	}

	// Token: 0x0600262E RID: 9774 RVA: 0x0009F6AD File Offset: 0x0009D8AD
	[CompilerGenerated]
	private void gwb(bool a)
	{
		this.kja.isClickThrough = a;
	}

	// Token: 0x0600262F RID: 9775 RVA: 0x0009F6BC File Offset: 0x0009D8BC
	public void bvk()
	{
		if (this.kja)
		{
			if (this.clickThroughToggle)
			{
				this.clickThroughToggle.SetIsOnWithoutNotify(this.kja.isClickThrough);
				if (this.kja.hitTestType == UniWindowController.HitTestType.None)
				{
					this.clickThroughToggle.interactable = true;
				}
				else
				{
					this.clickThroughToggle.interactable = false;
				}
			}
			if (this.kja.hitTestType == UniWindowController.HitTestType.Opacity && this.kja.isTransparent)
			{
				if (this.pickedColorImage)
				{
					this.pickedColorImage.color = this.kja.pickedColor;
				}
				if (this.pickedColorText)
				{
					this.pickedColorText.text = string.Format(a.fbj(), this.kja.pickedColor.a);
					this.pickedColorText.color = Color.black;
					return;
				}
			}
			else
			{
				if (this.pickedColorImage)
				{
					this.pickedColorImage.color = Color.gray;
				}
				if (this.pickedColorText)
				{
					this.pickedColorText.text = a.fbk();
					this.pickedColorText.color = Color.gray;
				}
			}
		}
	}

	// Token: 0x06002630 RID: 9776 RVA: 0x0009F7FC File Offset: 0x0009D9FC
	private void exj(Vector2 a)
	{
		if (this.menuPanel)
		{
			Vector2 vector = a * (this.kjc.sizeDelta.x / (float)Screen.width);
			float width = this.menuPanel.rect.width;
			float height = this.menuPanel.rect.height;
			vector.y = Mathf.Max(Mathf.Min(vector.y, (float)Screen.height - height / -1882f), height / -2993f);
			vector.x = Mathf.Max(Mathf.Min(vector.x, (float)Screen.width - width / -5903f), width / 2219f);
			this.menuPanel.pivot = Vector2.one * -4107f;
			this.menuPanel.anchorMin = Vector2.zero;
			this.menuPanel.anchorMax = Vector2.zero;
			this.menuPanel.anchoredPosition = vector;
			this.menuPanel.gameObject.SetActive(true);
		}
	}

	// Token: 0x06002631 RID: 9777 RVA: 0x0009F90E File Offset: 0x0009DB0E
	[CompilerGenerated]
	private void gwa()
	{
		this.kja.windowSize += new Vector2(0f, 100f);
	}

	// Token: 0x06002632 RID: 9778 RVA: 0x0009F938 File Offset: 0x0009DB38
	private void jfm(int a)
	{
		if (!this.kja)
		{
			return;
		}
		if (a < 1)
		{
			this.kja.shouldFitMonitor = false;
			if (this.zoomedToggle)
			{
				this.zoomedToggle.interactable = true;
				return;
			}
		}
		else
		{
			this.kja.monitorToFit = a - 1;
			this.kja.shouldFitMonitor = true;
			if (this.zoomedToggle)
			{
				this.zoomedToggle.interactable = false;
			}
		}
	}

	// Token: 0x06002633 RID: 9779 RVA: 0x0009F9B0 File Offset: 0x0009DBB0
	[CompilerGenerated]
	private void gvq(bool a)
	{
		this.kja.isTransparent = a;
	}

	// Token: 0x06002634 RID: 9780 RVA: 0x0009F9BE File Offset: 0x0009DBBE
	[CompilerGenerated]
	private void gwg()
	{
		this.gvn();
		this.gvl();
		this.gvf(a.fbl());
		this.gvp();
	}

	// Token: 0x06002635 RID: 9781 RVA: 0x0009EC7C File Offset: 0x0009CE7C
	[CompilerGenerated]
	private void gwh(string[] a)
	{
		this.gvf(string.Join(Environment.NewLine, a));
	}

	// Token: 0x06002636 RID: 9782 RVA: 0x0009F9E0 File Offset: 0x0009DBE0
	public void mfy()
	{
		if (!this.kja)
		{
			return;
		}
		string text = a.fbm() + this.kja.clientSize.ToString();
		if (this.clientSizeText)
		{
			this.clientSizeText.text = text;
			return;
		}
		Debug.Log(text);
	}

	// Token: 0x06002637 RID: 9783 RVA: 0x0009FA40 File Offset: 0x0009DC40
	private void ohq()
	{
		this.gvm();
		if (this.kjg + this.kjh < Time.time)
		{
			this.gvi();
		}
		if (lr.gxj(1))
		{
			this.kjf = lr.mgy;
			this.gvg();
		}
		if (lr.gxi(1))
		{
			this.kjd += (lr.mgy - this.kjf).sqrMagnitude;
		}
		if (lr.gxk(1))
		{
			if (this.kjd < this.kje)
			{
				this.gvj(this.kjf);
			}
			this.kjd = 1289f;
			this.gvg();
		}
		if (Input.touchSupported && Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			if (touch.phase == TouchPhase.Began)
			{
				this.kjf = Input.mousePosition;
				this.gvg();
			}
			if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
			{
				this.kjd += touch.deltaPosition.sqrMagnitude;
				this.kji += touch.deltaTime;
			}
			if (touch.phase == TouchPhase.Ended)
			{
				if (this.kjd < this.kje && this.kji >= this.kjj)
				{
					this.gvj(this.kjf);
				}
				this.kjd = -2359f;
				this.gvg();
			}
		}
		if (lr.gxg(a.fbn()))
		{
			FilePanel.OpenFilePanel(new FilePanel.Settings
			{
				flags = FilePanel.Flag.AllowMultipleSelection,
				title = a.fbo(),
				filters = new FilePanel.Filter[]
				{
					new FilePanel.Filter(a.fbp(), new string[]
					{
						a.fbq(),
						a.fbr(),
						a.fbs()
					}),
					new FilePanel.Filter(a.fbt(), new string[] { a.fbu() })
				},
				initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Resources),
				initialFile = a.fbv()
			}, new Action<string[]>(this.gwj));
		}
		if (lr.gxg(a.fbw()))
		{
			FilePanel.SaveFilePanel(new FilePanel.Settings
			{
				flags = FilePanel.Flag.AllowMultipleSelection,
				title = a.fbx(),
				filters = new FilePanel.Filter[0],
				initialFile = a.fby(),
				initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
			}, new Action<string[]>(this.gwk));
		}
		if (lr.gxg(a.fbz()))
		{
			Application.Quit();
		}
	}

	// Token: 0x06002638 RID: 9784 RVA: 0x0009FCC8 File Offset: 0x0009DEC8
	private void gvg()
	{
		this.kji = 0f;
	}

	// Token: 0x06002639 RID: 9785 RVA: 0x0009FCD5 File Offset: 0x0009DED5
	[CompilerGenerated]
	private void gvz()
	{
		this.kja.windowSize += new Vector2(0f, -100f);
	}

	// Token: 0x0600263A RID: 9786 RVA: 0x0009FCFC File Offset: 0x0009DEFC
	public void gvm()
	{
		if (this.kja)
		{
			if (this.clickThroughToggle)
			{
				this.clickThroughToggle.SetIsOnWithoutNotify(this.kja.isClickThrough);
				if (this.kja.hitTestType == UniWindowController.HitTestType.None)
				{
					this.clickThroughToggle.interactable = true;
				}
				else
				{
					this.clickThroughToggle.interactable = false;
				}
			}
			if (this.kja.hitTestType == UniWindowController.HitTestType.Opacity && this.kja.isTransparent)
			{
				if (this.pickedColorImage)
				{
					this.pickedColorImage.color = this.kja.pickedColor;
				}
				if (this.pickedColorText)
				{
					this.pickedColorText.text = string.Format(a.fca(), this.kja.pickedColor.a);
					this.pickedColorText.color = Color.black;
					return;
				}
			}
			else
			{
				if (this.pickedColorImage)
				{
					this.pickedColorImage.color = Color.gray;
				}
				if (this.pickedColorText)
				{
					this.pickedColorText.text = a.fcb();
					this.pickedColorText.color = Color.gray;
				}
			}
		}
	}

	// Token: 0x0600263B RID: 9787 RVA: 0x0009FE3C File Offset: 0x0009E03C
	public void hjq()
	{
		if (this.kja)
		{
			if (this.clickThroughToggle)
			{
				this.clickThroughToggle.SetIsOnWithoutNotify(this.kja.isClickThrough);
				if (this.kja.hitTestType == UniWindowController.HitTestType.None)
				{
					this.clickThroughToggle.interactable = true;
				}
				else
				{
					this.clickThroughToggle.interactable = false;
				}
			}
			if (this.kja.hitTestType == UniWindowController.HitTestType.Opacity && this.kja.isTransparent)
			{
				if (this.pickedColorImage)
				{
					this.pickedColorImage.color = this.kja.pickedColor;
				}
				if (this.pickedColorText)
				{
					this.pickedColorText.text = string.Format(a.fcc(), this.kja.pickedColor.a);
					this.pickedColorText.color = Color.black;
					return;
				}
			}
			else
			{
				if (this.pickedColorImage)
				{
					this.pickedColorImage.color = Color.gray;
				}
				if (this.pickedColorText)
				{
					this.pickedColorText.text = a.fcd();
					this.pickedColorText.color = Color.gray;
				}
			}
		}
	}

	// Token: 0x0600263C RID: 9788 RVA: 0x0009FF79 File Offset: 0x0009E179
	[CompilerGenerated]
	private void gwi(bool a)
	{
		this.borderlinePanel.gameObject.SetActive(a);
	}

	// Token: 0x0600263D RID: 9789 RVA: 0x0009FF8C File Offset: 0x0009E18C
	private void ks()
	{
		if (this.kja)
		{
			Vector2 windowPosition = this.kja.windowPosition;
			this.gvo(string.Concat(new string[]
			{
				a.fce(),
				windowPosition.ToString(),
				a.fcf(),
				this.kja.windowSize.ToString(),
				a.fcg(),
				(this.kja.cursorPosition - windowPosition).ToString(),
				a.fch(),
				lr.mgy.ToString()
			}));
			this.gvp();
		}
	}

	// Token: 0x0600263E RID: 9790 RVA: 0x000A0055 File Offset: 0x0009E255
	[CompilerGenerated]
	private void gvv(bool a)
	{
		this.kja.allowDropFiles = a;
	}

	// Token: 0x0600263F RID: 9791 RVA: 0x000A0063 File Offset: 0x0009E263
	[CompilerGenerated]
	private void gwf(UniWindowController.WindowStateEventType a)
	{
		this.gvl();
		this.gvf(a.fci() + a.ToString());
		this.gvp();
	}

	// Token: 0x06002640 RID: 9792 RVA: 0x000A0090 File Offset: 0x0009E290
	private void env(int a)
	{
		if (!this.kja)
		{
			return;
		}
		if (a < 1)
		{
			this.kja.shouldFitMonitor = false;
			if (this.zoomedToggle)
			{
				this.zoomedToggle.interactable = true;
				return;
			}
		}
		else
		{
			this.kja.monitorToFit = a - 1;
			this.kja.shouldFitMonitor = true;
			if (this.zoomedToggle)
			{
				this.zoomedToggle.interactable = false;
			}
		}
	}

	// Token: 0x06002641 RID: 9793 RVA: 0x0009EC7C File Offset: 0x0009CE7C
	[CompilerGenerated]
	private void gwj(string[] a)
	{
		this.gvf(string.Join(Environment.NewLine, a));
	}

	// Token: 0x06002642 RID: 9794 RVA: 0x000A0108 File Offset: 0x0009E308
	private void olf()
	{
		this.gvm();
		if (this.kjg + this.kjh < Time.time)
		{
			this.gvi();
		}
		if (lr.gxj(1))
		{
			this.kjf = lr.mgy;
			this.gvg();
		}
		if (lr.gxi(1))
		{
			this.kjd += (lr.mgy - this.kjf).sqrMagnitude;
		}
		if (lr.gxk(1))
		{
			if (this.kjd < this.kje)
			{
				this.gvj(this.kjf);
			}
			this.kjd = 6069f;
			this.gvg();
		}
		if (Input.touchSupported && Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			if (touch.phase == TouchPhase.Began)
			{
				this.kjf = Input.mousePosition;
				this.gvg();
			}
			if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
			{
				this.kjd += touch.deltaPosition.sqrMagnitude;
				this.kji += touch.deltaTime;
			}
			if (touch.phase == TouchPhase.Ended)
			{
				if (this.kjd < this.kje && this.kji >= this.kjj)
				{
					this.gvj(this.kjf);
				}
				this.kjd = -570f;
				this.gvg();
			}
		}
		if (lr.gxg(a.fcj()))
		{
			FilePanel.OpenFilePanel(new FilePanel.Settings
			{
				flags = FilePanel.Flag.AllowMultipleSelection,
				title = a.fck(),
				filters = new FilePanel.Filter[]
				{
					new FilePanel.Filter(a.fcl(), new string[]
					{
						a.fcm(),
						a.fcn(),
						a.fco()
					}),
					new FilePanel.Filter(a.fcp(), new string[] { a.fcq() })
				},
				initialDirectory = Environment.GetFolderPath((Environment.SpecialFolder)94),
				initialFile = a.fcr()
			}, new Action<string[]>(this.gwj));
		}
		if (lr.gxg(a.fcs()))
		{
			FilePanel.SaveFilePanel(new FilePanel.Settings
			{
				flags = FilePanel.Flag.AllowMultipleSelection,
				title = a.fct(),
				filters = new FilePanel.Filter[0],
				initialFile = a.fcu(),
				initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
			}, new Action<string[]>(this.gwk));
		}
		if (lr.gxg(a.fcv()))
		{
			Application.Quit();
		}
	}

	// Token: 0x06002643 RID: 9795 RVA: 0x000A0390 File Offset: 0x0009E590
	private void ojb()
	{
		if (this.kja)
		{
			Vector2 windowPosition = this.kja.windowPosition;
			this.gvo(string.Concat(new string[]
			{
				a.fcw(),
				windowPosition.ToString(),
				a.fcx(),
				this.kja.windowSize.ToString(),
				a.fcy(),
				(this.kja.cursorPosition - windowPosition).ToString(),
				a.fcz(),
				lr.mgy.ToString()
			}));
			this.gvp();
		}
	}

	// Token: 0x06002644 RID: 9796 RVA: 0x000A0459 File Offset: 0x0009E659
	[CompilerGenerated]
	private void gwe(bool a)
	{
		this.kjb.enabled = a;
	}

	// Token: 0x06002645 RID: 9797 RVA: 0x000A0467 File Offset: 0x0009E667
	[CompilerGenerated]
	private void gvr(float a)
	{
		this.kja.alphaValue = a;
	}

	// Token: 0x06002646 RID: 9798 RVA: 0x0009EC30 File Offset: 0x0009CE30
	private void ipi(string a)
	{
		this.kjg = Time.time;
		if (this.messageText)
		{
			this.messageText.text = a;
		}
		Debug.Log(a);
	}

	// Token: 0x06002647 RID: 9799 RVA: 0x000A0478 File Offset: 0x0009E678
	public void dqz()
	{
		if (this.kja)
		{
			if (this.clickThroughToggle)
			{
				this.clickThroughToggle.SetIsOnWithoutNotify(this.kja.isClickThrough);
				if (this.kja.hitTestType == UniWindowController.HitTestType.None)
				{
					this.clickThroughToggle.interactable = true;
				}
				else
				{
					this.clickThroughToggle.interactable = false;
				}
			}
			if (this.kja.hitTestType == UniWindowController.HitTestType.Opacity && this.kja.isTransparent)
			{
				if (this.pickedColorImage)
				{
					this.pickedColorImage.color = this.kja.pickedColor;
				}
				if (this.pickedColorText)
				{
					this.pickedColorText.text = string.Format(a.fda(), this.kja.pickedColor.a);
					this.pickedColorText.color = Color.black;
					return;
				}
			}
			else
			{
				if (this.pickedColorImage)
				{
					this.pickedColorImage.color = Color.gray;
				}
				if (this.pickedColorText)
				{
					this.pickedColorText.text = a.fdb();
					this.pickedColorText.color = Color.gray;
				}
			}
		}
	}

	// Token: 0x06002648 RID: 9800 RVA: 0x000A05B8 File Offset: 0x0009E7B8
	private void brs()
	{
		if (this.kja)
		{
			if (this.transparentToggle)
			{
				this.transparentToggle.SetIsOnWithoutNotify(this.kja.isTransparent);
			}
			if (this.alphaSlider)
			{
				this.alphaSlider.SetValueWithoutNotify(this.kja.alphaValue);
			}
			if (this.topmostToggle)
			{
				this.topmostToggle.SetIsOnWithoutNotify(this.kja.isTopmost);
			}
			if (this.bottommostToggle)
			{
				this.bottommostToggle.SetIsOnWithoutNotify(this.kja.isBottommost);
			}
			if (this.zoomedToggle)
			{
				this.zoomedToggle.SetIsOnWithoutNotify(this.kja.isZoomed);
			}
			if (this.allowDropToggle)
			{
				this.allowDropToggle.SetIsOnWithoutNotify(this.kja.allowDropFiles);
			}
			if (this.dragMoveToggle)
			{
				this.dragMoveToggle.isOn = this.kjb && this.kjb.isActiveAndEnabled;
			}
			if (this.fitWindowDropdown)
			{
				if (this.kja.shouldFitMonitor)
				{
					this.fitWindowDropdown.value = this.kja.monitorToFit + 1;
					if (this.zoomedToggle)
					{
						this.zoomedToggle.interactable = false;
					}
				}
				else
				{
					this.fitWindowDropdown.value = 0;
					if (this.zoomedToggle)
					{
						this.zoomedToggle.interactable = true;
					}
				}
				this.fitWindowDropdown.RefreshShownValue();
			}
			if (this.transparentTypeDropdown)
			{
				this.transparentTypeDropdown.value = (int)this.kja.transparentType;
				this.transparentTypeDropdown.RefreshShownValue();
			}
			if (this.hitTestTypeDropdown)
			{
				this.hitTestTypeDropdown.value = (int)this.kja.hitTestType;
				this.hitTestTypeDropdown.RefreshShownValue();
			}
			this.gvm();
		}
		if (this.showBorderlineToggle && this.borderlinePanel)
		{
			this.borderlinePanel.gameObject.SetActive(this.showBorderlineToggle.isOn);
		}
	}

	// Token: 0x0600264A RID: 9802 RVA: 0x0009EC5C File Offset: 0x0009CE5C
	private void dqt()
	{
		if (this.menuPanel)
		{
			this.menuPanel.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600264B RID: 9803 RVA: 0x000A0824 File Offset: 0x0009EA24
	private void gvn()
	{
		if (!this.fitWindowDropdown)
		{
			return;
		}
		this.fitWindowDropdown.options.RemoveRange(1, this.fitWindowDropdown.options.Count - 1);
		if (!this.kja)
		{
			this.fitWindowDropdown.value = 0;
			return;
		}
		int monitorCount = UniWindowController.GetMonitorCount();
		for (int i = 0; i < monitorCount; i++)
		{
			this.fitWindowDropdown.options.Add(new Dropdown.OptionData(a.fdc() + i.ToString()));
		}
		if (this.kja.monitorToFit >= monitorCount)
		{
			this.kja.monitorToFit = monitorCount - 1;
		}
	}

	// Token: 0x0600264C RID: 9804 RVA: 0x0009EC5C File Offset: 0x0009CE5C
	private void fcz()
	{
		if (this.menuPanel)
		{
			this.menuPanel.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600264D RID: 9805 RVA: 0x000A08D0 File Offset: 0x0009EAD0
	private void gvh(int a)
	{
		if (!this.kja)
		{
			return;
		}
		if (a < 1)
		{
			this.kja.shouldFitMonitor = false;
			if (this.zoomedToggle)
			{
				this.zoomedToggle.interactable = true;
				return;
			}
		}
		else
		{
			this.kja.monitorToFit = a - 1;
			this.kja.shouldFitMonitor = true;
			if (this.zoomedToggle)
			{
				this.zoomedToggle.interactable = false;
			}
		}
	}

	// Token: 0x0600264E RID: 9806 RVA: 0x000A0948 File Offset: 0x0009EB48
	[CompilerGenerated]
	private void gwc(int a)
	{
		this.kja.SetTransparentType((UniWindowController.TransparentType)a);
	}

	// Token: 0x0600264F RID: 9807 RVA: 0x000A0958 File Offset: 0x0009EB58
	private void hgu(Vector2 a)
	{
		if (this.menuPanel)
		{
			Vector2 vector = a * (this.kjc.sizeDelta.x / (float)Screen.width);
			float width = this.menuPanel.rect.width;
			float height = this.menuPanel.rect.height;
			vector.y = Mathf.Max(Mathf.Min(vector.y, (float)Screen.height - height / -4699f), height / 9395f);
			vector.x = Mathf.Max(Mathf.Min(vector.x, (float)Screen.width - width / 6670f), width / 7059f);
			this.menuPanel.pivot = Vector2.one * -9067f;
			this.menuPanel.anchorMin = Vector2.zero;
			this.menuPanel.anchorMax = Vector2.zero;
			this.menuPanel.anchoredPosition = vector;
			this.menuPanel.gameObject.SetActive(true);
		}
	}

	// Token: 0x06002650 RID: 9808 RVA: 0x000A0A6A File Offset: 0x0009EC6A
	[CompilerGenerated]
	private void gvu(bool a)
	{
		this.kja.isZoomed = a;
	}

	// Token: 0x06002651 RID: 9809 RVA: 0x000A0A78 File Offset: 0x0009EC78
	private void OnApplicationFocus(bool hasFocus)
	{
		if (hasFocus)
		{
			this.gvl();
			if (this.kja)
			{
				this.gvo(a.fdd());
				return;
			}
			this.gvo(a.fde());
		}
	}

	// Token: 0x06002652 RID: 9810 RVA: 0x0009EF26 File Offset: 0x0009D126
	public void bdg(string a)
	{
		if (this.messageText)
		{
			this.messageText.text = a;
			return;
		}
		Debug.Log(a);
	}

	// Token: 0x06002653 RID: 9811 RVA: 0x000A0AA8 File Offset: 0x0009ECA8
	private void mty()
	{
		if (!this.fitWindowDropdown)
		{
			return;
		}
		this.fitWindowDropdown.options.RemoveRange(1, this.fitWindowDropdown.options.Count - 1);
		if (!this.kja)
		{
			this.fitWindowDropdown.value = 0;
			return;
		}
		int monitorCount = UniWindowController.GetMonitorCount();
		for (int i = 0; i < monitorCount; i++)
		{
			this.fitWindowDropdown.options.Add(new Dropdown.OptionData(a.fdf() + i.ToString()));
		}
		if (this.kja.monitorToFit >= monitorCount)
		{
			this.kja.monitorToFit = monitorCount - 1;
		}
	}

	// Token: 0x06002654 RID: 9812 RVA: 0x0009EC30 File Offset: 0x0009CE30
	private void gki(string a)
	{
		this.kjg = Time.time;
		if (this.messageText)
		{
			this.messageText.text = a;
		}
		Debug.Log(a);
	}

	// Token: 0x06002655 RID: 9813 RVA: 0x000A0B54 File Offset: 0x0009ED54
	public void gvp()
	{
		if (!this.kja)
		{
			return;
		}
		string text = a.fdg() + this.kja.clientSize.ToString();
		if (this.clientSizeText)
		{
			this.clientSizeText.text = text;
			return;
		}
		Debug.Log(text);
	}

	// Token: 0x06002656 RID: 9814 RVA: 0x000A0BB4 File Offset: 0x0009EDB4
	public void hzy()
	{
		if (!this.kja)
		{
			return;
		}
		string text = a.fdh() + this.kja.clientSize.ToString();
		if (this.clientSizeText)
		{
			this.clientSizeText.text = text;
			return;
		}
		Debug.Log(text);
	}

	// Token: 0x06002657 RID: 9815 RVA: 0x000A0C14 File Offset: 0x0009EE14
	private void hfy(Vector2 a)
	{
		if (this.menuPanel)
		{
			Vector2 vector = a * (this.kjc.sizeDelta.x / (float)Screen.width);
			float width = this.menuPanel.rect.width;
			float height = this.menuPanel.rect.height;
			vector.y = Mathf.Max(Mathf.Min(vector.y, (float)Screen.height - height / -8165f), height / -9459f);
			vector.x = Mathf.Max(Mathf.Min(vector.x, (float)Screen.width - width / -1959f), width / -6900f);
			this.menuPanel.pivot = Vector2.one * 5048f;
			this.menuPanel.anchorMin = Vector2.zero;
			this.menuPanel.anchorMax = Vector2.zero;
			this.menuPanel.anchoredPosition = vector;
			this.menuPanel.gameObject.SetActive(true);
		}
	}

	// Token: 0x04001287 RID: 4743
	private UniWindowController kja;

	// Token: 0x04001288 RID: 4744
	private UniWindowMoveHandle kjb;

	// Token: 0x04001289 RID: 4745
	private RectTransform kjc;

	// Token: 0x0400128A RID: 4746
	private float kjd;

	// Token: 0x0400128B RID: 4747
	private float kje = 36f;

	// Token: 0x0400128C RID: 4748
	private Vector3 kjf;

	// Token: 0x0400128D RID: 4749
	private float kjg = -5f;

	// Token: 0x0400128E RID: 4750
	private float kjh = 1f;

	// Token: 0x0400128F RID: 4751
	private float kji;

	// Token: 0x04001290 RID: 4752
	private float kjj = 0.5f;

	// Token: 0x04001291 RID: 4753
	public Toggle transparentToggle;

	// Token: 0x04001292 RID: 4754
	public Slider alphaSlider;

	// Token: 0x04001293 RID: 4755
	public Toggle topmostToggle;

	// Token: 0x04001294 RID: 4756
	public Toggle bottommostToggle;

	// Token: 0x04001295 RID: 4757
	[FormerlySerializedAs("maximizedToggle")]
	public Toggle zoomedToggle;

	// Token: 0x04001296 RID: 4758
	public Toggle dragMoveToggle;

	// Token: 0x04001297 RID: 4759
	public Toggle allowDropToggle;

	// Token: 0x04001298 RID: 4760
	public Dropdown fitWindowDropdown;

	// Token: 0x04001299 RID: 4761
	public Toggle showBorderlineToggle;

	// Token: 0x0400129A RID: 4762
	public Button widthDownButton;

	// Token: 0x0400129B RID: 4763
	public Button widthUpButton;

	// Token: 0x0400129C RID: 4764
	public Button heightDownButton;

	// Token: 0x0400129D RID: 4765
	public Button heightUpButton;

	// Token: 0x0400129E RID: 4766
	public Dropdown transparentTypeDropdown;

	// Token: 0x0400129F RID: 4767
	public Dropdown hitTestTypeDropdown;

	// Token: 0x040012A0 RID: 4768
	public Toggle clickThroughToggle;

	// Token: 0x040012A1 RID: 4769
	public Image pickedColorImage;

	// Token: 0x040012A2 RID: 4770
	public Text pickedColorText;

	// Token: 0x040012A3 RID: 4771
	public Text messageText;

	// Token: 0x040012A4 RID: 4772
	public Text clientSizeText;

	// Token: 0x040012A5 RID: 4773
	public Button menuCloseButton;

	// Token: 0x040012A6 RID: 4774
	public RectTransform menuPanel;

	// Token: 0x040012A7 RID: 4775
	public RectTransform borderlinePanel;
}
