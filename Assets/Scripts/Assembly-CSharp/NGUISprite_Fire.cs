using UnityEngine;

public class NGUISprite_Fire : NGUISprite_Base
{
	public float _Alpha;

	public float _Offset;

	public float _Distance;

	public float OffSet_WaveTime;

	public float _WaveTime;

	public bool AutoPlayWave;

	public float AutoPlaySpeed;

	protected override Material getNewMaterial()
	{
		return null;
	}

	protected override void UpdateMaterial()
	{
	}
}
