using System.Collections.Generic;

public class CheckableActiveSkillInterval : ICheckable
{
	private float limitInterval;

	private Dictionary<long, List<float>> dic;

	public void AppendCastingTime(long skillID, float time)
	{
	}

	public double Check()
	{
		return 0.0;
	}

	public void Reset()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
