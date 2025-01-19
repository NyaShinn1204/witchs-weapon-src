using System;
using System.Collections.Generic;
using System.Reflection;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class ImplementedAction_Multiplatform : ActionTask
	{
		[SerializeField]
		private SerializedMethodInfo method;

		[SerializeField]
		private List<BBObjectParameter> parameters;

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
