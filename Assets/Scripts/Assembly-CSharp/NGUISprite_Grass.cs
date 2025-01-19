using UnityEngine;

public class NGUISprite_Grass : NGUISprite_Base
{
	public float _Alpha;

	public float _OffsetX;

	public float _OffsetY;

	public float _DistanceX;

	public float _DistanceY;

	public float _WaveTimeX;

	public float _WaveTimeY;

	public bool AutoPlayWaveX;

	public float AutoPlaySpeedX;

	public bool AutoPlayWaveY;

	public float AutoPlaySpeedY;

	protected override Material getNewMaterial()
	{
		return null;
	}

	protected override void UpdateMaterial()
	{
	}
}
