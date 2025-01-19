using UnityEngine;

namespace Pathfinding
{
	public class NodeLink : GraphModifier
	{
		public Transform end;

		public float costFactor;

		public bool oneWay;

		public bool deleteConnection;

		public Transform Start
		{
			get
			{
				return null;
			}
		}

		public Transform End
		{
			get
			{
				return null;
			}
		}

		public override void OnPostScan()
		{
		}

		public void InternalOnPostScan()
		{
		}

		public override void OnGraphsPostUpdate()
		{
		}

		public virtual void Apply()
		{
		}

		public void OnDrawGizmos()
		{
		}

		private void DrawGizmoBezier(Vector3 p1, Vector3 p2)
		{
		}
	}
}
