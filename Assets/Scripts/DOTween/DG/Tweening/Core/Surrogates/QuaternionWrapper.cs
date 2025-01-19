using System.Runtime.InteropServices;
using UnityEngine;

namespace DG.Tweening.Core.Surrogates
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public struct QuaternionWrapper
	{
		public Quaternion value;

		public QuaternionWrapper(Quaternion value)
		{
			this.value = default(Quaternion);
		}

		public static implicit operator Quaternion(QuaternionWrapper v)
		{
			return default(Quaternion);
		}

		public static implicit operator QuaternionWrapper(Quaternion v)
		{
			return default(QuaternionWrapper);
		}
	}
}
