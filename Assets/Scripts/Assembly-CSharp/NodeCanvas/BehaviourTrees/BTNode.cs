using System;
using System.Collections.Generic;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	public abstract class BTNode : Node
	{
		protected int isNodeInProtectCounter;

		public bool enableProtect;

		public sealed override Type outConnectionType
		{
			get
			{
				return null;
			}
		}

		public sealed override int maxInConnections
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

		public sealed override bool allowAsPrime
		{
			get
			{
				return false;
			}
		}

		public override bool showCommentsBottom
		{
			get
			{
				return false;
			}
		}

		protected bool isNodeInProtect
		{
			get
			{
				return false;
			}
		}

		public BehaviourTree btGraph
		{
			get
			{
				return null;
			}
		}

		public T AddChild<T>(int childIndex) where T : BTNode
		{
			return null;
		}

		public T AddChild<T>() where T : BTNode
		{
			return null;
		}

		public List<BTNode> GetAllChildNodesRecursively(bool includeThis)
		{
			return null;
		}

		public Dictionary<BTNode, int> GetAllChildNodesWithDepthRecursively(bool includeThis, int startIndex)
		{
			return null;
		}

		public virtual void PreExecute(BehaviourTree rootGraph)
		{
		}

		public override Status Execute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		public void NotifyParentNodeInProtectBegin()
		{
		}

		public void NotifyParentNodeInProtectEnd()
		{
		}

		public virtual void ResetProtectingParams()
		{
		}
	}
}
