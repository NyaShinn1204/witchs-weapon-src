public class LoggerNumericModual : LoggerModual
{
	public const string NAME = "NUMERIC";

	public const string FUNC_NAME_NUMERIC_DAMAGE = "[Numeric:Damage]";

	public const string FUNC_NAME_NUMERIC_DAMAGE_PARAM = "[Numeric:DamageParam]";

	public const string FUNC_NAME_NUMERIC_HEAL = "[Numeric:Heal]";

	public LoggerNumericModual(string name, int outputType)
	{
	}

	public override string RunFunction(int loglevel, string funcName, object self, params object[] obj)
	{
		return null;
	}

	private string LogDamageContent(params object[] obj)
	{
		return null;
	}

	private string LogDamageContentParam(params object[] obj)
	{
		return null;
	}

	private string logHealContent(params object[] obj)
	{
		return null;
	}
}
