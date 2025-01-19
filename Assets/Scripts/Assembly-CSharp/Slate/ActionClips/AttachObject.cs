using UnityEngine;

namespace Slate.ActionClips
{
	public class AttachObject : ActorActionClip
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		[Required]
		public Transform targetObject;

		public string childTransformName;

		public Vector3 localPosition;

		public Vector3 localRotation;

		public Vector3 localScale;

		private TransformSnapshot snapshot;

		private bool temporary;

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

		protected override void OnEnter()
		{
		}

		protected override void OnReverseEnter()
		{
		}

		protected override void OnExit()
		{
		}

		protected override void OnReverse()
		{
		}

		private void Do()
		{
		}

		private void UnDo()
		{
		}
	}
}
