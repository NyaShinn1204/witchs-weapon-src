using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DG.Tweening.Plugins.Core.PathCore
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Size = 24)]
	public struct ControlPoint
	{
		public Vector3 a;

		public Vector3 b;

		public ControlPoint(Vector3 a, Vector3 b)
		{
			this.a = default(Vector3);
			this.b = default(Vector3);
		}

		public static ControlPoint operator +(ControlPoint cp, Vector3 v)
		{
			return default(ControlPoint);
		}
	}
}
