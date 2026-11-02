using System;
using UnityEngine;

// Token: 0x02000027 RID: 39
[DisallowMultipleComponent]
public sealed class bf : MonoBehaviour
{
	// Token: 0x06000229 RID: 553 RVA: 0x0000B085 File Offset: 0x00009285
	private void mhz(uint a)
	{
		if (a == 28U)
		{
			this.vv();
		}
	}

	// Token: 0x0600022A RID: 554 RVA: 0x0000B092 File Offset: 0x00009292
	private void Awake()
	{
		this.hio = base.transform.localPosition;
		this.hip = true;
		bj.hja += this.vu;
	}

	// Token: 0x0600022B RID: 555 RVA: 0x0000B0BD File Offset: 0x000092BD
	private void vu(uint a)
	{
		if (a == 4716380U)
		{
			this.vv();
		}
	}

	// Token: 0x0600022C RID: 556 RVA: 0x0000B0D0 File Offset: 0x000092D0
	public void vv()
	{
		if (!this.hip)
		{
			return;
		}
		if (!bj.wm(4716380U))
		{
			this.vw();
			return;
		}
		if (bq.hlf == null || bq.hlf.playerSaveData == null)
		{
			this.vw();
			return;
		}
		int num = bq.knp;
		if (num != 600 && num != 601)
		{
			this.vw();
			return;
		}
		int num2 = bq.knj;
		if (num2 == 0)
		{
			this.vw();
			return;
		}
		SpineSkinData spineSkinData = ((bq.hle != null) ? bq.hle.bjy(num2, CLOTHE_TYPE.Bottom) : null);
		if (spineSkinData == null || !spineSkinData.overrideDickBottomPos)
		{
			this.vw();
			return;
		}
		base.transform.localPosition = spineSkinData.dickBottomOverrideLocalPos;
	}

	// Token: 0x0600022D RID: 557 RVA: 0x0000B18B File Offset: 0x0000938B
	private void kei()
	{
		bj.hja -= this.vu;
	}

	// Token: 0x0600022E RID: 558 RVA: 0x0000B19E File Offset: 0x0000939E
	private void fap(uint a)
	{
		if (a == 74U)
		{
			this.vv();
		}
	}

	// Token: 0x0600022F RID: 559 RVA: 0x0000B18B File Offset: 0x0000938B
	private void bqp()
	{
		bj.hja -= this.vu;
	}

	// Token: 0x06000230 RID: 560 RVA: 0x0000B092 File Offset: 0x00009292
	private void fpg()
	{
		this.hio = base.transform.localPosition;
		this.hip = true;
		bj.hja += this.vu;
	}

	// Token: 0x06000232 RID: 562 RVA: 0x0000B1AC File Offset: 0x000093AC
	public void nqg()
	{
		if (!this.hip)
		{
			return;
		}
		if (!bj.wm(4294967234U))
		{
			this.vw();
			return;
		}
		if (bq.hlf == null || bq.hlf.playerSaveData == null)
		{
			this.vw();
			return;
		}
		int num = bq.knp;
		if (num != -25 && num != 59)
		{
			this.vw();
			return;
		}
		int num2 = bq.knj;
		if (num2 == 0)
		{
			this.vw();
			return;
		}
		SpineSkinData spineSkinData = ((bq.hle != null) ? bq.hle.bjy(num2, CLOTHE_TYPE.Bottom) : null);
		if (spineSkinData == null || !spineSkinData.overrideDickBottomPos)
		{
			this.vw();
			return;
		}
		base.transform.localPosition = spineSkinData.dickBottomOverrideLocalPos;
	}

	// Token: 0x06000233 RID: 563 RVA: 0x0000B25E File Offset: 0x0000945E
	private void jba(uint a)
	{
		if (a == 60U)
		{
			this.vv();
		}
	}

	// Token: 0x06000234 RID: 564 RVA: 0x0000B18B File Offset: 0x0000938B
	private void OnDestroy()
	{
		bj.hja -= this.vu;
	}

	// Token: 0x06000235 RID: 565 RVA: 0x0000B18B File Offset: 0x0000938B
	private void dve()
	{
		bj.hja -= this.vu;
	}

	// Token: 0x06000236 RID: 566 RVA: 0x0000B26B File Offset: 0x0000946B
	private void fxn(uint a)
	{
		if (a == 4294967256U)
		{
			this.vv();
		}
	}

	// Token: 0x06000237 RID: 567 RVA: 0x0000B18B File Offset: 0x0000938B
	private void ggb()
	{
		bj.hja -= this.vu;
	}

	// Token: 0x06000238 RID: 568 RVA: 0x0000B092 File Offset: 0x00009292
	private void jdi()
	{
		this.hio = base.transform.localPosition;
		this.hip = true;
		bj.hja += this.vu;
	}

	// Token: 0x06000239 RID: 569 RVA: 0x0000B092 File Offset: 0x00009292
	private void jpt()
	{
		this.hio = base.transform.localPosition;
		this.hip = true;
		bj.hja += this.vu;
	}

	// Token: 0x0600023A RID: 570 RVA: 0x0000B278 File Offset: 0x00009478
	private void vw()
	{
		base.transform.localPosition = this.hio;
	}

	// Token: 0x0600023B RID: 571 RVA: 0x0000B28C File Offset: 0x0000948C
	public void lcb()
	{
		if (!this.hip)
		{
			return;
		}
		if (!bj.wm(43U))
		{
			this.vw();
			return;
		}
		if (bq.hlf == null || bq.hlf.playerSaveData == null)
		{
			this.vw();
			return;
		}
		int num = bq.knp;
		if (num != 43 && num != 46)
		{
			this.vw();
			return;
		}
		int num2 = bq.knj;
		if (num2 == 0)
		{
			this.vw();
			return;
		}
		SpineSkinData spineSkinData = ((bq.hle != null) ? bq.hle.bjy(num2, CLOTHE_TYPE.Bottom) : null);
		if (spineSkinData == null || !spineSkinData.overrideDickBottomPos)
		{
			this.vw();
			return;
		}
		base.transform.localPosition = spineSkinData.dickBottomOverrideLocalPos;
	}

	// Token: 0x0600023C RID: 572 RVA: 0x0000B092 File Offset: 0x00009292
	private void gxe()
	{
		this.hio = base.transform.localPosition;
		this.hip = true;
		bj.hja += this.vu;
	}

	// Token: 0x04000124 RID: 292
	private Vector3 hio;

	// Token: 0x04000125 RID: 293
	private bool hip;
}
