using System.Runtime.InteropServices;
using UnityEngine;

public class GridBaseOnOffset : UIGrid
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void VoidDelegate();

	protected BetterList<float> offsetArray;

	protected float mOffset;

	protected BetterList<Transform> children;

	public float top;

	public float bot;

	public bool mFree;

	public VoidDelegate onFinished;

	protected float target;

	protected float speed;

	protected float lastOffset;

	private const float SPEED_SAMPLING = 0.5f;

	private const float SPEED_EXPACT = 5f;

	protected float moverate;

	protected float moverate2;

	public bool free
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float offset
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public virtual float spacing
	{
		get
		{
			return 0f;
		}
	}

	public int chosenIndex
	{
		get
		{
			return 0;
		}
	}

	protected virtual void Awake()
	{
	}

	protected override void Start()
	{
	}

	public void refreshAll()
	{
	}

	public void reset()
	{
	}

	public virtual void refreshChildAt(int index)
	{
	}

	public void setTargetAlpha(GameObject go, float value)
	{
	}

	public virtual void move(Vector3 vec)
	{
	}

	public float checkOffset()
	{
		return 0f;
	}

	protected override void Update()
	{
	}

	public void refreshTarget()
	{
	}

	public virtual void moveToTarget()
	{
	}

	public void setTarget(int index)
	{
	}
}
