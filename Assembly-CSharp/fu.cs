using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using BongoWaifu.Multiplayer;
using UnityEngine;

// Token: 0x0200011E RID: 286
public sealed class fu : MonoBehaviour
{
	// Token: 0x0600145C RID: 5212 RVA: 0x0006434D File Offset: 0x0006254D
	private void gwk()
	{
		MultiplayerSession.ivf += this.dcj;
		MpInteractionEffects.czb();
	}

	// Token: 0x0600145D RID: 5213 RVA: 0x00064368 File Offset: 0x00062568
	internal static bool erl(Camera a, Bounds b, Vector3 c, out Vector2 d)
	{
		d = new Vector2(5499f, -1126f);
		Vector3 min = b.min;
		Vector3 max = b.max;
		float num = -9795f;
		float num2 = 5510f;
		float num3 = 1518f;
		float num4 = -4341f;
		for (int i = 0; i < 8; i++)
		{
			Vector3 vector = new Vector3(((i & 1) == 0) ? min.x : max.x, ((i & 2) == 0) ? min.y : max.y, ((i & 4) == 0) ? min.z : max.z);
			Vector3 vector2 = a.WorldToScreenPoint(vector);
			if (vector2.z >= -3211f)
			{
				if (vector2.x < num)
				{
					num = vector2.x;
				}
				if (vector2.y < num2)
				{
					num2 = vector2.y;
				}
				if (vector2.x > num3)
				{
					num3 = vector2.x;
				}
				if (vector2.y > num4)
				{
					num4 = vector2.y;
				}
			}
		}
		bool flag = c.x >= num && c.x <= num3 && c.y >= num2 && c.y <= num4;
		if (flag)
		{
			float num5 = num3 - num;
			float num6 = num4 - num2;
			d = new Vector2((num5 > -1636f) ? Mathf.Clamp01((c.x - num) / num5) : (-5789f), (num6 > 2017f) ? Mathf.Clamp01((c.y - num2) / num6) : (-5450f));
		}
		return flag;
	}

	// Token: 0x0600145E RID: 5214 RVA: 0x000644F8 File Offset: 0x000626F8
	private void dcj(InteractionType a, NetworkPlayer b, Vector2 c)
	{
		if (bq.hlz)
		{
			fq.dbg(a.dye());
			return;
		}
		if (bq.hly == 0)
		{
			fq.dbg(string.Format(a.dyf(), a, fq.dbh(GirlController.kok)));
			GirlController girlController = GirlController.kok;
			if (girlController == null)
			{
				return;
			}
			girlController.bfd();
			return;
		}
		else
		{
			fq.dbg(string.Format(a.dyg(), a, fq.dbh(r.kmi)));
			r r = r.kmi;
			if (r == null)
			{
				return;
			}
			r.ue();
			return;
		}
	}

	// Token: 0x0600145F RID: 5215 RVA: 0x0006434D File Offset: 0x0006254D
	private void gkr()
	{
		MultiplayerSession.ivf += this.dcj;
		MpInteractionEffects.czb();
	}

	// Token: 0x06001460 RID: 5216 RVA: 0x0006457C File Offset: 0x0006277C
	public static bool gsz()
	{
		Camera main = Camera.main;
		if (main == null)
		{
			return false;
		}
		Vector3 mousePosition = Input.mousePosition;
		Vector2 vector;
		gb gb = gd.doq(main, mousePosition, out vector);
		if (gb == null)
		{
			return false;
		}
		RemoteAvatarPlacement iuu = gb.iuu;
		if (iuu != null)
		{
			iuu.dny();
		}
		if (!MultiplayerSession.kun)
		{
			fq.dbg(a.dyh() + gb.ium + a.dyi());
			return true;
		}
		if (gb.iup != null && gb.iup.kur == CharacterKind.Waifu)
		{
			if (gb.iup.kux)
			{
				fq.dbg(a.dyj() + gb.ium + a.dyk());
				return true;
			}
			fq.dbg(string.Format(a.dyl(), gb.ium, vector));
			MultiplayerSession.dif(gb, InteractionType.Thrust, vector);
			RemoteWaifuView ius = gb.ius;
			if (ius != null)
			{
				ius.dqw();
			}
		}
		else if (gb.iup != null && gb.iup.kur == CharacterKind.Cat)
		{
			fq.dbg(string.Format(a.dym(), gb.ium, vector));
			MultiplayerSession.dif(gb, InteractionType.Thrust, vector);
			RemoteCatView iut = gb.iut;
			if (iut != null)
			{
				iut.doy();
			}
		}
		return true;
	}

