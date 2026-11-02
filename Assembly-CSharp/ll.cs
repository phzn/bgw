using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000260 RID: 608
public static class ll
{
	// Token: 0x060025FC RID: 9724 RVA: 0x0009E284 File Offset: 0x0009C484
	public static IEnumerator guz(CanvasGroup a, float b, float c)
	{
		float num = 0f;
		float alpha = a.alpha;
		while (num < c)
		{
			num += Time.deltaTime;
			a.alpha = Mathf.Lerp(alpha, b, num / c);
			yield return new WaitForEndOfFrame();
		}
		a.alpha = b;
		yield break;
	}

	// Token: 0x060025FD RID: 9725 RVA: 0x0009E2A1 File Offset: 0x0009C4A1
	public static IEnumerator gva(CanvasGroup a, float b, float c)
	{
		float num = 0f;
		float alpha = a.alpha;
		while (num < c)
		{
			num += Time.deltaTime;
			a.alpha = Mathf.Lerp(alpha, b, num / c);
			yield return new WaitForEndOfFrame();
		}
		a.alpha = b;
		yield break;
	}
}
