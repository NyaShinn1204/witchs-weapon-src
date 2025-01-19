using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
	public class AnimationLink : NodeLink2
	{
		[Serializable]
		public class LinkClip
		{
			public AnimationClip clip;

			public Vector3 velocity;

			public int loopCount;

			public string name
			{
				get
				{
					return null;
				}
			}
		}

		public string clip;

		public float animSpeed;

		public bool reverseAnim;

		public GameObject referenceMesh;

		public LinkClip[] sequence;

		public string boneRoot;

		private static Transform SearchRec(Transform tr, string name)
		{
			return null;
		}

		public void CalculateOffsets(List<Vector3> trace, out Vector3 endPosition)
		{
			endPosition = default(Vector3);
		}

		public override void OnDrawGizmosSelected()
		{
		}
	}
}
