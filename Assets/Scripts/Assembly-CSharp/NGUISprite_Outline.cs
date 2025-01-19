using UnityEngine;

public class NGUISprite_Outline : NGUISprite_Base
{
	public Color _Color;

	public float _OutLineSpread;

	protected override Material getNewMaterial()
	{
		return null;
	}

	protected override void UpdateMaterial()
	{
	}
}
