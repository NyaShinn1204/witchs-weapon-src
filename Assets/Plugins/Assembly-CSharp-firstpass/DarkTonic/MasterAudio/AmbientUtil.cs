using UnityEngine;

namespace DarkTonic.MasterAudio
{
	public static class AmbientUtil
	{
		public const string FollowerHolderName = "_Followers";

		public const string ListenerFollowerName = "~ListenerFollower~";

		public const float ListenerFollowerTrigRadius = 0.01f;

		private static Transform _followerHolder;

		private static ListenerFollower _listenerFollower;

		public static ListenerFollower ListenerFollower
		{
			get
			{
				return null;
			}
		}

		public static Transform FollowerHolder
		{
			get
			{
				return null;
			}
		}

		public static bool HasListenerFollower
		{
			get
			{
				return false;
			}
		}

		public static void InitFollowerHolder()
		{
		}

		public static bool InitListenerFollower()
		{
			return false;
		}

		public static Transform InitAudioSourceFollower(Transform transToFollow, string followerName, string soundGroupName, bool willFollowSource)
		{
			return null;
		}
	}
}
