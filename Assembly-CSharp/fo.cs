using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using BongoWaifu.Mcp.SpeechBubble;
using BongoWaifu.Multiplayer;
using UnityEngine;

// Token: 0x02000115 RID: 277
public sealed class fo : MonoBehaviour
{
	// Token: 0x060013AB RID: 5035 RVA: 0x00060E3C File Offset: 0x0005F03C
	private void Start()
	{
		this.dab();
	}

	// Token: 0x060013AC RID: 5036 RVA: 0x00060E44 File Offset: 0x0005F044
	private void njo()
	{
		if (this.iqy)
		{
			return;
		}
		if (bl.kmv == null)
		{
			return;
		}
		MultiplayerSession.iva += this.dac;
		MultiplayerSession.ivb += this.dag;
		MultiplayerSession.ivc += this.daf;
		bl.kmv.hjh += this.daj;
		GirlController.hpv += this.dah;
		this.iqy = true;
	}

	// Token: 0x060013AE RID: 5038 RVA: 0x00060ECC File Offset: 0x0005F0CC
	private void dae()
	{
		this.ira = false;
		if (!this.iqu)
		{
			return;
		}
		this.iqu = false;
		bool flag = this.iqv;
		this.iqv = false;
		if (!flag)
		{
			fq.dbg(string.Format(a.dtx(), bq.hly));
			return;
		}
		fq.dbg(string.Format(a.dty(), this.iqt));
		bl bl = bl.kmv;
		if (bl != null)
		{
			bl.xh(this.iqt);
		}
	}

	// Token: 0x060013AF RID: 5039 RVA: 0x00060F50 File Offset: 0x0005F150
	private static int laq()
	{
		PlayerData hlf = bq.hlf;
		if (!(hlf != null))
		{
			return 0;
		}
		return hlf.playerSaveData.dirtinessLevel;
	}

	// Token: 0x060013B0 RID: 5040 RVA: 0x00060F7C File Offset: 0x0005F17C
	private void dej()
	{
		if (!MultiplayerSession.iuw)
		{
			return;
		}
		this.dak();
		ClothingSet clothingSet = fh.cyk();
		this.ira = true;
		this.iqz = clothingSet;
		this.iqx = false;
		MultiplayerSession.dhw(clothingSet);
		MultiplayerSession.dib(fo.dai());
		MultiplayerSession.did(fi.kth);
		MultiplayerSession.die(bq.hlh);
	}

	// Token: 0x060013B1 RID: 5041 RVA: 0x00060E3C File Offset: 0x0005F03C
	private void OnEnable()
	{
		this.dab();
	}

	// Token: 0x060013B2 RID: 5042 RVA: 0x00060FD8 File Offset: 0x0005F1D8
	private void crx()
	{
		if (!this.iqy)
		{
			return;
		}
		MultiplayerSession.iva -= this.dac;
		MultiplayerSession.ivb -= this.dag;
		MultiplayerSession.ivc -= this.daf;
		if (bl.kmv != null)
		{
			bl.kmv.hjh -= this.daj;
		}
		GirlController.hpv -= this.dah;
		this.iqy = false;
	}

	// Token: 0x060013B3 RID: 5043 RVA: 0x0006105C File Offset: 0x0005F25C
	private void dal(ActiveCharacterInfo a)
	{
		if (a.Type == CharacterType.Cat)
		{
			MultiplayerSession.dhx(CharacterKind.Cat, a.CharacterId);
			return;
		}
		MultiplayerSession.dhx(CharacterKind.Waifu, null);
	}

	// Token: 0x060013B4 RID: 5044 RVA: 0x0006107B File Offset: 0x0005F27B
	public static void dam()
	{
		if (fo.iqs != null)
		{
			fo.iqs.iqx = true;
		}
	}

	// Token: 0x060013B5 RID: 5045 RVA: 0x0006107B File Offset: 0x0005F27B
	public static void mgm()
	{
		if (fo.iqs != null)
		{
			fo.iqs.iqx = true;
		}
	}

