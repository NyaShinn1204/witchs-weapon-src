using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	public class PickRandomListElement<T> : ActionTask
	{
		[RequiredField]
		public BBParameter<List<T>> targetList;

		public BBParameter<T> saveAs;

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
