using System;
using UnityEngine;

// Token: 0x020000D3 RID: 211
public sealed class SpinnerRotate : MonoBehaviour
{
	// Token: 0x06000B21 RID: 2849 RVA: 0x00042401 File Offset: 0x00040601
	private void Update()
	{
		base.transform.Rotate(0f, 0f, this.speed * Time.deltaTime);
	}

	// Token: 0x04000887 RID: 2183
	[SerializeField]
	private float speed = -360f;
}
