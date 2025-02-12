using System.Runtime.InteropServices;
using UnityEngine;

[ExecuteInEditMode]
public class ScrollViewBaseOnOffset : MonoBehaviour
{
	public enum Movement
	{
		Horizontal = 0,
		Vertical = 1,
		Unrestricted = 2,
		Custom = 3
	}

	public enum DragEffect
	{
		None = 0,
		Momentum = 1,
		MomentumAndSpring = 2
	}

	public enum ShowCondition
	{
		Always = 0,
		OnlyIfNeeded = 1,
		WhenDragging = 2
	}

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnDragFinished();

	private GridBaseOnOffset grid;

	public static BetterList<ScrollViewBaseOnOffset> list;

	public Movement movement;

	public DragEffect dragEffect;

	public bool restrictWithinPanel;

	public bool disableDragIfFits;

	public bool smoothDragStart;

	public bool iOSDragEmulation;

	public float scrollWheelFactor;

	public float momentumAmount;

	public UIProgressBar horizontalScrollBar;

	public UIProgressBar verticalScrollBar;

	public ShowCondition showScrollBars;

	public Vector2 customMovement;

	public UIWidget.Pivot contentPivot;

	public OnDragFinished onDragFinished;

	[HideInInspector]
	[SerializeField]
	private Vector3 scale;

	[SerializeField]
	[HideInInspector]
	private Vector2 relativePositionOnReset;

	protected Transform mTrans;

	protected UIPanel mPanel;

	protected Plane mPlane;

	protected Vector3 mLastPos;

	protected bool mPressed;

	protected Vector3 mMomentum;

	protected float mScroll;

	protected Bounds mBounds;

	protected bool mCalculatedBounds;

	protected bool mShouldMove;

	protected bool mIgnoreCallbacks;

	protected int mDragID;

	protected Vector2 mDragStartOffset;

	protected bool mDragStarted;

	public UIPanel panel
	{
		get
		{
			return null;
		}
	}

	public bool isDragging
	{
		get
		{
			return false;
		}
	}

	public virtual Bounds bounds
	{
		get
		{
			return default(Bounds);
		}
	}

	public bool canMoveHorizontally
	{
		get
		{
			return false;
		}
	}

	public bool canMoveVertically
	{
		get
		{
			return false;
		}
	}

	public virtual bool shouldMoveHorizontally
	{
		get
		{
			return false;
		}
	}

	public virtual bool shouldMoveVertically
	{
		get
		{
			return false;
		}
	}

	protected virtual bool shouldMove
	{
		get
		{
			return false;
		}
	}

	public Vector3 currentMomentum
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected virtual void Start()
	{
	}

	public bool RestrictWithinBounds(bool instant)
	{
		return false;
	}

	public bool RestrictWithinBounds(bool instant, bool horizontal, bool vertical)
	{
		return false;
	}

	public void DisableSpring()
	{
	}

	public virtual void UpdateScrollbars(bool recalculateBounds)
	{
	}

	protected void UpdateScrollbars(UIProgressBar slider, float contentMin, float contentMax, float contentSize, float viewSize, bool inverted)
	{
	}

	public virtual void SetDragAmount(float x, float y, bool updateScrollbars)
	{
	}

	public void ResetPosition()
	{
	}

	public void UpdatePosition()
	{
	}

	public void OnScrollBar()
	{
	}

	public virtual void MoveRelative(Vector3 relative)
	{
	}

	public virtual void MoveAbsolute(Vector3 absolute)
	{
	}

	public void Press(bool pressed)
	{
	}

	public void Release()
	{
	}

	public void Drag()
	{
	}

	public void Scroll(float delta)
	{
	}

	public void checkOffset(bool instant)
	{
	}
}
