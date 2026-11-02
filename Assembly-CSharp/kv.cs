using System;
using System.Collections.Generic;
using Ricimi;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000250 RID: 592
public class kv : ky
{
	// Token: 0x06002577 RID: 9591 RVA: 0x0009CC18 File Offset: 0x0009AE18
	public void gtq(kw a)
	{
		this.gtr(this.Title, a.Title);
		this.gtr(this.Subtitle, a.Subtitle);
		this.gtr(this.Message, a.Message);
		this.gts(this.Image, a.Image, a.TintColor);
		this.gtr(this.Caption, a.Caption);
		foreach (Button button in this.Buttons)
		{
			button.gameObject.SetActive(false);
		}
		if (a.Buttons.Count == 0)
		{
			this.ButtonGroup.SetActive(false);
			return;
		}
		for (int i = 0; i < a.Buttons.Count; i++)
		{
			this.gtt(this.Buttons[i], a.Buttons[i]);
		}
	}

	// Token: 0x06002578 RID: 9592 RVA: 0x0009CD1C File Offset: 0x0009AF1C
	private void jlq(Image a, Sprite b, Color32 c)
	{
		if (a == null)
		{
			return;
		}
		if (b != null)
		{
			a.sprite = b;
			a.color = c;
			return;
		}
		a.gameObject.SetActive(false);
	}

	// Token: 0x06002579 RID: 9593 RVA: 0x0009CD54 File Offset: 0x0009AF54
	private void gtt(Button a, ButtonInfo b)
	{
		if (a == null)
		{
			return;
		}
		a.gameObject.SetActive(true);
		TextMeshProUGUI componentInChildren = a.GetComponentInChildren<TextMeshProUGUI>();
		if (componentInChildren != null)
		{
			componentInChildren.text = b.Label;
		}
		if (!b.IgnoreButtonClickedEvent)
		{
			a.onClick = b.OnClickedEvent;
		}
		if (b.ClosePopupWhenClicked)
		{
			a.onClick.AddListener(new UnityAction(base.Close));
		}
	}

	// Token: 0x0600257A RID: 9594 RVA: 0x0009CDC6 File Offset: 0x0009AFC6
	private void dlv(TextMeshProUGUI a, string b)
	{
		if (a == null)
		{
			return;
		}
		if (!string.IsNullOrEmpty(b))
		{
			a.text = b;
			return;
		}
		a.gameObject.SetActive(false);
	}

	// Token: 0x0600257B RID: 9595 RVA: 0x0009CD1C File Offset: 0x0009AF1C
	private void mwv(Image a, Sprite b, Color32 c)
	{
		if (a == null)
		{
			return;
		}
		if (b != null)
		{
			a.sprite = b;
			a.color = c;
			return;
		}
		a.gameObject.SetActive(false);
	}

	// Token: 0x0600257C RID: 9596 RVA: 0x0009CDF0 File Offset: 0x0009AFF0
	private void ope(Button a, ButtonInfo b)
	{
		if (a == null)
		{
			return;
		}
		a.gameObject.SetActive(true);
		TextMeshProUGUI componentInChildren = a.GetComponentInChildren<TextMeshProUGUI>();
		if (componentInChildren != null)
		{
			componentInChildren.text = b.Label;
		}
		if (!b.IgnoreButtonClickedEvent)
		{
			a.onClick = b.OnClickedEvent;
		}
		if (b.ClosePopupWhenClicked)
		{
			a.onClick.AddListener(new UnityAction(base.Close));
		}
	}

	// Token: 0x0600257D RID: 9597 RVA: 0x0009CD1C File Offset: 0x0009AF1C
	private void lvs(Image a, Sprite b, Color32 c)
	{
		if (a == null)
		{
			return;
		}
		if (b != null)
		{
			a.sprite = b;
			a.color = c;
			return;
		}
		a.gameObject.SetActive(false);
	}

