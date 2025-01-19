using UnityEngine;

public class NGUISprite_GrayScale : NGUISprite_Base
{
	public float _EffectAmount;

	public float _Alpha;

	protected override Material getNewMaterial()
	{
		return null;
	}

	protected override void UpdateMaterial()
	{
	}
}
