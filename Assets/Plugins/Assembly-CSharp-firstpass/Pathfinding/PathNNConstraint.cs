namespace Pathfinding
{
	public class PathNNConstraint : NNConstraint
	{
		public new static PathNNConstraint Default
		{
			get
			{
				return null;
			}
		}

		public virtual void SetStart(GraphNode node)
		{
		}
	}
}
