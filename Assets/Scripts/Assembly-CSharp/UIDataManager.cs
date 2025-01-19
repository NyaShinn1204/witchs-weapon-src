using System.Collections;
using System.Collections.Generic;

public class UIDataManager
{
	private static UIDataManager instance;

	private ArrayList chapters;

	private Dictionary<string, StarDetailData> starDetails;

	private Dictionary<string, LootData> loots;

	private Dictionary<string, ArrayList> lvLoots;

	private Dictionary<string, LevelData> LevelDatas;

	public static UIDataManager GetInstance()
	{
		return null;
	}

	public ArrayList GetChapters()
	{
		return null;
	}

	public int GetChapterTotal()
	{
		return 0;
	}

	private void InitUIData()
	{
	}

	private void InitInstanceData()
	{
	}

	public LevelData GetLevelData(string lvID)
	{
		return null;
	}

	public StarDetailData GetStarDetailData(string StarDetailID)
	{
		return null;
	}

	public ArrayList GetLvLootGroup(string lvID)
	{
		return null;
	}

	public LootData GetLoot(string id)
	{
		return null;
	}

	public string GetLootImgAddress(string id)
	{
		return null;
	}
}
