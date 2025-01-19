using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class MoveNode : ActionTask
	{
		public enum MOVE_TYPE
		{
			potition = 1,
			nearPosition = 2,
			target = 3
		}

		public int valueReleaseTargetType;

		public float valueReleaseTargetArgu1;

		public float valueReleaseTargetArgu2;

		public float valueReleaseTargetArgu3;

		public float valueReleaseTargetArgu4;

		public float valueReleaseTargetArgu5;

		public MOVE_TYPE type;

		private Entity entity;

		public Vector3 targetPosition;

		public float distance;

		public bool showLog;

		public bool isSummon;

		protected override void OnExecute()
		{
		}

		private bool CheckValid(MOVE_TYPE type)
		{
			return false;
		}
	}
}
