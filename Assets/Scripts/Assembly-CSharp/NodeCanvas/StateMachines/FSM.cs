using System;
using System.Collections.Generic;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines
{
	[GraphInfo]
	public class FSM : Graph
	{
		private bool hasInitialized;

		private List<IUpdatable> updatableNodes;

		private List<AnyState> anyStates;

		private List<ConcurrentState> concurentStates;

		public FSMState currentState { get; private set; }

		public FSMState previousState { get; private set; }

		public string currentStateName
		{
			get
			{
				return null;
			}
		}

		public string previousStateName
		{
			get
			{
				return null;
			}
		}

		public override Type baseNodeType
		{
			get
			{
				return null;
			}
		}

		public override bool requiresAgent
		{
			get
			{
				return false;
			}
		}

		public override bool requiresPrimeNode
		{
			get
			{
				return false;
			}
		}

		public override bool autoSort
		{
			get
			{
				return false;
			}
		}

		public override bool useLocalBlackboard
		{
			get
			{
				return false;
			}
		}

		private event Action<IState> CallbackEnter
		{
			add
			{
			}
			remove
			{
			}
		}

		private event Action<IState> CallbackStay
		{
			add
			{
			}
			remove
			{
			}
		}

		private event Action<IState> CallbackExit
		{
			add
			{
			}
			remove
			{
			}
		}

		protected override void OnGraphStarted()
		{
		}

		protected override void OnGraphUnpaused()
		{
		}

		protected override void OnGraphUpdate()
		{
		}

		protected override void OnGraphStoped()
		{
		}

		protected override void OnGraphPaused()
		{
		}

		public bool EnterState(FSMState newState)
		{
			return false;
		}

		public FSMState TriggerState(string stateName)
		{
			return null;
		}

		public string[] GetStateNames()
		{
			return null;
		}

		public FSMState GetStateWithName(string name)
		{
			return null;
		}

		private void GatherDelegates()
		{
		}
	}
}
