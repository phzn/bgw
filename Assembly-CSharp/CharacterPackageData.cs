using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};

// Token: 0x020000C9 RID: 201
[Serializable]
public class CharacterPackageData
{
	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0003D103 File Offset: 0x0003B303
	public bool krk
	{
		get
		{
			return string.Equals(this.type, a.cws(), StringComparison.OrdinalIgnoreCase);
		}
	}

	// Token: 0x06000A75 RID: 2677 RVA: 0x0003D118 File Offset: 0x0003B318
	public bool chg(out string a)
	{
		if (string.IsNullOrEmpty(this.name))
		{
			a = a.cwt();
			return false;
		}
		if (this.krk)
		{
			if (this.images == null)
			{
				a = a.cwu();
				return false;
			}
			if (string.IsNullOrEmpty(this.images.idle))
			{
				a = a.cwv();
				return false;
			}
			if (string.IsNullOrEmpty(this.images.click_left))
			{
				a = a.cww();
				return false;
			}
			if (string.IsNullOrEmpty(this.images.click_right))
			{
				a = a.cwx();
				return false;
			}
		}
		else
		{
			if (string.IsNullOrEmpty(this.spine_file))
			{
				a = a.cwy();
				return false;
			}
			if (string.IsNullOrEmpty(this.atlas_file))
			{
				a = a.cwz();
				return false;
			}
			if (this.animations == null)
			{
				a = a.cxa();
				return false;
			}
			if (string.IsNullOrEmpty(this.animations.idle))
			{
				a = a.cxb();
				return false;
			}
			if (string.IsNullOrEmpty(this.animations.click_left))
			{
				a = a.cxc();
				return false;
			}
			if (string.IsNullOrEmpty(this.animations.click_right))
			{
				a = a.cxd();
				return false;
			}
		}
		a = null;
		return true;
	}

	// Token: 0x04000845 RID: 2117
	public string type = a.cxe();

	// Token: 0x04000846 RID: 2118
	public string id;

	// Token: 0x04000847 RID: 2119
	public string name;

	// Token: 0x04000848 RID: 2120
	public string author;

	// Token: 0x04000849 RID: 2121
	public int version;

	// Token: 0x0400084A RID: 2122
	public string spine_file;

	// Token: 0x0400084B RID: 2123
	public string atlas_file;

	// Token: 0x0400084C RID: 2124
	public CharacterPackageData.CharacterAnimations animations;

	// Token: 0x0400084D RID: 2125
	public float[] position;

	// Token: 0x0400084E RID: 2126
	public float[] scale;

	// Token: 0x0400084F RID: 2127
	public float hand_mix_out_time = 0.3f;

	// Token: 0x04000850 RID: 2128
	public float click_display_duration = 0.1f;

	// Token: 0x04000851 RID: 2129
	public CharacterPackageData.CharacterImages images;

	// Token: 0x020000CA RID: 202
	[Serializable]
	public class CharacterAnimations
	{
		// Token: 0x04000852 RID: 2130
		public string idle = a.iv();

		// Token: 0x04000853 RID: 2131
		public string click_left = a.iw();

		// Token: 0x04000854 RID: 2132
		public string click_right = a.ix();
	}

	// Token: 0x020000CB RID: 203
	[Serializable]
	public class CharacterImages
	{
		// Token: 0x04000855 RID: 2133
		public string idle = a.cwp();

		// Token: 0x04000856 RID: 2134
		public string click_left = a.cwq();

		// Token: 0x04000857 RID: 2135
		public string click_right = a.cwr();
	}
}
