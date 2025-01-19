using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class BlackboardVariableNode : ActionTask
	{
		public ValueParam.Type valueType;

		[SerializeField]
		public BBParameter<float> blackBoardAtrr1;

		public float val;

		public int targetType;

		public float targetArgu1;

		public float targetArgu2;

		public float targetArgu3;

		public float targetArgu4;

		public float targetArgu5;

		public int valueIndex;

		public string tableArgName;

		public Entity entity;

		private ValueParam param;

		protected override void OnExecute()
		{
		}
	}
}
