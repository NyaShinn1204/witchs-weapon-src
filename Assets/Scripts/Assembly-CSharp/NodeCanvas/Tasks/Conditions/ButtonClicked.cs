using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.UI;

namespace NodeCanvas.Tasks.Conditions
{
	public class ButtonClicked : ConditionTask
	{
		[RequiredField]
		public BBParameter<Button> button;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override string OnInit()
		{
			return null;
		}

		protected override bool OnCheck()
		{
			return false;
		}

		private void OnClick()
		{
		}
	}
}
