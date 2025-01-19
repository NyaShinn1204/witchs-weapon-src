using System.Collections.Generic;

public class HitRandom
{
	private float initRate;

	private float increaseRate;

	private int hitCountMax;

	private int curCount;

	private float curRate;

	private float Rnd;

	public static Dictionary<string, RandomRow> table;

	public HitRandom(int rate, int hitCountMax)
	{
	}

	private static void InitRandomTable()
	{
	}

	public bool IsHit(long randomID)
	{
		return false;
	}

	public static void GenTableRow(int rate, int times, float rate_init, float rate_increase)
	{
	}

	private float GetInitRate(int rate, int times)
	{
		return 0f;
	}

	private float GetIncreaseRate(int rate, int times)
	{
		return 0f;
	}
}
