using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions
{
	public class ModifyPropertyNode : ActionTask
	{
		public enum oprationType
		{
			assignment = 1,
			increase = 2,
			reduce = 3
		}

		public oprationType opration;

		public int valueReleaseTargetType;

		public float valueReleaseTargetArgu1;

		public float valueReleaseTargetArgu2;

		public float valueReleaseTargetArgu3;

		public float valueReleaseTargetArgu4;

		public float valueReleaseTargetArgu5;

		public int valueIndex;

		public float attrValue;

		public int additionValue;

		private Entity entity;

		protected override void OnExecute()
		{
		}
	}
}
