using System;
using TwitterKit.Internal;
using UnityEngine;

namespace TwitterKit.Unity
{
	public sealed class Twitter : ScriptableObject
	{
		private static ITwitter twitter;

		private static GameObject twitterGameObject;

		public static TwitterSession Session
		{
			get
			{
				return null;
			}
		}

		public static void AwakeInit()
		{
		}

		public static void Init()
		{
		}

		public static void LogIn(Action<TwitterSession> successCallback = null, Action<ApiError> failureCallback = null)
		{
		}

		public static void LogOut()
		{
		}

		public static void RequestEmail(TwitterSession session, Action<string> successCallback = null, Action<ApiError> failureCallback = null)
		{
		}

		public static void Compose(TwitterSession session, string imageUri, string text, string[] hashtags = null, Action<string> successCallback = null, Action<ApiError> failureCallback = null, Action cancelCallback = null)
		{
		}
	}
}
