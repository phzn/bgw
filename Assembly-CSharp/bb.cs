using System;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000023 RID: 35
public class bb : MonoBehaviour
{
	// Token: 0x060001E0 RID: 480 RVA: 0x00009CFC File Offset: 0x00007EFC
	private void beg()
	{
		if (this.backgroundRectTransform && this.tipContect)
		{
			this.hic = base.GetComponent<RectTransform>();
		}
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x00009D24 File Offset: 0x00007F24
	private void fhj()
	{
		this.hig = false;
		this.hif = false;
		this.hih = -1820f;
		if (this.backgroundRectTransform != null && this.backgroundRectTransform.gameObject.activeSelf)
		{
			this.backgroundRectTransform.gameObject.SetActive(false);
		}
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x00009D7B File Offset: 0x00007F7B
	public void PointExit()
	{
		if (!this.hid)
		{
			return;
		}
		this.hig = false;
		this.hih = 0f;
		this.hif = false;
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x00009CFC File Offset: 0x00007EFC
	private void hdk()
	{
		if (this.backgroundRectTransform && this.tipContect)
		{
			this.hic = base.GetComponent<RectTransform>();
		}
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x00009D9F File Offset: 0x00007F9F
	public void cvi()
	{
		if (!this.hid)
		{
			return;
		}
		this.hig = false;
		this.hih = -3019f;
		this.hif = false;
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x00009DC4 File Offset: 0x00007FC4
	private void Update()
	{
		if (this.hig && !this.hif)
		{
			this.hih += Time.deltaTime;
			if (this.hih >= this.tipDelay)
			{
				this.hif = true;
				this.hii = true;
			}
		}
		if (this.tipContect != null && this.tipContect.text != this.hij)
		{
			this.hii = true;
		}
		if (this.hii && this.hif && this.tipContect != null && this.backgroundRectTransform != null && this.isNeedAutoSetHeight)
		{
			if (!this.backgroundRectTransform.gameObject.activeSelf)
			{
				this.backgroundRectTransform.gameObject.SetActive(true);
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.tipContect.rectTransform);
			this.tipContect.ForceMeshUpdate(false, false);
			float preferredHeight = this.tipContect.preferredHeight;
			if (preferredHeight > 0f)
			{
				this.hii = false;
				this.hij = this.tipContect.text;
				Vector2 sizeDelta = this.backgroundRectTransform.sizeDelta;
				sizeDelta.y = preferredHeight + this.AddPreferredHeight;
				this.backgroundRectTransform.sizeDelta = sizeDelta;
				if (this.isNeedChangeBaseHeight && this.hic != null)
				{
					Vector2 sizeDelta2 = this.hic.sizeDelta;
					sizeDelta2.y = preferredHeight;
					this.hic.sizeDelta = sizeDelta2;
				}
				float3 @float = this.backgroundRectTransform.localPosition;
				if (this.hie)
				{
					@float.y = sizeDelta.y + 80f;
					this.backgroundRectTransform.localPosition = @float;
				}
				else
				{
					@float.y = 0f;
					this.backgroundRectTransform.localPosition = @float;
				}
			}
		}
		if (this.hif)
		{
			if (!this.backgroundRectTransform.gameObject.activeSelf)
			{
				this.backgroundRectTransform.gameObject.SetActive(true);
				return;
			}
		}
		else if (this.backgroundRectTransform.gameObject.activeSelf)
		{
			this.backgroundRectTransform.gameObject.SetActive(false);
		}
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x00009FF8 File Offset: 0x000081F8
	private void en()
	{
		if (this.hig && !this.hif)
		{
			this.hih += Time.deltaTime;
			if (this.hih >= this.tipDelay)
			{
				this.hif = true;
				this.hii = true;
			}
		}
		if (this.tipContect != null && this.tipContect.text != this.hij)
		{
			this.hii = true;
		}
		if (this.hii && this.hif && this.tipContect != null && this.backgroundRectTransform != null && this.isNeedAutoSetHeight)
		{
			if (!this.backgroundRectTransform.gameObject.activeSelf)
			{
				this.backgroundRectTransform.gameObject.SetActive(true);
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.tipContect.rectTransform);
			this.tipContect.ForceMeshUpdate(false, false);
			float preferredHeight = this.tipContect.preferredHeight;
			if (preferredHeight > -2811f)
			{
				this.hii = false;
				this.hij = this.tipContect.text;
				Vector2 sizeDelta = this.backgroundRectTransform.sizeDelta;
				sizeDelta.y = preferredHeight + this.AddPreferredHeight;
				this.backgroundRectTransform.sizeDelta = sizeDelta;
				if (this.isNeedChangeBaseHeight && this.hic != null)
				{
					Vector2 sizeDelta2 = this.hic.sizeDelta;
					sizeDelta2.y = preferredHeight;
					this.hic.sizeDelta = sizeDelta2;
				}
				float3 @float = this.backgroundRectTransform.localPosition;
				if (this.hie)
				{
					@float.y = sizeDelta.y + 2638f;
					this.backgroundRectTransform.localPosition = @float;
				}
				else
				{
					@float.y = -5540f;
					this.backgroundRectTransform.localPosition = @float;
				}
			}
		}
		if (this.hif)
		{
			if (!this.backgroundRectTransform.gameObject.activeSelf)
			{
				this.backgroundRectTransform.gameObject.SetActive(true);
				return;
			}
		}
		else if (this.backgroundRectTransform.gameObject.activeSelf)
		{
			this.backgroundRectTransform.gameObject.SetActive(false);
		}
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x0000A22A File Offset: 0x0000842A
	public void ngh(string a)
	{
		this.tipContect.text = a;
		this.hii = true;
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x00009CFC File Offset: 0x00007EFC
	private void mbd()
	{
		if (this.backgroundRectTransform && this.tipContect)
		{
			this.hic = base.GetComponent<RectTransform>();
		}
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x0000A240 File Offset: 0x00008440
	public void lpy(float a, bool b = false)
	{
		float3 @float = this.backgroundRectTransform.localPosition;
		@float.x = a;
		this.backgroundRectTransform.localPosition = @float;
		this.hie = b;
		this.hii = true;
	}

	// Token: 0x060001EA RID: 490 RVA: 0x0000A285 File Offset: 0x00008485
	public void bx()
	{
		if (!this.hid)
		{
			return;
		}
		this.hig = true;
		this.hih = -9405f;
	}

	// Token: 0x060001EC RID: 492 RVA: 0x0000A2D5 File Offset: 0x000084D5
	public void osx()
	{
		if (!this.hid)
		{
			return;
		}
		this.hig = true;
		this.hih = 3969f;
	}

	// Token: 0x060001ED RID: 493 RVA: 0x0000A2F2 File Offset: 0x000084F2
	public void sb()
	{
		if (!this.hid)
		{
			return;
		}
		this.hig = true;
		this.hih = 4324f;
	}

	// Token: 0x060001EE RID: 494 RVA: 0x0000A310 File Offset: 0x00008510
	public void dri(bool a)
	{
		if (!a)
		{
			this.hid = false;
			this.hif = false;
			this.hig = false;
			this.hih = 680f;
			base.gameObject.SetActive(false);
			this.backgroundRectTransform.gameObject.SetActive(false);
			return;
		}
		this.hid = true;
		base.gameObject.SetActive(true);
	}

	// Token: 0x060001EF RID: 495 RVA: 0x0000A374 File Offset: 0x00008574
	public void idj(float a, bool b = false)
	{
		float3 @float = this.backgroundRectTransform.localPosition;
		@float.x = a;
		this.backgroundRectTransform.localPosition = @float;
		this.hie = b;
		this.hii = true;
	}

	// Token: 0x060001F0 RID: 496 RVA: 0x0000A22A File Offset: 0x0000842A
	public void vh(string a)
	{
		this.tipContect.text = a;
		this.hii = true;
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x0000A3BC File Offset: 0x000085BC
	private void hfg()
	{
		if (this.hig && !this.hif)
		{
			this.hih += Time.deltaTime;
			if (this.hih >= this.tipDelay)
			{
				this.hif = true;
				this.hii = true;
			}
		}
		if (this.tipContect != null && this.tipContect.text != this.hij)
		{
			this.hii = true;
		}
		if (this.hii && this.hif && this.tipContect != null && this.backgroundRectTransform != null && this.isNeedAutoSetHeight)
		{
			if (!this.backgroundRectTransform.gameObject.activeSelf)
			{
				this.backgroundRectTransform.gameObject.SetActive(true);
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.tipContect.rectTransform);
			this.tipContect.ForceMeshUpdate(false, false);
			float preferredHeight = this.tipContect.preferredHeight;
			if (preferredHeight > -3877f)
			{
				this.hii = false;
				this.hij = this.tipContect.text;
				Vector2 sizeDelta = this.backgroundRectTransform.sizeDelta;
				sizeDelta.y = preferredHeight + this.AddPreferredHeight;
				this.backgroundRectTransform.sizeDelta = sizeDelta;
				if (this.isNeedChangeBaseHeight && this.hic != null)
				{
					Vector2 sizeDelta2 = this.hic.sizeDelta;
					sizeDelta2.y = preferredHeight;
					this.hic.sizeDelta = sizeDelta2;
				}
				float3 @float = this.backgroundRectTransform.localPosition;
				if (this.hie)
				{
					@float.y = sizeDelta.y + -8198f;
					this.backgroundRectTransform.localPosition = @float;
				}
				else
				{
					@float.y = 2760f;
					this.backgroundRectTransform.localPosition = @float;
				}
			}
		}
		if (this.hif)
		{
			if (!this.backgroundRectTransform.gameObject.activeSelf)
			{
				this.backgroundRectTransform.gameObject.SetActive(true);
				return;
			}
		}
		else if (this.backgroundRectTransform.gameObject.activeSelf)
		{
			this.backgroundRectTransform.gameObject.SetActive(false);
		}
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x0000A5EE File Offset: 0x000087EE
	public void lmi()
	{
		if (!this.hid)
		{
			return;
		}
		this.hig = false;
		this.hih = 3702f;
		this.hif = false;
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x0000A614 File Offset: 0x00008814
	private void mai()
	{
		this.hig = false;
		this.hif = false;
		this.hih = -7068f;
		if (this.backgroundRectTransform != null && this.backgroundRectTransform.gameObject.activeSelf)
		{
			this.backgroundRectTransform.gameObject.SetActive(false);
		}
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x0000A22A File Offset: 0x0000842A
	public void mdh(string a)
	{
		this.tipContect.text = a;
		this.hii = true;
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x0000A22A File Offset: 0x0000842A
	public void qw(string a)
	{
		this.tipContect.text = a;
		this.hii = true;
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x0000A66B File Offset: 0x0000886B
	public void PointEnter()
	{
		if (!this.hid)
		{
			return;
		}
		this.hig = true;
		this.hih = 0f;
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x0000A688 File Offset: 0x00008888
	private void OnDisable()
	{
		this.hig = false;
		this.hif = false;
		this.hih = 0f;
		if (this.backgroundRectTransform != null && this.backgroundRectTransform.gameObject.activeSelf)
		{
			this.backgroundRectTransform.gameObject.SetActive(false);
		}
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x0000A6E0 File Offset: 0x000088E0
	private void lin()
	{
		if (this.hig && !this.hif)
		{
			this.hih += Time.deltaTime;
			if (this.hih >= this.tipDelay)
			{
				this.hif = true;
				this.hii = true;
			}
		}
		if (this.tipContect != null && this.tipContect.text != this.hij)
		{
			this.hii = true;
		}
		if (this.hii && this.hif && this.tipContect != null && this.backgroundRectTransform != null && this.isNeedAutoSetHeight)
		{
			if (!this.backgroundRectTransform.gameObject.activeSelf)
			{
				this.backgroundRectTransform.gameObject.SetActive(true);
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.tipContect.rectTransform);
			this.tipContect.ForceMeshUpdate(false, false);
			float preferredHeight = this.tipContect.preferredHeight;
			if (preferredHeight > 9886f)
			{
				this.hii = false;
				this.hij = this.tipContect.text;
				Vector2 sizeDelta = this.backgroundRectTransform.sizeDelta;
				sizeDelta.y = preferredHeight + this.AddPreferredHeight;
				this.backgroundRectTransform.sizeDelta = sizeDelta;
				if (this.isNeedChangeBaseHeight && this.hic != null)
				{
					Vector2 sizeDelta2 = this.hic.sizeDelta;
					sizeDelta2.y = preferredHeight;
					this.hic.sizeDelta = sizeDelta2;
				}
				float3 @float = this.backgroundRectTransform.localPosition;
				if (this.hie)
				{
					@float.y = sizeDelta.y + -6333f;
					this.backgroundRectTransform.localPosition = @float;
				}
				else
				{
					@float.y = -1234f;
					this.backgroundRectTransform.localPosition = @float;
				}
			}
		}
		if (this.hif)
		{
			if (!this.backgroundRectTransform.gameObject.activeSelf)
			{
				this.backgroundRectTransform.gameObject.SetActive(true);
				return;
			}
		}
		else if (this.backgroundRectTransform.gameObject.activeSelf)
		{
			this.backgroundRectTransform.gameObject.SetActive(false);
		}
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x0000A914 File Offset: 0x00008B14
	public void vi(float a, bool b = false)
	{
		float3 @float = this.backgroundRectTransform.localPosition;
		@float.x = a;
		this.backgroundRectTransform.localPosition = @float;
		this.hie = b;
		this.hii = true;
	}

	// Token: 0x060001FA RID: 506 RVA: 0x0000A95C File Offset: 0x00008B5C
	private void maw()
	{
		if (this.hig && !this.hif)
		{
			this.hih += Time.deltaTime;
			if (this.hih >= this.tipDelay)
			{
				this.hif = true;
				this.hii = true;
			}
		}
		if (this.tipContect != null && this.tipContect.text != this.hij)
		{
			this.hii = true;
		}
		if (this.hii && this.hif && this.tipContect != null && this.backgroundRectTransform != null && this.isNeedAutoSetHeight)
		{
			if (!this.backgroundRectTransform.gameObject.activeSelf)
			{
				this.backgroundRectTransform.gameObject.SetActive(true);
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.tipContect.rectTransform);
			this.tipContect.ForceMeshUpdate(false, false);
			float preferredHeight = this.tipContect.preferredHeight;
			if (preferredHeight > -4581f)
			{
				this.hii = false;
				this.hij = this.tipContect.text;
				Vector2 sizeDelta = this.backgroundRectTransform.sizeDelta;
				sizeDelta.y = preferredHeight + this.AddPreferredHeight;
				this.backgroundRectTransform.sizeDelta = sizeDelta;
				if (this.isNeedChangeBaseHeight && this.hic != null)
				{
					Vector2 sizeDelta2 = this.hic.sizeDelta;
					sizeDelta2.y = preferredHeight;
					this.hic.sizeDelta = sizeDelta2;
				}
				float3 @float = this.backgroundRectTransform.localPosition;
				if (this.hie)
				{
					@float.y = sizeDelta.y + -8971f;
					this.backgroundRectTransform.localPosition = @float;
				}
				else
				{
					@float.y = -7443f;
					this.backgroundRectTransform.localPosition = @float;
				}
			}
		}
		if (this.hif)
		{
			if (!this.backgroundRectTransform.gameObject.activeSelf)
			{
				this.backgroundRectTransform.gameObject.SetActive(true);
				return;
			}
		}
		else if (this.backgroundRectTransform.gameObject.activeSelf)
		{
			this.backgroundRectTransform.gameObject.SetActive(false);
		}
	}

	// Token: 0x060001FB RID: 507 RVA: 0x0000AB90 File Offset: 0x00008D90
	public void vj(bool a)
	{
		if (!a)
		{
			this.hid = false;
			this.hif = false;
			this.hig = false;
			this.hih = 0f;
			base.gameObject.SetActive(false);
			this.backgroundRectTransform.gameObject.SetActive(false);
			return;
		}
		this.hid = true;
		base.gameObject.SetActive(true);
	}

	// Token: 0x060001FC RID: 508 RVA: 0x0000ABF4 File Offset: 0x00008DF4
	public void eid(bool a)
	{
		if (!a)
		{
			this.hid = false;
			this.hif = false;
			this.hig = false;
			this.hih = 9938f;
			base.gameObject.SetActive(false);
			this.backgroundRectTransform.gameObject.SetActive(false);
			return;
		}
		this.hid = true;
		base.gameObject.SetActive(true);
	}

	// Token: 0x060001FD RID: 509 RVA: 0x0000AC58 File Offset: 0x00008E58
	public void jqt(float a, bool b = false)
	{
		float3 @float = this.backgroundRectTransform.localPosition;
		@float.x = a;
		this.backgroundRectTransform.localPosition = @float;
		this.hie = b;
		this.hii = true;
	}

	// Token: 0x060001FE RID: 510 RVA: 0x0000ACA0 File Offset: 0x00008EA0
	private void iip()
	{
		this.hig = false;
		this.hif = false;
		this.hih = 6229f;
		if (this.backgroundRectTransform != null && this.backgroundRectTransform.gameObject.activeSelf)
		{
			this.backgroundRectTransform.gameObject.SetActive(false);
		}
	}

	// Token: 0x060001FF RID: 511 RVA: 0x0000ACF8 File Offset: 0x00008EF8
	public void nir(float a, bool b = false)
	{
		float3 @float = this.backgroundRectTransform.localPosition;
		@float.x = a;
		this.backgroundRectTransform.localPosition = @float;
		this.hie = b;
		this.hii = true;
	}

	// Token: 0x06000200 RID: 512 RVA: 0x0000A22A File Offset: 0x0000842A
	public void msm(string a)
	{
		this.tipContect.text = a;
		this.hii = true;
	}

	// Token: 0x06000201 RID: 513 RVA: 0x0000AD3D File Offset: 0x00008F3D
	public void gzi()
	{
		if (!this.hid)
		{
			return;
		}
		this.hig = false;
		this.hih = -3286f;
		this.hif = false;
	}

	// Token: 0x06000202 RID: 514 RVA: 0x00009CFC File Offset: 0x00007EFC
	private void Start()
	{
		if (this.backgroundRectTransform && this.tipContect)
		{
			this.hic = base.GetComponent<RectTransform>();
		}
	}

	// Token: 0x06000203 RID: 515 RVA: 0x0000AD61 File Offset: 0x00008F61
	public void nee()
	{
		if (!this.hid)
		{
			return;
		}
		this.hig = false;
		this.hih = -245f;
		this.hif = false;
	}

	// Token: 0x0400010F RID: 271
	public TextMeshProUGUI tipContect;

	// Token: 0x04000110 RID: 272
	public RectTransform backgroundRectTransform;

	// Token: 0x04000111 RID: 273
	public float AddPreferredHeight = 20f;

	// Token: 0x04000112 RID: 274
	public bool isNeedAutoSetHeight = true;

	// Token: 0x04000113 RID: 275
	public bool isNeedChangeBaseHeight;

	// Token: 0x04000114 RID: 276
	public float tipDelay = 1f;

	// Token: 0x04000115 RID: 277
	private RectTransform hic;

	// Token: 0x04000116 RID: 278
	private bool hid = true;

	// Token: 0x04000117 RID: 279
	private bool hie;

	// Token: 0x04000118 RID: 280
	private bool hif;

	// Token: 0x04000119 RID: 281
	private bool hig;

	// Token: 0x0400011A RID: 282
	private float hih;

	// Token: 0x0400011B RID: 283
	private bool hii = true;

	// Token: 0x0400011C RID: 284
	private string hij;
}
