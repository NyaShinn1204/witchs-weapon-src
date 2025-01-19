public class Logger
{
	public static LoggerConfig config;

	private static void Trace(string content)
	{
	}

	private static void Trace(int loglevel, string loggerModual, object self, string funcName, params object[] param)
	{
	}

	public static void Debug(string content)
	{
	}

	public static void Debug(string loggerModual, object self, string funcName, params object[] param)
	{
	}

	public static void Info(string loggerModual, object self, string funcName, params object[] param)
	{
	}

	public static void Warn(string loggerModual, object self, string funcName, params object[] param)
	{
	}

	public static void Error(string loggerModual, object self, string funcName, params object[] param)
	{
	}

	public static void Fatal(string loggerModual, object self, string funcName, params object[] param)
	{
	}
}
