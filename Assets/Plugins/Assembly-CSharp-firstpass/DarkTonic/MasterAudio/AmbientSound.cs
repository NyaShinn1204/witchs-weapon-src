using UnityEngine;

namespace DarkTonic.MasterAudio
{
	public class AmbientSound : MonoBehaviour
	{
		[SoundGroup]
		public string AmbientSoundGroup;

		public bool FollowCaller;

		public Transform RuntimeFollower;

		private Transform _trans;

		public bool IsValidSoundGroup
		{
			get
			{
				return false;
			}
		}

		public Transform Trans
		{
			get
			{
				return null;
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void StartTrackers()
		{
		}
	}
}
