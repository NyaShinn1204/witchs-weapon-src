using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
	public class GraphUpdateObject
	{
		public Bounds bounds;

		public bool requiresFloodFill;

		public bool updatePhysics;

		public bool resetPenaltyOnPhysics;

		public bool updateErosion;

		public NNConstraint nnConstraint;

		public int addPenalty;

		public bool modifyWalkability;

		public bool setWalkability;

		public bool modifyTag;

		public int setTag;

		public bool trackChangedNodes;

		private List<GraphNode> changedNodes;

		private List<ulong> backupData;

		private List<Int3> backupPositionData;

		public GraphUpdateShape shape;

		public GraphUpdateObject()
		{
		}

		public GraphUpdateObject(Bounds b)
		{
		}

		public virtual void WillUpdateNode(GraphNode node)
		{
		}

		public virtual void RevertFromBackup()
		{
		}

		public virtual void Apply(GraphNode node)
		{
		}
	}
}
