using UnityEngine;

namespace Slate
{
	public class AnimationTrack : CutsceneTrack
	{
		[SerializeField]
		private float _weight;

		[SerializeField]
		private float _blendIn;

		[SerializeField]
		private float _blendOut;

		[SerializeField]
		private AnimationBlendMode _animationBlendMode;

		[SerializeField]
		private string _mixTransformName;

		private Animation anim;

		private AnimationState state;

		public override string info
		{
			get
			{
				return null;
			}
		}

		public override float blendIn
		{
			get
			{
				return 0f;
			}
		}

		public override float blendOut
		{
			get
			{
				return 0f;
			}
		}

		public float weight
		{
			get
			{
				return 0f;
			}
		}

		public AnimationBlendMode animationBlendMode
		{
			get
			{
				return default(AnimationBlendMode);
			}
			private set
			{
			}
		}

		public string mixTransformName
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		protected override bool OnInitialize()
		{
			return false;
		}

		protected override void OnEnter()
		{
		}

		protected override void OnUpdate(float time, float previousTime)
		{
		}

		protected override void OnExit()
		{
		}

		protected override void OnReverseEnter()
		{
		}

		protected override void OnReverse()
		{
		}

		public float GetAnimationWeight()
		{
			return 0f;
		}

		public Transform GetMixTransform()
		{
			return null;
		}
	}
}
