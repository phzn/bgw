using System;
using System.Collections.Generic;
using System.Text;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Rewired.UI;
using Rewired.Utils;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	// Token: 0x020001B1 RID: 433
	public abstract class RewiredPointerInputModule : BaseInputModule
	{
		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x00082060 File Offset: 0x00080260
		private RewiredPointerInputModule.hy lqs
		{
			get
			{
				if (this.juf == null)
				{
					return this.juf = new RewiredPointerInputModule.hy();
				}
				return this.juf;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x0008208A File Offset: 0x0008028A
		private IMouseInputSource lqt
		{
			get
			{
				return this.lqs;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x0008208A File Offset: 0x0008028A
		protected ITouchInputSource lqu
		{
			get
			{
				return this.lqs;
			}
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x00082092 File Offset: 0x00080292
		protected bool euo(IMouseInputSource a)
		{
			return this.lqt == a;
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x000820A0 File Offset: 0x000802A0
		public IMouseInputSource eup(int a, int b)
		{
			if (b < 0)
			{
				throw new ArgumentOutOfRangeException(a.eoe());
			}
			if (this.juc.Count == 0 && this.euz(a))
			{
				return this.lqt;
			}
			int count = this.juc.Count;
			int num = 0;
			for (int i = 0; i < count; i++)
			{
				IMouseInputSource mouseInputSource = this.juc[i];
				if (!UnityTools.IsNullOrDestroyed<IMouseInputSource>(mouseInputSource) && mouseInputSource.playerId == a)
				{
					if (b == num)
					{
						return mouseInputSource;
					}
					num++;
				}
			}
			return null;
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x0008211C File Offset: 0x0008031C
		public void euq(IMouseInputSource a)
		{
			if (a == null)
			{
				throw new ArgumentNullException(a.eof());
			}
			this.juc.Remove(a);
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00082139 File Offset: 0x00080339
		public void eur(IMouseInputSource a)
		{
			if (UnityTools.IsNullOrDestroyed<IMouseInputSource>(a))
			{
				throw new ArgumentNullException(a.eof());
			}
			this.juc.Add(a);
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0008215C File Offset: 0x0008035C
		public int eus(int a)
		{
			if (this.juc.Count == 0 && this.euz(a))
			{
				return 1;
			}
			int count = this.juc.Count;
			int num = 0;
			for (int i = 0; i < count; i++)
			{
				IMouseInputSource mouseInputSource = this.juc[i];
				if (!UnityTools.IsNullOrDestroyed<IMouseInputSource>(mouseInputSource) && mouseInputSource.playerId == a)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x000821BE File Offset: 0x000803BE
		public ITouchInputSource eut(int a, int b)
		{
			if (!UnityTools.IsNullOrDestroyed<ITouchInputSource>(this.jue))
			{
				return this.jue;
			}
			return this.lqu;
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x000821DA File Offset: 0x000803DA
		public void euu(ITouchInputSource a)
		{
			if (a == null)
			{
				throw new ArgumentNullException(a.eof());
			}
			if (this.jue == a)
			{
				this.jue = null;
			}
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x000821FA File Offset: 0x000803FA
		public void euv(ITouchInputSource a)
		{
			if (UnityTools.IsNullOrDestroyed<ITouchInputSource>(a))
			{
				throw new ArgumentNullException(a.eof());
			}
			this.jue = a;
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x00082216 File Offset: 0x00080416
		public int euw(int a)
		{
			if (!this.euz(a))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x00082224 File Offset: 0x00080424
		protected void eux()
		{
			this.juc.Clear();
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x00082234 File Offset: 0x00080434
		protected virtual bool lqv
		{
			get
			{
				int count = this.juc.Count;
				if (count == 0)
				{
					return this.lqt.enabled;
				}
				for (int i = 0; i < count; i++)
				{
					if (this.juc[i].enabled)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x06001CA1 RID: 7329
		protected abstract bool euz(int a);

		// Token: 0x06001CA2 RID: 7330 RVA: 0x00082280 File Offset: 0x00080480
		protected bool eva(int a, int b, int c, out hu d, bool e, PointerEventType f)
		{
			Dictionary<int, hu>[] array;
			if (!this.jud.TryGetValue(a, out array))
			{
				array = new Dictionary<int, hu>[b + 1];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = new Dictionary<int, hu>();
				}
				this.jud.Add(a, array);
			}
			if (b >= array.Length)
			{
				Dictionary<int, hu>[] array2 = new Dictionary<int, hu>[b + 1];
				for (int j = 0; j < array.Length; j++)
				{
					array2[j] = array[j];
				}
				array2[b] = new Dictionary<int, hu>();
				array = array2;
				this.jud[a] = array;
			}
			Dictionary<int, hu> dictionary = array[b];
			if (dictionary.TryGetValue(c, out d))
			{
				d.jtn = ((f == PointerEventType.Mouse) ? this.eup(a, b) : null);
				d.jto = ((f == PointerEventType.Touch) ? this.eut(a, b) : null);
				return false;
			}
			if (!e)
			{
				return false;
			}
			d = this.evb(a, b, c, f);
			dictionary.Add(c, d);
			return true;
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00082368 File Offset: 0x00080568
		private hu evb(int a, int b, int c, PointerEventType d)
		{
			hu hu = new hu(base.eventSystem)
			{
				jtl = a,
				jtm = b,
				pointerId = c,
				jtp = d
			};
			if (d == PointerEventType.Mouse)
			{
				hu.jtn = this.eup(a, b);
			}
			else if (d == PointerEventType.Touch)
			{
				hu.jto = this.eut(a, b);
			}
			if (c == -1)
			{
				hu.jtq = 0;
			}
			else if (c == -2)
			{
				hu.jtq = 1;
			}
			else if (c == -3)
			{
				hu.jtq = 2;
			}
			else if (c >= -2147483520 && c <= -2147483392)
			{
				hu.jtq = c - -2147483520;
			}
			return hu;
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x0008240C File Offset: 0x0008060C
		protected void evc(hu a)
		{
			Dictionary<int, hu>[] array;
			if (this.jud.TryGetValue(a.jtl, out array) && a.jtm < array.Length)
			{
				array[a.jtm].Remove(a.pointerId);
			}
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00082450 File Offset: 0x00080650
		protected hu evd(int a, int b, Touch c, out bool d, out bool e)
		{
			hu hu;
			bool flag = this.eva(a, b, c.fingerId, out hu, true, PointerEventType.Touch);
			hu.Reset();
			d = flag || c.phase == TouchPhase.Began;
			e = c.phase == TouchPhase.Canceled || c.phase == TouchPhase.Ended;
			if (flag)
			{
				hu.position = c.position;
			}
			if (d)
			{
				hu.delta = Vector2.zero;
			}
			else
			{
				hu.delta = c.position - hu.position;
			}
			hu.position = c.position;
			hu.button = PointerEventData.InputButton.Left;
			base.eventSystem.RaycastAll(hu, this.m_RaycastResultCache);
			RaycastResult raycastResult = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			hu.pointerCurrentRaycast = raycastResult;
			this.m_RaycastResultCache.Clear();
			return hu;
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00082524 File Offset: 0x00080724
		protected virtual RewiredPointerInputModule.hv eve(int a, int b)
		{
			IMouseInputSource mouseInputSource = this.eup(a, b);
			if (mouseInputSource == null)
			{
				return null;
			}
			hu hu;
			bool flag = this.eva(a, b, -1, out hu, true, PointerEventType.Mouse);
			hu.Reset();
			if (flag)
			{
				hu.position = mouseInputSource.screenPosition;
			}
			Vector2 screenPosition = mouseInputSource.screenPosition;
			if (mouseInputSource.locked || !mouseInputSource.enabled)
			{
				hu.position = new Vector2(-1f, -1f);
				hu.delta = Vector2.zero;
			}
			else
			{
				hu.delta = screenPosition - hu.position;
				hu.position = screenPosition;
			}
			hu.scrollDelta = mouseInputSource.wheelDelta;
			hu.button = PointerEventData.InputButton.Left;
			base.eventSystem.RaycastAll(hu, this.m_RaycastResultCache);
			RaycastResult raycastResult = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			hu.pointerCurrentRaycast = raycastResult;
			this.m_RaycastResultCache.Clear();
			hu hu2;
			this.eva(a, b, -2, out hu2, true, PointerEventType.Mouse);
			this.evl(hu, hu2);
			hu2.button = PointerEventData.InputButton.Right;
			hu hu3;
			this.eva(a, b, -3, out hu3, true, PointerEventType.Mouse);
			this.evl(hu, hu3);
			hu3.button = PointerEventData.InputButton.Middle;
			for (int i = 3; i < mouseInputSource.buttonCount; i++)
			{
				hu hu4;
				this.eva(a, b, -2147483520 + i, out hu4, true, PointerEventType.Mouse);
				this.evl(hu, hu4);
				hu4.button = (PointerEventData.InputButton)(-1);
			}
			this.jug.etp(0, this.evm(a, b, 0), hu);
			this.jug.etp(1, this.evm(a, b, 1), hu2);
			this.jug.etp(2, this.evm(a, b, 2), hu3);
			for (int j = 3; j < mouseInputSource.buttonCount; j++)
			{
				hu hu5;
				this.eva(a, b, -2147483520 + j, out hu5, false, PointerEventType.Mouse);
				this.jug.etp(j, this.evm(a, b, j), hu5);
			}
			return this.jug;
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00082700 File Offset: 0x00080900
		protected hu evf(int a, int b, int c, bool d, PointerEventType e)
		{
			if (!d)
			{
				hu hu;
				this.eva(a, b, c, out hu, false, e);
				return hu;
			}
			Dictionary<int, hu>[] array;
			if (!this.jud.TryGetValue(a, out array))
			{
				return null;
			}
			if (b >= array.Length)
			{
				return null;
			}
			using (Dictionary<int, hu>.Enumerator enumerator = array[b].GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					KeyValuePair<int, hu> keyValuePair = enumerator.Current;
					return keyValuePair.Value;
				}
			}
			return null;
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00082788 File Offset: 0x00080988
		private static bool evg(Vector2 a, Vector2 b, float c, bool d)
		{
			return !d || (a - b).sqrMagnitude >= c * c;
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x000827B4 File Offset: 0x000809B4
		protected virtual void evh(hu a)
		{
			GameObject gameObject;
			if (a.jtp == PointerEventType.Mouse)
			{
				IMouseInputSource mouseInputSource = this.eup(a.jtl, a.jtm);
				if (mouseInputSource != null)
				{
					gameObject = ((!mouseInputSource.enabled || mouseInputSource.locked) ? null : a.pointerCurrentRaycast.gameObject);
				}
				else
				{
					gameObject = null;
				}
			}
			else
			{
				if (a.jtp != PointerEventType.Touch)
				{
					throw new NotImplementedException();
				}
				gameObject = a.pointerCurrentRaycast.gameObject;
			}
			base.HandlePointerExitAndEnter(a, gameObject);
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00082830 File Offset: 0x00080A30
		protected virtual void evi(hu a)
		{
			if (!a.IsPointerMoving() || a.pointerDrag == null)
			{
				return;
			}
			if (a.jtp == PointerEventType.Mouse)
			{
				IMouseInputSource mouseInputSource = this.eup(a.jtl, a.jtm);
				if (mouseInputSource == null || mouseInputSource.locked || !mouseInputSource.enabled)
				{
					return;
				}
			}
			if (!a.dragging && RewiredPointerInputModule.evg(a.pressPosition, a.position, (float)base.eventSystem.pixelDragThreshold, a.useDragThreshold))
			{
				ExecuteEvents.Execute<IBeginDragHandler>(a.pointerDrag, a, ExecuteEvents.beginDragHandler);
				a.dragging = true;
			}
			if (a.dragging)
			{
				if (a.pointerPress != a.pointerDrag)
				{
					ExecuteEvents.Execute<IPointerUpHandler>(a.pointerPress, a, ExecuteEvents.pointerUpHandler);
					a.eligibleForClick = false;
					a.pointerPress = null;
					a.rawPointerPress = null;
				}
				ExecuteEvents.Execute<IDragHandler>(a.pointerDrag, a, ExecuteEvents.dragHandler);
			}
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00082920 File Offset: 0x00080B20
		public override bool IsPointerOverGameObject(int pointerTypeId)
		{
			foreach (KeyValuePair<int, Dictionary<int, hu>[]> keyValuePair in this.jud)
			{
				Dictionary<int, hu>[] value = keyValuePair.Value;
				for (int i = 0; i < value.Length; i++)
				{
					hu hu;
					if (value[i].TryGetValue(pointerTypeId, out hu) && hu.pointerEnter != null)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x000829A8 File Offset: 0x00080BA8
		protected void evj()
		{
			BaseEventData baseEventData = this.GetBaseEventData();
			foreach (KeyValuePair<int, Dictionary<int, hu>[]> keyValuePair in this.jud)
			{
				Dictionary<int, hu>[] value = keyValuePair.Value;
				for (int i = 0; i < value.Length; i++)
				{
					foreach (KeyValuePair<int, hu> keyValuePair2 in value[i])
					{
						base.HandlePointerExitAndEnter(keyValuePair2.Value, null);
					}
					value[i].Clear();
				}
			}
			base.eventSystem.SetSelectedGameObject(null, baseEventData);
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x00082A74 File Offset: 0x00080C74
		public override string ToString()
		{
			string text = a.eog();
			Type type = base.GetType();
			StringBuilder stringBuilder = new StringBuilder(text + ((type != null) ? type.ToString() : null));
			stringBuilder.AppendLine();
			foreach (KeyValuePair<int, Dictionary<int, hu>[]> keyValuePair in this.jud)
			{
				stringBuilder.AppendLine(a.eoh() + keyValuePair.Key.ToString());
				Dictionary<int, hu>[] value = keyValuePair.Value;
				for (int i = 0; i < value.Length; i++)
				{
					stringBuilder.AppendLine(a.eoi() + i.ToString());
					foreach (KeyValuePair<int, hu> keyValuePair2 in value[i])
					{
						stringBuilder.AppendLine(a.eoj() + keyValuePair2.Key.ToString());
						stringBuilder.AppendLine(keyValuePair2.Value.ToString());
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x00082BC0 File Offset: 0x00080DC0
		protected void evk(GameObject a, BaseEventData b)
		{
			if (ExecuteEvents.GetEventHandler<ISelectHandler>(a) != base.eventSystem.currentSelectedGameObject)
			{
				base.eventSystem.SetSelectedGameObject(null, b);
			}
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x00082BE7 File Offset: 0x00080DE7
		protected void evl(PointerEventData a, PointerEventData b)
		{
			b.position = a.position;
			b.delta = a.delta;
			b.scrollDelta = a.scrollDelta;
			b.pointerCurrentRaycast = a.pointerCurrentRaycast;
			b.pointerEnter = a.pointerEnter;
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x00082C28 File Offset: 0x00080E28
		protected PointerEventData.FramePressState evm(int a, int b, int c)
		{
			IMouseInputSource mouseInputSource = this.eup(a, b);
			if (mouseInputSource == null)
			{
				return PointerEventData.FramePressState.NotChanged;
			}
			bool buttonDown = mouseInputSource.GetButtonDown(c);
			bool buttonUp = mouseInputSource.GetButtonUp(c);
			if (buttonDown && buttonUp)
			{
				return PointerEventData.FramePressState.PressedAndReleased;
			}
			if (buttonDown)
			{
				return PointerEventData.FramePressState.Pressed;
			}
			if (buttonUp)
			{
				return PointerEventData.FramePressState.Released;
			}
			return PointerEventData.FramePressState.NotChanged;
		}

		// Token: 0x04000EF0 RID: 3824
		public const int kMouseLeftId = -1;

		// Token: 0x04000EF1 RID: 3825
		public const int kMouseRightId = -2;

		// Token: 0x04000EF2 RID: 3826
		public const int kMouseMiddleId = -3;

		// Token: 0x04000EF3 RID: 3827
		public const int kFakeTouchesId = -4;

		// Token: 0x04000EF4 RID: 3828
		private const int jtz = -2147483520;

		// Token: 0x04000EF5 RID: 3829
		private const int jua = 128;

		// Token: 0x04000EF6 RID: 3830
		private const int jub = -2147483392;

		// Token: 0x04000EF7 RID: 3831
		private readonly List<IMouseInputSource> juc = new List<IMouseInputSource>();

		// Token: 0x04000EF8 RID: 3832
		private Dictionary<int, Dictionary<int, hu>[]> jud = new Dictionary<int, Dictionary<int, hu>[]>();

		// Token: 0x04000EF9 RID: 3833
		private ITouchInputSource jue;

		// Token: 0x04000EFA RID: 3834
		private RewiredPointerInputModule.hy juf;

		// Token: 0x04000EFB RID: 3835
		private readonly RewiredPointerInputModule.hv jug = new RewiredPointerInputModule.hv();

		// Token: 0x020001B2 RID: 434
		protected class hv
		{
			// Token: 0x06001CB2 RID: 7346 RVA: 0x00082C90 File Offset: 0x00080E90
			public bool kig()
			{
				for (int i = 0; i < this.jtr.Count; i++)
				{
					if (this.jtr[i].lqg.etr())
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x06001CB3 RID: 7347 RVA: 0x00082CD0 File Offset: 0x00080ED0
			public bool iix()
			{
				for (int i = 0; i < this.jtr.Count; i++)
				{
					if (this.jtr[i].lqg.etr())
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x06001CB5 RID: 7349 RVA: 0x00082D24 File Offset: 0x00080F24
			public RewiredPointerInputModule.hx eto(int a)
			{
				RewiredPointerInputModule.hx hx = null;
				for (int i = 0; i < this.jtr.Count; i++)
				{
					if (this.jtr[i].lqh == a)
					{
						hx = this.jtr[i];
						break;
					}
				}
				if (hx == null)
				{
					hx = new RewiredPointerInputModule.hx
					{
						lqh = a,
						lqg = new RewiredPointerInputModule.hw()
					};
					this.jtr.Add(hx);
				}
				return hx;
			}

			// Token: 0x06001CB6 RID: 7350 RVA: 0x00082D94 File Offset: 0x00080F94
			public bool etn()
			{
				for (int i = 0; i < this.jtr.Count; i++)
				{
					if (this.jtr[i].lqg.etr())
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x06001CB7 RID: 7351 RVA: 0x00082DD4 File Offset: 0x00080FD4
			public RewiredPointerInputModule.hx lju(int a)
			{
				RewiredPointerInputModule.hx hx = null;
				for (int i = 0; i < this.jtr.Count; i++)
				{
					if (this.jtr[i].lqh == a)
					{
						hx = this.jtr[i];
						break;
					}
				}
				if (hx == null)
				{
					hx = new RewiredPointerInputModule.hx
					{
						lqh = a,
						lqg = new RewiredPointerInputModule.hw()
					};
					this.jtr.Add(hx);
				}
				return hx;
			}

			// Token: 0x06001CB8 RID: 7352 RVA: 0x00082E44 File Offset: 0x00081044
			public bool big()
			{
				for (int i = 0; i < this.jtr.Count; i++)
				{
					if (this.jtr[i].lqg.etr())
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x06001CB9 RID: 7353 RVA: 0x00082E82 File Offset: 0x00081082
			public void etp(int a, PointerEventData.FramePressState b, hu c)
			{
				RewiredPointerInputModule.hx hx = this.eto(a);
				hx.lqg.jts = b;
				hx.lqg.jtt = c;
			}

			// Token: 0x06001CBA RID: 7354 RVA: 0x00082EA4 File Offset: 0x000810A4
			public RewiredPointerInputModule.hx hxo(int a)
			{
				RewiredPointerInputModule.hx hx = null;
				for (int i = 0; i < this.jtr.Count; i++)
				{
					if (this.jtr[i].lqh == a)
					{
						hx = this.jtr[i];
						break;
					}
				}
				if (hx == null)
				{
					hx = new RewiredPointerInputModule.hx
					{
						lqh = a,
						lqg = new RewiredPointerInputModule.hw()
					};
					this.jtr.Add(hx);
				}
				return hx;
			}

			// Token: 0x06001CBB RID: 7355 RVA: 0x00082F14 File Offset: 0x00081114
			public bool etm()
			{
				for (int i = 0; i < this.jtr.Count; i++)
				{
					if (this.jtr[i].lqg.etq())
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x04000EFC RID: 3836
			private List<RewiredPointerInputModule.hx> jtr = new List<RewiredPointerInputModule.hx>();
		}

		// Token: 0x020001B3 RID: 435
		public class hw
		{
			// Token: 0x06001CBC RID: 7356 RVA: 0x00082F52 File Offset: 0x00081152
			public bool etq()
			{
				return this.jts == PointerEventData.FramePressState.Pressed || this.jts == PointerEventData.FramePressState.PressedAndReleased;
			}

			// Token: 0x06001CBD RID: 7357 RVA: 0x00082F52 File Offset: 0x00081152
			public bool jry()
			{
				return this.jts == PointerEventData.FramePressState.Pressed || this.jts == PointerEventData.FramePressState.PressedAndReleased;
			}

			// Token: 0x06001CBE RID: 7358 RVA: 0x00082F52 File Offset: 0x00081152
			public bool jte()
			{
				return this.jts == PointerEventData.FramePressState.Pressed || this.jts == PointerEventData.FramePressState.PressedAndReleased;
			}

			// Token: 0x06001CC0 RID: 7360 RVA: 0x00082F52 File Offset: 0x00081152
			public bool hwj()
			{
				return this.jts == PointerEventData.FramePressState.Pressed || this.jts == PointerEventData.FramePressState.PressedAndReleased;
			}

			// Token: 0x06001CC1 RID: 7361 RVA: 0x00082F67 File Offset: 0x00081167
			public bool etr()
			{
				return this.jts == PointerEventData.FramePressState.Released || this.jts == PointerEventData.FramePressState.PressedAndReleased;
			}

			// Token: 0x04000EFD RID: 3837
			public PointerEventData.FramePressState jts;

			// Token: 0x04000EFE RID: 3838
			public hu jtt;
		}

		// Token: 0x020001B4 RID: 436
		protected class hx
		{
			// Token: 0x170003E1 RID: 993
			// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x00082F7D File Offset: 0x0008117D
			// (set) Token: 0x06001CC3 RID: 7363 RVA: 0x00082F85 File Offset: 0x00081185
			public RewiredPointerInputModule.hw lqg
			{
				get
				{
					return this.jtv;
				}
				set
				{
					this.jtv = value;
				}
			}

			// Token: 0x170003E2 RID: 994
			// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x00082F8E File Offset: 0x0008118E
			// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x00082F96 File Offset: 0x00081196
			public int lqh
			{
				get
				{
					return this.jtu;
				}
				set
				{
					this.jtu = value;
				}
			}

			// Token: 0x04000EFF RID: 3839
			private int jtu;

			// Token: 0x04000F00 RID: 3840
			private RewiredPointerInputModule.hw jtv;
		}

		// Token: 0x020001B5 RID: 437
		private sealed class hy : IMouseInputSource, ITouchInputSource
		{
			// Token: 0x170003E3 RID: 995
			// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x00082F9F File Offset: 0x0008119F
			int IMouseInputSource.lqi
			{
				get
				{
					this.euk();
					return 0;
				}
			}

			// Token: 0x170003E4 RID: 996
			// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x00082F9F File Offset: 0x0008119F
			int ITouchInputSource.lqj
			{
				get
				{
					this.euk();
					return 0;
				}
			}

			// Token: 0x06001CC9 RID: 7369 RVA: 0x00082FA8 File Offset: 0x000811A8
			bool IMouseInputSource.eud(int a)
			{
				this.euk();
				return Input.GetMouseButton(a);
			}

			// Token: 0x170003E6 RID: 998
			// (get) Token: 0x06001CCA RID: 7370 RVA: 0x00082FB6 File Offset: 0x000811B6
			bool IMouseInputSource.lql
			{
				get
				{
					this.euk();
					return Cursor.lockState == CursorLockMode.Locked;
				}
			}

			// Token: 0x170003E8 RID: 1000
			// (get) Token: 0x06001CCB RID: 7371 RVA: 0x00082FC6 File Offset: 0x000811C6
			Vector2 IMouseInputSource.lqn
			{
				get
				{
					this.euk();
					return Input.mousePosition;
				}
			}

			// Token: 0x06001CCC RID: 7372 RVA: 0x00082FD8 File Offset: 0x000811D8
			private void euk()
			{
				if (Time.frameCount == this.jty)
				{
					return;
				}
				this.jty = Time.frameCount;
				this.jtx = this.jtw;
				this.jtw = Input.mousePosition;
			}

			// Token: 0x06001CCD RID: 7373 RVA: 0x0008300F File Offset: 0x0008120F
			bool IMouseInputSource.euc(int a)
			{
				this.euk();
				return Input.GetMouseButtonUp(a);
			}

			// Token: 0x170003EC RID: 1004
			// (get) Token: 0x06001CCF RID: 7375 RVA: 0x0008302C File Offset: 0x0008122C
			int ITouchInputSource.lqr
			{
				get
				{
					this.euk();
					return Input.touchCount;
				}
			}

			// Token: 0x170003E7 RID: 999
			// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x00083039 File Offset: 0x00081239
			int IMouseInputSource.lqm
			{
				get
				{
					this.euk();
					return 3;
				}
			}

			// Token: 0x06001CD1 RID: 7377 RVA: 0x00082FD8 File Offset: 0x000811D8
			private void gem()
			{
				if (Time.frameCount == this.jty)
				{
					return;
				}
				this.jty = Time.frameCount;
				this.jtx = this.jtw;
				this.jtw = Input.mousePosition;
			}

			// Token: 0x170003EB RID: 1003
			// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x00083042 File Offset: 0x00081242
			bool ITouchInputSource.lqq
			{
				get
				{
					this.euk();
					return Input.touchSupported;
				}
			}

			// Token: 0x170003EA RID: 1002
			// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x0008304F File Offset: 0x0008124F
			Vector2 IMouseInputSource.lqp
			{
				get
				{
					this.euk();
					return Input.mouseScrollDelta;
				}
			}

			// Token: 0x06001CD4 RID: 7380 RVA: 0x0008305C File Offset: 0x0008125C
			bool IMouseInputSource.eub(int a)
			{
				this.euk();
				return Input.GetMouseButtonDown(a);
			}

			// Token: 0x170003E9 RID: 1001
			// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x0008306A File Offset: 0x0008126A
			Vector2 IMouseInputSource.lqo
			{
				get
				{
					this.euk();
					return this.jtw - this.jtx;
				}
			}

			// Token: 0x170003E5 RID: 997
			// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x00083083 File Offset: 0x00081283
			bool IMouseInputSource.lqk
			{
				get
				{
					this.euk();
					return Input.mousePresent;
				}
			}

			// Token: 0x06001CD7 RID: 7383 RVA: 0x00083090 File Offset: 0x00081290
			Touch ITouchInputSource.euj(int a)
			{
				this.euk();
				return Input.GetTouch(a);
			}

			// Token: 0x04000F01 RID: 3841
			private Vector2 jtw;

			// Token: 0x04000F02 RID: 3842
			private Vector2 jtx;

			// Token: 0x04000F03 RID: 3843
			private int jty = -1;
		}
	}
}
