using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions
{
	public class RandomSelectEntityNode : ActionTask
	{
		public enum oprationType
		{
			add = 1,
			remove = 2
		}

		public oprationType opration;

		public int valueReleaseTargetType;

		public float valueReleaseTargetArgu1;

		public float valueReleaseTargetArgu2;

		public float valueReleaseTargetArgu3;

		public float valueReleaseTargetArgu4;

		public float valueReleaseTargetArgu5;

		public int hatred;

		private Entity entity;

		protected override void OnExecute()
		{
		}
	}
}
