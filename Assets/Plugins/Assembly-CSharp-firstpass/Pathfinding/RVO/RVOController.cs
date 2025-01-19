using UnityEngine;

namespace Pathfinding.RVO
{
	public class RVOController : MonoBehaviour
	{
		public float radius;

		public float maxSpeed;

		public float height;

		public bool locked;

		public bool lockWhenNotMoving;

		public float agentTimeHorizon;

		[HideInInspector]
		public float obstacleTimeHorizon;

		public float neighbourDist;

		public int maxNeighbours;

		public LayerMask mask;

		public RVOLayer layer;

		[AstarEnumFlag]
		public RVOLayer collidesWith;

		[HideInInspector]
		public float wallAvoidForce;

		[HideInInspector]
		public float wallAvoidFalloff;

		public Vector3 center;

		private IAgent rvoAgent;

		public bool enableRotation;

		public float rotationSpeed;

		private Simulator simulator;

		private float adjustedY;

		private Transform tr;

		private Vector3 desiredVelocity;

		public bool debug;

		private Vector3 lastPosition;

		private static readonly Color GizmoColor;

		public Vector3 position
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 velocity
		{
			get
			{
				return default(Vector3);
			}
		}

		public void OnDisable()
		{
		}

		public void Awake()
		{
		}

		public void OnEnable()
		{
		}

		protected void UpdateAgentProperties()
		{
		}

		public void Move(Vector3 vel)
		{
		}

		public void Teleport(Vector3 pos)
		{
		}

		public void Update()
		{
		}

		public void OnDrawGizmos()
		{
		}
	}
}
