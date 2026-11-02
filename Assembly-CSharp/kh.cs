using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Rewired.Utils;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200022C RID: 556
[RequireComponent(typeof(Selectable))]
public class kh : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
	// Token: 0x06002475 RID: 9333 RVA: 0x0009A260 File Offset: 0x00098460
	private void Start()
	{
		this.kgd = base.transform.GetComponentInParent<ScrollRect>();
		if (this.kgd == null)
		{
			Debug.LogError(a.exx());
			return;
		}
	}

	// Token: 0x170005BF RID: 1471
	// (get) Token: 0x06002476 RID: 9334 RVA: 0x0009A28C File Offset: 0x0009848C
	private RectTransform mdt
	{
		get
		{
			return this.kgd.content;
		}
	}

	// Token: 0x170005C0 RID: 1472
	// (get) Token: 0x06002477 RID: 9335 RVA: 0x0009A29C File Offset: 0x0009849C
	private Selectable mdu
	{
		get
		{
			Selectable selectable;
			if ((selectable = this.kge) == null)
			{
				selectable = (this.kge = base.GetComponent<Selectable>());
			}
			return selectable;
		}
	}

	// Token: 0x170005C1 RID: 1473
	// (get) Token: 0x06002478 RID: 9336 RVA: 0x0009A2C2 File Offset: 0x000984C2
	private RectTransform mdv
	{
		get
		{
			return base.transform as RectTransform;
		}
	}

	// Token: 0x06002479 RID: 9337 RVA: 0x0009A2D0 File Offset: 0x000984D0
	public void OnSelect(BaseEventData eventData)
	{
		if (this.kgd == null)
		{
			return;
		}
		if (!(eventData is AxisEventData))
		{
			return;
		}
		RectTransform rectTransform = this.kgd.transform as RectTransform;
		Rect rect = MathTools.TransformRect(this.mdv.rect, this.mdv, rectTransform);
		Rect rect2 = rectTransform.rect;
		Rect rect3 = rectTransform.rect;
		float height;
		if (this.useCustomEdgePadding)
		{
			height = this.customEdgePadding;
		}
		else
		{
			height = rect.height;
		}
		rect3.yMax -= height;
		rect3.yMin += height;
		if (MathTools.RectContains(rect3, rect))
		{
			return;
		}
		Vector2 vector;
		if (!MathTools.GetOffsetToContainRect(rect3, rect, out vector))
		{
			return;
		}
		Vector2 anchoredPosition = this.mdt.anchoredPosition;
		anchoredPosition.x = Mathf.Clamp(anchoredPosition.x + vector.x, 0f, Mathf.Abs(rect2.width - this.mdt.sizeDelta.x));
		anchoredPosition.y = Mathf.Clamp(anchoredPosition.y + vector.y, 0f, Mathf.Abs(rect2.height - this.mdt.sizeDelta.y));
		this.mdt.anchoredPosition = anchoredPosition;
	}

	// Token: 0x040011A5 RID: 4517
	public bool useCustomEdgePadding;

	// Token: 0x040011A6 RID: 4518
	public float customEdgePadding = 50f;

	// Token: 0x040011A7 RID: 4519
	private ScrollRect kgd;

	// Token: 0x040011A8 RID: 4520
	private Selectable kge;
}
