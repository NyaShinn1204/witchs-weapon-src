using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace WaterBell.ProjX.Guide.Content
{
	public class StoryTransition : MonoBehaviour
	{
		private enum AnimCmd
		{
			OpenTransition = 0,
			CloseTransition = 1,
			FrontMaskFadeAnim = 2,
			FrontMaskFadeOut = 3
		}

		private UITexture centerTex;

		private UITexture bgTex;

		private Transform selfTrans;

		private bool isRunnning;

		private bool isRunningAnim;

		private bool isInstantFinish;

		private float animTimeAdd;

		private float animTimeMax;

		private float animTimeMaxDefault;

		private float lerpRatio;

		private Color srcCol;

		private Color desCol;

		private Color fadeTmpCol;

		public bool GetIsRunning()
		{
			return false;
		}

		private void Awake()
		{
		}

		public void Open(bool isInstantFinish = false)
		{
		}

		public void Close()
		{
		}

		public void Fade(Color srcCol, Color desCol, float fadeTime)
		{
		}

		public bool GetIsRunningAnim()
		{
			return false;
		}

		public void LetInstantFinish()
		{
		}

		[DebuggerHidden]
		private IEnumerator RunAnim(AnimCmd cmd, object[] cmdArgs = null)
		{
			return null;
		}

		private void CenterTexFadeLerp(float lerpRatio)
		{
		}
	}
}
