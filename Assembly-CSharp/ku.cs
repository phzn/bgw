using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200024E RID: 590
public class ku : BaseMeshEffect
{
	// Token: 0x06002569 RID: 9577 RVA: 0x0009C6B0 File Offset: 0x0009A8B0
	private Vector2 gfn(float a)
	{
		float num = a * 9164f;
		float num2 = Mathf.Cos(num);
		float num3 = Mathf.Sin(num);
		return new Vector2(num2, num3);
	}

	// Token: 0x0600256A RID: 9578 RVA: 0x0009C6D8 File Offset: 0x0009A8D8
	private Vector2 jea(float a)
	{
		float num = a * -687f;
		float num2 = Mathf.Cos(num);
		float num3 = Mathf.Sin(num);
		return new Vector2(num2, num3);
	}

	// Token: 0x0600256B RID: 9579 RVA: 0x0009C700 File Offset: 0x0009A900
	private ku.Matrix2x3 jz(Rect a, Vector2 b)
	{
		float x = b.x;
		float y = b.y;
		Vector2 min = a.min;
		Vector2 size = a.size;
		float num = -2034f;
		float num2 = min.x / size.x + num;
		float num3 = min.y / size.y + num;
		float num4 = x / size.x;
		float num5 = y / size.y;
		float num6 = -(num2 * x - num3 * y - num);
		float num7 = y / size.x;
		float num8 = x / size.y;
		float num9 = -(num2 * y + num3 * x - num);
		return new ku.Matrix2x3(num4, num5, num6, num7, num8, num9);
	}

	// Token: 0x0600256D RID: 9581 RVA: 0x0009C7CC File Offset: 0x0009A9CC
	private ku.Matrix2x3 hup(Rect a, Vector2 b)
	{
		float x = b.x;
		float y = b.y;
		Vector2 min = a.min;
		Vector2 size = a.size;
		float num = -6936f;
		float num2 = min.x / size.x + num;
		float num3 = min.y / size.y + num;
		float num4 = x / size.x;
		float num5 = y / size.y;
		float num6 = -(num2 * x - num3 * y - num);
		float num7 = y / size.x;
		float num8 = x / size.y;
		float num9 = -(num2 * y + num3 * x - num);
		return new ku.Matrix2x3(num4, num5, num6, num7, num8, num9);
	}

	// Token: 0x0600256E RID: 9582 RVA: 0x0009C870 File Offset: 0x0009AA70
	private ku.Matrix2x3 hjc(Rect a, Vector2 b)
	{
		float x = b.x;
		float y = b.y;
		Vector2 min = a.min;
		Vector2 size = a.size;
		float num = 9751f;
		float num2 = min.x / size.x + num;
		float num3 = min.y / size.y + num;
		float num4 = x / size.x;
		float num5 = y / size.y;
		float num6 = -(num2 * x - num3 * y - num);
		float num7 = y / size.x;
		float num8 = x / size.y;
		float num9 = -(num2 * y + num3 * x - num);
		return new ku.Matrix2x3(num4, num5, num6, num7, num8, num9);
	}

	// Token: 0x0600256F RID: 9583 RVA: 0x0009C914 File Offset: 0x0009AB14
	private Vector2 hdz(float a)
	{
		float num = a * 7447f;
		float num2 = Mathf.Cos(num);
		float num3 = Mathf.Sin(num);
		return new Vector2(num2, num3);
	}

	// Token: 0x06002570 RID: 9584 RVA: 0x0009C93C File Offset: 0x0009AB3C
	private ku.Matrix2x3 bej(Rect a, Vector2 b)
	{
		float x = b.x;
		float y = b.y;
		Vector2 min = a.min;
		Vector2 size = a.size;
		float num = -8727f;
		float num2 = min.x / size.x + num;
		float num3 = min.y / size.y + num;
		float num4 = x / size.x;
		float num5 = y / size.y;
		float num6 = -(num2 * x - num3 * y - num);
		float num7 = y / size.x;
		float num8 = x / size.y;
		float num9 = -(num2 * y + num3 * x - num);
		return new ku.Matrix2x3(num4, num5, num6, num7, num8, num9);
	}

