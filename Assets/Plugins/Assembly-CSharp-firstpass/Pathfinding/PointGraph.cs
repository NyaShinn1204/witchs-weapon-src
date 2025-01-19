using System.Collections.Generic;
using Pathfinding.Serialization;
using Pathfinding.Serialization.JsonFx;
using UnityEngine;

namespace Pathfinding
{
	[JsonOptIn]
	public class PointGraph : NavGraph, IUpdatableGraph
	{
		[JsonMember]
		public Transform root;

		[JsonMember]
		public string searchTag;

		[JsonMember]
		public float maxDistance;

		[JsonMember]
		public Vector3 limits;

		[JsonMember]
		public bool raycast;

		[JsonMember]
		public bool thickRaycast;

		[JsonMember]
		public float thickRaycastRadius;

		[JsonMember]
		public bool recursive;

		[JsonMember]
		public bool autoLinkNodes;

		[JsonMember]
		public LayerMask mask;

		[JsonMember]
		public bool optimizeForSparseGraph;

		[JsonMember]
		public bool optimizeFor2D;

		private static readonly Int3[] ThreeDNeighbours;

		private Dictionary<Int3, PointNode> nodeLookup;

		private Int3 minLookup;

		private Int3 maxLookup;

		private Int3 lookupCellSize;

		private GameObject[] nodeGameObjects;

		public PointNode[] nodes;

		public int nodeCount;

		private Int3 WorldToLookupSpace(Int3 p)
		{
			return default(Int3);
		}

		public override void GetNodes(GraphNodeDelegateCancelable del)
		{
		}

		public override NNInfo GetNearest(Vector3 position, NNConstraint constraint, GraphNode hint)
		{
			return default(NNInfo);
		}

		public override NNInfo GetNearestForce(Vector3 position, NNConstraint constraint)
		{
			return default(NNInfo);
		}

		public PointNode AddNode(Int3 position)
		{
			return null;
		}

		public T AddNode<T>(T nd, Int3 position) where T : PointNode
		{
			return null;
		}

		public static int CountChildren(Transform tr)
		{
			return 0;
		}

		public void AddChildren(ref int c, Transform tr)
		{
		}

		public void RebuildNodeLookup()
		{
		}

		public void AddToLookup(PointNode node)
		{
		}

		public override void ScanInternal(OnScanStatus statusCallback)
		{
		}

		public virtual bool IsValidConnection(GraphNode a, GraphNode b, out float dist)
		{
			dist = default(float);
			return false;
		}

		public GraphUpdateThreading CanUpdateAsync(GraphUpdateObject o)
		{
			return default(GraphUpdateThreading);
		}

		public void UpdateAreaInit(GraphUpdateObject o)
		{
		}

		public void UpdateArea(GraphUpdateObject guo)
		{
		}

		public override void PostDeserialization()
		{
		}

		public override void RelocateNodes(Matrix4x4 oldMatrix, Matrix4x4 newMatrix)
		{
		}

		public override void SerializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		public override void DeserializeExtraInfo(GraphSerializationContext ctx)
		{
		}
	}
}
