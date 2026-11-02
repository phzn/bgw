using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000221 RID: 545
	public class InputBehaviorWindow : Window
	{
		// Token: 0x060023AF RID: 9135 RVA: 0x00098F84 File Offset: 0x00097184
		public override void fkn(int a, Func<int, bool> b)
		{
			if (this.spawnTransform == null || this.doneButton == null || this.cancelButton == null || this.defaultButton == null || this.uiControlSetPrefab == null || this.uiSliderControlPrefab == null || this.doneButtonLabel == null || this.cancelButtonLabel == null || this.defaultButtonLabel == null)
			{
				Debug.LogError(a.esr());
				return;
			}
			this.kfr = new List<InputBehaviorWindow.kd>();
			this.kfs = new Dictionary<int, Action<int>>();
			this.doneButtonLabel.text = ControlMapper.ghi().mck;
			this.cancelButtonLabel.text = ControlMapper.ghi().mch;
			this.defaultButtonLabel.text = ControlMapper.ghi().mcl;
			base.fkn(a, b);
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x0009907C File Offset: 0x0009727C
		public void gjj(int a, ControlMapper.InputBehaviorSettings[] b)
		{
			if (!base.mgo)
			{
				return;
			}
			this.kft = a;
			foreach (ControlMapper.InputBehaviorSettings inputBehaviorSettings in b)
			{
				if (inputBehaviorSettings != null && inputBehaviorSettings.lwv)
				{
					InputBehavior inputBehavior = this.gjr(inputBehaviorSettings.lwj);
					if (inputBehavior != null)
					{
						UIControlSet uicontrolSet = this.gjp();
						Dictionary<int, InputBehaviorWindow.PropertyType> dictionary = new Dictionary<int, InputBehaviorWindow.PropertyType>();
						string text = ControlMapper.ghi().gkk(inputBehaviorSettings.lwm);
						if (!string.IsNullOrEmpty(text))
						{
							uicontrolSet.gqp(text);
						}
						else
						{
							uicontrolSet.gqp(inputBehavior.name);
						}
						if (inputBehaviorSettings.lwk)
						{
							kp kp = this.gjq(uicontrolSet, inputBehavior.id, null, ControlMapper.ghi().gkk(inputBehaviorSettings.lwn), inputBehaviorSettings.lwp, inputBehaviorSettings.lwr, inputBehaviorSettings.lws, new Action<int, int, float>(this.gjl), new Action<int, int>(this.gjn));
							kp.slider.value = Mathf.Clamp(inputBehavior.joystickAxisSensitivity, inputBehaviorSettings.lwr, inputBehaviorSettings.lws);
							dictionary.Add(kp.mfs, InputBehaviorWindow.PropertyType.JoystickAxisSensitivity);
						}
						if (inputBehaviorSettings.lwl)
						{
							kp kp2 = this.gjq(uicontrolSet, inputBehavior.id, null, ControlMapper.ghi().gkk(inputBehaviorSettings.lwo), inputBehaviorSettings.lwq, inputBehaviorSettings.lwt, inputBehaviorSettings.lwu, new Action<int, int, float>(this.gjm), new Action<int, int>(this.gjo));
							kp2.slider.value = Mathf.Clamp(inputBehavior.mouseXYAxisSensitivity, inputBehaviorSettings.lwt, inputBehaviorSettings.lwu);
							dictionary.Add(kp2.mfs, InputBehaviorWindow.PropertyType.MouseXYAxisSensitivity);
						}
						this.kfr.Add(new InputBehaviorWindow.kd(inputBehavior, uicontrolSet, dictionary));
					}
				}
			}
			base.mgj = this.doneButton.gameObject;
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x00099241 File Offset: 0x00097441
		public void gjk(InputBehaviorWindow.ButtonIdentifier a, Action<int> b)
		{
			if (!base.mgo)
			{
				return;
			}
			if (b == null)
			{
				return;
			}
			if (this.kfs.ContainsKey((int)a))
			{
				this.kfs[(int)a] = b;
				return;
			}
			this.kfs.Add((int)a, b);
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x0009927C File Offset: 0x0009747C
		public override void Cancel()
		{
			if (!base.mgo)
			{
				return;
			}
			foreach (InputBehaviorWindow.kd kd in this.kfr)
			{
				kd.gjd();
			}
			Action<int> action;
			if (!this.kfs.TryGetValue(1, out action))
			{
				if (this.cancelCallback != null)
				{
					this.cancelCallback();
				}
				return;
			}
			action(base.mgf);
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x00099308 File Offset: 0x00097508
		public void OnDone()
		{
			if (!base.mgo)
			{
				return;
			}
			Action<int> action;
			if (!this.kfs.TryGetValue(0, out action))
			{
				return;
			}
			action(base.mgf);
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x0008C02F File Offset: 0x0008A22F
		public void OnCancel()
		{
			this.Cancel();
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x0009933C File Offset: 0x0009753C
		public void OnRestoreDefault()
		{
			if (!base.mgo)
			{
				return;
			}
			foreach (InputBehaviorWindow.kd kd in this.kfr)
			{
				kd.gje();
			}
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x00099398 File Offset: 0x00097598
		private void gjl(int a, int b, float c)
		{
			this.gjr(a).joystickAxisSensitivity = c;
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x000993A7 File Offset: 0x000975A7
		private void gjm(int a, int b, float c)
		{
			this.gjr(a).mouseXYAxisSensitivity = c;
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x000993B8 File Offset: 0x000975B8
		private void gjn(int a, int b)
		{
			InputBehaviorWindow.kd kd = this.gjs(a);
			if (kd == null)
			{
				return;
			}
			kd.gjf(InputBehaviorWindow.PropertyType.JoystickAxisSensitivity, b);
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x000993DC File Offset: 0x000975DC
		private void gjo(int a, int b)
		{
			InputBehaviorWindow.kd kd = this.gjs(a);
			if (kd == null)
			{
				return;
			}
			kd.gjf(InputBehaviorWindow.PropertyType.MouseXYAxisSensitivity, b);
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x000993FD File Offset: 0x000975FD
		public override void fky()
		{
			base.fky();
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x00099405 File Offset: 0x00097605
		private UIControlSet gjp()
		{
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.uiControlSetPrefab);
			gameObject.transform.SetParent(this.spawnTransform, false);
			return gameObject.GetComponent<UIControlSet>();
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x0009942C File Offset: 0x0009762C
		private kp gjq(UIControlSet a, int b, string c, string d, Sprite e, float f, float g, Action<int, int, float> h, Action<int, int> i)
		{
			InputBehaviorWindow.ke ke = new InputBehaviorWindow.ke();
			ke.kfn = h;
			ke.kfo = b;
			ke.kfp = i;
			kp kp = a.gqr(this.uiSliderControlPrefab, e, f, g, new Action<int, float>(ke.gjh), new Action<int>(ke.gji));
			string text = (string.IsNullOrEmpty(d) ? c : d);
			if (!string.IsNullOrEmpty(text))
			{
				kp.mft = true;
				kp.title.text = text;
			}
			else
			{
				kp.mft = false;
			}
			kp.mfx = e != null;
			return kp;
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x000994C3 File Offset: 0x000976C3
		private InputBehavior gjr(int a)
		{
			return ReInput.mapping.GetInputBehavior(this.kft, a);
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x000994D8 File Offset: 0x000976D8
		private InputBehaviorWindow.kd gjs(int a)
		{
			int count = this.kfr.Count;
			for (int i = 0; i < count; i++)
			{
				if (this.kfr[i].mbx.id == a)
				{
					return this.kfr[i];
				}
			}
			return null;
		}

		// Token: 0x0400113D RID: 4413
		private const float kfq = 0.1f;

		// Token: 0x0400113E RID: 4414
		[SerializeField]
		private RectTransform spawnTransform;

		// Token: 0x0400113F RID: 4415
		[SerializeField]
		private Button doneButton;

		// Token: 0x04001140 RID: 4416
		[SerializeField]
		private Button cancelButton;

		// Token: 0x04001141 RID: 4417
		[SerializeField]
		private Button defaultButton;

		// Token: 0x04001142 RID: 4418
		[SerializeField]
		private TMP_Text doneButtonLabel;

		// Token: 0x04001143 RID: 4419
		[SerializeField]
		private TMP_Text cancelButtonLabel;

		// Token: 0x04001144 RID: 4420
		[SerializeField]
		private TMP_Text defaultButtonLabel;

		// Token: 0x04001145 RID: 4421
		[SerializeField]
		private GameObject uiControlSetPrefab;

		// Token: 0x04001146 RID: 4422
		[SerializeField]
		private GameObject uiSliderControlPrefab;

		// Token: 0x04001147 RID: 4423
		private List<InputBehaviorWindow.kd> kfr;

		// Token: 0x04001148 RID: 4424
		private Dictionary<int, Action<int>> kfs;

		// Token: 0x04001149 RID: 4425
		private int kft;

		// Token: 0x02000222 RID: 546
		private class kd
		{
			// Token: 0x1700055F RID: 1375
			// (get) Token: 0x060023C0 RID: 9152 RVA: 0x0009952C File Offset: 0x0009772C
			public InputBehavior mbx
			{
				get
				{
					return this.kfj;
				}
			}

			// Token: 0x060023C1 RID: 9153 RVA: 0x00099534 File Offset: 0x00097734
			public void gjd()
			{
				this.kfj.ImportData(this.kfm);
			}

			// Token: 0x060023C2 RID: 9154 RVA: 0x00099548 File Offset: 0x00097748
			public kd(InputBehavior a, UIControlSet b, Dictionary<int, InputBehaviorWindow.PropertyType> c)
			{
				this.kfj = a;
				this.kfk = b;
				this.kfl = c;
				this.kfm = new InputBehavior(a);
			}

			// Token: 0x060023C3 RID: 9155 RVA: 0x00099571 File Offset: 0x00097771
			public void dql()
			{
				this.kfj.Reset();
				this.gjg();
			}

			// Token: 0x060023C4 RID: 9156 RVA: 0x00099571 File Offset: 0x00097771
			public void nxe()
			{
				this.kfj.Reset();
				this.gjg();
			}

			// Token: 0x060023C5 RID: 9157 RVA: 0x00099584 File Offset: 0x00097784
			public void gjf(InputBehaviorWindow.PropertyType a, int b)
			{
				if (a != InputBehaviorWindow.PropertyType.JoystickAxisSensitivity)
				{
					if (a != InputBehaviorWindow.PropertyType.MouseXYAxisSensitivity)
					{
						return;
					}
					float mouseXYAxisSensitivity = this.kfm.mouseXYAxisSensitivity;
					this.kfj.mouseXYAxisSensitivity = mouseXYAxisSensitivity;
					kp kp = this.kfk.gqq<kp>(b);
					if (kp != null)
					{
						kp.slider.value = mouseXYAxisSensitivity;
					}
				}
				else
				{
					float joystickAxisSensitivity = this.kfm.joystickAxisSensitivity;
					this.kfj.joystickAxisSensitivity = joystickAxisSensitivity;
					kp kp2 = this.kfk.gqq<kp>(b);
					if (kp2 != null)
					{
						kp2.slider.value = joystickAxisSensitivity;
						return;
					}
				}
			}

			// Token: 0x060023C6 RID: 9158 RVA: 0x00099571 File Offset: 0x00097771
			public void gje()
			{
				this.kfj.Reset();
				this.gjg();
			}

			// Token: 0x060023C7 RID: 9159 RVA: 0x00099610 File Offset: 0x00097810
			public void gjg()
			{
				if (this.kfk == null)
				{
					return;
				}
				if (this.kfl == null)
				{
					return;
				}
				foreach (KeyValuePair<int, InputBehaviorWindow.PropertyType> keyValuePair in this.kfl)
				{
					kp kp = this.kfk.gqq<kp>(keyValuePair.Key);
					if (!(kp == null))
					{
						InputBehaviorWindow.PropertyType value = keyValuePair.Value;
						if (value != InputBehaviorWindow.PropertyType.JoystickAxisSensitivity)
						{
							if (value == InputBehaviorWindow.PropertyType.MouseXYAxisSensitivity)
							{
								kp.slider.value = this.kfj.mouseXYAxisSensitivity;
							}
						}
						else
						{
							kp.slider.value = this.kfj.joystickAxisSensitivity;
						}
					}
				}
			}

			// Token: 0x17000560 RID: 1376
			// (get) Token: 0x060023C8 RID: 9160 RVA: 0x000996D0 File Offset: 0x000978D0
			public UIControlSet mby
			{
				get
				{
					return this.kfk;
				}
			}

			// Token: 0x060023C9 RID: 9161 RVA: 0x000996D8 File Offset: 0x000978D8
			public void fpg(InputBehaviorWindow.PropertyType a, int b)
			{
				if (a != InputBehaviorWindow.PropertyType.JoystickAxisSensitivity)
				{
					if (a != InputBehaviorWindow.PropertyType.MouseXYAxisSensitivity)
					{
						return;
					}
					float mouseXYAxisSensitivity = this.kfm.mouseXYAxisSensitivity;
					this.kfj.mouseXYAxisSensitivity = mouseXYAxisSensitivity;
					kp kp = this.kfk.gqq<kp>(b);
					if (kp != null)
					{
						kp.slider.value = mouseXYAxisSensitivity;
					}
				}
				else
				{
					float joystickAxisSensitivity = this.kfm.joystickAxisSensitivity;
					this.kfj.joystickAxisSensitivity = joystickAxisSensitivity;
					kp kp2 = this.kfk.gqq<kp>(b);
					if (kp2 != null)
					{
						kp2.slider.value = joystickAxisSensitivity;
						return;
					}
				}
			}

			// Token: 0x0400114A RID: 4426
			private InputBehavior kfj;

			// Token: 0x0400114B RID: 4427
			private UIControlSet kfk;

			// Token: 0x0400114C RID: 4428
			private Dictionary<int, InputBehaviorWindow.PropertyType> kfl;

			// Token: 0x0400114D RID: 4429
			private InputBehavior kfm;
		}

		// Token: 0x02000223 RID: 547
		public enum ButtonIdentifier
		{
			// Token: 0x0400114F RID: 4431
			Done,
			// Token: 0x04001150 RID: 4432
			Cancel,
			// Token: 0x04001151 RID: 4433
			Default
		}

		// Token: 0x02000224 RID: 548
		private enum PropertyType
		{
			// Token: 0x04001153 RID: 4435
			JoystickAxisSensitivity,
			// Token: 0x04001154 RID: 4436
			MouseXYAxisSensitivity
		}

		// Token: 0x02000225 RID: 549
		[CompilerGenerated]
		private sealed class ke
		{
			// Token: 0x060023CA RID: 9162 RVA: 0x00099762 File Offset: 0x00097962
			internal void gji(int a)
			{
				this.kfp(this.kfo, a);
			}

			// Token: 0x060023CB RID: 9163 RVA: 0x00099776 File Offset: 0x00097976
			internal void gjh(int a, float b)
			{
				this.kfn(this.kfo, a, b);
			}

			// Token: 0x060023CC RID: 9164 RVA: 0x00099776 File Offset: 0x00097976
			internal void hk(int a, float b)
			{
				this.kfn(this.kfo, a, b);
			}

			// Token: 0x060023CD RID: 9165 RVA: 0x00099776 File Offset: 0x00097976
			internal void mzg(int a, float b)
			{
				this.kfn(this.kfo, a, b);
			}

			// Token: 0x060023CE RID: 9166 RVA: 0x00099776 File Offset: 0x00097976
			internal void lku(int a, float b)
			{
				this.kfn(this.kfo, a, b);
			}

			// Token: 0x04001155 RID: 4437
			public Action<int, int, float> kfn;

			// Token: 0x04001156 RID: 4438
			public int kfo;

			// Token: 0x04001157 RID: 4439
			public Action<int, int> kfp;
		}
	}
}
