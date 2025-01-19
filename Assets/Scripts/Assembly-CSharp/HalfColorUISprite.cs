using UnityEngine;

public class HalfColorUISprite : UISprite
{
	public static Rect zeroRect;

	private Rect mClipRect;

	private Color tempColor;

	private Vector2 mSkew;

	public static Color HALF_COLOR
	{
		get
		{
			return default(Color);
		}
	}

	public static Color BRIGHT_COLOR
	{
		get
		{
			return default(Color);
		}
	}

	public static Color PAUSE_COLOR
	{
		get
		{
			return default(Color);
		}
	}

	public bool pauseColor
	{
		set
		{
		}
	}

	public Color baseColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Rect clipRect
	{
		get
		{
			return default(Rect);
		}
		set
		{
		}
	}

	public Vector2 skew
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public float fixedAlpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected new void Start()
	{
	}

	public new void Update()
	{
	}

	protected override void Awake()
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
