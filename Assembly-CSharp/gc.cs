using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

// Token: 0x0200012C RID: 300
public static class gc
{
	// Token: 0x060015ED RID: 5613 RVA: 0x0006B230 File Offset: 0x00069430
	public static void bnt(ulong a, bool b)
	{
		if (a == 0UL)
		{
			return;
		}
		gc.ivw[a] = b;
		if (b)
		{
			PlayerPrefs.SetInt(a.egj() + a.ToString(), 1);
			return;
		}
		PlayerPrefs.DeleteKey(a.egk() + a.ToString());
	}

	// Token: 0x060015EE RID: 5614 RVA: 0x0006B280 File Offset: 0x00069480
	public static void hpq(ulong a, bool b)
	{
		if (a == 0UL)
		{
			return;
		}
		gc.ivw[a] = b;
		if (b)
		{
			PlayerPrefs.SetInt(a.egl() + a.ToString(), 1);
			return;
		}
		PlayerPrefs.DeleteKey(a.egm() + a.ToString());
	}

	// Token: 0x060015EF RID: 5615 RVA: 0x0006B2CE File Offset: 0x000694CE
	private static Vector3 bho(Vector3 a)
	{
		if (!(bx.hod != null))
		{
			return a;
		}
		return bx.hod.koe;
	}

	// Token: 0x060015F0 RID: 5616 RVA: 0x0006B2EC File Offset: 0x000694EC
	public static void dmv(ulong a, bool b)
	{
		if (a == 0UL)
		{
			return;
		}
		gc.ivw[a] = b;
		if (b)
		{
			PlayerPrefs.SetInt(a.egn() + a.ToString(), 1);
			return;
		}
		PlayerPrefs.DeleteKey(a.egn() + a.ToString());
	}

	// Token: 0x060015F1 RID: 5617 RVA: 0x0006B33C File Offset: 0x0006953C
	public static EventInstance dmy(EventReference a, Vector3 b, EVENT_CALLBACK c, EVENT_CALLBACK_TYPE d, Action<EventInstance> e)
	{
		if (gc.kvf || a.IsNull)
		{
			EventInstance eventInstance = default(EventInstance);
			return eventInstance;
		}
		EventInstance eventInstance2;
		try
		{
			eventInstance2 = RuntimeManager.CreateInstance(a);
		}
		catch (EventNotFoundException)
		{
			EventInstance eventInstance = default(EventInstance);
			return eventInstance;
		}
		if (!eventInstance2.isValid())
		{
			return default(EventInstance);
		}
		eventInstance2.set3DAttributes(gc.dmw(b).To3DAttributes());
		eventInstance2.setProperty(EVENT_PROPERTY.MINIMUM_DISTANCE, AudioManager.minDistance);
		eventInstance2.setProperty(EVENT_PROPERTY.MAXIMUM_DISTANCE, AudioManager.maxDistance);
		eventInstance2.setVolume(gc.kve);
		if (e != null)
		{
			e(eventInstance2);
		}
		eventInstance2.setCallback(c, d);
		eventInstance2.start();
		eventInstance2.release();
		return eventInstance2;
	}

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x060015F2 RID: 5618 RVA: 0x0006B404 File Offset: 0x00069604
	// (set) Token: 0x060015FD RID: 5629 RVA: 0x0006B587 File Offset: 0x00069787
	public static float kve
	{
		get
		{
			if (gc.ivu == null)
			{
				gc.ivu = new float?(Mathf.Clamp01(PlayerPrefs.GetFloat(a.ego(), 1f)));
			}
			return gc.ivu.Value;
		}
		set
		{
			gc.ivu = new float?(Mathf.Clamp01(value));
			PlayerPrefs.SetFloat(a.ego(), gc.ivu.Value);
		}
	}

	// Token: 0x060015F3 RID: 5619 RVA: 0x0006B2CE File Offset: 0x000694CE
	private static Vector3 ikk(Vector3 a)
	{
		if (!(bx.hod != null))
		{
			return a;
		}
		return bx.hod.koe;
	}

