using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Rewired.Glyphs;
using Rewired.Glyphs.UnityUI;
using Rewired.Utils;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020001F8 RID: 504
	public class ControlMapper : MonoBehaviour
	{
		// Token: 0x14000047 RID: 71
		// (add) Token: 0x06001FA8 RID: 8104 RVA: 0x0008C990 File Offset: 0x0008AB90
		// (remove) Token: 0x06001FA9 RID: 8105 RVA: 0x0008C9A9 File Offset: 0x0008ABA9
		public event Action mhf
		{
			add
			{
				this.kdt = (Action)Delegate.Combine(this.kdt, value);
			}
			remove
			{
				this.kdt = (Action)Delegate.Remove(this.kdt, value);
			}
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x06001FAA RID: 8106 RVA: 0x0008C9C2 File Offset: 0x0008ABC2
		// (remove) Token: 0x06001FAB RID: 8107 RVA: 0x0008C9DB File Offset: 0x0008ABDB
		public event Action mhg
		{
			add
			{
				this.kdu = (Action)Delegate.Combine(this.kdu, value);
			}
			remove
			{
				this.kdu = (Action)Delegate.Remove(this.kdu, value);
			}
		}

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x06001FAC RID: 8108 RVA: 0x0008C9F4 File Offset: 0x0008ABF4
		// (remove) Token: 0x06001FAD RID: 8109 RVA: 0x0008CA0D File Offset: 0x0008AC0D
		public event Action mhh
		{
			add
			{
				this.kdw = (Action)Delegate.Combine(this.kdw, value);
			}
			remove
			{
				this.kdw = (Action)Delegate.Remove(this.kdw, value);
			}
		}

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x06001FAE RID: 8110 RVA: 0x0008CA26 File Offset: 0x0008AC26
		// (remove) Token: 0x06001FAF RID: 8111 RVA: 0x0008CA3F File Offset: 0x0008AC3F
		public event Action mhi
		{
			add
			{
				this.kdv = (Action)Delegate.Combine(this.kdv, value);
			}
			remove
			{
				this.kdv = (Action)Delegate.Remove(this.kdv, value);
			}
		}

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x06001FB0 RID: 8112 RVA: 0x0008CA58 File Offset: 0x0008AC58
		// (remove) Token: 0x06001FB1 RID: 8113 RVA: 0x0008CA71 File Offset: 0x0008AC71
		public event Action mhj
		{
			add
			{
				this.kdx = (Action)Delegate.Combine(this.kdx, value);
			}
			remove
			{
				this.kdx = (Action)Delegate.Remove(this.kdx, value);
			}
		}

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x06001FB2 RID: 8114 RVA: 0x0008CA8A File Offset: 0x0008AC8A
		// (remove) Token: 0x06001FB3 RID: 8115 RVA: 0x0008CAA3 File Offset: 0x0008ACA3
		public event Action mhk
		{
			add
			{
				this.kdy = (Action)Delegate.Combine(this.kdy, value);
			}
			remove
			{
				this.kdy = (Action)Delegate.Remove(this.kdy, value);
			}
		}

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x06001FB4 RID: 8116 RVA: 0x0008CABC File Offset: 0x0008ACBC
		// (remove) Token: 0x06001FB5 RID: 8117 RVA: 0x0008CACA File Offset: 0x0008ACCA
		public event UnityAction mhl
		{
			add
			{
				this._onScreenClosed.AddListener(value);
			}
			remove
			{
				this._onScreenClosed.RemoveListener(value);
			}
		}

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x06001FB6 RID: 8118 RVA: 0x0008CAD8 File Offset: 0x0008ACD8
		// (remove) Token: 0x06001FB7 RID: 8119 RVA: 0x0008CAE6 File Offset: 0x0008ACE6
		public event UnityAction mhm
		{
			add
			{
				this._onScreenOpened.AddListener(value);
			}
			remove
			{
				this._onScreenOpened.RemoveListener(value);
			}
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x06001FB8 RID: 8120 RVA: 0x0008CAF4 File Offset: 0x0008ACF4
		// (remove) Token: 0x06001FB9 RID: 8121 RVA: 0x0008CB02 File Offset: 0x0008AD02
		public event UnityAction mhn
		{
			add
			{
				this._onPopupWindowClosed.AddListener(value);
			}
			remove
			{
				this._onPopupWindowClosed.RemoveListener(value);
			}
		}

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x06001FBA RID: 8122 RVA: 0x0008CB10 File Offset: 0x0008AD10
		// (remove) Token: 0x06001FBB RID: 8123 RVA: 0x0008CB1E File Offset: 0x0008AD1E
		public event UnityAction mho
		{
			add
			{
				this._onPopupWindowOpened.AddListener(value);
			}
			remove
			{
				this._onPopupWindowOpened.RemoveListener(value);
			}
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x06001FBC RID: 8124 RVA: 0x0008CB2C File Offset: 0x0008AD2C
		// (remove) Token: 0x06001FBD RID: 8125 RVA: 0x0008CB3A File Offset: 0x0008AD3A
		public event UnityAction mhp
		{
			add
			{
				this._onInputPollingStarted.AddListener(value);
			}
			remove
			{
				this._onInputPollingStarted.RemoveListener(value);
			}
		}

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x06001FBE RID: 8126 RVA: 0x0008CB48 File Offset: 0x0008AD48
		// (remove) Token: 0x06001FBF RID: 8127 RVA: 0x0008CB56 File Offset: 0x0008AD56
		public event UnityAction mhq
		{
			add
			{
				this._onInputPollingEnded.AddListener(value);
			}
			remove
			{
				this._onInputPollingEnded.RemoveListener(value);
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x0008CB64 File Offset: 0x0008AD64
		// (set) Token: 0x06001FC1 RID: 8129 RVA: 0x0008CB6C File Offset: 0x0008AD6C
		public InputManager lza
		{
			get
			{
				return this._rewiredInputManager;
			}
			set
			{
				this._rewiredInputManager = value;
				this.ggw(true);
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x0008CB7C File Offset: 0x0008AD7C
		// (set) Token: 0x06001FC3 RID: 8131 RVA: 0x0008CB84 File Offset: 0x0008AD84
		public bool lzb
		{
			get
			{
				return this._dontDestroyOnLoad;
			}
			set
			{
				if (value != this._dontDestroyOnLoad && value)
				{
					global::UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
				}
				this._dontDestroyOnLoad = value;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001FC4 RID: 8132 RVA: 0x0008CBA9 File Offset: 0x0008ADA9
		// (set) Token: 0x06001FC5 RID: 8133 RVA: 0x0008CBB1 File Offset: 0x0008ADB1
		public int lzc
		{
			get
			{
				return this._keyboardMapDefaultLayout;
			}
			set
			{
				this._keyboardMapDefaultLayout = value;
				this.ggw(true);
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x0008CBC1 File Offset: 0x0008ADC1
		// (set) Token: 0x06001FC7 RID: 8135 RVA: 0x0008CBC9 File Offset: 0x0008ADC9
		public int lzd
		{
			get
			{
				return this._mouseMapDefaultLayout;
			}
			set
			{
				this._mouseMapDefaultLayout = value;
				this.ggw(true);
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x0008CBD9 File Offset: 0x0008ADD9
		// (set) Token: 0x06001FC9 RID: 8137 RVA: 0x0008CBE1 File Offset: 0x0008ADE1
		public int lze
		{
			get
			{
				return this._joystickMapDefaultLayout;
			}
			set
			{
				this._joystickMapDefaultLayout = value;
				this.ggw(true);
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001FCA RID: 8138 RVA: 0x0008CBF1 File Offset: 0x0008ADF1
		// (set) Token: 0x06001FCB RID: 8139 RVA: 0x0008CC0A File Offset: 0x0008AE0A
		public bool lzf
		{
			get
			{
				return this._showPlayers && ReInput.players.playerCount > 1;
			}
			set
			{
				this._showPlayers = value;
				this.ggw(true);
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x0008CC1A File Offset: 0x0008AE1A
		// (set) Token: 0x06001FCD RID: 8141 RVA: 0x0008CC22 File Offset: 0x0008AE22
		public bool lzg
		{
			get
			{
				return this._showControllers;
			}
			set
			{
				this._showControllers = value;
				this.ggw(true);
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x0008CC32 File Offset: 0x0008AE32
		// (set) Token: 0x06001FCF RID: 8143 RVA: 0x0008CC3A File Offset: 0x0008AE3A
		public bool lzh
		{
			get
			{
				return this._showKeyboard;
			}
			set
			{
				this._showKeyboard = value;
				this.ggw(true);
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x0008CC4A File Offset: 0x0008AE4A
		// (set) Token: 0x06001FD1 RID: 8145 RVA: 0x0008CC52 File Offset: 0x0008AE52
		public bool lzi
		{
			get
			{
				return this._showMouse;
			}
			set
			{
				this._showMouse = value;
				this.ggw(true);
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x0008CC62 File Offset: 0x0008AE62
		// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x0008CC6A File Offset: 0x0008AE6A
		public int lzj
		{
			get
			{
				return this._maxControllersPerPlayer;
			}
			set
			{
				this._maxControllersPerPlayer = value;
				this.ggw(true);
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x0008CC7A File Offset: 0x0008AE7A
		// (set) Token: 0x06001FD5 RID: 8149 RVA: 0x0008CC82 File Offset: 0x0008AE82
		public bool lzk
		{
			get
			{
				return this._showActionCategoryLabels;
			}
			set
			{
				this._showActionCategoryLabels = value;
				this.ggw(true);
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x0008CC92 File Offset: 0x0008AE92
		// (set) Token: 0x06001FD7 RID: 8151 RVA: 0x0008CC9A File Offset: 0x0008AE9A
		public int lzl
		{
			get
			{
				return this._keyboardInputFieldCount;
			}
			set
			{
				this._keyboardInputFieldCount = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x0008CCAA File Offset: 0x0008AEAA
		// (set) Token: 0x06001FD9 RID: 8153 RVA: 0x0008CCB2 File Offset: 0x0008AEB2
		public int lzm
		{
			get
			{
				return this._mouseInputFieldCount;
			}
			set
			{
				this._mouseInputFieldCount = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001FDA RID: 8154 RVA: 0x0008CCC2 File Offset: 0x0008AEC2
		// (set) Token: 0x06001FDB RID: 8155 RVA: 0x0008CCCA File Offset: 0x0008AECA
		public int lzn
		{
			get
			{
				return this._controllerInputFieldCount;
			}
			set
			{
				this._controllerInputFieldCount = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001FDC RID: 8156 RVA: 0x0008CCDA File Offset: 0x0008AEDA
		// (set) Token: 0x06001FDD RID: 8157 RVA: 0x0008CCE2 File Offset: 0x0008AEE2
		public bool lzo
		{
			get
			{
				return this._showFullAxisInputFields;
			}
			set
			{
				this._showFullAxisInputFields = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001FDE RID: 8158 RVA: 0x0008CCF2 File Offset: 0x0008AEF2
		// (set) Token: 0x06001FDF RID: 8159 RVA: 0x0008CCFA File Offset: 0x0008AEFA
		public bool lzp
		{
			get
			{
				return this._showSplitAxisInputFields;
			}
			set
			{
				this._showSplitAxisInputFields = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x0008CD0A File Offset: 0x0008AF0A
		// (set) Token: 0x06001FE1 RID: 8161 RVA: 0x0008CD12 File Offset: 0x0008AF12
		public bool lzq
		{
			get
			{
				return this._showGlyphs;
			}
			set
			{
				this._showGlyphs = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x0008CD22 File Offset: 0x0008AF22
		// (set) Token: 0x06001FE3 RID: 8163 RVA: 0x0008CD2A File Offset: 0x0008AF2A
		public bool lzr
		{
			get
			{
				return this._allowElementAssignmentConflicts;
			}
			set
			{
				this._allowElementAssignmentConflicts = value;
				this.ggw(false);
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x0008CD3A File Offset: 0x0008AF3A
		// (set) Token: 0x06001FE5 RID: 8165 RVA: 0x0008CD42 File Offset: 0x0008AF42
		public bool lzs
		{
			get
			{
				return this._allowElementAssignmentSwap;
			}
			set
			{
				this._allowElementAssignmentSwap = value;
				this.ggw(false);
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x0008CD52 File Offset: 0x0008AF52
		// (set) Token: 0x06001FE7 RID: 8167 RVA: 0x0008CD5A File Offset: 0x0008AF5A
		public int lzt
		{
			get
			{
				return this._actionLabelWidth;
			}
			set
			{
				this._actionLabelWidth = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x0008CD6A File Offset: 0x0008AF6A
		// (set) Token: 0x06001FE9 RID: 8169 RVA: 0x0008CD72 File Offset: 0x0008AF72
		public int lzu
		{
			get
			{
				return this._keyboardColMaxWidth;
			}
			set
			{
				this._keyboardColMaxWidth = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001FEA RID: 8170 RVA: 0x0008CD82 File Offset: 0x0008AF82
		// (set) Token: 0x06001FEB RID: 8171 RVA: 0x0008CD8A File Offset: 0x0008AF8A
		public int lzv
		{
			get
			{
				return this._mouseColMaxWidth;
			}
			set
			{
				this._mouseColMaxWidth = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001FEC RID: 8172 RVA: 0x0008CD9A File Offset: 0x0008AF9A
		// (set) Token: 0x06001FED RID: 8173 RVA: 0x0008CDA2 File Offset: 0x0008AFA2
		public int lzw
		{
			get
			{
				return this._controllerColMaxWidth;
			}
			set
			{
				this._controllerColMaxWidth = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001FEE RID: 8174 RVA: 0x0008CDB2 File Offset: 0x0008AFB2
		// (set) Token: 0x06001FEF RID: 8175 RVA: 0x0008CDBA File Offset: 0x0008AFBA
		public int lzx
		{
			get
			{
				return this._inputRowHeight;
			}
			set
			{
				this._inputRowHeight = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001FF0 RID: 8176 RVA: 0x0008CDCA File Offset: 0x0008AFCA
		// (set) Token: 0x06001FF1 RID: 8177 RVA: 0x0008CDD2 File Offset: 0x0008AFD2
		public int lzy
		{
			get
			{
				return this._inputColumnSpacing;
			}
			set
			{
				this._inputColumnSpacing = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001FF2 RID: 8178 RVA: 0x0008CDE2 File Offset: 0x0008AFE2
		// (set) Token: 0x06001FF3 RID: 8179 RVA: 0x0008CDEA File Offset: 0x0008AFEA
		public int lzz
		{
			get
			{
				return this._inputRowCategorySpacing;
			}
			set
			{
				this._inputRowCategorySpacing = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x0008CDFA File Offset: 0x0008AFFA
		// (set) Token: 0x06001FF5 RID: 8181 RVA: 0x0008CE02 File Offset: 0x0008B002
		public int maa
		{
			get
			{
				return this._invertToggleWidth;
			}
			set
			{
				this._invertToggleWidth = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x0008CE12 File Offset: 0x0008B012
		// (set) Token: 0x06001FF7 RID: 8183 RVA: 0x0008CE1A File Offset: 0x0008B01A
		public int mab
		{
			get
			{
				return this._defaultWindowWidth;
			}
			set
			{
				this._defaultWindowWidth = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001FF8 RID: 8184 RVA: 0x0008CE2A File Offset: 0x0008B02A
		// (set) Token: 0x06001FF9 RID: 8185 RVA: 0x0008CE32 File Offset: 0x0008B032
		public int mac
		{
			get
			{
				return this._defaultWindowHeight;
			}
			set
			{
				this._defaultWindowHeight = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001FFA RID: 8186 RVA: 0x0008CE42 File Offset: 0x0008B042
		// (set) Token: 0x06001FFB RID: 8187 RVA: 0x0008CE4A File Offset: 0x0008B04A
		public float mad
		{
			get
			{
				return this._controllerAssignmentTimeout;
			}
			set
			{
				this._controllerAssignmentTimeout = value;
				this.ggw(false);
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001FFC RID: 8188 RVA: 0x0008CE5A File Offset: 0x0008B05A
		// (set) Token: 0x06001FFD RID: 8189 RVA: 0x0008CE62 File Offset: 0x0008B062
		public float mae
		{
			get
			{
				return this._preInputAssignmentTimeout;
			}
			set
			{
				this._preInputAssignmentTimeout = value;
				this.ggw(false);
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001FFE RID: 8190 RVA: 0x0008CE72 File Offset: 0x0008B072
		// (set) Token: 0x06001FFF RID: 8191 RVA: 0x0008CE7A File Offset: 0x0008B07A
		public float maf
		{
			get
			{
				return this._inputAssignmentTimeout;
			}
			set
			{
				this._inputAssignmentTimeout = value;
				this.ggw(false);
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x0008CE8A File Offset: 0x0008B08A
		// (set) Token: 0x06002001 RID: 8193 RVA: 0x0008CE92 File Offset: 0x0008B092
		public float mag
		{
			get
			{
				return this._axisCalibrationTimeout;
			}
			set
			{
				this._axisCalibrationTimeout = value;
				this.ggw(false);
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x0008CEA2 File Offset: 0x0008B0A2
		// (set) Token: 0x06002003 RID: 8195 RVA: 0x0008CEAA File Offset: 0x0008B0AA
		public bool mah
		{
			get
			{
				return this._ignoreMouseXAxisAssignment;
			}
			set
			{
				this._ignoreMouseXAxisAssignment = value;
				this.ggw(false);
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x0008CEBA File Offset: 0x0008B0BA
		// (set) Token: 0x06002005 RID: 8197 RVA: 0x0008CEC2 File Offset: 0x0008B0C2
		public bool mai
		{
			get
			{
				return this._ignoreMouseYAxisAssignment;
			}
			set
			{
				this._ignoreMouseYAxisAssignment = value;
				this.ggw(false);
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x0008CED2 File Offset: 0x0008B0D2
		// (set) Token: 0x06002007 RID: 8199 RVA: 0x0008CEDA File Offset: 0x0008B0DA
		public bool maj
		{
			get
			{
				return this._universalCancelClosesScreen;
			}
			set
			{
				this._universalCancelClosesScreen = value;
				this.ggw(false);
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x0008CEEA File Offset: 0x0008B0EA
		// (set) Token: 0x06002009 RID: 8201 RVA: 0x0008CEF2 File Offset: 0x0008B0F2
		public bool mak
		{
			get
			{
				return this._showInputBehaviorSettings;
			}
			set
			{
				this._showInputBehaviorSettings = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x0600200A RID: 8202 RVA: 0x0008CF02 File Offset: 0x0008B102
		// (set) Token: 0x0600200B RID: 8203 RVA: 0x0008CF0A File Offset: 0x0008B10A
		public bool mal
		{
			get
			{
				return this._useThemeSettings;
			}
			set
			{
				this._useThemeSettings = value;
				this.ggw(true);
				if (value)
				{
					this.ghe();
				}
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x0600200C RID: 8204 RVA: 0x0008CF23 File Offset: 0x0008B123
		// (set) Token: 0x0600200D RID: 8205 RVA: 0x0008CF2B File Offset: 0x0008B12B
		public ThemeSettings mam
		{
			get
			{
				return this._themeSettings;
			}
			set
			{
				this._themeSettings = value;
				this.ggw(true);
				this.ghe();
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x0008CF41 File Offset: 0x0008B141
		// (set) Token: 0x0600200F RID: 8207 RVA: 0x0008CF49 File Offset: 0x0008B149
		public LanguageDataBase man
		{
			get
			{
				return this._language;
			}
			set
			{
				this._language = value;
				if (this._language != null)
				{
					this._language.gkj();
				}
				this.ggw(true);
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x0008CF72 File Offset: 0x0008B172
		// (set) Token: 0x06002011 RID: 8209 RVA: 0x0008CF7A File Offset: 0x0008B17A
		public bool mao
		{
			get
			{
				return this._showPlayersGroupLabel;
			}
			set
			{
				this._showPlayersGroupLabel = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x0008CF8A File Offset: 0x0008B18A
		// (set) Token: 0x06002013 RID: 8211 RVA: 0x0008CF92 File Offset: 0x0008B192
		public bool maq
		{
			get
			{
				return this._showControllerGroupLabel;
			}
			set
			{
				this._showControllerGroupLabel = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x0008CFA2 File Offset: 0x0008B1A2
		// (set) Token: 0x06002015 RID: 8213 RVA: 0x0008CFAA File Offset: 0x0008B1AA
		public bool mar
		{
			get
			{
				return this._showAssignedControllersGroupLabel;
			}
			set
			{
				this._showAssignedControllersGroupLabel = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06002016 RID: 8214 RVA: 0x0008CFBA File Offset: 0x0008B1BA
		// (set) Token: 0x06002017 RID: 8215 RVA: 0x0008CFC2 File Offset: 0x0008B1C2
		public bool mas
		{
			get
			{
				return this._showSettingsGroupLabel;
			}
			set
			{
				this._showSettingsGroupLabel = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x0008CFD2 File Offset: 0x0008B1D2
		// (set) Token: 0x06002019 RID: 8217 RVA: 0x0008CFDA File Offset: 0x0008B1DA
		public bool mat
		{
			get
			{
				return this._showMapCategoriesGroupLabel;
			}
			set
			{
				this._showMapCategoriesGroupLabel = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x0008CFEA File Offset: 0x0008B1EA
		// (set) Token: 0x0600201B RID: 8219 RVA: 0x0008CFF2 File Offset: 0x0008B1F2
		public bool mau
		{
			get
			{
				return this._showControllerNameLabel;
			}
			set
			{
				this._showControllerNameLabel = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x0008D002 File Offset: 0x0008B202
		// (set) Token: 0x0600201D RID: 8221 RVA: 0x0008D00A File Offset: 0x0008B20A
		public bool mav
		{
			get
			{
				return this._showAssignedControllers;
			}
			set
			{
				this._showAssignedControllers = value;
				this.ggw(true);
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x0008D01A File Offset: 0x0008B21A
		// (set) Token: 0x0600201F RID: 8223 RVA: 0x0008D022 File Offset: 0x0008B222
		public Action maw
		{
			get
			{
				return this.kew;
			}
			set
			{
				this.kew = value;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x0008D02B File Offset: 0x0008B22B
		public bool max
		{
			get
			{
				if (!this.keb)
				{
					return this.references.lxk != null && this.references.lxk.gameObject.activeInHierarchy;
				}
				return this.kem.activeInHierarchy;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06002021 RID: 8225 RVA: 0x0008D06B File Offset: 0x0008B26B
		private bool may
		{
			get
			{
				return this.keb && !this.kee.lyw;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x0008D085 File Offset: 0x0008B285
		private bool maz
		{
			get
			{
				return this.kep <= Time.unscaledTime;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06002023 RID: 8227 RVA: 0x0008D098 File Offset: 0x0008B298
		private int mba
		{
			get
			{
				int num = 1;
				if (this._showKeyboard)
				{
					num++;
				}
				if (this._showMouse)
				{
					num++;
				}
				if (this._showControllers)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x0008D0CC File Offset: 0x0008B2CC
		private int mbb
		{
			get
			{
				return this._actionLabelWidth + (this._showKeyboard ? this._keyboardColMaxWidth : 0) + (this._showMouse ? this._mouseColMaxWidth : 0) + (this._showControllers ? this._controllerColMaxWidth : 0) + (this.mba - 1) * this._inputColumnSpacing;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06002025 RID: 8229 RVA: 0x0008D125 File Offset: 0x0008B325
		private Player mbc
		{
			get
			{
				return ReInput.players.GetPlayer(this.kef);
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x0008D137 File Offset: 0x0008B337
		private InputCategory mbd
		{
			get
			{
				return ReInput.mapping.GetMapCategory(this.keg);
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06002027 RID: 8231 RVA: 0x0008D14C File Offset: 0x0008B34C
		private ControlMapper.MappingSet mbe
		{
			get
			{
				if (this.keg < 0)
				{
					return null;
				}
				for (int i = 0; i < this._mappingSets.Length; i++)
				{
					if (this._mappingSets[i].lwd == this.keg)
					{
						return this._mappingSets[i];
					}
				}
				return null;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x0008D196 File Offset: 0x0008B396
		private Joystick mbf
		{
			get
			{
				return ReInput.controllers.GetJoystick(this.keo);
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06002029 RID: 8233 RVA: 0x0008D1A8 File Offset: 0x0008B3A8
		private bool mbg
		{
			get
			{
				return this.keo >= 0;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x0008D1B6 File Offset: 0x0008B3B6
		private GameObject mbh
		{
			get
			{
				if (!(EventSystem.current != null))
				{
					return null;
				}
				return EventSystem.current.currentSelectedGameObject;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600202B RID: 8235 RVA: 0x0008D1D1 File Offset: 0x0008B3D1
		private bool mbi
		{
			get
			{
				return this._showInputBehaviorSettings && this._inputBehaviorSettings.Length != 0;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x0600202C RID: 8236 RVA: 0x0008D1E7 File Offset: 0x0008B3E7
		private bool mbj
		{
			get
			{
				return this._mappingSets != null && this._mappingSets.Length > 1;
			}
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x0008D201 File Offset: 0x0008B401
		private void Awake()
		{
			if (this._dontDestroyOnLoad)
			{
				global::UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
			}
			this.gbq();
			if (this.max)
			{
				this.gbr();
				this.Open(true);
			}
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x0008D236 File Offset: 0x0008B436
		private void Start()
		{
			if (this._openOnStart)
			{
				this.Open(false);
			}
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x0008D247 File Offset: 0x0008B447
		private void Update()
		{
			if (!this.max)
			{
				return;
			}
			if (!this.keb)
			{
				return;
			}
			this.gga();
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x0008D261 File Offset: 0x0008B461
		private void OnDestroy()
		{
			ReInput.ControllerConnectedEvent -= this.gbs;
			ReInput.ControllerDisconnectedEvent -= this.gbt;
			ReInput.ControllerPreDisconnectEvent -= this.gbu;
			this.ggr();
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x0008D29C File Offset: 0x0008B49C
		private void gbq()
		{
			if (!ReInput.isReady)
			{
				Debug.LogError(a.ets());
				return;
			}
			this.ggq();
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x0008D2B8 File Offset: 0x0008B4B8
		private void gbr()
		{
			if (this.keb)
			{
				return;
			}
			if (!ReInput.isReady)
			{
				return;
			}
			if (this._rewiredInputManager == null)
			{
				this._rewiredInputManager = global::UnityEngine.Object.FindFirstObjectByType<InputManager>();
				if (this._rewiredInputManager == null)
				{
					Debug.LogError(a.ett());
					return;
				}
			}
			if (ControlMapper.kea != null)
			{
				Debug.LogError(a.etu());
				return;
			}
			ControlMapper.kea = this;
			if (this.prefabs == null || !this.prefabs.fop())
			{
				Debug.LogError(a.etv());
				return;
			}
			if (this.references == null || !this.references.fqj())
			{
				Debug.LogError(a.etw());
				return;
			}
			this.references.jzz = this.references.lxx.GetComponent<LayoutElement>();
			if (this.references.jzz == null)
			{
				Debug.LogError(a.etx());
				return;
			}
			if (this._showKeyboard && this._keyboardInputFieldCount < 1)
			{
				Debug.LogWarning(a.ety());
				this._keyboardInputFieldCount = 1;
			}
			if (this._showMouse && this._mouseInputFieldCount < 1)
			{
				Debug.LogWarning(a.etz());
				this._mouseInputFieldCount = 1;
			}
			if (this._showControllers && this._controllerInputFieldCount < 1)
			{
				Debug.LogWarning(a.eua());
				this._controllerInputFieldCount = 1;
			}
			if (this._maxControllersPerPlayer < 0)
			{
				Debug.LogWarning(a.eub());
				this._maxControllersPerPlayer = 0;
			}
			if (this._useThemeSettings && this._themeSettings == null)
			{
				Debug.LogWarning(a.euc());
				this._useThemeSettings = false;
			}
			if (this._language == null)
			{
				Debug.LogError(a.eud());
				return;
			}
			this._language.gkj();
			this.keu = new Action<kf>(this.gbv);
			this.kev = new Action<kj, bool>(this.gbw);
			ReInput.ControllerConnectedEvent += this.gbs;
			ReInput.ControllerDisconnectedEvent += this.gbt;
			ReInput.ControllerPreDisconnectEvent += this.gbu;
			this.kec = ReInput.players.playerCount;
			this.kem = this.references.lxk.gameObject;
			this.kee = new ControlMapper.jt(this.prefabs.lxc, this.prefabs.lxf, this.references.lxk.transform);
			this.keh = new List<ControlMapper.jb>();
			this.kei = new List<ControlMapper.jb>();
			this.kej = new List<ControlMapper.jb>();
			this.kel = new List<GameObject>();
			List<ControlMapper.MappingSet> list = new List<ControlMapper.MappingSet>(this._mappingSets.Length);
			for (int i = 0; i < this._mappingSets.Length; i++)
			{
				ControlMapper.MappingSet mappingSet = this._mappingSets[i];
				if (mappingSet != null && mappingSet.lwh)
				{
					list.Add(mappingSet);
				}
			}
			this._mappingSets = list.ToArray();
			this.keg = this._mappingSets[0].lwd;
			this.ged();
			this.gdl();
			this.gec();
			this.ggp();
			this.keb = true;
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x0008D5BE File Offset: 0x0008B7BE
		private void gbs(ControllerStatusChangedEventArgs a)
		{
			if (!this.keb)
			{
				return;
			}
			if (!this._showControllers)
			{
				return;
			}
			this.ggi();
			this.gep();
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x0008D5BE File Offset: 0x0008B7BE
		private void gbt(ControllerStatusChangedEventArgs a)
		{
			if (!this.keb)
			{
				return;
			}
			if (!this._showControllers)
			{
				return;
			}
			this.ggi();
			this.gep();
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x0008D5DE File Offset: 0x0008B7DE
		private void gbu(ControllerStatusChangedEventArgs a)
		{
			if (!this.keb)
			{
				return;
			}
			bool showControllers = this._showControllers;
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x0008D5F0 File Offset: 0x0008B7F0
		public void OnButtonActivated(ButtonInfo buttonInfo)
		{
			if (!this.keb)
			{
				return;
			}
			if (!this.maz)
			{
				return;
			}
			string identifier = buttonInfo.identifier;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(identifier);
			if (num <= 1656078790U)
			{
				if (num <= 1293854844U)
				{
					if (num != 36291085U)
					{
						if (num != 1293854844U)
						{
							return;
						}
						if (!(identifier == a.euh()))
						{
							return;
						}
						this.gcv();
						return;
					}
					else
					{
						if (!(identifier == a.euk()))
						{
							return;
						}
						this.gca(buttonInfo.intData, true);
						return;
					}
				}
				else if (num != 1619204974U)
				{
					if (num != 1656078790U)
					{
						return;
					}
					if (!(identifier == a.euj()))
					{
						return;
					}
					this.gdj();
					return;
				}
				else
				{
					if (!(identifier == a.eue()))
					{
						return;
					}
					this.gbx(buttonInfo.intData, true);
					return;
				}
			}
			else if (num <= 2379421585U)
			{
				if (num != 2139278426U)
				{
					if (num != 2379421585U)
					{
						return;
					}
					if (!(identifier == a.eul()))
					{
						return;
					}
					this.Close(true);
					return;
				}
				else
				{
					if (!(identifier == a.eui()))
					{
						return;
					}
					this.gdg();
					return;
				}
			}
			else if (num != 2857234147U)
			{
				if (num != 3019194153U)
				{
					if (num != 3496297297U)
					{
						return;
					}
					if (!(identifier == a.euf()))
					{
						return;
					}
					this.gby(buttonInfo.intData);
					return;
				}
				else
				{
					if (!(identifier == a.eug()))
					{
						return;
					}
					this.gbz();
					return;
				}
			}
			else
			{
				if (!(identifier == a.eum()))
				{
					return;
				}
				this.gcb();
				return;
			}
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x0008D76C File Offset: 0x0008B96C
		public void gbv(kf a)
		{
			if (!this.keb)
			{
				return;
			}
			if (!this.maz)
			{
				return;
			}
			if (this.mbc == null)
			{
				return;
			}
			InputAction action = ReInput.mapping.GetAction(a.kfx);
			if (action == null)
			{
				return;
			}
			AxisRange axisRange = ((action.type == InputActionType.Axis) ? a.mbz : AxisRange.Full);
			string text = this._language.gmu(action.id, axisRange);
			ControllerMap controllerMap = this.ggl(a.kfy);
			if (controllerMap == null)
			{
				return;
			}
			ActionElementMap actionElementMap = ((a.mca >= 0) ? controllerMap.GetElementMap(a.mca) : null);
			if (actionElementMap != null)
			{
				this.gcx(a, action, controllerMap, actionElementMap, text);
				return;
			}
			this.gcy(a, action, controllerMap, text);
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x0008D814 File Offset: 0x0008BA14
		public void gbw(kj a, bool b)
		{
			if (!this.keb)
			{
				return;
			}
			if (!this.maz)
			{
				return;
			}
			this.ggk(b, a.kfy, a.mca);
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x0008D83B File Offset: 0x0008BA3B
		private void gbx(int a, bool b)
		{
			if (!this.keb)
			{
				return;
			}
			this.kef = a;
			this.ggh();
			if (b)
			{
				this.gej(true, true);
			}
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x0008D85E File Offset: 0x0008BA5E
		private void gby(int a)
		{
			if (!this.keb)
			{
				return;
			}
			this.keo = a;
			this.gej(true, true);
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x0008D878 File Offset: 0x0008BA78
		private void gbz()
		{
			if (this.mbc == null)
			{
				return;
			}
			if (this.keo < 0)
			{
				return;
			}
			this.RemoveController(this.mbc, this.keo);
			this.ggi();
			this.gej(false, false);
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x0008D8AD File Offset: 0x0008BAAD
		private void gca(int a, bool b)
		{
			if (!this.keb)
			{
				return;
			}
			this.keg = a;
			if (b)
			{
				this.gej(true, true);
			}
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x0008D8CA File Offset: 0x0008BACA
		private void gcb()
		{
			if (!this.keb)
			{
				return;
			}
			this.gdk();
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x0008D8DB File Offset: 0x0008BADB
		private void gcc(InputActionEventData a)
		{
			if (!this.max)
			{
				this.Open();
				return;
			}
			if (!this.keb)
			{
				return;
			}
			if (!this.may)
			{
				return;
			}
			this.Close(true);
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x0008D905 File Offset: 0x0008BB05
		private void gcd(InputActionEventData a)
		{
			this.Open();
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x0008D90D File Offset: 0x0008BB0D
		private void gce(InputActionEventData a)
		{
			if (!this.keb)
			{
				return;
			}
			if (!this.max)
			{
				return;
			}
			if (!this.may)
			{
				return;
			}
			this.Close(true);
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x0008D931 File Offset: 0x0008BB31
		private void gcf(InputActionEventData a)
		{
			if (!this.keb)
			{
				return;
			}
			if (!this.max)
			{
				return;
			}
			if (this._universalCancelClosesScreen)
			{
				if (this.may)
				{
					this.Close(true);
					return;
				}
			}
			else if (this.may)
			{
				return;
			}
			this.gfk();
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x0008D96C File Offset: 0x0008BB6C
		private void gcg(int a)
		{
			if (!this.keb)
			{
				return;
			}
			if (a < 0)
			{
				return;
			}
			this.gfi(a);
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x0008D983 File Offset: 0x0008BB83
		private void gch(int a, ControllerMap b, ActionElementMap c)
		{
			if (b == null || c == null)
			{
				return;
			}
			b.DeleteElementMap(c.id);
			this.gfi(a);
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x0008D9A0 File Offset: 0x0008BBA0
		private void gci(kf a, ControllerMap b, ActionElementMap c, string d)
		{
			if (a == null || b == null)
			{
				return;
			}
			this.kes = new ControlMapper.ji(d, a, b, c, a.kfy, a.kfz);
			switch (a.kfy)
			{
			case ControllerType.Keyboard:
				this.gda();
				return;
			case ControllerType.Mouse:
				this.gda();
				return;
			case ControllerType.Joystick:
				this.gcz();
				return;
			default:
				throw new NotImplementedException();
			}
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x0008DA0B File Offset: 0x0008BC0B
		private void gcj(int a, Player b, int c)
		{
			if (a < 0 || b == null || c < 0)
			{
				return;
			}
			this.AssignController(b, c);
			this.gfi(a);
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x0008DA28 File Offset: 0x0008BC28
		private void gck(int a, Player b)
		{
			if (a < 0 || b == null)
			{
				return;
			}
			IList<Player> players = ReInput.players.Players;
			for (int i = 0; i < players.Count; i++)
			{
				if (players[i] != b)
				{
					players[i].controllers.hasMouse = false;
				}
			}
			b.controllers.hasMouse = true;
			this.gfi(a);
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x0008DA88 File Offset: 0x0008BC88
		private void gcl(int a, ControlMapper.ji b, ElementAssignment c, bool d, bool e)
		{
			if (this.mbc == null || b == null)
			{
				return;
			}
			ElementAssignmentConflictCheck elementAssignmentConflictCheck;
			if (!this.gfq(b, c, out elementAssignmentConflictCheck))
			{
				Debug.LogError(a.eun());
				this.gfi(a);
				return;
			}
			ElementAssignmentConflictInfo elementAssignmentConflictInfo = default(ElementAssignmentConflictInfo);
			ActionElementMap actionElementMap = null;
			ActionElementMap actionElementMap2 = null;
			bool flag = false;
			if (e && b.kan != null && this.gfs(elementAssignmentConflictCheck, out elementAssignmentConflictInfo, d))
			{
				flag = true;
				actionElementMap2 = new ActionElementMap(b.kan);
				actionElementMap = new ActionElementMap(elementAssignmentConflictInfo.elementMap);
			}
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				Player player = allPlayers[i];
				if (!d || player == this.mbc || player == ReInput.players.SystemPlayer)
				{
					player.controllers.conflictChecking.RemoveElementAssignmentConflicts(elementAssignmentConflictCheck);
				}
			}
			b.kam.ReplaceOrCreateElementMap(c);
			if (e && flag)
			{
				int actionId = actionElementMap.actionId;
				Pole axisContribution = actionElementMap.axisContribution;
				bool flag2 = actionElementMap.invert;
				AxisRange axisRange = actionElementMap2.axisRange;
				ControllerElementType elementType = actionElementMap2.elementType;
				int elementIdentifierId = actionElementMap2.elementIdentifierId;
				KeyCode keyCode = actionElementMap2.keyCode;
				ModifierKeyFlags modifierKeyFlags = actionElementMap2.modifierKeyFlags;
				if (elementType == actionElementMap.elementType && elementType == ControllerElementType.Axis)
				{
					if (axisRange != actionElementMap.axisRange)
					{
						if (axisRange == AxisRange.Full)
						{
							axisRange = AxisRange.Positive;
						}
						else if (actionElementMap.axisRange == AxisRange.Full)
						{
						}
					}
				}
				else if (elementType == ControllerElementType.Axis && (actionElementMap.elementType == ControllerElementType.Button || (actionElementMap.elementType == ControllerElementType.Axis && actionElementMap.axisRange != AxisRange.Full)) && axisRange == AxisRange.Full)
				{
					axisRange = AxisRange.Positive;
				}
				if (elementType != ControllerElementType.Axis || axisRange != AxisRange.Full)
				{
					flag2 = false;
				}
				int num = 0;
				foreach (ActionElementMap actionElementMap3 in elementAssignmentConflictInfo.controllerMap.ElementMapsWithAction(actionId))
				{
					if (this.ghd(elementType, axisRange, axisContribution, actionElementMap3.elementType, actionElementMap3.axisRange, actionElementMap3.axisContribution))
					{
						num++;
					}
				}
				if (num < this.ghb(b.kao))
				{
					elementAssignmentConflictInfo.controllerMap.ReplaceOrCreateElementMap(ElementAssignment.CompleteAssignment(b.kao, elementType, elementIdentifierId, axisRange, keyCode, modifierKeyFlags, actionId, axisContribution, flag2));
				}
			}
			this.gfi(a);
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x0008DCC4 File Offset: 0x0008BEC4
		private void gcm(int a, ControlMapper.ji b, ElementAssignment c)
		{
			if (this.mbc == null || b == null)
			{
				return;
			}
			b.kam.ReplaceOrCreateElementMap(c);
			this.gfi(a);
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x0008DCE8 File Offset: 0x0008BEE8
		private void gcn(int a)
		{
			if (this.kew == null)
			{
				IList<Player> players = ReInput.players.Players;
				for (int i = 0; i < players.Count; i++)
				{
					Player player = players[i];
					if (this._showControllers)
					{
						player.controllers.maps.LoadDefaultMaps(ControllerType.Joystick);
					}
					if (this._showKeyboard)
					{
						player.controllers.maps.LoadDefaultMaps(ControllerType.Keyboard);
					}
					if (this._showMouse)
					{
						player.controllers.maps.LoadDefaultMaps(ControllerType.Mouse);
					}
				}
			}
			this.gfi(a);
			if (this.kew != null)
			{
				this.kew();
			}
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x0008DD88 File Offset: 0x0008BF88
		private void gco(int a)
		{
			if (this.mbc == null)
			{
				return;
			}
			Window window = this.kee.fvd(a);
			if (a < 0)
			{
				return;
			}
			this.ggz();
			if (window.mgl.mga)
			{
				this.gha();
				this.gfi(a);
				return;
			}
			ControllerPollingInfo controllerPollingInfo = ReInput.controllers.polling.PollAllControllersOfTypeForFirstElementDown(ControllerType.Joystick);
			if (!controllerPollingInfo.success)
			{
				window.gtb(Mathf.CeilToInt(window.mgl.mgb).ToString(), 1);
				return;
			}
			this.gha();
			if (ReInput.controllers.IsControllerAssigned(ControllerType.Joystick, controllerPollingInfo.controllerId) && !this.mbc.controllers.ContainsController(ControllerType.Joystick, controllerPollingInfo.controllerId))
			{
				this.gcw(controllerPollingInfo.controllerId);
				return;
			}
			this.gcj(a, this.mbc, controllerPollingInfo.controllerId);
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x0008DE64 File Offset: 0x0008C064
		private void gcp(int a)
		{
			if (this.mbc == null)
			{
				return;
			}
			Window window = this.kee.fvd(a);
			if (a < 0)
			{
				return;
			}
			if (this.kes == null)
			{
				return;
			}
			this.ggz();
			if (!window.mgl.mga)
			{
				window.gtb(Mathf.CeilToInt(window.mgl.mgb).ToString(), 1);
				ControllerType controllerType = this.kes.kao;
				ControllerPollingInfo controllerPollingInfo;
				if (controllerType > ControllerType.Mouse)
				{
					if (controllerType != ControllerType.Joystick)
					{
						throw new NotImplementedException();
					}
					if (this.mbc.controllers.joystickCount == 0)
					{
						return;
					}
					controllerPollingInfo = ReInput.controllers.polling.PollControllerForFirstButtonDown(this.kes.kao, this.mbf.id);
				}
				else
				{
					controllerPollingInfo = ReInput.controllers.polling.PollControllerForFirstButtonDown(this.kes.kao, 0);
				}
				if (!controllerPollingInfo.success)
				{
					return;
				}
			}
			this.gda();
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x0008DF50 File Offset: 0x0008C150
		private void gcq(int a)
		{
			if (this.mbc == null)
			{
				return;
			}
			Window window = this.kee.fvd(a);
			if (a < 0)
			{
				return;
			}
			if (this.kes == null)
			{
				return;
			}
			this.ggz();
			if (window.mgl.mga)
			{
				this.gha();
				this.gfi(a);
				return;
			}
			window.gtb(Mathf.CeilToInt(window.mgl.mgb).ToString(), 1);
			if (this.mbc.controllers.joystickCount == 0)
			{
				return;
			}
			ControllerPollingInfo controllerPollingInfo = ReInput.controllers.polling.PollControllerForFirstElementDown(ControllerType.Joystick, this.mbf.id);
			if (!controllerPollingInfo.success)
			{
				return;
			}
			if (!this.ggy(this.kes, controllerPollingInfo))
			{
				return;
			}
			ElementAssignment elementAssignment = this.kes.fre(controllerPollingInfo);
			if (!this.gfn(this.mbc, this.kes, elementAssignment, false))
			{
				this.kes.kam.ReplaceOrCreateElementMap(elementAssignment);
				this.gha();
				this.gfi(a);
				return;
			}
			this.gha();
			this.gde(elementAssignment, false);
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x0008E05C File Offset: 0x0008C25C
		private void gcr(int a)
		{
			if (this.mbc == null)
			{
				return;
			}
			Window window = this.kee.fvd(a);
			if (a < 0)
			{
				return;
			}
			if (this.kes == null)
			{
				return;
			}
			this.ggz();
			if (window.mgl.mga)
			{
				this.gha();
				this.gfi(a);
				return;
			}
			ControllerPollingInfo controllerPollingInfo;
			bool flag;
			ModifierKeyFlags modifierKeyFlags;
			string text;
			this.gfr(out controllerPollingInfo, out flag, out modifierKeyFlags, out text);
			if (flag)
			{
				window.mgl.gru(this._inputAssignmentTimeout);
			}
			window.gtb(flag ? string.Empty : Mathf.CeilToInt(window.mgl.mgb).ToString(), 2);
			window.gtb(text, 1);
			if (!controllerPollingInfo.success)
			{
				return;
			}
			if (!this.ggy(this.kes, controllerPollingInfo))
			{
				return;
			}
			ElementAssignment elementAssignment = this.kes.frf(controllerPollingInfo, modifierKeyFlags);
			if (!this.gfn(this.mbc, this.kes, elementAssignment, false))
			{
				this.kes.kam.ReplaceOrCreateElementMap(elementAssignment);
				this.gha();
				this.gfi(a);
				return;
			}
			this.gha();
			this.gde(elementAssignment, false);
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x0008E174 File Offset: 0x0008C374
		private void gcs(int a)
		{
			if (this.mbc == null)
			{
				return;
			}
			Window window = this.kee.fvd(a);
			if (a < 0)
			{
				return;
			}
			if (this.kes == null)
			{
				return;
			}
			this.ggz();
			if (window.mgl.mga)
			{
				this.gha();
				this.gfi(a);
				return;
			}
			window.gtb(Mathf.CeilToInt(window.mgl.mgb).ToString(), 1);
			ControllerPollingInfo controllerPollingInfo;
			if (this._ignoreMouseXAxisAssignment || this._ignoreMouseYAxisAssignment)
			{
				controllerPollingInfo = default(ControllerPollingInfo);
				using (IEnumerator<ControllerPollingInfo> enumerator = ReInput.controllers.polling.PollControllerForAllElementsDown(ControllerType.Mouse, 0).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ControllerPollingInfo controllerPollingInfo2 = enumerator.Current;
						if (controllerPollingInfo2.elementType != ControllerElementType.Axis || ((!this._ignoreMouseXAxisAssignment || controllerPollingInfo2.elementIndex != 0) && (!this._ignoreMouseYAxisAssignment || controllerPollingInfo2.elementIndex != 1)))
						{
							controllerPollingInfo = controllerPollingInfo2;
							break;
						}
					}
					goto IL_00FC;
				}
			}
			controllerPollingInfo = ReInput.controllers.polling.PollControllerForFirstElementDown(ControllerType.Mouse, 0);
			IL_00FC:
			if (!controllerPollingInfo.success)
			{
				return;
			}
			if (!this.ggy(this.kes, controllerPollingInfo))
			{
				return;
			}
			ElementAssignment elementAssignment = this.kes.fre(controllerPollingInfo);
			if (!this.gfn(this.mbc, this.kes, elementAssignment, true))
			{
				this.kes.kam.ReplaceOrCreateElementMap(elementAssignment);
				this.gha();
				this.gfi(a);
				return;
			}
			this.gha();
			this.gde(elementAssignment, true);
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x0008E2F8 File Offset: 0x0008C4F8
		private void gct(int a)
		{
			if (this.mbc == null)
			{
				return;
			}
			Window window = this.kee.fvd(a);
			if (a < 0)
			{
				return;
			}
			if (this.ket == null || !this.ket.lyp)
			{
				return;
			}
			this.ggz();
			if (!window.mgl.mga)
			{
				window.gtb(Mathf.CeilToInt(window.mgl.mgb).ToString(), 1);
				if (this.mbc.controllers.joystickCount == 0)
				{
					return;
				}
				if (!this.ket.kat.PollForFirstButtonDown().success)
				{
					return;
				}
			}
			this.ket.frj();
			this.gfi(a);
			this.gdi();
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x0008E3B0 File Offset: 0x0008C5B0
		private void gcu(int a)
		{
			if (this.mbc == null)
			{
				return;
			}
			Window window = this.kee.fvd(a);
			if (a < 0)
			{
				return;
			}
			if (this.ket == null || !this.ket.lyp)
			{
				return;
			}
			if (!window.mgl.mga)
			{
				window.gtb(Mathf.CeilToInt(window.mgl.mgb).ToString(), 1);
				this.ket.fri();
				if (this.mbc.controllers.joystickCount == 0)
				{
					return;
				}
				if (!this.ket.kat.PollForFirstButtonDown().success)
				{
					return;
				}
			}
			this.gfv();
			this.gha();
			this.gfi(a);
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x0008E468 File Offset: 0x0008C668
		private void gcv()
		{
			if (this.mbc == null)
			{
				return;
			}
			if (ReInput.controllers.joystickCount == 0)
			{
				return;
			}
			Window window = this.gfd(true);
			if (window == null)
			{
				return;
			}
			window.gtc(new Action<int>(this.gco));
			window.gsr(this.prefabs.lxd, Vector2.zero, this._language.mcm);
			window.gst(this.prefabs.lxe, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.mcn);
			window.gst(this.prefabs.lxe, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, a.tk());
			window.mgl.gru(this._controllerAssignmentTimeout);
			this.kee.fvg(window);
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x0008E548 File Offset: 0x0008C748
		private void gcw(int a)
		{
			ControlMapper.ju ju = new ControlMapper.ju();
			ju.kcd = this;
			ju.kcf = a;
			if (this.mbc == null)
			{
				return;
			}
			if (ReInput.controllers.joystickCount == 0)
			{
				return;
			}
			ju.kce = this.gfd(true);
			if (ju.kce == null)
			{
				return;
			}
			string text = string.Empty;
			IList<Player> players = ReInput.players.Players;
			for (int i = 0; i < players.Count; i++)
			{
				if (players[i] != this.mbc && players[i].controllers.ContainsController(ControllerType.Joystick, ju.kcf))
				{
					text = this._language.gmo(players[i].id);
					break;
				}
			}
			Joystick joystick = ReInput.controllers.GetJoystick(ju.kcf);
			ju.kce.gsr(this.prefabs.lxd, Vector2.zero, this._language.mco);
			ju.kce.gst(this.prefabs.lxe, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.gmd(this._language.gmp(joystick), text, this._language.gmo(this.mbc.id)));
			UnityAction unityAction = new UnityAction(ju.fvq);
			ju.kce.cancelCallback = unityAction;
			ju.kce.gsw(this.prefabs.lwx, UIPivot.BottomLeft, UIAnchor.BottomLeft, Vector2.zero, this._language.mcb, new UnityAction(ju.fvr), unityAction, true);
			ju.kce.gsw(this.prefabs.lwx, UIPivot.BottomRight, UIAnchor.BottomRight, Vector2.zero, this._language.mcc, unityAction, unityAction, false);
			this.kee.fvg(ju.kce);
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x0008E73C File Offset: 0x0008C93C
		private void gcx(kf a, InputAction b, ControllerMap c, ActionElementMap d, string e)
		{
			ControlMapper.jv jv = new ControlMapper.jv();
			jv.kcg = this;
			jv.kci = a;
			jv.kcj = c;
			jv.kck = d;
			jv.kcl = e;
			ControlMapper.jd jd = this.ked.fsa(this.keg, b.id, jv.kci.mbz, jv.kci.kfy, jv.kci.intData);
			if (jd == null)
			{
				return;
			}
			jv.kch = this.gfd(true);
			if (jv.kch == null)
			{
				return;
			}
			jv.kch.gsr(this.prefabs.lxd, Vector2.zero, jv.kcl);
			jv.kch.gst(this.prefabs.lxe, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), jd.flo());
			UnityAction unityAction = new UnityAction(jv.fvs);
			jv.kch.cancelCallback = unityAction;
			jv.kch.gsw(this.prefabs.lwx, UIPivot.BottomLeft, UIAnchor.BottomLeft, Vector2.zero, this._language.mce, new UnityAction(jv.fvt), unityAction, true);
			jv.kch.gsw(this.prefabs.lwx, UIPivot.BottomCenter, UIAnchor.BottomCenter, Vector2.zero, this._language.mcf, new UnityAction(jv.fvu), unityAction, false);
			jv.kch.gsw(this.prefabs.lwx, UIPivot.BottomRight, UIAnchor.BottomRight, Vector2.zero, this._language.mch, unityAction, unityAction, false);
			this.kee.fvg(jv.kch);
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x0008E8FC File Offset: 0x0008CAFC
		private void gcy(kf a, InputAction b, ControllerMap c, string d)
		{
			if (this.ked.fsa(this.keg, b.id, a.mbz, a.kfy, a.intData) == null)
			{
				return;
			}
			this.gci(a, c, null, d);
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x0008E938 File Offset: 0x0008CB38
		private void gcz()
		{
			if (this.kes == null)
			{
				return;
			}
			Window window = this.gfd(true);
			if (window == null)
			{
				return;
			}
			window.gsr(this.prefabs.lxd, Vector2.zero, this.kes.kak);
			window.gst(this.prefabs.lxe, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.mcp);
			if (this.prefabs.lxi != null)
			{
				window.gsu(this.prefabs.lxi, UIPivot.BottomCenter, UIAnchor.BottomCenter, new Vector2(0f, 40f));
			}
			window.gst(this.prefabs.lxe, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, a.tk());
			window.gtc(new Action<int>(this.gcp));
			window.mgl.gru(this._preInputAssignmentTimeout);
			this.kee.fvg(window);
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x0008EA48 File Offset: 0x0008CC48
		private void gda()
		{
			if (this.kes == null)
			{
				return;
			}
			switch (this.kes.kao)
			{
			case ControllerType.Keyboard:
				this.gdc();
				return;
			case ControllerType.Mouse:
				if (this.mbc.controllers.hasMouse)
				{
					this.gdd();
					return;
				}
				this.gdf();
				return;
			case ControllerType.Joystick:
				this.gdb();
				return;
			default:
				throw new NotImplementedException();
			}
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x0008EAB4 File Offset: 0x0008CCB4
		private void gdb()
		{
			if (this.kes == null)
			{
				return;
			}
			Window window = this.gfd(true);
			if (window == null)
			{
				return;
			}
			string text = ((this.kes.lyn == AxisRange.Full && this._showFullAxisInputFields && !this._showSplitAxisInputFields) ? this._language.gmf(this.kes.kak) : this._language.gme(this.kes.kak));
			window.gsr(this.prefabs.lxd, Vector2.zero, this.kes.kak);
			window.gst(this.prefabs.lxe, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), text);
			window.gst(this.prefabs.lxe, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, a.tk());
			window.gtc(new Action<int>(this.gcq));
			window.mgl.gru(this._inputAssignmentTimeout);
			this.kee.fvg(window);
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x0008EBC8 File Offset: 0x0008CDC8
		private void gdc()
		{
			if (this.kes == null)
			{
				return;
			}
			Window window = this.gfd(true);
			if (window == null)
			{
				return;
			}
			window.gsr(this.prefabs.lxd, Vector2.zero, this.kes.kak);
			window.gst(this.prefabs.lxe, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.gmg(this.kes.kak));
			window.gst(this.prefabs.lxe, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -(window.gta(0) + 50f)), a.tk());
			window.gst(this.prefabs.lxe, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, a.tk());
			window.gtc(new Action<int>(this.gcr));
			window.mgl.gru(this._inputAssignmentTimeout);
			this.kee.fvg(window);
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x0008ECE0 File Offset: 0x0008CEE0
		private void gdd()
		{
			if (this.kes == null)
			{
				return;
			}
			Window window = this.gfd(true);
			if (window == null)
			{
				return;
			}
			string text = ((this.kes.lyn == AxisRange.Full && this._showFullAxisInputFields && !this._showSplitAxisInputFields) ? this._language.gmi(this.kes.kak) : this._language.gmh(this.kes.kak));
			window.gsr(this.prefabs.lxd, Vector2.zero, this.kes.kak);
			window.gst(this.prefabs.lxe, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), text);
			window.gst(this.prefabs.lxe, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, a.tk());
			window.gtc(new Action<int>(this.gcs));
			window.mgl.gru(this._inputAssignmentTimeout);
			this.kee.fvg(window);
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x0008EDF4 File Offset: 0x0008CFF4
		private void gde(ElementAssignment a, bool b)
		{
			ControlMapper.jw jw = new ControlMapper.jw();
			jw.kcm = this;
			jw.kco = a;
			jw.kcp = b;
			if (this.kes == null)
			{
				return;
			}
			bool flag = this.gfo(this.kes, jw.kco, jw.kcp);
			string text = (flag ? this._language.gmj(this.kes.lyo) : this._language.gmk(this.kes.lyo, this._allowElementAssignmentConflicts));
			jw.kcn = this.gfd(true);
			if (jw.kcn == null)
			{
				return;
			}
			jw.kcn.gsr(this.prefabs.lxd, Vector2.zero, this._language.mcq);
			jw.kcn.gst(this.prefabs.lxe, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), text);
			UnityAction unityAction = new UnityAction(jw.fvv);
			jw.kcn.cancelCallback = unityAction;
			if (flag)
			{
				jw.kcn.gsw(this.prefabs.lwx, UIPivot.BottomCenter, UIAnchor.BottomCenter, Vector2.zero, this._language.mcj, unityAction, unityAction, true);
			}
			else
			{
				jw.kcn.gsw(this.prefabs.lwx, UIPivot.BottomLeft, UIAnchor.BottomLeft, Vector2.zero, this._language.mce, new UnityAction(jw.fvw), unityAction, true);
				if (this._allowElementAssignmentConflicts)
				{
					jw.kcn.gsw(this.prefabs.lwx, UIPivot.BottomCenter, UIAnchor.BottomCenter, Vector2.zero, this._language.mcd, new UnityAction(jw.fvx), unityAction, false);
				}
				else if (this.ghc(jw.kcn.mgf, this.kes, jw.kco, jw.kcp))
				{
					jw.kcn.gsw(this.prefabs.lwx, UIPivot.BottomCenter, UIAnchor.BottomCenter, Vector2.zero, this._language.mcg, new UnityAction(jw.fvy), unityAction, false);
				}
				jw.kcn.gsw(this.prefabs.lwx, UIPivot.BottomRight, UIAnchor.BottomRight, Vector2.zero, this._language.mch, unityAction, unityAction, false);
			}
			this.kee.fvg(jw.kcn);
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x0008F06C File Offset: 0x0008D26C
		private void gdf()
		{
			ControlMapper.jx jx = new ControlMapper.jx();
			jx.kcq = this;
			if (this.mbc == null)
			{
				return;
			}
			jx.kcr = this.gfd(true);
			if (jx.kcr == null)
			{
				return;
			}
			string text = string.Empty;
			IList<Player> players = ReInput.players.Players;
			for (int i = 0; i < players.Count; i++)
			{
				if (players[i] != this.mbc && players[i].controllers.hasMouse)
				{
					text = this._language.gmo(players[i].id);
					break;
				}
			}
			jx.kcr.gsr(this.prefabs.lxd, Vector2.zero, this._language.mcr);
			jx.kcr.gst(this.prefabs.lxe, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.gml(text, this._language.gmo(this.mbc.id)));
			UnityAction unityAction = new UnityAction(jx.fvz);
			jx.kcr.cancelCallback = unityAction;
			jx.kcr.gsw(this.prefabs.lwx, UIPivot.BottomLeft, UIAnchor.BottomLeft, Vector2.zero, this._language.mcb, new UnityAction(jx.fwa), unityAction, true);
			jx.kcr.gsw(this.prefabs.lwx, UIPivot.BottomRight, UIAnchor.BottomRight, Vector2.zero, this._language.mcc, unityAction, unityAction, false);
			this.kee.fvg(jx.kcr);
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x0008F224 File Offset: 0x0008D424
		private void gdg()
		{
			if (this.mbc == null)
			{
				return;
			}
			if (this.mbc.controllers.joystickCount == 0)
			{
				return;
			}
			CalibrationWindow calibrationWindow = this.gfg(this.prefabs.lxg, a.euo(), true) as CalibrationWindow;
			if (calibrationWindow == null)
			{
				return;
			}
			Joystick joystick = this.mbf;
			calibrationWindow.gsr(this.prefabs.lxd, Vector2.zero, this._language.mcs);
			calibrationWindow.fko(this.mbc.id, joystick);
			calibrationWindow.fkp(CalibrationWindow.ButtonIdentifier.Done, new Action<int>(this.gfi));
			calibrationWindow.fkp(CalibrationWindow.ButtonIdentifier.Calibrate, new Action<int>(this.gfu));
			calibrationWindow.fkp(CalibrationWindow.ButtonIdentifier.Cancel, new Action<int>(this.gfi));
			this.kee.fvg(calibrationWindow);
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x0008F2F4 File Offset: 0x0008D4F4
		private void gdh()
		{
			if (this.mbc == null)
			{
				return;
			}
			Window window = this.gfd(false);
			if (window == null)
			{
				return;
			}
			if (this.ket == null)
			{
				return;
			}
			Joystick kat = this.ket.kat;
			if (kat.axisCount == 0)
			{
				return;
			}
			int kau = this.ket.kau;
			if (kau < 0 || kau >= kat.axisCount)
			{
				return;
			}
			window.gsr(this.prefabs.lxd, Vector2.zero, this._language.mct);
			window.gst(this.prefabs.lxe, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.gmm(this._language.gmr(kat, kat.AxisElementIdentifiers[kau].id, AxisRange.Full)));
			if (this.prefabs.lxi != null)
			{
				window.gsu(this.prefabs.lxi, UIPivot.BottomCenter, UIAnchor.BottomCenter, new Vector2(0f, 40f));
			}
			window.gst(this.prefabs.lxe, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, a.tk());
			window.gtc(new Action<int>(this.gct));
			window.mgl.gru(this._axisCalibrationTimeout);
			this.kee.fvg(window);
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x0008F45C File Offset: 0x0008D65C
		private void gdi()
		{
			if (this.mbc == null)
			{
				return;
			}
			Window window = this.gfd(false);
			if (window == null)
			{
				return;
			}
			if (this.ket == null)
			{
				return;
			}
			Joystick kat = this.ket.kat;
			if (kat.axisCount == 0)
			{
				return;
			}
			int kau = this.ket.kau;
			if (kau < 0 || kau >= kat.axisCount)
			{
				return;
			}
			window.gsr(this.prefabs.lxd, Vector2.zero, this._language.mcu);
			window.gst(this.prefabs.lxe, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.gmn(this._language.gmr(kat, kat.AxisElementIdentifiers[kau].id, AxisRange.Full)));
			if (this.prefabs.lxj != null)
			{
				window.gsu(this.prefabs.lxj, UIPivot.BottomCenter, UIAnchor.BottomCenter, new Vector2(0f, 40f));
			}
			window.gst(this.prefabs.lxe, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, a.tk());
			window.gtc(new Action<int>(this.gcu));
			window.mgl.gru(this._axisCalibrationTimeout);
			this.kee.fvg(window);
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x0008F5C4 File Offset: 0x0008D7C4
		private void gdj()
		{
			if (this.mbc == null)
			{
				return;
			}
			if (this._inputBehaviorSettings == null)
			{
				return;
			}
			InputBehaviorWindow inputBehaviorWindow = this.gfg(this.prefabs.lxh, a.eup(), true) as InputBehaviorWindow;
			if (inputBehaviorWindow == null)
			{
				return;
			}
			inputBehaviorWindow.gsr(this.prefabs.lxd, Vector2.zero, this._language.mcv);
			inputBehaviorWindow.gjj(this.mbc.id, this._inputBehaviorSettings);
			inputBehaviorWindow.gjk(InputBehaviorWindow.ButtonIdentifier.Done, new Action<int>(this.gfi));
			inputBehaviorWindow.gjk(InputBehaviorWindow.ButtonIdentifier.Cancel, new Action<int>(this.gfi));
			this.kee.fvg(inputBehaviorWindow);
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x0008F674 File Offset: 0x0008D874
		private void gdk()
		{
			if (this.mbc == null)
			{
				return;
			}
			this.gfh(this._language.mcw, this._language.mdm, this._language.mcb, new Action<int>(this.gcn), this._language.mcc, new Action<int>(this.gcg), true);
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x0008F6D8 File Offset: 0x0008D8D8
		private void gdl()
		{
			this.gdm();
			this.gdo();
			this.gdp();
			this.gdq();
			this.gdr();
			this.gds();
			this.gdu();
			this.gdv();
			this.ked.fsk();
			this.geb();
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x0008F728 File Offset: 0x0008D928
		private void gdm()
		{
			if (this.ked == null)
			{
				this.ked = new ControlMapper.jm();
			}
			else
			{
				this.ked.fsn();
			}
			for (int i = 0; i < this._mappingSets.Length; i++)
			{
				ControlMapper.MappingSet mappingSet = this._mappingSets[i];
				if (mappingSet != null && mappingSet.lwh)
				{
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(mappingSet.lwd);
					if (mapCategory != null && mapCategory.userAssignable)
					{
						this.ked.frr(mappingSet.lwd);
						if (mappingSet.lwe == ControlMapper.MappingSet.ActionListMode.ActionCategory)
						{
							IList<int> list = mappingSet.lwf;
							for (int j = 0; j < list.Count; j++)
							{
								int num = list[j];
								InputCategory actionCategory = ReInput.mapping.GetActionCategory(num);
								if (actionCategory != null && actionCategory.userAssignable)
								{
									this.ked.frt(mappingSet.lwd, num);
									foreach (InputAction inputAction in ReInput.mapping.UserAssignableActionsInCategory(num))
									{
										if (inputAction.type == InputActionType.Axis)
										{
											if (this._showFullAxisInputFields)
											{
												this.ked.frs(mappingSet.lwd, inputAction, AxisRange.Full);
											}
											if (this._showSplitAxisInputFields)
											{
												this.ked.frs(mappingSet.lwd, inputAction, AxisRange.Positive);
												this.ked.frs(mappingSet.lwd, inputAction, AxisRange.Negative);
											}
										}
										else if (inputAction.type == InputActionType.Button)
										{
											this.ked.frs(mappingSet.lwd, inputAction, AxisRange.Positive);
										}
									}
								}
							}
						}
						else
						{
							IList<int> list2 = mappingSet.lwg;
							for (int k = 0; k < list2.Count; k++)
							{
								InputAction action = ReInput.mapping.GetAction(list2[k]);
								if (action != null)
								{
									if (action.type == InputActionType.Axis)
									{
										if (this._showFullAxisInputFields)
										{
											this.ked.frs(mappingSet.lwd, action, AxisRange.Full);
										}
										if (this._showSplitAxisInputFields)
										{
											this.ked.frs(mappingSet.lwd, action, AxisRange.Positive);
											this.ked.frs(mappingSet.lwd, action, AxisRange.Negative);
										}
									}
									else if (action.type == InputActionType.Button)
									{
										this.ked.frs(mappingSet.lwd, action, AxisRange.Positive);
									}
								}
							}
						}
					}
				}
			}
			this.references.lyb.GetComponent<HorizontalLayoutGroup>().spacing = (float)this._inputColumnSpacing;
			this.references.jzz.flexibleWidth = 0f;
			this.references.jzz.preferredWidth = (float)this.mbb;
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x0008F9E8 File Offset: 0x0008DBE8
		private void gdn()
		{
			if (this.mbe == null)
			{
				return;
			}
			this.ked.fsk();
			this.ked.fsj(this.mbe.lwd);
			this.references.lyb.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.ked.fsd(this.mbe.lwd));
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x0008FA4C File Offset: 0x0008DC4C
		private void gdo()
		{
			this.references.kae = this.gfc(a.euq(), this.references.lxy, this._actionLabelWidth).transform;
			this.ges(this.prefabs.lwz, this._language.mcx, this.references.kae, Vector2.zero);
			if (this._showKeyboard)
			{
				this.references.kaf = this.gfc(a.eur(), this.references.lxy, this._keyboardColMaxWidth).transform;
				this.ges(this.prefabs.lwz, this._language.mcy, this.references.kaf, Vector2.zero).fnf(TextAlignmentOptions.Center);
			}
			if (this._showMouse)
			{
				this.references.kag = this.gfc(a.eus(), this.references.lxy, this._mouseColMaxWidth).transform;
				this.ges(this.prefabs.lwz, this._language.mcz, this.references.kag, Vector2.zero).fnf(TextAlignmentOptions.Center);
			}
			if (this._showControllers)
			{
				this.references.kah = this.gfc(a.eut(), this.references.lxy, this._controllerColMaxWidth).transform;
				this.ges(this.prefabs.lwz, this._language.mda, this.references.kah, Vector2.zero).fnf(TextAlignmentOptions.Center);
			}
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x0008FBF0 File Offset: 0x0008DDF0
		private void gdp()
		{
			Transform transform = this.gfc(a.euu(), this.references.lyb, this._actionLabelWidth).transform;
			this.references.kaa = transform;
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x0008FC2B File Offset: 0x0008DE2B
		private void gdq()
		{
			if (!this._showKeyboard)
			{
				return;
			}
			this.gdt(a.euv(), ControllerType.Keyboard, this._keyboardColMaxWidth, this._keyboardInputFieldCount, true);
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x0008FC4F File Offset: 0x0008DE4F
		private void gdr()
		{
			if (!this._showMouse)
			{
				return;
			}
			this.gdt(a.euw(), ControllerType.Mouse, this._mouseColMaxWidth, this._mouseInputFieldCount, false);
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x0008FC73 File Offset: 0x0008DE73
		private void gds()
		{
			if (!this._showControllers)
			{
				return;
			}
			this.gdt(a.eux(), ControllerType.Joystick, this._controllerColMaxWidth, this._controllerInputFieldCount, false);
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x0008FC98 File Offset: 0x0008DE98
		private void gdt(string a, ControllerType b, int c, int d, bool e)
		{
			Transform transform = this.gfc(a, this.references.lyb, c).transform;
			switch (b)
			{
			case ControllerType.Keyboard:
				this.references.kab = transform;
				return;
			case ControllerType.Mouse:
				this.references.kac = transform;
				return;
			case ControllerType.Joystick:
				this.references.kad = transform;
				return;
			default:
				throw new NotImplementedException();
			}
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x0008FD00 File Offset: 0x0008DF00
		private void gdu()
		{
			Transform transform = this.references.kaa;
			for (int i = 0; i < this._mappingSets.Length; i++)
			{
				ControlMapper.MappingSet mappingSet = this._mappingSets[i];
				if (mappingSet != null && mappingSet.lwh)
				{
					int num = 0;
					if (mappingSet.lwe == ControlMapper.MappingSet.ActionListMode.ActionCategory)
					{
						int num2 = 0;
						IList<int> list = mappingSet.lwf;
						for (int j = 0; j < list.Count; j++)
						{
							InputCategory actionCategory = ReInput.mapping.GetActionCategory(list[j]);
							if (actionCategory != null && actionCategory.userAssignable && this.ggn<InputAction>(ReInput.mapping.UserAssignableActionsInCategory(actionCategory.id)) != 0)
							{
								if (this._showActionCategoryLabels)
								{
									if (num2 > 0)
									{
										num -= this._inputRowCategorySpacing;
									}
									ControlMapper.jg jg = this.ger(this._language.gmw(actionCategory.id), transform, new Vector2(0f, (float)num));
									jg.fne(FontStyles.Bold);
									jg.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
									this.ked.fry(mappingSet.lwd, actionCategory.id, jg);
									num -= this._inputRowHeight;
								}
								foreach (InputAction inputAction in ReInput.mapping.UserAssignableActionsInCategory(actionCategory.id, true))
								{
									if (inputAction.type == InputActionType.Axis)
									{
										if (this._showFullAxisInputFields)
										{
											ControlMapper.jg jg2 = this.ger(this._language.gmu(inputAction.id, AxisRange.Full), transform, new Vector2(0f, (float)num));
											jg2.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
											this.ked.frx(mappingSet.lwd, inputAction.id, AxisRange.Full, jg2);
											num -= this._inputRowHeight;
										}
										if (this._showSplitAxisInputFields)
										{
											string text = this._language.gmu(inputAction.id, AxisRange.Positive);
											ControlMapper.jg jg2 = this.ger(text, transform, new Vector2(0f, (float)num));
											jg2.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
											this.ked.frx(mappingSet.lwd, inputAction.id, AxisRange.Positive, jg2);
											num -= this._inputRowHeight;
											string text2 = this._language.gmu(inputAction.id, AxisRange.Negative);
											jg2 = this.ger(text2, transform, new Vector2(0f, (float)num));
											jg2.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
											this.ked.frx(mappingSet.lwd, inputAction.id, AxisRange.Negative, jg2);
											num -= this._inputRowHeight;
										}
									}
									else if (inputAction.type == InputActionType.Button)
									{
										ControlMapper.jg jg2 = this.ger(this._language.gmt(inputAction.id), transform, new Vector2(0f, (float)num));
										jg2.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
										this.ked.frx(mappingSet.lwd, inputAction.id, AxisRange.Positive, jg2);
										num -= this._inputRowHeight;
									}
								}
								num2++;
							}
						}
					}
					else
					{
						IList<int> list2 = mappingSet.lwg;
						for (int k = 0; k < list2.Count; k++)
						{
							InputAction action = ReInput.mapping.GetAction(list2[k]);
							if (action != null && action.userAssignable)
							{
								InputCategory actionCategory2 = ReInput.mapping.GetActionCategory(action.categoryId);
								if (actionCategory2 != null && actionCategory2.userAssignable)
								{
									if (action.type == InputActionType.Axis)
									{
										if (this._showFullAxisInputFields)
										{
											ControlMapper.jg jg3 = this.ger(this._language.gmu(action.id, AxisRange.Full), transform, new Vector2(0f, (float)num));
											jg3.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
											this.ked.frx(mappingSet.lwd, action.id, AxisRange.Full, jg3);
											num -= this._inputRowHeight;
										}
										if (this._showSplitAxisInputFields)
										{
											ControlMapper.jg jg3 = this.ger(this._language.gmu(action.id, AxisRange.Positive), transform, new Vector2(0f, (float)num));
											jg3.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
											this.ked.frx(mappingSet.lwd, action.id, AxisRange.Positive, jg3);
											num -= this._inputRowHeight;
											jg3 = this.ger(this._language.gmu(action.id, AxisRange.Negative), transform, new Vector2(0f, (float)num));
											jg3.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
											this.ked.frx(mappingSet.lwd, action.id, AxisRange.Negative, jg3);
											num -= this._inputRowHeight;
										}
									}
									else if (action.type == InputActionType.Button)
									{
										ControlMapper.jg jg3 = this.ger(this._language.gmt(action.id), transform, new Vector2(0f, (float)num));
										jg3.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
										this.ked.frx(mappingSet.lwd, action.id, AxisRange.Positive, jg3);
										num -= this._inputRowHeight;
									}
								}
							}
						}
					}
					this.ked.fsc(mappingSet.lwd, (float)(-(float)num));
				}
			}
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x0009028C File Offset: 0x0008E48C
		private void gdv()
		{
			if (this._showControllers)
			{
				this.gdw(this.references.kad, ControllerType.Joystick, this._controllerColMaxWidth, this._controllerInputFieldCount, false);
			}
			if (this._showKeyboard)
			{
				this.gdw(this.references.kab, ControllerType.Keyboard, this._keyboardColMaxWidth, this._keyboardInputFieldCount, true);
			}
			if (this._showMouse)
			{
				this.gdw(this.references.kac, ControllerType.Mouse, this._mouseColMaxWidth, this._mouseInputFieldCount, false);
			}
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x00090310 File Offset: 0x0008E510
		private void gdw(Transform a, ControllerType b, int c, int d, bool e)
		{
			for (int i = 0; i < this._mappingSets.Length; i++)
			{
				ControlMapper.MappingSet mappingSet = this._mappingSets[i];
				if (mappingSet != null && mappingSet.lwh)
				{
					int num = c / d;
					int num2 = 0;
					int num3 = 0;
					if (mappingSet.lwe == ControlMapper.MappingSet.ActionListMode.ActionCategory)
					{
						IList<int> list = mappingSet.lwf;
						for (int j = 0; j < list.Count; j++)
						{
							InputCategory actionCategory = ReInput.mapping.GetActionCategory(list[j]);
							if (actionCategory != null && actionCategory.userAssignable && this.ggn<InputAction>(ReInput.mapping.UserAssignableActionsInCategory(actionCategory.id)) != 0)
							{
								if (this._showActionCategoryLabels)
								{
									num2 -= ((num3 > 0) ? (this._inputRowHeight + this._inputRowCategorySpacing) : this._inputRowHeight);
								}
								foreach (InputAction inputAction in ReInput.mapping.UserAssignableActionsInCategory(actionCategory.id, true))
								{
									if (inputAction.type == InputActionType.Axis)
									{
										if (this._showFullAxisInputFields)
										{
											this.gdx(a, mappingSet.lwd, inputAction, AxisRange.Full, b, d, num, ref num2, e);
										}
										if (this._showSplitAxisInputFields)
										{
											this.gdx(a, mappingSet.lwd, inputAction, AxisRange.Positive, b, d, num, ref num2, false);
											this.gdx(a, mappingSet.lwd, inputAction, AxisRange.Negative, b, d, num, ref num2, false);
										}
									}
									else if (inputAction.type == InputActionType.Button)
									{
										this.gdx(a, mappingSet.lwd, inputAction, AxisRange.Positive, b, d, num, ref num2, false);
									}
									num3++;
								}
							}
						}
					}
					else
					{
						IList<int> list2 = mappingSet.lwg;
						for (int k = 0; k < list2.Count; k++)
						{
							InputAction action = ReInput.mapping.GetAction(list2[k]);
							if (action != null && action.userAssignable)
							{
								InputCategory actionCategory2 = ReInput.mapping.GetActionCategory(action.categoryId);
								if (actionCategory2 != null && actionCategory2.userAssignable)
								{
									if (action.type == InputActionType.Axis)
									{
										if (this._showFullAxisInputFields)
										{
											this.gdx(a, mappingSet.lwd, action, AxisRange.Full, b, d, num, ref num2, e);
										}
										if (this._showSplitAxisInputFields)
										{
											this.gdx(a, mappingSet.lwd, action, AxisRange.Positive, b, d, num, ref num2, false);
											this.gdx(a, mappingSet.lwd, action, AxisRange.Negative, b, d, num, ref num2, false);
										}
									}
									else if (action.type == InputActionType.Button)
									{
										this.gdx(a, mappingSet.lwd, action, AxisRange.Positive, b, d, num, ref num2, false);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x000905C4 File Offset: 0x0008E7C4
		private void gdx(Transform a, int b, InputAction c, AxisRange d, ControllerType e, int f, int g, ref int h, bool i)
		{
			GameObject gameObject = this.gfa(a.euy(), a, new Vector2(0f, (float)h));
			HorizontalLayoutGroup horizontalLayoutGroup = gameObject.AddComponent<HorizontalLayoutGroup>();
			horizontalLayoutGroup.padding = this._inputRowPadding;
			horizontalLayoutGroup.spacing = (float)this._inputRowFieldSpacing;
			RectTransform component = gameObject.GetComponent<RectTransform>();
			component.anchorMin = new Vector2(0f, 1f);
			component.anchorMax = new Vector2(1f, 1f);
			component.pivot = new Vector2(0f, 1f);
			component.sizeDelta = Vector2.zero;
			component.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
			this.ked.fru(b, c, d, e, gameObject);
			for (int j = 0; j < f; j++)
			{
				int num = ((d == AxisRange.Full) ? this._invertToggleWidth : 0);
				ControlMapper.jd jd = this.gev(horizontalLayoutGroup.transform, Vector2.zero, a.tk(), c.id, d, e, j);
				jd.flm(ControlMapper.LayoutElementSizeType.PreferredSize, g - num);
				jd.flm(ControlMapper.LayoutElementSizeType.MinSize, 0);
				this.ked.frv(b, c, d, e, j, jd);
				if (d == AxisRange.Full)
				{
					if (!i)
					{
						ControlMapper.jf jf = this.gex(this.prefabs.lxb, horizontalLayoutGroup.transform, Vector2.zero, a.tk(), c.id, d, e, j);
						jf.flm(ControlMapper.LayoutElementSizeType.MinSize, num);
						jd.fml(jf);
					}
					else
					{
						jd.flk(false, false, true);
					}
				}
			}
			h -= this._inputRowHeight;
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x0009074C File Offset: 0x0008E94C
		private void gdy()
		{
			this.ked.fsi(this.keg);
			if (this.mbc == null)
			{
				return;
			}
			this.ked.fse(this.keg, true);
			foreach (ControlMapper.jh jh in this.ked.fsb(this.keg))
			{
				if (this._showKeyboard)
				{
					ControllerType controllerType = ControllerType.Keyboard;
					int num = 0;
					int num2 = this._keyboardMapDefaultLayout;
					int num3 = this._keyboardInputFieldCount;
					ControllerMap controllerMap = this.ggm(controllerType, num, num2);
					this.gdz(jh, controllerMap, controllerType, num, num3);
				}
				if (this._showMouse)
				{
					ControllerType controllerType = ControllerType.Mouse;
					int num = 0;
					int num2 = this._mouseMapDefaultLayout;
					int num3 = this._mouseInputFieldCount;
					ControllerMap controllerMap2 = this.ggm(controllerType, num, num2);
					if (this.mbc.controllers.hasMouse)
					{
						this.gdz(jh, controllerMap2, controllerType, num, num3);
					}
				}
				if (this.mbg && this.mbc.controllers.joystickCount > 0)
				{
					ControllerType controllerType = ControllerType.Joystick;
					int num = this.mbf.id;
					int num2 = this._joystickMapDefaultLayout;
					int num3 = this._controllerInputFieldCount;
					ControllerMap controllerMap3 = this.ggm(controllerType, num, num2);
					this.gdz(jh, controllerMap3, controllerType, num, num3);
				}
				else
				{
					this.gea(jh, ControllerType.Joystick, this._controllerInputFieldCount);
				}
			}
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x000908B0 File Offset: 0x0008EAB0
		private void gdz(ControlMapper.jh a, ControllerMap b, ControllerType c, int d, int e)
		{
			if (b == null)
			{
				return;
			}
			int num = 0;
			this.ked.fsh(this.keg, a.lyl, a.lym, c, d);
			foreach (ActionElementMap actionElementMap in b.ElementMapsWithAction(a.lyl))
			{
				if (actionElementMap.elementType == ControllerElementType.Button)
				{
					if (a.lym == AxisRange.Full)
					{
						continue;
					}
					if (a.lym == AxisRange.Positive)
					{
						if (actionElementMap.axisContribution == Pole.Negative)
						{
							continue;
						}
					}
					else if (a.lym == AxisRange.Negative && actionElementMap.axisContribution == Pole.Positive)
					{
						continue;
					}
					this.ked.fsg(this.keg, a.lyl, a.lym, c, d, num, actionElementMap.id, this._language.gmq(actionElementMap), false);
				}
				else if (actionElementMap.elementType == ControllerElementType.Axis)
				{
					if (a.lym == AxisRange.Full)
					{
						if (actionElementMap.axisRange != AxisRange.Full)
						{
							continue;
						}
						this.ked.fsg(this.keg, a.lyl, a.lym, c, d, num, actionElementMap.id, this._language.gmq(actionElementMap), actionElementMap.invert);
					}
					else if (a.lym == AxisRange.Positive)
					{
						if ((actionElementMap.axisRange == AxisRange.Full && ReInput.mapping.GetAction(a.lyl).type != InputActionType.Button) || actionElementMap.axisContribution == Pole.Negative)
						{
							continue;
						}
						this.ked.fsg(this.keg, a.lyl, a.lym, c, d, num, actionElementMap.id, this._language.gmq(actionElementMap), false);
					}
					else if (a.lym == AxisRange.Negative)
					{
						if (actionElementMap.axisRange == AxisRange.Full || actionElementMap.axisContribution == Pole.Positive)
						{
							continue;
						}
						this.ked.fsg(this.keg, a.lyl, a.lym, c, d, num, actionElementMap.id, this._language.gmq(actionElementMap), false);
					}
				}
				num++;
				if (num > e)
				{
					break;
				}
			}
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x00090AD0 File Offset: 0x0008ECD0
		private void gea(ControlMapper.jh a, ControllerType b, int c)
		{
			for (int i = 0; i < c; i++)
			{
				ControlMapper.jd jd = this.ked.fsa(this.keg, a.lyl, a.lym, b, i);
				if (jd != null)
				{
					jd.flj(false, false);
				}
			}
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x00090B14 File Offset: 0x0008ED14
		private void geb()
		{
			this.references.lyb.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
			this.references.lxz.value = 1f;
			this.references.lya.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHide;
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x00090B64 File Offset: 0x0008ED64
		private void gec()
		{
			this.references.lxo.gameObject.SetActive(this.lzf);
			this.references.lxp.gameObject.SetActive(this._showControllers);
			this.references.lxs.gameObject.SetActive(this._showControllers && this.ggv());
			this.references.lxt.gameObject.SetActive(this.mbi || this.mbj);
			this.references.lxu.gameObject.SetActive(this.mbi);
			this.references.lxv.gameObject.SetActive(this.mbj);
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x00090C29 File Offset: 0x0008EE29
		private void ged()
		{
			this.gee();
			this.gef();
			this.geg();
			this.geh();
			this.gei();
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x00090C4C File Offset: 0x0008EE4C
		private void gee()
		{
			if (!this.lzf)
			{
				return;
			}
			this.references.lxo.mfv = this._language.mdi;
			this.references.lxo.gqx(this._showPlayersGroupLabel);
			for (int i = 0; i < this.kec; i++)
			{
				Player player = ReInput.players.GetPlayer(i);
				if (player != null)
				{
					ControlMapper.jb jb = new ControlMapper.jb(kq.grj<ButtonInfo>(this.prefabs.lww, this.references.lxo.mfw, a.eex() + i.ToString() + a.euz()));
					jb.fln(this._language.gmo(player.id));
					jb.flw(a.eue(), player.id);
					jb.flx(new Action<ButtonInfo>(this.OnButtonActivated));
					jb.lvu.kgm += this.ggb;
					this.keh.Add(jb);
				}
			}
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x00090D58 File Offset: 0x0008EF58
		private void gef()
		{
			if (!this._showControllers)
			{
				return;
			}
			this.references.lxr.mfv = this._language.mdh;
			this.references.lxr.gqx(this._showControllerGroupLabel);
			this.references.lyc.gameObject.SetActive(this._showControllerNameLabel);
			this.references.lxq.gameObject.SetActive(this._showControllerGroupLabel || this._showControllerNameLabel);
			if (this.ggv())
			{
				this.references.lxs.mfv = this._language.mdj;
				this.references.lxs.gqx(this._showAssignedControllersGroupLabel);
			}
			this.references.lyd.GetComponent<ButtonInfo>().text.text = this._language.mdb;
			this.references.lyf.GetComponent<ButtonInfo>().text.text = this._language.mdc;
			this.references.lye.GetComponent<ButtonInfo>().text.text = this._language.mdd;
			ControlMapper.jb jb = this.get(this._language.mci, this.references.lxs.mfw, Vector2.zero);
			jb.flk(false, false, true);
			this.kek = jb;
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x00090EC0 File Offset: 0x0008F0C0
		private void geg()
		{
			if (!this.mbi)
			{
				return;
			}
			this.references.lxu.mfv = this._language.mdk;
			this.references.lxu.gqx(this._showSettingsGroupLabel);
			ControlMapper.jb jb = this.get(this._language.mde, this.references.lxu.mfw, Vector2.zero);
			this.kel.Add(jb.jzg);
			jb.lvu.kgm += this.ggb;
			jb.flw(a.euj(), 0);
			jb.flx(new Action<ButtonInfo>(this.OnButtonActivated));
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x00090F74 File Offset: 0x0008F174
		private void geh()
		{
			if (!this.mbj)
			{
				return;
			}
			if (this._mappingSets == null)
			{
				return;
			}
			this.references.lxv.mfv = this._language.mdl;
			this.references.lxv.gqx(this._showMapCategoriesGroupLabel);
			for (int i = 0; i < this._mappingSets.Length; i++)
			{
				ControlMapper.MappingSet mappingSet = this._mappingSets[i];
				if (mappingSet != null && mappingSet.lwh)
				{
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(mappingSet.lwd);
					if (mapCategory != null)
					{
						ControlMapper.jb jb = new ControlMapper.jb(kq.grj<ButtonInfo>(this.prefabs.lww, this.references.lxv.mfw, mapCategory.name + a.euz()));
						jb.fln(this._language.gmv(mapCategory.id));
						jb.flw(a.euk(), mapCategory.id);
						jb.flx(new Action<ButtonInfo>(this.OnButtonActivated));
						jb.lvu.kgm += this.ggb;
						this.kei.Add(jb);
					}
				}
			}
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x000910A4 File Offset: 0x0008F2A4
		private void gei()
		{
			this.references.lyg.GetComponent<ButtonInfo>().text.text = this._language.mdf;
			this.references.lyh.GetComponent<ButtonInfo>().text.text = this._language.mdg;
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x000910FB File Offset: 0x0008F2FB
		private void gej(bool a, bool b)
		{
			this.gek(b);
			this.gel();
			this.gem(b);
			this.geo(a);
			if (this.mbh == null || !this.mbh.activeInHierarchy)
			{
				this.gfx();
			}
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x0009113C File Offset: 0x0008F33C
		private void gek(bool a)
		{
			if (!this.lzf)
			{
				return;
			}
			for (int i = 0; i < this.keh.Count; i++)
			{
				bool flag = this.kef != this.keh[i].lvu.intData;
				this.keh[i].flj(flag, a);
			}
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x000911A0 File Offset: 0x0008F3A0
		private void gel()
		{
			int num = -1;
			this.references.lyc.text = this._language.mci;
			kq.grq(this.references.lyd, false, false);
			kq.grq(this.references.lye, false, false);
			kq.grq(this.references.lyf, false, false);
			if (this.ggv())
			{
				foreach (ControlMapper.jb jb in this.kej)
				{
					if (!(jb.jzg == null))
					{
						if (this.mbh == jb.jzg)
						{
							num = jb.lvu.intData;
						}
						global::UnityEngine.Object.Destroy(jb.jzg);
					}
				}
				this.kej.Clear();
				this.kek.flr(true);
			}
			Player player = ReInput.players.GetPlayer(this.kef);
			if (player == null)
			{
				return;
			}
			if (this.ggv())
			{
				if (player.controllers.joystickCount > 0)
				{
					this.kek.flr(false);
				}
				foreach (Joystick joystick in player.controllers.Joysticks)
				{
					ControlMapper.jb jb2 = this.get(this._language.gmp(joystick), this.references.lxs.mfw, Vector2.zero);
					jb2.flw(a.euf(), joystick.id);
					jb2.flx(new Action<ButtonInfo>(this.OnButtonActivated));
					jb2.lvu.kgm += this.ggb;
					this.kej.Add(jb2);
					if (joystick.id == this.keo)
					{
						jb2.flj(false, true);
					}
				}
				if (player.controllers.joystickCount > 0 && !this.mbg)
				{
					this.keo = player.controllers.Joysticks[0].id;
					this.kej[0].flj(false, false);
				}
				if (num < 0)
				{
					goto IL_02B0;
				}
				using (List<ControlMapper.jb>.Enumerator enumerator = this.kej.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ControlMapper.jb jb3 = enumerator.Current;
						if (jb3.lvu.intData == num)
						{
							this.gfw(jb3.jzg);
							break;
						}
					}
					goto IL_02B0;
				}
			}
			if (player.controllers.joystickCount > 0 && !this.mbg)
			{
				this.keo = player.controllers.Joysticks[0].id;
			}
			IL_02B0:
			if (this.mbg && player.controllers.joystickCount > 0)
			{
				this.references.lyd.interactable = true;
				this.references.lyc.text = this._language.gmp(this.mbf);
				if (this.mbf.axisCount > 0)
				{
					this.references.lyf.interactable = true;
				}
			}
			int joystickCount = player.controllers.joystickCount;
			int joystickCount2 = ReInput.controllers.joystickCount;
			int num2 = this.ggu();
			bool flag = num2 == 0;
			if (joystickCount2 > 0 && joystickCount < joystickCount2 && (num2 == 1 || flag || joystickCount < num2))
			{
				kq.grq(this.references.lye, true, false);
			}
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x0009153C File Offset: 0x0008F73C
		private void gem(bool a)
		{
			if (!this.mbj)
			{
				return;
			}
			for (int i = 0; i < this.kei.Count; i++)
			{
				bool flag = this.keg != this.kei[i].lvu.intData;
				this.kei[i].flj(flag, a);
			}
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x0009159D File Offset: 0x0008F79D
		private void geo(bool a)
		{
			if (a)
			{
				this.gdn();
			}
			this.gdy();
			if (a)
			{
				this.geb();
			}
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x000915B7 File Offset: 0x0008F7B7
		private void gep()
		{
			if (this.kee.lyw)
			{
				this.gfk();
				return;
			}
			this.gej(false, false);
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x000915D8 File Offset: 0x0008F7D8
		private void geq(ref int a, InputCategory b)
		{
			this.ger(this._language.gmv(b.id), this.references.kaa, new Vector2(0f, (float)(a * this._inputRowHeight) * -1f));
			a++;
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00091628 File Offset: 0x0008F828
		private ControlMapper.jg ger(string a, Transform b, Vector2 c)
		{
			return this.ges(this.prefabs.lwy, a, b, c);
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x00091640 File Offset: 0x0008F840
		private ControlMapper.jg ges(GameObject a, string b, Transform c, Vector2 d)
		{
			GameObject gameObject = this.gez(a, c, d);
			TMP_Text componentInSelfOrChildren = UnityTools.GetComponentInSelfOrChildren<TMP_Text>(gameObject);
			if (componentInSelfOrChildren == null)
			{
				Debug.LogError(a.eva());
				return null;
			}
			componentInSelfOrChildren.text = b;
			return new ControlMapper.jg(gameObject);
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x00091681 File Offset: 0x0008F881
		private ControlMapper.jb get(string a, Transform b, Vector2 c)
		{
			ControlMapper.jb jb = new ControlMapper.jb(this.gez(this.prefabs.lww, b, c));
			jb.fln(a);
			return jb;
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x000916A2 File Offset: 0x0008F8A2
		private ControlMapper.jb geu(string a, Transform b, Vector2 c)
		{
			ControlMapper.jb jb = new ControlMapper.jb(this.gez(this.prefabs.lwx, b, c));
			jb.fln(a);
			return jb;
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x000916C4 File Offset: 0x0008F8C4
		private ControlMapper.jd gev(Transform a, Vector2 b, string c, int d, AxisRange e, ControllerType f, int g)
		{
			ControlMapper.jd jd = this.gew(a, b);
			jd.fln(a.tk());
			jd.fmi(d, e, f, g);
			jd.fmj(this.keu);
			jd.lvw.kgm += this.ggb;
			if (jd.lvw.kfw != null)
			{
				jd.lvw.kfw.lsg = (this._showGlyphs ? ControllerElementGlyphBase.AllowedTypes.All : ControllerElementGlyphBase.AllowedTypes.Text);
			}
			return jd;
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x00091746 File Offset: 0x0008F946
		private ControlMapper.jd gew(Transform a, Vector2 b)
		{
			return new ControlMapper.jd(this.gez(this.prefabs.lxa, a, b));
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x00091760 File Offset: 0x0008F960
		private ControlMapper.jf gex(GameObject a, Transform b, Vector2 c, string d, int e, AxisRange f, ControllerType g, int h)
		{
			ControlMapper.jf jf = this.gey(a, b, c);
			jf.fmr(e, f, g, h);
			jf.fms(this.kev);
			jf.lwb.kgm += this.ggb;
			return jf;
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x0009179C File Offset: 0x0008F99C
		private ControlMapper.jf gey(GameObject a, Transform b, Vector2 c)
		{
			return new ControlMapper.jf(this.gez(a, b, c));
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x000917AC File Offset: 0x0008F9AC
		private GameObject gez(GameObject a, Transform b, Vector2 c)
		{
			if (a == null)
			{
				Debug.LogError(a.evb());
				return null;
			}
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(a);
			return this.gfb(gameObject, b, c);
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x000917E0 File Offset: 0x0008F9E0
		private GameObject gfa(string a, Transform b, Vector2 c)
		{
			GameObject gameObject = new GameObject();
			gameObject.name = a;
			gameObject.AddComponent<RectTransform>();
			return this.gfb(gameObject, b, c);
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x0009180C File Offset: 0x0008FA0C
		private GameObject gfb(GameObject a, Transform b, Vector2 c)
		{
			if (a == null)
			{
				Debug.LogError(a.evc());
				return null;
			}
			RectTransform component = a.GetComponent<RectTransform>();
			if (component == null)
			{
				Debug.LogError(a.evd());
				return a;
			}
			if (b != null)
			{
				component.SetParent(b, false);
			}
			component.anchoredPosition = c;
			return a;
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x00091864 File Offset: 0x0008FA64
		private GameObject gfc(string a, Transform b, int c)
		{
			GameObject gameObject = this.gfa(a, b, Vector2.zero);
			this.ked.frw(gameObject);
			LayoutElement layoutElement = gameObject.AddComponent<LayoutElement>();
			if (c >= 0)
			{
				layoutElement.preferredWidth = (float)c;
			}
			RectTransform component = gameObject.GetComponent<RectTransform>();
			component.anchorMin = new Vector2(0f, 0f);
			component.anchorMax = new Vector2(1f, 0f);
			return gameObject;
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x000918CE File Offset: 0x0008FACE
		private Window gfd(bool a)
		{
			return this.gfe(string.Empty, a);
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x000918DC File Offset: 0x0008FADC
		private Window gfe(string a, bool b)
		{
			if (b)
			{
				this.kee.fvc();
			}
			Window window = this.kee.fuw(a, this._defaultWindowWidth, this._defaultWindowHeight);
			if (window == null)
			{
				return null;
			}
			this.gfl();
			return window;
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x00091922 File Offset: 0x0008FB22
		private Window gff(GameObject a, bool b)
		{
			return this.gfg(a, string.Empty, b);
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00091934 File Offset: 0x0008FB34
		private Window gfg(GameObject a, string b, bool c)
		{
			if (c)
			{
				this.kee.fvc();
			}
			Window window = this.kee.fux(a, b);
			if (window == null)
			{
				return null;
			}
			this.gfl();
			return window;
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00091970 File Offset: 0x0008FB70
		private void gfh(string a, string b, string c, Action<int> d, string e, Action<int> f, bool g)
		{
			ControlMapper.jy jy = new ControlMapper.jy();
			jy.kcs = this;
			jy.kct = this.gfd(g);
			if (jy.kct == null)
			{
				return;
			}
			jy.kct.gsr(this.prefabs.lxd, Vector2.zero, a);
			jy.kct.gst(this.prefabs.lxe, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), b);
			UnityAction unityAction = new UnityAction(jy.fwb);
			jy.kct.cancelCallback = unityAction;
			jy.kct.gsw(this.prefabs.lwx, UIPivot.BottomLeft, UIAnchor.BottomLeft, Vector2.zero, c, new UnityAction(jy.fwc), unityAction, false);
			jy.kct.gsw(this.prefabs.lwx, UIPivot.BottomRight, UIAnchor.BottomRight, Vector2.zero, e, unityAction, unityAction, true);
			this.kee.fvg(jy.kct);
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00091A7B File Offset: 0x0008FC7B
		private void gfi(int a)
		{
			if (!this.kee.lyw)
			{
				return;
			}
			this.kee.fuz(a);
			this.gfm();
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x00091A9D File Offset: 0x0008FC9D
		private void gfj()
		{
			if (!this.kee.lyw)
			{
				return;
			}
			this.kee.fuy();
			this.gfm();
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x00091ABE File Offset: 0x0008FCBE
		private void gfk()
		{
			if (!this.kee.lyw)
			{
				return;
			}
			this.kee.fvc();
			this.gfm();
			this.gha();
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x00091AE5 File Offset: 0x0008FCE5
		private void gfl()
		{
			if (!this.kee.lyw)
			{
				return;
			}
			this.ggc(false);
			if (this.kdv != null)
			{
				this.kdv();
			}
			if (this._onPopupWindowOpened != null)
			{
				this._onPopupWindowOpened.Invoke();
			}
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x00091B22 File Offset: 0x0008FD22
		private void gfm()
		{
			if (this.kee.lyw)
			{
				return;
			}
			this.ggc(true);
			if (this.kdw != null)
			{
				this.kdw();
			}
			if (this._onPopupWindowClosed != null)
			{
				this._onPopupWindowClosed.Invoke();
			}
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x00091B60 File Offset: 0x0008FD60
		private bool gfn(Player a, ControlMapper.ji b, ElementAssignment c, bool d)
		{
			if (a == null || b == null)
			{
				return false;
			}
			ElementAssignmentConflictCheck elementAssignmentConflictCheck;
			if (!this.gfq(b, c, out elementAssignmentConflictCheck))
			{
				return false;
			}
			if (d)
			{
				return ReInput.players.SystemPlayer.controllers.conflictChecking.DoesElementAssignmentConflict(elementAssignmentConflictCheck) || a.controllers.conflictChecking.DoesElementAssignmentConflict(elementAssignmentConflictCheck);
			}
			return ReInput.controllers.conflictChecking.DoesElementAssignmentConflict(elementAssignmentConflictCheck);
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x00091BCC File Offset: 0x0008FDCC
		private bool gfo(ControlMapper.ji a, ElementAssignment b, bool c)
		{
			ElementAssignmentConflictCheck elementAssignmentConflictCheck;
			if (!this.gfq(a, b, out elementAssignmentConflictCheck))
			{
				return false;
			}
			if (c)
			{
				foreach (ElementAssignmentConflictInfo elementAssignmentConflictInfo in ReInput.players.SystemPlayer.controllers.conflictChecking.ElementAssignmentConflicts(elementAssignmentConflictCheck))
				{
					if (!elementAssignmentConflictInfo.isUserAssignable)
					{
						return true;
					}
				}
				using (IEnumerator<ElementAssignmentConflictInfo> enumerator = this.mbc.controllers.conflictChecking.ElementAssignmentConflicts(elementAssignmentConflictCheck).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ElementAssignmentConflictInfo elementAssignmentConflictInfo2 = enumerator.Current;
						if (!elementAssignmentConflictInfo2.isUserAssignable)
						{
							return true;
						}
					}
					return false;
				}
			}
			foreach (ElementAssignmentConflictInfo elementAssignmentConflictInfo3 in ReInput.controllers.conflictChecking.ElementAssignmentConflicts(elementAssignmentConflictCheck))
			{
				if (!elementAssignmentConflictInfo3.isUserAssignable)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x00091CF0 File Offset: 0x0008FEF0
		private IEnumerable<ElementAssignmentConflictInfo> gfp(Player a, ControlMapper.ji b, ElementAssignment c, bool d)
		{
			if (a == null || b == null)
			{
				yield break;
			}
			ElementAssignmentConflictCheck elementAssignmentConflictCheck;
			if (!this.gfq(b, c, out elementAssignmentConflictCheck))
			{
				yield break;
			}
			if (d)
			{
				foreach (ElementAssignmentConflictInfo elementAssignmentConflictInfo in ReInput.players.SystemPlayer.controllers.conflictChecking.ElementAssignmentConflicts(elementAssignmentConflictCheck))
				{
					if (!elementAssignmentConflictInfo.isUserAssignable)
					{
						yield return elementAssignmentConflictInfo;
					}
				}
				IEnumerator<ElementAssignmentConflictInfo> enumerator = null;
				foreach (ElementAssignmentConflictInfo elementAssignmentConflictInfo2 in a.controllers.conflictChecking.ElementAssignmentConflicts(elementAssignmentConflictCheck))
				{
					if (!elementAssignmentConflictInfo2.isUserAssignable)
					{
						yield return elementAssignmentConflictInfo2;
					}
				}
				enumerator = null;
			}
			else
			{
				foreach (ElementAssignmentConflictInfo elementAssignmentConflictInfo3 in ReInput.controllers.conflictChecking.ElementAssignmentConflicts(elementAssignmentConflictCheck))
				{
					if (!elementAssignmentConflictInfo3.isUserAssignable)
					{
						yield return elementAssignmentConflictInfo3;
					}
				}
				IEnumerator<ElementAssignmentConflictInfo> enumerator = null;
			}
			yield break;
			yield break;
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x00091D20 File Offset: 0x0008FF20
		private bool gfq(ControlMapper.ji a, ElementAssignment b, out ElementAssignmentConflictCheck c)
		{
			if (a == null || this.mbc == null)
			{
				c = default(ElementAssignmentConflictCheck);
				return false;
			}
			c = b.ToElementAssignmentConflictCheck();
			c.playerId = this.mbc.id;
			c.controllerType = a.kao;
			c.controllerId = a.kap;
			c.controllerMapId = a.kam.id;
			c.controllerMapCategoryId = a.kam.categoryId;
			if (a.kan != null)
			{
				c.elementMapId = a.kan.id;
			}
			return true;
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x00091DB4 File Offset: 0x0008FFB4
		private void gfr(out ControllerPollingInfo a, out bool b, out ModifierKeyFlags c, out string d)
		{
			a = default(ControllerPollingInfo);
			d = string.Empty;
			b = false;
			c = ModifierKeyFlags.None;
			int num = 0;
			ControllerPollingInfo controllerPollingInfo = default(ControllerPollingInfo);
			ControllerPollingInfo controllerPollingInfo2 = default(ControllerPollingInfo);
			ModifierKeyFlags modifierKeyFlags = ModifierKeyFlags.None;
			foreach (ControllerPollingInfo controllerPollingInfo3 in ReInput.controllers.Keyboard.PollForAllKeys())
			{
				KeyCode keyboardKey = controllerPollingInfo3.keyboardKey;
				if (keyboardKey != KeyCode.AltGr)
				{
					if (Keyboard.IsModifierKey(controllerPollingInfo3.keyboardKey))
					{
						if (num == 0)
						{
							controllerPollingInfo2 = controllerPollingInfo3;
						}
						modifierKeyFlags |= Keyboard.KeyCodeToModifierKeyFlags(keyboardKey);
						num++;
					}
					else if (controllerPollingInfo.keyboardKey == KeyCode.None)
					{
						controllerPollingInfo = controllerPollingInfo3;
					}
				}
			}
			if (controllerPollingInfo.keyboardKey == KeyCode.None)
			{
				if (num > 0)
				{
					b = true;
					if (num == 1)
					{
						if (ReInput.controllers.Keyboard.GetKeyTimePressed(controllerPollingInfo2.keyboardKey) > 1.0)
						{
							a = controllerPollingInfo2;
							return;
						}
						d = Keyboard.GetKeyName(controllerPollingInfo2.keyboardKey);
						return;
					}
					else
					{
						d = this._language.gmy(modifierKeyFlags);
					}
				}
				return;
			}
			if (!ReInput.controllers.Keyboard.GetKeyDown(controllerPollingInfo.keyboardKey))
			{
				return;
			}
			if (num == 0)
			{
				a = controllerPollingInfo;
				return;
			}
			a = controllerPollingInfo;
			c = modifierKeyFlags;
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x00091F00 File Offset: 0x00090100
		private bool gfs(ElementAssignmentConflictCheck a, out ElementAssignmentConflictInfo b, bool c)
		{
			if (this.gft(this.mbc, a, out b))
			{
				return true;
			}
			if (this.gft(ReInput.players.SystemPlayer, a, out b))
			{
				return true;
			}
			if (!c)
			{
				IList<Player> players = ReInput.players.Players;
				for (int i = 0; i < players.Count; i++)
				{
					Player player = players[i];
					if (player != this.mbc && this.gft(player, a, out b))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x00091F74 File Offset: 0x00090174
		private bool gft(Player a, ElementAssignmentConflictCheck b, out ElementAssignmentConflictInfo c)
		{
			using (IEnumerator<ElementAssignmentConflictInfo> enumerator = a.controllers.conflictChecking.ElementAssignmentConflicts(b).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					ElementAssignmentConflictInfo elementAssignmentConflictInfo = enumerator.Current;
					c = elementAssignmentConflictInfo;
					return true;
				}
			}
			c = default(ElementAssignmentConflictInfo);
			return false;
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x00091FDC File Offset: 0x000901DC
		private void gfu(int a)
		{
			if (this.mbc == null)
			{
				return;
			}
			if (this.mbc.controllers.joystickCount == 0)
			{
				return;
			}
			Joystick joystick = this.mbf;
			if (a < 0 || a >= joystick.axisCount)
			{
				return;
			}
			this.ket = new ControlMapper.jj(joystick, a);
			this.gdh();
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x0009202D File Offset: 0x0009022D
		private void gfv()
		{
			if (this.ket == null)
			{
				return;
			}
			this.ket.frk();
			this.ket = null;
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x0009204A File Offset: 0x0009024A
		private void gfw(GameObject a)
		{
			if (EventSystem.current == null)
			{
				return;
			}
			EventSystem.current.SetSelectedGameObject(a);
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x00092065 File Offset: 0x00090265
		private void gfx()
		{
			if (this.ken == null || !this.ken.activeInHierarchy)
			{
				this.gfy();
				return;
			}
			this.gfw(this.ken);
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x00092095 File Offset: 0x00090295
		private void gfy()
		{
			if (!this.max)
			{
				return;
			}
			if (this.references.lyi == null)
			{
				this.gfw(null);
				return;
			}
			this.gfw(this.references.lyi.gameObject);
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x000920D4 File Offset: 0x000902D4
		private void gfz(bool a)
		{
			this.keg = this.ggo();
			this.gca(this.keg, a);
			if (!this.mbj)
			{
				return;
			}
			for (int i = 0; i < this._mappingSets.Length; i++)
			{
				if (ReInput.mapping.GetMapCategory(this._mappingSets[i].lwd) != null)
				{
					this.keg = this._mappingSets[i].lwd;
					break;
				}
			}
			if (this.keg < 0)
			{
				return;
			}
			for (int j = 0; j < this._mappingSets.Length; j++)
			{
				bool flag = this._mappingSets[j].lwd != this.keg;
				this.kei[j].flj(flag, false);
			}
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x0009218E File Offset: 0x0009038E
		private void gga()
		{
			if (!this.may)
			{
				return;
			}
			if (this.mbh == null)
			{
				this.gfx();
			}
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x000921AD File Offset: 0x000903AD
		private void ggb(GameObject a)
		{
			this.ken = a;
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x000921B6 File Offset: 0x000903B6
		private void ggc(bool a)
		{
			this.references.lxl.interactable = a;
			if (a)
			{
				this.gej(false, false);
				this.gfx();
				this.kep = Time.unscaledTime + 0.1f;
			}
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x000921EB File Offset: 0x000903EB
		public void ggd()
		{
			if (this.max)
			{
				this.Close(true);
				return;
			}
			this.Open();
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x00092203 File Offset: 0x00090403
		public void Open()
		{
			this.Open(false);
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x0009220C File Offset: 0x0009040C
		private void Open(bool force)
		{
			if (!this.keb)
			{
				this.gbr();
			}
			if (!this.keb)
			{
				return;
			}
			if (!force && this.max)
			{
				return;
			}
			this.gge();
			if (ControlMapper.kea == null)
			{
				ControlMapper.kea = this;
			}
			this.kem.SetActive(true);
			this.gbx(0, false);
			this.gfz(false);
			this.gfy();
			this.gej(true, false);
			if (this.kdu != null)
			{
				this.kdu();
			}
			if (this._onScreenOpened != null)
			{
				this._onScreenOpened.Invoke();
			}
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x000922A4 File Offset: 0x000904A4
		public void Close(bool save)
		{
			if (!this.keb)
			{
				return;
			}
			if (!this.max)
			{
				return;
			}
			if (save && ReInput.userDataStore != null)
			{
				ReInput.userDataStore.Save();
			}
			this.gge();
			this.kem.SetActive(false);
			this.gfw(null);
			if (ControlMapper.kea == this)
			{
				ControlMapper.kea = null;
			}
			if (this.kdt != null)
			{
				this.kdt();
			}
			if (this._onScreenClosed != null)
			{
				this._onScreenClosed.Invoke();
			}
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x00092329 File Offset: 0x00090529
		private void gge()
		{
			this.gfk();
			this.ken = null;
			this.kes = null;
			this.ket = null;
			this.gha();
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x0009234C File Offset: 0x0009054C
		private void ggf()
		{
			this.gge();
			this.ggg();
			this.ggj();
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x00092360 File Offset: 0x00090560
		private void ggg()
		{
			this.kee.fvp();
			this.ked.fsn();
			foreach (ControlMapper.jb jb in this.keh)
			{
				global::UnityEngine.Object.Destroy(jb.jzg);
			}
			this.keh.Clear();
			foreach (ControlMapper.jb jb2 in this.kei)
			{
				global::UnityEngine.Object.Destroy(jb2.jzg);
			}
			this.kei.Clear();
			foreach (ControlMapper.jb jb3 in this.kej)
			{
				global::UnityEngine.Object.Destroy(jb3.jzg);
			}
			this.kej.Clear();
			if (this.kek != null)
			{
				global::UnityEngine.Object.Destroy(this.kek.jzg);
				this.kek = null;
			}
			foreach (GameObject gameObject in this.kel)
			{
				global::UnityEngine.Object.Destroy(gameObject);
			}
			this.kel.Clear();
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x000924E0 File Offset: 0x000906E0
		private void ggh()
		{
			this.keo = -1;
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x000924E0 File Offset: 0x000906E0
		private void ggi()
		{
			this.keo = -1;
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x000924EC File Offset: 0x000906EC
		private void ggj()
		{
			this.keb = false;
			if (ControlMapper.kea == this)
			{
				ControlMapper.kea = null;
			}
			this.kec = 0;
			this.ked = null;
			this.kee = null;
			this.kef = -1;
			this.keg = -1;
			this.keh = null;
			this.kei = null;
			this.kel = null;
			this.kem = null;
			this.ken = null;
			this.keo = -1;
			this.kes = null;
			this.ket = null;
			this.keu = null;
			this.kev = null;
			this.keq = false;
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00092583 File Offset: 0x00090783
		public void Reset()
		{
			if (!this.keb)
			{
				return;
			}
			bool flag = this.max;
			this.Close(false);
			this.ggf();
			this.gbr();
			if (flag)
			{
				this.Open(true);
			}
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x000925B0 File Offset: 0x000907B0
		private void ggk(bool a, ControllerType b, int c)
		{
			if (this.mbc == null)
			{
				return;
			}
			ControllerMapWithAxes controllerMapWithAxes = this.ggl(b) as ControllerMapWithAxes;
			if (controllerMapWithAxes == null)
			{
				return;
			}
			ActionElementMap elementMap = controllerMapWithAxes.GetElementMap(c);
			if (elementMap == null)
			{
				return;
			}
			elementMap.invert = a;
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x000925EC File Offset: 0x000907EC
		private ControllerMap ggl(ControllerType a)
		{
			if (this.mbc == null)
			{
				return null;
			}
			int num = 0;
			switch (a)
			{
			case ControllerType.Keyboard:
			case ControllerType.Mouse:
				break;
			case ControllerType.Joystick:
				if (this.mbc.controllers.joystickCount <= 0)
				{
					return null;
				}
				num = this.mbf.id;
				break;
			default:
				throw new NotImplementedException();
			}
			return this.mbc.controllers.maps.GetFirstMapInCategory(a, num, this.keg);
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x00092660 File Offset: 0x00090860
		private ControllerMap ggm(ControllerType a, int b, int c)
		{
			ControllerMap controllerMap = this.ggl(a);
			if (controllerMap == null)
			{
				this.mbc.controllers.maps.AddEmptyMap(a, b, this.keg, c);
				controllerMap = this.mbc.controllers.maps.GetMap(a, b, this.keg, c);
			}
			return controllerMap;
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x000926B8 File Offset: 0x000908B8
		private int ggn<a>(IEnumerable<a> a)
		{
			if (a == null)
			{
				return 0;
			}
			IEnumerator<a> enumerator = a.GetEnumerator();
			if (enumerator == null)
			{
				return 0;
			}
			int num = 0;
			while (enumerator.MoveNext())
			{
				num++;
			}
			return num;
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x000926E8 File Offset: 0x000908E8
		private int ggo()
		{
			if (this._mappingSets.Length == 0)
			{
				return 0;
			}
			for (int i = 0; i < this._mappingSets.Length; i++)
			{
				if (ReInput.mapping.GetMapCategory(this._mappingSets[i].lwd) != null)
				{
					return this._mappingSets[i].lwd;
				}
			}
			return 0;
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x0009273C File Offset: 0x0009093C
		private void ggp()
		{
			if (this.references.lyj == null)
			{
				return;
			}
			GameObject[] array = this.references.lyj;
			for (int i = 0; i < array.Length; i++)
			{
				km component = UnityTools.GetComponent<km>(array[i]);
				if (!(component == null))
				{
					component.kgm += this.ggb;
				}
			}
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00092798 File Offset: 0x00090998
		private void ggq()
		{
			this.ggs(this._screenToggleAction, new Action<InputActionEventData>(this.gcc));
			this.ggs(this._screenOpenAction, new Action<InputActionEventData>(this.gcd));
			this.ggs(this._screenCloseAction, new Action<InputActionEventData>(this.gce));
			this.ggs(this._universalCancelAction, new Action<InputActionEventData>(this.gcf));
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x00092808 File Offset: 0x00090A08
		private void ggr()
		{
			this.ggt(this._screenToggleAction, new Action<InputActionEventData>(this.gcc));
			this.ggt(this._screenOpenAction, new Action<InputActionEventData>(this.gcd));
			this.ggt(this._screenCloseAction, new Action<InputActionEventData>(this.gce));
			this.ggt(this._universalCancelAction, new Action<InputActionEventData>(this.gcf));
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x00092878 File Offset: 0x00090A78
		private void ggs(int a, Action<InputActionEventData> b)
		{
			if (a < 0 || b == null)
			{
				return;
			}
			if (ReInput.mapping.GetAction(a) == null)
			{
				Debug.LogWarning(a.eve() + a.ToString() + a.evf());
				return;
			}
			foreach (Player player in ReInput.players.AllPlayers)
			{
				player.AddInputEventDelegate(b, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, a);
			}
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x000928FC File Offset: 0x00090AFC
		private void ggt(int a, Action<InputActionEventData> b)
		{
			if (a < 0 || b == null)
			{
				return;
			}
			if (!ReInput.isReady)
			{
				return;
			}
			if (ReInput.mapping.GetAction(a) == null)
			{
				Debug.LogWarning(a.eve() + a.ToString() + a.evf());
				return;
			}
			foreach (Player player in ReInput.players.AllPlayers)
			{
				player.RemoveInputEventDelegate(b, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, a);
			}
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x00092988 File Offset: 0x00090B88
		private int ggu()
		{
			if (this._rewiredInputManager.userData.ConfigVars.autoAssignJoysticks)
			{
				return this._rewiredInputManager.userData.ConfigVars.maxJoysticksPerPlayer;
			}
			return this._maxControllersPerPlayer;
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x000929BD File Offset: 0x00090BBD
		private bool ggv()
		{
			return this._showControllers && (this._showAssignedControllers || this.ggu() != 1);
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x000929DF File Offset: 0x00090BDF
		private void ggw(bool a = false)
		{
			if (a)
			{
				this.Reset();
			}
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x000929EC File Offset: 0x00090BEC
		private void AssignController(Player player, int controllerId)
		{
			if (player == null)
			{
				return;
			}
			if (player.controllers.ContainsController(ControllerType.Joystick, controllerId))
			{
				return;
			}
			if (this.ggu() == 1)
			{
				this.ggx(player);
				this.ggi();
			}
			foreach (Player player2 in ReInput.players.Players)
			{
				if (player2 != player)
				{
					this.RemoveController(player2, controllerId);
				}
			}
			player.controllers.AddController(ControllerType.Joystick, controllerId, false);
			if (ReInput.userDataStore != null)
			{
				ReInput.userDataStore.LoadControllerData(player.id, ControllerType.Joystick, controllerId);
			}
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x00092A94 File Offset: 0x00090C94
		private void ggx(Player a)
		{
			if (a == null)
			{
				return;
			}
			IList<Joystick> joysticks = a.controllers.Joysticks;
			for (int i = joysticks.Count - 1; i >= 0; i--)
			{
				this.RemoveController(a, joysticks[i].id);
			}
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x00092AD7 File Offset: 0x00090CD7
		private void RemoveController(Player player, int controllerId)
		{
			if (player == null)
			{
				return;
			}
			if (!player.controllers.ContainsController(ControllerType.Joystick, controllerId))
			{
				return;
			}
			if (ReInput.userDataStore != null)
			{
				ReInput.userDataStore.SaveControllerData(player.id, ControllerType.Joystick, controllerId);
			}
			player.controllers.RemoveController(ControllerType.Joystick, controllerId);
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x00092B13 File Offset: 0x00090D13
		private bool ggy(ControlMapper.ji a, ControllerPollingInfo b)
		{
			return a != null && (a.lyn != AxisRange.Full || this._showSplitAxisInputFields || b.elementType != ControllerElementType.Button);
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x00092B37 File Offset: 0x00090D37
		private void ggz()
		{
			bool flag = this.keq;
			this.keq = true;
			if (!flag)
			{
				if (this.kdx != null)
				{
					this.kdx();
				}
				if (this._onInputPollingStarted != null)
				{
					this._onInputPollingStarted.Invoke();
				}
			}
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x00092B6E File Offset: 0x00090D6E
		private void gha()
		{
			bool flag = this.keq;
			this.keq = false;
			if (flag)
			{
				if (this.kdy != null)
				{
					this.kdy();
				}
				if (this._onInputPollingEnded != null)
				{
					this._onInputPollingEnded.Invoke();
				}
			}
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x00092BA5 File Offset: 0x00090DA5
		private int ghb(ControllerType a)
		{
			switch (a)
			{
			case ControllerType.Keyboard:
				return this._keyboardInputFieldCount;
			case ControllerType.Mouse:
				return this._mouseInputFieldCount;
			case ControllerType.Joystick:
				return this._controllerInputFieldCount;
			default:
				throw new NotImplementedException();
			}
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x00092BD8 File Offset: 0x00090DD8
		private bool ghc(int a, ControlMapper.ji b, ElementAssignment c, bool d)
		{
			if (this.mbc == null)
			{
				return false;
			}
			if (!this._allowElementAssignmentSwap)
			{
				return false;
			}
			if (b == null || b.kan == null)
			{
				return false;
			}
			ElementAssignmentConflictCheck elementAssignmentConflictCheck;
			if (!this.gfq(b, c, out elementAssignmentConflictCheck))
			{
				Debug.LogError(a.eun());
				return false;
			}
			List<ElementAssignmentConflictInfo> list = new List<ElementAssignmentConflictInfo>();
			list.AddRange(this.mbc.controllers.conflictChecking.ElementAssignmentConflicts(elementAssignmentConflictCheck));
			list.AddRange(ReInput.players.SystemPlayer.controllers.conflictChecking.ElementAssignmentConflicts(elementAssignmentConflictCheck));
			if (list.Count == 0)
			{
				return false;
			}
			ActionElementMap actionElementMap = b.kan;
			ElementAssignmentConflictInfo elementAssignmentConflictInfo = list[0];
			int actionId = elementAssignmentConflictInfo.elementMap.actionId;
			Pole axisContribution = elementAssignmentConflictInfo.elementMap.axisContribution;
			AxisRange axisRange = actionElementMap.axisRange;
			ControllerElementType elementType = actionElementMap.elementType;
			if (elementType == elementAssignmentConflictInfo.elementMap.elementType && elementType == ControllerElementType.Axis)
			{
				if (axisRange != elementAssignmentConflictInfo.elementMap.axisRange)
				{
					if (axisRange == AxisRange.Full)
					{
						axisRange = AxisRange.Positive;
					}
					else if (elementAssignmentConflictInfo.elementMap.axisRange == AxisRange.Full)
					{
					}
				}
			}
			else if (elementType == ControllerElementType.Axis && (elementAssignmentConflictInfo.elementMap.elementType == ControllerElementType.Button || (elementAssignmentConflictInfo.elementMap.elementType == ControllerElementType.Axis && elementAssignmentConflictInfo.elementMap.axisRange != AxisRange.Full)) && axisRange == AxisRange.Full)
			{
				axisRange = AxisRange.Positive;
			}
			int num = 0;
			if (c.actionId == elementAssignmentConflictInfo.actionId && b.kam == elementAssignmentConflictInfo.controllerMap)
			{
				Controller controller = ReInput.controllers.GetController(b.kao, b.kap);
				if (this.ghd(elementType, axisRange, axisContribution, controller.GetElementById(c.elementIdentifierId).type, c.axisRange, c.axisContribution))
				{
					num++;
				}
			}
			using (IEnumerator<ActionElementMap> enumerator = elementAssignmentConflictInfo.controllerMap.ElementMapsWithAction(actionId).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ControlMapper.jz jz = new ControlMapper.jz();
					jz.kcu = enumerator.Current;
					if (jz.kcu.id != actionElementMap.id && list.FindIndex(new Predicate<ElementAssignmentConflictInfo>(jz.fwd)) < 0 && this.ghd(elementType, axisRange, axisContribution, jz.kcu.elementType, jz.kcu.axisRange, jz.kcu.axisContribution))
					{
						num++;
					}
				}
			}
			return num < this.ghb(b.kao);
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x00092E50 File Offset: 0x00091050
		private bool ghd(ControllerElementType a, AxisRange b, Pole c, ControllerElementType d, AxisRange e, Pole f)
		{
			return ((a == ControllerElementType.Button || (a == ControllerElementType.Axis && b != AxisRange.Full)) && (d == ControllerElementType.Button || (d == ControllerElementType.Axis && e != AxisRange.Full)) && f == c) || (a == ControllerElementType.Axis && b == AxisRange.Full && d == ControllerElementType.Axis && e == AxisRange.Full);
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x00092E84 File Offset: 0x00091084
		private void ghe()
		{
			for (int i = 0; i < this.ker.Count; i++)
			{
				if (this.ker != null)
				{
					this.ker[i].gqg();
				}
			}
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x00092EC0 File Offset: 0x000910C0
		public static void ghf(ThemedElement a)
		{
			if (a == null)
			{
				return;
			}
			if (ControlMapper.kea == null)
			{
				return;
			}
			if (ControlMapper.kea.ker.Contains(a))
			{
				return;
			}
			ControlMapper.kea.ker.Add(a);
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x00092EFD File Offset: 0x000910FD
		public static void ghg(ThemedElement a)
		{
			if (a == null)
			{
				return;
			}
			if (ControlMapper.kea == null)
			{
				return;
			}
			ControlMapper.kea.ker.Remove(a);
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00092F28 File Offset: 0x00091128
		public static void ghh(ThemedElement.ElementInfo[] a)
		{
			if (ControlMapper.kea == null)
			{
				return;
			}
			if (ControlMapper.kea._themeSettings == null)
			{
				return;
			}
			if (!ControlMapper.kea._useThemeSettings)
			{
				return;
			}
			ControlMapper.kea._themeSettings.gpx(a);
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x00092F68 File Offset: 0x00091168
		public static LanguageDataBase ghi()
		{
			if (ControlMapper.kea == null)
			{
				return null;
			}
			return ControlMapper.kea._language;
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x00092F83 File Offset: 0x00091183
		public static ControlMapper mbk
		{
			get
			{
				return ControlMapper.kea;
			}
		}

		// Token: 0x04000FFC RID: 4092
		public const int versionMajor = 1;

		// Token: 0x04000FFD RID: 4093
		public const int versionMinor = 1;

		// Token: 0x04000FFE RID: 4094
		public const bool usesTMPro = true;

		// Token: 0x04000FFF RID: 4095
		private const float kdj = 0.1f;

		// Token: 0x04001000 RID: 4096
		private const string kdk = "PlayerSelection";

		// Token: 0x04001001 RID: 4097
		private const string kdl = "RemoveController";

		// Token: 0x04001002 RID: 4098
		private const string kdm = "AssignController";

		// Token: 0x04001003 RID: 4099
		private const string kdn = "CalibrateController";

		// Token: 0x04001004 RID: 4100
		private const string kdo = "EditInputBehaviors";

		// Token: 0x04001005 RID: 4101
		private const string kdp = "MapCategorySelection";

		// Token: 0x04001006 RID: 4102
		private const string kdq = "AssignedControllerSelection";

		// Token: 0x04001007 RID: 4103
		private const string kdr = "Done";

		// Token: 0x04001008 RID: 4104
		private const string kds = "RestoreDefaults";

		// Token: 0x04001009 RID: 4105
		[SerializeField]
		private InputManager _rewiredInputManager;

		// Token: 0x0400100A RID: 4106
		[SerializeField]
		private bool _dontDestroyOnLoad;

		// Token: 0x0400100B RID: 4107
		[SerializeField]
		private bool _openOnStart;

		// Token: 0x0400100C RID: 4108
		[SerializeField]
		private int _keyboardMapDefaultLayout;

		// Token: 0x0400100D RID: 4109
		[SerializeField]
		private int _mouseMapDefaultLayout;

		// Token: 0x0400100E RID: 4110
		[SerializeField]
		private int _joystickMapDefaultLayout;

		// Token: 0x0400100F RID: 4111
		[SerializeField]
		private ControlMapper.MappingSet[] _mappingSets = new ControlMapper.MappingSet[] { ControlMapper.MappingSet.lwi };

		// Token: 0x04001010 RID: 4112
		[SerializeField]
		private bool _showPlayers = true;

		// Token: 0x04001011 RID: 4113
		[SerializeField]
		private bool _showControllers = true;

		// Token: 0x04001012 RID: 4114
		[SerializeField]
		private bool _showKeyboard = true;

		// Token: 0x04001013 RID: 4115
		[SerializeField]
		private bool _showMouse = true;

		// Token: 0x04001014 RID: 4116
		[SerializeField]
		private int _maxControllersPerPlayer = 1;

		// Token: 0x04001015 RID: 4117
		[SerializeField]
		private bool _showActionCategoryLabels;

		// Token: 0x04001016 RID: 4118
		[SerializeField]
		private int _keyboardInputFieldCount = 2;

		// Token: 0x04001017 RID: 4119
		[SerializeField]
		private int _mouseInputFieldCount = 1;

		// Token: 0x04001018 RID: 4120
		[SerializeField]
		private int _controllerInputFieldCount = 1;

		// Token: 0x04001019 RID: 4121
		[SerializeField]
		private bool _showFullAxisInputFields = true;

		// Token: 0x0400101A RID: 4122
		[SerializeField]
		private bool _showSplitAxisInputFields = true;

		// Token: 0x0400101B RID: 4123
		[SerializeField]
		private bool _showGlyphs = true;

		// Token: 0x0400101C RID: 4124
		[SerializeField]
		private bool _allowElementAssignmentConflicts;

		// Token: 0x0400101D RID: 4125
		[SerializeField]
		private bool _allowElementAssignmentSwap;

		// Token: 0x0400101E RID: 4126
		[SerializeField]
		private int _actionLabelWidth = 200;

		// Token: 0x0400101F RID: 4127
		[SerializeField]
		private int _keyboardColMaxWidth = 360;

		// Token: 0x04001020 RID: 4128
		[SerializeField]
		private int _mouseColMaxWidth = 200;

		// Token: 0x04001021 RID: 4129
		[SerializeField]
		private int _controllerColMaxWidth = 200;

		// Token: 0x04001022 RID: 4130
		[SerializeField]
		private int _inputRowHeight = 40;

		// Token: 0x04001023 RID: 4131
		[SerializeField]
		private RectOffset _inputRowPadding = new RectOffset();

		// Token: 0x04001024 RID: 4132
		[SerializeField]
		private int _inputRowFieldSpacing;

		// Token: 0x04001025 RID: 4133
		[SerializeField]
		private int _inputColumnSpacing = 40;

		// Token: 0x04001026 RID: 4134
		[SerializeField]
		private int _inputRowCategorySpacing = 20;

		// Token: 0x04001027 RID: 4135
		[SerializeField]
		private int _invertToggleWidth = 40;

		// Token: 0x04001028 RID: 4136
		[SerializeField]
		private int _defaultWindowWidth = 500;

		// Token: 0x04001029 RID: 4137
		[SerializeField]
		private int _defaultWindowHeight = 400;

		// Token: 0x0400102A RID: 4138
		[SerializeField]
		private float _controllerAssignmentTimeout = 5f;

		// Token: 0x0400102B RID: 4139
		[SerializeField]
		private float _preInputAssignmentTimeout = 5f;

		// Token: 0x0400102C RID: 4140
		[SerializeField]
		private float _inputAssignmentTimeout = 5f;

		// Token: 0x0400102D RID: 4141
		[SerializeField]
		private float _axisCalibrationTimeout = 5f;

		// Token: 0x0400102E RID: 4142
		[SerializeField]
		private bool _ignoreMouseXAxisAssignment = true;

		// Token: 0x0400102F RID: 4143
		[SerializeField]
		private bool _ignoreMouseYAxisAssignment = true;

		// Token: 0x04001030 RID: 4144
		[SerializeField]
		private int _screenToggleAction = -1;

		// Token: 0x04001031 RID: 4145
		[SerializeField]
		private int _screenOpenAction = -1;

		// Token: 0x04001032 RID: 4146
		[SerializeField]
		private int _screenCloseAction = -1;

		// Token: 0x04001033 RID: 4147
		[SerializeField]
		private int _universalCancelAction = -1;

		// Token: 0x04001034 RID: 4148
		[SerializeField]
		private bool _universalCancelClosesScreen = true;

		// Token: 0x04001035 RID: 4149
		[SerializeField]
		private bool _showInputBehaviorSettings;

		// Token: 0x04001036 RID: 4150
		[SerializeField]
		private ControlMapper.InputBehaviorSettings[] _inputBehaviorSettings;

		// Token: 0x04001037 RID: 4151
		[SerializeField]
		private bool _useThemeSettings = true;

		// Token: 0x04001038 RID: 4152
		[SerializeField]
		private ThemeSettings _themeSettings;

		// Token: 0x04001039 RID: 4153
		[SerializeField]
		private LanguageDataBase _language;

		// Token: 0x0400103A RID: 4154
		[SerializeField]
		private ControlMapper.Prefabs prefabs;

		// Token: 0x0400103B RID: 4155
		[SerializeField]
		private ControlMapper.References references;

		// Token: 0x0400103C RID: 4156
		[SerializeField]
		private bool _showPlayersGroupLabel = true;

		// Token: 0x0400103D RID: 4157
		[SerializeField]
		private bool _showControllerGroupLabel = true;

		// Token: 0x0400103E RID: 4158
		[SerializeField]
		private bool _showAssignedControllersGroupLabel = true;

		// Token: 0x0400103F RID: 4159
		[SerializeField]
		private bool _showSettingsGroupLabel = true;

		// Token: 0x04001040 RID: 4160
		[SerializeField]
		private bool _showMapCategoriesGroupLabel = true;

		// Token: 0x04001041 RID: 4161
		[SerializeField]
		private bool _showControllerNameLabel = true;

		// Token: 0x04001042 RID: 4162
		[SerializeField]
		private bool _showAssignedControllers = true;

		// Token: 0x04001043 RID: 4163
		private Action kdt;

		// Token: 0x04001044 RID: 4164
		private Action kdu;

		// Token: 0x04001045 RID: 4165
		private Action kdv;

		// Token: 0x04001046 RID: 4166
		private Action kdw;

		// Token: 0x04001047 RID: 4167
		private Action kdx;

		// Token: 0x04001048 RID: 4168
		private Action kdy;

		// Token: 0x04001049 RID: 4169
		private Action kdz;

		// Token: 0x0400104A RID: 4170
		[SerializeField]
		private UnityEvent _onScreenClosed;

		// Token: 0x0400104B RID: 4171
		[SerializeField]
		private UnityEvent _onScreenOpened;

		// Token: 0x0400104C RID: 4172
		[SerializeField]
		private UnityEvent _onPopupWindowClosed;

		// Token: 0x0400104D RID: 4173
		[SerializeField]
		private UnityEvent _onPopupWindowOpened;

		// Token: 0x0400104E RID: 4174
		[SerializeField]
		private UnityEvent _onInputPollingStarted;

		// Token: 0x0400104F RID: 4175
		[SerializeField]
		private UnityEvent _onInputPollingEnded;

		// Token: 0x04001050 RID: 4176
		private static ControlMapper kea;

		// Token: 0x04001051 RID: 4177
		[NonSerialized]
		private bool keb;

		// Token: 0x04001052 RID: 4178
		[NonSerialized]
		private int kec;

		// Token: 0x04001053 RID: 4179
		private ControlMapper.jm ked;

		// Token: 0x04001054 RID: 4180
		private ControlMapper.jt kee;

		// Token: 0x04001055 RID: 4181
		[NonSerialized]
		private int kef;

		// Token: 0x04001056 RID: 4182
		[NonSerialized]
		private int keg;

		// Token: 0x04001057 RID: 4183
		[NonSerialized]
		private List<ControlMapper.jb> keh;

		// Token: 0x04001058 RID: 4184
		[NonSerialized]
		private List<ControlMapper.jb> kei;

		// Token: 0x04001059 RID: 4185
		[NonSerialized]
		private List<ControlMapper.jb> kej;

		// Token: 0x0400105A RID: 4186
		private ControlMapper.jb kek;

		// Token: 0x0400105B RID: 4187
		[NonSerialized]
		private List<GameObject> kel;

		// Token: 0x0400105C RID: 4188
		[NonSerialized]
		private GameObject kem;

		// Token: 0x0400105D RID: 4189
		[NonSerialized]
		private GameObject ken;

		// Token: 0x0400105E RID: 4190
		[NonSerialized]
		private int keo = -1;

		// Token: 0x0400105F RID: 4191
		[NonSerialized]
		private float kep;

		// Token: 0x04001060 RID: 4192
		[NonSerialized]
		private bool keq;

		// Token: 0x04001061 RID: 4193
		[NonSerialized]
		private List<ThemedElement> ker = new List<ThemedElement>();

		// Token: 0x04001062 RID: 4194
		[NonSerialized]
		private ControlMapper.ji kes;

		// Token: 0x04001063 RID: 4195
		[NonSerialized]
		private ControlMapper.jj ket;

		// Token: 0x04001064 RID: 4196
		private Action<kf> keu;

		// Token: 0x04001065 RID: 4197
		private Action<kj, bool> kev;

		// Token: 0x04001066 RID: 4198
		private Action kew;

		// Token: 0x020001F9 RID: 505
		private abstract class iz
		{
			// Token: 0x060020CE RID: 8398 RVA: 0x00093114 File Offset: 0x00091314
			public virtual string flo()
			{
				if (this.jzh == null)
				{
					return string.Empty;
				}
				return this.jzh.text;
			}

			// Token: 0x170004D2 RID: 1234
			// (get) Token: 0x060020DB RID: 8411 RVA: 0x00093477 File Offset: 0x00091677
			// (set) Token: 0x060020CF RID: 8399 RVA: 0x00093135 File Offset: 0x00091335
			public RectTransform jzm { get; private set; }

			// Token: 0x060020D0 RID: 8400 RVA: 0x0009313E File Offset: 0x0009133E
			public void flq(string a, int b)
			{
				if (this.jzj == null)
				{
					return;
				}
				this.jzj.identifier = a;
				this.jzj.intData = b;
			}

			// Token: 0x060020D1 RID: 8401 RVA: 0x00093168 File Offset: 0x00091368
			public virtual void fll(int a)
			{
				if (this.jzh == null)
				{
					return;
				}
				LayoutElement layoutElement = this.jzh.GetComponent<LayoutElement>();
				if (layoutElement == null)
				{
					layoutElement = this.jzh.gameObject.AddComponent<LayoutElement>();
				}
				layoutElement.preferredWidth = (float)a;
			}

			// Token: 0x060020D2 RID: 8402 RVA: 0x000931B4 File Offset: 0x000913B4
			public iz(GameObject a)
			{
				if (a == null)
				{
					Debug.LogError(a.esu());
					return;
				}
				this.jzi = a.GetComponent<Selectable>();
				if (this.jzi == null)
				{
					Debug.LogError(a.esv());
					return;
				}
				this.jzg = a;
				this.jzm = a.GetComponent<RectTransform>();
				this.jzh = UnityTools.GetComponentInSelfOrChildren<TMP_Text>(a);
				this.jzj = a.GetComponent<km>();
				this.jzl = new List<ControlMapper.iz>();
			}

			// Token: 0x060020D3 RID: 8403 RVA: 0x00093238 File Offset: 0x00091438
			public iz(Selectable a, TMP_Text b)
			{
				if (a == null)
				{
					Debug.LogError(a.esv());
					return;
				}
				this.jzi = a;
				this.jzg = a.gameObject;
				this.jzm = this.jzg.GetComponent<RectTransform>();
				this.jzh = b;
				this.jzj = this.jzg.GetComponent<km>();
				this.jzl = new List<ControlMapper.iz>();
			}

			// Token: 0x060020D4 RID: 8404 RVA: 0x000932A6 File Offset: 0x000914A6
			public virtual void flr(bool a)
			{
				if (this.jzg == null)
				{
					return;
				}
				this.jzg.SetActive(a);
			}

			// Token: 0x060020D5 RID: 8405 RVA: 0x000932C3 File Offset: 0x000914C3
			public virtual void flj(bool a, bool b)
			{
				this.flk(a, b, false);
			}

			// Token: 0x060020D6 RID: 8406 RVA: 0x000932CE File Offset: 0x000914CE
			public virtual void fln(string a)
			{
				if (this.jzh == null)
				{
					return;
				}
				this.jzh.text = a;
			}

			// Token: 0x060020D7 RID: 8407 RVA: 0x000932EC File Offset: 0x000914EC
			public virtual void flm(ControlMapper.LayoutElementSizeType a, int b)
			{
				if (this.jzm.childCount == 0)
				{
					return;
				}
				Transform child = this.jzm.GetChild(0);
				LayoutElement layoutElement = child.GetComponent<LayoutElement>();
				if (layoutElement == null)
				{
					layoutElement = child.gameObject.AddComponent<LayoutElement>();
				}
				if (a == ControlMapper.LayoutElementSizeType.MinSize)
				{
					layoutElement.minWidth = (float)b;
					return;
				}
				if (a == ControlMapper.LayoutElementSizeType.PreferredSize)
				{
					layoutElement.preferredWidth = (float)b;
					return;
				}
				throw new NotImplementedException();
			}

			// Token: 0x060020D8 RID: 8408 RVA: 0x0009334E File Offset: 0x0009154E
			public virtual void flp(ControlMapper.iz a)
			{
				this.jzl.Add(a);
			}

			// Token: 0x060020D9 RID: 8409 RVA: 0x0009335C File Offset: 0x0009155C
			public virtual void flk(bool a, bool b, bool c)
			{
				for (int i = 0; i < this.jzl.Count; i++)
				{
					if (this.jzl[i] != null)
					{
						this.jzl[i].flk(a, b, c);
					}
				}
				if (this.jzk)
				{
					return;
				}
				if (this.jzi == null)
				{
					return;
				}
				if (c)
				{
					this.jzk = true;
				}
				if (this.jzi.interactable == a)
				{
					return;
				}
				kq.grq(this.jzi, a, b);
			}

			// Token: 0x060020DA RID: 8410 RVA: 0x000933E0 File Offset: 0x000915E0
			protected virtual bool fls()
			{
				bool flag = true;
				for (int i = 0; i < this.jzl.Count; i++)
				{
					if (this.jzl[i] != null && !this.jzl[i].fls())
					{
						flag = false;
					}
				}
				if (this.jzi == null)
				{
					Debug.LogError(a.esw());
					flag = false;
				}
				if (this.jzm == null)
				{
					Debug.LogError(a.esx());
					flag = false;
				}
				if (this.jzj == null)
				{
					Debug.LogError(a.esy());
					flag = false;
				}
				return flag;
			}

			// Token: 0x04001067 RID: 4199
			public readonly GameObject jzg;

			// Token: 0x04001068 RID: 4200
			protected readonly TMP_Text jzh;

			// Token: 0x04001069 RID: 4201
			public readonly Selectable jzi;

			// Token: 0x0400106A RID: 4202
			protected readonly km jzj;

			// Token: 0x0400106B RID: 4203
			protected bool jzk;

			// Token: 0x0400106C RID: 4204
			protected readonly List<ControlMapper.iz> jzl;
		}

		// Token: 0x020001FA RID: 506
		private class jb : ControlMapper.iz
		{
			// Token: 0x060020DC RID: 8412 RVA: 0x00093480 File Offset: 0x00091680
			public void ntm(Action<ButtonInfo> a)
			{
				ControlMapper.jb.ja ja = new ControlMapper.jb.ja();
				ja.jzn = a;
				ja.jzo = this;
				if (this.lvt == null)
				{
					return;
				}
				this.lvt.onClick.AddListener(new UnityAction(ja.flt));
			}

			// Token: 0x060020DD RID: 8413 RVA: 0x000934CC File Offset: 0x000916CC
			public void mbc(string a, int b)
			{
				base.flq(a, b);
			}

			// Token: 0x060020DE RID: 8414 RVA: 0x000934D6 File Offset: 0x000916D6
			public jb(GameObject a)
				: base(a)
			{
				this.fls();
			}

			// Token: 0x170004D4 RID: 1236
			// (get) Token: 0x060020DF RID: 8415 RVA: 0x000934E6 File Offset: 0x000916E6
			public ButtonInfo lvu
			{
				get
				{
					return this.jzj as ButtonInfo;
				}
			}

			// Token: 0x060020E0 RID: 8416 RVA: 0x000934F4 File Offset: 0x000916F4
			public void flx(Action<ButtonInfo> a)
			{
				ControlMapper.jb.ja ja = new ControlMapper.jb.ja();
				ja.jzn = a;
				ja.jzo = this;
				if (this.lvt == null)
				{
					return;
				}
				this.lvt.onClick.AddListener(new UnityAction(ja.flt));
			}

			// Token: 0x060020E1 RID: 8417 RVA: 0x000934CC File Offset: 0x000916CC
			public void flw(string a, int b)
			{
				base.flq(a, b);
			}

			// Token: 0x060020E2 RID: 8418 RVA: 0x00093540 File Offset: 0x00091740
			public jb(Button a, TMP_Text b)
				: base(a, b)
			{
				this.fls();
			}

			// Token: 0x060020E3 RID: 8419 RVA: 0x000934CC File Offset: 0x000916CC
			public void vr(string a, int b)
			{
				base.flq(a, b);
			}

			// Token: 0x170004D3 RID: 1235
			// (get) Token: 0x060020E4 RID: 8420 RVA: 0x00093551 File Offset: 0x00091751
			protected Button lvt
			{
				get
				{
					return this.jzi as Button;
				}
			}

			// Token: 0x060020E5 RID: 8421 RVA: 0x000934CC File Offset: 0x000916CC
			public void nxo(string a, int b)
			{
				base.flq(a, b);
			}

			// Token: 0x020001FB RID: 507
			[CompilerGenerated]
			private sealed class ja
			{
				// Token: 0x060020E6 RID: 8422 RVA: 0x0009355E File Offset: 0x0009175E
				internal void kif()
				{
					this.jzn(this.jzo.lvu);
				}

				// Token: 0x060020E8 RID: 8424 RVA: 0x0009355E File Offset: 0x0009175E
				internal void ldk()
				{
					this.jzn(this.jzo.lvu);
				}

				// Token: 0x060020E9 RID: 8425 RVA: 0x0009355E File Offset: 0x0009175E
				internal void flt()
				{
					this.jzn(this.jzo.lvu);
				}

				// Token: 0x0400106E RID: 4206
				public Action<ButtonInfo> jzn;

				// Token: 0x0400106F RID: 4207
				public ControlMapper.jb jzo;
			}
		}

		// Token: 0x020001FC RID: 508
		private class jd : ControlMapper.iz
		{
			// Token: 0x170004D9 RID: 1241
			// (get) Token: 0x060020EA RID: 8426 RVA: 0x00093576 File Offset: 0x00091776
			// (set) Token: 0x060020F0 RID: 8432 RVA: 0x0009362C File Offset: 0x0009182C
			public int lvy
			{
				get
				{
					if (this.lvw == null)
					{
						return -1;
					}
					return this.lvw.mca;
				}
				set
				{
					if (this.lvw == null)
					{
						return;
					}
					this.lvw.mca = value;
				}
			}

			// Token: 0x060020EB RID: 8427 RVA: 0x00093593 File Offset: 0x00091793
			public void fml(ControlMapper.jf a)
			{
				if (a == null)
				{
					return;
				}
				this.jzr = a;
			}

			// Token: 0x170004D7 RID: 1239
			// (get) Token: 0x060020EC RID: 8428 RVA: 0x000935A0 File Offset: 0x000917A0
			public bool lvx
			{
				get
				{
					return this.jzr != null;
				}
			}

			// Token: 0x060020ED RID: 8429 RVA: 0x000935AB File Offset: 0x000917AB
			public jd(Button a, TMP_Text b)
				: base(a, b)
			{
				if (!this.fls())
				{
					return;
				}
				this.lvw.kfw = UnityTools.GetComponentInSelfOrChildren<UnityUIControllerElementGlyph>(a.gameObject);
			}

			// Token: 0x170004D8 RID: 1240
			// (get) Token: 0x060020F4 RID: 8436 RVA: 0x00093700 File Offset: 0x00091900
			// (set) Token: 0x060020EE RID: 8430 RVA: 0x000935D4 File Offset: 0x000917D4
			public ControlMapper.jf jzr { get; private set; }

			// Token: 0x060020EF RID: 8431 RVA: 0x000935E0 File Offset: 0x000917E0
			public void idy(Action<kf> a)
			{
				ControlMapper.jd.jc jc = new ControlMapper.jd.jc();
				jc.jzp = a;
				jc.jzq = this;
				if (this.lvv == null)
				{
					return;
				}
				this.lvv.onClick.AddListener(new UnityAction(jc.fly));
			}

			// Token: 0x170004DA RID: 1242
			// (get) Token: 0x060020F1 RID: 8433 RVA: 0x00093649 File Offset: 0x00091849
			// (set) Token: 0x060020FC RID: 8444 RVA: 0x00093852 File Offset: 0x00091A52
			public int lvz
			{
				get
				{
					if (this.lvw == null)
					{
						return -1;
					}
					return this.lvw.kfz;
				}
				set
				{
					if (this.lvw == null)
					{
						return;
					}
					this.lvw.kfz = value;
				}
			}

			// Token: 0x060020F2 RID: 8434 RVA: 0x00093668 File Offset: 0x00091868
			public void msv(Action<kf> a)
			{
				ControlMapper.jd.jc jc = new ControlMapper.jd.jc();
				jc.jzp = a;
				jc.jzq = this;
				if (this.lvv == null)
				{
					return;
				}
				this.lvv.onClick.AddListener(new UnityAction(jc.fly));
			}

			// Token: 0x060020F3 RID: 8435 RVA: 0x000936B4 File Offset: 0x000918B4
			public void ceb(Action<kf> a)
			{
				ControlMapper.jd.jc jc = new ControlMapper.jd.jc();
				jc.jzp = a;
				jc.jzq = this;
				if (this.lvv == null)
				{
					return;
				}
				this.lvv.onClick.AddListener(new UnityAction(jc.fly));
			}

			// Token: 0x060020F5 RID: 8437 RVA: 0x00093593 File Offset: 0x00091793
			public void fop(ControlMapper.jf a)
			{
				if (a == null)
				{
					return;
				}
				this.jzr = a;
			}

			// Token: 0x060020F6 RID: 8438 RVA: 0x00093708 File Offset: 0x00091908
			public jd(GameObject a)
				: base(a)
			{
				if (!this.fls())
				{
					return;
				}
				this.lvw.kfw = UnityTools.GetComponentInSelfOrChildren<UnityUIControllerElementGlyph>(a);
			}

			// Token: 0x060020F7 RID: 8439 RVA: 0x0009372C File Offset: 0x0009192C
			public void fmi(int a, AxisRange b, ControllerType c, int d)
			{
				base.flq(string.Empty, d);
				if (this.lvw == null)
				{
					return;
				}
				this.lvw.kfx = a;
				this.lvw.mbz = b;
				this.lvw.kfy = c;
			}

			// Token: 0x170004D6 RID: 1238
			// (get) Token: 0x060020F8 RID: 8440 RVA: 0x00093779 File Offset: 0x00091979
			public kf lvw
			{
				get
				{
					return this.jzj as kf;
				}
			}

			// Token: 0x060020F9 RID: 8441 RVA: 0x00093788 File Offset: 0x00091988
			public void ksa(int a, AxisRange b, ControllerType c, int d)
			{
				base.flq(string.Empty, d);
				if (this.lvw == null)
				{
					return;
				}
				this.lvw.kfx = a;
				this.lvw.mbz = b;
				this.lvw.kfy = c;
			}

			// Token: 0x060020FA RID: 8442 RVA: 0x000937D8 File Offset: 0x000919D8
			public void dbk(int a, AxisRange b, ControllerType c, int d)
			{
				base.flq(string.Empty, d);
				if (this.lvw == null)
				{
					return;
				}
				this.lvw.kfx = a;
				this.lvw.mbz = b;
				this.lvw.kfy = c;
			}

			// Token: 0x060020FB RID: 8443 RVA: 0x00093825 File Offset: 0x00091A25
			public virtual void fmk(bool a, bool b, bool c)
			{
				if (this.jzk)
				{
					return;
				}
				if (this.lvx && !a)
				{
					this.jzr.flk(a, b, c);
				}
				base.flk(a, b, c);
			}

			// Token: 0x060020FD RID: 8445 RVA: 0x00093870 File Offset: 0x00091A70
			public void gdt(Action<kf> a)
			{
				ControlMapper.jd.jc jc = new ControlMapper.jd.jc();
				jc.jzp = a;
				jc.jzq = this;
				if (this.lvv == null)
				{
					return;
				}
				this.lvv.onClick.AddListener(new UnityAction(jc.fly));
			}

			// Token: 0x060020FE RID: 8446 RVA: 0x000938BC File Offset: 0x00091ABC
			public void fmj(Action<kf> a)
			{
				ControlMapper.jd.jc jc = new ControlMapper.jd.jc();
				jc.jzp = a;
				jc.jzq = this;
				if (this.lvv == null)
				{
					return;
				}
				this.lvv.onClick.AddListener(new UnityAction(jc.fly));
			}

			// Token: 0x060020FF RID: 8447 RVA: 0x00093908 File Offset: 0x00091B08
			public void drx(int a, AxisRange b, ControllerType c, int d)
			{
				base.flq(string.Empty, d);
				if (this.lvw == null)
				{
					return;
				}
				this.lvw.kfx = a;
				this.lvw.mbz = b;
				this.lvw.kfy = c;
			}

			// Token: 0x06002100 RID: 8448 RVA: 0x00093593 File Offset: 0x00091793
			public void bzf(ControlMapper.jf a)
			{
				if (a == null)
				{
					return;
				}
				this.jzr = a;
			}

			// Token: 0x06002101 RID: 8449 RVA: 0x00093593 File Offset: 0x00091793
			public void man(ControlMapper.jf a)
			{
				if (a == null)
				{
					return;
				}
				this.jzr = a;
			}

			// Token: 0x06002102 RID: 8450 RVA: 0x00093593 File Offset: 0x00091793
			public void lha(ControlMapper.jf a)
			{
				if (a == null)
				{
					return;
				}
				this.jzr = a;
			}

			// Token: 0x170004D5 RID: 1237
			// (get) Token: 0x06002103 RID: 8451 RVA: 0x00093551 File Offset: 0x00091751
			protected Button lvv
			{
				get
				{
					return this.jzi as Button;
				}
			}

			// Token: 0x020001FD RID: 509
			[CompilerGenerated]
			private sealed class jc
			{
				// Token: 0x06002104 RID: 8452 RVA: 0x00093955 File Offset: 0x00091B55
				internal void nbc()
				{
					this.jzp(this.jzq.lvw);
				}

				// Token: 0x06002105 RID: 8453 RVA: 0x00093955 File Offset: 0x00091B55
				internal void fly()
				{
					this.jzp(this.jzq.lvw);
				}

				// Token: 0x06002107 RID: 8455 RVA: 0x00093955 File Offset: 0x00091B55
				internal void czo()
				{
					this.jzp(this.jzq.lvw);
				}

				// Token: 0x04001071 RID: 4209
				public Action<kf> jzp;

				// Token: 0x04001072 RID: 4210
				public ControlMapper.jd jzq;
			}
		}

		// Token: 0x020001FE RID: 510
		private class jf : ControlMapper.iz
		{
			// Token: 0x06002108 RID: 8456 RVA: 0x0009396D File Offset: 0x00091B6D
			public void gqu(bool a)
			{
				if (this.lwa == null)
				{
					return;
				}
				this.lwa.isOn = a;
			}

			// Token: 0x170004DD RID: 1245
			// (get) Token: 0x0600210F RID: 8463 RVA: 0x00093B25 File Offset: 0x00091D25
			// (set) Token: 0x06002109 RID: 8457 RVA: 0x0009398A File Offset: 0x00091B8A
			public int lwc
			{
				get
				{
					if (this.lwb == null)
					{
						return -1;
					}
					return this.lwb.mca;
				}
				set
				{
					if (this.lwb == null)
					{
						return;
					}
					this.lwb.mca = value;
				}
			}

			// Token: 0x0600210A RID: 8458 RVA: 0x000939A8 File Offset: 0x00091BA8
			public void ikc(Action<kj, bool> a)
			{
				ControlMapper.jf.je je = new ControlMapper.jf.je();
				je.jzs = a;
				je.jzt = this;
				if (this.lwa == null)
				{
					return;
				}
				EventTrigger eventTrigger = this.lwa.GetComponent<EventTrigger>();
				if (eventTrigger == null)
				{
					eventTrigger = this.lwa.gameObject.AddComponent<EventTrigger>();
				}
				EventTrigger.TriggerEvent triggerEvent = new EventTrigger.TriggerEvent();
				triggerEvent.AddListener(new UnityAction<BaseEventData>(je.fmm));
				EventTrigger.Entry entry = new EventTrigger.Entry
				{
					callback = triggerEvent,
					eventID = (EventTriggerType)27
				};
				EventTrigger.Entry entry2 = new EventTrigger.Entry
				{
					callback = triggerEvent,
					eventID = EventTriggerType.PointerClick
				};
				if (eventTrigger.triggers != null)
				{
					eventTrigger.triggers.Clear();
				}
				else
				{
					eventTrigger.triggers = new List<EventTrigger.Entry>();
				}
				eventTrigger.triggers.Add(entry);
				eventTrigger.triggers.Add(entry2);
			}

			// Token: 0x170004DC RID: 1244
			// (get) Token: 0x0600210B RID: 8459 RVA: 0x00093A79 File Offset: 0x00091C79
			public kj lwb
			{
				get
				{
					return this.jzj as kj;
				}
			}

			// Token: 0x0600210C RID: 8460 RVA: 0x00093A88 File Offset: 0x00091C88
			public void hlf(int a, AxisRange b, ControllerType c, int d)
			{
				base.flq(string.Empty, d);
				if (this.lwb == null)
				{
					return;
				}
				this.lwb.kfx = a;
				this.lwb.mbz = b;
				this.lwb.kfy = c;
			}

			// Token: 0x0600210D RID: 8461 RVA: 0x00093540 File Offset: 0x00091740
			public jf(Toggle a, TMP_Text b)
				: base(a, b)
			{
				this.fls();
			}

			// Token: 0x0600210E RID: 8462 RVA: 0x00093AD8 File Offset: 0x00091CD8
			public void fmr(int a, AxisRange b, ControllerType c, int d)
			{
				base.flq(string.Empty, d);
				if (this.lwb == null)
				{
					return;
				}
				this.lwb.kfx = a;
				this.lwb.mbz = b;
				this.lwb.kfy = c;
			}

			// Token: 0x06002110 RID: 8464 RVA: 0x00093B44 File Offset: 0x00091D44
			public void fms(Action<kj, bool> a)
			{
				ControlMapper.jf.je je = new ControlMapper.jf.je();
				je.jzs = a;
				je.jzt = this;
				if (this.lwa == null)
				{
					return;
				}
				EventTrigger eventTrigger = this.lwa.GetComponent<EventTrigger>();
				if (eventTrigger == null)
				{
					eventTrigger = this.lwa.gameObject.AddComponent<EventTrigger>();
				}
				EventTrigger.TriggerEvent triggerEvent = new EventTrigger.TriggerEvent();
				triggerEvent.AddListener(new UnityAction<BaseEventData>(je.fmm));
				EventTrigger.Entry entry = new EventTrigger.Entry
				{
					callback = triggerEvent,
					eventID = EventTriggerType.Submit
				};
				EventTrigger.Entry entry2 = new EventTrigger.Entry
				{
					callback = triggerEvent,
					eventID = EventTriggerType.PointerClick
				};
				if (eventTrigger.triggers != null)
				{
					eventTrigger.triggers.Clear();
				}
				else
				{
					eventTrigger.triggers = new List<EventTrigger.Entry>();
				}
				eventTrigger.triggers.Add(entry);
				eventTrigger.triggers.Add(entry2);
			}

			// Token: 0x06002111 RID: 8465 RVA: 0x0009396D File Offset: 0x00091B6D
			public void fmt(bool a)
			{
				if (this.lwa == null)
				{
					return;
				}
				this.lwa.isOn = a;
			}

			// Token: 0x06002112 RID: 8466 RVA: 0x000934D6 File Offset: 0x000916D6
			public jf(GameObject a)
				: base(a)
			{
				this.fls();
			}

			// Token: 0x06002113 RID: 8467 RVA: 0x0009396D File Offset: 0x00091B6D
			public void na(bool a)
			{
				if (this.lwa == null)
				{
					return;
				}
				this.lwa.isOn = a;
			}

			// Token: 0x170004DB RID: 1243
			// (get) Token: 0x06002114 RID: 8468 RVA: 0x00093C15 File Offset: 0x00091E15
			protected Toggle lwa
			{
				get
				{
					return this.jzi as Toggle;
				}
			}

			// Token: 0x06002115 RID: 8469 RVA: 0x0009396D File Offset: 0x00091B6D
			public void kez(bool a)
			{
				if (this.lwa == null)
				{
					return;
				}
				this.lwa.isOn = a;
			}

			// Token: 0x06002116 RID: 8470 RVA: 0x0009396D File Offset: 0x00091B6D
			public void cao(bool a)
			{
				if (this.lwa == null)
				{
					return;
				}
				this.lwa.isOn = a;
			}

			// Token: 0x020001FF RID: 511
			[CompilerGenerated]
			private sealed class je
			{
				// Token: 0x06002117 RID: 8471 RVA: 0x00093C24 File Offset: 0x00091E24
				internal void flu(BaseEventData a)
				{
					PointerEventData pointerEventData = a as PointerEventData;
					if (pointerEventData != null && pointerEventData.button != PointerEventData.InputButton.Left)
					{
						return;
					}
					this.jzs(this.jzt.lwb, this.jzt.lwa.isOn);
				}

				// Token: 0x06002119 RID: 8473 RVA: 0x00093C6C File Offset: 0x00091E6C
				internal void fmm(BaseEventData a)
				{
					PointerEventData pointerEventData = a as PointerEventData;
					if (pointerEventData != null && pointerEventData.button != PointerEventData.InputButton.Left)
					{
						return;
					}
					this.jzs(this.jzt.lwb, this.jzt.lwa.isOn);
				}

				// Token: 0x0600211A RID: 8474 RVA: 0x00093CB4 File Offset: 0x00091EB4
				internal void mfa(BaseEventData a)
				{
					PointerEventData pointerEventData = a as PointerEventData;
					if (pointerEventData != null && pointerEventData.button != PointerEventData.InputButton.Left)
					{
						return;
					}
					this.jzs(this.jzt.lwb, this.jzt.lwa.isOn);
				}

				// Token: 0x0600211B RID: 8475 RVA: 0x00093CFC File Offset: 0x00091EFC
				internal void kzb(BaseEventData a)
				{
					PointerEventData pointerEventData = a as PointerEventData;
					if (pointerEventData != null && pointerEventData.button != PointerEventData.InputButton.Left)
					{
						return;
					}
					this.jzs(this.jzt.lwb, this.jzt.lwa.isOn);
				}

				// Token: 0x04001073 RID: 4211
				public Action<kj, bool> jzs;

				// Token: 0x04001074 RID: 4212
				public ControlMapper.jf jzt;
			}
		}

		// Token: 0x02000200 RID: 512
		private class jg
		{
			// Token: 0x0600211C RID: 8476 RVA: 0x00093D42 File Offset: 0x00091F42
			public void ies(TextAlignmentOptions a)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzv.alignment = a;
			}

			// Token: 0x0600211D RID: 8477 RVA: 0x00093D5F File Offset: 0x00091F5F
			public void l(bool a)
			{
				if (this.jzu == null)
				{
					return;
				}
				this.jzu.SetActive(a);
			}

			// Token: 0x0600211E RID: 8478 RVA: 0x00093D7C File Offset: 0x00091F7C
			public jg(GameObject a)
			{
				if (a == null)
				{
					Debug.LogError(a.esu());
					return;
				}
				this.jzv = UnityTools.GetComponentInSelfOrChildren<TMP_Text>(a);
				this.fnh();
			}

			// Token: 0x170004DF RID: 1247
			// (get) Token: 0x06002137 RID: 8503 RVA: 0x00093EB8 File Offset: 0x000920B8
			// (set) Token: 0x0600211F RID: 8479 RVA: 0x00093DAB File Offset: 0x00091FAB
			private TMP_Text jzv { get; set; }

			// Token: 0x170004E0 RID: 1248
			// (get) Token: 0x0600213E RID: 8510 RVA: 0x00093F2C File Offset: 0x0009212C
			// (set) Token: 0x06002120 RID: 8480 RVA: 0x00093DB4 File Offset: 0x00091FB4
			public RectTransform jzw { get; private set; }

			// Token: 0x06002121 RID: 8481 RVA: 0x00093DBD File Offset: 0x00091FBD
			public void ksr(int a)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, (float)a);
			}

			// Token: 0x06002122 RID: 8482 RVA: 0x00093DDC File Offset: 0x00091FDC
			public void hur(int a)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)a);
			}

			// Token: 0x06002123 RID: 8483 RVA: 0x00093D5F File Offset: 0x00091F5F
			public void fng(bool a)
			{
				if (this.jzu == null)
				{
					return;
				}
				this.jzu.SetActive(a);
			}

			// Token: 0x06002124 RID: 8484 RVA: 0x00093DFB File Offset: 0x00091FFB
			public void fne(FontStyles a)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzv.fontStyle = a;
			}

			// Token: 0x06002125 RID: 8485 RVA: 0x00093DBD File Offset: 0x00091FBD
			public void fnb(int a)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, (float)a);
			}

			// Token: 0x06002126 RID: 8486 RVA: 0x00093DDC File Offset: 0x00091FDC
			public void dip(int a)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)a);
			}

			// Token: 0x06002127 RID: 8487 RVA: 0x00093E18 File Offset: 0x00092018
			public void fnd(string a)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzv.text = a;
			}

			// Token: 0x06002128 RID: 8488 RVA: 0x00093E35 File Offset: 0x00092035
			public void ktf(int a, int b)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, (float)a);
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)b);
			}

			// Token: 0x170004DE RID: 1246
			// (get) Token: 0x06002129 RID: 8489 RVA: 0x00093E62 File Offset: 0x00092062
			// (set) Token: 0x0600213B RID: 8507 RVA: 0x00093ED6 File Offset: 0x000920D6
			public GameObject jzu { get; private set; }

			// Token: 0x0600212A RID: 8490 RVA: 0x00093E6C File Offset: 0x0009206C
			private bool fnh()
			{
				bool flag = true;
				if (this.jzv == null)
				{
					Debug.LogError(a.esz());
					flag = false;
				}
				this.jzu = this.jzv.gameObject;
				this.jzw = this.jzv.GetComponent<RectTransform>();
				return flag;
			}

			// Token: 0x0600212B RID: 8491 RVA: 0x00093D5F File Offset: 0x00091F5F
			public void nrk(bool a)
			{
				if (this.jzu == null)
				{
					return;
				}
				this.jzu.SetActive(a);
			}

			// Token: 0x0600212C RID: 8492 RVA: 0x00093E35 File Offset: 0x00092035
			public void epn(int a, int b)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, (float)a);
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)b);
			}

			// Token: 0x0600212D RID: 8493 RVA: 0x00093E35 File Offset: 0x00092035
			public void bzq(int a, int b)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, (float)a);
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)b);
			}

			// Token: 0x0600212E RID: 8494 RVA: 0x00093E35 File Offset: 0x00092035
			public void oie(int a, int b)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, (float)a);
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)b);
			}

			// Token: 0x0600212F RID: 8495 RVA: 0x00093D42 File Offset: 0x00091F42
			public void gzi(TextAlignmentOptions a)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzv.alignment = a;
			}

			// Token: 0x06002130 RID: 8496 RVA: 0x00093D42 File Offset: 0x00091F42
			public void grn(TextAlignmentOptions a)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzv.alignment = a;
			}

			// Token: 0x06002131 RID: 8497 RVA: 0x00093DBD File Offset: 0x00091FBD
			public void efn(int a)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, (float)a);
			}

			// Token: 0x06002132 RID: 8498 RVA: 0x00093DBD File Offset: 0x00091FBD
			public void hnb(int a)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, (float)a);
			}

			// Token: 0x06002133 RID: 8499 RVA: 0x00093D42 File Offset: 0x00091F42
			public void eyo(TextAlignmentOptions a)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzv.alignment = a;
			}

			// Token: 0x06002134 RID: 8500 RVA: 0x00093DDC File Offset: 0x00091FDC
			public void wp(int a)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)a);
			}

			// Token: 0x06002135 RID: 8501 RVA: 0x00093D42 File Offset: 0x00091F42
			public void fnf(TextAlignmentOptions a)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzv.alignment = a;
			}

			// Token: 0x06002136 RID: 8502 RVA: 0x00093DDC File Offset: 0x00091FDC
			public void fnc(int a)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)a);
			}

			// Token: 0x06002138 RID: 8504 RVA: 0x00093D5F File Offset: 0x00091F5F
			public void hee(bool a)
			{
				if (this.jzu == null)
				{
					return;
				}
				this.jzu.SetActive(a);
			}

			// Token: 0x06002139 RID: 8505 RVA: 0x00093EC0 File Offset: 0x000920C0
			public jg(TMP_Text a)
			{
				this.jzv = a;
				this.fnh();
			}

			// Token: 0x0600213A RID: 8506 RVA: 0x00093E35 File Offset: 0x00092035
			public void fna(int a, int b)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, (float)a);
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)b);
			}

			// Token: 0x0600213C RID: 8508 RVA: 0x00093DDC File Offset: 0x00091FDC
			public void glm(int a)
			{
				if (this.jzv == null)
				{
					return;
				}
				this.jzw.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)a);
			}

			// Token: 0x0600213D RID: 8509 RVA: 0x00093EE0 File Offset: 0x000920E0
			private bool bgl()
			{
				bool flag = true;
				if (this.jzv == null)
				{
					Debug.LogError(a.eta());
					flag = false;
				}
				this.jzu = this.jzv.gameObject;
				this.jzw = this.jzv.GetComponent<RectTransform>();
				return flag;
			}
		}

		// Token: 0x02000201 RID: 513
		[Serializable]
		public class MappingSet
		{
			// Token: 0x170004E1 RID: 1249
			// (get) Token: 0x0600213F RID: 8511 RVA: 0x00093F34 File Offset: 0x00092134
			public int lwd
			{
				get
				{
					return this._mapCategoryId;
				}
			}

			// Token: 0x170004E2 RID: 1250
			// (get) Token: 0x06002140 RID: 8512 RVA: 0x00093F3C File Offset: 0x0009213C
			public ControlMapper.MappingSet.ActionListMode lwe
			{
				get
				{
					return this._actionListMode;
				}
			}

			// Token: 0x170004E3 RID: 1251
			// (get) Token: 0x06002141 RID: 8513 RVA: 0x00093F44 File Offset: 0x00092144
			public IList<int> lwf
			{
				get
				{
					if (this._actionCategoryIds == null)
					{
						return null;
					}
					if (this.jzx == null)
					{
						this.jzx = new ReadOnlyCollection<int>(this._actionCategoryIds);
					}
					return this.jzx;
				}
			}

			// Token: 0x170004E4 RID: 1252
			// (get) Token: 0x06002142 RID: 8514 RVA: 0x00093F6F File Offset: 0x0009216F
			public IList<int> lwg
			{
				get
				{
					if (this._actionIds == null)
					{
						return null;
					}
					if (this.jzy == null)
					{
						this.jzy = new ReadOnlyCollection<int>(this._actionIds);
					}
					return this._actionIds;
				}
			}

			// Token: 0x170004E5 RID: 1253
			// (get) Token: 0x06002143 RID: 8515 RVA: 0x00093F9C File Offset: 0x0009219C
			public bool lwh
			{
				get
				{
					if (this._mapCategoryId < 0)
					{
						return false;
					}
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(this._mapCategoryId);
					return mapCategory != null && mapCategory.userAssignable;
				}
			}

			// Token: 0x06002144 RID: 8516 RVA: 0x00093FD5 File Offset: 0x000921D5
			public MappingSet()
			{
				this._mapCategoryId = -1;
				this._actionCategoryIds = new int[0];
				this._actionIds = new int[0];
				this._actionListMode = ControlMapper.MappingSet.ActionListMode.ActionCategory;
			}

			// Token: 0x06002145 RID: 8517 RVA: 0x00094003 File Offset: 0x00092203
			private MappingSet(int mapCategoryId, ControlMapper.MappingSet.ActionListMode actionListMode, int[] actionCategoryIds, int[] actionIds)
			{
				this._mapCategoryId = mapCategoryId;
				this._actionListMode = actionListMode;
				this._actionCategoryIds = actionCategoryIds;
				this._actionIds = actionIds;
			}

			// Token: 0x170004E6 RID: 1254
			// (get) Token: 0x06002146 RID: 8518 RVA: 0x00094028 File Offset: 0x00092228
			public static ControlMapper.MappingSet lwi
			{
				get
				{
					return new ControlMapper.MappingSet(0, ControlMapper.MappingSet.ActionListMode.ActionCategory, new int[1], new int[0]);
				}
			}

			// Token: 0x04001078 RID: 4216
			[SerializeField]
			private int _mapCategoryId;

			// Token: 0x04001079 RID: 4217
			[SerializeField]
			private ControlMapper.MappingSet.ActionListMode _actionListMode;

			// Token: 0x0400107A RID: 4218
			[SerializeField]
			private int[] _actionCategoryIds;

			// Token: 0x0400107B RID: 4219
			[SerializeField]
			private int[] _actionIds;

			// Token: 0x0400107C RID: 4220
			private IList<int> jzx;

			// Token: 0x0400107D RID: 4221
			private IList<int> jzy;

			// Token: 0x02000202 RID: 514
			public enum ActionListMode
			{
				// Token: 0x0400107F RID: 4223
				ActionCategory,
				// Token: 0x04001080 RID: 4224
				Action
			}
		}

		// Token: 0x02000203 RID: 515
		[Serializable]
		public class InputBehaviorSettings
		{
			// Token: 0x170004E7 RID: 1255
			// (get) Token: 0x06002147 RID: 8519 RVA: 0x0009403D File Offset: 0x0009223D
			public int lwj
			{
				get
				{
					return this._inputBehaviorId;
				}
			}

			// Token: 0x170004E8 RID: 1256
			// (get) Token: 0x06002148 RID: 8520 RVA: 0x00094045 File Offset: 0x00092245
			public bool lwk
			{
				get
				{
					return this._showJoystickAxisSensitivity;
				}
			}

			// Token: 0x170004E9 RID: 1257
			// (get) Token: 0x06002149 RID: 8521 RVA: 0x0009404D File Offset: 0x0009224D
			public bool lwl
			{
				get
				{
					return this._showMouseXYAxisSensitivity;
				}
			}

			// Token: 0x170004EA RID: 1258
			// (get) Token: 0x0600214A RID: 8522 RVA: 0x00094055 File Offset: 0x00092255
			public string lwm
			{
				get
				{
					return this._labelLanguageKey;
				}
			}

			// Token: 0x170004EB RID: 1259
			// (get) Token: 0x0600214B RID: 8523 RVA: 0x0009405D File Offset: 0x0009225D
			public string lwn
			{
				get
				{
					return this._joystickAxisSensitivityLabelLanguageKey;
				}
			}

			// Token: 0x170004EC RID: 1260
			// (get) Token: 0x0600214C RID: 8524 RVA: 0x00094065 File Offset: 0x00092265
			public string lwo
			{
				get
				{
					return this._mouseXYAxisSensitivityLabelLanguageKey;
				}
			}

			// Token: 0x170004ED RID: 1261
			// (get) Token: 0x0600214D RID: 8525 RVA: 0x0009406D File Offset: 0x0009226D
			public Sprite lwp
			{
				get
				{
					return this._joystickAxisSensitivityIcon;
				}
			}

			// Token: 0x170004EE RID: 1262
			// (get) Token: 0x0600214E RID: 8526 RVA: 0x00094075 File Offset: 0x00092275
			public Sprite lwq
			{
				get
				{
					return this._mouseXYAxisSensitivityIcon;
				}
			}

			// Token: 0x170004EF RID: 1263
			// (get) Token: 0x0600214F RID: 8527 RVA: 0x0009407D File Offset: 0x0009227D
			public float lwr
			{
				get
				{
					return this._joystickAxisSensitivityMin;
				}
			}

			// Token: 0x170004F0 RID: 1264
			// (get) Token: 0x06002150 RID: 8528 RVA: 0x00094085 File Offset: 0x00092285
			public float lws
			{
				get
				{
					return this._joystickAxisSensitivityMax;
				}
			}

			// Token: 0x170004F1 RID: 1265
			// (get) Token: 0x06002151 RID: 8529 RVA: 0x0009408D File Offset: 0x0009228D
			public float lwt
			{
				get
				{
					return this._mouseXYAxisSensitivityMin;
				}
			}

			// Token: 0x170004F2 RID: 1266
			// (get) Token: 0x06002152 RID: 8530 RVA: 0x00094095 File Offset: 0x00092295
			public float lwu
			{
				get
				{
					return this._mouseXYAxisSensitivityMax;
				}
			}

			// Token: 0x170004F3 RID: 1267
			// (get) Token: 0x06002153 RID: 8531 RVA: 0x0009409D File Offset: 0x0009229D
			public bool lwv
			{
				get
				{
					return this._inputBehaviorId >= 0 && (this._showJoystickAxisSensitivity || this._showMouseXYAxisSensitivity);
				}
			}

			// Token: 0x04001081 RID: 4225
			[SerializeField]
			private int _inputBehaviorId = -1;

			// Token: 0x04001082 RID: 4226
			[SerializeField]
			private bool _showJoystickAxisSensitivity = true;

			// Token: 0x04001083 RID: 4227
			[SerializeField]
			private bool _showMouseXYAxisSensitivity = true;

			// Token: 0x04001084 RID: 4228
			[SerializeField]
			private string _labelLanguageKey = string.Empty;

			// Token: 0x04001085 RID: 4229
			[SerializeField]
			private string _joystickAxisSensitivityLabelLanguageKey = string.Empty;

			// Token: 0x04001086 RID: 4230
			[SerializeField]
			private string _mouseXYAxisSensitivityLabelLanguageKey = string.Empty;

			// Token: 0x04001087 RID: 4231
			[SerializeField]
			private Sprite _joystickAxisSensitivityIcon;

			// Token: 0x04001088 RID: 4232
			[SerializeField]
			private Sprite _mouseXYAxisSensitivityIcon;

			// Token: 0x04001089 RID: 4233
			[SerializeField]
			private float _joystickAxisSensitivityMin;

			// Token: 0x0400108A RID: 4234
			[SerializeField]
			private float _joystickAxisSensitivityMax = 2f;

			// Token: 0x0400108B RID: 4235
			[SerializeField]
			private float _mouseXYAxisSensitivityMin;

			// Token: 0x0400108C RID: 4236
			[SerializeField]
			private float _mouseXYAxisSensitivityMax = 2f;
		}

		// Token: 0x02000204 RID: 516
		[Serializable]
		private class Prefabs
		{
			// Token: 0x170004F4 RID: 1268
			// (get) Token: 0x06002155 RID: 8533 RVA: 0x0009411B File Offset: 0x0009231B
			public GameObject lww
			{
				get
				{
					return this._button;
				}
			}

			// Token: 0x170004F5 RID: 1269
			// (get) Token: 0x06002156 RID: 8534 RVA: 0x00094123 File Offset: 0x00092323
			public GameObject lwx
			{
				get
				{
					return this._fitButton;
				}
			}

			// Token: 0x170004F6 RID: 1270
			// (get) Token: 0x06002157 RID: 8535 RVA: 0x0009412B File Offset: 0x0009232B
			public GameObject lwy
			{
				get
				{
					return this._inputGridLabel;
				}
			}

			// Token: 0x170004F7 RID: 1271
			// (get) Token: 0x06002158 RID: 8536 RVA: 0x00094133 File Offset: 0x00092333
			public GameObject lwz
			{
				get
				{
					return this._inputGridHeaderLabel;
				}
			}

			// Token: 0x170004F8 RID: 1272
			// (get) Token: 0x06002159 RID: 8537 RVA: 0x0009413B File Offset: 0x0009233B
			public GameObject lxa
			{
				get
				{
					return this._inputGridFieldButton;
				}
			}

			// Token: 0x170004F9 RID: 1273
			// (get) Token: 0x0600215A RID: 8538 RVA: 0x00094143 File Offset: 0x00092343
			public GameObject lxb
			{
				get
				{
					return this._inputGridFieldInvertToggle;
				}
			}

			// Token: 0x170004FA RID: 1274
			// (get) Token: 0x0600215B RID: 8539 RVA: 0x0009414B File Offset: 0x0009234B
			public GameObject lxc
			{
				get
				{
					return this._window;
				}
			}

			// Token: 0x170004FB RID: 1275
			// (get) Token: 0x0600215C RID: 8540 RVA: 0x00094153 File Offset: 0x00092353
			public GameObject lxd
			{
				get
				{
					return this._windowTitleText;
				}
			}

			// Token: 0x170004FC RID: 1276
			// (get) Token: 0x0600215D RID: 8541 RVA: 0x0009415B File Offset: 0x0009235B
			public GameObject lxe
			{
				get
				{
					return this._windowContentText;
				}
			}

			// Token: 0x170004FD RID: 1277
			// (get) Token: 0x0600215E RID: 8542 RVA: 0x00094163 File Offset: 0x00092363
			public GameObject lxf
			{
				get
				{
					return this._fader;
				}
			}

			// Token: 0x170004FE RID: 1278
			// (get) Token: 0x0600215F RID: 8543 RVA: 0x0009416B File Offset: 0x0009236B
			public GameObject lxg
			{
				get
				{
					return this._calibrationWindow;
				}
			}

			// Token: 0x170004FF RID: 1279
			// (get) Token: 0x06002160 RID: 8544 RVA: 0x00094173 File Offset: 0x00092373
			public GameObject lxh
			{
				get
				{
					return this._inputBehaviorsWindow;
				}
			}

			// Token: 0x17000500 RID: 1280
			// (get) Token: 0x06002161 RID: 8545 RVA: 0x0009417B File Offset: 0x0009237B
			public GameObject lxi
			{
				get
				{
					return this._centerStickGraphic;
				}
			}

			// Token: 0x17000501 RID: 1281
			// (get) Token: 0x06002162 RID: 8546 RVA: 0x00094183 File Offset: 0x00092383
			public GameObject lxj
			{
				get
				{
					return this._moveStickGraphic;
				}
			}

			// Token: 0x06002163 RID: 8547 RVA: 0x0009418C File Offset: 0x0009238C
			public bool fop()
			{
				return !(this._button == null) && !(this._fitButton == null) && !(this._inputGridLabel == null) && !(this._inputGridHeaderLabel == null) && !(this._inputGridFieldButton == null) && !(this._inputGridFieldInvertToggle == null) && !(this._window == null) && !(this._windowTitleText == null) && !(this._windowContentText == null) && !(this._fader == null) && !(this._calibrationWindow == null) && !(this._inputBehaviorsWindow == null);
			}

			// Token: 0x0400108D RID: 4237
			[SerializeField]
			private GameObject _button;

			// Token: 0x0400108E RID: 4238
			[SerializeField]
			private GameObject _fitButton;

			// Token: 0x0400108F RID: 4239
			[SerializeField]
			private GameObject _inputGridLabel;

			// Token: 0x04001090 RID: 4240
			[SerializeField]
			private GameObject _inputGridHeaderLabel;

			// Token: 0x04001091 RID: 4241
			[SerializeField]
			private GameObject _inputGridFieldButton;

			// Token: 0x04001092 RID: 4242
			[SerializeField]
			private GameObject _inputGridFieldInvertToggle;

			// Token: 0x04001093 RID: 4243
			[SerializeField]
			private GameObject _window;

			// Token: 0x04001094 RID: 4244
			[SerializeField]
			private GameObject _windowTitleText;

			// Token: 0x04001095 RID: 4245
			[SerializeField]
			private GameObject _windowContentText;

			// Token: 0x04001096 RID: 4246
			[SerializeField]
			private GameObject _fader;

			// Token: 0x04001097 RID: 4247
			[SerializeField]
			private GameObject _calibrationWindow;

			// Token: 0x04001098 RID: 4248
			[SerializeField]
			private GameObject _inputBehaviorsWindow;

			// Token: 0x04001099 RID: 4249
			[SerializeField]
			private GameObject _centerStickGraphic;

			// Token: 0x0400109A RID: 4250
			[SerializeField]
			private GameObject _moveStickGraphic;
		}

		// Token: 0x02000205 RID: 517
		[Serializable]
		private class References
		{
			// Token: 0x17000502 RID: 1282
			// (get) Token: 0x06002165 RID: 8549 RVA: 0x00094250 File Offset: 0x00092450
			public Canvas lxk
			{
				get
				{
					return this._canvas;
				}
			}

			// Token: 0x17000503 RID: 1283
			// (get) Token: 0x06002166 RID: 8550 RVA: 0x00094258 File Offset: 0x00092458
			public CanvasGroup lxl
			{
				get
				{
					return this._mainCanvasGroup;
				}
			}

			// Token: 0x17000504 RID: 1284
			// (get) Token: 0x06002167 RID: 8551 RVA: 0x00094260 File Offset: 0x00092460
			public Transform lxm
			{
				get
				{
					return this._mainContent;
				}
			}

			// Token: 0x17000505 RID: 1285
			// (get) Token: 0x06002168 RID: 8552 RVA: 0x00094268 File Offset: 0x00092468
			public Transform lxn
			{
				get
				{
					return this._mainContentInner;
				}
			}

			// Token: 0x17000506 RID: 1286
			// (get) Token: 0x06002169 RID: 8553 RVA: 0x00094270 File Offset: 0x00092470
			public UIGroup lxo
			{
				get
				{
					return this._playersGroup;
				}
			}

			// Token: 0x17000507 RID: 1287
			// (get) Token: 0x0600216A RID: 8554 RVA: 0x00094278 File Offset: 0x00092478
			public Transform lxp
			{
				get
				{
					return this._controllerGroup;
				}
			}

			// Token: 0x17000508 RID: 1288
			// (get) Token: 0x0600216B RID: 8555 RVA: 0x00094280 File Offset: 0x00092480
			public Transform lxq
			{
				get
				{
					return this._controllerGroupLabelGroup;
				}
			}

			// Token: 0x17000509 RID: 1289
			// (get) Token: 0x0600216C RID: 8556 RVA: 0x00094288 File Offset: 0x00092488
			public UIGroup lxr
			{
				get
				{
					return this._controllerSettingsGroup;
				}
			}

			// Token: 0x1700050A RID: 1290
			// (get) Token: 0x0600216D RID: 8557 RVA: 0x00094290 File Offset: 0x00092490
			public UIGroup lxs
			{
				get
				{
					return this._assignedControllersGroup;
				}
			}

			// Token: 0x1700050B RID: 1291
			// (get) Token: 0x0600216E RID: 8558 RVA: 0x00094298 File Offset: 0x00092498
			public Transform lxt
			{
				get
				{
					return this._settingsAndMapCategoriesGroup;
				}
			}

			// Token: 0x1700050C RID: 1292
			// (get) Token: 0x0600216F RID: 8559 RVA: 0x000942A0 File Offset: 0x000924A0
			public UIGroup lxu
			{
				get
				{
					return this._settingsGroup;
				}
			}

			// Token: 0x1700050D RID: 1293
			// (get) Token: 0x06002170 RID: 8560 RVA: 0x000942A8 File Offset: 0x000924A8
			public UIGroup lxv
			{
				get
				{
					return this._mapCategoriesGroup;
				}
			}

			// Token: 0x1700050E RID: 1294
			// (get) Token: 0x06002171 RID: 8561 RVA: 0x000942B0 File Offset: 0x000924B0
			public Transform lxw
			{
				get
				{
					return this._inputGridGroup;
				}
			}

			// Token: 0x1700050F RID: 1295
			// (get) Token: 0x06002172 RID: 8562 RVA: 0x000942B8 File Offset: 0x000924B8
			public Transform lxx
			{
				get
				{
					return this._inputGridContainer;
				}
			}

			// Token: 0x17000510 RID: 1296
			// (get) Token: 0x06002173 RID: 8563 RVA: 0x000942C0 File Offset: 0x000924C0
			public Transform lxy
			{
				get
				{
					return this._inputGridHeadersGroup;
				}
			}

			// Token: 0x17000511 RID: 1297
			// (get) Token: 0x06002174 RID: 8564 RVA: 0x000942C8 File Offset: 0x000924C8
			public Scrollbar lxz
			{
				get
				{
					return this._inputGridVScrollbar;
				}
			}

			// Token: 0x17000512 RID: 1298
			// (get) Token: 0x06002175 RID: 8565 RVA: 0x000942D0 File Offset: 0x000924D0
			public ScrollRect lya
			{
				get
				{
					return this._inputGridScrollRect;
				}
			}

			// Token: 0x17000513 RID: 1299
			// (get) Token: 0x06002176 RID: 8566 RVA: 0x000942D8 File Offset: 0x000924D8
			public Transform lyb
			{
				get
				{
					return this._inputGridInnerGroup;
				}
			}

			// Token: 0x17000514 RID: 1300
			// (get) Token: 0x06002177 RID: 8567 RVA: 0x000942E0 File Offset: 0x000924E0
			public TMP_Text lyc
			{
				get
				{
					return this._controllerNameLabel;
				}
			}

			// Token: 0x17000515 RID: 1301
			// (get) Token: 0x06002178 RID: 8568 RVA: 0x000942E8 File Offset: 0x000924E8
			public Button lyd
			{
				get
				{
					return this._removeControllerButton;
				}
			}

			// Token: 0x17000516 RID: 1302
			// (get) Token: 0x06002179 RID: 8569 RVA: 0x000942F0 File Offset: 0x000924F0
			public Button lye
			{
				get
				{
					return this._assignControllerButton;
				}
			}

			// Token: 0x17000517 RID: 1303
			// (get) Token: 0x0600217A RID: 8570 RVA: 0x000942F8 File Offset: 0x000924F8
			public Button lyf
			{
				get
				{
					return this._calibrateControllerButton;
				}
			}

			// Token: 0x17000518 RID: 1304
			// (get) Token: 0x0600217B RID: 8571 RVA: 0x00094300 File Offset: 0x00092500
			public Button lyg
			{
				get
				{
					return this._doneButton;
				}
			}

			// Token: 0x17000519 RID: 1305
			// (get) Token: 0x0600217C RID: 8572 RVA: 0x00094308 File Offset: 0x00092508
			public Button lyh
			{
				get
				{
					return this._restoreDefaultsButton;
				}
			}

			// Token: 0x1700051A RID: 1306
			// (get) Token: 0x0600217D RID: 8573 RVA: 0x00094310 File Offset: 0x00092510
			public Selectable lyi
			{
				get
				{
					return this._defaultSelection;
				}
			}

			// Token: 0x1700051B RID: 1307
			// (get) Token: 0x0600217E RID: 8574 RVA: 0x00094318 File Offset: 0x00092518
			public GameObject[] lyj
			{
				get
				{
					return this._fixedSelectableUIElements;
				}
			}

			// Token: 0x1700051C RID: 1308
			// (get) Token: 0x0600217F RID: 8575 RVA: 0x00094320 File Offset: 0x00092520
			public Image lyk
			{
				get
				{
					return this._mainBackgroundImage;
				}
			}

			// Token: 0x1700051D RID: 1309
			// (get) Token: 0x06002180 RID: 8576 RVA: 0x00094328 File Offset: 0x00092528
			// (set) Token: 0x06002181 RID: 8577 RVA: 0x00094330 File Offset: 0x00092530
			public LayoutElement jzz { get; set; }

			// Token: 0x1700051E RID: 1310
			// (get) Token: 0x06002182 RID: 8578 RVA: 0x00094339 File Offset: 0x00092539
			// (set) Token: 0x06002183 RID: 8579 RVA: 0x00094341 File Offset: 0x00092541
			public Transform kaa { get; set; }

			// Token: 0x1700051F RID: 1311
			// (get) Token: 0x06002184 RID: 8580 RVA: 0x0009434A File Offset: 0x0009254A
			// (set) Token: 0x06002185 RID: 8581 RVA: 0x00094352 File Offset: 0x00092552
			public Transform kab { get; set; }

			// Token: 0x17000520 RID: 1312
			// (get) Token: 0x06002186 RID: 8582 RVA: 0x0009435B File Offset: 0x0009255B
			// (set) Token: 0x06002187 RID: 8583 RVA: 0x00094363 File Offset: 0x00092563
			public Transform kac { get; set; }

			// Token: 0x17000521 RID: 1313
			// (get) Token: 0x06002188 RID: 8584 RVA: 0x0009436C File Offset: 0x0009256C
			// (set) Token: 0x06002189 RID: 8585 RVA: 0x00094374 File Offset: 0x00092574
			public Transform kad { get; set; }

			// Token: 0x17000522 RID: 1314
			// (get) Token: 0x0600218A RID: 8586 RVA: 0x0009437D File Offset: 0x0009257D
			// (set) Token: 0x0600218B RID: 8587 RVA: 0x00094385 File Offset: 0x00092585
			public Transform kae { get; set; }

			// Token: 0x17000523 RID: 1315
			// (get) Token: 0x0600218C RID: 8588 RVA: 0x0009438E File Offset: 0x0009258E
			// (set) Token: 0x0600218D RID: 8589 RVA: 0x00094396 File Offset: 0x00092596
			public Transform kaf { get; set; }

			// Token: 0x17000524 RID: 1316
			// (get) Token: 0x0600218E RID: 8590 RVA: 0x0009439F File Offset: 0x0009259F
			// (set) Token: 0x0600218F RID: 8591 RVA: 0x000943A7 File Offset: 0x000925A7
			public Transform kag { get; set; }

			// Token: 0x17000525 RID: 1317
			// (get) Token: 0x06002190 RID: 8592 RVA: 0x000943B0 File Offset: 0x000925B0
			// (set) Token: 0x06002191 RID: 8593 RVA: 0x000943B8 File Offset: 0x000925B8
			public Transform kah { get; set; }

			// Token: 0x06002192 RID: 8594 RVA: 0x000943C4 File Offset: 0x000925C4
			public bool fqj()
			{
				return !(this._canvas == null) && !(this._mainCanvasGroup == null) && !(this._mainContent == null) && !(this._mainContentInner == null) && !(this._playersGroup == null) && !(this._controllerGroup == null) && !(this._controllerGroupLabelGroup == null) && !(this._controllerSettingsGroup == null) && !(this._assignedControllersGroup == null) && !(this._settingsAndMapCategoriesGroup == null) && !(this._settingsGroup == null) && !(this._mapCategoriesGroup == null) && !(this._inputGridGroup == null) && !(this._inputGridContainer == null) && !(this._inputGridHeadersGroup == null) && !(this._inputGridVScrollbar == null) && !(this._inputGridScrollRect == null) && !(this._inputGridInnerGroup == null) && !(this._controllerNameLabel == null) && !(this._removeControllerButton == null) && !(this._assignControllerButton == null) && !(this._calibrateControllerButton == null) && !(this._doneButton == null) && !(this._restoreDefaultsButton == null) && !(this._defaultSelection == null);
			}

			// Token: 0x0400109B RID: 4251
			[SerializeField]
			private Canvas _canvas;

			// Token: 0x0400109C RID: 4252
			[SerializeField]
			private CanvasGroup _mainCanvasGroup;

			// Token: 0x0400109D RID: 4253
			[SerializeField]
			private Transform _mainContent;

			// Token: 0x0400109E RID: 4254
			[SerializeField]
			private Transform _mainContentInner;

			// Token: 0x0400109F RID: 4255
			[SerializeField]
			private UIGroup _playersGroup;

			// Token: 0x040010A0 RID: 4256
			[SerializeField]
			private Transform _controllerGroup;

			// Token: 0x040010A1 RID: 4257
			[SerializeField]
			private Transform _controllerGroupLabelGroup;

			// Token: 0x040010A2 RID: 4258
			[SerializeField]
			private UIGroup _controllerSettingsGroup;

			// Token: 0x040010A3 RID: 4259
			[SerializeField]
			private UIGroup _assignedControllersGroup;

			// Token: 0x040010A4 RID: 4260
			[SerializeField]
			private Transform _settingsAndMapCategoriesGroup;

			// Token: 0x040010A5 RID: 4261
			[SerializeField]
			private UIGroup _settingsGroup;

			// Token: 0x040010A6 RID: 4262
			[SerializeField]
			private UIGroup _mapCategoriesGroup;

			// Token: 0x040010A7 RID: 4263
			[SerializeField]
			private Transform _inputGridGroup;

			// Token: 0x040010A8 RID: 4264
			[SerializeField]
			private Transform _inputGridContainer;

			// Token: 0x040010A9 RID: 4265
			[SerializeField]
			private Transform _inputGridHeadersGroup;

			// Token: 0x040010AA RID: 4266
			[SerializeField]
			private Scrollbar _inputGridVScrollbar;

			// Token: 0x040010AB RID: 4267
			[SerializeField]
			private ScrollRect _inputGridScrollRect;

			// Token: 0x040010AC RID: 4268
			[SerializeField]
			private Transform _inputGridInnerGroup;

			// Token: 0x040010AD RID: 4269
			[SerializeField]
			private TMP_Text _controllerNameLabel;

			// Token: 0x040010AE RID: 4270
			[SerializeField]
			private Button _removeControllerButton;

			// Token: 0x040010AF RID: 4271
			[SerializeField]
			private Button _assignControllerButton;

			// Token: 0x040010B0 RID: 4272
			[SerializeField]
			private Button _calibrateControllerButton;

			// Token: 0x040010B1 RID: 4273
			[SerializeField]
			private Button _doneButton;

			// Token: 0x040010B2 RID: 4274
			[SerializeField]
			private Button _restoreDefaultsButton;

			// Token: 0x040010B3 RID: 4275
			[SerializeField]
			private Selectable _defaultSelection;

			// Token: 0x040010B4 RID: 4276
			[SerializeField]
			private GameObject[] _fixedSelectableUIElements;

			// Token: 0x040010B5 RID: 4277
			[SerializeField]
			private Image _mainBackgroundImage;
		}

		// Token: 0x02000206 RID: 518
		private class jh
		{
			// Token: 0x17000526 RID: 1318
			// (get) Token: 0x06002194 RID: 8596 RVA: 0x00094565 File Offset: 0x00092765
			public int lyl
			{
				get
				{
					return this.kai;
				}
			}

			// Token: 0x17000527 RID: 1319
			// (get) Token: 0x06002195 RID: 8597 RVA: 0x0009456D File Offset: 0x0009276D
			public AxisRange lym
			{
				get
				{
					return this.kaj;
				}
			}

			// Token: 0x06002196 RID: 8598 RVA: 0x00094575 File Offset: 0x00092775
			public jh(int a, AxisRange b)
			{
				this.kai = a;
				this.kaj = b;
			}

			// Token: 0x040010BF RID: 4287
			private int kai;

			// Token: 0x040010C0 RID: 4288
			private AxisRange kaj;
		}

		// Token: 0x02000207 RID: 519
		private class ji
		{
			// Token: 0x1700052C RID: 1324
			// (get) Token: 0x06002197 RID: 8599 RVA: 0x0009458B File Offset: 0x0009278B
			// (set) Token: 0x060021A0 RID: 8608 RVA: 0x000946BA File Offset: 0x000928BA
			public ControllerType kao { get; private set; }

			// Token: 0x06002198 RID: 8600 RVA: 0x00094594 File Offset: 0x00092794
			public ElementAssignment frg()
			{
				return new ElementAssignment(this.kao, this.kaq.elementType, this.kaq.elementIdentifierId, this.lyn, this.kaq.keyboardKey, this.kar, this.kal.kfx, (this.kal.mbz == AxisRange.Negative) ? Pole.Negative : Pole.Positive, false, (this.kan != null) ? this.kan.id : (-1));
			}

			// Token: 0x1700052D RID: 1325
			// (get) Token: 0x060021A1 RID: 8609 RVA: 0x000946C3 File Offset: 0x000928C3
			// (set) Token: 0x06002199 RID: 8601 RVA: 0x00094616 File Offset: 0x00092816
			public int kap { get; private set; }

			// Token: 0x17000531 RID: 1329
			// (get) Token: 0x0600219A RID: 8602 RVA: 0x00094620 File Offset: 0x00092820
			public string lyo
			{
				get
				{
					if (this.kao == ControllerType.Keyboard)
					{
						return ControlMapper.ghi().gms(this.kaq.keyboardKey, this.kar);
					}
					return ControlMapper.ghi().gmr(this.kaq.controller, this.kaq.elementIdentifierId, (this.kaq.axisPole == Pole.Positive) ? AxisRange.Positive : AxisRange.Negative);
				}
			}

			// Token: 0x1700052E RID: 1326
			// (get) Token: 0x060021AD RID: 8621 RVA: 0x0009487F File Offset: 0x00092A7F
			// (set) Token: 0x0600219B RID: 8603 RVA: 0x0009468E File Offset: 0x0009288E
			public ControllerPollingInfo kaq { get; set; }

			// Token: 0x1700052F RID: 1327
			// (get) Token: 0x060021A6 RID: 8614 RVA: 0x000947AE File Offset: 0x000929AE
			// (set) Token: 0x0600219C RID: 8604 RVA: 0x00094697 File Offset: 0x00092897
			public ModifierKeyFlags kar { get; set; }

			// Token: 0x1700052A RID: 1322
			// (get) Token: 0x0600219D RID: 8605 RVA: 0x000946A0 File Offset: 0x000928A0
			// (set) Token: 0x060021AC RID: 8620 RVA: 0x00094876 File Offset: 0x00092A76
			public ControllerMap kam { get; private set; }

			// Token: 0x17000528 RID: 1320
			// (get) Token: 0x060021A7 RID: 8615 RVA: 0x000947B6 File Offset: 0x000929B6
			// (set) Token: 0x0600219E RID: 8606 RVA: 0x000946A8 File Offset: 0x000928A8
			public string kak { get; private set; }

			// Token: 0x17000529 RID: 1321
			// (get) Token: 0x060021AF RID: 8623 RVA: 0x0009489D File Offset: 0x00092A9D
			// (set) Token: 0x0600219F RID: 8607 RVA: 0x000946B1 File Offset: 0x000928B1
			public kf kal { get; private set; }

			// Token: 0x060021A2 RID: 8610 RVA: 0x000946CB File Offset: 0x000928CB
			public ElementAssignment dmb(ControllerPollingInfo a)
			{
				this.kaq = a;
				return this.frg();
			}

			// Token: 0x17000530 RID: 1328
			// (get) Token: 0x060021A3 RID: 8611 RVA: 0x000946DC File Offset: 0x000928DC
			public AxisRange lyn
			{
				get
				{
					AxisRange axisRange = AxisRange.Positive;
					if (this.kaq.elementType == ControllerElementType.Axis)
					{
						if (this.kal.mbz == AxisRange.Full)
						{
							axisRange = AxisRange.Full;
						}
						else
						{
							axisRange = ((this.kaq.axisPole == Pole.Positive) ? AxisRange.Positive : AxisRange.Negative);
						}
					}
					return axisRange;
				}
			}

			// Token: 0x1700052B RID: 1323
			// (get) Token: 0x060021B1 RID: 8625 RVA: 0x0009492A File Offset: 0x00092B2A
			// (set) Token: 0x060021A4 RID: 8612 RVA: 0x00094722 File Offset: 0x00092922
			public ActionElementMap kan { get; private set; }

			// Token: 0x060021A5 RID: 8613 RVA: 0x0009472C File Offset: 0x0009292C
			public ElementAssignment huj()
			{
				return new ElementAssignment(this.kao, this.kaq.elementType, this.kaq.elementIdentifierId, this.lyn, this.kaq.keyboardKey, this.kar, this.kal.kfx, (this.kal.mbz == AxisRange.Negative) ? Pole.Negative : Pole.Positive, false, (this.kan != null) ? this.kan.id : (-1));
			}

			// Token: 0x060021A8 RID: 8616 RVA: 0x000947BE File Offset: 0x000929BE
			public ji(string a, kf b, ControllerMap c, ActionElementMap d, ControllerType e, int f)
			{
				this.kak = a;
				this.kal = b;
				this.kam = c;
				this.kan = d;
				this.kao = e;
				this.kap = f;
			}

			// Token: 0x060021A9 RID: 8617 RVA: 0x000947F4 File Offset: 0x000929F4
			public ElementAssignment hqz()
			{
				return new ElementAssignment(this.kao, this.kaq.elementType, this.kaq.elementIdentifierId, this.lyn, this.kaq.keyboardKey, this.kar, this.kal.kfx, (this.kal.mbz == AxisRange.Negative) ? Pole.Negative : Pole.Positive, false, (this.kan != null) ? this.kan.id : (-1));
			}

			// Token: 0x060021AA RID: 8618 RVA: 0x000946CB File Offset: 0x000928CB
			public ElementAssignment fre(ControllerPollingInfo a)
			{
				this.kaq = a;
				return this.frg();
			}

			// Token: 0x060021AB RID: 8619 RVA: 0x000946CB File Offset: 0x000928CB
			public ElementAssignment efz(ControllerPollingInfo a)
			{
				this.kaq = a;
				return this.frg();
			}

			// Token: 0x060021AE RID: 8622 RVA: 0x00094887 File Offset: 0x00092A87
			public ElementAssignment frf(ControllerPollingInfo a, ModifierKeyFlags b)
			{
				this.kaq = a;
				this.kar = b;
				return this.frg();
			}

			// Token: 0x060021B0 RID: 8624 RVA: 0x000948A8 File Offset: 0x00092AA8
			public ElementAssignment czo()
			{
				return new ElementAssignment(this.kao, this.kaq.elementType, this.kaq.elementIdentifierId, this.lyn, this.kaq.keyboardKey, this.kar, this.kal.kfx, (this.kal.mbz == AxisRange.Negative) ? Pole.Negative : Pole.Positive, false, (this.kan != null) ? this.kan.id : (-1));
			}
		}

		// Token: 0x02000208 RID: 520
		private class jj
		{
			// Token: 0x060021B2 RID: 8626 RVA: 0x00094934 File Offset: 0x00092B34
			public void nro()
			{
				if (this.kav == null)
				{
					return;
				}
				AxisCalibration axis = this.kat.calibrationMap.GetAxis(this.kau);
				if (axis == null)
				{
					return;
				}
				if ((double)Mathf.Abs(this.kas.max - this.kas.min) < -5556.0)
				{
					return;
				}
				axis.SetData(this.kas);
			}

			// Token: 0x17000532 RID: 1330
			// (get) Token: 0x060021B3 RID: 8627 RVA: 0x0009499A File Offset: 0x00092B9A
			public bool lyp
			{
				get
				{
					return this.kav != null;
				}
			}

			// Token: 0x060021B4 RID: 8628 RVA: 0x000949A8 File Offset: 0x00092BA8
			public void fri()
			{
				if (this.kav == null)
				{
					return;
				}
				float valueRaw = this.kav.valueRaw;
				if (this.kaw || valueRaw < this.kas.min)
				{
					this.kas.min = valueRaw;
				}
				if (this.kaw || valueRaw > this.kas.max)
				{
					this.kas.max = valueRaw;
				}
				this.kaw = false;
			}

			// Token: 0x060021B5 RID: 8629 RVA: 0x00094A15 File Offset: 0x00092C15
			public void frj()
			{
				if (this.kav == null)
				{
					return;
				}
				this.kas.zero = this.kav.valueRaw;
			}

			// Token: 0x060021B6 RID: 8630 RVA: 0x00094A38 File Offset: 0x00092C38
			public void frk()
			{
				if (this.kav == null)
				{
					return;
				}
				AxisCalibration axis = this.kat.calibrationMap.GetAxis(this.kau);
				if (axis == null)
				{
					return;
				}
				if ((double)Mathf.Abs(this.kas.max - this.kas.min) < 0.1)
				{
					return;
				}
				axis.SetData(this.kas);
			}

			// Token: 0x060021B7 RID: 8631 RVA: 0x00094AA0 File Offset: 0x00092CA0
			public void kwn()
			{
				if (this.kav == null)
				{
					return;
				}
				float valueRaw = this.kav.valueRaw;
				if (this.kaw || valueRaw < this.kas.min)
				{
					this.kas.min = valueRaw;
				}
				if (this.kaw || valueRaw > this.kas.max)
				{
					this.kas.max = valueRaw;
				}
				this.kaw = false;
			}

			// Token: 0x060021B8 RID: 8632 RVA: 0x00094B10 File Offset: 0x00092D10
			public void dfv()
			{
				if (this.kav == null)
				{
					return;
				}
				float valueRaw = this.kav.valueRaw;
				if (this.kaw || valueRaw < this.kas.min)
				{
					this.kas.min = valueRaw;
				}
				if (this.kaw || valueRaw > this.kas.max)
				{
					this.kas.max = valueRaw;
				}
				this.kaw = false;
			}

			// Token: 0x060021B9 RID: 8633 RVA: 0x00094B80 File Offset: 0x00092D80
			public void opk()
			{
				if (this.kav == null)
				{
					return;
				}
				float valueRaw = this.kav.valueRaw;
				if (this.kaw || valueRaw < this.kas.min)
				{
					this.kas.min = valueRaw;
				}
				if (this.kaw || valueRaw > this.kas.max)
				{
					this.kas.max = valueRaw;
				}
				this.kaw = false;
			}

			// Token: 0x060021BA RID: 8634 RVA: 0x00094BF0 File Offset: 0x00092DF0
			public void bix()
			{
				if (this.kav == null)
				{
					return;
				}
				AxisCalibration axis = this.kat.calibrationMap.GetAxis(this.kau);
				if (axis == null)
				{
					return;
				}
				if ((double)Mathf.Abs(this.kas.max - this.kas.min) < 9090.0)
				{
					return;
				}
				axis.SetData(this.kas);
			}

			// Token: 0x060021BB RID: 8635 RVA: 0x00094C58 File Offset: 0x00092E58
			public void obh()
			{
				if (this.kav == null)
				{
					return;
				}
				AxisCalibration axis = this.kat.calibrationMap.GetAxis(this.kau);
				if (axis == null)
				{
					return;
				}
				if ((double)Mathf.Abs(this.kas.max - this.kas.min) < -9489.0)
				{
					return;
				}
				axis.SetData(this.kas);
			}

			// Token: 0x060021BC RID: 8636 RVA: 0x00094CC0 File Offset: 0x00092EC0
			public jj(Joystick a, int b)
			{
				this.kas = default(AxisCalibrationData);
				this.kat = a;
				this.kau = b;
				if (a != null && b >= 0 && a.axisCount > b)
				{
					this.kav = a.Axes[b];
					this.kas = a.calibrationMap.GetAxis(b).GetData();
				}
				this.kaw = true;
			}

			// Token: 0x040010C9 RID: 4297
			public AxisCalibrationData kas;

			// Token: 0x040010CA RID: 4298
			public readonly Joystick kat;

			// Token: 0x040010CB RID: 4299
			public readonly int kau;

			// Token: 0x040010CC RID: 4300
			private Controller.Axis kav;

			// Token: 0x040010CD RID: 4301
			private bool kaw;
		}

		// Token: 0x02000209 RID: 521
		private class jl<a, b>
		{
			// Token: 0x17000534 RID: 1332
			public b this[int index]
			{
				get
				{
					return this.kaz[index].kay;
				}
			}

			// Token: 0x060021BE RID: 8638 RVA: 0x00094D40 File Offset: 0x00092F40
			public jl()
			{
				this.kaz = new List<ControlMapper.jl<a, b>.jk>();
			}

			// Token: 0x17000533 RID: 1331
			// (get) Token: 0x060021BF RID: 8639 RVA: 0x00094D53 File Offset: 0x00092F53
			public int lyq
			{
				get
				{
					return this.kaz.Count;
				}
			}

			// Token: 0x060021C0 RID: 8640 RVA: 0x00094D60 File Offset: 0x00092F60
			public void fqa()
			{
				this.kaz.Clear();
			}

			// Token: 0x060021C1 RID: 8641 RVA: 0x00094D60 File Offset: 0x00092F60
			public void hkn()
			{
				this.kaz.Clear();
			}

			// Token: 0x060021C2 RID: 8642 RVA: 0x00094D70 File Offset: 0x00092F70
			public bool frn(a a, out b b)
			{
				b = default(b);
				int num = this.fro(a);
				if (num < 0)
				{
					return false;
				}
				b = this.kaz[num].kay;
				return true;
			}

			// Token: 0x060021C3 RID: 8643 RVA: 0x00094D60 File Offset: 0x00092F60
			public void frq()
			{
				this.kaz.Clear();
			}

			// Token: 0x060021C4 RID: 8644 RVA: 0x00094D60 File Offset: 0x00092F60
			public void ftj()
			{
				this.kaz.Clear();
			}

			// Token: 0x060021C5 RID: 8645 RVA: 0x00094DAC File Offset: 0x00092FAC
			public b frm(a a)
			{
				int num = this.fro(a);
				if (num < 0)
				{
					throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.etb());
				}
				return this.kaz[num].kay;
			}

			// Token: 0x060021C6 RID: 8646 RVA: 0x00094DE4 File Offset: 0x00092FE4
			public bool frp(a a)
			{
				int count = this.kaz.Count;
				for (int i = 0; i < count; i++)
				{
					if (EqualityComparer<a>.Default.Equals(this.kaz[i].kax, a))
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x060021C7 RID: 8647 RVA: 0x00094E2A File Offset: 0x0009302A
			public void Add(a key, b value)
			{
				if (this.frp(key))
				{
					throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.etc() + key.ToString() + global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.etd());
				}
				this.kaz.Add(new ControlMapper.jl<a, b>.jk(key, value));
			}

			// Token: 0x060021C8 RID: 8648 RVA: 0x00094D60 File Offset: 0x00092F60
			public void jcc()
			{
				this.kaz.Clear();
			}

			// Token: 0x060021C9 RID: 8649 RVA: 0x00094E6C File Offset: 0x0009306C
			public int fro(a a)
			{
				int count = this.kaz.Count;
				for (int i = 0; i < count; i++)
				{
					if (EqualityComparer<a>.Default.Equals(this.kaz[i].kax, a))
					{
						return i;
					}
				}
				return -1;
			}

			// Token: 0x040010CE RID: 4302
			private List<ControlMapper.jl<a, b>.jk> kaz;

			// Token: 0x0200020A RID: 522
			private class jk
			{
				// Token: 0x060021CA RID: 8650 RVA: 0x00094EB2 File Offset: 0x000930B2
				public jk(a a, b b)
				{
					this.kax = a;
					this.kay = b;
				}

				// Token: 0x040010CF RID: 4303
				public a kax;

				// Token: 0x040010D0 RID: 4304
				public b kay;
			}
		}

		// Token: 0x0200020B RID: 523
		private enum LayoutElementSizeType
		{
			// Token: 0x040010D2 RID: 4306
			MinSize,
			// Token: 0x040010D3 RID: 4307
			PreferredSize
		}

		// Token: 0x0200020C RID: 524
		private enum WindowType
		{
			// Token: 0x040010D5 RID: 4309
			None,
			// Token: 0x040010D6 RID: 4310
			ChooseJoystick,
			// Token: 0x040010D7 RID: 4311
			JoystickAssignmentConflict,
			// Token: 0x040010D8 RID: 4312
			ElementAssignment,
			// Token: 0x040010D9 RID: 4313
			ElementAssignmentPrePolling,
			// Token: 0x040010DA RID: 4314
			ElementAssignmentPolling,
			// Token: 0x040010DB RID: 4315
			ElementAssignmentResult,
			// Token: 0x040010DC RID: 4316
			ElementAssignmentConflict,
			// Token: 0x040010DD RID: 4317
			Calibration,
			// Token: 0x040010DE RID: 4318
			CalibrateStep1,
			// Token: 0x040010DF RID: 4319
			CalibrateStep2
		}

		// Token: 0x0200020D RID: 525
		private class jm
		{
			// Token: 0x060021CB RID: 8651 RVA: 0x00094EC8 File Offset: 0x000930C8
			public void fny(int a, InputAction b, AxisRange c)
			{
				this.kba.ftv(a, b, c);
			}

			// Token: 0x060021CC RID: 8652 RVA: 0x00094ED8 File Offset: 0x000930D8
			public IEnumerable<ControlMapper.jh> nje(int a)
			{
				return this.kba.fuk(a);
			}

			// Token: 0x060021CD RID: 8653 RVA: 0x00094EE6 File Offset: 0x000930E6
			public void cge()
			{
				this.kba.fur();
			}

			// Token: 0x060021CE RID: 8654 RVA: 0x00094EC8 File Offset: 0x000930C8
			public void frs(int a, InputAction b, AxisRange c)
			{
				this.kba.ftv(a, b, c);
			}

			// Token: 0x060021CF RID: 8655 RVA: 0x00094EF3 File Offset: 0x000930F3
			public void cly(int a)
			{
				this.kba.fuq(a);
			}

			// Token: 0x060021D0 RID: 8656 RVA: 0x00094F01 File Offset: 0x00093101
			public float fvn(int a)
			{
				return this.kba.fug(a);
			}

			// Token: 0x060021D1 RID: 8657 RVA: 0x00094F0F File Offset: 0x0009310F
			public bool muk(int a, int b, AxisRange c, ControllerType d, int e)
			{
				return this.kba.fue(a, b, c, d, e);
			}

			// Token: 0x060021D2 RID: 8658 RVA: 0x00094F23 File Offset: 0x00093123
			public void frx(int a, int b, AxisRange c, ControlMapper.jg d)
			{
				this.kba.ftx(a, b, c, d);
			}

			// Token: 0x060021D3 RID: 8659 RVA: 0x00094F35 File Offset: 0x00093135
			public void fry(int a, int b, ControlMapper.jg c)
			{
				this.kba.fua(a, b, c);
			}

			// Token: 0x060021D4 RID: 8660 RVA: 0x00094F45 File Offset: 0x00093145
			public void cgj(int a, int b, AxisRange c, ControllerType d, int e, string f)
			{
				this.kba.fum(a, b, c, d, e, f);
			}

			// Token: 0x060021D5 RID: 8661 RVA: 0x00094EF3 File Offset: 0x000930F3
			public void boo(int a)
			{
				this.kba.fuq(a);
			}

			// Token: 0x060021D6 RID: 8662 RVA: 0x00094ED8 File Offset: 0x000930D8
			public IEnumerable<ControlMapper.jh> fsb(int a)
			{
				return this.kba.fuk(a);
			}

			// Token: 0x060021D7 RID: 8663 RVA: 0x00094F5B File Offset: 0x0009315B
			public void ixm()
			{
				this.fsm();
				this.kba.fut();
			}

			// Token: 0x060021D8 RID: 8664 RVA: 0x00094F6E File Offset: 0x0009316E
			public void frt(int a, int b)
			{
				this.kba.fty(a, b);
			}

			// Token: 0x060021D9 RID: 8665 RVA: 0x00094F23 File Offset: 0x00093123
			public void kae(int a, int b, AxisRange c, ControlMapper.jg d)
			{
				this.kba.ftx(a, b, c, d);
			}

			// Token: 0x060021DA RID: 8666 RVA: 0x00094F45 File Offset: 0x00093145
			public void fsf(int a, int b, AxisRange c, ControllerType d, int e, string f)
			{
				this.kba.fum(a, b, c, d, e, f);
			}

			// Token: 0x060021DB RID: 8667 RVA: 0x00094F23 File Offset: 0x00093123
			public void cym(int a, int b, AxisRange c, ControlMapper.jg d)
			{
				this.kba.ftx(a, b, c, d);
			}

			// Token: 0x060021DC RID: 8668 RVA: 0x00094F0F File Offset: 0x0009310F
			public bool llp(int a, int b, AxisRange c, ControllerType d, int e)
			{
				return this.kba.fue(a, b, c, d, e);
			}

			// Token: 0x060021DD RID: 8669 RVA: 0x00094F7D File Offset: 0x0009317D
			public void fsi(int a)
			{
				this.kba.fup(a);
			}

			// Token: 0x060021DE RID: 8670 RVA: 0x00094EF3 File Offset: 0x000930F3
			public void edx(int a)
			{
				this.kba.fuq(a);
			}

			// Token: 0x060021DF RID: 8671 RVA: 0x00094F5B File Offset: 0x0009315B
			public void fsn()
			{
				this.fsm();
				this.kba.fut();
			}

			// Token: 0x060021E0 RID: 8672 RVA: 0x00094F01 File Offset: 0x00093101
			public float bmh(int a)
			{
				return this.kba.fug(a);
			}

			// Token: 0x060021E1 RID: 8673 RVA: 0x00094F8B File Offset: 0x0009318B
			public void gcv(int a, bool b)
			{
				this.kba.ful(a, b);
			}

			// Token: 0x060021E2 RID: 8674 RVA: 0x00094F9A File Offset: 0x0009319A
			public void kdh(GameObject a)
			{
				this.kbb.Add(a);
			}

			// Token: 0x060021E3 RID: 8675 RVA: 0x00094FA8 File Offset: 0x000931A8
			public jm()
			{
				this.kba = new ControlMapper.js();
				this.kbb = new List<GameObject>();
			}

			// Token: 0x060021E4 RID: 8676 RVA: 0x00094FC8 File Offset: 0x000931C8
			public void hmz(int a, int b, AxisRange c, ControllerType d, int e, int f, int g, string h, bool i)
			{
				this.kba.fun(a, b, c, d, e, f, g, h, i);
			}

			// Token: 0x060021E5 RID: 8677 RVA: 0x00094F01 File Offset: 0x00093101
			public float cjq(int a)
			{
				return this.kba.fug(a);
			}

			// Token: 0x060021E6 RID: 8678 RVA: 0x00094F5B File Offset: 0x0009315B
			public void gry()
			{
				this.fsm();
				this.kba.fut();
			}

			// Token: 0x060021E7 RID: 8679 RVA: 0x00094F9A File Offset: 0x0009319A
			public void frw(GameObject a)
			{
				this.kbb.Add(a);
			}

			// Token: 0x060021E8 RID: 8680 RVA: 0x00094F8B File Offset: 0x0009318B
			public void nwe(int a, bool b)
			{
				this.kba.ful(a, b);
			}

			// Token: 0x060021E9 RID: 8681 RVA: 0x00094FEF File Offset: 0x000931EF
			public void bvh(int a)
			{
				this.kba.fus(a);
			}

			// Token: 0x060021EA RID: 8682 RVA: 0x00095000 File Offset: 0x00093200
			public void fsg(int a, int b, AxisRange c, ControllerType d, int e, int f, int g, string h, bool i)
			{
				this.kba.fun(a, b, c, d, e, f, g, h, i);
			}

			// Token: 0x060021EB RID: 8683 RVA: 0x00094F35 File Offset: 0x00093135
			public void dkj(int a, int b, ControlMapper.jg c)
			{
				this.kba.fua(a, b, c);
			}

			// Token: 0x060021EC RID: 8684 RVA: 0x00094EE6 File Offset: 0x000930E6
			public void jss()
			{
				this.kba.fur();
			}

			// Token: 0x060021ED RID: 8685 RVA: 0x00094F35 File Offset: 0x00093135
			public void myo(int a, int b, ControlMapper.jg c)
			{
				this.kba.fua(a, b, c);
			}

			// Token: 0x060021EE RID: 8686 RVA: 0x00094EE6 File Offset: 0x000930E6
			public void hke()
			{
				this.kba.fur();
			}

			// Token: 0x060021EF RID: 8687 RVA: 0x00094F9A File Offset: 0x0009319A
			public void huz(GameObject a)
			{
				this.kbb.Add(a);
			}

			// Token: 0x060021F0 RID: 8688 RVA: 0x00094EE6 File Offset: 0x000930E6
			public void fsk()
			{
				this.kba.fur();
			}

			// Token: 0x060021F1 RID: 8689 RVA: 0x00094F8B File Offset: 0x0009318B
			public void iwl(int a, bool b)
			{
				this.kba.ful(a, b);
			}

			// Token: 0x060021F2 RID: 8690 RVA: 0x00094F01 File Offset: 0x00093101
			public float nww(int a)
			{
				return this.kba.fug(a);
			}

			// Token: 0x060021F3 RID: 8691 RVA: 0x00094F35 File Offset: 0x00093135
			public void gti(int a, int b, ControlMapper.jg c)
			{
				this.kba.fua(a, b, c);
			}

			// Token: 0x060021F4 RID: 8692 RVA: 0x00094F35 File Offset: 0x00093135
			public void ti(int a, int b, ControlMapper.jg c)
			{
				this.kba.fua(a, b, c);
			}

			// Token: 0x060021F5 RID: 8693 RVA: 0x00094FEF File Offset: 0x000931EF
			public void fyc(int a)
			{
				this.kba.fus(a);
			}

			// Token: 0x060021F6 RID: 8694 RVA: 0x00094F45 File Offset: 0x00093145
			public void jdp(int a, int b, AxisRange c, ControllerType d, int e, string f)
			{
				this.kba.fum(a, b, c, d, e, f);
			}

			// Token: 0x060021F7 RID: 8695 RVA: 0x00095027 File Offset: 0x00093227
			public void jpb(int a, float b)
			{
				this.kba.fuf(a, b);
			}

			// Token: 0x060021F8 RID: 8696 RVA: 0x00094F6E File Offset: 0x0009316E
			public void ewr(int a, int b)
			{
				this.kba.fty(a, b);
			}

			// Token: 0x060021F9 RID: 8697 RVA: 0x00095036 File Offset: 0x00093236
			public ControlMapper.jd fjs(int a, int b, AxisRange c, ControllerType d, int e)
			{
				return this.kba.fuh(a, b, c, d, e);
			}

			// Token: 0x060021FA RID: 8698 RVA: 0x00094FEF File Offset: 0x000931EF
			public void bdm(int a)
			{
				this.kba.fus(a);
			}

			// Token: 0x060021FB RID: 8699 RVA: 0x00094F0F File Offset: 0x0009310F
			public bool tu(int a, int b, AxisRange c, ControllerType d, int e)
			{
				return this.kba.fue(a, b, c, d, e);
			}

			// Token: 0x060021FC RID: 8700 RVA: 0x0009504C File Offset: 0x0009324C
			private void lik()
			{
				for (int i = 0; i < this.kbb.Count; i++)
				{
					if (!(this.kbb[i] == null))
					{
						global::UnityEngine.Object.Destroy(this.kbb[i]);
					}
				}
			}

			// Token: 0x060021FD RID: 8701 RVA: 0x00094FEF File Offset: 0x000931EF
			public void fsl(int a)
			{
				this.kba.fus(a);
			}

			// Token: 0x060021FE RID: 8702 RVA: 0x00095036 File Offset: 0x00093236
			public ControlMapper.jd fsa(int a, int b, AxisRange c, ControllerType d, int e)
			{
				return this.kba.fuh(a, b, c, d, e);
			}

			// Token: 0x060021FF RID: 8703 RVA: 0x00095094 File Offset: 0x00093294
			public void frr(int a)
			{
				this.kba.ftu(a);
			}

			// Token: 0x06002200 RID: 8704 RVA: 0x000950A4 File Offset: 0x000932A4
			private void mjl()
			{
				for (int i = 0; i < this.kbb.Count; i++)
				{
					if (!(this.kbb[i] == null))
					{
						global::UnityEngine.Object.Destroy(this.kbb[i]);
					}
				}
			}

			// Token: 0x06002201 RID: 8705 RVA: 0x00094ED8 File Offset: 0x000930D8
			public IEnumerable<ControlMapper.jh> lhu(int a)
			{
				return this.kba.fuk(a);
			}

			// Token: 0x06002202 RID: 8706 RVA: 0x00095027 File Offset: 0x00093227
			public void mrn(int a, float b)
			{
				this.kba.fuf(a, b);
			}

			// Token: 0x06002203 RID: 8707 RVA: 0x000950EC File Offset: 0x000932EC
			private void fsm()
			{
				for (int i = 0; i < this.kbb.Count; i++)
				{
					if (!(this.kbb[i] == null))
					{
						global::UnityEngine.Object.Destroy(this.kbb[i]);
					}
				}
			}

			// Token: 0x06002204 RID: 8708 RVA: 0x00094F45 File Offset: 0x00093145
			public void cug(int a, int b, AxisRange c, ControllerType d, int e, string f)
			{
				this.kba.fum(a, b, c, d, e, f);
			}

			// Token: 0x06002205 RID: 8709 RVA: 0x00094EC8 File Offset: 0x000930C8
			public void cds(int a, InputAction b, AxisRange c)
			{
				this.kba.ftv(a, b, c);
			}

			// Token: 0x06002206 RID: 8710 RVA: 0x00095134 File Offset: 0x00093334
			public void izy(int a, int b, AxisRange c, ControllerType d, int e, int f, int g, string h, bool i)
			{
				this.kba.fun(a, b, c, d, e, f, g, h, i);
			}

			// Token: 0x06002207 RID: 8711 RVA: 0x00094F7D File Offset: 0x0009317D
			public void iuo(int a)
			{
				this.kba.fup(a);
			}

			// Token: 0x06002208 RID: 8712 RVA: 0x00095027 File Offset: 0x00093227
			public void hoq(int a, float b)
			{
				this.kba.fuf(a, b);
			}

			// Token: 0x06002209 RID: 8713 RVA: 0x0009515B File Offset: 0x0009335B
			public void fru(int a, InputAction b, AxisRange c, ControllerType d, GameObject e)
			{
				this.kba.fub(a, b, c, d, e);
			}

			// Token: 0x0600220A RID: 8714 RVA: 0x00094EF3 File Offset: 0x000930F3
			public void fsj(int a)
			{
				this.kba.fuq(a);
			}

			// Token: 0x0600220B RID: 8715 RVA: 0x00095170 File Offset: 0x00093370
			private void bra()
			{
				for (int i = 0; i < this.kbb.Count; i++)
				{
					if (!(this.kbb[i] == null))
					{
						global::UnityEngine.Object.Destroy(this.kbb[i]);
					}
				}
			}

			// Token: 0x0600220C RID: 8716 RVA: 0x00094F01 File Offset: 0x00093101
			public float fsd(int a)
			{
				return this.kba.fug(a);
			}

			// Token: 0x0600220D RID: 8717 RVA: 0x00095027 File Offset: 0x00093227
			public void bdg(int a, float b)
			{
				this.kba.fuf(a, b);
			}

			// Token: 0x0600220E RID: 8718 RVA: 0x00095027 File Offset: 0x00093227
			public void fsc(int a, float b)
			{
				this.kba.fuf(a, b);
			}

			// Token: 0x0600220F RID: 8719 RVA: 0x000951B8 File Offset: 0x000933B8
			public void frv(int a, InputAction b, AxisRange c, ControllerType d, int e, ControlMapper.jd f)
			{
				this.kba.fuc(a, b, c, d, e, f);
			}

			// Token: 0x06002210 RID: 8720 RVA: 0x00094F0F File Offset: 0x0009310F
			public bool dcb(int a, int b, AxisRange c, ControllerType d, int e)
			{
				return this.kba.fue(a, b, c, d, e);
			}

			// Token: 0x06002211 RID: 8721 RVA: 0x00094F23 File Offset: 0x00093123
			public void nmr(int a, int b, AxisRange c, ControlMapper.jg d)
			{
				this.kba.ftx(a, b, c, d);
			}

			// Token: 0x06002212 RID: 8722 RVA: 0x00094F8B File Offset: 0x0009318B
			public void fse(int a, bool b)
			{
				this.kba.ful(a, b);
			}

			// Token: 0x06002213 RID: 8723 RVA: 0x000951CE File Offset: 0x000933CE
			public void fsh(int a, int b, AxisRange c, ControllerType d, int e)
			{
				this.kba.fuo(a, b, c, d, e);
			}

			// Token: 0x06002214 RID: 8724 RVA: 0x00094F8B File Offset: 0x0009318B
			public void ceo(int a, bool b)
			{
				this.kba.ful(a, b);
			}

			// Token: 0x06002215 RID: 8725 RVA: 0x00094F0F File Offset: 0x0009310F
			public bool frz(int a, int b, AxisRange c, ControllerType d, int e)
			{
				return this.kba.fue(a, b, c, d, e);
			}

			// Token: 0x06002216 RID: 8726 RVA: 0x00094EE6 File Offset: 0x000930E6
			public void kul()
			{
				this.kba.fur();
			}

			// Token: 0x06002217 RID: 8727 RVA: 0x00094F5B File Offset: 0x0009315B
			public void lvm()
			{
				this.fsm();
				this.kba.fut();
			}

			// Token: 0x06002218 RID: 8728 RVA: 0x00094EF3 File Offset: 0x000930F3
			public void lqe(int a)
			{
				this.kba.fuq(a);
			}

			// Token: 0x040010E0 RID: 4320
			private ControlMapper.js kba;

			// Token: 0x040010E1 RID: 4321
			private List<GameObject> kbb;
		}

		// Token: 0x0200020E RID: 526
		private class js
		{
			// Token: 0x06002219 RID: 8729 RVA: 0x000951E2 File Offset: 0x000933E2
			public bool fud(int a, int b, AxisRange c)
			{
				return this.fui(a, b, c) != null;
			}

			// Token: 0x0600221A RID: 8730 RVA: 0x000951F0 File Offset: 0x000933F0
			private ControlMapper.js.jq cvi(int a, int b)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return null;
				}
				return jn.fsx(b);
			}

			// Token: 0x0600221B RID: 8731 RVA: 0x00095218 File Offset: 0x00093418
			public void cpf(int a)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				List<ControlMapper.js.jo> list = jn.lyr;
				int num = ((list != null) ? list.Count : 0);
				for (int i = 0; i < num; i++)
				{
					list[i].ftk();
				}
			}

			// Token: 0x0600221C RID: 8732 RVA: 0x00095264 File Offset: 0x00093464
			public void bcw(int a, float b)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				jn.lyt = b;
			}

			// Token: 0x0600221D RID: 8733 RVA: 0x0009528C File Offset: 0x0009348C
			public void ccq(int a)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				jn.fsy(true);
			}

			// Token: 0x0600221E RID: 8734 RVA: 0x000952B4 File Offset: 0x000934B4
			private ControlMapper.js.jo fui(int a, int b, AxisRange c)
			{
				if (b < 0)
				{
					return null;
				}
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return null;
				}
				return jn.fss(b, c);
			}

			// Token: 0x0600221F RID: 8735 RVA: 0x000952E4 File Offset: 0x000934E4
			private ControlMapper.js.jq ftz(int a, int b)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return null;
				}
				return jn.fsx(b);
			}

			// Token: 0x06002220 RID: 8736 RVA: 0x0009530A File Offset: 0x0009350A
			public void ftu(int a)
			{
				if (a < 0)
				{
					return;
				}
				if (this.kbx.frp(a))
				{
					return;
				}
				this.kbx.Add(a, new ControlMapper.js.jn());
			}

			// Token: 0x06002221 RID: 8737 RVA: 0x00095334 File Offset: 0x00093534
			public void fun(int a, int b, AxisRange c, ControllerType d, int e, int f, int g, string h, bool i)
			{
				ControlMapper.js.jo jo = this.fui(a, b, c);
				if (jo == null)
				{
					return;
				}
				jo.ftg(d, e, f, g, h, i);
			}

			// Token: 0x06002222 RID: 8738 RVA: 0x00095364 File Offset: 0x00093564
			public void fuc(int a, InputAction b, AxisRange c, ControllerType d, int e, ControlMapper.jd f)
			{
				ControlMapper.js.jo jo = this.fuj(a, b, c);
				if (jo == null)
				{
					return;
				}
				jo.ftc(d, e, f);
			}

			// Token: 0x06002223 RID: 8739 RVA: 0x0009538C File Offset: 0x0009358C
			public ControlMapper.jd fuh(int a, int b, AxisRange c, ControllerType d, int e)
			{
				ControlMapper.js.jo jo = this.fui(a, b, c);
				if (jo == null)
				{
					return null;
				}
				return jo.ftd(d, e);
			}

			// Token: 0x06002224 RID: 8740 RVA: 0x000953B4 File Offset: 0x000935B4
			public bool fue(int a, int b, AxisRange c, ControllerType d, int e)
			{
				ControlMapper.js.jo jo = this.fui(a, b, c);
				return jo != null && jo.fte(d, e);
			}

			// Token: 0x06002225 RID: 8741 RVA: 0x000953DA File Offset: 0x000935DA
			public js()
			{
				this.kbx = new ControlMapper.jl<int, ControlMapper.js.jn>();
			}

			// Token: 0x06002226 RID: 8742 RVA: 0x000953F0 File Offset: 0x000935F0
			public void fge(int a, float b)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				jn.lyt = b;
			}

			// Token: 0x06002227 RID: 8743 RVA: 0x00095418 File Offset: 0x00093618
			private ControlMapper.js.jo ftw(int a, InputAction b, AxisRange c)
			{
				if (b == null)
				{
					return null;
				}
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return null;
				}
				return jn.fsv(b, c);
			}

			// Token: 0x06002228 RID: 8744 RVA: 0x00095444 File Offset: 0x00093644
			public void yu(int a, float b)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				jn.lyt = b;
			}

			// Token: 0x06002229 RID: 8745 RVA: 0x0009546C File Offset: 0x0009366C
			public void jcw(int a)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				List<ControlMapper.js.jo> list = jn.lyr;
				int num = ((list != null) ? list.Count : 0);
				for (int i = 0; i < num; i++)
				{
					list[i].ftk();
				}
			}

			// Token: 0x0600222A RID: 8746 RVA: 0x000954B6 File Offset: 0x000936B6
			public IEnumerable<ControlMapper.jh> fuk(int a)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					yield break;
				}
				List<ControlMapper.js.jo> list = jn.lyr;
				int num = ((list != null) ? list.Count : 0);
				int num2;
				for (int i = 0; i < num; i = num2 + 1)
				{
					yield return list[i].kbj;
					num2 = i;
				}
				yield break;
			}

			// Token: 0x0600222B RID: 8747 RVA: 0x000954CD File Offset: 0x000936CD
			public void nzx(int a, InputAction b, AxisRange c)
			{
				this.ftw(a, b, c);
			}

			// Token: 0x0600222C RID: 8748 RVA: 0x000954DC File Offset: 0x000936DC
			public void fuq(int a)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				jn.fsy(true);
			}

			// Token: 0x0600222D RID: 8749 RVA: 0x00095504 File Offset: 0x00093704
			public bool jna(int a, int b, AxisRange c, ControllerType d, int e)
			{
				ControlMapper.js.jo jo = this.fui(a, b, c);
				return jo != null && jo.fte(d, e);
			}

			// Token: 0x0600222E RID: 8750 RVA: 0x0009552C File Offset: 0x0009372C
			public void eoc(int a, int b, AxisRange c, ControllerType d, int e)
			{
				ControlMapper.js.jo jo = this.fui(a, b, c);
				if (jo == null)
				{
					return;
				}
				jo.fth(d, e);
			}

			// Token: 0x0600222F RID: 8751 RVA: 0x00095554 File Offset: 0x00093754
			public void ful(int a, bool b)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				List<ControlMapper.js.jo> list = jn.lyr;
				int num = ((list != null) ? list.Count : 0);
				for (int i = 0; i < num; i++)
				{
					list[i].ftl(b);
				}
			}

			// Token: 0x06002230 RID: 8752 RVA: 0x000955A0 File Offset: 0x000937A0
			public void hty(int a, InputAction b, AxisRange c, ControllerType d, GameObject e)
			{
				ControlMapper.js.jo jo = this.fuj(a, b, c);
				if (jo == null)
				{
					return;
				}
				jo.ftb(d, e);
			}

			// Token: 0x06002231 RID: 8753 RVA: 0x000955C5 File Offset: 0x000937C5
			public void ley(int a, int b)
			{
				this.ftz(a, b);
			}

			// Token: 0x06002232 RID: 8754 RVA: 0x000955D0 File Offset: 0x000937D0
			public void fua(int a, int b, ControlMapper.jg c)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				ControlMapper.js.jq jq = jn.fsw(b);
				if (jq == null)
				{
					return;
				}
				jq.ftm(c);
			}

			// Token: 0x06002233 RID: 8755 RVA: 0x00095601 File Offset: 0x00093801
			public void fut()
			{
				this.kbx.frq();
			}

			// Token: 0x06002234 RID: 8756 RVA: 0x0009530A File Offset: 0x0009350A
			public void mia(int a)
			{
				if (a < 0)
				{
					return;
				}
				if (this.kbx.frp(a))
				{
					return;
				}
				this.kbx.Add(a, new ControlMapper.js.jn());
			}

			// Token: 0x06002235 RID: 8757 RVA: 0x00095610 File Offset: 0x00093810
			private ControlMapper.js.jq iuo(int a, int b)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return null;
				}
				return jn.fsx(b);
			}

			// Token: 0x06002236 RID: 8758 RVA: 0x00095638 File Offset: 0x00093838
			public void ncd(int a)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				List<ControlMapper.js.jo> list = jn.lyr;
				int num = ((list != null) ? list.Count : 0);
				for (int i = 0; i < num; i++)
				{
					list[i].fti();
				}
			}

			// Token: 0x06002237 RID: 8759 RVA: 0x00095684 File Offset: 0x00093884
			public void ijr(int a, bool b)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				List<ControlMapper.js.jo> list = jn.lyr;
				int num = ((list != null) ? list.Count : 0);
				for (int i = 0; i < num; i++)
				{
					list[i].ftl(b);
				}
			}

			// Token: 0x06002238 RID: 8760 RVA: 0x000951E2 File Offset: 0x000933E2
			public bool kqy(int a, int b, AxisRange c)
			{
				return this.fui(a, b, c) != null;
			}

			// Token: 0x06002239 RID: 8761 RVA: 0x000956D0 File Offset: 0x000938D0
			public void ftx(int a, int b, AxisRange c, ControlMapper.jg d)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				ControlMapper.js.jo jo = jn.fss(b, c);
				if (jo == null)
				{
					return;
				}
				jo.fsz(d);
			}

			// Token: 0x0600223A RID: 8762 RVA: 0x000954CD File Offset: 0x000936CD
			public void ere(int a, InputAction b, AxisRange c)
			{
				this.ftw(a, b, c);
			}

			// Token: 0x0600223B RID: 8763 RVA: 0x00095703 File Offset: 0x00093903
			private ControlMapper.js.jo gij(int a, InputAction b, AxisRange c)
			{
				if (b == null)
				{
					return null;
				}
				return this.fui(a, b.id, c);
			}

			// Token: 0x0600223C RID: 8764 RVA: 0x000954CD File Offset: 0x000936CD
			public void mzq(int a, InputAction b, AxisRange c)
			{
				this.ftw(a, b, c);
			}

			// Token: 0x0600223D RID: 8765 RVA: 0x00095703 File Offset: 0x00093903
			private ControlMapper.js.jo kdf(int a, InputAction b, AxisRange c)
			{
				if (b == null)
				{
					return null;
				}
				return this.fui(a, b.id, c);
			}

			// Token: 0x0600223E RID: 8766 RVA: 0x00095718 File Offset: 0x00093918
			public void jdp()
			{
				for (int i = 0; i < this.kbx.lyq; i++)
				{
					this.kbx[i].fsy(false);
				}
			}

			// Token: 0x0600223F RID: 8767 RVA: 0x00095750 File Offset: 0x00093950
			public void nyd(int a, InputAction b, AxisRange c, ControllerType d, int e, ControlMapper.jd f)
			{
				ControlMapper.js.jo jo = this.fuj(a, b, c);
				if (jo == null)
				{
					return;
				}
				jo.ftc(d, e, f);
			}

			// Token: 0x06002240 RID: 8768 RVA: 0x000954CD File Offset: 0x000936CD
			public void fsb(int a, InputAction b, AxisRange c)
			{
				this.ftw(a, b, c);
			}

			// Token: 0x06002241 RID: 8769 RVA: 0x00095778 File Offset: 0x00093978
			public void izx(int a, int b, ControlMapper.jg c)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				ControlMapper.js.jq jq = jn.fsw(b);
				if (jq == null)
				{
					return;
				}
				jq.ftm(c);
			}

			// Token: 0x06002242 RID: 8770 RVA: 0x000957AC File Offset: 0x000939AC
			public void muh(int a)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				List<ControlMapper.js.jo> list = jn.lyr;
				int num = ((list != null) ? list.Count : 0);
				for (int i = 0; i < num; i++)
				{
					list[i].ftk();
				}
			}

			// Token: 0x06002243 RID: 8771 RVA: 0x000957F8 File Offset: 0x000939F8
			public void fuf(int a, float b)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				jn.lyt = b;
			}

			// Token: 0x06002244 RID: 8772 RVA: 0x00095820 File Offset: 0x00093A20
			public void cas(int a, InputAction b, AxisRange c, ControllerType d, int e, ControlMapper.jd f)
			{
				ControlMapper.js.jo jo = this.fuj(a, b, c);
				if (jo == null)
				{
					return;
				}
				jo.ftc(d, e, f);
			}

			// Token: 0x06002245 RID: 8773 RVA: 0x00095848 File Offset: 0x00093A48
			public void cza(int a, bool b)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				List<ControlMapper.js.jo> list = jn.lyr;
				int num = ((list != null) ? list.Count : 0);
				for (int i = 0; i < num; i++)
				{
					list[i].ftl(b);
				}
			}

			// Token: 0x06002246 RID: 8774 RVA: 0x00095894 File Offset: 0x00093A94
			public void fum(int a, int b, AxisRange c, ControllerType d, int e, string f)
			{
				ControlMapper.js.jo jo = this.fui(a, b, c);
				if (jo == null)
				{
					return;
				}
				jo.ftf(d, e, f);
			}

			// Token: 0x06002247 RID: 8775 RVA: 0x000954CD File Offset: 0x000936CD
			public void ftv(int a, InputAction b, AxisRange c)
			{
				this.ftw(a, b, c);
			}

			// Token: 0x06002248 RID: 8776 RVA: 0x000958BC File Offset: 0x00093ABC
			public void dkh(int a, int b, AxisRange c, ControllerType d, int e, string f)
			{
				ControlMapper.js.jo jo = this.fui(a, b, c);
				if (jo == null)
				{
					return;
				}
				jo.ftf(d, e, f);
			}

			// Token: 0x06002249 RID: 8777 RVA: 0x000958E4 File Offset: 0x00093AE4
			public void fus(int a)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				List<ControlMapper.js.jo> list = jn.lyr;
				int num = ((list != null) ? list.Count : 0);
				for (int i = 0; i < num; i++)
				{
					list[i].ftk();
				}
			}

			// Token: 0x0600224A RID: 8778 RVA: 0x000951E2 File Offset: 0x000933E2
			public bool nqz(int a, int b, AxisRange c)
			{
				return this.fui(a, b, c) != null;
			}

			// Token: 0x0600224B RID: 8779 RVA: 0x00095703 File Offset: 0x00093903
			private ControlMapper.js.jo fuj(int a, InputAction b, AxisRange c)
			{
				if (b == null)
				{
					return null;
				}
				return this.fui(a, b.id, c);
			}

			// Token: 0x0600224C RID: 8780 RVA: 0x00095930 File Offset: 0x00093B30
			public void fup(int a)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				List<ControlMapper.js.jo> list = jn.lyr;
				int num = ((list != null) ? list.Count : 0);
				for (int i = 0; i < num; i++)
				{
					list[i].fti();
				}
			}

			// Token: 0x0600224D RID: 8781 RVA: 0x0009597C File Offset: 0x00093B7C
			private ControlMapper.js.jq eah(int a, int b)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return null;
				}
				return jn.fsx(b);
			}

			// Token: 0x0600224E RID: 8782 RVA: 0x000955C5 File Offset: 0x000937C5
			public void omj(int a, int b)
			{
				this.ftz(a, b);
			}

			// Token: 0x0600224F RID: 8783 RVA: 0x000959A4 File Offset: 0x00093BA4
			private ControlMapper.js.jo khi(int a, int b, AxisRange c)
			{
				if (b < 0)
				{
					return null;
				}
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return null;
				}
				return jn.fss(b, c);
			}

			// Token: 0x06002250 RID: 8784 RVA: 0x000959D4 File Offset: 0x00093BD4
			public float fug(int a)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return 0f;
				}
				return jn.lyt;
			}

			// Token: 0x06002251 RID: 8785 RVA: 0x00095A00 File Offset: 0x00093C00
			public void cop(int a, InputAction b, AxisRange c, ControllerType d, int e, ControlMapper.jd f)
			{
				ControlMapper.js.jo jo = this.fuj(a, b, c);
				if (jo == null)
				{
					return;
				}
				jo.ftc(d, e, f);
			}

			// Token: 0x06002252 RID: 8786 RVA: 0x00095A28 File Offset: 0x00093C28
			public void vc(int a, int b, AxisRange c, ControlMapper.jg d)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				ControlMapper.js.jo jo = jn.fss(b, c);
				if (jo == null)
				{
					return;
				}
				jo.fsz(d);
			}

			// Token: 0x06002253 RID: 8787 RVA: 0x000955C5 File Offset: 0x000937C5
			public void fty(int a, int b)
			{
				this.ftz(a, b);
			}

			// Token: 0x06002254 RID: 8788 RVA: 0x00095A5C File Offset: 0x00093C5C
			public void cpw(int a, bool b)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				List<ControlMapper.js.jo> list = jn.lyr;
				int num = ((list != null) ? list.Count : 0);
				for (int i = 0; i < num; i++)
				{
					list[i].ftl(b);
				}
			}

			// Token: 0x06002255 RID: 8789 RVA: 0x00095AA8 File Offset: 0x00093CA8
			public void fur()
			{
				for (int i = 0; i < this.kbx.lyq; i++)
				{
					this.kbx[i].fsy(false);
				}
			}

			// Token: 0x06002256 RID: 8790 RVA: 0x00095AE0 File Offset: 0x00093CE0
			public void fub(int a, InputAction b, AxisRange c, ControllerType d, GameObject e)
			{
				ControlMapper.js.jo jo = this.fuj(a, b, c);
				if (jo == null)
				{
					return;
				}
				jo.ftb(d, e);
			}

			// Token: 0x06002257 RID: 8791 RVA: 0x00095B08 File Offset: 0x00093D08
			public void kdw()
			{
				for (int i = 0; i < this.kbx.lyq; i++)
				{
					this.kbx[i].fsy(false);
				}
			}

			// Token: 0x06002258 RID: 8792 RVA: 0x000951E2 File Offset: 0x000933E2
			public bool gmb(int a, int b, AxisRange c)
			{
				return this.fui(a, b, c) != null;
			}

			// Token: 0x06002259 RID: 8793 RVA: 0x00095703 File Offset: 0x00093903
			private ControlMapper.js.jo hvv(int a, InputAction b, AxisRange c)
			{
				if (b == null)
				{
					return null;
				}
				return this.fui(a, b.id, c);
			}

			// Token: 0x0600225A RID: 8794 RVA: 0x00095B40 File Offset: 0x00093D40
			public void lzf(int a)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				List<ControlMapper.js.jo> list = jn.lyr;
				int num = ((list != null) ? list.Count : 0);
				for (int i = 0; i < num; i++)
				{
					list[i].fti();
				}
			}

			// Token: 0x0600225B RID: 8795 RVA: 0x00095B8C File Offset: 0x00093D8C
			public void fuo(int a, int b, AxisRange c, ControllerType d, int e)
			{
				ControlMapper.js.jo jo = this.fui(a, b, c);
				if (jo == null)
				{
					return;
				}
				jo.fth(d, e);
			}

			// Token: 0x0600225C RID: 8796 RVA: 0x00095BB4 File Offset: 0x00093DB4
			public void efr(int a, InputAction b, AxisRange c, ControllerType d, GameObject e)
			{
				ControlMapper.js.jo jo = this.fuj(a, b, c);
				if (jo == null)
				{
					return;
				}
				jo.ftb(d, e);
			}

			// Token: 0x0600225D RID: 8797 RVA: 0x00095BDC File Offset: 0x00093DDC
			private ControlMapper.js.jq cli(int a, int b)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return null;
				}
				return jn.fsx(b);
			}

			// Token: 0x0600225E RID: 8798 RVA: 0x00095C04 File Offset: 0x00093E04
			public void odi(int a, bool b)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				List<ControlMapper.js.jo> list = jn.lyr;
				int num = ((list != null) ? list.Count : 0);
				for (int i = 0; i < num; i++)
				{
					list[i].ftl(b);
				}
			}

			// Token: 0x0600225F RID: 8799 RVA: 0x00095C50 File Offset: 0x00093E50
			public void cot(int a)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				jn.fsy(true);
			}

			// Token: 0x06002260 RID: 8800 RVA: 0x00095C78 File Offset: 0x00093E78
			public void mxq(int a, InputAction b, AxisRange c, ControllerType d, int e, ControlMapper.jd f)
			{
				ControlMapper.js.jo jo = this.fuj(a, b, c);
				if (jo == null)
				{
					return;
				}
				jo.ftc(d, e, f);
			}

			// Token: 0x06002261 RID: 8801 RVA: 0x00095CA0 File Offset: 0x00093EA0
			public void oak(int a, InputAction b, AxisRange c, ControllerType d, GameObject e)
			{
				ControlMapper.js.jo jo = this.fuj(a, b, c);
				if (jo == null)
				{
					return;
				}
				jo.ftb(d, e);
			}

			// Token: 0x06002262 RID: 8802 RVA: 0x00095CC8 File Offset: 0x00093EC8
			public void mjs(int a)
			{
				ControlMapper.js.jn jn;
				if (!this.kbx.frn(a, out jn))
				{
					return;
				}
				List<ControlMapper.js.jo> list = jn.lyr;
				int num = ((list != null) ? list.Count : 0);
				for (int i = 0; i < num; i++)
				{
					list[i].ftk();
				}
			}

			// Token: 0x040010E2 RID: 4322
			private ControlMapper.jl<int, ControlMapper.js.jn> kbx;

			// Token: 0x0200020F RID: 527
			private class jn
			{
				// Token: 0x06002263 RID: 8803 RVA: 0x00095D14 File Offset: 0x00093F14
				public int jhb(int a, AxisRange b)
				{
					int count = this.kbc.Count;
					for (int i = 0; i < count; i++)
					{
						if (this.kbc[i].fta(a, b))
						{
							return i;
						}
					}
					return -1;
				}

				// Token: 0x06002264 RID: 8804 RVA: 0x00095D51 File Offset: 0x00093F51
				public bool cvb(int a, AxisRange b)
				{
					return this.fst(a, b) >= 0;
				}

				// Token: 0x06002265 RID: 8805 RVA: 0x00095D51 File Offset: 0x00093F51
				public bool fsu(int a, AxisRange b)
				{
					return this.fst(a, b) >= 0;
				}

				// Token: 0x17000537 RID: 1335
				// (get) Token: 0x06002272 RID: 8818 RVA: 0x00095FB4 File Offset: 0x000941B4
				// (set) Token: 0x06002266 RID: 8806 RVA: 0x00095D61 File Offset: 0x00093F61
				public float lyt
				{
					get
					{
						return this.kbe;
					}
					set
					{
						this.kbe = value;
					}
				}

				// Token: 0x17000536 RID: 1334
				// (get) Token: 0x06002267 RID: 8807 RVA: 0x00095D6A File Offset: 0x00093F6A
				public ControlMapper.jl<int, ControlMapper.js.jq> lys
				{
					get
					{
						return this.kbd;
					}
				}

				// Token: 0x06002268 RID: 8808 RVA: 0x00095D74 File Offset: 0x00093F74
				public ControlMapper.js.jo hoe(InputAction a, AxisRange b)
				{
					if (a == null)
					{
						return null;
					}
					if (this.fsu(a.id, b))
					{
						return null;
					}
					this.kbc.Add(new ControlMapper.js.jo(a, b));
					return this.kbc[this.kbc.Count - 1];
				}

				// Token: 0x06002269 RID: 8809 RVA: 0x00095D51 File Offset: 0x00093F51
				public bool kfg(int a, AxisRange b)
				{
					return this.fst(a, b) >= 0;
				}

				// Token: 0x0600226A RID: 8810 RVA: 0x00095DC1 File Offset: 0x00093FC1
				public ControlMapper.js.jq jld(int a)
				{
					if (a < 0)
					{
						return null;
					}
					if (this.kbd.frp(a))
					{
						return null;
					}
					this.kbd.Add(a, new ControlMapper.js.jq(a));
					return this.kbd.frm(a);
				}

				// Token: 0x0600226B RID: 8811 RVA: 0x00095DF8 File Offset: 0x00093FF8
				public ControlMapper.js.jo fsv(InputAction a, AxisRange b)
				{
					if (a == null)
					{
						return null;
					}
					if (this.fsu(a.id, b))
					{
						return null;
					}
					this.kbc.Add(new ControlMapper.js.jo(a, b));
					return this.kbc[this.kbc.Count - 1];
				}

				// Token: 0x0600226C RID: 8812 RVA: 0x00095E45 File Offset: 0x00094045
				public ControlMapper.js.jq ckx(int a)
				{
					if (!this.kbd.frp(a))
					{
						return null;
					}
					return this.kbd.frm(a);
				}

				// Token: 0x0600226D RID: 8813 RVA: 0x00095E64 File Offset: 0x00094064
				public void hrc(bool a)
				{
					for (int i = 0; i < this.kbd.lyq; i++)
					{
						this.kbd[i].ftn(a);
					}
					for (int j = 0; j < this.kbc.Count; j++)
					{
						this.kbc[j].ftj(a);
					}
				}

				// Token: 0x0600226E RID: 8814 RVA: 0x00095EC4 File Offset: 0x000940C4
				public void fsy(bool a)
				{
					for (int i = 0; i < this.kbd.lyq; i++)
					{
						this.kbd[i].ftn(a);
					}
					for (int j = 0; j < this.kbc.Count; j++)
					{
						this.kbc[j].ftj(a);
					}
				}

				// Token: 0x0600226F RID: 8815 RVA: 0x00095F24 File Offset: 0x00094124
				public int fst(int a, AxisRange b)
				{
					int count = this.kbc.Count;
					for (int i = 0; i < count; i++)
					{
						if (this.kbc[i].fta(a, b))
						{
							return i;
						}
					}
					return -1;
				}

				// Token: 0x06002270 RID: 8816 RVA: 0x00095F64 File Offset: 0x00094164
				public ControlMapper.js.jo lyh(int a, AxisRange b)
				{
					int num = this.fst(a, b);
					if (num < 0)
					{
						return null;
					}
					return this.kbc[num];
				}

				// Token: 0x06002271 RID: 8817 RVA: 0x00095F8C File Offset: 0x0009418C
				public ControlMapper.js.jo gpu(int a, AxisRange b)
				{
					int num = this.fst(a, b);
					if (num < 0)
					{
						return null;
					}
					return this.kbc[num];
				}

				// Token: 0x06002273 RID: 8819 RVA: 0x00095FBC File Offset: 0x000941BC
				public ControlMapper.js.jo fss(int a, AxisRange b)
				{
					int num = this.fst(a, b);
					if (num < 0)
					{
						return null;
					}
					return this.kbc[num];
				}

				// Token: 0x17000535 RID: 1333
				// (get) Token: 0x06002274 RID: 8820 RVA: 0x00095FE4 File Offset: 0x000941E4
				public List<ControlMapper.js.jo> lyr
				{
					get
					{
						return this.kbc;
					}
				}

				// Token: 0x06002275 RID: 8821 RVA: 0x00095FEC File Offset: 0x000941EC
				public jn()
				{
					this.kbc = new List<ControlMapper.js.jo>();
					this.kbd = new ControlMapper.jl<int, ControlMapper.js.jq>();
				}

				// Token: 0x06002276 RID: 8822 RVA: 0x0009600C File Offset: 0x0009420C
				public ControlMapper.js.jo dvi(int a, AxisRange b)
				{
					int num = this.fst(a, b);
					if (num < 0)
					{
						return null;
					}
					return this.kbc[num];
				}

				// Token: 0x06002277 RID: 8823 RVA: 0x00096034 File Offset: 0x00094234
				public ControlMapper.js.jo njx(int a, AxisRange b)
				{
					int num = this.fst(a, b);
					if (num < 0)
					{
						return null;
					}
					return this.kbc[num];
				}

				// Token: 0x06002278 RID: 8824 RVA: 0x0009605C File Offset: 0x0009425C
				public void iju(bool a)
				{
					for (int i = 0; i < this.kbd.lyq; i++)
					{
						this.kbd[i].ftn(a);
					}
					for (int j = 0; j < this.kbc.Count; j++)
					{
						this.kbc[j].ftj(a);
					}
				}

				// Token: 0x06002279 RID: 8825 RVA: 0x00095DC1 File Offset: 0x00093FC1
				public ControlMapper.js.jq fsx(int a)
				{
					if (a < 0)
					{
						return null;
					}
					if (this.kbd.frp(a))
					{
						return null;
					}
					this.kbd.Add(a, new ControlMapper.js.jq(a));
					return this.kbd.frm(a);
				}

				// Token: 0x0600227A RID: 8826 RVA: 0x00095E45 File Offset: 0x00094045
				public ControlMapper.js.jq fsw(int a)
				{
					if (!this.kbd.frp(a))
					{
						return null;
					}
					return this.kbd.frm(a);
				}

				// Token: 0x040010E3 RID: 4323
				private List<ControlMapper.js.jo> kbc;

				// Token: 0x040010E4 RID: 4324
				private ControlMapper.jl<int, ControlMapper.js.jq> kbd;

				// Token: 0x040010E5 RID: 4325
				private float kbe;
			}

			// Token: 0x02000210 RID: 528
			private class jo
			{
				// Token: 0x0600227B RID: 8827 RVA: 0x000960B9 File Offset: 0x000942B9
				public jo(InputAction a, AxisRange b)
				{
					this.kbh = a;
					this.kbi = b;
					this.kbj = new ControlMapper.jh(a.id, b);
					this.kbf = new ControlMapper.jl<int, ControlMapper.js.jp>();
				}

				// Token: 0x0600227C RID: 8828 RVA: 0x000960EC File Offset: 0x000942EC
				public void ftk()
				{
					for (int i = 0; i < this.kbf.lyq; i++)
					{
						ControlMapper.js.jp jp = this.kbf[i];
						int num = jp.kbl.lyq;
						for (int j = 0; j < num; j++)
						{
							jp.kbl[j].fln(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.tk());
						}
					}
				}

				// Token: 0x0600227D RID: 8829 RVA: 0x0009614C File Offset: 0x0009434C
				public void bkz(bool a)
				{
					if (this.kbg != null)
					{
						this.kbg.fng(a);
					}
					int num = this.kbf.lyq;
					for (int i = 0; i < num; i++)
					{
						this.kbf[i].kbk.SetActive(a);
					}
				}

				// Token: 0x0600227E RID: 8830 RVA: 0x0009619C File Offset: 0x0009439C
				public void cuu(ControllerType a, GameObject b)
				{
					if (this.kbf.frp((int)a))
					{
						return;
					}
					this.kbf.Add((int)a, new ControlMapper.js.jp(b));
				}

				// Token: 0x0600227F RID: 8831 RVA: 0x0009619C File Offset: 0x0009439C
				public void jkz(ControllerType a, GameObject b)
				{
					if (this.kbf.frp((int)a))
					{
						return;
					}
					this.kbf.Add((int)a, new ControlMapper.js.jp(b));
				}

				// Token: 0x06002280 RID: 8832 RVA: 0x000961C0 File Offset: 0x000943C0
				public void ftj(bool a)
				{
					if (this.kbg != null)
					{
						this.kbg.fng(a);
					}
					int num = this.kbf.lyq;
					for (int i = 0; i < num; i++)
					{
						this.kbf[i].kbk.SetActive(a);
					}
				}

				// Token: 0x06002281 RID: 8833 RVA: 0x00096210 File Offset: 0x00094410
				public void ihm(ControllerType a, int b, ControlMapper.jd c)
				{
					if (!this.kbf.frp((int)a))
					{
						return;
					}
					ControlMapper.js.jp jp = this.kbf.frm((int)a);
					if (jp.kbl.frp(b))
					{
						return;
					}
					jp.kbl.Add(b, c);
				}

				// Token: 0x06002282 RID: 8834 RVA: 0x00096258 File Offset: 0x00094458
				public void nkn(ControllerType a, int b, int c, int d, string e, bool f)
				{
					if (!this.kbf.frp((int)a))
					{
						return;
					}
					if (!this.kbf.frm((int)a).kbl.frp(c))
					{
						return;
					}
					ControlMapper.jd jd = this.kbf.frm((int)a).kbl.frm(c);
					jd.fln(e);
					jd.lvy = d;
					jd.lvz = b;
					if (jd.lvx)
					{
						jd.jzr.flj(true, false);
						jd.jzr.fmt(f);
						jd.jzr.lwc = d;
					}
				}

				// Token: 0x06002283 RID: 8835 RVA: 0x000962EC File Offset: 0x000944EC
				public void fti()
				{
					for (int i = 0; i < this.kbf.lyq; i++)
					{
						ControlMapper.js.jp jp = this.kbf[i];
						int num = jp.kbl.lyq;
						for (int j = 0; j < num; j++)
						{
							ControlMapper.jd jd = jp.kbl[j];
							if (jd.lvx)
							{
								jd.jzr.flj(false, false);
								jd.jzr.fmt(false);
								jd.jzr.lwc = -1;
							}
							jd.fln(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.tk());
							jd.lvy = -1;
							jd.lvz = -1;
						}
					}
				}

				// Token: 0x06002284 RID: 8836 RVA: 0x00096395 File Offset: 0x00094595
				public bool lgu(int a, AxisRange b)
				{
					return this.kbh.id == a && this.kbi == b;
				}

				// Token: 0x06002285 RID: 8837 RVA: 0x000963B4 File Offset: 0x000945B4
				public ControlMapper.jd ftd(ControllerType a, int b)
				{
					if (!this.kbf.frp((int)a))
					{
						return null;
					}
					if (!this.kbf.frm((int)a).kbl.frp(b))
					{
						return null;
					}
					return this.kbf.frm((int)a).kbl.frm(b);
				}

				// Token: 0x06002286 RID: 8838 RVA: 0x00096403 File Offset: 0x00094603
				public bool iwt(ControllerType a, int b)
				{
					return this.kbf.frp((int)a) && this.kbf.frm((int)a).kbl.frp(b);
				}

				// Token: 0x06002287 RID: 8839 RVA: 0x00096434 File Offset: 0x00094634
				public void ftl(bool a)
				{
					for (int i = 0; i < this.kbf.lyq; i++)
					{
						ControlMapper.js.jp jp = this.kbf[i];
						int num = jp.kbl.lyq;
						for (int j = 0; j < num; j++)
						{
							ControlMapper.jd jd = jp.kbl[j];
							jd.flj(a, false);
							if (jd.lvx && (!a || jd.jzr.lwc >= 0))
							{
								jd.jzr.flj(a, false);
							}
						}
					}
				}

				// Token: 0x06002288 RID: 8840 RVA: 0x000964BC File Offset: 0x000946BC
				public void ftf(ControllerType a, int b, string c)
				{
					if (!this.kbf.frp((int)a))
					{
						return;
					}
					if (!this.kbf.frm((int)a).kbl.frp(b))
					{
						return;
					}
					this.kbf.frm((int)a).kbl.frm(b).fln(c);
				}

				// Token: 0x06002289 RID: 8841 RVA: 0x00096510 File Offset: 0x00094710
				public void nib(bool a)
				{
					if (this.kbg != null)
					{
						this.kbg.fng(a);
					}
					int num = this.kbf.lyq;
					for (int i = 0; i < num; i++)
					{
						this.kbf[i].kbk.SetActive(a);
					}
				}

				// Token: 0x0600228A RID: 8842 RVA: 0x00096395 File Offset: 0x00094595
				public bool mpc(int a, AxisRange b)
				{
					return this.kbh.id == a && this.kbi == b;
				}

				// Token: 0x0600228B RID: 8843 RVA: 0x00096560 File Offset: 0x00094760
				public void fam(ControlMapper.jg a)
				{
					this.kbg = a;
				}

				// Token: 0x0600228C RID: 8844 RVA: 0x0009656C File Offset: 0x0009476C
				public void fth(ControllerType a, int b)
				{
					if (!this.kbf.frp((int)a))
					{
						return;
					}
					ControlMapper.js.jp jp = this.kbf.frm((int)a);
					int num = jp.kbl.lyq;
					for (int i = 0; i < num; i++)
					{
						jp.kbl[i].lvz = b;
					}
				}

				// Token: 0x0600228D RID: 8845 RVA: 0x00096395 File Offset: 0x00094595
				public bool ekw(int a, AxisRange b)
				{
					return this.kbh.id == a && this.kbi == b;
				}

				// Token: 0x0600228E RID: 8846 RVA: 0x000965C0 File Offset: 0x000947C0
				public void ftc(ControllerType a, int b, ControlMapper.jd c)
				{
					if (!this.kbf.frp((int)a))
					{
						return;
					}
					ControlMapper.js.jp jp = this.kbf.frm((int)a);
					if (jp.kbl.frp(b))
					{
						return;
					}
					jp.kbl.Add(b, c);
				}

				// Token: 0x0600228F RID: 8847 RVA: 0x00096560 File Offset: 0x00094760
				public void wi(ControlMapper.jg a)
				{
					this.kbg = a;
				}

				// Token: 0x06002290 RID: 8848 RVA: 0x00096403 File Offset: 0x00094603
				public bool fte(ControllerType a, int b)
				{
					return this.kbf.frp((int)a) && this.kbf.frm((int)a).kbl.frp(b);
				}

				// Token: 0x06002291 RID: 8849 RVA: 0x00096403 File Offset: 0x00094603
				public bool lyx(ControllerType a, int b)
				{
					return this.kbf.frp((int)a) && this.kbf.frm((int)a).kbl.frp(b);
				}

				// Token: 0x06002292 RID: 8850 RVA: 0x00096608 File Offset: 0x00094808
				public void mxl()
				{
					for (int i = 0; i < this.kbf.lyq; i++)
					{
						ControlMapper.js.jp jp = this.kbf[i];
						int num = jp.kbl.lyq;
						for (int j = 0; j < num; j++)
						{
							ControlMapper.jd jd = jp.kbl[j];
							if (jd.lvx)
							{
								jd.jzr.flj(false, false);
								jd.jzr.fmt(false);
								jd.jzr.lwc = -1;
							}
							jd.fln(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.ete());
							jd.lvy = -1;
							jd.lvz = -1;
						}
					}
				}

				// Token: 0x06002293 RID: 8851 RVA: 0x0009619C File Offset: 0x0009439C
				public void ftb(ControllerType a, GameObject b)
				{
					if (this.kbf.frp((int)a))
					{
						return;
					}
					this.kbf.Add((int)a, new ControlMapper.js.jp(b));
				}

				// Token: 0x06002294 RID: 8852 RVA: 0x00096560 File Offset: 0x00094760
				public void r(ControlMapper.jg a)
				{
					this.kbg = a;
				}

				// Token: 0x06002295 RID: 8853 RVA: 0x000966B4 File Offset: 0x000948B4
				public void hob(bool a)
				{
					if (this.kbg != null)
					{
						this.kbg.fng(a);
					}
					int num = this.kbf.lyq;
					for (int i = 0; i < num; i++)
					{
						this.kbf[i].kbk.SetActive(a);
					}
				}

				// Token: 0x06002296 RID: 8854 RVA: 0x00096560 File Offset: 0x00094760
				public void fsz(ControlMapper.jg a)
				{
					this.kbg = a;
				}

				// Token: 0x06002297 RID: 8855 RVA: 0x00096704 File Offset: 0x00094904
				public void jut(ControllerType a, int b, string c)
				{
					if (!this.kbf.frp((int)a))
					{
						return;
					}
					if (!this.kbf.frm((int)a).kbl.frp(b))
					{
						return;
					}
					this.kbf.frm((int)a).kbl.frm(b).fln(c);
				}

				// Token: 0x06002298 RID: 8856 RVA: 0x00096395 File Offset: 0x00094595
				public bool fwx(int a, AxisRange b)
				{
					return this.kbh.id == a && this.kbi == b;
				}

				// Token: 0x06002299 RID: 8857 RVA: 0x00096758 File Offset: 0x00094958
				public void ekx(bool a)
				{
					if (this.kbg != null)
					{
						this.kbg.fng(a);
					}
					int num = this.kbf.lyq;
					for (int i = 0; i < num; i++)
					{
						this.kbf[i].kbk.SetActive(a);
					}
				}

				// Token: 0x0600229A RID: 8858 RVA: 0x00096395 File Offset: 0x00094595
				public bool fta(int a, AxisRange b)
				{
					return this.kbh.id == a && this.kbi == b;
				}

				// Token: 0x0600229B RID: 8859 RVA: 0x00096560 File Offset: 0x00094760
				public void bru(ControlMapper.jg a)
				{
					this.kbg = a;
				}

				// Token: 0x0600229C RID: 8860 RVA: 0x000967A8 File Offset: 0x000949A8
				public void ckw()
				{
					for (int i = 0; i < this.kbf.lyq; i++)
					{
						ControlMapper.js.jp jp = this.kbf[i];
						int num = jp.kbl.lyq;
						for (int j = 0; j < num; j++)
						{
							ControlMapper.jd jd = jp.kbl[j];
							if (jd.lvx)
							{
								jd.jzr.flj(false, false);
								jd.jzr.fmt(false);
								jd.jzr.lwc = -1;
							}
							jd.fln(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.etf());
							jd.lvy = -1;
							jd.lvz = -1;
						}
					}
				}

				// Token: 0x0600229D RID: 8861 RVA: 0x00096854 File Offset: 0x00094A54
				public void hlh()
				{
					for (int i = 0; i < this.kbf.lyq; i++)
					{
						ControlMapper.js.jp jp = this.kbf[i];
						int num = jp.kbl.lyq;
						for (int j = 0; j < num; j++)
						{
							ControlMapper.jd jd = jp.kbl[j];
							if (jd.lvx)
							{
								jd.jzr.flj(false, false);
								jd.jzr.fmt(false);
								jd.jzr.lwc = -1;
							}
							jd.fln(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.etg());
							jd.lvy = -1;
							jd.lvz = -1;
						}
					}
				}

				// Token: 0x0600229E RID: 8862 RVA: 0x00096900 File Offset: 0x00094B00
				public void frm()
				{
					for (int i = 0; i < this.kbf.lyq; i++)
					{
						ControlMapper.js.jp jp = this.kbf[i];
						int num = jp.kbl.lyq;
						for (int j = 0; j < num; j++)
						{
							ControlMapper.jd jd = jp.kbl[j];
							if (jd.lvx)
							{
								jd.jzr.flj(false, false);
								jd.jzr.fmt(false);
								jd.jzr.lwc = -1;
							}
							jd.fln(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eth());
							jd.lvy = -1;
							jd.lvz = -1;
						}
					}
				}

				// Token: 0x0600229F RID: 8863 RVA: 0x000969AC File Offset: 0x00094BAC
				public void dnu(ControllerType a, int b)
				{
					if (!this.kbf.frp((int)a))
					{
						return;
					}
					ControlMapper.js.jp jp = this.kbf.frm((int)a);
					int num = jp.kbl.lyq;
					for (int i = 0; i < num; i++)
					{
						jp.kbl[i].lvz = b;
					}
				}

				// Token: 0x060022A0 RID: 8864 RVA: 0x00096A00 File Offset: 0x00094C00
				public void njc(ControllerType a, int b)
				{
					if (!this.kbf.frp((int)a))
					{
						return;
					}
					ControlMapper.js.jp jp = this.kbf.frm((int)a);
					int num = jp.kbl.lyq;
					for (int i = 0; i < num; i++)
					{
						jp.kbl[i].lvz = b;
					}
				}

				// Token: 0x060022A1 RID: 8865 RVA: 0x00096A54 File Offset: 0x00094C54
				public void ftg(ControllerType a, int b, int c, int d, string e, bool f)
				{
					if (!this.kbf.frp((int)a))
					{
						return;
					}
					if (!this.kbf.frm((int)a).kbl.frp(c))
					{
						return;
					}
					ControlMapper.jd jd = this.kbf.frm((int)a).kbl.frm(c);
					jd.fln(e);
					jd.lvy = d;
					jd.lvz = b;
					if (jd.lvx)
					{
						jd.jzr.flj(true, false);
						jd.jzr.fmt(f);
						jd.jzr.lwc = d;
					}
				}

				// Token: 0x060022A2 RID: 8866 RVA: 0x0009619C File Offset: 0x0009439C
				public void ifd(ControllerType a, GameObject b)
				{
					if (this.kbf.frp((int)a))
					{
						return;
					}
					this.kbf.Add((int)a, new ControlMapper.js.jp(b));
				}

				// Token: 0x060022A3 RID: 8867 RVA: 0x00096AE8 File Offset: 0x00094CE8
				public void sb(ControllerType a, int b)
				{
					if (!this.kbf.frp((int)a))
					{
						return;
					}
					ControlMapper.js.jp jp = this.kbf.frm((int)a);
					int num = jp.kbl.lyq;
					for (int i = 0; i < num; i++)
					{
						jp.kbl[i].lvz = b;
					}
				}

				// Token: 0x040010E6 RID: 4326
				private ControlMapper.jl<int, ControlMapper.js.jp> kbf;

				// Token: 0x040010E7 RID: 4327
				public ControlMapper.jg kbg;

				// Token: 0x040010E8 RID: 4328
				public readonly InputAction kbh;

				// Token: 0x040010E9 RID: 4329
				public readonly AxisRange kbi;

				// Token: 0x040010EA RID: 4330
				public readonly ControlMapper.jh kbj;
			}

			// Token: 0x02000211 RID: 529
			private class jp
			{
				// Token: 0x060022A4 RID: 8868 RVA: 0x00096B3B File Offset: 0x00094D3B
				public jp(GameObject a)
				{
					this.kbk = a;
					this.kbl = new ControlMapper.jl<int, ControlMapper.jd>();
				}

				// Token: 0x040010EB RID: 4331
				public readonly GameObject kbk;

				// Token: 0x040010EC RID: 4332
				public readonly ControlMapper.jl<int, ControlMapper.jd> kbl;
			}

			// Token: 0x02000212 RID: 530
			private class jq
			{
				// Token: 0x060022A5 RID: 8869 RVA: 0x00096B55 File Offset: 0x00094D55
				public jq(int a)
				{
					this.kbm = a;
				}

				// Token: 0x060022A6 RID: 8870 RVA: 0x00096B64 File Offset: 0x00094D64
				public void ftn(bool a)
				{
					if (this.kbn != null)
					{
						this.kbn.fng(a);
					}
				}

				// Token: 0x060022A7 RID: 8871 RVA: 0x00096B7A File Offset: 0x00094D7A
				public void @if(ControlMapper.jg a)
				{
					this.kbn = a;
				}

				// Token: 0x060022A8 RID: 8872 RVA: 0x00096B7A File Offset: 0x00094D7A
				public void gkz(ControlMapper.jg a)
				{
					this.kbn = a;
				}

				// Token: 0x060022A9 RID: 8873 RVA: 0x00096B7A File Offset: 0x00094D7A
				public void ftm(ControlMapper.jg a)
				{
					this.kbn = a;
				}

				// Token: 0x060022AA RID: 8874 RVA: 0x00096B7A File Offset: 0x00094D7A
				public void gzb(ControlMapper.jg a)
				{
					this.kbn = a;
				}

				// Token: 0x060022AB RID: 8875 RVA: 0x00096B7A File Offset: 0x00094D7A
				public void gol(ControlMapper.jg a)
				{
					this.kbn = a;
				}

				// Token: 0x040010ED RID: 4333
				public readonly int kbm;

				// Token: 0x040010EE RID: 4334
				public ControlMapper.jg kbn;
			}
		}

		// Token: 0x02000214 RID: 532
		private class jt
		{
			// Token: 0x1700053A RID: 1338
			// (get) Token: 0x060022B4 RID: 8884 RVA: 0x00096CC4 File Offset: 0x00094EC4
			public bool lyw
			{
				get
				{
					for (int i = this.kby.Count - 1; i >= 0; i--)
					{
						if (!(this.kby[i] == null))
						{
							return true;
						}
					}
					return false;
				}
			}

			// Token: 0x060022B5 RID: 8885 RVA: 0x00096D00 File Offset: 0x00094F00
			private void ium(int a)
			{
				if (a < 0)
				{
					return;
				}
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (!(this.kby[i] == null) && this.kby[i].mgf != a)
					{
						this.kby[i].gte();
					}
				}
			}

			// Token: 0x060022B6 RID: 8886 RVA: 0x00096D64 File Offset: 0x00094F64
			public void nng(Window a)
			{
				if (a == null)
				{
					return;
				}
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (this.kby[i] == null)
					{
						this.kby.RemoveAt(i);
					}
					else if (!(this.kby[i] != a))
					{
						this.fvn(this.kby[i]);
						this.kby.RemoveAt(i);
						break;
					}
				}
				this.fvi();
				this.fvj();
			}

			// Token: 0x060022B7 RID: 8887 RVA: 0x00096DF5 File Offset: 0x00094FF5
			private void nel(Window a)
			{
				if (a == null)
				{
					return;
				}
				global::UnityEngine.Object.Destroy(a.gameObject);
			}

			// Token: 0x060022B8 RID: 8888 RVA: 0x00096E0C File Offset: 0x0009500C
			public void ltx()
			{
				this.fvk(false);
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (this.kby[i] == null)
					{
						this.kby.RemoveAt(i);
					}
					else
					{
						this.fvn(this.kby[i]);
						this.kby.RemoveAt(i);
					}
				}
				this.fvi();
			}

			// Token: 0x060022B9 RID: 8889 RVA: 0x00096E7E File Offset: 0x0009507E
			private void xy(bool a)
			{
				this.kcb.SetActive(a);
			}

			// Token: 0x060022BA RID: 8890 RVA: 0x00096E8C File Offset: 0x0009508C
			private Window fvs(string a, int b, int c)
			{
				if (string.IsNullOrEmpty(a))
				{
					a = global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eti();
				}
				GameObject gameObject = kq.grj<Window>(this.kbz, this.kca, a);
				if (gameObject == null)
				{
					return null;
				}
				Window component = gameObject.GetComponent<Window>();
				if (component != null)
				{
					component.fkn(this.fvo(), new Func<int, bool>(this.fve));
					this.kby.Add(component);
					component.gsp(b, c);
				}
				return component;
			}

			// Token: 0x060022BB RID: 8891 RVA: 0x00096F08 File Offset: 0x00095108
			public void fvb()
			{
				this.fvk(false);
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (this.kby[i] == null)
					{
						this.kby.RemoveAt(i);
					}
					else
					{
						this.fvn(this.kby[i]);
						this.kby.RemoveAt(i);
					}
				}
				this.fvi();
			}

			// Token: 0x060022BC RID: 8892 RVA: 0x00096F7A File Offset: 0x0009517A
			public void kiu()
			{
				this.fvb();
				if (this.kcb != null)
				{
					global::UnityEngine.Object.Destroy(this.kcb);
				}
			}

			// Token: 0x060022BD RID: 8893 RVA: 0x00096F9B File Offset: 0x0009519B
			public Window olz(GameObject a, string b)
			{
				if (a == null)
				{
					Debug.LogError(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.etj());
					return null;
				}
				Window window = this.fvm(b, a);
				this.fvi();
				return window;
			}

			// Token: 0x060022BE RID: 8894 RVA: 0x00096FC0 File Offset: 0x000951C0
			private void nnx(int a)
			{
				if (a < 0)
				{
					return;
				}
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (!(this.kby[i] == null) && this.kby[i].mgf != a)
					{
						this.kby[i].gte();
					}
				}
			}

			// Token: 0x1700053B RID: 1339
			// (get) Token: 0x060022BF RID: 8895 RVA: 0x00097024 File Offset: 0x00095224
			public Window lyx
			{
				get
				{
					for (int i = this.kby.Count - 1; i >= 0; i--)
					{
						if (!(this.kby[i] == null))
						{
							return this.kby[i];
						}
					}
					return null;
				}
			}

			// Token: 0x060022C0 RID: 8896 RVA: 0x0009706B File Offset: 0x0009526B
			public void fvf(int a)
			{
				this.fvg(this.fvd(a));
			}

			// Token: 0x060022C1 RID: 8897 RVA: 0x0009707C File Offset: 0x0009527C
			public void lpe()
			{
				this.fvk(false);
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (this.kby[i] == null)
					{
						this.kby.RemoveAt(i);
					}
					else
					{
						this.fvn(this.kby[i]);
						this.kby.RemoveAt(i);
					}
				}
				this.fvi();
			}

			// Token: 0x060022C2 RID: 8898 RVA: 0x000970F0 File Offset: 0x000952F0
			private Window th(string a, GameObject b)
			{
				if (string.IsNullOrEmpty(a))
				{
					a = global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.etk();
				}
				if (b == null)
				{
					return null;
				}
				GameObject gameObject = kq.grj<Window>(b, this.kca, a);
				if (gameObject == null)
				{
					return null;
				}
				Window component = gameObject.GetComponent<Window>();
				if (component != null)
				{
					component.fkn(this.fvo(), new Func<int, bool>(this.fve));
					this.kby.Add(component);
				}
				return component;
			}

			// Token: 0x060022C3 RID: 8899 RVA: 0x00097167 File Offset: 0x00095367
			private void fvj()
			{
				if (this.lyx == null)
				{
					return;
				}
				this.lyx.fky();
			}

			// Token: 0x060022C4 RID: 8900 RVA: 0x00097183 File Offset: 0x00095383
			public void dcm(Window a)
			{
				if (a == null)
				{
					return;
				}
				a.fky();
				this.fvh(a.mgf);
			}

			// Token: 0x060022C5 RID: 8901 RVA: 0x000971A1 File Offset: 0x000953A1
			public Window fsx(GameObject a, string b)
			{
				if (a == null)
				{
					Debug.LogError(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.etl());
					return null;
				}
				Window window = this.fvm(b, a);
				this.fvi();
				return window;
			}

			// Token: 0x060022C6 RID: 8902 RVA: 0x000971C8 File Offset: 0x000953C8
			private Window fvl(string a, int b, int c)
			{
				if (string.IsNullOrEmpty(a))
				{
					a = global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.etm();
				}
				GameObject gameObject = kq.grj<Window>(this.kbz, this.kca, a);
				if (gameObject == null)
				{
					return null;
				}
				Window component = gameObject.GetComponent<Window>();
				if (component != null)
				{
					component.fkn(this.fvo(), new Func<int, bool>(this.fve));
					this.kby.Add(component);
					component.gsp(b, c);
				}
				return component;
			}

			// Token: 0x060022C7 RID: 8903 RVA: 0x00097244 File Offset: 0x00095444
			private Window fvm(string a, GameObject b)
			{
				if (string.IsNullOrEmpty(a))
				{
					a = global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.etm();
				}
				if (b == null)
				{
					return null;
				}
				GameObject gameObject = kq.grj<Window>(b, this.kca, a);
				if (gameObject == null)
				{
					return null;
				}
				Window component = gameObject.GetComponent<Window>();
				if (component != null)
				{
					component.fkn(this.fvo(), new Func<int, bool>(this.fve));
					this.kby.Add(component);
				}
				return component;
			}

			// Token: 0x060022C8 RID: 8904 RVA: 0x000972BC File Offset: 0x000954BC
			public void mzj()
			{
				this.fvk(false);
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (this.kby[i] == null)
					{
						this.kby.RemoveAt(i);
					}
					else
					{
						this.fvn(this.kby[i]);
						this.kby.RemoveAt(i);
					}
				}
				this.fvi();
			}

			// Token: 0x060022C9 RID: 8905 RVA: 0x00097183 File Offset: 0x00095383
			public void dyf(Window a)
			{
				if (a == null)
				{
					return;
				}
				a.fky();
				this.fvh(a.mgf);
			}

			// Token: 0x060022CA RID: 8906 RVA: 0x00096F7A File Offset: 0x0009517A
			public void fvp()
			{
				this.fvb();
				if (this.kcb != null)
				{
					global::UnityEngine.Object.Destroy(this.kcb);
				}
			}

			// Token: 0x060022CB RID: 8907 RVA: 0x00097330 File Offset: 0x00095530
			private Window qn(string a, int b, int c)
			{
				if (string.IsNullOrEmpty(a))
				{
					a = global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.etn();
				}
				GameObject gameObject = kq.grj<Window>(this.kbz, this.kca, a);
				if (gameObject == null)
				{
					return null;
				}
				Window component = gameObject.GetComponent<Window>();
				if (component != null)
				{
					component.fkn(this.fvo(), new Func<int, bool>(this.fve));
					this.kby.Add(component);
					component.gsp(b, c);
				}
				return component;
			}

			// Token: 0x060022CC RID: 8908 RVA: 0x000973AC File Offset: 0x000955AC
			public Window kdn(int a)
			{
				if (a < 0)
				{
					return null;
				}
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (!(this.kby[i] == null) && this.kby[i].mgf == a)
					{
						return this.kby[i];
					}
				}
				return null;
			}

			// Token: 0x060022CD RID: 8909 RVA: 0x0009740D File Offset: 0x0009560D
			public void fuz(int a)
			{
				this.fva(this.fvd(a));
			}

			// Token: 0x060022CE RID: 8910 RVA: 0x0009741C File Offset: 0x0009561C
			private void fvh(int a)
			{
				if (a < 0)
				{
					return;
				}
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (!(this.kby[i] == null) && this.kby[i].mgf != a)
					{
						this.kby[i].gte();
					}
				}
			}

			// Token: 0x060022CF RID: 8911 RVA: 0x00097480 File Offset: 0x00095680
			public void yr()
			{
				if (!this.lyw)
				{
					return;
				}
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (!(this.kby[i] == null))
					{
						this.kby[i].Cancel();
					}
				}
				this.fvb();
			}

			// Token: 0x060022D0 RID: 8912 RVA: 0x000974DC File Offset: 0x000956DC
			private void joa(int a)
			{
				if (a < 0)
				{
					return;
				}
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (!(this.kby[i] == null) && this.kby[i].mgf != a)
					{
						this.kby[i].gte();
					}
				}
			}

			// Token: 0x060022D1 RID: 8913 RVA: 0x0009753F File Offset: 0x0009573F
			public Window fux(GameObject a, string b)
			{
				if (a == null)
				{
					Debug.LogError(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eto());
					return null;
				}
				Window window = this.fvm(b, a);
				this.fvi();
				return window;
			}

			// Token: 0x060022D2 RID: 8914 RVA: 0x00097564 File Offset: 0x00095764
			private int fvo()
			{
				int num = this.kcc;
				this.kcc++;
				return num;
			}

			// Token: 0x060022D3 RID: 8915 RVA: 0x0009757C File Offset: 0x0009577C
			private Window lhj(string a, int b, int c)
			{
				if (string.IsNullOrEmpty(a))
				{
					a = global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.etp();
				}
				GameObject gameObject = kq.grj<Window>(this.kbz, this.kca, a);
				if (gameObject == null)
				{
					return null;
				}
				Window component = gameObject.GetComponent<Window>();
				if (component != null)
				{
					component.fkn(this.fvo(), new Func<int, bool>(this.fve));
					this.kby.Add(component);
					component.gsp(b, c);
				}
				return component;
			}

			// Token: 0x060022D4 RID: 8916 RVA: 0x0009706B File Offset: 0x0009526B
			public void epv(int a)
			{
				this.fvg(this.fvd(a));
			}

			// Token: 0x060022D5 RID: 8917 RVA: 0x000975F8 File Offset: 0x000957F8
			public Window cph(int a)
			{
				if (a < 0)
				{
					return null;
				}
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (!(this.kby[i] == null) && this.kby[i].mgf == a)
					{
						return this.kby[i];
					}
				}
				return null;
			}

			// Token: 0x060022D6 RID: 8918 RVA: 0x00097659 File Offset: 0x00095859
			public Window gjv(GameObject a, string b)
			{
				if (a == null)
				{
					Debug.LogError(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.etq());
					return null;
				}
				Window window = this.fvm(b, a);
				this.fvi();
				return window;
			}

			// Token: 0x060022D7 RID: 8919 RVA: 0x00097680 File Offset: 0x00095880
			public void dqm()
			{
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (!(this.kby[i] == null))
					{
						this.fvn(this.kby[i]);
						this.kby.RemoveAt(i);
						break;
					}
					this.kby.RemoveAt(i);
				}
				this.fvi();
			}

			// Token: 0x060022D8 RID: 8920 RVA: 0x00096E7E File Offset: 0x0009507E
			private void oh(bool a)
			{
				this.kcb.SetActive(a);
			}

			// Token: 0x060022D9 RID: 8921 RVA: 0x000976ED File Offset: 0x000958ED
			public Window bdi(string a, int b, int c)
			{
				Window window = this.fvl(a, b, c);
				this.fvi();
				return window;
			}

			// Token: 0x060022DA RID: 8922 RVA: 0x00097700 File Offset: 0x00095900
			public void fvc()
			{
				if (!this.lyw)
				{
					return;
				}
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (!(this.kby[i] == null))
					{
						this.kby[i].Cancel();
					}
				}
				this.fvb();
			}

			// Token: 0x060022DB RID: 8923 RVA: 0x00097759 File Offset: 0x00095959
			public Window kep(GameObject a, string b)
			{
				if (a == null)
				{
					Debug.LogError(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.etr());
					return null;
				}
				Window window = this.fvm(b, a);
				this.fvi();
				return window;
			}

			// Token: 0x060022DC RID: 8924 RVA: 0x00097780 File Offset: 0x00095980
			public void za(Window a)
			{
				if (a == null)
				{
					return;
				}
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (this.kby[i] == null)
					{
						this.kby.RemoveAt(i);
					}
					else if (!(this.kby[i] != a))
					{
						this.fvn(this.kby[i]);
						this.kby.RemoveAt(i);
						break;
					}
				}
				this.fvi();
				this.fvj();
			}

			// Token: 0x060022DD RID: 8925 RVA: 0x00097814 File Offset: 0x00095A14
			public void fuy()
			{
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (!(this.kby[i] == null))
					{
						this.fvn(this.kby[i]);
						this.kby.RemoveAt(i);
						break;
					}
					this.kby.RemoveAt(i);
				}
				this.fvi();
			}

			// Token: 0x060022DE RID: 8926 RVA: 0x00097884 File Offset: 0x00095A84
			public Window fvd(int a)
			{
				if (a < 0)
				{
					return null;
				}
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (!(this.kby[i] == null) && this.kby[i].mgf == a)
					{
						return this.kby[i];
					}
				}
				return null;
			}

			// Token: 0x060022DF RID: 8927 RVA: 0x000978E8 File Offset: 0x00095AE8
			private void fvi()
			{
				if (!this.lyw)
				{
					this.fvk(false);
					return;
				}
				if (this.lyx.transform.parent == null)
				{
					return;
				}
				this.fvk(true);
				this.kcb.transform.SetAsLastSibling();
				int siblingIndex = this.lyx.transform.GetSiblingIndex();
				this.kcb.transform.SetSiblingIndex(siblingIndex);
			}

			// Token: 0x060022E0 RID: 8928 RVA: 0x00097958 File Offset: 0x00095B58
			public void igf()
			{
				this.fvk(false);
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (this.kby[i] == null)
					{
						this.kby.RemoveAt(i);
					}
					else
					{
						this.fvn(this.kby[i]);
						this.kby.RemoveAt(i);
					}
				}
				this.fvi();
			}

			// Token: 0x060022E1 RID: 8929 RVA: 0x000979CA File Offset: 0x00095BCA
			public bool fve(int a)
			{
				return a >= 0 && !(this.lyx == null) && this.lyx.mgf == a;
			}

			// Token: 0x060022E2 RID: 8930 RVA: 0x000979F0 File Offset: 0x00095BF0
			private void ciy(int a)
			{
				if (a < 0)
				{
					return;
				}
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (!(this.kby[i] == null) && this.kby[i].mgf != a)
					{
						this.kby[i].gte();
					}
				}
			}

			// Token: 0x060022E3 RID: 8931 RVA: 0x00097A54 File Offset: 0x00095C54
			public void div()
			{
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (!(this.kby[i] == null))
					{
						this.fvn(this.kby[i]);
						this.kby.RemoveAt(i);
						break;
					}
					this.kby.RemoveAt(i);
				}
				this.fvi();
			}

			// Token: 0x060022E4 RID: 8932 RVA: 0x00097AC4 File Offset: 0x00095CC4
			public Window kom(int a)
			{
				if (a < 0)
				{
					return null;
				}
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (!(this.kby[i] == null) && this.kby[i].mgf == a)
					{
						return this.kby[i];
					}
				}
				return null;
			}

			// Token: 0x060022E5 RID: 8933 RVA: 0x00097B28 File Offset: 0x00095D28
			public void fva(Window a)
			{
				if (a == null)
				{
					return;
				}
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (this.kby[i] == null)
					{
						this.kby.RemoveAt(i);
					}
					else if (!(this.kby[i] != a))
					{
						this.fvn(this.kby[i]);
						this.kby.RemoveAt(i);
						break;
					}
				}
				this.fvi();
				this.fvj();
			}

			// Token: 0x060022E6 RID: 8934 RVA: 0x00097BBC File Offset: 0x00095DBC
			public jt(GameObject a, GameObject b, Transform c)
			{
				this.kbz = a;
				this.kca = c;
				this.kby = new List<Window>();
				this.kcb = global::UnityEngine.Object.Instantiate<GameObject>(b);
				this.kcb.transform.SetParent(c, false);
				this.kcb.GetComponent<RectTransform>().localScale = Vector2.one;
				this.fvk(false);
			}

			// Token: 0x060022E7 RID: 8935 RVA: 0x00096E7E File Offset: 0x0009507E
			private void fvk(bool a)
			{
				this.kcb.SetActive(a);
			}

			// Token: 0x060022E8 RID: 8936 RVA: 0x00097C28 File Offset: 0x00095E28
			public void fbu()
			{
				for (int i = this.kby.Count - 1; i >= 0; i--)
				{
					if (!(this.kby[i] == null))
					{
						this.fvn(this.kby[i]);
						this.kby.RemoveAt(i);
						break;
					}
					this.kby.RemoveAt(i);
				}
				this.fvi();
			}

			// Token: 0x060022E9 RID: 8937 RVA: 0x000976ED File Offset: 0x000958ED
			public Window fuw(string a, int b, int c)
			{
				Window window = this.fvl(a, b, c);
				this.fvi();
				return window;
			}

			// Token: 0x060022EA RID: 8938 RVA: 0x00096DF5 File Offset: 0x00094FF5
			private void kyf(Window a)
			{
				if (a == null)
				{
					return;
				}
				global::UnityEngine.Object.Destroy(a.gameObject);
			}

			// Token: 0x060022EB RID: 8939 RVA: 0x00097183 File Offset: 0x00095383
			public void fvg(Window a)
			{
				if (a == null)
				{
					return;
				}
				a.fky();
				this.fvh(a.mgf);
			}

			// Token: 0x060022EC RID: 8940 RVA: 0x00096DF5 File Offset: 0x00094FF5
			private void fvn(Window a)
			{
				if (a == null)
				{
					return;
				}
				global::UnityEngine.Object.Destroy(a.gameObject);
			}

			// Token: 0x040010F8 RID: 4344
			private List<Window> kby;

			// Token: 0x040010F9 RID: 4345
			private GameObject kbz;

			// Token: 0x040010FA RID: 4346
			private Transform kca;

			// Token: 0x040010FB RID: 4347
			private GameObject kcb;

			// Token: 0x040010FC RID: 4348
			private int kcc;
		}

		// Token: 0x02000215 RID: 533
		[CompilerGenerated]
		private sealed class ju
		{
			// Token: 0x060022ED RID: 8941 RVA: 0x00097C95 File Offset: 0x00095E95
			internal void bb()
			{
				this.kcd.gcj(this.kce.mgf, this.kcd.mbc, this.kcf);
			}

			// Token: 0x060022EE RID: 8942 RVA: 0x00097CBE File Offset: 0x00095EBE
			internal void fvq()
			{
				this.kcd.gcg(this.kce.mgf);
			}

			// Token: 0x060022EF RID: 8943 RVA: 0x00097C95 File Offset: 0x00095E95
			internal void hag()
			{
				this.kcd.gcj(this.kce.mgf, this.kcd.mbc, this.kcf);
			}

			// Token: 0x060022F1 RID: 8945 RVA: 0x00097C95 File Offset: 0x00095E95
			internal void fvr()
			{
				this.kcd.gcj(this.kce.mgf, this.kcd.mbc, this.kcf);
			}

			// Token: 0x060022F2 RID: 8946 RVA: 0x00097C95 File Offset: 0x00095E95
			internal void hsa()
			{
				this.kcd.gcj(this.kce.mgf, this.kcd.mbc, this.kcf);
			}

			// Token: 0x060022F3 RID: 8947 RVA: 0x00097C95 File Offset: 0x00095E95
			internal void bqr()
			{
				this.kcd.gcj(this.kce.mgf, this.kcd.mbc, this.kcf);
			}

			// Token: 0x060022F4 RID: 8948 RVA: 0x00097CBE File Offset: 0x00095EBE
			internal void eyr()
			{
				this.kcd.gcg(this.kce.mgf);
			}

			// Token: 0x060022F5 RID: 8949 RVA: 0x00097CBE File Offset: 0x00095EBE
			internal void jyk()
			{
				this.kcd.gcg(this.kce.mgf);
			}

			// Token: 0x040010FD RID: 4349
			public ControlMapper kcd;

			// Token: 0x040010FE RID: 4350
			public Window kce;

			// Token: 0x040010FF RID: 4351
			public int kcf;
		}

		// Token: 0x02000216 RID: 534
		[CompilerGenerated]
		private sealed class jv
		{
			// Token: 0x060022F6 RID: 8950 RVA: 0x00097CD6 File Offset: 0x00095ED6
			internal void ckg()
			{
				this.kcg.gch(this.kch.mgf, this.kcj, this.kck);
			}

			// Token: 0x060022F7 RID: 8951 RVA: 0x00097CFA File Offset: 0x00095EFA
			internal void fvs()
			{
				this.kcg.gcg(this.kch.mgf);
			}

			// Token: 0x060022F9 RID: 8953 RVA: 0x00097CFA File Offset: 0x00095EFA
			internal void nfs()
			{
				this.kcg.gcg(this.kch.mgf);
			}

			// Token: 0x060022FA RID: 8954 RVA: 0x00097D12 File Offset: 0x00095F12
			internal void opv()
			{
				this.kcg.gci(this.kci, this.kcj, this.kck, this.kcl);
			}

			// Token: 0x060022FB RID: 8955 RVA: 0x00097CFA File Offset: 0x00095EFA
			internal void lik()
			{
				this.kcg.gcg(this.kch.mgf);
			}

			// Token: 0x060022FC RID: 8956 RVA: 0x00097CD6 File Offset: 0x00095ED6
			internal void lue()
			{
				this.kcg.gch(this.kch.mgf, this.kcj, this.kck);
			}

			// Token: 0x060022FD RID: 8957 RVA: 0x00097CD6 File Offset: 0x00095ED6
			internal void fvu()
			{
				this.kcg.gch(this.kch.mgf, this.kcj, this.kck);
			}

			// Token: 0x060022FE RID: 8958 RVA: 0x00097D12 File Offset: 0x00095F12
			internal void hsd()
			{
				this.kcg.gci(this.kci, this.kcj, this.kck, this.kcl);
			}

			// Token: 0x060022FF RID: 8959 RVA: 0x00097D12 File Offset: 0x00095F12
			internal void fvt()
			{
				this.kcg.gci(this.kci, this.kcj, this.kck, this.kcl);
			}

			// Token: 0x06002300 RID: 8960 RVA: 0x00097CD6 File Offset: 0x00095ED6
			internal void jhw()
			{
				this.kcg.gch(this.kch.mgf, this.kcj, this.kck);
			}

			// Token: 0x06002301 RID: 8961 RVA: 0x00097CD6 File Offset: 0x00095ED6
			internal void fp()
			{
				this.kcg.gch(this.kch.mgf, this.kcj, this.kck);
			}

			// Token: 0x06002302 RID: 8962 RVA: 0x00097CFA File Offset: 0x00095EFA
			internal void ida()
			{
				this.kcg.gcg(this.kch.mgf);
			}

			// Token: 0x04001100 RID: 4352
			public ControlMapper kcg;

			// Token: 0x04001101 RID: 4353
			public Window kch;

			// Token: 0x04001102 RID: 4354
			public kf kci;

			// Token: 0x04001103 RID: 4355
			public ControllerMap kcj;

			// Token: 0x04001104 RID: 4356
			public ActionElementMap kck;

			// Token: 0x04001105 RID: 4357
			public string kcl;
		}

		// Token: 0x02000217 RID: 535
		[CompilerGenerated]
		private sealed class jw
		{
			// Token: 0x06002303 RID: 8963 RVA: 0x00097D37 File Offset: 0x00095F37
			internal void gg()
			{
				this.kcm.gcm(this.kcn.mgf, this.kcm.kes, this.kco);
			}

			// Token: 0x06002304 RID: 8964 RVA: 0x00097D60 File Offset: 0x00095F60
			internal void fvv()
			{
				this.kcm.gcg(this.kcn.mgf);
			}

			// Token: 0x06002306 RID: 8966 RVA: 0x00097D37 File Offset: 0x00095F37
			internal void dft()
			{
				this.kcm.gcm(this.kcn.mgf, this.kcm.kes, this.kco);
			}

			// Token: 0x06002307 RID: 8967 RVA: 0x00097D78 File Offset: 0x00095F78
			internal void eeg()
			{
				this.kcm.gcl(this.kcn.mgf, this.kcm.kes, this.kco, this.kcp, false);
			}

			// Token: 0x06002308 RID: 8968 RVA: 0x00097D60 File Offset: 0x00095F60
			internal void bpx()
			{
				this.kcm.gcg(this.kcn.mgf);
			}

			// Token: 0x06002309 RID: 8969 RVA: 0x00097DA8 File Offset: 0x00095FA8
			internal void ldc()
			{
				this.kcm.gcl(this.kcn.mgf, this.kcm.kes, this.kco, this.kcp, true);
			}

			// Token: 0x0600230A RID: 8970 RVA: 0x00097D37 File Offset: 0x00095F37
			internal void fvx()
			{
				this.kcm.gcm(this.kcn.mgf, this.kcm.kes, this.kco);
			}

			// Token: 0x0600230B RID: 8971 RVA: 0x00097D37 File Offset: 0x00095F37
			internal void ckm()
			{
				this.kcm.gcm(this.kcn.mgf, this.kcm.kes, this.kco);
			}

			// Token: 0x0600230C RID: 8972 RVA: 0x00097D60 File Offset: 0x00095F60
			internal void jw()
			{
				this.kcm.gcg(this.kcn.mgf);
			}

			// Token: 0x0600230D RID: 8973 RVA: 0x00097D37 File Offset: 0x00095F37
			internal void jmm()
			{
				this.kcm.gcm(this.kcn.mgf, this.kcm.kes, this.kco);
			}

			// Token: 0x0600230E RID: 8974 RVA: 0x00097D78 File Offset: 0x00095F78
			internal void fvw()
			{
				this.kcm.gcl(this.kcn.mgf, this.kcm.kes, this.kco, this.kcp, false);
			}

			// Token: 0x0600230F RID: 8975 RVA: 0x00097DA8 File Offset: 0x00095FA8
			internal void fvy()
			{
				this.kcm.gcl(this.kcn.mgf, this.kcm.kes, this.kco, this.kcp, true);
			}

			// Token: 0x06002310 RID: 8976 RVA: 0x00097DA8 File Offset: 0x00095FA8
			internal void fqt()
			{
				this.kcm.gcl(this.kcn.mgf, this.kcm.kes, this.kco, this.kcp, true);
			}

			// Token: 0x06002311 RID: 8977 RVA: 0x00097DA8 File Offset: 0x00095FA8
			internal void jjr()
			{
				this.kcm.gcl(this.kcn.mgf, this.kcm.kes, this.kco, this.kcp, true);
			}

			// Token: 0x04001106 RID: 4358
			public ControlMapper kcm;

			// Token: 0x04001107 RID: 4359
			public Window kcn;

			// Token: 0x04001108 RID: 4360
			public ElementAssignment kco;

			// Token: 0x04001109 RID: 4361
			public bool kcp;
		}

		// Token: 0x02000218 RID: 536
		[CompilerGenerated]
		private sealed class jx
		{
			// Token: 0x06002313 RID: 8979 RVA: 0x00097DD8 File Offset: 0x00095FD8
			internal void nhf()
			{
				this.kcq.gcg(this.kcr.mgf);
			}

			// Token: 0x06002314 RID: 8980 RVA: 0x00097DD8 File Offset: 0x00095FD8
			internal void fhi()
			{
				this.kcq.gcg(this.kcr.mgf);
			}

			// Token: 0x06002315 RID: 8981 RVA: 0x00097DD8 File Offset: 0x00095FD8
			internal void fvz()
			{
				this.kcq.gcg(this.kcr.mgf);
			}

			// Token: 0x06002316 RID: 8982 RVA: 0x00097DF0 File Offset: 0x00095FF0
			internal void fwa()
			{
				this.kcq.gck(this.kcr.mgf, this.kcq.mbc);
			}

			// Token: 0x06002317 RID: 8983 RVA: 0x00097DF0 File Offset: 0x00095FF0
			internal void ncj()
			{
				this.kcq.gck(this.kcr.mgf, this.kcq.mbc);
			}

			// Token: 0x06002318 RID: 8984 RVA: 0x00097DD8 File Offset: 0x00095FD8
			internal void hf()
			{
				this.kcq.gcg(this.kcr.mgf);
			}

			// Token: 0x0400110A RID: 4362
			public ControlMapper kcq;

			// Token: 0x0400110B RID: 4363
			public Window kcr;
		}

		// Token: 0x02000219 RID: 537
		[CompilerGenerated]
		private sealed class jy
		{
			// Token: 0x06002319 RID: 8985 RVA: 0x00097E13 File Offset: 0x00096013
			internal void jyi()
			{
				this.kcs.gcn(this.kct.mgf);
			}

			// Token: 0x0600231A RID: 8986 RVA: 0x00097E13 File Offset: 0x00096013
			internal void fwc()
			{
				this.kcs.gcn(this.kct.mgf);
			}

			// Token: 0x0600231B RID: 8987 RVA: 0x00097E2B File Offset: 0x0009602B
			internal void fwb()
			{
				this.kcs.gcg(this.kct.mgf);
			}

			// Token: 0x0600231C RID: 8988 RVA: 0x00097E2B File Offset: 0x0009602B
			internal void gzn()
			{
				this.kcs.gcg(this.kct.mgf);
			}

			// Token: 0x0600231E RID: 8990 RVA: 0x00097E13 File Offset: 0x00096013
			internal void hlp()
			{
				this.kcs.gcn(this.kct.mgf);
			}

			// Token: 0x0600231F RID: 8991 RVA: 0x00097E2B File Offset: 0x0009602B
			internal void hox()
			{
				this.kcs.gcg(this.kct.mgf);
			}

			// Token: 0x0400110C RID: 4364
			public ControlMapper kcs;

			// Token: 0x0400110D RID: 4365
			public Window kct;
		}

		// Token: 0x0200021A RID: 538
		[CompilerGenerated]
		private sealed class jz
		{
			// Token: 0x06002321 RID: 8993 RVA: 0x00097E43 File Offset: 0x00096043
			internal bool fwd(ElementAssignmentConflictInfo a)
			{
				return a.elementMapId == this.kcu.id;
			}

			// Token: 0x0400110E RID: 4366
			public ActionElementMap kcu;
		}
	}
}
