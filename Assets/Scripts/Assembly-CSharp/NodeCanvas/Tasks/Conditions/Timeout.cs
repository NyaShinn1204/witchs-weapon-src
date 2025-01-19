using System.Collections;
using System.Diagnostics;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	public class Timeout : ConditionTask
	{
		public BBParameter<float> timeout;

		private float currentTime;

		private Coroutine coroutine;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnDisable()
		{
		}

		protected override bool OnCheck()
		{
			return false;
		}

		[DebuggerHidden]
		private IEnumerator Do()
		{
			return null;
		}
	}
}
