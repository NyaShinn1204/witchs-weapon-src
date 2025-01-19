public class LoggerTriggerModual : LoggerModual
{
	public const string NAME = " TRIGGER";

	public const string FUNC_NAME_TRIGGER_ACTIVE = "[Trigger:Active]";

	public const string FUNC_NAME_TRIGGER_DEACTIVE = "[Trigger:Deactive]";

	public const string FUNC_NAME_TRIGGER_TRIGGER = "[Trigger:Trigger]";

	public const string FUNC_NAME_TRIGGER_EVENT = "[Trigger:EventTrigger]";

	public const string FUNC_NAME_TRIGGER_CONST = "[Trigger:ConstTrigger]";

	public const string FUNC_NAME_TRIGGER_TIME = "[Trigger:TimeTrigger]";

	public const string FUNC_NAME_TRIGGER_TRIGGER_NO_TRIGGER = "[Trigger:rate_trigger_fail]";

	public const string FUNC_NAME_TRIGGER_TRIGGER_FAIL = "[Trigger:trigger_fail]";

	public const string FUNC_NAME_TRIGGER_TRIGGER_REMOVE = "[Trigger:trigger_complete]";

	public const string FUNC_NAME_TRIGGER_TIME_START = "[Trigger:time_trigger_start]";

	public const string FUNC_NAME_TRIGGER_TIME_PAUSE = "[Trigger:time_trigger_pause]";

	public const string FUNC_NAME_TRIGGER_TIME_STOP = "[Trigger:time_trigger_stop]";

	public LoggerTriggerModual(string name, int outputType)
	{
	}

	public override string RunFunction(int loglevel, string funcName, object self, params object[] obj)
	{
		return null;
	}

	private string NoTrigger(params object[] obj)
	{
		return null;
	}

	private string TriggerFail(params object[] obj)
	{
		return null;
	}

	private string TriggerComplete(params object[] obj)
	{
		return null;
	}

	private string ToPassiveContent(params object[] obj)
	{
		return null;
	}

	private string ToEventContent(params object[] obj)
	{
		return null;
	}

	private string ToConstContent(params object[] obj)
	{
		return null;
	}

	private string ToTimeContent(params object[] obj)
	{
		return null;
	}
}
