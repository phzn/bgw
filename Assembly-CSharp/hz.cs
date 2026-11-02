using System;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Rewired;
using UnityEngine;

// Token: 0x020001B9 RID: 441
public class hz : MonoBehaviour
{
	// Token: 0x06001D36 RID: 7478 RVA: 0x00084AC8 File Offset: 0x00082CC8
	private void OnEnable()
	{
		if (!ReInput.isReady)
		{
			return;
		}
		Player player = ReInput.players.GetPlayer(0);
		if (player == null)
		{
			return;
		}
		player.AddInputEventDelegate(new Action<InputActionEventData>(this.eyp), UpdateLoopType.Update, InputActionEventType.AxisActive, a.eoq());
		player.AddInputEventDelegate(new Action<InputActionEventData>(this.eyp), UpdateLoopType.Update, InputActionEventType.AxisInactive, a.eoq());
		player.AddInputEventDelegate(new Action<InputActionEventData>(this.eyq), UpdateLoopType.Update, InputActionEventType.AxisActive, a.eor());
		player.AddInputEventDelegate(new Action<InputActionEventData>(this.eyq), UpdateLoopType.Update, InputActionEventType.AxisInactive, a.eor());
		player.AddInputEventDelegate(new Action<InputActionEventData>(this.eyt), UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, a.eos());
		player.AddInputEventDelegate(new Action<InputActionEventData>(this.eyu), UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, a.eot());
		player.AddInputEventDelegate(new Action<InputActionEventData>(this.eyr), UpdateLoopType.Update, InputActionEventType.AxisActive, a.eou());
		player.AddInputEventDelegate(new Action<InputActionEventData>(this.eyr), UpdateLoopType.Update, InputActionEventType.AxisInactive, a.eou());
		player.AddInputEventDelegate(new Action<InputActionEventData>(this.eys), UpdateLoopType.Update, InputActionEventType.AxisActive, a.eov());
		player.AddInputEventDelegate(new Action<InputActionEventData>(this.eys), UpdateLoopType.Update, InputActionEventType.AxisInactive, a.eov());
	}

	// Token: 0x06001D38 RID: 7480 RVA: 0x00084C58 File Offset: 0x00082E58
	private void lut()
	{
		if (this.jut.Length == 0)
		{
			return;
		}
		this.jus--;
		if (this.jus < 0)
		{
			this.jus = this.jut.Length - 1;
		}
		base.GetComponent<Renderer>().material.color = this.jut[this.jus];
	}

