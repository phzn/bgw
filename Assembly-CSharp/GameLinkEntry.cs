using System;
using UnityEngine;

// Token: 0x02000069 RID: 105
[Serializable]
public class GameLinkEntry : ISerializationCallbackReceiver
{
	// Token: 0x06000509 RID: 1289 RVA: 0x00005090 File Offset: 0x00003290
	void ISerializationCallbackReceiver.bim()
	{
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x0001A2A0 File Offset: 0x000184A0
	void ISerializationCallbackReceiver.bin()
	{
		if (this.isDlc)
		{
			this.category = GameLinkCategory.Dlc;
			this.isDlc = false;
		}
	}

	// Token: 0x040004BC RID: 1212
	public string gameId;

	// Token: 0x040004BD RID: 1213
	public string displayName;

	// Token: 0x040004BE RID: 1214
	public Sprite icon;

	// Token: 0x040004BF RID: 1215
	public string url;

	// Token: 0x040004C0 RID: 1216
	public uint steamAppId;

	// Token: 0x040004C1 RID: 1217
	public bool markAsNew = true;

	// Token: 0x040004C2 RID: 1218
	public bool enabled = true;

	// Token: 0x040004C3 RID: 1219
	public GameLinkCategory category;

	// Token: 0x040004C4 RID: 1220
	[SerializeField]
	[HideInInspector]
	private bool isDlc;
}
