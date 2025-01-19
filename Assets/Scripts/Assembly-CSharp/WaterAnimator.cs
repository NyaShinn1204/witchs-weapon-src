using UnityEngine;

[ExecuteInEditMode]
public class WaterAnimator : ShaderAnimator
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

	public bool UseSharedMaterial;

	private Material mat;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Init()
	{
	}
}
