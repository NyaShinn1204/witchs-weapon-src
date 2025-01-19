using System;
using System.Collections.Generic;
using Pathfinding.Serialization;
using Pathfinding.Serialization.JsonFx;
using Pathfinding.Voxels;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	[JsonOptIn]
	public class RecastGraph : NavGraph, INavmesh, IRaycastableGraph, IFunnelGraph, IUpdatableGraph, INavmeshHolder
	{
		public enum RelevantGraphSurfaceMode
		{
			DoNotRequire = 0,
			OnlyForCompletelyInsideTile = 1,
			RequireForAll = 2
		}

		public class NavmeshTile : INavmeshHolder, INavmesh
		{
			public int[] tris;

			public Int3[] verts;

			public int x;

			public int z;

			public int w;

			public int d;

			public TriangleMeshNode[] nodes;

			public BBTree bbTree;

			public bool flag;

			public void GetTileCoordinates(int tileIndex, out int x, out int z)
			{
				x = default(int);
				z = default(int);
			}

			public int GetVertexArrayIndex(int index)
			{
				return 0;
			}

			public Int3 GetVertex(int index)
			{
				return default(Int3);
			}

			public void GetNodes(GraphNodeDelegateCancelable del)
			{
			}
		}

		public struct SceneMesh
		{
			public Mesh mesh;

			public Matrix4x4 matrix;

			public Bounds bounds;
		}

		private class CapsuleCache
		{
			public int rows;

			public float height;

			public Vector3[] verts;

			public int[] tris;
		}

		public bool dynamic;

		[JsonMember]
		public float characterRadius;

		[JsonMember]
		public float contourMaxError;

		[JsonMember]
		public float cellSize;

		[JsonMember]
		public float cellHeight;

		[JsonMember]
		public float walkableHeight;

		[JsonMember]
		public float walkableClimb;

		[JsonMember]
		public float maxSlope;

		[JsonMember]
		public float maxEdgeLength;

		[JsonMember]
		public float minRegionSize;

		[JsonMember]
		public int editorTileSize;

		[JsonMember]
		public int tileSizeX;

		[JsonMember]
		public int tileSizeZ;

		[JsonMember]
		public bool nearestSearchOnlyXZ;

		[JsonMember]
		public bool useTiles;

		public bool scanEmptyGraph;

		[JsonMember]
		public RelevantGraphSurfaceMode relevantGraphSurfaceMode;

		[JsonMember]
		public bool rasterizeColliders;

		[JsonMember]
		public bool rasterizeMeshes;

		[JsonMember]
		public bool rasterizeTerrain;

		[JsonMember]
		public bool rasterizeTrees;

		[JsonMember]
		public float colliderRasterizeDetail;

		[JsonMember]
		public Vector3 forcedBoundsCenter;

		[JsonMember]
		public Vector3 forcedBoundsSize;

		[JsonMember]
		public LayerMask mask;

		[JsonMember]
		public List<string> tagMask;

		[JsonMember]
		public bool showMeshOutline;

		[JsonMember]
		public bool showNodeConnections;

		[JsonMember]
		public int terrainSampleSize;

		private Voxelize globalVox;

		private BBTree _bbTree;

		private Int3[] _vertices;

		private Vector3[] _vectorVertices;

		public TriangleMeshNode[] nodes;

		public int tileXCount;

		public int tileZCount;

		private NavmeshTile[] tiles;

		private bool batchTileUpdate;

		private List<int> batchUpdatedTiles;

		public const int VertexIndexMask = 4095;

		public const int TileIndexMask = 524287;

		public const int TileIndexOffset = 12;

		public const int BorderVertexMask = 1;

		public const int BorderVertexOffset = 31;

		private Dictionary<Int2, int> cachedInt2_int_dict;

		private Dictionary<Int3, int> cachedInt3_int_dict;

		private readonly int[] BoxColliderTris;

		private readonly Vector3[] BoxColliderVerts;

		private List<CapsuleCache> capsuleCache;

		public Bounds forcedBounds
		{
			get
			{
				return default(Bounds);
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

		public Vector3[] vectorVertices
		{
			get
			{
				return null;
			}
		}

		public TriangleMeshNode[] TriNodes
		{
			get
			{
				return null;
			}
		}

		public override void CreateNodes(int number)
		{
		}

		public Int3 GetVertex(int index)
		{
			return default(Int3);
		}

		public int GetTileIndex(int index)
		{
			return 0;
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

		public NavmeshTile[] GetTiles()
		{
			return null;
		}

		public Bounds GetTileBounds(int x, int z)
		{
			return default(Bounds);
		}

		public Bounds GetTileBounds(int x, int z, int width, int depth)
		{
			return default(Bounds);
		}

		public Int2 GetTileCoordinates(Vector3 p)
		{
			return default(Int2);
		}

		public override void OnDestroy()
		{
		}

		private static NavmeshTile NewEmptyTile(int x, int z)
		{
			return null;
		}

		public override void GetNodes(GraphNodeDelegateCancelable del)
		{
		}

		public Vector3 ClosestPointOnNode(TriangleMeshNode node, Vector3 pos)
		{
			return default(Vector3);
		}

		public bool ContainsPoint(TriangleMeshNode node, Vector3 pos)
		{
			return false;
		}

		public void SnapForceBoundsToScene()
		{
		}

		public void GetRecastMeshObjs(Bounds bounds, List<ExtraMesh> buffer)
		{
		}

		public List<ExtraMesh> GetSceneMeshes(Bounds bounds)
		{
			return null;
		}

		public IntRect GetTouchingTiles(Bounds b)
		{
			return default(IntRect);
		}

		public IntRect GetTouchingTilesRound(Bounds b)
		{
			return default(IntRect);
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

		public void ConnectTileWithNeighbours(NavmeshTile tile)
		{
		}

		public void RemoveConnectionsFromTile(NavmeshTile tile)
		{
		}

		public void RemoveConnectionsFromTo(NavmeshTile a, NavmeshTile b)
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

		public GraphNode PointOnNavmesh(Vector3 position, NNConstraint constraint)
		{
			return null;
		}

		public void BuildFunnelCorridor(List<GraphNode> path, int startIndex, int endIndex, List<Vector3> left, List<Vector3> right)
		{
		}

		public void AddPortal(GraphNode n1, GraphNode n2, List<Vector3> left, List<Vector3> right)
		{
		}

		public static string GetRecastPath()
		{
			return null;
		}

		public override void ScanInternal(OnScanStatus statusCallback)
		{
		}

		protected void ScanTiledNavmesh(OnScanStatus statusCallback)
		{
		}

		protected void ScanAllTiles(OnScanStatus statusCallback)
		{
		}

		protected void BuildTileMesh(Voxelize vox, int x, int z)
		{
		}

		private NavmeshTile CreateTile(Voxelize vox, VoxelMesh mesh, int x, int z)
		{
			return null;
		}

		private void CreateNodeConnections(TriangleMeshNode[] nodes)
		{
		}

		private void ConnectTiles(NavmeshTile tile1, NavmeshTile tile2)
		{
		}

		public void StartBatchTileUpdate()
		{
		}

		public void EndBatchTileUpdate()
		{
		}

		public void ReplaceTile(int x, int z, Int3[] verts, int[] tris, bool worldSpace)
		{
		}

		public void ReplaceTile(int x, int z, int w, int d, Int3[] verts, int[] tris, bool worldSpace)
		{
		}

		protected void ScanCRecast()
		{
		}

		private void CollectTreeMeshes(List<ExtraMesh> extraMeshes, Terrain terrain)
		{
		}

		private bool CollectMeshes(out List<ExtraMesh> extraMeshes, Bounds bounds)
		{
			extraMeshes = null;
			return false;
		}

		private ExtraMesh RasterizeCollider(Collider col)
		{
			return default(ExtraMesh);
		}

		private ExtraMesh RasterizeCollider(Collider col, Matrix4x4 localToWorldMatrix)
		{
			return default(ExtraMesh);
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

		public bool Linecast(Vector3 tmp_origin, Vector3 tmp_end, GraphNode hint, out GraphHitInfo hit, List<GraphNode> trace)
		{
			hit = default(GraphHitInfo);
			return false;
		}

		public override void OnDrawGizmos(bool drawNodes)
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
