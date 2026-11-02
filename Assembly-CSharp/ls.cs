using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x0200026A RID: 618
public class ls : MonoBehaviour
{
	// Token: 0x060026B1 RID: 9905 RVA: 0x000A2DD2 File Offset: 0x000A0FD2
	public static float gxr(float a, float b, float c)
	{
		if (a < -b)
		{
			a = -(-a % 360f);
		}
		if (a > c)
		{
			a %= 360f;
		}
		return Mathf.Clamp(a, b, c);
	}

	// Token: 0x060026B2 RID: 9906 RVA: 0x000A2E00 File Offset: 0x000A1000
	internal void irt()
	{
		Quaternion quaternion = Quaternion.Euler(this.kju);
		base.transform.rotation = quaternion;
		base.transform.position = this.centerTransform.position + this.kjv;
		base.transform.localScale = this.kka * Mathf.Pow(-1792f, this.kkb);
	}

	// Token: 0x060026B3 RID: 9907 RVA: 0x000A2E6C File Offset: 0x000A106C
	internal virtual void gxp()
	{
		Vector3 vector = lr.mgy;
		if (lr.gxj(0))
		{
			if (this.kjx == ls.DragState.None && this.gxq(vector))
			{
				this.kjx = ls.DragState.Translating;
				if (this.confineTranslation)
				{
					Vector3 vector2 = new Vector3((float)Screen.width, (float)Screen.height);
					vector = Vector3.Max(Vector3.Min(vector, vector2), Vector3.zero);
				}
				this.kjw = vector;
			}
		}
		else if (lr.gxj(1) && this.kjx == ls.DragState.None && this.gxq(vector))
		{
			this.kjx = ls.DragState.Rotating;
			this.kjw = vector;
		}
		if (this.kjx == ls.DragState.Rotating)
		{
			if (lr.gxi(1))
			{
				if ((this.axes & ls.RotationAxes.Yaw) > ls.RotationAxes.None)
				{
					this.kju.y = this.kju.y - (vector.x - this.kjw.x) * 360f / (float)Screen.width * this.yawSensitivity;
					this.kju.y = ls.gxr(this.kju.y, this.minimumAngles.y, this.maximumAngles.y);
				}
				if ((this.axes & ls.RotationAxes.Pitch) > ls.RotationAxes.None)
				{
					this.kju.x = this.kju.x + (vector.y - this.kjw.y) * 360f / (float)Screen.height * this.pitchSensitvity;
					this.kju.x = ls.gxr(this.kju.x, this.minimumAngles.x, this.maximumAngles.x);
				}
				this.gxo();
			}
			else
			{
				this.kjx = ls.DragState.None;
			}
		}
		if (this.kjx == ls.DragState.Translating)
		{
			if (lr.gxi(0))
			{
				if (this.confineTranslation)
				{
					Vector3 vector3 = new Vector3((float)Screen.width, (float)Screen.height);
					vector = Vector3.Max(Vector3.Min(vector, vector3), Vector3.zero);
				}
				Vector3 vector4 = this.currentCamera.WorldToScreenPoint(base.transform.position);
				Vector3 vector5 = vector - this.kjw;
				vector5.z = 0f;
				Vector3 vector6 = this.currentCamera.ScreenToWorldPoint(vector4 + vector5);
				this.kjv = vector6 - this.centerTransform.position;
				this.gxo();
			}
			else
			{
				this.kjx = ls.DragState.None;
			}
		}
		if (!Mathf.Approximately(Input.GetAxis(a.fip()), 0f) && this.gxq(vector))
		{
			float num = Input.GetAxis(a.fip()) * this.scaleSensitivity;
			this.kkb -= num;
			this.kkb = Mathf.Clamp(this.kkb, -1f, 2f);
			this.gxo();
		}
		this.kjw = vector;
	}

	// Token: 0x060026B4 RID: 9908 RVA: 0x000A3120 File Offset: 0x000A1320
	internal void gxl()
	{
		if (!this.centerTransform)
		{
			this.centerTransform = base.transform.parent;
			if (!this.centerTransform || this.centerTransform == base.transform)
			{
				this.kjt = new GameObject();
				this.centerTransform = this.kjt.transform;
				this.centerTransform.position = Vector3.zero;
			}
		}
		if (!this.currentCamera)
		{
			this.currentCamera = Camera.main;
		}
		this.kjw = lr.mgy;
	}

	// Token: 0x060026B6 RID: 9910 RVA: 0x000A3228 File Offset: 0x000A1428
	public void gxn()
	{
		this.kju = this.kjz.eulerAngles;
		this.kjv = this.kjy;
		this.kkb = 0f;
		this.gxo();
	}

	// Token: 0x060026B7 RID: 9911 RVA: 0x000A3258 File Offset: 0x000A1458
	internal void geu()
	{
		if (!this.centerTransform)
		{
			this.centerTransform = base.transform.parent;
			if (!this.centerTransform || this.centerTransform == base.transform)
			{
				this.kjt = new GameObject();
				this.centerTransform = this.kjt.transform;
				this.centerTransform.position = Vector3.zero;
			}
		}
		if (!this.currentCamera)
		{
			this.currentCamera = Camera.main;
		}
		this.kjw = lr.mgy;
	}

