using System;
using System.Collections.Generic;
using UniRx;

namespace Invert.StateMachine
{
	public abstract class State : IObserver<StateMachineTrigger>
	{
		private Dictionary<StateMachineTrigger, StateTransition> _triggers;

		public abstract string Name { get; }

		public StateMachine StateMachine { get; set; }

		public Dictionary<StateMachineTrigger, StateTransition> Triggers
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Transition(StateTransition transition)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public virtual void OnEnter(State previousState)
		{
		}

		public virtual void OnExit(State nextState)
		{
		}

		public void OnEntering(State currentState)
		{
		}

		public virtual void AddTrigger(StateMachineTrigger trigger, StateTransition transition)
		{
		}

		public void Trigger(StateMachineTrigger transition)
		{
		}

		public void OnCompleted()
		{
		}

		public void OnError(Exception error)
		{
		}

		public void OnNext(StateMachineTrigger value)
		{
		}
	}
}
