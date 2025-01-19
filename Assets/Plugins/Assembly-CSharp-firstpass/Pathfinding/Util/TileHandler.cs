using System.Collections.Generic;
using Pathfinding.ClipperLib;
using Pathfinding.Poly2Tri;
using UnityEngine;

namespace Pathfinding.Util
{
	public class TileHandler
	{
		public class TileType
		{
			private Int3[] verts;

			private int[] tris;

			private Int3 offset;

			private int lastYOffset;

			private int lastRotation;

			private int width;

			private int depth;

			private static readonly int[] Rotations;

			public int Width
			{
				get
				{
					return 0;
				}
			}

			public int Depth
			{
				get
				{
					return 0;
				}
			}

			public TileType(Int3[] sourceVerts, int[] sourceTris, Int3 tileSize, Int3 centerOffset, int width = 1, int depth = 1)
			{
			}

			public TileType(Mesh source, Int3 tileSize, Int3 centerOffset, int width = 1, int depth = 1)
			{
			}

			public void Load(out Int3[] verts, out int[] tris, int rotation, int yoffset)
			{
				verts = null;
				tris = null;
			}
		}

		public enum CutMode
		{
			CutAll = 1,
			CutDual = 2,
			CutExtra = 4
		}

		private RecastGraph _graph;

		private List<TileType> tileTypes;

		private Clipper clipper;

		private int[] cached_int_array;

		private Dictionary<Int3, int> cached_Int3_int_dict;

		private Dictionary<Int2, int> cached_Int2_int_dict;

		private TileType[] activeTileTypes;

		private int[] activeTileRotations;

		private int[] activeTileOffsets;

		private bool[] reloadedInBatch;

		private bool isBatching;

		private const int CUT_ALL = 0;

		private const int CUT_DUAL = 1;

		private const int CUT_BREAK = 2;

		public RecastGraph graph
		{
			get
			{
				return null;
			}
		}

		public TileHandler(RecastGraph graph)
		{
		}

		public int GetActiveRotation(Int2 p)
		{
			return 0;
		}

		public TileType GetTileType(int index)
		{
			return null;
		}

		public int GetTileTypeCount()
		{
			return 0;
		}

		public TileType RegisterTileType(Mesh source, Int3 centerOffset, int width = 1, int depth = 1)
		{
			return null;
		}

		public void CreateTileTypesFromGraph()
		{
		}

		public bool StartBatchLoad()
		{
			return false;
		}

		public void EndBatchLoad()
		{
		}

		private void CutPoly(Int3[] verts, int[] tris, ref Int3[] outVertsArr, ref int[] outTrisArr, out int outVCount, out int outTCount, Int3[] extraShape, Int3 cuttingOffset, Bounds realBounds, CutMode mode = (CutMode)3, int perturbate = 0)
		{
			outVCount = default(int);
			outTCount = default(int);
		}

		private void DelaunayRefinement(Int3[] verts, int[] tris, ref int vCount, ref int tCount, bool delaunay, bool colinear, Int3 worldOffset)
		{
		}

		private Vector3 Point2D2V3(TriangulationPoint p)
		{
			return default(Vector3);
		}

		private Int3 IntPoint2Int3(IntPoint p)
		{
			return default(Int3);
		}

		public void ClearTile(int x, int z)
		{
		}

		public void ReloadInBounds(Bounds b)
		{
		}

		public void ReloadTile(int x, int z)
		{
		}

		public void CutShapeWithTile(int x, int z, Int3[] shape, ref Int3[] verts, ref int[] tris, out int vCount, out int tCount)
		{
			vCount = default(int);
			tCount = default(int);
		}

		protected static T[] ShrinkArray<T>(T[] arr, int newLength)
		{
			return null;
		}

		public void LoadTile(TileType tile, int x, int z, int rotation, int yoffset)
		{
		}
	}
}
