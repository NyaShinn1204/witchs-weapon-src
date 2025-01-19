using UnityEngine;
using UnityEngine.Events;

namespace Slate
{
	public class PlayCutsceneOnTrigger : MonoBehaviour
	{
		public Cutscene cutscene;

		public bool checkSpecificTagOnly;

		public string tagName;

		public bool once;

		public UnityEvent onFinish;

		private void OnTriggerEnter(Collider other)
		{
		}

		private void Reset()
		{
		}

		public static GameObject Create()
		{
			return null;
		}
	}
}
