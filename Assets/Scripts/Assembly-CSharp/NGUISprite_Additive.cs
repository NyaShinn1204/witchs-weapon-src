using UnityEngine;

public class NGUISprite_Additive : NGUISprite_Base
{
	public float _Alpha;

	protected override Material getNewMaterial()
	{
		return null;
	}

	protected override void UpdateMaterial()
	{
	}
}
