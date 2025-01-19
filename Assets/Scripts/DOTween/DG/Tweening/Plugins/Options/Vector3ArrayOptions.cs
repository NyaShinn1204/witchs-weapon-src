using System.Runtime.InteropServices;

namespace DG.Tweening.Plugins.Options
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public struct Vector3ArrayOptions : IPlugOptions
	{
		public AxisConstraint axisConstraint;

		public bool snapping;

		internal float[] durations;

		public void Reset()
		{
		}
	}
}
