using System;
using System.Collections.Generic;
using BongoWaifu.Multiplayer;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000130 RID: 304
public sealed class gd : MonoBehaviour
{
	// Token: 0x06001638 RID: 5688 RVA: 0x0006CCAE File Offset: 0x0006AEAE
	private static bool dos()
	{
		return EventSystem.current != null && EventSystem.current.IsPointerOverGameObject();
	}

	// Token: 0x06001639 RID: 5689 RVA: 0x0006D08C File Offset: 0x0006B28C
	private void Update()
	{
		if (this.ixm != null)
		{
			if (!this.ixm.isActiveAndEnabled)
			{
				this.ixm.doi();
				this.ixm = null;
			}
			else
			{
				if (Input.GetMouseButton(0))
				{
					this.ixm.doh(Input.mousePosition);
					return;
				}
				this.ixm.doi();
				this.ixm = null;
			}
		}
		if (MultiplayerSession.kuk.Count == 0)
		{
			this.dor(null);
			return;
		}
		Camera main = Camera.main;
		if (main == null)
		{
			this.dor(null);
			return;
		}
		Vector3 mousePosition = Input.mousePosition;
		Vector2 vector;
		gb gb = gd.doq(main, mousePosition, out vector);
		RemoteAvatarPlacement remoteAvatarPlacement = ((gb != null) ? gb.iuu : null);
		this.dor(remoteAvatarPlacement);
		if (remoteAvatarPlacement != null && Input.GetMouseButtonDown(0) && !gd.dos())
		{
			remoteAvatarPlacement.dog(mousePosition);
			remoteAvatarPlacement.dny();
			this.ixm = remoteAvatarPlacement;
		}
	}

