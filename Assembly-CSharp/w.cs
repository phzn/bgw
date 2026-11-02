using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000021 RID: 33
public sealed class w : MonoBehaviour, IScrollHandler, IEventSystemHandler
{
	// Token: 0x060001BE RID: 446 RVA: 0x000093DC File Offset: 0x000075DC
	private void kv()
	{
		this.hhu = base.GetComponentInParent<ScrollRect>();
	}

	// Token: 0x060001BF RID: 447 RVA: 0x000093DC File Offset: 0x000075DC
	private void msw()
	{
		this.hhu = base.GetComponentInParent<ScrollRect>();
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x000093DC File Offset: 0x000075DC
	private void Awake()
	{
		this.hhu = base.GetComponentInParent<ScrollRect>();
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x000093DC File Offset: 0x000075DC
	private void ham()
	{
		this.hhu = base.GetComponentInParent<ScrollRect>();
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x000093EA File Offset: 0x000075EA
	[NullableContext(1)]
	public void OnScroll(PointerEventData eventData)
	{
		if (this.hhu != null)
		{
			this.hhu.OnScroll(eventData);
		}
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x000093DC File Offset: 0x000075DC
	private void dgc()
	{
		this.hhu = base.GetComponentInParent<ScrollRect>();
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x000093DC File Offset: 0x000075DC
	private void OnTransformParentChanged()
	{
		this.hhu = base.GetComponentInParent<ScrollRect>();
	}

	// Token: 0x04000100 RID: 256
	[Nullable(2)]
	private ScrollRect hhu;
}
