using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200025B RID: 603
public class lf : MonoBehaviour
{
	// Token: 0x060025DC RID: 9692 RVA: 0x0009DD66 File Offset: 0x0009BF66
	private void der()
	{
		this.khy = base.GetComponent<Toggle>();
		this.khy.onValueChanged.AddListener(new UnityAction<bool>(this.gui));
	}

	// Token: 0x060025DD RID: 9693 RVA: 0x0009DD66 File Offset: 0x0009BF66
	private void djk()
	{
		this.khy = base.GetComponent<Toggle>();
		this.khy.onValueChanged.AddListener(new UnityAction<bool>(this.gui));
	}

	// Token: 0x060025DE RID: 9694 RVA: 0x0009DD66 File Offset: 0x0009BF66
	private void orw()
	{
		this.khy = base.GetComponent<Toggle>();
		this.khy.onValueChanged.AddListener(new UnityAction<bool>(this.gui));
	}

	// Token: 0x060025DF RID: 9695 RVA: 0x0009DD66 File Offset: 0x0009BF66
	private void Awake()
	{
		this.khy = base.GetComponent<Toggle>();
		this.khy.onValueChanged.AddListener(new UnityAction<bool>(this.gui));
	}

	// Token: 0x060025E0 RID: 9696 RVA: 0x0009DD90 File Offset: 0x0009BF90
	private void OnDestroy()
	{
		this.khy.onValueChanged.RemoveListener(new UnityAction<bool>(this.gui));
	}

	// Token: 0x060025E2 RID: 9698 RVA: 0x0009DDAE File Offset: 0x0009BFAE
	private void gui(bool a)
	{
		this.TabMenu.guh(this.khy, a);
	}

	// Token: 0x04001265 RID: 4709
	public le TabMenu;

	// Token: 0x04001266 RID: 4710
	private Toggle khy;
}
