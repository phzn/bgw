using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Token: 0x02000220 RID: 544
public interface kc : ICancelHandler, IEventSystemHandler
{
	// Token: 0x17000558 RID: 1368
	// (get) Token: 0x0600239F RID: 9119
	// (set) Token: 0x060023A0 RID: 9120
	Sprite mbn { get; set; }

	// Token: 0x17000559 RID: 1369
	// (get) Token: 0x060023A1 RID: 9121
	// (set) Token: 0x060023A2 RID: 9122
	Color mbo { get; set; }

	// Token: 0x1700055A RID: 1370
	// (get) Token: 0x060023A3 RID: 9123
	// (set) Token: 0x060023A4 RID: 9124
	string mbp { get; set; }

	// Token: 0x1700055B RID: 1371
	// (get) Token: 0x060023A5 RID: 9125
	// (set) Token: 0x060023A6 RID: 9126
	bool mbq { get; set; }

	// Token: 0x1700055C RID: 1372
	// (get) Token: 0x060023A7 RID: 9127
	// (set) Token: 0x060023A8 RID: 9128
	bool mbr { get; set; }

	// Token: 0x1700055D RID: 1373
	// (get) Token: 0x060023A9 RID: 9129
	// (set) Token: 0x060023AA RID: 9130
	bool mbs { get; set; }

	// Token: 0x1700055E RID: 1374
	// (get) Token: 0x060023AB RID: 9131
	// (set) Token: 0x060023AC RID: 9132
	bool mbt { get; set; }

	// Token: 0x14000059 RID: 89
	// (add) Token: 0x060023AD RID: 9133
	// (remove) Token: 0x060023AE RID: 9134
	event UnityAction mhr;
}
