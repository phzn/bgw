using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000244 RID: 580
public class kp : kk
{
	// Token: 0x170005F7 RID: 1527
	// (get) Token: 0x06002504 RID: 9476 RVA: 0x0009B6BC File Offset: 0x000998BC
	// (set) Token: 0x06002505 RID: 9477 RVA: 0x0009B6C4 File Offset: 0x000998C4
	public bool mfx
	{
		get
		{
			return this.kgq;
		}
		set
		{
			if (this.iconImage == null)
			{
				return;
			}
			this.iconImage.gameObject.SetActive(value);
			this.kgq = value;
		}
	}

	// Token: 0x170005F8 RID: 1528
	// (get) Token: 0x06002506 RID: 9478 RVA: 0x0009B6ED File Offset: 0x000998ED
	// (set) Token: 0x06002507 RID: 9479 RVA: 0x0009B6F5 File Offset: 0x000998F5
	public bool mfy
	{
		get
		{
			return this.kgr;
		}
		set
		{
			if (this.slider == null)
			{
				return;
			}
			this.slider.gameObject.SetActive(value);
			this.kgr = value;
		}
	}

	// Token: 0x06002508 RID: 9480 RVA: 0x0009B720 File Offset: 0x00099920
	public override void gqk(Action a)
	{
		kp.ko ko = new kp.ko();
		ko.kgp = a;
		base.gqk(ko.kgp);
		if (ko.kgp == null || this.slider == null)
		{
			return;
		}
		if (this.slider is kc)
		{
			(this.slider as kc).mhr += ko.grd;
			return;
		}
		EventTrigger eventTrigger = this.slider.GetComponent<EventTrigger>();
		if (eventTrigger == null)
		{
			eventTrigger = this.slider.gameObject.AddComponent<EventTrigger>();
		}
		EventTrigger.Entry entry = new EventTrigger.Entry();
		entry.callback = new EventTrigger.TriggerEvent();
		entry.eventID = EventTriggerType.Cancel;
		entry.callback.AddListener(new UnityAction<BaseEventData>(ko.gre));
		if (eventTrigger.triggers == null)
		{
			eventTrigger.triggers = new List<EventTrigger.Entry>();
		}
		eventTrigger.triggers.Add(entry);
	}

	// Token: 0x04001208 RID: 4616
	public Image iconImage;

	// Token: 0x04001209 RID: 4617
	public Slider slider;

	// Token: 0x0400120A RID: 4618
	private bool kgq;

	// Token: 0x0400120B RID: 4619
	private bool kgr;

	// Token: 0x02000245 RID: 581
	[CompilerGenerated]
	private sealed class ko
	{
		// Token: 0x0600250A RID: 9482 RVA: 0x0009B804 File Offset: 0x00099A04
		internal void ifx()
		{
			this.kgp();
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x0009B804 File Offset: 0x00099A04
		internal void gre(BaseEventData a)
		{
			this.kgp();
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x0009B804 File Offset: 0x00099A04
		internal void gcp()
		{
			this.kgp();
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x0009B804 File Offset: 0x00099A04
		internal void htz()
		{
			this.kgp();
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x0009B804 File Offset: 0x00099A04
		internal void dkr()
		{
			this.kgp();
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x0009B804 File Offset: 0x00099A04
		internal void grd()
		{
			this.kgp();
		}

		// Token: 0x0400120C RID: 4620
		public Action kgp;
	}
}
