using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace WaterBell.ProjX.Guide.Content
{
	public class BgTexCtrl : MonoBehaviour
	{
		private enum AnimCmd
		{
			HideBG = 0,
			SwapBG = 1
		}

		private Transform selfTrans;

		private UITexture tmpTex;

		private UITexture tex;

		private UIScreenAutoSize tmpTexAutoSize;

		private UIScreenAutoSize texAutoSize;

		private bool _isShowingBg;

		private float lerpRatio;

		private bool isRunningAnim;

		private bool isInstanceFinish;

		private float animTimeAdd;

		private float animTimeMax;

		public bool isShowingBg
		{
			get
			{
				return false;
			}
		}

		private void Awake()
		{
		}

		public void Reset()
		{
		}

		public void SwapBg(string picName, float delay = 0f)
		{
		}

		public void HideBg(float delay = 0f)
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
		private IEnumerator RunAnim(AnimCmd cmd, string picName, float delayTime = 0f)
		{
			return null;
		}
	}
}
