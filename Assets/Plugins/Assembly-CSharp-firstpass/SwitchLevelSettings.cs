using System;

public class SwitchLevelSettings<T> : ISwitchLevelSettings where T : SceneManager
{
	public string[] Levels { get; set; }

	public Action<LevelLoadProgress> ProgressUpdated { get; set; }

	public Action<T> Setup { get; set; }

	public Type StartManagerType
	{
		get
		{
			return null;
		}
	}

	public SwitchLevelSettings()
	{
	}

	public SwitchLevelSettings(Action<T> setup)
	{
	}

	public SwitchLevelSettings(string[] levels, Action<T> setup)
	{
	}

	public SwitchLevelSettings(Action<LevelLoadProgress> progressUpdated, string[] levels, Action<T> setup)
	{
	}

	public SwitchLevelSettings(Action<LevelLoadProgress> progressUpdated, string[] levels)
	{
	}

	public SwitchLevelSettings(Action<LevelLoadProgress> progressUpdated)
	{
	}

	public void InvokeControllerSetup(SceneManager sceneManager)
	{
	}
}
