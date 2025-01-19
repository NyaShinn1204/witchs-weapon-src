using System.Runtime.InteropServices;
using UnityEngine;

namespace DG.Tweening.Core.Surrogates
{
	[StructLayout(LayoutKind.Sequential, Size = 12)]
	public struct Vector3Wrapper
	{
		public Vector3 value;

		public Vector3Wrapper(Vector3 value)
		{
			this.value = default(Vector3);
		}

		public static implicit operator Vector3(Vector3Wrapper v)
		{
			return default(Vector3);
		}

		public static implicit operator Vector3Wrapper(Vector3 v)
		{
			return default(Vector3Wrapper);
		}
	}
}
