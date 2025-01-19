using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class CameraFader : MonoBehaviour
	{
		private static CameraFader _current;

		private float alpha;

		private Texture2D _blackTexture;

		private Texture2D blackTexture
		{
			get
			{
				return null;
			}
		}

		public static CameraFader current
		{
			get
			{
				return null;
			}
		}

		public void FadeIn(float time)
		{
		}

		public void FadeOut(float time)
		{
		}

		[DebuggerHidden]
		private IEnumerator CoroutineFadeIn(float time)
		{
			return null;
		}

		[DebuggerHidden]
		private IEnumerator CoroutineFadeOut(float time)
		{
			return null;
		}

		private void OnGUI()
		{
		}
	}
}