	// Token: 0x060026B8 RID: 9912 RVA: 0x000A32F2 File Offset: 0x000A14F2
	private void hdr()
	{
		if (!this.currentCamera.isActiveAndEnabled)
		{
			return;
		}
		this.gxp();
	}

	// Token: 0x060026B9 RID: 9913 RVA: 0x000A3308 File Offset: 0x000A1508
	internal bool ekr(Vector3 a)
	{
		RaycastHit raycastHit;
		return Physics.Raycast(this.currentCamera.ScreenPointToRay(a), out raycastHit) && raycastHit.transform.IsChildOf(base.transform);
	}

	// Token: 0x060026BA RID: 9914 RVA: 0x000A3341 File Offset: 0x000A1541
	private void OnDestroy()
	{
		if (this.kjt)
		{
			global::UnityEngine.Object.Destroy(this.kjt);
		}
	}

	// Token: 0x060026BB RID: 9915 RVA: 0x000A32F2 File Offset: 0x000A14F2
	private void gyr()
	{
		if (!this.currentCamera.isActiveAndEnabled)
		{
			return;
		}
		this.gxp();
	}

	// Token: 0x060026BC RID: 9916 RVA: 0x000A335C File Offset: 0x000A155C
	internal bool gxq(Vector3 a)
	{
		RaycastHit raycastHit;
		return Physics.Raycast(this.currentCamera.ScreenPointToRay(a), out raycastHit) && raycastHit.transform.IsChildOf(base.transform);
	}

	// Token: 0x060026BD RID: 9917 RVA: 0x000A3398 File Offset: 0x000A1598
	internal void lry()
	{
		Quaternion quaternion = Quaternion.Euler(this.kju);
		base.transform.rotation = quaternion;
		base.transform.position = this.centerTransform.position + this.kjv;
		base.transform.localScale = this.kka * Mathf.Pow(-8052f, this.kkb);
	}

	// Token: 0x060026BE RID: 9918 RVA: 0x000A3404 File Offset: 0x000A1604
	internal void gxm()
	{
		this.kjy = base.transform.position - this.centerTransform.position;
		this.kjz = base.transform.rotation * Quaternion.Inverse(this.centerTransform.rotation);
		this.kka = base.transform.localScale;
		this.gxn();
	}

	// Token: 0x060026BF RID: 9919 RVA: 0x000A346F File Offset: 0x000A166F
	private void Start()
	{
		this.gxl();
		this.gxm();
	}

	// Token: 0x060026C0 RID: 9920 RVA: 0x000A3480 File Offset: 0x000A1680
	internal void fqr()
	{
		Quaternion quaternion = Quaternion.Euler(this.kju);
		base.transform.rotation = quaternion;
		base.transform.position = this.centerTransform.position + this.kjv;
		base.transform.localScale = this.kka * Mathf.Pow(-5190f, this.kkb);
	}

	// Token: 0x060026C1 RID: 9921 RVA: 0x000A32F2 File Offset: 0x000A14F2
	private void iym()
	{
		if (!this.currentCamera.isActiveAndEnabled)
		{
			return;
		}
		this.gxp();
	}

	// Token: 0x060026C2 RID: 9922 RVA: 0x000A32F2 File Offset: 0x000A14F2
	private void Update()
	{
		if (!this.currentCamera.isActiveAndEnabled)
		{
			return;
		}
		this.gxp();
	}

	// Token: 0x060026C3 RID: 9923 RVA: 0x000A346F File Offset: 0x000A166F
	private void ncb()
	{
		this.gxl();
		this.gxm();
	}

	// Token: 0x060026C4 RID: 9924 RVA: 0x000A34EC File Offset: 0x000A16EC
	internal void gyh()
	{
		this.kjy = base.transform.position - this.centerTransform.position;
		this.kjz = base.transform.rotation * Quaternion.Inverse(this.centerTransform.rotation);
		this.kka = base.transform.localScale;
		this.gxn();
	}

	// Token: 0x060026C5 RID: 9925 RVA: 0x000A3558 File Offset: 0x000A1758
	internal void nj()
	{
		this.kjy = base.transform.position - this.centerTransform.position;
		this.kjz = base.transform.rotation * Quaternion.Inverse(this.centerTransform.rotation);
		this.kka = base.transform.localScale;
		this.gxn();
	}

	// Token: 0x060026C6 RID: 9926 RVA: 0x000A35C4 File Offset: 0x000A17C4
	internal void bgj()
	{
		if (!this.centerTransform)
		{
			this.centerTransform = base.transform.parent;
			if (!this.centerTransform || this.centerTransform == base.transform)
			{
				this.kjt = new GameObject();
				this.centerTransform = this.kjt.transform;
				this.centerTransform.position = Vector3.zero;
			}
		}
		if (!this.currentCamera)
		{
			this.currentCamera = Camera.main;
		}
		this.kjw = lr.mgy;
	}

