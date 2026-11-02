using System;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020000DD RID: 221
public sealed class WorkshopSizePreview : MonoBehaviour
{
	// Token: 0x06000B7B RID: 2939 RVA: 0x00043CBC File Offset: 0x00041EBC
	private void Start()
	{
		WorkshopSizePreview.ej ej = new WorkshopSizePreview.ej();
		ej.igd = PlayerPrefs.GetInt(a.blg(), 0);
		ej.ige = PlayerPrefs.GetInt(a.blh(), 2);
		dn.bxn(this.dropdownCharacterSize, this.characterSizeController, ej.igd, out this.igf, new Func<int, string, string>(ej.cmd));
		dn.bxn(this.dropdownUISize, this.uiSizeController, ej.ige, out this.igg, new Func<int, string, string>(ej.cme));
		this.characterSizeController.bds(ej.igd);
		this.uiSizeController.bds(ej.ige);
		this.dropdownCharacterSize.onValueChanged.AddListener(new UnityAction<int>(this.cmf));
		this.dropdownUISize.onValueChanged.AddListener(new UnityAction<int>(this.cmg));
	}

	// Token: 0x06000B7C RID: 2940 RVA: 0x00043D9F File Offset: 0x00041F9F
	private void cmf(int a)
	{
		if (this.igf == null || a < 0 || a >= this.igf.Length)
		{
			return;
		}
		this.characterSizeController.bds(this.igf[a]);
	}

	// Token: 0x06000B7D RID: 2941 RVA: 0x00043DCC File Offset: 0x00041FCC
	private void cmg(int a)
	{
		if (this.igg == null || a < 0 || a >= this.igg.Length)
		{
			return;
		}
		this.uiSizeController.bds(this.igg[a]);
	}

	// Token: 0x040008D8 RID: 2264
	[SerializeField]
	private bz characterSizeController;

	// Token: 0x040008D9 RID: 2265
	[SerializeField]
	private TMP_Dropdown dropdownCharacterSize;

	// Token: 0x040008DA RID: 2266
	[SerializeField]
	private bz uiSizeController;

	// Token: 0x040008DB RID: 2267
	[SerializeField]
	private TMP_Dropdown dropdownUISize;

	// Token: 0x040008DC RID: 2268
	private int[] igf;

	// Token: 0x040008DD RID: 2269
	private int[] igg;

	// Token: 0x020000DE RID: 222
	[CompilerGenerated]
	private sealed class ej
	{
		// Token: 0x06000B7F RID: 2943 RVA: 0x00043DF9 File Offset: 0x00041FF9
		internal string ixx(int a, string b)
		{
			if (a != this.ige)
			{
				return b;
			}
			return b + a.dlp();
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00043E11 File Offset: 0x00042011
		internal string lto(int a, string b)
		{
			if (a != this.ige)
			{
				return b;
			}
			return b + a.dlq();
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00043E29 File Offset: 0x00042029
		internal string jak(int a, string b)
		{
			if (a != this.ige)
			{
				return b;
			}
			return b + a.dlr();
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00043E41 File Offset: 0x00042041
		internal string cmd(int a, string b)
		{
			if (a != this.igd)
			{
				return b;
			}
			return b + a.dls();
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00043E59 File Offset: 0x00042059
		internal string niv(int a, string b)
		{
			if (a != this.ige)
			{
				return b;
			}
			return b + a.dlt();
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00043E71 File Offset: 0x00042071
		internal string cme(int a, string b)
		{
			if (a != this.ige)
			{
				return b;
			}
			return b + a.dls();
		}

		// Token: 0x040008DE RID: 2270
		public int igd;

		// Token: 0x040008DF RID: 2271
		public int ige;
	}
}
