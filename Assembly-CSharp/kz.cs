using System;
using UnityEngine;

// Token: 0x02000254 RID: 596
public class kz : MonoBehaviour
{
	// Token: 0x0600259D RID: 9629 RVA: 0x0009D6CF File Offset: 0x0009B8CF
	protected void Start()
	{
		this.khp = base.GetComponentInParent<Canvas>();
	}

	// Token: 0x0600259E RID: 9630 RVA: 0x0009D6DD File Offset: 0x0009B8DD
	public virtual void OpenPopup()
	{
		this.khq = global::UnityEngine.Object.Instantiate<GameObject>(this.popupPrefab, this.khp.transform, false);
		this.khq.SetActive(true);
		this.khq.GetComponent<ky>().Open();
	}

	// Token: 0x0400124B RID: 4683
	public GameObject popupPrefab;

	// Token: 0x0400124C RID: 4684
	protected Canvas khp;

	// Token: 0x0400124D RID: 4685
	protected GameObject khq;
}
