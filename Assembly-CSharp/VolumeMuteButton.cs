using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020000AA RID: 170
public sealed class VolumeMuteButton : MonoBehaviour
{
	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x06000910 RID: 2320 RVA: 0x0003770A File Offset: 0x0003590A
	public bool kqt
	{
		get
		{
			return this.slider != null && Mathf.Approximately(this.slider.value, 0f);
		}
	}

	// Token: 0x1400000D RID: 13
	// (add) Token: 0x06000911 RID: 2321 RVA: 0x00037734 File Offset: 0x00035934
	// (remove) Token: 0x06000912 RID: 2322 RVA: 0x0003776C File Offset: 0x0003596C
	public event Action hzh;

	// Token: 0x06000913 RID: 2323 RVA: 0x000377A1 File Offset: 0x000359A1
	private void Awake()
	{
		this.hzg = PlayerPrefs.GetFloat(this.lastVolumePrefKey, this.defaultUnmuteVolume);
		if (this.hzg <= 0f)
		{
			this.hzg = this.defaultUnmuteVolume;
		}
	}

	// Token: 0x06000914 RID: 2324 RVA: 0x000377D4 File Offset: 0x000359D4
	private void OnEnable()
	{
		float @float = PlayerPrefs.GetFloat(this.lastVolumePrefKey, this.hzg);
		if (@float > 0f)
		{
			this.hzg = @float;
		}
		if (this.button != null)
		{
			this.button.onClick.AddListener(new UnityAction(this.cbu));
		}
		if (this.slider != null)
		{
			this.slider.onValueChanged.AddListener(new UnityAction<float>(this.cbx));
		}
		this.cby();
	}

	// Token: 0x06000915 RID: 2325 RVA: 0x0003785C File Offset: 0x00035A5C
	private void OnDisable()
	{
		if (this.button != null)
		{
			this.button.onClick.RemoveListener(new UnityAction(this.cbu));
		}
		if (this.slider != null)
		{
			this.slider.onValueChanged.RemoveListener(new UnityAction<float>(this.cbx));
		}
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x000378BD File Offset: 0x00035ABD
	public void cbu()
	{
		if (this.slider == null)
		{
			return;
		}
		bq.hlk = false;
		if (this.kqt)
		{
			this.cbw();
		}
		else
		{
			this.cbv();
		}
		Action action = this.hzh;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x000378FC File Offset: 0x00035AFC
	public void cbv()
	{
		if (this.slider == null)
		{
			return;
		}
		if (this.kqt)
		{
			return;
		}
		if (this.slider.value > 0f)
		{
			this.hzg = this.slider.value;
			PlayerPrefs.SetFloat(this.lastVolumePrefKey, this.hzg);
			PlayerPrefs.Save();
		}
		this.slider.value = 0f;
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x0003796C File Offset: 0x00035B6C
	public void cbw()
	{
		if (this.slider == null)
		{
			return;
		}
		if (!this.kqt)
		{
			return;
		}
		float num = ((this.hzg > 0f) ? this.hzg : this.defaultUnmuteVolume);
		this.slider.value = num;
	}

	// Token: 0x06000919 RID: 2329 RVA: 0x000379B9 File Offset: 0x00035BB9
	private void cbx(float a)
	{
		if (a > 0f)
		{
			this.hzg = a;
		}
		this.cby();
	}

	// Token: 0x0600091A RID: 2330 RVA: 0x000379D0 File Offset: 0x00035BD0
	private void cby()
	{
		if (this.iconImage == null)
		{
			return;
		}
		Sprite sprite = (this.kqt ? this.mutedSprite : this.unmutedSprite);
		if (sprite != null && this.iconImage.sprite != sprite)
		{
			this.iconImage.sprite = sprite;
		}
	}

	// Token: 0x04000792 RID: 1938
	[SerializeField]
	private Button button;

	// Token: 0x04000793 RID: 1939
	[SerializeField]
	private Slider slider;

	// Token: 0x04000794 RID: 1940
	[SerializeField]
	private Image iconImage;

	// Token: 0x04000795 RID: 1941
	[SerializeField]
	private Sprite unmutedSprite;

	// Token: 0x04000796 RID: 1942
	[SerializeField]
	private Sprite mutedSprite;

	// Token: 0x04000797 RID: 1943
	[SerializeField]
	private string lastVolumePrefKey = a.cov();

	// Token: 0x04000798 RID: 1944
	[Range(0f, 1f)]
	[SerializeField]
	private float defaultUnmuteVolume = 0.5f;

	// Token: 0x04000799 RID: 1945
	private float hzg;
}
