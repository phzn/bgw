using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Glyphs.UnityUI
{
	// Token: 0x020001D1 RID: 465
	public abstract class UnityUIControllerElementGlyphBase : ControllerElementGlyphBase
	{
		// Token: 0x06001E1C RID: 7708 RVA: 0x00087598 File Offset: 0x00085798
		protected override GameObject faq()
		{
			return UnityUIControllerElementGlyphBase.lte;
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001E1D RID: 7709 RVA: 0x000875A7 File Offset: 0x000857A7
		// (set) Token: 0x06001E1E RID: 7710 RVA: 0x000875C7 File Offset: 0x000857C7
		public static GameObject lte
		{
			get
			{
				if (!(UnityUIControllerElementGlyphBase.jvs != null))
				{
					return UnityUIControllerElementGlyphBase.jvs = UnityUIControllerElementGlyphBase.fdr();
				}
				return UnityUIControllerElementGlyphBase.jvs;
			}
			set
			{
				UnityUIControllerElementGlyphBase.jvs = value;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001E1F RID: 7711 RVA: 0x000875CF File Offset: 0x000857CF
		// (set) Token: 0x06001E20 RID: 7712 RVA: 0x000875D6 File Offset: 0x000857D6
		public static Func<GameObject> ltf
		{
			get
			{
				return UnityUIControllerElementGlyphBase.jvt;
			}
			set
			{
				UnityUIControllerElementGlyphBase.jvt = value;
			}
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x000875E0 File Offset: 0x000857E0
		private static GameObject fdr()
		{
			if (UnityUIControllerElementGlyphBase.jvt != null)
			{
				return UnityUIControllerElementGlyphBase.jvt();
			}
			GameObject gameObject = new GameObject(a.epj());
			gameObject.hideFlags = HideFlags.HideAndDontSave;
			global::UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityUIGlyphOrText unityUIGlyphOrText = gameObject.AddComponent<UnityUIGlyphOrText>();
			VerticalLayoutGroup verticalLayoutGroup = gameObject.AddComponent<VerticalLayoutGroup>();
			verticalLayoutGroup.childControlHeight = true;
			verticalLayoutGroup.childControlWidth = true;
			verticalLayoutGroup.childForceExpandHeight = true;
			verticalLayoutGroup.childForceExpandWidth = true;
			GameObject gameObject2 = new GameObject(a.epk());
			gameObject2.hideFlags = HideFlags.HideAndDontSave;
			gameObject2.transform.SetParent(gameObject.transform, false);
			Image image = gameObject2.AddComponent<Image>();
			image.preserveAspect = true;
			unityUIGlyphOrText.lsq = image;
			GameObject gameObject3 = new GameObject(a.dtt());
			gameObject3.hideFlags = HideFlags.HideAndDontSave;
			gameObject3.transform.SetParent(gameObject.transform, false);
			Text text = gameObject3.AddComponent<Text>();
			text.alignment = TextAnchor.MiddleCenter;
			text.fontSize = 32;
			text.resizeTextForBestFit = true;
			text.resizeTextMinSize = 10;
			text.resizeTextMaxSize = 32;
			text.font = Resources.GetBuiltinResource<Font>(a.dtv());
			text.raycastTarget = false;
			unityUIGlyphOrText.lsp = text;
			return gameObject;
		}

		// Token: 0x04000F64 RID: 3940
		private static GameObject jvs;

		// Token: 0x04000F65 RID: 3941
		private static Func<GameObject> jvt;
	}
}
