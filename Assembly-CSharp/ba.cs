using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000022 RID: 34
public class ba : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler, IPointerMoveHandler
{
	// Token: 0x060001C6 RID: 454 RVA: 0x00009408 File Offset: 0x00007608
	public void OnSelect(BaseEventData eventData)
	{
		if (bq.hlm)
		{
			return;
		}
		Action action = this.onOpen;
		if (action != null)
		{
			action();
		}
		if (this.onOpenEvent != null)
		{
			this.onOpenEvent.Invoke();
		}
		this.hhz = true;
		if (this.objSelecting != null)
		{
			this.objSelecting.SetActive(true);
		}
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00009462 File Offset: 0x00007662
	public void dtp()
	{
		this.hhz = false;
		if (this.objSelecting != null)
		{
			this.objSelecting.SetActive(false);
		}
		if (this.kmn != null)
		{
			this.kmn.raycastTarget = false;
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000949F File Offset: 0x0000769F
	public bool kmo
	{
		get
		{
			if (bq.hlm)
			{
				return this.hhz;
			}
			return EventSystem.current.currentSelectedGameObject == base.gameObject;
		}
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00009462 File Offset: 0x00007662
	public void Start()
	{
		this.hhz = false;
		if (this.objSelecting != null)
		{
			this.objSelecting.SetActive(false);
		}
		if (this.kmn != null)
		{
			this.kmn.raycastTarget = false;
		}
	}

	// Token: 0x060001CA RID: 458 RVA: 0x000094C4 File Offset: 0x000076C4
	public void kde()
	{
		if (!base.gameObject.activeInHierarchy)
		{
			return;
		}
		if (this.kmn != null)
		{
			if (!this.isShowOnKeyboard && bq.hlm)
			{
				this.kmn.color = Color.clear;
			}
			else if (this.hhz)
			{
				this.hhy += Time.unscaledDeltaTime * 9126f;
				this.kmn.color = Color.Lerp(this.hhw, this.hhx, Mathf.PingPong(this.hhy, 2958f));
			}
		}
		bool flag = this.kmo;
		if (this.objSelecting != null && flag != this.hia)
		{
			this.objSelecting.SetActive(flag);
			this.hia = flag;
		}
		if (this.hhz && this.onSelectEvent != null)
		{
			this.onSelectEvent.Invoke();
		}
		this.vf();
	}

	// Token: 0x060001CB RID: 459 RVA: 0x000095AC File Offset: 0x000077AC
	public void OnPointerExit(PointerEventData eventData)
	{
		Action action = this.onClose;
		if (action != null)
		{
			action();
		}
		if (this.onCloseEvent != null)
		{
			this.onCloseEvent.Invoke();
		}
		this.hhz = false;
		if (this.objSelecting != null)
		{
			this.objSelecting.SetActive(false);
		}
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00009600 File Offset: 0x00007800
	public void ecs()
	{
		this.hib = true;
		this.hhz = false;
		this.hia = false;
		if (this.objSelecting != null)
		{
			this.objSelecting.SetActive(false);
		}
		if (this.onCloseEvent != null)
		{
			this.onCloseEvent.Invoke();
		}
	}

	// Token: 0x060001CD RID: 461 RVA: 0x00009650 File Offset: 0x00007850
	public void OnEnable()
	{
		this.hib = true;
		this.hhz = false;
		this.hia = false;
		if (this.objSelecting != null)
		{
			this.objSelecting.SetActive(false);
		}
		if (this.onCloseEvent != null)
		{
			this.onCloseEvent.Invoke();
		}
	}

	// Token: 0x060001CE RID: 462 RVA: 0x000096A0 File Offset: 0x000078A0
	public void OnDeselect(BaseEventData eventData)
	{
		if (bq.hlm)
		{
			return;
		}
		Action action = this.onClose;
		if (action != null)
		{
			action();
		}
		if (this.onCloseEvent != null)
		{
			this.onCloseEvent.Invoke();
		}
		this.hhz = false;
		if (this.objSelecting != null)
		{
			this.objSelecting.SetActive(false);
		}
	}

	// Token: 0x060001CF RID: 463 RVA: 0x000096FC File Offset: 0x000078FC
	public void lfc()
	{
		if (!base.gameObject.activeInHierarchy)
		{
			return;
		}
		if (this.kmn != null)
		{
			if (!this.isShowOnKeyboard && bq.hlm)
			{
				this.kmn.color = Color.clear;
			}
			else if (this.hhz)
			{
				this.hhy += Time.unscaledDeltaTime * 2592f;
				this.kmn.color = Color.Lerp(this.hhw, this.hhx, Mathf.PingPong(this.hhy, -453f));
			}
		}
		bool flag = this.kmo;
		if (this.objSelecting != null && flag != this.hia)
		{
			this.objSelecting.SetActive(flag);
			this.hia = flag;
		}
		if (this.hhz && this.onSelectEvent != null)
		{
			this.onSelectEvent.Invoke();
		}
		this.vf();
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060001D0 RID: 464 RVA: 0x000097E4 File Offset: 0x000079E4
	// (set) Token: 0x060001DA RID: 474 RVA: 0x00009C0A File Offset: 0x00007E0A
	public Image kmn
	{
		get
		{
			if (this.objSelecting == null)
			{
				return null;
			}
			if (this.hhv == null)
			{
				this.hhv = this.objSelecting.GetComponent<Image>();
				if (this.kmn != null)
				{
					this.hhw = this.kmn.color;
					this.hhx = this.kmn.color;
					this.hhx.a = this.hhx.a * 0.3f;
				}
			}
			return this.hhv;
		}
		set
		{
			this.hhv = value;
		}
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x0000986A File Offset: 0x00007A6A
	public void vf()
	{
		if (this.hib)
		{
			this.hib = false;
			if (!this.hhz)
			{
				if (this.onCloseEvent != null)
				{
					this.onCloseEvent.Invoke();
					return;
				}
			}
			else if (this.onOpenEvent != null)
			{
				this.onOpenEvent.Invoke();
			}
		}
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x000098C0 File Offset: 0x00007AC0
	public void bnq()
	{
		if (!base.gameObject.activeInHierarchy)
		{
			return;
		}
		if (this.kmn != null)
		{
			if (!this.isShowOnKeyboard && bq.hlm)
			{
				this.kmn.color = Color.clear;
			}
			else if (this.hhz)
			{
				this.hhy += Time.unscaledDeltaTime * -1226f;
				this.kmn.color = Color.Lerp(this.hhw, this.hhx, Mathf.PingPong(this.hhy, -3653f));
			}
		}
		bool flag = this.kmo;
		if (this.objSelecting != null && flag != this.hia)
		{
			this.objSelecting.SetActive(flag);
			this.hia = flag;
		}
		if (this.hhz && this.onSelectEvent != null)
		{
			this.onSelectEvent.Invoke();
		}
		this.vf();
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x000099A8 File Offset: 0x00007BA8
	public void SetActive(bool isActive)
	{
		if (this.kmn != null && this.kmn.enabled != isActive)
		{
			this.kmn.enabled = isActive;
		}
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x000099D4 File Offset: 0x00007BD4
	public void Update()
	{
		if (!base.gameObject.activeInHierarchy)
		{
			return;
		}
		if (this.kmn != null)
		{
			if (!this.isShowOnKeyboard && bq.hlm)
			{
				this.kmn.color = Color.clear;
			}
			else if (this.hhz)
			{
				this.hhy += Time.unscaledDeltaTime * 3f;
				this.kmn.color = Color.Lerp(this.hhw, this.hhx, Mathf.PingPong(this.hhy, 1f));
			}
		}
		bool flag = this.kmo;
		if (this.objSelecting != null && flag != this.hia)
		{
			this.objSelecting.SetActive(flag);
			this.hia = flag;
		}
		if (this.hhz && this.onSelectEvent != null)
		{
			this.onSelectEvent.Invoke();
		}
		this.vf();
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x00009ABC File Offset: 0x00007CBC
	public void OnPointerEnter(PointerEventData eventData)
	{
		Action action = this.onOpen;
		if (action != null)
		{
			action();
		}
		if (this.onOpenEvent != null)
		{
			this.onOpenEvent.Invoke();
		}
		this.hhz = true;
		if (this.objSelecting != null)
		{
			this.objSelecting.SetActive(true);
		}
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x00009B10 File Offset: 0x00007D10
	public void hkd()
	{
		this.hib = true;
		this.hhz = false;
		this.hia = false;
		if (this.objSelecting != null)
		{
			this.objSelecting.SetActive(false);
		}
		if (this.onCloseEvent != null)
		{
			this.onCloseEvent.Invoke();
		}
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x00009B60 File Offset: 0x00007D60
	public void gkv()
	{
		this.hib = true;
		this.hhz = false;
		this.hia = false;
		if (this.objSelecting != null)
		{
			this.objSelecting.SetActive(false);
		}
		if (this.onCloseEvent != null)
		{
			this.onCloseEvent.Invoke();
		}
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x00009BB0 File Offset: 0x00007DB0
	void IPointerMoveHandler.vg(PointerEventData a)
	{
		if (!this.hhz)
		{
			this.hhz = true;
			Action action = this.onOpen;
			if (action != null)
			{
				action();
			}
			if (this.onOpenEvent != null)
			{
				this.onOpenEvent.Invoke();
			}
			if (this.objSelecting != null)
			{
				this.objSelecting.SetActive(true);
			}
		}
	}

	// Token: 0x060001DB RID: 475 RVA: 0x000099A8 File Offset: 0x00007BA8
	public void fjq(bool isActive)
	{
		if (this.kmn != null && this.kmn.enabled != isActive)
		{
			this.kmn.enabled = isActive;
		}
	}

	// Token: 0x060001DC RID: 476 RVA: 0x0000986A File Offset: 0x00007A6A
	public void bqm()
	{
		if (this.hib)
		{
			this.hib = false;
			if (!this.hhz)
			{
				if (this.onCloseEvent != null)
				{
					this.onCloseEvent.Invoke();
					return;
				}
			}
			else if (this.onOpenEvent != null)
			{
				this.onOpenEvent.Invoke();
			}
		}
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00009C14 File Offset: 0x00007E14
	public void bbv()
	{
		if (!base.gameObject.activeInHierarchy)
		{
			return;
		}
		if (this.kmn != null)
		{
			if (!this.isShowOnKeyboard && bq.hlm)
			{
				this.kmn.color = Color.clear;
			}
			else if (this.hhz)
			{
				this.hhy += Time.unscaledDeltaTime * 2241f;
				this.kmn.color = Color.Lerp(this.hhw, this.hhx, Mathf.PingPong(this.hhy, 5142f));
			}
		}
		bool flag = this.kmo;
		if (this.objSelecting != null && flag != this.hia)
		{
			this.objSelecting.SetActive(flag);
			this.hia = flag;
		}
		if (this.hhz && this.onSelectEvent != null)
		{
			this.onSelectEvent.Invoke();
		}
		this.vf();
	}

	// Token: 0x060001DE RID: 478 RVA: 0x000099A8 File Offset: 0x00007BA8
	public void kf(bool isActive)
	{
		if (this.kmn != null && this.kmn.enabled != isActive)
		{
			this.kmn.enabled = isActive;
		}
	}

	// Token: 0x060001DF RID: 479 RVA: 0x000099A8 File Offset: 0x00007BA8
	public void cun(bool isActive)
	{
		if (this.kmn != null && this.kmn.enabled != isActive)
		{
			this.kmn.enabled = isActive;
		}
	}

	// Token: 0x04000101 RID: 257
	public bool isShowOnKeyboard = true;

	// Token: 0x04000102 RID: 258
	public GameObject objSelecting;

	// Token: 0x04000103 RID: 259
	public UnityEvent onOpenEvent;

	// Token: 0x04000104 RID: 260
	public UnityEvent onCloseEvent;

	// Token: 0x04000105 RID: 261
	public UnityEvent onSelectEvent;

	// Token: 0x04000106 RID: 262
	public Action onOpen;

	// Token: 0x04000107 RID: 263
	public Action onClose;

	// Token: 0x04000108 RID: 264
	private Image hhv;

	// Token: 0x04000109 RID: 265
	private Color hhw;

	// Token: 0x0400010A RID: 266
	private Color hhx;

	// Token: 0x0400010B RID: 267
	private float hhy;

	// Token: 0x0400010C RID: 268
	private bool hhz;

	// Token: 0x0400010D RID: 269
	private bool hia;

	// Token: 0x0400010E RID: 270
	private bool hib = true;
}
