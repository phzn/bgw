using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200025D RID: 605
public class lh : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Token: 0x060025EE RID: 9710 RVA: 0x0009DE3C File Offset: 0x0009C03C
	public virtual void OnPointerEnter(PointerEventData eventData)
	{
		if (eventData.button != PointerEventData.InputButton.Left)
		{
			return;
		}
		if (this.tooltip != null)
		{
			base.StartCoroutine(ll.guz(this.tooltip.GetComponent<CanvasGroup>(), 1f, this.fadeTime));
		}
	}

	// Token: 0x060025EF RID: 9711 RVA: 0x0009DE77 File Offset: 0x0009C077
	public virtual void OnPointerExit(PointerEventData eventData)
	{
		if (eventData.button != PointerEventData.InputButton.Left)
		{
			return;
		}
		if (this.tooltip != null)
		{
			base.StartCoroutine(ll.gva(this.tooltip.GetComponent<CanvasGroup>(), 0f, this.fadeTime));
		}
	}

	// Token: 0x0400126A RID: 4714
	public GameObject tooltip;

	// Token: 0x0400126B RID: 4715
	public float fadeTime = 0.1f;
}
