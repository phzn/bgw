using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using BongoWaifu.Multiplayer;
using Spine;
using Spine.Unity;

// Token: 0x02000135 RID: 309
public static class gg
{
	// Token: 0x06001697 RID: 5783 RVA: 0x0007067C File Offset: 0x0006E87C
	public static bool dqb(SkeletonAnimation a, gf b, ClothingSet c)
	{
		if (a == null || a.Skeleton == null)
		{
			if (fq.iro)
			{
				fq.dbg(a.eip() + fq.dbh(a) + a.eiq() + fq.dbh((a != null) ? a.Skeleton : null));
			}
			return false;
		}
		SpineSkinSetting hle = bq.hle;
		if (hle == null)
		{
			fq.dbg(a.eir());
			return false;
		}
		if (fq.iro)
		{
			fq.dbg(a.eis() + fq.dbi(c) + a.chz());
		}
		if (b != null)
		{
			b.dpq();
		}
		List<string> list = new List<string>(10);
		gg.dqc(hle, b, list, c.dick, CLOTHE_TYPE.Dick);
		gg.dqc(hle, b, list, c.hair, CLOTHE_TYPE.Hair);
		gg.dqc(hle, b, list, c.top, CLOTHE_TYPE.Top);
		gg.dqc(hle, b, list, c.bottom, CLOTHE_TYPE.Bottom);
		gg.dqc(hle, b, list, c.underwear, CLOTHE_TYPE.Underwear);
		gg.dqc(hle, b, list, c.socks, CLOTHE_TYPE.Socks);
		gg.dqc(hle, b, list, c.shoes, CLOTHE_TYPE.Shoes);
		gg.dqc(hle, b, list, c.skinTone, CLOTHE_TYPE.SkinTone);
		gg.dqc(hle, b, list, c.intimate, CLOTHE_TYPE.IntimateParts);
		gg.dqc(hle, b, list, c.pubic, CLOTHE_TYPE.PubicAndGenital);
		return gg.dqd(a.Skeleton, list);
	}

	// Token: 0x06001698 RID: 5784 RVA: 0x000707C4 File Offset: 0x0006E9C4
	public static bool dok(SkeletonAnimation a, gf b, ClothingSet c)
	{
		if (a == null || a.Skeleton == null)
		{
			if (fq.iro)
			{
				fq.dbg(a.eit() + fq.dbh(a) + a.eiu() + fq.dbh((a != null) ? a.Skeleton : null));
			}
			return false;
		}
		SpineSkinSetting hle = bq.hle;
		if (hle == null)
		{
			fq.dbg(a.eiv());
			return false;
		}
		if (fq.iro)
		{
			fq.dbg(a.eiw() + fq.dbi(c) + a.eix());
		}
		if (b != null)
		{
			b.dpq();
		}
		List<string> list = new List<string>(29);
		gg.dqc(hle, b, list, c.dick, CLOTHE_TYPE.Dick);
		gg.dqc(hle, b, list, c.hair, CLOTHE_TYPE.Hair);
		gg.dqc(hle, b, list, c.top, CLOTHE_TYPE.Top);
		gg.dqc(hle, b, list, c.bottom, CLOTHE_TYPE.Bottom);
		gg.dqc(hle, b, list, c.underwear, CLOTHE_TYPE.Underwear);
		gg.dqc(hle, b, list, c.socks, CLOTHE_TYPE.Socks);
		gg.dqc(hle, b, list, c.shoes, (CLOTHE_TYPE)(-86));
		gg.dqc(hle, b, list, c.skinTone, (CLOTHE_TYPE)(-36));
		gg.dqc(hle, b, list, c.intimate, (CLOTHE_TYPE)41);
		gg.dqc(hle, b, list, c.pubic, (CLOTHE_TYPE)(-72));
		return gg.dqd(a.Skeleton, list);
	}

