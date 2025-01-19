using UnityEngine;

public class NGUISprite_Crystal : NGUISprite_Base
{
	public float _Alpha;

	public float _OffsetX;

	public float _OffsetY;

	public float _Factor;

	public bool _Animate;

	public float _Speed;

	public float _Distance;

	private float _AutoSin;

	protected override Material getNewMaterial()
	{
		return null;
	}

	protected override void UpdateMaterial()
	{
	}
}
