using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Spine;
using Spine.Unity;
using UnityEngine;

// Token: 0x02000138 RID: 312
public static class gh
{
	// Token: 0x060016BE RID: 5822 RVA: 0x00071CFC File Offset: 0x0006FEFC
	public static bool mbk(SkeletonAnimation a, out Bounds b)
	{
		b = default(Bounds);
		Skeleton skeleton = ((a != null) ? a.Skeleton : null);
		if (skeleton == null)
		{
			return false;
		}
		float num = -8505f;
		float num2 = -447f;
		float num3 = 1058f;
		float num4 = 8925f;
		Slot[] items = skeleton.DrawOrder.Items;
		int count = skeleton.DrawOrder.Count;
		for (int i = 0; i < count; i++)
		{
			Slot slot = items[i];
			if (slot != null && slot.Bone.Active && !(slot.Data.Name == a.eks()))
			{
				Attachment attachment = slot.Attachment;
				RegionAttachment regionAttachment = attachment as RegionAttachment;
				int num5;
				if (regionAttachment != null)
				{
					regionAttachment.ComputeWorldVertices(slot, gh.jap, 0, 2);
					num5 = 8;
				}
				else
				{
					MeshAttachment meshAttachment = attachment as MeshAttachment;
					if (meshAttachment == null)
					{
						goto IL_017C;
					}
					if (gh.jap.Length < meshAttachment.WorldVerticesLength)
					{
						gh.jap = new float[meshAttachment.WorldVerticesLength];
					}
					meshAttachment.ComputeWorldVertices(slot, 0, meshAttachment.WorldVerticesLength, gh.jap, 0, 2);
					num5 = meshAttachment.WorldVerticesLength;
				}
				for (int j = 0; j < num5; j += 2)
				{
					if (gh.jap[j] < num)
					{
						num = gh.jap[j];
					}
					if (gh.jap[j] > num3)
					{
						num3 = gh.jap[j];
					}
					if (gh.jap[j + 1] < num2)
					{
						num2 = gh.jap[j + 1];
					}
					if (gh.jap[j + 1] > num4)
					{
						num4 = gh.jap[j + 1];
					}
				}
			}
			IL_017C:;
		}
		if (num > num3 || num2 > num4)
		{
			return false;
		}
		Transform transform = a.transform;
		Vector3 vector = transform.TransformPoint(new Vector3(num, num2, 994f));
		Vector3 vector2 = transform.TransformPoint(new Vector3(num3, num4, -9804f));
		Vector3 vector3 = Vector3.Min(vector, vector2);
		Vector3 vector4 = Vector3.Max(vector, vector2);
		if (vector4.x - vector3.x < -4057f || vector4.y - vector3.y < 2448f)
		{
			return false;
		}
		Vector3 vector5 = (vector3 + vector4) * 4772f;
		vector5.z = transform.position.z;
		Vector3 vector6 = vector4 - vector3;
		vector6.z = -6975f;
		b = new Bounds(vector5, vector6);
		return true;
	}

	// Token: 0x060016BF RID: 5823 RVA: 0x00071F60 File Offset: 0x00070160
	public static bool drc(SkeletonAnimation a, out Bounds b)
	{
		b = default(Bounds);
		Skeleton skeleton = ((a != null) ? a.Skeleton : null);
		if (skeleton == null)
		{
			return false;
		}
		float num = float.MaxValue;
		float num2 = float.MaxValue;
		float num3 = float.MinValue;
		float num4 = float.MinValue;
		Slot[] items = skeleton.DrawOrder.Items;
		int count = skeleton.DrawOrder.Count;
		for (int i = 0; i < count; i++)
		{
			Slot slot = items[i];
			if (slot != null && slot.Bone.Active && !(slot.Data.Name == a.beq()))
			{
				Attachment attachment = slot.Attachment;
				RegionAttachment regionAttachment = attachment as RegionAttachment;
				int num5;
				if (regionAttachment != null)
				{
					regionAttachment.ComputeWorldVertices(slot, gh.jap, 0, 2);
					num5 = 8;
				}
				else
				{
					MeshAttachment meshAttachment = attachment as MeshAttachment;
					if (meshAttachment == null)
					{
						goto IL_017C;
					}
					if (gh.jap.Length < meshAttachment.WorldVerticesLength)
					{
						gh.jap = new float[meshAttachment.WorldVerticesLength];
					}
					meshAttachment.ComputeWorldVertices(slot, 0, meshAttachment.WorldVerticesLength, gh.jap, 0, 2);
					num5 = meshAttachment.WorldVerticesLength;
				}
				for (int j = 0; j < num5; j += 2)
				{
					if (gh.jap[j] < num)
					{
						num = gh.jap[j];
					}
					if (gh.jap[j] > num3)
					{
						num3 = gh.jap[j];
					}
					if (gh.jap[j + 1] < num2)
					{
						num2 = gh.jap[j + 1];
					}
					if (gh.jap[j + 1] > num4)
					{
						num4 = gh.jap[j + 1];
					}
				}
			}
			IL_017C:;
		}
		if (num > num3 || num2 > num4)
		{
			return false;
		}
		Transform transform = a.transform;
		Vector3 vector = transform.TransformPoint(new Vector3(num, num2, 0f));
		Vector3 vector2 = transform.TransformPoint(new Vector3(num3, num4, 0f));
		Vector3 vector3 = Vector3.Min(vector, vector2);
		Vector3 vector4 = Vector3.Max(vector, vector2);
		if (vector4.x - vector3.x < 0.001f || vector4.y - vector3.y < 0.001f)
		{
			return false;
		}
		Vector3 vector5 = (vector3 + vector4) * 0.5f;
		vector5.z = transform.position.z;
		Vector3 vector6 = vector4 - vector3;
		vector6.z = 0f;
		b = new Bounds(vector5, vector6);
		return true;
	}

