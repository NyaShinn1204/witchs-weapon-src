public class LoggerPackModual : LoggerModual
{
	public const string NAME = "PACK";

	public const string FUNC_NAME_PACK_DAMAGE_START = "[Pack:Damage_Start]";

	public const string FUNC_NAME_PACK_DAMAGE_END = "[Pack:Damage_End]";

	public const string FUNC_NAME_PACK_HEAL_START = "[Pack:Heal_Start]";

	public const string FUNC_NAME_PACK_HEAL_END = "[Pack:Heal_End]";

	public const string FUNC_NAME_PACK_BUFF_START = "[Pack:Buff_Start]";

	public const string FUNC_NAME_PACK_BUFF_END = "[Pack:Buff_End]";

	public const string FUNC_NAME_PACK_DISPEL_START = "[Pack:Despiel_Start]";

	public const string FUNC_NAME_PACK_DISPEL_END = "[Pack:Despile_End]";

	public const string FUNC_NAME_PACK_SHIFT_START = "[Pack:Shift_Start]";

	public const string FUNC_NAME_PACK_SHIFT_END = "[Pack:Shift_End]";

	public LoggerPackModual(string name, int outputType)
	{
	}

	public override string RunFunction(int loglevel, string funcName, object self, params object[] obj)
	{
		return null;
	}

	private string CreateBuffPack(object self, params object[] obj)
	{
		return null;
	}

	private string DamageEnd(object self, params object[] obj)
	{
		return null;
	}
}
