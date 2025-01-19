using System;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	public class CheckStaticCSharpEvent : ConditionTask
	{
		[SerializeField]
		private Type targetType;

		[SerializeField]
		private string eventName;

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
	public class CheckStaticCSharpEvent<T> : ConditionTask
	{
		[SerializeField]
		private Type targetType;

		[SerializeField]
		private string eventName;

		[SerializeField]
		[BlackboardOnly]
		private BBParameter<T> saveAs;

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
