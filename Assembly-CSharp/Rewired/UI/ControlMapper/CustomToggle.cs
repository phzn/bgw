using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200021F RID: 543
	public class CustomToggle : Toggle, kc, ICancelHandler, IEventSystemHandler
	{
		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x0600237E RID: 9086 RVA: 0x00098B73 File Offset: 0x00096D73
		// (set) Token: 0x0600237F RID: 9087 RVA: 0x00098B7B File Offset: 0x00096D7B
		public Sprite mbn
		{
			get
			{
				return this._disabledHighlightedSprite;
			}
			set
			{
				this._disabledHighlightedSprite = value;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x00098B84 File Offset: 0x00096D84
		// (set) Token: 0x06002381 RID: 9089 RVA: 0x00098B8C File Offset: 0x00096D8C
		public Color mbo
		{
			get
			{
				return this._disabledHighlightedColor;
			}
			set
			{
				this._disabledHighlightedColor = value;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06002382 RID: 9090 RVA: 0x00098B95 File Offset: 0x00096D95
		// (set) Token: 0x06002383 RID: 9091 RVA: 0x00098B9D File Offset: 0x00096D9D
		public string mbp
		{
			get
			{
				return this._disabledHighlightedTrigger;
			}
			set
			{
				this._disabledHighlightedTrigger = value;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06002384 RID: 9092 RVA: 0x00098BA6 File Offset: 0x00096DA6
		// (set) Token: 0x06002385 RID: 9093 RVA: 0x00098BAE File Offset: 0x00096DAE
		public bool mbq
		{
			get
			{
				return this._autoNavUp;
			}
			set
			{
				this._autoNavUp = value;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x00098BB7 File Offset: 0x00096DB7
		// (set) Token: 0x06002387 RID: 9095 RVA: 0x00098BBF File Offset: 0x00096DBF
		public bool mbr
		{
			get
			{
				return this._autoNavDown;
			}
			set
			{
				this._autoNavDown = value;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x00098BC8 File Offset: 0x00096DC8
		// (set) Token: 0x06002389 RID: 9097 RVA: 0x00098BD0 File Offset: 0x00096DD0
		public bool mbs
		{
			get
			{
				return this._autoNavLeft;
			}
			set
			{
				this._autoNavLeft = value;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x00098BD9 File Offset: 0x00096DD9
		// (set) Token: 0x0600238B RID: 9099 RVA: 0x00098BE1 File Offset: 0x00096DE1
		public bool mbt
		{
			get
			{
				return this._autoNavRight;
			}
			set
			{
				this._autoNavRight = value;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x0600238C RID: 9100 RVA: 0x00098249 File Offset: 0x00096449
		private bool mbw
		{
			get
			{
				return !this.IsInteractable();
			}
		}

		// Token: 0x14000057 RID: 87
		// (add) Token: 0x0600238D RID: 9101 RVA: 0x00098BEC File Offset: 0x00096DEC
		// (remove) Token: 0x0600238E RID: 9102 RVA: 0x00098C24 File Offset: 0x00096E24
		private event UnityAction kfi;

		// Token: 0x14000058 RID: 88
		// (add) Token: 0x0600238F RID: 9103 RVA: 0x00098C59 File Offset: 0x00096E59
		// (remove) Token: 0x06002390 RID: 9104 RVA: 0x00098C62 File Offset: 0x00096E62
		public event UnityAction mhr
		{
			add
			{
				this.kfi += value;
			}
			remove
			{
				this.kfi -= value;
			}
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x00098C6C File Offset: 0x00096E6C
		public override Selectable FindSelectableOnLeft()
		{
			if ((base.navigation.mode & Navigation.Mode.Horizontal) != Navigation.Mode.None || this._autoNavLeft)
			{
				return kn.grc(this, base.transform, Vector3.left);
			}
			return base.FindSelectableOnLeft();
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x00098CAC File Offset: 0x00096EAC
		public override Selectable FindSelectableOnRight()
		{
			if ((base.navigation.mode & Navigation.Mode.Horizontal) != Navigation.Mode.None || this._autoNavRight)
			{
				return kn.grc(this, base.transform, Vector3.right);
			}
			return base.FindSelectableOnRight();
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x00098CEC File Offset: 0x00096EEC
		public override Selectable FindSelectableOnUp()
		{
			if ((base.navigation.mode & Navigation.Mode.Vertical) != Navigation.Mode.None || this._autoNavUp)
			{
				return kn.grc(this, base.transform, Vector3.up);
			}
			return base.FindSelectableOnUp();
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x00098D2C File Offset: 0x00096F2C
		public override Selectable FindSelectableOnDown()
		{
			if ((base.navigation.mode & Navigation.Mode.Vertical) != Navigation.Mode.None || this._autoNavDown)
			{
				return kn.grc(this, base.transform, Vector3.down);
			}
			return base.FindSelectableOnDown();
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x00098D6B File Offset: 0x00096F6B
		protected override void OnCanvasGroupChanged()
		{
			base.OnCanvasGroupChanged();
			if (EventSystem.current == null)
			{
				return;
			}
			this.gja(EventSystem.current.currentSelectedGameObject == base.gameObject);
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x00098D9C File Offset: 0x00096F9C
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			if (this.kfh)
			{
				Color disabledHighlightedColor = this._disabledHighlightedColor;
				Sprite disabledHighlightedSprite = this._disabledHighlightedSprite;
				string disabledHighlightedTrigger = this._disabledHighlightedTrigger;
				if (base.gameObject.activeInHierarchy)
				{
					switch (base.transition)
					{
					case Selectable.Transition.ColorTint:
						this.gix(disabledHighlightedColor * base.colors.colorMultiplier, instant);
						return;
					case Selectable.Transition.SpriteSwap:
						this.giy(disabledHighlightedSprite);
						return;
					case Selectable.Transition.Animation:
						this.giz(disabledHighlightedTrigger);
						return;
					default:
						return;
					}
				}
			}
			else
			{
				base.DoStateTransition(state, instant);
			}
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x00098E24 File Offset: 0x00097024
		private void gix(Color a, bool b)
		{
			if (base.targetGraphic == null)
			{
				return;
			}
			base.targetGraphic.CrossFadeColor(a, b ? 0f : base.colors.fadeDuration, true, true);
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x000984CE File Offset: 0x000966CE
		private void giy(Sprite a)
		{
			if (base.image == null)
			{
				return;
			}
			base.image.overrideSprite = a;
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x00098E68 File Offset: 0x00097068
		private void giz(string a)
		{
			if (base.animator == null || !base.animator.enabled || !base.animator.isActiveAndEnabled || base.animator.runtimeAnimatorController == null || string.IsNullOrEmpty(a))
			{
				return;
			}
			base.animator.ResetTrigger(this._disabledHighlightedTrigger);
			base.animator.SetTrigger(a);
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x00098ED6 File Offset: 0x000970D6
		public override void OnSelect(BaseEventData eventData)
		{
			base.OnSelect(eventData);
			this.gja(true);
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x00098EE6 File Offset: 0x000970E6
		public override void OnDeselect(BaseEventData eventData)
		{
			base.OnDeselect(eventData);
			this.gja(false);
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x00098EF8 File Offset: 0x000970F8
		private void gja(bool a)
		{
			if (!a)
			{
				if (this.kfh)
				{
					this.kfh = false;
					Selectable.SelectionState selectionState = (this.mbw ? Selectable.SelectionState.Disabled : base.currentSelectionState);
					this.DoStateTransition(selectionState, false);
					return;
				}
			}
			else
			{
				if (!this.mbw)
				{
					return;
				}
				this.kfh = true;
				this.DoStateTransition(Selectable.SelectionState.Disabled, false);
			}
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x00098F4A File Offset: 0x0009714A
		public void OnCancel(BaseEventData eventData)
		{
			if (this.kfi != null)
			{
				this.kfi();
			}
		}

		// Token: 0x04001134 RID: 4404
		[SerializeField]
		private Sprite _disabledHighlightedSprite;

		// Token: 0x04001135 RID: 4405
		[SerializeField]
		private Color _disabledHighlightedColor;

		// Token: 0x04001136 RID: 4406
		[SerializeField]
		private string _disabledHighlightedTrigger;

		// Token: 0x04001137 RID: 4407
		[SerializeField]
		private bool _autoNavUp = true;

		// Token: 0x04001138 RID: 4408
		[SerializeField]
		private bool _autoNavDown = true;

		// Token: 0x04001139 RID: 4409
		[SerializeField]
		private bool _autoNavLeft = true;

		// Token: 0x0400113A RID: 4410
		[SerializeField]
		private bool _autoNavRight = true;

		// Token: 0x0400113B RID: 4411
		private bool kfh;
	}
}
