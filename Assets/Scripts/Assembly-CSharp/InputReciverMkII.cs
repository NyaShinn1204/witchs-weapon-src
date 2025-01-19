using UnityEngine;
using unit;

[HideInInspector]
public class InputReciverMkII : InputReciver
{
	public new static InputReciverMkII instance;

	public Vector3 mouseStartPoint;

	public Vector3 lastMousePoint;

	public Vector3 currMousePoint;

	public MonsterEntity unitOnPress;

	public bool isSliding;

	public float holdStartTime;

	public const float lookForward = 0.5f;

	public float MAX_DRAG_DISTANCE;

	public const float MIN_DRAG_DISTANCE = 6f;

	public Rect rect;

	protected float rectLeft;

	protected float rectBase;

	protected float dragRatio;

	public bool reachRect;

	public float rectBorder;

	private int startFingerID;

	private float screenHeight
	{
		get
		{
			return 0f;
		}
	}

	private float screenWidth
	{
		get
		{
			return 0f;
		}
	}

	private int skillCount
	{
		get
		{
			return 0;
		}
	}

	private float skillWidth
	{
		get
		{
			return 0f;
		}
	}

	private float skillHeight
	{
		get
		{
			return 0f;
		}
	}

	private float skillRadius
	{
		get
		{
			return 0f;
		}
	}

	private void Awake()
	{
	}

	public override void Start()
	{
	}

	public override void OnDestroy()
	{
	}

	private Vector3 getCurrentPoint()
	{
		return default(Vector3);
	}

	public void ResetRect()
	{
	}

	public override void ReleaseMouse()
	{
	}

	public override void PressMouse()
	{
	}

	private void OrigPressMouse()
	{
	}

	protected void Sliding()
	{
	}

	protected void SaveSelectedMonsterOnPress()
	{
	}

	public override void MouseDown()
	{
	}

	public bool IsCurrPointInSkillBtnRegion(Vector3 sPposition)
	{
		return false;
	}
}
