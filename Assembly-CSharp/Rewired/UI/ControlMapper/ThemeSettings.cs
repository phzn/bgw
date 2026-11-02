using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200022E RID: 558
	[Serializable]
	public class ThemeSettings : ScriptableObject
	{
		// Token: 0x0600247C RID: 9340 RVA: 0x0009A424 File Offset: 0x00098624
		public void gpx(ThemedElement.ElementInfo[] a)
		{
			if (a == null)
			{
				return;
			}
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] != null)
				{
					this.gpy(a[i].mfq, a[i].mfr);
				}
			}
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x0009A460 File Offset: 0x00098660
		private void gpy(string a, Component b)
		{
			if (b as Selectable != null)
			{
				this.gpz(a, (Selectable)b);
				return;
			}
			if (b as Image != null)
			{
				this.gqa(a, (Image)b);
				return;
			}
			if (b as TMP_Text != null)
			{
				this.gqb(a, (TMP_Text)b);
				return;
			}
			if (b as UIImageHelper != null)
			{
				this.gqc(a, (UIImageHelper)b);
				return;
			}
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x0009A4E0 File Offset: 0x000986E0
		private void gpz(string a, Selectable b)
		{
			if (b == null)
			{
				return;
			}
			ThemeSettings.SelectableSettings_Base selectableSettings_Base;
			if (b as Button != null)
			{
				if (a == a.exz())
				{
					selectableSettings_Base = this._inputGridFieldSettings;
				}
				else
				{
					selectableSettings_Base = this._buttonSettings;
				}
			}
			else if (b as Scrollbar != null)
			{
				selectableSettings_Base = this._scrollbarSettings;
			}
			else if (b as Slider != null)
			{
				selectableSettings_Base = this._sliderSettings;
			}
			else if (b as Toggle != null)
			{
				if (a == a.ely())
				{
					selectableSettings_Base = this._buttonSettings;
				}
				else
				{
					selectableSettings_Base = this._selectableSettings;
				}
			}
			else
			{
				selectableSettings_Base = this._selectableSettings;
			}
			selectableSettings_Base.gnh(b);
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x0009A590 File Offset: 0x00098790
		private void gqa(string a, Image b)
		{
			if (b == null)
			{
				return;
			}
			uint num = <PrivateImplementationDetails>.ComputeStringHash(a);
			if (num <= 2822822017U)
			{
				if (num <= 665291243U)
				{
					if (num != 106194061U)
					{
						if (num != 283896133U)
						{
							if (num != 665291243U)
							{
								return;
							}
							if (!(a == a.eyf()))
							{
								return;
							}
							if (this._calibrationBackground != null)
							{
								this._calibrationBackground.goa(b);
								return;
							}
						}
						else
						{
							if (!(a == a.eyb()))
							{
								return;
							}
							if (this._popupWindowBackground != null)
							{
								this._popupWindowBackground.goa(b);
								return;
							}
						}
					}
					else
					{
						if (!(a == a.eyl()))
						{
							return;
						}
						if (this._buttonSettings != null)
						{
							this._buttonSettings.mea.goa(b);
						}
					}
				}
				else if (num != 2579191547U)
				{
					if (num != 2601460036U)
					{
						if (num != 2822822017U)
						{
							return;
						}
						if (!(a == a.eyj()))
						{
							return;
						}
						if (this._invertToggle != null)
						{
							this._invertToggle.goa(b);
							return;
						}
					}
					else
					{
						if (!(a == a.eya()))
						{
							return;
						}
						if (this._areaBackground != null)
						{
							this._areaBackground.goa(b);
							return;
						}
					}
				}
				else
				{
					if (!(a == a.eyi()))
					{
						return;
					}
					if (this._calibrationDeadzone != null)
					{
						this._calibrationDeadzone.goa(b);
						return;
					}
				}
			}
			else if (num <= 3490313510U)
			{
				if (num != 2998767316U)
				{
					if (num != 3338297968U)
					{
						if (num != 3490313510U)
						{
							return;
						}
						if (!(a == a.eye()))
						{
							return;
						}
						if (this._calibrationRawValueMarker != null)
						{
							this._calibrationRawValueMarker.goa(b);
							return;
						}
					}
					else
					{
						if (!(a == a.eyh()))
						{
							return;
						}
						if (this._calibrationCalibratedZeroMarker != null)
						{
							this._calibrationCalibratedZeroMarker.goa(b);
							return;
						}
					}
				}
				else
				{
					if (!(a == a.eyc()))
					{
						return;
					}
					if (this._mainWindowBackground != null)
					{
						this._mainWindowBackground.goa(b);
						return;
					}
				}
			}
			else if (num != 3776179782U)
			{
				if (num != 3836396811U)
				{
					if (num != 3911450241U)
					{
						return;
					}
					if (!(a == a.eyk()))
					{
						return;
					}
					if (this._inputGridFieldSettings != null)
					{
						this._inputGridFieldSettings.mea.goa(b);
						return;
					}
				}
				else
				{
					if (!(a == a.eyg()))
					{
						return;
					}
					if (this._calibrationZeroMarker != null)
					{
						this._calibrationZeroMarker.goa(b);
						return;
					}
				}
			}
			else
			{
				if (!(a == a.eyd()))
				{
					return;
				}
				if (this._calibrationValueMarker != null)
				{
					this._calibrationValueMarker.goa(b);
					return;
				}
			}
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x0009A828 File Offset: 0x00098A28
		private void gqb(string a, TMP_Text b)
		{
			if (b == null)
			{
				return;
			}
			ThemeSettings.TextSettings textSettings;
			if (!(a == a.ely()))
			{
				if (!(a == a.exz()))
				{
					textSettings = this._textSettings;
				}
				else
				{
					textSettings = this._inputGridFieldTextSettings;
				}
			}
			else
			{
				textSettings = this._buttonTextSettings;
			}
			if (textSettings.mfk != null)
			{
				b.font = textSettings.mfk;
			}
			b.color = textSettings.mfj;
			b.lineSpacing = textSettings.mfn;
			if (textSettings.mfm != 1f)
			{
				b.fontSize = (float)((int)(b.fontSize * textSettings.mfm));
				b.fontSizeMax = (float)((int)(b.fontSizeMax * textSettings.mfm));
				b.fontSizeMin = (float)((int)(b.fontSizeMin * textSettings.mfm));
			}
			b.characterSpacing = textSettings.mfo;
			b.wordSpacing = textSettings.mfp;
			if (textSettings.mfl != ThemeSettings.FontStyleOverride.Default)
			{
				b.fontStyle = ThemeSettings.gqd(textSettings.mfl);
			}
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x0009A923 File Offset: 0x00098B23
		private void gqc(string a, UIImageHelper b)
		{
			if (b == null)
			{
				return;
			}
			b.gqz(this._invertToggle.meg);
			b.gra(this._invertToggleDisabledColor);
			b.grb();
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x0009A952 File Offset: 0x00098B52
		private static FontStyles gqd(ThemeSettings.FontStyleOverride a)
		{
			switch (a)
			{
			case ThemeSettings.FontStyleOverride.Default:
			case ThemeSettings.FontStyleOverride.Normal:
				return FontStyles.Normal;
			case ThemeSettings.FontStyleOverride.Bold:
				return FontStyles.Bold;
			case ThemeSettings.FontStyleOverride.Italic:
				return FontStyles.Italic;
			case ThemeSettings.FontStyleOverride.BoldAndItalic:
				return FontStyles.Bold | FontStyles.Italic;
			default:
				throw new NotImplementedException();
			}
		}

		// Token: 0x040011AA RID: 4522
		[SerializeField]
		private ThemeSettings.ImageSettings _mainWindowBackground;

		// Token: 0x040011AB RID: 4523
		[SerializeField]
		private ThemeSettings.ImageSettings _popupWindowBackground;

		// Token: 0x040011AC RID: 4524
		[SerializeField]
		private ThemeSettings.ImageSettings _areaBackground;

		// Token: 0x040011AD RID: 4525
		[SerializeField]
		private ThemeSettings.SelectableSettings _selectableSettings;

		// Token: 0x040011AE RID: 4526
		[SerializeField]
		private ThemeSettings.SelectableSettings _buttonSettings;

		// Token: 0x040011AF RID: 4527
		[SerializeField]
		private ThemeSettings.SelectableSettings _inputGridFieldSettings;

		// Token: 0x040011B0 RID: 4528
		[SerializeField]
		private ThemeSettings.ScrollbarSettings _scrollbarSettings;

		// Token: 0x040011B1 RID: 4529
		[SerializeField]
		private ThemeSettings.SliderSettings _sliderSettings;

		// Token: 0x040011B2 RID: 4530
		[SerializeField]
		private ThemeSettings.ImageSettings _invertToggle;

		// Token: 0x040011B3 RID: 4531
		[SerializeField]
		private Color _invertToggleDisabledColor;

		// Token: 0x040011B4 RID: 4532
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationBackground;

		// Token: 0x040011B5 RID: 4533
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationValueMarker;

		// Token: 0x040011B6 RID: 4534
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationRawValueMarker;

		// Token: 0x040011B7 RID: 4535
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationZeroMarker;

		// Token: 0x040011B8 RID: 4536
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationCalibratedZeroMarker;

		// Token: 0x040011B9 RID: 4537
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationDeadzone;

		// Token: 0x040011BA RID: 4538
		[SerializeField]
		private ThemeSettings.TextSettings _textSettings;

		// Token: 0x040011BB RID: 4539
		[SerializeField]
		private ThemeSettings.TextSettings _buttonTextSettings;

		// Token: 0x040011BC RID: 4540
		[SerializeField]
		private ThemeSettings.TextSettings _inputGridFieldTextSettings;

		// Token: 0x0200022F RID: 559
		[Serializable]
		private abstract class SelectableSettings_Base
		{
			// Token: 0x170005C2 RID: 1474
			// (get) Token: 0x06002484 RID: 9348 RVA: 0x0009A97D File Offset: 0x00098B7D
			public Selectable.Transition mdw
			{
				get
				{
					return this._transition;
				}
			}

			// Token: 0x170005C3 RID: 1475
			// (get) Token: 0x06002485 RID: 9349 RVA: 0x0009A985 File Offset: 0x00098B85
			public ThemeSettings.CustomColorBlock mdx
			{
				get
				{
					return this._colors;
				}
			}

			// Token: 0x170005C4 RID: 1476
			// (get) Token: 0x06002486 RID: 9350 RVA: 0x0009A98D File Offset: 0x00098B8D
			public ThemeSettings.CustomSpriteState mdy
			{
				get
				{
					return this._spriteState;
				}
			}

			// Token: 0x170005C5 RID: 1477
			// (get) Token: 0x06002487 RID: 9351 RVA: 0x0009A995 File Offset: 0x00098B95
			public ThemeSettings.CustomAnimationTriggers mdz
			{
				get
				{
					return this._animationTriggers;
				}
			}

			// Token: 0x06002488 RID: 9352 RVA: 0x0009A9A0 File Offset: 0x00098BA0
			public virtual void gnh(Selectable a)
			{
				Selectable.Transition transition = this._transition;
				bool flag = a.transition != transition;
				a.transition = transition;
				kc kc = a as kc;
				if (transition == Selectable.Transition.ColorTint)
				{
					ThemeSettings.CustomColorBlock colors = this._colors;
					colors.mes = 0f;
					a.colors = ThemeSettings.CustomColorBlock.gor(colors);
					colors.mes = this._colors.mes;
					a.colors = ThemeSettings.CustomColorBlock.gor(colors);
					if (kc != null)
					{
						kc.mbo = colors.mex;
					}
				}
				else if (transition == Selectable.Transition.SpriteSwap)
				{
					a.spriteState = ThemeSettings.CustomSpriteState.gpc(this._spriteState);
					if (kc != null)
					{
						kc.mbn = this._spriteState.mfc;
					}
				}
				else if (transition == Selectable.Transition.Animation)
				{
					a.animationTriggers.disabledTrigger = this._animationTriggers.mfd;
					a.animationTriggers.highlightedTrigger = this._animationTriggers.mfe;
					a.animationTriggers.normalTrigger = this._animationTriggers.mff;
					a.animationTriggers.pressedTrigger = this._animationTriggers.mfg;
					if (kc != null)
					{
						kc.mbp = this._animationTriggers.mfi;
					}
				}
				if (flag)
				{
					a.targetGraphic.CrossFadeColor(a.targetGraphic.color, 0f, true, true);
				}
			}

			// Token: 0x040011BD RID: 4541
			[SerializeField]
			protected Selectable.Transition _transition;

			// Token: 0x040011BE RID: 4542
			[SerializeField]
			protected ThemeSettings.CustomColorBlock _colors;

			// Token: 0x040011BF RID: 4543
			[SerializeField]
			protected ThemeSettings.CustomSpriteState _spriteState;

			// Token: 0x040011C0 RID: 4544
			[SerializeField]
			protected ThemeSettings.CustomAnimationTriggers _animationTriggers;
		}

		// Token: 0x02000230 RID: 560
		[Serializable]
		private class SelectableSettings : ThemeSettings.SelectableSettings_Base
		{
			// Token: 0x170005C6 RID: 1478
			// (get) Token: 0x0600248A RID: 9354 RVA: 0x0009AAE4 File Offset: 0x00098CE4
			public ThemeSettings.ImageSettings mea
			{
				get
				{
					return this._imageSettings;
				}
			}

			// Token: 0x0600248B RID: 9355 RVA: 0x0009AAEC File Offset: 0x00098CEC
			public override void gnh(Selectable a)
			{
				if (a == null)
				{
					return;
				}
				base.gnh(a);
				if (this._imageSettings != null)
				{
					this._imageSettings.goa(a.targetGraphic as Image);
				}
			}

			// Token: 0x040011C1 RID: 4545
			[SerializeField]
			private ThemeSettings.ImageSettings _imageSettings;
		}

		// Token: 0x02000231 RID: 561
		[Serializable]
		private class SliderSettings : ThemeSettings.SelectableSettings_Base
		{
			// Token: 0x170005C7 RID: 1479
			// (get) Token: 0x0600248D RID: 9357 RVA: 0x0009AB25 File Offset: 0x00098D25
			public ThemeSettings.ImageSettings meb
			{
				get
				{
					return this._handleImageSettings;
				}
			}

			// Token: 0x170005C8 RID: 1480
			// (get) Token: 0x0600248E RID: 9358 RVA: 0x0009AB2D File Offset: 0x00098D2D
			public ThemeSettings.ImageSettings mec
			{
				get
				{
					return this._fillImageSettings;
				}
			}

			// Token: 0x170005C9 RID: 1481
			// (get) Token: 0x0600248F RID: 9359 RVA: 0x0009AB35 File Offset: 0x00098D35
			public ThemeSettings.ImageSettings med
			{
				get
				{
					return this._backgroundImageSettings;
				}
			}

			// Token: 0x06002490 RID: 9360 RVA: 0x0009AB40 File Offset: 0x00098D40
			private void gnm(Slider a)
			{
				if (a == null)
				{
					return;
				}
				if (this._handleImageSettings != null)
				{
					this._handleImageSettings.goa(a.targetGraphic as Image);
				}
				if (this._fillImageSettings != null)
				{
					RectTransform fillRect = a.fillRect;
					if (fillRect != null)
					{
						this._fillImageSettings.goa(fillRect.GetComponent<Image>());
					}
				}
				if (this._backgroundImageSettings != null)
				{
					Transform transform = a.transform.Find(a.exy());
					if (transform != null)
					{
						this._backgroundImageSettings.goa(transform.GetComponent<Image>());
					}
				}
			}

			// Token: 0x06002491 RID: 9361 RVA: 0x0009ABD1 File Offset: 0x00098DD1
			public override void gnh(Selectable a)
			{
				base.gnh(a);
				this.gnm(a as Slider);
			}

			// Token: 0x040011C2 RID: 4546
			[SerializeField]
			private ThemeSettings.ImageSettings _handleImageSettings;

			// Token: 0x040011C3 RID: 4547
			[SerializeField]
			private ThemeSettings.ImageSettings _fillImageSettings;

			// Token: 0x040011C4 RID: 4548
			[SerializeField]
			private ThemeSettings.ImageSettings _backgroundImageSettings;
		}

		// Token: 0x02000232 RID: 562
		[Serializable]
		private class ScrollbarSettings : ThemeSettings.SelectableSettings_Base
		{
			// Token: 0x170005CA RID: 1482
			// (get) Token: 0x06002493 RID: 9363 RVA: 0x0009ABE6 File Offset: 0x00098DE6
			public ThemeSettings.ImageSettings mee
			{
				get
				{
					return this._handleImageSettings;
				}
			}

			// Token: 0x170005CB RID: 1483
			// (get) Token: 0x06002494 RID: 9364 RVA: 0x0009ABEE File Offset: 0x00098DEE
			public ThemeSettings.ImageSettings mef
			{
				get
				{
					return this._backgroundImageSettings;
				}
			}

			// Token: 0x06002495 RID: 9365 RVA: 0x0009ABF8 File Offset: 0x00098DF8
			private void gnp(Scrollbar a)
			{
				if (a == null)
				{
					return;
				}
				if (this._handleImageSettings != null)
				{
					this._handleImageSettings.goa(a.targetGraphic as Image);
				}
				if (this._backgroundImageSettings != null)
				{
					this._backgroundImageSettings.goa(a.GetComponent<Image>());
				}
			}

			// Token: 0x06002496 RID: 9366 RVA: 0x0009AC46 File Offset: 0x00098E46
			public override void gnh(Selectable a)
			{
				base.gnh(a);
				this.gnp(a as Scrollbar);
			}

			// Token: 0x040011C5 RID: 4549
			[SerializeField]
			private ThemeSettings.ImageSettings _handleImageSettings;

			// Token: 0x040011C6 RID: 4550
			[SerializeField]
			private ThemeSettings.ImageSettings _backgroundImageSettings;
		}

		// Token: 0x02000233 RID: 563
		[Serializable]
		private class ImageSettings
		{
			// Token: 0x170005CC RID: 1484
			// (get) Token: 0x06002498 RID: 9368 RVA: 0x0009AC5B File Offset: 0x00098E5B
			public Color meg
			{
				get
				{
					return this._color;
				}
			}

			// Token: 0x170005CD RID: 1485
			// (get) Token: 0x06002499 RID: 9369 RVA: 0x0009AC63 File Offset: 0x00098E63
			public Sprite meh
			{
				get
				{
					return this._sprite;
				}
			}

			// Token: 0x170005CE RID: 1486
			// (get) Token: 0x0600249A RID: 9370 RVA: 0x0009AC6B File Offset: 0x00098E6B
			public Material mei
			{
				get
				{
					return this._materal;
				}
			}

			// Token: 0x170005CF RID: 1487
			// (get) Token: 0x0600249B RID: 9371 RVA: 0x0009AC73 File Offset: 0x00098E73
			public Image.Type mej
			{
				get
				{
					return this._type;
				}
			}

			// Token: 0x170005D0 RID: 1488
			// (get) Token: 0x0600249C RID: 9372 RVA: 0x0009AC7B File Offset: 0x00098E7B
			public bool mek
			{
				get
				{
					return this._preserveAspect;
				}
			}

			// Token: 0x170005D1 RID: 1489
			// (get) Token: 0x0600249D RID: 9373 RVA: 0x0009AC83 File Offset: 0x00098E83
			public bool mel
			{
				get
				{
					return this._fillCenter;
				}
			}

			// Token: 0x170005D2 RID: 1490
			// (get) Token: 0x0600249E RID: 9374 RVA: 0x0009AC8B File Offset: 0x00098E8B
			public Image.FillMethod mem
			{
				get
				{
					return this._fillMethod;
				}
			}

			// Token: 0x170005D3 RID: 1491
			// (get) Token: 0x0600249F RID: 9375 RVA: 0x0009AC93 File Offset: 0x00098E93
			public float men
			{
				get
				{
					return this._fillAmout;
				}
			}

			// Token: 0x170005D4 RID: 1492
			// (get) Token: 0x060024A0 RID: 9376 RVA: 0x0009AC9B File Offset: 0x00098E9B
			public bool meo
			{
				get
				{
					return this._fillClockwise;
				}
			}

			// Token: 0x170005D5 RID: 1493
			// (get) Token: 0x060024A1 RID: 9377 RVA: 0x0009ACA3 File Offset: 0x00098EA3
			public int mep
			{
				get
				{
					return this._fillOrigin;
				}
			}

			// Token: 0x060024A2 RID: 9378 RVA: 0x0009ACAC File Offset: 0x00098EAC
			public virtual void goa(Image a)
			{
				if (a == null)
				{
					return;
				}
				a.color = this._color;
				a.sprite = this._sprite;
				a.material = this._materal;
				a.type = this._type;
				a.preserveAspect = this._preserveAspect;
				a.fillCenter = this._fillCenter;
				a.fillMethod = this._fillMethod;
				a.fillAmount = this._fillAmout;
				a.fillClockwise = this._fillClockwise;
				a.fillOrigin = this._fillOrigin;
			}

			// Token: 0x040011C7 RID: 4551
			[SerializeField]
			private Color _color = Color.white;

			// Token: 0x040011C8 RID: 4552
			[SerializeField]
			private Sprite _sprite;

			// Token: 0x040011C9 RID: 4553
			[SerializeField]
			private Material _materal;

			// Token: 0x040011CA RID: 4554
			[SerializeField]
			private Image.Type _type;

			// Token: 0x040011CB RID: 4555
			[SerializeField]
			private bool _preserveAspect;

			// Token: 0x040011CC RID: 4556
			[SerializeField]
			private bool _fillCenter;

			// Token: 0x040011CD RID: 4557
			[SerializeField]
			private Image.FillMethod _fillMethod;

			// Token: 0x040011CE RID: 4558
			[SerializeField]
			private float _fillAmout;

			// Token: 0x040011CF RID: 4559
			[SerializeField]
			private bool _fillClockwise;

			// Token: 0x040011D0 RID: 4560
			[SerializeField]
			private int _fillOrigin;
		}

		// Token: 0x02000234 RID: 564
		[Serializable]
		private struct CustomColorBlock
		{
			// Token: 0x170005D6 RID: 1494
			// (get) Token: 0x060024A4 RID: 9380 RVA: 0x0009AD4E File Offset: 0x00098F4E
			// (set) Token: 0x060024A5 RID: 9381 RVA: 0x0009AD56 File Offset: 0x00098F56
			public float meq
			{
				get
				{
					return this.m_ColorMultiplier;
				}
				set
				{
					this.m_ColorMultiplier = value;
				}
			}

			// Token: 0x170005D7 RID: 1495
			// (get) Token: 0x060024A6 RID: 9382 RVA: 0x0009AD5F File Offset: 0x00098F5F
			// (set) Token: 0x060024A7 RID: 9383 RVA: 0x0009AD67 File Offset: 0x00098F67
			public Color mer
			{
				get
				{
					return this.m_DisabledColor;
				}
				set
				{
					this.m_DisabledColor = value;
				}
			}

			// Token: 0x170005D8 RID: 1496
			// (get) Token: 0x060024A8 RID: 9384 RVA: 0x0009AD70 File Offset: 0x00098F70
			// (set) Token: 0x060024A9 RID: 9385 RVA: 0x0009AD78 File Offset: 0x00098F78
			public float mes
			{
				get
				{
					return this.m_FadeDuration;
				}
				set
				{
					this.m_FadeDuration = value;
				}
			}

			// Token: 0x170005D9 RID: 1497
			// (get) Token: 0x060024AA RID: 9386 RVA: 0x0009AD81 File Offset: 0x00098F81
			// (set) Token: 0x060024AB RID: 9387 RVA: 0x0009AD89 File Offset: 0x00098F89
			public Color met
			{
				get
				{
					return this.m_HighlightedColor;
				}
				set
				{
					this.m_HighlightedColor = value;
				}
			}

			// Token: 0x170005DA RID: 1498
			// (get) Token: 0x060024AC RID: 9388 RVA: 0x0009AD92 File Offset: 0x00098F92
			// (set) Token: 0x060024AD RID: 9389 RVA: 0x0009AD9A File Offset: 0x00098F9A
			public Color meu
			{
				get
				{
					return this.m_NormalColor;
				}
				set
				{
					this.m_NormalColor = value;
				}
			}

			// Token: 0x170005DB RID: 1499
			// (get) Token: 0x060024AE RID: 9390 RVA: 0x0009ADA3 File Offset: 0x00098FA3
			// (set) Token: 0x060024AF RID: 9391 RVA: 0x0009ADAB File Offset: 0x00098FAB
			public Color mev
			{
				get
				{
					return this.m_PressedColor;
				}
				set
				{
					this.m_PressedColor = value;
				}
			}

			// Token: 0x170005DC RID: 1500
			// (get) Token: 0x060024B0 RID: 9392 RVA: 0x0009ADB4 File Offset: 0x00098FB4
			// (set) Token: 0x060024B1 RID: 9393 RVA: 0x0009ADBC File Offset: 0x00098FBC
			public Color mew
			{
				get
				{
					return this.m_SelectedColor;
				}
				set
				{
					this.m_SelectedColor = value;
				}
			}

			// Token: 0x170005DD RID: 1501
			// (get) Token: 0x060024B2 RID: 9394 RVA: 0x0009ADC5 File Offset: 0x00098FC5
			// (set) Token: 0x060024B3 RID: 9395 RVA: 0x0009ADCD File Offset: 0x00098FCD
			public Color mex
			{
				get
				{
					return this.m_DisabledHighlightedColor;
				}
				set
				{
					this.m_DisabledHighlightedColor = value;
				}
			}

			// Token: 0x060024B4 RID: 9396 RVA: 0x0009ADD8 File Offset: 0x00098FD8
			public static ColorBlock gor(ThemeSettings.CustomColorBlock a)
			{
				return new ColorBlock
				{
					selectedColor = a.m_SelectedColor,
					colorMultiplier = a.m_ColorMultiplier,
					disabledColor = a.m_DisabledColor,
					fadeDuration = a.m_FadeDuration,
					highlightedColor = a.m_HighlightedColor,
					normalColor = a.m_NormalColor,
					pressedColor = a.m_PressedColor
				};
			}

			// Token: 0x040011D1 RID: 4561
			[SerializeField]
			private float m_ColorMultiplier;

			// Token: 0x040011D2 RID: 4562
			[SerializeField]
			private Color m_DisabledColor;

			// Token: 0x040011D3 RID: 4563
			[SerializeField]
			private float m_FadeDuration;

			// Token: 0x040011D4 RID: 4564
			[SerializeField]
			private Color m_HighlightedColor;

			// Token: 0x040011D5 RID: 4565
			[SerializeField]
			private Color m_NormalColor;

			// Token: 0x040011D6 RID: 4566
			[SerializeField]
			private Color m_PressedColor;

			// Token: 0x040011D7 RID: 4567
			[SerializeField]
			private Color m_SelectedColor;

			// Token: 0x040011D8 RID: 4568
			[SerializeField]
			private Color m_DisabledHighlightedColor;
		}

		// Token: 0x02000235 RID: 565
		[Serializable]
		private struct CustomSpriteState
		{
			// Token: 0x170005DE RID: 1502
			// (get) Token: 0x060024B5 RID: 9397 RVA: 0x0009AE49 File Offset: 0x00099049
			// (set) Token: 0x060024B6 RID: 9398 RVA: 0x0009AE51 File Offset: 0x00099051
			public Sprite mey
			{
				get
				{
					return this.m_DisabledSprite;
				}
				set
				{
					this.m_DisabledSprite = value;
				}
			}

			// Token: 0x170005DF RID: 1503
			// (get) Token: 0x060024B7 RID: 9399 RVA: 0x0009AE5A File Offset: 0x0009905A
			// (set) Token: 0x060024B8 RID: 9400 RVA: 0x0009AE62 File Offset: 0x00099062
			public Sprite mez
			{
				get
				{
					return this.m_HighlightedSprite;
				}
				set
				{
					this.m_HighlightedSprite = value;
				}
			}

			// Token: 0x170005E0 RID: 1504
			// (get) Token: 0x060024B9 RID: 9401 RVA: 0x0009AE6B File Offset: 0x0009906B
			// (set) Token: 0x060024BA RID: 9402 RVA: 0x0009AE73 File Offset: 0x00099073
			public Sprite mfa
			{
				get
				{
					return this.m_PressedSprite;
				}
				set
				{
					this.m_PressedSprite = value;
				}
			}

			// Token: 0x170005E1 RID: 1505
			// (get) Token: 0x060024BB RID: 9403 RVA: 0x0009AE7C File Offset: 0x0009907C
			// (set) Token: 0x060024BC RID: 9404 RVA: 0x0009AE84 File Offset: 0x00099084
			public Sprite mfb
			{
				get
				{
					return this.m_SelectedSprite;
				}
				set
				{
					this.m_SelectedSprite = value;
				}
			}

			// Token: 0x170005E2 RID: 1506
			// (get) Token: 0x060024BD RID: 9405 RVA: 0x0009AE8D File Offset: 0x0009908D
			// (set) Token: 0x060024BE RID: 9406 RVA: 0x0009AE95 File Offset: 0x00099095
			public Sprite mfc
			{
				get
				{
					return this.m_DisabledHighlightedSprite;
				}
				set
				{
					this.m_DisabledHighlightedSprite = value;
				}
			}

			// Token: 0x060024BF RID: 9407 RVA: 0x0009AEA0 File Offset: 0x000990A0
			public static SpriteState gpc(ThemeSettings.CustomSpriteState a)
			{
				return new SpriteState
				{
					selectedSprite = a.m_SelectedSprite,
					disabledSprite = a.m_DisabledSprite,
					highlightedSprite = a.m_HighlightedSprite,
					pressedSprite = a.m_PressedSprite
				};
			}

			// Token: 0x040011D9 RID: 4569
			[SerializeField]
			private Sprite m_DisabledSprite;

			// Token: 0x040011DA RID: 4570
			[SerializeField]
			private Sprite m_HighlightedSprite;

			// Token: 0x040011DB RID: 4571
			[SerializeField]
			private Sprite m_PressedSprite;

			// Token: 0x040011DC RID: 4572
			[SerializeField]
			private Sprite m_SelectedSprite;

			// Token: 0x040011DD RID: 4573
			[SerializeField]
			private Sprite m_DisabledHighlightedSprite;
		}

		// Token: 0x02000236 RID: 566
		[Serializable]
		private class CustomAnimationTriggers
		{
			// Token: 0x060024C0 RID: 9408 RVA: 0x0009AEEC File Offset: 0x000990EC
			public CustomAnimationTriggers()
			{
				this.m_DisabledTrigger = string.Empty;
				this.m_HighlightedTrigger = string.Empty;
				this.m_NormalTrigger = string.Empty;
				this.m_PressedTrigger = string.Empty;
				this.m_SelectedTrigger = string.Empty;
				this.m_DisabledHighlightedTrigger = string.Empty;
			}

			// Token: 0x170005E3 RID: 1507
			// (get) Token: 0x060024C1 RID: 9409 RVA: 0x0009AF41 File Offset: 0x00099141
			// (set) Token: 0x060024C2 RID: 9410 RVA: 0x0009AF49 File Offset: 0x00099149
			public string mfd
			{
				get
				{
					return this.m_DisabledTrigger;
				}
				set
				{
					this.m_DisabledTrigger = value;
				}
			}

			// Token: 0x170005E4 RID: 1508
			// (get) Token: 0x060024C3 RID: 9411 RVA: 0x0009AF52 File Offset: 0x00099152
			// (set) Token: 0x060024C4 RID: 9412 RVA: 0x0009AF5A File Offset: 0x0009915A
			public string mfe
			{
				get
				{
					return this.m_HighlightedTrigger;
				}
				set
				{
					this.m_HighlightedTrigger = value;
				}
			}

			// Token: 0x170005E5 RID: 1509
			// (get) Token: 0x060024C5 RID: 9413 RVA: 0x0009AF63 File Offset: 0x00099163
			// (set) Token: 0x060024C6 RID: 9414 RVA: 0x0009AF6B File Offset: 0x0009916B
			public string mff
			{
				get
				{
					return this.m_NormalTrigger;
				}
				set
				{
					this.m_NormalTrigger = value;
				}
			}

			// Token: 0x170005E6 RID: 1510
			// (get) Token: 0x060024C7 RID: 9415 RVA: 0x0009AF74 File Offset: 0x00099174
			// (set) Token: 0x060024C8 RID: 9416 RVA: 0x0009AF7C File Offset: 0x0009917C
			public string mfg
			{
				get
				{
					return this.m_PressedTrigger;
				}
				set
				{
					this.m_PressedTrigger = value;
				}
			}

			// Token: 0x170005E7 RID: 1511
			// (get) Token: 0x060024C9 RID: 9417 RVA: 0x0009AF85 File Offset: 0x00099185
			// (set) Token: 0x060024CA RID: 9418 RVA: 0x0009AF8D File Offset: 0x0009918D
			public string mfh
			{
				get
				{
					return this.m_SelectedTrigger;
				}
				set
				{
					this.m_SelectedTrigger = value;
				}
			}

			// Token: 0x170005E8 RID: 1512
			// (get) Token: 0x060024CB RID: 9419 RVA: 0x0009AF96 File Offset: 0x00099196
			// (set) Token: 0x060024CC RID: 9420 RVA: 0x0009AF9E File Offset: 0x0009919E
			public string mfi
			{
				get
				{
					return this.m_DisabledHighlightedTrigger;
				}
				set
				{
					this.m_DisabledHighlightedTrigger = value;
				}
			}

			// Token: 0x060024CD RID: 9421 RVA: 0x0009AFA8 File Offset: 0x000991A8
			public static AnimationTriggers gpp(ThemeSettings.CustomAnimationTriggers a)
			{
				return new AnimationTriggers
				{
					selectedTrigger = a.m_SelectedTrigger,
					disabledTrigger = a.m_DisabledTrigger,
					highlightedTrigger = a.m_HighlightedTrigger,
					normalTrigger = a.m_NormalTrigger,
					pressedTrigger = a.m_PressedTrigger
				};
			}

			// Token: 0x040011DE RID: 4574
			[SerializeField]
			private string m_DisabledTrigger;

			// Token: 0x040011DF RID: 4575
			[SerializeField]
			private string m_HighlightedTrigger;

			// Token: 0x040011E0 RID: 4576
			[SerializeField]
			private string m_NormalTrigger;

			// Token: 0x040011E1 RID: 4577
			[SerializeField]
			private string m_PressedTrigger;

			// Token: 0x040011E2 RID: 4578
			[SerializeField]
			private string m_SelectedTrigger;

			// Token: 0x040011E3 RID: 4579
			[SerializeField]
			private string m_DisabledHighlightedTrigger;
		}

		// Token: 0x02000237 RID: 567
		[Serializable]
		private class TextSettings
		{
			// Token: 0x170005E9 RID: 1513
			// (get) Token: 0x060024CE RID: 9422 RVA: 0x0009AFF6 File Offset: 0x000991F6
			public Color mfj
			{
				get
				{
					return this._color;
				}
			}

			// Token: 0x170005EA RID: 1514
			// (get) Token: 0x060024CF RID: 9423 RVA: 0x0009AFFE File Offset: 0x000991FE
			public TMP_FontAsset mfk
			{
				get
				{
					return this._font;
				}
			}

			// Token: 0x170005EB RID: 1515
			// (get) Token: 0x060024D0 RID: 9424 RVA: 0x0009B006 File Offset: 0x00099206
			public ThemeSettings.FontStyleOverride mfl
			{
				get
				{
					return this._style;
				}
			}

			// Token: 0x170005EC RID: 1516
			// (get) Token: 0x060024D1 RID: 9425 RVA: 0x0009B00E File Offset: 0x0009920E
			public float mfm
			{
				get
				{
					return this._sizeMultiplier;
				}
			}

			// Token: 0x170005ED RID: 1517
			// (get) Token: 0x060024D2 RID: 9426 RVA: 0x0009B016 File Offset: 0x00099216
			public float mfn
			{
				get
				{
					return this._lineSpacing;
				}
			}

			// Token: 0x170005EE RID: 1518
			// (get) Token: 0x060024D3 RID: 9427 RVA: 0x0009B01E File Offset: 0x0009921E
			public float mfo
			{
				get
				{
					return this._characterSpacing;
				}
			}

			// Token: 0x170005EF RID: 1519
			// (get) Token: 0x060024D4 RID: 9428 RVA: 0x0009B026 File Offset: 0x00099226
			public float mfp
			{
				get
				{
					return this._wordSpacing;
				}
			}

			// Token: 0x040011E4 RID: 4580
			[SerializeField]
			private Color _color = Color.white;

			// Token: 0x040011E5 RID: 4581
			[SerializeField]
			private TMP_FontAsset _font;

			// Token: 0x040011E6 RID: 4582
			[SerializeField]
			private ThemeSettings.FontStyleOverride _style;

			// Token: 0x040011E7 RID: 4583
			[SerializeField]
			private float _sizeMultiplier = 1f;

			// Token: 0x040011E8 RID: 4584
			[SerializeField]
			private float _lineSpacing = 1f;

			// Token: 0x040011E9 RID: 4585
			[SerializeField]
			private float _characterSpacing = 1f;

			// Token: 0x040011EA RID: 4586
			[SerializeField]
			private float _wordSpacing = 1f;
		}

		// Token: 0x02000238 RID: 568
		private enum FontStyleOverride
		{
			// Token: 0x040011EC RID: 4588
			Default,
			// Token: 0x040011ED RID: 4589
			Normal,
			// Token: 0x040011EE RID: 4590
			Bold,
			// Token: 0x040011EF RID: 4591
			Italic,
			// Token: 0x040011F0 RID: 4592
			BoldAndItalic
		}
	}
}
