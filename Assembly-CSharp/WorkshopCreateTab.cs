using System;
using System.IO;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Kirurobo;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020000D5 RID: 213
public sealed class WorkshopCreateTab : MonoBehaviour
{
	// Token: 0x06000B28 RID: 2856 RVA: 0x000424D8 File Offset: 0x000406D8
	private void Start()
	{
		this.ckd(false);
		this.btnBrowse.onClick.AddListener(new UnityAction(this.cjw));
		this.btnSave.onClick.AddListener(new UnityAction(this.cka));
		this.btnReset.onClick.AddListener(new UnityAction(this.ckc));
		if (UniWindowController.current != null)
		{
			UniWindowController.current.OnDropFiles += this.cjx;
		}
		this.inputName.characterLimit = 128;
		this.sliderPosX.minValue = -2f;
		this.sliderPosX.maxValue = 2f;
		this.sliderPosY.minValue = -2f;
		this.sliderPosY.maxValue = 2f;
		this.sliderScale.minValue = 0.05f;
		this.sliderScale.maxValue = 2f;
		this.sliderClickDuration.minValue = 0.05f;
		this.sliderClickDuration.maxValue = 1f;
		this.sliderMixOutTime.minValue = 0.05f;
		this.sliderMixOutTime.maxValue = 1f;
		this.sliderPosX.onValueChanged.AddListener(new UnityAction<float>(this.ckj));
		this.sliderPosY.onValueChanged.AddListener(new UnityAction<float>(this.ckk));
		this.sliderScale.onValueChanged.AddListener(new UnityAction<float>(this.ckl));
		this.sliderClickDuration.onValueChanged.AddListener(new UnityAction<float>(this.ckm));
		this.sliderMixOutTime.onValueChanged.AddListener(new UnityAction<float>(this.ckn));
		this.inputPosX.onEndEdit.AddListener(new UnityAction<string>(this.cko));
		this.inputPosY.onEndEdit.AddListener(new UnityAction<string>(this.ckp));
		this.inputScale.onEndEdit.AddListener(new UnityAction<string>(this.ckq));
		this.inputClickDuration.onEndEdit.AddListener(new UnityAction<string>(this.ckr));
		this.inputMixOutTime.onEndEdit.AddListener(new UnityAction<string>(this.cks));
		this.txtFolderName.text = a.tk();
	}

	// Token: 0x06000B29 RID: 2857 RVA: 0x0004273C File Offset: 0x0004093C
	private void cjw()
	{
		FilePanel.OpenFilePanel(new FilePanel.Settings
		{
			title = a.dkr(),
			filters = new FilePanel.Filter[]
			{
				new FilePanel.Filter(a.dks(), new string[] { a.dkt() })
			}
		}, new Action<string[]>(this.ckt));
	}

