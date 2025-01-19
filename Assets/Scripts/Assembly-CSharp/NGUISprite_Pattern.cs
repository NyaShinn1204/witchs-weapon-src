using UnityEngine;

public class NGUISprite_Pattern : NGUISprite_Base
{
	public float _Alpha;

	public Texture2D __MainTex2;

	public float _OffsetX;

	public float _OffsetY;

	public bool _AutoScrollX;

	public float _AutoScrollSpeedX;

	public bool _AutoScrollY;

	public float _AutoScrollSpeedY;

	private float _AutoScrollCountX;

	private float _AutoScrollCountY;

	protected override Material getNewMaterial()
	{
		return null;
	}

	protected override void UpdateMaterial()
	{
	}
}
