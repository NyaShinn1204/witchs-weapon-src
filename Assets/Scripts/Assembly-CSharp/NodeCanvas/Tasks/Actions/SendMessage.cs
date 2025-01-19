using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class SendMessage<T> : ActionTask<Transform>
	{
		[RequiredField]
		public BBParameter<string> methodName;

		public BBParameter<T> argument;

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
