using System.Collections.Generic;

public class CLRFile
{
	public const int PLANTFORM_X86 = 1;

	public const int PLANTFORM_UNITY = 2;

	private static Dictionary<string, CLRFile> fileDic;

	public static PropertyFile ReadPropertyFile(string path, int plantform = 2)
	{
		return null;
	}

	public static XMLFile ReadXMLFile(string path, int plantform = 2)
	{
		return null;
	}

	private static void CreateDicIfNo()
	{
	}
}
