namespace Facebook.Unity.Mobile
{
	internal abstract class MobileFacebookGameObject : FacebookGameObject, IMobileFacebookCallbackHandler, IFacebookCallbackHandler
	{
		private IMobileFacebookImplementation MobileFacebook
		{
			get
			{
				return null;
			}
		}

		public void OnAppInviteComplete(string message)
		{
		}

		public void OnFetchDeferredAppLinkComplete(string message)
		{
		}

		public void OnRefreshCurrentAccessTokenComplete(string message)
		{
		}
	}
}
