using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines
{
	public class AnyState : FSMState, IUpdatable
	{
		public bool dontRetriggerStates;

		public override string name
		{
			get
			{
				return null;
			}
		}

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

		public override bool allowAsPrime
		{
			get
			{
				return false;
			}
		}

		public new void Update()
		{
		}
	}
}
