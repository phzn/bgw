using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Kirurobo;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000263 RID: 611
public class lm : MonoBehaviour
{
	// Token: 0x17000611 RID: 1553
	// (get) Token: 0x0600260A RID: 9738 RVA: 0x0009E460 File Offset: 0x0009C660
	public static lm mgx
	{
		get
		{
			lm lm;
			if ((lm = lm.kiz) == null)
			{
				lm = (lm.kiz = global::UnityEngine.Object.FindAnyObjectByType<lm>() ?? new lm());
			}
			return lm;
		}
	}

	// Token: 0x0600260B RID: 9739 RVA: 0x0009E47F File Offset: 0x0009C67F
	public void edn(string a)
	{
		if (a == a.ezu())
		{
			UniWindowController.current.isTransparent = true;
		}
		else if (a == a.ezv())
		{
			UniWindowController.current.shouldFitMonitor = true;
		}
		SceneManager.LoadScene(a);
	}

	// Token: 0x0600260C RID: 9740 RVA: 0x00043378 File Offset: 0x00041578
	public void hdt()
	{
		Application.Quit();
	}

	// Token: 0x0600260D RID: 9741 RVA: 0x0009E4B9 File Offset: 0x0009C6B9
	private void Awake()
	{
		if (this != lm.mgx)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		global::UnityEngine.Object.DontDestroyOnLoad(lm.mgx);
		global::UnityEngine.Object.DontDestroyOnLoad(UniWindowController.current);
		SceneManager.sceneLoaded += this.gvc;
	}

	// Token: 0x0600260E RID: 9742 RVA: 0x00043378 File Offset: 0x00041578
	public void gve()
	{
		Application.Quit();
	}

	// Token: 0x06002610 RID: 9744 RVA: 0x0009E4F9 File Offset: 0x0009C6F9
	public void gpf(string a)
	{
		if (a == a.ezw())
		{
			UniWindowController.current.isTransparent = true;
		}
		else if (a == a.ezx())
		{
			UniWindowController.current.shouldFitMonitor = true;
		}
		SceneManager.LoadScene(a);
	}

	// Token: 0x06002611 RID: 9745 RVA: 0x0009E533 File Offset: 0x0009C733
	public void gvd(string a)
	{
		if (a == a.ezy())
		{
			UniWindowController.current.isTransparent = true;
		}
		else if (a == a.ezz())
		{
			UniWindowController.current.shouldFitMonitor = true;
		}
		SceneManager.LoadScene(a);
	}

	// Token: 0x06002612 RID: 9746 RVA: 0x0009E56D File Offset: 0x0009C76D
	public void iuv(string a)
	{
		if (a == a.faa())
		{
			UniWindowController.current.isTransparent = true;
		}
		else if (a == a.fab())
		{
			UniWindowController.current.shouldFitMonitor = true;
		}
		SceneManager.LoadScene(a);
	}

	// Token: 0x06002613 RID: 9747 RVA: 0x0009E5A7 File Offset: 0x0009C7A7
	private void gvc(Scene a, LoadSceneMode b)
	{
		UniWindowController.current.SetCamera(Camera.main);
	}

	// Token: 0x06002614 RID: 9748 RVA: 0x0009E5A7 File Offset: 0x0009C7A7
	private void civ(Scene a, LoadSceneMode b)
	{
		UniWindowController.current.SetCamera(Camera.main);
	}

	// Token: 0x04001285 RID: 4741
	private static lm kiz;

	// Token: 0x04001286 RID: 4742
	public Canvas canvas;
}
