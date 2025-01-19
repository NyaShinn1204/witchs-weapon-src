using UnityEngine;

public class NGUISprite_Hologram : NGUISprite_Base
{
	public float _Alpha;

	public float Distortion;

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
