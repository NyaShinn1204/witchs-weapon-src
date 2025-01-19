public class SkillFuncPhase : SkillComposePhase, IFunctionPhase
{
	public static string ATTR_POINT_TYPE;

	public static string ATTR_DELAY;

	public static string ATTR_REPEAT_COUNT;

	public string pointType;

	public string groupName;

	public FunctionNamespace funcField;

	public FunctionNamespace GetFuncNamespace()
	{
		return null;
	}
}
