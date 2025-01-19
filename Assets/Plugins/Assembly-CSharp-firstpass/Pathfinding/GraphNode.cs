using System;
using System.Collections.Generic;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding
{
	public abstract class GraphNode
	{
		private int nodeIndex;

		protected uint flags;

		private uint penalty;

		public Int3 position;

		private const int FlagsWalkableOffset = 0;

		private const uint FlagsWalkableMask = 1u;

		private const int FlagsAreaOffset = 1;

		private const uint FlagsAreaMask = 131070u;

		private const int FlagsGraphOffset = 17;

		private const uint FlagsGraphMask = 393216u;

		public const uint MaxRegionCount = 65535u;

		public const uint MaxGraphCount = 3u;

		private const int FlagsTagOffset = 19;

		private const uint FlagsTagMask = 16252928u;

		[Obsolete]
		public Int3 Position
		{
			get
			{
				return default(Int3);
			}
		}

		[Obsolete]
		public bool walkable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete]
		public uint tags
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		[Obsolete]
		public uint graphIndex
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public bool Destroyed
		{
			get
			{
				return false;
			}
		}

		public int NodeIndex
		{
			get
			{
				return 0;
			}
		}

		public uint Flags
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint Penalty
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public bool Walkable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public uint Area
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint GraphIndex
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint Tag
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public GraphNode(AstarPath astar)
		{
		}

		public void Destroy()
		{
		}

		public void UpdateG(Path path, PathNode pathNode)
		{
		}

		public virtual void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		public virtual void FloodFill(Stack<GraphNode> stack, uint region)
		{
		}

		public abstract void GetConnections(GraphNodeDelegate del);

		public abstract void AddConnection(GraphNode node, uint cost);

		public abstract void RemoveConnection(GraphNode node);

		public abstract void ClearConnections(bool alsoReverse);

		public virtual bool ContainsConnection(GraphNode node)
		{
			return false;
		}

		public virtual void RecalculateConnectionCosts()
		{
		}

		public virtual bool GetPortal(GraphNode other, List<Vector3> left, List<Vector3> right, bool backwards)
		{
			return false;
		}

		public abstract void Open(Path path, PathNode pathNode, PathHandler handler);

		public virtual void SerializeNode(GraphSerializationContext ctx)
		{
		}

		public virtual void DeserializeNode(GraphSerializationContext ctx)
		{
		}

		public virtual void SerializeReferences(GraphSerializationContext ctx)
		{
		}

		public virtual void DeserializeReferences(GraphSerializationContext ctx)
		{
		}
	}
}
