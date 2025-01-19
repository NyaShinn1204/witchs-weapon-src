using System.Collections.Generic;
using System.Xml;

public class ConditionPhase : SkillComposePhase
{
	public List<Condition> conditionList;

	private string type;

	private float value1;

	private float value2;

	public ConditionPhase()
	{
	}

	public ConditionPhase(NameSpace field)
	{
	}

	public ConditionPhase(string name, Dictionary<string, string> paramList, List<Condition> conditionList)
	{
	}

	public override void OnInit(XmlElement node)
	{
	}

	public bool CheckCondition()
	{
		return false;
	}

	public override void invoke(NameSpace field)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
