using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class MecanimSetTrigger : ActionTask<Animator>
	{
		public BBParameter<string> parameter;

		public BBParameter<int> parameterHashID;

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
