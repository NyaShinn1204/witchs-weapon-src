using UnityEngine;

namespace Slate.ActionClips
{
	public class AnimateAmbientLighting : DirectorActionClip
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
		public float ambientIntensity;

		[AnimatableParameter]
		public Color ambientColor;

		private float wasIntensity;

		private Color wasColor;

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