	// Token: 0x060013B6 RID: 5046 RVA: 0x00061098 File Offset: 0x0005F298
	private void bek()
	{
		if (!this.iqy)
		{
			return;
		}
		MultiplayerSession.iva -= this.dac;
		MultiplayerSession.ivb -= this.dag;
		MultiplayerSession.ivc -= this.daf;
		if (bl.kmv != null)
		{
			bl.kmv.hjh -= this.daj;
		}
		GirlController.hpv -= this.dah;
		this.iqy = false;
	}

	// Token: 0x060013B7 RID: 5047 RVA: 0x0006111C File Offset: 0x0005F31C
	private void dad()
	{
		bl bl = bl.kmv;
		if (bl == null)
		{
			fq.dbg(a.dtz());
			return;
		}
		fq.dbg(string.Format(a.dua(), bq.hly));
		this.iqt = bq.hly;
		this.iqu = true;
		this.iqv = false;
		if (fo.dan(this.iqt))
		{
			this.iqv = true;
			this.iqw = true;
			try
			{
				bl.xh(0);
			}
			finally
			{
				this.iqw = false;
			}
		}
	}

	// Token: 0x060013B8 RID: 5048 RVA: 0x00060E3C File Offset: 0x0005F03C
	private void ffb()
	{
		this.dab();
	}

	// Token: 0x060013B9 RID: 5049 RVA: 0x000611B4 File Offset: 0x0005F3B4
	private static int oew()
	{
		PlayerData hlf = bq.hlf;
		if (!(hlf != null))
		{
			return 0;
		}
		return hlf.playerSaveData.dirtinessLevel;
	}

	// Token: 0x060013BA RID: 5050 RVA: 0x000611DD File Offset: 0x0005F3DD
	private void nai(gb a)
	{
		if (MultiplayerSession.iuw && MultiplayerSession.iux != null)
		{
			this.dak();
			MultiplayerSession.dhw(fh.cyk());
			MultiplayerSession.dib(fo.dai());
			MultiplayerSession.die(bq.hlh);
		}
	}

	// Token: 0x060013BB RID: 5051 RVA: 0x00061217 File Offset: 0x0005F417
	private void dp()
	{
		if (MultiplayerSession.iuw)
		{
			this.dad();
			return;
		}
		this.dae();
	}

	// Token: 0x060013BC RID: 5052 RVA: 0x00061230 File Offset: 0x0005F430
	private void Update()
	{
		if (!this.iqy)
		{
			this.dab();
		}
		if (!MultiplayerSession.iuw)
		{
			return;
		}
		if (MultiplayerSession.iux == null)
		{
			return;
		}
		ClothingSet clothingSet = fh.cyk();
		if (this.iqx || !this.ira || !clothingSet.diq(this.iqz))
		{
			this.iqx = false;
			this.ira = true;
			this.iqz = clothingSet;
			MultiplayerSession.dhw(clothingSet);
		}
	}

	// Token: 0x060013BD RID: 5053 RVA: 0x000612A4 File Offset: 0x0005F4A4
	private static bool dan(int a)
	{
		bl bl = bl.kmv;
		if (bl == null || a <= 0)
		{
			return false;
		}
		CatCharacterDefinition catCharacterDefinition = bl.xp(a);
		return catCharacterDefinition != null && catCharacterDefinition.unlockType == CatUnlockType.Workshop;
	}

	// Token: 0x060013BE RID: 5054 RVA: 0x00060E3C File Offset: 0x0005F03C
	private void jke()
	{
		this.dab();
	}

	// Token: 0x060013BF RID: 5055 RVA: 0x000612E4 File Offset: 0x0005F4E4
	private void dak()
	{
		ActiveCharacterInfo activeCharacterInfo = ((bl.kmv != null) ? bl.kmv.hjj : null);
		if (activeCharacterInfo != null)
		{
			this.dal(activeCharacterInfo);
			return;
		}
		MultiplayerSession.dhx(CharacterKind.Waifu, null);
	}

