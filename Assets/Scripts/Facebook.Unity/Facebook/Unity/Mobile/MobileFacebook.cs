using System;

namespace Facebook.Unity.Mobile
{
	internal abstract class MobileFacebook : FacebookBase, IMobileFacebookImplementation, IMobileFacebook, IFacebook, IMobileFacebookResultHandler, IFacebookResultHandler
	{
		private ShareDialogMode shareDialogMode;

		public ShareDialogMode ShareDialogMode
		{
			set
			{
			}
		}

		protected MobileFacebook(CallbackManager callbackManager)
			: base(null)
		{
		}

		public abstract void AppInvite(Uri appLinkUrl, Uri previewImageUrl, FacebookDelegate<IAppInviteResult> callback);

		public abstract void FetchDeferredAppLink(FacebookDelegate<IAppLinkResult> callback);

		public abstract void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback);

		public abstract bool IsImplicitPurchaseLoggingEnabled();

		public override void OnLoginComplete(ResultContainer resultContainer)
		{
		}

		public override void OnGetAppLinkComplete(ResultContainer resultContainer)
		{
		}

		public override void OnAppRequestsComplete(ResultContainer resultContainer)
		{
		}

		public void OnAppInviteComplete(ResultContainer resultContainer)
		{
		}

		public void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer)
		{
		}

		public override void OnShareLinkComplete(ResultContainer resultContainer)
		{
		}

		public void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer)
		{
		}

		protected abstract void SetShareDialogMode(ShareDialogMode mode);
	}
}
