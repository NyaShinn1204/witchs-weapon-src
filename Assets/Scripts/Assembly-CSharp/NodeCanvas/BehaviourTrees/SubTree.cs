using System.Collections.Generic;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	public class SubTree : BTNode, IGraphAssignable
	{
		[SerializeField]
		private BBParameter<BehaviourTree> _subTree;

		private Dictionary<BehaviourTree, BehaviourTree> instances;

		private bool onGraphStated;

		private bool isNeedStart;

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

		public BehaviourTree subTree
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

		protected override void OnReset()
		{
		}

		public override void OnGraphStoped()
		{
		}

		public override void OnGraphPaused()
		{
		}

		private bool IsInstance(BehaviourTree bt)
		{
			return false;
		}

		public new void PreExecute(BehaviourTree rootGraph)
		{
		}

		private void __PreCheckInstance(BehaviourTree rootGraph)
		{
		}

		private void CheckInstance(BehaviourTree rootGraph)
		{
		}

		private void TryStartAllNodes()
		{
		}

		public override void ResetProtectingParams()
		{
		}
	}
}