	// Token: 0x060015F4 RID: 5620 RVA: 0x0006B43C File Offset: 0x0006963C
	public static EventInstance dmx(EventReference a, Vector3 b)
	{
		if (gc.kvf || a.IsNull || AudioManager.klw == null)
		{
			return default(EventInstance);
		}
		return AudioManager.klw.qw(a, gc.dmw(b), gc.kve);
	}

	// Token: 0x060015F5 RID: 5621 RVA: 0x0006B488 File Offset: 0x00069688
	public static bool dmu(ulong a)
	{
		if (a == 0UL)
		{
			return false;
		}
		bool flag;
		if (gc.ivw.TryGetValue(a, out flag))
		{
			return flag;
		}
		bool flag2 = PlayerPrefs.GetInt(a.egn() + a.ToString(), 0) == 1;
		gc.ivw[a] = flag2;
		return flag2;
	}

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x060015F6 RID: 5622 RVA: 0x0006B4D3 File Offset: 0x000696D3
	// (set) Token: 0x060015FB RID: 5627 RVA: 0x0006B569 File Offset: 0x00069769
	public static bool kvd
	{
		get
		{
			if (gc.ivt == null)
			{
				gc.ivt = new bool?(PlayerPrefs.GetInt(a.egp(), 1) == 1);
			}
			return gc.ivt.Value;
		}
		set
		{
			gc.ivt = new bool?(value);
			PlayerPrefs.SetInt(a.egp(), value ? 1 : 0);
		}
	}

	// Token: 0x060015F7 RID: 5623 RVA: 0x0006B504 File Offset: 0x00069704
	public static bool ll(ulong a)
	{
		if (a == 0UL)
		{
			return false;
		}
		bool flag;
		if (gc.ivw.TryGetValue(a, out flag))
		{
			return flag;
		}
		bool flag2 = PlayerPrefs.GetInt(a.egq() + a.ToString(), 0) == 1;
		gc.ivw[a] = flag2;
		return flag2;
	}

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x060015F8 RID: 5624 RVA: 0x0006B54F File Offset: 0x0006974F
	public static bool kvf
	{
		get
		{
			return !gc.kvd || gc.kve <= 0.001f;
		}
	}

	// Token: 0x060015F9 RID: 5625 RVA: 0x0006B2CE File Offset: 0x000694CE
	private static Vector3 dmw(Vector3 a)
	{
		if (!(bx.hod != null))
		{
			return a;
		}
		return bx.hod.koe;
	}

	// Token: 0x060015FA RID: 5626 RVA: 0x0006B2CE File Offset: 0x000694CE
	private static Vector3 kwm(Vector3 a)
	{
		if (!(bx.hod != null))
		{
			return a;
		}
		return bx.hod.koe;
	}

	// Token: 0x060015FC RID: 5628 RVA: 0x0006B2CE File Offset: 0x000694CE
	private static Vector3 mhs(Vector3 a)
	{
		if (!(bx.hod != null))
		{
			return a;
		}
		return bx.hod.koe;
	}

	// Token: 0x060015FE RID: 5630 RVA: 0x0006B5B0 File Offset: 0x000697B0
	public static EventInstance dte(EventReference a, Vector3 b)
	{
		if (gc.kvf || a.IsNull || AudioManager.klw == null)
		{
			return default(EventInstance);
		}
		return AudioManager.klw.qw(a, gc.dmw(b), gc.kve);
	}

	// Token: 0x060015FF RID: 5631 RVA: 0x0006B5FC File Offset: 0x000697FC
	public static EventInstance khs(EventReference a, Vector3 b)
	{
		if (gc.kvf || a.IsNull || AudioManager.klw == null)
		{
			return default(EventInstance);
		}
		return AudioManager.klw.qw(a, gc.dmw(b), gc.kve);
	}

	// Token: 0x04000B19 RID: 2841
	public const string ivr = "Settings_RemotePlayerSound";

	// Token: 0x04000B1A RID: 2842
	public const string ivs = "Settings_RemotePlayerVolume";

	// Token: 0x04000B1B RID: 2843
	private static bool? ivt;

	// Token: 0x04000B1C RID: 2844
	private static float? ivu;

	// Token: 0x04000B1D RID: 2845
	private const string ivv = "mp_mute_";

	// Token: 0x04000B1E RID: 2846
	private static readonly Dictionary<ulong, bool> ivw = new Dictionary<ulong, bool>();
}
