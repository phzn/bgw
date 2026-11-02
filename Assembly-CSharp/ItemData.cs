using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Steamworks;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

// Token: 0x0200006B RID: 107
[Serializable]
public class ItemData
{
	// Token: 0x0600050D RID: 1293 RVA: 0x00002854 File Offset: 0x00000A54
	public ItemData()
	{
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x0001A2E4 File Offset: 0x000184E4
	public ItemData(SteamItemDetails_t details)
	{
		this.itemId = details.m_itemId.m_SteamItemInstanceID;
		this.defID = details.m_iDefinition.m_SteamItemDef;
		this.quantity = (uint)details.m_unQuantity;
		this.flags = (ESteamItemFlags)details.m_unFlags;
		this.name = ItemData.biu(details.m_iDefinition, a.bdh(), 256U);
		this.name_german = ItemData.biu(details.m_iDefinition, a.bdi(), 256U);
		this.name_french = ItemData.biu(details.m_iDefinition, a.bdj(), 256U);
		this.name_spanish = ItemData.biu(details.m_iDefinition, a.bdk(), 256U);
		this.name_schinese = ItemData.biu(details.m_iDefinition, a.bdl(), 256U);
		this.name_tchinese = ItemData.biu(details.m_iDefinition, a.bdm(), 256U);
		this.name_russian = ItemData.biu(details.m_iDefinition, a.bdn(), 256U);
		this.name_japanese = ItemData.biu(details.m_iDefinition, a.bdo(), 256U);
		this.name_portuguese = ItemData.biu(details.m_iDefinition, a.bdp(), 256U);
		this.description = ItemData.biu(details.m_iDefinition, a.bdq(), 512U);
		this.description_german = ItemData.biu(details.m_iDefinition, a.bdr(), 512U);
		this.description_french = ItemData.biu(details.m_iDefinition, a.bds(), 512U);
		this.description_spanish = ItemData.biu(details.m_iDefinition, a.bdt(), 512U);
		this.description_schinese = ItemData.biu(details.m_iDefinition, a.bdu(), 512U);
		this.description_tchinese = ItemData.biu(details.m_iDefinition, a.bdv(), 512U);
		this.description_russian = ItemData.biu(details.m_iDefinition, a.bdw(), 512U);
		this.description_japanese = ItemData.biu(details.m_iDefinition, a.bdx(), 512U);
		this.description_portuguese = ItemData.biu(details.m_iDefinition, a.bdy(), 512U);
		this.category = ItemData.biu(details.m_iDefinition, a.bdz(), 256U);
		this.rarity = ItemData.biu(details.m_iDefinition, a.bea(), 256U);
		this.name_color = ItemData.biu(details.m_iDefinition, a.beb(), 256U);
		this.background_color = ItemData.biu(details.m_iDefinition, a.bec(), 256U);
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x0001A583 File Offset: 0x00018783
	public Sprite bio()
	{
		if (!(bq.hle != null))
		{
			return null;
		}
		SpineSkinData spineSkinData = bq.hle.bjx(this.defID);
		if (spineSkinData == null)
		{
			return null;
		}
		return spineSkinData.icon;
	}

	// Token: 0x06000510 RID: 1296 RVA: 0x0001A5B0 File Offset: 0x000187B0
	public Color bip()
	{
		Color color;
		if (ColorUtility.TryParseHtmlString(this.name_color, out color))
		{
			return color;
		}
		return Color.white;
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x0001A5D4 File Offset: 0x000187D4
	public Color biq()
	{
		SpineSkinSetting hle = bq.hle;
		if (hle != null && hle.bjw(this.rarity))
		{
			return hle.bjv(this.rarity);
		}
		Color color;
		if (ColorUtility.TryParseHtmlString(this.background_color, out color))
		{
			return color;
		}
		if (!(hle != null))
		{
			return Color.gray;
		}
		return hle.defaultBackgroundColor;
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x0001A631 File Offset: 0x00018831
	public string bir()
	{
		return this.bit(true);
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x0001A63A File Offset: 0x0001883A
	public string bis()
	{
		return this.bit(false);
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x0001A644 File Offset: 0x00018844
	private string bit(bool a)
	{
		Locale selectedLocale = LocalizationSettings.SelectedLocale;
		string text = ((selectedLocale != null) ? selectedLocale.Identifier.Code : null);
		uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
		string text2;
		if (num <= 1461901041U)
		{
			if (num <= 1176137065U)
			{
				if (num != 89862570U)
				{
					if (num == 1176137065U)
					{
						if (text == a.bef())
						{
							text2 = (a ? this.name_spanish : this.description_spanish);
							goto IL_01F8;
						}
					}
				}
				else if (text == a.oq())
				{
					text2 = (a ? this.name_schinese : this.description_schinese);
					goto IL_01F8;
				}
			}
			else if (num != 1213488160U)
			{
				if (num == 1461901041U)
				{
					if (text == a.bee())
					{
						text2 = (a ? this.name_french : this.description_french);
						goto IL_01F8;
					}
				}
			}
			else if (text == a.beg())
			{
				text2 = (a ? this.name_russian : this.description_russian);
				goto IL_01F8;
			}
		}
		else if (num <= 1664981344U)
		{
			if (num != 1545391778U)
			{
				if (num == 1664981344U)
				{
					if (text == a.beh())
					{
						text2 = (a ? this.name_portuguese : this.description_portuguese);
						goto IL_01F8;
					}
				}
			}
			else if (text == a.bed())
			{
				text2 = (a ? this.name_german : this.description_german);
				goto IL_01F8;
			}
		}
		else if (num != 1816099348U)
		{
			if (num == 3973517379U)
			{
				if (text == a.op())
				{
					text2 = (a ? this.name_tchinese : this.description_tchinese);
					goto IL_01F8;
				}
			}
		}
		else if (text == a.or())
		{
			text2 = (a ? this.name_japanese : this.description_japanese);
			goto IL_01F8;
		}
		text2 = null;
		IL_01F8:
		string text3 = text2;
		if (!string.IsNullOrEmpty(text3))
		{
			return text3;
		}
		if (!a)
		{
			return this.description;
		}
		return this.name;
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x0001A868 File Offset: 0x00018A68
	private static string biu(SteamItemDef_t a, string b, uint c = 256U)
	{
		string text;
		if (SteamInventory.GetItemDefinitionProperty(a, b, out text, ref c))
		{
			return text;
		}
		return string.Empty;
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x0001A88C File Offset: 0x00018A8C
	public static ItemData biv(int a)
	{
		SteamItemDef_t steamItemDef_t = new SteamItemDef_t(a);
		return new ItemData
		{
			defID = a,
			name = ItemData.biu(steamItemDef_t, a.bdh(), 256U),
			name_german = ItemData.biu(steamItemDef_t, a.bdi(), 256U),
			name_french = ItemData.biu(steamItemDef_t, a.bdj(), 256U),
			name_spanish = ItemData.biu(steamItemDef_t, a.bdk(), 256U),
			name_schinese = ItemData.biu(steamItemDef_t, a.bdl(), 256U),
			name_tchinese = ItemData.biu(steamItemDef_t, a.bdm(), 256U),
			name_russian = ItemData.biu(steamItemDef_t, a.bdn(), 256U),
			name_japanese = ItemData.biu(steamItemDef_t, a.bdo(), 256U),
			name_portuguese = ItemData.biu(steamItemDef_t, a.bdp(), 256U)
		};
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x0001A974 File Offset: 0x00018B74
	public override string ToString()
	{
		return string.Format(a.bei(), new object[] { this.name, this.itemId, this.defID, this.quantity, this.category, this.rarity });
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x0001A9D8 File Offset: 0x00018BD8
	public void biw(ItemData a)
	{
		if (a == null)
		{
			return;
		}
		a.itemId = this.itemId;
		a.defID = this.defID;
		a.quantity = this.quantity;
		a.category = this.category;
		a.rarity = this.rarity;
		a.name_color = this.name_color;
		a.background_color = this.background_color;
		a.name = this.name;
		a.name_german = this.name_german;
		a.name_french = this.name_french;
		a.name_spanish = this.name_spanish;
		a.name_schinese = this.name_schinese;
		a.name_tchinese = this.name_tchinese;
		a.name_russian = this.name_russian;
		a.name_japanese = this.name_japanese;
		a.name_portuguese = this.name_portuguese;
		a.description = this.description;
		a.description_german = this.description_german;
		a.description_french = this.description_french;
		a.description_spanish = this.description_spanish;
		a.description_schinese = this.description_schinese;
		a.description_tchinese = this.description_tchinese;
		a.description_russian = this.description_russian;
		a.description_japanese = this.description_japanese;
		a.description_portuguese = this.description_portuguese;
		a.flags = this.flags;
	}

	// Token: 0x040004C6 RID: 1222
	public ulong itemId;

	// Token: 0x040004C7 RID: 1223
	public int defID;

	// Token: 0x040004C8 RID: 1224
	public uint quantity;

	// Token: 0x040004C9 RID: 1225
	public string category;

	// Token: 0x040004CA RID: 1226
	public string rarity;

	// Token: 0x040004CB RID: 1227
	public string name_color;

	// Token: 0x040004CC RID: 1228
	public string background_color;

	// Token: 0x040004CD RID: 1229
	public string name;

	// Token: 0x040004CE RID: 1230
	public string name_german;

	// Token: 0x040004CF RID: 1231
	public string name_french;

	// Token: 0x040004D0 RID: 1232
	public string name_spanish;

	// Token: 0x040004D1 RID: 1233
	public string name_schinese;

	// Token: 0x040004D2 RID: 1234
	public string name_tchinese;

	// Token: 0x040004D3 RID: 1235
	public string name_russian;

	// Token: 0x040004D4 RID: 1236
	public string name_japanese;

	// Token: 0x040004D5 RID: 1237
	public string name_portuguese;

	// Token: 0x040004D6 RID: 1238
	public string description;

	// Token: 0x040004D7 RID: 1239
	public string description_german;

	// Token: 0x040004D8 RID: 1240
	public string description_french;

	// Token: 0x040004D9 RID: 1241
	public string description_spanish;

	// Token: 0x040004DA RID: 1242
	public string description_schinese;

	// Token: 0x040004DB RID: 1243
	public string description_tchinese;

	// Token: 0x040004DC RID: 1244
	public string description_russian;

	// Token: 0x040004DD RID: 1245
	public string description_japanese;

	// Token: 0x040004DE RID: 1246
	public string description_portuguese;

	// Token: 0x040004DF RID: 1247
	public ESteamItemFlags flags;
}
