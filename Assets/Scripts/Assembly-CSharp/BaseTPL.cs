using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class BaseTPL
{
	public static int ParseInt(XmlElement node, string propName)
	{
		return 0;
	}

	public static float ParseFloat(XmlElement node, string propName)
	{
		return 0f;
	}

	public static MetaValue ParseMetaValue(XmlElement node, string propName)
	{
		return default(MetaValue);
	}

	public static bool ParseBool(XmlElement node, string propName)
	{
		return false;
	}

	public static Vector3 ParseVector(XmlElement node, string propName)
	{
		return default(Vector3);
	}

	public static List<float> ParseArray(XmlElement node, string propName)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public static bool GetFuncValue(string content, out float value)
	{
		value = default(float);
		return false;
	}
}
