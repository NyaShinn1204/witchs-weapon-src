public class UserUIDataManager
{
	private static UserUIDataManager instance;

	private UserData userData;

	public int currentChapter;

	public int currentLevel;

	public static UserUIDataManager GetInstance()
	{
		return null;
	}

	public bool IsUnlock(string lvID)
	{
		return false;
	}

	public int GetCurrentMaxLevel()
	{
		return 0;
	}

	public UserLevelData GetUsetLevelData(string levelID)
	{
		return null;
	}

	private void InitInstanceData()
	{
	}

	private void InitData()
	{
	}

	public int ImportJson(string levelJsonFilePath)
	{
		return 0;
	}

	public void Save()
	{
	}

	public void SetMaxLevel(int lv)
	{
	}
}
