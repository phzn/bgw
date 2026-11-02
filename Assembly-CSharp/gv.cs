using System;
using System.Collections.Generic;
using System.ComponentModel;
using Rewired;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Platforms.Windows;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

// Token: 0x0200018C RID: 396
[EditorBrowsable(EditorBrowsableState.Never)]
public class gv : IExternalTools
{
	// Token: 0x170003AF RID: 943
	// (get) Token: 0x06001B0E RID: 6926 RVA: 0x0007C5BF File Offset: 0x0007A7BF
	// (set) Token: 0x06001B0F RID: 6927 RVA: 0x0007C5C6 File Offset: 0x0007A7C6
	public static Func<object> lov
	{
		get
		{
			return gv.jqh;
		}
		set
		{
			gv.jqh = value;
		}
	}

	// Token: 0x06001B11 RID: 6929 RVA: 0x00005090 File Offset: 0x00003290
	public void Destroy()
	{
	}

	// Token: 0x170003B0 RID: 944
	// (get) Token: 0x06001B12 RID: 6930 RVA: 0x0007C5CE File Offset: 0x0007A7CE
	public bool isEditorPaused
	{
		get
		{
			return this.jqi;
		}
	}

	// Token: 0x14000045 RID: 69
	// (add) Token: 0x06001B13 RID: 6931 RVA: 0x0007C5D6 File Offset: 0x0007A7D6
	// (remove) Token: 0x06001B14 RID: 6932 RVA: 0x0007C5EF File Offset: 0x0007A7EF
	public event Action<bool> EditorPausedStateChangedEvent
	{
		add
		{
			this.jqj = (Action<bool>)Delegate.Combine(this.jqj, value);
		}
		remove
		{
			this.jqj = (Action<bool>)Delegate.Remove(this.jqj, value);
		}
	}

	// Token: 0x06001B15 RID: 6933 RVA: 0x0007C608 File Offset: 0x0007A808
	public object GetPlatformInitializer()
	{
		return Main.GetPlatformInitializer();
	}

	// Token: 0x06001B16 RID: 6934 RVA: 0x0007C60F File Offset: 0x0007A80F
	public string GetFocusedEditorWindowTitle()
	{
		return string.Empty;
	}

	// Token: 0x06001B17 RID: 6935 RVA: 0x0000FC31 File Offset: 0x0000DE31
	public bool IsEditorSceneViewFocused()
	{
		return false;
	}

	// Token: 0x06001B18 RID: 6936 RVA: 0x0000FC31 File Offset: 0x0000DE31
	public bool LinuxInput_IsJoystickPreconfigured(string name)
	{
		return false;
	}

	// Token: 0x14000046 RID: 70
	// (add) Token: 0x06001B19 RID: 6937 RVA: 0x0007C618 File Offset: 0x0007A818
	// (remove) Token: 0x06001B1A RID: 6938 RVA: 0x0007C650 File Offset: 0x0007A850
	public event Action<uint, bool> XboxOneInput_OnGamepadStateChange;

	// Token: 0x06001B1B RID: 6939 RVA: 0x0000FC31 File Offset: 0x0000DE31
	public int XboxOneInput_GetUserIdForGamepad(uint id)
	{
		return 0;
	}

	// Token: 0x06001B1C RID: 6940 RVA: 0x0007C685 File Offset: 0x0007A885
	public ulong XboxOneInput_GetControllerId(uint unityJoystickId)
	{
		return 0UL;
	}

	// Token: 0x06001B1D RID: 6941 RVA: 0x0000FC31 File Offset: 0x0000DE31
	public bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
	{
		return false;
	}

	// Token: 0x06001B1E RID: 6942 RVA: 0x0007C60F File Offset: 0x0007A80F
	public string XboxOneInput_GetControllerType(ulong xboxControllerId)
	{
		return string.Empty;
	}

	// Token: 0x06001B1F RID: 6943 RVA: 0x0000FC31 File Offset: 0x0000DE31
	public uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
	{
		return 0U;
	}

	// Token: 0x06001B20 RID: 6944 RVA: 0x00005090 File Offset: 0x00003290
	public void XboxOne_Gamepad_UpdatePlugin()
	{
	}

	// Token: 0x06001B21 RID: 6945 RVA: 0x0000FC31 File Offset: 0x0000DE31
	public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel)
	{
		return false;
	}

	// Token: 0x06001B22 RID: 6946 RVA: 0x00005090 File Offset: 0x00003290
	public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS)
	{
	}

	// Token: 0x06001B23 RID: 6947 RVA: 0x0007C689 File Offset: 0x0007A889
	public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
	{
		vids = new List<int>();
		pids = new List<int>();
	}

	// Token: 0x06001B24 RID: 6948 RVA: 0x0007C699 File Offset: 0x0007A899
	public int GetAndroidAPILevel()
	{
		return -1;
	}

	// Token: 0x06001B25 RID: 6949 RVA: 0x0007C69C File Offset: 0x0007A89C
	public void WindowsStandalone_ForwardRawInput(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize)
	{
		global::UnityEngine.Windows.Input.ForwardRawInput(rawInputHeaderIndices, rawInputDataIndices, indicesCount, rawInputData, rawInputDataSize);
	}

	// Token: 0x06001B26 RID: 6950 RVA: 0x0007C6AA File Offset: 0x0007A8AA
	public bool UnityUI_Graphic_GetRaycastTarget(object graphic)
	{
		return !(graphic as Graphic == null) && (graphic as Graphic).raycastTarget;
	}

	// Token: 0x06001B27 RID: 6951 RVA: 0x0007C6C7 File Offset: 0x0007A8C7
	public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value)
	{
		if (graphic as Graphic == null)
		{
			return;
		}
		(graphic as Graphic).raycastTarget = value;
	}

	// Token: 0x170003B1 RID: 945
	// (get) Token: 0x06001B28 RID: 6952 RVA: 0x0007C6E4 File Offset: 0x0007A8E4
	public bool UnityInput_IsTouchPressureSupported
	{
		get
		{
			return global::UnityEngine.Input.touchPressureSupported;
		}
	}

	// Token: 0x06001B29 RID: 6953 RVA: 0x0007C6EB File Offset: 0x0007A8EB
	public float UnityInput_GetTouchPressure(ref Touch touch)
	{
		return touch.pressure;
	}

	// Token: 0x06001B2A RID: 6954 RVA: 0x0007C6F3 File Offset: 0x0007A8F3
	public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch)
	{
		return touch.maximumPossiblePressure;
	}

	// Token: 0x06001B2B RID: 6955 RVA: 0x0007C6FB File Offset: 0x0007A8FB
	public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload)
	{
		return ht.esx(typeGuid, payload);
	}

	// Token: 0x06001B2C RID: 6956 RVA: 0x0007C704 File Offset: 0x0007A904
	public Type[] GetControllerTemplateTypes()
	{
		return ht.lqd;
	}

	// Token: 0x06001B2D RID: 6957 RVA: 0x0007C70B File Offset: 0x0007A90B
	public Type[] GetControllerTemplateInterfaceTypes()
	{
		return ht.lqe;
	}

	// Token: 0x04000E70 RID: 3696
	private static Func<object> jqh;

	// Token: 0x04000E71 RID: 3697
	private bool jqi;

	// Token: 0x04000E72 RID: 3698
	private Action<bool> jqj;
}
