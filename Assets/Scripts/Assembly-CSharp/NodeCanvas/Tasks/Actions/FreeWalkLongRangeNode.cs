using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class FreeWalkLongRangeNode : ActionTask
	{
		private Entity entity;

		public string RRAMax;

		public string RRMax;

		public string RRMin;

		public string RRAMin;

		public float timeMax;

		private float _RRMax;

		private float _RRMin;

		private float _RRAMax;

		private float _RRAMin;

		private bool isLockTime;

		private float time;

		private bool isMoving;

		[SerializeField]
		public BBParameter<bool> isSkillCating;

		private static float _angleRandom;

		protected override void OnExecute()
		{
		}

		private void FreeMoveComplete(bool flag)
		{
		}

		protected override void OnUpdate()
		{
		}

		private Vector3 CheckMoveToPosition()
		{
			return default(Vector3);
		}

		private void MoveToTargetPos(Vector3 pos)
		{
		}
	}
}
