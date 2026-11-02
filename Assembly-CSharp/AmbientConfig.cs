using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000060 RID: 96
public class AmbientConfig : ScriptableObject
{
	// Token: 0x17000076 RID: 118
	// (get) Token: 0x06000501 RID: 1281 RVA: 0x00019FE2 File Offset: 0x000181E2
	public int kov
	{
		get
		{
			if (this.scenes == null)
			{
				return 0;
			}
			return this.scenes.Count;
		}
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x00019FFC File Offset: 0x000181FC
	public AmbientSceneEntry bij(AmbientScene a)
	{
		if (this.scenes == null)
		{
			return null;
		}
		for (int i = 0; i < this.scenes.Count; i++)
		{
			if (this.scenes[i] != null && this.scenes[i].scene == a)
			{
				return this.scenes[i];
			}
		}
		return null;
	}

	// Token: 0x040002B8 RID: 696
	public const string ResourcesPath = "AmbientConfig";

	// Token: 0x040002B9 RID: 697
	public const string BankName = "Ambient";

	// Token: 0x040002BA RID: 698
	public List<AmbientSceneEntry> scenes = new List<AmbientSceneEntry>();

	// Token: 0x040002BB RID: 699
	public Vector2 clearMinutes = new Vector2(15f, 40f);

	// Token: 0x040002BC RID: 700
	public float stormWarnSeconds = 60f;

	// Token: 0x040002BD RID: 701
	public Vector2 rainStageMinutes = new Vector2(3f, 8f);

	// Token: 0x040002BE RID: 702
	[Range(0f, 1f)]
	public float peakWeightWeak = 0.3f;

	// Token: 0x040002BF RID: 703
	[Range(0f, 1f)]
	public float peakWeightNormal = 0.4f;

	// Token: 0x040002C0 RID: 704
	[Range(0f, 1f)]
	public float peakWeightHeavy = 0.3f;

	// Token: 0x040002C1 RID: 705
	[Range(0f, 1f)]
	public float quickRiseChance = 0.5f;

	// Token: 0x040002C2 RID: 706
	public Vector2 quickStageSeconds = new Vector2(30f, 60f);

	// Token: 0x040002C3 RID: 707
	public float weatherRampSeconds = 25f;

	// Token: 0x040002C4 RID: 708
	public float stormRampSeconds = 20f;

	// Token: 0x040002C5 RID: 709
	public float heavyRainWindFloor = 0.7f;

	// Token: 0x040002C6 RID: 710
	public float stormWarnWindFloor = 0.4f;

	// Token: 0x040002C7 RID: 711
	public float birdsRampSeconds = 10f;

	// Token: 0x040002C8 RID: 712
	public float campfireEndHoldMinutes = 10f;

	// Token: 0x040002C9 RID: 713
	public float campfireReigniteSeconds = 20f;

	// Token: 0x040002CA RID: 714
	public Vector2 streamDriftMinutes = new Vector2(5f, 10f);

	// Token: 0x040002CB RID: 715
	public float streamDriftSeconds = 15f;

	// Token: 0x040002CC RID: 716
	public Vector2 windGustSeconds = new Vector2(20f, 60f);

	// Token: 0x040002CD RID: 717
	public float windRampSeconds = 8f;

	// Token: 0x040002CE RID: 718
	public float cityDawnHour = 3f;

	// Token: 0x040002CF RID: 719
	public float cityMorningHour = 9f;

	// Token: 0x040002D0 RID: 720
	public float cityAfternoonHour = 15f;

	// Token: 0x040002D1 RID: 721
	public float cityNightHour = 19f;

	// Token: 0x040002D2 RID: 722
	public Vector2 cityBusyPeakA = new Vector2(7f, 9f);

	// Token: 0x040002D3 RID: 723
	public Vector2 cityBusyPeakB = new Vector2(17f, 19f);

	// Token: 0x040002D4 RID: 724
	public float cityBusyRampSeconds = 60f;
}
