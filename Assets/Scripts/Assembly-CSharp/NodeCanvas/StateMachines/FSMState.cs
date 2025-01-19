using System;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.StateMachines
{
	public abstract class FSMState : Node, IState
	{
		public enum TransitionEvaluationMode
		{
			CheckContinuously = 0,
			CheckAfterStateFinished = 1,
			CheckManually = 2
		}

		[SerializeField]
		private TransitionEvaluationMode _transitionEvaluation;

		private float _elapsedTime;

		private bool hasInit;

		public override int maxInConnections
		{
			get
			{
				return 0;
			}
		}

		public override int maxOutConnections
		{
			get
			{
				return 0;
			}
		}

		public sealed override Type outConnectionType
		{
			get
			{
				return null;
			}
		}

		public override bool allowAsPrime
		{
			get
			{
				return false;
			}
		}

		public sealed override bool showCommentsBottom
		{
			get
			{
				return false;
			}
		}

		public TransitionEvaluationMode transitionEvaluation
		{
			get
			{
				return default(TransitionEvaluationMode);
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
			private set
			{
			}
		}

		public FSM FSM
		{
			get
			{
				return null;
			}
		}

		public FSMConnection[] GetTransitions()
		{
			return null;
		}

		public void Finish()
		{
		}

		public void Finish(bool inSuccess)
		{
		}

		public sealed override void OnGraphStarted()
		{
		}

		public sealed override void OnGraphStoped()
		{
		}

		public sealed override void OnGraphPaused()
		{
		}

		protected sealed override Status OnExecute(Component agent, IBlackboard bb)
		{
			return default(Status);
		}

		public void Update()
		{
		}

		public bool CheckTransitions()
		{
			return false;
		}

		protected sealed override void OnReset()
		{
		}

		protected virtual void OnInit()
		{
		}

		protected virtual void OnEnter()
		{
		}

		protected virtual void OnUpdate()
		{
		}

		protected virtual void OnExit()
		{
		}

		protected virtual void OnPause()
		{
		}
	}
}
