using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace TwitterKit.Unity.Settings
{
	public class TwitterSettings : ScriptableObject
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void OnChangeCallback();

		public const string TWITTER_KIT_SETTINGS_ASSET_NAME = "TwitterKitSettings";

		public const string TWITTER_KIT_SETTINGS_PATH = "Twitter/Resources";

		public const string API_KEY_NOT_SET = "Your Twitter App API Key has not been set. To Set: In the main Unity editor navigate to 'Twitter Kit -> Settings' (make sure the Inspector tab is open).";

		public const string API_SECRET_NOT_SET = "Your Twitter App API Secret has not been set. To Set: In the main Unity editor navigate to 'Twitter Kit -> Settings' (make sure the Inspector tab is open).";

		private const string SET_SETTINGS_INFO = "To Set: In the main Unity editor navigate to 'Twitter Kit -> Settings' (make sure the Inspector tab is open).";

		private static TwitterSettings instance;

		private static List<OnChangeCallback> onChangeCallbacks;

		[SerializeField]
		private string consumerKey;

		[SerializeField]
		private string consumerSecret;

		public static TwitterSettings Instance
		{
			get
			{
				return null;
			}
		}

		public static TwitterSettings NullableInstance
		{
			get
			{
				return null;
			}
		}

		public static string ConsumerKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string ConsumerSecret
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static void RegisterChangeEventCallback(OnChangeCallback callback)
		{
		}

		public static void UnregisterChangeEventCallback(OnChangeCallback callback)
		{
		}

		private static void SettingsChanged()
		{
		}
	}
}
