using UnityEngine;
using UnityEngine.Events;

namespace Slate
{
	public class PlayCutsceneOnClick : MonoBehaviour
	{
		public Cutscene cutscene;

		public UnityEvent onFinish;

		private void OnMouseDown()
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
