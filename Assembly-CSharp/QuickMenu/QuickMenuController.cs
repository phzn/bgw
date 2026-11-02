using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Spine.Unity;
using UnityEngine;
using UnityEngine.EventSystems;

namespace QuickMenu
{
	// Token: 0x020000F1 RID: 241
	public class QuickMenuController : MonoBehaviour
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x000598DE File Offset: 0x00057ADE
		// (set) Token: 0x0600121A RID: 4634 RVA: 0x000598E5 File Offset: 0x00057AE5
		public static QuickMenuController iju { get; private set; }

		// Token: 0x0600121B RID: 4635 RVA: 0x000598ED File Offset: 0x00057AED
		private void Awake()
		{
			QuickMenuController.iju = this;
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x000598F5 File Offset: 0x00057AF5
		private void OnEnable()
		{
			eu.ijy += this.cre;
			eu.ijx += this.crd;
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00059919 File Offset: 0x00057B19
		private void OnDisable()
		{
			eu.ijy -= this.cre;
			eu.ijx -= this.crd;
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00059940 File Offset: 0x00057B40
		private void crd()
		{
			if (SettingPanel.kqq == null)
			{
				return;
			}
			if (!SettingPanel.kqq.gameObject.activeSelf)
			{
				return;
			}
			if (SettingPanel.kqq.kqr)
			{
				return;
			}
			BgmPanelController bgmPanelController = ((cx.kpw != null) ? cx.kpw.bgmPanel : null);
			if (bgmPanelController != null && bgmPanelController.gameObject.activeSelf && bgmPanelController.kpn)
			{
				return;
			}
			Vector2 vector = Input.mousePosition;
			if (vector.x < 0f || vector.x > (float)Screen.width || vector.y < 0f || vector.y > (float)Screen.height)
			{
				SettingPanel.kqq.Close();
				return;
			}
			if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
			{
				return;
			}
			if (this.crg(vector))
			{
				return;
			}
			SettingPanel.kqq.Close();
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00059A30 File Offset: 0x00057C30
		private void cre()
		{
			if (!bq.hlx)
			{
				return;
			}
			Vector2 vector = Input.mousePosition;
			if (vector.x < 0f || vector.x > (float)Screen.width || vector.y < 0f || vector.y > (float)Screen.height)
			{
				return;
			}
			bool flag = SettingPanel.kqq != null && SettingPanel.kqq.gameObject.activeSelf;
			if (flag && EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
			{
				return;
			}
			if (this.crg(vector))
			{
				return;
			}
			if (!this.crh(vector))
			{
				return;
			}
			if (flag)
			{
				SettingPanel.kqq.Close();
				return;
			}
			this.crj(vector);
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x00059AED File Offset: 0x00057CED
		public bool crf(Vector2 a)
		{
			return this.crg(a) || this.crh(a);
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00059B04 File Offset: 0x00057D04
		private bool crg(Vector2 a)
		{
			if (this.excludeUIRects != null)
			{
				for (int i = 0; i < this.excludeUIRects.Length; i++)
				{
					if (dx.cgm(this.excludeUIRects[i], a))
					{
						return true;
					}
				}
			}
			BgmPanelController bgmPanelController = ((cx.kpw != null) ? cx.kpw.bgmPanel : null);
			return bgmPanelController != null && bgmPanelController.gameObject.activeSelf && dx.cgl(bgmPanelController.transform, a);
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x00059B80 File Offset: 0x00057D80
		private bool crh(Vector2 a)
		{
			Renderer renderer = this.cri();
			if (renderer == null)
			{
				if (!this.ijv)
				{
					Debug.LogWarning(a.dqj());
					this.ijv = true;
				}
				return false;
			}
			if (!renderer.isVisible || !renderer.enabled)
			{
				return false;
			}
			Camera camera = ((this.renderCamera != null) ? this.renderCamera : Camera.main);
			if (camera == null)
			{
				return true;
			}
			Bounds bounds = renderer.bounds;
			SkeletonAnimation skeletonAnimation = ((GirlController.kok != null) ? GirlController.kok.skeletonAnimation : null);
			Bounds bounds2;
			if (skeletonAnimation != null && skeletonAnimation.gameObject == renderer.gameObject && gh.drc(skeletonAnimation, out bounds2))
			{
				bounds = bounds2;
			}
			Vector3 min = bounds.min;
			Vector3 max = bounds.max;
			float z = bounds.center.z;
			Vector3 vector = camera.WorldToScreenPoint(new Vector3(min.x, min.y, z));
			Vector3 vector2 = camera.WorldToScreenPoint(new Vector3(max.x, min.y, z));
			Vector3 vector3 = camera.WorldToScreenPoint(new Vector3(min.x, max.y, z));
			Vector3 vector4 = camera.WorldToScreenPoint(new Vector3(max.x, max.y, z));
			float num = Mathf.Min(new float[] { vector.x, vector2.x, vector3.x, vector4.x });
			float num2 = Mathf.Max(new float[] { vector.x, vector2.x, vector3.x, vector4.x });
			float num3 = Mathf.Min(new float[] { vector.y, vector2.y, vector3.y, vector4.y });
			float num4 = Mathf.Max(new float[] { vector.y, vector2.y, vector3.y, vector4.y });
			return a.x >= num && a.x <= num2 && a.y >= num3 && a.y <= num4;
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x00059DD4 File Offset: 0x00057FD4
		private Renderer cri()
		{
			if (this.characterRenderer != null && this.characterRenderer.gameObject.activeInHierarchy)
			{
				return this.characterRenderer;
			}
			GirlController girlController = global::UnityEngine.Object.FindObjectOfType<GirlController>();
			if (girlController != null && girlController.skeletonAnimation != null && girlController.skeletonAnimation.gameObject.activeInHierarchy)
			{
				MeshRenderer component = girlController.skeletonAnimation.GetComponent<MeshRenderer>();
				if (component != null)
				{
					return component;
				}
			}
			r r = global::UnityEngine.Object.FindObjectOfType<r>();
			if (r != null)
			{
				if (r.skeletonAnimation != null && r.skeletonAnimation.gameObject.activeInHierarchy)
				{
					MeshRenderer component2 = r.skeletonAnimation.GetComponent<MeshRenderer>();
					if (component2 != null)
					{
						return component2;
					}
				}
				if (r.imageSpriteRenderer != null && r.imageSpriteRenderer.gameObject.activeInHierarchy)
				{
					return r.imageSpriteRenderer;
				}
			}
			return null;
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x00059EBC File Offset: 0x000580BC
		private void crj(Vector2 a)
		{
			if (SettingPanel.kqq == null)
			{
				Debug.LogWarning(a.dqk());
				return;
			}
			if (this.menuAnchor != null)
			{
				SettingPanel.kqq.cam(this.menuAnchor);
				return;
			}
			if (!this.ijt)
			{
				Debug.LogWarning(a.dql());
				this.ijt = true;
			}
			Vector2 vector = a;
			Camera camera = ((this.renderCamera != null) ? this.renderCamera : Camera.main);
			Renderer renderer = this.cri();
			if (camera != null && renderer != null)
			{
				Vector3 center = renderer.bounds.center;
				Vector3 vector2 = camera.WorldToScreenPoint(center);
				vector = new Vector2(vector2.x, vector2.y);
			}
			SettingPanel.kqq.can(vector + this.fallbackOffset);
		}

		// Token: 0x04000967 RID: 2407
		[SerializeField]
		private RectTransform menuAnchor;

		// Token: 0x04000968 RID: 2408
		[SerializeField]
		private Vector2 fallbackOffset = new Vector2(-200f, 100f);

		// Token: 0x04000969 RID: 2409
		[SerializeField]
		private Renderer characterRenderer;

		// Token: 0x0400096A RID: 2410
		[SerializeField]
		private RectTransform[] excludeUIRects;

		// Token: 0x0400096B RID: 2411
		[SerializeField]
		private Camera renderCamera;

		// Token: 0x0400096C RID: 2412
		private bool ijt;

		// Token: 0x0400096E RID: 2414
		private bool ijv;
	}
}
