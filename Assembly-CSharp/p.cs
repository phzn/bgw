using System;
using FMODUnity;
using Unity.Mathematics;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000019 RID: 25
public class p : k
{
	// Token: 0x060000FE RID: 254 RVA: 0x000061A0 File Offset: 0x000043A0
	public void bjn(bool a)
	{
		if (a)
		{
			base.rx();
			return;
		}
		AudioManager.klw.qw(this.unClickSoundEvent, float3.zero, 3168f);
	}

	// Token: 0x060000FF RID: 255 RVA: 0x000061CC File Offset: 0x000043CC
	public void tb(bool a)
	{
		if (a)
		{
			base.rx();
			return;
		}
		AudioManager.klw.qw(this.unClickSoundEvent, float3.zero, 1f);
	}

	// Token: 0x06000101 RID: 257 RVA: 0x000061F8 File Offset: 0x000043F8
	public override void Start()
	{
		base.Start();
		base.GetComponent<Toggle>().onValueChanged.AddListener(new UnityAction<bool>(this.tb));
	}

	// Token: 0x06000102 RID: 258 RVA: 0x0000621C File Offset: 0x0000441C
	public void iqe(bool a)
	{
		if (a)
		{
			base.rx();
			return;
		}
		AudioManager.klw.qw(this.unClickSoundEvent, float3.zero, 5799f);
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00006248 File Offset: 0x00004448
	public void nvi(bool a)
	{
		if (a)
		{
			base.rx();
			return;
		}
		AudioManager.klw.qw(this.unClickSoundEvent, float3.zero, -8261f);
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00006274 File Offset: 0x00004474
	public void kkh(bool a)
	{
		if (a)
		{
			base.rx();
			return;
		}
		AudioManager.klw.qw(this.unClickSoundEvent, float3.zero, 1878f);
	}

	// Token: 0x040000CC RID: 204
	public EventReference unClickSoundEvent;
}
