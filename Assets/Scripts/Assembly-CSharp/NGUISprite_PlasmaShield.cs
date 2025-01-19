using UnityEngine;

public class NGUISprite_PlasmaShield : NGUISprite_Base
{
	public float _Alpha;

	public float _Size;

	public float _Offset;

	public Color _Color;

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
