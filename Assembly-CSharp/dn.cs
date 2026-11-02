using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using BongoWaifu.AiApi;
using BongoWaifu.Mcp;
using BongoWaifu.Mcp.SpeechBubble;
using BongoWaifu.Multiplayer;
using FMODUnity;
using GlobalKeyboardHook;
using Kirurobo;
using RamenCat;
using Steamworks;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

// Token: 0x0200009C RID: 156
public class dn : MonoBehaviour
{
	// Token: 0x060006EE RID: 1774 RVA: 0x0002668E File Offset: 0x0002488E
	private void byf(int a)
	{
		if (!Enum.IsDefined(typeof(DirtinessMode), a))
		{
			return;
		}
		bq.hmb = (DirtinessMode)a;
		PlayerPrefs.SetInt(a.rp(), a);
		PlayerPrefs.Save();
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x000266BE File Offset: 0x000248BE
	public void gwc(BaseEventData a)
	{
		PlayerPrefs.SetFloat(a.bky(), this.sliderBMG.value);
		PlayerPrefs.Save();
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x000266DA File Offset: 0x000248DA
	public void bvp(bool a)
	{
		bq.hlk = false;
		this.windowDragHandler.enableAutoSnap = a;
		PlayerPrefs.SetInt(a.bkz(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00026704 File Offset: 0x00024904
	public void bxe(bool a)
	{
		bq.hlk = false;
		bq.hlw = a;
		if (this.hotkeyHintPanel != null)
		{
			this.hotkeyHintPanel.SetActive(a);
		}
		this.bxk();
		PlayerPrefs.SetInt(a.sy(), a ? 1 : 0);
		PlayerPrefs.Save();
		if (a)
		{
			WinGlobalHotkey.ctp();
			return;
		}
		WinGlobalHotkey.ctq();
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x00026764 File Offset: 0x00024964
	private void bux()
	{
		if (this.objGameCompatRoot != null)
		{
			this.objGameCompatRoot.SetActive(true);
		}
		if (this.btnOpenCustomGameList != null)
		{
			this.btnOpenCustomGameList.onClick.AddListener(new UnityAction(this.buy));
		}
		if (this.objAdminModeRoot != null)
		{
			this.objAdminModeRoot.SetActive(true);
		}
		if (this.toggleAdminMode != null)
		{
			this.toggleAdminMode.SetIsOnWithoutNotify(d.mc());
			this.toggleAdminMode.onValueChanged.AddListener(new UnityAction<bool>(this.bva));
		}
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x0002680C File Offset: 0x00024A0C
	private void buy()
	{
		try
		{
			dz.cgu();
			Application.OpenURL(new Uri(dz.cgt()).AbsoluteUri);
			if (this.btnOpenCustomGameList != null)
			{
				this.btnOpenCustomGameList.interactable = false;
				base.StartCoroutine(this.buz(1f));
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.bla() + ex.Message);
		}
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x00026888 File Offset: 0x00024A88
	private void gjm()
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		string text = this.cab(playerSaveData.directApiProviderId);
		if (string.IsNullOrEmpty(text))
		{
			this.bzx(dn.byy(a.blb(), a.blc()));
			return;
		}
		int directApiProviderId = playerSaveData.directApiProviderId;
		AiProviderConfig aiProviderConfig = AiProviderCatalog.For((AiProviderId)directApiProviderId);
		string text2 = ((aiProviderConfig.AllowsCustomBaseUrl && !string.IsNullOrEmpty(playerSaveData.directApiBaseUrl)) ? playerSaveData.directApiBaseUrl : aiProviderConfig.DefaultBaseUrl);
		IAiChatAdapter aiChatAdapter = AiAdapterFactory.Create((AiProviderId)directApiProviderId);
		this.bzx(dn.byy(a.bld(), a.ble()));
		AiRequestRunner.Instance.FetchModels(aiChatAdapter, aiProviderConfig, text2, text, 19, new Action<AiModelList>(this.bzk));
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x00026950 File Offset: 0x00024B50
	private void kld(string a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		playerSaveData.directApiBaseUrl = (a ?? a.blf()).Trim();
		ci.Save(null);
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x000269A0 File Offset: 0x00024BA0
	public void bvb()
	{
		bq.hlo = PlayerPrefs.GetInt(a.blg(), 0);
		bq.hlp = PlayerPrefs.GetInt(a.blh(), 2);
		bq.hlq = PlayerPrefs.GetInt(a.bli(), 2);
		bq.hlr = PlayerPrefs.GetInt(a.blj(), 2);
		bq.hls = PlayerPrefs.GetInt(a.blk(), 1) == 1;
		bq.hlt = PlayerPrefs.GetInt(a.bll(), 0) == 1;
		bq.hlu = PlayerPrefs.GetInt(a.blm(), 0) == 1;
		bq.hlv = PlayerPrefs.GetInt(a.bln(), 0) == 1;
		this.toggleTop.SetIsOnWithoutNotify(bq.hls);
		this.toggleFlip.SetIsOnWithoutNotify(bq.hlt);
		this.toggleLockPosition.SetIsOnWithoutNotify(bq.hlu);
		if (bq.hlu)
		{
			CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
			if (characterDragTarget != null)
			{
				characterDragTarget.bhb();
			}
		}
		this.bwv(bq.hlu);
		if (this.toggleAutoHideDownUI != null)
		{
			this.toggleAutoHideDownUI.gameObject.SetActive(true);
			this.toggleAutoHideDownUI.SetIsOnWithoutNotify(bq.hlv);
		}
		bq.hlw = PlayerPrefs.GetInt(a.sy(), 1) == 1;
		if (this.toggleHotkey != null)
		{
			this.toggleHotkey.isOn = bq.hlw;
		}
		if (this.hotkeyHintPanel != null)
		{
			this.hotkeyHintPanel.SetActive(bq.hlw);
		}
		this.bxk();
		bq.hlx = PlayerPrefs.GetInt(a.blo(), 1) == 1;
		if (this.toggleRightClickQuickMenu != null)
		{
			this.toggleRightClickQuickMenu.SetIsOnWithoutNotify(bq.hlx);
		}
		this.bvk();
		this.bvl();
		this.bvr();
		this.bwc();
		this.bxc();
		this.bwf();
		this.bxl();
		this.bxv();
		this.bxy();
		this.byc();
		this.bxf();
		this.bxh();
		this.byg();
		this.bvg();
		this.byw();
		try
		{
			this.bzb();
		}
		catch (Exception ex)
		{
			string text = a.blp();
			Exception ex2 = ex;
			Debug.LogError(text + ((ex2 != null) ? ex2.ToString() : null));
		}
		this.hxr = base.GetComponentsInChildren<bb>(true);
		this.bvc();
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x00026BE4 File Offset: 0x00024DE4
	public void mcr()
	{
		bq.hlk = false;
		int monitorCount = UniWindowController.GetMonitorCount();
		if (monitorCount <= 1)
		{
			return;
		}
		int num = (UniWindowController.current.monitorToFit + 1) % monitorCount;
		if (UniWindowController.current.monitorToFit != num)
		{
			UniWindowController.current.MoveToMonitor(num);
		}
		bx.bcc(num);
		this.bvn();
		PlayerPrefs.SetInt(a.blq(), num);
		PlayerPrefs.Save();
		CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
		if (characterDragTarget != null)
		{
			characterDragTarget.bgy();
		}
		SettingPanel settingPanel = SettingPanel.kqq;
		if (settingPanel != null)
		{
			settingPanel.caw();
		}
		BgmPanelController bgmPanelController = ((cx.kpw != null) ? cx.kpw.bgmPanel : null);
		if (bgmPanelController != null)
		{
			bgmPanelController.bmt();
		}
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x00026C90 File Offset: 0x00024E90
	private void qj()
	{
		if (this.txtMonitor == null)
		{
			return;
		}
		int monitorToFit = UniWindowController.current.monitorToFit;
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.blr(), null);
		string text;
		if (table == null)
		{
			text = null;
		}
		else
		{
			StringTableEntry entry = table.GetEntry(a.bls());
			text = ((entry != null) ? entry.GetLocalizedString() : null);
		}
		string text2 = text ?? a.blt();
		this.txtMonitor.text = string.Format(a.blu(), text2, monitorToFit + 1);
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x00026D14 File Offset: 0x00024F14
	public void huq(int a)
	{
		if (!bq.hlw)
		{
			return;
		}
		bool flag = PlayerPrefs.GetInt(a.blv(), 0) != 0;
		float @float = PlayerPrefs.GetFloat(a.blw(), -7079f);
		if ((this.sliderSound != null && this.sliderSound.value > 6601f) || (this.sliderBMG != null && this.sliderBMG.value > 7896f) || (this.sliderSFX != null && this.sliderSFX.value > -651f) || (this.sliderVoice != null && this.sliderVoice.value > -5106f) || (flag && @float > -6259f))
		{
			this.hyc = ((this.sliderSound != null) ? this.sliderSound.value : 9895f);
			this.hyd = ((this.sliderBMG != null) ? this.sliderBMG.value : 5792f);
			this.hye = ((this.sliderSFX != null) ? this.sliderSFX.value : (-3214f));
			this.hyf = ((this.sliderVoice != null) ? this.sliderVoice.value : (-8677f));
			VolumeMuteButton volumeMuteButton = this.muteButtonBGM;
			if (volumeMuteButton != null)
			{
				volumeMuteButton.cbv();
			}
			VolumeMuteButton volumeMuteButton2 = this.muteButtonSound;
			if (volumeMuteButton2 != null)
			{
				volumeMuteButton2.cbv();
			}
			VolumeMuteButton volumeMuteButton3 = this.muteButtonSFX;
			if (volumeMuteButton3 != null)
			{
				volumeMuteButton3.cbv();
			}
			VolumeMuteButton volumeMuteButton4 = this.muteButtonVoice;
			if (volumeMuteButton4 != null)
			{
				volumeMuteButton4.cbv();
			}
			this.hyh = flag;
			if (flag)
			{
				this.hyg = @float;
				if (@float > 8782f)
				{
					PlayerPrefs.SetFloat(a.blx(), @float);
				}
				AudioManager audioManager = AudioManager.klw;
				if (audioManager != null)
				{
					audioManager.qn(-5033f, true);
				}
				PlayerPrefs.SetFloat(a.bly(), -1838f);
			}
			this.hyb = true;
		}
		else
		{
			if (!this.hyb)
			{
				return;
			}
			if (this.sliderSound != null)
			{
				this.sliderSound.value = this.hyc;
			}
			if (this.sliderBMG != null)
			{
				this.sliderBMG.value = this.hyd;
			}
			if (this.sliderSFX != null)
			{
				this.sliderSFX.value = this.hye;
			}
			if (this.sliderVoice != null)
			{
				this.sliderVoice.value = this.hyf;
			}
			if (this.hyh)
			{
				AudioManager audioManager2 = AudioManager.klw;
				if (audioManager2 != null)
				{
					audioManager2.qn(this.hyg, true);
				}
				PlayerPrefs.SetFloat(a.blz(), this.hyg);
			}
			this.hyb = false;
		}
		this.bvf();
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x00026FD8 File Offset: 0x000251D8
	private void hmp(int a)
	{
		if (a < 0 || a >= dn.FPSOptions.Length)
		{
			return;
		}
		int num = dn.FPSOptions[a];
		dn.bxu(num);
		PlayerPrefs.SetInt(a.bma(), num);
		PlayerPrefs.Save();
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00027012 File Offset: 0x00025212
	private void bxk()
	{
		if (this.hotkeyHintWindows != null)
		{
			this.hotkeyHintWindows.SetActive(true);
		}
		if (this.hotkeyHintMac != null)
		{
			this.hotkeyHintMac.SetActive(false);
		}
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00027048 File Offset: 0x00025248
	private void byw()
	{
		if (this.mcpOpenDocButton != null)
		{
			this.mcpOpenDocButton.onClick.AddListener(new UnityAction(this.cah));
		}
		if (this.mcpRetryButton != null)
		{
			this.mcpRetryButton.onClick.AddListener(new UnityAction(this.byx));
		}
		if (this.mcpFirstTimeTip != null)
		{
			this.mcpFirstTimeTip.SetActive(false);
		}
		this.UpdateMcpStatus();
		base.InvokeRepeating(a.bmb(), 1f, 1f);
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x000270E0 File Offset: 0x000252E0
	public static int bxt()
	{
		if (PlayerPrefs.HasKey(a.bmc()))
		{
			return PlayerPrefs.GetInt(a.bmc());
		}
		int num = Mathf.RoundToInt((float)Screen.currentResolution.refreshRateRatio.value);
		int num2 = 60;
		foreach (int num3 in dn.FPSOptions)
		{
			if (num3 != -1 && num3 <= num && num3 > num2)
			{
				num2 = num3;
			}
		}
		return num2;
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x00027157 File Offset: 0x00025357
	public void cdq()
	{
		bq.hlk = false;
		CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
		if (characterDragTarget == null)
		{
			return;
		}
		characterDragTarget.bgy();
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x00027170 File Offset: 0x00025370
	private void nax(string a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		string text = (a ?? a.bmd()).Trim();
		if (string.IsNullOrEmpty(text))
		{
			playerSaveData.directApiTemplateCustomized = false;
			playerSaveData.directApiPromptTemplate = a.bme();
			if (this.inputPromptTemplate != null)
			{
				this.inputPromptTemplate.text = AiPromptComposer.GetLocalizedDefaultTemplate();
			}
		}
		else
		{
			playerSaveData.directApiTemplateCustomized = true;
			playerSaveData.directApiPromptTemplate = text;
		}
		ci.Save(null);
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x00027200 File Offset: 0x00025400
	private void bvj(int a)
	{
		if (this.hyi)
		{
			return;
		}
		bq.hlk = false;
		List<Locale> locales = LocalizationSettings.AvailableLocales.Locales;
		if (a < 0 || a >= locales.Count)
		{
			return;
		}
		LocalizationSettings.SelectedLocale = locales[a];
		this.bwh();
		this.bvn();
		this.bxz();
		this.byd();
		this.bwq();
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00027260 File Offset: 0x00025460
	private void bvk()
	{
		int monitorCount = UniWindowController.GetMonitorCount();
		int num = PlayerPrefs.GetInt(a.bmf(), 0);
		if (monitorCount > 0 && num >= monitorCount)
		{
			num = 0;
			PlayerPrefs.SetInt(a.bmf(), num);
			PlayerPrefs.Save();
			Debug.Log(string.Format(a.bmg(), num));
		}
		if (monitorCount > 0)
		{
			if (UniWindowController.current.monitorToFit != num)
			{
				UniWindowController.current.MoveToMonitor(num);
			}
			bx.bcc(num);
			CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
			if (characterDragTarget != null)
			{
				characterDragTarget.bhb();
			}
		}
		this.bvn();
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x000272E8 File Offset: 0x000254E8
	private void bzo(int a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		playerSaveData.directApiChattinessTier = Mathf.Clamp(a, 0, 2);
		ci.Save(null);
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x00027330 File Offset: 0x00025530
	private void duj()
	{
		if (!bq.hlu)
		{
			return;
		}
		if (this.downUIController == null || !this.downUIController.kpx)
		{
			return;
		}
		if (this.dragImageRect == null)
		{
			return;
		}
		Vector2 vector = Input.mousePosition;
		if (RectTransformUtility.RectangleContainsScreenPoint(this.dragImageRect, vector))
		{
			this.downUIController.brk();
		}
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x00027394 File Offset: 0x00025594
	private void bvn()
	{
		if (this.txtMonitor == null)
		{
			return;
		}
		int monitorToFit = UniWindowController.current.monitorToFit;
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.rh(), null);
		string text;
		if (table == null)
		{
			text = null;
		}
		else
		{
			StringTableEntry entry = table.GetEntry(a.bmh());
			text = ((entry != null) ? entry.GetLocalizedString() : null);
		}
		string text2 = text ?? a.bmi();
		this.txtMonitor.text = string.Format(a.bmj(), text2, monitorToFit + 1);
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x00027418 File Offset: 0x00025618
	private static int gpx(AiConnectionMode a)
	{
		for (int i = 0; i < dn.hyt.Length; i++)
		{
			if (dn.hyt[i] == a)
			{
				return i;
			}
		}
		return 0;
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x00027444 File Offset: 0x00025644
	public void hnq()
	{
		bool flag = SettingPanel.kqs;
		if (this.dropdownCharacterMode != null)
		{
			this.dropdownCharacterMode.interactable = flag;
		}
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x00027474 File Offset: 0x00025674
	private void bxs(int a)
	{
		if (this.hyr)
		{
			return;
		}
		if (this.hyq == null || a < 0 || a >= this.hyq.Length)
		{
			return;
		}
		if (this.sizeSpeechBubbleController == null)
		{
			return;
		}
		bq.hlk = false;
		int num = this.hyq[a];
		bq.hlr = num;
		this.sizeSpeechBubbleController.bds(num);
		PlayerPrefs.SetInt(a.blj(), num);
		PlayerPrefs.Save();
		Canvas.ForceUpdateCanvases();
		if (this.speechBubbleController != null)
		{
			float num2 = this.sizeSpeechBubbleController.bdq(num);
			string text = a.bmk();
			StringTable table = LocalizationSettings.StringDatabase.GetTable(a.rh(), null);
			StringTableEntry stringTableEntry = ((table != null) ? table.GetEntry(a.bml()) : null);
			if (stringTableEntry != null)
			{
				text = stringTableEntry.GetLocalizedString();
			}
			string text2 = string.Format(text, num2.ToString(a.bmm()));
			this.speechBubbleController.ShowSizePreview(text2, 2.5f);
		}
	}

	// Token: 0x06000708 RID: 1800 RVA: 0x00027560 File Offset: 0x00025760
	public void isj()
	{
		if (this.dropdownVoice == null)
		{
			return;
		}
		VoiceConfig hlg = bq.hlg;
		if (hlg == null || hlg.kpk == 0)
		{
			this.dropdownVoice.gameObject.SetActive(false);
			return;
		}
		this.dropdownVoice.gameObject.SetActive(true);
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.bmn(), null);
		this.hyk = true;
		this.dropdownVoice.ClearOptions();
		List<string> list = new List<string>();
		for (int i = 0; i < hlg.profiles.Count; i++)
		{
			list.Add(this.bwr(hlg.profiles[i], i, table));
		}
		this.dropdownVoice.AddOptions(list);
		this.dropdownVoice.value = Mathf.Clamp(bq.hlh, 0, hlg.profiles.Count - 1);
		this.dropdownVoice.RefreshShownValue();
		this.hyk = false;
	}

	// Token: 0x06000709 RID: 1801 RVA: 0x00027655 File Offset: 0x00025855
	public void bvs(float a)
	{
		AudioManager.klw.qf(a, true);
	}

	// Token: 0x0600070A RID: 1802 RVA: 0x00027663 File Offset: 0x00025863
	public void bvt(float a)
	{
		AudioManager.klw.qi(a, true);
	}

	// Token: 0x0600070C RID: 1804 RVA: 0x0002769C File Offset: 0x0002589C
	public void nli(int a)
	{
		if (!bq.hlw)
		{
			return;
		}
		bool flag = PlayerPrefs.GetInt(a.bmp(), 0) != 0;
		float @float = PlayerPrefs.GetFloat(a.bmq(), 2615f);
		if ((this.sliderSound != null && this.sliderSound.value > 8488f) || (this.sliderBMG != null && this.sliderBMG.value > -1423f) || (this.sliderSFX != null && this.sliderSFX.value > 3846f) || (this.sliderVoice != null && this.sliderVoice.value > -6375f) || (flag && @float > 5719f))
		{
			this.hyc = ((this.sliderSound != null) ? this.sliderSound.value : (-4396f));
			this.hyd = ((this.sliderBMG != null) ? this.sliderBMG.value : (-4237f));
			this.hye = ((this.sliderSFX != null) ? this.sliderSFX.value : (-759f));
			this.hyf = ((this.sliderVoice != null) ? this.sliderVoice.value : 420f);
			VolumeMuteButton volumeMuteButton = this.muteButtonBGM;
			if (volumeMuteButton != null)
			{
				volumeMuteButton.cbv();
			}
			VolumeMuteButton volumeMuteButton2 = this.muteButtonSound;
			if (volumeMuteButton2 != null)
			{
				volumeMuteButton2.cbv();
			}
			VolumeMuteButton volumeMuteButton3 = this.muteButtonSFX;
			if (volumeMuteButton3 != null)
			{
				volumeMuteButton3.cbv();
			}
			VolumeMuteButton volumeMuteButton4 = this.muteButtonVoice;
			if (volumeMuteButton4 != null)
			{
				volumeMuteButton4.cbv();
			}
			this.hyh = flag;
			if (flag)
			{
				this.hyg = @float;
				if (@float > -9519f)
				{
					PlayerPrefs.SetFloat(a.bmr(), @float);
				}
				AudioManager audioManager = AudioManager.klw;
				if (audioManager != null)
				{
					audioManager.qn(4486f, true);
				}
				PlayerPrefs.SetFloat(a.bms(), -1213f);
			}
			this.hyb = true;
		}
		else
		{
			if (!this.hyb)
			{
				return;
			}
			if (this.sliderSound != null)
			{
				this.sliderSound.value = this.hyc;
			}
			if (this.sliderBMG != null)
			{
				this.sliderBMG.value = this.hyd;
			}
			if (this.sliderSFX != null)
			{
				this.sliderSFX.value = this.hye;
			}
			if (this.sliderVoice != null)
			{
				this.sliderVoice.value = this.hyf;
			}
			if (this.hyh)
			{
				AudioManager audioManager2 = AudioManager.klw;
				if (audioManager2 != null)
				{
					audioManager2.qn(this.hyg, true);
				}
				PlayerPrefs.SetFloat(a.bmt(), this.hyg);
			}
			this.hyb = false;
		}
		this.bvf();
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x00027960 File Offset: 0x00025B60
	private IEnumerator bwp()
	{
		yield return LocalizationSettings.InitializationOperation;
		this.bwq();
		yield break;
	}

	// Token: 0x0600070E RID: 1806
	[DllImport("user32.dll")]
	private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

	// Token: 0x0600070F RID: 1807 RVA: 0x0002796F File Offset: 0x00025B6F
	private static void ym(Slider a)
	{
		if (a == null)
		{
			return;
		}
		if (a.GetComponent<w>() == null)
		{
			a.gameObject.AddComponent<w>();
		}
	}

	// Token: 0x06000710 RID: 1808 RVA: 0x00027998 File Offset: 0x00025B98
	private int bjh()
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return 0;
		}
		return playerSaveData.directApiProviderId;
	}

	// Token: 0x06000711 RID: 1809 RVA: 0x00027663 File Offset: 0x00025863
	public void eav(float a)
	{
		AudioManager.klw.qi(a, true);
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x0002796F File Offset: 0x00025B6F
	private static void bwb(Slider a)
	{
		if (a == null)
		{
			return;
		}
		if (a.GetComponent<w>() == null)
		{
			a.gameObject.AddComponent<w>();
		}
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x000279CC File Offset: 0x00025BCC
	public void bep()
	{
		bq.hlk = false;
		int monitorCount = UniWindowController.GetMonitorCount();
		if (monitorCount <= 1)
		{
			return;
		}
		int num = (UniWindowController.current.monitorToFit + 1) % monitorCount;
		if (UniWindowController.current.monitorToFit != num)
		{
			UniWindowController.current.MoveToMonitor(num);
		}
		bx.bcc(num);
		this.bvn();
		PlayerPrefs.SetInt(a.bmu(), num);
		PlayerPrefs.Save();
		CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
		if (characterDragTarget != null)
		{
			characterDragTarget.bgy();
		}
		SettingPanel settingPanel = SettingPanel.kqq;
		if (settingPanel != null)
		{
			settingPanel.caw();
		}
		BgmPanelController bgmPanelController = ((cx.kpw != null) ? cx.kpw.bgmPanel : null);
		if (bgmPanelController != null)
		{
			bgmPanelController.bmt();
		}
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x00027A77 File Offset: 0x00025C77
	public void bwd(string a)
	{
		bq.hlk = false;
		dq dq = dq.kqv;
		if (dq != null)
		{
			dq.ccp(a);
		}
		PlayerPrefs.SetString(a.bmv(), a);
		PlayerPrefs.Save();
	}

	// Token: 0x06000715 RID: 1813 RVA: 0x00027AA0 File Offset: 0x00025CA0
	public void bvc()
	{
		bool flag = SettingPanel.kqs;
		if (this.dropdownCharacterMode != null)
		{
			this.dropdownCharacterMode.interactable = flag;
		}
	}

	// Token: 0x06000716 RID: 1814 RVA: 0x00027AD0 File Offset: 0x00025CD0
	private void bwf()
	{
		int num = PlayerPrefs.GetInt(a.ne(), 0);
		bl bl = bl.kmv;
		if (bl == null)
		{
			return;
		}
		if (num < 0 || num >= bl.kmu || this.bwe(num))
		{
			num = 0;
			PlayerPrefs.SetInt(a.ne(), num);
			PlayerPrefs.Save();
		}
		bl.xh(num);
		if (base.gameObject.activeInHierarchy)
		{
			base.StartCoroutine(this.bwg());
		}
	}

	// Token: 0x06000717 RID: 1815 RVA: 0x00027B44 File Offset: 0x00025D44
	private void bvq(bool a)
	{
		IntPtr activeWindow = dn.GetActiveWindow();
		if (activeWindow != IntPtr.Zero)
		{
			int num = dn.GetWindowLong(activeWindow, -20);
			if (a)
			{
				num &= -129;
				num |= 262144;
			}
			else
			{
				num &= -262145;
				num |= 128;
			}
			dn.SetWindowLong(activeWindow, -20, num);
		}
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x00027B9C File Offset: 0x00025D9C
	public void oib(bool a)
	{
		bq.hlk = false;
		bq.hlx = a;
		PlayerPrefs.SetInt(a.bmw(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x06000719 RID: 1817 RVA: 0x00027BC0 File Offset: 0x00025DC0
	public void byh(bool a)
	{
		bq.hlk = false;
		bool flag = q.tq(a);
		bool flag2 = a && !flag && q.kmh && d.mc();
		if (!flag && !flag2)
		{
			this.toggleAutoStart.SetIsOnWithoutNotify(!a);
			return;
		}
		PlayerPrefs.SetInt(a.hd(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x00027C1C File Offset: 0x00025E1C
	private static string byo(fa.CheckStatus a, StringTable b)
	{
		string text;
		switch (a)
		{
		case fa.CheckStatus.Checking:
			text = dn.byp(b, a.bmx(), a.bmy());
			break;
		case fa.CheckStatus.UpToDate:
			text = dn.byp(b, a.bmz(), a.bna());
			break;
		case fa.CheckStatus.UpdateAvailable:
			text = dn.byp(b, a.bnb(), a.bnc());
			break;
		case fa.CheckStatus.ApiUnavailable:
			text = dn.byp(b, a.bnd(), a.bne());
			break;
		default:
			text = dn.byp(b, a.bnf(), a.bng());
			break;
		}
		return text;
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x00027CA4 File Offset: 0x00025EA4
	public void ghm()
	{
		bq.hlk = false;
		if (!SteamManager.krd)
		{
			Debug.LogError(a.bnh());
			return;
		}
		if (!ModalDialogManager.kri)
		{
			Debug.LogError(a.bni());
			return;
		}
		if (SteamInventoryManager.iid == null)
		{
			Debug.LogError(a.bnj());
			return;
		}
		if (SteamInventoryManager.iid.ksp)
		{
			Debug.LogWarning(a.bnk());
			return;
		}
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.bnl(), null);
		string text;
		if (table == null)
		{
			text = null;
		}
		else
		{
			StringTableEntry entry = table.GetEntry(a.bnm());
			text = ((entry != null) ? entry.GetLocalizedString() : null);
		}
		string text2 = text ?? a.bnn();
		string text3;
		if (table == null)
		{
			text3 = null;
		}
		else
		{
			StringTableEntry entry2 = table.GetEntry(a.bno());
			text3 = ((entry2 != null) ? entry2.GetLocalizedString() : null);
		}
		string text4 = text3 ?? a.bnp();
		string text5;
		if (table == null)
		{
			text5 = null;
		}
		else
		{
			StringTableEntry entry3 = table.GetEntry(a.bnq());
			text5 = ((entry3 != null) ? entry3.GetLocalizedString() : null);
		}
		string text6 = text5 ?? a.bnr();
		string text7;
		if (table == null)
		{
			text7 = null;
		}
		else
		{
			StringTableEntry entry4 = table.GetEntry(a.bns());
			text7 = ((entry4 != null) ? entry4.GetLocalizedString() : null);
		}
		string text8 = text7 ?? a.bnt();
		string text9;
		if (table == null)
		{
			text9 = null;
		}
		else
		{
			StringTableEntry entry5 = table.GetEntry(a.bnu());
			text9 = ((entry5 != null) ? entry5.GetLocalizedString() : null);
		}
		string text10 = text9 ?? a.bnv();
		string text11;
		if (table == null)
		{
			text11 = null;
		}
		else
		{
			StringTableEntry entry6 = table.GetEntry(a.bnw());
			text11 = ((entry6 != null) ? entry6.GetLocalizedString() : null);
		}
		string text12 = text11 ?? a.bnx();
		string text13;
		if (table == null)
		{
			text13 = null;
		}
		else
		{
			StringTableEntry entry7 = table.GetEntry(a.bny());
			text13 = ((entry7 != null) ? entry7.GetLocalizedString() : null);
		}
		string text14 = text13 ?? a.bnz();
		string[] array = new string[57];
		array[0] = text4;
		array[1] = a.boa();
		array[2] = text6;
		array[3] = a.bob();
		array[4] = text8;
		array[5] = a.boc();
		array[6] = text10;
		array[7] = a.bod();
		array[8] = text12;
		string text15 = string.Concat(array);
		ModalDialogManager.icb.ShowTypingConfirm(text2, text15, a.boe(), text14, new Action(dn.<>c.<>9.btk), null);
	}

	// Token: 0x0600071C RID: 1820 RVA: 0x00027EB4 File Offset: 0x000260B4
	private string ilo(VoiceProfile a, int b, StringTable c)
	{
		if (a == null)
		{
			return string.Format(a.bof(), b);
		}
		if (!string.IsNullOrEmpty(a.displayNameKey) && c != null)
		{
			StringTableEntry entry = c.GetEntry(a.displayNameKey);
			if (entry != null)
			{
				string localizedString = entry.GetLocalizedString();
				if (!string.IsNullOrEmpty(localizedString))
				{
					return localizedString;
				}
			}
		}
		if (!string.IsNullOrEmpty(a.displayName))
		{
			return a.displayName;
		}
		if (!string.IsNullOrEmpty(a.id))
		{
			return a.id;
		}
		return string.Format(a.bog(), b);
	}

	// Token: 0x0600071D RID: 1821 RVA: 0x00027F44 File Offset: 0x00026144
	private void nuq(string a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		string text = (a ?? a.boh()).Trim();
		if (string.IsNullOrEmpty(text))
		{
			playerSaveData.directApiTemplateCustomized = false;
			playerSaveData.directApiPromptTemplate = a.boi();
			if (this.inputPromptTemplate != null)
			{
				this.inputPromptTemplate.text = AiPromptComposer.GetLocalizedDefaultTemplate();
			}
		}
		else
		{
			playerSaveData.directApiTemplateCustomized = true;
			playerSaveData.directApiPromptTemplate = text;
		}
		ci.Save(null);
	}

	// Token: 0x0600071E RID: 1822 RVA: 0x00027FD4 File Offset: 0x000261D4
	private void hzj()
	{
		if (this.objGameCompatRoot != null)
		{
			this.objGameCompatRoot.SetActive(true);
		}
		if (this.btnOpenCustomGameList != null)
		{
			this.btnOpenCustomGameList.onClick.AddListener(new UnityAction(this.buy));
		}
		if (this.objAdminModeRoot != null)
		{
			this.objAdminModeRoot.SetActive(true);
		}
		if (this.toggleAdminMode != null)
		{
			this.toggleAdminMode.SetIsOnWithoutNotify(d.mc());
			this.toggleAdminMode.onValueChanged.AddListener(new UnityAction<bool>(this.bva));
		}
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x00028079 File Offset: 0x00026279
	private void det()
	{
		this.bzw();
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x00028084 File Offset: 0x00026284
	private void hyv()
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		playerSaveData.directApiTemplateCustomized = false;
		playerSaveData.directApiPromptTemplate = a.boj();
		ci.Save(null);
		if (this.inputPromptTemplate != null)
		{
			this.inputPromptTemplate.text = AiPromptComposer.GetLocalizedDefaultTemplate();
		}
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x000280EC File Offset: 0x000262EC
	public void gpo(bool a)
	{
		bq.hlk = false;
		bq.hlt = a;
		for (int i = 0; i < this.flipTarget.Length; i++)
		{
			Vector3 localScale = this.flipTarget[i].localScale;
			localScale.x = math.abs(localScale.x) * (float)(a ? (-1) : 1);
			this.flipTarget[i].localScale = localScale;
		}
		if (this.flipExcludedTargets != null)
		{
			for (int j = 0; j < this.flipExcludedTargets.Length; j++)
			{
				if (!(this.flipExcludedTargets[j] == null))
				{
					Vector3 localScale2 = this.flipExcludedTargets[j].localScale;
					localScale2.x = math.abs(localScale2.x);
					this.flipExcludedTargets[j].localScale = localScale2;
				}
			}
		}
		PlayerPrefs.SetInt(a.bok(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x000281C0 File Offset: 0x000263C0
	private void okr(string a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		string text = (a ?? a.bol()).Trim();
		if (string.IsNullOrEmpty(text))
		{
			playerSaveData.directApiTemplateCustomized = false;
			playerSaveData.directApiPromptTemplate = a.bom();
			if (this.inputPromptTemplate != null)
			{
				this.inputPromptTemplate.text = AiPromptComposer.GetLocalizedDefaultTemplate();
			}
		}
		else
		{
			playerSaveData.directApiTemplateCustomized = true;
			playerSaveData.directApiPromptTemplate = text;
		}
		ci.Save(null);
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x00027655 File Offset: 0x00025855
	public void flm(float a)
	{
		AudioManager.klw.qf(a, true);
	}

	// Token: 0x06000724 RID: 1828 RVA: 0x00028250 File Offset: 0x00026450
	private void bjg()
	{
		bq.zr();
		if (this.dropdownDropNotification == null)
		{
			return;
		}
		this.bxz();
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x0002826C File Offset: 0x0002646C
	public void zy()
	{
		bq.hlk = false;
		Application.OpenURL(a.bon());
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x0002827E File Offset: 0x0002647E
	private void bxh()
	{
		bq.zt();
		if (this.toggleDisableMassagerIdle != null)
		{
			this.toggleDisableMassagerIdle.SetIsOnWithoutNotify(bq.hmd);
		}
		GirlController girlController = GirlController.kok;
		if (girlController == null)
		{
			return;
		}
		girlController.bfn();
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x000282B4 File Offset: 0x000264B4
	private void fpn(int a)
	{
		if (this.hyr)
		{
			return;
		}
		if (this.hyq == null || a < 0 || a >= this.hyq.Length)
		{
			return;
		}
		if (this.sizeSpeechBubbleController == null)
		{
			return;
		}
		bq.hlk = false;
		int num = this.hyq[a];
		bq.hlr = num;
		this.sizeSpeechBubbleController.bds(num);
		PlayerPrefs.SetInt(a.boo(), num);
		PlayerPrefs.Save();
		Canvas.ForceUpdateCanvases();
		if (this.speechBubbleController != null)
		{
			float num2 = this.sizeSpeechBubbleController.bdq(num);
			string text = a.bop();
			StringTable table = LocalizationSettings.StringDatabase.GetTable(a.boq(), null);
			StringTableEntry stringTableEntry = ((table != null) ? table.GetEntry(a.bor()) : null);
			if (stringTableEntry != null)
			{
				text = stringTableEntry.GetLocalizedString();
			}
			string text2 = string.Format(text, num2.ToString(a.bos()));
			this.speechBubbleController.ShowSizePreview(text2, -6614f);
		}
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x000283A0 File Offset: 0x000265A0
	private void osd(bool a)
	{
		if (this.windowController == null)
		{
			return;
		}
		if (a)
		{
			this.windowController.isClickThrough = false;
			this.windowController.hitTestType = UniWindowController.HitTestType.None;
			return;
		}
		this.windowController.hitTestType = UniWindowController.HitTestType.Opacity;
		this.windowController.isClickThrough = true;
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x000283F0 File Offset: 0x000265F0
	public void bwy()
	{
		if (this.hyl != null)
		{
			return;
		}
		if (bx.hod == null)
		{
			Debug.LogWarning(a.bot());
			return;
		}
		if (!ModalDialogManager.kri)
		{
			Debug.LogWarning(a.bou());
			return;
		}
		this.hyl = base.StartCoroutine(this.bwz());
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x00028444 File Offset: 0x00026644
	public void fzx()
	{
		bq.hlk = false;
		int monitorCount = UniWindowController.GetMonitorCount();
		if (monitorCount <= 1)
		{
			return;
		}
		int num = (UniWindowController.current.monitorToFit + 1) % monitorCount;
		if (UniWindowController.current.monitorToFit != num)
		{
			UniWindowController.current.MoveToMonitor(num);
		}
		bx.bcc(num);
		this.bvn();
		PlayerPrefs.SetInt(a.bov(), num);
		PlayerPrefs.Save();
		CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
		if (characterDragTarget != null)
		{
			characterDragTarget.bgy();
		}
		SettingPanel settingPanel = SettingPanel.kqq;
		if (settingPanel != null)
		{
			settingPanel.caw();
		}
		BgmPanelController bgmPanelController = ((cx.kpw != null) ? cx.kpw.bgmPanel : null);
		if (bgmPanelController != null)
		{
			bgmPanelController.bmt();
		}
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x000284F0 File Offset: 0x000266F0
	private void bxa(bool a)
	{
		if (!ModalDialogManager.kri)
		{
			return;
		}
		if (ModalDialogManager.icb.krh)
		{
			Debug.LogWarning(string.Format(a.bow(), a));
			return;
		}
		string text = a.box();
		string text2 = (a ? a.boz() : a.boy());
		try
		{
			if (LocalizationSettings.InitializationOperation.IsDone)
			{
				StringTable table = LocalizationSettings.StringDatabase.GetTable(a.rh(), null);
				if (table != null)
				{
					StringTableEntry entry = table.GetEntry(a.bpa());
					string text3 = ((entry != null) ? entry.GetLocalizedString() : null);
					if (!string.IsNullOrEmpty(text3))
					{
						text = text3;
					}
					string text4 = (a ? a.bpc() : a.bpb());
					StringTableEntry entry2 = table.GetEntry(text4);
					string text5 = ((entry2 != null) ? entry2.GetLocalizedString() : null);
					if (!string.IsNullOrEmpty(text5))
					{
						text2 = text5;
					}
				}
			}
		}
		catch
		{
		}
		ModalDialogManager.icb.ShowMessage(text, text2, null);
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x000285E8 File Offset: 0x000267E8
	private void idp()
	{
		try
		{
			dz.cgu();
			Application.OpenURL(new Uri(dz.cgt()).AbsoluteUri);
			if (this.btnOpenCustomGameList != null)
			{
				this.btnOpenCustomGameList.interactable = false;
				base.StartCoroutine(this.buz(-2232f));
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.bpd() + ex.Message);
		}
	}

	// Token: 0x0600072D RID: 1837 RVA: 0x00028664 File Offset: 0x00026864
	private void gpu(int a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		playerSaveData.directApiProviderId = a;
		playerSaveData.directApiModel = a.bpe();
		ci.Save(null);
		AiProviderConfig aiProviderConfig = AiProviderCatalog.For(a);
		if (this.inputCustomBaseUrl != null)
		{
			this.inputCustomBaseUrl.gameObject.SetActive(aiProviderConfig.AllowsCustomBaseUrl);
		}
		this.bzn(new List<string>(), null);
		DirectApiScheduler instance = DirectApiScheduler.Instance;
		if (instance != null)
		{
			instance.ResetRuntimeStatus();
		}
		this.caf();
		this.bzw();
		this.bzj();
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x00028707 File Offset: 0x00026907
	public void bxd(bool a)
	{
		bq.hlk = false;
		if (bo.hke != null)
		{
			bo.hke.yq(a);
			return;
		}
		PlayerPrefs.SetInt(a.ol(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x00028740 File Offset: 0x00026940
	private void hxn(AiConnectionMode a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		McpDialogueServer instance = McpDialogueServer.Instance;
		if (instance != null)
		{
			instance.StopServer();
		}
		DirectApiScheduler instance2 = DirectApiScheduler.Instance;
		if (instance2 != null)
		{
			instance2.Disable();
		}
		playerSaveData.aiConnectionMode = (int)a;
		playerSaveData.aiConnectionEnabled = a == AiConnectionMode.Mcp;
		bool flag = false;
		bool flag2 = false;
		if (a == AiConnectionMode.Mcp && !playerSaveData.firstTimeMcpToggleDone)
		{
			playerSaveData.firstTimeMcpToggleDone = true;
			flag = true;
		}
		if (a == AiConnectionMode.DirectApi && !playerSaveData.directApiFirstTimeTipDone)
		{
			playerSaveData.directApiFirstTimeTipDone = true;
			flag2 = true;
		}
		ci.Save(null);
		if (a == AiConnectionMode.Mcp)
		{
			McpDialogueServer instance3 = McpDialogueServer.Instance;
			if (instance3 != null)
			{
				instance3.StartServer();
			}
		}
		else if (a == AiConnectionMode.DirectApi)
		{
			DirectApiScheduler.EnsureInstance().Enable();
		}
		if (flag && this.mcpFirstTimeTip != null)
		{
			this.mcpFirstTimeTip.SetActive(true);
		}
		if (flag2 && this.directPrivacyTip != null)
		{
			this.directPrivacyTip.SetActive(true);
		}
		this.bze(a);
		this.bzw();
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x00028844 File Offset: 0x00026A44
	private string jmz(int a, StringTable b)
	{
		bool flag = this.bwe(a);
		string text = this.bwt(a, flag, b);
		if (string.IsNullOrEmpty(text))
		{
			text = string.Format(a.bpf(), a);
		}
		bl bl = bl.kmv;
		CatCharacterDefinition catCharacterDefinition = ((bl != null) ? bl.xp(a) : null);
		if (catCharacterDefinition != null && catCharacterDefinition.unlockType == CatUnlockType.Workshop)
		{
			text += a.bpg();
		}
		if (flag)
		{
			text = a.bph() + text + a.bpi();
		}
		return text;
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x000288C4 File Offset: 0x00026AC4
	private void byn()
	{
		fa fa = fa.imk;
		if (fa == null)
		{
			return;
		}
		if (this.btnCheckNow != null)
		{
			this.btnCheckNow.interactable = true;
		}
		bool flag = fa.imm == fa.CheckStatus.UpdateAvailable;
		if (this.objUpdateStatus != null)
		{
			this.objUpdateStatus.SetActive(flag);
		}
		if (this.txtUpdateStatus != null && flag)
		{
			StringTable table = LocalizationSettings.StringDatabase.GetTable(a.rh(), null);
			this.txtUpdateStatus.text = dn.byp(table, a.bnb(), a.bpj());
		}
		if (this.btnCheckNow != null)
		{
			this.btnCheckNow.gameObject.SetActive(!flag);
		}
		if (this.objUpdateBadge != null)
		{
			this.objUpdateBadge.un(flag);
		}
		Canvas.ForceUpdateCanvases();
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x000289A4 File Offset: 0x00026BA4
	private void djy()
	{
		if (this.txtMonitor == null)
		{
			return;
		}
		int monitorToFit = UniWindowController.current.monitorToFit;
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.bpk(), null);
		string text;
		if (table == null)
		{
			text = null;
		}
		else
		{
			StringTableEntry entry = table.GetEntry(a.bpl());
			text = ((entry != null) ? entry.GetLocalizedString() : null);
		}
		string text2 = text ?? a.bpm();
		this.txtMonitor.text = string.Format(a.bpn(), text2, monitorToFit + 1);
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x00028A25 File Offset: 0x00026C25
	public static void jwo(int a)
	{
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate = a;
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x00028A33 File Offset: 0x00026C33
	public void bvo(bool a)
	{
		bq.hlk = false;
		this.bvq(a);
		PlayerPrefs.SetInt(a.bpo(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x06000735 RID: 1845
	[DllImport("user32.dll")]
	private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

	// Token: 0x06000736 RID: 1846 RVA: 0x00028A58 File Offset: 0x00026C58
	private void bzc(int a)
	{
		if (this.hys)
		{
			return;
		}
		this.bzd(dn.hyt[Mathf.Clamp(a, 0, dn.hyt.Length - 1)]);
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x00028A80 File Offset: 0x00026C80
	public void bxm()
	{
		bq.hlo = PlayerPrefs.GetInt(a.blg(), 0);
		bq.hlp = PlayerPrefs.GetInt(a.blh(), 2);
		bq.hlq = PlayerPrefs.GetInt(a.bli(), 2);
		bq.hlr = PlayerPrefs.GetInt(a.blj(), 2);
		if (this.sizeController != null)
		{
			this.sizeController.bds(bq.hlo);
		}
		if (this.sizeUIController != null)
		{
			this.sizeUIController.bds(bq.hlp);
		}
		if (this.sizeToolbarController != null)
		{
			this.sizeToolbarController.bds(bq.hlq);
		}
		if (this.sizeSpeechBubbleController != null)
		{
			this.sizeSpeechBubbleController.bds(bq.hlr);
		}
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x00028B48 File Offset: 0x00026D48
	private void mno()
	{
		if (this.dropdownSize != null)
		{
			this.dropdownSize.onValueChanged.AddListener(new UnityAction<int>(this.bxp));
		}
		this.sliderSound.onValueChanged.AddListener(new UnityAction<float>(this.bvs));
		this.sliderBMG.onValueChanged.AddListener(new UnityAction<float>(this.bvt));
		this.sliderSFX.onValueChanged.AddListener(new UnityAction<float>(this.bvw));
		this.sliderVoice.onValueChanged.AddListener(new UnityAction<float>(this.bvx));
		this.bwa(this.sliderSound.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvu));
		this.bwa(this.sliderBMG.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvv));
		this.bwa(this.sliderSFX.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvy));
		this.bwa(this.sliderVoice.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvz));
		if (this.muteButtonSound != null)
		{
			this.muteButtonSound.hzh += this.bvf;
		}
		if (this.muteButtonBGM != null)
		{
			this.muteButtonBGM.hzh += this.bvf;
		}
		if (this.muteButtonSFX != null)
		{
			this.muteButtonSFX.hzh += this.bvf;
		}
		if (this.muteButtonVoice != null)
		{
			this.muteButtonVoice.hzh += this.bvf;
		}
		dn.bwb(this.sliderSound);
		dn.bwb(this.sliderBMG);
		dn.bwb(this.sliderSFX);
		dn.bwb(this.sliderVoice);
		if (this.dropdownUISize != null)
		{
			this.dropdownUISize.onValueChanged.AddListener(new UnityAction<int>(this.bxq));
		}
		if (this.dropdownToolbarSize != null)
		{
			this.dropdownToolbarSize.onValueChanged.AddListener(new UnityAction<int>(this.bxr));
		}
		if (this.dropdownSpeechBubbleSize != null)
		{
			this.dropdownSpeechBubbleSize.onValueChanged.AddListener(new UnityAction<int>(this.bxs));
		}
		this.btnCloseGame.onClick.AddListener(new UnityAction(this.byj));
		this.btnSteamInventory.onClick.AddListener(new UnityAction(this.byr));
		this.btnDiscord.onClick.AddListener(new UnityAction(this.bys));
		if (this.btnWorkshop != null)
		{
			this.btnWorkshop.onClick.AddListener(new UnityAction(this.byt));
		}
		if (this.btnTroubleshooting != null)
		{
			this.btnTroubleshooting.onClick.AddListener(new UnityAction(this.byu));
		}
		this.toggleTop.onValueChanged.AddListener(new UnityAction<bool>(this.byv));
		this.toggleFlip.onValueChanged.AddListener(new UnityAction<bool>(this.byi));
		if (this.toggleDropAnimation != null)
		{
			this.toggleDropAnimation.onValueChanged.AddListener(new UnityAction<bool>(this.bxg));
		}
		if (this.toggleDisableMassagerIdle != null)
		{
			this.toggleDisableMassagerIdle.onValueChanged.AddListener(new UnityAction<bool>(this.bxi));
		}
		if (this.dropdownLanguage != null)
		{
			this.dropdownLanguage.onValueChanged.AddListener(new UnityAction<int>(this.bvj));
		}
		this.btnMonitor.onClick.AddListener(new UnityAction(this.bvm));
		this.toggleTaskbar.onValueChanged.AddListener(new UnityAction<bool>(this.bvo));
		this.toggleTaskbarSnap.onValueChanged.AddListener(new UnityAction<bool>(this.bvp));
		this.toggleLockPosition.onValueChanged.AddListener(new UnityAction<bool>(this.bwu));
		if (this.btnResetCharacterPosition != null)
		{
			this.btnResetCharacterPosition.onClick.AddListener(new UnityAction(this.bwx));
		}
		if (this.btnRepairWindow != null)
		{
			this.btnRepairWindow.onClick.AddListener(new UnityAction(this.bwy));
			if (!ModalDialogManager.kri)
			{
				this.btnRepairWindow.interactable = false;
				this.hym = true;
				Debug.LogWarning(a.bpp());
			}
		}
		if (this.btnDeleteAllItems != null)
		{
			this.btnDeleteAllItems.onClick.AddListener(new UnityAction(this.byq));
			if (!ModalDialogManager.kri)
			{
				this.btnDeleteAllItems.interactable = false;
				Debug.LogWarning(a.bpq());
			}
		}
		this.toggleAutoHideDownUI.onValueChanged.AddListener(new UnityAction<bool>(this.bxb));
		if (this.toggleHotkey != null)
		{
			this.toggleHotkey.onValueChanged.AddListener(new UnityAction<bool>(this.bxe));
		}
		if (this.toggleRightClickQuickMenu != null)
		{
			this.toggleRightClickQuickMenu.onValueChanged.AddListener(new UnityAction<bool>(this.bxj));
		}
		if (this.inputSteamStatus != null)
		{
			this.inputSteamStatus.onEndEdit.AddListener(new UnityAction<string>(this.bwd));
		}
		if (this.dropdownCharacterMode != null)
		{
			this.dropdownCharacterMode.onValueChanged.AddListener(new UnityAction<int>(this.bwo));
		}
		if (this.dropdownVoice != null)
		{
			this.dropdownVoice.onValueChanged.AddListener(new UnityAction<int>(this.bws));
			base.StartCoroutine(this.bwp());
		}
		if (this.dropdownFPS != null)
		{
			this.dropdownFPS.onValueChanged.AddListener(new UnityAction<int>(this.bxx));
		}
		if (this.dropdownDropNotification != null)
		{
			this.dropdownDropNotification.onValueChanged.AddListener(new UnityAction<int>(this.byb));
		}
		if (this.dropdownDirtiness != null)
		{
			this.dropdownDirtiness.onValueChanged.AddListener(new UnityAction<int>(this.byf));
		}
		if (this.toggleAutoStart != null)
		{
			this.toggleAutoStart.onValueChanged.AddListener(new UnityAction<bool>(this.byh));
		}
		if (this.toggleDiscordRichPresence != null)
		{
			this.toggleDiscordRichPresence.onValueChanged.AddListener(new UnityAction<bool>(this.bxd));
		}
		if (this.btnCheckNow != null)
		{
			this.btnCheckNow.onClick.AddListener(new UnityAction(this.byk));
		}
		if (this.btnRestartUpdate != null)
		{
			this.btnRestartUpdate.onClick.AddListener(new UnityAction(this.bym));
			this.btnRestartUpdate.interactable = true;
		}
		if (this.objUpdateStatus != null)
		{
			this.objUpdateStatus.SetActive(false);
		}
		if (this.objUpdateBadge != null)
		{
			this.objUpdateBadge.un(false);
		}
		this.bux();
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x00028A25 File Offset: 0x00026C25
	public static void ctj(int a)
	{
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate = a;
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x0002796F File Offset: 0x00025B6F
	private static void kmh(Slider a)
	{
		if (a == null)
		{
			return;
		}
		if (a.GetComponent<w>() == null)
		{
			a.gameObject.AddComponent<w>();
		}
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x0002929C File Offset: 0x0002749C
	private void bxc()
	{
		if (this.toggleDiscordRichPresence == null)
		{
			return;
		}
		bool flag = PlayerPrefs.GetInt(a.ol(), 1) == 1;
		this.toggleDiscordRichPresence.SetIsOnWithoutNotify(flag);
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x000292D4 File Offset: 0x000274D4
	private void bzk(AiModelList a)
	{
		if (a == null)
		{
			return;
		}
		if (!a.Ok)
		{
			this.bzx(dn.cag(a.Error));
			DirectApiScheduler instance = DirectApiScheduler.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ShowApiError(a.Error, a.RawDetail);
			return;
		}
		else
		{
			PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
			string text = ((playerSaveData != null) ? playerSaveData.directApiModel : null);
			List<string> list = new List<string>(a.Models);
			this.bzn(list, (!string.IsNullOrEmpty(text)) ? text : ((list.Count > 0) ? list[0] : null));
			if (playerSaveData != null && string.IsNullOrEmpty(playerSaveData.directApiModel) && list.Count > 0)
			{
				playerSaveData.directApiModel = list[0];
				ci.Save(null);
			}
			string text2 = string.Format(dn.byy(a.bpr(), a.bps()), list.Count);
			this.bzx(text2);
			DirectApiScheduler instance2 = DirectApiScheduler.Instance;
			if (instance2 == null)
			{
				return;
			}
			instance2.ShowModalMessage(a.tk(), text2);
			return;
		}
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x000293E4 File Offset: 0x000275E4
	public void lad(bool a)
	{
		bq.hlk = false;
		bq.hlw = a;
		if (this.hotkeyHintPanel != null)
		{
			this.hotkeyHintPanel.SetActive(a);
		}
		this.bxk();
		PlayerPrefs.SetInt(a.bpt(), a ? 1 : 0);
		PlayerPrefs.Save();
		if (a)
		{
			WinGlobalHotkey.ctp();
			return;
		}
		WinGlobalHotkey.ctq();
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x00029444 File Offset: 0x00027644
	private void btn(string a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		playerSaveData.directApiBaseUrl = (a ?? a.bpu()).Trim();
		ci.Save(null);
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x00029494 File Offset: 0x00027694
	public void bvz(BaseEventData a)
	{
		PlayerPrefs.SetFloat(a.sg(), this.sliderVoice.value);
		PlayerPrefs.Save();
		bq.hlk = false;
		if (this.hxs && AudioManager.klw != null)
		{
			EventReference eventReference = bq.zy(new Func<VoiceProfile, EventReference>(dn.<>c.<>9.bth), this.soundPreviewVoice);
			if (!eventReference.IsNull)
			{
				AudioManager.klw.qw(eventReference, bx.hod.koe, 1f);
			}
		}
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x00029528 File Offset: 0x00027728
	public void nna(BaseEventData a)
	{
		PlayerPrefs.SetFloat(a.bpv(), this.sliderSFX.value);
		PlayerPrefs.Save();
		bq.hlk = false;
		if (this.hxs && AudioManager.klw != null && !this.soundPreviewSFX.IsNull)
		{
			AudioManager.klw.qw(this.soundPreviewSFX, bx.hod.koe, 1611f);
		}
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00029598 File Offset: 0x00027798
	private static string bxw()
	{
		string text;
		try
		{
			if (!LocalizationSettings.InitializationOperation.IsDone)
			{
				text = a.bpw();
			}
			else
			{
				StringTable table = LocalizationSettings.StringDatabase.GetTable(a.rh(), null);
				StringTableEntry stringTableEntry = ((table != null) ? table.GetEntry(a.bpx()) : null);
				string text2 = ((stringTableEntry != null) ? stringTableEntry.GetLocalizedString() : null);
				text = (string.IsNullOrEmpty(text2) ? a.bpw() : text2);
			}
		}
		catch
		{
			text = a.bpw();
		}
		return text;
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x0002961C File Offset: 0x0002781C
	private void bww()
	{
		if (!bq.hlu)
		{
			return;
		}
		if (this.downUIController == null || !this.downUIController.kpx)
		{
			return;
		}
		if (this.dragImageRect == null)
		{
			return;
		}
		Vector2 vector = Input.mousePosition;
		if (RectTransformUtility.RectangleContainsScreenPoint(this.dragImageRect, vector))
		{
			this.downUIController.brk();
		}
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x00029680 File Offset: 0x00027880
	public void erv()
	{
		bq.hlk = false;
		Application.OpenURL(a.bpy());
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x000296C0 File Offset: 0x000278C0
	public void ojv()
	{
		bq.hlk = false;
		int monitorCount = UniWindowController.GetMonitorCount();
		if (monitorCount <= 1)
		{
			return;
		}
		int num = (UniWindowController.current.monitorToFit + 1) % monitorCount;
		if (UniWindowController.current.monitorToFit != num)
		{
			UniWindowController.current.MoveToMonitor(num);
		}
		bx.bcc(num);
		this.bvn();
		PlayerPrefs.SetInt(a.bpz(), num);
		PlayerPrefs.Save();
		CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
		if (characterDragTarget != null)
		{
			characterDragTarget.bgy();
		}
		SettingPanel settingPanel = SettingPanel.kqq;
		if (settingPanel != null)
		{
			settingPanel.caw();
		}
		BgmPanelController bgmPanelController = ((cx.kpw != null) ? cx.kpw.bgmPanel : null);
		if (bgmPanelController != null)
		{
			bgmPanelController.bmt();
		}
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x0002976C File Offset: 0x0002796C
	private void bfm()
	{
		int monitorCount = UniWindowController.GetMonitorCount();
		int num = PlayerPrefs.GetInt(a.bqa(), 0);
		if (monitorCount > 0 && num >= monitorCount)
		{
			num = 0;
			PlayerPrefs.SetInt(a.bqb(), num);
			PlayerPrefs.Save();
			Debug.Log(string.Format(a.bqc(), num));
		}
		if (monitorCount > 0)
		{
			if (UniWindowController.current.monitorToFit != num)
			{
				UniWindowController.current.MoveToMonitor(num);
			}
			bx.bcc(num);
			CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
			if (characterDragTarget != null)
			{
				characterDragTarget.bhb();
			}
		}
		this.bvn();
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x000297F2 File Offset: 0x000279F2
	private void byc()
	{
		bq.zu();
		if (this.dropdownDirtiness == null)
		{
			return;
		}
		this.byd();
	}

	// Token: 0x06000748 RID: 1864 RVA: 0x00029810 File Offset: 0x00027A10
	private void jfj()
	{
		if (this.sliderSound != null)
		{
			PlayerPrefs.SetFloat(a.bqd(), this.sliderSound.value);
		}
		if (this.sliderBMG != null)
		{
			PlayerPrefs.SetFloat(a.bqe(), this.sliderBMG.value);
		}
		if (this.sliderSFX != null)
		{
			PlayerPrefs.SetFloat(a.bqf(), this.sliderSFX.value);
		}
		if (this.sliderVoice != null)
		{
			PlayerPrefs.SetFloat(a.bqg(), this.sliderVoice.value);
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x000298B0 File Offset: 0x00027AB0
	public void wg(bool a)
	{
		bq.hlk = false;
		bq.hlw = a;
		if (this.hotkeyHintPanel != null)
		{
			this.hotkeyHintPanel.SetActive(a);
		}
		this.bxk();
		PlayerPrefs.SetInt(a.bqh(), a ? 1 : 0);
		PlayerPrefs.Save();
		if (a)
		{
			WinGlobalHotkey.ctp();
			return;
		}
		WinGlobalHotkey.ctq();
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x000297F2 File Offset: 0x000279F2
	private void jqx()
	{
		bq.zu();
		if (this.dropdownDirtiness == null)
		{
			return;
		}
		this.byd();
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x00029910 File Offset: 0x00027B10
	public void lbd()
	{
		bool flag = SettingPanel.kqs;
		if (this.dropdownCharacterMode != null)
		{
			this.dropdownCharacterMode.interactable = flag;
		}
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x0002827E File Offset: 0x0002647E
	private void fon()
	{
		bq.zt();
		if (this.toggleDisableMassagerIdle != null)
		{
			this.toggleDisableMassagerIdle.SetIsOnWithoutNotify(bq.hmd);
		}
		GirlController girlController = GirlController.kok;
		if (girlController == null)
		{
			return;
		}
		girlController.bfn();
	}

	// Token: 0x0600074D RID: 1869 RVA: 0x00029940 File Offset: 0x00027B40
	public void byi(bool a)
	{
		bq.hlk = false;
		bq.hlt = a;
		for (int i = 0; i < this.flipTarget.Length; i++)
		{
			Vector3 localScale = this.flipTarget[i].localScale;
			localScale.x = math.abs(localScale.x) * (float)(a ? (-1) : 1);
			this.flipTarget[i].localScale = localScale;
		}
		if (this.flipExcludedTargets != null)
		{
			for (int j = 0; j < this.flipExcludedTargets.Length; j++)
			{
				if (!(this.flipExcludedTargets[j] == null))
				{
					Vector3 localScale2 = this.flipExcludedTargets[j].localScale;
					localScale2.x = math.abs(localScale2.x);
					this.flipExcludedTargets[j].localScale = localScale2;
				}
			}
		}
		PlayerPrefs.SetInt(a.bll(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x00029A14 File Offset: 0x00027C14
	private static string nyd(StringTable a, string b, string c)
	{
		if (a == null)
		{
			return c;
		}
		StringTableEntry entry = a.GetEntry(b);
		if (entry == null)
		{
			return c;
		}
		string localizedString = entry.GetLocalizedString();
		if (!string.IsNullOrEmpty(localizedString))
		{
			return localizedString;
		}
		return c;
	}

	// Token: 0x0600074F RID: 1871 RVA: 0x00029A4C File Offset: 0x00027C4C
	private void okc()
	{
		if (this.dropdownDropNotification == null)
		{
			return;
		}
		List<string> list = new List<string>
		{
			dn.bya(a.bqi(), a.bqj()),
			dn.bya(a.bqk(), a.bql()),
			dn.bya(a.bqm(), a.bqn())
		};
		this.dropdownDropNotification.ClearOptions();
		this.dropdownDropNotification.AddOptions(list);
		this.dropdownDropNotification.SetValueWithoutNotify((int)bq.hma);
		this.dropdownDropNotification.RefreshShownValue();
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x00029AE0 File Offset: 0x00027CE0
	private static string byy(string a, string b)
	{
		string text;
		try
		{
			if (!LocalizationSettings.InitializationOperation.IsDone)
			{
				text = b;
			}
			else
			{
				StringTable table = LocalizationSettings.StringDatabase.GetTable(a.rh(), null);
				StringTableEntry stringTableEntry = ((table != null) ? table.GetEntry(a) : null);
				string text2 = ((stringTableEntry != null) ? stringTableEntry.GetLocalizedString() : null);
				text = (string.IsNullOrEmpty(text2) ? b : text2);
			}
		}
		catch
		{
			text = b;
		}
		return text;
	}

	// Token: 0x06000751 RID: 1873 RVA: 0x00029B54 File Offset: 0x00027D54
	private void bym()
	{
		bq.hlk = false;
		if (!ModalDialogManager.kri)
		{
			fa fa = fa.imk;
			if (fa == null)
			{
				return;
			}
			fa.cuw();
			return;
		}
		else
		{
			if (ModalDialogManager.icb.krh)
			{
				return;
			}
			fa fa2 = fa.imk;
			bool flag = fa2 != null && fa2.imm == fa.CheckStatus.UpdateAvailable;
			StringTable table = LocalizationSettings.StringDatabase.GetTable(a.rh(), null);
			string text;
			string text2;
			if (flag)
			{
				text = dn.byp(table, a.bnb(), a.bnc());
				text2 = dn.byp(table, a.bqo(), a.bqp());
			}
			else
			{
				text = dn.byp(table, a.bqq(), a.bqr());
				text2 = dn.byp(table, a.bqs(), a.bqt());
			}
			ModalDialogManager.icb.ShowConfirm(text, text2, new Action(dn.<>c.<>9.btj), null);
			return;
		}
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x00029C30 File Offset: 0x00027E30
	private void gv()
	{
		q.tt();
		if (this.toggleAutoStart == null)
		{
			return;
		}
		if (!q.kmh)
		{
			this.toggleAutoStart.gameObject.SetActive(false);
			return;
		}
		bool flag = PlayerPrefs.GetInt(a.bqu(), 0) == 1;
		if (!q.tp(flag))
		{
			q.tq(flag);
		}
		this.toggleAutoStart.SetIsOnWithoutNotify(flag);
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x00029C94 File Offset: 0x00027E94
	[CompilerGenerated]
	private void cah()
	{
		if (!string.IsNullOrEmpty(this.mcpDocUrl))
		{
			Application.OpenURL(this.mcpDocUrl);
		}
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x00029CB0 File Offset: 0x00027EB0
	private static string byp(StringTable a, string b, string c)
	{
		if (a == null)
		{
			return c;
		}
		StringTableEntry entry = a.GetEntry(b);
		if (entry == null)
		{
			return c;
		}
		string localizedString = entry.GetLocalizedString();
		if (!string.IsNullOrEmpty(localizedString))
		{
			return localizedString;
		}
		return c;
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x00029CE7 File Offset: 0x00027EE7
	private static string krx(AiErrorKind a)
	{
		return AiLoc.DescribeError(a);
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x00029CF0 File Offset: 0x00027EF0
	private bool caa(int a)
	{
		bool flag;
		try
		{
			flag = AiSecretStore.HasKey(a);
		}
		catch (Exception ex)
		{
			string text = a.bqv();
			Exception ex2 = ex;
			Debug.LogError(text + ((ex2 != null) ? ex2.ToString() : null));
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x00029D38 File Offset: 0x00027F38
	public void bys()
	{
		bq.hlk = false;
		Application.OpenURL(a.qn());
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x00029D4C File Offset: 0x00027F4C
	public static int ffe(TMP_Dropdown a, bz b, int c, out int[] d, Func<int, string, string> e = null)
	{
		dn.dd dd = new dn.dd();
		dd.hwm = b;
		d = new int[dd.hwm.sizes.Count];
		for (int i = 0; i < d.Length; i++)
		{
			d[i] = i;
		}
		Array.Sort<int>(d, new Comparison<int>(dd.bto));
		a.ClearOptions();
		List<string> list = new List<string>();
		int num = 0;
		for (int j = 0; j < d.Length; j++)
		{
			int num2 = d[j];
			string text = a.bqw() + dd.hwm.bdq(num2).ToString();
			if (e != null)
			{
				text = e(num2, text);
			}
			list.Add(text);
			if (num2 == c)
			{
				num = j;
			}
		}
		a.AddOptions(list);
		a.value = num;
		a.RefreshShownValue();
		return num;
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x00027655 File Offset: 0x00025855
	public void nwe(float a)
	{
		AudioManager.klw.qf(a, true);
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x00029E24 File Offset: 0x00028024
	private void bxf()
	{
		bq.zs();
		if (this.toggleDropAnimation != null)
		{
			this.toggleDropAnimation.SetIsOnWithoutNotify(bq.hmc);
		}
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x00029E49 File Offset: 0x00028049
	private static string gho(AiConnectionMode a)
	{
		if (a == AiConnectionMode.Mcp)
		{
			return dn.byy(a.bqz(), a.bra());
		}
		if (a == AiConnectionMode.DirectApi)
		{
			return dn.byy(a.bqx(), a.bqy());
		}
		return dn.byy(a.brb(), a.brc());
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x00029E84 File Offset: 0x00028084
	private void ebe(int a)
	{
		if (this.hyr)
		{
			return;
		}
		if (this.hyp == null || a < 0 || a >= this.hyp.Length)
		{
			return;
		}
		if (this.sizeToolbarController == null)
		{
			return;
		}
		bq.hlk = false;
		int num = this.hyp[a];
		bq.hlq = num;
		this.sizeToolbarController.bds(num);
		PlayerPrefs.SetInt(a.brd(), num);
		PlayerPrefs.Save();
		Canvas.ForceUpdateCanvases();
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x00029EF8 File Offset: 0x000280F8
	private void ncy(int a)
	{
		if (this.hyj)
		{
			return;
		}
		bq.hlk = false;
		bl bl = bl.kmv;
		if (bl == null)
		{
			return;
		}
		int num = this.bwk(a);
		if (num == -1)
		{
			bl.xm(true);
			bl.xk();
			return;
		}
		if (num < 0 || num >= bl.kmu)
		{
			num = 0;
		}
		if (this.bwe(num))
		{
			this.hyj = true;
			this.dropdownCharacterMode.value = this.bwl();
			this.dropdownCharacterMode.RefreshShownValue();
			this.hyj = false;
			return;
		}
		bl.xm(false);
		bl.xu();
		bl.xh(num);
		int num2 = ((bl.hjk > 0) ? bl.hjk : bq.hly);
		PlayerPrefs.SetInt(a.bre(), num2);
		PlayerPrefs.Save();
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x00029FBC File Offset: 0x000281BC
	private void OnEnable()
	{
		this.hxt = base.StartCoroutine(this.bvh());
		this.bwh();
		this.bwq();
		eu.ijx += this.bww;
		if (this.btnOpenCustomGameList != null)
		{
			this.btnOpenCustomGameList.interactable = true;
		}
		if (this.hxr != null)
		{
			bb[] array = this.hxr;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].vj(true);
			}
		}
		fa.iml += this.byn;
		this.byn();
		LocalizationSettings.SelectedLocaleChanged += this.bzu;
		DirectApiScheduler.OnRuntimeStatusChanged += this.bzy;
		this.bzw();
		AudioManager.het += this.bvd;
		if (this.sliderBMG != null)
		{
			float @float = PlayerPrefs.GetFloat(a.se(), 0.5f);
			if (!Mathf.Approximately(this.sliderBMG.value, @float))
			{
				this.sliderBMG.value = @float;
			}
		}
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x0002A0C8 File Offset: 0x000282C8
	private static int byz(AiConnectionMode a)
	{
		for (int i = 0; i < dn.hyt.Length; i++)
		{
			if (dn.hyt[i] == a)
			{
				return i;
			}
		}
		return 0;
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x00027157 File Offset: 0x00025357
	public void bwx()
	{
		bq.hlk = false;
		CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
		if (characterDragTarget == null)
		{
			return;
		}
		characterDragTarget.bgy();
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x00028250 File Offset: 0x00026450
	private void nww()
	{
		bq.zr();
		if (this.dropdownDropNotification == null)
		{
			return;
		}
		this.bxz();
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x0002A0F4 File Offset: 0x000282F4
	public void ifa()
	{
		bq.hlk = false;
		if (!SteamManager.krd)
		{
			Debug.LogError(a.brf());
			return;
		}
		if (!ModalDialogManager.kri)
		{
			Debug.LogError(a.brg());
			return;
		}
		if (SteamInventoryManager.iid == null)
		{
			Debug.LogError(a.brh());
			return;
		}
		if (SteamInventoryManager.iid.ksp)
		{
			Debug.LogWarning(a.bri());
			return;
		}
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.brj(), null);
		string text;
		if (table == null)
		{
			text = null;
		}
		else
		{
			StringTableEntry entry = table.GetEntry(a.brk());
			text = ((entry != null) ? entry.GetLocalizedString() : null);
		}
		string text2 = text ?? a.brl();
		string text3;
		if (table == null)
		{
			text3 = null;
		}
		else
		{
			StringTableEntry entry2 = table.GetEntry(a.brm());
			text3 = ((entry2 != null) ? entry2.GetLocalizedString() : null);
		}
		string text4 = text3 ?? a.brn();
		string text5;
		if (table == null)
		{
			text5 = null;
		}
		else
		{
			StringTableEntry entry3 = table.GetEntry(a.bro());
			text5 = ((entry3 != null) ? entry3.GetLocalizedString() : null);
		}
		string text6 = text5 ?? a.brp();
		string text7;
		if (table == null)
		{
			text7 = null;
		}
		else
		{
			StringTableEntry entry4 = table.GetEntry(a.brq());
			text7 = ((entry4 != null) ? entry4.GetLocalizedString() : null);
		}
		string text8 = text7 ?? a.brr();
		string text9;
		if (table == null)
		{
			text9 = null;
		}
		else
		{
			StringTableEntry entry5 = table.GetEntry(a.brs());
			text9 = ((entry5 != null) ? entry5.GetLocalizedString() : null);
		}
		string text10 = text9 ?? a.brt();
		string text11;
		if (table == null)
		{
			text11 = null;
		}
		else
		{
			StringTableEntry entry6 = table.GetEntry(a.bru());
			text11 = ((entry6 != null) ? entry6.GetLocalizedString() : null);
		}
		string text12 = text11 ?? a.brv();
		string text13;
		if (table == null)
		{
			text13 = null;
		}
		else
		{
			StringTableEntry entry7 = table.GetEntry(a.brw());
			text13 = ((entry7 != null) ? entry7.GetLocalizedString() : null);
		}
		string text14 = text13 ?? a.brx();
		string[] array = new string[-54];
		array[0] = text4;
		array[1] = a.bry();
		array[2] = text6;
		array[3] = a.brz();
		array[4] = text8;
		array[5] = a.bsa();
		array[6] = text10;
		array[7] = a.bsb();
		array[8] = text12;
		string text15 = string.Concat(array);
		ModalDialogManager.icb.ShowTypingConfirm(text2, text15, a.bsc(), text14, new Action(dn.<>c.<>9.btk), null);
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x0002A301 File Offset: 0x00028501
	private void bvd(float a)
	{
		if (this.sliderBMG != null && !Mathf.Approximately(this.sliderBMG.value, a))
		{
			this.sliderBMG.value = a;
		}
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x0002A330 File Offset: 0x00028530
	private void lwb()
	{
		if (this.inputSteamStatus == null)
		{
			return;
		}
		string @string = PlayerPrefs.GetString(a.bsd(), a.bse());
		this.inputSteamStatus.text = @string;
		if (!string.IsNullOrWhiteSpace(@string))
		{
			dq dq = dq.kqv;
			if (dq == null)
			{
				return;
			}
			dq.ccp(@string);
		}
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x0002A380 File Offset: 0x00028580
	private void jnm(bool a)
	{
		IntPtr activeWindow = dn.GetActiveWindow();
		if (activeWindow != IntPtr.Zero)
		{
			int num = dn.GetWindowLong(activeWindow, -71);
			if (a)
			{
				num &= -8;
				num |= 48;
			}
			else
			{
				num &= 12;
				num |= 49;
			}
			dn.SetWindowLong(activeWindow, 16, num);
		}
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x0002A3CC File Offset: 0x000285CC
	private void ger()
	{
		bq.hlk = false;
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.bsf(), null);
		string text = dn.byp(table, a.bsg(), a.bsh());
		fa fa = fa.imk;
		if (fa == null)
		{
			if (ModalDialogManager.kri && !ModalDialogManager.icb.krh)
			{
				ModalDialogManager.icb.ShowMessage(text, dn.byp(table, a.bsi(), a.bsj()), null);
			}
			return;
		}
		if (this.btnCheckNow != null)
		{
			this.btnCheckNow.interactable = false;
			base.StartCoroutine(this.byl(886f));
		}
		fa.cuu();
		if (!ModalDialogManager.kri)
		{
			return;
		}
		if (ModalDialogManager.icb.krh)
		{
			return;
		}
		string text2 = dn.byo(fa.imm, table);
		if (fa.imm == fa.CheckStatus.ApiUnavailable && !string.IsNullOrEmpty(fa.imq))
		{
			text2 = text2 + a.bsk() + fa.imq + a.bsl();
		}
		ModalDialogManager.icb.ShowMessage(text, text2, null);
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x06000767 RID: 1895 RVA: 0x0002A4D3 File Offset: 0x000286D3
	private int kqp
	{
		get
		{
			return 1 + ((eb.krm != null) ? eb.krm.idp : 0);
		}
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x0002A4F4 File Offset: 0x000286F4
	public void mdf()
	{
		bq.hlo = PlayerPrefs.GetInt(a.bsm(), 0);
		bq.hlp = PlayerPrefs.GetInt(a.bsn(), 2);
		bq.hlq = PlayerPrefs.GetInt(a.bso(), 2);
		bq.hlr = PlayerPrefs.GetInt(a.bsp(), 2);
		bq.hls = PlayerPrefs.GetInt(a.bsq(), 1) == 1;
		bq.hlt = PlayerPrefs.GetInt(a.bsr(), 0) == 1;
		bq.hlu = PlayerPrefs.GetInt(a.bss(), 0) == 1;
		bq.hlv = PlayerPrefs.GetInt(a.bst(), 0) == 1;
		this.toggleTop.SetIsOnWithoutNotify(bq.hls);
		this.toggleFlip.SetIsOnWithoutNotify(bq.hlt);
		this.toggleLockPosition.SetIsOnWithoutNotify(bq.hlu);
		if (bq.hlu)
		{
			CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
			if (characterDragTarget != null)
			{
				characterDragTarget.bhb();
			}
		}
		this.bwv(bq.hlu);
		if (this.toggleAutoHideDownUI != null)
		{
			this.toggleAutoHideDownUI.gameObject.SetActive(true);
			this.toggleAutoHideDownUI.SetIsOnWithoutNotify(bq.hlv);
		}
		bq.hlw = PlayerPrefs.GetInt(a.bsu(), 1) == 1;
		if (this.toggleHotkey != null)
		{
			this.toggleHotkey.isOn = bq.hlw;
		}
		if (this.hotkeyHintPanel != null)
		{
			this.hotkeyHintPanel.SetActive(bq.hlw);
		}
		this.bxk();
		bq.hlx = PlayerPrefs.GetInt(a.bsv(), 1) == 1;
		if (this.toggleRightClickQuickMenu != null)
		{
			this.toggleRightClickQuickMenu.SetIsOnWithoutNotify(bq.hlx);
		}
		this.bvk();
		this.bvl();
		this.bvr();
		this.bwc();
		this.bxc();
		this.bwf();
		this.bxl();
		this.bxv();
		this.bxy();
		this.byc();
		this.bxf();
		this.bxh();
		this.byg();
		this.bvg();
		this.byw();
		try
		{
			this.bzb();
		}
		catch (Exception ex)
		{
			string text = a.bsw();
			Exception ex2 = ex;
			Debug.LogError(text + ((ex2 != null) ? ex2.ToString() : null));
		}
		this.hxr = base.GetComponentsInChildren<bb>(true);
		this.bvc();
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x0002A738 File Offset: 0x00028938
	private bool cac(int a, string b)
	{
		bool flag;
		try
		{
			flag = AiSecretStore.StoreKey(a, b);
		}
		catch (Exception ex)
		{
			string text = a.bsx();
			Exception ex2 = ex;
			Debug.LogError(text + ((ex2 != null) ? ex2.ToString() : null));
			flag = false;
		}
		return flag;
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x0002A784 File Offset: 0x00028984
	private void byg()
	{
		q.tt();
		if (this.toggleAutoStart == null)
		{
			return;
		}
		if (!q.kmh)
		{
			this.toggleAutoStart.gameObject.SetActive(false);
			return;
		}
		bool flag = PlayerPrefs.GetInt(a.hd(), 0) == 1;
		if (!q.tp(flag))
		{
			q.tq(flag);
		}
		this.toggleAutoStart.SetIsOnWithoutNotify(flag);
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x0002A7E8 File Offset: 0x000289E8
	private void gog()
	{
		if (this.inputSteamStatus == null)
		{
			return;
		}
		string @string = PlayerPrefs.GetString(a.bsy(), a.bsz());
		this.inputSteamStatus.text = @string;
		if (!string.IsNullOrWhiteSpace(@string))
		{
			dq dq = dq.kqv;
			if (dq == null)
			{
				return;
			}
			dq.ccp(@string);
		}
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x0002A838 File Offset: 0x00028A38
	private int bwl()
	{
		if (!bq.hlz)
		{
			return this.bwj(bq.hly);
		}
		return this.kqp;
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x0002A854 File Offset: 0x00028A54
	private int bwj(int a)
	{
		int num = this.kqp;
		if (a >= num)
		{
			return a + 1;
		}
		return a;
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x0002A871 File Offset: 0x00028A71
	private IEnumerator byl(float a)
	{
		yield return new WaitForSecondsRealtime(a);
		if (this.btnCheckNow != null)
		{
			this.btnCheckNow.interactable = true;
		}
		yield break;
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x0002A888 File Offset: 0x00028A88
	private void bzp(string a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		string text = (a ?? a.tk()).Trim();
		if (string.IsNullOrEmpty(text))
		{
			playerSaveData.directApiTemplateCustomized = false;
			playerSaveData.directApiPromptTemplate = a.tk();
			if (this.inputPromptTemplate != null)
			{
				this.inputPromptTemplate.text = AiPromptComposer.GetLocalizedDefaultTemplate();
			}
		}
		else
		{
			playerSaveData.directApiTemplateCustomized = true;
			playerSaveData.directApiPromptTemplate = text;
		}
		ci.Save(null);
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x0002A918 File Offset: 0x00028B18
	private void bvl()
	{
		if (Application.platform != RuntimePlatform.WindowsPlayer && Application.platform != RuntimePlatform.WindowsEditor)
		{
			if (this.toggleTaskbar != null)
			{
				this.toggleTaskbar.gameObject.SetActive(false);
			}
			return;
		}
		bool flag = PlayerPrefs.GetInt(a.bpo(), 1) == 1;
		bool flag2 = PlayerPrefs.GetInt(a.bkz(), 1) == 1;
		if (this.toggleTaskbar != null)
		{
			this.toggleTaskbar.isOn = flag;
		}
		if (this.toggleTaskbarSnap != null)
		{
			this.toggleTaskbarSnap.isOn = flag2;
			this.windowDragHandler.enableAutoSnap = flag2;
		}
		this.bvq(flag);
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x0002A9C0 File Offset: 0x00028BC0
	private static string bye(string a, string b)
	{
		string text;
		try
		{
			if (!LocalizationSettings.InitializationOperation.IsDone)
			{
				text = b;
			}
			else
			{
				StringTable table = LocalizationSettings.StringDatabase.GetTable(a.rh(), null);
				StringTableEntry stringTableEntry = ((table != null) ? table.GetEntry(a) : null);
				string text2 = ((stringTableEntry != null) ? stringTableEntry.GetLocalizedString() : null);
				text = (string.IsNullOrEmpty(text2) ? b : text2);
			}
		}
		catch
		{
			text = b;
		}
		return text;
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x0002AA34 File Offset: 0x00028C34
	public void bik()
	{
		bq.hlo = PlayerPrefs.GetInt(a.bta(), 0);
		bq.hlp = PlayerPrefs.GetInt(a.btb(), 2);
		bq.hlq = PlayerPrefs.GetInt(a.btc(), 2);
		bq.hlr = PlayerPrefs.GetInt(a.btd(), 2);
		bq.hls = PlayerPrefs.GetInt(a.bte(), 1) == 1;
		bq.hlt = PlayerPrefs.GetInt(a.btf(), 0) == 1;
		bq.hlu = PlayerPrefs.GetInt(a.btg(), 0) == 1;
		bq.hlv = PlayerPrefs.GetInt(a.bth(), 0) == 1;
		this.toggleTop.SetIsOnWithoutNotify(bq.hls);
		this.toggleFlip.SetIsOnWithoutNotify(bq.hlt);
		this.toggleLockPosition.SetIsOnWithoutNotify(bq.hlu);
		if (bq.hlu)
		{
			CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
			if (characterDragTarget != null)
			{
				characterDragTarget.bhb();
			}
		}
		this.bwv(bq.hlu);
		if (this.toggleAutoHideDownUI != null)
		{
			this.toggleAutoHideDownUI.gameObject.SetActive(true);
			this.toggleAutoHideDownUI.SetIsOnWithoutNotify(bq.hlv);
		}
		bq.hlw = PlayerPrefs.GetInt(a.bti(), 1) == 1;
		if (this.toggleHotkey != null)
		{
			this.toggleHotkey.isOn = bq.hlw;
		}
		if (this.hotkeyHintPanel != null)
		{
			this.hotkeyHintPanel.SetActive(bq.hlw);
		}
		this.bxk();
		bq.hlx = PlayerPrefs.GetInt(a.btj(), 1) == 1;
		if (this.toggleRightClickQuickMenu != null)
		{
			this.toggleRightClickQuickMenu.SetIsOnWithoutNotify(bq.hlx);
		}
		this.bvk();
		this.bvl();
		this.bvr();
		this.bwc();
		this.bxc();
		this.bwf();
		this.bxl();
		this.bxv();
		this.bxy();
		this.byc();
		this.bxf();
		this.bxh();
		this.byg();
		this.bvg();
		this.byw();
		try
		{
			this.bzb();
		}
		catch (Exception ex)
		{
			string text = a.btk();
			Exception ex2 = ex;
			Debug.LogError(text + ((ex2 != null) ? ex2.ToString() : null));
		}
		this.hxr = base.GetComponentsInChildren<bb>(true);
		this.bvc();
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x0002AC78 File Offset: 0x00028E78
	private static string dof(string a, string b)
	{
		string text;
		try
		{
			if (!LocalizationSettings.InitializationOperation.IsDone)
			{
				text = b;
			}
			else
			{
				StringTable table = LocalizationSettings.StringDatabase.GetTable(a.btl(), null);
				StringTableEntry stringTableEntry = ((table != null) ? table.GetEntry(a) : null);
				string text2 = ((stringTableEntry != null) ? stringTableEntry.GetLocalizedString() : null);
				text = (string.IsNullOrEmpty(text2) ? b : text2);
			}
		}
		catch
		{
			text = b;
		}
		return text;
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x0002ACEC File Offset: 0x00028EEC
	private void bzu(Locale a)
	{
		this.bzv();
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x0002ACF4 File Offset: 0x00028EF4
	private void mgx()
	{
		try
		{
			dz.cgu();
			Application.OpenURL(new Uri(dz.cgt()).AbsoluteUri);
			if (this.btnOpenCustomGameList != null)
			{
				this.btnOpenCustomGameList.interactable = false;
				base.StartCoroutine(this.buz(-5460f));
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.btm() + ex.Message);
		}
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x0002AD70 File Offset: 0x00028F70
	public void mve(bool a)
	{
		bq.hlk = false;
		this.bvq(a);
		PlayerPrefs.SetInt(a.btn(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x0002AD95 File Offset: 0x00028F95
	private IEnumerator bzs(Button a, float b)
	{
		if (a == null)
		{
			yield break;
		}
		a.interactable = false;
		yield return new WaitForSecondsRealtime(b);
		if (a != null)
		{
			a.interactable = true;
		}
		yield break;
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x00028079 File Offset: 0x00026279
	private void bzy()
	{
		this.bzw();
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x0002ADAC File Offset: 0x00028FAC
	private void bxv()
	{
		if (this.dropdownFPS == null)
		{
			return;
		}
		int num = dn.bxt();
		dn.bxu(num);
		List<string> list = new List<string>();
		int num2 = 0;
		string text = dn.bxw();
		for (int i = 0; i < dn.FPSOptions.Length; i++)
		{
			int num3 = dn.FPSOptions[i];
			list.Add((num3 == -1) ? text : num3.ToString());
			if (num3 == num)
			{
				num2 = i;
			}
		}
		this.dropdownFPS.ClearOptions();
		this.dropdownFPS.AddOptions(list);
		this.dropdownFPS.SetValueWithoutNotify(num2);
		this.dropdownFPS.RefreshShownValue();
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x0002AE50 File Offset: 0x00029050
	private void czk(string a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || string.IsNullOrEmpty(a))
		{
			return;
		}
		if (a == this.hyv && Time.unscaledTime - this.hyu < 4237f)
		{
			return;
		}
		if (this.hyw)
		{
			return;
		}
		string text = this.cab(playerSaveData.directApiProviderId);
		if (string.IsNullOrEmpty(text))
		{
			this.bzx(dn.byy(a.bto(), a.btp()));
			return;
		}
		if (AiRequestRunner.Instance.IsChatBusy)
		{
			this.bzx(dn.byy(a.btq(), a.btr()));
			return;
		}
		int directApiProviderId = playerSaveData.directApiProviderId;
		AiProviderConfig aiProviderConfig = AiProviderCatalog.For((AiProviderId)directApiProviderId);
		string text2 = ((aiProviderConfig.AllowsCustomBaseUrl && !string.IsNullOrEmpty(playerSaveData.directApiBaseUrl)) ? playerSaveData.directApiBaseUrl : aiProviderConfig.DefaultBaseUrl);
		IAiChatAdapter aiChatAdapter = AiAdapterFactory.Create((AiProviderId)directApiProviderId);
		AiChatRequest aiChatRequest = new AiChatRequest(a, a.bts(), a.btt(), -26, 6957f);
		this.hyw = true;
		this.hyu = Time.unscaledTime;
		this.hyv = a;
		this.bzx(dn.byy(a.btu(), a.btv()));
		AiRequestRunner.Instance.SendChat(aiChatAdapter, aiProviderConfig, text2, text, aiChatRequest, -41, new Action<AiChatResult>(this.bzm));
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x0002AF9C File Offset: 0x0002919C
	public void nqo(bool a)
	{
		bq.hlk = false;
		bq.hlt = a;
		for (int i = 0; i < this.flipTarget.Length; i++)
		{
			Vector3 localScale = this.flipTarget[i].localScale;
			localScale.x = math.abs(localScale.x) * (float)(a ? (-1) : 1);
			this.flipTarget[i].localScale = localScale;
		}
		if (this.flipExcludedTargets != null)
		{
			for (int j = 0; j < this.flipExcludedTargets.Length; j++)
			{
				if (!(this.flipExcludedTargets[j] == null))
				{
					Vector3 localScale2 = this.flipExcludedTargets[j].localScale;
					localScale2.x = math.abs(localScale2.x);
					this.flipExcludedTargets[j].localScale = localScale2;
				}
			}
		}
		PlayerPrefs.SetInt(a.btw(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x0002B06E File Offset: 0x0002926E
	public void ecz(bool a)
	{
		bq.hlk = false;
		if (bo.hke != null)
		{
			bo.hke.yq(a);
			return;
		}
		PlayerPrefs.SetInt(a.btx(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x0002B0A8 File Offset: 0x000292A8
	private void nke(int a)
	{
		if (this.hyj)
		{
			return;
		}
		bq.hlk = false;
		bl bl = bl.kmv;
		if (bl == null)
		{
			return;
		}
		int num = this.bwk(a);
		if (num == -1)
		{
			bl.xm(true);
			bl.xk();
			return;
		}
		if (num < 0 || num >= bl.kmu)
		{
			num = 0;
		}
		if (this.bwe(num))
		{
			this.hyj = true;
			this.dropdownCharacterMode.value = this.bwl();
			this.dropdownCharacterMode.RefreshShownValue();
			this.hyj = false;
			return;
		}
		bl.xm(false);
		bl.xu();
		bl.xh(num);
		int num2 = ((bl.hjk > 0) ? bl.hjk : bq.hly);
		PlayerPrefs.SetInt(a.bty(), num2);
		PlayerPrefs.Save();
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x0002B16C File Offset: 0x0002936C
	private void idi(List<string> a, string b)
	{
		dn.de de = new dn.de();
		de.hwn = b;
		if (this.dropdownAiModel == null)
		{
			return;
		}
		this.dropdownAiModel.ClearOptions();
		if (a == null || a.Count == 0)
		{
			this.dropdownAiModel.RefreshShownValue();
			return;
		}
		this.dropdownAiModel.AddOptions(a);
		int num = 0;
		if (!string.IsNullOrEmpty(de.hwn))
		{
			int num2 = a.FindIndex(new Predicate<string>(de.btp));
			if (num2 >= 0)
			{
				num = num2;
			}
		}
		this.dropdownAiModel.SetValueWithoutNotify(num);
		this.dropdownAiModel.RefreshShownValue();
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x0002B204 File Offset: 0x00029404
	private void iiq(bool a)
	{
		IntPtr activeWindow = dn.GetActiveWindow();
		if (activeWindow != IntPtr.Zero)
		{
			int num = dn.GetWindowLong(activeWindow, -24);
			if (a)
			{
				num &= 14;
				num |= -25;
			}
			else
			{
				num &= 35;
				num |= -68;
			}
			dn.SetWindowLong(activeWindow, 83, num);
		}
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x0002B250 File Offset: 0x00029450
	private bool cqg(int a)
	{
		bool flag;
		try
		{
			flag = AiSecretStore.MigrateLegacyKey(a);
		}
		catch (Exception ex)
		{
			string text = a.btz();
			Exception ex2 = ex;
			Debug.LogError(text + ((ex2 != null) ? ex2.ToString() : null));
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x0002B298 File Offset: 0x00029498
	private void byb(int a)
	{
		if (!Enum.IsDefined(typeof(DropNotificationMode), a))
		{
			return;
		}
		bq.hma = (DropNotificationMode)a;
		PlayerPrefs.SetInt(a.ru(), a);
		PlayerPrefs.Save();
		if (bq.hma == DropNotificationMode.Off)
		{
			PlayerData hlf = bq.hlf;
			PlayerSaveData playerSaveData = ((hlf != null) ? hlf.playerSaveData : null);
			if (((playerSaveData != null) ? playerSaveData.newItemDefIds : null) != null && playerSaveData.newItemDefIds.Count > 0)
			{
				playerSaveData.newItemDefIds.Clear();
				ci.Save(null);
				if (cx.kpw != null)
				{
					cx.kpw.brh();
				}
			}
		}
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x0002B330 File Offset: 0x00029530
	private int cae()
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return 0;
		}
		return playerSaveData.directApiProviderId;
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x0002B364 File Offset: 0x00029564
	private void gbi()
	{
		if (this.dropdownConnectionMode == null)
		{
			return;
		}
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData != null)
		{
			this.bzz(playerSaveData.directApiProviderId);
		}
		this.dropdownConnectionMode.ClearOptions();
		List<string> list = new List<string>();
		foreach (AiConnectionMode aiConnectionMode in dn.hyt)
		{
			list.Add(dn.bza(aiConnectionMode));
		}
		this.dropdownConnectionMode.AddOptions(list);
		this.dropdownConnectionMode.SetValueWithoutNotify((playerSaveData != null) ? dn.byz((AiConnectionMode)Mathf.Clamp(playerSaveData.aiConnectionMode, 0, 2)) : 0);
		this.dropdownConnectionMode.RefreshShownValue();
		this.dropdownConnectionMode.onValueChanged.AddListener(new UnityAction<int>(this.bzc));
		if (this.dropdownAiProvider != null)
		{
			List<string> list2 = new List<string>();
			foreach (AiProviderConfig aiProviderConfig in AiProviderCatalog.All)
			{
				list2.Add(aiProviderConfig.DisplayName);
			}
			this.dropdownAiProvider.ClearOptions();
			this.dropdownAiProvider.AddOptions(list2);
			this.dropdownAiProvider.SetValueWithoutNotify((playerSaveData != null) ? Mathf.Clamp(playerSaveData.directApiProviderId, 0, list2.Count - 1) : 0);
			this.dropdownAiProvider.RefreshShownValue();
			this.dropdownAiProvider.onValueChanged.AddListener(new UnityAction<int>(this.bzf));
		}
		if (this.dropdownChattiness != null)
		{
			this.dropdownChattiness.ClearOptions();
			this.dropdownChattiness.AddOptions(new List<string>
			{
				dn.byy(a.bua(), a.bub()),
				dn.byy(a.buc(), a.bud()),
				dn.byy(a.bue(), a.buf())
			});
			this.dropdownChattiness.SetValueWithoutNotify((playerSaveData != null) ? Mathf.Clamp(playerSaveData.directApiChattinessTier, 0, 2) : 1);
			this.dropdownChattiness.RefreshShownValue();
			this.dropdownChattiness.onValueChanged.AddListener(new UnityAction<int>(this.bzo));
		}
		if (this.inputApiKey != null)
		{
			this.inputApiKey.contentType = TMP_InputField.ContentType.Password;
			this.inputApiKey.text = a.bug();
			this.inputApiKey.onEndEdit.AddListener(new UnityAction<string>(this.bzg));
			this.caf();
		}
		if (this.inputCustomBaseUrl != null)
		{
			this.inputCustomBaseUrl.text = ((playerSaveData != null) ? playerSaveData.directApiBaseUrl : a.buh());
			this.inputCustomBaseUrl.onEndEdit.AddListener(new UnityAction<string>(this.bzh));
		}
		if (this.dropdownAiModel != null)
		{
			List<string> list3 = new List<string>();
			if (playerSaveData != null && !string.IsNullOrEmpty(playerSaveData.directApiModel))
			{
				list3.Add(playerSaveData.directApiModel);
			}
			this.bzn(list3, (playerSaveData != null) ? playerSaveData.directApiModel : null);
			this.dropdownAiModel.onValueChanged.AddListener(new UnityAction<int>(this.bzi));
		}
		if (this.btnRefreshModels != null)
		{
			this.btnRefreshModels.onClick.AddListener(new UnityAction(this.bzj));
		}
		if (this.inputPromptTemplate != null)
		{
			this.inputPromptTemplate.lineType = TMP_InputField.LineType.MultiLineNewline;
			this.inputPromptTemplate.text = this.bzt(playerSaveData);
			this.inputPromptTemplate.onEndEdit.AddListener(new UnityAction<string>(this.bzp));
		}
		if (this.btnRestorePromptDefault != null)
		{
			this.btnRestorePromptDefault.onClick.AddListener(new UnityAction(this.bzq));
		}
		if (this.btnTalkNow != null)
		{
			this.btnTalkNow.onClick.AddListener(new UnityAction(this.bzr));
		}
		if (this.directPrivacyTip != null)
		{
			this.directPrivacyTip.SetActive(false);
		}
		this.bze((AiConnectionMode)((playerSaveData != null) ? playerSaveData.aiConnectionMode : 0));
		this.bzw();
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x0002B79C File Offset: 0x0002999C
	private void ioy()
	{
		bq.hlk = false;
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.bui(), null);
		string text = dn.byp(table, a.buj(), a.buk());
		fa fa = fa.imk;
		if (fa == null)
		{
			if (ModalDialogManager.kri && !ModalDialogManager.icb.krh)
			{
				ModalDialogManager.icb.ShowMessage(text, dn.byp(table, a.bul(), a.bum()), null);
			}
			return;
		}
		if (this.btnCheckNow != null)
		{
			this.btnCheckNow.interactable = false;
			base.StartCoroutine(this.byl(-6020f));
		}
		fa.cuu();
		if (!ModalDialogManager.kri)
		{
			return;
		}
		if (ModalDialogManager.icb.krh)
		{
			return;
		}
		string text2 = dn.byo(fa.imm, table);
		if (fa.imm == fa.CheckStatus.ApiUnavailable && !string.IsNullOrEmpty(fa.imq))
		{
			text2 = text2 + a.bun() + fa.imq + a.buo();
		}
		ModalDialogManager.icb.ShowMessage(text, text2, null);
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x0002B8A4 File Offset: 0x00029AA4
	private void cfn()
	{
		if (this.dropdownSize != null)
		{
			this.dropdownSize.onValueChanged.AddListener(new UnityAction<int>(this.bxp));
		}
		this.sliderSound.onValueChanged.AddListener(new UnityAction<float>(this.bvs));
		this.sliderBMG.onValueChanged.AddListener(new UnityAction<float>(this.bvt));
		this.sliderSFX.onValueChanged.AddListener(new UnityAction<float>(this.bvw));
		this.sliderVoice.onValueChanged.AddListener(new UnityAction<float>(this.bvx));
		this.bwa(this.sliderSound.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvu));
		this.bwa(this.sliderBMG.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvv));
		this.bwa(this.sliderSFX.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvy));
		this.bwa(this.sliderVoice.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvz));
		if (this.muteButtonSound != null)
		{
			this.muteButtonSound.hzh += this.bvf;
		}
		if (this.muteButtonBGM != null)
		{
			this.muteButtonBGM.hzh += this.bvf;
		}
		if (this.muteButtonSFX != null)
		{
			this.muteButtonSFX.hzh += this.bvf;
		}
		if (this.muteButtonVoice != null)
		{
			this.muteButtonVoice.hzh += this.bvf;
		}
		dn.bwb(this.sliderSound);
		dn.bwb(this.sliderBMG);
		dn.bwb(this.sliderSFX);
		dn.bwb(this.sliderVoice);
		if (this.dropdownUISize != null)
		{
			this.dropdownUISize.onValueChanged.AddListener(new UnityAction<int>(this.bxq));
		}
		if (this.dropdownToolbarSize != null)
		{
			this.dropdownToolbarSize.onValueChanged.AddListener(new UnityAction<int>(this.bxr));
		}
		if (this.dropdownSpeechBubbleSize != null)
		{
			this.dropdownSpeechBubbleSize.onValueChanged.AddListener(new UnityAction<int>(this.bxs));
		}
		this.btnCloseGame.onClick.AddListener(new UnityAction(this.byj));
		this.btnSteamInventory.onClick.AddListener(new UnityAction(this.byr));
		this.btnDiscord.onClick.AddListener(new UnityAction(this.bys));
		if (this.btnWorkshop != null)
		{
			this.btnWorkshop.onClick.AddListener(new UnityAction(this.byt));
		}
		if (this.btnTroubleshooting != null)
		{
			this.btnTroubleshooting.onClick.AddListener(new UnityAction(this.byu));
		}
		this.toggleTop.onValueChanged.AddListener(new UnityAction<bool>(this.byv));
		this.toggleFlip.onValueChanged.AddListener(new UnityAction<bool>(this.byi));
		if (this.toggleDropAnimation != null)
		{
			this.toggleDropAnimation.onValueChanged.AddListener(new UnityAction<bool>(this.bxg));
		}
		if (this.toggleDisableMassagerIdle != null)
		{
			this.toggleDisableMassagerIdle.onValueChanged.AddListener(new UnityAction<bool>(this.bxi));
		}
		if (this.dropdownLanguage != null)
		{
			this.dropdownLanguage.onValueChanged.AddListener(new UnityAction<int>(this.bvj));
		}
		this.btnMonitor.onClick.AddListener(new UnityAction(this.bvm));
		this.toggleTaskbar.onValueChanged.AddListener(new UnityAction<bool>(this.bvo));
		this.toggleTaskbarSnap.onValueChanged.AddListener(new UnityAction<bool>(this.bvp));
		this.toggleLockPosition.onValueChanged.AddListener(new UnityAction<bool>(this.bwu));
		if (this.btnResetCharacterPosition != null)
		{
			this.btnResetCharacterPosition.onClick.AddListener(new UnityAction(this.bwx));
		}
		if (this.btnRepairWindow != null)
		{
			this.btnRepairWindow.onClick.AddListener(new UnityAction(this.bwy));
			if (!ModalDialogManager.kri)
			{
				this.btnRepairWindow.interactable = false;
				this.hym = true;
				Debug.LogWarning(a.bup());
			}
		}
		if (this.btnDeleteAllItems != null)
		{
			this.btnDeleteAllItems.onClick.AddListener(new UnityAction(this.byq));
			if (!ModalDialogManager.kri)
			{
				this.btnDeleteAllItems.interactable = false;
				Debug.LogWarning(a.buq());
			}
		}
		this.toggleAutoHideDownUI.onValueChanged.AddListener(new UnityAction<bool>(this.bxb));
		if (this.toggleHotkey != null)
		{
			this.toggleHotkey.onValueChanged.AddListener(new UnityAction<bool>(this.bxe));
		}
		if (this.toggleRightClickQuickMenu != null)
		{
			this.toggleRightClickQuickMenu.onValueChanged.AddListener(new UnityAction<bool>(this.bxj));
		}
		if (this.inputSteamStatus != null)
		{
			this.inputSteamStatus.onEndEdit.AddListener(new UnityAction<string>(this.bwd));
		}
		if (this.dropdownCharacterMode != null)
		{
			this.dropdownCharacterMode.onValueChanged.AddListener(new UnityAction<int>(this.bwo));
		}
		if (this.dropdownVoice != null)
		{
			this.dropdownVoice.onValueChanged.AddListener(new UnityAction<int>(this.bws));
			base.StartCoroutine(this.bwp());
		}
		if (this.dropdownFPS != null)
		{
			this.dropdownFPS.onValueChanged.AddListener(new UnityAction<int>(this.bxx));
		}
		if (this.dropdownDropNotification != null)
		{
			this.dropdownDropNotification.onValueChanged.AddListener(new UnityAction<int>(this.byb));
		}
		if (this.dropdownDirtiness != null)
		{
			this.dropdownDirtiness.onValueChanged.AddListener(new UnityAction<int>(this.byf));
		}
		if (this.toggleAutoStart != null)
		{
			this.toggleAutoStart.onValueChanged.AddListener(new UnityAction<bool>(this.byh));
		}
		if (this.toggleDiscordRichPresence != null)
		{
			this.toggleDiscordRichPresence.onValueChanged.AddListener(new UnityAction<bool>(this.bxd));
		}
		if (this.btnCheckNow != null)
		{
			this.btnCheckNow.onClick.AddListener(new UnityAction(this.byk));
		}
		if (this.btnRestartUpdate != null)
		{
			this.btnRestartUpdate.onClick.AddListener(new UnityAction(this.bym));
			this.btnRestartUpdate.interactable = true;
		}
		if (this.objUpdateStatus != null)
		{
			this.objUpdateStatus.SetActive(false);
		}
		if (this.objUpdateBadge != null)
		{
			this.objUpdateBadge.un(false);
		}
		this.bux();
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x0002BFF5 File Offset: 0x0002A1F5
	private IEnumerator bwg()
	{
		yield return LocalizationSettings.InitializationOperation;
		this.bwh();
		yield break;
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x0002C004 File Offset: 0x0002A204
	private void bcp()
	{
		if (this.dropdownSize != null)
		{
			this.dropdownSize.onValueChanged.AddListener(new UnityAction<int>(this.bxp));
		}
		this.sliderSound.onValueChanged.AddListener(new UnityAction<float>(this.bvs));
		this.sliderBMG.onValueChanged.AddListener(new UnityAction<float>(this.bvt));
		this.sliderSFX.onValueChanged.AddListener(new UnityAction<float>(this.bvw));
		this.sliderVoice.onValueChanged.AddListener(new UnityAction<float>(this.bvx));
		this.bwa(this.sliderSound.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvu));
		this.bwa(this.sliderBMG.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvv));
		this.bwa(this.sliderSFX.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvy));
		this.bwa(this.sliderVoice.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvz));
		if (this.muteButtonSound != null)
		{
			this.muteButtonSound.hzh += this.bvf;
		}
		if (this.muteButtonBGM != null)
		{
			this.muteButtonBGM.hzh += this.bvf;
		}
		if (this.muteButtonSFX != null)
		{
			this.muteButtonSFX.hzh += this.bvf;
		}
		if (this.muteButtonVoice != null)
		{
			this.muteButtonVoice.hzh += this.bvf;
		}
		dn.bwb(this.sliderSound);
		dn.bwb(this.sliderBMG);
		dn.bwb(this.sliderSFX);
		dn.bwb(this.sliderVoice);
		if (this.dropdownUISize != null)
		{
			this.dropdownUISize.onValueChanged.AddListener(new UnityAction<int>(this.bxq));
		}
		if (this.dropdownToolbarSize != null)
		{
			this.dropdownToolbarSize.onValueChanged.AddListener(new UnityAction<int>(this.bxr));
		}
		if (this.dropdownSpeechBubbleSize != null)
		{
			this.dropdownSpeechBubbleSize.onValueChanged.AddListener(new UnityAction<int>(this.bxs));
		}
		this.btnCloseGame.onClick.AddListener(new UnityAction(this.byj));
		this.btnSteamInventory.onClick.AddListener(new UnityAction(this.byr));
		this.btnDiscord.onClick.AddListener(new UnityAction(this.bys));
		if (this.btnWorkshop != null)
		{
			this.btnWorkshop.onClick.AddListener(new UnityAction(this.byt));
		}
		if (this.btnTroubleshooting != null)
		{
			this.btnTroubleshooting.onClick.AddListener(new UnityAction(this.byu));
		}
		this.toggleTop.onValueChanged.AddListener(new UnityAction<bool>(this.byv));
		this.toggleFlip.onValueChanged.AddListener(new UnityAction<bool>(this.byi));
		if (this.toggleDropAnimation != null)
		{
			this.toggleDropAnimation.onValueChanged.AddListener(new UnityAction<bool>(this.bxg));
		}
		if (this.toggleDisableMassagerIdle != null)
		{
			this.toggleDisableMassagerIdle.onValueChanged.AddListener(new UnityAction<bool>(this.bxi));
		}
		if (this.dropdownLanguage != null)
		{
			this.dropdownLanguage.onValueChanged.AddListener(new UnityAction<int>(this.bvj));
		}
		this.btnMonitor.onClick.AddListener(new UnityAction(this.bvm));
		this.toggleTaskbar.onValueChanged.AddListener(new UnityAction<bool>(this.bvo));
		this.toggleTaskbarSnap.onValueChanged.AddListener(new UnityAction<bool>(this.bvp));
		this.toggleLockPosition.onValueChanged.AddListener(new UnityAction<bool>(this.bwu));
		if (this.btnResetCharacterPosition != null)
		{
			this.btnResetCharacterPosition.onClick.AddListener(new UnityAction(this.bwx));
		}
		if (this.btnRepairWindow != null)
		{
			this.btnRepairWindow.onClick.AddListener(new UnityAction(this.bwy));
			if (!ModalDialogManager.kri)
			{
				this.btnRepairWindow.interactable = false;
				this.hym = true;
				Debug.LogWarning(a.bur());
			}
		}
		if (this.btnDeleteAllItems != null)
		{
			this.btnDeleteAllItems.onClick.AddListener(new UnityAction(this.byq));
			if (!ModalDialogManager.kri)
			{
				this.btnDeleteAllItems.interactable = false;
				Debug.LogWarning(a.bus());
			}
		}
		this.toggleAutoHideDownUI.onValueChanged.AddListener(new UnityAction<bool>(this.bxb));
		if (this.toggleHotkey != null)
		{
			this.toggleHotkey.onValueChanged.AddListener(new UnityAction<bool>(this.bxe));
		}
		if (this.toggleRightClickQuickMenu != null)
		{
			this.toggleRightClickQuickMenu.onValueChanged.AddListener(new UnityAction<bool>(this.bxj));
		}
		if (this.inputSteamStatus != null)
		{
			this.inputSteamStatus.onEndEdit.AddListener(new UnityAction<string>(this.bwd));
		}
		if (this.dropdownCharacterMode != null)
		{
			this.dropdownCharacterMode.onValueChanged.AddListener(new UnityAction<int>(this.bwo));
		}
		if (this.dropdownVoice != null)
		{
			this.dropdownVoice.onValueChanged.AddListener(new UnityAction<int>(this.bws));
			base.StartCoroutine(this.bwp());
		}
		if (this.dropdownFPS != null)
		{
			this.dropdownFPS.onValueChanged.AddListener(new UnityAction<int>(this.bxx));
		}
		if (this.dropdownDropNotification != null)
		{
			this.dropdownDropNotification.onValueChanged.AddListener(new UnityAction<int>(this.byb));
		}
		if (this.dropdownDirtiness != null)
		{
			this.dropdownDirtiness.onValueChanged.AddListener(new UnityAction<int>(this.byf));
		}
		if (this.toggleAutoStart != null)
		{
			this.toggleAutoStart.onValueChanged.AddListener(new UnityAction<bool>(this.byh));
		}
		if (this.toggleDiscordRichPresence != null)
		{
			this.toggleDiscordRichPresence.onValueChanged.AddListener(new UnityAction<bool>(this.bxd));
		}
		if (this.btnCheckNow != null)
		{
			this.btnCheckNow.onClick.AddListener(new UnityAction(this.byk));
		}
		if (this.btnRestartUpdate != null)
		{
			this.btnRestartUpdate.onClick.AddListener(new UnityAction(this.bym));
			this.btnRestartUpdate.interactable = true;
		}
		if (this.objUpdateStatus != null)
		{
			this.objUpdateStatus.SetActive(false);
		}
		if (this.objUpdateBadge != null)
		{
			this.objUpdateBadge.un(false);
		}
		this.bux();
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x0002C755 File Offset: 0x0002A955
	public void bxi(bool a)
	{
		bq.hlk = false;
		bq.hmd = a;
		PlayerPrefs.SetInt(a.rj(), a ? 1 : 0);
		PlayerPrefs.Save();
		GirlController girlController = GirlController.kok;
		if (girlController == null)
		{
			return;
		}
		girlController.bfn();
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x0002C788 File Offset: 0x0002A988
	private void fgo()
	{
		if (this.objGameCompatRoot != null)
		{
			this.objGameCompatRoot.SetActive(true);
		}
		if (this.btnOpenCustomGameList != null)
		{
			this.btnOpenCustomGameList.onClick.AddListener(new UnityAction(this.buy));
		}
		if (this.objAdminModeRoot != null)
		{
			this.objAdminModeRoot.SetActive(true);
		}
		if (this.toggleAdminMode != null)
		{
			this.toggleAdminMode.SetIsOnWithoutNotify(d.mc());
			this.toggleAdminMode.onValueChanged.AddListener(new UnityAction<bool>(this.bva));
		}
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x0002C830 File Offset: 0x0002AA30
	private void eap(int a)
	{
		if (!Enum.IsDefined(typeof(DropNotificationMode), a))
		{
			return;
		}
		bq.hma = (DropNotificationMode)a;
		PlayerPrefs.SetInt(a.but(), a);
		PlayerPrefs.Save();
		if (bq.hma == DropNotificationMode.Off)
		{
			PlayerData hlf = bq.hlf;
			PlayerSaveData playerSaveData = ((hlf != null) ? hlf.playerSaveData : null);
			if (((playerSaveData != null) ? playerSaveData.newItemDefIds : null) != null && playerSaveData.newItemDefIds.Count > 0)
			{
				playerSaveData.newItemDefIds.Clear();
				ci.Save(null);
				if (cx.kpw != null)
				{
					cx.kpw.brh();
				}
			}
		}
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x0002C8C8 File Offset: 0x0002AAC8
	public void efn()
	{
		if (this.hyl != null)
		{
			return;
		}
		if (bx.hod == null)
		{
			Debug.LogWarning(a.buu());
			return;
		}
		if (!ModalDialogManager.kri)
		{
			Debug.LogWarning(a.buv());
			return;
		}
		this.hyl = base.StartCoroutine(this.bwz());
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x0002C91C File Offset: 0x0002AB1C
	public void hew(bool a)
	{
		bq.hlk = false;
		bool flag = q.tq(a);
		bool flag2 = a && !flag && q.kmh && d.mc();
		if (!flag && !flag2)
		{
			this.toggleAutoStart.SetIsOnWithoutNotify(!a);
			return;
		}
		PlayerPrefs.SetInt(a.buw(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x0002C978 File Offset: 0x0002AB78
	public void bxb(bool a)
	{
		bq.hlk = false;
		bq.hlv = a;
		PlayerPrefs.SetInt(a.bln(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x0002C99C File Offset: 0x0002AB9C
	public void jvr(bool a)
	{
		bq.hlk = false;
		bq.hmc = a;
		PlayerPrefs.SetInt(a.bux(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x00027663 File Offset: 0x00025863
	public void dtj(float a)
	{
		AudioManager.klw.qi(a, true);
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x0002796F File Offset: 0x00025B6F
	private static void jlg(Slider a)
	{
		if (a == null)
		{
			return;
		}
		if (a.GetComponent<w>() == null)
		{
			a.gameObject.AddComponent<w>();
		}
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x0002C9C0 File Offset: 0x0002ABC0
	private void grp(int a)
	{
		if (!Enum.IsDefined(typeof(DirtinessMode), a))
		{
			return;
		}
		bq.hmb = (DirtinessMode)a;
		PlayerPrefs.SetInt(a.buy(), a);
		PlayerPrefs.Save();
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x0002C9F0 File Offset: 0x0002ABF0
	public void pt()
	{
		bq.hlk = false;
		Application.Quit();
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x00027157 File Offset: 0x00025357
	public void ldy()
	{
		bq.hlk = false;
		CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
		if (characterDragTarget == null)
		{
			return;
		}
		characterDragTarget.bgy();
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x0002CA00 File Offset: 0x0002AC00
	private void bva(bool a)
	{
		bq.hlk = false;
		bool flag = d.md(a);
		bool flag2 = d.mc();
		if (this.toggleAdminMode != null)
		{
			this.toggleAdminMode.SetIsOnWithoutNotify(flag2);
		}
		if (q.kmh && PlayerPrefs.GetInt(a.hd(), 0) == 1)
		{
			q.tq(true);
		}
		if (!ModalDialogManager.kri)
		{
			return;
		}
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.rh(), null);
		string text;
		string text2;
		if (!flag)
		{
			text = dn.byp(table, a.buz(), a.bva());
			text2 = dn.byp(table, a.bvb(), a.bvc());
		}
		else if (flag2)
		{
			text = dn.byp(table, a.bvd(), a.bve());
			text2 = dn.byp(table, a.bvf(), a.bvg());
		}
		else
		{
			text = dn.byp(table, a.bvh(), a.bvi());
			text2 = dn.byp(table, a.bvj(), a.bvk());
		}
		ModalDialogManager.icb.ShowMessage(text, text2, null);
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x0002CAF8 File Offset: 0x0002ACF8
	private void fgt(AiChatResult a)
	{
		this.hyw = false;
		if (a == null)
		{
			return;
		}
		if (a.Ok)
		{
			string text = dn.byy(a.bvl(), a.bvm());
			this.bzx(text);
			DirectApiScheduler instance = DirectApiScheduler.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ShowModalMessage(a.bvn(), text);
			return;
		}
		else
		{
			this.bzx(dn.cag(a.Error));
			DirectApiScheduler instance2 = DirectApiScheduler.Instance;
			if (instance2 == null)
			{
				return;
			}
			instance2.ShowApiError(a.Error, a.RawDetail);
			return;
		}
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x0002CB77 File Offset: 0x0002AD77
	public void brv(bool a)
	{
		bq.hlk = false;
		bq.hmc = a;
		PlayerPrefs.SetInt(a.bvo(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x0002CB9C File Offset: 0x0002AD9C
	private void caf()
	{
		if (this.inputApiKey == null)
		{
			return;
		}
		TMP_Text tmp_Text = this.inputApiKey.placeholder as TMP_Text;
		if (tmp_Text == null)
		{
			return;
		}
		string text = this.cad(this.cae());
		tmp_Text.text = ((text.Length > 0) ? string.Format(dn.byy(a.bvr(), a.bvs()), text) : dn.byy(a.bvp(), a.bvq()));
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x0002CC18 File Offset: 0x0002AE18
	private void otp()
	{
		this.hxt = base.StartCoroutine(this.bvh());
		this.bwh();
		this.bwq();
		eu.ijx += this.bww;
		if (this.btnOpenCustomGameList != null)
		{
			this.btnOpenCustomGameList.interactable = true;
		}
		if (this.hxr != null)
		{
			bb[] array = this.hxr;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].vj(true);
			}
		}
		fa.iml += this.byn;
		this.byn();
		LocalizationSettings.SelectedLocaleChanged += this.bzu;
		DirectApiScheduler.OnRuntimeStatusChanged += this.bzy;
		this.bzw();
		AudioManager.het += this.bvd;
		if (this.sliderBMG != null)
		{
			float @float = PlayerPrefs.GetFloat(a.bvt(), 4191f);
			if (!Mathf.Approximately(this.sliderBMG.value, @float))
			{
				this.sliderBMG.value = @float;
			}
		}
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x0002CD24 File Offset: 0x0002AF24
	private static string ndu(StringTable a, string b, string c)
	{
		if (a == null)
		{
			return c;
		}
		StringTableEntry entry = a.GetEntry(b);
		if (entry == null)
		{
			return c;
		}
		string localizedString = entry.GetLocalizedString();
		if (!string.IsNullOrEmpty(localizedString))
		{
			return localizedString;
		}
		return c;
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x0002CD5C File Offset: 0x0002AF5C
	private string fzf(int a)
	{
		string text;
		try
		{
			text = AiSecretStore.GetMaskedHint(a) ?? a.bvu();
		}
		catch (Exception ex)
		{
			string text2 = a.bvv();
			Exception ex2 = ex;
			Debug.LogError(text2 + ((ex2 != null) ? ex2.ToString() : null));
			text = a.bvw();
		}
		return text;
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x0002CDB4 File Offset: 0x0002AFB4
	public void bvv(BaseEventData a)
	{
		PlayerPrefs.SetFloat(a.se(), this.sliderBMG.value);
		PlayerPrefs.Save();
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x0002CDD0 File Offset: 0x0002AFD0
	public void byv(bool a)
	{
		bq.hlk = false;
		UniWindowController.current.isTopmost = a;
		UniWindowController.current.forceTopmost = a;
		PlayerPrefs.SetInt(a.blk(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x0002CE04 File Offset: 0x0002B004
	public void bvw(float a)
	{
		AudioManager.klw.qj(a, true);
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x0002CE14 File Offset: 0x0002B014
	private void mus()
	{
		if (this.txtVersion != null)
		{
			string text = Application.version;
			if (bq.knc)
			{
				text += a.bvx();
			}
			this.txtVersion.text = text;
		}
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x0002CE54 File Offset: 0x0002B054
	private void mcs()
	{
		if (this.dropdownLanguage == null)
		{
			return;
		}
		if (!LocalizationSettings.InitializationOperation.IsDone)
		{
			return;
		}
		this.hyi = true;
		List<Locale> locales = LocalizationSettings.AvailableLocales.Locales;
		Locale selectedLocale = LocalizationSettings.SelectedLocale;
		this.dropdownLanguage.ClearOptions();
		List<string> list = new List<string>();
		foreach (Locale locale in locales)
		{
			string text = locale.Identifier.CultureInfo.NativeName;
			if (text == a.bvy())
			{
				text = a.bvz();
			}
			if (text == a.bwa())
			{
				text = a.bwb();
			}
			list.Add(text);
		}
		this.dropdownLanguage.AddOptions(list);
		this.dropdownLanguage.value = locales.IndexOf(selectedLocale);
		this.dropdownLanguage.RefreshShownValue();
		this.hyi = false;
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x0002CF5C File Offset: 0x0002B15C
	private static string dwz(AiConnectionMode a)
	{
		if (a == AiConnectionMode.Mcp)
		{
			return dn.byy(a.bwe(), a.bwf());
		}
		if (a == AiConnectionMode.DirectApi)
		{
			return dn.byy(a.bwc(), a.bwd());
		}
		return dn.byy(a.bwg(), a.bwh());
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x0002CF98 File Offset: 0x0002B198
	private void dsz(int a)
	{
		if (this.hyi)
		{
			return;
		}
		bq.hlk = false;
		List<Locale> locales = LocalizationSettings.AvailableLocales.Locales;
		if (a < 0 || a >= locales.Count)
		{
			return;
		}
		LocalizationSettings.SelectedLocale = locales[a];
		this.bwh();
		this.bvn();
		this.bxz();
		this.byd();
		this.bwq();
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x0002CFF8 File Offset: 0x0002B1F8
	private void jhu(string a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		string text = (a ?? a.bwi()).Trim();
		if (string.IsNullOrEmpty(text))
		{
			playerSaveData.directApiTemplateCustomized = false;
			playerSaveData.directApiPromptTemplate = a.bwj();
			if (this.inputPromptTemplate != null)
			{
				this.inputPromptTemplate.text = AiPromptComposer.GetLocalizedDefaultTemplate();
			}
		}
		else
		{
			playerSaveData.directApiTemplateCustomized = true;
			playerSaveData.directApiPromptTemplate = text;
		}
		ci.Save(null);
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x0002D088 File Offset: 0x0002B288
	private void kex()
	{
		int monitorCount = UniWindowController.GetMonitorCount();
		int num = PlayerPrefs.GetInt(a.bwk(), 0);
		if (monitorCount > 0 && num >= monitorCount)
		{
			num = 0;
			PlayerPrefs.SetInt(a.bwl(), num);
			PlayerPrefs.Save();
			Debug.Log(string.Format(a.bwm(), num));
		}
		if (monitorCount > 0)
		{
			if (UniWindowController.current.monitorToFit != num)
			{
				UniWindowController.current.MoveToMonitor(num);
			}
			bx.bcc(num);
			CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
			if (characterDragTarget != null)
			{
				characterDragTarget.bhb();
			}
		}
		this.bvn();
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x0002D110 File Offset: 0x0002B310
	public void crp(bool a)
	{
		bq.hlk = false;
		bool flag = q.tq(a);
		bool flag2 = a && !flag && q.kmh && d.mc();
		if (!flag && !flag2)
		{
			this.toggleAutoStart.SetIsOnWithoutNotify(!a);
			return;
		}
		PlayerPrefs.SetInt(a.bwn(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x0002D16C File Offset: 0x0002B36C
	private void ogq(bool a)
	{
		if (this.windowController == null)
		{
			return;
		}
		if (a)
		{
			this.windowController.isClickThrough = false;
			this.windowController.hitTestType = UniWindowController.HitTestType.None;
			return;
		}
		this.windowController.hitTestType = UniWindowController.HitTestType.Opacity;
		this.windowController.isClickThrough = true;
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x00028A25 File Offset: 0x00026C25
	public static void mex(int a)
	{
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate = a;
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x0002D1BC File Offset: 0x0002B3BC
	private void bwc()
	{
		if (this.inputSteamStatus == null)
		{
			return;
		}
		string @string = PlayerPrefs.GetString(a.bmv(), a.tk());
		this.inputSteamStatus.text = @string;
		if (!string.IsNullOrWhiteSpace(@string))
		{
			dq dq = dq.kqv;
			if (dq == null)
			{
				return;
			}
			dq.ccp(@string);
		}
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x0002D20C File Offset: 0x0002B40C
	public void jax(bool a)
	{
		bq.hlk = false;
		bq.hmc = a;
		PlayerPrefs.SetInt(a.bwo(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x0002D230 File Offset: 0x0002B430
	private void bvi()
	{
		if (this.dropdownLanguage == null)
		{
			return;
		}
		if (!LocalizationSettings.InitializationOperation.IsDone)
		{
			return;
		}
		this.hyi = true;
		List<Locale> locales = LocalizationSettings.AvailableLocales.Locales;
		Locale selectedLocale = LocalizationSettings.SelectedLocale;
		this.dropdownLanguage.ClearOptions();
		List<string> list = new List<string>();
		foreach (Locale locale in locales)
		{
			string text = locale.Identifier.CultureInfo.NativeName;
			if (text == a.bwp())
			{
				text = a.bwq();
			}
			if (text == a.bwr())
			{
				text = a.bws();
			}
			list.Add(text);
		}
		this.dropdownLanguage.AddOptions(list);
		this.dropdownLanguage.value = locales.IndexOf(selectedLocale);
		this.dropdownLanguage.RefreshShownValue();
		this.hyi = false;
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x00029CE7 File Offset: 0x00027EE7
	private static string gdd(AiErrorKind a)
	{
		return AiLoc.DescribeError(a);
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x0002D338 File Offset: 0x0002B538
	private void cls()
	{
		if (this.txtMonitor == null)
		{
			return;
		}
		int monitorToFit = UniWindowController.current.monitorToFit;
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.bwt(), null);
		string text;
		if (table == null)
		{
			text = null;
		}
		else
		{
			StringTableEntry entry = table.GetEntry(a.bwu());
			text = ((entry != null) ? entry.GetLocalizedString() : null);
		}
		string text2 = text ?? a.bwv();
		this.txtMonitor.text = string.Format(a.bww(), text2, monitorToFit + 1);
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x0002D3BC File Offset: 0x0002B5BC
	private void gxr()
	{
		if (this.dropdownDropNotification == null)
		{
			return;
		}
		List<string> list = new List<string>
		{
			dn.bya(a.bwx(), a.bwy()),
			dn.bya(a.bwz(), a.bxa()),
			dn.bya(a.bxb(), a.bxc())
		};
		this.dropdownDropNotification.ClearOptions();
		this.dropdownDropNotification.AddOptions(list);
		this.dropdownDropNotification.SetValueWithoutNotify((int)bq.hma);
		this.dropdownDropNotification.RefreshShownValue();
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x0002D44F File Offset: 0x0002B64F
	public void llf(bool a)
	{
		bq.hlk = false;
		this.windowDragHandler.enableAutoSnap = a;
		PlayerPrefs.SetInt(a.bxd(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x060007AE RID: 1966 RVA: 0x0002D479 File Offset: 0x0002B679
	public void cur(bool a)
	{
		bq.hlk = false;
		this.bvq(a);
		PlayerPrefs.SetInt(a.bxe(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x0002D49E File Offset: 0x0002B69E
	public void bnq(bool a)
	{
		bq.hlk = false;
		this.windowDragHandler.enableAutoSnap = a;
		PlayerPrefs.SetInt(a.bxf(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x060007B0 RID: 1968 RVA: 0x00028079 File Offset: 0x00026279
	private void nrx()
	{
		this.bzw();
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x0002D4C8 File Offset: 0x0002B6C8
	private void bzw()
	{
		if (this.directStatusText == null)
		{
			return;
		}
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || !this.caa(playerSaveData.directApiProviderId))
		{
			this.bzx(dn.byy(a.bxg(), a.bxh()));
			return;
		}
		DirectApiScheduler instance = DirectApiScheduler.Instance;
		if (instance != null && instance.HasRunResult && !instance.LastOk)
		{
			this.bzx(dn.cag(instance.LastError));
			return;
		}
		this.bzx(dn.byy(a.bxi(), a.bxj()));
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x0002D56C File Offset: 0x0002B76C
	public void jao()
	{
		bq.hlo = PlayerPrefs.GetInt(a.bxk(), 0);
		bq.hlp = PlayerPrefs.GetInt(a.bxl(), 2);
		bq.hlq = PlayerPrefs.GetInt(a.bxm(), 2);
		bq.hlr = PlayerPrefs.GetInt(a.bxn(), 2);
		bq.hls = PlayerPrefs.GetInt(a.bxo(), 1) == 1;
		bq.hlt = PlayerPrefs.GetInt(a.bxp(), 0) == 1;
		bq.hlu = PlayerPrefs.GetInt(a.bxq(), 0) == 1;
		bq.hlv = PlayerPrefs.GetInt(a.bxr(), 0) == 1;
		this.toggleTop.SetIsOnWithoutNotify(bq.hls);
		this.toggleFlip.SetIsOnWithoutNotify(bq.hlt);
		this.toggleLockPosition.SetIsOnWithoutNotify(bq.hlu);
		if (bq.hlu)
		{
			CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
			if (characterDragTarget != null)
			{
				characterDragTarget.bhb();
			}
		}
		this.bwv(bq.hlu);
		if (this.toggleAutoHideDownUI != null)
		{
			this.toggleAutoHideDownUI.gameObject.SetActive(true);
			this.toggleAutoHideDownUI.SetIsOnWithoutNotify(bq.hlv);
		}
		bq.hlw = PlayerPrefs.GetInt(a.bxs(), 1) == 1;
		if (this.toggleHotkey != null)
		{
			this.toggleHotkey.isOn = bq.hlw;
		}
		if (this.hotkeyHintPanel != null)
		{
			this.hotkeyHintPanel.SetActive(bq.hlw);
		}
		this.bxk();
		bq.hlx = PlayerPrefs.GetInt(a.bxt(), 1) == 1;
		if (this.toggleRightClickQuickMenu != null)
		{
			this.toggleRightClickQuickMenu.SetIsOnWithoutNotify(bq.hlx);
		}
		this.bvk();
		this.bvl();
		this.bvr();
		this.bwc();
		this.bxc();
		this.bwf();
		this.bxl();
		this.bxv();
		this.bxy();
		this.byc();
		this.bxf();
		this.bxh();
		this.byg();
		this.bvg();
		this.byw();
		try
		{
			this.bzb();
		}
		catch (Exception ex)
		{
			string text = a.bxu();
			Exception ex2 = ex;
			Debug.LogError(text + ((ex2 != null) ? ex2.ToString() : null));
		}
		this.hxr = base.GetComponentsInChildren<bb>(true);
		this.bvc();
	}

	// Token: 0x060007B3 RID: 1971 RVA: 0x0002D7B0 File Offset: 0x0002B9B0
	private void hns()
	{
		if (this.toggleDiscordRichPresence == null)
		{
			return;
		}
		bool flag = PlayerPrefs.GetInt(a.bxv(), 1) == 1;
		this.toggleDiscordRichPresence.SetIsOnWithoutNotify(flag);
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x0002D7E8 File Offset: 0x0002B9E8
	private void gc(bool a)
	{
		IntPtr activeWindow = dn.GetActiveWindow();
		if (activeWindow != IntPtr.Zero)
		{
			int num = dn.GetWindowLong(activeWindow, 45);
			if (a)
			{
				num &= -70;
				num |= 93;
			}
			else
			{
				num &= -2;
				num |= -80;
			}
			dn.SetWindowLong(activeWindow, -19, num);
		}
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x0002D834 File Offset: 0x0002BA34
	public void bvy(BaseEventData a)
	{
		PlayerPrefs.SetFloat(a.sf(), this.sliderSFX.value);
		PlayerPrefs.Save();
		bq.hlk = false;
		if (this.hxs && AudioManager.klw != null && !this.soundPreviewSFX.IsNull)
		{
			AudioManager.klw.qw(this.soundPreviewSFX, bx.hod.koe, 1f);
		}
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x00028250 File Offset: 0x00026450
	private void bax()
	{
		bq.zr();
		if (this.dropdownDropNotification == null)
		{
			return;
		}
		this.bxz();
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x0002D8A4 File Offset: 0x0002BAA4
	private int fig(int a)
	{
		int num = this.kqp;
		if (a == num)
		{
			return -1;
		}
		if (a >= num)
		{
			return a - 1;
		}
		return a;
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x0002D8C7 File Offset: 0x0002BAC7
	private void fqw(int a)
	{
		if (!Enum.IsDefined(typeof(DirtinessMode), a))
		{
			return;
		}
		bq.hmb = (DirtinessMode)a;
		PlayerPrefs.SetInt(a.bxw(), a);
		PlayerPrefs.Save();
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x0002D8F8 File Offset: 0x0002BAF8
	private void fgr()
	{
		bq.hlk = false;
		McpDialogueServer instance = McpDialogueServer.Instance;
		if (instance == null)
		{
			return;
		}
		instance.StopServer();
		instance.StartServer();
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x0002D928 File Offset: 0x0002BB28
	private void OnDisable()
	{
		AudioManager.het -= this.bvd;
		fa.iml -= this.byn;
		LocalizationSettings.SelectedLocaleChanged -= this.bzu;
		DirectApiScheduler.OnRuntimeStatusChanged -= this.bzy;
		eu.ijx -= this.bww;
		if (this.hxt != null)
		{
			base.StopCoroutine(this.hxt);
			this.hxt = null;
		}
		if (this.hxr != null)
		{
			bb[] array = this.hxr;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].vj(false);
			}
		}
		this.hyl = null;
		if (this.btnRepairWindow != null && !this.btnRepairWindow.interactable && !this.hym)
		{
			this.btnRepairWindow.interactable = true;
		}
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x0002DA01 File Offset: 0x0002BC01
	private static string blc(AiConnectionMode a)
	{
		if (a == AiConnectionMode.Mcp)
		{
			return dn.byy(a.bxz(), a.bya());
		}
		if (a == AiConnectionMode.DirectApi)
		{
			return dn.byy(a.bxx(), a.bxy());
		}
		return dn.byy(a.byb(), a.byc());
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x00027663 File Offset: 0x00025863
	public void htm(float a)
	{
		AudioManager.klw.qi(a, true);
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x0002DA3A File Offset: 0x0002BC3A
	private void orw(TMP_Dropdown a, bz b, int c, out int[] d)
	{
		this.hyr = true;
		dn.bxn(a, b, c, out d, null);
		this.hyr = false;
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x0002DA58 File Offset: 0x0002BC58
	private void bzh(string a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		playerSaveData.directApiBaseUrl = (a ?? a.tk()).Trim();
		ci.Save(null);
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x0002DAA8 File Offset: 0x0002BCA8
	private void boi()
	{
		if (this.sliderSound != null)
		{
			PlayerPrefs.SetFloat(a.byd(), this.sliderSound.value);
		}
		if (this.sliderBMG != null)
		{
			PlayerPrefs.SetFloat(a.bye(), this.sliderBMG.value);
		}
		if (this.sliderSFX != null)
		{
			PlayerPrefs.SetFloat(a.byf(), this.sliderSFX.value);
		}
		if (this.sliderVoice != null)
		{
			PlayerPrefs.SetFloat(a.byg(), this.sliderVoice.value);
		}
		PlayerPrefs.Save();
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x0002DB48 File Offset: 0x0002BD48
	private void bwv(bool a)
	{
		if (this.windowController == null)
		{
			return;
		}
		if (a)
		{
			this.windowController.isClickThrough = false;
			this.windowController.hitTestType = UniWindowController.HitTestType.None;
			return;
		}
		this.windowController.hitTestType = UniWindowController.HitTestType.Opacity;
		this.windowController.isClickThrough = true;
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x0002DB98 File Offset: 0x0002BD98
	public void cxf(BaseEventData a)
	{
		PlayerPrefs.SetFloat(a.byh(), this.sliderBMG.value);
		PlayerPrefs.Save();
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x0002DBB4 File Offset: 0x0002BDB4
	private void bvr()
	{
		float @float = PlayerPrefs.GetFloat(a.sd(), 0.5f);
		this.sliderSound.value = @float;
		float float2 = PlayerPrefs.GetFloat(a.se(), 0.5f);
		this.sliderBMG.value = float2;
		float float3 = PlayerPrefs.GetFloat(a.sf(), 0.5f);
		this.sliderSFX.value = float3;
		float float4 = PlayerPrefs.GetFloat(a.sg(), 0.5f);
		this.sliderVoice.value = float4;
		this.hxs = true;
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x0002DC38 File Offset: 0x0002BE38
	public void mzf(BaseEventData a)
	{
		PlayerPrefs.SetFloat(a.byi(), this.sliderSFX.value);
		PlayerPrefs.Save();
		bq.hlk = false;
		if (this.hxs && AudioManager.klw != null && !this.soundPreviewSFX.IsNull)
		{
			AudioManager.klw.qw(this.soundPreviewSFX, bx.hod.koe, 2100f);
		}
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x0002DCA8 File Offset: 0x0002BEA8
	private bool kjv(int a)
	{
		bool flag;
		try
		{
			flag = AiSecretStore.MigrateLegacyKey(a);
		}
		catch (Exception ex)
		{
			string text = a.byj();
			Exception ex2 = ex;
			Debug.LogError(text + ((ex2 != null) ? ex2.ToString() : null));
			flag = false;
		}
		return flag;
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x0002DCF0 File Offset: 0x0002BEF0
	private void lfy(int a)
	{
		if (this.hyr)
		{
			return;
		}
		if (this.hyq == null || a < 0 || a >= this.hyq.Length)
		{
			return;
		}
		if (this.sizeSpeechBubbleController == null)
		{
			return;
		}
		bq.hlk = false;
		int num = this.hyq[a];
		bq.hlr = num;
		this.sizeSpeechBubbleController.bds(num);
		PlayerPrefs.SetInt(a.byk(), num);
		PlayerPrefs.Save();
		Canvas.ForceUpdateCanvases();
		if (this.speechBubbleController != null)
		{
			float num2 = this.sizeSpeechBubbleController.bdq(num);
			string text = a.byl();
			StringTable table = LocalizationSettings.StringDatabase.GetTable(a.bym(), null);
			StringTableEntry stringTableEntry = ((table != null) ? table.GetEntry(a.byn()) : null);
			if (stringTableEntry != null)
			{
				text = stringTableEntry.GetLocalizedString();
			}
			string text2 = string.Format(text, num2.ToString(a.byo()));
			this.speechBubbleController.ShowSizePreview(text2, 9653f);
		}
	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x0002DDDB File Offset: 0x0002BFDB
	private bool bwe(int a)
	{
		return ec.cia(a);
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x0002DDE4 File Offset: 0x0002BFE4
	private bool ksz(int a)
	{
		bool flag;
		try
		{
			flag = AiSecretStore.MigrateLegacyKey(a);
		}
		catch (Exception ex)
		{
			string text = a.byp();
			Exception ex2 = ex;
			Debug.LogError(text + ((ex2 != null) ? ex2.ToString() : null));
			flag = false;
		}
		return flag;
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x0002DE2C File Offset: 0x0002C02C
	private IEnumerator bwz()
	{
		dn.dc dc = new dn.dc();
		if (this.btnRepairWindow != null)
		{
			this.btnRepairWindow.interactable = false;
		}
		dc.hwk = false;
		dc.hwl = false;
		try
		{
			yield return bx.hod.StartCoroutine(bx.hod.bca(new Action<bool>(dc.btn)));
			if (!dc.hwl)
			{
				dc.hwk = false;
			}
			this.bxa(dc.hwk);
		}
		finally
		{
			if (this.btnRepairWindow != null && !this.hym)
			{
				this.btnRepairWindow.interactable = true;
			}
			this.hyl = null;
		}
		yield break;
		yield break;
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x0002DE3B File Offset: 0x0002C03B
	public void bkb(bool a)
	{
		bq.hlk = false;
		bq.hlv = a;
		PlayerPrefs.SetInt(a.byq(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x0002DE60 File Offset: 0x0002C060
	private void bws(int a)
	{
		if (this.hyk)
		{
			return;
		}
		VoiceConfig hlg = bq.hlg;
		if (hlg == null || hlg.kpk == 0)
		{
			return;
		}
		if (a < 0 || a >= hlg.kpk)
		{
			a = 0;
		}
		bq.hlh = a;
		PlayerPrefs.SetInt(a.rm(), a);
		PlayerPrefs.Save();
		MultiplayerSession.die(a);
		if (this.hxs && AudioManager.klw != null)
		{
			EventReference eventReference = bq.zy(new Func<VoiceProfile, EventReference>(dn.<>c.<>9.bti), this.soundPreviewVoice);
			if (!eventReference.IsNull)
			{
				AudioManager.klw.qw(eventReference, bx.hod.koe, 1f);
			}
		}
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x0002DF20 File Offset: 0x0002C120
	private void lif(GameObject a, EventTriggerType b, UnityAction<BaseEventData> c)
	{
		EventTrigger eventTrigger = a.GetComponent<EventTrigger>();
		if (eventTrigger == null)
		{
			eventTrigger = a.AddComponent<EventTrigger>();
		}
		EventTrigger.Entry entry = new EventTrigger.Entry();
		entry.eventID = b;
		entry.callback.AddListener(c);
		eventTrigger.triggers.Add(entry);
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x0002DDDB File Offset: 0x0002BFDB
	private bool oth(int a)
	{
		return ec.cia(a);
	}

	// Token: 0x060007CD RID: 1997 RVA: 0x0002DF6C File Offset: 0x0002C16C
	private void htz()
	{
		q.tt();
		if (this.toggleAutoStart == null)
		{
			return;
		}
		if (!q.kmh)
		{
			this.toggleAutoStart.gameObject.SetActive(false);
			return;
		}
		bool flag = PlayerPrefs.GetInt(a.byr(), 0) == 1;
		if (!q.tp(flag))
		{
			q.tq(flag);
		}
		this.toggleAutoStart.SetIsOnWithoutNotify(flag);
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x0002DFD0 File Offset: 0x0002C1D0
	private void nx()
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		string text = this.cab(playerSaveData.directApiProviderId);
		if (string.IsNullOrEmpty(text))
		{
			this.bzx(dn.byy(a.bys(), a.byt()));
			return;
		}
		int directApiProviderId = playerSaveData.directApiProviderId;
		AiProviderConfig aiProviderConfig = AiProviderCatalog.For((AiProviderId)directApiProviderId);
		string text2 = ((aiProviderConfig.AllowsCustomBaseUrl && !string.IsNullOrEmpty(playerSaveData.directApiBaseUrl)) ? playerSaveData.directApiBaseUrl : aiProviderConfig.DefaultBaseUrl);
		IAiChatAdapter aiChatAdapter = AiAdapterFactory.Create((AiProviderId)directApiProviderId);
		this.bzx(dn.byy(a.byu(), a.byv()));
		AiRequestRunner.Instance.FetchModels(aiChatAdapter, aiProviderConfig, text2, text, 60, new Action<AiModelList>(this.bzk));
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x0002E097 File Offset: 0x0002C297
	private static string bza(AiConnectionMode a)
	{
		if (a == AiConnectionMode.Mcp)
		{
			return dn.byy(a.byy(), a.byz());
		}
		if (a == AiConnectionMode.DirectApi)
		{
			return dn.byy(a.byw(), a.byx());
		}
		return dn.byy(a.bza(), a.bzb());
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x0002E0D0 File Offset: 0x0002C2D0
	private void emq()
	{
		if (this.inputSteamStatus == null)
		{
			return;
		}
		string @string = PlayerPrefs.GetString(a.bzc(), a.bzd());
		this.inputSteamStatus.text = @string;
		if (!string.IsNullOrWhiteSpace(@string))
		{
			dq dq = dq.kqv;
			if (dq == null)
			{
				return;
			}
			dq.ccp(@string);
		}
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x0002E120 File Offset: 0x0002C320
	private string kpq(PlayerSaveData a)
	{
		if (a != null && a.directApiTemplateCustomized && !string.IsNullOrWhiteSpace(a.directApiPromptTemplate))
		{
			return a.directApiPromptTemplate;
		}
		return AiPromptComposer.GetLocalizedDefaultTemplate();
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x0002E146 File Offset: 0x0002C346
	public void jiu(string a)
	{
		bq.hlk = false;
		dq dq = dq.kqv;
		if (dq != null)
		{
			dq.ccp(a);
		}
		PlayerPrefs.SetString(a.bze(), a);
		PlayerPrefs.Save();
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x0002E170 File Offset: 0x0002C370
	private string muc(int a)
	{
		string text;
		try
		{
			text = AiSecretStore.GetKeyForRequest(a) ?? a.bzf();
		}
		catch (Exception ex)
		{
			string text2 = a.bzg();
			Exception ex2 = ex;
			Debug.LogError(text2 + ((ex2 != null) ? ex2.ToString() : null));
			text = a.bzh();
		}
		return text;
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x0002E1C8 File Offset: 0x0002C3C8
	public void baq(bool a)
	{
		bq.hlk = false;
		if (bo.hke != null)
		{
			bo.hke.yq(a);
			return;
		}
		PlayerPrefs.SetInt(a.bzi(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x0002E1FF File Offset: 0x0002C3FF
	public void mun(bool a)
	{
		bq.hlk = false;
		this.bvq(a);
		PlayerPrefs.SetInt(a.bzj(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x060007D6 RID: 2006 RVA: 0x0002E224 File Offset: 0x0002C424
	public void cvo(bool a)
	{
		bq.hlk = false;
		bq.hlx = a;
		PlayerPrefs.SetInt(a.bzk(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x0002E248 File Offset: 0x0002C448
	private void bzj()
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		string text = this.cab(playerSaveData.directApiProviderId);
		if (string.IsNullOrEmpty(text))
		{
			this.bzx(dn.byy(a.bxg(), a.bxh()));
			return;
		}
		int directApiProviderId = playerSaveData.directApiProviderId;
		AiProviderConfig aiProviderConfig = AiProviderCatalog.For((AiProviderId)directApiProviderId);
		string text2 = ((aiProviderConfig.AllowsCustomBaseUrl && !string.IsNullOrEmpty(playerSaveData.directApiBaseUrl)) ? playerSaveData.directApiBaseUrl : aiProviderConfig.DefaultBaseUrl);
		IAiChatAdapter aiChatAdapter = AiAdapterFactory.Create((AiProviderId)directApiProviderId);
		this.bzx(dn.byy(a.bzl(), a.bmy()));
		AiRequestRunner.Instance.FetchModels(aiChatAdapter, aiProviderConfig, text2, text, 15, new Action<AiModelList>(this.bzk));
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x0002E310 File Offset: 0x0002C510
	private void gmi()
	{
		bq.hlk = false;
		if (!ModalDialogManager.kri)
		{
			fa fa = fa.imk;
			if (fa == null)
			{
				return;
			}
			fa.cuw();
			return;
		}
		else
		{
			if (ModalDialogManager.icb.krh)
			{
				return;
			}
			fa fa2 = fa.imk;
			bool flag = fa2 != null && fa2.imm == fa.CheckStatus.UpdateAvailable;
			StringTable table = LocalizationSettings.StringDatabase.GetTable(a.bzm(), null);
			string text;
			string text2;
			if (flag)
			{
				text = dn.byp(table, a.bzn(), a.bzo());
				text2 = dn.byp(table, a.bzp(), a.bzq());
			}
			else
			{
				text = dn.byp(table, a.bzr(), a.bzs());
				text2 = dn.byp(table, a.bzt(), a.bzu());
			}
			ModalDialogManager.icb.ShowConfirm(text, text2, new Action(dn.<>c.<>9.btj), null);
			return;
		}
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x0002E3EC File Offset: 0x0002C5EC
	public void hsc()
	{
		bq.hlk = false;
		Application.OpenURL(a.bzv());
	}

	// Token: 0x060007DA RID: 2010 RVA: 0x0002E400 File Offset: 0x0002C600
	private void iei()
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || this.inputPromptTemplate == null)
		{
			return;
		}
		if (!playerSaveData.directApiTemplateCustomized)
		{
			this.inputPromptTemplate.text = AiPromptComposer.GetLocalizedDefaultTemplate();
		}
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x0002E454 File Offset: 0x0002C654
	private static string ljm(string a, string b)
	{
		string text;
		try
		{
			if (!LocalizationSettings.InitializationOperation.IsDone)
			{
				text = b;
			}
			else
			{
				StringTable table = LocalizationSettings.StringDatabase.GetTable(a.bzw(), null);
				StringTableEntry stringTableEntry = ((table != null) ? table.GetEntry(a) : null);
				string text2 = ((stringTableEntry != null) ? stringTableEntry.GetLocalizedString() : null);
				text = (string.IsNullOrEmpty(text2) ? b : text2);
			}
		}
		catch
		{
			text = b;
		}
		return text;
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x0002E4C8 File Offset: 0x0002C6C8
	private void bzm(AiChatResult a)
	{
		this.hyw = false;
		if (a == null)
		{
			return;
		}
		if (a.Ok)
		{
			string text = dn.byy(a.bzx(), a.bzy());
			this.bzx(text);
			DirectApiScheduler instance = DirectApiScheduler.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ShowModalMessage(a.tk(), text);
			return;
		}
		else
		{
			this.bzx(dn.cag(a.Error));
			DirectApiScheduler instance2 = DirectApiScheduler.Instance;
			if (instance2 == null)
			{
				return;
			}
			instance2.ShowApiError(a.Error, a.RawDetail);
			return;
		}
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x0002E548 File Offset: 0x0002C748
	private void bwa(GameObject a, EventTriggerType b, UnityAction<BaseEventData> c)
	{
		EventTrigger eventTrigger = a.GetComponent<EventTrigger>();
		if (eventTrigger == null)
		{
			eventTrigger = a.AddComponent<EventTrigger>();
		}
		EventTrigger.Entry entry = new EventTrigger.Entry();
		entry.eventID = b;
		entry.callback.AddListener(c);
		eventTrigger.triggers.Add(entry);
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x0002E594 File Offset: 0x0002C794
	private string elz(int a, StringTable b)
	{
		bool flag = this.bwe(a);
		string text = this.bwt(a, flag, b);
		if (string.IsNullOrEmpty(text))
		{
			text = string.Format(a.bzz(), a);
		}
		bl bl = bl.kmv;
		CatCharacterDefinition catCharacterDefinition = ((bl != null) ? bl.xp(a) : null);
		if (catCharacterDefinition != null && catCharacterDefinition.unlockType == CatUnlockType.Workshop)
		{
			text += a.caa();
		}
		if (flag)
		{
			text = a.cab() + text + a.cac();
		}
		return text;
	}

	// Token: 0x060007DF RID: 2015 RVA: 0x00029E24 File Offset: 0x00028024
	private void bfd()
	{
		bq.zs();
		if (this.toggleDropAnimation != null)
		{
			this.toggleDropAnimation.SetIsOnWithoutNotify(bq.hmc);
		}
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x0002E614 File Offset: 0x0002C814
	private void ffr()
	{
		if (this.inputSteamStatus == null)
		{
			return;
		}
		string @string = PlayerPrefs.GetString(a.cad(), a.cae());
		this.inputSteamStatus.text = @string;
		if (!string.IsNullOrWhiteSpace(@string))
		{
			dq dq = dq.kqv;
			if (dq == null)
			{
				return;
			}
			dq.ccp(@string);
		}
	}

	// Token: 0x060007E1 RID: 2017 RVA: 0x0002E664 File Offset: 0x0002C864
	private void dpl()
	{
		bq.hlk = false;
		if (this.btnTalkNow != null)
		{
			base.StartCoroutine(this.bzs(this.btnTalkNow, -9832f));
		}
		if (DirectApiScheduler.Instance != null)
		{
			DirectApiScheduler.Instance.TalkNow();
		}
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x0002E6B4 File Offset: 0x0002C8B4
	public void jbv(BaseEventData a)
	{
		PlayerPrefs.SetFloat(a.caf(), this.sliderVoice.value);
		PlayerPrefs.Save();
		bq.hlk = false;
		if (this.hxs && AudioManager.klw != null)
		{
			EventReference eventReference = bq.zy(new Func<VoiceProfile, EventReference>(dn.<>c.<>9.bth), this.soundPreviewVoice);
			if (!eventReference.IsNull)
			{
				AudioManager.klw.qw(eventReference, bx.hod.koe, 7969f);
			}
		}
	}

	// Token: 0x060007E3 RID: 2019 RVA: 0x0002DA3A File Offset: 0x0002BC3A
	private void ocw(TMP_Dropdown a, bz b, int c, out int[] d)
	{
		this.hyr = true;
		dn.bxn(a, b, c, out d, null);
		this.hyr = false;
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x0002E748 File Offset: 0x0002C948
	public void cnz()
	{
		if (this.dropdownVoice == null)
		{
			return;
		}
		VoiceConfig hlg = bq.hlg;
		if (hlg == null || hlg.kpk == 0)
		{
			this.dropdownVoice.gameObject.SetActive(false);
			return;
		}
		this.dropdownVoice.gameObject.SetActive(true);
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.cag(), null);
		this.hyk = true;
		this.dropdownVoice.ClearOptions();
		List<string> list = new List<string>();
		for (int i = 0; i < hlg.profiles.Count; i++)
		{
			list.Add(this.bwr(hlg.profiles[i], i, table));
		}
		this.dropdownVoice.AddOptions(list);
		this.dropdownVoice.value = Mathf.Clamp(bq.hlh, 0, hlg.profiles.Count - 1);
		this.dropdownVoice.RefreshShownValue();
		this.hyk = false;
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x00028A25 File Offset: 0x00026C25
	public static void bxu(int a)
	{
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate = a;
	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x0002E840 File Offset: 0x0002CA40
	public void gum(BaseEventData a)
	{
		PlayerPrefs.SetFloat(a.cah(), this.sliderVoice.value);
		PlayerPrefs.Save();
		bq.hlk = false;
		if (this.hxs && AudioManager.klw != null)
		{
			EventReference eventReference = bq.zy(new Func<VoiceProfile, EventReference>(dn.<>c.<>9.bth), this.soundPreviewVoice);
			if (!eventReference.IsNull)
			{
				AudioManager.klw.qw(eventReference, bx.hod.koe, 3889f);
			}
		}
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x0002E8D4 File Offset: 0x0002CAD4
	private void lhg(bool a)
	{
		if (!ModalDialogManager.kri)
		{
			return;
		}
		if (ModalDialogManager.icb.krh)
		{
			Debug.LogWarning(string.Format(a.cai(), a));
			return;
		}
		string text = a.caj();
		string text2 = (a ? a.cal() : a.cak());
		try
		{
			if (LocalizationSettings.InitializationOperation.IsDone)
			{
				StringTable table = LocalizationSettings.StringDatabase.GetTable(a.cam(), null);
				if (table != null)
				{
					StringTableEntry entry = table.GetEntry(a.can());
					string text3 = ((entry != null) ? entry.GetLocalizedString() : null);
					if (!string.IsNullOrEmpty(text3))
					{
						text = text3;
					}
					string text4 = (a ? a.cap() : a.cao());
					StringTableEntry entry2 = table.GetEntry(text4);
					string text5 = ((entry2 != null) ? entry2.GetLocalizedString() : null);
					if (!string.IsNullOrEmpty(text5))
					{
						text2 = text5;
					}
				}
			}
		}
		catch
		{
		}
		ModalDialogManager.icb.ShowMessage(text, text2, null);
	}

	// Token: 0x060007E8 RID: 2024 RVA: 0x0002E9CC File Offset: 0x0002CBCC
	private void oil(int a)
	{
		if (this.hyr)
		{
			return;
		}
		if (this.hyo == null || a < 0 || a >= this.hyo.Length)
		{
			return;
		}
		bq.hlk = false;
		int num = this.hyo[a];
		bq.hlp = num;
		this.sizeUIController.bds(num);
		PlayerPrefs.SetInt(a.caq(), num);
		PlayerPrefs.Save();
		Canvas.ForceUpdateCanvases();
		if (SettingPanel.kqq != null)
		{
			SettingPanel.kqq.caz();
		}
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x0002EA48 File Offset: 0x0002CC48
	private void jbm(bool a)
	{
		if (this.windowController == null)
		{
			return;
		}
		if (a)
		{
			this.windowController.isClickThrough = false;
			this.windowController.hitTestType = UniWindowController.HitTestType.None;
			return;
		}
		this.windowController.hitTestType = UniWindowController.HitTestType.Opacity;
		this.windowController.isClickThrough = true;
	}

	// Token: 0x060007EA RID: 2026 RVA: 0x0002EA98 File Offset: 0x0002CC98
	private void lzz(List<string> a, string b)
	{
		dn.de de = new dn.de();
		de.hwn = b;
		if (this.dropdownAiModel == null)
		{
			return;
		}
		this.dropdownAiModel.ClearOptions();
		if (a == null || a.Count == 0)
		{
			this.dropdownAiModel.RefreshShownValue();
			return;
		}
		this.dropdownAiModel.AddOptions(a);
		int num = 0;
		if (!string.IsNullOrEmpty(de.hwn))
		{
			int num2 = a.FindIndex(new Predicate<string>(de.btp));
			if (num2 >= 0)
			{
				num = num2;
			}
		}
		this.dropdownAiModel.SetValueWithoutNotify(num);
		this.dropdownAiModel.RefreshShownValue();
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x0002EB30 File Offset: 0x0002CD30
	public void cef()
	{
		if (this.dropdownVoice == null)
		{
			return;
		}
		VoiceConfig hlg = bq.hlg;
		if (hlg == null || hlg.kpk == 0)
		{
			this.dropdownVoice.gameObject.SetActive(false);
			return;
		}
		this.dropdownVoice.gameObject.SetActive(true);
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.car(), null);
		this.hyk = true;
		this.dropdownVoice.ClearOptions();
		List<string> list = new List<string>();
		for (int i = 0; i < hlg.profiles.Count; i++)
		{
			list.Add(this.bwr(hlg.profiles[i], i, table));
		}
		this.dropdownVoice.AddOptions(list);
		this.dropdownVoice.value = Mathf.Clamp(bq.hlh, 0, hlg.profiles.Count - 1);
		this.dropdownVoice.RefreshShownValue();
		this.hyk = false;
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x0002EC28 File Offset: 0x0002CE28
	private void jpi()
	{
		try
		{
			dz.cgu();
			Application.OpenURL(new Uri(dz.cgt()).AbsoluteUri);
			if (this.btnOpenCustomGameList != null)
			{
				this.btnOpenCustomGameList.interactable = false;
				base.StartCoroutine(this.buz(7201f));
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.cas() + ex.Message);
		}
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x0002ECA4 File Offset: 0x0002CEA4
	public void byq()
	{
		bq.hlk = false;
		if (!SteamManager.krd)
		{
			Debug.LogError(a.cat());
			return;
		}
		if (!ModalDialogManager.kri)
		{
			Debug.LogError(a.cau());
			return;
		}
		if (SteamInventoryManager.iid == null)
		{
			Debug.LogError(a.cav());
			return;
		}
		if (SteamInventoryManager.iid.ksp)
		{
			Debug.LogWarning(a.caw());
			return;
		}
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.rh(), null);
		string text;
		if (table == null)
		{
			text = null;
		}
		else
		{
			StringTableEntry entry = table.GetEntry(a.cax());
			text = ((entry != null) ? entry.GetLocalizedString() : null);
		}
		string text2 = text ?? a.cay();
		string text3;
		if (table == null)
		{
			text3 = null;
		}
		else
		{
			StringTableEntry entry2 = table.GetEntry(a.caz());
			text3 = ((entry2 != null) ? entry2.GetLocalizedString() : null);
		}
		string text4 = text3 ?? a.cba();
		string text5;
		if (table == null)
		{
			text5 = null;
		}
		else
		{
			StringTableEntry entry3 = table.GetEntry(a.cbb());
			text5 = ((entry3 != null) ? entry3.GetLocalizedString() : null);
		}
		string text6 = text5 ?? a.cbc();
		string text7;
		if (table == null)
		{
			text7 = null;
		}
		else
		{
			StringTableEntry entry4 = table.GetEntry(a.cbd());
			text7 = ((entry4 != null) ? entry4.GetLocalizedString() : null);
		}
		string text8 = text7 ?? a.cbe();
		string text9;
		if (table == null)
		{
			text9 = null;
		}
		else
		{
			StringTableEntry entry5 = table.GetEntry(a.cbf());
			text9 = ((entry5 != null) ? entry5.GetLocalizedString() : null);
		}
		string text10 = text9 ?? a.cbg();
		string text11;
		if (table == null)
		{
			text11 = null;
		}
		else
		{
			StringTableEntry entry6 = table.GetEntry(a.cbh());
			text11 = ((entry6 != null) ? entry6.GetLocalizedString() : null);
		}
		string text12 = text11 ?? a.cbi();
		string text13;
		if (table == null)
		{
			text13 = null;
		}
		else
		{
			StringTableEntry entry7 = table.GetEntry(a.cbj());
			text13 = ((entry7 != null) ? entry7.GetLocalizedString() : null);
		}
		string text14 = text13 ?? a.cbk();
		string text15 = string.Concat(new string[]
		{
			text4,
			a.bfx(),
			text6,
			a.bfx(),
			text8,
			a.bfx(),
			text10,
			a.bfx(),
			text12
		});
		ModalDialogManager.icb.ShowTypingConfirm(text2, text15, a.cbl(), text14, new Action(dn.<>c.<>9.btk), null);
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x0002EEB4 File Offset: 0x0002D0B4
	private void xk(int a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		playerSaveData.directApiChattinessTier = Mathf.Clamp(a, 0, 2);
		ci.Save(null);
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x0002EEFC File Offset: 0x0002D0FC
	private void bzv()
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || this.inputPromptTemplate == null)
		{
			return;
		}
		if (!playerSaveData.directApiTemplateCustomized)
		{
			this.inputPromptTemplate.text = AiPromptComposer.GetLocalizedDefaultTemplate();
		}
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x0002EF50 File Offset: 0x0002D150
	private void bvg()
	{
		if (this.txtVersion != null)
		{
			string text = Application.version;
			if (bq.knc)
			{
				text += a.cbm();
			}
			this.txtVersion.text = text;
		}
	}

	// Token: 0x060007F1 RID: 2033 RVA: 0x0002EF90 File Offset: 0x0002D190
	public void byr()
	{
		bq.hlk = false;
		if (!SteamManager.krd)
		{
			Debug.LogError(a.cbn());
			return;
		}
		CSteamID steamID = SteamUser.GetSteamID();
		string text = string.Format(a.cbo(), steamID.m_SteamID);
		string text2 = a.bjg() + text;
		Application.OpenURL(text2);
		Debug.Log(a.cbp() + text2);
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x0002EFF4 File Offset: 0x0002D1F4
	private void bot(bool a)
	{
		if (!ModalDialogManager.kri)
		{
			return;
		}
		if (ModalDialogManager.icb.krh)
		{
			Debug.LogWarning(string.Format(a.cbq(), a));
			return;
		}
		string text = a.cbr();
		string text2 = (a ? a.cbt() : a.cbs());
		try
		{
			if (LocalizationSettings.InitializationOperation.IsDone)
			{
				StringTable table = LocalizationSettings.StringDatabase.GetTable(a.cbu(), null);
				if (table != null)
				{
					StringTableEntry entry = table.GetEntry(a.cbv());
					string text3 = ((entry != null) ? entry.GetLocalizedString() : null);
					if (!string.IsNullOrEmpty(text3))
					{
						text = text3;
					}
					string text4 = (a ? a.cbx() : a.cbw());
					StringTableEntry entry2 = table.GetEntry(text4);
					string text5 = ((entry2 != null) ? entry2.GetLocalizedString() : null);
					if (!string.IsNullOrEmpty(text5))
					{
						text2 = text5;
					}
				}
			}
		}
		catch
		{
		}
		ModalDialogManager.icb.ShowMessage(text, text2, null);
	}

	// Token: 0x060007F3 RID: 2035
	[DllImport("user32.dll")]
	private static extern IntPtr GetActiveWindow();

	// Token: 0x060007F4 RID: 2036 RVA: 0x0002F0EC File Offset: 0x0002D2EC
	private void fyt(bool a)
	{
		if (!ModalDialogManager.kri)
		{
			return;
		}
		if (ModalDialogManager.icb.krh)
		{
			Debug.LogWarning(string.Format(a.cby(), a));
			return;
		}
		string text = a.cbz();
		string text2 = (a ? a.ccb() : a.cca());
		try
		{
			if (LocalizationSettings.InitializationOperation.IsDone)
			{
				StringTable table = LocalizationSettings.StringDatabase.GetTable(a.ccc(), null);
				if (table != null)
				{
					StringTableEntry entry = table.GetEntry(a.ccd());
					string text3 = ((entry != null) ? entry.GetLocalizedString() : null);
					if (!string.IsNullOrEmpty(text3))
					{
						text = text3;
					}
					string text4 = (a ? a.ccf() : a.cce());
					StringTableEntry entry2 = table.GetEntry(text4);
					string text5 = ((entry2 != null) ? entry2.GetLocalizedString() : null);
					if (!string.IsNullOrEmpty(text5))
					{
						text2 = text5;
					}
				}
			}
		}
		catch
		{
		}
		ModalDialogManager.icb.ShowMessage(text, text2, null);
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x0002F1E4 File Offset: 0x0002D3E4
	private void ouf(AiModelList a)
	{
		if (a == null)
		{
			return;
		}
		if (!a.Ok)
		{
			this.bzx(dn.cag(a.Error));
			DirectApiScheduler instance = DirectApiScheduler.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ShowApiError(a.Error, a.RawDetail);
			return;
		}
		else
		{
			PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
			string text = ((playerSaveData != null) ? playerSaveData.directApiModel : null);
			List<string> list = new List<string>(a.Models);
			this.bzn(list, (!string.IsNullOrEmpty(text)) ? text : ((list.Count > 0) ? list[0] : null));
			if (playerSaveData != null && string.IsNullOrEmpty(playerSaveData.directApiModel) && list.Count > 0)
			{
				playerSaveData.directApiModel = list[0];
				ci.Save(null);
			}
			string text2 = string.Format(dn.byy(a.ccg(), a.cch()), list.Count);
			this.bzx(text2);
			DirectApiScheduler instance2 = DirectApiScheduler.Instance;
			if (instance2 == null)
			{
				return;
			}
			instance2.ShowModalMessage(a.cci(), text2);
			return;
		}
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x0002F2F1 File Offset: 0x0002D4F1
	public void bpu(float a)
	{
		AudioManager.klw.qk(a, true);
	}

	// Token: 0x060007F7 RID: 2039 RVA: 0x00027012 File Offset: 0x00025212
	private void han()
	{
		if (this.hotkeyHintWindows != null)
		{
			this.hotkeyHintWindows.SetActive(true);
		}
		if (this.hotkeyHintMac != null)
		{
			this.hotkeyHintMac.SetActive(false);
		}
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x0002A838 File Offset: 0x00028A38
	private int jix()
	{
		if (!bq.hlz)
		{
			return this.bwj(bq.hly);
		}
		return this.kqp;
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x0002F300 File Offset: 0x0002D500
	public static int kwf()
	{
		if (PlayerPrefs.HasKey(a.ccj()))
		{
			return PlayerPrefs.GetInt(a.cck());
		}
		int num = Mathf.RoundToInt((float)Screen.currentResolution.refreshRateRatio.value);
		int num2 = -59;
		foreach (int num3 in dn.FPSOptions)
		{
			if (num3 != -1 && num3 <= num && num3 > num2)
			{
				num2 = num3;
			}
		}
		return num2;
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x0002C9F0 File Offset: 0x0002ABF0
	public void byj()
	{
		bq.hlk = false;
		Application.Quit();
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x0002F377 File Offset: 0x0002D577
	private IEnumerator bvh()
	{
		yield return LocalizationSettings.InitializationOperation;
		this.bvi();
		yield break;
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x0002F388 File Offset: 0x0002D588
	private void hoi(int a)
	{
		if (this.hyr)
		{
			return;
		}
		if (this.hyo == null || a < 0 || a >= this.hyo.Length)
		{
			return;
		}
		bq.hlk = false;
		int num = this.hyo[a];
		bq.hlp = num;
		this.sizeUIController.bds(num);
		PlayerPrefs.SetInt(a.ccl(), num);
		PlayerPrefs.Save();
		Canvas.ForceUpdateCanvases();
		if (SettingPanel.kqq != null)
		{
			SettingPanel.kqq.caz();
		}
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x0002F404 File Offset: 0x0002D604
	public void feb(bool a)
	{
		bq.hlk = false;
		bq.hlw = a;
		if (this.hotkeyHintPanel != null)
		{
			this.hotkeyHintPanel.SetActive(a);
		}
		this.bxk();
		PlayerPrefs.SetInt(a.ccm(), a ? 1 : 0);
		PlayerPrefs.Save();
		if (a)
		{
			WinGlobalHotkey.ctp();
			return;
		}
		WinGlobalHotkey.ctq();
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x00029CE7 File Offset: 0x00027EE7
	private static string cag(AiErrorKind a)
	{
		return AiLoc.DescribeError(a);
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x0002F464 File Offset: 0x0002D664
	private void dhf(int a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || this.dropdownAiModel == null)
		{
			return;
		}
		if (a < 0 || a >= this.dropdownAiModel.options.Count)
		{
			return;
		}
		bq.hlk = false;
		playerSaveData.directApiModel = this.dropdownAiModel.options[a].text;
		ci.Save(null);
		this.bzl(playerSaveData.directApiModel);
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x00029E24 File Offset: 0x00028024
	private void nsz()
	{
		bq.zs();
		if (this.toggleDropAnimation != null)
		{
			this.toggleDropAnimation.SetIsOnWithoutNotify(bq.hmc);
		}
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x0002F4EC File Offset: 0x0002D6EC
	private void fh()
	{
		float @float = PlayerPrefs.GetFloat(a.ccn(), 9766f);
		this.sliderSound.value = @float;
		float float2 = PlayerPrefs.GetFloat(a.cco(), -2952f);
		this.sliderBMG.value = float2;
		float float3 = PlayerPrefs.GetFloat(a.ccp(), 2984f);
		this.sliderSFX.value = float3;
		float float4 = PlayerPrefs.GetFloat(a.ccq(), -2303f);
		this.sliderVoice.value = float4;
		this.hxs = true;
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x0002A838 File Offset: 0x00028A38
	private int kce()
	{
		if (!bq.hlz)
		{
			return this.bwj(bq.hly);
		}
		return this.kqp;
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x0002F570 File Offset: 0x0002D770
	public void gis()
	{
		bool flag = SettingPanel.kqs;
		if (this.dropdownCharacterMode != null)
		{
			this.dropdownCharacterMode.interactable = flag;
		}
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x0002F5A0 File Offset: 0x0002D7A0
	private void mvg(int a)
	{
		if (!Enum.IsDefined(typeof(DropNotificationMode), a))
		{
			return;
		}
		bq.hma = (DropNotificationMode)a;
		PlayerPrefs.SetInt(a.ccr(), a);
		PlayerPrefs.Save();
		if (bq.hma == DropNotificationMode.Off)
		{
			PlayerData hlf = bq.hlf;
			PlayerSaveData playerSaveData = ((hlf != null) ? hlf.playerSaveData : null);
			if (((playerSaveData != null) ? playerSaveData.newItemDefIds : null) != null && playerSaveData.newItemDefIds.Count > 0)
			{
				playerSaveData.newItemDefIds.Clear();
				ci.Save(null);
				if (cx.kpw != null)
				{
					cx.kpw.brh();
				}
			}
		}
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x0002DDDB File Offset: 0x0002BFDB
	private bool lsw(int a)
	{
		return ec.cia(a);
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x00028250 File Offset: 0x00026450
	private void bxy()
	{
		bq.zr();
		if (this.dropdownDropNotification == null)
		{
			return;
		}
		this.bxz();
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x0002F638 File Offset: 0x0002D838
	private void ccm(int a)
	{
		if (this.hyr)
		{
			return;
		}
		if (this.hyn == null || a < 0 || a >= this.hyn.Length)
		{
			return;
		}
		bq.hlk = false;
		int num = this.hyn[a];
		bq.hlo = num;
		this.sizeController.bds(num);
		PlayerPrefs.SetInt(a.ccs(), num);
		PlayerPrefs.Save();
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x0002F698 File Offset: 0x0002D898
	private void Start()
	{
		if (this.dropdownSize != null)
		{
			this.dropdownSize.onValueChanged.AddListener(new UnityAction<int>(this.bxp));
		}
		this.sliderSound.onValueChanged.AddListener(new UnityAction<float>(this.bvs));
		this.sliderBMG.onValueChanged.AddListener(new UnityAction<float>(this.bvt));
		this.sliderSFX.onValueChanged.AddListener(new UnityAction<float>(this.bvw));
		this.sliderVoice.onValueChanged.AddListener(new UnityAction<float>(this.bvx));
		this.bwa(this.sliderSound.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvu));
		this.bwa(this.sliderBMG.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvv));
		this.bwa(this.sliderSFX.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvy));
		this.bwa(this.sliderVoice.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvz));
		if (this.muteButtonSound != null)
		{
			this.muteButtonSound.hzh += this.bvf;
		}
		if (this.muteButtonBGM != null)
		{
			this.muteButtonBGM.hzh += this.bvf;
		}
		if (this.muteButtonSFX != null)
		{
			this.muteButtonSFX.hzh += this.bvf;
		}
		if (this.muteButtonVoice != null)
		{
			this.muteButtonVoice.hzh += this.bvf;
		}
		dn.bwb(this.sliderSound);
		dn.bwb(this.sliderBMG);
		dn.bwb(this.sliderSFX);
		dn.bwb(this.sliderVoice);
		if (this.dropdownUISize != null)
		{
			this.dropdownUISize.onValueChanged.AddListener(new UnityAction<int>(this.bxq));
		}
		if (this.dropdownToolbarSize != null)
		{
			this.dropdownToolbarSize.onValueChanged.AddListener(new UnityAction<int>(this.bxr));
		}
		if (this.dropdownSpeechBubbleSize != null)
		{
			this.dropdownSpeechBubbleSize.onValueChanged.AddListener(new UnityAction<int>(this.bxs));
		}
		this.btnCloseGame.onClick.AddListener(new UnityAction(this.byj));
		this.btnSteamInventory.onClick.AddListener(new UnityAction(this.byr));
		this.btnDiscord.onClick.AddListener(new UnityAction(this.bys));
		if (this.btnWorkshop != null)
		{
			this.btnWorkshop.onClick.AddListener(new UnityAction(this.byt));
		}
		if (this.btnTroubleshooting != null)
		{
			this.btnTroubleshooting.onClick.AddListener(new UnityAction(this.byu));
		}
		this.toggleTop.onValueChanged.AddListener(new UnityAction<bool>(this.byv));
		this.toggleFlip.onValueChanged.AddListener(new UnityAction<bool>(this.byi));
		if (this.toggleDropAnimation != null)
		{
			this.toggleDropAnimation.onValueChanged.AddListener(new UnityAction<bool>(this.bxg));
		}
		if (this.toggleDisableMassagerIdle != null)
		{
			this.toggleDisableMassagerIdle.onValueChanged.AddListener(new UnityAction<bool>(this.bxi));
		}
		if (this.dropdownLanguage != null)
		{
			this.dropdownLanguage.onValueChanged.AddListener(new UnityAction<int>(this.bvj));
		}
		this.btnMonitor.onClick.AddListener(new UnityAction(this.bvm));
		this.toggleTaskbar.onValueChanged.AddListener(new UnityAction<bool>(this.bvo));
		this.toggleTaskbarSnap.onValueChanged.AddListener(new UnityAction<bool>(this.bvp));
		this.toggleLockPosition.onValueChanged.AddListener(new UnityAction<bool>(this.bwu));
		if (this.btnResetCharacterPosition != null)
		{
			this.btnResetCharacterPosition.onClick.AddListener(new UnityAction(this.bwx));
		}
		if (this.btnRepairWindow != null)
		{
			this.btnRepairWindow.onClick.AddListener(new UnityAction(this.bwy));
			if (!ModalDialogManager.kri)
			{
				this.btnRepairWindow.interactable = false;
				this.hym = true;
				Debug.LogWarning(a.cct());
			}
		}
		if (this.btnDeleteAllItems != null)
		{
			this.btnDeleteAllItems.onClick.AddListener(new UnityAction(this.byq));
			if (!ModalDialogManager.kri)
			{
				this.btnDeleteAllItems.interactable = false;
				Debug.LogWarning(a.ccu());
			}
		}
		this.toggleAutoHideDownUI.onValueChanged.AddListener(new UnityAction<bool>(this.bxb));
		if (this.toggleHotkey != null)
		{
			this.toggleHotkey.onValueChanged.AddListener(new UnityAction<bool>(this.bxe));
		}
		if (this.toggleRightClickQuickMenu != null)
		{
			this.toggleRightClickQuickMenu.onValueChanged.AddListener(new UnityAction<bool>(this.bxj));
		}
		if (this.inputSteamStatus != null)
		{
			this.inputSteamStatus.onEndEdit.AddListener(new UnityAction<string>(this.bwd));
		}
		if (this.dropdownCharacterMode != null)
		{
			this.dropdownCharacterMode.onValueChanged.AddListener(new UnityAction<int>(this.bwo));
		}
		if (this.dropdownVoice != null)
		{
			this.dropdownVoice.onValueChanged.AddListener(new UnityAction<int>(this.bws));
			base.StartCoroutine(this.bwp());
		}
		if (this.dropdownFPS != null)
		{
			this.dropdownFPS.onValueChanged.AddListener(new UnityAction<int>(this.bxx));
		}
		if (this.dropdownDropNotification != null)
		{
			this.dropdownDropNotification.onValueChanged.AddListener(new UnityAction<int>(this.byb));
		}
		if (this.dropdownDirtiness != null)
		{
			this.dropdownDirtiness.onValueChanged.AddListener(new UnityAction<int>(this.byf));
		}
		if (this.toggleAutoStart != null)
		{
			this.toggleAutoStart.onValueChanged.AddListener(new UnityAction<bool>(this.byh));
		}
		if (this.toggleDiscordRichPresence != null)
		{
			this.toggleDiscordRichPresence.onValueChanged.AddListener(new UnityAction<bool>(this.bxd));
		}
		if (this.btnCheckNow != null)
		{
			this.btnCheckNow.onClick.AddListener(new UnityAction(this.byk));
		}
		if (this.btnRestartUpdate != null)
		{
			this.btnRestartUpdate.onClick.AddListener(new UnityAction(this.bym));
			this.btnRestartUpdate.interactable = true;
		}
		if (this.objUpdateStatus != null)
		{
			this.objUpdateStatus.SetActive(false);
		}
		if (this.objUpdateBadge != null)
		{
			this.objUpdateBadge.un(false);
		}
		this.bux();
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x0002FDEC File Offset: 0x0002DFEC
	public void hfr()
	{
		if (this.dropdownVoice == null)
		{
			return;
		}
		VoiceConfig hlg = bq.hlg;
		if (hlg == null || hlg.kpk == 0)
		{
			this.dropdownVoice.gameObject.SetActive(false);
			return;
		}
		this.dropdownVoice.gameObject.SetActive(true);
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.ccv(), null);
		this.hyk = true;
		this.dropdownVoice.ClearOptions();
		List<string> list = new List<string>();
		for (int i = 0; i < hlg.profiles.Count; i++)
		{
			list.Add(this.bwr(hlg.profiles[i], i, table));
		}
		this.dropdownVoice.AddOptions(list);
		this.dropdownVoice.value = Mathf.Clamp(bq.hlh, 0, hlg.profiles.Count - 1);
		this.dropdownVoice.RefreshShownValue();
		this.hyk = false;
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x0002FEE4 File Offset: 0x0002E0E4
	private void dhd()
	{
		bq.hlk = false;
		McpDialogueServer instance = McpDialogueServer.Instance;
		if (instance == null)
		{
			return;
		}
		instance.StopServer();
		instance.StartServer();
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x0002FF14 File Offset: 0x0002E114
	private void bwo(int a)
	{
		if (this.hyj)
		{
			return;
		}
		bq.hlk = false;
		bl bl = bl.kmv;
		if (bl == null)
		{
			return;
		}
		int num = this.bwk(a);
		if (num == -1)
		{
			bl.xm(true);
			bl.xk();
			return;
		}
		if (num < 0 || num >= bl.kmu)
		{
			num = 0;
		}
		if (this.bwe(num))
		{
			this.hyj = true;
			this.dropdownCharacterMode.value = this.bwl();
			this.dropdownCharacterMode.RefreshShownValue();
			this.hyj = false;
			return;
		}
		bl.xm(false);
		bl.xu();
		bl.xh(num);
		int num2 = ((bl.hjk > 0) ? bl.hjk : bq.hly);
		PlayerPrefs.SetInt(a.ne(), num2);
		PlayerPrefs.Save();
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x0002FFD8 File Offset: 0x0002E1D8
	public void naj()
	{
		bq.hlo = PlayerPrefs.GetInt(a.ccw(), 0);
		bq.hlp = PlayerPrefs.GetInt(a.ccx(), 2);
		bq.hlq = PlayerPrefs.GetInt(a.ccy(), 2);
		bq.hlr = PlayerPrefs.GetInt(a.ccz(), 2);
		if (this.sizeController != null)
		{
			this.sizeController.bds(bq.hlo);
		}
		if (this.sizeUIController != null)
		{
			this.sizeUIController.bds(bq.hlp);
		}
		if (this.sizeToolbarController != null)
		{
			this.sizeToolbarController.bds(bq.hlq);
		}
		if (this.sizeSpeechBubbleController != null)
		{
			this.sizeSpeechBubbleController.bds(bq.hlr);
		}
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x000300A0 File Offset: 0x0002E2A0
	private void kfy(GameObject a, EventTriggerType b, UnityAction<BaseEventData> c)
	{
		EventTrigger eventTrigger = a.GetComponent<EventTrigger>();
		if (eventTrigger == null)
		{
			eventTrigger = a.AddComponent<EventTrigger>();
		}
		EventTrigger.Entry entry = new EventTrigger.Entry();
		entry.eventID = b;
		entry.callback.AddListener(c);
		eventTrigger.triggers.Add(entry);
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x0002C9F0 File Offset: 0x0002ABF0
	public void irz()
	{
		bq.hlk = false;
		Application.Quit();
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x0002C9F0 File Offset: 0x0002ABF0
	public void epj()
	{
		bq.hlk = false;
		Application.Quit();
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x000300EC File Offset: 0x0002E2EC
	private void fog()
	{
		float @float = PlayerPrefs.GetFloat(a.cda(), 9668f);
		this.sliderSound.value = @float;
		float float2 = PlayerPrefs.GetFloat(a.cdb(), -45f);
		this.sliderBMG.value = float2;
		float float3 = PlayerPrefs.GetFloat(a.cdc(), 167f);
		this.sliderSFX.value = float3;
		float float4 = PlayerPrefs.GetFloat(a.cdd(), -9448f);
		this.sliderVoice.value = float4;
		this.hxs = true;
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x00030170 File Offset: 0x0002E370
	private void bdm(string a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		playerSaveData.directApiBaseUrl = (a ?? a.cde()).Trim();
		ci.Save(null);
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x000301C0 File Offset: 0x0002E3C0
	private void fev(GameObject a, EventTriggerType b, UnityAction<BaseEventData> c)
	{
		EventTrigger eventTrigger = a.GetComponent<EventTrigger>();
		if (eventTrigger == null)
		{
			eventTrigger = a.AddComponent<EventTrigger>();
		}
		EventTrigger.Entry entry = new EventTrigger.Entry();
		entry.eventID = b;
		entry.callback.AddListener(c);
		eventTrigger.triggers.Add(entry);
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x0003020C File Offset: 0x0002E40C
	private static string kbg(string a, string b)
	{
		string text;
		try
		{
			if (!LocalizationSettings.InitializationOperation.IsDone)
			{
				text = b;
			}
			else
			{
				StringTable table = LocalizationSettings.StringDatabase.GetTable(a.cdf(), null);
				StringTableEntry stringTableEntry = ((table != null) ? table.GetEntry(a) : null);
				string text2 = ((stringTableEntry != null) ? stringTableEntry.GetLocalizedString() : null);
				text = (string.IsNullOrEmpty(text2) ? b : text2);
			}
		}
		catch
		{
			text = b;
		}
		return text;
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x0002E120 File Offset: 0x0002C320
	private string bzt(PlayerSaveData a)
	{
		if (a != null && a.directApiTemplateCustomized && !string.IsNullOrWhiteSpace(a.directApiPromptTemplate))
		{
			return a.directApiPromptTemplate;
		}
		return AiPromptComposer.GetLocalizedDefaultTemplate();
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x00030280 File Offset: 0x0002E480
	private void fih(int a)
	{
		if (this.hyr)
		{
			return;
		}
		if (this.hyn == null || a < 0 || a >= this.hyn.Length)
		{
			return;
		}
		bq.hlk = false;
		int num = this.hyn[a];
		bq.hlo = num;
		this.sizeController.bds(num);
		PlayerPrefs.SetInt(a.cdg(), num);
		PlayerPrefs.Save();
	}

	// Token: 0x06000816 RID: 2070 RVA: 0x000302E0 File Offset: 0x0002E4E0
	private void bxr(int a)
	{
		if (this.hyr)
		{
			return;
		}
		if (this.hyp == null || a < 0 || a >= this.hyp.Length)
		{
			return;
		}
		if (this.sizeToolbarController == null)
		{
			return;
		}
		bq.hlk = false;
		int num = this.hyp[a];
		bq.hlq = num;
		this.sizeToolbarController.bds(num);
		PlayerPrefs.SetInt(a.bli(), num);
		PlayerPrefs.Save();
		Canvas.ForceUpdateCanvases();
	}

	// Token: 0x06000817 RID: 2071 RVA: 0x00027157 File Offset: 0x00025357
	public void htp()
	{
		bq.hlk = false;
		CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
		if (characterDragTarget == null)
		{
			return;
		}
		characterDragTarget.bgy();
	}

	// Token: 0x06000818 RID: 2072 RVA: 0x00030354 File Offset: 0x0002E554
	public static int bxn(TMP_Dropdown a, bz b, int c, out int[] d, Func<int, string, string> e = null)
	{
		dn.dd dd = new dn.dd();
		dd.hwm = b;
		d = new int[dd.hwm.sizes.Count];
		for (int i = 0; i < d.Length; i++)
		{
			d[i] = i;
		}
		Array.Sort<int>(d, new Comparison<int>(dd.bto));
		a.ClearOptions();
		List<string> list = new List<string>();
		int num = 0;
		for (int j = 0; j < d.Length; j++)
		{
			int num2 = d[j];
			string text = a.cdh() + dd.hwm.bdq(num2).ToString();
			if (e != null)
			{
				text = e(num2, text);
			}
			list.Add(text);
			if (num2 == c)
			{
				num = j;
			}
		}
		a.AddOptions(list);
		a.value = num;
		a.RefreshShownValue();
		return num;
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x0002E120 File Offset: 0x0002C320
	private string hjy(PlayerSaveData a)
	{
		if (a != null && a.directApiTemplateCustomized && !string.IsNullOrWhiteSpace(a.directApiPromptTemplate))
		{
			return a.directApiPromptTemplate;
		}
		return AiPromptComposer.GetLocalizedDefaultTemplate();
	}

	// Token: 0x0600081A RID: 2074 RVA: 0x00027663 File Offset: 0x00025863
	public void nyt(float a)
	{
		AudioManager.klw.qi(a, true);
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x0003042C File Offset: 0x0002E62C
	private void nov()
	{
		if (this.dropdownDropNotification == null)
		{
			return;
		}
		List<string> list = new List<string>
		{
			dn.bya(a.cdi(), a.cdj()),
			dn.bya(a.cdk(), a.cdl()),
			dn.bya(a.cdm(), a.cdn())
		};
		this.dropdownDropNotification.ClearOptions();
		this.dropdownDropNotification.AddOptions(list);
		this.dropdownDropNotification.SetValueWithoutNotify((int)bq.hma);
		this.dropdownDropNotification.RefreshShownValue();
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x000304C0 File Offset: 0x0002E6C0
	private void ffo()
	{
		if (this.dropdownLanguage == null)
		{
			return;
		}
		if (!LocalizationSettings.InitializationOperation.IsDone)
		{
			return;
		}
		this.hyi = true;
		List<Locale> locales = LocalizationSettings.AvailableLocales.Locales;
		Locale selectedLocale = LocalizationSettings.SelectedLocale;
		this.dropdownLanguage.ClearOptions();
		List<string> list = new List<string>();
		foreach (Locale locale in locales)
		{
			string text = locale.Identifier.CultureInfo.NativeName;
			if (text == a.cdo())
			{
				text = a.cdp();
			}
			if (text == a.cdq())
			{
				text = a.cdr();
			}
			list.Add(text);
		}
		this.dropdownLanguage.AddOptions(list);
		this.dropdownLanguage.value = locales.IndexOf(selectedLocale);
		this.dropdownLanguage.RefreshShownValue();
		this.hyi = false;
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x000305C8 File Offset: 0x0002E7C8
	private void mre(int a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		playerSaveData.directApiChattinessTier = Mathf.Clamp(a, 0, 2);
		ci.Save(null);
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x00030610 File Offset: 0x0002E810
	public void cds(BaseEventData a)
	{
		PlayerPrefs.SetFloat(a.cds(), this.sliderVoice.value);
		PlayerPrefs.Save();
		bq.hlk = false;
		if (this.hxs && AudioManager.klw != null)
		{
			EventReference eventReference = bq.zy(new Func<VoiceProfile, EventReference>(dn.<>c.<>9.bth), this.soundPreviewVoice);
			if (!eventReference.IsNull)
			{
				AudioManager.klw.qw(eventReference, bx.hod.koe, 2322f);
			}
		}
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x0002827E File Offset: 0x0002647E
	private void hma()
	{
		bq.zt();
		if (this.toggleDisableMassagerIdle != null)
		{
			this.toggleDisableMassagerIdle.SetIsOnWithoutNotify(bq.hmd);
		}
		GirlController girlController = GirlController.kok;
		if (girlController == null)
		{
			return;
		}
		girlController.bfn();
	}

	// Token: 0x06000820 RID: 2080 RVA: 0x000306A4 File Offset: 0x0002E8A4
	public static int caw()
	{
		if (PlayerPrefs.HasKey(a.cdt()))
		{
			return PlayerPrefs.GetInt(a.cdu());
		}
		int num = Mathf.RoundToInt((float)Screen.currentResolution.refreshRateRatio.value);
		int num2 = -90;
		foreach (int num3 in dn.FPSOptions)
		{
			if (num3 != -1 && num3 <= num && num3 > num2)
			{
				num2 = num3;
			}
		}
		return num2;
	}

	// Token: 0x06000821 RID: 2081 RVA: 0x0003071C File Offset: 0x0002E91C
	public void fis()
	{
		bq.hlk = false;
		if (!SteamManager.krd)
		{
			Debug.LogError(a.cdv());
			return;
		}
		CSteamID steamID = SteamUser.GetSteamID();
		string text = string.Format(a.cdw(), steamID.m_SteamID);
		string text2 = a.cdx() + text;
		Application.OpenURL(text2);
		Debug.Log(a.cdy() + text2);
	}

	// Token: 0x06000822 RID: 2082 RVA: 0x00030780 File Offset: 0x0002E980
	private int dic()
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return 0;
		}
		return playerSaveData.directApiProviderId;
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x000307B4 File Offset: 0x0002E9B4
	private void kaq()
	{
		bq.hlk = false;
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.cdz(), null);
		string text = dn.byp(table, a.cea(), a.ceb());
		fa fa = fa.imk;
		if (fa == null)
		{
			if (ModalDialogManager.kri && !ModalDialogManager.icb.krh)
			{
				ModalDialogManager.icb.ShowMessage(text, dn.byp(table, a.cec(), a.ced()), null);
			}
			return;
		}
		if (this.btnCheckNow != null)
		{
			this.btnCheckNow.interactable = false;
			base.StartCoroutine(this.byl(4450f));
		}
		fa.cuu();
		if (!ModalDialogManager.kri)
		{
			return;
		}
		if (ModalDialogManager.icb.krh)
		{
			return;
		}
		string text2 = dn.byo(fa.imm, table);
		if (fa.imm == fa.CheckStatus.ApiUnavailable && !string.IsNullOrEmpty(fa.imq))
		{
			text2 = text2 + a.cee() + fa.imq + a.cef();
		}
		ModalDialogManager.icb.ShowMessage(text, text2, null);
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x000308BC File Offset: 0x0002EABC
	private void bzi(int a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || this.dropdownAiModel == null)
		{
			return;
		}
		if (a < 0 || a >= this.dropdownAiModel.options.Count)
		{
			return;
		}
		bq.hlk = false;
		playerSaveData.directApiModel = this.dropdownAiModel.options[a].text;
		ci.Save(null);
		this.bzl(playerSaveData.directApiModel);
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x00030944 File Offset: 0x0002EB44
	private void bzb()
	{
		if (this.dropdownConnectionMode == null)
		{
			return;
		}
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData != null)
		{
			this.bzz(playerSaveData.directApiProviderId);
		}
		this.dropdownConnectionMode.ClearOptions();
		List<string> list = new List<string>();
		foreach (AiConnectionMode aiConnectionMode in dn.hyt)
		{
			list.Add(dn.bza(aiConnectionMode));
		}
		this.dropdownConnectionMode.AddOptions(list);
		this.dropdownConnectionMode.SetValueWithoutNotify((playerSaveData != null) ? dn.byz((AiConnectionMode)Mathf.Clamp(playerSaveData.aiConnectionMode, 0, 2)) : 0);
		this.dropdownConnectionMode.RefreshShownValue();
		this.dropdownConnectionMode.onValueChanged.AddListener(new UnityAction<int>(this.bzc));
		if (this.dropdownAiProvider != null)
		{
			List<string> list2 = new List<string>();
			foreach (AiProviderConfig aiProviderConfig in AiProviderCatalog.All)
			{
				list2.Add(aiProviderConfig.DisplayName);
			}
			this.dropdownAiProvider.ClearOptions();
			this.dropdownAiProvider.AddOptions(list2);
			this.dropdownAiProvider.SetValueWithoutNotify((playerSaveData != null) ? Mathf.Clamp(playerSaveData.directApiProviderId, 0, list2.Count - 1) : 0);
			this.dropdownAiProvider.RefreshShownValue();
			this.dropdownAiProvider.onValueChanged.AddListener(new UnityAction<int>(this.bzf));
		}
		if (this.dropdownChattiness != null)
		{
			this.dropdownChattiness.ClearOptions();
			this.dropdownChattiness.AddOptions(new List<string>
			{
				dn.byy(a.ceg(), a.ceh()),
				dn.byy(a.cei(), a.bfb()),
				dn.byy(a.cej(), a.cek())
			});
			this.dropdownChattiness.SetValueWithoutNotify((playerSaveData != null) ? Mathf.Clamp(playerSaveData.directApiChattinessTier, 0, 2) : 1);
			this.dropdownChattiness.RefreshShownValue();
			this.dropdownChattiness.onValueChanged.AddListener(new UnityAction<int>(this.bzo));
		}
		if (this.inputApiKey != null)
		{
			this.inputApiKey.contentType = TMP_InputField.ContentType.Password;
			this.inputApiKey.text = a.tk();
			this.inputApiKey.onEndEdit.AddListener(new UnityAction<string>(this.bzg));
			this.caf();
		}
		if (this.inputCustomBaseUrl != null)
		{
			this.inputCustomBaseUrl.text = ((playerSaveData != null) ? playerSaveData.directApiBaseUrl : a.tk());
			this.inputCustomBaseUrl.onEndEdit.AddListener(new UnityAction<string>(this.bzh));
		}
		if (this.dropdownAiModel != null)
		{
			List<string> list3 = new List<string>();
			if (playerSaveData != null && !string.IsNullOrEmpty(playerSaveData.directApiModel))
			{
				list3.Add(playerSaveData.directApiModel);
			}
			this.bzn(list3, (playerSaveData != null) ? playerSaveData.directApiModel : null);
			this.dropdownAiModel.onValueChanged.AddListener(new UnityAction<int>(this.bzi));
		}
		if (this.btnRefreshModels != null)
		{
			this.btnRefreshModels.onClick.AddListener(new UnityAction(this.bzj));
		}
		if (this.inputPromptTemplate != null)
		{
			this.inputPromptTemplate.lineType = TMP_InputField.LineType.MultiLineNewline;
			this.inputPromptTemplate.text = this.bzt(playerSaveData);
			this.inputPromptTemplate.onEndEdit.AddListener(new UnityAction<string>(this.bzp));
		}
		if (this.btnRestorePromptDefault != null)
		{
			this.btnRestorePromptDefault.onClick.AddListener(new UnityAction(this.bzq));
		}
		if (this.btnTalkNow != null)
		{
			this.btnTalkNow.onClick.AddListener(new UnityAction(this.bzr));
		}
		if (this.directPrivacyTip != null)
		{
			this.directPrivacyTip.SetActive(false);
		}
		this.bze((AiConnectionMode)((playerSaveData != null) ? playerSaveData.aiConnectionMode : 0));
		this.bzw();
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x00030D7C File Offset: 0x0002EF7C
	public void lna()
	{
		bq.hlk = false;
		if (!SteamManager.krd)
		{
			Debug.LogError(a.cel());
			return;
		}
		if (!ModalDialogManager.kri)
		{
			Debug.LogError(a.cem());
			return;
		}
		if (SteamInventoryManager.iid == null)
		{
			Debug.LogError(a.cen());
			return;
		}
		if (SteamInventoryManager.iid.ksp)
		{
			Debug.LogWarning(a.ceo());
			return;
		}
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.cep(), null);
		string text;
		if (table == null)
		{
			text = null;
		}
		else
		{
			StringTableEntry entry = table.GetEntry(a.ceq());
			text = ((entry != null) ? entry.GetLocalizedString() : null);
		}
		string text2 = text ?? a.cer();
		string text3;
		if (table == null)
		{
			text3 = null;
		}
		else
		{
			StringTableEntry entry2 = table.GetEntry(a.ces());
			text3 = ((entry2 != null) ? entry2.GetLocalizedString() : null);
		}
		string text4 = text3 ?? a.cet();
		string text5;
		if (table == null)
		{
			text5 = null;
		}
		else
		{
			StringTableEntry entry3 = table.GetEntry(a.ceu());
			text5 = ((entry3 != null) ? entry3.GetLocalizedString() : null);
		}
		string text6 = text5 ?? a.cev();
		string text7;
		if (table == null)
		{
			text7 = null;
		}
		else
		{
			StringTableEntry entry4 = table.GetEntry(a.cew());
			text7 = ((entry4 != null) ? entry4.GetLocalizedString() : null);
		}
		string text8 = text7 ?? a.cex();
		string text9;
		if (table == null)
		{
			text9 = null;
		}
		else
		{
			StringTableEntry entry5 = table.GetEntry(a.cey());
			text9 = ((entry5 != null) ? entry5.GetLocalizedString() : null);
		}
		string text10 = text9 ?? a.cez();
		string text11;
		if (table == null)
		{
			text11 = null;
		}
		else
		{
			StringTableEntry entry6 = table.GetEntry(a.cfa());
			text11 = ((entry6 != null) ? entry6.GetLocalizedString() : null);
		}
		string text12 = text11 ?? a.cfb();
		string text13;
		if (table == null)
		{
			text13 = null;
		}
		else
		{
			StringTableEntry entry7 = table.GetEntry(a.cfc());
			text13 = ((entry7 != null) ? entry7.GetLocalizedString() : null);
		}
		string text14 = text13 ?? a.cfd();
		string[] array = new string[-19];
		array[0] = text4;
		array[1] = a.cfe();
		array[2] = text6;
		array[3] = a.cff();
		array[4] = text8;
		array[5] = a.cfg();
		array[6] = text10;
		array[7] = a.cfh();
		array[8] = text12;
		string text15 = string.Concat(array);
		ModalDialogManager.icb.ShowTypingConfirm(text2, text15, a.cfi(), text14, new Action(dn.<>c.<>9.btk), null);
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x00030F89 File Offset: 0x0002F189
	public void bwh()
	{
		if (this.dropdownCharacterMode == null)
		{
			return;
		}
		base.StartCoroutine(this.bwm());
	}

	// Token: 0x06000828 RID: 2088 RVA: 0x00030FA8 File Offset: 0x0002F1A8
	private static string mjb(string a, string b)
	{
		string text;
		try
		{
			if (!LocalizationSettings.InitializationOperation.IsDone)
			{
				text = b;
			}
			else
			{
				StringTable table = LocalizationSettings.StringDatabase.GetTable(a.cfj(), null);
				StringTableEntry stringTableEntry = ((table != null) ? table.GetEntry(a) : null);
				string text2 = ((stringTableEntry != null) ? stringTableEntry.GetLocalizedString() : null);
				text = (string.IsNullOrEmpty(text2) ? b : text2);
			}
		}
		catch
		{
			text = b;
		}
		return text;
	}

	// Token: 0x06000829 RID: 2089 RVA: 0x0003101C File Offset: 0x0002F21C
	private string bwt(int a, bool b, StringTable c)
	{
		if (a == 0)
		{
			StringTableEntry entry = c.GetEntry(a.cfk());
			if (entry == null)
			{
				return null;
			}
			return entry.GetLocalizedString();
		}
		else
		{
			bl bl = bl.kmv;
			CatCharacterDefinition catCharacterDefinition = ((bl != null) ? bl.xp(a) : null);
			if (catCharacterDefinition == null)
			{
				return null;
			}
			string text = ((b && !string.IsNullOrEmpty(catCharacterDefinition.displayNameKey)) ? (catCharacterDefinition.displayNameKey + a.cfl()) : catCharacterDefinition.displayNameKey);
			if (!string.IsNullOrEmpty(text))
			{
				StringTableEntry entry2 = c.GetEntry(text);
				if (entry2 != null)
				{
					return entry2.GetLocalizedString();
				}
			}
			if (!string.IsNullOrEmpty(catCharacterDefinition.displayName))
			{
				return catCharacterDefinition.displayName;
			}
			return catCharacterDefinition.characterId;
		}
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x000310C0 File Offset: 0x0002F2C0
	public void bve(int a)
	{
		if (!bq.hlw)
		{
			return;
		}
		bool flag = PlayerPrefs.GetInt(a.w(), 0) != 0;
		float @float = PlayerPrefs.GetFloat(a.bi(), 0.5f);
		if ((this.sliderSound != null && this.sliderSound.value > 0f) || (this.sliderBMG != null && this.sliderBMG.value > 0f) || (this.sliderSFX != null && this.sliderSFX.value > 0f) || (this.sliderVoice != null && this.sliderVoice.value > 0f) || (flag && @float > 0f))
		{
			this.hyc = ((this.sliderSound != null) ? this.sliderSound.value : 0f);
			this.hyd = ((this.sliderBMG != null) ? this.sliderBMG.value : 0f);
			this.hye = ((this.sliderSFX != null) ? this.sliderSFX.value : 0f);
			this.hyf = ((this.sliderVoice != null) ? this.sliderVoice.value : 0f);
			VolumeMuteButton volumeMuteButton = this.muteButtonBGM;
			if (volumeMuteButton != null)
			{
				volumeMuteButton.cbv();
			}
			VolumeMuteButton volumeMuteButton2 = this.muteButtonSound;
			if (volumeMuteButton2 != null)
			{
				volumeMuteButton2.cbv();
			}
			VolumeMuteButton volumeMuteButton3 = this.muteButtonSFX;
			if (volumeMuteButton3 != null)
			{
				volumeMuteButton3.cbv();
			}
			VolumeMuteButton volumeMuteButton4 = this.muteButtonVoice;
			if (volumeMuteButton4 != null)
			{
				volumeMuteButton4.cbv();
			}
			this.hyh = flag;
			if (flag)
			{
				this.hyg = @float;
				if (@float > 0f)
				{
					PlayerPrefs.SetFloat(a.cfm(), @float);
				}
				AudioManager audioManager = AudioManager.klw;
				if (audioManager != null)
				{
					audioManager.qn(0f, true);
				}
				PlayerPrefs.SetFloat(a.bi(), 0f);
			}
			this.hyb = true;
		}
		else
		{
			if (!this.hyb)
			{
				return;
			}
			if (this.sliderSound != null)
			{
				this.sliderSound.value = this.hyc;
			}
			if (this.sliderBMG != null)
			{
				this.sliderBMG.value = this.hyd;
			}
			if (this.sliderSFX != null)
			{
				this.sliderSFX.value = this.hye;
			}
			if (this.sliderVoice != null)
			{
				this.sliderVoice.value = this.hyf;
			}
			if (this.hyh)
			{
				AudioManager audioManager2 = AudioManager.klw;
				if (audioManager2 != null)
				{
					audioManager2.qn(this.hyg, true);
				}
				PlayerPrefs.SetFloat(a.bi(), this.hyg);
			}
			this.hyb = false;
		}
		this.bvf();
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x00031384 File Offset: 0x0002F584
	private string bwn(int a, StringTable b)
	{
		bool flag = this.bwe(a);
		string text = this.bwt(a, flag, b);
		if (string.IsNullOrEmpty(text))
		{
			text = string.Format(a.cfn(), a);
		}
		bl bl = bl.kmv;
		CatCharacterDefinition catCharacterDefinition = ((bl != null) ? bl.xp(a) : null);
		if (catCharacterDefinition != null && catCharacterDefinition.unlockType == CatUnlockType.Workshop)
		{
			text += a.cfo();
		}
		if (flag)
		{
			text = a.cfp() + text + a.cfq();
		}
		return text;
	}

	// Token: 0x0600082C RID: 2092 RVA: 0x00028250 File Offset: 0x00026450
	private void cbv()
	{
		bq.zr();
		if (this.dropdownDropNotification == null)
		{
			return;
		}
		this.bxz();
	}

	// Token: 0x0600082D RID: 2093 RVA: 0x00031404 File Offset: 0x0002F604
	private void bxl()
	{
		if (this.dropdownSize != null)
		{
			this.bxo(this.dropdownSize, this.sizeController, bq.hlo, out this.hyn);
		}
		if (this.dropdownUISize != null)
		{
			this.bxo(this.dropdownUISize, this.sizeUIController, bq.hlp, out this.hyo);
		}
		if (this.dropdownToolbarSize != null && this.sizeToolbarController != null)
		{
			this.bxo(this.dropdownToolbarSize, this.sizeToolbarController, bq.hlq, out this.hyp);
		}
		if (this.dropdownSpeechBubbleSize != null && this.sizeSpeechBubbleController != null)
		{
			this.bxo(this.dropdownSpeechBubbleSize, this.sizeSpeechBubbleController, bq.hlr, out this.hyq);
			return;
		}
		if (this.sizeSpeechBubbleController != null)
		{
			this.sizeSpeechBubbleController.bds(bq.hlr);
		}
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x000314F8 File Offset: 0x0002F6F8
	public void icg(bool a)
	{
		bq.hlk = false;
		bool flag = q.tq(a);
		bool flag2 = a && !flag && q.kmh && d.mc();
		if (!flag && !flag2)
		{
			this.toggleAutoStart.SetIsOnWithoutNotify(!a);
			return;
		}
		PlayerPrefs.SetInt(a.cfr(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x00031554 File Offset: 0x0002F754
	private void ext()
	{
		q.tt();
		if (this.toggleAutoStart == null)
		{
			return;
		}
		if (!q.kmh)
		{
			this.toggleAutoStart.gameObject.SetActive(false);
			return;
		}
		bool flag = PlayerPrefs.GetInt(a.cfs(), 0) == 1;
		if (!q.tp(flag))
		{
			q.tq(flag);
		}
		this.toggleAutoStart.SetIsOnWithoutNotify(flag);
	}

	// Token: 0x06000830 RID: 2096 RVA: 0x0002DA3A File Offset: 0x0002BC3A
	private void lku(TMP_Dropdown a, bz b, int c, out int[] d)
	{
		this.hyr = true;
		dn.bxn(a, b, c, out d, null);
		this.hyr = false;
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x000315B8 File Offset: 0x0002F7B8
	private void civ(int a)
	{
		if (this.hyr)
		{
			return;
		}
		if (this.hyn == null || a < 0 || a >= this.hyn.Length)
		{
			return;
		}
		bq.hlk = false;
		int num = this.hyn[a];
		bq.hlo = num;
		this.sizeController.bds(num);
		PlayerPrefs.SetInt(a.cft(), num);
		PlayerPrefs.Save();
	}

	// Token: 0x06000832 RID: 2098 RVA: 0x00031618 File Offset: 0x0002F818
	private static string czh(string a, string b)
	{
		string text;
		try
		{
			if (!LocalizationSettings.InitializationOperation.IsDone)
			{
				text = b;
			}
			else
			{
				StringTable table = LocalizationSettings.StringDatabase.GetTable(a.cfu(), null);
				StringTableEntry stringTableEntry = ((table != null) ? table.GetEntry(a) : null);
				string text2 = ((stringTableEntry != null) ? stringTableEntry.GetLocalizedString() : null);
				text = (string.IsNullOrEmpty(text2) ? b : text2);
			}
		}
		catch
		{
			text = b;
		}
		return text;
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x0003168C File Offset: 0x0002F88C
	public void bvu(BaseEventData a)
	{
		PlayerPrefs.SetFloat(a.sd(), this.sliderSound.value);
		PlayerPrefs.Save();
		bq.hlk = false;
		if (this.hxs && AudioManager.klw != null && !this.soundPreviewUI.IsNull)
		{
			AudioManager.klw.qw(this.soundPreviewUI, bx.hod.koe, 1f);
		}
	}

	// Token: 0x06000834 RID: 2100 RVA: 0x000316FB File Offset: 0x0002F8FB
	public void con()
	{
		bq.hlk = false;
		Application.OpenURL(a.cfv());
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x00031710 File Offset: 0x0002F910
	private void bzf(int a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		playerSaveData.directApiProviderId = a;
		playerSaveData.directApiModel = a.tk();
		ci.Save(null);
		AiProviderConfig aiProviderConfig = AiProviderCatalog.For(a);
		if (this.inputCustomBaseUrl != null)
		{
			this.inputCustomBaseUrl.gameObject.SetActive(aiProviderConfig.AllowsCustomBaseUrl);
		}
		this.bzn(new List<string>(), null);
		DirectApiScheduler instance = DirectApiScheduler.Instance;
		if (instance != null)
		{
			instance.ResetRuntimeStatus();
		}
		this.caf();
		this.bzw();
		this.bzj();
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x000317B4 File Offset: 0x0002F9B4
	public static int jso(TMP_Dropdown a, bz b, int c, out int[] d, Func<int, string, string> e = null)
	{
		dn.dd dd = new dn.dd();
		dd.hwm = b;
		d = new int[dd.hwm.sizes.Count];
		for (int i = 0; i < d.Length; i++)
		{
			d[i] = i;
		}
		Array.Sort<int>(d, new Comparison<int>(dd.bto));
		a.ClearOptions();
		List<string> list = new List<string>();
		int num = 0;
		for (int j = 0; j < d.Length; j++)
		{
			int num2 = d[j];
			string text = a.cfw() + dd.hwm.bdq(num2).ToString();
			if (e != null)
			{
				text = e(num2, text);
			}
			list.Add(text);
			if (num2 == c)
			{
				num = j;
			}
		}
		a.AddOptions(list);
		a.value = num;
		a.RefreshShownValue();
		return num;
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x0003188C File Offset: 0x0002FA8C
	public void eva(bool a)
	{
		bq.hlk = false;
		UniWindowController.current.isTopmost = a;
		UniWindowController.current.forceTopmost = a;
		PlayerPrefs.SetInt(a.cfx(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x000318C0 File Offset: 0x0002FAC0
	private void dlr()
	{
		bq.hlk = false;
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.cfy(), null);
		string text = dn.byp(table, a.cfz(), a.cga());
		fa fa = fa.imk;
		if (fa == null)
		{
			if (ModalDialogManager.kri && !ModalDialogManager.icb.krh)
			{
				ModalDialogManager.icb.ShowMessage(text, dn.byp(table, a.cgb(), a.cgc()), null);
			}
			return;
		}
		if (this.btnCheckNow != null)
		{
			this.btnCheckNow.interactable = false;
			base.StartCoroutine(this.byl(5684f));
		}
		fa.cuu();
		if (!ModalDialogManager.kri)
		{
			return;
		}
		if (ModalDialogManager.icb.krh)
		{
			return;
		}
		string text2 = dn.byo(fa.imm, table);
		if (fa.imm == fa.CheckStatus.ApiUnavailable && !string.IsNullOrEmpty(fa.imq))
		{
			text2 = text2 + a.cgd() + fa.imq + a.cge();
		}
		ModalDialogManager.icb.ShowMessage(text, text2, null);
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x000319C8 File Offset: 0x0002FBC8
	private static string bya(string a, string b)
	{
		string text;
		try
		{
			if (!LocalizationSettings.InitializationOperation.IsDone)
			{
				text = b;
			}
			else
			{
				StringTable table = LocalizationSettings.StringDatabase.GetTable(a.rh(), null);
				StringTableEntry stringTableEntry = ((table != null) ? table.GetEntry(a) : null);
				string text2 = ((stringTableEntry != null) ? stringTableEntry.GetLocalizedString() : null);
				text = (string.IsNullOrEmpty(text2) ? b : text2);
			}
		}
		catch
		{
			text = b;
		}
		return text;
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x00031A3C File Offset: 0x0002FC3C
	private void jui(bool a)
	{
		IntPtr activeWindow = dn.GetActiveWindow();
		if (activeWindow != IntPtr.Zero)
		{
			int num = dn.GetWindowLong(activeWindow, 95);
			if (a)
			{
				num &= -11;
				num |= 85;
			}
			else
			{
				num &= 72;
				num |= 40;
			}
			dn.SetWindowLong(activeWindow, 16, num);
		}
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x00031A88 File Offset: 0x0002FC88
	private void oss(List<string> a, string b)
	{
		dn.de de = new dn.de();
		de.hwn = b;
		if (this.dropdownAiModel == null)
		{
			return;
		}
		this.dropdownAiModel.ClearOptions();
		if (a == null || a.Count == 0)
		{
			this.dropdownAiModel.RefreshShownValue();
			return;
		}
		this.dropdownAiModel.AddOptions(a);
		int num = 0;
		if (!string.IsNullOrEmpty(de.hwn))
		{
			int num2 = a.FindIndex(new Predicate<string>(de.btp));
			if (num2 >= 0)
			{
				num = num2;
			}
		}
		this.dropdownAiModel.SetValueWithoutNotify(num);
		this.dropdownAiModel.RefreshShownValue();
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x00031B1E File Offset: 0x0002FD1E
	private void bzx(string a)
	{
		if (this.directStatusText != null)
		{
			this.directStatusText.text = a;
		}
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x00031B3C File Offset: 0x0002FD3C
	private void bzg(string a)
	{
		bq.hlk = false;
		string text = (a ?? a.tk()).Trim();
		if (this.inputApiKey != null)
		{
			this.inputApiKey.text = a.tk();
		}
		if (string.IsNullOrEmpty(text))
		{
			DirectApiScheduler instance = DirectApiScheduler.Instance;
			if (instance != null)
			{
				instance.ResetRuntimeStatus();
			}
			this.caf();
			this.bzw();
			return;
		}
		if (!this.cac(this.cae(), text))
		{
			this.bzx(dn.byy(a.cgf(), a.cgg()));
			return;
		}
		DirectApiScheduler instance2 = DirectApiScheduler.Instance;
		if (instance2 != null)
		{
			instance2.ResetRuntimeStatus();
		}
		this.caf();
		this.bzw();
		this.bzj();
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x00031BEC File Offset: 0x0002FDEC
	private bool ede(int a, string b)
	{
		bool flag;
		try
		{
			flag = AiSecretStore.StoreKey(a, b);
		}
		catch (Exception ex)
		{
			string text = a.cgh();
			Exception ex2 = ex;
			Debug.LogError(text + ((ex2 != null) ? ex2.ToString() : null));
			flag = false;
		}
		return flag;
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x00031C38 File Offset: 0x0002FE38
	public void hc(bool a)
	{
		bq.hlk = false;
		bool flag = q.tq(a);
		bool flag2 = a && !flag && q.kmh && d.mc();
		if (!flag && !flag2)
		{
			this.toggleAutoStart.SetIsOnWithoutNotify(!a);
			return;
		}
		PlayerPrefs.SetInt(a.cgi(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x00031C94 File Offset: 0x0002FE94
	private IEnumerator buz(float a)
	{
		yield return new WaitForSecondsRealtime(a);
		if (this.btnOpenCustomGameList != null)
		{
			this.btnOpenCustomGameList.interactable = true;
		}
		yield break;
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x00031CAC File Offset: 0x0002FEAC
	private void ige(AiConnectionMode a)
	{
		this.hys = true;
		if (this.dropdownConnectionMode != null)
		{
			this.dropdownConnectionMode.SetValueWithoutNotify(dn.byz(a));
			this.dropdownConnectionMode.RefreshShownValue();
		}
		this.hys = false;
		bool flag = a == AiConnectionMode.Mcp;
		bool flag2 = a == AiConnectionMode.DirectApi;
		if (this.mcpStatus != null)
		{
			this.mcpStatus.SetActive(flag);
		}
		if (this.mcpOpenDocButton != null)
		{
			this.mcpOpenDocButton.gameObject.SetActive(flag);
		}
		if (this.mcpRetryButton != null)
		{
			this.mcpRetryButton.gameObject.SetActive(flag);
		}
		if (!flag && this.mcpFirstTimeTip != null)
		{
			this.mcpFirstTimeTip.SetActive(false);
		}
		if (this.directApiPanel != null)
		{
			this.directApiPanel.SetActive(flag2);
		}
		if (!flag2 && this.directPrivacyTip != null)
		{
			this.directPrivacyTip.SetActive(false);
		}
		if (this.inputCustomBaseUrl != null)
		{
			AiProviderConfig aiProviderConfig = AiProviderCatalog.For((this.dropdownAiProvider != null) ? this.dropdownAiProvider.value : 0);
			this.inputCustomBaseUrl.gameObject.SetActive(flag2 && aiProviderConfig.AllowsCustomBaseUrl);
		}
		if (this.mcpExtraToggleTargets != null)
		{
			for (int i = 0; i < this.mcpExtraToggleTargets.Length; i++)
			{
				if (this.mcpExtraToggleTargets[i] != null)
				{
					this.mcpExtraToggleTargets[i].SetActive(a > AiConnectionMode.None);
				}
			}
		}
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x00031E2F File Offset: 0x0003002F
	public void kfr()
	{
		bq.hlk = false;
		Application.OpenURL(a.cgj());
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x0002C9F0 File Offset: 0x0002ABF0
	public void ve()
	{
		bq.hlk = false;
		Application.Quit();
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x00031E44 File Offset: 0x00030044
	private void bzl(string a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || string.IsNullOrEmpty(a))
		{
			return;
		}
		if (a == this.hyv && Time.unscaledTime - this.hyu < 3f)
		{
			return;
		}
		if (this.hyw)
		{
			return;
		}
		string text = this.cab(playerSaveData.directApiProviderId);
		if (string.IsNullOrEmpty(text))
		{
			this.bzx(dn.byy(a.bxg(), a.bxh()));
			return;
		}
		if (AiRequestRunner.Instance.IsChatBusy)
		{
			this.bzx(dn.byy(a.cgk(), a.cgl()));
			return;
		}
		int directApiProviderId = playerSaveData.directApiProviderId;
		AiProviderConfig aiProviderConfig = AiProviderCatalog.For((AiProviderId)directApiProviderId);
		string text2 = ((aiProviderConfig.AllowsCustomBaseUrl && !string.IsNullOrEmpty(playerSaveData.directApiBaseUrl)) ? playerSaveData.directApiBaseUrl : aiProviderConfig.DefaultBaseUrl);
		IAiChatAdapter aiChatAdapter = AiAdapterFactory.Create((AiProviderId)directApiProviderId);
		AiChatRequest aiChatRequest = new AiChatRequest(a, a.cgm(), a.cgn(), 2048, -1f);
		this.hyw = true;
		this.hyu = Time.unscaledTime;
		this.hyv = a;
		this.bzx(dn.byy(a.bzl(), a.bmy()));
		AiRequestRunner.Instance.SendChat(aiChatAdapter, aiProviderConfig, text2, text, aiChatRequest, 15, new Action<AiChatResult>(this.bzm));
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x00031F94 File Offset: 0x00030194
	public static int oid(TMP_Dropdown a, bz b, int c, out int[] d, Func<int, string, string> e = null)
	{
		dn.dd dd = new dn.dd();
		dd.hwm = b;
		d = new int[dd.hwm.sizes.Count];
		for (int i = 0; i < d.Length; i++)
		{
			d[i] = i;
		}
		Array.Sort<int>(d, new Comparison<int>(dd.bto));
		a.ClearOptions();
		List<string> list = new List<string>();
		int num = 0;
		for (int j = 0; j < d.Length; j++)
		{
			int num2 = d[j];
			string text = a.cgo() + dd.hwm.bdq(num2).ToString();
			if (e != null)
			{
				text = e(num2, text);
			}
			list.Add(text);
			if (num2 == c)
			{
				num = j;
			}
		}
		a.AddOptions(list);
		a.value = num;
		a.RefreshShownValue();
		return num;
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x0003206C File Offset: 0x0003026C
	private void bzr()
	{
		bq.hlk = false;
		if (this.btnTalkNow != null)
		{
			base.StartCoroutine(this.bzs(this.btnTalkNow, 2f));
		}
		if (DirectApiScheduler.Instance != null)
		{
			DirectApiScheduler.Instance.TalkNow();
		}
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x000320BC File Offset: 0x000302BC
	private bool bzz(int a)
	{
		bool flag;
		try
		{
			flag = AiSecretStore.MigrateLegacyKey(a);
		}
		catch (Exception ex)
		{
			string text = a.cgp();
			Exception ex2 = ex;
			Debug.LogError(text + ((ex2 != null) ? ex2.ToString() : null));
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x00032104 File Offset: 0x00030304
	private void nyy(AiConnectionMode a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		McpDialogueServer instance = McpDialogueServer.Instance;
		if (instance != null)
		{
			instance.StopServer();
		}
		DirectApiScheduler instance2 = DirectApiScheduler.Instance;
		if (instance2 != null)
		{
			instance2.Disable();
		}
		playerSaveData.aiConnectionMode = (int)a;
		playerSaveData.aiConnectionEnabled = a == AiConnectionMode.Mcp;
		bool flag = false;
		bool flag2 = false;
		if (a == AiConnectionMode.Mcp && !playerSaveData.firstTimeMcpToggleDone)
		{
			playerSaveData.firstTimeMcpToggleDone = true;
			flag = true;
		}
		if (a == AiConnectionMode.DirectApi && !playerSaveData.directApiFirstTimeTipDone)
		{
			playerSaveData.directApiFirstTimeTipDone = true;
			flag2 = true;
		}
		ci.Save(null);
		if (a == AiConnectionMode.Mcp)
		{
			McpDialogueServer instance3 = McpDialogueServer.Instance;
			if (instance3 != null)
			{
				instance3.StartServer();
			}
		}
		else if (a == AiConnectionMode.DirectApi)
		{
			DirectApiScheduler.EnsureInstance().Enable();
		}
		if (flag && this.mcpFirstTimeTip != null)
		{
			this.mcpFirstTimeTip.SetActive(true);
		}
		if (flag2 && this.directPrivacyTip != null)
		{
			this.directPrivacyTip.SetActive(true);
		}
		this.bze(a);
		this.bzw();
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x00032208 File Offset: 0x00030408
	private void iwi(int a)
	{
		if (this.hyr)
		{
			return;
		}
		if (this.hyq == null || a < 0 || a >= this.hyq.Length)
		{
			return;
		}
		if (this.sizeSpeechBubbleController == null)
		{
			return;
		}
		bq.hlk = false;
		int num = this.hyq[a];
		bq.hlr = num;
		this.sizeSpeechBubbleController.bds(num);
		PlayerPrefs.SetInt(a.cgq(), num);
		PlayerPrefs.Save();
		Canvas.ForceUpdateCanvases();
		if (this.speechBubbleController != null)
		{
			float num2 = this.sizeSpeechBubbleController.bdq(num);
			string text = a.cgr();
			StringTable table = LocalizationSettings.StringDatabase.GetTable(a.cgs(), null);
			StringTableEntry stringTableEntry = ((table != null) ? table.GetEntry(a.cgt()) : null);
			if (stringTableEntry != null)
			{
				text = stringTableEntry.GetLocalizedString();
			}
			string text2 = string.Format(text, num2.ToString(a.cgu()));
			this.speechBubbleController.ShowSizePreview(text2, 6765f);
		}
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x00028A25 File Offset: 0x00026C25
	public static void kqa(int a)
	{
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate = a;
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x000322F4 File Offset: 0x000304F4
	private string cfw(int a)
	{
		string text;
		try
		{
			text = AiSecretStore.GetKeyForRequest(a) ?? a.cgv();
		}
		catch (Exception ex)
		{
			string text2 = a.cgw();
			Exception ex2 = ex;
			Debug.LogError(text2 + ((ex2 != null) ? ex2.ToString() : null));
			text = a.cgx();
		}
		return text;
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x0003234C File Offset: 0x0003054C
	private static string mde(fa.CheckStatus a, StringTable b)
	{
		string text;
		switch (a)
		{
		case fa.CheckStatus.Checking:
			text = dn.byp(b, a.cgy(), a.cgz());
			break;
		case fa.CheckStatus.UpToDate:
			text = dn.byp(b, a.cha(), a.chb());
			break;
		case fa.CheckStatus.UpdateAvailable:
			text = dn.byp(b, a.chc(), a.chd());
			break;
		case fa.CheckStatus.ApiUnavailable:
			text = dn.byp(b, a.che(), a.chf());
			break;
		default:
			text = dn.byp(b, a.chg(), a.chh());
			break;
		}
		return text;
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x00029E24 File Offset: 0x00028024
	private void jhp()
	{
		bq.zs();
		if (this.toggleDropAnimation != null)
		{
			this.toggleDropAnimation.SetIsOnWithoutNotify(bq.hmc);
		}
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x00027012 File Offset: 0x00025212
	private void lnc()
	{
		if (this.hotkeyHintWindows != null)
		{
			this.hotkeyHintWindows.SetActive(true);
		}
		if (this.hotkeyHintMac != null)
		{
			this.hotkeyHintMac.SetActive(false);
		}
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x000323D4 File Offset: 0x000305D4
	public void bwq()
	{
		if (this.dropdownVoice == null)
		{
			return;
		}
		VoiceConfig hlg = bq.hlg;
		if (hlg == null || hlg.kpk == 0)
		{
			this.dropdownVoice.gameObject.SetActive(false);
			return;
		}
		this.dropdownVoice.gameObject.SetActive(true);
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.rh(), null);
		this.hyk = true;
		this.dropdownVoice.ClearOptions();
		List<string> list = new List<string>();
		for (int i = 0; i < hlg.profiles.Count; i++)
		{
			list.Add(this.bwr(hlg.profiles[i], i, table));
		}
		this.dropdownVoice.AddOptions(list);
		this.dropdownVoice.value = Mathf.Clamp(bq.hlh, 0, hlg.profiles.Count - 1);
		this.dropdownVoice.RefreshShownValue();
		this.hyk = false;
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x000324CC File Offset: 0x000306CC
	private int oho(int a)
	{
		int num = this.kqp;
		if (a >= num)
		{
			return a + 1;
		}
		return a;
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x000324EC File Offset: 0x000306EC
	public static int oqq(TMP_Dropdown a, bz b, int c, out int[] d, Func<int, string, string> e = null)
	{
		dn.dd dd = new dn.dd();
		dd.hwm = b;
		d = new int[dd.hwm.sizes.Count];
		for (int i = 0; i < d.Length; i++)
		{
			d[i] = i;
		}
		Array.Sort<int>(d, new Comparison<int>(dd.bto));
		a.ClearOptions();
		List<string> list = new List<string>();
		int num = 0;
		for (int j = 0; j < d.Length; j++)
		{
			int num2 = d[j];
			string text = a.chi() + dd.hwm.bdq(num2).ToString();
			if (e != null)
			{
				text = e(num2, text);
			}
			list.Add(text);
			if (num2 == c)
			{
				num = j;
			}
		}
		a.AddOptions(list);
		a.value = num;
		a.RefreshShownValue();
		return num;
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x000325C4 File Offset: 0x000307C4
	public void gd(bool a)
	{
		bq.hlk = false;
		this.windowDragHandler.enableAutoSnap = a;
		PlayerPrefs.SetInt(a.chj(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x0002DA3A File Offset: 0x0002BC3A
	private void bxo(TMP_Dropdown a, bz b, int c, out int[] d)
	{
		this.hyr = true;
		dn.bxn(a, b, c, out d, null);
		this.hyr = false;
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x00028A58 File Offset: 0x00026C58
	private void njy(int a)
	{
		if (this.hys)
		{
			return;
		}
		this.bzd(dn.hyt[Mathf.Clamp(a, 0, dn.hyt.Length - 1)]);
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x00027157 File Offset: 0x00025357
	public void nsc()
	{
		bq.hlk = false;
		CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
		if (characterDragTarget == null)
		{
			return;
		}
		characterDragTarget.bgy();
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x000325EE File Offset: 0x000307EE
	private void mns(int a)
	{
		if (!Enum.IsDefined(typeof(DirtinessMode), a))
		{
			return;
		}
		bq.hmb = (DirtinessMode)a;
		PlayerPrefs.SetInt(a.chk(), a);
		PlayerPrefs.Save();
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00032620 File Offset: 0x00030820
	private void eng()
	{
		if (this.dropdownFPS == null)
		{
			return;
		}
		int num = dn.bxt();
		dn.bxu(num);
		List<string> list = new List<string>();
		int num2 = 0;
		string text = dn.bxw();
		for (int i = 0; i < dn.FPSOptions.Length; i++)
		{
			int num3 = dn.FPSOptions[i];
			list.Add((num3 == -1) ? text : num3.ToString());
			if (num3 == num)
			{
				num2 = i;
			}
		}
		this.dropdownFPS.ClearOptions();
		this.dropdownFPS.AddOptions(list);
		this.dropdownFPS.SetValueWithoutNotify(num2);
		this.dropdownFPS.RefreshShownValue();
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x000326C4 File Offset: 0x000308C4
	private void bxp(int a)
	{
		if (this.hyr)
		{
			return;
		}
		if (this.hyn == null || a < 0 || a >= this.hyn.Length)
		{
			return;
		}
		bq.hlk = false;
		int num = this.hyn[a];
		bq.hlo = num;
		this.sizeController.bds(num);
		PlayerPrefs.SetInt(a.blg(), num);
		PlayerPrefs.Save();
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x00032724 File Offset: 0x00030924
	private void bzq()
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		playerSaveData.directApiTemplateCustomized = false;
		playerSaveData.directApiPromptTemplate = a.tk();
		ci.Save(null);
		if (this.inputPromptTemplate != null)
		{
			this.inputPromptTemplate.text = AiPromptComposer.GetLocalizedDefaultTemplate();
		}
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x0003278C File Offset: 0x0003098C
	public void bxg(bool a)
	{
		bq.hlk = false;
		bq.hmc = a;
		PlayerPrefs.SetInt(a.ri(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x000327B0 File Offset: 0x000309B0
	private void bxq(int a)
	{
		if (this.hyr)
		{
			return;
		}
		if (this.hyo == null || a < 0 || a >= this.hyo.Length)
		{
			return;
		}
		bq.hlk = false;
		int num = this.hyo[a];
		bq.hlp = num;
		this.sizeUIController.bds(num);
		PlayerPrefs.SetInt(a.blh(), num);
		PlayerPrefs.Save();
		Canvas.ForceUpdateCanvases();
		if (SettingPanel.kqq != null)
		{
			SettingPanel.kqq.caz();
		}
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x0003282C File Offset: 0x00030A2C
	private string cab(int a)
	{
		string text;
		try
		{
			text = AiSecretStore.GetKeyForRequest(a) ?? a.tk();
		}
		catch (Exception ex)
		{
			string text2 = a.chl();
			Exception ex2 = ex;
			Debug.LogError(text2 + ((ex2 != null) ? ex2.ToString() : null));
			text = a.tk();
		}
		return text;
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x00032884 File Offset: 0x00030A84
	private void eyd(AiChatResult a)
	{
		this.hyw = false;
		if (a == null)
		{
			return;
		}
		if (a.Ok)
		{
			string text = dn.byy(a.chm(), a.chn());
			this.bzx(text);
			DirectApiScheduler instance = DirectApiScheduler.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ShowModalMessage(a.cho(), text);
			return;
		}
		else
		{
			this.bzx(dn.cag(a.Error));
			DirectApiScheduler instance2 = DirectApiScheduler.Instance;
			if (instance2 == null)
			{
				return;
			}
			instance2.ShowApiError(a.Error, a.RawDetail);
			return;
		}
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x00032904 File Offset: 0x00030B04
	private int fwv(int a)
	{
		int num = this.kqp;
		if (a == num)
		{
			return -1;
		}
		if (a >= num)
		{
			return a - 1;
		}
		return a;
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x00032928 File Offset: 0x00030B28
	public void bsy(int a)
	{
		if (!bq.hlw)
		{
			return;
		}
		bool flag = PlayerPrefs.GetInt(a.chp(), 0) != 0;
		float @float = PlayerPrefs.GetFloat(a.chq(), -5078f);
		if ((this.sliderSound != null && this.sliderSound.value > 1856f) || (this.sliderBMG != null && this.sliderBMG.value > 698f) || (this.sliderSFX != null && this.sliderSFX.value > 5664f) || (this.sliderVoice != null && this.sliderVoice.value > 8934f) || (flag && @float > 8313f))
		{
			this.hyc = ((this.sliderSound != null) ? this.sliderSound.value : 9716f);
			this.hyd = ((this.sliderBMG != null) ? this.sliderBMG.value : 7060f);
			this.hye = ((this.sliderSFX != null) ? this.sliderSFX.value : (-8150f));
			this.hyf = ((this.sliderVoice != null) ? this.sliderVoice.value : 7191f);
			VolumeMuteButton volumeMuteButton = this.muteButtonBGM;
			if (volumeMuteButton != null)
			{
				volumeMuteButton.cbv();
			}
			VolumeMuteButton volumeMuteButton2 = this.muteButtonSound;
			if (volumeMuteButton2 != null)
			{
				volumeMuteButton2.cbv();
			}
			VolumeMuteButton volumeMuteButton3 = this.muteButtonSFX;
			if (volumeMuteButton3 != null)
			{
				volumeMuteButton3.cbv();
			}
			VolumeMuteButton volumeMuteButton4 = this.muteButtonVoice;
			if (volumeMuteButton4 != null)
			{
				volumeMuteButton4.cbv();
			}
			this.hyh = flag;
			if (flag)
			{
				this.hyg = @float;
				if (@float > -9999f)
				{
					PlayerPrefs.SetFloat(a.chr(), @float);
				}
				AudioManager audioManager = AudioManager.klw;
				if (audioManager != null)
				{
					audioManager.qn(-8340f, true);
				}
				PlayerPrefs.SetFloat(a.chs(), 3964f);
			}
			this.hyb = true;
		}
		else
		{
			if (!this.hyb)
			{
				return;
			}
			if (this.sliderSound != null)
			{
				this.sliderSound.value = this.hyc;
			}
			if (this.sliderBMG != null)
			{
				this.sliderBMG.value = this.hyd;
			}
			if (this.sliderSFX != null)
			{
				this.sliderSFX.value = this.hye;
			}
			if (this.sliderVoice != null)
			{
				this.sliderVoice.value = this.hyf;
			}
			if (this.hyh)
			{
				AudioManager audioManager2 = AudioManager.klw;
				if (audioManager2 != null)
				{
					audioManager2.qn(this.hyg, true);
				}
				PlayerPrefs.SetFloat(a.cht(), this.hyg);
			}
			this.hyb = false;
		}
		this.bvf();
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x00032BEC File Offset: 0x00030DEC
	public static int oui()
	{
		if (PlayerPrefs.HasKey(a.chu()))
		{
			return PlayerPrefs.GetInt(a.chv());
		}
		int num = Mathf.RoundToInt((float)Screen.currentResolution.refreshRateRatio.value);
		int num2 = 4;
		foreach (int num3 in dn.FPSOptions)
		{
			if (num3 != -1 && num3 <= num && num3 > num2)
			{
				num2 = num3;
			}
		}
		return num2;
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x00032C64 File Offset: 0x00030E64
	private void bxx(int a)
	{
		if (a < 0 || a >= dn.FPSOptions.Length)
		{
			return;
		}
		int num = dn.FPSOptions[a];
		dn.bxu(num);
		PlayerPrefs.SetInt(a.bmc(), num);
		PlayerPrefs.Save();
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x00032CA0 File Offset: 0x00030EA0
	private void byk()
	{
		bq.hlk = false;
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.rh(), null);
		string text = dn.byp(table, a.chw(), a.chx());
		fa fa = fa.imk;
		if (fa == null)
		{
			if (ModalDialogManager.kri && !ModalDialogManager.icb.krh)
			{
				ModalDialogManager.icb.ShowMessage(text, dn.byp(table, a.bnd(), a.bne()), null);
			}
			return;
		}
		if (this.btnCheckNow != null)
		{
			this.btnCheckNow.interactable = false;
			base.StartCoroutine(this.byl(2f));
		}
		fa.cuu();
		if (!ModalDialogManager.kri)
		{
			return;
		}
		if (ModalDialogManager.icb.krh)
		{
			return;
		}
		string text2 = dn.byo(fa.imm, table);
		if (fa.imm == fa.CheckStatus.ApiUnavailable && !string.IsNullOrEmpty(fa.imq))
		{
			text2 = text2 + a.chy() + fa.imq + a.chz();
		}
		ModalDialogManager.icb.ShowMessage(text, text2, null);
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x000297F2 File Offset: 0x000279F2
	private void bgo()
	{
		bq.zu();
		if (this.dropdownDirtiness == null)
		{
			return;
		}
		this.byd();
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x00032DA8 File Offset: 0x00030FA8
	private void gti()
	{
		int num = PlayerPrefs.GetInt(a.cia(), 0);
		bl bl = bl.kmv;
		if (bl == null)
		{
			return;
		}
		if (num < 0 || num >= bl.kmu || this.bwe(num))
		{
			num = 0;
			PlayerPrefs.SetInt(a.cib(), num);
			PlayerPrefs.Save();
		}
		bl.xh(num);
		if (base.gameObject.activeInHierarchy)
		{
			base.StartCoroutine(this.bwg());
		}
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x00032E1C File Offset: 0x0003101C
	private void jjc()
	{
		if (this.dropdownConnectionMode == null)
		{
			return;
		}
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData != null)
		{
			this.bzz(playerSaveData.directApiProviderId);
		}
		this.dropdownConnectionMode.ClearOptions();
		List<string> list = new List<string>();
		foreach (AiConnectionMode aiConnectionMode in dn.hyt)
		{
			list.Add(dn.bza(aiConnectionMode));
		}
		this.dropdownConnectionMode.AddOptions(list);
		this.dropdownConnectionMode.SetValueWithoutNotify((playerSaveData != null) ? dn.byz((AiConnectionMode)Mathf.Clamp(playerSaveData.aiConnectionMode, 0, 2)) : 0);
		this.dropdownConnectionMode.RefreshShownValue();
		this.dropdownConnectionMode.onValueChanged.AddListener(new UnityAction<int>(this.bzc));
		if (this.dropdownAiProvider != null)
		{
			List<string> list2 = new List<string>();
			foreach (AiProviderConfig aiProviderConfig in AiProviderCatalog.All)
			{
				list2.Add(aiProviderConfig.DisplayName);
			}
			this.dropdownAiProvider.ClearOptions();
			this.dropdownAiProvider.AddOptions(list2);
			this.dropdownAiProvider.SetValueWithoutNotify((playerSaveData != null) ? Mathf.Clamp(playerSaveData.directApiProviderId, 0, list2.Count - 1) : 0);
			this.dropdownAiProvider.RefreshShownValue();
			this.dropdownAiProvider.onValueChanged.AddListener(new UnityAction<int>(this.bzf));
		}
		if (this.dropdownChattiness != null)
		{
			this.dropdownChattiness.ClearOptions();
			this.dropdownChattiness.AddOptions(new List<string>
			{
				dn.byy(a.cic(), a.cid()),
				dn.byy(a.cie(), a.cif()),
				dn.byy(a.cig(), a.cih())
			});
			this.dropdownChattiness.SetValueWithoutNotify((playerSaveData != null) ? Mathf.Clamp(playerSaveData.directApiChattinessTier, 0, 2) : 1);
			this.dropdownChattiness.RefreshShownValue();
			this.dropdownChattiness.onValueChanged.AddListener(new UnityAction<int>(this.bzo));
		}
		if (this.inputApiKey != null)
		{
			this.inputApiKey.contentType = TMP_InputField.ContentType.Password;
			this.inputApiKey.text = a.cii();
			this.inputApiKey.onEndEdit.AddListener(new UnityAction<string>(this.bzg));
			this.caf();
		}
		if (this.inputCustomBaseUrl != null)
		{
			this.inputCustomBaseUrl.text = ((playerSaveData != null) ? playerSaveData.directApiBaseUrl : a.cij());
			this.inputCustomBaseUrl.onEndEdit.AddListener(new UnityAction<string>(this.bzh));
		}
		if (this.dropdownAiModel != null)
		{
			List<string> list3 = new List<string>();
			if (playerSaveData != null && !string.IsNullOrEmpty(playerSaveData.directApiModel))
			{
				list3.Add(playerSaveData.directApiModel);
			}
			this.bzn(list3, (playerSaveData != null) ? playerSaveData.directApiModel : null);
			this.dropdownAiModel.onValueChanged.AddListener(new UnityAction<int>(this.bzi));
		}
		if (this.btnRefreshModels != null)
		{
			this.btnRefreshModels.onClick.AddListener(new UnityAction(this.bzj));
		}
		if (this.inputPromptTemplate != null)
		{
			this.inputPromptTemplate.lineType = TMP_InputField.LineType.MultiLineNewline;
			this.inputPromptTemplate.text = this.bzt(playerSaveData);
			this.inputPromptTemplate.onEndEdit.AddListener(new UnityAction<string>(this.bzp));
		}
		if (this.btnRestorePromptDefault != null)
		{
			this.btnRestorePromptDefault.onClick.AddListener(new UnityAction(this.bzq));
		}
		if (this.btnTalkNow != null)
		{
			this.btnTalkNow.onClick.AddListener(new UnityAction(this.bzr));
		}
		if (this.directPrivacyTip != null)
		{
			this.directPrivacyTip.SetActive(false);
		}
		this.bze((AiConnectionMode)((playerSaveData != null) ? playerSaveData.aiConnectionMode : 0));
		this.bzw();
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x00033254 File Offset: 0x00031454
	private void dlz(bool a)
	{
		bq.hlk = false;
		bool flag = d.md(a);
		bool flag2 = d.mc();
		if (this.toggleAdminMode != null)
		{
			this.toggleAdminMode.SetIsOnWithoutNotify(flag2);
		}
		if (q.kmh && PlayerPrefs.GetInt(a.cik(), 0) == 1)
		{
			q.tq(true);
		}
		if (!ModalDialogManager.kri)
		{
			return;
		}
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.cil(), null);
		string text;
		string text2;
		if (!flag)
		{
			text = dn.byp(table, a.cim(), a.cin());
			text2 = dn.byp(table, a.cio(), a.cip());
		}
		else if (flag2)
		{
			text = dn.byp(table, a.ciq(), a.cir());
			text2 = dn.byp(table, a.cis(), a.cit());
		}
		else
		{
			text = dn.byp(table, a.ciu(), a.civ());
			text2 = dn.byp(table, a.ciw(), a.cix());
		}
		ModalDialogManager.icb.ShowMessage(text, text2, null);
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x00027655 File Offset: 0x00025855
	public void oph(float a)
	{
		AudioManager.klw.qf(a, true);
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x0003334C File Offset: 0x0003154C
	private void nyr(List<string> a, string b)
	{
		dn.de de = new dn.de();
		de.hwn = b;
		if (this.dropdownAiModel == null)
		{
			return;
		}
		this.dropdownAiModel.ClearOptions();
		if (a == null || a.Count == 0)
		{
			this.dropdownAiModel.RefreshShownValue();
			return;
		}
		this.dropdownAiModel.AddOptions(a);
		int num = 0;
		if (!string.IsNullOrEmpty(de.hwn))
		{
			int num2 = a.FindIndex(new Predicate<string>(de.btp));
			if (num2 >= 0)
			{
				num = num2;
			}
		}
		this.dropdownAiModel.SetValueWithoutNotify(num);
		this.dropdownAiModel.RefreshShownValue();
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x000333E2 File Offset: 0x000315E2
	public void ijw(bool a)
	{
		bq.hlk = false;
		bq.hlv = a;
		PlayerPrefs.SetInt(a.ciy(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x00033408 File Offset: 0x00031608
	private void cwc()
	{
		float @float = PlayerPrefs.GetFloat(a.ciz(), 7982f);
		this.sliderSound.value = @float;
		float float2 = PlayerPrefs.GetFloat(a.cja(), 6758f);
		this.sliderBMG.value = float2;
		float float3 = PlayerPrefs.GetFloat(a.cjb(), -1514f);
		this.sliderSFX.value = float3;
		float float4 = PlayerPrefs.GetFloat(a.cjc(), -7669f);
		this.sliderVoice.value = float4;
		this.hxs = true;
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x0003348C File Offset: 0x0003168C
	private void ilz()
	{
		McpDialogueServer instance = McpDialogueServer.Instance;
		if (instance == null || this.mcpStatusText == null)
		{
			return;
		}
		string text = string.Format(a.cjd(), instance.ActivePort);
		TMP_Text tmp_Text = this.mcpStatusText;
		string text2;
		switch (instance.CurrentState)
		{
		case McpDialogueServer.State.Stopped:
			text2 = dn.byy(a.cje(), a.cjf());
			break;
		case McpDialogueServer.State.Starting:
			text2 = dn.byy(a.cjg(), a.cjh());
			break;
		case McpDialogueServer.State.Running:
			text2 = string.Format(dn.byy(a.cji(), a.cjj()), text);
			break;
		case McpDialogueServer.State.PortFail:
			text2 = dn.byy(a.cjk(), a.cjl());
			break;
		default:
			text2 = string.Format(dn.byy(a.cjm(), a.cjn()), instance.LastError ?? a.cjo());
			break;
		}
		tmp_Text.text = text2;
		if (this.mcpConnectedCountText != null)
		{
			this.mcpConnectedCountText.text = string.Format(dn.byy(a.cjp(), a.cjq()), instance.ConnectedAiCount);
		}
		if (this.mcpQueueLengthText != null)
		{
			this.mcpQueueLengthText.text = string.Format(dn.byy(a.cjr(), a.cjs()), instance.QueueLength);
		}
		if (this.mcpRetryButton != null)
		{
			bool flag = instance.CurrentState == McpDialogueServer.State.PortFail || instance.CurrentState == McpDialogueServer.State.OtherError;
			this.mcpRetryButton.gameObject.SetActive(flag);
		}
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x00033618 File Offset: 0x00031818
	private void ij()
	{
		if (this.objGameCompatRoot != null)
		{
			this.objGameCompatRoot.SetActive(true);
		}
		if (this.btnOpenCustomGameList != null)
		{
			this.btnOpenCustomGameList.onClick.AddListener(new UnityAction(this.buy));
		}
		if (this.objAdminModeRoot != null)
		{
			this.objAdminModeRoot.SetActive(true);
		}
		if (this.toggleAdminMode != null)
		{
			this.toggleAdminMode.SetIsOnWithoutNotify(d.mc());
			this.toggleAdminMode.onValueChanged.AddListener(new UnityAction<bool>(this.bva));
		}
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x000336C0 File Offset: 0x000318C0
	private void ons(string a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		playerSaveData.directApiBaseUrl = (a ?? a.cjt()).Trim();
		ci.Save(null);
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x0002F2F1 File Offset: 0x0002D4F1
	public void bvx(float a)
	{
		AudioManager.klw.qk(a, true);
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x00033710 File Offset: 0x00031910
	public void bvm()
	{
		bq.hlk = false;
		int monitorCount = UniWindowController.GetMonitorCount();
		if (monitorCount <= 1)
		{
			return;
		}
		int num = (UniWindowController.current.monitorToFit + 1) % monitorCount;
		if (UniWindowController.current.monitorToFit != num)
		{
			UniWindowController.current.MoveToMonitor(num);
		}
		bx.bcc(num);
		this.bvn();
		PlayerPrefs.SetInt(a.bmf(), num);
		PlayerPrefs.Save();
		CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
		if (characterDragTarget != null)
		{
			characterDragTarget.bgy();
		}
		SettingPanel settingPanel = SettingPanel.kqq;
		if (settingPanel != null)
		{
			settingPanel.caw();
		}
		BgmPanelController bgmPanelController = ((cx.kpw != null) ? cx.kpw.bgmPanel : null);
		if (bgmPanelController != null)
		{
			bgmPanelController.bmt();
		}
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x000337BC File Offset: 0x000319BC
	private void euy(int a)
	{
		if (this.hyr)
		{
			return;
		}
		if (this.hyn == null || a < 0 || a >= this.hyn.Length)
		{
			return;
		}
		bq.hlk = false;
		int num = this.hyn[a];
		bq.hlo = num;
		this.sizeController.bds(num);
		PlayerPrefs.SetInt(a.cju(), num);
		PlayerPrefs.Save();
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x0003381C File Offset: 0x00031A1C
	private void kmk(int a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || this.dropdownAiModel == null)
		{
			return;
		}
		if (a < 0 || a >= this.dropdownAiModel.options.Count)
		{
			return;
		}
		bq.hlk = false;
		playerSaveData.directApiModel = this.dropdownAiModel.options[a].text;
		ci.Save(null);
		this.bzl(playerSaveData.directApiModel);
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x000338A4 File Offset: 0x00031AA4
	private void bvf()
	{
		if (this.sliderSound != null)
		{
			PlayerPrefs.SetFloat(a.sd(), this.sliderSound.value);
		}
		if (this.sliderBMG != null)
		{
			PlayerPrefs.SetFloat(a.se(), this.sliderBMG.value);
		}
		if (this.sliderSFX != null)
		{
			PlayerPrefs.SetFloat(a.sf(), this.sliderSFX.value);
		}
		if (this.sliderVoice != null)
		{
			PlayerPrefs.SetFloat(a.sg(), this.sliderVoice.value);
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x00033944 File Offset: 0x00031B44
	private string cad(int a)
	{
		string text;
		try
		{
			text = AiSecretStore.GetMaskedHint(a) ?? a.tk();
		}
		catch (Exception ex)
		{
			string text2 = a.cjv();
			Exception ex2 = ex;
			Debug.LogError(text2 + ((ex2 != null) ? ex2.ToString() : null));
			text = a.tk();
		}
		return text;
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x0003399C File Offset: 0x00031B9C
	private void bze(AiConnectionMode a)
	{
		this.hys = true;
		if (this.dropdownConnectionMode != null)
		{
			this.dropdownConnectionMode.SetValueWithoutNotify(dn.byz(a));
			this.dropdownConnectionMode.RefreshShownValue();
		}
		this.hys = false;
		bool flag = a == AiConnectionMode.Mcp;
		bool flag2 = a == AiConnectionMode.DirectApi;
		if (this.mcpStatus != null)
		{
			this.mcpStatus.SetActive(flag);
		}
		if (this.mcpOpenDocButton != null)
		{
			this.mcpOpenDocButton.gameObject.SetActive(flag);
		}
		if (this.mcpRetryButton != null)
		{
			this.mcpRetryButton.gameObject.SetActive(flag);
		}
		if (!flag && this.mcpFirstTimeTip != null)
		{
			this.mcpFirstTimeTip.SetActive(false);
		}
		if (this.directApiPanel != null)
		{
			this.directApiPanel.SetActive(flag2);
		}
		if (!flag2 && this.directPrivacyTip != null)
		{
			this.directPrivacyTip.SetActive(false);
		}
		if (this.inputCustomBaseUrl != null)
		{
			AiProviderConfig aiProviderConfig = AiProviderCatalog.For((this.dropdownAiProvider != null) ? this.dropdownAiProvider.value : 0);
			this.inputCustomBaseUrl.gameObject.SetActive(flag2 && aiProviderConfig.AllowsCustomBaseUrl);
		}
		if (this.mcpExtraToggleTargets != null)
		{
			for (int i = 0; i < this.mcpExtraToggleTargets.Length; i++)
			{
				if (this.mcpExtraToggleTargets[i] != null)
				{
					this.mcpExtraToggleTargets[i].SetActive(a > AiConnectionMode.None);
				}
			}
		}
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x00033B20 File Offset: 0x00031D20
	public void fcg()
	{
		bq.hlk = false;
		if (!SteamManager.krd)
		{
			Debug.LogError(a.cjw());
			return;
		}
		CSteamID steamID = SteamUser.GetSteamID();
		string text = string.Format(a.cjx(), steamID.m_SteamID);
		string text2 = a.cjy() + text;
		Application.OpenURL(text2);
		Debug.Log(a.cjz() + text2);
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x00033B84 File Offset: 0x00031D84
	private void cgj(string a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || string.IsNullOrEmpty(a))
		{
			return;
		}
		if (a == this.hyv && Time.unscaledTime - this.hyu < -8504f)
		{
			return;
		}
		if (this.hyw)
		{
			return;
		}
		string text = this.cab(playerSaveData.directApiProviderId);
		if (string.IsNullOrEmpty(text))
		{
			this.bzx(dn.byy(a.cka(), a.ckb()));
			return;
		}
		if (AiRequestRunner.Instance.IsChatBusy)
		{
			this.bzx(dn.byy(a.ckc(), a.ckd()));
			return;
		}
		int directApiProviderId = playerSaveData.directApiProviderId;
		AiProviderConfig aiProviderConfig = AiProviderCatalog.For((AiProviderId)directApiProviderId);
		string text2 = ((aiProviderConfig.AllowsCustomBaseUrl && !string.IsNullOrEmpty(playerSaveData.directApiBaseUrl)) ? playerSaveData.directApiBaseUrl : aiProviderConfig.DefaultBaseUrl);
		IAiChatAdapter aiChatAdapter = AiAdapterFactory.Create((AiProviderId)directApiProviderId);
		AiChatRequest aiChatRequest = new AiChatRequest(a, a.cke(), a.ckf(), 30, 115f);
		this.hyw = true;
		this.hyu = Time.unscaledTime;
		this.hyv = a;
		this.bzx(dn.byy(a.ckg(), a.ckh()));
		AiRequestRunner.Instance.SendChat(aiChatAdapter, aiProviderConfig, text2, text, aiChatRequest, 48, new Action<AiChatResult>(this.bzm));
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x00033CD0 File Offset: 0x00031ED0
	private void bjx()
	{
		if (this.dropdownConnectionMode == null)
		{
			return;
		}
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData != null)
		{
			this.bzz(playerSaveData.directApiProviderId);
		}
		this.dropdownConnectionMode.ClearOptions();
		List<string> list = new List<string>();
		foreach (AiConnectionMode aiConnectionMode in dn.hyt)
		{
			list.Add(dn.bza(aiConnectionMode));
		}
		this.dropdownConnectionMode.AddOptions(list);
		this.dropdownConnectionMode.SetValueWithoutNotify((playerSaveData != null) ? dn.byz((AiConnectionMode)Mathf.Clamp(playerSaveData.aiConnectionMode, 0, 2)) : 0);
		this.dropdownConnectionMode.RefreshShownValue();
		this.dropdownConnectionMode.onValueChanged.AddListener(new UnityAction<int>(this.bzc));
		if (this.dropdownAiProvider != null)
		{
			List<string> list2 = new List<string>();
			foreach (AiProviderConfig aiProviderConfig in AiProviderCatalog.All)
			{
				list2.Add(aiProviderConfig.DisplayName);
			}
			this.dropdownAiProvider.ClearOptions();
			this.dropdownAiProvider.AddOptions(list2);
			this.dropdownAiProvider.SetValueWithoutNotify((playerSaveData != null) ? Mathf.Clamp(playerSaveData.directApiProviderId, 0, list2.Count - 1) : 0);
			this.dropdownAiProvider.RefreshShownValue();
			this.dropdownAiProvider.onValueChanged.AddListener(new UnityAction<int>(this.bzf));
		}
		if (this.dropdownChattiness != null)
		{
			this.dropdownChattiness.ClearOptions();
			this.dropdownChattiness.AddOptions(new List<string>
			{
				dn.byy(a.cki(), a.ckj()),
				dn.byy(a.ckk(), a.ckl()),
				dn.byy(a.ckm(), a.ckn())
			});
			this.dropdownChattiness.SetValueWithoutNotify((playerSaveData != null) ? Mathf.Clamp(playerSaveData.directApiChattinessTier, 0, 2) : 1);
			this.dropdownChattiness.RefreshShownValue();
			this.dropdownChattiness.onValueChanged.AddListener(new UnityAction<int>(this.bzo));
		}
		if (this.inputApiKey != null)
		{
			this.inputApiKey.contentType = TMP_InputField.ContentType.Password;
			this.inputApiKey.text = a.cko();
			this.inputApiKey.onEndEdit.AddListener(new UnityAction<string>(this.bzg));
			this.caf();
		}
		if (this.inputCustomBaseUrl != null)
		{
			this.inputCustomBaseUrl.text = ((playerSaveData != null) ? playerSaveData.directApiBaseUrl : a.ckp());
			this.inputCustomBaseUrl.onEndEdit.AddListener(new UnityAction<string>(this.bzh));
		}
		if (this.dropdownAiModel != null)
		{
			List<string> list3 = new List<string>();
			if (playerSaveData != null && !string.IsNullOrEmpty(playerSaveData.directApiModel))
			{
				list3.Add(playerSaveData.directApiModel);
			}
			this.bzn(list3, (playerSaveData != null) ? playerSaveData.directApiModel : null);
			this.dropdownAiModel.onValueChanged.AddListener(new UnityAction<int>(this.bzi));
		}
		if (this.btnRefreshModels != null)
		{
			this.btnRefreshModels.onClick.AddListener(new UnityAction(this.bzj));
		}
		if (this.inputPromptTemplate != null)
		{
			this.inputPromptTemplate.lineType = TMP_InputField.LineType.MultiLineNewline;
			this.inputPromptTemplate.text = this.bzt(playerSaveData);
			this.inputPromptTemplate.onEndEdit.AddListener(new UnityAction<string>(this.bzp));
		}
		if (this.btnRestorePromptDefault != null)
		{
			this.btnRestorePromptDefault.onClick.AddListener(new UnityAction(this.bzq));
		}
		if (this.btnTalkNow != null)
		{
			this.btnTalkNow.onClick.AddListener(new UnityAction(this.bzr));
		}
		if (this.directPrivacyTip != null)
		{
			this.directPrivacyTip.SetActive(false);
		}
		this.bze((AiConnectionMode)((playerSaveData != null) ? playerSaveData.aiConnectionMode : 0));
		this.bzw();
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x00034108 File Offset: 0x00032308
	private void bzn(List<string> a, string b)
	{
		dn.de de = new dn.de();
		de.hwn = b;
		if (this.dropdownAiModel == null)
		{
			return;
		}
		this.dropdownAiModel.ClearOptions();
		if (a == null || a.Count == 0)
		{
			this.dropdownAiModel.RefreshShownValue();
			return;
		}
		this.dropdownAiModel.AddOptions(a);
		int num = 0;
		if (!string.IsNullOrEmpty(de.hwn))
		{
			int num2 = a.FindIndex(new Predicate<string>(de.btp));
			if (num2 >= 0)
			{
				num = num2;
			}
		}
		this.dropdownAiModel.SetValueWithoutNotify(num);
		this.dropdownAiModel.RefreshShownValue();
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x000341A0 File Offset: 0x000323A0
	public void bgs(BaseEventData a)
	{
		PlayerPrefs.SetFloat(a.ckq(), this.sliderVoice.value);
		PlayerPrefs.Save();
		bq.hlk = false;
		if (this.hxs && AudioManager.klw != null)
		{
			EventReference eventReference = bq.zy(new Func<VoiceProfile, EventReference>(dn.<>c.<>9.bth), this.soundPreviewVoice);
			if (!eventReference.IsNull)
			{
				AudioManager.klw.qw(eventReference, bx.hod.koe, -2991f);
			}
		}
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x00034234 File Offset: 0x00032434
	private void byd()
	{
		if (this.dropdownDirtiness == null)
		{
			return;
		}
		List<string> list = new List<string>
		{
			dn.bye(a.ckr(), a.cks()),
			dn.bye(a.ckt(), a.cku()),
			dn.bye(a.ckv(), a.ckw())
		};
		this.dropdownDirtiness.ClearOptions();
		this.dropdownDirtiness.AddOptions(list);
		this.dropdownDirtiness.SetValueWithoutNotify((int)bq.hmb);
		this.dropdownDirtiness.RefreshShownValue();
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x000342C8 File Offset: 0x000324C8
	private void efs(AiChatResult a)
	{
		this.hyw = false;
		if (a == null)
		{
			return;
		}
		if (a.Ok)
		{
			string text = dn.byy(a.ckx(), a.cky());
			this.bzx(text);
			DirectApiScheduler instance = DirectApiScheduler.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ShowModalMessage(a.ckz(), text);
			return;
		}
		else
		{
			this.bzx(dn.cag(a.Error));
			DirectApiScheduler instance2 = DirectApiScheduler.Instance;
			if (instance2 == null)
			{
				return;
			}
			instance2.ShowApiError(a.Error, a.RawDetail);
			return;
		}
	}

	// Token: 0x0600087C RID: 2172 RVA: 0x00034348 File Offset: 0x00032548
	private void iej(bool a)
	{
		bq.hlk = false;
		bool flag = d.md(a);
		bool flag2 = d.mc();
		if (this.toggleAdminMode != null)
		{
			this.toggleAdminMode.SetIsOnWithoutNotify(flag2);
		}
		if (q.kmh && PlayerPrefs.GetInt(a.cla(), 0) == 1)
		{
			q.tq(true);
		}
		if (!ModalDialogManager.kri)
		{
			return;
		}
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.clb(), null);
		string text;
		string text2;
		if (!flag)
		{
			text = dn.byp(table, a.clc(), a.cld());
			text2 = dn.byp(table, a.cle(), a.clf());
		}
		else if (flag2)
		{
			text = dn.byp(table, a.clg(), a.clh());
			text2 = dn.byp(table, a.cli(), a.clj());
		}
		else
		{
			text = dn.byp(table, a.clk(), a.cll());
			text2 = dn.byp(table, a.clm(), a.cln());
		}
		ModalDialogManager.icb.ShowMessage(text, text2, null);
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x00034440 File Offset: 0x00032640
	private void ltc(bool a)
	{
		bq.hlk = false;
		bool flag = d.md(a);
		bool flag2 = d.mc();
		if (this.toggleAdminMode != null)
		{
			this.toggleAdminMode.SetIsOnWithoutNotify(flag2);
		}
		if (q.kmh && PlayerPrefs.GetInt(a.clo(), 0) == 1)
		{
			q.tq(true);
		}
		if (!ModalDialogManager.kri)
		{
			return;
		}
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.clp(), null);
		string text;
		string text2;
		if (!flag)
		{
			text = dn.byp(table, a.clq(), a.clr());
			text2 = dn.byp(table, a.cls(), a.clt());
		}
		else if (flag2)
		{
			text = dn.byp(table, a.clu(), a.clv());
			text2 = dn.byp(table, a.clw(), a.clx());
		}
		else
		{
			text = dn.byp(table, a.cly(), a.clz());
			text2 = dn.byp(table, a.cma(), a.cmb());
		}
		ModalDialogManager.icb.ShowMessage(text, text2, null);
	}

	// Token: 0x0600087E RID: 2174 RVA: 0x00034535 File Offset: 0x00032735
	public void bxj(bool a)
	{
		bq.hlk = false;
		bq.hlx = a;
		PlayerPrefs.SetInt(a.blo(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x00034559 File Offset: 0x00032759
	public void fmz(bool a)
	{
		bq.hlk = false;
		if (a)
		{
			CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
			if (characterDragTarget != null)
			{
				characterDragTarget.bhb();
			}
		}
		bq.hlu = a;
		this.bwv(a);
		PlayerPrefs.SetInt(a.cmc(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x00034597 File Offset: 0x00032797
	private IEnumerator bwm()
	{
		AsyncOperationHandle<StringTable> tableAsync = LocalizationSettings.StringDatabase.GetTableAsync(a.rh(), null);
		yield return tableAsync;
		if (tableAsync.Status != AsyncOperationStatus.Succeeded)
		{
			yield break;
		}
		StringTable result = tableAsync.Result;
		bl bl = bl.kmv;
		if (bl == null)
		{
			yield break;
		}
		this.hyj = true;
		if (this.dropdownCharacterMode.captionText != null)
		{
			this.dropdownCharacterMode.captionText.richText = true;
		}
		if (this.dropdownCharacterMode.itemText != null)
		{
			this.dropdownCharacterMode.itemText.richText = true;
		}
		this.dropdownCharacterMode.ClearOptions();
		List<string> list = new List<string>();
		int num = this.kqp;
		StringTableEntry entry = result.GetEntry(a.bkw());
		string text = ((entry != null) ? entry.GetLocalizedString() : null);
		if (string.IsNullOrEmpty(text))
		{
			text = a.bkx();
		}
		for (int i = 0; i < bl.kmu; i++)
		{
			if (list.Count == num)
			{
				list.Add(text);
			}
			list.Add(this.bwn(i, result));
		}
		if (list.Count == num)
		{
			list.Add(text);
		}
		this.dropdownCharacterMode.AddOptions(list);
		this.dropdownCharacterMode.value = this.bwl();
		this.dropdownCharacterMode.RefreshShownValue();
		this.hyj = false;
		if (this.dropdownDisableHelper == null && this.dropdownCharacterMode != null)
		{
			this.dropdownDisableHelper = this.dropdownCharacterMode.GetComponent<cy>();
		}
		if (this.dropdownDisableHelper != null)
		{
			this.dropdownDisableHelper.brn();
			for (int j = 0; j < bl.kmu; j++)
			{
				if (this.bwe(j))
				{
					CatCharacterDefinition catCharacterDefinition = bl.xp(j);
					uint num2 = ((catCharacterDefinition != null) ? catCharacterDefinition.dlcAppId : 0U);
					this.dropdownDisableHelper.brm(this.bwj(j), num2);
				}
			}
		}
		yield break;
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x000345A8 File Offset: 0x000327A8
	private int bwk(int a)
	{
		int num = this.kqp;
		if (a == num)
		{
			return -1;
		}
		if (a >= num)
		{
			return a - 1;
		}
		return a;
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x000345CC File Offset: 0x000327CC
	private void nys(int a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		playerSaveData.directApiChattinessTier = Mathf.Clamp(a, 0, 2);
		ci.Save(null);
	}

	// Token: 0x06000883 RID: 2179 RVA: 0x0002E120 File Offset: 0x0002C320
	private string ida(PlayerSaveData a)
	{
		if (a != null && a.directApiTemplateCustomized && !string.IsNullOrWhiteSpace(a.directApiPromptTemplate))
		{
			return a.directApiPromptTemplate;
		}
		return AiPromptComposer.GetLocalizedDefaultTemplate();
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x00034612 File Offset: 0x00032812
	public void byt()
	{
		bq.hlk = false;
		Application.OpenURL(a.cmd());
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x00034624 File Offset: 0x00032824
	private void eco(int a)
	{
		if (a < 0 || a >= dn.FPSOptions.Length)
		{
			return;
		}
		int num = dn.FPSOptions[a];
		dn.bxu(num);
		PlayerPrefs.SetInt(a.cme(), num);
		PlayerPrefs.Save();
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x00030F89 File Offset: 0x0002F189
	public void qz()
	{
		if (this.dropdownCharacterMode == null)
		{
			return;
		}
		base.StartCoroutine(this.bwm());
	}

	// Token: 0x06000887 RID: 2183 RVA: 0x00034660 File Offset: 0x00032860
	private void oco(int a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		playerSaveData.directApiChattinessTier = Mathf.Clamp(a, 0, 2);
		ci.Save(null);
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x000346A8 File Offset: 0x000328A8
	public void gln()
	{
		bool flag = SettingPanel.kqs;
		if (this.dropdownCharacterMode != null)
		{
			this.dropdownCharacterMode.interactable = flag;
		}
	}

	// Token: 0x06000889 RID: 2185 RVA: 0x000346D8 File Offset: 0x000328D8
	private void kow(bool a)
	{
		if (!ModalDialogManager.kri)
		{
			return;
		}
		if (ModalDialogManager.icb.krh)
		{
			Debug.LogWarning(string.Format(a.cmf(), a));
			return;
		}
		string text = a.cmg();
		string text2 = (a ? a.cmi() : a.cmh());
		try
		{
			if (LocalizationSettings.InitializationOperation.IsDone)
			{
				StringTable table = LocalizationSettings.StringDatabase.GetTable(a.cmj(), null);
				if (table != null)
				{
					StringTableEntry entry = table.GetEntry(a.cmk());
					string text3 = ((entry != null) ? entry.GetLocalizedString() : null);
					if (!string.IsNullOrEmpty(text3))
					{
						text = text3;
					}
					string text4 = (a ? a.cmm() : a.cml());
					StringTableEntry entry2 = table.GetEntry(text4);
					string text5 = ((entry2 != null) ? entry2.GetLocalizedString() : null);
					if (!string.IsNullOrEmpty(text5))
					{
						text2 = text5;
					}
				}
			}
		}
		catch
		{
		}
		ModalDialogManager.icb.ShowMessage(text, text2, null);
	}

	// Token: 0x0600088A RID: 2186 RVA: 0x000347D0 File Offset: 0x000329D0
	public void cmk()
	{
		bq.hlk = false;
		Application.OpenURL(a.cmn());
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x000347E2 File Offset: 0x000329E2
	public void nfy(bool a)
	{
		bq.hlk = false;
		bq.hmc = a;
		PlayerPrefs.SetInt(a.cmo(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x00034808 File Offset: 0x00032A08
	private void bzd(AiConnectionMode a)
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		bq.hlk = false;
		McpDialogueServer instance = McpDialogueServer.Instance;
		if (instance != null)
		{
			instance.StopServer();
		}
		DirectApiScheduler instance2 = DirectApiScheduler.Instance;
		if (instance2 != null)
		{
			instance2.Disable();
		}
		playerSaveData.aiConnectionMode = (int)a;
		playerSaveData.aiConnectionEnabled = a == AiConnectionMode.Mcp;
		bool flag = false;
		bool flag2 = false;
		if (a == AiConnectionMode.Mcp && !playerSaveData.firstTimeMcpToggleDone)
		{
			playerSaveData.firstTimeMcpToggleDone = true;
			flag = true;
		}
		if (a == AiConnectionMode.DirectApi && !playerSaveData.directApiFirstTimeTipDone)
		{
			playerSaveData.directApiFirstTimeTipDone = true;
			flag2 = true;
		}
		ci.Save(null);
		if (a == AiConnectionMode.Mcp)
		{
			McpDialogueServer instance3 = McpDialogueServer.Instance;
			if (instance3 != null)
			{
				instance3.StartServer();
			}
		}
		else if (a == AiConnectionMode.DirectApi)
		{
			DirectApiScheduler.EnsureInstance().Enable();
		}
		if (flag && this.mcpFirstTimeTip != null)
		{
			this.mcpFirstTimeTip.SetActive(true);
		}
		if (flag2 && this.directPrivacyTip != null)
		{
			this.directPrivacyTip.SetActive(true);
		}
		this.bze(a);
		this.bzw();
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x0003490C File Offset: 0x00032B0C
	private void exg()
	{
		PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
		if (playerSaveData == null || this.inputPromptTemplate == null)
		{
			return;
		}
		if (!playerSaveData.directApiTemplateCustomized)
		{
			this.inputPromptTemplate.text = AiPromptComposer.GetLocalizedDefaultTemplate();
		}
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x00034960 File Offset: 0x00032B60
	private void UpdateMcpStatus()
	{
		McpDialogueServer instance = McpDialogueServer.Instance;
		if (instance == null || this.mcpStatusText == null)
		{
			return;
		}
		string text = string.Format(a.cmp(), instance.ActivePort);
		TMP_Text tmp_Text = this.mcpStatusText;
		string text2;
		switch (instance.CurrentState)
		{
		case McpDialogueServer.State.Stopped:
			text2 = dn.byy(a.cmq(), a.cmr());
			break;
		case McpDialogueServer.State.Starting:
			text2 = dn.byy(a.cms(), a.cmt());
			break;
		case McpDialogueServer.State.Running:
			text2 = string.Format(dn.byy(a.cmu(), a.cmv()), text);
			break;
		case McpDialogueServer.State.PortFail:
			text2 = dn.byy(a.cmw(), a.cmx());
			break;
		default:
			text2 = string.Format(dn.byy(a.cmy(), a.cmz()), instance.LastError ?? a.cna());
			break;
		}
		tmp_Text.text = text2;
		if (this.mcpConnectedCountText != null)
		{
			this.mcpConnectedCountText.text = string.Format(dn.byy(a.cnb(), a.cnc()), instance.ConnectedAiCount);
		}
		if (this.mcpQueueLengthText != null)
		{
			this.mcpQueueLengthText.text = string.Format(dn.byy(a.cnd(), a.cne()), instance.QueueLength);
		}
		if (this.mcpRetryButton != null)
		{
			bool flag = instance.CurrentState == McpDialogueServer.State.PortFail || instance.CurrentState == McpDialogueServer.State.OtherError;
			this.mcpRetryButton.gameObject.SetActive(flag);
		}
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x00034AEC File Offset: 0x00032CEC
	private void krk()
	{
		if (this.toggleDiscordRichPresence == null)
		{
			return;
		}
		bool flag = PlayerPrefs.GetInt(a.cnf(), 1) == 1;
		this.toggleDiscordRichPresence.SetIsOnWithoutNotify(flag);
	}

	// Token: 0x06000890 RID: 2192 RVA: 0x00034B24 File Offset: 0x00032D24
	private string bwr(VoiceProfile a, int b, StringTable c)
	{
		if (a == null)
		{
			return string.Format(a.cng(), b);
		}
		if (!string.IsNullOrEmpty(a.displayNameKey) && c != null)
		{
			StringTableEntry entry = c.GetEntry(a.displayNameKey);
			if (entry != null)
			{
				string localizedString = entry.GetLocalizedString();
				if (!string.IsNullOrEmpty(localizedString))
				{
					return localizedString;
				}
			}
		}
		if (!string.IsNullOrEmpty(a.displayName))
		{
			return a.displayName;
		}
		if (!string.IsNullOrEmpty(a.id))
		{
			return a.id;
		}
		return string.Format(a.cng(), b);
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x00034BB4 File Offset: 0x00032DB4
	private bool kmn(int a)
	{
		bool flag;
		try
		{
			flag = AiSecretStore.MigrateLegacyKey(a);
		}
		catch (Exception ex)
		{
			string text = a.cnh();
			Exception ex2 = ex;
			Debug.LogError(text + ((ex2 != null) ? ex2.ToString() : null));
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x00034BFC File Offset: 0x00032DFC
	private bool mdo(int a, string b)
	{
		bool flag;
		try
		{
			flag = AiSecretStore.StoreKey(a, b);
		}
		catch (Exception ex)
		{
			string text = a.cni();
			Exception ex2 = ex;
			Debug.LogError(text + ((ex2 != null) ? ex2.ToString() : null));
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x00034C48 File Offset: 0x00032E48
	private void byx()
	{
		bq.hlk = false;
		McpDialogueServer instance = McpDialogueServer.Instance;
		if (instance == null)
		{
			return;
		}
		instance.StopServer();
		instance.StartServer();
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x00034C78 File Offset: 0x00032E78
	private void ofy(int a)
	{
		if (this.hyr)
		{
			return;
		}
		if (this.hyo == null || a < 0 || a >= this.hyo.Length)
		{
			return;
		}
		bq.hlk = false;
		int num = this.hyo[a];
		bq.hlp = num;
		this.sizeUIController.bds(num);
		PlayerPrefs.SetInt(a.cnj(), num);
		PlayerPrefs.Save();
		Canvas.ForceUpdateCanvases();
		if (SettingPanel.kqq != null)
		{
			SettingPanel.kqq.caz();
		}
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x00034CF4 File Offset: 0x00032EF4
	private void fcm()
	{
		if (this.dropdownSize != null)
		{
			this.dropdownSize.onValueChanged.AddListener(new UnityAction<int>(this.bxp));
		}
		this.sliderSound.onValueChanged.AddListener(new UnityAction<float>(this.bvs));
		this.sliderBMG.onValueChanged.AddListener(new UnityAction<float>(this.bvt));
		this.sliderSFX.onValueChanged.AddListener(new UnityAction<float>(this.bvw));
		this.sliderVoice.onValueChanged.AddListener(new UnityAction<float>(this.bvx));
		this.bwa(this.sliderSound.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvu));
		this.bwa(this.sliderBMG.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvv));
		this.bwa(this.sliderSFX.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvy));
		this.bwa(this.sliderVoice.gameObject, EventTriggerType.PointerUp, new UnityAction<BaseEventData>(this.bvz));
		if (this.muteButtonSound != null)
		{
			this.muteButtonSound.hzh += this.bvf;
		}
		if (this.muteButtonBGM != null)
		{
			this.muteButtonBGM.hzh += this.bvf;
		}
		if (this.muteButtonSFX != null)
		{
			this.muteButtonSFX.hzh += this.bvf;
		}
		if (this.muteButtonVoice != null)
		{
			this.muteButtonVoice.hzh += this.bvf;
		}
		dn.bwb(this.sliderSound);
		dn.bwb(this.sliderBMG);
		dn.bwb(this.sliderSFX);
		dn.bwb(this.sliderVoice);
		if (this.dropdownUISize != null)
		{
			this.dropdownUISize.onValueChanged.AddListener(new UnityAction<int>(this.bxq));
		}
		if (this.dropdownToolbarSize != null)
		{
			this.dropdownToolbarSize.onValueChanged.AddListener(new UnityAction<int>(this.bxr));
		}
		if (this.dropdownSpeechBubbleSize != null)
		{
			this.dropdownSpeechBubbleSize.onValueChanged.AddListener(new UnityAction<int>(this.bxs));
		}
		this.btnCloseGame.onClick.AddListener(new UnityAction(this.byj));
		this.btnSteamInventory.onClick.AddListener(new UnityAction(this.byr));
		this.btnDiscord.onClick.AddListener(new UnityAction(this.bys));
		if (this.btnWorkshop != null)
		{
			this.btnWorkshop.onClick.AddListener(new UnityAction(this.byt));
		}
		if (this.btnTroubleshooting != null)
		{
			this.btnTroubleshooting.onClick.AddListener(new UnityAction(this.byu));
		}
		this.toggleTop.onValueChanged.AddListener(new UnityAction<bool>(this.byv));
		this.toggleFlip.onValueChanged.AddListener(new UnityAction<bool>(this.byi));
		if (this.toggleDropAnimation != null)
		{
			this.toggleDropAnimation.onValueChanged.AddListener(new UnityAction<bool>(this.bxg));
		}
		if (this.toggleDisableMassagerIdle != null)
		{
			this.toggleDisableMassagerIdle.onValueChanged.AddListener(new UnityAction<bool>(this.bxi));
		}
		if (this.dropdownLanguage != null)
		{
			this.dropdownLanguage.onValueChanged.AddListener(new UnityAction<int>(this.bvj));
		}
		this.btnMonitor.onClick.AddListener(new UnityAction(this.bvm));
		this.toggleTaskbar.onValueChanged.AddListener(new UnityAction<bool>(this.bvo));
		this.toggleTaskbarSnap.onValueChanged.AddListener(new UnityAction<bool>(this.bvp));
		this.toggleLockPosition.onValueChanged.AddListener(new UnityAction<bool>(this.bwu));
		if (this.btnResetCharacterPosition != null)
		{
			this.btnResetCharacterPosition.onClick.AddListener(new UnityAction(this.bwx));
		}
		if (this.btnRepairWindow != null)
		{
			this.btnRepairWindow.onClick.AddListener(new UnityAction(this.bwy));
			if (!ModalDialogManager.kri)
			{
				this.btnRepairWindow.interactable = false;
				this.hym = true;
				Debug.LogWarning(a.cnk());
			}
		}
		if (this.btnDeleteAllItems != null)
		{
			this.btnDeleteAllItems.onClick.AddListener(new UnityAction(this.byq));
			if (!ModalDialogManager.kri)
			{
				this.btnDeleteAllItems.interactable = false;
				Debug.LogWarning(a.cnl());
			}
		}
		this.toggleAutoHideDownUI.onValueChanged.AddListener(new UnityAction<bool>(this.bxb));
		if (this.toggleHotkey != null)
		{
			this.toggleHotkey.onValueChanged.AddListener(new UnityAction<bool>(this.bxe));
		}
		if (this.toggleRightClickQuickMenu != null)
		{
			this.toggleRightClickQuickMenu.onValueChanged.AddListener(new UnityAction<bool>(this.bxj));
		}
		if (this.inputSteamStatus != null)
		{
			this.inputSteamStatus.onEndEdit.AddListener(new UnityAction<string>(this.bwd));
		}
		if (this.dropdownCharacterMode != null)
		{
			this.dropdownCharacterMode.onValueChanged.AddListener(new UnityAction<int>(this.bwo));
		}
		if (this.dropdownVoice != null)
		{
			this.dropdownVoice.onValueChanged.AddListener(new UnityAction<int>(this.bws));
			base.StartCoroutine(this.bwp());
		}
		if (this.dropdownFPS != null)
		{
			this.dropdownFPS.onValueChanged.AddListener(new UnityAction<int>(this.bxx));
		}
		if (this.dropdownDropNotification != null)
		{
			this.dropdownDropNotification.onValueChanged.AddListener(new UnityAction<int>(this.byb));
		}
		if (this.dropdownDirtiness != null)
		{
			this.dropdownDirtiness.onValueChanged.AddListener(new UnityAction<int>(this.byf));
		}
		if (this.toggleAutoStart != null)
		{
			this.toggleAutoStart.onValueChanged.AddListener(new UnityAction<bool>(this.byh));
		}
		if (this.toggleDiscordRichPresence != null)
		{
			this.toggleDiscordRichPresence.onValueChanged.AddListener(new UnityAction<bool>(this.bxd));
		}
		if (this.btnCheckNow != null)
		{
			this.btnCheckNow.onClick.AddListener(new UnityAction(this.byk));
		}
		if (this.btnRestartUpdate != null)
		{
			this.btnRestartUpdate.onClick.AddListener(new UnityAction(this.bym));
			this.btnRestartUpdate.interactable = true;
		}
		if (this.objUpdateStatus != null)
		{
			this.objUpdateStatus.SetActive(false);
		}
		if (this.objUpdateBadge != null)
		{
			this.objUpdateBadge.un(false);
		}
		this.bux();
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x00035448 File Offset: 0x00033648
	private static string nl(string a, string b)
	{
		string text;
		try
		{
			if (!LocalizationSettings.InitializationOperation.IsDone)
			{
				text = b;
			}
			else
			{
				StringTable table = LocalizationSettings.StringDatabase.GetTable(a.cnm(), null);
				StringTableEntry stringTableEntry = ((table != null) ? table.GetEntry(a) : null);
				string text2 = ((stringTableEntry != null) ? stringTableEntry.GetLocalizedString() : null);
				text = (string.IsNullOrEmpty(text2) ? b : text2);
			}
		}
		catch
		{
			text = b;
		}
		return text;
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x000354BC File Offset: 0x000336BC
	public void cok(bool a)
	{
		bq.hlk = false;
		bq.hlw = a;
		if (this.hotkeyHintPanel != null)
		{
			this.hotkeyHintPanel.SetActive(a);
		}
		this.bxk();
		PlayerPrefs.SetInt(a.cnn(), a ? 1 : 0);
		PlayerPrefs.Save();
		if (a)
		{
			WinGlobalHotkey.ctp();
			return;
		}
		WinGlobalHotkey.ctq();
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x0003551C File Offset: 0x0003371C
	private bool gim(int a, string b)
	{
		bool flag;
		try
		{
			flag = AiSecretStore.StoreKey(a, b);
		}
		catch (Exception ex)
		{
			string text = a.cno();
			Exception ex2 = ex;
			Debug.LogError(text + ((ex2 != null) ? ex2.ToString() : null));
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x00035568 File Offset: 0x00033768
	private void bek(AiModelList a)
	{
		if (a == null)
		{
			return;
		}
		if (!a.Ok)
		{
			this.bzx(dn.cag(a.Error));
			DirectApiScheduler instance = DirectApiScheduler.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ShowApiError(a.Error, a.RawDetail);
			return;
		}
		else
		{
			PlayerSaveData playerSaveData = ((bq.hlf != null) ? bq.hlf.playerSaveData : null);
			string text = ((playerSaveData != null) ? playerSaveData.directApiModel : null);
			List<string> list = new List<string>(a.Models);
			this.bzn(list, (!string.IsNullOrEmpty(text)) ? text : ((list.Count > 0) ? list[0] : null));
			if (playerSaveData != null && string.IsNullOrEmpty(playerSaveData.directApiModel) && list.Count > 0)
			{
				playerSaveData.directApiModel = list[0];
				ci.Save(null);
			}
			string text2 = string.Format(dn.byy(a.cnp(), a.cnq()), list.Count);
			this.bzx(text2);
			DirectApiScheduler instance2 = DirectApiScheduler.Instance;
			if (instance2 == null)
			{
				return;
			}
			instance2.ShowModalMessage(a.cnr(), text2);
			return;
		}
	}

	// Token: 0x0600089A RID: 2202 RVA: 0x00035675 File Offset: 0x00033875
	public void bwu(bool a)
	{
		bq.hlk = false;
		if (a)
		{
			CharacterDragTarget characterDragTarget = CharacterDragTarget.kot;
			if (characterDragTarget != null)
			{
				characterDragTarget.bhb();
			}
		}
		bq.hlu = a;
		this.bwv(a);
		PlayerPrefs.SetInt(a.blm(), a ? 1 : 0);
		PlayerPrefs.Save();
	}

	// Token: 0x0600089B RID: 2203 RVA: 0x000356B4 File Offset: 0x000338B4
	private int lhy(int a)
	{
		int num = this.kqp;
		if (a == num)
		{
			return -1;
		}
		if (a >= num)
		{
			return a - 1;
		}
		return a;
	}

	// Token: 0x0600089C RID: 2204 RVA: 0x000356D7 File Offset: 0x000338D7
	public void byu()
	{
		bq.hlk = false;
		Application.OpenURL(a.cns());
	}

	// Token: 0x0600089D RID: 2205 RVA: 0x000356EC File Offset: 0x000338EC
	private void kdl()
	{
		if (this.inputApiKey == null)
		{
			return;
		}
		TMP_Text tmp_Text = this.inputApiKey.placeholder as TMP_Text;
		if (tmp_Text == null)
		{
			return;
		}
		string text = this.cad(this.cae());
		tmp_Text.text = ((text.Length > 0) ? string.Format(dn.byy(a.cnv(), a.cnw()), text) : dn.byy(a.cnt(), a.cnu()));
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x00035768 File Offset: 0x00033968
	private void dr()
	{
		if (this.txtMonitor == null)
		{
			return;
		}
		int monitorToFit = UniWindowController.current.monitorToFit;
		StringTable table = LocalizationSettings.StringDatabase.GetTable(a.cnx(), null);
		string text;
		if (table == null)
		{
			text = null;
		}
		else
		{
			StringTableEntry entry = table.GetEntry(a.cny());
			text = ((entry != null) ? entry.GetLocalizedString() : null);
		}
		string text2 = text ?? a.cnz();
		this.txtMonitor.text = string.Format(a.coa(), text2, monitorToFit + 1);
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x000357EC File Offset: 0x000339EC
	private void bxz()
	{
		if (this.dropdownDropNotification == null)
		{
			return;
		}
		List<string> list = new List<string>
		{
			dn.bya(a.cob(), a.coc()),
			dn.bya(a.cod(), a.coe()),
			dn.bya(a.cof(), a.cog())
		};
		this.dropdownDropNotification.ClearOptions();
		this.dropdownDropNotification.AddOptions(list);
		this.dropdownDropNotification.SetValueWithoutNotify((int)bq.hma);
		this.dropdownDropNotification.RefreshShownValue();
	}

	// Token: 0x040006A9 RID: 1705
	public TMP_Dropdown dropdownLanguage;

	// Token: 0x040006AA RID: 1706
	public Slider sliderBMG;

	// Token: 0x040006AB RID: 1707
	public Slider sliderSound;

	// Token: 0x040006AC RID: 1708
	public Slider sliderSFX;

	// Token: 0x040006AD RID: 1709
	public Slider sliderVoice;

	// Token: 0x040006AE RID: 1710
	public TMP_Dropdown dropdownVoice;

	// Token: 0x040006AF RID: 1711
	public EventReference soundPreviewUI;

	// Token: 0x040006B0 RID: 1712
	public EventReference soundPreviewSFX;

	// Token: 0x040006B1 RID: 1713
	public EventReference soundPreviewVoice;

	// Token: 0x040006B2 RID: 1714
	public VolumeMuteButton muteButtonBGM;

	// Token: 0x040006B3 RID: 1715
	public VolumeMuteButton muteButtonSound;

	// Token: 0x040006B4 RID: 1716
	public VolumeMuteButton muteButtonSFX;

	// Token: 0x040006B5 RID: 1717
	public VolumeMuteButton muteButtonVoice;

	// Token: 0x040006B6 RID: 1718
	public TMP_Dropdown dropdownSize;

	// Token: 0x040006B7 RID: 1719
	public bz sizeController;

	// Token: 0x040006B8 RID: 1720
	public Toggle toggleDropAnimation;

	// Token: 0x040006B9 RID: 1721
	public Toggle toggleDisableMassagerIdle;

	// Token: 0x040006BA RID: 1722
	public Toggle toggleFlip;

	// Token: 0x040006BB RID: 1723
	public Transform[] flipTarget;

	// Token: 0x040006BC RID: 1724
	public Transform[] flipExcludedTargets;

	// Token: 0x040006BD RID: 1725
	public TMP_Dropdown dropdownUISize;

	// Token: 0x040006BE RID: 1726
	public bz sizeUIController;

	// Token: 0x040006BF RID: 1727
	public TMP_Dropdown dropdownToolbarSize;

	// Token: 0x040006C0 RID: 1728
	public bz sizeToolbarController;

	// Token: 0x040006C1 RID: 1729
	public Toggle toggleTop;

	// Token: 0x040006C2 RID: 1730
	public Button btnMonitor;

	// Token: 0x040006C3 RID: 1731
	public TextMeshProUGUI txtMonitor;

	// Token: 0x040006C4 RID: 1732
	public Toggle toggleTaskbar;

	// Token: 0x040006C5 RID: 1733
	public Toggle toggleTaskbarSnap;

	// Token: 0x040006C6 RID: 1734
	public WindowDragHandler windowDragHandler;

	// Token: 0x040006C7 RID: 1735
	public Toggle toggleLockPosition;

	// Token: 0x040006C8 RID: 1736
	public UniWindowController windowController;

	// Token: 0x040006C9 RID: 1737
	public RectTransform dragImageRect;

	// Token: 0x040006CA RID: 1738
	public cx downUIController;

	// Token: 0x040006CB RID: 1739
	public Button btnResetCharacterPosition;

	// Token: 0x040006CC RID: 1740
	public Button btnRepairWindow;

	// Token: 0x040006CD RID: 1741
	public Toggle toggleAutoHideDownUI;

	// Token: 0x040006CE RID: 1742
	public Toggle toggleHotkey;

	// Token: 0x040006CF RID: 1743
	public GameObject hotkeyHintPanel;

	// Token: 0x040006D0 RID: 1744
	public GameObject hotkeyHintWindows;

	// Token: 0x040006D1 RID: 1745
	public GameObject hotkeyHintMac;

	// Token: 0x040006D2 RID: 1746
	public Toggle toggleRightClickQuickMenu;

	// Token: 0x040006D3 RID: 1747
	public TMP_InputField inputSteamStatus;

	// Token: 0x040006D4 RID: 1748
	public Toggle toggleDiscordRichPresence;

	// Token: 0x040006D5 RID: 1749
	public Button btnSteamInventory;

	// Token: 0x040006D6 RID: 1750
	public Button btnDiscord;

	// Token: 0x040006D7 RID: 1751
	public Button btnWorkshop;

	// Token: 0x040006D8 RID: 1752
	public Button btnCloseGame;

	// Token: 0x040006D9 RID: 1753
	public Button btnTroubleshooting;

	// Token: 0x040006DA RID: 1754
	public Button btnDeleteAllItems;

	// Token: 0x040006DB RID: 1755
	public TMP_Dropdown dropdownCharacterMode;

	// Token: 0x040006DC RID: 1756
	public cy dropdownDisableHelper;

	// Token: 0x040006DD RID: 1757
	public TMP_Dropdown dropdownFPS;

	// Token: 0x040006DE RID: 1758
	public TMP_Dropdown dropdownDropNotification;

	// Token: 0x040006DF RID: 1759
	public TMP_Dropdown dropdownDirtiness;

	// Token: 0x040006E0 RID: 1760
	public Toggle toggleAutoStart;

	// Token: 0x040006E1 RID: 1761
	public TextMeshProUGUI txtVersion;

	// Token: 0x040006E2 RID: 1762
	public GameObject objUpdateStatus;

	// Token: 0x040006E3 RID: 1763
	public TextMeshProUGUI txtUpdateStatus;

	// Token: 0x040006E4 RID: 1764
	public Button btnCheckNow;

	// Token: 0x040006E5 RID: 1765
	public Button btnRestartUpdate;

	// Token: 0x040006E6 RID: 1766
	public t objUpdateBadge;

	// Token: 0x040006E7 RID: 1767
	public GameObject objGameCompatRoot;

	// Token: 0x040006E8 RID: 1768
	public Button btnOpenCustomGameList;

	// Token: 0x040006E9 RID: 1769
	public GameObject objAdminModeRoot;

	// Token: 0x040006EA RID: 1770
	public Toggle toggleAdminMode;

	// Token: 0x040006EB RID: 1771
	public GameObject mcpStatus;

	// Token: 0x040006EC RID: 1772
	public TMP_Text mcpStatusText;

	// Token: 0x040006ED RID: 1773
	public TMP_Text mcpConnectedCountText;

	// Token: 0x040006EE RID: 1774
	public TMP_Text mcpQueueLengthText;

	// Token: 0x040006EF RID: 1775
	public Button mcpOpenDocButton;

	// Token: 0x040006F0 RID: 1776
	public Button mcpRetryButton;

	// Token: 0x040006F1 RID: 1777
	public GameObject mcpFirstTimeTip;

	// Token: 0x040006F2 RID: 1778
	public string mcpDocUrl = a.bmo();

	// Token: 0x040006F3 RID: 1779
	public TMP_Dropdown dropdownSpeechBubbleSize;

	// Token: 0x040006F4 RID: 1780
	public bz sizeSpeechBubbleController;

	// Token: 0x040006F5 RID: 1781
	public GameObject[] mcpExtraToggleTargets;

	// Token: 0x040006F6 RID: 1782
	public SpeechBubbleController speechBubbleController;

	// Token: 0x040006F7 RID: 1783
	public TMP_Dropdown dropdownConnectionMode;

	// Token: 0x040006F8 RID: 1784
	public GameObject directApiPanel;

	// Token: 0x040006F9 RID: 1785
	public TMP_Dropdown dropdownAiProvider;

	// Token: 0x040006FA RID: 1786
	public TMP_InputField inputApiKey;

	// Token: 0x040006FB RID: 1787
	public TMP_InputField inputCustomBaseUrl;

	// Token: 0x040006FC RID: 1788
	public TMP_Dropdown dropdownAiModel;

	// Token: 0x040006FD RID: 1789
	public Button btnRefreshModels;

	// Token: 0x040006FE RID: 1790
	public TMP_InputField inputPromptTemplate;

	// Token: 0x040006FF RID: 1791
	public Button btnRestorePromptDefault;

	// Token: 0x04000700 RID: 1792
	public TMP_Dropdown dropdownChattiness;

	// Token: 0x04000701 RID: 1793
	public Button btnTalkNow;

	// Token: 0x04000702 RID: 1794
	public TMP_Text directStatusText;

	// Token: 0x04000703 RID: 1795
	public GameObject directPrivacyTip;

	// Token: 0x04000704 RID: 1796
	private bb[] hxr;

	// Token: 0x04000705 RID: 1797
	private bool hxs;

	// Token: 0x04000706 RID: 1798
	private Coroutine hxt;

	// Token: 0x04000707 RID: 1799
	private const int hxu = -20;

	// Token: 0x04000708 RID: 1800
	private const int hxv = 128;

	// Token: 0x04000709 RID: 1801
	private const int hxw = 262144;

	// Token: 0x0400070A RID: 1802
	private const string hxx = "Settings_TargetMonitor";

	// Token: 0x0400070B RID: 1803
	private const string hxy = "Settings_ShowInTaskbar";

	// Token: 0x0400070C RID: 1804
	private const string hxz = "Settings_TaskbarSnap";

	// Token: 0x0400070D RID: 1805
	public const string PREF_KEY_SOUND_VOLUME = "Settings_SoundVolume";

	// Token: 0x0400070E RID: 1806
	public const string PREF_KEY_BGM_VOLUME = "Settings_BGMVolume";

	// Token: 0x0400070F RID: 1807
	public const string PREF_KEY_SFX_VOLUME = "Settings_SFXVolume";

	// Token: 0x04000710 RID: 1808
	public const string PREF_KEY_VOICE_VOLUME = "Settings_VoiceVolume";

	// Token: 0x04000711 RID: 1809
	private const string hya = "Settings_LastVolume_Ambient";

	// Token: 0x04000712 RID: 1810
	public const string PREF_KEY_LOCK_POSITION = "Settings_LockPosition";

	// Token: 0x04000713 RID: 1811
	public const string PREF_KEY_AUTOHIDE_DOWN_UI = "Settings_AutoHideDownUI";

	// Token: 0x04000714 RID: 1812
	public const string PREF_KEY_HOTKEY_ENABLED = "Settings_HotkeyEnabled";

	// Token: 0x04000715 RID: 1813
	public const string PREF_KEY_RIGHT_CLICK_QUICK_MENU = "Settings_RightClickQuickMenu";

	// Token: 0x04000716 RID: 1814
	public const string PREF_KEY_SIZE_INDEX = "Settings_SizeIndex";

	// Token: 0x04000717 RID: 1815
	public const string PREF_KEY_UI_SIZE_INDEX = "Settings_UISizeIndex";

	// Token: 0x04000718 RID: 1816
	public const string PREF_KEY_TOOLBAR_SIZE_INDEX = "Settings_ToolbarSizeIndex";

	// Token: 0x04000719 RID: 1817
	public const string PREF_KEY_SPEECH_BUBBLE_SIZE_INDEX = "Settings_SpeechBubbleSizeIndex";

	// Token: 0x0400071A RID: 1818
	public const string PREF_KEY_ALWAYS_ON_TOP = "Settings_AlwaysOnTop";

	// Token: 0x0400071B RID: 1819
	public const string PREF_KEY_IS_FLIPPED = "Settings_IsFlipped";

	// Token: 0x0400071C RID: 1820
	public const string PREF_KEY_STEAM_STATUS = "Settings_SteamStatus";

	// Token: 0x0400071D RID: 1821
	public const string PREF_KEY_CHARACTER_MODE = "Settings_CharacterMode";

	// Token: 0x0400071E RID: 1822
	public const string PREF_KEY_CHARACTER_HIDDEN = "Settings_CharacterHidden";

	// Token: 0x0400071F RID: 1823
	public const string PREF_KEY_FPS = "Settings_FPS";

	// Token: 0x04000720 RID: 1824
	public const string PREF_KEY_AUTO_START = "Settings_AutoStart";

	// Token: 0x04000721 RID: 1825
	public const string PREF_KEY_DROP_NOTIFICATION = "Settings_DropNotification";

	// Token: 0x04000722 RID: 1826
	public const string PREF_KEY_DROP_ANIMATION = "Settings_DropAnimation";

	// Token: 0x04000723 RID: 1827
	public static readonly int[] FPSOptions = new int[] { 12, 24, 30, 60, 120, 144, -1 };

	// Token: 0x04000724 RID: 1828
	private bool hyb;

	// Token: 0x04000725 RID: 1829
	private float hyc;

	// Token: 0x04000726 RID: 1830
	private float hyd;

	// Token: 0x04000727 RID: 1831
	private float hye;

	// Token: 0x04000728 RID: 1832
	private float hyf;

	// Token: 0x04000729 RID: 1833
	private float hyg;

	// Token: 0x0400072A RID: 1834
	private bool hyh;

	// Token: 0x0400072B RID: 1835
	private bool hyi;

	// Token: 0x0400072C RID: 1836
	private bool hyj;

	// Token: 0x0400072D RID: 1837
	private bool hyk;

	// Token: 0x0400072E RID: 1838
	private Coroutine hyl;

	// Token: 0x0400072F RID: 1839
	private bool hym;

	// Token: 0x04000730 RID: 1840
	private int[] hyn;

	// Token: 0x04000731 RID: 1841
	private int[] hyo;

	// Token: 0x04000732 RID: 1842
	private int[] hyp;

	// Token: 0x04000733 RID: 1843
	private int[] hyq;

	// Token: 0x04000734 RID: 1844
	private bool hyr;

	// Token: 0x04000735 RID: 1845
	private bool hys;

	// Token: 0x04000736 RID: 1846
	private static readonly AiConnectionMode[] hyt = new AiConnectionMode[]
	{
		AiConnectionMode.None,
		AiConnectionMode.DirectApi,
		AiConnectionMode.Mcp
	};

	// Token: 0x04000737 RID: 1847
	private float hyu = -9999f;

	// Token: 0x04000738 RID: 1848
	private string hyv = a.tk();

	// Token: 0x04000739 RID: 1849
	private bool hyw;

	// Token: 0x0200009E RID: 158
	[CompilerGenerated]
	private sealed class dc
	{
		// Token: 0x060008A9 RID: 2217 RVA: 0x000359E8 File Offset: 0x00033BE8
		internal void btn(bool a)
		{
			this.hwk = a;
			this.hwl = true;
		}

		// Token: 0x04000741 RID: 1857
		public bool hwk;

		// Token: 0x04000742 RID: 1858
		public bool hwl;
	}

	// Token: 0x0200009F RID: 159
	[CompilerGenerated]
	private sealed class dd
	{
		// Token: 0x060008AA RID: 2218 RVA: 0x000359F8 File Offset: 0x00033BF8
		internal int bto(int a, int b)
		{
			return this.hwm.sizes[a].CompareTo(this.hwm.sizes[b]);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00035A30 File Offset: 0x00033C30
		internal int uw(int a, int b)
		{
			return this.hwm.sizes[a].CompareTo(this.hwm.sizes[b]);
		}

		// Token: 0x04000743 RID: 1859
		public bz hwm;
	}

	// Token: 0x020000A0 RID: 160
	[CompilerGenerated]
	private sealed class de
	{
		// Token: 0x060008AE RID: 2222 RVA: 0x00035A67 File Offset: 0x00033C67
		internal bool btp(string a)
		{
			return a == this.hwn;
		}

		// Token: 0x04000744 RID: 1860
		public string hwn;
	}
}
