using UnityEngine;

namespace Slate
{
	public class CameraShot : DirectorActionClip
	{
		public enum BlendInEffectType
		{
			None = 0,
			FadeIn = 1,
			CrossDissolve = 2,
			EaseIn = 3
		}

		public enum BlendOutEffectType
		{
			None = 0,
			FadeOut = 1
		}

		public enum ShotAnimationMode
		{
			UseInternal = 0,
			UseExternalAnimationClip = 1
		}

		[SerializeField]
		[HideInInspector]
		private float _length;

		[SerializeField]
		[HideInInspector]
		private float _blendIn;

		[SerializeField]
		[HideInInspector]
		private float _blendOut;

		[SerializeField]
		[HideInInspector]
		private ShotCamera _targetShot;

		[HideInInspector]
		public BlendInEffectType blendInEffect;

		[HideInInspector]
		public BlendOutEffectType blendOutEffect;

		[HideInInspector]
		public float steadyCamEffect;

		private Color lastFadeColor;

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

		public new GameObject actor
		{
			get
			{
				return null;
			}
		}

		public CameraShot previousShot { get; private set; }

		public ShotCamera targetShot
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private CameraTrack track
		{
			get
			{
				return null;
			}
		}

		[AnimatableParameter]
		public Vector3 position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[AnimatableParameter]
		public Vector3 rotation
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[AnimatableParameter]
		public float fieldOfView
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[AnimatableParameter]
		public float focalPoint
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[AnimatableParameter]
		public float focalRange
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected override void OnAfterValidate()
		{
		}

		protected override void OnRootEnabled()
		{
		}

		protected override void OnRootDisabled()
		{
		}

		protected override void OnRootUpdated(float time, float previousTime)
		{
		}

		protected override void OnEnter()
		{
		}

		protected override void OnUpdate(float time, float previousTime)
		{
		}

		protected override void OnReverse()
		{
		}
	}
}