	// Token: 0x06000B2A RID: 2858 RVA: 0x00042798 File Offset: 0x00040998
	private void cjx(string[] a)
	{
		if (a == null || a.Length == 0)
		{
			return;
		}
		foreach (string text in a)
		{
			if (Path.GetFileName(text) == a.cxy())
			{
				this.cjy(Path.GetDirectoryName(text));
				return;
			}
			if (Directory.Exists(text) && File.Exists(Path.Combine(text, a.cxy())))
			{
				this.cjy(text);
				return;
			}
		}
	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x00042804 File Offset: 0x00040A04
	public void cjy(string a)
	{
		this.ife = a.Replace('\\', '/');
		this.txtFolderName.text = Path.GetFileName(this.ife);
		string text = Path.Combine(this.ife, a.cxy());
		if (!File.Exists(text))
		{
			this.txtValidation.text = a.dku();
			this.txtValidation.color = Color.red;
			return;
		}
		try
		{
			string text2 = File.ReadAllText(text);
			this.iff = JsonUtility.FromJson<CharacterPackageData>(text2);
		}
		catch (Exception ex)
		{
			this.txtValidation.text = a.dkv() + ex.Message;
			this.txtValidation.color = Color.red;
			return;
		}
		string text3;
		if (!this.iff.chg(out text3))
		{
			this.txtValidation.text = a.dkw() + text3;
			this.txtValidation.color = Color.yellow;
			return;
		}
		this.txtValidation.text = a.dkx();
		this.txtValidation.color = Color.green;
		this.ckd(true);
		this.txtType.text = (this.iff.krk ? a.dee() : a.def());
		this.inputName.text = this.iff.name ?? a.tk();
		if (this.uploadTab != null)
		{
			this.uploadTab.cmq();
			this.uploadTab.cml(this.iff.name);
			this.uploadTab.cmm(true);
			string text4 = WorkshopCreateTab.cke(this.ife);
			if (text4 != null)
			{
				this.uploadTab.cmo(text4);
			}
		}
		float num = ((this.iff.position != null && this.iff.position.Length >= 2) ? this.iff.position[0] : 0f);
		float num2 = ((this.iff.position != null && this.iff.position.Length >= 2) ? this.iff.position[1] : 0f);
		float num3 = ((this.iff.scale != null && this.iff.scale.Length >= 2) ? this.iff.scale[0] : 1f);
		this.sliderPosX.value = num;
		this.sliderPosY.value = num2;
		this.sliderScale.value = num3;
		this.inputPosX.SetTextWithoutNotify(num.ToString(a.dky()));
		this.inputPosY.SetTextWithoutNotify(num2.ToString(a.dky()));
		this.inputScale.SetTextWithoutNotify(num3.ToString(a.dky()));
		bool flag = this.iff.krk;
		this.objClickDuration.SetActive(flag);
		this.objMixOutTime.SetActive(!flag);
		if (flag)
		{
			this.sliderClickDuration.value = this.iff.click_display_duration;
			this.inputClickDuration.SetTextWithoutNotify(this.iff.click_display_duration.ToString(a.dky()));
		}
		else
		{
			this.sliderMixOutTime.value = this.iff.hand_mix_out_time;
			this.inputMixOutTime.SetTextWithoutNotify(this.iff.hand_mix_out_time.ToString(a.dky()));
		}
		this.ifg = this.iff.name ?? a.tk();
		this.ifh = num;
		this.ifi = num2;
		this.ifj = num3;
		this.ifk = this.iff.click_display_duration;
		this.ifl = this.iff.hand_mix_out_time;
		this.btnSave.interactable = true;
		string text5;
		CatCharacterDefinition catCharacterDefinition = ea.chh(this.ife, out text5);
		if (catCharacterDefinition != null)
		{
			WorkshopPreviewController.krz.cly(catCharacterDefinition);
			if (flag)
			{
				WorkshopPreviewController.krz.clz(this.sliderClickDuration.value);
				return;
			}
			WorkshopPreviewController.krz.cma(this.sliderMixOutTime.value);
			return;
		}
		else
		{
			this.txtValidation.text = a.dkz() + text5;
			this.txtValidation.color = Color.red;
		}
	}

	// Token: 0x06000B2C RID: 2860 RVA: 0x00042C3C File Offset: 0x00040E3C
	private void cjz()
	{
		if (WorkshopPreviewController.krz == null)
		{
			return;
		}
		WorkshopPreviewController.krz.ksb = new Vector2(this.sliderPosX.value, this.sliderPosY.value);
		float value = this.sliderScale.value;
		WorkshopPreviewController.krz.ksc = new Vector2(value, value);
	}

	// Token: 0x06000B2D RID: 2861 RVA: 0x00042C99 File Offset: 0x00040E99
	private void cka()
	{
		this.ckb();
	}

	// Token: 0x06000B2E RID: 2862 RVA: 0x00042CA4 File Offset: 0x00040EA4
	public bool ckb()
	{
		if (this.iff == null || string.IsNullOrEmpty(this.ife))
		{
			return false;
		}
		this.iff.name = this.inputName.text;
		this.iff.position = new float[]
		{
			WorkshopCreateTab.ckg(this.sliderPosX.value),
			WorkshopCreateTab.ckg(this.sliderPosY.value)
		};
		float num = WorkshopCreateTab.ckg(this.sliderScale.value);
		this.iff.scale = new float[] { num, num };
		if (this.iff.krk)
		{
			this.iff.click_display_duration = WorkshopCreateTab.ckg(this.sliderClickDuration.value);
		}
		else
		{
			this.iff.hand_mix_out_time = WorkshopCreateTab.ckg(this.sliderMixOutTime.value);
		}
		string text = JsonUtility.ToJson(this.iff, true);
		string text2 = Path.Combine(this.ife, a.cxy());
		try
		{
			File.WriteAllText(text2, text);
		}
		catch (Exception ex)
		{
			this.txtValidation.text = a.dla() + ex.Message;
			this.txtValidation.color = Color.red;
			return false;
		}
		this.ifg = this.inputName.text;
		this.ifh = this.sliderPosX.value;
		this.ifi = this.sliderPosY.value;
		this.ifj = this.sliderScale.value;
		this.ifk = this.sliderClickDuration.value;
		this.ifl = this.sliderMixOutTime.value;
		this.txtValidation.text = a.dlb() + text2.Replace('\\', '/');
		this.txtValidation.color = Color.green;
		return true;
	}

	// Token: 0x06000B2F RID: 2863 RVA: 0x00042E88 File Offset: 0x00041088
	private void ckc()
	{
		if (this.iff == null)
		{
			return;
		}
		this.inputName.text = this.ifg;
		this.sliderPosX.value = this.ifh;
		this.sliderPosY.value = this.ifi;
		this.sliderScale.value = this.ifj;
		if (this.iff.krk)
		{
			this.sliderClickDuration.value = this.ifk;
			return;
		}
		this.sliderMixOutTime.value = this.ifl;
	}

	// Token: 0x06000B30 RID: 2864 RVA: 0x00042F14 File Offset: 0x00041114
	private void ckd(bool a)
	{
		this.objType.SetActive(a);
		this.objValidation.SetActive(a);
		this.objName.SetActive(a);
		this.objPosX.SetActive(a);
		this.objPosY.SetActive(a);
		this.objScale.SetActive(a);
		this.objSave.SetActive(a);
		this.objClickDuration.SetActive(false);
		this.objMixOutTime.SetActive(false);
	}

	// Token: 0x06000B31 RID: 2865 RVA: 0x00042F90 File Offset: 0x00041190
	private static string cke(string a)
	{
		foreach (string text in new string[]
		{
			a.cxn(),
			a.dlc()
		})
		{
			string text2 = Path.Combine(a, text);
			if (File.Exists(text2))
			{
				return text2;
			}
		}
		try
		{
			foreach (string text3 in Directory.GetFiles(a))
			{
				string fileName = Path.GetFileName(text3);
				if (fileName.Equals(a.cxn(), StringComparison.OrdinalIgnoreCase) || fileName.Equals(a.dlc(), StringComparison.OrdinalIgnoreCase))
				{
					return text3;
				}
			}
		}
		catch
		{
		}
		return null;
	}

	// Token: 0x06000B32 RID: 2866 RVA: 0x0004303C File Offset: 0x0004123C
	private static void ckf(string a, Slider b, TMP_InputField c)
	{
		float num;
		if (float.TryParse(a, out num))
		{
			num = Mathf.Clamp(num, b.minValue, b.maxValue);
			b.value = num;
			c.SetTextWithoutNotify(num.ToString(a.dky()));
			return;
		}
		c.SetTextWithoutNotify(b.value.ToString(a.dky()));
	}

	// Token: 0x06000B33 RID: 2867 RVA: 0x00043099 File Offset: 0x00041299
	private static float ckg(float a)
	{
		return Mathf.Round(a * 1000f) / 1000f;
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x06000B34 RID: 2868 RVA: 0x000430AD File Offset: 0x000412AD
	public string kru
	{
		get
		{
			return this.ife;
		}
	}

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x06000B35 RID: 2869 RVA: 0x000430B5 File Offset: 0x000412B5
	public CharacterPackageData krv
	{
		get
		{
			return this.iff;
		}
	}

	// Token: 0x06000B37 RID: 2871 RVA: 0x000430BD File Offset: 0x000412BD
	[CompilerGenerated]
	private void ckj(float a)
	{
		this.inputPosX.SetTextWithoutNotify(a.ToString(a.dky()));
		this.cjz();
	}

	// Token: 0x06000B38 RID: 2872 RVA: 0x000430DC File Offset: 0x000412DC
	[CompilerGenerated]
	private void ckk(float a)
	{
		this.inputPosY.SetTextWithoutNotify(a.ToString(a.dky()));
		this.cjz();
	}

	// Token: 0x06000B39 RID: 2873 RVA: 0x000430FB File Offset: 0x000412FB
	[CompilerGenerated]
	private void ckl(float a)
	{
		this.inputScale.SetTextWithoutNotify(a.ToString(a.dky()));
		this.cjz();
	}

	// Token: 0x06000B3A RID: 2874 RVA: 0x0004311A File Offset: 0x0004131A
	[CompilerGenerated]
	private void ckm(float a)
	{
		this.inputClickDuration.SetTextWithoutNotify(a.ToString(a.dky()));
		if (WorkshopPreviewController.krz != null)
		{
			WorkshopPreviewController.krz.clz(a);
		}
	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x0004314B File Offset: 0x0004134B
	[CompilerGenerated]
	private void ckn(float a)
	{
		this.inputMixOutTime.SetTextWithoutNotify(a.ToString(a.dky()));
		if (WorkshopPreviewController.krz != null)
		{
			WorkshopPreviewController.krz.cma(a);
		}
	}

	// Token: 0x06000B3C RID: 2876 RVA: 0x0004317C File Offset: 0x0004137C
	[CompilerGenerated]
	private void cko(string a)
	{
		WorkshopCreateTab.ckf(a, this.sliderPosX, this.inputPosX);
	}

	// Token: 0x06000B3D RID: 2877 RVA: 0x00043190 File Offset: 0x00041390
	[CompilerGenerated]
	private void ckp(string a)
	{
		WorkshopCreateTab.ckf(a, this.sliderPosY, this.inputPosY);
	}

	// Token: 0x06000B3E RID: 2878 RVA: 0x000431A4 File Offset: 0x000413A4
	[CompilerGenerated]
	private void ckq(string a)
	{
		WorkshopCreateTab.ckf(a, this.sliderScale, this.inputScale);
	}

	// Token: 0x06000B3F RID: 2879 RVA: 0x000431B8 File Offset: 0x000413B8
	[CompilerGenerated]
	private void ckr(string a)
	{
		WorkshopCreateTab.ckf(a, this.sliderClickDuration, this.inputClickDuration);
	}

	// Token: 0x06000B40 RID: 2880 RVA: 0x000431CC File Offset: 0x000413CC
	[CompilerGenerated]
	private void cks(string a)
	{
		WorkshopCreateTab.ckf(a, this.sliderMixOutTime, this.inputMixOutTime);
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x000431E0 File Offset: 0x000413E0
	[CompilerGenerated]
	private void ckt(string[] a)
	{
		if (a == null || a.Length == 0)
		{
			return;
		}
		string directoryName = Path.GetDirectoryName(a[0]);
		if (string.IsNullOrEmpty(directoryName))
		{
			return;
		}
		this.cjy(directoryName);
	}

	// Token: 0x0400088D RID: 2189
	[SerializeField]
	private Button btnBrowse;

	// Token: 0x0400088E RID: 2190
	[SerializeField]
	private TMP_Text txtFolderName;

	// Token: 0x0400088F RID: 2191
	[SerializeField]
	private TMP_Text txtType;

	// Token: 0x04000890 RID: 2192
	[SerializeField]
	private TMP_Text txtValidation;

	// Token: 0x04000891 RID: 2193
	[SerializeField]
	private GameObject objType;

	// Token: 0x04000892 RID: 2194
	[SerializeField]
	private GameObject objValidation;

	// Token: 0x04000893 RID: 2195
	[SerializeField]
	private GameObject objName;

	// Token: 0x04000894 RID: 2196
	[SerializeField]
	private GameObject objPosX;

	// Token: 0x04000895 RID: 2197
	[SerializeField]
	private GameObject objPosY;

	// Token: 0x04000896 RID: 2198
	[SerializeField]
	private GameObject objScale;

	// Token: 0x04000897 RID: 2199
	[SerializeField]
	private GameObject objSave;

	// Token: 0x04000898 RID: 2200
	[SerializeField]
	private TMP_InputField inputName;

	// Token: 0x04000899 RID: 2201
	[SerializeField]
	private Slider sliderPosX;

	// Token: 0x0400089A RID: 2202
	[SerializeField]
	private Slider sliderPosY;

	// Token: 0x0400089B RID: 2203
	[SerializeField]
	private Slider sliderScale;

	// Token: 0x0400089C RID: 2204
	[SerializeField]
	private TMP_InputField inputPosX;

	// Token: 0x0400089D RID: 2205
	[SerializeField]
	private TMP_InputField inputPosY;

	// Token: 0x0400089E RID: 2206
	[SerializeField]
	private TMP_InputField inputScale;

	// Token: 0x0400089F RID: 2207
	[SerializeField]
	private GameObject objClickDuration;

	// Token: 0x040008A0 RID: 2208
	[SerializeField]
	private Slider sliderClickDuration;

	// Token: 0x040008A1 RID: 2209
	[SerializeField]
	private TMP_InputField inputClickDuration;

	// Token: 0x040008A2 RID: 2210
	[SerializeField]
	private GameObject objMixOutTime;

	// Token: 0x040008A3 RID: 2211
	[SerializeField]
	private Slider sliderMixOutTime;

	// Token: 0x040008A4 RID: 2212
	[SerializeField]
	private TMP_InputField inputMixOutTime;

	// Token: 0x040008A5 RID: 2213
	[SerializeField]
	private Button btnSave;

	// Token: 0x040008A6 RID: 2214
	[SerializeField]
	private Button btnReset;

	// Token: 0x040008A7 RID: 2215
	[SerializeField]
	private WorkshopUploadTab uploadTab;

	// Token: 0x040008A8 RID: 2216
	private string ife;

	// Token: 0x040008A9 RID: 2217
	private CharacterPackageData iff;

	// Token: 0x040008AA RID: 2218
	private string ifg;

	// Token: 0x040008AB RID: 2219
	private float ifh;

	// Token: 0x040008AC RID: 2220
	private float ifi;

	// Token: 0x040008AD RID: 2221
	private float ifj;

	// Token: 0x040008AE RID: 2222
	private float ifk;

	// Token: 0x040008AF RID: 2223
	private float ifl;
}
