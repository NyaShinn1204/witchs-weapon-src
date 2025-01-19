using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Facebook.Unity.Mobile.Android
{
	internal sealed class AndroidFacebook : MobileFacebook
	{
		private class JavaMethodCall<T> : MethodCall<T> where T : IResult
		{
			private AndroidFacebook androidImpl;

			public JavaMethodCall(AndroidFacebook androidImpl, string methodName)
				: base((FacebookBase)null, (string)null)
			{
			}

			public override void Call(MethodArguments args = null)
			{
			}
		}

		private bool limitEventUsage;

		private IAndroidWrapper androidWrapper;

		[CompilerGenerated]
		private string _003CKeyHash_003Ek__BackingField;

		private string KeyHash
		{
			[CompilerGenerated]
			set
			{
				_003CKeyHash_003Ek__BackingField = value;
			}
		}

		public override bool LimitEventUsage
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override string SDKName
		{
			get
			{
				return null;
			}
		}

		public override string SDKVersion
		{
			get
			{
				return null;
			}
		}

		public AndroidFacebook()
			: base(null)
		{
		}

		public AndroidFacebook(IAndroidWrapper androidWrapper, CallbackManager callbackManager)
			: base(null)
		{
		}

		public void Init(string appId, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete)
		{
		}

		public override void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		public override void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		public override void LogOut()
		{
		}

		public override void AppRequest(string message, OGActionType? actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback)
		{
		}

		public override void AppInvite(Uri appLinkUrl, Uri previewImageUrl, FacebookDelegate<IAppInviteResult> callback)
		{
		}

		public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback)
		{
		}

		public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback)
		{
		}

		public override void GetAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		public override void AppEventsLogEvent(string logEvent, float? valueToSum, Dictionary<string, object> parameters)
		{
		}

		public override void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters)
		{
		}

		public override bool IsImplicitPurchaseLoggingEnabled()
		{
			return false;
		}

		public override void ActivateApp(string appId)
		{
		}

		public override void FetchDeferredAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		public override void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback)
		{
		}

		protected override void SetShareDialogMode(ShareDialogMode mode)
		{
		}

		private static IAndroidWrapper GetAndroidWrapper()
		{
			return null;
		}

		private void CallFB(string method, string args)
		{
		}
	}
}
