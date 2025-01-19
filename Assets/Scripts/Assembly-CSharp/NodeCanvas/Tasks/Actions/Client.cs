using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class Client : ActionTask
	{
		private int count;

		private int time;

		[SerializeField]
		public BBParameter<string> evt;

		protected override void OnUpdate()
		{
		}

		protected override void OnExecute()
		{
		}
	}
}
