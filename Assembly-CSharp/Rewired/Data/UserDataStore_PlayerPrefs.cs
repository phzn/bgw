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
	// Token: 0x020001A2 RID: 418
	public class UserDataStore_PlayerPrefs : UserDataStore
	{
		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x0007F3A9 File Offset: 0x0007D5A9
		// (set) Token: 0x06001BE6 RID: 7142 RVA: 0x0007F3B1 File Offset: 0x0007D5B1
		public bool lps
		{
			get
			{
				return this.isEnabled;
			}
			set
			{
				this.isEnabled = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x0007F3BA File Offset: 0x0007D5BA
		// (set) Token: 0x06001BE8 RID: 7144 RVA: 0x0007F3C2 File Offset: 0x0007D5C2
		public bool lpt
		{
			get
			{
				return this.loadDataOnStart;
			}
			set
			{
				this.loadDataOnStart = value;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x0007F3CB File Offset: 0x0007D5CB
		// (set) Token: 0x06001BEA RID: 7146 RVA: 0x0007F3D3 File Offset: 0x0007D5D3
		public bool lpu
		{
			get
			{
				return this.loadJoystickAssignments;
			}
			set
			{
				this.loadJoystickAssignments = value;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001BEB RID: 7147 RVA: 0x0007F3DC File Offset: 0x0007D5DC
		// (set) Token: 0x06001BEC RID: 7148 RVA: 0x0007F3E4 File Offset: 0x0007D5E4
		public bool lpv
		{
			get
			{
				return this.loadKeyboardAssignments;
			}
			set
			{
				this.loadKeyboardAssignments = value;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x0007F3ED File Offset: 0x0007D5ED
		// (set) Token: 0x06001BEE RID: 7150 RVA: 0x0007F3F5 File Offset: 0x0007D5F5
		public bool lpw
		{
			get
			{
				return this.loadMouseAssignments;
			}
			set
			{
				this.loadMouseAssignments = value;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x0007F3FE File Offset: 0x0007D5FE
		// (set) Token: 0x06001BF0 RID: 7152 RVA: 0x0007F406 File Offset: 0x0007D606
		public UserDataStore_PlayerPrefs.ActionMappingSaveMode lpx
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

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x0007F40F File Offset: 0x0007D60F
		// (set) Token: 0x06001BF2 RID: 7154 RVA: 0x0007F417 File Offset: 0x0007D617
		public string lpy
		{
			get
			{
				return this.playerPrefsKeyPrefix;
			}
			set
			{
				this.playerPrefsKeyPrefix = value;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x0007F420 File Offset: 0x0007D620
		private string lpz
		{
			get
			{
				return string.Format(a.enr(), this.playerPrefsKeyPrefix, a.emy());
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x0007F437 File Offset: 0x0007D637
		private bool lqa
		{
			get
			{
				return this.loadKeyboardAssignments || this.loadMouseAssignments || this.loadJoystickAssignments;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x0007F454 File Offset: 0x0007D654
		private List<int> lqb
		{
			get
			{
				if (this.jte != null)
				{
					return this.jte;
				}
				List<int> list = new List<int>();
				IList<InputAction> actions = ReInput.mapping.Actions;
				for (int i = 0; i < actions.Count; i++)
				{
					list.Add(actions[i].id);
				}
				this.jte = list;
				return list;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x0007F4AC File Offset: 0x0007D6AC
		private string lqc
		{
			get
			{
				if (!string.IsNullOrEmpty(this.jtf))
				{
					return this.jtf;
				}
				StringBuilder stringBuilder = new StringBuilder();
				List<int> list = this.lqb;
				for (int i = 0; i < list.Count; i++)
				{
					if (i > 0)
					{
						stringBuilder.Append(a.ejj());
					}
					stringBuilder.Append(list[i]);
				}
				this.jtf = stringBuilder.ToString();
				return this.jtf;
			}
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0007F51B File Offset: 0x0007D71B
		public override void Save()
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning(a.ens(), this);
				return;
			}
			this.erc();
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0007F537 File Offset: 0x0007D737
		public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning(a.ens(), this);
				return;
			}
			this.erj(playerId, controllerType, controllerId);
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0007F556 File Offset: 0x0007D756
		public override void SaveControllerData(ControllerType controllerType, int controllerId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning(a.ens(), this);
				return;
			}
			this.erk(controllerType, controllerId);
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0007F574 File Offset: 0x0007D774
		public override void SavePlayerData(int playerId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning(a.ens(), this);
				return;
			}
			this.erd(playerId);
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0007F591 File Offset: 0x0007D791
		public override void SaveInputBehavior(int playerId, int behaviorId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning(a.ens(), this);
				return;
			}
			this.ers(playerId, behaviorId);
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x0007F5AF File Offset: 0x0007D7AF
		public override void Load()
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning(a.ent(), this);
				return;
			}
			this.eqi();
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0007F5CC File Offset: 0x0007D7CC
		public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning(a.ent(), this);
				return;
			}
			this.eqp(playerId, controllerType, controllerId);
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x0007F5EC File Offset: 0x0007D7EC
		public override void LoadControllerData(ControllerType controllerType, int controllerId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning(a.ent(), this);
				return;
			}
			this.eqq(controllerType, controllerId);
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0007F60B File Offset: 0x0007D80B
		public override void LoadPlayerData(int playerId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning(a.ent(), this);
				return;
			}
			this.eqj(playerId);
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0007F629 File Offset: 0x0007D829
		public override void LoadInputBehavior(int playerId, int behaviorId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning(a.ent(), this);
				return;
			}
			this.eqv(playerId, behaviorId);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0007F648 File Offset: 0x0007D848
		protected override void OnInitialize()
		{
			if (this.loadDataOnStart)
			{
				this.Load();
				if (this.lqa && ReInput.controllers.joystickCount > 0)
				{
					this.jtd = true;
					this.eru();
				}
			}
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x0007F67C File Offset: 0x0007D87C
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
		{
			if (!this.isEnabled)
			{
				return;
			}
			if (args.controllerType == ControllerType.Joystick)
			{
				this.eqo(args.controllerId);
				if (this.loadDataOnStart && this.loadJoystickAssignments && !this.jtd)
				{
					base.StartCoroutine(this.erb());
				}
				if (this.loadJoystickAssignments && !this.jtc)
				{
					this.eru();
				}
				this.jtd = true;
			}
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x0007F6EB File Offset: 0x0007D8EB
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
		{
			if (!this.isEnabled)
			{
				return;
			}
			if (args.controllerType == ControllerType.Joystick)
			{
				this.eri(args.controllerId);
			}
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x0007F70B File Offset: 0x0007D90B
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
		{
			if (!this.isEnabled)
			{
				return;
			}
			if (this.lqa)
			{
				this.eru();
			}
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x0007F728 File Offset: 0x0007D928
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
			this.ern(player, controllerMap);
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0007F754 File Offset: 0x0007D954
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				return null;
			}
			return this.eqs(player, controllerIdentifier, categoryId, layoutId);
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x0007F780 File Offset: 0x0007D980
		private int eqi()
		{
			int num = 0;
			if (this.lqa && this.eqx())
			{
				num++;
			}
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				num += this.eqk(allPlayers[i]);
			}
			return num + this.eql();
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0007F7D9 File Offset: 0x0007D9D9
		private int eqj(int a)
		{
			return this.eqk(ReInput.players.GetPlayer(a));
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x0007F7EC File Offset: 0x0007D9EC
		private int eqk(Player a)
		{
			if (a == null)
			{
				return 0;
			}
			int num = 0;
			num += this.equ(a.id);
			num += this.eqr(a.id, ControllerType.Keyboard, 0);
			num += this.eqr(a.id, ControllerType.Mouse, 0);
			foreach (Joystick joystick in a.controllers.Joysticks)
			{
				num += this.eqr(a.id, ControllerType.Joystick, joystick.id);
			}
			this.esr(a.id);
			return num;
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x0007F894 File Offset: 0x0007DA94
		private int eql()
		{
			int num = 0;
			IList<Joystick> joysticks = ReInput.controllers.Joysticks;
			for (int i = 0; i < joysticks.Count; i++)
			{
				num += this.eqm(joysticks[i]);
			}
			return num;
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x0007F8D0 File Offset: 0x0007DAD0
		private int eqm(Joystick a)
		{
			if (a == null)
			{
				return 0;
			}
			if (!a.ImportCalibrationMapFromXmlString(this.esl(a)))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x0007F8E9 File Offset: 0x0007DAE9
		private int eqn(int a)
		{
			return this.eqm(ReInput.controllers.GetJoystick(a));
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x0007F8FC File Offset: 0x0007DAFC
		private int eqo(int a)
		{
			int num = 0;
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				Player player = allPlayers[i];
				if (player.controllers.ContainsController(ControllerType.Joystick, a))
				{
					num += this.eqr(player.id, ControllerType.Joystick, a);
					this.esr(player.id);
				}
			}
			return num + this.eqn(a);
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x0007F966 File Offset: 0x0007DB66
		private int eqp(int a, ControllerType b, int c)
		{
			int num = 0 + this.eqr(a, b, c);
			this.esr(a);
			return num + this.eqq(b, c);
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x0007F984 File Offset: 0x0007DB84
		private int eqq(ControllerType a, int b)
		{
			int num = 0;
			if (a == ControllerType.Joystick)
			{
				num += this.eqn(b);
			}
			return num;
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x0007F9A4 File Offset: 0x0007DBA4
		private int eqr(int a, ControllerType b, int c)
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
						UserDataStore_PlayerPrefs.ActionMappingSaveMode actionMappingSaveMode = this._actionMappingSaveMode;
						if (actionMappingSaveMode != UserDataStore_PlayerPrefs.ActionMappingSaveMode.ByController)
						{
							if (actionMappingSaveMode != UserDataStore_PlayerPrefs.ActionMappingSaveMode.ByControllerElementRole)
							{
								throw new NotImplementedException();
							}
							Dictionary<string, UserDataStore_PlayerPrefs.ControllerElementByRoleMap> dictionary = ((this.jth != null) ? this.jth : (this.jth = new Dictionary<string, UserDataStore_PlayerPrefs.ControllerElementByRoleMap>()));
							dictionary.Clear();
							bool flag = false;
							bool flag2 = false;
							for (int k = 0; k < controller.elementCount; k++)
							{
								string role = controller.Elements[k].elementIdentifier.role;
								if (!string.IsNullOrEmpty(role))
								{
									this.eqt(player, controller, role, inputMapCategory.id, inputLayout.id, dictionary);
								}
							}
							ControllerMap controllerMap = this.eqs(player, controller.identifier, inputMapCategory.id, inputLayout.id);
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
								if (this.jti == null)
								{
									this.jti = new Dictionary<string, bool>();
								}
								this.jti.Clear();
								for (int l = controllerMap.elementMapCount - 1; l >= 0; l--)
								{
									ActionElementMap actionElementMap = controllerMap.ElementMaps[l];
									ControllerElementIdentifier elementIdentifierById = controller.GetElementIdentifierById(actionElementMap.elementIdentifierId);
									if (elementIdentifierById != null && dictionary.ContainsKey(elementIdentifierById.role))
									{
										this.jti[elementIdentifierById.role] = actionElementMap.enabled;
										controllerMap.DeleteElementMap(actionElementMap.id);
										flag2 = true;
									}
								}
								foreach (KeyValuePair<string, UserDataStore_PlayerPrefs.ControllerElementByRoleMap> keyValuePair in dictionary)
								{
									UserDataStore_PlayerPrefs.ControllerElementByRoleMap value = keyValuePair.Value;
									for (int m = 0; m < controller.Elements.Count; m++)
									{
										Controller.Element element = controller.Elements[m];
										if (!(element.elementIdentifier.role != keyValuePair.Value.role) && value.data != null && value.data.Count != 0)
										{
											for (int n = 0; n < value.data.Count; n++)
											{
												ElementAssignment elementAssignment;
												ActionElementMap actionElementMap2;
												if (value.data[n].epg(b, element, out elementAssignment) && controllerMap.CreateElementMap(elementAssignment, out actionElementMap2))
												{
													bool flag3;
													if (this.jti.TryGetValue(keyValuePair.Value.role, out flag3))
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
							ControllerMap controllerMap2 = this.eqs(player, controller.identifier, inputMapCategory.id, inputLayout.id);
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

		// Token: 0x06001C11 RID: 7185 RVA: 0x0007FDA0 File Offset: 0x0007DFA0
		private ControllerMap eqs(Player a, ControllerIdentifier b, int c, int d)
		{
			if (a == null)
			{
				return null;
			}
			string text = this.esj(a, b, c, d);
			if (string.IsNullOrEmpty(text))
			{
				return null;
			}
			ControllerMap controllerMap = ControllerMap.CreateFromXml(b.controllerType, text);
			if (controllerMap == null)
			{
				return null;
			}
			List<int> list = this.esk(a, b, c, d);
			this.esn(b, controllerMap, list);
			return controllerMap;
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x0007FDF4 File Offset: 0x0007DFF4
		private bool eqt(Player a, Controller b, string c, int d, int e, Dictionary<string, UserDataStore_PlayerPrefs.ControllerElementByRoleMap> f)
		{
			if (string.IsNullOrEmpty(c))
			{
				return false;
			}
			string text = this.erx(a, c, d, e, 0);
			bool flag;
			try
			{
				string @string;
				if (!PlayerPrefs.HasKey(text) || string.IsNullOrEmpty(@string = PlayerPrefs.GetString(text)))
				{
					flag = false;
				}
				else if (string.IsNullOrEmpty(@string))
				{
					flag = false;
				}
				else
				{
					UserDataStore_PlayerPrefs.ControllerElementByRoleMap controllerElementByRoleMap = UserDataStore_PlayerPrefs.ControllerElementByRoleMap.epi(c, @string);
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

		// Token: 0x06001C13 RID: 7187 RVA: 0x0007FE74 File Offset: 0x0007E074
		private int equ(int a)
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
				num += this.eqw(player, inputBehaviors[i]);
			}
			return num;
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x0007FEC8 File Offset: 0x0007E0C8
		private int eqv(int a, int b)
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
			return this.eqw(player, inputBehavior);
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0007FF00 File Offset: 0x0007E100
		private int eqw(Player a, InputBehavior b)
		{
			if (a == null || b == null)
			{
				return 0;
			}
			string text = this.esm(a, b.id);
			if (text == null || text == string.Empty)
			{
				return 0;
			}
			if (!b.ImportXmlString(text))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x0007FF44 File Offset: 0x0007E144
		private bool eqx()
		{
			try
			{
				UserDataStore_PlayerPrefs.hn hn = this.era();
				if (hn == null)
				{
					return false;
				}
				if (this.loadKeyboardAssignments || this.loadMouseAssignments)
				{
					this.eqy(hn);
				}
				if (this.loadJoystickAssignments)
				{
					this.eqz(hn);
				}
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x0007FFA0 File Offset: 0x0007E1A0
		private bool eqy(UserDataStore_PlayerPrefs.hn a)
		{
			try
			{
				if (a == null && (a = this.era()) == null)
				{
					return false;
				}
				foreach (Player player in ReInput.players.AllPlayers)
				{
					if (a.epf(player.id))
					{
						UserDataStore_PlayerPrefs.hn.hl hl = a.jsj[a.epe(player.id)];
						if (this.loadKeyboardAssignments)
						{
							player.controllers.hasKeyboard = hl.jsd;
						}
						if (this.loadMouseAssignments)
						{
							player.controllers.hasMouse = hl.jse;
						}
					}
				}
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x0008006C File Offset: 0x0007E26C
		private bool eqz(UserDataStore_PlayerPrefs.hn a)
		{
			try
			{
				if (ReInput.controllers.joystickCount == 0)
				{
					return false;
				}
				if (a == null && (a = this.era()) == null)
				{
					return false;
				}
				foreach (Player player in ReInput.players.AllPlayers)
				{
					player.controllers.ClearControllersOfType(ControllerType.Joystick);
				}
				List<UserDataStore_PlayerPrefs.ho> list = (this.loadJoystickAssignments ? new List<UserDataStore_PlayerPrefs.ho>() : null);
				foreach (Player player2 in ReInput.players.AllPlayers)
				{
					if (a.epf(player2.id))
					{
						UserDataStore_PlayerPrefs.hn.hl hl = a.jsj[a.epe(player2.id)];
						for (int i = 0; i < hl.lpo; i++)
						{
							UserDataStore_PlayerPrefs.hp hp = new UserDataStore_PlayerPrefs.hp();
							UserDataStore_PlayerPrefs.hn.hm hm = hl.jsf[i];
							if (hm != null)
							{
								hp.jsm = this.eso(hm);
								if (hp.jsm != null)
								{
									if (list.Find(new Predicate<UserDataStore_PlayerPrefs.ho>(hp.epj)) == null)
									{
										list.Add(new UserDataStore_PlayerPrefs.ho(hp.jsm, hm.jsi));
									}
									player2.controllers.AddController(hp.jsm, false);
								}
							}
						}
					}
				}
				if (this.jtb)
				{
					foreach (Player player3 in ReInput.players.AllPlayers)
					{
						if (a.epf(player3.id))
						{
							UserDataStore_PlayerPrefs.hn.hl hl2 = a.jsj[a.epe(player3.id)];
							for (int j = 0; j < hl2.lpo; j++)
							{
								UserDataStore_PlayerPrefs.hq hq = new UserDataStore_PlayerPrefs.hq();
								hq.jsn = hl2.jsf[j];
								if (hq.jsn != null)
								{
									Joystick joystick = null;
									int num = list.FindIndex(new Predicate<UserDataStore_PlayerPrefs.ho>(hq.epk));
									if (num >= 0)
									{
										joystick = list[num].jsk;
									}
									else
									{
										List<Joystick> list2;
										if (!this.esp(hq.jsn, out list2))
										{
											goto IL_029A;
										}
										using (List<Joystick>.Enumerator enumerator2 = list2.GetEnumerator())
										{
											while (enumerator2.MoveNext())
											{
												UserDataStore_PlayerPrefs.hr hr = new UserDataStore_PlayerPrefs.hr();
												hr.jso = enumerator2.Current;
												if (list.Find(new Predicate<UserDataStore_PlayerPrefs.ho>(hr.epl)) == null)
												{
													joystick = hr.jso;
													break;
												}
											}
										}
										if (joystick == null)
										{
											goto IL_029A;
										}
										list.Add(new UserDataStore_PlayerPrefs.ho(joystick, hq.jsn.jsi));
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

		// Token: 0x06001C19 RID: 7193 RVA: 0x000803D8 File Offset: 0x0007E5D8
		private UserDataStore_PlayerPrefs.hn era()
		{
			UserDataStore_PlayerPrefs.hn hn;
			try
			{
				if (!PlayerPrefs.HasKey(this.lpz))
				{
					hn = null;
				}
				else
				{
					string @string = PlayerPrefs.GetString(this.lpz);
					if (string.IsNullOrEmpty(@string))
					{
						hn = null;
					}
					else
					{
						UserDataStore_PlayerPrefs.hn hn2 = JsonParser.FromJson<UserDataStore_PlayerPrefs.hn>(@string);
						if (hn2 == null || hn2.lpp == 0)
						{
							hn = null;
						}
						else
						{
							hn = hn2;
						}
					}
				}
			}
			catch
			{
				hn = null;
			}
			return hn;
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x00080440 File Offset: 0x0007E640
		private IEnumerator erb()
		{
			this.jtc = true;
			yield return new WaitForEndOfFrame();
			if (!ReInput.isReady)
			{
				yield break;
			}
			this.eqz(null);
			this.eru();
			this.jtc = false;
			yield break;
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x00080450 File Offset: 0x0007E650
		private void erc()
		{
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				this.ere(allPlayers[i]);
			}
			this.erf();
			if (this.lqa)
			{
				this.eru();
			}
			PlayerPrefs.Save();
			for (int j = 0; j < allPlayers.Count; j++)
			{
				this.ess(allPlayers[j]);
			}
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x000804C0 File Offset: 0x0007E6C0
		private void erd(int a)
		{
			Player player = ReInput.players.GetPlayer(a);
			this.ere(player);
			PlayerPrefs.Save();
			this.ess(player);
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x000804EC File Offset: 0x0007E6EC
		private void ere(Player a)
		{
			if (a == null)
			{
				return;
			}
			PlayerSaveData saveData = a.GetSaveData(true);
			this.err(a, saveData);
			this.erl(a, saveData);
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x00080518 File Offset: 0x0007E718
		private void erf()
		{
			IList<Joystick> joysticks = ReInput.controllers.Joysticks;
			for (int i = 0; i < joysticks.Count; i++)
			{
				this.erh(joysticks[i]);
			}
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0008054E File Offset: 0x0007E74E
		private void erg(int a)
		{
			this.erh(ReInput.controllers.GetJoystick(a));
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x00080564 File Offset: 0x0007E764
		private void erh(Joystick a)
		{
			if (a == null)
			{
				return;
			}
			JoystickCalibrationMapSaveData calibrationMapSaveData = a.GetCalibrationMapSaveData();
			PlayerPrefs.SetString(this.ery(a), calibrationMapSaveData.map.ToXmlString());
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x00080594 File Offset: 0x0007E794
		private void eri(int a)
		{
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				Player player = allPlayers[i];
				if (player.controllers.ContainsController(ControllerType.Joystick, a))
				{
					this.erm(player.id, ControllerType.Joystick, a);
				}
			}
			this.erg(a);
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x000805E9 File Offset: 0x0007E7E9
		private void erj(int a, ControllerType b, int c)
		{
			this.erm(a, b, c);
			this.erk(b, c);
			PlayerPrefs.Save();
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x00080601 File Offset: 0x0007E801
		private void erk(ControllerType a, int b)
		{
			if (a == ControllerType.Joystick)
			{
				this.erg(b);
			}
			PlayerPrefs.Save();
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x00080614 File Offset: 0x0007E814
		private void erl(Player a, PlayerSaveData b)
		{
			List<ControllerMapSaveData> list = new List<ControllerMapSaveData>(b.AllControllerMapSaveData);
			if (this._actionMappingSaveMode == UserDataStore_PlayerPrefs.ActionMappingSaveMode.ByControllerElementRole)
			{
				list.Sort(new Comparison<ControllerMapSaveData>(UserDataStore_PlayerPrefs.esu));
			}
			for (int i = 0; i < list.Count; i++)
			{
				this.ern(a, list[i].map);
			}
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x00080670 File Offset: 0x0007E870
		private void erm(int a, ControllerType b, int c)
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
			if (this._actionMappingSaveMode == UserDataStore_PlayerPrefs.ActionMappingSaveMode.ByControllerElementRole)
			{
				List<ControllerMapSaveData> list = new List<ControllerMapSaveData>(mapSaveData);
				list.Sort(new Comparison<ControllerMapSaveData>(UserDataStore_PlayerPrefs.esu));
				list.CopyTo(mapSaveData);
			}
			for (int i = 0; i < mapSaveData.Length; i++)
			{
				this.ern(player, mapSaveData[i].map);
			}
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x000806FC File Offset: 0x0007E8FC
		private void ern(Player a, ControllerMap b)
		{
			UserDataStore_PlayerPrefs.ActionMappingSaveMode actionMappingSaveMode = this._actionMappingSaveMode;
			if (actionMappingSaveMode == UserDataStore_PlayerPrefs.ActionMappingSaveMode.ByController)
			{
				this.ero(a, b);
				return;
			}
			if (actionMappingSaveMode != UserDataStore_PlayerPrefs.ActionMappingSaveMode.ByControllerElementRole)
			{
				throw new NotImplementedException();
			}
			this.erp(a, b.controller, b);
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x00080738 File Offset: 0x0007E938
		private void ero(Player a, ControllerMap b)
		{
			PlayerPrefs.SetString(this.erw(a, b.controller.identifier, b.categoryId, b.layoutId, 2), b.ToXmlString());
			PlayerPrefs.SetString(this.erz(a, b.controller.identifier, b.categoryId, b.layoutId, 2), this.lqc);
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x0008079C File Offset: 0x0007E99C
		private void erp(Player a, Controller b, ControllerMap c)
		{
			if (b == null)
			{
				return;
			}
			this.ero(a, c);
			IList<ActionElementMap> elementMaps = c.ElementMaps;
			Dictionary<string, UserDataStore_PlayerPrefs.ControllerElementByRoleMap> dictionary = null;
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
							flag |= this.erq(a, c.controller, elementMaps[j], ref dictionary);
						}
					}
					if (!flag)
					{
						if (dictionary == null)
						{
							dictionary = new Dictionary<string, UserDataStore_PlayerPrefs.ControllerElementByRoleMap>();
						}
						dictionary.Add(role, new UserDataStore_PlayerPrefs.ControllerElementByRoleMap
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
			foreach (KeyValuePair<string, UserDataStore_PlayerPrefs.ControllerElementByRoleMap> keyValuePair in dictionary)
			{
				PlayerPrefs.SetString(this.erx(a, keyValuePair.Value.role, c.categoryId, c.layoutId, 0), keyValuePair.Value.eph());
			}
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x000808EC File Offset: 0x0007EAEC
		private bool erq(Player a, Controller b, ActionElementMap c, ref Dictionary<string, UserDataStore_PlayerPrefs.ControllerElementByRoleMap> d)
		{
			ControllerElementIdentifier elementIdentifierById = b.GetElementIdentifierById(c.elementIdentifierId);
			if (elementIdentifierById == null || string.IsNullOrEmpty(elementIdentifierById.role))
			{
				return false;
			}
			if (d == null)
			{
				d = new Dictionary<string, UserDataStore_PlayerPrefs.ControllerElementByRoleMap>();
			}
			UserDataStore_PlayerPrefs.ControllerElementByRoleMap controllerElementByRoleMap;
			if (!d.TryGetValue(elementIdentifierById.role, out controllerElementByRoleMap))
			{
				controllerElementByRoleMap = new UserDataStore_PlayerPrefs.ControllerElementByRoleMap();
				controllerElementByRoleMap.role = elementIdentifierById.role;
				d.Add(elementIdentifierById.role, controllerElementByRoleMap);
			}
			controllerElementByRoleMap.Add(c);
			return true;
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x00080960 File Offset: 0x0007EB60
		private void err(Player a, PlayerSaveData b)
		{
			if (a == null)
			{
				return;
			}
			InputBehavior[] inputBehaviors = b.inputBehaviors;
			for (int i = 0; i < inputBehaviors.Length; i++)
			{
				this.ert(a, inputBehaviors[i]);
			}
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x00080994 File Offset: 0x0007EB94
		private void ers(int a, int b)
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
			this.ert(player, inputBehavior);
			PlayerPrefs.Save();
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x000809CF File Offset: 0x0007EBCF
		private void ert(Player a, InputBehavior b)
		{
			if (a == null || b == null)
			{
				return;
			}
			PlayerPrefs.SetString(this.esa(a, b.id), b.ToXmlString());
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x000809F0 File Offset: 0x0007EBF0
		private bool eru()
		{
			try
			{
				UserDataStore_PlayerPrefs.hn hn = new UserDataStore_PlayerPrefs.hn(ReInput.players.allPlayerCount);
				for (int i = 0; i < ReInput.players.allPlayerCount; i++)
				{
					Player player = ReInput.players.AllPlayers[i];
					UserDataStore_PlayerPrefs.hn.hl hl = new UserDataStore_PlayerPrefs.hn.hl();
					hn.jsj[i] = hl;
					hl.jsc = player.id;
					hl.jsd = player.controllers.hasKeyboard;
					hl.jse = player.controllers.hasMouse;
					UserDataStore_PlayerPrefs.hn.hm[] array = new UserDataStore_PlayerPrefs.hn.hm[player.controllers.joystickCount];
					hl.jsf = array;
					for (int j = 0; j < player.controllers.joystickCount; j++)
					{
						Joystick joystick = player.controllers.Joysticks[j];
						array[j] = new UserDataStore_PlayerPrefs.hn.hm
						{
							jsg = joystick.deviceInstanceGuid,
							jsi = joystick.id,
							jsh = joystick.hardwareIdentifier
						};
					}
				}
				PlayerPrefs.SetString(this.lpz, JsonWriter.ToJson(hn));
				PlayerPrefs.Save();
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x00080B30 File Offset: 0x0007ED30
		private bool erv()
		{
			return PlayerPrefs.HasKey(this.lpz) && !string.IsNullOrEmpty(PlayerPrefs.GetString(this.lpz));
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x00080B58 File Offset: 0x0007ED58
		private string erw(Player a, ControllerIdentifier b, int c, int d, int e)
		{
			this.jtg.Length = 0;
			UserDataStore_PlayerPrefs.esb(this.jtg, this.playerPrefsKeyPrefix);
			UserDataStore_PlayerPrefs.esc(this.jtg, a);
			UserDataStore_PlayerPrefs.esd(this.jtg, a, b, c, d, e);
			return this.jtg.ToString();
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x00080BAC File Offset: 0x0007EDAC
		private string erx(Player a, string b, int c, int d, int e)
		{
			this.jtg.Length = 0;
			UserDataStore_PlayerPrefs.esb(this.jtg, this.playerPrefsKeyPrefix);
			UserDataStore_PlayerPrefs.esc(this.jtg, a);
			UserDataStore_PlayerPrefs.esg(this.jtg, b, c, d, e);
			return this.jtg.ToString();
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00080BFE File Offset: 0x0007EDFE
		private string ery(Joystick a)
		{
			this.jtg.Length = 0;
			UserDataStore_PlayerPrefs.esb(this.jtg, this.playerPrefsKeyPrefix);
			UserDataStore_PlayerPrefs.esh(this.jtg, a);
			return this.jtg.ToString();
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x00080C34 File Offset: 0x0007EE34
		private string erz(Player a, ControllerIdentifier b, int c, int d, int e)
		{
			this.jtg.Length = 0;
			UserDataStore_PlayerPrefs.esb(this.jtg, this.playerPrefsKeyPrefix);
			UserDataStore_PlayerPrefs.esc(this.jtg, a);
			UserDataStore_PlayerPrefs.ese(this.jtg, a, b, c, d, e);
			return this.jtg.ToString();
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00080C88 File Offset: 0x0007EE88
		private string esa(Player a, int b)
		{
			this.jtg.Length = 0;
			UserDataStore_PlayerPrefs.esb(this.jtg, this.playerPrefsKeyPrefix);
			UserDataStore_PlayerPrefs.esc(this.jtg, a);
			UserDataStore_PlayerPrefs.esi(this.jtg, b);
			return this.jtg.ToString();
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00080CD5 File Offset: 0x0007EED5
		private static void esb(StringBuilder a, string b)
		{
			a.Append(b);
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00080CDF File Offset: 0x0007EEDF
		private static void esc(StringBuilder a, Player b)
		{
			a.Append(a.enu());
			a.Append(b.name);
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00080CFA File Offset: 0x0007EEFA
		private static void esd(StringBuilder a, Player b, ControllerIdentifier c, int d, int e, int f)
		{
			a.Append(a.ena());
			UserDataStore_PlayerPrefs.esf(a, b, c, d, e, f);
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00080D15 File Offset: 0x0007EF15
		private static void ese(StringBuilder a, Player b, ControllerIdentifier c, int d, int e, int f)
		{
			a.Append(a.enb());
			UserDataStore_PlayerPrefs.esf(a, b, c, d, e, f);
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00080D30 File Offset: 0x0007EF30
		private static void esf(StringBuilder a, Player b, ControllerIdentifier c, int d, int e, int f)
		{
			if (f >= 2)
			{
				a.Append(a.enc());
				a.Append(f);
			}
			a.Append(a.end());
			a.Append(UserDataStore_PlayerPrefs.est(c.controllerType).Name);
			a.Append(a.ene());
			a.Append(d);
			a.Append(a.enl());
			a.Append(e);
			if (f >= 2)
			{
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
					a.Append(UserDataStore_PlayerPrefs.esq(b, c));
					return;
				}
			}
			else
			{
				a.Append(a.eni());
				a.Append(c.hardwareIdentifier);
				if (c.controllerType == ControllerType.Joystick)
				{
					a.Append(a.enh());
					a.Append(c.hardwareTypeGuid);
					if (f >= 1)
					{
						a.Append(a.enj());
						a.Append(UserDataStore_PlayerPrefs.esq(b, c));
					}
				}
			}
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x00080E80 File Offset: 0x0007F080
		private static void esg(StringBuilder a, string b, int c, int d, int e)
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

		// Token: 0x06001C3A RID: 7226 RVA: 0x00080EEC File Offset: 0x0007F0EC
		private static void esh(StringBuilder a, Joystick b)
		{
			a.Append(a.env());
			a.Append(a.eno());
			a.Append(b.type.ToString());
			a.Append(a.eni());
			a.Append(b.hardwareIdentifier);
			a.Append(a.enh());
			a.Append(b.hardwareTypeGuid.ToString());
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00080F6C File Offset: 0x0007F16C
		private static void esi(StringBuilder a, int b)
		{
			a.Append(a.enp());
			a.Append(a.enq());
			a.Append(b);
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00080F90 File Offset: 0x0007F190
		private string esj(Player a, ControllerIdentifier b, int c, int d)
		{
			for (int i = 2; i >= 0; i--)
			{
				string text = this.erw(a, b, c, d, i);
				if (PlayerPrefs.HasKey(text))
				{
					return PlayerPrefs.GetString(text);
				}
			}
			return null;
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x00080FC8 File Offset: 0x0007F1C8
		private List<int> esk(Player a, ControllerIdentifier b, int c, int d)
		{
			List<int> list = new List<int>();
			string text = null;
			bool flag = false;
			for (int i = 2; i >= 0; i--)
			{
				text = this.erz(a, b, c, d, i);
				if (PlayerPrefs.HasKey(text))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return list;
			}
			string @string = PlayerPrefs.GetString(text);
			if (string.IsNullOrEmpty(@string))
			{
				return list;
			}
			string[] array = @string.Split(',', StringSplitOptions.None);
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

		// Token: 0x06001C3E RID: 7230 RVA: 0x00081060 File Offset: 0x0007F260
		private string esl(Joystick a)
		{
			string text = this.ery(a);
			if (!PlayerPrefs.HasKey(text))
			{
				return string.Empty;
			}
			return PlayerPrefs.GetString(text);
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x0008108C File Offset: 0x0007F28C
		private string esm(Player a, int b)
		{
			string text = this.esa(a, b);
			if (!PlayerPrefs.HasKey(text))
			{
				return string.Empty;
			}
			return PlayerPrefs.GetString(text);
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x000810B8 File Offset: 0x0007F2B8
		private void esn(ControllerIdentifier a, ControllerMap b, List<int> c)
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
			foreach (int num in this.lqb)
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
					flag = true;
				}
			}
			if (flag)
			{
				b.isModified = false;
			}
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x00081208 File Offset: 0x0007F408
		private Joystick eso(UserDataStore_PlayerPrefs.hn.hm a)
		{
			if (a == null)
			{
				return null;
			}
			if (a.jsg == Guid.Empty)
			{
				return null;
			}
			IList<Joystick> joysticks = ReInput.controllers.Joysticks;
			for (int i = 0; i < joysticks.Count; i++)
			{
				if (joysticks[i].deviceInstanceGuid == a.jsg)
				{
					return joysticks[i];
				}
			}
			return null;
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x0008126C File Offset: 0x0007F46C
		private bool esp(UserDataStore_PlayerPrefs.hn.hm a, out List<Joystick> b)
		{
			b = null;
			if (a == null)
			{
				return false;
			}
			if (string.IsNullOrEmpty(a.jsh))
			{
				return false;
			}
			IList<Joystick> joysticks = ReInput.controllers.Joysticks;
			for (int i = 0; i < joysticks.Count; i++)
			{
				if (string.Equals(joysticks[i].hardwareIdentifier, a.jsh, StringComparison.OrdinalIgnoreCase))
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

		// Token: 0x06001C43 RID: 7235 RVA: 0x000812E4 File Offset: 0x0007F4E4
		private static int esq(Player a, ControllerIdentifier b)
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

		// Token: 0x06001C44 RID: 7236 RVA: 0x000813B4 File Offset: 0x0007F5B4
		private void esr(int a)
		{
			Player player = ReInput.players.GetPlayer(a);
			if (player == null)
			{
				return;
			}
			player.controllers.maps.layoutManager.Apply();
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x000813E8 File Offset: 0x0007F5E8
		private void ess(Player a)
		{
			if (this._actionMappingSaveMode == UserDataStore_PlayerPrefs.ActionMappingSaveMode.ByControllerElementRole)
			{
				int joystickCount = a.controllers.joystickCount;
				if (joystickCount > 1)
				{
					for (int i = 0; i < joystickCount; i++)
					{
						this.eqr(a.id, ControllerType.Joystick, a.controllers.Joysticks[i].id);
					}
					this.esr(a.id);
				}
			}
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x0008144C File Offset: 0x0007F64C
		private static Type est(ControllerType a)
		{
			switch (a)
			{
			case ControllerType.Keyboard:
				return typeof(KeyboardMap);
			case ControllerType.Mouse:
				return typeof(MouseMap);
			case ControllerType.Joystick:
				return typeof(JoystickMap);
			default:
				if (a == ControllerType.Custom)
				{
					return typeof(CustomControllerMap);
				}
				Debug.LogWarning(a.enw() + a.ToString());
				return null;
			}
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x000814BC File Offset: 0x0007F6BC
		private static int esu(ControllerMapSaveData a, ControllerMapSaveData b)
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

		// Token: 0x04000EB5 RID: 3765
		private const string jss = "UserDataStore_PlayerPrefs";

		// Token: 0x04000EB6 RID: 3766
		private const string jst = "Rewired: ";

		// Token: 0x04000EB7 RID: 3767
		private const string jsu = "ControllerAssignments";

		// Token: 0x04000EB8 RID: 3768
		private const int jsv = 0;

		// Token: 0x04000EB9 RID: 3769
		private const int jsw = 1;

		// Token: 0x04000EBA RID: 3770
		private const int jsx = 2;

		// Token: 0x04000EBB RID: 3771
		private const int jsy = 2;

		// Token: 0x04000EBC RID: 3772
		private const int jsz = 2;

		// Token: 0x04000EBD RID: 3773
		private const int jta = 0;

		// Token: 0x04000EBE RID: 3774
		[SerializeField]
		private bool isEnabled = true;

		// Token: 0x04000EBF RID: 3775
		[SerializeField]
		private bool loadDataOnStart = true;

		// Token: 0x04000EC0 RID: 3776
		[SerializeField]
		private bool loadJoystickAssignments = true;

		// Token: 0x04000EC1 RID: 3777
		[SerializeField]
		private bool loadKeyboardAssignments = true;

		// Token: 0x04000EC2 RID: 3778
		[SerializeField]
		private bool loadMouseAssignments = true;

		// Token: 0x04000EC3 RID: 3779
		[SerializeField]
		private UserDataStore_PlayerPrefs.ActionMappingSaveMode _actionMappingSaveMode;

		// Token: 0x04000EC4 RID: 3780
		[SerializeField]
		private string playerPrefsKeyPrefix = a.enx();

		// Token: 0x04000EC5 RID: 3781
		[NonSerialized]
		private bool jtb = true;

		// Token: 0x04000EC6 RID: 3782
		[NonSerialized]
		private bool jtc;

		// Token: 0x04000EC7 RID: 3783
		[NonSerialized]
		private bool jtd;

		// Token: 0x04000EC8 RID: 3784
		[NonSerialized]
		private List<int> jte;

		// Token: 0x04000EC9 RID: 3785
		[NonSerialized]
		private string jtf;

		// Token: 0x04000ECA RID: 3786
		[NonSerialized]
		private readonly StringBuilder jtg = new StringBuilder();

		// Token: 0x04000ECB RID: 3787
		[NonSerialized]
		private Dictionary<string, UserDataStore_PlayerPrefs.ControllerElementByRoleMap> jth;

		// Token: 0x04000ECC RID: 3788
		[NonSerialized]
		private Dictionary<string, bool> jti;

		// Token: 0x020001A3 RID: 419
		private class hn
		{
			// Token: 0x06001C49 RID: 7241 RVA: 0x0008155C File Offset: 0x0007F75C
			public int epe(int a)
			{
				for (int i = 0; i < this.lpp; i++)
				{
					if (this.jsj[i] != null && this.jsj[i].jsc == a)
					{
						return i;
					}
				}
				return -1;
			}

			// Token: 0x06001C4A RID: 7242 RVA: 0x00081598 File Offset: 0x0007F798
			public int jzl(int a)
			{
				for (int i = 0; i < this.lpp; i++)
				{
					if (this.jsj[i] != null && this.jsj[i].jsc == a)
					{
						return i;
					}
				}
				return -1;
			}

			// Token: 0x170003D0 RID: 976
			// (get) Token: 0x06001C4B RID: 7243 RVA: 0x000815D3 File Offset: 0x0007F7D3
			public int lpp
			{
				get
				{
					if (this.jsj == null)
					{
						return 0;
					}
					return this.jsj.Length;
				}
			}

			// Token: 0x06001C4C RID: 7244 RVA: 0x000815E8 File Offset: 0x0007F7E8
			public hn(int a)
			{
				this.jsj = new UserDataStore_PlayerPrefs.hn.hl[a];
				for (int i = 0; i < a; i++)
				{
					this.jsj[i] = new UserDataStore_PlayerPrefs.hn.hl();
				}
			}

			// Token: 0x06001C4D RID: 7245 RVA: 0x00081620 File Offset: 0x0007F820
			public int mma(int a)
			{
				for (int i = 0; i < this.lpp; i++)
				{
					if (this.jsj[i] != null && this.jsj[i].jsc == a)
					{
						return i;
					}
				}
				return -1;
			}

			// Token: 0x06001C4E RID: 7246 RVA: 0x0008165B File Offset: 0x0007F85B
			public bool epf(int a)
			{
				return this.epe(a) >= 0;
			}

			// Token: 0x06001C4F RID: 7247 RVA: 0x00002854 File Offset: 0x00000A54
			public hn()
			{
			}

			// Token: 0x06001C50 RID: 7248 RVA: 0x0008166C File Offset: 0x0007F86C
			public int nky(int a)
			{
				for (int i = 0; i < this.lpp; i++)
				{
					if (this.jsj[i] != null && this.jsj[i].jsc == a)
					{
						return i;
					}
				}
				return -1;
			}

			// Token: 0x06001C51 RID: 7249 RVA: 0x000816A8 File Offset: 0x0007F8A8
			public int ecu(int a)
			{
				for (int i = 0; i < this.lpp; i++)
				{
					if (this.jsj[i] != null && this.jsj[i].jsc == a)
					{
						return i;
					}
				}
				return -1;
			}

			// Token: 0x06001C52 RID: 7250 RVA: 0x0008165B File Offset: 0x0007F85B
			public bool evt(int a)
			{
				return this.epe(a) >= 0;
			}

			// Token: 0x04000ECD RID: 3789
			public UserDataStore_PlayerPrefs.hn.hl[] jsj;

			// Token: 0x020001A4 RID: 420
			public class hl
			{
				// Token: 0x06001C53 RID: 7251 RVA: 0x000816E3 File Offset: 0x0007F8E3
				public bool omb(int a)
				{
					return this.epb(a) >= 0;
				}

				// Token: 0x06001C54 RID: 7252 RVA: 0x000816F4 File Offset: 0x0007F8F4
				public int epb(int a)
				{
					for (int i = 0; i < this.lpo; i++)
					{
						if (this.jsf[i] != null && this.jsf[i].jsi == a)
						{
							return i;
						}
					}
					return -1;
				}

				// Token: 0x06001C55 RID: 7253 RVA: 0x00081730 File Offset: 0x0007F930
				public int eek(int a)
				{
					for (int i = 0; i < this.lpo; i++)
					{
						if (this.jsf[i] != null && this.jsf[i].jsi == a)
						{
							return i;
						}
					}
					return -1;
				}

				// Token: 0x170003D1 RID: 977
				// (get) Token: 0x06001C56 RID: 7254 RVA: 0x0008176B File Offset: 0x0007F96B
				public int lpo
				{
					get
					{
						if (this.jsf == null)
						{
							return 0;
						}
						return this.jsf.Length;
					}
				}

				// Token: 0x06001C57 RID: 7255 RVA: 0x00081780 File Offset: 0x0007F980
				public int dzu(int a)
				{
					for (int i = 0; i < this.lpo; i++)
					{
						if (this.jsf[i] != null && this.jsf[i].jsi == a)
						{
							return i;
						}
					}
					return -1;
				}

				// Token: 0x06001C59 RID: 7257 RVA: 0x000817BC File Offset: 0x0007F9BC
				public int dzk(int a)
				{
					for (int i = 0; i < this.lpo; i++)
					{
						if (this.jsf[i] != null && this.jsf[i].jsi == a)
						{
							return i;
						}
					}
					return -1;
				}

				// Token: 0x06001C5A RID: 7258 RVA: 0x000816E3 File Offset: 0x0007F8E3
				public bool epc(int a)
				{
					return this.epb(a) >= 0;
				}

				// Token: 0x06001C5B RID: 7259 RVA: 0x000816E3 File Offset: 0x0007F8E3
				public bool fyi(int a)
				{
					return this.epb(a) >= 0;
				}

				// Token: 0x06001C5C RID: 7260 RVA: 0x000817F8 File Offset: 0x0007F9F8
				public int fcx(int a)
				{
					for (int i = 0; i < this.lpo; i++)
					{
						if (this.jsf[i] != null && this.jsf[i].jsi == a)
						{
							return i;
						}
					}
					return -1;
				}

				// Token: 0x06001C5D RID: 7261 RVA: 0x000816E3 File Offset: 0x0007F8E3
				public bool lws(int a)
				{
					return this.epb(a) >= 0;
				}

				// Token: 0x04000ECE RID: 3790
				public int jsc;

				// Token: 0x04000ECF RID: 3791
				public bool jsd;

				// Token: 0x04000ED0 RID: 3792
				public bool jse;

				// Token: 0x04000ED1 RID: 3793
				public UserDataStore_PlayerPrefs.hn.hm[] jsf;
			}

			// Token: 0x020001A5 RID: 421
			public class hm
			{
				// Token: 0x04000ED2 RID: 3794
				public Guid jsg;

				// Token: 0x04000ED3 RID: 3795
				public string jsh;

				// Token: 0x04000ED4 RID: 3796
				public int jsi;
			}
		}

		// Token: 0x020001A6 RID: 422
		private class ho
		{
			// Token: 0x06001C5F RID: 7263 RVA: 0x00081833 File Offset: 0x0007FA33
			public ho(Joystick a, int b)
			{
				if (a == null)
				{
					throw new ArgumentNullException(a.eml());
				}
				this.jsk = a;
				this.jsl = b;
			}

			// Token: 0x04000ED5 RID: 3797
			public readonly Joystick jsk;

			// Token: 0x04000ED6 RID: 3798
			public readonly int jsl;
		}

		// Token: 0x020001A7 RID: 423
		[Serializable]
		private class ControllerElementByRoleMap
		{
			// Token: 0x06001C60 RID: 7264 RVA: 0x00081857 File Offset: 0x0007FA57
			[Preserve]
			public ControllerElementByRoleMap()
			{
				this.data = new List<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>();
			}

			// Token: 0x06001C61 RID: 7265 RVA: 0x0008186C File Offset: 0x0007FA6C
			public void Add(ActionElementMap elementMap)
			{
				this.data.Add(new UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry
				{
					actionId = elementMap.actionId,
					elementType = elementMap.elementType,
					axisRange = elementMap.axisRange,
					invert = elementMap.invert,
					axisContribution = elementMap.axisContribution
				});
			}

			// Token: 0x06001C62 RID: 7266 RVA: 0x000818D0 File Offset: 0x0007FAD0
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

			// Token: 0x06001C63 RID: 7267 RVA: 0x0007F11D File Offset: 0x0007D31D
			public string eph()
			{
				return JsonWriter.ToJson(this);
			}

			// Token: 0x06001C64 RID: 7268 RVA: 0x00081990 File Offset: 0x0007FB90
			public static UserDataStore_PlayerPrefs.ControllerElementByRoleMap epi(string a, string b)
			{
				UserDataStore_PlayerPrefs.ControllerElementByRoleMap controllerElementByRoleMap = JsonParser.FromJson<UserDataStore_PlayerPrefs.ControllerElementByRoleMap>(b);
				if (controllerElementByRoleMap != null)
				{
					controllerElementByRoleMap.role = a;
				}
				return controllerElementByRoleMap;
			}

			// Token: 0x04000ED7 RID: 3799
			[DoNotSerialize]
			public string role;

			// Token: 0x04000ED8 RID: 3800
			public List<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry> data;

			// Token: 0x020001A8 RID: 424
			[Serializable]
			public struct Entry
			{
				// Token: 0x06001C65 RID: 7269 RVA: 0x000819B0 File Offset: 0x0007FBB0
				public bool epg(ControllerType a, Controller.Element b, out ElementAssignment c)
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

				// Token: 0x06001C66 RID: 7270 RVA: 0x00081AB4 File Offset: 0x0007FCB4
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

				// Token: 0x04000ED9 RID: 3801
				public int actionId;

				// Token: 0x04000EDA RID: 3802
				public ControllerElementType elementType;

				// Token: 0x04000EDB RID: 3803
				public AxisRange axisRange;

				// Token: 0x04000EDC RID: 3804
				public bool invert;

				// Token: 0x04000EDD RID: 3805
				public Pole axisContribution;
			}
		}

		// Token: 0x020001A9 RID: 425
		public enum ActionMappingSaveMode
		{
			// Token: 0x04000EDF RID: 3807
			ByController,
			// Token: 0x04000EE0 RID: 3808
			ByControllerElementRole
		}

		// Token: 0x020001AA RID: 426
		[CompilerGenerated]
		private sealed class hp
		{
			// Token: 0x06001C67 RID: 7271 RVA: 0x00081B57 File Offset: 0x0007FD57
			internal bool lng(UserDataStore_PlayerPrefs.ho a)
			{
				return a.jsk == this.jsm;
			}

			// Token: 0x06001C68 RID: 7272 RVA: 0x00081B57 File Offset: 0x0007FD57
			internal bool epj(UserDataStore_PlayerPrefs.ho a)
			{
				return a.jsk == this.jsm;
			}

			// Token: 0x06001C6A RID: 7274 RVA: 0x00081B57 File Offset: 0x0007FD57
			internal bool bau(UserDataStore_PlayerPrefs.ho a)
			{
				return a.jsk == this.jsm;
			}

			// Token: 0x06001C6B RID: 7275 RVA: 0x00081B57 File Offset: 0x0007FD57
			internal bool hlp(UserDataStore_PlayerPrefs.ho a)
			{
				return a.jsk == this.jsm;
			}

			// Token: 0x06001C6C RID: 7276 RVA: 0x00081B57 File Offset: 0x0007FD57
			internal bool cyz(UserDataStore_PlayerPrefs.ho a)
			{
				return a.jsk == this.jsm;
			}

			// Token: 0x04000EE1 RID: 3809
			public Joystick jsm;
		}

		// Token: 0x020001AB RID: 427
		[CompilerGenerated]
		private sealed class hq
		{
			// Token: 0x06001C6D RID: 7277 RVA: 0x00081B67 File Offset: 0x0007FD67
			internal bool epk(UserDataStore_PlayerPrefs.ho a)
			{
				return a.jsl == this.jsn.jsi;
			}

			// Token: 0x06001C6E RID: 7278 RVA: 0x00081B67 File Offset: 0x0007FD67
			internal bool dmj(UserDataStore_PlayerPrefs.ho a)
			{
				return a.jsl == this.jsn.jsi;
			}

			// Token: 0x06001C70 RID: 7280 RVA: 0x00081B67 File Offset: 0x0007FD67
			internal bool dan(UserDataStore_PlayerPrefs.ho a)
			{
				return a.jsl == this.jsn.jsi;
			}

			// Token: 0x06001C71 RID: 7281 RVA: 0x00081B67 File Offset: 0x0007FD67
			internal bool bfg(UserDataStore_PlayerPrefs.ho a)
			{
				return a.jsl == this.jsn.jsi;
			}

			// Token: 0x04000EE2 RID: 3810
			public UserDataStore_PlayerPrefs.hn.hm jsn;
		}

		// Token: 0x020001AC RID: 428
		[CompilerGenerated]
		private sealed class hr
		{
			// Token: 0x06001C72 RID: 7282 RVA: 0x00081B7C File Offset: 0x0007FD7C
			internal bool htz(UserDataStore_PlayerPrefs.ho a)
			{
				return a.jsk == this.jso;
			}

			// Token: 0x06001C73 RID: 7283 RVA: 0x00081B7C File Offset: 0x0007FD7C
			internal bool epl(UserDataStore_PlayerPrefs.ho a)
			{
				return a.jsk == this.jso;
			}

			// Token: 0x04000EE3 RID: 3811
			public Joystick jso;
		}
	}
}
