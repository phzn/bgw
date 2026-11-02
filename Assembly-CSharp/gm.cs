using System;
using Rewired;

// Token: 0x02000183 RID: 387
public interface gm : IControllerTemplate
{
	// Token: 0x17000287 RID: 647
	// (get) Token: 0x060019D0 RID: 6608
	IControllerTemplateAxis ldl { get; }

	// Token: 0x17000288 RID: 648
	// (get) Token: 0x060019D1 RID: 6609
	IControllerTemplateAxis ldm { get; }

	// Token: 0x17000289 RID: 649
	// (get) Token: 0x060019D2 RID: 6610
	IControllerTemplateAxis ldn { get; }
}
