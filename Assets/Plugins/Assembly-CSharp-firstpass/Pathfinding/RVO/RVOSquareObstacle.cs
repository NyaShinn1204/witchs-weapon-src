using UnityEngine;

namespace Pathfinding.RVO
{
	public class RVOSquareObstacle : RVOObstacle
	{
		public float height;

		public Vector2 size;

		protected override bool StaticObstacle
		{
			get
			{
				return false;
			}
		}

		protected override bool ExecuteInEditor
		{
			get
			{
				return false;
			}
		}

		protected override bool LocalCoordinates
		{
			get
			{
				return false;
			}
		}

		protected override bool AreGizmosDirty()
		{
			return false;
		}

		protected override void CreateObstacles()
		{
		}
	}
}
