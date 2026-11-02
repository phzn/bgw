using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000246 RID: 582
public static class kq
{
	// Token: 0x06002511 RID: 9489 RVA: 0x0009B814 File Offset: 0x00099A14
	public static GameObject grj<a>(GameObject a, Transform b, string c) where a : Component
	{
		GameObject gameObject = kq.grl<a>(a, b, c);
		if (gameObject == null)
		{
			return null;
		}
		RectTransform component = gameObject.GetComponent<RectTransform>();
		if (component == null)
		{
			Debug.LogError(c + a.eyp());
		}
		else
		{
			component.localScale = Vector3.one;
		}
		return gameObject;
	}

	// Token: 0x06002512 RID: 9490 RVA: 0x0009B864 File Offset: 0x00099A64
	public static Vector3 grm(RectTransform a, Vector2 b)
	{
		if (a == null)
		{
			return Vector3.zero;
		}
		if (b != Vector2.zero)
		{
			b /= Mathf.Max(Mathf.Abs(b.x), Mathf.Abs(b.y));
		}
		Rect rect = a.rect;
		b = rect.center + Vector2.Scale(rect.size, b * 0.5f);
		return b;
	}

	// Token: 0x06002513 RID: 9491 RVA: 0x0009B8E8 File Offset: 0x00099AE8
	public static Rect grn(RectTransform a)
	{
		if (a == null)
		{
			return default(Rect);
		}
		Rect rect = a.rect;
		Vector2 vector = a.TransformPoint(new Vector2(rect.xMin, rect.yMin));
		Vector2 vector2 = a.TransformPoint(new Vector2(rect.xMin, rect.yMax));
		Vector2 vector3 = a.TransformPoint(new Vector2(rect.xMax, rect.yMin));
		return new Rect(vector.x, vector.y, vector3.x - vector.x, vector2.y - vector.y);
	}

	// Token: 0x06002514 RID: 9492 RVA: 0x0009B9A7 File Offset: 0x00099BA7
	public static Rect heu(Rect a)
	{
		return new Rect(a.xMin, a.yMin, a.width, -a.height);
	}

	// Token: 0x06002515 RID: 9493 RVA: 0x0009B9CC File Offset: 0x00099BCC
	private static GameObject grl<c>(GameObject a, Transform b, string c) where c : Component
	{
		if (a == null)
		{
			Debug.LogError(c + a.eyq());
			return null;
		}
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(a);
		if (!string.IsNullOrEmpty(c))
		{
			gameObject.name = c;
		}
		c component = gameObject.GetComponent<c>();
		if (component == null)
		{
			Debug.LogError(c + a.eyr() + component.GetType().ToString() + a.eys());
			return null;
		}
		if (b != null)
		{
			gameObject.transform.SetParent(b, false);
		}
		return gameObject;
	}

	// Token: 0x06002516 RID: 9494 RVA: 0x0009BA60 File Offset: 0x00099C60
	public static void grq(Selectable a, bool b, bool c)
	{
		if (a == null)
		{
			return;
		}
		if (c)
		{
			a.interactable = b;
			return;
		}
		if (a.transition == Selectable.Transition.ColorTint)
		{
			ColorBlock colors = a.colors;
			float fadeDuration = colors.fadeDuration;
			colors.fadeDuration = 0f;
			a.colors = colors;
			a.interactable = b;
			colors.fadeDuration = fadeDuration;
			a.colors = colors;
			return;
		}
		a.interactable = b;
	}

	// Token: 0x06002517 RID: 9495 RVA: 0x0009B9A7 File Offset: 0x00099BA7
	public static Rect lha(Rect a)
	{
		return new Rect(a.xMin, a.yMin, a.width, -a.height);
	}

	// Token: 0x06002518 RID: 9496 RVA: 0x0009BACC File Offset: 0x00099CCC
	public static Vector3 jlj(RectTransform a, Vector2 b)
	{
		if (a == null)
		{
			return Vector3.zero;
		}
		if (b != Vector2.zero)
		{
			b /= Mathf.Max(Mathf.Abs(b.x), Mathf.Abs(b.y));
		}
		Rect rect = a.rect;
		b = rect.center + Vector2.Scale(rect.size, b * -3799f);
		return b;
	}