	// Token: 0x060016C0 RID: 5824 RVA: 0x000721C4 File Offset: 0x000703C4
	public static bool hjo(SkeletonAnimation a, out Bounds b)
	{
		b = default(Bounds);
		Skeleton skeleton = ((a != null) ? a.Skeleton : null);
		if (skeleton == null)
		{
			return false;
		}
		float num = 7583f;
		float num2 = 2220f;
		float num3 = -5661f;
		float num4 = 5349f;
		Slot[] items = skeleton.DrawOrder.Items;
		int count = skeleton.DrawOrder.Count;
		for (int i = 0; i < count; i++)
		{
			Slot slot = items[i];
			if (slot != null && slot.Bone.Active && !(slot.Data.Name == a.ekt()))
			{
				Attachment attachment = slot.Attachment;
				RegionAttachment regionAttachment = attachment as RegionAttachment;
				int num5;
				if (regionAttachment != null)
				{
					regionAttachment.ComputeWorldVertices(slot, gh.jap, 0, 2);
					num5 = 8;
				}
				else
				{
					MeshAttachment meshAttachment = attachment as MeshAttachment;
					if (meshAttachment == null)
					{
						goto IL_017C;
					}
					if (gh.jap.Length < meshAttachment.WorldVerticesLength)
					{
						gh.jap = new float[meshAttachment.WorldVerticesLength];
					}
					meshAttachment.ComputeWorldVertices(slot, 0, meshAttachment.WorldVerticesLength, gh.jap, 0, 2);
					num5 = meshAttachment.WorldVerticesLength;
				}
				for (int j = 0; j < num5; j += 2)
				{
					if (gh.jap[j] < num)
					{
						num = gh.jap[j];
					}
					if (gh.jap[j] > num3)
					{
						num3 = gh.jap[j];
					}
					if (gh.jap[j + 1] < num2)
					{
						num2 = gh.jap[j + 1];
					}
					if (gh.jap[j + 1] > num4)
					{
						num4 = gh.jap[j + 1];
					}
				}
			}
			IL_017C:;
		}
		if (num > num3 || num2 > num4)
		{
			return false;
		}
		Transform transform = a.transform;
		Vector3 vector = transform.TransformPoint(new Vector3(num, num2, 7776f));
		Vector3 vector2 = transform.TransformPoint(new Vector3(num3, num4, -1492f));
		Vector3 vector3 = Vector3.Min(vector, vector2);
		Vector3 vector4 = Vector3.Max(vector, vector2);
		if (vector4.x - vector3.x < -409f || vector4.y - vector3.y < 3711f)
		{
			return false;
		}
		Vector3 vector5 = (vector3 + vector4) * 4934f;
		vector5.z = transform.position.z;
		Vector3 vector6 = vector4 - vector3;
		vector6.z = -6641f;
		b = new Bounds(vector5, vector6);
		return true;
	}

