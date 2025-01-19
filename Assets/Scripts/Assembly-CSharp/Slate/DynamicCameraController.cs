using System;
using UnityEngine;

namespace Slate
{
	[Serializable]
	public class DynamicCameraController
	{
		[Serializable]
		public class Transposer
		{
			public enum TrackingMode
			{
				None = 0,
				OffsetTracking = 1,
				RailTracking = 2
			}

			public enum OffsetMode
			{
				LocalSpace = 0,
				WorldSpace = 1
			}

			public TrackingMode trackingMode;

			public Transform target;

			public Vector3 targetOffset;

			public OffsetMode offsetMode;

			public Vector3 railStart;

			public Vector3 railEnd;

			public float railOffset;

			public float smoothDamping;
		}

		[Serializable]
		public class Composer
		{
			public enum TrackingMode
			{
				None = 0,
				FrameComposition = 1
			}

			public TrackingMode trackingMode;

			public Transform target;

			public Vector3 targetOffset;

			public float targetSize;

			public Vector2 frameCenter;

			public Vector2 frameExtends;

			public float dutchTilt;

			public float smoothDamping;
		}

		private const float MIN_DAMP = 0.1f;

		private const float MAX_DAMP = 10f;

		[SerializeField]
		private Transposer _transposer;

		[SerializeField]
		private Composer _composer;

		private int lastUpdateFrame;

		public Transposer transposer
		{
			get
			{
				return null;
			}
		}

		public Composer composer
		{
			get
			{
				return null;
			}
		}

		public bool controlsPosition
		{
			get
			{
				return false;
			}
		}

		public bool controlsRotation
		{
			get
			{
				return false;
			}
		}

		public void UpdateControllerHard(IDirectableCamera directableCamera, IDirectable directable)
		{
		}

		public void UpdateControllerSoft(IDirectableCamera directableCamera, IDirectable directable)
		{
		}

		private void UpdateController(IDirectableCamera directableCamera, IDirectable directable, bool isHard)
		{
		}
	}
}
