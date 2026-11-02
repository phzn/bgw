using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Steamworks;
using UnityEngine;

namespace RamenCat
{
	// Token: 0x020000E4 RID: 228
	public sealed class SteamInventoryManager : MonoBehaviour
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x0005630C File Offset: 0x0005450C
		// (set) Token: 0x06001191 RID: 4497 RVA: 0x00056313 File Offset: 0x00054513
		public static SteamInventoryManager iid { get; private set; }

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06001192 RID: 4498 RVA: 0x0005631C File Offset: 0x0005451C
		// (remove) Token: 0x06001193 RID: 4499 RVA: 0x00056354 File Offset: 0x00054554
		public event Action<IReadOnlyList<ItemData>> iie;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06001194 RID: 4500 RVA: 0x0005638C File Offset: 0x0005458C
		// (remove) Token: 0x06001195 RID: 4501 RVA: 0x000563C4 File Offset: 0x000545C4
		public event Action<ItemData> iif;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06001196 RID: 4502 RVA: 0x000563FC File Offset: 0x000545FC
		// (remove) Token: 0x06001197 RID: 4503 RVA: 0x00056434 File Offset: 0x00054634
		public event Action<ItemData, string> iig;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06001198 RID: 4504 RVA: 0x0005646C File Offset: 0x0005466C
		// (remove) Token: 0x06001199 RID: 4505 RVA: 0x000564A4 File Offset: 0x000546A4
		public event Action<string, EResult> iih;

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x0600119A RID: 4506 RVA: 0x000564DC File Offset: 0x000546DC
		// (remove) Token: 0x0600119B RID: 4507 RVA: 0x00056514 File Offset: 0x00054714
		public event Action<IReadOnlyList<ItemData>> iii;

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x0600119C RID: 4508 RVA: 0x0005654C File Offset: 0x0005474C
		// (remove) Token: 0x0600119D RID: 4509 RVA: 0x00056580 File Offset: 0x00054780
		public static event Action iij;

