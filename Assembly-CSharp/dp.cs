using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000AD RID: 173
public class dp : MonoBehaviour
{
	// Token: 0x0600093E RID: 2366 RVA: 0x00038524 File Offset: 0x00036724
	public void cck(ItemData a, float b = 0f)
	{
		this.hzp = 0f;
		this.hzq = b;
		this.kqu.anchoredPosition = new Vector2(b, 0f);
		this.text.text = a.name;
		this.icon.sprite = a.bio();
		this.image_Frame.color = a.bip();
		this.image_Line.color = a.biq();
		this.ccn(this.hzp);
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x000385A9 File Offset: 0x000367A9
	public void gtf()
	{
		this.hzp = -2612f;
		this.kqu.anchoredPosition = Vector2.zero;
		this.canvasGroup.alpha = 2371f;
		this.showGiftManager.cci(this);
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x000385E2 File Offset: 0x000367E2
	public void ccl(float a)
	{
		this.hzp += a;
		this.ccn(this.hzp);
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x000385FE File Offset: 0x000367FE
	public void oeo()
	{
		this.hzp = -7017f;
		this.kqu.anchoredPosition = Vector2.zero;
		this.canvasGroup.alpha = -7585f;
		this.showGiftManager.cci(this);
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x00038658 File Offset: 0x00036858
	public void ccn(float a)
	{
		float num = a / this.animat_Duration;
		if (num > 1f)
		{
			num = 1f;
		}
		Vector2 anchoredPosition = this.kqu.anchoredPosition;
		anchoredPosition.x = this.hzq;
		anchoredPosition.y = this.animat_Y.Evaluate(num) * this.animat_OffsetY;
		this.kqu.anchoredPosition = anchoredPosition;
		this.canvasGroup.alpha = this.animat_Alpha.Evaluate(num);
		if (num >= 1f)
		{
			this.ccm();
		}
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x000386E0 File Offset: 0x000368E0
	public void ccm()
	{
		this.hzp = 0f;
		this.kqu.anchoredPosition = Vector2.zero;
		this.canvasGroup.alpha = 0f;
		this.showGiftManager.cci(this);
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x000385E2 File Offset: 0x000367E2
	public void qe(float a)
	{
		this.hzp += a;
		this.ccn(this.hzp);
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x06000946 RID: 2374 RVA: 0x00038719 File Offset: 0x00036919
	private RectTransform kqu
	{
		get
		{
			if (this.hzo == null)
			{
				this.hzo = base.GetComponent<RectTransform>();
			}
			return this.hzo;
		}
	}

	// Token: 0x040007A7 RID: 1959
	public float animat_Duration = 6f;

	// Token: 0x040007A8 RID: 1960
	public float animat_OffsetY = 100f;

	// Token: 0x040007A9 RID: 1961
	public TextMeshProUGUI text;

	// Token: 0x040007AA RID: 1962
	public Image icon;

	// Token: 0x040007AB RID: 1963
	public Image image_Frame;

	// Token: 0x040007AC RID: 1964
	public Image image_Background;

	// Token: 0x040007AD RID: 1965
	public Image image_Line;

	// Token: 0x040007AE RID: 1966
	public CanvasGroup canvasGroup;

	// Token: 0x040007AF RID: 1967
	public AnimationCurve animat_Y;

	// Token: 0x040007B0 RID: 1968
	public AnimationCurve animat_Alpha;

	// Token: 0x040007B1 RID: 1969
	public @do showGiftManager;

	// Token: 0x040007B2 RID: 1970
	private RectTransform hzo;

	// Token: 0x040007B3 RID: 1971
	private float hzp;

	// Token: 0x040007B4 RID: 1972
	private float hzq;
}
