using System.Collections.Generic;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.StateMachines
{
	public class NestedBTState : FSMState, IGraphAssignable
	{
		public enum BTExecutionMode
		{
			Once = 0,
			Repeat = 1
		}

		public enum BTExitMode
		{
			StopAndRestart = 0,
			PauseAndResume = 1
		}

		[SerializeField]
		private BBParameter<BehaviourTree> _nestedBT;

		public BTExecutionMode executionMode;

		public BTExitMode exitMode;

		public string successEvent;

		public string failureEvent;

		private Dictionary<BehaviourTree, BehaviourTree> instances;

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

		public BehaviourTree nestedBT
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

		private void OnFinish(bool success)
		{
		}

		protected override void OnExit()
		{
		}

		protected override void OnPause()
		{
		}

		private bool IsInstance(BehaviourTree bt)
		{
			return false;
		}

		private void CheckInstance()
		{
		}
	}
}