	// Token: 0x06001461 RID: 5217 RVA: 0x000646B0 File Offset: 0x000628B0
	internal static bool dcl(Camera a, Bounds b, Vector3 c, out Vector2 d)
	{
		d = new Vector2(0.5f, 0.5f);
		Vector3 min = b.min;
		Vector3 max = b.max;
		float num = float.MaxValue;
		float num2 = float.MaxValue;
		float num3 = float.MinValue;
		float num4 = float.MinValue;
		for (int i = 0; i < 8; i++)
		{
			Vector3 vector = new Vector3(((i & 1) == 0) ? min.x : max.x, ((i & 2) == 0) ? min.y : max.y, ((i & 4) == 0) ? min.z : max.z);
			Vector3 vector2 = a.WorldToScreenPoint(vector);
			if (vector2.z >= 0f)
			{
				if (vector2.x < num)
				{
					num = vector2.x;
				}
				if (vector2.y < num2)
				{
					num2 = vector2.y;
				}
				if (vector2.x > num3)
				{
					num3 = vector2.x;
				}
				if (vector2.y > num4)
				{
					num4 = vector2.y;
				}
			}
		}
		bool flag = c.x >= num && c.x <= num3 && c.y >= num2 && c.y <= num4;
		if (flag)
		{
			float num5 = num3 - num;
			float num6 = num4 - num2;
			d = new Vector2((num5 > 0.0001f) ? Mathf.Clamp01((c.x - num) / num5) : 0.5f, (num6 > 0.0001f) ? Mathf.Clamp01((c.y - num2) / num6) : 0.5f);
		}
		return flag;
	}

	// Token: 0x06001462 RID: 5218 RVA: 0x00064840 File Offset: 0x00062A40
	internal static bool mdz(Camera a, Bounds b, Vector3 c, out Vector2 d)
	{
		d = new Vector2(-922f, -9998f);
		Vector3 min = b.min;
		Vector3 max = b.max;
		float num = 2069f;
		float num2 = -7671f;
		float num3 = -8392f;
		float num4 = 9600f;
		for (int i = 0; i < 8; i++)
		{
			Vector3 vector = new Vector3(((i & 1) == 0) ? min.x : max.x, ((i & 2) == 0) ? min.y : max.y, ((i & 4) == 0) ? min.z : max.z);
			Vector3 vector2 = a.WorldToScreenPoint(vector);
			if (vector2.z >= 5702f)
			{
				if (vector2.x < num)
				{
					num = vector2.x;
				}
				if (vector2.y < num2)
				{
					num2 = vector2.y;
				}
				if (vector2.x > num3)
				{
					num3 = vector2.x;
				}
				if (vector2.y > num4)
				{
					num4 = vector2.y;
				}
			}
		}
		bool flag = c.x >= num && c.x <= num3 && c.y >= num2 && c.y <= num4;
		if (flag)
		{
			float num5 = num3 - num;
			float num6 = num4 - num2;
			d = new Vector2((num5 > -7669f) ? Mathf.Clamp01((c.x - num) / num5) : 2302f, (num6 > 8247f) ? Mathf.Clamp01((c.y - num2) / num6) : 8896f);
		}
		return flag;
	}

	// Token: 0x06001463 RID: 5219 RVA: 0x000649D0 File Offset: 0x00062BD0
	private void jic(InteractionType a, NetworkPlayer b, Vector2 c)
	{
		if (bq.hlz)
		{
			fq.dbg(a.dyn());
			return;
		}
		if (bq.hly == 0)
		{
			fq.dbg(string.Format(a.dyo(), a, fq.dbh(GirlController.kok)));
			GirlController girlController = GirlController.kok;
			if (girlController == null)
			{
				return;
			}
			girlController.bfd();
			return;
		}
		else
		{
			fq.dbg(string.Format(a.dyp(), a, fq.dbh(r.kmi)));
			r r = r.kmi;
			if (r == null)
			{
				return;
			}
			r.ue();
			return;
		}
	}

	// Token: 0x06001464 RID: 5220 RVA: 0x00064A54 File Offset: 0x00062C54
	internal static bool cft(Camera a, Bounds b, Vector3 c, out Vector2 d)
	{
		d = new Vector2(-8828f, -3693f);
		Vector3 min = b.min;
		Vector3 max = b.max;
		float num = 5117f;
		float num2 = -9354f;
		float num3 = 9375f;
		float num4 = 7358f;
		for (int i = 0; i < 8; i++)
		{
			Vector3 vector = new Vector3(((i & 1) == 0) ? min.x : max.x, ((i & 2) == 0) ? min.y : max.y, ((i & 4) == 0) ? min.z : max.z);
			Vector3 vector2 = a.WorldToScreenPoint(vector);
			if (vector2.z >= 3543f)
			{
				if (vector2.x < num)
				{
					num = vector2.x;
				}
				if (vector2.y < num2)
				{
					num2 = vector2.y;
				}
				if (vector2.x > num3)
				{
					num3 = vector2.x;
				}
				if (vector2.y > num4)
				{
					num4 = vector2.y;
				}
			}
		}
		bool flag = c.x >= num && c.x <= num3 && c.y >= num2 && c.y <= num4;
		if (flag)
		{
			float num5 = num3 - num;
			float num6 = num4 - num2;
			d = new Vector2((num5 > 3524f) ? Mathf.Clamp01((c.x - num) / num5) : 347f, (num6 > -8293f) ? Mathf.Clamp01((c.y - num2) / num6) : (-4336f));
		}
		return flag;
	}

