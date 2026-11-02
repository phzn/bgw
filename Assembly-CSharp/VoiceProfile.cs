using System;
using FMODUnity;

// Token: 0x02000078 RID: 120
[Serializable]
public class VoiceProfile
{
	// Token: 0x040005A3 RID: 1443
	public string id;

	// Token: 0x040005A4 RID: 1444
	public string displayName;

	// Token: 0x040005A5 RID: 1445
	public string displayNameKey;

	// Token: 0x040005A6 RID: 1446
	public EventReference loopVoice;

	// Token: 0x040005A7 RID: 1447
	public EventReference endVoice;

	// Token: 0x040005A8 RID: 1448
	public EventReference talkVoice;
}
