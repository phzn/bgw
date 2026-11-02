using System;

namespace Rewired.Glyphs
{
	// Token: 0x020001BC RID: 444
	public abstract class ControllerElementGlyph : ControllerElementGlyphBase
	{
		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x000856CA File Offset: 0x000838CA
		// (set) Token: 0x06001D76 RID: 7542 RVA: 0x000856D2 File Offset: 0x000838D2
		public ActionElementMap lsa
		{
			get
			{
				return this.juw;
			}
			set
			{
				this.juw = value;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x000856DB File Offset: 0x000838DB
		// (set) Token: 0x06001D78 RID: 7544 RVA: 0x000856E3 File Offset: 0x000838E3
		public ControllerElementIdentifier lsb
		{
			get
			{
				return this.jux;
			}
			set
			{
				this.jux = value;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x000856EC File Offset: 0x000838EC
		// (set) Token: 0x06001D7A RID: 7546 RVA: 0x000856F4 File Offset: 0x000838F4
		public AxisRange lsc
		{
			get
			{
				return this.juy;
			}
			set
			{
				this.juy = value;
			}
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x00085700 File Offset: 0x00083900
		protected override void Update()
		{
			base.Update();
			if (!ReInput.isReady)
			{
				return;
			}
			if (this.juw == null && this.lsb == null)
			{
				this.fao();
				return;
			}
			if (this.lsa != null)
			{
				this.fal(this.juw);
			}
			else if (this.lsb != null)
			{
				this.fan(this.jux, this.lsc);
			}
			this.fah();
		}

		// Token: 0x04000F34 RID: 3892
		[NonSerialized]
		private ActionElementMap juw;

		// Token: 0x04000F35 RID: 3893
		[NonSerialized]
		private ControllerElementIdentifier jux;

		// Token: 0x04000F36 RID: 3894
		[NonSerialized]
		private AxisRange juy;
	}
}
