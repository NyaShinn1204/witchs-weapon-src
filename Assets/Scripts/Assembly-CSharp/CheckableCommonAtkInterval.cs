using System.Collections.Generic;

public class CheckableCommonAtkInterval : ICheckable
{
	private List<float> damageTimes;

	private List<long> weaponIDs;

	private long[] exceptIDs;

	public void CollectCommonDamageTime(long weaponID, float commonATKTime)
	{
	}

	public double Check()
	{
		return 0.0;
	}

	private float GetCompareValue(long weaponid, float deltaTime)
	{
		return 0f;
	}

	public void SetExpectIDs(long id1, long id2)
	{
	}

	public void Reset()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
