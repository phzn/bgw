using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200001F RID: 31
public sealed class u : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Token: 0x060001B0 RID: 432 RVA: 0x0000933A File Offset: 0x0000753A
	public void OnPointerEnter(PointerEventData eventData)
	{
		Action entered = this.Entered;
		if (entered == null)
		{
			return;
		}
		entered();
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x0000934C File Offset: 0x0000754C
	public void OnPointerExit(PointerEventData eventData)
	{
		Action exited = this.Exited;
		if (exited == null)
		{
			return;
		}
		exited();
	}

	// Token: 0x040000FD RID: 253
	public Action Entered;

	// Token: 0x040000FE RID: 254
	public Action Exited;
}
