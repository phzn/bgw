using System;
using System.Collections;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.ResourceManagement.AsyncOperations;

// Token: 0x02000052 RID: 82
public class cg : MonoBehaviour
{
	// Token: 0x06000476 RID: 1142 RVA: 0x0001671D File Offset: 0x0001491D
	private void Awake()
	{
		if (cg.hqn != null && cg.hqn != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		cg.hqn = this;
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x0001671D File Offset: 0x0001491D
	private void dsd()
	{
		if (cg.hqn != null && cg.hqn != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		cg.hqn = this;
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x00016756 File Offset: 0x00014956
	public static string dec(StringTable a, string b)
	{
		return a.GetEntry(b).GetLocalizedString();
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00016764 File Offset: 0x00014964
	private void bmm()
	{
		this.bgo();
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x00016764 File Offset: 0x00014964
	private void lt()
	{
		this.bgo();
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x00016756 File Offset: 0x00014956
	public static string bgq(StringTable a, string b)
	{
		return a.GetEntry(b).GetLocalizedString();
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x0600047D RID: 1149 RVA: 0x0001676C File Offset: 0x0001496C
	public static cg koq
	{
		get
		{
			return cg.hqn;
		}
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x00016764 File Offset: 0x00014964
	private void Start()
	{
		this.bgo();
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x00016764 File Offset: 0x00014964
	private void nnj()
	{
		this.bgo();
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x00016756 File Offset: 0x00014956
	public static string clk(StringTable a, string b)
	{
		return a.GetEntry(b).GetLocalizedString();
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x0001671D File Offset: 0x0001491D
	private void bty()
	{
		if (cg.hqn != null && cg.hqn != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		cg.hqn = this;
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00016773 File Offset: 0x00014973
	public void bgo()
	{
		cg.isPlayerDataLoaded = false;
		base.StartCoroutine(this.bgp(null));
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00016764 File Offset: 0x00014964
	private void lsh()
	{
		this.bgo();
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x00016756 File Offset: 0x00014956
	public static string kog(StringTable a, string b)
	{
		return a.GetEntry(b).GetLocalizedString();
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x00016773 File Offset: 0x00014973
	public void ce()
	{
		cg.isPlayerDataLoaded = false;
		base.StartCoroutine(this.bgp(null));
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x06000486 RID: 1158 RVA: 0x00016789 File Offset: 0x00014989
	public static bool kop
	{
		get
		{
			return cg.isPlayerDataLoaded;
		}
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00016790 File Offset: 0x00014990
	private IEnumerator bgp(Action a = null)
	{
		AsyncOperationHandle<StringTable> tableAsync = LocalizationSettings.StringDatabase.GetTableAsync(a.rh(), null);
		yield return tableAsync;
		if (tableAsync.Status == AsyncOperationStatus.Succeeded)
		{
			StringTable result = tableAsync.Result;
			AchievementData[] array = bq.hlf.achievementDatas.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				array[i].name = cg.bgq(result, string.Format(a.wc(), array[i].achievement.ToString()));
				array[i].description = cg.bgq(result, string.Format(a.wd(), array[i].achievement.ToString()));
			}
			cg.isPlayerDataLoaded = true;
			if (a != null)
			{
				a();
			}
		}
		else
		{
			Debug.LogError(a.we() + tableAsync.OperationException.ToString());
		}
		yield break;
	}

	// Token: 0x04000262 RID: 610
	private static cg hqn;

	// Token: 0x04000263 RID: 611
	public static bool isPlayerDataLoaded;
}
