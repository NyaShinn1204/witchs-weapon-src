namespace Pathfinding
{
	public class PathEndingCondition
	{
		protected Path p;

		protected PathEndingCondition()
		{
		}

		public PathEndingCondition(Path p)
		{
		}

		public virtual bool TargetFound(PathNode node)
		{
			return false;
		}
	}
}
