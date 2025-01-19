using UnityEngine;

namespace Slate.ActionClips
{
	public class AnimateActorVisibility : ActorActionClip
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		[AnimatableParameter]
		public bool visible;

		private bool wasVisible;

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

		protected override void OnCreate()
		{
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
	}
}
