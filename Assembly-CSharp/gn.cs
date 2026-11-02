using System;
using Rewired;

// Token: 0x02000184 RID: 388
public interface gn : IControllerTemplate
{
	// Token: 0x1700028A RID: 650
	// (get) Token: 0x060019D3 RID: 6611
	IControllerTemplateAxis ldo { get; }

	// Token: 0x1700028B RID: 651
	// (get) Token: 0x060019D4 RID: 6612
	IControllerTemplateAxis ldp { get; }

	// Token: 0x1700028C RID: 652
	// (get) Token: 0x060019D5 RID: 6613
	IControllerTemplateAxis ldq { get; }

	// Token: 0x1700028D RID: 653
	// (get) Token: 0x060019D6 RID: 6614
	IControllerTemplateAxis ldr { get; }

	// Token: 0x1700028E RID: 654
	// (get) Token: 0x060019D7 RID: 6615
	IControllerTemplateButton lds { get; }

	// Token: 0x1700028F RID: 655
	// (get) Token: 0x060019D8 RID: 6616
	IControllerTemplateButton ldt { get; }

	// Token: 0x17000290 RID: 656
	// (get) Token: 0x060019D9 RID: 6617
	IControllerTemplateButton ldu { get; }

	// Token: 0x17000291 RID: 657
	// (get) Token: 0x060019DA RID: 6618
	IControllerTemplateButton ldv { get; }

	// Token: 0x17000292 RID: 658
	// (get) Token: 0x060019DB RID: 6619
	IControllerTemplateButton ldw { get; }

	// Token: 0x17000293 RID: 659
	// (get) Token: 0x060019DC RID: 6620
	IControllerTemplateButton ldx { get; }

	// Token: 0x17000294 RID: 660
	// (get) Token: 0x060019DD RID: 6621
	IControllerTemplateButton ldy { get; }

	// Token: 0x17000295 RID: 661
	// (get) Token: 0x060019DE RID: 6622
	IControllerTemplateButton ldz { get; }

	// Token: 0x17000296 RID: 662
	// (get) Token: 0x060019DF RID: 6623
	IControllerTemplateButton lea { get; }

	// Token: 0x17000297 RID: 663
	// (get) Token: 0x060019E0 RID: 6624
	IControllerTemplateButton leb { get; }

	// Token: 0x17000298 RID: 664
	// (get) Token: 0x060019E1 RID: 6625
	IControllerTemplateButton lec { get; }

	// Token: 0x17000299 RID: 665
	// (get) Token: 0x060019E2 RID: 6626
	IControllerTemplateButton led { get; }

	// Token: 0x1700029A RID: 666
	// (get) Token: 0x060019E3 RID: 6627
	IControllerTemplateButton lee { get; }

	// Token: 0x1700029B RID: 667
	// (get) Token: 0x060019E4 RID: 6628
	IControllerTemplateButton lef { get; }

	// Token: 0x1700029C RID: 668
	// (get) Token: 0x060019E5 RID: 6629
	IControllerTemplateButton leg { get; }

	// Token: 0x1700029D RID: 669
	// (get) Token: 0x060019E6 RID: 6630
	IControllerTemplateButton leh { get; }

	// Token: 0x1700029E RID: 670
	// (get) Token: 0x060019E7 RID: 6631
	IControllerTemplateButton lei { get; }

	// Token: 0x1700029F RID: 671
	// (get) Token: 0x060019E8 RID: 6632
	IControllerTemplateButton lej { get; }

	// Token: 0x170002A0 RID: 672
	// (get) Token: 0x060019E9 RID: 6633
	IControllerTemplateButton lek { get; }

	// Token: 0x170002A1 RID: 673
	// (get) Token: 0x060019EA RID: 6634
	IControllerTemplateButton lel { get; }

	// Token: 0x170002A2 RID: 674
	// (get) Token: 0x060019EB RID: 6635
	IControllerTemplateButton lem { get; }

	// Token: 0x170002A3 RID: 675
	// (get) Token: 0x060019EC RID: 6636
	IControllerTemplateButton len { get; }

	// Token: 0x170002A4 RID: 676
	// (get) Token: 0x060019ED RID: 6637
	IControllerTemplateButton leo { get; }

	// Token: 0x170002A5 RID: 677
	// (get) Token: 0x060019EE RID: 6638
	IControllerTemplateButton lep { get; }

	// Token: 0x170002A6 RID: 678
	// (get) Token: 0x060019EF RID: 6639
	IControllerTemplateButton leq { get; }

	// Token: 0x170002A7 RID: 679
	// (get) Token: 0x060019F0 RID: 6640
	IControllerTemplateButton ler { get; }

	// Token: 0x170002A8 RID: 680
	// (get) Token: 0x060019F1 RID: 6641
	IControllerTemplateButton les { get; }

	// Token: 0x170002A9 RID: 681
	// (get) Token: 0x060019F2 RID: 6642
	IControllerTemplateButton let { get; }

	// Token: 0x170002AA RID: 682
	// (get) Token: 0x060019F3 RID: 6643
	IControllerTemplateButton leu { get; }

	// Token: 0x170002AB RID: 683
	// (get) Token: 0x060019F4 RID: 6644
	IControllerTemplateButton lev { get; }

	// Token: 0x170002AC RID: 684
	// (get) Token: 0x060019F5 RID: 6645
	IControllerTemplateButton lew { get; }

	// Token: 0x170002AD RID: 685
	// (get) Token: 0x060019F6 RID: 6646
	IControllerTemplateButton lex { get; }

	// Token: 0x170002AE RID: 686
	// (get) Token: 0x060019F7 RID: 6647
	IControllerTemplateHat ley { get; }

	// Token: 0x170002AF RID: 687
	// (get) Token: 0x060019F8 RID: 6648
	IControllerTemplateHat lez { get; }

	// Token: 0x170002B0 RID: 688
	// (get) Token: 0x060019F9 RID: 6649
	IControllerTemplateThrottle lfa { get; }

	// Token: 0x170002B1 RID: 689
	// (get) Token: 0x060019FA RID: 6650
	IControllerTemplateThrottle lfb { get; }

	// Token: 0x170002B2 RID: 690
	// (get) Token: 0x060019FB RID: 6651
	IControllerTemplateStick6D lfc { get; }
}
