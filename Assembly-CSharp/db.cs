using System;
using System.Text;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000099 RID: 153
public class db : MonoBehaviour
{
	// Token: 0x060006CD RID: 1741 RVA: 0x00025998 File Offset: 0x00023B98
	public void bsn(GameLinkEntry a, t b)
	{
		this.hwf = a;
		if (this.icon != null && a.icon != null)
		{
			this.icon.sprite = a.icon;
		}
		if (this.dot != null)
		{
			this.dot.dotId = a.biw() + a.gameId;
			this.dot.parentDot = b;
			this.dot.us();
			if (b != null)
			{
				b.ut(this.dot);
			}
		}
		if (this.button != null)
		{
			this.button.onClick.RemoveAllListeners();
			this.button.onClick.AddListener(new UnityAction(this.bso));
		}
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x00025A68 File Offset: 0x00023C68
	private static void bsq(StringBuilder a, ref char b, string c, string d)
	{
		a.Append(b).Append(c).Append('=')
			.Append(Uri.EscapeDataString(d));
		b = '&';
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x00025A90 File Offset: 0x00023C90
	private string bsp()
	{
		string text;
		if (this.hwf.steamAppId > 0U)
		{
			text = string.Format(a.bix(), this.hwf.steamAppId);
		}
		else
		{
			if (string.IsNullOrEmpty(this.hwf.url))
			{
				return null;
			}
			text = this.hwf.url;
		}
		string text2 = (string.IsNullOrEmpty(this.hwf.gameId) ? a.biy() : this.hwf.gameId);
		StringBuilder stringBuilder = new StringBuilder(text);
		char c = (text.Contains(a.biz()) ? '&' : '?');
		db.bsq(stringBuilder, ref c, a.bja(), a.bjb());
		db.bsq(stringBuilder, ref c, a.bjc(), a.bjd());
		db.bsq(stringBuilder, ref c, a.bje(), text2);
		string text3 = stringBuilder.ToString();
		if (text3.Contains(a.bjf()))
		{
			return a.bjg() + text3;
		}
		return text3;
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x00025B84 File Offset: 0x00023D84
	private string nwn()
	{
		string text;
		if (this.hwf.steamAppId > 0U)
		{
			text = string.Format(a.bjh(), this.hwf.steamAppId);
		}
		else
		{
			if (string.IsNullOrEmpty(this.hwf.url))
			{
				return null;
			}
			text = this.hwf.url;
		}
		string text2 = (string.IsNullOrEmpty(this.hwf.gameId) ? a.bji() : this.hwf.gameId);
		StringBuilder stringBuilder = new StringBuilder(text);
		char c = (char)(text.Contains(a.bjj()) ? (-67) : 46);
		db.bsq(stringBuilder, ref c, a.bjk(), a.bjl());
		db.bsq(stringBuilder, ref c, a.bjm(), a.bjn());
		db.bsq(stringBuilder, ref c, a.bjo(), text2);
		string text3 = stringBuilder.ToString();
		if (text3.Contains(a.bjp()))
		{
			return a.bjq() + text3;
		}
		return text3;
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x00025C78 File Offset: 0x00023E78
	private string bta()
	{
		string text;
		if (this.hwf.steamAppId > 0U)
		{
			text = string.Format(a.bjr(), this.hwf.steamAppId);
		}
		else
		{
			if (string.IsNullOrEmpty(this.hwf.url))
			{
				return null;
			}
			text = this.hwf.url;
		}
		string text2 = (string.IsNullOrEmpty(this.hwf.gameId) ? a.bjs() : this.hwf.gameId);
		StringBuilder stringBuilder = new StringBuilder(text);
		char c = (char)(text.Contains(a.bjt()) ? (-90) : (-64));
		db.bsq(stringBuilder, ref c, a.bju(), a.bjv());
		db.bsq(stringBuilder, ref c, a.bjw(), a.bjx());
		db.bsq(stringBuilder, ref c, a.bjy(), text2);
		string text3 = stringBuilder.ToString();
		if (text3.Contains(a.bjz()))
		{
			return a.bka() + text3;
		}
		return text3;
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x00025D6C File Offset: 0x00023F6C
	private void bso()
	{
		if (this.hwf == null)
		{
			return;
		}
		bq.hlk = false;
		string text = this.bsp();
		if (string.IsNullOrEmpty(text))
		{
			Debug.LogError(a.bkb() + this.hwf.gameId + a.bkc());
			return;
		}
		Application.OpenURL(text);
		if (this.dot != null)
		{
			this.dot.uq();
		}
		if (cx.kpw != null)
		{
			cx.kpw.brh();
		}
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x00025DF0 File Offset: 0x00023FF0
	private void fjg()
	{
		if (this.hwf == null)
		{
			return;
		}
		bq.hlk = false;
		string text = this.bsp();
		if (string.IsNullOrEmpty(text))
		{
			Debug.LogError(a.bkd() + this.hwf.gameId + a.bke());
			return;
		}
		Application.OpenURL(text);
		if (this.dot != null)
		{
			this.dot.uq();
		}
		if (cx.kpw != null)
		{
			cx.kpw.brh();
		}
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x00025E74 File Offset: 0x00024074
	private void fkl()
	{
		if (this.hwf == null)
		{
			return;
		}
		bq.hlk = false;
		string text = this.bsp();
		if (string.IsNullOrEmpty(text))
		{
			Debug.LogError(a.bkf() + this.hwf.gameId + a.bkg());
			return;
		}
		Application.OpenURL(text);
		if (this.dot != null)
		{
			this.dot.uq();
		}
		if (cx.kpw != null)
		{
			cx.kpw.brh();
		}
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x00025EF8 File Offset: 0x000240F8
	private void ebt()
	{
		if (this.hwf == null)
		{
			return;
		}
		bq.hlk = false;
		string text = this.bsp();
		if (string.IsNullOrEmpty(text))
		{
			Debug.LogError(a.bkh() + this.hwf.gameId + a.bki());
			return;
		}
		Application.OpenURL(text);
		if (this.dot != null)
		{
			this.dot.uq();
		}
		if (cx.kpw != null)
		{
			cx.kpw.brh();
		}
	}

	// Token: 0x0400068A RID: 1674
	public Image icon;

	// Token: 0x0400068B RID: 1675
	public Button button;

	// Token: 0x0400068C RID: 1676
	public t dot;

	// Token: 0x0400068D RID: 1677
	private GameLinkEntry hwf;
}
