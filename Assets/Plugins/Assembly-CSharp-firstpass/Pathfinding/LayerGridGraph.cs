using Pathfinding.Serialization;
using Pathfinding.Serialization.JsonFx;
using UnityEngine;

namespace Pathfinding
{
	public class LayerGridGraph : GridGraph, IRaycastableGraph, IUpdatableGraph
	{
		public int[] nodeCellIndices;

		[JsonMember]
		public int layerCount;

		[JsonMember]
		public float mergeSpanRange;

		[JsonMember]
		public float characterHeight;

		public new LevelGridNode[] nodes;

		public override bool uniformWidthDepthGrid
		{
			get
			{
				return false;
			}
		}

		public override void OnDestroy()
		{
		}

		public new void RemoveGridGraphFromStatic()
		{
		}

		public override void GetNodes(GraphNodeDelegateCancelable del)
		{
		}

		public new void UpdateArea(GraphUpdateObject o)
		{
		}

		public override void ScanInternal(OnScanStatus status)
		{
		}

		public bool RecalculateCell(int x, int z, bool preserveExistingNodes)
		{
			return false;
		}

		public void AddLayers(int count)
		{
		}

		public virtual void UpdatePenalty(LevelGridNode node)
		{
		}

		public override void ErodeWalkableArea(int xmin, int zmin, int xmax, int zmax)
		{
		}

		public void CalculateConnections(GraphNode[] nodes, GraphNode node, int x, int z, int layerIndex)
		{
		}

		public override NNInfo GetNearest(Vector3 position, NNConstraint constraint, GraphNode hint = null)
		{
			return default(NNInfo);
		}

		private LevelGridNode GetNearestNode(Vector3 position, int x, int z, NNConstraint constraint)
		{
			return null;
		}

		public override NNInfo GetNearestForce(Vector3 position, NNConstraint constraint)
		{
			return default(NNInfo);
		}

		public new bool Linecast(Vector3 _a, Vector3 _b)
		{
			return false;
		}

		public new bool Linecast(Vector3 _a, Vector3 _b, GraphNode hint)
		{
			return false;
		}

		public new bool Linecast(Vector3 _a, Vector3 _b, GraphNode hint, out GraphHitInfo hit)
		{
			hit = default(GraphHitInfo);
			return false;
		}

		public new bool SnappedLinecast(Vector3 _a, Vector3 _b, GraphNode hint, out GraphHitInfo hit)
		{
			hit = default(GraphHitInfo);
			return false;
		}

		public bool CheckConnection(LevelGridNode node, int dir)
		{
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

		public override void PostDeserialization()
		{
		}
	}
}
