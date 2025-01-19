using System.Collections.Generic;

public class BattleData
{
	public float HeroDamage;

	public float HeroPassiveDamage;

	public float HereHealth;

	public List<string> EnitmyID;

	public List<string> DefendID;

	private static BattleData instance;

	public Dictionary<string, int> entityIDs;

	public Dictionary<string, int> defendIDs;

	public static BattleData Instance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Dictionary<string, string> CombinDic(Dictionary<string, string> param)
	{
		return null;
	}

	public void Reset()
	{
	}

	public void Stat(Dictionary<string, int> dic, string key)
	{
	}

	private string dicToString(Dictionary<string, int> dic)
	{
		return null;
	}
}
