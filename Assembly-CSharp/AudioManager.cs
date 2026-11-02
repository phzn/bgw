using System;
using System.Collections;
using System.Collections.Generic;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using FMOD;
using FMOD.Studio;
using FMODUnity;
using Unity.Mathematics;
using UnityEngine;

// Token: 0x02000009 RID: 9
public class AudioManager : MonoBehaviour
{
	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000072 RID: 114 RVA: 0x00004411 File Offset: 0x00002611
	public static AudioManager klw
	{
		get
		{
			return AudioManager.heo;
		}
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00004418 File Offset: 0x00002618
	private void Awake()
	{
		if (AudioManager.heo != null && AudioManager.heo != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.soundInfos = new List<AudioManager.SoundInfo>(400);
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AudioManager.heo = this;
		this.hej = RuntimeManager.GetBus(a.cm());
		this.hek = RuntimeManager.GetBus(a.cn());
		this.hel = RuntimeManager.GetBus(a.co());
		this.hem = RuntimeManager.GetBus(a.cp());
		try
		{
			this.hen = RuntimeManager.GetBus(a.cq());
		}
		catch (BusNotFoundException)
		{
			global::UnityEngine.Debug.LogWarning(a.cr());
		}
		this.qf(0f, true);
		this.qi(0f, true);
		this.qj(0f, true);
		this.qk(0f, true);
		this.qn(0f, true);
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00004518 File Offset: 0x00002718
	private static float qe(float a)
	{
		a = Mathf.Clamp01(a);
		return a * a;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00004527 File Offset: 0x00002727
	public void qf(float a, bool b = false)
	{
		this.heq = AudioManager.qe(a);
		if (b)
		{
			this.hep = this.heq;
			this.hej.setVolume(this.hep);
		}
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06000076 RID: 118 RVA: 0x00004558 File Offset: 0x00002758
	// (remove) Token: 0x06000077 RID: 119 RVA: 0x0000458C File Offset: 0x0000278C
	public static event Action<float> het;

	// Token: 0x06000078 RID: 120 RVA: 0x000045BF File Offset: 0x000027BF
	public void qi(float a, bool b = false)
	{
		Action<float> action = AudioManager.het;
		if (action != null)
		{
			action(a);
		}
		this.hes = AudioManager.qe(a);
		if (b)
		{
			this.her = this.hes;
			this.hek.setVolume(this.her);
		}
	}

	// Token: 0x06000079 RID: 121 RVA: 0x000045FF File Offset: 0x000027FF
	public void qj(float a, bool b = false)
	{
		this.hev = AudioManager.qe(a);
		if (b)
		{
			this.heu = this.hev;
			this.hel.setVolume(this.heu);
		}
	}

	// Token: 0x0600007A RID: 122 RVA: 0x0000462E File Offset: 0x0000282E
	public void qk(float a, bool b = false)
	{
		this.hex = AudioManager.qe(a);
		if (b)
		{
			this.hew = this.hex;
			this.hem.setVolume(this.hew);
		}
	}

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x0600007B RID: 123 RVA: 0x00004660 File Offset: 0x00002860
	// (remove) Token: 0x0600007C RID: 124 RVA: 0x00004694 File Offset: 0x00002894
	public static event Action<float> hfa;

	// Token: 0x0600007D RID: 125 RVA: 0x000046C8 File Offset: 0x000028C8
	public void qn(float a, bool b = false)
	{
		Action<float> action = AudioManager.hfa;
		if (action != null)
		{
			action(a);
		}
		this.hez = AudioManager.qe(a);
		if (b)
		{
			this.hey = this.hez;
			if (this.hen.isValid())
			{
				this.hen.setVolume(this.hey);
			}
		}
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00004720 File Offset: 0x00002920
	private void qo()
	{
		float num = ((Time.timeScale == 0f) ? 0f : this.heq);
		if (Mathf.Approximately(this.hep, num))
		{
			return;
		}
		this.hep = Mathf.MoveTowards(this.hep, num, Time.unscaledDeltaTime);
		this.hej.setVolume(this.hep);
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00004780 File Offset: 0x00002980
	private void qp()
	{
		if (Mathf.Approximately(this.her, this.hes))
		{
			return;
		}
		this.her = Mathf.MoveTowards(this.her, this.hes, Time.unscaledDeltaTime / 4f);
		this.hek.setVolume(this.her);
	}

	// Token: 0x06000080 RID: 128 RVA: 0x000047D8 File Offset: 0x000029D8
	private void qq()
	{
		float num = ((Time.timeScale == 0f) ? 0f : this.hev);
		if (Mathf.Approximately(this.heu, num))
		{
			return;
		}
		this.heu = Mathf.MoveTowards(this.heu, num, Time.unscaledDeltaTime);
		this.hel.setVolume(this.heu);
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00004838 File Offset: 0x00002A38
	private void qr()
	{
		float num = ((Time.timeScale == 0f) ? 0f : this.hex);
		if (Mathf.Approximately(this.hew, num))
		{
			return;
		}
		this.hew = Mathf.MoveTowards(this.hew, num, Time.unscaledDeltaTime);
		this.hem.setVolume(this.hew);
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00004898 File Offset: 0x00002A98
	private void qs()
	{
		if (!this.hen.isValid())
		{
			return;
		}
		if (Mathf.Approximately(this.hey, this.hez))
		{
			return;
		}
		this.hey = Mathf.MoveTowards(this.hey, this.hez, Time.unscaledDeltaTime / 4f);
		this.hen.setVolume(this.hey);
	}

	// Token: 0x06000083 RID: 131 RVA: 0x000048FC File Offset: 0x00002AFC
	public void Update()
	{
		this.qo();
		this.qp();
		this.qq();
		this.qr();
		this.qs();
		for (int i = this.hfc.Count - 1; i >= 0; i--)
		{
			List<float> list = this.hfc;
			int num = i;
			list[num] -= Time.deltaTime;
			if (this.hfc[i] <= 0f)
			{
				EventInstance eventInstance = this.hfb[i];
				this.hfc.RemoveAt(i);
				this.hfb.RemoveAt(i);
				this.rf(eventInstance, 0.5f);
			}
		}
	}

	// Token: 0x06000084 RID: 132 RVA: 0x000049A0 File Offset: 0x00002BA0
	public void qt()
	{
		this.BGM_Main.ru(0.5f);
	}

	// Token: 0x06000085 RID: 133 RVA: 0x000049B4 File Offset: 0x00002BB4
	private bool qu(GUID a, Vector3 b, float c, float d)
	{
		float time = Time.time;
		float num = d * d;
		for (int i = this.soundInfos.Count - 1; i >= 0; i--)
		{
			if (this.soundInfos[i].eventReference.Guid == a && time - this.soundInfos[i].currentTime < c && math.distancesq(this.soundInfos[i].position, b) < num)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00004A40 File Offset: 0x00002C40
	public void qv(EventReference a, Vector3 b, float c = -1f, float d = -1f)
	{
		if (a.IsNull)
		{
			return;
		}
		if (c == -1f)
		{
			c = this.baseSize;
		}
		if (d == -1f)
		{
			d = this.baseTime;
		}
		if (this.qu(a.Guid, b, d, c))
		{
			return;
		}
		AudioManager.EventInstancePool eventInstancePool = AudioManager.ra(a.Guid);
		if (eventInstancePool.po())
		{
			EventInstance eventInstance = eventInstancePool.pp(b);
			eventInstance.setVolume(1f);
			eventInstance.start();
			AudioManager.SoundInfo soundInfo = new AudioManager.SoundInfo
			{
				eventReference = a,
				position = b,
				currentTime = Time.time
			};
			this.soundInfos.Add(soundInfo);
			base.StartCoroutine(this.rb(eventInstance, eventInstancePool, soundInfo));
		}
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00004AFC File Offset: 0x00002CFC
	public EventInstance qw(EventReference a, Vector3 b, float c = 1f)
	{
		if (a.IsNull)
		{
			return default(EventInstance);
		}
		AudioManager.EventInstancePool eventInstancePool = AudioManager.ra(a.Guid);
		if (eventInstancePool.po())
		{
			EventInstance eventInstance = eventInstancePool.pp(b);
			eventInstance.setVolume(c);
			eventInstance.start();
			base.StartCoroutine(this.rb(eventInstance, eventInstancePool, null));
			return eventInstance;
		}
		return default(EventInstance);
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00004B64 File Offset: 0x00002D64
	public void qx(EventReference a, Vector3 b, float c = 1f)
	{
		if (a.IsNull)
		{
			return;
		}
		AudioManager.EventInstancePool eventInstancePool = AudioManager.ra(a.Guid);
		if (eventInstancePool.po())
		{
			this.hei = eventInstancePool.pp(b);
			this.hei.setVolume(c);
			this.hei.start();
			base.StartCoroutine(this.rb(this.hei, eventInstancePool, null));
		}
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00004BCC File Offset: 0x00002DCC
	public void qy()
	{
		PLAYBACK_STATE playback_STATE = PLAYBACK_STATE.STOPPED;
		this.hei.getPlaybackState(out playback_STATE);
		if (playback_STATE != PLAYBACK_STATE.STOPPED)
		{
			this.hei.stop(global::FMOD.Studio.STOP_MODE.IMMEDIATE);
		}
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00004BFC File Offset: 0x00002DFC
	public bool qz()
	{
		PLAYBACK_STATE playback_STATE = PLAYBACK_STATE.STOPPED;
		this.hei.getPlaybackState(out playback_STATE);
		return playback_STATE != PLAYBACK_STATE.STOPPED;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00004C20 File Offset: 0x00002E20
	public static AudioManager.EventInstancePool ra(GUID a)
	{
		AudioManager.EventInstancePool eventInstancePool;
		if (AudioManager.EventInstancePoolDict.TryGetValue(a, out eventInstancePool))
		{
			return eventInstancePool;
		}
		AudioManager.EventInstancePool eventInstancePool2 = new AudioManager.EventInstancePool
		{
			eventGuid = a,
			initialSize = 10,
			maxSize = 20
		};
		eventInstancePool2.pn();
		AudioManager.EventInstancePoolDict.Add(a, eventInstancePool2);
		return eventInstancePool2;
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00004C6E File Offset: 0x00002E6E
	private IEnumerator rb(EventInstance a, AudioManager.EventInstancePool b, AudioManager.SoundInfo c)
	{
		PLAYBACK_STATE playback_STATE = PLAYBACK_STATE.STOPPED;
		a.getPlaybackState(out playback_STATE);
		while (playback_STATE != PLAYBACK_STATE.STOPPED)
		{
			yield return null;
			a.getPlaybackState(out playback_STATE);
		}
		b.pq(a);
		if (c != null)
		{
			this.soundInfos.Remove(c);
		}
		yield break;
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00004C94 File Offset: 0x00002E94
	public void rc(EventReference a, float b)
	{
		if (a.IsNull)
		{
			return;
		}
		for (int i = 0; i < this.hfb.Count; i++)
		{
			if (this.ri(this.hfb[i], a))
			{
				if (this.hfc[i] < b)
				{
					this.hfc[i] = b;
				}
				return;
			}
		}
		EventInstance eventInstance = RuntimeManager.CreateInstance(a.Guid);
		eventInstance.start();
		this.hfb.Add(eventInstance);
		this.hfc.Add(b);
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00004D20 File Offset: 0x00002F20
	public void rd(EventReference a)
	{
		for (int i = 0; i < this.hfb.Count; i++)
		{
			if (this.ri(this.hfb[i], a))
			{
				this.rf(this.hfb[i], 0.5f);
				this.hfc.RemoveAt(i);
				this.hfb.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00004D88 File Offset: 0x00002F88
	public EventInstance re(EventReference a, GameObject b)
	{
		EventInstance eventInstance = RuntimeManager.CreateInstance(a.Guid);
		eventInstance.start();
		base.StartCoroutine(this.rg(eventInstance, b));
		return eventInstance;
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00004DB9 File Offset: 0x00002FB9
	public void rf(EventInstance a, float b)
	{
		if (b > 0f)
		{
			base.StartCoroutine(this.rh(a, b));
			return;
		}
		this.hfb.Remove(a);
		a.stop(global::FMOD.Studio.STOP_MODE.IMMEDIATE);
		a.release();
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00004DF1 File Offset: 0x00002FF1
	private IEnumerator rg(EventInstance a, GameObject b)
	{
		while (a.isValid() && b != null && b.activeSelf)
		{
			a.set3DAttributes(b.transform.position.To3DAttributes());
			yield return null;
		}
		yield break;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00004E07 File Offset: 0x00003007
	private IEnumerator rh(EventInstance a, float b)
	{
		float num;
		a.getVolume(out num);
		float num2 = 0f;
		while (num2 < b)
		{
			num2 += Time.deltaTime;
			float num3 = Mathf.Lerp(num, 0f, num2 / b);
			a.setVolume(num3);
			yield return null;
		}
		this.hfb.Remove(a);
		a.stop(global::FMOD.Studio.STOP_MODE.IMMEDIATE);
		a.release();
		yield break;
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00004E24 File Offset: 0x00003024
	public bool ri(EventInstance a, EventReference b)
	{
		EventDescription eventDescription;
		a.getDescription(out eventDescription);
		GUID guid;
		eventDescription.getID(out guid);
		return guid == b.Guid;
	}

	// Token: 0x04000074 RID: 116
	private EventInstance hei;

	// Token: 0x04000075 RID: 117
	private Bus hej;

	// Token: 0x04000076 RID: 118
	private Bus hek;

	// Token: 0x04000077 RID: 119
	private Bus hel;

	// Token: 0x04000078 RID: 120
	private Bus hem;

	// Token: 0x04000079 RID: 121
	private Bus hen;

	// Token: 0x0400007A RID: 122
	public float baseSize = 2f;

	// Token: 0x0400007B RID: 123
	public float baseTime = 0.1f;

	// Token: 0x0400007C RID: 124
	public static float minDistance = 6f;

	// Token: 0x0400007D RID: 125
	public static float maxDistance = 25f;

	// Token: 0x0400007E RID: 126
	public j BGM_Main;

	// Token: 0x0400007F RID: 127
	[SerializeField]
	protected List<AudioManager.SoundInfo> soundInfos = new List<AudioManager.SoundInfo>();

	// Token: 0x04000080 RID: 128
	private static AudioManager heo;

	// Token: 0x04000081 RID: 129
	public static Dictionary<GUID, AudioManager.EventInstancePool> EventInstancePoolDict = new Dictionary<GUID, AudioManager.EventInstancePool>();

	// Token: 0x04000082 RID: 130
	private float hep;

	// Token: 0x04000083 RID: 131
	private float heq = 1f;

	// Token: 0x04000084 RID: 132
	private float her;

	// Token: 0x04000085 RID: 133
	private float hes = 1f;

	// Token: 0x04000087 RID: 135
	private float heu;

	// Token: 0x04000088 RID: 136
	private float hev = 1f;

	// Token: 0x04000089 RID: 137
	private float hew;

	// Token: 0x0400008A RID: 138
	private float hex = 1f;

	// Token: 0x0400008B RID: 139
	private float hey;

	// Token: 0x0400008C RID: 140
	private float hez = 1f;

	// Token: 0x0400008E RID: 142
	private List<EventInstance> hfb = new List<EventInstance>();

	// Token: 0x0400008F RID: 143
	private List<float> hfc = new List<float>();

	// Token: 0x0200000A RID: 10
	[Serializable]
	public class EventInstancePool
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00004EFC File Offset: 0x000030FC
		public void pn()
		{
			for (int i = 0; i < this.initialSize; i++)
			{
				EventInstance eventInstance = RuntimeManager.CreateInstance(this.eventGuid);
				eventInstance.set3DAttributes(Vector3.up.To3DAttributes());
				this.hdq.Enqueue(eventInstance);
				this.nowNumber++;
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004F52 File Offset: 0x00003152
		public bool po()
		{
			return this.hdq.Count != 0 || this.nowNumber != this.maxSize;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004F74 File Offset: 0x00003174
		public EventInstance pp(Vector3 a)
		{
			if (this.hdq.Count > 0)
			{
				EventInstance eventInstance = this.hdq.Dequeue();
				eventInstance.set3DAttributes(a.To3DAttributes());
				eventInstance.setProperty(EVENT_PROPERTY.MINIMUM_DISTANCE, AudioManager.minDistance);
				eventInstance.setProperty(EVENT_PROPERTY.MAXIMUM_DISTANCE, AudioManager.maxDistance);
				return eventInstance;
			}
			EventInstance eventInstance2 = RuntimeManager.CreateInstance(this.eventGuid);
			this.nowNumber++;
			eventInstance2.set3DAttributes(a.To3DAttributes());
			eventInstance2.setProperty(EVENT_PROPERTY.MINIMUM_DISTANCE, AudioManager.minDistance);
			eventInstance2.setProperty(EVENT_PROPERTY.MAXIMUM_DISTANCE, AudioManager.maxDistance);
			return eventInstance2;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000500C File Offset: 0x0000320C
		public void pq(EventInstance a)
		{
			if (this.hdq.Count < this.maxSize)
			{
				a.stop(global::FMOD.Studio.STOP_MODE.IMMEDIATE);
				a.setPitch(1f);
				a.setVolume(1f);
				a.setCallback(null, (EVENT_CALLBACK_TYPE)4294967295U);
				this.hdq.Enqueue(a);
				return;
			}
			a.release();
		}

		// Token: 0x04000090 RID: 144
		public GUID eventGuid;

		// Token: 0x04000091 RID: 145
		public int initialSize;

		// Token: 0x04000092 RID: 146
		public int maxSize;

		// Token: 0x04000093 RID: 147
		public int nowNumber;

		// Token: 0x04000094 RID: 148
		private Queue<EventInstance> hdq = new Queue<EventInstance>();
	}

	// Token: 0x0200000B RID: 11
	[Serializable]
	public class SoundInfo
	{
		// Token: 0x04000095 RID: 149
		public EventReference eventReference;

		// Token: 0x04000096 RID: 150
		public Vector3 position;

		// Token: 0x04000097 RID: 151
		public float currentTime;
	}
}
