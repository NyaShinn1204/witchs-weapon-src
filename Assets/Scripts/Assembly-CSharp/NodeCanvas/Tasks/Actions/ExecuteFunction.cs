using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class ExecuteFunction : ActionTask, ISubParametersContainer
	{
		[SerializeField]
		protected ReflectedWrapper functionWrapper;

		private bool routineRunning;

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

		protected override void OnStop()
		{
		}

		[DebuggerHidden]
		private IEnumerator InternalCoroutine(IEnumerator routine)
		{
			return null;
		}

		private void SetMethod(MethodInfo method)
		{
		}
	}
}
