using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using TMPro;
using UnityEngine;
using UnityEngine.TextCore;

namespace Rewired.Glyphs.UnityUI
{
	// Token: 0x020001D8 RID: 472
	[RequireComponent(typeof(TextMeshProUGUI))]
	public class UnityUITextMeshProGlyphHelper : MonoBehaviour
	{
		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001E52 RID: 7762 RVA: 0x00087E20 File Offset: 0x00086020
		private UnityUITextMeshProGlyphHelper.ih.ig<UnityUITextMeshProGlyphHelper.ii> lvc
		{
			get
			{
				if (this.jyd == null)
				{
					return this.jyd = new UnityUITextMeshProGlyphHelper.ih.ig<UnityUITextMeshProGlyphHelper.ii>();
				}
				return this.jyd;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001E53 RID: 7763 RVA: 0x00087E4C File Offset: 0x0008604C
		private UnityUITextMeshProGlyphHelper.ih.ig<UnityUITextMeshProGlyphHelper.ij> lvd
		{
			get
			{
				if (this.jye == null)
				{
					return this.jye = new UnityUITextMeshProGlyphHelper.ih.ig<UnityUITextMeshProGlyphHelper.ij>();
				}
				return this.jye;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x00087E78 File Offset: 0x00086078
		private UnityUITextMeshProGlyphHelper.ih.ig<UnityUITextMeshProGlyphHelper.ik> lve
		{
			get
			{
				if (this.jyf == null)
				{
					return this.jyf = new UnityUITextMeshProGlyphHelper.ih.ig<UnityUITextMeshProGlyphHelper.ik>();
				}
				return this.jyf;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001E55 RID: 7765 RVA: 0x00087EA4 File Offset: 0x000860A4
		private Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler> lvf
		{
			get
			{
				if (this.jyg == null)
				{
					Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler> dictionary = new Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler>();
					dictionary.Add(a.esf(), new UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler(this.fjd));
					dictionary.Add(a.esg(), new UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler(this.fje));
					dictionary.Add(a.esh(), new UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler(this.fjf));
					Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler> dictionary2 = dictionary;
					this.jyg = dictionary;
					return dictionary2;
				}
				return this.jyg;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x00087F13 File Offset: 0x00086113
		// (set) Token: 0x06001E57 RID: 7767 RVA: 0x00087F1B File Offset: 0x0008611B
		public virtual string lvg
		{
			get
			{
				return this._text;
			}
			set
			{
				this._text = value;
				this.fjl();
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x00087F2A File Offset: 0x0008612A
		// (set) Token: 0x06001E59 RID: 7769 RVA: 0x00087F32 File Offset: 0x00086132
		public virtual ControllerElementGlyphSelectorOptionsSOBase lvh
		{
			get
			{
				return this._options;
			}
			set
			{
				this._options = value;
				this.fjl();
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x00087F41 File Offset: 0x00086141
		// (set) Token: 0x06001E5B RID: 7771 RVA: 0x00087F4C File Offset: 0x0008614C
		public virtual UnityUITextMeshProGlyphHelper.TMProSpriteOptions lvi
		{
			get
			{
				return this._spriteOptions;
			}
			set
			{
				this._spriteOptions = value;
				int count = this.jxq.Count;
				for (int i = 0; i < count; i++)
				{
					int num = this.jxq[i].lts.luq;
					for (int j = 0; j < num; j++)
					{
						UnityUITextMeshProGlyphHelper.im im = this.jxq[i].lts.fhf(j);
						if (im != null && !(im.lup == null))
						{
							Rect rect = im.lup.rect;
							im.lug = rect.width * this._spriteOptions.ltw.x + this._spriteOptions.ltx.x;
							im.luh = rect.height * this._spriteOptions.ltw.y + this._spriteOptions.ltx.y;
							im.lui = rect.width * this._spriteOptions.lty + this._spriteOptions.ltz;
							im.lul = this._spriteOptions.ltv;
						}
					}
					TMPro_EventManager.ON_SPRITE_ASSET_PROPERTY_CHANGED(true, this.jxq[i].lts.fhe());
				}
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x0008809E File Offset: 0x0008629E
		// (set) Token: 0x06001E5D RID: 7773 RVA: 0x000880A8 File Offset: 0x000862A8
		public virtual Material lvj
		{
			get
			{
				return this._baseSpriteMaterial;
			}
			set
			{
				UnityUITextMeshProGlyphHelper.iw iw = new UnityUITextMeshProGlyphHelper.iw();
				iw.jxi = this;
				this._baseSpriteMaterial = value;
				iw.jxh = ((this._baseSpriteMaterial != null) ? this._baseSpriteMaterial : this.jxp.ltt);
				this.fjr(new Action<UnityUITextMeshProGlyphHelper.il>(iw.fig));
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x00088102 File Offset: 0x00086302
		// (set) Token: 0x06001E5F RID: 7775 RVA: 0x0008810C File Offset: 0x0008630C
		public virtual bool lvk
		{
			get
			{
				return this._overrideSpriteMaterialProperties;
			}
			set
			{
				this._overrideSpriteMaterialProperties = value;
				if (value)
				{
					this.fjr(new Action<UnityUITextMeshProGlyphHelper.il>(this.fki));
					return;
				}
				UnityUITextMeshProGlyphHelper.ix ix = new UnityUITextMeshProGlyphHelper.ix();
				ix.jxj = ((this._baseSpriteMaterial != null) ? this._baseSpriteMaterial : this.jxp.ltt);
				this.fjr(new Action<UnityUITextMeshProGlyphHelper.il>(ix.fih));
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x00088175 File Offset: 0x00086375
		// (set) Token: 0x06001E61 RID: 7777 RVA: 0x0008817D File Offset: 0x0008637D
		public virtual UnityUITextMeshProGlyphHelper.SpriteMaterialProperties lvl
		{
			get
			{
				return this._spriteMaterialProperties;
			}
			set
			{
				this._spriteMaterialProperties = value;
				if (!this._overrideSpriteMaterialProperties)
				{
					return;
				}
				this.fjr(new Action<UnityUITextMeshProGlyphHelper.il>(this.fkj));
			}
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x000881A1 File Offset: 0x000863A1
		protected virtual void OnEnable()
		{
			this.fiz();
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x000881AA File Offset: 0x000863AA
		protected virtual void Start()
		{
			this.fja();
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x000881B2 File Offset: 0x000863B2
		protected virtual void Update()
		{
			if (!ReInput.isReady)
			{
				return;
			}
			this.fja();
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x000881C4 File Offset: 0x000863C4
		protected virtual void OnDestroy()
		{
			if (this.jxp != null)
			{
				if (this.jxk != null && this.jxk.spriteAsset == this.jxp.lts.fhe())
				{
					this.jxk.spriteAsset = null;
				}
				this.jxp.ffj();
				this.jxp = null;
			}
			for (int i = 0; i < this.jxq.Count; i++)
			{
				if (this.jxq[i] != null)
				{
					this.jxq[i].ffj();
				}
			}
			this.jxq.Clear();
			for (int j = 0; j < this.jxr.Count; j++)
			{
				if (this.jxr[j] != null)
				{
					this.jxr[j].ffj();
				}
			}
			this.jxr.Clear();
			if (this.jyc != null)
			{
				global::UnityEngine.Object.Destroy(this.jyc);
				this.jyc = null;
			}
			for (int k = 0; k < this.jxy.Count; k++)
			{
				this.jxy[k].fet();
			}
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x000882EE File Offset: 0x000864EE
		public virtual void fix()
		{
			if (!ReInput.isReady)
			{
				return;
			}
			this.jyb = true;
			this.Update();
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x00088308 File Offset: 0x00086508
		protected virtual ControllerElementGlyphSelectorOptions fiy()
		{
			if (this._options != null && this._options.lsl == null)
			{
				Debug.LogError(a.epm() + typeof(ControllerElementGlyphSelectorOptions).Name + a.epn());
				return ControllerElementGlyphSelectorOptions.lsk;
			}
			if (!(this._options != null))
			{
				return ControllerElementGlyphSelectorOptions.lsk;
			}
			return this._options.lsl;
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x00088378 File Offset: 0x00086578
		private bool fiz()
		{
			if (this.jya)
			{
				return true;
			}
			this.jxk = base.GetComponent<TextMeshProUGUI>();
			this.jyc = new Texture2D(1, 1);
			this.fjm();
			this.jya = true;
			return true;
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x000883AC File Offset: 0x000865AC
		private void fja()
		{
			bool flag = false;
			int count = this.jxy.Count;
			for (int i = 0; i < count; i++)
			{
				UnityUITextMeshProGlyphHelper.ih ih = this.jxy[i];
				switch (ih.jwb)
				{
				case UnityUITextMeshProGlyphHelper.ih.TagType.ControllerElement:
				{
					UnityUITextMeshProGlyphHelper.ii ii = (UnityUITextMeshProGlyphHelper.ii)ih;
					this.jxw.Clear();
					this.fjh((UnityUITextMeshProGlyphHelper.ii)ih, this.jxw);
					if (!UnityUITextMeshProGlyphHelper.fkb(this.jxw, ii.ltp))
					{
						flag = true;
					}
					break;
				}
				case UnityUITextMeshProGlyphHelper.ih.TagType.Action:
				{
					UnityUITextMeshProGlyphHelper.ij ij = (UnityUITextMeshProGlyphHelper.ij)ih;
					string text;
					this.fji(ij, out text);
					if (!string.Equals(ij.ltq, text, StringComparison.Ordinal))
					{
						flag = true;
					}
					break;
				}
				case UnityUITextMeshProGlyphHelper.ih.TagType.Player:
				{
					UnityUITextMeshProGlyphHelper.ik ik = (UnityUITextMeshProGlyphHelper.ik)ih;
					string text2;
					this.fjj(ik, out text2);
					if (!string.Equals(ik.ltr, text2, StringComparison.Ordinal))
					{
						flag = true;
					}
					break;
				}
				default:
					throw new NotImplementedException();
				}
			}
			if (!string.Equals(this._text, this.jxl, StringComparison.Ordinal))
			{
				this.jxl = this._text;
				flag = true;
			}
			if (flag || this.jyb)
			{
				string text3;
				if (this.fjb(this.jxl, out text3))
				{
					this.jxk.text = text3;
				}
				else
				{
					this.jxk.text = this._text;
				}
			}
			int count2 = this.jxu.Count;
			if (count2 > 0)
			{
				for (int j = 0; j < count2; j++)
				{
					this.jxu[j].lts.fhj();
				}
				this.jxu.Clear();
			}
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x0008853C File Offset: 0x0008673C
		private bool fjb(string a, out string b)
		{
			b = null;
			UnityUITextMeshProGlyphHelper.ih.fev(this.jxy);
			this.jxx.Clear();
			bool flag = false;
			while (this.fjc(ref a, this.jxm))
			{
				flag = true;
				b = a;
			}
			this.fjp();
			if (this.jyb)
			{
				this.jyb = false;
			}
			return flag;
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x00088594 File Offset: 0x00086794
		private bool fjc(ref string a, StringBuilder b)
		{
			int num = 0;
			UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler parseTagAttributesHandler = null;
			int num2 = -1;
			try
			{
				for (int i = 0; i < a.Length; i++)
				{
					char c = a[i];
					switch (num)
					{
					case 0:
						if (c == '<')
						{
							num2 = i;
							b.Length = 0;
							num = 1;
						}
						break;
					case 1:
						if (UnityUITextMeshProGlyphHelper.fjz(c))
						{
							b.Append(char.ToLowerInvariant(c));
						}
						else if (char.IsWhiteSpace(c))
						{
							if (b.Length > 0)
							{
								if (this.lvf.TryGetValue(b.ToString(), out parseTagAttributesHandler))
								{
									b.Length = 0;
									num = 2;
								}
								else
								{
									num = 0;
									i--;
								}
							}
						}
						else
						{
							num = 0;
							i--;
						}
						break;
					case 2:
					{
						int num3 = a.IndexOf('>', i);
						if (num3 < 0)
						{
							throw new Exception(a.esi());
						}
						string text;
						if (parseTagAttributesHandler(a, i, num3 - i, out text))
						{
							b.Length = 0;
							if (num2 > 0)
							{
								b.Append(a, 0, num2);
							}
							b.Append(text);
							int num4 = num3 + 1;
							if (num4 < a.Length)
							{
								b.Append(a, num4, a.Length - num4);
							}
							a = b.ToString();
							return true;
						}
						throw new Exception(a.esj());
					}
					}
				}
			}
			catch (Exception ex)
			{
				Debug.LogError(ex);
			}
			return false;
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00088724 File Offset: 0x00086924
		private bool fjd(string a, int b, int c, out string d)
		{
			UnityUITextMeshProGlyphHelper.ii ii;
			if (!UnityUITextMeshProGlyphHelper.ii.fex(a, b, c, this.jxn, this.jxo, this.jxz, this.lvc, out ii))
			{
				d = null;
				return false;
			}
			this.jxy.Add(ii);
			ii.ltp.Clear();
			if (!this.fjh(ii, ii.ltp))
			{
				d = null;
				return true;
			}
			this.fjg(ii.ltp, out d);
			return true;
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00088798 File Offset: 0x00086998
		private bool fje(string a, int b, int c, out string d)
		{
			UnityUITextMeshProGlyphHelper.ij ij;
			if (!UnityUITextMeshProGlyphHelper.ij.ffa(a, b, c, this.jxn, this.jxo, this.jxz, this.lvd, out ij))
			{
				d = null;
				return false;
			}
			this.jxy.Add(ij);
			this.fji(ij, out d);
			return true;
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x000887E8 File Offset: 0x000869E8
		private bool fjf(string a, int b, int c, out string d)
		{
			UnityUITextMeshProGlyphHelper.ik ik;
			if (!UnityUITextMeshProGlyphHelper.ik.ffd(a, b, c, this.jxn, this.jxo, this.jxz, this.lve, out ik))
			{
				d = null;
				return false;
			}
			this.jxy.Add(ik);
			this.fjj(ik, out d);
			return true;
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x00088838 File Offset: 0x00086A38
		private bool fjg(List<UnityUITextMeshProGlyphHelper.GlyphOrText> a, out string b)
		{
			StringBuilder stringBuilder = this.jxn;
			stringBuilder.Length = 0;
			int count = a.Count;
			for (int i = 0; i < count; i++)
			{
				string glyphKey = a[i].glyphKey;
				if (a[i].sprite != null && !string.IsNullOrEmpty(glyphKey) && this.fjk(a[i].sprite, glyphKey))
				{
					UnityUITextMeshProGlyphHelper.fkc(stringBuilder, glyphKey);
				}
				else
				{
					stringBuilder.Append(a[i].name);
				}
				if (i < count - 1)
				{
					stringBuilder.Append(a.m());
				}
			}
			b = stringBuilder.ToString();
			return !string.IsNullOrEmpty(b);
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x000888E4 File Offset: 0x00086AE4
		private bool fjh(UnityUITextMeshProGlyphHelper.ii a, List<UnityUITextMeshProGlyphHelper.GlyphOrText> b)
		{
			if (a == null)
			{
				return false;
			}
			this.jxs.Clear();
			ActionElementMap actionElementMap;
			ActionElementMap actionElementMap2;
			if (!ie.fdb(a.jwe, a.jwf, a.jwg, this.fiy(), this.jxs, out actionElementMap, out actionElementMap2))
			{
				return false;
			}
			if (actionElementMap != null && actionElementMap2 != null)
			{
				UnityUITextMeshProGlyphHelper.GlyphOrText glyphOrText = default(UnityUITextMeshProGlyphHelper.GlyphOrText);
				this.jxs.Clear();
				this.jxs.Add(actionElementMap);
				this.jxs.Add(actionElementMap2);
				object obj;
				string text;
				if (UnityUITextMeshProGlyphHelper.fke(a.jwd) && ActionElementMap.TryGetCombinedElementIdentifierGlyph(this.jxs, out obj) && ActionElementMap.TryGetCombinedElementIdentifierFinalGlyphKey(this.jxs, out text))
				{
					glyphOrText.glyphKey = text;
					glyphOrText.sprite = obj as Sprite;
					b.Add(glyphOrText);
					return true;
				}
				string text2;
				if (UnityUITextMeshProGlyphHelper.fkf(a.jwd) && ActionElementMap.TryGetCombinedElementIdentifierName(this.jxs, out text2))
				{
					glyphOrText.name = text2;
					b.Add(glyphOrText);
					return true;
				}
			}
			bool flag = false;
			this.jxt.Clear();
			this.jxv.Clear();
			bool flag2 = flag | UnityUITextMeshProGlyphHelper.fkd(actionElementMap, a.jwd, this.jxt, this.jxv, b);
			this.jxt.Clear();
			this.jxv.Clear();
			return flag2 | UnityUITextMeshProGlyphHelper.fkd(actionElementMap2, a.jwd, this.jxt, this.jxv, b);
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x00088A40 File Offset: 0x00086C40
		private bool fji(UnityUITextMeshProGlyphHelper.ij a, out string b)
		{
			if (a == null)
			{
				b = null;
				return false;
			}
			InputAction action = ReInput.mapping.GetAction(a.jwi);
			if (action == null)
			{
				b = null;
				return false;
			}
			b = action.GetDisplayName(a.jwj);
			a.ltq = b;
			return true;
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x00088A88 File Offset: 0x00086C88
		private bool fjj(UnityUITextMeshProGlyphHelper.ik a, out string b)
		{
			if (a == null)
			{
				b = null;
				return false;
			}
			Player player = ReInput.players.GetPlayer(a.jwl);
			if (player == null)
			{
				b = null;
				return false;
			}
			b = player.descriptiveName;
			a.ltr = b;
			return true;
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x00088AC8 File Offset: 0x00086CC8
		private bool fjk(Sprite a, string b)
		{
			UnityUITextMeshProGlyphHelper.il il = this.fjn(a);
			if (il == null)
			{
				return false;
			}
			UnityUITextMeshProGlyphHelper.@in @in = il.lts;
			if (!@in.fhh(b))
			{
				Rect rect = a.rect;
				UnityUITextMeshProGlyphHelper.im im = UnityUITextMeshProGlyphHelper.io.fhm();
				im.lue = rect.width;
				im.luf = rect.height;
				im.luj = new Vector2(rect.x, rect.y);
				im.lug = rect.width * this._spriteOptions.ltw.x + this._spriteOptions.ltx.x;
				im.luh = rect.height * this._spriteOptions.ltw.y + this._spriteOptions.ltx.y;
				im.lui = rect.width * this._spriteOptions.lty + this._spriteOptions.ltz;
				im.lul = this._spriteOptions.ltv;
				im.luk = new Vector2(rect.width * -0.5f, rect.height * 0.5f);
				im.lum = b;
				im.luo = TMP_TextUtilities.GetSimpleHashCode(b);
				im.lup = a;
				@in.fhg(im);
				this.fjq(il);
			}
			if (!this.jxx.Contains(il))
			{
				this.jxx.Add(il);
			}
			return true;
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x00088C31 File Offset: 0x00086E31
		private void fjl()
		{
			this.jyb = true;
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x00088C3A File Offset: 0x00086E3A
		private void fjm()
		{
			if (this.jxp != null)
			{
				return;
			}
			this.jxp = new UnityUITextMeshProGlyphHelper.il(null);
			this.jxk.spriteAsset = this.jxp.lts.fhe();
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x00088C6C File Offset: 0x00086E6C
		private UnityUITextMeshProGlyphHelper.il fjn(Sprite a)
		{
			if (a == null || a.texture == null)
			{
				return null;
			}
			int count = this.jxq.Count;
			for (int i = 0; i < count; i++)
			{
				if (this.jxq[i] != null && this.jxq[i].lts.lur == a.texture)
				{
					return this.jxq[i];
				}
			}
			UnityUITextMeshProGlyphHelper.il il = null;
			int count2 = this.jxr.Count;
			for (int j = 0; j < count2; j++)
			{
				if (this.jxr[j] != null)
				{
					il = this.jxr[j];
					this.jxr.RemoveAt(j);
					break;
				}
			}
			if (il == null)
			{
				il = this.fjo();
			}
			il.lts.lur = a.texture;
			il.ltt.SetTexture(ShaderUtilities.ID_MainTex, a.texture);
			List<TMP_SpriteAsset> list = this.jxp.lts.fhe().fallbackSpriteAssets;
			if (list == null)
			{
				list = new List<TMP_SpriteAsset>();
				this.jxp.lts.fhe().fallbackSpriteAssets = list;
			}
			list.Add(il.lts.fhe());
			this.jxq.Add(il);
			return il;
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x00088DB8 File Offset: 0x00086FB8
		private UnityUITextMeshProGlyphHelper.il fjo()
		{
			UnityUITextMeshProGlyphHelper.il il = new UnityUITextMeshProGlyphHelper.il(this._baseSpriteMaterial);
			if (this._overrideSpriteMaterialProperties)
			{
				UnityUITextMeshProGlyphHelper.fkh(this._spriteMaterialProperties, il.ltt);
			}
			return il;
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00088DEC File Offset: 0x00086FEC
		private void fjp()
		{
			int num = 0;
			for (int i = this.jxq.Count - 1; i >= 0; i--)
			{
				UnityUITextMeshProGlyphHelper.il il = this.jxq[i];
				if (il != null && !this.jxx.Contains(il))
				{
					if (num >= 2)
					{
						this.jxp.lts.fhe().fallbackSpriteAssets.Remove(il.lts.fhe());
						il.lts.lur = null;
						il.lts.fhi();
						il.ltt.SetTexture(ShaderUtilities.ID_MainTex, this.jyc);
						this.jxr.Add(il);
						this.jxq.RemoveAt(i);
					}
					else
					{
						num++;
					}
				}
			}
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x00088EAF File Offset: 0x000870AF
		private void fjq(UnityUITextMeshProGlyphHelper.il a)
		{
			if (this.jxu.Contains(a))
			{
				return;
			}
			this.jxu.Add(a);
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x00088ECC File Offset: 0x000870CC
		private void fjr(Action<UnityUITextMeshProGlyphHelper.il> a)
		{
			if (a == null)
			{
				return;
			}
			int num = this.jxq.Count;
			for (int i = 0; i < num; i++)
			{
				if (this.jxq[i] != null)
				{
					a(this.jxq[i]);
				}
			}
			num = this.jxr.Count;
			for (int j = 0; j < num; j++)
			{
				if (this.jxr[j] != null)
				{
					a(this.jxr[j]);
				}
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x00088F4D File Offset: 0x0008714D
		private static int lvm
		{
			get
			{
				return Shader.PropertyToID(a.esk());
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x00088F59 File Offset: 0x00087159
		private static string[] lvn
		{
			get
			{
				if (UnityUITextMeshProGlyphHelper.jyh == null)
				{
					return UnityUITextMeshProGlyphHelper.jyh = Enum.GetNames(typeof(UnityUITextMeshProGlyphHelper.DisplayType));
				}
				return UnityUITextMeshProGlyphHelper.jyh;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x00088F7D File Offset: 0x0008717D
		private static UnityUITextMeshProGlyphHelper.DisplayType[] lvo
		{
			get
			{
				if (UnityUITextMeshProGlyphHelper.jyi == null)
				{
					return UnityUITextMeshProGlyphHelper.jyi = (UnityUITextMeshProGlyphHelper.DisplayType[])Enum.GetValues(typeof(UnityUITextMeshProGlyphHelper.DisplayType));
				}
				return UnityUITextMeshProGlyphHelper.jyi;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x00088FA6 File Offset: 0x000871A6
		private static string[] lvp
		{
			get
			{
				if (UnityUITextMeshProGlyphHelper.jyj == null)
				{
					return UnityUITextMeshProGlyphHelper.jyj = Enum.GetNames(typeof(AxisRange));
				}
				return UnityUITextMeshProGlyphHelper.jyj;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x00088FCA File Offset: 0x000871CA
		private static AxisRange[] lvq
		{
			get
			{
				if (UnityUITextMeshProGlyphHelper.jyk == null)
				{
					return UnityUITextMeshProGlyphHelper.jyk = (AxisRange[])Enum.GetValues(typeof(AxisRange));
				}
				return UnityUITextMeshProGlyphHelper.jyk;
			}
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x00088FF4 File Offset: 0x000871F4
		private static void fjx(string a, int b, int c, StringBuilder d, StringBuilder e, Dictionary<string, string> f)
		{
			if (string.IsNullOrEmpty(a) || b < 0 || b >= a.Length)
			{
				return;
			}
			f.Clear();
			d.Length = 0;
			e.Length = 0;
			bool flag = true;
			int num = b + c - 1;
			int num2 = 0;
			try
			{
				for (int i = b; i < b + c; i++)
				{
					char c2 = a[i];
					switch (num2)
					{
					case 0:
						if (UnityUITextMeshProGlyphHelper.fjy(c2))
						{
							num2 = 1;
							i--;
							d.Length = 0;
						}
						break;
					case 1:
						if (c2 == '=')
						{
							if (d.Length == 0)
							{
								throw new Exception(a.esl());
							}
							num2 = 2;
						}
						else if (UnityUITextMeshProGlyphHelper.fjy(c2))
						{
							d.Append(char.ToLowerInvariant(c2));
						}
						else if (!char.IsWhiteSpace(c2))
						{
							throw new Exception(a.esm());
						}
						break;
					case 2:
						if ((flag = c2 == '"') || UnityUITextMeshProGlyphHelper.fka(c2))
						{
							if (!flag)
							{
								i--;
							}
							e.Length = 0;
							num2 = 3;
						}
						break;
					case 3:
						if ((flag && c2 == '"') || (!flag && (i == num || char.IsWhiteSpace(c2))))
						{
							if (!flag && i == num)
							{
								e.Append(c2);
							}
							if (e.Length == 0)
							{
								throw new Exception(a.esn());
							}
							if (f == null)
							{
								f = new Dictionary<string, string>();
							}
							f.Add(d.ToString(), e.ToString());
							num2 = 0;
						}
						else
						{
							e.Append(c2);
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				Debug.LogError(ex);
			}
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x000891A0 File Offset: 0x000873A0
		private static bool fjy(char a)
		{
			return char.IsLetterOrDigit(a) || a == '_';
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x000891A0 File Offset: 0x000873A0
		private static bool fjz(char a)
		{
			return char.IsLetterOrDigit(a) || a == '_';
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x000891B1 File Offset: 0x000873B1
		private static bool fka(char a)
		{
			return char.IsDigit(a);
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x000891BC File Offset: 0x000873BC
		private static bool fkb(List<UnityUITextMeshProGlyphHelper.GlyphOrText> a, List<UnityUITextMeshProGlyphHelper.GlyphOrText> b)
		{
			if (a.Count != b.Count)
			{
				return false;
			}
			for (int i = 0; i < a.Count; i++)
			{
				if (UnityUITextMeshProGlyphHelper.GlyphOrText.fff(a[i], b[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x00089202 File Offset: 0x00087402
		private static void fkc(StringBuilder a, string b)
		{
			a.Append(a.eso());
			a.Append(b);
			a.Append(a.esp());
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x00089224 File Offset: 0x00087424
		private static bool fkd(ActionElementMap a, UnityUITextMeshProGlyphHelper.DisplayType b, List<Sprite> c, List<string> d, List<UnityUITextMeshProGlyphHelper.GlyphOrText> e)
		{
			if (a == null || c == null || e == null)
			{
				return false;
			}
			if (UnityUITextMeshProGlyphHelper.fke(b) && a.GetElementIdentifierGlyphs<Sprite>(c) > 0)
			{
				a.GetElementIdentifierFinalGlyphKeys(d);
				if (d.Count != c.Count)
				{
					Debug.LogError(a.esq());
				}
				else
				{
					int count = c.Count;
					for (int i = 0; i < count; i++)
					{
						e.Add(new UnityUITextMeshProGlyphHelper.GlyphOrText
						{
							glyphKey = d[i],
							sprite = c[i]
						});
					}
					if (count > 0)
					{
						return true;
					}
				}
			}
			if (UnityUITextMeshProGlyphHelper.fkf(b))
			{
				e.Add(new UnityUITextMeshProGlyphHelper.GlyphOrText
				{
					name = a.elementIdentifierName
				});
				return true;
			}
			return false;
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x000892E1 File Offset: 0x000874E1
		private static bool fke(UnityUITextMeshProGlyphHelper.DisplayType a)
		{
			return a == UnityUITextMeshProGlyphHelper.DisplayType.Glyph || a == UnityUITextMeshProGlyphHelper.DisplayType.GlyphOrText;
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x000892EC File Offset: 0x000874EC
		private static bool fkf(UnityUITextMeshProGlyphHelper.DisplayType a)
		{
			return a == UnityUITextMeshProGlyphHelper.DisplayType.Text || a == UnityUITextMeshProGlyphHelper.DisplayType.GlyphOrText;
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x000892F8 File Offset: 0x000874F8
		private static void fkg(Material a, Material b)
		{
			if (a == null || b == null)
			{
				return;
			}
			b.shader = a.shader;
			if (a.shaderKeywords != null)
			{
				string[] array = new string[a.shaderKeywords.Length];
				Array.Copy(a.shaderKeywords, array, a.shaderKeywords.Length);
				b.shaderKeywords = array;
			}
			else
			{
				b.shaderKeywords = null;
			}
			if (a.HasProperty(UnityUITextMeshProGlyphHelper.lvm) && b.HasProperty(UnityUITextMeshProGlyphHelper.lvm))
			{
				b.color = a.color;
			}
			b.renderQueue = a.renderQueue;
			b.globalIlluminationFlags = a.globalIlluminationFlags;
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x0008939C File Offset: 0x0008759C
		private static void fkh(UnityUITextMeshProGlyphHelper.SpriteMaterialProperties a, Material b)
		{
			if (b == null)
			{
				return;
			}
			if (b.HasProperty(UnityUITextMeshProGlyphHelper.lvm))
			{
				b.color = a.lub;
			}
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x00089483 File Offset: 0x00087683
		[CompilerGenerated]
		private void fki(UnityUITextMeshProGlyphHelper.il a)
		{
			UnityUITextMeshProGlyphHelper.fkh(this._spriteMaterialProperties, a.ltt);
			TMPro_EventManager.ON_MATERIAL_PROPERTY_CHANGED(true, a.ltt);
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x00089483 File Offset: 0x00087683
		[CompilerGenerated]
		private void fkj(UnityUITextMeshProGlyphHelper.il a)
		{
			UnityUITextMeshProGlyphHelper.fkh(this._spriteMaterialProperties, a.ltt);
			TMPro_EventManager.ON_MATERIAL_PROPERTY_CHANGED(true, a.ltt);
		}

		// Token: 0x04000F72 RID: 3954
		[SerializeField]
		[TextArea(3, 10)]
		private string _text;

		// Token: 0x04000F73 RID: 3955
		[SerializeField]
		private ControllerElementGlyphSelectorOptionsSOBase _options;

		// Token: 0x04000F74 RID: 3956
		[SerializeField]
		private UnityUITextMeshProGlyphHelper.TMProSpriteOptions _spriteOptions = UnityUITextMeshProGlyphHelper.TMProSpriteOptions.lua;

		// Token: 0x04000F75 RID: 3957
		[SerializeField]
		private Material _baseSpriteMaterial;

		// Token: 0x04000F76 RID: 3958
		[SerializeField]
		private bool _overrideSpriteMaterialProperties = true;

		// Token: 0x04000F77 RID: 3959
		[SerializeField]
		private UnityUITextMeshProGlyphHelper.SpriteMaterialProperties _spriteMaterialProperties = UnityUITextMeshProGlyphHelper.SpriteMaterialProperties.luc;

		// Token: 0x04000F78 RID: 3960
		[NonSerialized]
		private TextMeshProUGUI jxk;

		// Token: 0x04000F79 RID: 3961
		[NonSerialized]
		private string jxl;

		// Token: 0x04000F7A RID: 3962
		[NonSerialized]
		private readonly StringBuilder jxm = new StringBuilder();

		// Token: 0x04000F7B RID: 3963
		[NonSerialized]
		private readonly StringBuilder jxn = new StringBuilder();

		// Token: 0x04000F7C RID: 3964
		[NonSerialized]
		private readonly StringBuilder jxo = new StringBuilder();

		// Token: 0x04000F7D RID: 3965
		[NonSerialized]
		private UnityUITextMeshProGlyphHelper.il jxp;

		// Token: 0x04000F7E RID: 3966
		[NonSerialized]
		private readonly List<UnityUITextMeshProGlyphHelper.il> jxq = new List<UnityUITextMeshProGlyphHelper.il>();

		// Token: 0x04000F7F RID: 3967
		[NonSerialized]
		private readonly List<UnityUITextMeshProGlyphHelper.il> jxr = new List<UnityUITextMeshProGlyphHelper.il>();

		// Token: 0x04000F80 RID: 3968
		[NonSerialized]
		private readonly List<ActionElementMap> jxs = new List<ActionElementMap>();

		// Token: 0x04000F81 RID: 3969
		[NonSerialized]
		private readonly List<Sprite> jxt = new List<Sprite>();

		// Token: 0x04000F82 RID: 3970
		[NonSerialized]
		private readonly List<UnityUITextMeshProGlyphHelper.il> jxu = new List<UnityUITextMeshProGlyphHelper.il>();

		// Token: 0x04000F83 RID: 3971
		[NonSerialized]
		private readonly List<string> jxv = new List<string>();

		// Token: 0x04000F84 RID: 3972
		[NonSerialized]
		private readonly List<UnityUITextMeshProGlyphHelper.GlyphOrText> jxw = new List<UnityUITextMeshProGlyphHelper.GlyphOrText>();

		// Token: 0x04000F85 RID: 3973
		[NonSerialized]
		private readonly List<UnityUITextMeshProGlyphHelper.il> jxx = new List<UnityUITextMeshProGlyphHelper.il>();

		// Token: 0x04000F86 RID: 3974
		[NonSerialized]
		private readonly List<UnityUITextMeshProGlyphHelper.ih> jxy = new List<UnityUITextMeshProGlyphHelper.ih>();

		// Token: 0x04000F87 RID: 3975
		[NonSerialized]
		private Dictionary<string, string> jxz = new Dictionary<string, string>();

		// Token: 0x04000F88 RID: 3976
		[NonSerialized]
		private bool jya;

		// Token: 0x04000F89 RID: 3977
		[NonSerialized]
		private bool jyb;

		// Token: 0x04000F8A RID: 3978
		[NonSerialized]
		private Texture2D jyc;

		// Token: 0x04000F8B RID: 3979
		private UnityUITextMeshProGlyphHelper.ih.ig<UnityUITextMeshProGlyphHelper.ii> jyd;

		// Token: 0x04000F8C RID: 3980
		private UnityUITextMeshProGlyphHelper.ih.ig<UnityUITextMeshProGlyphHelper.ij> jye;

		// Token: 0x04000F8D RID: 3981
		private UnityUITextMeshProGlyphHelper.ih.ig<UnityUITextMeshProGlyphHelper.ik> jyf;

		// Token: 0x04000F8E RID: 3982
		[NonSerialized]
		private Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler> jyg;

		// Token: 0x04000F8F RID: 3983
		private static string[] jyh;

		// Token: 0x04000F90 RID: 3984
		private static UnityUITextMeshProGlyphHelper.DisplayType[] jyi;

		// Token: 0x04000F91 RID: 3985
		private static string[] jyj;

		// Token: 0x04000F92 RID: 3986
		private static AxisRange[] jyk;

		// Token: 0x020001D9 RID: 473
		// (Invoke) Token: 0x06001E8F RID: 7823
		private delegate bool ParseTagAttributesHandler(string text, int startIndex, int count, out string replacement);

		// Token: 0x020001DA RID: 474
		private abstract class ih
		{
			// Token: 0x1700044C RID: 1100
			// (get) Token: 0x06001E92 RID: 7826 RVA: 0x000894A2 File Offset: 0x000876A2
			// (set) Token: 0x06001E93 RID: 7827 RVA: 0x000894AA File Offset: 0x000876AA
			protected UnityUITextMeshProGlyphHelper.ih.@if lto
			{
				get
				{
					return this.jwc;
				}
				set
				{
					this.jwc = value;
				}
			}

			// Token: 0x06001E94 RID: 7828 RVA: 0x000894B4 File Offset: 0x000876B4
			public static void gea(List<UnityUITextMeshProGlyphHelper.ih> a)
			{
				int count = a.Count;
				for (int i = 0; i < count; i++)
				{
					if (a[i] != null)
					{
						a[i].fet();
					}
				}
				a.Clear();
			}

			// Token: 0x06001E95 RID: 7829 RVA: 0x000894EF File Offset: 0x000876EF
			public void fet()
			{
				if (this.jwc == null)
				{
					return;
				}
				this.jwc.fep(this);
			}

			// Token: 0x06001E96 RID: 7830 RVA: 0x00089508 File Offset: 0x00087708
			public static void nkj(List<UnityUITextMeshProGlyphHelper.ih> a)
			{
				int count = a.Count;
				for (int i = 0; i < count; i++)
				{
					if (a[i] != null)
					{
						a[i].fet();
					}
				}
				a.Clear();
			}

			// Token: 0x06001E97 RID: 7831 RVA: 0x00089544 File Offset: 0x00087744
			public static void nva(List<UnityUITextMeshProGlyphHelper.ih> a)
			{
				int count = a.Count;
				for (int i = 0; i < count; i++)
				{
					if (a[i] != null)
					{
						a[i].fet();
					}
				}
				a.Clear();
			}

			// Token: 0x06001E98 RID: 7832 RVA: 0x000894EF File Offset: 0x000876EF
			public void hmb()
			{
				if (this.jwc == null)
				{
					return;
				}
				this.jwc.fep(this);
			}

			// Token: 0x06001E99 RID: 7833 RVA: 0x000894EF File Offset: 0x000876EF
			public void bsc()
			{
				if (this.jwc == null)
				{
					return;
				}
				this.jwc.fep(this);
			}

			// Token: 0x06001E9A RID: 7834
			protected abstract void feu();

			// Token: 0x06001E9B RID: 7835 RVA: 0x00089580 File Offset: 0x00087780
			public static void fev(List<UnityUITextMeshProGlyphHelper.ih> a)
			{
				int count = a.Count;
				for (int i = 0; i < count; i++)
				{
					if (a[i] != null)
					{
						a[i].fet();
					}
				}
				a.Clear();
			}

			// Token: 0x06001E9C RID: 7836 RVA: 0x000895BC File Offset: 0x000877BC
			public static void kim(List<UnityUITextMeshProGlyphHelper.ih> a)
			{
				int count = a.Count;
				for (int i = 0; i < count; i++)
				{
					if (a[i] != null)
					{
						a[i].fet();
					}
				}
				a.Clear();
			}

			// Token: 0x06001E9D RID: 7837 RVA: 0x000895F7 File Offset: 0x000877F7
			protected ih(UnityUITextMeshProGlyphHelper.ih.TagType a)
			{
				this.jwb = a;
			}

			// Token: 0x04000F93 RID: 3987
			public readonly UnityUITextMeshProGlyphHelper.ih.TagType jwb;

			// Token: 0x04000F94 RID: 3988
			private UnityUITextMeshProGlyphHelper.ih.@if jwc;

			// Token: 0x020001DB RID: 475
			public enum TagType
			{
				// Token: 0x04000F96 RID: 3990
				ControllerElement,
				// Token: 0x04000F97 RID: 3991
				Action,
				// Token: 0x04000F98 RID: 3992
				Player
			}

			// Token: 0x020001DC RID: 476
			public abstract class @if
			{
				// Token: 0x06001E9E RID: 7838
				public abstract bool fep(UnityUITextMeshProGlyphHelper.ih a);
			}

			// Token: 0x020001DD RID: 477
			public sealed class ig<a> : UnityUITextMeshProGlyphHelper.ih.@if where a : UnityUITextMeshProGlyphHelper.ih, new()
			{
				// Token: 0x06001EA0 RID: 7840 RVA: 0x00089606 File Offset: 0x00087806
				public ig()
				{
					this.jwa = new List<a>();
				}

				// Token: 0x06001EA1 RID: 7841 RVA: 0x0008961C File Offset: 0x0008781C
				public a feq()
				{
					a a;
					if (this.jwa.Count == 0)
					{
						a = new a();
						if (a != null)
						{
							a.lto = this;
						}
						return a;
					}
					int num = this.jwa.Count - 1;
					a = this.jwa[num];
					this.jwa.RemoveAt(num);
					return a;
				}

				// Token: 0x06001EA2 RID: 7842 RVA: 0x0008967C File Offset: 0x0008787C
				public override bool fep(UnityUITextMeshProGlyphHelper.ih a)
				{
					a a2 = a as a;
					if (a2 == null || a2.lto != this)
					{
						return false;
					}
					a2.feu();
					if (this.jwa.Contains(a2))
					{
						return false;
					}
					this.jwa.Add(a2);
					return true;
				}

				// Token: 0x04000F99 RID: 3993
				private readonly List<a> jwa;
			}
		}

		// Token: 0x020001DE RID: 478
		private sealed class ii : UnityUITextMeshProGlyphHelper.ih
		{
			// Token: 0x1700044D RID: 1101
			// (get) Token: 0x06001EA3 RID: 7843 RVA: 0x000896D5 File Offset: 0x000878D5
			public List<UnityUITextMeshProGlyphHelper.GlyphOrText> ltp
			{
				get
				{
					return this.jwh;
				}
			}

			// Token: 0x06001EA4 RID: 7844 RVA: 0x000896DD File Offset: 0x000878DD
			public ii()
				: base(UnityUITextMeshProGlyphHelper.ih.TagType.ControllerElement)
			{
				this.jwh = new List<UnityUITextMeshProGlyphHelper.GlyphOrText>();
				this.feu();
			}

			// Token: 0x06001EA5 RID: 7845 RVA: 0x000896F7 File Offset: 0x000878F7
			protected override void feu()
			{
				this.jwd = UnityUITextMeshProGlyphHelper.DisplayType.GlyphOrText;
				this.jwe = -1;
				this.jwf = -1;
				this.jwg = AxisRange.Full;
				this.jwh.Clear();
			}

			// Token: 0x06001EA6 RID: 7846 RVA: 0x00089720 File Offset: 0x00087920
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(typeof(UnityUITextMeshProGlyphHelper.ii).Name);
				stringBuilder.Append(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.cyw());
				stringBuilder.Append(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.epo());
				stringBuilder.Append(this.jwd);
				stringBuilder.Append(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.epp());
				stringBuilder.Append(this.jwe);
				stringBuilder.Append(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.epq());
				stringBuilder.Append(this.jwf);
				stringBuilder.Append(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.epr());
				stringBuilder.Append(this.jwg);
				return stringBuilder.ToString();
			}

			// Token: 0x06001EA7 RID: 7847 RVA: 0x000897C8 File Offset: 0x000879C8
			public static bool fex(string a, int b, int c, StringBuilder d, StringBuilder e, Dictionary<string, string> f, UnityUITextMeshProGlyphHelper.ih.ig<UnityUITextMeshProGlyphHelper.ii> g, out UnityUITextMeshProGlyphHelper.ii h)
			{
				h = null;
				if (string.IsNullOrEmpty(a) || b < 0 || b + c >= a.Length)
				{
					return false;
				}
				UnityUITextMeshProGlyphHelper.fjx(a, b, c, d, e, f);
				if (f.Count == 0)
				{
					return false;
				}
				h = g.feq();
				bool flag3;
				try
				{
					string text;
					if (f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eps(), out text))
					{
						bool flag = false;
						for (int i = 0; i < UnityUITextMeshProGlyphHelper.lvn.Length; i++)
						{
							if (string.Equals(text, UnityUITextMeshProGlyphHelper.lvn[i], StringComparison.OrdinalIgnoreCase))
							{
								h.jwd = UnityUITextMeshProGlyphHelper.lvo[i];
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.ept() + text);
						}
					}
					else
					{
						h.jwd = UnityUITextMeshProGlyphHelper.DisplayType.GlyphOrText;
					}
					if (f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.epu(), out text))
					{
						h.jwe = int.Parse(text);
						if (ReInput.players.GetPlayer(h.jwe) == null)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.epv() + h.jwe.ToString());
						}
					}
					else
					{
						if (!f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.epw(), out text))
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.epy());
						}
						Player player = ReInput.players.GetPlayer(text);
						if (player == null)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.epx() + text);
						}
						h.jwe = player.id;
					}
					if (f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.epz(), out text))
					{
						h.jwf = int.Parse(text);
						if (ReInput.mapping.GetAction(h.jwf) == null)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqa() + h.jwf.ToString());
						}
					}
					else
					{
						if (!f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqb(), out text))
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqd());
						}
						InputAction action = ReInput.mapping.GetAction(text);
						if (action == null)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqc() + text);
						}
						h.jwf = action.id;
					}
					if (f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqe(), out text))
					{
						bool flag2 = false;
						for (int j = 0; j < UnityUITextMeshProGlyphHelper.lvp.Length; j++)
						{
							if (string.Equals(text, UnityUITextMeshProGlyphHelper.lvp[j], StringComparison.OrdinalIgnoreCase))
							{
								h.jwg = UnityUITextMeshProGlyphHelper.lvq[j];
								flag2 = true;
								break;
							}
						}
						if (!flag2)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqf() + text);
						}
					}
					else
					{
						h.jwg = AxisRange.Full;
					}
					flag3 = true;
				}
				catch (Exception ex)
				{
					Debug.LogError(ex);
					h.fet();
					flag3 = false;
				}
				return flag3;
			}

			// Token: 0x06001EA8 RID: 7848 RVA: 0x00089A54 File Offset: 0x00087C54
			public static bool fcu(string a, int b, int c, StringBuilder d, StringBuilder e, Dictionary<string, string> f, UnityUITextMeshProGlyphHelper.ih.ig<UnityUITextMeshProGlyphHelper.ii> g, out UnityUITextMeshProGlyphHelper.ii h)
			{
				h = null;
				if (string.IsNullOrEmpty(a) || b < 0 || b + c >= a.Length)
				{
					return false;
				}
				UnityUITextMeshProGlyphHelper.fjx(a, b, c, d, e, f);
				if (f.Count == 0)
				{
					return false;
				}
				h = g.feq();
				bool flag3;
				try
				{
					string text;
					if (f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqg(), out text))
					{
						bool flag = false;
						for (int i = 0; i < UnityUITextMeshProGlyphHelper.lvn.Length; i++)
						{
							if (string.Equals(text, UnityUITextMeshProGlyphHelper.lvn[i], StringComparison.OrdinalIgnoreCase))
							{
								h.jwd = UnityUITextMeshProGlyphHelper.lvo[i];
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqh() + text);
						}
					}
					else
					{
						h.jwd = UnityUITextMeshProGlyphHelper.DisplayType.GlyphOrText;
					}
					if (f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqi(), out text))
					{
						h.jwe = int.Parse(text);
						if (ReInput.players.GetPlayer(h.jwe) == null)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqj() + h.jwe.ToString());
						}
					}
					else
					{
						if (!f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqk(), out text))
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqm());
						}
						Player player = ReInput.players.GetPlayer(text);
						if (player == null)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eql() + text);
						}
						h.jwe = player.id;
					}
					if (f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqn(), out text))
					{
						h.jwf = int.Parse(text);
						if (ReInput.mapping.GetAction(h.jwf) == null)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqo() + h.jwf.ToString());
						}
					}
					else
					{
						if (!f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqp(), out text))
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqr());
						}
						InputAction action = ReInput.mapping.GetAction(text);
						if (action == null)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqq() + text);
						}
						h.jwf = action.id;
					}
					if (f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqs(), out text))
					{
						bool flag2 = false;
						for (int j = 0; j < UnityUITextMeshProGlyphHelper.lvp.Length; j++)
						{
							if (string.Equals(text, UnityUITextMeshProGlyphHelper.lvp[j], StringComparison.OrdinalIgnoreCase))
							{
								h.jwg = UnityUITextMeshProGlyphHelper.lvq[j];
								flag2 = true;
								break;
							}
						}
						if (!flag2)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqt() + text);
						}
					}
					else
					{
						h.jwg = AxisRange.Full;
					}
					flag3 = true;
				}
				catch (Exception ex)
				{
					Debug.LogError(ex);
					h.fet();
					flag3 = false;
				}
				return flag3;
			}

			// Token: 0x04000F9A RID: 3994
			public UnityUITextMeshProGlyphHelper.DisplayType jwd;

			// Token: 0x04000F9B RID: 3995
			public int jwe;

			// Token: 0x04000F9C RID: 3996
			public int jwf;

			// Token: 0x04000F9D RID: 3997
			public AxisRange jwg;

			// Token: 0x04000F9E RID: 3998
			private readonly List<UnityUITextMeshProGlyphHelper.GlyphOrText> jwh;
		}

		// Token: 0x020001DF RID: 479
		private sealed class ij : UnityUITextMeshProGlyphHelper.ih
		{
			// Token: 0x06001EA9 RID: 7849 RVA: 0x00089CE0 File Offset: 0x00087EE0
			public ij()
				: base(UnityUITextMeshProGlyphHelper.ih.TagType.Action)
			{
				this.feu();
			}

			// Token: 0x1700044E RID: 1102
			// (get) Token: 0x06001EAC RID: 7852 RVA: 0x00089D0F File Offset: 0x00087F0F
			// (set) Token: 0x06001EAA RID: 7850 RVA: 0x00089CEF File Offset: 0x00087EEF
			public string ltq
			{
				get
				{
					return this.jwk;
				}
				set
				{
					this.jwk = value;
				}
			}

			// Token: 0x06001EAB RID: 7851 RVA: 0x00089CF8 File Offset: 0x00087EF8
			protected override void feu()
			{
				this.jwi = -1;
				this.jwj = AxisRange.Full;
				this.jwk = null;
			}

			// Token: 0x06001EAD RID: 7853 RVA: 0x00089D18 File Offset: 0x00087F18
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(typeof(UnityUITextMeshProGlyphHelper.ii).Name);
				stringBuilder.Append(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.cyw());
				stringBuilder.Append(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.equ());
				stringBuilder.Append(this.jwi);
				stringBuilder.Append(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.epr());
				stringBuilder.Append(this.jwj);
				return stringBuilder.ToString();
			}

			// Token: 0x06001EAE RID: 7854 RVA: 0x00089D88 File Offset: 0x00087F88
			public static bool ffa(string a, int b, int c, StringBuilder d, StringBuilder e, Dictionary<string, string> f, UnityUITextMeshProGlyphHelper.ih.ig<UnityUITextMeshProGlyphHelper.ij> g, out UnityUITextMeshProGlyphHelper.ij h)
			{
				h = null;
				if (string.IsNullOrEmpty(a) || b < 0 || b + c >= a.Length)
				{
					return false;
				}
				UnityUITextMeshProGlyphHelper.fjx(a, b, c, d, e, f);
				if (f.Count == 0)
				{
					return false;
				}
				h = g.feq();
				bool flag2;
				try
				{
					string text;
					if (f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqv(), out text) || f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.epz(), out text))
					{
						h.jwi = int.Parse(text);
						if (ReInput.mapping.GetAction(h.jwi) == null)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqa() + h.jwi.ToString());
						}
					}
					else
					{
						if (!f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.bdh(), out text) && !f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqb(), out text))
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqd());
						}
						InputAction action = ReInput.mapping.GetAction(text);
						if (action == null)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqc() + text);
						}
						h.jwi = action.id;
					}
					if (f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqw(), out text) || f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqe(), out text))
					{
						bool flag = false;
						for (int i = 0; i < UnityUITextMeshProGlyphHelper.lvp.Length; i++)
						{
							if (string.Equals(text, UnityUITextMeshProGlyphHelper.lvp[i], StringComparison.OrdinalIgnoreCase))
							{
								h.jwj = UnityUITextMeshProGlyphHelper.lvq[i];
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqf() + text);
						}
					}
					else
					{
						h.jwj = AxisRange.Full;
					}
					flag2 = true;
				}
				catch (Exception ex)
				{
					Debug.LogError(ex);
					h.fet();
					flag2 = false;
				}
				return flag2;
			}

			// Token: 0x04000F9F RID: 3999
			public int jwi;

			// Token: 0x04000FA0 RID: 4000
			public AxisRange jwj;

			// Token: 0x04000FA1 RID: 4001
			private string jwk;
		}

		// Token: 0x020001E0 RID: 480
		private sealed class ik : UnityUITextMeshProGlyphHelper.ih
		{
			// Token: 0x06001EAF RID: 7855 RVA: 0x00089F3C File Offset: 0x0008813C
			public static bool ffd(string a, int b, int c, StringBuilder d, StringBuilder e, Dictionary<string, string> f, UnityUITextMeshProGlyphHelper.ih.ig<UnityUITextMeshProGlyphHelper.ik> g, out UnityUITextMeshProGlyphHelper.ik h)
			{
				h = null;
				if (string.IsNullOrEmpty(a) || b < 0 || b + c >= a.Length)
				{
					return false;
				}
				UnityUITextMeshProGlyphHelper.fjx(a, b, c, d, e, f);
				if (f.Count == 0)
				{
					return false;
				}
				h = g.feq();
				bool flag;
				try
				{
					string text;
					if (f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqv(), out text) || f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.epu(), out text))
					{
						h.jwl = int.Parse(text);
						if (ReInput.players.GetPlayer(h.jwl) == null)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.epv() + h.jwl.ToString());
						}
					}
					else
					{
						if (!f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.bdh(), out text) && !f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.epw(), out text))
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.epy());
						}
						Player player = ReInput.players.GetPlayer(text);
						if (player == null)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.epx() + text);
						}
						h.jwl = player.id;
					}
					flag = true;
				}
				catch (Exception ex)
				{
					Debug.LogError(ex);
					h.fet();
					flag = false;
				}
				return flag;
			}

			// Token: 0x06001EB0 RID: 7856 RVA: 0x0008A06C File Offset: 0x0008826C
			public static bool lrh(string a, int b, int c, StringBuilder d, StringBuilder e, Dictionary<string, string> f, UnityUITextMeshProGlyphHelper.ih.ig<UnityUITextMeshProGlyphHelper.ik> g, out UnityUITextMeshProGlyphHelper.ik h)
			{
				h = null;
				if (string.IsNullOrEmpty(a) || b < 0 || b + c >= a.Length)
				{
					return false;
				}
				UnityUITextMeshProGlyphHelper.fjx(a, b, c, d, e, f);
				if (f.Count == 0)
				{
					return false;
				}
				h = g.feq();
				bool flag;
				try
				{
					string text;
					if (f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqx(), out text) || f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqy(), out text))
					{
						h.jwl = int.Parse(text);
						if (ReInput.players.GetPlayer(h.jwl) == null)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eqz() + h.jwl.ToString());
						}
					}
					else
					{
						if (!f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.era(), out text) && !f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.erb(), out text))
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.erd());
						}
						Player player = ReInput.players.GetPlayer(text);
						if (player == null)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.erc() + text);
						}
						h.jwl = player.id;
					}
					flag = true;
				}
				catch (Exception ex)
				{
					Debug.LogError(ex);
					h.fet();
					flag = false;
				}
				return flag;
			}

