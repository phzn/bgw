using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Token: 0x020000C1 RID: 193
public sealed class DraggableWindow : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x06000A0C RID: 2572 RVA: 0x0003B16E File Offset: 0x0003936E
	// (set) Token: 0x06000A0D RID: 2573 RVA: 0x0003B176 File Offset: 0x00039376
	public bool ich { get; private set; }

	// Token: 0x06000A0E RID: 2574 RVA: 0x0003B180 File Offset: 0x00039380
	private void Awake()
	{
		if (this.target == null)
		{
			this.target = base.transform.parent as RectTransform;
		}
		if (this.canvas == null)
		{
			this.canvas = base.GetComponentInParent<Canvas>();
		}
		if (this.target != null)
		{
			this.icf = this.target.anchoredPosition;
			this.icg = true;
		}
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x0003B1F1 File Offset: 0x000393F1
	public void cgk()
	{
		if (!this.icg || this.target == null)
		{
			return;
		}
		this.target.anchoredPosition = this.icf;
		UnityEvent<Vector2> unityEvent = this.onPositionChanged;
		if (unityEvent == null)
		{
			return;
		}
		unityEvent.Invoke(this.icf);
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x0003B231 File Offset: 0x00039431
	public void OnBeginDrag(PointerEventData eventData)
	{
		this.ich = true;
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x0003B23C File Offset: 0x0003943C
	public void OnDrag(PointerEventData eventData)
	{
		if (this.target == null || this.canvas == null)
		{
			return;
		}
		float num = ((this.canvas.scaleFactor > 0f) ? this.canvas.scaleFactor : 1f);
		this.target.anchoredPosition += eventData.delta / num;
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x0003B2AD File Offset: 0x000394AD
	public void OnEndDrag(PointerEventData eventData)
	{
		this.ich = false;
		if (this.target == null)
		{
			return;
		}
		UnityEvent<Vector2> unityEvent = this.onPositionChanged;
		if (unityEvent == null)
		{
			return;
		}
		unityEvent.Invoke(this.target.anchoredPosition);
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x0003B2E0 File Offset: 0x000394E0
	private void OnDisable()
	{
		this.ich = false;
	}

	// Token: 0x04000822 RID: 2082
	[SerializeField]
	private RectTransform target;

	// Token: 0x04000823 RID: 2083
	[SerializeField]
	private Canvas canvas;

	// Token: 0x04000824 RID: 2084
	public UnityEvent<Vector2> onPositionChanged;

	// Token: 0x04000825 RID: 2085
	private Vector2 icf;

	// Token: 0x04000826 RID: 2086
	private bool icg;
}
