using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Spine.Unity;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BongoWaifu.Multiplayer
{
	// Token: 0x0200012E RID: 302
	public sealed class RemoteAvatarPlacement : MonoBehaviour
	{
		// Token: 0x0600160B RID: 5643 RVA: 0x0006BD37 File Offset: 0x00069F37
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetFocusStatics()
		{
			RemoteAvatarPlacement.ixi = 0;
			RemoteAvatarPlacement.ixj.Clear();
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x0006BD49 File Offset: 0x00069F49
		// (set) Token: 0x0600160D RID: 5645 RVA: 0x0006BD51 File Offset: 0x00069F51
		public int ixk { get; private set; }

		// Token: 0x0600160E RID: 5646 RVA: 0x0006BD5C File Offset: 0x00069F5C
		public void dnl(CharacterKind a, Vector2 b)
		{
			Vector2 vector = ((b.x <= 0f || b.y <= 0f) ? Vector2.one : b);
			bool flag = this.ixa != a || this.ixb != vector;
			this.ixa = a;
			this.ixb = vector;
			if (!flag)
			{
				return;
			}
			Bounds bounds;
			if (!this.iws && this.dnv(out bounds))
			{
				this.iwt = new Vector3(bounds.center.x, bounds.min.y, base.transform.position.z);
				this.iws = true;
			}
			this.iwr = true;
			this.iwp = true;
			this.iwq = Time.frameCount + 2;
			this.iwu = Time.frameCount + 12;
			this.iwx = false;
			this.dnw();
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x0006BE37 File Offset: 0x0006A037
		private void Awake()
		{
			this.iwi = base.GetComponentsInChildren<Renderer>(true);
			this.iwj = base.GetComponentsInChildren<SkeletonAnimation>(true);
			this.ixe = Screen.width;
			this.ixf = Screen.height;
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x0006BE69 File Offset: 0x0006A069
		private void OnEnable()
		{
			RemoteAvatarPlacement.ixj.Add(this);
			this.dnz();
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x0006BE7C File Offset: 0x0006A07C
		public void dnm()
		{
			if (this.iwe)
			{
				return;
			}
			this.dop();
			this.iwp = true;
			this.iwq = Time.frameCount + 2;
			fq.dbg(string.Format(a.egw(), this.ivz, Screen.width, Screen.height));
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x0006BEDC File Offset: 0x0006A0DC
		public void dnn(ulong a)
		{
			if (this.iwb && this.ivz == a)
			{
				return;
			}
			bool flag = !this.iwb;
			this.iwb = true;
			this.ivz = a;
			this.iwa = a > 0UL;
			this.iwc = Camera.main;
			this.dnt(false);
			if (flag)
			{
				this.dno();
			}
			this.dop();
			this.iwp = true;
			this.iwq = Time.frameCount + 2;
			fq.dbg(string.Format(a.egx(), new object[]
			{
				a,
				this.iwa,
				base.transform.position,
				base.transform.lossyScale
			}));
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x0006BFA4 File Offset: 0x0006A1A4
		private void dno()
		{
			SkeletonAnimation skeletonAnimation = ((GirlController.kok != null) ? GirlController.kok.skeletonAnimation : null);
			Camera camera = ((this.iwc != null) ? this.iwc : Camera.main);
			Vector3 vector;
			if (skeletonAnimation != null)
			{
				Vector3 position = skeletonAnimation.transform.position;
				float num = -1f;
				if (camera != null && camera.WorldToViewportPoint(position).x < 0.5f)
				{
					num = 1f;
				}
				vector = position + new Vector3(3f * num, 0f, 0f);
				if (camera != null)
				{
					Vector3 vector2 = camera.WorldToViewportPoint(vector);
					vector2.x = Mathf.Clamp(vector2.x, 0.12f, 0.88f);
					vector = camera.ViewportToWorldPoint(vector2);
				}
			}
			else
			{
				vector = new Vector3(0f, -5f, 0f);
			}
			vector.z = base.transform.position.z;
			base.transform.position = vector;
			this.dnw();
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x0006C0C1 File Offset: 0x0006A2C1
		private void Update()
		{
			this.dnt(true);
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x0006C0CA File Offset: 0x0006A2CA
		public void dnp(string a)
		{
			if (!string.IsNullOrEmpty(a))
			{
				this.iwn = a;
			}
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x0006C0DB File Offset: 0x0006A2DB
		public void dnq(NetworkPlayer a)
		{
			this.ixc = a;
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x0006C0E4 File Offset: 0x0006A2E4
		public void dnr(Color a)
		{
			this.ixd = a;
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x0006C0F0 File Offset: 0x0006A2F0
		private void LateUpdate()
		{
			if (Screen.width != this.ixe || Screen.height != this.ixf)
			{
				this.ixe = Screen.width;
				this.ixf = Screen.height;
				this.dnm();
			}
			this.doe();
			Bounds bounds;
			if (this.iws && !this.iwe && Time.frameCount >= this.iwq && this.dnv(out bounds))
			{
				Vector3 vector = this.iwt - new Vector3(bounds.center.x, bounds.min.y, base.transform.position.z);
				vector.z = 0f;
				if (vector.sqrMagnitude > 0.0001f)
				{
					base.transform.position += vector;
					this.dnw();
				}
				if (Time.frameCount >= this.iwu)
				{
					this.iws = false;
					this.doo();
					fq.dbg(string.Format(a.egy(), base.transform.position));
				}
			}
			if (this.iwp && !this.iwe && !this.iws && Time.frameCount >= this.iwq && this.dns())
			{
				this.iwp = false;
			}
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x0006C24C File Offset: 0x0006A44C
		private bool dns()
		{
			if (this.iwc == null)
			{
				this.iwc = Camera.main;
			}
			if (this.iwc == null)
			{
				return false;
			}
			Bounds bounds;
			if (!this.dnv(out bounds))
			{
				return false;
			}
			Vector3 vector = this.iwc.WorldToViewportPoint(bounds.center);
			if (vector.z <= 0f)
			{
				return false;
			}
			Vector3 vector2 = vector;
			vector2.x = Mathf.Clamp(vector.x, 0.08f, 0.92f);
			vector2.y = Mathf.Clamp(vector.y, 0.1f, 0.9f);
			if (Mathf.Approximately(vector2.x, vector.x) && Mathf.Approximately(vector2.y, vector.y))
			{
				return true;
			}
			Vector3 vector3 = this.iwc.ViewportToWorldPoint(vector2) - this.iwc.ViewportToWorldPoint(vector);
			vector3.z = 0f;
			base.transform.position += vector3;
			this.dnw();
			fq.dbg(string.Format(a.egz(), vector, vector2, base.transform.position));
			return true;
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x0006C385 File Offset: 0x0006A585
		private void OnDisable()
		{
			RemoteAvatarPlacement.ixj.Remove(this);
			if (this.iwo)
			{
				this.iwo = false;
				RemoteNameplate.dpu(this);
			}
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x0006C3A8 File Offset: 0x0006A5A8
		private void dnt(bool a)
		{
			SkeletonAnimation skeletonAnimation = ((GirlController.kok != null) ? GirlController.kok.skeletonAnimation : null);
			Vector3 vector2;
			if (skeletonAnimation != null)
			{
				if (this.ixa == CharacterKind.Cat)
				{
					Vector3 vector = ((skeletonAnimation.transform.parent != null) ? skeletonAnimation.transform.parent.lossyScale : Vector3.one);
					vector2 = new Vector3(Mathf.Abs(vector.x * this.ixb.x), Mathf.Abs(vector.y * this.ixb.y), Mathf.Abs(vector.z));
				}
				else
				{
					Vector3 lossyScale = skeletonAnimation.transform.lossyScale;
					vector2 = new Vector3(Mathf.Abs(lossyScale.x), Mathf.Abs(lossyScale.y), Mathf.Abs(lossyScale.z));
				}
			}
			else
			{
				int num = Mathf.Clamp(bq.hlo, 0, RemoteAvatarPlacement.ivx.Length - 1);
				float num2 = RemoteAvatarPlacement.ivx[num] * 0.2f;
				vector2 = new Vector3(num2, num2, num2);
			}
			Vector3 vector3 = ((base.transform.parent != null) ? base.transform.parent.lossyScale : Vector3.one);
			Vector3 vector4 = new Vector3(Mathf.Approximately(vector3.x, 0f) ? vector2.x : (vector2.x / vector3.x), Mathf.Approximately(vector3.y, 0f) ? vector2.y : (vector2.y / vector3.y), Mathf.Approximately(vector3.z, 0f) ? vector2.z : (vector2.z / vector3.z));
			Vector3 localScale = base.transform.localScale;
			float num3 = (bq.hlt ? (-1f) : 1f);
			Vector3 vector5 = new Vector3(vector4.x * num3, vector4.y, vector4.z);
			if (Mathf.Approximately(localScale.x, vector5.x) && Mathf.Approximately(localScale.y, vector5.y) && Mathf.Approximately(localScale.z, vector5.z))
			{
				return;
			}
			if (this.iwr)
			{
				a = false;
				this.iwr = false;
			}
			bool flag = false;
			Vector3 vector6 = default(Vector3);
			Bounds bounds;
			if (a && this.dnv(out bounds))
			{
				vector6 = new Vector3(bounds.center.x, bounds.min.y, base.transform.position.z);
				flag = true;
			}
			base.transform.localScale = vector5;
			this.dnw();
			if (flag && !Mathf.Approximately(localScale.x, 0f) && !Mathf.Approximately(localScale.y, 0f))
			{
				float num4 = vector4.x / Mathf.Abs(localScale.x);
				float num5 = vector4.y / localScale.y;
				Vector3 position = base.transform.position;
				position.x = vector6.x + (position.x - vector6.x) * num4;
				position.y = vector6.y + (position.y - vector6.y) * num5;
				base.transform.position = position;
				this.dnw();
				if (!this.iwe)
				{
					this.dns();
				}
				if (this.iwe && this.iwc != null)
				{
					this.iwd = base.transform.position - this.doj(Input.mousePosition);
				}
				this.doo();
			}
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x0006C760 File Offset: 0x0006A960
		private Renderer dnu()
		{
			if (this.iwi == null)
			{
				return null;
			}
			for (int i = 0; i < this.iwi.Length; i++)
			{
				Renderer renderer = this.iwi[i];
				if (renderer != null && renderer.enabled && renderer.gameObject.activeInHierarchy)
				{
					return renderer;
				}
			}
			return null;
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x0006C7B4 File Offset: 0x0006A9B4
		public bool dnv(out Bounds a)
		{
			if (this.iwk == Time.frameCount)
			{
				a = this.iwm;
				return this.iwl;
			}
			this.iwk = Time.frameCount;
			this.iwl = this.dnx(out this.iwm);
			a = this.iwm;
			return this.iwl;
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x0006C810 File Offset: 0x0006AA10
		private void dnw()
		{
			this.iwk = -1;
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x0006C81C File Offset: 0x0006AA1C
		private bool dnx(out Bounds a)
		{
			a = default(Bounds);
			Renderer renderer = this.dnu();
			if (renderer == null)
			{
				return false;
			}
			if (this.iwj != null)
			{
				for (int i = 0; i < this.iwj.Length; i++)
				{
					SkeletonAnimation skeletonAnimation = this.iwj[i];
					if (skeletonAnimation != null && skeletonAnimation.gameObject == renderer.gameObject && gh.drc(skeletonAnimation, out a))
					{
						return true;
					}
				}
			}
			Bounds bounds = renderer.bounds;
			if (bounds.size.x < 0.001f || bounds.size.y < 0.001f)
			{
				return false;
			}
			a = bounds;
			return true;
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x0006C8C4 File Offset: 0x0006AAC4
		public void dny()
		{
			bool flag = true;
			for (int i = 0; i < RemoteAvatarPlacement.ixj.Count; i++)
			{
				RemoteAvatarPlacement remoteAvatarPlacement = RemoteAvatarPlacement.ixj[i];
				if (remoteAvatarPlacement != null && remoteAvatarPlacement != this && remoteAvatarPlacement.ixk > this.ixk)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				return;
			}
			this.dnz();
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x0006C922 File Offset: 0x0006AB22
		private void dnz()
		{
			this.ixk = ++RemoteAvatarPlacement.ixi;
			this.doa();
			if (RemoteAvatarPlacement.ixi >= 25000)
			{
				RemoteAvatarPlacement.dob();
			}
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x0006C950 File Offset: 0x0006AB50
		private void doa()
		{
			if (this.iwi == null)
			{
				return;
			}
			int num = -30000 + this.ixk;
			for (int i = 0; i < this.iwi.Length; i++)
			{
				if (this.iwi[i] != null)
				{
					this.iwi[i].sortingOrder = num;
				}
			}
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x0006C9A4 File Offset: 0x0006ABA4
		private static void dob()
		{
			RemoteAvatarPlacement.ixj.RemoveAll(new Predicate<RemoteAvatarPlacement>(RemoteAvatarPlacement.<>c.<>9.dnh));
			RemoteAvatarPlacement.ixj.Sort(new Comparison<RemoteAvatarPlacement>(RemoteAvatarPlacement.<>c.<>9.dni));
			for (int i = 0; i < RemoteAvatarPlacement.ixj.Count; i++)
			{
				RemoteAvatarPlacement.ixj[i].ixk = i + 1;
				RemoteAvatarPlacement.ixj[i].doa();
			}
			RemoteAvatarPlacement.ixi = RemoteAvatarPlacement.ixj.Count;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x0006CA4B File Offset: 0x0006AC4B
		public void doc()
		{
			this.iwo = true;
			this.iwx = false;
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x0006CA5B File Offset: 0x0006AC5B
		public void dod()
		{
			this.iwo = false;
			RemoteNameplate.dpu(this);
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x0006CA6C File Offset: 0x0006AC6C
		private void doe()
		{
			if (!this.iwo)
			{
				return;
			}
			if (RemoteAvatarPlacement.dof())
			{
				RemoteNameplate.dpu(this);
				return;
			}
			if (this.iwc == null)
			{
				this.iwc = Camera.main;
			}
			if (this.iwc == null)
			{
				RemoteNameplate.dpu(this);
				return;
			}
			Vector3 lossyScale = base.transform.lossyScale;
			Vector3 vector;
			if (this.ixa == CharacterKind.Waifu)
			{
				if (lossyScale.x == 0f || lossyScale.y == 0f)
				{
					RemoteNameplate.dpu(this);
					return;
				}
				vector = new Vector3(base.transform.position.x + -0.6f * lossyScale.x, base.transform.position.y + 6.7f * lossyScale.y, base.transform.position.z);
			}
			else
			{
				if (!this.iwx)
				{
					if (lossyScale.x == 0f || lossyScale.y == 0f)
					{
						RemoteNameplate.dpu(this);
						return;
					}
					Bounds bounds;
					if (!this.dnv(out bounds))
					{
						RemoteNameplate.dpu(this);
						return;
					}
					this.iwy = (bounds.min.y - base.transform.position.y) / lossyScale.y;
					this.iwz = (bounds.center.x - base.transform.position.x) / lossyScale.x;
					this.iwx = true;
				}
				vector = new Vector3(base.transform.position.x + this.iwz * lossyScale.x, base.transform.position.y + this.iwy * lossyScale.y, base.transform.position.z);
			}
			Vector3 vector2 = this.iwc.WorldToScreenPoint(vector);
			if (vector2.z <= 0f)
			{
				RemoteNameplate.dpu(this);
				return;
			}
			float num = ((this.ixc != null && this.ixa == CharacterKind.Waifu) ? Mathf.Clamp01((float)this.ixc.kuz / 100f) : (-1f));
			RemoteNameplate.dpt(this, this.iwn, num, new Vector2(vector2.x, vector2.y), this.ixd);
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x0006CCAE File Offset: 0x0006AEAE
		private static bool dof()
		{
			return EventSystem.current != null && EventSystem.current.IsPointerOverGameObject();
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x0006CCCC File Offset: 0x0006AECC
		public void dog(Vector3 a)
		{
			if (RemoteAvatarPlacement.dof())
			{
				return;
			}
			if (this.iwc == null)
			{
				this.iwc = Camera.main;
			}
			if (this.iwc == null)
			{
				return;
			}
			this.iwf = true;
			this.iwe = false;
			this.iwg = a;
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x0006CD20 File Offset: 0x0006AF20
		public void doh(Vector3 a)
		{
			if (this.iwc == null)
			{
				return;
			}
			if (!this.iwe)
			{
				if (!this.iwf)
				{
					return;
				}
				float num = ((EventSystem.current != null) ? ((float)EventSystem.current.pixelDragThreshold) : 8f);
				if (num < 8f)
				{
					num = 8f;
				}
				if ((a - this.iwg).sqrMagnitude < num * num)
				{
					return;
				}
				this.iwe = true;
				this.iws = false;
				this.iwp = false;
				this.iwd = base.transform.position - this.doj(a);
			}
			Vector3 vector = this.doj(a) + this.iwd;
			vector.z = base.transform.position.z;
			base.transform.position = vector;
			this.dnw();
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x0006CE06 File Offset: 0x0006B006
		public void doi()
		{
			this.iwf = false;
			if (!this.iwe)
			{
				return;
			}
			this.iwe = false;
			this.doo();
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x0006CE28 File Offset: 0x0006B028
		private Vector3 doj(Vector3 a)
		{
			float num = Mathf.Abs(this.iwc.transform.position.z - base.transform.position.z);
			return this.iwc.ScreenToWorldPoint(new Vector3(a.x, a.y, num));
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x0006CE7E File Offset: 0x0006B07E
		private string kvg
		{
			get
			{
				return string.Format(a.eha(), this.ivz);
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600162D RID: 5677 RVA: 0x0006CE95 File Offset: 0x0006B095
		private string kvh
		{
			get
			{
				return string.Format(a.ehb(), this.ivz);
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600162E RID: 5678 RVA: 0x0006CEAC File Offset: 0x0006B0AC
		private string kvi
		{
			get
			{
				return string.Format(a.ehc(), this.ivz);
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600162F RID: 5679 RVA: 0x0006CEC3 File Offset: 0x0006B0C3
		private string kvj
		{
			get
			{
				return string.Format(a.ehd(), this.ivz);
			}
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x0006CEDC File Offset: 0x0006B0DC
		private void doo()
		{
			if (!this.iwa)
			{
				return;
			}
			Bounds bounds;
			if (!this.dnv(out bounds))
			{
				return;
			}
			PlayerPrefs.SetFloat(this.kvg, bounds.center.x);
			PlayerPrefs.SetFloat(this.kvh, bounds.min.y);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x0006CF2C File Offset: 0x0006B12C
		private void dop()
		{
			if (!this.iwa)
			{
				return;
			}
			if (PlayerPrefs.HasKey(this.kvg))
			{
				this.iwt = new Vector3(PlayerPrefs.GetFloat(this.kvg), PlayerPrefs.GetFloat(this.kvh), base.transform.position.z);
				this.iws = true;
				this.iwq = Time.frameCount + 2;
				this.iwu = Time.frameCount + 12;
				return;
			}
			if (!PlayerPrefs.HasKey(this.kvi))
			{
				return;
			}
			Vector3 position = base.transform.position;
			position.x = PlayerPrefs.GetFloat(this.kvi, position.x);
			position.y = PlayerPrefs.GetFloat(this.kvj, position.y);
			base.transform.position = position;
			this.dnw();
		}

		// Token: 0x04000B21 RID: 2849
		private static readonly float[] ivx = new float[] { 1f, 1.2f, 1.5f, 1.8f, 2.1f, 0.5f, 0.6f, 0.7f, 0.8f, 0.9f };

		// Token: 0x04000B22 RID: 2850
		private const float ivy = 0.2f;

		// Token: 0x04000B23 RID: 2851
		private ulong ivz;

		// Token: 0x04000B24 RID: 2852
		private bool iwa;

		// Token: 0x04000B25 RID: 2853
		private bool iwb;

		// Token: 0x04000B26 RID: 2854
		private Camera iwc;

		// Token: 0x04000B27 RID: 2855
		private Vector3 iwd;

		// Token: 0x04000B28 RID: 2856
		private bool iwe;

		// Token: 0x04000B29 RID: 2857
		private bool iwf;

		// Token: 0x04000B2A RID: 2858
		private Vector3 iwg;

		// Token: 0x04000B2B RID: 2859
		private const float iwh = 8f;

		// Token: 0x04000B2C RID: 2860
		private Renderer[] iwi;

		// Token: 0x04000B2D RID: 2861
		private SkeletonAnimation[] iwj;

		// Token: 0x04000B2E RID: 2862
		private int iwk = -1;

		// Token: 0x04000B2F RID: 2863
		private bool iwl;

		// Token: 0x04000B30 RID: 2864
		private Bounds iwm;

		// Token: 0x04000B31 RID: 2865
		private string iwn = a.eex();

		// Token: 0x04000B32 RID: 2866
		private bool iwo;

		// Token: 0x04000B33 RID: 2867
		private bool iwp;

		// Token: 0x04000B34 RID: 2868
		private int iwq;

		// Token: 0x04000B35 RID: 2869
		private bool iwr;

		// Token: 0x04000B36 RID: 2870
		private bool iws;

		// Token: 0x04000B37 RID: 2871
		private Vector3 iwt;

		// Token: 0x04000B38 RID: 2872
		private int iwu;

		// Token: 0x04000B39 RID: 2873
		private const float iwv = -0.6f;

		// Token: 0x04000B3A RID: 2874
		private const float iww = 6.7f;

		// Token: 0x04000B3B RID: 2875
		private bool iwx;

		// Token: 0x04000B3C RID: 2876
		private float iwy;

		// Token: 0x04000B3D RID: 2877
		private float iwz;

		// Token: 0x04000B3E RID: 2878
		private CharacterKind ixa;

		// Token: 0x04000B3F RID: 2879
		private Vector2 ixb = Vector2.one;

		// Token: 0x04000B40 RID: 2880
		private NetworkPlayer ixc;

		// Token: 0x04000B41 RID: 2881
		private Color ixd = Color.white;

		// Token: 0x04000B42 RID: 2882
		private int ixe;

		// Token: 0x04000B43 RID: 2883
		private int ixf;

		// Token: 0x04000B44 RID: 2884
		private const int ixg = -30000;

		// Token: 0x04000B45 RID: 2885
		private const int ixh = 25000;

		// Token: 0x04000B46 RID: 2886
		private static int ixi;

		// Token: 0x04000B47 RID: 2887
		private static readonly List<RemoteAvatarPlacement> ixj = new List<RemoteAvatarPlacement>();
	}
}
