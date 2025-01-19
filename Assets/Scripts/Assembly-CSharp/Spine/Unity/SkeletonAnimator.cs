using System.Collections.Generic;
using UnityEngine;

namespace Spine.Unity
{
	public class SkeletonAnimator : SkeletonRenderer, ISkeletonAnimation
	{
		public enum MixMode
		{
			AlwaysMix = 0,
			MixNext = 1,
			SpineStyle = 2
		}

		public class SpineMecanimTranslator
		{
			private readonly Dictionary<int, Animation> animationTable;

			private readonly Dictionary<AnimationClip, int> clipNameHashCodeTable;

			private Animator animator;

			private List<Animation> previousAnimations;

			public bool autoReset;

			public void Initialize(Animator animator, SkeletonDataAsset skeletonDataAsset)
			{
			}

			public void Apply(Skeleton skeleton, ref MixMode[] layerMixModes)
			{
			}

			private static float AnimationTime(float normalizedTime, float clipLength, bool loop, bool reversed)
			{
				return 0f;
			}

			private static float AnimationTime(float normalizedTime, float clipLength, bool reversed)
			{
				return 0f;
			}

			private int NameHashCode(AnimationClip clip)
			{
				return 0;
			}
		}

		public MixMode[] layerMixModes;

		public SpineMecanimTranslator translator;

		protected event UpdateBonesDelegate _UpdateLocal
		{
			add
			{
			}
			remove
			{
			}
		}

		protected event UpdateBonesDelegate _UpdateWorld
		{
			add
			{
			}
			remove
			{
			}
		}

		protected event UpdateBonesDelegate _UpdateComplete
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UpdateBonesDelegate UpdateLocal
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UpdateBonesDelegate UpdateWorld
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UpdateBonesDelegate UpdateComplete
		{
			add
			{
			}
			remove
			{
			}
		}

		public override void Initialize(bool overwrite)
		{
		}

		public void Update()
		{
		}
	}
}
