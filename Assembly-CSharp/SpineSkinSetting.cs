using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x02000076 RID: 118
[CreateAssetMenu(fileName = "SpineSkinSetting", menuName = "Scriptable Objects/SpineSkinSetting")]
public class SpineSkinSetting : ScriptableObject
{
	// Token: 0x06000538 RID: 1336 RVA: 0x0001C2A4 File Offset: 0x0001A4A4
	public Color bjv(string a)
	{
		if (string.IsNullOrEmpty(a) || this.rarityColorEntries == null)
		{
			return this.defaultBackgroundColor;
		}
		for (int i = 0; i < this.rarityColorEntries.Count; i++)
		{
			RarityColorEntry rarityColorEntry = this.rarityColorEntries[i];
			if (rarityColorEntry != null && !string.IsNullOrEmpty(rarityColorEntry.rarity) && string.Equals(rarityColorEntry.rarity, a, StringComparison.OrdinalIgnoreCase))
			{
				return rarityColorEntry.backgroundColor;
			}
		}
		return this.defaultBackgroundColor;
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x0001C318 File Offset: 0x0001A518
	public bool bjw(string a)
	{
		if (string.IsNullOrEmpty(a) || this.rarityColorEntries == null)
		{
			return false;
		}
		for (int i = 0; i < this.rarityColorEntries.Count; i++)
		{
			RarityColorEntry rarityColorEntry = this.rarityColorEntries[i];
			if (rarityColorEntry != null && !string.IsNullOrEmpty(rarityColorEntry.rarity) && string.Equals(rarityColorEntry.rarity, a, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x0001C37C File Offset: 0x0001A57C
	public SpineSkinData bjx(int a)
	{
		for (int i = 0; i < this.SpineSkinDatas.Count; i++)
		{
			if (this.SpineSkinDatas[i].kox == a)
			{
				return this.SpineSkinDatas[i];
			}
		}
		if (this.CollabSkinDatas != null)
		{
			for (int j = 0; j < this.CollabSkinDatas.Count; j++)
			{
				if (this.CollabSkinDatas[j] != null && this.CollabSkinDatas[j].kox == a)
				{
					return this.CollabSkinDatas[j];
				}
			}
		}
		return null;
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x0001C410 File Offset: 0x0001A610
	public SpineSkinData bjy(int a, CLOTHE_TYPE b)
	{
		if (a == 0)
		{
			return new SpineSkinData
			{
				type = b,
				name = CLOTHE_NAME.Null
			};
		}
		for (int i = 0; i < this.SpineSkinDatas.Count; i++)
		{
			if (this.SpineSkinDatas[i].kox == a)
			{
				return this.SpineSkinDatas[i];
			}
		}
		if (this.CollabSkinDatas != null)
		{
			for (int j = 0; j < this.CollabSkinDatas.Count; j++)
			{
				if (this.CollabSkinDatas[j] != null && this.CollabSkinDatas[j].kox == a)
				{
					return this.CollabSkinDatas[j];
				}
			}
		}
		return null;
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x0001C4B9 File Offset: 0x0001A6B9
	public bool bjz(int a)
	{
		if (this.galleryPurchaseOnlyHiddenItems == null || this.galleryPurchaseOnlyHiddenItems.Count == 0)
		{
			return false;
		}
		if (this._galleryPurchaseOnlyHiddenCache == null)
		{
			this._galleryPurchaseOnlyHiddenCache = new HashSet<int>(this.galleryPurchaseOnlyHiddenItems);
		}
		return this._galleryPurchaseOnlyHiddenCache.Contains(a);
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x0001C4F8 File Offset: 0x0001A6F8
	private void bka(List<SpineSkinData> a, CLOTHE_TYPE b)
	{
		if (this.CollabSkinDatas == null || a == null)
		{
			return;
		}
		for (int i = 0; i < this.CollabSkinDatas.Count; i++)
		{
			SpineSkinData spineSkinData = this.CollabSkinDatas[i];
			if (spineSkinData != null && spineSkinData.type == b)
			{
				a.Add(spineSkinData);
			}
		}
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x0600053E RID: 1342 RVA: 0x0001C548 File Offset: 0x0001A748
	public List<SpineSkinData> kpa
	{
		get
		{
			if (this._dicks != null)
			{
				return this._dicks;
			}
			this._dicks = new List<SpineSkinData>();
			for (int i = 0; i < this.SpineSkinDatas.Count; i++)
			{
				if (this.SpineSkinDatas[i].type == CLOTHE_TYPE.Dick)
				{
					this._dicks.Add(this.SpineSkinDatas[i]);
				}
			}
			this.bka(this._dicks, CLOTHE_TYPE.Dick);
			return this._dicks;
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x0600053F RID: 1343 RVA: 0x0001C5C4 File Offset: 0x0001A7C4
	public List<SpineSkinData> kpb
	{
		get
		{
			if (this._hairs != null)
			{
				return this._hairs;
			}
			this._hairs = new List<SpineSkinData>();
			for (int i = 0; i < this.SpineSkinDatas.Count; i++)
			{
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.ShortHair_Black && this.SpineSkinDatas[i].name < (CLOTHE_NAME)2000)
				{
					this._hairs.Add(this.SpineSkinDatas[i]);
				}
			}
			this.bka(this._hairs, CLOTHE_TYPE.Hair);
			return this._hairs;
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x06000540 RID: 1344 RVA: 0x0001C65C File Offset: 0x0001A85C
	public List<SpineSkinData> kpc
	{
		get
		{
			if (this._tops != null)
			{
				return this._tops;
			}
			this._tops = new List<SpineSkinData>();
			for (int i = 0; i < this.SpineSkinDatas.Count; i++)
			{
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.TShirt_White && this.SpineSkinDatas[i].name < CLOTHE_NAME.DrapedLongSkirt_Black)
				{
					this._tops.Add(this.SpineSkinDatas[i]);
				}
			}
			this.bka(this._tops, CLOTHE_TYPE.Top);
			return this._tops;
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x06000541 RID: 1345 RVA: 0x0001C6F4 File Offset: 0x0001A8F4
	public List<SpineSkinData> kpd
	{
		get
		{
			if (this._bottoms != null)
			{
				return this._bottoms;
			}
			this._bottoms = new List<SpineSkinData>();
			for (int i = 0; i < this.SpineSkinDatas.Count; i++)
			{
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.DrapedLongSkirt_Black && this.SpineSkinDatas[i].name < CLOTHE_NAME.SportsBra_Blue)
				{
					this._bottoms.Add(this.SpineSkinDatas[i]);
				}
			}
			this.bka(this._bottoms, CLOTHE_TYPE.Bottom);
			return this._bottoms;
		}
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x06000542 RID: 1346 RVA: 0x0001C78C File Offset: 0x0001A98C
	public List<SpineSkinData> kpe
	{
		get
		{
			if (this._underwears != null)
			{
				return this._underwears;
			}
			this._underwears = new List<SpineSkinData>();
			for (int i = 0; i < this.SpineSkinDatas.Count; i++)
			{
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.SportsBra_Blue && this.SpineSkinDatas[i].name < (CLOTHE_NAME)6000)
				{
					this._underwears.Add(this.SpineSkinDatas[i]);
				}
			}
			this.bka(this._underwears, CLOTHE_TYPE.Underwear);
			return this._underwears;
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x06000543 RID: 1347 RVA: 0x0001C824 File Offset: 0x0001AA24
	public List<SpineSkinData> kpf
	{
		get
		{
			if (this._socks != null)
			{
				return this._socks;
			}
			this._socks = new List<SpineSkinData>();
			for (int i = 0; i < this.SpineSkinDatas.Count; i++)
			{
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.CrewSocks_White && this.SpineSkinDatas[i].name < CLOTHE_NAME.CanvasShoes_White)
				{
					this._socks.Add(this.SpineSkinDatas[i]);
				}
			}
			this.bka(this._socks, CLOTHE_TYPE.Socks);
			return this._socks;
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x06000544 RID: 1348 RVA: 0x0001C8BC File Offset: 0x0001AABC
	public List<SpineSkinData> kpg
	{
		get
		{
			if (this._shoes != null)
			{
				return this._shoes;
			}
			this._shoes = new List<SpineSkinData>();
			for (int i = 0; i < this.SpineSkinDatas.Count; i++)
			{
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.CanvasShoes_White && this.SpineSkinDatas[i].name < (CLOTHE_NAME)10000)
				{
					this._shoes.Add(this.SpineSkinDatas[i]);
				}
			}
			this.bka(this._shoes, CLOTHE_TYPE.Shoes);
			return this._shoes;
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x06000545 RID: 1349 RVA: 0x0001C954 File Offset: 0x0001AB54
	public List<SpineSkinData> kph
	{
		get
		{
			if (this._skinTones != null)
			{
				return this._skinTones;
			}
			this._skinTones = new List<SpineSkinData>();
			for (int i = 0; i < this.SpineSkinDatas.Count; i++)
			{
				if (this.SpineSkinDatas[i] != null && this.SpineSkinDatas[i].type == CLOTHE_TYPE.SkinTone)
				{
					this._skinTones.Add(this.SpineSkinDatas[i]);
				}
			}
			this.bka(this._skinTones, CLOTHE_TYPE.SkinTone);
			return this._skinTones;
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x06000546 RID: 1350 RVA: 0x0001C9E0 File Offset: 0x0001ABE0
	public List<SpineSkinData> kpi
	{
		get
		{
			if (this._intimateParts != null)
			{
				return this._intimateParts;
			}
			this._intimateParts = new List<SpineSkinData>();
			for (int i = 0; i < this.SpineSkinDatas.Count; i++)
			{
				if (this.SpineSkinDatas[i] != null && this.SpineSkinDatas[i].type == CLOTHE_TYPE.IntimateParts)
				{
					this._intimateParts.Add(this.SpineSkinDatas[i]);
				}
			}
			this.bka(this._intimateParts, CLOTHE_TYPE.IntimateParts);
			return this._intimateParts;
		}
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x06000547 RID: 1351 RVA: 0x0001CA6C File Offset: 0x0001AC6C
	public List<SpineSkinData> kpj
	{
		get
		{
			if (this._pubicAndGenitals != null)
			{
				return this._pubicAndGenitals;
			}
			this._pubicAndGenitals = new List<SpineSkinData>();
			for (int i = 0; i < this.SpineSkinDatas.Count; i++)
			{
				if (this.SpineSkinDatas[i] != null && this.SpineSkinDatas[i].type == CLOTHE_TYPE.PubicAndGenital)
				{
					this._pubicAndGenitals.Add(this.SpineSkinDatas[i]);
				}
			}
			this.bka(this._pubicAndGenitals, CLOTHE_TYPE.PubicAndGenital);
			return this._pubicAndGenitals;
		}
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x0001CAF8 File Offset: 0x0001ACF8
	public List<SpineSkinData> bkl(CLOTHE_TYPE a)
	{
		switch (a)
		{
		case CLOTHE_TYPE.Dick:
			return this.kpa;
		case CLOTHE_TYPE.Hair:
			return this.kpb;
		case (CLOTHE_TYPE)2:
		case (CLOTHE_TYPE)6:
		case (CLOTHE_TYPE)7:
			break;
		case CLOTHE_TYPE.Top:
			return this.kpc;
		case CLOTHE_TYPE.Bottom:
			return this.kpd;
		case CLOTHE_TYPE.Underwear:
			return this.kpe;
		case CLOTHE_TYPE.Socks:
			return this.kpf;
		case CLOTHE_TYPE.Shoes:
			return this.kpg;
		default:
			switch (a)
			{
			case CLOTHE_TYPE.SkinTone:
				return this.kph;
			case CLOTHE_TYPE.IntimateParts:
				return this.kpi;
			case CLOTHE_TYPE.PubicAndGenital:
				return this.kpj;
			}
			break;
		}
		Debug.LogError(a.bel() + a.ToString());
		return null;
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x0001CBB0 File Offset: 0x0001ADB0
	public void bkm()
	{
		this._dicks = null;
		this._hairs = null;
		this._tops = null;
		this._bottoms = null;
		this._underwears = null;
		this._socks = null;
		this._shoes = null;
		this._skinTones = null;
		this._intimateParts = null;
		this._pubicAndGenitals = null;
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x0001CC04 File Offset: 0x0001AE04
	public int bkn(int a, CLOTHE_TYPE b)
	{
		if (a == 0)
		{
			return SpineSkinSetting.bko(b);
		}
		SpineSkinData spineSkinData = this.bjy(a, b);
		if (spineSkinData == null)
		{
			return SpineSkinSetting.bko(b);
		}
		if (!SteamManager.krd || !bq.hmf)
		{
			int num = bq.hlf.playerSaveData.bjb(b);
			if (num == 0)
			{
				return SpineSkinSetting.bko(b);
			}
			return num;
		}
		else
		{
			if (spineSkinData.isNeedUnlock && (!(du.iah != null) || !du.iah.iai || !du.iah.cej(spineSkinData.achievement)))
			{
				return SpineSkinSetting.bko(b);
			}
			if (!spineSkinData.bjk())
			{
				return SpineSkinSetting.bko(b);
			}
			if (spineSkinData.bjr(a))
			{
				bq.hlf.playerSaveData.bjc(b, a);
				return a;
			}
			return SpineSkinSetting.bko(b);
		}
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x0001CCC7 File Offset: 0x0001AEC7
	private static int bko(CLOTHE_TYPE a)
	{
		if (a == CLOTHE_TYPE.Dick)
		{
			return 1;
		}
		if (a == CLOTHE_TYPE.SkinTone)
		{
			return 200;
		}
		if (a != CLOTHE_TYPE.IntimateParts)
		{
			return 0;
		}
		return 400;
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x0001CCE8 File Offset: 0x0001AEE8
	public void bkp()
	{
		PlayerData hlf = bq.hlf;
		if (((hlf != null) ? hlf.playerSaveData : null) == null)
		{
			return;
		}
		this.bkq(bq.knn, CLOTHE_TYPE.SkinTone);
		this.bkq(bq.kno, CLOTHE_TYPE.IntimateParts);
		this.bkq(bq.knp, CLOTHE_TYPE.PubicAndGenital);
		this.bkt();
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x0001CD38 File Offset: 0x0001AF38
	private void bkq(int a, CLOTHE_TYPE b)
	{
		if (a == 0)
		{
			return;
		}
		SpineSkinData spineSkinData = this.bjy(a, b);
		if (spineSkinData == null)
		{
			return;
		}
		if (spineSkinData.skinName == SKIN_NAME.Null)
		{
			return;
		}
		if (spineSkinData.texture == null)
		{
			return;
		}
		SpineMaterialData spineMaterialData = this.bkv(spineSkinData.skinName);
		if (((spineMaterialData != null) ? spineMaterialData.material : null) == null)
		{
			return;
		}
		spineMaterialData.material.SetInt(a.bem(), 1);
		spineMaterialData.material.SetTexture(a.ben(), spineSkinData.texture);
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x0001CDB7 File Offset: 0x0001AFB7
	public void bkr()
	{
		this.bkm();
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x0001CDC0 File Offset: 0x0001AFC0
	public void bks(SKIN_NAME a, Texture2D b)
	{
		if (this.bkv(a).material == null)
		{
			return;
		}
		this.bkv(a).material.SetInt(a.bem(), 1);
		this.bkv(a).material.SetTexture(a.ben(), b);
		this.bkt();
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x0001CE18 File Offset: 0x0001B018
	public void bkt()
	{
		if (GirlController.kok == null)
		{
			Debug.LogError(a.beo());
			return;
		}
		if (!GirlController.kok.kom)
		{
			Debug.LogWarning(a.bep());
			return;
		}
		GirlController.kok.bgb();
		this.bku(bq.kng, a.beq());
		this.bku(bq.knh, a.ber());
		this.bku(bq.kni, a.bes());
		this.bku(bq.knj, a.bet());
		this.bku(bq.knk, a.beu());
		this.bku(bq.knl, a.bev());
		this.bku(bq.knm, a.bew());
		this.bku(bq.knn, a.bex());
		this.bku(bq.kno, a.bey());
		this.bku(bq.knp, a.bez());
		GirlController.kok.bgc();
		bf bf = GirlController.kok.kol;
		if (bf == null)
		{
			return;
		}
		bf.vv();
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x0001CF1C File Offset: 0x0001B11C
	private void bku(int a, string b)
	{
		if (a == 0)
		{
			return;
		}
		SpineSkinData spineSkinData = this.bjx(a);
		if (spineSkinData == null)
		{
			Debug.LogWarning(string.Format(a.bfa(), b, a));
			return;
		}
		if (spineSkinData.skinName != SKIN_NAME.Null)
		{
			GirlController.kok.bfz(spineSkinData.skinName.ToString());
		}
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x0001CF74 File Offset: 0x0001B174
	public SpineMaterialData bkv(SKIN_NAME a)
	{
		foreach (SpineMaterialData spineMaterialData in this.SpineMaterialDatas)
		{
			if (spineMaterialData.skinName == a)
			{
				return spineMaterialData;
			}
		}
		return null;
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x0001CFD0 File Offset: 0x0001B1D0
	public void bkw()
	{
		foreach (object obj in Enum.GetValues(typeof(SKIN_NAME)))
		{
			SKIN_NAME skin_NAME = (SKIN_NAME)obj;
			bool flag = false;
			for (int i = 0; i < this.SpineMaterialDatas.Count; i++)
			{
				if (this.SpineMaterialDatas[i].skinName == skin_NAME)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				SpineMaterialData spineMaterialData = new SpineMaterialData();
				spineMaterialData.skinName = skin_NAME;
				this.SpineMaterialDatas.Add(spineMaterialData);
			}
		}
		this.SpineMaterialDatas.Sort(new Comparison<SpineMaterialData>(SpineSkinSetting.<>c.<>9.bjt));
		this.blb();
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x0001D0B0 File Offset: 0x0001B2B0
	public void bkx()
	{
		foreach (object obj in Enum.GetValues(typeof(CLOTHE_NAME)))
		{
			CLOTHE_NAME clothe_NAME = (CLOTHE_NAME)obj;
			if (clothe_NAME < CLOTHE_NAME.IvysHair_OriginalColor)
			{
				bool flag = false;
				for (int i = 0; i < this.SpineSkinDatas.Count; i++)
				{
					if (this.SpineSkinDatas[i].name == clothe_NAME)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					SpineSkinData spineSkinData = new SpineSkinData();
					spineSkinData.name = clothe_NAME;
					spineSkinData.skinName = SKIN_NAME.Null;
					spineSkinData.texture = null;
					this.SpineSkinDatas.Add(spineSkinData);
				}
			}
		}
		this.SpineSkinDatas.Sort(new Comparison<SpineSkinData>(SpineSkinSetting.<>c.<>9.bju));
		this.bky();
		this.blb();
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x0001D1B0 File Offset: 0x0001B3B0
	public void bky()
	{
		for (int i = 0; i < this.SpineSkinDatas.Count; i++)
		{
			if (this.SpineSkinDatas[i].name > CLOTHE_NAME.Null && this.SpineSkinDatas[i].name < CLOTHE_NAME.ShortHair_Black)
			{
				this.SpineSkinDatas[i].type = CLOTHE_TYPE.Dick;
				this.SpineSkinDatas[i].skinName = SKIN_NAME.Dick;
			}
			if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.ShortHair_Black && this.SpineSkinDatas[i].name < (CLOTHE_NAME)2000)
			{
				this.SpineSkinDatas[i].type = CLOTHE_TYPE.Hair;
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.ShortHair_Black && this.SpineSkinDatas[i].name <= (CLOTHE_NAME)1009)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Hair_ShortHair;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.MediumHair_Black && this.SpineSkinDatas[i].name <= (CLOTHE_NAME)1019)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Hair_MediumLengthHair;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.Twintails_Black && this.SpineSkinDatas[i].name <= (CLOTHE_NAME)1029)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Hair_TwintailsHair;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.Afro_Black && this.SpineSkinDatas[i].name <= (CLOTHE_NAME)1039)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Hair_Afro;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.PixieCut_Black && this.SpineSkinDatas[i].name <= (CLOTHE_NAME)1109)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Hair_PixieShortHair;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.LongWavyHair_Black && this.SpineSkinDatas[i].name <= (CLOTHE_NAME)1119)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Hair_LongWavyHair;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.Pigtails_Black && this.SpineSkinDatas[i].name <= (CLOTHE_NAME)1129)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Hair_PigtailsHair;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.BobCut_Black && this.SpineSkinDatas[i].name <= (CLOTHE_NAME)1209)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Hair_BobHair;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.LongStraightHair_Black && this.SpineSkinDatas[i].name <= (CLOTHE_NAME)1219)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Hair_LongStraightHair;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.SpaceBuns_Black && this.SpineSkinDatas[i].name <= (CLOTHE_NAME)1229)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Hair_SpaceBuns;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.HighSidePonytail_Black && this.SpineSkinDatas[i].name <= (CLOTHE_NAME)1309)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Hair_HighSidePonytail;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.HighBun_Black && this.SpineSkinDatas[i].name <= (CLOTHE_NAME)1319)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Hair_HighBun;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.FrenchBraid_Black && this.SpineSkinDatas[i].name <= (CLOTHE_NAME)1329)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Hair_FrenchBraid;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.SingleBraid_Black && this.SpineSkinDatas[i].name <= (CLOTHE_NAME)1409)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Hair_SingleBraid;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.CrisscrossUpdo_Black && this.SpineSkinDatas[i].name <= (CLOTHE_NAME)1419)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Hair_CrisscrossUpdo;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.LongStraightHairWithHeadband_Black && this.SpineSkinDatas[i].name <= (CLOTHE_NAME)1509)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Hair_LongStraightHair_Headband;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.LongStraightHairWithBowHeadband_Black && this.SpineSkinDatas[i].name <= (CLOTHE_NAME)1519)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Hair_LongStraightHair_BowHeadband;
				}
			}
			if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.TShirt_White && this.SpineSkinDatas[i].name < CLOTHE_NAME.DrapedLongSkirt_Black)
			{
				this.SpineSkinDatas[i].type = CLOTHE_TYPE.Top;
				this.SpineSkinDatas[i].skinName = SKIN_NAME.Top;
			}
			if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.DrapedLongSkirt_Black && this.SpineSkinDatas[i].name < CLOTHE_NAME.SportsBra_Blue)
			{
				this.SpineSkinDatas[i].type = CLOTHE_TYPE.Bottom;
				this.SpineSkinDatas[i].skinName = SKIN_NAME.Bottom;
			}
			if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.SportsBra_Blue && this.SpineSkinDatas[i].name < (CLOTHE_NAME)6000)
			{
				this.SpineSkinDatas[i].type = CLOTHE_TYPE.Underwear;
				this.SpineSkinDatas[i].skinName = SKIN_NAME.Underwear;
			}
			if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.CrewSocks_White && this.SpineSkinDatas[i].name < CLOTHE_NAME.CanvasShoes_White)
			{
				this.SpineSkinDatas[i].type = CLOTHE_TYPE.Socks;
				this.SpineSkinDatas[i].skinName = SKIN_NAME.Socks;
			}
			if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.CanvasShoes_White && this.SpineSkinDatas[i].name < (CLOTHE_NAME)10000)
			{
				this.SpineSkinDatas[i].type = CLOTHE_TYPE.Shoes;
				this.SpineSkinDatas[i].skinName = SKIN_NAME.Shoes;
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.CanvasShoes_White && this.SpineSkinDatas[i].name <= CLOTHE_NAME.CanvasShoes_Pink)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Shoes_Mask;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.AnkleBoots_Black && this.SpineSkinDatas[i].name <= CLOTHE_NAME.AnkleBoots_White)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Shoes_Mask;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.DesignerCanvasShoes_Blue && this.SpineSkinDatas[i].name <= CLOTHE_NAME.FurBoots_Red)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Shoes_Mask;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.Sneakers_Blue && this.SpineSkinDatas[i].name <= CLOTHE_NAME.Sneakers_Purple)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Shoes_Mask;
				}
				if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.HighHeels_Red && this.SpineSkinDatas[i].name <= CLOTHE_NAME.CombatBoots_Blue)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Shoes_Mask;
				}
				if (this.SpineSkinDatas[i].name == CLOTHE_NAME.BalletShoes)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Shoes_Mask;
				}
				if (this.SpineSkinDatas[i].name == CLOTHE_NAME.ArmoredBoots)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Shoes_Mask;
				}
				if (this.SpineSkinDatas[i].name == CLOTHE_NAME.FuturisticHighHeels)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.Shoes_Mask;
				}
			}
			if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.Body_Base && this.SpineSkinDatas[i].name < (CLOTHE_NAME)399)
			{
				this.SpineSkinDatas[i].type = CLOTHE_TYPE.SkinTone;
				this.SpineSkinDatas[i].skinName = SKIN_NAME.Body;
			}
			if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.IntimateParts_Standard_SoftEdge_Pink && this.SpineSkinDatas[i].name < (CLOTHE_NAME)599)
			{
				this.SpineSkinDatas[i].type = CLOTHE_TYPE.IntimateParts;
				this.SpineSkinDatas[i].skinName = SKIN_NAME.IntimateParts;
			}
			if (this.SpineSkinDatas[i].name >= CLOTHE_NAME.Futanari_Big && this.SpineSkinDatas[i].name < (CLOTHE_NAME)799)
			{
				this.SpineSkinDatas[i].type = CLOTHE_TYPE.PubicAndGenital;
				this.SpineSkinDatas[i].skinName = SKIN_NAME.PubicAndGenital_PubicHair;
				if (this.SpineSkinDatas[i].name == CLOTHE_NAME.Futanari_Big)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.PubicAndGenital_Futa_Big;
				}
				if (this.SpineSkinDatas[i].name == CLOTHE_NAME.Futanari_Small)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.PubicAndGenital_Futa_Small;
				}
				if (this.SpineSkinDatas[i].name == CLOTHE_NAME.PubicHair_Sparse)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.PubicAndGenital_PubicHair_Multiply;
				}
				if (this.SpineSkinDatas[i].name == CLOTHE_NAME.PubicHair_Dense)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.PubicAndGenital_PubicHair_Multiply;
				}
				if (this.SpineSkinDatas[i].name == CLOTHE_NAME.Futanari_Big_Ball)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.PubicAndGenital_Futa_Big_Ball;
				}
				if (this.SpineSkinDatas[i].name == CLOTHE_NAME.Futanari_Small_Ball)
				{
					this.SpineSkinDatas[i].skinName = SKIN_NAME.PubicAndGenital_Futa_Small_Ball;
				}
			}
		}
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x00005090 File Offset: 0x00003290
	public void bkz()
	{
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x00005090 File Offset: 0x00003290
	public void bla()
	{
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x00005090 File Offset: 0x00003290
	public void blb()
	{
	}

	// Token: 0x0400058D RID: 1421
	public List<SpineMaterialData> SpineMaterialDatas;

	// Token: 0x0400058E RID: 1422
	public List<SpineSkinData> SpineSkinDatas;

	// Token: 0x0400058F RID: 1423
	public List<SpineSkinData> CollabSkinDatas = new List<SpineSkinData>();

	// Token: 0x04000590 RID: 1424
	public List<int> galleryPurchaseOnlyHiddenItems = new List<int>();

	// Token: 0x04000591 RID: 1425
	private HashSet<int> _galleryPurchaseOnlyHiddenCache;

	// Token: 0x04000592 RID: 1426
	public Texture2D nakedTexture;

	// Token: 0x04000593 RID: 1427
	public Sprite spriteLock;

	// Token: 0x04000594 RID: 1428
	public List<RarityColorEntry> rarityColorEntries = new List<RarityColorEntry>
	{
		new RarityColorEntry
		{
			rarity = a.bfb(),
			backgroundColor = new Color(0.65f, 0.65f, 0.65f, 0.627451f)
		},
		new RarityColorEntry
		{
			rarity = a.bfc(),
			backgroundColor = new Color(0.21678324f, 0.7106918f, 0.21678324f, 0.627451f)
		},
		new RarityColorEntry
		{
			rarity = a.bfd(),
			backgroundColor = new Color(0.3f, 0.55f, 0.95f, 0.627451f)
		},
		new RarityColorEntry
		{
			rarity = a.bfe(),
			backgroundColor = new Color(0.7f, 0.4f, 0.95f, 0.627451f)
		},
		new RarityColorEntry
		{
			rarity = a.bff(),
			backgroundColor = new Color(1f, 0.17295581f, 0.5136288f, 0.627451f)
		},
		new RarityColorEntry
		{
			rarity = a.bfg(),
			backgroundColor = new Color(1f, 0.71269983f, 0f, 0.627451f)
		},
		new RarityColorEntry
		{
			rarity = a.bfh(),
			backgroundColor = new Color(0f, 0.6f, 0.65f, 0.627451f)
		}
	};

	// Token: 0x04000595 RID: 1429
	public Color defaultBackgroundColor = new Color(0.5f, 0.5f, 0.5f, 1f);

	// Token: 0x04000596 RID: 1430
	private List<SpineSkinData> _dicks;

	// Token: 0x04000597 RID: 1431
	private List<SpineSkinData> _hairs;

	// Token: 0x04000598 RID: 1432
	private List<SpineSkinData> _tops;

	// Token: 0x04000599 RID: 1433
	private List<SpineSkinData> _bottoms;

	// Token: 0x0400059A RID: 1434
	private List<SpineSkinData> _underwears;

	// Token: 0x0400059B RID: 1435
	private List<SpineSkinData> _socks;

	// Token: 0x0400059C RID: 1436
	private List<SpineSkinData> _shoes;

	// Token: 0x0400059D RID: 1437
	private List<SpineSkinData> _skinTones;

	// Token: 0x0400059E RID: 1438
	private List<SpineSkinData> _intimateParts;

	// Token: 0x0400059F RID: 1439
	private List<SpineSkinData> _pubicAndGenitals;
}
