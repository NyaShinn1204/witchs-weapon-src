using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Slate
{
	public class CutsceneSequencePlayer : MonoBehaviour
	{
		public bool playOnStart;

		public List<Cutscene> cutscenes;

		public UnityEvent onFinish;

		private int currentIndex;

		private bool isPlaying;

		private void Start()
		{
		}

		public void Play()
		{
		}

		public void Stop()
		{
		}

		private void MoveNext()
		{
		}

		public static GameObject Create()
		{
			return null;
		}
	}
}
