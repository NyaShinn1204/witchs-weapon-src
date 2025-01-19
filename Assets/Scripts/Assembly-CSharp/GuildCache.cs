public class GuildCache
{
	private float critValuePhsic;

	private float critValueMagic;

	private bool isCached;

	public void OpenNoCrit()
	{
	}

	public void CloseNoCrit()
	{
	}

	public void OpenReducePower(float rate, long servantID = 0L)
	{
	}

	public void CloseReducePower(long servantID = 0L)
	{
	}

	public void OpenReduceSharp(float rate, long servantID)
	{
	}

	public void CloseReduceSharp()
	{
	}

	public void ReachMaxSharp(long servantID)
	{
	}

	private BuildPowerAndSharp GetWrapper()
	{
		return null;
	}

	public void Clear()
	{
	}

	private void ResetCrit()
	{
	}

	private void ResetPower()
	{
	}

	private void ResetSharp()
	{
	}
}
