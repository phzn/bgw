using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using TMPro;
using UnityEngine;

// Token: 0x02000095 RID: 149
public class GalleryItemController : MonoBehaviour
{
	// Token: 0x17000094 RID: 148
	// (get) Token: 0x060006B1 RID: 1713 RVA: 0x000252A0 File Offset: 0x000234A0
	public static GalleryItemController kpy
	{
		get
		{
			return GalleryItemController.hwb;
		}
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x000252A7 File Offset: 0x000234A7
	private void Awake()
	{
		GalleryItemController.hwb = this;
		if (this.galleryItem != null)
		{
			this.galleryItem.transform.SetParent(this.transPool, false);
			this.galleryItem.gameObject.SetActive(false);
		}
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x000252E5 File Offset: 0x000234E5
	private void OnDestroy()
	{
		if (GalleryItemController.hwb == this)
		{
			GalleryItemController.hwb = null;
		}
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x000252FC File Offset: 0x000234FC
	public void brz(CLOTHE_TYPE a)
	{
		this.hwa = a;
		this.hvz = true;
		this.bsd();
		if (!SettingPanel.kqs)
		{
			this.bsf(0, 0);
			return;
		}
		SpineSkinSetting hle = bq.hle;
		if (hle == null)
		{
			this.bsf(0, 0);
			return;
		}
		List<SpineSkinData> list = hle.bkl(a);
		List<SpineSkinData> collabSkinDatas = hle.CollabSkinDatas;
		if (list == null)
		{
			this.bsf(0, 0);
			return;
		}
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < list.Count; i++)
		{
			SpineSkinData spineSkinData = list[i];
			if (spineSkinData != null)
			{
				int num3 = spineSkinData.kox;
				if (num3 >= 1000)
				{
					bool flag = collabSkinDatas != null && collabSkinDatas.Contains(spineSkinData);
					bool flag2 = hle.bjz(num3);
					bool flag3 = bq.bar(num3) > 0;
					if ((!flag && !flag2) || flag3)
					{
						num2++;
						if (flag3)
						{
							num++;
						}
						this.bsb(spineSkinData, flag3);
					}
				}
			}
		}
		this.bsf(num, num2);
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x000253EB File Offset: 0x000235EB
	public void bsa()
	{
		if (this.hvz)
		{
			this.brz(this.hwa);
		}
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x00025401 File Offset: 0x00023601
	private void bsb(SpineSkinData a, bool b)
	{
		this.bsc(this.transContent).bru(a, b);
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x00025418 File Offset: 0x00023618
	private GalleryItem bsc(Transform a)
	{
		GalleryItem galleryItem = ((this.hvy.Count > 0) ? this.hvy.Dequeue() : global::UnityEngine.Object.Instantiate<GalleryItem>(this.galleryItem, this.transPool));
		galleryItem.brt();
		galleryItem.transform.SetParent(a, false);
		this.hvx.Add(galleryItem);
		return galleryItem;
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x00025474 File Offset: 0x00023674
	private void bsd()
	{
		for (int i = this.hvx.Count - 1; i >= 0; i--)
		{
			this.bse(this.hvx[i]);
		}
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x000254AB File Offset: 0x000236AB
	private void bse(GalleryItem a)
	{
		this.hvx.Remove(a);
		a.transform.SetParent(this.transPool, false);
		a.Close();
		this.hvy.Enqueue(a);
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x000254DE File Offset: 0x000236DE
	private void bsf(int a, int b)
	{
		if (this.txtProgress != null)
		{
			this.txtProgress.text = string.Format(a.biq(), a, b);
		}
	}

	// Token: 0x04000678 RID: 1656
	[SerializeField]
	private GalleryItem galleryItem;

	// Token: 0x04000679 RID: 1657
	[SerializeField]
	private Transform transContent;

	// Token: 0x0400067A RID: 1658
	[SerializeField]
	private Transform transPool;

	// Token: 0x0400067B RID: 1659
	[SerializeField]
	private TMP_Text txtProgress;

	// Token: 0x0400067C RID: 1660
	private readonly List<GalleryItem> hvx = new List<GalleryItem>();

	// Token: 0x0400067D RID: 1661
	private readonly Queue<GalleryItem> hvy = new Queue<GalleryItem>();

	// Token: 0x0400067E RID: 1662
	private bool hvz;

	// Token: 0x0400067F RID: 1663
	private CLOTHE_TYPE hwa;

	// Token: 0x04000680 RID: 1664
	private static GalleryItemController hwb;
}
