namespace Pathfinding
{
	public class FloodPathConstraint : NNConstraint
	{
		private FloodPath path;

		public FloodPathConstraint(FloodPath path)
		{
		}

		public override bool Suitable(GraphNode node)
		{
			return false;
		}
	}
}
