using System;
using System.Collections;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.Networking;
using UnityEngine.UI;

// Token: 0x02000089 RID: 137
public class cs : MonoBehaviour
{
	// Token: 0x060005D6 RID: 1494 RVA: 0x0002048C File Offset: 0x0001E68C
	public void odl(bool a, uint b, string c = "")
	{
		this.htw = a;
		this.htx = b;
		this.hty = null;
		if (this.objLock != null)
		{
			this.objLock.SetActive(a);
			if (a)
			{
				Button component = this.objLock.GetComponent<Button>();
				if (component != null)
				{
					component.onClick.RemoveAllListeners();
					component.onClick.AddListener(new UnityAction(this.bod));
				}
				u u = this.objLock.GetComponent<u>();
				if (u == null)
				{
					u = this.objLock.AddComponent<u>();
				}
				u.Entered = new Action(this.bob);
				u.Exited = new Action(this.boc);
			}
		}
		if (a && b > 0U && !cs.htz.ContainsKey(b))
		{
			if (!string.IsNullOrEmpty(c))
			{
				cs.htz[b] = c;
			}
			base.StartCoroutine(cs.boh(b));
		}
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x00020584 File Offset: 0x0001E784
	public void bob()
	{
		if (!this.htw || this.tipObject == null)
		{
			return;
		}
		this.hty = this.boe();
		this.tipObject.vj(true);
		this.tipObject.vh(this.hty);
		this.tipObject.PointEnter();
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x000205DC File Offset: 0x0001E7DC
	private static string jf(string a, uint b)
	{
		if (!a.Contains(a.bgi()))
		{
			return null;
		}
		string text = a.bgj();
		int num = a.IndexOf(text);
		if (num < 0)
		{
			return null;
		}
		int num2 = num + text.Length;
		int num3 = a.IndexOf('a', num2);
		if (num3 < 0)
		{
			return null;
		}
		return a.Substring(num2, num3 - num2);
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x00020630 File Offset: 0x0001E830
	public void mqy()
	{
		if (!this.htw || this.tipObject == null)
		{
			return;
		}
		this.hty = this.boe();
		this.tipObject.vj(true);
		this.tipObject.vh(this.hty);
		this.tipObject.PointEnter();
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x00020688 File Offset: 0x0001E888
	private string bof(string a, string b)
	{
		if (LocalizationSettings.InitializationOperation.IsDone)
		{
			StringTable table = LocalizationSettings.StringDatabase.GetTable(a.rh(), null);
			if (table != null)
			{
				StringTableEntry entry = table.GetEntry(a);
				if (entry != null)
				{
					return entry.GetLocalizedString();
				}
			}
		}
		return b;
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x000206D6 File Offset: 0x0001E8D6
	public void og()
	{
		if (!this.htw || this.tipObject == null)
		{
			return;
		}
		this.tipObject.PointExit();
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x000206D6 File Offset: 0x0001E8D6
	public void boc()
	{
		if (!this.htw || this.tipObject == null)
		{
			return;
		}
		this.tipObject.PointExit();
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x000206FC File Offset: 0x0001E8FC
	private static string jyf(string a, uint b)
	{
		if (!a.Contains(a.bgk()))
		{
			return null;
		}
		string text = a.bgl();
		int num = a.IndexOf(text);
		if (num < 0)
		{
			return null;
		}
		int num2 = num + text.Length;
		int num3 = a.IndexOf('\0', num2);
		if (num3 < 0)
		{
			return null;
		}
		return a.Substring(num2, num3 - num2);
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x0002075C File Offset: 0x0001E95C
	private string boe()
	{
		string text = this.bof(a.bgm(), a.bgn());
		string text2 = this.bof(a.bfy(), a.bfz());
		string text3 = this.bog();
		return string.Format(text, text3) + a.bfx() + text2;
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x000207A4 File Offset: 0x0001E9A4
	private string krv()
	{
		string text;
		if (this.htx > 0U && cs.htz.TryGetValue(this.htx, out text))
		{
			return text;
		}
		if (this.htx <= 0U)
		{
			return a.bgo();
		}
		return this.htx.ToString();
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x000207EA File Offset: 0x0001E9EA
	public void dzn()
	{
		if (!this.htw)
		{
			return;
		}
		if (this.htx > 0U)
		{
			Application.OpenURL(string.Format(a.bgp(), this.htx));
		}
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x00020818 File Offset: 0x0001EA18
	public void boa(bool a)
	{
		this.htw = a;
		if (this.objLock != null)
		{
			this.objLock.SetActive(a);
		}
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x0002083B File Offset: 0x0001EA3B
	public void bxz()
	{
		if (!this.htw)
		{
			return;
		}
		if (this.htx > 0U)
		{
			Application.OpenURL(string.Format(a.bgq(), this.htx));
		}
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x0002086C File Offset: 0x0001EA6C
	public void bnz(bool a, uint b, string c = "")
	{
		this.htw = a;
		this.htx = b;
		this.hty = null;
		if (this.objLock != null)
		{
			this.objLock.SetActive(a);
			if (a)
			{
				Button component = this.objLock.GetComponent<Button>();
				if (component != null)
				{
					component.onClick.RemoveAllListeners();
					component.onClick.AddListener(new UnityAction(this.bod));
				}
				u u = this.objLock.GetComponent<u>();
				if (u == null)
				{
					u = this.objLock.AddComponent<u>();
				}
				u.Entered = new Action(this.bob);
				u.Exited = new Action(this.boc);
			}
		}
		if (a && b > 0U && !cs.htz.ContainsKey(b))
		{
			if (!string.IsNullOrEmpty(c))
			{
				cs.htz[b] = c;
			}
			base.StartCoroutine(cs.boh(b));
		}
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x00020964 File Offset: 0x0001EB64
	public void cw(bool a, uint b, string c = "")
	{
		this.htw = a;
		this.htx = b;
		this.hty = null;
		if (this.objLock != null)
		{
			this.objLock.SetActive(a);
			if (a)
			{
				Button component = this.objLock.GetComponent<Button>();
				if (component != null)
				{
					component.onClick.RemoveAllListeners();
					component.onClick.AddListener(new UnityAction(this.bod));
				}
				u u = this.objLock.GetComponent<u>();
				if (u == null)
				{
					u = this.objLock.AddComponent<u>();
				}
				u.Entered = new Action(this.bob);
				u.Exited = new Action(this.boc);
			}
		}
		if (a && b > 0U && !cs.htz.ContainsKey(b))
		{
			if (!string.IsNullOrEmpty(c))
			{
				cs.htz[b] = c;
			}
			base.StartCoroutine(cs.boh(b));
		}
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x00020A5A File Offset: 0x0001EC5A
	public void jhj()
	{
		if (!this.htw)
		{
			return;
		}
		if (this.htx > 0U)
		{
			Application.OpenURL(string.Format(a.bgr(), this.htx));
		}
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x00020A88 File Offset: 0x0001EC88
	public void lfq()
	{
		if (!this.htw)
		{
			return;
		}
		if (this.htx > 0U)
		{
			Application.OpenURL(string.Format(a.bgs(), this.htx));
		}
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x000206D6 File Offset: 0x0001E8D6
	public void nzb()
	{
		if (!this.htw || this.tipObject == null)
		{
			return;
		}
		this.tipObject.PointExit();
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x00020AB8 File Offset: 0x0001ECB8
	private static string boi(string a, uint b)
	{
		if (!a.Contains(a.bgt()))
		{
			return null;
		}
		string text = a.bgu();
		int num = a.IndexOf(text);
		if (num < 0)
		{
			return null;
		}
		int num2 = num + text.Length;
		int num3 = a.IndexOf('"', num2);
		if (num3 < 0)
		{
			return null;
		}
		return a.Substring(num2, num3 - num2);
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x00020B0B File Offset: 0x0001ED0B
	public void bod()
	{
		if (!this.htw)
		{
			return;
		}
		if (this.htx > 0U)
		{
			Application.OpenURL(string.Format(a.bgv(), this.htx));
		}
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x00020B3C File Offset: 0x0001ED3C
	public void mas()
	{
		if (!this.htw || this.tipObject == null)
		{
			return;
		}
		this.hty = this.boe();
		this.tipObject.vj(true);
		this.tipObject.vh(this.hty);
		this.tipObject.PointEnter();
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x00020B94 File Offset: 0x0001ED94
	private static IEnumerator boh(uint a)
	{
		string text = string.Format(a.bgg(), a);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(text))
		{
			unityWebRequest.timeout = 10;
			yield return unityWebRequest.SendWebRequest();
			if (unityWebRequest.result != UnityWebRequest.Result.Success)
			{
				Debug.LogWarning(string.Format(a.bgh(), a, unityWebRequest.error));
				yield break;
			}
			string text2 = cs.boi(unityWebRequest.downloadHandler.text, a);
			if (!string.IsNullOrEmpty(text2))
			{
				cs.htz[a] = text2;
			}
		}
		UnityWebRequest unityWebRequest = null;
		yield break;
		yield break;
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x00020BA4 File Offset: 0x0001EDA4
	private string buq()
	{
		string text;
		if (this.htx > 0U && cs.htz.TryGetValue(this.htx, out text))
		{
			return text;
		}
		if (this.htx <= 0U)
		{
			return a.bgw();
		}
		return this.htx.ToString();
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x00020BEC File Offset: 0x0001EDEC
	public void khi()
	{
		if (!this.htw || this.tipObject == null)
		{
			return;
		}
		this.hty = this.boe();
		this.tipObject.vj(true);
		this.tipObject.vh(this.hty);
		this.tipObject.PointEnter();
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x00020C44 File Offset: 0x0001EE44
	private string bog()
	{
		string text;
		if (this.htx > 0U && cs.htz.TryGetValue(this.htx, out text))
		{
			return text;
		}
		if (this.htx <= 0U)
		{
			return a.tk();
		}
		return this.htx.ToString();
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x00020C8C File Offset: 0x0001EE8C
	public void yd(bool a, uint b, string c = "")
	{
		this.htw = a;
		this.htx = b;
		this.hty = null;
		if (this.objLock != null)
		{
			this.objLock.SetActive(a);
			if (a)
			{
				Button component = this.objLock.GetComponent<Button>();
				if (component != null)
				{
					component.onClick.RemoveAllListeners();
					component.onClick.AddListener(new UnityAction(this.bod));
				}
				u u = this.objLock.GetComponent<u>();
				if (u == null)
				{
					u = this.objLock.AddComponent<u>();
				}
				u.Entered = new Action(this.bob);
				u.Exited = new Action(this.boc);
			}
		}
		if (a && b > 0U && !cs.htz.ContainsKey(b))
		{
			if (!string.IsNullOrEmpty(c))
			{
				cs.htz[b] = c;
			}
			base.StartCoroutine(cs.boh(b));
		}
	}

	// Token: 0x04000609 RID: 1545
	public GameObject objLock;

	// Token: 0x0400060A RID: 1546
	public bb tipObject;

	// Token: 0x0400060B RID: 1547
	private bool htw;

	// Token: 0x0400060C RID: 1548
	private uint htx;

	// Token: 0x0400060D RID: 1549
	private string hty;

	// Token: 0x0400060E RID: 1550
	private static readonly Dictionary<uint, string> htz = new Dictionary<uint, string>();
}
