using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace NodeCanvas.Framework
{
	public abstract class ConditionTask<T> : ConditionTask where T : Component
	{
		public sealed override Type agentType
		{
			get
			{
				return null;
			}
		}

		public new T agent
		{
			get
			{
				return null;
			}
		}
	}
	public abstract class ConditionTask : Task
	{
		[SerializeField]
		private bool _invert;

		[NonSerialized]
		private int yieldReturn;

		private int yields;

		public bool invert
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void Enable(Component agent, IBlackboard bb)
		{
		}

		public void Disable()
		{
		}

		public bool CheckCondition(Component agent, IBlackboard blackboard)
		{
			return false;
		}

		protected void YieldReturn(bool value)
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual bool OnCheck()
		{
			return false;
		}

		[DebuggerHidden]
		private IEnumerator Flip()
		{
			return null;
		}
	}
}
