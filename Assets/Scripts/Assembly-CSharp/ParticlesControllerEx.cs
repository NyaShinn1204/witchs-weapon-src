using UnityEngine;

public class ParticlesControllerEx : MonoBehaviour
{
	public Color color;

	public Vector3 segmentDir;

	public float StartAngle;

	private ParticleSystem.Particle[] particles;

	private ParticleSystem mPrSystem;

	private int mCurrCount;

	private static int MaxValueToHide;

	private void Awake()
	{
	}

	public ParticleSystem GetPS()
	{
		return null;
	}

	private void LateUpdate()
	{
	}

	public void UpdateSegments()
	{
	}

	public bool IsReadyToUse()
	{
		return false;
	}

	public void SetVertexCount(int aCount)
	{
	}

	public void SetPosition(int aIndex, Vector3 aPosition)
	{
	}

	public void SetRotation(int aIndex, float Rotation)
	{
	}

	public void SetStartLifeTime(int aIndex, float lifeTime)
	{
	}

	public void SetLifeTime(int aIndex, float lifeTime)
	{
	}

	public void SetStartColor(int aIndex, Color aColor)
	{
	}

	public void SetStartScale(int aIndex, float scale)
	{
	}

	public ParticleSystem.Particle getParticle(int aIndex)
	{
		return default(ParticleSystem.Particle);
	}
}
