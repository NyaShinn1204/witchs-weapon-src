using UnityEngine;

public class NGUISprite_Circle_Fade : NGUISprite_Base
{
	public float _Alpha;

	public float _Offset;

	public int _InOut;

	protected override Material getNewMaterial()
	{
		return null;
	}

	protected override void UpdateMaterial()
	{
	}
}
