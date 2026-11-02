using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200001E RID: 30
public class OpenURLButton : MonoBehaviour
{
	// Token: 0x060001AC RID: 428 RVA: 0x000092D3 File Offset: 0x000074D3
	private void Start()
	{
		this._button.onClick.AddListener(new UnityAction(this.vb));
	}

	// Token: 0x060001AD RID: 429 RVA: 0x000092F1 File Offset: 0x000074F1
	private void OnDestroy()
	{
		this._button.onClick.RemoveListener(new UnityAction(this.vb));
	}

	// Token: 0x060001AE RID: 430 RVA: 0x0000930F File Offset: 0x0000750F
	public void vb()
	{
		bq.hlk = false;
		if (string.IsNullOrEmpty(this._url))
		{
			Debug.LogWarning(a.jm());
			return;
		}
		Application.OpenURL(this._url);
	}

	// Token: 0x040000FB RID: 251
	[SerializeField]
	private Button _button;

	// Token: 0x040000FC RID: 252
	[SerializeField]
	private string _url;
}
