using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Ricimi;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BongoWaifu.Multiplayer
{
	// Token: 0x02000134 RID: 308
	public static class RemoteNameplate
	{
		// Token: 0x0600168D RID: 5773 RVA: 0x0006FF58 File Offset: 0x0006E158
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
			RemoteNameplate.iyv = null;
			RemoteNameplate.iyw = null;
			RemoteNameplate.iyx = null;
			RemoteNameplate.iyy = 0.6f;
			RemoteNameplate.iyz = new Color(-1f, -1f, -1f, -1f);
			RemoteNameplate.iza = null;
			RemoteNameplate.izb = Vector2.zero;
			RemoteNameplate.izc = null;
			RemoteNameplate.izd = null;
			RemoteNameplate.ize = false;
			RemoteNameplate.izf = null;
			RemoteNameplate.izg = null;
			RemoteNameplate.izh = null;
			RemoteNameplate.izi = false;
			RemoteNameplate.izj = -1f;
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x0006FFE4 File Offset: 0x0006E1E4
		public static void dpt(object a, string b, float c, Vector2 d, Color e)
		{
			RemoteNameplate.dpw();
			if (RemoteNameplate.iyw == null || RemoteNameplate.iza == null)
			{
				return;
			}
			RemoteNameplate.izd = a;
			if (RemoteNameplate.iyx != null && e != RemoteNameplate.iyz)
			{
				RemoteNameplate.iyx.color = new Color(e.r, e.g, e.b, RemoteNameplate.iyy);
				RemoteNameplate.iyz = e;
			}
			float num = RemoteNameplate.dpy();
			if (!Mathf.Approximately(num, RemoteNameplate.izj))
			{
				RemoteNameplate.iza.localScale = new Vector3(num, num, 1f);
				RemoteNameplate.izj = num;
			}
			string text = (string.IsNullOrEmpty(b) ? a.eex() : b);
			if (!string.Equals(text, RemoteNameplate.izc))
			{
				RemoteNameplate.iyw.text = text;
				RemoteNameplate.izc = text;
				LayoutRebuilder.ForceRebuildLayoutImmediate(RemoteNameplate.iza);
			}
			if (RemoteNameplate.izf != null)
			{
				bool flag = c >= 0f;
				if (flag)
				{
					int num2 = Mathf.Clamp(Mathf.RoundToInt(c * 100f), 0, 100);
					if (RemoteNameplate.izg != null)
					{
						RemoteNameplate.izg.Percentage = (float)num2;
					}
					if (RemoteNameplate.izh != null)
					{
						RemoteNameplate.izh.text = num2.ToString();
					}
				}
				if (flag != RemoteNameplate.izi)
				{
					RemoteNameplate.izf.SetActive(flag);
					RemoteNameplate.izi = flag;
				}
			}
			if (!RemoteNameplate.iyv.activeSelf)
			{
				RemoteNameplate.iyv.SetActive(true);
			}
			Vector2 vector = RemoteNameplate.dpz();
			RemoteNameplate.iza.position = new Vector3(d.x + RemoteNameplate.izb.x, d.y + vector.y + RemoteNameplate.izb.y, 0f);
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x000701AA File Offset: 0x0006E3AA
		public static void dpu(object a)
		{
			if (RemoteNameplate.izd != a)
			{
				return;
			}
			RemoteNameplate.izd = null;
			if (RemoteNameplate.iyv != null && RemoteNameplate.iyv.activeSelf)
			{
				RemoteNameplate.iyv.SetActive(false);
			}
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x000701DF File Offset: 0x0006E3DF
		public static void dpv()
		{
			RemoteNameplate.izd = null;
			if (RemoteNameplate.iyv != null && RemoteNameplate.iyv.activeSelf)
			{
				RemoteNameplate.iyv.SetActive(false);
			}
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x0007020C File Offset: 0x0006E40C
		private static void dpw()
		{
			if (RemoteNameplate.iyv != null)
			{
				return;
			}
			Canvas[] array = global::UnityEngine.Object.FindObjectsByType<Canvas>(FindObjectsInactive.Include, FindObjectsSortMode.None);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null && array[i].gameObject.name == a.eil())
				{
					global::UnityEngine.Object.Destroy(array[i].gameObject);
				}
			}
			GameObject gameObject = Resources.Load<GameObject>(a.eil());
			if (gameObject == null)
			{
				if (!RemoteNameplate.ize)
				{
					Debug.LogError(a.eim());
					RemoteNameplate.ize = true;
				}
				return;
			}
			RemoteNameplate.iyv = global::UnityEngine.Object.Instantiate<GameObject>(gameObject);
			RemoteNameplate.iyv.name = a.eil();
			RemoteNameplate.iyw = RemoteNameplate.iyv.GetComponentInChildren<Text>(true);
			if (RemoteNameplate.iyw == null)
			{
				Debug.LogError(a.ein());
				global::UnityEngine.Object.Destroy(RemoteNameplate.iyv);
				RemoteNameplate.iyv = null;
				return;
			}
			RemoteNameplate.iza = RemoteNameplate.iyw.rectTransform.parent as RectTransform;
			if (RemoteNameplate.iza == null || RemoteNameplate.iza == RemoteNameplate.iyv.transform)
			{
				RemoteNameplate.iza = RemoteNameplate.iyw.rectTransform;
			}
			RemoteNameplate.iyx = RemoteNameplate.iza.GetComponent<Image>();
			if (RemoteNameplate.iyx != null)
			{
				RemoteNameplate.iyy = RemoteNameplate.iyx.color.a;
			}
			RemoteNameplate.iyz = new Color(-1f, -1f, -1f, -1f);
			RemoteNameplate.izb = RemoteNameplate.iza.anchoredPosition;
			RemoteNameplate.iyw.font = RemoteNameplate.dqa();
			RemoteNameplate.iyw.raycastTarget = false;
			RemoteNameplate.dpx();
			RemoteNameplate.izc = null;
			RemoteNameplate.iyv.SetActive(false);
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x000703C4 File Offset: 0x0006E5C4
		private static void dpx()
		{
			GameObject gameObject = Resources.Load<GameObject>(a.eio());
			if (gameObject == null || RemoteNameplate.iza == null)
			{
				return;
			}
			RemoteNameplate.izf = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, RemoteNameplate.iza);
			RemoteNameplate.izf.name = a.bht();
			LayoutElement layoutElement = RemoteNameplate.izf.GetComponent<LayoutElement>();
			if (layoutElement == null)
			{
				layoutElement = RemoteNameplate.izf.AddComponent<LayoutElement>();
			}
			layoutElement.ignoreLayout = true;
			RectTransform rectTransform = RemoteNameplate.izf.transform as RectTransform;
			if (rectTransform != null)
			{
				rectTransform.anchorMin = new Vector2(1f, 0.5f);
				rectTransform.anchorMax = new Vector2(1f, 0.5f);
				rectTransform.pivot = new Vector2(0f, 0.5f);
				rectTransform.anchoredPosition = new Vector2(4f, 0f);
				rectTransform.localScale = new Vector3(0.5f, 0.5f, 1f);
			}
			ce[] componentsInChildren = RemoteNameplate.izf.GetComponentsInChildren<ce>(true);
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (componentsInChildren[i] != null)
				{
					componentsInChildren[i].enabled = false;
				}
			}
			Graphic[] componentsInChildren2 = RemoteNameplate.izf.GetComponentsInChildren<Graphic>(true);
			for (int j = 0; j < componentsInChildren2.Length; j++)
			{
				if (componentsInChildren2[j] != null)
				{
					componentsInChildren2[j].raycastTarget = false;
				}
			}
			RemoteNameplate.izg = RemoteNameplate.izf.GetComponentInChildren<CircularProgressBar>(true);
			RemoteNameplate.izh = RemoteNameplate.izf.GetComponentInChildren<TMP_Text>(true);
			RemoteNameplate.izf.SetActive(false);
			RemoteNameplate.izi = false;
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00070558 File Offset: 0x0006E758
		private static float dpy()
		{
			GirlController girlController = GirlController.kok;
			if (girlController == null || girlController.sizeController == null)
			{
				return 1f;
			}
			bz sizeController = girlController.sizeController;
			int num = ((sizeController.sizes != null) ? sizeController.sizes.Count : 0);
			if (num == 0)
			{
				return 1f;
			}
			int num2 = Mathf.Clamp(bq.hlo, 0, num - 1);
			int num3 = Mathf.Clamp(0, 0, num - 1);
			float num4 = sizeController.bdq(num3);
			if (num4 <= 0.0001f)
			{
				return 1f;
			}
			return sizeController.bdq(num2) / num4;
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x000705F0 File Offset: 0x0006E7F0
		private static Vector2 dpz()
		{
			WindowDragHandler windowDragHandler = WindowDragHandler.hot;
			Vector2 vector;
			if (windowDragHandler != null && windowDragHandler.beb(out vector))
			{
				return vector;
			}
			return Vector2.zero;
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x00070620 File Offset: 0x0006E820
		private static Font dqa()
		{
			Font builtinResource = Resources.GetBuiltinResource<Font>(a.dtv());
			if (builtinResource != null)
			{
				return builtinResource;
			}
			return Font.CreateDynamicFontFromOSFont(a.dtw(), 20);
		}

		// Token: 0x04000B6B RID: 2923
		private const string iyo = "MP_Nameplate";

		// Token: 0x04000B6C RID: 2924
		private const string iyp = "MP_Nameplate";

		// Token: 0x04000B6D RID: 2925
		private const string iyq = "MP_LoveBar";

		// Token: 0x04000B6E RID: 2926
		private const string iyr = "LoveBar";

		// Token: 0x04000B6F RID: 2927
		private const float iys = 0.5f;

		// Token: 0x04000B70 RID: 2928
		private const float iyt = 4f;

		// Token: 0x04000B71 RID: 2929
		private const int iyu = 0;

		// Token: 0x04000B72 RID: 2930
		private static GameObject iyv;

		// Token: 0x04000B73 RID: 2931
		private static Text iyw;

		// Token: 0x04000B74 RID: 2932
		private static Image iyx;

		// Token: 0x04000B75 RID: 2933
		private static float iyy = 0.6f;

		// Token: 0x04000B76 RID: 2934
		private static Color iyz = new Color(-1f, -1f, -1f, -1f);

		// Token: 0x04000B77 RID: 2935
		private static RectTransform iza;

		// Token: 0x04000B78 RID: 2936
		private static Vector2 izb;

		// Token: 0x04000B79 RID: 2937
		private static string izc;

		// Token: 0x04000B7A RID: 2938
		private static object izd;

		// Token: 0x04000B7B RID: 2939
		private static bool ize;

		// Token: 0x04000B7C RID: 2940
		private static GameObject izf;

		// Token: 0x04000B7D RID: 2941
		private static CircularProgressBar izg;

		// Token: 0x04000B7E RID: 2942
		private static TMP_Text izh;

		// Token: 0x04000B7F RID: 2943
		private static bool izi;

		// Token: 0x04000B80 RID: 2944
		private static float izj;
	}
}
