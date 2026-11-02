using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200021E RID: 542
	public class CustomSlider : Slider, kc, ICancelHandler, IEventSystemHandler
	{
		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x0600235D RID: 9053 RVA: 0x00098765 File Offset: 0x00096965
		// (set) Token: 0x0600235E RID: 9054 RVA: 0x0009876D File Offset: 0x0009696D
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

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x0600235F RID: 9055 RVA: 0x00098776 File Offset: 0x00096976
		// (set) Token: 0x06002360 RID: 9056 RVA: 0x0009877E File Offset: 0x0009697E
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

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06002361 RID: 9057 RVA: 0x00098787 File Offset: 0x00096987
		// (set) Token: 0x06002362 RID: 9058 RVA: 0x0009878F File Offset: 0x0009698F
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

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06002363 RID: 9059 RVA: 0x00098798 File Offset: 0x00096998
		// (set) Token: 0x06002364 RID: 9060 RVA: 0x000987A0 File Offset: 0x000969A0
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

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06002365 RID: 9061 RVA: 0x000987A9 File Offset: 0x000969A9
		// (set) Token: 0x06002366 RID: 9062 RVA: 0x000987B1 File Offset: 0x000969B1
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

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x000987BA File Offset: 0x000969BA
		// (set) Token: 0x06002368 RID: 9064 RVA: 0x000987C2 File Offset: 0x000969C2
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

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x000987CB File Offset: 0x000969CB
		// (set) Token: 0x0600236A RID: 9066 RVA: 0x000987D3 File Offset: 0x000969D3
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

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x00098249 File Offset: 0x00096449
		private bool mbv
		{
			get
			{
				return !this.IsInteractable();
			}
		}

		// Token: 0x14000055 RID: 85
		// (add) Token: 0x0600236C RID: 9068 RVA: 0x000987DC File Offset: 0x000969DC
		// (remove) Token: 0x0600236D RID: 9069 RVA: 0x00098814 File Offset: 0x00096A14
		private event UnityAction kfg;

		// Token: 0x14000056 RID: 86
		// (add) Token: 0x0600236E RID: 9070 RVA: 0x00098849 File Offset: 0x00096A49
		// (remove) Token: 0x0600236F RID: 9071 RVA: 0x00098852 File Offset: 0x00096A52
		public event UnityAction mhr
		{
			add
			{
				this.kfg += value;
			}
			remove
			{
				this.kfg -= value;
			}
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x0009885C File Offset: 0x00096A5C
		public override Selectable FindSelectableOnLeft()
		{
			if ((base.navigation.mode & Navigation.Mode.Horizontal) != Navigation.Mode.None || this._autoNavLeft)
			{
				return kn.grc(this, base.transform, Vector3.left);
			}
			return base.FindSelectableOnLeft();
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x0009889C File Offset: 0x00096A9C
		public override Selectable FindSelectableOnRight()
		{
			if ((base.navigation.mode & Navigation.Mode.Horizontal) != Navigation.Mode.None || this._autoNavRight)
			{
				return kn.grc(this, base.transform, Vector3.right);
			}
			return base.FindSelectableOnRight();
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x000988DC File Offset: 0x00096ADC
		public override Selectable FindSelectableOnUp()
		{
			if ((base.navigation.mode & Navigation.Mode.Vertical) != Navigation.Mode.None || this._autoNavUp)
			{
				return kn.grc(this, base.transform, Vector3.up);
			}
			return base.FindSelectableOnUp();
		}

		// Token: 0x06002373 RID: 9075 RVA: 0x0009891C File Offset: 0x00096B1C
		public override Selectable FindSelectableOnDown()
		{
			if ((base.navigation.mode & Navigation.Mode.Vertical) != Navigation.Mode.None || this._autoNavDown)
			{
				return kn.grc(this, base.transform, Vector3.down);
			}
			return base.FindSelectableOnDown();
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x0009895B File Offset: 0x00096B5B
		protected override void OnCanvasGroupChanged()
		{
			base.OnCanvasGroupChanged();
			if (EventSystem.current == null)
			{
				return;
			}
			this.git(EventSystem.current.currentSelectedGameObject == base.gameObject);
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x0009898C File Offset: 0x00096B8C
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			if (this.kff)
			{
				Color disabledHighlightedColor = this._disabledHighlightedColor;
				Sprite disabledHighlightedSprite = this._disabledHighlightedSprite;
				string disabledHighlightedTrigger = this._disabledHighlightedTrigger;
				if (base.gameObject.activeInHierarchy)
				{
					switch (base.transition)
					{
					case Selectable.Transition.ColorTint:
						this.giq(disabledHighlightedColor * base.colors.colorMultiplier, instant);
						return;
					case Selectable.Transition.SpriteSwap:
						this.gir(disabledHighlightedSprite);
						return;
					case Selectable.Transition.Animation:
						this.gis(disabledHighlightedTrigger);
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

		// Token: 0x06002376 RID: 9078 RVA: 0x00098A14 File Offset: 0x00096C14
		private void giq(Color a, bool b)
		{
			if (base.targetGraphic == null)
			{
				return;
			}
			base.targetGraphic.CrossFadeColor(a, b ? 0f : base.colors.fadeDuration, true, true);
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x000984CE File Offset: 0x000966CE
		private void gir(Sprite a)
		{
			if (base.image == null)
			{
				return;
			}
			base.image.overrideSprite = a;
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x00098A58 File Offset: 0x00096C58
		private void gis(string a)
		{
			if (base.animator == null || !base.animator.enabled || !base.animator.isActiveAndEnabled || base.animator.runtimeAnimatorController == null || string.IsNullOrEmpty(a))
			{
				return;
			}
			base.animator.ResetTrigger(this._disabledHighlightedTrigger);
			base.animator.SetTrigger(a);
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x00098AC6 File Offset: 0x00096CC6
		public override void OnSelect(BaseEventData eventData)
		{
			base.OnSelect(eventData);
			this.git(true);
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x00098AD6 File Offset: 0x00096CD6
		public override void OnDeselect(BaseEventData eventData)
		{
			base.OnDeselect(eventData);
			this.git(false);
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x00098AE8 File Offset: 0x00096CE8
		private void git(bool a)
		{
			if (!a)
			{
				if (this.kff)
				{
					this.kff = false;
					Selectable.SelectionState selectionState = (this.mbv ? Selectable.SelectionState.Disabled : base.currentSelectionState);
					this.DoStateTransition(selectionState, false);
					return;
				}
			}
			else
			{
				if (!this.mbv)
				{
					return;
				}
				this.kff = true;
				this.DoStateTransition(Selectable.SelectionState.Disabled, false);
			}
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x00098B3A File Offset: 0x00096D3A
		public void OnCancel(BaseEventData eventData)
		{
			if (this.kfg != null)
			{
				this.kfg();
			}
		}

		// Token: 0x0400112B RID: 4395
		[SerializeField]
		private Sprite _disabledHighlightedSprite;

		// Token: 0x0400112C RID: 4396
		[SerializeField]
		private Color _disabledHighlightedColor;

		// Token: 0x0400112D RID: 4397
		[SerializeField]
		private string _disabledHighlightedTrigger;

		// Token: 0x0400112E RID: 4398
		[SerializeField]
		private bool _autoNavUp = true;

		// Token: 0x0400112F RID: 4399
		[SerializeField]
		private bool _autoNavDown = true;

		// Token: 0x04001130 RID: 4400
		[SerializeField]
		private bool _autoNavLeft = true;

		// Token: 0x04001131 RID: 4401
		[SerializeField]
		private bool _autoNavRight = true;

		// Token: 0x04001132 RID: 4402
		private bool kff;
	}
}
