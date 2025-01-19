using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions
{
	public class AccuCountNode : ActionTask
	{
		public string maxCountStr;

		private float maxCount;

		private float currentCount;

		private Entity entity;

		protected override string OnInit()
		{
			return null;
		}

		protected override void OnExecute()
		{
		}
	}
}
