using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000096 RID: 150
public class GalleryPanel : MonoBehaviour
{
	// Token: 0x060006BC RID: 1724 RVA: 0x0002552D File Offset: 0x0002372D
	private void Awake()
	{
		this.bsh();
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x00025538 File Offset: 0x00023738
	private void bsh()
	{
		if (this.hwd)
		{
			return;
		}
		this.hwd = true;
		this.bsi(this.toggle_Hair, CLOTHE_TYPE.Hair);
		this.bsi(this.toggle_Top, CLOTHE_TYPE.Top);
		this.bsi(this.toggle_Bottom, CLOTHE_TYPE.Bottom);
		this.bsi(this.toggle_Underwear, CLOTHE_TYPE.Underwear);
		this.bsi(this.toggle_Socks, CLOTHE_TYPE.Socks);
		this.bsi(this.toggle_Shoes, CLOTHE_TYPE.Shoes);
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x000255A4 File Offset: 0x000237A4
	private void bsi(Toggle a, CLOTHE_TYPE b)
	{
		GalleryPanel.cz cz = new GalleryPanel.cz();
		cz.hwc = b;
		if (a == null)
		{
			return;
		}
		a.onValueChanged.AddListener(new UnityAction<bool>(cz.bsg));
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x000255E0 File Offset: 0x000237E0
	public void bsj()
	{
		if (this.toggle_Hair == null)
		{
			if (GalleryItemController.kpy != null)
			{
				GalleryItemController.kpy.brz(CLOTHE_TYPE.Hair);
			}
			return;
		}
		if (this.toggle_Hair.isOn)
		{
			if (GalleryItemController.kpy != null)
			{
				GalleryItemController.kpy.brz(CLOTHE_TYPE.Hair);
				return;
			}
		}
		else
		{
			this.toggle_Hair.isOn = true;
		}
	}

	// Token: 0x04000681 RID: 1665
	[SerializeField]
	private Toggle toggle_Hair;

	// Token: 0x04000682 RID: 1666
	[SerializeField]
	private Toggle toggle_Top;

	// Token: 0x04000683 RID: 1667
	[SerializeField]
	private Toggle toggle_Bottom;

	// Token: 0x04000684 RID: 1668
	[SerializeField]
	private Toggle toggle_Underwear;

	// Token: 0x04000685 RID: 1669
	[SerializeField]
	private Toggle toggle_Socks;

	// Token: 0x04000686 RID: 1670
	[SerializeField]
	private Toggle toggle_Shoes;

	// Token: 0x04000687 RID: 1671
	private bool hwd;

	// Token: 0x02000097 RID: 151
	[CompilerGenerated]
	private sealed class cz
	{
		// Token: 0x060006C2 RID: 1730 RVA: 0x00025646 File Offset: 0x00023846
		internal void eex(bool a)
		{
			if (a && GalleryItemController.kpy != null)
			{
				GalleryItemController.kpy.brz(this.hwc);
			}
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00025646 File Offset: 0x00023846
		internal void bsg(bool a)
		{
			if (a && GalleryItemController.kpy != null)
			{
				GalleryItemController.kpy.brz(this.hwc);
			}
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00025646 File Offset: 0x00023846
		internal void grk(bool a)
		{
			if (a && GalleryItemController.kpy != null)
			{
				GalleryItemController.kpy.brz(this.hwc);
			}
		}

		// Token: 0x04000688 RID: 1672
		public CLOTHE_TYPE hwc;
	}
}
