using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x02000056 RID: 86
[DefaultExecutionOrder(50)]
public class CharacterDragTarget : MonoBehaviour
{
	// Token: 0x17000071 RID: 113
	// (get) Token: 0x06000496 RID: 1174 RVA: 0x00016C1F File Offset: 0x00014E1F
	public Transform kor
	{
		get
		{
			if (!(this.targetTransform != null))
			{
				return base.transform;
			}
			return this.targetTransform;
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x06000497 RID: 1175 RVA: 0x00016C3C File Offset: 0x00014E3C
	public Vector3 kos
	{
		get
		{
			return this.hqx;
		}
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x06000498 RID: 1176 RVA: 0x00016C44 File Offset: 0x00014E44
	public static CharacterDragTarget kot
	{
		get
		{
			return CharacterDragTarget.hqy;
		}
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x00016C4B File Offset: 0x00014E4B
	private void Awake()
	{
		CharacterDragTarget.hqy = this;
		this.hqx = this.kor.position;
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x00016C64 File Offset: 0x00014E64
	private void Start()
	{
		Vector3 vector;
		if (!ch.bhe(out vector))
		{
			return;
		}
		if (!this.bgz(vector, 0.5f))
		{
			Debug.Log(string.Format(a.wh(), vector, 50f, this.hqx));
			ch.bhf();
			return;
		}
		WindowDragHandler windowDragHandler = global::UnityEngine.Object.FindFirstObjectByType<WindowDragHandler>();
		Vector3 vector2 = ((windowDragHandler != null) ? windowDragHandler.beh(vector) : vector);
		if ((vector2 - vector).sqrMagnitude > 0.0001f)
		{
			Debug.Log(string.Format(a.wi(), vector, vector2, this.hqx));
		}
		else
		{
			Debug.Log(string.Format(a.wj(), vector, this.hqx));
		}
		this.kor.position = vector2;
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00016D3D File Offset: 0x00014F3D
	private void OnDestroy()
	{
		if (CharacterDragTarget.hqy == this)
		{
			CharacterDragTarget.hqy = null;
		}
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x00016D52 File Offset: 0x00014F52
	public void bgy()
	{
		this.kor.position = ((this.defaultPosition != Vector3.zero) ? this.defaultPosition : this.hqx);
		ch.bhf();
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x00016D84 File Offset: 0x00014F84
	public bool bgz(Vector3 a, float b = 0.05f)
	{
		Camera main = Camera.main;
		if (main == null)
		{
			return true;
		}
		Vector3 vector = main.WorldToViewportPoint(a);
		float num = -b - 0.001f;
		float num2 = 1f + b + 0.001f;
		return vector.z > 0f && vector.x >= num && vector.x <= num2 && vector.y >= num && vector.y <= num2;
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00016DF7 File Offset: 0x00014FF7
	public bool bha(float a = 0.05f)
	{
		return this.kor != null && this.bgz(this.kor.position, a);
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x00016E1B File Offset: 0x0001501B
	public void bhb()
	{
		if (!this.bha(0.5f))
		{
			Debug.Log(a.wk());
			this.bgy();
		}
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x00016E3C File Offset: 0x0001503C
	private void bhc()
	{
		if (!Application.isPlaying)
		{
			Debug.LogWarning(a.wl());
			return;
		}
		if (!bq.hmg)
		{
			Debug.LogWarning(a.wm());
			return;
		}
		if (bq.hlf == null || bq.hlf.playerSaveData == null)
		{
			Debug.LogWarning(a.wn());
			return;
		}
		ch.bhf();
		Debug.Log(a.wo());
	}

	// Token: 0x04000273 RID: 627
	[SerializeField]
	private Transform targetTransform;

	// Token: 0x04000274 RID: 628
	public Vector3 defaultPosition = Vector3.zero;

	// Token: 0x04000275 RID: 629
	private Vector3 hqx;

	// Token: 0x04000276 RID: 630
	private static CharacterDragTarget hqy;

	// Token: 0x04000277 RID: 631
	private const float hqz = 0.5f;

	// Token: 0x04000278 RID: 632
	private const float hra = 0.001f;
}
