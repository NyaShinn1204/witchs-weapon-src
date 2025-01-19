using System;

namespace LuaInterface
{
	public static class Debugger
	{
		public static bool useLog;

		public static string threadStack;

		public static ILogger logger;

		private static CString sb;

		static Debugger()
		{
		}

		private static string GetLogFormat(string str)
		{
			return null;
		}

		public static void Log(string str)
		{
		}

		public static void Log(object message)
		{
		}

		public static void Log(string str, object arg0)
		{
		}

		public static void Log(string str, object arg0, object arg1)
		{
		}

		public static void Log(string str, object arg0, object arg1, object arg2)
		{
		}

		public static void Log(string str, params object[] param)
		{
		}

		public static void LogWarning(string str)
		{
		}

		public static void LogWarning(object message)
		{
		}

		public static void LogWarning(string str, object arg0)
		{
		}

		public static void LogWarning(string str, object arg0, object arg1)
		{
		}

		public static void LogWarning(string str, object arg0, object arg1, object arg2)
		{
		}

		public static void LogWarning(string str, params object[] param)
		{
		}

		public static void LogError(string str)
		{
		}

		public static void LogError(object message)
		{
		}

		public static void LogError(string str, object arg0)
		{
		}

		public static void LogError(string str, object arg0, object arg1)
		{
		}

		public static void LogError(string str, object arg0, object arg1, object arg2)
		{
		}

		public static void LogError(string str, params object[] param)
		{
		}

		public static void LogException(Exception e)
		{
		}

		public static void LogException(string str, Exception e)
		{
		}
	}
}
