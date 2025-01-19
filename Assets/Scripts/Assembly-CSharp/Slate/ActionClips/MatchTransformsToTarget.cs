using UnityEngine;

namespace Slate.ActionClips
{
	public class MatchTransformsToTarget : ActorActionClip
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

		[Required]
		public Transform targetObject;

		public EaseType interpolation;

		public bool matchPosition;

		public Vector3 positionOffset;

		public bool matchRotation;

		public Vector3 rotationOffset;

		public bool matchScale;

		public Vector3 scaleOffset;

		private Vector3 lastPos;

		private Quaternion lastRot;

		private Vector3 lastScale;

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

		public override bool isValid
		{
			get
			{
				return false;
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
