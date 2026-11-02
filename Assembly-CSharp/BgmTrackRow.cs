using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000083 RID: 131
public sealed class BgmTrackRow : MonoBehaviour
{
	// Token: 0x060005BD RID: 1469 RVA: 0x0001FF41 File Offset: 0x0001E141
	private static Color bnp(int a)
	{
		return BgmTrackRow.htq[Mathf.Abs(a) % BgmTrackRow.htq.Length];
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x0001FF5C File Offset: 0x0001E15C
	public void bnq(int a, BgmTrack b, bool c, bool d, Action<int> e, string f, bb g, string h)
	{
		BgmTrackRow.co co = new BgmTrackRow.co();
		co.htk = f;
		co.htl = g;
		co.htm = h;
		co.htn = e;
		if (b == null)
		{
			return;
		}
		bool flag = b.albumArt != null;
		if (this.title != null)
		{
			this.title.text = b.displayName;
			this.title.gameObject.SetActive(!flag);
		}
		if (this.duration != null)
		{
			this.duration.text = b.durationLabel;
			this.duration.gameObject.SetActive(!flag);
		}
		if (this.banner != null)
		{
			this.banner.sprite = b.albumArt;
			this.banner.color = (flag ? Color.white : BgmTrackRow.bnp(a));
		}
		if (this.lockOverlay != null)
		{
			this.lockOverlay.SetActive(c);
		}
		if (this.nowPlaying != null)
		{
			this.nowPlaying.SetActive(!c && d);
		}
		if (this.dimOverlay != null)
		{
			Image component = this.dimOverlay.GetComponent<Image>();
			if (component != null)
			{
				component.sprite = ((this.banner != null) ? this.banner.sprite : null);
			}
			this.dimOverlay.SetActive(!c && !d);
		}
		if (this.selectButton != null)
		{
			this.selectButton.interactable = !c;
		}
		if (this.lockButton != null)
		{
			this.lockButton.onClick.RemoveAllListeners();
		}
		if (this.selectButton != null)
		{
			this.selectButton.onClick.RemoveAllListeners();
		}
		u u = ((this.lockOverlay != null) ? this.lockOverlay.GetComponent<u>() : null);
		if (c && this.lockOverlay != null && u == null)
		{
			u = this.lockOverlay.AddComponent<u>();
		}
		if (u != null)
		{
			u.Entered = null;
			u.Exited = null;
		}
		if (c)
		{
			if (this.lockButton != null)
			{
				this.lockButton.onClick.AddListener(new UnityAction(co.bnl));
			}
			if (u != null && co.htl != null)
			{
				u.Entered = new Action(co.bnm);
				u.Exited = new Action(co.bnn);
				return;
			}
		}
		else if (this.selectButton != null && co.htn != null)
		{
			BgmTrackRow.cp cp = new BgmTrackRow.cp();
			cp.htp = co;
			cp.hto = a;
			this.selectButton.onClick.AddListener(new UnityAction(cp.bno));
		}
	}

	// Token: 0x040005F5 RID: 1525
	[SerializeField]
	private Image banner;

	// Token: 0x040005F6 RID: 1526
	[SerializeField]
	private TMP_Text title;

	// Token: 0x040005F7 RID: 1527
	[SerializeField]
	private TMP_Text duration;

	// Token: 0x040005F8 RID: 1528
	[SerializeField]
	private GameObject nowPlaying;

	// Token: 0x040005F9 RID: 1529
	[SerializeField]
	private GameObject lockOverlay;

	// Token: 0x040005FA RID: 1530
	[SerializeField]
	private GameObject dimOverlay;

	// Token: 0x040005FB RID: 1531
	[SerializeField]
	private Button lockButton;

	// Token: 0x040005FC RID: 1532
	[SerializeField]
	private Button selectButton;

	// Token: 0x040005FD RID: 1533
	private static readonly Color[] htq = new Color[]
	{
		new Color(0.93f, 0.65f, 0.35f),
		new Color(0.85f, 0.45f, 0.45f),
		new Color(0.55f, 0.7f, 0.55f),
		new Color(0.5f, 0.62f, 0.82f),
		new Color(0.72f, 0.58f, 0.82f),
		new Color(0.9f, 0.8f, 0.45f)
	};

	// Token: 0x02000084 RID: 132
	[CompilerGenerated]
	private sealed class co
	{
		// Token: 0x060005C1 RID: 1473 RVA: 0x000202FA File Offset: 0x0001E4FA
		internal void cbf()
		{
			this.htl.PointExit();
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00020307 File Offset: 0x0001E507
		internal void bnl()
		{
			Application.OpenURL(this.htk);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x000202FA File Offset: 0x0001E4FA
		internal void bnn()
		{
			this.htl.PointExit();
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x000202FA File Offset: 0x0001E4FA
		internal void bvc()
		{
			this.htl.PointExit();
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00020307 File Offset: 0x0001E507
		internal void mgx()
		{
			Application.OpenURL(this.htk);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00020314 File Offset: 0x0001E514
		internal void bnm()
		{
			this.htl.vj(true);
			this.htl.vh(this.htm);
			this.htl.PointEnter();
		}

		// Token: 0x040005FE RID: 1534
		public string htk;

		// Token: 0x040005FF RID: 1535
		public bb htl;

		// Token: 0x04000600 RID: 1536
		public string htm;

		// Token: 0x04000601 RID: 1537
		public Action<int> htn;
	}

	// Token: 0x02000085 RID: 133
	[CompilerGenerated]
	private sealed class cp
	{
		// Token: 0x060005C9 RID: 1481 RVA: 0x0002033E File Offset: 0x0001E53E
		internal void bno()
		{
			this.htp.htn(this.hto);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0002033E File Offset: 0x0001E53E
		internal void glq()
		{
			this.htp.htn(this.hto);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0002033E File Offset: 0x0001E53E
		internal void bvh()
		{
			this.htp.htn(this.hto);
		}

		// Token: 0x04000602 RID: 1538
		public int hto;

		// Token: 0x04000603 RID: 1539
		public BgmTrackRow.co htp;
	}
}
