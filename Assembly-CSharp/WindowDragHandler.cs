using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000043 RID: 67
[DefaultExecutionOrder(100)]
public class WindowDragHandler : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	// Token: 0x17000064 RID: 100
	// (get) Token: 0x06000414 RID: 1044 RVA: 0x00014473 File Offset: 0x00012673
	public int kof
	{
		get
		{
			if (!this.hos)
			{
				return this.window10DownOffsetY;
			}
			return this.window11DownOffsetY;
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x06000415 RID: 1045 RVA: 0x0001448A File Offset: 0x0001268A
	// (set) Token: 0x06000416 RID: 1046 RVA: 0x00014491 File Offset: 0x00012691
	public static WindowDragHandler hot { get; private set; }

	// Token: 0x06000417 RID: 1047
	[DllImport("user32.dll")]
	private static extern IntPtr MonitorFromPoint(WindowDragHandler.POINT pt, uint dwFlags);

	// Token: 0x06000418 RID: 1048
	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern bool GetMonitorInfo(IntPtr hMonitor, ref WindowDragHandler.MONITORINFOEX lpmi);

	// Token: 0x06000419 RID: 1049
	[DllImport("user32.dll")]
	private static extern bool GetCursorPos(out WindowDragHandler.POINT lpPoint);

	// Token: 0x0600041A RID: 1050 RVA: 0x0001449C File Offset: 0x0001269C
	private void Awake()
	{
		WindowDragHandler.hot = this;
		if (this.downUI == null)
		{
			this.downUI = base.transform.parent as RectTransform;
		}
		if (this.canvas == null)
		{
			this.canvas = base.GetComponentInParent<Canvas>();
		}
		if (this.canvas != null && this.canvas.rootCanvas != null)
		{
			this.canvas = this.canvas.rootCanvas;
		}
		if (this.canvasRect == null && this.canvas != null)
		{
			this.canvasRect = this.canvas.transform as RectTransform;
		}
		if (this.worldCamera == null)
		{
			this.worldCamera = Camera.main;
		}
		this.bdz();
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x00014570 File Offset: 0x00012770
	private void bdz()
	{
		this.hos = false;
		string operatingSystem = SystemInfo.operatingSystem;
		if (operatingSystem.Contains(a.vi()))
		{
			this.hos = true;
		}
		else
		{
			Match match = Regex.Match(operatingSystem, a.vj());
			int num;
			if (match.Success && int.TryParse(match.Groups[1].Value, out num) && num >= 22000)
			{
				this.hos = true;
			}
		}
		Debug.Log(string.Format(a.vk(), operatingSystem, this.hos));
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x000145F8 File Offset: 0x000127F8
	private void Start()
	{
		if (this.worldCamera == null)
		{
			this.worldCamera = Camera.main;
		}
		CharacterDragTarget characterDragTarget = ((CharacterDragTarget.kot != null) ? CharacterDragTarget.kot : global::UnityEngine.Object.FindFirstObjectByType<CharacterDragTarget>());
		if (this.targetTransform == null && characterDragTarget != null)
		{
			this.targetTransform = characterDragTarget.kor;
		}
		FixedResolutionViewport fixedResolutionViewport = global::UnityEngine.Object.FindFirstObjectByType<FixedResolutionViewport>();
		if (fixedResolutionViewport != null && fixedResolutionViewport.icj > 0f)
		{
			this.referenceFov = fixedResolutionViewport.icj;
		}
		this.bea(characterDragTarget);
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x0001468C File Offset: 0x0001288C
	private void bea(CharacterDragTarget a)
	{
		if (!this.bec() || this.downUI == null)
		{
			return;
		}
		Vector3 vector = ((a != null) ? a.kos : this.targetTransform.position);
		Vector2 anchoredPosition = this.downUI.anchoredPosition;
		Vector2 vector2 = new Vector2(this.referenceCanvasWidth * this.downUI.anchorMin.x + anchoredPosition.x, this.referenceCanvasHeight * this.downUI.anchorMin.y + anchoredPosition.y);
		float num = Mathf.Abs(this.worldCamera.transform.position.z - vector.z);
		if (num < 0.001f)
		{
			num = 0.001f;
		}
		float num2 = this.referenceCanvasHeight / (2f * num * Mathf.Tan(this.referenceFov * 0.5f * 0.017453292f));
		Vector2 vector3 = new Vector2(this.referenceCanvasWidth * 0.5f + (vector.x - this.worldCamera.transform.position.x) * num2, this.referenceCanvasHeight * 0.5f + (vector.y - this.worldCamera.transform.position.y) * num2);
		this.hon = vector2 - vector3;
		this.hoo = true;
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x000147E8 File Offset: 0x000129E8
	public bool beb(out Vector2 a)
	{
		a = this.hon;
		return this.hoo;
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x000147FC File Offset: 0x000129FC
	public void OnBeginDrag(PointerEventData e)
	{
		if (!this.bec())
		{
			return;
		}
		if (this.bed())
		{
			return;
		}
		this.hop = this.targetTransform.position;
		this.hoq = e.position;
		this.hor = true;
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x00014834 File Offset: 0x00012A34
	public void OnDrag(PointerEventData e)
	{
		if (!this.hor || !this.bec())
		{
			return;
		}
		Vector3 vector = this.bef(this.hoq);
		Vector3 vector2 = this.bef(e.position);
		Vector3 vector3 = this.hop + (vector2 - vector);
		this.targetTransform.position = this.beg(vector3);
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x00014891 File Offset: 0x00012A91
	public void OnEndDrag(PointerEventData e)
	{
		if (!this.hor)
		{
			return;
		}
		this.hor = false;
		if (!this.bec())
		{
			return;
		}
		if (this.enableAutoSnap)
		{
			this.bei();
		}
		ch.bhd(this.targetTransform.position);
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x000148CC File Offset: 0x00012ACC
	private void LateUpdate()
	{
		if (!this.hoo || !this.bec() || this.downUI == null)
		{
			return;
		}
		Vector3 vector = this.worldCamera.WorldToScreenPoint(this.targetTransform.position);
		if (vector.z <= 0f)
		{
			return;
		}
		Vector2 vector2 = new Vector2(vector.x, vector.y) + this.hon;
		RectTransform rectTransform = this.downUI.parent as RectTransform;
		if (rectTransform == null)
		{
			return;
		}
		Camera camera = ((this.canvas.renderMode == RenderMode.ScreenSpaceOverlay) ? null : this.canvas.worldCamera);
		Vector2 vector3;
		if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, vector2, camera, out vector3))
		{
			return;
		}
		Vector2 vector4 = new Vector2((this.downUI.anchorMin.x - rectTransform.pivot.x) * rectTransform.rect.width, (this.downUI.anchorMin.y - rectTransform.pivot.y) * rectTransform.rect.height);
		this.downUI.anchoredPosition = vector3 - vector4;
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x000149F1 File Offset: 0x00012BF1
	private bool bec()
	{
		return this.targetTransform != null && this.canvas != null && this.canvasRect != null && this.worldCamera != null;
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x00014A2B File Offset: 0x00012C2B
	private bool bed()
	{
		return bq.hlu;
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x00014A34 File Offset: 0x00012C34
	private Vector2 bee(Vector3 a)
	{
		Vector3 vector = this.worldCamera.WorldToScreenPoint(a);
		Camera camera = ((this.canvas.renderMode == RenderMode.ScreenSpaceOverlay) ? null : this.canvas.worldCamera);
		Vector2 vector2;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(this.canvasRect, vector, camera, out vector2);
		return vector2;
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x00014A80 File Offset: 0x00012C80
	private Vector3 bef(Vector2 a)
	{
		Ray ray = this.worldCamera.ScreenPointToRay(a);
		Plane plane = new Plane(Vector3.forward, this.targetTransform.position);
		float num;
		if (!plane.Raycast(ray, out num))
		{
			return this.targetTransform.position;
		}
		return ray.GetPoint(num);
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x00014AD8 File Offset: 0x00012CD8
	private Vector3 beg(Vector3 a)
	{
		Vector3 vector = this.worldCamera.WorldToViewportPoint(a);
		float num = Mathf.Max(1f, (float)Screen.width);
		float num2 = Mathf.Max(1f, (float)Screen.height);
		float num3 = Mathf.Max(1f, this.referenceCanvasWidth) / num;
		float num4 = Mathf.Max(1f, this.referenceCanvasHeight) / num2;
		vector.x = Mathf.Clamp(vector.x, -this.allowOverflowLeft * num3, 1f + this.allowOverflowRight * num3);
		vector.y = Mathf.Clamp(vector.y, -this.allowOverflowBottom * num4, 1f + this.allowOverflowTop * num4);
		return this.worldCamera.ViewportToWorldPoint(vector);
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x00014B9B File Offset: 0x00012D9B
	public Vector3 beh(Vector3 a)
	{
		if (this.worldCamera == null)
		{
			this.worldCamera = Camera.main;
		}
		if (this.worldCamera == null)
		{
			return a;
		}
		return this.beg(a);
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x00014BD0 File Offset: 0x00012DD0
	private void bei()
	{
		WindowDragHandler.POINT point;
		if (!WindowDragHandler.GetCursorPos(out point))
		{
			return;
		}
		IntPtr intPtr = WindowDragHandler.MonitorFromPoint(point, 2U);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		WindowDragHandler.MONITORINFOEX monitorinfoex = default(WindowDragHandler.MONITORINFOEX);
		monitorinfoex.cbSize = Marshal.SizeOf<WindowDragHandler.MONITORINFOEX>(monitorinfoex);
		if (!WindowDragHandler.GetMonitorInfo(intPtr, ref monitorinfoex))
		{
			return;
		}
		if (monitorinfoex.rcWork.Bottom >= monitorinfoex.rcMonitor.Bottom)
		{
			return;
		}
		int num = monitorinfoex.rcMonitor.Bottom - monitorinfoex.rcWork.Bottom;
		float num2 = (float)Screen.width * 0.5f;
		Vector3 vector = this.bef(new Vector2(num2, (float)num));
		Vector3 vector2 = this.bef(new Vector2(num2, 0f));
		float num3 = Mathf.Abs(vector.y - vector2.y) / Mathf.Max(1f, (float)num);
		float num4 = (float)this.snapThreshold * num3;
		float num5 = vector.y + this.taskbarOffsetY;
		Vector3 position = this.targetTransform.position;
		if (Mathf.Abs(position.y - num5) <= num4)
		{
			position.y = num5;
			this.targetTransform.position = position;
		}
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x00005090 File Offset: 0x00003290
	private void bej()
	{
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x00014CF4 File Offset: 0x00012EF4
	private float bek()
	{
		if (this.downUI == null || this.worldCamera == null || this.canvas == null)
		{
			return 0f;
		}
		Vector3[] array = new Vector3[4];
		this.downUI.GetWorldCorners(array);
		Vector3 vector = Vector3.Lerp(array[0], array[3], 0.5f);
		Camera camera = ((this.canvas.renderMode == RenderMode.ScreenSpaceOverlay) ? null : this.canvas.worldCamera);
		Vector3 vector2 = ((camera != null) ? camera.WorldToScreenPoint(vector) : vector);
		Vector3 vector3 = this.worldCamera.WorldToScreenPoint(this.targetTransform.position);
		return Mathf.Max(0f, vector3.y - vector2.y);
	}

	// Token: 0x040001E8 RID: 488
	public bool enableAutoSnap = true;

	// Token: 0x040001E9 RID: 489
	public int snapThreshold = 30;

	// Token: 0x040001EA RID: 490
	public int window10DownOffsetY = 65;

	// Token: 0x040001EB RID: 491
	public int window11DownOffsetY = 80;

	// Token: 0x040001EC RID: 492
	[Range(-0.5f, 0.5f)]
	[SerializeField]
	private float allowOverflowLeft = 0.4f;

	// Token: 0x040001ED RID: 493
	[Range(-0.5f, 0.5f)]
	[SerializeField]
	private float allowOverflowRight = 0.4f;

	// Token: 0x040001EE RID: 494
	[Range(-0.5f, 0.5f)]
	[SerializeField]
	private float allowOverflowBottom = 0.5f;

	// Token: 0x040001EF RID: 495
	[Range(-0.5f, 0.5f)]
	[SerializeField]
	private float allowOverflowTop;

	// Token: 0x040001F0 RID: 496
	[SerializeField]
	private float taskbarOffsetY;

	// Token: 0x040001F1 RID: 497
	[SerializeField]
	private float dockOffsetY;

	// Token: 0x040001F2 RID: 498
	[SerializeField]
	private bool dockSnapCharacterPivot = true;

	// Token: 0x040001F3 RID: 499
	[SerializeField]
	private bool dockSnapUIBottom = true;

	// Token: 0x040001F4 RID: 500
	[SerializeField]
	private float referenceCanvasWidth = 1024f;

	// Token: 0x040001F5 RID: 501
	[SerializeField]
	private float referenceCanvasHeight = 1024f;

	// Token: 0x040001F6 RID: 502
	[SerializeField]
	private float referenceFov = 15f;

	// Token: 0x040001F7 RID: 503
	[SerializeField]
	private Transform targetTransform;

	// Token: 0x040001F8 RID: 504
	[SerializeField]
	private RectTransform downUI;

	// Token: 0x040001F9 RID: 505
	[SerializeField]
	private Canvas canvas;

	// Token: 0x040001FA RID: 506
	[SerializeField]
	private RectTransform canvasRect;

	// Token: 0x040001FB RID: 507
	[SerializeField]
	private Camera worldCamera;

	// Token: 0x040001FC RID: 508
	private Vector2 hon;

	// Token: 0x040001FD RID: 509
	private bool hoo;

	// Token: 0x040001FE RID: 510
	private Vector3 hop;

	// Token: 0x040001FF RID: 511
	private Vector2 hoq;

	// Token: 0x04000200 RID: 512
	private bool hor;

	// Token: 0x04000201 RID: 513
	private bool hos;

	// Token: 0x04000203 RID: 515
	private const uint hou = 2U;

	// Token: 0x02000044 RID: 68
	private struct POINT
	{
		// Token: 0x04000204 RID: 516
		public int X;

		// Token: 0x04000205 RID: 517
		public int Y;
	}

	// Token: 0x02000045 RID: 69
	private struct RECT
	{
		// Token: 0x04000206 RID: 518
		public int Left;

		// Token: 0x04000207 RID: 519
		public int Top;

		// Token: 0x04000208 RID: 520
		public int Right;

		// Token: 0x04000209 RID: 521
		public int Bottom;
	}

	// Token: 0x02000046 RID: 70
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	private struct MONITORINFOEX
	{
		// Token: 0x0400020A RID: 522
		public int cbSize;

		// Token: 0x0400020B RID: 523
		public WindowDragHandler.RECT rcMonitor;

		// Token: 0x0400020C RID: 524
		public WindowDragHandler.RECT rcWork;

		// Token: 0x0400020D RID: 525
		public int dwFlags;

		// Token: 0x0400020E RID: 526
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string szDevice;
	}
}
