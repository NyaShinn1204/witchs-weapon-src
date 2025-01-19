using System.Collections.Generic;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.StateMachines
{
	public class NestedFSMState : FSMState, IGraphAssignable
	{
		[SerializeField]
		protected BBParameter<FSM> _nestedFSM;

		private Dictionary<FSM, FSM> instances;

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

		protected override void OnEnter()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnExit()
		{
		}

		protected override void OnPause()
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
