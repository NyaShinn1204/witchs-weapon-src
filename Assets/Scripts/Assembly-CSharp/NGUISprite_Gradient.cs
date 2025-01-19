using UnityEngine;

public class NGUISprite_Gradient : NGUISprite_Base
{
	public Color _Color;

	public Color _Color2;

	public float _Alpha;

	protected override Material getNewMaterial()
	{
		return null;
	}

	protected override void UpdateMaterial()
	{
	}
}
