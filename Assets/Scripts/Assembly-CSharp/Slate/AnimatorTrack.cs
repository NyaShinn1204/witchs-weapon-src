using System.Collections.Generic;
using Slate.ActionClips;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace Slate
{
	[UniqueElement]
	public class AnimatorTrack : CutsceneTrack
	{
		private const int ROOTMOTION_FRAMERATE = 30;

		public AnimationClip baseAnimationClip;

		public float basePlaybackSpeed;

		public bool useRootMotion;

		private Dictionary<PlayAnimatorClip, int> ports;

		private int activeClips;

		private PlayableGraph graph;

		private AnimationPlayableOutput animationOutput;

		private Playable mixerPlayable;

		private Playable baseClipPlayable;

		private bool useBakedRootMotion;

		private List<Vector3> rmPositions;

		private List<Quaternion> rmRotations;

		private Dictionary<AnimatorControllerParameter, object> wasAnimatorParameters;

		private RuntimeAnimatorController wasController;

		private AnimatorCullingMode wasCullingMode;

		private bool wasRootMotion;

		private bool wasEnabled;

		public Animator animator { get; private set; }

		public override string info
		{
			get
			{
				return null;
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

		protected override void OnReverseEnter()
		{
		}

		protected override void OnExit()
		{
		}

		protected override void OnReverse()
		{
		}

		public void EnableClip(PlayAnimatorClip playAnimClip)
		{
		}

		public void UpdateClip(PlayAnimatorClip playAnimClip, float clipTime, float clipPrevious, float weight)
		{
		}

		public void DisableClip(PlayAnimatorClip playAnimClip)
		{
		}

		private void StoreSet()
		{
		}

		private void Restore()
		{
		}

		private void CreateAndPlayTree()
		{
		}

		private void BakeRootMotion()
		{
		}

		private void ApplyBakedRootMotion(float time)
		{
		}

		private void StoreAnimatorInfo()
		{
		}

		private void RestoreAnimatorInfo()
		{
		}
	}
}
