using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Pathfinding.RVO;
using UnityEngine;

namespace Pathfinding
{
	public class RichAI : MonoBehaviour
	{
		public Transform target;

		public bool drawGizmos;

		public bool repeatedlySearchPaths;

		public float repathRate;

		public float maxSpeed;

		public float acceleration;

		public float slowdownTime;

		public float rotationSpeed;

		public float endReachedDistance;

		public float wallForce;

		public float wallDist;

		public Vector3 gravity;

		public bool raycastingForGroundPlacement;

		public LayerMask groundMask;

		public float centerOffset;

		public RichFunnel.FunnelSimplification funnelSimplification;

		public Animation anim;

		public bool preciseSlowdown;

		public bool slowWhenNotFacingTarget;

		private Vector3 velocity;

		protected RichPath rp;

		protected Seeker seeker;

		protected Transform tr;

		private CharacterController controller;

		private RVOController rvoController;

		private Vector3 lastTargetPoint;

		private Vector3 currentTargetDirection;

		protected bool waitingForPathCalc;

		protected bool canSearchPath;

		protected bool delayUpdatePath;

		protected bool traversingSpecialPath;

		protected bool lastCorner;

		private float distanceToWaypoint;

		protected List<Vector3> buffer;

		protected List<Vector3> wallBuffer;

		private bool startHasRun;

		protected float lastRepath;

		private static float deltaTime;

		public static readonly Color GizmoColorRaycast;

		public static readonly Color GizmoColorPath;

		public Vector3 Velocity
		{
			get
			{
				return default(Vector3);
			}
		}

		public bool TraversingSpecial
		{
			get
			{
				return false;
			}
		}

		public Vector3 TargetPoint
		{
			get
			{
				return default(Vector3);
			}
		}

		public bool ApproachingPartEndpoint
		{
			get
			{
				return false;
			}
		}

		public bool ApproachingPathEndpoint
		{
			get
			{
				return false;
			}
		}

		public float DistanceToNextWaypoint
		{
			get
			{
				return 0f;
			}
		}

		private void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public virtual void UpdatePath()
		{
		}

		[DebuggerHidden]
		private IEnumerator SearchPaths()
		{
			return null;
		}

		private void OnPathComplete(Path p)
		{
		}

		private void NextPart()
		{
		}

		protected virtual void OnTargetReached()
		{
		}

		protected virtual Vector3 UpdateTarget(RichFunnel fn)
		{
			return default(Vector3);
		}

		protected virtual void Update()
		{
		}

		private Vector3 RaycastPosition(Vector3 position, float lasty)
		{
			return default(Vector3);
		}

		private bool RotateTowards(Vector3 trotdir)
		{
			return false;
		}

		public void OnDrawGizmos()
		{
		}

		[DebuggerHidden]
		private IEnumerator TraverseSpecial(RichSpecial rs)
		{
			return null;
		}
	}
}
