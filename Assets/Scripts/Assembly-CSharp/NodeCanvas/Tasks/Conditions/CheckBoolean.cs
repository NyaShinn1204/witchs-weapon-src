using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions
{
	public class CheckBoolean : ConditionTask
	{
		[BlackboardOnly]
		public BBParameter<bool> valueA;

		public BBParameter<bool> valueB;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override bool OnCheck()
		{
			return false;
		}
	}
}
