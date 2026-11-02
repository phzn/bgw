using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Steamworks;
using UnityEngine;

// Token: 0x020000AF RID: 175
public class dq : MonoBehaviour
{
	// Token: 0x170000AC RID: 172
	// (get) Token: 0x06000948 RID: 2376 RVA: 0x00038808 File Offset: 0x00036A08
	public static dq kqv
	{
		get
		{
			return dq.hzr;
		}
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x0003880F File Offset: 0x00036A0F
	private void Awake()
	{
		if (dq.hzr != null && dq.hzr != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		dq.hzr = this;
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00038848 File Offset: 0x00036A48
	public void ccp(string a)
	{
		if (!SteamManager.krd)
		{
			return;
		}
		if (string.IsNullOrWhiteSpace(a))
		{
			SteamFriends.SetRichPresence(a.cpa(), string.Empty);
			SteamFriends.SetRichPresence(a.cpb(), string.Empty);
			bo bo = bo.hke;
			if (bo == null)
			{
				return;
			}
			bo.yn(null);
			return;
		}
		else
		{
			SteamFriends.SetRichPresence(a.cpa(), a);
			SteamFriends.SetRichPresence(a.cpb(), a.cpc());
			bo bo2 = bo.hke;
			if (bo2 == null)
			{
				return;
			}
			bo2.yn(a);
			return;
		}
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x000388C4 File Offset: 0x00036AC4
	public void byq(string a)
	{
		if (!SteamManager.krd)
		{
			return;
		}
		if (string.IsNullOrWhiteSpace(a))
		{
			SteamFriends.SetRichPresence(a.cpd(), string.Empty);
			SteamFriends.SetRichPresence(a.cpe(), string.Empty);
			bo bo = bo.hke;
			if (bo == null)
			{
				return;
			}
			bo.yn(null);
			return;
		}
		else
		{
			SteamFriends.SetRichPresence(a.cpf(), a);
			SteamFriends.SetRichPresence(a.cpg(), a.cph());
			bo bo2 = bo.hke;
			if (bo2 == null)
			{
				return;
			}
			bo2.yn(a);
			return;
		}
	}

	// Token: 0x040007B5 RID: 1973
	private static dq hzr;
}
