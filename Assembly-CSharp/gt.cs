using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Rewired;

// Token: 0x02000189 RID: 393
public sealed class gt : ControllerTemplate, gm, IControllerTemplate
{
	// Token: 0x17000383 RID: 899
	// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x0007BFB1 File Offset: 0x0007A1B1
	IControllerTemplateAxis gm.lnd
	{
		get
		{
			return base.GetElement<IControllerTemplateAxis>(0);
		}
	}

	// Token: 0x17000384 RID: 900
	// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x0007BFBA File Offset: 0x0007A1BA
	IControllerTemplateAxis gm.lne
	{
		get
		{
			return base.GetElement<IControllerTemplateAxis>(1);
		}
	}

	// Token: 0x17000385 RID: 901
	// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x0007BFC3 File Offset: 0x0007A1C3
	IControllerTemplateAxis gm.lnf
	{
		get
		{
			return base.GetElement<IControllerTemplateAxis>(2);
		}
	}

	// Token: 0x06001AD7 RID: 6871 RVA: 0x0007BF97 File Offset: 0x0007A197
	public gt(object a)
		: base(a)
	{
	}

	// Token: 0x04000E27 RID: 3623
	public static readonly Guid jnm = new Guid(a.emg());

	// Token: 0x04000E28 RID: 3624
	public const int jnn = 0;

	// Token: 0x04000E29 RID: 3625
	public const int jno = 1;

	// Token: 0x04000E2A RID: 3626
	public const int jnp = 2;
}
