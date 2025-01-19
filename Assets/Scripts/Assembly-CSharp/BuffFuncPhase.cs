public class BuffFuncPhase : BuffPhase, IFunctionPhase
{
	public const string POINT_TYPE_ADD = "OnAddPoint";

	public const string POINT_TYPE_TRIGGER = "OnTickPoint";

	public const string POINT_TYPE_INTERUPT = "OnInterruptPoint";

	public const string POINT_TYPE_EVENT = "OnEventPoint";

	public const string POINT_TYPE_END = "OnEndPoint";

	public static string ATTR_POINT_TYPE;

	public static string ATTR_EVENT_TYPE;

	public static string ATTR_EVENT_ARG1;

	public static string ATTR_EVENT_ARG2;

	public static string ATTR_EVENT_ARG3;

	public string pointType;

	public EventCondition GetCondition()
	{
		return null;
	}

	public FunctionNamespace GetFuncNamespace()
	{
		return null;
	}
}