		// Token: 0x0600119E RID: 4510 RVA: 0x000565B4 File Offset: 0x000547B4
		private void Awake()
		{
			if (SteamInventoryManager.iid != null && SteamInventoryManager.iid != this)
			{
				global::UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			SteamInventoryManager.iid = this;
			global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			SteamManager.ibn -= this.cpf;
			SteamManager.ibn += this.cpf;
			bool flag = SteamManager.krd;
			if (flag && !this.ijb)
			{
				this.cpe();
				this.ijb = true;
				bq.hmf = false;
				Debug.Log(a.dnc());
				return;
			}
			if (!flag)
			{
				Debug.LogWarning(a.dnd());
			}
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00056656 File Offset: 0x00054856
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStaticEvents()
		{
			SteamInventoryManager.iij = null;
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00056660 File Offset: 0x00054860
		private void Update()
		{
			if (!this.ijb)
			{
				return;
			}
			this.cpj();
			if (this._autoRefreshInterval > 0f)
			{
				this.ija += Time.unscaledDeltaTime;
				if (this.ija >= this._autoRefreshInterval)
				{
					this.ija = 0f;
					this.cpl();
				}
			}
			this.ije += Time.unscaledDeltaTime;
			if (this.ije >= 1f)
			{
				this.ije = 0f;
				this.cpi();
				this.cph();
			}
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x000566F0 File Offset: 0x000548F0
		private void OnDestroy()
		{
			SteamManager.ibn -= this.cpf;
			if (this.ijj)
			{
				int num = this.ijl + this.ijm;
				int num2 = this.ijk - num;
				if (num2 > 0)
				{
					this.ijm += num2;
				}
				Debug.LogWarning(string.Format(a.dne(), this.ijm, num, this.ijk));
				this.cpy();
			}
			Callback<SteamInventoryResultReady_t> callback = this.iik;
			if (callback != null)
			{
				callback.Dispose();
			}
			Callback<SteamInventoryFullUpdate_t> callback2 = this.iil;
			if (callback2 != null)
			{
				callback2.Dispose();
			}
			Callback<SteamInventoryDefinitionUpdate_t> callback3 = this.iim;
			if (callback3 != null)
			{
				callback3.Dispose();
			}
			this.cpg();
			this.iji = false;
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x000567B0 File Offset: 0x000549B0
		private void cpe()
		{
			this.iik = Callback<SteamInventoryResultReady_t>.Create(new Callback<SteamInventoryResultReady_t>.DispatchDelegate(this.cqc));
			this.iil = Callback<SteamInventoryFullUpdate_t>.Create(new Callback<SteamInventoryFullUpdate_t>.DispatchDelegate(this.cqd));
			this.iim = Callback<SteamInventoryDefinitionUpdate_t>.Create(new Callback<SteamInventoryDefinitionUpdate_t>.DispatchDelegate(this.cqe));
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x00056802 File Offset: 0x00054A02
		private void cpf()
		{
			if (this.ijb)
			{
				return;
			}
			if (!SteamManager.krd)
			{
				return;
			}
			this.cpe();
			this.ijb = true;
			bq.hmf = false;
			this.cpl();
			Debug.Log(a.dnf());
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x00056838 File Offset: 0x00054A38
		private void cpg()
		{
			if (!SteamManager.krf)
			{
				this.iin.Clear();
				return;
			}
			foreach (KeyValuePair<int, SteamInventoryManager.em> keyValuePair in this.iin)
			{
				SteamInventory.DestroyResult(keyValuePair.Value.igo);
			}
			this.iin.Clear();
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x000568B4 File Offset: 0x00054AB4
		private void cph()
		{
			if (this.iip.Count == 0)
			{
				return;
			}
			DateTime utcNow = DateTime.UtcNow;
			double num = (double)this._requestTimeout * 2.0;
			List<int> list = null;
			object obj = this.ijd;
			lock (obj)
			{
				for (int i = 0; i < this.iip.Count; i++)
				{
					SteamInventoryManager.en en = this.iip[i];
					if ((utcNow - en.ihc).TotalSeconds > num)
					{
						if (list == null)
						{
							list = new List<int>();
						}
						list.Add(en.iha);
					}
				}
			}
			if (list == null)
			{
				return;
			}
			foreach (int num2 in list)
			{
				Debug.LogWarning(string.Format(a.dng(), num2, num));
				this.cqn(num2);
			}
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x000569D4 File Offset: 0x00054BD4
		private void cpi()
		{
			this.ijc.Clear();
			foreach (KeyValuePair<int, SteamInventoryManager.em> keyValuePair in this.iin)
			{
				if ((DateTime.UtcNow - keyValuePair.Value.igq).TotalSeconds > (double)this._requestTimeout)
				{
					this.ijc.Add(keyValuePair.Key);
				}
			}
			foreach (int num in this.ijc)
			{
				SteamInventoryManager.em em = this.iin[num];
				Debug.LogWarning(string.Format(a.dnh(), em.igp, num));
				SteamInventory.DestroyResult(em.igo);
				this.iin.Remove(num);
				if (em.igv != null)
				{
					this.cqn(em.igv.Value);
				}
				Action<string, EResult> action = this.iih;
				if (action != null)
				{
					action(em.igp, EResult.k_EResultTimeout);
				}
				try
				{
					Action<bool, EResult> igu = em.igu;
					if (igu != null)
					{
						igu(false, EResult.k_EResultTimeout);
					}
				}
				catch (Exception ex)
				{
					Debug.LogError(string.Format(a.dni(), ex));
				}
			}
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x00056B60 File Offset: 0x00054D60
		private void cpj()
		{
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			DateTime utcNow = DateTime.UtcNow;
			if (this.ijg < 0f)
			{
				this.ijg = realtimeSinceStartup;
				this.ijh = utcNow;
				return;
			}
			double num = (double)(realtimeSinceStartup - this.ijg);
			double num2 = (utcNow - this.ijh).TotalSeconds - num;
			this.ijg = realtimeSinceStartup;
			this.ijh = utcNow;
			if (this.iji || num2 <= this._sleepDetectThresholdSeconds)
			{
				return;
			}
			Debug.LogWarning(string.Format(a.dnj(), num2, this.iin.Count));
			foreach (KeyValuePair<int, SteamInventoryManager.em> keyValuePair in this.iin)
			{
				keyValuePair.Value.igq = utcNow;
			}
			this.iji = true;
			base.StartCoroutine(this.cpk());
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x00056C60 File Offset: 0x00054E60
		private IEnumerator cpk()
		{
			yield return null;
			yield return null;
			try
			{
				try
				{
					Action action = SteamInventoryManager.iij;
					if (action != null)
					{
						action();
					}
				}
				catch (Exception ex)
				{
					Debug.LogError(string.Format(a.dnb(), ex));
				}
				if (this.cqs())
				{
					this.cpl();
				}
				yield break;
			}
			finally
			{
				this.iji = false;
			}
			yield break;
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x00056C70 File Offset: 0x00054E70
		public void cpl()
		{
			if (!this.cqs())
			{
				return;
			}
			SteamInventoryResult_t steamInventoryResult_t;
			if (SteamInventory.GetAllItems(out steamInventoryResult_t))
			{
				this.cqt(steamInventoryResult_t, a.dnk(), new Action(this.cqw), null);
				if (bq.knd)
				{
					Debug.Log(string.Format(a.dnl(), steamInventoryResult_t.m_SteamInventoryResult));
					return;
				}
			}
			else
			{
				Debug.LogError(a.dnm());
				Action<string, EResult> action = this.iih;
				if (action == null)
				{
					return;
				}
				action(a.dnk(), EResult.k_EResultFail);
			}
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x00056CEC File Offset: 0x00054EEC
		public IReadOnlyList<ItemData> cpm()
		{
			object obj = this.ijd;
			IReadOnlyList<ItemData> readOnlyList;
			lock (obj)
			{
				readOnlyList = this.cqo();
			}
			return readOnlyList;
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x00056D30 File Offset: 0x00054F30
		public IReadOnlyList<ItemData> cpn()
		{
			object obj = this.ijd;
			IReadOnlyList<ItemData> readOnlyList;
			lock (obj)
			{
				readOnlyList = this.iio.ToList<ItemData>();
			}
			return readOnlyList;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x00056D78 File Offset: 0x00054F78
		public float kso
		{
			get
			{
				if (this._autoRefreshInterval > 0f)
				{
					return this._autoRefreshInterval - this.ija;
				}
				return -1f;
			}
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00056D9C File Offset: 0x00054F9C
		public void cpp(int a)
		{
			SteamInventoryManager.eo eo = new SteamInventoryManager.eo();
			eo.ihg = this;
			eo.ihh = a;
			if (!this.cqs())
			{
				return;
			}
			SteamInventoryResult_t steamInventoryResult_t;
			if (SteamInventory.TriggerItemDrop(out steamInventoryResult_t, new SteamItemDef_t(eo.ihh)))
			{
				this.cqt(steamInventoryResult_t, string.Format(a.dnn(), eo.ihh), new Action(eo.cny), null);
				if (bq.knd)
				{
					Debug.Log(string.Format(a.dno(), eo.ihh));
					return;
				}
			}
			else
			{
				Debug.LogError(string.Format(a.dnp(), eo.ihh));
				Action<string, EResult> action = this.iih;
				if (action == null)
				{
					return;
				}
				action(string.Format(a.dnn(), eo.ihh), EResult.k_EResultFail);
			}
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00056E68 File Offset: 0x00055068
		public void cpq()
		{
			if (!this.cqs())
			{
				return;
			}
			SteamInventoryResult_t steamInventoryResult_t;
			if (SteamInventory.GrantPromoItems(out steamInventoryResult_t))
			{
				this.cqt(steamInventoryResult_t, a.dnq(), new Action(this.cqx), null);
				if (bq.knd)
				{
					Debug.Log(string.Format(a.dnr(), steamInventoryResult_t.m_SteamInventoryResult));
					return;
				}
			}
			else
			{
				Debug.LogError(a.dns());
				Action<string, EResult> action = this.iih;
				if (action == null)
				{
					return;
				}
				action(a.dnq(), EResult.k_EResultFail);
			}
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00056EE4 File Offset: 0x000550E4
		public void cpr(int a)
		{
			if (!this.cqs())
			{
				return;
			}
			SteamItemDef_t[] array = new SteamItemDef_t[]
			{
				new SteamItemDef_t(a)
			};
			SteamInventoryResult_t steamInventoryResult_t;
			if (SteamInventory.AddPromoItems(out steamInventoryResult_t, array, 1U))
			{
				this.cqt(steamInventoryResult_t, string.Format(a.dnt(), a), null, null);
				if (bq.knd)
				{
					Debug.Log(string.Format(a.dnu(), a));
					return;
				}
			}
			else
			{
				Debug.LogError(string.Format(a.dnv(), a));
				Action<string, EResult> action = this.iih;
				if (action == null)
				{
					return;
				}
				action(string.Format(a.dnt(), a), EResult.k_EResultFail);
			}
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00056F88 File Offset: 0x00055188
		public void cps(ulong a, uint b = 1U)
		{
			if (!this.cqs())
			{
				return;
			}
			SteamInventoryResult_t steamInventoryResult_t;
			if (SteamInventory.ConsumeItem(out steamInventoryResult_t, new SteamItemInstanceID_t(a), b))
			{
				this.cqt(steamInventoryResult_t, string.Format(a.dnw(), a, b), null, null);
				if (bq.knd)
				{
					Debug.Log(string.Format(a.dnx(), a, b));
					return;
				}
			}
			else
			{
				Debug.LogError(a.dny());
				Action<string, EResult> action = this.iih;
				if (action == null)
				{
					return;
				}
				action(string.Format(a.dnz(), a), EResult.k_EResultFail);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x0005701B File Offset: 0x0005521B
		public bool ksp
		{
			get
			{
				return this.ijj;
			}
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00057024 File Offset: 0x00055224
		public void cpu(Action<int, int> a = null, Action<int, int> b = null, float c = 60f)
		{
			if (!this.cqs())
			{
				if (b != null)
				{
					b(-1, -1);
				}
				return;
			}
			if (this.ijj)
			{
				Debug.LogWarning(a.doa());
				if (b != null)
				{
					b(-1, -1);
				}
				return;
			}
			IReadOnlyList<ItemData> readOnlyList = this.cpn();
			int count = readOnlyList.Count;
			if (count == 0)
			{
				Debug.Log(a.dob());
				if (b != null)
				{
					b(0, 0);
				}
				return;
			}
			this.ijj = true;
			this.ijk = count;
			this.ijl = 0;
			this.ijm = 0;
			this.ijn = a;
			this.ijo = b;
			Debug.Log(string.Format(a.doc(), count));
			foreach (ItemData itemData in readOnlyList)
			{
				this.cpv(itemData.itemId, itemData.quantity);
			}
			this.ijp = base.StartCoroutine(this.cpx(c));
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00057124 File Offset: 0x00055324
		private void cpv(ulong a, uint b)
		{
			SteamInventoryResult_t steamInventoryResult_t;
			if (SteamInventory.ConsumeItem(out steamInventoryResult_t, new SteamItemInstanceID_t(a), b))
			{
				int steamInventoryResult = steamInventoryResult_t.m_SteamInventoryResult;
				this.cqt(steamInventoryResult_t, string.Format(a.dod(), a, b), null, new Action<bool, EResult>(this.cpw));
				SteamInventoryManager.em em;
				if (this.iin.TryGetValue(steamInventoryResult, out em))
				{
					em.igt = new Dictionary<ulong, uint> { { a, b } };
					return;
				}
			}
			else
			{
				if (bq.knd)
				{
					Debug.LogWarning(string.Format(a.doe(), a));
				}
				this.cpw(false, EResult.k_EResultFail);
			}
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x000571BC File Offset: 0x000553BC
		private void cpw(bool a, EResult b)
		{
			if (!this.ijj)
			{
				return;
			}
			if (a)
			{
				this.ijl++;
			}
			else
			{
				this.ijm++;
			}
			int num = this.ijl + this.ijm;
			try
			{
				Action<int, int> action = this.ijn;
				if (action != null)
				{
					action(num, this.ijk);
				}
			}
			catch (Exception ex)
			{
				Debug.LogError(string.Format(a.dof(), ex));
			}
			if (num >= this.ijk)
			{
				this.cpy();
			}
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00057250 File Offset: 0x00055450
		private IEnumerator cpx(float a)
		{
			yield return new WaitForSeconds(a);
			if (!this.ijj)
			{
				yield break;
			}
			int num = this.ijl + this.ijm;
			int num2 = this.ijk - num;
			if (num2 > 0)
			{
				this.ijm += num2;
			}
			Debug.LogWarning(string.Format(a.dmz(), new object[] { a, num, this.ijk, num2 }));
			this.cpy();
			yield break;
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00057268 File Offset: 0x00055468
		private void cpy()
		{
			if (!this.ijj)
			{
				return;
			}
			int num = this.ijl;
			int num2 = this.ijm;
			Action<int, int> action = this.ijo;
			this.ijj = false;
			this.ijn = null;
			this.ijo = null;
			this.ijk = 0;
			this.ijl = 0;
			this.ijm = 0;
			if (this.ijp != null)
			{
				base.StopCoroutine(this.ijp);
				this.ijp = null;
			}
			Debug.Log(string.Format(a.dog(), num, num2));
			try
			{
				if (action != null)
				{
					action(num, num2);
				}
			}
			catch (Exception ex)
			{
				Debug.LogError(string.Format(a.doh(), ex));
			}
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00057324 File Offset: 0x00055524
		public bool ExchangeItems([TupleElementNames(new string[] { "defId", "qty" })] ValueTuple<int, uint>[] generate, [TupleElementNames(new string[] { "instanceId", "qty" })] ValueTuple<ulong, uint>[] destroy, string sourceLabel = null, Action<bool, EResult> onComplete = null, int? optimisticOpId = null)
		{
			if (!this.cqs())
			{
				if (optimisticOpId != null)
				{
					this.cqn(optimisticOpId.Value);
				}
				if (onComplete != null)
				{
					onComplete(false, EResult.k_EResultFail);
				}
				return false;
			}
			if (generate == null || generate.Length == 0 || destroy == null || destroy.Length == 0)
			{
				if (bq.knd)
				{
					Debug.LogWarning(a.doi());
				}
				if (optimisticOpId != null)
				{
					this.cqn(optimisticOpId.Value);
				}
				if (onComplete != null)
				{
					onComplete(false, EResult.k_EResultInvalidParam);
				}
				return false;
			}
			SteamItemDef_t[] array = generate.Select<ValueTuple<int, uint>, SteamItemDef_t>(new Func<ValueTuple<int, uint>, SteamItemDef_t>(SteamInventoryManager.<>c.<>9.cnr)).ToArray<SteamItemDef_t>();
			uint[] array2 = generate.Select<ValueTuple<int, uint>, uint>(new Func<ValueTuple<int, uint>, uint>(SteamInventoryManager.<>c.<>9.cns)).ToArray<uint>();
			SteamItemInstanceID_t[] array3 = destroy.Select<ValueTuple<ulong, uint>, SteamItemInstanceID_t>(new Func<ValueTuple<ulong, uint>, SteamItemInstanceID_t>(SteamInventoryManager.<>c.<>9.cnt)).ToArray<SteamItemInstanceID_t>();
			uint[] array4 = destroy.Select<ValueTuple<ulong, uint>, uint>(new Func<ValueTuple<ulong, uint>, uint>(SteamInventoryManager.<>c.<>9.cnu)).ToArray<uint>();
			SteamInventoryResult_t steamInventoryResult_t;
			if (SteamInventory.ExchangeItems(out steamInventoryResult_t, array, array2, (uint)array.Length, array3, array4, (uint)array3.Length))
			{
				string text = (string.IsNullOrEmpty(sourceLabel) ? string.Format(a.doj(), generate.Length, destroy.Length) : sourceLabel);
				this.cqt(steamInventoryResult_t, text, null, onComplete);
				SteamInventoryManager.em em;
				if (this.iin.TryGetValue(steamInventoryResult_t.m_SteamInventoryResult, out em))
				{
					Dictionary<ulong, uint> dictionary = new Dictionary<ulong, uint>(destroy.Length);
					foreach (ValueTuple<ulong, uint> valueTuple in destroy)
					{
						ulong item = valueTuple.Item1;
						uint item2 = valueTuple.Item2;
						uint num;
						dictionary.TryGetValue(item, out num);
						dictionary[item] = num + item2;
					}
					em.igt = dictionary;
					em.igv = optimisticOpId;
				}
				if (bq.knd)
				{
					StringBuilder stringBuilder = new StringBuilder();
					object obj = this.ijd;
					lock (obj)
					{
						foreach (ValueTuple<ulong, uint> valueTuple2 in destroy)
						{
							ulong item3 = valueTuple2.Item1;
							uint item4 = valueTuple2.Item2;
							ItemData itemData = null;
							for (int j = 0; j < this.iio.Count; j++)
							{
								if (this.iio[j].itemId == item3)
								{
									itemData = this.iio[j];
									break;
								}
							}
							if (itemData == null)
							{
								stringBuilder.AppendLine(string.Format(a.dok(), item3, item4));
							}
							else
							{
								uint num2 = 1024U;
								string text2;
								SteamInventory.GetItemDefinitionProperty(new SteamItemDef_t(itemData.defID), a.dol(), out text2, ref num2);
								string text3 = a.dom() + (itemData.rarity ?? a.tk()).ToLowerInvariant() + a.don();
								bool flag2 = !string.IsNullOrEmpty(text2) && text2.Contains(text3);
								string text4 = (flag2 ? a.dop() : a.doo());
								stringBuilder.AppendLine(string.Format(a.doq(), new object[] { text4, item3, item4, itemData.defID, itemData.rarity, itemData.category }));
								if (!flag2)
								{
									stringBuilder.AppendLine(string.Concat(new string[]
									{
										a.dor(),
										text3,
										a.dos(),
										text2,
										a.eg()
									}));
								}
							}
						}
					}
					string text5 = a.dot();
					object[] array5 = new object[5];
					array5[0] = text;
					array5[1] = string.Join(a.dou(), generate.Select<ValueTuple<int, uint>, string>(new Func<ValueTuple<int, uint>, string>(SteamInventoryManager.<>c.<>9.cnv)));
					array5[2] = destroy.Length;
					array5[3] = destroy.Sum<ValueTuple<ulong, uint>>(new Func<ValueTuple<ulong, uint>, long>(SteamInventoryManager.<>c.<>9.cnw));
					array5[4] = stringBuilder;
					Debug.Log(string.Format(text5, array5));
				}
				return true;
			}
			if (bq.knd)
			{
				Debug.LogError(a.dov());
			}
			if (optimisticOpId != null)
			{
				this.cqn(optimisticOpId.Value);
			}
			Action<string, EResult> action = this.iih;
			if (action != null)
			{
				action(sourceLabel ?? a.dow(), EResult.k_EResultFail);
			}
			if (onComplete != null)
			{
				onComplete(false, EResult.k_EResultFail);
			}
			return false;
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x000577E4 File Offset: 0x000559E4
		public bool cpz(int a, [TupleElementNames(new string[] { "instanceId", "qty" })] ValueTuple<ulong, uint>[] destroyPairs, float b, Action<bool, EResult> c)
		{
			int num;
			return this.cqa(a, destroyPairs, b, c, out num);
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00057800 File Offset: 0x00055A00
		public bool cqa(int a, [TupleElementNames(new string[] { "instanceId", "qty" })] ValueTuple<ulong, uint>[] destroyPairs, float b, Action<bool, EResult> c, out int d)
		{
			SteamInventoryManager.ep ep = new SteamInventoryManager.ep();
			ep.ihj = this;
			ep.ihk = c;
			d = 0;
			if (this.ijq)
			{
				if (bq.knd)
				{
					Debug.LogWarning(a.dox());
				}
				return false;
			}
			if (destroyPairs == null || destroyPairs.Length == 0)
			{
				Debug.LogError(a.doy());
				return false;
			}
			this.ijq = true;
			List<ValueTuple<ulong, int, int?>> list = new List<ValueTuple<ulong, int, int?>>(destroyPairs.Length);
			foreach (ValueTuple<ulong, uint> valueTuple in destroyPairs)
			{
				ulong item = valueTuple.Item1;
				uint item2 = valueTuple.Item2;
				list.Add(new ValueTuple<ulong, int, int?>(item, (int)(-(int)item2), null));
			}
			d = this.cql(list, a.doz());
			ValueTuple<int, uint>[] array = new ValueTuple<int, uint>[]
			{
				new ValueTuple<int, uint>(a, 1U)
			};
			SteamInventoryManager.ep ep2 = ep;
			int i = this.ijr + 1;
			this.ijr = i;
			ep2.ihi = i;
			int num = d;
			base.StartCoroutine(this.cqb(ep.ihi, b, num, ep.ihk));
			this.ExchangeItems(array, destroyPairs, a.doz(), new Action<bool, EResult>(ep.cnz), new int?(d));
			return true;
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x0005792C File Offset: 0x00055B2C
		private IEnumerator cqb(int a, float b, int c, Action<bool, EResult> d)
		{
			yield return new WaitForSeconds(b);
			if (a != this.ijr)
			{
				yield break;
			}
			Debug.LogError(string.Format(a.dna(), b, c));
			this.ijr++;
			this.ijq = false;
			if (c > 0)
			{
				this.cqn(c);
			}
			if (d != null)
			{
				d(false, EResult.k_EResultTimeout);
			}
			yield break;
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00057958 File Offset: 0x00055B58
		private void cqc(SteamInventoryResultReady_t a)
		{
			bool flag = a.m_result == EResult.k_EResultOK;
			int steamInventoryResult = a.m_handle.m_SteamInventoryResult;
			SteamInventoryManager.em em;
			if (!this.iin.TryGetValue(steamInventoryResult, out em))
			{
				if (bq.knd)
				{
					Debug.LogWarning(string.Format(a.dpa(), steamInventoryResult));
				}
				SteamInventory.DestroyResult(a.m_handle);
				return;
			}
			if (bq.knd)
			{
				Debug.Log(string.Format(a.dpb(), steamInventoryResult, em.igp) + string.Format(a.dpc(), a.m_result, flag ? a.dpe() : a.dpd()));
			}
			if (!flag)
			{
				this.cqj(em, a.m_result);
				return;
			}
			this.cqf(a.m_handle, em);
			if (em.igv != null)
			{
				this.cqm(em.igv.Value);
			}
			try
			{
				Action<bool, EResult> igu = em.igu;
				if (igu != null)
				{
					igu(true, EResult.k_EResultOK);
				}
			}
			catch (Exception ex)
			{
				Debug.LogError(string.Format(a.dpf(), ex));
			}
			this.iin.Remove(steamInventoryResult);
			SteamInventory.DestroyResult(a.m_handle);
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00057A8C File Offset: 0x00055C8C
		private void cqd(SteamInventoryFullUpdate_t a)
		{
			if (bq.knd)
			{
				Debug.Log(string.Format(a.dpg(), a.m_handle));
			}
			SteamItemDetails_t[] array;
			if (this.cqu(a.m_handle, out array))
			{
				this.cqg(array);
				return;
			}
			if (bq.knd)
			{
				Debug.LogWarning(a.dph());
			}
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00057AE3 File Offset: 0x00055CE3
		private void cqe(SteamInventoryDefinitionUpdate_t a)
		{
			if (bq.knd)
			{
				Debug.Log(a.dpi());
			}
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x00057AF8 File Offset: 0x00055CF8
		private void cqf(SteamInventoryResult_t a, SteamInventoryManager.em b)
		{
			SteamItemDetails_t[] array;
			if (!this.cqu(a, out array))
			{
				if (bq.knd)
				{
					Debug.LogError(a.dpj() + b.igp);
				}
				if (b.igp != a.dnk() && this.ijb)
				{
					Debug.LogWarning(a.dpk() + b.igp + a.dpl());
					this.cpl();
				}
				return;
			}
			if (b.igp == a.dnk())
			{
				this.cqg(array);
				return;
			}
			if (b.igp == a.dnq())
			{
				this.cqh(array);
				return;
			}
			this.cqi(array, b);
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x00057BA4 File Offset: 0x00055DA4
		private void cqg(SteamItemDetails_t[] a)
		{
			object obj = this.ijd;
			IReadOnlyList<ItemData> readOnlyList;
			lock (obj)
			{
				this.iio.Clear();
				this.iiy.Clear();
				this.cqp();
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				for (int i = 0; i < a.Length; i++)
				{
					ItemData itemData = new ItemData(a[i]);
					int num4;
					if (itemData.quantity == 0U)
					{
						num++;
					}
					else if (this.iiy.TryGetValue(itemData.itemId, out num4))
					{
						ItemData itemData2 = this.iio[num4];
						if (itemData2.defID != itemData.defID)
						{
							Debug.LogError(string.Format(a.dpm(), itemData.itemId, itemData2.defID, itemData.defID));
							num3++;
						}
						else
						{
							Debug.LogWarning(string.Format(a.dpn(), new object[] { itemData.itemId, itemData.defID, itemData2.quantity, itemData2.flags, itemData.quantity, itemData.flags }));
							num2++;
							if (itemData.quantity > itemData2.quantity)
							{
								this.iio[num4] = itemData;
								this.cqv(itemData);
							}
						}
					}
					else
					{
						this.iiy[itemData.itemId] = this.iio.Count;
						this.iio.Add(itemData);
						this.cqv(itemData);
					}
				}
				if (bq.knd)
				{
					Debug.Log(string.Format(a.dpo(), new object[]
					{
						this.iio.Count,
						this.iip.Count,
						num,
						num2,
						num3
					}));
				}
				this.cqq();
				readOnlyList = this.cqo();
			}
			bq.hmf = true;
			Action<IReadOnlyList<ItemData>> action = this.iie;
			if (action == null)
			{
				return;
			}
			action(readOnlyList);
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x00057E18 File Offset: 0x00056018
		private void cqh(SteamItemDetails_t[] a)
		{
			if (a.Length == 0)
			{
				Debug.Log(a.dpp());
				return;
			}
			List<ItemData> list = new List<ItemData>();
			for (int i = 0; i < a.Length; i++)
			{
				ItemData itemData = new ItemData(a[i]);
				this.cqv(itemData);
				list.Add(itemData);
				Action<ItemData> action = this.iif;
				if (action != null)
				{
					action(itemData);
				}
				Action<ItemData, string> action2 = this.iig;
				if (action2 != null)
				{
					action2(itemData, a.dnq());
				}
			}
			Debug.Log(string.Format(a.dpq(), list.Count));
			Action<IReadOnlyList<ItemData>> action3 = this.iii;
			if (action3 != null)
			{
				action3(list);
			}
			this.cpl();
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00057EC0 File Offset: 0x000560C0
		private void cqi(SteamItemDetails_t[] a, SteamInventoryManager.em b)
		{
			string igp = b.igp;
			Dictionary<ulong, uint> igt = b.igt;
			object obj = this.ijd;
			Dictionary<ulong, uint> dictionary;
			lock (obj)
			{
				dictionary = new Dictionary<ulong, uint>(this.iio.Count);
				foreach (ItemData itemData in this.iio)
				{
					dictionary[itemData.itemId] = itemData.quantity;
				}
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			this.iiz.Clear();
			for (int i = 0; i < a.Length; i++)
			{
				ItemData itemData2 = new ItemData(a[i]);
				bool flag2 = (itemData2.flags & (ESteamItemFlags.k_ESteamItemRemoved | ESteamItemFlags.k_ESteamItemConsumed)) > (ESteamItemFlags)0;
				uint num4;
				dictionary.TryGetValue(itemData2.itemId, out num4);
				uint num5;
				long num6;
				bool flag4;
				if (igt != null && igt.TryGetValue(itemData2.itemId, out num5))
				{
					num6 = Math.Max(0L, (long)((ulong)num4 - (ulong)num5));
					bool flag3 = (ulong)itemData2.quantity > (ulong)num6;
					flag4 = flag2 || !flag3;
					if (flag3 && !flag2 && bq.knd)
					{
						Debug.Log(string.Format(a.dpr(), new object[] { itemData2.itemId, itemData2.defID, num4, num5, num6, itemData2.quantity, itemData2.flags, igp }));
					}
				}
				else
				{
					num6 = -1L;
					flag4 = flag2;
				}
				if (flag4)
				{
					if (bq.knd)
					{
						Debug.Log(string.Format(a.dps(), new object[] { igp, itemData2, itemData2.flags, num4, itemData2.quantity, num6 }));
					}
					num2++;
				}
				else if (!this.iiz.Add(itemData2.itemId))
				{
					Debug.LogWarning(string.Format(a.dpt(), itemData2.itemId, itemData2.defID, igp));
					num3++;
					num++;
				}
				else
				{
					this.cqv(itemData2);
					Action<ItemData> action = this.iif;
					if (action != null)
					{
						action(itemData2);
					}
					Action<ItemData, string> action2 = this.iig;
					if (action2 != null)
					{
						action2(itemData2, igp);
					}
					num++;
				}
			}
			if (bq.knd)
			{
				Debug.Log(string.Format(a.dpu(), new object[] { a.Length, igp, num, num2, num3 }));
			}
			if (num > 0 && this.ijb)
			{
				if (bq.knd)
				{
					Debug.Log(string.Format(a.dpv(), num, igp));
				}
				this.cpl();
			}
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00058204 File Offset: 0x00056404
		private void cqj(SteamInventoryManager.em a, EResult b)
		{
			this.iin.Remove(a.igo.m_SteamInventoryResult);
			SteamInventory.DestroyResult(a.igo);
			a.igr++;
			if (a.igr < this._maxRetries && a.igs != null)
			{
				float num = Mathf.Pow(2f, (float)a.igr);
				Debug.LogWarning(a.dpw() + a.igp + a.m() + string.Format(a.dpx(), a.igr + 1, this._maxRetries, num));
				base.StartCoroutine(this.cqk(a.igs, num));
				return;
			}
			Debug.LogError(string.Format(a.dpy(), a.igp, a.igr) + string.Format(a.dpz(), b));
			if (a.igv != null)
			{
				this.cqn(a.igv.Value);
			}
			Action<string, EResult> action = this.iih;
			if (action != null)
			{
				action(a.igp, b);
			}
			try
			{
				Action<bool, EResult> igu = a.igu;
				if (igu != null)
				{
					igu(false, b);
				}
			}
			catch (Exception ex)
			{
				Debug.LogError(string.Format(a.dpf(), ex));
			}
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00058368 File Offset: 0x00056568
		private IEnumerator cqk(Action a, float b)
		{
			yield return new WaitForSeconds(b);
			if (a != null)
			{
				a();
			}
			yield break;
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00058380 File Offset: 0x00056580
		public int cql([TupleElementNames(new string[] { "InstanceId", "SignedDelta", "DefIdIfNew" })] IReadOnlyList<ValueTuple<ulong, int, int?>> deltas, string a)
		{
			if (deltas == null || deltas.Count == 0)
			{
				return 0;
			}
			object obj = this.ijd;
			int num3;
			IReadOnlyList<ItemData> readOnlyList;
			lock (obj)
			{
				List<SteamInventoryManager.InventoryDelta> list = new List<SteamInventoryManager.InventoryDelta>(deltas.Count);
				foreach (ValueTuple<ulong, int, int?> valueTuple in deltas)
				{
					uint num = this.cqr(valueTuple.Item1);
					list.Add(new SteamInventoryManager.InventoryDelta(valueTuple.Item1, valueTuple.Item2, valueTuple.Item3, num));
				}
				int num2 = this.iiq + 1;
				this.iiq = num2;
				num3 = num2;
				this.iip.Add(new SteamInventoryManager.en
				{
					iha = num3,
					ihb = (a ?? a.dqa()),
					ihc = DateTime.UtcNow,
					ihd = list,
					ihe = null,
					ihf = false
				});
				this.cqp();
				if (bq.knd)
				{
					Debug.Log(string.Format(a.dqb(), num3, a, deltas.Count));
				}
				readOnlyList = this.cqo();
			}
			Action<IReadOnlyList<ItemData>> action = this.iie;
			if (action != null)
			{
				action(readOnlyList);
			}
			return num3;
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00058500 File Offset: 0x00056700
		public bool cqm(int a)
		{
			if (a <= 0)
			{
				return false;
			}
			object obj = this.ijd;
			lock (obj)
			{
				for (int i = 0; i < this.iip.Count; i++)
				{
					if (this.iip[i].iha == a)
					{
						this.iip[i].ihf = true;
						if (bq.knd)
						{
							Debug.Log(string.Format(a.dqc(), a));
						}
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x000585A0 File Offset: 0x000567A0
		public bool cqn(int a)
		{
			if (a <= 0)
			{
				return false;
			}
			bool flag = false;
			IReadOnlyList<ItemData> readOnlyList = null;
			object obj = this.ijd;
			lock (obj)
			{
				int i = 0;
				while (i < this.iip.Count)
				{
					if (this.iip[i].iha == a)
					{
						this.iip.RemoveAt(i);
						this.cqp();
						flag = true;
						if (bq.knd)
						{
							Debug.Log(string.Format(a.dqd(), a));
							break;
						}
						break;
					}
					else
					{
						i++;
					}
				}
				if (flag)
				{
					readOnlyList = this.cqo();
				}
			}
			if (flag)
			{
				Action<IReadOnlyList<ItemData>> action = this.iie;
				if (action != null)
				{
					action(readOnlyList);
				}
			}
			return flag;
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00058668 File Offset: 0x00056868
		private IReadOnlyList<ItemData> cqo()
		{
			if (!this.iis && this.iir != null)
			{
				return this.iir;
			}
			if (this.iip.Count == 0)
			{
				this.iiw.Clear();
				for (int i = 0; i < this.iio.Count; i++)
				{
					ItemData itemData = this.iio[i];
					if (itemData != null && itemData.quantity != 0U)
					{
						this.iiw.Add(itemData);
					}
				}
				this.iir = new List<ItemData>(this.iiw).AsReadOnly();
				this.iis = false;
				return this.iir;
			}
			this.iiw.Clear();
			this.iit.Clear();
			this.iiu.Clear();
			this.iiv.Clear();
			for (int j = 0; j < this.iio.Count; j++)
			{
				ItemData itemData2 = this.iio[j];
				this.iiw.Add(itemData2);
				this.iit[itemData2.itemId] = j;
				this.iiu[itemData2.itemId] = itemData2.quantity;
			}
			foreach (SteamInventoryManager.en en in this.iip)
			{
				foreach (SteamInventoryManager.InventoryDelta inventoryDelta in en.ihd)
				{
					int num;
					if (this.iit.TryGetValue(inventoryDelta.igw, out num))
					{
						long num2 = (long)((ulong)inventoryDelta.igz + (ulong)((long)inventoryDelta.igx));
						if (num2 < 0L)
						{
							num2 = 0L;
						}
						uint num3 = this.iiu[inventoryDelta.igw];
						if ((inventoryDelta.igx >= 0 || (ulong)num3 > (ulong)num2) && (inventoryDelta.igx <= 0 || (ulong)num3 < (ulong)num2))
						{
							ItemData itemData3 = this.iiw[num];
							if (!this.iiv.Contains(inventoryDelta.igw))
							{
								ItemData itemData4 = new ItemData();
								itemData3.biw(itemData4);
								itemData3 = itemData4;
								this.iiw[num] = itemData3;
								this.iiv.Add(inventoryDelta.igw);
							}
							long num4 = (long)((ulong)itemData3.quantity + (ulong)((long)inventoryDelta.igx));
							itemData3.quantity = ((num4 <= 0L) ? 0U : ((uint)num4));
						}
					}
				}
			}
			this.iiw.RemoveAll(SteamInventoryManager.ijs);
			this.iir = new List<ItemData>(this.iiw).AsReadOnly();
			this.iis = false;
			return this.iir;
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00058948 File Offset: 0x00056B48
		private void cqp()
		{
			this.iis = true;
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00058954 File Offset: 0x00056B54
		private void cqq()
		{
			if (this.iip.Count == 0)
			{
				return;
			}
			this.iix.Clear();
			for (int i = 0; i < this.iio.Count; i++)
			{
				this.iix[this.iio[i].itemId] = this.iio[i].quantity;
			}
			bool flag = false;
			for (int j = this.iip.Count - 1; j >= 0; j--)
			{
				SteamInventoryManager.en en = this.iip[j];
				if (en.ihf)
				{
					bool flag2 = true;
					foreach (SteamInventoryManager.InventoryDelta inventoryDelta in en.ihd)
					{
						uint num;
						this.iix.TryGetValue(inventoryDelta.igw, out num);
						long num2 = (long)((ulong)inventoryDelta.igz + (ulong)((long)inventoryDelta.igx));
						if (num2 < 0L)
						{
							num2 = 0L;
						}
						if (inventoryDelta.igx < 0)
						{
							if ((ulong)num > (ulong)num2)
							{
								flag2 = false;
								break;
							}
						}
						else if (inventoryDelta.igx > 0 && (ulong)num < (ulong)num2)
						{
							flag2 = false;
							break;
						}
					}
					if (flag2)
					{
						if (bq.knd)
						{
							Debug.Log(string.Format(a.dqe(), en.iha, en.ihb));
						}
						this.iip.RemoveAt(j);
						flag = true;
					}
				}
			}
			if (flag)
			{
				this.cqp();
			}
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00058AD8 File Offset: 0x00056CD8
		private uint cqr(ulong a)
		{
			long num = 0L;
			for (int i = 0; i < this.iio.Count; i++)
			{
				if (this.iio[i].itemId == a)
				{
					num = (long)((ulong)this.iio[i].quantity);
					break;
				}
			}
			foreach (SteamInventoryManager.en en in this.iip)
			{
				foreach (SteamInventoryManager.InventoryDelta inventoryDelta in en.ihd)
				{
					if (inventoryDelta.igw == a)
					{
						num = Math.Max(0L, num + (long)inventoryDelta.igx);
					}
				}
			}
			return (uint)num;
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00058BB8 File Offset: 0x00056DB8
		private bool cqs()
		{
			if (!this.ijb || !SteamManager.krd || SteamManager.ibh)
			{
				Debug.LogError(a.dqf());
				return false;
			}
			return true;
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00058BE0 File Offset: 0x00056DE0
		private void cqt(SteamInventoryResult_t a, string b, Action c = null, Action<bool, EResult> d = null)
		{
			int steamInventoryResult = a.m_SteamInventoryResult;
			this.iin[steamInventoryResult] = new SteamInventoryManager.em(a, b, c, d);
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00058C0C File Offset: 0x00056E0C
		private bool cqu(SteamInventoryResult_t a, out SteamItemDetails_t[] b)
		{
			b = null;
			uint num = 0U;
			if (!SteamInventory.GetResultItems(a, null, ref num))
			{
				Debug.LogError(a.dqg());
				return false;
			}
			if (num == 0U)
			{
				b = Array.Empty<SteamItemDetails_t>();
				return true;
			}
			b = new SteamItemDetails_t[num];
			if (!SteamInventory.GetResultItems(a, b, ref num))
			{
				Debug.LogError(a.dqh());
				return false;
			}
			return true;
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00058C62 File Offset: 0x00056E62
		private void cqv(ItemData a)
		{
			if (bq.hll)
			{
				Debug.Log(string.Format(a.dqi(), a));
			}
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00058D68 File Offset: 0x00056F68
		[CompilerGenerated]
		private void cqw()
		{
			this.cpl();
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00058D70 File Offset: 0x00056F70
		[CompilerGenerated]
		private void cqx()
		{
			this.cpq();
		}

		// Token: 0x04000907 RID: 2311
		[SerializeField]
		private float _autoRefreshInterval;

		// Token: 0x04000908 RID: 2312
		[SerializeField]
		private int _maxRetries = 3;

		// Token: 0x04000909 RID: 2313
		[SerializeField]
		private float _requestTimeout = 30f;

		// Token: 0x0400090A RID: 2314
		private Callback<SteamInventoryResultReady_t> iik;

		// Token: 0x0400090B RID: 2315
		private Callback<SteamInventoryFullUpdate_t> iil;

		// Token: 0x0400090C RID: 2316
		private Callback<SteamInventoryDefinitionUpdate_t> iim;

		// Token: 0x0400090D RID: 2317
		private readonly Dictionary<int, SteamInventoryManager.em> iin = new Dictionary<int, SteamInventoryManager.em>();

		// Token: 0x0400090E RID: 2318
		private readonly List<ItemData> iio = new List<ItemData>();

		// Token: 0x0400090F RID: 2319
		private readonly List<SteamInventoryManager.en> iip = new List<SteamInventoryManager.en>();

		// Token: 0x04000910 RID: 2320
		private int iiq;

		// Token: 0x04000911 RID: 2321
		private IReadOnlyList<ItemData> iir;

		// Token: 0x04000912 RID: 2322
		private bool iis = true;

		// Token: 0x04000913 RID: 2323
		private readonly Dictionary<ulong, int> iit = new Dictionary<ulong, int>();

		// Token: 0x04000914 RID: 2324
		private readonly Dictionary<ulong, uint> iiu = new Dictionary<ulong, uint>();

		// Token: 0x04000915 RID: 2325
		private readonly HashSet<ulong> iiv = new HashSet<ulong>();

		// Token: 0x04000916 RID: 2326
		private readonly List<ItemData> iiw = new List<ItemData>();

		// Token: 0x04000917 RID: 2327
		private readonly Dictionary<ulong, uint> iix = new Dictionary<ulong, uint>();

		// Token: 0x04000918 RID: 2328
		private readonly Dictionary<ulong, int> iiy = new Dictionary<ulong, int>();

		// Token: 0x04000919 RID: 2329
		private readonly HashSet<ulong> iiz = new HashSet<ulong>();

		// Token: 0x0400091A RID: 2330
		private float ija;

		// Token: 0x0400091B RID: 2331
		private bool ijb;

		// Token: 0x0400091C RID: 2332
		private readonly List<int> ijc = new List<int>();

		// Token: 0x0400091D RID: 2333
		private readonly object ijd = new object();

		// Token: 0x0400091E RID: 2334
		private float ije;

		// Token: 0x0400091F RID: 2335
		private const float ijf = 1f;

		// Token: 0x04000920 RID: 2336
		[SerializeField]
		private double _sleepDetectThresholdSeconds = 30.0;

		// Token: 0x04000921 RID: 2337
		private float ijg = -1f;

		// Token: 0x04000922 RID: 2338
		private DateTime ijh = DateTime.MinValue;

		// Token: 0x04000923 RID: 2339
		private bool iji;

		// Token: 0x04000924 RID: 2340
		private bool ijj;

		// Token: 0x04000925 RID: 2341
		private int ijk;

		// Token: 0x04000926 RID: 2342
		private int ijl;

		// Token: 0x04000927 RID: 2343
		private int ijm;

		// Token: 0x04000928 RID: 2344
		private Action<int, int> ijn;

		// Token: 0x04000929 RID: 2345
		private Action<int, int> ijo;

		// Token: 0x0400092A RID: 2346
		private Coroutine ijp;

		// Token: 0x0400092B RID: 2347
		private bool ijq;

		// Token: 0x0400092C RID: 2348
		private int ijr;

		// Token: 0x0400092D RID: 2349
		private static readonly Predicate<ItemData> ijs = new Predicate<ItemData>(SteamInventoryManager.<>c.<>9.cnx);

		// Token: 0x020000E5 RID: 229
		private class em
		{
			// Token: 0x060011D3 RID: 4563 RVA: 0x00058D78 File Offset: 0x00056F78
			public em(SteamInventoryResult_t a, string b, Action c = null, Action<bool, EResult> d = null)
			{
				this.igo = a;
				this.igp = b;
				this.igq = DateTime.UtcNow;
				this.igr = 0;
				this.igs = c;
				this.igt = null;
				this.igu = d;
				this.igv = null;
			}

			// Token: 0x0400092E RID: 2350
			public SteamInventoryResult_t igo;

			// Token: 0x0400092F RID: 2351
			public string igp;

			// Token: 0x04000930 RID: 2352
			public DateTime igq;

			// Token: 0x04000931 RID: 2353
			public int igr;

			// Token: 0x04000932 RID: 2354
			public Action igs;

			// Token: 0x04000933 RID: 2355
			public Dictionary<ulong, uint> igt;

			// Token: 0x04000934 RID: 2356
			public Action<bool, EResult> igu;

			// Token: 0x04000935 RID: 2357
			public int? igv;
		}

		// Token: 0x020000E6 RID: 230
		[NullableContext(1)]
		[Nullable(0)]
		public sealed class InventoryDelta : IEquatable<SteamInventoryManager.InventoryDelta>
		{
			// Token: 0x060011D4 RID: 4564 RVA: 0x00058DCD File Offset: 0x00056FCD
			public InventoryDelta(ulong InstanceId, int SignedDelta, int? DefIdIfNew, uint MergedQuantityAtRegister)
			{
				this.igw = InstanceId;
				this.igx = SignedDelta;
				this.igy = DefIdIfNew;
				this.igz = MergedQuantityAtRegister;
				base..ctor();
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x060011D5 RID: 4565 RVA: 0x00058DF2 File Offset: 0x00056FF2
			[CompilerGenerated]
			private Type ksf
			{
				[CompilerGenerated]
				get
				{
					return typeof(SteamInventoryManager.InventoryDelta);
				}
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00058DFE File Offset: 0x00056FFE
			// (set) Token: 0x060011D7 RID: 4567 RVA: 0x00058E06 File Offset: 0x00057006
			public ulong igw { get; set; }

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x060011D8 RID: 4568 RVA: 0x00058E0F File Offset: 0x0005700F
			// (set) Token: 0x060011D9 RID: 4569 RVA: 0x00058E17 File Offset: 0x00057017
			public int igx { get; set; }

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x060011DA RID: 4570 RVA: 0x00058E20 File Offset: 0x00057020
			// (set) Token: 0x060011DB RID: 4571 RVA: 0x00058E28 File Offset: 0x00057028
			public int? igy { get; set; }

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x060011DC RID: 4572 RVA: 0x00058E31 File Offset: 0x00057031
			// (set) Token: 0x060011DD RID: 4573 RVA: 0x00058E39 File Offset: 0x00057039
			public uint igz { get; set; }

			// Token: 0x060011DE RID: 4574 RVA: 0x00058E44 File Offset: 0x00057044
			[CompilerGenerated]
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(a.dmo());
				stringBuilder.Append(a.dmp());
				if (this.cnm(stringBuilder))
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append('}');
				return stringBuilder.ToString();
			}

			// Token: 0x060011DF RID: 4575 RVA: 0x00058E90 File Offset: 0x00057090
			[CompilerGenerated]
			private bool cnm(StringBuilder a)
			{
				RuntimeHelpers.EnsureSufficientExecutionStack();
				a.Append(a.dmq());
				a.Append(this.igw.ToString());
				a.Append(a.dmr());
				a.Append(this.igx.ToString());
				a.Append(a.dms());
				a.Append(this.igy.ToString());
				a.Append(a.dmt());
				a.Append(this.igz.ToString());
				return true;
			}

			// Token: 0x060011E0 RID: 4576 RVA: 0x00058F3F File Offset: 0x0005713F
			[NullableContext(2)]
			[CompilerGenerated]
			public static bool cnn(SteamInventoryManager.InventoryDelta a, SteamInventoryManager.InventoryDelta b)
			{
				return !SteamInventoryManager.InventoryDelta.cno(a, b);
			}

			// Token: 0x060011E1 RID: 4577 RVA: 0x00058F4B File Offset: 0x0005714B
			[NullableContext(2)]
			[CompilerGenerated]
			public static bool cno(SteamInventoryManager.InventoryDelta a, SteamInventoryManager.InventoryDelta b)
			{
				return a == b || (a != null && a.Equals(b));
			}

			// Token: 0x060011E2 RID: 4578 RVA: 0x00058F60 File Offset: 0x00057160
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return (((EqualityComparer<Type>.Default.GetHashCode(this.ksf) * -1521134295 + EqualityComparer<ulong>.Default.GetHashCode(this.<igw>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<igx>k__BackingField)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(this.<igy>k__BackingField)) * -1521134295 + EqualityComparer<uint>.Default.GetHashCode(this.<igz>k__BackingField);
			}

			// Token: 0x060011E3 RID: 4579 RVA: 0x00058FD9 File Offset: 0x000571D9
			[NullableContext(2)]
			[CompilerGenerated]
			public override bool Equals(object obj)
			{
				return this.Equals(obj as SteamInventoryManager.InventoryDelta);
			}

			// Token: 0x060011E4 RID: 4580 RVA: 0x00058FE8 File Offset: 0x000571E8
			[NullableContext(2)]
			[CompilerGenerated]
			public bool Equals(SteamInventoryManager.InventoryDelta other)
			{
				return this == other || (other != null && this.ksf == other.ksf && EqualityComparer<ulong>.Default.Equals(this.<igw>k__BackingField, other.<igw>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<igx>k__BackingField, other.<igx>k__BackingField) && EqualityComparer<int?>.Default.Equals(this.<igy>k__BackingField, other.<igy>k__BackingField) && EqualityComparer<uint>.Default.Equals(this.<igz>k__BackingField, other.<igz>k__BackingField));
			}

			// Token: 0x060011E5 RID: 4581 RVA: 0x00059074 File Offset: 0x00057274
			[CompilerGenerated]
			public SteamInventoryManager.InventoryDelta cnp()
			{
				return new SteamInventoryManager.InventoryDelta(this);
			}

			// Token: 0x060011E6 RID: 4582 RVA: 0x0005907C File Offset: 0x0005727C
			[CompilerGenerated]
			private InventoryDelta(SteamInventoryManager.InventoryDelta original)
			{
				this.igw = original.<igw>k__BackingField;
				this.igx = original.<igx>k__BackingField;
				this.igy = original.<igy>k__BackingField;
				this.igz = original.<igz>k__BackingField;
			}

			// Token: 0x060011E7 RID: 4583 RVA: 0x000590B4 File Offset: 0x000572B4
			[CompilerGenerated]
			public void cnq(out ulong a, out int b, out int? c, out uint d)
			{
				a = this.igw;
				b = this.igx;
				c = this.igy;
				d = this.igz;
			}
		}

		// Token: 0x020000E7 RID: 231
		private sealed class en
		{
			// Token: 0x0400093A RID: 2362
			public int iha;

			// Token: 0x0400093B RID: 2363
			public string ihb;

			// Token: 0x0400093C RID: 2364
			public DateTime ihc;

			// Token: 0x0400093D RID: 2365
			public IReadOnlyList<SteamInventoryManager.InventoryDelta> ihd;

			// Token: 0x0400093E RID: 2366
			public int? ihe;

			// Token: 0x0400093F RID: 2367
			public bool ihf;
		}

		// Token: 0x020000E9 RID: 233
		[CompilerGenerated]
		private sealed class eo
		{
			// Token: 0x060011F3 RID: 4595 RVA: 0x0005914C File Offset: 0x0005734C
			internal void olp()
			{
				this.ihg.cpp(this.ihh);
			}

			// Token: 0x060011F4 RID: 4596 RVA: 0x0005914C File Offset: 0x0005734C
			internal void cny()
			{
				this.ihg.cpp(this.ihh);
			}

			// Token: 0x060011F5 RID: 4597 RVA: 0x0005914C File Offset: 0x0005734C
			internal void cmj()
			{
				this.ihg.cpp(this.ihh);
			}

			// Token: 0x060011F6 RID: 4598 RVA: 0x0005914C File Offset: 0x0005734C
			internal void oun()
			{
				this.ihg.cpp(this.ihh);
			}

			// Token: 0x04000947 RID: 2375
			public SteamInventoryManager ihg;

			// Token: 0x04000948 RID: 2376
			public int ihh;
		}

		// Token: 0x020000EA RID: 234
		[CompilerGenerated]
		private sealed class ep
		{
			// Token: 0x060011F7 RID: 4599 RVA: 0x00059160 File Offset: 0x00057360
			internal void jgh(bool a, EResult b)
			{
				if (this.ihi != this.ihj.ijr)
				{
					if (bq.knd)
					{
						Debug.LogWarning(string.Format(a.dmv(), this.ihi));
					}
					return;
				}
				this.ihj.ijr = this.ihj.ijr + 1;
				this.ihj.ijq = false;
				Action<bool, EResult> action = this.ihk;
				if (action == null)
				{
					return;
				}
				action(a, b);
			}

			// Token: 0x060011F8 RID: 4600 RVA: 0x000591D8 File Offset: 0x000573D8
			internal void clh(bool a, EResult b)
			{
				if (this.ihi != this.ihj.ijr)
				{
					if (bq.knd)
					{
						Debug.LogWarning(string.Format(a.dmw(), this.ihi));
					}
					return;
				}
				this.ihj.ijr = this.ihj.ijr + 1;
				this.ihj.ijq = false;
				Action<bool, EResult> action = this.ihk;
				if (action == null)
				{
					return;
				}
				action(a, b);
			}

			// Token: 0x060011FA RID: 4602 RVA: 0x00059250 File Offset: 0x00057450
			internal void cnz(bool a, EResult b)
			{
				if (this.ihi != this.ihj.ijr)
				{
					if (bq.knd)
					{
						Debug.LogWarning(string.Format(a.dmx(), this.ihi));
					}
					return;
				}
				this.ihj.ijr = this.ihj.ijr + 1;
				this.ihj.ijq = false;
				Action<bool, EResult> action = this.ihk;
				if (action == null)
				{
					return;
				}
				action(a, b);
			}

			// Token: 0x060011FB RID: 4603 RVA: 0x000592C8 File Offset: 0x000574C8
			internal void jka(bool a, EResult b)
			{
				if (this.ihi != this.ihj.ijr)
				{
					if (bq.knd)
					{
						Debug.LogWarning(string.Format(a.dmy(), this.ihi));
					}
					return;
				}
				this.ihj.ijr = this.ihj.ijr + 1;
				this.ihj.ijq = false;
				Action<bool, EResult> action = this.ihk;
				if (action == null)
				{
					return;
				}
				action(a, b);
			}

			// Token: 0x04000949 RID: 2377
			public int ihi;

			// Token: 0x0400094A RID: 2378
			public SteamInventoryManager ihj;

			// Token: 0x0400094B RID: 2379
			public Action<bool, EResult> ihk;
		}
	}
}
