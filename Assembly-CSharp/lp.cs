using System;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Kirurobo;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000266 RID: 614
public class lp : MonoBehaviour
{
	// Token: 0x06002687 RID: 9863 RVA: 0x000A21C4 File Offset: 0x000A03C4
	private void gwz()
	{
		FilePanel.Settings settings = default(FilePanel.Settings);
		settings.filters = new FilePanel.Filter[]
		{
			new FilePanel.Filter(a.fal(), new string[] { a.dcv() }),
			new FilePanel.Filter(a.fdr(), new string[]
			{
				a.dma(),
				a.dmb(),
				a.fak(),
				a.fds(),
				a.fdt(),
				a.fdu()
			}),
			new FilePanel.Filter(a.fdv(), new string[]
			{
				a.fdw(),
				a.fdx(),
				a.fdy(),
				a.fdz()
			})
		};
		settings.title = a.fea();
		settings.initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
		this.messageText.text = a.tk();
		FilePanel.OpenFilePanel(settings, new Action<string[]>(this.gxc));
	}

	// Token: 0x06002688 RID: 9864 RVA: 0x00005090 File Offset: 0x00003290
	private void bfo()
	{
	}

	// Token: 0x06002689 RID: 9865 RVA: 0x00005090 File Offset: 0x00003290
	private void Update()
	{
	}

	// Token: 0x0600268A RID: 9866 RVA: 0x000A22B4 File Offset: 0x000A04B4
	private void cgo()
	{
		FilePanel.Settings settings = default(FilePanel.Settings);
		settings.filters = new FilePanel.Filter[]
		{
			new FilePanel.Filter(a.feb(), new string[]
			{
				a.fec(),
				a.fed(),
				a.fee(),
				a.fef(),
				a.feg(),
				a.feh()
			}),
			new FilePanel.Filter(a.fei(), new string[]
			{
				a.fej(),
				a.fek(),
				a.fel(),
				a.fem()
			}),
			new FilePanel.Filter(a.fen(), new string[] { a.feo() })
		};
		settings.flags = FilePanel.Flag.AllowMultipleSelection;
		settings.title = a.fep();
		settings.initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		this.messageText.text = a.feq();
		FilePanel.OpenFilePanel(settings, new Action<string[]>(this.gxd));
	}

	// Token: 0x0600268B RID: 9867 RVA: 0x000A23AC File Offset: 0x000A05AC
	private void gxb()
	{
		FilePanel.Settings settings = default(FilePanel.Settings);
		settings.filters = new FilePanel.Filter[]
		{
			new FilePanel.Filter(a.fer(), new string[]
			{
				a.fdw(),
				a.fes()
			}),
			new FilePanel.Filter(a.fdr(), new string[]
			{
				a.dma(),
				a.dmb(),
				a.fak(),
				a.fds(),
				a.fdt(),
				a.fdu()
			}),
			new FilePanel.Filter(a.fal(), new string[] { a.dcv() })
		};
		settings.title = a.fet();
		settings.initialFile = a.fap();
		this.messageText.text = a.tk();
		FilePanel.SaveFilePanel(settings, new Action<string[]>(this.gxe));
	}

	// Token: 0x0600268C RID: 9868 RVA: 0x00005090 File Offset: 0x00003290
	private void iox()
	{
	}

	// Token: 0x0600268D RID: 9869 RVA: 0x000A248C File Offset: 0x000A068C
	private void gxa()
	{
		FilePanel.Settings settings = default(FilePanel.Settings);
		settings.filters = new FilePanel.Filter[]
		{
			new FilePanel.Filter(a.fdr(), new string[]
			{
				a.dma(),
				a.dmb(),
				a.fak(),
				a.fds(),
				a.fdt(),
				a.fdu()
			}),
			new FilePanel.Filter(a.fdv(), new string[]
			{
				a.fdw(),
				a.fdx(),
				a.fdy(),
				a.fdz()
			}),
			new FilePanel.Filter(a.fal(), new string[] { a.dcv() })
		};
		settings.flags = FilePanel.Flag.AllowMultipleSelection;
		settings.title = a.feu();
		settings.initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		this.messageText.text = a.tk();
		FilePanel.OpenFilePanel(settings, new Action<string[]>(this.gxd));
	}

