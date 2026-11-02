using System;
using FMODUnity;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000018 RID: 24
public class o : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Token: 0x060000F6 RID: 246 RVA: 0x0000613E File Offset: 0x0000433E
	public void ta(float a)
	{
		AudioManager.klw.qw(this.clickSoundEvent, float3.zero, 1f);
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x00006160 File Offset: 0x00004360
	private void mzn()
	{
		base.GetComponent<Slider>().onValueChanged.AddListener(new UnityAction<float>(this.ta));
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00006160 File Offset: 0x00004360
	private void Start()
	{
		base.GetComponent<Slider>().onValueChanged.AddListener(new UnityAction<float>(this.ta));
	}

	// Token: 0x060000FA RID: 250 RVA: 0x0000617E File Offset: 0x0000437E
	public void OnPointerEnter(PointerEventData eventData)
	{
		AudioManager.klw.qw(this.hoverSoundEvent, float3.zero, 1f);
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00006160 File Offset: 0x00004360
	private void fro()
	{
		base.GetComponent<Slider>().onValueChanged.AddListener(new UnityAction<float>(this.ta));
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00005090 File Offset: 0x00003290
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00006160 File Offset: 0x00004360
	private void hyo()
	{
		base.GetComponent<Slider>().onValueChanged.AddListener(new UnityAction<float>(this.ta));
	}

	// Token: 0x040000CA RID: 202
	public EventReference clickSoundEvent;

	// Token: 0x040000CB RID: 203
	public EventReference hoverSoundEvent;
}
