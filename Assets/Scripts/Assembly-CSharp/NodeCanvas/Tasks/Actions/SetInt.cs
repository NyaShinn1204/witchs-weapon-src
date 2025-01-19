using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Actions
{
	public class SetInt : ActionTask
	{
		[BlackboardOnly]
		public BBParameter<int> valueA;

		public OperationMethod Operation;

		public BBParameter<int> valueB;

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
