using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class ExecuteFunction_Multiplatform : ActionTask
	{
		[SerializeField]
		protected SerializedMethodInfo method;

		[SerializeField]
		protected List<BBObjectParameter> parameters;

		[SerializeField]
		protected List<bool> parameterIsByRef;

		[SerializeField]
		[BlackboardOnly]
		protected BBObjectParameter returnValue;

		private object[] args;

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
