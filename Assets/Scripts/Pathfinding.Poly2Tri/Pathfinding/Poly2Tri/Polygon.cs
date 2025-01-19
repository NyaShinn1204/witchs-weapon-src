using System.Collections.Generic;

namespace Pathfinding.Poly2Tri
{
	public class Polygon : Triangulatable
	{
		protected List<TriangulationPoint> _points;

		protected List<TriangulationPoint> _steinerPoints;

		protected List<Polygon> _holes;

		protected List<DelaunayTriangle> _triangles;

		protected PolygonPoint _last;

		public TriangulationMode TriangulationMode
		{
			get
			{
				return default(TriangulationMode);
			}
		}

		public IList<TriangulationPoint> Points
		{
			get
			{
				return null;
			}
		}

		public IList<DelaunayTriangle> Triangles
		{
			get
			{
				return null;
			}
		}

		public IList<Polygon> Holes
		{
			get
			{
				return null;
			}
		}

		public Polygon(IList<PolygonPoint> points)
		{
		}

		public void AddHole(Polygon poly)
		{
		}

		public void AddPoints(IEnumerable<PolygonPoint> list)
		{
		}

		public void AddTriangle(DelaunayTriangle t)
		{
		}

		public void AddTriangles(IEnumerable<DelaunayTriangle> list)
		{
		}

		public void ClearTriangles()
		{
		}

		public void Prepare(TriangulationContext tcx)
		{
		}
	}
}
