using System;
using System.Collections;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000247 RID: 583
	[RequireComponent(typeof(CanvasGroup))]
	public class Window : MonoBehaviour
	{
		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x0009BE0E File Offset: 0x0009A00E
		public bool mge
		{
			get
			{
				return this.khe != null && this.khe(this.kgy);
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06002521 RID: 9505 RVA: 0x0009BE2B File Offset: 0x0009A02B
		public int mgf
		{
			get
			{
				return this.kgy;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x0009BE33 File Offset: 0x0009A033
		public RectTransform mgg
		{
			get
			{
				if (this.kgz == null)
				{
					this.kgz = base.gameObject.GetComponent<RectTransform>();
				}
				return this.kgz;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06002523 RID: 9507 RVA: 0x0009BE5A File Offset: 0x0009A05A
		public TMP_Text mgh
		{
			get
			{
				return this.kha;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06002524 RID: 9508 RVA: 0x0009BE62 File Offset: 0x0009A062
		public List<TMP_Text> mgi
		{
			get
			{
				return this.khb;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06002525 RID: 9509 RVA: 0x0009BE6A File Offset: 0x0009A06A
		// (set) Token: 0x06002526 RID: 9510 RVA: 0x0009BE72 File Offset: 0x0009A072
		public GameObject mgj
		{
			get
			{
				return this.khc;
			}
			set
			{
				this.khc = value;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06002527 RID: 9511 RVA: 0x0009BE7B File Offset: 0x0009A07B
		// (set) Token: 0x06002528 RID: 9512 RVA: 0x0009BE83 File Offset: 0x0009A083
		public Action<int> mgk
		{
			get
			{
				return this.khd;
			}
			set
			{
				this.khd = value;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06002529 RID: 9513 RVA: 0x0009BE8C File Offset: 0x0009A08C
		public Window.kr mgl
		{
			get
			{
				return this.khf;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x0009BE94 File Offset: 0x0009A094
		// (set) Token: 0x0600252B RID: 9515 RVA: 0x0009BEA8 File Offset: 0x0009A0A8
		public int mgm
		{
			get
			{
				return (int)this.mgg.sizeDelta.x;
			}
			set
			{
				Vector2 sizeDelta = this.mgg.sizeDelta;
				sizeDelta.x = (float)value;
				this.mgg.sizeDelta = sizeDelta;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x0009BED6 File Offset: 0x0009A0D6
		// (set) Token: 0x0600252D RID: 9517 RVA: 0x0009BEEC File Offset: 0x0009A0EC
		public int mgn
		{
			get
			{
				return (int)this.mgg.sizeDelta.y;
			}
			set
			{
				Vector2 sizeDelta = this.mgg.sizeDelta;
				sizeDelta.y = (float)value;
				this.mgg.sizeDelta = sizeDelta;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x0009BF1A File Offset: 0x0009A11A
		protected bool mgo
		{
			get
			{
				return this.kgx;
			}
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x0009BF22 File Offset: 0x0009A122
		private void OnEnable()
		{
			base.StartCoroutine(a.eyt());
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x0009BF30 File Offset: 0x0009A130
		protected virtual void Update()
		{
			if (!this.kgx)
			{
				return;
			}
			if (!this.mge)
			{
				return;
			}
			this.gti();
			if (this.khd != null)
			{
				this.khd(this.kgy);
			}
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x0009BF64 File Offset: 0x0009A164
		public virtual void fkn(int a, Func<int, bool> b)
		{
			if (this.kgx)
			{
				Debug.LogError(a.eyu());
				return;
			}
			this.kgy = a;
			this.khe = b;
			this.khf = new Window.kr();
			this.khb = new List<TMP_Text>();
			this.khg = base.GetComponent<CanvasGroup>();
			this.kgx = true;
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x0009BFBB File Offset: 0x0009A1BB
		public void gsp(int a, int b)
		{
			this.mgg.sizeDelta = new Vector2((float)a, (float)b);
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x0009BFD1 File Offset: 0x0009A1D1
		public void gsq(GameObject a, Vector2 b)
		{
			this.gtf(a, ref this.kha, a.eyv(), UIPivot.TopCenter, UIAnchor.TopHStretch, b);
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x0009BFF0 File Offset: 0x0009A1F0
		public void gsr(GameObject a, Vector2 b, string c)
		{
			this.gsq(a, b);
			this.gsy(c);
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x0009C004 File Offset: 0x0009A204
		public void gss(GameObject a, UIPivot b, UIAnchor c, Vector2 d)
		{
			TMP_Text tmp_Text = null;
			this.gtf(a, ref tmp_Text, a.eyw(), b, c, d);
			this.khb.Add(tmp_Text);
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x0009C031 File Offset: 0x0009A231
		public void gst(GameObject a, UIPivot b, UIAnchor c, Vector2 d, string e)
		{
			this.gss(a, b, c, d);
			this.gtb(e, this.khb.Count - 1);
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x0009C053 File Offset: 0x0009A253
		public void gsu(GameObject a, UIPivot b, UIAnchor c, Vector2 d)
		{
			this.gtg(a, a.dee(), b, c, d);
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x0009C065 File Offset: 0x0009A265
		public void gsv(GameObject a, UIPivot b, UIAnchor c, Vector2 d, string e)
		{
			this.gsu(a, b, c, d);
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x0009C074 File Offset: 0x0009A274
		public void gsw(GameObject a, UIPivot b, UIAnchor c, Vector2 d, string e, UnityAction f, UnityAction g, bool h)
		{
			if (a == null)
			{
				return;
			}
			ButtonInfo buttonInfo;
			GameObject gameObject = this.gth(a, a.euz(), c, b, d, out buttonInfo);
			if (gameObject == null)
			{
				return;
			}
			Button component = gameObject.GetComponent<Button>();
			if (f != null)
			{
				component.onClick.AddListener(f);
			}
			CustomButton customButton = component as CustomButton;
			if (g != null && customButton != null)
			{
				customButton.mhr += g;
			}
			if (buttonInfo.text != null)
			{
				buttonInfo.text.text = e;
			}
			if (h)
			{
				this.khc = gameObject;
			}
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x0009C102 File Offset: 0x0009A302
		public string gsx(string a)
		{
			if (this.kha == null)
			{
				return string.Empty;
			}
			return this.kha.text;
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x0009C123 File Offset: 0x0009A323
		public void gsy(string a)
		{
			if (this.kha == null)
			{
				return;
			}
			this.kha.text = a;
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x0009C140 File Offset: 0x0009A340
		public string gsz(int a)
		{
			if (this.khb == null || this.khb.Count <= a || this.khb[a] == null)
			{
				return string.Empty;
			}
			return this.khb[a].text;
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x0009C190 File Offset: 0x0009A390
		public float gta(int a)
		{
			if (this.khb == null || this.khb.Count <= a || this.khb[a] == null)
			{
				return 0f;
			}
			return this.khb[a].rectTransform.sizeDelta.y;
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x0009C1E8 File Offset: 0x0009A3E8
		public void gtb(string a, int b)
		{
			if (this.khb == null || this.khb.Count <= b || this.khb[b] == null)
			{
				return;
			}
			this.khb[b].text = a;
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x0009C227 File Offset: 0x0009A427
		public void gtc(Action<int> a)
		{
			this.mgk = a;
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x0009C230 File Offset: 0x0009A430
		public virtual void fky()
		{
			if (EventSystem.current == null)
			{
				return;
			}
			EventSystem.current.SetSelectedGameObject(this.khc);
			this.gtd();
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x0009C256 File Offset: 0x0009A456
		public virtual void gtd()
		{
			this.khg.interactable = true;
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x0009C264 File Offset: 0x0009A464
		public virtual void gte()
		{
			this.khg.interactable = false;
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x0009C272 File Offset: 0x0009A472
		public virtual void Cancel()
		{
			if (!this.mgo)
			{
				return;
			}
			if (this.cancelCallback != null)
			{
				this.cancelCallback();
			}
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x0009C290 File Offset: 0x0009A490
		private void gtf(GameObject a, ref TMP_Text b, string c, UIPivot d, UIAnchor e, Vector2 f)
		{
			if (a == null || this.content == null)
			{
				return;
			}
			if (b != null)
			{
				Debug.LogError(a.eyx() + c + a.eyy());
				return;
			}
			GameObject gameObject = kq.grk<TMP_Text>(a, this.content.transform, c, d, e.min, e.max, f);
			if (gameObject == null)
			{
				return;
			}
			b = gameObject.GetComponent<TMP_Text>();
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x0009C314 File Offset: 0x0009A514
		private void gtg(GameObject a, string b, UIPivot c, UIAnchor d, Vector2 e)
		{
			if (a == null || this.content == null)
			{
				return;
			}
			kq.grk<Image>(a, this.content.transform, b, c, d.min, d.max, e);
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x0009C364 File Offset: 0x0009A564
		private GameObject gth(GameObject a, string b, UIAnchor c, UIPivot d, Vector2 e, out ButtonInfo f)
		{
			f = null;
			if (a == null)
			{
				return null;
			}
			GameObject gameObject = kq.grk<ButtonInfo>(a, this.content.transform, b, d, c.min, c.max, e);
			if (gameObject == null)
			{
				return null;
			}
			f = gameObject.GetComponent<ButtonInfo>();
			if (gameObject.GetComponent<Button>() == null)
			{
				Debug.Log(a.eyz());
				return null;
			}
			if (f == null)
			{
				Debug.Log(a.eza());
				return null;
			}
			return gameObject;
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x0009C3EE File Offset: 0x0009A5EE
		private IEnumerator OnEnableAsync()
		{
			yield return 1;
			if (EventSystem.current == null)
			{
				yield break;
			}
			if (this.mgj != null)
			{
				EventSystem.current.SetSelectedGameObject(this.mgj);
			}
			else
			{
				EventSystem.current.SetSelectedGameObject(null);
			}
			yield break;
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x0009C400 File Offset: 0x0009A600
		private void gti()
		{
			if (!this.mge)
			{
				return;
			}
			if (EventSystem.current == null)
			{
				return;
			}
			if (EventSystem.current.currentSelectedGameObject == null)
			{
				this.gtj();
			}
			this.khh = EventSystem.current.currentSelectedGameObject;
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x0009C44C File Offset: 0x0009A64C
		private void gtj()
		{
			if (!this.mge)
			{
				return;
			}
			if (this.khh == null || !this.khh.activeInHierarchy)
			{
				this.gtk(this.khc);
				return;
			}
			this.gtk(this.khh);
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x0009204A File Offset: 0x0009024A
		private void gtk(GameObject a)
		{
			if (EventSystem.current == null)
			{
				return;
			}
			EventSystem.current.SetSelectedGameObject(a);
		}

		// Token: 0x0400120D RID: 4621
		public Image backgroundImage;

		// Token: 0x0400120E RID: 4622
		public GameObject content;

		// Token: 0x0400120F RID: 4623
		private bool kgx;

		// Token: 0x04001210 RID: 4624
		private int kgy = -1;

		// Token: 0x04001211 RID: 4625
		private RectTransform kgz;

		// Token: 0x04001212 RID: 4626
		private TMP_Text kha;

		// Token: 0x04001213 RID: 4627
		private List<TMP_Text> khb;

		// Token: 0x04001214 RID: 4628
		private GameObject khc;

		// Token: 0x04001215 RID: 4629
		private Action<int> khd;

		// Token: 0x04001216 RID: 4630
		private Func<int, bool> khe;

		// Token: 0x04001217 RID: 4631
		private Window.kr khf;

		// Token: 0x04001218 RID: 4632
		private CanvasGroup khg;

		// Token: 0x04001219 RID: 4633
		public UnityAction cancelCallback;

		// Token: 0x0400121A RID: 4634
		private GameObject khh;

		// Token: 0x02000248 RID: 584
		public class kr
		{
			// Token: 0x17000604 RID: 1540
			// (get) Token: 0x0600254C RID: 9548 RVA: 0x0009C49A File Offset: 0x0009A69A
			public bool mfz
			{
				get
				{
					return this.kgs;
				}
			}

			// Token: 0x17000605 RID: 1541
			// (get) Token: 0x0600254D RID: 9549 RVA: 0x0009C4A2 File Offset: 0x0009A6A2
			public bool mga
			{
				get
				{
					if (!this.mfz)
					{
						return false;
					}
					if (Time.realtimeSinceStartup < this.kgt)
					{
						return false;
					}
					this.kgs = false;
					return true;
				}
			}

			// Token: 0x0600254E RID: 9550 RVA: 0x0009C4C5 File Offset: 0x0009A6C5
			public void gru(float a)
			{
				this.kgt = Time.realtimeSinceStartup + a;
				this.kgs = true;
			}

			// Token: 0x17000606 RID: 1542
			// (get) Token: 0x0600254F RID: 9551 RVA: 0x0009C4DB File Offset: 0x0009A6DB
			public float mgb
			{
				get
				{
					if (!this.kgs)
					{
						return 0f;
					}
					return this.kgt - Time.realtimeSinceStartup;
				}
			}

			// Token: 0x06002551 RID: 9553 RVA: 0x0009C4F7 File Offset: 0x0009A6F7
			public void grv()
			{
				this.kgs = false;
			}

			// Token: 0x0400121B RID: 4635
			private bool kgs;

			// Token: 0x0400121C RID: 4636
			private float kgt;
		}
	}
}
