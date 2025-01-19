using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	public class RaycastModifier : MonoModifier
	{
		[HideInInspector]
		public bool useRaycasting;

		[HideInInspector]
		public LayerMask mask;

		[HideInInspector]
		public bool thickRaycast;

		[HideInInspector]
		public float thickRaycastRadius;

		[HideInInspector]
		public Vector3 raycastOffset;

		[HideInInspector]
		public bool subdivideEveryIter;

		public int iterations;

		[HideInInspector]
		public bool useGraphRaycasting;

		private static List<Vector3> nodes;

		public override ModifierData input
		{
			get
			{
				return default(ModifierData);
			}
		}

		public override ModifierData output
		{
			get
			{
				return default(ModifierData);
			}
		}

		public override void Apply(Path p, ModifierData source)
		{
		}

		public bool ValidateLine(GraphNode n1, GraphNode n2, Vector3 v1, Vector3 v2)
		{
			return false;
		}
	}
}
