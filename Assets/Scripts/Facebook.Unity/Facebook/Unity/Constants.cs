using System;

namespace Facebook.Unity
{
	internal static class Constants
	{
		private static FacebookUnityPlatform? currentPlatform;

		public static Uri GraphUrl
		{
			get
			{
				return null;
			}
		}

		public static string GraphApiUserAgent
		{
			get
			{
				return null;
			}
		}

		public static bool IsMobile
		{
			get
			{
				return false;
			}
		}

		public static bool IsEditor
		{
			get
			{
				return false;
			}
		}

		public static bool IsWeb
		{
			get
			{
				return false;
			}
		}

		public static bool IsGameroom
		{
			get
			{
				return false;
			}
		}

		public static string UnitySDKUserAgentSuffixLegacy
		{
			get
			{
				return null;
			}
		}

		public static string UnitySDKUserAgent
		{
			get
			{
				return null;
			}
		}

		public static bool DebugMode
		{
			get
			{
				return false;
			}
		}

		public static FacebookUnityPlatform CurrentPlatform
		{
			get
			{
				return default(FacebookUnityPlatform);
			}
		}

		private static FacebookUnityPlatform GetCurrentPlatform()
		{
			return default(FacebookUnityPlatform);
		}
	}
}
