using DG.Tweening;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class BrownianMotion : MonoBehaviour
	{
		public Vector2 offsetXY;

		public float minDuration;

		public float maxDutation;

		public AnimationCurve moveCurve;

		private float duration;

		private Vector3 rotateTo;

		private Tweener m_RotateTweener;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void Reset()
		{
		}

		public void Play(float delay = 0f)
		{
		}

		private void PlayDelay()
		{
		}

		public void Pause(float delay = 0f, bool isResetRotation = true)
		{
		}

		private void PauseDelay()
		{
		}
	}
}
