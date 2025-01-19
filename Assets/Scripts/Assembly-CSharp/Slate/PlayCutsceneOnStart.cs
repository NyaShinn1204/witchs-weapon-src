using UnityEngine;
using UnityEngine.Events;

namespace Slate
{
	public class PlayCutsceneOnStart : MonoBehaviour
	{
		public Cutscene cutscene;

		public UnityEvent onFinish;

		private void Start()
		{
		}

		public static GameObject Create()
		{
			return null;
		}
	}
}
