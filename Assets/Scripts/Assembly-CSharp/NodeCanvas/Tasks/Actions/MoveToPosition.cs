using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions
{
	public class MoveToPosition : ActionTask<NavMeshAgent>
	{
		public BBParameter<Vector3> targetPosition;

		public BBParameter<float> speed;

		public float keepDistance;

		private Vector3? lastRequest;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnStop()
		{
		}

		protected override void OnPause()
		{
		}
	}
}
