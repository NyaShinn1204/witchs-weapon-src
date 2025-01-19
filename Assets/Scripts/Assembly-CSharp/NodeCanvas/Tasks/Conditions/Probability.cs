using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions
{
	public class Probability : ConditionTask
	{
		public BBParameter<float> probability;

		public BBParameter<float> maxValue;

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
