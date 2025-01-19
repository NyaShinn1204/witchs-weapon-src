using System;
using System.Reflection;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class GetField : ActionTask
	{
		[SerializeField]
		protected Type targetType;

		[SerializeField]
		protected string fieldName;

		[SerializeField]
		[BlackboardOnly]
		protected BBObjectParameter saveAs;

		private FieldInfo field;

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

		protected override string OnInit()
		{
			return null;
		}

		protected override void OnExecute()
		{
		}
	}
}
