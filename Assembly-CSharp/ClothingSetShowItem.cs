using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000091 RID: 145
public class ClothingSetShowItem : MonoBehaviour
{
	// Token: 0x06000659 RID: 1625 RVA: 0x000230B4 File Offset: 0x000212B4
	public void bqv(Sprite a)
	{
		if (a == null)
		{
			this._imageIcon.color = new Color(1f, 1f, 1f, 0f);
			return;
		}
		this._imageIcon.color = new Color(1f, 1f, 1f, 1f);
		this._imageIcon.sprite = a;
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x0002311F File Offset: 0x0002131F
	public void bqw(bool a)
	{
		this._objNoHas.SetActive(a);
	}

	// Token: 0x04000657 RID: 1623
	[SerializeField]
	private Image _imageIcon;

	// Token: 0x04000658 RID: 1624
	[SerializeField]
	private GameObject _objNoHas;
}
