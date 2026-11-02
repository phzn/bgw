using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000063 RID: 99
[CreateAssetMenu(fileName = "BgmAlbumConfig", menuName = "BongoWaifu/BGM Album Config")]
public class BgmAlbumConfig : ScriptableObject
{
	// Token: 0x17000077 RID: 119
	// (get) Token: 0x06000505 RID: 1285 RVA: 0x0001A1DE File Offset: 0x000183DE
	public int kow
	{
		get
		{
			if (this.tracks == null)
			{
				return 0;
			}
			return this.tracks.Count;
		}
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x0001A1F5 File Offset: 0x000183F5
	public BgmTrack bil(int a)
	{
		if (this.tracks != null && a >= 0 && a < this.tracks.Count)
		{
			return this.tracks[a];
		}
		return null;
	}

	// Token: 0x040002DF RID: 735
	public const string ResourcesPath = "BgmAlbumConfig";

	// Token: 0x040002E0 RID: 736
	public List<BgmTrack> tracks = new List<BgmTrack>();

	// Token: 0x040002E1 RID: 737
	public int defaultIndex;

	// Token: 0x040002E2 RID: 738
	public uint dlcAppId = 4880200U;
}
