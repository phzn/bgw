using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Rewired.Utils.Attributes;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data
{
	// Token: 0x02000195 RID: 405
	public abstract class UserDataStore_KeyValue : UserDataStore
	{
		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x0007CBC1 File Offset: 0x0007ADC1
		// (set) Token: 0x06001B54 RID: 6996 RVA: 0x0007CBC9 File Offset: 0x0007ADC9
		public bool lpf
		{
			get
			{
				return this._isEnabled;
			}
			set
			{
				this._isEnabled = value;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x0007CBD2 File Offset: 0x0007ADD2
		// (set) Token: 0x06001B56 RID: 6998 RVA: 0x0007CBDA File Offset: 0x0007ADDA
		public bool lpg
		{
			get
			{
				return this._loadDataOnStart;
			}
			set
			{
				this._loadDataOnStart = value;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x0007CBE3 File Offset: 0x0007ADE3
		// (set) Token: 0x06001B58 RID: 7000 RVA: 0x0007CBEB File Offset: 0x0007ADEB
		public bool lph
		{
			get
			{
				return this._loadJoystickAssignments;
			}
			set
			{
				this._loadJoystickAssignments = value;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x0007CBF4 File Offset: 0x0007ADF4
		// (set) Token: 0x06001B5A RID: 7002 RVA: 0x0007CBFC File Offset: 0x0007ADFC
		public bool lpi
		{
			get
			{
				return this._loadKeyboardAssignments;
			}
			set
			{
				this._loadKeyboardAssignments = value;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x0007CC05 File Offset: 0x0007AE05
		// (set) Token: 0x06001B5C RID: 7004 RVA: 0x0007CC0D File Offset: 0x0007AE0D
		public bool lpj
		{
			get
			{
				return this._loadMouseAssignments;
			}
			set
			{
				this._loadMouseAssignments = value;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x0007CC16 File Offset: 0x0007AE16
		// (set) Token: 0x06001B5E RID: 7006 RVA: 0x0007CC1E File Offset: 0x0007AE1E
		public UserDataStore_KeyValue.ActionMappingSaveMode lpk
		{
			get
			{
				return this._actionMappingSaveMode;
			}
			set
			{
				this._actionMappingSaveMode = value;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001B5F RID: 7007
		protected abstract UserDataStore_KeyValue.hg lpa { get; }

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001B60 RID: 7008 RVA: 0x0007CC27 File Offset: 0x0007AE27
		private bool lpl
		{
			get
			{
				return this._loadKeyboardAssignments || this._loadMouseAssignments || this._loadJoystickAssignments;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x0007CC44 File Offset: 0x0007AE44
		private List<int> lpm
		{
			get
			{
				if (this.jrx != null)
				{
					return this.jrx;
				}
				List<int> list = new List<int>();
				IList<InputAction> actions = ReInput.mapping.Actions;
				for (int i = 0; i < actions.Count; i++)
				{
					list.Add(actions[i].id);
				}
				this.jrx = list;
				return list;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001B62 RID: 7010 RVA: 0x0007CC9C File Offset: 0x0007AE9C
		private string lpn
		{
			get
			{
				if (!string.IsNullOrEmpty(this.jry))
				{
					return this.jry;
				}
				StringBuilder stringBuilder = new StringBuilder();
				List<int> list = this.lpm;
				for (int i = 0; i < list.Count; i++)
				{
					if (i > 0)
					{
						stringBuilder.Append(a.ejj());
					}
					stringBuilder.Append(list[i]);
				}
				this.jry = stringBuilder.ToString();
				return this.jry;
			}
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0007CD0B File Offset: 0x0007AF0B
		public override void Save()
		{
			if (!this._isEnabled)
			{
				Debug.LogWarning(a.emv() + UserDataStore_KeyValue.jrp + a.emw(), this);
				return;
			}
			this.eno();
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0007CD36 File Offset: 0x0007AF36
		public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
			if (!this._isEnabled)
			{
				Debug.LogWarning(a.emv() + UserDataStore_KeyValue.jrp + a.emw(), this);
				return;
			}
			this.env(playerId, controllerType, controllerId);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0007CD64 File Offset: 0x0007AF64
		public override void SaveControllerData(ControllerType controllerType, int controllerId)
		{
			if (!this._isEnabled)
			{
				Debug.LogWarning(a.emv() + UserDataStore_KeyValue.jrp + a.emw(), this);
				return;
			}
			this.enw(controllerType, controllerId);
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0007CD91 File Offset: 0x0007AF91
		public override void SavePlayerData(int playerId)
		{
			if (!this._isEnabled)
			{
				Debug.LogWarning(a.emv() + UserDataStore_KeyValue.jrp + a.emw(), this);
				return;
			}
			this.enp(playerId);
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x0007CDBD File Offset: 0x0007AFBD
		public override void SaveInputBehavior(int playerId, int behaviorId)
		{
			if (!this._isEnabled)
			{
				Debug.LogWarning(a.emv() + UserDataStore_KeyValue.jrp + a.emw(), this);
				return;
			}
			this.eoe(playerId, behaviorId);
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x0007CDEA File Offset: 0x0007AFEA
		public override void Load()
		{
			if (!this._isEnabled)
			{
				Debug.LogWarning(a.emv() + UserDataStore_KeyValue.jrp + a.emx(), this);
				return;
			}
			this.emt();
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x0007CE16 File Offset: 0x0007B016
		public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
			if (!this._isEnabled)
			{
				Debug.LogWarning(a.emv() + UserDataStore_KeyValue.jrp + a.emx(), this);
				return;
			}
			this.ena(playerId, controllerType, controllerId);
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x0007CE45 File Offset: 0x0007B045
		public override void LoadControllerData(ControllerType controllerType, int controllerId)
		{
			if (!this._isEnabled)
			{
				Debug.LogWarning(a.emv() + UserDataStore_KeyValue.jrp + a.emx(), this);
				return;
			}
			this.enb(controllerType, controllerId);
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x0007CE73 File Offset: 0x0007B073
		public override void LoadPlayerData(int playerId)
		{
			if (!this._isEnabled)
			{
				Debug.LogWarning(a.emv() + UserDataStore_KeyValue.jrp + a.emx(), this);
				return;
			}
			this.emu(playerId);
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x0007CEA0 File Offset: 0x0007B0A0
		public override void LoadInputBehavior(int playerId, int behaviorId)
		{
			if (!this._isEnabled)
			{
				Debug.LogWarning(a.emv() + UserDataStore_KeyValue.jrp + a.emx(), this);
				return;
			}
			this.enh(playerId, behaviorId);
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x0007CECE File Offset: 0x0007B0CE
		protected override void OnInitialize()
		{
			if (this._loadDataOnStart)
			{
				this.Load();
				if (this.lpl && ReInput.controllers.joystickCount > 0)
				{
					this.jrw = true;
					this.eog();
				}
			}
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x0007CF04 File Offset: 0x0007B104
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
		{
			if (!this._isEnabled)
			{
				return;
			}
			if (args.controllerType == ControllerType.Joystick)
			{
				this.emz(args.controllerId);
				if (this._loadDataOnStart && this._loadJoystickAssignments && !this.jrw)
				{
					base.StartCoroutine(this.enn());
				}
				if (this._loadJoystickAssignments && !this.jrv)
				{
					this.eog();
				}
				this.jrw = true;
			}
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x0007CF73 File Offset: 0x0007B173
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
		{
			if (!this._isEnabled)
			{
				return;
			}
			if (args.controllerType == ControllerType.Joystick)
			{
				this.enu(args.controllerId);
			}
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x0007CF93 File Offset: 0x0007B193
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
		{
			if (!this._isEnabled)
			{
				return;
			}
			if (this.lpl)
			{
				this.eog();
			}
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0007CFB0 File Offset: 0x0007B1B0
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
		{
			if (controllerMap == null)
			{
				return;
			}
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				return;
			}
			this.enz(player, controllerMap);
			this.lpa.Save();
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x0007CFE8 File Offset: 0x0007B1E8
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				return null;
			}
			return this.ene(player, controllerIdentifier, categoryId, layoutId);
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x0007D011 File Offset: 0x0007B211
		public virtual void ems()
		{
			this.lpa.ekw();
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x0007D020 File Offset: 0x0007B220
		private int emt()
		{
			int num = 0;
			if (this.lpl && this.enj())
			{
				num++;
			}
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				num += this.emv(allPlayers[i]);
			}
			return num + this.emw();
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0007D079 File Offset: 0x0007B279
		private int emu(int a)
		{
			return this.emv(ReInput.players.GetPlayer(a));
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x0007D08C File Offset: 0x0007B28C
		private int emv(Player a)
		{
			if (a == null)
			{
				return 0;
			}
			int num = 0;
			num += this.eng(a.id);
			num += this.enc(a.id, ControllerType.Keyboard, 0);
			num += this.enc(a.id, ControllerType.Mouse, 0);
			foreach (Joystick joystick in a.controllers.Joysticks)
			{
				num += this.enc(a.id, ControllerType.Joystick, joystick.id);
			}
			this.eov(a.id);
			return num;
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x0007D134 File Offset: 0x0007B334
		private int emw()
		{
			int num = 0;
			IList<Joystick> joysticks = ReInput.controllers.Joysticks;
			for (int i = 0; i < joysticks.Count; i++)
			{
				num += this.emx(joysticks[i]);
			}
			return num;
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x0007D170 File Offset: 0x0007B370
		private int emx(Joystick a)
		{
			if (a == null)
			{
				return 0;
			}
			if (!a.ImportCalibrationMapFromJsonString(this.eoq(a)))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x0007D189 File Offset: 0x0007B389
		private int emy(int a)
		{
			return this.emx(ReInput.controllers.GetJoystick(a));
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x0007D19C File Offset: 0x0007B39C
		private int emz(int a)
		{
			int num = 0;
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				Player player = allPlayers[i];
				if (player.controllers.ContainsController(ControllerType.Joystick, a))
				{
					num += this.enc(player.id, ControllerType.Joystick, a);
					this.eov(player.id);
				}
			}
			return num + this.emy(a);
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x0007D206 File Offset: 0x0007B406
		private int ena(int a, ControllerType b, int c)
		{
			int num = 0 + this.enc(a, b, c);
			this.eov(a);
			return num + this.enb(b, c);
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0007D224 File Offset: 0x0007B424
		private int enb(ControllerType a, int b)
		{
			int num = 0;
			if (a == ControllerType.Joystick)
			{
				num += this.emy(b);
			}
			return num;
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x0007D244 File Offset: 0x0007B444
		private int enc(int a, ControllerType b, int c)
		{
			int num = 0;
			Player player = ReInput.players.GetPlayer(a);
			if (player == null)
			{
				return num;
			}
			Controller controller = ReInput.controllers.GetController(b, c);
			if (controller == null)
			{
				return num;
			}
			IList<InputMapCategory> mapCategories = ReInput.mapping.MapCategories;
			for (int i = 0; i < mapCategories.Count; i++)
			{
				InputMapCategory inputMapCategory = mapCategories[i];
				if (inputMapCategory.userAssignable)
				{
					IList<InputLayout> list = ReInput.mapping.MapLayouts(controller.type);
					for (int j = 0; j < list.Count; j++)
					{
						InputLayout inputLayout = list[j];
						UserDataStore_KeyValue.ActionMappingSaveMode actionMappingSaveMode = this._actionMappingSaveMode;
						if (actionMappingSaveMode != UserDataStore_KeyValue.ActionMappingSaveMode.ByController)
						{
							if (actionMappingSaveMode != UserDataStore_KeyValue.ActionMappingSaveMode.ByControllerElementRole)
							{
								throw new NotImplementedException();
							}
							Dictionary<string, UserDataStore_KeyValue.ControllerElementByRoleMap> dictionary = ((this.jsa != null) ? this.jsa : (this.jsa = new Dictionary<string, UserDataStore_KeyValue.ControllerElementByRoleMap>()));
							dictionary.Clear();
							bool flag = false;
							bool flag2 = false;
							for (int k = 0; k < controller.elementCount; k++)
							{
								string role = controller.Elements[k].elementIdentifier.role;
								if (!string.IsNullOrEmpty(role))
								{
									this.enf(player, controller, role, inputMapCategory.id, inputLayout.id, dictionary);
								}
							}
							ControllerMap controllerMap = this.ene(player, controller.identifier, inputMapCategory.id, inputLayout.id);
							if (controllerMap == null)
							{
								controllerMap = player.controllers.maps.GetMap(controller.type, controller.id, inputMapCategory.id, inputLayout.id);
								if (controllerMap == null)
								{
									if (dictionary.Count == 0)
									{
										goto IL_03A8;
									}
									controllerMap = ControllerMap.Create(controller, inputMapCategory.id, inputLayout.id);
								}
							}
							else
							{
								flag = true;
							}
							if (dictionary.Count != 0)
							{
								if (this.jsb == null)
								{
									this.jsb = new Dictionary<string, bool>();
								}
								this.jsb.Clear();
								for (int l = controllerMap.elementMapCount - 1; l >= 0; l--)
								{
									ActionElementMap actionElementMap = controllerMap.ElementMaps[l];
									ControllerElementIdentifier elementIdentifierById = controller.GetElementIdentifierById(actionElementMap.elementIdentifierId);
									if (elementIdentifierById != null && dictionary.ContainsKey(elementIdentifierById.role))
									{
										this.jsb[elementIdentifierById.role] = actionElementMap.enabled;
										controllerMap.DeleteElementMap(actionElementMap.id);
										flag2 = true;
									}
								}
								foreach (KeyValuePair<string, UserDataStore_KeyValue.ControllerElementByRoleMap> keyValuePair in dictionary)
								{
									UserDataStore_KeyValue.ControllerElementByRoleMap value = keyValuePair.Value;
									for (int m = 0; m < controller.Elements.Count; m++)
									{
										Controller.Element element = controller.Elements[m];
										if (!(element.elementIdentifier.role != keyValuePair.Value.role) && value.data != null && value.data.Count != 0)
										{
											for (int n = 0; n < value.data.Count; n++)
											{
												ElementAssignment elementAssignment;
												ActionElementMap actionElementMap2;
												if (value.data[n].elt(b, element, out elementAssignment) && controllerMap.CreateElementMap(elementAssignment, out actionElementMap2))
												{
													bool flag3;
													if (this.jsb.TryGetValue(keyValuePair.Value.role, out flag3))
													{
														actionElementMap2.enabled = flag3;
													}
													flag = true;
													flag2 = true;
												}
											}
										}
									}
								}
							}
							if (flag2)
							{
								controllerMap.isModified = false;
							}
							if (flag)
							{
								player.controllers.maps.AddMap(controller, controllerMap);
								num++;
							}
						}
						else
						{
							ControllerMap controllerMap2 = this.ene(player, controller.identifier, inputMapCategory.id, inputLayout.id);
							if (controllerMap2 != null)
							{
								player.controllers.maps.AddMap(controller, controllerMap2);
								num++;
							}
						}
						IL_03A8:;
					}
				}
			}
			return num;
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x0007D640 File Offset: 0x0007B840
		private ControllerMap ene(Player a, ControllerIdentifier b, int c, int d)
		{
			if (a == null)
			{
				return null;
			}
			string text = this.eoo(a, b, c, d);
			if (string.IsNullOrEmpty(text))
			{
				return null;
			}
			ControllerMap controllerMap = ControllerMap.CreateFromJson(b.controllerType, text);
			if (controllerMap == null)
			{
				return null;
			}
			List<int> list = this.eop(a, b, c, d);
			this.eos(b, controllerMap, list);
			return controllerMap;
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x0007D694 File Offset: 0x0007B894
		private bool enf(Player a, Controller b, string c, int d, int e, Dictionary<string, UserDataStore_KeyValue.ControllerElementByRoleMap> f)
		{
			if (string.IsNullOrEmpty(c))
			{
				return false;
			}
			this.jrz.Length = 0;
			UserDataStore_KeyValue.eoh(this.jrz, a);
			UserDataStore_KeyValue.eol(this.jrz, c, d, e, 0);
			bool flag;
			try
			{
				string text;
				if (!UserDataStore_KeyValue.eoy(this.lpa, this.jrz.ToString(), out text))
				{
					flag = false;
				}
				else if (string.IsNullOrEmpty(text))
				{
					flag = false;
				}
				else
				{
					UserDataStore_KeyValue.ControllerElementByRoleMap controllerElementByRoleMap = UserDataStore_KeyValue.ControllerElementByRoleMap.elv(c, text);
					if (controllerElementByRoleMap == null)
					{
						flag = false;
					}
					else
					{
						f[c] = controllerElementByRoleMap;
						flag = true;
					}
				}
			}
			catch
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0007D730 File Offset: 0x0007B930
		private int eng(int a)
		{
			Player player = ReInput.players.GetPlayer(a);
			if (player == null)
			{
				return 0;
			}
			int num = 0;
			IList<InputBehavior> inputBehaviors = ReInput.mapping.GetInputBehaviors(player.id);
			for (int i = 0; i < inputBehaviors.Count; i++)
			{
				num += this.eni(player, inputBehaviors[i]);
			}
			return num;
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x0007D784 File Offset: 0x0007B984
		private int enh(int a, int b)
		{
			Player player = ReInput.players.GetPlayer(a);
			if (player == null)
			{
				return 0;
			}
			InputBehavior inputBehavior = ReInput.mapping.GetInputBehavior(a, b);
			if (inputBehavior == null)
			{
				return 0;
			}
			return this.eni(player, inputBehavior);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x0007D7BC File Offset: 0x0007B9BC
		private int eni(Player a, InputBehavior b)
		{
			if (a == null || b == null)
			{
				return 0;
			}
			string text = this.eor(a, b.id);
			if (text == null || text == string.Empty)
			{
				return 0;
			}
			if (!b.ImportJsonString(text))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0007D800 File Offset: 0x0007BA00
		private bool enj()
		{
			try
			{
				UserDataStore_KeyValue.he he = this.enm();
				if (he == null)
				{
					return false;
				}
				if (this._loadKeyboardAssignments || this._loadMouseAssignments)
				{
					this.enk(he);
				}
				if (this._loadJoystickAssignments)
				{
					this.enl(he);
				}
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x0007D85C File Offset: 0x0007BA5C
		private bool enk(UserDataStore_KeyValue.he a)
		{
			try
			{
				if (a == null && (a = this.enm()) == null)
				{
					return false;
				}
				foreach (Player player in ReInput.players.AllPlayers)
				{
					if (a.els(player.id))
					{
						UserDataStore_KeyValue.he.hc hc = a.jrg[a.elr(player.id)];
						if (this._loadKeyboardAssignments)
						{
							player.controllers.hasKeyboard = hc.jra;
						}
						if (this._loadMouseAssignments)
						{
							player.controllers.hasMouse = hc.jrb;
						}
					}
				}
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x0007D928 File Offset: 0x0007BB28
		private bool enl(UserDataStore_KeyValue.he a)
		{
			try
			{
				if (ReInput.controllers.joystickCount == 0)
				{
					return false;
				}
				if (a == null && (a = this.enm()) == null)
				{
					return false;
				}
				foreach (Player player in ReInput.players.AllPlayers)
				{
					player.controllers.ClearControllersOfType(ControllerType.Joystick);
				}
				List<UserDataStore_KeyValue.hf> list = (this._loadJoystickAssignments ? new List<UserDataStore_KeyValue.hf>() : null);
				foreach (Player player2 in ReInput.players.AllPlayers)
				{
					if (a.els(player2.id))
					{
						UserDataStore_KeyValue.he.hc hc = a.jrg[a.elr(player2.id)];
						for (int i = 0; i < hc.lpb; i++)
						{
							UserDataStore_KeyValue.hh hh = new UserDataStore_KeyValue.hh();
							UserDataStore_KeyValue.he.hd hd = hc.jrc[i];
							if (hd != null)
							{
								hh.jrj = this.eot(hd);
								if (hh.jrj != null)
								{
									if (list.Find(new Predicate<UserDataStore_KeyValue.hf>(hh.elw)) == null)
									{
										list.Add(new UserDataStore_KeyValue.hf(hh.jrj, hd.jrf));
									}
									player2.controllers.AddController(hh.jrj, false);
								}
							}
						}
					}
				}
				if (this.jru)
				{
					foreach (Player player3 in ReInput.players.AllPlayers)
					{
						if (a.els(player3.id))
						{
							UserDataStore_KeyValue.he.hc hc2 = a.jrg[a.elr(player3.id)];
							for (int j = 0; j < hc2.lpb; j++)
							{
								UserDataStore_KeyValue.hi hi = new UserDataStore_KeyValue.hi();
								hi.jrk = hc2.jrc[j];
								if (hi.jrk != null)
								{
									Joystick joystick = null;
									int num = list.FindIndex(new Predicate<UserDataStore_KeyValue.hf>(hi.elx));
									if (num >= 0)
									{
										joystick = list[num].jrh;
									}
									else
									{
										List<Joystick> list2;
										if (!this.eou(hi.jrk, out list2))
										{
											goto IL_029A;
										}
										using (List<Joystick>.Enumerator enumerator2 = list2.GetEnumerator())
										{
											while (enumerator2.MoveNext())
											{
												UserDataStore_KeyValue.hj hj = new UserDataStore_KeyValue.hj();
												hj.jrl = enumerator2.Current;
												if (list.Find(new Predicate<UserDataStore_KeyValue.hf>(hj.ely)) == null)
												{
													joystick = hj.jrl;
													break;
												}
											}
										}
										if (joystick == null)
										{
											goto IL_029A;
										}
										list.Add(new UserDataStore_KeyValue.hf(joystick, hi.jrk.jrf));
									}
									player3.controllers.AddController(joystick, false);
								}
								IL_029A:;
							}
						}
					}
				}
			}
			catch
			{
			}
			if (ReInput.configuration.autoAssignJoysticks)
			{
				ReInput.controllers.AutoAssignJoysticks();
			}
			return true;
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0007DC94 File Offset: 0x0007BE94
		private UserDataStore_KeyValue.he enm()
		{
			UserDataStore_KeyValue.he he;
			try
			{
				string text;
				if (!UserDataStore_KeyValue.eoy(this.lpa, a.emy(), out text))
				{
					he = null;
				}
				else if (string.IsNullOrEmpty(text))
				{
					he = null;
				}
				else
				{
					UserDataStore_KeyValue.he he2 = JsonParser.FromJson<UserDataStore_KeyValue.he>(text);
					if (he2 == null || he2.lpc == 0)
					{
						he = null;
					}
					else
					{
						he = he2;
					}
				}
			}
			catch
			{
				he = null;
			}
			return he;
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0007DCF8 File Offset: 0x0007BEF8
		private IEnumerator enn()
		{
			this.jrv = true;
			yield return new WaitForEndOfFrame();
			if (!ReInput.isReady)
			{
				yield break;
			}
			this.enl(null);
			this.eog();
			this.jrv = false;
			yield break;
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0007DD08 File Offset: 0x0007BF08
		private void eno()
		{
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				this.enq(allPlayers[i]);
			}
			this.enr();
			if (this.lpl)
			{
				this.eog();
			}
			this.lpa.Save();
			for (int j = 0; j < allPlayers.Count; j++)
			{
				this.eow(allPlayers[j]);
			}
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0007DD80 File Offset: 0x0007BF80
		private void enp(int a)
		{
			Player player = ReInput.players.GetPlayer(a);
			this.enq(player);
			this.lpa.Save();
			this.eow(player);
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0007DDB4 File Offset: 0x0007BFB4
		private void enq(Player a)
		{
			if (a == null)
			{
				return;
			}
			PlayerSaveData saveData = a.GetSaveData(true);
			this.eod(a, saveData);
			this.enx(a, saveData);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x0007DDE0 File Offset: 0x0007BFE0
		private void enr()
		{
			IList<Joystick> joysticks = ReInput.controllers.Joysticks;
			for (int i = 0; i < joysticks.Count; i++)
			{
				this.ent(joysticks[i]);
			}
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0007DE16 File Offset: 0x0007C016
		private void ens(int a)
		{
			this.ent(ReInput.controllers.GetJoystick(a));
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x0007DE2C File Offset: 0x0007C02C
		private void ent(Joystick a)
		{
			if (a == null)
			{
				return;
			}
			JoystickCalibrationMapSaveData calibrationMapSaveData = a.GetCalibrationMapSaveData();
			string text = this.eom(a);
			this.lpa.eku(text, calibrationMapSaveData.map.ToJsonString());
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0007DE64 File Offset: 0x0007C064
		private void enu(int a)
		{
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				Player player = allPlayers[i];
				if (player.controllers.ContainsController(ControllerType.Joystick, a))
				{
					this.eny(player.id, ControllerType.Joystick, a);
				}
			}
			this.ens(a);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0007DEB9 File Offset: 0x0007C0B9
		private void env(int a, ControllerType b, int c)
		{
			this.eny(a, b, c);
			this.SaveControllerData(b, c);
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0007DECC File Offset: 0x0007C0CC
		private void enw(ControllerType a, int b)
		{
			if (a == ControllerType.Joystick)
			{
				this.ens(b);
			}
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0007DEDC File Offset: 0x0007C0DC
		private void enx(Player a, PlayerSaveData b)
		{
			List<ControllerMapSaveData> list = new List<ControllerMapSaveData>(b.AllControllerMapSaveData);
			if (this._actionMappingSaveMode == UserDataStore_KeyValue.ActionMappingSaveMode.ByControllerElementRole)
			{
				list.Sort(new Comparison<ControllerMapSaveData>(UserDataStore_KeyValue.eoz));
			}
			for (int i = 0; i < list.Count; i++)
			{
				this.enz(a, list[i].map);
			}
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0007DF38 File Offset: 0x0007C138
		private void eny(int a, ControllerType b, int c)
		{
			Player player = ReInput.players.GetPlayer(a);
			if (player == null)
			{
				return;
			}
			if (!player.controllers.ContainsController(b, c))
			{
				return;
			}
			ControllerMapSaveData[] mapSaveData = player.controllers.maps.GetMapSaveData(b, c, true);
			if (mapSaveData == null)
			{
				return;
			}
			if (this._actionMappingSaveMode == UserDataStore_KeyValue.ActionMappingSaveMode.ByControllerElementRole)
			{
				List<ControllerMapSaveData> list = new List<ControllerMapSaveData>(mapSaveData);
				list.Sort(new Comparison<ControllerMapSaveData>(UserDataStore_KeyValue.eoz));
				list.CopyTo(mapSaveData);
			}
			for (int i = 0; i < mapSaveData.Length; i++)
			{
				this.enz(player, mapSaveData[i].map);
			}
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0007DFC4 File Offset: 0x0007C1C4
		private void enz(Player a, ControllerMap b)
		{
			UserDataStore_KeyValue.ActionMappingSaveMode actionMappingSaveMode = this._actionMappingSaveMode;
			if (actionMappingSaveMode == UserDataStore_KeyValue.ActionMappingSaveMode.ByController)
			{
				this.eoa(a, b);
				return;
			}
			if (actionMappingSaveMode != UserDataStore_KeyValue.ActionMappingSaveMode.ByControllerElementRole)
			{
				throw new NotImplementedException();
			}
			this.eob(a, b.controller, b);
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x0007E000 File Offset: 0x0007C200
		private void eoa(Player a, ControllerMap b)
		{
			string text = this.eoi(a, b.controller.identifier, b.categoryId, b.layoutId, 0);
			this.lpa.eku(text, b.ToJsonString());
			text = this.eoj(a, b.controller.identifier, b.categoryId, b.layoutId, 0);
			this.lpa.eku(text, this.lpn);
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x0007E074 File Offset: 0x0007C274
		private void eob(Player a, Controller b, ControllerMap c)
		{
			if (b == null)
			{
				return;
			}
			this.eoa(a, c);
			IList<ActionElementMap> elementMaps = c.ElementMaps;
			Dictionary<string, UserDataStore_KeyValue.ControllerElementByRoleMap> dictionary = null;
			for (int i = 0; i < b.elementCount; i++)
			{
				string role = b.Elements[i].elementIdentifier.role;
				if (!string.IsNullOrEmpty(role))
				{
					bool flag = false;
					for (int j = 0; j < elementMaps.Count; j++)
					{
						Controller.Element elementById = b.GetElementById(elementMaps[j].elementIdentifierId);
						if (elementById != null && !(elementById.elementIdentifier.role != role))
						{
							flag |= this.eoc(a, c.controller, elementMaps[j], ref dictionary);
						}
					}
					if (!flag)
					{
						if (dictionary == null)
						{
							dictionary = new Dictionary<string, UserDataStore_KeyValue.ControllerElementByRoleMap>();
						}
						dictionary.Add(role, new UserDataStore_KeyValue.ControllerElementByRoleMap
						{
							role = role
						});
					}
				}
			}
			if (dictionary == null)
			{
				return;
			}
			foreach (KeyValuePair<string, UserDataStore_KeyValue.ControllerElementByRoleMap> keyValuePair in dictionary)
			{
				this.jrz.Length = 0;
				UserDataStore_KeyValue.eoh(this.jrz, a);
				UserDataStore_KeyValue.eol(this.jrz, keyValuePair.Value.role, c.categoryId, c.layoutId, 0);
				this.lpa.eku(this.jrz.ToString(), keyValuePair.Value.elu());
			}
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x0007E1F4 File Offset: 0x0007C3F4
		private bool eoc(Player a, Controller b, ActionElementMap c, ref Dictionary<string, UserDataStore_KeyValue.ControllerElementByRoleMap> d)
		{
			ControllerElementIdentifier elementIdentifierById = b.GetElementIdentifierById(c.elementIdentifierId);
			if (elementIdentifierById == null || string.IsNullOrEmpty(elementIdentifierById.role))
			{
				return false;
			}
			if (d == null)
			{
				d = new Dictionary<string, UserDataStore_KeyValue.ControllerElementByRoleMap>();
			}
			UserDataStore_KeyValue.ControllerElementByRoleMap controllerElementByRoleMap;
			if (!d.TryGetValue(elementIdentifierById.role, out controllerElementByRoleMap))
			{
				controllerElementByRoleMap = new UserDataStore_KeyValue.ControllerElementByRoleMap();
				controllerElementByRoleMap.role = elementIdentifierById.role;
				d.Add(elementIdentifierById.role, controllerElementByRoleMap);
			}
			controllerElementByRoleMap.Add(c);
			return true;
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x0007E268 File Offset: 0x0007C468
		private void eod(Player a, PlayerSaveData b)
		{
			if (a == null)
			{
				return;
			}
			InputBehavior[] inputBehaviors = b.inputBehaviors;
			for (int i = 0; i < inputBehaviors.Length; i++)
			{
				this.eof(a, inputBehaviors[i]);
			}
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x0007E29C File Offset: 0x0007C49C
		private void eoe(int a, int b)
		{
			Player player = ReInput.players.GetPlayer(a);
			if (player == null)
			{
				return;
			}
			InputBehavior inputBehavior = ReInput.mapping.GetInputBehavior(a, b);
			if (inputBehavior == null)
			{
				return;
			}
			this.eof(player, inputBehavior);
			this.lpa.Save();
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0007E2E0 File Offset: 0x0007C4E0
		private void eof(Player a, InputBehavior b)
		{
			if (a == null || b == null)
			{
				return;
			}
			string text = this.eon(a, b.id);
			this.lpa.eku(text, b.ToJsonString());
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x0007E318 File Offset: 0x0007C518
		private bool eog()
		{
			try
			{
				UserDataStore_KeyValue.he he = new UserDataStore_KeyValue.he(ReInput.players.allPlayerCount);
				for (int i = 0; i < ReInput.players.allPlayerCount; i++)
				{
					Player player = ReInput.players.AllPlayers[i];
					UserDataStore_KeyValue.he.hc hc = new UserDataStore_KeyValue.he.hc();
					he.jrg[i] = hc;
					hc.jqz = player.id;
					hc.jra = player.controllers.hasKeyboard;
					hc.jrb = player.controllers.hasMouse;
					UserDataStore_KeyValue.he.hd[] array = new UserDataStore_KeyValue.he.hd[player.controllers.joystickCount];
					hc.jrc = array;
					for (int j = 0; j < player.controllers.joystickCount; j++)
					{
						Joystick joystick = player.controllers.Joysticks[j];
						array[j] = new UserDataStore_KeyValue.he.hd
						{
							jrd = joystick.deviceInstanceGuid,
							jrf = joystick.id,
							jre = joystick.hardwareIdentifier
						};
					}
				}
				this.lpa.eku(a.emy(), JsonWriter.ToJson(he));
				this.lpa.Save();
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x0007E464 File Offset: 0x0007C664
		private static void eoh(StringBuilder a, Player b)
		{
			a.Append(a.emz());
			a.Append(b.id);
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x0007E480 File Offset: 0x0007C680
		private string eoi(Player a, ControllerIdentifier b, int c, int d, int e)
		{
			this.jrz.Length = 0;
			UserDataStore_KeyValue.eoh(this.jrz, a);
			this.jrz.Append(a.ena());
			UserDataStore_KeyValue.eok(this.jrz, a, b, c, d, e);
			return this.jrz.ToString();
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x0007E4D4 File Offset: 0x0007C6D4
		private string eoj(Player a, ControllerIdentifier b, int c, int d, int e)
		{
			this.jrz.Length = 0;
			UserDataStore_KeyValue.eoh(this.jrz, a);
			this.jrz.Append(a.enb());
			UserDataStore_KeyValue.eok(this.jrz, a, b, c, d, e);
			return this.jrz.ToString();
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x0007E528 File Offset: 0x0007C728
		private static void eok(StringBuilder a, Player b, ControllerIdentifier c, int d, int e, int f)
		{
			a.Append(a.enc());
			a.Append(f);
			a.Append(a.end());
			a.Append((int)c.controllerType);
			a.Append(a.ene());
			a.Append(d);
			a.Append(a.enf());
			a.Append(a.eng());
			a.Append(e);
			a.Append(a.enh());
			a.Append(c.hardwareTypeGuid);
			if (c.hardwareTypeGuid == Guid.Empty)
			{
				a.Append(a.eni());
				a.Append(c.hardwareIdentifier);
			}
			if (c.controllerType == ControllerType.Joystick)
			{
				a.Append(a.enj());
				a.Append(UserDataStore_KeyValue.eox(b, c).ToString());
			}
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x0007E614 File Offset: 0x0007C814
		private static void eol(StringBuilder a, string b, int c, int d, int e)
		{
			a.Append(a.enk());
			a.Append(a.enc());
			a.Append(e);
			a.Append(a.ene());
			a.Append(c);
			a.Append(a.enl());
			a.Append(d);
			a.Append(a.enm());
			a.Append(b);
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x0007E680 File Offset: 0x0007C880
		private string eom(Joystick a)
		{
			this.jrz.Length = 0;
			this.jrz.Append(a.enn());
			this.jrz.Append(a.eno());
			this.jrz.Append((int)a.type);
			this.jrz.Append(a.eni());
			this.jrz.Append(a.hardwareIdentifier);
			this.jrz.Append(a.enh());
			this.jrz.Append(a.hardwareTypeGuid.ToString());
			return this.jrz.ToString();
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x0007E72C File Offset: 0x0007C92C
		private string eon(Player a, int b)
		{
			this.jrz.Length = 0;
			UserDataStore_KeyValue.eoh(this.jrz, a);
			this.jrz.Append(a.enp());
			this.jrz.Append(a.enq());
			this.jrz.Append(b);
			return this.jrz.ToString();
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0007E78C File Offset: 0x0007C98C
		private string eoo(Player a, ControllerIdentifier b, int c, int d)
		{
			for (int i = 0; i >= 0; i--)
			{
				string text = this.eoi(a, b, c, d, i);
				string text2;
				if (UserDataStore_KeyValue.eoy(this.lpa, text, out text2) && !string.IsNullOrEmpty(text2))
				{
					return text2;
				}
			}
			return null;
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0007E7D0 File Offset: 0x0007C9D0
		private List<int> eop(Player a, ControllerIdentifier b, int c, int d)
		{
			List<int> list = new List<int>();
			string text = null;
			bool flag = false;
			for (int i = 0; i >= 0; i--)
			{
				string text2 = this.eoj(a, b, c, d, i);
				if (UserDataStore_KeyValue.eoy(this.lpa, text2, out text))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return list;
			}
			if (string.IsNullOrEmpty(text))
			{
				return list;
			}
			string[] array = text.Split(',', StringSplitOptions.None);
			for (int j = 0; j < array.Length; j++)
			{
				int num;
				if (!string.IsNullOrEmpty(array[j]) && int.TryParse(array[j], out num))
				{
					list.Add(num);
				}
			}
			return list;
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0007E86C File Offset: 0x0007CA6C
		private string eoq(Joystick a)
		{
			string text = this.eom(a);
			string text2;
			UserDataStore_KeyValue.eoy(this.lpa, text, out text2);
			return text2;
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0007E894 File Offset: 0x0007CA94
		private string eor(Player a, int b)
		{
			string text = this.eon(a, b);
			string text2;
			UserDataStore_KeyValue.eoy(this.lpa, text, out text2);
			return text2;
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0007E8BC File Offset: 0x0007CABC
		private void eos(ControllerIdentifier a, ControllerMap b, List<int> c)
		{
			if (b == null || c == null)
			{
				return;
			}
			if (c == null || c.Count == 0)
			{
				return;
			}
			ControllerMap controllerMapInstance = ReInput.mapping.GetControllerMapInstance(a, b.categoryId, b.layoutId);
			if (controllerMapInstance == null)
			{
				return;
			}
			List<int> list = new List<int>();
			foreach (int num in this.lpm)
			{
				if (!c.Contains(num))
				{
					list.Add(num);
				}
			}
			if (list.Count == 0)
			{
				return;
			}
			bool flag = false;
			foreach (ActionElementMap actionElementMap in controllerMapInstance.AllMaps)
			{
				if (list.Contains(actionElementMap.actionId) && !b.DoesElementAssignmentConflict(actionElementMap))
				{
					ElementAssignment elementAssignment = new ElementAssignment(b.controllerType, actionElementMap.elementType, actionElementMap.elementIdentifierId, actionElementMap.axisRange, actionElementMap.keyCode, actionElementMap.modifierKeyFlags, actionElementMap.actionId, actionElementMap.axisContribution, actionElementMap.invert);
					b.CreateElementMap(elementAssignment);
				}
			}
			if (flag)
			{
				b.isModified = false;
			}
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0007EA08 File Offset: 0x0007CC08
		private Joystick eot(UserDataStore_KeyValue.he.hd a)
		{
			if (a == null)
			{
				return null;
			}
			if (a.jrd == Guid.Empty)
			{
				return null;
			}
			IList<Joystick> joysticks = ReInput.controllers.Joysticks;
			for (int i = 0; i < joysticks.Count; i++)
			{
				if (joysticks[i].deviceInstanceGuid == a.jrd)
				{
					return joysticks[i];
				}
			}
			return null;
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x0007EA6C File Offset: 0x0007CC6C
		private bool eou(UserDataStore_KeyValue.he.hd a, out List<Joystick> b)
		{
			b = null;
			if (a == null)
			{
				return false;
			}
			if (string.IsNullOrEmpty(a.jre))
			{
				return false;
			}
			IList<Joystick> joysticks = ReInput.controllers.Joysticks;
			for (int i = 0; i < joysticks.Count; i++)
			{
				if (string.Equals(joysticks[i].hardwareIdentifier, a.jre, StringComparison.OrdinalIgnoreCase))
				{
					if (b == null)
					{
						b = new List<Joystick>();
					}
					b.Add(joysticks[i]);
				}
			}
			return b != null;
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0007EAE4 File Offset: 0x0007CCE4
		private void eov(int a)
		{
			Player player = ReInput.players.GetPlayer(a);
			if (player == null)
			{
				return;
			}
			player.controllers.maps.layoutManager.Apply();
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x0007EB18 File Offset: 0x0007CD18
		private void eow(Player a)
		{
			if (this._actionMappingSaveMode == UserDataStore_KeyValue.ActionMappingSaveMode.ByControllerElementRole)
			{
				int joystickCount = a.controllers.joystickCount;
				if (joystickCount > 1)
				{
					for (int i = 0; i < joystickCount; i++)
					{
						this.enc(a.id, ControllerType.Joystick, a.controllers.Joysticks[i].id);
					}
					this.eov(a.id);
				}
			}
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0007EB7C File Offset: 0x0007CD7C
		private static int eox(Player a, ControllerIdentifier b)
		{
			Controller controller = ReInput.controllers.GetController(b);
			if (controller == null)
			{
				return 0;
			}
			int num = 0;
			foreach (Controller controller2 in a.controllers.Controllers)
			{
				if (controller2.type == controller.type)
				{
					bool flag = false;
					if (controller.type == ControllerType.Joystick)
					{
						if ((controller2 as Joystick).hardwareTypeGuid != controller.hardwareTypeGuid)
						{
							continue;
						}
						if (controller.hardwareTypeGuid != Guid.Empty)
						{
							flag = true;
						}
					}
					if (flag || !(controller2.hardwareIdentifier != controller.hardwareIdentifier))
					{
						if (controller2 == controller)
						{
							return num;
						}
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0007EC4C File Offset: 0x0007CE4C
		private static bool eoy(UserDataStore_KeyValue.hg a, string b, out string c)
		{
			if (a == null || string.IsNullOrEmpty(b))
			{
				c = null;
				return false;
			}
			object obj;
			if (!a.ekt(b, out obj))
			{
				c = null;
				return false;
			}
			c = obj as string;
			return obj is string;
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0007EC8C File Offset: 0x0007CE8C
		private static int eoz(ControllerMapSaveData a, ControllerMapSaveData b)
		{
			if (a.map == null)
			{
				if (b.map == null)
				{
					return 0;
				}
				return -1;
			}
			else
			{
				if (b.map == null)
				{
					return 1;
				}
				return a.map.modifiedTime.CompareTo(b.map.modifiedTime);
			}
		}

		// Token: 0x04000E88 RID: 3720
		private static readonly string jrp = typeof(UserDataStore_KeyValue).Name;

		// Token: 0x04000E89 RID: 3721
		private const string jrq = "Rewired: ";

		// Token: 0x04000E8A RID: 3722
		private const string jrr = "ControllerAssignments";

		// Token: 0x04000E8B RID: 3723
		private const int jrs = 0;

		// Token: 0x04000E8C RID: 3724
		private const int jrt = 0;

		// Token: 0x04000E8D RID: 3725
		[SerializeField]
		private bool _isEnabled = true;

		// Token: 0x04000E8E RID: 3726
		[SerializeField]
		private bool _loadDataOnStart = true;

		// Token: 0x04000E8F RID: 3727
		[SerializeField]
		private bool _loadJoystickAssignments = true;

		// Token: 0x04000E90 RID: 3728
		[SerializeField]
		private bool _loadKeyboardAssignments = true;

		// Token: 0x04000E91 RID: 3729
		[SerializeField]
		private bool _loadMouseAssignments = true;

		// Token: 0x04000E92 RID: 3730
		[SerializeField]
		private UserDataStore_KeyValue.ActionMappingSaveMode _actionMappingSaveMode;

		// Token: 0x04000E93 RID: 3731
		[NonSerialized]
		private bool jru = true;

		// Token: 0x04000E94 RID: 3732
		[NonSerialized]
		private bool jrv;

		// Token: 0x04000E95 RID: 3733
		[NonSerialized]
		private bool jrw;

		// Token: 0x04000E96 RID: 3734
		[NonSerialized]
		private List<int> jrx;

		// Token: 0x04000E97 RID: 3735
		[NonSerialized]
		private string jry;

		// Token: 0x04000E98 RID: 3736
		[NonSerialized]
		private readonly StringBuilder jrz = new StringBuilder();

		// Token: 0x04000E99 RID: 3737
		[NonSerialized]
		private Dictionary<string, UserDataStore_KeyValue.ControllerElementByRoleMap> jsa;

		// Token: 0x04000E9A RID: 3738
		[NonSerialized]
		private Dictionary<string, bool> jsb;

		// Token: 0x02000196 RID: 406
		private class he
		{
			// Token: 0x06001BB0 RID: 7088 RVA: 0x0007ED28 File Offset: 0x0007CF28
			public int elr(int a)
			{
				for (int i = 0; i < this.lpc; i++)
				{
					if (this.jrg[i] != null && this.jrg[i].jqz == a)
					{
						return i;
					}
				}
				return -1;
			}

			// Token: 0x06001BB1 RID: 7089 RVA: 0x00002854 File Offset: 0x00000A54
			public he()
			{
			}

			// Token: 0x06001BB2 RID: 7090 RVA: 0x0007ED63 File Offset: 0x0007CF63
			public bool ibv(int a)
			{
				return this.elr(a) >= 0;
			}

			// Token: 0x06001BB3 RID: 7091 RVA: 0x0007ED63 File Offset: 0x0007CF63
			public bool lnu(int a)
			{
				return this.elr(a) >= 0;
			}

			// Token: 0x06001BB4 RID: 7092 RVA: 0x0007ED63 File Offset: 0x0007CF63
			public bool nkl(int a)
			{
				return this.elr(a) >= 0;
			}

			// Token: 0x06001BB5 RID: 7093 RVA: 0x0007ED74 File Offset: 0x0007CF74
			public int con(int a)
			{
				for (int i = 0; i < this.lpc; i++)
				{
					if (this.jrg[i] != null && this.jrg[i].jqz == a)
					{
						return i;
					}
				}
				return -1;
			}

			// Token: 0x06001BB6 RID: 7094 RVA: 0x0007EDB0 File Offset: 0x0007CFB0
			public he(int a)
			{
				this.jrg = new UserDataStore_KeyValue.he.hc[a];
				for (int i = 0; i < a; i++)
				{
					this.jrg[i] = new UserDataStore_KeyValue.he.hc();
				}
			}

			// Token: 0x170003C1 RID: 961
			// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x0007EDE8 File Offset: 0x0007CFE8
			public int lpc
			{
				get
				{
					if (this.jrg == null)
					{
						return 0;
					}
					return this.jrg.Length;
				}
			}

			// Token: 0x06001BB8 RID: 7096 RVA: 0x0007EDFC File Offset: 0x0007CFFC
			public int ooz(int a)
			{
				for (int i = 0; i < this.lpc; i++)
				{
					if (this.jrg[i] != null && this.jrg[i].jqz == a)
					{
						return i;
					}
				}
				return -1;
			}

			// Token: 0x06001BB9 RID: 7097 RVA: 0x0007ED63 File Offset: 0x0007CF63
			public bool els(int a)
			{
				return this.elr(a) >= 0;
			}

			// Token: 0x06001BBA RID: 7098 RVA: 0x0007EE38 File Offset: 0x0007D038
			public int leb(int a)
			{
				for (int i = 0; i < this.lpc; i++)
				{
					if (this.jrg[i] != null && this.jrg[i].jqz == a)
					{
						return i;
					}
				}
				return -1;
			}

			// Token: 0x04000E9B RID: 3739
			public UserDataStore_KeyValue.he.hc[] jrg;

			// Token: 0x02000197 RID: 407
			public class hc
			{
				// Token: 0x06001BBB RID: 7099 RVA: 0x0007EE73 File Offset: 0x0007D073
				public bool @in(int a)
				{
					return this.elo(a) >= 0;
				}

				// Token: 0x06001BBC RID: 7100 RVA: 0x0007EE73 File Offset: 0x0007D073
				public bool jnp(int a)
				{
					return this.elo(a) >= 0;
				}

				// Token: 0x06001BBD RID: 7101 RVA: 0x0007EE84 File Offset: 0x0007D084
				public int fwv(int a)
				{
					for (int i = 0; i < this.lpb; i++)
					{
						if (this.jrc[i] != null && this.jrc[i].jrf == a)
						{
							return i;
						}
					}
					return -1;
				}

				// Token: 0x06001BBF RID: 7103 RVA: 0x0007EEC0 File Offset: 0x0007D0C0
				public int kfv(int a)
				{
					for (int i = 0; i < this.lpb; i++)
					{
						if (this.jrc[i] != null && this.jrc[i].jrf == a)
						{
							return i;
						}
					}
					return -1;
				}

				// Token: 0x170003C2 RID: 962
				// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x0007EEFB File Offset: 0x0007D0FB
				public int lpb
				{
					get
					{
						if (this.jrc == null)
						{
							return 0;
						}
						return this.jrc.Length;
					}
				}

				// Token: 0x06001BC1 RID: 7105 RVA: 0x0007EF10 File Offset: 0x0007D110
				public int elo(int a)
				{
					for (int i = 0; i < this.lpb; i++)
					{
						if (this.jrc[i] != null && this.jrc[i].jrf == a)
						{
							return i;
						}
					}
					return -1;
				}

				// Token: 0x06001BC2 RID: 7106 RVA: 0x0007EF4C File Offset: 0x0007D14C
				public int kpt(int a)
				{
					for (int i = 0; i < this.lpb; i++)
					{
						if (this.jrc[i] != null && this.jrc[i].jrf == a)
						{
							return i;
						}
					}
					return -1;
				}

				// Token: 0x06001BC3 RID: 7107 RVA: 0x0007EE73 File Offset: 0x0007D073
				public bool gqe(int a)
				{
					return this.elo(a) >= 0;
				}

				// Token: 0x06001BC4 RID: 7108 RVA: 0x0007EE73 File Offset: 0x0007D073
				public bool elp(int a)
				{
					return this.elo(a) >= 0;
				}

				// Token: 0x06001BC5 RID: 7109 RVA: 0x0007EF88 File Offset: 0x0007D188
				public int men(int a)
				{
					for (int i = 0; i < this.lpb; i++)
					{
						if (this.jrc[i] != null && this.jrc[i].jrf == a)
						{
							return i;
						}
					}
					return -1;
				}

				// Token: 0x04000E9C RID: 3740
				public int jqz;

				// Token: 0x04000E9D RID: 3741
				public bool jra;

				// Token: 0x04000E9E RID: 3742
				public bool jrb;

				// Token: 0x04000E9F RID: 3743
				public UserDataStore_KeyValue.he.hd[] jrc;
			}

			// Token: 0x02000198 RID: 408
			public class hd
			{
				// Token: 0x04000EA0 RID: 3744
				public Guid jrd;

				// Token: 0x04000EA1 RID: 3745
				public string jre;

				// Token: 0x04000EA2 RID: 3746
				public int jrf;
			}
		}

		// Token: 0x02000199 RID: 409
		private class hf
		{
			// Token: 0x06001BC7 RID: 7111 RVA: 0x0007EFC3 File Offset: 0x0007D1C3
			public hf(Joystick a, int b)
			{
				if (a == null)
				{
					throw new ArgumentNullException(a.eml());
				}
				this.jrh = a;
				this.jri = b;
			}

			// Token: 0x04000EA3 RID: 3747
			public readonly Joystick jrh;

			// Token: 0x04000EA4 RID: 3748
			public readonly int jri;
		}

		// Token: 0x0200019A RID: 410
		protected interface hg
		{
			// Token: 0x06001BC8 RID: 7112
			bool Save();

			// Token: 0x06001BC9 RID: 7113
			bool ekv();

			// Token: 0x06001BCA RID: 7114
			bool ekw();

			// Token: 0x06001BCB RID: 7115
			bool ekt(string a, out object b);

			// Token: 0x06001BCC RID: 7116
			bool eku(string a, object b);
		}

		// Token: 0x0200019B RID: 411
		[Serializable]
		protected class ControllerElementByRoleMap
		{
			// Token: 0x06001BCD RID: 7117 RVA: 0x0007EFE7 File Offset: 0x0007D1E7
			[Preserve]
			public ControllerElementByRoleMap()
			{
				this.data = new List<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>();
			}

			// Token: 0x06001BCE RID: 7118 RVA: 0x0007EFFC File Offset: 0x0007D1FC
			public void Add(ActionElementMap elementMap)
			{
				this.data.Add(new UserDataStore_KeyValue.ControllerElementByRoleMap.Entry
				{
					actionId = elementMap.actionId,
					elementType = elementMap.elementType,
					axisRange = elementMap.axisRange,
					invert = elementMap.invert,
					axisContribution = elementMap.axisContribution
				});
			}

			// Token: 0x06001BCF RID: 7119 RVA: 0x0007F060 File Offset: 0x0007D260
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(a.emr());
				stringBuilder.Append(this.role);
				stringBuilder.Append(a.ems());
				stringBuilder.Append((this.data != null) ? this.data.Count : 0);
				stringBuilder.Append(a.bfx());
				if (this.data != null)
				{
					for (int i = 0; i < this.data.Count; i++)
					{
						stringBuilder.Append(a.emt());
						stringBuilder.Append(i);
						stringBuilder.Append(a.emu());
						stringBuilder.Append(this.data[i]);
					}
				}
				return stringBuilder.ToString();
			}

			// Token: 0x06001BD0 RID: 7120 RVA: 0x0007F11D File Offset: 0x0007D31D
			public string elu()
			{
				return JsonWriter.ToJson(this);
			}

			// Token: 0x06001BD1 RID: 7121 RVA: 0x0007F128 File Offset: 0x0007D328
			public static UserDataStore_KeyValue.ControllerElementByRoleMap elv(string a, string b)
			{
				UserDataStore_KeyValue.ControllerElementByRoleMap controllerElementByRoleMap = JsonParser.FromJson<UserDataStore_KeyValue.ControllerElementByRoleMap>(b);
				if (controllerElementByRoleMap != null)
				{
					controllerElementByRoleMap.role = a;
				}
				return controllerElementByRoleMap;
			}

			// Token: 0x04000EA5 RID: 3749
			[DoNotSerialize]
			public string role;

			// Token: 0x04000EA6 RID: 3750
			public List<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry> data;

			// Token: 0x0200019C RID: 412
			[Serializable]
			public struct Entry
			{
				// Token: 0x06001BD2 RID: 7122 RVA: 0x0007F148 File Offset: 0x0007D348
				public bool elt(ControllerType a, Controller.Element b, out ElementAssignment c)
				{
					if (b.type == this.elementType)
					{
						c = ElementAssignment.CompleteAssignment(a, b.type, b.elementIdentifier.id, this.axisRange, KeyCode.None, ModifierKeyFlags.None, this.actionId, this.axisContribution, this.invert);
						return true;
					}
					ControllerElementType controllerElementType = this.elementType;
					if (controllerElementType != ControllerElementType.Axis)
					{
						if (controllerElementType != ControllerElementType.Button)
						{
							c = default(ElementAssignment);
							return false;
						}
						if (b.type == ControllerElementType.Axis)
						{
							c = ElementAssignment.CompleteAssignment(a, b.type, b.elementIdentifier.id, AxisRange.Positive, KeyCode.None, ModifierKeyFlags.None, this.actionId, this.axisContribution, false);
							return true;
						}
						c = default(ElementAssignment);
						return false;
					}
					else
					{
						if (b.type == ControllerElementType.Button)
						{
							Pole pole = this.axisContribution;
							if (this.axisRange == AxisRange.Full && this.invert)
							{
								pole = Pole.Negative;
							}
							c = ElementAssignment.CompleteAssignment(a, b.type, b.elementIdentifier.id, AxisRange.Full, KeyCode.None, ModifierKeyFlags.None, this.actionId, pole, false);
							return true;
						}
						c = default(ElementAssignment);
						return false;
					}
				}

				// Token: 0x06001BD3 RID: 7123 RVA: 0x0007F24C File Offset: 0x0007D44C
				public override string ToString()
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append(a.emm());
					stringBuilder.Append(this.actionId);
					stringBuilder.Append(a.emn());
					stringBuilder.Append(this.elementType);
					stringBuilder.Append(a.emo());
					stringBuilder.Append(this.axisRange);
					stringBuilder.Append(a.emp());
					stringBuilder.Append(this.invert);
					stringBuilder.Append(a.emq());
					stringBuilder.Append(this.axisContribution);
					return stringBuilder.ToString();
				}

				// Token: 0x04000EA7 RID: 3751
				public int actionId;

				// Token: 0x04000EA8 RID: 3752
				public ControllerElementType elementType;

				// Token: 0x04000EA9 RID: 3753
				public AxisRange axisRange;

				// Token: 0x04000EAA RID: 3754
				public bool invert;

				// Token: 0x04000EAB RID: 3755
				public Pole axisContribution;
			}
		}

		// Token: 0x0200019D RID: 413
		public enum ActionMappingSaveMode
		{
			// Token: 0x04000EAD RID: 3757
			ByController,
			// Token: 0x04000EAE RID: 3758
			ByControllerElementRole
		}

		// Token: 0x0200019E RID: 414
		[CompilerGenerated]
		private sealed class hh
		{
			// Token: 0x06001BD4 RID: 7124 RVA: 0x0007F2EF File Offset: 0x0007D4EF
			internal bool elw(UserDataStore_KeyValue.hf a)
			{
				return a.jrh == this.jrj;
			}

			// Token: 0x06001BD5 RID: 7125 RVA: 0x0007F2EF File Offset: 0x0007D4EF
			internal bool lyj(UserDataStore_KeyValue.hf a)
			{
				return a.jrh == this.jrj;
			}

			// Token: 0x06001BD7 RID: 7127 RVA: 0x0007F2EF File Offset: 0x0007D4EF
			internal bool eud(UserDataStore_KeyValue.hf a)
			{
				return a.jrh == this.jrj;
			}

			// Token: 0x06001BD8 RID: 7128 RVA: 0x0007F2EF File Offset: 0x0007D4EF
			internal bool dfx(UserDataStore_KeyValue.hf a)
			{
				return a.jrh == this.jrj;
			}

			// Token: 0x06001BD9 RID: 7129 RVA: 0x0007F2EF File Offset: 0x0007D4EF
			internal bool ivm(UserDataStore_KeyValue.hf a)
			{
				return a.jrh == this.jrj;
			}

			// Token: 0x04000EAF RID: 3759
			public Joystick jrj;
		}

		// Token: 0x0200019F RID: 415
		[CompilerGenerated]
		private sealed class hi
		{
			// Token: 0x06001BDA RID: 7130 RVA: 0x0007F2FF File Offset: 0x0007D4FF
			internal bool elx(UserDataStore_KeyValue.hf a)
			{
				return a.jri == this.jrk.jrf;
			}

			// Token: 0x06001BDB RID: 7131 RVA: 0x0007F2FF File Offset: 0x0007D4FF
			internal bool lay(UserDataStore_KeyValue.hf a)
			{
				return a.jri == this.jrk.jrf;
			}

			// Token: 0x04000EB0 RID: 3760
			public UserDataStore_KeyValue.he.hd jrk;
		}

		// Token: 0x020001A0 RID: 416
		[CompilerGenerated]
		private sealed class hj
		{
			// Token: 0x06001BDD RID: 7133 RVA: 0x0007F314 File Offset: 0x0007D514
			internal bool ely(UserDataStore_KeyValue.hf a)
			{
				return a.jrh == this.jrl;
			}

			// Token: 0x04000EB1 RID: 3761
			public Joystick jrl;
		}
	}
}
