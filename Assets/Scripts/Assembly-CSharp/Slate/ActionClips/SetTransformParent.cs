using UnityEngine;

namespace Slate.ActionClips
{
	public class SetTransformParent : ActorActionClip
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		public Transform newParent;

		public bool resetPosition;

		public bool resetRotation;

		public bool resetScale;

		private Transform originalParent;

		private Vector3 originalPos;

		private Quaternion originalRot;

		private Vector3 originalScale;

		private bool temporary;

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
