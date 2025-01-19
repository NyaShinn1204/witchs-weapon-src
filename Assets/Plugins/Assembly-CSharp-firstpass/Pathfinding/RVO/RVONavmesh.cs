using System.Collections.Generic;

namespace Pathfinding.RVO
{
	public class RVONavmesh : GraphModifier
	{
		public float wallHeight;

		private List<ObstacleVertex> obstacles;

		private Simulator lastSim;

		public override void OnPostCacheLoad()
		{
		}

		public override void OnLatePostScan()
		{
		}

		public void RemoveObstacles()
		{
		}

		public void AddGraphObstacles(Simulator sim, NavGraph graph)
		{
		}
	}
}
