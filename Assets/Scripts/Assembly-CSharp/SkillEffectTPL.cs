using System.Collections.Generic;
using System.Xml;

public class SkillEffectTPL
{
	public const string GROUP_NAME = "GROUP_NAME_";

	public string pointType;

	public bool hasPerformance;

	public bool hasPerformance2;

	public Dictionary<string, SkillFuncPhase> normalPointDic;

	public Dictionary<string, SkillFuncPhase> effectPointGroupDic;

	public Dictionary<string, SkillFuncPhase> performancePointGroupDic;

	public Dictionary<string, SkillFuncPhase> performancePointGroupDic2;

	private NameSpace fileds;

	private SkillProperty property;

	public void Initialize(SkillProperty property)
	{
	}

	private void ParseNodeToFunction(XmlElement node)
	{
	}

	private string GenGroupName(SkillFuncPhase funcPhase, int count)
	{
		return null;
	}

	public static void ParseNodeToPhase(XmlElement node, Phase phase, NameSpace filed, IFunctionPhase funcPhase)
	{
	}

	public void InvokeFunction(string name, Skill skill, string groupName = null)
	{
	}

	private void InvokePhase(SkillFuncPhase function, Skill skill)
	{
	}
}
