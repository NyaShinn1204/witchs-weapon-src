using WaterBell.ProjX.Data.Entity;

public static class ProgressController
{
	public static int IsLevelUnlock(long levelID)
	{
		return 0;
	}

	public static int IsChapterUnlock(long chapterID)
	{
		return 0;
	}

	public static int CanSweep(long levelID)
	{
		return 0;
	}

	public static int CanChapterBattle(long chapterID)
	{
		return 0;
	}

	private static Progress.SingleProgress GetProgressByChapterID(long chapterID)
	{
		return null;
	}

	private static Progress.SingleProgress.Level GetLevel(long levelID)
	{
		return null;
	}

	private static TypeCsvInstance GetInstanceTableData(long levelID)
	{
		return null;
	}

	private static TypeCsvInstanceSet GetInstanceSetTableData(long chapterID)
	{
		return null;
	}
}
