using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class ProtectBeginNode : ActionTask
	{
		private Entity entity;

		[SerializeField]
		public BBParameter<bool> isProtected;

		protected override void OnExecute()
		{
		}
	}
}
