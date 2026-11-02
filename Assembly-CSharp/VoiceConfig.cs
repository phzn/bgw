using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000079 RID: 121
[CreateAssetMenu(fileName = "VoiceConfig", menuName = "BongoWaifu/Voice Config")]
public class VoiceConfig : ScriptableObject
{
	// Token: 0x17000085 RID: 133
	// (get) Token: 0x0600055F RID: 1375 RVA: 0x0001DEA9 File Offset: 0x0001C0A9
	public int kpk
	{
		get
		{
			if (this.profiles == null)
			{
				return 0;
			}
			return this.profiles.Count;
		}
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x0001DEC0 File Offset: 0x0001C0C0
	public VoiceProfile bld(int a)
	{
		if (this.profiles == null || this.profiles.Count == 0)
		{
			return null;
		}
		if (a < 0 || a >= this.profiles.Count)
		{
			return null;
		}
		return this.profiles[a];
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x0001DEFC File Offset: 0x0001C0FC
	public VoiceProfile ble(int a)
	{
		VoiceProfile voiceProfile = this.bld(a);
		if (voiceProfile != null)
		{
			return voiceProfile;
		}
		return this.bld(this.defaultIndex);
	}

	// Token: 0x040005A9 RID: 1449
	public List<VoiceProfile> profiles = new List<VoiceProfile>();

	// Token: 0x040005AA RID: 1450
	public int defaultIndex;
}
