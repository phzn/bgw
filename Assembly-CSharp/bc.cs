using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000024 RID: 36
public class bc : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Token: 0x06000204 RID: 516 RVA: 0x0000AD85 File Offset: 0x00008F85
	public void OnPointerEnter(PointerEventData eventData)
	{
		this.vk();
	}

	// Token: 0x06000205 RID: 517 RVA: 0x0000AD8D File Offset: 0x00008F8D
	public void OnPointerExit(PointerEventData eventData)
	{
		this.vl();
	}

	// Token: 0x06000206 RID: 518 RVA: 0x0000AD85 File Offset: 0x00008F85
	private void OnMouseEnter()
	{
		this.vk();
	}

	// Token: 0x06000207 RID: 519 RVA: 0x0000AD8D File Offset: 0x00008F8D
	private void mqq()
	{
		this.vl();
	}

	// Token: 0x06000208 RID: 520 RVA: 0x0000AD95 File Offset: 0x00008F95
	public void vm(bool a)
	{
		if (this.tipObject != null)
		{
			this.tipObject.vj(a);
		}
	}

	// Token: 0x06000209 RID: 521 RVA: 0x0000ADB1 File Offset: 0x00008FB1
	private void nnr()
	{
		if (this.tipObject != null)
		{
			this.tipObject.vi(this.xOffset, this.showAbove);
			this.tipObject.PointEnter();
		}
	}

	// Token: 0x0600020B RID: 523 RVA: 0x0000AD8D File Offset: 0x00008F8D
	private void OnMouseExit()
	{
		this.vl();
	}

	// Token: 0x0600020C RID: 524 RVA: 0x0000ADE3 File Offset: 0x00008FE3
	private void qh()
	{
		if (this.tipObject != null)
		{
			this.tipObject.PointExit();
		}
	}

	// Token: 0x0600020D RID: 525 RVA: 0x0000ADE3 File Offset: 0x00008FE3
	private void hco()
	{
		if (this.tipObject != null)
		{
			this.tipObject.PointExit();
		}
	}

	// Token: 0x0600020E RID: 526 RVA: 0x0000ADE3 File Offset: 0x00008FE3
	private void ist()
	{
		if (this.tipObject != null)
		{
			this.tipObject.PointExit();
		}
	}

	// Token: 0x0600020F RID: 527 RVA: 0x0000ADE3 File Offset: 0x00008FE3
	private void vl()
	{
		if (this.tipObject != null)
		{
			this.tipObject.PointExit();
		}
	}

	// Token: 0x06000210 RID: 528 RVA: 0x0000ADB1 File Offset: 0x00008FB1
	private void vk()
	{
		if (this.tipObject != null)
		{
			this.tipObject.vi(this.xOffset, this.showAbove);
			this.tipObject.PointEnter();
		}
	}

	// Token: 0x06000211 RID: 529 RVA: 0x0000AD95 File Offset: 0x00008F95
	public void jxl(bool a)
	{
		if (this.tipObject != null)
		{
			this.tipObject.vj(a);
		}
	}

	// Token: 0x0400011D RID: 285
	public bb tipObject;

	// Token: 0x0400011E RID: 286
	public float xOffset;

	// Token: 0x0400011F RID: 287
	public bool showAbove;
}
