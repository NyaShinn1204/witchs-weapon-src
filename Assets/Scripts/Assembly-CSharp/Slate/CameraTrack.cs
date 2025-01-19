using UnityEngine;

namespace Slate
{
	[UniqueElement]
	public class CameraTrack : CutsceneTrack
	{
		private static CameraTrack activeCameraTrack;

		[SerializeField]
		[HideInInspector]
		private float _startTimeOffset;

		[SerializeField]
		[HideInInspector]
		private float _endTimeOffset;

		[HideInInspector]
		public float _blendIn;

		[HideInInspector]
		public float _blendOut;

		[HideInInspector]
		public EaseType interpolation;

		[HideInInspector]
		public float cineBoxFadeTime;

		[HideInInspector]
		public float appliedSmoothing;

		[HideInInspector]
		public Camera exitCameraOverride;

		[SerializeField]
		[HideInInspector]
		private bool _isSmoothLookAtCamTarget;

		[SerializeField]
		[HideInInspector]
		private Transform _camTarget;

		private GameCamera entryCamera;

		public bool isSmoothLookAt
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Transform camTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CameraShot firstShot { get; private set; }

		public CameraShot lastShot { get; private set; }

		public CameraShot currentShot { get; set; }

		public override string info
		{
			get
			{
				return null;
			}
		}

		public override float startTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override float endTime
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

		protected override void OnUpdate(float time, float previousTime)
		{
		}

		protected override void OnExit()
		{
		}

		protected override void OnReverseEnter()
		{
		}

		protected override void OnReverse()
		{
		}
	}
}
