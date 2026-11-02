using System;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200022B RID: 555
	[Serializable]
	public abstract class LanguageDataBase : ScriptableObject
	{
		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x0600242F RID: 9263 RVA: 0x0009A251 File Offset: 0x00098451
		public bool mds
		{
			get
			{
				return ReInput.localization.localizedStringProvider != null;
			}
		}

		// Token: 0x06002430 RID: 9264
		public abstract void gkj();

		// Token: 0x06002431 RID: 9265
		public abstract string gkk(string a);

		// Token: 0x06002432 RID: 9266
		public abstract bool gkl(string a);

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06002433 RID: 9267
		public abstract string mcb { get; }

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06002434 RID: 9268
		public abstract string mcc { get; }

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06002435 RID: 9269
		public abstract string mcd { get; }

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06002436 RID: 9270
		public abstract string mce { get; }

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06002437 RID: 9271
		public abstract string mcf { get; }

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06002438 RID: 9272
		public abstract string mcg { get; }

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06002439 RID: 9273
		public abstract string mch { get; }

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x0600243A RID: 9274
		public abstract string mci { get; }

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x0600243B RID: 9275
		public abstract string mcj { get; }

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x0600243C RID: 9276
		public abstract string mck { get; }

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x0600243D RID: 9277
		public abstract string mcl { get; }

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600243E RID: 9278
		public abstract string mcm { get; }

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600243F RID: 9279
		public abstract string mcn { get; }

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06002440 RID: 9280
		public abstract string mco { get; }

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06002441 RID: 9281
		public abstract string mcp { get; }

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06002442 RID: 9282
		public abstract string mcq { get; }

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06002443 RID: 9283
		public abstract string mcr { get; }

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06002444 RID: 9284
		public abstract string mcs { get; }

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06002445 RID: 9285
		public abstract string mct { get; }

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06002446 RID: 9286
		public abstract string mcu { get; }

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06002447 RID: 9287
		public abstract string mcv { get; }

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06002448 RID: 9288
		public abstract string mcw { get; }

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06002449 RID: 9289
		public abstract string mcx { get; }

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x0600244A RID: 9290
		public abstract string mcy { get; }

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x0600244B RID: 9291
		public abstract string mcz { get; }

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x0600244C RID: 9292
		public abstract string mda { get; }

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x0600244D RID: 9293
		public abstract string mdb { get; }

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x0600244E RID: 9294
		public abstract string mdc { get; }

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x0600244F RID: 9295
		public abstract string mdd { get; }

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06002450 RID: 9296
		public abstract string mde { get; }

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06002451 RID: 9297
		public abstract string mdf { get; }

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06002452 RID: 9298
		public abstract string mdg { get; }

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06002453 RID: 9299
		public abstract string mdh { get; }

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06002454 RID: 9300
		public abstract string mdi { get; }

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06002455 RID: 9301
		public abstract string mdj { get; }

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06002456 RID: 9302
		public abstract string mdk { get; }

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06002457 RID: 9303
		public abstract string mdl { get; }

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06002458 RID: 9304
		public abstract string mdm { get; }

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06002459 RID: 9305
		public abstract string mdn { get; }

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600245A RID: 9306
		public abstract string mdo { get; }

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x0600245B RID: 9307
		public abstract string mdp { get; }

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x0600245C RID: 9308
		public abstract string mdq { get; }

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x0600245D RID: 9309
		public abstract string mdr { get; }

		// Token: 0x0600245E RID: 9310
		public abstract string gmd(string a, string b, string c);

		// Token: 0x0600245F RID: 9311
		public abstract string gme(string a);

		// Token: 0x06002460 RID: 9312
		public abstract string gmf(string a);

		// Token: 0x06002461 RID: 9313
		public abstract string gmg(string a);

		// Token: 0x06002462 RID: 9314
		public abstract string gmh(string a);

		// Token: 0x06002463 RID: 9315
		public abstract string gmi(string a);

		// Token: 0x06002464 RID: 9316
		public abstract string gmj(string a);

		// Token: 0x06002465 RID: 9317
		public abstract string gmk(string a, bool b);

		// Token: 0x06002466 RID: 9318
		public abstract string gml(string a, string b);

		// Token: 0x06002467 RID: 9319
		public abstract string gmm(string a);

		// Token: 0x06002468 RID: 9320
		public abstract string gmn(string a);

		// Token: 0x06002469 RID: 9321
		public abstract string gmo(int a);

		// Token: 0x0600246A RID: 9322
		public abstract string gmp(Controller a);

		// Token: 0x0600246B RID: 9323
		public abstract string gmq(ActionElementMap a);

		// Token: 0x0600246C RID: 9324
		public abstract string gmr(Controller a, int b, AxisRange c);

		// Token: 0x0600246D RID: 9325
		public abstract string gms(KeyCode a, ModifierKeyFlags b);

		// Token: 0x0600246E RID: 9326
		public abstract string gmt(int a);

		// Token: 0x0600246F RID: 9327
		public abstract string gmu(int a, AxisRange b);

		// Token: 0x06002470 RID: 9328
		public abstract string gmv(int a);

		// Token: 0x06002471 RID: 9329
		public abstract string gmw(int a);

		// Token: 0x06002472 RID: 9330
		public abstract string gmx(ControllerType a, int b);

		// Token: 0x06002473 RID: 9331
		public abstract string gmy(ModifierKeyFlags a);
	}
}
