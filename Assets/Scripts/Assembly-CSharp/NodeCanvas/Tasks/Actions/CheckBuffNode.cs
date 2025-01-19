using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions
{
	public class CheckBuffNode : ConditionTask
	{
		public string BuffIDStr;

		public string BuffLayerStr;

		private long buffID;

		private Entity entity;

		protected override string OnInit()
		{
			return null;
		}

		protected override bool OnCheck()
		{
			return false;
		}
	}
}
