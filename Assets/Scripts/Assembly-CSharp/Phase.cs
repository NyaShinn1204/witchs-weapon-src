using System.Collections.Generic;
using System.Xml;

public class Phase
{
	public string phaseName;

	public Dictionary<string, string> paramList;

	public NameSpace classNamespace;

	public IFunctionPhase rootFunction;

	public Phase()
	{
	}

	public Phase(string name, Dictionary<string, string> paramList = null)
	{
	}

	public virtual void OnInit(XmlElement node)
	{
	}

	public void AddParam(XmlElement ele, string name)
	{
	}

	public string GetParam(string key)
	{
		return null;
	}

	public string GetVariableParam(string key)
	{
		return null;
	}

	public string GetStringParam(string key)
	{
		return null;
	}

	public int GetIntParam(string key)
	{
		return 0;
	}

	public object GetObjectParam(string key)
	{
		return null;
	}

	public long GetLongParam(string key)
	{
		return 0L;
	}

	public float GetFloatParam(string key)
	{
		return 0f;
	}

	public virtual void invoke(NameSpace field)
	{
	}
}
