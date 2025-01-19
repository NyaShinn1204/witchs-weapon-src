using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace NodeCanvas.Framework
{
	public abstract class ActionTask<T> : ActionTask where T : Component
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
	public abstract class ActionTask : Task
	{
		[NonSerialized]
		private Status status;

		[NonSerialized]
		private float startedTime;

		[NonSerialized]
		private float pausedTime;

		[NonSerialized]
		private bool latch;

		[NonSerialized]
		private bool _isPaused;

		public Status p_status
		{
			get
			{
				return default(Status);
			}
		}

		public bool p_latch
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float elapsedTime
		{
			get
			{
				return 0f;
			}
		}

		public bool isRunning
		{
			get
			{
				return false;
			}
		}

		public bool isPaused
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public void ExecuteAction(Component agent, Action<bool> callback)
		{
		}

		public void ExecuteAction(Component agent, IBlackboard blackboard, Action<bool> callback)
		{
		}

		[DebuggerHidden]
		private IEnumerator ActionUpdater(Component agent, IBlackboard blackboard, Action<bool> callback)
		{
			return null;
		}

		public Status ExecuteAction(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		private void LogMessage(Component agent, string log)
		{
		}

		public void EndAction()
		{
		}

		public void EndAction(bool success)
		{
		}

		public void EndAction(bool? success)
		{
		}

		public void PauseAction()
		{
		}

		protected virtual void OnExecute()
		{
		}

		protected virtual void OnUpdate()
		{
		}

		protected virtual void OnStop()
		{
		}

		protected virtual void OnPause()
		{
		}

		public virtual void ResetOnStop()
		{
		}
	}
}
