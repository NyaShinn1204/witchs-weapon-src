using System;
using UnityEngine;

namespace Slate
{
	public class DirectorCamera : MonoBehaviour, IDirectableCamera
	{
		[SerializeField]
		[HideInInspector]
		private bool _matchMainWhenActive;

		[SerializeField]
		[HideInInspector]
		private bool _setMainWhenActive;

		[SerializeField]
		[HideInInspector]
		private bool _autoHandleActiveState;

		[SerializeField]
		[HideInInspector]
		private bool _ignoreFOVChanges;

		[SerializeField]
		[HideInInspector]
		private bool _dontDestroyOnLoad;

		public const float MAX_DAMP = 3f;

		private static DirectorCamera _current;

		private static Camera _cam;

		private static IDirectableCamera lastTargetShot;

		private static float noiseTimer;

		private static Vector3 noisePosOffset;

		private static Vector3 noiseRotOffset;

		private static Vector3 noiseTargetPosOffset;

		private static Vector3 noiseTargetRotOffset;

		private static Vector3 noiseCamPosVel;

		private static Vector3 noiseCamRotVel;

		public static DirectorCamera current
		{
			get
			{
				return null;
			}
		}

		public Camera cam
		{
			get
			{
				return null;
			}
		}

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

		public Quaternion rotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

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

		public float focalPoint { get; set; }

		public float focalRange { get; set; }

		public static bool matchMainWhenActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool setMainWhenActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool autoHandleActiveState
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool ignoreFOVChanges
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool dontDestroyOnLoad
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static Camera renderCamera
		{
			get
			{
				return null;
			}
		}

		public static GameCamera gameCamera { get; set; }

		public static bool isEnabled { get; private set; }

		public static event Action<IDirectableCamera> OnCut
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action OnActivate
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action OnDeactivate
		{
			add
			{
			}
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private Camera CreateRenderCamera()
		{
			return null;
		}

		public static void Enable()
		{
		}

		public static void Disable()
		{
		}

		public static void Update(IDirectableCamera source, IDirectableCamera target, EaseType interpolation, float weight, float damping = 0f, bool isLookAt = false, Transform lookAtTgt = null)
		{
		}

		public static void ApplyNoise(float magnitude, float weight)
		{
		}

		GameObject IDirectableCamera.get_gameObject()
		{
			return null;
		}
	}
}
