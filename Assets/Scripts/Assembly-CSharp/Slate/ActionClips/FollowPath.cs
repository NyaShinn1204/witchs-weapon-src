using UnityEngine;

namespace Slate.ActionClips
{
	public class FollowPath : ActorActionClip
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
		public Path path;

		public bool useSpeed;

		public float speed;

		public float lookAhead;

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

		protected override void OnUpdate(float time)
		{
		}

		protected override void OnReverse()
		{
		}
	}
}
