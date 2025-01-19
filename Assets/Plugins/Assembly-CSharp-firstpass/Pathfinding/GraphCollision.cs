using System;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	public class GraphCollision
	{
		public ColliderType type;

		public float diameter;

		public float height;

		public float collisionOffset;

		public RayDirection rayDirection;

		public LayerMask mask;

		public LayerMask heightMask;

		public float fromHeight;

		public bool thickRaycast;

		public float thickRaycastDiameter;

		public Vector3 up;

		private Vector3 upheight;

		private float finalRadius;

		private float finalRaycastRadius;

		public const float RaycastErrorMargin = 0.005f;

		public bool collisionCheck;

		public bool heightCheck;

		public bool unwalkableWhenNoGround;

		public bool use2D;

		public void Initialize(Matrix4x4 matrix, float scale)
		{
		}

		public bool Check(Vector3 position)
		{
			return false;
		}

		public Vector3 CheckHeight(Vector3 position)
		{
			return default(Vector3);
		}

		public Vector3 CheckHeight(Vector3 position, out RaycastHit hit, out bool walkable)
		{
			hit = default(RaycastHit);
			walkable = default(bool);
			return default(Vector3);
		}

		public Vector3 Raycast(Vector3 origin, out RaycastHit hit, out bool walkable)
		{
			hit = default(RaycastHit);
			walkable = default(bool);
			return default(Vector3);
		}

		public RaycastHit[] CheckHeightAll(Vector3 position)
		{
			return null;
		}
	}
}
