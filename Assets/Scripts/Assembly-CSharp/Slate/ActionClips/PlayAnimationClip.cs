using UnityEngine;

namespace Slate.ActionClips
{
	public class PlayAnimationClip : ActorActionClip<Animation>, ICrossBlendable, ISubClipContainable, IDirectable
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

		private TransformSnapshot snapShot;

		private Transform mixTransform;

		private AnimationState state;

		private bool isListClip;

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

		private AnimationTrack track
		{
			get
			{
				return null;
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

		protected override void OnExit()
		{
		}

		protected override void OnReverseEnter()
		{
		}
	}
}