	// Token: 0x06001465 RID: 5221 RVA: 0x00064BE4 File Offset: 0x00062DE4
	public static bool xd()
	{
		Camera main = Camera.main;
		if (main == null)
		{
			return false;
		}
		Vector3 mousePosition = Input.mousePosition;
		Vector2 vector;
		gb gb = gd.doq(main, mousePosition, out vector);
		if (gb == null)
		{
			return false;
		}
		RemoteAvatarPlacement iuu = gb.iuu;
		if (iuu != null)
		{
			iuu.dny();
		}
		if (!MultiplayerSession.kun)
		{
			fq.dbg(a.dyq() + gb.ium + a.dyr());
			return true;
		}
		if (gb.iup != null && gb.iup.kur == CharacterKind.Waifu)
		{
			if (gb.iup.kux)
			{
				fq.dbg(a.dys() + gb.ium + a.dyt());
				return true;
			}
			fq.dbg(string.Format(a.dyu(), gb.ium, vector));
			MultiplayerSession.dif(gb, InteractionType.Thrust, vector);
			RemoteWaifuView ius = gb.ius;
			if (ius != null)
			{
				ius.dqw();
			}
		}
		else if (gb.iup != null && gb.iup.kur == CharacterKind.Cat)
		{
			fq.dbg(string.Format(a.dyv(), gb.ium, vector));
			MultiplayerSession.dif(gb, InteractionType.Thrust, vector);
			RemoteCatView iut = gb.iut;
			if (iut != null)
			{
				iut.doy();
			}
		}
		return true;
	}

	// Token: 0x06001466 RID: 5222 RVA: 0x0006434D File Offset: 0x0006254D
	private void OnEnable()
	{
		MultiplayerSession.ivf += this.dcj;
		MpInteractionEffects.czb();
	}

	// Token: 0x06001467 RID: 5223 RVA: 0x0006434D File Offset: 0x0006254D
	private void hah()
	{
		MultiplayerSession.ivf += this.dcj;
		MpInteractionEffects.czb();
	}

	// Token: 0x06001468 RID: 5224 RVA: 0x00064D18 File Offset: 0x00062F18
	public static bool dck()
	{
		Camera main = Camera.main;
		if (main == null)
		{
			return false;
		}
		Vector3 mousePosition = Input.mousePosition;
		Vector2 vector;
		gb gb = gd.doq(main, mousePosition, out vector);
		if (gb == null)
		{
			return false;
		}
		RemoteAvatarPlacement iuu = gb.iuu;
		if (iuu != null)
		{
			iuu.dny();
		}
		if (!MultiplayerSession.kun)
		{
			fq.dbg(a.dyw() + gb.ium + a.dyx());
			return true;
		}
		if (gb.iup != null && gb.iup.kur == CharacterKind.Waifu)
		{
			if (gb.iup.kux)
			{
				fq.dbg(a.dyw() + gb.ium + a.dyy());
				return true;
			}
			fq.dbg(string.Format(a.dyz(), gb.ium, vector));
			MultiplayerSession.dif(gb, InteractionType.Thrust, vector);
			RemoteWaifuView ius = gb.ius;
			if (ius != null)
			{
				ius.dqw();
			}
		}
		else if (gb.iup != null && gb.iup.kur == CharacterKind.Cat)
		{
			fq.dbg(string.Format(a.dza(), gb.ium, vector));
			MultiplayerSession.dif(gb, InteractionType.Thrust, vector);
			RemoteCatView iut = gb.iut;
			if (iut != null)
			{
				iut.doy();
			}
		}
		return true;
	}

