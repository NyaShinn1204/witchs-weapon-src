using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Facebook.Unity.Mobile;
using UnityEngine;

namespace Facebook.Unity
{
	public sealed class FB : ScriptableObject
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		private delegate void OnDLLLoaded();

		public sealed class Canvas
		{
			private static IPayFacebook FacebookPayImpl
			{
				get
				{
					return null;
				}
			}

			public static void Pay(string product, string action = "purchaseitem", int quantity = 1, int? quantityMin = null, int? quantityMax = null, string requestId = null, string pricepointId = null, string testCurrency = null, FacebookDelegate<IPayResult> callback = null)
			{
			}
		}

		public sealed class Mobile
		{
			public static ShareDialogMode ShareDialogMode
			{
				set
				{
				}
			}

			private static IMobileFacebook MobileFacebookImpl
			{
				get
				{
					return null;
				}
			}

			public static void AppInvite(Uri appLinkUrl, Uri previewImageUrl = null, FacebookDelegate<IAppInviteResult> callback = null)
			{
			}

			public static void FetchDeferredAppLinkData(FacebookDelegate<IAppLinkResult> callback = null)
			{
			}

			public static void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback = null)
			{
			}

			public static bool IsImplicitPurchaseLoggingEnabled()
			{
				return false;
			}
		}

		internal abstract class CompiledFacebookLoader : MonoBehaviour
		{
			protected abstract FacebookGameObject FBGameObject { get; }

			public void Start()
			{
			}
		}

		private const string DefaultJSSDKLocale = "en_US";

		private static IFacebook facebook;

		private static bool isInitCalled;

		private static string facebookDomain;

		private static string graphApiVersion;

		public static string AppId { get; private set; }

		public static string ClientToken { get; private set; }

		public static string GraphApiVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool IsLoggedIn
		{
			get
			{
				return false;
			}
		}

		public static bool IsInitialized
		{
			get
			{
				return false;
			}
		}

		public static bool LimitAppEventUsage
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal static IFacebook FacebookImpl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal static string FacebookDomain
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private static OnDLLLoaded OnDLLLoadedDelegate { get; set; }

		public static void Init(InitDelegate onInitComplete = null, HideUnityDelegate onHideUnity = null, string authResponse = null)
		{
		}

		public static void Init(string appId, string clientToken = null, bool cookie = true, bool logging = true, bool status = true, bool xfbml = false, bool frictionlessRequests = true, string authResponse = null, string javascriptSDKLocale = "en_US", HideUnityDelegate onHideUnity = null, InitDelegate onInitComplete = null)
		{
		}

		public static void LogInWithPublishPermissions(IEnumerable<string> permissions = null, FacebookDelegate<ILoginResult> callback = null)
		{
		}

		public static void LogInWithReadPermissions(IEnumerable<string> permissions = null, FacebookDelegate<ILoginResult> callback = null)
		{
		}

		public static void LogOut()
		{
		}

		public static void AppRequest(string message, OGActionType actionType, string objectId, IEnumerable<string> to, string data = "", string title = "", FacebookDelegate<IAppRequestResult> callback = null)
		{
		}

		public static void AppRequest(string message, OGActionType actionType, string objectId, IEnumerable<object> filters = null, IEnumerable<string> excludeIds = null, int? maxRecipients = null, string data = "", string title = "", FacebookDelegate<IAppRequestResult> callback = null)
		{
		}

		public static void AppRequest(string message, IEnumerable<string> to = null, IEnumerable<object> filters = null, IEnumerable<string> excludeIds = null, int? maxRecipients = null, string data = "", string title = "", FacebookDelegate<IAppRequestResult> callback = null)
		{
		}

		public static void ShareLink(Uri contentURL = null, string contentTitle = "", string contentDescription = "", Uri photoURL = null, FacebookDelegate<IShareResult> callback = null)
		{
		}

		public static void FeedShare(string toId = "", Uri link = null, string linkName = "", string linkCaption = "", string linkDescription = "", Uri picture = null, string mediaSource = "", FacebookDelegate<IShareResult> callback = null)
		{
		}

		public static void API(string query, HttpMethod method, FacebookDelegate<IGraphResult> callback = null, IDictionary<string, string> formData = null)
		{
		}

		public static void API(string query, HttpMethod method, FacebookDelegate<IGraphResult> callback, WWWForm formData)
		{
		}

		public static void ActivateApp()
		{
		}

		public static void GetAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		public static void LogAppEvent(string logEvent, float? valueToSum = null, Dictionary<string, object> parameters = null)
		{
		}

		public static void LogPurchase(float logPurchase, string currency = null, Dictionary<string, object> parameters = null)
		{
		}

		private static void LogVersion()
		{
		}
	}
}
