using System;
using UnityEngine;

namespace Rewired.Glyphs
{
	// Token: 0x020001C8 RID: 456
	[Serializable]
	public abstract class GlyphSet : ScriptableObject
	{
		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x00086396 File Offset: 0x00084596
		// (set) Token: 0x06001DD8 RID: 7640 RVA: 0x0008639E File Offset: 0x0008459E
		public string[] lsx
		{
			get
			{
				return this._baseKeys;
			}
			set
			{
				this._baseKeys = value;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001DD9 RID: 7641
		public abstract int lsy { get; }

		// Token: 0x06001DDA RID: 7642
		public abstract GlyphSet.EntryBase fcm(int a);

		// Token: 0x04000F54 RID: 3924
		[SerializeField]
		private string[] _baseKeys;

		// Token: 0x020001C9 RID: 457
		[Serializable]
		public abstract class EntryBase
		{
			// Token: 0x17000425 RID: 1061
			// (get) Token: 0x06001DDC RID: 7644 RVA: 0x000863A7 File Offset: 0x000845A7
			// (set) Token: 0x06001DDD RID: 7645 RVA: 0x000863AF File Offset: 0x000845AF
			public string lsv
			{
				get
				{
					return this._key;
				}
				set
				{
					this._key = value;
				}
			}

			// Token: 0x06001DDE RID: 7646
			public abstract object fcg();

			// Token: 0x04000F55 RID: 3925
			[SerializeField]
			private string _key;
		}

		// Token: 0x020001CA RID: 458
		[Serializable]
		public abstract class EntryBase<TValue> : GlyphSet.EntryBase
		{
			// Token: 0x17000426 RID: 1062
			// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x000863B8 File Offset: 0x000845B8
			// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x000863C0 File Offset: 0x000845C0
			public TValue lsw
			{
				get
				{
					return this._value;
				}
				set
				{
					this._value = value;
				}
			}

			// Token: 0x06001DE2 RID: 7650 RVA: 0x000863C9 File Offset: 0x000845C9
			public override object fcg()
			{
				return this._value;
			}

			// Token: 0x04000F56 RID: 3926
			[SerializeField]
			private TValue _value;
		}
	}
}