	// Token: 0x06001469 RID: 5225 RVA: 0x00064E4C File Offset: 0x0006304C
	internal static bool myu(Camera a, Bounds b, Vector3 c, out Vector2 d)
	{
		d = new Vector2(-200f, 9252f);
		Vector3 min = b.min;
		Vector3 max = b.max;
		float num = 370f;
		float num2 = -8135f;
		float num3 = 661f;
		float num4 = -7612f;
		for (int i = 0; i < 8; i++)
		{
			Vector3 vector = new Vector3(((i & 1) == 0) ? min.x : max.x, ((i & 2) == 0) ? min.y : max.y, ((i & 4) == 0) ? min.z : max.z);
			Vector3 vector2 = a.WorldToScreenPoint(vector);
			if (vector2.z >= -4166f)
			{
				if (vector2.x < num)
				{
					num = vector2.x;
				}
				if (vector2.y < num2)
				{
					num2 = vector2.y;
				}
				if (vector2.x > num3)
				{
					num3 = vector2.x;
				}
				if (vector2.y > num4)
				{
					num4 = vector2.y;
				}
			}
		}
		bool flag = c.x >= num && c.x <= num3 && c.y >= num2 && c.y <= num4;
		if (flag)
		{
			float num5 = num3 - num;
			float num6 = num4 - num2;
			d = new Vector2((num5 > 1109f) ? Mathf.Clamp01((c.x - num) / num5) : 474f, (num6 > 6230f) ? Mathf.Clamp01((c.y - num2) / num6) : (-7649f));
		}
		return flag;
	}

	// Token: 0x0600146A RID: 5226 RVA: 0x0006434D File Offset: 0x0006254D
	private void isj()
	{
		MultiplayerSession.ivf += this.dcj;
		MpInteractionEffects.czb();
	}

	// Token: 0x0600146B RID: 5227 RVA: 0x00064FDC File Offset: 0x000631DC
	private void Update()
	{
		if (!MultiplayerSession.iuw)
		{
			this.ise = -1;
			this.isf = -1;
			this.isg = -1;
			this.ish = false;
			return;
		}
		NetworkPlayer networkPlayer = MultiplayerSession.iux;
		if (networkPlayer == null || networkPlayer.kur != CharacterKind.Waifu)
		{
			return;
		}
		GirlController girlController = GirlController.kok;
		if (girlController == null)
		{
			return;
		}
		bool hlz = bq.hlz;
		int num = (int)(hlz ? GirlController.GIRL_STATE.Idle : girlController.state);
		float num2 = girlController.kog;
		int num3 = ((num2 > 75f) ? 3 : ((num2 > 50f) ? 2 : ((num2 > 25f) ? 1 : 0)));
		bool flag = !hlz && girlController.koi;
		if (num != this.ise || num3 != this.isf || flag != this.ish)
		{
			this.ise = num;
			this.isf = num3;
			this.ish = flag;
			MultiplayerSession.dhy(num, num3, flag);
		}
		int num4 = girlController.koh;
		if (num4 != this.isg)
		{
			this.isg = num4;
			MultiplayerSession.dic(num4);
		}
	}

	// Token: 0x0600146C RID: 5228 RVA: 0x000650E0 File Offset: 0x000632E0
	public static bool fnm()
	{
		Camera main = Camera.main;
		if (main == null)
		{
			return false;
		}
		Vector3 mousePosition = Input.mousePosition;
		Vector2 vector;
		gb gb = gd.doq(main, mousePosition, out vector);
		if (gb == null)
		{
			return false;
		}
		RemoteAvatarPlacement iuu = gb.iuu;
		if (iuu != null)
		{
			iuu.dny();
		}
		if (!MultiplayerSession.kun)
		{
			fq.dbg(a.dzb() + gb.ium + a.dzc());
			return true;
		}
		if (gb.iup != null && gb.iup.kur == CharacterKind.Waifu)
		{
			if (gb.iup.kux)
			{
				fq.dbg(a.dzd() + gb.ium + a.dze());
				return true;
			}
			fq.dbg(string.Format(a.dzf(), gb.ium, vector));
			MultiplayerSession.dif(gb, InteractionType.Thrust, vector);
			RemoteWaifuView ius = gb.ius;
			if (ius != null)
			{
				ius.dqw();
			}
		}
		else if (gb.iup != null && gb.iup.kur == CharacterKind.Cat)
		{
			fq.dbg(string.Format(a.dzg(), gb.ium, vector));
			MultiplayerSession.dif(gb, InteractionType.Thrust, vector);
			RemoteCatView iut = gb.iut;
			if (iut != null)
			{
				iut.doy();
			}
		}
		return true;
	}

	// Token: 0x0600146D RID: 5229 RVA: 0x00065212 File Offset: 0x00063412
	private void OnDisable()
	{
		MultiplayerSession.ivf -= this.dcj;
	}

	// Token: 0x04000A8B RID: 2699
	private int ise = -1;

	// Token: 0x04000A8C RID: 2700
	private int isf = -1;

	// Token: 0x04000A8D RID: 2701
	private int isg = -1;

	// Token: 0x04000A8E RID: 2702
	private bool ish;
}
