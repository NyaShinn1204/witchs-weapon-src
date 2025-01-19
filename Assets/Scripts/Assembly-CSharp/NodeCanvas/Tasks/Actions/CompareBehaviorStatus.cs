using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions
{
	public class CompareBehaviorStatus : ConditionTask
	{
		private Entity entity;

		public int targetType;

		public float targetArgu1;

		public float targetArgu2;

		public float targetArgu3;

		public float targetArgu4;

		public float targetArgu5;

		public AITreePool.AITreeType type;

		public bool isSame;

		protected override bool OnCheck()
		{
			return false;
		}
	}
}
