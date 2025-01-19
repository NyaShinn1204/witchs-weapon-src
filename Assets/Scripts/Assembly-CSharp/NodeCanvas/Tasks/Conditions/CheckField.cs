using System;
using System.Reflection;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	public class CheckField : ConditionTask
	{
		[SerializeField]
		protected BBParameter checkValue;

		[SerializeField]
		protected Type targetType;

		[SerializeField]
		protected string fieldName;

		[SerializeField]
		protected CompareMethod comparison;

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

		protected override bool OnCheck()
		{
			return false;
		}
	}
}
