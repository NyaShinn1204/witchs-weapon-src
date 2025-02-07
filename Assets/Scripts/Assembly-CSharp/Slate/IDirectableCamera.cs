using UnityEngine;

namespace Slate
{
	public interface IDirectableCamera
	{
		GameObject gameObject { get; }

		Camera cam { get; }

		Vector3 position { get; set; }

		Quaternion rotation { get; set; }

		float fieldOfView { get; set; }

		float focalPoint { get; set; }

		float focalRange { get; set; }
	}
}
