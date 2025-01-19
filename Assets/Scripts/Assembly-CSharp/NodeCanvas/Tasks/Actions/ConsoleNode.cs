using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class ConsoleNode : ActionTask
	{
		public string content;

		[SerializeField]
		public BBParameter<float> count;

		protected override void OnExecute()
		{
		}
	}
}
