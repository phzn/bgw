using System;
using System.Collections.Generic;
using Kirurobo;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020000C7 RID: 199
public class LockClickThroughGuard : MonoBehaviour
{
	// Token: 0x06000A68 RID: 2664 RVA: 0x0003CED7 File Offset: 0x0003B0D7
	private void Reset()
	{
		this.windowController = base.GetComponent<UniWindowController>();
	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x0003CEE8 File Offset: 0x0003B0E8
	private void Update()
	{
		if (this.windowController == null)
		{
			return;
		}
		if (!bq.hlu)
		{
			return;
		}
		this.ide = Input.GetMouseButton(0);
		bool flag = !this.chd() && !this.ide;
		if (this.windowController.isClickThrough != flag)
		{
			this.windowController.isClickThrough = flag;
		}
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x0003CF48 File Offset: 0x0003B148
	private void LateUpdate()
	{
		if (this.windowController == null)
		{
			return;
		}
		if (bq.hlu)
		{
			return;
		}
		if (this.windowController.hitTestType != UniWindowController.HitTestType.Opacity)
		{
			return;
		}
		if (Input.GetMouseButton(0) && this.windowController.isClickThrough)
		{
			this.windowController.isClickThrough = false;
		}
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x0003CF9C File Offset: 0x0003B19C
	private bool chd()
	{
		if (this.protectedRects == null || EventSystem.current == null)
		{
			return false;
		}
		if (this.idf == null)
		{
			this.idf = new PointerEventData(EventSystem.current);
		}
		this.idf.position = Input.mousePosition;
		this.idg.Clear();
		EventSystem.current.RaycastAll(this.idf, this.idg);
		for (int i = 0; i < this.idg.Count; i++)
		{
			Transform transform = this.idg[i].gameObject.transform;
			for (int j = 0; j < this.protectedRects.Length; j++)
			{
				RectTransform rectTransform = this.protectedRects[j];
				if (!(rectTransform == null) && rectTransform.gameObject.activeInHierarchy && transform.IsChildOf(rectTransform.transform))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0400083F RID: 2111
	[SerializeField]
	private UniWindowController windowController;

	// Token: 0x04000840 RID: 2112
	[SerializeField]
	private RectTransform[] protectedRects;

	// Token: 0x04000841 RID: 2113
	private bool ide;

	// Token: 0x04000842 RID: 2114
	private PointerEventData idf;

	// Token: 0x04000843 RID: 2115
	private readonly List<RaycastResult> idg = new List<RaycastResult>();
}
