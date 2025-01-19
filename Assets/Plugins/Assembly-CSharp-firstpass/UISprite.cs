using System;
using UnityEngine;

[ExecuteInEditMode]
public class UISprite : UIBasicSprite
{
	private bool _hasListener;

	[HideInInspector]
	public UIAtlas _staticAtlas;

	[HideInInspector]
	[SerializeField]
	private UIAtlas mAtlas;

	[HideInInspector]
	[SerializeField]
	private string mSpriteName;

	[HideInInspector]
	[SerializeField]
	private bool mFillCenter;

	[NonSerialized]
	protected UISpriteData mSprite;

	[NonSerialized]
	private bool mSpriteSet;

	public override Material material
	{
		get
		{
			return null;
		}
	}

	public UIAtlas atlas
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string spriteName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool isValid
	{
		get
		{
			return false;
		}
	}

	[Obsolete]
	public bool fillCenter
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override Vector4 border
	{
		get
		{
			return default(Vector4);
		}
	}

	public override float pixelSize
	{
		get
		{
			return 0f;
		}
	}

	public override int minWidth
	{
		get
		{
			return 0;
		}
	}

	public override int minHeight
	{
		get
		{
			return 0;
		}
	}

	public override Vector4 drawingDimensions
	{
		get
		{
			return default(Vector4);
		}
	}

	public override bool premultipliedAlpha
	{
		get
		{
			return false;
		}
	}

	protected override void Awake()
	{
	}

	private void ChangeLanaguage(GUtilListenerEvent sEvent)
	{
	}

	public UISpriteData GetAtlasSprite()
	{
		return null;
	}

	protected void SetAtlasSprite(UISpriteData sp)
	{
	}

	public override void MakePixelPerfect()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
