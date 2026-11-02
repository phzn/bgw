using System;
using Rewired;
using Rewired.Glyphs.UnityUI;

// Token: 0x02000226 RID: 550
public class kf : km
{
	// Token: 0x17000561 RID: 1377
	// (get) Token: 0x060023D0 RID: 9168 RVA: 0x0009978B File Offset: 0x0009798B
	// (set) Token: 0x060023D1 RID: 9169 RVA: 0x00099793 File Offset: 0x00097993
	public UnityUIControllerElementGlyph kfw { get; set; }

	// Token: 0x17000562 RID: 1378
	// (get) Token: 0x060023D2 RID: 9170 RVA: 0x0009979C File Offset: 0x0009799C
	// (set) Token: 0x060023D3 RID: 9171 RVA: 0x000997A4 File Offset: 0x000979A4
	public int kfx { get; set; }

	// Token: 0x17000563 RID: 1379
	// (get) Token: 0x060023D4 RID: 9172 RVA: 0x000997AD File Offset: 0x000979AD
	// (set) Token: 0x060023D5 RID: 9173 RVA: 0x000997B5 File Offset: 0x000979B5
	public AxisRange mbz
	{
		get
		{
			return this.kfv;
		}
		set
		{
			this.kfv = value;
			if (this.kfw != null)
			{
				this.kfw.lsc = value;
			}
		}
	}

	// Token: 0x17000564 RID: 1380
	// (get) Token: 0x060023D6 RID: 9174 RVA: 0x000997D8 File Offset: 0x000979D8
	// (set) Token: 0x060023D7 RID: 9175 RVA: 0x000997E0 File Offset: 0x000979E0
	public int mca
	{
		get
		{
			return this.kfu;
		}
		set
		{
			this.kfu = value;
			if (this.kfw != null)
			{
				this.kfw.lsa = ReInput.mapping.GetActionElementMap(value);
			}
		}
	}

	// Token: 0x17000565 RID: 1381
	// (get) Token: 0x060023D8 RID: 9176 RVA: 0x0009980D File Offset: 0x00097A0D
	// (set) Token: 0x060023D9 RID: 9177 RVA: 0x00099815 File Offset: 0x00097A15
	public ControllerType kfy { get; set; }

	// Token: 0x17000566 RID: 1382
	// (get) Token: 0x060023DA RID: 9178 RVA: 0x0009981E File Offset: 0x00097A1E
	// (set) Token: 0x060023DB RID: 9179 RVA: 0x00099826 File Offset: 0x00097A26
	public int kfz { get; set; }

	// Token: 0x04001158 RID: 4440
	private int kfu;

	// Token: 0x04001159 RID: 4441
	private AxisRange kfv;
}
