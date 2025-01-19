using System.Xml;

public class AdjustProcessPhase : SkillPhase
{
	public const int ADJUST_TYPE_INTERUUPT = 1;

	public const int ADJUST_TYPE_RETURN = 2;

	public const int ADJUST_TYPE_GOTO = 3;

	public const int ADJUST_TYPE_INVOKE = 4;

	public const int POINT_TYPE_START = 1;

	public const int POINT_TYPE_RELEASE = 2;

	public const int POINT_TYPE_END = 3;

	public AdjustProcessPhase(NameSpace field)
	{
	}

	public override void OnInit(XmlElement node)
	{
	}

	public override void invoke(NameSpace field)
	{
	}

	private void RunTargetPoint(int pointType)
	{
	}
}
