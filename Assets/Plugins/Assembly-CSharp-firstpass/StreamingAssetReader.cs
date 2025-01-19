using System.IO;

public class StreamingAssetReader
{
	private enum deviceType
	{
		iphone = 0,
		android = 1,
		windows = 2
	}

	private static StreamingAssetReader _instance;

	public static readonly string LevelFilePath;

	public static readonly string LevelCfgFilePath;

	public static readonly string CSLEScriptPath;

	public static readonly string CSLEScriptRelativePath;

	private deviceType dType;

	public static StreamingAssetReader getInstance()
	{
		return null;
	}

	public void init()
	{
	}

	public string GetLevelFileAsStringBySAPath(string levelFileName)
	{
		return null;
	}

	public string GetLessonFileAsStringBySAPath(string lessonFileName)
	{
		return null;
	}

	public string GetTestFileAsStringBySAPath(string jsonFile)
	{
		return null;
	}

	public string LoadFileBySAPath(string relativeFilePath, string baseFolder = "")
	{
		return null;
	}

	public void WritePerfile(string sPathSteamingUnfull, string sPathPerfile, bool sIsOverwrite = false, string baseFolder = "")
	{
	}

	public StreamReader LoadXML(string xmlFullPath)
	{
		return null;
	}

	public string[] LoadCSVLines(string csvFileFullPath)
	{
		return null;
	}

	public string LoadFileByFullPath(string fullFilePath)
	{
		return null;
	}
}
