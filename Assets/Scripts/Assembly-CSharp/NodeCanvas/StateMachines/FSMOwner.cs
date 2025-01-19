using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines
{
	public class FSMOwner : GraphOwner<FSM>
	{
		public string currentRootStateName
		{
			get
			{
				return null;
			}
		}

		public string previousRootStateName
		{
			get
			{
				return null;
			}
		}

		public string currentDeepStateName
		{
			get
			{
				return null;
			}
		}

		public string previousDeepStateName
		{
			get
			{
				return null;
			}
		}

		public IState GetCurrentState(bool includeSubFSMs = true)
		{
			return null;
		}

		public IState GetPreviousState(bool includeSubFSMs = true)
		{
			return null;
		}

		public IState TriggerState(string stateName)
		{
			return null;
		}

		public string[] GetStateNames()
		{
			return null;
		}
	}
}