	// Token: 0x06001699 RID: 5785 RVA: 0x0007090C File Offset: 0x0006EB0C
	private static void dqc(SpineSkinSetting a, gf b, List<string> c, int d, CLOTHE_TYPE e)
	{
		if (d == 0)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.eiy(), e));
			}
			return;
		}
		SpineSkinData spineSkinData = a.bjy(d, e);
		if (spineSkinData == null)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.eiz(), e, d));
			}
			return;
		}
		if (spineSkinData.skinName == SKIN_NAME.Null)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.eja(), e, d));
			}
			return;
		}
		if (spineSkinData.koy && !bj.wm(spineSkinData.bjn()))
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.ejb(), new object[]
				{
					e,
					d,
					spineSkinData.skinName,
					spineSkinData.bjn()
				}));
			}
			return;
		}
		c.Add(spineSkinData.skinName.ToString());
		if (fq.iro)
		{
			fq.dbg(string.Format(a.ejc(), new object[]
			{
				e,
				d,
				spineSkinData.skinName,
				fq.dbh(spineSkinData.texture)
			}));
		}
		if (spineSkinData.texture != null && b != null)
		{
			b.dpp(spineSkinData.skinName, spineSkinData.texture);
		}
	}

	// Token: 0x0600169A RID: 5786 RVA: 0x00070A80 File Offset: 0x0006EC80
	public static bool dqd(Skeleton a, List<string> b)
	{
		if (a == null || a.Data == null)
		{
			if (fq.iro)
			{
				fq.dbg(a.ejd() + fq.dbh(a) + a.eje() + fq.dbh((a != null) ? a.Data : null));
			}
			return false;
		}
		int num = 0;
		Skin skin = new Skin(a.ejf());
		for (int i = 0; i < b.Count; i++)
		{
			Skin skin2 = a.Data.FindSkin(b[i]);
			if (skin2 != null)
			{
				skin.AddSkin(skin2);
				num++;
			}
			else if (fq.iro)
			{
				fq.dbg(a.ejg() + b[i] + a.ejh());
			}
		}
		a.SetSkin(skin);
		a.SetSlotsToSetupPose();
		if (fq.iro)
		{
			fq.dbg(string.Format(a.eji(), b.Count, num, string.Join(a.ejj(), b)));
		}
		return true;
	}

	// Token: 0x0600169B RID: 5787 RVA: 0x00070B70 File Offset: 0x0006ED70
	private static void jil(SpineSkinSetting a, gf b, List<string> c, int d, CLOTHE_TYPE e)
	{
		if (d == 0)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.ejk(), e));
			}
			return;
		}
		SpineSkinData spineSkinData = a.bjy(d, e);
		if (spineSkinData == null)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.ejl(), e, d));
			}
			return;
		}
		if (spineSkinData.skinName == SKIN_NAME.Null)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.ejm(), e, d));
			}
			return;
		}
		if (spineSkinData.koy && !bj.wm(spineSkinData.bjn()))
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.ejn(), new object[]
				{
					e,
					d,
					spineSkinData.skinName,
					spineSkinData.bjn()
				}));
			}
			return;
		}
		c.Add(spineSkinData.skinName.ToString());
		if (fq.iro)
		{
			fq.dbg(string.Format(a.ejo(), new object[]
			{
				e,
				d,
				spineSkinData.skinName,
				fq.dbh(spineSkinData.texture)
			}));
		}
		if (spineSkinData.texture != null && b != null)
		{
			b.dpp(spineSkinData.skinName, spineSkinData.texture);
		}
	}

	// Token: 0x0600169C RID: 5788 RVA: 0x00070CE4 File Offset: 0x0006EEE4
	public static bool hmj(Skeleton a, List<string> b)
	{
		if (a == null || a.Data == null)
		{
			if (fq.iro)
			{
				fq.dbg(a.ejp() + fq.dbh(a) + a.ejq() + fq.dbh((a != null) ? a.Data : null));
			}
			return false;
		}
		int num = 0;
		Skin skin = new Skin(a.ejr());
		for (int i = 0; i < b.Count; i++)
		{
			Skin skin2 = a.Data.FindSkin(b[i]);
			if (skin2 != null)
			{
				skin.AddSkin(skin2);
				num++;
			}
			else if (fq.iro)
			{
				fq.dbg(a.ejs() + b[i] + a.ejt());
			}
		}
		a.SetSkin(skin);
		a.SetSlotsToSetupPose();
		if (fq.iro)
		{
			fq.dbg(string.Format(a.eju(), b.Count, num, string.Join(a.ejv(), b)));
		}
		return true;
	}

	// Token: 0x0600169D RID: 5789 RVA: 0x00070DD4 File Offset: 0x0006EFD4
	private static void gut(SpineSkinSetting a, gf b, List<string> c, int d, CLOTHE_TYPE e)
	{
		if (d == 0)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.ejw(), e));
			}
			return;
		}
		SpineSkinData spineSkinData = a.bjy(d, e);
		if (spineSkinData == null)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.ejx(), e, d));
			}
			return;
		}
		if (spineSkinData.skinName == SKIN_NAME.Null)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.ejy(), e, d));
			}
			return;
		}
		if (spineSkinData.koy && !bj.wm(spineSkinData.bjn()))
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.ejz(), new object[]
				{
					e,
					d,
					spineSkinData.skinName,
					spineSkinData.bjn()
				}));
			}
			return;
		}
		c.Add(spineSkinData.skinName.ToString());
		if (fq.iro)
		{
			fq.dbg(string.Format(a.eka(), new object[]
			{
				e,
				d,
				spineSkinData.skinName,
				fq.dbh(spineSkinData.texture)
			}));
		}
		if (spineSkinData.texture != null && b != null)
		{
			b.dpp(spineSkinData.skinName, spineSkinData.texture);
		}
	}

	// Token: 0x0600169E RID: 5790 RVA: 0x00070F48 File Offset: 0x0006F148
	private static void kht(SpineSkinSetting a, gf b, List<string> c, int d, CLOTHE_TYPE e)
	{
		if (d == 0)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.ekb(), e));
			}
			return;
		}
		SpineSkinData spineSkinData = a.bjy(d, e);
		if (spineSkinData == null)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.ekc(), e, d));
			}
			return;
		}
		if (spineSkinData.skinName == SKIN_NAME.Null)
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.ekd(), e, d));
			}
			return;
		}
		if (spineSkinData.koy && !bj.wm(spineSkinData.bjn()))
		{
			if (fq.iro)
			{
				fq.dbg(string.Format(a.eke(), new object[]
				{
					e,
					d,
					spineSkinData.skinName,
					spineSkinData.bjn()
				}));
			}
			return;
		}
		c.Add(spineSkinData.skinName.ToString());
		if (fq.iro)
		{
			fq.dbg(string.Format(a.ekf(), new object[]
			{
				e,
				d,
				spineSkinData.skinName,
				fq.dbh(spineSkinData.texture)
			}));
		}
		if (spineSkinData.texture != null && b != null)
		{
			b.dpp(spineSkinData.skinName, spineSkinData.texture);
		}
	}
}
