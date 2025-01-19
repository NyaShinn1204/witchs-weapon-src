using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Facebook.Unity.Canvas;
using Facebook.Unity.Mobile;

namespace Facebook.Unity.Editor
{
	internal class EditorFacebook : FacebookBase, IMobileFacebookImplementation, IMobileFacebook, IFacebook, IMobileFacebookResultHandler, IFacebookResultHandler, ICanvasFacebookImplementation, ICanvasFacebook, IPayFacebook, ICanvasFacebookResultHandler
	{
		private IEditorWrapper editorWrapper;

		[CompilerGenerated]
		private ShareDialogMode _003CShareDialogMode_003Ek__BackingField;

		public override bool LimitEventUsage { get; set; }

		public ShareDialogMode ShareDialogMode
		{
			[CompilerGenerated]
			set
			{
				_003CShareDialogMode_003Ek__BackingField = value;
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

		private static IFacebookCallbackHandler EditorGameObject
		{
			get
			{
				return null;
			}
		}

		public EditorFacebook(IEditorWrapper wrapper, CallbackManager callbackManager)
			: base(null)
		{
		}

		public EditorFacebook()
			: base(null)
		{
		}

		public override void Init(InitDelegate onInitComplete)
		{
		}

		public override void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		public override void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		public override void AppRequest(string message, OGActionType? actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback)
		{
		}

		public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback)
		{
		}

		public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback)
		{
		}

		public override void ActivateApp(string appId)
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

		public bool IsImplicitPurchaseLoggingEnabled()
		{
			return false;
		}

		public void AppInvite(Uri appLinkUrl, Uri previewImageUrl, FacebookDelegate<IAppInviteResult> callback)
		{
		}

		public void FetchDeferredAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		public void Pay(string product, string action, int quantity, int? quantityMin, int? quantityMax, string requestId, string pricepointId, string testCurrency, FacebookDelegate<IPayResult> callback)
		{
		}

		public void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback)
		{
		}

		public override void OnAppRequestsComplete(ResultContainer resultContainer)
		{
		}

		public override void OnGetAppLinkComplete(ResultContainer resultContainer)
		{
		}

		public override void OnLoginComplete(ResultContainer resultContainer)
		{
		}

		public override void OnShareLinkComplete(ResultContainer resultContainer)
		{
		}

		public void OnAppInviteComplete(ResultContainer resultContainer)
		{
		}

		public void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer)
		{
		}

		public void OnPayComplete(ResultContainer resultContainer)
		{
		}

		public void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer)
		{
		}

		public void OnFacebookAuthResponseChange(ResultContainer resultContainer)
		{
		}

		public void OnUrlResponse(string message)
		{
		}

		public void OnHideUnity(bool hidden)
		{
		}
	}
}
