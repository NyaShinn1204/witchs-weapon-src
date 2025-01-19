using System;
using System.Reflection;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class SetField : ActionTask
	{
		[SerializeField]
		protected BBObjectParameter setValue;

		[SerializeField]
		protected Type targetType;

		[SerializeField]
		protected string fieldName;

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