	// Token: 0x060013C0 RID: 5056 RVA: 0x00061217 File Offset: 0x0005F417
	private void brc()
	{
		if (MultiplayerSession.iuw)
		{
			this.dad();
			return;
		}
		this.dae();
	}

	// Token: 0x060013C1 RID: 5057 RVA: 0x00061324 File Offset: 0x0005F524
	private void OnDestroy()
	{
		if (fo.iqs == this)
		{
			fo.iqs = null;
		}
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x0006133C File Offset: 0x0005F53C
	private static int dai()
	{
		PlayerData hlf = bq.hlf;
		if (!(hlf != null))
		{
			return 0;
		}
		return hlf.playerSaveData.dirtinessLevel;
	}

	// Token: 0x060013C3 RID: 5059 RVA: 0x00060E3C File Offset: 0x0005F03C
	private void ntn()
	{
		this.dab();
	}

	// Token: 0x060013C4 RID: 5060 RVA: 0x00061365 File Offset: 0x0005F565
	private void iiz(int a)
	{
		if (!MultiplayerSession.iuw || MultiplayerSession.iux == null)
		{
			return;
		}
		MultiplayerSession.dib(a);
	}

	// Token: 0x060013C5 RID: 5061 RVA: 0x00061384 File Offset: 0x0005F584
	private void cpc()
	{
		if (!MultiplayerSession.iuw)
		{
			return;
		}
		this.dak();
		ClothingSet clothingSet = fh.cyk();
		this.ira = true;
		this.iqz = clothingSet;
		this.iqx = false;
		MultiplayerSession.dhw(clothingSet);
		MultiplayerSession.dib(fo.dai());
		MultiplayerSession.did(fi.kth);
		MultiplayerSession.die(bq.hlh);
	}

	// Token: 0x060013C6 RID: 5062 RVA: 0x000613E0 File Offset: 0x0005F5E0
	private void rg()
	{
		if (this.iqy)
		{
			return;
		}
		if (bl.kmv == null)
		{
			return;
		}
		MultiplayerSession.iva += this.dac;
		MultiplayerSession.ivb += this.dag;
		MultiplayerSession.ivc += this.daf;
		bl.kmv.hjh += this.daj;
		GirlController.hpv += this.dah;
		this.iqy = true;
	}

	// Token: 0x060013C7 RID: 5063 RVA: 0x00060E3C File Offset: 0x0005F03C
	private void lxw()
	{
		this.dab();
	}

	// Token: 0x060013C8 RID: 5064 RVA: 0x00061324 File Offset: 0x0005F524
	private void kmr()
	{
		if (fo.iqs == this)
		{
			fo.iqs = null;
		}
	}

	// Token: 0x060013C9 RID: 5065 RVA: 0x00060E3C File Offset: 0x0005F03C
	private void joo()
	{
		this.dab();
	}

	// Token: 0x060013CA RID: 5066 RVA: 0x00061468 File Offset: 0x0005F668
	private void nud()
	{
		if (!this.iqy)
		{
			this.dab();
		}
		if (!MultiplayerSession.iuw)
		{
			return;
		}
		if (MultiplayerSession.iux == null)
		{
			return;
		}
		ClothingSet clothingSet = fh.cyk();
		if (this.iqx || !this.ira || !clothingSet.diq(this.iqz))
		{
			this.iqx = false;
			this.ira = true;
			this.iqz = clothingSet;
			MultiplayerSession.dhw(clothingSet);
		}
	}

	// Token: 0x060013CB RID: 5067 RVA: 0x000614D9 File Offset: 0x0005F6D9
	private void iys()
	{
		if (fo.iqs != null && fo.iqs != this)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		fo.iqs = this;
	}

	// Token: 0x060013CC RID: 5068 RVA: 0x00061504 File Offset: 0x0005F704
	private void ijz()
	{
		this.ira = false;
		if (!this.iqu)
		{
			return;
		}
		this.iqu = false;
		bool flag = this.iqv;
		this.iqv = false;
		if (!flag)
		{
			fq.dbg(string.Format(a.dub(), bq.hly));
			return;
		}
		fq.dbg(string.Format(a.duc(), this.iqt));
		bl bl = bl.kmv;
		if (bl != null)
		{
			bl.xh(this.iqt);
		}
	}

	// Token: 0x060013CD RID: 5069 RVA: 0x00061588 File Offset: 0x0005F788
	private void OnDisable()
	{
		if (!this.iqy)
		{
			return;
		}
		MultiplayerSession.iva -= this.dac;
		MultiplayerSession.ivb -= this.dag;
		MultiplayerSession.ivc -= this.daf;
		if (bl.kmv != null)
		{
			bl.kmv.hjh -= this.daj;
		}
		GirlController.hpv -= this.dah;
		this.iqy = false;
	}

	// Token: 0x060013CE RID: 5070 RVA: 0x0006160C File Offset: 0x0005F80C
	private void hkp()
	{
		bl bl = bl.kmv;
		if (bl == null)
		{
			fq.dbg(a.dud());
			return;
		}
		fq.dbg(string.Format(a.due(), bq.hly));
		this.iqt = bq.hly;
		this.iqu = true;
		this.iqv = false;
		if (fo.dan(this.iqt))
		{
			this.iqv = true;
			this.iqw = true;
			try
			{
				bl.xh(0);
			}
			finally
			{
				this.iqw = false;
			}
		}
	}

	// Token: 0x060013CF RID: 5071 RVA: 0x00061365 File Offset: 0x0005F565
	private void dah(int a)
	{
		if (!MultiplayerSession.iuw || MultiplayerSession.iux == null)
		{
			return;
		}
		MultiplayerSession.dib(a);
	}

	// Token: 0x060013D0 RID: 5072 RVA: 0x00060E3C File Offset: 0x0005F03C
	private void nee()
	{
		this.dab();
	}

	// Token: 0x060013D1 RID: 5073 RVA: 0x0006107B File Offset: 0x0005F27B
	public static void fku()
	{
		if (fo.iqs != null)
		{
			fo.iqs.iqx = true;
		}
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x000616A4 File Offset: 0x0005F8A4
	private void kxi()
	{
		if (!this.iqy)
		{
			this.dab();
		}
		if (!MultiplayerSession.iuw)
		{
			return;
		}
		if (MultiplayerSession.iux == null)
		{
			return;
		}
		ClothingSet clothingSet = fh.cyk();
		if (this.iqx || !this.ira || !clothingSet.diq(this.iqz))
		{
			this.iqx = false;
			this.ira = true;
			this.iqz = clothingSet;
			MultiplayerSession.dhw(clothingSet);
		}
	}

	// Token: 0x060013D3 RID: 5075 RVA: 0x00061217 File Offset: 0x0005F417
	private void dhi()
	{
		if (MultiplayerSession.iuw)
		{
			this.dad();
			return;
		}
		this.dae();
	}

	// Token: 0x060013D4 RID: 5076 RVA: 0x00061718 File Offset: 0x0005F918
	private void iyi()
	{
		ActiveCharacterInfo activeCharacterInfo = ((bl.kmv != null) ? bl.kmv.hjj : null);
		if (activeCharacterInfo != null)
		{
			this.dal(activeCharacterInfo);
			return;
		}
		MultiplayerSession.dhx(CharacterKind.Waifu, null);
	}

	// Token: 0x060013D5 RID: 5077 RVA: 0x00061758 File Offset: 0x0005F958
	private void dag()
	{
		if (!MultiplayerSession.iuw)
		{
			return;
		}
		this.dak();
		ClothingSet clothingSet = fh.cyk();
		this.ira = true;
		this.iqz = clothingSet;
		this.iqx = false;
		MultiplayerSession.dhw(clothingSet);
		MultiplayerSession.dib(fo.dai());
		MultiplayerSession.did(fi.kth);
		MultiplayerSession.die(bq.hlh);
	}

	// Token: 0x060013D6 RID: 5078 RVA: 0x000617B4 File Offset: 0x0005F9B4
	private void bzn()
	{
		this.ira = false;
		if (!this.iqu)
		{
			return;
		}
		this.iqu = false;
		bool flag = this.iqv;
		this.iqv = false;
		if (!flag)
		{
			fq.dbg(string.Format(a.duf(), bq.hly));
			return;
		}
		fq.dbg(string.Format(a.dug(), this.iqt));
		bl bl = bl.kmv;
		if (bl != null)
		{
			bl.xh(this.iqt);
		}
	}

	// Token: 0x060013D7 RID: 5079 RVA: 0x00061838 File Offset: 0x0005FA38
	private static bool fjn(int a)
	{
		bl bl = bl.kmv;
		if (bl == null || a <= 0)
		{
			return false;
		}
		CatCharacterDefinition catCharacterDefinition = bl.xp(a);
		return catCharacterDefinition != null && catCharacterDefinition.unlockType == CatUnlockType.Workshop;
	}

	// Token: 0x060013D8 RID: 5080 RVA: 0x000614D9 File Offset: 0x0005F6D9
	private void fyx()
	{
		if (fo.iqs != null && fo.iqs != this)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		fo.iqs = this;
	}

	// Token: 0x060013D9 RID: 5081 RVA: 0x00061878 File Offset: 0x0005FA78
	private void kya()
	{
		if (this.iqy)
		{
			return;
		}
		if (bl.kmv == null)
		{
			return;
		}
		MultiplayerSession.iva += this.dac;
		MultiplayerSession.ivb += this.dag;
		MultiplayerSession.ivc += this.daf;
		bl.kmv.hjh += this.daj;
		GirlController.hpv += this.dah;
		this.iqy = true;
	}

	// Token: 0x060013DA RID: 5082 RVA: 0x00061900 File Offset: 0x0005FB00
	private void fax()
	{
		bl bl = bl.kmv;
		if (bl == null)
		{
			fq.dbg(a.duh());
			return;
		}
		fq.dbg(string.Format(a.dui(), bq.hly));
		this.iqt = bq.hly;
		this.iqu = true;
		this.iqv = false;
		if (fo.dan(this.iqt))
		{
			this.iqv = true;
			this.iqw = true;
			try
			{
				bl.xh(0);
			}
			finally
			{
				this.iqw = false;
			}
		}
	}

	// Token: 0x060013DB RID: 5083 RVA: 0x00061998 File Offset: 0x0005FB98
	private void dab()
	{
		if (this.iqy)
		{
			return;
		}
		if (bl.kmv == null)
		{
			return;
		}
		MultiplayerSession.iva += this.dac;
		MultiplayerSession.ivb += this.dag;
		MultiplayerSession.ivc += this.daf;
		bl.kmv.hjh += this.daj;
		GirlController.hpv += this.dah;
		this.iqy = true;
	}

	// Token: 0x060013DC RID: 5084 RVA: 0x00061A20 File Offset: 0x0005FC20
	private void mcr()
	{
		ActiveCharacterInfo activeCharacterInfo = ((bl.kmv != null) ? bl.kmv.hjj : null);
		if (activeCharacterInfo != null)
		{
			this.dal(activeCharacterInfo);
			return;
		}
		MultiplayerSession.dhx(CharacterKind.Waifu, null);
	}

	// Token: 0x060013DD RID: 5085 RVA: 0x000611DD File Offset: 0x0005F3DD
	private void daf(gb a)
	{
		if (MultiplayerSession.iuw && MultiplayerSession.iux != null)
		{
			this.dak();
			MultiplayerSession.dhw(fh.cyk());
			MultiplayerSession.dib(fo.dai());
			MultiplayerSession.die(bq.hlh);
		}
	}

	// Token: 0x060013DE RID: 5086 RVA: 0x00061A60 File Offset: 0x0005FC60
	private void olv()
	{
		ActiveCharacterInfo activeCharacterInfo = ((bl.kmv != null) ? bl.kmv.hjj : null);
		if (activeCharacterInfo != null)
		{
			this.dal(activeCharacterInfo);
			return;
		}
		MultiplayerSession.dhx(CharacterKind.Waifu, null);
	}

	// Token: 0x060013DF RID: 5087 RVA: 0x00061AA0 File Offset: 0x0005FCA0
	private void gzl()
	{
		if (!MultiplayerSession.iuw)
		{
			return;
		}
		this.dak();
		ClothingSet clothingSet = fh.cyk();
		this.ira = true;
		this.iqz = clothingSet;
		this.iqx = false;
		MultiplayerSession.dhw(clothingSet);
		MultiplayerSession.dib(fo.dai());
		MultiplayerSession.did(fi.kth);
		MultiplayerSession.die(bq.hlh);
	}

	// Token: 0x060013E0 RID: 5088 RVA: 0x000614D9 File Offset: 0x0005F6D9
	private void Awake()
	{
		if (fo.iqs != null && fo.iqs != this)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		fo.iqs = this;
	}

	// Token: 0x060013E1 RID: 5089 RVA: 0x00061AFC File Offset: 0x0005FCFC
	private void cqq()
	{
		if (this.iqy)
		{
			return;
		}
		if (bl.kmv == null)
		{
			return;
		}
		MultiplayerSession.iva += this.dac;
		MultiplayerSession.ivb += this.dag;
		MultiplayerSession.ivc += this.daf;
		bl.kmv.hjh += this.daj;
		GirlController.hpv += this.dah;
		this.iqy = true;
	}

	// Token: 0x060013E2 RID: 5090 RVA: 0x00061B84 File Offset: 0x0005FD84
	private void daj(ActiveCharacterInfo a)
	{
		if (!MultiplayerSession.iuw || a == null)
		{
			return;
		}
		if (!this.iqw)
		{
			bl bl = bl.kmv;
			int num = ((bl != null) ? bl.hjk : (-1));
			if (num > 0)
			{
				this.iqt = num;
				this.iqu = true;
				this.iqv = true;
				fq.dbg(string.Format(a.duj(), num));
			}
			else if (this.iqv)
			{
				this.iqv = false;
				fq.dbg(a.duk());
			}
		}
		this.dal(a);
	}

	// Token: 0x060013E3 RID: 5091 RVA: 0x0006107B File Offset: 0x0005F27B
	public static void cqr()
	{
		if (fo.iqs != null)
		{
			fo.iqs.iqx = true;
		}
	}

	// Token: 0x060013E4 RID: 5092 RVA: 0x00061C14 File Offset: 0x0005FE14
	private static bool dia(int a)
	{
		bl bl = bl.kmv;
		if (bl == null || a <= 0)
		{
			return false;
		}
		CatCharacterDefinition catCharacterDefinition = bl.xp(a);
		return catCharacterDefinition != null && catCharacterDefinition.unlockType == CatUnlockType.Workshop;
	}

	// Token: 0x060013E5 RID: 5093 RVA: 0x00061217 File Offset: 0x0005F417
	private void dac()
	{
		if (MultiplayerSession.iuw)
		{
			this.dad();
			return;
		}
		this.dae();
	}

	// Token: 0x04000A56 RID: 2646
	private static fo iqs;

	// Token: 0x04000A57 RID: 2647
	private int iqt;

	// Token: 0x04000A58 RID: 2648
	private bool iqu;

	// Token: 0x04000A59 RID: 2649
	private bool iqv;

	// Token: 0x04000A5A RID: 2650
	private bool iqw;

	// Token: 0x04000A5B RID: 2651
	private bool iqx;

	// Token: 0x04000A5C RID: 2652
	private bool iqy;

	// Token: 0x04000A5D RID: 2653
	private ClothingSet iqz;

	// Token: 0x04000A5E RID: 2654
	private bool ira;
}
