using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Rewired.Glyphs;
using Rewired.Glyphs.UnityUI;
using Rewired.Integration.UnityUI;
using Rewired.Utils;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020001F2 RID: 498
	public class CalibrationWindow : Window
	{
		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001F7C RID: 8060 RVA: 0x0008BA68 File Offset: 0x00089C68
		private bool lvr
		{
			get
			{
				return this.jyq != null && this.jys >= 0 && this.jys < this.jyq.calibrationMap.axisCount;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x0008BA98 File Offset: 0x00089C98
		private AxisCalibration lvs
		{
			get
			{
				if (!this.lvr)
				{
					return null;
				}
				return this.jyq.calibrationMap.GetAxis(this.jys);
			}
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x0008BABC File Offset: 0x00089CBC
		public override void fkn(int a, Func<int, bool> b)
		{
			if (this.rightContentContainer == null || this.valueDisplayGroup == null || this.calibratedValueMarker == null || this.rawValueMarker == null || this.calibratedZeroMarker == null || this.deadzoneArea == null || this.deadzoneSlider == null || this.sensitivitySlider == null || this.zeroSlider == null || this.invertToggle == null || this.axisScrollAreaContent == null || this.doneButton == null || this.calibrateButton == null || this.axisButtonPrefab == null || this.doneButtonLabel == null || this.cancelButtonLabel == null || this.defaultButtonLabel == null || this.deadzoneSliderLabel == null || this.zeroSliderLabel == null || this.sensitivitySliderLabel == null || this.invertToggleLabel == null || this.calibrateButtonLabel == null)
			{
				Debug.LogError(a.esr());
				return;
			}
			this.jyv = new List<Button>();
			this.jyw = new Dictionary<int, Action<int>>();
			this.doneButtonLabel.text = ControlMapper.ghi().mck;
			this.cancelButtonLabel.text = ControlMapper.ghi().mch;
			this.defaultButtonLabel.text = ControlMapper.ghi().mcl;
			this.deadzoneSliderLabel.text = ControlMapper.ghi().mdn;
			this.zeroSliderLabel.text = ControlMapper.ghi().mdo;
			this.sensitivitySliderLabel.text = ControlMapper.ghi().mdp;
			this.invertToggleLabel.text = ControlMapper.ghi().mdq;
			this.calibrateButtonLabel.text = ControlMapper.ghi().mdr;
			base.fkn(a, b);
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x0008BCF8 File Offset: 0x00089EF8
		public void fko(int a, Joystick b)
		{
			if (!base.mgo)
			{
				return;
			}
			this.jyx = a;
			this.jyq = b;
			if (b == null)
			{
				Debug.LogError(a.ess());
				return;
			}
			float num = 0f;
			for (int i = 0; i < b.axisCount; i++)
			{
				CalibrationWindow.iy iy = new CalibrationWindow.iy();
				iy.jyn = this;
				iy.jyl = i;
				GameObject gameObject = kq.grj<Button>(this.axisButtonPrefab, this.axisScrollAreaContent, a.est() + i.ToString());
				iy.jym = gameObject.GetComponent<Button>();
				iy.jym.onClick.AddListener(new UnityAction(iy.fkk));
				UnityUIControllerElementGlyph componentInSelfOrChildren = UnityTools.GetComponentInSelfOrChildren<UnityUIControllerElementGlyph>(gameObject);
				if (componentInSelfOrChildren != null)
				{
					componentInSelfOrChildren.lsg = (ControlMapper.mbk.lzq ? ControllerElementGlyphBase.AllowedTypes.All : ControllerElementGlyphBase.AllowedTypes.Text);
					componentInSelfOrChildren.lsb = b.AxisElementIdentifiers[i];
				}
				else
				{
					TMP_Text componentInSelfOrChildren2 = UnityTools.GetComponentInSelfOrChildren<TMP_Text>(gameObject);
					if (componentInSelfOrChildren2 != null)
					{
						componentInSelfOrChildren2.text = ControlMapper.ghi().gmr(b, b.AxisElementIdentifiers[i].id, AxisRange.Full);
					}
				}
				if (num == 0f)
				{
					num = UnityTools.GetComponentInSelfOrChildren<LayoutElement>(gameObject).minHeight;
				}
				this.jyv.Add(iy.jym);
			}
			float spacing = this.axisScrollAreaContent.GetComponent<VerticalLayoutGroup>().spacing;
			this.axisScrollAreaContent.sizeDelta = new Vector2(this.axisScrollAreaContent.sizeDelta.x, Mathf.Max((float)b.axisCount * (num + spacing) - spacing, this.axisScrollAreaContent.sizeDelta.y));
			this.jyr = b.calibrationMap.ToXmlString();
			this.jyu = this.rightContentContainer.sizeDelta.x;
			this.jyy = base.gameObject.transform.root.GetComponentInChildren<RewiredStandaloneInputModule>();
			if (this.jyy != null)
			{
				this.jyz = ReInput.mapping.GetActionId(this.jyy.lrs);
				this.jza = ReInput.mapping.GetActionId(this.jyy.lrt);
			}
			if (b.axisCount > 0)
			{
				this.fkx(0);
			}
			base.mgj = this.doneButton.gameObject;
			this.fkt();
			this.fks();
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x0008BF4A File Offset: 0x0008A14A
		public void fkp(CalibrationWindow.ButtonIdentifier a, Action<int> b)
		{
			if (!base.mgo)
			{
				return;
			}
			if (b == null)
			{
				return;
			}
			if (this.jyw.ContainsKey((int)a))
			{
				this.jyw[(int)a] = b;
				return;
			}
			this.jyw.Add((int)a, b);
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x0008BF84 File Offset: 0x0008A184
		public override void Cancel()
		{
			if (!base.mgo)
			{
				return;
			}
			if (this.jyq != null)
			{
				this.jyq.ImportCalibrationMapFromXmlString(this.jyr);
			}
			Action<int> action;
			if (!this.jyw.TryGetValue(1, out action))
			{
				if (this.cancelCallback != null)
				{
					this.cancelCallback();
				}
				return;
			}
			action(base.mgf);
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x0008BFE4 File Offset: 0x0008A1E4
		protected override void Update()
		{
			if (!base.mgo)
			{
				return;
			}
			base.Update();
			this.fkr();
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x0008BFFC File Offset: 0x0008A1FC
		public void OnDone()
		{
			if (!base.mgo)
			{
				return;
			}
			Action<int> action;
			if (!this.jyw.TryGetValue(0, out action))
			{
				return;
			}
			action(base.mgf);
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x0008C02F File Offset: 0x0008A22F
		public void OnCancel()
		{
			this.Cancel();
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x0008C037 File Offset: 0x0008A237
		public void OnRestoreDefault()
		{
			if (!base.mgo)
			{
				return;
			}
			if (this.jyq == null)
			{
				return;
			}
			this.jyq.calibrationMap.Reset();
			this.fkt();
			this.fks();
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x0008C068 File Offset: 0x0008A268
		public void OnCalibrate()
		{
			if (!base.mgo)
			{
				return;
			}
			Action<int> action;
			if (!this.jyw.TryGetValue(3, out action))
			{
				return;
			}
			action(this.jys);
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x0008C09B File Offset: 0x0008A29B
		public void OnInvert(bool state)
		{
			if (!base.mgo)
			{
				return;
			}
			if (!this.lvr)
			{
				return;
			}
			this.lvs.invert = state;
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x0008C0BB File Offset: 0x0008A2BB
		public void OnZeroValueChange(float value)
		{
			if (!base.mgo)
			{
				return;
			}
			if (!this.lvr)
			{
				return;
			}
			this.lvs.calibratedZero = value;
			this.fkv();
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x0008C0E1 File Offset: 0x0008A2E1
		public void OnZeroCancel()
		{
			if (!base.mgo)
			{
				return;
			}
			if (!this.lvr)
			{
				return;
			}
			this.lvs.calibratedZero = this.jyt.zero;
			this.fkv();
			this.fkt();
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x0008C118 File Offset: 0x0008A318
		public void OnDeadzoneValueChange(float value)
		{
			if (!base.mgo)
			{
				return;
			}
			if (!this.lvr)
			{
				return;
			}
			this.lvs.deadZone = Mathf.Clamp(value, 0f, 0.8f);
			if (value > 0.8f)
			{
				this.deadzoneSlider.value = 0.8f;
			}
			this.fku();
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x0008C170 File Offset: 0x0008A370
		public void OnDeadzoneCancel()
		{
			if (!base.mgo)
			{
				return;
			}
			if (!this.lvr)
			{
				return;
			}
			this.lvs.deadZone = this.jyt.deadZone;
			this.fku();
			this.fkt();
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x0008C1A6 File Offset: 0x0008A3A6
		public void OnSensitivityValueChange(float value)
		{
			if (!base.mgo)
			{
				return;
			}
			if (!this.lvr)
			{
				return;
			}
			this.fld(this.lvs, value);
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x0008C1C7 File Offset: 0x0008A3C7
		public void OnSensitivityCancel(float value)
		{
			if (!base.mgo)
			{
				return;
			}
			if (!this.lvr)
			{
				return;
			}
			this.lvs.sensitivity = this.jyt.sensitivity;
			this.fkt();
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x0008C1F7 File Offset: 0x0008A3F7
		public void OnAxisScrollRectScroll(Vector2 pos)
		{
			base.mgo;
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x0008C200 File Offset: 0x0008A400
		private void fkq(int a, Button b)
		{
			if (!base.mgo)
			{
				return;
			}
			if (this.jyq == null)
			{
				return;
			}
			this.fkx(a);
			this.fkt();
			this.fks();
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x0008C227 File Offset: 0x0008A427
		private void fkr()
		{
			this.fkw();
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x0008C22F File Offset: 0x0008A42F
		private void fks()
		{
			this.fkv();
			this.fkw();
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x0008C240 File Offset: 0x0008A440
		private void fkt()
		{
			if (!this.lvr)
			{
				this.deadzoneSlider.value = 0f;
				this.zeroSlider.value = 0f;
				this.sensitivitySlider.value = 0f;
				this.invertToggle.isOn = false;
				return;
			}
			this.deadzoneSlider.value = this.lvs.deadZone;
			this.zeroSlider.value = this.lvs.calibratedZero;
			this.sensitivitySlider.value = this.flc(this.lvs);
			this.invertToggle.isOn = this.lvs.invert;
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x0008C2EC File Offset: 0x0008A4EC
		private void fku()
		{
			if (!this.lvr)
			{
				return;
			}
			float num = this.jyu * this.lvs.deadZone;
			this.deadzoneArea.sizeDelta = new Vector2(num, this.deadzoneArea.sizeDelta.y);
			this.deadzoneArea.anchoredPosition = new Vector2(this.lvs.calibratedZero * -this.deadzoneArea.parent.localPosition.x, this.deadzoneArea.anchoredPosition.y);
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x0008C378 File Offset: 0x0008A578
		private void fkv()
		{
			if (!this.lvr)
			{
				return;
			}
			this.calibratedZeroMarker.anchoredPosition = new Vector2(this.lvs.calibratedZero * -this.deadzoneArea.parent.localPosition.x, this.calibratedZeroMarker.anchoredPosition.y);
			this.fku();
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x0008C3D8 File Offset: 0x0008A5D8
		private void fkw()
		{
			if (!this.lvr)
			{
				this.calibratedValueMarker.anchoredPosition = new Vector2(0f, this.calibratedValueMarker.anchoredPosition.y);
				this.rawValueMarker.anchoredPosition = new Vector2(0f, this.rawValueMarker.anchoredPosition.y);
				return;
			}
			float axis = this.jyq.GetAxis(this.jys);
			float num = Mathf.Clamp(this.jyq.GetAxisRaw(this.jys), -1f, 1f);
			this.calibratedValueMarker.anchoredPosition = new Vector2(this.jyu * 0.5f * axis, this.calibratedValueMarker.anchoredPosition.y);
			this.rawValueMarker.anchoredPosition = new Vector2(this.jyu * 0.5f * num, this.rawValueMarker.anchoredPosition.y);
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x0008C4C8 File Offset: 0x0008A6C8
		private void fkx(int a)
		{
			if (a < 0 || a >= this.jyv.Count)
			{
				return;
			}
			if (this.jyv[a] == null)
			{
				return;
			}
			this.jyv[a].interactable = false;
			this.jyv[a].Select();
			for (int i = 0; i < this.jyv.Count; i++)
			{
				if (i != a)
				{
					this.jyv[i].interactable = true;
				}
			}
			this.jys = a;
			this.jyt = this.lvs.GetData();
			this.fkz();
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x0008C56A File Offset: 0x0008A76A
		public override void fky()
		{
			base.fky();
			if (this.jys >= 0)
			{
				this.fkx(this.jys);
			}
			this.fkt();
			this.fks();
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x0008C594 File Offset: 0x0008A794
		private void fkz()
		{
			if (!this.lvr)
			{
				return;
			}
			this.jzb = 0.1f;
			if (this.jyy != null)
			{
				if (this.fla(this.jyz, this.jys))
				{
					this.flb(this.jyx, this.jyz, ref this.jzb);
					return;
				}
				if (this.fla(this.jza, this.jys))
				{
					this.flb(this.jyx, this.jza, ref this.jzb);
				}
			}
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x0008C61C File Offset: 0x0008A81C
		private bool fla(int a, int b)
		{
			if (this.jyy == null)
			{
				return false;
			}
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			int count = allPlayers.Count;
			for (int i = 0; i < count; i++)
			{
				IList<JoystickMap> maps = allPlayers[i].controllers.maps.GetMaps<JoystickMap>(this.jyq.id);
				if (maps != null)
				{
					int count2 = maps.Count;
					for (int j = 0; j < count2; j++)
					{
						IList<ActionElementMap> axisMaps = maps[j].AxisMaps;
						if (axisMaps != null)
						{
							int count3 = axisMaps.Count;
							for (int k = 0; k < count3; k++)
							{
								ActionElementMap actionElementMap = axisMaps[k];
								if (actionElementMap.actionId == a && actionElementMap.elementIndex == b)
								{
									return true;
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x0008C6EC File Offset: 0x0008A8EC
		private void flb(int a, int b, ref float c)
		{
			InputAction action = ReInput.mapping.GetAction(b);
			if (action == null)
			{
				return;
			}
			int behaviorId = action.behaviorId;
			InputBehavior inputBehavior = ReInput.mapping.GetInputBehavior(a, behaviorId);
			if (inputBehavior == null)
			{
				return;
			}
			c = inputBehavior.buttonDeadZone + 0.1f;
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x0008C72F File Offset: 0x0008A92F
		private float flc(AxisCalibration a)
		{
			if (a.sensitivityType == AxisSensitivityType.Multiplier)
			{
				return a.sensitivity;
			}
			if (a.sensitivityType == AxisSensitivityType.Power)
			{
				return CalibrationWindow.fle(a.sensitivity, 0f, this.sensitivitySlider.maxValue);
			}
			return a.sensitivity;
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x0008C76C File Offset: 0x0008A96C
		public void fld(AxisCalibration a, float b)
		{
			if (a.sensitivityType == AxisSensitivityType.Multiplier)
			{
				a.sensitivity = Mathf.Clamp(b, this.jzb, float.PositiveInfinity);
				if (b < this.jzb)
				{
					this.sensitivitySlider.value = this.jzb;
					return;
				}
			}
			else
			{
				if (a.sensitivityType == AxisSensitivityType.Power)
				{
					a.sensitivity = CalibrationWindow.fle(b, 0f, this.sensitivitySlider.maxValue);
					return;
				}
				a.sensitivity = b;
			}
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x0008C7E0 File Offset: 0x0008A9E0
		private static float fle(float a, float b, float c)
		{
			a = Mathf.Clamp(a, b, c);
			if (a > 1f)
			{
				a = MathTools.ValueInNewRange(a, 1f, c, 1f, 0f);
			}
			else if (a < 1f)
			{
				a = MathTools.ValueInNewRange(a, 0f, 1f, c, 1f);
			}
			return a;
		}

		// Token: 0x04000FC8 RID: 4040
		private const float jyo = 0.1f;

		// Token: 0x04000FC9 RID: 4041
		private const float jyp = 0.8f;

		// Token: 0x04000FCA RID: 4042
		[SerializeField]
		private RectTransform rightContentContainer;

		// Token: 0x04000FCB RID: 4043
		[SerializeField]
		private RectTransform valueDisplayGroup;

		// Token: 0x04000FCC RID: 4044
		[SerializeField]
		private RectTransform calibratedValueMarker;

		// Token: 0x04000FCD RID: 4045
		[SerializeField]
		private RectTransform rawValueMarker;

		// Token: 0x04000FCE RID: 4046
		[SerializeField]
		private RectTransform calibratedZeroMarker;

		// Token: 0x04000FCF RID: 4047
		[SerializeField]
		private RectTransform deadzoneArea;

		// Token: 0x04000FD0 RID: 4048
		[SerializeField]
		private Slider deadzoneSlider;

		// Token: 0x04000FD1 RID: 4049
		[SerializeField]
		private Slider zeroSlider;

		// Token: 0x04000FD2 RID: 4050
		[SerializeField]
		private Slider sensitivitySlider;

		// Token: 0x04000FD3 RID: 4051
		[SerializeField]
		private Toggle invertToggle;

		// Token: 0x04000FD4 RID: 4052
		[SerializeField]
		private RectTransform axisScrollAreaContent;

		// Token: 0x04000FD5 RID: 4053
		[SerializeField]
		private Button doneButton;

		// Token: 0x04000FD6 RID: 4054
		[SerializeField]
		private Button calibrateButton;

		// Token: 0x04000FD7 RID: 4055
		[SerializeField]
		private TMP_Text doneButtonLabel;

		// Token: 0x04000FD8 RID: 4056
		[SerializeField]
		private TMP_Text cancelButtonLabel;

		// Token: 0x04000FD9 RID: 4057
		[SerializeField]
		private TMP_Text defaultButtonLabel;

		// Token: 0x04000FDA RID: 4058
		[SerializeField]
		private TMP_Text deadzoneSliderLabel;

		// Token: 0x04000FDB RID: 4059
		[SerializeField]
		private TMP_Text zeroSliderLabel;

		// Token: 0x04000FDC RID: 4060
		[SerializeField]
		private TMP_Text sensitivitySliderLabel;

		// Token: 0x04000FDD RID: 4061
		[SerializeField]
		private TMP_Text invertToggleLabel;

		// Token: 0x04000FDE RID: 4062
		[SerializeField]
		private TMP_Text calibrateButtonLabel;

		// Token: 0x04000FDF RID: 4063
		[SerializeField]
		private GameObject axisButtonPrefab;

		// Token: 0x04000FE0 RID: 4064
		private Joystick jyq;

		// Token: 0x04000FE1 RID: 4065
		private string jyr;

		// Token: 0x04000FE2 RID: 4066
		private int jys = -1;

		// Token: 0x04000FE3 RID: 4067
		private AxisCalibrationData jyt;

		// Token: 0x04000FE4 RID: 4068
		private float jyu;

		// Token: 0x04000FE5 RID: 4069
		private List<Button> jyv;

		// Token: 0x04000FE6 RID: 4070
		private Dictionary<int, Action<int>> jyw;

		// Token: 0x04000FE7 RID: 4071
		private int jyx;

		// Token: 0x04000FE8 RID: 4072
		private RewiredStandaloneInputModule jyy;

		// Token: 0x04000FE9 RID: 4073
		private int jyz = -1;

		// Token: 0x04000FEA RID: 4074
		private int jza = -1;

		// Token: 0x04000FEB RID: 4075
		private float jzb;

		// Token: 0x020001F3 RID: 499
		public enum ButtonIdentifier
		{
			// Token: 0x04000FED RID: 4077
			Done,
			// Token: 0x04000FEE RID: 4078
			Cancel,
			// Token: 0x04000FEF RID: 4079
			Default,
			// Token: 0x04000FF0 RID: 4080
			Calibrate
		}

		// Token: 0x020001F4 RID: 500
		[CompilerGenerated]
		private sealed class iy
		{
			// Token: 0x06001FA0 RID: 8096 RVA: 0x0008C85D File Offset: 0x0008AA5D
			internal void fkk()
			{
				this.jyn.fkq(this.jyl, this.jym);
			}

			// Token: 0x04000FF1 RID: 4081
			public int jyl;

			// Token: 0x04000FF2 RID: 4082
			public Button jym;

			// Token: 0x04000FF3 RID: 4083
			public CalibrationWindow jyn;
		}
	}
}
