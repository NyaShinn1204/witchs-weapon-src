using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace UnityChan
{
	public class AutoBlink : MonoBehaviour
	{
		private enum Status
		{
			Close = 0,
			HalfClose = 1,
			Open = 2
		}

		public bool isActive;

		public SkinnedMeshRenderer ref_SMR_EYE_DEF;

		public SkinnedMeshRenderer ref_SMR_EL_DEF;

		public float ratio_Close;

		public float ratio_HalfClose;

		[HideInInspector]
		public float ratio_Open;

		private bool timerStarted;

		private bool isBlink;

		public float timeBlink;

		private float timeRemining;

		public float threshold;

		public float interval;

		private Status eyeStatus;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void ResetTimer()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void SetCloseEyes()
		{
		}

		private void SetHalfCloseEyes()
		{
		}

		private void SetOpenEyes()
		{
		}

		[DebuggerHidden]
		private IEnumerator RandomChange()
		{
			return null;
		}
	}
}
