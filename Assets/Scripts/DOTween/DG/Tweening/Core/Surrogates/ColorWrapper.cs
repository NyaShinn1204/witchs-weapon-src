using System.Runtime.InteropServices;
using UnityEngine;

namespace DG.Tweening.Core.Surrogates
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public struct ColorWrapper
	{
		public Color value;

		public ColorWrapper(Color value)
		{
			this.value = default(Color);
		}

		public static implicit operator Color(ColorWrapper v)
		{
			return default(Color);
		}

		public static implicit operator Color32(ColorWrapper v)
		{
			return default(Color32);
		}

		public static implicit operator ColorWrapper(Color v)
		{
			return default(ColorWrapper);
		}

		public static implicit operator ColorWrapper(Color32 v)
		{
			return default(ColorWrapper);
		}
	}
}
