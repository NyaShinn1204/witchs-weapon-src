using UnityEngine;

namespace Slate.ActionClips
{
	public class AttachObjectPrefab : ActorActionClip
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		[Required]
		public Transform targetPrefab;

		public string childTransformName;

		public Vector3 localPosition;

		public Vector3 localRotation;

		public Vector3 localScale;

		private Transform instance;

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
