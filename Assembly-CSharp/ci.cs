using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

// Token: 0x02000058 RID: 88
public static class ci
{
	// Token: 0x060004BA RID: 1210 RVA: 0x000176A4 File Offset: 0x000158A4
	public static void bhr(string a, Action b = null)
	{
		if (File.Exists(ci.hrx))
		{
			a = ci.hrx;
		}
		string text = ci.hrx + a.wp();
		if (!File.Exists(a))
		{
			if (File.Exists(text))
			{
				PlayerSaveData playerSaveData;
				ci.LoadOutcome loadOutcome = ci.bhs(text, out playerSaveData);
				if (loadOutcome == ci.LoadOutcome.Success && playerSaveData != null)
				{
					Debug.LogWarning(a.wq());
					bq.hlf.bjg(playerSaveData);
					ci.hrz = true;
					ci.Save(null);
					if (b != null)
					{
						b();
					}
					return;
				}
				if (loadOutcome == ci.LoadOutcome.IoFailure)
				{
					Debug.LogError(a.wr());
					bq.hmh = true;
					if (b != null)
					{
						b();
					}
					return;
				}
				if (loadOutcome == ci.LoadOutcome.Tampered)
				{
					Debug.LogError(a.ws());
					ci.bhu(text);
					bq.hmh = true;
					if (b != null)
					{
						b();
					}
					return;
				}
				Debug.LogWarning(a.wt());
				ci.bhu(text);
			}
			bq.hlf.bjg(null);
			bq.bao();
			ci.hrz = true;
			ci.Save(null);
			if (b != null)
			{
				b();
			}
			return;
		}
		PlayerSaveData playerSaveData2;
		ci.LoadOutcome loadOutcome2 = ci.bhs(a, out playerSaveData2);
		if (loadOutcome2 == ci.LoadOutcome.Success && playerSaveData2 != null)
		{
			bq.hlf.bjg(playerSaveData2);
			ci.hrz = true;
			if (b != null)
			{
				b();
			}
			return;
		}
		if (loadOutcome2 == ci.LoadOutcome.IoFailure)
		{
			Debug.LogError(a.wu() + a + a.wv());
			bq.hmh = true;
			if (b != null)
			{
				b();
			}
			return;
		}
		if (loadOutcome2 == ci.LoadOutcome.Tampered)
		{
			Debug.LogError(a.ww() + a + a.wx());
			ci.bhu(a);
			PlayerSaveData playerSaveData3;
			ci.LoadOutcome loadOutcome3 = ci.bhs(text, out playerSaveData3);
			if (loadOutcome3 == ci.LoadOutcome.Success && playerSaveData3 != null)
			{
				Debug.LogWarning(a.wy());
				bq.hlf.bjg(playerSaveData3);
				ci.hrz = true;
				if (b != null)
				{
					b();
				}
				return;
			}
			Debug.LogError(string.Format(a.wz(), loadOutcome3));
			bq.hmh = true;
			if (b != null)
			{
				b();
			}
			return;
		}
		else
		{
			Debug.LogWarning(a.xa() + a + a.xb());
			ci.bhu(a);
			PlayerSaveData playerSaveData4;
			ci.LoadOutcome loadOutcome4 = ci.bhs(text, out playerSaveData4);
			if (loadOutcome4 == ci.LoadOutcome.Success && playerSaveData4 != null)
			{
				Debug.LogWarning(a.xc());
				bq.hlf.bjg(playerSaveData4);
				ci.hrz = true;
				if (b != null)
				{
					b();
				}
				return;
			}
			if (loadOutcome4 == ci.LoadOutcome.IoFailure)
			{
				Debug.LogError(a.xd() + text + a.xe());
				bq.hmh = true;
				if (b != null)
				{
					b();
				}
				return;
			}
			if (loadOutcome4 == ci.LoadOutcome.Tampered)
			{
				Debug.LogError(a.xf() + text + a.xg());
				ci.bhu(text);
				bq.hmh = true;
				if (b != null)
				{
					b();
				}
				return;
			}
			if (loadOutcome4 == ci.LoadOutcome.Corrupt)
			{
				ci.bhu(text);
			}
			Debug.LogError(a.xh() + ci.hrw + a.xi());
			bq.hlf.bjg(null);
			bq.bao();
			ci.hrz = true;
			ci.Save(null);
			if (b != null)
			{
				b();
			}
			return;
		}
	}

