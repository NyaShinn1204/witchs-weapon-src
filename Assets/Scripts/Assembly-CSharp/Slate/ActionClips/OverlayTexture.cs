using UnityEngine;

namespace Slate.ActionClips
{
	public class OverlayTexture : DirectorActionClip
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

		public Texture texture;

		[AnimatableParameter]
		public Color color;

		[AnimatableParameter]
		public Vector2 scale;

		[AnimatableParameter]
		public Vector2 position;

		public EaseType interpolation;

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

		protected override void OnUpdate(float deltaTime)
		{
		}
	}
}
