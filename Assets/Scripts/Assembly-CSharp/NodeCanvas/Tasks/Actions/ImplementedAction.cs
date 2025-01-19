using System;
using System.Reflection;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class ImplementedAction : ActionTask, ISubParametersContainer
	{
		[SerializeField]
		protected ReflectedFunctionWrapper functionWrapper;

		private Status actionStatus;

		private MethodInfo targetMethod
		{
			get
			{
				return null;
			}
		}

		public override Type agentType
		{
			get
			{
				return null;
			}
		}

		protected override string info
		{
			get
			{
				return null;
			}
		}

		BBParameter[] ISubParametersContainer.GetIncludeParseParameters()
		{
			return null;
		}

		public override void OnValidate(ITaskSystem ownerSystem)
		{
		}

		protected override string OnInit()
		{
			return null;
		}

		protected override void OnExecute()
		{
		}

		protected override void OnUpdate()
		{
		}

		private void Forward()
		{
		}

		protected override void OnStop()
		{
		}

		private void SetMethod(MethodInfo method)
		{
		}
	}
}
