using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Facebook.Unity.Settings
{
	public class FacebookSettings : ScriptableObject
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void OnChangeCallback();

		[Serializable]
		public class UrlSchemes
		{
			[SerializeField]
			private List<string> list;

			public List<string> Schemes
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public UrlSchemes(List<string> schemes = null)
			{
			}
		}

		public const string FacebookSettingsAssetName = "FacebookSettings";

		public const string FacebookSettingsPath = "FacebookSDK/SDK/Resources";

		public const string FacebookSettingsAssetExtension = ".asset";

		private static List<OnChangeCallback> onChangeCallbacks;

		private static FacebookSettings instance;

		[SerializeField]
		private int selectedAppIndex;

		[SerializeField]
		private List<string> clientTokens;

		[SerializeField]
		private List<string> appIds;

		[SerializeField]
		private List<string> appLabels;

		[SerializeField]
		private bool cookie;

		[SerializeField]
		private bool logging;

		[SerializeField]
		private bool status;

		[SerializeField]
		private bool xfbml;

		[SerializeField]
		private bool frictionlessRequests;

		[SerializeField]
		private string iosURLSuffix;

		[SerializeField]
		private List<UrlSchemes> appLinkSchemes;

		[SerializeField]
		private string uploadAccessToken;

		[SerializeField]
		private bool autoLogAppEventsEnabled;

		[SerializeField]
		private bool advertiserIDCollectionEnabled;

		public static int SelectedAppIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static List<string> AppIds
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static List<string> AppLabels
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static List<string> ClientTokens
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string AppId
		{
			get
			{
				return null;
			}
		}

		public static string ClientToken
		{
			get
			{
				return null;
			}
		}

		public static bool IsValidAppId
		{
			get
			{
				return false;
			}
		}

		public static bool Cookie
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool Logging
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool Status
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool Xfbml
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static string IosURLSuffix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string ChannelUrl
		{
			get
			{
				return null;
			}
		}

		public static bool FrictionlessRequests
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static List<UrlSchemes> AppLinkSchemes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string UploadAccessToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool AutoLogAppEventsEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool AdvertiserIDCollectionEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static FacebookSettings Instance
		{
			get
			{
				return null;
			}
		}

		public static FacebookSettings NullableInstance
		{
			get
			{
				return null;
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
