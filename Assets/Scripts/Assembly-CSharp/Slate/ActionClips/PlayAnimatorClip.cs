using UnityEngine;

namespace Slate.ActionClips
{
	public class PlayAnimatorClip : ActorActionClip, ICrossBlendable, ISubClipContainable, IDirectable
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

		[Required]
		public AnimationClip animationClip;

		public float clipOffset;

		public float playbackSpeed;

		[AnimatableParameter]
		public Vector2 steerLocalRotation;

		private Vector3 wasRotation;

		float ISubClipContainable.subClipOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override string info
		{
			get
			{
				return null;
			}
		}

		public override bool isValid
		{
			get
			{
				return false;
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

		private AnimatorTrack track
		{
			get
			{
				return null;
			}
		}

		private Animator animator
		{
			get
			{
				return null;
			}
		}

		protected override void OnEnter()
		{
		}

		protected override void OnReverseEnter()
		{
		}

		protected override void OnUpdate(float time, float previousTime)
		{
		}

		protected override void OnExit()
		{
		}

		protected override void OnReverse()
		{
		}
	}
}
