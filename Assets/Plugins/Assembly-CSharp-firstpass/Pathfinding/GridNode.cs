using System;
using System.Collections.Generic;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding
{
	public class GridNode : GraphNode
	{
		private static GridGraph[] _gridGraphs;

		public GraphNode[] connections;

		public uint[] connectionCosts;

		protected int nodeInGridIndex;

		protected ushort gridFlags;

		private const int GridFlagsConnectionOffset = 0;

		private const int GridFlagsConnectionBit0 = 1;

		private const int GridFlagsConnectionMask = 255;

		private const int GridFlagsWalkableErosionOffset = 8;

		private const int GridFlagsWalkableErosionMask = 256;

		private const int GridFlagsWalkableTmpOffset = 9;

		private const int GridFlagsWalkableTmpMask = 512;

		private const int GridFlagsEdgeNodeOffset = 10;

		private const int GridFlagsEdgeNodeMask = 1024;

		public bool EdgeNode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool WalkableErosion
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool TmpWalkable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int NodeInGridIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public GridNode(AstarPath astar)
			: base(null)
		{
		}

		public static GridGraph GetGridGraph(uint graphIndex)
		{
			return null;
		}

		public static void SetGridGraph(int graphIndex, GridGraph graph)
		{
		}

		[Obsolete]
		public int GetIndex()
		{
			return 0;
		}

		public bool GetConnectionInternal(int dir)
		{
			return false;
		}

		public void SetConnectionInternal(int dir, bool value)
		{
		}

		public void ResetConnectionsInternal()
		{
		}

		public override void ClearConnections(bool alsoReverse)
		{
		}

		public override void GetConnections(GraphNodeDelegate del)
		{
		}

		public override bool GetPortal(GraphNode other, List<Vector3> left, List<Vector3> right, bool backwards)
		{
			return false;
		}

		public override void FloodFill(Stack<GraphNode> stack, uint region)
		{
		}

		public override void AddConnection(GraphNode node, uint cost)
		{
		}

		public override void RemoveConnection(GraphNode node)
		{
		}

		public override void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		public override void Open(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		public override void SerializeNode(GraphSerializationContext ctx)
		{
		}

		public override void DeserializeNode(GraphSerializationContext ctx)
		{
		}
	}
}
