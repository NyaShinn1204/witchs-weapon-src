using UnityEngine;

[ExecuteInEditMode]
public class UIAnchor : MonoBehaviour
{
	public enum Side
	{
		BottomLeft = 0,
		Left = 1,
		TopLeft = 2,
		Top = 3,
		TopRight = 4,
		Right = 5,
		BottomRight = 6,
		Bottom = 7,
		Center = 8
	}

	private static int _define_cut;

	private const string _define_cut_key = "com.shuiqinling.user.define.cut";

	private static string _refresh_key;

	public static bool IS_IPHONEX;

	public Camera uiCamera;

	public GameObject container;

	public Side side;

	public bool unCareCut;

	public bool runOnlyOnce;

	public Vector2 relativeOffset;

	public Vector2 pixelOffset;

	[HideInInspector]
	[SerializeField]
	private UIWidget widgetContainer;

	private Transform mTrans;

	private Animation mAnim;

	private Rect mRect;

	private UIRoot mRoot;

	private bool mStarted;

	public static float iPhoneXCut
	{
		get
		{
			return 0f;
		}
	}

	public static int UserDefineCut
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static bool iPhoneX
	{
		get
		{
			return false;
		}
	}

	private static void Refresh()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void ScreenSizeChanged()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
