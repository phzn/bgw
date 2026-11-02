using System;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000239 RID: 569
	public class ThemedElement : MonoBehaviour
	{
		// Token: 0x060024D6 RID: 9430 RVA: 0x0009B06D File Offset: 0x0009926D
		private void Start()
		{
			this.gqg();
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x0009B075 File Offset: 0x00099275
		private void OnEnable()
		{
			ControlMapper.ghf(this);
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x0009B07D File Offset: 0x0009927D
		private void OnDisable()
		{
			ControlMapper.ghg(this);
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x0009B085 File Offset: 0x00099285
		public void gqg()
		{
			ControlMapper.ghh(this._elements);
		}

		// Token: 0x040011F1 RID: 4593
		[SerializeField]
		private ThemedElement.ElementInfo[] _elements;

		// Token: 0x0200023A RID: 570
		[Serializable]
		public class ElementInfo
		{
			// Token: 0x170005F0 RID: 1520
			// (get) Token: 0x060024DB RID: 9435 RVA: 0x0009B092 File Offset: 0x00099292
			public string mfq
			{
				get
				{
					return this._themeClass;
				}
			}

			// Token: 0x170005F1 RID: 1521
			// (get) Token: 0x060024DC RID: 9436 RVA: 0x0009B09A File Offset: 0x0009929A
			public Component mfr
			{
				get
				{
					return this._component;
				}
			}

			// Token: 0x040011F2 RID: 4594
			[SerializeField]
			private string _themeClass;

			// Token: 0x040011F3 RID: 4595
			[SerializeField]
			private Component _component;
		}
	}
}
