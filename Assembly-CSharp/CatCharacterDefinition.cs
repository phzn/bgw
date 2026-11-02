using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Spine.Unity;
using UnityEngine;

// Token: 0x02000066 RID: 102
[CreateAssetMenu(fileName = "NewCatCharacter", menuName = "BongoWaifu/Cat Character Definition")]
public class CatCharacterDefinition : ScriptableObject
{
	// Token: 0x040002EA RID: 746
	public string characterId;

	// Token: 0x040002EB RID: 747
	public string displayNameKey;

	// Token: 0x040002EC RID: 748
	public string displayName;

	// Token: 0x040002ED RID: 749
	public Sprite previewIcon;

	// Token: 0x040002EE RID: 750
	public CatDisplayMode displayMode;

	// Token: 0x040002EF RID: 751
	public Vector2 characterPosition = Vector2.zero;

	// Token: 0x040002F0 RID: 752
	public Vector2 characterScale = Vector2.one;

	// Token: 0x040002F1 RID: 753
	public SkeletonDataAsset skeletonDataAsset;

	// Token: 0x040002F2 RID: 754
	public string idleAnim = a.iv();

	// Token: 0x040002F3 RID: 755
	public string clickLeftAnim = a.iw();

	// Token: 0x040002F4 RID: 756
	public string clickRightAnim = a.ix();

	// Token: 0x040002F5 RID: 757
	public float handMixOutTime = 0.3f;

	// Token: 0x040002F6 RID: 758
	public Sprite idleSprite;

	// Token: 0x040002F7 RID: 759
	public Sprite clickLeftSprite;

	// Token: 0x040002F8 RID: 760
	public Sprite clickRightSprite;

	// Token: 0x040002F9 RID: 761
	public float clickDisplayDuration = 0.1f;

	// Token: 0x040002FA RID: 762
	public CatUnlockType unlockType;

	// Token: 0x040002FB RID: 763
	public uint dlcAppId;
}
