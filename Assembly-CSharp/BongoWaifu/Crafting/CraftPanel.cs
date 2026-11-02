using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using RamenCat;
using RamenCat.Crafting;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

namespace BongoWaifu.Crafting
{
	// Token: 0x02000108 RID: 264
	public class CraftPanel : MonoBehaviour
	{
		// Token: 0x06001336 RID: 4918 RVA: 0x0005D8A0 File Offset: 0x0005BAA0
		private void Awake()
		{
			if (this._basketSlotPrefab != null && this._basketSlotPrefab.gameObject.activeSelf)
			{
				this._basketSlotPrefab.gameObject.SetActive(false);
			}
			if (this._itemSlotPrefab != null && this._itemSlotPrefab.gameObject.activeSelf)
			{
				this._itemSlotPrefab.gameObject.SetActive(false);
			}
			this.iok = new fe((this._config != null) ? this._config.ksq : 10);
			this.iok.inh += this.cxv;
			this.ipg = new Comparison<CraftPanel.ff>(this.cyj);
			this.cxa();
			if (this._btnCraft != null)
			{
				this._btnCraft.onClick.RemoveAllListeners();
				this._btnCraft.onClick.AddListener(new UnityAction(this.cyf));
			}
			if (this._btnAutoSelectDuplicates != null)
			{
				this._btnAutoSelectDuplicates.onClick.RemoveAllListeners();
				this._btnAutoSelectDuplicates.onClick.AddListener(new UnityAction(this.cyb));
			}
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x0005D9DC File Offset: 0x0005BBDC
		private void OnDestroy()
		{
			if (this.iok != null)
			{
				this.iok.inh -= this.cxv;
			}
			if (this._btnCraft != null)
			{
				this._btnCraft.onClick.RemoveListener(new UnityAction(this.cyf));
			}
			if (this._btnAutoSelectDuplicates != null)
			{
				this._btnAutoSelectDuplicates.onClick.RemoveListener(new UnityAction(this.cyb));
			}
			bp.hky -= this.cww;
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x0005DA70 File Offset: 0x0005BC70
		private void OnEnable()
		{
			if (SteamInventoryManager.iid != null)
			{
				SteamInventoryManager.iid.iie += this.cxb;
			}
			bp.hky += this.cww;
			LocalizationSettings.SelectedLocaleChanged += this.cwx;
			if (@do.hzm != null && this._giftDisplayAnchor != null)
			{
				@do.hzm.ccb(a.doz(), this._giftDisplayAnchor);
			}
			this.iou.Clear();
			this.iov = 0;
			this.cwy();
			this.cxd();
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x0005DB10 File Offset: 0x0005BD10
		private void OnDisable()
		{
			if (SteamInventoryManager.iid != null)
			{
				SteamInventoryManager.iid.iie -= this.cxb;
			}
			bp.hky -= this.cww;
			LocalizationSettings.SelectedLocaleChanged -= this.cwx;
			if (@do.hzm != null)
			{
				@do.hzm.ccc(a.doz());
			}
			if (this.ioj != null)
			{
				base.StopCoroutine(this.ioj);
				this.ioj = null;
			}
			if (this.iok != null)
			{
				this.iok.cwg();
			}
			this.iou.Clear();
			this.iov = 0;
			this.ipa = 0;
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x0005DBC5 File Offset: 0x0005BDC5
		private void cww()
		{
			if (base.gameObject.activeInHierarchy)
			{
				this.cxd();
			}
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x0005DBDA File Offset: 0x0005BDDA
		private void cwx(Locale a)
		{
			this.cwy();
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x0005DBE4 File Offset: 0x0005BDE4
		private void cwy()
		{
			if (this._textBtnLabel != null)
			{
				this._textBtnLabel.text = CraftPanel.cwz(a.dsa(), a.dsb());
			}
			if (this._textAutoSelectLabel != null)
			{
				this._textAutoSelectLabel.text = CraftPanel.cwz(a.dsc(), a.dsd());
			}
			if (this.ioj == null && !this.iow)
			{
				this.cxy();
			}
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x0005DC58 File Offset: 0x0005BE58
		private static string cwz(string a, string b)
		{
			string text;
			try
			{
				string localizedString = LocalizationSettings.StringDatabase.GetLocalizedString(a.rh(), a, null, FallbackBehavior.UseProjectSettings, Array.Empty<object>());
				text = (string.IsNullOrEmpty(localizedString) ? b : localizedString);
			}
			catch
			{
				text = b;
			}
			return text;
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0005DCAC File Offset: 0x0005BEAC
		private void cxa()
		{
			if (this._basketSlotPrefab == null || this._transBasketContent == null)
			{
				return;
			}
			int num = this.iok.ksz;
			for (int i = 0; i < num; i++)
			{
				CraftBasketSlot craftBasketSlot = global::UnityEngine.Object.Instantiate<CraftBasketSlot>(this._basketSlotPrefab, this._transBasketContent);
				craftBasketSlot.gameObject.SetActive(true);
				craftBasketSlot.cwj(i, new Action<int>(this.cxu));
				this.iol.Add(craftBasketSlot);
			}
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0005DD2C File Offset: 0x0005BF2C
		private void cxb(IReadOnlyList<ItemData> a)
		{
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (!this.iow)
			{
				this.ioy.Clear();
				if (a != null)
				{
					for (int i = 0; i < a.Count; i++)
					{
						ItemData itemData = a[i];
						if (itemData.quantity > 0U)
						{
							this.ioy.Add(new ValueTuple<ulong, uint>(itemData.itemId, itemData.quantity));
						}
					}
				}
				if (this.ioz && this.ioy.SetEquals(this.iox))
				{
					return;
				}
			}
			this.cxe(a);
			if (!this.iow)
			{
				this.iox.Clear();
				foreach (ValueTuple<ulong, uint> valueTuple in this.ioy)
				{
					this.iox.Add(valueTuple);
				}
				this.ioz = true;
				return;
			}
			this.iox.Clear();
			if (a != null)
			{
				for (int j = 0; j < a.Count; j++)
				{
					ItemData itemData2 = a[j];
					if (itemData2.quantity > 0U)
					{
						this.iox.Add(new ValueTuple<ulong, uint>(itemData2.itemId, itemData2.quantity));
					}
				}
			}
			this.ioz = true;
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0005DE84 File Offset: 0x0005C084
		public void cxc()
		{
			this.cxd();
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x0005DE8C File Offset: 0x0005C08C
		private void cxd()
		{
			if (SteamInventoryManager.iid == null)
			{
				return;
			}
			IReadOnlyList<ItemData> readOnlyList = SteamInventoryManager.iid.cpm();
			this.cxe(readOnlyList);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0005DEBC File Offset: 0x0005C0BC
		private void cxe(IReadOnlyList<ItemData> a)
		{
			this.iop.Clear();
			if (a != null)
			{
				for (int i = 0; i < a.Count; i++)
				{
					ItemData itemData = a[i];
					if (this.cxj(itemData))
					{
						this.iop.Add(itemData);
					}
				}
			}
			this.cxf(this.iop);
			int num = this.iok.cwh(this.iop);
			if (num > 0)
			{
				Debug.Log(string.Format(a.dse(), num));
			}
			this.cxn();
			this.cxw();
			this.cxy();
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0005DF50 File Offset: 0x0005C150
		private void cxf(List<ItemData> a)
		{
			for (int i = 0; i < this.ioo.Count; i++)
			{
				this.cxh(this.ioo[i]);
			}
			this.ioo.Clear();
			this.ipb.Clear();
			this.ioq.Clear();
			this.ior.Clear();
			this.ipc.Clear();
			for (int j = 0; j < a.Count; j++)
			{
				ItemData itemData = a[j];
				if (!this.ipc.Add(itemData.itemId))
				{
					Debug.LogError(string.Format(a.dsf(), itemData.itemId, itemData.defID, itemData.quantity));
				}
				else
				{
					CraftPanel.ff ff;
					if (!this.ior.TryGetValue(itemData.defID, out ff))
					{
						ff = this.cxg(itemData.defID, itemData.rarity);
						this.ior[itemData.defID] = ff;
						if (this.iou.ContainsKey(itemData.defID))
						{
							this.ioo.Add(ff);
						}
						else
						{
							this.ipb.Add(ff);
						}
					}
					ff.@int.Add(itemData);
					ff.ins += (int)itemData.quantity;
				}
			}
			this.ior.Clear();
			this.ioo.Sort(this.ipg);
			if (this.ipb.Count > 0)
			{
				this.ipb.Sort(new Comparison<CraftPanel.ff>(CraftPanel.cxl));
				for (int k = 0; k < this.ipb.Count; k++)
				{
					CraftPanel.ff ff2 = this.ipb[k];
					Dictionary<int, int> dictionary = this.iou;
					int inq = ff2.inq;
					int num = this.iov;
					this.iov = num + 1;
					dictionary[inq] = num;
					this.ioo.Add(ff2);
				}
				this.ipb.Clear();
			}
			for (int l = 0; l < this.ioo.Count; l++)
			{
				this.cxi(this.ioo[l]);
			}
			this.ipd.Clear();
			for (int m = 0; m < this.ioo.Count; m++)
			{
				CraftPanel.ff ff3 = this.ioo[m];
				if (!this.ipd.Add(ff3.inq))
				{
					Debug.LogError(string.Format(a.dsg(), ff3.inq));
				}
			}
			this.ipd.Clear();
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x0005E1F0 File Offset: 0x0005C3F0
		private CraftPanel.ff cxg(int a, string b)
		{
			CraftPanel.ff ff = ((this.ios.Count > 0) ? this.ios.Dequeue() : new CraftPanel.ff());
			ff.inq = a;
			ff.inr = b;
			ff.ins = 0;
			if (ff.@int == null)
			{
				ff.@int = ((this.iot.Count > 0) ? this.iot.Dequeue() : new List<ItemData>(8));
			}
			else
			{
				ff.@int.Clear();
			}
			ff.inu = null;
			return ff;
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x0005E278 File Offset: 0x0005C478
		private void cxh(CraftPanel.ff a)
		{
			if (a == null)
			{
				return;
			}
			a.inu = null;
			if (a.@int != null)
			{
				a.@int.Clear();
				this.iot.Enqueue(a.@int);
				a.@int = null;
			}
			this.ios.Enqueue(a);
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0005E2C8 File Offset: 0x0005C4C8
		private void cxi(CraftPanel.ff a)
		{
			if (a.@int == null || a.@int.Count == 0)
			{
				return;
			}
			ItemData itemData = a.@int[0];
			ItemData itemData2 = new ItemData();
			itemData.biw(itemData2);
			itemData2.quantity = (uint)a.ins;
			a.inu = itemData2;
			this.ioq[itemData2.itemId] = a;
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x0005E328 File Offset: 0x0005C528
		private bool cxj(ItemData a)
		{
			return a != null && a.quantity != 0U && (!(this._config != null) || this._config.cqz(a)) && this.cxk(a);
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x0005E364 File Offset: 0x0005C564
		private bool cxk(ItemData a)
		{
			if (a == null || string.IsNullOrEmpty(a.rarity))
			{
				return false;
			}
			bool flag;
			if (this.ipe.TryGetValue(a.defID, out flag))
			{
				return flag;
			}
			uint num = 1024U;
			string text;
			if (!SteamInventory.GetItemDefinitionProperty(new SteamItemDef_t(a.defID), a.dol(), out text, ref num))
			{
				return false;
			}
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			string text2 = a.dom() + a.rarity.ToLowerInvariant() + a.don();
			bool flag2 = text.Contains(text2);
			this.ipe[a.defID] = flag2;
			return flag2;
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x0005E400 File Offset: 0x0005C600
		private static int cxl(CraftPanel.ff a, CraftPanel.ff b)
		{
			bool flag = a != null && bp.zp(a.inq);
			bool flag2 = b != null && bp.zp(b.inq);
			if (flag != flag2)
			{
				if (!flag)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				int num = CraftPanel.cxm((a != null) ? a.inr : null);
				int num2 = CraftPanel.cxm((b != null) ? b.inr : null);
				if (num != num2)
				{
					return num.CompareTo(num2);
				}
				int num3 = ((a != null) ? a.ins : 0);
				int num4 = ((b != null) ? b.ins : 0);
				if (num3 != num4)
				{
					return num4.CompareTo(num3);
				}
				int num5 = ((a != null) ? a.inq : 0);
				int num6 = ((b != null) ? b.inq : 0);
				return num5.CompareTo(num6);
			}
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x0005E4C0 File Offset: 0x0005C6C0
		private static int cxm(string a)
		{
			if (string.IsNullOrEmpty(a))
			{
				return 0;
			}
			string text = a.ToLowerInvariant();
			if (text == a.dsh())
			{
				return 6;
			}
			if (text == a.dsi())
			{
				return 5;
			}
			if (text == a.dsj())
			{
				return 4;
			}
			if (text == a.dsk())
			{
				return 3;
			}
			if (text == a.dsl())
			{
				return 2;
			}
			if (!(text == a.dsm()))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x0005E53C File Offset: 0x0005C73C
		private void cxn()
		{
			for (int i = this.iom.Count - 1; i >= 0; i--)
			{
				this.cxr(this.iom[i]);
			}
			for (int j = 0; j < this.ioo.Count; j++)
			{
				ItemData inu = this.ioo[j].inu;
				if (inu != null)
				{
					this.cxq().cwo(inu, new Func<ItemData, int>(this.cxs), new Func<ItemData, bool>(this.cxo), new Action<ItemData, bool>(this.cxt), new Func<ItemData, bool>(this.cxp));
				}
			}
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x0005E5DC File Offset: 0x0005C7DC
		private bool cxo(ItemData a)
		{
			if (a == null)
			{
				return false;
			}
			string text = this.iok.ktd;
			return string.IsNullOrEmpty(text) || string.Equals(text, a.rarity, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x0005E611 File Offset: 0x0005C811
		private bool cxp(ItemData a)
		{
			return a != null && bp.zp(a.defID);
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x0005E624 File Offset: 0x0005C824
		private CraftItemSlot cxq()
		{
			CraftItemSlot craftItemSlot = ((this.ion.Count > 0) ? this.ion.Dequeue() : global::UnityEngine.Object.Instantiate<CraftItemSlot>(this._itemSlotPrefab, this._transItemPool));
			craftItemSlot.transform.SetParent(this._transItemContent, false);
			craftItemSlot.gameObject.SetActive(true);
			this.iom.Add(craftItemSlot);
			return craftItemSlot;
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x0005E689 File Offset: 0x0005C889
		private void cxr(CraftItemSlot a)
		{
			this.iom.Remove(a);
			a.gameObject.SetActive(false);
			a.transform.SetParent(this._transItemPool, false);
			this.ion.Enqueue(a);
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x0005E6C4 File Offset: 0x0005C8C4
		private int cxs(ItemData a)
		{
			if (a == null)
			{
				return 0;
			}
			CraftPanel.ff ff;
			if (!this.ioq.TryGetValue(a.itemId, out ff) || ff == null)
			{
				return 0;
			}
			int num = 0;
			List<ItemData> @int = ff.@int;
			for (int i = 0; i < @int.Count; i++)
			{
				num += this.iok.cwd(@int[i].itemId);
			}
			return num;
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x0005E728 File Offset: 0x0005C928
		private void cxt(ItemData a, bool b)
		{
			if (this.iow || a == null)
			{
				return;
			}
			CraftPanel.ff ff;
			if (!this.ioq.TryGetValue(a.itemId, out ff) || ff == null)
			{
				return;
			}
			if (!b)
			{
				List<ItemData> @int = ff.@int;
				for (int i = @int.Count - 1; i >= 0; i--)
				{
					ItemData itemData = @int[i];
					if (this.iok.cwd(itemData.itemId) > 0)
					{
						this.iok.Remove(itemData.itemId);
						return;
					}
				}
				return;
			}
			if (this.iok.ktb)
			{
				return;
			}
			int num = ff.ins;
			if (bp.zp(ff.inq) && num > 0)
			{
				num--;
			}
			if (this.cxs(a) >= num)
			{
				return;
			}
			if (this.iok.ktd != null && !string.Equals(this.iok.ktd, ff.inr, StringComparison.OrdinalIgnoreCase))
			{
				Debug.LogWarning(a.dsn() + this.iok.ktd + a.dso() + ff.inr);
				return;
			}
			List<ItemData> int2 = ff.@int;
			for (int j = 0; j < int2.Count; j++)
			{
				ItemData itemData2 = int2[j];
				if (this.iok.cwd(itemData2.itemId) < (int)itemData2.quantity)
				{
					this.iok.Add(itemData2.itemId, ff.inr);
					return;
				}
			}
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x0005E88C File Offset: 0x0005CA8C
		private void cxu(int a)
		{
			if (this.iow)
			{
				return;
			}
			this.iok.cwe(a);
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x0005E8A4 File Offset: 0x0005CAA4
		private void cxv()
		{
			this.cxw();
			this.cxy();
			for (int i = 0; i < this.iom.Count; i++)
			{
				this.iom[i].cwq();
			}
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0005E8E4 File Offset: 0x0005CAE4
		private void cxw()
		{
			for (int i = 0; i < this.iol.Count; i++)
			{
				ulong num = this.iok.cwf(i);
				if (num == 0UL)
				{
					this.iol[i].cwk();
				}
				else
				{
					ItemData itemData = this.cxx(num);
					if (itemData == null)
					{
						this.iol[i].cwk();
					}
					else
					{
						this.iol[i].cwl(itemData);
					}
				}
			}
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x0005E95C File Offset: 0x0005CB5C
		private ItemData cxx(ulong a)
		{
			for (int i = 0; i < this.ioo.Count; i++)
			{
				List<ItemData> @int = this.ioo[i].@int;
				if (@int != null)
				{
					for (int j = 0; j < @int.Count; j++)
					{
						if (@int[j].itemId == a)
						{
							return @int[j];
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0005E9C0 File Offset: 0x0005CBC0
		private void cxy()
		{
			if (this._btnCraft == null)
			{
				return;
			}
			bool flag = !this.iow && this.iok.ktb;
			this._btnCraft.interactable = flag;
			if (this._btnCraftCanvasGroup != null)
			{
				this._btnCraftCanvasGroup.alpha = (flag ? 1f : 0.5f);
			}
			if (this._textCraftStatus != null && this.ioj == null)
			{
				this._textCraftStatus.text = this.cxz();
			}
			bool flag2 = !this.iow && !this.iok.ktb && this.cye();
			if (this._btnAutoSelectDuplicates != null)
			{
				this._btnAutoSelectDuplicates.interactable = flag2;
			}
			if (this._btnAutoSelectCanvasGroup != null)
			{
				this._btnAutoSelectCanvasGroup.alpha = (flag2 ? 1f : 0.5f);
			}
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x0005EAB0 File Offset: 0x0005CCB0
		private string cxz()
		{
			if (this.iow)
			{
				return CraftPanel.cwz(a.dsp(), a.dsq());
			}
			int num = this.iok.kta;
			int num2 = this.iok.ksz;
			if (num == 0)
			{
				return CraftPanel.cwz(a.dsr(), string.Format(a.dss(), num2));
			}
			string text = this.iok.ktd;
			string text2 = this.cya(text);
			if (num >= num2)
			{
				string text3 = CraftPanel.cwz(a.dst(), a.dsu());
				return string.Concat(new string[]
				{
					text3,
					a.dsv(),
					text,
					a.dsw(),
					text2,
					a.dsx()
				});
			}
			return string.Format(a.dsy(), new object[] { text, num, num2, text2 });
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0005EB90 File Offset: 0x0005CD90
		private string cya(string a)
		{
			if (this._config == null)
			{
				return a.biz();
			}
			CraftTierEntry craftTierEntry = this._config.cra(a);
			if (craftTierEntry == null)
			{
				return a.biz();
			}
			return craftTierEntry.outputRarity;
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0005EBD0 File Offset: 0x0005CDD0
		private void cyb()
		{
			if (this.iow)
			{
				return;
			}
			if (this.iok == null || this.iok.ktb)
			{
				return;
			}
			string text = this.iok.ktd;
			if (string.IsNullOrEmpty(text))
			{
				text = this.cyd();
				if (string.IsNullOrEmpty(text))
				{
					this.cyh(CraftPanel.cwz(a.dsz(), a.dta()));
					return;
				}
			}
			int num = 0;
			while (num < this.ioo.Count && !this.iok.ktb)
			{
				CraftPanel.ff ff = this.ioo[num];
				if (ff != null && ff.inu != null && string.Equals(ff.inr, text, StringComparison.OrdinalIgnoreCase))
				{
					int num2 = ff.ins - 1 - this.cxs(ff.inu);
					int num3 = 0;
					while (num3 < num2 && !this.iok.ktb && this.cyc(ff, text))
					{
						num3++;
					}
				}
				num++;
			}
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0005ECC8 File Offset: 0x0005CEC8
		private bool cyc(CraftPanel.ff a, string b)
		{
			List<ItemData> @int = a.@int;
			if (@int == null)
			{
				return false;
			}
			for (int i = 0; i < @int.Count; i++)
			{
				ItemData itemData = @int[i];
				if (this.iok.cwd(itemData.itemId) < (int)itemData.quantity)
				{
					return this.iok.Add(itemData.itemId, b);
				}
			}
			return false;
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x0005ED28 File Offset: 0x0005CF28
		private string cyd()
		{
			this.ipf.Clear();
			for (int i = 0; i < this.ioo.Count; i++)
			{
				CraftPanel.ff ff = this.ioo[i];
				if (ff != null && ff.inu != null && !(this._config == null) && this._config.cra(ff.inr) != null)
				{
					int num = ff.ins - 1 - this.cxs(ff.inu);
					if (num > 0)
					{
						int num2;
						this.ipf.TryGetValue(ff.inr, out num2);
						this.ipf[ff.inr] = num2 + num;
					}
				}
			}
			if (this.ipf.Count == 0)
			{
				return null;
			}
			int num3 = ((this.iok != null) ? this.iok.ksz : int.MaxValue);
			string text = null;
			int num4 = int.MaxValue;
			string text2 = null;
			int num5 = -1;
			int num6 = int.MaxValue;
			foreach (KeyValuePair<string, int> keyValuePair in this.ipf)
			{
				int num7 = CraftPanel.cxm(keyValuePair.Key);
				if (keyValuePair.Value >= num3 && num7 < num4)
				{
					num4 = num7;
					text = keyValuePair.Key;
				}
				if (keyValuePair.Value > num5 || (keyValuePair.Value == num5 && num7 < num6))
				{
					num5 = keyValuePair.Value;
					num6 = num7;
					text2 = keyValuePair.Key;
				}
			}
			return text ?? text2;
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x0005EECC File Offset: 0x0005D0CC
		private bool cye()
		{
			if (this.iok == null)
			{
				return false;
			}
			string text = this.iok.ktd;
			for (int i = 0; i < this.ioo.Count; i++)
			{
				CraftPanel.ff ff = this.ioo[i];
				if (ff != null && ff.inu != null)
				{
					if (!string.IsNullOrEmpty(text))
					{
						if (!string.Equals(ff.inr, text, StringComparison.OrdinalIgnoreCase))
						{
							goto IL_0089;
						}
					}
					else if (this._config == null || this._config.cra(ff.inr) == null)
					{
						goto IL_0089;
					}
					if (ff.ins - 1 - this.cxs(ff.inu) > 0)
					{
						return true;
					}
				}
				IL_0089:;
			}
			return false;
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0005EF78 File Offset: 0x0005D178
		private void cyf()
		{
			if (this.iow)
			{
				return;
			}
			if (!this.iok.ktb)
			{
				return;
			}
			if (this._config == null)
			{
				Debug.LogError(a.dtb());
				return;
			}
			if (SteamInventoryManager.iid == null)
			{
				Debug.LogError(a.dtc());
				return;
			}
			IReadOnlyList<ItemData> readOnlyList = SteamInventoryManager.iid.cpm();
			int num = this.iok.cwh(readOnlyList);
			if (num > 0 || !this.iok.ktb)
			{
				Debug.LogWarning(string.Format(a.dtd(), num, this.iok.kta, this.iok.ksz));
				this.cxy();
				return;
			}
			CraftTierEntry craftTierEntry = this._config.cra(this.iok.ktd);
			if (craftTierEntry == null)
			{
				Debug.LogError(a.dte() + this.iok.ktd + a.dtf());
				return;
			}
			ValueTuple<ulong, uint>[] array = this.iok.cwi();
			this.iow = true;
			this.cxy();
			this.iok.cwg();
			if (!SteamInventoryManager.iid.cqa(craftTierEntry.generatorDefId, array, this._config.craftTimeoutSeconds, new Action<bool, EResult>(this.cyg), out this.ipa))
			{
				this.iow = false;
				this.cxy();
				Debug.LogWarning(a.dtg());
				return;
			}
			if (bq.knd)
			{
				Debug.Log(string.Format(a.dth(), this.ipa));
			}
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0005F0FC File Offset: 0x0005D2FC
		private void cyg(bool a, EResult b)
		{
			this.iow = false;
			this.ipa = 0;
			if (a)
			{
				Debug.Log(string.Format(a.dti(), b));
				if (du.iah != null)
				{
					du.iah.cec(du.STEAM_STAT_ID.STAT_CRAFT_TOTAL_COUNT, 1, du.STEAM_STAT_OP.Add);
				}
				if (bq.hle != null)
				{
					bq.bao();
					bq.hle.bkt();
					ci.Save(null);
				}
				this.cyh(CraftPanel.cwz(a.dtj(), a.dtk()));
			}
			else
			{
				Debug.LogError(string.Format(a.dtl(), b));
				this.cyh(CraftPanel.cwz(a.dtm(), a.dtn()));
			}
			this.cxy();
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x0005F1B2 File Offset: 0x0005D3B2
		private void cyh(string a)
		{
			if (this._textCraftStatus == null)
			{
				return;
			}
			if (this.ioj != null)
			{
				base.StopCoroutine(this.ioj);
			}
			this.ioj = base.StartCoroutine(this.cyi(a));
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x0005F1EA File Offset: 0x0005D3EA
		private IEnumerator cyi(string a)
		{
			this._textCraftStatus.text = a;
			yield return new WaitForSeconds(this._resultDisplayDuration);
			this.ioj = null;
			if (this._textCraftStatus != null)
			{
				this._textCraftStatus.text = this.cxz();
			}
			yield break;
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x0005F2EC File Offset: 0x0005D4EC
		[CompilerGenerated]
		private int cyj(CraftPanel.ff a, CraftPanel.ff b)
		{
			bool flag = bp.zp(a.inq);
			bool flag2 = bp.zp(b.inq);
			if (flag == flag2)
			{
				int num;
				this.iou.TryGetValue(a.inq, out num);
				int num2;
				this.iou.TryGetValue(b.inq, out num2);
				return num.CompareTo(num2);
			}
			if (!flag)
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x040009F1 RID: 2545
		[SerializeField]
		private CraftRecipeConfig _config;

		// Token: 0x040009F2 RID: 2546
		[SerializeField]
		private Transform _transBasketContent;

		// Token: 0x040009F3 RID: 2547
		[SerializeField]
		private CraftBasketSlot _basketSlotPrefab;

		// Token: 0x040009F4 RID: 2548
		[SerializeField]
		private Transform _transItemContent;

		// Token: 0x040009F5 RID: 2549
		[SerializeField]
		private Transform _transItemPool;

		// Token: 0x040009F6 RID: 2550
		[SerializeField]
		private CraftItemSlot _itemSlotPrefab;

		// Token: 0x040009F7 RID: 2551
		[SerializeField]
		private Button _btnCraft;

		// Token: 0x040009F8 RID: 2552
		[SerializeField]
		private CanvasGroup _btnCraftCanvasGroup;

		// Token: 0x040009F9 RID: 2553
		[SerializeField]
		private TextMeshProUGUI _textBtnLabel;

		// Token: 0x040009FA RID: 2554
		[SerializeField]
		private TextMeshProUGUI _textCraftStatus;

		// Token: 0x040009FB RID: 2555
		[SerializeField]
		private float _resultDisplayDuration = 2.5f;

		// Token: 0x040009FC RID: 2556
		[SerializeField]
		private Button _btnAutoSelectDuplicates;

		// Token: 0x040009FD RID: 2557
		[SerializeField]
		private CanvasGroup _btnAutoSelectCanvasGroup;

		// Token: 0x040009FE RID: 2558
		[SerializeField]
		private TextMeshProUGUI _textAutoSelectLabel;

		// Token: 0x040009FF RID: 2559
		[SerializeField]
		private Transform _giftDisplayAnchor;

		// Token: 0x04000A00 RID: 2560
		private const string inz = "UI";

		// Token: 0x04000A01 RID: 2561
		private const string ioa = "craft_btn_label";

		// Token: 0x04000A02 RID: 2562
		private const string iob = "craft_status_idle";

		// Token: 0x04000A03 RID: 2563
		private const string ioc = "craft_status_progress";

		// Token: 0x04000A04 RID: 2564
		private const string iod = "craft_status_ready";

		// Token: 0x04000A05 RID: 2565
		private const string ioe = "craft_status_crafting";

		// Token: 0x04000A06 RID: 2566
		private const string iof = "craft_status_success";

		// Token: 0x04000A07 RID: 2567
		private const string iog = "craft_status_failed";

		// Token: 0x04000A08 RID: 2568
		private const string ioh = "craft_btn_auto_select";

		// Token: 0x04000A09 RID: 2569
		private const string ioi = "craft_status_no_duplicates";

		// Token: 0x04000A0A RID: 2570
		private Coroutine ioj;

		// Token: 0x04000A0B RID: 2571
		private fe iok;

		// Token: 0x04000A0C RID: 2572
		private readonly List<CraftBasketSlot> iol = new List<CraftBasketSlot>();

		// Token: 0x04000A0D RID: 2573
		private readonly List<CraftItemSlot> iom = new List<CraftItemSlot>();

		// Token: 0x04000A0E RID: 2574
		private readonly Queue<CraftItemSlot> ion = new Queue<CraftItemSlot>();

		// Token: 0x04000A0F RID: 2575
		private readonly List<CraftPanel.ff> ioo = new List<CraftPanel.ff>();

		// Token: 0x04000A10 RID: 2576
		private readonly List<ItemData> iop = new List<ItemData>();

		// Token: 0x04000A11 RID: 2577
		private readonly Dictionary<ulong, CraftPanel.ff> ioq = new Dictionary<ulong, CraftPanel.ff>();

		// Token: 0x04000A12 RID: 2578
		private readonly Dictionary<int, CraftPanel.ff> ior = new Dictionary<int, CraftPanel.ff>();

		// Token: 0x04000A13 RID: 2579
		private readonly Queue<CraftPanel.ff> ios = new Queue<CraftPanel.ff>();

		// Token: 0x04000A14 RID: 2580
		private readonly Queue<List<ItemData>> iot = new Queue<List<ItemData>>();

		// Token: 0x04000A15 RID: 2581
		private readonly Dictionary<int, int> iou = new Dictionary<int, int>();

		// Token: 0x04000A16 RID: 2582
		private int iov;

		// Token: 0x04000A17 RID: 2583
		private bool iow;

		// Token: 0x04000A18 RID: 2584
		[TupleElementNames(new string[] { "instanceId", "quantity" })]
		private readonly HashSet<ValueTuple<ulong, uint>> iox = new HashSet<ValueTuple<ulong, uint>>();

		// Token: 0x04000A19 RID: 2585
		[TupleElementNames(new string[] { "instanceId", "quantity" })]
		private readonly HashSet<ValueTuple<ulong, uint>> ioy = new HashSet<ValueTuple<ulong, uint>>();

		// Token: 0x04000A1A RID: 2586
		private bool ioz;

		// Token: 0x04000A1B RID: 2587
		private int ipa;

		// Token: 0x04000A1C RID: 2588
		private readonly List<CraftPanel.ff> ipb = new List<CraftPanel.ff>();

		// Token: 0x04000A1D RID: 2589
		private readonly HashSet<ulong> ipc = new HashSet<ulong>(128);

		// Token: 0x04000A1E RID: 2590
		private readonly HashSet<int> ipd = new HashSet<int>(64);

		// Token: 0x04000A1F RID: 2591
		private readonly Dictionary<int, bool> ipe = new Dictionary<int, bool>(128);

		// Token: 0x04000A20 RID: 2592
		private readonly Dictionary<string, int> ipf = new Dictionary<string, int>(8, StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000A21 RID: 2593
		private Comparison<CraftPanel.ff> ipg;

		// Token: 0x04000A22 RID: 2594
		private const string iph = "Craft";

		// Token: 0x02000109 RID: 265
		private sealed class ff
		{
			// Token: 0x04000A23 RID: 2595
			public int inq;

			// Token: 0x04000A24 RID: 2596
			public string inr;

			// Token: 0x04000A25 RID: 2597
			public int ins;

			// Token: 0x04000A26 RID: 2598
			public List<ItemData> @int;

			// Token: 0x04000A27 RID: 2599
			public ItemData inu;
		}
	}
}
