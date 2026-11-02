using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200006A RID: 106
[CreateAssetMenu(fileName = "GameLinkConfig", menuName = "BongoWaifu/Game Link Config")]
public class GameLinkConfig : ScriptableObject
{
	// Token: 0x040004C5 RID: 1221
	public List<GameLinkEntry> games = new List<GameLinkEntry>();
}
