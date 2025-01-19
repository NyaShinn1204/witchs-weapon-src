using UnityEngine;

namespace Slate.ActionClips
{
	public class RotateBy : ActorActionClip
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		public Vector3 rotation;

		public bool perSecond;

		public EaseType interpolation;

		private Vector3 originalRot;

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
