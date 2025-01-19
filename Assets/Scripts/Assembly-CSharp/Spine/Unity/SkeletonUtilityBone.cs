using System;
using UnityEngine;

namespace Spine.Unity
{
	[ExecuteInEditMode]
	public class SkeletonUtilityBone : MonoBehaviour
	{
		public enum Mode
		{
			Follow = 0,
			Override = 1
		}

		public string boneName;

		public Transform parentReference;

		public Mode mode;

		public bool position;

		public bool rotation;

		public bool scale;

		public bool zPosition;

		public float overrideAlpha;

		[NonSerialized]
		public SkeletonUtility skeletonUtility;

		[NonSerialized]
		public Bone bone;

		[NonSerialized]
		public bool transformLerpComplete;

		[NonSerialized]
		public bool valid;

		private Transform cachedTransform;

		private Transform skeletonTransform;

		private bool incompatibleTransformMode;

		public bool IncompatibleTransformMode
		{
			get
			{
				return false;
			}
		}

		public void Reset()
		{
		}

		private void OnEnable()
		{
		}

		private void HandleOnReset()
		{
		}

		private void OnDisable()
		{
		}

		public void DoUpdate()
		{
		}

		public static bool BoneTransformModeIncompatible(Bone bone)
		{
			return false;
		}

		public void AddBoundingBox(string skinName, string slotName, string attachmentName)
		{
		}
	}
}
