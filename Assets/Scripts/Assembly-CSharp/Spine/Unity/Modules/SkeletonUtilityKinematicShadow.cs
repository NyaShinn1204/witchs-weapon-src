using System.Collections.Generic;
using UnityEngine;

namespace Spine.Unity.Modules
{
	public class SkeletonUtilityKinematicShadow : MonoBehaviour
	{
		private struct TransformPair
		{
			public Transform dest;

			public Transform src;
		}

		public bool detachedShadow;

		public Transform parent;

		public bool hideShadow;

		private GameObject shadowRoot;

		private readonly List<TransformPair> shadowTable;

		private void Start()
		{
		}

		private static void DestroyComponents(Component[] components)
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
