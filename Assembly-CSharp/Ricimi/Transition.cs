using System;
using System.Collections;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Ricimi
{
	// Token: 0x0200025E RID: 606
	public class Transition : MonoBehaviour
	{
		// Token: 0x060025F1 RID: 9713 RVA: 0x0009DEC5 File Offset: 0x0009C0C5
		private void Awake()
		{
			Transition.kij = new GameObject(a.ezs());
			Transition.kij.AddComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
			global::UnityEngine.Object.DontDestroyOnLoad(Transition.kij);
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x0009DEF0 File Offset: 0x0009C0F0
		public static void guo(string a, float b, Color c)
		{
			GameObject gameObject = new GameObject(a.ezt());
			gameObject.AddComponent<Transition>();
			gameObject.GetComponent<Transition>().gup(a, b, c);
			gameObject.transform.SetParent(Transition.kij.transform, false);
			gameObject.transform.SetAsLastSibling();
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x0009DF3C File Offset: 0x0009C13C
		private void gup(string a, float b, Color c)
		{
			base.StartCoroutine(this.guq(a, b, c));
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x0009DF4E File Offset: 0x0009C14E
		private IEnumerator guq(string a, float b, Color c)
		{
			Texture2D texture2D = new Texture2D(1, 1);
			texture2D.SetPixel(0, 0, c);
			texture2D.Apply();
			this.kik = new GameObject();
			Image image = this.kik.AddComponent<Image>();
			Rect rect = new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height);
			Sprite sprite = Sprite.Create(texture2D, rect, new Vector2(0.5f, 0.5f), 1f);
			image.material = new Material(image.material);
			image.material.mainTexture = texture2D;
			image.sprite = sprite;
			Color color = image.color;
			image.color = color;
			image.canvasRenderer.SetAlpha(0f);
			this.kik.transform.localScale = new Vector3(1f, 1f, 1f);
			this.kik.GetComponent<RectTransform>().sizeDelta = Transition.kij.GetComponent<RectTransform>().sizeDelta;
			this.kik.transform.SetParent(Transition.kij.transform, false);
			this.kik.transform.SetAsFirstSibling();
			float num = 0f;
			float num2 = b / 2f;
			while (num < num2)
			{
				num += Time.deltaTime;
				image.canvasRenderer.SetAlpha(Mathf.InverseLerp(0f, 1f, num / num2));
				yield return new WaitForEndOfFrame();
			}
			image.canvasRenderer.SetAlpha(1f);
			yield return new WaitForEndOfFrame();
			SceneManager.LoadScene(a);
			num = 0f;
			while (num < num2)
			{
				num += Time.deltaTime;
				image.canvasRenderer.SetAlpha(Mathf.InverseLerp(1f, 0f, num / num2));
				yield return new WaitForEndOfFrame();
			}
			image.canvasRenderer.SetAlpha(0f);
			yield return new WaitForEndOfFrame();
			global::UnityEngine.Object.Destroy(Transition.kij);
			yield break;
		}

		// Token: 0x0400126C RID: 4716
		private static GameObject kij;

		// Token: 0x0400126D RID: 4717
		private GameObject kik;
	}
}
