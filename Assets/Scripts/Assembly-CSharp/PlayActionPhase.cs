using System.Xml;

public class PlayActionPhase : SkillPhase
{
	public const int TARGET_TYPE_RELEASER = 1;

	public const int TARGET_TYPE_RELEASE_TARGET = 2;

	public const int TARGET_TYPE_EFFECT_TARGET = 3;

	public const int TARGET_TYPE_SUMMON = 4;

	public const int TARGET_TYPE_CURRENT = 5;

	public const int TARGET_TYPE_TARGET_COLLECTION = 99;

	private int targetType;

	private string actionName;

	public PlayActionPhase(NameSpace field)
	{
	}

	public override void OnInit(XmlElement node)
	{
	}

	public override void invoke(NameSpace field)
	{
	}

	private void PlayAnimation(Entity entity, string action)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
