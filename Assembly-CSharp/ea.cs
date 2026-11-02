using System;
using System.IO;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Spine.Unity;
using UnityEngine;

// Token: 0x020000CC RID: 204
public static class ea
{
	// Token: 0x06000A79 RID: 2681 RVA: 0x0003D2B8 File Offset: 0x0003B4B8
	private static void chk(CatCharacterDefinition a, CharacterPackageData b)
	{
		if (b.position != null && b.position.Length >= 2)
		{
			a.characterPosition = new Vector2(b.position[0], b.position[1]);
		}
		if (b.scale != null && b.scale.Length >= 2)
		{
			a.characterScale = new Vector2(b.scale[0], b.scale[1]);
		}
	}

	// Token: 0x06000A7A RID: 2682 RVA: 0x0003D324 File Offset: 0x0003B524
	private static CatCharacterDefinition chi(string a, CharacterPackageData b, out string c)
	{
		c = null;
		string text;
		SkeletonDataAsset skeletonDataAsset = ed.cib(a, b.spine_file, b.atlas_file, out text);
		if (skeletonDataAsset == null)
		{
			c = text;
			return null;
		}
		string text2;
		if (!ed.cic(skeletonDataAsset, b, out text2))
		{
			c = text2;
			global::UnityEngine.Object.Destroy(skeletonDataAsset);
			return null;
		}
		CatCharacterDefinition catCharacterDefinition = ScriptableObject.CreateInstance<CatCharacterDefinition>();
		catCharacterDefinition.characterId = b.id;
		catCharacterDefinition.displayName = b.name;
		catCharacterDefinition.displayMode = CatDisplayMode.Spine;
		catCharacterDefinition.skeletonDataAsset = skeletonDataAsset;
		catCharacterDefinition.idleAnim = b.animations.idle;
		catCharacterDefinition.clickLeftAnim = b.animations.click_left;
		catCharacterDefinition.clickRightAnim = b.animations.click_right;
		catCharacterDefinition.handMixOutTime = b.hand_mix_out_time;
		catCharacterDefinition.unlockType = CatUnlockType.Workshop;
		ea.chk(catCharacterDefinition, b);
		ea.chm(catCharacterDefinition, a);
		Debug.Log(a.cxf() + b.name + a.cxg() + b.author);
		return catCharacterDefinition;
	}

	// Token: 0x06000A7B RID: 2683 RVA: 0x0003D40C File Offset: 0x0003B60C
	private static void cvj(CatCharacterDefinition a, string b)
	{
		string text = Path.Combine(b, a.cxh());
		if (!File.Exists(text))
		{
			return;
		}
		byte[] array = File.ReadAllBytes(text);
		Texture2D texture2D = new Texture2D(2, 2, TextureFormat.RGBA32, false);
		if (texture2D.LoadImage(array))
		{
			a.previewIcon = Sprite.Create(texture2D, new Rect(457f, 2350f, (float)texture2D.width, (float)texture2D.height), new Vector2(793f, -3156f));
			return;
		}
		global::UnityEngine.Object.Destroy(texture2D);
	}

