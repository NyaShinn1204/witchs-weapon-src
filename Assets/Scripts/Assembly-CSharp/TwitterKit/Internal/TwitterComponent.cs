using System;
using TwitterKit.Unity;
using UnityEngine;

namespace TwitterKit.Internal
{
	internal class TwitterComponent : MonoBehaviour
	{
		public Action<TwitterSession> loginSuccessAction { get; set; }

		public Action<ApiError> loginFailureAction { get; set; }

		public Action<string> emailSuccessAction { get; set; }

		public Action<ApiError> emailFailureAction { get; set; }

		public Action<string> tweetSuccessAction { get; set; }

		public Action<ApiError> tweetFailureAction { get; set; }

		public Action tweetCancelAction { get; set; }

		public void Awake()
		{
		}

		public void LoginComplete(string session)
		{
		}

		public void LoginFailed(string error)
		{
		}

		public void RequestEmailComplete(string email)
		{
		}

		public void RequestEmailFailed(string error)
		{
		}

		public void TweetComplete(string tweetId)
		{
		}

		public void TweetFailed(string error)
		{
		}

		public void TweetCancelled()
		{
		}
	}
}
