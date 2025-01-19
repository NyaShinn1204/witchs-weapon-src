using UnityEngine;

namespace Slate.ActionClips
{
	public class AnimateLimbIK : ActorActionClip<Animator>
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		[SerializeField]
		[HideInInspector]
		private float _blendIn;

		[SerializeField]
		[HideInInspector]
		private float _blendOut;

		public AvatarIKGoal IKGoal;

		[AnimatableParameter]
		public float weight;

		public TransformationParameter IKTarget;

		private Vector3 lastPos;

		private Quaternion lastRot;

		private float lastWeight;

		private bool isEnter;

		private bool isReverse;

		[AnimatableParameter]
		[ShowTrajectory]
		[PositionHandle]
		public Vector3 targetPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[AnimatableParameter]
		public Vector3 targetRotation
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		private AnimatorDispatcher dispatcher
		{
			get
			{
				return null;
			}
		}

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
			set
			{
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

		public override float blendOut
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected override void OnCreate()
		{
		}

		protected override void OnAfterValidate()
		{
		}

		protected override void OnEnter()
		{
		}

		protected override void OnReverseEnter()
		{
		}

		protected override void OnReverse()
		{
		}

		protected override void OnExit()
		{
		}

		private void OnAnimatorIK(int index)
		{
		}
	}
}
