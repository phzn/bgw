using System;
using FMODUnity;
using UnityEngine;

// Token: 0x02000062 RID: 98
[Serializable]
public sealed class BgmTrack
{
	// Token: 0x040002D9 RID: 729
	public string id;

	// Token: 0x040002DA RID: 730
	public string displayName;

	// Token: 0x040002DB RID: 731
	public string durationLabel;

	// Token: 0x040002DC RID: 732
	public EventReference track;

	// Token: 0x040002DD RID: 733
	public Sprite albumArt;

	// Token: 0x040002DE RID: 734
	public bool requiresDlc;
}
