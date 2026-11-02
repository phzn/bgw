using System;
using System.Collections;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x02000102 RID: 258
public sealed class fd : MonoBehaviour
{
	// Token: 0x060012C9 RID: 4809 RVA: 0x0005C030 File Offset: 0x0005A230
	private static void cvp()
	{
		fd.Page[] array = fd.ina;
		for (int i = 0; i < array.Length; i++)
		{
			fd.cvq(array[i]);
		}
	}

	// Token: 0x060012CA RID: 4810 RVA: 0x0005C05C File Offset: 0x0005A25C
	public static void bfk(fd.Page a)
	{
		fd.cvl();
		int num = fd.cvr(a);
		if (num == 2)
		{
			return;
		}
		if (num == 1)
		{
			fd.inb.Add(a);
			return;
		}
		if (fd.cvs(a, 1))
		{
			fd.inb.Add(a);
		}
	}

	// Token: 0x060012CB RID: 4811 RVA: 0x0005C0A0 File Offset: 0x0005A2A0
	public static bool gwb(fd.Page a)
	{
		return fd.cvr(a) == 2;
	}

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x060012CC RID: 4812 RVA: 0x0005C0AB File Offset: 0x0005A2AB
	// (set) Token: 0x060012E3 RID: 4835 RVA: 0x0005C43D File Offset: 0x0005A63D
	public static fd inc { get; private set; }

	// Token: 0x060012CD RID: 4813 RVA: 0x0005C0B4 File Offset: 0x0005A2B4
	private static bool ogz(fd.Page a, int b)
	{
		if (bq.hmh)
		{
			return false;
		}
		PlayerSaveData playerSaveData = fd.cvt();
		if (playerSaveData == null)
		{
			return false;
		}
		int num = ((a == fd.Page.Developer) ? playerSaveData.creatorPageDeveloperState : playerSaveData.creatorPagePublisherState);
		if (a == fd.Page.Developer)
		{
			playerSaveData.creatorPageDeveloperState = b;
		}
		else
		{
			playerSaveData.creatorPagePublisherState = b;
		}
		ci.Save(null);
		if (ci.hsa)
		{
			return true;
		}
		if (a == fd.Page.Developer)
		{
			playerSaveData.creatorPageDeveloperState = num;
		}
		else
		{
			playerSaveData.creatorPagePublisherState = num;
		}
		return false;
	}

	// Token: 0x060012CE RID: 4814 RVA: 0x0005C11D File Offset: 0x0005A31D
	public static void gbw()
	{
		if (fd.inc != null)
		{
			return;
		}
		GameObject gameObject = new GameObject(a.drw());
		global::UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.AddComponent<fd>();
	}

	// Token: 0x060012CF RID: 4815 RVA: 0x0005C144 File Offset: 0x0005A344
	private static void hmo()
	{
		foreach (fd.Page page in fd.ina)
		{
			if (!fd.inb.Contains(page))
			{
				fd.cvq(page);
			}
		}
	}

	// Token: 0x060012D0 RID: 4816 RVA: 0x0005C17C File Offset: 0x0005A37C
	public static void cvl()
	{
		if (fd.inc != null)
		{
			return;
		}
		GameObject gameObject = new GameObject(a.drx());
		global::UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.AddComponent<fd>();
	}

