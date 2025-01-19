using System.Xml;

public class CreateDamgePackPhase : SkillPhase
{
	public const int IS_COMMON_ATK = 8;

	private int damageTag;

	private int damageType;

	private float damageRate;

	private NumericParam param;

	public CreateDamgePackPhase(NameSpace field)
	{
	}

	public override void OnInit(XmlElement node)
	{
	}

	public override void invoke(NameSpace field)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
