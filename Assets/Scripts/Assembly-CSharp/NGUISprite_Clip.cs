using UnityEngine;

public class NGUISprite_Clip : NGUISprite_Base
{
	public float _Alpha;

	public float _ClipLeft;

	public float _ClipRight;

	public float _ClipUp;

	public float _ClipDown;

	protected override Material getNewMaterial()
	{
		return null;
	}

	protected override void UpdateMaterial()
	{
	}
}
