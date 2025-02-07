using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	public class CheckButtonInput : ConditionTask
	{
		public PressTypes pressType;

		[RequiredField]
		public BBParameter<string> buttonName;

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
