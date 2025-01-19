using TwitterKit.Unity;
using UnityEngine;

namespace TwitterKit.Internal
{
	internal class AndroidTwitterImpl : ITwitter
	{
		private AndroidJavaClass twitter;

		public void Init(string consumerKey, string consumerSecret)
		{
		}

		public void LogIn()
		{
		}

		public void LogOut()
		{
		}

		public TwitterSession Session()
		{
			return null;
		}

		public void RequestEmail(TwitterSession session)
		{
		}

		public void Compose(TwitterSession session, string imageUri, string text, string[] hashtags)
		{
		}
	}
}