	// Token: 0x060026C7 RID: 9927 RVA: 0x000A3660 File Offset: 0x000A1860
	internal void htr()
	{
		if (!this.centerTransform)
		{
			this.centerTransform = base.transform.parent;
			if (!this.centerTransform || this.centerTransform == base.transform)
			{
				this.kjt = new GameObject();
				this.centerTransform = this.kjt.transform;
				this.centerTransform.position = Vector3.zero;
			}
		}
		if (!this.currentCamera)
		{
			this.currentCamera = Camera.main;
		}
		this.kjw = lr.mgy;
	}

	// Token: 0x060026C8 RID: 9928 RVA: 0x000A36FC File Offset: 0x000A18FC
	internal void gmy()
	{
		Quaternion quaternion = Quaternion.Euler(this.kju);
		base.transform.rotation = quaternion;
		base.transform.position = this.centerTransform.position + this.kjv;
		base.transform.localScale = this.kka * Mathf.Pow(-5726f, this.kkb);
	}

	// Token: 0x060026C9 RID: 9929 RVA: 0x000A3768 File Offset: 0x000A1968
	internal void gxo()
	{
		Quaternion quaternion = Quaternion.Euler(this.kju);
		base.transform.rotation = quaternion;
		base.transform.position = this.centerTransform.position + this.kjv;
		base.transform.localScale = this.kka * Mathf.Pow(10f, this.kkb);
	}

	// Token: 0x060026CA RID: 9930 RVA: 0x000A37D4 File Offset: 0x000A19D4
	internal bool wt(Vector3 a)
	{
		RaycastHit raycastHit;
		return Physics.Raycast(this.currentCamera.ScreenPointToRay(a), out raycastHit) && raycastHit.transform.IsChildOf(base.transform);
	}

	// Token: 0x060026CB RID: 9931 RVA: 0x000A3810 File Offset: 0x000A1A10
	internal bool lfh(Vector3 a)
	{
		RaycastHit raycastHit;
		return Physics.Raycast(this.currentCamera.ScreenPointToRay(a), out raycastHit) && raycastHit.transform.IsChildOf(base.transform);
	}

	// Token: 0x060026CC RID: 9932 RVA: 0x000A384C File Offset: 0x000A1A4C
	internal void mac()
	{
		if (!this.centerTransform)
		{
			this.centerTransform = base.transform.parent;
			if (!this.centerTransform || this.centerTransform == base.transform)
			{
				this.kjt = new GameObject();
				this.centerTransform = this.kjt.transform;
				this.centerTransform.position = Vector3.zero;
			}
		}
		if (!this.currentCamera)
		{
			this.currentCamera = Camera.main;
		}
		this.kjw = lr.mgy;
	}

	// Token: 0x040012BD RID: 4797
	public ls.RotationAxes axes = ls.RotationAxes.PitchAndYaw;

	// Token: 0x040012BE RID: 4798
	public float yawSensitivity = 1f;

	// Token: 0x040012BF RID: 4799
	public float pitchSensitvity = 1f;

	// Token: 0x040012C0 RID: 4800
	public float scaleSensitivity = 0.5f;

	// Token: 0x040012C1 RID: 4801
	public Vector2 minimumAngles = new Vector2(-90f, -360f);

	// Token: 0x040012C2 RID: 4802
	public Vector2 maximumAngles = new Vector2(90f, 360f);

	// Token: 0x040012C3 RID: 4803
	public bool confineTranslation = true;

	// Token: 0x040012C4 RID: 4804
	public Transform centerTransform;

	// Token: 0x040012C5 RID: 4805
	public Camera currentCamera;

	// Token: 0x040012C6 RID: 4806
	internal GameObject kjt;

	// Token: 0x040012C7 RID: 4807
	internal Vector3 kju;

	// Token: 0x040012C8 RID: 4808
	internal Vector3 kjv;

	// Token: 0x040012C9 RID: 4809
	internal Vector3 kjw;

	// Token: 0x040012CA RID: 4810
	internal ls.DragState kjx;

	// Token: 0x040012CB RID: 4811
	internal Vector3 kjy;

	// Token: 0x040012CC RID: 4812
	internal Quaternion kjz;

	// Token: 0x040012CD RID: 4813
	internal Vector3 kka;

	// Token: 0x040012CE RID: 4814
	internal float kkb;

	// Token: 0x0200026B RID: 619
	[Flags]
	public enum RotationAxes
	{
		// Token: 0x040012D0 RID: 4816
		None = 0,
		// Token: 0x040012D1 RID: 4817
		Pitch = 1,
		// Token: 0x040012D2 RID: 4818
		Yaw = 2,
		// Token: 0x040012D3 RID: 4819
		PitchAndYaw = 3
	}

	// Token: 0x0200026C RID: 620
	[Flags]
	public enum DragState
	{
		// Token: 0x040012D5 RID: 4821
		None = 0,
		// Token: 0x040012D6 RID: 4822
		Rotating = 1,
		// Token: 0x040012D7 RID: 4823
		Translating = 2
	}
}
