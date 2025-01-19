using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class MecanimSetLookAt : ActionTask<Animator>
	{
		public BBParameter<GameObject> targetPosition;

		public BBParameter<float> targetWeight;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		public void OnAnimatorIK()
		{
		}
	}
}
