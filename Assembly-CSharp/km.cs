using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200023F RID: 575
public abstract class km : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
	// Token: 0x1400005A RID: 90
	// (add) Token: 0x060024F2 RID: 9458 RVA: 0x0009B2E4 File Offset: 0x000994E4
	// (remove) Token: 0x060024F3 RID: 9459 RVA: 0x0009B31C File Offset: 0x0009951C
	public event Action<GameObject> kgm;

	// Token: 0x060024F4 RID: 9460 RVA: 0x0009B351 File Offset: 0x00099551
	public void OnSelect(BaseEventData eventData)
	{
		if (this.kgm != null)
		{
			this.kgm(base.gameObject);
		}
	}

	// Token: 0x040011FD RID: 4605
	public string identifier;

	// Token: 0x040011FE RID: 4606
	public int intData;

	// Token: 0x040011FF RID: 4607
	public TMP_Text text;
}
