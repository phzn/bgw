using System;
using System.Collections.Generic;
using Ricimi;
using UnityEngine;

// Token: 0x02000251 RID: 593
public class kw : kz
{
	// Token: 0x06002586 RID: 9606 RVA: 0x0009CF52 File Offset: 0x0009B152
	public override void OpenPopup()
	{
		base.OpenPopup();
		this.khq.GetComponent<kv>().gtq(this);
	}

	// Token: 0x0400123E RID: 4670
	public string Title;

	// Token: 0x0400123F RID: 4671
	public string Subtitle;

	// Token: 0x04001240 RID: 4672
	[TextArea(3, 3)]
	public string Message;

	// Token: 0x04001241 RID: 4673
	[Space]
	public Sprite Image;

	// Token: 0x04001242 RID: 4674
	public Color32 TintColor = Color.white;

	// Token: 0x04001243 RID: 4675
	public string Caption;

	// Token: 0x04001244 RID: 4676
	[Space]
	public List<ButtonInfo> Buttons;
}
