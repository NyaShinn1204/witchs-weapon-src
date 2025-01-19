using System;
using UnityEngine;

namespace Slate.ActionClips
{
	[Obsolete]
	public class SetParentTemporary : ActorActionClip
	{
		public float _length;

		public Transform newParent;

		public bool matchPosition;

		public bool matchRotation;

		public bool matchScale;

		private Transform originalParent;

		private Vector3 originalPos;

		private Quaternion originalRot;

		private Vector3 originalScale;

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

		protected override void OnUpdate(float deltaTime)
		{
		}

		protected override void OnReverse()
		{
		}
	}
}
