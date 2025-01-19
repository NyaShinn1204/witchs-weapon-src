using UnityEngine;

public class DHCUISprite : UISprite
{
	public Vector2 _TL;

	public Vector2 _TR;

	public Vector2 _BL;

	public Vector2 _BR;

	public float _fillX;

	public float _fillY;

	protected override void Awake()
	{
	}

	public void setBorder(Vector2 tl, Vector2 tr, Vector2 bl, Vector2 br, float fillX, float fillY)
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
