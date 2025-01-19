using UnityEngine;

public class MngrUI : MonoBehaviour
{
	private static Transform _battlePanel;

	private static Transform _uiRoot;

	private static int _IDSign;

	private static float _screenHeight;

	private static float _RATIO_BASE;

	private static Camera _cameraMain;

	private static Camera _cameraMainUI;

	public static Transform battlePanel
	{
		get
		{
			return null;
		}
	}

	public static Transform uiRoot
	{
		get
		{
			return null;
		}
	}

	public static int IDSign
	{
		get
		{
			return 0;
		}
	}

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

	public static float screenWidthAnchor
	{
		get
		{
			return 0f;
		}
	}

	public static float screenMul
	{
		get
		{
			return 0f;
		}
	}

	public static Camera cameraMain
	{
		get
		{
			return null;
		}
	}

	public static Camera cameraMainUI
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public static GameObject getUI(string sName)
	{
		return null;
	}
}
