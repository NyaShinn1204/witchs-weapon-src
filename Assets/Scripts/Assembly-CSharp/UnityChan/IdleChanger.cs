using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace UnityChan
{
	public class IdleChanger : MonoBehaviour
	{
		private Animator anim;

		private AnimatorStateInfo currentState;

		private AnimatorStateInfo previousState;

		public bool _random;

		public float _threshold;

		public float _interval;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnGUI()
		{
		}

		[DebuggerHidden]
		private IEnumerator RandomChange()
		{
			return null;
		}
	}
}
