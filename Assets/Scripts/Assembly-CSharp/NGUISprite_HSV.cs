using UnityEngine;

public class NGUISprite_HSV : NGUISprite_Base
{
	public float _Alpha;

	public float _HueShift;

	public float _Saturation;

	public float _ValueBrightness;

	protected override Material getNewMaterial()
	{
		return null;
	}

	protected override void UpdateMaterial()
	{
	}
}