			// Token: 0x1700044F RID: 1103
			// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x0008A32A File Offset: 0x0008852A
			// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x0008A19C File Offset: 0x0008839C
			public string ltr
			{
				get
				{
					return this.jwm;
				}
				set
				{
					this.jwm = value;
				}
			}

			// Token: 0x06001EB2 RID: 7858 RVA: 0x0008A1A8 File Offset: 0x000883A8
			public static bool jbt(string a, int b, int c, StringBuilder d, StringBuilder e, Dictionary<string, string> f, UnityUITextMeshProGlyphHelper.ih.ig<UnityUITextMeshProGlyphHelper.ik> g, out UnityUITextMeshProGlyphHelper.ik h)
			{
				h = null;
				if (string.IsNullOrEmpty(a) || b < 0 || b + c >= a.Length)
				{
					return false;
				}
				UnityUITextMeshProGlyphHelper.fjx(a, b, c, d, e, f);
				if (f.Count == 0)
				{
					return false;
				}
				h = g.feq();
				bool flag;
				try
				{
					string text;
					if (f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.ere(), out text) || f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.erf(), out text))
					{
						h.jwl = int.Parse(text);
						if (ReInput.players.GetPlayer(h.jwl) == null)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.erg() + h.jwl.ToString());
						}
					}
					else
					{
						if (!f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.erh(), out text) && !f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eri(), out text))
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.erk());
						}
						Player player = ReInput.players.GetPlayer(text);
						if (player == null)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.erj() + text);
						}
						h.jwl = player.id;
					}
					flag = true;
				}
				catch (Exception ex)
				{
					Debug.LogError(ex);
					h.fet();
					flag = false;
				}
				return flag;
			}

			// Token: 0x06001EB3 RID: 7859 RVA: 0x0008A2D8 File Offset: 0x000884D8
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(typeof(UnityUITextMeshProGlyphHelper.ii).Name);
				stringBuilder.Append(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.cyw());
				stringBuilder.Append(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.erl());
				stringBuilder.Append(this.jwl);
				return stringBuilder.ToString();
			}

			// Token: 0x06001EB5 RID: 7861 RVA: 0x0008A334 File Offset: 0x00088534
			public static bool epe(string a, int b, int c, StringBuilder d, StringBuilder e, Dictionary<string, string> f, UnityUITextMeshProGlyphHelper.ih.ig<UnityUITextMeshProGlyphHelper.ik> g, out UnityUITextMeshProGlyphHelper.ik h)
			{
				h = null;
				if (string.IsNullOrEmpty(a) || b < 0 || b + c >= a.Length)
				{
					return false;
				}
				UnityUITextMeshProGlyphHelper.fjx(a, b, c, d, e, f);
				if (f.Count == 0)
				{
					return false;
				}
				h = g.feq();
				bool flag;
				try
				{
					string text;
					if (f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.erm(), out text) || f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.ern(), out text))
					{
						h.jwl = int.Parse(text);
						if (ReInput.players.GetPlayer(h.jwl) == null)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.ero() + h.jwl.ToString());
						}
					}
					else
					{
						if (!f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.erp(), out text) && !f.TryGetValue(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.erq(), out text))
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.ers());
						}
						Player player = ReInput.players.GetPlayer(text);
						if (player == null)
						{
							throw new Exception(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.err() + text);
						}
						h.jwl = player.id;
					}
					flag = true;
				}
				catch (Exception ex)
				{
					Debug.LogError(ex);
					h.fet();
					flag = false;
				}
				return flag;
			}

			// Token: 0x06001EB6 RID: 7862 RVA: 0x0008A464 File Offset: 0x00088664
			public ik()
				: base(UnityUITextMeshProGlyphHelper.ih.TagType.Player)
			{
				this.feu();
			}

			// Token: 0x06001EB7 RID: 7863 RVA: 0x0008A473 File Offset: 0x00088673
			protected override void feu()
			{
				this.jwl = -1;
				this.jwm = null;
			}

			// Token: 0x04000FA2 RID: 4002
			public int jwl;

			// Token: 0x04000FA3 RID: 4003
			private string jwm;
		}

		// Token: 0x020001E1 RID: 481
		private struct GlyphOrText : IEquatable<UnityUITextMeshProGlyphHelper.GlyphOrText>
		{
			// Token: 0x06001EB8 RID: 7864 RVA: 0x0008A484 File Offset: 0x00088684
			public override bool Equals(object obj)
			{
				if (!(obj is UnityUITextMeshProGlyphHelper.GlyphOrText))
				{
					return false;
				}
				UnityUITextMeshProGlyphHelper.GlyphOrText glyphOrText = (UnityUITextMeshProGlyphHelper.GlyphOrText)obj;
				return string.Equals(glyphOrText.glyphKey, this.glyphKey, StringComparison.Ordinal) && glyphOrText.sprite == this.sprite && string.Equals(glyphOrText.name, this.name, StringComparison.Ordinal);
			}

			// Token: 0x06001EB9 RID: 7865 RVA: 0x0008A4DD File Offset: 0x000886DD
			public override int GetHashCode()
			{
				return ((17 * 29 + this.glyphKey.GetHashCode()) * 29 + this.sprite.GetHashCode()) * 29 + this.name.GetHashCode();
			}

			// Token: 0x06001EBA RID: 7866 RVA: 0x0008A50E File Offset: 0x0008870E
			public bool Equals(UnityUITextMeshProGlyphHelper.GlyphOrText other)
			{
				return string.Equals(other.glyphKey, this.glyphKey, StringComparison.Ordinal) && other.sprite == this.sprite && string.Equals(other.name, this.name, StringComparison.Ordinal);
			}

			// Token: 0x06001EBB RID: 7867 RVA: 0x0008A54B File Offset: 0x0008874B
			public static bool ffe(UnityUITextMeshProGlyphHelper.GlyphOrText a, UnityUITextMeshProGlyphHelper.GlyphOrText b)
			{
				return string.Equals(a.glyphKey, b.glyphKey, StringComparison.Ordinal) && a.sprite == b.sprite && string.Equals(a.name, b.name, StringComparison.Ordinal);
			}

			// Token: 0x06001EBC RID: 7868 RVA: 0x0008A588 File Offset: 0x00088788
			public static bool fff(UnityUITextMeshProGlyphHelper.GlyphOrText a, UnityUITextMeshProGlyphHelper.GlyphOrText b)
			{
				return !UnityUITextMeshProGlyphHelper.GlyphOrText.ffe(a, b);
			}

			// Token: 0x04000FA4 RID: 4004
			public string glyphKey;

			// Token: 0x04000FA5 RID: 4005
			public Sprite sprite;

			// Token: 0x04000FA6 RID: 4006
			public string name;
		}

		// Token: 0x020001E2 RID: 482
		private class il
		{
			// Token: 0x06001EBD RID: 7869 RVA: 0x0008A594 File Offset: 0x00088794
			public void ijw()
			{
				if (this.jwo != null)
				{
					this.jwo.fhk();
					this.jwo = null;
				}
				if (this.jwp != null)
				{
					global::UnityEngine.Object.Destroy(this.jwp);
					this.jwp = null;
				}
			}

			// Token: 0x06001EBE RID: 7870 RVA: 0x0008A5D0 File Offset: 0x000887D0
			public static Material blj(Material a, uint b)
			{
				Material material = ((a != null) ? new Material(a) : new Material(UnityUITextMeshProGlyphHelper.il.ltu));
				material.name = typeof(UnityUITextMeshProGlyphHelper).Name + global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.ert() + b.ToString();
				material.hideFlags = HideFlags.HideInHierarchy;
				return material;
			}

			// Token: 0x17000452 RID: 1106
			// (get) Token: 0x06001EBF RID: 7871 RVA: 0x0008A625 File Offset: 0x00088825
			private static Shader ltu
			{
				get
				{
					if (UnityUITextMeshProGlyphHelper.il.jwr == null)
					{
						ShaderUtilities.GetShaderPropertyIDs();
						UnityUITextMeshProGlyphHelper.il.jwr = Shader.Find(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eru());
					}
					return UnityUITextMeshProGlyphHelper.il.jwr;
				}
			}

			// Token: 0x06001EC0 RID: 7872 RVA: 0x0008A650 File Offset: 0x00088850
			public static Material ffi(Material a, uint b)
			{
				Material material = ((a != null) ? new Material(a) : new Material(UnityUITextMeshProGlyphHelper.il.ltu));
				material.name = typeof(UnityUITextMeshProGlyphHelper).Name + global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.erv() + b.ToString();
				material.hideFlags = HideFlags.HideInHierarchy;
				return material;
			}

			// Token: 0x17000451 RID: 1105
			// (get) Token: 0x06001EC1 RID: 7873 RVA: 0x0008A6A5 File Offset: 0x000888A5
			public Material ltt
			{
				get
				{
					return this.jwp;
				}
			}

			// Token: 0x06001EC2 RID: 7874 RVA: 0x0008A594 File Offset: 0x00088794
			public void opk()
			{
				if (this.jwo != null)
				{
					this.jwo.fhk();
					this.jwo = null;
				}
				if (this.jwp != null)
				{
					global::UnityEngine.Object.Destroy(this.jwp);
					this.jwp = null;
				}
			}

			// Token: 0x06001EC3 RID: 7875 RVA: 0x0008A594 File Offset: 0x00088794
			public void ffj()
			{
				if (this.jwo != null)
				{
					this.jwo.fhk();
					this.jwo = null;
				}
				if (this.jwp != null)
				{
					global::UnityEngine.Object.Destroy(this.jwp);
					this.jwp = null;
				}
			}

			// Token: 0x17000450 RID: 1104
			// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x0008A6AD File Offset: 0x000888AD
			public UnityUITextMeshProGlyphHelper.@in lts
			{
				get
				{
					return this.jwo;
				}
			}

			// Token: 0x06001EC5 RID: 7877 RVA: 0x0008A6B8 File Offset: 0x000888B8
			public static Material muq(Material a, uint b)
			{
				Material material = ((a != null) ? new Material(a) : new Material(UnityUITextMeshProGlyphHelper.il.ltu));
				material.name = typeof(UnityUITextMeshProGlyphHelper).Name + global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.erw() + b.ToString();
				material.hideFlags = HideFlags.HideInHierarchy;
				return material;
			}

			// Token: 0x06001EC6 RID: 7878 RVA: 0x0008A594 File Offset: 0x00088794
			public void ivi()
			{
				if (this.jwo != null)
				{
					this.jwo.fhk();
					this.jwo = null;
				}
				if (this.jwp != null)
				{
					global::UnityEngine.Object.Destroy(this.jwp);
					this.jwp = null;
				}
			}

			// Token: 0x06001EC7 RID: 7879 RVA: 0x0008A710 File Offset: 0x00088910
			public static Material kr(Material a, uint b)
			{
				Material material = ((a != null) ? new Material(a) : new Material(UnityUITextMeshProGlyphHelper.il.ltu));
				material.name = typeof(UnityUITextMeshProGlyphHelper).Name + global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.erx() + b.ToString();
				material.hideFlags = HideFlags.HideInHierarchy;
				return material;
			}

			// Token: 0x06001EC8 RID: 7880 RVA: 0x0008A768 File Offset: 0x00088968
			public il(Material a)
			{
				this.jwn = UnityUITextMeshProGlyphHelper.il.jwq++;
				this.jwo = UnityUITextMeshProGlyphHelper.io.fhn();
				TMP_SpriteAsset tmp_SpriteAsset = this.jwo.fhe();
				tmp_SpriteAsset.name = typeof(UnityUITextMeshProGlyphHelper).Name + global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.ery() + this.jwn.ToString();
				tmp_SpriteAsset.hashCode = TMP_TextUtilities.GetSimpleHashCode(tmp_SpriteAsset.name);
				this.jwp = UnityUITextMeshProGlyphHelper.il.ffi(a, this.jwn);
				if (this.jwo != null)
				{
					tmp_SpriteAsset.material = this.ltt;
					tmp_SpriteAsset.materialHashCode = TMP_TextUtilities.GetSimpleHashCode(this.ltt.name);
				}
			}

			// Token: 0x04000FA7 RID: 4007
			public readonly uint jwn;

			// Token: 0x04000FA8 RID: 4008
			private UnityUITextMeshProGlyphHelper.@in jwo;

			// Token: 0x04000FA9 RID: 4009
			private Material jwp;

			// Token: 0x04000FAA RID: 4010
			private static uint jwq;

			// Token: 0x04000FAB RID: 4011
			private static Shader jwr;
		}

		// Token: 0x020001E3 RID: 483
		[Serializable]
		public struct TMProSpriteOptions : IEquatable<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>
		{
			// Token: 0x17000453 RID: 1107
			// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x0008A81C File Offset: 0x00088A1C
			// (set) Token: 0x06001ECA RID: 7882 RVA: 0x0008A824 File Offset: 0x00088A24
			public float ltv
			{
				get
				{
					return this._scale;
				}
				set
				{
					this._scale = value;
				}
			}

			// Token: 0x17000454 RID: 1108
			// (get) Token: 0x06001ECB RID: 7883 RVA: 0x0008A82D File Offset: 0x00088A2D
			// (set) Token: 0x06001ECC RID: 7884 RVA: 0x0008A835 File Offset: 0x00088A35
			public Vector2 ltw
			{
				get
				{
					return this._offsetSizeMultiplier;
				}
				set
				{
					this._offsetSizeMultiplier = value;
				}
			}

			// Token: 0x17000455 RID: 1109
			// (get) Token: 0x06001ECD RID: 7885 RVA: 0x0008A83E File Offset: 0x00088A3E
			// (set) Token: 0x06001ECE RID: 7886 RVA: 0x0008A846 File Offset: 0x00088A46
			public Vector2 ltx
			{
				get
				{
					return this._extraOffset;
				}
				set
				{
					this._extraOffset = value;
				}
			}

			// Token: 0x17000456 RID: 1110
			// (get) Token: 0x06001ECF RID: 7887 RVA: 0x0008A84F File Offset: 0x00088A4F
			// (set) Token: 0x06001ED0 RID: 7888 RVA: 0x0008A857 File Offset: 0x00088A57
			public float lty
			{
				get
				{
					return this._xAdvanceWidthMultiplier;
				}
				set
				{
					this._xAdvanceWidthMultiplier = value;
				}
			}

			// Token: 0x17000457 RID: 1111
			// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x0008A860 File Offset: 0x00088A60
			// (set) Token: 0x06001ED2 RID: 7890 RVA: 0x0008A868 File Offset: 0x00088A68
			public float ltz
			{
				get
				{
					return this._extraXAdvance;
				}
				set
				{
					this._extraXAdvance = value;
				}
			}

			// Token: 0x17000458 RID: 1112
			// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x0008A874 File Offset: 0x00088A74
			public static UnityUITextMeshProGlyphHelper.TMProSpriteOptions lua
			{
				get
				{
					return new UnityUITextMeshProGlyphHelper.TMProSpriteOptions
					{
						ltv = 1.5f,
						ltx = default(Vector2),
						ltw = new Vector2(0f, 0.75f),
						lty = 1f
					};
				}
			}

			// Token: 0x06001ED4 RID: 7892 RVA: 0x0008A8C8 File Offset: 0x00088AC8
			public override bool Equals(object obj)
			{
				if (!(obj is UnityUITextMeshProGlyphHelper.TMProSpriteOptions))
				{
					return false;
				}
				UnityUITextMeshProGlyphHelper.TMProSpriteOptions tmproSpriteOptions = (UnityUITextMeshProGlyphHelper.TMProSpriteOptions)obj;
				return tmproSpriteOptions._scale == this._scale && tmproSpriteOptions._offsetSizeMultiplier == this._offsetSizeMultiplier && tmproSpriteOptions._extraOffset == this._extraOffset && tmproSpriteOptions._xAdvanceWidthMultiplier == this._xAdvanceWidthMultiplier && tmproSpriteOptions._extraXAdvance == this._extraXAdvance;
			}

			// Token: 0x06001ED5 RID: 7893 RVA: 0x0008A938 File Offset: 0x00088B38
			public override int GetHashCode()
			{
				return ((((17 * 29 + this._scale.GetHashCode()) * 29 + this._offsetSizeMultiplier.GetHashCode()) * 29 + this._extraOffset.GetHashCode()) * 29 + this._xAdvanceWidthMultiplier.GetHashCode()) * 29 + this._extraXAdvance.GetHashCode();
			}

			// Token: 0x06001ED6 RID: 7894 RVA: 0x0008A9A0 File Offset: 0x00088BA0
			public bool Equals(UnityUITextMeshProGlyphHelper.TMProSpriteOptions other)
			{
				return other._scale == this._scale && other._offsetSizeMultiplier == this._offsetSizeMultiplier && other._extraOffset == this._extraOffset && other._xAdvanceWidthMultiplier == this._xAdvanceWidthMultiplier && other._extraXAdvance == this._extraXAdvance;
			}

			// Token: 0x06001ED7 RID: 7895 RVA: 0x0008AA00 File Offset: 0x00088C00
			public static bool ffw(UnityUITextMeshProGlyphHelper.TMProSpriteOptions a, UnityUITextMeshProGlyphHelper.TMProSpriteOptions b)
			{
				return a._scale == b._scale && a._offsetSizeMultiplier == b._offsetSizeMultiplier && a._extraOffset == b._extraOffset && a._xAdvanceWidthMultiplier == b._xAdvanceWidthMultiplier && a._extraXAdvance == b._extraXAdvance;
			}

			// Token: 0x06001ED8 RID: 7896 RVA: 0x0008AA5F File Offset: 0x00088C5F
			public static bool ffx(UnityUITextMeshProGlyphHelper.TMProSpriteOptions a, UnityUITextMeshProGlyphHelper.TMProSpriteOptions b)
			{
				return !UnityUITextMeshProGlyphHelper.TMProSpriteOptions.ffw(a, b);
			}

			// Token: 0x04000FAC RID: 4012
			[SerializeField]
			private float _scale;

			// Token: 0x04000FAD RID: 4013
			[SerializeField]
			private Vector2 _offsetSizeMultiplier;

			// Token: 0x04000FAE RID: 4014
			[SerializeField]
			private Vector2 _extraOffset;

			// Token: 0x04000FAF RID: 4015
			[SerializeField]
			private float _xAdvanceWidthMultiplier;

			// Token: 0x04000FB0 RID: 4016
			[SerializeField]
			private float _extraXAdvance;
		}

		// Token: 0x020001E4 RID: 484
		[Serializable]
		public struct SpriteMaterialProperties
		{
			// Token: 0x17000459 RID: 1113
			// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x0008AA6B File Offset: 0x00088C6B
			// (set) Token: 0x06001EDA RID: 7898 RVA: 0x0008AA73 File Offset: 0x00088C73
			public Color lub
			{
				get
				{
					return this._color;
				}
				set
				{
					this._color = value;
				}
			}

			// Token: 0x1700045A RID: 1114
			// (get) Token: 0x06001EDB RID: 7899 RVA: 0x0008AA7C File Offset: 0x00088C7C
			public static UnityUITextMeshProGlyphHelper.SpriteMaterialProperties luc
			{
				get
				{
					return new UnityUITextMeshProGlyphHelper.SpriteMaterialProperties
					{
						_color = Color.white
					};
				}
			}

			// Token: 0x04000FB1 RID: 4017
			[SerializeField]
			private Color _color;
		}

		// Token: 0x020001E5 RID: 485
		private interface im
		{
			// Token: 0x1700045B RID: 1115
			// (get) Token: 0x06001EDC RID: 7900
			// (set) Token: 0x06001EDD RID: 7901
			uint lud { get; set; }

			// Token: 0x1700045C RID: 1116
			// (get) Token: 0x06001EDE RID: 7902
			// (set) Token: 0x06001EDF RID: 7903
			float lue { get; set; }

			// Token: 0x1700045D RID: 1117
			// (get) Token: 0x06001EE0 RID: 7904
			// (set) Token: 0x06001EE1 RID: 7905
			float luf { get; set; }

			// Token: 0x1700045E RID: 1118
			// (get) Token: 0x06001EE2 RID: 7906
			// (set) Token: 0x06001EE3 RID: 7907
			float lug { get; set; }

			// Token: 0x1700045F RID: 1119
			// (get) Token: 0x06001EE4 RID: 7908
			// (set) Token: 0x06001EE5 RID: 7909
			float luh { get; set; }

			// Token: 0x17000460 RID: 1120
			// (get) Token: 0x06001EE6 RID: 7910
			// (set) Token: 0x06001EE7 RID: 7911
			float lui { get; set; }

			// Token: 0x17000461 RID: 1121
			// (get) Token: 0x06001EE8 RID: 7912
			// (set) Token: 0x06001EE9 RID: 7913
			Vector2 luj { get; set; }

			// Token: 0x17000462 RID: 1122
			// (get) Token: 0x06001EEA RID: 7914
			// (set) Token: 0x06001EEB RID: 7915
			Vector2 luk { get; set; }

			// Token: 0x17000463 RID: 1123
			// (get) Token: 0x06001EEC RID: 7916
			// (set) Token: 0x06001EED RID: 7917
			float lul { get; set; }

			// Token: 0x17000464 RID: 1124
			// (get) Token: 0x06001EEE RID: 7918
			// (set) Token: 0x06001EEF RID: 7919
			string lum { get; set; }

			// Token: 0x17000465 RID: 1125
			// (get) Token: 0x06001EF0 RID: 7920
			// (set) Token: 0x06001EF1 RID: 7921
			uint lun { get; set; }

			// Token: 0x17000466 RID: 1126
			// (get) Token: 0x06001EF2 RID: 7922
			// (set) Token: 0x06001EF3 RID: 7923
			int luo { get; set; }

			// Token: 0x17000467 RID: 1127
			// (get) Token: 0x06001EF4 RID: 7924
			// (set) Token: 0x06001EF5 RID: 7925
			Sprite lup { get; set; }
		}

		// Token: 0x020001E6 RID: 486
		private interface @in
		{
			// Token: 0x17000468 RID: 1128
			// (get) Token: 0x06001EF6 RID: 7926
			int luq { get; }

			// Token: 0x17000469 RID: 1129
			// (get) Token: 0x06001EF7 RID: 7927
			// (set) Token: 0x06001EF8 RID: 7928
			Texture lur { get; set; }

			// Token: 0x06001EF9 RID: 7929
			TMP_SpriteAsset fhe();

			// Token: 0x06001EFA RID: 7930
			UnityUITextMeshProGlyphHelper.im fhf(int a);

			// Token: 0x06001EFB RID: 7931
			void fhg(UnityUITextMeshProGlyphHelper.im a);

			// Token: 0x06001EFC RID: 7932
			bool fhh(string a);

			// Token: 0x06001EFD RID: 7933
			void fhi();

			// Token: 0x06001EFE RID: 7934
			void fhj();

			// Token: 0x06001EFF RID: 7935
			void fhk();
		}

		// Token: 0x020001E7 RID: 487
		private static class io
		{
			// Token: 0x06001F00 RID: 7936 RVA: 0x0008AAA0 File Offset: 0x00088CA0
			public static UnityUITextMeshProGlyphHelper.im opq()
			{
				if (!UnityUITextMeshProGlyphHelper.io.fhl())
				{
					return new UnityUITextMeshProGlyphHelper.iq();
				}
				return new UnityUITextMeshProGlyphHelper.iv();
			}

			// Token: 0x06001F01 RID: 7937 RVA: 0x0008AAC4 File Offset: 0x00088CC4
			public static UnityUITextMeshProGlyphHelper.@in eta()
			{
				if (!UnityUITextMeshProGlyphHelper.io.fhl())
				{
					return new UnityUITextMeshProGlyphHelper.iq.ip();
				}
				return new UnityUITextMeshProGlyphHelper.iv.iu();
			}

			// Token: 0x06001F02 RID: 7938 RVA: 0x0008AAE8 File Offset: 0x00088CE8
			private static bool ino()
			{
				bool flag = UnityUITextMeshProGlyphHelper.iv.fif();
				if (UnityUITextMeshProGlyphHelper.io.jws)
				{
					return flag;
				}
				UnityUITextMeshProGlyphHelper.io.jws = true;
				return flag;
			}

			// Token: 0x06001F03 RID: 7939 RVA: 0x0008AB10 File Offset: 0x00088D10
			private static bool gid()
			{
				bool flag = UnityUITextMeshProGlyphHelper.iv.fif();
				if (UnityUITextMeshProGlyphHelper.io.jws)
				{
					return flag;
				}
				UnityUITextMeshProGlyphHelper.io.jws = true;
				return flag;
			}

			// Token: 0x06001F04 RID: 7940 RVA: 0x0008AB38 File Offset: 0x00088D38
			public static UnityUITextMeshProGlyphHelper.@in cte()
			{
				if (!UnityUITextMeshProGlyphHelper.io.fhl())
				{
					return new UnityUITextMeshProGlyphHelper.iq.ip();
				}
				return new UnityUITextMeshProGlyphHelper.iv.iu();
			}

			// Token: 0x06001F05 RID: 7941 RVA: 0x0008AB5C File Offset: 0x00088D5C
			private static bool fzc()
			{
				bool flag = UnityUITextMeshProGlyphHelper.iv.fif();
				if (UnityUITextMeshProGlyphHelper.io.jws)
				{
					return flag;
				}
				UnityUITextMeshProGlyphHelper.io.jws = true;
				return flag;
			}

			// Token: 0x06001F06 RID: 7942 RVA: 0x0008AB84 File Offset: 0x00088D84
			public static UnityUITextMeshProGlyphHelper.@in fhn()
			{
				if (!UnityUITextMeshProGlyphHelper.io.fhl())
				{
					return new UnityUITextMeshProGlyphHelper.iq.ip();
				}
				return new UnityUITextMeshProGlyphHelper.iv.iu();
			}

			// Token: 0x06001F07 RID: 7943 RVA: 0x0008ABA8 File Offset: 0x00088DA8
			public static UnityUITextMeshProGlyphHelper.@in hgg()
			{
				if (!UnityUITextMeshProGlyphHelper.io.fhl())
				{
					return new UnityUITextMeshProGlyphHelper.iq.ip();
				}
				return new UnityUITextMeshProGlyphHelper.iv.iu();
			}

			// Token: 0x06001F08 RID: 7944 RVA: 0x0008ABCC File Offset: 0x00088DCC
			private static bool fhl()
			{
				bool flag = UnityUITextMeshProGlyphHelper.iv.fif();
				if (UnityUITextMeshProGlyphHelper.io.jws)
				{
					return flag;
				}
				UnityUITextMeshProGlyphHelper.io.jws = true;
				return flag;
			}

			// Token: 0x06001F09 RID: 7945 RVA: 0x0008ABF4 File Offset: 0x00088DF4
			public static UnityUITextMeshProGlyphHelper.@in iql()
			{
				if (!UnityUITextMeshProGlyphHelper.io.fhl())
				{
					return new UnityUITextMeshProGlyphHelper.iq.ip();
				}
				return new UnityUITextMeshProGlyphHelper.iv.iu();
			}

			// Token: 0x06001F0A RID: 7946 RVA: 0x0008AC18 File Offset: 0x00088E18
			public static UnityUITextMeshProGlyphHelper.im ekt()
			{
				if (!UnityUITextMeshProGlyphHelper.io.fhl())
				{
					return new UnityUITextMeshProGlyphHelper.iq();
				}
				return new UnityUITextMeshProGlyphHelper.iv();
			}

			// Token: 0x06001F0B RID: 7947 RVA: 0x0008AC3C File Offset: 0x00088E3C
			public static UnityUITextMeshProGlyphHelper.im irf()
			{
				if (!UnityUITextMeshProGlyphHelper.io.fhl())
				{
					return new UnityUITextMeshProGlyphHelper.iq();
				}
				return new UnityUITextMeshProGlyphHelper.iv();
			}

			// Token: 0x06001F0C RID: 7948 RVA: 0x0008AC60 File Offset: 0x00088E60
			public static UnityUITextMeshProGlyphHelper.im fhm()
			{
				if (!UnityUITextMeshProGlyphHelper.io.fhl())
				{
					return new UnityUITextMeshProGlyphHelper.iq();
				}
				return new UnityUITextMeshProGlyphHelper.iv();
			}

			// Token: 0x04000FB2 RID: 4018
			private static bool jws;
		}

		// Token: 0x020001E8 RID: 488
		private class iq : UnityUITextMeshProGlyphHelper.im
		{
			// Token: 0x06001F0D RID: 7949 RVA: 0x0008AC83 File Offset: 0x00088E83
			public iq()
			{
				this.jwv = new TMP_Sprite();
			}

			// Token: 0x1700046A RID: 1130
			// (get) Token: 0x06001F0E RID: 7950 RVA: 0x0008AC96 File Offset: 0x00088E96
			// (set) Token: 0x06001F0F RID: 7951 RVA: 0x0008ACA3 File Offset: 0x00088EA3
			public uint lud
			{
				get
				{
					return (uint)this.jwv.id;
				}
				set
				{
					this.jwv.id = (int)value;
				}
			}

			// Token: 0x1700046B RID: 1131
			// (get) Token: 0x06001F10 RID: 7952 RVA: 0x0008ACB1 File Offset: 0x00088EB1
			// (set) Token: 0x06001F11 RID: 7953 RVA: 0x0008ACBE File Offset: 0x00088EBE
			public float lue
			{
				get
				{
					return this.jwv.width;
				}
				set
				{
					this.jwv.width = value;
				}
			}

			// Token: 0x1700046C RID: 1132
			// (get) Token: 0x06001F12 RID: 7954 RVA: 0x0008ACCC File Offset: 0x00088ECC
			// (set) Token: 0x06001F13 RID: 7955 RVA: 0x0008ACD9 File Offset: 0x00088ED9
			public float luf
			{
				get
				{
					return this.jwv.height;
				}
				set
				{
					this.jwv.height = value;
				}
			}

			// Token: 0x1700046D RID: 1133
			// (get) Token: 0x06001F14 RID: 7956 RVA: 0x0008ACE7 File Offset: 0x00088EE7
			// (set) Token: 0x06001F15 RID: 7957 RVA: 0x0008ACF4 File Offset: 0x00088EF4
			public float lug
			{
				get
				{
					return this.jwv.xOffset;
				}
				set
				{
					this.jwv.xOffset = value;
				}
			}

			// Token: 0x1700046E RID: 1134
			// (get) Token: 0x06001F16 RID: 7958 RVA: 0x0008AD02 File Offset: 0x00088F02
			// (set) Token: 0x06001F17 RID: 7959 RVA: 0x0008AD0F File Offset: 0x00088F0F
			public float luh
			{
				get
				{
					return this.jwv.yOffset;
				}
				set
				{
					this.jwv.yOffset = value;
				}
			}

			// Token: 0x1700046F RID: 1135
			// (get) Token: 0x06001F18 RID: 7960 RVA: 0x0008AD1D File Offset: 0x00088F1D
			// (set) Token: 0x06001F19 RID: 7961 RVA: 0x0008AD2A File Offset: 0x00088F2A
			public float lui
			{
				get
				{
					return this.jwv.xAdvance;
				}
				set
				{
					this.jwv.xAdvance = value;
				}
			}

			// Token: 0x17000470 RID: 1136
			// (get) Token: 0x06001F1A RID: 7962 RVA: 0x0008AD38 File Offset: 0x00088F38
			// (set) Token: 0x06001F1B RID: 7963 RVA: 0x0008AD55 File Offset: 0x00088F55
			public Vector2 luj
			{
				get
				{
					return new Vector2(this.jwv.x, this.jwv.y);
				}
				set
				{
					this.jwv.x = value.x;
					this.jwv.y = value.y;
				}
			}

			// Token: 0x17000471 RID: 1137
			// (get) Token: 0x06001F1C RID: 7964 RVA: 0x0008AD79 File Offset: 0x00088F79
			// (set) Token: 0x06001F1D RID: 7965 RVA: 0x0008AD86 File Offset: 0x00088F86
			public Vector2 luk
			{
				get
				{
					return this.jwv.pivot;
				}
				set
				{
					this.jwv.pivot = value;
				}
			}

			// Token: 0x17000472 RID: 1138
			// (get) Token: 0x06001F1E RID: 7966 RVA: 0x0008AD94 File Offset: 0x00088F94
			// (set) Token: 0x06001F1F RID: 7967 RVA: 0x0008ADA1 File Offset: 0x00088FA1
			public float lul
			{
				get
				{
					return this.jwv.scale;
				}
				set
				{
					this.jwv.scale = value;
				}
			}

			// Token: 0x17000473 RID: 1139
			// (get) Token: 0x06001F20 RID: 7968 RVA: 0x0008ADAF File Offset: 0x00088FAF
			// (set) Token: 0x06001F21 RID: 7969 RVA: 0x0008ADBC File Offset: 0x00088FBC
			public string lum
			{
				get
				{
					return this.jwv.name;
				}
				set
				{
					this.jwv.name = value;
				}
			}

			// Token: 0x17000474 RID: 1140
			// (get) Token: 0x06001F22 RID: 7970 RVA: 0x0008ADCA File Offset: 0x00088FCA
			// (set) Token: 0x06001F23 RID: 7971 RVA: 0x0008ADD7 File Offset: 0x00088FD7
			public uint lun
			{
				get
				{
					return (uint)this.jwv.unicode;
				}
				set
				{
					this.jwv.unicode = (int)value;
				}
			}

			// Token: 0x17000475 RID: 1141
			// (get) Token: 0x06001F24 RID: 7972 RVA: 0x0008ADE5 File Offset: 0x00088FE5
			// (set) Token: 0x06001F25 RID: 7973 RVA: 0x0008ADF2 File Offset: 0x00088FF2
			public int luo
			{
				get
				{
					return this.jwv.hashCode;
				}
				set
				{
					this.jwv.hashCode = value;
				}
			}

			// Token: 0x17000476 RID: 1142
			// (get) Token: 0x06001F26 RID: 7974 RVA: 0x0008AE00 File Offset: 0x00089000
			// (set) Token: 0x06001F27 RID: 7975 RVA: 0x0008AE0D File Offset: 0x0008900D
			public Sprite lup
			{
				get
				{
					return this.jwv.sprite;
				}
				set
				{
					this.jwv.sprite = value;
				}
			}

			// Token: 0x04000FB3 RID: 4019
			public TMP_Sprite jwv;

			// Token: 0x020001E9 RID: 489
			public class ip : UnityUITextMeshProGlyphHelper.@in
			{
				// Token: 0x17000477 RID: 1143
				// (get) Token: 0x06001F28 RID: 7976 RVA: 0x0008AE1B File Offset: 0x0008901B
				public int luq
				{
					get
					{
						return this.jwu.Count;
					}
				}

				// Token: 0x17000478 RID: 1144
				// (get) Token: 0x06001F29 RID: 7977 RVA: 0x0008AE28 File Offset: 0x00089028
				// (set) Token: 0x06001F2A RID: 7978 RVA: 0x0008AE35 File Offset: 0x00089035
				public Texture lur
				{
					get
					{
						return this.jwt.spriteSheet;
					}
					set
					{
						this.jwt.spriteSheet = value;
					}
				}

				// Token: 0x06001F2B RID: 7979 RVA: 0x0008AE44 File Offset: 0x00089044
				public ip()
				{
					this.jwt = ScriptableObject.CreateInstance<TMP_SpriteAsset>();
					this.jwt.hideFlags = HideFlags.DontSave;
					if (this.jwt.spriteInfoList == null)
					{
						this.jwt.spriteInfoList = new List<TMP_Sprite>();
					}
					this.jwu = new List<UnityUITextMeshProGlyphHelper.iq>();
				}

				// Token: 0x06001F2C RID: 7980 RVA: 0x0008AE97 File Offset: 0x00089097
				public TMP_SpriteAsset fhe()
				{
					return this.jwt;
				}

				// Token: 0x06001F2D RID: 7981 RVA: 0x0008AE9F File Offset: 0x0008909F
				public UnityUITextMeshProGlyphHelper.im fhf(int a)
				{
					if (a >= this.jwu.Count)
					{
						return null;
					}
					return this.jwu[a];
				}

				// Token: 0x06001F2E RID: 7982 RVA: 0x0008AEC0 File Offset: 0x000890C0
				public void fhg(UnityUITextMeshProGlyphHelper.im a)
				{
					UnityUITextMeshProGlyphHelper.iq iq = a as UnityUITextMeshProGlyphHelper.iq;
					if (a == null)
					{
						throw new ArgumentException();
					}
					iq.jwv.id = this.jwt.spriteInfoList.Count;
					this.jwt.spriteInfoList.Add(iq.jwv);
					this.jwu.Add(iq);
				}

				// Token: 0x06001F2F RID: 7983 RVA: 0x0008AF1A File Offset: 0x0008911A
				public void fhi()
				{
					this.jwt.spriteInfoList.Clear();
					this.jwu.Clear();
				}

				// Token: 0x06001F30 RID: 7984 RVA: 0x0008AF38 File Offset: 0x00089138
				public bool fhh(string a)
				{
					int count = this.jwu.Count;
					for (int i = 0; i < count; i++)
					{
						if (string.Equals(this.jwu[i].lum, a, StringComparison.Ordinal))
						{
							return true;
						}
					}
					return false;
				}

				// Token: 0x06001F31 RID: 7985 RVA: 0x0008AF7A File Offset: 0x0008917A
				public void fhj()
				{
					this.jwt.UpdateLookupTables();
				}

				// Token: 0x06001F32 RID: 7986 RVA: 0x0008AF87 File Offset: 0x00089187
				public void fhk()
				{
					if (this.jwt == null)
					{
						return;
					}
					global::UnityEngine.Object.Destroy(this.jwt);
					this.jwt = null;
				}

				// Token: 0x04000FB4 RID: 4020
				private TMP_SpriteAsset jwt;

				// Token: 0x04000FB5 RID: 4021
				private readonly List<UnityUITextMeshProGlyphHelper.iq> jwu;
			}
		}

		// Token: 0x020001EA RID: 490
		private class iv : UnityUITextMeshProGlyphHelper.im
		{
			// Token: 0x06001F33 RID: 7987 RVA: 0x0008AFAA File Offset: 0x000891AA
			public iv()
			{
				this.jxe = new UnityUITextMeshProGlyphHelper.iv.@is();
				this.jxf = new UnityUITextMeshProGlyphHelper.iv.ir();
				this.jxf.lut = this.jxe.luy;
			}

			// Token: 0x17000479 RID: 1145
			// (get) Token: 0x06001F34 RID: 7988 RVA: 0x0008AFDE File Offset: 0x000891DE
			public UnityUITextMeshProGlyphHelper.iv.@is lva
			{
				get
				{
					return this.jxe;
				}
			}

			// Token: 0x06001F35 RID: 7989 RVA: 0x0008AFE8 File Offset: 0x000891E8
			public static bool ecs()
			{
				if (UnityUITextMeshProGlyphHelper.iv.jxg != null)
				{
					return UnityUITextMeshProGlyphHelper.iv.jxg.Value;
				}
				try
				{
					new UnityUITextMeshProGlyphHelper.iv.iu();
					UnityUITextMeshProGlyphHelper.iv.jxg = new bool?(true);
				}
				catch
				{
					UnityUITextMeshProGlyphHelper.iv.jxg = new bool?(false);
				}
				return UnityUITextMeshProGlyphHelper.iv.jxg.Value;
			}

			// Token: 0x06001F36 RID: 7990 RVA: 0x0008B048 File Offset: 0x00089248
			public static bool fjb()
			{
				if (UnityUITextMeshProGlyphHelper.iv.jxg != null)
				{
					return UnityUITextMeshProGlyphHelper.iv.jxg.Value;
				}
				try
				{
					new UnityUITextMeshProGlyphHelper.iv.iu();
					UnityUITextMeshProGlyphHelper.iv.jxg = new bool?(true);
				}
				catch
				{
					UnityUITextMeshProGlyphHelper.iv.jxg = new bool?(false);
				}
				return UnityUITextMeshProGlyphHelper.iv.jxg.Value;
			}

			// Token: 0x1700047E RID: 1150
			// (get) Token: 0x06001F3B RID: 7995 RVA: 0x0008B150 File Offset: 0x00089350
			// (set) Token: 0x06001F37 RID: 7991 RVA: 0x0008B0A8 File Offset: 0x000892A8
			public float lug
			{
				get
				{
					return this.jxe.luy.metrics.horizontalBearingX;
				}
				set
				{
					GlyphMetrics metrics = this.jxe.luy.metrics;
					metrics.horizontalBearingX = value;
					this.jxe.luy.metrics = metrics;
				}
			}

			// Token: 0x17000483 RID: 1155
			// (get) Token: 0x06001F38 RID: 7992 RVA: 0x0008B0DF File Offset: 0x000892DF
			// (set) Token: 0x06001F53 RID: 8019 RVA: 0x0008B52B File Offset: 0x0008972B
			public float lul
			{
				get
				{
					return this.jxf.luw;
				}
				set
				{
					this.jxf.luw = value;
				}
			}

			// Token: 0x1700047C RID: 1148
			// (get) Token: 0x06001F42 RID: 8002 RVA: 0x0008B2C8 File Offset: 0x000894C8
			// (set) Token: 0x06001F39 RID: 7993 RVA: 0x0008B0EC File Offset: 0x000892EC
			public float lue
			{
				get
				{
					return this.jxe.luy.metrics.width;
				}
				set
				{
					GlyphMetrics metrics = this.jxe.luy.metrics;
					metrics.width = value;
					this.jxe.luy.metrics = metrics;
					GlyphRect glyphRect = this.jxe.luy.glyphRect;
					glyphRect.width = (int)value;
					this.jxe.luy.glyphRect = glyphRect;
				}
			}

			// Token: 0x17000486 RID: 1158
			// (get) Token: 0x06001F3A RID: 7994 RVA: 0x0000FC31 File Offset: 0x0000DE31
			// (set) Token: 0x06001F4E RID: 8014 RVA: 0x00005090 File Offset: 0x00003290
			public int luo
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			// Token: 0x1700047D RID: 1149
			// (get) Token: 0x06001F45 RID: 8005 RVA: 0x0008B39C File Offset: 0x0008959C
			// (set) Token: 0x06001F3C RID: 7996 RVA: 0x0008B178 File Offset: 0x00089378
			public float luf
			{
				get
				{
					return this.jxe.luy.metrics.height;
				}
				set
				{
					GlyphMetrics metrics = this.jxe.luy.metrics;
					metrics.height = value;
					this.jxe.luy.metrics = metrics;
					GlyphRect glyphRect = this.jxe.luy.glyphRect;
					glyphRect.height = (int)value;
					this.jxe.luy.glyphRect = glyphRect;
				}
			}

			// Token: 0x1700047F RID: 1151
			// (get) Token: 0x06001F4D RID: 8013 RVA: 0x0008B4A0 File Offset: 0x000896A0
			// (set) Token: 0x06001F3D RID: 7997 RVA: 0x0008B1DC File Offset: 0x000893DC
			public float luh
			{
				get
				{
					return this.jxe.luy.metrics.horizontalBearingY;
				}
				set
				{
					GlyphMetrics metrics = this.jxe.luy.metrics;
					metrics.horizontalBearingY = value;
					this.jxe.luy.metrics = metrics;
				}
			}

			// Token: 0x06001F3E RID: 7998 RVA: 0x0008B214 File Offset: 0x00089414
			public static bool fif()
			{
				if (UnityUITextMeshProGlyphHelper.iv.jxg != null)
				{
					return UnityUITextMeshProGlyphHelper.iv.jxg.Value;
				}
				try
				{
					new UnityUITextMeshProGlyphHelper.iv.iu();
					UnityUITextMeshProGlyphHelper.iv.jxg = new bool?(true);
				}
				catch
				{
					UnityUITextMeshProGlyphHelper.iv.jxg = new bool?(false);
				}
				return UnityUITextMeshProGlyphHelper.iv.jxg.Value;
			}

			// Token: 0x17000481 RID: 1153
			// (get) Token: 0x06001F3F RID: 7999 RVA: 0x0008B274 File Offset: 0x00089474
			// (set) Token: 0x06001F43 RID: 8003 RVA: 0x0008B2F0 File Offset: 0x000894F0
			public Vector2 luj
			{
				get
				{
					GlyphRect glyphRect = this.jxe.luy.glyphRect;
					return new Vector2((float)glyphRect.x, (float)glyphRect.y);
				}
				set
				{
					GlyphRect glyphRect = this.jxe.luy.glyphRect;
					glyphRect.x = (int)value.x;
					glyphRect.y = (int)value.y;
					this.jxe.luy.glyphRect = glyphRect;
				}
			}

			// Token: 0x1700047B RID: 1147
			// (get) Token: 0x06001F40 RID: 8000 RVA: 0x0008B2A7 File Offset: 0x000894A7
			// (set) Token: 0x06001F4A RID: 8010 RVA: 0x0008B44D File Offset: 0x0008964D
			public uint lud
			{
				get
				{
					return this.jxe.luy.index;
				}
				set
				{
					this.jxe.luy.index = value;
					this.jxf.lux = value;
				}
			}

			// Token: 0x17000485 RID: 1157
			// (get) Token: 0x06001F41 RID: 8001 RVA: 0x0008B2B9 File Offset: 0x000894B9
			// (set) Token: 0x06001F4C RID: 8012 RVA: 0x0008B491 File Offset: 0x00089691
			public uint lun
			{
				get
				{
					return this.jxf.luu;
				}
				set
				{
					this.jxf.luu = value;
				}
			}

			// Token: 0x06001F44 RID: 8004 RVA: 0x0008B33C File Offset: 0x0008953C
			public static bool hpw()
			{
				if (UnityUITextMeshProGlyphHelper.iv.jxg != null)
				{
					return UnityUITextMeshProGlyphHelper.iv.jxg.Value;
				}
				try
				{
					new UnityUITextMeshProGlyphHelper.iv.iu();
					UnityUITextMeshProGlyphHelper.iv.jxg = new bool?(true);
				}
				catch
				{
					UnityUITextMeshProGlyphHelper.iv.jxg = new bool?(false);
				}
				return UnityUITextMeshProGlyphHelper.iv.jxg.Value;
			}

			// Token: 0x06001F46 RID: 8006 RVA: 0x0008B3C4 File Offset: 0x000895C4
			public static bool en()
			{
				if (UnityUITextMeshProGlyphHelper.iv.jxg != null)
				{
					return UnityUITextMeshProGlyphHelper.iv.jxg.Value;
				}
				try
				{
					new UnityUITextMeshProGlyphHelper.iv.iu();
					UnityUITextMeshProGlyphHelper.iv.jxg = new bool?(true);
				}
				catch
				{
					UnityUITextMeshProGlyphHelper.iv.jxg = new bool?(false);
				}
				return UnityUITextMeshProGlyphHelper.iv.jxg.Value;
			}

			// Token: 0x17000484 RID: 1156
			// (get) Token: 0x06001F49 RID: 8009 RVA: 0x0008B440 File Offset: 0x00089640
			// (set) Token: 0x06001F47 RID: 8007 RVA: 0x0008B424 File Offset: 0x00089624
			public string lum
			{
				get
				{
					return this.jxf.luv;
				}
				set
				{
					this.jxf.luv = value;
				}
			}

			// Token: 0x17000487 RID: 1159
			// (get) Token: 0x06001F50 RID: 8016 RVA: 0x0008B4DE File Offset: 0x000896DE
			// (set) Token: 0x06001F48 RID: 8008 RVA: 0x0008B432 File Offset: 0x00089632
			public Sprite lup
			{
				get
				{
					return this.jxe.luz;
				}
				set
				{
					this.jxe.luz = value;
				}
			}

			// Token: 0x17000480 RID: 1152
			// (get) Token: 0x06001F4B RID: 8011 RVA: 0x0008B46C File Offset: 0x0008966C
			// (set) Token: 0x06001F51 RID: 8017 RVA: 0x0008B4EC File Offset: 0x000896EC
			public float lui
			{
				get
				{
					return this.jxe.luy.metrics.horizontalAdvance;
				}
				set
				{
					GlyphMetrics metrics = this.jxe.luy.metrics;
					metrics.horizontalAdvance = value;
					this.jxe.luy.metrics = metrics;
				}
			}

			// Token: 0x17000482 RID: 1154
			// (get) Token: 0x06001F4F RID: 8015 RVA: 0x0008B4C8 File Offset: 0x000896C8
			// (set) Token: 0x06001F54 RID: 8020 RVA: 0x00005090 File Offset: 0x00003290
			public Vector2 luk
			{
				get
				{
					return default(Vector2);
				}
				set
				{
				}
			}

			// Token: 0x1700047A RID: 1146
			// (get) Token: 0x06001F52 RID: 8018 RVA: 0x0008B523 File Offset: 0x00089723
			public UnityUITextMeshProGlyphHelper.iv.ir lvb
			{
				get
				{
					return this.jxf;
				}
			}

			// Token: 0x04000FB6 RID: 4022
			private readonly UnityUITextMeshProGlyphHelper.iv.@is jxe;

			// Token: 0x04000FB7 RID: 4023
			private readonly UnityUITextMeshProGlyphHelper.iv.ir jxf;

			// Token: 0x04000FB8 RID: 4024
			private static bool? jxg;

			// Token: 0x020001EB RID: 491
			public class ir
			{
				// Token: 0x17000488 RID: 1160
				// (get) Token: 0x06001F55 RID: 8021 RVA: 0x0008B539 File Offset: 0x00089739
				public TMP_SpriteCharacter lus
				{
					get
					{
						return this.jww;
					}
				}

				// Token: 0x17000489 RID: 1161
				// (get) Token: 0x06001F56 RID: 8022 RVA: 0x0008B541 File Offset: 0x00089741
				// (set) Token: 0x06001F57 RID: 8023 RVA: 0x0008B54E File Offset: 0x0008974E
				public Glyph lut
				{
					get
					{
						return this.jww.glyph;
					}
					set
					{
						this.jww.glyph = value;
					}
				}

				// Token: 0x1700048A RID: 1162
				// (get) Token: 0x06001F58 RID: 8024 RVA: 0x0008B55C File Offset: 0x0008975C
				// (set) Token: 0x06001F59 RID: 8025 RVA: 0x0008B569 File Offset: 0x00089769
				public uint luu
				{
					get
					{
						return this.jww.unicode;
					}
					set
					{
						if (value == 0U)
						{
							value = 65534U;
						}
						this.jww.unicode = value;
					}
				}

				// Token: 0x1700048B RID: 1163
				// (get) Token: 0x06001F5A RID: 8026 RVA: 0x0008B583 File Offset: 0x00089783
				// (set) Token: 0x06001F5B RID: 8027 RVA: 0x0008B590 File Offset: 0x00089790
				public string luv
				{
					get
					{
						return this.jww.name;
					}
					set
					{
						this.jww.name = value;
					}
				}

				// Token: 0x1700048C RID: 1164
				// (get) Token: 0x06001F5C RID: 8028 RVA: 0x0008B59E File Offset: 0x0008979E
				// (set) Token: 0x06001F5D RID: 8029 RVA: 0x0008B5AB File Offset: 0x000897AB
				public float luw
				{
					get
					{
						return this.jww.scale;
					}
					set
					{
						this.jww.scale = value;
					}
				}

				// Token: 0x1700048D RID: 1165
				// (get) Token: 0x06001F5E RID: 8030 RVA: 0x0008B5B9 File Offset: 0x000897B9
				// (set) Token: 0x06001F5F RID: 8031 RVA: 0x0008B5C6 File Offset: 0x000897C6
				public uint lux
				{
					get
					{
						return this.jww.glyphIndex;
					}
					set
					{
						this.jww.glyphIndex = value;
					}
				}

				// Token: 0x06001F60 RID: 8032 RVA: 0x0008B5D4 File Offset: 0x000897D4
				public ir()
				{
					this.jww = new TMP_SpriteCharacter();
				}

				// Token: 0x04000FB9 RID: 4025
				private readonly TMP_SpriteCharacter jww;
			}

			// Token: 0x020001EC RID: 492
			public class @is
			{
				// Token: 0x1700048E RID: 1166
				// (get) Token: 0x06001F61 RID: 8033 RVA: 0x0008B5E7 File Offset: 0x000897E7
				public TMP_SpriteGlyph luy
				{
					get
					{
						return this.jwx;
					}
				}

				// Token: 0x06001F62 RID: 8034 RVA: 0x0008B5EF File Offset: 0x000897EF
				private static void nel(Glyph a)
				{
					a.scale = -4733f;
					a.atlasIndex = 0;
				}

				// Token: 0x1700048F RID: 1167
				// (get) Token: 0x06001F63 RID: 8035 RVA: 0x0008B603 File Offset: 0x00089803
				// (set) Token: 0x06001F68 RID: 8040 RVA: 0x0008B66A File Offset: 0x0008986A
				public Sprite luz
				{
					get
					{
						return this.jwx.sprite;
					}
					set
					{
						this.jwx.sprite = value;
					}
				}

				// Token: 0x06001F64 RID: 8036 RVA: 0x0008B610 File Offset: 0x00089810
				private static void fic(Glyph a)
				{
					a.scale = 1f;
					a.atlasIndex = 0;
				}

				// Token: 0x06001F65 RID: 8037 RVA: 0x0008B624 File Offset: 0x00089824
				private static void kxm(Glyph a)
				{
					a.scale = 7329f;
					a.atlasIndex = 0;
				}

				// Token: 0x06001F66 RID: 8038 RVA: 0x0008B638 File Offset: 0x00089838
				public @is()
				{
					this.jwx = new TMP_SpriteGlyph();
					UnityUITextMeshProGlyphHelper.iv.@is.fic(this.jwx);
				}

				// Token: 0x06001F67 RID: 8039 RVA: 0x0008B656 File Offset: 0x00089856
				private static void hth(Glyph a)
				{
					a.scale = 8096f;
					a.atlasIndex = 0;
				}

				// Token: 0x04000FBA RID: 4026
				private readonly TMP_SpriteGlyph jwx;
			}

			// Token: 0x020001ED RID: 493
			public class iu : UnityUITextMeshProGlyphHelper.@in
			{
				// Token: 0x17000490 RID: 1168
				// (get) Token: 0x06001F69 RID: 8041 RVA: 0x0008B678 File Offset: 0x00089878
				public int luq
				{
					get
					{
						return this.jxc.Count;
					}
				}

				// Token: 0x17000491 RID: 1169
				// (get) Token: 0x06001F6A RID: 8042 RVA: 0x0008B685 File Offset: 0x00089885
				// (set) Token: 0x06001F6B RID: 8043 RVA: 0x0008B692 File Offset: 0x00089892
				public Texture lur
				{
					get
					{
						return this.jxd.spriteSheet;
					}
					set
					{
						this.jxd.spriteSheet = value;
					}
				}

				// Token: 0x06001F6C RID: 8044 RVA: 0x0008B6A0 File Offset: 0x000898A0
				public iu()
				{
					this.jxd = ScriptableObject.CreateInstance<TMP_SpriteAsset>();
					this.jxd.hideFlags = HideFlags.DontSave;
					Type typeFromHandle = typeof(TMP_SpriteAsset);
					if (typeFromHandle == null)
					{
						throw new ArgumentNullException(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.eps());
					}
					PropertyInfo property = typeFromHandle.GetProperty(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.erz(), BindingFlags.Instance | BindingFlags.Public);
					if (property == null)
					{
						throw new ArgumentNullException(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.erz());
					}
					property.SetValue(this.jxd, global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.esa());
					this.jwy = typeFromHandle.GetProperty(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.esb(), BindingFlags.Instance | BindingFlags.Public);
					if (this.jwy == null)
					{
						throw new ArgumentNullException(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.esb());
					}
					this.jxa = (IList)this.jwy.GetValue(this.jxd);
					if (this.jxa == null)
					{
						throw new ArgumentNullException(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.esc());
					}
					this.jwz = typeFromHandle.GetProperty(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.esd(), BindingFlags.Instance | BindingFlags.Public);
					if (this.jwz == null)
					{
						throw new ArgumentNullException(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.esd());
					}
					this.jxb = (IList)this.jwz.GetValue(this.jxd);
					if (this.jxb == null)
					{
						throw new ArgumentNullException(global::<PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254}.a.ese());
					}
					this.jxc = new List<UnityUITextMeshProGlyphHelper.iv>();
				}

				// Token: 0x06001F6D RID: 8045 RVA: 0x0008B7DC File Offset: 0x000899DC
				public TMP_SpriteAsset fhe()
				{
					return this.jxd;
				}

				// Token: 0x06001F6E RID: 8046 RVA: 0x0008B7E4 File Offset: 0x000899E4
				public UnityUITextMeshProGlyphHelper.im fhf(int a)
				{
					if (a >= this.jxc.Count)
					{
						return null;
					}
					return this.jxc[a];
				}

				// Token: 0x06001F6F RID: 8047 RVA: 0x0008B804 File Offset: 0x00089A04
				public void fhg(UnityUITextMeshProGlyphHelper.im a)
				{
					UnityUITextMeshProGlyphHelper.iv iv = a as UnityUITextMeshProGlyphHelper.iv;
					if (iv == null)
					{
						throw new ArgumentException();
					}
					iv.lud = (uint)this.jxa.Count;
					this.jxa.Add(iv.lvb.lus);
					this.jxb.Add(iv.lva.luy);
					this.jxc.Add(iv);
				}

				// Token: 0x06001F70 RID: 8048 RVA: 0x0008B86C File Offset: 0x00089A6C
				public void fhi()
				{
					this.jxa.Clear();
					this.jxb.Clear();
					this.jxc.Clear();
				}

				// Token: 0x06001F71 RID: 8049 RVA: 0x0008B890 File Offset: 0x00089A90
				public bool fhh(string a)
				{
					int count = this.jxc.Count;
					for (int i = 0; i < count; i++)
					{
						if (string.Equals(this.jxc[i].lum, a, StringComparison.Ordinal))
						{
							return true;
						}
					}
					return false;
				}

				// Token: 0x06001F72 RID: 8050 RVA: 0x0008B8D2 File Offset: 0x00089AD2
				public void fhj()
				{
					this.jxd.UpdateLookupTables();
				}

				// Token: 0x06001F73 RID: 8051 RVA: 0x0008B8DF File Offset: 0x00089ADF
				public void fhk()
				{
					if (this.jxd == null)
					{
						return;
					}
					global::UnityEngine.Object.Destroy(this.jxd);
					this.jxd = null;
				}

				// Token: 0x04000FBB RID: 4027
				private readonly PropertyInfo jwy;

				// Token: 0x04000FBC RID: 4028
				private readonly PropertyInfo jwz;

				// Token: 0x04000FBD RID: 4029
				private readonly IList jxa;

				// Token: 0x04000FBE RID: 4030
				private readonly IList jxb;

				// Token: 0x04000FBF RID: 4031
				private readonly List<UnityUITextMeshProGlyphHelper.iv> jxc;

				// Token: 0x04000FC0 RID: 4032
				private TMP_SpriteAsset jxd;
			}
		}

		// Token: 0x020001EE RID: 494
		private enum DisplayType
		{
			// Token: 0x04000FC2 RID: 4034
			Glyph,
			// Token: 0x04000FC3 RID: 4035
			Text,
			// Token: 0x04000FC4 RID: 4036
			GlyphOrText
		}

		// Token: 0x020001EF RID: 495
		[CompilerGenerated]
		private sealed class iw
		{
			// Token: 0x06001F74 RID: 8052 RVA: 0x0008B904 File Offset: 0x00089B04
			internal void fig(UnityUITextMeshProGlyphHelper.il a)
			{
				UnityUITextMeshProGlyphHelper.fkg(this.jxh, a.ltt);
				if (this.jxi._overrideSpriteMaterialProperties)
				{
					UnityUITextMeshProGlyphHelper.fkh(this.jxi._spriteMaterialProperties, a.ltt);
				}
				TMPro_EventManager.ON_MATERIAL_PROPERTY_CHANGED(true, a.ltt);
			}

			// Token: 0x06001F75 RID: 8053 RVA: 0x0008B954 File Offset: 0x00089B54
			internal void jqv(UnityUITextMeshProGlyphHelper.il a)
			{
				UnityUITextMeshProGlyphHelper.fkg(this.jxh, a.ltt);
				if (this.jxi._overrideSpriteMaterialProperties)
				{
					UnityUITextMeshProGlyphHelper.fkh(this.jxi._spriteMaterialProperties, a.ltt);
				}
				TMPro_EventManager.ON_MATERIAL_PROPERTY_CHANGED(true, a.ltt);
			}

			// Token: 0x06001F76 RID: 8054 RVA: 0x0008B9A4 File Offset: 0x00089BA4
			internal void dfv(UnityUITextMeshProGlyphHelper.il a)
			{
				UnityUITextMeshProGlyphHelper.fkg(this.jxh, a.ltt);
				if (this.jxi._overrideSpriteMaterialProperties)
				{
					UnityUITextMeshProGlyphHelper.fkh(this.jxi._spriteMaterialProperties, a.ltt);
				}
				TMPro_EventManager.ON_MATERIAL_PROPERTY_CHANGED(true, a.ltt);
			}

			// Token: 0x06001F77 RID: 8055 RVA: 0x0008B9F4 File Offset: 0x00089BF4
			internal void gbm(UnityUITextMeshProGlyphHelper.il a)
			{
				UnityUITextMeshProGlyphHelper.fkg(this.jxh, a.ltt);
				if (this.jxi._overrideSpriteMaterialProperties)
				{
					UnityUITextMeshProGlyphHelper.fkh(this.jxi._spriteMaterialProperties, a.ltt);
				}
				TMPro_EventManager.ON_MATERIAL_PROPERTY_CHANGED(true, a.ltt);
			}

			// Token: 0x04000FC5 RID: 4037
			public Material jxh;

			// Token: 0x04000FC6 RID: 4038
			public UnityUITextMeshProGlyphHelper jxi;
		}

		// Token: 0x020001F0 RID: 496
		[CompilerGenerated]
		private sealed class ix
		{
			// Token: 0x06001F7A RID: 8058 RVA: 0x0008BA41 File Offset: 0x00089C41
			internal void fih(UnityUITextMeshProGlyphHelper.il a)
			{
				UnityUITextMeshProGlyphHelper.fkg(this.jxj, a.ltt);
				TMPro_EventManager.ON_MATERIAL_PROPERTY_CHANGED(true, a.ltt);
			}

			// Token: 0x04000FC7 RID: 4039
			public Material jxj;
		}
	}
}
