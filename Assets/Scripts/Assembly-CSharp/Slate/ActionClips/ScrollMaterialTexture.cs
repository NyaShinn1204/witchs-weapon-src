using UnityEngine;

namespace Slate.ActionClips
{
	public class ScrollMaterialTexture : ActorActionClip<Renderer>
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		[ShaderPropertyPopup]
		public string propertyName;

		public Vector2 speed;

		public EaseType interpolation;

		private Vector2 originalOffset;

		private Material sharedMat;

		private Material instanceMat;

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
		}

		protected override void OnEnter()
		{
		}

		protected override void OnUpdate(float deltaTime)
		{
		}

		protected override void OnReverse()
		{
		}
	}
}
