using System;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	public class AstarColor
	{
		public Color _NodeConnection;

		public Color _UnwalkableNode;

		public Color _BoundsHandles;

		public Color _ConnectionLowLerp;

		public Color _ConnectionHighLerp;

		public Color _MeshEdgeColor;

		public Color _MeshColor;

		public Color[] _AreaColors;

		public static Color NodeConnection;

		public static Color UnwalkableNode;

		public static Color BoundsHandles;

		public static Color ConnectionLowLerp;

		public static Color ConnectionHighLerp;

		public static Color MeshEdgeColor;

		public static Color MeshColor;

		private static Color[] AreaColors;

		public static Color GetAreaColor(uint area)
		{
			return default(Color);
		}

		public void OnEnable()
		{
		}
	}
}
