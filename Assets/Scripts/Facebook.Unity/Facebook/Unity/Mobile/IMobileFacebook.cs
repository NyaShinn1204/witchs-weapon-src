using System;

namespace Facebook.Unity.Mobile
{
	internal interface IMobileFacebook : IFacebook
	{
		ShareDialogMode ShareDialogMode { set; }

		void AppInvite(Uri appLinkUrl, Uri previewImageUrl, FacebookDelegate<IAppInviteResult> callback);

		void FetchDeferredAppLink(FacebookDelegate<IAppLinkResult> callback);

		void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback);

		bool IsImplicitPurchaseLoggingEnabled();
	}
}
