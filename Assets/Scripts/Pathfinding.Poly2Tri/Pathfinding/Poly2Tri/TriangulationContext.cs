using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Pathfinding.Poly2Tri
{
	public abstract class TriangulationContext
	{
		public readonly List<DelaunayTriangle> Triangles;

		public readonly List<TriangulationPoint> Points;

		[CompilerGenerated]
		private TriangulationDebugContext _003CDebugContext_003Ek__BackingField;

		[CompilerGenerated]
		private bool _003CIsDebugEnabled_003Ek__BackingField;

		public TriangulationDebugContext DebugContext
		{
			[CompilerGenerated]
			get
			{
				return _003CDebugContext_003Ek__BackingField;
			}
		}

		public TriangulationMode TriangulationMode { get; protected set; }

		public Triangulatable Triangulatable { get; private set; }

		public int StepCount { get; private set; }

		public abstract TriangulationAlgorithm Algorithm { get; }

		public virtual bool IsDebugEnabled
		{
			[CompilerGenerated]
			get
			{
				return _003CIsDebugEnabled_003Ek__BackingField;
			}
		}

		public DTSweepDebugContext DTDebugContext
		{
			get
			{
				return null;
			}
		}

		public void Done()
		{
		}

		public virtual void PrepareTriangulation(Triangulatable t)
		{
		}

		public abstract TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b);

		public void Update(string message)
		{
		}

		public virtual void Clear()
		{
		}
	}
}
