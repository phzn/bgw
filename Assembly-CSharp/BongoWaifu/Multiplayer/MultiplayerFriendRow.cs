using System;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BongoWaifu.Multiplayer
{
	// Token: 0x0200011D RID: 285
	public sealed class MultiplayerFriendRow : MonoBehaviour
	{
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x00064146 File Offset: 0x00062346
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x0006414E File Offset: 0x0006234E
		public ulong irz { get; private set; }

		// Token: 0x06001452 RID: 5202 RVA: 0x00064157 File Offset: 0x00062357
		private void Awake()
		{
			this.dcb();
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00064160 File Offset: 0x00062360
		private void dcb()
		{
			if (this.isd)
			{
				return;
			}
			this.isd = true;
			if (this.actionButton != null)
			{
				this.actionButton.onClick.AddListener(new UnityAction(this.dch));
			}
			if (this.muteButton != null)
			{
				this.muteButton.onClick.AddListener(new UnityAction(this.dci));
			}
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x000641D4 File Offset: 0x000623D4
		public void dcc(string a, Action b, bool c = true, bool d = true)
		{
			this.dcb();
			this.isc = a;
			if (this.titleText != null)
			{
				this.titleText.text = a;
			}
			this.isa = b;
			if (this.actionButton != null)
			{
				this.actionButton.gameObject.SetActive(c);
				this.actionButton.interactable = d;
			}
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0006423C File Offset: 0x0006243C
		public void dcd(string a, bool b)
		{
			if (this.titleText != null)
			{
				this.titleText.text = string.Format(MultiplayerLoc.Get(a.dyc(), a.dyd()), this.isc, a);
			}
			if (this.actionButton != null)
			{
				this.actionButton.interactable = b;
			}
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00064297 File Offset: 0x00062497
		public void dce(ulong a, bool b, Action c, bool d = true)
		{
			this.dcb();
			this.irz = a;
			this.isb = c;
			if (this.muteButton != null)
			{
				this.muteButton.gameObject.SetActive(d);
			}
			this.dcf(b);
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x000642D4 File Offset: 0x000624D4
		public void dcf(bool a)
		{
			if (this.muteIconOn != null)
			{
				this.muteIconOn.SetActive(!a);
			}
			if (this.muteIconOff != null)
			{
				this.muteIconOff.SetActive(a);
			}
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0006430D File Offset: 0x0006250D
		public void dcg(Color a)
		{
			if (this.colorSwatch != null)
			{
				this.colorSwatch.color = a;
			}
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00064329 File Offset: 0x00062529
		[CompilerGenerated]
		private void dch()
		{
			Action action = this.isa;
			if (action == null)
			{
				return;
			}
			action();
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0006433B File Offset: 0x0006253B
		[CompilerGenerated]
		private void dci()
		{
			Action action = this.isb;
			if (action == null)
			{
				return;
			}
			action();
		}

		// Token: 0x04000A80 RID: 2688
		[SerializeField]
		public TMP_Text titleText;

		// Token: 0x04000A81 RID: 2689
		[SerializeField]
		public Button actionButton;

		// Token: 0x04000A82 RID: 2690
		[SerializeField]
		public Image colorSwatch;

		// Token: 0x04000A83 RID: 2691
		[SerializeField]
		public Button muteButton;

		// Token: 0x04000A84 RID: 2692
		[SerializeField]
		public GameObject muteIconOn;

		// Token: 0x04000A85 RID: 2693
		[SerializeField]
		public GameObject muteIconOff;

		// Token: 0x04000A87 RID: 2695
		private Action isa;

		// Token: 0x04000A88 RID: 2696
		private Action isb;

		// Token: 0x04000A89 RID: 2697
		private string isc;

		// Token: 0x04000A8A RID: 2698
		private bool isd;
	}
}
