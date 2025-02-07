using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class PlayAnimationAdvanced : ActionTask<Animation>
	{
		[RequiredField]
		public BBParameter<AnimationClip> animationClip;

		public WrapMode animationWrap;

		public AnimationBlendMode blendMode;

		public float playbackSpeed;

		public float crossFadeTime;

		public PlayDirections playDirection;

		public BBParameter<string> mixTransformName;

		public BBParameter<int> animationLayer;

		public bool queueAnimation;

		public bool waitActionFinish;

		private string animationToPlay;

		private int dir;

		private Transform mixTransform;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override string OnInit()
		{
			return null;
		}

		protected override void OnExecute()
		{
		}

		protected override void OnUpdate()
		{
		}

		private Transform FindTransform(Transform parent, string name)
		{
			return null;
		}
	}
}