	// Token: 0x06001D39 RID: 7481 RVA: 0x00084CB8 File Offset: 0x00082EB8
	private void OnDisable()
	{
		if (!ReInput.isReady)
		{
			return;
		}
		Player player = ReInput.players.GetPlayer(0);
		if (player == null)
		{
			return;
		}
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyp));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyq));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyt));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyu));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyr));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eys));
	}

	// Token: 0x06001D3A RID: 7482 RVA: 0x00084D49 File Offset: 0x00082F49
	private void eyr(InputActionEventData a)
	{
		this.eyw(new Vector2(a.GetAxis(), 0f));
	}

	// Token: 0x06001D3B RID: 7483 RVA: 0x00084D64 File Offset: 0x00082F64
	private void bev()
	{
		if (this.jut.Length == 0)
		{
			return;
		}
		this.jus++;
		if (this.jus >= this.jut.Length)
		{
			this.jus = 0;
		}
		base.GetComponent<Renderer>().material.color = this.jut[this.jus];
	}

	// Token: 0x06001D3C RID: 7484 RVA: 0x00084DC4 File Offset: 0x00082FC4
	private void ksd()
	{
		if (!ReInput.isReady)
		{
			return;
		}
		Player player = ReInput.players.GetPlayer(0);
		if (player == null)
		{
			return;
		}
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyp));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyq));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyt));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyu));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyr));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eys));
	}

	// Token: 0x06001D3D RID: 7485 RVA: 0x00084E55 File Offset: 0x00083055
	private void eyu(InputActionEventData a)
	{
		this.eyy();
	}

	// Token: 0x06001D3E RID: 7486 RVA: 0x00084E5D File Offset: 0x0008305D
	private void hds(InputActionEventData a)
	{
		this.eyv(new Vector2(a.GetAxis(), -7870f));
	}

	// Token: 0x06001D3F RID: 7487 RVA: 0x00084E78 File Offset: 0x00083078
	private void eyw(Vector2 a)
	{
		a *= this.rotateSpeed;
		base.transform.Rotate(Vector3.up, -a.x, Space.World);
		base.transform.Rotate(Vector3.right, a.y, Space.World);
	}

	// Token: 0x06001D40 RID: 7488 RVA: 0x00084EC4 File Offset: 0x000830C4
	private void hti()
	{
		if (!ReInput.isReady)
		{
			return;
		}
		Player player = ReInput.players.GetPlayer(0);
		if (player == null)
		{
			return;
		}
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyp));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyq));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyt));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyu));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyr));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eys));
	}

	// Token: 0x06001D41 RID: 7489 RVA: 0x00084F55 File Offset: 0x00083155
	private void bij(InputActionEventData a)
	{
		this.eyw(new Vector2(a.GetAxis(), -6499f));
	}

	// Token: 0x06001D42 RID: 7490 RVA: 0x00084F6E File Offset: 0x0008316E
	private void mad(InputActionEventData a)
	{
		this.eyv(new Vector2(3183f, a.GetAxis()));
	}

	// Token: 0x06001D43 RID: 7491 RVA: 0x00084F88 File Offset: 0x00083188
	private void jvh()
	{
		if (!ReInput.isReady)
		{
			return;
		}
		Player player = ReInput.players.GetPlayer(0);
		if (player == null)
		{
			return;
		}
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyp));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyq));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyt));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyu));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyr));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eys));
	}

	// Token: 0x06001D44 RID: 7492 RVA: 0x00085019 File Offset: 0x00083219
	private void eys(InputActionEventData a)
	{
		this.eyw(new Vector2(0f, a.GetAxis()));
	}

	// Token: 0x06001D45 RID: 7493 RVA: 0x00085032 File Offset: 0x00083232
	private void nhk(Vector2 a)
	{
		base.transform.Translate(a * Time.deltaTime * this.moveSpeed, Space.World);
	}

	// Token: 0x06001D46 RID: 7494 RVA: 0x0008505C File Offset: 0x0008325C
	private void eyy()
	{
		if (this.jut.Length == 0)
		{
			return;
		}
		this.jus--;
		if (this.jus < 0)
		{
			this.jus = this.jut.Length - 1;
		}
		base.GetComponent<Renderer>().material.color = this.jut[this.jus];
	}

	// Token: 0x06001D47 RID: 7495 RVA: 0x000850BB File Offset: 0x000832BB
	private void fjd(InputActionEventData a)
	{
		this.eyv(new Vector2(a.GetAxis(), -6298f));
	}

	// Token: 0x06001D48 RID: 7496 RVA: 0x000850D4 File Offset: 0x000832D4
	private void nkz(Vector2 a)
	{
		a *= this.rotateSpeed;
		base.transform.Rotate(Vector3.up, -a.x, Space.World);
		base.transform.Rotate(Vector3.right, a.y, Space.World);
	}

	// Token: 0x06001D49 RID: 7497 RVA: 0x00084E55 File Offset: 0x00083055
	private void mar(InputActionEventData a)
	{
		this.eyy();
	}

	// Token: 0x06001D4A RID: 7498 RVA: 0x00085120 File Offset: 0x00083320
	private void lxq(InputActionEventData a)
	{
		this.eyw(new Vector2(a.GetAxis(), -8613f));
	}

	// Token: 0x06001D4B RID: 7499 RVA: 0x0008513C File Offset: 0x0008333C
	private void kfc()
	{
		if (this.jut.Length == 0)
		{
			return;
		}
		this.jus--;
		if (this.jus < 0)
		{
			this.jus = this.jut.Length - 1;
		}
		base.GetComponent<Renderer>().material.color = this.jut[this.jus];
	}

	// Token: 0x06001D4C RID: 7500 RVA: 0x0008519B File Offset: 0x0008339B
	private void eyt(InputActionEventData a)
	{
		this.eyx();
	}

	// Token: 0x06001D4D RID: 7501 RVA: 0x000851A3 File Offset: 0x000833A3
	private void jjg(InputActionEventData a)
	{
		this.eyw(new Vector2(a.GetAxis(), -4867f));
	}

	// Token: 0x06001D4E RID: 7502 RVA: 0x00084E55 File Offset: 0x00083055
	private void hzo(InputActionEventData a)
	{
		this.eyy();
	}

	// Token: 0x06001D4F RID: 7503 RVA: 0x000851BC File Offset: 0x000833BC
	private void yd(InputActionEventData a)
	{
		this.eyw(new Vector2(8955f, a.GetAxis()));
	}

	// Token: 0x06001D50 RID: 7504 RVA: 0x000851D8 File Offset: 0x000833D8
	private void kqv()
	{
		if (this.jut.Length == 0)
		{
			return;
		}
		this.jus++;
		if (this.jus >= this.jut.Length)
		{
			this.jus = 0;
		}
		base.GetComponent<Renderer>().material.color = this.jut[this.jus];
	}

	// Token: 0x06001D51 RID: 7505 RVA: 0x00085235 File Offset: 0x00083435
	private void npx(InputActionEventData a)
	{
		this.eyv(new Vector2(a.GetAxis(), -6839f));
	}

	// Token: 0x06001D52 RID: 7506 RVA: 0x00085032 File Offset: 0x00083232
	private void eyv(Vector2 a)
	{
		base.transform.Translate(a * Time.deltaTime * this.moveSpeed, Space.World);
	}

	// Token: 0x06001D53 RID: 7507 RVA: 0x00085250 File Offset: 0x00083450
	private void loy()
	{
		if (this.jut.Length == 0)
		{
			return;
		}
		this.jus++;
		if (this.jus >= this.jut.Length)
		{
			this.jus = 0;
		}
		base.GetComponent<Renderer>().material.color = this.jut[this.jus];
	}

	// Token: 0x06001D54 RID: 7508 RVA: 0x000852B0 File Offset: 0x000834B0
	private void eyx()
	{
		if (this.jut.Length == 0)
		{
			return;
		}
		this.jus++;
		if (this.jus >= this.jut.Length)
		{
			this.jus = 0;
		}
		base.GetComponent<Renderer>().material.color = this.jut[this.jus];
	}

	// Token: 0x06001D55 RID: 7509 RVA: 0x00084E55 File Offset: 0x00083055
	private void jdc(InputActionEventData a)
	{
		this.eyy();
	}

	// Token: 0x06001D56 RID: 7510 RVA: 0x0008530D File Offset: 0x0008350D
	private void eyp(InputActionEventData a)
	{
		this.eyv(new Vector2(a.GetAxis(), 0f));
	}

	// Token: 0x06001D57 RID: 7511 RVA: 0x00085032 File Offset: 0x00083232
	private void ecr(Vector2 a)
	{
		base.transform.Translate(a * Time.deltaTime * this.moveSpeed, Space.World);
	}

	// Token: 0x06001D58 RID: 7512 RVA: 0x00085326 File Offset: 0x00083526
	private void eyq(InputActionEventData a)
	{
		this.eyv(new Vector2(0f, a.GetAxis()));
	}

	// Token: 0x06001D59 RID: 7513 RVA: 0x00085340 File Offset: 0x00083540
	private void evx()
	{
		if (this.jut.Length == 0)
		{
			return;
		}
		this.jus++;
		if (this.jus >= this.jut.Length)
		{
			this.jus = 0;
		}
		base.GetComponent<Renderer>().material.color = this.jut[this.jus];
	}

	// Token: 0x06001D5A RID: 7514 RVA: 0x0008539D File Offset: 0x0008359D
	private void ijm(InputActionEventData a)
	{
		this.eyv(new Vector2(a.GetAxis(), -8790f));
	}

	// Token: 0x06001D5B RID: 7515 RVA: 0x0008519B File Offset: 0x0008339B
	private void gne(InputActionEventData a)
	{
		this.eyx();
	}

	// Token: 0x06001D5C RID: 7516 RVA: 0x000853B8 File Offset: 0x000835B8
	private void cdt()
	{
		if (this.jut.Length == 0)
		{
			return;
		}
		this.jus--;
		if (this.jus < 0)
		{
			this.jus = this.jut.Length - 1;
		}
		base.GetComponent<Renderer>().material.color = this.jut[this.jus];
	}

	// Token: 0x06001D5D RID: 7517 RVA: 0x00085418 File Offset: 0x00083618
	private void ktk()
	{
		if (!ReInput.isReady)
		{
			return;
		}
		Player player = ReInput.players.GetPlayer(0);
		if (player == null)
		{
			return;
		}
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyp));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyq));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyt));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyu));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eyr));
		player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.eys));
	}

	// Token: 0x06001D5E RID: 7518 RVA: 0x0008519B File Offset: 0x0008339B
	private void lst(InputActionEventData a)
	{
		this.eyx();
	}

	// Token: 0x06001D5F RID: 7519 RVA: 0x0008519B File Offset: 0x0008339B
	private void itc(InputActionEventData a)
	{
		this.eyx();
	}

	// Token: 0x04000F2C RID: 3884
	public float rotateSpeed = 1f;

	// Token: 0x04000F2D RID: 3885
	public float moveSpeed = 1f;

	// Token: 0x04000F2E RID: 3886
	private int jus;

	// Token: 0x04000F2F RID: 3887
	private Color[] jut = new Color[]
	{
		Color.white,
		Color.red,
		Color.green,
		Color.blue
	};
}
