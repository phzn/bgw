using System;
using System.Collections;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000252 RID: 594
public class ky : MonoBehaviour
{
	// Token: 0x06002588 RID: 9608 RVA: 0x0009CF84 File Offset: 0x0009B184
	private void gtz()
	{
		Texture2D texture2D = new Texture2D(1, 1);
		texture2D.SetPixel(0, 0, this.backgroundColor);
		texture2D.Apply();
		this.kho = new GameObject(a.ezb());
		Image image = this.kho.AddComponent<Image>();
		Rect rect = new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height);
		Sprite sprite = Sprite.Create(texture2D, rect, new Vector2(0.5f, 0.5f), 1f);
		image.material = new Material(image.material);
		image.material.mainTexture = texture2D;
		image.sprite = sprite;
		Color color = image.color;
		image.color = color;
		image.canvasRenderer.SetAlpha(0f);
		image.CrossFadeAlpha(1f, 0.4f, false);
		Canvas componentInParent = base.GetComponentInParent<Canvas>();
		this.kho.transform.localScale = new Vector3(1f, 1f, 1f);
		this.kho.GetComponent<RectTransform>().sizeDelta = componentInParent.GetComponent<RectTransform>().sizeDelta;
		this.kho.transform.SetParent(componentInParent.transform, false);
		this.kho.transform.SetSiblingIndex(base.transform.GetSiblingIndex());
	}

	// Token: 0x06002589 RID: 9609 RVA: 0x0009D0D0 File Offset: 0x0009B2D0
	public void jwp()
	{
		Animator component = base.GetComponent<Animator>();
		if (component.GetCurrentAnimatorStateInfo(0).IsName(a.ezc()))
		{
			component.Play(a.ezd());
		}
		this.gua();
		base.StartCoroutine(this.gty());
	}

	// Token: 0x0600258A RID: 9610 RVA: 0x0009D118 File Offset: 0x0009B318
	public void Open()
	{
		this.gtz();
	}

	// Token: 0x0600258B RID: 9611 RVA: 0x0009D120 File Offset: 0x0009B320
	private IEnumerator gty()
	{
		yield return new WaitForSeconds(this.destroyTime);
		global::UnityEngine.Object.Destroy(this.kho);
		global::UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x0600258C RID: 9612 RVA: 0x0009D130 File Offset: 0x0009B330
	private void gua()
	{
		Image component = this.kho.GetComponent<Image>();
		if (component != null)
		{
			component.CrossFadeAlpha(0f, 0.2f, false);
		}
	}

	// Token: 0x0600258E RID: 9614 RVA: 0x0009D118 File Offset: 0x0009B318
	public void bbd()
	{
		this.gtz();
	}

	// Token: 0x0600258F RID: 9615 RVA: 0x0009D198 File Offset: 0x0009B398
	private void jst()
	{
		Texture2D texture2D = new Texture2D(1, 1);
		texture2D.SetPixel(0, 0, this.backgroundColor);
		texture2D.Apply();
		this.kho = new GameObject(a.eze());
		Image image = this.kho.AddComponent<Image>();
		Rect rect = new Rect(-2583f, 4321f, (float)texture2D.width, (float)texture2D.height);
		Sprite sprite = Sprite.Create(texture2D, rect, new Vector2(-7640f, 2880f), 6554f);
		image.material = new Material(image.material);
		image.material.mainTexture = texture2D;
		image.sprite = sprite;
		Color color = image.color;
		image.color = color;
		image.canvasRenderer.SetAlpha(-8090f);
		image.CrossFadeAlpha(3142f, 3443f, false);
		Canvas componentInParent = base.GetComponentInParent<Canvas>();
		this.kho.transform.localScale = new Vector3(-7245f, -2066f, -4497f);
		this.kho.GetComponent<RectTransform>().sizeDelta = componentInParent.GetComponent<RectTransform>().sizeDelta;
		this.kho.transform.SetParent(componentInParent.transform, false);
		this.kho.transform.SetSiblingIndex(base.transform.GetSiblingIndex());
	}

	// Token: 0x06002590 RID: 9616 RVA: 0x0009D2E4 File Offset: 0x0009B4E4
	private void dkx()
	{
		Texture2D texture2D = new Texture2D(1, 1);
		texture2D.SetPixel(0, 0, this.backgroundColor);
		texture2D.Apply();
		this.kho = new GameObject(a.ezf());
		Image image = this.kho.AddComponent<Image>();
		Rect rect = new Rect(8908f, 1456f, (float)texture2D.width, (float)texture2D.height);
		Sprite sprite = Sprite.Create(texture2D, rect, new Vector2(9269f, 1918f), -8148f);
		image.material = new Material(image.material);
		image.material.mainTexture = texture2D;
		image.sprite = sprite;
		Color color = image.color;
		image.color = color;
		image.canvasRenderer.SetAlpha(-8555f);
		image.CrossFadeAlpha(-7594f, -4742f, false);
		Canvas componentInParent = base.GetComponentInParent<Canvas>();
		this.kho.transform.localScale = new Vector3(-1221f, -6832f, 6190f);
		this.kho.GetComponent<RectTransform>().sizeDelta = componentInParent.GetComponent<RectTransform>().sizeDelta;
		this.kho.transform.SetParent(componentInParent.transform, false);
		this.kho.transform.SetSiblingIndex(base.transform.GetSiblingIndex());
	}

	// Token: 0x06002591 RID: 9617 RVA: 0x0009D430 File Offset: 0x0009B630
	public void jqc()
	{
		Animator component = base.GetComponent<Animator>();
		if (component.GetCurrentAnimatorStateInfo(0).IsName(a.ezg()))
		{
			component.Play(a.ezh());
		}
		this.gua();
		base.StartCoroutine(this.gty());
	}

	// Token: 0x06002592 RID: 9618 RVA: 0x0009D478 File Offset: 0x0009B678
	public void Close()
	{
		Animator component = base.GetComponent<Animator>();
		if (component.GetCurrentAnimatorStateInfo(0).IsName(a.ezi()))
		{
			component.Play(a.ezj());
		}
		this.gua();
		base.StartCoroutine(this.gty());
	}

	// Token: 0x06002593 RID: 9619 RVA: 0x0009D4C0 File Offset: 0x0009B6C0
	private void obl()
	{
		Texture2D texture2D = new Texture2D(1, 1);
		texture2D.SetPixel(0, 0, this.backgroundColor);
		texture2D.Apply();
		this.kho = new GameObject(a.ezk());
		Image image = this.kho.AddComponent<Image>();
		Rect rect = new Rect(7760f, -7580f, (float)texture2D.width, (float)texture2D.height);
		Sprite sprite = Sprite.Create(texture2D, rect, new Vector2(-8047f, -4890f), 4250f);
		image.material = new Material(image.material);
		image.material.mainTexture = texture2D;
		image.sprite = sprite;
		Color color = image.color;
		image.color = color;
		image.canvasRenderer.SetAlpha(-390f);
		image.CrossFadeAlpha(-135f, -3836f, false);
		Canvas componentInParent = base.GetComponentInParent<Canvas>();
		this.kho.transform.localScale = new Vector3(4702f, 1181f, 7090f);
		this.kho.GetComponent<RectTransform>().sizeDelta = componentInParent.GetComponent<RectTransform>().sizeDelta;
		this.kho.transform.SetParent(componentInParent.transform, false);
		this.kho.transform.SetSiblingIndex(base.transform.GetSiblingIndex());
	}

	// Token: 0x06002594 RID: 9620 RVA: 0x0009D118 File Offset: 0x0009B318
	public void cgp()
	{
		this.gtz();
	}

	// Token: 0x06002595 RID: 9621 RVA: 0x0009D60C File Offset: 0x0009B80C
	public void mex()
	{
		Animator component = base.GetComponent<Animator>();
		if (component.GetCurrentAnimatorStateInfo(0).IsName(a.ezl()))
		{
			component.Play(a.ezm());
		}
		this.gua();
		base.StartCoroutine(this.gty());
	}

	// Token: 0x04001245 RID: 4677
	public Color backgroundColor = new Color(0.039215688f, 0.039215688f, 0.039215688f, 0.6f);

	// Token: 0x04001246 RID: 4678
	public float destroyTime = 0.5f;

	// Token: 0x04001247 RID: 4679
	private GameObject kho;
}
