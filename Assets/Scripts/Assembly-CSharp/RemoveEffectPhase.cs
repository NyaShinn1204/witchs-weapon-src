using System.Collections.Generic;
using System.Xml;

public class RemoveEffectPhase : SkillPhase
{
	private int targetType;

	private string effectName;

	public RemoveEffectPhase(NameSpace field)
	{
	}

	public override void OnInit(XmlElement node)
	{
	}

	public override void invoke(NameSpace field)
	{
	}

	private void RemoveEffect(List<Entity> list, string name)
	{
	}
}
