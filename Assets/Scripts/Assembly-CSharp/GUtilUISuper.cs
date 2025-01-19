using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class GUtilUISuper : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	private delegate void FunctionLoadComplete(Type sType, string uiName);

	public const int LAYER_UI_DEFAULT = 8;

	private static GameObject _anchorTopLeft;

	private static GameObject _anchorCenter;

	private static Dictionary<Type, List<GUtilUISuper>> _hashUI;

	protected List<SuperUIButton> _myButtons;

	protected bool _isDestroy;

	protected bool _isStart;

	protected GUtilUISuper _back;

	public static float screenHeight
	{
		get
		{
			return 0f;
		}
	}

	public static float screenWidth
	{
		get
		{
			return 0f;
		}
	}

	public static Transform anchorTopLeft
	{
		get
		{
			return null;
		}
	}

	public static Transform anchorCenter
	{
		get
		{
			return null;
		}
	}

	public static T show<T>(string sName, List<string> sFullUrl, bool sIsSign = true) where T : GUtilUISuper
	{
		return null;
	}

	public static GUtilUISuper show(Type sType, string sName, List<string> sFullUrl, bool sIsSign = true)
	{
		return null;
	}

	public static T showNew<T>(string sName) where T : GUtilUISuper
	{
		return null;
	}

	private static GUtilUISuper showReal(Type sType, string sName, string sPath)
	{
		return null;
	}

	public static T getUI<T>() where T : GUtilUISuper
	{
		return null;
	}

	public static List<T> getUIs<T>() where T : GUtilUISuper
	{
		return null;
	}

	public static void close<T>() where T : GUtilUISuper
	{
	}

	protected static UISprite craeteSprite(Transform sParent)
	{
		return null;
	}

	protected virtual void Start()
	{
	}

	protected void createBack()
	{
	}

	protected int getMinDepthPanel()
	{
		return 0;
	}

	protected virtual void initListener()
	{
	}

	protected virtual ButtonEx addButtonEx(GameObject sButton)
	{
		return null;
	}

	protected virtual void animShow()
	{
	}

	protected void animShowAlpha()
	{
	}

	protected void animShowScale()
	{
	}

	protected virtual void animClose()
	{
	}

	public virtual void destroyButton()
	{
	}

	public virtual void destroy()
	{
	}

	protected virtual void doneEventListener(string sListener)
	{
	}

	public static GameObject cloneGameObject(GameObject sTemplet, string name)
	{
		return null;
	}

	protected static void setSprite(GameObject sObj, string sSprite)
	{
	}

	protected static UISprite createSprite(Transform sParent, string sAtla, string sSprite)
	{
		return null;
	}

	protected static UILabel createLabel(Transform sParent, string sText)
	{
		return null;
	}
}
