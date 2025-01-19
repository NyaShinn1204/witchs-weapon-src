using UnityEngine;
using UnityEngine.AI;

namespace Slate.ActionClips
{
	public class PathfindTo : ActorActionClip
	{
		[SerializeField]
		[HideInInspector]
		private float _blendIn;

		public float speed;

		public PositionParameter targetPosition;

		private NavMeshPath navPath;

		private Vector3[] pathPoints;

		private Vector3 originalPos;

		private Quaternion originalRot;

		private Vector3 lastFrom;

		private Vector3 lastTo;

		private bool lockCalc;

		public override string info
		{
			get
			{
				return null;
			}
		}

		public override float length
		{
			get
			{
				return 0f;
			}
		}

		public override float blendIn
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected override void OnEnter()
		{
		}

		protected override void OnUpdate(float time)
		{
		}

		protected override void OnReverse()
		{
		}

		private void TryCalculatePath()
		{
		}
	}
}