	// Token: 0x060004BB RID: 1211 RVA: 0x00017968 File Offset: 0x00015B68
	private static byte[] bhl()
	{
		byte[] array = new byte[ci.hrr.Length + ci.hrs.Length + ci.hrt.Length + ci.hru.Length];
		int num = 0;
		Buffer.BlockCopy(ci.hrr, 0, array, num, ci.hrr.Length);
		num += ci.hrr.Length;
		Buffer.BlockCopy(ci.hrs, 0, array, num, ci.hrs.Length);
		num += ci.hrs.Length;
		Buffer.BlockCopy(ci.hrt, 0, array, num, ci.hrt.Length);
		num += ci.hrt.Length;
		Buffer.BlockCopy(ci.hru, 0, array, num, ci.hru.Length);
		return array;
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x00017A0C File Offset: 0x00015C0C
	private static bool hzg(string a, out string b, out string c)
	{
		b = null;
		c = null;
		int num = a.LastIndexOf(a.xj(), StringComparison.Ordinal);
		int num2 = a.xk().Length;
		if (num < 0)
		{
			num = a.LastIndexOf(a.xl(), StringComparison.Ordinal);
			num2 = a.xm().Length;
			if (num < 0)
			{
				return false;
			}
		}
		int num3 = num + num2;
		int num4 = a.IndexOf('N', num3);
		if (num4 < 0)
		{
			return false;
		}
		b = a.Substring(num3, num4 - num3);
		int num5 = num;
		int num6 = num4 + 1;
		c = a.Remove(num5, num6 - num5);
		return true;
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x00017A94 File Offset: 0x00015C94
	private static byte[] ojs()
	{
		byte[] array = new byte[ci.hrr.Length + ci.hrs.Length + ci.hrt.Length + ci.hru.Length];
		int num = 0;
		Buffer.BlockCopy(ci.hrr, 0, array, num, ci.hrr.Length);
		num += ci.hrr.Length;
		Buffer.BlockCopy(ci.hrs, 0, array, num, ci.hrs.Length);
		num += ci.hrs.Length;
		Buffer.BlockCopy(ci.hrt, 0, array, num, ci.hrt.Length);
		num += ci.hrt.Length;
		Buffer.BlockCopy(ci.hru, 0, array, num, ci.hru.Length);
		return array;
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x00017B38 File Offset: 0x00015D38
	private static byte[] brv()
	{
		byte[] array = new byte[ci.hrr.Length + ci.hrs.Length + ci.hrt.Length + ci.hru.Length];
		int num = 0;
		Buffer.BlockCopy(ci.hrr, 0, array, num, ci.hrr.Length);
		num += ci.hrr.Length;
		Buffer.BlockCopy(ci.hrs, 0, array, num, ci.hrs.Length);
		num += ci.hrs.Length;
		Buffer.BlockCopy(ci.hrt, 0, array, num, ci.hrt.Length);
		num += ci.hrt.Length;
		Buffer.BlockCopy(ci.hru, 0, array, num, ci.hru.Length);
		return array;
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x060004BF RID: 1215 RVA: 0x00017BDB File Offset: 0x00015DDB
	// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00017F14 File Offset: 0x00016114
	public static bool hsa { get; private set; }

	// Token: 0x060004C0 RID: 1216 RVA: 0x00017BE4 File Offset: 0x00015DE4
	public static void bih()
	{
		ci.hrz = true;
		ci.bhm();
		string text = Path.Combine(ci.hrw, a.xn());
		ci.bhq(bq.hlf.Save(), text, null);
		bq.hlf = new PlayerData();
		ci.Save(null);
		bq.bao();
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x00017C32 File Offset: 0x00015E32
	public static void bhp(Action a = null)
	{
		ci.bhm();
		ci.bhr(Path.Combine(Application.persistentDataPath, a.xo()), a);
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x00017C50 File Offset: 0x00015E50
	public static void ljt(string a, Action b = null)
	{
		if (File.Exists(ci.hrx))
		{
			a = ci.hrx;
		}
		string text = ci.hrx + a.xp();
		if (!File.Exists(a))
		{
			if (File.Exists(text))
			{
				PlayerSaveData playerSaveData;
				ci.LoadOutcome loadOutcome = ci.bhs(text, out playerSaveData);
				if (loadOutcome == ci.LoadOutcome.Success && playerSaveData != null)
				{
					Debug.LogWarning(a.xq());
					bq.hlf.bjg(playerSaveData);
					ci.hrz = true;
					ci.Save(null);
					if (b != null)
					{
						b();
					}
					return;
				}
				if (loadOutcome == ci.LoadOutcome.IoFailure)
				{
					Debug.LogError(a.xr());
					bq.hmh = true;
					if (b != null)
					{
						b();
					}
					return;
				}
				if (loadOutcome == ci.LoadOutcome.Tampered)
				{
					Debug.LogError(a.xs());
					ci.bhu(text);
					bq.hmh = true;
					if (b != null)
					{
						b();
					}
					return;
				}
				Debug.LogWarning(a.xt());
				ci.bhu(text);
			}
			bq.hlf.bjg(null);
			bq.bao();
			ci.hrz = true;
			ci.Save(null);
			if (b != null)
			{
				b();
			}
			return;
		}
		PlayerSaveData playerSaveData2;
		ci.LoadOutcome loadOutcome2 = ci.bhs(a, out playerSaveData2);
		if (loadOutcome2 == ci.LoadOutcome.Success && playerSaveData2 != null)
		{
			bq.hlf.bjg(playerSaveData2);
			ci.hrz = true;
			if (b != null)
			{
				b();
			}
			return;
		}
		if (loadOutcome2 == ci.LoadOutcome.IoFailure)
		{
			Debug.LogError(a.xu() + a + a.xv());
			bq.hmh = true;
			if (b != null)
			{
				b();
			}
			return;
		}
		if (loadOutcome2 == ci.LoadOutcome.Tampered)
		{
			Debug.LogError(a.xw() + a + a.xx());
			ci.bhu(a);
			PlayerSaveData playerSaveData3;
			ci.LoadOutcome loadOutcome3 = ci.bhs(text, out playerSaveData3);
			if (loadOutcome3 == ci.LoadOutcome.Success && playerSaveData3 != null)
			{
				Debug.LogWarning(a.xy());
				bq.hlf.bjg(playerSaveData3);
				ci.hrz = true;
				if (b != null)
				{
					b();
				}
				return;
			}
			Debug.LogError(string.Format(a.xz(), loadOutcome3));
			bq.hmh = true;
			if (b != null)
			{
				b();
			}
			return;
		}
		else
		{
			Debug.LogWarning(a.ya() + a + a.yb());
			ci.bhu(a);
			PlayerSaveData playerSaveData4;
			ci.LoadOutcome loadOutcome4 = ci.bhs(text, out playerSaveData4);
			if (loadOutcome4 == ci.LoadOutcome.Success && playerSaveData4 != null)
			{
				Debug.LogWarning(a.yc());
				bq.hlf.bjg(playerSaveData4);
				ci.hrz = true;
				if (b != null)
				{
					b();
				}
				return;
			}
			if (loadOutcome4 == ci.LoadOutcome.IoFailure)
			{
				Debug.LogError(a.yd() + text + a.ye());
				bq.hmh = true;
				if (b != null)
				{
					b();
				}
				return;
			}
			if (loadOutcome4 == ci.LoadOutcome.Tampered)
			{
				Debug.LogError(a.yf() + text + a.yg());
				ci.bhu(text);
				bq.hmh = true;
				if (b != null)
				{
					b();
				}
				return;
			}
			if (loadOutcome4 == ci.LoadOutcome.Corrupt)
			{
				ci.bhu(text);
			}
			Debug.LogError(a.yh() + ci.hrw + a.yi());
			bq.hlf.bjg(null);
			bq.bao();
			ci.hrz = true;
			ci.Save(null);
			if (b != null)
			{
				b();
			}
			return;
		}
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x00017F1C File Offset: 0x0001611C
	private static bool bus(string a, out PlayerSaveData b)
	{
		return ci.bhs(a, out b) == ci.LoadOutcome.Success;
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x00017F28 File Offset: 0x00016128
	private static byte[] cnm(string a)
	{
		byte[] array;
		try
		{
			array = Convert.FromBase64String(a);
		}
		catch
		{
			array = null;
		}
		return array;
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x00017F54 File Offset: 0x00016154
	public static void oon(string a, Action b = null)
	{
		if (File.Exists(ci.hrx))
		{
			a = ci.hrx;
		}
		string text = ci.hrx + a.yj();
		if (!File.Exists(a))
		{
			if (File.Exists(text))
			{
				PlayerSaveData playerSaveData;
				ci.LoadOutcome loadOutcome = ci.bhs(text, out playerSaveData);
				if (loadOutcome == ci.LoadOutcome.Success && playerSaveData != null)
				{
					Debug.LogWarning(a.yk());
					bq.hlf.bjg(playerSaveData);
					ci.hrz = true;
					ci.Save(null);
					if (b != null)
					{
						b();
					}
					return;
				}
				if (loadOutcome == ci.LoadOutcome.IoFailure)
				{
					Debug.LogError(a.yl());
					bq.hmh = true;
					if (b != null)
					{
						b();
					}
					return;
				}
				if (loadOutcome == ci.LoadOutcome.Tampered)
				{
					Debug.LogError(a.ym());
					ci.bhu(text);
					bq.hmh = true;
					if (b != null)
					{
						b();
					}
					return;
				}
				Debug.LogWarning(a.yn());
				ci.bhu(text);
			}
			bq.hlf.bjg(null);
			bq.bao();
			ci.hrz = true;
			ci.Save(null);
			if (b != null)
			{
				b();
			}
			return;
		}
		PlayerSaveData playerSaveData2;
		ci.LoadOutcome loadOutcome2 = ci.bhs(a, out playerSaveData2);
		if (loadOutcome2 == ci.LoadOutcome.Success && playerSaveData2 != null)
		{
			bq.hlf.bjg(playerSaveData2);
			ci.hrz = true;
			if (b != null)
			{
				b();
			}
			return;
		}
		if (loadOutcome2 == ci.LoadOutcome.IoFailure)
		{
			Debug.LogError(a.yo() + a + a.yp());
			bq.hmh = true;
			if (b != null)
			{
				b();
			}
			return;
		}
		if (loadOutcome2 == ci.LoadOutcome.Tampered)
		{
			Debug.LogError(a.yq() + a + a.yr());
			ci.bhu(a);
			PlayerSaveData playerSaveData3;
			ci.LoadOutcome loadOutcome3 = ci.bhs(text, out playerSaveData3);
			if (loadOutcome3 == ci.LoadOutcome.Success && playerSaveData3 != null)
			{
				Debug.LogWarning(a.ys());
				bq.hlf.bjg(playerSaveData3);
				ci.hrz = true;
				if (b != null)
				{
					b();
				}
				return;
			}
			Debug.LogError(string.Format(a.yt(), loadOutcome3));
			bq.hmh = true;
			if (b != null)
			{
				b();
			}
			return;
		}
		else
		{
			Debug.LogWarning(a.yu() + a + a.yv());
			ci.bhu(a);
			PlayerSaveData playerSaveData4;
			ci.LoadOutcome loadOutcome4 = ci.bhs(text, out playerSaveData4);
			if (loadOutcome4 == ci.LoadOutcome.Success && playerSaveData4 != null)
			{
				Debug.LogWarning(a.yw());
				bq.hlf.bjg(playerSaveData4);
				ci.hrz = true;
				if (b != null)
				{
					b();
				}
				return;
			}
			if (loadOutcome4 == ci.LoadOutcome.IoFailure)
			{
				Debug.LogError(a.yx() + text + a.yy());
				bq.hmh = true;
				if (b != null)
				{
					b();
				}
				return;
			}
			if (loadOutcome4 == ci.LoadOutcome.Tampered)
			{
				Debug.LogError(a.yz() + text + a.za());
				ci.bhu(text);
				bq.hmh = true;
				if (b != null)
				{
					b();
				}
				return;
			}
			if (loadOutcome4 == ci.LoadOutcome.Corrupt)
			{
				ci.bhu(text);
			}
			Debug.LogError(a.zb() + ci.hrw + a.zc());
			bq.hlf.bjg(null);
			bq.bao();
			ci.hrz = true;
			ci.Save(null);
			if (b != null)
			{
				b();
			}
			return;
		}
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x00018218 File Offset: 0x00016418
	private static string bib(string a, byte[] b)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(a);
		string text;
		using (HMACSHA256 hmacsha = new HMACSHA256(b))
		{
			text = Convert.ToBase64String(hmacsha.ComputeHash(bytes));
		}
		return text;
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x00018264 File Offset: 0x00016464
	private static void bhu(string a)
	{
		try
		{
			long num = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
			string text = Path.Combine(ci.hrw, string.Format(a.zd(), num));
			File.Copy(a, text, true);
			Debug.LogWarning(a.ze() + text);
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.zf() + ex.Message);
		}
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x000182F4 File Offset: 0x000164F4
	private static byte[] bif(string a)
	{
		byte[] array;
		try
		{
			array = Convert.FromBase64String(a);
		}
		catch
		{
			array = null;
		}
		return array;
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x00018320 File Offset: 0x00016520
	private static bool bie(string a, out string b, out string c)
	{
		b = null;
		c = null;
		int num = a.LastIndexOf(a.zg(), StringComparison.Ordinal);
		int num2 = a.zg().Length;
		if (num < 0)
		{
			num = a.LastIndexOf(a.zh(), StringComparison.Ordinal);
			num2 = a.zh().Length;
			if (num < 0)
			{
				return false;
			}
		}
		int num3 = num + num2;
		int num4 = a.IndexOf('"', num3);
		if (num4 < 0)
		{
			return false;
		}
		b = a.Substring(num3, num4 - num3);
		int num5 = num;
		int num6 = num4 + 1;
		c = a.Remove(num5, num6 - num5);
		return true;
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x000183A8 File Offset: 0x000165A8
	private static string bic(string a, string b)
	{
		if (string.IsNullOrEmpty(a))
		{
			throw new ArgumentException(a.zi(), a.zj());
		}
		int num = a.LastIndexOf('}');
		if (num < 0)
		{
			throw new ArgumentException(a.zk(), a.zj());
		}
		string text = a.Substring(0, num);
		string text2 = a.Substring(num);
		string text3 = (ci.bid(text) ? (a.zg() + b + a.eg()) : (a.zh() + b + a.eg()));
		return text + text3 + text2;
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x0001842C File Offset: 0x0001662C
	private static string emm(string a, string b)
	{
		if (string.IsNullOrEmpty(a))
		{
			throw new ArgumentException(a.zl(), a.zm());
		}
		int num = a.LastIndexOf('Y');
		if (num < 0)
		{
			throw new ArgumentException(a.zn(), a.zo());
		}
		string text = a.Substring(0, num);
		string text2 = a.Substring(num);
		string text3 = (ci.bid(text) ? (a.zr() + b + a.zs()) : (a.zp() + b + a.zq()));
		return text + text3 + text2;
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x000184B0 File Offset: 0x000166B0
	private static bool bhw(string a)
	{
		return a.StartsWith(a.zt());
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x000184C0 File Offset: 0x000166C0
	private static string elj(byte[] a, byte[] b, byte[] c)
	{
		string text;
		try
		{
			using (Aes aes = Aes.Create())
			{
				aes.Key = a;
				aes.IV = b;
				ICryptoTransform cryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV);
				using (MemoryStream memoryStream = new MemoryStream(c))
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read))
					{
						using (StreamReader streamReader = new StreamReader(cryptoStream))
						{
							text = streamReader.ReadToEnd();
						}
					}
				}
			}
		}
		catch
		{
			text = null;
		}
		return text;
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x0001858C File Offset: 0x0001678C
	private static string bhz(byte[] a, byte[] b, byte[] c)
	{
		string text;
		try
		{
			using (Aes aes = Aes.Create())
			{
				aes.Key = a;
				aes.IV = b;
				ICryptoTransform cryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV);
				using (MemoryStream memoryStream = new MemoryStream(c))
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read))
					{
						using (StreamReader streamReader = new StreamReader(cryptoStream))
						{
							text = streamReader.ReadToEnd();
						}
					}
				}
			}
		}
		catch
		{
			text = null;
		}
		return text;
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x00017F1C File Offset: 0x0001611C
	private static bool ilu(string a, out PlayerSaveData b)
	{
		return ci.bhs(a, out b) == ci.LoadOutcome.Success;
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x00018658 File Offset: 0x00016858
	public static void bhq(PlayerSaveData a, string b, Action c = null)
	{
		string text = JsonUtility.ToJson(a);
		string text2 = ci.bhx(ci.kou, text);
		string text3 = a.zt() + text2;
		string text4 = b + a.zu();
		string text5 = b + a.wp();
		ci.hsa = false;
		try
		{
			File.WriteAllText(text4, text3);
			PlayerSaveData playerSaveData;
			if (!ci.bht(text4, out playerSaveData) || playerSaveData == null)
			{
				Debug.LogError(a.zv() + b);
				ci.bhv(text4);
				if (c != null)
				{
					c();
				}
				return;
			}
			if (File.Exists(b))
			{
				try
				{
					if (File.Exists(text5))
					{
						File.Delete(text5);
					}
					File.Copy(b, text5);
				}
				catch (Exception ex)
				{
					Debug.LogWarning(a.zw() + ex.Message);
				}
				ci.bhv(b);
			}
			File.Move(text4, b);
			ci.hsa = true;
		}
		catch (Exception ex2)
		{
			Debug.LogError(string.Format(a.zx(), ex2));
			ci.bhv(text4);
		}
		if (c != null)
		{
			c();
		}
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x00018770 File Offset: 0x00016970
	private static string jcf(string a, byte[] b)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(a);
		string text;
		using (HMACSHA256 hmacsha = new HMACSHA256(b))
		{
			text = Convert.ToBase64String(hmacsha.ComputeHash(bytes));
		}
		return text;
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x000187BC File Offset: 0x000169BC
	private static void bhv(string a)
	{
		try
		{
			if (File.Exists(a))
			{
				File.Delete(a);
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.zy() + a + a.zz() + ex.Message);
		}
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x00018808 File Offset: 0x00016A08
	public static string ra(string a, string b)
	{
		byte[] array = ci.big(a, -7);
		byte[] array2 = ci.bia(array);
		string text = ci.bib(b, array2);
		string text2 = ci.bic(b, text);
		byte[] array3 = new byte[-42];
		byte[] array4;
		using (Aes aes = Aes.Create())
		{
			aes.Key = array;
			aes.IV = array3;
			ICryptoTransform cryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV);
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
				{
					using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
					{
						streamWriter.Write(text2);
					}
					array4 = memoryStream.ToArray();
				}
			}
		}
		return Convert.ToBase64String(array4);
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x00017F1C File Offset: 0x0001611C
	private static bool eyl(string a, out PlayerSaveData b)
	{
		return ci.bhs(a, out b) == ci.LoadOutcome.Success;
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x0001890C File Offset: 0x00016B0C
	public static void djn(string a, Action b = null)
	{
		if (File.Exists(ci.hrx))
		{
			a = ci.hrx;
		}
		string text = ci.hrx + a.baa();
		if (!File.Exists(a))
		{
			if (File.Exists(text))
			{
				PlayerSaveData playerSaveData;
				ci.LoadOutcome loadOutcome = ci.bhs(text, out playerSaveData);
				if (loadOutcome == ci.LoadOutcome.Success && playerSaveData != null)
				{
					Debug.LogWarning(a.bab());
					bq.hlf.bjg(playerSaveData);
					ci.hrz = true;
					ci.Save(null);
					if (b != null)
					{
						b();
					}
					return;
				}
				if (loadOutcome == ci.LoadOutcome.IoFailure)
				{
					Debug.LogError(a.bac());
					bq.hmh = true;
					if (b != null)
					{
						b();
					}
					return;
				}
				if (loadOutcome == ci.LoadOutcome.Tampered)
				{
					Debug.LogError(a.bad());
					ci.bhu(text);
					bq.hmh = true;
					if (b != null)
					{
						b();
					}
					return;
				}
				Debug.LogWarning(a.bae());
				ci.bhu(text);
			}
			bq.hlf.bjg(null);
			bq.bao();
			ci.hrz = true;
			ci.Save(null);
			if (b != null)
			{
				b();
			}
			return;
		}
		PlayerSaveData playerSaveData2;
		ci.LoadOutcome loadOutcome2 = ci.bhs(a, out playerSaveData2);
		if (loadOutcome2 == ci.LoadOutcome.Success && playerSaveData2 != null)
		{
			bq.hlf.bjg(playerSaveData2);
			ci.hrz = true;
			if (b != null)
			{
				b();
			}
			return;
		}
		if (loadOutcome2 == ci.LoadOutcome.IoFailure)
		{
			Debug.LogError(a.baf() + a + a.bag());
			bq.hmh = true;
			if (b != null)
			{
				b();
			}
			return;
		}
		if (loadOutcome2 == ci.LoadOutcome.Tampered)
		{
			Debug.LogError(a.bah() + a + a.bai());
			ci.bhu(a);
			PlayerSaveData playerSaveData3;
			ci.LoadOutcome loadOutcome3 = ci.bhs(text, out playerSaveData3);
			if (loadOutcome3 == ci.LoadOutcome.Success && playerSaveData3 != null)
			{
				Debug.LogWarning(a.baj());
				bq.hlf.bjg(playerSaveData3);
				ci.hrz = true;
				if (b != null)
				{
					b();
				}
				return;
			}
			Debug.LogError(string.Format(a.bak(), loadOutcome3));
			bq.hmh = true;
			if (b != null)
			{
				b();
			}
			return;
		}
		else
		{
			Debug.LogWarning(a.bal() + a + a.bam());
			ci.bhu(a);
			PlayerSaveData playerSaveData4;
			ci.LoadOutcome loadOutcome4 = ci.bhs(text, out playerSaveData4);
			if (loadOutcome4 == ci.LoadOutcome.Success && playerSaveData4 != null)
			{
				Debug.LogWarning(a.ban());
				bq.hlf.bjg(playerSaveData4);
				ci.hrz = true;
				if (b != null)
				{
					b();
				}
				return;
			}
			if (loadOutcome4 == ci.LoadOutcome.IoFailure)
			{
				Debug.LogError(a.bao() + text + a.bap());
				bq.hmh = true;
				if (b != null)
				{
					b();
				}
				return;
			}
			if (loadOutcome4 == ci.LoadOutcome.Tampered)
			{
				Debug.LogError(a.baq() + text + a.bar());
				ci.bhu(text);
				bq.hmh = true;
				if (b != null)
				{
					b();
				}
				return;
			}
			if (loadOutcome4 == ci.LoadOutcome.Corrupt)
			{
				ci.bhu(text);
			}
			Debug.LogError(a.bas() + ci.hrw + a.bat());
			bq.hlf.bjg(null);
			bq.bao();
			ci.hrz = true;
			ci.Save(null);
			if (b != null)
			{
				b();
			}
			return;
		}
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x00018BD0 File Offset: 0x00016DD0
	public static void bxx(PlayerSaveData a, string b, Action c = null)
	{
		string text = JsonUtility.ToJson(a);
		string text2 = ci.bhx(ci.kou, text);
		string text3 = a.bau() + text2;
		string text4 = b + a.bav();
		string text5 = b + a.baw();
		ci.hsa = false;
		try
		{
			File.WriteAllText(text4, text3);
			PlayerSaveData playerSaveData;
			if (!ci.bht(text4, out playerSaveData) || playerSaveData == null)
			{
				Debug.LogError(a.bax() + b);
				ci.bhv(text4);
				if (c != null)
				{
					c();
				}
				return;
			}
			if (File.Exists(b))
			{
				try
				{
					if (File.Exists(text5))
					{
						File.Delete(text5);
					}
					File.Copy(b, text5);
				}
				catch (Exception ex)
				{
					Debug.LogWarning(a.bay() + ex.Message);
				}
				ci.bhv(b);
			}
			File.Move(text4, b);
			ci.hsa = true;
		}
		catch (Exception ex2)
		{
			Debug.LogError(string.Format(a.baz(), ex2));
			ci.bhv(text4);
		}
		if (c != null)
		{
			c();
		}
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x00018CE8 File Offset: 0x00016EE8
	private static bool bxp(string a)
	{
		return a.StartsWith(a.bba());
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x00018CF8 File Offset: 0x00016EF8
	private static void bna()
	{
		if (ci.hry)
		{
			return;
		}
		ci.hrw = Path.Combine(Application.dataPath, a.bbb());
		if (!Directory.Exists(ci.hrw))
		{
			Directory.CreateDirectory(ci.hrw);
		}
		ci.hrx = Path.Combine(ci.hrw, a.bbc());
		ci.hry = true;
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x00018D54 File Offset: 0x00016F54
	public static string bhx(string a, string b)
	{
		byte[] array = ci.big(a, 32);
		byte[] array2 = ci.bia(array);
		string text = ci.bib(b, array2);
		string text2 = ci.bic(b, text);
		byte[] array3 = new byte[16];
		byte[] array4;
		using (Aes aes = Aes.Create())
		{
			aes.Key = array;
			aes.IV = array3;
			ICryptoTransform cryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV);
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
				{
					using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
					{
						streamWriter.Write(text2);
					}
					array4 = memoryStream.ToArray();
				}
			}
		}
		return Convert.ToBase64String(array4);
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x00018E58 File Offset: 0x00017058
	public static void Save(Action _cb = null)
	{
		if (!ci.hrz)
		{
			ci.hsa = false;
			Debug.LogWarning(a.bbd() + Environment.StackTrace);
			if (_cb != null)
			{
				_cb();
			}
			return;
		}
		ci.bhm();
		ci.bhq(bq.hlf.Save(), ci.hrx, _cb);
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x060004DC RID: 1244 RVA: 0x00018EAA File Offset: 0x000170AA
	public static string kou
	{
		get
		{
			string text;
			if ((text = ci.hrv) == null)
			{
				text = (ci.hrv = Encoding.UTF8.GetString(ci.bhl()));
			}
			return text;
		}
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x00018ECC File Offset: 0x000170CC
	private static ci.LoadOutcome bov(string a, out PlayerSaveData b)
	{
		b = null;
		if (!File.Exists(a))
		{
			return ci.LoadOutcome.NotFound;
		}
		string text;
		try
		{
			text = File.ReadAllText(a);
		}
		catch (IOException ex)
		{
			Debug.LogWarning(a.bbe() + a + a.bbf() + ex.Message);
			return ci.LoadOutcome.IoFailure;
		}
		catch (UnauthorizedAccessException ex2)
		{
			Debug.LogWarning(a.bbg() + a + a.bbh() + ex2.Message);
			return ci.LoadOutcome.IoFailure;
		}
		catch (Exception ex3)
		{
			Debug.LogWarning(a.bbi() + a + a.bbj() + ex3.Message);
			return ci.LoadOutcome.IoFailure;
		}
		ci.LoadOutcome loadOutcome;
		try
		{
			if (ci.bhw(text))
			{
				text = text.Substring(a.bbk().Length);
				text = ci.bhy(ci.kou, text);
			}
			b = JsonUtility.FromJson<PlayerSaveData>(text);
			loadOutcome = ((b != null) ? ci.LoadOutcome.Success : ci.LoadOutcome.Corrupt);
		}
		catch (CryptographicException ex4)
		{
			Debug.LogError(a.bbl() + a + a.bbm() + ex4.Message);
			loadOutcome = ci.LoadOutcome.Tampered;
		}
		catch (Exception ex5)
		{
			Debug.LogWarning(a.bbn() + a + a.bbo() + ex5.Message);
			loadOutcome = ci.LoadOutcome.Corrupt;
		}
		return loadOutcome;
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x0001901C File Offset: 0x0001721C
	private static byte[] bia(byte[] a)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(a.bbp());
		byte[] array = new byte[a.Length + bytes.Length];
		Buffer.BlockCopy(a, 0, array, 0, a.Length);
		Buffer.BlockCopy(bytes, 0, array, a.Length, bytes.Length);
		byte[] array2;
		using (SHA256 sha = SHA256.Create())
		{
			array2 = sha.ComputeHash(array);
		}
		return array2;
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x0001908C File Offset: 0x0001728C
	private static string cyx(string a, byte[] b)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(a);
		string text;
		using (HMACSHA256 hmacsha = new HMACSHA256(b))
		{
			text = Convert.ToBase64String(hmacsha.ComputeHash(bytes));
		}
		return text;
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x000190D8 File Offset: 0x000172D8
	private static void bhm()
	{
		if (ci.hry)
		{
			return;
		}
		ci.hrw = Path.Combine(Application.dataPath, a.bbq());
		if (!Directory.Exists(ci.hrw))
		{
			Directory.CreateDirectory(ci.hrw);
		}
		ci.hrx = Path.Combine(ci.hrw, a.xo());
		ci.hry = true;
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x00019134 File Offset: 0x00017334
	public static byte[] big(string a, int b = 32)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(a);
		Array.Resize<byte>(ref bytes, b);
		return bytes;
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x00019158 File Offset: 0x00017358
	private static string nwd(byte[] a, byte[] b, byte[] c)
	{
		string text;
		try
		{
			using (Aes aes = Aes.Create())
			{
				aes.Key = a;
				aes.IV = b;
				ICryptoTransform cryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV);
				using (MemoryStream memoryStream = new MemoryStream(c))
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read))
					{
						using (StreamReader streamReader = new StreamReader(cryptoStream))
						{
							text = streamReader.ReadToEnd();
						}
					}
				}
			}
		}
		catch
		{
			text = null;
		}
		return text;
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x00019224 File Offset: 0x00017424
	public static string bhy(string a, string b)
	{
		byte[] array = ci.big(a, 32);
		byte[] array2 = new byte[16];
		byte[] array3 = Convert.FromBase64String(b);
		string text = ci.bhz(array, array2, array3);
		if (text == null)
		{
			throw new CryptographicException(a.bbr());
		}
		string text2;
		string text3;
		if (!ci.bie(text, out text2, out text3))
		{
			return text;
		}
		byte[] array4 = ci.bia(array);
		byte[] array5 = ci.bif(ci.bib(text3, array4));
		byte[] array6 = ci.bif(text2);
		if (array5 == null || array6 == null || !CryptographicOperations.FixedTimeEquals(array5, array6))
		{
			throw new CryptographicException(a.bbs());
		}
		return text3;
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x000192BC File Offset: 0x000174BC
	private static void mpj(string a)
	{
		try
		{
			long num = (long)(DateTime.UtcNow - new DateTime(59, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
			string text = Path.Combine(ci.hrw, string.Format(a.bbt(), num));
			File.Copy(a, text, true);
			Debug.LogWarning(a.bbu() + text);
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.bbv() + ex.Message);
		}
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x00019348 File Offset: 0x00017548
	private static void muz(string a)
	{
		try
		{
			long num = (long)(DateTime.UtcNow - new DateTime(-4, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
			string text = Path.Combine(ci.hrw, string.Format(a.bbw(), num));
			File.Copy(a, text, true);
			Debug.LogWarning(a.bbx() + text);
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.bby() + ex.Message);
		}
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x000193D4 File Offset: 0x000175D4
	public static string nww(string a, string b)
	{
		byte[] array = ci.big(a, -57);
		byte[] array2 = ci.bia(array);
		string text = ci.bib(b, array2);
		string text2 = ci.bic(b, text);
		byte[] array3 = new byte[53];
		byte[] array4;
		using (Aes aes = Aes.Create())
		{
			aes.Key = array;
			aes.IV = array3;
			ICryptoTransform cryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV);
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
				{
					using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
					{
						streamWriter.Write(text2);
					}
					array4 = memoryStream.ToArray();
				}
			}
		}
		return Convert.ToBase64String(array4);
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x000194D8 File Offset: 0x000176D8
	private static string hse(string a, byte[] b)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(a);
		string text;
		using (HMACSHA256 hmacsha = new HMACSHA256(b))
		{
			text = Convert.ToBase64String(hmacsha.ComputeHash(bytes));
		}
		return text;
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x00019524 File Offset: 0x00017724
	private static bool jxo(string a)
	{
		return a.StartsWith(a.bbz());
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x00019534 File Offset: 0x00017734
	private static bool ctv(string a, out string b, out string c)
	{
		b = null;
		c = null;
		int num = a.LastIndexOf(a.bca(), StringComparison.Ordinal);
		int num2 = a.bcb().Length;
		if (num < 0)
		{
			num = a.LastIndexOf(a.bcc(), StringComparison.Ordinal);
			num2 = a.bcd().Length;
			if (num < 0)
			{
				return false;
			}
		}
		int num3 = num + num2;
		int num4 = a.IndexOf((char)(-68), num3);
		if (num4 < 0)
		{
			return false;
		}
		b = a.Substring(num3, num4 - num3);
		int num5 = num;
		int num6 = num4 + 1;
		c = a.Remove(num5, num6 - num5);
		return true;
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x000195BC File Offset: 0x000177BC
	public static string co(string a, string b)
	{
		byte[] array = ci.big(a, -64);
		byte[] array2 = ci.bia(array);
		string text = ci.bib(b, array2);
		string text2 = ci.bic(b, text);
		byte[] array3 = new byte[55];
		byte[] array4;
		using (Aes aes = Aes.Create())
		{
			aes.Key = array;
			aes.IV = array3;
			ICryptoTransform cryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV);
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
				{
					using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
					{
						streamWriter.Write(text2);
					}
					array4 = memoryStream.ToArray();
				}
			}
		}
		return Convert.ToBase64String(array4);
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x000196C0 File Offset: 0x000178C0
	private static ci.LoadOutcome bhs(string a, out PlayerSaveData b)
	{
		b = null;
		if (!File.Exists(a))
		{
			return ci.LoadOutcome.NotFound;
		}
		string text;
		try
		{
			text = File.ReadAllText(a);
		}
		catch (IOException ex)
		{
			Debug.LogWarning(a.bce() + a + a.bcf() + ex.Message);
			return ci.LoadOutcome.IoFailure;
		}
		catch (UnauthorizedAccessException ex2)
		{
			Debug.LogWarning(a.bce() + a + a.bcg() + ex2.Message);
			return ci.LoadOutcome.IoFailure;
		}
		catch (Exception ex3)
		{
			Debug.LogWarning(a.bce() + a + a.bch() + ex3.Message);
			return ci.LoadOutcome.IoFailure;
		}
		ci.LoadOutcome loadOutcome;
		try
		{
			if (ci.bhw(text))
			{
				text = text.Substring(a.zt().Length);
				text = ci.bhy(ci.kou, text);
			}
			b = JsonUtility.FromJson<PlayerSaveData>(text);
			loadOutcome = ((b != null) ? ci.LoadOutcome.Success : ci.LoadOutcome.Corrupt);
		}
		catch (CryptographicException ex4)
		{
			Debug.LogError(a.bce() + a + a.bci() + ex4.Message);
			loadOutcome = ci.LoadOutcome.Tampered;
		}
		catch (Exception ex5)
		{
			Debug.LogWarning(a.bce() + a + a.bcj() + ex5.Message);
			loadOutcome = ci.LoadOutcome.Corrupt;
		}
		return loadOutcome;
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x00019810 File Offset: 0x00017A10
	private static byte[] dda(string a)
	{
		byte[] array;
		try
		{
			array = Convert.FromBase64String(a);
		}
		catch
		{
			array = null;
		}
		return array;
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x00017F1C File Offset: 0x0001611C
	private static bool bht(string a, out PlayerSaveData b)
	{
		return ci.bhs(a, out b) == ci.LoadOutcome.Success;
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x0001983C File Offset: 0x00017A3C
	public static string enb(string a, string b)
	{
		byte[] array = ci.big(a, -76);
		byte[] array2 = new byte[79];
		byte[] array3 = Convert.FromBase64String(b);
		string text = ci.bhz(array, array2, array3);
		if (text == null)
		{
			throw new CryptographicException(a.bck());
		}
		string text2;
		string text3;
		if (!ci.bie(text, out text2, out text3))
		{
			return text;
		}
		byte[] array4 = ci.bia(array);
		byte[] array5 = ci.bif(ci.bib(text3, array4));
		byte[] array6 = ci.bif(text2);
		if (array5 == null || array6 == null || !CryptographicOperations.FixedTimeEquals(array5, array6))
		{
			throw new CryptographicException(a.bcl());
		}
		return text3;
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x000198D4 File Offset: 0x00017AD4
	private static string mfs(byte[] a, byte[] b, byte[] c)
	{
		string text;
		try
		{
			using (Aes aes = Aes.Create())
			{
				aes.Key = a;
				aes.IV = b;
				ICryptoTransform cryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV);
				using (MemoryStream memoryStream = new MemoryStream(c))
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read))
					{
						using (StreamReader streamReader = new StreamReader(cryptoStream))
						{
							text = streamReader.ReadToEnd();
						}
					}
				}
			}
		}
		catch
		{
			text = null;
		}
		return text;
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x000199A0 File Offset: 0x00017BA0
	public static string bdt(string a, string b)
	{
		byte[] array = ci.big(a, -20);
		byte[] array2 = ci.bia(array);
		string text = ci.bib(b, array2);
		string text2 = ci.bic(b, text);
		byte[] array3 = new byte[97];
		byte[] array4;
		using (Aes aes = Aes.Create())
		{
			aes.Key = array;
			aes.IV = array3;
			ICryptoTransform cryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV);
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
				{
					using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
					{
						streamWriter.Write(text2);
					}
					array4 = memoryStream.ToArray();
				}
			}
		}
		return Convert.ToBase64String(array4);
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x00019AA4 File Offset: 0x00017CA4
	private static bool bid(string a)
	{
		for (int i = a.Length - 1; i >= 0; i--)
		{
			char c = a[i];
			if (c != ' ' && c != '\t' && c != '\n' && c != '\r')
			{
				return c != '{';
			}
		}
		return false;
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x00019AEC File Offset: 0x00017CEC
	public static void exf()
	{
		ci.hrz = true;
		ci.bhm();
		string text = Path.Combine(ci.hrw, a.bcm());
		ci.bhq(bq.hlf.Save(), text, null);
		bq.hlf = new PlayerData();
		ci.Save(null);
		bq.bao();
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x00019B3C File Offset: 0x00017D3C
	private static bool eym(string a)
	{
		for (int i = a.Length - 1; i >= 0; i--)
		{
			char c = a[i];
			if ((int)c != -77 && c != '-' && c != '*' && (int)c != -35)
			{
				return c != 'S';
			}
		}
		return false;
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x00019B84 File Offset: 0x00017D84
	private static void nvo()
	{
		if (ci.hry)
		{
			return;
		}
		ci.hrw = Path.Combine(Application.dataPath, a.bcn());
		if (!Directory.Exists(ci.hrw))
		{
			Directory.CreateDirectory(ci.hrw);
		}
		ci.hrx = Path.Combine(ci.hrw, a.bco());
		ci.hry = true;
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x00019C48 File Offset: 0x00017E48
	public static byte[] ffq(string a, int b = 32)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(a);
		Array.Resize<byte>(ref bytes, b);
		return bytes;
	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x00019C6A File Offset: 0x00017E6A
	private static bool jco(string a)
	{
		return a.StartsWith(a.bcp());
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x00019C78 File Offset: 0x00017E78
	public static byte[] ch(string a, int b = 32)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(a);
		Array.Resize<byte>(ref bytes, b);
		return bytes;
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x00019C9C File Offset: 0x00017E9C
	public static byte[] mpp(string a, int b = 32)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(a);
		Array.Resize<byte>(ref bytes, b);
		return bytes;
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x00019CC0 File Offset: 0x00017EC0
	private static void cey(string a)
	{
		try
		{
			if (File.Exists(a))
			{
				File.Delete(a);
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(a.bcq() + a + a.bcr() + ex.Message);
		}
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x00019D0C File Offset: 0x00017F0C
	private static byte[] hle(string a)
	{
		byte[] array;
		try
		{
			array = Convert.FromBase64String(a);
		}
		catch
		{
			array = null;
		}
		return array;
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x00019D38 File Offset: 0x00017F38
	private static byte[] oai()
	{
		byte[] array = new byte[ci.hrr.Length + ci.hrs.Length + ci.hrt.Length + ci.hru.Length];
		int num = 0;
		Buffer.BlockCopy(ci.hrr, 0, array, num, ci.hrr.Length);
		num += ci.hrr.Length;
		Buffer.BlockCopy(ci.hrs, 0, array, num, ci.hrs.Length);
		num += ci.hrs.Length;
		Buffer.BlockCopy(ci.hrt, 0, array, num, ci.hrt.Length);
		num += ci.hrt.Length;
		Buffer.BlockCopy(ci.hru, 0, array, num, ci.hru.Length);
		return array;
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x00019DDC File Offset: 0x00017FDC
	private static void mjs()
	{
		if (ci.hry)
		{
			return;
		}
		ci.hrw = Path.Combine(Application.dataPath, a.bcs());
		if (!Directory.Exists(ci.hrw))
		{
			Directory.CreateDirectory(ci.hrw);
		}
		ci.hrx = Path.Combine(ci.hrw, a.bct());
		ci.hry = true;
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x00019E38 File Offset: 0x00018038
	private static ci.LoadOutcome mej(string a, out PlayerSaveData b)
	{
		b = null;
		if (!File.Exists(a))
		{
			return ci.LoadOutcome.NotFound;
		}
		string text;
		try
		{
			text = File.ReadAllText(a);
		}
		catch (IOException ex)
		{
			Debug.LogWarning(a.bcu() + a + a.bcv() + ex.Message);
			return ci.LoadOutcome.IoFailure;
		}
		catch (UnauthorizedAccessException ex2)
		{
			Debug.LogWarning(a.bcw() + a + a.bcx() + ex2.Message);
			return ci.LoadOutcome.IoFailure;
		}
		catch (Exception ex3)
		{
			Debug.LogWarning(a.bcy() + a + a.bcz() + ex3.Message);
			return ci.LoadOutcome.IoFailure;
		}
		ci.LoadOutcome loadOutcome;
		try
		{
			if (ci.bhw(text))
			{
				text = text.Substring(a.bda().Length);
				text = ci.bhy(ci.kou, text);
			}
			b = JsonUtility.FromJson<PlayerSaveData>(text);
			loadOutcome = ((b != null) ? ci.LoadOutcome.Success : ci.LoadOutcome.Corrupt);
		}
		catch (CryptographicException ex4)
		{
			Debug.LogError(a.bdb() + a + a.bdc() + ex4.Message);
			loadOutcome = ci.LoadOutcome.Tampered;
		}
		catch (Exception ex5)
		{
			Debug.LogWarning(a.bdd() + a + a.bde() + ex5.Message);
			loadOutcome = ci.LoadOutcome.Corrupt;
		}
		return loadOutcome;
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x00019F88 File Offset: 0x00018188
	private static void gom()
	{
		if (ci.hry)
		{
			return;
		}
		ci.hrw = Path.Combine(Application.dataPath, a.bdf());
		if (!Directory.Exists(ci.hrw))
		{
			Directory.CreateDirectory(ci.hrw);
		}
		ci.hrx = Path.Combine(ci.hrw, a.bdg());
		ci.hry = true;
	}

	// Token: 0x04000279 RID: 633
	public const string hrb = "Resolution_Preference";

	// Token: 0x0400027A RID: 634
	public const string hrc = "AntiAliasingPreference";

	// Token: 0x0400027B RID: 635
	public const string hrd = "FullscreenPreference";

	// Token: 0x0400027C RID: 636
	public const string hre = "BorderlessPreference";

	// Token: 0x0400027D RID: 637
	public const string hrf = "FPSPreference";

	// Token: 0x0400027E RID: 638
	public const string hrg = "MaskPreference";

	// Token: 0x0400027F RID: 639
	public const string hrh = "AutoShootPreference";

	// Token: 0x04000280 RID: 640
	public const string hri = "DamageNumbersPreference";

	// Token: 0x04000281 RID: 641
	public const string hrj = "BackgroundEffectsPreference";

	// Token: 0x04000282 RID: 642
	public const string hrk = "MasterVolume";

	// Token: 0x04000283 RID: 643
	public const string hrl = "GameVolume";

	// Token: 0x04000284 RID: 644
	public const string hrm = "EffectVolume";

	// Token: 0x04000285 RID: 645
	public const string hrn = "VoiceVolume";

	// Token: 0x04000286 RID: 646
	public const string hro = "PlayerControlMode";

	// Token: 0x04000287 RID: 647
	public const string hrp = "PlayerMoveSpeed";

	// Token: 0x04000288 RID: 648
	public const string hrq = "PlayerDeadZone";

	// Token: 0x04000289 RID: 649
	private static readonly byte[] hrr = new byte[] { 82, 97, 109, 101 };

	// Token: 0x0400028A RID: 650
	private static readonly byte[] hrs = new byte[] { 110, 73, 115, 65 };

	// Token: 0x0400028B RID: 651
	private static readonly byte[] hrt = new byte[] { 71, 111, 111, 100 };

	// Token: 0x0400028C RID: 652
	private static readonly byte[] hru = new byte[] { 67, 97, 116 };

	// Token: 0x0400028D RID: 653
	private static string hrv;

	// Token: 0x0400028E RID: 654
	private static string hrw;

	// Token: 0x0400028F RID: 655
	private static string hrx;

	// Token: 0x04000290 RID: 656
	private static bool hry;

	// Token: 0x04000291 RID: 657
	private static bool hrz;

	// Token: 0x04000293 RID: 659
	private const string hsb = ",\"_hmac\":\"";

	// Token: 0x04000294 RID: 660
	private const int hsc = 16;

	// Token: 0x04000295 RID: 661
	private const string hsd = "::mac";

	// Token: 0x02000059 RID: 89
	private enum LoadOutcome
	{
		// Token: 0x04000297 RID: 663
		Success,
		// Token: 0x04000298 RID: 664
		NotFound,
		// Token: 0x04000299 RID: 665
		IoFailure,
		// Token: 0x0400029A RID: 666
		Corrupt,
		// Token: 0x0400029B RID: 667
		Tampered
	}
}
