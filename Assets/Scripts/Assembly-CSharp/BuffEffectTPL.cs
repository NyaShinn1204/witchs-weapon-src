using System.Collections.Generic;
using System.Xml;

public class BuffEffectTPL
{
	private NameSpace fileds;

	private Dictionary<string, BuffFuncPhase> phaseDic;

	private Dictionary<EventCondition, BuffFuncPhase> eventDic;

	public void Initialize(string templateID)
	{
	}

	private void ParseNodeToFunction(XmlElement node)
	{
	}

	public static void ParseNodeToPhase(XmlElement node, Phase phase, NameSpace filed, IFunctionPhase funcPhase)
	{
	}

	public void InvokeFunction(string name, BuffEntity buff, BaseEvent evt = null)
	{
	}
}
