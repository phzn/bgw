using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000020 RID: 32
public sealed class v : MonoBehaviour, IScrollHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	// Token: 0x060001B3 RID: 435 RVA: 0x0000935E File Offset: 0x0000755E
	private void Awake()
	{
		this.hht = base.GetComponentInParent<ScrollRect>();
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x0000935E File Offset: 0x0000755E
	private void ggh()
	{
		this.hht = base.GetComponentInParent<ScrollRect>();
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x0000935E File Offset: 0x0000755E
	private void isj()
	{
		this.hht = base.GetComponentInParent<ScrollRect>();
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x0000936C File Offset: 0x0000756C
	[NullableContext(1)]
	public void OnScroll(PointerEventData eventData)
	{
		if (this.hht != null)
		{
			this.hht.OnScroll(eventData);
		}
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x0000935E File Offset: 0x0000755E
	private void miq()
	{
		this.hht = base.GetComponentInParent<ScrollRect>();
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x00009388 File Offset: 0x00007588
	[NullableContext(1)]
	public void OnEndDrag(PointerEventData eventData)
	{
		if (this.hht != null)
		{
			this.hht.OnEndDrag(eventData);
		}
	}

	// Token: 0x060001BA RID: 442 RVA: 0x000093A4 File Offset: 0x000075A4
	[NullableContext(1)]
	public void OnDrag(PointerEventData eventData)
	{
		if (this.hht != null)
		{
			this.hht.OnDrag(eventData);
		}
	}

	// Token: 0x060001BB RID: 443 RVA: 0x0000935E File Offset: 0x0000755E
	private void bfk()
	{
		this.hht = base.GetComponentInParent<ScrollRect>();
	}

	// Token: 0x060001BC RID: 444 RVA: 0x0000935E File Offset: 0x0000755E
	private void OnTransformParentChanged()
	{
		this.hht = base.GetComponentInParent<ScrollRect>();
	}

	// Token: 0x060001BD RID: 445 RVA: 0x000093C0 File Offset: 0x000075C0
	[NullableContext(1)]
	public void OnBeginDrag(PointerEventData eventData)
	{
		if (this.hht != null)
		{
			this.hht.OnBeginDrag(eventData);
		}
	}

	// Token: 0x040000FF RID: 255
	[Nullable(2)]
	private ScrollRect hht;
}
