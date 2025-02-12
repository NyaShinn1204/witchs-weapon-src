using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	public class GetIndexOfElement<T> : ActionTask
	{
		[RequiredField]
		[BlackboardOnly]
		public BBParameter<List<T>> targetList;

		public BBParameter<T> targetElement;

		[BlackboardOnly]
		public BBParameter<int> saveIndexAs;

		protected override void OnExecute()
		{
		}
	}
}
