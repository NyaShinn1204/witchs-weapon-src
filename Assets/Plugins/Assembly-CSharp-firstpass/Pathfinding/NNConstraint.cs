namespace Pathfinding
{
	public class NNConstraint
	{
		public int graphMask;

		public bool constrainArea;

		public int area;

		public bool constrainWalkability;

		public bool walkable;

		public bool distanceXZ;

		public bool constrainTags;

		public int tags;

		public bool constrainDistance;

		public static NNConstraint Default
		{
			get
			{
				return null;
			}
		}

		public static NNConstraint None
		{
			get
			{
				return null;
			}
		}

		public virtual bool SuitableGraph(int graphIndex, NavGraph graph)
		{
			return false;
		}

		public virtual bool Suitable(GraphNode node)
		{
			return false;
		}
	}
}