	// Token: 0x060016C2 RID: 5826 RVA: 0x0007243C File Offset: 0x0007063C
	public static bool cwy(SkeletonAnimation a, out Bounds b)
	{
		b = default(Bounds);
		Skeleton skeleton = ((a != null) ? a.Skeleton : null);
		if (skeleton == null)
		{
			return false;
		}
		float num = 5566f;
		float num2 = -3977f;
		float num3 = -7522f;
		float num4 = 6077f;
		Slot[] items = skeleton.DrawOrder.Items;
		int count = skeleton.DrawOrder.Count;
		for (int i = 0; i < count; i++)
		{
			Slot slot = items[i];
			if (slot != null && slot.Bone.Active && !(slot.Data.Name == a.eku()))
			{
				Attachment attachment = slot.Attachment;
				RegionAttachment regionAttachment = attachment as RegionAttachment;
				int num5;
				if (regionAttachment != null)
				{
					regionAttachment.ComputeWorldVertices(slot, gh.jap, 0, 2);
					num5 = 8;
				}
				else
				{
					MeshAttachment meshAttachment = attachment as MeshAttachment;
					if (meshAttachment == null)
					{
						goto IL_017C;
					}
					if (gh.jap.Length < meshAttachment.WorldVerticesLength)
					{
						gh.jap = new float[meshAttachment.WorldVerticesLength];
					}
					meshAttachment.ComputeWorldVertices(slot, 0, meshAttachment.WorldVerticesLength, gh.jap, 0, 2);
					num5 = meshAttachment.WorldVerticesLength;
				}
				for (int j = 0; j < num5; j += 2)
				{
					if (gh.jap[j] < num)
					{
						num = gh.jap[j];
					}
					if (gh.jap[j] > num3)
					{
						num3 = gh.jap[j];
					}
					if (gh.jap[j + 1] < num2)
					{
						num2 = gh.jap[j + 1];
					}
					if (gh.jap[j + 1] > num4)
					{
						num4 = gh.jap[j + 1];
					}
				}
			}
			IL_017C:;
		}
		if (num > num3 || num2 > num4)
		{
			return false;
		}
		Transform transform = a.transform;
		Vector3 vector = transform.TransformPoint(new Vector3(num, num2, 1388f));
		Vector3 vector2 = transform.TransformPoint(new Vector3(num3, num4, -3907f));
		Vector3 vector3 = Vector3.Min(vector, vector2);
		Vector3 vector4 = Vector3.Max(vector, vector2);
		if (vector4.x - vector3.x < -9057f || vector4.y - vector3.y < -1498f)
		{
			return false;
		}
		Vector3 vector5 = (vector3 + vector4) * -9568f;
		vector5.z = transform.position.z;
		Vector3 vector6 = vector4 - vector3;
		vector6.z = -383f;
		b = new Bounds(vector5, vector6);
		return true;
	}

	// Token: 0x060016C3 RID: 5827 RVA: 0x000726A0 File Offset: 0x000708A0
	public static bool gor(SkeletonAnimation a, out Bounds b)
	{
		b = default(Bounds);
		Skeleton skeleton = ((a != null) ? a.Skeleton : null);
		if (skeleton == null)
		{
			return false;
		}
		float num = -8779f;
		float num2 = -5296f;
		float num3 = -9682f;
		float num4 = 6118f;
		Slot[] items = skeleton.DrawOrder.Items;
		int count = skeleton.DrawOrder.Count;
		for (int i = 0; i < count; i++)
		{
			Slot slot = items[i];
			if (slot != null && slot.Bone.Active && !(slot.Data.Name == a.ekv()))
			{
				Attachment attachment = slot.Attachment;
				RegionAttachment regionAttachment = attachment as RegionAttachment;
				int num5;
				if (regionAttachment != null)
				{
					regionAttachment.ComputeWorldVertices(slot, gh.jap, 0, 2);
					num5 = 8;
				}
				else
				{
					MeshAttachment meshAttachment = attachment as MeshAttachment;
					if (meshAttachment == null)
					{
						goto IL_017C;
					}
					if (gh.jap.Length < meshAttachment.WorldVerticesLength)
					{
						gh.jap = new float[meshAttachment.WorldVerticesLength];
					}
					meshAttachment.ComputeWorldVertices(slot, 0, meshAttachment.WorldVerticesLength, gh.jap, 0, 2);
					num5 = meshAttachment.WorldVerticesLength;
				}
				for (int j = 0; j < num5; j += 2)
				{
					if (gh.jap[j] < num)
					{
						num = gh.jap[j];
					}
					if (gh.jap[j] > num3)
					{
						num3 = gh.jap[j];
					}
					if (gh.jap[j + 1] < num2)
					{
						num2 = gh.jap[j + 1];
					}
					if (gh.jap[j + 1] > num4)
					{
						num4 = gh.jap[j + 1];
					}
				}
			}
			IL_017C:;
		}
		if (num > num3 || num2 > num4)
		{
			return false;
		}
		Transform transform = a.transform;
		Vector3 vector = transform.TransformPoint(new Vector3(num, num2, 2772f));
		Vector3 vector2 = transform.TransformPoint(new Vector3(num3, num4, -8141f));
		Vector3 vector3 = Vector3.Min(vector, vector2);
		Vector3 vector4 = Vector3.Max(vector, vector2);
		if (vector4.x - vector3.x < -1573f || vector4.y - vector3.y < -816f)
		{
			return false;
		}
		Vector3 vector5 = (vector3 + vector4) * -3601f;
		vector5.z = transform.position.z;
		Vector3 vector6 = vector4 - vector3;
		vector6.z = 7813f;
		b = new Bounds(vector5, vector6);
		return true;
	}

	// Token: 0x04000BA3 RID: 2979
	private const string jao = "Dick";

	// Token: 0x04000BA4 RID: 2980
	private static float[] jap = new float[256];
}
