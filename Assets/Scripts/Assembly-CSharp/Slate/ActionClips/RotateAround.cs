using UnityEngine;

namespace Slate.ActionClips
{
	public class RotateAround : ActorActionClip
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		public Vector3 rotation;

		public bool perSecond;

		public bool lookTarget;

		public EaseType interpolation;

		public PositionParameter targetPosition;

		private Vector3 originalPos;

		private Quaternion originalRot;

		private Vector3 targetOriginalPos;

		[AnimatableParameter]
		[ShowTrajectory]
		[PositionHandle]
		public Vector3 targetPositionVector
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

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
		}

		protected override void OnAfterValidate()
		{
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
