using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Actions
{
	public class Wait : ActionTask
	{
		public BBParameter<float> waitTime;

		public CompactStatus finishStatus;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnUpdate()
		{
		}
	}
}
