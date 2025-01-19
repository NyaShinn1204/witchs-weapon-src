using System.Collections.Generic;

namespace Pathfinding.Poly2Tri
{
	public class TriangulationPoint
	{
		public double X;

		public double Y;

		public List<DTSweepConstraint> Edges { get; private set; }

		public bool HasEdges
		{
			get
			{
				return false;
			}
		}

		public TriangulationPoint(double x, double y)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public void AddEdge(DTSweepConstraint e)
		{
		}
	}
}
