using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions
{
	public class TimeNode : ActionTask
	{
		public float randomMin;

		public float randomMax;

		private float val;

		private float currentTime;

		protected override string OnInit()
		{
			return null;
		}

		protected override void OnUpdate()
		{
		}
	}
}
