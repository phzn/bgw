using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using Rewired.Platforms;
using Rewired.Utils.Interfaces;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Rewired
{
	// Token: 0x0200018B RID: 395
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class InputManager : InputManager_Base
	{
		// Token: 0x06001B04 RID: 6916 RVA: 0x0007C4ED File Offset: 0x0007A6ED
		protected override void OnInitialized()
		{
			this.eko();
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x0007C4F5 File Offset: 0x0007A6F5
		protected override void OnDeinitialized()
		{
			this.ekp();
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x0007C500 File Offset: 0x0007A700
		protected override void DetectPlatform()
		{
			this.scriptingBackend = ScriptingBackend.Mono;
			this.scriptingAPILevel = ScriptingAPILevel.Net20;
			this.editorPlatform = EditorPlatform.None;
			this.platform = Platform.Unknown;
			this.webplayerPlatform = WebplayerPlatform.None;
			this.isEditor = false;
			if (SystemInfo.deviceName == null)
			{
				string empty = string.Empty;
			}
			if (SystemInfo.deviceModel == null)
			{
				string empty2 = string.Empty;
			}
			this.platform = Platform.Windows;
			this.scriptingBackend = ScriptingBackend.Mono;
			this.scriptingAPILevel = ScriptingAPILevel.NetStandard20;
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x00005090 File Offset: 0x00003290
		protected override void CheckRecompile()
		{
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x0007C566 File Offset: 0x0007A766
		protected override IExternalTools GetExternalTools()
		{
			return new gv();
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x0007C56D File Offset: 0x0007A76D
		private bool ekn(string a, string b, string c)
		{
			return Regex.IsMatch(b, a, RegexOptions.IgnoreCase) || Regex.IsMatch(c, a, RegexOptions.IgnoreCase);
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x0007C583 File Offset: 0x0007A783
		private void eko()
		{
			this.ekp();
			SceneManager.sceneLoaded += this.ekq;
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x0007C59C File Offset: 0x0007A79C
		private void ekp()
		{
			SceneManager.sceneLoaded -= this.ekq;
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x0007C5AF File Offset: 0x0007A7AF
		private void ekq(Scene a, LoadSceneMode b)
		{
			base.OnSceneLoaded();
		}

		// Token: 0x04000E6F RID: 3695
		private bool jqg;
	}
}