	// Token: 0x06000A7C RID: 2684 RVA: 0x0003D488 File Offset: 0x0003B688
	private static Sprite chl(string a, string b, out string c)
	{
		c = null;
		string text = Path.Combine(a, b);
		if (!File.Exists(text))
		{
			c = a.cxi() + text;
			return null;
		}
		if (new FileInfo(text).Length > 10485760L)
		{
			c = string.Format(a.cxj(), b, 10L);
			return null;
		}
		byte[] array = File.ReadAllBytes(text);
		Texture2D texture2D = new Texture2D(2, 2, TextureFormat.RGBA32, false);
		if (!texture2D.LoadImage(array))
		{
			c = a.cxk() + b;
			global::UnityEngine.Object.Destroy(texture2D);
			return null;
		}
		if (texture2D.width > 4096 || texture2D.height > 4096)
		{
			c = string.Format(a.cxl(), new object[] { b, 4096, 4096, texture2D.width, texture2D.height });
			global::UnityEngine.Object.Destroy(texture2D);
			return null;
		}
		texture2D.name = Path.GetFileNameWithoutExtension(b);
		texture2D.filterMode = FilterMode.Bilinear;
		texture2D.wrapMode = TextureWrapMode.Clamp;
		return Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f));
	}

	// Token: 0x06000A7D RID: 2685 RVA: 0x0003D5CC File Offset: 0x0003B7CC
	private static void kbi(CatCharacterDefinition a, string b)
	{
		string text = Path.Combine(b, a.cxm());
		if (!File.Exists(text))
		{
			return;
		}
		byte[] array = File.ReadAllBytes(text);
		Texture2D texture2D = new Texture2D(2, 2, TextureFormat.RGBA32, false);
		if (texture2D.LoadImage(array))
		{
			a.previewIcon = Sprite.Create(texture2D, new Rect(6320f, 2479f, (float)texture2D.width, (float)texture2D.height), new Vector2(1916f, -5645f));
			return;
		}
		global::UnityEngine.Object.Destroy(texture2D);
	}

	// Token: 0x06000A7E RID: 2686 RVA: 0x0003D648 File Offset: 0x0003B848
	private static void chm(CatCharacterDefinition a, string b)
	{
		string text = Path.Combine(b, a.cxn());
		if (!File.Exists(text))
		{
			return;
		}
		byte[] array = File.ReadAllBytes(text);
		Texture2D texture2D = new Texture2D(2, 2, TextureFormat.RGBA32, false);
		if (texture2D.LoadImage(array))
		{
			a.previewIcon = Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f));
			return;
		}
		global::UnityEngine.Object.Destroy(texture2D);
	}

	// Token: 0x06000A7F RID: 2687 RVA: 0x0003D6C4 File Offset: 0x0003B8C4
	private static void fpl(CatCharacterDefinition a, string b)
	{
		string text = Path.Combine(b, a.cxo());
		if (!File.Exists(text))
		{
			return;
		}
		byte[] array = File.ReadAllBytes(text);
		Texture2D texture2D = new Texture2D(2, 2, TextureFormat.RGBA32, false);
		if (texture2D.LoadImage(array))
		{
			a.previewIcon = Sprite.Create(texture2D, new Rect(816f, -7782f, (float)texture2D.width, (float)texture2D.height), new Vector2(9248f, -1336f));
			return;
		}
		global::UnityEngine.Object.Destroy(texture2D);
	}

	// Token: 0x06000A80 RID: 2688 RVA: 0x0003D740 File Offset: 0x0003B940
	private static CatCharacterDefinition chj(string a, CharacterPackageData b, out string c)
	{
		c = null;
		Sprite sprite = ea.chl(a, b.images.idle, out c);
		if (sprite == null)
		{
			return null;
		}
		Sprite sprite2 = ea.chl(a, b.images.click_left, out c);
		if (sprite2 == null)
		{
			return null;
		}
		Sprite sprite3 = ea.chl(a, b.images.click_right, out c);
		if (sprite3 == null)
		{
			return null;
		}
		CatCharacterDefinition catCharacterDefinition = ScriptableObject.CreateInstance<CatCharacterDefinition>();
		catCharacterDefinition.characterId = b.id;
		catCharacterDefinition.displayName = b.name;
		catCharacterDefinition.displayMode = CatDisplayMode.Image;
		catCharacterDefinition.idleSprite = sprite;
		catCharacterDefinition.clickLeftSprite = sprite2;
		catCharacterDefinition.clickRightSprite = sprite3;
		catCharacterDefinition.clickDisplayDuration = b.click_display_duration;
		catCharacterDefinition.unlockType = CatUnlockType.Workshop;
		ea.chk(catCharacterDefinition, b);
		ea.chm(catCharacterDefinition, a);
		Debug.Log(a.cxp() + b.name + a.cxg() + b.author);
		return catCharacterDefinition;
	}

	// Token: 0x06000A81 RID: 2689 RVA: 0x0003D824 File Offset: 0x0003BA24
	private static void cjp(CatCharacterDefinition a, CharacterPackageData b)
	{
		if (b.position != null && b.position.Length >= 2)
		{
			a.characterPosition = new Vector2(b.position[0], b.position[1]);
		}
		if (b.scale != null && b.scale.Length >= 2)
		{
			a.characterScale = new Vector2(b.scale[0], b.scale[1]);
		}
	}

	// Token: 0x06000A82 RID: 2690 RVA: 0x0003D890 File Offset: 0x0003BA90
	private static CatCharacterDefinition ept(string a, CharacterPackageData b, out string c)
	{
		c = null;
		string text;
		SkeletonDataAsset skeletonDataAsset = ed.cib(a, b.spine_file, b.atlas_file, out text);
		if (skeletonDataAsset == null)
		{
			c = text;
			return null;
		}
		string text2;
		if (!ed.cic(skeletonDataAsset, b, out text2))
		{
			c = text2;
			global::UnityEngine.Object.Destroy(skeletonDataAsset);
			return null;
		}
		CatCharacterDefinition catCharacterDefinition = ScriptableObject.CreateInstance<CatCharacterDefinition>();
		catCharacterDefinition.characterId = b.id;
		catCharacterDefinition.displayName = b.name;
		catCharacterDefinition.displayMode = CatDisplayMode.Spine;
		catCharacterDefinition.skeletonDataAsset = skeletonDataAsset;
		catCharacterDefinition.idleAnim = b.animations.idle;
		catCharacterDefinition.clickLeftAnim = b.animations.click_left;
		catCharacterDefinition.clickRightAnim = b.animations.click_right;
		catCharacterDefinition.handMixOutTime = b.hand_mix_out_time;
		catCharacterDefinition.unlockType = CatUnlockType.Workshop;
		ea.chk(catCharacterDefinition, b);
		ea.chm(catCharacterDefinition, a);
		Debug.Log(a.cxq() + b.name + a.cxr() + b.author);
		return catCharacterDefinition;
	}

	// Token: 0x06000A83 RID: 2691 RVA: 0x0003D978 File Offset: 0x0003BB78
	public static CatCharacterDefinition ngg(string a, out string b)
	{
		b = null;
		string text = Path.Combine(a, a.cxs());
		if (!File.Exists(text))
		{
			b = a.cxt() + a;
			return null;
		}
		string text2 = File.ReadAllText(text);
		CharacterPackageData characterPackageData;
		try
		{
			characterPackageData = JsonUtility.FromJson<CharacterPackageData>(text2);
		}
		catch (Exception ex)
		{
			b = a.cxu() + ex.Message;
			return null;
		}
		if (characterPackageData == null)
		{
			b = a.cxv();
			return null;
		}
		string text3;
		if (!characterPackageData.chg(out text3))
		{
			b = a.cxw() + text3;
			return null;
		}
		if (string.IsNullOrEmpty(characterPackageData.id))
		{
			characterPackageData.id = Path.GetFileName(a);
		}
		if (characterPackageData.krk)
		{
			return ea.chj(a, characterPackageData, out b);
		}
		return ea.chi(a, characterPackageData, out b);
	}

	// Token: 0x06000A84 RID: 2692 RVA: 0x0003DA40 File Offset: 0x0003BC40
	private static void egu(CatCharacterDefinition a, string b)
	{
		string text = Path.Combine(b, a.cxx());
		if (!File.Exists(text))
		{
			return;
		}
		byte[] array = File.ReadAllBytes(text);
		Texture2D texture2D = new Texture2D(2, 2, TextureFormat.RGBA32, false);
		if (texture2D.LoadImage(array))
		{
			a.previewIcon = Sprite.Create(texture2D, new Rect(-4775f, -5914f, (float)texture2D.width, (float)texture2D.height), new Vector2(-3151f, 4449f));
			return;
		}
		global::UnityEngine.Object.Destroy(texture2D);
	}

	// Token: 0x06000A85 RID: 2693 RVA: 0x0003DABC File Offset: 0x0003BCBC
	public static CatCharacterDefinition chh(string a, out string b)
	{
		b = null;
		string text = Path.Combine(a, a.cxy());
		if (!File.Exists(text))
		{
			b = a.cxz() + a;
			return null;
		}
		string text2 = File.ReadAllText(text);
		CharacterPackageData characterPackageData;
		try
		{
			characterPackageData = JsonUtility.FromJson<CharacterPackageData>(text2);
		}
		catch (Exception ex)
		{
			b = a.cya() + ex.Message;
			return null;
		}
		if (characterPackageData == null)
		{
			b = a.cyb();
			return null;
		}
		string text3;
		if (!characterPackageData.chg(out text3))
		{
			b = a.cyc() + text3;
			return null;
		}
		if (string.IsNullOrEmpty(characterPackageData.id))
		{
			characterPackageData.id = Path.GetFileName(a);
		}
		if (characterPackageData.krk)
		{
			return ea.chj(a, characterPackageData, out b);
		}
		return ea.chi(a, characterPackageData, out b);
	}

	// Token: 0x06000A86 RID: 2694 RVA: 0x0003DB84 File Offset: 0x0003BD84
	public static CatCharacterDefinition jkg(string a, out string b)
	{
		b = null;
		string text = Path.Combine(a, a.cyd());
		if (!File.Exists(text))
		{
			b = a.cye() + a;
			return null;
		}
		string text2 = File.ReadAllText(text);
		CharacterPackageData characterPackageData;
		try
		{
			characterPackageData = JsonUtility.FromJson<CharacterPackageData>(text2);
		}
		catch (Exception ex)
		{
			b = a.cyf() + ex.Message;
			return null;
		}
		if (characterPackageData == null)
		{
			b = a.cyg();
			return null;
		}
		string text3;
		if (!characterPackageData.chg(out text3))
		{
			b = a.cyh() + text3;
			return null;
		}
		if (string.IsNullOrEmpty(characterPackageData.id))
		{
			characterPackageData.id = Path.GetFileName(a);
		}
		if (characterPackageData.krk)
		{
			return ea.chj(a, characterPackageData, out b);
		}
		return ea.chi(a, characterPackageData, out b);
	}

	// Token: 0x06000A87 RID: 2695 RVA: 0x0003DC4C File Offset: 0x0003BE4C
	public static CatCharacterDefinition nil(string a, out string b)
	{
		b = null;
		string text = Path.Combine(a, a.cyi());
		if (!File.Exists(text))
		{
			b = a.cyj() + a;
			return null;
		}
		string text2 = File.ReadAllText(text);
		CharacterPackageData characterPackageData;
		try
		{
			characterPackageData = JsonUtility.FromJson<CharacterPackageData>(text2);
		}
		catch (Exception ex)
		{
			b = a.cyk() + ex.Message;
			return null;
		}
		if (characterPackageData == null)
		{
			b = a.cyl();
			return null;
		}
		string text3;
		if (!characterPackageData.chg(out text3))
		{
			b = a.cym() + text3;
			return null;
		}
		if (string.IsNullOrEmpty(characterPackageData.id))
		{
			characterPackageData.id = Path.GetFileName(a);
		}
		if (characterPackageData.krk)
		{
			return ea.chj(a, characterPackageData, out b);
		}
		return ea.chi(a, characterPackageData, out b);
	}

	// Token: 0x04000858 RID: 2136
	private const long idi = 10485760L;

	// Token: 0x04000859 RID: 2137
	private const int idj = 4096;
}
