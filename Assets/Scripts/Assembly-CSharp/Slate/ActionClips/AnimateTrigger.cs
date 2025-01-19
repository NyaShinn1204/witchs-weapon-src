using UnityEngine;

namespace Slate.ActionClips
{
	public class AnimateTrigger : MecanimBaseClip
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		public string triggerName;

		[AnimatableParameter]
		public bool value;

		public override bool isValid
		{
			get
			{
				return false;
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

		protected override void OnUpdate(float time)
		{
		}
	}
}
