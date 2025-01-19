using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;

namespace NodeCanvas.Tasks.Conditions
{
	public class CheckEnum : ConditionTask
	{
		[BlackboardOnly]
		public BBObjectParameter valueA;

		public BBObjectParameter valueB;

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
