using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class ProtectEndNode : ActionTask, ILogParam
	{
		private Entity entity;

		[SerializeField]
		public BBParameter<bool> isProtected;

		[SerializeField]
		public BBParameter<bool> shouldReset;

		protected override void OnExecute()
		{
		}

		public string ValueToString()
		{
			return null;
		}
	}
}
