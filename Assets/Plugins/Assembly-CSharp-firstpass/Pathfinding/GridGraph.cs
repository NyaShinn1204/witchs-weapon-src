using System;
using System.Collections.Generic;
using Pathfinding.Serialization;
using Pathfinding.Serialization.JsonFx;
using UnityEngine;

namespace Pathfinding
{
	[JsonOptIn]
	public class GridGraph : NavGraph, IUpdatableGraph, IRaycastableGraph
	{
		public class TextureData
		{
			public enum ChannelUse
			{
				None = 0,
				Penalty = 1,
				Position = 2,
				WalkablePenalty = 3
			}

			public bool enabled;

			public Texture2D source;

			public float[] factors;

			public ChannelUse[] channels;

			private Color32[] data;

			public void Initialize()
			{
			}

			public void Apply(GridNode node, int x, int z)
			{
			}

			private void ApplyChannel(GridNode node, int x, int z, int value, ChannelUse channelUse, float factor)
			{
			}
		}

		public int width;

		public int depth;

		[JsonMember]
		public float aspectRatio;

		[JsonMember]
		public Vector3 rotation;

		public Bounds bounds;

		[JsonMember]
		public Vector3 center;

		[JsonMember]
		public Vector2 unclampedSize;

		[JsonMember]
		public float nodeSize;

		[JsonMember]
		public GraphCollision collision;

		[JsonMember]
		public float maxClimb;

		[JsonMember]
		public int maxClimbAxis;

		[JsonMember]
		public float maxSlope;

		[JsonMember]
		public int erodeIterations;

		[JsonMember]
		public bool erosionUseTags;

		[JsonMember]
		public int erosionFirstTag;

		[JsonMember]
		public bool autoLinkGrids;

		[JsonMember]
		public float autoLinkDistLimit;

		[JsonMember]
		public NumNeighbours neighbours;

		[JsonMember]
		public bool cutCorners;

		[JsonMember]
		public float penaltyPositionOffset;

		[JsonMember]
		public bool penaltyPosition;

		[JsonMember]
		public float penaltyPositionFactor;

		[JsonMember]
		public bool penaltyAngle;

		[JsonMember]
		public float penaltyAngleFactor;

		[JsonMember]
		public TextureData textureData;

		public Vector2 size;

		[NonSerialized]
		public readonly int[] neighbourOffsets;

		[NonSerialized]
		public readonly uint[] neighbourCosts;

		[NonSerialized]
		public readonly int[] neighbourXOffsets;

		[NonSerialized]
		public readonly int[] neighbourZOffsets;

		public const int getNearestForceOverlap = 2;

		public Matrix4x4 boundsMatrix;

		public Matrix4x4 boundsMatrix2;

		public int scans;

		public GridNode[] nodes;

		[NonSerialized]
		protected int[] corners;

		public virtual bool uniformWidthDepthGrid
		{
			get
			{
				return false;
			}
		}

		public bool useRaycastNormal
		{
			get
			{
				return false;
			}
		}

		public int Width
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Depth
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override void OnDestroy()
		{
		}

		public void RemoveGridGraphFromStatic()
		{
		}

		public override void GetNodes(GraphNodeDelegateCancelable del)
		{
		}

		public Int3 GetNodePosition(int index, int yOffset)
		{
			return default(Int3);
		}

		public uint GetConnectionCost(int dir)
		{
			return 0u;
		}

		public GridNode GetNodeConnection(GridNode node, int dir)
		{
			return null;
		}

		public bool HasNodeConnection(GridNode node, int dir)
		{
			return false;
		}

		public void SetNodeConnection(GridNode node, int dir, bool value)
		{
		}

		private GridNode GetNodeConnection(int index, int x, int z, int dir)
		{
			return null;
		}

		public void SetNodeConnection(int index, int x, int z, int dir, bool value)
		{
		}

		public bool HasNodeConnection(int index, int x, int z, int dir)
		{
			return false;
		}

		public void UpdateSizeFromWidthDepth()
		{
		}

		public void GenerateMatrix()
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

		public virtual void SetUpOffsetsAndCosts()
		{
		}

		public override void ScanInternal(OnScanStatus statusCallback)
		{
		}

		public virtual void UpdateNodePositionCollision(GridNode node, int x, int z, bool resetPenalty = true)
		{
		}

		public virtual void ErodeWalkableArea()
		{
		}

		public virtual void ErodeWalkableArea(int xmin, int zmin, int xmax, int zmax)
		{
		}

		public virtual bool IsValidConnection(GridNode n1, GridNode n2)
		{
			return false;
		}

		public static void CalculateConnections(GridNode node)
		{
		}

		public virtual void CalculateConnections(GridNode[] nodes, int x, int z, GridNode node)
		{
		}

		public void OnPostScan(AstarPath script)
		{
		}

		public override void OnDrawGizmos(bool drawNodes)
		{
		}

		public void GetBoundsMinMax(Bounds b, Matrix4x4 matrix, out Vector3 min, out Vector3 max)
		{
			min = default(Vector3);
			max = default(Vector3);
		}

		public List<GraphNode> GetNodesInArea(Bounds b)
		{
			return null;
		}

		public List<GraphNode> GetNodesInArea(GraphUpdateShape shape)
		{
			return null;
		}

		private List<GraphNode> GetNodesInArea(Bounds b, GraphUpdateShape shape)
		{
			return null;
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

		public bool Linecast(Vector3 _a, Vector3 _b)
		{
			return false;
		}

		public bool Linecast(Vector3 _a, Vector3 _b, GraphNode hint)
		{
			return false;
		}

		public bool Linecast(Vector3 _a, Vector3 _b, GraphNode hint, out GraphHitInfo hit)
		{
			hit = default(GraphHitInfo);
			return false;
		}

		public bool Linecast(Vector3 _a, Vector3 _b, GraphNode hint, out GraphHitInfo hit, List<GraphNode> trace)
		{
			hit = default(GraphHitInfo);
			return false;
		}

		public bool SnappedLinecast(Vector3 _a, Vector3 _b, GraphNode hint, out GraphHitInfo hit)
		{
			hit = default(GraphHitInfo);
			return false;
		}

		public bool CheckConnection(GridNode node, int dir)
		{
			return false;
		}

		public override void SerializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		public override void DeserializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		public override void PostDeserialization()
		{
		}
	}
}
