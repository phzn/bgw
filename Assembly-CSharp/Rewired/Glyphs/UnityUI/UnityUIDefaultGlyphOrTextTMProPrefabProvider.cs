using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Glyphs.UnityUI
{
	// Token: 0x020001D3 RID: 467
	internal class UnityUIDefaultGlyphOrTextTMProPrefabProvider
	{
		// Token: 0x06001E25 RID: 7717 RVA: 0x000876FA File Offset: 0x000858FA
		[RuntimeInitializeOnLoadMethod]
		private static void Initialize()
		{
			UnityUIControllerElementGlyphBase.ltf = new Func<GameObject>(UnityUIDefaultGlyphOrTextTMProPrefabProvider.fds);
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x00087710 File Offset: 0x00085910
		private static GameObject fds()
		{
			GameObject gameObject = new GameObject(a.epj());
			gameObject.hideFlags = HideFlags.HideAndDontSave;
			global::UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityUIGlyphOrTextTMPro unityUIGlyphOrTextTMPro = gameObject.AddComponent<UnityUIGlyphOrTextTMPro>();
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
			unityUIGlyphOrTextTMPro.lsq = image;
			GameObject gameObject3 = new GameObject(a.dtt());
			gameObject3.hideFlags = HideFlags.HideAndDontSave;
			gameObject3.transform.SetParent(gameObject.transform, false);
			TextMeshProUGUI textMeshProUGUI = gameObject3.AddComponent<TextMeshProUGUI>();
			textMeshProUGUI.alignment = TextAlignmentOptions.Center;
			textMeshProUGUI.fontSize = 32f;
			textMeshProUGUI.enableAutoSizing = true;
			textMeshProUGUI.fontSizeMin = 10f;
			textMeshProUGUI.fontSizeMax = 32f;
			textMeshProUGUI.raycastTarget = false;
			unityUIGlyphOrTextTMPro.lsp = textMeshProUGUI;
			return gameObject;
		}
	}
}
