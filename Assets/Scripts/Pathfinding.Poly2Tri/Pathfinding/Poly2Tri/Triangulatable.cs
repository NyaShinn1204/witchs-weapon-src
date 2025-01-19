using System.Collections.Generic;

namespace Pathfinding.Poly2Tri
{
	public interface Triangulatable
	{
		TriangulationMode TriangulationMode { get; }

		void Prepare(TriangulationContext tcx);

		void AddTriangle(DelaunayTriangle t);

		void AddTriangles(IEnumerable<DelaunayTriangle> list);
	}
}
