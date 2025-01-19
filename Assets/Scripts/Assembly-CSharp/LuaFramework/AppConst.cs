namespace LuaFramework
{
	public class AppConst
	{
		public const bool DebugMode = false;

		public const bool UpdateMode = false;

		public const bool LuaByteMode = false;

		public const bool LuaBundleMode = true;

		public const int TimerInterval = 1;

		public const int GameFrameRate = 30;

		public const string AppName = "LuaFramework";

		public const string LuaTempDir = "/Temp/Lua/";

		public const string ExtName = ".ab";

		public const string AppPrefix = "LuaFramework_";

		public const string WebUrl = "http://localhost:6688/";

		public static string UserId;

		public static int SocketPort;

		public static string SocketAddress;

		public static string FrameworkRoot
		{
			get
			{
				return null;
			}
		}
	}
}
