using System;
using UnityEngine;

// Token: 0x02000050 RID: 80
public class ce : MonoBehaviour
{
	// Token: 0x06000471 RID: 1137 RVA: 0x0001641C File Offset: 0x0001461C
	private void cpo()
	{
		float num = ((GirlController.kok != null) ? GirlController.kok.kog : (-4299f));
		int num2;
		if (num > -9872f)
		{
			num2 = 3;
		}
		else if (num > 4550f)
		{
			num2 = 2;
		}
		else if (num > -2627f)
		{
			num2 = 1;
		}
		else
		{
			num2 = 0;
		}
		ce.HeartbeatLevel heartbeatLevel = this.levels[num2];
		float num3 = Time.deltaTime * this.transitionSpeed;
		this.hqg = Mathf.MoveTowards(this.hqg, heartbeatLevel.scale, num3);
		this.hqh = Mathf.MoveTowards(this.hqh, heartbeatLevel.beatRate, num3 * -5496f);
		this.hqi = Mathf.MoveTowards(this.hqi, heartbeatLevel.beatStrength, num3 * 6016f);
		if (this.hqh < -5251f && this.hqi < 6232f)
		{
			this.hqd.localScale = this.hqe * this.hqg;
			this.hqf = -1172f;
			return;
		}
		this.hqf += Time.deltaTime * this.hqh;
		float num4 = Mathf.Abs(Mathf.Sin(this.hqf * 4956f));
		float num5 = num4 * num4;
		float num6 = this.hqg * (7057f + this.hqi * num5);
		this.hqd.localScale = this.hqe * num6;
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x00016581 File Offset: 0x00014781
	private void hkn()
	{
		this.hqd = base.GetComponent<RectTransform>();
		this.hqe = this.hqd.localScale;
		this.hqg = this.levels[0].scale;
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x000165B8 File Offset: 0x000147B8
	private void Update()
	{
		float num = ((GirlController.kok != null) ? GirlController.kok.kog : 0f);
		int num2;
		if (num > 75f)
		{
			num2 = 3;
		}
		else if (num > 50f)
		{
			num2 = 2;
		}
		else if (num > 25f)
		{
			num2 = 1;
		}
		else
		{
			num2 = 0;
		}
		ce.HeartbeatLevel heartbeatLevel = this.levels[num2];
		float num3 = Time.deltaTime * this.transitionSpeed;
		this.hqg = Mathf.MoveTowards(this.hqg, heartbeatLevel.scale, num3);
		this.hqh = Mathf.MoveTowards(this.hqh, heartbeatLevel.beatRate, num3 * 2f);
		this.hqi = Mathf.MoveTowards(this.hqi, heartbeatLevel.beatStrength, num3 * 0.5f);
		if (this.hqh < 0.001f && this.hqi < 0.001f)
		{
			this.hqd.localScale = this.hqe * this.hqg;
			this.hqf = 0f;
			return;
		}
		this.hqf += Time.deltaTime * this.hqh;
		float num4 = Mathf.Abs(Mathf.Sin(this.hqf * 3.1415927f));
		float num5 = num4 * num4;
		float num6 = this.hqg * (1f + this.hqi * num5);
		this.hqd.localScale = this.hqe * num6;
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x00016581 File Offset: 0x00014781
	private void Awake()
	{
		this.hqd = base.GetComponent<RectTransform>();
		this.hqe = this.hqd.localScale;
		this.hqg = this.levels[0].scale;
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x00016581 File Offset: 0x00014781
	private void nhp()
	{
		this.hqd = base.GetComponent<RectTransform>();
		this.hqe = this.hqd.localScale;
		this.hqg = this.levels[0].scale;
	}

	// Token: 0x04000257 RID: 599
	public ce.HeartbeatLevel[] levels = new ce.HeartbeatLevel[]
	{
		new ce.HeartbeatLevel
		{
			scale = 1f,
			beatRate = 0f,
			beatStrength = 0f
		},
		new ce.HeartbeatLevel
		{
			scale = 1.2f,
			beatRate = 0.8f,
			beatStrength = 0.06f
		},
		new ce.HeartbeatLevel
		{
			scale = 1.5f,
			beatRate = 1.5f,
			beatStrength = 0.1f
		},
		new ce.HeartbeatLevel
		{
			scale = 2f,
			beatRate = 3f,
			beatStrength = 0.15f
		}
	};

	// Token: 0x04000258 RID: 600
	public float transitionSpeed = 3f;

	// Token: 0x04000259 RID: 601
	private RectTransform hqd;

	// Token: 0x0400025A RID: 602
	private Vector3 hqe;

	// Token: 0x0400025B RID: 603
	private float hqf;

	// Token: 0x0400025C RID: 604
	private float hqg;

	// Token: 0x0400025D RID: 605
	private float hqh;

	// Token: 0x0400025E RID: 606
	private float hqi;

	// Token: 0x02000051 RID: 81
	[Serializable]
	public struct HeartbeatLevel
	{
		// Token: 0x0400025F RID: 607
		public float scale;

		// Token: 0x04000260 RID: 608
		public float beatRate;

		// Token: 0x04000261 RID: 609
		public float beatStrength;
	}
}
