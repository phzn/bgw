using System;
using Rewired;
using Rewired.Integration.UnityUI;
using UnityEngine;

// Token: 0x02000025 RID: 37
public class bd : MonoBehaviour
{
	// Token: 0x17000030 RID: 48
	// (get) Token: 0x06000212 RID: 530 RVA: 0x0000ADFE File Offset: 0x00008FFE
	public static Player kmp
	{
		get
		{
			if (bd.hik == null)
			{
				bd.hik = ReInput.players.GetPlayer(0);
			}
			return bd.hik;
		}
	}

	// Token: 0x06000213 RID: 531 RVA: 0x0000AE1C File Offset: 0x0000901C
	private void Awake()
	{
		if (bd.him != null && bd.him != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		bd.him = this;
		this.hil = global::UnityEngine.Object.FindAnyObjectByType<RewiredStandaloneInputModule>();
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000214 RID: 532 RVA: 0x0000AE6C File Offset: 0x0000906C
	private void fog()
	{
		if (bd.him != null && bd.him != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		bd.him = this;
		this.hil = global::UnityEngine.Object.FindAnyObjectByType<RewiredStandaloneInputModule>();
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x06000215 RID: 533 RVA: 0x0000AEBB File Offset: 0x000090BB
	public static bd kmr
	{
		get
		{
			return bd.him;
		}
	}

	// Token: 0x06000217 RID: 535 RVA: 0x0000AEC4 File Offset: 0x000090C4
	private void kvy()
	{
		if (bd.him != null && bd.him != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		bd.him = this;
		this.hil = global::UnityEngine.Object.FindAnyObjectByType<RewiredStandaloneInputModule>();
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000218 RID: 536 RVA: 0x0000AF14 File Offset: 0x00009114
	private void kga()
	{
		if (bd.him != null && bd.him != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		bd.him = this;
		this.hil = global::UnityEngine.Object.FindAnyObjectByType<RewiredStandaloneInputModule>();
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x06000219 RID: 537 RVA: 0x0000AF63 File Offset: 0x00009163
	public RewiredStandaloneInputModule kmq
	{
		get
		{
			return this.hil;
		}
	}

	// Token: 0x0600021A RID: 538 RVA: 0x0000AF6C File Offset: 0x0000916C
	private void kit()
	{
		if (bd.him != null && bd.him != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		bd.him = this;
		this.hil = global::UnityEngine.Object.FindAnyObjectByType<RewiredStandaloneInputModule>();
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x04000120 RID: 288
	private static Player hik;

	// Token: 0x04000121 RID: 289
	private RewiredStandaloneInputModule hil;

	// Token: 0x04000122 RID: 290
	private static bd him;
}
