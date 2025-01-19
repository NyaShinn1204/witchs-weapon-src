using System.Collections;
using System.Diagnostics;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	public class TriggerBoolean : ActionTask
	{
		[RequiredField]
		[BlackboardOnly]
		public BBParameter<bool> variable;

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

		[DebuggerHidden]
		private IEnumerator Flip()
		{
			return null;
		}
	}
}
