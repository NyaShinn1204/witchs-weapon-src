using UnityEngine;

namespace WaterBell.ProjX.Core.Manager.Audio
{
	public class AudioContainer : MonoBehaviour
	{
		public bool PlayOnAwake;

		private bool PlayOnAwake4OnEnable;

		public string AudioResID;

		public bool useRandomPlay;

		public string[] AudioResIDs;

		private int RandKey;

		private AudioPlay _audioSource;

		private void Awake()
		{
		}

		private void initAudioPlay()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void doPlay()
		{
		}

		public void doStop()
		{
		}
	}
}
