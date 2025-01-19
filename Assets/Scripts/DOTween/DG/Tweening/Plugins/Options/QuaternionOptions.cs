using System.Runtime.InteropServices;
using UnityEngine;

namespace DG.Tweening.Plugins.Options
{
	[StructLayout(LayoutKind.Sequential, Size = 20)]
	public struct QuaternionOptions : IPlugOptions
	{
		internal RotateMode rotateMode;

		internal AxisConstraint axisConstraint;

		internal Vector3 up;

		public void Reset()
		{
		}
	}
}
