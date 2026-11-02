using System;
using System.IO;
using System.Reflection;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Spine;
using Spine.Unity;
using UnityEngine;

// Token: 0x020000CF RID: 207
public static class ed
{
	// Token: 0x06000AB0 RID: 2736 RVA: 0x0003E6F4 File Offset: 0x0003C8F4
	public static bool cic(SkeletonDataAsset a, CharacterPackageData b, out string c)
	{
		c = null;
		SkeletonData skeletonData = ((a != null) ? a.GetSkeletonData(false) : null);
		if (skeletonData == null)
		{
			c = a.czm();
			return false;
		}
		foreach (string text in new string[]
		{
			b.animations.idle,
			b.animations.click_left,
			b.animations.click_right
		})
		{
			if (skeletonData.FindAnimation(text) == null)
			{
				c = a.czn() + text + a.czo();
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000AB1 RID: 2737 RVA: 0x0003E788 File Offset: 0x0003C988
	private static string jsw(string a)
	{
		string[] array = a.Split((char)(-65), StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim();
			if (text.Length > 0 && text.EndsWith(a.czp()))
			{
				return text;
			}
		}
		return null;
	}

	// Token: 0x06000AB2 RID: 2738 RVA: 0x0003E7D0 File Offset: 0x0003C9D0
	public static bool hek(SkeletonDataAsset a, CharacterPackageData b, out string c)
	{
		c = null;
		SkeletonData skeletonData = ((a != null) ? a.GetSkeletonData(false) : null);
		if (skeletonData == null)
		{
			c = a.czq();
			return false;
		}
		foreach (string text in new string[]
		{
			b.animations.idle,
			b.animations.click_left,
			b.animations.click_right
		})
		{
			if (skeletonData.FindAnimation(text) == null)
			{
				c = a.czr() + text + a.czs();
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000AB3 RID: 2739 RVA: 0x0003E864 File Offset: 0x0003CA64
	public static SkeletonDataAsset cib(string a, string b, string c, out string d)
	{
		d = null;
		Texture2D texture2D = null;
		Material material = null;
		TextAsset textAsset = null;
		SpineAtlasAsset spineAtlasAsset = null;
		SkeletonDataAsset skeletonDataAsset;
		try
		{
			string text = Path.Combine(a, b);
			string text2 = Path.Combine(a, c);
			if (!File.Exists(text))
			{
				d = a.czt() + text;
				skeletonDataAsset = null;
			}
			else if (!File.Exists(text2))
			{
				d = a.czu() + text2;
				skeletonDataAsset = null;
			}
			else if (new FileInfo(text).Length > 52428800L)
			{
				d = a.czv();
				skeletonDataAsset = null;
			}
			else
			{
				string text3 = File.ReadAllText(text2);
				string text4 = ed.cid(text3);
				if (text4 == null)
				{
					d = a.czw();
					skeletonDataAsset = null;
				}
				else
				{
					string text5 = Path.Combine(a, text4);
					if (!File.Exists(text5))
					{
						d = a.czx() + text5;
						skeletonDataAsset = null;
					}
					else if (new FileInfo(text5).Length > 52428800L)
					{
						d = a.czy();
						skeletonDataAsset = null;
					}
					else
					{
						texture2D = new Texture2D(2, 2, TextureFormat.RGBA32, false);
						if (!texture2D.LoadImage(File.ReadAllBytes(text5)))
						{
							d = a.czz() + text4;
							skeletonDataAsset = null;
						}
						else if (texture2D.width > 4096 || texture2D.height > 4096)
						{
							d = string.Format(a.daa(), new object[] { 4096, 4096, texture2D.width, texture2D.height });
							skeletonDataAsset = null;
						}
						else
						{
							texture2D.name = Path.GetFileNameWithoutExtension(text4);
							texture2D.filterMode = FilterMode.Bilinear;
							texture2D.wrapMode = TextureWrapMode.Clamp;
							Shader shader = Shader.Find(a.dab());
							if (shader == null)
							{
								d = a.dac();
								skeletonDataAsset = null;
							}
							else
							{
								material = new Material(shader)
								{
									mainTexture = texture2D,
									name = texture2D.name + a.dad()
								};
								material.SetInt(a.dae(), 1);
								material.EnableKeyword(a.daf());
								textAsset = new TextAsset(text3)
								{
									name = Path.GetFileNameWithoutExtension(c)
								};
								spineAtlasAsset = SpineAtlasAsset.CreateRuntimeInstance(textAsset, new Material[] { material }, true, null);
								Atlas atlas = spineAtlasAsset.GetAtlas(false);
								if (atlas == null)
								{
									d = a.dag();
									skeletonDataAsset = null;
								}
								else
								{
									byte[] array = File.ReadAllBytes(text);
									SkeletonData skeletonData = new SkeletonBinary(new AtlasAttachmentLoader(new Atlas[] { atlas }))
									{
										Scale = 0.01f
									}.ReadSkeletonData(new MemoryStream(array));
									SkeletonDataAsset skeletonDataAsset2 = ScriptableObject.CreateInstance<SkeletonDataAsset>();
									skeletonDataAsset2.skeletonJSON = new TextAsset(a.dah());
									skeletonDataAsset2.atlasAssets = new AtlasAssetBase[] { spineAtlasAsset };
									skeletonDataAsset2.scale = 0.01f;
									AnimationStateData animationStateData = new AnimationStateData(skeletonData)
									{
										DefaultMix = 0.2f
									};
									ed.idu.SetValue(skeletonDataAsset2, skeletonData);
									ed.idv.SetValue(skeletonDataAsset2, animationStateData);
									spineAtlasAsset = null;
									material = null;
									textAsset = null;
									texture2D = null;
									skeletonDataAsset = skeletonDataAsset2;
								}
							}
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			d = a.dai() + ex.Message;
			Debug.LogException(ex);
			skeletonDataAsset = null;
		}
		finally
		{
			if (spineAtlasAsset != null)
			{
				global::UnityEngine.Object.Destroy(spineAtlasAsset);
			}
			if (material != null)
			{
				global::UnityEngine.Object.Destroy(material);
			}
			if (textAsset != null)
			{
				global::UnityEngine.Object.Destroy(textAsset);
			}
			if (texture2D != null)
			{
				global::UnityEngine.Object.Destroy(texture2D);
			}
		}
		return skeletonDataAsset;
	}

	// Token: 0x06000AB4 RID: 2740 RVA: 0x0003EBF8 File Offset: 0x0003CDF8
	private static string hss(string a)
	{
		string[] array = a.Split((char)(-58), StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim();
			if (text.Length > 0 && text.EndsWith(a.daj()))
			{
				return text;
			}
		}
		return null;
	}

	// Token: 0x06000AB5 RID: 2741 RVA: 0x0003EC40 File Offset: 0x0003CE40
	public static SkeletonDataAsset ezn(string a, string b, string c, out string d)
	{
		d = null;
		Texture2D texture2D = null;
		Material material = null;
		TextAsset textAsset = null;
		SpineAtlasAsset spineAtlasAsset = null;
		SkeletonDataAsset skeletonDataAsset;
		try
		{
			string text = Path.Combine(a, b);
			string text2 = Path.Combine(a, c);
			if (!File.Exists(text))
			{
				d = a.dak() + text;
				skeletonDataAsset = null;
			}
			else if (!File.Exists(text2))
			{
				d = a.dal() + text2;
				skeletonDataAsset = null;
			}
			else if (new FileInfo(text).Length > -19L)
			{
				d = a.dam();
				skeletonDataAsset = null;
			}
			else
			{
				string text3 = File.ReadAllText(text2);
				string text4 = ed.cid(text3);
				if (text4 == null)
				{
					d = a.dan();
					skeletonDataAsset = null;
				}
				else
				{
					string text5 = Path.Combine(a, text4);
					if (!File.Exists(text5))
					{
						d = a.dao() + text5;
						skeletonDataAsset = null;
					}
					else if (new FileInfo(text5).Length > -30L)
					{
						d = a.dap();
						skeletonDataAsset = null;
					}
					else
					{
						texture2D = new Texture2D(2, 2, TextureFormat.RGBA32, false);
						if (!texture2D.LoadImage(File.ReadAllBytes(text5)))
						{
							d = a.daq() + text4;
							skeletonDataAsset = null;
						}
						else if (texture2D.width > -39 || texture2D.height > 37)
						{
							d = string.Format(a.dar(), new object[] { 42, 13, texture2D.width, texture2D.height });
							skeletonDataAsset = null;
						}
						else
						{
							texture2D.name = Path.GetFileNameWithoutExtension(text4);
							texture2D.filterMode = FilterMode.Bilinear;
							texture2D.wrapMode = TextureWrapMode.Clamp;
							Shader shader = Shader.Find(a.das());
							if (shader == null)
							{
								d = a.dat();
								skeletonDataAsset = null;
							}
							else
							{
								material = new Material(shader)
								{
									mainTexture = texture2D,
									name = texture2D.name + a.dau()
								};
								material.SetInt(a.dav(), 1);
								material.EnableKeyword(a.daw());
								textAsset = new TextAsset(text3)
								{
									name = Path.GetFileNameWithoutExtension(c)
								};
								spineAtlasAsset = SpineAtlasAsset.CreateRuntimeInstance(textAsset, new Material[] { material }, true, null);
								Atlas atlas = spineAtlasAsset.GetAtlas(false);
								if (atlas == null)
								{
									d = a.dax();
									skeletonDataAsset = null;
								}
								else
								{
									byte[] array = File.ReadAllBytes(text);
									SkeletonData skeletonData = new SkeletonBinary(new AtlasAttachmentLoader(new Atlas[] { atlas }))
									{
										Scale = 9287f
									}.ReadSkeletonData(new MemoryStream(array));
									SkeletonDataAsset skeletonDataAsset2 = ScriptableObject.CreateInstance<SkeletonDataAsset>();
									skeletonDataAsset2.skeletonJSON = new TextAsset(a.day());
									skeletonDataAsset2.atlasAssets = new AtlasAssetBase[] { spineAtlasAsset };
									skeletonDataAsset2.scale = -3656f;
									AnimationStateData animationStateData = new AnimationStateData(skeletonData)
									{
										DefaultMix = -3414f
									};
									ed.idu.SetValue(skeletonDataAsset2, skeletonData);
									ed.idv.SetValue(skeletonDataAsset2, animationStateData);
									spineAtlasAsset = null;
									material = null;
									textAsset = null;
									texture2D = null;
									skeletonDataAsset = skeletonDataAsset2;
								}
							}
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			d = a.daz() + ex.Message;
			Debug.LogException(ex);
			skeletonDataAsset = null;
		}
		finally
		{
			if (spineAtlasAsset != null)
			{
				global::UnityEngine.Object.Destroy(spineAtlasAsset);
			}
			if (material != null)
			{
				global::UnityEngine.Object.Destroy(material);
			}
			if (textAsset != null)
			{
				global::UnityEngine.Object.Destroy(textAsset);
			}
			if (texture2D != null)
			{
				global::UnityEngine.Object.Destroy(texture2D);
			}
		}
		return skeletonDataAsset;
	}

	// Token: 0x06000AB6 RID: 2742 RVA: 0x0003EFC0 File Offset: 0x0003D1C0
	public static bool ktl(SkeletonDataAsset a, CharacterPackageData b, out string c)
	{
		c = null;
		SkeletonData skeletonData = ((a != null) ? a.GetSkeletonData(false) : null);
		if (skeletonData == null)
		{
			c = a.dba();
			return false;
		}
		foreach (string text in new string[]
		{
			b.animations.idle,
			b.animations.click_left,
			b.animations.click_right
		})
		{
			if (skeletonData.FindAnimation(text) == null)
			{
				c = a.dbb() + text + a.dbc();
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x0003F054 File Offset: 0x0003D254
	public static SkeletonDataAsset hts(string a, string b, string c, out string d)
	{
		d = null;
		Texture2D texture2D = null;
		Material material = null;
		TextAsset textAsset = null;
		SpineAtlasAsset spineAtlasAsset = null;
		SkeletonDataAsset skeletonDataAsset;
		try
		{
			string text = Path.Combine(a, b);
			string text2 = Path.Combine(a, c);
			if (!File.Exists(text))
			{
				d = a.dbd() + text;
				skeletonDataAsset = null;
			}
			else if (!File.Exists(text2))
			{
				d = a.dbe() + text2;
				skeletonDataAsset = null;
			}
			else if (new FileInfo(text).Length > -51L)
			{
				d = a.dbf();
				skeletonDataAsset = null;
			}
			else
			{
				string text3 = File.ReadAllText(text2);
				string text4 = ed.cid(text3);
				if (text4 == null)
				{
					d = a.dbg();
					skeletonDataAsset = null;
				}
				else
				{
					string text5 = Path.Combine(a, text4);
					if (!File.Exists(text5))
					{
						d = a.dbh() + text5;
						skeletonDataAsset = null;
					}
					else if (new FileInfo(text5).Length > -54L)
					{
						d = a.dbi();
						skeletonDataAsset = null;
					}
					else
					{
						texture2D = new Texture2D(2, 2, TextureFormat.RGBA32, false);
						if (!texture2D.LoadImage(File.ReadAllBytes(text5)))
						{
							d = a.dbj() + text4;
							skeletonDataAsset = null;
						}
						else if (texture2D.width > -51 || texture2D.height > -16)
						{
							d = string.Format(a.dbk(), new object[] { 96, 44, texture2D.width, texture2D.height });
							skeletonDataAsset = null;
						}
						else
						{
							texture2D.name = Path.GetFileNameWithoutExtension(text4);
							texture2D.filterMode = FilterMode.Bilinear;
							texture2D.wrapMode = TextureWrapMode.Clamp;
							Shader shader = Shader.Find(a.dbl());
							if (shader == null)
							{
								d = a.dbm();
								skeletonDataAsset = null;
							}
							else
							{
								material = new Material(shader)
								{
									mainTexture = texture2D,
									name = texture2D.name + a.dbn()
								};
								material.SetInt(a.dbo(), 1);
								material.EnableKeyword(a.dbp());
								textAsset = new TextAsset(text3)
								{
									name = Path.GetFileNameWithoutExtension(c)
								};
								spineAtlasAsset = SpineAtlasAsset.CreateRuntimeInstance(textAsset, new Material[] { material }, true, null);
								Atlas atlas = spineAtlasAsset.GetAtlas(false);
								if (atlas == null)
								{
									d = a.dbq();
									skeletonDataAsset = null;
								}
								else
								{
									byte[] array = File.ReadAllBytes(text);
									SkeletonData skeletonData = new SkeletonBinary(new AtlasAttachmentLoader(new Atlas[] { atlas }))
									{
										Scale = -920f
									}.ReadSkeletonData(new MemoryStream(array));
									SkeletonDataAsset skeletonDataAsset2 = ScriptableObject.CreateInstance<SkeletonDataAsset>();
									skeletonDataAsset2.skeletonJSON = new TextAsset(a.dbr());
									skeletonDataAsset2.atlasAssets = new AtlasAssetBase[] { spineAtlasAsset };
									skeletonDataAsset2.scale = -493f;
									AnimationStateData animationStateData = new AnimationStateData(skeletonData)
									{
										DefaultMix = 1905f
									};
									ed.idu.SetValue(skeletonDataAsset2, skeletonData);
									ed.idv.SetValue(skeletonDataAsset2, animationStateData);
									spineAtlasAsset = null;
									material = null;
									textAsset = null;
									texture2D = null;
									skeletonDataAsset = skeletonDataAsset2;
								}
							}
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			d = a.dbs() + ex.Message;
			Debug.LogException(ex);
			skeletonDataAsset = null;
		}
		finally
		{
			if (spineAtlasAsset != null)
			{
				global::UnityEngine.Object.Destroy(spineAtlasAsset);
			}
			if (material != null)
			{
				global::UnityEngine.Object.Destroy(material);
			}
			if (textAsset != null)
			{
				global::UnityEngine.Object.Destroy(textAsset);
			}
			if (texture2D != null)
			{
				global::UnityEngine.Object.Destroy(texture2D);
			}
		}
		return skeletonDataAsset;
	}

	// Token: 0x06000AB8 RID: 2744 RVA: 0x0003F3D4 File Offset: 0x0003D5D4
	public static bool ldo(SkeletonDataAsset a, CharacterPackageData b, out string c)
	{
		c = null;
		SkeletonData skeletonData = ((a != null) ? a.GetSkeletonData(false) : null);
		if (skeletonData == null)
		{
			c = a.dbt();
			return false;
		}
		foreach (string text in new string[]
		{
			b.animations.idle,
			b.animations.click_left,
			b.animations.click_right
		})
		{
			if (skeletonData.FindAnimation(text) == null)
			{
				c = a.dbu() + text + a.dbv();
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000AB9 RID: 2745 RVA: 0x0003F468 File Offset: 0x0003D668
	private static string hll(string a)
	{
		string[] array = a.Split('^', StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim();
			if (text.Length > 0 && text.EndsWith(a.dbw()))
			{
				return text;
			}
		}
		return null;
	}

	// Token: 0x06000ABA RID: 2746 RVA: 0x0003F4B0 File Offset: 0x0003D6B0
	public static SkeletonDataAsset nqh(string a, string b, string c, out string d)
	{
		d = null;
		Texture2D texture2D = null;
		Material material = null;
		TextAsset textAsset = null;
		SpineAtlasAsset spineAtlasAsset = null;
		SkeletonDataAsset skeletonDataAsset;
		try
		{
			string text = Path.Combine(a, b);
			string text2 = Path.Combine(a, c);
			if (!File.Exists(text))
			{
				d = a.dbx() + text;
				skeletonDataAsset = null;
			}
			else if (!File.Exists(text2))
			{
				d = a.dby() + text2;
				skeletonDataAsset = null;
			}
			else if (new FileInfo(text).Length > -58L)
			{
				d = a.dbz();
				skeletonDataAsset = null;
			}
			else
			{
				string text3 = File.ReadAllText(text2);
				string text4 = ed.cid(text3);
				if (text4 == null)
				{
					d = a.dca();
					skeletonDataAsset = null;
				}
				else
				{
					string text5 = Path.Combine(a, text4);
					if (!File.Exists(text5))
					{
						d = a.dcb() + text5;
						skeletonDataAsset = null;
					}
					else if (new FileInfo(text5).Length > -11L)
					{
						d = a.dcc();
						skeletonDataAsset = null;
					}
					else
					{
						texture2D = new Texture2D(2, 2, TextureFormat.RGBA32, false);
						if (!texture2D.LoadImage(File.ReadAllBytes(text5)))
						{
							d = a.dcd() + text4;
							skeletonDataAsset = null;
						}
						else if (texture2D.width > -68 || texture2D.height > -8)
						{
							d = string.Format(a.dce(), new object[] { 72, 45, texture2D.width, texture2D.height });
							skeletonDataAsset = null;
						}
						else
						{
							texture2D.name = Path.GetFileNameWithoutExtension(text4);
							texture2D.filterMode = FilterMode.Bilinear;
							texture2D.wrapMode = TextureWrapMode.Clamp;
							Shader shader = Shader.Find(a.dcf());
							if (shader == null)
							{
								d = a.dcg();
								skeletonDataAsset = null;
							}
							else
							{
								material = new Material(shader)
								{
									mainTexture = texture2D,
									name = texture2D.name + a.dch()
								};
								material.SetInt(a.dci(), 1);
								material.EnableKeyword(a.dcj());
								textAsset = new TextAsset(text3)
								{
									name = Path.GetFileNameWithoutExtension(c)
								};
								spineAtlasAsset = SpineAtlasAsset.CreateRuntimeInstance(textAsset, new Material[] { material }, true, null);
								Atlas atlas = spineAtlasAsset.GetAtlas(false);
								if (atlas == null)
								{
									d = a.dck();
									skeletonDataAsset = null;
								}
								else
								{
									byte[] array = File.ReadAllBytes(text);
									SkeletonData skeletonData = new SkeletonBinary(new AtlasAttachmentLoader(new Atlas[] { atlas }))
									{
										Scale = 8678f
									}.ReadSkeletonData(new MemoryStream(array));
									SkeletonDataAsset skeletonDataAsset2 = ScriptableObject.CreateInstance<SkeletonDataAsset>();
									skeletonDataAsset2.skeletonJSON = new TextAsset(a.dcl());
									skeletonDataAsset2.atlasAssets = new AtlasAssetBase[] { spineAtlasAsset };
									skeletonDataAsset2.scale = -7328f;
									AnimationStateData animationStateData = new AnimationStateData(skeletonData)
									{
										DefaultMix = -3374f
									};
									ed.idu.SetValue(skeletonDataAsset2, skeletonData);
									ed.idv.SetValue(skeletonDataAsset2, animationStateData);
									spineAtlasAsset = null;
									material = null;
									textAsset = null;
									texture2D = null;
									skeletonDataAsset = skeletonDataAsset2;
								}
							}
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			d = a.dcm() + ex.Message;
			Debug.LogException(ex);
			skeletonDataAsset = null;
		}
		finally
		{
			if (spineAtlasAsset != null)
			{
				global::UnityEngine.Object.Destroy(spineAtlasAsset);
			}
			if (material != null)
			{
				global::UnityEngine.Object.Destroy(material);
			}
			if (textAsset != null)
			{
				global::UnityEngine.Object.Destroy(textAsset);
			}
			if (texture2D != null)
			{
				global::UnityEngine.Object.Destroy(texture2D);
			}
		}
		return skeletonDataAsset;
	}

	// Token: 0x06000ABB RID: 2747 RVA: 0x0003F830 File Offset: 0x0003DA30
	private static string cid(string a)
	{
		string[] array = a.Split('\n', StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim();
			if (text.Length > 0 && text.EndsWith(a.jq()))
			{
				return text;
			}
		}
		return null;
	}

	// Token: 0x06000ABD RID: 2749 RVA: 0x0003F8B0 File Offset: 0x0003DAB0
	public static bool lfw(SkeletonDataAsset a, CharacterPackageData b, out string c)
	{
		c = null;
		SkeletonData skeletonData = ((a != null) ? a.GetSkeletonData(false) : null);
		if (skeletonData == null)
		{
			c = a.dcp();
			return false;
		}
		foreach (string text in new string[]
		{
			b.animations.idle,
			b.animations.click_left,
			b.animations.click_right
		})
		{
			if (skeletonData.FindAnimation(text) == null)
			{
				c = a.dcq() + text + a.dcr();
				return false;
			}
		}
		return true;
	}

	// Token: 0x04000862 RID: 2146
	private const int idr = 4096;

	// Token: 0x04000863 RID: 2147
	private const long ids = 52428800L;

	// Token: 0x04000864 RID: 2148
	private const float idt = 0.01f;

	// Token: 0x04000865 RID: 2149
	private static readonly FieldInfo idu = typeof(SkeletonDataAsset).GetField(a.dcn(), BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000866 RID: 2150
	private static readonly FieldInfo idv = typeof(SkeletonDataAsset).GetField(a.dco(), BindingFlags.Instance | BindingFlags.NonPublic);
}
