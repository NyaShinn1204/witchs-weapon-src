using System.Collections.Generic;
using System.Text;

namespace Pathfinding
{
	public class PathHandler
	{
		private ushort pathID;

		private BinaryHeapM heap;

		private const int BucketSizeLog2 = 10;

		private const int BucketSize = 1024;

		private const int BucketIndexMask = 1023;

		public PathNode[][] nodes;

		private bool[] bucketNew;

		private bool[] bucketCreated;

		private Stack<PathNode[]> bucketCache;

		private int filledBuckets;

		public readonly StringBuilder DebugStringBuilder;

		public ushort PathID
		{
			get
			{
				return 0;
			}
		}

		public void PushNode(PathNode node)
		{
		}

		public PathNode PopNode()
		{
			return null;
		}

		public BinaryHeapM GetHeap()
		{
			return null;
		}

		public void RebuildHeap()
		{
		}

		public bool HeapEmpty()
		{
			return false;
		}

		public void InitializeForPath(Path p)
		{
		}

		public void DestroyNode(GraphNode node)
		{
		}

		public void InitializeNode(GraphNode node)
		{
		}

		public PathNode GetPathNode(GraphNode node)
		{
			return null;
		}

		public void ClearPathIDs()
		{
		}
	}
}
