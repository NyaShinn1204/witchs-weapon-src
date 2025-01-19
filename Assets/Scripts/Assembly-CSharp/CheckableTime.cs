public class CheckableTime : ICheckable
{
	public float startTime;

	public float endTime;

	private float[] typeTimes;

	private int[] typeMonsterCount;

	public double Check()
	{
		return 0.0;
	}

	public void SetMonsterTypeCount(int commonCount, int eliteCount, int bossCount)
	{
	}

	public void SetMonsterTypeRate(float commonRate, float eliteRate, float bossRate)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