	// Token: 0x0600268E RID: 9870 RVA: 0x000A2582 File Offset: 0x000A0782
	[CompilerGenerated]
	private void gxc(string[] a)
	{
		this.messageText.text = a.fev() + string.Join(a.bfx(), a);
	}

	// Token: 0x06002690 RID: 9872 RVA: 0x000A25A4 File Offset: 0x000A07A4
	private void mzk()
	{
		this.openFileButton.onClick.AddListener(new UnityAction(this.gwz));
		this.openMultipleFilesButton.onClick.AddListener(new UnityAction(this.gxa));
		this.saveFileButton.onClick.AddListener(new UnityAction(this.gxb));
		this.messageText.text = a.few();
	}

	// Token: 0x06002691 RID: 9873 RVA: 0x000A2618 File Offset: 0x000A0818
	private void Start()
	{
		this.openFileButton.onClick.AddListener(new UnityAction(this.gwz));
		this.openMultipleFilesButton.onClick.AddListener(new UnityAction(this.gxa));
		this.saveFileButton.onClick.AddListener(new UnityAction(this.gxb));
		this.messageText.text = a.fex();
	}

	// Token: 0x06002692 RID: 9874 RVA: 0x000A268C File Offset: 0x000A088C
	private void oue()
	{
		FilePanel.Settings settings = default(FilePanel.Settings);
		settings.filters = new FilePanel.Filter[]
		{
			new FilePanel.Filter(a.fey(), new string[] { a.fez() }),
			new FilePanel.Filter(a.ffa(), new string[]
			{
				a.ffb(),
				a.ffc(),
				a.ffd(),
				a.ffe(),
				a.fff(),
				a.ffg()
			}),
			new FilePanel.Filter(a.ffh(), new string[]
			{
				a.ffi(),
				a.ffj(),
				a.ffk(),
				a.ffl()
			})
		};
		settings.title = a.ffm();
		settings.initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonAdminTools);
		this.messageText.text = a.ffn();
		FilePanel.OpenFilePanel(settings, new Action<string[]>(this.gxc));
	}

	// Token: 0x06002693 RID: 9875 RVA: 0x00005090 File Offset: 0x00003290
	private void eie()
	{
	}

	// Token: 0x06002694 RID: 9876 RVA: 0x000A277C File Offset: 0x000A097C
	private void ub()
	{
		FilePanel.Settings settings = default(FilePanel.Settings);
		settings.filters = new FilePanel.Filter[]
		{
			new FilePanel.Filter(a.ffo(), new string[]
			{
				a.ffp(),
				a.ffq(),
				a.ffr(),
				a.ffs(),
				a.fft(),
				a.ffu()
			}),
			new FilePanel.Filter(a.ffv(), new string[]
			{
				a.ffw(),
				a.ffx(),
				a.ffy(),
				a.ffz()
			}),
			new FilePanel.Filter(a.fga(), new string[] { a.fgb() })
		};
		settings.flags = FilePanel.Flag.AllowMultipleSelection;
		settings.title = a.fgc();
		settings.initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		this.messageText.text = a.fgd();
		FilePanel.OpenFilePanel(settings, new Action<string[]>(this.gxd));
	}

	// Token: 0x06002695 RID: 9877 RVA: 0x00005090 File Offset: 0x00003290
	private void faa()
	{
	}

	// Token: 0x06002696 RID: 9878 RVA: 0x000A2872 File Offset: 0x000A0A72
	[CompilerGenerated]
	private void gxe(string[] a)
	{
		this.messageText.text = a.fge() + string.Join(a.bfx(), a);
	}

	// Token: 0x06002697 RID: 9879 RVA: 0x000A2894 File Offset: 0x000A0A94
	private void diw()
	{
		FilePanel.Settings settings = default(FilePanel.Settings);
		settings.filters = new FilePanel.Filter[]
		{
			new FilePanel.Filter(a.fgf(), new string[]
			{
				a.fgg(),
				a.fgh()
			}),
			new FilePanel.Filter(a.fgi(), new string[]
			{
				a.fgj(),
				a.fgk(),
				a.fgl(),
				a.fgm(),
				a.fgn(),
				a.fgo()
			}),
			new FilePanel.Filter(a.fgp(), new string[] { a.fgq() })
		};
		settings.title = a.fgr();
		settings.initialFile = a.fgs();
		this.messageText.text = a.fgt();
		FilePanel.SaveFilePanel(settings, new Action<string[]>(this.gxe));
	}

	// Token: 0x06002698 RID: 9880 RVA: 0x000A2974 File Offset: 0x000A0B74
	private void cpi()
	{
		FilePanel.Settings settings = default(FilePanel.Settings);
		settings.filters = new FilePanel.Filter[]
		{
			new FilePanel.Filter(a.fgu(), new string[]
			{
				a.fgv(),
				a.fgw()
			}),
			new FilePanel.Filter(a.fgx(), new string[]
			{
				a.fgy(),
				a.fgz(),
				a.fha(),
				a.fhb(),
				a.fhc(),
				a.fhd()
			}),
			new FilePanel.Filter(a.fhe(), new string[] { a.fhf() })
		};
		settings.title = a.fhg();
		settings.initialFile = a.fhh();
		this.messageText.text = a.fhi();
		FilePanel.SaveFilePanel(settings, new Action<string[]>(this.gxe));
	}

	// Token: 0x06002699 RID: 9881 RVA: 0x000A2A54 File Offset: 0x000A0C54
	private void nhc()
	{
		this.openFileButton.onClick.AddListener(new UnityAction(this.gwz));
		this.openMultipleFilesButton.onClick.AddListener(new UnityAction(this.gxa));
		this.saveFileButton.onClick.AddListener(new UnityAction(this.gxb));
		this.messageText.text = a.fhj();
	}

	// Token: 0x0600269A RID: 9882 RVA: 0x000A2AC8 File Offset: 0x000A0CC8
	private void non()
	{
		FilePanel.Settings settings = default(FilePanel.Settings);
		settings.filters = new FilePanel.Filter[]
		{
			new FilePanel.Filter(a.fhk(), new string[]
			{
				a.fhl(),
				a.fhm()
			}),
			new FilePanel.Filter(a.fhn(), new string[]
			{
				a.fho(),
				a.fhp(),
				a.fhq(),
				a.fhr(),
				a.fhs(),
				a.fht()
			}),
			new FilePanel.Filter(a.fhu(), new string[] { a.fhv() })
		};
		settings.title = a.fhw();
		settings.initialFile = a.fhx();
		this.messageText.text = a.fhy();
		FilePanel.SaveFilePanel(settings, new Action<string[]>(this.gxe));
	}

	// Token: 0x0600269B RID: 9883 RVA: 0x000A2BA8 File Offset: 0x000A0DA8
	private void fwk()
	{
		FilePanel.Settings settings = default(FilePanel.Settings);
		settings.filters = new FilePanel.Filter[]
		{
			new FilePanel.Filter(a.fhz(), new string[]
			{
				a.fia(),
				a.fib()
			}),
			new FilePanel.Filter(a.fic(), new string[]
			{
				a.fid(),
				a.fie(),
				a.fif(),
				a.fig(),
				a.fih(),
				a.fii()
			}),
			new FilePanel.Filter(a.fij(), new string[] { a.fik() })
		};
		settings.title = a.fil();
		settings.initialFile = a.fim();
		this.messageText.text = a.fin();
		FilePanel.SaveFilePanel(settings, new Action<string[]>(this.gxe));
	}

	// Token: 0x0600269C RID: 9884 RVA: 0x000A2C85 File Offset: 0x000A0E85
	[CompilerGenerated]
	private void gxd(string[] a)
	{
		this.messageText.text = a.fio() + string.Join(a.bfx(), a);
	}

	// Token: 0x040012B6 RID: 4790
	public Button openFileButton;

	// Token: 0x040012B7 RID: 4791
	public Button openMultipleFilesButton;

	// Token: 0x040012B8 RID: 4792
	public Button saveFileButton;

	// Token: 0x040012B9 RID: 4793
	public Text messageText;
}
