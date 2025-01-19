using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;

public class Ling00TagParser
{
	private static XmlDocument _doc;

	private static Dictionary<string, List<XmlNode>> _docNodeHash;

	private static string xmlDataPath;

	public static XmlDocument doc
	{
		get
		{
			return null;
		}
	}

	[DebuggerHidden]
	public static IEnumerator LoadDataXML()
	{
		return null;
	}

	public static XmlNode GetSkillNode(string sTemplateID)
	{
		return null;
	}

	public static SkillFuncPhase ParseFuncPhase(XmlElement node)
	{
		return null;
	}

	public static Phase CreatePhaseByNode(XmlElement node, NameSpace field)
	{
		return null;
	}
}
