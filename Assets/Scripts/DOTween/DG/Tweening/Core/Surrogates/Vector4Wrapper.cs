using System.Runtime.InteropServices;
using UnityEngine;

namespace DG.Tweening.Core.Surrogates
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public struct Vector4Wrapper
	{
		public Vector4 value;

		public Vector4Wrapper(Vector4 value)
		{
			this.value = default(Vector4);
		}

		public static implicit operator Vector4(Vector4Wrapper v)
		{
			return default(Vector4);
		}

		public static implicit operator Vector4Wrapper(Vector4 v)
		{
			return default(Vector4Wrapper);
		}
	}
}
