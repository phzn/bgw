using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Rewired.Utils;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000243 RID: 579
public static class kn
{
	// Token: 0x06002503 RID: 9475 RVA: 0x0009B4AC File Offset: 0x000996AC
	public static Selectable grc(Selectable a, Transform b, Vector3 c)
	{
		RectTransform rectTransform = b as RectTransform;
		if (rectTransform == null)
		{
			return null;
		}
		if (Selectable.allSelectableCount > kn.kgo.Length)
		{
			kn.kgo = new Selectable[Selectable.allSelectableCount];
		}
		int num = Selectable.AllSelectablesNoAlloc(kn.kgo);
		IList<Selectable> list = kn.kgo;
		c.Normalize();
		Vector2 vector = c;
		Vector2 vector2 = kq.grm(rectTransform, vector);
		bool flag = vector == Vector2.right * -1f || vector == Vector2.right;
		float num2 = float.PositiveInfinity;
		float num3 = float.PositiveInfinity;
		Selectable selectable = null;
		Selectable selectable2 = null;
		Vector2 vector3 = vector2 + vector * 999999f;
		for (int i = 0; i < num; i++)
		{
			Selectable selectable3 = list[i];
			if (!(selectable3 == a) && !(selectable3 == null) && selectable3.navigation.mode != Navigation.Mode.None && (selectable3.IsInteractable() || ReflectionTools.GetPrivateField<Selectable, bool>(selectable3, a.eyo())))
			{
				RectTransform rectTransform2 = selectable3.transform as RectTransform;
				if (!(rectTransform2 == null))
				{
					Rect rect = kq.grp(kq.gro(rectTransform2, b, rectTransform2.rect));
					float num4;
					if (MathTools.LineIntersectsRect(vector2, vector3, rect, out num4))
					{
						if (flag)
						{
							num4 *= 0.25f;
						}
						if (num4 < num3)
						{
							num3 = num4;
							selectable2 = selectable3;
						}
					}
					Vector2 vector4 = UnityTools.TransformPoint(rectTransform2, b, rectTransform2.rect.center) - vector2;
					if (Mathf.Abs(Vector2.Angle(vector, vector4)) <= 75f)
					{
						float sqrMagnitude = vector4.sqrMagnitude;
						if (sqrMagnitude < num2)
						{
							num2 = sqrMagnitude;
							selectable = selectable3;
						}
					}
				}
			}
		}
		if (!(selectable2 != null) || !(selectable != null))
		{
			Array.Clear(kn.kgo, 0, kn.kgo.Length);
			return selectable2 ?? selectable;
		}
		if (num3 > num2)
		{
			return selectable;
		}
		return selectable2;
	}

	// Token: 0x04001207 RID: 4615
	private static Selectable[] kgo = new Selectable[0];
}
