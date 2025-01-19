using UnityEngine;

namespace Slate.ActionClips
{
	public class AnimateLookAtIK : ActorActionClip<Animator>
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

		[AnimatableParameter]
		public float weight;

		[AnimatableParameter]
		public float bodyWeight;

		[AnimatableParameter]
		public float headWeight;

		[AnimatableParameter]
		public float eyesWeight;

		public PositionParameter targetPosition;

		[AnimatableParameter]
		[ShowTrajectory]
		[PositionHandle]
		public Vector3 targetPositionVector
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
