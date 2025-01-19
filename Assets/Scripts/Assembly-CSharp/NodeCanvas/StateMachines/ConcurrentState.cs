using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.StateMachines
{
	public class ConcurrentState : FSMState, IUpdatable, ITaskAssignable
	{
		[SerializeField]
		private ActionList _actionList;

		[SerializeField]
		private bool _repeatStateActions;

		public ActionList actionList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Task task
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool repeatStateActions
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

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

		public override void OnValidate(Graph assignedGraph)
		{
		}

		protected override void OnEnter()
		{
		}

		public new void Update()
		{
		}

		protected override void OnExit()
		{
		}

		protected override void OnPause()
		{
		}
	}
}
