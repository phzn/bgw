using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000090 RID: 144
public class ClothingSetItemController : MonoBehaviour
{
	// Token: 0x17000090 RID: 144
	// (get) Token: 0x06000647 RID: 1607 RVA: 0x00022A17 File Offset: 0x00020C17
	public static ClothingSetItemController kpv
	{
		get
		{
			return ClothingSetItemController.hvd;
		}
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00022A1E File Offset: 0x00020C1E
	private void Awake()
	{
		ClothingSetItemController.hvd = this;
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x00022A28 File Offset: 0x00020C28
	private void Start()
	{
		this.btnAddClothingSet.onClick.AddListener(new UnityAction(this.bqt));
		this.btnRandomClothingSet.onClick.AddListener(new UnityAction(this.bqu));
		this.clothingSetItem.gameObject.SetActive(false);
		this.hve = true;
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x00022A85 File Offset: 0x00020C85
	private void OnEnable()
	{
		if (this.hve)
		{
			this.bqi();
		}
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x00022A98 File Offset: 0x00020C98
	public void bqi()
	{
		if (!SettingPanel.kqs)
		{
			for (int i = this.huz.Count - 1; i >= 0; i--)
			{
				this.bqm(this.huz[i]);
			}
			return;
		}
		if (bq.hlf == null)
		{
			Debug.LogFormat(a.bhq(), Array.Empty<object>());
			return;
		}
		if (bq.hlf.playerSaveData == null)
		{
			Debug.LogFormat(a.bhr(), Array.Empty<object>());
			return;
		}
		if (bq.hlf.playerSaveData.clothingSetDatas == null)
		{
			Debug.LogFormat(a.bhs(), Array.Empty<object>());
			return;
		}
		this.hvb = bq.hlf.playerSaveData.clothingSetDatas;
		for (int j = this.huz.Count - 1; j >= 0; j--)
		{
			this.bqm(this.huz[j]);
		}
		for (int k = 0; k < this.hvb.Count; k++)
		{
			this.bql().bqb(this.hvb[k]);
		}
		this.bqj();
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x00022BA4 File Offset: 0x00020DA4
	public void bqj()
	{
		if (bq.hlf == null || bq.hlf.playerSaveData == null)
		{
			return;
		}
		PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		this.bqk(this.currentHair, playerSaveData.desiredHairUse);
		this.bqk(this.currentTop, playerSaveData.desiredTopUse);
		this.bqk(this.currentBottom, playerSaveData.desiredBottomUse);
		this.bqk(this.currentUnderwear, playerSaveData.desiredUnderwearUse);
		this.bqk(this.currentSocks, playerSaveData.desiredSocksUse);
		this.bqk(this.currentShoes, playerSaveData.desiredShoesUse);
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x00022C44 File Offset: 0x00020E44
	private void bqk(ClothingSetShowItem a, int b)
	{
		if (a == null)
		{
			return;
		}
		SpineSkinData spineSkinData = bq.hle.bjx(b);
		a.bqv((spineSkinData != null) ? spineSkinData.icon : null);
		a.bqw(b != 0 && spineSkinData != null && !spineSkinData.bjq());
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x00022C94 File Offset: 0x00020E94
	public cw bql()
	{
		cw cw = ((this.hva.Count > 0) ? this.hva.Dequeue() : global::UnityEngine.Object.Instantiate<cw>(this.clothingSetItem, this.transPool));
		cw.bqa();
		cw.transform.SetParent(this.transContent);
		this.huz.Add(cw);
		return cw;
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x00022CF2 File Offset: 0x00020EF2
	public void bqm(cw a)
	{
		this.huz.Remove(a);
		a.transform.SetParent(this.transPool);
		a.Close();
		this.hva.Enqueue(a);
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x00022D24 File Offset: 0x00020F24
	public void bqn()
	{
		PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		this.bqo(new ClothingSetData
		{
			HairUse = playerSaveData.desiredHairUse,
			TopUse = playerSaveData.desiredTopUse,
			BottomUse = playerSaveData.desiredBottomUse,
			UnderwearUse = playerSaveData.desiredUnderwearUse,
			SocksUse = playerSaveData.desiredSocksUse,
			ShoesUse = playerSaveData.desiredShoesUse,
			DickUse = playerSaveData.desiredDickUse,
			SkinToneUse = playerSaveData.desiredSkinToneUse,
			IntimatePartsUse = playerSaveData.desiredIntimatePartsUse,
			PubicAndGenitalUse = playerSaveData.desiredPubicAndGenitalUse,
			desiredHairUse = playerSaveData.desiredHairUse,
			desiredTopUse = playerSaveData.desiredTopUse,
			desiredBottomUse = playerSaveData.desiredBottomUse,
			desiredUnderwearUse = playerSaveData.desiredUnderwearUse,
			desiredSocksUse = playerSaveData.desiredSocksUse,
			desiredShoesUse = playerSaveData.desiredShoesUse,
			desiredDickUse = playerSaveData.desiredDickUse,
			desiredSkinToneUse = playerSaveData.desiredSkinToneUse,
			desiredIntimatePartsUse = playerSaveData.desiredIntimatePartsUse,
			desiredPubicAndGenitalUse = playerSaveData.desiredPubicAndGenitalUse,
			lastVerifiedHairUse = playerSaveData.lastVerifiedHairUse,
			lastVerifiedTopUse = playerSaveData.lastVerifiedTopUse,
			lastVerifiedBottomUse = playerSaveData.lastVerifiedBottomUse,
			lastVerifiedUnderwearUse = playerSaveData.lastVerifiedUnderwearUse,
			lastVerifiedSocksUse = playerSaveData.lastVerifiedSocksUse,
			lastVerifiedShoesUse = playerSaveData.lastVerifiedShoesUse,
			lastVerifiedDickUse = playerSaveData.lastVerifiedDickUse,
			lastVerifiedSkinToneUse = playerSaveData.lastVerifiedSkinToneUse,
			lastVerifiedIntimatePartsUse = playerSaveData.lastVerifiedIntimatePartsUse,
			lastVerifiedPubicAndGenitalUse = playerSaveData.lastVerifiedPubicAndGenitalUse
		});
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x00022EB1 File Offset: 0x000210B1
	public void bqo(ClothingSetData a)
	{
		bq.hlf.playerSaveData.bix(a);
		this.bqi();
		ci.Save(null);
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x00022ECF File Offset: 0x000210CF
	public void bqp(cw a)
	{
		bq.hlf.playerSaveData.biy(a.kpu);
		this.bqi();
		ci.Save(null);
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x00022EF2 File Offset: 0x000210F2
	public void bqq()
	{
		this.bqr(CLOTHE_TYPE.Hair);
		this.bqr(CLOTHE_TYPE.Top);
		this.bqr(CLOTHE_TYPE.Bottom);
		this.bqr(CLOTHE_TYPE.Underwear);
		this.bqr(CLOTHE_TYPE.Socks);
		this.bqr(CLOTHE_TYPE.Shoes);
		this.bqj();
		ci.Save(null);
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x00022F2C File Offset: 0x0002112C
	private void bqr(CLOTHE_TYPE a)
	{
		List<SpineSkinData> list = bq.hle.bkl(a);
		if (list == null || list.Count == 0)
		{
			return;
		}
		this.hvc.Clear();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].bjq())
			{
				this.hvc.Add(list[i]);
			}
		}
		if (this.hvc.Count == 0)
		{
			return;
		}
		int num = global::UnityEngine.Random.Range(0, this.hvc.Count + 1);
		if (num < this.hvc.Count)
		{
			this.hvc[num].bjp(true);
			return;
		}
		this.bqs(a);
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x00022FD8 File Offset: 0x000211D8
	private void bqs(CLOTHE_TYPE a)
	{
		PlayerSaveData playerSaveData = bq.hlf.playerSaveData;
		switch (a)
		{
		case CLOTHE_TYPE.Hair:
			playerSaveData.desiredHairUse = 0;
			break;
		case CLOTHE_TYPE.Top:
			playerSaveData.desiredTopUse = 0;
			break;
		case CLOTHE_TYPE.Bottom:
			playerSaveData.desiredBottomUse = 0;
			break;
		case CLOTHE_TYPE.Underwear:
			playerSaveData.desiredUnderwearUse = 0;
			break;
		case CLOTHE_TYPE.Socks:
			playerSaveData.desiredSocksUse = 0;
			break;
		case CLOTHE_TYPE.Shoes:
			playerSaveData.desiredShoesUse = 0;
			break;
		}
		bq.bap(a);
		bq.hle.bkt();
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x00023096 File Offset: 0x00021296
	[CompilerGenerated]
	private void bqt()
	{
		bq.hlk = false;
		this.bqn();
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x000230A4 File Offset: 0x000212A4
	[CompilerGenerated]
	private void bqu()
	{
		bq.hlk = false;
		this.bqq();
	}

	// Token: 0x04000646 RID: 1606
	[SerializeField]
	private Button btnAddClothingSet;

	// Token: 0x04000647 RID: 1607
	[SerializeField]
	private Button btnRandomClothingSet;

	// Token: 0x04000648 RID: 1608
	[SerializeField]
	private cw clothingSetItem;

	// Token: 0x04000649 RID: 1609
	[SerializeField]
	private Transform transContent;

	// Token: 0x0400064A RID: 1610
	[SerializeField]
	private Transform transPool;

	// Token: 0x0400064B RID: 1611
	[SerializeField]
	private ClothingSetShowItem currentHair;

	// Token: 0x0400064C RID: 1612
	[SerializeField]
	private ClothingSetShowItem currentTop;

	// Token: 0x0400064D RID: 1613
	[SerializeField]
	private ClothingSetShowItem currentBottom;

	// Token: 0x0400064E RID: 1614
	[SerializeField]
	private ClothingSetShowItem currentUnderwear;

	// Token: 0x0400064F RID: 1615
	[SerializeField]
	private ClothingSetShowItem currentSocks;

	// Token: 0x04000650 RID: 1616
	[SerializeField]
	private ClothingSetShowItem currentShoes;

	// Token: 0x04000651 RID: 1617
	private List<cw> huz = new List<cw>();

	// Token: 0x04000652 RID: 1618
	private Queue<cw> hva = new Queue<cw>();

	// Token: 0x04000653 RID: 1619
	private List<ClothingSetData> hvb = new List<ClothingSetData>();

	// Token: 0x04000654 RID: 1620
	private readonly List<SpineSkinData> hvc = new List<SpineSkinData>();

	// Token: 0x04000655 RID: 1621
	private static ClothingSetItemController hvd;

	// Token: 0x04000656 RID: 1622
	private bool hve;
}
