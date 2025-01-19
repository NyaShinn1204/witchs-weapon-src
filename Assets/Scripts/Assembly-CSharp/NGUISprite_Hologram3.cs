using UnityEngine;

public class NGUISprite_Hologram3 : NGUISprite_Base
{
	public float _Alpha;

	public float Red;

	public float Green;

	public float Blue;

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
