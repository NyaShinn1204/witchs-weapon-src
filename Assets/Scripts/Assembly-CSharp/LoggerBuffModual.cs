public class LoggerBuffModual : LoggerModual
{
	public const string NAME = " BUFF";

	public const string FUNC_NAME_BUFF_ON_START = "[Buff:OnStart]";

	public const string FUNC_NAME_BUFF_ON_TRIGGER = "[Buff:OnTrigger]";

	public const string FUNC_NAME_BUFF_ON_EVENT = "[Buff:OnEvent]";

	public const string FUNC_NAME_BUFF_ON_INTERUPT = "[Buff:OnInterupt]";

	public const string FUNC_NAME_BUFF_ON_END = "[Buff:OnEnd]";

	public LoggerBuffModual(string name, int outputType)
	{
	}

	public override string RunFunction(int loglevel, string funcName, object self, params object[] obj)
	{
		return null;
	}

	private string OnStartLog(object self, params object[] obj)
	{
		return null;
	}

	private string OnTriggerLog(object self, params object[] obj)
	{
		return null;
	}

	private string OnEventLog(object self, params object[] obj)
	{
		return null;
	}

	private string OnInteruptLog(object self, params object[] obj)
	{
		return null;
	}

	private string OnEndLog(object self, params object[] obj)
	{
		return null;
	}
}
