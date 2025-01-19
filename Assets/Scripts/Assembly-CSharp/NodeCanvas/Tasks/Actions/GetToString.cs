using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions
{
	public class GetToString : ActionTask
	{
		[BlackboardOnly]
		public BBParameter<object> variable;

		[BlackboardOnly]
		public BBParameter<string> toString;

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
