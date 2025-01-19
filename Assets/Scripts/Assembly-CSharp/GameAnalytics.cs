using System.Collections.Generic;

public class GameAnalytics
{
	public enum GA_TYPE
	{
		CN_Adjust = 0,
		JP_Adjust = 1,
		TW_KOCHAVA = 2
	}

	public static Dictionary<GA_TYPE, GameAnalytics> instances;

	public static GameAnalytics GetInstance(GA_TYPE type)
	{
		return null;
	}

	public virtual void Init()
	{
	}

	public virtual void TriggerEvent(string etype)
	{
	}

	public virtual void TriggerEvent(string etype, string[] param)
	{
	}

	public virtual void TriggerEventPay(int amount)
	{
	}

	public virtual void TriggerEventLogin()
	{
	}

	public virtual void TriggerEventRoleLogin()
	{
	}

	public virtual void TriggerEventLevelUp(int level = 1)
	{
	}

	public virtual void TriggerEventGuide(int progress = -1)
	{
	}

	public virtual void TriggerEventUserRegist()
	{
	}
}