	// Token: 0x0600257E RID: 9598 RVA: 0x0009CDC6 File Offset: 0x0009AFC6
	private void dzj(TextMeshProUGUI a, string b)
	{
		if (a == null)
		{
			return;
		}
		if (!string.IsNullOrEmpty(b))
		{
			a.text = b;
			return;
		}
		a.gameObject.SetActive(false);
	}

	// Token: 0x0600257F RID: 9599 RVA: 0x0009CD1C File Offset: 0x0009AF1C
	private void ggj(Image a, Sprite b, Color32 c)
	{
		if (a == null)
		{
			return;
		}
		if (b != null)
		{
			a.sprite = b;
			a.color = c;
			return;
		}
		a.gameObject.SetActive(false);
	}

	// Token: 0x06002580 RID: 9600 RVA: 0x0009CE64 File Offset: 0x0009B064
	private void bpn(Button a, ButtonInfo b)
	{
		if (a == null)
		{
			return;
		}
		a.gameObject.SetActive(true);
		TextMeshProUGUI componentInChildren = a.GetComponentInChildren<TextMeshProUGUI>();
		if (componentInChildren != null)
		{
			componentInChildren.text = b.Label;
		}
		if (!b.IgnoreButtonClickedEvent)
		{
			a.onClick = b.OnClickedEvent;
		}
		if (b.ClosePopupWhenClicked)
		{
			a.onClick.AddListener(new UnityAction(base.Close));
		}
	}

	// Token: 0x06002581 RID: 9601 RVA: 0x0009CDC6 File Offset: 0x0009AFC6
	private void njp(TextMeshProUGUI a, string b)
	{
		if (a == null)
		{
			return;
		}
		if (!string.IsNullOrEmpty(b))
		{
			a.text = b;
			return;
		}
		a.gameObject.SetActive(false);
	}

	// Token: 0x06002583 RID: 9603 RVA: 0x0009CEE0 File Offset: 0x0009B0E0
	private void hde(Button a, ButtonInfo b)
	{
		if (a == null)
		{
			return;
		}
		a.gameObject.SetActive(true);
		TextMeshProUGUI componentInChildren = a.GetComponentInChildren<TextMeshProUGUI>();
		if (componentInChildren != null)
		{
			componentInChildren.text = b.Label;
		}
		if (!b.IgnoreButtonClickedEvent)
		{
			a.onClick = b.OnClickedEvent;
		}
		if (b.ClosePopupWhenClicked)
		{
			a.onClick.AddListener(new UnityAction(base.Close));
		}
	}

	// Token: 0x06002584 RID: 9604 RVA: 0x0009CD1C File Offset: 0x0009AF1C
	private void gts(Image a, Sprite b, Color32 c)
	{
		if (a == null)
		{
			return;
		}
		if (b != null)
		{
			a.sprite = b;
			a.color = c;
			return;
		}
		a.gameObject.SetActive(false);
	}

	// Token: 0x06002585 RID: 9605 RVA: 0x0009CDC6 File Offset: 0x0009AFC6
	private void gtr(TextMeshProUGUI a, string b)
	{
		if (a == null)
		{
			return;
		}
		if (!string.IsNullOrEmpty(b))
		{
			a.text = b;
			return;
		}
		a.gameObject.SetActive(false);
	}

	// Token: 0x04001237 RID: 4663
	public TextMeshProUGUI Title;

	// Token: 0x04001238 RID: 4664
	public TextMeshProUGUI Subtitle;

	// Token: 0x04001239 RID: 4665
	public TextMeshProUGUI Message;

	// Token: 0x0400123A RID: 4666
	[Space]
	public Image Image;

	// Token: 0x0400123B RID: 4667
	public TextMeshProUGUI Caption;

	// Token: 0x0400123C RID: 4668
	[Space]
	public GameObject ButtonGroup;

	// Token: 0x0400123D RID: 4669
	public List<Button> Buttons;
}
