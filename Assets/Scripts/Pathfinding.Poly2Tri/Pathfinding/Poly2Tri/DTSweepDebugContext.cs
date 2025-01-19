namespace Pathfinding.Poly2Tri
{
	public class DTSweepDebugContext : TriangulationDebugContext
	{
		private DelaunayTriangle _primaryTriangle;

		private DelaunayTriangle _secondaryTriangle;

		private TriangulationPoint _activePoint;

		private AdvancingFrontNode _activeNode;

		private DTSweepConstraint _activeConstraint;

		public DelaunayTriangle PrimaryTriangle
		{
			set
			{
			}
		}

		public DelaunayTriangle SecondaryTriangle
		{
			set
			{
			}
		}

		public TriangulationPoint ActivePoint
		{
			set
			{
			}
		}

		public AdvancingFrontNode ActiveNode
		{
			set
			{
			}
		}

		public DTSweepConstraint ActiveConstraint
		{
			set
			{
			}
		}

		public override void Clear()
		{
		}
	}
}
