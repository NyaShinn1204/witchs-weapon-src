using System;

[Serializable]
public class BarLevelInfoData
{
	public int level;

	public long max;

	public long lowLimitTotal;

	public long upperLimitTotal;

	public BarLevelInfoData(int level, long max)
	{
	}
}
