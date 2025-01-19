using System.Collections.Generic;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding
{
	public class LevelGridNode : GraphNode
	{
		private const int GridFlagsWalkableErosionOffset = 8;

		private const int GridFlagsWalkableErosionMask = 256;

		private const int GridFlagsWalkableTmpOffset = 9;

		private const int GridFlagsWalkableTmpMask = 512;

		private static LayerGridGraph[] _gridGraphs;

		protected ushort gridFlags;

		protected int nodeInGridIndex;

		protected uint gridConnections;

		protected static LayerGridGraph[] gridGraphs;

		public const int NoConnection = 255;

		public const int ConnectionMask = 255;

		private const int ConnectionStride = 8;

		public const int MaxLayerCount = 255;

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

		public LevelGridNode(AstarPath astar)
			: base(null)
		{
		}

		public static LayerGridGraph GetGridGraph(uint graphIndex)
		{
			return null;
		}

		public static void SetGridGraph(int graphIndex, LayerGridGraph graph)
		{
		}

		public void ResetAllGridConnections()
		{
		}

		public bool HasAnyGridConnections()
		{
			return false;
		}

		public void SetPosition(Int3 position)
		{
		}

		public override void ClearConnections(bool alsoReverse)
		{
		}

		public override void GetConnections(GraphNodeDelegate del)
		{
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

		public bool GetConnection(int i)
		{
			return false;
		}

		public void SetConnectionValue(int dir, int value)
		{
		}

		public int GetConnectionValue(int dir)
		{
			return 0;
		}

		public override bool GetPortal(GraphNode other, List<Vector3> left, List<Vector3> right, bool backwards)
		{
			return false;
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
