using System.Collections.Generic;

namespace Invert.StateMachine
{
	public class StateMachine : P<State>
	{
		private List<State> _states;

		public List<State> States
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual State StartState
		{
			get
			{
				return null;
			}
		}

		public State LastState
		{
			get
			{
				return null;
			}
		}

		public State CurrentState
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public StateTransition[] Transitions { get; set; }

		public StateTransition LastTransition { get; set; }

		public string Identifier { get; private set; }

		public StateMachine(ViewModel owner, string propertyName)
		{
		}

		private void Compose()
		{
		}

		protected override void OnPropertyChanged(string value)
		{
		}

		public virtual void Compose(List<State> states)
		{
		}

		public void Transition(string name)
		{
		}

		public void Transition(StateTransition transition)
		{
		}

		public void SetState(string stateName)
		{
		}
	}
}
