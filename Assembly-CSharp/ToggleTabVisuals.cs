using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000086 RID: 134
public sealed class ToggleTabVisuals : MonoBehaviour
{
	// Token: 0x060005CC RID: 1484 RVA: 0x00020358 File Offset: 0x0001E558
	private void Awake()
	{
		if (this.items == null)
		{
			return;
		}
		for (int i = 0; i < this.items.Length; i++)
		{
			ToggleTabVisuals.cq cq = new ToggleTabVisuals.cq();
			cq.htr = this.items[i];
			if (cq.htr.toggle != null)
			{
				cq.htr.toggle.onValueChanged.AddListener(new UnityAction<bool>(cq.bnr));
			}
		}
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x000203CD File Offset: 0x0001E5CD
	private void OnEnable()
	{
		this.bns();
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x000203D8 File Offset: 0x0001E5D8
	public void bns()
	{
		if (this.items == null)
		{
			return;
		}
		for (int i = 0; i < this.items.Length; i++)
		{
			ToggleTabVisuals.bnt(this.items[i], this.items[i].toggle != null && this.items[i].toggle.isOn);
		}
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x00020444 File Offset: 0x0001E644
	private static void bnt(ToggleTabVisuals.Item a, bool b)
	{
		if (a.onGraphic != null)
		{
			a.onGraphic.SetActive(b);
		}
		if (a.offGraphic != null)
		{
			a.offGraphic.SetActive(!b);
		}
	}

	// Token: 0x04000604 RID: 1540
	[SerializeField]
	private ToggleTabVisuals.Item[] items;

	// Token: 0x02000087 RID: 135
	[Serializable]
	public struct Item
	{
		// Token: 0x04000605 RID: 1541
		public Toggle toggle;

		// Token: 0x04000606 RID: 1542
		public GameObject onGraphic;

		// Token: 0x04000607 RID: 1543
		public GameObject offGraphic;
	}

	// Token: 0x02000088 RID: 136
	[CompilerGenerated]
	private sealed class cq
	{
		// Token: 0x060005D1 RID: 1489 RVA: 0x0002047D File Offset: 0x0001E67D
		internal void mxl(bool a)
		{
			ToggleTabVisuals.bnt(this.htr, a);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0002047D File Offset: 0x0001E67D
		internal void dfo(bool a)
		{
			ToggleTabVisuals.bnt(this.htr, a);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0002047D File Offset: 0x0001E67D
		internal void bnr(bool a)
		{
			ToggleTabVisuals.bnt(this.htr, a);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0002047D File Offset: 0x0001E67D
		internal void oek(bool a)
		{
			ToggleTabVisuals.bnt(this.htr, a);
		}

		// Token: 0x04000608 RID: 1544
		public ToggleTabVisuals.Item htr;
	}
}
