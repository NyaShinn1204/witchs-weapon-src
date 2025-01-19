namespace Pathfinding
{
	public class BinaryHeapM
	{
		private struct Tuple
		{
			public uint F;

			public PathNode node;

			public Tuple(uint F, PathNode node)
			{
				this.F = 0u;
				this.node = null;
			}
		}

		public int numberOfItems;

		public float growthFactor;

		public const int D = 4;

		private Tuple[] binaryHeap;

		public BinaryHeapM(int numberOfElements)
		{
		}

		public void Clear()
		{
		}

		public PathNode GetNode(int i)
		{
			return null;
		}

		public void Add(PathNode node)
		{
		}

		public PathNode Remove()
		{
			return null;
		}

		private void Validate()
		{
		}

		public void Rebuild()
		{
		}
	}
}
