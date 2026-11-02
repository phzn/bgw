using System;

// Token: 0x0200002D RID: 45
public readonly struct DlcInfo
{
	// Token: 0x17000033 RID: 51
	// (get) Token: 0x06000278 RID: 632 RVA: 0x0000C81A File Offset: 0x0000AA1A
	public uint AppId { get; }

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000279 RID: 633 RVA: 0x0000C822 File Offset: 0x0000AA22
	public string BundleName { get; }

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x0600027A RID: 634 RVA: 0x0000C82A File Offset: 0x0000AA2A
	public string InstallDirName { get; }

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x0600027B RID: 635 RVA: 0x0000C832 File Offset: 0x0000AA32
	public string SourceAssetFolder { get; }

	// Token: 0x0600027C RID: 636 RVA: 0x0000C83A File Offset: 0x0000AA3A
	public DlcInfo(uint appId, string bundleName, string installDirName, string sourceAssetFolder)
	{
		this.AppId = appId;
		this.BundleName = (bundleName ?? string.Empty).ToLowerInvariant();
		this.InstallDirName = installDirName;
		this.SourceAssetFolder = sourceAssetFolder;
	}
}
