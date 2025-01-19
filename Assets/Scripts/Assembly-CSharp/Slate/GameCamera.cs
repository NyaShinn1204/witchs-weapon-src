using UnityEngine;

namespace Slate
{
	public class GameCamera : MonoBehaviour, IDirectableCamera
	{
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

		GameObject IDirectableCamera.get_gameObject()
		{
			return null;
		}
	}
}
