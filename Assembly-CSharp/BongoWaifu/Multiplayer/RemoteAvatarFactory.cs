using System;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using UnityEngine;

namespace BongoWaifu.Multiplayer
{
	// Token: 0x0200012D RID: 301
	public sealed class RemoteAvatarFactory : MonoBehaviour
	{
		// Token: 0x06001600 RID: 5632 RVA: 0x0006B648 File Offset: 0x00069848
		private void OnEnable()
		{
			MultiplayerSession.ivc += this.dmz;
			MultiplayerSession.ivd += this.dna;
			MultiplayerSession.ive += this.dnb;
			MultiplayerSession.ivg += this.dnc;
			MultiplayerSession.ivh += this.dnd;
			for (int i = 0; i < MultiplayerSession.kuk.Count; i++)
			{
				this.dmz(MultiplayerSession.kuk[i]);
			}
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x0006B6D0 File Offset: 0x000698D0
		private void OnDisable()
		{
			MultiplayerSession.ivc -= this.dmz;
			MultiplayerSession.ivd -= this.dna;
			MultiplayerSession.ive -= this.dnb;
			MultiplayerSession.ivg -= this.dnc;
			MultiplayerSession.ivh -= this.dnd;
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x0006B734 File Offset: 0x00069934
		private void dmz(gb a)
		{
			if (a == null || this.remoteAvatarPrefab == null)
			{
				return;
			}
			if (a.iuq != null)
			{
				return;
			}
			if (base.GetComponent<gd>() == null)
			{
				base.gameObject.AddComponent<gd>();
			}
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.remoteAvatarPrefab, (this.avatarParent != null) ? this.avatarParent : base.transform);
			a.iuq = gameObject.transform;
			a.iur = gameObject.GetComponentInChildren<Renderer>();
			a.ius = gameObject.GetComponentInChildren<RemoteWaifuView>(true);
			a.iut = gameObject.GetComponentInChildren<RemoteCatView>(true);
			RemoteAvatarPlacement remoteAvatarPlacement = gameObject.GetComponent<RemoteAvatarPlacement>();
			if (remoteAvatarPlacement == null)
			{
				remoteAvatarPlacement = gameObject.GetComponentInChildren<RemoteAvatarPlacement>(true);
			}
			if (remoteAvatarPlacement != null)
			{
				remoteAvatarPlacement.dnn(a.iul);
				remoteAvatarPlacement.dnp(a.ium);
				remoteAvatarPlacement.dnq(a.iup);
				remoteAvatarPlacement.dnr(a.iuv);
			}
			a.iuu = remoteAvatarPlacement;
			RemoteWaifuView ius = a.ius;
			if (ius != null)
			{
				ius.dqg(a.iul);
			}
			fq.dbg(string.Format(a.egr(), new object[]
			{
				a.ium,
				fq.dbh(a.ius),
				fq.dbh(a.iut),
				fq.dbh(remoteAvatarPlacement),
				fq.dbh(a.iur),
				gameObject.transform.position,
				gameObject.transform.localScale
			}));
			this.dne(a);
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x0006B8C4 File Offset: 0x00069AC4
		private void dna(gb a)
		{
			if (a == null)
			{
				return;
			}
			RemoteWaifuView ius = a.ius;
			if (ius != null)
			{
				ius.dra();
			}
			if (a.iuq != null)
			{
				global::UnityEngine.Object.Destroy(a.iuq.gameObject);
			}
			a.iuq = null;
			a.iur = null;
			a.ius = null;
			a.iut = null;
			a.iuu = null;
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x0006B928 File Offset: 0x00069B28
		private void dnb(gb a)
		{
			if (a == null)
			{
				return;
			}
			if (a.iuu != null)
			{
				a.iuu.dnn(a.iul);
				a.iuu.dnp(a.ium);
				a.iuu.dnq(a.iup);
				a.iuu.dnr(a.iuv);
			}
			RemoteWaifuView ius = a.ius;
			if (ius != null)
			{
				ius.dqg(a.iul);
			}
			this.dne(a);
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x0006B9AC File Offset: 0x00069BAC
		private void dnc(gb a, InteractionType b, NetworkPlayer c, Vector2 d)
		{
			if (c != null && c == MultiplayerSession.iux)
			{
				return;
			}
			if (a == null)
			{
				return;
			}
			if (a.iun == CharacterKind.Cat)
			{
				RemoteCatView iut = a.iut;
				if (iut == null)
				{
					return;
				}
				iut.doy();
				return;
			}
			else
			{
				RemoteWaifuView ius = a.ius;
				if (ius == null)
				{
					return;
				}
				ius.dqw();
				return;
			}
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x0006B9FE File Offset: 0x00069BFE
		private void dnd(gb a)
		{
			if (a != null)
			{
				RemoteCatView iut = a.iut;
				if (iut == null)
				{
					return;
				}
				iut.doy();
			}
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x0006BA14 File Offset: 0x00069C14
		private void dne(gb a)
		{
			if (a == null || a.iup == null || a.iuq == null)
			{
				if (fq.iro)
				{
					fq.dbg(string.Concat(new string[]
					{
						a.egs(),
						fq.dbh(a),
						a.egt(),
						fq.dbh((a != null) ? a.iup : null),
						a.egu(),
						fq.dbh((a != null) ? a.iuq : null)
					}));
				}
				return;
			}
			if (fq.iro)
			{
				fq.dbg(string.Format(a.egv(), new object[]
				{
					a.ium,
					a.iup.kur,
					fq.dbi(a.iup.kut),
					a.iup.kuv,
					a.iup.kuw,
					a.iup.kuy
				}));
			}
			if (a.iup.kur == CharacterKind.Cat)
			{
				CatCharacterDefinition catCharacterDefinition = RemoteAvatarFactory.dng(a.iup.kus);
				if (catCharacterDefinition != null)
				{
					RemoteAvatarPlacement iuu = a.iuu;
					if (iuu != null)
					{
						iuu.dnl(CharacterKind.Cat, catCharacterDefinition.characterScale);
					}
					RemoteWaifuView ius = a.ius;
					if (ius != null)
					{
						ius.dql(false);
					}
					RemoteAvatarFactory.dnf(a, false);
					RemoteCatView iut = a.iut;
					if (iut == null)
					{
						return;
					}
					iut.dov(catCharacterDefinition);
					return;
				}
			}
			RemoteAvatarPlacement iuu2 = a.iuu;
			if (iuu2 != null)
			{
				iuu2.dnl(CharacterKind.Waifu, Vector2.one);
			}
			RemoteWaifuView ius2 = a.ius;
			if (ius2 != null)
			{
				ius2.dql(true);
			}
			RemoteAvatarFactory.dnf(a, true);
			if (a.ius != null)
			{
				a.ius.dqp(a.iup.kut);
				a.ius.dqh(a.iup.kuu);
				a.ius.dqq(a.iup.kuv);
				a.ius.dqu(a.iup.kuw);
				a.ius.dqv(a.iup.kuy);
			}
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x0006BC3C File Offset: 0x00069E3C
		private static void dnf(gb a, bool b)
		{
			GameObject gameObject = ((a.ius != null) ? a.ius.gameObject : null);
			GameObject gameObject2 = ((a.iut != null) ? a.iut.gameObject : null);
			GameObject gameObject3 = (b ? gameObject : gameObject2);
			GameObject gameObject4 = (b ? gameObject2 : gameObject);
			if (gameObject3 != null && !gameObject3.activeSelf)
			{
				gameObject3.SetActive(true);
			}
			if (gameObject4 != null && gameObject4 != gameObject3 && gameObject4.activeSelf)
			{
				gameObject4.SetActive(false);
			}
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x0006BCCC File Offset: 0x00069ECC
		private static CatCharacterDefinition dng(string a)
		{
			if (string.IsNullOrEmpty(a) || eb.krm == null)
			{
				return null;
			}
			IReadOnlyList<CatCharacterDefinition> readOnlyList = eb.krm.krl;
			for (int i = 0; i < readOnlyList.Count; i++)
			{
				CatCharacterDefinition catCharacterDefinition = readOnlyList[i];
				if (catCharacterDefinition != null && catCharacterDefinition.characterId == a && catCharacterDefinition.unlockType != CatUnlockType.Workshop)
				{
					return catCharacterDefinition;
				}
			}
			return null;
		}

		// Token: 0x04000B1F RID: 2847
		[SerializeField]
		private GameObject remoteAvatarPrefab;

		// Token: 0x04000B20 RID: 2848
		[SerializeField]
		private Transform avatarParent;
	}
}
