using UnityEngine;

namespace Slate
{
	public class ShotCamera : MonoBehaviour, IDirectableCamera
	{
		public const string DEFAULT_NAME = "Shot Camera";

		[SerializeField]
		private DynamicCameraController _dynamicController;

		[SerializeField]
		private float _focalPoint;

		[SerializeField]
		private float _focalRange;

		private Camera _cam;

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

		public Vector3 localPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 localEulerAngles
		{
			get
			{
				return default(Vector3);
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

		public DynamicCameraController dynamicController
		{
			get
			{
				return null;
			}
		}

		public bool dynamicControlledPosition
		{
			get
			{
				return false;
			}
		}

		public bool dynamicControlledRotation
		{
			get
			{
				return false;
			}
		}

		private void Awake()
		{
		}

		public void UpdateDynamicControllerHard(IDirectable directable)
		{
		}

		public void UpdateDynamicControllerSoft(IDirectable directable)
		{
		}

		public RenderTexture GetRenderTexture(int width, int height)
		{
			return null;
		}

		public static ShotCamera Create(Transform targetParent = null)
		{
			return null;
		}

		public static ShotCamera Find(string shotName)
		{
			return null;
		}

		GameObject IDirectableCamera.get_gameObject()
		{
			return null;
		}
	}
}
