using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Pathfinding
{
	[StructLayout(LayoutKind.Sequential, Size = 12)]
	public struct Int3
	{
		public int x;

		public int y;

		public int z;

		public const int Precision = 1000;

		public const float FloatPrecision = 1000f;

		public const float PrecisionFactor = 0.001f;

		private static Int3 _zero;

		public static Int3 zero
		{
			get
			{
				return default(Int3);
			}
		}

		public int Item
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float magnitude
		{
			get
			{
				return 0f;
			}
		}

		public int costMagnitude
		{
			get
			{
				return 0;
			}
		}

		public float worldMagnitude
		{
			get
			{
				return 0f;
			}
		}

		public float sqrMagnitude
		{
			get
			{
				return 0f;
			}
		}

		public long sqrMagnitudeLong
		{
			get
			{
				return 0L;
			}
		}

		public int unsafeSqrMagnitude
		{
			get
			{
				return 0;
			}
		}

		[Obsolete]
		public float safeMagnitude
		{
			get
			{
				return 0f;
			}
		}

		[Obsolete]
		public float safeSqrMagnitude
		{
			get
			{
				return 0f;
			}
		}

		public Int3(Vector3 position)
		{
			x = 0;
			y = 0;
			z = 0;
		}

		public Int3(int _x, int _y, int _z)
		{
			x = 0;
			y = 0;
			z = 0;
		}

		public static bool operator ==(Int3 lhs, Int3 rhs)
		{
			return false;
		}

		public static bool operator !=(Int3 lhs, Int3 rhs)
		{
			return false;
		}

		public static explicit operator Int3(Vector3 ob)
		{
			return default(Int3);
		}

		public static explicit operator Vector3(Int3 ob)
		{
			return default(Vector3);
		}

		public static Int3 operator -(Int3 lhs, Int3 rhs)
		{
			return default(Int3);
		}

		public static Int3 operator -(Int3 lhs)
		{
			return default(Int3);
		}

		public static Int3 operator +(Int3 lhs, Int3 rhs)
		{
			return default(Int3);
		}

		public static Int3 operator *(Int3 lhs, int rhs)
		{
			return default(Int3);
		}

		public static Int3 operator *(Int3 lhs, float rhs)
		{
			return default(Int3);
		}

		public static Int3 operator *(Int3 lhs, double rhs)
		{
			return default(Int3);
		}

		public static Int3 operator *(Int3 lhs, Vector3 rhs)
		{
			return default(Int3);
		}

		public static Int3 operator /(Int3 lhs, float rhs)
		{
			return default(Int3);
		}

		public Int3 DivBy2()
		{
			return default(Int3);
		}

		public static float Angle(Int3 lhs, Int3 rhs)
		{
			return 0f;
		}

		public static int Dot(Int3 lhs, Int3 rhs)
		{
			return 0;
		}

		public static long DotLong(Int3 lhs, Int3 rhs)
		{
			return 0L;
		}

		public Int3 Normal2D()
		{
			return default(Int3);
		}

		public Int3 NormalizeTo(int newMagn)
		{
			return default(Int3);
		}

		public static implicit operator string(Int3 ob)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object o)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
