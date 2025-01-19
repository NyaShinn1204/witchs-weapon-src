using System.Runtime.CompilerServices;

namespace Pathfinding.Poly2Tri
{
	public class PolygonPoint : TriangulationPoint
	{
		[CompilerGenerated]
		private PolygonPoint _003CPrevious_003Ek__BackingField;

		public PolygonPoint Next { get; set; }

		public PolygonPoint Previous
		{
			[CompilerGenerated]
			set
			{
				_003CPrevious_003Ek__BackingField = value;
			}
		}

		public PolygonPoint(double x, double y)
			: base(0.0, 0.0)
		{
		}
	}
}
