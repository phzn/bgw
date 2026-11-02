using System;
using FMODUnity;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000012 RID: 18
public class k : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler
{
	// Token: 0x060000C3 RID: 195 RVA: 0x00005090 File Offset: 0x00003290
	public virtual void Start()
	{
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x0000555B File Offset: 0x0000375B
	public virtual void SetActive(bool isCanPlay)
	{
		this.hfs = isCanPlay;
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00005564 File Offset: 0x00003764
	public virtual void rx()
	{
		if (!this.hfs)
		{
			return;
		}
		AudioManager.klw.qw(this.clickSoundEvent, float3.zero, 1f);
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x0000558F File Offset: 0x0000378F
	public virtual void OnPointerEnter(PointerEventData eventData)
	{
		if (!this.hfs)
		{
			return;
		}
		AudioManager.klw.qw(this.hoverSoundEvent, float3.zero, 1f);
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x000055BA File Offset: 0x000037BA
	public virtual void OnPointerExit(PointerEventData eventData)
	{
		bool flag = this.hfs;
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x0000558F File Offset: 0x0000378F
	public void OnSelect(BaseEventData eventData)
	{
		if (!this.hfs)
		{
			return;
		}
		AudioManager.klw.qw(this.hoverSoundEvent, float3.zero, 1f);
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x000055BA File Offset: 0x000037BA
	public void OnDeselect(BaseEventData eventData)
	{
		bool flag = this.hfs;
	}

	// Token: 0x040000B8 RID: 184
	public EventReference clickSoundEvent;

	// Token: 0x040000B9 RID: 185
	public EventReference hoverSoundEvent;

	// Token: 0x040000BA RID: 186
	private bool hfs = true;
}
