using System.Collections;

public class UserLevelData
{
	public static int refreshTotal;

	public string levelID { get; set; }

	public int todayChallengeTime { get; set; }

	public int todayRefreshTime { get; set; }

	public ArrayList getStars { get; set; }

	public UserLevelData()
	{
	}

	public UserLevelData(string levelID, int todayChallengeTime, int todayRefreshTime, ArrayList getStars)
	{
	}
}
