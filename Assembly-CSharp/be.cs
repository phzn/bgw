using System;
using System.IO;

// Token: 0x02000026 RID: 38
[Obsolete("Use DlcLoader + DlcRegistry directly. Will be removed in Phase 4.5.")]
public static class be
{
	// Token: 0x0600021B RID: 539 RVA: 0x0000AFBB File Offset: 0x000091BB
	public static bool vq()
	{
		return bj.wm(4716380U);
	}

	// Token: 0x0600021C RID: 540 RVA: 0x0000AFC8 File Offset: 0x000091C8
	public static bool vt(string a, out string b)
	{
		b = null;
		if (string.IsNullOrEmpty(a))
		{
			return false;
		}
		string text;
		if (!bj.wn(4716380U, out text))
		{
			return false;
		}
		string text2 = a.Replace('\\', '/').TrimStart('/');
		b = Path.Combine(text, text2);
		return true;
	}

	// Token: 0x0600021D RID: 541 RVA: 0x0000B00E File Offset: 0x0000920E
	public static bool ee()
	{
		return bj.wm(62U);
	}

	// Token: 0x0600021E RID: 542 RVA: 0x0000B017 File Offset: 0x00009217
	public static bool jdx(out string a)
	{
		return bj.wn(4294967232U, out a);
	}

	// Token: 0x0600021F RID: 543 RVA: 0x0000B021 File Offset: 0x00009221
	public static bool gcd()
	{
		return bj.wm(30U);
	}

	// Token: 0x06000220 RID: 544 RVA: 0x0000B02A File Offset: 0x0000922A
	public static bool cib()
	{
		return bj.wm(81U);
	}

	// Token: 0x06000221 RID: 545 RVA: 0x0000B033 File Offset: 0x00009233
	public static void ejg()
	{
		bj.wp(31U);
	}

	// Token: 0x06000222 RID: 546 RVA: 0x0000B03C File Offset: 0x0000923C
	public static void blv()
	{
		bj.wp(79U);
	}

	// Token: 0x06000223 RID: 547 RVA: 0x0000B045 File Offset: 0x00009245
	public static bool kqy(out string a)
	{
		return bj.wn(17U, out a);
	}

	// Token: 0x06000224 RID: 548 RVA: 0x0000B04F File Offset: 0x0000924F
	public static bool drl(out string a)
	{
		return bj.wn(4294967257U, out a);
	}

	// Token: 0x06000225 RID: 549 RVA: 0x0000B059 File Offset: 0x00009259
	public static bool vr(out string a)
	{
		return bj.wn(4716380U, out a);
	}

	// Token: 0x06000226 RID: 550 RVA: 0x0000B066 File Offset: 0x00009266
	public static void vs()
	{
		bj.wp(4716380U);
	}

	// Token: 0x06000227 RID: 551 RVA: 0x0000B072 File Offset: 0x00009272
	public static bool kgv()
	{
		return bj.wm(64U);
	}

	// Token: 0x06000228 RID: 552 RVA: 0x0000B07B File Offset: 0x0000927B
	public static bool oqv(out string a)
	{
		return bj.wn(57U, out a);
	}

	// Token: 0x04000123 RID: 291
	public const uint hin = 4716380U;
}
