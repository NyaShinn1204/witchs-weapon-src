using System.Collections;
using System.Collections.Generic;

public class UserData
{
	public Dictionary<string, UserLevelData> userLevelData { get; set; }

	public ArrayList unlocks { get; set; }

	public int currentMaxLevel { get; set; }
}
