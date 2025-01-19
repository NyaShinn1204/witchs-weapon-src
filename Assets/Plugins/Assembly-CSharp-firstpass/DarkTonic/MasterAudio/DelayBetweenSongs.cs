using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace DarkTonic.MasterAudio
{
	public class DelayBetweenSongs : MonoBehaviour
	{
		public float minTimeToWait;

		public float maxTimeToWait;

		public string playlistControllerName;

		private PlaylistController _controller;

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void SongEnded(string songName)
		{
		}

		[DebuggerHidden]
		private IEnumerator PlaySongWithDelay()
		{
			return null;
		}
	}
}
