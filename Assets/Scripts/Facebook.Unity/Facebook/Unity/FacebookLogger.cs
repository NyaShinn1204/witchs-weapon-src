namespace Facebook.Unity
{
	internal static class FacebookLogger
	{
		private class DebugLogger : IFacebookLogger
		{
			public void Log(string msg)
			{
			}

			public void Info(string msg)
			{
			}

			public void Warn(string msg)
			{
			}
		}

		internal static IFacebookLogger Instance { private get; set; }

		static FacebookLogger()
		{
		}

		public static void Log(string msg)
		{
		}

		public static void Info(string msg)
		{
		}

		public static void Warn(string msg)
		{
		}

		public static void Warn(string format, params string[] args)
		{
		}
	}
}
