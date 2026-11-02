using System;
using System.IO;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020000DC RID: 220
public sealed class WorkshopPreviewController : MonoBehaviour
{
	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x06000B6A RID: 2922 RVA: 0x0004395A File Offset: 0x00041B5A
	public static WorkshopPreviewController krz
	{
		get
		{
			return WorkshopPreviewController.igb;
		}
	}

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00043964 File Offset: 0x00041B64
	private Transform ksa
	{
		get
		{
			if (this.catController.skeletonAnimation != null && this.catController.skeletonAnimation.gameObject.activeSelf)
			{
				return this.catController.skeletonAnimation.transform;
			}
			if (this.catController.imageSpriteRenderer != null && this.catController.imageSpriteRenderer.gameObject.activeSelf)
			{
				return this.catController.imageSpriteRenderer.transform;
			}
			return this.previewRoot;
		}
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x06000B6C RID: 2924 RVA: 0x000439ED File Offset: 0x00041BED
	// (set) Token: 0x06000B6D RID: 2925 RVA: 0x000439FF File Offset: 0x00041BFF
	public Vector2 ksb
	{
		get
		{
			return this.ksa.localPosition;
		}
		set
		{
			this.ksa.localPosition = new Vector3(value.x, value.y, 0f);
			this.catController.tz(value, this.ksc);
		}
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x06000B6E RID: 2926 RVA: 0x00043A34 File Offset: 0x00041C34
	// (set) Token: 0x06000B6F RID: 2927 RVA: 0x00043A46 File Offset: 0x00041C46
	public Vector2 ksc
	{
		get
		{
			return this.ksa.localScale;
		}
		set
		{
			this.ksa.localScale = new Vector3(value.x, value.y, 1f);
			this.catController.tz(this.ksb, value);
		}
	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x00043A7B File Offset: 0x00041C7B
	private void Awake()
	{
		WorkshopPreviewController.igb = this;
	}

	// Token: 0x06000B71 RID: 2929 RVA: 0x00043A83 File Offset: 0x00041C83
	private void OnEnable()
	{
		eu.cry(false);
		eu.ijw += this.clx;
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x00043A9C File Offset: 0x00041C9C
	private void OnDisable()
	{
		eu.ijw -= this.clx;
		eu.crz();
	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x00043AB4 File Offset: 0x00041CB4
	private void clx(int a)
	{
		if (this.igc == null)
		{
			return;
		}
		this.catController.ue();
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x00043AD0 File Offset: 0x00041CD0
	public void cly(CatCharacterDefinition a)
	{
		this.igc = a;
		if (a == null)
		{
			this.catController.gameObject.SetActive(false);
			return;
		}
		this.catController.gameObject.SetActive(true);
		this.catController.tv(a);
		this.ksb = a.characterPosition;
		this.ksc = a.characterScale;
	}

	// Token: 0x06000B75 RID: 2933 RVA: 0x00043B34 File Offset: 0x00041D34
	public void clz(float a)
	{
		this.catController.ua(a);
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x00043B42 File Offset: 0x00041D42
	public void cma(float a)
	{
		this.catController.ub(a);
	}

	// Token: 0x06000B77 RID: 2935 RVA: 0x00043B50 File Offset: 0x00041D50
	private void Update()
	{
		eu.csa();
		if (this.igc == null)
		{
			return;
		}
		if (!Input.GetMouseButtonDown(0))
		{
			return;
		}
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			return;
		}
		this.catController.ue();
	}

	// Token: 0x06000B78 RID: 2936 RVA: 0x00043BA0 File Offset: 0x00041DA0
	public Texture2D cmb()
	{
		int num = 512;
		RenderTexture temporary = RenderTexture.GetTemporary(num, num, 24);
		this.screenshotCamera.targetTexture = temporary;
		this.screenshotCamera.backgroundColor = this.screenshotBackground;
		this.screenshotCamera.enabled = true;
		this.screenshotCamera.Render();
		this.screenshotCamera.enabled = false;
		RenderTexture.active = temporary;
		Texture2D texture2D = new Texture2D(num, num, TextureFormat.RGB24, false);
		texture2D.ReadPixels(new Rect(0f, 0f, (float)num, (float)num), 0, 0);
		texture2D.Apply();
		RenderTexture.active = null;
		this.screenshotCamera.targetTexture = null;
		RenderTexture.ReleaseTemporary(temporary);
		return texture2D;
	}

	// Token: 0x06000B79 RID: 2937 RVA: 0x00043C48 File Offset: 0x00041E48
	public string cmc(string a)
	{
		Texture2D texture2D = this.cmb();
		byte[] array = texture2D.EncodeToPNG();
		global::UnityEngine.Object.Destroy(texture2D);
		string text = Path.Combine(a, a.cxn()).Replace('\\', '/');
		File.WriteAllBytes(text, array);
		Debug.Log(a.dlo() + text);
		return text;
	}

	// Token: 0x040008D2 RID: 2258
	private static WorkshopPreviewController igb;

	// Token: 0x040008D3 RID: 2259
	[SerializeField]
	private r catController;

	// Token: 0x040008D4 RID: 2260
	[SerializeField]
	private Transform previewRoot;

	// Token: 0x040008D5 RID: 2261
	[SerializeField]
	private Camera screenshotCamera;

	// Token: 0x040008D6 RID: 2262
	[SerializeField]
	private Color screenshotBackground = new Color(0.15f, 0.15f, 0.15f, 1f);

	// Token: 0x040008D7 RID: 2263
	private CatCharacterDefinition igc;
}
