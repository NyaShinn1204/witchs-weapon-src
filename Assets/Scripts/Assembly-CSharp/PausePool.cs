using System.Collections.Generic;

public class PausePool
{
	private static PauseType _pauseStatus;

	private static int _pauseSkillCount;

	public static Dictionary<IPausedComponent, PauseType> _pausedPool;

	public static PauseType pauseStatus
	{
		get
		{
			return default(PauseType);
		}
	}

	public static bool AllPaused
	{
		get
		{
			return false;
		}
	}

	public static bool DemiPaused
	{
		get
		{
			return false;
		}
	}

	public static bool SkillPaused
	{
		get
		{
			return false;
		}
	}

	public static void AddKey(IPausedComponent ip, PauseType pauseType)
	{
	}

	public static void PauseSkill()
	{
	}

	public static void PauseButton()
	{
	}

	public static void ResumeSkill()
	{
	}

	public static void ResumeButton()
	{
	}

	public static void removeKey(IPausedComponent ip)
	{
	}

	public static void Reset()
	{
	}

	public static void PauseBTTree()
	{
	}

	public static void ResumeBTTree()
	{
	}
}
