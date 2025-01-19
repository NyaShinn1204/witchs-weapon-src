using System.Runtime.InteropServices;
using UnityEngine;

namespace Pathfinding.RVO
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public struct Line
	{
		public Vector2 point;

		public Vector2 dir;
	}
}
