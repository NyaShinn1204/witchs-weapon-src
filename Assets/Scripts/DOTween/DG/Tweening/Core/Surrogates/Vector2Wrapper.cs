using System.Runtime.InteropServices;
using UnityEngine;

namespace DG.Tweening.Core.Surrogates
{
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct Vector2Wrapper
	{
		public Vector2 value;

		public Vector2Wrapper(Vector2 value)
		{
			this.value = default(Vector2);
		}

		public Vector2Wrapper(float x, float y)
		{
			value = default(Vector2);
		}

		public static implicit operator Vector2(Vector2Wrapper v)
		{
			return default(Vector2);
		}

		public static implicit operator Vector2Wrapper(Vector2 v)
		{
			return default(Vector2Wrapper);
		}
	}
}
