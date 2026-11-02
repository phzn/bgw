using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Rewired.Interfaces;
using Rewired.Utils;
using UnityEngine;

namespace Rewired.Localization
{
	// Token: 0x020001BB RID: 443
	public abstract class LocalizedStringProviderBase : MonoBehaviour, ILocalizedStringProvider
	{
		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x00085583 File Offset: 0x00083783
		// (set) Token: 0x06001D6A RID: 7530 RVA: 0x0008558B File Offset: 0x0008378B
		public virtual bool lrz
		{
			get
			{
				return this._prefetch;
			}
			set
			{
				this._prefetch = value;
				if (base.gameObject.activeInHierarchy && base.enabled && ReInput.isReady && ReInput.localization.localizedStringProvider == this)
				{
					ReInput.localization.prefetch = value;
				}
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001D6B RID: 7531
		protected abstract bool lry { get; }

		// Token: 0x06001D6C RID: 7532 RVA: 0x000855C8 File Offset: 0x000837C8
		protected virtual void OnEnable()
		{
			if (!this.lry)
			{
				this.eze();
			}
			this.ezi();
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x000855DF File Offset: 0x000837DF
		protected virtual void OnDisable()
		{
			if (ReInput.isReady && ReInput.localization.localizedStringProvider == this)
			{
				ReInput.localization.localizedStringProvider = null;
			}
			ReInput.InitializedEvent -= this.ezi;
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x00005090 File Offset: 0x00003290
		protected virtual void Update()
		{
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x00085614 File Offset: 0x00083814
		protected virtual void ezi()
		{
			ReInput.InitializedEvent -= this.ezi;
			ReInput.InitializedEvent += this.ezi;
			if (!ReInput.isReady)
			{
				return;
			}
			if (!UnityTools.IsNullOrDestroyed<ILocalizedStringProvider>(ReInput.localization.localizedStringProvider))
			{
				Debug.LogWarning(a.eow());
				return;
			}
			ReInput.localization.localizedStringProvider = this;
			ReInput.localization.prefetch = this._prefetch;
		}

		// Token: 0x06001D70 RID: 7536
		protected abstract bool eze();

		// Token: 0x06001D71 RID: 7537 RVA: 0x00085684 File Offset: 0x00083884
		public virtual void ezj()
		{
			this.eze();
			if (base.gameObject.activeInHierarchy && base.enabled && ReInput.isReady && ReInput.localization.localizedStringProvider == this)
			{
				ReInput.localization.Reload();
			}
		}

		// Token: 0x06001D72 RID: 7538
		protected abstract bool TryGetLocalizedString(string key, out string result);

		// Token: 0x06001D73 RID: 7539 RVA: 0x000856C0 File Offset: 0x000838C0
		bool ILocalizedStringProvider.ezk(string a, out string b)
		{
			return this.TryGetLocalizedString(a, out b);
		}

		// Token: 0x04000F33 RID: 3891
		[SerializeField]
		private bool _prefetch;
	}
}
