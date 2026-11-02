using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace BongoWaifu.Multiplayer
{
	// Token: 0x0200010D RID: 269
	public sealed class MpFloatingText : MonoBehaviour
	{
		// Token: 0x06001370 RID: 4976 RVA: 0x0005F738 File Offset: 0x0005D938
		public void cyr(RectTransform a, Text b, CanvasGroup c)
		{
			this.ipq = a;
			this.ipr = b;
			this.ips = c;
			base.gameObject.SetActive(false);
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x0005F75B File Offset: 0x0005D95B
		public bool ktk
		{
			get
			{
				return !base.gameObject.activeSelf;
			}
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x0005F76C File Offset: 0x0005D96C
		public void cyt(Vector2 a, Color b, string c, float d, float e, int f)
		{
			if (this.ipq == null || this.ipr == null || this.ips == null)
			{
				return;
			}
			this.ipr.fontSize = f;
			this.ipr.text = c;
			this.ipr.color = new Color(b.r, b.g, b.b, 1f);
			this.ips.alpha = 1f;
			this.ipq.position = new Vector3(a.x, a.y, 0f);
			base.gameObject.SetActive(true);
			if (this.ipt != null)
			{
				base.StopCoroutine(this.ipt);
			}
			this.ipt = base.StartCoroutine(this.cyu(a, d, Mathf.Max(0.01f, e)));
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0005F856 File Offset: 0x0005DA56
		private IEnumerator cyu(Vector2 a, float b, float c)
		{
			float num = 0f;
			while (num < c)
			{
				num += Time.deltaTime;
				float num2 = Mathf.Clamp01(num / c);
				this.ipq.position = new Vector3(a.x, a.y + b * num2, 0f);
				this.ips.alpha = 1f - num2;
				yield return null;
			}
			this.ipt = null;
			base.gameObject.SetActive(false);
			yield break;
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x0005F87C File Offset: 0x0005DA7C
		private void OnDisable()
		{
			if (this.ipt != null)
			{
				base.StopCoroutine(this.ipt);
				this.ipt = null;
			}
			if (base.gameObject.activeSelf)
			{
				base.gameObject.SetActive(false);
				if (this.ips != null)
				{
					this.ips.alpha = 0f;
				}
			}
		}

		// Token: 0x04000A2D RID: 2605
		private RectTransform ipq;

		// Token: 0x04000A2E RID: 2606
		private Text ipr;

		// Token: 0x04000A2F RID: 2607
		private CanvasGroup ips;

		// Token: 0x04000A30 RID: 2608
		private Coroutine ipt;
	}
}
