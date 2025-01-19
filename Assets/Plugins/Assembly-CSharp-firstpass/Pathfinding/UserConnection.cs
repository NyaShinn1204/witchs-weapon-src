using UnityEngine;

namespace Pathfinding
{
	public class UserConnection
	{
		public Vector3 p1;

		public Vector3 p2;

		public ConnectionType type;

		public bool doOverrideCost;

		public int overrideCost;

		public bool oneWay;

		public bool enable;

		public float width;

		public bool doOverrideWalkability;

		public bool doOverridePenalty;

		public uint overridePenalty;
	}
}