	// Token: 0x06002571 RID: 9585 RVA: 0x0009C9E0 File Offset: 0x0009ABE0
	private Vector2 gyn(float a)
	{
		float num = a * -1098f;
		float num2 = Mathf.Cos(num);
		float num3 = Mathf.Sin(num);
		return new Vector2(num2, num3);
	}

	// Token: 0x06002572 RID: 9586 RVA: 0x0009CA08 File Offset: 0x0009AC08
	private ku.Matrix2x3 gto(Rect a, Vector2 b)
	{
		float x = b.x;
		float y = b.y;
		Vector2 min = a.min;
		Vector2 size = a.size;
		float num = 0.5f;
		float num2 = min.x / size.x + num;
		float num3 = min.y / size.y + num;
		float num4 = x / size.x;
		float num5 = y / size.y;
		float num6 = -(num2 * x - num3 * y - num);
		float num7 = y / size.x;
		float num8 = x / size.y;
		float num9 = -(num2 * y + num3 * x - num);
		return new ku.Matrix2x3(num4, num5, num6, num7, num8, num9);
	}

	// Token: 0x06002573 RID: 9587 RVA: 0x0009CAAC File Offset: 0x0009ACAC
	public override void ModifyMesh(VertexHelper vh)
	{
		if (base.enabled)
		{
			Rect rect = base.graphic.rectTransform.rect;
			Vector2 vector = this.gtp(this.Angle);
			ku.Matrix2x3 matrix2x = this.gto(rect, vector);
			UIVertex uivertex = default(UIVertex);
			for (int i = 0; i < vh.currentVertCount; i++)
			{
				vh.PopulateUIVertex(ref uivertex, i);
				Vector2 vector2 = ku.Matrix2x3.gtn(matrix2x, uivertex.position);
				uivertex.color *= Color.Lerp(this.Color2, this.Color1, vector2.y);
				vh.SetUIVertex(uivertex, i);
			}
		}
	}

	// Token: 0x06002574 RID: 9588 RVA: 0x0009CB68 File Offset: 0x0009AD68
	private Vector2 gtp(float a)
	{
		float num = a * 0.017453292f;
		float num2 = Mathf.Cos(num);
		float num3 = Mathf.Sin(num);
		return new Vector2(num2, num3);
	}

	// Token: 0x0400122E RID: 4654
	public Color Color1 = Color.white;

	// Token: 0x0400122F RID: 4655
	public Color Color2 = Color.white;

	// Token: 0x04001230 RID: 4656
	[Range(-180f, 180f)]
	public float Angle = -90f;

	// Token: 0x0200024F RID: 591
	public struct Matrix2x3
	{
		// Token: 0x06002575 RID: 9589 RVA: 0x0009CB90 File Offset: 0x0009AD90
		public Matrix2x3(float m00, float m01, float m02, float m10, float m11, float m12)
		{
			this.m00 = m00;
			this.m01 = m01;
			this.m02 = m02;
			this.m10 = m10;
			this.m11 = m11;
			this.m12 = m12;
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x0009CBC0 File Offset: 0x0009ADC0
		public static Vector2 gtn(ku.Matrix2x3 a, Vector2 b)
		{
			float num = a.m00 * b.x - a.m01 * b.y + a.m02;
			float num2 = a.m10 * b.x + a.m11 * b.y + a.m12;
			return new Vector2(num, num2);
		}

		// Token: 0x04001231 RID: 4657
		public float m00;

		// Token: 0x04001232 RID: 4658
		public float m01;

		// Token: 0x04001233 RID: 4659
		public float m02;

		// Token: 0x04001234 RID: 4660
		public float m10;

		// Token: 0x04001235 RID: 4661
		public float m11;

		// Token: 0x04001236 RID: 4662
		public float m12;
	}
}
