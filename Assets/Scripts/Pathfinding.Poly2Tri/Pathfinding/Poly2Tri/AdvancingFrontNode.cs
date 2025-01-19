namespace Pathfinding.Poly2Tri
{
	public class AdvancingFrontNode
	{
		public AdvancingFrontNode Next;

		public AdvancingFrontNode Prev;

		public double Value;

		public TriangulationPoint Point;

		public DelaunayTriangle Triangle;

		public bool HasNext
		{
			get
			{
				return false;
			}
		}

		public bool HasPrev
		{
			get
			{
				return false;
			}
		}

		public AdvancingFrontNode(TriangulationPoint point)
		{
		}
	}
}
