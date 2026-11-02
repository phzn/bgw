using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200021C RID: 540
	public class CustomButton : Button, kc, ICancelHandler, IEventSystemHandler
	{
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x000981D2 File Offset: 0x000963D2
		// (set) Token: 0x06002333 RID: 9011 RVA: 0x000981DA File Offset: 0x000963DA
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

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x000981E3 File Offset: 0x000963E3
		// (set) Token: 0x06002335 RID: 9013 RVA: 0x000981EB File Offset: 0x000963EB
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

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x000981F4 File Offset: 0x000963F4
		// (set) Token: 0x06002337 RID: 9015 RVA: 0x000981FC File Offset: 0x000963FC
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

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x00098205 File Offset: 0x00096405
		// (set) Token: 0x06002339 RID: 9017 RVA: 0x0009820D File Offset: 0x0009640D
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

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x00098216 File Offset: 0x00096416
		// (set) Token: 0x0600233B RID: 9019 RVA: 0x0009821E File Offset: 0x0009641E
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

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x00098227 File Offset: 0x00096427
		// (set) Token: 0x0600233D RID: 9021 RVA: 0x0009822F File Offset: 0x0009642F
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

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x0600233E RID: 9022 RVA: 0x00098238 File Offset: 0x00096438
		// (set) Token: 0x0600233F RID: 9023 RVA: 0x00098240 File Offset: 0x00096440
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

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x00098249 File Offset: 0x00096449
		private bool mbu
		{
			get
			{
				return !this.IsInteractable();
			}
		}

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x06002341 RID: 9025 RVA: 0x00098254 File Offset: 0x00096454
		// (remove) Token: 0x06002342 RID: 9026 RVA: 0x0009828C File Offset: 0x0009648C
		private event UnityAction kfe;

		// Token: 0x14000054 RID: 84
		// (add) Token: 0x06002343 RID: 9027 RVA: 0x000982C1 File Offset: 0x000964C1
		// (remove) Token: 0x06002344 RID: 9028 RVA: 0x000982CA File Offset: 0x000964CA
		public event UnityAction mhr
		{
			add
			{
				this.kfe += value;
			}
			remove
			{
				this.kfe -= value;
			}
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x000982D4 File Offset: 0x000964D4
		public override Selectable FindSelectableOnLeft()
		{
			if ((base.navigation.mode & Navigation.Mode.Horizontal) != Navigation.Mode.None || this._autoNavLeft)
			{
				return kn.grc(this, base.transform, Vector3.left);
			}
			return base.FindSelectableOnLeft();
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x00098314 File Offset: 0x00096514
		public override Selectable FindSelectableOnRight()
		{
			if ((base.navigation.mode & Navigation.Mode.Horizontal) != Navigation.Mode.None || this._autoNavRight)
			{
				return kn.grc(this, base.transform, Vector3.right);
			}
			return base.FindSelectableOnRight();
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x00098354 File Offset: 0x00096554
		public override Selectable FindSelectableOnUp()
		{
			if ((base.navigation.mode & Navigation.Mode.Vertical) != Navigation.Mode.None || this._autoNavUp)
			{
				return kn.grc(this, base.transform, Vector3.up);
			}
			return base.FindSelectableOnUp();
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x00098394 File Offset: 0x00096594
		public override Selectable FindSelectableOnDown()
		{
			if ((base.navigation.mode & Navigation.Mode.Vertical) != Navigation.Mode.None || this._autoNavDown)
			{
				return kn.grc(this, base.transform, Vector3.down);
			}
			return base.FindSelectableOnDown();
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x000983D3 File Offset: 0x000965D3
		protected override void OnCanvasGroupChanged()
		{
			base.OnCanvasGroupChanged();
			if (EventSystem.current == null)
			{
				return;
			}
			this.gim(EventSystem.current.currentSelectedGameObject == base.gameObject);
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x00098404 File Offset: 0x00096604
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			if (this.kfd)
			{
				Color disabledHighlightedColor = this._disabledHighlightedColor;
				Sprite disabledHighlightedSprite = this._disabledHighlightedSprite;
				string disabledHighlightedTrigger = this._disabledHighlightedTrigger;
				if (base.gameObject.activeInHierarchy)
				{
					switch (base.transition)
					{
					case Selectable.Transition.ColorTint:
						this.gih(disabledHighlightedColor * base.colors.colorMultiplier, instant);
						return;
					case Selectable.Transition.SpriteSwap:
						this.gii(disabledHighlightedSprite);
						return;
					case Selectable.Transition.Animation:
						this.gij(disabledHighlightedTrigger);
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

		// Token: 0x0600234B RID: 9035 RVA: 0x0009848C File Offset: 0x0009668C
		private void gih(Color a, bool b)
		{
			if (base.targetGraphic == null)
			{
				return;
			}
			base.targetGraphic.CrossFadeColor(a, b ? 0f : base.colors.fadeDuration, true, true);
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x000984CE File Offset: 0x000966CE
		private void gii(Sprite a)
		{
			if (base.image == null)
			{
				return;
			}
			base.image.overrideSprite = a;
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x000984EC File Offset: 0x000966EC
		private void gij(string a)
		{
			if (base.animator == null || !base.animator.enabled || !base.animator.isActiveAndEnabled || base.animator.runtimeAnimatorController == null || string.IsNullOrEmpty(a))
			{
				return;
			}
			base.animator.ResetTrigger(this._disabledHighlightedTrigger);
			base.animator.SetTrigger(a);
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x0009855A File Offset: 0x0009675A
		public override void OnSelect(BaseEventData eventData)
		{
			base.OnSelect(eventData);
			this.gim(true);
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x0009856A File Offset: 0x0009676A
		public override void OnDeselect(BaseEventData eventData)
		{
			base.OnDeselect(eventData);
			this.gim(false);
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x0009857A File Offset: 0x0009677A
		private void gik()
		{
			if (!this.IsActive() || !this.IsInteractable())
			{
				return;
			}
			base.onClick.Invoke();
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x00098598 File Offset: 0x00096798
		public override void OnPointerClick(PointerEventData eventData)
		{
			if (!this.IsActive() || !this.IsInteractable())
			{
				return;
			}
			if (eventData.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.gik();
			if (!this.IsActive() || !this.IsInteractable())
			{
				this.kfd = true;
				this.DoStateTransition(Selectable.SelectionState.Disabled, false);
			}
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x000985E4 File Offset: 0x000967E4
		public override void OnSubmit(BaseEventData eventData)
		{
			this.gik();
			if (!this.IsActive() || !this.IsInteractable())
			{
				this.kfd = true;
				this.DoStateTransition(Selectable.SelectionState.Disabled, false);
				return;
			}
			this.DoStateTransition(Selectable.SelectionState.Pressed, false);
			base.StartCoroutine(this.gil());
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x00098621 File Offset: 0x00096821
		private IEnumerator gil()
		{
			float fadeDuration = base.colors.fadeDuration;
			float num = 0f;
			while (num < fadeDuration)
			{
				num += Time.unscaledDeltaTime;
				yield return null;
			}
			this.DoStateTransition(base.currentSelectionState, false);
			yield break;
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x00098630 File Offset: 0x00096830
		private void gim(bool a)
		{
			if (!a)
			{
				if (this.kfd)
				{
					this.kfd = false;
					Selectable.SelectionState selectionState = (this.mbu ? Selectable.SelectionState.Disabled : base.currentSelectionState);
					this.DoStateTransition(selectionState, false);
					return;
				}
			}
			else
			{
				if (!this.mbu)
				{
					return;
				}
				this.kfd = true;
				this.DoStateTransition(Selectable.SelectionState.Disabled, false);
			}
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x00098682 File Offset: 0x00096882
		public void OnCancel(BaseEventData eventData)
		{
			if (this.kfe != null)
			{
				this.kfe();
			}
		}

		// Token: 0x0400111D RID: 4381
		[SerializeField]
		private Sprite _disabledHighlightedSprite;

		// Token: 0x0400111E RID: 4382
		[SerializeField]
		private Color _disabledHighlightedColor;

		// Token: 0x0400111F RID: 4383
		[SerializeField]
		private string _disabledHighlightedTrigger;

		// Token: 0x04001120 RID: 4384
		[SerializeField]
		private bool _autoNavUp = true;

		// Token: 0x04001121 RID: 4385
		[SerializeField]
		private bool _autoNavDown = true;

		// Token: 0x04001122 RID: 4386
		[SerializeField]
		private bool _autoNavLeft = true;

		// Token: 0x04001123 RID: 4387
		[SerializeField]
		private bool _autoNavRight = true;

		// Token: 0x04001124 RID: 4388
		private bool kfd;
	}
}
