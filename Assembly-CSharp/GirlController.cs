using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using AOT;
using FMOD;
using FMOD.Studio;
using FMODUnity;
using Ricimi;
using Spine;
using Spine.Unity;
using TMPro;
using UnityEngine;

// Token: 0x02000047 RID: 71
public class GirlController : MonoBehaviour
{
	// Token: 0x17000066 RID: 102
	// (get) Token: 0x0600042D RID: 1069 RVA: 0x00014E42 File Offset: 0x00013042
	public float kog
	{
		get
		{
			return this.hpg;
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x0600042E RID: 1070 RVA: 0x00014E4A File Offset: 0x0001304A
	public int koh
	{
		get
		{
			return Mathf.RoundToInt(this.hpe);
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x0600042F RID: 1071 RVA: 0x00014E57 File Offset: 0x00013057
	public bool koi
	{
		get
		{
			return this.hpl;
		}
	}

	// Token: 0x1400000B RID: 11
	// (add) Token: 0x06000430 RID: 1072 RVA: 0x00014E60 File Offset: 0x00013060
	// (remove) Token: 0x06000431 RID: 1073 RVA: 0x00014E94 File Offset: 0x00013094
	public static event Action<int> hpv;

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x06000432 RID: 1074 RVA: 0x00014EC7 File Offset: 0x000130C7
	public int koj
	{
		get
		{
			if (!(bq.hlf != null))
			{
				return 0;
			}
			return bq.hlf.playerSaveData.dirtinessLevel;
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x06000433 RID: 1075 RVA: 0x00014EE7 File Offset: 0x000130E7
	public static GirlController kok
	{
		get
		{
			return GirlController.hqa;
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x06000434 RID: 1076 RVA: 0x00014EEE File Offset: 0x000130EE
	public bf kol
	{
		get
		{
			return this.dickBottomOverride;
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x06000435 RID: 1077 RVA: 0x00014EF6 File Offset: 0x000130F6
	public bool kom
	{
		get
		{
			return this.hqb && this.skeleton != null && this.skeleton.Data != null;
		}
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x00014F18 File Offset: 0x00013118
	private void Start()
	{
		this.hpe = 0f;
		this.hpg = 0f;
		this.hpl = false;
		this.hpa = new HashSet<string>(this.clothes);
		if (this.slider_Love != null)
		{
			this.slider_Love.Percentage = this.hpe;
		}
		if (this.text_Orgasm)
		{
			this.text_Orgasm.text = this.hph.ToString();
		}
		this.skeleton = this.skeletonAnimation.Skeleton;
		GirlController.hqa = this;
		this.skeletonAnimation.AnimationState.Event += this.bgf;
		this.hpw = this.skeleton.Data.FindEvent(GirlController.hpx);
		this.hpy = this.skeleton.Data.FindEvent(GirlController.hpz);
		GirlController.hpc.Clear();
		foreach (GirlController.WaifuSoundEffect waifuSoundEffect in this.waifuSoundEffects)
		{
			if (!string.IsNullOrEmpty(waifuSoundEffect.soundName) && waifuSoundEffect.effect != null)
			{
				GirlController.hpc[waifuSoundEffect.soundName] = waifuSoundEffect.effect;
			}
		}
		this.hqb = true;
		this.bfs(true);
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x0001505A File Offset: 0x0001325A
	public void OnDestroy()
	{
		this.skeletonAnimation.AnimationState.Event -= this.bgf;
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x00015078 File Offset: 0x00013278
	public void bfc()
	{
		if (this.skeletonAnimation == null)
		{
			return;
		}
		TrackEntry current = this.skeletonAnimation.AnimationState.GetCurrent(0);
		if (current == null || current.Animation == null)
		{
			switch (this.state)
			{
			case GirlController.GIRL_STATE.Idle:
				this.skeletonAnimation.AnimationState.SetAnimation(0, (bq.hmd && this.bfl(a.vl())) ? a.vl() : a.iv(), true);
				break;
			case GirlController.GIRL_STATE.Idle_H:
				this.skeletonAnimation.AnimationState.SetAnimation(0, a.vm(), true);
				break;
			case GirlController.GIRL_STATE.Idle_H_End:
				this.skeletonAnimation.AnimationState.SetAnimation(0, (bq.hmd && this.bfl(a.vn())) ? a.vn() : a.vo(), true);
				break;
			default:
				this.state = GirlController.GIRL_STATE.Idle;
				this.skeletonAnimation.AnimationState.SetAnimation(0, (bq.hmd && this.bfl(a.vl())) ? a.vl() : a.iv(), true);
				break;
			}
		}
		TrackEntry current2 = this.skeletonAnimation.AnimationState.GetCurrent(5);
		if (current2 == null || current2.Animation == null)
		{
			this.bfq(this.hpf);
		}
		TrackEntry current3 = this.skeletonAnimation.AnimationState.GetCurrent(6);
		if (current3 == null || current3.Animation == null)
		{
			this.hpt = -1;
			this.bfs(true);
		}
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x000151F0 File Offset: 0x000133F0
	public bool bfd()
	{
		if (this.hpl)
		{
			return false;
		}
		this.hpe += 0.75f;
		this.hpg += 0.2f;
		if (this.hpm >= this.hpn)
		{
			switch (this.state)
			{
			case GirlController.GIRL_STATE.Idle:
				this.bfo();
				this.hpm = 0f;
				this.hpn = 0.5f;
				this.hpo = 0f;
				return true;
			case GirlController.GIRL_STATE.Idle_H:
				this.bfh();
				this.hpm = 0f;
				this.hpn = 0.05f;
				this.hpo = 0f;
				return true;
			case GirlController.GIRL_STATE.Idle_H_End:
				this.bfo();
				this.hpm = 0f;
				this.hpn = 0.5f;
				this.hpo = 0f;
				return true;
			case GirlController.GIRL_STATE.Fuck_Loop:
				this.bfh();
				this.hpm = 0f;
				this.hpn = 0.05f;
				this.hpo = 0f;
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x00015308 File Offset: 0x00013508
	public void bfe()
	{
		if (this.hpl)
		{
			if (this.state != GirlController.GIRL_STATE.Fuck_End && this.state != GirlController.GIRL_STATE.Idle_H_End)
			{
				this.bfp();
				return;
			}
		}
		else
		{
			if (this.hpe <= 0f)
			{
				this.bfi();
			}
			if (this.state == GirlController.GIRL_STATE.Idle_H || this.state == GirlController.GIRL_STATE.Idle_H_End)
			{
				this.hpo += Time.deltaTime;
				if (this.hpo > 20f)
				{
					this.bfi();
					this.hpo = 0f;
				}
			}
		}
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x0001538C File Offset: 0x0001358C
	public void bff()
	{
		int num;
		if (this.hpg > 75f)
		{
			num = 3;
		}
		else if (this.hpg > 50f)
		{
			num = 2;
		}
		else if (this.hpg > 25f)
		{
			num = 1;
		}
		else
		{
			num = 0;
		}
		if (num != this.hpk)
		{
			this.hpk = num;
			this.bfq(num);
		}
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x000153E8 File Offset: 0x000135E8
	private void bfg()
	{
		EventReference eventReference = bq.zy(new Func<VoiceProfile, EventReference>(GirlController.<>c.<>9.ben), this.soundEnd_VC);
		if (eventReference.IsNull || this.soundEnd_SFX.IsNull || AudioManager.klw == null)
		{
			return;
		}
		AudioManager.klw.qw(eventReference, bx.hod.koe, 1f);
		AudioManager.klw.qw(this.soundEnd_SFX, bx.hod.koe, 1f);
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x00015480 File Offset: 0x00013680
	public void bfh()
	{
		this.state = GirlController.GIRL_STATE.Fuck_Loop;
		int num = global::UnityEngine.Random.Range(0, 4);
		string text = GirlController.GIRL_LOOP.Fuck_Loop_00.ToString();
		if (num >= 0 && num < 4)
		{
			GirlController.GIRL_LOOP girl_LOOP = (GirlController.GIRL_LOOP)num;
			text = girl_LOOP.ToString();
		}
		this.bfy(1, text, false, null, 0.3f, MixBlend.First);
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x000154D4 File Offset: 0x000136D4
	public void bfi()
	{
		if (this.state == GirlController.GIRL_STATE.Idle)
		{
			return;
		}
		this.state = GirlController.GIRL_STATE.Idle;
		this.bfm(GirlController.GIRL_STATE.Idle, a.iv(), a.vl());
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x000154F7 File Offset: 0x000136F7
	public void bfj()
	{
		if (this.state == GirlController.GIRL_STATE.Idle_H)
		{
			return;
		}
		this.state = GirlController.GIRL_STATE.Idle_H;
		this.bfx(0, a.vm(), true, true, null, -1f);
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x0001551E File Offset: 0x0001371E
	public void bfk()
	{
		if (this.state == GirlController.GIRL_STATE.Idle_H_End)
		{
			return;
		}
		this.state = GirlController.GIRL_STATE.Idle_H_End;
		this.bfm(GirlController.GIRL_STATE.Idle_H_End, a.vo(), a.vn());
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x00015542 File Offset: 0x00013742
	private bool bfl(string a)
	{
		return this.skeleton != null && this.skeleton.Data != null && this.skeleton.Data.FindAnimation(a) != null;
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x00015570 File Offset: 0x00013770
	private void bfm(GirlController.GIRL_STATE a, string b, string c)
	{
		GirlController.cb cb = new GirlController.cb();
		cb.hov = this;
		cb.how = a;
		cb.hox = c;
		if (bq.hmd && this.bfl(cb.hox))
		{
			this.bfx(0, b, false, true, new Action(cb.beq), -1f);
			return;
		}
		this.bfx(0, b, true, true, null, -1f);
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x000155DC File Offset: 0x000137DC
	public void bfn()
	{
		GirlController.GIRL_STATE girl_STATE = this.state;
		if (girl_STATE == GirlController.GIRL_STATE.Idle)
		{
			this.bfx(0, (bq.hmd && this.bfl(a.vl())) ? a.vl() : a.iv(), true, true, null, 0f);
			return;
		}
		if (girl_STATE != GirlController.GIRL_STATE.Idle_H_End)
		{
			return;
		}
		this.bfx(0, (bq.hmd && this.bfl(a.vn())) ? a.vn() : a.vo(), true, true, null, 0f);
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x00015658 File Offset: 0x00013858
	public void bfo()
	{
		if (this.state == GirlController.GIRL_STATE.Fuck_Start)
		{
			return;
		}
		this.state = GirlController.GIRL_STATE.Fuck_Start;
		if (AudioManager.klw != null)
		{
			AudioManager.klw.qw(this.soundThrust, bx.hod.koe, 1f);
			EventReference eventReference = bq.zy(new Func<VoiceProfile, EventReference>(GirlController.<>c.<>9.beo), this.soundLoopWaifu);
			if (!eventReference.IsNull)
			{
				EventInstance eventInstance = AudioManager.klw.qw(eventReference, bx.hod.koe, 1f);
				if (eventInstance.isValid() && this.waifuSoundEffects.Length != 0)
				{
					eventInstance.setCallback(new EVENT_CALLBACK(GirlController.bgd), EVENT_CALLBACK_TYPE.SOUND_PLAYED);
				}
			}
		}
		this.bfx(0, a.vp(), false, true, new Action(this.bgg), -1f);
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00015740 File Offset: 0x00013940
	public void bfp()
	{
		if (this.state == GirlController.GIRL_STATE.Fuck_End)
		{
			return;
		}
		this.hpg += 5f;
		this.state = GirlController.GIRL_STATE.Fuck_End;
		this.bfg();
		this.bfx(0, a.vq(), false, true, new Action(this.bgh), -1f);
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00015798 File Offset: 0x00013998
	public void bfq(int a = 0)
	{
		this.hpf = a;
		switch (a)
		{
		case 0:
			this.bfx(5, a.vr(), true, true, null, -1f);
			return;
		case 1:
			this.bfx(5, a.vs(), true, true, null, -1f);
			return;
		case 2:
			this.bfx(5, a.vt(), true, true, null, -1f);
			return;
		case 3:
			this.bfx(5, a.vu(), true, true, null, -1f);
			return;
		default:
			return;
		}
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x00015818 File Offset: 0x00013A18
	private void bfr(int a, bool b)
	{
		a = Mathf.Clamp(a, 0, 10);
		if (a == this.hpt)
		{
			return;
		}
		if (this.skeletonAnimation == null || this.skeleton == null || this.skeleton.Data == null)
		{
			return;
		}
		string text = string.Format(a.vv(), a);
		if (this.skeleton.Data.FindAnimation(text) == null)
		{
			this.hpt = a;
			Action<int> action = GirlController.hpv;
			if (action == null)
			{
				return;
			}
			action(a);
			return;
		}
		else
		{
			this.skeletonAnimation.AnimationState.SetAnimation(6, text, true).MixDuration = (b ? 0f : 1f);
			this.hpt = a;
			Action<int> action2 = GirlController.hpv;
			if (action2 == null)
			{
				return;
			}
			action2(a);
			return;
		}
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x000158DA File Offset: 0x00013ADA
	private void bfs(bool a)
	{
		this.bfr(this.koj, a);
	}

	// Token: 0x06000449 RID: 1097 RVA: 0x000158E9 File Offset: 0x00013AE9
	public void bft()
	{
		this.hpt = -1;
		this.bfs(true);
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x000158FC File Offset: 0x00013AFC
	private void bfu()
	{
		if (bq.hmb == DirtinessMode.Off)
		{
			return;
		}
		PlayerData hlf = bq.hlf;
		PlayerSaveData playerSaveData = ((hlf != null) ? hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		this.hpu = 0f;
		if (playerSaveData.dirtinessLevel >= 10)
		{
			return;
		}
		playerSaveData.dirtinessLevel = Mathf.Min(playerSaveData.dirtinessLevel + 1, 10);
		this.bfr(playerSaveData.dirtinessLevel, false);
		ci.Save(null);
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x00015968 File Offset: 0x00013B68
	private void bfv()
	{
		if (bq.hmb != DirtinessMode.OverTime)
		{
			this.hpu = 0f;
			return;
		}
		PlayerData hlf = bq.hlf;
		PlayerSaveData playerSaveData = ((hlf != null) ? hlf.playerSaveData : null);
		if (playerSaveData == null || playerSaveData.dirtinessLevel <= 0)
		{
			this.hpu = 0f;
			return;
		}
		this.hpu += Time.deltaTime;
		if (this.hpu >= 90f)
		{
			this.hpu -= 90f;
			playerSaveData.dirtinessLevel = Mathf.Max(playerSaveData.dirtinessLevel - 1, 0);
			this.bfr(playerSaveData.dirtinessLevel, false);
		}
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x00015A08 File Offset: 0x00013C08
	public void bfw()
	{
		PlayerData hlf = bq.hlf;
		PlayerSaveData playerSaveData = ((hlf != null) ? hlf.playerSaveData : null);
		if (playerSaveData == null)
		{
			return;
		}
		this.hpu = 0f;
		if (playerSaveData.dirtinessLevel != 0)
		{
			playerSaveData.dirtinessLevel = 0;
			this.bfr(0, true);
			ci.Save(null);
			return;
		}
		Action<int> action = GirlController.hpv;
		if (action == null)
		{
			return;
		}
		action(0);
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x00015A64 File Offset: 0x00013C64
	public void Update()
	{
		GirlController.ParticleEffectGroup particleEffectGroup;
		while (GirlController.hpd.TryDequeue(out particleEffectGroup))
		{
			particleEffectGroup.bel();
		}
		this.hpb -= Time.deltaTime;
		this.hpg -= Time.deltaTime * 0.5555556f;
		this.hpg = Mathf.Clamp(this.hpg, 0f, 100f);
		this.hpm += Time.deltaTime;
		if (!this.hpl)
		{
			float num = this.hpe / 100f;
			float num2 = ((this.loveDecayDuration > 0f) ? (60f / this.loveDecayDuration) : 1f);
			this.hpe -= Time.deltaTime * Mathf.Lerp(0.916f, 2.747f, num) * num2;
		}
		else
		{
			this.hpe -= Time.deltaTime * 15f;
			if (this.hpe < 10f)
			{
				this.hpl = false;
			}
		}
		if (this.hpe < 0f)
		{
			this.hpe = 0f;
		}
		else if (this.hpe > 100f)
		{
			this.hpe = 100f;
			this.hph++;
			this.hpl = true;
			if (du.iah != null)
			{
				du.iah.cec(du.STEAM_STAT_ID.STAT_ORGASM, 1, du.STEAM_STAT_OP.Add);
			}
			this.bfu();
		}
		if (this.slider_Love != null && !Mathf.Approximately(this.hpe, this.hpj))
		{
			this.hpj = this.hpe;
			this.slider_Love.Percentage = this.hpe;
		}
		if (this.text_Orgasm != null && this.hph != this.hpi)
		{
			this.hpi = this.hph;
			this.text_Orgasm.text = this.hph.ToString();
		}
		this.bfe();
		this.bff();
		this.bfv();
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00015C5C File Offset: 0x00013E5C
	public void ChangeClothe()
	{
		this.bfx(2, a.vw(), false, false, null, -1f);
		this.skeletonAnimation.AnimationState.SetAnimation(1, a.vw(), false).MixBlend = MixBlend.First;
		this.skeletonAnimation.AnimationState.AddEmptyAnimation(1, 0.3f, 0f);
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x00015CB8 File Offset: 0x00013EB8
	public void bfx(int a, string b, bool c, bool d = true, Action e = null, float f = -1f)
	{
		GirlController.cc cc = new GirlController.cc();
		cc.hoy = e;
		TrackEntry current = this.skeletonAnimation.AnimationState.GetCurrent(a);
		if (d && current != null && current.Animation.Name == b)
		{
			return;
		}
		if (a > 0)
		{
			this.skeletonAnimation.AnimationState.ClearTrack(a);
			this.skeletonAnimation.AnimationState.SetEmptyAnimation(a, 0f);
		}
		TrackEntry trackEntry = this.skeletonAnimation.AnimationState.SetAnimation(a, b, c);
		if (f >= 0f)
		{
			trackEntry.MixDuration = f;
		}
		if (a > 0 && !c)
		{
			this.skeletonAnimation.AnimationState.AddEmptyAnimation(a, 0.1f, 0f);
		}
		if (cc.hoy != null)
		{
			trackEntry.Complete += cc.ber;
		}
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x00015D90 File Offset: 0x00013F90
	public void bfy(int a, string b, bool c, Action d = null, float e = 0.5f, MixBlend f = MixBlend.Setup)
	{
		GirlController.cd cd = new GirlController.cd();
		cd.hoz = d;
		TrackEntry trackEntry = this.skeletonAnimation.AnimationState.SetAnimation(a, b, c);
		if (a > 0)
		{
			trackEntry.MixBlend = f;
			this.skeletonAnimation.AnimationState.AddEmptyAnimation(a, e, 0f);
		}
		if (cd.hoz != null)
		{
			trackEntry.Complete += cd.bes;
		}
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x00015DFE File Offset: 0x00013FFE
	public void bfz(string a)
	{
		if (this.hpa.Add(a))
		{
			this.clothes.Add(a);
		}
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x00015E1A File Offset: 0x0001401A
	public void bga(string a)
	{
		if (this.hpa.Remove(a))
		{
			this.clothes.Remove(a);
		}
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x00015E37 File Offset: 0x00014037
	public void bgb()
	{
		this.clothes.Clear();
		this.hpa.Clear();
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x00015E50 File Offset: 0x00014050
	public void bgc()
	{
		Skin skin = new Skin(a.vx());
		for (int i = 0; i < this.clothes.Count; i++)
		{
			Skin skin2 = this.skeleton.Data.FindSkin(this.clothes[i]);
			if (skin2 != null)
			{
				skin.AddSkin(skin2);
			}
		}
		this.skeleton.SetSkin(skin);
		this.skeleton.SetSlotsToSetupPose();
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x00015EBC File Offset: 0x000140BC
	[MonoPInvokeCallback(typeof(EVENT_CALLBACK))]
	private static RESULT bgd(EVENT_CALLBACK_TYPE a, IntPtr b, IntPtr c)
	{
		if (a == EVENT_CALLBACK_TYPE.SOUND_PLAYED)
		{
			Sound sound = default(Sound);
			sound.handle = c;
			string text;
			sound.getName(out text, 256);
			GirlController.ParticleEffectGroup particleEffectGroup = GirlController.bge(Path.GetFileNameWithoutExtension(text));
			if (particleEffectGroup != null)
			{
				GirlController.hpd.Enqueue(particleEffectGroup);
			}
		}
		return RESULT.OK;
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x00015F0C File Offset: 0x0001410C
	private static GirlController.ParticleEffectGroup bge(string a)
	{
		GirlController.ParticleEffectGroup particleEffectGroup;
		if (GirlController.hpc.TryGetValue(a, out particleEffectGroup))
		{
			return particleEffectGroup;
		}
		string text = Regex.Replace(a, a.vy(), a.vz());
		if (GirlController.hpc.TryGetValue(text, out particleEffectGroup))
		{
			return particleEffectGroup;
		}
		int num = text.LastIndexOf('_');
		if (num > 0 && GirlController.hpc.TryGetValue(text.Substring(0, num), out particleEffectGroup))
		{
			return particleEffectGroup;
		}
		return null;
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x00015F74 File Offset: 0x00014174
	private void bgf(TrackEntry a, Event b)
	{
		if (this.hpw == b.Data)
		{
			if (AudioManager.klw != null)
			{
				AudioManager.klw.qw(this.soundThrust, bx.hod.koe, 1f);
			}
			if (this.hpb > 0f)
			{
				return;
			}
			if (global::UnityEngine.Random.Range(0f, 100f) < 30f)
			{
				EventReference eventReference = bq.zy(new Func<VoiceProfile, EventReference>(GirlController.<>c.<>9.bep), this.soundLoopWaifu);
				if (AudioManager.klw != null && !eventReference.IsNull)
				{
					EventInstance eventInstance = AudioManager.klw.qw(eventReference, bx.hod.koe, 1f);
					if (eventInstance.isValid() && this.waifuSoundEffects.Length != 0)
					{
						eventInstance.setCallback(new EVENT_CALLBACK(GirlController.bgd), EVENT_CALLBACK_TYPE.SOUND_PLAYED);
					}
				}
				this.hpb = 0.5f;
			}
		}
		if (this.hpy == b.Data)
		{
			switch (this.hpf)
			{
			case 0:
				break;
			case 1:
				this.ef_Loop_Level01.bel();
				return;
			case 2:
				if (global::UnityEngine.Random.value < 0.3f)
				{
					this.ef_Loop_Level02.bel();
					if (AudioManager.klw != null)
					{
						AudioManager.klw.qw(this.soundSquirtSmall, bx.hod.koe, 1f);
						return;
					}
				}
				break;
			case 3:
				if (global::UnityEngine.Random.value < 0.3f)
				{
					this.ef_Loop_Level03.bel();
					if (AudioManager.klw != null)
					{
						AudioManager.klw.qw(this.soundSquirtBig, bx.hod.koe, 1f);
					}
				}
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x0600045A RID: 1114 RVA: 0x000161FA File Offset: 0x000143FA
	[CompilerGenerated]
	private void bgg()
	{
		this.bfj();
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x00016202 File Offset: 0x00014402
	[CompilerGenerated]
	private void bgh()
	{
		this.bfk();
	}

	// Token: 0x0400020F RID: 527
	public GirlController.GIRL_STATE state;

	// Token: 0x04000210 RID: 528
	public SkeletonAnimation skeletonAnimation;

	// Token: 0x04000211 RID: 529
	public Skeleton skeleton;

	// Token: 0x04000212 RID: 530
	public CircularProgressBar slider_Love;

	// Token: 0x04000213 RID: 531
	public bz sizeController;

	// Token: 0x04000214 RID: 532
	public TextMeshProUGUI text_Orgasm;

	// Token: 0x04000215 RID: 533
	public List<string> clothes = new List<string>();

	// Token: 0x04000216 RID: 534
	private HashSet<string> hpa = new HashSet<string>();

	// Token: 0x04000217 RID: 535
	public EventReference soundLoopWaifu;

	// Token: 0x04000218 RID: 536
	public GirlController.WaifuSoundEffect[] waifuSoundEffects = new GirlController.WaifuSoundEffect[0];

	// Token: 0x04000219 RID: 537
	public EventReference soundThrust;

	// Token: 0x0400021A RID: 538
	public EventReference soundSquirtSmall;

	// Token: 0x0400021B RID: 539
	public EventReference soundSquirtBig;

	// Token: 0x0400021C RID: 540
	public EventReference soundEnd_VC;

	// Token: 0x0400021D RID: 541
	public EventReference soundEnd_SFX;

	// Token: 0x0400021E RID: 542
	private float hpb;

	// Token: 0x0400021F RID: 543
	private static Dictionary<string, GirlController.ParticleEffectGroup> hpc = new Dictionary<string, GirlController.ParticleEffectGroup>();

	// Token: 0x04000220 RID: 544
	private static ConcurrentQueue<GirlController.ParticleEffectGroup> hpd = new ConcurrentQueue<GirlController.ParticleEffectGroup>();

	// Token: 0x04000221 RID: 545
	public GirlController.ParticleEffectGroup ef_Loop_Level01 = new GirlController.ParticleEffectGroup();

	// Token: 0x04000222 RID: 546
	public GirlController.ParticleEffectGroup ef_Loop_Level02 = new GirlController.ParticleEffectGroup();

	// Token: 0x04000223 RID: 547
	public GirlController.ParticleEffectGroup ef_Loop_Level03 = new GirlController.ParticleEffectGroup();

	// Token: 0x04000224 RID: 548
	public float loveDecayDuration = 60f;

	// Token: 0x04000225 RID: 549
	private float hpe;

	// Token: 0x04000226 RID: 550
	private int hpf;

	// Token: 0x04000227 RID: 551
	private float hpg;

	// Token: 0x04000228 RID: 552
	private int hph;

	// Token: 0x04000229 RID: 553
	private int hpi = -1;

	// Token: 0x0400022A RID: 554
	private float hpj = -1f;

	// Token: 0x0400022B RID: 555
	private int hpk = -1;

	// Token: 0x0400022C RID: 556
	private bool hpl;

	// Token: 0x0400022D RID: 557
	private float hpm;

	// Token: 0x0400022E RID: 558
	private float hpn = 0.15f;

	// Token: 0x0400022F RID: 559
	private float hpo;

	// Token: 0x04000230 RID: 560
	private const int hpp = 6;

	// Token: 0x04000231 RID: 561
	private const float hpq = 1f;

	// Token: 0x04000232 RID: 562
	private const float hpr = 90f;

	// Token: 0x04000233 RID: 563
	private const int hps = 10;

	// Token: 0x04000234 RID: 564
	private int hpt = -1;

	// Token: 0x04000235 RID: 565
	private float hpu;

	// Token: 0x04000237 RID: 567
	private EventData hpw;

	// Token: 0x04000238 RID: 568
	private static string hpx = a.wa();

	// Token: 0x04000239 RID: 569
	private EventData hpy;

	// Token: 0x0400023A RID: 570
	private static string hpz = a.wb();

	// Token: 0x0400023B RID: 571
	private static GirlController hqa;

	// Token: 0x0400023C RID: 572
	[SerializeField]
	private bf dickBottomOverride;

	// Token: 0x0400023D RID: 573
	private bool hqb;

	// Token: 0x0400023E RID: 574
	private const float hqc = 0.3f;

	// Token: 0x02000048 RID: 72
	public enum GIRL_STATE
	{
		// Token: 0x04000240 RID: 576
		Idle,
		// Token: 0x04000241 RID: 577
		Idle_H,
		// Token: 0x04000242 RID: 578
		Idle_H_End,
		// Token: 0x04000243 RID: 579
		Fuck_Start,
		// Token: 0x04000244 RID: 580
		Fuck_Loop,
		// Token: 0x04000245 RID: 581
		Fuck_End
	}

	// Token: 0x02000049 RID: 73
	private enum GIRL_LOOP
	{
		// Token: 0x04000247 RID: 583
		Fuck_Loop_00,
		// Token: 0x04000248 RID: 584
		Fuck_Loop_01,
		// Token: 0x04000249 RID: 585
		Fuck_Loop_02,
		// Token: 0x0400024A RID: 586
		Fuck_Loop_03
	}

	// Token: 0x0200004A RID: 74
	[Serializable]
	public class WaifuSoundEffect
	{
		// Token: 0x0400024B RID: 587
		public string soundName;

		// Token: 0x0400024C RID: 588
		public GirlController.ParticleEffectGroup effect = new GirlController.ParticleEffectGroup();
	}

	// Token: 0x0200004B RID: 75
	[Serializable]
	public class ParticleEffectGroup
	{
		// Token: 0x0600045D RID: 1117 RVA: 0x00016220 File Offset: 0x00014420
		public void bel()
		{
			for (int i = 0; i < this.particleSystems.Length; i++)
			{
				if (this.particleSystems[i] != null)
				{
					this.particleSystems[i].Play();
				}
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00016260 File Offset: 0x00014460
		public void bem()
		{
			for (int i = 0; i < this.particleSystems.Length; i++)
			{
				if (this.particleSystems[i] != null)
				{
					this.particleSystems[i].Stop();
				}
			}
		}

		// Token: 0x0400024D RID: 589
		public ParticleSystem[] particleSystems = new ParticleSystem[0];
	}

	// Token: 0x0200004D RID: 77
	[CompilerGenerated]
	private sealed class cb
	{
		// Token: 0x06000466 RID: 1126 RVA: 0x000162CD File Offset: 0x000144CD
		internal void beq()
		{
			if (this.hov.state == this.how)
			{
				this.hov.bfx(0, this.hox, true, true, null, 0.3f);
			}
		}

		// Token: 0x04000252 RID: 594
		public GirlController hov;

		// Token: 0x04000253 RID: 595
		public GirlController.GIRL_STATE how;

		// Token: 0x04000254 RID: 596
		public string hox;
	}

	// Token: 0x0200004E RID: 78
	[CompilerGenerated]
	private sealed class cc
	{
		// Token: 0x06000468 RID: 1128 RVA: 0x000162FC File Offset: 0x000144FC
		internal void njs(TrackEntry a)
		{
			Action action = this.hoy;
			if (action == null)
			{
				return;
			}
			action();
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x000162FC File Offset: 0x000144FC
		internal void ber(TrackEntry a)
		{
			Action action = this.hoy;
			if (action == null)
			{
				return;
			}
			action();
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x000162FC File Offset: 0x000144FC
		internal void dew(TrackEntry a)
		{
			Action action = this.hoy;
			if (action == null)
			{
				return;
			}
			action();
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000162FC File Offset: 0x000144FC
		internal void zr(TrackEntry a)
		{
			Action action = this.hoy;
			if (action == null)
			{
				return;
			}
			action();
		}

		// Token: 0x04000255 RID: 597
		public Action hoy;
	}

	// Token: 0x0200004F RID: 79
	[CompilerGenerated]
	private sealed class cd
	{
		// Token: 0x0600046D RID: 1133 RVA: 0x0001630E File Offset: 0x0001450E
		internal void bes(TrackEntry a)
		{
			Action action = this.hoz;
			if (action == null)
			{
				return;
			}
			action();
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0001630E File Offset: 0x0001450E
		internal void jqo(TrackEntry a)
		{
			Action action = this.hoz;
			if (action == null)
			{
				return;
			}
			action();
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0001630E File Offset: 0x0001450E
		internal void ded(TrackEntry a)
		{
			Action action = this.hoz;
			if (action == null)
			{
				return;
			}
			action();
		}

		// Token: 0x04000256 RID: 598
		public Action hoz;
	}
}
