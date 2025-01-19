using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class CaluDistanceNode : ActionTask
	{
		[SerializeField]
		public BBParameter<float> veriable;

		private Entity entity;

		protected override void OnExecute()
		{
		}
	}
}
