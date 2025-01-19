using System.Xml;

public class ModifyMassPhase : SkillPhase
{
	public const int MASS_NORMAL = 1;

	public const int MASS_SKILL = 2;

	private int targetType;

	private int massType;

	public ModifyMassPhase(NameSpace field)
	{
	}

	public override void OnInit(XmlElement node)
	{
	}

	public override void invoke(NameSpace field)
	{
	}
}
