using UnityEngine;

public class NGUISprite_Pixel : NGUISprite_Base
{
	public float _Alpha;

	public float _Offset;

	protected override Material getNewMaterial()
	{
		return null;
	}

	protected override void UpdateMaterial()
	{
	}
}
