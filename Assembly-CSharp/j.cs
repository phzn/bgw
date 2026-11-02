using System;
using System.Collections;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

// Token: 0x0200000F RID: 15
[RequireComponent(typeof(StudioEventEmitter))]
public class j : MonoBehaviour
{
	// Token: 0x060000AF RID: 175 RVA: 0x000052CE File Offset: 0x000034CE
	private IEnumerator rw(EventInstance a, float b)
	{
		float num;
		a.getVolume(out num);
		float num2 = 0f;
		while (num2 < b)
		{
			num2 += Time.unscaledDeltaTime;
			float num3 = Mathf.Lerp(num, 0f, num2 / b);
			a.setVolume(num3);
			yield return null;
		}
		a.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
		a.release();
		yield break;
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x000052E4 File Offset: 0x000034E4
	public void ru(float a = 0.5f)
	{
		if (!this.hfq)
		{
			return;
		}
		this.hfq = false;
		base.StartCoroutine(this.rw(this.kmb.EventInstance, a));
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000530F File Offset: 0x0000350F
	// (set) Token: 0x060000B6 RID: 182 RVA: 0x000053A1 File Offset: 0x000035A1
	public StudioEventEmitter kmb
	{
		get
		{
			if (this.hfr == null)
			{
				this.hfr = base.GetComponent<StudioEventEmitter>();
			}
			return this.hfr;
		}
		set
		{
			this.hfr = value;
		}
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00005334 File Offset: 0x00003534
	public void rt(float a = 0f)
	{
		if (this.hfq)
		{
			return;
		}
		this.hfq = true;
		this.kmb.Play();
		this.kmb.EventInstance.setVolume(1f);
		if (a > 0f)
		{
			base.StartCoroutine(this.rv(a));
		}
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x0000538B File Offset: 0x0000358B
	public IEnumerator rv(float a)
	{
		EventInstance eventInstance = this.kmb.EventInstance;
		float num;
		eventInstance.getVolume(out num);
		float num2 = 0f;
		while (num2 < a)
		{
			num2 += Time.unscaledDeltaTime;
			float num3 = Mathf.Lerp(0f, num, num2 / a);
			eventInstance.setVolume(num3);
			yield return null;
		}
		yield break;
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x000052E4 File Offset: 0x000034E4
	public void olb(float a = 0.5f)
	{
		if (!this.hfq)
		{
			return;
		}
		this.hfq = false;
		base.StartCoroutine(this.rw(this.kmb.EventInstance, a));
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x000052E4 File Offset: 0x000034E4
	public void bon(float a = 0.5f)
	{
		if (!this.hfq)
		{
			return;
		}
		this.hfq = false;
		base.StartCoroutine(this.rw(this.kmb.EventInstance, a));
	}

	// Token: 0x040000A9 RID: 169
	private bool hfq;

	// Token: 0x040000AA RID: 170
	private StudioEventEmitter hfr;
}
