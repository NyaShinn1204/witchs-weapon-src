using UnityEngine;

namespace Slate.ActionClips
{
	public class AnimateOnPath : ActorActionClip
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		[SerializeField]
		[HideInInspector]
		private float _blendIn;

		[Required]
		public Path path;

		[AnimatableParameter]
		public float positionOnPath;

		[AnimatableParameter]
		[PositionHandle]
		[ShowTrajectory]
		public Vector3 lookAtTargetPosition;

		public EaseType blendInterpolation;

		private Vector3 lastPos;

		private Quaternion lastRot;

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
			set
			{
			}
		}

		public override bool isValid
		{
			get
			{
				return false;
			}
		}

		public override TransformSpace defaultTransformSpace
		{
			get
			{
				return default(TransformSpace);
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
