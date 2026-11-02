using System;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000016 RID: 22
public class m : k
{
	// Token: 0x060000EF RID: 239 RVA: 0x000060D7 File Offset: 0x000042D7
	public override void Start()
	{
		base.Start();
		if (base.GetComponent<Button>() != null)
		{
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.rx));
		}
	}
}
