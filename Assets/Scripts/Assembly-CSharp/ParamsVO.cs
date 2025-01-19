using System;
using System.Collections.Generic;

[Serializable]
public class ParamsVO
{
	public string scriptName;

	public Dictionary<string, object> paramDic;

	public static ParamsVO CreateScriptEntity(string name, Dictionary<string, object> dic)
	{
		return null;
	}

	public ParamsVO Clone()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
