using UnityEngine;

public class ParticleSpark : ProgrameParticleBase
{
	public int step;

	private const int numNor = 15;

	private const int numMax = 40;

	public const float baseSize = 3f;

	private float size;

	protected const float resistance = 0.8f;

	protected static Vector3 aSpd;

	private float base_spd;

	private const float HEIGHT = 106f;

	private const float WIDTH = 13f;

	private float from;

	private float to;

	protected override void Awake()
	{
	}

	protected override void globalRefresh()
	{
	}

	protected override void refreshParticleAt(int i)
	{
	}

	protected override void reinitParticle(int index)
	{
	}

	public void boom(int max)
	{
	}

	public void boom()
	{
	}

	public void boom(float from, float to)
	{
	}

	protected override void sucide()
	{
	}
}
