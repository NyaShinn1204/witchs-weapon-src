using System.Collections.Generic;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	public class NestedFSM : BTNode, IGraphAssignable
	{
		[SerializeField]
		private BBParameter<FSM> _nestedFSM;

		private Dictionary<FSM, FSM> instances;

		public string successState;

		public string failureState;

		Graph IGraphAssignable.nestedGraph
		{
			get
			{
				return null;
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

		public FSM nestedFSM
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		Graph[] IGraphAssignable.GetInstances()
		{
			return null;
		}

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		private void OnFSMFinish(bool success)
		{
		}

		protected override void OnReset()
		{
		}

		public override void OnGraphPaused()
		{
		}

		public override void OnGraphStoped()
		{
		}

		private bool IsInstance(FSM fsm)
		{
			return false;
		}

		private void CheckInstance()
		{
		}
	}
}