	// Token: 0x060012D1 RID: 4817 RVA: 0x0005C1A2 File Offset: 0x0005A3A2
	private void Awake()
	{
		if (fd.inc != null && fd.inc != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		fd.inc = this;
		fd.inb.Clear();
	}

	// Token: 0x060012D2 RID: 4818 RVA: 0x0005C1DA File Offset: 0x0005A3DA
	private static void iiu(fd.Page a)
	{
		if (fd.cvr(a) != 1)
		{
			return;
		}
		if (!fd.cvs(a, 2))
		{
			return;
		}
		Action<fd.Page> action = fd.ind;
		if (action == null)
		{
			return;
		}
		action(a);
	}

	// Token: 0x060012D3 RID: 4819 RVA: 0x0005C200 File Offset: 0x0005A400
	private static bool lve(fd.Page a, int b)
	{
		if (bq.hmh)
		{
			return false;
		}
		PlayerSaveData playerSaveData = fd.cvt();
		if (playerSaveData == null)
		{
			return false;
		}
		int num = ((a == fd.Page.Developer) ? playerSaveData.creatorPageDeveloperState : playerSaveData.creatorPagePublisherState);
		if (a == fd.Page.Developer)
		{
			playerSaveData.creatorPageDeveloperState = b;
		}
		else
		{
			playerSaveData.creatorPagePublisherState = b;
		}
		ci.Save(null);
		if (ci.hsa)
		{
			return true;
		}
		if (a == fd.Page.Developer)
		{
			playerSaveData.creatorPageDeveloperState = num;
		}
		else
		{
			playerSaveData.creatorPagePublisherState = num;
		}
		return false;
	}

	// Token: 0x1400002F RID: 47
	// (add) Token: 0x060012D5 RID: 4821 RVA: 0x0005C284 File Offset: 0x0005A484
	// (remove) Token: 0x060012EF RID: 4847 RVA: 0x0005C5B0 File Offset: 0x0005A7B0
	private static event Action<fd.Page> ind;

	// Token: 0x060012D6 RID: 4822 RVA: 0x0005C1A2 File Offset: 0x0005A3A2
	private void kxg()
	{
		if (fd.inc != null && fd.inc != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		fd.inc = this;
		fd.inb.Clear();
	}

	// Token: 0x060012D7 RID: 4823 RVA: 0x0005C2B7 File Offset: 0x0005A4B7
	private void OnApplicationFocus(bool hasFocus)
	{
		if (!hasFocus)
		{
			return;
		}
		fd.inb.Clear();
		if (bq.hmg)
		{
			fd.cvp();
		}
	}

	// Token: 0x060012D8 RID: 4824 RVA: 0x0005C2D4 File Offset: 0x0005A4D4
	private static bool eob(fd.Page a, int b)
	{
		if (bq.hmh)
		{
			return false;
		}
		PlayerSaveData playerSaveData = fd.cvt();
		if (playerSaveData == null)
		{
			return false;
		}
		int num = ((a == fd.Page.Developer) ? playerSaveData.creatorPageDeveloperState : playerSaveData.creatorPagePublisherState);
		if (a == fd.Page.Developer)
		{
			playerSaveData.creatorPageDeveloperState = b;
		}
		else
		{
			playerSaveData.creatorPagePublisherState = b;
		}
		ci.Save(null);
		if (ci.hsa)
		{
			return true;
		}
		if (a == fd.Page.Developer)
		{
			playerSaveData.creatorPageDeveloperState = num;
		}
		else
		{
			playerSaveData.creatorPagePublisherState = num;
		}
		return false;
	}

	// Token: 0x060012D9 RID: 4825 RVA: 0x0005C1DA File Offset: 0x0005A3DA
	private static void cvq(fd.Page a)
	{
		if (fd.cvr(a) != 1)
		{
			return;
		}
		if (!fd.cvs(a, 2))
		{
			return;
		}
		Action<fd.Page> action = fd.ind;
		if (action == null)
		{
			return;
		}
		action(a);
	}

	// Token: 0x060012DA RID: 4826 RVA: 0x0005C340 File Offset: 0x0005A540
	public static void fdy(fd.Page a)
	{
		fd.cvl();
		int num = fd.cvr(a);
		if (num == 2)
		{
			return;
		}
		if (num == 1)
		{
			fd.inb.Add(a);
			return;
		}
		if (fd.cvs(a, 1))
		{
			fd.inb.Add(a);
		}
	}

	// Token: 0x060012DB RID: 4827 RVA: 0x0005C0A0 File Offset: 0x0005A2A0
	public static bool nyx(fd.Page a)
	{
		return fd.cvr(a) == 2;
	}

	// Token: 0x060012DC RID: 4828 RVA: 0x0005C384 File Offset: 0x0005A584
	private static int cvr(fd.Page a)
	{
		PlayerSaveData playerSaveData = fd.cvt();
		if (playerSaveData == null)
		{
			return 0;
		}
		if (a != fd.Page.Developer)
		{
			return playerSaveData.creatorPagePublisherState;
		}
		return playerSaveData.creatorPageDeveloperState;
	}

	// Token: 0x060012DE RID: 4830 RVA: 0x0005C3AC File Offset: 0x0005A5AC
	public static void jvy(Action<fd.Page> a)
	{
		if (a == null)
		{
			return;
		}
		fd.ind -= a;
	}

	// Token: 0x060012DF RID: 4831 RVA: 0x0005C3B8 File Offset: 0x0005A5B8
	private static PlayerSaveData hzv()
	{
		if (!(bq.hlf != null))
		{
			return null;
		}
		return bq.hlf.playerSaveData;
	}

	// Token: 0x060012E0 RID: 4832 RVA: 0x0005C3D4 File Offset: 0x0005A5D4
	private static bool cvs(fd.Page a, int b)
	{
		if (bq.hmh)
		{
			return false;
		}
		PlayerSaveData playerSaveData = fd.cvt();
		if (playerSaveData == null)
		{
			return false;
		}
		int num = ((a == fd.Page.Developer) ? playerSaveData.creatorPageDeveloperState : playerSaveData.creatorPagePublisherState);
		if (a == fd.Page.Developer)
		{
			playerSaveData.creatorPageDeveloperState = b;
		}
		else
		{
			playerSaveData.creatorPagePublisherState = b;
		}
		ci.Save(null);
		if (ci.hsa)
		{
			return true;
		}
		if (a == fd.Page.Developer)
		{
			playerSaveData.creatorPageDeveloperState = num;
		}
		else
		{
			playerSaveData.creatorPagePublisherState = num;
		}
		return false;
	}

	// Token: 0x060012E1 RID: 4833 RVA: 0x0005C0A0 File Offset: 0x0005A2A0
	public static bool cvn(fd.Page a)
	{
		return fd.cvr(a) == 2;
	}

	// Token: 0x060012E2 RID: 4834 RVA: 0x0005C3AC File Offset: 0x0005A5AC
	public static void esw(Action<fd.Page> a)
	{
		if (a == null)
		{
			return;
		}
		fd.ind -= a;
	}

	// Token: 0x060012E4 RID: 4836 RVA: 0x0005C445 File Offset: 0x0005A645
	public static void cvi(Action<fd.Page> a)
	{
		if (a == null)
		{
			return;
		}
		fd.ind += a;
		fd.cvj(a);
	}

	// Token: 0x060012E5 RID: 4837 RVA: 0x0005C458 File Offset: 0x0005A658
	private static bool gda(fd.Page a, int b)
	{
		if (bq.hmh)
		{
			return false;
		}
		PlayerSaveData playerSaveData = fd.cvt();
		if (playerSaveData == null)
		{
			return false;
		}
		int num = ((a == fd.Page.Developer) ? playerSaveData.creatorPageDeveloperState : playerSaveData.creatorPagePublisherState);
		if (a == fd.Page.Developer)
		{
			playerSaveData.creatorPageDeveloperState = b;
		}
		else
		{
			playerSaveData.creatorPagePublisherState = b;
		}
		ci.Save(null);
		if (ci.hsa)
		{
			return true;
		}
		if (a == fd.Page.Developer)
		{
			playerSaveData.creatorPageDeveloperState = num;
		}
		else
		{
			playerSaveData.creatorPagePublisherState = num;
		}
		return false;
	}

	// Token: 0x060012E6 RID: 4838 RVA: 0x0005C4C4 File Offset: 0x0005A6C4
	private static void nhj()
	{
		foreach (fd.Page page in fd.ina)
		{
			if (!fd.inb.Contains(page))
			{
				fd.cvq(page);
			}
		}
	}

	// Token: 0x060012E7 RID: 4839 RVA: 0x0005C4FC File Offset: 0x0005A6FC
	private static void cvo()
	{
		foreach (fd.Page page in fd.ina)
		{
			if (!fd.inb.Contains(page))
			{
				fd.cvq(page);
			}
		}
	}

	// Token: 0x060012E8 RID: 4840 RVA: 0x0005C0A0 File Offset: 0x0005A2A0
	public static bool mnz(fd.Page a)
	{
		return fd.cvr(a) == 2;
	}

	// Token: 0x060012E9 RID: 4841 RVA: 0x0005C534 File Offset: 0x0005A734
	private static void hxh(Action<fd.Page> a)
	{
		if (a == null)
		{
			return;
		}
		foreach (fd.Page page in fd.ina)
		{
			if (fd.cvn(page))
			{
				a(page);
			}
		}
	}

	// Token: 0x060012EA RID: 4842 RVA: 0x0005C3AC File Offset: 0x0005A5AC
	public static void cvk(Action<fd.Page> a)
	{
		if (a == null)
		{
			return;
		}
		fd.ind -= a;
	}

	// Token: 0x060012EB RID: 4843 RVA: 0x0005C56C File Offset: 0x0005A76C
	public static void jwi(fd.Page a)
	{
		fd.cvl();
		int num = fd.cvr(a);
		if (num == 2)
		{
			return;
		}
		if (num == 1)
		{
			fd.inb.Add(a);
			return;
		}
		if (fd.cvs(a, 1))
		{
			fd.inb.Add(a);
		}
	}

	// Token: 0x060012EC RID: 4844 RVA: 0x0005C1DA File Offset: 0x0005A3DA
	private static void jrn(fd.Page a)
	{
		if (fd.cvr(a) != 1)
		{
			return;
		}
		if (!fd.cvs(a, 2))
		{
			return;
		}
		Action<fd.Page> action = fd.ind;
		if (action == null)
		{
			return;
		}
		action(a);
	}

	// Token: 0x060012ED RID: 4845 RVA: 0x0005C1DA File Offset: 0x0005A3DA
	private static void fhz(fd.Page a)
	{
		if (fd.cvr(a) != 1)
		{
			return;
		}
		if (!fd.cvs(a, 2))
		{
			return;
		}
		Action<fd.Page> action = fd.ind;
		if (action == null)
		{
			return;
		}
		action(a);
	}

	// Token: 0x060012EE RID: 4846 RVA: 0x0005C0A0 File Offset: 0x0005A2A0
	public static bool hlt(fd.Page a)
	{
		return fd.cvr(a) == 2;
	}

	// Token: 0x060012F0 RID: 4848 RVA: 0x0005C1A2 File Offset: 0x0005A3A2
	private void jdg()
	{
		if (fd.inc != null && fd.inc != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		fd.inc = this;
		fd.inb.Clear();
	}

	// Token: 0x060012F1 RID: 4849 RVA: 0x0005C5E4 File Offset: 0x0005A7E4
	private static void mfy()
	{
		foreach (fd.Page page in fd.ina)
		{
			if (!fd.inb.Contains(page))
			{
				fd.cvq(page);
			}
		}
	}

	// Token: 0x060012F2 RID: 4850 RVA: 0x0005C61C File Offset: 0x0005A81C
	private void oh()
	{
		if (fd.inc == this)
		{
			fd.inc = null;
		}
	}

	// Token: 0x060012F3 RID: 4851 RVA: 0x0005C634 File Offset: 0x0005A834
	public static void cvm(fd.Page a)
	{
		fd.cvl();
		int num = fd.cvr(a);
		if (num == 2)
		{
			return;
		}
		if (num == 1)
		{
			fd.inb.Add(a);
			return;
		}
		if (fd.cvs(a, 1))
		{
			fd.inb.Add(a);
		}
	}

	// Token: 0x060012F4 RID: 4852 RVA: 0x0005C678 File Offset: 0x0005A878
	private static void ert(Action<fd.Page> a)
	{
		if (a == null)
		{
			return;
		}
		foreach (fd.Page page in fd.ina)
		{
			if (fd.cvn(page))
			{
				a(page);
			}
		}
	}

	// Token: 0x060012F5 RID: 4853 RVA: 0x0005C3B8 File Offset: 0x0005A5B8
	private static PlayerSaveData cvt()
	{
		if (!(bq.hlf != null))
		{
			return null;
		}
		return bq.hlf.playerSaveData;
	}

	// Token: 0x060012F6 RID: 4854 RVA: 0x0005C6B0 File Offset: 0x0005A8B0
	public static void kva()
	{
		if (fd.inc != null)
		{
			return;
		}
		GameObject gameObject = new GameObject(a.dry());
		global::UnityEngine.Object.DontDestroyOnLoad(gameObject);
		gameObject.AddComponent<fd>();
	}

	// Token: 0x060012F7 RID: 4855 RVA: 0x0005C6D6 File Offset: 0x0005A8D6
	private IEnumerator Start()
	{
		while (!bq.hmg)
		{
			yield return null;
		}
		fd.cvj(fd.ind);
		fd.cvo();
		yield break;
	}

	// Token: 0x060012F8 RID: 4856 RVA: 0x0005C6E0 File Offset: 0x0005A8E0
	private static void cvj(Action<fd.Page> a)
	{
		if (a == null)
		{
			return;
		}
		foreach (fd.Page page in fd.ina)
		{
			if (fd.cvn(page))
			{
				a(page);
			}
		}
	}

	// Token: 0x060012F9 RID: 4857 RVA: 0x0005C61C File Offset: 0x0005A81C
	private void OnDestroy()
	{
		if (fd.inc == this)
		{
			fd.inc = null;
		}
	}

	// Token: 0x060012FA RID: 4858 RVA: 0x0005C1A2 File Offset: 0x0005A3A2
	private void bma()
	{
		if (fd.inc != null && fd.inc != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		fd.inc = this;
		fd.inb.Clear();
	}

	// Token: 0x060012FB RID: 4859 RVA: 0x0005C718 File Offset: 0x0005A918
	private static void mlb(Action<fd.Page> a)
	{
		if (a == null)
		{
			return;
		}
		foreach (fd.Page page in fd.ina)
		{
			if (fd.cvn(page))
			{
				a(page);
			}
		}
	}

	// Token: 0x040009CD RID: 2509
	private const int imx = 0;

	// Token: 0x040009CE RID: 2510
	private const int imy = 1;

	// Token: 0x040009CF RID: 2511
	private const int imz = 2;

	// Token: 0x040009D0 RID: 2512
	private static readonly fd.Page[] ina = new fd.Page[]
	{
		fd.Page.Developer,
		fd.Page.Publisher
	};

	// Token: 0x040009D1 RID: 2513
	private static readonly HashSet<fd.Page> inb = new HashSet<fd.Page>();

	// Token: 0x02000103 RID: 259
	public enum Page
	{
		// Token: 0x040009D5 RID: 2517
		Developer,
		// Token: 0x040009D6 RID: 2518
		Publisher
	}
}
