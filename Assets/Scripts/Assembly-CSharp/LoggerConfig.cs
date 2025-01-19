using System.Collections.Generic;

public class LoggerConfig
{
	public const int OUTPUT_TYPE_CONSOLE = 1;

	public const int OUTPUT_TYPE_FILE = 2;

	public const int OUTPUT_TYPE_NETWORK = 3;

	private Dictionary<string, LoggerModual> modualDic;

	public string path;

	public string fileName;

	public int outputType;

	public bool isOverride;

	public bool enabled;

	private static LoggerConfig _instance;

	private void Init()
	{
	}

	public static LoggerConfig GetInstance()
	{
		return null;
	}

	public LoggerModual GetModual(string name)
	{
		return null;
	}

	public void AddModual(LoggerModual modual)
	{
	}
}