	// Token: 0x0600163A RID: 5690 RVA: 0x0006D170 File Offset: 0x0006B370
	internal static gb emz(Camera a, Vector3 b, out Vector2 c)
	{
		gb gb = null;
		Vector2 vector = new Vector2(-265f, -3836f);
		int num = -32;
		IReadOnlyList<gb> readOnlyList = MultiplayerSession.kuk;
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			gb gb2 = readOnlyList[i];
			Bounds bounds;
			Vector2 vector2;
			if (gb2 != null && !(gb2.iuu == null) && !(gb2.iur == null) && gb2.iur.enabled && gb2.iur.gameObject.activeInHierarchy && gb2.iuu.dnv(out bounds) && fu.dcl(a, bounds, b, out vector2) && gb2.iuu.ixk > num)
			{
				gb = gb2;
				vector = vector2;
				num = gb2.iuu.ixk;
			}
		}
		c = vector;
		return gb;
	}

	// Token: 0x0600163B RID: 5691 RVA: 0x0006D250 File Offset: 0x0006B450
	private void lgn()
	{
		if (this.ixm != null)
		{
			if (!this.ixm.isActiveAndEnabled)
			{
				this.ixm.doi();
				this.ixm = null;
			}
			else
			{
				if (Input.GetMouseButton(0))
				{
					this.ixm.doh(Input.mousePosition);
					return;
				}
				this.ixm.doi();
				this.ixm = null;
			}
		}
		if (MultiplayerSession.kuk.Count == 0)
		{
			this.dor(null);
			return;
		}
		Camera main = Camera.main;
		if (main == null)
		{
			this.dor(null);
			return;
		}
		Vector3 mousePosition = Input.mousePosition;
		Vector2 vector;
		gb gb = gd.doq(main, mousePosition, out vector);
		RemoteAvatarPlacement remoteAvatarPlacement = ((gb != null) ? gb.iuu : null);
		this.dor(remoteAvatarPlacement);
		if (remoteAvatarPlacement != null && Input.GetMouseButtonDown(0) && !gd.dos())
		{
			remoteAvatarPlacement.dog(mousePosition);
			remoteAvatarPlacement.dny();
			this.ixm = remoteAvatarPlacement;
		}
	}

	// Token: 0x0600163C RID: 5692 RVA: 0x0006D334 File Offset: 0x0006B534
	internal static gb lpt(Camera a, Vector3 b, out Vector2 c)
	{
		gb gb = null;
		Vector2 vector = new Vector2(1604f, 5575f);
		int num = -6;
		IReadOnlyList<gb> readOnlyList = MultiplayerSession.kuk;
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			gb gb2 = readOnlyList[i];
			Bounds bounds;
			Vector2 vector2;
			if (gb2 != null && !(gb2.iuu == null) && !(gb2.iur == null) && gb2.iur.enabled && gb2.iur.gameObject.activeInHierarchy && gb2.iuu.dnv(out bounds) && fu.dcl(a, bounds, b, out vector2) && gb2.iuu.ixk > num)
			{
				gb = gb2;
				vector = vector2;
				num = gb2.iuu.ixk;
			}
		}
		c = vector;
		return gb;
	}

	// Token: 0x0600163D RID: 5693 RVA: 0x0006D414 File Offset: 0x0006B614
	internal static gb kz(Camera a, Vector3 b, out Vector2 c)
	{
		gb gb = null;
		Vector2 vector = new Vector2(-1222f, 90f);
		int num = -75;
		IReadOnlyList<gb> readOnlyList = MultiplayerSession.kuk;
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			gb gb2 = readOnlyList[i];
			Bounds bounds;
			Vector2 vector2;
			if (gb2 != null && !(gb2.iuu == null) && !(gb2.iur == null) && gb2.iur.enabled && gb2.iur.gameObject.activeInHierarchy && gb2.iuu.dnv(out bounds) && fu.dcl(a, bounds, b, out vector2) && gb2.iuu.ixk > num)
			{
				gb = gb2;
				vector = vector2;
				num = gb2.iuu.ixk;
			}
		}
		c = vector;
		return gb;
	}

	// Token: 0x0600163F RID: 5695 RVA: 0x0006CCAE File Offset: 0x0006AEAE
	private static bool izm()
	{
		return EventSystem.current != null && EventSystem.current.IsPointerOverGameObject();
	}

	// Token: 0x06001640 RID: 5696 RVA: 0x0006D4F4 File Offset: 0x0006B6F4
	private void nat()
	{
		if (this.ixm != null)
		{
			if (!this.ixm.isActiveAndEnabled)
			{
				this.ixm.doi();
				this.ixm = null;
			}
			else
			{
				if (Input.GetMouseButton(0))
				{
					this.ixm.doh(Input.mousePosition);
					return;
				}
				this.ixm.doi();
				this.ixm = null;
			}
		}
		if (MultiplayerSession.kuk.Count == 0)
		{
			this.dor(null);
			return;
		}
		Camera main = Camera.main;
		if (main == null)
		{
			this.dor(null);
			return;
		}
		Vector3 mousePosition = Input.mousePosition;
		Vector2 vector;
		gb gb = gd.doq(main, mousePosition, out vector);
		RemoteAvatarPlacement remoteAvatarPlacement = ((gb != null) ? gb.iuu : null);
		this.dor(remoteAvatarPlacement);
		if (remoteAvatarPlacement != null && Input.GetMouseButtonDown(0) && !gd.dos())
		{
			remoteAvatarPlacement.dog(mousePosition);
			remoteAvatarPlacement.dny();
			this.ixm = remoteAvatarPlacement;
		}
	}

	// Token: 0x06001641 RID: 5697 RVA: 0x0006D5D8 File Offset: 0x0006B7D8
	internal static gb ehk(Camera a, Vector3 b, out Vector2 c)
	{
		gb gb = null;
		Vector2 vector = new Vector2(4125f, -1568f);
		int num = 9;
		IReadOnlyList<gb> readOnlyList = MultiplayerSession.kuk;
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			gb gb2 = readOnlyList[i];
			Bounds bounds;
			Vector2 vector2;
			if (gb2 != null && !(gb2.iuu == null) && !(gb2.iur == null) && gb2.iur.enabled && gb2.iur.gameObject.activeInHierarchy && gb2.iuu.dnv(out bounds) && fu.dcl(a, bounds, b, out vector2) && gb2.iuu.ixk > num)
			{
				gb = gb2;
				vector = vector2;
				num = gb2.iuu.ixk;
			}
		}
		c = vector;
		return gb;
	}

	// Token: 0x06001642 RID: 5698 RVA: 0x0006D6B8 File Offset: 0x0006B8B8
	internal static gb doq(Camera a, Vector3 b, out Vector2 c)
	{
		gb gb = null;
		Vector2 vector = new Vector2(0.5f, 0.5f);
		int num = int.MinValue;
		IReadOnlyList<gb> readOnlyList = MultiplayerSession.kuk;
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			gb gb2 = readOnlyList[i];
			Bounds bounds;
			Vector2 vector2;
			if (gb2 != null && !(gb2.iuu == null) && !(gb2.iur == null) && gb2.iur.enabled && gb2.iur.gameObject.activeInHierarchy && gb2.iuu.dnv(out bounds) && fu.dcl(a, bounds, b, out vector2) && gb2.iuu.ixk > num)
			{
				gb = gb2;
				vector = vector2;
				num = gb2.iuu.ixk;
			}
		}
		c = vector;
		return gb;
	}

	// Token: 0x06001643 RID: 5699 RVA: 0x0006D79C File Offset: 0x0006B99C
	private void bkq()
	{
		if (this.ixm != null)
		{
			if (!this.ixm.isActiveAndEnabled)
			{
				this.ixm.doi();
				this.ixm = null;
			}
			else
			{
				if (Input.GetMouseButton(0))
				{
					this.ixm.doh(Input.mousePosition);
					return;
				}
				this.ixm.doi();
				this.ixm = null;
			}
		}
		if (MultiplayerSession.kuk.Count == 0)
		{
			this.dor(null);
			return;
		}
		Camera main = Camera.main;
		if (main == null)
		{
			this.dor(null);
			return;
		}
		Vector3 mousePosition = Input.mousePosition;
		Vector2 vector;
		gb gb = gd.doq(main, mousePosition, out vector);
		RemoteAvatarPlacement remoteAvatarPlacement = ((gb != null) ? gb.iuu : null);
		this.dor(remoteAvatarPlacement);
		if (remoteAvatarPlacement != null && Input.GetMouseButtonDown(0) && !gd.dos())
		{
			remoteAvatarPlacement.dog(mousePosition);
			remoteAvatarPlacement.dny();
			this.ixm = remoteAvatarPlacement;
		}
	}

	// Token: 0x06001644 RID: 5700 RVA: 0x0006CCAE File Offset: 0x0006AEAE
	private static bool iea()
	{
		return EventSystem.current != null && EventSystem.current.IsPointerOverGameObject();
	}

	// Token: 0x06001645 RID: 5701 RVA: 0x0006D880 File Offset: 0x0006BA80
	private void dor(RemoteAvatarPlacement a)
	{
		if (this.ixl == a)
		{
			return;
		}
		if (this.ixl != null)
		{
			this.ixl.dod();
		}
		this.ixl = a;
		if (this.ixl != null)
		{
			this.ixl.doc();
		}
	}

	// Token: 0x06001646 RID: 5702 RVA: 0x0006D8D8 File Offset: 0x0006BAD8
	private void kxu(RemoteAvatarPlacement a)
	{
		if (this.ixl == a)
		{
			return;
		}
		if (this.ixl != null)
		{
			this.ixl.dod();
		}
		this.ixl = a;
		if (this.ixl != null)
		{
			this.ixl.doc();
		}
	}

	// Token: 0x06001647 RID: 5703 RVA: 0x0006D930 File Offset: 0x0006BB30
	private void mlu(RemoteAvatarPlacement a)
	{
		if (this.ixl == a)
		{
			return;
		}
		if (this.ixl != null)
		{
			this.ixl.dod();
		}
		this.ixl = a;
		if (this.ixl != null)
		{
			this.ixl.doc();
		}
	}

	// Token: 0x06001648 RID: 5704 RVA: 0x0006CCAE File Offset: 0x0006AEAE
	private static bool bdx()
	{
		return EventSystem.current != null && EventSystem.current.IsPointerOverGameObject();
	}

	// Token: 0x04000B4C RID: 2892
	private RemoteAvatarPlacement ixl;

	// Token: 0x04000B4D RID: 2893
	private RemoteAvatarPlacement ixm;
}
