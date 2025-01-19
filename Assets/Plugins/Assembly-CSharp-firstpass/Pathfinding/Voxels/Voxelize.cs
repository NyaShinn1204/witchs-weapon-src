using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding.Voxels
{
	public class Voxelize
	{
		private static List<int[]> intArrCache;

		private static readonly int[] emptyArr;

		public List<ExtraMesh> inputExtraMeshes;

		protected Vector3[] inputVertices;

		protected int[] inputTriangles;

		public readonly int voxelWalkableClimb;

		public readonly uint voxelWalkableHeight;

		public readonly float cellSize;

		public readonly float cellHeight;

		public int minRegionSize;

		public int borderSize;

		public float maxEdgeLength;

		public float maxSlope;

		public RecastGraph.RelevantGraphSurfaceMode relevantGraphSurfaceMode;

		public Bounds forcedBounds;

		public VoxelArea voxelArea;

		public VoxelContourSet countourSet;

		public int width;

		public int depth;

		public Vector3 voxelOffset;

		public const uint NotConnected = 63u;

		public const int MaxLayers = 65535;

		public const int MaxRegions = 500;

		public const int UnwalkableArea = 0;

		public const ushort BorderReg = 32768;

		public const int RC_BORDER_VERTEX = 65536;

		public const int RC_AREA_BORDER = 131072;

		public const int VERTEX_BUCKET_COUNT = 4096;

		public const int RC_CONTOUR_TESS_WALL_EDGES = 1;

		public const int RC_CONTOUR_TESS_AREA_EDGES = 2;

		public const int ContourRegMask = 65535;

		public string debugString;

		public readonly Vector3 cellScale;

		public readonly Vector3 cellScaleDivision;

		public Voxelize(float ch, float cs, float wc, float wh, float ms)
		{
		}

		public void BuildContours(float maxError, int maxEdgeLength, VoxelContourSet cset, int buildFlags)
		{
		}

		private void GetClosestIndices(int[] vertsa, int nvertsa, int[] vertsb, int nvertsb, ref int ia, ref int ib)
		{
		}

		private static void ReleaseIntArr(int[] arr)
		{
		}

		private static int[] ClaimIntArr(int minCapacity, bool zero)
		{
			return null;
		}

		private static void ReleaseContours(VoxelContourSet cset)
		{
		}

		public static bool MergeContours(ref VoxelContour ca, ref VoxelContour cb, int ia, int ib)
		{
			return false;
		}

		public void SimplifyContour(List<int> verts, List<int> simplified, float maxError, int maxEdgeLenght, int buildFlags)
		{
		}

		public void WalkContour(int x, int z, int i, ushort[] flags, List<int> verts)
		{
		}

		public int GetCornerHeight(int x, int z, int i, int dir, ref bool isBorderVertex)
		{
			return 0;
		}

		public void RemoveDegenerateSegments(List<int> simplified)
		{
		}

		public int CalcAreaOfPolygon2D(int[] verts, int nverts)
		{
			return 0;
		}

		public static bool Ileft(int a, int b, int c, int[] va, int[] vb, int[] vc)
		{
			return false;
		}

		public static bool Diagonal(int i, int j, int n, int[] verts, int[] indices)
		{
			return false;
		}

		public static bool InCone(int i, int j, int n, int[] verts, int[] indices)
		{
			return false;
		}

		public static bool Left(int a, int b, int c, int[] verts)
		{
			return false;
		}

		public static bool LeftOn(int a, int b, int c, int[] verts)
		{
			return false;
		}

		public static bool Collinear(int a, int b, int c, int[] verts)
		{
			return false;
		}

		public static int Area2(int a, int b, int c, int[] verts)
		{
			return 0;
		}

		private static bool Diagonalie(int i, int j, int n, int[] verts, int[] indices)
		{
			return false;
		}

		public static bool Xorb(bool x, bool y)
		{
			return false;
		}

		public static bool IntersectProp(int a, int b, int c, int d, int[] verts)
		{
			return false;
		}

		private static bool Between(int a, int b, int c, int[] verts)
		{
			return false;
		}

		private static bool Intersect(int a, int b, int c, int d, int[] verts)
		{
			return false;
		}

		private static bool Vequal(int a, int b, int[] verts)
		{
			return false;
		}

		public static int Prev(int i, int n)
		{
			return 0;
		}

		public static int Next(int i, int n)
		{
			return 0;
		}

		public void BuildPolyMesh(VoxelContourSet cset, int nvp, out VoxelMesh mesh)
		{
			mesh = default(VoxelMesh);
		}

		public int Triangulate(int n, int[] verts, ref int[] indices, ref int[] tris)
		{
			return 0;
		}

		public Vector3 CompactSpanToVector(int x, int z, int i)
		{
			return default(Vector3);
		}

		public void VectorToIndex(Vector3 p, out int x, out int z)
		{
			x = default(int);
			z = default(int);
		}

		public void OnGUI()
		{
		}

		public void CollectMeshes()
		{
		}

		public static void CollectMeshes(List<ExtraMesh> extraMeshes, Bounds bounds, out Vector3[] verts, out int[] tris)
		{
			verts = null;
			tris = null;
		}

		public void Init()
		{
		}

		public void VoxelizeInput()
		{
		}

		public void BuildCompactField()
		{
		}

		public void BuildVoxelConnections()
		{
		}

		public void DrawLine(int a, int b, int[] indices, int[] verts, Color col)
		{
		}

		public Vector3 ConvertPos(int x, int y, int z)
		{
			return default(Vector3);
		}

		public Vector3 ConvertPosCorrZ(int x, int y, int z)
		{
			return default(Vector3);
		}

		public Vector3 ConvertPosWithoutOffset(int x, int y, int z)
		{
			return default(Vector3);
		}

		public Vector3 ConvertPosition(int x, int z, int i)
		{
			return default(Vector3);
		}

		public void ErodeWalkableArea(int radius)
		{
		}

		public void BuildDistanceField()
		{
		}

		[Obsolete]
		public void ErodeVoxels(int radius)
		{
		}

		public void FilterLowHeightSpans(uint voxelWalkableHeight, float cs, float ch, Vector3 min)
		{
		}

		public void FilterLedges(uint voxelWalkableHeight, int voxelWalkableClimb, float cs, float ch, Vector3 min)
		{
		}

		public ushort[] ExpandRegions(int maxIterations, uint level, ushort[] srcReg, ushort[] srcDist, ushort[] dstReg, ushort[] dstDist, List<int> stack)
		{
			return null;
		}

		public bool FloodRegion(int x, int z, int i, uint level, ushort r, ushort[] srcReg, ushort[] srcDist, List<int> stack)
		{
			return false;
		}

		public void MarkRectWithRegion(int minx, int maxx, int minz, int maxz, ushort region, ushort[] srcReg)
		{
		}

		public ushort CalculateDistanceField(ushort[] src)
		{
			return 0;
		}

		public ushort[] BoxBlur(ushort[] src, ushort[] dst)
		{
			return null;
		}

		private void FloodOnes(List<Int3> st1, ushort[] regs, uint level, ushort reg)
		{
		}

		public void BuildRegions()
		{
		}

		private static int union_find_find(int[] arr, int x)
		{
			return 0;
		}

		private static void union_find_union(int[] arr, int a, int b)
		{
		}

		public void FilterSmallRegions(ushort[] reg, int minRegionSize, int maxRegions)
		{
		}
	}
}
