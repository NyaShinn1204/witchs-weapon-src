using UnityEngine;

namespace Slate.ActionClips
{
	public class CharacterLookAt : ActorActionClip<Character>
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

		public EaseType interpolation;

		[AnimatableParameter]
		public float weight;

		public PositionParameter targetPosition;

		private Quaternion wasNeckRot;

		private Quaternion wasHeadRot;

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

		protected override void OnCreate()
		{
		}

		protected override void OnAfterValidate()
		{
		}

		protected override void OnEnter()
		{
		}

		protected override void OnUpdate(float time)
		{
		}

		protected override void OnReverse()
		{
		}
	}
}
