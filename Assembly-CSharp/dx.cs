using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020000C2 RID: 194
public static class dx
{
	// Token: 0x06000A15 RID: 2581 RVA: 0x0003B2EC File Offset: 0x000394EC
	public static bool mdm(RectTransform a, Vector2 b)
	{
		if (a == null || !a.gameObject.activeInHierarchy)
		{
			return false;
		}
		Canvas componentInParent = a.GetComponentInParent<Canvas>();
		Canvas canvas = ((componentInParent != null) ? componentInParent.rootCanvas : null);
		Camera camera = ((canvas != null && canvas.renderMode != RenderMode.ScreenSpaceOverlay) ? canvas.worldCamera : null);
		return RectTransformUtility.RectangleContainsScreenPoint(a, b, camera);
	}

	// Token: 0x06000A17 RID: 2583 RVA: 0x0003B35C File Offset: 0x0003955C
	public static bool cgl(Transform a, Vector2 b)
	{
		EventSystem current = EventSystem.current;
		if (current == null || a == null)
		{
			return false;
		}
		PointerEventData pointerEventData = new PointerEventData(current)
		{
			position = b
		};
		dx.ici.Clear();
		current.RaycastAll(pointerEventData, dx.ici);
		for (int i = 0; i < dx.ici.Count; i++)
		{
			GameObject gameObject = dx.ici[i].gameObject;
			if (!(gameObject == null) && gameObject.transform.IsChildOf(a))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000A18 RID: 2584 RVA: 0x0003B3EC File Offset: 0x000395EC
	public static bool cgm(RectTransform a, Vector2 b)
	{
		if (a == null || !a.gameObject.activeInHierarchy)
		{
			return false;
		}
		Canvas componentInParent = a.GetComponentInParent<Canvas>();
		Canvas canvas = ((componentInParent != null) ? componentInParent.rootCanvas : null);
		Camera camera = ((canvas != null && canvas.renderMode != RenderMode.ScreenSpaceOverlay) ? canvas.worldCamera : null);
		return RectTransformUtility.RectangleContainsScreenPoint(a, b, camera);
	}

	// Token: 0x04000828 RID: 2088
	private static readonly List<RaycastResult> ici = new List<RaycastResult>();
}
