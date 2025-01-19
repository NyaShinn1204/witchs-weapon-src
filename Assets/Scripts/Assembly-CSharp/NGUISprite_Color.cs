using UnityEngine;

public class NGUISprite_Color : NGUISprite_Base
{
	public Color _Color;

	public float _Alpha;

	protected override Material getNewMaterial()
	{
		return null;
	}

	protected override void UpdateMaterial()
	{
	}
}
