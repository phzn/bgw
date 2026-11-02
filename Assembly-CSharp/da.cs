using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

// Token: 0x02000098 RID: 152
public static class da
{
	// Token: 0x060006C5 RID: 1733 RVA: 0x00025668 File Offset: 0x00023868
	private static string cou(string a)
	{
		string text2;
		try
		{
			StringTable table = LocalizationSettings.StringDatabase.GetTable(a.bir(), null);
			StringTableEntry stringTableEntry = ((table != null) ? table.GetEntry(a) : null);
			string text = ((stringTableEntry != null) ? stringTableEntry.GetLocalizedString() : null);
			text2 = (string.IsNullOrEmpty(text) ? null : text);
		}
		catch
		{
			text2 = null;
		}
		return text2;
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x000256CC File Offset: 0x000238CC
	private static string bsm(string a)
	{
		string text2;
		try
		{
			StringTable table = LocalizationSettings.StringDatabase.GetTable(a.bhh(), null);
			StringTableEntry stringTableEntry = ((table != null) ? table.GetEntry(a) : null);
			string text = ((stringTableEntry != null) ? stringTableEntry.GetLocalizedString() : null);
			text2 = (string.IsNullOrEmpty(text) ? null : text);
		}
		catch
		{
			text2 = null;
		}
		return text2;
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x00025730 File Offset: 0x00023930
	public static string jl(SpineSkinData a)
	{
		if (a == null || a.kox == 0)
		{
			return null;
		}
		ItemData itemData = da.bsl(a.kox);
		string text = ((itemData != null) ? itemData.bir() : null);
		if (string.IsNullOrEmpty(text))
		{
			text = ItemData.biv(a.kox).bir();
		}
		if (string.IsNullOrEmpty(text))
		{
			text = da.bsm(string.Format(a.bis(), a.name));
		}
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return null;
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x000257AC File Offset: 0x000239AC
	public static string ofq(SpineSkinData a)
	{
		if (a == null || a.kox == 0)
		{
			return null;
		}
		ItemData itemData = da.bsl(a.kox);
		string text = ((itemData != null) ? itemData.bir() : null);
		if (string.IsNullOrEmpty(text))
		{
			text = ItemData.biv(a.kox).bir();
		}
		if (string.IsNullOrEmpty(text))
		{
			text = da.bsm(string.Format(a.bit(), a.name));
		}
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return null;
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x00025828 File Offset: 0x00023A28
	private static ItemData bsl(int a)
	{
		ItemData[] hlj = bq.hlj;
		if (hlj == null)
		{
			return null;
		}
		foreach (ItemData itemData in hlj)
		{
			if (itemData != null && itemData.defID == a)
			{
				return itemData;
			}
		}
		return null;
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x00025864 File Offset: 0x00023A64
	public static string bsk(SpineSkinData a)
	{
		if (a == null || a.kox == 0)
		{
			return null;
		}
		ItemData itemData = da.bsl(a.kox);
		string text = ((itemData != null) ? itemData.bir() : null);
		if (string.IsNullOrEmpty(text))
		{
			text = ItemData.biv(a.kox).bir();
		}
		if (string.IsNullOrEmpty(text))
		{
			text = da.bsm(string.Format(a.biu(), a.name));
		}
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return null;
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x000258E0 File Offset: 0x00023AE0
	private static ItemData kfz(int a)
	{
		ItemData[] hlj = bq.hlj;
		if (hlj == null)
		{
			return null;
		}
		foreach (ItemData itemData in hlj)
		{
			if (itemData != null && itemData.defID == a)
			{
				return itemData;
			}
		}
		return null;
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x0002591C File Offset: 0x00023B1C
	public static string mah(SpineSkinData a)
	{
		if (a == null || a.kox == 0)
		{
			return null;
		}
		ItemData itemData = da.bsl(a.kox);
		string text = ((itemData != null) ? itemData.bir() : null);
		if (string.IsNullOrEmpty(text))
		{
			text = ItemData.biv(a.kox).bir();
		}
		if (string.IsNullOrEmpty(text))
		{
			text = da.bsm(string.Format(a.biv(), a.name));
		}
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return null;
	}

	// Token: 0x04000689 RID: 1673
	private const string hwe = "Item";
}
