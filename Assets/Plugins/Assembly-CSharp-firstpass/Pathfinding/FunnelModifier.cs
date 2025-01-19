using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	public class FunnelModifier : MonoModifier
	{
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

		public bool RunFunnel(List<Vector3> left, List<Vector3> right, List<Vector3> funnelPath)
		{
			return false;
		}
	}
}
