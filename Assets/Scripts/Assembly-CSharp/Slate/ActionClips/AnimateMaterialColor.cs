using UnityEngine;

namespace Slate.ActionClips
{
	public class AnimateMaterialColor : ActorActionClip<Renderer>
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

		[ShaderPropertyPopup]
		public string propertyName;

		[AnimatableParameter]
		public Color color;

		public EaseType interpolation;

		private Color originalColor;

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

		protected override void OnEnter()
		{
		}

		protected override void OnReverseEnter()
		{
		}

		protected override void OnUpdate(float deltaTime)
		{
		}

		protected override void OnReverse()
		{
		}

		protected override void OnExit()
		{
		}

		private void DoSet()
		{
		}

		private void DoReset()
		{
		}
	}
}
