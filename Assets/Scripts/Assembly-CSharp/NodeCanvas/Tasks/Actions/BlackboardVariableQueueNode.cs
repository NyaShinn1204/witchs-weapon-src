using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class BlackboardVariableQueueNode : ActionTask
	{
		public ValueParam.Type valueType;

		public float val;

		[SerializeField]
		public BBParameter<float> blackBoardAtrr1;

		public int valueReleaseTargetType;

		public float valueReleaseTargetArgu1;

		public float valueReleaseTargetArgu2;

		public float valueReleaseTargetArgu3;

		public float valueReleaseTargetArgu4;

		public float valueReleaseTargetArgu5;

		public int valueIndex;

		public string tableArgName;

		private Entity entity;

		private ValueParam valueParam;

		protected override void OnExecute()
		{
		}
	}
}
