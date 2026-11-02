using System;
using TMPro;
using UnityEngine.Events;

// Token: 0x02000017 RID: 23
public class n : k
{
	// Token: 0x060000F1 RID: 241 RVA: 0x00006112 File Offset: 0x00004312
	public void bin(int a)
	{
		base.rx();
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00006112 File Offset: 0x00004312
	public void ndl(int a)
	{
		base.rx();
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00006112 File Offset: 0x00004312
	public void sz(int a)
	{
		base.rx();
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x0000611A File Offset: 0x0000431A
	public override void Start()
	{
		base.Start();
		base.GetComponent<TMP_Dropdown>().onValueChanged.AddListener(new UnityAction<int>(this.sz));
	}
}
