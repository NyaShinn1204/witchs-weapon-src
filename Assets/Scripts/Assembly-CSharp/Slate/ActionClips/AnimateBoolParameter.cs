using UnityEngine;

namespace Slate.ActionClips
{
	public class AnimateBoolParameter : MecanimBaseClip
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		public string parameterName;

		[AnimatableParameter]
		public bool value;

		private bool lastValue;

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

		protected override void OnEnter()
		{
		}

		protected override void OnUpdate(float time)
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
