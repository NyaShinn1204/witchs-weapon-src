using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.InteropServices;
using BestHTTP;
using LuaInterface;
using UnityEngine;
using UnityEngine.Events;
using WaterBell.ProjX.Data.Entity;
using WaterBell.ProjX.Data.NetIO;

public class DelegateFactory
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate Delegate DelegateCreate(LuaFunction func, LuaTable self, bool flag);

	private class System_Action_Event : LuaDelegate
	{
		public System_Action_Event(LuaFunction func)
			: base(null)
		{
		}

		public System_Action_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class UnityEngine_Events_UnityAction_Event : LuaDelegate
	{
		public UnityEngine_Events_UnityAction_Event(LuaFunction func)
			: base(null)
		{
		}

		public UnityEngine_Events_UnityAction_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class System_Predicate_int_Event : LuaDelegate
	{
		public System_Predicate_int_Event(LuaFunction func)
			: base(null)
		{
		}

		public System_Predicate_int_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public bool Call(int param0)
		{
			return false;
		}

		public bool CallWithSelf(int param0)
		{
			return false;
		}
	}

	private class System_Action_int_Event : LuaDelegate
	{
		public System_Action_int_Event(LuaFunction func)
			: base(null)
		{
		}

		public System_Action_int_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(int param0)
		{
		}

		public void CallWithSelf(int param0)
		{
		}
	}

	private class System_Comparison_int_Event : LuaDelegate
	{
		public System_Comparison_int_Event(LuaFunction func)
			: base(null)
		{
		}

		public System_Comparison_int_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public int Call(int param0, int param1)
		{
			return 0;
		}

		public int CallWithSelf(int param0, int param1)
		{
			return 0;
		}
	}

	private class System_Func_int_int_Event : LuaDelegate
	{
		public System_Func_int_int_Event(LuaFunction func)
			: base(null)
		{
		}

		public System_Func_int_int_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public int Call(int param0)
		{
			return 0;
		}

		public int CallWithSelf(int param0)
		{
			return 0;
		}
	}

	private class System_Action_TypeCsvActivity_Event : LuaDelegate
	{
		public System_Action_TypeCsvActivity_Event(LuaFunction func)
			: base(null)
		{
		}

		public System_Action_TypeCsvActivity_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(TypeCsvActivity param0)
		{
		}

		public void CallWithSelf(TypeCsvActivity param0)
		{
		}
	}

	private class LuaNetProxy_OnDataDelegate_Event : LuaDelegate
	{
		public LuaNetProxy_OnDataDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public LuaNetProxy_OnDataDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(Response param0)
		{
		}

		public void CallWithSelf(Response param0)
		{
		}
	}

	private class Function_Event : LuaDelegate
	{
		public Function_Event(LuaFunction func)
			: base(null)
		{
		}

		public Function_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class FunctionBool_Event : LuaDelegate
	{
		public FunctionBool_Event(LuaFunction func)
			: base(null)
		{
		}

		public FunctionBool_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(bool param0)
		{
		}

		public void CallWithSelf(bool param0)
		{
		}
	}

	private class FunctionDouble_Event : LuaDelegate
	{
		public FunctionDouble_Event(LuaFunction func)
			: base(null)
		{
		}

		public FunctionDouble_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(double param0)
		{
		}

		public void CallWithSelf(double param0)
		{
		}
	}

	private class FunctionGameObject_Event : LuaDelegate
	{
		public FunctionGameObject_Event(LuaFunction func)
			: base(null)
		{
		}

		public FunctionGameObject_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(GameObject param0)
		{
		}

		public void CallWithSelf(GameObject param0)
		{
		}
	}

	private class FunctionUlong_Event : LuaDelegate
	{
		public FunctionUlong_Event(LuaFunction func)
			: base(null)
		{
		}

		public FunctionUlong_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(ulong param0)
		{
		}

		public void CallWithSelf(ulong param0)
		{
		}
	}

	private class FunctionListenerEvent_Event : LuaDelegate
	{
		public FunctionListenerEvent_Event(LuaFunction func)
			: base(null)
		{
		}

		public FunctionListenerEvent_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(GUtilListenerEvent param0)
		{
		}

		public void CallWithSelf(GUtilListenerEvent param0)
		{
		}
	}

	private class FunctionUnArgs_Event : LuaDelegate
	{
		public FunctionUnArgs_Event(LuaFunction func)
			: base(null)
		{
		}

		public FunctionUnArgs_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class UIWindowsManager_CloseAction_Event : LuaDelegate
	{
		public UIWindowsManager_CloseAction_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIWindowsManager_CloseAction_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class UnityEngine_Camera_CameraCallback_Event : LuaDelegate
	{
		public UnityEngine_Camera_CameraCallback_Event(LuaFunction func)
			: base(null)
		{
		}

		public UnityEngine_Camera_CameraCallback_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(Camera param0)
		{
		}

		public void CallWithSelf(Camera param0)
		{
		}
	}

	private class UnityEngine_Application_LowMemoryCallback_Event : LuaDelegate
	{
		public UnityEngine_Application_LowMemoryCallback_Event(LuaFunction func)
			: base(null)
		{
		}

		public UnityEngine_Application_LowMemoryCallback_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class UnityEngine_Application_AdvertisingIdentifierCallback_Event : LuaDelegate
	{
		public UnityEngine_Application_AdvertisingIdentifierCallback_Event(LuaFunction func)
			: base(null)
		{
		}

		public UnityEngine_Application_AdvertisingIdentifierCallback_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(string param0, bool param1, string param2)
		{
		}

		public void CallWithSelf(string param0, bool param1, string param2)
		{
		}
	}

	private class UnityEngine_Application_LogCallback_Event : LuaDelegate
	{
		public UnityEngine_Application_LogCallback_Event(LuaFunction func)
			: base(null)
		{
		}

		public UnityEngine_Application_LogCallback_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(string param0, string param1, LogType param2)
		{
		}

		public void CallWithSelf(string param0, string param1, LogType param2)
		{
		}
	}

	private class UnityEngine_AudioClip_PCMReaderCallback_Event : LuaDelegate
	{
		public UnityEngine_AudioClip_PCMReaderCallback_Event(LuaFunction func)
			: base(null)
		{
		}

		public UnityEngine_AudioClip_PCMReaderCallback_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(float[] param0)
		{
		}

		public void CallWithSelf(float[] param0)
		{
		}
	}

	private class UnityEngine_AudioClip_PCMSetPositionCallback_Event : LuaDelegate
	{
		public UnityEngine_AudioClip_PCMSetPositionCallback_Event(LuaFunction func)
			: base(null)
		{
		}

		public UnityEngine_AudioClip_PCMSetPositionCallback_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(int param0)
		{
		}

		public void CallWithSelf(int param0)
		{
		}
	}

	private class System_Action_UnityEngine_AsyncOperation_Event : LuaDelegate
	{
		public System_Action_UnityEngine_AsyncOperation_Event(LuaFunction func)
			: base(null)
		{
		}

		public System_Action_UnityEngine_AsyncOperation_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(UnityEngine.AsyncOperation param0)
		{
		}

		public void CallWithSelf(UnityEngine.AsyncOperation param0)
		{
		}
	}

	private class WaterBell_ProjX_Data_NetIO_NetMsgBase_SuccessfulDelegate_Event : LuaDelegate
	{
		public WaterBell_ProjX_Data_NetIO_NetMsgBase_SuccessfulDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public WaterBell_ProjX_Data_NetIO_NetMsgBase_SuccessfulDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class WaterBell_ProjX_Data_NetIO_NetMsgBase_FailedDelegate_Event : LuaDelegate
	{
		public WaterBell_ProjX_Data_NetIO_NetMsgBase_FailedDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public WaterBell_ProjX_Data_NetIO_NetMsgBase_FailedDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(string param0)
		{
		}

		public void CallWithSelf(string param0)
		{
		}
	}

	private class WaterBell_ProjX_Data_NetIO_NetMsgBase_ErrorDelegate_Event : LuaDelegate
	{
		public WaterBell_ProjX_Data_NetIO_NetMsgBase_ErrorDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public WaterBell_ProjX_Data_NetIO_NetMsgBase_ErrorDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(string param0)
		{
		}

		public void CallWithSelf(string param0)
		{
		}
	}

	private class WaterBell_ProjX_Data_NetIO_NetMsgBase_TimeOutDelegate_Event : LuaDelegate
	{
		public WaterBell_ProjX_Data_NetIO_NetMsgBase_TimeOutDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public WaterBell_ProjX_Data_NetIO_NetMsgBase_TimeOutDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(HTTPRequestStates param0)
		{
		}

		public void CallWithSelf(HTTPRequestStates param0)
		{
		}
	}

	private class WaterBell_ProjX_Data_NetIO_NetMsgBase_InternalErrorDelegate_Event : LuaDelegate
	{
		public WaterBell_ProjX_Data_NetIO_NetMsgBase_InternalErrorDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public WaterBell_ProjX_Data_NetIO_NetMsgBase_InternalErrorDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(string param0)
		{
		}

		public void CallWithSelf(string param0)
		{
		}
	}

	private class WaterBell_ProjX_Data_NetIO_NetMsgBase_DealResultHandler_Event : LuaDelegate
	{
		public WaterBell_ProjX_Data_NetIO_NetMsgBase_DealResultHandler_Event(LuaFunction func)
			: base(null)
		{
		}

		public WaterBell_ProjX_Data_NetIO_NetMsgBase_DealResultHandler_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(object param0, EventArgs param1)
		{
		}

		public void CallWithSelf(object param0, EventArgs param1)
		{
		}
	}

	private class WaterBell_ProjX_Data_NetIO_NetMsgSeq_FinishSeqHandler_Event : LuaDelegate
	{
		public WaterBell_ProjX_Data_NetIO_NetMsgSeq_FinishSeqHandler_Event(LuaFunction func)
			: base(null)
		{
		}

		public WaterBell_ProjX_Data_NetIO_NetMsgSeq_FinishSeqHandler_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class WaterBell_ProjX_Data_NetIO_NetMsgSeq_FinishStepHandler_Event : LuaDelegate
	{
		public WaterBell_ProjX_Data_NetIO_NetMsgSeq_FinishStepHandler_Event(LuaFunction func)
			: base(null)
		{
		}

		public WaterBell_ProjX_Data_NetIO_NetMsgSeq_FinishStepHandler_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class System_Action_WaterBell_ProjX_Data_Entity_PropertyChangeedObservable_Event : LuaDelegate
	{
		public System_Action_WaterBell_ProjX_Data_Entity_PropertyChangeedObservable_Event(LuaFunction func)
			: base(null)
		{
		}

		public System_Action_WaterBell_ProjX_Data_Entity_PropertyChangeedObservable_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(PropertyChangeedObservable param0)
		{
		}

		public void CallWithSelf(PropertyChangeedObservable param0)
		{
		}
	}

	private class UIEventListener_VoidDelegate_Event : LuaDelegate
	{
		public UIEventListener_VoidDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIEventListener_VoidDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(GameObject param0)
		{
		}

		public void CallWithSelf(GameObject param0)
		{
		}
	}

	private class EventDelegate_Callback_Event : LuaDelegate
	{
		public EventDelegate_Callback_Event(LuaFunction func)
			: base(null)
		{
		}

		public EventDelegate_Callback_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class UIAlert_DelegateCheck_Event : LuaDelegate
	{
		public UIAlert_DelegateCheck_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIAlert_DelegateCheck_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(bool param0)
		{
		}

		public void CallWithSelf(bool param0)
		{
		}
	}

	private class System_Collections_ObjectModel_NotifyCollectionChangedEventHandler_Event : LuaDelegate
	{
		public System_Collections_ObjectModel_NotifyCollectionChangedEventHandler_Event(LuaFunction func)
			: base(null)
		{
		}

		public System_Collections_ObjectModel_NotifyCollectionChangedEventHandler_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(NotifyCollectionChangedEventArgs param0)
		{
		}

		public void CallWithSelf(NotifyCollectionChangedEventArgs param0)
		{
		}
	}

	private class System_ComponentModel_PropertyChangedEventHandler_Event : LuaDelegate
	{
		public System_ComponentModel_PropertyChangedEventHandler_Event(LuaFunction func)
			: base(null)
		{
		}

		public System_ComponentModel_PropertyChangedEventHandler_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(object param0, PropertyChangedEventArgs param1)
		{
		}

		public void CallWithSelf(object param0, PropertyChangedEventArgs param1)
		{
		}
	}

	private class UICamera_GetKeyStateFunc_Event : LuaDelegate
	{
		public UICamera_GetKeyStateFunc_Event(LuaFunction func)
			: base(null)
		{
		}

		public UICamera_GetKeyStateFunc_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public bool Call(KeyCode param0)
		{
			return false;
		}

		public bool CallWithSelf(KeyCode param0)
		{
			return false;
		}
	}

	private class UICamera_GetAxisFunc_Event : LuaDelegate
	{
		public UICamera_GetAxisFunc_Event(LuaFunction func)
			: base(null)
		{
		}

		public UICamera_GetAxisFunc_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public float Call(string param0)
		{
			return 0f;
		}

		public float CallWithSelf(string param0)
		{
			return 0f;
		}
	}

	private class UICamera_GetAnyKeyFunc_Event : LuaDelegate
	{
		public UICamera_GetAnyKeyFunc_Event(LuaFunction func)
			: base(null)
		{
		}

		public UICamera_GetAnyKeyFunc_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public bool Call()
		{
			return false;
		}

		public bool CallWithSelf()
		{
			return false;
		}
	}

	private class UICamera_OnScreenResize_Event : LuaDelegate
	{
		public UICamera_OnScreenResize_Event(LuaFunction func)
			: base(null)
		{
		}

		public UICamera_OnScreenResize_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class UICamera_OnCustomInput_Event : LuaDelegate
	{
		public UICamera_OnCustomInput_Event(LuaFunction func)
			: base(null)
		{
		}

		public UICamera_OnCustomInput_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class UICamera_OnSchemeChange_Event : LuaDelegate
	{
		public UICamera_OnSchemeChange_Event(LuaFunction func)
			: base(null)
		{
		}

		public UICamera_OnSchemeChange_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class UICamera_VoidDelegate_Event : LuaDelegate
	{
		public UICamera_VoidDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public UICamera_VoidDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(GameObject param0)
		{
		}

		public void CallWithSelf(GameObject param0)
		{
		}
	}

	private class UICamera_BoolDelegate_Event : LuaDelegate
	{
		public UICamera_BoolDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public UICamera_BoolDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(GameObject param0, bool param1)
		{
		}

		public void CallWithSelf(GameObject param0, bool param1)
		{
		}
	}

	private class UICamera_FloatDelegate_Event : LuaDelegate
	{
		public UICamera_FloatDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public UICamera_FloatDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(GameObject param0, float param1)
		{
		}

		public void CallWithSelf(GameObject param0, float param1)
		{
		}
	}

	private class UICamera_VectorDelegate_Event : LuaDelegate
	{
		public UICamera_VectorDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public UICamera_VectorDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(GameObject param0, Vector2 param1)
		{
		}

		public void CallWithSelf(GameObject param0, Vector2 param1)
		{
		}
	}

	private class UICamera_ObjectDelegate_Event : LuaDelegate
	{
		public UICamera_ObjectDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public UICamera_ObjectDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(GameObject param0, GameObject param1)
		{
		}

		public void CallWithSelf(GameObject param0, GameObject param1)
		{
		}
	}

	private class UICamera_KeyCodeDelegate_Event : LuaDelegate
	{
		public UICamera_KeyCodeDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public UICamera_KeyCodeDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(GameObject param0, KeyCode param1)
		{
		}

		public void CallWithSelf(GameObject param0, KeyCode param1)
		{
		}
	}

	private class UICamera_MoveDelegate_Event : LuaDelegate
	{
		public UICamera_MoveDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public UICamera_MoveDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(Vector2 param0)
		{
		}

		public void CallWithSelf(Vector2 param0)
		{
		}
	}

	private class UICamera_GetTouchCountCallback_Event : LuaDelegate
	{
		public UICamera_GetTouchCountCallback_Event(LuaFunction func)
			: base(null)
		{
		}

		public UICamera_GetTouchCountCallback_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public int Call()
		{
			return 0;
		}

		public int CallWithSelf()
		{
			return 0;
		}
	}

	private class UICamera_GetTouchCallback_Event : LuaDelegate
	{
		public UICamera_GetTouchCallback_Event(LuaFunction func)
			: base(null)
		{
		}

		public UICamera_GetTouchCallback_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public UICamera.Touch Call(int param0)
		{
			return null;
		}

		public UICamera.Touch CallWithSelf(int param0)
		{
			return null;
		}
	}

	private class UIPanel_OnGeometryUpdated_Event : LuaDelegate
	{
		public UIPanel_OnGeometryUpdated_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIPanel_OnGeometryUpdated_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class UIPanel_OnClippingMoved_Event : LuaDelegate
	{
		public UIPanel_OnClippingMoved_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIPanel_OnClippingMoved_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(UIPanel param0)
		{
		}

		public void CallWithSelf(UIPanel param0)
		{
		}
	}

	private class UIWidget_OnDimensionsChanged_Event : LuaDelegate
	{
		public UIWidget_OnDimensionsChanged_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIWidget_OnDimensionsChanged_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class UIWidget_OnPostFillCallback_Event : LuaDelegate
	{
		public UIWidget_OnPostFillCallback_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIWidget_OnPostFillCallback_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(UIWidget param0, int param1, BetterList<Vector3> param2, BetterList<Vector2> param3, BetterList<Color32> param4)
		{
		}

		public void CallWithSelf(UIWidget param0, int param1, BetterList<Vector3> param2, BetterList<Vector2> param3, BetterList<Color32> param4)
		{
		}
	}

	private class UIDrawCall_OnRenderCallback_Event : LuaDelegate
	{
		public UIDrawCall_OnRenderCallback_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIDrawCall_OnRenderCallback_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(Material param0)
		{
		}

		public void CallWithSelf(Material param0)
		{
		}
	}

	private class UIWidget_HitCheck_Event : LuaDelegate
	{
		public UIWidget_HitCheck_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIWidget_HitCheck_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public bool Call(Vector3 param0)
		{
			return false;
		}

		public bool CallWithSelf(Vector3 param0)
		{
			return false;
		}
	}

	private class UIGrid_OnReposition_Event : LuaDelegate
	{
		public UIGrid_OnReposition_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIGrid_OnReposition_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class System_Comparison_UnityEngine_Transform_Event : LuaDelegate
	{
		public System_Comparison_UnityEngine_Transform_Event(LuaFunction func)
			: base(null)
		{
		}

		public System_Comparison_UnityEngine_Transform_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public int Call(Transform param0, Transform param1)
		{
			return 0;
		}

		public int CallWithSelf(Transform param0, Transform param1)
		{
			return 0;
		}
	}

	private class UITable_OnReposition_Event : LuaDelegate
	{
		public UITable_OnReposition_Event(LuaFunction func)
			: base(null)
		{
		}

		public UITable_OnReposition_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class UIInput_OnValidate_Event : LuaDelegate
	{
		public UIInput_OnValidate_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIInput_OnValidate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public char Call(string param0, int param1, char param2)
		{
			return '\0';
		}

		public char CallWithSelf(string param0, int param1, char param2)
		{
			return '\0';
		}
	}

	private class UIEventListener_BoolDelegate_Event : LuaDelegate
	{
		public UIEventListener_BoolDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIEventListener_BoolDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(GameObject param0, bool param1)
		{
		}

		public void CallWithSelf(GameObject param0, bool param1)
		{
		}
	}

	private class UIEventListener_FloatDelegate_Event : LuaDelegate
	{
		public UIEventListener_FloatDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIEventListener_FloatDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(GameObject param0, float param1)
		{
		}

		public void CallWithSelf(GameObject param0, float param1)
		{
		}
	}

	private class UIEventListener_VectorDelegate_Event : LuaDelegate
	{
		public UIEventListener_VectorDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIEventListener_VectorDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(GameObject param0, Vector2 param1)
		{
		}

		public void CallWithSelf(GameObject param0, Vector2 param1)
		{
		}
	}

	private class UIEventListener_ObjectDelegate_Event : LuaDelegate
	{
		public UIEventListener_ObjectDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIEventListener_ObjectDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(GameObject param0, GameObject param1)
		{
		}

		public void CallWithSelf(GameObject param0, GameObject param1)
		{
		}
	}

	private class UIEventListener_KeyCodeDelegate_Event : LuaDelegate
	{
		public UIEventListener_KeyCodeDelegate_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIEventListener_KeyCodeDelegate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(GameObject param0, KeyCode param1)
		{
		}

		public void CallWithSelf(GameObject param0, KeyCode param1)
		{
		}
	}

	private class UIProgressBar_OnDragFinished_Event : LuaDelegate
	{
		public UIProgressBar_OnDragFinished_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIProgressBar_OnDragFinished_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class SpringPanel_OnFinished_Event : LuaDelegate
	{
		public SpringPanel_OnFinished_Event(LuaFunction func)
			: base(null)
		{
		}

		public SpringPanel_OnFinished_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class UICenterOnChild_OnCenterCallback_Event : LuaDelegate
	{
		public UICenterOnChild_OnCenterCallback_Event(LuaFunction func)
			: base(null)
		{
		}

		public UICenterOnChild_OnCenterCallback_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(GameObject param0)
		{
		}

		public void CallWithSelf(GameObject param0)
		{
		}
	}

	private class UIScrollView_OnDragNotification_Event : LuaDelegate
	{
		public UIScrollView_OnDragNotification_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIScrollView_OnDragNotification_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	private class UIWrapContent_OnInitializeItem_Event : LuaDelegate
	{
		public UIWrapContent_OnInitializeItem_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIWrapContent_OnInitializeItem_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call(GameObject param0, int param1, int param2)
		{
		}

		public void CallWithSelf(GameObject param0, int param1, int param2)
		{
		}
	}

	private class UIToggle_Validate_Event : LuaDelegate
	{
		public UIToggle_Validate_Event(LuaFunction func)
			: base(null)
		{
		}

		public UIToggle_Validate_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public bool Call(bool param0)
		{
			return false;
		}

		public bool CallWithSelf(bool param0)
		{
			return false;
		}
	}

	private class Localization_LoadFunction_Event : LuaDelegate
	{
		public Localization_LoadFunction_Event(LuaFunction func)
			: base(null)
		{
		}

		public Localization_LoadFunction_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public byte[] Call(string param0)
		{
			return null;
		}

		public byte[] CallWithSelf(string param0)
		{
			return null;
		}
	}

	private class Localization_OnLocalizeNotification_Event : LuaDelegate
	{
		public Localization_OnLocalizeNotification_Event(LuaFunction func)
			: base(null)
		{
		}

		public Localization_OnLocalizeNotification_Event(LuaFunction func, LuaTable self)
			: base(null)
		{
		}

		public void Call()
		{
		}

		public void CallWithSelf()
		{
		}
	}

	public static Dictionary<Type, DelegateCreate> dict;

	private static DelegateFactory factory;

	static DelegateFactory()
	{
	}

	public static void Init()
	{
	}

	[NoToLua]
	public static void Register()
	{
	}

	[NoToLua]
	public static Delegate CreateDelegate(Type t, LuaFunction func = null)
	{
		return null;
	}

	[NoToLua]
	public static Delegate CreateDelegate(Type t, LuaFunction func, LuaTable self)
	{
		return null;
	}

	[NoToLua]
	public static Delegate RemoveDelegate(Delegate obj, LuaFunction func)
	{
		return null;
	}

	[NoToLua]
	public static Delegate RemoveDelegate(Delegate obj, Delegate dg)
	{
		return null;
	}

	public Action System_Action(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_System_Action(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_System_Action(IntPtr L, Action o)
	{
	}

	public UnityAction UnityEngine_Events_UnityAction(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UnityEngine_Events_UnityAction(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UnityEngine_Events_UnityAction(IntPtr L, UnityAction o)
	{
	}

	public Predicate<int> System_Predicate_int(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_System_Predicate_int(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_System_Predicate_int(IntPtr L, Predicate<int> o)
	{
	}

	public Action<int> System_Action_int(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_System_Action_int(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_System_Action_int(IntPtr L, Action<int> o)
	{
	}

	public Comparison<int> System_Comparison_int(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_System_Comparison_int(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_System_Comparison_int(IntPtr L, Comparison<int> o)
	{
	}

	public Func<int, int> System_Func_int_int(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_System_Func_int_int(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_System_Func_int_int(IntPtr L, Func<int, int> o)
	{
	}

	public Action<TypeCsvActivity> System_Action_TypeCsvActivity(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_System_Action_TypeCsvActivity(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_System_Action_TypeCsvActivity(IntPtr L, Action<TypeCsvActivity> o)
	{
	}

	public LuaNetProxy.OnDataDelegate LuaNetProxy_OnDataDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_LuaNetProxy_OnDataDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_LuaNetProxy_OnDataDelegate(IntPtr L, LuaNetProxy.OnDataDelegate o)
	{
	}

	public Function Function(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_Function(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_Function(IntPtr L, Function o)
	{
	}

	public FunctionBool FunctionBool(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_FunctionBool(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_FunctionBool(IntPtr L, FunctionBool o)
	{
	}

	public FunctionDouble FunctionDouble(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_FunctionDouble(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_FunctionDouble(IntPtr L, FunctionDouble o)
	{
	}

	public FunctionGameObject FunctionGameObject(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_FunctionGameObject(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_FunctionGameObject(IntPtr L, FunctionGameObject o)
	{
	}

	public FunctionUlong FunctionUlong(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_FunctionUlong(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_FunctionUlong(IntPtr L, FunctionUlong o)
	{
	}

	public FunctionListenerEvent FunctionListenerEvent(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_FunctionListenerEvent(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_FunctionListenerEvent(IntPtr L, FunctionListenerEvent o)
	{
	}

	public FunctionUnArgs FunctionUnArgs(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_FunctionUnArgs(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_FunctionUnArgs(IntPtr L, FunctionUnArgs o)
	{
	}

	public UIWindowsManager.CloseAction UIWindowsManager_CloseAction(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIWindowsManager_CloseAction(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIWindowsManager_CloseAction(IntPtr L, UIWindowsManager.CloseAction o)
	{
	}

	public Camera.CameraCallback UnityEngine_Camera_CameraCallback(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UnityEngine_Camera_CameraCallback(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UnityEngine_Camera_CameraCallback(IntPtr L, Camera.CameraCallback o)
	{
	}

	public Application.LowMemoryCallback UnityEngine_Application_LowMemoryCallback(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UnityEngine_Application_LowMemoryCallback(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UnityEngine_Application_LowMemoryCallback(IntPtr L, Application.LowMemoryCallback o)
	{
	}

	public Application.AdvertisingIdentifierCallback UnityEngine_Application_AdvertisingIdentifierCallback(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UnityEngine_Application_AdvertisingIdentifierCallback(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UnityEngine_Application_AdvertisingIdentifierCallback(IntPtr L, Application.AdvertisingIdentifierCallback o)
	{
	}

	public Application.LogCallback UnityEngine_Application_LogCallback(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UnityEngine_Application_LogCallback(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UnityEngine_Application_LogCallback(IntPtr L, Application.LogCallback o)
	{
	}

	public AudioClip.PCMReaderCallback UnityEngine_AudioClip_PCMReaderCallback(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UnityEngine_AudioClip_PCMReaderCallback(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UnityEngine_AudioClip_PCMReaderCallback(IntPtr L, AudioClip.PCMReaderCallback o)
	{
	}

	public AudioClip.PCMSetPositionCallback UnityEngine_AudioClip_PCMSetPositionCallback(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UnityEngine_AudioClip_PCMSetPositionCallback(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UnityEngine_AudioClip_PCMSetPositionCallback(IntPtr L, AudioClip.PCMSetPositionCallback o)
	{
	}

	public Action<UnityEngine.AsyncOperation> System_Action_UnityEngine_AsyncOperation(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_System_Action_UnityEngine_AsyncOperation(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_System_Action_UnityEngine_AsyncOperation(IntPtr L, Action<UnityEngine.AsyncOperation> o)
	{
	}

	public NetMsgBase.SuccessfulDelegate WaterBell_ProjX_Data_NetIO_NetMsgBase_SuccessfulDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_WaterBell_ProjX_Data_NetIO_NetMsgBase_SuccessfulDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_WaterBell_ProjX_Data_NetIO_NetMsgBase_SuccessfulDelegate(IntPtr L, NetMsgBase.SuccessfulDelegate o)
	{
	}

	public NetMsgBase.FailedDelegate WaterBell_ProjX_Data_NetIO_NetMsgBase_FailedDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_WaterBell_ProjX_Data_NetIO_NetMsgBase_FailedDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_WaterBell_ProjX_Data_NetIO_NetMsgBase_FailedDelegate(IntPtr L, NetMsgBase.FailedDelegate o)
	{
	}

	public NetMsgBase.ErrorDelegate WaterBell_ProjX_Data_NetIO_NetMsgBase_ErrorDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_WaterBell_ProjX_Data_NetIO_NetMsgBase_ErrorDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_WaterBell_ProjX_Data_NetIO_NetMsgBase_ErrorDelegate(IntPtr L, NetMsgBase.ErrorDelegate o)
	{
	}

	public NetMsgBase.TimeOutDelegate WaterBell_ProjX_Data_NetIO_NetMsgBase_TimeOutDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_WaterBell_ProjX_Data_NetIO_NetMsgBase_TimeOutDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_WaterBell_ProjX_Data_NetIO_NetMsgBase_TimeOutDelegate(IntPtr L, NetMsgBase.TimeOutDelegate o)
	{
	}

	public NetMsgBase.InternalErrorDelegate WaterBell_ProjX_Data_NetIO_NetMsgBase_InternalErrorDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_WaterBell_ProjX_Data_NetIO_NetMsgBase_InternalErrorDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_WaterBell_ProjX_Data_NetIO_NetMsgBase_InternalErrorDelegate(IntPtr L, NetMsgBase.InternalErrorDelegate o)
	{
	}

	public NetMsgBase.DealResultHandler WaterBell_ProjX_Data_NetIO_NetMsgBase_DealResultHandler(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_WaterBell_ProjX_Data_NetIO_NetMsgBase_DealResultHandler(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_WaterBell_ProjX_Data_NetIO_NetMsgBase_DealResultHandler(IntPtr L, NetMsgBase.DealResultHandler o)
	{
	}

	public NetMsgSeq.FinishSeqHandler WaterBell_ProjX_Data_NetIO_NetMsgSeq_FinishSeqHandler(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_WaterBell_ProjX_Data_NetIO_NetMsgSeq_FinishSeqHandler(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_WaterBell_ProjX_Data_NetIO_NetMsgSeq_FinishSeqHandler(IntPtr L, NetMsgSeq.FinishSeqHandler o)
	{
	}

	public NetMsgSeq.FinishStepHandler WaterBell_ProjX_Data_NetIO_NetMsgSeq_FinishStepHandler(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_WaterBell_ProjX_Data_NetIO_NetMsgSeq_FinishStepHandler(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_WaterBell_ProjX_Data_NetIO_NetMsgSeq_FinishStepHandler(IntPtr L, NetMsgSeq.FinishStepHandler o)
	{
	}

	public Action<PropertyChangeedObservable> System_Action_WaterBell_ProjX_Data_Entity_PropertyChangeedObservable(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_System_Action_WaterBell_ProjX_Data_Entity_PropertyChangeedObservable(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_System_Action_WaterBell_ProjX_Data_Entity_PropertyChangeedObservable(IntPtr L, Action<PropertyChangeedObservable> o)
	{
	}

	public UIEventListener.VoidDelegate UIEventListener_VoidDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIEventListener_VoidDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIEventListener_VoidDelegate(IntPtr L, UIEventListener.VoidDelegate o)
	{
	}

	public EventDelegate.Callback EventDelegate_Callback(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_EventDelegate_Callback(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_EventDelegate_Callback(IntPtr L, EventDelegate.Callback o)
	{
	}

	public UIAlert.DelegateCheck UIAlert_DelegateCheck(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIAlert_DelegateCheck(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIAlert_DelegateCheck(IntPtr L, UIAlert.DelegateCheck o)
	{
	}

	public NotifyCollectionChangedEventHandler System_Collections_ObjectModel_NotifyCollectionChangedEventHandler(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_System_Collections_ObjectModel_NotifyCollectionChangedEventHandler(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_System_Collections_ObjectModel_NotifyCollectionChangedEventHandler(IntPtr L, NotifyCollectionChangedEventHandler o)
	{
	}

	public PropertyChangedEventHandler System_ComponentModel_PropertyChangedEventHandler(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_System_ComponentModel_PropertyChangedEventHandler(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_System_ComponentModel_PropertyChangedEventHandler(IntPtr L, PropertyChangedEventHandler o)
	{
	}

	public UICamera.GetKeyStateFunc UICamera_GetKeyStateFunc(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UICamera_GetKeyStateFunc(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UICamera_GetKeyStateFunc(IntPtr L, UICamera.GetKeyStateFunc o)
	{
	}

	public UICamera.GetAxisFunc UICamera_GetAxisFunc(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UICamera_GetAxisFunc(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UICamera_GetAxisFunc(IntPtr L, UICamera.GetAxisFunc o)
	{
	}

	public UICamera.GetAnyKeyFunc UICamera_GetAnyKeyFunc(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UICamera_GetAnyKeyFunc(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UICamera_GetAnyKeyFunc(IntPtr L, UICamera.GetAnyKeyFunc o)
	{
	}

	public UICamera.OnScreenResize UICamera_OnScreenResize(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UICamera_OnScreenResize(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UICamera_OnScreenResize(IntPtr L, UICamera.OnScreenResize o)
	{
	}

	public UICamera.OnCustomInput UICamera_OnCustomInput(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UICamera_OnCustomInput(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UICamera_OnCustomInput(IntPtr L, UICamera.OnCustomInput o)
	{
	}

	public UICamera.OnSchemeChange UICamera_OnSchemeChange(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UICamera_OnSchemeChange(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UICamera_OnSchemeChange(IntPtr L, UICamera.OnSchemeChange o)
	{
	}

	public UICamera.VoidDelegate UICamera_VoidDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UICamera_VoidDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UICamera_VoidDelegate(IntPtr L, UICamera.VoidDelegate o)
	{
	}

	public UICamera.BoolDelegate UICamera_BoolDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UICamera_BoolDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UICamera_BoolDelegate(IntPtr L, UICamera.BoolDelegate o)
	{
	}

	public UICamera.FloatDelegate UICamera_FloatDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UICamera_FloatDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UICamera_FloatDelegate(IntPtr L, UICamera.FloatDelegate o)
	{
	}

	public UICamera.VectorDelegate UICamera_VectorDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UICamera_VectorDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UICamera_VectorDelegate(IntPtr L, UICamera.VectorDelegate o)
	{
	}

	public UICamera.ObjectDelegate UICamera_ObjectDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UICamera_ObjectDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UICamera_ObjectDelegate(IntPtr L, UICamera.ObjectDelegate o)
	{
	}

	public UICamera.KeyCodeDelegate UICamera_KeyCodeDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UICamera_KeyCodeDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UICamera_KeyCodeDelegate(IntPtr L, UICamera.KeyCodeDelegate o)
	{
	}

	public UICamera.MoveDelegate UICamera_MoveDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UICamera_MoveDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UICamera_MoveDelegate(IntPtr L, UICamera.MoveDelegate o)
	{
	}

	public UICamera.GetTouchCountCallback UICamera_GetTouchCountCallback(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UICamera_GetTouchCountCallback(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UICamera_GetTouchCountCallback(IntPtr L, UICamera.GetTouchCountCallback o)
	{
	}

	public UICamera.GetTouchCallback UICamera_GetTouchCallback(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UICamera_GetTouchCallback(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UICamera_GetTouchCallback(IntPtr L, UICamera.GetTouchCallback o)
	{
	}

	public UIPanel.OnGeometryUpdated UIPanel_OnGeometryUpdated(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIPanel_OnGeometryUpdated(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIPanel_OnGeometryUpdated(IntPtr L, UIPanel.OnGeometryUpdated o)
	{
	}

	public UIPanel.OnClippingMoved UIPanel_OnClippingMoved(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIPanel_OnClippingMoved(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIPanel_OnClippingMoved(IntPtr L, UIPanel.OnClippingMoved o)
	{
	}

	public UIWidget.OnDimensionsChanged UIWidget_OnDimensionsChanged(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIWidget_OnDimensionsChanged(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIWidget_OnDimensionsChanged(IntPtr L, UIWidget.OnDimensionsChanged o)
	{
	}

	public UIWidget.OnPostFillCallback UIWidget_OnPostFillCallback(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIWidget_OnPostFillCallback(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIWidget_OnPostFillCallback(IntPtr L, UIWidget.OnPostFillCallback o)
	{
	}

	public UIDrawCall.OnRenderCallback UIDrawCall_OnRenderCallback(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIDrawCall_OnRenderCallback(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIDrawCall_OnRenderCallback(IntPtr L, UIDrawCall.OnRenderCallback o)
	{
	}

	public UIWidget.HitCheck UIWidget_HitCheck(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIWidget_HitCheck(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIWidget_HitCheck(IntPtr L, UIWidget.HitCheck o)
	{
	}

	public UIGrid.OnReposition UIGrid_OnReposition(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIGrid_OnReposition(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIGrid_OnReposition(IntPtr L, UIGrid.OnReposition o)
	{
	}

	public Comparison<Transform> System_Comparison_UnityEngine_Transform(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_System_Comparison_UnityEngine_Transform(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_System_Comparison_UnityEngine_Transform(IntPtr L, Comparison<Transform> o)
	{
	}

	public UITable.OnReposition UITable_OnReposition(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UITable_OnReposition(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UITable_OnReposition(IntPtr L, UITable.OnReposition o)
	{
	}

	public UIInput.OnValidate UIInput_OnValidate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIInput_OnValidate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIInput_OnValidate(IntPtr L, UIInput.OnValidate o)
	{
	}

	public UIEventListener.BoolDelegate UIEventListener_BoolDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIEventListener_BoolDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIEventListener_BoolDelegate(IntPtr L, UIEventListener.BoolDelegate o)
	{
	}

	public UIEventListener.FloatDelegate UIEventListener_FloatDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIEventListener_FloatDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIEventListener_FloatDelegate(IntPtr L, UIEventListener.FloatDelegate o)
	{
	}

	public UIEventListener.VectorDelegate UIEventListener_VectorDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIEventListener_VectorDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIEventListener_VectorDelegate(IntPtr L, UIEventListener.VectorDelegate o)
	{
	}

	public UIEventListener.ObjectDelegate UIEventListener_ObjectDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIEventListener_ObjectDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIEventListener_ObjectDelegate(IntPtr L, UIEventListener.ObjectDelegate o)
	{
	}

	public UIEventListener.KeyCodeDelegate UIEventListener_KeyCodeDelegate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIEventListener_KeyCodeDelegate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIEventListener_KeyCodeDelegate(IntPtr L, UIEventListener.KeyCodeDelegate o)
	{
	}

	public UIProgressBar.OnDragFinished UIProgressBar_OnDragFinished(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIProgressBar_OnDragFinished(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIProgressBar_OnDragFinished(IntPtr L, UIProgressBar.OnDragFinished o)
	{
	}

	public SpringPanel.OnFinished SpringPanel_OnFinished(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_SpringPanel_OnFinished(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_SpringPanel_OnFinished(IntPtr L, SpringPanel.OnFinished o)
	{
	}

	public UICenterOnChild.OnCenterCallback UICenterOnChild_OnCenterCallback(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UICenterOnChild_OnCenterCallback(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UICenterOnChild_OnCenterCallback(IntPtr L, UICenterOnChild.OnCenterCallback o)
	{
	}

	public UIScrollView.OnDragNotification UIScrollView_OnDragNotification(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIScrollView_OnDragNotification(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIScrollView_OnDragNotification(IntPtr L, UIScrollView.OnDragNotification o)
	{
	}

	public UIWrapContent.OnInitializeItem UIWrapContent_OnInitializeItem(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIWrapContent_OnInitializeItem(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIWrapContent_OnInitializeItem(IntPtr L, UIWrapContent.OnInitializeItem o)
	{
	}

	public UIToggle.Validate UIToggle_Validate(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_UIToggle_Validate(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_UIToggle_Validate(IntPtr L, UIToggle.Validate o)
	{
	}

	public Localization.LoadFunction Localization_LoadFunction(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_Localization_LoadFunction(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_Localization_LoadFunction(IntPtr L, Localization.LoadFunction o)
	{
	}

	public Localization.OnLocalizeNotification Localization_OnLocalizeNotification(LuaFunction func, LuaTable self, bool flag)
	{
		return null;
	}

	private bool Check_Localization_OnLocalizeNotification(IntPtr L, int pos)
	{
		return false;
	}

	private void Push_Localization_OnLocalizeNotification(IntPtr L, Localization.OnLocalizeNotification o)
	{
	}
}
