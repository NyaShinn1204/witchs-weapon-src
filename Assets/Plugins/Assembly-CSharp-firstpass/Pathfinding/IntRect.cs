using System.Runtime.InteropServices;
using UnityEngine;

namespace Pathfinding
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public struct IntRect
	{
		public int xmin;

		public int ymin;

		public int xmax;

		public int ymax;

		private static readonly int[] Rotations;

		public int Width
		{
			get
			{
				return 0;
			}
		}

		public int Height
		{
			get
			{
				return 0;
			}
		}

		public IntRect(int xmin, int ymin, int xmax, int ymax)
		{
			this.xmin = 0;
			this.ymin = 0;
			this.xmax = 0;
			this.ymax = 0;
		}

		public bool Contains(int x, int y)
		{
			return false;
		}

		public bool IsValid()
		{
			return false;
		}

		public static bool operator ==(IntRect a, IntRect b)
		{
			return false;
		}

		public static bool operator !=(IntRect a, IntRect b)
		{
			return false;
		}

		public override bool Equals(object _b)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static IntRect Intersection(IntRect a, IntRect b)
		{
			return default(IntRect);
		}

		public static bool Intersects(IntRect a, IntRect b)
		{
			return false;
		}

		public static IntRect Union(IntRect a, IntRect b)
		{
			return default(IntRect);
		}

		public IntRect ExpandToContain(int x, int y)
		{
			return default(IntRect);
		}

		public IntRect Expand(int range)
		{
			return default(IntRect);
		}

		public IntRect Rotate(int r)
		{
			return default(IntRect);
		}

		public IntRect Offset(Int2 offset)
		{
			return default(IntRect);
		}

		public IntRect Offset(int x, int y)
		{
			return default(IntRect);
		}

		public override string ToString()
		{
			return null;
		}

		public void DebugDraw(Matrix4x4 matrix, Color col)
		{
		}
	}
}
