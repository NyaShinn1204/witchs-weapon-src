using UnityEngine;

public class NGUISprite_PlasmaRainbow : NGUISprite_Base
{
	public float _Alpha;

	public float _Colors;

	public float _Offset;

	private float _TimeX;

	public float Speed;

	protected override Material getNewMaterial()
	{
		return null;
	}

	protected override void UpdateMaterial()
	{
	}
}
