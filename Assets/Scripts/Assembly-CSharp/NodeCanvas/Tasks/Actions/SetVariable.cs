using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions
{
	public class SetVariable<T> : ActionTask
	{
		[BlackboardOnly]
		public BBParameter<T> valueA;

		public BBParameter<T> valueB;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}
	}
}
