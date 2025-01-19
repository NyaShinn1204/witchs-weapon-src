using System;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	public class CheckCSharpEvent : ConditionTask
	{
		[SerializeField]
		private Type targetType;

		[SerializeField]
		private string eventName;

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

		public void Raised()
		{
		}

		protected override bool OnCheck()
		{
			return false;
		}
	}
	public class CheckCSharpEvent<T> : ConditionTask
	{
		[SerializeField]
		private Type targetType;

		[SerializeField]
		private string eventName;

		[SerializeField]
		private BBParameter<T> saveAs;

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

		public void Raised(T eventValue)
		{
		}

		protected override bool OnCheck()
		{
			return false;
		}
	}
}
