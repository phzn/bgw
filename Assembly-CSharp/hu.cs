using System;
using System.Text;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Rewired.Integration.UnityUI;
using Rewired.UI;
using UnityEngine.EventSystems;

// Token: 0x020001AF RID: 431
public class hu : PointerEventData
{
	// Token: 0x170003D6 RID: 982
	// (get) Token: 0x06001C81 RID: 7297 RVA: 0x00081E75 File Offset: 0x00080075
	// (set) Token: 0x06001C82 RID: 7298 RVA: 0x00081E7D File Offset: 0x0008007D
	public int jtl { get; set; }

	// Token: 0x170003D7 RID: 983
	// (get) Token: 0x06001C83 RID: 7299 RVA: 0x00081E86 File Offset: 0x00080086
	// (set) Token: 0x06001C84 RID: 7300 RVA: 0x00081E8E File Offset: 0x0008008E
	public int jtm { get; set; }

	// Token: 0x170003D8 RID: 984
	// (get) Token: 0x06001C85 RID: 7301 RVA: 0x00081E97 File Offset: 0x00080097
	// (set) Token: 0x06001C86 RID: 7302 RVA: 0x00081E9F File Offset: 0x0008009F
	public IMouseInputSource jtn { get; set; }

	// Token: 0x170003D9 RID: 985
	// (get) Token: 0x06001C87 RID: 7303 RVA: 0x00081EA8 File Offset: 0x000800A8
	// (set) Token: 0x06001C88 RID: 7304 RVA: 0x00081EB0 File Offset: 0x000800B0
	public ITouchInputSource jto { get; set; }

	// Token: 0x170003DA RID: 986
	// (get) Token: 0x06001C89 RID: 7305 RVA: 0x00081EB9 File Offset: 0x000800B9
	// (set) Token: 0x06001C8A RID: 7306 RVA: 0x00081EC1 File Offset: 0x000800C1
	public PointerEventType jtp { get; set; }

	// Token: 0x170003DB RID: 987
	// (get) Token: 0x06001C8B RID: 7307 RVA: 0x00081ECA File Offset: 0x000800CA
	// (set) Token: 0x06001C8C RID: 7308 RVA: 0x00081ED2 File Offset: 0x000800D2
	public int jtq { get; set; }

	// Token: 0x06001C8D RID: 7309 RVA: 0x00081EDB File Offset: 0x000800DB
	public hu(EventSystem a)
		: base(a)
	{
		this.jtl = -1;
		this.jtm = -1;
		this.jtq = -1;
	}

	// Token: 0x06001C8E RID: 7310 RVA: 0x00081EFC File Offset: 0x000800FC
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(a.eny() + this.jtl.ToString());
		string text = a.enz();
		IMouseInputSource mouseInputSource = this.jtn;
		stringBuilder.AppendLine(text + ((mouseInputSource != null) ? mouseInputSource.ToString() : null));
		stringBuilder.AppendLine(a.eoa() + this.jtm.ToString());
		string text2 = a.eob();
		ITouchInputSource touchInputSource = this.jto;
		stringBuilder.AppendLine(text2 + ((touchInputSource != null) ? touchInputSource.ToString() : null));
		stringBuilder.AppendLine(a.eoc() + this.jtp.ToString());
		stringBuilder.AppendLine(a.eod() + this.jtq.ToString());
		stringBuilder.Append(base.ToString());
		return stringBuilder.ToString();
	}
}
