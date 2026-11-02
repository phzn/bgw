using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000228 RID: 552
	[Serializable]
	public class LanguageData : LanguageDataBase
	{
		// Token: 0x060023E6 RID: 9190 RVA: 0x0009988B File Offset: 0x00097A8B
		public override void gkj()
		{
			if (this._initialized)
			{
				return;
			}
			this.customDict = LanguageData.CustomEntry.gki(this._customEntries);
			this._initialized = true;
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x000998B0 File Offset: 0x00097AB0
		public override string gkk(string a)
		{
			if (string.IsNullOrEmpty(a))
			{
				return string.Empty;
			}
			string text;
			if (!this.customDict.TryGetValue(a, out text))
			{
				return string.Empty;
			}
			return text;
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x000998E2 File Offset: 0x00097AE2
		public override bool gkl(string a)
		{
			return !string.IsNullOrEmpty(a) && this.customDict.ContainsKey(a);
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060023E9 RID: 9193 RVA: 0x000998FA File Offset: 0x00097AFA
		public override string mcb
		{
			get
			{
				return this._yes;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x00099902 File Offset: 0x00097B02
		public override string mcc
		{
			get
			{
				return this._no;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060023EB RID: 9195 RVA: 0x0009990A File Offset: 0x00097B0A
		public override string mcd
		{
			get
			{
				return this._add;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x00099912 File Offset: 0x00097B12
		public override string mce
		{
			get
			{
				return this._replace;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060023ED RID: 9197 RVA: 0x0009991A File Offset: 0x00097B1A
		public override string mcf
		{
			get
			{
				return this._remove;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x00099922 File Offset: 0x00097B22
		public override string mcg
		{
			get
			{
				return this._swap;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060023EF RID: 9199 RVA: 0x0009992A File Offset: 0x00097B2A
		public override string mch
		{
			get
			{
				return this._cancel;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060023F0 RID: 9200 RVA: 0x00099932 File Offset: 0x00097B32
		public override string mci
		{
			get
			{
				return this._none;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x0009993A File Offset: 0x00097B3A
		public override string mcj
		{
			get
			{
				return this._okay;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x00099942 File Offset: 0x00097B42
		public override string mck
		{
			get
			{
				return this._done;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x0009994A File Offset: 0x00097B4A
		public override string mcl
		{
			get
			{
				return this._default;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x00099952 File Offset: 0x00097B52
		public override string mcm
		{
			get
			{
				return this._assignControllerWindowTitle;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x0009995A File Offset: 0x00097B5A
		public override string mcn
		{
			get
			{
				return this._assignControllerWindowMessage;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060023F6 RID: 9206 RVA: 0x00099962 File Offset: 0x00097B62
		public override string mco
		{
			get
			{
				return this._controllerAssignmentConflictWindowTitle;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x0009996A File Offset: 0x00097B6A
		public override string mcp
		{
			get
			{
				return this._elementAssignmentPrePollingWindowMessage;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060023F8 RID: 9208 RVA: 0x00099972 File Offset: 0x00097B72
		public override string mcq
		{
			get
			{
				return this._elementAssignmentConflictWindowMessage;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x0009997A File Offset: 0x00097B7A
		public override string mcr
		{
			get
			{
				return this._mouseAssignmentConflictWindowTitle;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060023FA RID: 9210 RVA: 0x00099982 File Offset: 0x00097B82
		public override string mcs
		{
			get
			{
				return this._calibrateControllerWindowTitle;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x0009998A File Offset: 0x00097B8A
		public override string mct
		{
			get
			{
				return this._calibrateAxisStep1WindowTitle;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060023FC RID: 9212 RVA: 0x00099992 File Offset: 0x00097B92
		public override string mcu
		{
			get
			{
				return this._calibrateAxisStep2WindowTitle;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060023FD RID: 9213 RVA: 0x0009999A File Offset: 0x00097B9A
		public override string mcv
		{
			get
			{
				return this._inputBehaviorSettingsWindowTitle;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060023FE RID: 9214 RVA: 0x000999A2 File Offset: 0x00097BA2
		public override string mcw
		{
			get
			{
				return this._restoreDefaultsWindowTitle;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x000999AA File Offset: 0x00097BAA
		public override string mcx
		{
			get
			{
				return this._actionColumnLabel;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x000999B2 File Offset: 0x00097BB2
		public override string mcy
		{
			get
			{
				return this._keyboardColumnLabel;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x000999BA File Offset: 0x00097BBA
		public override string mcz
		{
			get
			{
				return this._mouseColumnLabel;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06002402 RID: 9218 RVA: 0x000999C2 File Offset: 0x00097BC2
		public override string mda
		{
			get
			{
				return this._controllerColumnLabel;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x000999CA File Offset: 0x00097BCA
		public override string mdb
		{
			get
			{
				return this._removeControllerButtonLabel;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06002404 RID: 9220 RVA: 0x000999D2 File Offset: 0x00097BD2
		public override string mdc
		{
			get
			{
				return this._calibrateControllerButtonLabel;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06002405 RID: 9221 RVA: 0x000999DA File Offset: 0x00097BDA
		public override string mdd
		{
			get
			{
				return this._assignControllerButtonLabel;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06002406 RID: 9222 RVA: 0x000999E2 File Offset: 0x00097BE2
		public override string mde
		{
			get
			{
				return this._inputBehaviorSettingsButtonLabel;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06002407 RID: 9223 RVA: 0x000999EA File Offset: 0x00097BEA
		public override string mdf
		{
			get
			{
				return this._doneButtonLabel;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06002408 RID: 9224 RVA: 0x000999F2 File Offset: 0x00097BF2
		public override string mdg
		{
			get
			{
				return this._restoreDefaultsButtonLabel;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06002409 RID: 9225 RVA: 0x000999FA File Offset: 0x00097BFA
		public override string mdh
		{
			get
			{
				return this._controllerSettingsGroupLabel;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x0600240A RID: 9226 RVA: 0x00099A02 File Offset: 0x00097C02
		public override string mdi
		{
			get
			{
				return this._playersGroupLabel;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x00099A0A File Offset: 0x00097C0A
		public override string mdj
		{
			get
			{
				return this._assignedControllersGroupLabel;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x0600240C RID: 9228 RVA: 0x00099A12 File Offset: 0x00097C12
		public override string mdk
		{
			get
			{
				return this._settingsGroupLabel;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600240D RID: 9229 RVA: 0x00099A1A File Offset: 0x00097C1A
		public override string mdl
		{
			get
			{
				return this._mapCategoriesGroupLabel;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600240E RID: 9230 RVA: 0x00099A22 File Offset: 0x00097C22
		public override string mdm
		{
			get
			{
				if (ReInput.players.playerCount > 1)
				{
					return this._restoreDefaultsWindowMessage_multiPlayer;
				}
				return this._restoreDefaultsWindowMessage_onePlayer;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x00099A3E File Offset: 0x00097C3E
		public override string mdn
		{
			get
			{
				return this._calibrateWindow_deadZoneSliderLabel;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06002410 RID: 9232 RVA: 0x00099A46 File Offset: 0x00097C46
		public override string mdo
		{
			get
			{
				return this._calibrateWindow_zeroSliderLabel;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06002411 RID: 9233 RVA: 0x00099A4E File Offset: 0x00097C4E
		public override string mdp
		{
			get
			{
				return this._calibrateWindow_sensitivitySliderLabel;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06002412 RID: 9234 RVA: 0x00099A56 File Offset: 0x00097C56
		public override string mdq
		{
			get
			{
				return this._calibrateWindow_invertToggleLabel;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06002413 RID: 9235 RVA: 0x00099A5E File Offset: 0x00097C5E
		public override string mdr
		{
			get
			{
				return this._calibrateWindow_calibrateButtonLabel;
			}
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x00099A66 File Offset: 0x00097C66
		public override string gmd(string a, string b, string c)
		{
			return string.Format(this._controllerAssignmentConflictWindowMessage, a, b, c);
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x00099A76 File Offset: 0x00097C76
		public override string gme(string a)
		{
			return string.Format(this._joystickElementAssignmentPollingWindowMessage, a);
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x00099A84 File Offset: 0x00097C84
		public override string gmf(string a)
		{
			return string.Format(this._joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly, a);
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x00099A92 File Offset: 0x00097C92
		public override string gmg(string a)
		{
			return string.Format(this._keyboardElementAssignmentPollingWindowMessage, a);
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x00099AA0 File Offset: 0x00097CA0
		public override string gmh(string a)
		{
			return string.Format(this._mouseElementAssignmentPollingWindowMessage, a);
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x00099AAE File Offset: 0x00097CAE
		public override string gmi(string a)
		{
			return string.Format(this._mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly, a);
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x00099ABC File Offset: 0x00097CBC
		public override string gmj(string a)
		{
			return string.Format(this._elementAlreadyInUseBlocked, a);
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x00099ACA File Offset: 0x00097CCA
		public override string gmk(string a, bool b)
		{
			if (!b)
			{
				return string.Format(this._elementAlreadyInUseCanReplace, a);
			}
			return string.Format(this._elementAlreadyInUseCanReplace_conflictAllowed, a);
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x00099AE8 File Offset: 0x00097CE8
		public override string gml(string a, string b)
		{
			return string.Format(this._mouseAssignmentConflictWindowMessage, a, b);
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x00099AF7 File Offset: 0x00097CF7
		public override string gmm(string a)
		{
			return string.Format(this._calibrateAxisStep1WindowMessage, a);
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x00099B05 File Offset: 0x00097D05
		public override string gmn(string a)
		{
			return string.Format(this._calibrateAxisStep2WindowMessage, a);
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x00099B13 File Offset: 0x00097D13
		public override string gmo(int a)
		{
			Player player = ReInput.players.GetPlayer(a);
			if (player == null)
			{
				throw new ArgumentException(a.evn() + a.ToString());
			}
			return player.descriptiveName;
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x00099B3F File Offset: 0x00097D3F
		public override string gmp(Controller a)
		{
			if (a == null)
			{
				throw new ArgumentNullException(a.evo());
			}
			return a.name;
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x00099B58 File Offset: 0x00097D58
		public override string gmq(ActionElementMap a)
		{
			if (a == null)
			{
				throw new ArgumentNullException(a.evp());
			}
			if (base.mds)
			{
				return a.elementIdentifierName;
			}
			if (a.controllerMap.controllerType == ControllerType.Keyboard)
			{
				return this.gms(a.keyCode, a.modifierKeyFlags);
			}
			return this.gmr(a.controllerMap.controller, a.elementIdentifierId, a.axisRange);
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x00099BC0 File Offset: 0x00097DC0
		public override string gmr(Controller a, int b, AxisRange c)
		{
			if (a == null)
			{
				throw new ArgumentNullException(a.evo());
			}
			ControllerElementIdentifier elementIdentifierById = a.GetElementIdentifierById(b);
			if (elementIdentifierById == null)
			{
				throw new ArgumentException(a.evq() + b.ToString());
			}
			Controller.Element elementById = a.GetElementById(b);
			if (elementById == null)
			{
				return string.Empty;
			}
			return elementIdentifierById.GetDisplayName(elementById.type, c);
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x00099C1B File Offset: 0x00097E1B
		public override string gms(KeyCode a, ModifierKeyFlags b)
		{
			if (base.mds)
			{
				return Keyboard.GetKeyName(a, b);
			}
			if (b != ModifierKeyFlags.None)
			{
				return string.Format(a.evr(), this.gmy(b), this._modifierKeys.separator, Keyboard.GetKeyName(a));
			}
			return Keyboard.GetKeyName(a);
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x00099C59 File Offset: 0x00097E59
		public override string gmt(int a)
		{
			InputAction action = ReInput.mapping.GetAction(a);
			if (action == null)
			{
				throw new ArgumentException(a.evs() + a.ToString());
			}
			return action.descriptiveName;
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x00099C88 File Offset: 0x00097E88
		public override string gmu(int a, AxisRange b)
		{
			InputAction action = ReInput.mapping.GetAction(a);
			if (action == null)
			{
				throw new ArgumentException(a.evs() + a.ToString());
			}
			if (base.mds)
			{
				return action.GetDisplayName(b);
			}
			switch (b)
			{
			case AxisRange.Full:
				return action.descriptiveName;
			case AxisRange.Positive:
				if (string.IsNullOrEmpty(action.positiveDescriptiveName))
				{
					return action.descriptiveName + a.evt();
				}
				return action.positiveDescriptiveName;
			case AxisRange.Negative:
				if (string.IsNullOrEmpty(action.negativeDescriptiveName))
				{
					return action.descriptiveName + a.evu();
				}
				return action.negativeDescriptiveName;
			default:
				throw new NotImplementedException();
			}
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x00099D35 File Offset: 0x00097F35
		public override string gmv(int a)
		{
			InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(a);
			if (mapCategory == null)
			{
				throw new ArgumentException(a.evv() + a.ToString());
			}
			return mapCategory.descriptiveName;
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x00099D61 File Offset: 0x00097F61
		public override string gmw(int a)
		{
			InputCategory actionCategory = ReInput.mapping.GetActionCategory(a);
			if (actionCategory == null)
			{
				throw new ArgumentException(a.evw() + a.ToString());
			}
			return actionCategory.descriptiveName;
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x00099D8D File Offset: 0x00097F8D
		public override string gmx(ControllerType a, int b)
		{
			InputLayout layout = ReInput.mapping.GetLayout(a, b);
			if (layout == null)
			{
				throw new ArgumentException(a.evx() + a.ToString() + a.evy() + b.ToString());
			}
			return layout.descriptiveName;
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x00099DCC File Offset: 0x00097FCC
		public override string gmy(ModifierKeyFlags a)
		{
			if (base.mds)
			{
				return Keyboard.ModifierKeyFlagsToString(a);
			}
			int num = 0;
			string text = string.Empty;
			if (Keyboard.ModifierKeyFlagsContain(a, ModifierKey.Control))
			{
				text += this._modifierKeys.control;
				num++;
			}
			if (Keyboard.ModifierKeyFlagsContain(a, ModifierKey.Command))
			{
				if (num > 0 && !string.IsNullOrEmpty(this._modifierKeys.separator))
				{
					text += this._modifierKeys.separator;
				}
				text += this._modifierKeys.command;
				num++;
			}
			if (Keyboard.ModifierKeyFlagsContain(a, ModifierKey.Alt))
			{
				if (num > 0 && !string.IsNullOrEmpty(this._modifierKeys.separator))
				{
					text += this._modifierKeys.separator;
				}
				text += this._modifierKeys.alt;
				num++;
			}
			if (num >= 3)
			{
				return text;
			}
			if (Keyboard.ModifierKeyFlagsContain(a, ModifierKey.Shift))
			{
				if (num > 0 && !string.IsNullOrEmpty(this._modifierKeys.separator))
				{
					text += this._modifierKeys.separator;
				}
				text += this._modifierKeys.shift;
				num++;
			}
			return text;
		}

		// Token: 0x04001162 RID: 4450
		[SerializeField]
		private string _yes = a.evz();

		// Token: 0x04001163 RID: 4451
		[SerializeField]
		private string _no = a.ewa();

		// Token: 0x04001164 RID: 4452
		[SerializeField]
		private string _add = a.ewb();

		// Token: 0x04001165 RID: 4453
		[SerializeField]
		private string _replace = a.ewc();

		// Token: 0x04001166 RID: 4454
		[SerializeField]
		private string _remove = a.ewd();

		// Token: 0x04001167 RID: 4455
		[SerializeField]
		private string _swap = a.ewe();

		// Token: 0x04001168 RID: 4456
		[SerializeField]
		private string _cancel = a.ewf();

		// Token: 0x04001169 RID: 4457
		[SerializeField]
		private string _none = a.bzb();

		// Token: 0x0400116A RID: 4458
		[SerializeField]
		private string _okay = a.ewg();

		// Token: 0x0400116B RID: 4459
		[SerializeField]
		private string _done = a.eul();

		// Token: 0x0400116C RID: 4460
		[SerializeField]
		private string _default = a.ewh();

		// Token: 0x0400116D RID: 4461
		[SerializeField]
		private string _assignControllerWindowTitle = a.ewi();

		// Token: 0x0400116E RID: 4462
		[SerializeField]
		private string _assignControllerWindowMessage = a.ewj();

		// Token: 0x0400116F RID: 4463
		[SerializeField]
		private string _controllerAssignmentConflictWindowTitle = a.ewk();

		// Token: 0x04001170 RID: 4464
		[SerializeField]
		private string _controllerAssignmentConflictWindowMessage = a.ewl();

		// Token: 0x04001171 RID: 4465
		[SerializeField]
		private string _elementAssignmentPrePollingWindowMessage = a.ewm();

		// Token: 0x04001172 RID: 4466
		[SerializeField]
		private string _joystickElementAssignmentPollingWindowMessage = a.ewn();

		// Token: 0x04001173 RID: 4467
		[SerializeField]
		private string _joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly = a.ewo();

		// Token: 0x04001174 RID: 4468
		[SerializeField]
		private string _keyboardElementAssignmentPollingWindowMessage = a.ewp();

		// Token: 0x04001175 RID: 4469
		[SerializeField]
		private string _mouseElementAssignmentPollingWindowMessage = a.ewq();

		// Token: 0x04001176 RID: 4470
		[SerializeField]
		private string _mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly = a.ewr();

		// Token: 0x04001177 RID: 4471
		[SerializeField]
		private string _elementAssignmentConflictWindowMessage = a.ews();

		// Token: 0x04001178 RID: 4472
		[SerializeField]
		private string _elementAlreadyInUseBlocked = a.ewt();

		// Token: 0x04001179 RID: 4473
		[SerializeField]
		private string _elementAlreadyInUseCanReplace = a.ewu();

		// Token: 0x0400117A RID: 4474
		[SerializeField]
		private string _elementAlreadyInUseCanReplace_conflictAllowed = a.ewv();

		// Token: 0x0400117B RID: 4475
		[SerializeField]
		private string _mouseAssignmentConflictWindowTitle = a.eww();

		// Token: 0x0400117C RID: 4476
		[SerializeField]
		private string _mouseAssignmentConflictWindowMessage = a.ewx();

		// Token: 0x0400117D RID: 4477
		[SerializeField]
		private string _calibrateControllerWindowTitle = a.ewy();

		// Token: 0x0400117E RID: 4478
		[SerializeField]
		private string _calibrateAxisStep1WindowTitle = a.ewz();

		// Token: 0x0400117F RID: 4479
		[SerializeField]
		private string _calibrateAxisStep1WindowMessage = a.exa();

		// Token: 0x04001180 RID: 4480
		[SerializeField]
		private string _calibrateAxisStep2WindowTitle = a.exb();

		// Token: 0x04001181 RID: 4481
		[SerializeField]
		private string _calibrateAxisStep2WindowMessage = a.exc();

		// Token: 0x04001182 RID: 4482
		[SerializeField]
		private string _inputBehaviorSettingsWindowTitle = a.exd();

		// Token: 0x04001183 RID: 4483
		[SerializeField]
		private string _restoreDefaultsWindowTitle = a.exe();

		// Token: 0x04001184 RID: 4484
		[SerializeField]
		private string _restoreDefaultsWindowMessage_onePlayer = a.exf();

		// Token: 0x04001185 RID: 4485
		[SerializeField]
		private string _restoreDefaultsWindowMessage_multiPlayer = a.exg();

		// Token: 0x04001186 RID: 4486
		[SerializeField]
		private string _actionColumnLabel = a.exh();

		// Token: 0x04001187 RID: 4487
		[SerializeField]
		private string _keyboardColumnLabel = a.exi();

		// Token: 0x04001188 RID: 4488
		[SerializeField]
		private string _mouseColumnLabel = a.exj();

		// Token: 0x04001189 RID: 4489
		[SerializeField]
		private string _controllerColumnLabel = a.exk();

		// Token: 0x0400118A RID: 4490
		[SerializeField]
		private string _removeControllerButtonLabel = a.ewd();

		// Token: 0x0400118B RID: 4491
		[SerializeField]
		private string _calibrateControllerButtonLabel = a.exl();

		// Token: 0x0400118C RID: 4492
		[SerializeField]
		private string _assignControllerButtonLabel = a.exm();

		// Token: 0x0400118D RID: 4493
		[SerializeField]
		private string _inputBehaviorSettingsButtonLabel = a.exn();

		// Token: 0x0400118E RID: 4494
		[SerializeField]
		private string _doneButtonLabel = a.eul();

		// Token: 0x0400118F RID: 4495
		[SerializeField]
		private string _restoreDefaultsButtonLabel = a.exe();

		// Token: 0x04001190 RID: 4496
		[SerializeField]
		private string _playersGroupLabel = a.exo();

		// Token: 0x04001191 RID: 4497
		[SerializeField]
		private string _controllerSettingsGroupLabel = a.exp();

		// Token: 0x04001192 RID: 4498
		[SerializeField]
		private string _assignedControllersGroupLabel = a.exq();

		// Token: 0x04001193 RID: 4499
		[SerializeField]
		private string _settingsGroupLabel = a.exr();

		// Token: 0x04001194 RID: 4500
		[SerializeField]
		private string _mapCategoriesGroupLabel = a.exs();

		// Token: 0x04001195 RID: 4501
		[SerializeField]
		private string _calibrateWindow_deadZoneSliderLabel = a.ext();

		// Token: 0x04001196 RID: 4502
		[SerializeField]
		private string _calibrateWindow_zeroSliderLabel = a.exu();

		// Token: 0x04001197 RID: 4503
		[SerializeField]
		private string _calibrateWindow_sensitivitySliderLabel = a.exv();

		// Token: 0x04001198 RID: 4504
		[SerializeField]
		private string _calibrateWindow_invertToggleLabel = a.exw();

		// Token: 0x04001199 RID: 4505
		[SerializeField]
		private string _calibrateWindow_calibrateButtonLabel = a.exl();

		// Token: 0x0400119A RID: 4506
		[SerializeField]
		private LanguageData.ModifierKeys _modifierKeys;

		// Token: 0x0400119B RID: 4507
		[SerializeField]
		private LanguageData.CustomEntry[] _customEntries;

		// Token: 0x0400119C RID: 4508
		private bool _initialized;

		// Token: 0x0400119D RID: 4509
		private Dictionary<string, string> customDict;

		// Token: 0x02000229 RID: 553
		[Serializable]
		protected class CustomEntry
		{
			// Token: 0x0600242B RID: 9259 RVA: 0x00002854 File Offset: 0x00000A54
			public CustomEntry()
			{
			}

			// Token: 0x0600242C RID: 9260 RVA: 0x0009A167 File Offset: 0x00098367
			public CustomEntry(string key, string value)
			{
				this.key = key;
				this.value = value;
			}

			// Token: 0x0600242D RID: 9261 RVA: 0x0009A180 File Offset: 0x00098380
			public static Dictionary<string, string> gki(LanguageData.CustomEntry[] a)
			{
				if (a == null)
				{
					return new Dictionary<string, string>();
				}
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				for (int i = 0; i < a.Length; i++)
				{
					if (a[i] != null && !string.IsNullOrEmpty(a[i].key) && !string.IsNullOrEmpty(a[i].value))
					{
						if (dictionary.ContainsKey(a[i].key))
						{
							Debug.LogError(a.evg() + a[i].key + a.evh());
						}
						else
						{
							dictionary.Add(a[i].key, a[i].value);
						}
					}
				}
				return dictionary;
			}

			// Token: 0x0400119E RID: 4510
			public string key;

			// Token: 0x0400119F RID: 4511
			public string value;
		}

		// Token: 0x0200022A RID: 554
		[Serializable]
		protected class ModifierKeys
		{
			// Token: 0x040011A0 RID: 4512
			public string control = a.evi();

			// Token: 0x040011A1 RID: 4513
			public string alt = a.evj();

			// Token: 0x040011A2 RID: 4514
			public string shift = a.evk();

			// Token: 0x040011A3 RID: 4515
			public string command = a.evl();

			// Token: 0x040011A4 RID: 4516
			public string separator = a.evm();
		}
	}
}
