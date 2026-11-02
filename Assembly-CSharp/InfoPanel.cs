using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Steamworks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200009A RID: 154
public class InfoPanel : MonoBehaviour
{
	// Token: 0x060006D7 RID: 1751 RVA: 0x00025F7C File Offset: 0x0002417C
	private void Start()
	{
		if (this.btnRamenCat != null)
		{
			this.btnRamenCat.onClick.AddListener(new UnityAction(this.bsw));
		}
		if (this.btnHideGame != null)
		{
			this.btnHideGame.onClick.AddListener(new UnityAction(this.bsx));
		}
		this.bta();
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x00025FE3 File Offset: 0x000241E3
	private void OnEnable()
	{
		fd.cvi(new Action<fd.Page>(this.bsu));
		this.bsv();
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x00025FFC File Offset: 0x000241FC
	private void OnDisable()
	{
		fd.cvk(new Action<fd.Page>(this.bsu));
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x0002600F File Offset: 0x0002420F
	private void OnDestroy()
	{
		fd.cvk(new Action<fd.Page>(this.bsu));
		if (this.hwi)
		{
			this.hwi = false;
			SteamManager.ibn -= this.btc;
		}
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x00026042 File Offset: 0x00024242
	private void bsu(fd.Page a)
	{
		this.bsv();
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x0002604C File Offset: 0x0002424C
	private void bsv()
	{
		bool flag = !fd.cvn(fd.Page.Developer);
		bool flag2 = !fd.cvn(fd.Page.Publisher);
		if (this.giftHintRamenCat != null)
		{
			this.giftHintRamenCat.un(flag);
		}
		if (this.giftHintHideGame != null)
		{
			this.giftHintHideGame.un(flag2);
		}
		if (this.hintLabelRamenCat != null)
		{
			this.hintLabelRamenCat.SetActive(flag);
		}
		if (this.hintLabelHideGame != null)
		{
			this.hintLabelHideGame.SetActive(flag2);
		}
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x000260D8 File Offset: 0x000242D8
	private void bsw()
	{
		bq.hlk = false;
		InfoPanel.bsy(this.urlRamenCat);
		fd.cvm(fd.Page.Developer);
		if (this.dotRamenCat != null)
		{
			this.dotRamenCat.uq();
		}
		if (cx.kpw != null)
		{
			cx.kpw.brh();
		}
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x0002612C File Offset: 0x0002432C
	private void bsx()
	{
		bq.hlk = false;
		InfoPanel.bsy(this.urlHideGame);
		fd.cvm(fd.Page.Publisher);
		if (this.dotHideGame != null)
		{
			this.dotHideGame.uq();
		}
		if (cx.kpw != null)
		{
			cx.kpw.brh();
		}
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x00026180 File Offset: 0x00024380
	private static void bsy(string a)
	{
		if (string.IsNullOrEmpty(a))
		{
			Debug.LogWarning(a.bkj());
			return;
		}
		Application.OpenURL(a.bjg() + a);
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x000261A5 File Offset: 0x000243A5
	public void bsz()
	{
		this.bta();
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x000261B0 File Offset: 0x000243B0
	private void bta()
	{
		if (this.hwg)
		{
			return;
		}
		this.hwg = true;
		if (this.gameLinkConfig == null || this.gameLinkConfig.games == null || this.baseGameLinkPrefab == null)
		{
			this.btf(this.dlcSectionRoot);
			this.btf(this.otherGameSectionRoot);
			this.btf(this.collabSectionRoot);
			return;
		}
		this.hwh = !SteamManager.krd;
		List<GameLinkEntry> list = new List<GameLinkEntry>(this.gameLinkConfig.games.Count);
		HashSet<string> hashSet = new HashSet<string>();
		foreach (GameLinkEntry gameLinkEntry in this.gameLinkConfig.games)
		{
			if (this.bte(gameLinkEntry, hashSet) && !InfoPanel.btg(gameLinkEntry.steamAppId))
			{
				list.Add(gameLinkEntry);
			}
		}
		int num = this.btd(this.dlcItemContainer, this.dlcSectionRoot, list, new Func<GameLinkEntry, bool>(InfoPanel.<>c.<>9.bsr));
		int num2 = this.btd(this.otherGameItemContainer, this.otherGameSectionRoot, list, new Func<GameLinkEntry, bool>(InfoPanel.<>c.<>9.bss));
		bool flag = this.btd(this.collabItemContainer, this.collabSectionRoot, list, new Func<GameLinkEntry, bool>(InfoPanel.<>c.<>9.bst)) != 0;
		if (num == 0)
		{
			this.btf(this.dlcSectionRoot);
		}
		if (num2 == 0)
		{
			this.btf(this.otherGameSectionRoot);
		}
		if (!flag)
		{
			this.btf(this.collabSectionRoot);
		}
		this.btb();
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x00026378 File Offset: 0x00024578
	private void btb()
	{
		if (this.hwi)
		{
			return;
		}
		this.hwi = true;
		SteamManager.ibn += this.btc;
		if (SteamManager.krd)
		{
			this.btc();
		}
	}

	// Token: 0x060006E3 RID: 1763 RVA: 0x000263A8 File Offset: 0x000245A8
	private void btc()
	{
		if (!this.hwh)
		{
			return;
		}
		foreach (GameObject gameObject in this.hwj)
		{
			if (!(gameObject == null))
			{
				db component = gameObject.GetComponent<db>();
				if (this.parentTabDot != null && component != null && component.dot != null)
				{
					this.parentTabDot.uu(component.dot);
				}
				global::UnityEngine.Object.Destroy(gameObject);
			}
		}
		this.hwj.Clear();
		if (this.dlcSectionRoot != null)
		{
			this.dlcSectionRoot.SetActive(true);
		}
		if (this.otherGameSectionRoot != null)
		{
			this.otherGameSectionRoot.SetActive(true);
		}
		if (this.collabSectionRoot != null)
		{
			this.collabSectionRoot.SetActive(true);
		}
		this.hwg = false;
		this.bta();
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x000264B0 File Offset: 0x000246B0
	private int btd(Transform a, GameObject b, List<GameLinkEntry> c, Func<GameLinkEntry, bool> d)
	{
		if (a == null)
		{
			return 0;
		}
		int num = -1;
		if (b != null && b.transform.parent == a)
		{
			num = b.transform.GetSiblingIndex();
		}
		int num2 = 0;
		foreach (GameLinkEntry gameLinkEntry in c)
		{
			if (d(gameLinkEntry))
			{
				GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.baseGameLinkPrefab, a);
				this.hwj.Add(gameObject);
				if (num >= 0)
				{
					gameObject.transform.SetSiblingIndex(num + 1 + num2);
				}
				db component = gameObject.GetComponent<db>();
				if (component != null)
				{
					component.bsn(gameLinkEntry, this.parentTabDot);
				}
				num2++;
			}
		}
		return num2;
	}

	// Token: 0x060006E5 RID: 1765 RVA: 0x00026590 File Offset: 0x00024790
	private bool bte(GameLinkEntry a, HashSet<string> b)
	{
		if (a == null)
		{
			return false;
		}
		if (!a.enabled)
		{
			return false;
		}
		if (string.IsNullOrEmpty(a.gameId))
		{
			Debug.LogError(a.bkk());
			return false;
		}
		if (!b.Add(a.gameId))
		{
			Debug.LogError(a.bkl() + a.gameId + a.bkm());
			return false;
		}
		if (a.steamAppId == 0U && string.IsNullOrEmpty(a.url))
		{
			Debug.LogError(a.bkn() + a.gameId + a.bko());
			return false;
		}
		return true;
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x00026621 File Offset: 0x00024821
	private void btf(GameObject a)
	{
		if (a != null)
		{
			a.SetActive(false);
		}
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x00026633 File Offset: 0x00024833
	private static bool btg(uint a)
	{
		return a != 0U && SteamManager.krd && SteamApps.BIsSubscribedApp(new AppId_t(a));
	}

	// Token: 0x0400068E RID: 1678
	public Button btnRamenCat;

	// Token: 0x0400068F RID: 1679
	public string urlRamenCat;

	// Token: 0x04000690 RID: 1680
	public Button btnHideGame;

	// Token: 0x04000691 RID: 1681
	public string urlHideGame;

	// Token: 0x04000692 RID: 1682
	public t dotRamenCat;

	// Token: 0x04000693 RID: 1683
	public t dotHideGame;

	// Token: 0x04000694 RID: 1684
	[SerializeField]
	private t parentTabDot;

	// Token: 0x04000695 RID: 1685
	public t giftHintRamenCat;

	// Token: 0x04000696 RID: 1686
	public t giftHintHideGame;

	// Token: 0x04000697 RID: 1687
	public GameObject hintLabelRamenCat;

	// Token: 0x04000698 RID: 1688
	public GameObject hintLabelHideGame;

	// Token: 0x04000699 RID: 1689
	[SerializeField]
	private GameObject dlcSectionRoot;

	// Token: 0x0400069A RID: 1690
	[SerializeField]
	private Transform dlcItemContainer;

	// Token: 0x0400069B RID: 1691
	[SerializeField]
	private GameObject otherGameSectionRoot;

	// Token: 0x0400069C RID: 1692
	[SerializeField]
	private Transform otherGameItemContainer;

	// Token: 0x0400069D RID: 1693
	[SerializeField]
	private GameObject collabSectionRoot;

	// Token: 0x0400069E RID: 1694
	[SerializeField]
	private Transform collabItemContainer;

	// Token: 0x0400069F RID: 1695
	[SerializeField]
	private GameObject baseGameLinkPrefab;

	// Token: 0x040006A0 RID: 1696
	[SerializeField]
	private GameLinkConfig gameLinkConfig;

	// Token: 0x040006A1 RID: 1697
	private bool hwg;

	// Token: 0x040006A2 RID: 1698
	private bool hwh;

	// Token: 0x040006A3 RID: 1699
	private bool hwi;

	// Token: 0x040006A4 RID: 1700
	private readonly List<GameObject> hwj = new List<GameObject>();
}
