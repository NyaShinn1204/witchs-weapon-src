namespace Pathfinding
{
	public struct PathThreadInfo
	{
		public int threadIndex;

		public AstarPath astar;

		public PathHandler runData;

		private object _lock;

		public object Lock
		{
			get
			{
				return null;
			}
		}

		public PathThreadInfo(int index, AstarPath astar, PathHandler runData)
		{
			threadIndex = 0;
			this.astar = null;
			this.runData = null;
			_lock = null;
		}
	}
}