	// Token: 0x06002519 RID: 9497 RVA: 0x0009B9A7 File Offset: 0x00099BA7
	public static Rect bed(Rect a)
	{
		return new Rect(a.xMin, a.yMin, a.width, -a.height);
	}

	// Token: 0x0600251A RID: 9498 RVA: 0x0009BB50 File Offset: 0x00099D50
	public static Vector3 lgz(RectTransform a, Vector2 b)
	{
		if (a == null)
		{
			return Vector3.zero;
		}
		if (b != Vector2.zero)
		{
			b /= Mathf.Max(Mathf.Abs(b.x), Mathf.Abs(b.y));
		}
		Rect rect = a.rect;
		b = rect.center + Vector2.Scale(rect.size, b * 6261f);
		return b;
	}

	// Token: 0x0600251B RID: 9499 RVA: 0x0009BBD4 File Offset: 0x00099DD4
	public static Rect vz(RectTransform a)
	{
		if (a == null)
		{
			return default(Rect);
		}
		Rect rect = a.rect;
		Vector2 vector = a.TransformPoint(new Vector2(rect.xMin, rect.yMin));
		Vector2 vector2 = a.TransformPoint(new Vector2(rect.xMin, rect.yMax));
		Vector2 vector3 = a.TransformPoint(new Vector2(rect.xMax, rect.yMin));
		return new Rect(vector.x, vector.y, vector3.x - vector.x, vector2.y - vector.y);
	}

	// Token: 0x0600251C RID: 9500 RVA: 0x0009BC94 File Offset: 0x00099E94
	public static Rect gro(Transform a, Transform b, Rect c)
	{
		Vector3 vector;
		Vector3 vector2;
		Vector3 vector3;
		if (a != null)
		{
			vector = a.TransformPoint(new Vector2(c.xMin, c.yMin));
			vector2 = a.TransformPoint(new Vector2(c.xMin, c.yMax));
			vector3 = a.TransformPoint(new Vector2(c.xMax, c.yMin));
		}
		else
		{
			vector = new Vector2(c.xMin, c.yMin);
			vector2 = new Vector2(c.xMin, c.yMax);
			vector3 = new Vector2(c.xMax, c.yMin);
		}
		if (b != null)
		{
			vector = b.InverseTransformPoint(vector);
			vector2 = b.InverseTransformPoint(vector2);
			vector3 = b.InverseTransformPoint(vector3);
		}
		return new Rect(vector.x, vector.y, vector3.x - vector.x, vector.y - vector2.y);
	}

	// Token: 0x0600251D RID: 9501 RVA: 0x0009BDA0 File Offset: 0x00099FA0
	public static GameObject grk<b>(GameObject a, Transform b, string c, Vector2 d, Vector2 e, Vector2 f, Vector2 g) where b : Component
	{
		GameObject gameObject = kq.grl<b>(a, b, c);
		if (gameObject == null)
		{
			return null;
		}
		RectTransform component = gameObject.GetComponent<RectTransform>();
		if (component == null)
		{
			Debug.LogError(c + a.eyp());
		}
		else
		{
			component.localScale = Vector3.one;
			component.pivot = d;
			component.anchorMin = e;
			component.anchorMax = f;
			component.anchoredPosition = g;
		}
		return gameObject;
	}

	// Token: 0x0600251E RID: 9502 RVA: 0x0009B9A7 File Offset: 0x00099BA7
	public static Rect iur(Rect a)
	{
		return new Rect(a.xMin, a.yMin, a.width, -a.height);
	}

	// Token: 0x0600251F RID: 9503 RVA: 0x0009B9A7 File Offset: 0x00099BA7
	public static Rect grp(Rect a)
	{
		return new Rect(a.xMin, a.yMin, a.width, -a.height);
	}
}
