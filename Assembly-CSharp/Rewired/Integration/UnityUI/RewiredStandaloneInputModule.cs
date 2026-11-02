using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Rewired.Components;
using Rewired.UI;
using Rewired.Utils;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace Rewired.Integration.UnityUI
{
	// Token: 0x020001B7 RID: 439
	public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule
	{
		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x0008309E File Offset: 0x0008129E
		// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x000830A6 File Offset: 0x000812A6
		public InputManager_Base lqw
		{
			get
			{
				return this.rewiredInputManager;
			}
			set
			{
				this.rewiredInputManager = value;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x000830AF File Offset: 0x000812AF
		// (set) Token: 0x06001CDB RID: 7387 RVA: 0x000830B7 File Offset: 0x000812B7
		public bool lqx
		{
			get
			{
				return this.useAllRewiredGamePlayers;
			}
			set
			{
				bool flag = value != this.useAllRewiredGamePlayers;
				this.useAllRewiredGamePlayers = value;
				if (flag)
				{
					this.eya();
				}
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x000830D4 File Offset: 0x000812D4
		// (set) Token: 0x06001CDD RID: 7389 RVA: 0x000830DC File Offset: 0x000812DC
		public bool lqy
		{
			get
			{
				return this.useRewiredSystemPlayer;
			}
			set
			{
				bool flag = value != this.useRewiredSystemPlayer;
				this.useRewiredSystemPlayer = value;
				if (flag)
				{
					this.eya();
				}
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x000830F9 File Offset: 0x000812F9
		// (set) Token: 0x06001CDF RID: 7391 RVA: 0x0008310B File Offset: 0x0008130B
		public int[] lqz
		{
			get
			{
				return (int[])this.rewiredPlayerIds.Clone();
			}
			set
			{
				this.rewiredPlayerIds = ((value != null) ? ((int[])value.Clone()) : new int[0]);
				this.eya();
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x0008312F File Offset: 0x0008132F
		// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x00083137 File Offset: 0x00081337
		public bool lra
		{
			get
			{
				return this.usePlayingPlayersOnly;
			}
			set
			{
				this.usePlayingPlayersOnly = value;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x00083140 File Offset: 0x00081340
		// (set) Token: 0x06001CE3 RID: 7395 RVA: 0x0008314D File Offset: 0x0008134D
		public List<PlayerMouse> lrb
		{
			get
			{
				return new List<PlayerMouse>(this.playerMice);
			}
			set
			{
				if (value == null)
				{
					this.playerMice = new List<PlayerMouse>();
					this.eya();
					return;
				}
				this.playerMice = new List<PlayerMouse>(value);
				this.eya();
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x00083176 File Offset: 0x00081376
		// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x0008317E File Offset: 0x0008137E
		public bool lrc
		{
			get
			{
				return this.moveOneElementPerAxisPress;
			}
			set
			{
				this.moveOneElementPerAxisPress = value;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x00083187 File Offset: 0x00081387
		// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x0008318F File Offset: 0x0008138F
		public bool lrd
		{
			get
			{
				return this.m_allowMouseInput;
			}
			set
			{
				this.m_allowMouseInput = value;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x00083198 File Offset: 0x00081398
		// (set) Token: 0x06001CE9 RID: 7401 RVA: 0x000831A0 File Offset: 0x000813A0
		public bool lre
		{
			get
			{
				return this.m_allowMouseInputIfTouchSupported;
			}
			set
			{
				this.m_allowMouseInputIfTouchSupported = value;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001CEA RID: 7402 RVA: 0x000831A9 File Offset: 0x000813A9
		// (set) Token: 0x06001CEB RID: 7403 RVA: 0x000831B1 File Offset: 0x000813B1
		public bool lrf
		{
			get
			{
				return this.m_allowTouchInput;
			}
			set
			{
				this.m_allowTouchInput = value;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001CEC RID: 7404 RVA: 0x000831BA File Offset: 0x000813BA
		// (set) Token: 0x06001CED RID: 7405 RVA: 0x000831C2 File Offset: 0x000813C2
		public bool lrg
		{
			get
			{
				return this.m_deselectIfBackgroundClicked;
			}
			set
			{
				this.m_deselectIfBackgroundClicked = value;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001CEE RID: 7406 RVA: 0x000831CB File Offset: 0x000813CB
		// (set) Token: 0x06001CEF RID: 7407 RVA: 0x000831D3 File Offset: 0x000813D3
		private bool lrh
		{
			get
			{
				return this.m_deselectBeforeSelecting;
			}
			set
			{
				this.m_deselectBeforeSelecting = value;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x000831DC File Offset: 0x000813DC
		// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x000831E4 File Offset: 0x000813E4
		public bool lri
		{
			get
			{
				return this.setActionsById;
			}
			set
			{
				if (this.setActionsById == value)
				{
					return;
				}
				this.setActionsById = value;
				this.eya();
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x000831FD File Offset: 0x000813FD
		// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x00083208 File Offset: 0x00081408
		public int lrj
		{
			get
			{
				return this.horizontalActionId;
			}
			set
			{
				if (value == this.horizontalActionId)
				{
					return;
				}
				this.horizontalActionId = value;
				if (ReInput.isReady)
				{
					this.m_HorizontalAxis = ((ReInput.mapping.GetAction(value) != null) ? ReInput.mapping.GetAction(value).name : string.Empty);
				}
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x00083257 File Offset: 0x00081457
		// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x00083260 File Offset: 0x00081460
		public int lrk
		{
			get
			{
				return this.verticalActionId;
			}
			set
			{
				if (value == this.verticalActionId)
				{
					return;
				}
				this.verticalActionId = value;
				if (ReInput.isReady)
				{
					this.m_VerticalAxis = ((ReInput.mapping.GetAction(value) != null) ? ReInput.mapping.GetAction(value).name : string.Empty);
				}
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x000832AF File Offset: 0x000814AF
		// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x000832B8 File Offset: 0x000814B8
		public int lrl
		{
			get
			{
				return this.submitActionId;
			}
			set
			{
				if (value == this.submitActionId)
				{
					return;
				}
				this.submitActionId = value;
				if (ReInput.isReady)
				{
					this.m_SubmitButton = ((ReInput.mapping.GetAction(value) != null) ? ReInput.mapping.GetAction(value).name : string.Empty);
				}
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x00083307 File Offset: 0x00081507
		// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x00083310 File Offset: 0x00081510
		public int lrm
		{
			get
			{
				return this.cancelActionId;
			}
			set
			{
				if (value == this.cancelActionId)
				{
					return;
				}
				this.cancelActionId = value;
				if (ReInput.isReady)
				{
					this.m_CancelButton = ((ReInput.mapping.GetAction(value) != null) ? ReInput.mapping.GetAction(value).name : string.Empty);
				}
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x0008335F File Offset: 0x0008155F
		protected override bool lqv
		{
			get
			{
				return base.lqv && this.m_allowMouseInput && (!this.jun || this.m_allowMouseInputIfTouchSupported);
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x000831A9 File Offset: 0x000813A9
		private bool lrn
		{
			get
			{
				return this.m_allowTouchInput;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x00083385 File Offset: 0x00081585
		// (set) Token: 0x06001CFD RID: 7421 RVA: 0x0008338D File Offset: 0x0008158D
		[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead")]
		public bool lro
		{
			get
			{
				return this.m_ForceModuleActive;
			}
			set
			{
				this.m_ForceModuleActive = value;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x00083385 File Offset: 0x00081585
		// (set) Token: 0x06001CFF RID: 7423 RVA: 0x0008338D File Offset: 0x0008158D
		public bool lrp
		{
			get
			{
				return this.m_ForceModuleActive;
			}
			set
			{
				this.m_ForceModuleActive = value;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x00083396 File Offset: 0x00081596
		// (set) Token: 0x06001D01 RID: 7425 RVA: 0x0008339E File Offset: 0x0008159E
		public float lrq
		{
			get
			{
				return this.m_InputActionsPerSecond;
			}
			set
			{
				this.m_InputActionsPerSecond = value;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x000833A7 File Offset: 0x000815A7
		// (set) Token: 0x06001D03 RID: 7427 RVA: 0x000833AF File Offset: 0x000815AF
		public float lrr
		{
			get
			{
				return this.m_RepeatDelay;
			}
			set
			{
				this.m_RepeatDelay = value;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x000833B8 File Offset: 0x000815B8
		// (set) Token: 0x06001D05 RID: 7429 RVA: 0x000833C0 File Offset: 0x000815C0
		public string lrs
		{
			get
			{
				return this.m_HorizontalAxis;
			}
			set
			{
				if (this.m_HorizontalAxis == value)
				{
					return;
				}
				this.m_HorizontalAxis = value;
				if (ReInput.isReady)
				{
					this.horizontalActionId = ReInput.mapping.GetActionId(value);
				}
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x000833F0 File Offset: 0x000815F0
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x000833F8 File Offset: 0x000815F8
		public string lrt
		{
			get
			{
				return this.m_VerticalAxis;
			}
			set
			{
				if (this.m_VerticalAxis == value)
				{
					return;
				}
				this.m_VerticalAxis = value;
				if (ReInput.isReady)
				{
					this.verticalActionId = ReInput.mapping.GetActionId(value);
				}
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x00083428 File Offset: 0x00081628
		// (set) Token: 0x06001D09 RID: 7433 RVA: 0x00083430 File Offset: 0x00081630
		public string lru
		{
			get
			{
				return this.m_SubmitButton;
			}
			set
			{
				if (this.m_SubmitButton == value)
				{
					return;
				}
				this.m_SubmitButton = value;
				if (ReInput.isReady)
				{
					this.submitActionId = ReInput.mapping.GetActionId(value);
				}
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x00083460 File Offset: 0x00081660
		// (set) Token: 0x06001D0B RID: 7435 RVA: 0x00083468 File Offset: 0x00081668
		public string lrv
		{
			get
			{
				return this.m_CancelButton;
			}
			set
			{
				if (this.m_CancelButton == value)
				{
					return;
				}
				this.m_CancelButton = value;
				if (ReInput.isReady)
				{
					this.cancelActionId = ReInput.mapping.GetActionId(value);
				}
			}
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x00083498 File Offset: 0x00081698
		private RewiredStandaloneInputModule()
		{
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x0008353F File Offset: 0x0008173F
		protected override void Awake()
		{
			base.Awake();
			this.jun = base.lqu.touchSupported;
			ReInput.InitializedEvent += this.eyn;
			this.exz();
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x0008356F File Offset: 0x0008176F
		public override void UpdateModule()
		{
			this.eyi();
			if (this.jum)
			{
				return;
			}
			if (!ReInput.isReady)
			{
				return;
			}
			if (!this.jur)
			{
				this.exy();
				return;
			}
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x0003AA83 File Offset: 0x00038C83
		public override bool IsModuleSupported()
		{
			return true;
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00083598 File Offset: 0x00081798
		public override bool ShouldActivateModule()
		{
			if (!base.ShouldActivateModule())
			{
				return false;
			}
			if (this.jum)
			{
				return false;
			}
			if (!ReInput.isReady)
			{
				return false;
			}
			bool flag = this.m_ForceModuleActive;
			for (int i = 0; i < this.jul.Length; i++)
			{
				Player player = ReInput.players.GetPlayer(this.jul[i]);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					flag |= this.eye(player, this.submitActionId);
					flag |= this.eye(player, this.cancelActionId);
					if (this.moveOneElementPerAxisPress)
					{
						flag |= this.eye(player, this.horizontalActionId) || this.eyg(player, this.horizontalActionId);
						flag |= this.eye(player, this.verticalActionId) || this.eyg(player, this.verticalActionId);
					}
					else
					{
						flag |= !Mathf.Approximately(this.eyh(player, this.horizontalActionId), 0f);
						flag |= !Mathf.Approximately(this.eyh(player, this.verticalActionId), 0f);
					}
				}
			}
			if (this.lqv)
			{
				flag |= this.eyl();
				flag |= this.eym(0);
			}
			if (this.lrn)
			{
				for (int j = 0; j < base.lqu.touchCount; j++)
				{
					Touch touch = base.lqu.GetTouch(j);
					flag |= touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary;
				}
			}
			return flag;
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00083724 File Offset: 0x00081924
		public override void ActivateModule()
		{
			if (!this.jur && this.exy())
			{
				return;
			}
			base.ActivateModule();
			GameObject gameObject = base.eventSystem.currentSelectedGameObject;
			if (gameObject == null)
			{
				gameObject = base.eventSystem.firstSelectedGameObject;
			}
			base.eventSystem.SetSelectedGameObject(gameObject, this.GetBaseEventData());
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x0008377B File Offset: 0x0008197B
		public override void DeactivateModule()
		{
			base.DeactivateModule();
			base.evj();
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x0008378C File Offset: 0x0008198C
		public override void Process()
		{
			if (!ReInput.isReady)
			{
				return;
			}
			if (!this.jur && this.exy())
			{
				return;
			}
			if (!base.enabled || !base.gameObject.activeInHierarchy)
			{
				return;
			}
			bool flag = this.exv();
			if (base.eventSystem.sendNavigationEvents)
			{
				if (!flag)
				{
					flag |= this.exr();
				}
				if (!flag)
				{
					this.exp();
				}
			}
			if (!this.exn() && this.lqv)
			{
				this.ext();
			}
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x00083808 File Offset: 0x00081A08
		private bool exn()
		{
			if (!this.lrn)
			{
				return false;
			}
			for (int i = 0; i < base.lqu.touchCount; i++)
			{
				Touch touch = base.lqu.GetTouch(i);
				if (touch.type != TouchType.Indirect)
				{
					bool flag;
					bool flag2;
					hu hu = base.evd(0, 0, touch, out flag, out flag2);
					this.exo(hu, flag, flag2);
					if (!flag2)
					{
						this.evh(hu);
						this.evi(hu);
					}
					else
					{
						base.evc(hu);
					}
				}
			}
			return base.lqu.touchCount > 0;
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00083890 File Offset: 0x00081A90
		private void exo(PointerEventData a, bool b, bool c)
		{
			GameObject gameObject = a.pointerCurrentRaycast.gameObject;
			if (b)
			{
				a.eligibleForClick = true;
				a.delta = Vector2.zero;
				a.dragging = false;
				a.useDragThreshold = true;
				a.pressPosition = a.position;
				a.pointerPressRaycast = a.pointerCurrentRaycast;
				this.exx(gameObject, a);
				if (a.pointerEnter != gameObject)
				{
					base.HandlePointerExitAndEnter(a, gameObject);
					a.pointerEnter = gameObject;
				}
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, a, ExecuteEvents.pointerDownHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				}
				double unscaledTime = ReInput.time.unscaledTime;
				if (gameObject2 == a.lastPress)
				{
					if (unscaledTime - (double)a.clickTime < 0.30000001192092896)
					{
						int num = a.clickCount + 1;
						a.clickCount = num;
					}
					else
					{
						a.clickCount = 1;
					}
					a.clickTime = (float)unscaledTime;
				}
				else
				{
					a.clickCount = 1;
				}
				a.pointerPress = gameObject2;
				a.rawPointerPress = gameObject;
				a.clickTime = (float)unscaledTime;
				a.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (a.pointerDrag != null)
				{
					ExecuteEvents.Execute<IInitializePotentialDragHandler>(a.pointerDrag, a, ExecuteEvents.initializePotentialDrag);
				}
			}
			if (c)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(a.pointerPress, a, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (a.pointerPress == eventHandler && a.eligibleForClick)
				{
					ExecuteEvents.Execute<IPointerClickHandler>(a.pointerPress, a, ExecuteEvents.pointerClickHandler);
				}
				else if (a.pointerDrag != null && a.dragging)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, a, ExecuteEvents.dropHandler);
				}
				a.eligibleForClick = false;
				a.pointerPress = null;
				a.rawPointerPress = null;
				if (a.pointerDrag != null && a.dragging)
				{
					ExecuteEvents.Execute<IEndDragHandler>(a.pointerDrag, a, ExecuteEvents.endDragHandler);
				}
				a.dragging = false;
				a.pointerDrag = null;
				if (a.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(a.pointerDrag, a, ExecuteEvents.endDragHandler);
				}
				a.pointerDrag = null;
				ExecuteEvents.ExecuteHierarchy<IPointerExitHandler>(a.pointerEnter, a, ExecuteEvents.pointerExitHandler);
				a.pointerEnter = null;
			}
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x00083AC0 File Offset: 0x00081CC0
		private bool exp()
		{
			if (base.eventSystem.currentSelectedGameObject == null)
			{
				return false;
			}
			if (this.jum)
			{
				return false;
			}
			BaseEventData baseEventData = this.GetBaseEventData();
			for (int i = 0; i < this.jul.Length; i++)
			{
				Player player = ReInput.players.GetPlayer(this.jul[i]);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					if (this.eye(player, this.submitActionId))
					{
						ExecuteEvents.Execute<ISubmitHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.submitHandler);
						break;
					}
					if (this.eye(player, this.cancelActionId))
					{
						ExecuteEvents.Execute<ICancelHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.cancelHandler);
						break;
					}
				}
			}
			return baseEventData.used;
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x00083B88 File Offset: 0x00081D88
		private Vector2 exq()
		{
			if (this.jum)
			{
				return Vector2.zero;
			}
			Vector2 zero = Vector2.zero;
			for (int i = 0; i < this.jul.Length; i++)
			{
				Player player = ReInput.players.GetPlayer(this.jul[i]);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					float num = this.eyh(player, this.horizontalActionId);
					float num2 = this.eyh(player, this.verticalActionId);
					if (Mathf.Approximately(num, 0f))
					{
						num = 0f;
					}
					if (Mathf.Approximately(num2, 0f))
					{
						num2 = 0f;
					}
					if (this.moveOneElementPerAxisPress)
					{
						if (this.eye(player, this.horizontalActionId) && num > 0f)
						{
							zero.x += 1f;
						}
						if (this.eyg(player, this.horizontalActionId) && num < 0f)
						{
							zero.x -= 1f;
						}
						if (this.eye(player, this.verticalActionId) && num2 > 0f)
						{
							zero.y += 1f;
						}
						if (this.eyg(player, this.verticalActionId) && num2 < 0f)
						{
							zero.y -= 1f;
						}
					}
					else
					{
						if (this.eyd(player, this.horizontalActionId) && num > 0f)
						{
							zero.x += 1f;
						}
						if (this.eyf(player, this.horizontalActionId) && num < 0f)
						{
							zero.x -= 1f;
						}
						if (this.eyd(player, this.verticalActionId) && num2 > 0f)
						{
							zero.y += 1f;
						}
						if (this.eyf(player, this.verticalActionId) && num2 < 0f)
						{
							zero.y -= 1f;
						}
					}
				}
			}
			return zero;
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x00083D88 File Offset: 0x00081F88
		private bool exr()
		{
			if (this.jum)
			{
				return false;
			}
			double unscaledTime = ReInput.time.unscaledTime;
			Vector2 vector = this.exq();
			if (Mathf.Approximately(vector.x, 0f) && Mathf.Approximately(vector.y, 0f))
			{
				this.juq = 0;
				return false;
			}
			bool flag = Vector2.Dot(vector, this.jup) > 0f;
			bool flag2;
			bool flag3;
			this.exs(out flag2, out flag3);
			AxisEventData axisEventData = null;
			bool flag4 = flag2 || flag3;
			if (flag4)
			{
				axisEventData = this.GetAxisEventData(vector.x, vector.y, 0f);
				MoveDirection moveDir = axisEventData.moveDir;
				flag4 = ((moveDir == MoveDirection.Up || moveDir == MoveDirection.Down) && flag3) || ((moveDir == MoveDirection.Left || moveDir == MoveDirection.Right) && flag2);
			}
			if (!flag4)
			{
				if (this.m_RepeatDelay > 0f)
				{
					if (flag && this.juq == 1)
					{
						flag4 = unscaledTime > this.juo + (double)this.m_RepeatDelay;
					}
					else
					{
						flag4 = unscaledTime > this.juo + (double)(1f / this.m_InputActionsPerSecond);
					}
				}
				else
				{
					flag4 = unscaledTime > this.juo + (double)(1f / this.m_InputActionsPerSecond);
				}
			}
			if (!flag4)
			{
				return false;
			}
			if (axisEventData == null)
			{
				axisEventData = this.GetAxisEventData(vector.x, vector.y, 0f);
			}
			if (axisEventData.moveDir != MoveDirection.None)
			{
				ExecuteEvents.Execute<IMoveHandler>(base.eventSystem.currentSelectedGameObject, axisEventData, ExecuteEvents.moveHandler);
				if (!flag)
				{
					this.juq = 0;
				}
				if (this.juq == 0 || (!flag2 && !flag3))
				{
					this.juq++;
				}
				this.juo = unscaledTime;
				this.jup = vector;
			}
			else
			{
				this.juq = 0;
			}
			return axisEventData.used;
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x00083F40 File Offset: 0x00082140
		private void exs(out bool a, out bool b)
		{
			a = false;
			b = false;
			for (int i = 0; i < this.jul.Length; i++)
			{
				Player player = ReInput.players.GetPlayer(this.jul[i]);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					a |= this.eye(player, this.horizontalActionId) || this.eyg(player, this.horizontalActionId);
					b |= this.eye(player, this.verticalActionId) || this.eyg(player, this.verticalActionId);
				}
			}
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00083FD8 File Offset: 0x000821D8
		private void ext()
		{
			for (int i = 0; i < this.jul.Length; i++)
			{
				Player player = ReInput.players.GetPlayer(this.jul[i]);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					int num = base.eus(this.jul[i]);
					for (int j = 0; j < num; j++)
					{
						this.exu(this.jul[i], j);
					}
				}
			}
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00084048 File Offset: 0x00082248
		private void exu(int a, int b)
		{
			RewiredPointerInputModule.hv hv = this.eve(a, b);
			if (hv == null)
			{
				return;
			}
			RewiredPointerInputModule.hw hw = hv.eto(0).lqg;
			this.exw(hw);
			this.evh(hw.jtt);
			this.evi(hw.jtt);
			this.exw(hv.eto(1).lqg);
			this.evi(hv.eto(1).lqg.jtt);
			this.exw(hv.eto(2).lqg);
			this.evi(hv.eto(2).lqg.jtt);
			IMouseInputSource mouseInputSource = base.eup(a, b);
			if (mouseInputSource == null)
			{
				return;
			}
			for (int i = 3; i < mouseInputSource.buttonCount; i++)
			{
				this.exw(hv.eto(i).lqg);
				this.evi(hv.eto(i).lqg.jtt);
			}
			if (!Mathf.Approximately(hw.jtt.scrollDelta.sqrMagnitude, 0f))
			{
				ExecuteEvents.ExecuteHierarchy<IScrollHandler>(ExecuteEvents.GetEventHandler<IScrollHandler>(hw.jtt.pointerCurrentRaycast.gameObject), hw.jtt, ExecuteEvents.scrollHandler);
			}
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x00084174 File Offset: 0x00082374
		private bool exv()
		{
			if (base.eventSystem.currentSelectedGameObject == null)
			{
				return false;
			}
			BaseEventData baseEventData = this.GetBaseEventData();
			ExecuteEvents.Execute<IUpdateSelectedHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.updateSelectedHandler);
			return baseEventData.used;
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x000841BC File Offset: 0x000823BC
		private void exw(RewiredPointerInputModule.hw a)
		{
			hu jtt = a.jtt;
			if (base.eup(jtt.jtl, jtt.jtm) == null)
			{
				return;
			}
			GameObject gameObject = jtt.pointerCurrentRaycast.gameObject;
			if (a.etq())
			{
				jtt.eligibleForClick = true;
				jtt.delta = Vector2.zero;
				jtt.dragging = false;
				jtt.useDragThreshold = true;
				jtt.pressPosition = jtt.position;
				jtt.pointerPressRaycast = jtt.pointerCurrentRaycast;
				this.exx(gameObject, jtt);
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, jtt, ExecuteEvents.pointerDownHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				}
				double unscaledTime = ReInput.time.unscaledTime;
				if (gameObject2 == jtt.lastPress)
				{
					if (unscaledTime - (double)jtt.clickTime < 0.30000001192092896)
					{
						hu hu = jtt;
						int num = hu.clickCount + 1;
						hu.clickCount = num;
					}
					else
					{
						jtt.clickCount = 1;
					}
					jtt.clickTime = (float)unscaledTime;
				}
				else
				{
					jtt.clickCount = 1;
				}
				jtt.pointerPress = gameObject2;
				jtt.rawPointerPress = gameObject;
				jtt.clickTime = (float)unscaledTime;
				jtt.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (jtt.pointerDrag != null)
				{
					ExecuteEvents.Execute<IInitializePotentialDragHandler>(jtt.pointerDrag, jtt, ExecuteEvents.initializePotentialDrag);
				}
			}
			if (a.etr())
			{
				ExecuteEvents.Execute<IPointerUpHandler>(jtt.pointerPress, jtt, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (jtt.pointerPress == eventHandler && jtt.eligibleForClick)
				{
					ExecuteEvents.Execute<IPointerClickHandler>(jtt.pointerPress, jtt, ExecuteEvents.pointerClickHandler);
				}
				else if (jtt.pointerDrag != null && jtt.dragging)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, jtt, ExecuteEvents.dropHandler);
				}
				jtt.eligibleForClick = false;
				jtt.pointerPress = null;
				jtt.rawPointerPress = null;
				if (jtt.pointerDrag != null && jtt.dragging)
				{
					ExecuteEvents.Execute<IEndDragHandler>(jtt.pointerDrag, jtt, ExecuteEvents.endDragHandler);
				}
				jtt.dragging = false;
				jtt.pointerDrag = null;
				if (gameObject != jtt.pointerEnter)
				{
					base.HandlePointerExitAndEnter(jtt, null);
					base.HandlePointerExitAndEnter(jtt, gameObject);
				}
			}
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x000843D8 File Offset: 0x000825D8
		private void exx(GameObject a, BaseEventData b)
		{
			if (this.m_deselectIfBackgroundClicked && this.m_deselectBeforeSelecting)
			{
				base.evk(a, b);
				return;
			}
			GameObject eventHandler = ExecuteEvents.GetEventHandler<ISelectHandler>(a);
			if (this.m_deselectIfBackgroundClicked)
			{
				if (eventHandler != base.eventSystem.currentSelectedGameObject && eventHandler != null)
				{
					base.eventSystem.SetSelectedGameObject(null, b);
					return;
				}
			}
			else if (this.m_deselectBeforeSelecting && eventHandler != null && eventHandler != base.eventSystem.currentSelectedGameObject)
			{
				base.eventSystem.SetSelectedGameObject(null, b);
			}
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x00084468 File Offset: 0x00082668
		private void OnApplicationFocus(bool hasFocus)
		{
			this.jur = hasFocus;
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x00084471 File Offset: 0x00082671
		private bool exy()
		{
			return !ReInput.isReady || ReInput.configuration.ignoreInputWhenAppNotInFocus;
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x00084486 File Offset: 0x00082686
		protected override void OnDestroy()
		{
			base.OnDestroy();
			ReInput.InitializedEvent -= this.eyn;
			ReInput.ShutDownEvent -= this.eyo;
			ReInput.EditorRecompileEvent -= this.eyj;
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x000844C4 File Offset: 0x000826C4
		protected override bool euz(int a)
		{
			if (this.jul == null)
			{
				return false;
			}
			if (!ReInput.isReady)
			{
				return false;
			}
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < this.jul.Length; j++)
				{
					Player player = ReInput.players.GetPlayer(this.jul[j]);
					if (player != null && (i >= 1 || !this.usePlayingPlayersOnly || player.isPlaying) && (i >= 2 || player.controllers.hasMouse))
					{
						return this.jul[j] == a;
					}
				}
			}
			return false;
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x0008454C File Offset: 0x0008274C
		private void exz()
		{
			if (!ReInput.isReady)
			{
				Debug.LogError(a.eop());
				return;
			}
			ReInput.ShutDownEvent -= this.eyo;
			ReInput.ShutDownEvent += this.eyo;
			ReInput.EditorRecompileEvent -= this.eyj;
			ReInput.EditorRecompileEvent += this.eyj;
			this.eya();
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x000845B8 File Offset: 0x000827B8
		private void eya()
		{
			if (!ReInput.isReady)
			{
				return;
			}
			this.eyc();
			if (this.useAllRewiredGamePlayers)
			{
				IList<Player> list = (this.useRewiredSystemPlayer ? ReInput.players.AllPlayers : ReInput.players.Players);
				this.jul = new int[list.Count];
				for (int i = 0; i < list.Count; i++)
				{
					this.jul[i] = list[i].id;
				}
			}
			else
			{
				bool flag = false;
				List<int> list2 = new List<int>(this.rewiredPlayerIds.Length + 1);
				for (int j = 0; j < this.rewiredPlayerIds.Length; j++)
				{
					Player player = ReInput.players.GetPlayer(this.rewiredPlayerIds[j]);
					if (player != null && !list2.Contains(player.id))
					{
						list2.Add(player.id);
						if (player.id == 9999999)
						{
							flag = true;
						}
					}
				}
				if (this.useRewiredSystemPlayer && !flag)
				{
					list2.Insert(0, ReInput.players.GetSystemPlayer().id);
				}
				this.jul = list2.ToArray();
			}
			this.eyb();
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x000846D8 File Offset: 0x000828D8
		private void eyb()
		{
			if (!ReInput.isReady)
			{
				return;
			}
			base.eux();
			for (int i = 0; i < this.playerMice.Count; i++)
			{
				PlayerMouse playerMouse = this.playerMice[i];
				if (!UnityTools.IsNullOrDestroyed<PlayerMouse>(playerMouse))
				{
					base.eur(playerMouse);
				}
			}
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x00084728 File Offset: 0x00082928
		private void eyc()
		{
			if (!ReInput.isReady)
			{
				return;
			}
			if (!this.setActionsById)
			{
				this.horizontalActionId = ReInput.mapping.GetActionId(this.m_HorizontalAxis);
				this.verticalActionId = ReInput.mapping.GetActionId(this.m_VerticalAxis);
				this.submitActionId = ReInput.mapping.GetActionId(this.m_SubmitButton);
				this.cancelActionId = ReInput.mapping.GetActionId(this.m_CancelButton);
				return;
			}
			InputAction inputAction = ReInput.mapping.GetAction(this.horizontalActionId);
			this.m_HorizontalAxis = ((inputAction != null) ? inputAction.name : string.Empty);
			if (inputAction == null)
			{
				this.horizontalActionId = -1;
			}
			inputAction = ReInput.mapping.GetAction(this.verticalActionId);
			this.m_VerticalAxis = ((inputAction != null) ? inputAction.name : string.Empty);
			if (inputAction == null)
			{
				this.verticalActionId = -1;
			}
			inputAction = ReInput.mapping.GetAction(this.submitActionId);
			this.m_SubmitButton = ((inputAction != null) ? inputAction.name : string.Empty);
			if (inputAction == null)
			{
				this.submitActionId = -1;
			}
			inputAction = ReInput.mapping.GetAction(this.cancelActionId);
			this.m_CancelButton = ((inputAction != null) ? inputAction.name : string.Empty);
			if (inputAction == null)
			{
				this.cancelActionId = -1;
			}
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x00084862 File Offset: 0x00082A62
		private bool eyd(Player a, int b)
		{
			return b >= 0 && a.GetButton(b);
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x00084871 File Offset: 0x00082A71
		private bool eye(Player a, int b)
		{
			return b >= 0 && a.GetButtonDown(b);
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x00084880 File Offset: 0x00082A80
		private bool eyf(Player a, int b)
		{
			return b >= 0 && a.GetNegativeButton(b);
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x0008488F File Offset: 0x00082A8F
		private bool eyg(Player a, int b)
		{
			return b >= 0 && a.GetNegativeButtonDown(b);
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x0008489E File Offset: 0x00082A9E
		private float eyh(Player a, int b)
		{
			if (b < 0)
			{
				return 0f;
			}
			return a.GetAxis(b);
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x000848B1 File Offset: 0x00082AB1
		private void eyi()
		{
			if (!this.jum)
			{
				return;
			}
			if (!ReInput.isReady)
			{
				return;
			}
			this.jum = false;
			this.exz();
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x000848D1 File Offset: 0x00082AD1
		private void eyj()
		{
			this.jum = true;
			this.eyk();
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x000848E0 File Offset: 0x00082AE0
		private void eyk()
		{
			Array.Clear(this.jul, 0, this.jul.Length);
			base.eux();
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x000848FC File Offset: 0x00082AFC
		private bool eyl()
		{
			for (int i = 0; i < this.jul.Length; i++)
			{
				int num = this.jul[i];
				Player player = ReInput.players.GetPlayer(num);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					int num2 = base.eus(num);
					for (int j = 0; j < num2; j++)
					{
						IMouseInputSource mouseInputSource = base.eup(num, j);
						if (mouseInputSource != null && mouseInputSource.screenPositionDelta.sqrMagnitude > 0f)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x00084988 File Offset: 0x00082B88
		private bool eym(int a)
		{
			for (int i = 0; i < this.jul.Length; i++)
			{
				int num = this.jul[i];
				Player player = ReInput.players.GetPlayer(num);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					int num2 = base.eus(num);
					for (int j = 0; j < num2; j++)
					{
						IMouseInputSource mouseInputSource = base.eup(num, j);
						if (mouseInputSource != null && mouseInputSource.GetButtonDown(a))
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x00084A04 File Offset: 0x00082C04
		private void eyn()
		{
			this.exz();
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x00084A0C File Offset: 0x00082C0C
		private void eyo()
		{
			this.eyk();
		}

		// Token: 0x04000F07 RID: 3847
		private const string juh = "UIHorizontal";

		// Token: 0x04000F08 RID: 3848
		private const string jui = "UIVertical";

		// Token: 0x04000F09 RID: 3849
		private const string juj = "UISubmit";

		// Token: 0x04000F0A RID: 3850
		private const string juk = "UICancel";

		// Token: 0x04000F0B RID: 3851
		[SerializeField]
		private InputManager_Base rewiredInputManager;

		// Token: 0x04000F0C RID: 3852
		[SerializeField]
		private bool useAllRewiredGamePlayers;

		// Token: 0x04000F0D RID: 3853
		[SerializeField]
		private bool useRewiredSystemPlayer;

		// Token: 0x04000F0E RID: 3854
		[SerializeField]
		private int[] rewiredPlayerIds = new int[1];

		// Token: 0x04000F0F RID: 3855
		[SerializeField]
		private bool usePlayingPlayersOnly;

		// Token: 0x04000F10 RID: 3856
		[SerializeField]
		private List<PlayerMouse> playerMice = new List<PlayerMouse>();

		// Token: 0x04000F11 RID: 3857
		[SerializeField]
		private bool moveOneElementPerAxisPress;

		// Token: 0x04000F12 RID: 3858
		[SerializeField]
		private bool setActionsById;

		// Token: 0x04000F13 RID: 3859
		[SerializeField]
		private int horizontalActionId = -1;

		// Token: 0x04000F14 RID: 3860
		[SerializeField]
		private int verticalActionId = -1;

		// Token: 0x04000F15 RID: 3861
		[SerializeField]
		private int submitActionId = -1;

		// Token: 0x04000F16 RID: 3862
		[SerializeField]
		private int cancelActionId = -1;

		// Token: 0x04000F17 RID: 3863
		[SerializeField]
		private string m_HorizontalAxis = a.eol();

		// Token: 0x04000F18 RID: 3864
		[SerializeField]
		private string m_VerticalAxis = a.eom();

		// Token: 0x04000F19 RID: 3865
		[SerializeField]
		private string m_SubmitButton = a.eon();

		// Token: 0x04000F1A RID: 3866
		[SerializeField]
		private string m_CancelButton = a.eoo();

		// Token: 0x04000F1B RID: 3867
		[SerializeField]
		private float m_InputActionsPerSecond = 10f;

		// Token: 0x04000F1C RID: 3868
		[SerializeField]
		private float m_RepeatDelay;

		// Token: 0x04000F1D RID: 3869
		[SerializeField]
		private bool m_allowMouseInput = true;

		// Token: 0x04000F1E RID: 3870
		[SerializeField]
		private bool m_allowMouseInputIfTouchSupported = true;

		// Token: 0x04000F1F RID: 3871
		[SerializeField]
		private bool m_allowTouchInput = true;

		// Token: 0x04000F20 RID: 3872
		[SerializeField]
		private bool m_deselectIfBackgroundClicked = true;

		// Token: 0x04000F21 RID: 3873
		[SerializeField]
		private bool m_deselectBeforeSelecting = true;

		// Token: 0x04000F22 RID: 3874
		[SerializeField]
		[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
		private bool m_ForceModuleActive;

		// Token: 0x04000F23 RID: 3875
		[NonSerialized]
		private int[] jul;

		// Token: 0x04000F24 RID: 3876
		private bool jum;

		// Token: 0x04000F25 RID: 3877
		[NonSerialized]
		private bool jun;

		// Token: 0x04000F26 RID: 3878
		[NonSerialized]
		private double juo;

		// Token: 0x04000F27 RID: 3879
		[NonSerialized]
		private Vector2 jup;

		// Token: 0x04000F28 RID: 3880
		[NonSerialized]
		private int juq;

		// Token: 0x04000F29 RID: 3881
		[NonSerialized]
		private bool jur = true;

		// Token: 0x020001B8 RID: 440
		[Serializable]
		public class PlayerSetting
		{
			// Token: 0x06001D33 RID: 7475 RVA: 0x00084A14 File Offset: 0x00082C14
			public PlayerSetting()
			{
			}

			// Token: 0x06001D34 RID: 7476 RVA: 0x00084A28 File Offset: 0x00082C28
			private PlayerSetting(RewiredStandaloneInputModule.PlayerSetting other)
			{
				if (other == null)
				{
					throw new ArgumentNullException(a.eok());
				}
				this.playerId = other.playerId;
				this.playerMice = new List<PlayerMouse>();
				if (other.playerMice != null)
				{
					foreach (PlayerMouse playerMouse in other.playerMice)
					{
						this.playerMice.Add(playerMouse);
					}
				}
			}

			// Token: 0x06001D35 RID: 7477 RVA: 0x00084AC0 File Offset: 0x00082CC0
			public RewiredStandaloneInputModule.PlayerSetting evn()
			{
				return new RewiredStandaloneInputModule.PlayerSetting(this);
			}

			// Token: 0x04000F2A RID: 3882
			public int playerId;

			// Token: 0x04000F2B RID: 3883
			public List<PlayerMouse> playerMice = new List<PlayerMouse>();
		}
	}
}
