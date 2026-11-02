using System;
using UnityEngine;

// Token: 0x020001C4 RID: 452
public abstract class ib : MonoBehaviour
{
	// Token: 0x1700041C RID: 1052
	// (get) Token: 0x06001DB8 RID: 7608
	// (set) Token: 0x06001DB9 RID: 7609
	protected abstract string lso { get; set; }

	// Token: 0x06001DBA RID: 7610
	public abstract void fbl(string a);

	// Token: 0x06001DBB RID: 7611
	public abstract void fbm(object a);

	// Token: 0x06001DBC RID: 7612 RVA: 0x00085DEE File Offset: 0x00083FEE
	public virtual void fbn()
	{
		this.fbo(ib.TypeFlags.All);
	}

	// Token: 0x06001DBD RID: 7613
	protected abstract void fbo(ib.TypeFlags a);

	// Token: 0x020001C5 RID: 453
	[Flags]
	protected enum TypeFlags
	{
		// Token: 0x04000F4A RID: 3914
		None = 0,
		// Token: 0x04000F4B RID: 3915
		Glyph = 1,
		// Token: 0x04000F4C RID: 3916
		Text = 2,
		// Token: 0x04000F4D RID: 3917
		All = -1
	}
}
