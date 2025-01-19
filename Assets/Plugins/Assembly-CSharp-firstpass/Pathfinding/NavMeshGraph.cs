using System;
using System.Collections.Generic;
using Pathfinding.Serialization;
using Pathfinding.Serialization.JsonFx;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	[JsonOptIn]
	public class NavMeshGraph : NavGraph, INavmesh, IUpdatableGraph, IFunnelGraph, INavmeshHolder, IRaycastableGraph
	{
		[JsonMember]
		public Mesh sourceMesh;

		[JsonMember]
		public Vector3 offset;

		[JsonMember]
		public Vector3 rotation;

		[JsonMember]
		public float scale;

		[JsonMember]
		public bool accurateNearestNode;

		public TriangleMeshNode[] nodes;

		private BBTree _bbTree;

		[NonSerialized]
		private Int3[] _vertices;

		[NonSerialized]
		private Vector3[] originalVertices;

		[NonSerialized]
		public int[] triangles;

		public TriangleMeshNode[] TriNodes
		{
			get
			{
				return null;
			}
		}

		public BBTree bbTree
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Int3[] vertices
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void CreateNodes(int number)
		{
		}

		public override void GetNodes(GraphNodeDelegateCancelable del)
		{
		}

		public override void OnDestroy()
		{
		}

		public Int3 GetVertex(int index)
		{
			return default(Int3);
		}

		public int GetVertexArrayIndex(int index)
		{
			return 0;
		}

		public void GetTileCoordinates(int tileIndex, out int x, out int z)
		{
			x = default(int);
			z = default(int);
		}

		public void GenerateMatrix()
		{
		}

		public override void RelocateNodes(Matrix4x4 oldMatrix, Matrix4x4 newMatrix)
		{
		}

		public static NNInfo GetNearest(NavMeshGraph graph, GraphNode[] nodes, Vector3 position, NNConstraint constraint, bool accurateNearestNode)
		{
			return default(NNInfo);
		}

		public override NNInfo GetNearest(Vector3 position, NNConstraint constraint, GraphNode hint)
		{
			return default(NNInfo);
		}

		public override NNInfo GetNearestForce(Vector3 position, NNConstraint constraint)
		{
			return default(NNInfo);
		}

		public static NNInfo GetNearestForce(NavGraph graph, INavmeshHolder navmesh, Vector3 position, NNConstraint constraint, bool accurateNearestNode)
		{
			return default(NNInfo);
		}

		public static NNInfo GetNearestForceBoth(NavGraph graph, INavmeshHolder navmesh, Vector3 position, NNConstraint constraint, bool accurateNearestNode)
		{
			return default(NNInfo);
		}

		public void BuildFunnelCorridor(List<GraphNode> path, int startIndex, int endIndex, List<Vector3> left, List<Vector3> right)
		{
		}

		public static void BuildFunnelCorridor(INavmesh graph, List<GraphNode> path, int startIndex, int endIndex, List<Vector3> left, List<Vector3> right)
		{
		}

		public void AddPortal(GraphNode n1, GraphNode n2, List<Vector3> left, List<Vector3> right)
		{
		}

		public bool Linecast(Vector3 origin, Vector3 end)
		{
			return false;
		}

		public bool Linecast(Vector3 origin, Vector3 end, GraphNode hint, out GraphHitInfo hit)
		{
			hit = default(GraphHitInfo);
			return false;
		}

		public bool Linecast(Vector3 origin, Vector3 end, GraphNode hint)
		{
			return false;
		}

		public bool Linecast(Vector3 origin, Vector3 end, GraphNode hint, out GraphHitInfo hit, List<GraphNode> trace)
		{
			hit = default(GraphHitInfo);
			return false;
		}

		public static bool Linecast(INavmesh graph, Vector3 tmp_origin, Vector3 tmp_end, GraphNode hint, out GraphHitInfo hit)
		{
			hit = default(GraphHitInfo);
			return false;
		}

		public static bool Linecast(INavmesh graph, Vector3 tmp_origin, Vector3 tmp_end, GraphNode hint, out GraphHitInfo hit, List<GraphNode> trace)
		{
			hit = default(GraphHitInfo);
			return false;
		}

		public GraphUpdateThreading CanUpdateAsync(GraphUpdateObject o)
		{
			return default(GraphUpdateThreading);
		}

		public void UpdateAreaInit(GraphUpdateObject o)
		{
		}

		public void UpdateArea(GraphUpdateObject o)
		{
		}

		public static void UpdateArea(GraphUpdateObject o, INavmesh graph)
		{
		}

		public static Vector3 ClosestPointOnNode(TriangleMeshNode node, Int3[] vertices, Vector3 pos)
		{
			return default(Vector3);
		}

		public bool ContainsPoint(TriangleMeshNode node, Vector3 pos)
		{
			return false;
		}

		public static bool ContainsPoint(TriangleMeshNode node, Vector3 pos, Int3[] vertices)
		{
			return false;
		}

		public void ScanInternal(string objMeshPath)
		{
		}

		public override void ScanInternal(OnScanStatus statusCallback)
		{
		}

		public void GenerateNodes(Vector3[] vectorVertices, int[] triangles, out Vector3[] originalVertices, out Int3[] vertices)
		{
			originalVertices = null;
			vertices = null;
		}

		public static void RebuildBBTree(NavMeshGraph graph)
		{
		}

		public void PostProcess()
		{
		}

		public void Sort(Vector3[] a)
		{
		}

		public override void OnDrawGizmos(bool drawNodes)
		{
		}

		public override void DeserializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		public override void SerializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		public static void DeserializeMeshNodes(NavMeshGraph graph, GraphNode[] nodes, byte[] bytes)
		{
		}
	}
}
